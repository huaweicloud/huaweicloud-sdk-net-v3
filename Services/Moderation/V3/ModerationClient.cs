using System;
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
        /// 图像审核批量同步接口
        ///
        /// 图像审核批量同步接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCheckImageSyncResponse BatchCheckImageSync(BatchCheckImageSyncRequest batchCheckImageSyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/image/batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCheckImageSyncRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCheckImageSyncResponse>(response);
        }

        public SyncInvoker<BatchCheckImageSyncResponse> BatchCheckImageSyncInvoker(BatchCheckImageSyncRequest batchCheckImageSyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/image/batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCheckImageSyncRequest);
            return new SyncInvoker<BatchCheckImageSyncResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCheckImageSyncResponse>);
        }
        
        /// <summary>
        /// 图像内容审核
        ///
        /// 分析并识别用户上传的图像内容是否有敏感内容（如涉及暴恐元素、涉黄内容等），并将识别结果返回给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckImageModerationResponse CheckImageModeration(CheckImageModerationRequest checkImageModerationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkImageModerationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CheckImageModerationResponse>(response);
        }

        public SyncInvoker<CheckImageModerationResponse> CheckImageModerationInvoker(CheckImageModerationRequest checkImageModerationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkImageModerationRequest);
            return new SyncInvoker<CheckImageModerationResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckImageModerationResponse>);
        }
        
        /// <summary>
        /// 关闭音频流内容审核作业
        ///
        /// 关闭音频流内容审核作业
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunCloseAudioStreamModerationJobResponse RunCloseAudioStreamModerationJob(RunCloseAudioStreamModerationJobRequest runCloseAudioStreamModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runCloseAudioStreamModerationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio-stream/jobs/stop/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCloseAudioStreamModerationJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunCloseAudioStreamModerationJobResponse>(response);
        }

        public SyncInvoker<RunCloseAudioStreamModerationJobResponse> RunCloseAudioStreamModerationJobInvoker(RunCloseAudioStreamModerationJobRequest runCloseAudioStreamModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runCloseAudioStreamModerationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio-stream/jobs/stop/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCloseAudioStreamModerationJobRequest);
            return new SyncInvoker<RunCloseAudioStreamModerationJobResponse>(this, "POST", request, JsonUtils.DeSerialize<RunCloseAudioStreamModerationJobResponse>);
        }
        
        /// <summary>
        /// 关闭视频流内容审核作业
        ///
        /// 关闭视频流审核接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunCloseVideoStreamModerationJobResponse RunCloseVideoStreamModerationJob(RunCloseVideoStreamModerationJobRequest runCloseVideoStreamModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runCloseVideoStreamModerationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/video-stream/jobs/stop/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCloseVideoStreamModerationJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunCloseVideoStreamModerationJobResponse>(response);
        }

        public SyncInvoker<RunCloseVideoStreamModerationJobResponse> RunCloseVideoStreamModerationJobInvoker(RunCloseVideoStreamModerationJobRequest runCloseVideoStreamModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runCloseVideoStreamModerationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/video-stream/jobs/stop/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCloseVideoStreamModerationJobRequest);
            return new SyncInvoker<RunCloseVideoStreamModerationJobResponse>(this, "POST", request, JsonUtils.DeSerialize<RunCloseVideoStreamModerationJobResponse>);
        }
        
        /// <summary>
        /// 创建音频内容审核作业
        ///
        /// 分析并识别用户上传的音频内容是否有敏感内容（如色情、政治等），并将识别结果返回给用户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunCreateAudioModerationJobResponse RunCreateAudioModerationJob(RunCreateAudioModerationJobRequest runCreateAudioModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateAudioModerationJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunCreateAudioModerationJobResponse>(response);
        }

        public SyncInvoker<RunCreateAudioModerationJobResponse> RunCreateAudioModerationJobInvoker(RunCreateAudioModerationJobRequest runCreateAudioModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateAudioModerationJobRequest);
            return new SyncInvoker<RunCreateAudioModerationJobResponse>(this, "POST", request, JsonUtils.DeSerialize<RunCreateAudioModerationJobResponse>);
        }
        
        /// <summary>
        /// 创建音频流内容审核作业
        ///
        /// 创建音频流内容审核作业，创建成功会将作业ID返回给用户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunCreateAudioStreamModerationJobResponse RunCreateAudioStreamModerationJob(RunCreateAudioStreamModerationJobRequest runCreateAudioStreamModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio-stream/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateAudioStreamModerationJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunCreateAudioStreamModerationJobResponse>(response);
        }

        public SyncInvoker<RunCreateAudioStreamModerationJobResponse> RunCreateAudioStreamModerationJobInvoker(RunCreateAudioStreamModerationJobRequest runCreateAudioStreamModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio-stream/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateAudioStreamModerationJobRequest);
            return new SyncInvoker<RunCreateAudioStreamModerationJobResponse>(this, "POST", request, JsonUtils.DeSerialize<RunCreateAudioStreamModerationJobResponse>);
        }
        
        /// <summary>
        /// 创建文档内容审核作业
        ///
        /// 创建文档内容审核作业，创建成功会将作业ID返回给用户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunCreateDocumentModerationJobResponse RunCreateDocumentModerationJob(RunCreateDocumentModerationJobRequest runCreateDocumentModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/document/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateDocumentModerationJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunCreateDocumentModerationJobResponse>(response);
        }

        public SyncInvoker<RunCreateDocumentModerationJobResponse> RunCreateDocumentModerationJobInvoker(RunCreateDocumentModerationJobRequest runCreateDocumentModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/document/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateDocumentModerationJobRequest);
            return new SyncInvoker<RunCreateDocumentModerationJobResponse>(this, "POST", request, JsonUtils.DeSerialize<RunCreateDocumentModerationJobResponse>);
        }
        
        /// <summary>
        /// 创建视频内容审核作业
        ///
        /// 创建视频内容审核作业，创建成功会将作业ID返回给用户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunCreateVideoModerationJobResponse RunCreateVideoModerationJob(RunCreateVideoModerationJobRequest runCreateVideoModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/video/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateVideoModerationJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunCreateVideoModerationJobResponse>(response);
        }

        public SyncInvoker<RunCreateVideoModerationJobResponse> RunCreateVideoModerationJobInvoker(RunCreateVideoModerationJobRequest runCreateVideoModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/video/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateVideoModerationJobRequest);
            return new SyncInvoker<RunCreateVideoModerationJobResponse>(this, "POST", request, JsonUtils.DeSerialize<RunCreateVideoModerationJobResponse>);
        }
        
        /// <summary>
        /// 创建视频流内容审核作业
        ///
        /// 创建视频流内容审核作业，创建成功会将作业ID返回给用户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunCreateVideoStreamModerationJobResponse RunCreateVideoStreamModerationJob(RunCreateVideoStreamModerationJobRequest runCreateVideoStreamModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/video-stream/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateVideoStreamModerationJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunCreateVideoStreamModerationJobResponse>(response);
        }

        public SyncInvoker<RunCreateVideoStreamModerationJobResponse> RunCreateVideoStreamModerationJobInvoker(RunCreateVideoStreamModerationJobRequest runCreateVideoStreamModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/video-stream/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCreateVideoStreamModerationJobRequest);
            return new SyncInvoker<RunCreateVideoStreamModerationJobResponse>(this, "POST", request, JsonUtils.DeSerialize<RunCreateVideoStreamModerationJobResponse>);
        }
        
        /// <summary>
        /// 查询音频内容审核作业
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunQueryAudioModerationJobResponse RunQueryAudioModerationJob(RunQueryAudioModerationJobRequest runQueryAudioModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runQueryAudioModerationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryAudioModerationJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<RunQueryAudioModerationJobResponse>(response);
        }

        public SyncInvoker<RunQueryAudioModerationJobResponse> RunQueryAudioModerationJobInvoker(RunQueryAudioModerationJobRequest runQueryAudioModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runQueryAudioModerationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/audio/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryAudioModerationJobRequest);
            return new SyncInvoker<RunQueryAudioModerationJobResponse>(this, "GET", request, JsonUtils.DeSerialize<RunQueryAudioModerationJobResponse>);
        }
        
        /// <summary>
        /// 查询文档审核作业结果
        ///
        /// 查询文档审核结果接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunQueryDocumentModerationJobResponse RunQueryDocumentModerationJob(RunQueryDocumentModerationJobRequest runQueryDocumentModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runQueryDocumentModerationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/document/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryDocumentModerationJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<RunQueryDocumentModerationJobResponse>(response);
        }

        public SyncInvoker<RunQueryDocumentModerationJobResponse> RunQueryDocumentModerationJobInvoker(RunQueryDocumentModerationJobRequest runQueryDocumentModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runQueryDocumentModerationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/document/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryDocumentModerationJobRequest);
            return new SyncInvoker<RunQueryDocumentModerationJobResponse>(this, "GET", request, JsonUtils.DeSerialize<RunQueryDocumentModerationJobResponse>);
        }
        
        /// <summary>
        /// 查询视频内容审核作业
        ///
        /// 查询视频审核作业处理状态与结果，并将识别结果返回给用户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunQueryVideoModerationJobResponse RunQueryVideoModerationJob(RunQueryVideoModerationJobRequest runQueryVideoModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runQueryVideoModerationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/video/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryVideoModerationJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<RunQueryVideoModerationJobResponse>(response);
        }

        public SyncInvoker<RunQueryVideoModerationJobResponse> RunQueryVideoModerationJobInvoker(RunQueryVideoModerationJobRequest runQueryVideoModerationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", runQueryVideoModerationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/video/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryVideoModerationJobRequest);
            return new SyncInvoker<RunQueryVideoModerationJobResponse>(this, "GET", request, JsonUtils.DeSerialize<RunQueryVideoModerationJobResponse>);
        }
        
        /// <summary>
        /// 文本内容审核
        ///
        /// 分析并识别用户上传的文本内容是否有敏感内容（如色情、政治等），并将识别结果返回给用户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunTextModerationResponse RunTextModeration(RunTextModerationRequest runTextModerationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/text", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runTextModerationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunTextModerationResponse>(response);
        }

        public SyncInvoker<RunTextModerationResponse> RunTextModerationInvoker(RunTextModerationRequest runTextModerationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/moderation/text", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runTextModerationRequest);
            return new SyncInvoker<RunTextModerationResponse>(this, "POST", request, JsonUtils.DeSerialize<RunTextModerationResponse>);
        }
        
    }
}