using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;

namespace HuaweiCloud.SDK.IdentityCenterOIDC.V1
{
    public class IdentityCenterOIDCCredentials : Credentials<IdentityCenterOIDCCredentials>
    {
        private static readonly Dictionary<string, string> PathParamDict = new Dictionary<string, string>();


        public override Dictionary<string, string> GetPathParamDictionary()
        {
            return PathParamDict;
        }

        public override Task<HttpRequest> SignAuthRequest(HttpRequest request, SdkHttpClient client = null)
        {
            var httpRequestTask = Task<HttpRequest>.Factory.StartNew(() =>
            {
                return request;
            });

            return httpRequestTask;
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
