using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;

namespace HuaweiCloud.SDK.Iam.V3
{
    public class IamCredentials : Credentials
    {

        public string XAuthToken { set; get; }

        private static readonly Dictionary<string, string> PathParamDict = new Dictionary<string, string>();

        public IamCredentials(string xAuthToken = null)
        {
            this.XAuthToken = xAuthToken;
        }

        public override Dictionary<string, string> GetPathParamDictionary()
        {
            return PathParamDict;
        }

        public override Task<HttpRequest> SignAuthRequest(HttpRequest request)
        {
            var httpRequestTask = Task<HttpRequest>.Factory.StartNew(() =>
            {
                if (XAuthToken != null)
                {
                    request.Headers.Add("X-Auth-Token", XAuthToken);
                }

                return request;
            });

            return httpRequestTask;
        }

        public override Credentials ProcessAuthParams(SdkHttpClient client, string regionId)
        {
            return this;
        }

        public override void ProcessDerivedAuthParams(string derivedAuthServiceName, string regionId)
        {
        }
    }
}
