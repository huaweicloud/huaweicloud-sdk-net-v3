using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Dbss.V1.Model;

namespace HuaweiCloud.SDK.Dbss.V1
{
    public partial class DbssClient : Client
    {
        public static ClientBuilder<DbssClient> NewBuilder()
        {
            return new ClientBuilder<DbssClient>();
        }

        
        /// <summary>
        /// 添加自建数据库
        ///
        /// 添加自建数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddAuditDatabaseResponse AddAuditDatabase(AddAuditDatabaseRequest addAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addAuditDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddAuditDatabaseResponse>(response);
        }

        public SyncInvoker<AddAuditDatabaseResponse> AddAuditDatabaseInvoker(AddAuditDatabaseRequest addAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addAuditDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditDatabaseRequest);
            return new SyncInvoker<AddAuditDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAuditDatabaseResponse>);
        }
        
        /// <summary>
        /// 添加RDS数据库
        ///
        /// 添加RDS数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddRdsDatabaseResponse AddRdsDatabase(AddRdsDatabaseRequest addRdsDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addRdsDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addRdsDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddRdsDatabaseResponse>(response);
        }

        public SyncInvoker<AddRdsDatabaseResponse> AddRdsDatabaseInvoker(AddRdsDatabaseRequest addRdsDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addRdsDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addRdsDatabaseRequest);
            return new SyncInvoker<AddRdsDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<AddRdsDatabaseResponse>);
        }
        
        /// <summary>
        /// 添加RDS数据库(V1待下线)
        ///
        /// 添加RDS数据库。V1版本已不再维护，待下线。
        /// 请使用V2版本接口（/v2/{project_id}/{instance_id}/audit/databases/rds）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddRdsNoAgentDatabaseResponse AddRdsNoAgentDatabase(AddRdsNoAgentDatabaseRequest addRdsNoAgentDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addRdsNoAgentDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addRdsNoAgentDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddRdsNoAgentDatabaseResponse>(response);
        }

        public SyncInvoker<AddRdsNoAgentDatabaseResponse> AddRdsNoAgentDatabaseInvoker(AddRdsNoAgentDatabaseRequest addRdsNoAgentDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addRdsNoAgentDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addRdsNoAgentDatabaseRequest);
            return new SyncInvoker<AddRdsNoAgentDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<AddRdsNoAgentDatabaseResponse>);
        }
        
        /// <summary>
        /// 包年包月计费模式创建审计实例
        ///
        /// 包年包月计费模式创建审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstancesPeriodOrderResponse CreateInstancesPeriodOrder(CreateInstancesPeriodOrderRequest createInstancesPeriodOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dbss/audit/charge/period/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstancesPeriodOrderRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstancesPeriodOrderResponse>(response);
        }

        public SyncInvoker<CreateInstancesPeriodOrderResponse> CreateInstancesPeriodOrderInvoker(CreateInstancesPeriodOrderRequest createInstancesPeriodOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dbss/audit/charge/period/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstancesPeriodOrderRequest);
            return new SyncInvoker<CreateInstancesPeriodOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstancesPeriodOrderResponse>);
        }
        
        /// <summary>
        /// 删除数据库
        ///
        /// 删除数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAuditDatabaseResponse DeleteAuditDatabase(DeleteAuditDatabaseRequest deleteAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteAuditDatabaseRequest.InstanceId.ToString());
            urlParam.Add("db_id", deleteAuditDatabaseRequest.DbId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/{db_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditDatabaseRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditDatabaseResponse>(response);
        }

        public SyncInvoker<DeleteAuditDatabaseResponse> DeleteAuditDatabaseInvoker(DeleteAuditDatabaseRequest deleteAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteAuditDatabaseRequest.InstanceId.ToString());
            urlParam.Add("db_id", deleteAuditDatabaseRequest.DbId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/{db_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditDatabaseRequest);
            return new SyncInvoker<DeleteAuditDatabaseResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditDatabaseResponse>);
        }
        
        /// <summary>
        /// 删除审计实例
        ///
        /// 只有按需计费模式实例没有任务时 或 包周期模式实例状态为故障时，才能执行此操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstancesResponse DeleteInstances(DeleteInstancesRequest deleteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteInstancesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInstancesResponse>(response);
        }

        public SyncInvoker<DeleteInstancesResponse> DeleteInstancesInvoker(DeleteInstancesRequest deleteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteInstancesRequest);
            return new SyncInvoker<DeleteInstancesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteInstancesResponse>);
        }
        
        /// <summary>
        /// 查询审计告警信息
        ///
        /// 查询审计告警信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditAlarmLogResponse ListAuditAlarmLog(ListAuditAlarmLogRequest listAuditAlarmLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditAlarmLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/alarm-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditAlarmLogRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAuditAlarmLogResponse>(response);
        }

        public SyncInvoker<ListAuditAlarmLogResponse> ListAuditAlarmLogInvoker(ListAuditAlarmLogRequest listAuditAlarmLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditAlarmLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/alarm-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditAlarmLogRequest);
            return new SyncInvoker<ListAuditAlarmLogResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditAlarmLogResponse>);
        }
        
        /// <summary>
        /// 查询数据库列表
        ///
        /// 查询数据库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditDatabasesResponse ListAuditDatabases(ListAuditDatabasesRequest listAuditDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditDatabasesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditDatabasesResponse>(response);
        }

        public SyncInvoker<ListAuditDatabasesResponse> ListAuditDatabasesInvoker(ListAuditDatabasesRequest listAuditDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditDatabasesRequest);
            return new SyncInvoker<ListAuditDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditDatabasesResponse>);
        }
        
        /// <summary>
        /// 查询实例创建任务信息
        ///
        /// 查询实例创建任务信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditInstanceJobsResponse ListAuditInstanceJobs(ListAuditInstanceJobsRequest listAuditInstanceJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", listAuditInstanceJobsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/jobs/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstanceJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditInstanceJobsResponse>(response);
        }

        public SyncInvoker<ListAuditInstanceJobsResponse> ListAuditInstanceJobsInvoker(ListAuditInstanceJobsRequest listAuditInstanceJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", listAuditInstanceJobsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/jobs/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstanceJobsRequest);
            return new SyncInvoker<ListAuditInstanceJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditInstanceJobsResponse>);
        }
        
        /// <summary>
        /// 查询审计实例列表
        ///
        /// 查询审计实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditInstancesResponse ListAuditInstances(ListAuditInstancesRequest listAuditInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditInstancesResponse>(response);
        }

        public SyncInvoker<ListAuditInstancesResponse> ListAuditInstancesInvoker(ListAuditInstancesRequest listAuditInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstancesRequest);
            return new SyncInvoker<ListAuditInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditInstancesResponse>);
        }
        
        /// <summary>
        /// 查询用户操作日志信息
        ///
        /// 查询用户操作日志信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditOperateLogsResponse ListAuditOperateLogs(ListAuditOperateLogsRequest listAuditOperateLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditOperateLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/operate-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditOperateLogsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAuditOperateLogsResponse>(response);
        }

        public SyncInvoker<ListAuditOperateLogsResponse> ListAuditOperateLogsInvoker(ListAuditOperateLogsRequest listAuditOperateLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditOperateLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/operate-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditOperateLogsRequest);
            return new SyncInvoker<ListAuditOperateLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditOperateLogsResponse>);
        }
        
        /// <summary>
        /// 查询风险规则策略
        ///
        /// 查询风险规则策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditRuleRisksResponse ListAuditRuleRisks(ListAuditRuleRisksRequest listAuditRuleRisksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditRuleRisksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/risk", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleRisksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditRuleRisksResponse>(response);
        }

        public SyncInvoker<ListAuditRuleRisksResponse> ListAuditRuleRisksInvoker(ListAuditRuleRisksRequest listAuditRuleRisksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditRuleRisksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/risk", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleRisksRequest);
            return new SyncInvoker<ListAuditRuleRisksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditRuleRisksResponse>);
        }
        
        /// <summary>
        /// 查询审计范围策略列表
        ///
        /// 查询审计范围策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditRuleScopesResponse ListAuditRuleScopes(ListAuditRuleScopesRequest listAuditRuleScopesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditRuleScopesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/scopes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleScopesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditRuleScopesResponse>(response);
        }

        public SyncInvoker<ListAuditRuleScopesResponse> ListAuditRuleScopesInvoker(ListAuditRuleScopesRequest listAuditRuleScopesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditRuleScopesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/scopes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleScopesRequest);
            return new SyncInvoker<ListAuditRuleScopesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditRuleScopesResponse>);
        }
        
        /// <summary>
        /// 查询隐私数据脱敏规则
        ///
        /// 查询隐私数据脱敏规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditSensitiveMasksResponse ListAuditSensitiveMasks(ListAuditSensitiveMasksRequest listAuditSensitiveMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditSensitiveMasksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/sensitive/masks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditSensitiveMasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditSensitiveMasksResponse>(response);
        }

        public SyncInvoker<ListAuditSensitiveMasksResponse> ListAuditSensitiveMasksInvoker(ListAuditSensitiveMasksRequest listAuditSensitiveMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditSensitiveMasksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/sensitive/masks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditSensitiveMasksRequest);
            return new SyncInvoker<ListAuditSensitiveMasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditSensitiveMasksResponse>);
        }
        
        /// <summary>
        /// 查询审计SQL语句
        ///
        /// 查询审计SQL语句
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditSqlsResponse ListAuditSqls(ListAuditSqlsRequest listAuditSqlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditSqlsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/sqls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditSqlsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAuditSqlsResponse>(response);
        }

        public SyncInvoker<ListAuditSqlsResponse> ListAuditSqlsInvoker(ListAuditSqlsRequest listAuditSqlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditSqlsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/sqls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditSqlsRequest);
            return new SyncInvoker<ListAuditSqlsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditSqlsResponse>);
        }
        
        /// <summary>
        /// 查询审计汇总信息
        ///
        /// 查询审计汇总信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditSummaryInfosResponse ListAuditSummaryInfos(ListAuditSummaryInfosRequest listAuditSummaryInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/summary/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditSummaryInfosRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditSummaryInfosResponse>(response);
        }

        public SyncInvoker<ListAuditSummaryInfosResponse> ListAuditSummaryInfosInvoker(ListAuditSummaryInfosRequest listAuditSummaryInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/summary/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditSummaryInfosRequest);
            return new SyncInvoker<ListAuditSummaryInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditSummaryInfosResponse>);
        }
        
        /// <summary>
        /// 查询可用区信息
        ///
        /// 查询可用区信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAvailabilityZoneInfosResponse ListAvailabilityZoneInfos(ListAvailabilityZoneInfosRequest listAvailabilityZoneInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dbss/audit/availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZoneInfosRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAvailabilityZoneInfosResponse>(response);
        }

        public SyncInvoker<ListAvailabilityZoneInfosResponse> ListAvailabilityZoneInfosInvoker(ListAvailabilityZoneInfosRequest listAvailabilityZoneInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dbss/audit/availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZoneInfosRequest);
            return new SyncInvoker<ListAvailabilityZoneInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailabilityZoneInfosResponse>);
        }
        
        /// <summary>
        /// 查询ECS服务器规格信息
        ///
        /// 查询ECS服务器规格信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEcsSpecificationResponse ListEcsSpecification(ListEcsSpecificationRequest listEcsSpecificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/specification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEcsSpecificationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEcsSpecificationResponse>(response);
        }

        public SyncInvoker<ListEcsSpecificationResponse> ListEcsSpecificationInvoker(ListEcsSpecificationRequest listEcsSpecificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/specification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEcsSpecificationRequest);
            return new SyncInvoker<ListEcsSpecificationResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEcsSpecificationResponse>);
        }
        
        /// <summary>
        /// 查询RDS数据库列表
        ///
        /// 查询RDS数据库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRdsDatabasesResponse ListRdsDatabases(ListRdsDatabasesRequest listRdsDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRdsDatabasesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRdsDatabasesResponse>(response);
        }

        public SyncInvoker<ListRdsDatabasesResponse> ListRdsDatabasesInvoker(ListRdsDatabasesRequest listRdsDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRdsDatabasesRequest);
            return new SyncInvoker<ListRdsDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRdsDatabasesResponse>);
        }
        
        /// <summary>
        /// 查询SQL注入规则策略
        ///
        /// 查询SQL注入规则策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSqlInjectionRulesResponse ListSqlInjectionRules(ListSqlInjectionRulesRequest listSqlInjectionRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSqlInjectionRulesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/sql-injections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSqlInjectionRulesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListSqlInjectionRulesResponse>(response);
        }

        public SyncInvoker<ListSqlInjectionRulesResponse> ListSqlInjectionRulesInvoker(ListSqlInjectionRulesRequest listSqlInjectionRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSqlInjectionRulesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/sql-injections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSqlInjectionRulesRequest);
            return new SyncInvoker<ListSqlInjectionRulesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSqlInjectionRulesResponse>);
        }
        
        /// <summary>
        /// 重启审计实例
        ///
        /// 重启审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RebootAuditInstanceResponse RebootAuditInstance(RebootAuditInstanceRequest rebootAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", rebootAuditInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RebootAuditInstanceResponse>(response);
        }

        public SyncInvoker<RebootAuditInstanceResponse> RebootAuditInstanceInvoker(RebootAuditInstanceRequest rebootAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", rebootAuditInstanceRequest);
            return new SyncInvoker<RebootAuditInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RebootAuditInstanceResponse>);
        }
        
        /// <summary>
        /// 查询账户配额信息
        ///
        /// 查询账户配额信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAuditQuotaResponse ShowAuditQuota(ShowAuditQuotaRequest showAuditQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditQuotaResponse>(response);
        }

        public SyncInvoker<ShowAuditQuotaResponse> ShowAuditQuotaInvoker(ShowAuditQuotaRequest showAuditQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditQuotaRequest);
            return new SyncInvoker<ShowAuditQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditQuotaResponse>);
        }
        
        /// <summary>
        /// 查询指定风险规则策略
        ///
        /// 查询指定风险规则策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAuditRuleRiskResponse ShowAuditRuleRisk(ShowAuditRuleRiskRequest showAuditRuleRiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAuditRuleRiskRequest.InstanceId.ToString());
            urlParam.Add("risk_id", showAuditRuleRiskRequest.RiskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/risk/{risk_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditRuleRiskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditRuleRiskResponse>(response);
        }

        public SyncInvoker<ShowAuditRuleRiskResponse> ShowAuditRuleRiskInvoker(ShowAuditRuleRiskRequest showAuditRuleRiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAuditRuleRiskRequest.InstanceId.ToString());
            urlParam.Add("risk_id", showAuditRuleRiskRequest.RiskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/risk/{risk_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditRuleRiskRequest);
            return new SyncInvoker<ShowAuditRuleRiskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditRuleRiskResponse>);
        }
        
        /// <summary>
        /// 开启审计实例
        ///
        /// 开启审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartAuditInstanceResponse StartAuditInstance(StartAuditInstanceRequest startAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startAuditInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartAuditInstanceResponse>(response);
        }

        public SyncInvoker<StartAuditInstanceResponse> StartAuditInstanceInvoker(StartAuditInstanceRequest startAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startAuditInstanceRequest);
            return new SyncInvoker<StartAuditInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StartAuditInstanceResponse>);
        }
        
        /// <summary>
        /// 关闭审计实例
        ///
        /// 关闭审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopAuditInstanceResponse StopAuditInstance(StopAuditInstanceRequest stopAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopAuditInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopAuditInstanceResponse>(response);
        }

        public SyncInvoker<StopAuditInstanceResponse> StopAuditInstanceInvoker(StopAuditInstanceRequest stopAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopAuditInstanceRequest);
            return new SyncInvoker<StopAuditInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StopAuditInstanceResponse>);
        }
        
        /// <summary>
        /// 开启关闭数据库
        ///
        /// 开启关闭数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchAuditDatabaseResponse SwitchAuditDatabase(SwitchAuditDatabaseRequest switchAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchAuditDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAuditDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchAuditDatabaseResponse>(response);
        }

        public SyncInvoker<SwitchAuditDatabaseResponse> SwitchAuditDatabaseInvoker(SwitchAuditDatabaseRequest switchAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchAuditDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAuditDatabaseRequest);
            return new SyncInvoker<SwitchAuditDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchAuditDatabaseResponse>);
        }
        
        /// <summary>
        /// 开启关闭风险规则
        ///
        /// 开启关闭风险规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchRiskRuleResponse SwitchRiskRule(SwitchRiskRuleRequest switchRiskRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchRiskRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/rule/risk/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchRiskRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchRiskRuleResponse>(response);
        }

        public SyncInvoker<SwitchRiskRuleResponse> SwitchRiskRuleInvoker(SwitchRiskRuleRequest switchRiskRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchRiskRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/rule/risk/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchRiskRuleRequest);
            return new SyncInvoker<SwitchRiskRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchRiskRuleResponse>);
        }
        
        /// <summary>
        /// 更新审计实例信息
        ///
        /// 更新审计实例信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAuditInstanceResponse UpdateAuditInstance(UpdateAuditInstanceRequest updateAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateAuditInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditInstanceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAuditInstanceResponse>(response);
        }

        public SyncInvoker<UpdateAuditInstanceResponse> UpdateAuditInstanceInvoker(UpdateAuditInstanceRequest updateAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateAuditInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditInstanceRequest);
            return new SyncInvoker<UpdateAuditInstanceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAuditInstanceResponse>);
        }
        
        /// <summary>
        /// 修改实例安全组
        ///
        /// 修改实例安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAuditSecurityGroupResponse UpdateAuditSecurityGroup(UpdateAuditSecurityGroupRequest updateAuditSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditSecurityGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateAuditSecurityGroupResponse>(response);
        }

        public SyncInvoker<UpdateAuditSecurityGroupResponse> UpdateAuditSecurityGroupInvoker(UpdateAuditSecurityGroupRequest updateAuditSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditSecurityGroupRequest);
            return new SyncInvoker<UpdateAuditSecurityGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAuditSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 添加审计数据库Agent
        ///
        /// 添加审计数据库Agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddAuditAgentResponse AddAuditAgent(AddAuditAgentRequest addAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addAuditAgentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditAgentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddAuditAgentResponse>(response);
        }

        public SyncInvoker<AddAuditAgentResponse> AddAuditAgentInvoker(AddAuditAgentRequest addAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addAuditAgentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditAgentRequest);
            return new SyncInvoker<AddAuditAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAuditAgentResponse>);
        }
        
        /// <summary>
        /// 删除数据库Agent
        ///
        /// 删除数据库Agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAuditAgentResponse DeleteAuditAgent(DeleteAuditAgentRequest deleteAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteAuditAgentRequest.InstanceId.ToString());
            urlParam.Add("agent_id", deleteAuditAgentRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditAgentRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditAgentResponse>(response);
        }

        public SyncInvoker<DeleteAuditAgentResponse> DeleteAuditAgentInvoker(DeleteAuditAgentRequest deleteAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteAuditAgentRequest.InstanceId.ToString());
            urlParam.Add("agent_id", deleteAuditAgentRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditAgentRequest);
            return new SyncInvoker<DeleteAuditAgentResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditAgentResponse>);
        }
        
        /// <summary>
        /// 下载审计Agent
        ///
        /// 下载审计Agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadAuditAgentResponse DownloadAuditAgent(DownloadAuditAgentRequest downloadAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", downloadAuditAgentRequest.InstanceId.ToString());
            urlParam.Add("agent_id", downloadAuditAgentRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAuditAgentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadAuditAgentResponse>(response);
        }

        public SyncInvoker<DownloadAuditAgentResponse> DownloadAuditAgentInvoker(DownloadAuditAgentRequest downloadAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", downloadAuditAgentRequest.InstanceId.ToString());
            urlParam.Add("agent_id", downloadAuditAgentRequest.AgentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAuditAgentRequest);
            return new SyncInvoker<DownloadAuditAgentResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadAuditAgentResponse>);
        }
        
        /// <summary>
        /// 查询数据库Agent列表
        ///
        /// 查询数据库Agent列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditAgentResponse ListAuditAgent(ListAuditAgentRequest listAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditAgentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditAgentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditAgentResponse>(response);
        }

        public SyncInvoker<ListAuditAgentResponse> ListAuditAgentInvoker(ListAuditAgentRequest listAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditAgentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditAgentRequest);
            return new SyncInvoker<ListAuditAgentResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditAgentResponse>);
        }
        
        /// <summary>
        /// 开启关闭Agent
        ///
        /// 用于开启和关闭Agent审计的功能，当开启后，开始抓取用户的访问信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchAgentResponse SwitchAgent(SwitchAgentRequest switchAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchAgentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/agent/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAgentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchAgentResponse>(response);
        }

        public SyncInvoker<SwitchAgentResponse> SwitchAgentInvoker(SwitchAgentRequest switchAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchAgentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/agent/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAgentRequest);
            return new SyncInvoker<SwitchAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchAgentResponse>);
        }
        
        /// <summary>
        /// 批量添加资源标签
        ///
        /// 批量添加资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchAddResourceTagResponse BatchAddResourceTag(BatchAddResourceTagRequest batchAddResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchAddResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchAddResourceTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddResourceTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchAddResourceTagResponse>(response);
        }

        public SyncInvoker<BatchAddResourceTagResponse> BatchAddResourceTagInvoker(BatchAddResourceTagRequest batchAddResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchAddResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchAddResourceTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddResourceTagRequest);
            return new SyncInvoker<BatchAddResourceTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchAddResourceTagResponse>);
        }
        
        /// <summary>
        /// 批量删除资源标签
        ///
        /// 批量删除资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteResourceTagResponse BatchDeleteResourceTag(BatchDeleteResourceTagRequest batchDeleteResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchDeleteResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchDeleteResourceTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteResourceTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<BatchDeleteResourceTagResponse>(response);
        }

        public SyncInvoker<BatchDeleteResourceTagResponse> BatchDeleteResourceTagInvoker(BatchDeleteResourceTagRequest batchDeleteResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchDeleteResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchDeleteResourceTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteResourceTagRequest);
            return new SyncInvoker<BatchDeleteResourceTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<BatchDeleteResourceTagResponse>);
        }
        
        /// <summary>
        /// 根据标签查询资源实例数量
        ///
        /// 根据标签查询资源实例数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountResourceInstanceByTagResponse CountResourceInstanceByTag(CountResourceInstanceByTagRequest countResourceInstanceByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", countResourceInstanceByTagRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", countResourceInstanceByTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CountResourceInstanceByTagResponse>(response);
        }

        public SyncInvoker<CountResourceInstanceByTagResponse> CountResourceInstanceByTagInvoker(CountResourceInstanceByTagRequest countResourceInstanceByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", countResourceInstanceByTagRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", countResourceInstanceByTagRequest);
            return new SyncInvoker<CountResourceInstanceByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<CountResourceInstanceByTagResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询项目标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectResourceTagsResponse ListProjectResourceTags(ListProjectResourceTagsRequest listProjectResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listProjectResourceTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectResourceTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProjectResourceTagsResponse>(response);
        }

        public SyncInvoker<ListProjectResourceTagsResponse> ListProjectResourceTagsInvoker(ListProjectResourceTagsRequest listProjectResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listProjectResourceTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectResourceTagsRequest);
            return new SyncInvoker<ListProjectResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectResourceTagsResponse>);
        }
        
        /// <summary>
        /// 根据标签查询资源实例列表
        ///
        /// 根据标签查询资源实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceInstanceByTagResponse ListResourceInstanceByTag(ListResourceInstanceByTagRequest listResourceInstanceByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceInstanceByTagRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstanceByTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListResourceInstanceByTagResponse>(response);
        }

        public SyncInvoker<ListResourceInstanceByTagResponse> ListResourceInstanceByTagInvoker(ListResourceInstanceByTagRequest listResourceInstanceByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceInstanceByTagRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstanceByTagRequest);
            return new SyncInvoker<ListResourceInstanceByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceInstanceByTagResponse>);
        }
        
    }
}