using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Moderation.V2.Model;

namespace HuaweiCloud.SDK.Moderation.V2
{
    public partial class ModerationAsyncClient : Client
    {
        public static ClientBuilder<ModerationAsyncClient> NewBuilder()
        {
            return new ClientBuilder<ModerationAsyncClient>();
        }

        
        /// <summary>
        /// 处理结果查询
        ///
        /// 分析并识别用户上传的图像内容是否有敏感内容（如涉及政治人物、暴恐元素、涉黄内容等），并将识别结果返回给用户。
        /// &gt; 任务最长保留时间为30分钟，过期后会被清理掉。建议在任务提交后，每30s进行一次周期查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunCheckResultResponse> RunCheckResultAsync(RunCheckResultRequest runCheckResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image/batch",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCheckResultRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<RunCheckResultResponse>(response);
        }

        public AsyncInvoker<RunCheckResultResponse> RunCheckResultAsyncInvoker(RunCheckResultRequest runCheckResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image/batch",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCheckResultRequest);
            return new AsyncInvoker<RunCheckResultResponse>(this, "GET", request, JsonUtils.DeSerialize<RunCheckResultResponse>);
        }
        
        /// <summary>
        /// 任务列表查询
        ///
        /// 查询批量图像内容审核任务列表，可通过指定任务状态查询来对任务列表进行过滤。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunCheckTaskJobsResponse> RunCheckTaskJobsAsync(RunCheckTaskJobsRequest runCheckTaskJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image/batch/jobs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCheckTaskJobsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<RunCheckTaskJobsResponse>(response);
        }

        public AsyncInvoker<RunCheckTaskJobsResponse> RunCheckTaskJobsAsyncInvoker(RunCheckTaskJobsRequest runCheckTaskJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image/batch/jobs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCheckTaskJobsRequest);
            return new AsyncInvoker<RunCheckTaskJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<RunCheckTaskJobsResponse>);
        }
        
        /// <summary>
        /// 图像内容审核（批量）
        ///
        /// 分析并识别用户上传的图像内容是否有敏感内容（如涉及政治人物、暴恐元素、涉黄内容等），并将识别结果返回给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunImageBatchModerationResponse> RunImageBatchModerationAsync(RunImageBatchModerationRequest runImageBatchModerationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image/batch",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageBatchModerationRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunImageBatchModerationResponse>(response);
        }

        public AsyncInvoker<RunImageBatchModerationResponse> RunImageBatchModerationAsyncInvoker(RunImageBatchModerationRequest runImageBatchModerationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image/batch",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageBatchModerationRequest);
            return new AsyncInvoker<RunImageBatchModerationResponse>(this, "POST", request, JsonUtils.DeSerialize<RunImageBatchModerationResponse>);
        }
        
        /// <summary>
        /// 图像内容审核
        ///
        /// 分析并识别用户上传的图像内容是否有敏感内容（如涉及政治人物、暴恐元素、涉黄内容等），并将识别结果返回给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunImageModerationResponse> RunImageModerationAsync(RunImageModerationRequest runImageModerationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageModerationRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunImageModerationResponse>(response);
        }

        public AsyncInvoker<RunImageModerationResponse> RunImageModerationAsyncInvoker(RunImageModerationRequest runImageModerationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageModerationRequest);
            return new AsyncInvoker<RunImageModerationResponse>(this, "POST", request, JsonUtils.DeSerialize<RunImageModerationResponse>);
        }
        
        /// <summary>
        /// 语音内容审核
        ///
        /// 分析并识别用户上传的语音内容是否有敏感内容（如色情、政治等），并将识别结果 返回给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunModerationAudioResponse> RunModerationAudioAsync(RunModerationAudioRequest runModerationAudioRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/voice",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runModerationAudioRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunModerationAudioResponse>(response);
        }

        public AsyncInvoker<RunModerationAudioResponse> RunModerationAudioAsyncInvoker(RunModerationAudioRequest runModerationAudioRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/voice",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runModerationAudioRequest);
            return new AsyncInvoker<RunModerationAudioResponse>(this, "POST", request, JsonUtils.DeSerialize<RunModerationAudioResponse>);
        }
        
        /// <summary>
        /// 任务提交
        ///
        /// 提交批量图像内容审核任务，返回任务标识，任务标识可用于查询任务结果。此接口为异步接口，相对于批量接口，支持更大图片列表批次。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunTaskSumbitResponse> RunTaskSumbitAsync(RunTaskSumbitRequest runTaskSumbitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image/batch/jobs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runTaskSumbitRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunTaskSumbitResponse>(response);
        }

        public AsyncInvoker<RunTaskSumbitResponse> RunTaskSumbitAsyncInvoker(RunTaskSumbitRequest runTaskSumbitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image/batch/jobs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runTaskSumbitRequest);
            return new AsyncInvoker<RunTaskSumbitResponse>(this, "POST", request, JsonUtils.DeSerialize<RunTaskSumbitResponse>);
        }
        
        /// <summary>
        /// 文本内容审核
        ///
        /// 分析并识别用户上传的文本内容是否有敏感内容（如色情、政治等），并将识别结果返回给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunTextModerationResponse> RunTextModerationAsync(RunTextModerationRequest runTextModerationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/text",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runTextModerationRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunTextModerationResponse>(response);
        }

        public AsyncInvoker<RunTextModerationResponse> RunTextModerationAsyncInvoker(RunTextModerationRequest runTextModerationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/text",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runTextModerationRequest);
            return new AsyncInvoker<RunTextModerationResponse>(this, "POST", request, JsonUtils.DeSerialize<RunTextModerationResponse>);
        }
        
    }
}