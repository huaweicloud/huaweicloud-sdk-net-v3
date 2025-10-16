using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Config.V1.Model;

namespace HuaweiCloud.SDK.Config.V1
{
    public partial class ConfigClient : Client
    {
        public static ClientBuilder<ConfigClient> NewBuilder()
        {
            return new ClientBuilder<ConfigClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 创建资源聚合器授权
        ///
        /// 给资源聚合器帐号授予从源帐号收集数据的权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAggregationAuthorizationResponse CreateAggregationAuthorization(CreateAggregationAuthorizationRequest createAggregationAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregation-authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAggregationAuthorizationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<CreateAggregationAuthorizationResponse>(response);
        }

        public SyncInvoker<CreateAggregationAuthorizationResponse> CreateAggregationAuthorizationInvoker(CreateAggregationAuthorizationRequest createAggregationAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregation-authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAggregationAuthorizationRequest);
            return new SyncInvoker<CreateAggregationAuthorizationResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreateAggregationAuthorizationResponse>);
        }
        
        /// <summary>
        /// 创建资源聚合器
        ///
        /// 创建资源聚合器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateConfigurationAggregatorResponse CreateConfigurationAggregator(CreateConfigurationAggregatorRequest createConfigurationAggregatorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfigurationAggregatorRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<CreateConfigurationAggregatorResponse>(response);
        }

        public SyncInvoker<CreateConfigurationAggregatorResponse> CreateConfigurationAggregatorInvoker(CreateConfigurationAggregatorRequest createConfigurationAggregatorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfigurationAggregatorRequest);
            return new SyncInvoker<CreateConfigurationAggregatorResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreateConfigurationAggregatorResponse>);
        }
        
        /// <summary>
        /// 删除资源聚合器授权
        ///
        /// 删除指定资源聚合器帐号的授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAggregationAuthorizationResponse DeleteAggregationAuthorization(DeleteAggregationAuthorizationRequest deleteAggregationAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAggregationAuthorizationRequest.AuthorizedAccountId, out var valueOfAuthorizedAccountId)) urlParam.Add("authorized_account_id", valueOfAuthorizedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregation-authorization/{authorized_account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAggregationAuthorizationRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAggregationAuthorizationResponse>(response);
        }

        public SyncInvoker<DeleteAggregationAuthorizationResponse> DeleteAggregationAuthorizationInvoker(DeleteAggregationAuthorizationRequest deleteAggregationAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAggregationAuthorizationRequest.AuthorizedAccountId, out var valueOfAuthorizedAccountId)) urlParam.Add("authorized_account_id", valueOfAuthorizedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregation-authorization/{authorized_account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAggregationAuthorizationRequest);
            return new SyncInvoker<DeleteAggregationAuthorizationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAggregationAuthorizationResponse>);
        }
        
        /// <summary>
        /// 删除资源聚合器
        ///
        /// 删除资源聚合器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteConfigurationAggregatorResponse DeleteConfigurationAggregator(DeleteConfigurationAggregatorRequest deleteConfigurationAggregatorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConfigurationAggregatorRequest.AggregatorId, out var valueOfAggregatorId)) urlParam.Add("aggregator_id", valueOfAggregatorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/{aggregator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigurationAggregatorRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteConfigurationAggregatorResponse>(response);
        }

        public SyncInvoker<DeleteConfigurationAggregatorResponse> DeleteConfigurationAggregatorInvoker(DeleteConfigurationAggregatorRequest deleteConfigurationAggregatorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConfigurationAggregatorRequest.AggregatorId, out var valueOfAggregatorId)) urlParam.Add("aggregator_id", valueOfAggregatorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/{aggregator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigurationAggregatorRequest);
            return new SyncInvoker<DeleteConfigurationAggregatorResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteConfigurationAggregatorResponse>);
        }
        
        /// <summary>
        /// 删除聚合器帐号中挂起的授权请求
        ///
        /// 删除聚合器帐号中挂起的授权请求。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePendingAggregationRequestResponse DeletePendingAggregationRequest(DeletePendingAggregationRequestRequest deletePendingAggregationRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePendingAggregationRequestRequest.RequesterAccountId, out var valueOfRequesterAccountId)) urlParam.Add("requester_account_id", valueOfRequesterAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/pending-aggregation-request/{requester_account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePendingAggregationRequestRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePendingAggregationRequestResponse>(response);
        }

        public SyncInvoker<DeletePendingAggregationRequestResponse> DeletePendingAggregationRequestInvoker(DeletePendingAggregationRequestRequest deletePendingAggregationRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePendingAggregationRequestRequest.RequesterAccountId, out var valueOfRequesterAccountId)) urlParam.Add("requester_account_id", valueOfRequesterAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/pending-aggregation-request/{requester_account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePendingAggregationRequestRequest);
            return new SyncInvoker<DeletePendingAggregationRequestResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePendingAggregationRequestResponse>);
        }
        
        /// <summary>
        /// 查询聚合合规规则列表
        ///
        /// 查询合规和不合规规则的列表，其中包含合规和不合规规则的资源数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAggregateComplianceByPolicyAssignmentResponse ListAggregateComplianceByPolicyAssignment(ListAggregateComplianceByPolicyAssignmentRequest listAggregateComplianceByPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/policy-assignments/compliance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAggregateComplianceByPolicyAssignmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAggregateComplianceByPolicyAssignmentResponse>(response);
        }

        public SyncInvoker<ListAggregateComplianceByPolicyAssignmentResponse> ListAggregateComplianceByPolicyAssignmentInvoker(ListAggregateComplianceByPolicyAssignmentRequest listAggregateComplianceByPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/policy-assignments/compliance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAggregateComplianceByPolicyAssignmentRequest);
            return new SyncInvoker<ListAggregateComplianceByPolicyAssignmentResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAggregateComplianceByPolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 查询聚合器中资源的列表
        ///
        /// 查询资源聚合器中特定资源的列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAggregateDiscoveredResourcesResponse ListAggregateDiscoveredResources(ListAggregateDiscoveredResourcesRequest listAggregateDiscoveredResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/aggregate-discovered-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAggregateDiscoveredResourcesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAggregateDiscoveredResourcesResponse>(response);
        }

        public SyncInvoker<ListAggregateDiscoveredResourcesResponse> ListAggregateDiscoveredResourcesInvoker(ListAggregateDiscoveredResourcesRequest listAggregateDiscoveredResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/aggregate-discovered-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAggregateDiscoveredResourcesRequest);
            return new SyncInvoker<ListAggregateDiscoveredResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAggregateDiscoveredResourcesResponse>);
        }
        
        /// <summary>
        /// 查询资源聚合器授权列表
        ///
        /// 查询授权过的资源聚合器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAggregationAuthorizationsResponse ListAggregationAuthorizations(ListAggregationAuthorizationsRequest listAggregationAuthorizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregation-authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAggregationAuthorizationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAggregationAuthorizationsResponse>(response);
        }

        public SyncInvoker<ListAggregationAuthorizationsResponse> ListAggregationAuthorizationsInvoker(ListAggregationAuthorizationsRequest listAggregationAuthorizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregation-authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAggregationAuthorizationsRequest);
            return new SyncInvoker<ListAggregationAuthorizationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAggregationAuthorizationsResponse>);
        }
        
        /// <summary>
        /// 查询资源聚合器列表
        ///
        /// 查询资源聚合器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConfigurationAggregatorsResponse ListConfigurationAggregators(ListConfigurationAggregatorsRequest listConfigurationAggregatorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationAggregatorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListConfigurationAggregatorsResponse>(response);
        }

        public SyncInvoker<ListConfigurationAggregatorsResponse> ListConfigurationAggregatorsInvoker(ListConfigurationAggregatorsRequest listConfigurationAggregatorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationAggregatorsRequest);
            return new SyncInvoker<ListConfigurationAggregatorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigurationAggregatorsResponse>);
        }
        
        /// <summary>
        /// 查询所有挂起的聚合请求列表
        ///
        /// 查询所有挂起的聚合请求列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPendingAggregationRequestsResponse ListPendingAggregationRequests(ListPendingAggregationRequestsRequest listPendingAggregationRequestsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/pending-aggregation-request", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPendingAggregationRequestsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPendingAggregationRequestsResponse>(response);
        }

        public SyncInvoker<ListPendingAggregationRequestsResponse> ListPendingAggregationRequestsInvoker(ListPendingAggregationRequestsRequest listPendingAggregationRequestsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/pending-aggregation-request", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPendingAggregationRequestsRequest);
            return new SyncInvoker<ListPendingAggregationRequestsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPendingAggregationRequestsResponse>);
        }
        
        /// <summary>
        /// 对指定聚合器执行高级查询
        ///
        /// 对指定聚合器执行高级查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunAggregateResourceQueryResponse RunAggregateResourceQuery(RunAggregateResourceQueryRequest runAggregateResourceQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runAggregateResourceQueryRequest.AggregatorId, out var valueOfAggregatorId)) urlParam.Add("aggregator_id", valueOfAggregatorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/{aggregator_id}/run-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runAggregateResourceQueryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunAggregateResourceQueryResponse>(response);
        }

        public SyncInvoker<RunAggregateResourceQueryResponse> RunAggregateResourceQueryInvoker(RunAggregateResourceQueryRequest runAggregateResourceQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runAggregateResourceQueryRequest.AggregatorId, out var valueOfAggregatorId)) urlParam.Add("aggregator_id", valueOfAggregatorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/{aggregator_id}/run-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runAggregateResourceQueryRequest);
            return new SyncInvoker<RunAggregateResourceQueryResponse>(this, "POST", request, JsonUtils.DeSerialize<RunAggregateResourceQueryResponse>);
        }
        
        /// <summary>
        /// 查询指定聚合合规规则的评估结果详情
        ///
        /// 返回指定聚合合规规则的评估结果详情。包含评估了哪些资源，以及每个资源是否符合规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAggregateComplianceDetailsByPolicyAssignmentResponse ShowAggregateComplianceDetailsByPolicyAssignment(ShowAggregateComplianceDetailsByPolicyAssignmentRequest showAggregateComplianceDetailsByPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/policy-states/compliance-details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAggregateComplianceDetailsByPolicyAssignmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowAggregateComplianceDetailsByPolicyAssignmentResponse>(response);
        }

        public SyncInvoker<ShowAggregateComplianceDetailsByPolicyAssignmentResponse> ShowAggregateComplianceDetailsByPolicyAssignmentInvoker(ShowAggregateComplianceDetailsByPolicyAssignmentRequest showAggregateComplianceDetailsByPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/policy-states/compliance-details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAggregateComplianceDetailsByPolicyAssignmentRequest);
            return new SyncInvoker<ShowAggregateComplianceDetailsByPolicyAssignmentResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowAggregateComplianceDetailsByPolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 查询聚合器中帐号资源的计数
        ///
        /// 查询聚合器中帐号资源的计数，支持通过过滤器和GroupByKey来统计资源数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAggregateDiscoveredResourceCountsResponse ShowAggregateDiscoveredResourceCounts(ShowAggregateDiscoveredResourceCountsRequest showAggregateDiscoveredResourceCountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/aggregate-discovered-resource-counts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAggregateDiscoveredResourceCountsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowAggregateDiscoveredResourceCountsResponse>(response);
        }

        public SyncInvoker<ShowAggregateDiscoveredResourceCountsResponse> ShowAggregateDiscoveredResourceCountsInvoker(ShowAggregateDiscoveredResourceCountsRequest showAggregateDiscoveredResourceCountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/aggregate-discovered-resource-counts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAggregateDiscoveredResourceCountsRequest);
            return new SyncInvoker<ShowAggregateDiscoveredResourceCountsResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowAggregateDiscoveredResourceCountsResponse>);
        }
        
        /// <summary>
        /// 查询指定聚合合规规则详情
        ///
        /// 返回指定聚合合规规则详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAggregatePolicyAssignmentDetailResponse ShowAggregatePolicyAssignmentDetail(ShowAggregatePolicyAssignmentDetailRequest showAggregatePolicyAssignmentDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/policy-assignment/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAggregatePolicyAssignmentDetailRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowAggregatePolicyAssignmentDetailResponse>(response);
        }

        public SyncInvoker<ShowAggregatePolicyAssignmentDetailResponse> ShowAggregatePolicyAssignmentDetailInvoker(ShowAggregatePolicyAssignmentDetailRequest showAggregatePolicyAssignmentDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/policy-assignment/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAggregatePolicyAssignmentDetailRequest);
            return new SyncInvoker<ShowAggregatePolicyAssignmentDetailResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowAggregatePolicyAssignmentDetailResponse>);
        }
        
        /// <summary>
        /// 查询聚合器中一个或多个帐户的合规概况
        ///
        /// 查询聚合器中一个或多个帐户的合规和不合规规则数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAggregatePolicyStateComplianceSummaryResponse ShowAggregatePolicyStateComplianceSummary(ShowAggregatePolicyStateComplianceSummaryRequest showAggregatePolicyStateComplianceSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/policy-states/compliance-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAggregatePolicyStateComplianceSummaryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowAggregatePolicyStateComplianceSummaryResponse>(response);
        }

        public SyncInvoker<ShowAggregatePolicyStateComplianceSummaryResponse> ShowAggregatePolicyStateComplianceSummaryInvoker(ShowAggregatePolicyStateComplianceSummaryRequest showAggregatePolicyStateComplianceSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-data/policy-states/compliance-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAggregatePolicyStateComplianceSummaryRequest);
            return new SyncInvoker<ShowAggregatePolicyStateComplianceSummaryResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowAggregatePolicyStateComplianceSummaryResponse>);
        }
        
        /// <summary>
        /// 查询源帐号中资源的详情
        ///
        /// 查询源帐号中特定资源的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAggregateResourceConfigResponse ShowAggregateResourceConfig(ShowAggregateResourceConfigRequest showAggregateResourceConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-resource-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAggregateResourceConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowAggregateResourceConfigResponse>(response);
        }

        public SyncInvoker<ShowAggregateResourceConfigResponse> ShowAggregateResourceConfigInvoker(ShowAggregateResourceConfigRequest showAggregateResourceConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/aggregate-resource-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAggregateResourceConfigRequest);
            return new SyncInvoker<ShowAggregateResourceConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowAggregateResourceConfigResponse>);
        }
        
        /// <summary>
        /// 查询指定资源聚合器
        ///
        /// 查询指定资源聚合器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConfigurationAggregatorResponse ShowConfigurationAggregator(ShowConfigurationAggregatorRequest showConfigurationAggregatorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigurationAggregatorRequest.AggregatorId, out var valueOfAggregatorId)) urlParam.Add("aggregator_id", valueOfAggregatorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/{aggregator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationAggregatorRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigurationAggregatorResponse>(response);
        }

        public SyncInvoker<ShowConfigurationAggregatorResponse> ShowConfigurationAggregatorInvoker(ShowConfigurationAggregatorRequest showConfigurationAggregatorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigurationAggregatorRequest.AggregatorId, out var valueOfAggregatorId)) urlParam.Add("aggregator_id", valueOfAggregatorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/{aggregator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationAggregatorRequest);
            return new SyncInvoker<ShowConfigurationAggregatorResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigurationAggregatorResponse>);
        }
        
        /// <summary>
        /// 查询指定资源聚合器聚合帐号的状态信息
        ///
        /// 查询指定资源聚合器聚合帐号的状态信息，状态包括验证源帐号和聚合器帐号之间授权的信息。如果失败，状态包含相关的错误码或消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConfigurationAggregatorSourcesStatusResponse ShowConfigurationAggregatorSourcesStatus(ShowConfigurationAggregatorSourcesStatusRequest showConfigurationAggregatorSourcesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigurationAggregatorSourcesStatusRequest.AggregatorId, out var valueOfAggregatorId)) urlParam.Add("aggregator_id", valueOfAggregatorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/{aggregator_id}/aggregator-sources-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationAggregatorSourcesStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigurationAggregatorSourcesStatusResponse>(response);
        }

        public SyncInvoker<ShowConfigurationAggregatorSourcesStatusResponse> ShowConfigurationAggregatorSourcesStatusInvoker(ShowConfigurationAggregatorSourcesStatusRequest showConfigurationAggregatorSourcesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigurationAggregatorSourcesStatusRequest.AggregatorId, out var valueOfAggregatorId)) urlParam.Add("aggregator_id", valueOfAggregatorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/{aggregator_id}/aggregator-sources-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationAggregatorSourcesStatusRequest);
            return new SyncInvoker<ShowConfigurationAggregatorSourcesStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigurationAggregatorSourcesStatusResponse>);
        }
        
        /// <summary>
        /// 更新资源聚合器
        ///
        /// 更新资源聚合器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateConfigurationAggregatorResponse UpdateConfigurationAggregator(UpdateConfigurationAggregatorRequest updateConfigurationAggregatorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateConfigurationAggregatorRequest.AggregatorId, out var valueOfAggregatorId)) urlParam.Add("aggregator_id", valueOfAggregatorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/{aggregator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigurationAggregatorRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateConfigurationAggregatorResponse>(response);
        }

        public SyncInvoker<UpdateConfigurationAggregatorResponse> UpdateConfigurationAggregatorInvoker(UpdateConfigurationAggregatorRequest updateConfigurationAggregatorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateConfigurationAggregatorRequest.AggregatorId, out var valueOfAggregatorId)) urlParam.Add("aggregator_id", valueOfAggregatorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/aggregators/{aggregator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigurationAggregatorRequest);
            return new SyncInvoker<UpdateConfigurationAggregatorResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateConfigurationAggregatorResponse>);
        }
        
        /// <summary>
        /// 列举合规规则包的结果概览
        ///
        /// 列举用户的合规规则包的合规结果概览。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CollectConformancePackComplianceSummaryResponse CollectConformancePackComplianceSummary(CollectConformancePackComplianceSummaryRequest collectConformancePackComplianceSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/compliance/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectConformancePackComplianceSummaryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CollectConformancePackComplianceSummaryResponse>(response);
        }

        public SyncInvoker<CollectConformancePackComplianceSummaryResponse> CollectConformancePackComplianceSummaryInvoker(CollectConformancePackComplianceSummaryRequest collectConformancePackComplianceSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/compliance/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectConformancePackComplianceSummaryRequest);
            return new SyncInvoker<CollectConformancePackComplianceSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<CollectConformancePackComplianceSummaryResponse>);
        }
        
        /// <summary>
        /// 创建合规规则包
        ///
        /// 创建新的合规规则包。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateConformancePackResponse CreateConformancePack(CreateConformancePackRequest createConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConformancePackRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateConformancePackResponse>(response);
        }

        public SyncInvoker<CreateConformancePackResponse> CreateConformancePackInvoker(CreateConformancePackRequest createConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConformancePackRequest);
            return new SyncInvoker<CreateConformancePackResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateConformancePackResponse>);
        }
        
        /// <summary>
        /// 创建组织合规规则包
        ///
        /// 创建新的组织合规规则包。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOrganizationConformancePackResponse CreateOrganizationConformancePack(CreateOrganizationConformancePackRequest createOrganizationConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createOrganizationConformancePackRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrganizationConformancePackRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateOrganizationConformancePackResponse>(response);
        }

        public SyncInvoker<CreateOrganizationConformancePackResponse> CreateOrganizationConformancePackInvoker(CreateOrganizationConformancePackRequest createOrganizationConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createOrganizationConformancePackRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrganizationConformancePackRequest);
            return new SyncInvoker<CreateOrganizationConformancePackResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOrganizationConformancePackResponse>);
        }
        
        /// <summary>
        /// 删除合规规则包
        ///
        /// 删除用户的合规规则包。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteConformancePackResponse DeleteConformancePack(DeleteConformancePackRequest deleteConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConformancePackRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteConformancePackResponse>(response);
        }

        public SyncInvoker<DeleteConformancePackResponse> DeleteConformancePackInvoker(DeleteConformancePackRequest deleteConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConformancePackRequest);
            return new SyncInvoker<DeleteConformancePackResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteConformancePackResponse>);
        }
        
        /// <summary>
        /// 删除组织合规规则包
        ///
        /// 删除用户的组织合规规则包。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteOrganizationConformancePackResponse DeleteOrganizationConformancePack(DeleteOrganizationConformancePackRequest deleteOrganizationConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOrganizationConformancePackRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(deleteOrganizationConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOrganizationConformancePackRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteOrganizationConformancePackResponse>(response);
        }

        public SyncInvoker<DeleteOrganizationConformancePackResponse> DeleteOrganizationConformancePackInvoker(DeleteOrganizationConformancePackRequest deleteOrganizationConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOrganizationConformancePackRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(deleteOrganizationConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOrganizationConformancePackRequest);
            return new SyncInvoker<DeleteOrganizationConformancePackResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteOrganizationConformancePackResponse>);
        }
        
        /// <summary>
        /// 列举预定义合规规则包模板
        ///
        /// 列举预定义的合规规则包的模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBuiltInConformancePackTemplatesResponse ListBuiltInConformancePackTemplates(ListBuiltInConformancePackTemplatesRequest listBuiltInConformancePackTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/conformance-packs/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBuiltInConformancePackTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBuiltInConformancePackTemplatesResponse>(response);
        }

        public SyncInvoker<ListBuiltInConformancePackTemplatesResponse> ListBuiltInConformancePackTemplatesInvoker(ListBuiltInConformancePackTemplatesRequest listBuiltInConformancePackTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/conformance-packs/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBuiltInConformancePackTemplatesRequest);
            return new SyncInvoker<ListBuiltInConformancePackTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBuiltInConformancePackTemplatesResponse>);
        }
        
        /// <summary>
        /// 列举合规规则包的评估结果
        ///
        /// 列举合规规则包的合规规则评估结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConformancePackComplianceByPackIdResponse ListConformancePackComplianceByPackId(ListConformancePackComplianceByPackIdRequest listConformancePackComplianceByPackIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listConformancePackComplianceByPackIdRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/{conformance_pack_id}/compliance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConformancePackComplianceByPackIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListConformancePackComplianceByPackIdResponse>(response);
        }

        public SyncInvoker<ListConformancePackComplianceByPackIdResponse> ListConformancePackComplianceByPackIdInvoker(ListConformancePackComplianceByPackIdRequest listConformancePackComplianceByPackIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listConformancePackComplianceByPackIdRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/{conformance_pack_id}/compliance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConformancePackComplianceByPackIdRequest);
            return new SyncInvoker<ListConformancePackComplianceByPackIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConformancePackComplianceByPackIdResponse>);
        }
        
        /// <summary>
        /// 列举合规规则包的评估结果详情
        ///
        /// 列举合规规则包的合规规则评估结果详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConformancePackComplianceDetailsByPackIdResponse ListConformancePackComplianceDetailsByPackId(ListConformancePackComplianceDetailsByPackIdRequest listConformancePackComplianceDetailsByPackIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listConformancePackComplianceDetailsByPackIdRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/{conformance_pack_id}/compliance/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConformancePackComplianceDetailsByPackIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListConformancePackComplianceDetailsByPackIdResponse>(response);
        }

        public SyncInvoker<ListConformancePackComplianceDetailsByPackIdResponse> ListConformancePackComplianceDetailsByPackIdInvoker(ListConformancePackComplianceDetailsByPackIdRequest listConformancePackComplianceDetailsByPackIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listConformancePackComplianceDetailsByPackIdRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/{conformance_pack_id}/compliance/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConformancePackComplianceDetailsByPackIdRequest);
            return new SyncInvoker<ListConformancePackComplianceDetailsByPackIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConformancePackComplianceDetailsByPackIdResponse>);
        }
        
        /// <summary>
        /// 列举合规规则包分数
        ///
        /// 列举用户的合规规则包分数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConformancePackComplianceScoresResponse ListConformancePackComplianceScores(ListConformancePackComplianceScoresRequest listConformancePackComplianceScoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/scores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConformancePackComplianceScoresRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListConformancePackComplianceScoresResponse>(response);
        }

        public SyncInvoker<ListConformancePackComplianceScoresResponse> ListConformancePackComplianceScoresInvoker(ListConformancePackComplianceScoresRequest listConformancePackComplianceScoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/scores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConformancePackComplianceScoresRequest);
            return new SyncInvoker<ListConformancePackComplianceScoresResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConformancePackComplianceScoresResponse>);
        }
        
        /// <summary>
        /// 列举合规规则包
        ///
        /// 列举用户的合规规则包。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConformancePacksResponse ListConformancePacks(ListConformancePacksRequest listConformancePacksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConformancePacksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListConformancePacksResponse>(response);
        }

        public SyncInvoker<ListConformancePacksResponse> ListConformancePacksInvoker(ListConformancePacksRequest listConformancePacksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConformancePacksRequest);
            return new SyncInvoker<ListConformancePacksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConformancePacksResponse>);
        }
        
        /// <summary>
        /// 查看组织合规规则包部署状态
        ///
        /// 列举用户的组织合规规则包部署状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOrganizationConformancePackStatusesResponse ListOrganizationConformancePackStatuses(ListOrganizationConformancePackStatusesRequest listOrganizationConformancePackStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOrganizationConformancePackStatusesRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationConformancePackStatusesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOrganizationConformancePackStatusesResponse>(response);
        }

        public SyncInvoker<ListOrganizationConformancePackStatusesResponse> ListOrganizationConformancePackStatusesInvoker(ListOrganizationConformancePackStatusesRequest listOrganizationConformancePackStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOrganizationConformancePackStatusesRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationConformancePackStatusesRequest);
            return new SyncInvoker<ListOrganizationConformancePackStatusesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOrganizationConformancePackStatusesResponse>);
        }
        
        /// <summary>
        /// 列举组织合规规则包
        ///
        /// 列举用户的组织合规规则包。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOrganizationConformancePacksResponse ListOrganizationConformancePacks(ListOrganizationConformancePacksRequest listOrganizationConformancePacksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOrganizationConformancePacksRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationConformancePacksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOrganizationConformancePacksResponse>(response);
        }

        public SyncInvoker<ListOrganizationConformancePacksResponse> ListOrganizationConformancePacksInvoker(ListOrganizationConformancePacksRequest listOrganizationConformancePacksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOrganizationConformancePacksRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationConformancePacksRequest);
            return new SyncInvoker<ListOrganizationConformancePacksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOrganizationConformancePacksResponse>);
        }
        
        /// <summary>
        /// 查看预定义合规规则包模板
        ///
        /// 根据ID获取单个预定义合规规则包模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBuiltInConformancePackTemplateResponse ShowBuiltInConformancePackTemplate(ShowBuiltInConformancePackTemplateRequest showBuiltInConformancePackTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBuiltInConformancePackTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/conformance-packs/templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuiltInConformancePackTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBuiltInConformancePackTemplateResponse>(response);
        }

        public SyncInvoker<ShowBuiltInConformancePackTemplateResponse> ShowBuiltInConformancePackTemplateInvoker(ShowBuiltInConformancePackTemplateRequest showBuiltInConformancePackTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBuiltInConformancePackTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/conformance-packs/templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuiltInConformancePackTemplateRequest);
            return new SyncInvoker<ShowBuiltInConformancePackTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBuiltInConformancePackTemplateResponse>);
        }
        
        /// <summary>
        /// 查看合规规则包
        ///
        /// 根据ID获取单个合规规则包。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConformancePackResponse ShowConformancePack(ShowConformancePackRequest showConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConformancePackRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowConformancePackResponse>(response);
        }

        public SyncInvoker<ShowConformancePackResponse> ShowConformancePackInvoker(ShowConformancePackRequest showConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConformancePackRequest);
            return new SyncInvoker<ShowConformancePackResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConformancePackResponse>);
        }
        
        /// <summary>
        /// 查看组织合规规则包
        ///
        /// 根据ID获取单个组织合规规则包详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOrganizationConformancePackResponse ShowOrganizationConformancePack(ShowOrganizationConformancePackRequest showOrganizationConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationConformancePackRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationConformancePackRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOrganizationConformancePackResponse>(response);
        }

        public SyncInvoker<ShowOrganizationConformancePackResponse> ShowOrganizationConformancePackInvoker(ShowOrganizationConformancePackRequest showOrganizationConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationConformancePackRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationConformancePackRequest);
            return new SyncInvoker<ShowOrganizationConformancePackResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOrganizationConformancePackResponse>);
        }
        
        /// <summary>
        /// 查看组织合规规则包部署详细状态
        ///
        /// 查看指定组织合规规则包在成员帐号中的部署状态详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOrganizationConformancePackDetailedStatusesResponse ShowOrganizationConformancePackDetailedStatuses(ShowOrganizationConformancePackDetailedStatusesRequest showOrganizationConformancePackDetailedStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationConformancePackDetailedStatusesRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs/detailed-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationConformancePackDetailedStatusesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOrganizationConformancePackDetailedStatusesResponse>(response);
        }

        public SyncInvoker<ShowOrganizationConformancePackDetailedStatusesResponse> ShowOrganizationConformancePackDetailedStatusesInvoker(ShowOrganizationConformancePackDetailedStatusesRequest showOrganizationConformancePackDetailedStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationConformancePackDetailedStatusesRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs/detailed-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationConformancePackDetailedStatusesRequest);
            return new SyncInvoker<ShowOrganizationConformancePackDetailedStatusesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOrganizationConformancePackDetailedStatusesResponse>);
        }
        
        /// <summary>
        /// 更新合规规则包
        ///
        /// 更新用户的合规规则包。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateConformancePackResponse UpdateConformancePack(UpdateConformancePackRequest updateConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConformancePackRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateConformancePackResponse>(response);
        }

        public SyncInvoker<UpdateConformancePackResponse> UpdateConformancePackInvoker(UpdateConformancePackRequest updateConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConformancePackRequest);
            return new SyncInvoker<UpdateConformancePackResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateConformancePackResponse>);
        }
        
        /// <summary>
        /// 更新组织合规规则包
        ///
        /// 更新用户的组织合规规则包。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateOrganizationConformancePackResponse UpdateOrganizationConformancePack(UpdateOrganizationConformancePackRequest updateOrganizationConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateOrganizationConformancePackRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(updateOrganizationConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOrganizationConformancePackRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateOrganizationConformancePackResponse>(response);
        }

        public SyncInvoker<UpdateOrganizationConformancePackResponse> UpdateOrganizationConformancePackInvoker(UpdateOrganizationConformancePackRequest updateOrganizationConformancePackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateOrganizationConformancePackRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(updateOrganizationConformancePackRequest.ConformancePackId, out var valueOfConformancePackId)) urlParam.Add("conformance_pack_id", valueOfConformancePackId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/conformance-packs/{conformance_pack_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOrganizationConformancePackRequest);
            return new SyncInvoker<UpdateOrganizationConformancePackResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateOrganizationConformancePackResponse>);
        }
        
        /// <summary>
        /// 查询资源历史
        ///
        /// 查询资源与资源关系的变更历史
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceHistoryResponse ShowResourceHistory(ShowResourceHistoryRequest showResourceHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceHistoryRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/resources/{resource_id}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceHistoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceHistoryResponse>(response);
        }

        public SyncInvoker<ShowResourceHistoryResponse> ShowResourceHistoryInvoker(ShowResourceHistoryRequest showResourceHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceHistoryRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/resources/{resource_id}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceHistoryRequest);
            return new SyncInvoker<ShowResourceHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceHistoryResponse>);
        }
        
        /// <summary>
        /// 批量创建修正例外
        ///
        /// 批量创建合规规则修正例外。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateRemediationExceptionsResponse BatchCreateRemediationExceptions(BatchCreateRemediationExceptionsRequest batchCreateRemediationExceptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateRemediationExceptionsRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-exception/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateRemediationExceptionsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateRemediationExceptionsResponse>(response);
        }

        public SyncInvoker<BatchCreateRemediationExceptionsResponse> BatchCreateRemediationExceptionsInvoker(BatchCreateRemediationExceptionsRequest batchCreateRemediationExceptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateRemediationExceptionsRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-exception/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateRemediationExceptionsRequest);
            return new SyncInvoker<BatchCreateRemediationExceptionsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateRemediationExceptionsResponse>);
        }
        
        /// <summary>
        /// 批量删除修正例外
        ///
        /// 批量删除合规规则修正例外。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteRemediationExceptionsResponse BatchDeleteRemediationExceptions(BatchDeleteRemediationExceptionsRequest batchDeleteRemediationExceptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteRemediationExceptionsRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-exception/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRemediationExceptionsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteRemediationExceptionsResponse>(response);
        }

        public SyncInvoker<BatchDeleteRemediationExceptionsResponse> BatchDeleteRemediationExceptionsInvoker(BatchDeleteRemediationExceptionsRequest batchDeleteRemediationExceptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteRemediationExceptionsRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-exception/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRemediationExceptionsRequest);
            return new SyncInvoker<BatchDeleteRemediationExceptionsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteRemediationExceptionsResponse>);
        }
        
        /// <summary>
        /// 查询规则的合规总结
        ///
        /// 根据规则ID查询此规则的合规总结
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CollectPolicyAssignmentsStatesSummaryResponse CollectPolicyAssignmentsStatesSummary(CollectPolicyAssignmentsStatesSummaryRequest collectPolicyAssignmentsStatesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(collectPolicyAssignmentsStatesSummaryRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/policy-states/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectPolicyAssignmentsStatesSummaryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CollectPolicyAssignmentsStatesSummaryResponse>(response);
        }

        public SyncInvoker<CollectPolicyAssignmentsStatesSummaryResponse> CollectPolicyAssignmentsStatesSummaryInvoker(CollectPolicyAssignmentsStatesSummaryRequest collectPolicyAssignmentsStatesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(collectPolicyAssignmentsStatesSummaryRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/policy-states/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectPolicyAssignmentsStatesSummaryRequest);
            return new SyncInvoker<CollectPolicyAssignmentsStatesSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<CollectPolicyAssignmentsStatesSummaryResponse>);
        }
        
        /// <summary>
        /// 查询用户的合规总结
        ///
        /// 查询用户的合规总结
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CollectPolicyStatesSummaryResponse CollectPolicyStatesSummary(CollectPolicyStatesSummaryRequest collectPolicyStatesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-states/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectPolicyStatesSummaryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CollectPolicyStatesSummaryResponse>(response);
        }

        public SyncInvoker<CollectPolicyStatesSummaryResponse> CollectPolicyStatesSummaryInvoker(CollectPolicyStatesSummaryRequest collectPolicyStatesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-states/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectPolicyStatesSummaryRequest);
            return new SyncInvoker<CollectPolicyStatesSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<CollectPolicyStatesSummaryResponse>);
        }
        
        /// <summary>
        /// 列举修正最新记录
        ///
        /// 列举合规规则修正最新记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CollectRemediationExecutionStatusesSummaryResponse CollectRemediationExecutionStatusesSummary(CollectRemediationExecutionStatusesSummaryRequest collectRemediationExecutionStatusesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(collectRemediationExecutionStatusesSummaryRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-execution-statuses/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectRemediationExecutionStatusesSummaryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CollectRemediationExecutionStatusesSummaryResponse>(response);
        }

        public SyncInvoker<CollectRemediationExecutionStatusesSummaryResponse> CollectRemediationExecutionStatusesSummaryInvoker(CollectRemediationExecutionStatusesSummaryRequest collectRemediationExecutionStatusesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(collectRemediationExecutionStatusesSummaryRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-execution-statuses/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectRemediationExecutionStatusesSummaryRequest);
            return new SyncInvoker<CollectRemediationExecutionStatusesSummaryResponse>(this, "POST", request, JsonUtils.DeSerialize<CollectRemediationExecutionStatusesSummaryResponse>);
        }
        
        /// <summary>
        /// 查询用户资源的合规总结
        ///
        /// 查询用户资源的合规总结
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CollectResourcesPolicyStatesSummaryResponse CollectResourcesPolicyStatesSummary(CollectResourcesPolicyStatesSummaryRequest collectResourcesPolicyStatesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/resources/policy-states/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectResourcesPolicyStatesSummaryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CollectResourcesPolicyStatesSummaryResponse>(response);
        }

        public SyncInvoker<CollectResourcesPolicyStatesSummaryResponse> CollectResourcesPolicyStatesSummaryInvoker(CollectResourcesPolicyStatesSummaryRequest collectResourcesPolicyStatesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/resources/policy-states/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectResourcesPolicyStatesSummaryRequest);
            return new SyncInvoker<CollectResourcesPolicyStatesSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<CollectResourcesPolicyStatesSummaryResponse>);
        }
        
        /// <summary>
        /// 创建或更新修正配置
        ///
        /// 创建或更新合规规则修正配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOrUpdateRemediationConfigurationResponse CreateOrUpdateRemediationConfiguration(CreateOrUpdateRemediationConfigurationRequest createOrUpdateRemediationConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createOrUpdateRemediationConfigurationRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrUpdateRemediationConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<CreateOrUpdateRemediationConfigurationResponse>(response);
        }

        public SyncInvoker<CreateOrUpdateRemediationConfigurationResponse> CreateOrUpdateRemediationConfigurationInvoker(CreateOrUpdateRemediationConfigurationRequest createOrUpdateRemediationConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createOrUpdateRemediationConfigurationRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrUpdateRemediationConfigurationRequest);
            return new SyncInvoker<CreateOrUpdateRemediationConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreateOrUpdateRemediationConfigurationResponse>);
        }
        
        /// <summary>
        /// 创建组织合规规则
        ///
        /// 创建组织合规规则，如果规则名称已存在，则为更新操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOrganizationPolicyAssignmentResponse CreateOrganizationPolicyAssignment(CreateOrganizationPolicyAssignmentRequest createOrganizationPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createOrganizationPolicyAssignmentRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrganizationPolicyAssignmentRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<CreateOrganizationPolicyAssignmentResponse>(response);
        }

        public SyncInvoker<CreateOrganizationPolicyAssignmentResponse> CreateOrganizationPolicyAssignmentInvoker(CreateOrganizationPolicyAssignmentRequest createOrganizationPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createOrganizationPolicyAssignmentRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrganizationPolicyAssignmentRequest);
            return new SyncInvoker<CreateOrganizationPolicyAssignmentResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreateOrganizationPolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 创建合规规则
        ///
        /// 创建新的合规规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePolicyAssignmentsResponse CreatePolicyAssignments(CreatePolicyAssignmentsRequest createPolicyAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyAssignmentsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<CreatePolicyAssignmentsResponse>(response);
        }

        public SyncInvoker<CreatePolicyAssignmentsResponse> CreatePolicyAssignmentsInvoker(CreatePolicyAssignmentsRequest createPolicyAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyAssignmentsRequest);
            return new SyncInvoker<CreatePolicyAssignmentsResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreatePolicyAssignmentsResponse>);
        }
        
        /// <summary>
        /// 删除组织合规规则
        ///
        /// 删除组织合规规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteOrganizationPolicyAssignmentResponse DeleteOrganizationPolicyAssignment(DeleteOrganizationPolicyAssignmentRequest deleteOrganizationPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOrganizationPolicyAssignmentRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(deleteOrganizationPolicyAssignmentRequest.OrganizationPolicyAssignmentId, out var valueOfOrganizationPolicyAssignmentId)) urlParam.Add("organization_policy_assignment_id", valueOfOrganizationPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignments/{organization_policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOrganizationPolicyAssignmentRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteOrganizationPolicyAssignmentResponse>(response);
        }

        public SyncInvoker<DeleteOrganizationPolicyAssignmentResponse> DeleteOrganizationPolicyAssignmentInvoker(DeleteOrganizationPolicyAssignmentRequest deleteOrganizationPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOrganizationPolicyAssignmentRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(deleteOrganizationPolicyAssignmentRequest.OrganizationPolicyAssignmentId, out var valueOfOrganizationPolicyAssignmentId)) urlParam.Add("organization_policy_assignment_id", valueOfOrganizationPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignments/{organization_policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOrganizationPolicyAssignmentRequest);
            return new SyncInvoker<DeleteOrganizationPolicyAssignmentResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteOrganizationPolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 删除合规规则
        ///
        /// 根据规则ID删除此规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePolicyAssignmentResponse DeletePolicyAssignment(DeletePolicyAssignmentRequest deletePolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyAssignmentRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyAssignmentRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePolicyAssignmentResponse>(response);
        }

        public SyncInvoker<DeletePolicyAssignmentResponse> DeletePolicyAssignmentInvoker(DeletePolicyAssignmentRequest deletePolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyAssignmentRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyAssignmentRequest);
            return new SyncInvoker<DeletePolicyAssignmentResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 删除修正配置
        ///
        /// 删除合规规则修正配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRemediationConfigurationResponse DeleteRemediationConfiguration(DeleteRemediationConfigurationRequest deleteRemediationConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRemediationConfigurationRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRemediationConfigurationRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRemediationConfigurationResponse>(response);
        }

        public SyncInvoker<DeleteRemediationConfigurationResponse> DeleteRemediationConfigurationInvoker(DeleteRemediationConfigurationRequest deleteRemediationConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRemediationConfigurationRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRemediationConfigurationRequest);
            return new SyncInvoker<DeleteRemediationConfigurationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRemediationConfigurationResponse>);
        }
        
        /// <summary>
        /// 停用合规规则
        ///
        /// 根据规则ID停用此规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisablePolicyAssignmentResponse DisablePolicyAssignment(DisablePolicyAssignmentRequest disablePolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disablePolicyAssignmentRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disablePolicyAssignmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DisablePolicyAssignmentResponse>(response);
        }

        public SyncInvoker<DisablePolicyAssignmentResponse> DisablePolicyAssignmentInvoker(DisablePolicyAssignmentRequest disablePolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disablePolicyAssignmentRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disablePolicyAssignmentRequest);
            return new SyncInvoker<DisablePolicyAssignmentResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisablePolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 启用合规规则
        ///
        /// 根据规则ID启用此规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnablePolicyAssignmentResponse EnablePolicyAssignment(EnablePolicyAssignmentRequest enablePolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enablePolicyAssignmentRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enablePolicyAssignmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<EnablePolicyAssignmentResponse>(response);
        }

        public SyncInvoker<EnablePolicyAssignmentResponse> EnablePolicyAssignmentInvoker(EnablePolicyAssignmentRequest enablePolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enablePolicyAssignmentRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enablePolicyAssignmentRequest);
            return new SyncInvoker<EnablePolicyAssignmentResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnablePolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 列出内置策略
        ///
        /// 列出用户的内置策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBuiltInPolicyDefinitionsResponse ListBuiltInPolicyDefinitions(ListBuiltInPolicyDefinitionsRequest listBuiltInPolicyDefinitionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/policy-definitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBuiltInPolicyDefinitionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBuiltInPolicyDefinitionsResponse>(response);
        }

        public SyncInvoker<ListBuiltInPolicyDefinitionsResponse> ListBuiltInPolicyDefinitionsInvoker(ListBuiltInPolicyDefinitionsRequest listBuiltInPolicyDefinitionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/policy-definitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBuiltInPolicyDefinitionsRequest);
            return new SyncInvoker<ListBuiltInPolicyDefinitionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBuiltInPolicyDefinitionsResponse>);
        }
        
        /// <summary>
        /// 查询组织合规规则列表
        ///
        /// 查询组织合规规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOrganizationPolicyAssignmentsResponse ListOrganizationPolicyAssignments(ListOrganizationPolicyAssignmentsRequest listOrganizationPolicyAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOrganizationPolicyAssignmentsRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationPolicyAssignmentsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOrganizationPolicyAssignmentsResponse>(response);
        }

        public SyncInvoker<ListOrganizationPolicyAssignmentsResponse> ListOrganizationPolicyAssignmentsInvoker(ListOrganizationPolicyAssignmentsRequest listOrganizationPolicyAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOrganizationPolicyAssignmentsRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationPolicyAssignmentsRequest);
            return new SyncInvoker<ListOrganizationPolicyAssignmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOrganizationPolicyAssignmentsResponse>);
        }
        
        /// <summary>
        /// 列出合规规则
        ///
        /// 列出用户的合规规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPolicyAssignmentsResponse ListPolicyAssignments(ListPolicyAssignmentsRequest listPolicyAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyAssignmentsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyAssignmentsResponse>(response);
        }

        public SyncInvoker<ListPolicyAssignmentsResponse> ListPolicyAssignmentsInvoker(ListPolicyAssignmentsRequest listPolicyAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyAssignmentsRequest);
            return new SyncInvoker<ListPolicyAssignmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyAssignmentsResponse>);
        }
        
        /// <summary>
        /// 获取规则的合规结果
        ///
        /// 根据规则ID查询所有的合规结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPolicyStatesByAssignmentIdResponse ListPolicyStatesByAssignmentId(ListPolicyStatesByAssignmentIdRequest listPolicyStatesByAssignmentIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPolicyStatesByAssignmentIdRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/policy-states", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyStatesByAssignmentIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyStatesByAssignmentIdResponse>(response);
        }

        public SyncInvoker<ListPolicyStatesByAssignmentIdResponse> ListPolicyStatesByAssignmentIdInvoker(ListPolicyStatesByAssignmentIdRequest listPolicyStatesByAssignmentIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPolicyStatesByAssignmentIdRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/policy-states", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyStatesByAssignmentIdRequest);
            return new SyncInvoker<ListPolicyStatesByAssignmentIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyStatesByAssignmentIdResponse>);
        }
        
        /// <summary>
        /// 获取用户的合规结果
        ///
        /// 查询用户所有的合规结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPolicyStatesByDomainIdResponse ListPolicyStatesByDomainId(ListPolicyStatesByDomainIdRequest listPolicyStatesByDomainIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-states", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyStatesByDomainIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyStatesByDomainIdResponse>(response);
        }

        public SyncInvoker<ListPolicyStatesByDomainIdResponse> ListPolicyStatesByDomainIdInvoker(ListPolicyStatesByDomainIdRequest listPolicyStatesByDomainIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-states", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyStatesByDomainIdRequest);
            return new SyncInvoker<ListPolicyStatesByDomainIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyStatesByDomainIdResponse>);
        }
        
        /// <summary>
        /// 获取资源的合规结果
        ///
        /// 根据资源ID查询所有合规结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPolicyStatesByResourceIdResponse ListPolicyStatesByResourceId(ListPolicyStatesByResourceIdRequest listPolicyStatesByResourceIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPolicyStatesByResourceIdRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/resources/{resource_id}/policy-states", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyStatesByResourceIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyStatesByResourceIdResponse>(response);
        }

        public SyncInvoker<ListPolicyStatesByResourceIdResponse> ListPolicyStatesByResourceIdInvoker(ListPolicyStatesByResourceIdRequest listPolicyStatesByResourceIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPolicyStatesByResourceIdRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/resources/{resource_id}/policy-states", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyStatesByResourceIdRequest);
            return new SyncInvoker<ListPolicyStatesByResourceIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyStatesByResourceIdResponse>);
        }
        
        /// <summary>
        /// 查询当前账号合规统计趋势
        ///
        /// 查询当前账号合规统计趋势
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPolicyStatesStatisticsResponse ListPolicyStatesStatistics(ListPolicyStatesStatisticsRequest listPolicyStatesStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-states/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyStatesStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyStatesStatisticsResponse>(response);
        }

        public SyncInvoker<ListPolicyStatesStatisticsResponse> ListPolicyStatesStatisticsInvoker(ListPolicyStatesStatisticsRequest listPolicyStatesStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-states/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyStatesStatisticsRequest);
            return new SyncInvoker<ListPolicyStatesStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyStatesStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询修正例外
        ///
        /// 查询合规规则修正例外。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRemediationExceptionsResponse ListRemediationExceptions(ListRemediationExceptionsRequest listRemediationExceptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRemediationExceptionsRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-exception", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRemediationExceptionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRemediationExceptionsResponse>(response);
        }

        public SyncInvoker<ListRemediationExceptionsResponse> ListRemediationExceptionsInvoker(ListRemediationExceptionsRequest listRemediationExceptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRemediationExceptionsRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-exception", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRemediationExceptionsRequest);
            return new SyncInvoker<ListRemediationExceptionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRemediationExceptionsResponse>);
        }
        
        /// <summary>
        /// 查询修正执行结果
        ///
        /// 查询合规规则修正执行结果详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRemediationExecutionStatusesResponse ListRemediationExecutionStatuses(ListRemediationExecutionStatusesRequest listRemediationExecutionStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRemediationExecutionStatusesRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-execution-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRemediationExecutionStatusesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRemediationExecutionStatusesResponse>(response);
        }

        public SyncInvoker<ListRemediationExecutionStatusesResponse> ListRemediationExecutionStatusesInvoker(ListRemediationExecutionStatusesRequest listRemediationExecutionStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRemediationExecutionStatusesRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-execution-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRemediationExecutionStatusesRequest);
            return new SyncInvoker<ListRemediationExecutionStatusesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRemediationExecutionStatusesResponse>);
        }
        
        /// <summary>
        /// 运行合规评估
        ///
        /// 根据规则ID评估此规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunEvaluationByPolicyAssignmentIdResponse RunEvaluationByPolicyAssignmentId(RunEvaluationByPolicyAssignmentIdRequest runEvaluationByPolicyAssignmentIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runEvaluationByPolicyAssignmentIdRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/policy-states/run-evaluation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runEvaluationByPolicyAssignmentIdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RunEvaluationByPolicyAssignmentIdResponse>(response);
        }

        public SyncInvoker<RunEvaluationByPolicyAssignmentIdResponse> RunEvaluationByPolicyAssignmentIdInvoker(RunEvaluationByPolicyAssignmentIdRequest runEvaluationByPolicyAssignmentIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runEvaluationByPolicyAssignmentIdRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/policy-states/run-evaluation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runEvaluationByPolicyAssignmentIdRequest);
            return new SyncInvoker<RunEvaluationByPolicyAssignmentIdResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RunEvaluationByPolicyAssignmentIdResponse>);
        }
        
        /// <summary>
        /// 运行修正执行
        ///
        /// 手动运行合规规则修正执行。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunRemediationExecutionResponse RunRemediationExecution(RunRemediationExecutionRequest runRemediationExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runRemediationExecutionRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-execution", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runRemediationExecutionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RunRemediationExecutionResponse>(response);
        }

        public SyncInvoker<RunRemediationExecutionResponse> RunRemediationExecutionInvoker(RunRemediationExecutionRequest runRemediationExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runRemediationExecutionRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-execution", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runRemediationExecutionRequest);
            return new SyncInvoker<RunRemediationExecutionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RunRemediationExecutionResponse>);
        }
        
        /// <summary>
        /// 查询单个内置策略
        ///
        /// 根据策略ID查询单个内置策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBuiltInPolicyDefinitionResponse ShowBuiltInPolicyDefinition(ShowBuiltInPolicyDefinitionRequest showBuiltInPolicyDefinitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBuiltInPolicyDefinitionRequest.PolicyDefinitionId, out var valueOfPolicyDefinitionId)) urlParam.Add("policy_definition_id", valueOfPolicyDefinitionId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/policy-definitions/{policy_definition_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuiltInPolicyDefinitionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBuiltInPolicyDefinitionResponse>(response);
        }

        public SyncInvoker<ShowBuiltInPolicyDefinitionResponse> ShowBuiltInPolicyDefinitionInvoker(ShowBuiltInPolicyDefinitionRequest showBuiltInPolicyDefinitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBuiltInPolicyDefinitionRequest.PolicyDefinitionId, out var valueOfPolicyDefinitionId)) urlParam.Add("policy_definition_id", valueOfPolicyDefinitionId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/policy-definitions/{policy_definition_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuiltInPolicyDefinitionRequest);
            return new SyncInvoker<ShowBuiltInPolicyDefinitionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBuiltInPolicyDefinitionResponse>);
        }
        
        /// <summary>
        /// 获取规则的评估状态
        ///
        /// 根据规则ID查询此规则的评估状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEvaluationStateByAssignmentIdResponse ShowEvaluationStateByAssignmentId(ShowEvaluationStateByAssignmentIdRequest showEvaluationStateByAssignmentIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEvaluationStateByAssignmentIdRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/policy-states/evaluation-state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEvaluationStateByAssignmentIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEvaluationStateByAssignmentIdResponse>(response);
        }

        public SyncInvoker<ShowEvaluationStateByAssignmentIdResponse> ShowEvaluationStateByAssignmentIdInvoker(ShowEvaluationStateByAssignmentIdRequest showEvaluationStateByAssignmentIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEvaluationStateByAssignmentIdRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/policy-states/evaluation-state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEvaluationStateByAssignmentIdRequest);
            return new SyncInvoker<ShowEvaluationStateByAssignmentIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEvaluationStateByAssignmentIdResponse>);
        }
        
        /// <summary>
        /// 查询指定组织合规规则
        ///
        /// 查询指定组织合规规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOrganizationPolicyAssignmentResponse ShowOrganizationPolicyAssignment(ShowOrganizationPolicyAssignmentRequest showOrganizationPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationPolicyAssignmentRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationPolicyAssignmentRequest.OrganizationPolicyAssignmentId, out var valueOfOrganizationPolicyAssignmentId)) urlParam.Add("organization_policy_assignment_id", valueOfOrganizationPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignments/{organization_policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationPolicyAssignmentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOrganizationPolicyAssignmentResponse>(response);
        }

        public SyncInvoker<ShowOrganizationPolicyAssignmentResponse> ShowOrganizationPolicyAssignmentInvoker(ShowOrganizationPolicyAssignmentRequest showOrganizationPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationPolicyAssignmentRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationPolicyAssignmentRequest.OrganizationPolicyAssignmentId, out var valueOfOrganizationPolicyAssignmentId)) urlParam.Add("organization_policy_assignment_id", valueOfOrganizationPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignments/{organization_policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationPolicyAssignmentRequest);
            return new SyncInvoker<ShowOrganizationPolicyAssignmentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOrganizationPolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 查询组织内每个成员帐号合规规则部署的详细状态
        ///
        /// 查询组织内每个成员帐号合规规则部署的详细状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOrganizationPolicyAssignmentDetailedStatusResponse ShowOrganizationPolicyAssignmentDetailedStatus(ShowOrganizationPolicyAssignmentDetailedStatusRequest showOrganizationPolicyAssignmentDetailedStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationPolicyAssignmentDetailedStatusRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignment-detailed-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationPolicyAssignmentDetailedStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOrganizationPolicyAssignmentDetailedStatusResponse>(response);
        }

        public SyncInvoker<ShowOrganizationPolicyAssignmentDetailedStatusResponse> ShowOrganizationPolicyAssignmentDetailedStatusInvoker(ShowOrganizationPolicyAssignmentDetailedStatusRequest showOrganizationPolicyAssignmentDetailedStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationPolicyAssignmentDetailedStatusRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignment-detailed-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationPolicyAssignmentDetailedStatusRequest);
            return new SyncInvoker<ShowOrganizationPolicyAssignmentDetailedStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOrganizationPolicyAssignmentDetailedStatusResponse>);
        }
        
        /// <summary>
        /// 查询组织合规规则部署状态
        ///
        /// 查询组织合规规则部署状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOrganizationPolicyAssignmentStatusesResponse ShowOrganizationPolicyAssignmentStatuses(ShowOrganizationPolicyAssignmentStatusesRequest showOrganizationPolicyAssignmentStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationPolicyAssignmentStatusesRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignment-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationPolicyAssignmentStatusesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOrganizationPolicyAssignmentStatusesResponse>(response);
        }

        public SyncInvoker<ShowOrganizationPolicyAssignmentStatusesResponse> ShowOrganizationPolicyAssignmentStatusesInvoker(ShowOrganizationPolicyAssignmentStatusesRequest showOrganizationPolicyAssignmentStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationPolicyAssignmentStatusesRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignment-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationPolicyAssignmentStatusesRequest);
            return new SyncInvoker<ShowOrganizationPolicyAssignmentStatusesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOrganizationPolicyAssignmentStatusesResponse>);
        }
        
        /// <summary>
        /// 获取单个合规规则
        ///
        /// 根据规则ID获取单个规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPolicyAssignmentResponse ShowPolicyAssignment(ShowPolicyAssignmentRequest showPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyAssignmentRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyAssignmentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPolicyAssignmentResponse>(response);
        }

        public SyncInvoker<ShowPolicyAssignmentResponse> ShowPolicyAssignmentInvoker(ShowPolicyAssignmentRequest showPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyAssignmentRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyAssignmentRequest);
            return new SyncInvoker<ShowPolicyAssignmentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 查询修正配置
        ///
        /// 查询合规规则修正配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRemediationConfigurationResponse ShowRemediationConfiguration(ShowRemediationConfigurationRequest showRemediationConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRemediationConfigurationRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRemediationConfigurationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRemediationConfigurationResponse>(response);
        }

        public SyncInvoker<ShowRemediationConfigurationResponse> ShowRemediationConfigurationInvoker(ShowRemediationConfigurationRequest showRemediationConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRemediationConfigurationRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}/remediation-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRemediationConfigurationRequest);
            return new SyncInvoker<ShowRemediationConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRemediationConfigurationResponse>);
        }
        
        /// <summary>
        /// 更新组织合规规则
        ///
        /// 更新组织合规规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateOrganizationPolicyAssignmentResponse UpdateOrganizationPolicyAssignment(UpdateOrganizationPolicyAssignmentRequest updateOrganizationPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateOrganizationPolicyAssignmentRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(updateOrganizationPolicyAssignmentRequest.OrganizationPolicyAssignmentId, out var valueOfOrganizationPolicyAssignmentId)) urlParam.Add("organization_policy_assignment_id", valueOfOrganizationPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignments/{organization_policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOrganizationPolicyAssignmentRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateOrganizationPolicyAssignmentResponse>(response);
        }

        public SyncInvoker<UpdateOrganizationPolicyAssignmentResponse> UpdateOrganizationPolicyAssignmentInvoker(UpdateOrganizationPolicyAssignmentRequest updateOrganizationPolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateOrganizationPolicyAssignmentRequest.OrganizationId, out var valueOfOrganizationId)) urlParam.Add("organization_id", valueOfOrganizationId);
            if (StringUtils.TryConvertToNonEmptyString(updateOrganizationPolicyAssignmentRequest.OrganizationPolicyAssignmentId, out var valueOfOrganizationPolicyAssignmentId)) urlParam.Add("organization_policy_assignment_id", valueOfOrganizationPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/organizations/{organization_id}/policy-assignments/{organization_policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOrganizationPolicyAssignmentRequest);
            return new SyncInvoker<UpdateOrganizationPolicyAssignmentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateOrganizationPolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 更新合规规则
        ///
        /// 更新用户的合规规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePolicyAssignmentResponse UpdatePolicyAssignment(UpdatePolicyAssignmentRequest updatePolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyAssignmentRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyAssignmentRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePolicyAssignmentResponse>(response);
        }

        public SyncInvoker<UpdatePolicyAssignmentResponse> UpdatePolicyAssignmentInvoker(UpdatePolicyAssignmentRequest updatePolicyAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyAssignmentRequest.PolicyAssignmentId, out var valueOfPolicyAssignmentId)) urlParam.Add("policy_assignment_id", valueOfPolicyAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-assignments/{policy_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyAssignmentRequest);
            return new SyncInvoker<UpdatePolicyAssignmentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePolicyAssignmentResponse>);
        }
        
        /// <summary>
        /// 更新合规评估结果
        ///
        /// 更新用户自定义合规规则的合规评估结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePolicyStateResponse UpdatePolicyState(UpdatePolicyStateRequest updatePolicyStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-states", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyStateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePolicyStateResponse>(response);
        }

        public SyncInvoker<UpdatePolicyStateResponse> UpdatePolicyStateInvoker(UpdatePolicyStateRequest updatePolicyStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/policy-states", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyStateRequest);
            return new SyncInvoker<UpdatePolicyStateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePolicyStateResponse>);
        }
        
        /// <summary>
        /// 创建高级查询
        ///
        /// 创建新的高级查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateStoredQueryResponse CreateStoredQuery(CreateStoredQueryRequest createStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/stored-queries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createStoredQueryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateStoredQueryResponse>(response);
        }

        public SyncInvoker<CreateStoredQueryResponse> CreateStoredQueryInvoker(CreateStoredQueryRequest createStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/stored-queries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createStoredQueryRequest);
            return new SyncInvoker<CreateStoredQueryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateStoredQueryResponse>);
        }
        
        /// <summary>
        /// 删除高级查询
        ///
        /// 删除单个高级查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteStoredQueryResponse DeleteStoredQuery(DeleteStoredQueryRequest deleteStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStoredQueryRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteStoredQueryResponse>(response);
        }

        public SyncInvoker<DeleteStoredQueryResponse> DeleteStoredQueryInvoker(DeleteStoredQueryRequest deleteStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/stored-queries/{query_id}", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/schemas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSchemasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSchemasResponse>(response);
        }

        public SyncInvoker<ListSchemasResponse> ListSchemasInvoker(ListSchemasRequest listSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/schemas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSchemasRequest);
            return new SyncInvoker<ListSchemasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSchemasResponse>);
        }
        
        /// <summary>
        /// 列出高级查询
        ///
        /// 列举所有高级查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStoredQueriesResponse ListStoredQueries(ListStoredQueriesRequest listStoredQueriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/stored-queries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStoredQueriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListStoredQueriesResponse>(response);
        }

        public SyncInvoker<ListStoredQueriesResponse> ListStoredQueriesInvoker(ListStoredQueriesRequest listStoredQueriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/stored-queries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStoredQueriesRequest);
            return new SyncInvoker<ListStoredQueriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStoredQueriesResponse>);
        }
        
        /// <summary>
        /// 运行高级查询
        ///
        /// 执行高级查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunQueryResponse RunQuery(RunQueryRequest runQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/run-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runQueryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunQueryResponse>(response);
        }

        public SyncInvoker<RunQueryResponse> RunQueryInvoker(RunQueryRequest runQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/run-query", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStoredQueryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStoredQueryResponse>(response);
        }

        public SyncInvoker<ShowStoredQueryResponse> ShowStoredQueryInvoker(ShowStoredQueryRequest showStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStoredQueryRequest);
            return new SyncInvoker<ShowStoredQueryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStoredQueryResponse>);
        }
        
        /// <summary>
        /// 更新单个高级查询
        ///
        /// 更新自定义查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateStoredQueryResponse UpdateStoredQuery(UpdateStoredQueryRequest updateStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStoredQueryRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateStoredQueryResponse>(response);
        }

        public SyncInvoker<UpdateStoredQueryResponse> UpdateStoredQueryInvoker(UpdateStoredQueryRequest updateStoredQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateStoredQueryRequest.QueryId, out var valueOfQueryId)) urlParam.Add("query_id", valueOfQueryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/stored-queries/{query_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStoredQueryRequest);
            return new SyncInvoker<UpdateStoredQueryResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateStoredQueryResponse>);
        }
        
        /// <summary>
        /// 查询用户可见的区域
        ///
        /// 查询用户可见的区域
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRegionsResponse ListRegions(ListRegionsRequest listRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRegionsResponse>(response);
        }

        public SyncInvoker<ListRegionsResponse> ListRegionsInvoker(ListRegionsRequest listRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegionsRequest);
            return new SyncInvoker<ListRegionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRegionsResponse>);
        }
        
        /// <summary>
        /// 列举资源关系
        ///
        /// 指定资源ID，查询该资源与其他资源的关联关系，可以指定关系方向为\&quot;in\&quot; 或者\&quot;out\&quot;。资源关系依赖开启资源记录器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceRelationsResponse ShowResourceRelations(ShowResourceRelationsRequest showResourceRelationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceRelationsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/resources/{resource_id}/relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceRelationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceRelationsResponse>(response);
        }

        public SyncInvoker<ShowResourceRelationsResponse> ShowResourceRelationsInvoker(ShowResourceRelationsRequest showResourceRelationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceRelationsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/resources/{resource_id}/relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceRelationsRequest);
            return new SyncInvoker<ShowResourceRelationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceRelationsResponse>);
        }
        
        /// <summary>
        /// 列举资源关系详情
        ///
        /// 指定资源ID，查询该资源与其他资源的关联关系，可以指定关系方向为“in”或者“out”，需要当帐号有rms:resources:getRelation权限。资源关系依赖开启资源记录器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceRelationsDetailResponse ShowResourceRelationsDetail(ShowResourceRelationsDetailRequest showResourceRelationsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceRelationsDetailRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources/{resource_id}/relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceRelationsDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceRelationsDetailResponse>(response);
        }

        public SyncInvoker<ShowResourceRelationsDetailResponse> ShowResourceRelationsDetailInvoker(ShowResourceRelationsDetailRequest showResourceRelationsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceRelationsDetailRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources/{resource_id}/relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceRelationsDetailRequest);
            return new SyncInvoker<ShowResourceRelationsDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceRelationsDetailResponse>);
        }
        
        /// <summary>
        /// 列举资源概要
        ///
        /// 查询当前帐号的资源概览。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CollectAllResourcesSummaryResponse CollectAllResourcesSummary(CollectAllResourcesSummaryRequest collectAllResourcesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectAllResourcesSummaryRequest);
            var response = DoHttpRequestSync("GET", request);
            var collectAllResourcesSummaryResponse = JsonUtils.DeSerializeNull<CollectAllResourcesSummaryResponse>(response);
            collectAllResourcesSummaryResponse.Body = JsonUtils.DeSerializeList<ResourceSummaryResponseItem>(response);
            return collectAllResourcesSummaryResponse;
        }

        public SyncInvoker<CollectAllResourcesSummaryResponse> CollectAllResourcesSummaryInvoker(CollectAllResourcesSummaryRequest collectAllResourcesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectAllResourcesSummaryRequest);
            return new SyncInvoker<CollectAllResourcesSummaryResponse>(this, "GET", request, response =>
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
        public CollectTrackedResourcesSummaryResponse CollectTrackedResourcesSummary(CollectTrackedResourcesSummaryRequest collectTrackedResourcesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracked-resources/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectTrackedResourcesSummaryRequest);
            var response = DoHttpRequestSync("GET", request);
            var collectTrackedResourcesSummaryResponse = JsonUtils.DeSerializeNull<CollectTrackedResourcesSummaryResponse>(response);
            collectTrackedResourcesSummaryResponse.Body = JsonUtils.DeSerializeList<ResourceSummaryResponseItem>(response);
            return collectTrackedResourcesSummaryResponse;
        }

        public SyncInvoker<CollectTrackedResourcesSummaryResponse> CollectTrackedResourcesSummaryInvoker(CollectTrackedResourcesSummaryRequest collectTrackedResourcesSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracked-resources/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectTrackedResourcesSummaryRequest);
            return new SyncInvoker<CollectTrackedResourcesSummaryResponse>(this, "GET", request, response =>
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
        public CountAllResourcesResponse CountAllResources(CountAllResourcesRequest countAllResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countAllResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CountAllResourcesResponse>(response);
        }

        public SyncInvoker<CountAllResourcesResponse> CountAllResourcesInvoker(CountAllResourcesRequest countAllResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countAllResourcesRequest);
            return new SyncInvoker<CountAllResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<CountAllResourcesResponse>);
        }
        
        /// <summary>
        /// 查询资源记录器收集的资源数量
        ///
        /// 查询当前用户资源记录器收集的资源数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountTrackedResourcesResponse CountTrackedResources(CountTrackedResourcesRequest countTrackedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracked-resources/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countTrackedResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CountTrackedResourcesResponse>(response);
        }

        public SyncInvoker<CountTrackedResourcesResponse> CountTrackedResourcesInvoker(CountTrackedResourcesRequest countTrackedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracked-resources/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countTrackedResourcesRequest);
            return new SyncInvoker<CountTrackedResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<CountTrackedResourcesResponse>);
        }
        
        /// <summary>
        /// 列举所有已对接的云服务
        ///
        /// 查询所有已对接Config的云服务、资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllProvidersResponse ListAllProviders(ListAllProvidersRequest listAllProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllProvidersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAllProvidersResponse>(response);
        }

        public SyncInvoker<ListAllProvidersResponse> ListAllProvidersInvoker(ListAllProvidersRequest listAllProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllProvidersRequest);
            return new SyncInvoker<ListAllProvidersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllProvidersResponse>);
        }
        
        /// <summary>
        /// 列举所有资源
        ///
        /// 返回当前用户下所有资源，需要当前用户有rms:resources:list权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllResourcesResponse ListAllResources(ListAllResourcesRequest listAllResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAllResourcesResponse>(response);
        }

        public SyncInvoker<ListAllResourcesResponse> ListAllResourcesInvoker(ListAllResourcesRequest listAllResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllResourcesRequest);
            return new SyncInvoker<ListAllResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllResourcesResponse>);
        }
        
        /// <summary>
        /// 列举资源标签
        ///
        /// 查询当前帐号下所有资源的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllTagsResponse ListAllTags(ListAllTagsRequest listAllTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAllTagsResponse>(response);
        }

        public SyncInvoker<ListAllTagsResponse> ListAllTagsInvoker(ListAllTagsRequest listAllTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllTagsRequest);
            return new SyncInvoker<ListAllTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllTagsResponse>);
        }
        
        /// <summary>
        /// 列举云服务
        ///
        /// 查询Config支持的云服务、资源、区域列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProvidersResponse ListProviders(ListProvidersRequest listProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvidersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProvidersResponse>(response);
        }

        public SyncInvoker<ListProvidersResponse> ListProvidersInvoker(ListProvidersRequest listProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvidersRequest);
            return new SyncInvoker<ListProvidersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProvidersResponse>);
        }
        
        /// <summary>
        /// 列举指定类型的资源
        ///
        /// 返回当前租户下特定资源类型的资源，需要当前用户有rms:resources:list权限。比如查询云服务器，对应的Config资源类型是ecs.cloudservers，其中provider为ecs，type为cloudservers。 Config支持的服务和资源类型参见[支持的服务和区域](https://console.huaweicloud.com/eps/#/resources/supported)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourcesResponse ListResources(ListResourcesRequest listResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourcesRequest.Provider, out var valueOfProvider)) urlParam.Add("provider", valueOfProvider);
            if (StringUtils.TryConvertToNonEmptyString(listResourcesRequest.Type, out var valueOfType)) urlParam.Add("type", valueOfType);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/provider/{provider}/type/{type}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListResourcesResponse>(response);
        }

        public SyncInvoker<ListResourcesResponse> ListResourcesInvoker(ListResourcesRequest listResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourcesRequest.Provider, out var valueOfProvider)) urlParam.Add("provider", valueOfProvider);
            if (StringUtils.TryConvertToNonEmptyString(listResourcesRequest.Type, out var valueOfType)) urlParam.Add("type", valueOfType);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/provider/{provider}/type/{type}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesRequest);
            return new SyncInvoker<ListResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourcesResponse>);
        }
        
        /// <summary>
        /// 列举资源记录器收集的资源标签
        ///
        /// 查询当前用户资源记录器收集的资源的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTrackedResourceTagsResponse ListTrackedResourceTags(ListTrackedResourceTagsRequest listTrackedResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracked-resources/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrackedResourceTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTrackedResourceTagsResponse>(response);
        }

        public SyncInvoker<ListTrackedResourceTagsResponse> ListTrackedResourceTagsInvoker(ListTrackedResourceTagsRequest listTrackedResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracked-resources/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrackedResourceTagsRequest);
            return new SyncInvoker<ListTrackedResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTrackedResourceTagsResponse>);
        }
        
        /// <summary>
        /// 列举资源记录器收集的全部资源
        ///
        /// 查询当前用户资源记录器收集的全部资源，需要当前用户有rms:resources:list权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTrackedResourcesResponse ListTrackedResources(ListTrackedResourcesRequest listTrackedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracked-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrackedResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTrackedResourcesResponse>(response);
        }

        public SyncInvoker<ListTrackedResourcesResponse> ListTrackedResourcesInvoker(ListTrackedResourcesRequest listTrackedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracked-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrackedResourcesRequest);
            return new SyncInvoker<ListTrackedResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTrackedResourcesResponse>);
        }
        
        /// <summary>
        /// 查询单个资源
        ///
        /// 指定资源ID，返回该资源的详细信息，需要当前用户有rms:resources:get权限。比如查询云服务器，对应的Config资源类型是ecs.cloudservers，其中provider为ecs，type为cloudservers。Config支持的服务和资源类型参见[支持的服务和区域](https://console.huaweicloud.com/eps/#/resources/supported)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceByIdResponse ShowResourceById(ShowResourceByIdRequest showResourceByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceByIdRequest.Provider, out var valueOfProvider)) urlParam.Add("provider", valueOfProvider);
            if (StringUtils.TryConvertToNonEmptyString(showResourceByIdRequest.Type, out var valueOfType)) urlParam.Add("type", valueOfType);
            if (StringUtils.TryConvertToNonEmptyString(showResourceByIdRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/provider/{provider}/type/{type}/resources/{resource_id}", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/provider/{provider}/type/{type}/resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceByIdRequest);
            return new SyncInvoker<ShowResourceByIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceByIdResponse>);
        }
        
        /// <summary>
        /// 查询帐号下的单个资源
        ///
        /// 查询当前帐号下的单个资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceDetailResponse ShowResourceDetail(ShowResourceDetailRequest showResourceDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceDetailRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceDetailResponse>(response);
        }

        public SyncInvoker<ShowResourceDetailResponse> ShowResourceDetailInvoker(ShowResourceDetailRequest showResourceDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceDetailRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/all-resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceDetailRequest);
            return new SyncInvoker<ShowResourceDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceDetailResponse>);
        }
        
        /// <summary>
        /// 查询资源记录器收集的单个资源
        ///
        /// 查询当前用户资源记录器收集的单个资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTrackedResourceDetailResponse ShowTrackedResourceDetail(ShowTrackedResourceDetailRequest showTrackedResourceDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTrackedResourceDetailRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracked-resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrackedResourceDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTrackedResourceDetailResponse>(response);
        }

        public SyncInvoker<ShowTrackedResourceDetailResponse> ShowTrackedResourceDetailInvoker(ShowTrackedResourceDetailRequest showTrackedResourceDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTrackedResourceDetailRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracked-resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrackedResourceDetailRequest);
            return new SyncInvoker<ShowTrackedResourceDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrackedResourceDetailResponse>);
        }
        
        /// <summary>
        /// 查询资源实例数量
        ///
        /// 使用标签过滤实例，标签管理服务需要提供按标签过滤各服务实例并汇总显示在列表中，需要各服务提供查询能力。注意：tags, tags_any, not_tags, not_tags_any等字段支持的tag的数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountResourcesByTagResponse CountResourcesByTag(CountResourcesByTagRequest countResourcesByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countResourcesByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countResourcesByTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CountResourcesByTagResponse>(response);
        }

        public SyncInvoker<CountResourcesByTagResponse> CountResourcesByTagInvoker(CountResourcesByTagRequest countResourcesByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countResourcesByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countResourcesByTagRequest);
            return new SyncInvoker<CountResourcesByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<CountResourcesByTagResponse>);
        }
        
        /// <summary>
        /// 查询资源实例列表
        ///
        /// 使用标签过滤实例，标签管理服务需要提供按标签过滤各服务实例并汇总显示在列表中，需要各服务提供查询能力。注意：tags, tags_any, not_tags, not_tags_any等字段支持的tag的数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourcesByTagResponse ListResourcesByTag(ListResourcesByTagRequest listResourcesByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourcesByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesByTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListResourcesByTagResponse>(response);
        }

        public SyncInvoker<ListResourcesByTagResponse> ListResourcesByTagInvoker(ListResourcesByTagRequest listResourcesByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourcesByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesByTagRequest);
            return new SyncInvoker<ListResourcesByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourcesByTagResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询指定实例的标签信息。标签管理服务需要使用该接口查询指定实例的全部标签数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest listTagsForResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagsForResourceRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listTagsForResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsForResourceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTagsForResourceResponse>(response);
        }

        public SyncInvoker<ListTagsForResourceResponse> ListTagsForResourceInvoker(ListTagsForResourceRequest listTagsForResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagsForResourceRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listTagsForResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsForResourceRequest);
            return new SyncInvoker<ListTagsForResourceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagsForResourceResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询租户在指定Project中实例类型的所有资源标签集合。标签管理服务需要能够列出当前租户全部已使用的资源标签集合，为各服务Console打资源标签和过滤实例时提供标签联想功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagsForResourceTypeResponse ListTagsForResourceType(ListTagsForResourceTypeRequest listTagsForResourceTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagsForResourceTypeRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsForResourceTypeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTagsForResourceTypeResponse>(response);
        }

        public SyncInvoker<ListTagsForResourceTypeResponse> ListTagsForResourceTypeInvoker(ListTagsForResourceTypeRequest listTagsForResourceTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagsForResourceTypeRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsForResourceTypeRequest);
            return new SyncInvoker<ListTagsForResourceTypeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagsForResourceTypeResponse>);
        }
        
        /// <summary>
        /// 批量添加资源标签
        ///
        /// 此接口为幂等接口。为指定实例批量添加或删除标签，标签管理服务需要使用该接口批量管理实例的标签。一个资源上最多有20个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public TagResourceResponse TagResource(TagResourceRequest tagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(tagResourceRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(tagResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagResourceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<TagResourceResponse>(response);
        }

        public SyncInvoker<TagResourceResponse> TagResourceInvoker(TagResourceRequest tagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(tagResourceRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(tagResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagResourceRequest);
            return new SyncInvoker<TagResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<TagResourceResponse>);
        }
        
        /// <summary>
        /// 批量删除资源标签
        ///
        /// 此接口为幂等接口。为指定实例批量添加或删除标签，标签管理服务需要使用该接口批量管理实例的标签。一个资源上最多有20个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UnTagResourceResponse UnTagResource(UnTagResourceRequest unTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unTagResourceRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(unTagResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unTagResourceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UnTagResourceResponse>(response);
        }

        public SyncInvoker<UnTagResourceResponse> UnTagResourceInvoker(UnTagResourceRequest unTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unTagResourceRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(unTagResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unTagResourceRequest);
            return new SyncInvoker<UnTagResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UnTagResourceResponse>);
        }
        
        /// <summary>
        /// 创建或更新记录器
        ///
        /// 创建或更新资源记录器，只能存在一个资源记录器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTrackerConfigResponse CreateTrackerConfig(CreateTrackerConfigRequest createTrackerConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracker-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrackerConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<CreateTrackerConfigResponse>(response);
        }

        public SyncInvoker<CreateTrackerConfigResponse> CreateTrackerConfigInvoker(CreateTrackerConfigRequest createTrackerConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracker-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrackerConfigRequest);
            return new SyncInvoker<CreateTrackerConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<CreateTrackerConfigResponse>);
        }
        
        /// <summary>
        /// 删除记录器
        ///
        /// 删除资源记录器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTrackerConfigResponse DeleteTrackerConfig(DeleteTrackerConfigRequest deleteTrackerConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracker-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrackerConfigRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTrackerConfigResponse>(response);
        }

        public SyncInvoker<DeleteTrackerConfigResponse> DeleteTrackerConfigInvoker(DeleteTrackerConfigRequest deleteTrackerConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracker-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrackerConfigRequest);
            return new SyncInvoker<DeleteTrackerConfigResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTrackerConfigResponse>);
        }
        
        /// <summary>
        /// 查询记录器
        ///
        /// 查询资源记录器的详细信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTrackerConfigResponse ShowTrackerConfig(ShowTrackerConfigRequest showTrackerConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracker-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrackerConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTrackerConfigResponse>(response);
        }

        public SyncInvoker<ShowTrackerConfigResponse> ShowTrackerConfigInvoker(ShowTrackerConfigRequest showTrackerConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-manager/domains/{domain_id}/tracker-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrackerConfigRequest);
            return new SyncInvoker<ShowTrackerConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrackerConfigResponse>);
        }
        
    }
}