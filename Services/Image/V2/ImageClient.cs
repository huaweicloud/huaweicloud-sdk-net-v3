using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Image.V2.Model;

namespace HuaweiCloud.SDK.Image.V2
{
    public partial class ImageClient : Client
    {
        public static ClientBuilder<ImageClient> NewBuilder()
        {
            return new ClientBuilder<ImageClient>();
        }

        
        /// <summary>
        /// 名人识别
        /// </summary>
        public RunCelebrityRecognitionResponse RunCelebrityRecognition(RunCelebrityRecognitionRequest runCelebrityRecognitionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/celebrity-recognition",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runCelebrityRecognitionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunCelebrityRecognitionResponse>(response);
        }
        
        /// <summary>
        /// 图像标签
        /// </summary>
        public RunImageTaggingResponse RunImageTagging(RunImageTaggingRequest runImageTaggingRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/tagging",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageTaggingRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunImageTaggingResponse>(response);
        }
        
    }
}