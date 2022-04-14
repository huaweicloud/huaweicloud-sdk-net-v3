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
        /// </summary>
        public async Task<RunCheckResultResponse> RunCheckResultAsync(RunCheckResultRequest runCheckResultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image/batch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCheckResultRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<RunCheckResultResponse>(response);
        }
        
        /// <summary>
        /// 任务列表查询
        /// </summary>
        public async Task<RunCheckTaskJobsResponse> RunCheckTaskJobsAsync(RunCheckTaskJobsRequest runCheckTaskJobsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image/batch/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCheckTaskJobsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<RunCheckTaskJobsResponse>(response);
        }
        
        /// <summary>
        /// 图像内容审核（批量）
        /// </summary>
        public async Task<RunImageBatchModerationResponse> RunImageBatchModerationAsync(RunImageBatchModerationRequest runImageBatchModerationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image/batch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageBatchModerationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunImageBatchModerationResponse>(response);
        }
        
        /// <summary>
        /// 图像内容审核
        /// </summary>
        public async Task<RunImageModerationResponse> RunImageModerationAsync(RunImageModerationRequest runImageModerationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageModerationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunImageModerationResponse>(response);
        }
        
        /// <summary>
        /// 语音内容审核
        /// </summary>
        public async Task<RunModerationAudioResponse> RunModerationAudioAsync(RunModerationAudioRequest runModerationAudioRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/voice",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runModerationAudioRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunModerationAudioResponse>(response);
        }
        
        /// <summary>
        /// 任务提交
        /// </summary>
        public async Task<RunTaskSumbitResponse> RunTaskSumbitAsync(RunTaskSumbitRequest runTaskSumbitRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/image/batch/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runTaskSumbitRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunTaskSumbitResponse>(response);
        }
        
        /// <summary>
        /// 文本内容审核
        /// </summary>
        public async Task<RunTextModerationResponse> RunTextModerationAsync(RunTextModerationRequest runTextModerationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/moderation/text",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runTextModerationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunTextModerationResponse>(response);
        }
        
    }
}