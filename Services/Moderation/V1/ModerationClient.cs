using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Moderation.V1.Model;

namespace HuaweiCloud.SDK.Moderation.V1
{
    public partial class ModerationClient : Client
    {
        public static ClientBuilder<ModerationClient> NewBuilder()
        {
            return new ClientBuilder<ModerationClient>();
        }

        
        /// <summary>
        /// 图像内容检测（异步批量）- 处理结果查询
        /// </summary>
        public RunCheckResultResponse RunCheckResult(RunCheckResultRequest runCheckResultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/moderation/image/batch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCheckResultRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<RunCheckResultResponse>(response);
        }
        
        /// <summary>
        /// 图像内容检测（批量）- 任务列表查询
        /// </summary>
        public RunCheckTaskJobsResponse RunCheckTaskJobs(RunCheckTaskJobsRequest runCheckTaskJobsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/moderation/image/batch/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCheckTaskJobsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<RunCheckTaskJobsResponse>(response);
        }
        
        /// <summary>
        /// 图像内容检测（批量）
        /// </summary>
        public RunImageBatchModerationResponse RunImageBatchModeration(RunImageBatchModerationRequest runImageBatchModerationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/moderation/image/batch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageBatchModerationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunImageBatchModerationResponse>(response);
        }
        
        /// <summary>
        /// 图像内容检测
        /// </summary>
        public RunImageModerationResponse RunImageModeration(RunImageModerationRequest runImageModerationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/moderation/image",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageModerationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunImageModerationResponse>(response);
        }
        
        /// <summary>
        /// 图像内容检测（批量）- 任务提交
        /// </summary>
        public RunTaskSumbitResponse RunTaskSumbit(RunTaskSumbitRequest runTaskSumbitRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/moderation/image/batch/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runTaskSumbitRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunTaskSumbitResponse>(response);
        }
        
        /// <summary>
        /// 文本内容检测
        /// </summary>
        public RunTextModerationResponse RunTextModeration(RunTextModerationRequest runTextModerationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/moderation/text",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runTextModerationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunTextModerationResponse>(response);
        }
        
    }
}