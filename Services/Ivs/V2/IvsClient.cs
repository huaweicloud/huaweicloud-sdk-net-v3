using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ivs.V2.Model;

namespace HuaweiCloud.SDK.Ivs.V2
{
    public partial class IvsClient : Client
    {
        public static ClientBuilder<IvsClient> NewBuilder()
        {
            return new ClientBuilder<IvsClient>();
        }

        
        /// <summary>
        /// 人证核身证件版（二要素）
        /// </summary>
        public DetectExtentionByIdCardImageResponse DetectExtentionByIdCardImage(DetectExtentionByIdCardImageRequest detectExtentionByIdCardImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-idcard-extention",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectExtentionByIdCardImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectExtentionByIdCardImageResponse>(response);
        }
        
        /// <summary>
        /// 人证核身证件版（二要素）
        /// </summary>
        public DetectExtentionByNameAndIdResponse DetectExtentionByNameAndId(DetectExtentionByNameAndIdRequest detectExtentionByNameAndIdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-idcard-extention",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectExtentionByNameAndIdRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectExtentionByNameAndIdResponse>(response);
        }
        
        /// <summary>
        /// 人证核身标准版（三要素）
        /// </summary>
        public DetectStandardByIdCardImageResponse DetectStandardByIdCardImage(DetectStandardByIdCardImageRequest detectStandardByIdCardImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByIdCardImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectStandardByIdCardImageResponse>(response);
        }
        
        /// <summary>
        /// 人证核身标准版（三要素）
        /// </summary>
        public DetectStandardByNameAndIdResponse DetectStandardByNameAndId(DetectStandardByNameAndIdRequest detectStandardByNameAndIdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByNameAndIdRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectStandardByNameAndIdResponse>(response);
        }
        
    }
}