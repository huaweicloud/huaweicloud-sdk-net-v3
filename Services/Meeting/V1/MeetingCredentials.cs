using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public enum AuthTypeEnum
{
    // 账号密码鉴权方式
    ACCOUNT = 0,
    // APPID鉴权方式
    APPID = 1,
}

public enum TenantSceneEnum
{
    // 单租户场景
    SINGLE_TENANT = 0,
    // 多租户场景
    MULTI_TENANT = 1,
}

namespace HuaweiCloud.SDK.Meeting.V1
{
    public class MeetingCredentials : Credentials<MeetingCredentials>
    {
        private static readonly Dictionary<string, string> PathParamDict = new Dictionary<string, string>();

        private string token = "";
        private DateTime? lastTokenDate;
        private AuthTypeEnum authTypeEnum = AuthTypeEnum.ACCOUNT;
        private TenantSceneEnum tenantSceneEnum = TenantSceneEnum.SINGLE_TENANT;
        private string appId = "";
        private string appKey = "";
        private string corpId = "";
        private string userId = "";
        private string deptCode = "";
        private string clientType = "";
        private string userName = "";
        private string userPassword = "";
        
        public MeetingCredentials(string userName, string userPassword)
        {
            if (userName != "")
            {
                this.userName = userName;
            }
            
            if (userPassword != "")
            {
                this.userPassword = userPassword;
            }
        }
        
        public override Dictionary<string, string> GetPathParamDictionary()
        {
            return PathParamDict;
        }

        public void WithAuthTypeEnum(AuthTypeEnum authTypeEnum)
        {
            this.authTypeEnum = authTypeEnum;
        }
        
        public void WithTenantSceneEnum(TenantSceneEnum tenantSceneEnum)
        {
            this.tenantSceneEnum = tenantSceneEnum;
        }
        
        public void WithAppId(string appId)
        {
            this.appId = appId;
        }
        
        public void WithAppKey(string appKey)
        {
            this.appKey = appKey;
        }
        
        public void WithCorpId(string corpId)
        {
            this.corpId = corpId;
        }
        
        public void WithUserId(string userId)
        {
            this.userId = userId;
        }
        
        public void WithDeptCode(string deptCode)
        {
            this.deptCode = deptCode;
        }
        
        public void WithClientType(string clientType)
        {
            this.clientType = clientType;
        }

        private string SignHmac256(long expireTime, string nonce)
        {
            string[] dataParam;
            if (tenantSceneEnum == TenantSceneEnum.MULTI_TENANT)
            {
                dataParam = new string[] { appId, corpId, userId, expireTime.ToString(), nonce };
            }
            else
            {
                dataParam = new string[] { appId, userId, expireTime.ToString(), nonce };
            }

            string data = string.Join(":", dataParam);
            using (var hMacSha256 = new HMACSHA256(Encoding.UTF8.GetBytes(appKey)))
            {
                var result = hMacSha256.ComputeHash(Encoding.UTF8.GetBytes(data));
                return BitConverter.ToString(result, 0).Replace("-", string.Empty).ToUpper();
            }
        }
        
        public override Task<HttpRequest> SignAuthRequest(HttpRequest request, SdkHttpClient client)
        {

            var httpRequestTask = Task<HttpRequest>.Factory.StartNew(() =>
            {
                return this.ProcessRequest(request, client);
            });

            return httpRequestTask;
        }

        private HttpRequest ProcessRequest(HttpRequest request, SdkHttpClient client)
        {
            var nowTime = DateTime.Now;
            bool isExpire = true;
            TimeSpan? timeDiff = nowTime - lastTokenDate;
            if (timeDiff != null && timeDiff <= TimeSpan.FromHours(12))
            {
                isExpire = false;
            }

            if (this.token == "" || isExpire)
            {
                string url = "";
                string content = "";
                string authorization = "";
                if (authTypeEnum == AuthTypeEnum.ACCOUNT)
                {
                    var body = new { account = userName, clientType = 72 };
                    content = JsonConvert.SerializeObject(body);
                    url = request.Host + "/v1/usg/acs/auth/account";
                    byte[] bytes = Encoding.UTF8.GetBytes(this.userName + ':' + this.userPassword);
                    authorization = "Basic " + Convert.ToBase64String(bytes);
                }
                else
                {
                    string nonce = Guid.NewGuid().ToString();
                    // 签名信息有效期（10分钟）
                    long expireTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds() + 60 * 10;
                    authorization = "HMAC-SHA256 signature=" + SignHmac256(expireTime, nonce);
                    var body = new { appId, userId, corpId, expireTime, nonce, clientType = 72, deptCode };
                    content = JsonConvert.SerializeObject(body);
                }
                
                HttpRequestMessage sdkRequest = new HttpRequestMessage();
                sdkRequest.Method = HttpMethod.Post;
                sdkRequest.RequestUri = new Uri(url);
                string contentType = "application/json";
                sdkRequest.Content = new StringContent(content, Encoding.UTF8, contentType);
                sdkRequest.Headers.Add("Authorization", authorization);
                var response = TaskUtils.RunSync(() => client.DoHttpRequest(sdkRequest));
                string jsonString = TaskUtils.RunSync(() => response.Content.ReadAsStringAsync());
                var jObject = JObject.Parse(jsonString);
                this.token = (string)jObject["accessToken"];
                this.lastTokenDate = DateTime.Now;
                request.Headers.Add("X-Access-Token", token);
            }
            else
            {
                request.Headers.Add("X-Access-Token", token);
            }

            return request;
        }

        public override ICredential ProcessAuthParams(SdkHttpClient client, string regionId)
        {
            return this;
        }

        public override void ProcessDerivedAuthParams(string derivedAuthServiceName, string regionId)
        {
        }
    }
}
