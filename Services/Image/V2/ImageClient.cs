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
        /// 创建任务
        ///
        /// Create Task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateImageHighresolutionMattingTaskResponse CreateImageHighresolutionMattingTask(CreateImageHighresolutionMattingTaskRequest createImageHighresolutionMattingTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/image-highresolution-matting/tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createImageHighresolutionMattingTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateImageHighresolutionMattingTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建任务
        ///
        /// Create Task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateImageToVideoTaskResponse CreateImageToVideoTask(CreateImageToVideoTaskRequest createImageToVideoTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/image-to-video/tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createImageToVideoTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateImageToVideoTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建任务
        ///
        /// Create Task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateImageTranslateTaskResponse CreateImageTranslateTask(CreateImageTranslateTaskRequest createImageTranslateTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/image-wisedesign-translate/tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createImageTranslateTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateImageTranslateTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建图像重构任务
        ///
        /// Create Task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateImageVariationTaskResponse CreateImageVariationTask(CreateImageVariationTaskRequest createImageVariationTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/image-variation/tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createImageVariationTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateImageVariationTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建文生图任务
        ///
        /// Create Task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTextToImageTaskResponse CreateTextToImageTask(CreateTextToImageTaskRequest createTextToImageTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/text-to-image/tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTextToImageTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateTextToImageTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建任务
        ///
        /// 创建视频封面任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVideoCoverAnalysisTaskResponse CreateVideoCoverAnalysisTask(CreateVideoCoverAnalysisTaskRequest createVideoCoverAnalysisTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/video-cover-analysis/tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVideoCoverAnalysisTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVideoCoverAnalysisTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建任务
        ///
        /// Create Task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVideoCuttingTaskResponse CreateVideoCuttingTask(CreateVideoCuttingTaskRequest createVideoCuttingTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/video-cutting/tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVideoCuttingTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVideoCuttingTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建司乘敏感擦除任务
        ///
        /// Create Task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVideoObjectMaskingTaskResponse CreateVideoObjectMaskingTask(CreateVideoObjectMaskingTaskRequest createVideoObjectMaskingTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/video-object-masking/tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVideoObjectMaskingTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVideoObjectMaskingTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建任务
        ///
        /// 创建视频拆条任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVideoShotSplitTaskResponse CreateVideoShotSplitTask(CreateVideoShotSplitTaskRequest createVideoShotSplitTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/video-shot-split/tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVideoShotSplitTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVideoShotSplitTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建任务
        ///
        /// Create Task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVideoSummarizationAnalysisTaskResponse CreateVideoSummarizationAnalysisTask(CreateVideoSummarizationAnalysisTaskRequest createVideoSummarizationAnalysisTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/video-summarization-analysis/tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVideoSummarizationAnalysisTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVideoSummarizationAnalysisTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建任务
        ///
        /// Create Task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVideoSynthesisTaskResponse CreateVideoSynthesisTask(CreateVideoSynthesisTaskRequest createVideoSynthesisTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/video-synthesis/tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVideoSynthesisTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVideoSynthesisTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建任务
        ///
        /// Create Task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVideoTranslateTaskResponse CreateVideoTranslateTask(CreateVideoTranslateTaskRequest createVideoTranslateTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/video-translate/tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVideoTranslateTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVideoTranslateTaskResponse>(response);
        }
        
        /// <summary>
        /// 名人识别
        ///
        /// 分析并识别图片中包含的政治人物、明星及网红人物，返回人物信息及人脸坐标。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 删除媒资图像标签
        ///
        /// 用于用户删除自定义的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunDeleteCustomTagsResponse RunDeleteCustomTags(RunDeleteCustomTagsRequest runDeleteCustomTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/media-tagging/custom-tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runDeleteCustomTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<RunDeleteCustomTagsResponse>(response);
        }
        
        /// <summary>
        /// 图像描述
        ///
        /// 图像描述
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunImageDescriptionResponse RunImageDescription(RunImageDescriptionRequest runImageDescriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/description",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageDescriptionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunImageDescriptionResponse>(response);
        }
        
        /// <summary>
        /// 主体识别
        ///
        /// 检测图像中的主要内容，返回主要内容的坐标信息，这里的主要内容包括两方面：bounding_box和main_object_box
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunImageMainObjectDetectionResponse RunImageMainObjectDetection(RunImageMainObjectDetectionRequest runImageMainObjectDetectionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/image/main-object-detection",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageMainObjectDetectionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunImageMainObjectDetectionResponse>(response);
        }
        
        /// <summary>
        /// 标签识别
        ///
        /// 自然图像的语义内容非常丰富，一个图像包含多个标签内容，图像标签服务准确识别自然图片中数百种场景、上千种通用物体及其属性，让智能相册管理、照片检索和分类、基于场景内容或者物体的广告推荐等功能更加直观。使用时用户发送待处理图片，返回图片标签内容及相应置信度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunImageMediaTaggingResponse RunImageMediaTagging(RunImageMediaTaggingRequest runImageMediaTaggingRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/media-tagging",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageMediaTaggingRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunImageMediaTaggingResponse>(response);
        }
        
        /// <summary>
        /// 媒资图像标签检测
        ///
        /// 自然图像的语义内容非常丰富，一个图像包含多个标签内容，图像标签服务准确识别自然图片中数百种场景、上千种通用物体及其属性，让智能相册管理、照片检索和分类、基于场景内容或者物体的广告推荐等功能更加直观。使用时用户发送待处理图片，返回图片标签内容及相应的位置坐标。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunImageMediaTaggingDetResponse RunImageMediaTaggingDet(RunImageMediaTaggingDetRequest runImageMediaTaggingDetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/media-tagging-det",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageMediaTaggingDetRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunImageMediaTaggingDetResponse>(response);
        }
        
        /// <summary>
        /// 图像超分
        ///
        /// 图像数据，base64编码，输入图像范围200px ~ 1080px，支持JPG/PNG/BMP/JPEG/WEBP格式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunImageSuperResolutionResponse RunImageSuperResolution(RunImageSuperResolutionRequest runImageSuperResolutionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/image-super-resolution",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageSuperResolutionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunImageSuperResolutionResponse>(response);
        }
        
        /// <summary>
        /// 图像标签
        ///
        /// 自然图像的语义内容非常丰富，一个图像包含多个标签内容，图像标签服务准确识别自然图片中数百种场景、上千种通用物体及其属性，让智能相册管理、照片检索和分类、基于场景内容或者物体的广告推荐等功能更加直观。使用时用户发送待处理图片，返回图片标签内容及相应置信度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunImageTaggingResponse RunImageTagging(RunImageTaggingRequest runImageTaggingRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/tagging",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageTaggingRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunImageTaggingResponse>(response);
        }
        
        /// <summary>
        /// 智能设计图像裁剪
        ///
        /// 智能设计图像裁剪服务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunImageWisedesignCropResponse RunImageWisedesignCrop(RunImageWisedesignCropRequest runImageWisedesignCropRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/image-wisedesign-crop",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageWisedesignCropRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunImageWisedesignCropResponse>(response);
        }
        
        /// <summary>
        /// 智能设计图像修复
        ///
        /// 智能设计图像修复服务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunImageWisedesignInpaintingResponse RunImageWisedesignInpainting(RunImageWisedesignInpaintingRequest runImageWisedesignInpaintingRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/image-wisedesign-inpainting",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageWisedesignInpaintingRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunImageWisedesignInpaintingResponse>(response);
        }
        
        /// <summary>
        /// 查询媒资图像标签
        ///
        /// 用于用户自查是否存在自定义的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunQueryCustomTagsResponse RunQueryCustomTags(RunQueryCustomTagsRequest runQueryCustomTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/media-tagging/custom-tags/check",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryCustomTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<RunQueryCustomTagsResponse>(response);
        }
        
        /// <summary>
        /// 翻拍识别
        ///
        /// 零售行业通常根据零售店的销售量进行销售奖励，拍摄售出商品的条形码上传后台是常用的统计方式。翻拍识别利用深度神经网络算法判断条形码图片为原始拍摄，还是经过二次翻拍、打印翻拍等手法二次处理的图片。利用翻拍识别，可以检测出经过二次处理的不合规范图片，使得统计数据更准确、有效。。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunRecaptureDetectResponse RunRecaptureDetect(RunRecaptureDetectRequest runRecaptureDetectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/recapture-detect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runRecaptureDetectRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunRecaptureDetectResponse>(response);
        }
        
        /// <summary>
        /// 查询任务
        ///
        /// show task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowImageHighresolutionMattingTaskResponse ShowImageHighresolutionMattingTask(ShowImageHighresolutionMattingTaskRequest showImageHighresolutionMattingTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showImageHighresolutionMattingTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/image-highresolution-matting/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageHighresolutionMattingTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowImageHighresolutionMattingTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询任务
        ///
        /// show task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowImageToVideoTaskResponse ShowImageToVideoTask(ShowImageToVideoTaskRequest showImageToVideoTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showImageToVideoTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/image-to-video/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageToVideoTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowImageToVideoTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询任务
        ///
        /// show task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowImageTranslateTaskResponse ShowImageTranslateTask(ShowImageTranslateTaskRequest showImageTranslateTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showImageTranslateTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/image-wisedesign-translate/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageTranslateTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowImageTranslateTaskResponse>(response);
        }
        
        /// <summary>
        /// show task 查询任务信息
        ///
        /// show task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowImageVariationTaskResponse ShowImageVariationTask(ShowImageVariationTaskRequest showImageVariationTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showImageVariationTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/image-variation/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageVariationTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowImageVariationTaskResponse>(response);
        }
        
        /// <summary>
        /// show task 查询任务信息
        ///
        /// show task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTextToImageTaskResponse ShowTextToImageTask(ShowTextToImageTaskRequest showTextToImageTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showTextToImageTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/text-to-image/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTextToImageTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowTextToImageTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询任务
        ///
        /// 查询视频封面任务完成状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVideoCoverAnalysisTaskResponse ShowVideoCoverAnalysisTask(ShowVideoCoverAnalysisTaskRequest showVideoCoverAnalysisTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showVideoCoverAnalysisTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/video-cover-analysis/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVideoCoverAnalysisTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVideoCoverAnalysisTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询任务
        ///
        /// show task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVideoCuttingTaskResponse ShowVideoCuttingTask(ShowVideoCuttingTaskRequest showVideoCuttingTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showVideoCuttingTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/video-cutting/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVideoCuttingTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVideoCuttingTaskResponse>(response);
        }
        
        /// <summary>
        /// show task 查询任务信息
        ///
        /// show task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVideoObjectMaskingTaskResponse ShowVideoObjectMaskingTask(ShowVideoObjectMaskingTaskRequest showVideoObjectMaskingTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showVideoObjectMaskingTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/video-object-masking/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVideoObjectMaskingTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVideoObjectMaskingTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询任务
        ///
        /// 查询拆条任务状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVideoShotSplitTaskResponse ShowVideoShotSplitTask(ShowVideoShotSplitTaskRequest showVideoShotSplitTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showVideoShotSplitTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/video-shot-split/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVideoShotSplitTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVideoShotSplitTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询任务
        ///
        /// show task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVideoSummarizationAnalysisTaskResponse ShowVideoSummarizationAnalysisTask(ShowVideoSummarizationAnalysisTaskRequest showVideoSummarizationAnalysisTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showVideoSummarizationAnalysisTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/video-summarization-analysis/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVideoSummarizationAnalysisTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVideoSummarizationAnalysisTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询任务
        ///
        /// show task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVideoSynthesisTaskResponse ShowVideoSynthesisTask(ShowVideoSynthesisTaskRequest showVideoSynthesisTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showVideoSynthesisTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/video-synthesis/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVideoSynthesisTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVideoSynthesisTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询任务
        ///
        /// show task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVideoTranslateTaskResponse ShowVideoTranslateTask(ShowVideoTranslateTaskRequest showVideoTranslateTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showVideoTranslateTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/video-translate/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVideoTranslateTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVideoTranslateTaskResponse>(response);
        }
        
    }
}