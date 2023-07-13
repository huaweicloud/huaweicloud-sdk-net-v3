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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/process",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelAssetTranscodeTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<CancelAssetTranscodeTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/extract_audio",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelExtractAudioTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<CancelExtractAudioTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/duplication",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkMd5DuplicationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<CheckMd5DuplicationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/status/uploaded",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmAssetUploadRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ConfirmAssetUploadResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/watermark/status/uploaded",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmImageUploadRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ConfirmImageUploadResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetByFileUploadRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAssetByFileUploadResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetCategoryRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAssetCategoryResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/process",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetProcessTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAssetProcessTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/review",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetReviewTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAssetReviewTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/extract_audio",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExtractAudioTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateExtractAudioTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/preheating",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreheatingAssetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePreheatingAssetResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/stock/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTakeOverTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTakeOverTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTemplateGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template-collection/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateGroupCollectionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTemplateGroupCollectionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/asset/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTranscodeTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTranscodeTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWatermarkTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateWatermarkTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssetCategoryRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAssetCategoryResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssetsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteAssetsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTemplateGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template-collection/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateGroupCollectionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTemplateGroupCollectionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/asset/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodeTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTranscodeTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWatermarkTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteWatermarkTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetCategoryRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            ListAssetCategoryResponse listAssetCategoryResponse = JsonUtils.DeSerializeNull<ListAssetCategoryResponse>(response);
            listAssetCategoryResponse.Body = JsonUtils.DeSerializeList<QueryCategoryRsp>(response);
            return listAssetCategoryResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetListRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAssetListResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/vod/cdn/logs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainLogsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDomainLogsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTemplateGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template-collection/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateGroupCollectionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTemplateGroupCollectionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/top-statistics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopStatisticsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTopStatisticsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/asset/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodeTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTranscodeTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWatermarkTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListWatermarkTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/reproduction",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", publishAssetFromObsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<PublishAssetFromObsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/status/publish",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", publishAssetsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<PublishAssetsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/ciphers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetCipherRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAssetCipherResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAssetDetailResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetMetaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAssetMetaResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/asset/authority",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetTempAuthorityRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAssetTempAuthorityResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/cdn-statistics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCdnStatisticsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCdnStatisticsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/preheating",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPreheatingAssetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPreheatingAssetResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/vod-statistics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVodStatisticsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVodStatisticsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/status/unpublish",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", unpublishAssetsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UnpublishAssetsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAssetResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssetCategoryRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAssetCategoryResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssetMetaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateAssetMetaResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/authority",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBucketAuthorizedRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateBucketAuthorizedResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/cover",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCoverByThumbnailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateCoverByThumbnailResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTemplateGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template-collection/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateGroupCollectionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTemplateGroupCollectionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/asset/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTranscodeTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTranscodeTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWatermarkTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateWatermarkTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/upload_by_url",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", uploadMetaDataByUrlRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UploadMetaDataByUrlResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/stock/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTakeOverTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTakeOverTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/task/details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTakeOverAssetDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTakeOverAssetDetailsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/stock/task/details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTakeOverTaskDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTakeOverTaskDetailsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/asset/subtitles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifySubtitleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<ModifySubtitleResponse>(response);
        }
        
    }
}