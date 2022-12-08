using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Tms.v1.Model;

namespace HuaweiCloud.SDK.Tms.v1
{
    public partial class TmsClient : Client
    {
        public static ClientBuilder<TmsClient> NewBuilder()
        {
            return new ClientBuilder<TmsClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 创建预定义标签
        ///
        /// 用于创建预定标签。用户创建预定义标签后，可以使用预定义标签来给资源创建标签。该接口支持幂等特性和处理批量数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePredefineTagsResponse CreatePredefineTags(CreatePredefineTagsRequest createPredefineTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPredefineTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreatePredefineTagsResponse>(response);
        }
        
        /// <summary>
        /// 批量添加标签
        ///
        /// 用于给云服务的多个资源添加标签，每个资源最多可添加10个标签，每次最多支持批量操作20个资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateResourceTagResponse CreateResourceTag(CreateResourceTagRequest createResourceTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/resource-tags/batch-create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createResourceTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateResourceTagResponse>(response);
        }
        
        /// <summary>
        /// 删除预定义标签
        ///
        /// 用于删除预定标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePredefineTagsResponse DeletePredefineTags(DeletePredefineTagsRequest deletePredefineTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deletePredefineTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<DeletePredefineTagsResponse>(response);
        }
        
        /// <summary>
        /// 批量移除标签
        ///
        /// 用于批量移除云服务多个资源的标签，每个资源最多支持移除10个标签，每次最多支持批量操作20个资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteResourceTagResponse DeleteResourceTag(DeleteResourceTagRequest deleteResourceTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/resource-tags/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteResourceTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DeleteResourceTagResponse>(response);
        }
        
        /// <summary>
        /// 查询API版本列表
        ///
        /// 查询标签管理服务的API版本列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListApiVersionsResponse ListApiVersions(ListApiVersionsRequest listApiVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }
        
        /// <summary>
        /// 查询预定义标签列表
        ///
        /// 用于查询预定义标签列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPredefineTagsResponse ListPredefineTags(ListPredefineTagsRequest listPredefineTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPredefineTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPredefineTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询标签管理支持的服务
        ///
        /// 查询标签管理支持的服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProvidersResponse ListProviders(ListProvidersRequest listProvidersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/tms/providers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvidersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListProvidersResponse>(response);
        }
        
        /// <summary>
        /// 根据标签过滤资源
        ///
        /// 根据标签过滤资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceResponse ListResource(ListResourceRequest listResourceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/resource-instances/filter",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListResourceResponse>(response);
        }
        
        /// <summary>
        /// 查询标签键列表
        ///
        /// 查询指定区域的所有标签键.
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagKeysResponse ListTagKeys(ListTagKeysRequest listTagKeysRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/tag-keys",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagKeysRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTagKeysResponse>(response);
        }
        
        /// <summary>
        /// 查询标签值列表
        ///
        /// 查询指定区域的标签键下的所有标签值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagValuesResponse ListTagValues(ListTagValuesRequest listTagValuesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/tag-values",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagValuesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTagValuesResponse>(response);
        }
        
        /// <summary>
        /// 查询API版本号详情
        ///
        /// 查询指定的标签管理服务API版本号详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowApiVersionResponse ShowApiVersion(ShowApiVersionRequest showApiVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version" , showApiVersionRequest.ApiVersion.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{api_version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询单个资源上的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceTagResponse ShowResourceTag(ShowResourceTagRequest showResourceTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id" , showResourceTagRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/resources/{resource_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowResourceTagResponse>(response);
        }
        
        /// <summary>
        /// 查询标签配额
        ///
        /// 查询标签的配额信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTagQuotaResponse ShowTagQuota(ShowTagQuotaRequest showTagQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/tms/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagQuotaRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowTagQuotaResponse>(response);
        }
        
        /// <summary>
        /// 修改预定义标签
        ///
        /// 修改预定义标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePredefineTagsResponse UpdatePredefineTags(UpdatePredefineTagsRequest updatePredefineTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePredefineTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdatePredefineTagsResponse>(response);
        }
        
    }
}