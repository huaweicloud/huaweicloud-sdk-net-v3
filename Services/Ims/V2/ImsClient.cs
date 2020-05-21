using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Ims.V2.Model;

namespace HuaweiCloud.SDK.Ims.V2
{
    public partial class ImsClient : Client
    {
        public static ClientBuilder<ImsClient> NewBuilder()
        {
            return new ClientBuilder<ImsClient>();
        }

        
        /// <summary>
        /// 批量添加镜像成员
        /// </summary>
        public BatchAddMembersResponse BatchAddMembers(BatchAddMembersRequest batchAddMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddMembersRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<BatchAddMembersResponse>(response);
        }
        
        /// <summary>
        /// 批量删除镜像成员
        /// </summary>
        public BatchDeleteMembersResponse BatchDeleteMembers(BatchDeleteMembersRequest batchDeleteMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteMembersRequest);
            SdkResponse response = DoHttpRequest("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteMembersResponse>(response);
        }
        
        /// <summary>
        /// 批量更新镜像成员状态
        /// </summary>
        public BatchUpdateMembersResponse BatchUpdateMembers(BatchUpdateMembersRequest batchUpdateMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateMembersRequest);
            SdkResponse response = DoHttpRequest("PUT",request);
            return JsonUtils.DeSerialize<BatchUpdateMembersResponse>(response);
        }
        
        /// <summary>
        /// 跨Region复制镜像
        /// </summary>
        public CopyImageCrossRegionResponse CopyImageCrossRegion(CopyImageCrossRegionRequest copyImageCrossRegionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , copyImageCrossRegionRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/cross_region_copy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyImageCrossRegionRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<CopyImageCrossRegionResponse>(response);
        }
        
        /// <summary>
        /// Region内复制镜像
        /// </summary>
        public CopyImageInRegionResponse CopyImageInRegion(CopyImageInRegionRequest copyImageInRegionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , copyImageInRegionRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/copy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyImageInRegionRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<CopyImageInRegionResponse>(response);
        }
        
        /// <summary>
        /// 使用外部镜像文件制作数据镜像
        /// </summary>
        public CreateDataImageResponse CreateDataImage(CreateDataImageRequest createDataImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/dataimages/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDataImageRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<CreateDataImageResponse>(response);
        }
        
        /// <summary>
        /// 制作镜像
        /// </summary>
        public CreateImageResponse CreateImage(CreateImageRequest createImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/cloudimages/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createImageRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<CreateImageResponse>(response);
        }
        
