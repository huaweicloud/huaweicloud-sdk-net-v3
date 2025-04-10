using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.IdentityCenterOIDC.V1.Model;

namespace HuaweiCloud.SDK.IdentityCenterOIDC.V1
{
    public partial class IdentityCenterOIDCClient : Client
    {
        public static ClientBuilder<IdentityCenterOIDCClient> NewBuilder()
        {
            return new ClientBuilder<IdentityCenterOIDCClient>("IdentityCenterOIDCCredentials");
        }

        
        /// <summary>
        /// 注册客户端
        ///
        /// 向IAM身份中心注册客户端，这允许客户端启动设备授权，输出应该持久化以便于身份验证请求重用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RegisterClientResponse RegisterClient(RegisterClientRequest registerClientRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/clients", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerClientRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RegisterClientResponse>(response);
        }

        public SyncInvoker<RegisterClientResponse> RegisterClientInvoker(RegisterClientRequest registerClientRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/clients", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerClientRequest);
            return new SyncInvoker<RegisterClientResponse>(this, "POST", request, JsonUtils.DeSerialize<RegisterClientResponse>);
        }
        
        /// <summary>
        /// 请求设备授权
        ///
        /// 发起设备授权请求
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartDeviceAuthorizationResponse StartDeviceAuthorization(StartDeviceAuthorizationRequest startDeviceAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/device/authorize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDeviceAuthorizationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartDeviceAuthorizationResponse>(response);
        }

        public SyncInvoker<StartDeviceAuthorizationResponse> StartDeviceAuthorizationInvoker(StartDeviceAuthorizationRequest startDeviceAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/device/authorize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDeviceAuthorizationRequest);
            return new SyncInvoker<StartDeviceAuthorizationResponse>(this, "POST", request, JsonUtils.DeSerialize<StartDeviceAuthorizationResponse>);
        }
        
        /// <summary>
        /// 创建令牌
        ///
        /// 获取访问令牌
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTokenResponse CreateToken(CreateTokenRequest createTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTokenRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTokenResponse>(response);
        }

        public SyncInvoker<CreateTokenResponse> CreateTokenInvoker(CreateTokenRequest createTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTokenRequest);
            return new SyncInvoker<CreateTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTokenResponse>);
        }
        
    }
}