using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Config.V1.Model;

namespace HuaweiCloud.SDK.Config.V1
{
    public partial class ConfigAsyncClient : Client
    {
        public static ClientBuilder<ConfigAsyncClient> NewBuilder()
        {
            return new ClientBuilder<ConfigAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 创建资源聚合器授权
        ///
        /// 给资源聚合器帐号授予从源帐号收集数据的权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAggregationAuthorizationResponse> CreateAggregationAuthorizationAsync(CreateAggregationAuthorizationRequest createAggregationAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregation-authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAggregationAuthorizationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<CreateAggregationAuthorizationResponse>(response);
        }

        public AsyncInvoker<CreateAggregationAuthorizationResponse> CreateAggregationAuthorizationAsyncInvoker(CreateAggregationAuthorizationRequest createAggregationAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregation-authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAggregationAuthorizationRequest);
            return new AsyncInvoker<CreateAggregationAuthorizationResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreateAggregationAuthorizationResponse>);
        }
        
        /// <summary>
        /// 创建资源聚合器
        ///
        /// 创建资源聚合器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateConfigurationAggregatorResponse> CreateConfigurationAggregatorAsync(CreateConfigurationAggregatorRequest createConfigurationAggregatorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfigurationAggregatorRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<CreateConfigurationAggregatorResponse>(response);
        }

        public AsyncInvoker<CreateConfigurationAggregatorResponse> CreateConfigurationAggregatorAsyncInvoker(CreateConfigurationAggregatorRequest createConfigurationAggregatorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfigurationAggregatorRequest);
            return new AsyncInvoker<CreateConfigurationAggregatorResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreateConfigurationAggregatorResponse>);
        }
        
        /// <summary>
        /// 删除资源聚合器授权
        ///
        /// 删除指定资源聚合器帐号的授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAggregationAuthorizationResponse> DeleteAggregationAuthorizationAsync(DeleteAggregationAuthorizationRequest deleteAggregationAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAggregationAuthorizationRequest.AuthorizedAccountId, out var valueOfAuthorizedAccountId)) urlParam.Add("authorized_account_id", valueOfAuthorizedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregation-authorization/{authorized_account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAggregationAuthorizationRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAggregationAuthorizationResponse>(response);
        }

        public AsyncInvoker<DeleteAggregationAuthorizationResponse> DeleteAggregationAuthorizationAsyncInvoker(DeleteAggregationAuthorizationRequest deleteAggregationAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAggregationAuthorizationRequest.AuthorizedAccountId, out var valueOfAuthorizedAccountId)) urlParam.Add("authorized_account_id", valueOfAuthorizedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregation-authorization/{authorized_account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAggregationAuthorizationRequest);
            return new AsyncInvoker<DeleteAggregationAuthorizationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAggregationAuthorizationResponse>);
        }
        
        /// <summary>
        /// 删除资源聚合器
        ///
        /// 删除资源聚合器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteConfigurationAggregatorResponse> DeleteConfigurationAggregatorAsync(DeleteConfigurationAggregatorRequest deleteConfigurationAggregatorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConfigurationAggregatorRequest.AggregatorId, out var valueOfAggregatorId)) urlParam.Add("aggregator_id", valueOfAggregatorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/{aggregator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigurationAggregatorRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteConfigurationAggregatorResponse>(response);
        }

        public AsyncInvoker<DeleteConfigurationAggregatorResponse> DeleteConfigurationAggregatorAsyncInvoker(DeleteConfigurationAggregatorRequest deleteConfigurationAggregatorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConfigurationAggregatorRequest.AggregatorId, out var valueOfAggregatorId)) urlParam.Add("aggregator_id", valueOfAggregatorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/{aggregator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigurationAggregatorRequest);
            return new AsyncInvoker<DeleteConfigurationAggregatorResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteConfigurationAggregatorResponse>);
        }
        
        /// <summary>
        /// 删除聚合器帐号中挂起的授权请求
        ///
        /// 删除聚合器帐号中挂起的授权请求。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePendingAggregationRequestResponse> DeletePendingAggregationRequestAsync(DeletePendingAggregationRequestRequest deletePendingAggregationRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePendingAggregationRequestRequest.RequesterAccountId, out var valueOfRequesterAccountId)) urlParam.Add("requester_account_id", valueOfRequesterAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/pending-aggregation-request/{requester_account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePendingAggregationRequestRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePendingAggregationRequestResponse>(response);
        }

        public AsyncInvoker<DeletePendingAggregationRequestResponse> DeletePendingAggregationRequestAsyncInvoker(DeletePendingAggregationRequestRequest deletePendingAggregationRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePendingAggregationRequestRequest.RequesterAccountId, out var valueOfRequesterAccountId)) urlParam.Add("requester_account_id", valueOfRequesterAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/pending-aggregation-request/{requester_account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePendingAggregationRequestRequest);
            return new AsyncInvoker<DeletePendingAggregationRequestResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePendingAggregationRequestResponse>);
        }
        
        /// <summary>
        /// 查询聚合合规规则列表
        ///
        /// 查询合规和不合规规则的列表，其中包含合规和不合规规则的资源数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAggregateComplianceByPolicyAssignmentResponse> ListAggregateComplianceByPolicyAssignmentAsync(ListAggregateComplianceByPolicyAssignmentRequest listAggregateComplianceByPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/policy-assignments/compliance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAggregateComplianceByPolicyAssignmentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAggregateComplianceByPolicyAssignmentResponse>(response);
        }

        public AsyncInvoker<ListAggregateComplianceByPolicyAssignmentResponse> ListAggregateComplianceByPolicyAssignmentAsyncInvoker(ListAggregateComplianceByPolicyAssignmentRequest listAggregateComplianceByPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/policy-assignments/compliance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAggregateComplianceByPolicyAssignmentRequest);
            return new AsyncInvoker<ListAggregateComplianceByPolicyAssignmentResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAggregateComplianceByPolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 查询聚合器中资源的列表
        ///
        /// 查询资源聚合器中特定资源的列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAggregateDiscoveredResourcesResponse> ListAggregateDiscoveredResourcesAsync(ListAggregateDiscoveredResourcesRequest listAggregateDiscoveredResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/aggregate-discovered-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAggregateDiscoveredResourcesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAggregateDiscoveredResourcesResponse>(response);
        }

        public AsyncInvoker<ListAggregateDiscoveredResourcesResponse> ListAggregateDiscoveredResourcesAsyncInvoker(ListAggregateDiscoveredResourcesRequest listAggregateDiscoveredResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/aggregate-discovered-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAggregateDiscoveredResourcesRequest);
            return new AsyncInvoker<ListAggregateDiscoveredResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAggregateDiscoveredResourcesResponse>);
        }
        
        /// <summary>
        /// 查询资源聚合器授权列表
        ///
        /// 查询授权过的资源聚合器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAggregationAuthorizationsResponse> ListAggregationAuthorizationsAsync(ListAggregationAuthorizationsRequest listAggregationAuthorizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregation-authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAggregationAuthorizationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAggregationAuthorizationsResponse>(response);
        }

        public AsyncInvoker<ListAggregationAuthorizationsResponse> ListAggregationAuthorizationsAsyncInvoker(ListAggregationAuthorizationsRequest listAggregationAuthorizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregation-authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAggregationAuthorizationsRequest);
            return new AsyncInvoker<ListAggregationAuthorizationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAggregationAuthorizationsResponse>);
        }
        
        /// <summary>
        /// 查询资源聚合器列表
        ///
        /// 查询资源聚合器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConfigurationAggregatorsResponse> ListConfigurationAggregatorsAsync(ListConfigurationAggregatorsRequest listConfigurationAggregatorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationAggregatorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListConfigurationAggregatorsResponse>(response);
        }

        public AsyncInvoker<ListConfigurationAggregatorsResponse> ListConfigurationAggregatorsAsyncInvoker(ListConfigurationAggregatorsRequest listConfigurationAggregatorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationAggregatorsRequest);
            return new AsyncInvoker<ListConfigurationAggregatorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigurationAggregatorsResponse>);
        }
        
        /// <summary>
        /// 查询所有挂起的聚合请求列表
        ///
        /// 查询所有挂起的聚合请求列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPendingAggregationRequestsResponse> ListPendingAggregationRequestsAsync(ListPendingAggregationRequestsRequest listPendingAggregationRequestsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/pending-aggregation-request", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPendingAggregationRequestsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPendingAggregationRequestsResponse>(response);
        }

        public AsyncInvoker<ListPendingAggregationRequestsResponse> ListPendingAggregationRequestsAsyncInvoker(ListPendingAggregationRequestsRequest listPendingAggregationRequestsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/pending-aggregation-request", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPendingAggregationRequestsRequest);
            return new AsyncInvoker<ListPendingAggregationRequestsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPendingAggregationRequestsResponse>);
        }
        
        /// <summary>
        /// 对指定聚合器执行高级查询
        ///
        /// 对指定聚合器执行高级查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunAggregateResourceQueryResponse> RunAggregateResourceQueryAsync(RunAggregateResourceQueryRequest runAggregateResourceQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runAggregateResourceQueryRequest.AggregatorId, out var valueOfAggregatorId)) urlParam.Add("aggregator_id", valueOfAggregatorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/{aggregator_id}/run-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runAggregateResourceQueryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RunAggregateResourceQueryResponse>(response);
        }

        public AsyncInvoker<RunAggregateResourceQueryResponse> RunAggregateResourceQueryAsyncInvoker(RunAggregateResourceQueryRequest runAggregateResourceQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runAggregateResourceQueryRequest.AggregatorId, out var valueOfAggregatorId)) urlParam.Add("aggregator_id", valueOfAggregatorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/{aggregator_id}/run-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runAggregateResourceQueryRequest);
            return new AsyncInvoker<RunAggregateResourceQueryResponse>(this, "POST", request, JsonUtils.DeSerialize<RunAggregateResourceQueryResponse>);
        }
        
        /// <summary>
        /// 查询指定聚合合规规则的评估结果详情
        ///
        /// 返回指定聚合合规规则的评估结果详情。包含评估了哪些资源，以及每个资源是否符合规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAggregateComplianceDetailsByPolicyAssignmentResponse> ShowAggregateComplianceDetailsByPolicyAssignmentAsync(ShowAggregateComplianceDetailsByPolicyAssignmentRequest showAggregateComplianceDetailsByPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/policy-states/compliance-details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAggregateComplianceDetailsByPolicyAssignmentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowAggregateComplianceDetailsByPolicyAssignmentResponse>(response);
        }

        public AsyncInvoker<ShowAggregateComplianceDetailsByPolicyAssignmentResponse> ShowAggregateComplianceDetailsByPolicyAssignmentAsyncInvoker(ShowAggregateComplianceDetailsByPolicyAssignmentRequest showAggregateComplianceDetailsByPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/policy-states/compliance-details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAggregateComplianceDetailsByPolicyAssignmentRequest);
            return new AsyncInvoker<ShowAggregateComplianceDetailsByPolicyAssignmentResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowAggregateComplianceDetailsByPolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 查询聚合器中帐号资源的计数
        ///
        /// 查询聚合器中帐号资源的计数，支持通过过滤器和GroupByKey来统计资源数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAggregateDiscoveredResourceCountsResponse> ShowAggregateDiscoveredResourceCountsAsync(ShowAggregateDiscoveredResourceCountsRequest showAggregateDiscoveredResourceCountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/aggregate-discovered-resource-counts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAggregateDiscoveredResourceCountsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowAggregateDiscoveredResourceCountsResponse>(response);
        }

        public AsyncInvoker<ShowAggregateDiscoveredResourceCountsResponse> ShowAggregateDiscoveredResourceCountsAsyncInvoker(ShowAggregateDiscoveredResourceCountsRequest showAggregateDiscoveredResourceCountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/aggregate-discovered-resource-counts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAggregateDiscoveredResourceCountsRequest);
            return new AsyncInvoker<ShowAggregateDiscoveredResourceCountsResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowAggregateDiscoveredResourceCountsResponse>);
        }
        
        /// <summary>
        /// 查询指定聚合合规规则详情
        ///
        /// 返回指定聚合合规规则详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAggregatePolicyAssignmentDetailResponse> ShowAggregatePolicyAssignmentDetailAsync(ShowAggregatePolicyAssignmentDetailRequest showAggregatePolicyAssignmentDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/policy-assignment/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAggregatePolicyAssignmentDetailRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowAggregatePolicyAssignmentDetailResponse>(response);
        }

        public AsyncInvoker<ShowAggregatePolicyAssignmentDetailResponse> ShowAggregatePolicyAssignmentDetailAsyncInvoker(ShowAggregatePolicyAssignmentDetailRequest showAggregatePolicyAssignmentDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/policy-assignment/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAggregatePolicyAssignmentDetailRequest);
            return new AsyncInvoker<ShowAggregatePolicyAssignmentDetailResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowAggregatePolicyAssignmentDetailResponse>);
        }
        
        /// <summary>
        /// 查询聚合器中一个或多个帐户的合规概况
        ///
        /// 查询聚合器中一个或多个帐户的合规和不合规规则数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAggregatePolicyStateComplianceSummaryResponse> ShowAggregatePolicyStateComplianceSummaryAsync(ShowAggregatePolicyStateComplianceSummaryRequest showAggregatePolicyStateComplianceSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/policy-states/compliance-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAggregatePolicyStateComplianceSummaryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowAggregatePolicyStateComplianceSummaryResponse>(response);
        }

        public AsyncInvoker<ShowAggregatePolicyStateComplianceSummaryResponse> ShowAggregatePolicyStateComplianceSummaryAsyncInvoker(ShowAggregatePolicyStateComplianceSummaryRequest showAggregatePolicyStateComplianceSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/policy-states/compliance-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAggregatePolicyStateComplianceSummaryRequest);
            return new AsyncInvoker<ShowAggregatePolicyStateComplianceSummaryResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowAggregatePolicyStateComplianceSummaryResponse>);
        }
        
        /// <summary>
        /// 查询源帐号中资源的详情
        ///
        /// 查询源帐号中特定资源的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAggregateResourceConfigResponse> ShowAggregateResourceConfigAsync(ShowAggregateResourceConfigRequest showAggregateResourceConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-resource-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAggregateResourceConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowAggregateResourceConfigResponse>(response);
        }

        public AsyncInvoker<ShowAggregateResourceConfigResponse> ShowAggregateResourceConfigAsyncInvoker(ShowAggregateResourceConfigRequest showAggregateResourceConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-resource-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAggregateResourceConfigRequest);
            return new AsyncInvoker<ShowAggregateResourceConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowAggregateResourceConfigResponse>);
        }
        
        /// <summary>
        /// 查询指定资源聚合器
        ///
        /// 查询指定资源聚合器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowConfigurationAggregatorResponse> ShowConfigurationAggregatorAsync(ShowConfigurationAggregatorRequest showConfigurationAggregatorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigurationAggregatorRequest.AggregatorId, out var valueOfAggregatorId)) urlParam.Add("aggregator_id", valueOfAggregatorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/{aggregator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationAggregatorRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigurationAggregatorResponse>(response);
        }

        public AsyncInvoker<ShowConfigurationAggregatorResponse> ShowConfigurationAggregatorAsyncInvoker(ShowConfigurationAggregatorRequest showConfigurationAggregatorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigurationAggregatorRequest.AggregatorId, out var valueOfAggregatorId)) urlParam.Add("aggregator_id", valueOfAggregatorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/{aggregator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationAggregatorRequest);
            return new AsyncInvoker<ShowConfigurationAggregatorResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigurationAggregatorResponse>);
        }
        
        /// <summary>
        /// 查询指定资源聚合器聚合帐号的状态信息
        ///
        /// 查询指定资源聚合器聚合帐号的状态信息，状态包括验证源帐号和聚合器帐号之间授权的信息。如果失败，状态包含相关的错误码或消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowConfigurationAggregatorSourcesStatusResponse> ShowConfigurationAggregatorSourcesStatusAsync(ShowConfigurationAggregatorSourcesStatusRequest showConfigurationAggregatorSourcesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigurationAggregatorSourcesStatusRequest.AggregatorId, out var valueOfAggregatorId)) urlParam.Add("aggregator_id", valueOfAggregatorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/{aggregator_id}/aggregator-sources-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationAggregatorSourcesStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigurationAggregatorSourcesStatusResponse>(response);
        }

        public AsyncInvoker<ShowConfigurationAggregatorSourcesStatusResponse> ShowConfigurationAggregatorSourcesStatusAsyncInvoker(ShowConfigurationAggregatorSourcesStatusRequest showConfigurationAggregatorSourcesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigurationAggregatorSourcesStatusRequest.AggregatorId, out var valueOfAggregatorId)) urlParam.Add("aggregator_id", valueOfAggregatorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/{aggregator_id}/aggregator-sources-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationAggregatorSourcesStatusRequest);
            return new AsyncInvoker<ShowConfigurationAggregatorSourcesStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigurationAggregatorSourcesStatusResponse>);
        }
        
        /// <summary>
        /// 更新资源聚合器
        ///
        /// 更新资源聚合器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateConfigurationAggregatorResponse> UpdateConfigurationAggregatorAsync(UpdateConfigurationAggregatorRequest updateConfigurationAggregatorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateConfigurationAggregatorRequest.AggregatorId, out var valueOfAggregatorId)) urlParam.Add("aggregator_id", valueOfAggregatorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/{aggregator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigurationAggregatorRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateConfigurationAggregatorResponse>(response);
        }

        public AsyncInvoker<UpdateConfigurationAggregatorResponse> UpdateConfigurationAggregatorAsyncInvoker(UpdateConfigurationAggregatorRequest updateConfigurationAggregatorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateConfigurationAggregatorRequest.AggregatorId, out var valueOfAggregatorId)) urlParam.Add("aggregator_id", valueOfAggregatorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/{aggregator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigurationAggregatorRequest);
            return new AsyncInvoker<UpdateConfigurationAggregatorResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateConfigurationAggregatorResponse>);
        }
        
        /// <summary>
        /// 列举合规规则包的结果概览
        ///
        /// 列举用户的合规规则包的合规结果概览。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CollectConformancePackComplianceSummaryResponse> CollectConformancePackComplianceSummaryAsync(CollectConformancePackComplianceSummaryRequest collectConformancePackComplianceSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/compliance/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectConformancePackComplianceSummaryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CollectConformancePackComplianceSummaryResponse>(response);
        }

        public AsyncInvoker<CollectConformancePackComplianceSummaryResponse> CollectConformancePackComplianceSummaryAsyncInvoker(CollectConformancePackComplianceSummaryRequest collectConformancePackComplianceSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/compliance/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectConformancePackComplianceSummaryRequest);
            return new AsyncInvoker<CollectConformancePackComplianceSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<CollectConformancePackComplianceSummaryResponse>);
        }
        
        /// <summary>
        /// 创建合规规则包
        ///
        /// 创建新的合规规则包。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateConformancePackResponse> CreateConformancePackAsync(CreateConformancePackRequest createConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConformancePackRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateConformancePackResponse>(response);
        }

        public AsyncInvoker<CreateConformancePackResponse> CreateConformancePackAsyncInvoker(CreateConformancePackRequest createConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConformancePackRequest);
            return new AsyncInvoker<CreateConformancePackResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateConformancePackResponse>);
        }
        
        /// <summary>
        /// 创建组织合规规则包
        ///
        /// 创建新的组织合规规则包。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateOrganizationConformancePackResponse> CreateOrganizationConformancePackAsync(CreateOrganizationConformancePackRequest createOrganizationConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createOrganizationConformancePackRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrganizationConformancePackRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateOrganizationConformancePackResponse>(response);
        }

        public AsyncInvoker<CreateOrganizationConformancePackResponse> CreateOrganizationConformancePackAsyncInvoker(CreateOrganizationConformancePackRequest createOrganizationConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createOrganizationConformancePackRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrganizationConformancePackRequest);
            return new AsyncInvoker<CreateOrganizationConformancePackResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOrganizationConformancePackResponse>);
        }
        
        /// <summary>
        /// 删除合规规则包
        ///
        /// 删除用户的合规规则包。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteConformancePackResponse> DeleteConformancePackAsync(DeleteConformancePackRequest deleteConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConformancePackRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteConformancePackResponse>(response);
        }

        public AsyncInvoker<DeleteConformancePackResponse> DeleteConformancePackAsyncInvoker(DeleteConformancePackRequest deleteConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConformancePackRequest);
            return new AsyncInvoker<DeleteConformancePackResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteConformancePackResponse>);
        }
        
        /// <summary>
        /// 删除组织合规规则包
        ///
        /// 删除用户的组织合规规则包。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteOrganizationConformancePackResponse> DeleteOrganizationConformancePackAsync(DeleteOrganizationConformancePackRequest deleteOrganizationConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOrganizationConformancePackRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(deleteOrganizationConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOrganizationConformancePackRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteOrganizationConformancePackResponse>(response);
        }

        public AsyncInvoker<DeleteOrganizationConformancePackResponse> DeleteOrganizationConformancePackAsyncInvoker(DeleteOrganizationConformancePackRequest deleteOrganizationConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOrganizationConformancePackRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(deleteOrganizationConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOrganizationConformancePackRequest);
            return new AsyncInvoker<DeleteOrganizationConformancePackResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteOrganizationConformancePackResponse>);
        }
        
        /// <summary>
        /// 列举预定义合规规则包模板
        ///
        /// 列举预定义的合规规则包的模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBuiltInConformancePackTemplatesResponse> ListBuiltInConformancePackTemplatesAsync(ListBuiltInConformancePackTemplatesRequest listBuiltInConformancePackTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/conformance-packs/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBuiltInConformancePackTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBuiltInConformancePackTemplatesResponse>(response);
        }

        public AsyncInvoker<ListBuiltInConformancePackTemplatesResponse> ListBuiltInConformancePackTemplatesAsyncInvoker(ListBuiltInConformancePackTemplatesRequest listBuiltInConformancePackTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/conformance-packs/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBuiltInConformancePackTemplatesRequest);
            return new AsyncInvoker<ListBuiltInConformancePackTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBuiltInConformancePackTemplatesResponse>);
        }
        
        /// <summary>
        /// 列举合规规则包的评估结果
        ///
        /// 列举合规规则包的合规规则评估结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConformancePackComplianceByPackIdResponse> ListConformancePackComplianceByPackIdAsync(ListConformancePackComplianceByPackIdRequest listConformancePackComplianceByPackIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listConformancePackComplianceByPackIdRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/{conformance_pack_id}/compliance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConformancePackComplianceByPackIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListConformancePackComplianceByPackIdResponse>(response);
        }

        public AsyncInvoker<ListConformancePackComplianceByPackIdResponse> ListConformancePackComplianceByPackIdAsyncInvoker(ListConformancePackComplianceByPackIdRequest listConformancePackComplianceByPackIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listConformancePackComplianceByPackIdRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/{conformance_pack_id}/compliance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConformancePackComplianceByPackIdRequest);
            return new AsyncInvoker<ListConformancePackComplianceByPackIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConformancePackComplianceByPackIdResponse>);
        }
        
        /// <summary>
        /// 列举合规规则包的评估结果详情
        ///
        /// 列举合规规则包的合规规则评估结果详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConformancePackComplianceDetailsByPackIdResponse> ListConformancePackComplianceDetailsByPackIdAsync(ListConformancePackComplianceDetailsByPackIdRequest listConformancePackComplianceDetailsByPackIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listConformancePackComplianceDetailsByPackIdRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/{conformance_pack_id}/compliance/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConformancePackComplianceDetailsByPackIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListConformancePackComplianceDetailsByPackIdResponse>(response);
        }

        public AsyncInvoker<ListConformancePackComplianceDetailsByPackIdResponse> ListConformancePackComplianceDetailsByPackIdAsyncInvoker(ListConformancePackComplianceDetailsByPackIdRequest listConformancePackComplianceDetailsByPackIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listConformancePackComplianceDetailsByPackIdRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/{conformance_pack_id}/compliance/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConformancePackComplianceDetailsByPackIdRequest);
            return new AsyncInvoker<ListConformancePackComplianceDetailsByPackIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConformancePackComplianceDetailsByPackIdResponse>);
        }
        
        /// <summary>
        /// 列举合规规则包分数
        ///
        /// 列举用户的合规规则包分数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConformancePackComplianceScoresResponse> ListConformancePackComplianceScoresAsync(ListConformancePackComplianceScoresRequest listConformancePackComplianceScoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/scores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConformancePackComplianceScoresRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListConformancePackComplianceScoresResponse>(response);
        }

        public AsyncInvoker<ListConformancePackComplianceScoresResponse> ListConformancePackComplianceScoresAsyncInvoker(ListConformancePackComplianceScoresRequest listConformancePackComplianceScoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/scores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConformancePackComplianceScoresRequest);
            return new AsyncInvoker<ListConformancePackComplianceScoresResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConformancePackComplianceScoresResponse>);
        }
        
        /// <summary>
        /// 列举合规规则包
        ///
        /// 列举用户的合规规则包。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConformancePacksResponse> ListConformancePacksAsync(ListConformancePacksRequest listConformancePacksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConformancePacksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListConformancePacksResponse>(response);
        }

        public AsyncInvoker<ListConformancePacksResponse> ListConformancePacksAsyncInvoker(ListConformancePacksRequest listConformancePacksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConformancePacksRequest);
            return new AsyncInvoker<ListConformancePacksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConformancePacksResponse>);
        }
        
        /// <summary>
        /// 查看组织合规规则包部署状态
        ///
        /// 列举用户的组织合规规则包部署状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOrganizationConformancePackStatusesResponse> ListOrganizationConformancePackStatusesAsync(ListOrganizationConformancePackStatusesRequest listOrganizationConformancePackStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOrganizationConformancePackStatusesRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationConformancePackStatusesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOrganizationConformancePackStatusesResponse>(response);
        }

        public AsyncInvoker<ListOrganizationConformancePackStatusesResponse> ListOrganizationConformancePackStatusesAsyncInvoker(ListOrganizationConformancePackStatusesRequest listOrganizationConformancePackStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOrganizationConformancePackStatusesRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationConformancePackStatusesRequest);
            return new AsyncInvoker<ListOrganizationConformancePackStatusesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOrganizationConformancePackStatusesResponse>);
        }
        
        /// <summary>
        /// 列举组织合规规则包
        ///
        /// 列举用户的组织合规规则包。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOrganizationConformancePacksResponse> ListOrganizationConformancePacksAsync(ListOrganizationConformancePacksRequest listOrganizationConformancePacksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOrganizationConformancePacksRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationConformancePacksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOrganizationConformancePacksResponse>(response);
        }

        public AsyncInvoker<ListOrganizationConformancePacksResponse> ListOrganizationConformancePacksAsyncInvoker(ListOrganizationConformancePacksRequest listOrganizationConformancePacksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOrganizationConformancePacksRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationConformancePacksRequest);
            return new AsyncInvoker<ListOrganizationConformancePacksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOrganizationConformancePacksResponse>);
        }
        
        /// <summary>
        /// 查看预定义合规规则包模板
        ///
        /// 根据ID获取单个预定义合规规则包模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBuiltInConformancePackTemplateResponse> ShowBuiltInConformancePackTemplateAsync(ShowBuiltInConformancePackTemplateRequest showBuiltInConformancePackTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBuiltInConformancePackTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/conformance-packs/templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuiltInConformancePackTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBuiltInConformancePackTemplateResponse>(response);
        }

        public AsyncInvoker<ShowBuiltInConformancePackTemplateResponse> ShowBuiltInConformancePackTemplateAsyncInvoker(ShowBuiltInConformancePackTemplateRequest showBuiltInConformancePackTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBuiltInConformancePackTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/conformance-packs/templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuiltInConformancePackTemplateRequest);
            return new AsyncInvoker<ShowBuiltInConformancePackTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBuiltInConformancePackTemplateResponse>);
        }
        
        /// <summary>
        /// 查看合规规则包
        ///
        /// 根据ID获取单个合规规则包。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowConformancePackResponse> ShowConformancePackAsync(ShowConformancePackRequest showConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConformancePackRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowConformancePackResponse>(response);
        }

        public AsyncInvoker<ShowConformancePackResponse> ShowConformancePackAsyncInvoker(ShowConformancePackRequest showConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConformancePackRequest);
            return new AsyncInvoker<ShowConformancePackResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConformancePackResponse>);
        }
        
        /// <summary>
        /// 查看组织合规规则包
        ///
        /// 根据ID获取单个组织合规规则包详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOrganizationConformancePackResponse> ShowOrganizationConformancePackAsync(ShowOrganizationConformancePackRequest showOrganizationConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationConformancePackRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationConformancePackRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOrganizationConformancePackResponse>(response);
        }

        public AsyncInvoker<ShowOrganizationConformancePackResponse> ShowOrganizationConformancePackAsyncInvoker(ShowOrganizationConformancePackRequest showOrganizationConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationConformancePackRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationConformancePackRequest);
            return new AsyncInvoker<ShowOrganizationConformancePackResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOrganizationConformancePackResponse>);
        }
        
        /// <summary>
        /// 查看组织合规规则包部署详细状态
        ///
        /// 查看指定组织合规规则包在成员帐号中的部署状态详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOrganizationConformancePackDetailedStatusesResponse> ShowOrganizationConformancePackDetailedStatusesAsync(ShowOrganizationConformancePackDetailedStatusesRequest showOrganizationConformancePackDetailedStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationConformancePackDetailedStatusesRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs/detailed-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationConformancePackDetailedStatusesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOrganizationConformancePackDetailedStatusesResponse>(response);
        }

        public AsyncInvoker<ShowOrganizationConformancePackDetailedStatusesResponse> ShowOrganizationConformancePackDetailedStatusesAsyncInvoker(ShowOrganizationConformancePackDetailedStatusesRequest showOrganizationConformancePackDetailedStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationConformancePackDetailedStatusesRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs/detailed-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationConformancePackDetailedStatusesRequest);
            return new AsyncInvoker<ShowOrganizationConformancePackDetailedStatusesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOrganizationConformancePackDetailedStatusesResponse>);
        }
        
        /// <summary>
        /// 更新合规规则包
        ///
        /// 更新用户的合规规则包。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateConformancePackResponse> UpdateConformancePackAsync(UpdateConformancePackRequest updateConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConformancePackRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateConformancePackResponse>(response);
        }

        public AsyncInvoker<UpdateConformancePackResponse> UpdateConformancePackAsyncInvoker(UpdateConformancePackRequest updateConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConformancePackRequest);
            return new AsyncInvoker<UpdateConformancePackResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateConformancePackResponse>);
        }
        
        /// <summary>
        /// 更新组织合规规则包
        ///
        /// 更新用户的组织合规规则包。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateOrganizationConformancePackResponse> UpdateOrganizationConformancePackAsync(UpdateOrganizationConformancePackRequest updateOrganizationConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateOrganizationConformancePackRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(updateOrganizationConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOrganizationConformancePackRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateOrganizationConformancePackResponse>(response);
        }

        public AsyncInvoker<UpdateOrganizationConformancePackResponse> UpdateOrganizationConformancePackAsyncInvoker(UpdateOrganizationConformancePackRequest updateOrganizationConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateOrganizationConformancePackRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(updateOrganizationConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOrganizationConformancePackRequest);
            return new AsyncInvoker<UpdateOrganizationConformancePackResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateOrganizationConformancePackResponse>);
        }
        
        /// <summary>
        /// 查询资源历史
        ///
        /// 查询资源与资源关系的变更历史
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceHistoryResponse> ShowResourceHistoryAsync(ShowResourceHistoryRequest showResourceHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceHistoryRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/resources/{resource_id}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceHistoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceHistoryResponse>(response);
        }

        public AsyncInvoker<ShowResourceHistoryResponse> ShowResourceHistoryAsyncInvoker(ShowResourceHistoryRequest showResourceHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceHistoryRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/resources/{resource_id}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceHistoryRequest);
            return new AsyncInvoker<ShowResourceHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceHistoryResponse>);
        }
        
        /// <summary>
        /// 批量创建修正例外
        ///
        /// 批量创建合规规则修正例外。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateRemediationExceptionsResponse> BatchCreateRemediationExceptionsAsync(BatchCreateRemediationExceptionsRequest batchCreateRemediationExceptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateRemediationExceptionsRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-exception/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateRemediationExceptionsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateRemediationExceptionsResponse>(response);
        }

        public AsyncInvoker<BatchCreateRemediationExceptionsResponse> BatchCreateRemediationExceptionsAsyncInvoker(BatchCreateRemediationExceptionsRequest batchCreateRemediationExceptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateRemediationExceptionsRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-exception/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateRemediationExceptionsRequest);
            return new AsyncInvoker<BatchCreateRemediationExceptionsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateRemediationExceptionsResponse>);
        }
        
        /// <summary>
        /// 批量删除修正例外
        ///
        /// 批量删除合规规则修正例外。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteRemediationExceptionsResponse> BatchDeleteRemediationExceptionsAsync(BatchDeleteRemediationExceptionsRequest batchDeleteRemediationExceptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteRemediationExceptionsRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-exception/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRemediationExceptionsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteRemediationExceptionsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteRemediationExceptionsResponse> BatchDeleteRemediationExceptionsAsyncInvoker(BatchDeleteRemediationExceptionsRequest batchDeleteRemediationExceptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteRemediationExceptionsRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-exception/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRemediationExceptionsRequest);
            return new AsyncInvoker<BatchDeleteRemediationExceptionsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteRemediationExceptionsResponse>);
        }
        
        /// <summary>
        /// 查询规则的合规总结
        ///
        /// 根据规则ID查询此规则的合规总结
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CollectPolicyAssignmentsStatesSummaryResponse> CollectPolicyAssignmentsStatesSummaryAsync(CollectPolicyAssignmentsStatesSummaryRequest collectPolicyAssignmentsStatesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(collectPolicyAssignmentsStatesSummaryRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/policy-states/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectPolicyAssignmentsStatesSummaryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CollectPolicyAssignmentsStatesSummaryResponse>(response);
        }

        public AsyncInvoker<CollectPolicyAssignmentsStatesSummaryResponse> CollectPolicyAssignmentsStatesSummaryAsyncInvoker(CollectPolicyAssignmentsStatesSummaryRequest collectPolicyAssignmentsStatesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(collectPolicyAssignmentsStatesSummaryRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/policy-states/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectPolicyAssignmentsStatesSummaryRequest);
            return new AsyncInvoker<CollectPolicyAssignmentsStatesSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<CollectPolicyAssignmentsStatesSummaryResponse>);
        }
        
        /// <summary>
        /// 查询用户的合规总结
        ///
        /// 查询用户的合规总结
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CollectPolicyStatesSummaryResponse> CollectPolicyStatesSummaryAsync(CollectPolicyStatesSummaryRequest collectPolicyStatesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-states/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectPolicyStatesSummaryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CollectPolicyStatesSummaryResponse>(response);
        }

        public AsyncInvoker<CollectPolicyStatesSummaryResponse> CollectPolicyStatesSummaryAsyncInvoker(CollectPolicyStatesSummaryRequest collectPolicyStatesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-states/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectPolicyStatesSummaryRequest);
            return new AsyncInvoker<CollectPolicyStatesSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<CollectPolicyStatesSummaryResponse>);
        }
        
        /// <summary>
        /// 列举修正最新记录
        ///
        /// 列举合规规则修正最新记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CollectRemediationExecutionStatusesSummaryResponse> CollectRemediationExecutionStatusesSummaryAsync(CollectRemediationExecutionStatusesSummaryRequest collectRemediationExecutionStatusesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(collectRemediationExecutionStatusesSummaryRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-execution-statuses/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectRemediationExecutionStatusesSummaryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CollectRemediationExecutionStatusesSummaryResponse>(response);
        }

        public AsyncInvoker<CollectRemediationExecutionStatusesSummaryResponse> CollectRemediationExecutionStatusesSummaryAsyncInvoker(CollectRemediationExecutionStatusesSummaryRequest collectRemediationExecutionStatusesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(collectRemediationExecutionStatusesSummaryRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-execution-statuses/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectRemediationExecutionStatusesSummaryRequest);
            return new AsyncInvoker<CollectRemediationExecutionStatusesSummaryResponse>(this, "POST", request, JsonUtils.DeSerialize<CollectRemediationExecutionStatusesSummaryResponse>);
        }
        
        /// <summary>
        /// 查询用户资源的合规总结
        ///
        /// 查询用户资源的合规总结
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CollectResourcesPolicyStatesSummaryResponse> CollectResourcesPolicyStatesSummaryAsync(CollectResourcesPolicyStatesSummaryRequest collectResourcesPolicyStatesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/resources/policy-states/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectResourcesPolicyStatesSummaryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CollectResourcesPolicyStatesSummaryResponse>(response);
        }

        public AsyncInvoker<CollectResourcesPolicyStatesSummaryResponse> CollectResourcesPolicyStatesSummaryAsyncInvoker(CollectResourcesPolicyStatesSummaryRequest collectResourcesPolicyStatesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/resources/policy-states/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectResourcesPolicyStatesSummaryRequest);
            return new AsyncInvoker<CollectResourcesPolicyStatesSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<CollectResourcesPolicyStatesSummaryResponse>);
        }
        
        /// <summary>
        /// 创建或更新修正配置
        ///
        /// 创建或更新合规规则修正配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateOrUpdateRemediationConfigurationResponse> CreateOrUpdateRemediationConfigurationAsync(CreateOrUpdateRemediationConfigurationRequest createOrUpdateRemediationConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createOrUpdateRemediationConfigurationRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrUpdateRemediationConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<CreateOrUpdateRemediationConfigurationResponse>(response);
        }

        public AsyncInvoker<CreateOrUpdateRemediationConfigurationResponse> CreateOrUpdateRemediationConfigurationAsyncInvoker(CreateOrUpdateRemediationConfigurationRequest createOrUpdateRemediationConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createOrUpdateRemediationConfigurationRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrUpdateRemediationConfigurationRequest);
            return new AsyncInvoker<CreateOrUpdateRemediationConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreateOrUpdateRemediationConfigurationResponse>);
        }
        
        /// <summary>
        /// 创建组织合规规则
        ///
        /// 创建组织合规规则，如果规则名称已存在，则为更新操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateOrganizationPolicyAssignmentResponse> CreateOrganizationPolicyAssignmentAsync(CreateOrganizationPolicyAssignmentRequest createOrganizationPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createOrganizationPolicyAssignmentRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrganizationPolicyAssignmentRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<CreateOrganizationPolicyAssignmentResponse>(response);
        }

        public AsyncInvoker<CreateOrganizationPolicyAssignmentResponse> CreateOrganizationPolicyAssignmentAsyncInvoker(CreateOrganizationPolicyAssignmentRequest createOrganizationPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createOrganizationPolicyAssignmentRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrganizationPolicyAssignmentRequest);
            return new AsyncInvoker<CreateOrganizationPolicyAssignmentResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreateOrganizationPolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 创建合规规则
        ///
        /// 创建新的合规规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePolicyAssignmentsResponse> CreatePolicyAssignmentsAsync(CreatePolicyAssignmentsRequest createPolicyAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyAssignmentsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<CreatePolicyAssignmentsResponse>(response);
        }

        public AsyncInvoker<CreatePolicyAssignmentsResponse> CreatePolicyAssignmentsAsyncInvoker(CreatePolicyAssignmentsRequest createPolicyAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyAssignmentsRequest);
            return new AsyncInvoker<CreatePolicyAssignmentsResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreatePolicyAssignmentsResponse>);
        }
        
        /// <summary>
        /// 删除组织合规规则
        ///
        /// 删除组织合规规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteOrganizationPolicyAssignmentResponse> DeleteOrganizationPolicyAssignmentAsync(DeleteOrganizationPolicyAssignmentRequest deleteOrganizationPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOrganizationPolicyAssignmentRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(deleteOrganizationPolicyAssignmentRequest.OrganizationPolicyAssignmentId, out var valueOfOrganizationPolicyAssignmentId)) urlParam.Add("organization_policy_assignment_id", valueOfOrganizationPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignments/{organization_policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOrganizationPolicyAssignmentRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteOrganizationPolicyAssignmentResponse>(response);
        }

        public AsyncInvoker<DeleteOrganizationPolicyAssignmentResponse> DeleteOrganizationPolicyAssignmentAsyncInvoker(DeleteOrganizationPolicyAssignmentRequest deleteOrganizationPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOrganizationPolicyAssignmentRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(deleteOrganizationPolicyAssignmentRequest.OrganizationPolicyAssignmentId, out var valueOfOrganizationPolicyAssignmentId)) urlParam.Add("organization_policy_assignment_id", valueOfOrganizationPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignments/{organization_policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOrganizationPolicyAssignmentRequest);
            return new AsyncInvoker<DeleteOrganizationPolicyAssignmentResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteOrganizationPolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 删除合规规则
        ///
        /// 根据规则ID删除此规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePolicyAssignmentResponse> DeletePolicyAssignmentAsync(DeletePolicyAssignmentRequest deletePolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyAssignmentRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyAssignmentRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePolicyAssignmentResponse>(response);
        }

        public AsyncInvoker<DeletePolicyAssignmentResponse> DeletePolicyAssignmentAsyncInvoker(DeletePolicyAssignmentRequest deletePolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyAssignmentRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyAssignmentRequest);
            return new AsyncInvoker<DeletePolicyAssignmentResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 删除修正配置
        ///
        /// 删除合规规则修正配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRemediationConfigurationResponse> DeleteRemediationConfigurationAsync(DeleteRemediationConfigurationRequest deleteRemediationConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRemediationConfigurationRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRemediationConfigurationRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRemediationConfigurationResponse>(response);
        }

        public AsyncInvoker<DeleteRemediationConfigurationResponse> DeleteRemediationConfigurationAsyncInvoker(DeleteRemediationConfigurationRequest deleteRemediationConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRemediationConfigurationRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRemediationConfigurationRequest);
            return new AsyncInvoker<DeleteRemediationConfigurationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRemediationConfigurationResponse>);
        }
        
        /// <summary>
        /// 停用合规规则
        ///
        /// 根据规则ID停用此规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisablePolicyAssignmentResponse> DisablePolicyAssignmentAsync(DisablePolicyAssignmentRequest disablePolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disablePolicyAssignmentRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disablePolicyAssignmentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DisablePolicyAssignmentResponse>(response);
        }

        public AsyncInvoker<DisablePolicyAssignmentResponse> DisablePolicyAssignmentAsyncInvoker(DisablePolicyAssignmentRequest disablePolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disablePolicyAssignmentRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disablePolicyAssignmentRequest);
            return new AsyncInvoker<DisablePolicyAssignmentResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisablePolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 启用合规规则
        ///
        /// 根据规则ID启用此规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnablePolicyAssignmentResponse> EnablePolicyAssignmentAsync(EnablePolicyAssignmentRequest enablePolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enablePolicyAssignmentRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enablePolicyAssignmentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<EnablePolicyAssignmentResponse>(response);
        }

        public AsyncInvoker<EnablePolicyAssignmentResponse> EnablePolicyAssignmentAsyncInvoker(EnablePolicyAssignmentRequest enablePolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enablePolicyAssignmentRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enablePolicyAssignmentRequest);
            return new AsyncInvoker<EnablePolicyAssignmentResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnablePolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 列出内置策略
        ///
        /// 列出用户的内置策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBuiltInPolicyDefinitionsResponse> ListBuiltInPolicyDefinitionsAsync(ListBuiltInPolicyDefinitionsRequest listBuiltInPolicyDefinitionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/policy-definitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBuiltInPolicyDefinitionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBuiltInPolicyDefinitionsResponse>(response);
        }

        public AsyncInvoker<ListBuiltInPolicyDefinitionsResponse> ListBuiltInPolicyDefinitionsAsyncInvoker(ListBuiltInPolicyDefinitionsRequest listBuiltInPolicyDefinitionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/policy-definitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBuiltInPolicyDefinitionsRequest);
            return new AsyncInvoker<ListBuiltInPolicyDefinitionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBuiltInPolicyDefinitionsResponse>);
        }
        
        /// <summary>
        /// 查询组织合规规则列表
        ///
        /// 查询组织合规规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOrganizationPolicyAssignmentsResponse> ListOrganizationPolicyAssignmentsAsync(ListOrganizationPolicyAssignmentsRequest listOrganizationPolicyAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOrganizationPolicyAssignmentsRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationPolicyAssignmentsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOrganizationPolicyAssignmentsResponse>(response);
        }

        public AsyncInvoker<ListOrganizationPolicyAssignmentsResponse> ListOrganizationPolicyAssignmentsAsyncInvoker(ListOrganizationPolicyAssignmentsRequest listOrganizationPolicyAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOrganizationPolicyAssignmentsRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationPolicyAssignmentsRequest);
            return new AsyncInvoker<ListOrganizationPolicyAssignmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOrganizationPolicyAssignmentsResponse>);
        }
        
        /// <summary>
        /// 列出合规规则
        ///
        /// 列出用户的合规规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPolicyAssignmentsResponse> ListPolicyAssignmentsAsync(ListPolicyAssignmentsRequest listPolicyAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyAssignmentsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyAssignmentsResponse>(response);
        }

        public AsyncInvoker<ListPolicyAssignmentsResponse> ListPolicyAssignmentsAsyncInvoker(ListPolicyAssignmentsRequest listPolicyAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyAssignmentsRequest);
            return new AsyncInvoker<ListPolicyAssignmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyAssignmentsResponse>);
        }
        
        /// <summary>
        /// 获取规则的合规结果
        ///
        /// 根据规则ID查询所有的合规结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPolicyStatesByAssignmentIdResponse> ListPolicyStatesByAssignmentIdAsync(ListPolicyStatesByAssignmentIdRequest listPolicyStatesByAssignmentIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPolicyStatesByAssignmentIdRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/policy-states", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyStatesByAssignmentIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyStatesByAssignmentIdResponse>(response);
        }

        public AsyncInvoker<ListPolicyStatesByAssignmentIdResponse> ListPolicyStatesByAssignmentIdAsyncInvoker(ListPolicyStatesByAssignmentIdRequest listPolicyStatesByAssignmentIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPolicyStatesByAssignmentIdRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/policy-states", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyStatesByAssignmentIdRequest);
            return new AsyncInvoker<ListPolicyStatesByAssignmentIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyStatesByAssignmentIdResponse>);
        }
        
        /// <summary>
        /// 获取用户的合规结果
        ///
        /// 查询用户所有的合规结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPolicyStatesByDomainIdResponse> ListPolicyStatesByDomainIdAsync(ListPolicyStatesByDomainIdRequest listPolicyStatesByDomainIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-states", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyStatesByDomainIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyStatesByDomainIdResponse>(response);
        }

        public AsyncInvoker<ListPolicyStatesByDomainIdResponse> ListPolicyStatesByDomainIdAsyncInvoker(ListPolicyStatesByDomainIdRequest listPolicyStatesByDomainIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-states", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyStatesByDomainIdRequest);
            return new AsyncInvoker<ListPolicyStatesByDomainIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyStatesByDomainIdResponse>);
        }
        
        /// <summary>
        /// 获取资源的合规结果
        ///
        /// 根据资源ID查询所有合规结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPolicyStatesByResourceIdResponse> ListPolicyStatesByResourceIdAsync(ListPolicyStatesByResourceIdRequest listPolicyStatesByResourceIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPolicyStatesByResourceIdRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/resources/{resource_id}/policy-states", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyStatesByResourceIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyStatesByResourceIdResponse>(response);
        }

        public AsyncInvoker<ListPolicyStatesByResourceIdResponse> ListPolicyStatesByResourceIdAsyncInvoker(ListPolicyStatesByResourceIdRequest listPolicyStatesByResourceIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPolicyStatesByResourceIdRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/resources/{resource_id}/policy-states", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyStatesByResourceIdRequest);
            return new AsyncInvoker<ListPolicyStatesByResourceIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyStatesByResourceIdResponse>);
        }
        
        /// <summary>
        /// 查询当前账号合规统计趋势
        ///
        /// 查询当前账号合规统计趋势
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPolicyStatesStatisticsResponse> ListPolicyStatesStatisticsAsync(ListPolicyStatesStatisticsRequest listPolicyStatesStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-states/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyStatesStatisticsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyStatesStatisticsResponse>(response);
        }

        public AsyncInvoker<ListPolicyStatesStatisticsResponse> ListPolicyStatesStatisticsAsyncInvoker(ListPolicyStatesStatisticsRequest listPolicyStatesStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-states/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyStatesStatisticsRequest);
            return new AsyncInvoker<ListPolicyStatesStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyStatesStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询修正例外
        ///
        /// 查询合规规则修正例外。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRemediationExceptionsResponse> ListRemediationExceptionsAsync(ListRemediationExceptionsRequest listRemediationExceptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRemediationExceptionsRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-exception", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRemediationExceptionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRemediationExceptionsResponse>(response);
        }

        public AsyncInvoker<ListRemediationExceptionsResponse> ListRemediationExceptionsAsyncInvoker(ListRemediationExceptionsRequest listRemediationExceptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRemediationExceptionsRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-exception", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRemediationExceptionsRequest);
            return new AsyncInvoker<ListRemediationExceptionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRemediationExceptionsResponse>);
        }
        
        /// <summary>
        /// 查询修正执行结果
        ///
        /// 查询合规规则修正执行结果详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRemediationExecutionStatusesResponse> ListRemediationExecutionStatusesAsync(ListRemediationExecutionStatusesRequest listRemediationExecutionStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRemediationExecutionStatusesRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-execution-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRemediationExecutionStatusesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRemediationExecutionStatusesResponse>(response);
        }

        public AsyncInvoker<ListRemediationExecutionStatusesResponse> ListRemediationExecutionStatusesAsyncInvoker(ListRemediationExecutionStatusesRequest listRemediationExecutionStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRemediationExecutionStatusesRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-execution-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRemediationExecutionStatusesRequest);
            return new AsyncInvoker<ListRemediationExecutionStatusesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRemediationExecutionStatusesResponse>);
        }
        
        /// <summary>
        /// 运行合规评估
        ///
        /// 根据规则ID评估此规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunEvaluationByPolicyAssignmentIdResponse> RunEvaluationByPolicyAssignmentIdAsync(RunEvaluationByPolicyAssignmentIdRequest runEvaluationByPolicyAssignmentIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runEvaluationByPolicyAssignmentIdRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/policy-states/run-evaluation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runEvaluationByPolicyAssignmentIdRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<RunEvaluationByPolicyAssignmentIdResponse>(response);
        }

        public AsyncInvoker<RunEvaluationByPolicyAssignmentIdResponse> RunEvaluationByPolicyAssignmentIdAsyncInvoker(RunEvaluationByPolicyAssignmentIdRequest runEvaluationByPolicyAssignmentIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runEvaluationByPolicyAssignmentIdRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/policy-states/run-evaluation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runEvaluationByPolicyAssignmentIdRequest);
            return new AsyncInvoker<RunEvaluationByPolicyAssignmentIdResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RunEvaluationByPolicyAssignmentIdResponse>);
        }
        
        /// <summary>
        /// 运行修正执行
        ///
        /// 手动运行合规规则修正执行。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunRemediationExecutionResponse> RunRemediationExecutionAsync(RunRemediationExecutionRequest runRemediationExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runRemediationExecutionRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-execution", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runRemediationExecutionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<RunRemediationExecutionResponse>(response);
        }

        public AsyncInvoker<RunRemediationExecutionResponse> RunRemediationExecutionAsyncInvoker(RunRemediationExecutionRequest runRemediationExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runRemediationExecutionRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-execution", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runRemediationExecutionRequest);
            return new AsyncInvoker<RunRemediationExecutionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RunRemediationExecutionResponse>);
        }
        
        /// <summary>
        /// 查询单个内置策略
        ///
        /// 根据策略ID查询单个内置策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBuiltInPolicyDefinitionResponse> ShowBuiltInPolicyDefinitionAsync(ShowBuiltInPolicyDefinitionRequest showBuiltInPolicyDefinitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBuiltInPolicyDefinitionRequest.PolicyDefinitionId, out var valueOfPolicyDefinitionId)) urlParam.Add("policy_definition_id", valueOfPolicyDefinitionId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/policy-definitions/{policy_definition_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuiltInPolicyDefinitionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBuiltInPolicyDefinitionResponse>(response);
        }

        public AsyncInvoker<ShowBuiltInPolicyDefinitionResponse> ShowBuiltInPolicyDefinitionAsyncInvoker(ShowBuiltInPolicyDefinitionRequest showBuiltInPolicyDefinitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBuiltInPolicyDefinitionRequest.PolicyDefinitionId, out var valueOfPolicyDefinitionId)) urlParam.Add("policy_definition_id", valueOfPolicyDefinitionId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/policy-definitions/{policy_definition_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuiltInPolicyDefinitionRequest);
            return new AsyncInvoker<ShowBuiltInPolicyDefinitionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBuiltInPolicyDefinitionResponse>);
        }
        
        /// <summary>
        /// 获取规则的评估状态
        ///
        /// 根据规则ID查询此规则的评估状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEvaluationStateByAssignmentIdResponse> ShowEvaluationStateByAssignmentIdAsync(ShowEvaluationStateByAssignmentIdRequest showEvaluationStateByAssignmentIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEvaluationStateByAssignmentIdRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/policy-states/evaluation-state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEvaluationStateByAssignmentIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowEvaluationStateByAssignmentIdResponse>(response);
        }

        public AsyncInvoker<ShowEvaluationStateByAssignmentIdResponse> ShowEvaluationStateByAssignmentIdAsyncInvoker(ShowEvaluationStateByAssignmentIdRequest showEvaluationStateByAssignmentIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEvaluationStateByAssignmentIdRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/policy-states/evaluation-state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEvaluationStateByAssignmentIdRequest);
            return new AsyncInvoker<ShowEvaluationStateByAssignmentIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEvaluationStateByAssignmentIdResponse>);
        }
        
        /// <summary>
        /// 查询指定组织合规规则
        ///
        /// 查询指定组织合规规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOrganizationPolicyAssignmentResponse> ShowOrganizationPolicyAssignmentAsync(ShowOrganizationPolicyAssignmentRequest showOrganizationPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationPolicyAssignmentRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationPolicyAssignmentRequest.OrganizationPolicyAssignmentId, out var valueOfOrganizationPolicyAssignmentId)) urlParam.Add("organization_policy_assignment_id", valueOfOrganizationPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignments/{organization_policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationPolicyAssignmentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOrganizationPolicyAssignmentResponse>(response);
        }

        public AsyncInvoker<ShowOrganizationPolicyAssignmentResponse> ShowOrganizationPolicyAssignmentAsyncInvoker(ShowOrganizationPolicyAssignmentRequest showOrganizationPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationPolicyAssignmentRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationPolicyAssignmentRequest.OrganizationPolicyAssignmentId, out var valueOfOrganizationPolicyAssignmentId)) urlParam.Add("organization_policy_assignment_id", valueOfOrganizationPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignments/{organization_policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationPolicyAssignmentRequest);
            return new AsyncInvoker<ShowOrganizationPolicyAssignmentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOrganizationPolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 查询组织内每个成员帐号合规规则部署的详细状态
        ///
        /// 查询组织内每个成员帐号合规规则部署的详细状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOrganizationPolicyAssignmentDetailedStatusResponse> ShowOrganizationPolicyAssignmentDetailedStatusAsync(ShowOrganizationPolicyAssignmentDetailedStatusRequest showOrganizationPolicyAssignmentDetailedStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationPolicyAssignmentDetailedStatusRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignment-detailed-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationPolicyAssignmentDetailedStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOrganizationPolicyAssignmentDetailedStatusResponse>(response);
        }

        public AsyncInvoker<ShowOrganizationPolicyAssignmentDetailedStatusResponse> ShowOrganizationPolicyAssignmentDetailedStatusAsyncInvoker(ShowOrganizationPolicyAssignmentDetailedStatusRequest showOrganizationPolicyAssignmentDetailedStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationPolicyAssignmentDetailedStatusRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignment-detailed-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationPolicyAssignmentDetailedStatusRequest);
            return new AsyncInvoker<ShowOrganizationPolicyAssignmentDetailedStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOrganizationPolicyAssignmentDetailedStatusResponse>);
        }
        
        /// <summary>
        /// 查询组织合规规则部署状态
        ///
        /// 查询组织合规规则部署状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOrganizationPolicyAssignmentStatusesResponse> ShowOrganizationPolicyAssignmentStatusesAsync(ShowOrganizationPolicyAssignmentStatusesRequest showOrganizationPolicyAssignmentStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationPolicyAssignmentStatusesRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignment-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationPolicyAssignmentStatusesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOrganizationPolicyAssignmentStatusesResponse>(response);
        }

        public AsyncInvoker<ShowOrganizationPolicyAssignmentStatusesResponse> ShowOrganizationPolicyAssignmentStatusesAsyncInvoker(ShowOrganizationPolicyAssignmentStatusesRequest showOrganizationPolicyAssignmentStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationPolicyAssignmentStatusesRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignment-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationPolicyAssignmentStatusesRequest);
            return new AsyncInvoker<ShowOrganizationPolicyAssignmentStatusesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOrganizationPolicyAssignmentStatusesResponse>);
        }
        
        /// <summary>
        /// 获取单个合规规则
        ///
        /// 根据规则ID获取单个规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPolicyAssignmentResponse> ShowPolicyAssignmentAsync(ShowPolicyAssignmentRequest showPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyAssignmentRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyAssignmentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPolicyAssignmentResponse>(response);
        }

        public AsyncInvoker<ShowPolicyAssignmentResponse> ShowPolicyAssignmentAsyncInvoker(ShowPolicyAssignmentRequest showPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyAssignmentRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyAssignmentRequest);
            return new AsyncInvoker<ShowPolicyAssignmentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 查询修正配置
        ///
        /// 查询合规规则修正配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRemediationConfigurationResponse> ShowRemediationConfigurationAsync(ShowRemediationConfigurationRequest showRemediationConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRemediationConfigurationRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRemediationConfigurationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRemediationConfigurationResponse>(response);
        }

        public AsyncInvoker<ShowRemediationConfigurationResponse> ShowRemediationConfigurationAsyncInvoker(ShowRemediationConfigurationRequest showRemediationConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRemediationConfigurationRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRemediationConfigurationRequest);
            return new AsyncInvoker<ShowRemediationConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRemediationConfigurationResponse>);
        }
        
        /// <summary>
        /// 更新组织合规规则
        ///
        /// 更新组织合规规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateOrganizationPolicyAssignmentResponse> UpdateOrganizationPolicyAssignmentAsync(UpdateOrganizationPolicyAssignmentRequest updateOrganizationPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateOrganizationPolicyAssignmentRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(updateOrganizationPolicyAssignmentRequest.OrganizationPolicyAssignmentId, out var valueOfOrganizationPolicyAssignmentId)) urlParam.Add("organization_policy_assignment_id", valueOfOrganizationPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignments/{organization_policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOrganizationPolicyAssignmentRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateOrganizationPolicyAssignmentResponse>(response);
        }

        public AsyncInvoker<UpdateOrganizationPolicyAssignmentResponse> UpdateOrganizationPolicyAssignmentAsyncInvoker(UpdateOrganizationPolicyAssignmentRequest updateOrganizationPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateOrganizationPolicyAssignmentRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(updateOrganizationPolicyAssignmentRequest.OrganizationPolicyAssignmentId, out var valueOfOrganizationPolicyAssignmentId)) urlParam.Add("organization_policy_assignment_id", valueOfOrganizationPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignments/{organization_policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOrganizationPolicyAssignmentRequest);
            return new AsyncInvoker<UpdateOrganizationPolicyAssignmentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateOrganizationPolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 更新合规规则
        ///
        /// 更新用户的合规规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePolicyAssignmentResponse> UpdatePolicyAssignmentAsync(UpdatePolicyAssignmentRequest updatePolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyAssignmentRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyAssignmentRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePolicyAssignmentResponse>(response);
        }

        public AsyncInvoker<UpdatePolicyAssignmentResponse> UpdatePolicyAssignmentAsyncInvoker(UpdatePolicyAssignmentRequest updatePolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyAssignmentRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyAssignmentRequest);
            return new AsyncInvoker<UpdatePolicyAssignmentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 更新合规评估结果
        ///
        /// 更新用户自定义合规规则的合规评估结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePolicyStateResponse> UpdatePolicyStateAsync(UpdatePolicyStateRequest updatePolicyStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-states", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyStateRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePolicyStateResponse>(response);
        }

        public AsyncInvoker<UpdatePolicyStateResponse> UpdatePolicyStateAsyncInvoker(UpdatePolicyStateRequest updatePolicyStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-states", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyStateRequest);
            return new AsyncInvoker<UpdatePolicyStateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePolicyStateResponse>);
        }
        
        /// <summary>
        /// 创建高级查询
        ///
        /// 创建新的高级查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateStoredQueryResponse> CreateStoredQueryAsync(CreateStoredQueryRequest createStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/stored-queries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createStoredQueryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateStoredQueryResponse>(response);
        }

        public AsyncInvoker<CreateStoredQueryResponse> CreateStoredQueryAsyncInvoker(CreateStoredQueryRequest createStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/stored-queries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createStoredQueryRequest);
            return new AsyncInvoker<CreateStoredQueryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateStoredQueryResponse>);
        }
        
        /// <summary>
        /// 删除高级查询
        ///
        /// 删除单个高级查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteStoredQueryResponse> DeleteStoredQueryAsync(DeleteStoredQueryRequest deleteStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStoredQueryRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteStoredQueryResponse>(response);
        }

        public AsyncInvoker<DeleteStoredQueryResponse> DeleteStoredQueryAsyncInvoker(DeleteStoredQueryRequest deleteStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/stored-queries/{query_id}", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/schemas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSchemasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSchemasResponse>(response);
        }

        public AsyncInvoker<ListSchemasResponse> ListSchemasAsyncInvoker(ListSchemasRequest listSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/schemas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSchemasRequest);
            return new AsyncInvoker<ListSchemasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSchemasResponse>);
        }
        
        /// <summary>
        /// 列出高级查询
        ///
        /// 列举所有高级查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStoredQueriesResponse> ListStoredQueriesAsync(ListStoredQueriesRequest listStoredQueriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/stored-queries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStoredQueriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStoredQueriesResponse>(response);
        }

        public AsyncInvoker<ListStoredQueriesResponse> ListStoredQueriesAsyncInvoker(ListStoredQueriesRequest listStoredQueriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/stored-queries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStoredQueriesRequest);
            return new AsyncInvoker<ListStoredQueriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStoredQueriesResponse>);
        }
        
        /// <summary>
        /// 运行高级查询
        ///
        /// 执行高级查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunQueryResponse> RunQueryAsync(RunQueryRequest runQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/run-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RunQueryResponse>(response);
        }

        public AsyncInvoker<RunQueryResponse> RunQueryAsyncInvoker(RunQueryRequest runQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/run-query", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStoredQueryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStoredQueryResponse>(response);
        }

        public AsyncInvoker<ShowStoredQueryResponse> ShowStoredQueryAsyncInvoker(ShowStoredQueryRequest showStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStoredQueryRequest);
            return new AsyncInvoker<ShowStoredQueryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStoredQueryResponse>);
        }
        
        /// <summary>
        /// 更新单个高级查询
        ///
        /// 更新自定义查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateStoredQueryResponse> UpdateStoredQueryAsync(UpdateStoredQueryRequest updateStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStoredQueryRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateStoredQueryResponse>(response);
        }

        public AsyncInvoker<UpdateStoredQueryResponse> UpdateStoredQueryAsyncInvoker(UpdateStoredQueryRequest updateStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStoredQueryRequest);
            return new AsyncInvoker<UpdateStoredQueryResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateStoredQueryResponse>);
        }
        
        /// <summary>
        /// 查询用户可见的区域
        ///
        /// 查询用户可见的区域
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRegionsResponse> ListRegionsAsync(ListRegionsRequest listRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRegionsResponse>(response);
        }

        public AsyncInvoker<ListRegionsResponse> ListRegionsAsyncInvoker(ListRegionsRequest listRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegionsRequest);
            return new AsyncInvoker<ListRegionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRegionsResponse>);
        }
        
        /// <summary>
        /// 列举资源关系
        ///
        /// 指定资源ID，查询该资源与其他资源的关联关系，可以指定关系方向为\&quot;in\&quot; 或者\&quot;out\&quot;。资源关系依赖开启资源记录器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceRelationsResponse> ShowResourceRelationsAsync(ShowResourceRelationsRequest showResourceRelationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceRelationsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/resources/{resource_id}/relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceRelationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceRelationsResponse>(response);
        }

        public AsyncInvoker<ShowResourceRelationsResponse> ShowResourceRelationsAsyncInvoker(ShowResourceRelationsRequest showResourceRelationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceRelationsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/resources/{resource_id}/relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceRelationsRequest);
            return new AsyncInvoker<ShowResourceRelationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceRelationsResponse>);
        }
        
        /// <summary>
        /// 列举资源关系详情
        ///
        /// 指定资源ID，查询该资源与其他资源的关联关系，可以指定关系方向为“in”或者“out”，需要当帐号有rms:resources:getRelation权限。资源关系依赖开启资源记录器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceRelationsDetailResponse> ShowResourceRelationsDetailAsync(ShowResourceRelationsDetailRequest showResourceRelationsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceRelationsDetailRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources/{resource_id}/relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceRelationsDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceRelationsDetailResponse>(response);
        }

        public AsyncInvoker<ShowResourceRelationsDetailResponse> ShowResourceRelationsDetailAsyncInvoker(ShowResourceRelationsDetailRequest showResourceRelationsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceRelationsDetailRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources/{resource_id}/relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceRelationsDetailRequest);
            return new AsyncInvoker<ShowResourceRelationsDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceRelationsDetailResponse>);
        }
        
        /// <summary>
        /// 列举资源概要
        ///
        /// 查询当前帐号的资源概览。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CollectAllResourcesSummaryResponse> CollectAllResourcesSummaryAsync(CollectAllResourcesSummaryRequest collectAllResourcesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectAllResourcesSummaryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var collectAllResourcesSummaryResponse = JsonUtils.DeSerializeNull<CollectAllResourcesSummaryResponse>(response);
            collectAllResourcesSummaryResponse.Body = JsonUtils.DeSerializeList<ResourceSummaryResponseItem>(response);
            return collectAllResourcesSummaryResponse;
        }

        public AsyncInvoker<CollectAllResourcesSummaryResponse> CollectAllResourcesSummaryAsyncInvoker(CollectAllResourcesSummaryRequest collectAllResourcesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectAllResourcesSummaryRequest);
            return new AsyncInvoker<CollectAllResourcesSummaryResponse>(this, "GET", request, response =>
            {
                var collectAllResourcesSummaryResponse = JsonUtils.DeSerializeNull<CollectAllResourcesSummaryResponse>(response);
                collectAllResourcesSummaryResponse.Body = JsonUtils.DeSerializeList<ResourceSummaryResponseItem>(response);
                return collectAllResourcesSummaryResponse;
            });
        }
        
        /// <summary>
        /// 列举资源记录器收集的资源概要
        ///
        /// 查询当前用户资源记录器收集的资源概览。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CollectTrackedResourcesSummaryResponse> CollectTrackedResourcesSummaryAsync(CollectTrackedResourcesSummaryRequest collectTrackedResourcesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracked-resources/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectTrackedResourcesSummaryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var collectTrackedResourcesSummaryResponse = JsonUtils.DeSerializeNull<CollectTrackedResourcesSummaryResponse>(response);
            collectTrackedResourcesSummaryResponse.Body = JsonUtils.DeSerializeList<ResourceSummaryResponseItem>(response);
            return collectTrackedResourcesSummaryResponse;
        }

        public AsyncInvoker<CollectTrackedResourcesSummaryResponse> CollectTrackedResourcesSummaryAsyncInvoker(CollectTrackedResourcesSummaryRequest collectTrackedResourcesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracked-resources/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectTrackedResourcesSummaryRequest);
            return new AsyncInvoker<CollectTrackedResourcesSummaryResponse>(this, "GET", request, response =>
            {
                var collectTrackedResourcesSummaryResponse = JsonUtils.DeSerializeNull<CollectTrackedResourcesSummaryResponse>(response);
                collectTrackedResourcesSummaryResponse.Body = JsonUtils.DeSerializeList<ResourceSummaryResponseItem>(response);
                return collectTrackedResourcesSummaryResponse;
            });
        }
        
        /// <summary>
        /// 查询资源数量
        ///
        /// 查询当前帐号的资源数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountAllResourcesResponse> CountAllResourcesAsync(CountAllResourcesRequest countAllResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countAllResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CountAllResourcesResponse>(response);
        }

        public AsyncInvoker<CountAllResourcesResponse> CountAllResourcesAsyncInvoker(CountAllResourcesRequest countAllResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countAllResourcesRequest);
            return new AsyncInvoker<CountAllResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<CountAllResourcesResponse>);
        }
        
        /// <summary>
        /// 查询资源记录器收集的资源数量
        ///
        /// 查询当前用户资源记录器收集的资源数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountTrackedResourcesResponse> CountTrackedResourcesAsync(CountTrackedResourcesRequest countTrackedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracked-resources/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countTrackedResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CountTrackedResourcesResponse>(response);
        }

        public AsyncInvoker<CountTrackedResourcesResponse> CountTrackedResourcesAsyncInvoker(CountTrackedResourcesRequest countTrackedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracked-resources/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countTrackedResourcesRequest);
            return new AsyncInvoker<CountTrackedResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<CountTrackedResourcesResponse>);
        }
        
        /// <summary>
        /// 列举所有已对接的云服务
        ///
        /// 查询所有已对接Config的云服务、资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAllProvidersResponse> ListAllProvidersAsync(ListAllProvidersRequest listAllProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllProvidersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAllProvidersResponse>(response);
        }

        public AsyncInvoker<ListAllProvidersResponse> ListAllProvidersAsyncInvoker(ListAllProvidersRequest listAllProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllProvidersRequest);
            return new AsyncInvoker<ListAllProvidersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllProvidersResponse>);
        }
        
        /// <summary>
        /// 列举所有资源
        ///
        /// 返回当前用户下所有资源，需要当前用户有rms:resources:list权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAllResourcesResponse> ListAllResourcesAsync(ListAllResourcesRequest listAllResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAllResourcesResponse>(response);
        }

        public AsyncInvoker<ListAllResourcesResponse> ListAllResourcesAsyncInvoker(ListAllResourcesRequest listAllResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllResourcesRequest);
            return new AsyncInvoker<ListAllResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllResourcesResponse>);
        }
        
        /// <summary>
        /// 列举资源标签
        ///
        /// 查询当前帐号下所有资源的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAllTagsResponse> ListAllTagsAsync(ListAllTagsRequest listAllTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAllTagsResponse>(response);
        }

        public AsyncInvoker<ListAllTagsResponse> ListAllTagsAsyncInvoker(ListAllTagsRequest listAllTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllTagsRequest);
            return new AsyncInvoker<ListAllTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllTagsResponse>);
        }
        
        /// <summary>
        /// 列举云服务
        ///
        /// 查询Config支持的云服务、资源、区域列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProvidersResponse> ListProvidersAsync(ListProvidersRequest listProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvidersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProvidersResponse>(response);
        }

        public AsyncInvoker<ListProvidersResponse> ListProvidersAsyncInvoker(ListProvidersRequest listProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvidersRequest);
            return new AsyncInvoker<ListProvidersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProvidersResponse>);
        }
        
        /// <summary>
        /// 列举指定类型的资源
        ///
        /// 返回当前租户下特定资源类型的资源，需要当前用户有rms:resources:list权限。比如查询云服务器，对应的Config资源类型是ecs.cloudservers，其中provider为ecs，type为cloudservers。 Config支持的服务和资源类型参见[支持的服务和区域](https://console.huaweicloud.com/eps/#/resources/supported)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest listResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourcesRequest.Provider, out var valueOfProvider)) urlParam.Add("provider", valueOfProvider);
            if (StringUtils.TryConvertToNonEmptyString(listResourcesRequest.Type, out var valueOfType)) urlParam.Add("type", valueOfType);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/provider/{provider}/type/{type}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListResourcesResponse>(response);
        }

        public AsyncInvoker<ListResourcesResponse> ListResourcesAsyncInvoker(ListResourcesRequest listResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourcesRequest.Provider, out var valueOfProvider)) urlParam.Add("provider", valueOfProvider);
            if (StringUtils.TryConvertToNonEmptyString(listResourcesRequest.Type, out var valueOfType)) urlParam.Add("type", valueOfType);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/provider/{provider}/type/{type}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesRequest);
            return new AsyncInvoker<ListResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourcesResponse>);
        }
        
        /// <summary>
        /// 列举资源记录器收集的资源标签
        ///
        /// 查询当前用户资源记录器收集的资源的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTrackedResourceTagsResponse> ListTrackedResourceTagsAsync(ListTrackedResourceTagsRequest listTrackedResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracked-resources/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrackedResourceTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTrackedResourceTagsResponse>(response);
        }

        public AsyncInvoker<ListTrackedResourceTagsResponse> ListTrackedResourceTagsAsyncInvoker(ListTrackedResourceTagsRequest listTrackedResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracked-resources/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrackedResourceTagsRequest);
            return new AsyncInvoker<ListTrackedResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTrackedResourceTagsResponse>);
        }
        
        /// <summary>
        /// 列举资源记录器收集的全部资源
        ///
        /// 查询当前用户资源记录器收集的全部资源，需要当前用户有rms:resources:list权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTrackedResourcesResponse> ListTrackedResourcesAsync(ListTrackedResourcesRequest listTrackedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracked-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrackedResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTrackedResourcesResponse>(response);
        }

        public AsyncInvoker<ListTrackedResourcesResponse> ListTrackedResourcesAsyncInvoker(ListTrackedResourcesRequest listTrackedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracked-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrackedResourcesRequest);
            return new AsyncInvoker<ListTrackedResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTrackedResourcesResponse>);
        }
        
        /// <summary>
        /// 查询单个资源
        ///
        /// 指定资源ID，返回该资源的详细信息，需要当前用户有rms:resources:get权限。比如查询云服务器，对应的Config资源类型是ecs.cloudservers，其中provider为ecs，type为cloudservers。Config支持的服务和资源类型参见[支持的服务和区域](https://console.huaweicloud.com/eps/#/resources/supported)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceByIdResponse> ShowResourceByIdAsync(ShowResourceByIdRequest showResourceByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceByIdRequest.Provider, out var valueOfProvider)) urlParam.Add("provider", valueOfProvider);
            if (StringUtils.TryConvertToNonEmptyString(showResourceByIdRequest.Type, out var valueOfType)) urlParam.Add("type", valueOfType);
            if (StringUtils.TryConvertToNonEmptyString(showResourceByIdRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/provider/{provider}/type/{type}/resources/{resource_id}", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/provider/{provider}/type/{type}/resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceByIdRequest);
            return new AsyncInvoker<ShowResourceByIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceByIdResponse>);
        }
        
        /// <summary>
        /// 查询帐号下的单个资源
        ///
        /// 查询当前帐号下的单个资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceDetailResponse> ShowResourceDetailAsync(ShowResourceDetailRequest showResourceDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceDetailRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceDetailResponse>(response);
        }

        public AsyncInvoker<ShowResourceDetailResponse> ShowResourceDetailAsyncInvoker(ShowResourceDetailRequest showResourceDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceDetailRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceDetailRequest);
            return new AsyncInvoker<ShowResourceDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceDetailResponse>);
        }
        
        /// <summary>
        /// 查询资源记录器收集的单个资源
        ///
        /// 查询当前用户资源记录器收集的单个资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTrackedResourceDetailResponse> ShowTrackedResourceDetailAsync(ShowTrackedResourceDetailRequest showTrackedResourceDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTrackedResourceDetailRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracked-resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrackedResourceDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTrackedResourceDetailResponse>(response);
        }

        public AsyncInvoker<ShowTrackedResourceDetailResponse> ShowTrackedResourceDetailAsyncInvoker(ShowTrackedResourceDetailRequest showTrackedResourceDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTrackedResourceDetailRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracked-resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrackedResourceDetailRequest);
            return new AsyncInvoker<ShowTrackedResourceDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrackedResourceDetailResponse>);
        }
        
        /// <summary>
        /// 查询资源实例数量
        ///
        /// 使用标签过滤实例，标签管理服务需要提供按标签过滤各服务实例并汇总显示在列表中，需要各服务提供查询能力。注意：tags, tags_any, not_tags, not_tags_any等字段支持的tag的数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountResourcesByTagResponse> CountResourcesByTagAsync(CountResourcesByTagRequest countResourcesByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countResourcesByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countResourcesByTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CountResourcesByTagResponse>(response);
        }

        public AsyncInvoker<CountResourcesByTagResponse> CountResourcesByTagAsyncInvoker(CountResourcesByTagRequest countResourcesByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countResourcesByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countResourcesByTagRequest);
            return new AsyncInvoker<CountResourcesByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<CountResourcesByTagResponse>);
        }
        
        /// <summary>
        /// 查询资源实例列表
        ///
        /// 使用标签过滤实例，标签管理服务需要提供按标签过滤各服务实例并汇总显示在列表中，需要各服务提供查询能力。注意：tags, tags_any, not_tags, not_tags_any等字段支持的tag的数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourcesByTagResponse> ListResourcesByTagAsync(ListResourcesByTagRequest listResourcesByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourcesByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesByTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListResourcesByTagResponse>(response);
        }

        public AsyncInvoker<ListResourcesByTagResponse> ListResourcesByTagAsyncInvoker(ListResourcesByTagRequest listResourcesByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourcesByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesByTagRequest);
            return new AsyncInvoker<ListResourcesByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourcesByTagResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询指定实例的标签信息。标签管理服务需要使用该接口查询指定实例的全部标签数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest listTagsForResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagsForResourceRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listTagsForResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsForResourceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTagsForResourceResponse>(response);
        }

        public AsyncInvoker<ListTagsForResourceResponse> ListTagsForResourceAsyncInvoker(ListTagsForResourceRequest listTagsForResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagsForResourceRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listTagsForResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsForResourceRequest);
            return new AsyncInvoker<ListTagsForResourceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagsForResourceResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询租户在指定Project中实例类型的所有资源标签集合。标签管理服务需要能够列出当前租户全部已使用的资源标签集合，为各服务Console打资源标签和过滤实例时提供标签联想功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTagsForResourceTypeResponse> ListTagsForResourceTypeAsync(ListTagsForResourceTypeRequest listTagsForResourceTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagsForResourceTypeRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsForResourceTypeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTagsForResourceTypeResponse>(response);
        }

        public AsyncInvoker<ListTagsForResourceTypeResponse> ListTagsForResourceTypeAsyncInvoker(ListTagsForResourceTypeRequest listTagsForResourceTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagsForResourceTypeRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsForResourceTypeRequest);
            return new AsyncInvoker<ListTagsForResourceTypeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagsForResourceTypeResponse>);
        }
        
        /// <summary>
        /// 批量添加资源标签
        ///
        /// 此接口为幂等接口。为指定实例批量添加或删除标签，标签管理服务需要使用该接口批量管理实例的标签。一个资源上最多有20个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<TagResourceResponse> TagResourceAsync(TagResourceRequest tagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(tagResourceRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(tagResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagResourceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<TagResourceResponse>(response);
        }

        public AsyncInvoker<TagResourceResponse> TagResourceAsyncInvoker(TagResourceRequest tagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(tagResourceRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(tagResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagResourceRequest);
            return new AsyncInvoker<TagResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<TagResourceResponse>);
        }
        
        /// <summary>
        /// 批量删除资源标签
        ///
        /// 此接口为幂等接口。为指定实例批量添加或删除标签，标签管理服务需要使用该接口批量管理实例的标签。一个资源上最多有20个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UnTagResourceResponse> UnTagResourceAsync(UnTagResourceRequest unTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unTagResourceRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(unTagResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unTagResourceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UnTagResourceResponse>(response);
        }

        public AsyncInvoker<UnTagResourceResponse> UnTagResourceAsyncInvoker(UnTagResourceRequest unTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unTagResourceRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(unTagResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unTagResourceRequest);
            return new AsyncInvoker<UnTagResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UnTagResourceResponse>);
        }
        
        /// <summary>
        /// 创建或更新记录器
        ///
        /// 创建或更新资源记录器，只能存在一个资源记录器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTrackerConfigResponse> CreateTrackerConfigAsync(CreateTrackerConfigRequest createTrackerConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracker-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrackerConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<CreateTrackerConfigResponse>(response);
        }

        public AsyncInvoker<CreateTrackerConfigResponse> CreateTrackerConfigAsyncInvoker(CreateTrackerConfigRequest createTrackerConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracker-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrackerConfigRequest);
            return new AsyncInvoker<CreateTrackerConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<CreateTrackerConfigResponse>);
        }
        
        /// <summary>
        /// 删除记录器
        ///
        /// 删除资源记录器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTrackerConfigResponse> DeleteTrackerConfigAsync(DeleteTrackerConfigRequest deleteTrackerConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracker-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrackerConfigRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTrackerConfigResponse>(response);
        }

        public AsyncInvoker<DeleteTrackerConfigResponse> DeleteTrackerConfigAsyncInvoker(DeleteTrackerConfigRequest deleteTrackerConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracker-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrackerConfigRequest);
            return new AsyncInvoker<DeleteTrackerConfigResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTrackerConfigResponse>);
        }
        
        /// <summary>
        /// 查询记录器
        ///
        /// 查询资源记录器的详细信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTrackerConfigResponse> ShowTrackerConfigAsync(ShowTrackerConfigRequest showTrackerConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracker-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrackerConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTrackerConfigResponse>(response);
        }

        public AsyncInvoker<ShowTrackerConfigResponse> ShowTrackerConfigAsyncInvoker(ShowTrackerConfigRequest showTrackerConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracker-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrackerConfigRequest);
            return new AsyncInvoker<ShowTrackerConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrackerConfigResponse>);
        }
        
    }
}