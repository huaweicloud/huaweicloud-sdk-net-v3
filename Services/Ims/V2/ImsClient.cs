using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
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
        /// 添加镜像标签
        ///
        /// 该接口用于为指定镜像添加或更新指定的单个标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddImageTagResponse AddImageTag(AddImageTagRequest addImageTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , addImageTagRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/{image_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addImageTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<AddImageTagResponse>(response);
        }
        
        /// <summary>
        /// 批量添加镜像成员
        ///
        /// 该接口为扩展接口，主要用于镜像共享时用户将多个镜像共享给多个用户。
        /// 该接口为异步接口，返回job_id说明任务下发成功，查询异步任务状态，如果是success说明任务执行成功，如果是failed说明任务执行失败。如何查询异步任务，请参见异步任务查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchAddMembersResponse BatchAddMembers(BatchAddMembersRequest batchAddMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddMembersRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchAddMembersResponse>(response);
        }
        
        /// <summary>
        /// 批量添加删除镜像标签
        ///
        /// 该接口用于为指定镜像批量添加/更新、删除标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchAddOrDeleteTagsResponse BatchAddOrDeleteTags(BatchAddOrDeleteTagsRequest batchAddOrDeleteTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , batchAddOrDeleteTagsRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/{image_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddOrDeleteTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchAddOrDeleteTagsResponse>(response);
        }
        
        /// <summary>
        /// 批量删除镜像成员
        ///
        /// 该接口为扩展接口，主要用于取消镜像共享。
        /// 该接口为异步接口，返回job_id说明任务下发成功，查询异步任务状态，如果是success说明任务执行成功，如果是failed说明任务执行失败。如何查询异步任务，请参见异步任务查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteMembersResponse BatchDeleteMembers(BatchDeleteMembersRequest batchDeleteMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteMembersRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteMembersResponse>(response);
        }
        
        /// <summary>
        /// 批量更新镜像成员状态
        ///
        /// 该接口为扩展接口，主要用于用户接受或者拒绝多个共享镜像时批量更新镜像成员的状态。
        /// 该接口为异步接口，返回job_id说明任务下发成功，查询异步任务状态，如果是success说明任务执行成功，如果是failed说明任务执行失败。如何查询异步任务，请参见异步任务查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateMembersResponse BatchUpdateMembers(BatchUpdateMembersRequest batchUpdateMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateMembersRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<BatchUpdateMembersResponse>(response);
        }
        
        /// <summary>
        /// 跨Region复制镜像
        ///
        /// 该接口为扩展接口，用户在一个区域制作的私有镜像，可以通过跨Region复制镜像将镜像复制到其他区域，在其他区域发放相同类型的云服务器，帮助用户实现区域间的业务迁移。
        /// 该接口为异步接口，返回job_id说明任务下发成功，查询异步任务状态，如果是success说明任务执行成功，如果是failed说明任务执行失败。
        /// 如何查询异步任务，请参见异步任务进度查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CopyImageCrossRegionResponse CopyImageCrossRegion(CopyImageCrossRegionRequest copyImageCrossRegionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , copyImageCrossRegionRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/cross_region_copy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyImageCrossRegionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CopyImageCrossRegionResponse>(response);
        }
        
        /// <summary>
        /// Region内复制镜像
        ///
        /// 该接口为扩展接口，主要用于用户将一个已有镜像复制为另一个镜像。复制镜像时，可以更改镜像的加密等属性，以满足不同的场景。
        /// 该接口为异步接口，返回job_id说明任务下发成功，查询异步任务状态，如果是success说明任务执行成功，如果是failed说明任务执行失败。如何查询异步任务，请参见异步任务查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CopyImageInRegionResponse CopyImageInRegion(CopyImageInRegionRequest copyImageInRegionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , copyImageInRegionRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/copy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyImageInRegionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CopyImageInRegionResponse>(response);
        }
        
        /// <summary>
        /// 使用外部镜像文件制作数据镜像
        ///
        /// 使用上传至OBS桶中的外部数据卷镜像文件制作数据镜像。作为异步接口，调用成功，只是说明后台收到了制作请求，镜像是否制作成功需要通过异步任务查询接口查询该任务的执行状态。具体请参考异步任务查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDataImageResponse CreateDataImage(CreateDataImageRequest createDataImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/dataimages/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDataImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateDataImageResponse>(response);
        }
        
        /// <summary>
        /// 制作镜像
        ///
        /// 本接口用于制作私有镜像，支持：
        /// - 使用云服务器制作私有镜像。
        /// - 使用上传至OBS桶中的外部镜像文件制作私有镜像。
        /// - 使用数据卷制作系统盘镜像。
        /// 
        /// 作为异步接口，调用成功，只是说明云平台收到了制作请求，镜像是否制作成功需要通过异步任务查询接口查询该任务的执行状态，具体请参考异步任务查询。
        /// 
        /// 不同场景必选参数说明：
        /// 
        /// - 使用云服务器制作镜像时的请求的必选参数：name,instance_id。
        /// - 使用上传至OBS桶中的外部镜像文件时的请求必选参数：name,image_url,min_disk。
        /// - 使用数据卷制作系统盘镜像时的请求必选参数：name,volume_id,os_version
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateImageResponse CreateImage(CreateImageRequest createImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/cloudimages/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateImageResponse>(response);
        }
        
        /// <summary>
        /// 增加或修改标签
        ///
        /// 该接口主要用于为某个镜像增加或修改一个自定义标签。通过自定义标签，用户可以将镜像进行分类。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOrUpdateTagsResponse CreateOrUpdateTags(CreateOrUpdateTagsRequest createOrUpdateTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOrUpdateTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<CreateOrUpdateTagsResponse>(response);
        }
        
        /// <summary>
        /// 制作整机镜像
        ///
        /// 使用云服务器或者云服务器备份制作整机镜像。作为异步接口，调用成功，只是说明后台收到了制作整机镜像的请求，镜像是否制作成功需要通过异步任务查询接口查询该任务的执行状态，具体请参考异步任务查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateWholeImageResponse CreateWholeImage(CreateWholeImageRequest createWholeImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/wholeimages/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWholeImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateWholeImageResponse>(response);
        }
        
        /// <summary>
        /// 删除镜像标签
        ///
        /// 该接口用于为镜像删除指定的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteImageTagResponse DeleteImageTag(DeleteImageTagRequest deleteImageTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , deleteImageTagRequest.ImageId.ToString());
            urlParam.Add("key" , deleteImageTagRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/{image_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImageTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteImageTagResponse>(response);
        }
        
        /// <summary>
        /// 导出镜像
        ///
        /// 该接口为扩展接口，用于用户将自己的私有镜像导出到指定的OBS桶中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExportImageResponse ExportImage(ExportImageRequest exportImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , exportImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/file",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exportImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ExportImageResponse>(response);
        }
        
        /// <summary>
        /// 镜像文件快速导入
        ///
        /// 使用上传至OBS桶中的超大外部镜像文件制作私有镜像，目前仅支持RAW或ZVHD2格式镜像文件。且要求镜像文件大小不能超过1TB。
        /// 由于快速导入功能要求提前转换镜像文件格式为RAW或ZVHD2格式，因此镜像文件小于128GB时推荐您优先使用常规的创建私有镜像的方式。
        /// 作为异步接口，调用成功，只是说明后台收到了制作请求，镜像是否制作成功需要通过异步任务查询接口查询该任务的执行状态，具体请参考异步任务查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ImportImageQuickResponse ImportImageQuick(ImportImageQuickRequest importImageQuickRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/cloudimages/quickimport/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importImageQuickRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ImportImageQuickResponse>(response);
        }
        
        /// <summary>
        /// 按标签查询镜像
        ///
        /// 该接口用于按标签或其他条件对镜像进行过滤或者计数使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListImageByTagsResponse ListImageByTags(ListImageByTagsRequest listImageByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listImageByTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListImageByTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像标签
        ///
        /// 该接口用于为查询指定镜像上的所有标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListImageTagsResponse ListImageTags(ListImageTagsRequest listImageTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , listImageTagsRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/{image_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListImageTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像列表
        ///
        /// 根据不同条件查询镜像列表信息。
        /// 可以在URI后面用‘?’和‘&amp;’添加不同的查询条件组合，请参考请求样例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListImagesResponse ListImages(ListImagesRequest listImagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/cloudimages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImagesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListImagesResponse>(response);
        }
        
        /// <summary>
        /// 查询租户所有镜像标签
        ///
        /// 该接口用于为查询租户的所有镜像上的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListImagesTagsResponse ListImagesTags(ListImagesTagsRequest listImagesTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImagesTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListImagesTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像支持的OS列表
        ///
        /// 查询当前区域弹性云服务器的OS兼容性列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOsVersionsResponse ListOsVersions(ListOsVersionsRequest listOsVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/os_version",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOsVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListOsVersionsResponse listOsVersionsResponse = JsonUtils.DeSerializeNull<ListOsVersionsResponse>(response);
            listOsVersionsResponse.Body = JsonUtils.DeSerializeList<ListOsVersionsResponseBody>(response);
            return listOsVersionsResponse;
        }
        
        /// <summary>
        /// 按条件查询租户镜像标签列表
        ///
        /// 根据不同条件查询镜像标签列表信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagsResponse ListTags(ListTagsRequest listTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTagsResponse>(response);
        }
        
        /// <summary>
        /// 注册镜像
        ///
        /// 该接口用于将镜像文件注册为云平台未初始化的私有镜像。
        /// 使用该接口注册镜像的具体步骤如下：
        /// 将镜像文件上传到OBS个人桶中。具体操作请参见《对象存储服务客户端指南（OBS Browser）》或《对象存储服务API参考》。
        /// 使用创建镜像元数据接口创建镜像元数据。调用成功后，保存该镜像的ID。创建镜像元数据请参考创建镜像元数据（OpenStack原生）。
        /// 根据2得到的镜像ID，使用注册镜像接口注册OBS桶中的镜像文件。
        /// 注册镜像接口作为异步接口，调用成功后，说明后台收到了注册请求。需要根据镜像ID查询该镜像状态验证镜像注册是否成功。当镜像状态变为“active”时，表示镜像注册成功。
        /// 如何查询异步任务，请参见异步任务查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RegisterImageResponse RegisterImage(RegisterImageRequest registerImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , registerImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/upload",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<RegisterImageResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像配额
        ///
        /// 该接口为扩展接口，主要用于查询租户在当前Region的私有镜像的配额数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowImageQuotaResponse ShowImageQuota(ShowImageQuotaRequest showImageQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/quota",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageQuotaRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowImageQuotaResponse>(response);
        }
        
        /// <summary>
        /// 查询job状态
        ///
        /// 该接口为扩展接口，主要用于查询异步接口执行情况，比如查询导出镜像任务的执行状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobResponse ShowJob(ShowJobRequest showJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }
        
        /// <summary>
        /// 异步任务进度查询
        ///
        /// 该接口为扩展接口，主要用于查询异步任务进度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobProgressResponse ShowJobProgress(ShowJobProgressRequest showJobProgressRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobProgressRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/job/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobProgressRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowJobProgressResponse>(response);
        }
        
        /// <summary>
        /// 更新镜像信息
        ///
        /// 更新镜像信息接口，主要用于镜像属性的修改。当前仅支持可用（active）状态的镜像更新相关信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateImageResponse UpdateImage(UpdateImageRequest updateImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , updateImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/cloudimages/{image_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerialize<UpdateImageResponse>(response);
        }
        
        /// <summary>
        /// 查询版本列表（OpenStack原生）
        ///
        /// 查询API的版本信息列表，包括API的版本兼容性、域名信息等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVersionsResponse ListVersions(ListVersionsRequest listVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVersionsResponse>(response);
        }
        
        /// <summary>
        /// 查询版本列表（OpenStack原生）
        ///
        /// 查询API的版本信息列表，包括API的版本兼容性、域名信息等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVersionResponse ShowVersion(ShowVersionRequest showVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version" , showVersionRequest.Version.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVersionResponse>(response);
        }
        
        /// <summary>
        /// 添加镜像成员（OpenStack原生）
        ///
        /// 用户共享镜像给其他用户时，使用该接口向该镜像成员中添加接受镜像用户的项目ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GlanceAddImageMemberResponse GlanceAddImageMember(GlanceAddImageMemberRequest glanceAddImageMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceAddImageMemberRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceAddImageMemberRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<GlanceAddImageMemberResponse>(response);
        }
        
        /// <summary>
        /// 创建镜像元数据（OpenStack原生）
        ///
        /// 创建镜像元数据。调用创建镜像元数据接口成功后，只是创建了镜像的元数据，镜像对应的实际镜像文件并不存在
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GlanceCreateImageMetadataResponse GlanceCreateImageMetadata(GlanceCreateImageMetadataRequest glanceCreateImageMetadataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/images",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceCreateImageMetadataRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<GlanceCreateImageMetadataResponse>(response);
        }
        
        /// <summary>
        /// 增加标签（OpenStack原生）
        ///
        /// 该接口主要用于为某个镜像添加一个自定义标签。通过自定义标签，用户可以将镜像进行分类。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GlanceCreateTagResponse GlanceCreateTag(GlanceCreateTagRequest glanceCreateTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceCreateTagRequest.ImageId.ToString());
            urlParam.Add("tag" , glanceCreateTagRequest.Tag.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/tags/{tag}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceCreateTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<GlanceCreateTagResponse>(response);
        }
        
        /// <summary>
        /// 删除镜像（OpenStack原生）
        ///
        /// 该接口主要用于删除镜像，用户可以通过该接口将自己的私有镜像删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GlanceDeleteImageResponse GlanceDeleteImage(GlanceDeleteImageRequest glanceDeleteImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceDeleteImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceDeleteImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<GlanceDeleteImageResponse>(response);
        }
        
        /// <summary>
        /// 删除指定的镜像成员（OpenStack原生）
        ///
        /// 该接口用于取消对某个用户的镜像共享。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GlanceDeleteImageMemberResponse GlanceDeleteImageMember(GlanceDeleteImageMemberRequest glanceDeleteImageMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceDeleteImageMemberRequest.ImageId.ToString());
            urlParam.Add("member_id" , glanceDeleteImageMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceDeleteImageMemberRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<GlanceDeleteImageMemberResponse>(response);
        }
        
        /// <summary>
        /// 删除标签（OpenStack原生）
        ///
        /// 该接口主要用于删除某个镜像的自定义标签，通过该接口，用户可以将私有镜像中一些不用的标签删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GlanceDeleteTagResponse GlanceDeleteTag(GlanceDeleteTagRequest glanceDeleteTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceDeleteTagRequest.ImageId.ToString());
            urlParam.Add("tag" , glanceDeleteTagRequest.Tag.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/tags/{tag}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceDeleteTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<GlanceDeleteTagResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像成员列表视图（OpenStack原生）
        ///
        /// 该接口主要用于查询镜像成员列表视图，通过视图，用户可以了解到镜像成员包含哪些属性，同时也可以了解每个属性的数据类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GlanceListImageMemberSchemasResponse GlanceListImageMemberSchemas(GlanceListImageMemberSchemasRequest glanceListImageMemberSchemasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/schemas/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceListImageMemberSchemasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<GlanceListImageMemberSchemasResponse>(response);
        }
        
        /// <summary>
        /// 获取镜像成员列表（OpenStack原生）
        ///
        /// 该接口用于共享镜像过程中，获取接受该镜像的成员列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GlanceListImageMembersResponse GlanceListImageMembers(GlanceListImageMembersRequest glanceListImageMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceListImageMembersRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceListImageMembersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<GlanceListImageMembersResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像列表视图（OpenStack原生）
        ///
        /// 该接口主要用于查询镜像列表视图，通过该接口用户可以了解到镜像列表的详细情况和数据结构。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GlanceListImageSchemasResponse GlanceListImageSchemas(GlanceListImageSchemasRequest glanceListImageSchemasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/schemas/images",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceListImageSchemasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<GlanceListImageSchemasResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像列表（OpenStack原生）
        ///
        /// 获取镜像列表。
        /// 使用本接口查询镜像列表时，需要使用分页查询才能返回全部的镜像列表。
        /// 分页说明
        /// 分页是指返回一组镜像的一个子集，在返回的时候会存在下个子集的链接和首个子集的链接，默认返回的子集中数量为25，用户也可以通过使用limit和marker两个参数自己分页，指定返回子集中需要返回的数量。
        /// 响应中的参数first是查询首页的URL。next是查询下一页的URL。当查询镜像列表最后一页时，不存在next。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GlanceListImagesResponse GlanceListImages(GlanceListImagesRequest glanceListImagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/images",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceListImagesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<GlanceListImagesResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像详情（OpenStack原生）
        ///
        /// 查询单个镜像详情，用户可以通过该接口查询单个私有或者公共镜像的详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GlanceShowImageResponse GlanceShowImage(GlanceShowImageRequest glanceShowImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceShowImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceShowImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<GlanceShowImageResponse>(response);
        }
        
        /// <summary>
        /// 获取镜像成员详情（OpenStack原生）
        ///
        /// 该接口主要用于镜像共享中查询某个镜像成员的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GlanceShowImageMemberResponse GlanceShowImageMember(GlanceShowImageMemberRequest glanceShowImageMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceShowImageMemberRequest.ImageId.ToString());
            urlParam.Add("member_id" , glanceShowImageMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceShowImageMemberRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<GlanceShowImageMemberResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像成员视图（OpenStack原生）
        ///
        /// 该接口主要用于查询镜像成员视图，通过视图，用户可以了解到镜像成员包含哪些属性，同时也可以了解每个属性的数据类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GlanceShowImageMemberSchemasResponse GlanceShowImageMemberSchemas(GlanceShowImageMemberSchemasRequest glanceShowImageMemberSchemasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/schemas/member",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceShowImageMemberSchemasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<GlanceShowImageMemberSchemasResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像视图（OpenStack原生）
        ///
        /// 该接口主要用于查询镜像视图，通过视图，用户可以了解到镜像包含哪些属性，同时也可以了解每个属性的数据类型等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GlanceShowImageSchemasResponse GlanceShowImageSchemas(GlanceShowImageSchemasRequest glanceShowImageSchemasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/schemas/image",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceShowImageSchemasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<GlanceShowImageSchemasResponse>(response);
        }
        
        /// <summary>
        /// 更新镜像信息（OpenStack原生）
        ///
        /// 修改镜像信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GlanceUpdateImageResponse GlanceUpdateImage(GlanceUpdateImageRequest glanceUpdateImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceUpdateImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/openstack-images-v2.1-json-patch", glanceUpdateImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerialize<GlanceUpdateImageResponse>(response);
        }
        
        /// <summary>
        /// 更新镜像成员状态（OpenStack原生）
        ///
        /// 用户接受或者拒绝共享镜像时，使用该接口更新镜像成员的状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GlanceUpdateImageMemberResponse GlanceUpdateImageMember(GlanceUpdateImageMemberRequest glanceUpdateImageMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceUpdateImageMemberRequest.ImageId.ToString());
            urlParam.Add("member_id" , glanceUpdateImageMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceUpdateImageMemberRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<GlanceUpdateImageMemberResponse>(response);
        }
        
    }
}