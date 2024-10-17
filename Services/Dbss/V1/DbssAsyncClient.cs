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
        /// 添加自建数据库
        ///
        /// 添加自建数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddAuditDatabaseResponse> AddAuditDatabaseAsync(AddAuditDatabaseRequest addAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addAuditDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddAuditDatabaseResponse>(response);
        }

        public AsyncInvoker<AddAuditDatabaseResponse> AddAuditDatabaseAsyncInvoker(AddAuditDatabaseRequest addAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addAuditDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditDatabaseRequest);
            return new AsyncInvoker<AddAuditDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAuditDatabaseResponse>);
        }
        
        /// <summary>
        /// 添加RDS数据库
        ///
        /// 添加RDS数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddRdsDatabaseResponse> AddRdsDatabaseAsync(AddRdsDatabaseRequest addRdsDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addRdsDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addRdsDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddRdsDatabaseResponse>(response);
        }

        public AsyncInvoker<AddRdsDatabaseResponse> AddRdsDatabaseAsyncInvoker(AddRdsDatabaseRequest addRdsDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addRdsDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addRdsDatabaseRequest);
            return new AsyncInvoker<AddRdsDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<AddRdsDatabaseResponse>);
        }
        
        /// <summary>
        /// 添加RDS数据库(V1待下线)
        ///
        /// 添加RDS数据库。V1版本已不再维护，待下线。
        /// 请使用V2版本接口（/v2/{project_id}/{instance_id}/audit/databases/rds）。
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
        /// 删除数据库
        ///
        /// 删除数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAuditDatabaseResponse> DeleteAuditDatabaseAsync(DeleteAuditDatabaseRequest deleteAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteAuditDatabaseRequest.InstanceId.ToString());
            urlParam.Add("db_id", deleteAuditDatabaseRequest.DbId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/{db_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditDatabaseRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditDatabaseResponse>(response);
        }

        public AsyncInvoker<DeleteAuditDatabaseResponse> DeleteAuditDatabaseAsyncInvoker(DeleteAuditDatabaseRequest deleteAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteAuditDatabaseRequest.InstanceId.ToString());
            urlParam.Add("db_id", deleteAuditDatabaseRequest.DbId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/{db_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditDatabaseRequest);
            return new AsyncInvoker<DeleteAuditDatabaseResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditDatabaseResponse>);
        }
        
        /// <summary>
        /// 删除审计实例
        ///
        /// 只有按需计费模式实例没有任务时 或 包周期模式实例状态为故障时，才能执行此操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstancesResponse> DeleteInstancesAsync(DeleteInstancesRequest deleteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteInstancesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInstancesResponse>(response);
        }

        public AsyncInvoker<DeleteInstancesResponse> DeleteInstancesAsyncInvoker(DeleteInstancesRequest deleteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteInstancesRequest);
            return new AsyncInvoker<DeleteInstancesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteInstancesResponse>);
        }
        
        /// <summary>
        /// 查询审计告警信息
        ///
        /// 查询审计告警信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditAlarmLogResponse> ListAuditAlarmLogAsync(ListAuditAlarmLogRequest listAuditAlarmLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditAlarmLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/alarm-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditAlarmLogRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAuditAlarmLogResponse>(response);
        }

        public AsyncInvoker<ListAuditAlarmLogResponse> ListAuditAlarmLogAsyncInvoker(ListAuditAlarmLogRequest listAuditAlarmLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditAlarmLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/alarm-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditAlarmLogRequest);
            return new AsyncInvoker<ListAuditAlarmLogResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditAlarmLogResponse>);
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
        /// 查询审计SQL语句
        ///
        /// 查询审计SQL语句
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditSqlsResponse> ListAuditSqlsAsync(ListAuditSqlsRequest listAuditSqlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditSqlsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/sqls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditSqlsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAuditSqlsResponse>(response);
        }

        public AsyncInvoker<ListAuditSqlsResponse> ListAuditSqlsAsyncInvoker(ListAuditSqlsRequest listAuditSqlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditSqlsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/sqls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditSqlsRequest);
            return new AsyncInvoker<ListAuditSqlsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditSqlsResponse>);
        }
        
        /// <summary>
        /// 查询审计汇总信息
        ///
        /// 查询审计汇总信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditSummaryInfosResponse> ListAuditSummaryInfosAsync(ListAuditSummaryInfosRequest listAuditSummaryInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/summary/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditSummaryInfosRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditSummaryInfosResponse>(response);
        }

        public AsyncInvoker<ListAuditSummaryInfosResponse> ListAuditSummaryInfosAsyncInvoker(ListAuditSummaryInfosRequest listAuditSummaryInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/summary/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditSummaryInfosRequest);
            return new AsyncInvoker<ListAuditSummaryInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditSummaryInfosResponse>);
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
        /// 查询ECS服务器规格信息
        ///
        /// 查询ECS服务器规格信息
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
        /// 查询RDS数据库列表
        ///
        /// 查询RDS数据库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRdsDatabasesResponse> ListRdsDatabasesAsync(ListRdsDatabasesRequest listRdsDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRdsDatabasesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRdsDatabasesResponse>(response);
        }

        public AsyncInvoker<ListRdsDatabasesResponse> ListRdsDatabasesAsyncInvoker(ListRdsDatabasesRequest listRdsDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRdsDatabasesRequest);
            return new AsyncInvoker<ListRdsDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRdsDatabasesResponse>);
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
        /// 重启审计实例
        ///
        /// 重启审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RebootAuditInstanceResponse> RebootAuditInstanceAsync(RebootAuditInstanceRequest rebootAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", rebootAuditInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RebootAuditInstanceResponse>(response);
        }

        public AsyncInvoker<RebootAuditInstanceResponse> RebootAuditInstanceAsyncInvoker(RebootAuditInstanceRequest rebootAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", rebootAuditInstanceRequest);
            return new AsyncInvoker<RebootAuditInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RebootAuditInstanceResponse>);
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
        /// 开启审计实例
        ///
        /// 开启审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartAuditInstanceResponse> StartAuditInstanceAsync(StartAuditInstanceRequest startAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startAuditInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartAuditInstanceResponse>(response);
        }

        public AsyncInvoker<StartAuditInstanceResponse> StartAuditInstanceAsyncInvoker(StartAuditInstanceRequest startAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startAuditInstanceRequest);
            return new AsyncInvoker<StartAuditInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StartAuditInstanceResponse>);
        }
        
        /// <summary>
        /// 关闭审计实例
        ///
        /// 关闭审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopAuditInstanceResponse> StopAuditInstanceAsync(StopAuditInstanceRequest stopAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopAuditInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopAuditInstanceResponse>(response);
        }

        public AsyncInvoker<StopAuditInstanceResponse> StopAuditInstanceAsyncInvoker(StopAuditInstanceRequest stopAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopAuditInstanceRequest);
            return new AsyncInvoker<StopAuditInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StopAuditInstanceResponse>);
        }
        
        /// <summary>
        /// 开启关闭数据库
        ///
        /// 开启关闭数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchAuditDatabaseResponse> SwitchAuditDatabaseAsync(SwitchAuditDatabaseRequest switchAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchAuditDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAuditDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SwitchAuditDatabaseResponse>(response);
        }

        public AsyncInvoker<SwitchAuditDatabaseResponse> SwitchAuditDatabaseAsyncInvoker(SwitchAuditDatabaseRequest switchAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchAuditDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAuditDatabaseRequest);
            return new AsyncInvoker<SwitchAuditDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchAuditDatabaseResponse>);
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
        /// 更新审计实例信息
        ///
        /// 更新审计实例信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAuditInstanceResponse> UpdateAuditInstanceAsync(UpdateAuditInstanceRequest updateAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateAuditInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditInstanceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAuditInstanceResponse>(response);
        }

        public AsyncInvoker<UpdateAuditInstanceResponse> UpdateAuditInstanceAsyncInvoker(UpdateAuditInstanceRequest updateAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateAuditInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditInstanceRequest);
            return new AsyncInvoker<UpdateAuditInstanceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAuditInstanceResponse>);
        }
        
        /// <summary>
        /// 修改实例安全组
        ///
        /// 修改实例安全组
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
        
        /// <summary>
        /// 添加审计数据库Agent
        ///
        /// 添加审计数据库Agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddAuditAgentResponse> AddAuditAgentAsync(AddAuditAgentRequest addAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addAuditAgentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditAgentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddAuditAgentResponse>(response);
        }

        public AsyncInvoker<AddAuditAgentResponse> AddAuditAgentAsyncInvoker(AddAuditAgentRequest addAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addAuditAgentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditAgentRequest);
            return new AsyncInvoker<AddAuditAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAuditAgentResponse>);
        }
        
        /// <summary>
        /// 删除数据库Agent
        ///
        /// 删除数据库Agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAuditAgentResponse> DeleteAuditAgentAsync(DeleteAuditAgentRequest deleteAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteAuditAgentRequest.InstanceId.ToString());
            urlParam.Add("agent_id", deleteAuditAgentRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditAgentRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditAgentResponse>(response);
        }

        public AsyncInvoker<DeleteAuditAgentResponse> DeleteAuditAgentAsyncInvoker(DeleteAuditAgentRequest deleteAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteAuditAgentRequest.InstanceId.ToString());
            urlParam.Add("agent_id", deleteAuditAgentRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditAgentRequest);
            return new AsyncInvoker<DeleteAuditAgentResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditAgentResponse>);
        }
        
        /// <summary>
        /// 下载审计Agent
        ///
        /// 下载审计Agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadAuditAgentResponse> DownloadAuditAgentAsync(DownloadAuditAgentRequest downloadAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", downloadAuditAgentRequest.InstanceId.ToString());
            urlParam.Add("agent_id", downloadAuditAgentRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAuditAgentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadAuditAgentResponse>(response);
        }

        public AsyncInvoker<DownloadAuditAgentResponse> DownloadAuditAgentAsyncInvoker(DownloadAuditAgentRequest downloadAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", downloadAuditAgentRequest.InstanceId.ToString());
            urlParam.Add("agent_id", downloadAuditAgentRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAuditAgentRequest);
            return new AsyncInvoker<DownloadAuditAgentResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadAuditAgentResponse>);
        }
        
        /// <summary>
        /// 查询数据库Agent列表
        ///
        /// 查询数据库Agent列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditAgentResponse> ListAuditAgentAsync(ListAuditAgentRequest listAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditAgentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditAgentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditAgentResponse>(response);
        }

        public AsyncInvoker<ListAuditAgentResponse> ListAuditAgentAsyncInvoker(ListAuditAgentRequest listAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditAgentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditAgentRequest);
            return new AsyncInvoker<ListAuditAgentResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditAgentResponse>);
        }
        
        /// <summary>
        /// 开启关闭Agent
        ///
        /// 用于开启和关闭Agent审计的功能，当开启后，开始抓取用户的访问信息。
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
        
    }
}