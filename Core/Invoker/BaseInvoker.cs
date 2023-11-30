using System;
using System.Net.Http;
using HuaweiCloud.SDK.Core.Auth;

namespace HuaweiCloud.SDK.Core
{
    public abstract class BaseInvoker<TInvoker, TResp> where TInvoker : BaseInvoker<TInvoker, TResp> where TResp : SdkResponse
    {
        protected readonly Client Client;
        protected readonly string Method;
        protected readonly SdkRequest Request;
        protected readonly Func<HttpResponseMessage, TResp> DeserializeMethod;

        public BaseInvoker(Client client, string method, SdkRequest request, Func<HttpResponseMessage, TResp> deserializeMethod)
        {
            Client = client;
            Method = method;
            Request = request;
            DeserializeMethod = deserializeMethod;
        }

        public TInvoker AddHeader(string key, string value)
        {
            Request.Header.Add(key, value);
            return (TInvoker)this;
        }

        public TInvoker ReplaceCredentialWhen(Func<ICredential, ICredential> function)
        {
            Client.WithCredential(function.Invoke(Client.GetCredential()));
            return (TInvoker)this;
        }
    }
}
