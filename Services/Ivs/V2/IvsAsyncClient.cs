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
        ///
        /// 使用姓名、身份证号码二要素进行身份审核。身份验证时，传入的数据为身份证信息。提取身份证信息时，可以使用身份证正反面图片，也可以直接输入姓名、身份证号文本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 使用姓名、身份证号码二要素进行身份审核。身份验证时，传入的数据为身份证信息。提取身份证信息时，可以使用身份证正反面图片，也可以直接输入姓名、身份证号文本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 使用姓名、身份证号码、人脸图片三要素进行身份审核。
        /// 身份验证时，传入的数据为人脸图片、身份证信息。提取身份证信息时，可以使用身份证正反面图片，也可以直接输入姓名、身份证号文本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 校验用户上传的身份证图片支持正反面同时上传 中的信息的真实性，输出最终的审核结果。 该接口也支持用户直接上传姓名和身份证号码进行合法性校验 。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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