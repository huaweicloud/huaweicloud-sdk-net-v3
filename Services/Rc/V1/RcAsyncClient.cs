using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Rc.V1.Model;

namespace HuaweiCloud.SDK.Rc.V1
{
    public partial class RcAsyncClient : Client
    {
        public static ClientBuilder<RcAsyncClient> NewBuilder()
        {
            return new ClientBuilder<RcAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 将资源添加到资源组
        ///
        /// 将一个或多个资源添加到资源组，需要当前用户有resourcecenter:group:addResource权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddResourcesToGroupResponse> AddResourcesToGroupAsync(AddResourcesToGroupRequest addResourcesToGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addResourcesToGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups/{group_id}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addResourcesToGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<AddResourcesToGroupResponse>(response);
        }

        public AsyncInvoker<AddResourcesToGroupResponse> AddResourcesToGroupAsyncInvoker(AddResourcesToGroupRequest addResourcesToGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addResourcesToGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups/{group_id}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addResourcesToGroupRequest);
            return new AsyncInvoker<AddResourcesToGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<AddResourcesToGroupResponse>);
        }
        
        /// <summary>
        /// 创建资源分组
        ///
        /// 创建一个资源分组，需要当前用户有resourcecenter:group:create权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateResourceGroupResponse> CreateResourceGroupAsync(CreateResourceGroupRequest createResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateResourceGroupResponse>(response);
        }

        public AsyncInvoker<CreateResourceGroupResponse> CreateResourceGroupAsyncInvoker(CreateResourceGroupRequest createResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceGroupRequest);
            return new AsyncInvoker<CreateResourceGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateResourceGroupResponse>);
        }
        
        /// <summary>
        /// 删除一个资源分组
        ///
        /// 删除一个资源分组，需要当前用户有resourcecenter:group:delete权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteResourceGroupResponse> DeleteResourceGroupAsync(DeleteResourceGroupRequest deleteResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteResourceGroupResponse>(response);
        }

        public AsyncInvoker<DeleteResourceGroupResponse> DeleteResourceGroupAsyncInvoker(DeleteResourceGroupRequest deleteResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceGroupRequest);
            return new AsyncInvoker<DeleteResourceGroupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteResourceGroupResponse>);
        }
        
        /// <summary>
        /// 查询资源分组列表
        ///
        /// 查询资源分组列表，需要当前用户有resourcecenter:group:list权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceGroupsResponse> ListResourceGroupsAsync(ListResourceGroupsRequest listResourceGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListResourceGroupsResponse>(response);
        }

        public AsyncInvoker<ListResourceGroupsResponse> ListResourceGroupsAsyncInvoker(ListResourceGroupsRequest listResourceGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceGroupsRequest);
            return new AsyncInvoker<ListResourceGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceGroupsResponse>);
        }
        
        /// <summary>
        /// 从资源组中移除资源
        ///
        /// 从资源组中移除一个资源，需要当前用户有resourcecenter:group:removeResource权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemoveResourceFromGroupResponse> RemoveResourceFromGroupAsync(RemoveResourceFromGroupRequest removeResourceFromGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeResourceFromGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(removeResourceFromGroupRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups/{group_id}/resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeResourceFromGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<RemoveResourceFromGroupResponse>(response);
        }

        public AsyncInvoker<RemoveResourceFromGroupResponse> RemoveResourceFromGroupAsyncInvoker(RemoveResourceFromGroupRequest removeResourceFromGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeResourceFromGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(removeResourceFromGroupRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups/{group_id}/resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeResourceFromGroupRequest);
            return new AsyncInvoker<RemoveResourceFromGroupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<RemoveResourceFromGroupResponse>);
        }
        
        /// <summary>
        /// 查询一个资源分组
        ///
        /// 查询一个资源分组，需要当前用户有resourcecenter:group:get权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceGroupResponse> ShowResourceGroupAsync(ShowResourceGroupRequest showResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceGroupResponse>(response);
        }

        public AsyncInvoker<ShowResourceGroupResponse> ShowResourceGroupAsyncInvoker(ShowResourceGroupRequest showResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceGroupRequest);
            return new AsyncInvoker<ShowResourceGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceGroupResponse>);
        }
        
        /// <summary>
        /// 修改一个资源分组
        ///
        /// 修改一个资源分组，需要当前用户有resourcecenter:group:update权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateResourceGroupResponse> UpdateResourceGroupAsync(UpdateResourceGroupRequest updateResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceGroupRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateResourceGroupResponse>(response);
        }

        public AsyncInvoker<UpdateResourceGroupResponse> UpdateResourceGroupAsyncInvoker(UpdateResourceGroupRequest updateResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceGroupRequest);
            return new AsyncInvoker<UpdateResourceGroupResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateResourceGroupResponse>);
        }
        
        /// <summary>
        /// 创建高级查询
        ///
        /// Create Resource Query Language
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateStoredQueryResponse> CreateStoredQueryAsync(CreateStoredQueryRequest createStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/stored-queries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createStoredQueryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateStoredQueryResponse>(response);
        }

        public AsyncInvoker<CreateStoredQueryResponse> CreateStoredQueryAsyncInvoker(CreateStoredQueryRequest createStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/stored-queries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createStoredQueryRequest);
            return new AsyncInvoker<CreateStoredQueryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateStoredQueryResponse>);
        }
        
        /// <summary>
        /// 删除高级查询
        ///
        /// Select resources by SQL
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteStoredQueryResponse> DeleteStoredQueryAsync(DeleteStoredQueryRequest deleteStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStoredQueryRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteStoredQueryResponse>(response);
        }

        public AsyncInvoker<DeleteStoredQueryResponse> DeleteStoredQueryAsyncInvoker(DeleteStoredQueryRequest deleteStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStoredQueryRequest);
            return new AsyncInvoker<DeleteStoredQueryResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteStoredQueryResponse>);
        }
        
        /// <summary>
        /// 列举高级查询Schema
        ///
        /// List Schemas
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSchemasResponse> ListSchemasAsync(ListSchemasRequest listSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/schemas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSchemasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSchemasResponse>(response);
        }

        public AsyncInvoker<ListSchemasResponse> ListSchemasAsyncInvoker(ListSchemasRequest listSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/schemas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSchemasRequest);
            return new AsyncInvoker<ListSchemasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSchemasResponse>);
        }
        
        /// <summary>
        /// 列出高级查询
        ///
        /// List Resource Query Language
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStoredQueriesResponse> ListStoredQueriesAsync(ListStoredQueriesRequest listStoredQueriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/stored-queries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStoredQueriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStoredQueriesResponse>(response);
        }

        public AsyncInvoker<ListStoredQueriesResponse> ListStoredQueriesAsyncInvoker(ListStoredQueriesRequest listStoredQueriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/stored-queries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStoredQueriesRequest);
            return new AsyncInvoker<ListStoredQueriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStoredQueriesResponse>);
        }
        
        /// <summary>
        /// 运行高级查询
        ///
        /// Run Resource Query Language
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunQueryResponse> RunQueryAsync(RunQueryRequest runQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/run-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RunQueryResponse>(response);
        }

        public AsyncInvoker<RunQueryResponse> RunQueryAsyncInvoker(RunQueryRequest runQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/run-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryRequest);
            return new AsyncInvoker<RunQueryResponse>(this, "POST", request, JsonUtils.DeSerialize<RunQueryResponse>);
        }
        
        /// <summary>
        /// 查询单个高级查询
        ///
        /// Show Resource Query Language
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStoredQueryResponse> ShowStoredQueryAsync(ShowStoredQueryRequest showStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStoredQueryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStoredQueryResponse>(response);
        }

        public AsyncInvoker<ShowStoredQueryResponse> ShowStoredQueryAsyncInvoker(ShowStoredQueryRequest showStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStoredQueryRequest);
            return new AsyncInvoker<ShowStoredQueryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStoredQueryResponse>);
        }
        
        /// <summary>
        /// 更新单个高级查询
        ///
        /// Update Resource Query Language
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateStoredQueryResponse> UpdateStoredQueryAsync(UpdateStoredQueryRequest updateStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStoredQueryRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateStoredQueryResponse>(response);
        }

        public AsyncInvoker<UpdateStoredQueryResponse> UpdateStoredQueryAsyncInvoker(UpdateStoredQueryRequest updateStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStoredQueryRequest);
            return new AsyncInvoker<UpdateStoredQueryResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateStoredQueryResponse>);
        }
        
        /// <summary>
        /// 列举资源关系
        ///
        /// 指定资源ID，查询该资源与其他资源的关联关系，需要当前用户有resourcecenter::listResourceRelation权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceRelationsResponse> ShowResourceRelationsAsync(ShowResourceRelationsRequest showResourceRelationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/resource-relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceRelationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceRelationsResponse>(response);
        }

        public AsyncInvoker<ShowResourceRelationsResponse> ShowResourceRelationsAsyncInvoker(ShowResourceRelationsRequest showResourceRelationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/resource-relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceRelationsRequest);
            return new AsyncInvoker<ShowResourceRelationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceRelationsResponse>);
        }
        
        /// <summary>
        /// 列举资源概要
        ///
        /// 查询当前帐号的资源概览，需要当前用户有rc::listResourceSummary权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CollectAllResourcesSummaryResponse> CollectAllResourcesSummaryAsync(CollectAllResourcesSummaryRequest collectAllResourcesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-resources/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectAllResourcesSummaryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var collectAllResourcesSummaryResponse = JsonUtils.DeSerializeNull<CollectAllResourcesSummaryResponse>(response);
            collectAllResourcesSummaryResponse.Body = JsonUtils.DeSerializeList<ResourceSummaryResponseItem>(response);
            return collectAllResourcesSummaryResponse;
        }

        public AsyncInvoker<CollectAllResourcesSummaryResponse> CollectAllResourcesSummaryAsyncInvoker(CollectAllResourcesSummaryRequest collectAllResourcesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-resources/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectAllResourcesSummaryRequest);
            return new AsyncInvoker<CollectAllResourcesSummaryResponse>(this, "GET", request, response =>
            {
                var collectAllResourcesSummaryResponse = JsonUtils.DeSerializeNull<CollectAllResourcesSummaryResponse>(response);
                collectAllResourcesSummaryResponse.Body = JsonUtils.DeSerializeList<ResourceSummaryResponseItem>(response);
                return collectAllResourcesSummaryResponse;
            });
        }
        
        /// <summary>
        /// 查询资源数量
        ///
        /// 查询资源数量，需要当前用户有resourcecenter::getResourceCount权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountAllResourcesResponse> CountAllResourcesAsync(CountAllResourcesRequest countAllResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-resources/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countAllResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CountAllResourcesResponse>(response);
        }

        public AsyncInvoker<CountAllResourcesResponse> CountAllResourcesAsyncInvoker(CountAllResourcesRequest countAllResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-resources/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countAllResourcesRequest);
            return new AsyncInvoker<CountAllResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<CountAllResourcesResponse>);
        }
        
        /// <summary>
        /// 列举所有已对接的云服务
        ///
        /// 查询所有已对接RC的云服务、资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAllProvidersResponse> ListAllProvidersAsync(ListAllProvidersRequest listAllProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllProvidersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAllProvidersResponse>(response);
        }

        public AsyncInvoker<ListAllProvidersResponse> ListAllProvidersAsyncInvoker(ListAllProvidersRequest listAllProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllProvidersRequest);
            return new AsyncInvoker<ListAllProvidersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllProvidersResponse>);
        }
        
        /// <summary>
        /// 列举所有资源
        ///
        /// 返回当前用户下所有资源，需要当前用户有resourcecenter::listResource权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAllResourcesResponse> ListAllResourcesAsync(ListAllResourcesRequest listAllResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAllResourcesResponse>(response);
        }

        public AsyncInvoker<ListAllResourcesResponse> ListAllResourcesAsyncInvoker(ListAllResourcesRequest listAllResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllResourcesRequest);
            return new AsyncInvoker<ListAllResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllResourcesResponse>);
        }
        
        /// <summary>
        /// 列举资源标签
        ///
        /// 查询当前帐号下所有资源的标签，需要当前用户有resourcecenter::listResourceTag权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAllTagsResponse> ListAllTagsAsync(ListAllTagsRequest listAllTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-resources/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAllTagsResponse>(response);
        }

        public AsyncInvoker<ListAllTagsResponse> ListAllTagsAsyncInvoker(ListAllTagsRequest listAllTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-resources/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllTagsRequest);
            return new AsyncInvoker<ListAllTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllTagsResponse>);
        }
        
        /// <summary>
        /// 列举指定类型的资源
        ///
        /// 返回当前租户下特定资源类型的资源，需要当前用户有resourcecenter::listResourceByType权限。比如查询云服务器，对应的RC资源类型是ecs.cloudservers，其中provider为ecs，type为cloudservers。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest listResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourcesRequest.Provider, out var valueOfProvider)) urlParam.Add("provider", valueOfProvider);
            if (StringUtils.TryConvertToNonEmptyString(listResourcesRequest.Type, out var valueOfType)) urlParam.Add("type", valueOfType);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/provider/{provider}/type/{type}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListResourcesResponse>(response);
        }

        public AsyncInvoker<ListResourcesResponse> ListResourcesAsyncInvoker(ListResourcesRequest listResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourcesRequest.Provider, out var valueOfProvider)) urlParam.Add("provider", valueOfProvider);
            if (StringUtils.TryConvertToNonEmptyString(listResourcesRequest.Type, out var valueOfType)) urlParam.Add("type", valueOfType);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/provider/{provider}/type/{type}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesRequest);
            return new AsyncInvoker<ListResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourcesResponse>);
        }
        
        /// <summary>
        /// 查询指定类型的单个资源
        ///
        /// 指定资源ID，返回该资源的详细信息，需要当前用户有resourcecenter::getResourceByType权限。比如查询云服务器，对应的RC资源类型是ecs.cloudservers，其中provider为ecs，type为cloudservers。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceByIdResponse> ShowResourceByIdAsync(ShowResourceByIdRequest showResourceByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceByIdRequest.Provider, out var valueOfProvider)) urlParam.Add("provider", valueOfProvider);
            if (StringUtils.TryConvertToNonEmptyString(showResourceByIdRequest.Type, out var valueOfType)) urlParam.Add("type", valueOfType);
            if (StringUtils.TryConvertToNonEmptyString(showResourceByIdRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/provider/{provider}/type/{type}/resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceByIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceByIdResponse>(response);
        }

        public AsyncInvoker<ShowResourceByIdResponse> ShowResourceByIdAsyncInvoker(ShowResourceByIdRequest showResourceByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceByIdRequest.Provider, out var valueOfProvider)) urlParam.Add("provider", valueOfProvider);
            if (StringUtils.TryConvertToNonEmptyString(showResourceByIdRequest.Type, out var valueOfType)) urlParam.Add("type", valueOfType);
            if (StringUtils.TryConvertToNonEmptyString(showResourceByIdRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/provider/{provider}/type/{type}/resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceByIdRequest);
            return new AsyncInvoker<ShowResourceByIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceByIdResponse>);
        }
        
        /// <summary>
        /// 查询单个资源
        ///
        /// 查询当前帐号下的单个资源，需要当前用户有resourcecenter::getResource权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceDetailResponse> ShowResourceDetailAsync(ShowResourceDetailRequest showResourceDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceDetailRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceDetailResponse>(response);
        }

        public AsyncInvoker<ShowResourceDetailResponse> ShowResourceDetailAsyncInvoker(ShowResourceDetailRequest showResourceDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceDetailRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceDetailRequest);
            return new AsyncInvoker<ShowResourceDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceDetailResponse>);
        }
        
    }
}