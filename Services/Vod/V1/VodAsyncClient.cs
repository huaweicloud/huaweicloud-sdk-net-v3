using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Vod.V1.Model;

namespace HuaweiCloud.SDK.Vod.V1
{
    public partial class VodAsyncClient : Client
    {
        public static ClientBuilder<VodAsyncClient> NewBuilder()
        {
            return new ClientBuilder<VodAsyncClient>();
        }

        
        /// <summary>
        /// 取消媒资转码任务
        ///
        /// 取消媒资转码任务，只能取消排队中的转码任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelAssetTranscodeTaskResponse> CancelAssetTranscodeTaskAsync(CancelAssetTranscodeTaskRequest cancelAssetTranscodeTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/process",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelAssetTranscodeTaskRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<CancelAssetTranscodeTaskResponse>(response);
        }

        public AsyncInvoker<CancelAssetTranscodeTaskResponse> CancelAssetTranscodeTaskAsyncInvoker(CancelAssetTranscodeTaskRequest cancelAssetTranscodeTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/process",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelAssetTranscodeTaskRequest);
            return new AsyncInvoker<CancelAssetTranscodeTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CancelAssetTranscodeTaskResponse>);
        }
        
        /// <summary>
        /// 取消提取音频任务
        ///
        /// 取消提取音频任务，只有排队中的提取音频任务才可以取消。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelExtractAudioTaskResponse> CancelExtractAudioTaskAsync(CancelExtractAudioTaskRequest cancelExtractAudioTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/extract_audio",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelExtractAudioTaskRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<CancelExtractAudioTaskResponse>(response);
        }

        public AsyncInvoker<CancelExtractAudioTaskResponse> CancelExtractAudioTaskAsyncInvoker(CancelExtractAudioTaskRequest cancelExtractAudioTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/extract_audio",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelExtractAudioTaskRequest);
            return new AsyncInvoker<CancelExtractAudioTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CancelExtractAudioTaskResponse>);
        }
        
        /// <summary>
        /// 上传检验
        ///
        /// 校验媒资文件是否已存储于视频点播服务中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckMd5DuplicationResponse> CheckMd5DuplicationAsync(CheckMd5DuplicationRequest checkMd5DuplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/duplication",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkMd5DuplicationRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<CheckMd5DuplicationResponse>(response);
        }

        public AsyncInvoker<CheckMd5DuplicationResponse> CheckMd5DuplicationAsyncInvoker(CheckMd5DuplicationRequest checkMd5DuplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/duplication",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkMd5DuplicationRequest);
            return new AsyncInvoker<CheckMd5DuplicationResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckMd5DuplicationResponse>);
        }
        
        /// <summary>
        /// 确认媒资上传
        ///
        /// 媒资分段上传完成后，需要调用此接口通知点播服务媒资上传的状态，表示媒资上传创建完成。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ConfirmAssetUploadResponse> ConfirmAssetUploadAsync(ConfirmAssetUploadRequest confirmAssetUploadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/status/uploaded",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmAssetUploadRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ConfirmAssetUploadResponse>(response);
        }

        public AsyncInvoker<ConfirmAssetUploadResponse> ConfirmAssetUploadAsyncInvoker(ConfirmAssetUploadRequest confirmAssetUploadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/status/uploaded",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmAssetUploadRequest);
            return new AsyncInvoker<ConfirmAssetUploadResponse>(this, "POST", request, JsonUtils.DeSerialize<ConfirmAssetUploadResponse>);
        }
        
        /// <summary>
        /// 确认水印图片上传
        ///
        /// 确认水印图片上传状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ConfirmImageUploadResponse> ConfirmImageUploadAsync(ConfirmImageUploadRequest confirmImageUploadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/watermark/status/uploaded",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmImageUploadRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ConfirmImageUploadResponse>(response);
        }

        public AsyncInvoker<ConfirmImageUploadResponse> ConfirmImageUploadAsyncInvoker(ConfirmImageUploadRequest confirmImageUploadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/watermark/status/uploaded",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmImageUploadRequest);
            return new AsyncInvoker<ConfirmImageUploadResponse>(this, "POST", request, JsonUtils.DeSerialize<ConfirmImageUploadResponse>);
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
        public async Task<CreateAssetByFileUploadResponse> CreateAssetByFileUploadAsync(CreateAssetByFileUploadRequest createAssetByFileUploadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetByFileUploadRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAssetByFileUploadResponse>(response);
        }

        public AsyncInvoker<CreateAssetByFileUploadResponse> CreateAssetByFileUploadAsyncInvoker(CreateAssetByFileUploadRequest createAssetByFileUploadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetByFileUploadRequest);
            return new AsyncInvoker<CreateAssetByFileUploadResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAssetByFileUploadResponse>);
        }
        
        /// <summary>
        /// 创建媒资分类
        ///
        /// 创建媒资分类。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAssetCategoryResponse> CreateAssetCategoryAsync(CreateAssetCategoryRequest createAssetCategoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetCategoryRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAssetCategoryResponse>(response);
        }

        public AsyncInvoker<CreateAssetCategoryResponse> CreateAssetCategoryAsyncInvoker(CreateAssetCategoryRequest createAssetCategoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetCategoryRequest);
            return new AsyncInvoker<CreateAssetCategoryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAssetCategoryResponse>);
        }
        
        /// <summary>
        /// 媒资处理
        ///
        /// 实现视频转码、截图、加密等处理。既可以同时启动多种操作，也可以只启动一种操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAssetProcessTaskResponse> CreateAssetProcessTaskAsync(CreateAssetProcessTaskRequest createAssetProcessTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/process",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetProcessTaskRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAssetProcessTaskResponse>(response);
        }

        public AsyncInvoker<CreateAssetProcessTaskResponse> CreateAssetProcessTaskAsyncInvoker(CreateAssetProcessTaskRequest createAssetProcessTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/process",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetProcessTaskRequest);
            return new AsyncInvoker<CreateAssetProcessTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAssetProcessTaskResponse>);
        }
        
        /// <summary>
        /// 创建审核媒资任务
        ///
        /// 对上传的媒资进行审核。审核后，可以调用[查询媒资详细信息](https://support.huaweicloud.com/api-vod/vod_04_0202.html)接口查看审核结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAssetReviewTaskResponse> CreateAssetReviewTaskAsync(CreateAssetReviewTaskRequest createAssetReviewTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/review",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetReviewTaskRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAssetReviewTaskResponse>(response);
        }

        public AsyncInvoker<CreateAssetReviewTaskResponse> CreateAssetReviewTaskAsyncInvoker(CreateAssetReviewTaskRequest createAssetReviewTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/review",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetReviewTaskRequest);
            return new AsyncInvoker<CreateAssetReviewTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAssetReviewTaskResponse>);
        }
        
        /// <summary>
        /// 音频提取
        ///
        /// 本接口为异步接口，创建音频提取任务下发成功后会返回asset_id和提取的audio_asset_id，但此时音频提取任务并没有立即完成，可通过消息订阅界面配置的音频提取完成事件来获取音频提取任务完成与否。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateExtractAudioTaskResponse> CreateExtractAudioTaskAsync(CreateExtractAudioTaskRequest createExtractAudioTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/extract_audio",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExtractAudioTaskRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateExtractAudioTaskResponse>(response);
        }

        public AsyncInvoker<CreateExtractAudioTaskResponse> CreateExtractAudioTaskAsyncInvoker(CreateExtractAudioTaskRequest createExtractAudioTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/extract_audio",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExtractAudioTaskRequest);
            return new AsyncInvoker<CreateExtractAudioTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateExtractAudioTaskResponse>);
        }
        
        /// <summary>
        /// CDN预热
        ///
        /// 媒资发布后，可通过指定媒资ID或URL向CDN预热。用户初次请求时，将由CDN节点提供请求媒资，加快用户下载缓存时间，提高用户体验。单租户每天最多预热1000个。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePreheatingAssetResponse> CreatePreheatingAssetAsync(CreatePreheatingAssetRequest createPreheatingAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/preheating",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreheatingAssetRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePreheatingAssetResponse>(response);
        }

        public AsyncInvoker<CreatePreheatingAssetResponse> CreatePreheatingAssetAsyncInvoker(CreatePreheatingAssetRequest createPreheatingAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/preheating",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreheatingAssetRequest);
            return new AsyncInvoker<CreatePreheatingAssetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePreheatingAssetResponse>);
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
        public async Task<CreateTakeOverTaskResponse> CreateTakeOverTaskAsync(CreateTakeOverTaskRequest createTakeOverTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/stock/task",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTakeOverTaskRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTakeOverTaskResponse>(response);
        }

        public AsyncInvoker<CreateTakeOverTaskResponse> CreateTakeOverTaskAsyncInvoker(CreateTakeOverTaskRequest createTakeOverTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/stock/task",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTakeOverTaskRequest);
            return new AsyncInvoker<CreateTakeOverTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTakeOverTaskResponse>);
        }
        
        /// <summary>
        /// 创建自定义转码模板组
        ///
        /// 创建自定义转码模板组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTemplateGroupResponse> CreateTemplateGroupAsync(CreateTemplateGroupRequest createTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateGroupRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTemplateGroupResponse>(response);
        }

        public AsyncInvoker<CreateTemplateGroupResponse> CreateTemplateGroupAsyncInvoker(CreateTemplateGroupRequest createTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateGroupRequest);
            return new AsyncInvoker<CreateTemplateGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTemplateGroupResponse>);
        }
        
        /// <summary>
        /// 创建转码模板组集合
        ///
        /// 创建转码模板组集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTemplateGroupCollectionResponse> CreateTemplateGroupCollectionAsync(CreateTemplateGroupCollectionRequest createTemplateGroupCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template-collection/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateGroupCollectionRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTemplateGroupCollectionResponse>(response);
        }

        public AsyncInvoker<CreateTemplateGroupCollectionResponse> CreateTemplateGroupCollectionAsyncInvoker(CreateTemplateGroupCollectionRequest createTemplateGroupCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template-collection/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateGroupCollectionRequest);
            return new AsyncInvoker<CreateTemplateGroupCollectionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTemplateGroupCollectionResponse>);
        }
        
        /// <summary>
        /// 创建自定义转码模板
        ///
        /// 创建自定义转码模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTranscodeTemplateResponse> CreateTranscodeTemplateAsync(CreateTranscodeTemplateRequest createTranscodeTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/asset/template/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTranscodeTemplateRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTranscodeTemplateResponse>(response);
        }

        public AsyncInvoker<CreateTranscodeTemplateResponse> CreateTranscodeTemplateAsyncInvoker(CreateTranscodeTemplateRequest createTranscodeTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/asset/template/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTranscodeTemplateRequest);
            return new AsyncInvoker<CreateTranscodeTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTranscodeTemplateResponse>);
        }
        
        /// <summary>
        /// 创建水印模板
        ///
        /// 创建水印模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateWatermarkTemplateResponse> CreateWatermarkTemplateAsync(CreateWatermarkTemplateRequest createWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWatermarkTemplateRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateWatermarkTemplateResponse>(response);
        }

        public AsyncInvoker<CreateWatermarkTemplateResponse> CreateWatermarkTemplateAsyncInvoker(CreateWatermarkTemplateRequest createWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWatermarkTemplateRequest);
            return new AsyncInvoker<CreateWatermarkTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWatermarkTemplateResponse>);
        }
        
        /// <summary>
        /// 删除媒资分类
        ///
        /// 删除媒资分类。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAssetCategoryResponse> DeleteAssetCategoryAsync(DeleteAssetCategoryRequest deleteAssetCategoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssetCategoryRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAssetCategoryResponse>(response);
        }

        public AsyncInvoker<DeleteAssetCategoryResponse> DeleteAssetCategoryAsyncInvoker(DeleteAssetCategoryRequest deleteAssetCategoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssetCategoryRequest);
            return new AsyncInvoker<DeleteAssetCategoryResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAssetCategoryResponse>);
        }
        
        /// <summary>
        /// 删除媒资
        ///
        /// 删除媒资。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAssetsResponse> DeleteAssetsAsync(DeleteAssetsRequest deleteAssetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssetsRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteAssetsResponse>(response);
        }

        public AsyncInvoker<DeleteAssetsResponse> DeleteAssetsAsyncInvoker(DeleteAssetsRequest deleteAssetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssetsRequest);
            return new AsyncInvoker<DeleteAssetsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAssetsResponse>);
        }
        
        /// <summary>
        /// 删除自定义转码模板组
        ///
        /// 删除自定义转码模板组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTemplateGroupResponse> DeleteTemplateGroupAsync(DeleteTemplateGroupRequest deleteTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateGroupRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTemplateGroupResponse>(response);
        }

        public AsyncInvoker<DeleteTemplateGroupResponse> DeleteTemplateGroupAsyncInvoker(DeleteTemplateGroupRequest deleteTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateGroupRequest);
            return new AsyncInvoker<DeleteTemplateGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTemplateGroupResponse>);
        }
        
        /// <summary>
        /// 删除转码模板组集合
        ///
        /// 删除转码模板组集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTemplateGroupCollectionResponse> DeleteTemplateGroupCollectionAsync(DeleteTemplateGroupCollectionRequest deleteTemplateGroupCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template-collection/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateGroupCollectionRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTemplateGroupCollectionResponse>(response);
        }

        public AsyncInvoker<DeleteTemplateGroupCollectionResponse> DeleteTemplateGroupCollectionAsyncInvoker(DeleteTemplateGroupCollectionRequest deleteTemplateGroupCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template-collection/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateGroupCollectionRequest);
            return new AsyncInvoker<DeleteTemplateGroupCollectionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTemplateGroupCollectionResponse>);
        }
        
        /// <summary>
        /// 删除自定义模板
        ///
        /// 删除自定义模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTranscodeTemplateResponse> DeleteTranscodeTemplateAsync(DeleteTranscodeTemplateRequest deleteTranscodeTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/asset/template/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodeTemplateRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTranscodeTemplateResponse>(response);
        }

        public AsyncInvoker<DeleteTranscodeTemplateResponse> DeleteTranscodeTemplateAsyncInvoker(DeleteTranscodeTemplateRequest deleteTranscodeTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/asset/template/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodeTemplateRequest);
            return new AsyncInvoker<DeleteTranscodeTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTranscodeTemplateResponse>);
        }
        
        /// <summary>
        /// 删除水印模板
        ///
        /// 删除水印模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteWatermarkTemplateResponse> DeleteWatermarkTemplateAsync(DeleteWatermarkTemplateRequest deleteWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWatermarkTemplateRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteWatermarkTemplateResponse>(response);
        }

        public AsyncInvoker<DeleteWatermarkTemplateResponse> DeleteWatermarkTemplateAsyncInvoker(DeleteWatermarkTemplateRequest deleteWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWatermarkTemplateRequest);
            return new AsyncInvoker<DeleteWatermarkTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteWatermarkTemplateResponse>);
        }
        
        /// <summary>
        /// 查询指定分类信息
        ///
        /// 查询指定分类信息，及其子分类（即下一级分类）的列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAssetCategoryResponse> ListAssetCategoryAsync(ListAssetCategoryRequest listAssetCategoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetCategoryRequest);
            var response = await DoHttpRequestAsync("GET",request);
            var listAssetCategoryResponse = JsonUtils.DeSerializeNull<ListAssetCategoryResponse>(response);
            listAssetCategoryResponse.Body = JsonUtils.DeSerializeList<QueryCategoryRsp>(response);
            return listAssetCategoryResponse;
        }

        public AsyncInvoker<ListAssetCategoryResponse> ListAssetCategoryAsyncInvoker(ListAssetCategoryRequest listAssetCategoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetCategoryRequest);
            return new AsyncInvoker<ListAssetCategoryResponse>(this, "GET", request, response =>
            {
                var listAssetCategoryResponse = JsonUtils.DeSerializeNull<ListAssetCategoryResponse>(response);
                listAssetCategoryResponse.Body = JsonUtils.DeSerializeList<QueryCategoryRsp>(response);
                return listAssetCategoryResponse;
            });
        }
        
        /// <summary>
        /// 查询媒资列表
        ///
        /// 查询媒资列表，列表中的每一条记录包含媒资的概要信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAssetListResponse> ListAssetListAsync(ListAssetListRequest listAssetListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/list",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetListRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAssetListResponse>(response);
        }

        public AsyncInvoker<ListAssetListResponse> ListAssetListAsyncInvoker(ListAssetListRequest listAssetListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/list",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetListRequest);
            return new AsyncInvoker<ListAssetListResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAssetListResponse>);
        }
        
        /// <summary>
        /// 查询域名播放日志
        ///
        /// 查询指定点播域名某段时间内在CDN的相关日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDomainLogsResponse> ListDomainLogsAsync(ListDomainLogsRequest listDomainLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/vod/cdn/logs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainLogsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDomainLogsResponse>(response);
        }

        public AsyncInvoker<ListDomainLogsResponse> ListDomainLogsAsyncInvoker(ListDomainLogsRequest listDomainLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/vod/cdn/logs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainLogsRequest);
            return new AsyncInvoker<ListDomainLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainLogsResponse>);
        }
        
        /// <summary>
        /// 查询转码模板组列表
        ///
        /// 查询转码模板组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTemplateGroupResponse> ListTemplateGroupAsync(ListTemplateGroupRequest listTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateGroupRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTemplateGroupResponse>(response);
        }

        public AsyncInvoker<ListTemplateGroupResponse> ListTemplateGroupAsyncInvoker(ListTemplateGroupRequest listTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateGroupRequest);
            return new AsyncInvoker<ListTemplateGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTemplateGroupResponse>);
        }
        
        /// <summary>
        /// 查询自定义模板组集合
        ///
        /// 查询转码模板组集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTemplateGroupCollectionResponse> ListTemplateGroupCollectionAsync(ListTemplateGroupCollectionRequest listTemplateGroupCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template-collection/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateGroupCollectionRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTemplateGroupCollectionResponse>(response);
        }

        public AsyncInvoker<ListTemplateGroupCollectionResponse> ListTemplateGroupCollectionAsyncInvoker(ListTemplateGroupCollectionRequest listTemplateGroupCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template-collection/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateGroupCollectionRequest);
            return new AsyncInvoker<ListTemplateGroupCollectionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTemplateGroupCollectionResponse>);
        }
        
        /// <summary>
        /// 查询TopN媒资信息
        ///
        /// 查询指定域名在指定日期播放次数排名Top 100的媒资统计数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTopStatisticsResponse> ListTopStatisticsAsync(ListTopStatisticsRequest listTopStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/top-statistics",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopStatisticsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTopStatisticsResponse>(response);
        }

        public AsyncInvoker<ListTopStatisticsResponse> ListTopStatisticsAsyncInvoker(ListTopStatisticsRequest listTopStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/top-statistics",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopStatisticsRequest);
            return new AsyncInvoker<ListTopStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTopStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询转码模板列表
        ///
        /// 查询转码模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTranscodeTemplateResponse> ListTranscodeTemplateAsync(ListTranscodeTemplateRequest listTranscodeTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/asset/template/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodeTemplateRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTranscodeTemplateResponse>(response);
        }

        public AsyncInvoker<ListTranscodeTemplateResponse> ListTranscodeTemplateAsyncInvoker(ListTranscodeTemplateRequest listTranscodeTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/asset/template/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodeTemplateRequest);
            return new AsyncInvoker<ListTranscodeTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTranscodeTemplateResponse>);
        }
        
        /// <summary>
        /// 查询水印列表
        ///
        /// 查询水印模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWatermarkTemplateResponse> ListWatermarkTemplateAsync(ListWatermarkTemplateRequest listWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWatermarkTemplateRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListWatermarkTemplateResponse>(response);
        }

        public AsyncInvoker<ListWatermarkTemplateResponse> ListWatermarkTemplateAsyncInvoker(ListWatermarkTemplateRequest listWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWatermarkTemplateRequest);
            return new AsyncInvoker<ListWatermarkTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWatermarkTemplateResponse>);
        }
        
        /// <summary>
        /// 创建媒资：OBS转存方式
        ///
        /// 若您在使用点播服务前，已经在OBS桶中存储了音视频文件，您可以使用该接口将存储在OBS桶中的音视频文件转存到点播服务中，使用点播服务的音视频管理功能。调用该接口前，您需要调用[桶授权](https://support.huaweicloud.com/api-vod/vod_04_0199.html)接口，将存储音视频文件的OBS桶授权给点播服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PublishAssetFromObsResponse> PublishAssetFromObsAsync(PublishAssetFromObsRequest publishAssetFromObsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/reproduction",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", publishAssetFromObsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<PublishAssetFromObsResponse>(response);
        }

        public AsyncInvoker<PublishAssetFromObsResponse> PublishAssetFromObsAsyncInvoker(PublishAssetFromObsRequest publishAssetFromObsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/reproduction",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", publishAssetFromObsRequest);
            return new AsyncInvoker<PublishAssetFromObsResponse>(this, "POST", request, JsonUtils.DeSerialize<PublishAssetFromObsResponse>);
        }
        
        /// <summary>
        /// 媒资发布
        ///
        /// 将媒资设置为发布状态。支持批量发布。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PublishAssetsResponse> PublishAssetsAsync(PublishAssetsRequest publishAssetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/status/publish",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", publishAssetsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<PublishAssetsResponse>(response);
        }

        public AsyncInvoker<PublishAssetsResponse> PublishAssetsAsyncInvoker(PublishAssetsRequest publishAssetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/status/publish",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", publishAssetsRequest);
            return new AsyncInvoker<PublishAssetsResponse>(this, "POST", request, JsonUtils.DeSerialize<PublishAssetsResponse>);
        }
        
        /// <summary>
        /// 密钥查询
        ///
        /// 终端播放HLS加密视频时，向租户管理系统请求密钥，租户管理系统先查询其本地有没有已缓存的密钥，没有时则调用此接口向VOD查询。该接口的具体使用场景请参见[通过HLS加密防止视频泄露](https://support.huaweicloud.com/bestpractice-vod/vod_10_0004.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAssetCipherResponse> ShowAssetCipherAsync(ShowAssetCipherRequest showAssetCipherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/ciphers",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetCipherRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAssetCipherResponse>(response);
        }

        public AsyncInvoker<ShowAssetCipherResponse> ShowAssetCipherAsyncInvoker(ShowAssetCipherRequest showAssetCipherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/ciphers",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetCipherRequest);
            return new AsyncInvoker<ShowAssetCipherResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssetCipherResponse>);
        }
        
        /// <summary>
        /// 查询指定媒资的详细信息
        ///
        /// 查询指定媒资的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAssetDetailResponse> ShowAssetDetailAsync(ShowAssetDetailRequest showAssetDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/details",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetDetailRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAssetDetailResponse>(response);
        }

        public AsyncInvoker<ShowAssetDetailResponse> ShowAssetDetailAsyncInvoker(ShowAssetDetailRequest showAssetDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/details",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetDetailRequest);
            return new AsyncInvoker<ShowAssetDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssetDetailResponse>);
        }
        
        /// <summary>
        /// 查询媒资信息
        ///
        /// 查询媒资信息，支持指定媒资ID、分类、状态、起止时间查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAssetMetaResponse> ShowAssetMetaAsync(ShowAssetMetaRequest showAssetMetaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/info",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetMetaRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAssetMetaResponse>(response);
        }

        public AsyncInvoker<ShowAssetMetaResponse> ShowAssetMetaAsyncInvoker(ShowAssetMetaRequest showAssetMetaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/info",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetMetaRequest);
            return new AsyncInvoker<ShowAssetMetaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssetMetaResponse>);
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
        public async Task<ShowAssetTempAuthorityResponse> ShowAssetTempAuthorityAsync(ShowAssetTempAuthorityRequest showAssetTempAuthorityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/asset/authority",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetTempAuthorityRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAssetTempAuthorityResponse>(response);
        }

        public AsyncInvoker<ShowAssetTempAuthorityResponse> ShowAssetTempAuthorityAsyncInvoker(ShowAssetTempAuthorityRequest showAssetTempAuthorityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/asset/authority",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetTempAuthorityRequest);
            return new AsyncInvoker<ShowAssetTempAuthorityResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssetTempAuthorityResponse>);
        }
        
        /// <summary>
        /// 查询CDN统计信息
        ///
        /// 查询CDN的统计数据，包括流量、峰值带宽、请求总数、请求命中率、流量命中率。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCdnStatisticsResponse> ShowCdnStatisticsAsync(ShowCdnStatisticsRequest showCdnStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/cdn-statistics",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCdnStatisticsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCdnStatisticsResponse>(response);
        }

        public AsyncInvoker<ShowCdnStatisticsResponse> ShowCdnStatisticsAsyncInvoker(ShowCdnStatisticsRequest showCdnStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/cdn-statistics",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCdnStatisticsRequest);
            return new AsyncInvoker<ShowCdnStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCdnStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询CDN预热
        ///
        /// 查询预热结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPreheatingAssetResponse> ShowPreheatingAssetAsync(ShowPreheatingAssetRequest showPreheatingAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/preheating",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPreheatingAssetRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPreheatingAssetResponse>(response);
        }

        public AsyncInvoker<ShowPreheatingAssetResponse> ShowPreheatingAssetAsyncInvoker(ShowPreheatingAssetRequest showPreheatingAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/preheating",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPreheatingAssetRequest);
            return new AsyncInvoker<ShowPreheatingAssetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPreheatingAssetResponse>);
        }
        
        /// <summary>
        /// 查询源站统计信息
        ///
        /// 查询点播源站的统计数据，包括流量、存储空间、转码时长。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVodStatisticsResponse> ShowVodStatisticsAsync(ShowVodStatisticsRequest showVodStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/vod-statistics",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVodStatisticsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVodStatisticsResponse>(response);
        }

        public AsyncInvoker<ShowVodStatisticsResponse> ShowVodStatisticsAsyncInvoker(ShowVodStatisticsRequest showVodStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/vod-statistics",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVodStatisticsRequest);
            return new AsyncInvoker<ShowVodStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVodStatisticsResponse>);
        }
        
        /// <summary>
        /// 媒资发布取消
        ///
        /// 将媒资设置为未发布状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UnpublishAssetsResponse> UnpublishAssetsAsync(UnpublishAssetsRequest unpublishAssetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/status/unpublish",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unpublishAssetsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UnpublishAssetsResponse>(response);
        }

        public AsyncInvoker<UnpublishAssetsResponse> UnpublishAssetsAsyncInvoker(UnpublishAssetsRequest unpublishAssetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/status/unpublish",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unpublishAssetsRequest);
            return new AsyncInvoker<UnpublishAssetsResponse>(this, "POST", request, JsonUtils.DeSerialize<UnpublishAssetsResponse>);
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
        public async Task<UpdateAssetResponse> UpdateAssetAsync(UpdateAssetRequest updateAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssetRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAssetResponse>(response);
        }

        public AsyncInvoker<UpdateAssetResponse> UpdateAssetAsyncInvoker(UpdateAssetRequest updateAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssetRequest);
            return new AsyncInvoker<UpdateAssetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAssetResponse>);
        }
        
        /// <summary>
        /// 修改媒资分类
        ///
        /// 修改媒资分类。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAssetCategoryResponse> UpdateAssetCategoryAsync(UpdateAssetCategoryRequest updateAssetCategoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssetCategoryRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAssetCategoryResponse>(response);
        }

        public AsyncInvoker<UpdateAssetCategoryResponse> UpdateAssetCategoryAsyncInvoker(UpdateAssetCategoryRequest updateAssetCategoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssetCategoryRequest);
            return new AsyncInvoker<UpdateAssetCategoryResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAssetCategoryResponse>);
        }
        
        /// <summary>
        /// 修改媒资属性
        ///
        /// 修改媒资属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAssetMetaResponse> UpdateAssetMetaAsync(UpdateAssetMetaRequest updateAssetMetaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/info",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssetMetaRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateAssetMetaResponse>(response);
        }

        public AsyncInvoker<UpdateAssetMetaResponse> UpdateAssetMetaAsyncInvoker(UpdateAssetMetaRequest updateAssetMetaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/info",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssetMetaRequest);
            return new AsyncInvoker<UpdateAssetMetaResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAssetMetaResponse>);
        }
        
        /// <summary>
        /// 桶授权
        ///
        /// 用户可以通过该接口将OBS桶授权给点播服务或取消点播服务的授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateBucketAuthorizedResponse> UpdateBucketAuthorizedAsync(UpdateBucketAuthorizedRequest updateBucketAuthorizedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/authority",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBucketAuthorizedRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateBucketAuthorizedResponse>(response);
        }

        public AsyncInvoker<UpdateBucketAuthorizedResponse> UpdateBucketAuthorizedAsyncInvoker(UpdateBucketAuthorizedRequest updateBucketAuthorizedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/authority",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBucketAuthorizedRequest);
            return new AsyncInvoker<UpdateBucketAuthorizedResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateBucketAuthorizedResponse>);
        }
        
        /// <summary>
        /// 设置封面
        ///
        /// 将视频截图生成的某张图片设置成封面。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateCoverByThumbnailResponse> UpdateCoverByThumbnailAsync(UpdateCoverByThumbnailRequest updateCoverByThumbnailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/cover",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCoverByThumbnailRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateCoverByThumbnailResponse>(response);
        }

        public AsyncInvoker<UpdateCoverByThumbnailResponse> UpdateCoverByThumbnailAsyncInvoker(UpdateCoverByThumbnailRequest updateCoverByThumbnailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/cover",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCoverByThumbnailRequest);
            return new AsyncInvoker<UpdateCoverByThumbnailResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateCoverByThumbnailResponse>);
        }
        
        /// <summary>
        /// 修改自定义转码模板组
        ///
        /// 修改自定义转码模板组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTemplateGroupResponse> UpdateTemplateGroupAsync(UpdateTemplateGroupRequest updateTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateGroupRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTemplateGroupResponse>(response);
        }

        public AsyncInvoker<UpdateTemplateGroupResponse> UpdateTemplateGroupAsyncInvoker(UpdateTemplateGroupRequest updateTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateGroupRequest);
            return new AsyncInvoker<UpdateTemplateGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTemplateGroupResponse>);
        }
        
        /// <summary>
        /// 修改转码模板组集合
        ///
        /// 修改转码模板组结合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTemplateGroupCollectionResponse> UpdateTemplateGroupCollectionAsync(UpdateTemplateGroupCollectionRequest updateTemplateGroupCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template-collection/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateGroupCollectionRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTemplateGroupCollectionResponse>(response);
        }

        public AsyncInvoker<UpdateTemplateGroupCollectionResponse> UpdateTemplateGroupCollectionAsyncInvoker(UpdateTemplateGroupCollectionRequest updateTemplateGroupCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template-collection/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateGroupCollectionRequest);
            return new AsyncInvoker<UpdateTemplateGroupCollectionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTemplateGroupCollectionResponse>);
        }
        
        /// <summary>
        /// 修改转码模板
        ///
        /// 修改转码模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTranscodeTemplateResponse> UpdateTranscodeTemplateAsync(UpdateTranscodeTemplateRequest updateTranscodeTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/asset/template/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTranscodeTemplateRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTranscodeTemplateResponse>(response);
        }

        public AsyncInvoker<UpdateTranscodeTemplateResponse> UpdateTranscodeTemplateAsyncInvoker(UpdateTranscodeTemplateRequest updateTranscodeTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/asset/template/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTranscodeTemplateRequest);
            return new AsyncInvoker<UpdateTranscodeTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTranscodeTemplateResponse>);
        }
        
        /// <summary>
        /// 修改水印模板
        ///
        /// 修改水印模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateWatermarkTemplateResponse> UpdateWatermarkTemplateAsync(UpdateWatermarkTemplateRequest updateWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWatermarkTemplateRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateWatermarkTemplateResponse>(response);
        }

        public AsyncInvoker<UpdateWatermarkTemplateResponse> UpdateWatermarkTemplateAsyncInvoker(UpdateWatermarkTemplateRequest updateWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWatermarkTemplateRequest);
            return new AsyncInvoker<UpdateWatermarkTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateWatermarkTemplateResponse>);
        }
        
        /// <summary>
        /// 创建媒资：URL拉取注入
        ///
        /// 基于音视频源文件URL，将音视频文件离线拉取上传到点播服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UploadMetaDataByUrlResponse> UploadMetaDataByUrlAsync(UploadMetaDataByUrlRequest uploadMetaDataByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/upload_by_url",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", uploadMetaDataByUrlRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UploadMetaDataByUrlResponse>(response);
        }

        public AsyncInvoker<UploadMetaDataByUrlResponse> UploadMetaDataByUrlAsyncInvoker(UploadMetaDataByUrlRequest uploadMetaDataByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/upload_by_url",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", uploadMetaDataByUrlRequest);
            return new AsyncInvoker<UploadMetaDataByUrlResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadMetaDataByUrlResponse>);
        }
        
        /// <summary>
        /// 查询托管任务
        ///
        /// 查询OBS存量托管任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTakeOverTaskResponse> ListTakeOverTaskAsync(ListTakeOverTaskRequest listTakeOverTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/stock/task",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTakeOverTaskRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTakeOverTaskResponse>(response);
        }

        public AsyncInvoker<ListTakeOverTaskResponse> ListTakeOverTaskAsyncInvoker(ListTakeOverTaskRequest listTakeOverTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/stock/task",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTakeOverTaskRequest);
            return new AsyncInvoker<ListTakeOverTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTakeOverTaskResponse>);
        }
        
        /// <summary>
        /// 查询托管媒资详情
        ///
        /// 查询OBS托管媒资的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTakeOverAssetDetailsResponse> ShowTakeOverAssetDetailsAsync(ShowTakeOverAssetDetailsRequest showTakeOverAssetDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/task/details",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTakeOverAssetDetailsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTakeOverAssetDetailsResponse>(response);
        }

        public AsyncInvoker<ShowTakeOverAssetDetailsResponse> ShowTakeOverAssetDetailsAsyncInvoker(ShowTakeOverAssetDetailsRequest showTakeOverAssetDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/task/details",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTakeOverAssetDetailsRequest);
            return new AsyncInvoker<ShowTakeOverAssetDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTakeOverAssetDetailsResponse>);
        }
        
        /// <summary>
        /// 查询托管任务详情
        ///
        /// 查询OBS存量托管任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTakeOverTaskDetailsResponse> ShowTakeOverTaskDetailsAsync(ShowTakeOverTaskDetailsRequest showTakeOverTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/stock/task/details",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTakeOverTaskDetailsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTakeOverTaskDetailsResponse>(response);
        }

        public AsyncInvoker<ShowTakeOverTaskDetailsResponse> ShowTakeOverTaskDetailsAsyncInvoker(ShowTakeOverTaskDetailsRequest showTakeOverTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/stock/task/details",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTakeOverTaskDetailsRequest);
            return new AsyncInvoker<ShowTakeOverTaskDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTakeOverTaskDetailsResponse>);
        }
        
        /// <summary>
        /// 多字幕封装
        ///
        /// 多字幕封装，仅支持 HLS VTT格式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifySubtitleResponse> ModifySubtitleAsync(ModifySubtitleRequest modifySubtitleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/subtitles",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifySubtitleRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<ModifySubtitleResponse>(response);
        }

        public AsyncInvoker<ModifySubtitleResponse> ModifySubtitleAsyncInvoker(ModifySubtitleRequest modifySubtitleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/subtitles",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifySubtitleRequest);
            return new AsyncInvoker<ModifySubtitleResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifySubtitleResponse>);
        }
        
    }
}