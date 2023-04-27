using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Image.V2.Model;

namespace HuaweiCloud.SDK.Image.V2
{
    public partial class ImageAsyncClient : Client
    {
        public static ClientBuilder<ImageAsyncClient> NewBuilder()
        {
            return new ClientBuilder<ImageAsyncClient>();
        }

        
        /// <summary>
        /// 创建图像高清抠图任务
        ///
        /// 创建图像高清抠图任务，将输入的高清图像中的商品主体从原图中扣取出来，输出商品主体图片或者蒙版。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateImageHighresolutionMattingTaskResponse> CreateImageHighresolutionMattingTaskAsync(CreateImageHighresolutionMattingTaskRequest createImageHighresolutionMattingTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/image-highresolution-matting/tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createImageHighresolutionMattingTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateImageHighresolutionMattingTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建视频脱敏任务
        ///
        /// 创建视频脱敏除任务，将输入视频的图像敏感信息模糊化，包括视频中的人脸和车牌
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateVideoObjectMaskingTaskResponse> CreateVideoObjectMaskingTaskAsync(CreateVideoObjectMaskingTaskRequest createVideoObjectMaskingTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/video-object-masking/tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVideoObjectMaskingTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateVideoObjectMaskingTaskResponse>(response);
        }
        
        /// <summary>
        /// 名人识别
        ///
        /// 分析并识别图片中包含的政治人物、明星及网红人物，返回人物信息及人脸坐标。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunCelebrityRecognitionResponse> RunCelebrityRecognitionAsync(RunCelebrityRecognitionRequest runCelebrityRecognitionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/celebrity-recognition",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runCelebrityRecognitionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunCelebrityRecognitionResponse>(response);
        }
        
        /// <summary>
        /// 图像描述
        ///
        /// 图像描述
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunImageDescriptionResponse> RunImageDescriptionAsync(RunImageDescriptionRequest runImageDescriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/description",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageDescriptionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunImageDescriptionResponse>(response);
        }
        
        /// <summary>
        /// 主体识别
        ///
        /// 检测图像中的主要内容，返回主要内容的坐标信息，这里的主要内容包括两方面：bounding_box和main_object_box
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunImageMainObjectDetectionResponse> RunImageMainObjectDetectionAsync(RunImageMainObjectDetectionRequest runImageMainObjectDetectionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/image/main-object-detection",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageMainObjectDetectionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunImageMainObjectDetectionResponse>(response);
        }
        
        /// <summary>
        /// 标签识别
        ///
        /// 自然图像的语义内容非常丰富，一个图像包含多个标签内容，图像标签服务准确识别自然图片中数百种场景、上千种通用物体及其属性，让智能相册管理、照片检索和分类、基于场景内容或者物体的广告推荐等功能更加直观。使用时用户发送待处理图片，返回图片标签内容及相应置信度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunImageMediaTaggingResponse> RunImageMediaTaggingAsync(RunImageMediaTaggingRequest runImageMediaTaggingRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/media-tagging",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageMediaTaggingRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunImageMediaTaggingResponse>(response);
        }
        
        /// <summary>
        /// 媒资图像标签检测
        ///
        /// 自然图像的语义内容非常丰富，一个图像包含多个标签内容，图像标签服务准确识别自然图片中数百种场景、上千种通用物体及其属性，让智能相册管理、照片检索和分类、基于场景内容或者物体的广告推荐等功能更加直观。使用时用户发送待处理图片，返回图片标签内容及相应的位置坐标。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunImageMediaTaggingDetResponse> RunImageMediaTaggingDetAsync(RunImageMediaTaggingDetRequest runImageMediaTaggingDetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/media-tagging-det",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageMediaTaggingDetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunImageMediaTaggingDetResponse>(response);
        }
        
        /// <summary>
        /// 图像超分
        ///
        /// 图像数据，base64编码，输入图像范围200px ~ 1080px，支持JPG/PNG/BMP/JPEG/WEBP格式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunImageSuperResolutionResponse> RunImageSuperResolutionAsync(RunImageSuperResolutionRequest runImageSuperResolutionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/image-super-resolution",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageSuperResolutionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunImageSuperResolutionResponse>(response);
        }
        
        /// <summary>
        /// 图像标签
        ///
        /// 自然图像的语义内容非常丰富，一个图像包含多个标签内容，图像标签服务准确识别自然图片中数百种场景、上千种通用物体及其属性，让智能相册管理、照片检索和分类、基于场景内容或者物体的广告推荐等功能更加直观。使用时用户发送待处理图片，返回图片标签内容及相应置信度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunImageTaggingResponse> RunImageTaggingAsync(RunImageTaggingRequest runImageTaggingRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/tagging",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageTaggingRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunImageTaggingResponse>(response);
        }
        
        /// <summary>
        /// 翻拍识别
        ///
        /// 零售行业通常根据零售店的销售量进行销售奖励，拍摄售出商品的条形码上传后台是常用的统计方式。翻拍识别利用深度神经网络算法判断条形码图片为原始拍摄，还是经过二次翻拍、打印翻拍等手法二次处理的图片。利用翻拍识别，可以检测出经过二次处理的不合规范图片，使得统计数据更准确、有效。。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunRecaptureDetectResponse> RunRecaptureDetectAsync(RunRecaptureDetectRequest runRecaptureDetectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/recapture-detect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runRecaptureDetectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunRecaptureDetectResponse>(response);
        }
        
        /// <summary>
        /// 查询图像高清抠图任务
        ///
        /// 查询图像高清抠图任务，返回参数配置以及任务状态信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowImageHighresolutionMattingTaskResponse> ShowImageHighresolutionMattingTaskAsync(ShowImageHighresolutionMattingTaskRequest showImageHighresolutionMattingTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showImageHighresolutionMattingTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/image-highresolution-matting/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageHighresolutionMattingTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowImageHighresolutionMattingTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询视频脱敏任务详情
        ///
        /// show task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVideoObjectMaskingTaskResponse> ShowVideoObjectMaskingTaskAsync(ShowVideoObjectMaskingTaskRequest showVideoObjectMaskingTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showVideoObjectMaskingTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/video-object-masking/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVideoObjectMaskingTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVideoObjectMaskingTaskResponse>(response);
        }
        
    }
}