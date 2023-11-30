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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/image",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkImageModerationRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CheckImageModerationResponse>(response);
        }

        public AsyncInvoker<CheckImageModerationResponse> CheckImageModerationAsyncInvoker(CheckImageModerationRequest checkImageModerationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/image",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkImageModerationRequest);
            return new AsyncInvoker<CheckImageModerationResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckImageModerationResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runCloseAudioStreamModerationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio-stream/jobs/stop/{job_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCloseAudioStreamModerationJobRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunCloseAudioStreamModerationJobResponse>(response);
        }

        public AsyncInvoker<RunCloseAudioStreamModerationJobResponse> RunCloseAudioStreamModerationJobAsyncInvoker(RunCloseAudioStreamModerationJobRequest runCloseAudioStreamModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runCloseAudioStreamModerationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio-stream/jobs/stop/{job_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCloseAudioStreamModerationJobRequest);
            return new AsyncInvoker<RunCloseAudioStreamModerationJobResponse>(this, "POST", request, JsonUtils.DeSerialize<RunCloseAudioStreamModerationJobResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runCloseVideoStreamModerationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/video-stream/jobs/stop/{job_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCloseVideoStreamModerationJobRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunCloseVideoStreamModerationJobResponse>(response);
        }

        public AsyncInvoker<RunCloseVideoStreamModerationJobResponse> RunCloseVideoStreamModerationJobAsyncInvoker(RunCloseVideoStreamModerationJobRequest runCloseVideoStreamModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runCloseVideoStreamModerationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/video-stream/jobs/stop/{job_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCloseVideoStreamModerationJobRequest);
            return new AsyncInvoker<RunCloseVideoStreamModerationJobResponse>(this, "POST", request, JsonUtils.DeSerialize<RunCloseVideoStreamModerationJobResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio/jobs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateAudioModerationJobRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunCreateAudioModerationJobResponse>(response);
        }

        public AsyncInvoker<RunCreateAudioModerationJobResponse> RunCreateAudioModerationJobAsyncInvoker(RunCreateAudioModerationJobRequest runCreateAudioModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio/jobs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateAudioModerationJobRequest);
            return new AsyncInvoker<RunCreateAudioModerationJobResponse>(this, "POST", request, JsonUtils.DeSerialize<RunCreateAudioModerationJobResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio-stream/jobs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateAudioStreamModerationJobRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunCreateAudioStreamModerationJobResponse>(response);
        }

        public AsyncInvoker<RunCreateAudioStreamModerationJobResponse> RunCreateAudioStreamModerationJobAsyncInvoker(RunCreateAudioStreamModerationJobRequest runCreateAudioStreamModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio-stream/jobs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateAudioStreamModerationJobRequest);
            return new AsyncInvoker<RunCreateAudioStreamModerationJobResponse>(this, "POST", request, JsonUtils.DeSerialize<RunCreateAudioStreamModerationJobResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/document/jobs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateDocumentModerationJobRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunCreateDocumentModerationJobResponse>(response);
        }

        public AsyncInvoker<RunCreateDocumentModerationJobResponse> RunCreateDocumentModerationJobAsyncInvoker(RunCreateDocumentModerationJobRequest runCreateDocumentModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/document/jobs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateDocumentModerationJobRequest);
            return new AsyncInvoker<RunCreateDocumentModerationJobResponse>(this, "POST", request, JsonUtils.DeSerialize<RunCreateDocumentModerationJobResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/video/jobs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateVideoModerationJobRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunCreateVideoModerationJobResponse>(response);
        }

        public AsyncInvoker<RunCreateVideoModerationJobResponse> RunCreateVideoModerationJobAsyncInvoker(RunCreateVideoModerationJobRequest runCreateVideoModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/video/jobs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateVideoModerationJobRequest);
            return new AsyncInvoker<RunCreateVideoModerationJobResponse>(this, "POST", request, JsonUtils.DeSerialize<RunCreateVideoModerationJobResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/video-stream/jobs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateVideoStreamModerationJobRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunCreateVideoStreamModerationJobResponse>(response);
        }

        public AsyncInvoker<RunCreateVideoStreamModerationJobResponse> RunCreateVideoStreamModerationJobAsyncInvoker(RunCreateVideoStreamModerationJobRequest runCreateVideoStreamModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/video-stream/jobs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateVideoStreamModerationJobRequest);
            return new AsyncInvoker<RunCreateVideoStreamModerationJobResponse>(this, "POST", request, JsonUtils.DeSerialize<RunCreateVideoStreamModerationJobResponse>);
        }
        
        /// <summary>
        /// 查询音频内容审核作业
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunQueryAudioModerationJobResponse> RunQueryAudioModerationJobAsync(RunQueryAudioModerationJobRequest runQueryAudioModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runQueryAudioModerationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio/jobs/{job_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryAudioModerationJobRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<RunQueryAudioModerationJobResponse>(response);
        }

        public AsyncInvoker<RunQueryAudioModerationJobResponse> RunQueryAudioModerationJobAsyncInvoker(RunQueryAudioModerationJobRequest runQueryAudioModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runQueryAudioModerationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio/jobs/{job_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryAudioModerationJobRequest);
            return new AsyncInvoker<RunQueryAudioModerationJobResponse>(this, "GET", request, JsonUtils.DeSerialize<RunQueryAudioModerationJobResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runQueryDocumentModerationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/document/jobs/{job_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryDocumentModerationJobRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<RunQueryDocumentModerationJobResponse>(response);
        }

        public AsyncInvoker<RunQueryDocumentModerationJobResponse> RunQueryDocumentModerationJobAsyncInvoker(RunQueryDocumentModerationJobRequest runQueryDocumentModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runQueryDocumentModerationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/document/jobs/{job_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryDocumentModerationJobRequest);
            return new AsyncInvoker<RunQueryDocumentModerationJobResponse>(this, "GET", request, JsonUtils.DeSerialize<RunQueryDocumentModerationJobResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runQueryVideoModerationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/video/jobs/{job_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryVideoModerationJobRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<RunQueryVideoModerationJobResponse>(response);
        }

        public AsyncInvoker<RunQueryVideoModerationJobResponse> RunQueryVideoModerationJobAsyncInvoker(RunQueryVideoModerationJobRequest runQueryVideoModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runQueryVideoModerationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/video/jobs/{job_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryVideoModerationJobRequest);
            return new AsyncInvoker<RunQueryVideoModerationJobResponse>(this, "GET", request, JsonUtils.DeSerialize<RunQueryVideoModerationJobResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/text",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runTextModerationRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunTextModerationResponse>(response);
        }

        public AsyncInvoker<RunTextModerationResponse> RunTextModerationAsyncInvoker(RunTextModerationRequest runTextModerationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/text",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runTextModerationRequest);
            return new AsyncInvoker<RunTextModerationResponse>(this, "POST", request, JsonUtils.DeSerialize<RunTextModerationResponse>);
        }
        
    }
}