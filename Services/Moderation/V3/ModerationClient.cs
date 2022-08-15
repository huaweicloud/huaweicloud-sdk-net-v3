using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Moderation.V3.Model;

namespace HuaweiCloud.SDK.Moderation.V3
{
    public partial class ModerationClient : Client
    {
        public static ClientBuilder<ModerationClient> NewBuilder()
        {
            return new ClientBuilder<ModerationClient>();
        }

        
        /// <summary>
        /// 创建音频内容审核作业
        ///
        /// 分析并识别用户上传的音频内容是否有敏感内容（如色情、政治等），并将识别结果返回给用户
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public RunCreateAudioModerationJobResponse RunCreateAudioModerationJob(RunCreateAudioModerationJobRequest runCreateAudioModerationJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateAudioModerationJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunCreateAudioModerationJobResponse>(response);
        }
        
        /// <summary>
        /// 查询音频内容审核作业
        ///
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public RunQueryAudioModerationJobResponse RunQueryAudioModerationJob(RunQueryAudioModerationJobRequest runQueryAudioModerationJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , runQueryAudioModerationJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryAudioModerationJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<RunQueryAudioModerationJobResponse>(response);
        }
        
        /// <summary>
        /// 文本内容审核
        ///
        /// 分析并识别用户上传的文本内容是否有敏感内容（如色情、政治等），并将识别结果返回给用户
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public RunTextModerationResponse RunTextModeration(RunTextModerationRequest runTextModerationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/text",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runTextModerationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunTextModerationResponse>(response);
        }
        
    }
}