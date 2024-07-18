using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Vod.V1.Model;

namespace HuaweiCloud.SDK.Vod.V1
{
    public partial class VodClient : Client
    {
        public static ClientBuilder<VodClient> NewBuilder()
        {
            return new ClientBuilder<VodClient>();
        }

        
        /// <summary>
        /// 取消媒资转码任务
        ///
        /// 取消媒资转码任务，只能取消排队中的转码任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelAssetTranscodeTaskResponse CancelAssetTranscodeTask(CancelAssetTranscodeTaskRequest cancelAssetTranscodeTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/process", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelAssetTranscodeTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<CancelAssetTranscodeTaskResponse>(response);
        }

        public SyncInvoker<CancelAssetTranscodeTaskResponse> CancelAssetTranscodeTaskInvoker(CancelAssetTranscodeTaskRequest cancelAssetTranscodeTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/process", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelAssetTranscodeTaskRequest);
            return new SyncInvoker<CancelAssetTranscodeTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CancelAssetTranscodeTaskResponse>);
        }
        
        /// <summary>
        /// 取消提取音频任务
        ///
        /// 取消提取音频任务，只有排队中的提取音频任务才可以取消。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelExtractAudioTaskResponse CancelExtractAudioTask(CancelExtractAudioTaskRequest cancelExtractAudioTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/extract_audio", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelExtractAudioTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<CancelExtractAudioTaskResponse>(response);
        }

        public SyncInvoker<CancelExtractAudioTaskResponse> CancelExtractAudioTaskInvoker(CancelExtractAudioTaskRequest cancelExtractAudioTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/extract_audio", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelExtractAudioTaskRequest);
            return new SyncInvoker<CancelExtractAudioTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CancelExtractAudioTaskResponse>);
        }
        
        /// <summary>
        /// 上传检验
        ///
        /// 校验媒资文件是否已存储于视频点播服务中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckMd5DuplicationResponse CheckMd5Duplication(CheckMd5DuplicationRequest checkMd5DuplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/duplication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkMd5DuplicationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CheckMd5DuplicationResponse>(response);
        }

        public SyncInvoker<CheckMd5DuplicationResponse> CheckMd5DuplicationInvoker(CheckMd5DuplicationRequest checkMd5DuplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/duplication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkMd5DuplicationRequest);
            return new SyncInvoker<CheckMd5DuplicationResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckMd5DuplicationResponse>);
        }
        
        /// <summary>
        /// 确认媒资上传
        ///
        /// 媒资分段上传完成后，需要调用此接口通知点播服务媒资上传的状态，表示媒资上传创建完成。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ConfirmAssetUploadResponse ConfirmAssetUpload(ConfirmAssetUploadRequest confirmAssetUploadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/status/uploaded", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmAssetUploadRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ConfirmAssetUploadResponse>(response);
        }

        public SyncInvoker<ConfirmAssetUploadResponse> ConfirmAssetUploadInvoker(ConfirmAssetUploadRequest confirmAssetUploadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/status/uploaded", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmAssetUploadRequest);
            return new SyncInvoker<ConfirmAssetUploadResponse>(this, "POST", request, JsonUtils.DeSerialize<ConfirmAssetUploadResponse>);
        }
        
        /// <summary>
        /// 确认水印图片上传
        ///
        /// 确认水印图片上传状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ConfirmImageUploadResponse ConfirmImageUpload(ConfirmImageUploadRequest confirmImageUploadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/watermark/status/uploaded", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmImageUploadRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ConfirmImageUploadResponse>(response);
        }

        public SyncInvoker<ConfirmImageUploadResponse> ConfirmImageUploadInvoker(ConfirmImageUploadRequest confirmImageUploadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/watermark/status/uploaded", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmImageUploadRequest);
            return new SyncInvoker<ConfirmImageUploadResponse>(this, "POST", request, JsonUtils.DeSerialize<ConfirmImageUploadResponse>);
        }
        
        /// <summary>
        /// 创建媒资：上传方式
        ///
        /// 调用该接口创建媒资时，需要将对应的媒资文件上传到点播服务的OBS桶中。
        /// 
        /// 若上传的单媒资文件大小小于20M，则可以直接用PUT方法对该接口返回的地址进行上传。具体使用方法请参考[示例1：媒资上传（20M以下）](https://support.huaweicloud.com/api-vod/vod_04_0195.html)。
        /// 
        /// 若上传的单个媒资大小大于20M，则需要进行二进制流分割后上传，该接口的具体使用方法请参考[示例2：媒资分段上传（20M以上）](https://support.huaweicloud.com/api-vod/vod_04_0216.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAssetByFileUploadResponse CreateAssetByFileUpload(CreateAssetByFileUploadRequest createAssetByFileUploadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetByFileUploadRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAssetByFileUploadResponse>(response);
        }

        public SyncInvoker<CreateAssetByFileUploadResponse> CreateAssetByFileUploadInvoker(CreateAssetByFileUploadRequest createAssetByFileUploadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetByFileUploadRequest);
            return new SyncInvoker<CreateAssetByFileUploadResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAssetByFileUploadResponse>);
        }
        
        /// <summary>
        /// 创建媒资分类
        ///
        /// 创建媒资分类。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAssetCategoryResponse CreateAssetCategory(CreateAssetCategoryRequest createAssetCategoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetCategoryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAssetCategoryResponse>(response);
        }

        public SyncInvoker<CreateAssetCategoryResponse> CreateAssetCategoryInvoker(CreateAssetCategoryRequest createAssetCategoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetCategoryRequest);
            return new SyncInvoker<CreateAssetCategoryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAssetCategoryResponse>);
        }
        
        /// <summary>
        /// 媒资处理
        ///
        /// 实现视频转码、截图、加密等处理。既可以同时启动多种操作，也可以只启动一种操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAssetProcessTaskResponse CreateAssetProcessTask(CreateAssetProcessTaskRequest createAssetProcessTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/process", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetProcessTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAssetProcessTaskResponse>(response);
        }

        public SyncInvoker<CreateAssetProcessTaskResponse> CreateAssetProcessTaskInvoker(CreateAssetProcessTaskRequest createAssetProcessTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/process", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetProcessTaskRequest);
            return new SyncInvoker<CreateAssetProcessTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAssetProcessTaskResponse>);
        }
        
        /// <summary>
        /// 创建审核媒资任务
        ///
        /// 对上传的媒资进行审核。审核后，可以调用[查询媒资详细信息](https://support.huaweicloud.com/api-vod/vod_04_0202.html)接口查看审核结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAssetReviewTaskResponse CreateAssetReviewTask(CreateAssetReviewTaskRequest createAssetReviewTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/review", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetReviewTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAssetReviewTaskResponse>(response);
        }

        public SyncInvoker<CreateAssetReviewTaskResponse> CreateAssetReviewTaskInvoker(CreateAssetReviewTaskRequest createAssetReviewTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/review", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetReviewTaskRequest);
            return new SyncInvoker<CreateAssetReviewTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAssetReviewTaskResponse>);
        }
        
        /// <summary>
        /// 音频提取
        ///
        /// 本接口为异步接口，创建音频提取任务下发成功后会返回asset_id和提取的audio_asset_id，但此时音频提取任务并没有立即完成，可通过消息订阅界面配置的音频提取完成事件来获取音频提取任务完成与否。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateExtractAudioTaskResponse CreateExtractAudioTask(CreateExtractAudioTaskRequest createExtractAudioTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/extract_audio", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExtractAudioTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateExtractAudioTaskResponse>(response);
        }

        public SyncInvoker<CreateExtractAudioTaskResponse> CreateExtractAudioTaskInvoker(CreateExtractAudioTaskRequest createExtractAudioTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/extract_audio", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExtractAudioTaskRequest);
            return new SyncInvoker<CreateExtractAudioTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateExtractAudioTaskResponse>);
        }
        
        /// <summary>
        /// CDN预热
        ///
        /// 媒资发布后，可通过指定媒资ID或URL向CDN预热。用户初次请求时，将由CDN节点提供请求媒资，加快用户下载缓存时间，提高用户体验。单租户每天最多预热1000个。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePreheatingAssetResponse CreatePreheatingAsset(CreatePreheatingAssetRequest createPreheatingAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/preheating", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreheatingAssetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePreheatingAssetResponse>(response);
        }

        public SyncInvoker<CreatePreheatingAssetResponse> CreatePreheatingAssetInvoker(CreatePreheatingAssetRequest createPreheatingAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/preheating", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreheatingAssetRequest);
            return new SyncInvoker<CreatePreheatingAssetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePreheatingAssetResponse>);
        }
        
        /// <summary>
        /// 创建媒资：OBS托管方式
        ///
        /// 通过存量托管的方式，将已存储在OBS桶中的音视频文件同步到点播服务。
        /// 
        /// OBS托管方式分为增量托管和存量托管，增量托管暂只支持通过视频点播控制台配置，配置后，若OBS有新增音视频文件，则会自动同步到点播服务中，具体请参见[增量托管](https://support.huaweicloud.com/usermanual-vod/vod010032.html)。两个托管方式都需要先将对应的OBS桶授权给点播服务，具体请参见[桶授权](https://support.huaweicloud.com/usermanual-vod/vod010031.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTakeOverTaskResponse CreateTakeOverTask(CreateTakeOverTaskRequest createTakeOverTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/stock/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTakeOverTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTakeOverTaskResponse>(response);
        }

        public SyncInvoker<CreateTakeOverTaskResponse> CreateTakeOverTaskInvoker(CreateTakeOverTaskRequest createTakeOverTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/stock/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTakeOverTaskRequest);
            return new SyncInvoker<CreateTakeOverTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTakeOverTaskResponse>);
        }
        
        /// <summary>
        /// 创建自定义转码模板组
        ///
        /// 创建自定义转码模板组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTemplateGroupResponse CreateTemplateGroup(CreateTemplateGroupRequest createTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTemplateGroupResponse>(response);
        }

        public SyncInvoker<CreateTemplateGroupResponse> CreateTemplateGroupInvoker(CreateTemplateGroupRequest createTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateGroupRequest);
            return new SyncInvoker<CreateTemplateGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTemplateGroupResponse>);
        }
        
        /// <summary>
        /// 创建转码模板组集合
        ///
        /// 创建转码模板组集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTemplateGroupCollectionResponse CreateTemplateGroupCollection(CreateTemplateGroupCollectionRequest createTemplateGroupCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template-collection/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateGroupCollectionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTemplateGroupCollectionResponse>(response);
        }

        public SyncInvoker<CreateTemplateGroupCollectionResponse> CreateTemplateGroupCollectionInvoker(CreateTemplateGroupCollectionRequest createTemplateGroupCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template-collection/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateGroupCollectionRequest);
            return new SyncInvoker<CreateTemplateGroupCollectionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTemplateGroupCollectionResponse>);
        }
        
        /// <summary>
        /// 创建自定义转码模板
        ///
        /// 创建自定义转码模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTranscodeTemplateResponse CreateTranscodeTemplate(CreateTranscodeTemplateRequest createTranscodeTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/asset/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTranscodeTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTranscodeTemplateResponse>(response);
        }

        public SyncInvoker<CreateTranscodeTemplateResponse> CreateTranscodeTemplateInvoker(CreateTranscodeTemplateRequest createTranscodeTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/asset/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTranscodeTemplateRequest);
            return new SyncInvoker<CreateTranscodeTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTranscodeTemplateResponse>);
        }
        
        /// <summary>
        /// 创建水印模板
        ///
        /// 创建水印模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateWatermarkTemplateResponse CreateWatermarkTemplate(CreateWatermarkTemplateRequest createWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWatermarkTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateWatermarkTemplateResponse>(response);
        }

        public SyncInvoker<CreateWatermarkTemplateResponse> CreateWatermarkTemplateInvoker(CreateWatermarkTemplateRequest createWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWatermarkTemplateRequest);
            return new SyncInvoker<CreateWatermarkTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWatermarkTemplateResponse>);
        }
        
        /// <summary>
        /// 删除媒资分类
        ///
        /// 删除媒资分类。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAssetCategoryResponse DeleteAssetCategory(DeleteAssetCategoryRequest deleteAssetCategoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssetCategoryRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAssetCategoryResponse>(response);
        }

        public SyncInvoker<DeleteAssetCategoryResponse> DeleteAssetCategoryInvoker(DeleteAssetCategoryRequest deleteAssetCategoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssetCategoryRequest);
            return new SyncInvoker<DeleteAssetCategoryResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAssetCategoryResponse>);
        }
        
        /// <summary>
        /// 删除媒资
        ///
        /// 删除媒资。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAssetsResponse DeleteAssets(DeleteAssetsRequest deleteAssetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssetsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAssetsResponse>(response);
        }

        public SyncInvoker<DeleteAssetsResponse> DeleteAssetsInvoker(DeleteAssetsRequest deleteAssetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssetsRequest);
            return new SyncInvoker<DeleteAssetsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAssetsResponse>);
        }
        
        /// <summary>
        /// 删除自定义转码模板组
        ///
        /// 删除自定义转码模板组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTemplateGroupResponse DeleteTemplateGroup(DeleteTemplateGroupRequest deleteTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTemplateGroupResponse>(response);
        }

        public SyncInvoker<DeleteTemplateGroupResponse> DeleteTemplateGroupInvoker(DeleteTemplateGroupRequest deleteTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateGroupRequest);
            return new SyncInvoker<DeleteTemplateGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTemplateGroupResponse>);
        }
        
        /// <summary>
        /// 删除转码模板组集合
        ///
        /// 删除转码模板组集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTemplateGroupCollectionResponse DeleteTemplateGroupCollection(DeleteTemplateGroupCollectionRequest deleteTemplateGroupCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template-collection/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateGroupCollectionRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTemplateGroupCollectionResponse>(response);
        }

        public SyncInvoker<DeleteTemplateGroupCollectionResponse> DeleteTemplateGroupCollectionInvoker(DeleteTemplateGroupCollectionRequest deleteTemplateGroupCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template-collection/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateGroupCollectionRequest);
            return new SyncInvoker<DeleteTemplateGroupCollectionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTemplateGroupCollectionResponse>);
        }
        
        /// <summary>
        /// 删除转码产物
        ///
        /// 删除转码产物。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTranscodeProductResponse DeleteTranscodeProduct(DeleteTranscodeProductRequest deleteTranscodeProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/transcode-product", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodeProductRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteTranscodeProductResponse>(response);
        }

        public SyncInvoker<DeleteTranscodeProductResponse> DeleteTranscodeProductInvoker(DeleteTranscodeProductRequest deleteTranscodeProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/transcode-product", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodeProductRequest);
            return new SyncInvoker<DeleteTranscodeProductResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteTranscodeProductResponse>);
        }
        
        /// <summary>
        /// 删除自定义模板
        ///
        /// 删除自定义模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTranscodeTemplateResponse DeleteTranscodeTemplate(DeleteTranscodeTemplateRequest deleteTranscodeTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/asset/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodeTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTranscodeTemplateResponse>(response);
        }

        public SyncInvoker<DeleteTranscodeTemplateResponse> DeleteTranscodeTemplateInvoker(DeleteTranscodeTemplateRequest deleteTranscodeTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/asset/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodeTemplateRequest);
            return new SyncInvoker<DeleteTranscodeTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTranscodeTemplateResponse>);
        }
        
        /// <summary>
        /// 删除水印模板
        ///
        /// 删除水印模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteWatermarkTemplateResponse DeleteWatermarkTemplate(DeleteWatermarkTemplateRequest deleteWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWatermarkTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteWatermarkTemplateResponse>(response);
        }

        public SyncInvoker<DeleteWatermarkTemplateResponse> DeleteWatermarkTemplateInvoker(DeleteWatermarkTemplateRequest deleteWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWatermarkTemplateRequest);
            return new SyncInvoker<DeleteWatermarkTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteWatermarkTemplateResponse>);
        }
        
        /// <summary>
        /// 查询指定分类信息
        ///
        /// 查询指定分类信息，及其子分类（即下一级分类）的列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAssetCategoryResponse ListAssetCategory(ListAssetCategoryRequest listAssetCategoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetCategoryRequest);
            var response = DoHttpRequestSync("GET", request);
            var listAssetCategoryResponse = JsonUtils.DeSerializeNull<ListAssetCategoryResponse>(response);
            listAssetCategoryResponse.Body = JsonUtils.DeSerializeList<QueryCategoryRsp>(response);
            return listAssetCategoryResponse;
        }

        public SyncInvoker<ListAssetCategoryResponse> ListAssetCategoryInvoker(ListAssetCategoryRequest listAssetCategoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetCategoryRequest);
            return new SyncInvoker<ListAssetCategoryResponse>(this, "GET", request, response =>
            {
                var listAssetCategoryResponse = JsonUtils.DeSerializeNull<ListAssetCategoryResponse>(response);
                listAssetCategoryResponse.Body = JsonUtils.DeSerializeList<QueryCategoryRsp>(response);
                return listAssetCategoryResponse;
            });
        }
        
        /// <summary>
        /// 查询媒资日播放统计数据
        ///
        /// 查询媒资日播放统计数据。
        /// 
        /// 使用媒资日播放统计查询API前，需要先提交工单开通统计功能，才能触发统计任务。
        /// 
        /// 支持查询最近一年的播放统计数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAssetDailySummaryLogResponse ListAssetDailySummaryLog(ListAssetDailySummaryLogRequest listAssetDailySummaryLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/daily-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetDailySummaryLogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAssetDailySummaryLogResponse>(response);
        }

        public SyncInvoker<ListAssetDailySummaryLogResponse> ListAssetDailySummaryLogInvoker(ListAssetDailySummaryLogRequest listAssetDailySummaryLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/daily-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetDailySummaryLogRequest);
            return new SyncInvoker<ListAssetDailySummaryLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAssetDailySummaryLogResponse>);
        }
        
        /// <summary>
        /// 查询媒资列表
        ///
        /// 查询媒资列表，列表中的每一条记录包含媒资的概要信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAssetListResponse ListAssetList(ListAssetListRequest listAssetListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAssetListResponse>(response);
        }

        public SyncInvoker<ListAssetListResponse> ListAssetListInvoker(ListAssetListRequest listAssetListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetListRequest);
            return new SyncInvoker<ListAssetListResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAssetListResponse>);
        }
        
        /// <summary>
        /// 查询域名播放日志
        ///
        /// 查询指定点播域名某段时间内在CDN的相关日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainLogsResponse ListDomainLogs(ListDomainLogsRequest listDomainLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/vod/cdn/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainLogsResponse>(response);
        }

        public SyncInvoker<ListDomainLogsResponse> ListDomainLogsInvoker(ListDomainLogsRequest listDomainLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/vod/cdn/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainLogsRequest);
            return new SyncInvoker<ListDomainLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainLogsResponse>);
        }
        
        /// <summary>
        /// 查询转码模板组列表
        ///
        /// 查询转码模板组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTemplateGroupResponse ListTemplateGroup(ListTemplateGroupRequest listTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTemplateGroupResponse>(response);
        }

        public SyncInvoker<ListTemplateGroupResponse> ListTemplateGroupInvoker(ListTemplateGroupRequest listTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateGroupRequest);
            return new SyncInvoker<ListTemplateGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTemplateGroupResponse>);
        }
        
        /// <summary>
        /// 查询自定义模板组集合
        ///
        /// 查询转码模板组集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTemplateGroupCollectionResponse ListTemplateGroupCollection(ListTemplateGroupCollectionRequest listTemplateGroupCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template-collection/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateGroupCollectionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTemplateGroupCollectionResponse>(response);
        }

        public SyncInvoker<ListTemplateGroupCollectionResponse> ListTemplateGroupCollectionInvoker(ListTemplateGroupCollectionRequest listTemplateGroupCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template-collection/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateGroupCollectionRequest);
            return new SyncInvoker<ListTemplateGroupCollectionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTemplateGroupCollectionResponse>);
        }
        
        /// <summary>
        /// 查询TopN媒资信息
        ///
        /// 查询指定域名在指定日期播放次数排名Top 100的媒资统计数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTopStatisticsResponse ListTopStatistics(ListTopStatisticsRequest listTopStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/top-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTopStatisticsResponse>(response);
        }

        public SyncInvoker<ListTopStatisticsResponse> ListTopStatisticsInvoker(ListTopStatisticsRequest listTopStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/top-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopStatisticsRequest);
            return new SyncInvoker<ListTopStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTopStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询转码模板列表
        ///
        /// 查询转码模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTranscodeTemplateResponse ListTranscodeTemplate(ListTranscodeTemplateRequest listTranscodeTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/asset/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodeTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTranscodeTemplateResponse>(response);
        }

        public SyncInvoker<ListTranscodeTemplateResponse> ListTranscodeTemplateInvoker(ListTranscodeTemplateRequest listTranscodeTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/asset/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodeTemplateRequest);
            return new SyncInvoker<ListTranscodeTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTranscodeTemplateResponse>);
        }
        
        /// <summary>
        /// 查询水印列表
        ///
        /// 查询水印模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWatermarkTemplateResponse ListWatermarkTemplate(ListWatermarkTemplateRequest listWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWatermarkTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListWatermarkTemplateResponse>(response);
        }

        public SyncInvoker<ListWatermarkTemplateResponse> ListWatermarkTemplateInvoker(ListWatermarkTemplateRequest listWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWatermarkTemplateRequest);
            return new SyncInvoker<ListWatermarkTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWatermarkTemplateResponse>);
        }
        
        /// <summary>
        /// 多字幕封装
        ///
        /// 多字幕封装，仅支持 HLS VTT格式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifySubtitleResponse ModifySubtitle(ModifySubtitleRequest modifySubtitleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/subtitles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifySubtitleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifySubtitleResponse>(response);
        }

        public SyncInvoker<ModifySubtitleResponse> ModifySubtitleInvoker(ModifySubtitleRequest modifySubtitleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/subtitles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifySubtitleRequest);
            return new SyncInvoker<ModifySubtitleResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifySubtitleResponse>);
        }
        
        /// <summary>
        /// 创建媒资：OBS转存方式
        ///
        /// 若您在使用点播服务前，已经在OBS桶中存储了音视频文件，您可以使用该接口将存储在OBS桶中的音视频文件转存到点播服务中，使用点播服务的音视频管理功能。调用该接口前，您需要调用[桶授权](https://support.huaweicloud.com/api-vod/vod_04_0199.html)接口，将存储音视频文件的OBS桶授权给点播服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public PublishAssetFromObsResponse PublishAssetFromObs(PublishAssetFromObsRequest publishAssetFromObsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/reproduction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", publishAssetFromObsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<PublishAssetFromObsResponse>(response);
        }

        public SyncInvoker<PublishAssetFromObsResponse> PublishAssetFromObsInvoker(PublishAssetFromObsRequest publishAssetFromObsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/reproduction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", publishAssetFromObsRequest);
            return new SyncInvoker<PublishAssetFromObsResponse>(this, "POST", request, JsonUtils.DeSerialize<PublishAssetFromObsResponse>);
        }
        
        /// <summary>
        /// 媒资发布
        ///
        /// 将媒资设置为发布状态。支持批量发布。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public PublishAssetsResponse PublishAssets(PublishAssetsRequest publishAssetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/status/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", publishAssetsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<PublishAssetsResponse>(response);
        }

        public SyncInvoker<PublishAssetsResponse> PublishAssetsInvoker(PublishAssetsRequest publishAssetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/status/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", publishAssetsRequest);
            return new SyncInvoker<PublishAssetsResponse>(this, "POST", request, JsonUtils.DeSerialize<PublishAssetsResponse>);
        }
        
        /// <summary>
        /// 密钥查询
        ///
        /// 终端播放HLS加密视频时，向租户管理系统请求密钥，租户管理系统先查询其本地有没有已缓存的密钥，没有时则调用此接口向VOD查询。该接口的具体使用场景请参见[通过HLS加密防止视频泄露](https://support.huaweicloud.com/bestpractice-vod/vod_10_0004.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAssetCipherResponse ShowAssetCipher(ShowAssetCipherRequest showAssetCipherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/ciphers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetCipherRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAssetCipherResponse>(response);
        }

        public SyncInvoker<ShowAssetCipherResponse> ShowAssetCipherInvoker(ShowAssetCipherRequest showAssetCipherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/ciphers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetCipherRequest);
            return new SyncInvoker<ShowAssetCipherResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssetCipherResponse>);
        }
        
        /// <summary>
        /// 查询指定媒资的详细信息
        ///
        /// 查询指定媒资的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAssetDetailResponse ShowAssetDetail(ShowAssetDetailRequest showAssetDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAssetDetailResponse>(response);
        }

        public SyncInvoker<ShowAssetDetailResponse> ShowAssetDetailInvoker(ShowAssetDetailRequest showAssetDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetDetailRequest);
            return new SyncInvoker<ShowAssetDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssetDetailResponse>);
        }
        
        /// <summary>
        /// 查询媒资信息
        ///
        /// 查询媒资信息，支持指定媒资ID、分类、状态、起止时间查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAssetMetaResponse ShowAssetMeta(ShowAssetMetaRequest showAssetMetaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetMetaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAssetMetaResponse>(response);
        }

        public SyncInvoker<ShowAssetMetaResponse> ShowAssetMetaInvoker(ShowAssetMetaRequest showAssetMetaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetMetaRequest);
            return new SyncInvoker<ShowAssetMetaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssetMetaResponse>);
        }
        
        /// <summary>
        /// 获取分段上传授权
        ///
        /// 客户端请求创建媒资时，如果媒资文件超过20MB，需采用分段的方式向OBS上传，在每次与OBS交互前，客户端需通过此接口获取到授权方可与OBS交互。
        /// 
        /// 该接口可以获取[初始化多段上传任务](https://support.huaweicloud.com/api-obs/obs_04_0098.html)、[上传段](https://support.huaweicloud.com/api-obs/obs_04_0099.html)、[合并段](https://support.huaweicloud.com/api-obs/obs_04_0102.html)、[列举已上传段](https://support.huaweicloud.com/api-obs/obs_04_0101.html)、[取消段合并](https://support.huaweicloud.com/api-obs/obs_04_0103.html)的带有临时授权的URL，用户需要根据OBS的接口文档配置相应请求的HTTP请求方法、请求头、请求体，然后请求对应的带有临时授权的URL。
        /// 
        /// 视频分段上传方式和OBS的接口文档保持一致，包括HTTP请求方法、请求头、请求体等各种入参，此接口的作用是为用户生成带有鉴权信息的URL（鉴权信息即query_str），用来替换OBS接口中对应的URL，临时给用户开通向点播服务的桶上传文件的权限。
        /// 
        /// 调用获取授权接口时需要传入bucket、object_key、http_verb，其中bucket和object_key是由[创建媒资：上传方式](https://support.huaweicloud.com/api-vod/vod_04_0196.html)接口中返回的响应体中的target字段获得的bucket和object，http_verb需要根据指定的操作选择。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAssetTempAuthorityResponse ShowAssetTempAuthority(ShowAssetTempAuthorityRequest showAssetTempAuthorityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/asset/authority", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetTempAuthorityRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAssetTempAuthorityResponse>(response);
        }

        public SyncInvoker<ShowAssetTempAuthorityResponse> ShowAssetTempAuthorityInvoker(ShowAssetTempAuthorityRequest showAssetTempAuthorityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/asset/authority", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetTempAuthorityRequest);
            return new SyncInvoker<ShowAssetTempAuthorityResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssetTempAuthorityResponse>);
        }
        
        /// <summary>
        /// 查询CDN统计信息
        ///
        /// 查询CDN的统计数据，包括流量、峰值带宽、请求总数、请求命中率、流量命中率。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCdnStatisticsResponse ShowCdnStatistics(ShowCdnStatisticsRequest showCdnStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/cdn-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCdnStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCdnStatisticsResponse>(response);
        }

        public SyncInvoker<ShowCdnStatisticsResponse> ShowCdnStatisticsInvoker(ShowCdnStatisticsRequest showCdnStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/cdn-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCdnStatisticsRequest);
            return new SyncInvoker<ShowCdnStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCdnStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询CDN预热
        ///
        /// 查询预热结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPreheatingAssetResponse ShowPreheatingAsset(ShowPreheatingAssetRequest showPreheatingAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/preheating", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPreheatingAssetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPreheatingAssetResponse>(response);
        }

        public SyncInvoker<ShowPreheatingAssetResponse> ShowPreheatingAssetInvoker(ShowPreheatingAssetRequest showPreheatingAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/preheating", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPreheatingAssetRequest);
            return new SyncInvoker<ShowPreheatingAssetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPreheatingAssetResponse>);
        }
        
        /// <summary>
        /// 查询取回数据信息
        ///
        /// ## 典型场景 ##
        ///  用于查询点播低频和归档取回量统计数据。&lt;br/&gt;
        /// 
        /// ## 接口功能 ##
        ///  用于查询点播低频和归档取回量统计数据。&lt;br/&gt;
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVodRetrievalResponse ShowVodRetrieval(ShowVodRetrievalRequest showVodRetrievalRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/vod-retrieval", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVodRetrievalRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVodRetrievalResponse>(response);
        }

        public SyncInvoker<ShowVodRetrievalResponse> ShowVodRetrievalInvoker(ShowVodRetrievalRequest showVodRetrievalRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/vod-retrieval", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVodRetrievalRequest);
            return new SyncInvoker<ShowVodRetrievalResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVodRetrievalResponse>);
        }
        
        /// <summary>
        /// 查询源站统计信息
        ///
        /// 查询点播源站的统计数据，包括流量、存储空间、转码时长。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVodStatisticsResponse ShowVodStatistics(ShowVodStatisticsRequest showVodStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/vod-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVodStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVodStatisticsResponse>(response);
        }

        public SyncInvoker<ShowVodStatisticsResponse> ShowVodStatisticsInvoker(ShowVodStatisticsRequest showVodStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/vod-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVodStatisticsRequest);
            return new SyncInvoker<ShowVodStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVodStatisticsResponse>);
        }
        
        /// <summary>
        /// 媒资发布取消
        ///
        /// 将媒资设置为未发布状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UnpublishAssetsResponse UnpublishAssets(UnpublishAssetsRequest unpublishAssetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/status/unpublish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unpublishAssetsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UnpublishAssetsResponse>(response);
        }

        public SyncInvoker<UnpublishAssetsResponse> UnpublishAssetsInvoker(UnpublishAssetsRequest unpublishAssetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/status/unpublish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unpublishAssetsRequest);
            return new SyncInvoker<UnpublishAssetsResponse>(this, "POST", request, JsonUtils.DeSerialize<UnpublishAssetsResponse>);
        }
        
        /// <summary>
        /// 视频更新
        ///
        /// 媒资创建后，单独上传封面、更新视频文件或更新已有封面。
        /// 
        /// 如果是更新视频文件，更新完后要通过[确认媒资上传](https://support.huaweicloud.com/api-vod/vod_04_0198.html)接口通知点播服务。
        /// 
        /// 如果是更新封面或单独上传封面，则不需通知。
        /// 
        /// 更新视频可以使用分段上传，具体方式可以参考[示例2：媒资分段上传（20M以上）](https://support.huaweicloud.com/api-vod/vod_04_0216.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAssetResponse UpdateAsset(UpdateAssetRequest updateAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssetRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAssetResponse>(response);
        }

        public SyncInvoker<UpdateAssetResponse> UpdateAssetInvoker(UpdateAssetRequest updateAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssetRequest);
            return new SyncInvoker<UpdateAssetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAssetResponse>);
        }
        
        /// <summary>
        /// 修改媒资分类
        ///
        /// 修改媒资分类。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAssetCategoryResponse UpdateAssetCategory(UpdateAssetCategoryRequest updateAssetCategoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssetCategoryRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAssetCategoryResponse>(response);
        }

        public SyncInvoker<UpdateAssetCategoryResponse> UpdateAssetCategoryInvoker(UpdateAssetCategoryRequest updateAssetCategoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssetCategoryRequest);
            return new SyncInvoker<UpdateAssetCategoryResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAssetCategoryResponse>);
        }
        
        /// <summary>
        /// 修改媒资属性
        ///
        /// 修改媒资属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAssetMetaResponse UpdateAssetMeta(UpdateAssetMetaRequest updateAssetMetaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssetMetaRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAssetMetaResponse>(response);
        }

        public SyncInvoker<UpdateAssetMetaResponse> UpdateAssetMetaInvoker(UpdateAssetMetaRequest updateAssetMetaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssetMetaRequest);
            return new SyncInvoker<UpdateAssetMetaResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAssetMetaResponse>);
        }
        
        /// <summary>
        /// 桶授权
        ///
        /// 用户可以通过该接口将OBS桶授权给点播服务或取消点播服务的授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateBucketAuthorizedResponse UpdateBucketAuthorized(UpdateBucketAuthorizedRequest updateBucketAuthorizedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/authority", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBucketAuthorizedRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateBucketAuthorizedResponse>(response);
        }

        public SyncInvoker<UpdateBucketAuthorizedResponse> UpdateBucketAuthorizedInvoker(UpdateBucketAuthorizedRequest updateBucketAuthorizedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/authority", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBucketAuthorizedRequest);
            return new SyncInvoker<UpdateBucketAuthorizedResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateBucketAuthorizedResponse>);
        }
        
        /// <summary>
        /// 设置封面
        ///
        /// 将视频截图生成的某张图片设置成封面。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateCoverByThumbnailResponse UpdateCoverByThumbnail(UpdateCoverByThumbnailRequest updateCoverByThumbnailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/cover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCoverByThumbnailRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateCoverByThumbnailResponse>(response);
        }

        public SyncInvoker<UpdateCoverByThumbnailResponse> UpdateCoverByThumbnailInvoker(UpdateCoverByThumbnailRequest updateCoverByThumbnailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/cover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCoverByThumbnailRequest);
            return new SyncInvoker<UpdateCoverByThumbnailResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateCoverByThumbnailResponse>);
        }
        
        /// <summary>
        /// 修改媒资文件在obs的存储模式
        ///
        /// ## 接口功能 ##
        ///   修改媒资文件在obs的存储模式&lt;br/&gt;
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateStorageModeResponse UpdateStorageMode(UpdateStorageModeRequest updateStorageModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/storage-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStorageModeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateStorageModeResponse>(response);
        }

        public SyncInvoker<UpdateStorageModeResponse> UpdateStorageModeInvoker(UpdateStorageModeRequest updateStorageModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/storage-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStorageModeRequest);
            return new SyncInvoker<UpdateStorageModeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateStorageModeResponse>);
        }
        
        /// <summary>
        /// 修改自定义转码模板组
        ///
        /// 修改自定义转码模板组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTemplateGroupResponse UpdateTemplateGroup(UpdateTemplateGroupRequest updateTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTemplateGroupResponse>(response);
        }

        public SyncInvoker<UpdateTemplateGroupResponse> UpdateTemplateGroupInvoker(UpdateTemplateGroupRequest updateTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateGroupRequest);
            return new SyncInvoker<UpdateTemplateGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTemplateGroupResponse>);
        }
        
        /// <summary>
        /// 修改转码模板组集合
        ///
        /// 修改转码模板组结合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTemplateGroupCollectionResponse UpdateTemplateGroupCollection(UpdateTemplateGroupCollectionRequest updateTemplateGroupCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template-collection/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateGroupCollectionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTemplateGroupCollectionResponse>(response);
        }

        public SyncInvoker<UpdateTemplateGroupCollectionResponse> UpdateTemplateGroupCollectionInvoker(UpdateTemplateGroupCollectionRequest updateTemplateGroupCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template-collection/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateGroupCollectionRequest);
            return new SyncInvoker<UpdateTemplateGroupCollectionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTemplateGroupCollectionResponse>);
        }
        
        /// <summary>
        /// 修改转码模板
        ///
        /// 修改转码模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTranscodeTemplateResponse UpdateTranscodeTemplate(UpdateTranscodeTemplateRequest updateTranscodeTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/asset/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTranscodeTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTranscodeTemplateResponse>(response);
        }

        public SyncInvoker<UpdateTranscodeTemplateResponse> UpdateTranscodeTemplateInvoker(UpdateTranscodeTemplateRequest updateTranscodeTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/asset/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTranscodeTemplateRequest);
            return new SyncInvoker<UpdateTranscodeTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTranscodeTemplateResponse>);
        }
        
        /// <summary>
        /// 修改水印模板
        ///
        /// 修改水印模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateWatermarkTemplateResponse UpdateWatermarkTemplate(UpdateWatermarkTemplateRequest updateWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWatermarkTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateWatermarkTemplateResponse>(response);
        }

        public SyncInvoker<UpdateWatermarkTemplateResponse> UpdateWatermarkTemplateInvoker(UpdateWatermarkTemplateRequest updateWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWatermarkTemplateRequest);
            return new SyncInvoker<UpdateWatermarkTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateWatermarkTemplateResponse>);
        }
        
        /// <summary>
        /// 创建媒资：URL拉取注入
        ///
        /// 基于音视频源文件URL，将音视频文件离线拉取上传到点播服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UploadMetaDataByUrlResponse UploadMetaDataByUrl(UploadMetaDataByUrlRequest uploadMetaDataByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/upload_by_url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", uploadMetaDataByUrlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UploadMetaDataByUrlResponse>(response);
        }

        public SyncInvoker<UploadMetaDataByUrlResponse> UploadMetaDataByUrlInvoker(UploadMetaDataByUrlRequest uploadMetaDataByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/upload_by_url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", uploadMetaDataByUrlRequest);
            return new SyncInvoker<UploadMetaDataByUrlResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadMetaDataByUrlResponse>);
        }
        
        /// <summary>
        /// 查询托管任务
        ///
        /// 查询OBS存量托管任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTakeOverTaskResponse ListTakeOverTask(ListTakeOverTaskRequest listTakeOverTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/stock/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTakeOverTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTakeOverTaskResponse>(response);
        }

        public SyncInvoker<ListTakeOverTaskResponse> ListTakeOverTaskInvoker(ListTakeOverTaskRequest listTakeOverTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/stock/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTakeOverTaskRequest);
            return new SyncInvoker<ListTakeOverTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTakeOverTaskResponse>);
        }
        
        /// <summary>
        /// 查询托管媒资详情
        ///
        /// 查询OBS托管媒资的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTakeOverAssetDetailsResponse ShowTakeOverAssetDetails(ShowTakeOverAssetDetailsRequest showTakeOverAssetDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/task/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTakeOverAssetDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTakeOverAssetDetailsResponse>(response);
        }

        public SyncInvoker<ShowTakeOverAssetDetailsResponse> ShowTakeOverAssetDetailsInvoker(ShowTakeOverAssetDetailsRequest showTakeOverAssetDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/task/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTakeOverAssetDetailsRequest);
            return new SyncInvoker<ShowTakeOverAssetDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTakeOverAssetDetailsResponse>);
        }
        
        /// <summary>
        /// 查询托管任务详情
        ///
        /// 查询OBS存量托管任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTakeOverTaskDetailsResponse ShowTakeOverTaskDetails(ShowTakeOverTaskDetailsRequest showTakeOverTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/stock/task/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTakeOverTaskDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTakeOverTaskDetailsResponse>(response);
        }

        public SyncInvoker<ShowTakeOverTaskDetailsResponse> ShowTakeOverTaskDetailsInvoker(ShowTakeOverTaskDetailsRequest showTakeOverTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/stock/task/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTakeOverTaskDetailsRequest);
            return new SyncInvoker<ShowTakeOverTaskDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTakeOverTaskDetailsResponse>);
        }
        
    }
}