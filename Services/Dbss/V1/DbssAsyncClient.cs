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
        /// 添加审计数据库Agent[待下线]
        ///
        /// 添加审计数据库Agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<AddAuditAgentResponse> AddAuditAgentAsync(AddAuditAgentRequest addAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addAuditAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditAgentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddAuditAgentResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<AddAuditAgentResponse> AddAuditAgentAsyncInvoker(AddAuditAgentRequest addAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addAuditAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditAgentRequest);
            return new AsyncInvoker<AddAuditAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAuditAgentResponse>);
        }
        
        /// <summary>
        /// 添加自建数据库[待下线]
        ///
        /// 添加自建数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<AddAuditDatabaseResponse> AddAuditDatabaseAsync(AddAuditDatabaseRequest addAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addAuditDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddAuditDatabaseResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<AddAuditDatabaseResponse> AddAuditDatabaseAsyncInvoker(AddAuditDatabaseRequest addAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addAuditDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditDatabaseRequest);
            return new AsyncInvoker<AddAuditDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAuditDatabaseResponse>);
        }
        
        /// <summary>
        /// 添加自建数据库
        ///
        /// 添加自建数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddAuditDatabaseNewResponse> AddAuditDatabaseNewAsync(AddAuditDatabaseNewRequest addAuditDatabaseNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addAuditDatabaseNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditDatabaseNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddAuditDatabaseNewResponse>(response);
        }

        public AsyncInvoker<AddAuditDatabaseNewResponse> AddAuditDatabaseNewAsyncInvoker(AddAuditDatabaseNewRequest addAuditDatabaseNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addAuditDatabaseNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditDatabaseNewRequest);
            return new AsyncInvoker<AddAuditDatabaseNewResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAuditDatabaseNewResponse>);
        }
        
        /// <summary>
        /// 添加RDS数据库[待下线]
        ///
        /// 添加RDS数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<AddRdsDatabaseResponse> AddRdsDatabaseAsync(AddRdsDatabaseRequest addRdsDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRdsDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addRdsDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddRdsDatabaseResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<AddRdsDatabaseResponse> AddRdsDatabaseAsyncInvoker(AddRdsDatabaseRequest addRdsDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRdsDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addRdsDatabaseRequest);
            return new AsyncInvoker<AddRdsDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<AddRdsDatabaseResponse>);
        }
        
        /// <summary>
        /// 添加RDS数据库
        ///
        /// 添加RDS数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddRdsDatabaseNewResponse> AddRdsDatabaseNewAsync(AddRdsDatabaseNewRequest addRdsDatabaseNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRdsDatabaseNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addRdsDatabaseNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddRdsDatabaseNewResponse>(response);
        }

        public AsyncInvoker<AddRdsDatabaseNewResponse> AddRdsDatabaseNewAsyncInvoker(AddRdsDatabaseNewRequest addRdsDatabaseNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRdsDatabaseNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addRdsDatabaseNewRequest);
            return new AsyncInvoker<AddRdsDatabaseNewResponse>(this, "POST", request, JsonUtils.DeSerialize<AddRdsDatabaseNewResponse>);
        }
        
        /// <summary>
        /// 添加RDS数据库[待下线]
        ///
        /// 添加RDS数据库。V1版本已不再维护，待下线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<AddRdsNoAgentDatabaseResponse> AddRdsNoAgentDatabaseAsync(AddRdsNoAgentDatabaseRequest addRdsNoAgentDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRdsNoAgentDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addRdsNoAgentDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddRdsNoAgentDatabaseResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<AddRdsNoAgentDatabaseResponse> AddRdsNoAgentDatabaseAsyncInvoker(AddRdsNoAgentDatabaseRequest addRdsNoAgentDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRdsNoAgentDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/databases/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addRdsNoAgentDatabaseRequest);
            return new AsyncInvoker<AddRdsNoAgentDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<AddRdsNoAgentDatabaseResponse>);
        }
        
        /// <summary>
        /// 审计范围规则操作-删除策略
        ///
        /// 审计范围规则操作-删除策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteAuditScopeResponse> BatchDeleteAuditScopeAsync(BatchDeleteAuditScopeRequest batchDeleteAuditScopeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteAuditScopeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/scopes/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAuditScopeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteAuditScopeResponse>(response);
        }

        public AsyncInvoker<BatchDeleteAuditScopeResponse> BatchDeleteAuditScopeAsyncInvoker(BatchDeleteAuditScopeRequest batchDeleteAuditScopeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteAuditScopeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/scopes/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAuditScopeRequest);
            return new AsyncInvoker<BatchDeleteAuditScopeResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteAuditScopeResponse>);
        }
        
        /// <summary>
        /// 批量标记
        ///
        /// 批量标记
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchSetAuditAlarmLogStatusResponse> BatchSetAuditAlarmLogStatusAsync(BatchSetAuditAlarmLogStatusRequest batchSetAuditAlarmLogStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchSetAuditAlarmLogStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/alarm-log/mark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetAuditAlarmLogStatusRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchSetAuditAlarmLogStatusResponse>(response);
        }

        public AsyncInvoker<BatchSetAuditAlarmLogStatusResponse> BatchSetAuditAlarmLogStatusAsyncInvoker(BatchSetAuditAlarmLogStatusRequest batchSetAuditAlarmLogStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchSetAuditAlarmLogStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/alarm-log/mark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetAuditAlarmLogStatusRequest);
            return new AsyncInvoker<BatchSetAuditAlarmLogStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchSetAuditAlarmLogStatusResponse>);
        }
        
        /// <summary>
        /// 绑定数据库加密实例的eip
        ///
        /// 绑定数据库加密实例的eip
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BindDbEncryptEipResponse> BindDbEncryptEipAsync(BindDbEncryptEipRequest bindDbEncryptEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(bindDbEncryptEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/eip/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", bindDbEncryptEipRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BindDbEncryptEipResponse>(response);
        }

        public AsyncInvoker<BindDbEncryptEipResponse> BindDbEncryptEipAsyncInvoker(BindDbEncryptEipRequest bindDbEncryptEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(bindDbEncryptEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/eip/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", bindDbEncryptEipRequest);
            return new AsyncInvoker<BindDbEncryptEipResponse>(this, "POST", request, JsonUtils.DeSerialize<BindDbEncryptEipResponse>);
        }
        
        /// <summary>
        /// 绑定数据库运维实例的eip
        ///
        /// 绑定数据库运维实例的eip
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BindDbOmEipResponse> BindDbOmEipAsync(BindDbOmEipRequest bindDbOmEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(bindDbOmEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/eip/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", bindDbOmEipRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BindDbOmEipResponse>(response);
        }

        public AsyncInvoker<BindDbOmEipResponse> BindDbOmEipAsyncInvoker(BindDbOmEipRequest bindDbOmEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(bindDbOmEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/eip/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", bindDbOmEipRequest);
            return new AsyncInvoker<BindDbOmEipResponse>(this, "POST", request, JsonUtils.DeSerialize<BindDbOmEipResponse>);
        }
        
        /// <summary>
        /// 更改数据库加密实例的安全组
        ///
        /// 更改数据库加密实例的安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeDbEncryptSecurityGroupResponse> ChangeDbEncryptSecurityGroupAsync(ChangeDbEncryptSecurityGroupRequest changeDbEncryptSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeDbEncryptSecurityGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeDbEncryptSecurityGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ChangeDbEncryptSecurityGroupResponse>(response);
        }

        public AsyncInvoker<ChangeDbEncryptSecurityGroupResponse> ChangeDbEncryptSecurityGroupAsyncInvoker(ChangeDbEncryptSecurityGroupRequest changeDbEncryptSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeDbEncryptSecurityGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeDbEncryptSecurityGroupRequest);
            return new AsyncInvoker<ChangeDbEncryptSecurityGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeDbEncryptSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 更改数据库运维实例的安全组
        ///
        /// 更改数据库运维实例的安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeDbOmSecurityGroupResponse> ChangeDbOmSecurityGroupAsync(ChangeDbOmSecurityGroupRequest changeDbOmSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeDbOmSecurityGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeDbOmSecurityGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ChangeDbOmSecurityGroupResponse>(response);
        }

        public AsyncInvoker<ChangeDbOmSecurityGroupResponse> ChangeDbOmSecurityGroupAsyncInvoker(ChangeDbOmSecurityGroupRequest changeDbOmSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeDbOmSecurityGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeDbOmSecurityGroupRequest);
            return new AsyncInvoker<ChangeDbOmSecurityGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeDbOmSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 触发审计实例升级
        ///
        /// 触发审计实例升级
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ConfirmUpgradeAuditResponse> ConfirmUpgradeAuditAsync(ConfirmUpgradeAuditRequest confirmUpgradeAuditRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(confirmUpgradeAuditRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{resource_id}/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmUpgradeAuditRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ConfirmUpgradeAuditResponse>(response);
        }

        public AsyncInvoker<ConfirmUpgradeAuditResponse> ConfirmUpgradeAuditAsyncInvoker(ConfirmUpgradeAuditRequest confirmUpgradeAuditRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(confirmUpgradeAuditRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{resource_id}/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmUpgradeAuditRequest);
            return new AsyncInvoker<ConfirmUpgradeAuditResponse>(this, "POST", request, JsonUtils.DeSerialize<ConfirmUpgradeAuditResponse>);
        }
        
        /// <summary>
        /// 查询数据库用户会话分布
        ///
        /// 查询数据库用户会话分布
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountDbAccountSessionResponse> CountDbAccountSessionAsync(CountDbAccountSessionRequest countDbAccountSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countDbAccountSessionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/session/db-account", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countDbAccountSessionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var countDbAccountSessionResponse = JsonUtils.DeSerializeNull<CountDbAccountSessionResponse>(response);
            countDbAccountSessionResponse.Body = JsonUtils.DeSerializeList<ReportAccountSessionNew>(response);
            return countDbAccountSessionResponse;
        }

        public AsyncInvoker<CountDbAccountSessionResponse> CountDbAccountSessionAsyncInvoker(CountDbAccountSessionRequest countDbAccountSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countDbAccountSessionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/session/db-account", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countDbAccountSessionRequest);
            return new AsyncInvoker<CountDbAccountSessionResponse>(this, "POST", request, response =>
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
        public async Task<CountDbClientSessionResponse> CountDbClientSessionAsync(CountDbClientSessionRequest countDbClientSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countDbClientSessionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/session/db-client", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countDbClientSessionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var countDbClientSessionResponse = JsonUtils.DeSerializeNull<CountDbClientSessionResponse>(response);
            countDbClientSessionResponse.Body = JsonUtils.DeSerializeList<ReportClientSessionNew>(response);
            return countDbClientSessionResponse;
        }

        public AsyncInvoker<CountDbClientSessionResponse> CountDbClientSessionAsyncInvoker(CountDbClientSessionRequest countDbClientSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countDbClientSessionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/session/db-client", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countDbClientSessionRequest);
            return new AsyncInvoker<CountDbClientSessionResponse>(this, "POST", request, response =>
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
        public async Task<CountInjectionStatisticsResponse> CountInjectionStatisticsAsync(CountInjectionStatisticsRequest countInjectionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countInjectionStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/sql-injection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countInjectionStatisticsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CountInjectionStatisticsResponse>(response);
        }

        public AsyncInvoker<CountInjectionStatisticsResponse> CountInjectionStatisticsAsyncInvoker(CountInjectionStatisticsRequest countInjectionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countInjectionStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/sql-injection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countInjectionStatisticsRequest);
            return new AsyncInvoker<CountInjectionStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<CountInjectionStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取指定时间段内的风险操作数量分布统计
        ///
        /// 获取指定时间段内的风险操作数量分布统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountOperationStatisticsResponse> CountOperationStatisticsAsync(CountOperationStatisticsRequest countOperationStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countOperationStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/risk-operation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countOperationStatisticsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CountOperationStatisticsResponse>(response);
        }

        public AsyncInvoker<CountOperationStatisticsResponse> CountOperationStatisticsAsyncInvoker(CountOperationStatisticsRequest countOperationStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countOperationStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/risk-operation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countOperationStatisticsRequest);
            return new AsyncInvoker<CountOperationStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<CountOperationStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取指定时间段内的风险分布统计
        ///
        /// 获取指定时间段内的风险分布统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountRiskTrendStatisticsResponse> CountRiskTrendStatisticsAsync(CountRiskTrendStatisticsRequest countRiskTrendStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countRiskTrendStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/risk-level", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countRiskTrendStatisticsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CountRiskTrendStatisticsResponse>(response);
        }

        public AsyncInvoker<CountRiskTrendStatisticsResponse> CountRiskTrendStatisticsAsyncInvoker(CountRiskTrendStatisticsRequest countRiskTrendStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countRiskTrendStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/risk-level", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countRiskTrendStatisticsRequest);
            return new AsyncInvoker<CountRiskTrendStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<CountRiskTrendStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取指定时间段内的查询会话统计
        ///
        /// 获取指定时间段内的查询会话统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountSessionStatisticsResponse> CountSessionStatisticsAsync(CountSessionStatisticsRequest countSessionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countSessionStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/session", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countSessionStatisticsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CountSessionStatisticsResponse>(response);
        }

        public AsyncInvoker<CountSessionStatisticsResponse> CountSessionStatisticsAsyncInvoker(CountSessionStatisticsRequest countSessionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countSessionStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/session", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countSessionStatisticsRequest);
            return new AsyncInvoker<CountSessionStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<CountSessionStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取指定时间段内的SQL分布统计
        ///
        /// 获取指定时间段内的SQL分布统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountSqlStatisticsResponse> CountSqlStatisticsAsync(CountSqlStatisticsRequest countSqlStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countSqlStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/sql-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countSqlStatisticsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CountSqlStatisticsResponse>(response);
        }

        public AsyncInvoker<CountSqlStatisticsResponse> CountSqlStatisticsAsyncInvoker(CountSqlStatisticsRequest countSqlStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countSqlStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/sql-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countSqlStatisticsRequest);
            return new AsyncInvoker<CountSqlStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<CountSqlStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取指定时间段内的sql数量分布统计
        ///
        /// 获取指定时间段内的sql数量分布统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountSqlTrendStatisticsResponse> CountSqlTrendStatisticsAsync(CountSqlTrendStatisticsRequest countSqlTrendStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countSqlTrendStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/sql-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countSqlTrendStatisticsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CountSqlTrendStatisticsResponse>(response);
        }

        public AsyncInvoker<CountSqlTrendStatisticsResponse> CountSqlTrendStatisticsAsyncInvoker(CountSqlTrendStatisticsRequest countSqlTrendStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countSqlTrendStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/statistics/trend/sql-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countSqlTrendStatisticsRequest);
            return new AsyncInvoker<CountSqlTrendStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<CountSqlTrendStatisticsResponse>);
        }
        
        /// <summary>
        /// 添加风险规则
        ///
        /// 添加风险规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAuditRiskRuleResponse> CreateAuditRiskRuleAsync(CreateAuditRiskRuleRequest createAuditRiskRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAuditRiskRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/risk", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuditRiskRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAuditRiskRuleResponse>(response);
        }

        public AsyncInvoker<CreateAuditRiskRuleResponse> CreateAuditRiskRuleAsyncInvoker(CreateAuditRiskRuleRequest createAuditRiskRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAuditRiskRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/risk", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuditRiskRuleRequest);
            return new AsyncInvoker<CreateAuditRiskRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAuditRiskRuleResponse>);
        }
        
        /// <summary>
        /// 添加审计范围策略
        ///
        /// 添加审计范围策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAuditScopeRuleResponse> CreateAuditScopeRuleAsync(CreateAuditScopeRuleRequest createAuditScopeRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAuditScopeRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/scopes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuditScopeRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAuditScopeRuleResponse>(response);
        }

        public AsyncInvoker<CreateAuditScopeRuleResponse> CreateAuditScopeRuleAsyncInvoker(CreateAuditScopeRuleRequest createAuditScopeRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAuditScopeRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/scopes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuditScopeRuleRequest);
            return new AsyncInvoker<CreateAuditScopeRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAuditScopeRuleResponse>);
        }
        
        /// <summary>
        /// 按包周期方式购买数据库加密实例
        ///
        /// 按需方式购买数据库加密实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDbEncryptInstancePeriodResponse> CreateDbEncryptInstancePeriodAsync(CreateDbEncryptInstancePeriodRequest createDbEncryptInstancePeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/db-encrypt/charge/period/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbEncryptInstancePeriodRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDbEncryptInstancePeriodResponse>(response);
        }

        public AsyncInvoker<CreateDbEncryptInstancePeriodResponse> CreateDbEncryptInstancePeriodAsyncInvoker(CreateDbEncryptInstancePeriodRequest createDbEncryptInstancePeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/db-encrypt/charge/period/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbEncryptInstancePeriodRequest);
            return new AsyncInvoker<CreateDbEncryptInstancePeriodResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDbEncryptInstancePeriodResponse>);
        }
        
        /// <summary>
        /// 包周期购买数据库运维实例
        ///
        /// 包周期购买数据库运维实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDbOmInstancePeriodResponse> CreateDbOmInstancePeriodAsync(CreateDbOmInstancePeriodRequest createDbOmInstancePeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/db-om/charge/period/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbOmInstancePeriodRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDbOmInstancePeriodResponse>(response);
        }

        public AsyncInvoker<CreateDbOmInstancePeriodResponse> CreateDbOmInstancePeriodAsyncInvoker(CreateDbOmInstancePeriodRequest createDbOmInstancePeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/db-om/charge/period/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbOmInstancePeriodRequest);
            return new AsyncInvoker<CreateDbOmInstancePeriodResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDbOmInstancePeriodResponse>);
        }
        
        /// <summary>
        /// 包年包月计费模式创建审计实例[待下线]
        ///
        /// 包年包月计费模式创建审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<CreateInstancesPeriodOrderResponse> CreateInstancesPeriodOrderAsync(CreateInstancesPeriodOrderRequest createInstancesPeriodOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dbss/audit/charge/period/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstancesPeriodOrderRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstancesPeriodOrderResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<CreateInstancesPeriodOrderResponse> CreateInstancesPeriodOrderAsyncInvoker(CreateInstancesPeriodOrderRequest createInstancesPeriodOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dbss/audit/charge/period/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstancesPeriodOrderRequest);
            return new AsyncInvoker<CreateInstancesPeriodOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstancesPeriodOrderResponse>);
        }
        
        /// <summary>
        /// 包年包月计费模式创建审计实例
        ///
        /// 包年包月计费模式创建审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstancesPeriodOrderNewResponse> CreateInstancesPeriodOrderNewAsync(CreateInstancesPeriodOrderNewRequest createInstancesPeriodOrderNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/charge/period/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstancesPeriodOrderNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstancesPeriodOrderNewResponse>(response);
        }

        public AsyncInvoker<CreateInstancesPeriodOrderNewResponse> CreateInstancesPeriodOrderNewAsyncInvoker(CreateInstancesPeriodOrderNewRequest createInstancesPeriodOrderNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/charge/period/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstancesPeriodOrderNewRequest);
            return new AsyncInvoker<CreateInstancesPeriodOrderNewResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstancesPeriodOrderNewResponse>);
        }
        
        /// <summary>
        /// 立即生成报表
        ///
        /// 立即生成报表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateReportResponse> CreateReportAsync(CreateReportRequest createReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createReportRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/reports/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReportRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateReportResponse>(response);
        }

        public AsyncInvoker<CreateReportResponse> CreateReportAsyncInvoker(CreateReportRequest createReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createReportRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/reports/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReportRequest);
            return new AsyncInvoker<CreateReportResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateReportResponse>);
        }
        
        /// <summary>
        /// 增加隐私数据脱敏规则
        ///
        /// 增加隐私数据脱敏规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSensitiveMaskRuleResponse> CreateSensitiveMaskRuleAsync(CreateSensitiveMaskRuleRequest createSensitiveMaskRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSensitiveMaskRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSensitiveMaskRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSensitiveMaskRuleResponse>(response);
        }

        public AsyncInvoker<CreateSensitiveMaskRuleResponse> CreateSensitiveMaskRuleAsyncInvoker(CreateSensitiveMaskRuleRequest createSensitiveMaskRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSensitiveMaskRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSensitiveMaskRuleRequest);
            return new AsyncInvoker<CreateSensitiveMaskRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSensitiveMaskRuleResponse>);
        }
        
        /// <summary>
        /// 删除数据库Agent[待下线]
        ///
        /// 删除数据库Agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<DeleteAuditAgentResponse> DeleteAuditAgentAsync(DeleteAuditAgentRequest deleteAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAgentRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditAgentRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditAgentResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<DeleteAuditAgentResponse> DeleteAuditAgentAsyncInvoker(DeleteAuditAgentRequest deleteAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAgentRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditAgentRequest);
            return new AsyncInvoker<DeleteAuditAgentResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditAgentResponse>);
        }
        
        /// <summary>
        /// 删除告警监控记录
        ///
        /// 删除告警监控记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAuditAlarmLogResponse> DeleteAuditAlarmLogAsync(DeleteAuditAlarmLogRequest deleteAuditAlarmLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAlarmLogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAlarmLogRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/alarm-log/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditAlarmLogRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditAlarmLogResponse>(response);
        }

        public AsyncInvoker<DeleteAuditAlarmLogResponse> DeleteAuditAlarmLogAsyncInvoker(DeleteAuditAlarmLogRequest deleteAuditAlarmLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAlarmLogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAlarmLogRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/alarm-log/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditAlarmLogRequest);
            return new AsyncInvoker<DeleteAuditAlarmLogResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditAlarmLogResponse>);
        }
        
        /// <summary>
        /// 删除指定备份任务
        ///
        /// 删除指定备份任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAuditBackupTaskResponse> DeleteAuditBackupTaskAsync(DeleteAuditBackupTaskRequest deleteAuditBackupTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditBackupTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditBackupTaskRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backups/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditBackupTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditBackupTaskResponse>(response);
        }

        public AsyncInvoker<DeleteAuditBackupTaskResponse> DeleteAuditBackupTaskAsyncInvoker(DeleteAuditBackupTaskRequest deleteAuditBackupTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditBackupTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditBackupTaskRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backups/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditBackupTaskRequest);
            return new AsyncInvoker<DeleteAuditBackupTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditBackupTaskResponse>);
        }
        
        /// <summary>
        /// 删除数据库[待下线]
        ///
        /// 删除数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<DeleteAuditDatabaseResponse> DeleteAuditDatabaseAsync(DeleteAuditDatabaseRequest deleteAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditDatabaseRequest.DbId, out var valueOfDbId)) urlParam.Add("db_id", valueOfDbId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/{db_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditDatabaseRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditDatabaseResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<DeleteAuditDatabaseResponse> DeleteAuditDatabaseAsyncInvoker(DeleteAuditDatabaseRequest deleteAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditDatabaseRequest.DbId, out var valueOfDbId)) urlParam.Add("db_id", valueOfDbId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/{db_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditDatabaseRequest);
            return new AsyncInvoker<DeleteAuditDatabaseResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditDatabaseResponse>);
        }
        
        /// <summary>
        /// 删除数据库
        ///
        /// 删除数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAuditDatabaseNewResponse> DeleteAuditDatabaseNewAsync(DeleteAuditDatabaseNewRequest deleteAuditDatabaseNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditDatabaseNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditDatabaseNewRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/databases/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditDatabaseNewRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditDatabaseNewResponse>(response);
        }

        public AsyncInvoker<DeleteAuditDatabaseNewResponse> DeleteAuditDatabaseNewAsyncInvoker(DeleteAuditDatabaseNewRequest deleteAuditDatabaseNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditDatabaseNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditDatabaseNewRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/databases/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditDatabaseNewRequest);
            return new AsyncInvoker<DeleteAuditDatabaseNewResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditDatabaseNewResponse>);
        }
        
        /// <summary>
        /// 删除报表
        ///
        /// 删除报表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAuditReportResponse> DeleteAuditReportAsync(DeleteAuditReportRequest deleteAuditReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditReportRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditReportRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/reports/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditReportRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditReportResponse>(response);
        }

        public AsyncInvoker<DeleteAuditReportResponse> DeleteAuditReportAsyncInvoker(DeleteAuditReportRequest deleteAuditReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditReportRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditReportRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/reports/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditReportRequest);
            return new AsyncInvoker<DeleteAuditReportResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditReportResponse>);
        }
        
        /// <summary>
        /// 删除风险策略
        ///
        /// 删除风险策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAuditRuleRiskResponse> DeleteAuditRuleRiskAsync(DeleteAuditRuleRiskRequest deleteAuditRuleRiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditRuleRiskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditRuleRiskRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/risk/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditRuleRiskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditRuleRiskResponse>(response);
        }

        public AsyncInvoker<DeleteAuditRuleRiskResponse> DeleteAuditRuleRiskAsyncInvoker(DeleteAuditRuleRiskRequest deleteAuditRuleRiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditRuleRiskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditRuleRiskRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/risk/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditRuleRiskRequest);
            return new AsyncInvoker<DeleteAuditRuleRiskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditRuleRiskResponse>);
        }
        
        /// <summary>
        /// 删除审计范围策略
        ///
        /// 删除审计范围策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAuditScopeResponse> DeleteAuditScopeAsync(DeleteAuditScopeRequest deleteAuditScopeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditScopeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditScopeRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/scopes/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditScopeRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditScopeResponse>(response);
        }

        public AsyncInvoker<DeleteAuditScopeResponse> DeleteAuditScopeAsyncInvoker(DeleteAuditScopeRequest deleteAuditScopeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditScopeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditScopeRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/scopes/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditScopeRequest);
            return new AsyncInvoker<DeleteAuditScopeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditScopeResponse>);
        }
        
        /// <summary>
        /// 删除数据库加密实例
        ///
        /// 删除数据库加密实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDbEncryptInstanceResponse> DeleteDbEncryptInstanceAsync(DeleteDbEncryptInstanceRequest deleteDbEncryptInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDbEncryptInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbEncryptInstanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDbEncryptInstanceResponse>(response);
        }

        public AsyncInvoker<DeleteDbEncryptInstanceResponse> DeleteDbEncryptInstanceAsyncInvoker(DeleteDbEncryptInstanceRequest deleteDbEncryptInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDbEncryptInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbEncryptInstanceRequest);
            return new AsyncInvoker<DeleteDbEncryptInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDbEncryptInstanceResponse>);
        }
        
        /// <summary>
        /// 删除数据库运维实例
        ///
        /// 删除数据库运维实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDbOmInstanceResponse> DeleteDbOmInstanceAsync(DeleteDbOmInstanceRequest deleteDbOmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDbOmInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbOmInstanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDbOmInstanceResponse>(response);
        }

        public AsyncInvoker<DeleteDbOmInstanceResponse> DeleteDbOmInstanceAsyncInvoker(DeleteDbOmInstanceRequest deleteDbOmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDbOmInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbOmInstanceRequest);
            return new AsyncInvoker<DeleteDbOmInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDbOmInstanceResponse>);
        }
        
        /// <summary>
        /// 删除审计实例[待下线]
        ///
        /// 只有按需计费模式实例没有任务时 或 包周期模式实例状态为故障时，才能执行此操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<DeleteInstancesResponse> DeleteInstancesAsync(DeleteInstancesRequest deleteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteInstancesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInstancesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<DeleteInstancesResponse> DeleteInstancesAsyncInvoker(DeleteInstancesRequest deleteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteInstancesRequest);
            return new AsyncInvoker<DeleteInstancesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteInstancesResponse>);
        }
        
        /// <summary>
        /// 删除审计实例
        ///
        /// 只有按需计费模式实例没有任务时 或 包周期模式实例状态为故障时，才能执行此操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstancesNewResponse> DeleteInstancesNewAsync(DeleteInstancesNewRequest deleteInstancesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteInstancesNewRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInstancesNewResponse>(response);
        }

        public AsyncInvoker<DeleteInstancesNewResponse> DeleteInstancesNewAsyncInvoker(DeleteInstancesNewRequest deleteInstancesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteInstancesNewRequest);
            return new AsyncInvoker<DeleteInstancesNewResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteInstancesNewResponse>);
        }
        
        /// <summary>
        /// 删除隐私数据脱敏规则
        ///
        /// 删除隐私数据脱敏规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSensitiveRulesResponse> DeleteSensitiveRulesAsync(DeleteSensitiveRulesRequest deleteSensitiveRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSensitiveRulesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSensitiveRulesRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/rule/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSensitiveRulesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSensitiveRulesResponse>(response);
        }

        public AsyncInvoker<DeleteSensitiveRulesResponse> DeleteSensitiveRulesAsyncInvoker(DeleteSensitiveRulesRequest deleteSensitiveRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSensitiveRulesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSensitiveRulesRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/rule/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSensitiveRulesRequest);
            return new AsyncInvoker<DeleteSensitiveRulesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSensitiveRulesResponse>);
        }
        
        /// <summary>
        /// 下载审计Agent[待下线]
        ///
        /// 下载审计Agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<DownloadAuditAgentResponse> DownloadAuditAgentAsync(DownloadAuditAgentRequest downloadAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditAgentRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAuditAgentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadAuditAgentResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<DownloadAuditAgentResponse> DownloadAuditAgentAsyncInvoker(DownloadAuditAgentRequest downloadAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditAgentRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAuditAgentRequest);
            return new AsyncInvoker<DownloadAuditAgentResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadAuditAgentResponse>);
        }
        
        /// <summary>
        /// 下载报表
        ///
        /// 下载报表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadAuditReportResponse> DownloadAuditReportAsync(DownloadAuditReportRequest downloadAuditReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditReportRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditReportRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/reports/{id}/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAuditReportRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadAuditReportResponse>(response);
        }

        public AsyncInvoker<DownloadAuditReportResponse> DownloadAuditReportAsyncInvoker(DownloadAuditReportRequest downloadAuditReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditReportRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditReportRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/reports/{id}/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAuditReportRequest);
            return new AsyncInvoker<DownloadAuditReportResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadAuditReportResponse>);
        }
        
        /// <summary>
        /// 获取实例告警配置[待下线]
        ///
        /// 获取实例告警配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListAlarmTopicConfigInfoResponse> ListAlarmTopicConfigInfoAsync(ListAlarmTopicConfigInfoRequest listAlarmTopicConfigInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmTopicConfigInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/alarm/topic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTopicConfigInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmTopicConfigInfoResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListAlarmTopicConfigInfoResponse> ListAlarmTopicConfigInfoAsyncInvoker(ListAlarmTopicConfigInfoRequest listAlarmTopicConfigInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmTopicConfigInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/alarm/topic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTopicConfigInfoRequest);
            return new AsyncInvoker<ListAlarmTopicConfigInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmTopicConfigInfoResponse>);
        }
        
        /// <summary>
        /// 获取实例告警配置
        ///
        /// 获取实例告警配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAlarmTopicConfigInfoNewResponse> ListAlarmTopicConfigInfoNewAsync(ListAlarmTopicConfigInfoNewRequest listAlarmTopicConfigInfoNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmTopicConfigInfoNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/alarm/topic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTopicConfigInfoNewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmTopicConfigInfoNewResponse>(response);
        }

        public AsyncInvoker<ListAlarmTopicConfigInfoNewResponse> ListAlarmTopicConfigInfoNewAsyncInvoker(ListAlarmTopicConfigInfoNewRequest listAlarmTopicConfigInfoNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmTopicConfigInfoNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/alarm/topic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTopicConfigInfoNewRequest);
            return new AsyncInvoker<ListAlarmTopicConfigInfoNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmTopicConfigInfoNewResponse>);
        }
        
        /// <summary>
        /// 查询数据库Agent列表[待下线]
        ///
        /// 查询数据库Agent列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListAuditAgentResponse> ListAuditAgentAsync(ListAuditAgentRequest listAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditAgentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditAgentResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListAuditAgentResponse> ListAuditAgentAsyncInvoker(ListAuditAgentRequest listAuditAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditAgentRequest);
            return new AsyncInvoker<ListAuditAgentResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditAgentResponse>);
        }
        
        /// <summary>
        /// 查询审计告警信息[待下线]
        ///
        /// 查询审计告警信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListAuditAlarmLogResponse> ListAuditAlarmLogAsync(ListAuditAlarmLogRequest listAuditAlarmLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditAlarmLogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/alarm-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditAlarmLogRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAuditAlarmLogResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListAuditAlarmLogResponse> ListAuditAlarmLogAsyncInvoker(ListAuditAlarmLogRequest listAuditAlarmLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditAlarmLogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/alarm-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditAlarmLogRequest);
            return new AsyncInvoker<ListAuditAlarmLogResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditAlarmLogResponse>);
        }
        
        /// <summary>
        /// 查询审计告警信息
        ///
        /// 查询审计告警信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditAlarmLogNewResponse> ListAuditAlarmLogNewAsync(ListAuditAlarmLogNewRequest listAuditAlarmLogNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditAlarmLogNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/alarm-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditAlarmLogNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAuditAlarmLogNewResponse>(response);
        }

        public AsyncInvoker<ListAuditAlarmLogNewResponse> ListAuditAlarmLogNewAsyncInvoker(ListAuditAlarmLogNewRequest listAuditAlarmLogNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditAlarmLogNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/alarm-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditAlarmLogNewRequest);
            return new AsyncInvoker<ListAuditAlarmLogNewResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditAlarmLogNewResponse>);
        }
        
        /// <summary>
        /// 获取所有备份信息
        ///
        /// 获取所有备份信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditBackupInfoResponse> ListAuditBackupInfoAsync(ListAuditBackupInfoRequest listAuditBackupInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditBackupInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditBackupInfoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAuditBackupInfoResponse>(response);
        }

        public AsyncInvoker<ListAuditBackupInfoResponse> ListAuditBackupInfoAsyncInvoker(ListAuditBackupInfoRequest listAuditBackupInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditBackupInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditBackupInfoRequest);
            return new AsyncInvoker<ListAuditBackupInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditBackupInfoResponse>);
        }
        
        /// <summary>
        /// 获取风险导出配置列表
        ///
        /// 获取风险导出配置列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditBackupRiskTemplatesResponse> ListAuditBackupRiskTemplatesAsync(ListAuditBackupRiskTemplatesRequest listAuditBackupRiskTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditBackupRiskTemplatesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/risk/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditBackupRiskTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditBackupRiskTemplatesResponse>(response);
        }

        public AsyncInvoker<ListAuditBackupRiskTemplatesResponse> ListAuditBackupRiskTemplatesAsyncInvoker(ListAuditBackupRiskTemplatesRequest listAuditBackupRiskTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditBackupRiskTemplatesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/risk/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditBackupRiskTemplatesRequest);
            return new AsyncInvoker<ListAuditBackupRiskTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditBackupRiskTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询数据库列表[待下线]
        ///
        /// 查询数据库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListAuditDatabasesResponse> ListAuditDatabasesAsync(ListAuditDatabasesRequest listAuditDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditDatabasesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditDatabasesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditDatabasesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListAuditDatabasesResponse> ListAuditDatabasesAsyncInvoker(ListAuditDatabasesRequest listAuditDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditDatabasesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditDatabasesRequest);
            return new AsyncInvoker<ListAuditDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditDatabasesResponse>);
        }
        
        /// <summary>
        /// 查询数据库列表
        ///
        /// 查询数据库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditDatabasesNewResponse> ListAuditDatabasesNewAsync(ListAuditDatabasesNewRequest listAuditDatabasesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditDatabasesNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditDatabasesNewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditDatabasesNewResponse>(response);
        }

        public AsyncInvoker<ListAuditDatabasesNewResponse> ListAuditDatabasesNewAsyncInvoker(ListAuditDatabasesNewRequest listAuditDatabasesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditDatabasesNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditDatabasesNewRequest);
            return new AsyncInvoker<ListAuditDatabasesNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditDatabasesNewResponse>);
        }
        
        /// <summary>
        /// 查询实例创建任务信息[待下线]
        ///
        /// 查询实例创建任务信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListAuditInstanceJobsResponse> ListAuditInstanceJobsAsync(ListAuditInstanceJobsRequest listAuditInstanceJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditInstanceJobsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/jobs/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstanceJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditInstanceJobsResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListAuditInstanceJobsResponse> ListAuditInstanceJobsAsyncInvoker(ListAuditInstanceJobsRequest listAuditInstanceJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditInstanceJobsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/jobs/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstanceJobsRequest);
            return new AsyncInvoker<ListAuditInstanceJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditInstanceJobsResponse>);
        }
        
        /// <summary>
        /// 查询实例创建任务信息
        ///
        /// 查询实例创建任务信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditInstanceJobsNewResponse> ListAuditInstanceJobsNewAsync(ListAuditInstanceJobsNewRequest listAuditInstanceJobsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditInstanceJobsNewRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{resource_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstanceJobsNewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditInstanceJobsNewResponse>(response);
        }

        public AsyncInvoker<ListAuditInstanceJobsNewResponse> ListAuditInstanceJobsNewAsyncInvoker(ListAuditInstanceJobsNewRequest listAuditInstanceJobsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditInstanceJobsNewRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{resource_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstanceJobsNewRequest);
            return new AsyncInvoker<ListAuditInstanceJobsNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditInstanceJobsNewResponse>);
        }
        
        /// <summary>
        /// 查询审计实例列表[待下线]
        ///
        /// 查询审计实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListAuditInstancesResponse> ListAuditInstancesAsync(ListAuditInstancesRequest listAuditInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditInstancesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListAuditInstancesResponse> ListAuditInstancesAsyncInvoker(ListAuditInstancesRequest listAuditInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstancesRequest);
            return new AsyncInvoker<ListAuditInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditInstancesResponse>);
        }
        
        /// <summary>
        /// 查询审计实例列表
        ///
        /// 查询审计实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditInstancesNewResponse> ListAuditInstancesNewAsync(ListAuditInstancesNewRequest listAuditInstancesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstancesNewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditInstancesNewResponse>(response);
        }

        public AsyncInvoker<ListAuditInstancesNewResponse> ListAuditInstancesNewAsyncInvoker(ListAuditInstancesNewRequest listAuditInstancesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditInstancesNewRequest);
            return new AsyncInvoker<ListAuditInstancesNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditInstancesNewResponse>);
        }
        
        /// <summary>
        /// 备份或风险导出时，选择obs桶
        ///
        /// 备份或风险导出时，选择obs桶
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditObsBucketsResponse> ListAuditObsBucketsAsync(ListAuditObsBucketsRequest listAuditObsBucketsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/backup/obs-buckets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditObsBucketsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditObsBucketsResponse>(response);
        }

        public AsyncInvoker<ListAuditObsBucketsResponse> ListAuditObsBucketsAsyncInvoker(ListAuditObsBucketsRequest listAuditObsBucketsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/backup/obs-buckets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditObsBucketsRequest);
            return new AsyncInvoker<ListAuditObsBucketsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditObsBucketsResponse>);
        }
        
        /// <summary>
        /// 查询用户操作日志信息[待下线]
        ///
        /// 查询用户操作日志信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListAuditOperateLogsResponse> ListAuditOperateLogsAsync(ListAuditOperateLogsRequest listAuditOperateLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditOperateLogsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/operate-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditOperateLogsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAuditOperateLogsResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListAuditOperateLogsResponse> ListAuditOperateLogsAsyncInvoker(ListAuditOperateLogsRequest listAuditOperateLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditOperateLogsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/operate-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditOperateLogsRequest);
            return new AsyncInvoker<ListAuditOperateLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditOperateLogsResponse>);
        }
        
        /// <summary>
        /// 查询用户操作日志信息
        ///
        /// 查询用户操作日志信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditOperateLogsNewResponse> ListAuditOperateLogsNewAsync(ListAuditOperateLogsNewRequest listAuditOperateLogsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditOperateLogsNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/operation-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditOperateLogsNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAuditOperateLogsNewResponse>(response);
        }

        public AsyncInvoker<ListAuditOperateLogsNewResponse> ListAuditOperateLogsNewAsyncInvoker(ListAuditOperateLogsNewRequest listAuditOperateLogsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditOperateLogsNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/operation-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditOperateLogsNewRequest);
            return new AsyncInvoker<ListAuditOperateLogsNewResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditOperateLogsNewResponse>);
        }
        
        /// <summary>
        /// 获取报表模板
        ///
        /// 获取报表模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditReportTemplatesResponse> ListAuditReportTemplatesAsync(ListAuditReportTemplatesRequest listAuditReportTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditReportTemplatesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/reports/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditReportTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditReportTemplatesResponse>(response);
        }

        public AsyncInvoker<ListAuditReportTemplatesResponse> ListAuditReportTemplatesAsyncInvoker(ListAuditReportTemplatesRequest listAuditReportTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditReportTemplatesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/reports/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditReportTemplatesRequest);
            return new AsyncInvoker<ListAuditReportTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditReportTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询报表
        ///
        /// 查询报表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditReportsResponse> ListAuditReportsAsync(ListAuditReportsRequest listAuditReportsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditReportsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/reports/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditReportsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAuditReportsResponse>(response);
        }

        public AsyncInvoker<ListAuditReportsResponse> ListAuditReportsAsyncInvoker(ListAuditReportsRequest listAuditReportsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditReportsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/reports/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditReportsRequest);
            return new AsyncInvoker<ListAuditReportsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditReportsResponse>);
        }
        
        /// <summary>
        /// 查询风险规则策略[待下线]
        ///
        /// 查询风险规则策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListAuditRuleRisksResponse> ListAuditRuleRisksAsync(ListAuditRuleRisksRequest listAuditRuleRisksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditRuleRisksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/risk", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleRisksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditRuleRisksResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListAuditRuleRisksResponse> ListAuditRuleRisksAsyncInvoker(ListAuditRuleRisksRequest listAuditRuleRisksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditRuleRisksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/risk", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleRisksRequest);
            return new AsyncInvoker<ListAuditRuleRisksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditRuleRisksResponse>);
        }
        
        /// <summary>
        /// 查询风险规则策略
        ///
        /// 查询风险规则策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditRuleRisksNewResponse> ListAuditRuleRisksNewAsync(ListAuditRuleRisksNewRequest listAuditRuleRisksNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditRuleRisksNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/risk", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleRisksNewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditRuleRisksNewResponse>(response);
        }

        public AsyncInvoker<ListAuditRuleRisksNewResponse> ListAuditRuleRisksNewAsyncInvoker(ListAuditRuleRisksNewRequest listAuditRuleRisksNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditRuleRisksNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/risk", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleRisksNewRequest);
            return new AsyncInvoker<ListAuditRuleRisksNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditRuleRisksNewResponse>);
        }
        
        /// <summary>
        /// 查询审计范围策略列表[待下线]
        ///
        /// 查询审计范围策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListAuditRuleScopesResponse> ListAuditRuleScopesAsync(ListAuditRuleScopesRequest listAuditRuleScopesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditRuleScopesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/scopes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleScopesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditRuleScopesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListAuditRuleScopesResponse> ListAuditRuleScopesAsyncInvoker(ListAuditRuleScopesRequest listAuditRuleScopesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditRuleScopesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/scopes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleScopesRequest);
            return new AsyncInvoker<ListAuditRuleScopesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditRuleScopesResponse>);
        }
        
        /// <summary>
        /// 查询审计范围策略列表
        ///
        /// 查询审计范围策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditRuleScopesNewResponse> ListAuditRuleScopesNewAsync(ListAuditRuleScopesNewRequest listAuditRuleScopesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditRuleScopesNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/scopes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleScopesNewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditRuleScopesNewResponse>(response);
        }

        public AsyncInvoker<ListAuditRuleScopesNewResponse> ListAuditRuleScopesNewAsyncInvoker(ListAuditRuleScopesNewRequest listAuditRuleScopesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditRuleScopesNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/scopes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditRuleScopesNewRequest);
            return new AsyncInvoker<ListAuditRuleScopesNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditRuleScopesNewResponse>);
        }
        
        /// <summary>
        /// 查询隐私数据脱敏规则[待下线]
        ///
        /// 查询隐私数据脱敏规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListAuditSensitiveMasksResponse> ListAuditSensitiveMasksAsync(ListAuditSensitiveMasksRequest listAuditSensitiveMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditSensitiveMasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/sensitive/masks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditSensitiveMasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditSensitiveMasksResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListAuditSensitiveMasksResponse> ListAuditSensitiveMasksAsyncInvoker(ListAuditSensitiveMasksRequest listAuditSensitiveMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditSensitiveMasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/sensitive/masks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditSensitiveMasksRequest);
            return new AsyncInvoker<ListAuditSensitiveMasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditSensitiveMasksResponse>);
        }
        
        /// <summary>
        /// 查询隐私数据脱敏规则
        ///
        /// 查询隐私数据脱敏规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditSensitiveMasksNewResponse> ListAuditSensitiveMasksNewAsync(ListAuditSensitiveMasksNewRequest listAuditSensitiveMasksNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditSensitiveMasksNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditSensitiveMasksNewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditSensitiveMasksNewResponse>(response);
        }

        public AsyncInvoker<ListAuditSensitiveMasksNewResponse> ListAuditSensitiveMasksNewAsyncInvoker(ListAuditSensitiveMasksNewRequest listAuditSensitiveMasksNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditSensitiveMasksNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditSensitiveMasksNewRequest);
            return new AsyncInvoker<ListAuditSensitiveMasksNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditSensitiveMasksNewResponse>);
        }
        
        /// <summary>
        /// 查询审计SQL语句[待下线]
        ///
        /// 查询审计SQL语句
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListAuditSqlsResponse> ListAuditSqlsAsync(ListAuditSqlsRequest listAuditSqlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditSqlsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/sqls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditSqlsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAuditSqlsResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListAuditSqlsResponse> ListAuditSqlsAsyncInvoker(ListAuditSqlsRequest listAuditSqlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditSqlsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/sqls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditSqlsRequest);
            return new AsyncInvoker<ListAuditSqlsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditSqlsResponse>);
        }
        
        /// <summary>
        /// 查询审计SQL语句
        ///
        /// 查询审计SQL语句
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditSqlsNewResponse> ListAuditSqlsNewAsync(ListAuditSqlsNewRequest listAuditSqlsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditSqlsNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/sqls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditSqlsNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAuditSqlsNewResponse>(response);
        }

        public AsyncInvoker<ListAuditSqlsNewResponse> ListAuditSqlsNewAsyncInvoker(ListAuditSqlsNewRequest listAuditSqlsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditSqlsNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/sqls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAuditSqlsNewRequest);
            return new AsyncInvoker<ListAuditSqlsNewResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditSqlsNewResponse>);
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
        /// 查询趋势历史数据
        ///
        /// 查询趋势历史数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditTrendHistoryResponse> ListAuditTrendHistoryAsync(ListAuditTrendHistoryRequest listAuditTrendHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditTrendHistoryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/statistics/trend/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditTrendHistoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listAuditTrendHistoryResponse = JsonUtils.DeSerializeNull<ListAuditTrendHistoryResponse>(response);
            listAuditTrendHistoryResponse.Body = JsonUtils.DeSerializeList<TrendStatusResponse>(response);
            return listAuditTrendHistoryResponse;
        }

        public AsyncInvoker<ListAuditTrendHistoryResponse> ListAuditTrendHistoryAsyncInvoker(ListAuditTrendHistoryRequest listAuditTrendHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditTrendHistoryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/statistics/trend/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditTrendHistoryRequest);
            return new AsyncInvoker<ListAuditTrendHistoryResponse>(this, "GET", request, response =>
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
        public async Task<ListAvailabilityZoneInfosResponse> ListAvailabilityZoneInfosAsync(ListAvailabilityZoneInfosRequest listAvailabilityZoneInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dbss/audit/availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZoneInfosRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAvailabilityZoneInfosResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListAvailabilityZoneInfosResponse> ListAvailabilityZoneInfosAsyncInvoker(ListAvailabilityZoneInfosRequest listAvailabilityZoneInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dbss/audit/availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZoneInfosRequest);
            return new AsyncInvoker<ListAvailabilityZoneInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailabilityZoneInfosResponse>);
        }
        
        /// <summary>
        /// 查询可用区信息
        ///
        /// 查询可用区信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAvailabilityZoneInfosNewResponse> ListAvailabilityZoneInfosNewAsync(ListAvailabilityZoneInfosNewRequest listAvailabilityZoneInfosNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZoneInfosNewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAvailabilityZoneInfosNewResponse>(response);
        }

        public AsyncInvoker<ListAvailabilityZoneInfosNewResponse> ListAvailabilityZoneInfosNewAsyncInvoker(ListAvailabilityZoneInfosNewRequest listAvailabilityZoneInfosNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZoneInfosNewRequest);
            return new AsyncInvoker<ListAvailabilityZoneInfosNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailabilityZoneInfosNewResponse>);
        }
        
        /// <summary>
        /// 列举数据库加密实例
        ///
        /// 列举数据库加密实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDbEncryptInstancesResponse> ListDbEncryptInstancesAsync(ListDbEncryptInstancesRequest listDbEncryptInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/db-encrypt/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbEncryptInstancesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListDbEncryptInstancesResponse>(response);
        }

        public AsyncInvoker<ListDbEncryptInstancesResponse> ListDbEncryptInstancesAsyncInvoker(ListDbEncryptInstancesRequest listDbEncryptInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/db-encrypt/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbEncryptInstancesRequest);
            return new AsyncInvoker<ListDbEncryptInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListDbEncryptInstancesResponse>);
        }
        
        /// <summary>
        /// 查询ECS服务器规格信息[待下线]
        ///
        /// 查询ECS服务器规格信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListEcsSpecificationResponse> ListEcsSpecificationAsync(ListEcsSpecificationRequest listEcsSpecificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/specification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEcsSpecificationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEcsSpecificationResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListEcsSpecificationResponse> ListEcsSpecificationAsyncInvoker(ListEcsSpecificationRequest listEcsSpecificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/specification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEcsSpecificationRequest);
            return new AsyncInvoker<ListEcsSpecificationResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEcsSpecificationResponse>);
        }
        
        /// <summary>
        /// 查询ECS服务器规格信息
        ///
        /// 查询ECS服务器规格信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEcsSpecificationNewResponse> ListEcsSpecificationNewAsync(ListEcsSpecificationNewRequest listEcsSpecificationNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/specification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEcsSpecificationNewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEcsSpecificationNewResponse>(response);
        }

        public AsyncInvoker<ListEcsSpecificationNewResponse> ListEcsSpecificationNewAsyncInvoker(ListEcsSpecificationNewRequest listEcsSpecificationNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/specification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEcsSpecificationNewRequest);
            return new AsyncInvoker<ListEcsSpecificationNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEcsSpecificationNewResponse>);
        }
        
        /// <summary>
        /// 获取数据库运维集群实例
        ///
        /// 获取数据库运维集群实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/db-om/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListInstancesResponse>(response);
        }

        public AsyncInvoker<ListInstancesResponse> ListInstancesAsyncInvoker(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/db-om/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            return new AsyncInvoker<ListInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInstancesResponse>);
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
        /// 查询SQL注入规则策略[待下线]
        ///
        /// 查询SQL注入规则策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListSqlInjectionRulesResponse> ListSqlInjectionRulesAsync(ListSqlInjectionRulesRequest listSqlInjectionRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlInjectionRulesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/sql-injections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSqlInjectionRulesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListSqlInjectionRulesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListSqlInjectionRulesResponse> ListSqlInjectionRulesAsyncInvoker(ListSqlInjectionRulesRequest listSqlInjectionRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlInjectionRulesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/sql-injections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSqlInjectionRulesRequest);
            return new AsyncInvoker<ListSqlInjectionRulesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSqlInjectionRulesResponse>);
        }
        
        /// <summary>
        /// 重启审计实例[待下线]
        ///
        /// 重启审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<RebootAuditInstanceResponse> RebootAuditInstanceAsync(RebootAuditInstanceRequest rebootAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", rebootAuditInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RebootAuditInstanceResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<RebootAuditInstanceResponse> RebootAuditInstanceAsyncInvoker(RebootAuditInstanceRequest rebootAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", rebootAuditInstanceRequest);
            return new AsyncInvoker<RebootAuditInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RebootAuditInstanceResponse>);
        }
        
        /// <summary>
        /// 重启审计实例
        ///
        /// 重启审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RebootAuditInstanceNewResponse> RebootAuditInstanceNewAsync(RebootAuditInstanceNewRequest rebootAuditInstanceNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instance/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", rebootAuditInstanceNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RebootAuditInstanceNewResponse>(response);
        }

        public AsyncInvoker<RebootAuditInstanceNewResponse> RebootAuditInstanceNewAsyncInvoker(RebootAuditInstanceNewRequest rebootAuditInstanceNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instance/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", rebootAuditInstanceNewRequest);
            return new AsyncInvoker<RebootAuditInstanceNewResponse>(this, "POST", request, JsonUtils.DeSerialize<RebootAuditInstanceNewResponse>);
        }
        
        /// <summary>
        /// 重启数据库加密实例
        ///
        /// 重启数据库加密实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RebootDbEncryptInstanceResponse> RebootDbEncryptInstanceAsync(RebootDbEncryptInstanceRequest rebootDbEncryptInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rebootDbEncryptInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebootDbEncryptInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RebootDbEncryptInstanceResponse>(response);
        }

        public AsyncInvoker<RebootDbEncryptInstanceResponse> RebootDbEncryptInstanceAsyncInvoker(RebootDbEncryptInstanceRequest rebootDbEncryptInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rebootDbEncryptInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebootDbEncryptInstanceRequest);
            return new AsyncInvoker<RebootDbEncryptInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RebootDbEncryptInstanceResponse>);
        }
        
        /// <summary>
        /// 重启数据库运维实例
        ///
        /// 重启数据库运维实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RebootDbOmInstanceResponse> RebootDbOmInstanceAsync(RebootDbOmInstanceRequest rebootDbOmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rebootDbOmInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebootDbOmInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RebootDbOmInstanceResponse>(response);
        }

        public AsyncInvoker<RebootDbOmInstanceResponse> RebootDbOmInstanceAsyncInvoker(RebootDbOmInstanceRequest rebootDbOmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rebootDbOmInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebootDbOmInstanceRequest);
            return new AsyncInvoker<RebootDbOmInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RebootDbOmInstanceResponse>);
        }
        
        /// <summary>
        /// 重置数据库加密实例的密码
        ///
        /// 重置数据库加密实例的密码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetDbEncryptPasswordResponse> ResetDbEncryptPasswordAsync(ResetDbEncryptPasswordRequest resetDbEncryptPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetDbEncryptPasswordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/password/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetDbEncryptPasswordRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResetDbEncryptPasswordResponse>(response);
        }

        public AsyncInvoker<ResetDbEncryptPasswordResponse> ResetDbEncryptPasswordAsyncInvoker(ResetDbEncryptPasswordRequest resetDbEncryptPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetDbEncryptPasswordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/password/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetDbEncryptPasswordRequest);
            return new AsyncInvoker<ResetDbEncryptPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetDbEncryptPasswordResponse>);
        }
        
        /// <summary>
        /// 重置数据库运维实例的密码
        ///
        /// 重置数据库运维实例的密码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetDbOmPasswordResponse> ResetDbOmPasswordAsync(ResetDbOmPasswordRequest resetDbOmPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetDbOmPasswordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/password/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetDbOmPasswordRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResetDbOmPasswordResponse>(response);
        }

        public AsyncInvoker<ResetDbOmPasswordResponse> ResetDbOmPasswordAsyncInvoker(ResetDbOmPasswordRequest resetDbOmPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetDbOmPasswordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/password/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetDbOmPasswordRequest);
            return new AsyncInvoker<ResetDbOmPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetDbOmPasswordResponse>);
        }
        
        /// <summary>
        /// 恢复备份信息
        ///
        /// 恢复备份信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestoreAuditBackupResponse> RestoreAuditBackupAsync(RestoreAuditBackupRequest restoreAuditBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreAuditBackupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(restoreAuditBackupRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/{id}/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreAuditBackupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RestoreAuditBackupResponse>(response);
        }

        public AsyncInvoker<RestoreAuditBackupResponse> RestoreAuditBackupAsyncInvoker(RestoreAuditBackupRequest restoreAuditBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreAuditBackupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(restoreAuditBackupRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/{id}/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreAuditBackupRequest);
            return new AsyncInvoker<RestoreAuditBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreAuditBackupResponse>);
        }
        
        /// <summary>
        /// 重试备份任务
        ///
        /// 重试备份任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RetryAuditBackupTaskResponse> RetryAuditBackupTaskAsync(RetryAuditBackupTaskRequest retryAuditBackupTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryAuditBackupTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(retryAuditBackupTaskRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/{id}/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryAuditBackupTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RetryAuditBackupTaskResponse>(response);
        }

        public AsyncInvoker<RetryAuditBackupTaskResponse> RetryAuditBackupTaskAsyncInvoker(RetryAuditBackupTaskRequest retryAuditBackupTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryAuditBackupTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(retryAuditBackupTaskRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/{id}/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryAuditBackupTaskRequest);
            return new AsyncInvoker<RetryAuditBackupTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<RetryAuditBackupTaskResponse>);
        }
        
        /// <summary>
        /// 设置实例告警配置[待下线]
        ///
        /// 设置实例告警配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<SetAlarmTopicConfigInfoResponse> SetAlarmTopicConfigInfoAsync(SetAlarmTopicConfigInfoRequest setAlarmTopicConfigInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAlarmTopicConfigInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/alarm/topic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAlarmTopicConfigInfoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetAlarmTopicConfigInfoResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<SetAlarmTopicConfigInfoResponse> SetAlarmTopicConfigInfoAsyncInvoker(SetAlarmTopicConfigInfoRequest setAlarmTopicConfigInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAlarmTopicConfigInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/alarm/topic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAlarmTopicConfigInfoRequest);
            return new AsyncInvoker<SetAlarmTopicConfigInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<SetAlarmTopicConfigInfoResponse>);
        }
        
        /// <summary>
        /// 设置实例告警配置
        ///
        /// 设置实例告警配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetAlarmTopicConfigInfoNewResponse> SetAlarmTopicConfigInfoNewAsync(SetAlarmTopicConfigInfoNewRequest setAlarmTopicConfigInfoNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAlarmTopicConfigInfoNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/alarm/topic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAlarmTopicConfigInfoNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetAlarmTopicConfigInfoNewResponse>(response);
        }

        public AsyncInvoker<SetAlarmTopicConfigInfoNewResponse> SetAlarmTopicConfigInfoNewAsyncInvoker(SetAlarmTopicConfigInfoNewRequest setAlarmTopicConfigInfoNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAlarmTopicConfigInfoNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/alarm/topic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAlarmTopicConfigInfoNewRequest);
            return new AsyncInvoker<SetAlarmTopicConfigInfoNewResponse>(this, "POST", request, JsonUtils.DeSerialize<SetAlarmTopicConfigInfoNewResponse>);
        }
        
        /// <summary>
        /// 标记监控告警
        ///
        /// 标记监控告警
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetAuditAlarmLogStatusResponse> SetAuditAlarmLogStatusAsync(SetAuditAlarmLogStatusRequest setAuditAlarmLogStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditAlarmLogStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(setAuditAlarmLogStatusRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/alarm-log/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditAlarmLogStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SetAuditAlarmLogStatusResponse>(response);
        }

        public AsyncInvoker<SetAuditAlarmLogStatusResponse> SetAuditAlarmLogStatusAsyncInvoker(SetAuditAlarmLogStatusRequest setAuditAlarmLogStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditAlarmLogStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(setAuditAlarmLogStatusRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/alarm-log/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditAlarmLogStatusRequest);
            return new AsyncInvoker<SetAuditAlarmLogStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetAuditAlarmLogStatusResponse>);
        }
        
        /// <summary>
        /// 获取备份配置信息
        ///
        /// 设置备份配置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetAuditAutoBackupTemplateResponse> SetAuditAutoBackupTemplateAsync(SetAuditAutoBackupTemplateRequest setAuditAutoBackupTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditAutoBackupTemplateRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditAutoBackupTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SetAuditAutoBackupTemplateResponse>(response);
        }

        public AsyncInvoker<SetAuditAutoBackupTemplateResponse> SetAuditAutoBackupTemplateAsyncInvoker(SetAuditAutoBackupTemplateRequest setAuditAutoBackupTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditAutoBackupTemplateRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditAutoBackupTemplateRequest);
            return new AsyncInvoker<SetAuditAutoBackupTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<SetAuditAutoBackupTemplateResponse>);
        }
        
        /// <summary>
        /// 风险导出开关(按DomainId)
        ///
        /// 风险导出开关(按DomainId)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetAuditBackupRiskSwitchResponse> SetAuditBackupRiskSwitchAsync(SetAuditBackupRiskSwitchRequest setAuditBackupRiskSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditBackupRiskSwitchRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(setAuditBackupRiskSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/audit/{instance_id}/backup/risk/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditBackupRiskSwitchRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetAuditBackupRiskSwitchResponse>(response);
        }

        public AsyncInvoker<SetAuditBackupRiskSwitchResponse> SetAuditBackupRiskSwitchAsyncInvoker(SetAuditBackupRiskSwitchRequest setAuditBackupRiskSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditBackupRiskSwitchRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(setAuditBackupRiskSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/audit/{instance_id}/backup/risk/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditBackupRiskSwitchRequest);
            return new AsyncInvoker<SetAuditBackupRiskSwitchResponse>(this, "POST", request, JsonUtils.DeSerialize<SetAuditBackupRiskSwitchResponse>);
        }
        
        /// <summary>
        /// 开启/关闭备份
        ///
        /// 开启/关闭备份
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetAuditBackupSwitchResponse> SetAuditBackupSwitchAsync(SetAuditBackupSwitchRequest setAuditBackupSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditBackupSwitchRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(setAuditBackupSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/audit/{instance_id}/backup/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditBackupSwitchRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetAuditBackupSwitchResponse>(response);
        }

        public AsyncInvoker<SetAuditBackupSwitchResponse> SetAuditBackupSwitchAsyncInvoker(SetAuditBackupSwitchRequest setAuditBackupSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditBackupSwitchRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(setAuditBackupSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/audit/{instance_id}/backup/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditBackupSwitchRequest);
            return new AsyncInvoker<SetAuditBackupSwitchResponse>(this, "POST", request, JsonUtils.DeSerialize<SetAuditBackupSwitchResponse>);
        }
        
        /// <summary>
        /// 配置审计实例时区信息
        ///
        /// 配置审计实例时区信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetAuditInstanceTimeZoneResponse> SetAuditInstanceTimeZoneAsync(SetAuditInstanceTimeZoneRequest setAuditInstanceTimeZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditInstanceTimeZoneRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/timezone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditInstanceTimeZoneRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetAuditInstanceTimeZoneResponse>(response);
        }

        public AsyncInvoker<SetAuditInstanceTimeZoneResponse> SetAuditInstanceTimeZoneAsyncInvoker(SetAuditInstanceTimeZoneRequest setAuditInstanceTimeZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditInstanceTimeZoneRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/timezone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditInstanceTimeZoneRequest);
            return new AsyncInvoker<SetAuditInstanceTimeZoneResponse>(this, "POST", request, JsonUtils.DeSerialize<SetAuditInstanceTimeZoneResponse>);
        }
        
        /// <summary>
        /// 启用禁用策略
        ///
        /// 启用禁用策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetAuditScopeRuleSwitchResponse> SetAuditScopeRuleSwitchAsync(SetAuditScopeRuleSwitchRequest setAuditScopeRuleSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditScopeRuleSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/scopes/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditScopeRuleSwitchRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetAuditScopeRuleSwitchResponse>(response);
        }

        public AsyncInvoker<SetAuditScopeRuleSwitchResponse> SetAuditScopeRuleSwitchAsyncInvoker(SetAuditScopeRuleSwitchRequest setAuditScopeRuleSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditScopeRuleSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/scopes/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditScopeRuleSwitchRequest);
            return new AsyncInvoker<SetAuditScopeRuleSwitchResponse>(this, "POST", request, JsonUtils.DeSerialize<SetAuditScopeRuleSwitchResponse>);
        }
        
        /// <summary>
        /// 编辑风险操作策略
        ///
        /// 编辑风险操作策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetRiskOperationPolicyResponse> SetRiskOperationPolicyAsync(SetRiskOperationPolicyRequest setRiskOperationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setRiskOperationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(setRiskOperationPolicyRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/risk/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRiskOperationPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SetRiskOperationPolicyResponse>(response);
        }

        public AsyncInvoker<SetRiskOperationPolicyResponse> SetRiskOperationPolicyAsyncInvoker(SetRiskOperationPolicyRequest setRiskOperationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setRiskOperationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(setRiskOperationPolicyRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/risk/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRiskOperationPolicyRequest);
            return new AsyncInvoker<SetRiskOperationPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetRiskOperationPolicyResponse>);
        }
        
        /// <summary>
        /// 审计实例风险规则排序
        ///
        /// 审计实例风险规则排序
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetRiskRuleRankResponse> SetRiskRuleRankAsync(SetRiskRuleRankRequest setRiskRuleRankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setRiskRuleRankRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/risk/rank", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRiskRuleRankRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetRiskRuleRankResponse>(response);
        }

        public AsyncInvoker<SetRiskRuleRankResponse> SetRiskRuleRankAsyncInvoker(SetRiskRuleRankRequest setRiskRuleRankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setRiskRuleRankRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/risk/rank", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRiskRuleRankRequest);
            return new AsyncInvoker<SetRiskRuleRankResponse>(this, "POST", request, JsonUtils.DeSerialize<SetRiskRuleRankResponse>);
        }
        
        /// <summary>
        /// 启用禁用单条隐私数据脱敏规则
        ///
        /// 启用禁用隐私数据脱敏规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetSensitiveMaskRuleSwitchResponse> SetSensitiveMaskRuleSwitchAsync(SetSensitiveMaskRuleSwitchRequest setSensitiveMaskRuleSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSensitiveMaskRuleSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/sensitive/mask/rule/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSensitiveMaskRuleSwitchRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetSensitiveMaskRuleSwitchResponse>(response);
        }

        public AsyncInvoker<SetSensitiveMaskRuleSwitchResponse> SetSensitiveMaskRuleSwitchAsyncInvoker(SetSensitiveMaskRuleSwitchRequest setSensitiveMaskRuleSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSensitiveMaskRuleSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/sensitive/mask/rule/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSensitiveMaskRuleSwitchRequest);
            return new AsyncInvoker<SetSensitiveMaskRuleSwitchResponse>(this, "POST", request, JsonUtils.DeSerialize<SetSensitiveMaskRuleSwitchResponse>);
        }
        
        /// <summary>
        /// 开启关闭结果集存储
        ///
        /// 开启关闭结果集存储
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetSensitiveResultSwitchResponse> SetSensitiveResultSwitchAsync(SetSensitiveResultSwitchRequest setSensitiveResultSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSensitiveResultSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/result/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSensitiveResultSwitchRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetSensitiveResultSwitchResponse>(response);
        }

        public AsyncInvoker<SetSensitiveResultSwitchResponse> SetSensitiveResultSwitchAsyncInvoker(SetSensitiveResultSwitchRequest setSensitiveResultSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSensitiveResultSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/result/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSensitiveResultSwitchRequest);
            return new AsyncInvoker<SetSensitiveResultSwitchResponse>(this, "POST", request, JsonUtils.DeSerialize<SetSensitiveResultSwitchResponse>);
        }
        
        /// <summary>
        /// 开启关闭隐私数据脱敏功能
        ///
        /// 开启关闭隐私数据脱敏
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetSensitiveSwitchResponse> SetSensitiveSwitchAsync(SetSensitiveSwitchRequest setSensitiveSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSensitiveSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSensitiveSwitchRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetSensitiveSwitchResponse>(response);
        }

        public AsyncInvoker<SetSensitiveSwitchResponse> SetSensitiveSwitchAsyncInvoker(SetSensitiveSwitchRequest setSensitiveSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSensitiveSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSensitiveSwitchRequest);
            return new AsyncInvoker<SetSensitiveSwitchResponse>(this, "POST", request, JsonUtils.DeSerialize<SetSensitiveSwitchResponse>);
        }
        
        /// <summary>
        /// 获取单个风险导出配置
        ///
        /// 获取单个风险导出配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAuditBackRiskTemplateResponse> ShowAuditBackRiskTemplateAsync(ShowAuditBackRiskTemplateRequest showAuditBackRiskTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditBackRiskTemplateRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditBackRiskTemplateRequest.DbId, out var valueOfDbId)) urlParam.Add("db_id", valueOfDbId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/risk/template/{db_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditBackRiskTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditBackRiskTemplateResponse>(response);
        }

        public AsyncInvoker<ShowAuditBackRiskTemplateResponse> ShowAuditBackRiskTemplateAsyncInvoker(ShowAuditBackRiskTemplateRequest showAuditBackRiskTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditBackRiskTemplateRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditBackRiskTemplateRequest.DbId, out var valueOfDbId)) urlParam.Add("db_id", valueOfDbId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/risk/template/{db_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditBackRiskTemplateRequest);
            return new AsyncInvoker<ShowAuditBackRiskTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditBackRiskTemplateResponse>);
        }
        
        /// <summary>
        /// 获取备份状态
        ///
        /// 获取备份状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAuditBackupStatusResponse> ShowAuditBackupStatusAsync(ShowAuditBackupStatusRequest showAuditBackupStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditBackupStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditBackupStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditBackupStatusResponse>(response);
        }

        public AsyncInvoker<ShowAuditBackupStatusResponse> ShowAuditBackupStatusAsyncInvoker(ShowAuditBackupStatusRequest showAuditBackupStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditBackupStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditBackupStatusRequest);
            return new AsyncInvoker<ShowAuditBackupStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditBackupStatusResponse>);
        }
        
        /// <summary>
        /// 查询账户配额信息[待下线]
        ///
        /// 查询账户配额信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ShowAuditQuotaResponse> ShowAuditQuotaAsync(ShowAuditQuotaRequest showAuditQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditQuotaResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ShowAuditQuotaResponse> ShowAuditQuotaAsyncInvoker(ShowAuditQuotaRequest showAuditQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditQuotaRequest);
            return new AsyncInvoker<ShowAuditQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditQuotaResponse>);
        }
        
        /// <summary>
        /// 查询账户配额信息
        ///
        /// 查询账户配额信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAuditQuotaNewResponse> ShowAuditQuotaNewAsync(ShowAuditQuotaNewRequest showAuditQuotaNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditQuotaNewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditQuotaNewResponse>(response);
        }

        public AsyncInvoker<ShowAuditQuotaNewResponse> ShowAuditQuotaNewAsyncInvoker(ShowAuditQuotaNewRequest showAuditQuotaNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditQuotaNewRequest);
            return new AsyncInvoker<ShowAuditQuotaNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditQuotaNewResponse>);
        }
        
        /// <summary>
        /// 查询指定风险规则策略[待下线]
        ///
        /// 查询指定风险规则策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ShowAuditRuleRiskResponse> ShowAuditRuleRiskAsync(ShowAuditRuleRiskRequest showAuditRuleRiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditRuleRiskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditRuleRiskRequest.RiskId, out var valueOfRiskId)) urlParam.Add("risk_id", valueOfRiskId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/risk/{risk_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditRuleRiskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditRuleRiskResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ShowAuditRuleRiskResponse> ShowAuditRuleRiskAsyncInvoker(ShowAuditRuleRiskRequest showAuditRuleRiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditRuleRiskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditRuleRiskRequest.RiskId, out var valueOfRiskId)) urlParam.Add("risk_id", valueOfRiskId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/dbss/audit/rule/risk/{risk_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditRuleRiskRequest);
            return new AsyncInvoker<ShowAuditRuleRiskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditRuleRiskResponse>);
        }
        
        /// <summary>
        /// 查询指定风险规则策略
        ///
        /// 查询指定风险规则策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAuditRuleRiskNewResponse> ShowAuditRuleRiskNewAsync(ShowAuditRuleRiskNewRequest showAuditRuleRiskNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditRuleRiskNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditRuleRiskNewRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/risk/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditRuleRiskNewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditRuleRiskNewResponse>(response);
        }

        public AsyncInvoker<ShowAuditRuleRiskNewResponse> ShowAuditRuleRiskNewAsyncInvoker(ShowAuditRuleRiskNewRequest showAuditRuleRiskNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditRuleRiskNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditRuleRiskNewRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/risk/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditRuleRiskNewRequest);
            return new AsyncInvoker<ShowAuditRuleRiskNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditRuleRiskNewResponse>);
        }
        
        /// <summary>
        /// 获取租户下所有实例的风险汇总信息
        ///
        /// 获取租户下所有实例的风险汇总信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAuditStatisticsResponse> ShowAuditStatisticsAsync(ShowAuditStatisticsRequest showAuditStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/summary/risk/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditStatisticsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditStatisticsResponse>(response);
        }

        public AsyncInvoker<ShowAuditStatisticsResponse> ShowAuditStatisticsAsyncInvoker(ShowAuditStatisticsRequest showAuditStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/summary/risk/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditStatisticsRequest);
            return new AsyncInvoker<ShowAuditStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取租户审计信息汇总任务状态
        ///
        /// 获取租户审计信息汇总任务状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAuditTaskStatusResponse> ShowAuditTaskStatusAsync(ShowAuditTaskStatusRequest showAuditTaskStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditTaskStatusRequest.BusiType, out var valueOfBusiType)) urlParam.Add("busi_type", valueOfBusiType);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/summary/{busi_type}/task-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditTaskStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditTaskStatusResponse>(response);
        }

        public AsyncInvoker<ShowAuditTaskStatusResponse> ShowAuditTaskStatusAsyncInvoker(ShowAuditTaskStatusRequest showAuditTaskStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditTaskStatusRequest.BusiType, out var valueOfBusiType)) urlParam.Add("busi_type", valueOfBusiType);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/summary/{busi_type}/task-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditTaskStatusRequest);
            return new AsyncInvoker<ShowAuditTaskStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditTaskStatusResponse>);
        }
        
        /// <summary>
        /// 获取报表的计划任务配置信息（topic方式）
        ///
        /// 获取报表的计划任务配置信息（topic方式）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAuditTopicReportSchedulerConfigResponse> ShowAuditTopicReportSchedulerConfigAsync(ShowAuditTopicReportSchedulerConfigRequest showAuditTopicReportSchedulerConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditTopicReportSchedulerConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditTopicReportSchedulerConfigRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/reports/tasks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditTopicReportSchedulerConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditTopicReportSchedulerConfigResponse>(response);
        }

        public AsyncInvoker<ShowAuditTopicReportSchedulerConfigResponse> ShowAuditTopicReportSchedulerConfigAsyncInvoker(ShowAuditTopicReportSchedulerConfigRequest showAuditTopicReportSchedulerConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditTopicReportSchedulerConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditTopicReportSchedulerConfigRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/reports/tasks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditTopicReportSchedulerConfigRequest);
            return new AsyncInvoker<ShowAuditTopicReportSchedulerConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditTopicReportSchedulerConfigResponse>);
        }
        
        /// <summary>
        /// 查询租户的实例是否可升级
        ///
        /// 查询租户的实例是否可升级
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAuditUpgradeStatusResponse> ShowAuditUpgradeStatusAsync(ShowAuditUpgradeStatusRequest showAuditUpgradeStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/upgrade/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditUpgradeStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditUpgradeStatusResponse>(response);
        }

        public AsyncInvoker<ShowAuditUpgradeStatusResponse> ShowAuditUpgradeStatusAsyncInvoker(ShowAuditUpgradeStatusRequest showAuditUpgradeStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/upgrade/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditUpgradeStatusRequest);
            return new AsyncInvoker<ShowAuditUpgradeStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditUpgradeStatusResponse>);
        }
        
        /// <summary>
        /// 获取风险导出桶名和路径
        ///
        /// 获取风险导出桶名和路径
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBackupRiskBucketPathResponse> ShowBackupRiskBucketPathAsync(ShowBackupRiskBucketPathRequest showBackupRiskBucketPathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBackupRiskBucketPathRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/risk/bucket-path", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupRiskBucketPathRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBackupRiskBucketPathResponse>(response);
        }

        public AsyncInvoker<ShowBackupRiskBucketPathResponse> ShowBackupRiskBucketPathAsyncInvoker(ShowBackupRiskBucketPathRequest showBackupRiskBucketPathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBackupRiskBucketPathRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/backup/risk/bucket-path", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupRiskBucketPathRequest);
            return new AsyncInvoker<ShowBackupRiskBucketPathResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackupRiskBucketPathResponse>);
        }
        
        /// <summary>
        /// 获取实例监控数据
        ///
        /// 获取实例监控数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceMonitorInfoResponse> ShowInstanceMonitorInfoAsync(ShowInstanceMonitorInfoRequest showInstanceMonitorInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceMonitorInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/system/monitorinfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceMonitorInfoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowInstanceMonitorInfoResponse>(response);
        }

        public AsyncInvoker<ShowInstanceMonitorInfoResponse> ShowInstanceMonitorInfoAsyncInvoker(ShowInstanceMonitorInfoRequest showInstanceMonitorInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceMonitorInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/system/monitorinfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceMonitorInfoRequest);
            return new AsyncInvoker<ShowInstanceMonitorInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowInstanceMonitorInfoResponse>);
        }
        
        /// <summary>
        /// 查询加密/运维增强配额
        ///
        /// 查询加密/运维增强配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceQuotaResponse> ShowInstanceQuotaAsync(ShowInstanceQuotaRequest showInstanceQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instance/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceQuotaResponse>(response);
        }

        public AsyncInvoker<ShowInstanceQuotaResponse> ShowInstanceQuotaAsyncInvoker(ShowInstanceQuotaRequest showInstanceQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instance/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceQuotaRequest);
            return new AsyncInvoker<ShowInstanceQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceQuotaResponse>);
        }
        
        /// <summary>
        /// 获取隐私数据脱敏开关
        ///
        /// 获取隐私数据脱敏开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSensitiveMaskSwitchResponse> ShowSensitiveMaskSwitchAsync(ShowSensitiveMaskSwitchRequest showSensitiveMaskSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSensitiveMaskSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSensitiveMaskSwitchRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSensitiveMaskSwitchResponse>(response);
        }

        public AsyncInvoker<ShowSensitiveMaskSwitchResponse> ShowSensitiveMaskSwitchAsyncInvoker(ShowSensitiveMaskSwitchRequest showSensitiveMaskSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSensitiveMaskSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSensitiveMaskSwitchRequest);
            return new AsyncInvoker<ShowSensitiveMaskSwitchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSensitiveMaskSwitchResponse>);
        }
        
        /// <summary>
        /// 获取隐私数据结果集开关
        ///
        /// 获取隐私数据结果集开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSensitiveResultSwitchResponse> ShowSensitiveResultSwitchAsync(ShowSensitiveResultSwitchRequest showSensitiveResultSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSensitiveResultSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/result/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSensitiveResultSwitchRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSensitiveResultSwitchResponse>(response);
        }

        public AsyncInvoker<ShowSensitiveResultSwitchResponse> ShowSensitiveResultSwitchAsyncInvoker(ShowSensitiveResultSwitchRequest showSensitiveResultSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSensitiveResultSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/result/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSensitiveResultSwitchRequest);
            return new AsyncInvoker<ShowSensitiveResultSwitchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSensitiveResultSwitchResponse>);
        }
        
        /// <summary>
        /// 获取管理侧版本信息
        ///
        /// 获取管理侧版本信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowServerVersionResponse> ShowServerVersionAsync(ShowServerVersionRequest showServerVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowServerVersionResponse>(response);
        }

        public AsyncInvoker<ShowServerVersionResponse> ShowServerVersionAsyncInvoker(ShowServerVersionRequest showServerVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerVersionRequest);
            return new AsyncInvoker<ShowServerVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerVersionResponse>);
        }
        
        /// <summary>
        /// 获取指定SQL语句的详细信息
        ///
        /// 获取指定SQL语句的详细信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSqlDetailResponse> ShowSqlDetailAsync(ShowSqlDetailRequest showSqlDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSqlDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showSqlDetailRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/sqls/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSqlDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSqlDetailResponse>(response);
        }

        public AsyncInvoker<ShowSqlDetailResponse> ShowSqlDetailAsyncInvoker(ShowSqlDetailRequest showSqlDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSqlDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showSqlDetailRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/sqls/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSqlDetailRequest);
            return new AsyncInvoker<ShowSqlDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSqlDetailResponse>);
        }
        
        /// <summary>
        /// 开启审计实例[待下线]
        ///
        /// 开启审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<StartAuditInstanceResponse> StartAuditInstanceAsync(StartAuditInstanceRequest startAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startAuditInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartAuditInstanceResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<StartAuditInstanceResponse> StartAuditInstanceAsyncInvoker(StartAuditInstanceRequest startAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startAuditInstanceRequest);
            return new AsyncInvoker<StartAuditInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StartAuditInstanceResponse>);
        }
        
        /// <summary>
        /// 开启审计实例
        ///
        /// 开启审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartAuditInstanceNewResponse> StartAuditInstanceNewAsync(StartAuditInstanceNewRequest startAuditInstanceNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instance/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startAuditInstanceNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartAuditInstanceNewResponse>(response);
        }

        public AsyncInvoker<StartAuditInstanceNewResponse> StartAuditInstanceNewAsyncInvoker(StartAuditInstanceNewRequest startAuditInstanceNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instance/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startAuditInstanceNewRequest);
            return new AsyncInvoker<StartAuditInstanceNewResponse>(this, "POST", request, JsonUtils.DeSerialize<StartAuditInstanceNewResponse>);
        }
        
        /// <summary>
        /// 启动数据库加密实例
        ///
        /// 启动数据库加密实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartDbEncryptInstanceResponse> StartDbEncryptInstanceAsync(StartDbEncryptInstanceRequest startDbEncryptInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startDbEncryptInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDbEncryptInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartDbEncryptInstanceResponse>(response);
        }

        public AsyncInvoker<StartDbEncryptInstanceResponse> StartDbEncryptInstanceAsyncInvoker(StartDbEncryptInstanceRequest startDbEncryptInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startDbEncryptInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDbEncryptInstanceRequest);
            return new AsyncInvoker<StartDbEncryptInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StartDbEncryptInstanceResponse>);
        }
        
        /// <summary>
        /// 启动数据库运维实例
        ///
        /// 启动数据库运维实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartDbOmInstanceResponse> StartDbOmInstanceAsync(StartDbOmInstanceRequest startDbOmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startDbOmInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDbOmInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartDbOmInstanceResponse>(response);
        }

        public AsyncInvoker<StartDbOmInstanceResponse> StartDbOmInstanceAsyncInvoker(StartDbOmInstanceRequest startDbOmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startDbOmInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDbOmInstanceRequest);
            return new AsyncInvoker<StartDbOmInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StartDbOmInstanceResponse>);
        }
        
        /// <summary>
        /// 关闭审计实例[待下线]
        ///
        /// 关闭审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<StopAuditInstanceResponse> StopAuditInstanceAsync(StopAuditInstanceRequest stopAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopAuditInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopAuditInstanceResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<StopAuditInstanceResponse> StopAuditInstanceAsyncInvoker(StopAuditInstanceRequest stopAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instance/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopAuditInstanceRequest);
            return new AsyncInvoker<StopAuditInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StopAuditInstanceResponse>);
        }
        
        /// <summary>
        /// 关闭审计实例
        ///
        /// 关闭审计实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopAuditInstanceNewResponse> StopAuditInstanceNewAsync(StopAuditInstanceNewRequest stopAuditInstanceNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instance/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopAuditInstanceNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopAuditInstanceNewResponse>(response);
        }

        public AsyncInvoker<StopAuditInstanceNewResponse> StopAuditInstanceNewAsyncInvoker(StopAuditInstanceNewRequest stopAuditInstanceNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instance/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopAuditInstanceNewRequest);
            return new AsyncInvoker<StopAuditInstanceNewResponse>(this, "POST", request, JsonUtils.DeSerialize<StopAuditInstanceNewResponse>);
        }
        
        /// <summary>
        /// 停止数据库加密实例
        ///
        /// 停止数据库加密实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopDbEncryptInstanceResponse> StopDbEncryptInstanceAsync(StopDbEncryptInstanceRequest stopDbEncryptInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopDbEncryptInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopDbEncryptInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopDbEncryptInstanceResponse>(response);
        }

        public AsyncInvoker<StopDbEncryptInstanceResponse> StopDbEncryptInstanceAsyncInvoker(StopDbEncryptInstanceRequest stopDbEncryptInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopDbEncryptInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopDbEncryptInstanceRequest);
            return new AsyncInvoker<StopDbEncryptInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StopDbEncryptInstanceResponse>);
        }
        
        /// <summary>
        /// 停止数据库运维实例
        ///
        /// 停止数据库运维实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopDbOmInstanceResponse> StopDbOmInstanceAsync(StopDbOmInstanceRequest stopDbOmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopDbOmInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopDbOmInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopDbOmInstanceResponse>(response);
        }

        public AsyncInvoker<StopDbOmInstanceResponse> StopDbOmInstanceAsyncInvoker(StopDbOmInstanceRequest stopDbOmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopDbOmInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopDbOmInstanceRequest);
            return new AsyncInvoker<StopDbOmInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StopDbOmInstanceResponse>);
        }
        
        /// <summary>
        /// 开启关闭Agent[待下线]
        ///
        /// 用于开启和关闭Agent审计的功能，当开启后，开始抓取用户的访问信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<SwitchAgentResponse> SwitchAgentAsync(SwitchAgentRequest switchAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/agent/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAgentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SwitchAgentResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<SwitchAgentResponse> SwitchAgentAsyncInvoker(SwitchAgentRequest switchAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/agent/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAgentRequest);
            return new AsyncInvoker<SwitchAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchAgentResponse>);
        }
        
        /// <summary>
        /// 开启关闭数据库[待下线]
        ///
        /// 开启关闭数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<SwitchAuditDatabaseResponse> SwitchAuditDatabaseAsync(SwitchAuditDatabaseRequest switchAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchAuditDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAuditDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SwitchAuditDatabaseResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<SwitchAuditDatabaseResponse> SwitchAuditDatabaseAsyncInvoker(SwitchAuditDatabaseRequest switchAuditDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchAuditDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/audit/databases/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAuditDatabaseRequest);
            return new AsyncInvoker<SwitchAuditDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchAuditDatabaseResponse>);
        }
        
        /// <summary>
        /// 开启关闭数据库
        ///
        /// 开启关闭数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchAuditDatabaseNewResponse> SwitchAuditDatabaseNewAsync(SwitchAuditDatabaseNewRequest switchAuditDatabaseNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchAuditDatabaseNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/databases/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAuditDatabaseNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SwitchAuditDatabaseNewResponse>(response);
        }

        public AsyncInvoker<SwitchAuditDatabaseNewResponse> SwitchAuditDatabaseNewAsyncInvoker(SwitchAuditDatabaseNewRequest switchAuditDatabaseNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchAuditDatabaseNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/databases/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAuditDatabaseNewRequest);
            return new AsyncInvoker<SwitchAuditDatabaseNewResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchAuditDatabaseNewResponse>);
        }
        
        /// <summary>
        /// 开启关闭风险规则[待下线]
        ///
        /// 开启关闭风险规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<SwitchRiskRuleResponse> SwitchRiskRuleAsync(SwitchRiskRuleRequest switchRiskRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchRiskRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/rule/risk/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchRiskRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SwitchRiskRuleResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<SwitchRiskRuleResponse> SwitchRiskRuleAsyncInvoker(SwitchRiskRuleRequest switchRiskRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchRiskRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{instance_id}/audit/rule/risk/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchRiskRuleRequest);
            return new AsyncInvoker<SwitchRiskRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchRiskRuleResponse>);
        }
        
        /// <summary>
        /// 开启/关闭风险规则
        ///
        /// 开启/关闭风险规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchRiskRuleNewResponse> SwitchRiskRuleNewAsync(SwitchRiskRuleNewRequest switchRiskRuleNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchRiskRuleNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/risk/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchRiskRuleNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SwitchRiskRuleNewResponse>(response);
        }

        public AsyncInvoker<SwitchRiskRuleNewResponse> SwitchRiskRuleNewAsyncInvoker(SwitchRiskRuleNewRequest switchRiskRuleNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchRiskRuleNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/risk/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchRiskRuleNewRequest);
            return new AsyncInvoker<SwitchRiskRuleNewResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchRiskRuleNewResponse>);
        }
        
        /// <summary>
        /// 解绑数据库加密实例的eip
        ///
        /// 解绑数据库加密实例的eip
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UnbindDbEncryptEipResponse> UnbindDbEncryptEipAsync(UnbindDbEncryptEipRequest unbindDbEncryptEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unbindDbEncryptEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/eip/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unbindDbEncryptEipRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UnbindDbEncryptEipResponse>(response);
        }

        public AsyncInvoker<UnbindDbEncryptEipResponse> UnbindDbEncryptEipAsyncInvoker(UnbindDbEncryptEipRequest unbindDbEncryptEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unbindDbEncryptEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/eip/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unbindDbEncryptEipRequest);
            return new AsyncInvoker<UnbindDbEncryptEipResponse>(this, "POST", request, JsonUtils.DeSerialize<UnbindDbEncryptEipResponse>);
        }
        
        /// <summary>
        /// 解绑数据库运维实例的eip
        ///
        /// 解绑数据库运维实例的eip
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UnbindDbOmEipResponse> UnbindDbOmEipAsync(UnbindDbOmEipRequest unbindDbOmEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unbindDbOmEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/eip/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unbindDbOmEipRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UnbindDbOmEipResponse>(response);
        }

        public AsyncInvoker<UnbindDbOmEipResponse> UnbindDbOmEipAsyncInvoker(UnbindDbOmEipRequest unbindDbOmEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unbindDbOmEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/eip/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unbindDbOmEipRequest);
            return new AsyncInvoker<UnbindDbOmEipResponse>(this, "POST", request, JsonUtils.DeSerialize<UnbindDbOmEipResponse>);
        }
        
        /// <summary>
        /// 更新审计实例信息[待下线]
        ///
        /// 更新审计实例信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<UpdateAuditInstanceResponse> UpdateAuditInstanceAsync(UpdateAuditInstanceRequest updateAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditInstanceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAuditInstanceResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<UpdateAuditInstanceResponse> UpdateAuditInstanceAsyncInvoker(UpdateAuditInstanceRequest updateAuditInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditInstanceRequest);
            return new AsyncInvoker<UpdateAuditInstanceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAuditInstanceResponse>);
        }
        
        /// <summary>
        /// 更新审计实例信息
        ///
        /// 更新审计实例信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAuditInstanceNewResponse> UpdateAuditInstanceNewAsync(UpdateAuditInstanceNewRequest updateAuditInstanceNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditInstanceNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instance/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditInstanceNewRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAuditInstanceNewResponse>(response);
        }

        public AsyncInvoker<UpdateAuditInstanceNewResponse> UpdateAuditInstanceNewAsyncInvoker(UpdateAuditInstanceNewRequest updateAuditInstanceNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditInstanceNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/instance/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditInstanceNewRequest);
            return new AsyncInvoker<UpdateAuditInstanceNewResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAuditInstanceNewResponse>);
        }
        
        /// <summary>
        /// 修改风险导出桶名和路径(按DomainId)
        ///
        /// 修改风险导出桶名和路径(按DomainId)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAuditRiskBucketPathResponse> UpdateAuditRiskBucketPathAsync(UpdateAuditRiskBucketPathRequest updateAuditRiskBucketPathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditRiskBucketPathRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(updateAuditRiskBucketPathRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/audit/{instance_id}/backup/risk/global/bucket-path", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditRiskBucketPathRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateAuditRiskBucketPathResponse>(response);
        }

        public AsyncInvoker<UpdateAuditRiskBucketPathResponse> UpdateAuditRiskBucketPathAsyncInvoker(UpdateAuditRiskBucketPathRequest updateAuditRiskBucketPathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditRiskBucketPathRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(updateAuditRiskBucketPathRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/audit/{instance_id}/backup/risk/global/bucket-path", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditRiskBucketPathRequest);
            return new AsyncInvoker<UpdateAuditRiskBucketPathResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAuditRiskBucketPathResponse>);
        }
        
        /// <summary>
        /// 编辑审计范围规则
        ///
        /// 编辑审计范围规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAuditScopeRuleResponse> UpdateAuditScopeRuleAsync(UpdateAuditScopeRuleRequest updateAuditScopeRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditScopeRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateAuditScopeRuleRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/rule/scopes/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditScopeRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateAuditScopeRuleResponse>(response);
        }

        public AsyncInvoker<UpdateAuditScopeRuleResponse> UpdateAuditScopeRuleAsyncInvoker(UpdateAuditScopeRuleRequest updateAuditScopeRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditScopeRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateAuditScopeRuleRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/rule/scopes/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditScopeRuleRequest);
            return new AsyncInvoker<UpdateAuditScopeRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAuditScopeRuleResponse>);
        }
        
        /// <summary>
        /// 修改实例安全组[待下线]
        ///
        /// 修改实例安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<UpdateAuditSecurityGroupResponse> UpdateAuditSecurityGroupAsync(UpdateAuditSecurityGroupRequest updateAuditSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditSecurityGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateAuditSecurityGroupResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<UpdateAuditSecurityGroupResponse> UpdateAuditSecurityGroupAsyncInvoker(UpdateAuditSecurityGroupRequest updateAuditSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dbss/audit/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditSecurityGroupRequest);
            return new AsyncInvoker<UpdateAuditSecurityGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAuditSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 修改实例安全组
        ///
        /// 修改实例安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAuditSecurityGroupNewResponse> UpdateAuditSecurityGroupNewAsync(UpdateAuditSecurityGroupNewRequest updateAuditSecurityGroupNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditSecurityGroupNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateAuditSecurityGroupNewResponse>(response);
        }

        public AsyncInvoker<UpdateAuditSecurityGroupNewResponse> UpdateAuditSecurityGroupNewAsyncInvoker(UpdateAuditSecurityGroupNewRequest updateAuditSecurityGroupNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditSecurityGroupNewRequest);
            return new AsyncInvoker<UpdateAuditSecurityGroupNewResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAuditSecurityGroupNewResponse>);
        }
        
        /// <summary>
        /// 更新租户审计信息汇总任务状态
        ///
        /// 更新租户审计信息汇总任务状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAuditTaskStatusResponse> UpdateAuditTaskStatusAsync(UpdateAuditTaskStatusRequest updateAuditTaskStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditTaskStatusRequest.BusiType, out var valueOfBusiType)) urlParam.Add("busi_type", valueOfBusiType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/summary/{busi_type}/task-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditTaskStatusRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateAuditTaskStatusResponse>(response);
        }

        public AsyncInvoker<UpdateAuditTaskStatusResponse> UpdateAuditTaskStatusAsyncInvoker(UpdateAuditTaskStatusRequest updateAuditTaskStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditTaskStatusRequest.BusiType, out var valueOfBusiType)) urlParam.Add("busi_type", valueOfBusiType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/summary/{busi_type}/task-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditTaskStatusRequest);
            return new AsyncInvoker<UpdateAuditTaskStatusResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateAuditTaskStatusResponse>);
        }
        
        /// <summary>
        /// 更改报表的计划任务配置信息（topic方式）
        ///
        /// 更改报表的计划任务配置信息（topic方式）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAuditTopicReportSchedulerConfigResponse> UpdateAuditTopicReportSchedulerConfigAsync(UpdateAuditTopicReportSchedulerConfigRequest updateAuditTopicReportSchedulerConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditTopicReportSchedulerConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/reports/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditTopicReportSchedulerConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateAuditTopicReportSchedulerConfigResponse>(response);
        }

        public AsyncInvoker<UpdateAuditTopicReportSchedulerConfigResponse> UpdateAuditTopicReportSchedulerConfigAsyncInvoker(UpdateAuditTopicReportSchedulerConfigRequest updateAuditTopicReportSchedulerConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditTopicReportSchedulerConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/reports/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditTopicReportSchedulerConfigRequest);
            return new AsyncInvoker<UpdateAuditTopicReportSchedulerConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAuditTopicReportSchedulerConfigResponse>);
        }
        
        /// <summary>
        /// 更改数据库加密实例的名称
        ///
        /// 更改数据库加密实例的名称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDbEncryptInstanceNameResponse> UpdateDbEncryptInstanceNameAsync(UpdateDbEncryptInstanceNameRequest updateDbEncryptInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDbEncryptInstanceNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDbEncryptInstanceNameRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDbEncryptInstanceNameResponse>(response);
        }

        public AsyncInvoker<UpdateDbEncryptInstanceNameResponse> UpdateDbEncryptInstanceNameAsyncInvoker(UpdateDbEncryptInstanceNameRequest updateDbEncryptInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDbEncryptInstanceNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-encrypt/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDbEncryptInstanceNameRequest);
            return new AsyncInvoker<UpdateDbEncryptInstanceNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDbEncryptInstanceNameResponse>);
        }
        
        /// <summary>
        /// 更改数据库运维实例的名称
        ///
        /// 更改数据库运维实例的名称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDbOmInstanceNameResponse> UpdateDbOmInstanceNameAsync(UpdateDbOmInstanceNameRequest updateDbOmInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDbOmInstanceNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDbOmInstanceNameRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDbOmInstanceNameResponse>(response);
        }

        public AsyncInvoker<UpdateDbOmInstanceNameResponse> UpdateDbOmInstanceNameAsyncInvoker(UpdateDbOmInstanceNameRequest updateDbOmInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDbOmInstanceNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/db-om/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDbOmInstanceNameRequest);
            return new AsyncInvoker<UpdateDbOmInstanceNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDbOmInstanceNameResponse>);
        }
        
        /// <summary>
        /// 修改编辑隐私数据脱敏规则
        ///
        /// 修改编辑隐私数据脱敏规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSensitiveMaskRuleResponse> UpdateSensitiveMaskRuleAsync(UpdateSensitiveMaskRuleRequest updateSensitiveMaskRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSensitiveMaskRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateSensitiveMaskRuleRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/rule/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSensitiveMaskRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateSensitiveMaskRuleResponse>(response);
        }

        public AsyncInvoker<UpdateSensitiveMaskRuleResponse> UpdateSensitiveMaskRuleAsyncInvoker(UpdateSensitiveMaskRuleRequest updateSensitiveMaskRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSensitiveMaskRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateSensitiveMaskRuleRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/sensitive/mask/rule/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSensitiveMaskRuleRequest);
            return new AsyncInvoker<UpdateSensitiveMaskRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateSensitiveMaskRuleResponse>);
        }
        
        /// <summary>
        /// 往OBS导出审计数据库配置
        ///
        /// 往OBS导出审计数据库配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UploadAuditDbConfigResponse> UploadAuditDbConfigAsync(UploadAuditDbConfigRequest uploadAuditDbConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/databases/configs/obs-upload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", uploadAuditDbConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UploadAuditDbConfigResponse>(response);
        }

        public AsyncInvoker<UploadAuditDbConfigResponse> UploadAuditDbConfigAsyncInvoker(UploadAuditDbConfigRequest uploadAuditDbConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/databases/configs/obs-upload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", uploadAuditDbConfigRequest);
            return new AsyncInvoker<UploadAuditDbConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadAuditDbConfigResponse>);
        }
        
        /// <summary>
        /// 添加审计数据库Agent
        ///
        /// 添加审计数据库Agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddAuditAgentNewResponse> AddAuditAgentNewAsync(AddAuditAgentNewRequest addAuditAgentNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addAuditAgentNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditAgentNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddAuditAgentNewResponse>(response);
        }

        public AsyncInvoker<AddAuditAgentNewResponse> AddAuditAgentNewAsyncInvoker(AddAuditAgentNewRequest addAuditAgentNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addAuditAgentNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addAuditAgentNewRequest);
            return new AsyncInvoker<AddAuditAgentNewResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAuditAgentNewResponse>);
        }
        
        /// <summary>
        /// 指定agent_id方式添加agent
        ///
        /// 指定agent_id方式添加agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAuditDbAgentResponse> CreateAuditDbAgentAsync(CreateAuditDbAgentRequest createAuditDbAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAuditDbAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createAuditDbAgentRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuditDbAgentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAuditDbAgentResponse>(response);
        }

        public AsyncInvoker<CreateAuditDbAgentResponse> CreateAuditDbAgentAsyncInvoker(CreateAuditDbAgentRequest createAuditDbAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAuditDbAgentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createAuditDbAgentRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuditDbAgentRequest);
            return new AsyncInvoker<CreateAuditDbAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAuditDbAgentResponse>);
        }
        
        /// <summary>
        /// 删除数据库Agent
        ///
        /// 删除数据库Agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAuditAgentNewResponse> DeleteAuditAgentNewAsync(DeleteAuditAgentNewRequest deleteAuditAgentNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAgentNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAgentNewRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditAgentNewRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditAgentNewResponse>(response);
        }

        public AsyncInvoker<DeleteAuditAgentNewResponse> DeleteAuditAgentNewAsyncInvoker(DeleteAuditAgentNewRequest deleteAuditAgentNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAgentNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditAgentNewRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/agents/{agent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditAgentNewRequest);
            return new AsyncInvoker<DeleteAuditAgentNewResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditAgentNewResponse>);
        }
        
        /// <summary>
        /// 下载审计Agent
        ///
        /// 下载审计Agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadAuditAgentNewResponse> DownloadAuditAgentNewAsync(DownloadAuditAgentNewRequest downloadAuditAgentNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditAgentNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditAgentNewRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/agents/{agent_id}/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAuditAgentNewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadAuditAgentNewResponse>(response);
        }

        public AsyncInvoker<DownloadAuditAgentNewResponse> DownloadAuditAgentNewAsyncInvoker(DownloadAuditAgentNewRequest downloadAuditAgentNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditAgentNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(downloadAuditAgentNewRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/agents/{agent_id}/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAuditAgentNewRequest);
            return new AsyncInvoker<DownloadAuditAgentNewResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadAuditAgentNewResponse>);
        }
        
        /// <summary>
        /// 查询数据库Agent列表
        ///
        /// 查询数据库Agent列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditAgentNewResponse> ListAuditAgentNewAsync(ListAuditAgentNewRequest listAuditAgentNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditAgentNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditAgentNewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditAgentNewResponse>(response);
        }

        public AsyncInvoker<ListAuditAgentNewResponse> ListAuditAgentNewAsyncInvoker(ListAuditAgentNewRequest listAuditAgentNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditAgentNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/audit/{instance_id}/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditAgentNewRequest);
            return new AsyncInvoker<ListAuditAgentNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditAgentNewResponse>);
        }
        
        /// <summary>
        /// 开启/关闭Agent
        ///
        /// 用于开启和关闭Agent审计的功能，当开启后，开始抓取用户的访问信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchAgentNewResponse> SwitchAgentNewAsync(SwitchAgentNewRequest switchAgentNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchAgentNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/agent/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAgentNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SwitchAgentNewResponse>(response);
        }

        public AsyncInvoker<SwitchAgentNewResponse> SwitchAgentNewAsyncInvoker(SwitchAgentNewRequest switchAgentNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchAgentNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/agent/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAgentNewRequest);
            return new AsyncInvoker<SwitchAgentNewResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchAgentNewResponse>);
        }
        
        /// <summary>
        /// 批量添加白名单
        ///
        /// 批量添加白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchAddAuditWhitelistResponse> BatchAddAuditWhitelistAsync(BatchAddAuditWhitelistRequest batchAddAuditWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchAddAuditWhitelistRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/whitelists", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddAuditWhitelistRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchAddAuditWhitelistResponse>(response);
        }

        public AsyncInvoker<BatchAddAuditWhitelistResponse> BatchAddAuditWhitelistAsyncInvoker(BatchAddAuditWhitelistRequest batchAddAuditWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchAddAuditWhitelistRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/whitelists", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddAuditWhitelistRequest);
            return new AsyncInvoker<BatchAddAuditWhitelistResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAddAuditWhitelistResponse>);
        }
        
        /// <summary>
        /// 添加sql自定义规则
        ///
        /// 添加sql自定义规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAuditSqlRuleResponse> CreateAuditSqlRuleAsync(CreateAuditSqlRuleRequest createAuditSqlRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAuditSqlRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/sql", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuditSqlRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAuditSqlRuleResponse>(response);
        }

        public AsyncInvoker<CreateAuditSqlRuleResponse> CreateAuditSqlRuleAsyncInvoker(CreateAuditSqlRuleRequest createAuditSqlRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAuditSqlRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/sql", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuditSqlRuleRequest);
            return new AsyncInvoker<CreateAuditSqlRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAuditSqlRuleResponse>);
        }
        
        /// <summary>
        /// 删除sql自定义规则
        ///
        /// 删除sql自定义规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAuditRuleSqlResponse> DeleteAuditRuleSqlAsync(DeleteAuditRuleSqlRequest deleteAuditRuleSqlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditRuleSqlRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditRuleSqlRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/sql/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditRuleSqlRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditRuleSqlResponse>(response);
        }

        public AsyncInvoker<DeleteAuditRuleSqlResponse> DeleteAuditRuleSqlAsyncInvoker(DeleteAuditRuleSqlRequest deleteAuditRuleSqlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditRuleSqlRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditRuleSqlRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/sql/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditRuleSqlRequest);
            return new AsyncInvoker<DeleteAuditRuleSqlResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditRuleSqlResponse>);
        }
        
        /// <summary>
        /// 批量删除白名单
        ///
        /// 批量删除白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAuditWhitelistResponse> DeleteAuditWhitelistAsync(DeleteAuditWhitelistRequest deleteAuditWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditWhitelistRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/whitelists/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditWhitelistRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DeleteAuditWhitelistResponse>(response);
        }

        public AsyncInvoker<DeleteAuditWhitelistResponse> DeleteAuditWhitelistAsyncInvoker(DeleteAuditWhitelistRequest deleteAuditWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAuditWhitelistRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/whitelists/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditWhitelistRequest);
            return new AsyncInvoker<DeleteAuditWhitelistResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteAuditWhitelistResponse>);
        }
        
        /// <summary>
        /// 查询SQL注入规则策略
        ///
        /// 查询SQL注入规则策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSqlInjectionRulesNewResponse> ListSqlInjectionRulesNewAsync(ListSqlInjectionRulesNewRequest listSqlInjectionRulesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlInjectionRulesNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/sqls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSqlInjectionRulesNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListSqlInjectionRulesNewResponse>(response);
        }

        public AsyncInvoker<ListSqlInjectionRulesNewResponse> ListSqlInjectionRulesNewAsyncInvoker(ListSqlInjectionRulesNewRequest listSqlInjectionRulesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlInjectionRulesNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/sqls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSqlInjectionRulesNewRequest);
            return new AsyncInvoker<ListSqlInjectionRulesNewResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSqlInjectionRulesNewResponse>);
        }
        
        /// <summary>
        /// 查询白名单列表
        ///
        /// 查询白名单列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWhitelistsResponse> ListWhitelistsAsync(ListWhitelistsRequest listWhitelistsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listWhitelistsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/whitelists", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWhitelistsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListWhitelistsResponse>(response);
        }

        public AsyncInvoker<ListWhitelistsResponse> ListWhitelistsAsyncInvoker(ListWhitelistsRequest listWhitelistsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listWhitelistsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/whitelists", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWhitelistsRequest);
            return new AsyncInvoker<ListWhitelistsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWhitelistsResponse>);
        }
        
        /// <summary>
        /// 开启关闭sql注入策略
        ///
        /// 开启关闭sql注入策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetAuditSqlRuleSwitchResponse> SetAuditSqlRuleSwitchAsync(SetAuditSqlRuleSwitchRequest setAuditSqlRuleSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditSqlRuleSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/sql/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditSqlRuleSwitchRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetAuditSqlRuleSwitchResponse>(response);
        }

        public AsyncInvoker<SetAuditSqlRuleSwitchResponse> SetAuditSqlRuleSwitchAsyncInvoker(SetAuditSqlRuleSwitchRequest setAuditSqlRuleSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditSqlRuleSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/sql/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditSqlRuleSwitchRequest);
            return new AsyncInvoker<SetAuditSqlRuleSwitchResponse>(this, "POST", request, JsonUtils.DeSerialize<SetAuditSqlRuleSwitchResponse>);
        }
        
        /// <summary>
        /// sql规则优先级排序
        ///
        /// sql规则优先级排序
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetSqlRuleRankResponse> SetSqlRuleRankAsync(SetSqlRuleRankRequest setSqlRuleRankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSqlRuleRankRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/sql/rank", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSqlRuleRankRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetSqlRuleRankResponse>(response);
        }

        public AsyncInvoker<SetSqlRuleRankResponse> SetSqlRuleRankAsyncInvoker(SetSqlRuleRankRequest setSqlRuleRankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSqlRuleRankRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/audit/{instance_id}/rule/sql/rank", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSqlRuleRankRequest);
            return new AsyncInvoker<SetSqlRuleRankResponse>(this, "POST", request, JsonUtils.DeSerialize<SetSqlRuleRankResponse>);
        }
        
        /// <summary>
        /// 编辑sql自定义规则
        ///
        /// 编辑sql自定义规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAuditSqlRuleResponse> UpdateAuditSqlRuleAsync(UpdateAuditSqlRuleRequest updateAuditSqlRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditSqlRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateAuditSqlRuleRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/sql/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditSqlRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateAuditSqlRuleResponse>(response);
        }

        public AsyncInvoker<UpdateAuditSqlRuleResponse> UpdateAuditSqlRuleAsyncInvoker(UpdateAuditSqlRuleRequest updateAuditSqlRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditSqlRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateAuditSqlRuleRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/rule/sql/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditSqlRuleRequest);
            return new AsyncInvoker<UpdateAuditSqlRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAuditSqlRuleResponse>);
        }
        
        /// <summary>
        /// 修改白名单
        ///
        /// 修改白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAuditWhitelistResponse> UpdateAuditWhitelistAsync(UpdateAuditWhitelistRequest updateAuditWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditWhitelistRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateAuditWhitelistRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/whitelists/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditWhitelistRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAuditWhitelistResponse>(response);
        }

        public AsyncInvoker<UpdateAuditWhitelistResponse> UpdateAuditWhitelistAsyncInvoker(UpdateAuditWhitelistRequest updateAuditWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAuditWhitelistRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateAuditWhitelistRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audit/{instance_id}/whitelists/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuditWhitelistRequest);
            return new AsyncInvoker<UpdateAuditWhitelistResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAuditWhitelistResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(batchAddResourceTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(batchAddResourceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddResourceTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchAddResourceTagResponse>(response);
        }

        public AsyncInvoker<BatchAddResourceTagResponse> BatchAddResourceTagAsyncInvoker(BatchAddResourceTagRequest batchAddResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchAddResourceTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(batchAddResourceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
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
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteResourceTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteResourceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteResourceTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<BatchDeleteResourceTagResponse>(response);
        }

        public AsyncInvoker<BatchDeleteResourceTagResponse> BatchDeleteResourceTagAsyncInvoker(BatchDeleteResourceTagRequest batchDeleteResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteResourceTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteResourceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
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
            if (StringUtils.TryConvertToNonEmptyString(countResourceInstanceByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", countResourceInstanceByTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CountResourceInstanceByTagResponse>(response);
        }

        public AsyncInvoker<CountResourceInstanceByTagResponse> CountResourceInstanceByTagAsyncInvoker(CountResourceInstanceByTagRequest countResourceInstanceByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countResourceInstanceByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", countResourceInstanceByTagRequest);
            return new AsyncInvoker<CountResourceInstanceByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<CountResourceInstanceByTagResponse>);
        }
        
        /// <summary>
        /// 获取实例标签
        ///
        /// 获取实例标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditTagsResponse> ListAuditTagsAsync(ListAuditTagsRequest listAuditTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listAuditTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditTagsResponse>(response);
        }

        public AsyncInvoker<ListAuditTagsResponse> ListAuditTagsAsyncInvoker(ListAuditTagsRequest listAuditTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listAuditTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditTagsRequest);
            return new AsyncInvoker<ListAuditTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditTagsResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(listProjectResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectResourceTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProjectResourceTagsResponse>(response);
        }

        public AsyncInvoker<ListProjectResourceTagsResponse> ListProjectResourceTagsAsyncInvoker(ListProjectResourceTagsRequest listProjectResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
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
            if (StringUtils.TryConvertToNonEmptyString(listResourceInstanceByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstanceByTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListResourceInstanceByTagResponse>(response);
        }

        public AsyncInvoker<ListResourceInstanceByTagResponse> ListResourceInstanceByTagAsyncInvoker(ListResourceInstanceByTagRequest listResourceInstanceByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceInstanceByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstanceByTagRequest);
            return new AsyncInvoker<ListResourceInstanceByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceInstanceByTagResponse>);
        }
        
    }
}