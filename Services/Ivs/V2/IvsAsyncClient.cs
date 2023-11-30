using System;
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-idcard-extention",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectExtentionByIdCardImageRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetectExtentionByIdCardImageResponse>(response);
        }

        public AsyncInvoker<DetectExtentionByIdCardImageResponse> DetectExtentionByIdCardImageAsyncInvoker(DetectExtentionByIdCardImageRequest detectExtentionByIdCardImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-idcard-extention",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectExtentionByIdCardImageRequest);
            return new AsyncInvoker<DetectExtentionByIdCardImageResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectExtentionByIdCardImageResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-idcard-extention",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectExtentionByNameAndIdRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetectExtentionByNameAndIdResponse>(response);
        }

        public AsyncInvoker<DetectExtentionByNameAndIdResponse> DetectExtentionByNameAndIdAsyncInvoker(DetectExtentionByNameAndIdRequest detectExtentionByNameAndIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-idcard-extention",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectExtentionByNameAndIdRequest);
            return new AsyncInvoker<DetectExtentionByNameAndIdResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectExtentionByNameAndIdResponse>);
        }
        
        /// <summary>
        /// 人证核身标准版（三要素）
        ///
        /// 使用身份证正反面图片提取姓名和身份证号码，与人脸图片进行三要素身份审核。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetectStandardByIdCardImageResponse> DetectStandardByIdCardImageAsync(DetectStandardByIdCardImageRequest detectStandardByIdCardImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByIdCardImageRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetectStandardByIdCardImageResponse>(response);
        }

        public AsyncInvoker<DetectStandardByIdCardImageResponse> DetectStandardByIdCardImageAsyncInvoker(DetectStandardByIdCardImageRequest detectStandardByIdCardImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByIdCardImageRequest);
            return new AsyncInvoker<DetectStandardByIdCardImageResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectStandardByIdCardImageResponse>);
        }
        
        /// <summary>
        /// 人证核身标准版（三要素）
        ///
        /// 使用姓名、身份证号文本和人脸图片进行三要素身份审核。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetectStandardByNameAndIdResponse> DetectStandardByNameAndIdAsync(DetectStandardByNameAndIdRequest detectStandardByNameAndIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByNameAndIdRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetectStandardByNameAndIdResponse>(response);
        }

        public AsyncInvoker<DetectStandardByNameAndIdResponse> DetectStandardByNameAndIdAsyncInvoker(DetectStandardByNameAndIdRequest detectStandardByNameAndIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByNameAndIdRequest);
            return new AsyncInvoker<DetectStandardByNameAndIdResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectStandardByNameAndIdResponse>);
        }
        
        /// <summary>
        /// 人证核身标准版（三要素）
        ///
        /// 从身份证正反面图片中提取姓名和身份证号码，并对视频做活体检测后提取人脸图片，以此进行三要素身份审核。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetectStandardByVideoAndIdCardImageResponse> DetectStandardByVideoAndIdCardImageAsync(DetectStandardByVideoAndIdCardImageRequest detectStandardByVideoAndIdCardImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByVideoAndIdCardImageRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetectStandardByVideoAndIdCardImageResponse>(response);
        }

        public AsyncInvoker<DetectStandardByVideoAndIdCardImageResponse> DetectStandardByVideoAndIdCardImageAsyncInvoker(DetectStandardByVideoAndIdCardImageRequest detectStandardByVideoAndIdCardImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByVideoAndIdCardImageRequest);
            return new AsyncInvoker<DetectStandardByVideoAndIdCardImageResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectStandardByVideoAndIdCardImageResponse>);
        }
        
        /// <summary>
        /// 人证核身标准版（三要素）
        ///
        /// 使用姓名、身份证号文本，并对视频做活体检测后提取人脸图片，以此进行三要素身份审核。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetectStandardByVideoAndNameAndIdResponse> DetectStandardByVideoAndNameAndIdAsync(DetectStandardByVideoAndNameAndIdRequest detectStandardByVideoAndNameAndIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByVideoAndNameAndIdRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetectStandardByVideoAndNameAndIdResponse>(response);
        }

        public AsyncInvoker<DetectStandardByVideoAndNameAndIdResponse> DetectStandardByVideoAndNameAndIdAsyncInvoker(DetectStandardByVideoAndNameAndIdRequest detectStandardByVideoAndNameAndIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByVideoAndNameAndIdRequest);
            return new AsyncInvoker<DetectStandardByVideoAndNameAndIdResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectStandardByVideoAndNameAndIdResponse>);
        }
        
    }
}