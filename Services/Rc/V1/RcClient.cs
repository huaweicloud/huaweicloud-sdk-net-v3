using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Rc.V1.Model;

namespace HuaweiCloud.SDK.Rc.V1
{
    public partial class RcClient : Client
    {
        public static ClientBuilder<RcClient> NewBuilder()
        {
            return new ClientBuilder<RcClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 将资源添加到资源组
        ///
        /// 将一个或多个资源添加到资源组，需要当前用户有resourcecenter:group:addResource权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddResourcesToGroupResponse AddResourcesToGroup(AddResourcesToGroupRequest addResourcesToGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addResourcesToGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups/{group_id}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addResourcesToGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<AddResourcesToGroupResponse>(response);
        }

        public SyncInvoker<AddResourcesToGroupResponse> AddResourcesToGroupInvoker(AddResourcesToGroupRequest addResourcesToGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addResourcesToGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups/{group_id}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addResourcesToGroupRequest);
            return new SyncInvoker<AddResourcesToGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<AddResourcesToGroupResponse>);
        }
        
        /// <summary>
        /// 创建资源分组
        ///
        /// 创建一个资源分组，需要当前用户有resourcecenter:group:create权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateResourceGroupResponse CreateResourceGroup(CreateResourceGroupRequest createResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateResourceGroupResponse>(response);
        }

        public SyncInvoker<CreateResourceGroupResponse> CreateResourceGroupInvoker(CreateResourceGroupRequest createResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceGroupRequest);
            return new SyncInvoker<CreateResourceGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateResourceGroupResponse>);
        }
        
        /// <summary>
        /// 删除一个资源分组
        ///
        /// 删除一个资源分组，需要当前用户有resourcecenter:group:delete权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteResourceGroupResponse DeleteResourceGroup(DeleteResourceGroupRequest deleteResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteResourceGroupResponse>(response);
        }

        public SyncInvoker<DeleteResourceGroupResponse> DeleteResourceGroupInvoker(DeleteResourceGroupRequest deleteResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceGroupRequest);
            return new SyncInvoker<DeleteResourceGroupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteResourceGroupResponse>);
        }
        
        /// <summary>
        /// 查询资源分组列表
        ///
        /// 查询资源分组列表，需要当前用户有resourcecenter:group:list权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceGroupsResponse ListResourceGroups(ListResourceGroupsRequest listResourceGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListResourceGroupsResponse>(response);
        }

        public SyncInvoker<ListResourceGroupsResponse> ListResourceGroupsInvoker(ListResourceGroupsRequest listResourceGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceGroupsRequest);
            return new SyncInvoker<ListResourceGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceGroupsResponse>);
        }
        
        /// <summary>
        /// 从资源组中移除资源
        ///
        /// 从资源组中移除一个资源，需要当前用户有resourcecenter:group:removeResource权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RemoveResourceFromGroupResponse RemoveResourceFromGroup(RemoveResourceFromGroupRequest removeResourceFromGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeResourceFromGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(removeResourceFromGroupRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups/{group_id}/resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeResourceFromGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<RemoveResourceFromGroupResponse>(response);
        }

        public SyncInvoker<RemoveResourceFromGroupResponse> RemoveResourceFromGroupInvoker(RemoveResourceFromGroupRequest removeResourceFromGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeResourceFromGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(removeResourceFromGroupRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups/{group_id}/resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeResourceFromGroupRequest);
            return new SyncInvoker<RemoveResourceFromGroupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<RemoveResourceFromGroupResponse>);
        }
        
        /// <summary>
        /// 查询一个资源分组
        ///
        /// 查询一个资源分组，需要当前用户有resourcecenter:group:get权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceGroupResponse ShowResourceGroup(ShowResourceGroupRequest showResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceGroupResponse>(response);
        }

        public SyncInvoker<ShowResourceGroupResponse> ShowResourceGroupInvoker(ShowResourceGroupRequest showResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceGroupRequest);
            return new SyncInvoker<ShowResourceGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceGroupResponse>);
        }
        
        /// <summary>
        /// 修改一个资源分组
        ///
        /// 修改一个资源分组，需要当前用户有resourcecenter:group:update权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateResourceGroupResponse UpdateResourceGroup(UpdateResourceGroupRequest updateResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceGroupRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateResourceGroupResponse>(response);
        }

        public SyncInvoker<UpdateResourceGroupResponse> UpdateResourceGroupInvoker(UpdateResourceGroupRequest updateResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceGroupRequest);
            return new SyncInvoker<UpdateResourceGroupResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateResourceGroupResponse>);
        }
        
        /// <summary>
        /// 创建高级查询
        ///
        /// Create Resource Query Language
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateStoredQueryResponse CreateStoredQuery(CreateStoredQueryRequest createStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/stored-queries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createStoredQueryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateStoredQueryResponse>(response);
        }

        public SyncInvoker<CreateStoredQueryResponse> CreateStoredQueryInvoker(CreateStoredQueryRequest createStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/stored-queries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createStoredQueryRequest);
            return new SyncInvoker<CreateStoredQueryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateStoredQueryResponse>);
        }
        
        /// <summary>
        /// 删除高级查询
        ///
        /// Select resources by SQL
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteStoredQueryResponse DeleteStoredQuery(DeleteStoredQueryRequest deleteStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStoredQueryRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteStoredQueryResponse>(response);
        }

        public SyncInvoker<DeleteStoredQueryResponse> DeleteStoredQueryInvoker(DeleteStoredQueryRequest deleteStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStoredQueryRequest);
            return new SyncInvoker<DeleteStoredQueryResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteStoredQueryResponse>);
        }
        
        /// <summary>
        /// 列举高级查询Schema
        ///
        /// List Schemas
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSchemasResponse ListSchemas(ListSchemasRequest listSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/schemas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSchemasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSchemasResponse>(response);
        }

        public SyncInvoker<ListSchemasResponse> ListSchemasInvoker(ListSchemasRequest listSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/schemas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSchemasRequest);
            return new SyncInvoker<ListSchemasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSchemasResponse>);
        }
        
        /// <summary>
        /// 列出高级查询
        ///
        /// List Resource Query Language
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStoredQueriesResponse ListStoredQueries(ListStoredQueriesRequest listStoredQueriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/stored-queries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStoredQueriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListStoredQueriesResponse>(response);
        }

        public SyncInvoker<ListStoredQueriesResponse> ListStoredQueriesInvoker(ListStoredQueriesRequest listStoredQueriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/stored-queries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStoredQueriesRequest);
            return new SyncInvoker<ListStoredQueriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStoredQueriesResponse>);
        }
        
        /// <summary>
        /// 运行高级查询
        ///
        /// Run Resource Query Language
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunQueryResponse RunQuery(RunQueryRequest runQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/run-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunQueryResponse>(response);
        }

        public SyncInvoker<RunQueryResponse> RunQueryInvoker(RunQueryRequest runQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/run-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryRequest);
            return new SyncInvoker<RunQueryResponse>(this, "POST", request, JsonUtils.DeSerialize<RunQueryResponse>);
        }
        
        /// <summary>
        /// 查询单个高级查询
        ///
        /// Show Resource Query Language
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStoredQueryResponse ShowStoredQuery(ShowStoredQueryRequest showStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStoredQueryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStoredQueryResponse>(response);
        }

        public SyncInvoker<ShowStoredQueryResponse> ShowStoredQueryInvoker(ShowStoredQueryRequest showStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStoredQueryRequest);
            return new SyncInvoker<ShowStoredQueryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStoredQueryResponse>);
        }
        
        /// <summary>
        /// 更新单个高级查询
        ///
        /// Update Resource Query Language
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateStoredQueryResponse UpdateStoredQuery(UpdateStoredQueryRequest updateStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStoredQueryRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateStoredQueryResponse>(response);
        }

        public SyncInvoker<UpdateStoredQueryResponse> UpdateStoredQueryInvoker(UpdateStoredQueryRequest updateStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStoredQueryRequest);
            return new SyncInvoker<UpdateStoredQueryResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateStoredQueryResponse>);
        }
        
        /// <summary>
        /// 列举资源关系
        ///
        /// 指定资源ID，查询该资源与其他资源的关联关系，需要当前用户有resourcecenter::listResourceRelation权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceRelationsResponse ShowResourceRelations(ShowResourceRelationsRequest showResourceRelationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/resource-relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceRelationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceRelationsResponse>(response);
        }

        public SyncInvoker<ShowResourceRelationsResponse> ShowResourceRelationsInvoker(ShowResourceRelationsRequest showResourceRelationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/resource-relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceRelationsRequest);
            return new SyncInvoker<ShowResourceRelationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceRelationsResponse>);
        }
        
        /// <summary>
        /// 列举资源概要
        ///
        /// 查询当前帐号的资源概览，需要当前用户有rc::listResourceSummary权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CollectAllResourcesSummaryResponse CollectAllResourcesSummary(CollectAllResourcesSummaryRequest collectAllResourcesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-resources/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectAllResourcesSummaryRequest);
            var response = DoHttpRequestSync("GET", request);
            var collectAllResourcesSummaryResponse = JsonUtils.DeSerializeNull<CollectAllResourcesSummaryResponse>(response);
            collectAllResourcesSummaryResponse.Body = JsonUtils.DeSerializeList<ResourceSummaryResponseItem>(response);
            return collectAllResourcesSummaryResponse;
        }

        public SyncInvoker<CollectAllResourcesSummaryResponse> CollectAllResourcesSummaryInvoker(CollectAllResourcesSummaryRequest collectAllResourcesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-resources/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectAllResourcesSummaryRequest);
            return new SyncInvoker<CollectAllResourcesSummaryResponse>(this, "GET", request, response =>
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
        public CountAllResourcesResponse CountAllResources(CountAllResourcesRequest countAllResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-resources/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countAllResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CountAllResourcesResponse>(response);
        }

        public SyncInvoker<CountAllResourcesResponse> CountAllResourcesInvoker(CountAllResourcesRequest countAllResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-resources/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countAllResourcesRequest);
            return new SyncInvoker<CountAllResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<CountAllResourcesResponse>);
        }
        
        /// <summary>
        /// 列举所有已对接的云服务
        ///
        /// 查询所有已对接RC的云服务、资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllProvidersResponse ListAllProviders(ListAllProvidersRequest listAllProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllProvidersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAllProvidersResponse>(response);
        }

        public SyncInvoker<ListAllProvidersResponse> ListAllProvidersInvoker(ListAllProvidersRequest listAllProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllProvidersRequest);
            return new SyncInvoker<ListAllProvidersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllProvidersResponse>);
        }
        
        /// <summary>
        /// 列举所有资源
        ///
        /// 返回当前用户下所有资源，需要当前用户有resourcecenter::listResource权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllResourcesResponse ListAllResources(ListAllResourcesRequest listAllResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAllResourcesResponse>(response);
        }

        public SyncInvoker<ListAllResourcesResponse> ListAllResourcesInvoker(ListAllResourcesRequest listAllResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllResourcesRequest);
            return new SyncInvoker<ListAllResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllResourcesResponse>);
        }
        
        /// <summary>
        /// 列举资源标签
        ///
        /// 查询当前帐号下所有资源的标签，需要当前用户有resourcecenter::listResourceTag权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllTagsResponse ListAllTags(ListAllTagsRequest listAllTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-resources/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAllTagsResponse>(response);
        }

        public SyncInvoker<ListAllTagsResponse> ListAllTagsInvoker(ListAllTagsRequest listAllTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-resources/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllTagsRequest);
            return new SyncInvoker<ListAllTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllTagsResponse>);
        }
        
        /// <summary>
        /// 列举指定类型的资源
        ///
        /// 返回当前租户下特定资源类型的资源，需要当前用户有resourcecenter::listResourceByType权限。比如查询云服务器，对应的RC资源类型是ecs.cloudservers，其中provider为ecs，type为cloudservers。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourcesResponse ListResources(ListResourcesRequest listResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourcesRequest.Provider, out var valueOfProvider)) urlParam.Add("provider", valueOfProvider);
            if (StringUtils.TryConvertToNonEmptyString(listResourcesRequest.Type, out var valueOfType)) urlParam.Add("type", valueOfType);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/provider/{provider}/type/{type}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListResourcesResponse>(response);
        }

        public SyncInvoker<ListResourcesResponse> ListResourcesInvoker(ListResourcesRequest listResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourcesRequest.Provider, out var valueOfProvider)) urlParam.Add("provider", valueOfProvider);
            if (StringUtils.TryConvertToNonEmptyString(listResourcesRequest.Type, out var valueOfType)) urlParam.Add("type", valueOfType);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/provider/{provider}/type/{type}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesRequest);
            return new SyncInvoker<ListResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourcesResponse>);
        }
        
        /// <summary>
        /// 查询指定类型的单个资源
        ///
        /// 指定资源ID，返回该资源的详细信息，需要当前用户有resourcecenter::getResourceByType权限。比如查询云服务器，对应的RC资源类型是ecs.cloudservers，其中provider为ecs，type为cloudservers。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceByIdResponse ShowResourceById(ShowResourceByIdRequest showResourceByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceByIdRequest.Provider, out var valueOfProvider)) urlParam.Add("provider", valueOfProvider);
            if (StringUtils.TryConvertToNonEmptyString(showResourceByIdRequest.Type, out var valueOfType)) urlParam.Add("type", valueOfType);
            if (StringUtils.TryConvertToNonEmptyString(showResourceByIdRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/provider/{provider}/type/{type}/resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceByIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceByIdResponse>(response);
        }

        public SyncInvoker<ShowResourceByIdResponse> ShowResourceByIdInvoker(ShowResourceByIdRequest showResourceByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceByIdRequest.Provider, out var valueOfProvider)) urlParam.Add("provider", valueOfProvider);
            if (StringUtils.TryConvertToNonEmptyString(showResourceByIdRequest.Type, out var valueOfType)) urlParam.Add("type", valueOfType);
            if (StringUtils.TryConvertToNonEmptyString(showResourceByIdRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/provider/{provider}/type/{type}/resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceByIdRequest);
            return new SyncInvoker<ShowResourceByIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceByIdResponse>);
        }
        
        /// <summary>
        /// 查询单个资源
        ///
        /// 查询当前帐号下的单个资源，需要当前用户有resourcecenter::getResource权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceDetailResponse ShowResourceDetail(ShowResourceDetailRequest showResourceDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceDetailRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceDetailResponse>(response);
        }

        public SyncInvoker<ShowResourceDetailResponse> ShowResourceDetailInvoker(ShowResourceDetailRequest showResourceDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceDetailRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-center/all-resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceDetailRequest);
            return new SyncInvoker<ShowResourceDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceDetailResponse>);
        }
        
    }
}