        /// <summary>
        /// 增加或修改标签
        /// </summary>
        public CreateOrUpdateTagsResponse CreateOrUpdateTags(CreateOrUpdateTagsRequest createOrUpdateTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOrUpdateTagsRequest);
            SdkResponse response = DoHttpRequest("PUT",request);
            return JsonUtils.DeSerializeNull<CreateOrUpdateTagsResponse>(response);
        }
        
        /// <summary>
        /// 制作整机镜像
        /// </summary>
        public CreateWholeImageResponse CreateWholeImage(CreateWholeImageRequest createWholeImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/wholeimages/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWholeImageRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<CreateWholeImageResponse>(response);
        }
        
        /// <summary>
        /// 导出镜像
        /// </summary>
        public ExportImageResponse ExportImage(ExportImageRequest exportImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , exportImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/file",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exportImageRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<ExportImageResponse>(response);
        }
        
        /// <summary>
        /// 镜像文件快速导入
        /// </summary>
        public ImportImageQuickResponse ImportImageQuick(ImportImageQuickRequest importImageQuickRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/cloudimages/quickimport/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importImageQuickRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<ImportImageQuickResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像列表
        /// </summary>
        public ListImagesResponse ListImages(ListImagesRequest listImagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/cloudimages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listImagesRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ListImagesResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像支持的OS列表
        /// </summary>
        public ListOsVersionsResponse ListOsVersions(ListOsVersionsRequest listOsVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/os_version",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listOsVersionsRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            ListOsVersionsResponse listOsVersionsResponse = JsonUtils.DeSerializeNull<ListOsVersionsResponse>(response);
            listOsVersionsResponse.Body = JsonUtils.DeSerializeList<ListOsVersionsResponseBody>(response);
            return listOsVersionsResponse;
        }
        
        /// <summary>
        /// 按条件查询租户镜像标签列表
        /// </summary>
        public ListTagsResponse ListTags(ListTagsRequest listTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listTagsRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ListTagsResponse>(response);
        }
        
        /// <summary>
        /// 注册镜像
        /// </summary>
        public RegisterImageResponse RegisterImage(RegisterImageRequest registerImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , registerImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/upload",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerImageRequest);
            SdkResponse response = DoHttpRequest("PUT",request);
            return JsonUtils.DeSerialize<RegisterImageResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像配额
        /// </summary>
        public ShowImageQuotaResponse ShowImageQuota(ShowImageQuotaRequest showImageQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/quota",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showImageQuotaRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ShowImageQuotaResponse>(response);
        }
        
        /// <summary>
        /// 更新镜像信息
        /// </summary>
        public UpdateImageResponse UpdateImage(UpdateImageRequest updateImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , updateImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/cloudimages/{image_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateImageRequest);
            SdkResponse response = DoHttpRequest("PATCH",request);
            return JsonUtils.DeSerialize<UpdateImageResponse>(response);
        }
        
        /// <summary>
        /// 查询job状态
        /// </summary>
        public ShowJobResponse ShowJob(ShowJobRequest showJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showJobRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }
        
        /// <summary>
        /// 添加镜像成员（OpenStack原生）
        /// </summary>
        public GlanceAddImageMemberResponse GlanceAddImageMember(GlanceAddImageMemberRequest glanceAddImageMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceAddImageMemberRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceAddImageMemberRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<GlanceAddImageMemberResponse>(response);
        }
        
        /// <summary>
        /// 创建镜像元数据（OpenStack原生）
        /// </summary>
        public GlanceCreateImageMetadataResponse GlanceCreateImageMetadata(GlanceCreateImageMetadataRequest glanceCreateImageMetadataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/images",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceCreateImageMetadataRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<GlanceCreateImageMetadataResponse>(response);
        }
        
        /// <summary>
        /// 增加标签（OpenStack原生）
        /// </summary>
        public GlanceCreateTagResponse GlanceCreateTag(GlanceCreateTagRequest glanceCreateTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceCreateTagRequest.ImageId.ToString());
            urlParam.Add("tag" , glanceCreateTagRequest.Tag.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/tags/{tag}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, glanceCreateTagRequest);
            SdkResponse response = DoHttpRequest("PUT",request);
            return JsonUtils.DeSerializeNull<GlanceCreateTagResponse>(response);
        }
        
        /// <summary>
        /// 删除镜像（OpenStack原生）
        /// </summary>
        public GlanceDeleteImageResponse GlanceDeleteImage(GlanceDeleteImageRequest glanceDeleteImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceDeleteImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceDeleteImageRequest);
            SdkResponse response = DoHttpRequest("DELETE",request);
            return JsonUtils.DeSerializeNull<GlanceDeleteImageResponse>(response);
        }
        
        /// <summary>
        /// 删除指定的镜像成员（OpenStack原生）
        /// </summary>
        public GlanceDeleteImageMemberResponse GlanceDeleteImageMember(GlanceDeleteImageMemberRequest glanceDeleteImageMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceDeleteImageMemberRequest.ImageId.ToString());
            urlParam.Add("member_id" , glanceDeleteImageMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, glanceDeleteImageMemberRequest);
            SdkResponse response = DoHttpRequest("DELETE",request);
            return JsonUtils.DeSerializeNull<GlanceDeleteImageMemberResponse>(response);
        }
        
        /// <summary>
        /// 删除标签（OpenStack原生）
        /// </summary>
        public GlanceDeleteTagResponse GlanceDeleteTag(GlanceDeleteTagRequest glanceDeleteTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceDeleteTagRequest.ImageId.ToString());
            urlParam.Add("tag" , glanceDeleteTagRequest.Tag.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/tags/{tag}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, glanceDeleteTagRequest);
            SdkResponse response = DoHttpRequest("DELETE",request);
            return JsonUtils.DeSerializeNull<GlanceDeleteTagResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像成员列表视图（OpenStack原生）
        /// </summary>
        public GlanceListImageMemberSchemasResponse GlanceListImageMemberSchemas(GlanceListImageMemberSchemasRequest glanceListImageMemberSchemasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/schemas/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, glanceListImageMemberSchemasRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<GlanceListImageMemberSchemasResponse>(response);
        }
        
        /// <summary>
        /// 获取镜像成员列表（OpenStack原生）
        /// </summary>
        public GlanceListImageMembersResponse GlanceListImageMembers(GlanceListImageMembersRequest glanceListImageMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceListImageMembersRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, glanceListImageMembersRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<GlanceListImageMembersResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像列表视图（OpenStack原生）
        /// </summary>
        public GlanceListImageSchemasResponse GlanceListImageSchemas(GlanceListImageSchemasRequest glanceListImageSchemasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/schemas/images",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, glanceListImageSchemasRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<GlanceListImageSchemasResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像列表（OpenStack原生）
        /// </summary>
        public GlanceListImagesResponse GlanceListImages(GlanceListImagesRequest glanceListImagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/images",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, glanceListImagesRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<GlanceListImagesResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像详情（OpenStack原生）
        /// </summary>
        public GlanceShowImageResponse GlanceShowImage(GlanceShowImageRequest glanceShowImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceShowImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, glanceShowImageRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<GlanceShowImageResponse>(response);
        }
        
        /// <summary>
        /// 获取镜像成员详情（OpenStack原生）
        /// </summary>
        public GlanceShowImageMemberResponse GlanceShowImageMember(GlanceShowImageMemberRequest glanceShowImageMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceShowImageMemberRequest.ImageId.ToString());
            urlParam.Add("member_id" , glanceShowImageMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, glanceShowImageMemberRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<GlanceShowImageMemberResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像成员视图（OpenStack原生）
        /// </summary>
        public GlanceShowImageMemberSchemasResponse GlanceShowImageMemberSchemas(GlanceShowImageMemberSchemasRequest glanceShowImageMemberSchemasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/schemas/member",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, glanceShowImageMemberSchemasRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<GlanceShowImageMemberSchemasResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像视图（OpenStack原生）
        /// </summary>
        public GlanceShowImageSchemasResponse GlanceShowImageSchemas(GlanceShowImageSchemasRequest glanceShowImageSchemasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/schemas/image",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, glanceShowImageSchemasRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<GlanceShowImageSchemasResponse>(response);
        }
        
        /// <summary>
        /// 更新镜像信息（OpenStack原生）
        /// </summary>
        public GlanceUpdateImageResponse GlanceUpdateImage(GlanceUpdateImageRequest glanceUpdateImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceUpdateImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceUpdateImageRequest);
            SdkResponse response = DoHttpRequest("PATCH",request);
            return JsonUtils.DeSerialize<GlanceUpdateImageResponse>(response);
        }
        
        /// <summary>
        /// 更新镜像成员状态（OpenStack原生）
        /// </summary>
        public GlanceUpdateImageMemberResponse GlanceUpdateImageMember(GlanceUpdateImageMemberRequest glanceUpdateImageMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceUpdateImageMemberRequest.ImageId.ToString());
            urlParam.Add("member_id" , glanceUpdateImageMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceUpdateImageMemberRequest);
            SdkResponse response = DoHttpRequest("PUT",request);
            return JsonUtils.DeSerialize<GlanceUpdateImageMemberResponse>(response);
        }
        
    }
}