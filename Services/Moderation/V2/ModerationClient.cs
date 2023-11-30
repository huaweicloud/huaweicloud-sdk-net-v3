using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Moderation.V2.Model;

namespace HuaweiCloud.SDK.Moderation.V2
{
    public partial class ModerationClient : Client
    {
        public static ClientBuilder<ModerationClient> NewBuilder()
        {
            return new ClientBuilder<ModerationClient>();
        }

        
        /// <summary>
        /// 处理结果查询
        ///
        /// 分析并识别用户上传的图像内容是否有敏感内容（如涉及政治人物、暴恐元素、涉黄内容等），并将识别结果返回给用户。
        /// &gt; 任务最长保留时间为30分钟，过期后会被清理掉。建议在任务提交后，每30s进行一次周期查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunCheckResultResponse RunCheckResult(RunCheckResultRequest runCheckResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image/batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCheckResultRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<RunCheckResultResponse>(response);
        }

        public SyncInvoker<RunCheckResultResponse> RunCheckResultInvoker(RunCheckResultRequest runCheckResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image/batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCheckResultRequest);
            return new SyncInvoker<RunCheckResultResponse>(this, "GET", request, JsonUtils.DeSerialize<RunCheckResultResponse>);
        }
        
        /// <summary>
        /// 任务列表查询
        ///
        /// 查询批量图像内容审核任务列表，可通过指定任务状态查询来对任务列表进行过滤。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunCheckTaskJobsResponse RunCheckTaskJobs(RunCheckTaskJobsRequest runCheckTaskJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image/batch/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCheckTaskJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<RunCheckTaskJobsResponse>(response);
        }

        public SyncInvoker<RunCheckTaskJobsResponse> RunCheckTaskJobsInvoker(RunCheckTaskJobsRequest runCheckTaskJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image/batch/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCheckTaskJobsRequest);
            return new SyncInvoker<RunCheckTaskJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<RunCheckTaskJobsResponse>);
        }
        
        /// <summary>
        /// 图像内容审核（批量）
        ///
        /// 分析并识别用户上传的图像内容是否有敏感内容（如涉及政治人物、暴恐元素、涉黄内容等），并将识别结果返回给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunImageBatchModerationResponse RunImageBatchModeration(RunImageBatchModerationRequest runImageBatchModerationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image/batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageBatchModerationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunImageBatchModerationResponse>(response);
        }

        public SyncInvoker<RunImageBatchModerationResponse> RunImageBatchModerationInvoker(RunImageBatchModerationRequest runImageBatchModerationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image/batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageBatchModerationRequest);
            return new SyncInvoker<RunImageBatchModerationResponse>(this, "POST", request, JsonUtils.DeSerialize<RunImageBatchModerationResponse>);
        }
        
        /// <summary>
        /// 图像内容审核
        ///
        /// 分析并识别用户上传的图像内容是否有敏感内容（如涉及政治人物、暴恐元素、涉黄内容等），并将识别结果返回给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunImageModerationResponse RunImageModeration(RunImageModerationRequest runImageModerationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageModerationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunImageModerationResponse>(response);
        }

        public SyncInvoker<RunImageModerationResponse> RunImageModerationInvoker(RunImageModerationRequest runImageModerationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageModerationRequest);
            return new SyncInvoker<RunImageModerationResponse>(this, "POST", request, JsonUtils.DeSerialize<RunImageModerationResponse>);
        }
        
        /// <summary>
        /// 语音内容审核
        ///
        /// 分析并识别用户上传的语音内容是否有敏感内容（如色情、政治等），并将识别结果 返回给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunModerationAudioResponse RunModerationAudio(RunModerationAudioRequest runModerationAudioRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/voice", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runModerationAudioRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunModerationAudioResponse>(response);
        }

        public SyncInvoker<RunModerationAudioResponse> RunModerationAudioInvoker(RunModerationAudioRequest runModerationAudioRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/voice", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runModerationAudioRequest);
            return new SyncInvoker<RunModerationAudioResponse>(this, "POST", request, JsonUtils.DeSerialize<RunModerationAudioResponse>);
        }
        
        /// <summary>
        /// 任务提交
        ///
        /// 提交批量图像内容审核任务，返回任务标识，任务标识可用于查询任务结果。此接口为异步接口，相对于批量接口，支持更大图片列表批次。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunTaskSumbitResponse RunTaskSumbit(RunTaskSumbitRequest runTaskSumbitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image/batch/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runTaskSumbitRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunTaskSumbitResponse>(response);
        }

        public SyncInvoker<RunTaskSumbitResponse> RunTaskSumbitInvoker(RunTaskSumbitRequest runTaskSumbitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image/batch/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runTaskSumbitRequest);
            return new SyncInvoker<RunTaskSumbitResponse>(this, "POST", request, JsonUtils.DeSerialize<RunTaskSumbitResponse>);
        }
        
        /// <summary>
        /// 文本内容审核
        ///
        /// 分析并识别用户上传的文本内容是否有敏感内容（如色情、政治等），并将识别结果返回给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunTextModerationResponse RunTextModeration(RunTextModerationRequest runTextModerationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/text", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runTextModerationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunTextModerationResponse>(response);
        }

        public SyncInvoker<RunTextModerationResponse> RunTextModerationInvoker(RunTextModerationRequest runTextModerationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/text", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runTextModerationRequest);
            return new SyncInvoker<RunTextModerationResponse>(this, "POST", request, JsonUtils.DeSerialize<RunTextModerationResponse>);
        }
        
    }
}