using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Sis.V1.Model;

namespace HuaweiCloud.SDK.Sis.V1
{
    public partial class SisAsyncClient : Client
    {
        public static ClientBuilder<SisAsyncClient> NewBuilder()
        {
            return new ClientBuilder<SisAsyncClient>();
        }

        
        /// <summary>
        /// 获取录音文件识别结果
        ///
        /// 该接口用于获取录音文件识别结果及识别状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CollectTranscriberJobResponse> CollectTranscriberJobAsync(CollectTranscriberJobRequest collectTranscriberJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(collectTranscriberJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/transcriber/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectTranscriberJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CollectTranscriberJobResponse>(response);
        }

        public AsyncInvoker<CollectTranscriberJobResponse> CollectTranscriberJobAsyncInvoker(CollectTranscriberJobRequest collectTranscriberJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(collectTranscriberJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/transcriber/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectTranscriberJobRequest);
            return new AsyncInvoker<CollectTranscriberJobResponse>(this, "GET", request, JsonUtils.DeSerialize<CollectTranscriberJobResponse>);
        }
        
        /// <summary>
        /// 创建热词表
        ///
        /// 新建一个热词表，创建成功返回id。每个用户限制创建10个热词表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateVocabularyResponse> CreateVocabularyAsync(CreateVocabularyRequest createVocabularyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/vocabularies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVocabularyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateVocabularyResponse>(response);
        }

        public AsyncInvoker<CreateVocabularyResponse> CreateVocabularyAsyncInvoker(CreateVocabularyRequest createVocabularyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/vocabularies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVocabularyRequest);
            return new AsyncInvoker<CreateVocabularyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVocabularyResponse>);
        }
        
        /// <summary>
        /// 注册接口
        ///
        /// 客户上传一段录音，并指定voice_name，在系统中注册声音。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateVoiceResponse> CreateVoiceAsync(CreateVoiceRequest createVoiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vcs/voices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVoiceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateVoiceResponse>(response);
        }

        public AsyncInvoker<CreateVoiceResponse> CreateVoiceAsyncInvoker(CreateVoiceRequest createVoiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vcs/voices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVoiceRequest);
            return new AsyncInvoker<CreateVoiceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVoiceResponse>);
        }
        
        /// <summary>
        /// 删除热词表
        ///
        /// 通过热词表id删除热词表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteVocabularyResponse> DeleteVocabularyAsync(DeleteVocabularyRequest deleteVocabularyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteVocabularyRequest.VocabularyId, out var valueOfVocabularyId)) urlParam.Add("vocabulary_id", valueOfVocabularyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/vocabularies/{vocabulary_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVocabularyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteVocabularyResponse>(response);
        }

        public AsyncInvoker<DeleteVocabularyResponse> DeleteVocabularyAsyncInvoker(DeleteVocabularyRequest deleteVocabularyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteVocabularyRequest.VocabularyId, out var valueOfVocabularyId)) urlParam.Add("vocabulary_id", valueOfVocabularyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/vocabularies/{vocabulary_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVocabularyRequest);
            return new AsyncInvoker<DeleteVocabularyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteVocabularyResponse>);
        }
        
        /// <summary>
        /// 合成接口
        ///
        /// 用户指定一个声色名称，并指定对应的文本，合成对应的复刻的声音
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GenerateSpeechResponse> GenerateSpeechAsync(GenerateSpeechRequest generateSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vcs/voices/clone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", generateSpeechRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<GenerateSpeechResponse>(response);
        }

        public AsyncInvoker<GenerateSpeechResponse> GenerateSpeechAsyncInvoker(GenerateSpeechRequest generateSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vcs/voices/clone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", generateSpeechRequest);
            return new AsyncInvoker<GenerateSpeechResponse>(this, "POST", request, JsonUtils.DeSerialize<GenerateSpeechResponse>);
        }
        
        /// <summary>
        /// 查询接口
        ///
        /// 查询已注册的声音列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVoicesResponse> ListVoicesAsync(ListVoicesRequest listVoicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vcs/voices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVoicesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListVoicesResponse>(response);
        }

        public AsyncInvoker<ListVoicesResponse> ListVoicesAsyncInvoker(ListVoicesRequest listVoicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vcs/voices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVoicesRequest);
            return new AsyncInvoker<ListVoicesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVoicesResponse>);
        }
        
        /// <summary>
        /// 提交录音文件识别任务
        ///
        /// **录音文件识别**
        /// 录音文件识别接口，用于识别长录音文件，录音文件放在华为云OBS（对象存储服务）上。
        /// 
        /// 由于录音文件识别通常会需要较长的时间，因此识别是异步的，也即接口分为创建识别任务和查询任务状态两个接口。创建识别任务接口创建任务完成后返回，然后用户通过调用查询任务状态接口来获得转写状态和结果。
        /// 
        /// **功能介绍**
        /// 该接口用于提交录音文件识别任务，其中录音文件保存在用户的OBS桶中。用户开通录音识别服务时，需授权录音文件引擎读取用户OBS桶权限。
        /// 
        /// 接口约束
        /// 录音时长不超过5小时，文件大小不超过300M，识别结果保存72小时（从识别完成的时间算起）。72小时后如果再访问，将会返回 \&quot;task id is not found\&quot;错误。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PushTranscriberJobsResponse> PushTranscriberJobsAsync(PushTranscriberJobsRequest pushTranscriberJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/transcriber/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", pushTranscriberJobsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<PushTranscriberJobsResponse>(response);
        }

        public AsyncInvoker<PushTranscriberJobsResponse> PushTranscriberJobsAsyncInvoker(PushTranscriberJobsRequest pushTranscriberJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/transcriber/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", pushTranscriberJobsRequest);
            return new AsyncInvoker<PushTranscriberJobsResponse>(this, "POST", request, JsonUtils.DeSerialize<PushTranscriberJobsResponse>);
        }
        
        /// <summary>
        /// 录音文件识别极速版
        ///
        /// 极速版ASR(Restful API 接口, 适用于音频(文件大小&lt;&#x3D;100M,语音时长&lt;&#x3D;30分钟)文件的同步识别。
        /// 此接口以POST方式一次性上传整个音频或从华为OBS中下载音频， 识别结果将在请求响应中即刻返回，用于语音文件极速转写，质检分析的离线场景。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeFlashAsrResponse> RecognizeFlashAsrAsync(RecognizeFlashAsrRequest recognizeFlashAsrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/flash", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", recognizeFlashAsrRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeFlashAsrResponse>(response);
        }

        public AsyncInvoker<RecognizeFlashAsrResponse> RecognizeFlashAsrAsyncInvoker(RecognizeFlashAsrRequest recognizeFlashAsrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/flash", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", recognizeFlashAsrRequest);
            return new AsyncInvoker<RecognizeFlashAsrResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeFlashAsrResponse>);
        }
        
        /// <summary>
        /// 一句话识别
        ///
        /// 一句话识别接口，用于短语音的同步识别。一次性上传整个音频，响应中即返回识别结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecognizeShortAudioResponse> RecognizeShortAudioAsync(RecognizeShortAudioRequest recognizeShortAudioRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/short-audio", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeShortAudioRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecognizeShortAudioResponse>(response);
        }

        public AsyncInvoker<RecognizeShortAudioResponse> RecognizeShortAudioAsyncInvoker(RecognizeShortAudioRequest recognizeShortAudioRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/short-audio", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeShortAudioRequest);
            return new AsyncInvoker<RecognizeShortAudioResponse>(this, "POST", request, JsonUtils.DeSerialize<RecognizeShortAudioResponse>);
        }
        
        /// <summary>
        /// 语音合成
        ///
        /// 语音合成，是一种将文本转换成逼真语音的服务。用户通过实时访问和调用API获取语音合成结果，将用户输入的文字合成为音频。通过音色选择、自定义音量、语速，为企业和个人提供个性化的发音服务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunTtsResponse> RunTtsAsync(RunTtsRequest runTtsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runTtsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RunTtsResponse>(response);
        }

        public AsyncInvoker<RunTtsResponse> RunTtsAsyncInvoker(RunTtsRequest runTtsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runTtsRequest);
            return new AsyncInvoker<RunTtsResponse>(this, "POST", request, JsonUtils.DeSerialize<RunTtsResponse>);
        }
        
        /// <summary>
        /// 查询热词表列表
        ///
        /// 查询用户所有热词表列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVocabulariesResponse> ShowVocabulariesAsync(ShowVocabulariesRequest showVocabulariesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/vocabularies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showVocabulariesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowVocabulariesResponse>(response);
        }

        public AsyncInvoker<ShowVocabulariesResponse> ShowVocabulariesAsyncInvoker(ShowVocabulariesRequest showVocabulariesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/vocabularies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showVocabulariesRequest);
            return new AsyncInvoker<ShowVocabulariesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVocabulariesResponse>);
        }
        
        /// <summary>
        /// 查询热词表信息
        ///
        /// 通过热词表id查询热词表的信息和内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVocabularyResponse> ShowVocabularyAsync(ShowVocabularyRequest showVocabularyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showVocabularyRequest.VocabularyId, out var valueOfVocabularyId)) urlParam.Add("vocabulary_id", valueOfVocabularyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/vocabularies/{vocabulary_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVocabularyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowVocabularyResponse>(response);
        }

        public AsyncInvoker<ShowVocabularyResponse> ShowVocabularyAsyncInvoker(ShowVocabularyRequest showVocabularyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showVocabularyRequest.VocabularyId, out var valueOfVocabularyId)) urlParam.Add("vocabulary_id", valueOfVocabularyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/vocabularies/{vocabulary_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVocabularyRequest);
            return new AsyncInvoker<ShowVocabularyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVocabularyResponse>);
        }
        
        /// <summary>
        /// 更新热词表
        ///
        /// 更新一个热词表，更新成功返回id。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateVocabularyResponse> UpdateVocabularyAsync(UpdateVocabularyRequest updateVocabularyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateVocabularyRequest.VocabularyId, out var valueOfVocabularyId)) urlParam.Add("vocabulary_id", valueOfVocabularyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/vocabularies/{vocabulary_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVocabularyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateVocabularyResponse>(response);
        }

        public AsyncInvoker<UpdateVocabularyResponse> UpdateVocabularyAsyncInvoker(UpdateVocabularyRequest updateVocabularyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateVocabularyRequest.VocabularyId, out var valueOfVocabularyId)) urlParam.Add("vocabulary_id", valueOfVocabularyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/vocabularies/{vocabulary_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVocabularyRequest);
            return new AsyncInvoker<UpdateVocabularyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateVocabularyResponse>);
        }
        
    }
}