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
        /// </summary>
        public CancelAssetTranscodeTaskResponse CancelAssetTranscodeTask(CancelAssetTranscodeTaskRequest cancelAssetTranscodeTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/process",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelAssetTranscodeTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<CancelAssetTranscodeTaskResponse>(response);
        }
        
        /// <summary>
        /// 取消提取音频任务
        /// </summary>
        public CancelExtractAudioTaskResponse CancelExtractAudioTask(CancelExtractAudioTaskRequest cancelExtractAudioTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/extract_audio",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelExtractAudioTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<CancelExtractAudioTaskResponse>(response);
        }
        
        /// <summary>
        /// 上传检验
        /// </summary>
        public CheckMd5DuplicationResponse CheckMd5Duplication(CheckMd5DuplicationRequest checkMd5DuplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/duplication",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkMd5DuplicationRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<CheckMd5DuplicationResponse>(response);
        }
        
        /// <summary>
        /// 确认媒资上传
        /// </summary>
        public ConfirmAssetUploadResponse ConfirmAssetUpload(ConfirmAssetUploadRequest confirmAssetUploadRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/status/uploaded",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmAssetUploadRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ConfirmAssetUploadResponse>(response);
        }
        
        /// <summary>
        /// 确认水印图片上传
        /// </summary>
        public ConfirmImageUploadResponse ConfirmImageUpload(ConfirmImageUploadRequest confirmImageUploadRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/watermark/status/uploaded",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmImageUploadRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ConfirmImageUploadResponse>(response);
        }
        
        /// <summary>
        /// 创建媒资：上传方式
        /// </summary>
        public CreateAssetByFileUploadResponse CreateAssetByFileUpload(CreateAssetByFileUploadRequest createAssetByFileUploadRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetByFileUploadRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateAssetByFileUploadResponse>(response);
        }
        
        /// <summary>
        /// 创建媒资分类
        /// </summary>
        public CreateAssetCategoryResponse CreateAssetCategory(CreateAssetCategoryRequest createAssetCategoryRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetCategoryRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateAssetCategoryResponse>(response);
        }
        
        /// <summary>
        /// 媒资处理
        /// </summary>
        public CreateAssetProcessTaskResponse CreateAssetProcessTask(CreateAssetProcessTaskRequest createAssetProcessTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/process",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetProcessTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateAssetProcessTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建审核媒资任务
        /// </summary>
        public CreateAssetReviewTaskResponse CreateAssetReviewTask(CreateAssetReviewTaskRequest createAssetReviewTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/review",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetReviewTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateAssetReviewTaskResponse>(response);
        }
        
        /// <summary>
        /// 音频提取
        /// </summary>
        public CreateExtractAudioTaskResponse CreateExtractAudioTask(CreateExtractAudioTaskRequest createExtractAudioTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/extract_audio",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExtractAudioTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateExtractAudioTaskResponse>(response);
        }
        
        /// <summary>
        /// CDN预热
        /// </summary>
        public CreatePreheatingAssetResponse CreatePreheatingAsset(CreatePreheatingAssetRequest createPreheatingAssetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/preheating",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreheatingAssetRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePreheatingAssetResponse>(response);
        }
        
        /// <summary>
        /// 创建媒资：OBS托管方式
        /// </summary>
        public CreateTakeOverTaskResponse CreateTakeOverTask(CreateTakeOverTaskRequest createTakeOverTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/stock/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTakeOverTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateTakeOverTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建自定义转码模板组
        /// </summary>
        public CreateTemplateGroupResponse CreateTemplateGroup(CreateTemplateGroupRequest createTemplateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateTemplateGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建水印模板
        /// </summary>
        public CreateWatermarkTemplateResponse CreateWatermarkTemplate(CreateWatermarkTemplateRequest createWatermarkTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWatermarkTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateWatermarkTemplateResponse>(response);
        }
        
        /// <summary>
        /// 删除媒资分类
        /// </summary>
        public DeleteAssetCategoryResponse DeleteAssetCategory(DeleteAssetCategoryRequest deleteAssetCategoryRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssetCategoryRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAssetCategoryResponse>(response);
        }
        
        /// <summary>
        /// 删除媒资
        /// </summary>
        public DeleteAssetsResponse DeleteAssets(DeleteAssetsRequest deleteAssetsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssetsRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteAssetsResponse>(response);
        }
        
        /// <summary>
        /// 删除自定义转码模板组
        /// </summary>
        public DeleteTemplateGroupResponse DeleteTemplateGroup(DeleteTemplateGroupRequest deleteTemplateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTemplateGroupResponse>(response);
        }
        
        /// <summary>
        /// 删除水印模板
        /// </summary>
        public DeleteWatermarkTemplateResponse DeleteWatermarkTemplate(DeleteWatermarkTemplateRequest deleteWatermarkTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWatermarkTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteWatermarkTemplateResponse>(response);
        }
        
        /// <summary>
        /// 查询指定分类信息
        /// </summary>
        public ListAssetCategoryResponse ListAssetCategory(ListAssetCategoryRequest listAssetCategoryRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetCategoryRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListAssetCategoryResponse listAssetCategoryResponse = JsonUtils.DeSerializeNull<ListAssetCategoryResponse>(response);
            listAssetCategoryResponse.Body = JsonUtils.DeSerializeList<QueryCategoryRsp>(response);
            return listAssetCategoryResponse;
        }
        
        /// <summary>
        /// 查询媒资列表
        /// </summary>
        public ListAssetListResponse ListAssetList(ListAssetListRequest listAssetListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetListRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAssetListResponse>(response);
        }
        
        /// <summary>
        /// 查询域名播放日志
        /// </summary>
        public ListDomainLogsResponse ListDomainLogs(ListDomainLogsRequest listDomainLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/vod/cdn/logs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainLogsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDomainLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询转码模板组列表
        /// </summary>
        public ListTemplateGroupResponse ListTemplateGroup(ListTemplateGroupRequest listTemplateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTemplateGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询TopN媒资信息
        /// </summary>
        public ListTopStatisticsResponse ListTopStatistics(ListTopStatisticsRequest listTopStatisticsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/top-statistics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopStatisticsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTopStatisticsResponse>(response);
        }
        
        /// <summary>
        /// 查询水印列表
        /// </summary>
        public ListWatermarkTemplateResponse ListWatermarkTemplate(ListWatermarkTemplateRequest listWatermarkTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWatermarkTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListWatermarkTemplateResponse>(response);
        }
        
        /// <summary>
        /// 创建媒资：OBS转存方式
        /// </summary>
        public PublishAssetFromObsResponse PublishAssetFromObs(PublishAssetFromObsRequest publishAssetFromObsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/reproduction",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", publishAssetFromObsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<PublishAssetFromObsResponse>(response);
        }
        
        /// <summary>
        /// 媒资发布
        /// </summary>
        public PublishAssetsResponse PublishAssets(PublishAssetsRequest publishAssetsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/status/publish",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", publishAssetsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<PublishAssetsResponse>(response);
        }
        
        /// <summary>
        /// 密钥查询
        /// </summary>
        public ShowAssetCipherResponse ShowAssetCipher(ShowAssetCipherRequest showAssetCipherRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/ciphers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetCipherRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAssetCipherResponse>(response);
        }
        
        /// <summary>
        /// 查询指定媒资的详细信息
        /// </summary>
        public ShowAssetDetailResponse ShowAssetDetail(ShowAssetDetailRequest showAssetDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAssetDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询媒资信息
        /// </summary>
        public ShowAssetMetaResponse ShowAssetMeta(ShowAssetMetaRequest showAssetMetaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetMetaRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAssetMetaResponse>(response);
        }
        
        /// <summary>
        /// 获取分段上传授权
        /// </summary>
        public ShowAssetTempAuthorityResponse ShowAssetTempAuthority(ShowAssetTempAuthorityRequest showAssetTempAuthorityRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/asset/authority",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetTempAuthorityRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAssetTempAuthorityResponse>(response);
        }
        
        /// <summary>
        /// 查询CDN统计信息
        /// </summary>
        public ShowCdnStatisticsResponse ShowCdnStatistics(ShowCdnStatisticsRequest showCdnStatisticsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/cdn-statistics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCdnStatisticsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowCdnStatisticsResponse>(response);
        }
        
        /// <summary>
        /// 查询CDN预热
        /// </summary>
        public ShowPreheatingAssetResponse ShowPreheatingAsset(ShowPreheatingAssetRequest showPreheatingAssetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/preheating",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPreheatingAssetRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPreheatingAssetResponse>(response);
        }
        
        /// <summary>
        /// 查询源站统计信息
        /// </summary>
        public ShowVodStatisticsResponse ShowVodStatistics(ShowVodStatisticsRequest showVodStatisticsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/vod-statistics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVodStatisticsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVodStatisticsResponse>(response);
        }
        
        /// <summary>
        /// 媒资发布取消
        /// </summary>
        public UnpublishAssetsResponse UnpublishAssets(UnpublishAssetsRequest unpublishAssetsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/status/unpublish",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", unpublishAssetsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UnpublishAssetsResponse>(response);
        }
        
        /// <summary>
        /// 视频更新
        /// </summary>
        public UpdateAssetResponse UpdateAsset(UpdateAssetRequest updateAssetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssetRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAssetResponse>(response);
        }
        
        /// <summary>
        /// 修改媒资分类
        /// </summary>
        public UpdateAssetCategoryResponse UpdateAssetCategory(UpdateAssetCategoryRequest updateAssetCategoryRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/category",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssetCategoryRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAssetCategoryResponse>(response);
        }
        
        /// <summary>
        /// 修改媒资属性
        /// </summary>
        public UpdateAssetMetaResponse UpdateAssetMeta(UpdateAssetMetaRequest updateAssetMetaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAssetMetaRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateAssetMetaResponse>(response);
        }
        
        /// <summary>
        /// 桶授权
        /// </summary>
        public UpdateBucketAuthorizedResponse UpdateBucketAuthorized(UpdateBucketAuthorizedRequest updateBucketAuthorizedRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/authority",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBucketAuthorizedRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateBucketAuthorizedResponse>(response);
        }
        
        /// <summary>
        /// 设置封面
        /// </summary>
        public UpdateCoverByThumbnailResponse UpdateCoverByThumbnail(UpdateCoverByThumbnailRequest updateCoverByThumbnailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/cover",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCoverByThumbnailRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateCoverByThumbnailResponse>(response);
        }
        
        /// <summary>
        /// 修改自定义转码模板组
        /// </summary>
        public UpdateTemplateGroupResponse UpdateTemplateGroup(UpdateTemplateGroupRequest updateTemplateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTemplateGroupResponse>(response);
        }
        
        /// <summary>
        /// 修改水印模板
        /// </summary>
        public UpdateWatermarkTemplateResponse UpdateWatermarkTemplate(UpdateWatermarkTemplateRequest updateWatermarkTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWatermarkTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateWatermarkTemplateResponse>(response);
        }
        
        /// <summary>
        /// 创建媒资：URL拉取注入
        /// </summary>
        public UploadMetaDataByUrlResponse UploadMetaDataByUrl(UploadMetaDataByUrlRequest uploadMetaDataByUrlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/upload_by_url",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", uploadMetaDataByUrlRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UploadMetaDataByUrlResponse>(response);
        }
        
        /// <summary>
        /// 查询托管任务
        /// </summary>
        public ListTakeOverTaskResponse ListTakeOverTask(ListTakeOverTaskRequest listTakeOverTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/stock/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTakeOverTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTakeOverTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询托管媒资详情
        /// </summary>
        public ShowTakeOverAssetDetailsResponse ShowTakeOverAssetDetails(ShowTakeOverAssetDetailsRequest showTakeOverAssetDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/task/details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTakeOverAssetDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowTakeOverAssetDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询托管任务详情
        /// </summary>
        public ShowTakeOverTaskDetailsResponse ShowTakeOverTaskDetails(ShowTakeOverTaskDetailsRequest showTakeOverTaskDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/stock/task/details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTakeOverTaskDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowTakeOverTaskDetailsResponse>(response);
        }
        
    }
}