using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Dds.V3.Model;

namespace HuaweiCloud.SDK.Dds.V3
{
    public partial class DdsAsyncClient : Client
    {
        public static ClientBuilder<DdsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<DdsAsyncClient>();
        }

        
        /// <summary>
        /// 实例新增只读节点
        ///
        /// DDS副本集实例新增只读节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddReadonlyNodeResponse> AddReadonlyNodeAsync(AddReadonlyNodeRequest addReadonlyNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addReadonlyNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/readonly-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addReadonlyNodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddReadonlyNodeResponse>(response);
        }

        public AsyncInvoker<AddReadonlyNodeResponse> AddReadonlyNodeAsyncInvoker(AddReadonlyNodeRequest addReadonlyNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addReadonlyNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/readonly-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addReadonlyNodeRequest);
            return new AsyncInvoker<AddReadonlyNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<AddReadonlyNodeResponse>);
        }
        
        /// <summary>
        /// 扩容集群实例的节点数量
        ///
        /// 扩容指定集群实例的节点数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddShardingNodeResponse> AddShardingNodeAsync(AddShardingNodeRequest addShardingNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addShardingNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/enlarge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addShardingNodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddShardingNodeResponse>(response);
        }

        public AsyncInvoker<AddShardingNodeResponse> AddShardingNodeAsyncInvoker(AddShardingNodeRequest addShardingNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addShardingNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/enlarge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addShardingNodeRequest);
            return new AsyncInvoker<AddShardingNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<AddShardingNodeResponse>);
        }
        
        /// <summary>
        /// 绑定弹性公网IP
        ///
        /// 为实例下的节点绑定弹性公网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AttachEipResponse> AttachEipAsync(AttachEipRequest attachEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", attachEipRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nodes/{node_id}/bind-eip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachEipRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AttachEipResponse>(response);
        }

        public AsyncInvoker<AttachEipResponse> AttachEipAsyncInvoker(AttachEipRequest attachEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", attachEipRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nodes/{node_id}/bind-eip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachEipRequest);
            return new AsyncInvoker<AttachEipResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachEipResponse>);
        }
        
        /// <summary>
        /// 修改实例内网地址
        ///
        /// 修改实例的内网地址
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AttachInternalIpResponse> AttachInternalIpAsync(AttachInternalIpRequest attachInternalIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", attachInternalIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-internal-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachInternalIpRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AttachInternalIpResponse>(response);
        }

        public AsyncInvoker<AttachInternalIpResponse> AttachInternalIpAsyncInvoker(AttachInternalIpRequest attachInternalIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", attachInternalIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-internal-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachInternalIpRequest);
            return new AsyncInvoker<AttachInternalIpResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachInternalIpResponse>);
        }
        
        /// <summary>
        /// 批量删除手动备份
        ///
        /// 批量删除数据库实例的手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteBackupResponse> BatchDeleteBackupAsync(BatchDeleteBackupRequest batchDeleteBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteBackupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<BatchDeleteBackupResponse>(response);
        }

        public AsyncInvoker<BatchDeleteBackupResponse> BatchDeleteBackupAsyncInvoker(BatchDeleteBackupRequest batchDeleteBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteBackupRequest);
            return new AsyncInvoker<BatchDeleteBackupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<BatchDeleteBackupResponse>);
        }
        
        /// <summary>
        /// 批量添加或删除资源标签
        ///
        /// 批量添加或删除指定实例的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchTagActionResponse> BatchTagActionAsync(BatchTagActionRequest batchTagActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchTagActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagActionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchTagActionResponse>(response);
        }

        public AsyncInvoker<BatchTagActionResponse> BatchTagActionAsyncInvoker(BatchTagActionRequest batchTagActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchTagActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagActionRequest);
            return new AsyncInvoker<BatchTagActionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchTagActionResponse>);
        }
        
        /// <summary>
        /// 批量数据库补丁升级
        ///
        /// 批量升级数据库补丁版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpgradeDatabaseVersionResponse> BatchUpgradeDatabaseVersionAsync(BatchUpgradeDatabaseVersionRequest batchUpgradeDatabaseVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpgradeDatabaseVersionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchUpgradeDatabaseVersionResponse>(response);
        }

        public AsyncInvoker<BatchUpgradeDatabaseVersionResponse> BatchUpgradeDatabaseVersionAsyncInvoker(BatchUpgradeDatabaseVersionRequest batchUpgradeDatabaseVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpgradeDatabaseVersionRequest);
            return new AsyncInvoker<BatchUpgradeDatabaseVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchUpgradeDatabaseVersionResponse>);
        }
        
        /// <summary>
        /// 解绑弹性公网IP
        ///
        /// 解绑实例下节点已经绑定的弹性公网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelEipResponse> CancelEipAsync(CancelEipRequest cancelEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", cancelEipRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nodes/{node_id}/unbind-eip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelEipRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CancelEipResponse>(response);
        }

        public AsyncInvoker<CancelEipResponse> CancelEipAsyncInvoker(CancelEipRequest cancelEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", cancelEipRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nodes/{node_id}/unbind-eip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelEipRequest);
            return new AsyncInvoker<CancelEipResponse>(this, "POST", request, JsonUtils.DeSerialize<CancelEipResponse>);
        }
        
        /// <summary>
        /// 取消定时任务
        ///
        /// 根据任务ID取消定时任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelScheduledTaskResponse> CancelScheduledTaskAsync(CancelScheduledTaskRequest cancelScheduledTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", cancelScheduledTaskRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/scheduled-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelScheduledTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<CancelScheduledTaskResponse>(response);
        }

        public AsyncInvoker<CancelScheduledTaskResponse> CancelScheduledTaskAsyncInvoker(CancelScheduledTaskRequest cancelScheduledTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", cancelScheduledTaskRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/scheduled-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelScheduledTaskRequest);
            return new AsyncInvoker<CancelScheduledTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CancelScheduledTaskResponse>);
        }
        
        /// <summary>
        /// 设置可维护时间段
        ///
        /// 修改用户允许启动某项对数据库实例运行有影响的任务的时间范围，例如操作系统升级和数据库软件版本升级的时间窗。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeOpsWindowResponse> ChangeOpsWindowAsync(ChangeOpsWindowRequest changeOpsWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeOpsWindowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/maintenance-window", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeOpsWindowRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<ChangeOpsWindowResponse>(response);
        }

        public AsyncInvoker<ChangeOpsWindowResponse> ChangeOpsWindowAsyncInvoker(ChangeOpsWindowRequest changeOpsWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeOpsWindowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/maintenance-window", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeOpsWindowRequest);
            return new AsyncInvoker<ChangeOpsWindowResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ChangeOpsWindowResponse>);
        }
        
        /// <summary>
        /// 检查数据库密码
        ///
        /// 检查数据库密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckPasswordResponse> CheckPasswordAsync(CheckPasswordRequest checkPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", checkPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/check-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkPasswordRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CheckPasswordResponse>(response);
        }

        public AsyncInvoker<CheckPasswordResponse> CheckPasswordAsyncInvoker(CheckPasswordRequest checkPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", checkPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/check-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkPasswordRequest);
            return new AsyncInvoker<CheckPasswordResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CheckPasswordResponse>);
        }
        
        /// <summary>
        /// 检查弱密码
        ///
        /// 检查弱密码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckWeakPasswordResponse> CheckWeakPasswordAsync(CheckWeakPasswordRequest checkWeakPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/weak-password-verification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkWeakPasswordRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CheckWeakPasswordResponse>(response);
        }

        public AsyncInvoker<CheckWeakPasswordResponse> CheckWeakPasswordAsyncInvoker(CheckWeakPasswordRequest checkWeakPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/weak-password-verification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkWeakPasswordRequest);
            return new AsyncInvoker<CheckWeakPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckWeakPasswordResponse>);
        }
        
        /// <summary>
        /// 参数模板比较
        ///
        /// 比较两个参数模板之间的差异。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CompareConfigurationResponse> CompareConfigurationAsync(CompareConfigurationRequest compareConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/comparison", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareConfigurationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CompareConfigurationResponse>(response);
        }

        public AsyncInvoker<CompareConfigurationResponse> CompareConfigurationAsyncInvoker(CompareConfigurationRequest compareConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/comparison", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareConfigurationRequest);
            return new AsyncInvoker<CompareConfigurationResponse>(this, "POST", request, JsonUtils.DeSerialize<CompareConfigurationResponse>);
        }
        
        /// <summary>
        /// 复制参数模板
        ///
        /// 复制参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CopyConfigurationResponse> CopyConfigurationAsync(CopyConfigurationRequest copyConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", copyConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyConfigurationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CopyConfigurationResponse>(response);
        }

        public AsyncInvoker<CopyConfigurationResponse> CopyConfigurationAsyncInvoker(CopyConfigurationRequest copyConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", copyConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyConfigurationRequest);
            return new AsyncInvoker<CopyConfigurationResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyConfigurationResponse>);
        }
        
        /// <summary>
        /// 创建参数模板
        ///
        /// 创建参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateConfigurationResponse> CreateConfigurationAsync(CreateConfigurationRequest createConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfigurationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateConfigurationResponse>(response);
        }

        public AsyncInvoker<CreateConfigurationResponse> CreateConfigurationAsyncInvoker(CreateConfigurationRequest createConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfigurationRequest);
            return new AsyncInvoker<CreateConfigurationResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateConfigurationResponse>);
        }
        
        /// <summary>
        /// 创建数据库角色
        ///
        /// 创建数据库角色。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDatabaseRoleResponse> CreateDatabaseRoleAsync(CreateDatabaseRoleRequest createDatabaseRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDatabaseRoleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDatabaseRoleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDatabaseRoleResponse>(response);
        }

        public AsyncInvoker<CreateDatabaseRoleResponse> CreateDatabaseRoleAsyncInvoker(CreateDatabaseRoleRequest createDatabaseRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDatabaseRoleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDatabaseRoleRequest);
            return new AsyncInvoker<CreateDatabaseRoleResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDatabaseRoleResponse>);
        }
        
        /// <summary>
        /// 创建数据库用户
        ///
        /// 创建数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDatabaseUserResponse> CreateDatabaseUserAsync(CreateDatabaseUserRequest createDatabaseUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDatabaseUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDatabaseUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDatabaseUserResponse>(response);
        }

        public AsyncInvoker<CreateDatabaseUserResponse> CreateDatabaseUserAsyncInvoker(CreateDatabaseUserRequest createDatabaseUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDatabaseUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDatabaseUserRequest);
            return new AsyncInvoker<CreateDatabaseUserResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDatabaseUserResponse>);
        }
        
        /// <summary>
        /// 创建实例
        ///
        /// 创建文档数据库实例，包括集群实例、副本集实例、以及单节点实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceResponse>(response);
        }

        public AsyncInvoker<CreateInstanceResponse> CreateInstanceAsyncInvoker(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRequest);
            return new AsyncInvoker<CreateInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceResponse>);
        }
        
        /// <summary>
        /// 创建集群的Shard/Config IP
        ///
        /// 创建集群的Shard/Config IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateIpResponse> CreateIpAsync(CreateIpRequest createIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/create-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIpRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateIpResponse>(response);
        }

        public AsyncInvoker<CreateIpResponse> CreateIpAsyncInvoker(CreateIpRequest createIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/create-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIpRequest);
            return new AsyncInvoker<CreateIpResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateIpResponse>);
        }
        
        /// <summary>
        /// 创建killOp规则
        ///
        /// 创建killOp规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateKillOpRuleResponse> CreateKillOpRuleAsync(CreateKillOpRuleRequest createKillOpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createKillOpRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kill-op-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKillOpRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateKillOpRuleResponse>(response);
        }

        public AsyncInvoker<CreateKillOpRuleResponse> CreateKillOpRuleAsyncInvoker(CreateKillOpRuleRequest createKillOpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createKillOpRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kill-op-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKillOpRuleRequest);
            return new AsyncInvoker<CreateKillOpRuleResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateKillOpRuleResponse>);
        }
        
        /// <summary>
        /// 创建手动备份
        ///
        /// 创建数据库实例的手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateManualBackupResponse> CreateManualBackupAsync(CreateManualBackupRequest createManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createManualBackupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateManualBackupResponse>(response);
        }

        public AsyncInvoker<CreateManualBackupResponse> CreateManualBackupAsyncInvoker(CreateManualBackupRequest createManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createManualBackupRequest);
            return new AsyncInvoker<CreateManualBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateManualBackupResponse>);
        }
        
        /// <summary>
        /// 删除审计日志
        ///
        /// 删除审计日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAuditLogResponse> DeleteAuditLogAsync(DeleteAuditLogRequest deleteAuditLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteAuditLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditLogRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditLogResponse>(response);
        }

        public AsyncInvoker<DeleteAuditLogResponse> DeleteAuditLogAsyncInvoker(DeleteAuditLogRequest deleteAuditLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteAuditLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditLogRequest);
            return new AsyncInvoker<DeleteAuditLogResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditLogResponse>);
        }
        
        /// <summary>
        /// 删除参数模板
        ///
        /// 删除参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteConfigurationResponse> DeleteConfigurationAsync(DeleteConfigurationRequest deleteConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", deleteConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigurationRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteConfigurationResponse>(response);
        }

        public AsyncInvoker<DeleteConfigurationResponse> DeleteConfigurationAsyncInvoker(DeleteConfigurationRequest deleteConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", deleteConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigurationRequest);
            return new AsyncInvoker<DeleteConfigurationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteConfigurationResponse>);
        }
        
        /// <summary>
        /// 删除数据库角色
        ///
        /// 删除数据库角色。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDatabaseRoleResponse> DeleteDatabaseRoleAsync(DeleteDatabaseRoleRequest deleteDatabaseRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabaseRoleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseRoleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDatabaseRoleResponse>(response);
        }

        public AsyncInvoker<DeleteDatabaseRoleResponse> DeleteDatabaseRoleAsyncInvoker(DeleteDatabaseRoleRequest deleteDatabaseRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabaseRoleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseRoleRequest);
            return new AsyncInvoker<DeleteDatabaseRoleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDatabaseRoleResponse>);
        }
        
        /// <summary>
        /// 删除数据库用户
        ///
        /// 删除数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDatabaseUserResponse> DeleteDatabaseUserAsync(DeleteDatabaseUserRequest deleteDatabaseUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabaseUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseUserRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDatabaseUserResponse>(response);
        }

        public AsyncInvoker<DeleteDatabaseUserResponse> DeleteDatabaseUserAsyncInvoker(DeleteDatabaseUserRequest deleteDatabaseUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabaseUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseUserRequest);
            return new AsyncInvoker<DeleteDatabaseUserResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDatabaseUserResponse>);
        }
        
        /// <summary>
        /// 删除实例
        ///
        /// 删除数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInstanceResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceResponse> DeleteInstanceAsyncInvoker(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            return new AsyncInvoker<DeleteInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteInstanceResponse>);
        }
        
        /// <summary>
        /// 删除killOp规则
        ///
        /// 删除killOp规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteKillOpRuleListResponse> DeleteKillOpRuleListAsync(DeleteKillOpRuleListRequest deleteKillOpRuleListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteKillOpRuleListRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kill-op-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKillOpRuleListRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteKillOpRuleListResponse>(response);
        }

        public AsyncInvoker<DeleteKillOpRuleListResponse> DeleteKillOpRuleListAsyncInvoker(DeleteKillOpRuleListRequest deleteKillOpRuleListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteKillOpRuleListRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kill-op-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKillOpRuleListRequest);
            return new AsyncInvoker<DeleteKillOpRuleListResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteKillOpRuleListResponse>);
        }
        
        /// <summary>
        /// 解除关联LTS日志流
        ///
        /// 将实例日志与LTS日志流解除关联，后台将取消上传实例日志到的LTS日志流里。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLtsConfigResponse> DeleteLtsConfigAsync(DeleteLtsConfigRequest deleteLtsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLtsConfigRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLtsConfigResponse>(response);
        }

        public AsyncInvoker<DeleteLtsConfigResponse> DeleteLtsConfigAsyncInvoker(DeleteLtsConfigRequest deleteLtsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLtsConfigRequest);
            return new AsyncInvoker<DeleteLtsConfigResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLtsConfigResponse>);
        }
        
        /// <summary>
        /// 删除手动备份
        ///
        /// 删除数据库实例的手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteManualBackupResponse> DeleteManualBackupAsync(DeleteManualBackupRequest deleteManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteManualBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteManualBackupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteManualBackupResponse>(response);
        }

        public AsyncInvoker<DeleteManualBackupResponse> DeleteManualBackupAsyncInvoker(DeleteManualBackupRequest deleteManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteManualBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteManualBackupRequest);
            return new AsyncInvoker<DeleteManualBackupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteManualBackupResponse>);
        }
        
        /// <summary>
        /// 删除只读节点
        ///
        /// 当副本集添加了只读节点后，需要删除对应的只读节点需要调用此API。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteReadonlyNodeResponse> DeleteReadonlyNodeAsync(DeleteReadonlyNodeRequest deleteReadonlyNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteReadonlyNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/readonly-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteReadonlyNodeRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteReadonlyNodeResponse>(response);
        }

        public AsyncInvoker<DeleteReadonlyNodeResponse> DeleteReadonlyNodeAsyncInvoker(DeleteReadonlyNodeRequest deleteReadonlyNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteReadonlyNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/readonly-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteReadonlyNodeRequest);
            return new AsyncInvoker<DeleteReadonlyNodeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteReadonlyNodeResponse>);
        }
        
        /// <summary>
        /// 终结实例节点会话
        ///
        /// 终结实例节点会话。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSessionResponse> DeleteSessionAsync(DeleteSessionRequest deleteSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", deleteSessionRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nodes/{node_id}/session", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSessionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteSessionResponse>(response);
        }

        public AsyncInvoker<DeleteSessionResponse> DeleteSessionAsyncInvoker(DeleteSessionRequest deleteSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", deleteSessionRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nodes/{node_id}/session", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSessionRequest);
            return new AsyncInvoker<DeleteSessionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteSessionResponse>);
        }
        
        /// <summary>
        /// 获取错误日志下载链接
        ///
        /// 获取错误日志下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadErrorlogResponse> DownloadErrorlogAsync(DownloadErrorlogRequest downloadErrorlogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", downloadErrorlogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/errorlog-download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadErrorlogRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DownloadErrorlogResponse>(response);
        }

        public AsyncInvoker<DownloadErrorlogResponse> DownloadErrorlogAsyncInvoker(DownloadErrorlogRequest downloadErrorlogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", downloadErrorlogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/errorlog-download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadErrorlogRequest);
            return new AsyncInvoker<DownloadErrorlogResponse>(this, "POST", request, JsonUtils.DeSerialize<DownloadErrorlogResponse>);
        }
        
        /// <summary>
        /// 获取慢日志下载链接
        ///
        /// 获取慢日志下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadSlowlogResponse> DownloadSlowlogAsync(DownloadSlowlogRequest downloadSlowlogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", downloadSlowlogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSlowlogRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DownloadSlowlogResponse>(response);
        }

        public AsyncInvoker<DownloadSlowlogResponse> DownloadSlowlogAsyncInvoker(DownloadSlowlogRequest downloadSlowlogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", downloadSlowlogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSlowlogRequest);
            return new AsyncInvoker<DownloadSlowlogResponse>(this, "POST", request, JsonUtils.DeSerialize<DownloadSlowlogResponse>);
        }
        
        /// <summary>
        /// 扩容副本集实例的节点数量
        ///
        /// 扩容指定副本集实例的节点数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExpandReplicasetNodeResponse> ExpandReplicasetNodeAsync(ExpandReplicasetNodeRequest expandReplicasetNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", expandReplicasetNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replicaset-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandReplicasetNodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExpandReplicasetNodeResponse>(response);
        }

        public AsyncInvoker<ExpandReplicasetNodeResponse> ExpandReplicasetNodeAsyncInvoker(ExpandReplicasetNodeRequest expandReplicasetNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", expandReplicasetNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replicaset-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandReplicasetNodeRequest);
            return new AsyncInvoker<ExpandReplicasetNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<ExpandReplicasetNodeResponse>);
        }
        
        /// <summary>
        /// 查询可应用的实例
        ///
        /// 查询指定参数模板可被应用的实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAppliedInstancesResponse> ListAppliedInstancesAsync(ListAppliedInstancesRequest listAppliedInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", listAppliedInstancesRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applicable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppliedInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAppliedInstancesResponse>(response);
        }

        public AsyncInvoker<ListAppliedInstancesResponse> ListAppliedInstancesAsyncInvoker(ListAppliedInstancesRequest listAppliedInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", listAppliedInstancesRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applicable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppliedInstancesRequest);
            return new AsyncInvoker<ListAppliedInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppliedInstancesResponse>);
        }
        
        /// <summary>
        /// 获取审计日志下载链接
        ///
        /// 获取审计日志下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditlogLinksResponse> ListAuditlogLinksAsync(ListAuditlogLinksRequest listAuditlogLinksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditlogLinksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-links", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditlogLinksRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAuditlogLinksResponse>(response);
        }

        public AsyncInvoker<ListAuditlogLinksResponse> ListAuditlogLinksAsyncInvoker(ListAuditlogLinksRequest listAuditlogLinksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditlogLinksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-links", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditlogLinksRequest);
            return new AsyncInvoker<ListAuditlogLinksResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditlogLinksResponse>);
        }
        
        /// <summary>
        /// 获取审计日志列表
        ///
        /// 获取审计日志列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditlogsResponse> ListAuditlogsAsync(ListAuditlogsRequest listAuditlogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditlogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditlogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditlogsResponse>(response);
        }

        public AsyncInvoker<ListAuditlogsResponse> ListAuditlogsAsyncInvoker(ListAuditlogsRequest listAuditlogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditlogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditlogsRequest);
            return new AsyncInvoker<ListAuditlogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditlogsResponse>);
        }
        
        /// <summary>
        /// 查询实例可迁移到的可用区
        ///
        /// 查询实例可迁移到的可用区。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAz2MigrateResponse> ListAz2MigrateAsync(ListAz2MigrateRequest listAz2MigrateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAz2MigrateRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/migrate/az", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAz2MigrateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAz2MigrateResponse>(response);
        }

        public AsyncInvoker<ListAz2MigrateResponse> ListAz2MigrateAsyncInvoker(ListAz2MigrateRequest listAz2MigrateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAz2MigrateRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/migrate/az", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAz2MigrateRequest);
            return new AsyncInvoker<ListAz2MigrateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAz2MigrateResponse>);
        }
        
        /// <summary>
        /// 查询备份列表
        ///
        /// 根据指定条件查询备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBackupsResponse> ListBackupsAsync(ListBackupsRequest listBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBackupsResponse>(response);
        }

        public AsyncInvoker<ListBackupsResponse> ListBackupsAsyncInvoker(ListBackupsRequest listBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupsRequest);
            return new AsyncInvoker<ListBackupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBackupsResponse>);
        }
        
        /// <summary>
        /// 获取参数模板列表
        ///
        /// 获取参数模板列表，包括DDS数据库的所有默认参数模板和用户创建的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConfigurationsResponse> ListConfigurationsAsync(ListConfigurationsRequest listConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListConfigurationsResponse>(response);
        }

        public AsyncInvoker<ListConfigurationsResponse> ListConfigurationsAsyncInvoker(ListConfigurationsRequest listConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationsRequest);
            return new AsyncInvoker<ListConfigurationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigurationsResponse>);
        }
        
        /// <summary>
        /// 查询数据库角色列表
        ///
        /// 查询数据库角色列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDatabaseRolesResponse> ListDatabaseRolesAsync(ListDatabaseRolesRequest listDatabaseRolesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabaseRolesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseRolesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDatabaseRolesResponse>(response);
        }

        public AsyncInvoker<ListDatabaseRolesResponse> ListDatabaseRolesAsyncInvoker(ListDatabaseRolesRequest listDatabaseRolesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabaseRolesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseRolesRequest);
            return new AsyncInvoker<ListDatabaseRolesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabaseRolesResponse>);
        }
        
        /// <summary>
        /// 查询数据库用户列表
        ///
        /// 查询数据库用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDatabaseUsersResponse> ListDatabaseUsersAsync(ListDatabaseUsersRequest listDatabaseUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabaseUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseUsersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDatabaseUsersResponse>(response);
        }

        public AsyncInvoker<ListDatabaseUsersResponse> ListDatabaseUsersAsyncInvoker(ListDatabaseUsersRequest listDatabaseUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabaseUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseUsersRequest);
            return new AsyncInvoker<ListDatabaseUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabaseUsersResponse>);
        }
        
        /// <summary>
        /// 查询数据库列表
        ///
        /// 查询数据库列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDatabasesResponse> ListDatabasesAsync(ListDatabasesRequest listDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabasesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDatabasesResponse>(response);
        }

        public AsyncInvoker<ListDatabasesResponse> ListDatabasesAsyncInvoker(ListDatabasesRequest listDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabasesRequest);
            return new AsyncInvoker<ListDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabasesResponse>);
        }
        
        /// <summary>
        /// 查询数据库版本信息
        ///
        /// 查询指定实例类型的数据库版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDatastoreVersionsResponse> ListDatastoreVersionsAsync(ListDatastoreVersionsRequest listDatastoreVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("datastore_name", listDatastoreVersionsRequest.DatastoreName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores/{datastore_name}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoreVersionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDatastoreVersionsResponse>(response);
        }

        public AsyncInvoker<ListDatastoreVersionsResponse> ListDatastoreVersionsAsyncInvoker(ListDatastoreVersionsRequest listDatastoreVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("datastore_name", listDatastoreVersionsRequest.DatastoreName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores/{datastore_name}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoreVersionsRequest);
            return new AsyncInvoker<ListDatastoreVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatastoreVersionsResponse>);
        }
        
        /// <summary>
        /// 查询数据库错误日志
        ///
        /// 查询数据库错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListErrorLogsResponse> ListErrorLogsAsync(ListErrorLogsRequest listErrorLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listErrorLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/errorlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listErrorLogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListErrorLogsResponse>(response);
        }

        public AsyncInvoker<ListErrorLogsResponse> ListErrorLogsAsyncInvoker(ListErrorLogsRequest listErrorLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listErrorLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/errorlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listErrorLogsRequest);
            return new AsyncInvoker<ListErrorLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListErrorLogsResponse>);
        }
        
        /// <summary>
        /// 查询数据库规格
        ///
        /// 查询指定条件下的实例规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFlavorInfosResponse> ListFlavorInfosAsync(ListFlavorInfosRequest listFlavorInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorInfosRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorInfosResponse>(response);
        }

        public AsyncInvoker<ListFlavorInfosResponse> ListFlavorInfosAsyncInvoker(ListFlavorInfosRequest listFlavorInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorInfosRequest);
            return new AsyncInvoker<ListFlavorInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorInfosResponse>);
        }
        
        /// <summary>
        /// 查询所有实例规格信息
        ///
        /// 查询指定条件下的所有实例规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFlavorsResponse> ListFlavorsAsync(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }

        public AsyncInvoker<ListFlavorsResponse> ListFlavorsAsyncInvoker(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            return new AsyncInvoker<ListFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询指定实例的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceTagsResponse> ListInstanceTagsAsync(ListInstanceTagsRequest listInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceTagsResponse>(response);
        }

        public AsyncInvoker<ListInstanceTagsResponse> ListInstanceTagsAsyncInvoker(ListInstanceTagsRequest listInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTagsRequest);
            return new AsyncInvoker<ListInstanceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceTagsResponse>);
        }
        
        /// <summary>
        /// 查询实例列表和详情
        ///
        /// 根据指定条件查询实例列表和详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesResponse>(response);
        }

        public AsyncInvoker<ListInstancesResponse> ListInstancesAsyncInvoker(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            return new AsyncInvoker<ListInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesResponse>);
        }
        
        /// <summary>
        /// 查询资源实例
        ///
        /// 根据标签查询指定的数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesByTagsResponse> ListInstancesByTagsAsync(ListInstancesByTagsRequest listInstancesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListInstancesByTagsResponse>(response);
        }

        public AsyncInvoker<ListInstancesByTagsResponse> ListInstancesByTagsAsyncInvoker(ListInstancesByTagsRequest listInstancesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesByTagsRequest);
            return new AsyncInvoker<ListInstancesByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInstancesByTagsResponse>);
        }
        
        /// <summary>
        /// 查询LTS日志配置信息
        ///
        /// 查询LTS日志配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLtsConfigsResponse> ListLtsConfigsAsync(ListLtsConfigsRequest listLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLtsConfigsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLtsConfigsResponse>(response);
        }

        public AsyncInvoker<ListLtsConfigsResponse> ListLtsConfigsAsyncInvoker(ListLtsConfigsRequest listLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLtsConfigsRequest);
            return new AsyncInvoker<ListLtsConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLtsConfigsResponse>);
        }
        
        /// <summary>
        /// 查询数据库错误日志
        ///
        /// 查询数据库错误日志信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLtsErrorLogsResponse> ListLtsErrorLogsAsync(ListLtsErrorLogsRequest listLtsErrorLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listLtsErrorLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/error-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLtsErrorLogsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListLtsErrorLogsResponse>(response);
        }

        public AsyncInvoker<ListLtsErrorLogsResponse> ListLtsErrorLogsAsyncInvoker(ListLtsErrorLogsRequest listLtsErrorLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listLtsErrorLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/error-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLtsErrorLogsRequest);
            return new AsyncInvoker<ListLtsErrorLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLtsErrorLogsResponse>);
        }
        
        /// <summary>
        /// 查询数据库慢日志
        ///
        /// 查询数据库慢日志信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLtsSlowLogsResponse> ListLtsSlowLogsAsync(ListLtsSlowLogsRequest listLtsSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listLtsSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLtsSlowLogsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListLtsSlowLogsResponse>(response);
        }

        public AsyncInvoker<ListLtsSlowLogsResponse> ListLtsSlowLogsAsyncInvoker(ListLtsSlowLogsRequest listLtsSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listLtsSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLtsSlowLogsRequest);
            return new AsyncInvoker<ListLtsSlowLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLtsSlowLogsResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询指定project ID下实例的所有标签集合。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectTagsResponse> ListProjectTagsAsync(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProjectTagsResponse>(response);
        }

        public AsyncInvoker<ListProjectTagsResponse> ListProjectTagsAsyncInvoker(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            return new AsyncInvoker<ListProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectTagsResponse>);
        }
        
        /// <summary>
        /// 查询回收站实例列表
        ///
        /// 查询回收站实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecycleInstancesResponse> ListRecycleInstancesAsync(ListRecycleInstancesRequest listRecycleInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/recycle-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecycleInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRecycleInstancesResponse>(response);
        }

        public AsyncInvoker<ListRecycleInstancesResponse> ListRecycleInstancesAsyncInvoker(ListRecycleInstancesRequest listRecycleInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/recycle-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecycleInstancesRequest);
            return new AsyncInvoker<ListRecycleInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecycleInstancesResponse>);
        }
        
        /// <summary>
        /// 获取可恢复的数据库集合列表
        ///
        /// 获取可恢复的数据库集合列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRestoreCollectionsResponse> ListRestoreCollectionsAsync(ListRestoreCollectionsRequest listRestoreCollectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreCollectionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-collection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreCollectionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRestoreCollectionsResponse>(response);
        }

        public AsyncInvoker<ListRestoreCollectionsResponse> ListRestoreCollectionsAsyncInvoker(ListRestoreCollectionsRequest listRestoreCollectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreCollectionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-collection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreCollectionsRequest);
            return new AsyncInvoker<ListRestoreCollectionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestoreCollectionsResponse>);
        }
        
        /// <summary>
        /// 获取可恢复的数据库列表
        ///
        /// 获取可恢复的数据库列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRestoreDatabasesResponse> ListRestoreDatabasesAsync(ListRestoreDatabasesRequest listRestoreDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreDatabasesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRestoreDatabasesResponse>(response);
        }

        public AsyncInvoker<ListRestoreDatabasesResponse> ListRestoreDatabasesAsyncInvoker(ListRestoreDatabasesRequest listRestoreDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreDatabasesRequest);
            return new AsyncInvoker<ListRestoreDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestoreDatabasesResponse>);
        }
        
        /// <summary>
        /// 查询可恢复的时间段
        ///
        /// 查询实例的可恢复时间段。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRestoreTimesResponse> ListRestoreTimesAsync(ListRestoreTimesRequest listRestoreTimesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreTimesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTimesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRestoreTimesResponse>(response);
        }

        public AsyncInvoker<ListRestoreTimesResponse> ListRestoreTimesAsyncInvoker(ListRestoreTimesRequest listRestoreTimesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreTimesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTimesRequest);
            return new AsyncInvoker<ListRestoreTimesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestoreTimesResponse>);
        }
        
        /// <summary>
        /// 查询定时任务
        ///
        /// 根据指定条件查询定时任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScheduledTasksResponse> ListScheduledTasksAsync(ListScheduledTasksRequest listScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/scheduled-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduledTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListScheduledTasksResponse>(response);
        }

        public AsyncInvoker<ListScheduledTasksResponse> ListScheduledTasksAsyncInvoker(ListScheduledTasksRequest listScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/scheduled-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduledTasksRequest);
            return new AsyncInvoker<ListScheduledTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScheduledTasksResponse>);
        }
        
        /// <summary>
        /// 查询实例节点会话
        ///
        /// 查询实例节点会话。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSessionsResponse> ListSessionsAsync(ListSessionsRequest listSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", listSessionsRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nodes/{node_id}/sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSessionsResponse>(response);
        }

        public AsyncInvoker<ListSessionsResponse> ListSessionsAsyncInvoker(ListSessionsRequest listSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", listSessionsRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nodes/{node_id}/sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionsRequest);
            return new AsyncInvoker<ListSessionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSessionsResponse>);
        }
        
        /// <summary>
        /// 查询数据库慢日志
        ///
        /// 查询数据库慢日志信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSlowLogsResponse> ListSlowLogsAsync(ListSlowLogsRequest listSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSlowLogsResponse>(response);
        }

        public AsyncInvoker<ListSlowLogsResponse> ListSlowLogsAsyncInvoker(ListSlowLogsRequest listSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsRequest);
            return new AsyncInvoker<ListSlowLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSlowLogsResponse>);
        }
        
        /// <summary>
        /// 获取SSL证书下载地址
        ///
        /// 获取SSL证书下载地址
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSslCertDownloadAddressResponse> ListSslCertDownloadAddressAsync(ListSslCertDownloadAddressRequest listSslCertDownloadAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSslCertDownloadAddressRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-cert/download-link", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSslCertDownloadAddressRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSslCertDownloadAddressResponse>(response);
        }

        public AsyncInvoker<ListSslCertDownloadAddressResponse> ListSslCertDownloadAddressAsyncInvoker(ListSslCertDownloadAddressRequest listSslCertDownloadAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSslCertDownloadAddressRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-cert/download-link", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSslCertDownloadAddressRequest);
            return new AsyncInvoker<ListSslCertDownloadAddressResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSslCertDownloadAddressResponse>);
        }
        
        /// <summary>
        /// 查询数据库磁盘类型
        ///
        /// 查询当前区域下的数据库磁盘类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStorageTypeResponse> ListStorageTypeAsync(ListStorageTypeRequest listStorageTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/storage-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageTypeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStorageTypeResponse>(response);
        }

        public AsyncInvoker<ListStorageTypeResponse> ListStorageTypeAsyncInvoker(ListStorageTypeRequest listStorageTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/storage-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageTypeRequest);
            return new AsyncInvoker<ListStorageTypeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStorageTypeResponse>);
        }
        
        /// <summary>
        /// 查询任务列表和详情
        ///
        /// 根据指定条件查询任务中心中的任务列表和详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTasksResponse> ListTasksAsync(ListTasksRequest listTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTasksResponse>(response);
        }

        public AsyncInvoker<ListTasksResponse> ListTasksAsyncInvoker(ListTasksRequest listTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTasksRequest);
            return new AsyncInvoker<ListTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTasksResponse>);
        }
        
        /// <summary>
        /// 实例可用区迁移
        ///
        /// 实例可用区迁移。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<MigrateAzResponse> MigrateAzAsync(MigrateAzRequest migrateAzRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", migrateAzRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateAzRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<MigrateAzResponse>(response);
        }

        public AsyncInvoker<MigrateAzResponse> MigrateAzAsyncInvoker(MigrateAzRequest migrateAzRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", migrateAzRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateAzRequest);
            return new AsyncInvoker<MigrateAzResponse>(this, "POST", request, JsonUtils.DeSerialize<MigrateAzResponse>);
        }
        
        /// <summary>
        /// 重置参数模板
        ///
        /// 重置参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetConfigurationResponse> ResetConfigurationAsync(ResetConfigurationRequest resetConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", resetConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetConfigurationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ResetConfigurationResponse>(response);
        }

        public AsyncInvoker<ResetConfigurationResponse> ResetConfigurationAsyncInvoker(ResetConfigurationRequest resetConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", resetConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetConfigurationRequest);
            return new AsyncInvoker<ResetConfigurationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetConfigurationResponse>);
        }
        
        /// <summary>
        /// 修改数据库用户密码
        ///
        /// 修改数据库用户密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordRequest resetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/reset-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPasswordRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetPasswordResponse>(response);
        }

        public AsyncInvoker<ResetPasswordResponse> ResetPasswordAsyncInvoker(ResetPasswordRequest resetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/reset-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPasswordRequest);
            return new AsyncInvoker<ResetPasswordResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetPasswordResponse>);
        }
        
        /// <summary>
        /// 变更实例规格
        ///
        /// 变更实例的规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResizeInstanceResponse> ResizeInstanceAsync(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResizeInstanceResponse>(response);
        }

        public AsyncInvoker<ResizeInstanceResponse> ResizeInstanceAsyncInvoker(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceRequest);
            return new AsyncInvoker<ResizeInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeInstanceResponse>);
        }
        
        /// <summary>
        /// 扩容实例存储容量
        ///
        /// 扩容实例相关的存储容量大小。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResizeInstanceVolumeResponse> ResizeInstanceVolumeAsync(ResizeInstanceVolumeRequest resizeInstanceVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/enlarge-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceVolumeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResizeInstanceVolumeResponse>(response);
        }

        public AsyncInvoker<ResizeInstanceVolumeResponse> ResizeInstanceVolumeAsyncInvoker(ResizeInstanceVolumeRequest resizeInstanceVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/enlarge-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceVolumeRequest);
            return new AsyncInvoker<ResizeInstanceVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeInstanceVolumeResponse>);
        }
        
        /// <summary>
        /// 重启实例
        ///
        /// 重启实例的数据库服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestartInstanceResponse> RestartInstanceAsync(RestartInstanceRequest restartInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RestartInstanceResponse>(response);
        }

        public AsyncInvoker<RestartInstanceResponse> RestartInstanceAsyncInvoker(RestartInstanceRequest restartInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartInstanceRequest);
            return new AsyncInvoker<RestartInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestartInstanceResponse>);
        }
        
        /// <summary>
        /// 恢复到当前实例
        ///
        /// 恢复到当前实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestoreInstanceResponse> RestoreInstanceAsync(RestoreInstanceRequest restoreInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RestoreInstanceResponse>(response);
        }

        public AsyncInvoker<RestoreInstanceResponse> RestoreInstanceAsyncInvoker(RestoreInstanceRequest restoreInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreInstanceRequest);
            return new AsyncInvoker<RestoreInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreInstanceResponse>);
        }
        
        /// <summary>
        /// 库表级时间点恢复
        ///
        /// 库表级时间点恢复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestoreInstanceFromCollectionResponse> RestoreInstanceFromCollectionAsync(RestoreInstanceFromCollectionRequest restoreInstanceFromCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restoreInstanceFromCollectionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore/collections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreInstanceFromCollectionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RestoreInstanceFromCollectionResponse>(response);
        }

        public AsyncInvoker<RestoreInstanceFromCollectionResponse> RestoreInstanceFromCollectionAsyncInvoker(RestoreInstanceFromCollectionRequest restoreInstanceFromCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restoreInstanceFromCollectionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore/collections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreInstanceFromCollectionRequest);
            return new AsyncInvoker<RestoreInstanceFromCollectionResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreInstanceFromCollectionResponse>);
        }
        
        /// <summary>
        /// 恢复到新实例
        ///
        /// 根据备份恢复新实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestoreNewInstanceResponse> RestoreNewInstanceAsync(RestoreNewInstanceRequest restoreNewInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreNewInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RestoreNewInstanceResponse>(response);
        }

        public AsyncInvoker<RestoreNewInstanceResponse> RestoreNewInstanceAsyncInvoker(RestoreNewInstanceRequest restoreNewInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreNewInstanceRequest);
            return new AsyncInvoker<RestoreNewInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreNewInstanceResponse>);
        }
        
        /// <summary>
        /// 设置审计日志策略
        ///
        /// 设置审计日志策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetAuditlogPolicyResponse> SetAuditlogPolicyAsync(SetAuditlogPolicyRequest setAuditlogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setAuditlogPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditlogPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SetAuditlogPolicyResponse>(response);
        }

        public AsyncInvoker<SetAuditlogPolicyResponse> SetAuditlogPolicyAsyncInvoker(SetAuditlogPolicyRequest setAuditlogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setAuditlogPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditlogPolicyRequest);
            return new AsyncInvoker<SetAuditlogPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetAuditlogPolicyResponse>);
        }
        
        /// <summary>
        /// 设置磁盘自动扩容策略
        ///
        /// 设置磁盘自动扩容策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetAutoEnlargePoliciesResponse> SetAutoEnlargePoliciesAsync(SetAutoEnlargePoliciesRequest setAutoEnlargePoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/auto-enlarge-volume-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAutoEnlargePoliciesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetAutoEnlargePoliciesResponse>(response);
        }

        public AsyncInvoker<SetAutoEnlargePoliciesResponse> SetAutoEnlargePoliciesAsyncInvoker(SetAutoEnlargePoliciesRequest setAutoEnlargePoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/auto-enlarge-volume-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAutoEnlargePoliciesRequest);
            return new AsyncInvoker<SetAutoEnlargePoliciesResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetAutoEnlargePoliciesResponse>);
        }
        
        /// <summary>
        /// 设置自动备份策略
        ///
        /// 设置自动备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetBackupPolicyResponse> SetBackupPolicyAsync(SetBackupPolicyRequest setBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBackupPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetBackupPolicyResponse>(response);
        }

        public AsyncInvoker<SetBackupPolicyResponse> SetBackupPolicyAsyncInvoker(SetBackupPolicyRequest setBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBackupPolicyRequest);
            return new AsyncInvoker<SetBackupPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetBackupPolicyResponse>);
        }
        
        /// <summary>
        /// 设置集群均衡开关
        ///
        /// 设置集群均衡开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetBalancerSwitchResponse> SetBalancerSwitchAsync(SetBalancerSwitchRequest setBalancerSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setBalancerSwitchRequest.InstanceId.ToString());
            urlParam.Add("action", setBalancerSwitchRequest.Action.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balancer/{action}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBalancerSwitchRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SetBalancerSwitchResponse>(response);
        }

        public AsyncInvoker<SetBalancerSwitchResponse> SetBalancerSwitchAsyncInvoker(SetBalancerSwitchRequest setBalancerSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setBalancerSwitchRequest.InstanceId.ToString());
            urlParam.Add("action", setBalancerSwitchRequest.Action.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balancer/{action}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBalancerSwitchRequest);
            return new AsyncInvoker<SetBalancerSwitchResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetBalancerSwitchResponse>);
        }
        
        /// <summary>
        /// 设置集群均衡活动时间窗
        ///
        /// 设置集群均衡活动时间窗。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetBalancerWindowResponse> SetBalancerWindowAsync(SetBalancerWindowRequest setBalancerWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setBalancerWindowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balancer/active-window", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBalancerWindowRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SetBalancerWindowResponse>(response);
        }

        public AsyncInvoker<SetBalancerWindowResponse> SetBalancerWindowAsyncInvoker(SetBalancerWindowRequest setBalancerWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setBalancerWindowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balancer/active-window", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBalancerWindowRequest);
            return new AsyncInvoker<SetBalancerWindowResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetBalancerWindowResponse>);
        }
        
        /// <summary>
        /// 设置实例回收站策略
        ///
        /// 设置实例回收站策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetRecyclePolicyResponse> SetRecyclePolicyAsync(SetRecyclePolicyRequest setRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRecyclePolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetRecyclePolicyResponse>(response);
        }

        public AsyncInvoker<SetRecyclePolicyResponse> SetRecyclePolicyAsyncInvoker(SetRecyclePolicyRequest setRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRecyclePolicyRequest);
            return new AsyncInvoker<SetRecyclePolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetRecyclePolicyResponse>);
        }
        
        /// <summary>
        /// 查询审计日志策略
        ///
        /// 查询审计日志策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAuditlogPolicyResponse> ShowAuditlogPolicyAsync(ShowAuditlogPolicyRequest showAuditlogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAuditlogPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditlogPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditlogPolicyResponse>(response);
        }

        public AsyncInvoker<ShowAuditlogPolicyResponse> ShowAuditlogPolicyAsyncInvoker(ShowAuditlogPolicyRequest showAuditlogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAuditlogPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditlogPolicyRequest);
            return new AsyncInvoker<ShowAuditlogPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditlogPolicyResponse>);
        }
        
        /// <summary>
        /// 查询磁盘自动扩容策略
        ///
        /// 查询磁盘自动扩容策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutoEnlargePolicyResponse> ShowAutoEnlargePolicyAsync(ShowAutoEnlargePolicyRequest showAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAutoEnlargePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auto-enlarge-volume-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoEnlargePolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoEnlargePolicyResponse>(response);
        }

        public AsyncInvoker<ShowAutoEnlargePolicyResponse> ShowAutoEnlargePolicyAsyncInvoker(ShowAutoEnlargePolicyRequest showAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAutoEnlargePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auto-enlarge-volume-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoEnlargePolicyRequest);
            return new AsyncInvoker<ShowAutoEnlargePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoEnlargePolicyResponse>);
        }
        
        /// <summary>
        /// 获取备份下载链接
        ///
        /// 获取备份下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBackupDownloadLinkResponse> ShowBackupDownloadLinkAsync(ShowBackupDownloadLinkRequest showBackupDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/download-file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupDownloadLinkRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBackupDownloadLinkResponse>(response);
        }

        public AsyncInvoker<ShowBackupDownloadLinkResponse> ShowBackupDownloadLinkAsyncInvoker(ShowBackupDownloadLinkRequest showBackupDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/download-file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupDownloadLinkRequest);
            return new AsyncInvoker<ShowBackupDownloadLinkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackupDownloadLinkResponse>);
        }
        
        /// <summary>
        /// 查询自动备份策略
        ///
        /// 查询自动备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBackupPolicyResponse> ShowBackupPolicyAsync(ShowBackupPolicyRequest showBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBackupPolicyResponse>(response);
        }

        public AsyncInvoker<ShowBackupPolicyResponse> ShowBackupPolicyAsyncInvoker(ShowBackupPolicyRequest showBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupPolicyRequest);
            return new AsyncInvoker<ShowBackupPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackupPolicyResponse>);
        }
        
        /// <summary>
        /// 查询副本集跨网段访问配置
        ///
        /// 查询副本集跨网段访问配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowClientNetworkResponse> ShowClientNetworkAsync(ShowClientNetworkRequest showClientNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showClientNetworkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/client-network", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClientNetworkRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowClientNetworkResponse>(response);
        }

        public AsyncInvoker<ShowClientNetworkResponse> ShowClientNetworkAsyncInvoker(ShowClientNetworkRequest showClientNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showClientNetworkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/client-network", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClientNetworkRequest);
            return new AsyncInvoker<ShowClientNetworkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClientNetworkResponse>);
        }
        
        /// <summary>
        /// 查询参数模板被应用历史
        ///
        /// 查询参数模板应用历史
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowConfigurationAppliedHistoryResponse> ShowConfigurationAppliedHistoryAsync(ShowConfigurationAppliedHistoryRequest showConfigurationAppliedHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showConfigurationAppliedHistoryRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applied-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationAppliedHistoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigurationAppliedHistoryResponse>(response);
        }

        public AsyncInvoker<ShowConfigurationAppliedHistoryResponse> ShowConfigurationAppliedHistoryAsyncInvoker(ShowConfigurationAppliedHistoryRequest showConfigurationAppliedHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showConfigurationAppliedHistoryRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applied-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationAppliedHistoryRequest);
            return new AsyncInvoker<ShowConfigurationAppliedHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigurationAppliedHistoryResponse>);
        }
        
        /// <summary>
        /// 查询参数模板修改历史
        ///
        /// 查询参数模板修改历史。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowConfigurationModifyHistoryResponse> ShowConfigurationModifyHistoryAsync(ShowConfigurationModifyHistoryRequest showConfigurationModifyHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showConfigurationModifyHistoryRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationModifyHistoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigurationModifyHistoryResponse>(response);
        }

        public AsyncInvoker<ShowConfigurationModifyHistoryResponse> ShowConfigurationModifyHistoryAsyncInvoker(ShowConfigurationModifyHistoryRequest showConfigurationModifyHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showConfigurationModifyHistoryRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationModifyHistoryRequest);
            return new AsyncInvoker<ShowConfigurationModifyHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigurationModifyHistoryResponse>);
        }
        
        /// <summary>
        /// 获取参数模板的详情
        ///
        /// 获取参数模板的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowConfigurationParameterResponse> ShowConfigurationParameterAsync(ShowConfigurationParameterRequest showConfigurationParameterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showConfigurationParameterRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationParameterRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigurationParameterResponse>(response);
        }

        public AsyncInvoker<ShowConfigurationParameterResponse> ShowConfigurationParameterAsyncInvoker(ShowConfigurationParameterRequest showConfigurationParameterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showConfigurationParameterRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationParameterRequest);
            return new AsyncInvoker<ShowConfigurationParameterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigurationParameterResponse>);
        }
        
        /// <summary>
        /// 查询实例连接数统计信息
        ///
        /// 查询客户端IP访问至DDS数据库实例的连接数统计信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowConnectionStatisticsResponse> ShowConnectionStatisticsAsync(ShowConnectionStatisticsRequest showConnectionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showConnectionStatisticsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/conn-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConnectionStatisticsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowConnectionStatisticsResponse>(response);
        }

        public AsyncInvoker<ShowConnectionStatisticsResponse> ShowConnectionStatisticsAsyncInvoker(ShowConnectionStatisticsRequest showConnectionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showConnectionStatisticsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/conn-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConnectionStatisticsRequest);
            return new AsyncInvoker<ShowConnectionStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConnectionStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询实例磁盘信息
        ///
        /// 查询实例磁盘信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDiskUsageResponse> ShowDiskUsageAsync(ShowDiskUsageRequest showDiskUsageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showDiskUsageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disk-usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiskUsageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDiskUsageResponse>(response);
        }

        public AsyncInvoker<ShowDiskUsageResponse> ShowDiskUsageAsyncInvoker(ShowDiskUsageRequest showDiskUsageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showDiskUsageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disk-usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiskUsageRequest);
            return new AsyncInvoker<ShowDiskUsageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDiskUsageResponse>);
        }
        
        /// <summary>
        /// 获取指定实例的参数信息
        ///
        /// 获取指定实例的参数，可以是实例，组，节点的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEntityConfigurationResponse> ShowEntityConfigurationAsync(ShowEntityConfigurationRequest showEntityConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showEntityConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEntityConfigurationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowEntityConfigurationResponse>(response);
        }

        public AsyncInvoker<ShowEntityConfigurationResponse> ShowEntityConfigurationAsyncInvoker(ShowEntityConfigurationRequest showEntityConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showEntityConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEntityConfigurationRequest);
            return new AsyncInvoker<ShowEntityConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEntityConfigurationResponse>);
        }
        
        /// <summary>
        /// 查询实例参数的修改历史
        ///
        /// 查询实例参数的修改历史。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceConfigurationModifyHistoryResponse> ShowInstanceConfigurationModifyHistoryAsync(ShowInstanceConfigurationModifyHistoryRequest showInstanceConfigurationModifyHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceConfigurationModifyHistoryRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configuration-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigurationModifyHistoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceConfigurationModifyHistoryResponse>(response);
        }

        public AsyncInvoker<ShowInstanceConfigurationModifyHistoryResponse> ShowInstanceConfigurationModifyHistoryAsyncInvoker(ShowInstanceConfigurationModifyHistoryRequest showInstanceConfigurationModifyHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceConfigurationModifyHistoryRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configuration-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigurationModifyHistoryRequest);
            return new AsyncInvoker<ShowInstanceConfigurationModifyHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceConfigurationModifyHistoryResponse>);
        }
        
        /// <summary>
        /// 获取DDS任务中心指定ID的任务信息。
        ///
        /// 获取DDS任务中心指定ID的任务信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobDetailResponse> ShowJobDetailAsync(ShowJobDetailRequest showJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobDetailResponse>(response);
        }

        public AsyncInvoker<ShowJobDetailResponse> ShowJobDetailAsyncInvoker(ShowJobDetailRequest showJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            return new AsyncInvoker<ShowJobDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobDetailResponse>);
        }
        
        /// <summary>
        /// 获取killOp规则列表
        ///
        /// 获取killOp规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowKillOpRuleRuleListResponse> ShowKillOpRuleRuleListAsync(ShowKillOpRuleRuleListRequest showKillOpRuleRuleListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showKillOpRuleRuleListRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kill-op-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKillOpRuleRuleListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowKillOpRuleRuleListResponse>(response);
        }

        public AsyncInvoker<ShowKillOpRuleRuleListResponse> ShowKillOpRuleRuleListAsyncInvoker(ShowKillOpRuleRuleListRequest showKillOpRuleRuleListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showKillOpRuleRuleListRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kill-op-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKillOpRuleRuleListRequest);
            return new AsyncInvoker<ShowKillOpRuleRuleListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKillOpRuleRuleListResponse>);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// 查询单租户在DDS服务下的资源配额，包括单节点实例配额、副本集实例配额、集群实例配额等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQuotasResponse> ShowQuotasAsync(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }

        public AsyncInvoker<ShowQuotasResponse> ShowQuotasAsyncInvoker(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            return new AsyncInvoker<ShowQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotasResponse>);
        }
        
        /// <summary>
        /// 查询实例回收站策略
        ///
        /// 查询实例回收站策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecyclePolicyResponse> ShowRecyclePolicyAsync(ShowRecyclePolicyRequest showRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecyclePolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRecyclePolicyResponse>(response);
        }

        public AsyncInvoker<ShowRecyclePolicyResponse> ShowRecyclePolicyAsyncInvoker(ShowRecyclePolicyRequest showRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecyclePolicyRequest);
            return new AsyncInvoker<ShowRecyclePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecyclePolicyResponse>);
        }
        
        /// <summary>
        /// 查询数据库复制集名称
        ///
        /// 查询数据库复制集名称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowReplSetNameResponse> ShowReplSetNameAsync(ShowReplSetNameRequest showReplSetNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showReplSetNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replica-set/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplSetNameRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowReplSetNameResponse>(response);
        }

        public AsyncInvoker<ShowReplSetNameResponse> ShowReplSetNameAsyncInvoker(ShowReplSetNameRequest showReplSetNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showReplSetNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replica-set/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplSetNameRequest);
            return new AsyncInvoker<ShowReplSetNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReplSetNameResponse>);
        }
        
        /// <summary>
        /// 查询秒级监控配置
        ///
        /// 查询秒级监控配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSecondLevelMonitoringStatusResponse> ShowSecondLevelMonitoringStatusAsync(ShowSecondLevelMonitoringStatusRequest showSecondLevelMonitoringStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSecondLevelMonitoringStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitoring-by-seconds/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecondLevelMonitoringStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSecondLevelMonitoringStatusResponse>(response);
        }

        public AsyncInvoker<ShowSecondLevelMonitoringStatusResponse> ShowSecondLevelMonitoringStatusAsyncInvoker(ShowSecondLevelMonitoringStatusRequest showSecondLevelMonitoringStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSecondLevelMonitoringStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitoring-by-seconds/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecondLevelMonitoringStatusRequest);
            return new AsyncInvoker<ShowSecondLevelMonitoringStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecondLevelMonitoringStatusResponse>);
        }
        
        /// <summary>
        /// 查询集群均衡设置
        ///
        /// 查询集群均衡设置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowShardingBalancerResponse> ShowShardingBalancerAsync(ShowShardingBalancerRequest showShardingBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showShardingBalancerRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balancer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showShardingBalancerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowShardingBalancerResponse>(response);
        }

        public AsyncInvoker<ShowShardingBalancerResponse> ShowShardingBalancerAsyncInvoker(ShowShardingBalancerRequest showShardingBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showShardingBalancerRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balancer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showShardingBalancerRequest);
            return new AsyncInvoker<ShowShardingBalancerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowShardingBalancerResponse>);
        }
        
        /// <summary>
        /// 查询慢日志明文开关
        ///
        /// 查询慢日志明文开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSlowlogDesensitizationSwitchResponse> ShowSlowlogDesensitizationSwitchAsync(ShowSlowlogDesensitizationSwitchRequest showSlowlogDesensitizationSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSlowlogDesensitizationSwitchRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-desensitization/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSlowlogDesensitizationSwitchRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSlowlogDesensitizationSwitchResponse>(response);
        }

        public AsyncInvoker<ShowSlowlogDesensitizationSwitchResponse> ShowSlowlogDesensitizationSwitchAsyncInvoker(ShowSlowlogDesensitizationSwitchRequest showSlowlogDesensitizationSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSlowlogDesensitizationSwitchRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-desensitization/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSlowlogDesensitizationSwitchRequest);
            return new AsyncInvoker<ShowSlowlogDesensitizationSwitchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSlowlogDesensitizationSwitchResponse>);
        }
        
        /// <summary>
        /// 查询数据库补丁升级预估时长
        ///
        /// 查询数据库补丁升级预估时长
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUpgradeDurationResponse> ShowUpgradeDurationAsync(ShowUpgradeDurationRequest showUpgradeDurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showUpgradeDurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade-duration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeDurationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUpgradeDurationResponse>(response);
        }

        public AsyncInvoker<ShowUpgradeDurationResponse> ShowUpgradeDurationAsyncInvoker(ShowUpgradeDurationRequest showUpgradeDurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showUpgradeDurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade-duration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeDurationRequest);
            return new AsyncInvoker<ShowUpgradeDurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUpgradeDurationResponse>);
        }
        
        /// <summary>
        /// 删除实例的节点
        ///
        /// 删除实例的节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShrinkInstanceNodesResponse> ShrinkInstanceNodesAsync(ShrinkInstanceNodesRequest shrinkInstanceNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", shrinkInstanceNodesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", shrinkInstanceNodesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<ShrinkInstanceNodesResponse>(response);
        }

        public AsyncInvoker<ShrinkInstanceNodesResponse> ShrinkInstanceNodesAsyncInvoker(ShrinkInstanceNodesRequest shrinkInstanceNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", shrinkInstanceNodesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", shrinkInstanceNodesRequest);
            return new AsyncInvoker<ShrinkInstanceNodesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<ShrinkInstanceNodesResponse>);
        }
        
        /// <summary>
        /// 停止备份
        ///
        /// 支持紧急情况下停止备份功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopBackupResponse> StopBackupAsync(StopBackupRequest stopBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", stopBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBackupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<StopBackupResponse>(response);
        }

        public AsyncInvoker<StopBackupResponse> StopBackupAsyncInvoker(StopBackupRequest stopBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", stopBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBackupRequest);
            return new AsyncInvoker<StopBackupResponse>(this, "PUT", request, JsonUtils.DeSerialize<StopBackupResponse>);
        }
        
        /// <summary>
        /// 应用参数模板
        ///
        /// 指定实例变更参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchConfigurationResponse> SwitchConfigurationAsync(SwitchConfigurationRequest switchConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", switchConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SwitchConfigurationResponse>(response);
        }

        public AsyncInvoker<SwitchConfigurationResponse> SwitchConfigurationAsyncInvoker(SwitchConfigurationRequest switchConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", switchConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchConfigurationRequest);
            return new AsyncInvoker<SwitchConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchConfigurationResponse>);
        }
        
        /// <summary>
        /// 强制备节点升主
        ///
        /// 支持副本集、shard和config备节点强制升主。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchInstancePrimaryResponse> SwitchInstancePrimaryAsync(SwitchInstancePrimaryRequest switchInstancePrimaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchInstancePrimaryRequest.InstanceId.ToString());
            urlParam.Add("node_id", switchInstancePrimaryRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/primary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchInstancePrimaryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SwitchInstancePrimaryResponse>(response);
        }

        public AsyncInvoker<SwitchInstancePrimaryResponse> SwitchInstancePrimaryAsyncInvoker(SwitchInstancePrimaryRequest switchInstancePrimaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchInstancePrimaryRequest.InstanceId.ToString());
            urlParam.Add("node_id", switchInstancePrimaryRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/primary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchInstancePrimaryRequest);
            return new AsyncInvoker<SwitchInstancePrimaryResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SwitchInstancePrimaryResponse>);
        }
        
        /// <summary>
        /// 开启/关闭秒级监控
        ///
        /// 开启或关闭指定实例的秒级监控。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchSecondLevelMonitoringResponse> SwitchSecondLevelMonitoringAsync(SwitchSecondLevelMonitoringRequest switchSecondLevelMonitoringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSecondLevelMonitoringRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitoring-by-seconds/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSecondLevelMonitoringRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SwitchSecondLevelMonitoringResponse>(response);
        }

        public AsyncInvoker<SwitchSecondLevelMonitoringResponse> SwitchSecondLevelMonitoringAsyncInvoker(SwitchSecondLevelMonitoringRequest switchSecondLevelMonitoringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSecondLevelMonitoringRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitoring-by-seconds/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSecondLevelMonitoringRequest);
            return new AsyncInvoker<SwitchSecondLevelMonitoringResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SwitchSecondLevelMonitoringResponse>);
        }
        
        /// <summary>
        /// 设置慢日志明文开关
        ///
        /// 设置实例的慢日志明文开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchSlowlogDesensitizationResponse> SwitchSlowlogDesensitizationAsync(SwitchSlowlogDesensitizationRequest switchSlowlogDesensitizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSlowlogDesensitizationRequest.InstanceId.ToString());
            urlParam.Add("status", switchSlowlogDesensitizationRequest.Status.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-desensitization/{status}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSlowlogDesensitizationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SwitchSlowlogDesensitizationResponse>(response);
        }

        public AsyncInvoker<SwitchSlowlogDesensitizationResponse> SwitchSlowlogDesensitizationAsyncInvoker(SwitchSlowlogDesensitizationRequest switchSlowlogDesensitizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSlowlogDesensitizationRequest.InstanceId.ToString());
            urlParam.Add("status", switchSlowlogDesensitizationRequest.Status.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-desensitization/{status}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSlowlogDesensitizationRequest);
            return new AsyncInvoker<SwitchSlowlogDesensitizationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SwitchSlowlogDesensitizationResponse>);
        }
        
        /// <summary>
        /// 切换SSL开关
        ///
        /// 切换实例的SSL开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchSslResponse> SwitchSslAsync(SwitchSslRequest switchSslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSslRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switch-ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSslRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SwitchSslResponse>(response);
        }

        public AsyncInvoker<SwitchSslResponse> SwitchSslAsyncInvoker(SwitchSslRequest switchSslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSslRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switch-ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSslRequest);
            return new AsyncInvoker<SwitchSslResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchSslResponse>);
        }
        
        /// <summary>
        /// 切换副本集实例的主备节点
        ///
        /// 切换副本集实例下的主备节点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchoverReplicaSetResponse> SwitchoverReplicaSetAsync(SwitchoverReplicaSetRequest switchoverReplicaSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchoverReplicaSetRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchoverReplicaSetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SwitchoverReplicaSetResponse>(response);
        }

        public AsyncInvoker<SwitchoverReplicaSetResponse> SwitchoverReplicaSetAsyncInvoker(SwitchoverReplicaSetRequest switchoverReplicaSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchoverReplicaSetRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchoverReplicaSetRequest);
            return new AsyncInvoker<SwitchoverReplicaSetResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchoverReplicaSetResponse>);
        }
        
        /// <summary>
        /// 副本集跨网段访问配置。
        ///
        /// 副本集跨网段访问配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateClientNetworkResponse> UpdateClientNetworkAsync(UpdateClientNetworkRequest updateClientNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateClientNetworkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/client-network", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClientNetworkRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateClientNetworkResponse>(response);
        }

        public AsyncInvoker<UpdateClientNetworkResponse> UpdateClientNetworkAsyncInvoker(UpdateClientNetworkRequest updateClientNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateClientNetworkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/client-network", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClientNetworkRequest);
            return new AsyncInvoker<UpdateClientNetworkResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateClientNetworkResponse>);
        }
        
        /// <summary>
        /// 修改参数模板
        ///
        /// 修改指定参数模板的参数信息，包括名称、描述、指定参数的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateConfigurationParameterResponse> UpdateConfigurationParameterAsync(UpdateConfigurationParameterRequest updateConfigurationParameterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", updateConfigurationParameterRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigurationParameterRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateConfigurationParameterResponse>(response);
        }

        public AsyncInvoker<UpdateConfigurationParameterResponse> UpdateConfigurationParameterAsyncInvoker(UpdateConfigurationParameterRequest updateConfigurationParameterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", updateConfigurationParameterRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigurationParameterRequest);
            return new AsyncInvoker<UpdateConfigurationParameterResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateConfigurationParameterResponse>);
        }
        
        /// <summary>
        /// 修改指定实例的参数
        ///
        /// 修改指定实例的参数，可以是实例，组，节点的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEntityConfigurationResponse> UpdateEntityConfigurationAsync(UpdateEntityConfigurationRequest updateEntityConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateEntityConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEntityConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEntityConfigurationResponse>(response);
        }

        public AsyncInvoker<UpdateEntityConfigurationResponse> UpdateEntityConfigurationAsyncInvoker(UpdateEntityConfigurationRequest updateEntityConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateEntityConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEntityConfigurationRequest);
            return new AsyncInvoker<UpdateEntityConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEntityConfigurationResponse>);
        }
        
        /// <summary>
        /// 修改实例名称
        ///
        /// 修改实例名称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceNameResponse> UpdateInstanceNameAsync(UpdateInstanceNameRequest updateInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceNameRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceNameResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceNameResponse> UpdateInstanceNameAsyncInvoker(UpdateInstanceNameRequest updateInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceNameRequest);
            return new AsyncInvoker<UpdateInstanceNameResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceNameResponse>);
        }
        
        /// <summary>
        /// 修改数据库端口
        ///
        /// 修改数据库实例的端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstancePortResponse> UpdateInstancePortAsync(UpdateInstancePortRequest updateInstancePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstancePortRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstancePortRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateInstancePortResponse>(response);
        }

        public AsyncInvoker<UpdateInstancePortResponse> UpdateInstancePortAsyncInvoker(UpdateInstancePortRequest updateInstancePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstancePortRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstancePortRequest);
            return new AsyncInvoker<UpdateInstancePortResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateInstancePortResponse>);
        }
        
        /// <summary>
        /// 修改实例备注
        ///
        /// 修改实例备注。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceRemarkResponse> UpdateInstanceRemarkAsync(UpdateInstanceRemarkRequest updateInstanceRemarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceRemarkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/remark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRemarkRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceRemarkResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceRemarkResponse> UpdateInstanceRemarkAsyncInvoker(UpdateInstanceRemarkRequest updateInstanceRemarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceRemarkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/remark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRemarkRequest);
            return new AsyncInvoker<UpdateInstanceRemarkResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceRemarkResponse>);
        }
        
        /// <summary>
        /// 启用/禁用killOp规则
        ///
        /// 启用/禁用killOp规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateKillOpRuleResponse> UpdateKillOpRuleAsync(UpdateKillOpRuleRequest updateKillOpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateKillOpRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kill-op-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKillOpRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateKillOpRuleResponse>(response);
        }

        public AsyncInvoker<UpdateKillOpRuleResponse> UpdateKillOpRuleAsyncInvoker(UpdateKillOpRuleRequest updateKillOpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateKillOpRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kill-op-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKillOpRuleRequest);
            return new AsyncInvoker<UpdateKillOpRuleResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateKillOpRuleResponse>);
        }
        
        /// <summary>
        /// 关联LTS日志流
        ///
        /// 将实例日志与LTS日志流关联，后台将自动上传实例日志到关联的LTS日志流里。
        /// 关联成功后，会产生一定费用，具体计费可参考云日志服务（LTS）的定价详情。
        /// 系统会为当前选择的日志流创建对应日志类型的结构化配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLtsConfigResponse> UpdateLtsConfigAsync(UpdateLtsConfigRequest updateLtsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLtsConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateLtsConfigResponse>(response);
        }

        public AsyncInvoker<UpdateLtsConfigResponse> UpdateLtsConfigAsyncInvoker(UpdateLtsConfigRequest updateLtsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLtsConfigRequest);
            return new AsyncInvoker<UpdateLtsConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateLtsConfigResponse>);
        }
        
        /// <summary>
        /// 修改数据库复制集名称
        ///
        /// 修改数据库复制集名称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateReplSetNameResponse> UpdateReplSetNameAsync(UpdateReplSetNameRequest updateReplSetNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateReplSetNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replica-set/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReplSetNameRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateReplSetNameResponse>(response);
        }

        public AsyncInvoker<UpdateReplSetNameResponse> UpdateReplSetNameAsyncInvoker(UpdateReplSetNameRequest updateReplSetNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateReplSetNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replica-set/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReplSetNameRequest);
            return new AsyncInvoker<UpdateReplSetNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateReplSetNameResponse>);
        }
        
        /// <summary>
        /// 变更实例安全组
        ///
        /// 变更实例关联的安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSecurityGroupResponse> UpdateSecurityGroupAsync(UpdateSecurityGroupRequest updateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateSecurityGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecurityGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateSecurityGroupResponse>(response);
        }

        public AsyncInvoker<UpdateSecurityGroupResponse> UpdateSecurityGroupAsyncInvoker(UpdateSecurityGroupRequest updateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateSecurityGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecurityGroupRequest);
            return new AsyncInvoker<UpdateSecurityGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 数据库补丁升级
        ///
        /// 升级数据库补丁版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpgradeDatabaseVersionResponse> UpgradeDatabaseVersionAsync(UpgradeDatabaseVersionRequest upgradeDatabaseVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeDatabaseVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDatabaseVersionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpgradeDatabaseVersionResponse>(response);
        }

        public AsyncInvoker<UpgradeDatabaseVersionResponse> UpgradeDatabaseVersionAsyncInvoker(UpgradeDatabaseVersionRequest upgradeDatabaseVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeDatabaseVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDatabaseVersionRequest);
            return new AsyncInvoker<UpgradeDatabaseVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeDatabaseVersionResponse>);
        }
        
        /// <summary>
        /// 校验参数模板名称是否存在
        ///
        /// 校验参数模板名称是否存在。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ValidateConfigurationNameResponse> ValidateConfigurationNameAsync(ValidateConfigurationNameRequest validateConfigurationNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/name-validation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateConfigurationNameRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ValidateConfigurationNameResponse>(response);
        }

        public AsyncInvoker<ValidateConfigurationNameResponse> ValidateConfigurationNameAsyncInvoker(ValidateConfigurationNameRequest validateConfigurationNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/name-validation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateConfigurationNameRequest);
            return new AsyncInvoker<ValidateConfigurationNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ValidateConfigurationNameResponse>);
        }
        
        /// <summary>
        /// 查询当前支持的API版本信息列表
        ///
        /// 查询当前支持的API版本信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApiVersionResponse> ListApiVersionAsync(ListApiVersionRequest listApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionResponse>(response);
        }

        public AsyncInvoker<ListApiVersionResponse> ListApiVersionAsyncInvoker(ListApiVersionRequest listApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionRequest);
            return new AsyncInvoker<ListApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionResponse>);
        }
        
        /// <summary>
        /// 查询指定API版本信息
        ///
        /// 查询指定API版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowApiVersionResponse> ShowApiVersionAsync(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", showApiVersionRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }

        public AsyncInvoker<ShowApiVersionResponse> ShowApiVersionAsyncInvoker(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", showApiVersionRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            return new AsyncInvoker<ShowApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApiVersionResponse>);
        }
        
    }
}