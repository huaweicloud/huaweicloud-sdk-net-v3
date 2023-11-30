using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HuaweiCloud.SDK.Core
{
    public class AsyncInvoker<TResp> : BaseInvoker<AsyncInvoker<TResp>, TResp> where TResp : SdkResponse
    {
        public AsyncInvoker(Client client, string method, SdkRequest request, Func<HttpResponseMessage, TResp> deserializeMethod) : base(client, method, request, deserializeMethod)
        {
        }

        public async Task<TResp> Invoke()
        {
            var responseMessage = await Client.DoHttpRequestAsync(Method, Request);
            return DeserializeMethod.Invoke(responseMessage);
        }
    }
}
