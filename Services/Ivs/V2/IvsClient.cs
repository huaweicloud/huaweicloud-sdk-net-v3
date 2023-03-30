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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-idcard-extention",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectExtentionByIdCardImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectExtentionByIdCardImageResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-idcard-extention",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectExtentionByNameAndIdRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectExtentionByNameAndIdResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByIdCardImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectStandardByIdCardImageResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByNameAndIdRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectStandardByNameAndIdResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByVideoAndIdCardImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectStandardByVideoAndIdCardImageResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/ivs-standard",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectStandardByVideoAndNameAndIdRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DetectStandardByVideoAndNameAndIdResponse>(response);
        }
        
    }
}