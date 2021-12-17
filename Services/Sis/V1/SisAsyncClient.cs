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
        /// </summary>
        public async Task<CollectTranscriberJobResponse> CollectTranscriberJobAsync(CollectTranscriberJobRequest collectTranscriberJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , collectTranscriberJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/transcriber/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectTranscriberJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<CollectTranscriberJobResponse>(response);
        }
        
        /// <summary>
        /// 创建热词表
        /// </summary>
        public async Task<CreateVocabularyResponse> CreateVocabularyAsync(CreateVocabularyRequest createVocabularyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/vocabularies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVocabularyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateVocabularyResponse>(response);
        }
        
        /// <summary>
        /// 删除热词表
        /// </summary>
        public async Task<DeleteVocabularyResponse> DeleteVocabularyAsync(DeleteVocabularyRequest deleteVocabularyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vocabulary_id" , deleteVocabularyRequest.VocabularyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/vocabularies/{vocabulary_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVocabularyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVocabularyResponse>(response);
        }
        
        /// <summary>
        /// 提交录音文件识别任务
        /// </summary>
        public async Task<PushTranscriberJobsResponse> PushTranscriberJobsAsync(PushTranscriberJobsRequest pushTranscriberJobsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/transcriber/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", pushTranscriberJobsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<PushTranscriberJobsResponse>(response);
        }
        
        /// <summary>
        /// 录音文件识别极速版
        /// </summary>
        public async Task<RecognizeFlashAsrResponse> RecognizeFlashAsrAsync(RecognizeFlashAsrRequest recognizeFlashAsrRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/flash",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", recognizeFlashAsrRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeFlashAsrResponse>(response);
        }
        
        /// <summary>
        /// 一句话识别
        /// </summary>
        public async Task<RecognizeShortAudioResponse> RecognizeShortAudioAsync(RecognizeShortAudioRequest recognizeShortAudioRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/short-audio",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", recognizeShortAudioRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RecognizeShortAudioResponse>(response);
        }
        
        /// <summary>
        /// 语音评测
        /// </summary>
        public async Task<RunAudioAssessmentResponse> RunAudioAssessmentAsync(RunAudioAssessmentRequest runAudioAssessmentRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/assessment/audio",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runAudioAssessmentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunAudioAssessmentResponse>(response);
        }
        
        /// <summary>
        /// 多模态评测
        /// </summary>
        public async Task<RunMultiModalAssessmentResponse> RunMultiModalAssessmentAsync(RunMultiModalAssessmentRequest runMultiModalAssessmentRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/assessment/video",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runMultiModalAssessmentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunMultiModalAssessmentResponse>(response);
        }
        
        /// <summary>
        /// 语音合成
        /// </summary>
        public async Task<RunTtsResponse> RunTtsAsync(RunTtsRequest runTtsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tts",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runTtsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunTtsResponse>(response);
        }
        
        /// <summary>
        /// 查询热词表列表
        /// </summary>
        public async Task<ShowVocabulariesResponse> ShowVocabulariesAsync(ShowVocabulariesRequest showVocabulariesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/vocabularies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showVocabulariesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVocabulariesResponse>(response);
        }
        
        /// <summary>
        /// 查询热词表信息
        /// </summary>
        public async Task<ShowVocabularyResponse> ShowVocabularyAsync(ShowVocabularyRequest showVocabularyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vocabulary_id" , showVocabularyRequest.VocabularyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/vocabularies/{vocabulary_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVocabularyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVocabularyResponse>(response);
        }
        
        /// <summary>
        /// 更新热词表
        /// </summary>
        public async Task<UpdateVocabularyResponse> UpdateVocabularyAsync(UpdateVocabularyRequest updateVocabularyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vocabulary_id" , updateVocabularyRequest.VocabularyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asr/vocabularies/{vocabulary_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVocabularyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVocabularyResponse>(response);
        }
        
    }
}