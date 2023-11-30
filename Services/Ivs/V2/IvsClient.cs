using System;
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
        ///
        /// 使用姓名、身份证号码二要素进行身份审核。身份验证时，传入的数据为身份证信息。提取身份证信息时，可以使用身份证正反面图片，也可以直接输入姓名、身份证号文本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetectExtentionByIdCardImageResponse DetectExtentionByIdCardImage(DetectExtentionByIdCardImageRequest detectExtentionByIdCardImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-idcard-extention", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectExtentionByIdCardImageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectExtentionByIdCardImageResponse>(response);
        }

        public SyncInvoker<DetectExtentionByIdCardImageResponse> DetectExtentionByIdCardImageInvoker(DetectExtentionByIdCardImageRequest detectExtentionByIdCardImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-idcard-extention", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectExtentionByIdCardImageRequest);
            return new SyncInvoker<DetectExtentionByIdCardImageResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectExtentionByIdCardImageResponse>);
        }
        
        /// <summary>
        /// 人证核身证件版（二要素）
        ///
        /// 使用姓名、身份证号码二要素进行身份审核。身份验证时，传入的数据为身份证信息。提取身份证信息时，可以使用身份证正反面图片，也可以直接输入姓名、身份证号文本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetectExtentionByNameAndIdResponse DetectExtentionByNameAndId(DetectExtentionByNameAndIdRequest detectExtentionByNameAndIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-idcard-extention", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectExtentionByNameAndIdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectExtentionByNameAndIdResponse>(response);
        }

        public SyncInvoker<DetectExtentionByNameAndIdResponse> DetectExtentionByNameAndIdInvoker(DetectExtentionByNameAndIdRequest detectExtentionByNameAndIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-idcard-extention", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectExtentionByNameAndIdRequest);
            return new SyncInvoker<DetectExtentionByNameAndIdResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectExtentionByNameAndIdResponse>);
        }
        
        /// <summary>
        /// 人证核身标准版（三要素）
        ///
        /// 使用身份证正反面图片提取姓名和身份证号码，与人脸图片进行三要素身份审核。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetectStandardByIdCardImageResponse DetectStandardByIdCardImage(DetectStandardByIdCardImageRequest detectStandardByIdCardImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByIdCardImageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectStandardByIdCardImageResponse>(response);
        }

        public SyncInvoker<DetectStandardByIdCardImageResponse> DetectStandardByIdCardImageInvoker(DetectStandardByIdCardImageRequest detectStandardByIdCardImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByIdCardImageRequest);
            return new SyncInvoker<DetectStandardByIdCardImageResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectStandardByIdCardImageResponse>);
        }
        
        /// <summary>
        /// 人证核身标准版（三要素）
        ///
        /// 使用姓名、身份证号文本和人脸图片进行三要素身份审核。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetectStandardByNameAndIdResponse DetectStandardByNameAndId(DetectStandardByNameAndIdRequest detectStandardByNameAndIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByNameAndIdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectStandardByNameAndIdResponse>(response);
        }

        public SyncInvoker<DetectStandardByNameAndIdResponse> DetectStandardByNameAndIdInvoker(DetectStandardByNameAndIdRequest detectStandardByNameAndIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByNameAndIdRequest);
            return new SyncInvoker<DetectStandardByNameAndIdResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectStandardByNameAndIdResponse>);
        }
        
        /// <summary>
        /// 人证核身标准版（三要素）
        ///
        /// 从身份证正反面图片中提取姓名和身份证号码，并对视频做活体检测后提取人脸图片，以此进行三要素身份审核。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetectStandardByVideoAndIdCardImageResponse DetectStandardByVideoAndIdCardImage(DetectStandardByVideoAndIdCardImageRequest detectStandardByVideoAndIdCardImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByVideoAndIdCardImageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectStandardByVideoAndIdCardImageResponse>(response);
        }

        public SyncInvoker<DetectStandardByVideoAndIdCardImageResponse> DetectStandardByVideoAndIdCardImageInvoker(DetectStandardByVideoAndIdCardImageRequest detectStandardByVideoAndIdCardImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByVideoAndIdCardImageRequest);
            return new SyncInvoker<DetectStandardByVideoAndIdCardImageResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectStandardByVideoAndIdCardImageResponse>);
        }
        
        /// <summary>
        /// 人证核身标准版（三要素）
        ///
        /// 使用姓名、身份证号文本，并对视频做活体检测后提取人脸图片，以此进行三要素身份审核。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetectStandardByVideoAndNameAndIdResponse DetectStandardByVideoAndNameAndId(DetectStandardByVideoAndNameAndIdRequest detectStandardByVideoAndNameAndIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByVideoAndNameAndIdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetectStandardByVideoAndNameAndIdResponse>(response);
        }

        public SyncInvoker<DetectStandardByVideoAndNameAndIdResponse> DetectStandardByVideoAndNameAndIdInvoker(DetectStandardByVideoAndNameAndIdRequest detectStandardByVideoAndNameAndIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByVideoAndNameAndIdRequest);
            return new SyncInvoker<DetectStandardByVideoAndNameAndIdResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectStandardByVideoAndNameAndIdResponse>);
        }
        
    }
}