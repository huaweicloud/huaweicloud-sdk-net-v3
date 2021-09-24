using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ivs.V2.Model;

namespace HuaweiCloud.SDK.Ivs.V2
{
    public partial class IvsAsyncClient : Client
    {
        public static ClientBuilder<IvsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<IvsAsyncClient>();
        }

        
        /// <summary>
        /// 人证核身证件版（二要素）
        /// </summary>
        public async Task<DetectExtentionByIdCardImageResponse> DetectExtentionByIdCardImageAsync(DetectExtentionByIdCardImageRequest detectExtentionByIdCardImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-idcard-extention",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectExtentionByIdCardImageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetectExtentionByIdCardImageResponse>(response);
        }
        
        /// <summary>
        /// 人证核身证件版（二要素）
        /// </summary>
        public async Task<DetectExtentionByNameAndIdResponse> DetectExtentionByNameAndIdAsync(DetectExtentionByNameAndIdRequest detectExtentionByNameAndIdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-idcard-extention",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectExtentionByNameAndIdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetectExtentionByNameAndIdResponse>(response);
        }
        
        /// <summary>
        /// 人证核身标准版（三要素）
        /// </summary>
        public async Task<DetectStandardByIdCardImageResponse> DetectStandardByIdCardImageAsync(DetectStandardByIdCardImageRequest detectStandardByIdCardImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByIdCardImageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetectStandardByIdCardImageResponse>(response);
        }
        
        /// <summary>
        /// 人证核身标准版（三要素）
        /// </summary>
        public async Task<DetectStandardByNameAndIdResponse> DetectStandardByNameAndIdAsync(DetectStandardByNameAndIdRequest detectStandardByNameAndIdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByNameAndIdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetectStandardByNameAndIdResponse>(response);
        }
        
    }
}