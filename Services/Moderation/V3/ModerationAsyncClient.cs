using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Moderation.V3.Model;

namespace HuaweiCloud.SDK.Moderation.V3
{
    public partial class ModerationAsyncClient : Client
    {
        public static ClientBuilder<ModerationAsyncClient> NewBuilder()
        {
            return new ClientBuilder<ModerationAsyncClient>();
        }

        
        /// <summary>
        /// 图像内容审核
        ///
        /// 分析并识别用户上传的图像内容是否有敏感内容（如涉及暴恐元素、涉黄内容等），并将识别结果返回给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckImageModerationResponse> CheckImageModerationAsync(CheckImageModerationRequest checkImageModerationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/image",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkImageModerationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CheckImageModerationResponse>(response);
        }
        
        /// <summary>
        /// 关闭音频流内容审核作业
        ///
        /// 关闭音频流内容审核作业
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunCloseAudioStreamModerationJobResponse> RunCloseAudioStreamModerationJobAsync(RunCloseAudioStreamModerationJobRequest runCloseAudioStreamModerationJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , runCloseAudioStreamModerationJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio-stream/jobs/stop/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCloseAudioStreamModerationJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunCloseAudioStreamModerationJobResponse>(response);
        }
        
        /// <summary>
        /// 关闭视频流内容审核作业
        ///
        /// 关闭视频流审核接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunCloseVideoStreamModerationJobResponse> RunCloseVideoStreamModerationJobAsync(RunCloseVideoStreamModerationJobRequest runCloseVideoStreamModerationJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , runCloseVideoStreamModerationJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/video-stream/jobs/stop/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCloseVideoStreamModerationJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunCloseVideoStreamModerationJobResponse>(response);
        }
        
        /// <summary>
        /// 创建音频内容审核作业
        ///
        /// 分析并识别用户上传的音频内容是否有敏感内容（如色情、政治等），并将识别结果返回给用户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunCreateAudioModerationJobResponse> RunCreateAudioModerationJobAsync(RunCreateAudioModerationJobRequest runCreateAudioModerationJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateAudioModerationJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunCreateAudioModerationJobResponse>(response);
        }
        
        /// <summary>
        /// 创建音频流内容审核作业
        ///
        /// 创建音频流内容审核作业，创建成功会将作业ID返回给用户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunCreateAudioStreamModerationJobResponse> RunCreateAudioStreamModerationJobAsync(RunCreateAudioStreamModerationJobRequest runCreateAudioStreamModerationJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio-stream/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateAudioStreamModerationJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunCreateAudioStreamModerationJobResponse>(response);
        }
        
        /// <summary>
        /// 创建文档内容审核作业
        ///
        /// 创建文档内容审核作业，创建成功会将作业ID返回给用户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunCreateDocumentModerationJobResponse> RunCreateDocumentModerationJobAsync(RunCreateDocumentModerationJobRequest runCreateDocumentModerationJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/document/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateDocumentModerationJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunCreateDocumentModerationJobResponse>(response);
        }
        
        /// <summary>
        /// 创建视频内容审核作业
        ///
        /// 创建视频内容审核作业，创建成功会将作业ID返回给用户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunCreateVideoModerationJobResponse> RunCreateVideoModerationJobAsync(RunCreateVideoModerationJobRequest runCreateVideoModerationJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/video/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateVideoModerationJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunCreateVideoModerationJobResponse>(response);
        }
        
        /// <summary>
        /// 创建视频流内容审核作业
        ///
        /// 创建视频流内容审核作业，创建成功会将作业ID返回给用户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunCreateVideoStreamModerationJobResponse> RunCreateVideoStreamModerationJobAsync(RunCreateVideoStreamModerationJobRequest runCreateVideoStreamModerationJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/video-stream/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateVideoStreamModerationJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunCreateVideoStreamModerationJobResponse>(response);
        }
        
        /// <summary>
        /// 查询音频内容审核作业
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunQueryAudioModerationJobResponse> RunQueryAudioModerationJobAsync(RunQueryAudioModerationJobRequest runQueryAudioModerationJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , runQueryAudioModerationJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryAudioModerationJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<RunQueryAudioModerationJobResponse>(response);
        }
        
        /// <summary>
        /// 查询文档审核作业结果
        ///
        /// 查询文档审核结果接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunQueryDocumentModerationJobResponse> RunQueryDocumentModerationJobAsync(RunQueryDocumentModerationJobRequest runQueryDocumentModerationJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , runQueryDocumentModerationJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/document/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryDocumentModerationJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<RunQueryDocumentModerationJobResponse>(response);
        }
        
        /// <summary>
        /// 查询视频内容审核作业
        ///
        /// 查询视频审核作业处理状态与结果，并将识别结果返回给用户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunQueryVideoModerationJobResponse> RunQueryVideoModerationJobAsync(RunQueryVideoModerationJobRequest runQueryVideoModerationJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , runQueryVideoModerationJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/video/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryVideoModerationJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<RunQueryVideoModerationJobResponse>(response);
        }
        
        /// <summary>
        /// 文本内容审核
        ///
        /// 分析并识别用户上传的文本内容是否有敏感内容（如色情、政治等），并将识别结果返回给用户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunTextModerationResponse> RunTextModerationAsync(RunTextModerationRequest runTextModerationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/text",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runTextModerationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunTextModerationResponse>(response);
        }
        
    }
}