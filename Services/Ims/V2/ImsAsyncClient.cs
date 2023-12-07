using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ims.V2.Model;

namespace HuaweiCloud.SDK.Ims.V2
{
    public partial class ImsAsyncClient : Client
    {
        public static ClientBuilder<ImsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<ImsAsyncClient>();
        }

        
        /// <summary>
        /// 添加镜像标签
        ///
        /// 该接口用于为指定镜像添加或更新指定的单个标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddImageTagResponse> AddImageTagAsync(AddImageTagRequest addImageTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", addImageTagRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/{image_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addImageTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddImageTagResponse>(response);
        }

        public AsyncInvoker<AddImageTagResponse> AddImageTagAsyncInvoker(AddImageTagRequest addImageTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", addImageTagRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/{image_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addImageTagRequest);
            return new AsyncInvoker<AddImageTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddImageTagResponse>);
        }
        
        /// <summary>
        /// 批量添加镜像成员
        ///
        /// 该接口为扩展接口，主要用于镜像共享时用户将多个镜像共享给多个用户。
        /// 该接口为异步接口，返回job_id说明任务下发成功，查询异步任务状态，如果是success说明任务执行成功，如果是failed说明任务执行失败。如何查询异步任务，请参见异步任务查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchAddMembersResponse> BatchAddMembersAsync(BatchAddMembersRequest batchAddMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddMembersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchAddMembersResponse>(response);
        }

        public AsyncInvoker<BatchAddMembersResponse> BatchAddMembersAsyncInvoker(BatchAddMembersRequest batchAddMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddMembersRequest);
            return new AsyncInvoker<BatchAddMembersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAddMembersResponse>);
        }
        
        /// <summary>
        /// 批量添加删除镜像标签
        ///
        /// 该接口用于为指定镜像批量添加/更新、删除标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchAddOrDeleteTagsResponse> BatchAddOrDeleteTagsAsync(BatchAddOrDeleteTagsRequest batchAddOrDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", batchAddOrDeleteTagsRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/{image_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddOrDeleteTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchAddOrDeleteTagsResponse>(response);
        }

        public AsyncInvoker<BatchAddOrDeleteTagsResponse> BatchAddOrDeleteTagsAsyncInvoker(BatchAddOrDeleteTagsRequest batchAddOrDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", batchAddOrDeleteTagsRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/{image_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddOrDeleteTagsRequest);
            return new AsyncInvoker<BatchAddOrDeleteTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchAddOrDeleteTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除镜像成员
        ///
        /// 该接口为扩展接口，主要用于取消镜像共享。
        /// 该接口为异步接口，返回job_id说明任务下发成功，查询异步任务状态，如果是success说明任务执行成功，如果是failed说明任务执行失败。如何查询异步任务，请参见异步任务查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteMembersResponse> BatchDeleteMembersAsync(BatchDeleteMembersRequest batchDeleteMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteMembersRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteMembersResponse>(response);
        }

        public AsyncInvoker<BatchDeleteMembersResponse> BatchDeleteMembersAsyncInvoker(BatchDeleteMembersRequest batchDeleteMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteMembersRequest);
            return new AsyncInvoker<BatchDeleteMembersResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteMembersResponse>);
        }
        
        /// <summary>
        /// 批量更新镜像成员状态
        ///
        /// 该接口为扩展接口，主要用于用户接受或者拒绝多个共享镜像时批量更新镜像成员的状态。
        /// 该接口为异步接口，返回job_id说明任务下发成功，查询异步任务状态，如果是success说明任务执行成功，如果是failed说明任务执行失败。如何查询异步任务，请参见异步任务查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateMembersResponse> BatchUpdateMembersAsync(BatchUpdateMembersRequest batchUpdateMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateMembersRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateMembersResponse>(response);
        }

        public AsyncInvoker<BatchUpdateMembersResponse> BatchUpdateMembersAsyncInvoker(BatchUpdateMembersRequest batchUpdateMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateMembersRequest);
            return new AsyncInvoker<BatchUpdateMembersResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateMembersResponse>);
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
        public async Task<CopyImageCrossRegionResponse> CopyImageCrossRegionAsync(CopyImageCrossRegionRequest copyImageCrossRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", copyImageCrossRegionRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/cross_region_copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyImageCrossRegionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CopyImageCrossRegionResponse>(response);
        }

        public AsyncInvoker<CopyImageCrossRegionResponse> CopyImageCrossRegionAsyncInvoker(CopyImageCrossRegionRequest copyImageCrossRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", copyImageCrossRegionRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/cross_region_copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyImageCrossRegionRequest);
            return new AsyncInvoker<CopyImageCrossRegionResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyImageCrossRegionResponse>);
        }
        
        /// <summary>
        /// Region内复制镜像
        ///
        /// 该接口为扩展接口，主要用于用户将一个已有镜像复制为另一个镜像。复制镜像时，可以更改镜像的加密等属性，以满足不同的场景。
        /// 该接口为异步接口，返回job_id说明任务下发成功，查询异步任务状态，如果是success说明任务执行成功，如果是failed说明任务执行失败。如何查询异步任务，请参见异步任务查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CopyImageInRegionResponse> CopyImageInRegionAsync(CopyImageInRegionRequest copyImageInRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", copyImageInRegionRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyImageInRegionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CopyImageInRegionResponse>(response);
        }

        public AsyncInvoker<CopyImageInRegionResponse> CopyImageInRegionAsyncInvoker(CopyImageInRegionRequest copyImageInRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", copyImageInRegionRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyImageInRegionRequest);
            return new AsyncInvoker<CopyImageInRegionResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyImageInRegionResponse>);
        }
        
        /// <summary>
        /// 使用外部镜像文件制作数据镜像
        ///
        /// 使用上传至OBS桶中的外部数据卷镜像文件制作数据镜像。作为异步接口，调用成功，只是说明后台收到了制作请求，镜像是否制作成功需要通过异步任务查询接口查询该任务的执行状态。具体请参考异步任务查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDataImageResponse> CreateDataImageAsync(CreateDataImageRequest createDataImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/dataimages/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDataImageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDataImageResponse>(response);
        }

        public AsyncInvoker<CreateDataImageResponse> CreateDataImageAsyncInvoker(CreateDataImageRequest createDataImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/dataimages/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDataImageRequest);
            return new AsyncInvoker<CreateDataImageResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDataImageResponse>);
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
        public async Task<CreateImageResponse> CreateImageAsync(CreateImageRequest createImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/cloudimages/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createImageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateImageResponse>(response);
        }

        public AsyncInvoker<CreateImageResponse> CreateImageAsyncInvoker(CreateImageRequest createImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/cloudimages/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createImageRequest);
            return new AsyncInvoker<CreateImageResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateImageResponse>);
        }
        
        /// <summary>
        /// 增加或修改标签
        ///
        /// 该接口主要用于为某个镜像增加或修改一个自定义标签。通过自定义标签，用户可以将镜像进行分类。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateOrUpdateTagsResponse> CreateOrUpdateTagsAsync(CreateOrUpdateTagsRequest createOrUpdateTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOrUpdateTagsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<CreateOrUpdateTagsResponse>(response);
        }

        public AsyncInvoker<CreateOrUpdateTagsResponse> CreateOrUpdateTagsAsyncInvoker(CreateOrUpdateTagsRequest createOrUpdateTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOrUpdateTagsRequest);
            return new AsyncInvoker<CreateOrUpdateTagsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<CreateOrUpdateTagsResponse>);
        }
        
        /// <summary>
        /// 制作整机镜像
        ///
        /// 使用云服务器或者云服务器备份制作整机镜像。作为异步接口，调用成功，只是说明后台收到了制作整机镜像的请求，镜像是否制作成功需要通过异步任务查询接口查询该任务的执行状态，具体请参考异步任务查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateWholeImageResponse> CreateWholeImageAsync(CreateWholeImageRequest createWholeImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/wholeimages/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWholeImageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateWholeImageResponse>(response);
        }

        public AsyncInvoker<CreateWholeImageResponse> CreateWholeImageAsyncInvoker(CreateWholeImageRequest createWholeImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/wholeimages/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWholeImageRequest);
            return new AsyncInvoker<CreateWholeImageResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWholeImageResponse>);
        }
        
        /// <summary>
        /// 删除镜像标签
        ///
        /// 该接口用于为镜像删除指定的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteImageTagResponse> DeleteImageTagAsync(DeleteImageTagRequest deleteImageTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", deleteImageTagRequest.ImageId.ToString());
            urlParam.Add("key", deleteImageTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/{image_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImageTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteImageTagResponse>(response);
        }

        public AsyncInvoker<DeleteImageTagResponse> DeleteImageTagAsyncInvoker(DeleteImageTagRequest deleteImageTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", deleteImageTagRequest.ImageId.ToString());
            urlParam.Add("key", deleteImageTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/{image_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImageTagRequest);
            return new AsyncInvoker<DeleteImageTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteImageTagResponse>);
        }
        
        /// <summary>
        /// 导出镜像
        ///
        /// 该接口为扩展接口，用于用户将自己的私有镜像导出到指定的OBS桶中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExportImageResponse> ExportImageAsync(ExportImageRequest exportImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", exportImageRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exportImageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExportImageResponse>(response);
        }

        public AsyncInvoker<ExportImageResponse> ExportImageAsyncInvoker(ExportImageRequest exportImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", exportImageRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exportImageRequest);
            return new AsyncInvoker<ExportImageResponse>(this, "POST", request, JsonUtils.DeSerialize<ExportImageResponse>);
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
        public async Task<ImportImageQuickResponse> ImportImageQuickAsync(ImportImageQuickRequest importImageQuickRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/cloudimages/quickimport/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importImageQuickRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ImportImageQuickResponse>(response);
        }

        public AsyncInvoker<ImportImageQuickResponse> ImportImageQuickAsyncInvoker(ImportImageQuickRequest importImageQuickRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/cloudimages/quickimport/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importImageQuickRequest);
            return new AsyncInvoker<ImportImageQuickResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportImageQuickResponse>);
        }
        
        /// <summary>
        /// 按标签查询镜像
        ///
        /// 该接口用于按标签或其他条件对镜像进行过滤或者计数使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListImageByTagsResponse> ListImageByTagsAsync(ListImageByTagsRequest listImageByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listImageByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListImageByTagsResponse>(response);
        }

        public AsyncInvoker<ListImageByTagsResponse> ListImageByTagsAsyncInvoker(ListImageByTagsRequest listImageByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listImageByTagsRequest);
            return new AsyncInvoker<ListImageByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListImageByTagsResponse>);
        }
        
        /// <summary>
        /// 查询镜像标签
        ///
        /// 该接口用于为查询指定镜像上的所有标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListImageTagsResponse> ListImageTagsAsync(ListImageTagsRequest listImageTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", listImageTagsRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/{image_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListImageTagsResponse>(response);
        }

        public AsyncInvoker<ListImageTagsResponse> ListImageTagsAsyncInvoker(ListImageTagsRequest listImageTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", listImageTagsRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/{image_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageTagsRequest);
            return new AsyncInvoker<ListImageTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListImageTagsResponse>);
        }
        
        /// <summary>
        /// 查询镜像列表
        ///
        /// 根据不同条件查询镜像列表信息。
        /// 可以在URI后面用‘?’和‘&amp;’添加不同的查询条件组合，请参考请求样例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListImagesResponse> ListImagesAsync(ListImagesRequest listImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/cloudimages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImagesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListImagesResponse>(response);
        }

        public AsyncInvoker<ListImagesResponse> ListImagesAsyncInvoker(ListImagesRequest listImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/cloudimages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImagesRequest);
            return new AsyncInvoker<ListImagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListImagesResponse>);
        }
        
        /// <summary>
        /// 查询租户所有镜像标签
        ///
        /// 该接口用于为查询租户的所有镜像上的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListImagesTagsResponse> ListImagesTagsAsync(ListImagesTagsRequest listImagesTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImagesTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListImagesTagsResponse>(response);
        }

        public AsyncInvoker<ListImagesTagsResponse> ListImagesTagsAsyncInvoker(ListImagesTagsRequest listImagesTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImagesTagsRequest);
            return new AsyncInvoker<ListImagesTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListImagesTagsResponse>);
        }
        
        /// <summary>
        /// 查询镜像支持的OS列表
        ///
        /// 查询当前区域弹性云服务器的OS兼容性列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOsVersionsResponse> ListOsVersionsAsync(ListOsVersionsRequest listOsVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/os_version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOsVersionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listOsVersionsResponse = JsonUtils.DeSerializeNull<ListOsVersionsResponse>(response);
            listOsVersionsResponse.Body = JsonUtils.DeSerializeList<ListOsVersionsResponseBody>(response);
            return listOsVersionsResponse;
        }

        public AsyncInvoker<ListOsVersionsResponse> ListOsVersionsAsyncInvoker(ListOsVersionsRequest listOsVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/os_version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOsVersionsRequest);
            return new AsyncInvoker<ListOsVersionsResponse>(this, "GET", request, response =>
            {
                var listOsVersionsResponse = JsonUtils.DeSerializeNull<ListOsVersionsResponse>(response);
                listOsVersionsResponse.Body = JsonUtils.DeSerializeList<ListOsVersionsResponseBody>(response);
                return listOsVersionsResponse;
            });
        }
        
        /// <summary>
        /// 按条件查询租户镜像标签列表
        ///
        /// 根据不同条件查询镜像标签列表信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTagsResponse> ListTagsAsync(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTagsResponse>(response);
        }

        public AsyncInvoker<ListTagsResponse> ListTagsAsyncInvoker(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            return new AsyncInvoker<ListTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagsResponse>);
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
        public async Task<RegisterImageResponse> RegisterImageAsync(RegisterImageRequest registerImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", registerImageRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/upload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerImageRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<RegisterImageResponse>(response);
        }

        public AsyncInvoker<RegisterImageResponse> RegisterImageAsyncInvoker(RegisterImageRequest registerImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", registerImageRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/upload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerImageRequest);
            return new AsyncInvoker<RegisterImageResponse>(this, "PUT", request, JsonUtils.DeSerialize<RegisterImageResponse>);
        }
        
        /// <summary>
        /// 查询镜像配额
        ///
        /// 该接口为扩展接口，主要用于查询租户在当前Region的私有镜像的配额数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowImageQuotaResponse> ShowImageQuotaAsync(ShowImageQuotaRequest showImageQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowImageQuotaResponse>(response);
        }

        public AsyncInvoker<ShowImageQuotaResponse> ShowImageQuotaAsyncInvoker(ShowImageQuotaRequest showImageQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageQuotaRequest);
            return new AsyncInvoker<ShowImageQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowImageQuotaResponse>);
        }
        
        /// <summary>
        /// 查询job状态
        ///
        /// 该接口为扩展接口，主要用于查询异步接口执行情况，比如查询导出镜像任务的执行状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobResponse> ShowJobAsync(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }

        public AsyncInvoker<ShowJobResponse> ShowJobAsyncInvoker(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            return new AsyncInvoker<ShowJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobResponse>);
        }
        
        /// <summary>
        /// 异步任务进度查询
        ///
        /// 该接口为扩展接口，主要用于查询异步任务进度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobProgressResponse> ShowJobProgressAsync(ShowJobProgressRequest showJobProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobProgressRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/job/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobProgressRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobProgressResponse>(response);
        }

        public AsyncInvoker<ShowJobProgressResponse> ShowJobProgressAsyncInvoker(ShowJobProgressRequest showJobProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobProgressRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/job/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobProgressRequest);
            return new AsyncInvoker<ShowJobProgressResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobProgressResponse>);
        }
        
        /// <summary>
        /// 更新镜像信息
        ///
        /// 更新镜像信息接口，主要用于镜像属性的修改。当前仅支持可用（active）状态的镜像更新相关信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateImageResponse> UpdateImageAsync(UpdateImageRequest updateImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", updateImageRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/cloudimages/{image_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateImageRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateImageResponse>(response);
        }

        public AsyncInvoker<UpdateImageResponse> UpdateImageAsyncInvoker(UpdateImageRequest updateImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", updateImageRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/cloudimages/{image_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateImageRequest);
            return new AsyncInvoker<UpdateImageResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateImageResponse>);
        }
        
        /// <summary>
        /// 查询版本列表（OpenStack原生）
        ///
        /// 查询API的版本信息列表，包括API的版本兼容性、域名信息等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest listVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListVersionsResponse>(response);
        }

        public AsyncInvoker<ListVersionsResponse> ListVersionsAsyncInvoker(ListVersionsRequest listVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionsRequest);
            return new AsyncInvoker<ListVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVersionsResponse>);
        }
        
        /// <summary>
        /// 查询版本列表（OpenStack原生）
        ///
        /// 查询API的版本信息列表，包括API的版本兼容性、域名信息等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVersionResponse> ShowVersionAsync(ShowVersionRequest showVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", showVersionRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowVersionResponse>(response);
        }

        public AsyncInvoker<ShowVersionResponse> ShowVersionAsyncInvoker(ShowVersionRequest showVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", showVersionRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            return new AsyncInvoker<ShowVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVersionResponse>);
        }
        
        /// <summary>
        /// 添加镜像成员（OpenStack原生）
        ///
        /// 用户共享镜像给其他用户时，使用该接口向该镜像成员中添加接受镜像用户的项目ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GlanceAddImageMemberResponse> GlanceAddImageMemberAsync(GlanceAddImageMemberRequest glanceAddImageMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", glanceAddImageMemberRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceAddImageMemberRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<GlanceAddImageMemberResponse>(response);
        }

        public AsyncInvoker<GlanceAddImageMemberResponse> GlanceAddImageMemberAsyncInvoker(GlanceAddImageMemberRequest glanceAddImageMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", glanceAddImageMemberRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceAddImageMemberRequest);
            return new AsyncInvoker<GlanceAddImageMemberResponse>(this, "POST", request, JsonUtils.DeSerialize<GlanceAddImageMemberResponse>);
        }
        
        /// <summary>
        /// 创建镜像元数据（OpenStack原生）
        ///
        /// 创建镜像元数据。调用创建镜像元数据接口成功后，只是创建了镜像的元数据，镜像对应的实际镜像文件并不存在
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GlanceCreateImageMetadataResponse> GlanceCreateImageMetadataAsync(GlanceCreateImageMetadataRequest glanceCreateImageMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceCreateImageMetadataRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<GlanceCreateImageMetadataResponse>(response);
        }

        public AsyncInvoker<GlanceCreateImageMetadataResponse> GlanceCreateImageMetadataAsyncInvoker(GlanceCreateImageMetadataRequest glanceCreateImageMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceCreateImageMetadataRequest);
            return new AsyncInvoker<GlanceCreateImageMetadataResponse>(this, "POST", request, JsonUtils.DeSerialize<GlanceCreateImageMetadataResponse>);
        }
        
        /// <summary>
        /// 增加标签（OpenStack原生）
        ///
        /// 该接口主要用于为某个镜像添加一个自定义标签。通过自定义标签，用户可以将镜像进行分类。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GlanceCreateTagResponse> GlanceCreateTagAsync(GlanceCreateTagRequest glanceCreateTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", glanceCreateTagRequest.ImageId.ToString());
            urlParam.Add("tag", glanceCreateTagRequest.Tag.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/tags/{tag}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceCreateTagRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<GlanceCreateTagResponse>(response);
        }

        public AsyncInvoker<GlanceCreateTagResponse> GlanceCreateTagAsyncInvoker(GlanceCreateTagRequest glanceCreateTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", glanceCreateTagRequest.ImageId.ToString());
            urlParam.Add("tag", glanceCreateTagRequest.Tag.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/tags/{tag}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceCreateTagRequest);
            return new AsyncInvoker<GlanceCreateTagResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<GlanceCreateTagResponse>);
        }
        
        /// <summary>
        /// 删除镜像（OpenStack原生）
        ///
        /// 该接口主要用于删除镜像，用户可以通过该接口将自己的私有镜像删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GlanceDeleteImageResponse> GlanceDeleteImageAsync(GlanceDeleteImageRequest glanceDeleteImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", glanceDeleteImageRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceDeleteImageRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<GlanceDeleteImageResponse>(response);
        }

        public AsyncInvoker<GlanceDeleteImageResponse> GlanceDeleteImageAsyncInvoker(GlanceDeleteImageRequest glanceDeleteImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", glanceDeleteImageRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceDeleteImageRequest);
            return new AsyncInvoker<GlanceDeleteImageResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<GlanceDeleteImageResponse>);
        }
        
        /// <summary>
        /// 删除指定的镜像成员（OpenStack原生）
        ///
        /// 该接口用于取消对某个用户的镜像共享。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GlanceDeleteImageMemberResponse> GlanceDeleteImageMemberAsync(GlanceDeleteImageMemberRequest glanceDeleteImageMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", glanceDeleteImageMemberRequest.ImageId.ToString());
            urlParam.Add("member_id", glanceDeleteImageMemberRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceDeleteImageMemberRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<GlanceDeleteImageMemberResponse>(response);
        }

        public AsyncInvoker<GlanceDeleteImageMemberResponse> GlanceDeleteImageMemberAsyncInvoker(GlanceDeleteImageMemberRequest glanceDeleteImageMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", glanceDeleteImageMemberRequest.ImageId.ToString());
            urlParam.Add("member_id", glanceDeleteImageMemberRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceDeleteImageMemberRequest);
            return new AsyncInvoker<GlanceDeleteImageMemberResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<GlanceDeleteImageMemberResponse>);
        }
        
        /// <summary>
        /// 删除标签（OpenStack原生）
        ///
        /// 该接口主要用于删除某个镜像的自定义标签，通过该接口，用户可以将私有镜像中一些不用的标签删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GlanceDeleteTagResponse> GlanceDeleteTagAsync(GlanceDeleteTagRequest glanceDeleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", glanceDeleteTagRequest.ImageId.ToString());
            urlParam.Add("tag", glanceDeleteTagRequest.Tag.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/tags/{tag}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceDeleteTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<GlanceDeleteTagResponse>(response);
        }

        public AsyncInvoker<GlanceDeleteTagResponse> GlanceDeleteTagAsyncInvoker(GlanceDeleteTagRequest glanceDeleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", glanceDeleteTagRequest.ImageId.ToString());
            urlParam.Add("tag", glanceDeleteTagRequest.Tag.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/tags/{tag}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceDeleteTagRequest);
            return new AsyncInvoker<GlanceDeleteTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<GlanceDeleteTagResponse>);
        }
        
        /// <summary>
        /// 查询镜像成员列表视图（OpenStack原生）
        ///
        /// 该接口主要用于查询镜像成员列表视图，通过视图，用户可以了解到镜像成员包含哪些属性，同时也可以了解每个属性的数据类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GlanceListImageMemberSchemasResponse> GlanceListImageMemberSchemasAsync(GlanceListImageMemberSchemasRequest glanceListImageMemberSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/schemas/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceListImageMemberSchemasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GlanceListImageMemberSchemasResponse>(response);
        }

        public AsyncInvoker<GlanceListImageMemberSchemasResponse> GlanceListImageMemberSchemasAsyncInvoker(GlanceListImageMemberSchemasRequest glanceListImageMemberSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/schemas/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceListImageMemberSchemasRequest);
            return new AsyncInvoker<GlanceListImageMemberSchemasResponse>(this, "GET", request, JsonUtils.DeSerialize<GlanceListImageMemberSchemasResponse>);
        }
        
        /// <summary>
        /// 获取镜像成员列表（OpenStack原生）
        ///
        /// 该接口用于共享镜像过程中，获取接受该镜像的成员列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GlanceListImageMembersResponse> GlanceListImageMembersAsync(GlanceListImageMembersRequest glanceListImageMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", glanceListImageMembersRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceListImageMembersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GlanceListImageMembersResponse>(response);
        }

        public AsyncInvoker<GlanceListImageMembersResponse> GlanceListImageMembersAsyncInvoker(GlanceListImageMembersRequest glanceListImageMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", glanceListImageMembersRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceListImageMembersRequest);
            return new AsyncInvoker<GlanceListImageMembersResponse>(this, "GET", request, JsonUtils.DeSerialize<GlanceListImageMembersResponse>);
        }
        
        /// <summary>
        /// 查询镜像列表视图（OpenStack原生）
        ///
        /// 该接口主要用于查询镜像列表视图，通过该接口用户可以了解到镜像列表的详细情况和数据结构。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GlanceListImageSchemasResponse> GlanceListImageSchemasAsync(GlanceListImageSchemasRequest glanceListImageSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/schemas/images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceListImageSchemasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GlanceListImageSchemasResponse>(response);
        }

        public AsyncInvoker<GlanceListImageSchemasResponse> GlanceListImageSchemasAsyncInvoker(GlanceListImageSchemasRequest glanceListImageSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/schemas/images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceListImageSchemasRequest);
            return new AsyncInvoker<GlanceListImageSchemasResponse>(this, "GET", request, JsonUtils.DeSerialize<GlanceListImageSchemasResponse>);
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
        public async Task<GlanceListImagesResponse> GlanceListImagesAsync(GlanceListImagesRequest glanceListImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceListImagesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GlanceListImagesResponse>(response);
        }

        public AsyncInvoker<GlanceListImagesResponse> GlanceListImagesAsyncInvoker(GlanceListImagesRequest glanceListImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceListImagesRequest);
            return new AsyncInvoker<GlanceListImagesResponse>(this, "GET", request, JsonUtils.DeSerialize<GlanceListImagesResponse>);
        }
        
        /// <summary>
        /// 查询镜像详情（OpenStack原生）
        ///
        /// 查询单个镜像详情，用户可以通过该接口查询单个私有或者公共镜像的详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GlanceShowImageResponse> GlanceShowImageAsync(GlanceShowImageRequest glanceShowImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", glanceShowImageRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceShowImageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GlanceShowImageResponse>(response);
        }

        public AsyncInvoker<GlanceShowImageResponse> GlanceShowImageAsyncInvoker(GlanceShowImageRequest glanceShowImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", glanceShowImageRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceShowImageRequest);
            return new AsyncInvoker<GlanceShowImageResponse>(this, "GET", request, JsonUtils.DeSerialize<GlanceShowImageResponse>);
        }
        
        /// <summary>
        /// 获取镜像成员详情（OpenStack原生）
        ///
        /// 该接口主要用于镜像共享中查询某个镜像成员的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GlanceShowImageMemberResponse> GlanceShowImageMemberAsync(GlanceShowImageMemberRequest glanceShowImageMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", glanceShowImageMemberRequest.ImageId.ToString());
            urlParam.Add("member_id", glanceShowImageMemberRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceShowImageMemberRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GlanceShowImageMemberResponse>(response);
        }

        public AsyncInvoker<GlanceShowImageMemberResponse> GlanceShowImageMemberAsyncInvoker(GlanceShowImageMemberRequest glanceShowImageMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", glanceShowImageMemberRequest.ImageId.ToString());
            urlParam.Add("member_id", glanceShowImageMemberRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceShowImageMemberRequest);
            return new AsyncInvoker<GlanceShowImageMemberResponse>(this, "GET", request, JsonUtils.DeSerialize<GlanceShowImageMemberResponse>);
        }
        
        /// <summary>
        /// 查询镜像成员视图（OpenStack原生）
        ///
        /// 该接口主要用于查询镜像成员视图，通过视图，用户可以了解到镜像成员包含哪些属性，同时也可以了解每个属性的数据类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GlanceShowImageMemberSchemasResponse> GlanceShowImageMemberSchemasAsync(GlanceShowImageMemberSchemasRequest glanceShowImageMemberSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/schemas/member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceShowImageMemberSchemasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GlanceShowImageMemberSchemasResponse>(response);
        }

        public AsyncInvoker<GlanceShowImageMemberSchemasResponse> GlanceShowImageMemberSchemasAsyncInvoker(GlanceShowImageMemberSchemasRequest glanceShowImageMemberSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/schemas/member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceShowImageMemberSchemasRequest);
            return new AsyncInvoker<GlanceShowImageMemberSchemasResponse>(this, "GET", request, JsonUtils.DeSerialize<GlanceShowImageMemberSchemasResponse>);
        }
        
        /// <summary>
        /// 查询镜像视图（OpenStack原生）
        ///
        /// 该接口主要用于查询镜像视图，通过视图，用户可以了解到镜像包含哪些属性，同时也可以了解每个属性的数据类型等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GlanceShowImageSchemasResponse> GlanceShowImageSchemasAsync(GlanceShowImageSchemasRequest glanceShowImageSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/schemas/image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceShowImageSchemasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GlanceShowImageSchemasResponse>(response);
        }

        public AsyncInvoker<GlanceShowImageSchemasResponse> GlanceShowImageSchemasAsyncInvoker(GlanceShowImageSchemasRequest glanceShowImageSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/schemas/image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceShowImageSchemasRequest);
            return new AsyncInvoker<GlanceShowImageSchemasResponse>(this, "GET", request, JsonUtils.DeSerialize<GlanceShowImageSchemasResponse>);
        }
        
        /// <summary>
        /// 更新镜像信息（OpenStack原生）
        ///
        /// 修改镜像信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GlanceUpdateImageResponse> GlanceUpdateImageAsync(GlanceUpdateImageRequest glanceUpdateImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", glanceUpdateImageRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/openstack-images-v2.1-json-patch", glanceUpdateImageRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<GlanceUpdateImageResponse>(response);
        }

        public AsyncInvoker<GlanceUpdateImageResponse> GlanceUpdateImageAsyncInvoker(GlanceUpdateImageRequest glanceUpdateImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", glanceUpdateImageRequest.ImageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/openstack-images-v2.1-json-patch", glanceUpdateImageRequest);
            return new AsyncInvoker<GlanceUpdateImageResponse>(this, "PATCH", request, JsonUtils.DeSerialize<GlanceUpdateImageResponse>);
        }
        
        /// <summary>
        /// 更新镜像成员状态（OpenStack原生）
        ///
        /// 用户接受或者拒绝共享镜像时，使用该接口更新镜像成员的状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GlanceUpdateImageMemberResponse> GlanceUpdateImageMemberAsync(GlanceUpdateImageMemberRequest glanceUpdateImageMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", glanceUpdateImageMemberRequest.ImageId.ToString());
            urlParam.Add("member_id", glanceUpdateImageMemberRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceUpdateImageMemberRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<GlanceUpdateImageMemberResponse>(response);
        }

        public AsyncInvoker<GlanceUpdateImageMemberResponse> GlanceUpdateImageMemberAsyncInvoker(GlanceUpdateImageMemberRequest glanceUpdateImageMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id", glanceUpdateImageMemberRequest.ImageId.ToString());
            urlParam.Add("member_id", glanceUpdateImageMemberRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceUpdateImageMemberRequest);
            return new AsyncInvoker<GlanceUpdateImageMemberResponse>(this, "PUT", request, JsonUtils.DeSerialize<GlanceUpdateImageMemberResponse>);
        }
        
    }
}