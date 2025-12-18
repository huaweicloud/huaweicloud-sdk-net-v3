using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Sts.V1.Model;

namespace HuaweiCloud.SDK.Sts.V1
{
    public partial class StsClient : Client
    {
        public static ClientBuilder<StsClient> NewBuilder()
        {
            return new ClientBuilder<StsClient>();
        }

        
        /// <summary>
        /// 通过委托或者信任委托获取临时安全凭证
        ///
        /// 通过委托或者信任委托获取临时安全凭证，临时安全凭证可用于对云资源发起访问。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssumeAgencyResponse AssumeAgency(AssumeAgencyRequest assumeAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/assume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", assumeAgencyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AssumeAgencyResponse>(response);
        }

        public SyncInvoker<AssumeAgencyResponse> AssumeAgencyInvoker(AssumeAgencyRequest assumeAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/assume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", assumeAgencyRequest);
            return new SyncInvoker<AssumeAgencyResponse>(this, "POST", request, JsonUtils.DeSerialize<AssumeAgencyResponse>);
        }
        
        /// <summary>
        /// 解密鉴权失败的原因
        ///
        /// 解密鉴权失败的原因。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DecodeAuthorizationMessageResponse DecodeAuthorizationMessage(DecodeAuthorizationMessageRequest decodeAuthorizationMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/decode-authorization-message", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", decodeAuthorizationMessageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DecodeAuthorizationMessageResponse>(response);
        }

        public SyncInvoker<DecodeAuthorizationMessageResponse> DecodeAuthorizationMessageInvoker(DecodeAuthorizationMessageRequest decodeAuthorizationMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/decode-authorization-message", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", decodeAuthorizationMessageRequest);
            return new SyncInvoker<DecodeAuthorizationMessageResponse>(this, "POST", request, JsonUtils.DeSerialize<DecodeAuthorizationMessageResponse>);
        }
        
        /// <summary>
        /// 获取调用者身份信息
        ///
        /// 获取调用者（用户，委托等）身份信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetCallerIdentityResponse GetCallerIdentity(GetCallerIdentityRequest getCallerIdentityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/caller-identity", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getCallerIdentityRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetCallerIdentityResponse>(response);
        }

        public SyncInvoker<GetCallerIdentityResponse> GetCallerIdentityInvoker(GetCallerIdentityRequest getCallerIdentityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/caller-identity", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getCallerIdentityRequest);
            return new SyncInvoker<GetCallerIdentityResponse>(this, "GET", request, JsonUtils.DeSerialize<GetCallerIdentityResponse>);
        }
        
    }
}