using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Sts.V1.Model;

namespace HuaweiCloud.SDK.Sts.V1
{
    public partial class StsAsyncClient : Client
    {
        public static ClientBuilder<StsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<StsAsyncClient>();
        }

        
        /// <summary>
        /// 通过委托或者信任委托获取临时安全凭证
        ///
        /// 通过委托或者信任委托获取临时安全凭证，临时安全凭证可用于对云资源发起访问。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssumeAgencyResponse> AssumeAgencyAsync(AssumeAgencyRequest assumeAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/assume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", assumeAgencyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AssumeAgencyResponse>(response);
        }

        public AsyncInvoker<AssumeAgencyResponse> AssumeAgencyAsyncInvoker(AssumeAgencyRequest assumeAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/assume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", assumeAgencyRequest);
            return new AsyncInvoker<AssumeAgencyResponse>(this, "POST", request, JsonUtils.DeSerialize<AssumeAgencyResponse>);
        }
        
        /// <summary>
        /// 解密鉴权失败的原因
        ///
        /// 解密鉴权失败的原因。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DecodeAuthorizationMessageResponse> DecodeAuthorizationMessageAsync(DecodeAuthorizationMessageRequest decodeAuthorizationMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/decode-authorization-message", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", decodeAuthorizationMessageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DecodeAuthorizationMessageResponse>(response);
        }

        public AsyncInvoker<DecodeAuthorizationMessageResponse> DecodeAuthorizationMessageAsyncInvoker(DecodeAuthorizationMessageRequest decodeAuthorizationMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/decode-authorization-message", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", decodeAuthorizationMessageRequest);
            return new AsyncInvoker<DecodeAuthorizationMessageResponse>(this, "POST", request, JsonUtils.DeSerialize<DecodeAuthorizationMessageResponse>);
        }
        
        /// <summary>
        /// 获取调用者身份信息
        ///
        /// 获取调用者（用户，委托等）身份信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetCallerIdentityResponse> GetCallerIdentityAsync(GetCallerIdentityRequest getCallerIdentityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/caller-identity", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getCallerIdentityRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetCallerIdentityResponse>(response);
        }

        public AsyncInvoker<GetCallerIdentityResponse> GetCallerIdentityAsyncInvoker(GetCallerIdentityRequest getCallerIdentityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/caller-identity", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getCallerIdentityRequest);
            return new AsyncInvoker<GetCallerIdentityResponse>(this, "GET", request, JsonUtils.DeSerialize<GetCallerIdentityResponse>);
        }
        
    }
}