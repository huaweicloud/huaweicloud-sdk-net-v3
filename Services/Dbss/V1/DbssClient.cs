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
        /// 添加审计数据库Agent[待下线]
        ///
        /// 添加审计数据库Agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AddAuditAgentResponse AddAuditAgent(AddAuditAgentRequest addAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addAuditAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditAgentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddAuditAgentResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<AddAuditAgentResponse> AddAuditAgentInvoker(AddAuditAgentRequest addAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addAuditAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditAgentRequest);
            return new SyncInvoker<AddAuditAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAuditAgentResponse>);
        }
        
        /// <summary>
        /// 添加自建数据库[待下线]
        ///
        /// 添加自建数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AddAuditDatabaseResponse AddAuditDatabase(AddAuditDatabaseRequest addAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addAuditDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddAuditDatabaseResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<AddAuditDatabaseResponse> AddAuditDatabaseInvoker(AddAuditDatabaseRequest addAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addAuditDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditDatabaseRequest);
            return new SyncInvoker<AddAuditDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAuditDatabaseResponse>);
        }
        
        /// <summary>
        /// 添加自建数据库
        ///
        /// 添加自建数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddAuditDatabaseNewResponse AddAuditDatabaseNew(AddAuditDatabaseNewRequest addAuditDatabaseNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addAuditDatabaseNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditDatabaseNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddAuditDatabaseNewResponse>(response);
        }

        public SyncInvoker<AddAuditDatabaseNewResponse> AddAuditDatabaseNewInvoker(AddAuditDatabaseNewRequest addAuditDatabaseNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addAuditDatabaseNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditDatabaseNewRequest);
            return new SyncInvoker<AddAuditDatabaseNewResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAuditDatabaseNewResponse>);
        }
        
        /// <summary>
        /// 添加RDS数据库[待下线]
        ///
        /// 添加RDS数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AddRdsDatabaseResponse AddRdsDatabase(AddRdsDatabaseRequest addRdsDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRdsDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addRdsDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddRdsDatabaseResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<AddRdsDatabaseResponse> AddRdsDatabaseInvoker(AddRdsDatabaseRequest addRdsDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRdsDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addRdsDatabaseRequest);
            return new SyncInvoker<AddRdsDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<AddRdsDatabaseResponse>);
        }
        
        /// <summary>
        /// 添加RDS数据库
        ///
        /// 添加RDS数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddRdsDatabaseNewResponse AddRdsDatabaseNew(AddRdsDatabaseNewRequest addRdsDatabaseNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRdsDatabaseNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addRdsDatabaseNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddRdsDatabaseNewResponse>(response);
        }

        public SyncInvoker<AddRdsDatabaseNewResponse> AddRdsDatabaseNewInvoker(AddRdsDatabaseNewRequest addRdsDatabaseNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRdsDatabaseNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addRdsDatabaseNewRequest);
            return new SyncInvoker<AddRdsDatabaseNewResponse>(this, "POST", request, JsonUtils.DeSerialize<AddRdsDatabaseNewResponse>);
        }
        
        /// <summary>
        /// 添加RDS数据库[待下线]
        ///
        /// 添加RDS数据库。V1版本已不再维护，待下线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AddRdsNoAgentDatabaseResponse AddRdsNoAgentDatabase(AddRdsNoAgentDatabaseRequest addRdsNoAgentDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRdsNoAgentDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addRdsNoAgentDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddRdsNoAgentDatabaseResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<AddRdsNoAgentDatabaseResponse> AddRdsNoAgentDatabaseInvoker(AddRdsNoAgentDatabaseRequest addRdsNoAgentDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRdsNoAgentDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addRdsNoAgentDatabaseRequest);
            return new SyncInvoker<AddRdsNoAgentDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<AddRdsNoAgentDatabaseResponse>);
        }
        
        /// <summary>
        /// 审计范围规则操作-删除策略
        ///
        /// 审计范围规则操作-删除策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteAuditScopeResponse BatchDeleteAuditScope(BatchDeleteAuditScopeRequest batchDeleteAuditScopeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteAuditScopeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/scopes/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAuditScopeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteAuditScopeResponse>(response);
        }

        public SyncInvoker<BatchDeleteAuditScopeResponse> BatchDeleteAuditScopeInvoker(BatchDeleteAuditScopeRequest batchDeleteAuditScopeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteAuditScopeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/scopes/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAuditScopeRequest);
            return new SyncInvoker<BatchDeleteAuditScopeResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteAuditScopeResponse>);
        }
        
        /// <summary>
        /// 批量标记
        ///
        /// 批量标记
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchSetAuditAlarmLogStatusResponse BatchSetAuditAlarmLogStatus(BatchSetAuditAlarmLogStatusRequest batchSetAuditAlarmLogStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchSetAuditAlarmLogStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/alarm-log/mark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetAuditAlarmLogStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchSetAuditAlarmLogStatusResponse>(response);
        }

        public SyncInvoker<BatchSetAuditAlarmLogStatusResponse> BatchSetAuditAlarmLogStatusInvoker(BatchSetAuditAlarmLogStatusRequest batchSetAuditAlarmLogStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchSetAuditAlarmLogStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/alarm-log/mark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetAuditAlarmLogStatusRequest);
            return new SyncInvoker<BatchSetAuditAlarmLogStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchSetAuditAlarmLogStatusResponse>);
        }
        
        /// <summary>
        /// 绑定数据库加密实例的EIP
        ///
        /// 绑定数据库加密实例的EIP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BindDbEncryptEipResponse BindDbEncryptEip(BindDbEncryptEipRequest bindDbEncryptEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(bindDbEncryptEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/eip/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", bindDbEncryptEipRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BindDbEncryptEipResponse>(response);
        }

        public SyncInvoker<BindDbEncryptEipResponse> BindDbEncryptEipInvoker(BindDbEncryptEipRequest bindDbEncryptEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(bindDbEncryptEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/eip/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", bindDbEncryptEipRequest);
            return new SyncInvoker<BindDbEncryptEipResponse>(this, "POST", request, JsonUtils.DeSerialize<BindDbEncryptEipResponse>);
        }
        
        /// <summary>
        /// 绑定数据库运维实例的EIP
        ///
        /// 绑定数据库运维实例的EIP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BindDbOmEipResponse BindDbOmEip(BindDbOmEipRequest bindDbOmEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(bindDbOmEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/eip/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", bindDbOmEipRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BindDbOmEipResponse>(response);
        }

        public SyncInvoker<BindDbOmEipResponse> BindDbOmEipInvoker(BindDbOmEipRequest bindDbOmEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(bindDbOmEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/eip/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", bindDbOmEipRequest);
            return new SyncInvoker<BindDbOmEipResponse>(this, "POST", request, JsonUtils.DeSerialize<BindDbOmEipResponse>);
        }
        
        /// <summary>
        /// 更改数据库加密实例的安全组
        ///
        /// 更改数据库加密实例的安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeDbEncryptSecurityGroupResponse ChangeDbEncryptSecurityGroup(ChangeDbEncryptSecurityGroupRequest changeDbEncryptSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeDbEncryptSecurityGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeDbEncryptSecurityGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ChangeDbEncryptSecurityGroupResponse>(response);
        }

        public SyncInvoker<ChangeDbEncryptSecurityGroupResponse> ChangeDbEncryptSecurityGroupInvoker(ChangeDbEncryptSecurityGroupRequest changeDbEncryptSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeDbEncryptSecurityGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeDbEncryptSecurityGroupRequest);
            return new SyncInvoker<ChangeDbEncryptSecurityGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeDbEncryptSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 更改数据库运维实例的安全组
        ///
        /// 更改数据库运维实例的安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeDbOmSecurityGroupResponse ChangeDbOmSecurityGroup(ChangeDbOmSecurityGroupRequest changeDbOmSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeDbOmSecurityGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeDbOmSecurityGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ChangeDbOmSecurityGroupResponse>(response);
        }

        public SyncInvoker<ChangeDbOmSecurityGroupResponse> ChangeDbOmSecurityGroupInvoker(ChangeDbOmSecurityGroupRequest changeDbOmSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeDbOmSecurityGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeDbOmSecurityGroupRequest);
            return new SyncInvoker<ChangeDbOmSecurityGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeDbOmSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 触发审计实例升级
        ///
        /// 触发审计实例升级
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ConfirmUpgradeAuditResponse ConfirmUpgradeAudit(ConfirmUpgradeAuditRequest confirmUpgradeAuditRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(confirmUpgradeAuditRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{resource_id}/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmUpgradeAuditRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ConfirmUpgradeAuditResponse>(response);
        }

        public SyncInvoker<ConfirmUpgradeAuditResponse> ConfirmUpgradeAuditInvoker(ConfirmUpgradeAuditRequest confirmUpgradeAuditRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(confirmUpgradeAuditRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{resource_id}/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmUpgradeAuditRequest);
            return new SyncInvoker<ConfirmUpgradeAuditResponse>(this, "POST", request, JsonUtils.DeSerialize<ConfirmUpgradeAuditResponse>);
        }
        
        /// <summary>
        /// 查询数据库用户会话分布
        ///
        /// 查询数据库用户会话分布
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountDbAccountSessionResponse CountDbAccountSession(CountDbAccountSessionRequest countDbAccountSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countDbAccountSessionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/session/db-account", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countDbAccountSessionRequest);
            var response = DoHttpRequestSync("POST", request);
            var countDbAccountSessionResponse = JsonUtils.DeSerializeNull<CountDbAccountSessionResponse>(response);
            countDbAccountSessionResponse.Body = JsonUtils.DeSerializeList<ReportAccountSessionNew>(response);
            return countDbAccountSessionResponse;
        }

        public SyncInvoker<CountDbAccountSessionResponse> CountDbAccountSessionInvoker(CountDbAccountSessionRequest countDbAccountSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countDbAccountSessionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/session/db-account", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countDbAccountSessionRequest);
            return new SyncInvoker<CountDbAccountSessionResponse>(this, "POST", request, response =>
            {
                var countDbAccountSessionResponse = JsonUtils.DeSerializeNull<CountDbAccountSessionResponse>(response);
                countDbAccountSessionResponse.Body = JsonUtils.DeSerializeList<ReportAccountSessionNew>(response);
                return countDbAccountSessionResponse;
            });
        }
        
        /// <summary>
        /// 查询客户端会话分布
        ///
        /// 查询客户端会话分布
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountDbClientSessionResponse CountDbClientSession(CountDbClientSessionRequest countDbClientSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countDbClientSessionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/session/db-client", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countDbClientSessionRequest);
            var response = DoHttpRequestSync("POST", request);
            var countDbClientSessionResponse = JsonUtils.DeSerializeNull<CountDbClientSessionResponse>(response);
            countDbClientSessionResponse.Body = JsonUtils.DeSerializeList<ReportClientSessionNew>(response);
            return countDbClientSessionResponse;
        }

        public SyncInvoker<CountDbClientSessionResponse> CountDbClientSessionInvoker(CountDbClientSessionRequest countDbClientSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countDbClientSessionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/session/db-client", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countDbClientSessionRequest);
            return new SyncInvoker<CountDbClientSessionResponse>(this, "POST", request, response =>
            {
                var countDbClientSessionResponse = JsonUtils.DeSerializeNull<CountDbClientSessionResponse>(response);
                countDbClientSessionResponse.Body = JsonUtils.DeSerializeList<ReportClientSessionNew>(response);
                return countDbClientSessionResponse;
            });
        }
        
        /// <summary>
        /// 获取指定时间段内的sql注入分布统计
        ///
        /// 获取指定时间段内的sql注入分布统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountInjectionStatisticsResponse CountInjectionStatistics(CountInjectionStatisticsRequest countInjectionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countInjectionStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/sql-injection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countInjectionStatisticsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CountInjectionStatisticsResponse>(response);
        }

        public SyncInvoker<CountInjectionStatisticsResponse> CountInjectionStatisticsInvoker(CountInjectionStatisticsRequest countInjectionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countInjectionStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/sql-injection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countInjectionStatisticsRequest);
            return new SyncInvoker<CountInjectionStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<CountInjectionStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取指定时间段内的风险操作数量分布统计
        ///
        /// 获取指定时间段内的风险操作数量分布统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountOperationStatisticsResponse CountOperationStatistics(CountOperationStatisticsRequest countOperationStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countOperationStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/risk-operation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countOperationStatisticsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CountOperationStatisticsResponse>(response);
        }

        public SyncInvoker<CountOperationStatisticsResponse> CountOperationStatisticsInvoker(CountOperationStatisticsRequest countOperationStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countOperationStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/risk-operation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countOperationStatisticsRequest);
            return new SyncInvoker<CountOperationStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<CountOperationStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取指定时间段内的风险分布统计
        ///
        /// 获取指定时间段内的风险分布统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountRiskTrendStatisticsResponse CountRiskTrendStatistics(CountRiskTrendStatisticsRequest countRiskTrendStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countRiskTrendStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/risk-level", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countRiskTrendStatisticsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CountRiskTrendStatisticsResponse>(response);
        }

        public SyncInvoker<CountRiskTrendStatisticsResponse> CountRiskTrendStatisticsInvoker(CountRiskTrendStatisticsRequest countRiskTrendStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countRiskTrendStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/risk-level", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countRiskTrendStatisticsRequest);
            return new SyncInvoker<CountRiskTrendStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<CountRiskTrendStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取指定时间段内的查询会话统计
        ///
        /// 获取指定时间段内的查询会话统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountSessionStatisticsResponse CountSessionStatistics(CountSessionStatisticsRequest countSessionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countSessionStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/session", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countSessionStatisticsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CountSessionStatisticsResponse>(response);
        }

        public SyncInvoker<CountSessionStatisticsResponse> CountSessionStatisticsInvoker(CountSessionStatisticsRequest countSessionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countSessionStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/session", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countSessionStatisticsRequest);
            return new SyncInvoker<CountSessionStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<CountSessionStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取指定时间段内的SQL分布统计
        ///
        /// 获取指定时间段内的SQL分布统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountSqlStatisticsResponse CountSqlStatistics(CountSqlStatisticsRequest countSqlStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countSqlStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/sql-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countSqlStatisticsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CountSqlStatisticsResponse>(response);
        }

        public SyncInvoker<CountSqlStatisticsResponse> CountSqlStatisticsInvoker(CountSqlStatisticsRequest countSqlStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countSqlStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/sql-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countSqlStatisticsRequest);
            return new SyncInvoker<CountSqlStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<CountSqlStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取指定时间段内的sql数量分布统计
        ///
        /// 获取指定时间段内的sql数量分布统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountSqlTrendStatisticsResponse CountSqlTrendStatistics(CountSqlTrendStatisticsRequest countSqlTrendStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countSqlTrendStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/sql-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countSqlTrendStatisticsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CountSqlTrendStatisticsResponse>(response);
        }

        public SyncInvoker<CountSqlTrendStatisticsResponse> CountSqlTrendStatisticsInvoker(CountSqlTrendStatisticsRequest countSqlTrendStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countSqlTrendStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/sql-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countSqlTrendStatisticsRequest);
            return new SyncInvoker<CountSqlTrendStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<CountSqlTrendStatisticsResponse>);
        }
        
        /// <summary>
        /// 添加风险规则
        ///
        /// 添加风险规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAuditRiskRuleResponse CreateAuditRiskRule(CreateAuditRiskRuleRequest createAuditRiskRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAuditRiskRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/risk", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuditRiskRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAuditRiskRuleResponse>(response);
        }

        public SyncInvoker<CreateAuditRiskRuleResponse> CreateAuditRiskRuleInvoker(CreateAuditRiskRuleRequest createAuditRiskRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAuditRiskRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/risk", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuditRiskRuleRequest);
            return new SyncInvoker<CreateAuditRiskRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAuditRiskRuleResponse>);
        }
        
        /// <summary>
        /// 添加审计范围策略
        ///
        /// 添加审计范围策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAuditScopeRuleResponse CreateAuditScopeRule(CreateAuditScopeRuleRequest createAuditScopeRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAuditScopeRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/scopes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuditScopeRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAuditScopeRuleResponse>(response);
        }

        public SyncInvoker<CreateAuditScopeRuleResponse> CreateAuditScopeRuleInvoker(CreateAuditScopeRuleRequest createAuditScopeRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAuditScopeRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/scopes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuditScopeRuleRequest);
            return new SyncInvoker<CreateAuditScopeRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAuditScopeRuleResponse>);
        }
        
        /// <summary>
        /// 按包周期方式购买数据库加密实例
        ///
        /// 按包周期方式购买数据库加密实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDbEncryptInstancePeriodResponse CreateDbEncryptInstancePeriod(CreateDbEncryptInstancePeriodRequest createDbEncryptInstancePeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/db-encrypt/charge/period/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbEncryptInstancePeriodRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDbEncryptInstancePeriodResponse>(response);
        }

        public SyncInvoker<CreateDbEncryptInstancePeriodResponse> CreateDbEncryptInstancePeriodInvoker(CreateDbEncryptInstancePeriodRequest createDbEncryptInstancePeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/db-encrypt/charge/period/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbEncryptInstancePeriodRequest);
            return new SyncInvoker<CreateDbEncryptInstancePeriodResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDbEncryptInstancePeriodResponse>);
        }
        
        /// <summary>
        /// 包周期购买数据库运维实例
        ///
        /// 包周期购买数据库运维实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDbOmInstancePeriodResponse CreateDbOmInstancePeriod(CreateDbOmInstancePeriodRequest createDbOmInstancePeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/db-om/charge/period/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbOmInstancePeriodRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDbOmInstancePeriodResponse>(response);
        }

        public SyncInvoker<CreateDbOmInstancePeriodResponse> CreateDbOmInstancePeriodInvoker(CreateDbOmInstancePeriodRequest createDbOmInstancePeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/db-om/charge/period/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbOmInstancePeriodRequest);
            return new SyncInvoker<CreateDbOmInstancePeriodResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDbOmInstancePeriodResponse>);
        }
        
        /// <summary>
        /// 包年包月计费模式创建审计实例[待下线]
        ///
        /// 包年包月计费模式创建审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public CreateInstancesPeriodOrderResponse CreateInstancesPeriodOrder(CreateInstancesPeriodOrderRequest createInstancesPeriodOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dbss/audit/charge/period/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstancesPeriodOrderRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstancesPeriodOrderResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<CreateInstancesPeriodOrderResponse> CreateInstancesPeriodOrderInvoker(CreateInstancesPeriodOrderRequest createInstancesPeriodOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dbss/audit/charge/period/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstancesPeriodOrderRequest);
            return new SyncInvoker<CreateInstancesPeriodOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstancesPeriodOrderResponse>);
        }
        
        /// <summary>
        /// 包年包月计费模式创建审计实例
        ///
        /// 包年包月计费模式创建审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstancesPeriodOrderNewResponse CreateInstancesPeriodOrderNew(CreateInstancesPeriodOrderNewRequest createInstancesPeriodOrderNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/charge/period/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstancesPeriodOrderNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstancesPeriodOrderNewResponse>(response);
        }

        public SyncInvoker<CreateInstancesPeriodOrderNewResponse> CreateInstancesPeriodOrderNewInvoker(CreateInstancesPeriodOrderNewRequest createInstancesPeriodOrderNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/charge/period/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstancesPeriodOrderNewRequest);
            return new SyncInvoker<CreateInstancesPeriodOrderNewResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstancesPeriodOrderNewResponse>);
        }
        
        /// <summary>
        /// 立即生成报表
        ///
        /// 立即生成报表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateReportResponse CreateReport(CreateReportRequest createReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createReportRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/reports/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReportRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateReportResponse>(response);
        }

        public SyncInvoker<CreateReportResponse> CreateReportInvoker(CreateReportRequest createReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createReportRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/reports/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReportRequest);
            return new SyncInvoker<CreateReportResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateReportResponse>);
        }
        
        /// <summary>
        /// 增加隐私数据脱敏规则
        ///
        /// 增加隐私数据脱敏规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSensitiveMaskRuleResponse CreateSensitiveMaskRule(CreateSensitiveMaskRuleRequest createSensitiveMaskRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSensitiveMaskRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSensitiveMaskRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSensitiveMaskRuleResponse>(response);
        }

        public SyncInvoker<CreateSensitiveMaskRuleResponse> CreateSensitiveMaskRuleInvoker(CreateSensitiveMaskRuleRequest createSensitiveMaskRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSensitiveMaskRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSensitiveMaskRuleRequest);
            return new SyncInvoker<CreateSensitiveMaskRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSensitiveMaskRuleResponse>);
        }
        
        /// <summary>
        /// 删除数据库Agent[待下线]
        ///
        /// 删除数据库Agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public DeleteAuditAgentResponse DeleteAuditAgent(DeleteAuditAgentRequest deleteAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAgentRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditAgentRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditAgentResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<DeleteAuditAgentResponse> DeleteAuditAgentInvoker(DeleteAuditAgentRequest deleteAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAgentRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditAgentRequest);
            return new SyncInvoker<DeleteAuditAgentResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditAgentResponse>);
        }
        
        /// <summary>
        /// 删除告警监控记录
        ///
        /// 删除告警监控记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAuditAlarmLogResponse DeleteAuditAlarmLog(DeleteAuditAlarmLogRequest deleteAuditAlarmLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAlarmLogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAlarmLogRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/alarm-log/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditAlarmLogRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditAlarmLogResponse>(response);
        }

        public SyncInvoker<DeleteAuditAlarmLogResponse> DeleteAuditAlarmLogInvoker(DeleteAuditAlarmLogRequest deleteAuditAlarmLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAlarmLogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAlarmLogRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/alarm-log/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditAlarmLogRequest);
            return new SyncInvoker<DeleteAuditAlarmLogResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditAlarmLogResponse>);
        }
        
        /// <summary>
        /// 删除指定备份任务
        ///
        /// 删除指定备份任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAuditBackupTaskResponse DeleteAuditBackupTask(DeleteAuditBackupTaskRequest deleteAuditBackupTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditBackupTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditBackupTaskRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backups/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditBackupTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditBackupTaskResponse>(response);
        }

        public SyncInvoker<DeleteAuditBackupTaskResponse> DeleteAuditBackupTaskInvoker(DeleteAuditBackupTaskRequest deleteAuditBackupTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditBackupTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditBackupTaskRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backups/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditBackupTaskRequest);
            return new SyncInvoker<DeleteAuditBackupTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditBackupTaskResponse>);
        }
        
        /// <summary>
        /// 删除数据库[待下线]
        ///
        /// 删除数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public DeleteAuditDatabaseResponse DeleteAuditDatabase(DeleteAuditDatabaseRequest deleteAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditDatabaseRequest.DbId, out var valueOfDbId)) urlParam.Add("db_id", valueOfDbId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/{db_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditDatabaseRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditDatabaseResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<DeleteAuditDatabaseResponse> DeleteAuditDatabaseInvoker(DeleteAuditDatabaseRequest deleteAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditDatabaseRequest.DbId, out var valueOfDbId)) urlParam.Add("db_id", valueOfDbId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/{db_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditDatabaseRequest);
            return new SyncInvoker<DeleteAuditDatabaseResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditDatabaseResponse>);
        }
        
        /// <summary>
        /// 删除数据库
        ///
        /// 删除数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAuditDatabaseNewResponse DeleteAuditDatabaseNew(DeleteAuditDatabaseNewRequest deleteAuditDatabaseNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditDatabaseNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditDatabaseNewRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/databases/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditDatabaseNewRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditDatabaseNewResponse>(response);
        }

        public SyncInvoker<DeleteAuditDatabaseNewResponse> DeleteAuditDatabaseNewInvoker(DeleteAuditDatabaseNewRequest deleteAuditDatabaseNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditDatabaseNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditDatabaseNewRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/databases/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditDatabaseNewRequest);
            return new SyncInvoker<DeleteAuditDatabaseNewResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditDatabaseNewResponse>);
        }
        
        /// <summary>
        /// 删除报表
        ///
        /// 删除报表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAuditReportResponse DeleteAuditReport(DeleteAuditReportRequest deleteAuditReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditReportRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditReportRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/reports/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditReportRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditReportResponse>(response);
        }

        public SyncInvoker<DeleteAuditReportResponse> DeleteAuditReportInvoker(DeleteAuditReportRequest deleteAuditReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditReportRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditReportRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/reports/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditReportRequest);
            return new SyncInvoker<DeleteAuditReportResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditReportResponse>);
        }
        
        /// <summary>
        /// 删除风险策略
        ///
        /// 删除风险策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAuditRuleRiskResponse DeleteAuditRuleRisk(DeleteAuditRuleRiskRequest deleteAuditRuleRiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditRuleRiskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditRuleRiskRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/risk/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditRuleRiskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditRuleRiskResponse>(response);
        }

        public SyncInvoker<DeleteAuditRuleRiskResponse> DeleteAuditRuleRiskInvoker(DeleteAuditRuleRiskRequest deleteAuditRuleRiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditRuleRiskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditRuleRiskRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/risk/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditRuleRiskRequest);
            return new SyncInvoker<DeleteAuditRuleRiskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditRuleRiskResponse>);
        }
        
        /// <summary>
        /// 删除审计范围策略
        ///
        /// 删除审计范围策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAuditScopeResponse DeleteAuditScope(DeleteAuditScopeRequest deleteAuditScopeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditScopeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditScopeRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/scopes/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditScopeRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditScopeResponse>(response);
        }

        public SyncInvoker<DeleteAuditScopeResponse> DeleteAuditScopeInvoker(DeleteAuditScopeRequest deleteAuditScopeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditScopeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditScopeRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/scopes/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditScopeRequest);
            return new SyncInvoker<DeleteAuditScopeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditScopeResponse>);
        }
        
        /// <summary>
        /// 删除数据库加密实例
        ///
        /// 删除数据库加密实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDbEncryptInstanceResponse DeleteDbEncryptInstance(DeleteDbEncryptInstanceRequest deleteDbEncryptInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDbEncryptInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbEncryptInstanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDbEncryptInstanceResponse>(response);
        }

        public SyncInvoker<DeleteDbEncryptInstanceResponse> DeleteDbEncryptInstanceInvoker(DeleteDbEncryptInstanceRequest deleteDbEncryptInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDbEncryptInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbEncryptInstanceRequest);
            return new SyncInvoker<DeleteDbEncryptInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDbEncryptInstanceResponse>);
        }
        
        /// <summary>
        /// 删除数据库运维实例
        ///
        /// 删除数据库运维实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDbOmInstanceResponse DeleteDbOmInstance(DeleteDbOmInstanceRequest deleteDbOmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDbOmInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbOmInstanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDbOmInstanceResponse>(response);
        }

        public SyncInvoker<DeleteDbOmInstanceResponse> DeleteDbOmInstanceInvoker(DeleteDbOmInstanceRequest deleteDbOmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDbOmInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbOmInstanceRequest);
            return new SyncInvoker<DeleteDbOmInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDbOmInstanceResponse>);
        }
        
        /// <summary>
        /// 删除审计实例[待下线]
        ///
        /// 只有按需计费模式实例没有任务时 或 包周期模式实例状态为故障时，才能执行此操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public DeleteInstancesResponse DeleteInstances(DeleteInstancesRequest deleteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteInstancesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInstancesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<DeleteInstancesResponse> DeleteInstancesInvoker(DeleteInstancesRequest deleteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteInstancesRequest);
            return new SyncInvoker<DeleteInstancesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteInstancesResponse>);
        }
        
        /// <summary>
        /// 删除审计实例
        ///
        /// 只有按需计费模式实例没有任务时 或 包周期模式实例状态为故障时，才能执行此操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstancesNewResponse DeleteInstancesNew(DeleteInstancesNewRequest deleteInstancesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteInstancesNewRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInstancesNewResponse>(response);
        }

        public SyncInvoker<DeleteInstancesNewResponse> DeleteInstancesNewInvoker(DeleteInstancesNewRequest deleteInstancesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteInstancesNewRequest);
            return new SyncInvoker<DeleteInstancesNewResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteInstancesNewResponse>);
        }
        
        /// <summary>
        /// 删除隐私数据脱敏规则
        ///
        /// 删除隐私数据脱敏规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSensitiveRulesResponse DeleteSensitiveRules(DeleteSensitiveRulesRequest deleteSensitiveRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSensitiveRulesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSensitiveRulesRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/rule/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSensitiveRulesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSensitiveRulesResponse>(response);
        }

        public SyncInvoker<DeleteSensitiveRulesResponse> DeleteSensitiveRulesInvoker(DeleteSensitiveRulesRequest deleteSensitiveRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSensitiveRulesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSensitiveRulesRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/rule/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSensitiveRulesRequest);
            return new SyncInvoker<DeleteSensitiveRulesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSensitiveRulesResponse>);
        }
        
        /// <summary>
        /// 下载审计Agent[待下线]
        ///
        /// 下载审计Agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public DownloadAuditAgentResponse DownloadAuditAgent(DownloadAuditAgentRequest downloadAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditAgentRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAuditAgentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadAuditAgentResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<DownloadAuditAgentResponse> DownloadAuditAgentInvoker(DownloadAuditAgentRequest downloadAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditAgentRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAuditAgentRequest);
            return new SyncInvoker<DownloadAuditAgentResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadAuditAgentResponse>);
        }
        
        /// <summary>
        /// 下载报表
        ///
        /// 下载报表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadAuditReportResponse DownloadAuditReport(DownloadAuditReportRequest downloadAuditReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditReportRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditReportRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/reports/{id}/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAuditReportRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadAuditReportResponse>(response);
        }

        public SyncInvoker<DownloadAuditReportResponse> DownloadAuditReportInvoker(DownloadAuditReportRequest downloadAuditReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditReportRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditReportRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/reports/{id}/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAuditReportRequest);
            return new SyncInvoker<DownloadAuditReportResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadAuditReportResponse>);
        }
        
        /// <summary>
        /// 获取实例告警配置[待下线]
        ///
        /// 获取实例告警配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ListAlarmTopicConfigInfoResponse ListAlarmTopicConfigInfo(ListAlarmTopicConfigInfoRequest listAlarmTopicConfigInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmTopicConfigInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/alarm/topic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTopicConfigInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmTopicConfigInfoResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ListAlarmTopicConfigInfoResponse> ListAlarmTopicConfigInfoInvoker(ListAlarmTopicConfigInfoRequest listAlarmTopicConfigInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmTopicConfigInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/alarm/topic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTopicConfigInfoRequest);
            return new SyncInvoker<ListAlarmTopicConfigInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmTopicConfigInfoResponse>);
        }
        
        /// <summary>
        /// 获取实例告警配置
        ///
        /// 获取实例告警配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAlarmTopicConfigInfoNewResponse ListAlarmTopicConfigInfoNew(ListAlarmTopicConfigInfoNewRequest listAlarmTopicConfigInfoNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmTopicConfigInfoNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/alarm/topic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTopicConfigInfoNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmTopicConfigInfoNewResponse>(response);
        }

        public SyncInvoker<ListAlarmTopicConfigInfoNewResponse> ListAlarmTopicConfigInfoNewInvoker(ListAlarmTopicConfigInfoNewRequest listAlarmTopicConfigInfoNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmTopicConfigInfoNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/alarm/topic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTopicConfigInfoNewRequest);
            return new SyncInvoker<ListAlarmTopicConfigInfoNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmTopicConfigInfoNewResponse>);
        }
        
        /// <summary>
        /// 查询数据库Agent列表[待下线]
        ///
        /// 查询数据库Agent列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ListAuditAgentResponse ListAuditAgent(ListAuditAgentRequest listAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditAgentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditAgentResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ListAuditAgentResponse> ListAuditAgentInvoker(ListAuditAgentRequest listAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditAgentRequest);
            return new SyncInvoker<ListAuditAgentResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditAgentResponse>);
        }
        
        /// <summary>
        /// 查询审计告警信息[待下线]
        ///
        /// 查询审计告警信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ListAuditAlarmLogResponse ListAuditAlarmLog(ListAuditAlarmLogRequest listAuditAlarmLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditAlarmLogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/alarm-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditAlarmLogRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAuditAlarmLogResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ListAuditAlarmLogResponse> ListAuditAlarmLogInvoker(ListAuditAlarmLogRequest listAuditAlarmLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditAlarmLogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/alarm-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditAlarmLogRequest);
            return new SyncInvoker<ListAuditAlarmLogResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditAlarmLogResponse>);
        }
        
        /// <summary>
        /// 查询审计告警信息
        ///
        /// 查询审计告警信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditAlarmLogNewResponse ListAuditAlarmLogNew(ListAuditAlarmLogNewRequest listAuditAlarmLogNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditAlarmLogNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/alarm-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditAlarmLogNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAuditAlarmLogNewResponse>(response);
        }

        public SyncInvoker<ListAuditAlarmLogNewResponse> ListAuditAlarmLogNewInvoker(ListAuditAlarmLogNewRequest listAuditAlarmLogNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditAlarmLogNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/alarm-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditAlarmLogNewRequest);
            return new SyncInvoker<ListAuditAlarmLogNewResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditAlarmLogNewResponse>);
        }
        
        /// <summary>
        /// 获取所有备份信息
        ///
        /// 获取所有备份信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditBackupInfoResponse ListAuditBackupInfo(ListAuditBackupInfoRequest listAuditBackupInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditBackupInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditBackupInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAuditBackupInfoResponse>(response);
        }

        public SyncInvoker<ListAuditBackupInfoResponse> ListAuditBackupInfoInvoker(ListAuditBackupInfoRequest listAuditBackupInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditBackupInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditBackupInfoRequest);
            return new SyncInvoker<ListAuditBackupInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditBackupInfoResponse>);
        }
        
        /// <summary>
        /// 获取风险导出配置列表
        ///
        /// 获取风险导出配置列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditBackupRiskTemplatesResponse ListAuditBackupRiskTemplates(ListAuditBackupRiskTemplatesRequest listAuditBackupRiskTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditBackupRiskTemplatesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/risk/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditBackupRiskTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditBackupRiskTemplatesResponse>(response);
        }

        public SyncInvoker<ListAuditBackupRiskTemplatesResponse> ListAuditBackupRiskTemplatesInvoker(ListAuditBackupRiskTemplatesRequest listAuditBackupRiskTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditBackupRiskTemplatesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/risk/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditBackupRiskTemplatesRequest);
            return new SyncInvoker<ListAuditBackupRiskTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditBackupRiskTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询数据库列表[待下线]
        ///
        /// 查询数据库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ListAuditDatabasesResponse ListAuditDatabases(ListAuditDatabasesRequest listAuditDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditDatabasesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditDatabasesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditDatabasesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ListAuditDatabasesResponse> ListAuditDatabasesInvoker(ListAuditDatabasesRequest listAuditDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditDatabasesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditDatabasesRequest);
            return new SyncInvoker<ListAuditDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditDatabasesResponse>);
        }
        
        /// <summary>
        /// 查询数据库列表
        ///
        /// 查询数据库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditDatabasesNewResponse ListAuditDatabasesNew(ListAuditDatabasesNewRequest listAuditDatabasesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditDatabasesNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditDatabasesNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditDatabasesNewResponse>(response);
        }

        public SyncInvoker<ListAuditDatabasesNewResponse> ListAuditDatabasesNewInvoker(ListAuditDatabasesNewRequest listAuditDatabasesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditDatabasesNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditDatabasesNewRequest);
            return new SyncInvoker<ListAuditDatabasesNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditDatabasesNewResponse>);
        }
        
        /// <summary>
        /// 查询实例创建任务信息[待下线]
        ///
        /// 查询实例创建任务信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ListAuditInstanceJobsResponse ListAuditInstanceJobs(ListAuditInstanceJobsRequest listAuditInstanceJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditInstanceJobsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/jobs/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstanceJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditInstanceJobsResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ListAuditInstanceJobsResponse> ListAuditInstanceJobsInvoker(ListAuditInstanceJobsRequest listAuditInstanceJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditInstanceJobsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/jobs/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstanceJobsRequest);
            return new SyncInvoker<ListAuditInstanceJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditInstanceJobsResponse>);
        }
        
        /// <summary>
        /// 查询实例创建任务信息
        ///
        /// 查询实例创建任务信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditInstanceJobsNewResponse ListAuditInstanceJobsNew(ListAuditInstanceJobsNewRequest listAuditInstanceJobsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditInstanceJobsNewRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{resource_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstanceJobsNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditInstanceJobsNewResponse>(response);
        }

        public SyncInvoker<ListAuditInstanceJobsNewResponse> ListAuditInstanceJobsNewInvoker(ListAuditInstanceJobsNewRequest listAuditInstanceJobsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditInstanceJobsNewRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{resource_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstanceJobsNewRequest);
            return new SyncInvoker<ListAuditInstanceJobsNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditInstanceJobsNewResponse>);
        }
        
        /// <summary>
        /// 查询审计实例列表[待下线]
        ///
        /// 查询审计实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ListAuditInstancesResponse ListAuditInstances(ListAuditInstancesRequest listAuditInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditInstancesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ListAuditInstancesResponse> ListAuditInstancesInvoker(ListAuditInstancesRequest listAuditInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstancesRequest);
            return new SyncInvoker<ListAuditInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditInstancesResponse>);
        }
        
        /// <summary>
        /// 查询审计实例列表
        ///
        /// 查询审计实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditInstancesNewResponse ListAuditInstancesNew(ListAuditInstancesNewRequest listAuditInstancesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstancesNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditInstancesNewResponse>(response);
        }

        public SyncInvoker<ListAuditInstancesNewResponse> ListAuditInstancesNewInvoker(ListAuditInstancesNewRequest listAuditInstancesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstancesNewRequest);
            return new SyncInvoker<ListAuditInstancesNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditInstancesNewResponse>);
        }
        
        /// <summary>
        /// 备份或风险导出时，选择obs桶
        ///
        /// 备份或风险导出时，选择obs桶
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditObsBucketsResponse ListAuditObsBuckets(ListAuditObsBucketsRequest listAuditObsBucketsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/backup/obs-buckets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditObsBucketsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditObsBucketsResponse>(response);
        }

        public SyncInvoker<ListAuditObsBucketsResponse> ListAuditObsBucketsInvoker(ListAuditObsBucketsRequest listAuditObsBucketsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/backup/obs-buckets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditObsBucketsRequest);
            return new SyncInvoker<ListAuditObsBucketsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditObsBucketsResponse>);
        }
        
        /// <summary>
        /// 查询用户操作日志信息[待下线]
        ///
        /// 查询用户操作日志信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ListAuditOperateLogsResponse ListAuditOperateLogs(ListAuditOperateLogsRequest listAuditOperateLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditOperateLogsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/operate-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditOperateLogsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAuditOperateLogsResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ListAuditOperateLogsResponse> ListAuditOperateLogsInvoker(ListAuditOperateLogsRequest listAuditOperateLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditOperateLogsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/operate-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditOperateLogsRequest);
            return new SyncInvoker<ListAuditOperateLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditOperateLogsResponse>);
        }
        
        /// <summary>
        /// 查询用户操作日志信息
        ///
        /// 查询用户操作日志信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditOperateLogsNewResponse ListAuditOperateLogsNew(ListAuditOperateLogsNewRequest listAuditOperateLogsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditOperateLogsNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/operation-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditOperateLogsNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAuditOperateLogsNewResponse>(response);
        }

        public SyncInvoker<ListAuditOperateLogsNewResponse> ListAuditOperateLogsNewInvoker(ListAuditOperateLogsNewRequest listAuditOperateLogsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditOperateLogsNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/operation-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditOperateLogsNewRequest);
            return new SyncInvoker<ListAuditOperateLogsNewResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditOperateLogsNewResponse>);
        }
        
        /// <summary>
        /// 获取报表模板
        ///
        /// 获取报表模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditReportTemplatesResponse ListAuditReportTemplates(ListAuditReportTemplatesRequest listAuditReportTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditReportTemplatesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/reports/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditReportTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditReportTemplatesResponse>(response);
        }

        public SyncInvoker<ListAuditReportTemplatesResponse> ListAuditReportTemplatesInvoker(ListAuditReportTemplatesRequest listAuditReportTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditReportTemplatesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/reports/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditReportTemplatesRequest);
            return new SyncInvoker<ListAuditReportTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditReportTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询报表
        ///
        /// 查询报表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditReportsResponse ListAuditReports(ListAuditReportsRequest listAuditReportsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditReportsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/reports/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditReportsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAuditReportsResponse>(response);
        }

        public SyncInvoker<ListAuditReportsResponse> ListAuditReportsInvoker(ListAuditReportsRequest listAuditReportsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditReportsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/reports/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditReportsRequest);
            return new SyncInvoker<ListAuditReportsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditReportsResponse>);
        }
        
        /// <summary>
        /// 查询风险规则策略[待下线]
        ///
        /// 查询风险规则策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ListAuditRuleRisksResponse ListAuditRuleRisks(ListAuditRuleRisksRequest listAuditRuleRisksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditRuleRisksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/risk", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleRisksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditRuleRisksResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ListAuditRuleRisksResponse> ListAuditRuleRisksInvoker(ListAuditRuleRisksRequest listAuditRuleRisksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditRuleRisksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/risk", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleRisksRequest);
            return new SyncInvoker<ListAuditRuleRisksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditRuleRisksResponse>);
        }
        
        /// <summary>
        /// 查询风险规则策略
        ///
        /// 查询风险规则策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditRuleRisksNewResponse ListAuditRuleRisksNew(ListAuditRuleRisksNewRequest listAuditRuleRisksNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditRuleRisksNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/risk", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleRisksNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditRuleRisksNewResponse>(response);
        }

        public SyncInvoker<ListAuditRuleRisksNewResponse> ListAuditRuleRisksNewInvoker(ListAuditRuleRisksNewRequest listAuditRuleRisksNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditRuleRisksNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/risk", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleRisksNewRequest);
            return new SyncInvoker<ListAuditRuleRisksNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditRuleRisksNewResponse>);
        }
        
        /// <summary>
        /// 查询审计范围策略列表[待下线]
        ///
        /// 查询审计范围策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ListAuditRuleScopesResponse ListAuditRuleScopes(ListAuditRuleScopesRequest listAuditRuleScopesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditRuleScopesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/scopes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleScopesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditRuleScopesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ListAuditRuleScopesResponse> ListAuditRuleScopesInvoker(ListAuditRuleScopesRequest listAuditRuleScopesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditRuleScopesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/scopes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleScopesRequest);
            return new SyncInvoker<ListAuditRuleScopesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditRuleScopesResponse>);
        }
        
        /// <summary>
        /// 查询审计范围策略列表
        ///
        /// 查询审计范围策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditRuleScopesNewResponse ListAuditRuleScopesNew(ListAuditRuleScopesNewRequest listAuditRuleScopesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditRuleScopesNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/scopes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleScopesNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditRuleScopesNewResponse>(response);
        }

        public SyncInvoker<ListAuditRuleScopesNewResponse> ListAuditRuleScopesNewInvoker(ListAuditRuleScopesNewRequest listAuditRuleScopesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditRuleScopesNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/scopes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleScopesNewRequest);
            return new SyncInvoker<ListAuditRuleScopesNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditRuleScopesNewResponse>);
        }
        
        /// <summary>
        /// 查询隐私数据脱敏规则[待下线]
        ///
        /// 查询隐私数据脱敏规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ListAuditSensitiveMasksResponse ListAuditSensitiveMasks(ListAuditSensitiveMasksRequest listAuditSensitiveMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditSensitiveMasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/sensitive/masks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditSensitiveMasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditSensitiveMasksResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ListAuditSensitiveMasksResponse> ListAuditSensitiveMasksInvoker(ListAuditSensitiveMasksRequest listAuditSensitiveMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditSensitiveMasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/sensitive/masks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditSensitiveMasksRequest);
            return new SyncInvoker<ListAuditSensitiveMasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditSensitiveMasksResponse>);
        }
        
        /// <summary>
        /// 查询隐私数据脱敏规则
        ///
        /// 查询隐私数据脱敏规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditSensitiveMasksNewResponse ListAuditSensitiveMasksNew(ListAuditSensitiveMasksNewRequest listAuditSensitiveMasksNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditSensitiveMasksNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditSensitiveMasksNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditSensitiveMasksNewResponse>(response);
        }

        public SyncInvoker<ListAuditSensitiveMasksNewResponse> ListAuditSensitiveMasksNewInvoker(ListAuditSensitiveMasksNewRequest listAuditSensitiveMasksNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditSensitiveMasksNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditSensitiveMasksNewRequest);
            return new SyncInvoker<ListAuditSensitiveMasksNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditSensitiveMasksNewResponse>);
        }
        
        /// <summary>
        /// 查询审计SQL语句[待下线]
        ///
        /// 查询审计SQL语句
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ListAuditSqlsResponse ListAuditSqls(ListAuditSqlsRequest listAuditSqlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditSqlsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/sqls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditSqlsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAuditSqlsResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ListAuditSqlsResponse> ListAuditSqlsInvoker(ListAuditSqlsRequest listAuditSqlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditSqlsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/sqls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditSqlsRequest);
            return new SyncInvoker<ListAuditSqlsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditSqlsResponse>);
        }
        
        /// <summary>
        /// 查询审计SQL语句
        ///
        /// 查询审计SQL语句
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditSqlsNewResponse ListAuditSqlsNew(ListAuditSqlsNewRequest listAuditSqlsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditSqlsNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/sqls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditSqlsNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAuditSqlsNewResponse>(response);
        }

        public SyncInvoker<ListAuditSqlsNewResponse> ListAuditSqlsNewInvoker(ListAuditSqlsNewRequest listAuditSqlsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditSqlsNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/sqls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditSqlsNewRequest);
            return new SyncInvoker<ListAuditSqlsNewResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditSqlsNewResponse>);
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
        /// 查询趋势历史数据
        ///
        /// 查询趋势历史数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditTrendHistoryResponse ListAuditTrendHistory(ListAuditTrendHistoryRequest listAuditTrendHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditTrendHistoryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/statistics/trend/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditTrendHistoryRequest);
            var response = DoHttpRequestSync("GET", request);
            var listAuditTrendHistoryResponse = JsonUtils.DeSerializeNull<ListAuditTrendHistoryResponse>(response);
            listAuditTrendHistoryResponse.Body = JsonUtils.DeSerializeList<TrendStatusResponse>(response);
            return listAuditTrendHistoryResponse;
        }

        public SyncInvoker<ListAuditTrendHistoryResponse> ListAuditTrendHistoryInvoker(ListAuditTrendHistoryRequest listAuditTrendHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditTrendHistoryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/statistics/trend/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditTrendHistoryRequest);
            return new SyncInvoker<ListAuditTrendHistoryResponse>(this, "GET", request, response =>
            {
                var listAuditTrendHistoryResponse = JsonUtils.DeSerializeNull<ListAuditTrendHistoryResponse>(response);
                listAuditTrendHistoryResponse.Body = JsonUtils.DeSerializeList<TrendStatusResponse>(response);
                return listAuditTrendHistoryResponse;
            });
        }
        
        /// <summary>
        /// 查询可用区信息[待下线]
        ///
        /// 查询可用区信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ListAvailabilityZoneInfosResponse ListAvailabilityZoneInfos(ListAvailabilityZoneInfosRequest listAvailabilityZoneInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dbss/audit/availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZoneInfosRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAvailabilityZoneInfosResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ListAvailabilityZoneInfosResponse> ListAvailabilityZoneInfosInvoker(ListAvailabilityZoneInfosRequest listAvailabilityZoneInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dbss/audit/availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZoneInfosRequest);
            return new SyncInvoker<ListAvailabilityZoneInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailabilityZoneInfosResponse>);
        }
        
        /// <summary>
        /// 查询可用区信息
        ///
        /// 查询可用区信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAvailabilityZoneInfosNewResponse ListAvailabilityZoneInfosNew(ListAvailabilityZoneInfosNewRequest listAvailabilityZoneInfosNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZoneInfosNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAvailabilityZoneInfosNewResponse>(response);
        }

        public SyncInvoker<ListAvailabilityZoneInfosNewResponse> ListAvailabilityZoneInfosNewInvoker(ListAvailabilityZoneInfosNewRequest listAvailabilityZoneInfosNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZoneInfosNewRequest);
            return new SyncInvoker<ListAvailabilityZoneInfosNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailabilityZoneInfosNewResponse>);
        }
        
        /// <summary>
        /// 列举数据库加密实例
        ///
        /// 列举数据库加密实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDbEncryptInstancesResponse ListDbEncryptInstances(ListDbEncryptInstancesRequest listDbEncryptInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/db-encrypt/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbEncryptInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListDbEncryptInstancesResponse>(response);
        }

        public SyncInvoker<ListDbEncryptInstancesResponse> ListDbEncryptInstancesInvoker(ListDbEncryptInstancesRequest listDbEncryptInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/db-encrypt/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbEncryptInstancesRequest);
            return new SyncInvoker<ListDbEncryptInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListDbEncryptInstancesResponse>);
        }
        
        /// <summary>
        /// 查询ECS服务器规格信息[待下线]
        ///
        /// 查询ECS服务器规格信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ListEcsSpecificationResponse ListEcsSpecification(ListEcsSpecificationRequest listEcsSpecificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/specification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEcsSpecificationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEcsSpecificationResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ListEcsSpecificationResponse> ListEcsSpecificationInvoker(ListEcsSpecificationRequest listEcsSpecificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/specification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEcsSpecificationRequest);
            return new SyncInvoker<ListEcsSpecificationResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEcsSpecificationResponse>);
        }
        
        /// <summary>
        /// 查询ECS服务器规格信息
        ///
        /// 查询ECS服务器规格信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEcsSpecificationNewResponse ListEcsSpecificationNew(ListEcsSpecificationNewRequest listEcsSpecificationNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/specification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEcsSpecificationNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEcsSpecificationNewResponse>(response);
        }

        public SyncInvoker<ListEcsSpecificationNewResponse> ListEcsSpecificationNewInvoker(ListEcsSpecificationNewRequest listEcsSpecificationNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/specification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEcsSpecificationNewRequest);
            return new SyncInvoker<ListEcsSpecificationNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEcsSpecificationNewResponse>);
        }
        
        /// <summary>
        /// 获取数据库运维集群实例
        ///
        /// 获取数据库运维集群实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstancesResponse ListInstances(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/db-om/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListInstancesResponse>(response);
        }

        public SyncInvoker<ListInstancesResponse> ListInstancesInvoker(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/db-om/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            return new SyncInvoker<ListInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInstancesResponse>);
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
        /// 查询SQL注入规则策略[待下线]
        ///
        /// 查询SQL注入规则策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ListSqlInjectionRulesResponse ListSqlInjectionRules(ListSqlInjectionRulesRequest listSqlInjectionRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlInjectionRulesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/sql-injections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSqlInjectionRulesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListSqlInjectionRulesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ListSqlInjectionRulesResponse> ListSqlInjectionRulesInvoker(ListSqlInjectionRulesRequest listSqlInjectionRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlInjectionRulesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/sql-injections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSqlInjectionRulesRequest);
            return new SyncInvoker<ListSqlInjectionRulesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSqlInjectionRulesResponse>);
        }
        
        /// <summary>
        /// 重启审计实例[待下线]
        ///
        /// 重启审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public RebootAuditInstanceResponse RebootAuditInstance(RebootAuditInstanceRequest rebootAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", rebootAuditInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RebootAuditInstanceResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<RebootAuditInstanceResponse> RebootAuditInstanceInvoker(RebootAuditInstanceRequest rebootAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", rebootAuditInstanceRequest);
            return new SyncInvoker<RebootAuditInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RebootAuditInstanceResponse>);
        }
        
        /// <summary>
        /// 重启审计实例
        ///
        /// 重启审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RebootAuditInstanceNewResponse RebootAuditInstanceNew(RebootAuditInstanceNewRequest rebootAuditInstanceNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instance/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", rebootAuditInstanceNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RebootAuditInstanceNewResponse>(response);
        }

        public SyncInvoker<RebootAuditInstanceNewResponse> RebootAuditInstanceNewInvoker(RebootAuditInstanceNewRequest rebootAuditInstanceNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instance/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", rebootAuditInstanceNewRequest);
            return new SyncInvoker<RebootAuditInstanceNewResponse>(this, "POST", request, JsonUtils.DeSerialize<RebootAuditInstanceNewResponse>);
        }
        
        /// <summary>
        /// 重启数据库加密实例
        ///
        /// 重启数据库加密实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RebootDbEncryptInstanceResponse RebootDbEncryptInstance(RebootDbEncryptInstanceRequest rebootDbEncryptInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rebootDbEncryptInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebootDbEncryptInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RebootDbEncryptInstanceResponse>(response);
        }

        public SyncInvoker<RebootDbEncryptInstanceResponse> RebootDbEncryptInstanceInvoker(RebootDbEncryptInstanceRequest rebootDbEncryptInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rebootDbEncryptInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebootDbEncryptInstanceRequest);
            return new SyncInvoker<RebootDbEncryptInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RebootDbEncryptInstanceResponse>);
        }
        
        /// <summary>
        /// 重启数据库运维实例
        ///
        /// 重启数据库运维实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RebootDbOmInstanceResponse RebootDbOmInstance(RebootDbOmInstanceRequest rebootDbOmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rebootDbOmInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebootDbOmInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RebootDbOmInstanceResponse>(response);
        }

        public SyncInvoker<RebootDbOmInstanceResponse> RebootDbOmInstanceInvoker(RebootDbOmInstanceRequest rebootDbOmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rebootDbOmInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebootDbOmInstanceRequest);
            return new SyncInvoker<RebootDbOmInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RebootDbOmInstanceResponse>);
        }
        
        /// <summary>
        /// 重置数据库加密实例的密码
        ///
        /// 重置数据库加密实例的密码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetDbEncryptPasswordResponse ResetDbEncryptPassword(ResetDbEncryptPasswordRequest resetDbEncryptPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetDbEncryptPasswordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/password/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetDbEncryptPasswordRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResetDbEncryptPasswordResponse>(response);
        }

        public SyncInvoker<ResetDbEncryptPasswordResponse> ResetDbEncryptPasswordInvoker(ResetDbEncryptPasswordRequest resetDbEncryptPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetDbEncryptPasswordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/password/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetDbEncryptPasswordRequest);
            return new SyncInvoker<ResetDbEncryptPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetDbEncryptPasswordResponse>);
        }
        
        /// <summary>
        /// 重置数据库运维实例的密码
        ///
        /// 重置数据库运维实例的密码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetDbOmPasswordResponse ResetDbOmPassword(ResetDbOmPasswordRequest resetDbOmPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetDbOmPasswordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/password/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetDbOmPasswordRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResetDbOmPasswordResponse>(response);
        }

        public SyncInvoker<ResetDbOmPasswordResponse> ResetDbOmPasswordInvoker(ResetDbOmPasswordRequest resetDbOmPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetDbOmPasswordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/password/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetDbOmPasswordRequest);
            return new SyncInvoker<ResetDbOmPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetDbOmPasswordResponse>);
        }
        
        /// <summary>
        /// 恢复备份信息
        ///
        /// 恢复备份信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreAuditBackupResponse RestoreAuditBackup(RestoreAuditBackupRequest restoreAuditBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreAuditBackupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(restoreAuditBackupRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/{id}/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreAuditBackupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestoreAuditBackupResponse>(response);
        }

        public SyncInvoker<RestoreAuditBackupResponse> RestoreAuditBackupInvoker(RestoreAuditBackupRequest restoreAuditBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreAuditBackupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(restoreAuditBackupRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/{id}/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreAuditBackupRequest);
            return new SyncInvoker<RestoreAuditBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreAuditBackupResponse>);
        }
        
        /// <summary>
        /// 重试备份任务
        ///
        /// 重试备份任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RetryAuditBackupTaskResponse RetryAuditBackupTask(RetryAuditBackupTaskRequest retryAuditBackupTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryAuditBackupTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(retryAuditBackupTaskRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/{id}/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryAuditBackupTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RetryAuditBackupTaskResponse>(response);
        }

        public SyncInvoker<RetryAuditBackupTaskResponse> RetryAuditBackupTaskInvoker(RetryAuditBackupTaskRequest retryAuditBackupTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryAuditBackupTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(retryAuditBackupTaskRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/{id}/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryAuditBackupTaskRequest);
            return new SyncInvoker<RetryAuditBackupTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<RetryAuditBackupTaskResponse>);
        }
        
        /// <summary>
        /// 设置实例告警配置[待下线]
        ///
        /// 设置实例告警配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SetAlarmTopicConfigInfoResponse SetAlarmTopicConfigInfo(SetAlarmTopicConfigInfoRequest setAlarmTopicConfigInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAlarmTopicConfigInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/alarm/topic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAlarmTopicConfigInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetAlarmTopicConfigInfoResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<SetAlarmTopicConfigInfoResponse> SetAlarmTopicConfigInfoInvoker(SetAlarmTopicConfigInfoRequest setAlarmTopicConfigInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAlarmTopicConfigInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/alarm/topic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAlarmTopicConfigInfoRequest);
            return new SyncInvoker<SetAlarmTopicConfigInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<SetAlarmTopicConfigInfoResponse>);
        }
        
        /// <summary>
        /// 设置实例告警配置
        ///
        /// 设置实例告警配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetAlarmTopicConfigInfoNewResponse SetAlarmTopicConfigInfoNew(SetAlarmTopicConfigInfoNewRequest setAlarmTopicConfigInfoNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAlarmTopicConfigInfoNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/alarm/topic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAlarmTopicConfigInfoNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetAlarmTopicConfigInfoNewResponse>(response);
        }

        public SyncInvoker<SetAlarmTopicConfigInfoNewResponse> SetAlarmTopicConfigInfoNewInvoker(SetAlarmTopicConfigInfoNewRequest setAlarmTopicConfigInfoNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAlarmTopicConfigInfoNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/alarm/topic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAlarmTopicConfigInfoNewRequest);
            return new SyncInvoker<SetAlarmTopicConfigInfoNewResponse>(this, "POST", request, JsonUtils.DeSerialize<SetAlarmTopicConfigInfoNewResponse>);
        }
        
        /// <summary>
        /// 标记监控告警
        ///
        /// 标记监控告警
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetAuditAlarmLogStatusResponse SetAuditAlarmLogStatus(SetAuditAlarmLogStatusRequest setAuditAlarmLogStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditAlarmLogStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(setAuditAlarmLogStatusRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/alarm-log/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditAlarmLogStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SetAuditAlarmLogStatusResponse>(response);
        }

        public SyncInvoker<SetAuditAlarmLogStatusResponse> SetAuditAlarmLogStatusInvoker(SetAuditAlarmLogStatusRequest setAuditAlarmLogStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditAlarmLogStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(setAuditAlarmLogStatusRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/alarm-log/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditAlarmLogStatusRequest);
            return new SyncInvoker<SetAuditAlarmLogStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetAuditAlarmLogStatusResponse>);
        }
        
        /// <summary>
        /// 获取备份配置信息
        ///
        /// 设置备份配置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetAuditAutoBackupTemplateResponse SetAuditAutoBackupTemplate(SetAuditAutoBackupTemplateRequest setAuditAutoBackupTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditAutoBackupTemplateRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditAutoBackupTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SetAuditAutoBackupTemplateResponse>(response);
        }

        public SyncInvoker<SetAuditAutoBackupTemplateResponse> SetAuditAutoBackupTemplateInvoker(SetAuditAutoBackupTemplateRequest setAuditAutoBackupTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditAutoBackupTemplateRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditAutoBackupTemplateRequest);
            return new SyncInvoker<SetAuditAutoBackupTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<SetAuditAutoBackupTemplateResponse>);
        }
        
        /// <summary>
        /// 风险导出开关(按DomainId)
        ///
        /// 风险导出开关(按DomainId)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetAuditBackupRiskSwitchResponse SetAuditBackupRiskSwitch(SetAuditBackupRiskSwitchRequest setAuditBackupRiskSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditBackupRiskSwitchRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(setAuditBackupRiskSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/audit/{instance_id}/backup/risk/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditBackupRiskSwitchRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetAuditBackupRiskSwitchResponse>(response);
        }

        public SyncInvoker<SetAuditBackupRiskSwitchResponse> SetAuditBackupRiskSwitchInvoker(SetAuditBackupRiskSwitchRequest setAuditBackupRiskSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditBackupRiskSwitchRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(setAuditBackupRiskSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/audit/{instance_id}/backup/risk/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditBackupRiskSwitchRequest);
            return new SyncInvoker<SetAuditBackupRiskSwitchResponse>(this, "POST", request, JsonUtils.DeSerialize<SetAuditBackupRiskSwitchResponse>);
        }
        
        /// <summary>
        /// 开启/关闭备份
        ///
        /// 开启/关闭备份
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetAuditBackupSwitchResponse SetAuditBackupSwitch(SetAuditBackupSwitchRequest setAuditBackupSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditBackupSwitchRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(setAuditBackupSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/audit/{instance_id}/backup/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditBackupSwitchRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetAuditBackupSwitchResponse>(response);
        }

        public SyncInvoker<SetAuditBackupSwitchResponse> SetAuditBackupSwitchInvoker(SetAuditBackupSwitchRequest setAuditBackupSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditBackupSwitchRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(setAuditBackupSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/audit/{instance_id}/backup/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditBackupSwitchRequest);
            return new SyncInvoker<SetAuditBackupSwitchResponse>(this, "POST", request, JsonUtils.DeSerialize<SetAuditBackupSwitchResponse>);
        }
        
        /// <summary>
        /// 配置审计实例时区信息
        ///
        /// 配置审计实例时区信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetAuditInstanceTimeZoneResponse SetAuditInstanceTimeZone(SetAuditInstanceTimeZoneRequest setAuditInstanceTimeZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditInstanceTimeZoneRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/timezone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditInstanceTimeZoneRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetAuditInstanceTimeZoneResponse>(response);
        }

        public SyncInvoker<SetAuditInstanceTimeZoneResponse> SetAuditInstanceTimeZoneInvoker(SetAuditInstanceTimeZoneRequest setAuditInstanceTimeZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditInstanceTimeZoneRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/timezone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditInstanceTimeZoneRequest);
            return new SyncInvoker<SetAuditInstanceTimeZoneResponse>(this, "POST", request, JsonUtils.DeSerialize<SetAuditInstanceTimeZoneResponse>);
        }
        
        /// <summary>
        /// 启用禁用策略
        ///
        /// 启用禁用策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetAuditScopeRuleSwitchResponse SetAuditScopeRuleSwitch(SetAuditScopeRuleSwitchRequest setAuditScopeRuleSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditScopeRuleSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/scopes/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditScopeRuleSwitchRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetAuditScopeRuleSwitchResponse>(response);
        }

        public SyncInvoker<SetAuditScopeRuleSwitchResponse> SetAuditScopeRuleSwitchInvoker(SetAuditScopeRuleSwitchRequest setAuditScopeRuleSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditScopeRuleSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/scopes/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditScopeRuleSwitchRequest);
            return new SyncInvoker<SetAuditScopeRuleSwitchResponse>(this, "POST", request, JsonUtils.DeSerialize<SetAuditScopeRuleSwitchResponse>);
        }
        
        /// <summary>
        /// 编辑风险操作策略
        ///
        /// 编辑风险操作策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetRiskOperationPolicyResponse SetRiskOperationPolicy(SetRiskOperationPolicyRequest setRiskOperationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setRiskOperationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(setRiskOperationPolicyRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/risk/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRiskOperationPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SetRiskOperationPolicyResponse>(response);
        }

        public SyncInvoker<SetRiskOperationPolicyResponse> SetRiskOperationPolicyInvoker(SetRiskOperationPolicyRequest setRiskOperationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setRiskOperationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(setRiskOperationPolicyRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/risk/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRiskOperationPolicyRequest);
            return new SyncInvoker<SetRiskOperationPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetRiskOperationPolicyResponse>);
        }
        
        /// <summary>
        /// 审计实例风险规则排序
        ///
        /// 审计实例风险规则排序
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetRiskRuleRankResponse SetRiskRuleRank(SetRiskRuleRankRequest setRiskRuleRankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setRiskRuleRankRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/risk/rank", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRiskRuleRankRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetRiskRuleRankResponse>(response);
        }

        public SyncInvoker<SetRiskRuleRankResponse> SetRiskRuleRankInvoker(SetRiskRuleRankRequest setRiskRuleRankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setRiskRuleRankRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/risk/rank", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRiskRuleRankRequest);
            return new SyncInvoker<SetRiskRuleRankResponse>(this, "POST", request, JsonUtils.DeSerialize<SetRiskRuleRankResponse>);
        }
        
        /// <summary>
        /// 启用禁用单条隐私数据脱敏规则
        ///
        /// 启用禁用隐私数据脱敏规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetSensitiveMaskRuleSwitchResponse SetSensitiveMaskRuleSwitch(SetSensitiveMaskRuleSwitchRequest setSensitiveMaskRuleSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSensitiveMaskRuleSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/sensitive/mask/rule/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSensitiveMaskRuleSwitchRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetSensitiveMaskRuleSwitchResponse>(response);
        }

        public SyncInvoker<SetSensitiveMaskRuleSwitchResponse> SetSensitiveMaskRuleSwitchInvoker(SetSensitiveMaskRuleSwitchRequest setSensitiveMaskRuleSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSensitiveMaskRuleSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/sensitive/mask/rule/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSensitiveMaskRuleSwitchRequest);
            return new SyncInvoker<SetSensitiveMaskRuleSwitchResponse>(this, "POST", request, JsonUtils.DeSerialize<SetSensitiveMaskRuleSwitchResponse>);
        }
        
        /// <summary>
        /// 开启关闭结果集存储
        ///
        /// 开启关闭结果集存储
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetSensitiveResultSwitchResponse SetSensitiveResultSwitch(SetSensitiveResultSwitchRequest setSensitiveResultSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSensitiveResultSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/result/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSensitiveResultSwitchRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetSensitiveResultSwitchResponse>(response);
        }

        public SyncInvoker<SetSensitiveResultSwitchResponse> SetSensitiveResultSwitchInvoker(SetSensitiveResultSwitchRequest setSensitiveResultSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSensitiveResultSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/result/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSensitiveResultSwitchRequest);
            return new SyncInvoker<SetSensitiveResultSwitchResponse>(this, "POST", request, JsonUtils.DeSerialize<SetSensitiveResultSwitchResponse>);
        }
        
        /// <summary>
        /// 开启关闭隐私数据脱敏功能
        ///
        /// 开启关闭隐私数据脱敏
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetSensitiveSwitchResponse SetSensitiveSwitch(SetSensitiveSwitchRequest setSensitiveSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSensitiveSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSensitiveSwitchRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetSensitiveSwitchResponse>(response);
        }

        public SyncInvoker<SetSensitiveSwitchResponse> SetSensitiveSwitchInvoker(SetSensitiveSwitchRequest setSensitiveSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSensitiveSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSensitiveSwitchRequest);
            return new SyncInvoker<SetSensitiveSwitchResponse>(this, "POST", request, JsonUtils.DeSerialize<SetSensitiveSwitchResponse>);
        }
        
        /// <summary>
        /// 获取单个风险导出配置
        ///
        /// 获取单个风险导出配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAuditBackRiskTemplateResponse ShowAuditBackRiskTemplate(ShowAuditBackRiskTemplateRequest showAuditBackRiskTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditBackRiskTemplateRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditBackRiskTemplateRequest.DbId, out var valueOfDbId)) urlParam.Add("db_id", valueOfDbId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/risk/template/{db_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditBackRiskTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditBackRiskTemplateResponse>(response);
        }

        public SyncInvoker<ShowAuditBackRiskTemplateResponse> ShowAuditBackRiskTemplateInvoker(ShowAuditBackRiskTemplateRequest showAuditBackRiskTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditBackRiskTemplateRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditBackRiskTemplateRequest.DbId, out var valueOfDbId)) urlParam.Add("db_id", valueOfDbId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/risk/template/{db_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditBackRiskTemplateRequest);
            return new SyncInvoker<ShowAuditBackRiskTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditBackRiskTemplateResponse>);
        }
        
        /// <summary>
        /// 获取备份状态
        ///
        /// 获取备份状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAuditBackupStatusResponse ShowAuditBackupStatus(ShowAuditBackupStatusRequest showAuditBackupStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditBackupStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditBackupStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditBackupStatusResponse>(response);
        }

        public SyncInvoker<ShowAuditBackupStatusResponse> ShowAuditBackupStatusInvoker(ShowAuditBackupStatusRequest showAuditBackupStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditBackupStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditBackupStatusRequest);
            return new SyncInvoker<ShowAuditBackupStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditBackupStatusResponse>);
        }
        
        /// <summary>
        /// 查询账户配额信息[待下线]
        ///
        /// 查询账户配额信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ShowAuditQuotaResponse ShowAuditQuota(ShowAuditQuotaRequest showAuditQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditQuotaResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ShowAuditQuotaResponse> ShowAuditQuotaInvoker(ShowAuditQuotaRequest showAuditQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditQuotaRequest);
            return new SyncInvoker<ShowAuditQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditQuotaResponse>);
        }
        
        /// <summary>
        /// 查询账户配额信息
        ///
        /// 查询账户配额信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAuditQuotaNewResponse ShowAuditQuotaNew(ShowAuditQuotaNewRequest showAuditQuotaNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditQuotaNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditQuotaNewResponse>(response);
        }

        public SyncInvoker<ShowAuditQuotaNewResponse> ShowAuditQuotaNewInvoker(ShowAuditQuotaNewRequest showAuditQuotaNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditQuotaNewRequest);
            return new SyncInvoker<ShowAuditQuotaNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditQuotaNewResponse>);
        }
        
        /// <summary>
        /// 查询指定风险规则策略[待下线]
        ///
        /// 查询指定风险规则策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ShowAuditRuleRiskResponse ShowAuditRuleRisk(ShowAuditRuleRiskRequest showAuditRuleRiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditRuleRiskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditRuleRiskRequest.RiskId, out var valueOfRiskId)) urlParam.Add("risk_id", valueOfRiskId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/risk/{risk_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditRuleRiskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditRuleRiskResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ShowAuditRuleRiskResponse> ShowAuditRuleRiskInvoker(ShowAuditRuleRiskRequest showAuditRuleRiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditRuleRiskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditRuleRiskRequest.RiskId, out var valueOfRiskId)) urlParam.Add("risk_id", valueOfRiskId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/risk/{risk_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditRuleRiskRequest);
            return new SyncInvoker<ShowAuditRuleRiskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditRuleRiskResponse>);
        }
        
        /// <summary>
        /// 查询指定风险规则策略
        ///
        /// 查询指定风险规则策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAuditRuleRiskNewResponse ShowAuditRuleRiskNew(ShowAuditRuleRiskNewRequest showAuditRuleRiskNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditRuleRiskNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditRuleRiskNewRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/risk/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditRuleRiskNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditRuleRiskNewResponse>(response);
        }

        public SyncInvoker<ShowAuditRuleRiskNewResponse> ShowAuditRuleRiskNewInvoker(ShowAuditRuleRiskNewRequest showAuditRuleRiskNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditRuleRiskNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditRuleRiskNewRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/risk/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditRuleRiskNewRequest);
            return new SyncInvoker<ShowAuditRuleRiskNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditRuleRiskNewResponse>);
        }
        
        /// <summary>
        /// 获取租户下所有实例的风险汇总信息
        ///
        /// 获取租户下所有实例的风险汇总信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAuditStatisticsResponse ShowAuditStatistics(ShowAuditStatisticsRequest showAuditStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/summary/risk/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditStatisticsResponse>(response);
        }

        public SyncInvoker<ShowAuditStatisticsResponse> ShowAuditStatisticsInvoker(ShowAuditStatisticsRequest showAuditStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/summary/risk/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditStatisticsRequest);
            return new SyncInvoker<ShowAuditStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取租户审计信息汇总任务状态
        ///
        /// 获取租户审计信息汇总任务状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAuditTaskStatusResponse ShowAuditTaskStatus(ShowAuditTaskStatusRequest showAuditTaskStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditTaskStatusRequest.BusiType, out var valueOfBusiType)) urlParam.Add("busi_type", valueOfBusiType);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/summary/{busi_type}/task-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditTaskStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditTaskStatusResponse>(response);
        }

        public SyncInvoker<ShowAuditTaskStatusResponse> ShowAuditTaskStatusInvoker(ShowAuditTaskStatusRequest showAuditTaskStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditTaskStatusRequest.BusiType, out var valueOfBusiType)) urlParam.Add("busi_type", valueOfBusiType);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/summary/{busi_type}/task-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditTaskStatusRequest);
            return new SyncInvoker<ShowAuditTaskStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditTaskStatusResponse>);
        }
        
        /// <summary>
        /// 获取报表的计划任务配置信息（topic方式）
        ///
        /// 获取报表的计划任务配置信息（topic方式）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAuditTopicReportSchedulerConfigResponse ShowAuditTopicReportSchedulerConfig(ShowAuditTopicReportSchedulerConfigRequest showAuditTopicReportSchedulerConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditTopicReportSchedulerConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditTopicReportSchedulerConfigRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/reports/tasks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditTopicReportSchedulerConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditTopicReportSchedulerConfigResponse>(response);
        }

        public SyncInvoker<ShowAuditTopicReportSchedulerConfigResponse> ShowAuditTopicReportSchedulerConfigInvoker(ShowAuditTopicReportSchedulerConfigRequest showAuditTopicReportSchedulerConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditTopicReportSchedulerConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditTopicReportSchedulerConfigRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/reports/tasks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditTopicReportSchedulerConfigRequest);
            return new SyncInvoker<ShowAuditTopicReportSchedulerConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditTopicReportSchedulerConfigResponse>);
        }
        
        /// <summary>
        /// 查询租户的实例是否可升级
        ///
        /// 查询租户的实例是否可升级
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAuditUpgradeStatusResponse ShowAuditUpgradeStatus(ShowAuditUpgradeStatusRequest showAuditUpgradeStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/upgrade/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditUpgradeStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditUpgradeStatusResponse>(response);
        }

        public SyncInvoker<ShowAuditUpgradeStatusResponse> ShowAuditUpgradeStatusInvoker(ShowAuditUpgradeStatusRequest showAuditUpgradeStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/upgrade/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditUpgradeStatusRequest);
            return new SyncInvoker<ShowAuditUpgradeStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditUpgradeStatusResponse>);
        }
        
        /// <summary>
        /// 获取风险导出桶名和路径
        ///
        /// 获取风险导出桶名和路径
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBackupRiskBucketPathResponse ShowBackupRiskBucketPath(ShowBackupRiskBucketPathRequest showBackupRiskBucketPathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBackupRiskBucketPathRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/risk/bucket-path", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupRiskBucketPathRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBackupRiskBucketPathResponse>(response);
        }

        public SyncInvoker<ShowBackupRiskBucketPathResponse> ShowBackupRiskBucketPathInvoker(ShowBackupRiskBucketPathRequest showBackupRiskBucketPathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBackupRiskBucketPathRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/risk/bucket-path", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupRiskBucketPathRequest);
            return new SyncInvoker<ShowBackupRiskBucketPathResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackupRiskBucketPathResponse>);
        }
        
        /// <summary>
        /// 获取实例监控数据
        ///
        /// 获取实例监控数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceMonitorInfoResponse ShowInstanceMonitorInfo(ShowInstanceMonitorInfoRequest showInstanceMonitorInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceMonitorInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/system/monitorinfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceMonitorInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowInstanceMonitorInfoResponse>(response);
        }

        public SyncInvoker<ShowInstanceMonitorInfoResponse> ShowInstanceMonitorInfoInvoker(ShowInstanceMonitorInfoRequest showInstanceMonitorInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceMonitorInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/system/monitorinfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceMonitorInfoRequest);
            return new SyncInvoker<ShowInstanceMonitorInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowInstanceMonitorInfoResponse>);
        }
        
        /// <summary>
        /// 查询加密/运维增强配额
        ///
        /// 查询加密/运维增强配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceQuotaResponse ShowInstanceQuota(ShowInstanceQuotaRequest showInstanceQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instance/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceQuotaResponse>(response);
        }

        public SyncInvoker<ShowInstanceQuotaResponse> ShowInstanceQuotaInvoker(ShowInstanceQuotaRequest showInstanceQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instance/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceQuotaRequest);
            return new SyncInvoker<ShowInstanceQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceQuotaResponse>);
        }
        
        /// <summary>
        /// 获取隐私数据脱敏开关
        ///
        /// 获取隐私数据脱敏开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSensitiveMaskSwitchResponse ShowSensitiveMaskSwitch(ShowSensitiveMaskSwitchRequest showSensitiveMaskSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSensitiveMaskSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSensitiveMaskSwitchRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSensitiveMaskSwitchResponse>(response);
        }

        public SyncInvoker<ShowSensitiveMaskSwitchResponse> ShowSensitiveMaskSwitchInvoker(ShowSensitiveMaskSwitchRequest showSensitiveMaskSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSensitiveMaskSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSensitiveMaskSwitchRequest);
            return new SyncInvoker<ShowSensitiveMaskSwitchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSensitiveMaskSwitchResponse>);
        }
        
        /// <summary>
        /// 获取隐私数据结果集开关
        ///
        /// 获取隐私数据结果集开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSensitiveResultSwitchResponse ShowSensitiveResultSwitch(ShowSensitiveResultSwitchRequest showSensitiveResultSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSensitiveResultSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/result/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSensitiveResultSwitchRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSensitiveResultSwitchResponse>(response);
        }

        public SyncInvoker<ShowSensitiveResultSwitchResponse> ShowSensitiveResultSwitchInvoker(ShowSensitiveResultSwitchRequest showSensitiveResultSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSensitiveResultSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/result/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSensitiveResultSwitchRequest);
            return new SyncInvoker<ShowSensitiveResultSwitchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSensitiveResultSwitchResponse>);
        }
        
        /// <summary>
        /// 获取管理侧版本信息
        ///
        /// 获取管理侧版本信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowServerVersionResponse ShowServerVersion(ShowServerVersionRequest showServerVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowServerVersionResponse>(response);
        }

        public SyncInvoker<ShowServerVersionResponse> ShowServerVersionInvoker(ShowServerVersionRequest showServerVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerVersionRequest);
            return new SyncInvoker<ShowServerVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerVersionResponse>);
        }
        
        /// <summary>
        /// 获取指定SQL语句的详细信息
        ///
        /// 获取指定SQL语句的详细信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSqlDetailResponse ShowSqlDetail(ShowSqlDetailRequest showSqlDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSqlDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showSqlDetailRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/sqls/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSqlDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSqlDetailResponse>(response);
        }

        public SyncInvoker<ShowSqlDetailResponse> ShowSqlDetailInvoker(ShowSqlDetailRequest showSqlDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSqlDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showSqlDetailRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/sqls/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSqlDetailRequest);
            return new SyncInvoker<ShowSqlDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSqlDetailResponse>);
        }
        
        /// <summary>
        /// 开启审计实例[待下线]
        ///
        /// 开启审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public StartAuditInstanceResponse StartAuditInstance(StartAuditInstanceRequest startAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startAuditInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartAuditInstanceResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<StartAuditInstanceResponse> StartAuditInstanceInvoker(StartAuditInstanceRequest startAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startAuditInstanceRequest);
            return new SyncInvoker<StartAuditInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StartAuditInstanceResponse>);
        }
        
        /// <summary>
        /// 开启审计实例
        ///
        /// 开启审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartAuditInstanceNewResponse StartAuditInstanceNew(StartAuditInstanceNewRequest startAuditInstanceNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instance/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startAuditInstanceNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartAuditInstanceNewResponse>(response);
        }

        public SyncInvoker<StartAuditInstanceNewResponse> StartAuditInstanceNewInvoker(StartAuditInstanceNewRequest startAuditInstanceNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instance/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startAuditInstanceNewRequest);
            return new SyncInvoker<StartAuditInstanceNewResponse>(this, "POST", request, JsonUtils.DeSerialize<StartAuditInstanceNewResponse>);
        }
        
        /// <summary>
        /// 启动数据库加密实例
        ///
        /// 启动数据库加密实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartDbEncryptInstanceResponse StartDbEncryptInstance(StartDbEncryptInstanceRequest startDbEncryptInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startDbEncryptInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDbEncryptInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartDbEncryptInstanceResponse>(response);
        }

        public SyncInvoker<StartDbEncryptInstanceResponse> StartDbEncryptInstanceInvoker(StartDbEncryptInstanceRequest startDbEncryptInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startDbEncryptInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDbEncryptInstanceRequest);
            return new SyncInvoker<StartDbEncryptInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StartDbEncryptInstanceResponse>);
        }
        
        /// <summary>
        /// 启动数据库运维实例
        ///
        /// 启动数据库运维实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartDbOmInstanceResponse StartDbOmInstance(StartDbOmInstanceRequest startDbOmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startDbOmInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDbOmInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartDbOmInstanceResponse>(response);
        }

        public SyncInvoker<StartDbOmInstanceResponse> StartDbOmInstanceInvoker(StartDbOmInstanceRequest startDbOmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startDbOmInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDbOmInstanceRequest);
            return new SyncInvoker<StartDbOmInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StartDbOmInstanceResponse>);
        }
        
        /// <summary>
        /// 关闭审计实例[待下线]
        ///
        /// 关闭审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public StopAuditInstanceResponse StopAuditInstance(StopAuditInstanceRequest stopAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopAuditInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopAuditInstanceResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<StopAuditInstanceResponse> StopAuditInstanceInvoker(StopAuditInstanceRequest stopAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopAuditInstanceRequest);
            return new SyncInvoker<StopAuditInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StopAuditInstanceResponse>);
        }
        
        /// <summary>
        /// 关闭审计实例
        ///
        /// 关闭审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopAuditInstanceNewResponse StopAuditInstanceNew(StopAuditInstanceNewRequest stopAuditInstanceNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instance/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopAuditInstanceNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopAuditInstanceNewResponse>(response);
        }

        public SyncInvoker<StopAuditInstanceNewResponse> StopAuditInstanceNewInvoker(StopAuditInstanceNewRequest stopAuditInstanceNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instance/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopAuditInstanceNewRequest);
            return new SyncInvoker<StopAuditInstanceNewResponse>(this, "POST", request, JsonUtils.DeSerialize<StopAuditInstanceNewResponse>);
        }
        
        /// <summary>
        /// 停止数据库加密实例
        ///
        /// 停止数据库加密实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopDbEncryptInstanceResponse StopDbEncryptInstance(StopDbEncryptInstanceRequest stopDbEncryptInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopDbEncryptInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopDbEncryptInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopDbEncryptInstanceResponse>(response);
        }

        public SyncInvoker<StopDbEncryptInstanceResponse> StopDbEncryptInstanceInvoker(StopDbEncryptInstanceRequest stopDbEncryptInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopDbEncryptInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopDbEncryptInstanceRequest);
            return new SyncInvoker<StopDbEncryptInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StopDbEncryptInstanceResponse>);
        }
        
        /// <summary>
        /// 停止数据库运维实例
        ///
        /// 停止数据库运维实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopDbOmInstanceResponse StopDbOmInstance(StopDbOmInstanceRequest stopDbOmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopDbOmInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopDbOmInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopDbOmInstanceResponse>(response);
        }

        public SyncInvoker<StopDbOmInstanceResponse> StopDbOmInstanceInvoker(StopDbOmInstanceRequest stopDbOmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopDbOmInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopDbOmInstanceRequest);
            return new SyncInvoker<StopDbOmInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StopDbOmInstanceResponse>);
        }
        
        /// <summary>
        /// 开启关闭Agent[待下线]
        ///
        /// 用于开启和关闭Agent审计的功能，当开启后，开始抓取用户的访问信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SwitchAgentResponse SwitchAgent(SwitchAgentRequest switchAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/agent/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAgentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchAgentResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<SwitchAgentResponse> SwitchAgentInvoker(SwitchAgentRequest switchAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/agent/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAgentRequest);
            return new SyncInvoker<SwitchAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchAgentResponse>);
        }
        
        /// <summary>
        /// 开启关闭数据库[待下线]
        ///
        /// 开启关闭数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SwitchAuditDatabaseResponse SwitchAuditDatabase(SwitchAuditDatabaseRequest switchAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchAuditDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAuditDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchAuditDatabaseResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<SwitchAuditDatabaseResponse> SwitchAuditDatabaseInvoker(SwitchAuditDatabaseRequest switchAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchAuditDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAuditDatabaseRequest);
            return new SyncInvoker<SwitchAuditDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchAuditDatabaseResponse>);
        }
        
        /// <summary>
        /// 开启关闭数据库
        ///
        /// 开启关闭数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchAuditDatabaseNewResponse SwitchAuditDatabaseNew(SwitchAuditDatabaseNewRequest switchAuditDatabaseNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchAuditDatabaseNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/databases/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAuditDatabaseNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchAuditDatabaseNewResponse>(response);
        }

        public SyncInvoker<SwitchAuditDatabaseNewResponse> SwitchAuditDatabaseNewInvoker(SwitchAuditDatabaseNewRequest switchAuditDatabaseNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchAuditDatabaseNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/databases/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAuditDatabaseNewRequest);
            return new SyncInvoker<SwitchAuditDatabaseNewResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchAuditDatabaseNewResponse>);
        }
        
        /// <summary>
        /// 开启关闭风险规则[待下线]
        ///
        /// 开启关闭风险规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SwitchRiskRuleResponse SwitchRiskRule(SwitchRiskRuleRequest switchRiskRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchRiskRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/rule/risk/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchRiskRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchRiskRuleResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<SwitchRiskRuleResponse> SwitchRiskRuleInvoker(SwitchRiskRuleRequest switchRiskRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchRiskRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/rule/risk/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchRiskRuleRequest);
            return new SyncInvoker<SwitchRiskRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchRiskRuleResponse>);
        }
        
        /// <summary>
        /// 开启/关闭风险规则
        ///
        /// 开启/关闭风险规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchRiskRuleNewResponse SwitchRiskRuleNew(SwitchRiskRuleNewRequest switchRiskRuleNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchRiskRuleNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/risk/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchRiskRuleNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchRiskRuleNewResponse>(response);
        }

        public SyncInvoker<SwitchRiskRuleNewResponse> SwitchRiskRuleNewInvoker(SwitchRiskRuleNewRequest switchRiskRuleNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchRiskRuleNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/risk/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchRiskRuleNewRequest);
            return new SyncInvoker<SwitchRiskRuleNewResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchRiskRuleNewResponse>);
        }
        
        /// <summary>
        /// 解绑数据库加密实例的EIP
        ///
        /// 解绑数据库加密实例的EIP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UnbindDbEncryptEipResponse UnbindDbEncryptEip(UnbindDbEncryptEipRequest unbindDbEncryptEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unbindDbEncryptEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/eip/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unbindDbEncryptEipRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UnbindDbEncryptEipResponse>(response);
        }

        public SyncInvoker<UnbindDbEncryptEipResponse> UnbindDbEncryptEipInvoker(UnbindDbEncryptEipRequest unbindDbEncryptEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unbindDbEncryptEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/eip/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unbindDbEncryptEipRequest);
            return new SyncInvoker<UnbindDbEncryptEipResponse>(this, "POST", request, JsonUtils.DeSerialize<UnbindDbEncryptEipResponse>);
        }
        
        /// <summary>
        /// 解绑数据库运维实例的EIP
        ///
        /// 解绑数据库运维实例的EIP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UnbindDbOmEipResponse UnbindDbOmEip(UnbindDbOmEipRequest unbindDbOmEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unbindDbOmEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/eip/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unbindDbOmEipRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UnbindDbOmEipResponse>(response);
        }

        public SyncInvoker<UnbindDbOmEipResponse> UnbindDbOmEipInvoker(UnbindDbOmEipRequest unbindDbOmEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unbindDbOmEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/eip/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unbindDbOmEipRequest);
            return new SyncInvoker<UnbindDbOmEipResponse>(this, "POST", request, JsonUtils.DeSerialize<UnbindDbOmEipResponse>);
        }
        
        /// <summary>
        /// 更新审计实例信息[待下线]
        ///
        /// 更新审计实例信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public UpdateAuditInstanceResponse UpdateAuditInstance(UpdateAuditInstanceRequest updateAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditInstanceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAuditInstanceResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<UpdateAuditInstanceResponse> UpdateAuditInstanceInvoker(UpdateAuditInstanceRequest updateAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditInstanceRequest);
            return new SyncInvoker<UpdateAuditInstanceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAuditInstanceResponse>);
        }
        
        /// <summary>
        /// 更新审计实例信息
        ///
        /// 更新审计实例信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAuditInstanceNewResponse UpdateAuditInstanceNew(UpdateAuditInstanceNewRequest updateAuditInstanceNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditInstanceNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instance/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditInstanceNewRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAuditInstanceNewResponse>(response);
        }

        public SyncInvoker<UpdateAuditInstanceNewResponse> UpdateAuditInstanceNewInvoker(UpdateAuditInstanceNewRequest updateAuditInstanceNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditInstanceNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instance/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditInstanceNewRequest);
            return new SyncInvoker<UpdateAuditInstanceNewResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAuditInstanceNewResponse>);
        }
        
        /// <summary>
        /// 修改风险导出桶名和路径(按DomainId)
        ///
        /// 修改风险导出桶名和路径(按DomainId)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAuditRiskBucketPathResponse UpdateAuditRiskBucketPath(UpdateAuditRiskBucketPathRequest updateAuditRiskBucketPathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditRiskBucketPathRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(updateAuditRiskBucketPathRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/audit/{instance_id}/backup/risk/global/bucket-path", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditRiskBucketPathRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateAuditRiskBucketPathResponse>(response);
        }

        public SyncInvoker<UpdateAuditRiskBucketPathResponse> UpdateAuditRiskBucketPathInvoker(UpdateAuditRiskBucketPathRequest updateAuditRiskBucketPathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditRiskBucketPathRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(updateAuditRiskBucketPathRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/audit/{instance_id}/backup/risk/global/bucket-path", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditRiskBucketPathRequest);
            return new SyncInvoker<UpdateAuditRiskBucketPathResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAuditRiskBucketPathResponse>);
        }
        
        /// <summary>
        /// 编辑审计范围规则
        ///
        /// 编辑审计范围规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAuditScopeRuleResponse UpdateAuditScopeRule(UpdateAuditScopeRuleRequest updateAuditScopeRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditScopeRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateAuditScopeRuleRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/rule/scopes/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditScopeRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateAuditScopeRuleResponse>(response);
        }

        public SyncInvoker<UpdateAuditScopeRuleResponse> UpdateAuditScopeRuleInvoker(UpdateAuditScopeRuleRequest updateAuditScopeRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditScopeRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateAuditScopeRuleRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/rule/scopes/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditScopeRuleRequest);
            return new SyncInvoker<UpdateAuditScopeRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAuditScopeRuleResponse>);
        }
        
        /// <summary>
        /// 修改实例安全组[待下线]
        ///
        /// 修改实例安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public UpdateAuditSecurityGroupResponse UpdateAuditSecurityGroup(UpdateAuditSecurityGroupRequest updateAuditSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditSecurityGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateAuditSecurityGroupResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<UpdateAuditSecurityGroupResponse> UpdateAuditSecurityGroupInvoker(UpdateAuditSecurityGroupRequest updateAuditSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditSecurityGroupRequest);
            return new SyncInvoker<UpdateAuditSecurityGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAuditSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 修改实例安全组
        ///
        /// 修改实例安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAuditSecurityGroupNewResponse UpdateAuditSecurityGroupNew(UpdateAuditSecurityGroupNewRequest updateAuditSecurityGroupNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditSecurityGroupNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateAuditSecurityGroupNewResponse>(response);
        }

        public SyncInvoker<UpdateAuditSecurityGroupNewResponse> UpdateAuditSecurityGroupNewInvoker(UpdateAuditSecurityGroupNewRequest updateAuditSecurityGroupNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditSecurityGroupNewRequest);
            return new SyncInvoker<UpdateAuditSecurityGroupNewResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAuditSecurityGroupNewResponse>);
        }
        
        /// <summary>
        /// 更新租户审计信息汇总任务状态
        ///
        /// 更新租户审计信息汇总任务状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAuditTaskStatusResponse UpdateAuditTaskStatus(UpdateAuditTaskStatusRequest updateAuditTaskStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditTaskStatusRequest.BusiType, out var valueOfBusiType)) urlParam.Add("busi_type", valueOfBusiType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/summary/{busi_type}/task-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditTaskStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateAuditTaskStatusResponse>(response);
        }

        public SyncInvoker<UpdateAuditTaskStatusResponse> UpdateAuditTaskStatusInvoker(UpdateAuditTaskStatusRequest updateAuditTaskStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditTaskStatusRequest.BusiType, out var valueOfBusiType)) urlParam.Add("busi_type", valueOfBusiType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/summary/{busi_type}/task-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditTaskStatusRequest);
            return new SyncInvoker<UpdateAuditTaskStatusResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateAuditTaskStatusResponse>);
        }
        
        /// <summary>
        /// 更改报表的计划任务配置信息（topic方式）
        ///
        /// 更改报表的计划任务配置信息（topic方式）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAuditTopicReportSchedulerConfigResponse UpdateAuditTopicReportSchedulerConfig(UpdateAuditTopicReportSchedulerConfigRequest updateAuditTopicReportSchedulerConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditTopicReportSchedulerConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/reports/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditTopicReportSchedulerConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateAuditTopicReportSchedulerConfigResponse>(response);
        }

        public SyncInvoker<UpdateAuditTopicReportSchedulerConfigResponse> UpdateAuditTopicReportSchedulerConfigInvoker(UpdateAuditTopicReportSchedulerConfigRequest updateAuditTopicReportSchedulerConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditTopicReportSchedulerConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/reports/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditTopicReportSchedulerConfigRequest);
            return new SyncInvoker<UpdateAuditTopicReportSchedulerConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAuditTopicReportSchedulerConfigResponse>);
        }
        
        /// <summary>
        /// 更改数据库加密实例的名称
        ///
        /// 更改数据库加密实例的名称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDbEncryptInstanceNameResponse UpdateDbEncryptInstanceName(UpdateDbEncryptInstanceNameRequest updateDbEncryptInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDbEncryptInstanceNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDbEncryptInstanceNameRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDbEncryptInstanceNameResponse>(response);
        }

        public SyncInvoker<UpdateDbEncryptInstanceNameResponse> UpdateDbEncryptInstanceNameInvoker(UpdateDbEncryptInstanceNameRequest updateDbEncryptInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDbEncryptInstanceNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDbEncryptInstanceNameRequest);
            return new SyncInvoker<UpdateDbEncryptInstanceNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDbEncryptInstanceNameResponse>);
        }
        
        /// <summary>
        /// 更改数据库运维实例的名称
        ///
        /// 更改数据库运维实例的名称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDbOmInstanceNameResponse UpdateDbOmInstanceName(UpdateDbOmInstanceNameRequest updateDbOmInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDbOmInstanceNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDbOmInstanceNameRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDbOmInstanceNameResponse>(response);
        }

        public SyncInvoker<UpdateDbOmInstanceNameResponse> UpdateDbOmInstanceNameInvoker(UpdateDbOmInstanceNameRequest updateDbOmInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDbOmInstanceNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDbOmInstanceNameRequest);
            return new SyncInvoker<UpdateDbOmInstanceNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDbOmInstanceNameResponse>);
        }
        
        /// <summary>
        /// 修改编辑隐私数据脱敏规则
        ///
        /// 修改编辑隐私数据脱敏规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSensitiveMaskRuleResponse UpdateSensitiveMaskRule(UpdateSensitiveMaskRuleRequest updateSensitiveMaskRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSensitiveMaskRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateSensitiveMaskRuleRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/rule/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSensitiveMaskRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateSensitiveMaskRuleResponse>(response);
        }

        public SyncInvoker<UpdateSensitiveMaskRuleResponse> UpdateSensitiveMaskRuleInvoker(UpdateSensitiveMaskRuleRequest updateSensitiveMaskRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSensitiveMaskRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateSensitiveMaskRuleRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/rule/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSensitiveMaskRuleRequest);
            return new SyncInvoker<UpdateSensitiveMaskRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateSensitiveMaskRuleResponse>);
        }
        
        /// <summary>
        /// 往OBS导出审计数据库配置
        ///
        /// 往OBS导出审计数据库配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UploadAuditDbConfigResponse UploadAuditDbConfig(UploadAuditDbConfigRequest uploadAuditDbConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/databases/configs/obs-upload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", uploadAuditDbConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UploadAuditDbConfigResponse>(response);
        }

        public SyncInvoker<UploadAuditDbConfigResponse> UploadAuditDbConfigInvoker(UploadAuditDbConfigRequest uploadAuditDbConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/databases/configs/obs-upload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", uploadAuditDbConfigRequest);
            return new SyncInvoker<UploadAuditDbConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadAuditDbConfigResponse>);
        }
        
        /// <summary>
        /// 添加审计数据库Agent
        ///
        /// 添加审计数据库Agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddAuditAgentNewResponse AddAuditAgentNew(AddAuditAgentNewRequest addAuditAgentNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addAuditAgentNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditAgentNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddAuditAgentNewResponse>(response);
        }

        public SyncInvoker<AddAuditAgentNewResponse> AddAuditAgentNewInvoker(AddAuditAgentNewRequest addAuditAgentNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addAuditAgentNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditAgentNewRequest);
            return new SyncInvoker<AddAuditAgentNewResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAuditAgentNewResponse>);
        }
        
        /// <summary>
        /// 指定agent_id方式添加agent
        ///
        /// 指定agent_id方式添加agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAuditDbAgentResponse CreateAuditDbAgent(CreateAuditDbAgentRequest createAuditDbAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAuditDbAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createAuditDbAgentRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuditDbAgentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAuditDbAgentResponse>(response);
        }

        public SyncInvoker<CreateAuditDbAgentResponse> CreateAuditDbAgentInvoker(CreateAuditDbAgentRequest createAuditDbAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAuditDbAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createAuditDbAgentRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuditDbAgentRequest);
            return new SyncInvoker<CreateAuditDbAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAuditDbAgentResponse>);
        }
        
        /// <summary>
        /// 删除数据库Agent
        ///
        /// 删除数据库Agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAuditAgentNewResponse DeleteAuditAgentNew(DeleteAuditAgentNewRequest deleteAuditAgentNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAgentNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAgentNewRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditAgentNewRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditAgentNewResponse>(response);
        }

        public SyncInvoker<DeleteAuditAgentNewResponse> DeleteAuditAgentNewInvoker(DeleteAuditAgentNewRequest deleteAuditAgentNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAgentNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAgentNewRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditAgentNewRequest);
            return new SyncInvoker<DeleteAuditAgentNewResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditAgentNewResponse>);
        }
        
        /// <summary>
        /// 下载审计Agent
        ///
        /// 下载审计Agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadAuditAgentNewResponse DownloadAuditAgentNew(DownloadAuditAgentNewRequest downloadAuditAgentNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditAgentNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditAgentNewRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/agents/{agent_id}/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAuditAgentNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadAuditAgentNewResponse>(response);
        }

        public SyncInvoker<DownloadAuditAgentNewResponse> DownloadAuditAgentNewInvoker(DownloadAuditAgentNewRequest downloadAuditAgentNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditAgentNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditAgentNewRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/agents/{agent_id}/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAuditAgentNewRequest);
            return new SyncInvoker<DownloadAuditAgentNewResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadAuditAgentNewResponse>);
        }
        
        /// <summary>
        /// 查询数据库Agent列表
        ///
        /// 查询数据库Agent列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditAgentNewResponse ListAuditAgentNew(ListAuditAgentNewRequest listAuditAgentNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditAgentNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditAgentNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditAgentNewResponse>(response);
        }

        public SyncInvoker<ListAuditAgentNewResponse> ListAuditAgentNewInvoker(ListAuditAgentNewRequest listAuditAgentNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditAgentNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditAgentNewRequest);
            return new SyncInvoker<ListAuditAgentNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditAgentNewResponse>);
        }
        
        /// <summary>
        /// 开启/关闭Agent
        ///
        /// 用于开启和关闭Agent审计的功能，当开启后，开始抓取用户的访问信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchAgentNewResponse SwitchAgentNew(SwitchAgentNewRequest switchAgentNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchAgentNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/agent/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAgentNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchAgentNewResponse>(response);
        }

        public SyncInvoker<SwitchAgentNewResponse> SwitchAgentNewInvoker(SwitchAgentNewRequest switchAgentNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchAgentNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/agent/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAgentNewRequest);
            return new SyncInvoker<SwitchAgentNewResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchAgentNewResponse>);
        }
        
        /// <summary>
        /// 批量添加白名单
        ///
        /// 批量添加白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchAddAuditWhitelistResponse BatchAddAuditWhitelist(BatchAddAuditWhitelistRequest batchAddAuditWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchAddAuditWhitelistRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/whitelists", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddAuditWhitelistRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchAddAuditWhitelistResponse>(response);
        }

        public SyncInvoker<BatchAddAuditWhitelistResponse> BatchAddAuditWhitelistInvoker(BatchAddAuditWhitelistRequest batchAddAuditWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchAddAuditWhitelistRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/whitelists", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddAuditWhitelistRequest);
            return new SyncInvoker<BatchAddAuditWhitelistResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAddAuditWhitelistResponse>);
        }
        
        /// <summary>
        /// 添加sql自定义规则
        ///
        /// 添加sql自定义规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAuditSqlRuleResponse CreateAuditSqlRule(CreateAuditSqlRuleRequest createAuditSqlRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAuditSqlRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/sql", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuditSqlRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAuditSqlRuleResponse>(response);
        }

        public SyncInvoker<CreateAuditSqlRuleResponse> CreateAuditSqlRuleInvoker(CreateAuditSqlRuleRequest createAuditSqlRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAuditSqlRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/sql", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuditSqlRuleRequest);
            return new SyncInvoker<CreateAuditSqlRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAuditSqlRuleResponse>);
        }
        
        /// <summary>
        /// 删除sql自定义规则
        ///
        /// 删除sql自定义规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAuditRuleSqlResponse DeleteAuditRuleSql(DeleteAuditRuleSqlRequest deleteAuditRuleSqlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditRuleSqlRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditRuleSqlRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/sql/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditRuleSqlRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditRuleSqlResponse>(response);
        }

        public SyncInvoker<DeleteAuditRuleSqlResponse> DeleteAuditRuleSqlInvoker(DeleteAuditRuleSqlRequest deleteAuditRuleSqlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditRuleSqlRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditRuleSqlRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/sql/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditRuleSqlRequest);
            return new SyncInvoker<DeleteAuditRuleSqlResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditRuleSqlResponse>);
        }
        
        /// <summary>
        /// 批量删除白名单
        ///
        /// 批量删除白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAuditWhitelistResponse DeleteAuditWhitelist(DeleteAuditWhitelistRequest deleteAuditWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditWhitelistRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/whitelists/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditWhitelistRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteAuditWhitelistResponse>(response);
        }

        public SyncInvoker<DeleteAuditWhitelistResponse> DeleteAuditWhitelistInvoker(DeleteAuditWhitelistRequest deleteAuditWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditWhitelistRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/whitelists/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditWhitelistRequest);
            return new SyncInvoker<DeleteAuditWhitelistResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteAuditWhitelistResponse>);
        }
        
        /// <summary>
        /// 查询SQL注入规则策略
        ///
        /// 查询SQL注入规则策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSqlInjectionRulesNewResponse ListSqlInjectionRulesNew(ListSqlInjectionRulesNewRequest listSqlInjectionRulesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlInjectionRulesNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/sqls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSqlInjectionRulesNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListSqlInjectionRulesNewResponse>(response);
        }

        public SyncInvoker<ListSqlInjectionRulesNewResponse> ListSqlInjectionRulesNewInvoker(ListSqlInjectionRulesNewRequest listSqlInjectionRulesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlInjectionRulesNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/sqls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSqlInjectionRulesNewRequest);
            return new SyncInvoker<ListSqlInjectionRulesNewResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSqlInjectionRulesNewResponse>);
        }
        
        /// <summary>
        /// 查询白名单列表
        ///
        /// 查询白名单列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWhitelistsResponse ListWhitelists(ListWhitelistsRequest listWhitelistsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listWhitelistsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/whitelists", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWhitelistsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListWhitelistsResponse>(response);
        }

        public SyncInvoker<ListWhitelistsResponse> ListWhitelistsInvoker(ListWhitelistsRequest listWhitelistsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listWhitelistsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/whitelists", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWhitelistsRequest);
            return new SyncInvoker<ListWhitelistsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWhitelistsResponse>);
        }
        
        /// <summary>
        /// 开启关闭sql注入策略
        ///
        /// 开启关闭sql注入策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetAuditSqlRuleSwitchResponse SetAuditSqlRuleSwitch(SetAuditSqlRuleSwitchRequest setAuditSqlRuleSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditSqlRuleSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/sql/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditSqlRuleSwitchRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetAuditSqlRuleSwitchResponse>(response);
        }

        public SyncInvoker<SetAuditSqlRuleSwitchResponse> SetAuditSqlRuleSwitchInvoker(SetAuditSqlRuleSwitchRequest setAuditSqlRuleSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditSqlRuleSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/sql/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditSqlRuleSwitchRequest);
            return new SyncInvoker<SetAuditSqlRuleSwitchResponse>(this, "POST", request, JsonUtils.DeSerialize<SetAuditSqlRuleSwitchResponse>);
        }
        
        /// <summary>
        /// sql规则优先级排序
        ///
        /// sql规则优先级排序
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetSqlRuleRankResponse SetSqlRuleRank(SetSqlRuleRankRequest setSqlRuleRankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSqlRuleRankRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/sql/rank", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSqlRuleRankRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetSqlRuleRankResponse>(response);
        }

        public SyncInvoker<SetSqlRuleRankResponse> SetSqlRuleRankInvoker(SetSqlRuleRankRequest setSqlRuleRankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSqlRuleRankRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/sql/rank", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSqlRuleRankRequest);
            return new SyncInvoker<SetSqlRuleRankResponse>(this, "POST", request, JsonUtils.DeSerialize<SetSqlRuleRankResponse>);
        }
        
        /// <summary>
        /// 编辑sql自定义规则
        ///
        /// 编辑sql自定义规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAuditSqlRuleResponse UpdateAuditSqlRule(UpdateAuditSqlRuleRequest updateAuditSqlRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditSqlRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateAuditSqlRuleRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/sql/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditSqlRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateAuditSqlRuleResponse>(response);
        }

        public SyncInvoker<UpdateAuditSqlRuleResponse> UpdateAuditSqlRuleInvoker(UpdateAuditSqlRuleRequest updateAuditSqlRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditSqlRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateAuditSqlRuleRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/sql/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditSqlRuleRequest);
            return new SyncInvoker<UpdateAuditSqlRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAuditSqlRuleResponse>);
        }
        
        /// <summary>
        /// 修改白名单
        ///
        /// 修改白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAuditWhitelistResponse UpdateAuditWhitelist(UpdateAuditWhitelistRequest updateAuditWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditWhitelistRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateAuditWhitelistRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/whitelists/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditWhitelistRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAuditWhitelistResponse>(response);
        }

        public SyncInvoker<UpdateAuditWhitelistResponse> UpdateAuditWhitelistInvoker(UpdateAuditWhitelistRequest updateAuditWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditWhitelistRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateAuditWhitelistRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/whitelists/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditWhitelistRequest);
            return new SyncInvoker<UpdateAuditWhitelistResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAuditWhitelistResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(batchAddResourceTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(batchAddResourceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddResourceTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchAddResourceTagResponse>(response);
        }

        public SyncInvoker<BatchAddResourceTagResponse> BatchAddResourceTagInvoker(BatchAddResourceTagRequest batchAddResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchAddResourceTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(batchAddResourceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
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
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteResourceTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteResourceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteResourceTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<BatchDeleteResourceTagResponse>(response);
        }

        public SyncInvoker<BatchDeleteResourceTagResponse> BatchDeleteResourceTagInvoker(BatchDeleteResourceTagRequest batchDeleteResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteResourceTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteResourceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
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
            if (StringUtils.TryConvertToNonEmptyString(countResourceInstanceByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", countResourceInstanceByTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CountResourceInstanceByTagResponse>(response);
        }

        public SyncInvoker<CountResourceInstanceByTagResponse> CountResourceInstanceByTagInvoker(CountResourceInstanceByTagRequest countResourceInstanceByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countResourceInstanceByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", countResourceInstanceByTagRequest);
            return new SyncInvoker<CountResourceInstanceByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<CountResourceInstanceByTagResponse>);
        }
        
        /// <summary>
        /// 获取实例标签
        ///
        /// 获取实例标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditTagsResponse ListAuditTags(ListAuditTagsRequest listAuditTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listAuditTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditTagsResponse>(response);
        }

        public SyncInvoker<ListAuditTagsResponse> ListAuditTagsInvoker(ListAuditTagsRequest listAuditTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listAuditTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditTagsRequest);
            return new SyncInvoker<ListAuditTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditTagsResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(listProjectResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectResourceTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProjectResourceTagsResponse>(response);
        }

        public SyncInvoker<ListProjectResourceTagsResponse> ListProjectResourceTagsInvoker(ListProjectResourceTagsRequest listProjectResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
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
            if (StringUtils.TryConvertToNonEmptyString(listResourceInstanceByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstanceByTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListResourceInstanceByTagResponse>(response);
        }

        public SyncInvoker<ListResourceInstanceByTagResponse> ListResourceInstanceByTagInvoker(ListResourceInstanceByTagRequest listResourceInstanceByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceInstanceByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstanceByTagRequest);
            return new SyncInvoker<ListResourceInstanceByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceInstanceByTagResponse>);
        }
        
    }
}