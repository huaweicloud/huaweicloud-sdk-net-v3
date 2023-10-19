using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Sis.V1.Model;

namespace HuaweiCloud.SDK.Sis.V1
{
    public partial class SisClient : Client
    {
        public static ClientBuilder<SisClient> NewBuilder()
        {
            return new ClientBuilder<SisClient>();
        }

        
        /// <summary>
        /// 获取录音文件识别结果
        ///
        /// 该接口用于获取录音文件识别结果及识别状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CollectTranscriberJobResponse CollectTranscriberJob(CollectTranscriberJobRequest collectTranscriberJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , collectTranscriberJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/transcriber/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectTranscriberJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<CollectTranscriberJobResponse>(response);
        }
        
        /// <summary>
        /// 创建热词表
        ///
        /// 新建一个热词表，创建成功返回id。每个用户限制创建10个热词表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVocabularyResponse CreateVocabulary(CreateVocabularyRequest createVocabularyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/vocabularies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVocabularyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVocabularyResponse>(response);
        }
        
        /// <summary>
        /// 删除热词表
        ///
        /// 通过热词表id删除热词表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteVocabularyResponse DeleteVocabulary(DeleteVocabularyRequest deleteVocabularyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vocabulary_id" , deleteVocabularyRequest.VocabularyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/vocabularies/{vocabulary_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVocabularyRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVocabularyResponse>(response);
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
        public PushTranscriberJobsResponse PushTranscriberJobs(PushTranscriberJobsRequest pushTranscriberJobsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/transcriber/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", pushTranscriberJobsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<PushTranscriberJobsResponse>(response);
        }
        
        /// <summary>
        /// 录音文件识别极速版
        ///
        /// 极速版ASR(Restful API 接口, 适用于音频(文件大小&lt;&#x3D;100M,语音时长&lt;&#x3D;30分钟)文件的同步识别。
        /// 此接口以POST方式一次性上传整个音频或从华为OBS中下载音频， 识别结果将在请求响应中即刻返回，用于语音文件极速转写，质检分析的离线场景。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RecognizeFlashAsrResponse RecognizeFlashAsr(RecognizeFlashAsrRequest recognizeFlashAsrRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/flash",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", recognizeFlashAsrRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeFlashAsrResponse>(response);
        }
        
        /// <summary>
        /// 一句话识别
        ///
        /// 一句话识别接口，用于短语音的同步识别。一次性上传整个音频，响应中即返回识别结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RecognizeShortAudioResponse RecognizeShortAudio(RecognizeShortAudioRequest recognizeShortAudioRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/short-audio",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeShortAudioRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RecognizeShortAudioResponse>(response);
        }
        
        /// <summary>
        /// 语音合成
        ///
        /// 语音合成，是一种将文本转换成逼真语音的服务。用户通过实时访问和调用API获取语音合成结果，将用户输入的文字合成为音频。通过音色选择、自定义音量、语速，为企业和个人提供个性化的发音服务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunTtsResponse RunTts(RunTtsRequest runTtsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tts",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runTtsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunTtsResponse>(response);
        }
        
        /// <summary>
        /// 查询热词表列表
        ///
        /// 查询用户所有热词表列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVocabulariesResponse ShowVocabularies(ShowVocabulariesRequest showVocabulariesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/vocabularies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showVocabulariesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVocabulariesResponse>(response);
        }
        
        /// <summary>
        /// 查询热词表信息
        ///
        /// 通过热词表id查询热词表的信息和内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVocabularyResponse ShowVocabulary(ShowVocabularyRequest showVocabularyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vocabulary_id" , showVocabularyRequest.VocabularyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/vocabularies/{vocabulary_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVocabularyRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVocabularyResponse>(response);
        }
        
        /// <summary>
        /// 更新热词表
        ///
        /// 更新一个热词表，更新成功返回id。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateVocabularyResponse UpdateVocabulary(UpdateVocabularyRequest updateVocabularyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vocabulary_id" , updateVocabularyRequest.VocabularyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/vocabularies/{vocabulary_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVocabularyRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVocabularyResponse>(response);
        }
        
    }
}