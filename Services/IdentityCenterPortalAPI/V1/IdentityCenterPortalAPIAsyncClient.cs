using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.IdentityCenterPortalAPI.V1.Model;

namespace HuaweiCloud.SDK.IdentityCenterPortalAPI.V1
{
    public partial class IdentityCenterPortalAPIAsyncClient : Client
    {
        public static ClientBuilder<IdentityCenterPortalAPIAsyncClient> NewBuilder()
        {
            return new ClientBuilder<IdentityCenterPortalAPIAsyncClient>("IdentityCenterPortalAPICredentials");
        }

        
        /// <summary>
        /// 列出账号
        ///
        /// 列出分配给用户的所有账号
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAccountsResponse> ListAccountsAsync(ListAccountsRequest listAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/assigned-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAccountsResponse>(response);
        }

        public AsyncInvoker<ListAccountsResponse> ListAccountsAsyncInvoker(ListAccountsRequest listAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/assigned-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountsRequest);
            return new AsyncInvoker<ListAccountsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccountsResponse>);
        }
        
        /// <summary>
        /// 列出账号委托
        ///
        /// 列出账号分配给用户的所有委托或信任委托
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAccountAgenciesResponse> ListAccountAgenciesAsync(ListAccountAgenciesRequest listAccountAgenciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/assigned-agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAgenciesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAccountAgenciesResponse>(response);
        }

        public AsyncInvoker<ListAccountAgenciesResponse> ListAccountAgenciesAsyncInvoker(ListAccountAgenciesRequest listAccountAgenciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/assigned-agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAgenciesRequest);
            return new AsyncInvoker<ListAccountAgenciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccountAgenciesResponse>);
        }
        
        /// <summary>
        /// 获取委托凭证
        ///
        /// 获取分配给用户的指定委托或信任委托的STS短期凭证
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetAgencyCredentialsResponse> GetAgencyCredentialsAsync(GetAgencyCredentialsRequest getAgencyCredentialsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/credentials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAgencyCredentialsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetAgencyCredentialsResponse>(response);
        }

        public AsyncInvoker<GetAgencyCredentialsResponse> GetAgencyCredentialsAsyncInvoker(GetAgencyCredentialsRequest getAgencyCredentialsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/credentials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAgencyCredentialsRequest);
            return new AsyncInvoker<GetAgencyCredentialsResponse>(this, "GET", request, JsonUtils.DeSerialize<GetAgencyCredentialsResponse>);
        }
        
        /// <summary>
        /// 登出用户
        ///
        /// 向IAM身份中心服务发送API调用，使相应的服务端IAM身份中心登录会话失效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<LogoutResponse> LogoutAsync(LogoutRequest logoutRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/logout", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", logoutRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<LogoutResponse>(response);
        }

        public AsyncInvoker<LogoutResponse> LogoutAsyncInvoker(LogoutRequest logoutRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/logout", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", logoutRequest);
            return new AsyncInvoker<LogoutResponse>(this, "POST", request, JsonUtils.DeSerializeNull<LogoutResponse>);
        }
        
    }
}