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
        /// 创建水印模板
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
        /// 删除水印模板
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
        /// 查询TopN媒资信息
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
        /// 查询水印列表
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
        /// 修改水印模板
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
        /// </summary>
        public async Task<ShowTakeOverTaskDetailsResponse> ShowTakeOverTaskDetailsAsync(ShowTakeOverTaskDetailsRequest showTakeOverTaskDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/asset/obs/host/stock/task/details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTakeOverTaskDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTakeOverTaskDetailsResponse>(response);
        }
        
    }
}