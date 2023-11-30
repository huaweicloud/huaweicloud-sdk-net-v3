using System;
using System.Net.Http;

namespace HuaweiCloud.SDK.Core
{
    public class SyncInvoker<TResp> : BaseInvoker<SyncInvoker<TResp>, TResp> where TResp : SdkResponse
    {
        public SyncInvoker(Client client, string method, SdkRequest request, Func<HttpResponseMessage, TResp> deserializeMethod) : base(client, method, request, deserializeMethod)
        {
        }

        public TResp Invoke()
        {
            var responseMessage = Client.DoHttpRequestSync(Method, Request);
            return DeserializeMethod.Invoke(responseMessage);
        }
    }
}
