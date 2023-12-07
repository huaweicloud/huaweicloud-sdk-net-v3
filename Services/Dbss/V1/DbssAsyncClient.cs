using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Dbss.V1.Model;

namespace HuaweiCloud.SDK.Dbss.V1
{
    public partial class DbssAsyncClient : Client
    {
        public static ClientBuilder<DbssAsyncClient> NewBuilder()
        {
            return new ClientBuilder<DbssAsyncClient>();
        }

        
        /// <summary>
        /// 添加RDS免agent数据库
        ///
        /// 添加RDS免agent数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddRdsNoAgentDatabaseResponse> AddRdsNoAgentDatabaseAsync(AddRdsNoAgentDatabaseRequest addRdsNoAgentDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addRdsNoAgentDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addRdsNoAgentDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddRdsNoAgentDatabaseResponse>(response);
        }

        public AsyncInvoker<AddRdsNoAgentDatabaseResponse> AddRdsNoAgentDatabaseAsyncInvoker(AddRdsNoAgentDatabaseRequest addRdsNoAgentDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addRdsNoAgentDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addRdsNoAgentDatabaseRequest);
            return new AsyncInvoker<AddRdsNoAgentDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<AddRdsNoAgentDatabaseResponse>);
        }
        
        /// <summary>
        /// 批量添加资源标签
        ///
        /// 批量添加资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchAddResourceTagResponse> BatchAddResourceTagAsync(BatchAddResourceTagRequest batchAddResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchAddResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchAddResourceTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddResourceTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchAddResourceTagResponse>(response);
        }

        public AsyncInvoker<BatchAddResourceTagResponse> BatchAddResourceTagAsyncInvoker(BatchAddResourceTagRequest batchAddResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchAddResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchAddResourceTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddResourceTagRequest);
            return new AsyncInvoker<BatchAddResourceTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchAddResourceTagResponse>);
        }
        
        /// <summary>
        /// 批量删除资源标签
        ///
        /// 批量删除资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteResourceTagResponse> BatchDeleteResourceTagAsync(BatchDeleteResourceTagRequest batchDeleteResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchDeleteResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchDeleteResourceTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteResourceTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<BatchDeleteResourceTagResponse>(response);
        }

        public AsyncInvoker<BatchDeleteResourceTagResponse> BatchDeleteResourceTagAsyncInvoker(BatchDeleteResourceTagRequest batchDeleteResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchDeleteResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchDeleteResourceTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteResourceTagRequest);
            return new AsyncInvoker<BatchDeleteResourceTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<BatchDeleteResourceTagResponse>);
        }
        
        /// <summary>
        /// 根据标签查询资源实例数量
        ///
        /// 根据标签查询资源实例数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountResourceInstanceByTagResponse> CountResourceInstanceByTagAsync(CountResourceInstanceByTagRequest countResourceInstanceByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", countResourceInstanceByTagRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", countResourceInstanceByTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CountResourceInstanceByTagResponse>(response);
        }

        public AsyncInvoker<CountResourceInstanceByTagResponse> CountResourceInstanceByTagAsyncInvoker(CountResourceInstanceByTagRequest countResourceInstanceByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", countResourceInstanceByTagRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", countResourceInstanceByTagRequest);
            return new AsyncInvoker<CountResourceInstanceByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<CountResourceInstanceByTagResponse>);
        }
        
        /// <summary>
        /// 包年包月计费模式创建审计实例
        ///
        /// 包年包月计费模式创建审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstancesPeriodOrderResponse> CreateInstancesPeriodOrderAsync(CreateInstancesPeriodOrderRequest createInstancesPeriodOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dbss/audit/charge/period/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstancesPeriodOrderRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstancesPeriodOrderResponse>(response);
        }

        public AsyncInvoker<CreateInstancesPeriodOrderResponse> CreateInstancesPeriodOrderAsyncInvoker(CreateInstancesPeriodOrderRequest createInstancesPeriodOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dbss/audit/charge/period/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstancesPeriodOrderRequest);
            return new AsyncInvoker<CreateInstancesPeriodOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstancesPeriodOrderResponse>);
        }
        
        /// <summary>
        /// 查询数据库列表
        ///
        /// 查询数据库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditDatabasesResponse> ListAuditDatabasesAsync(ListAuditDatabasesRequest listAuditDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditDatabasesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditDatabasesResponse>(response);
        }

        public AsyncInvoker<ListAuditDatabasesResponse> ListAuditDatabasesAsyncInvoker(ListAuditDatabasesRequest listAuditDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditDatabasesRequest);
            return new AsyncInvoker<ListAuditDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditDatabasesResponse>);
        }
        
        /// <summary>
        /// 查询实例创建任务信息
        ///
        /// 查询实例创建任务信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditInstanceJobsResponse> ListAuditInstanceJobsAsync(ListAuditInstanceJobsRequest listAuditInstanceJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", listAuditInstanceJobsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/jobs/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstanceJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditInstanceJobsResponse>(response);
        }

        public AsyncInvoker<ListAuditInstanceJobsResponse> ListAuditInstanceJobsAsyncInvoker(ListAuditInstanceJobsRequest listAuditInstanceJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", listAuditInstanceJobsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/jobs/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstanceJobsRequest);
            return new AsyncInvoker<ListAuditInstanceJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditInstanceJobsResponse>);
        }
        
        /// <summary>
        /// 查询审计实例列表
        ///
        /// 查询审计实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditInstancesResponse> ListAuditInstancesAsync(ListAuditInstancesRequest listAuditInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditInstancesResponse>(response);
        }

        public AsyncInvoker<ListAuditInstancesResponse> ListAuditInstancesAsyncInvoker(ListAuditInstancesRequest listAuditInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstancesRequest);
            return new AsyncInvoker<ListAuditInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditInstancesResponse>);
        }
        
        /// <summary>
        /// 查询用户操作日志信息
        ///
        /// 查询用户操作日志信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditOperateLogsResponse> ListAuditOperateLogsAsync(ListAuditOperateLogsRequest listAuditOperateLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditOperateLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/operate-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditOperateLogsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAuditOperateLogsResponse>(response);
        }

        public AsyncInvoker<ListAuditOperateLogsResponse> ListAuditOperateLogsAsyncInvoker(ListAuditOperateLogsRequest listAuditOperateLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditOperateLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/operate-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditOperateLogsRequest);
            return new AsyncInvoker<ListAuditOperateLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditOperateLogsResponse>);
        }
        
        /// <summary>
        /// 查询风险规则策略
        ///
        /// 查询风险规则策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditRuleRisksResponse> ListAuditRuleRisksAsync(ListAuditRuleRisksRequest listAuditRuleRisksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditRuleRisksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/risk", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleRisksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditRuleRisksResponse>(response);
        }

        public AsyncInvoker<ListAuditRuleRisksResponse> ListAuditRuleRisksAsyncInvoker(ListAuditRuleRisksRequest listAuditRuleRisksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditRuleRisksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/risk", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleRisksRequest);
            return new AsyncInvoker<ListAuditRuleRisksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditRuleRisksResponse>);
        }
        
        /// <summary>
        /// 查询审计范围策略列表
        ///
        /// 查询审计范围策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditRuleScopesResponse> ListAuditRuleScopesAsync(ListAuditRuleScopesRequest listAuditRuleScopesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditRuleScopesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/scopes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleScopesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditRuleScopesResponse>(response);
        }

        public AsyncInvoker<ListAuditRuleScopesResponse> ListAuditRuleScopesAsyncInvoker(ListAuditRuleScopesRequest listAuditRuleScopesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditRuleScopesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/scopes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleScopesRequest);
            return new AsyncInvoker<ListAuditRuleScopesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditRuleScopesResponse>);
        }
        
        /// <summary>
        /// 查询隐私数据脱敏规则
        ///
        /// 查询隐私数据脱敏规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditSensitiveMasksResponse> ListAuditSensitiveMasksAsync(ListAuditSensitiveMasksRequest listAuditSensitiveMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditSensitiveMasksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/sensitive/masks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditSensitiveMasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditSensitiveMasksResponse>(response);
        }

        public AsyncInvoker<ListAuditSensitiveMasksResponse> ListAuditSensitiveMasksAsyncInvoker(ListAuditSensitiveMasksRequest listAuditSensitiveMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditSensitiveMasksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/sensitive/masks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditSensitiveMasksRequest);
            return new AsyncInvoker<ListAuditSensitiveMasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditSensitiveMasksResponse>);
        }
        
        /// <summary>
        /// 查询可用区信息
        ///
        /// 查询可用区信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAvailabilityZoneInfosResponse> ListAvailabilityZoneInfosAsync(ListAvailabilityZoneInfosRequest listAvailabilityZoneInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dbss/audit/availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZoneInfosRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAvailabilityZoneInfosResponse>(response);
        }

        public AsyncInvoker<ListAvailabilityZoneInfosResponse> ListAvailabilityZoneInfosAsyncInvoker(ListAvailabilityZoneInfosRequest listAvailabilityZoneInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dbss/audit/availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZoneInfosRequest);
            return new AsyncInvoker<ListAvailabilityZoneInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailabilityZoneInfosResponse>);
        }
        
        /// <summary>
        /// 查询ecs服务器规格信息
        ///
        /// 查询ecs服务器规格信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEcsSpecificationResponse> ListEcsSpecificationAsync(ListEcsSpecificationRequest listEcsSpecificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/specification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEcsSpecificationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEcsSpecificationResponse>(response);
        }

        public AsyncInvoker<ListEcsSpecificationResponse> ListEcsSpecificationAsyncInvoker(ListEcsSpecificationRequest listEcsSpecificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/specification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEcsSpecificationRequest);
            return new AsyncInvoker<ListEcsSpecificationResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEcsSpecificationResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询项目标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectResourceTagsResponse> ListProjectResourceTagsAsync(ListProjectResourceTagsRequest listProjectResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listProjectResourceTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectResourceTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProjectResourceTagsResponse>(response);
        }

        public AsyncInvoker<ListProjectResourceTagsResponse> ListProjectResourceTagsAsyncInvoker(ListProjectResourceTagsRequest listProjectResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listProjectResourceTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectResourceTagsRequest);
            return new AsyncInvoker<ListProjectResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectResourceTagsResponse>);
        }
        
        /// <summary>
        /// 根据标签查询资源实例列表
        ///
        /// 根据标签查询资源实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceInstanceByTagResponse> ListResourceInstanceByTagAsync(ListResourceInstanceByTagRequest listResourceInstanceByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceInstanceByTagRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstanceByTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListResourceInstanceByTagResponse>(response);
        }

        public AsyncInvoker<ListResourceInstanceByTagResponse> ListResourceInstanceByTagAsyncInvoker(ListResourceInstanceByTagRequest listResourceInstanceByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceInstanceByTagRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstanceByTagRequest);
            return new AsyncInvoker<ListResourceInstanceByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceInstanceByTagResponse>);
        }
        
        /// <summary>
        /// 查询SQL注入规则策略
        ///
        /// 查询SQL注入规则策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSqlInjectionRulesResponse> ListSqlInjectionRulesAsync(ListSqlInjectionRulesRequest listSqlInjectionRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSqlInjectionRulesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/sql-injections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSqlInjectionRulesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListSqlInjectionRulesResponse>(response);
        }

        public AsyncInvoker<ListSqlInjectionRulesResponse> ListSqlInjectionRulesAsyncInvoker(ListSqlInjectionRulesRequest listSqlInjectionRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSqlInjectionRulesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/sql-injections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSqlInjectionRulesRequest);
            return new AsyncInvoker<ListSqlInjectionRulesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSqlInjectionRulesResponse>);
        }
        
        /// <summary>
        /// 查询账户配额信息
        ///
        /// 查询账户配额信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAuditQuotaResponse> ShowAuditQuotaAsync(ShowAuditQuotaRequest showAuditQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditQuotaResponse>(response);
        }

        public AsyncInvoker<ShowAuditQuotaResponse> ShowAuditQuotaAsyncInvoker(ShowAuditQuotaRequest showAuditQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditQuotaRequest);
            return new AsyncInvoker<ShowAuditQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditQuotaResponse>);
        }
        
        /// <summary>
        /// 查询指定风险规则策略
        ///
        /// 查询指定风险规则策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAuditRuleRiskResponse> ShowAuditRuleRiskAsync(ShowAuditRuleRiskRequest showAuditRuleRiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAuditRuleRiskRequest.InstanceId.ToString());
            urlParam.Add("risk_id", showAuditRuleRiskRequest.RiskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/risk/{risk_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditRuleRiskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditRuleRiskResponse>(response);
        }

        public AsyncInvoker<ShowAuditRuleRiskResponse> ShowAuditRuleRiskAsyncInvoker(ShowAuditRuleRiskRequest showAuditRuleRiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAuditRuleRiskRequest.InstanceId.ToString());
            urlParam.Add("risk_id", showAuditRuleRiskRequest.RiskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/risk/{risk_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditRuleRiskRequest);
            return new AsyncInvoker<ShowAuditRuleRiskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditRuleRiskResponse>);
        }
        
        /// <summary>
        /// 开启关闭Agent
        ///
        /// 用于开启和关闭agent的功能，当开启后，开始抓取用户的访问信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchAgentResponse> SwitchAgentAsync(SwitchAgentRequest switchAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchAgentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/agent/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAgentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SwitchAgentResponse>(response);
        }

        public AsyncInvoker<SwitchAgentResponse> SwitchAgentAsyncInvoker(SwitchAgentRequest switchAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchAgentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/agent/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAgentRequest);
            return new AsyncInvoker<SwitchAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchAgentResponse>);
        }
        
        /// <summary>
        /// 开启关闭风险规则
        ///
        /// 开启关闭风险规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchRiskRuleResponse> SwitchRiskRuleAsync(SwitchRiskRuleRequest switchRiskRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchRiskRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/rule/risk/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchRiskRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SwitchRiskRuleResponse>(response);
        }

        public AsyncInvoker<SwitchRiskRuleResponse> SwitchRiskRuleAsyncInvoker(SwitchRiskRuleRequest switchRiskRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchRiskRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/rule/risk/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchRiskRuleRequest);
            return new AsyncInvoker<SwitchRiskRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchRiskRuleResponse>);
        }
        
        /// <summary>
        /// 修改安全组
        ///
        /// 修改安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAuditSecurityGroupResponse> UpdateAuditSecurityGroupAsync(UpdateAuditSecurityGroupRequest updateAuditSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditSecurityGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateAuditSecurityGroupResponse>(response);
        }

        public AsyncInvoker<UpdateAuditSecurityGroupResponse> UpdateAuditSecurityGroupAsyncInvoker(UpdateAuditSecurityGroupRequest updateAuditSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditSecurityGroupRequest);
            return new AsyncInvoker<UpdateAuditSecurityGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAuditSecurityGroupResponse>);
        }
        
    }
}