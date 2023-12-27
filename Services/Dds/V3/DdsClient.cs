using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Dds.V3.Model;

namespace HuaweiCloud.SDK.Dds.V3
{
    public partial class DdsClient : Client
    {
        public static ClientBuilder<DdsClient> NewBuilder()
        {
            return new ClientBuilder<DdsClient>();
        }

        
        /// <summary>
        /// 实例新增只读节点
        ///
        /// DDS副本集实例新增只读节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddReadonlyNodeResponse AddReadonlyNode(AddReadonlyNodeRequest addReadonlyNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addReadonlyNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/readonly-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addReadonlyNodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddReadonlyNodeResponse>(response);
        }

        public SyncInvoker<AddReadonlyNodeResponse> AddReadonlyNodeInvoker(AddReadonlyNodeRequest addReadonlyNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addReadonlyNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/readonly-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addReadonlyNodeRequest);
            return new SyncInvoker<AddReadonlyNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<AddReadonlyNodeResponse>);
        }
        
        /// <summary>
        /// 扩容集群实例的节点数量
        ///
        /// 扩容指定集群实例的节点数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddShardingNodeResponse AddShardingNode(AddShardingNodeRequest addShardingNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addShardingNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/enlarge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addShardingNodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddShardingNodeResponse>(response);
        }

        public SyncInvoker<AddShardingNodeResponse> AddShardingNodeInvoker(AddShardingNodeRequest addShardingNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addShardingNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/enlarge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addShardingNodeRequest);
            return new SyncInvoker<AddShardingNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<AddShardingNodeResponse>);
        }
        
        /// <summary>
        /// 绑定弹性公网IP
        ///
        /// 为实例下的节点绑定弹性公网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AttachEipResponse AttachEip(AttachEipRequest attachEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", attachEipRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nodes/{node_id}/bind-eip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachEipRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AttachEipResponse>(response);
        }

        public SyncInvoker<AttachEipResponse> AttachEipInvoker(AttachEipRequest attachEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", attachEipRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nodes/{node_id}/bind-eip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachEipRequest);
            return new SyncInvoker<AttachEipResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachEipResponse>);
        }
        
        /// <summary>
        /// 修改实例内网地址
        ///
        /// 修改实例的内网地址
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AttachInternalIpResponse AttachInternalIp(AttachInternalIpRequest attachInternalIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", attachInternalIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-internal-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachInternalIpRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AttachInternalIpResponse>(response);
        }

        public SyncInvoker<AttachInternalIpResponse> AttachInternalIpInvoker(AttachInternalIpRequest attachInternalIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", attachInternalIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-internal-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachInternalIpRequest);
            return new SyncInvoker<AttachInternalIpResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachInternalIpResponse>);
        }
        
        /// <summary>
        /// 批量添加或删除资源标签
        ///
        /// 批量添加或删除指定实例的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchTagActionResponse BatchTagAction(BatchTagActionRequest batchTagActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchTagActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchTagActionResponse>(response);
        }

        public SyncInvoker<BatchTagActionResponse> BatchTagActionInvoker(BatchTagActionRequest batchTagActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchTagActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagActionRequest);
            return new SyncInvoker<BatchTagActionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchTagActionResponse>);
        }
        
        /// <summary>
        /// 解绑弹性公网IP
        ///
        /// 解绑实例下节点已经绑定的弹性公网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelEipResponse CancelEip(CancelEipRequest cancelEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", cancelEipRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nodes/{node_id}/unbind-eip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelEipRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CancelEipResponse>(response);
        }

        public SyncInvoker<CancelEipResponse> CancelEipInvoker(CancelEipRequest cancelEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", cancelEipRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nodes/{node_id}/unbind-eip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelEipRequest);
            return new SyncInvoker<CancelEipResponse>(this, "POST", request, JsonUtils.DeSerialize<CancelEipResponse>);
        }
        
        /// <summary>
        /// 设置可维护时间段
        ///
        /// 修改用户允许启动某项对数据库实例运行有影响的任务的时间范围，例如操作系统升级和数据库软件版本升级的时间窗。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeOpsWindowResponse ChangeOpsWindow(ChangeOpsWindowRequest changeOpsWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeOpsWindowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/maintenance-window", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeOpsWindowRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ChangeOpsWindowResponse>(response);
        }

        public SyncInvoker<ChangeOpsWindowResponse> ChangeOpsWindowInvoker(ChangeOpsWindowRequest changeOpsWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeOpsWindowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/maintenance-window", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeOpsWindowRequest);
            return new SyncInvoker<ChangeOpsWindowResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ChangeOpsWindowResponse>);
        }
        
        /// <summary>
        /// 检查数据库密码
        ///
        /// 检查数据库密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckPasswordResponse CheckPassword(CheckPasswordRequest checkPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", checkPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/check-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkPasswordRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CheckPasswordResponse>(response);
        }

        public SyncInvoker<CheckPasswordResponse> CheckPasswordInvoker(CheckPasswordRequest checkPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", checkPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/check-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkPasswordRequest);
            return new SyncInvoker<CheckPasswordResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CheckPasswordResponse>);
        }
        
        /// <summary>
        /// 检查弱密码
        ///
        /// 检查弱密码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckWeakPasswordResponse CheckWeakPassword(CheckWeakPasswordRequest checkWeakPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/weak-password-verification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkWeakPasswordRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CheckWeakPasswordResponse>(response);
        }

        public SyncInvoker<CheckWeakPasswordResponse> CheckWeakPasswordInvoker(CheckWeakPasswordRequest checkWeakPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/weak-password-verification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkWeakPasswordRequest);
            return new SyncInvoker<CheckWeakPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckWeakPasswordResponse>);
        }
        
        /// <summary>
        /// 参数模板比较
        ///
        /// 比较两个参数模板之间的差异。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CompareConfigurationResponse CompareConfiguration(CompareConfigurationRequest compareConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/comparison", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareConfigurationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CompareConfigurationResponse>(response);
        }

        public SyncInvoker<CompareConfigurationResponse> CompareConfigurationInvoker(CompareConfigurationRequest compareConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/comparison", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareConfigurationRequest);
            return new SyncInvoker<CompareConfigurationResponse>(this, "POST", request, JsonUtils.DeSerialize<CompareConfigurationResponse>);
        }
        
        /// <summary>
        /// 复制参数模板
        ///
        /// 复制参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CopyConfigurationResponse CopyConfiguration(CopyConfigurationRequest copyConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", copyConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyConfigurationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CopyConfigurationResponse>(response);
        }

        public SyncInvoker<CopyConfigurationResponse> CopyConfigurationInvoker(CopyConfigurationRequest copyConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", copyConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyConfigurationRequest);
            return new SyncInvoker<CopyConfigurationResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyConfigurationResponse>);
        }
        
        /// <summary>
        /// 创建参数模板
        ///
        /// 创建参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateConfigurationResponse CreateConfiguration(CreateConfigurationRequest createConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfigurationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateConfigurationResponse>(response);
        }

        public SyncInvoker<CreateConfigurationResponse> CreateConfigurationInvoker(CreateConfigurationRequest createConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfigurationRequest);
            return new SyncInvoker<CreateConfigurationResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateConfigurationResponse>);
        }
        
        /// <summary>
        /// 创建数据库角色
        ///
        /// 创建数据库角色。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDatabaseRoleResponse CreateDatabaseRole(CreateDatabaseRoleRequest createDatabaseRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDatabaseRoleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDatabaseRoleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDatabaseRoleResponse>(response);
        }

        public SyncInvoker<CreateDatabaseRoleResponse> CreateDatabaseRoleInvoker(CreateDatabaseRoleRequest createDatabaseRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDatabaseRoleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDatabaseRoleRequest);
            return new SyncInvoker<CreateDatabaseRoleResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDatabaseRoleResponse>);
        }
        
        /// <summary>
        /// 创建数据库用户
        ///
        /// 创建数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDatabaseUserResponse CreateDatabaseUser(CreateDatabaseUserRequest createDatabaseUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDatabaseUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDatabaseUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDatabaseUserResponse>(response);
        }

        public SyncInvoker<CreateDatabaseUserResponse> CreateDatabaseUserInvoker(CreateDatabaseUserRequest createDatabaseUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDatabaseUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDatabaseUserRequest);
            return new SyncInvoker<CreateDatabaseUserResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDatabaseUserResponse>);
        }
        
        /// <summary>
        /// 创建实例
        ///
        /// 创建文档数据库实例，包括集群实例、副本集实例、以及单节点实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceResponse>(response);
        }

        public SyncInvoker<CreateInstanceResponse> CreateInstanceInvoker(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRequest);
            return new SyncInvoker<CreateInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceResponse>);
        }
        
        /// <summary>
        /// 创建集群的Shard/Config IP
        ///
        /// 创建集群的Shard/Config IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateIpResponse CreateIp(CreateIpRequest createIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/create-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIpRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateIpResponse>(response);
        }

        public SyncInvoker<CreateIpResponse> CreateIpInvoker(CreateIpRequest createIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/create-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIpRequest);
            return new SyncInvoker<CreateIpResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateIpResponse>);
        }
        
        /// <summary>
        /// 创建killOp规则
        ///
        /// 创建killOp规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateKillOpRuleResponse CreateKillOpRule(CreateKillOpRuleRequest createKillOpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createKillOpRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kill-op-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKillOpRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateKillOpRuleResponse>(response);
        }

        public SyncInvoker<CreateKillOpRuleResponse> CreateKillOpRuleInvoker(CreateKillOpRuleRequest createKillOpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createKillOpRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kill-op-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKillOpRuleRequest);
            return new SyncInvoker<CreateKillOpRuleResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateKillOpRuleResponse>);
        }
        
        /// <summary>
        /// 创建手动备份
        ///
        /// 创建数据库实例的手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateManualBackupResponse CreateManualBackup(CreateManualBackupRequest createManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createManualBackupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateManualBackupResponse>(response);
        }

        public SyncInvoker<CreateManualBackupResponse> CreateManualBackupInvoker(CreateManualBackupRequest createManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createManualBackupRequest);
            return new SyncInvoker<CreateManualBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateManualBackupResponse>);
        }
        
        /// <summary>
        /// 删除审计日志
        ///
        /// 删除审计日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAuditLogResponse DeleteAuditLog(DeleteAuditLogRequest deleteAuditLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteAuditLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditLogRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAuditLogResponse>(response);
        }

        public SyncInvoker<DeleteAuditLogResponse> DeleteAuditLogInvoker(DeleteAuditLogRequest deleteAuditLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteAuditLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditLogRequest);
            return new SyncInvoker<DeleteAuditLogResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAuditLogResponse>);
        }
        
        /// <summary>
        /// 删除参数模板
        ///
        /// 删除参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteConfigurationResponse DeleteConfiguration(DeleteConfigurationRequest deleteConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", deleteConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigurationRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteConfigurationResponse>(response);
        }

        public SyncInvoker<DeleteConfigurationResponse> DeleteConfigurationInvoker(DeleteConfigurationRequest deleteConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", deleteConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigurationRequest);
            return new SyncInvoker<DeleteConfigurationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteConfigurationResponse>);
        }
        
        /// <summary>
        /// 删除数据库角色
        ///
        /// 删除数据库角色。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDatabaseRoleResponse DeleteDatabaseRole(DeleteDatabaseRoleRequest deleteDatabaseRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabaseRoleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseRoleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDatabaseRoleResponse>(response);
        }

        public SyncInvoker<DeleteDatabaseRoleResponse> DeleteDatabaseRoleInvoker(DeleteDatabaseRoleRequest deleteDatabaseRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabaseRoleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseRoleRequest);
            return new SyncInvoker<DeleteDatabaseRoleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDatabaseRoleResponse>);
        }
        
        /// <summary>
        /// 删除数据库用户
        ///
        /// 删除数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDatabaseUserResponse DeleteDatabaseUser(DeleteDatabaseUserRequest deleteDatabaseUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabaseUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseUserRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDatabaseUserResponse>(response);
        }

        public SyncInvoker<DeleteDatabaseUserResponse> DeleteDatabaseUserInvoker(DeleteDatabaseUserRequest deleteDatabaseUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabaseUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseUserRequest);
            return new SyncInvoker<DeleteDatabaseUserResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDatabaseUserResponse>);
        }
        
        /// <summary>
        /// 删除实例
        ///
        /// 删除数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInstanceResponse>(response);
        }

        public SyncInvoker<DeleteInstanceResponse> DeleteInstanceInvoker(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            return new SyncInvoker<DeleteInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteInstanceResponse>);
        }
        
        /// <summary>
        /// 删除killOp规则
        ///
        /// 删除killOp规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteKillOpRuleListResponse DeleteKillOpRuleList(DeleteKillOpRuleListRequest deleteKillOpRuleListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteKillOpRuleListRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kill-op-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKillOpRuleListRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteKillOpRuleListResponse>(response);
        }

        public SyncInvoker<DeleteKillOpRuleListResponse> DeleteKillOpRuleListInvoker(DeleteKillOpRuleListRequest deleteKillOpRuleListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteKillOpRuleListRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kill-op-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKillOpRuleListRequest);
            return new SyncInvoker<DeleteKillOpRuleListResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteKillOpRuleListResponse>);
        }
        
        /// <summary>
        /// 解除关联LTS日志流
        ///
        /// 将实例日志与LTS日志流解除关联，后台将取消上传实例日志到的LTS日志流里。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLtsConfigResponse DeleteLtsConfig(DeleteLtsConfigRequest deleteLtsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLtsConfigRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLtsConfigResponse>(response);
        }

        public SyncInvoker<DeleteLtsConfigResponse> DeleteLtsConfigInvoker(DeleteLtsConfigRequest deleteLtsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLtsConfigRequest);
            return new SyncInvoker<DeleteLtsConfigResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLtsConfigResponse>);
        }
        
        /// <summary>
        /// 删除手动备份
        ///
        /// 删除数据库实例的手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteManualBackupResponse DeleteManualBackup(DeleteManualBackupRequest deleteManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteManualBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteManualBackupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteManualBackupResponse>(response);
        }

        public SyncInvoker<DeleteManualBackupResponse> DeleteManualBackupInvoker(DeleteManualBackupRequest deleteManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteManualBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteManualBackupRequest);
            return new SyncInvoker<DeleteManualBackupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteManualBackupResponse>);
        }
        
        /// <summary>
        /// 删除只读节点
        ///
        /// 当副本集添加了只读节点后，需要删除对应的只读节点需要调用此API。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteReadonlyNodeResponse DeleteReadonlyNode(DeleteReadonlyNodeRequest deleteReadonlyNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteReadonlyNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/readonly-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteReadonlyNodeRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteReadonlyNodeResponse>(response);
        }

        public SyncInvoker<DeleteReadonlyNodeResponse> DeleteReadonlyNodeInvoker(DeleteReadonlyNodeRequest deleteReadonlyNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteReadonlyNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/readonly-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteReadonlyNodeRequest);
            return new SyncInvoker<DeleteReadonlyNodeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteReadonlyNodeResponse>);
        }
        
        /// <summary>
        /// 终结实例节点会话
        ///
        /// 终结实例节点会话。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSessionResponse DeleteSession(DeleteSessionRequest deleteSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", deleteSessionRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nodes/{node_id}/session", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSessionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteSessionResponse>(response);
        }

        public SyncInvoker<DeleteSessionResponse> DeleteSessionInvoker(DeleteSessionRequest deleteSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", deleteSessionRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nodes/{node_id}/session", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSessionRequest);
            return new SyncInvoker<DeleteSessionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteSessionResponse>);
        }
        
        /// <summary>
        /// 获取错误日志下载链接
        ///
        /// 获取错误日志下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadErrorlogResponse DownloadErrorlog(DownloadErrorlogRequest downloadErrorlogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", downloadErrorlogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/errorlog-download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadErrorlogRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DownloadErrorlogResponse>(response);
        }

        public SyncInvoker<DownloadErrorlogResponse> DownloadErrorlogInvoker(DownloadErrorlogRequest downloadErrorlogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", downloadErrorlogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/errorlog-download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadErrorlogRequest);
            return new SyncInvoker<DownloadErrorlogResponse>(this, "POST", request, JsonUtils.DeSerialize<DownloadErrorlogResponse>);
        }
        
        /// <summary>
        /// 获取慢日志下载链接
        ///
        /// 获取慢日志下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadSlowlogResponse DownloadSlowlog(DownloadSlowlogRequest downloadSlowlogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", downloadSlowlogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSlowlogRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DownloadSlowlogResponse>(response);
        }

        public SyncInvoker<DownloadSlowlogResponse> DownloadSlowlogInvoker(DownloadSlowlogRequest downloadSlowlogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", downloadSlowlogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSlowlogRequest);
            return new SyncInvoker<DownloadSlowlogResponse>(this, "POST", request, JsonUtils.DeSerialize<DownloadSlowlogResponse>);
        }
        
        /// <summary>
        /// 扩容副本集实例的节点数量
        ///
        /// 扩容指定副本集实例的节点数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExpandReplicasetNodeResponse ExpandReplicasetNode(ExpandReplicasetNodeRequest expandReplicasetNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", expandReplicasetNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replicaset-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandReplicasetNodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExpandReplicasetNodeResponse>(response);
        }

        public SyncInvoker<ExpandReplicasetNodeResponse> ExpandReplicasetNodeInvoker(ExpandReplicasetNodeRequest expandReplicasetNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", expandReplicasetNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replicaset-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandReplicasetNodeRequest);
            return new SyncInvoker<ExpandReplicasetNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<ExpandReplicasetNodeResponse>);
        }
        
        /// <summary>
        /// 查询可应用的实例
        ///
        /// 查询指定参数模板可被应用的实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAppliedInstancesResponse ListAppliedInstances(ListAppliedInstancesRequest listAppliedInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", listAppliedInstancesRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applicable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppliedInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAppliedInstancesResponse>(response);
        }

        public SyncInvoker<ListAppliedInstancesResponse> ListAppliedInstancesInvoker(ListAppliedInstancesRequest listAppliedInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", listAppliedInstancesRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applicable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppliedInstancesRequest);
            return new SyncInvoker<ListAppliedInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppliedInstancesResponse>);
        }
        
        /// <summary>
        /// 获取审计日志下载链接
        ///
        /// 获取审计日志下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditlogLinksResponse ListAuditlogLinks(ListAuditlogLinksRequest listAuditlogLinksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditlogLinksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-links", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditlogLinksRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAuditlogLinksResponse>(response);
        }

        public SyncInvoker<ListAuditlogLinksResponse> ListAuditlogLinksInvoker(ListAuditlogLinksRequest listAuditlogLinksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditlogLinksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-links", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditlogLinksRequest);
            return new SyncInvoker<ListAuditlogLinksResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAuditlogLinksResponse>);
        }
        
        /// <summary>
        /// 获取审计日志列表
        ///
        /// 获取审计日志列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditlogsResponse ListAuditlogs(ListAuditlogsRequest listAuditlogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditlogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditlogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditlogsResponse>(response);
        }

        public SyncInvoker<ListAuditlogsResponse> ListAuditlogsInvoker(ListAuditlogsRequest listAuditlogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditlogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditlogsRequest);
            return new SyncInvoker<ListAuditlogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditlogsResponse>);
        }
        
        /// <summary>
        /// 查询实例可迁移到的可用区
        ///
        /// 查询实例可迁移到的可用区。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAz2MigrateResponse ListAz2Migrate(ListAz2MigrateRequest listAz2MigrateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAz2MigrateRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/migrate/az", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAz2MigrateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAz2MigrateResponse>(response);
        }

        public SyncInvoker<ListAz2MigrateResponse> ListAz2MigrateInvoker(ListAz2MigrateRequest listAz2MigrateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAz2MigrateRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/migrate/az", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAz2MigrateRequest);
            return new SyncInvoker<ListAz2MigrateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAz2MigrateResponse>);
        }
        
        /// <summary>
        /// 查询备份列表
        ///
        /// 根据指定条件查询备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBackupsResponse ListBackups(ListBackupsRequest listBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBackupsResponse>(response);
        }

        public SyncInvoker<ListBackupsResponse> ListBackupsInvoker(ListBackupsRequest listBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupsRequest);
            return new SyncInvoker<ListBackupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBackupsResponse>);
        }
        
        /// <summary>
        /// 获取参数模板列表
        ///
        /// 获取参数模板列表，包括DDS数据库的所有默认参数模板和用户创建的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConfigurationsResponse ListConfigurations(ListConfigurationsRequest listConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListConfigurationsResponse>(response);
        }

        public SyncInvoker<ListConfigurationsResponse> ListConfigurationsInvoker(ListConfigurationsRequest listConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationsRequest);
            return new SyncInvoker<ListConfigurationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigurationsResponse>);
        }
        
        /// <summary>
        /// 查询数据库角色列表
        ///
        /// 查询数据库角色列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDatabaseRolesResponse ListDatabaseRoles(ListDatabaseRolesRequest listDatabaseRolesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabaseRolesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseRolesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDatabaseRolesResponse>(response);
        }

        public SyncInvoker<ListDatabaseRolesResponse> ListDatabaseRolesInvoker(ListDatabaseRolesRequest listDatabaseRolesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabaseRolesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseRolesRequest);
            return new SyncInvoker<ListDatabaseRolesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabaseRolesResponse>);
        }
        
        /// <summary>
        /// 查询数据库用户列表
        ///
        /// 查询数据库用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDatabaseUsersResponse ListDatabaseUsers(ListDatabaseUsersRequest listDatabaseUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabaseUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDatabaseUsersResponse>(response);
        }

        public SyncInvoker<ListDatabaseUsersResponse> ListDatabaseUsersInvoker(ListDatabaseUsersRequest listDatabaseUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabaseUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseUsersRequest);
            return new SyncInvoker<ListDatabaseUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabaseUsersResponse>);
        }
        
        /// <summary>
        /// 查询数据库版本信息
        ///
        /// 查询指定实例类型的数据库版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDatastoreVersionsResponse ListDatastoreVersions(ListDatastoreVersionsRequest listDatastoreVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("datastore_name", listDatastoreVersionsRequest.DatastoreName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores/{datastore_name}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoreVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDatastoreVersionsResponse>(response);
        }

        public SyncInvoker<ListDatastoreVersionsResponse> ListDatastoreVersionsInvoker(ListDatastoreVersionsRequest listDatastoreVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("datastore_name", listDatastoreVersionsRequest.DatastoreName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores/{datastore_name}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoreVersionsRequest);
            return new SyncInvoker<ListDatastoreVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatastoreVersionsResponse>);
        }
        
        /// <summary>
        /// 查询数据库错误日志
        ///
        /// 查询数据库错误信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListErrorLogsResponse ListErrorLogs(ListErrorLogsRequest listErrorLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listErrorLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/errorlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listErrorLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListErrorLogsResponse>(response);
        }

        public SyncInvoker<ListErrorLogsResponse> ListErrorLogsInvoker(ListErrorLogsRequest listErrorLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listErrorLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/errorlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listErrorLogsRequest);
            return new SyncInvoker<ListErrorLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListErrorLogsResponse>);
        }
        
        /// <summary>
        /// 查询数据库规格
        ///
        /// 查询指定条件下的实例规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFlavorInfosResponse ListFlavorInfos(ListFlavorInfosRequest listFlavorInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorInfosRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorInfosResponse>(response);
        }

        public SyncInvoker<ListFlavorInfosResponse> ListFlavorInfosInvoker(ListFlavorInfosRequest listFlavorInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorInfosRequest);
            return new SyncInvoker<ListFlavorInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorInfosResponse>);
        }
        
        /// <summary>
        /// 查询所有实例规格信息
        ///
        /// 查询指定条件下的所有实例规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFlavorsResponse ListFlavors(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }

        public SyncInvoker<ListFlavorsResponse> ListFlavorsInvoker(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            return new SyncInvoker<ListFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询指定实例的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceTagsResponse ListInstanceTags(ListInstanceTagsRequest listInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceTagsResponse>(response);
        }

        public SyncInvoker<ListInstanceTagsResponse> ListInstanceTagsInvoker(ListInstanceTagsRequest listInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTagsRequest);
            return new SyncInvoker<ListInstanceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceTagsResponse>);
        }
        
        /// <summary>
        /// 查询实例列表和详情
        ///
        /// 根据指定条件查询实例列表和详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstancesResponse ListInstances(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesResponse>(response);
        }

        public SyncInvoker<ListInstancesResponse> ListInstancesInvoker(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            return new SyncInvoker<ListInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesResponse>);
        }
        
        /// <summary>
        /// 查询资源实例
        ///
        /// 根据标签查询指定的数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstancesByTagsResponse ListInstancesByTags(ListInstancesByTagsRequest listInstancesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListInstancesByTagsResponse>(response);
        }

        public SyncInvoker<ListInstancesByTagsResponse> ListInstancesByTagsInvoker(ListInstancesByTagsRequest listInstancesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesByTagsRequest);
            return new SyncInvoker<ListInstancesByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInstancesByTagsResponse>);
        }
        
        /// <summary>
        /// 查询LTS日志配置信息
        ///
        /// 查询LTS日志配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLtsConfigsResponse ListLtsConfigs(ListLtsConfigsRequest listLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLtsConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLtsConfigsResponse>(response);
        }

        public SyncInvoker<ListLtsConfigsResponse> ListLtsConfigsInvoker(ListLtsConfigsRequest listLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLtsConfigsRequest);
            return new SyncInvoker<ListLtsConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLtsConfigsResponse>);
        }
        
        /// <summary>
        /// 查询数据库错误日志
        ///
        /// 查询数据库错误日志信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLtsErrorLogsResponse ListLtsErrorLogs(ListLtsErrorLogsRequest listLtsErrorLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listLtsErrorLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/error-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLtsErrorLogsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListLtsErrorLogsResponse>(response);
        }

        public SyncInvoker<ListLtsErrorLogsResponse> ListLtsErrorLogsInvoker(ListLtsErrorLogsRequest listLtsErrorLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listLtsErrorLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/error-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLtsErrorLogsRequest);
            return new SyncInvoker<ListLtsErrorLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLtsErrorLogsResponse>);
        }
        
        /// <summary>
        /// 查询数据库慢日志
        ///
        /// 查询数据库慢日志信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLtsSlowLogsResponse ListLtsSlowLogs(ListLtsSlowLogsRequest listLtsSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listLtsSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLtsSlowLogsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListLtsSlowLogsResponse>(response);
        }

        public SyncInvoker<ListLtsSlowLogsResponse> ListLtsSlowLogsInvoker(ListLtsSlowLogsRequest listLtsSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listLtsSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLtsSlowLogsRequest);
            return new SyncInvoker<ListLtsSlowLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLtsSlowLogsResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询指定project ID下实例的所有标签集合。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectTagsResponse ListProjectTags(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProjectTagsResponse>(response);
        }

        public SyncInvoker<ListProjectTagsResponse> ListProjectTagsInvoker(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            return new SyncInvoker<ListProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectTagsResponse>);
        }
        
        /// <summary>
        /// 查询回收站实例列表
        ///
        /// 查询回收站实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRecycleInstancesResponse ListRecycleInstances(ListRecycleInstancesRequest listRecycleInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/recycle-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecycleInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRecycleInstancesResponse>(response);
        }

        public SyncInvoker<ListRecycleInstancesResponse> ListRecycleInstancesInvoker(ListRecycleInstancesRequest listRecycleInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/recycle-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecycleInstancesRequest);
            return new SyncInvoker<ListRecycleInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecycleInstancesResponse>);
        }
        
        /// <summary>
        /// 获取可恢复的数据库集合列表
        ///
        /// 获取可恢复的数据库集合列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRestoreCollectionsResponse ListRestoreCollections(ListRestoreCollectionsRequest listRestoreCollectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreCollectionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-collection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreCollectionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRestoreCollectionsResponse>(response);
        }

        public SyncInvoker<ListRestoreCollectionsResponse> ListRestoreCollectionsInvoker(ListRestoreCollectionsRequest listRestoreCollectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreCollectionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-collection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreCollectionsRequest);
            return new SyncInvoker<ListRestoreCollectionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestoreCollectionsResponse>);
        }
        
        /// <summary>
        /// 获取可恢复的数据库列表
        ///
        /// 获取可恢复的数据库列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRestoreDatabasesResponse ListRestoreDatabases(ListRestoreDatabasesRequest listRestoreDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreDatabasesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRestoreDatabasesResponse>(response);
        }

        public SyncInvoker<ListRestoreDatabasesResponse> ListRestoreDatabasesInvoker(ListRestoreDatabasesRequest listRestoreDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreDatabasesRequest);
            return new SyncInvoker<ListRestoreDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestoreDatabasesResponse>);
        }
        
        /// <summary>
        /// 查询可恢复的时间段
        ///
        /// 查询实例的可恢复时间段。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRestoreTimesResponse ListRestoreTimes(ListRestoreTimesRequest listRestoreTimesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreTimesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTimesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRestoreTimesResponse>(response);
        }

        public SyncInvoker<ListRestoreTimesResponse> ListRestoreTimesInvoker(ListRestoreTimesRequest listRestoreTimesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreTimesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTimesRequest);
            return new SyncInvoker<ListRestoreTimesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestoreTimesResponse>);
        }
        
        /// <summary>
        /// 查询实例节点会话
        ///
        /// 查询实例节点会话。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSessionsResponse ListSessions(ListSessionsRequest listSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", listSessionsRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nodes/{node_id}/sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSessionsResponse>(response);
        }

        public SyncInvoker<ListSessionsResponse> ListSessionsInvoker(ListSessionsRequest listSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", listSessionsRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nodes/{node_id}/sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionsRequest);
            return new SyncInvoker<ListSessionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSessionsResponse>);
        }
        
        /// <summary>
        /// 查询数据库慢日志
        ///
        /// 查询数据库慢日志信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSlowLogsResponse ListSlowLogs(ListSlowLogsRequest listSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSlowLogsResponse>(response);
        }

        public SyncInvoker<ListSlowLogsResponse> ListSlowLogsInvoker(ListSlowLogsRequest listSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsRequest);
            return new SyncInvoker<ListSlowLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSlowLogsResponse>);
        }
        
        /// <summary>
        /// 获取SSL证书下载地址
        ///
        /// 获取SSL证书下载地址
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSslCertDownloadAddressResponse ListSslCertDownloadAddress(ListSslCertDownloadAddressRequest listSslCertDownloadAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSslCertDownloadAddressRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-cert/download-link", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSslCertDownloadAddressRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSslCertDownloadAddressResponse>(response);
        }

        public SyncInvoker<ListSslCertDownloadAddressResponse> ListSslCertDownloadAddressInvoker(ListSslCertDownloadAddressRequest listSslCertDownloadAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSslCertDownloadAddressRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-cert/download-link", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSslCertDownloadAddressRequest);
            return new SyncInvoker<ListSslCertDownloadAddressResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSslCertDownloadAddressResponse>);
        }
        
        /// <summary>
        /// 查询数据库磁盘类型
        ///
        /// 查询当前区域下的数据库磁盘类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStorageTypeResponse ListStorageType(ListStorageTypeRequest listStorageTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/storage-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageTypeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListStorageTypeResponse>(response);
        }

        public SyncInvoker<ListStorageTypeResponse> ListStorageTypeInvoker(ListStorageTypeRequest listStorageTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/storage-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageTypeRequest);
            return new SyncInvoker<ListStorageTypeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStorageTypeResponse>);
        }
        
        /// <summary>
        /// 查询任务列表和详情
        ///
        /// 根据指定条件查询任务中心中的任务列表和详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTasksResponse ListTasks(ListTasksRequest listTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTasksResponse>(response);
        }

        public SyncInvoker<ListTasksResponse> ListTasksInvoker(ListTasksRequest listTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTasksRequest);
            return new SyncInvoker<ListTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTasksResponse>);
        }
        
        /// <summary>
        /// 实例可用区迁移
        ///
        /// 实例可用区迁移。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public MigrateAzResponse MigrateAz(MigrateAzRequest migrateAzRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", migrateAzRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateAzRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<MigrateAzResponse>(response);
        }

        public SyncInvoker<MigrateAzResponse> MigrateAzInvoker(MigrateAzRequest migrateAzRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", migrateAzRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateAzRequest);
            return new SyncInvoker<MigrateAzResponse>(this, "POST", request, JsonUtils.DeSerialize<MigrateAzResponse>);
        }
        
        /// <summary>
        /// 重置参数模板
        ///
        /// 重置参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetConfigurationResponse ResetConfiguration(ResetConfigurationRequest resetConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", resetConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetConfigurationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ResetConfigurationResponse>(response);
        }

        public SyncInvoker<ResetConfigurationResponse> ResetConfigurationInvoker(ResetConfigurationRequest resetConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", resetConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetConfigurationRequest);
            return new SyncInvoker<ResetConfigurationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetConfigurationResponse>);
        }
        
        /// <summary>
        /// 修改数据库用户密码
        ///
        /// 修改数据库用户密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetPasswordResponse ResetPassword(ResetPasswordRequest resetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/reset-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPasswordRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetPasswordResponse>(response);
        }

        public SyncInvoker<ResetPasswordResponse> ResetPasswordInvoker(ResetPasswordRequest resetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/reset-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPasswordRequest);
            return new SyncInvoker<ResetPasswordResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetPasswordResponse>);
        }
        
        /// <summary>
        /// 变更实例规格
        ///
        /// 变更实例的规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResizeInstanceResponse ResizeInstance(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResizeInstanceResponse>(response);
        }

        public SyncInvoker<ResizeInstanceResponse> ResizeInstanceInvoker(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceRequest);
            return new SyncInvoker<ResizeInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeInstanceResponse>);
        }
        
        /// <summary>
        /// 扩容实例存储容量
        ///
        /// 扩容实例相关的存储容量大小。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResizeInstanceVolumeResponse ResizeInstanceVolume(ResizeInstanceVolumeRequest resizeInstanceVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/enlarge-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceVolumeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResizeInstanceVolumeResponse>(response);
        }

        public SyncInvoker<ResizeInstanceVolumeResponse> ResizeInstanceVolumeInvoker(ResizeInstanceVolumeRequest resizeInstanceVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/enlarge-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceVolumeRequest);
            return new SyncInvoker<ResizeInstanceVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeInstanceVolumeResponse>);
        }
        
        /// <summary>
        /// 重启实例
        ///
        /// 重启实例的数据库服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestartInstanceResponse RestartInstance(RestartInstanceRequest restartInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestartInstanceResponse>(response);
        }

        public SyncInvoker<RestartInstanceResponse> RestartInstanceInvoker(RestartInstanceRequest restartInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartInstanceRequest);
            return new SyncInvoker<RestartInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestartInstanceResponse>);
        }
        
        /// <summary>
        /// 恢复到当前实例
        ///
        /// 恢复到当前实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreInstanceResponse RestoreInstance(RestoreInstanceRequest restoreInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestoreInstanceResponse>(response);
        }

        public SyncInvoker<RestoreInstanceResponse> RestoreInstanceInvoker(RestoreInstanceRequest restoreInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreInstanceRequest);
            return new SyncInvoker<RestoreInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreInstanceResponse>);
        }
        
        /// <summary>
        /// 库表级时间点恢复
        ///
        /// 库表级时间点恢复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreInstanceFromCollectionResponse RestoreInstanceFromCollection(RestoreInstanceFromCollectionRequest restoreInstanceFromCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restoreInstanceFromCollectionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore/collections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreInstanceFromCollectionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestoreInstanceFromCollectionResponse>(response);
        }

        public SyncInvoker<RestoreInstanceFromCollectionResponse> RestoreInstanceFromCollectionInvoker(RestoreInstanceFromCollectionRequest restoreInstanceFromCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restoreInstanceFromCollectionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore/collections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreInstanceFromCollectionRequest);
            return new SyncInvoker<RestoreInstanceFromCollectionResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreInstanceFromCollectionResponse>);
        }
        
        /// <summary>
        /// 恢复到新实例
        ///
        /// 根据备份恢复新实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreNewInstanceResponse RestoreNewInstance(RestoreNewInstanceRequest restoreNewInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreNewInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestoreNewInstanceResponse>(response);
        }

        public SyncInvoker<RestoreNewInstanceResponse> RestoreNewInstanceInvoker(RestoreNewInstanceRequest restoreNewInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreNewInstanceRequest);
            return new SyncInvoker<RestoreNewInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreNewInstanceResponse>);
        }
        
        /// <summary>
        /// 设置审计日志策略
        ///
        /// 设置审计日志策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetAuditlogPolicyResponse SetAuditlogPolicy(SetAuditlogPolicyRequest setAuditlogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setAuditlogPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditlogPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SetAuditlogPolicyResponse>(response);
        }

        public SyncInvoker<SetAuditlogPolicyResponse> SetAuditlogPolicyInvoker(SetAuditlogPolicyRequest setAuditlogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setAuditlogPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditlogPolicyRequest);
            return new SyncInvoker<SetAuditlogPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetAuditlogPolicyResponse>);
        }
        
        /// <summary>
        /// 设置自动备份策略
        ///
        /// 设置自动备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetBackupPolicyResponse SetBackupPolicy(SetBackupPolicyRequest setBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBackupPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetBackupPolicyResponse>(response);
        }

        public SyncInvoker<SetBackupPolicyResponse> SetBackupPolicyInvoker(SetBackupPolicyRequest setBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBackupPolicyRequest);
            return new SyncInvoker<SetBackupPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetBackupPolicyResponse>);
        }
        
        /// <summary>
        /// 设置集群均衡开关
        ///
        /// 设置集群均衡开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetBalancerSwitchResponse SetBalancerSwitch(SetBalancerSwitchRequest setBalancerSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setBalancerSwitchRequest.InstanceId.ToString());
            urlParam.Add("action", setBalancerSwitchRequest.Action.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balancer/{action}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBalancerSwitchRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SetBalancerSwitchResponse>(response);
        }

        public SyncInvoker<SetBalancerSwitchResponse> SetBalancerSwitchInvoker(SetBalancerSwitchRequest setBalancerSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setBalancerSwitchRequest.InstanceId.ToString());
            urlParam.Add("action", setBalancerSwitchRequest.Action.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balancer/{action}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBalancerSwitchRequest);
            return new SyncInvoker<SetBalancerSwitchResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetBalancerSwitchResponse>);
        }
        
        /// <summary>
        /// 设置集群均衡活动时间窗
        ///
        /// 设置集群均衡活动时间窗。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetBalancerWindowResponse SetBalancerWindow(SetBalancerWindowRequest setBalancerWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setBalancerWindowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balancer/active-window", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBalancerWindowRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SetBalancerWindowResponse>(response);
        }

        public SyncInvoker<SetBalancerWindowResponse> SetBalancerWindowInvoker(SetBalancerWindowRequest setBalancerWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setBalancerWindowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balancer/active-window", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBalancerWindowRequest);
            return new SyncInvoker<SetBalancerWindowResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetBalancerWindowResponse>);
        }
        
        /// <summary>
        /// 设置实例回收站策略
        ///
        /// 设置实例回收站策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetRecyclePolicyResponse SetRecyclePolicy(SetRecyclePolicyRequest setRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRecyclePolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetRecyclePolicyResponse>(response);
        }

        public SyncInvoker<SetRecyclePolicyResponse> SetRecyclePolicyInvoker(SetRecyclePolicyRequest setRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRecyclePolicyRequest);
            return new SyncInvoker<SetRecyclePolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetRecyclePolicyResponse>);
        }
        
        /// <summary>
        /// 查询审计日志策略
        ///
        /// 查询审计日志策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAuditlogPolicyResponse ShowAuditlogPolicy(ShowAuditlogPolicyRequest showAuditlogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAuditlogPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditlogPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditlogPolicyResponse>(response);
        }

        public SyncInvoker<ShowAuditlogPolicyResponse> ShowAuditlogPolicyInvoker(ShowAuditlogPolicyRequest showAuditlogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAuditlogPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditlogPolicyRequest);
            return new SyncInvoker<ShowAuditlogPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditlogPolicyResponse>);
        }
        
        /// <summary>
        /// 获取备份下载链接
        ///
        /// 获取备份下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBackupDownloadLinkResponse ShowBackupDownloadLink(ShowBackupDownloadLinkRequest showBackupDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/download-file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupDownloadLinkRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBackupDownloadLinkResponse>(response);
        }

        public SyncInvoker<ShowBackupDownloadLinkResponse> ShowBackupDownloadLinkInvoker(ShowBackupDownloadLinkRequest showBackupDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/download-file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupDownloadLinkRequest);
            return new SyncInvoker<ShowBackupDownloadLinkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackupDownloadLinkResponse>);
        }
        
        /// <summary>
        /// 查询自动备份策略
        ///
        /// 查询自动备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBackupPolicyResponse ShowBackupPolicy(ShowBackupPolicyRequest showBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBackupPolicyResponse>(response);
        }

        public SyncInvoker<ShowBackupPolicyResponse> ShowBackupPolicyInvoker(ShowBackupPolicyRequest showBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupPolicyRequest);
            return new SyncInvoker<ShowBackupPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackupPolicyResponse>);
        }
        
        /// <summary>
        /// 查询副本集跨网段访问配置
        ///
        /// 查询副本集跨网段访问配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowClientNetworkResponse ShowClientNetwork(ShowClientNetworkRequest showClientNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showClientNetworkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/client-network", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClientNetworkRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowClientNetworkResponse>(response);
        }

        public SyncInvoker<ShowClientNetworkResponse> ShowClientNetworkInvoker(ShowClientNetworkRequest showClientNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showClientNetworkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/client-network", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClientNetworkRequest);
            return new SyncInvoker<ShowClientNetworkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClientNetworkResponse>);
        }
        
        /// <summary>
        /// 查询参数模板被应用历史
        ///
        /// 查询参数模板应用历史
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConfigurationAppliedHistoryResponse ShowConfigurationAppliedHistory(ShowConfigurationAppliedHistoryRequest showConfigurationAppliedHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showConfigurationAppliedHistoryRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applied-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationAppliedHistoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigurationAppliedHistoryResponse>(response);
        }

        public SyncInvoker<ShowConfigurationAppliedHistoryResponse> ShowConfigurationAppliedHistoryInvoker(ShowConfigurationAppliedHistoryRequest showConfigurationAppliedHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showConfigurationAppliedHistoryRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applied-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationAppliedHistoryRequest);
            return new SyncInvoker<ShowConfigurationAppliedHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigurationAppliedHistoryResponse>);
        }
        
        /// <summary>
        /// 查询参数模板修改历史
        ///
        /// 查询参数模板修改历史。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConfigurationModifyHistoryResponse ShowConfigurationModifyHistory(ShowConfigurationModifyHistoryRequest showConfigurationModifyHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showConfigurationModifyHistoryRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationModifyHistoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigurationModifyHistoryResponse>(response);
        }

        public SyncInvoker<ShowConfigurationModifyHistoryResponse> ShowConfigurationModifyHistoryInvoker(ShowConfigurationModifyHistoryRequest showConfigurationModifyHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showConfigurationModifyHistoryRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationModifyHistoryRequest);
            return new SyncInvoker<ShowConfigurationModifyHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigurationModifyHistoryResponse>);
        }
        
        /// <summary>
        /// 获取参数模板的详情
        ///
        /// 获取参数模板的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConfigurationParameterResponse ShowConfigurationParameter(ShowConfigurationParameterRequest showConfigurationParameterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showConfigurationParameterRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationParameterRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigurationParameterResponse>(response);
        }

        public SyncInvoker<ShowConfigurationParameterResponse> ShowConfigurationParameterInvoker(ShowConfigurationParameterRequest showConfigurationParameterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showConfigurationParameterRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationParameterRequest);
            return new SyncInvoker<ShowConfigurationParameterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigurationParameterResponse>);
        }
        
        /// <summary>
        /// 查询实例连接数统计信息
        ///
        /// 查询客户端IP访问至DDS数据库实例的连接数统计信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConnectionStatisticsResponse ShowConnectionStatistics(ShowConnectionStatisticsRequest showConnectionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showConnectionStatisticsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/conn-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConnectionStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowConnectionStatisticsResponse>(response);
        }

        public SyncInvoker<ShowConnectionStatisticsResponse> ShowConnectionStatisticsInvoker(ShowConnectionStatisticsRequest showConnectionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showConnectionStatisticsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/conn-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConnectionStatisticsRequest);
            return new SyncInvoker<ShowConnectionStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConnectionStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询实例磁盘信息
        ///
        /// 查询实例磁盘信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDiskUsageResponse ShowDiskUsage(ShowDiskUsageRequest showDiskUsageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showDiskUsageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disk-usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiskUsageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDiskUsageResponse>(response);
        }

        public SyncInvoker<ShowDiskUsageResponse> ShowDiskUsageInvoker(ShowDiskUsageRequest showDiskUsageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showDiskUsageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disk-usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiskUsageRequest);
            return new SyncInvoker<ShowDiskUsageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDiskUsageResponse>);
        }
        
        /// <summary>
        /// 获取指定实例的参数信息
        ///
        /// 获取指定实例的参数，可以是实例，组，节点的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEntityConfigurationResponse ShowEntityConfiguration(ShowEntityConfigurationRequest showEntityConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showEntityConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEntityConfigurationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEntityConfigurationResponse>(response);
        }

        public SyncInvoker<ShowEntityConfigurationResponse> ShowEntityConfigurationInvoker(ShowEntityConfigurationRequest showEntityConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showEntityConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEntityConfigurationRequest);
            return new SyncInvoker<ShowEntityConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEntityConfigurationResponse>);
        }
        
        /// <summary>
        /// 获取DDS任务中心指定ID的任务信息。
        ///
        /// 获取DDS任务中心指定ID的任务信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobDetailResponse ShowJobDetail(ShowJobDetailRequest showJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobDetailResponse>(response);
        }

        public SyncInvoker<ShowJobDetailResponse> ShowJobDetailInvoker(ShowJobDetailRequest showJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            return new SyncInvoker<ShowJobDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobDetailResponse>);
        }
        
        /// <summary>
        /// 获取killOp规则列表
        ///
        /// 获取killOp规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKillOpRuleRuleListResponse ShowKillOpRuleRuleList(ShowKillOpRuleRuleListRequest showKillOpRuleRuleListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showKillOpRuleRuleListRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kill-op-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKillOpRuleRuleListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKillOpRuleRuleListResponse>(response);
        }

        public SyncInvoker<ShowKillOpRuleRuleListResponse> ShowKillOpRuleRuleListInvoker(ShowKillOpRuleRuleListRequest showKillOpRuleRuleListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showKillOpRuleRuleListRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kill-op-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKillOpRuleRuleListRequest);
            return new SyncInvoker<ShowKillOpRuleRuleListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKillOpRuleRuleListResponse>);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// 查询单租户在DDS服务下的资源配额，包括单节点实例配额、副本集实例配额、集群实例配额等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowQuotasResponse ShowQuotas(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }

        public SyncInvoker<ShowQuotasResponse> ShowQuotasInvoker(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            return new SyncInvoker<ShowQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotasResponse>);
        }
        
        /// <summary>
        /// 查询实例回收站策略
        ///
        /// 查询实例回收站策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecyclePolicyResponse ShowRecyclePolicy(ShowRecyclePolicyRequest showRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecyclePolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRecyclePolicyResponse>(response);
        }

        public SyncInvoker<ShowRecyclePolicyResponse> ShowRecyclePolicyInvoker(ShowRecyclePolicyRequest showRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecyclePolicyRequest);
            return new SyncInvoker<ShowRecyclePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecyclePolicyResponse>);
        }
        
        /// <summary>
        /// 查询数据库复制集名称
        ///
        /// 查询数据库复制集名称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowReplSetNameResponse ShowReplSetName(ShowReplSetNameRequest showReplSetNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showReplSetNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replica-set/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplSetNameRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowReplSetNameResponse>(response);
        }

        public SyncInvoker<ShowReplSetNameResponse> ShowReplSetNameInvoker(ShowReplSetNameRequest showReplSetNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showReplSetNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replica-set/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplSetNameRequest);
            return new SyncInvoker<ShowReplSetNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReplSetNameResponse>);
        }
        
        /// <summary>
        /// 查询秒级监控配置
        ///
        /// 查询秒级监控配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSecondLevelMonitoringStatusResponse ShowSecondLevelMonitoringStatus(ShowSecondLevelMonitoringStatusRequest showSecondLevelMonitoringStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSecondLevelMonitoringStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitoring-by-seconds/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecondLevelMonitoringStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSecondLevelMonitoringStatusResponse>(response);
        }

        public SyncInvoker<ShowSecondLevelMonitoringStatusResponse> ShowSecondLevelMonitoringStatusInvoker(ShowSecondLevelMonitoringStatusRequest showSecondLevelMonitoringStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSecondLevelMonitoringStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitoring-by-seconds/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecondLevelMonitoringStatusRequest);
            return new SyncInvoker<ShowSecondLevelMonitoringStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecondLevelMonitoringStatusResponse>);
        }
        
        /// <summary>
        /// 查询集群均衡设置
        ///
        /// 查询集群均衡设置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowShardingBalancerResponse ShowShardingBalancer(ShowShardingBalancerRequest showShardingBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showShardingBalancerRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balancer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showShardingBalancerRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowShardingBalancerResponse>(response);
        }

        public SyncInvoker<ShowShardingBalancerResponse> ShowShardingBalancerInvoker(ShowShardingBalancerRequest showShardingBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showShardingBalancerRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balancer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showShardingBalancerRequest);
            return new SyncInvoker<ShowShardingBalancerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowShardingBalancerResponse>);
        }
        
        /// <summary>
        /// 查询慢日志明文开关
        ///
        /// 查询慢日志明文开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSlowlogDesensitizationSwitchResponse ShowSlowlogDesensitizationSwitch(ShowSlowlogDesensitizationSwitchRequest showSlowlogDesensitizationSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSlowlogDesensitizationSwitchRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-desensitization/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSlowlogDesensitizationSwitchRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSlowlogDesensitizationSwitchResponse>(response);
        }

        public SyncInvoker<ShowSlowlogDesensitizationSwitchResponse> ShowSlowlogDesensitizationSwitchInvoker(ShowSlowlogDesensitizationSwitchRequest showSlowlogDesensitizationSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSlowlogDesensitizationSwitchRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-desensitization/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSlowlogDesensitizationSwitchRequest);
            return new SyncInvoker<ShowSlowlogDesensitizationSwitchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSlowlogDesensitizationSwitchResponse>);
        }
        
        /// <summary>
        /// 查询数据库补丁升级预估时长
        ///
        /// 查询数据库补丁升级预估时长
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUpgradeDurationResponse ShowUpgradeDuration(ShowUpgradeDurationRequest showUpgradeDurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showUpgradeDurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade-duration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeDurationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUpgradeDurationResponse>(response);
        }

        public SyncInvoker<ShowUpgradeDurationResponse> ShowUpgradeDurationInvoker(ShowUpgradeDurationRequest showUpgradeDurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showUpgradeDurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade-duration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeDurationRequest);
            return new SyncInvoker<ShowUpgradeDurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUpgradeDurationResponse>);
        }
        
        /// <summary>
        /// 删除实例的节点
        ///
        /// 删除实例的节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShrinkInstanceNodesResponse ShrinkInstanceNodes(ShrinkInstanceNodesRequest shrinkInstanceNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", shrinkInstanceNodesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", shrinkInstanceNodesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<ShrinkInstanceNodesResponse>(response);
        }

        public SyncInvoker<ShrinkInstanceNodesResponse> ShrinkInstanceNodesInvoker(ShrinkInstanceNodesRequest shrinkInstanceNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", shrinkInstanceNodesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", shrinkInstanceNodesRequest);
            return new SyncInvoker<ShrinkInstanceNodesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<ShrinkInstanceNodesResponse>);
        }
        
        /// <summary>
        /// 停止备份
        ///
        /// 支持紧急情况下停止备份功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopBackupResponse StopBackup(StopBackupRequest stopBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", stopBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBackupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<StopBackupResponse>(response);
        }

        public SyncInvoker<StopBackupResponse> StopBackupInvoker(StopBackupRequest stopBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", stopBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBackupRequest);
            return new SyncInvoker<StopBackupResponse>(this, "PUT", request, JsonUtils.DeSerialize<StopBackupResponse>);
        }
        
        /// <summary>
        /// 应用参数模板
        ///
        /// 指定实例变更参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchConfigurationResponse SwitchConfiguration(SwitchConfigurationRequest switchConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", switchConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SwitchConfigurationResponse>(response);
        }

        public SyncInvoker<SwitchConfigurationResponse> SwitchConfigurationInvoker(SwitchConfigurationRequest switchConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", switchConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchConfigurationRequest);
            return new SyncInvoker<SwitchConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchConfigurationResponse>);
        }
        
        /// <summary>
        /// 强制备节点升主
        ///
        /// 支持副本集、shard和config备节点强制升主。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchInstancePrimaryResponse SwitchInstancePrimary(SwitchInstancePrimaryRequest switchInstancePrimaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchInstancePrimaryRequest.InstanceId.ToString());
            urlParam.Add("node_id", switchInstancePrimaryRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/primary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchInstancePrimaryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SwitchInstancePrimaryResponse>(response);
        }

        public SyncInvoker<SwitchInstancePrimaryResponse> SwitchInstancePrimaryInvoker(SwitchInstancePrimaryRequest switchInstancePrimaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchInstancePrimaryRequest.InstanceId.ToString());
            urlParam.Add("node_id", switchInstancePrimaryRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/primary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchInstancePrimaryRequest);
            return new SyncInvoker<SwitchInstancePrimaryResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SwitchInstancePrimaryResponse>);
        }
        
        /// <summary>
        /// 开启/关闭秒级监控
        ///
        /// 开启或关闭指定实例的秒级监控。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchSecondLevelMonitoringResponse SwitchSecondLevelMonitoring(SwitchSecondLevelMonitoringRequest switchSecondLevelMonitoringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSecondLevelMonitoringRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitoring-by-seconds/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSecondLevelMonitoringRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SwitchSecondLevelMonitoringResponse>(response);
        }

        public SyncInvoker<SwitchSecondLevelMonitoringResponse> SwitchSecondLevelMonitoringInvoker(SwitchSecondLevelMonitoringRequest switchSecondLevelMonitoringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSecondLevelMonitoringRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitoring-by-seconds/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSecondLevelMonitoringRequest);
            return new SyncInvoker<SwitchSecondLevelMonitoringResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SwitchSecondLevelMonitoringResponse>);
        }
        
        /// <summary>
        /// 设置慢日志明文开关
        ///
        /// 设置实例的慢日志明文开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchSlowlogDesensitizationResponse SwitchSlowlogDesensitization(SwitchSlowlogDesensitizationRequest switchSlowlogDesensitizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSlowlogDesensitizationRequest.InstanceId.ToString());
            urlParam.Add("status", switchSlowlogDesensitizationRequest.Status.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-desensitization/{status}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSlowlogDesensitizationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SwitchSlowlogDesensitizationResponse>(response);
        }

        public SyncInvoker<SwitchSlowlogDesensitizationResponse> SwitchSlowlogDesensitizationInvoker(SwitchSlowlogDesensitizationRequest switchSlowlogDesensitizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSlowlogDesensitizationRequest.InstanceId.ToString());
            urlParam.Add("status", switchSlowlogDesensitizationRequest.Status.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-desensitization/{status}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSlowlogDesensitizationRequest);
            return new SyncInvoker<SwitchSlowlogDesensitizationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SwitchSlowlogDesensitizationResponse>);
        }
        
        /// <summary>
        /// 切换SSL开关
        ///
        /// 切换实例的SSL开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchSslResponse SwitchSsl(SwitchSslRequest switchSslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSslRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switch-ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSslRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchSslResponse>(response);
        }

        public SyncInvoker<SwitchSslResponse> SwitchSslInvoker(SwitchSslRequest switchSslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSslRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switch-ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSslRequest);
            return new SyncInvoker<SwitchSslResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchSslResponse>);
        }
        
        /// <summary>
        /// 切换副本集实例的主备节点
        ///
        /// 切换副本集实例下的主备节点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchoverReplicaSetResponse SwitchoverReplicaSet(SwitchoverReplicaSetRequest switchoverReplicaSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchoverReplicaSetRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchoverReplicaSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchoverReplicaSetResponse>(response);
        }

        public SyncInvoker<SwitchoverReplicaSetResponse> SwitchoverReplicaSetInvoker(SwitchoverReplicaSetRequest switchoverReplicaSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchoverReplicaSetRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchoverReplicaSetRequest);
            return new SyncInvoker<SwitchoverReplicaSetResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchoverReplicaSetResponse>);
        }
        
        /// <summary>
        /// 副本集跨网段访问配置。
        ///
        /// 副本集跨网段访问配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateClientNetworkResponse UpdateClientNetwork(UpdateClientNetworkRequest updateClientNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateClientNetworkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/client-network", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClientNetworkRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateClientNetworkResponse>(response);
        }

        public SyncInvoker<UpdateClientNetworkResponse> UpdateClientNetworkInvoker(UpdateClientNetworkRequest updateClientNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateClientNetworkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/client-network", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClientNetworkRequest);
            return new SyncInvoker<UpdateClientNetworkResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateClientNetworkResponse>);
        }
        
        /// <summary>
        /// 修改参数模板
        ///
        /// 修改指定参数模板的参数信息，包括名称、描述、指定参数的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateConfigurationParameterResponse UpdateConfigurationParameter(UpdateConfigurationParameterRequest updateConfigurationParameterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", updateConfigurationParameterRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigurationParameterRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateConfigurationParameterResponse>(response);
        }

        public SyncInvoker<UpdateConfigurationParameterResponse> UpdateConfigurationParameterInvoker(UpdateConfigurationParameterRequest updateConfigurationParameterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", updateConfigurationParameterRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigurationParameterRequest);
            return new SyncInvoker<UpdateConfigurationParameterResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateConfigurationParameterResponse>);
        }
        
        /// <summary>
        /// 修改指定实例的参数
        ///
        /// 修改指定实例的参数，可以是实例，组，节点的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateEntityConfigurationResponse UpdateEntityConfiguration(UpdateEntityConfigurationRequest updateEntityConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateEntityConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEntityConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEntityConfigurationResponse>(response);
        }

        public SyncInvoker<UpdateEntityConfigurationResponse> UpdateEntityConfigurationInvoker(UpdateEntityConfigurationRequest updateEntityConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateEntityConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEntityConfigurationRequest);
            return new SyncInvoker<UpdateEntityConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEntityConfigurationResponse>);
        }
        
        /// <summary>
        /// 修改实例名称
        ///
        /// 修改实例名称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceNameResponse UpdateInstanceName(UpdateInstanceNameRequest updateInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceNameRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceNameResponse>(response);
        }

        public SyncInvoker<UpdateInstanceNameResponse> UpdateInstanceNameInvoker(UpdateInstanceNameRequest updateInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceNameRequest);
            return new SyncInvoker<UpdateInstanceNameResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceNameResponse>);
        }
        
        /// <summary>
        /// 修改数据库端口
        ///
        /// 修改数据库实例的端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstancePortResponse UpdateInstancePort(UpdateInstancePortRequest updateInstancePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstancePortRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstancePortRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateInstancePortResponse>(response);
        }

        public SyncInvoker<UpdateInstancePortResponse> UpdateInstancePortInvoker(UpdateInstancePortRequest updateInstancePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstancePortRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstancePortRequest);
            return new SyncInvoker<UpdateInstancePortResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateInstancePortResponse>);
        }
        
        /// <summary>
        /// 修改实例备注
        ///
        /// 修改实例备注。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceRemarkResponse UpdateInstanceRemark(UpdateInstanceRemarkRequest updateInstanceRemarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceRemarkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/remark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRemarkRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceRemarkResponse>(response);
        }

        public SyncInvoker<UpdateInstanceRemarkResponse> UpdateInstanceRemarkInvoker(UpdateInstanceRemarkRequest updateInstanceRemarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceRemarkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/remark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRemarkRequest);
            return new SyncInvoker<UpdateInstanceRemarkResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceRemarkResponse>);
        }
        
        /// <summary>
        /// 启用/禁用killOp规则
        ///
        /// 启用/禁用killOp规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateKillOpRuleResponse UpdateKillOpRule(UpdateKillOpRuleRequest updateKillOpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateKillOpRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kill-op-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKillOpRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateKillOpRuleResponse>(response);
        }

        public SyncInvoker<UpdateKillOpRuleResponse> UpdateKillOpRuleInvoker(UpdateKillOpRuleRequest updateKillOpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateKillOpRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kill-op-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKillOpRuleRequest);
            return new SyncInvoker<UpdateKillOpRuleResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateKillOpRuleResponse>);
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
        public UpdateLtsConfigResponse UpdateLtsConfig(UpdateLtsConfigRequest updateLtsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLtsConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateLtsConfigResponse>(response);
        }

        public SyncInvoker<UpdateLtsConfigResponse> UpdateLtsConfigInvoker(UpdateLtsConfigRequest updateLtsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLtsConfigRequest);
            return new SyncInvoker<UpdateLtsConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateLtsConfigResponse>);
        }
        
        /// <summary>
        /// 修改数据库复制集名称
        ///
        /// 修改数据库复制集名称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateReplSetNameResponse UpdateReplSetName(UpdateReplSetNameRequest updateReplSetNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateReplSetNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replica-set/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReplSetNameRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateReplSetNameResponse>(response);
        }

        public SyncInvoker<UpdateReplSetNameResponse> UpdateReplSetNameInvoker(UpdateReplSetNameRequest updateReplSetNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateReplSetNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replica-set/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReplSetNameRequest);
            return new SyncInvoker<UpdateReplSetNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateReplSetNameResponse>);
        }
        
        /// <summary>
        /// 变更实例安全组
        ///
        /// 变更实例关联的安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSecurityGroupResponse UpdateSecurityGroup(UpdateSecurityGroupRequest updateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateSecurityGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecurityGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateSecurityGroupResponse>(response);
        }

        public SyncInvoker<UpdateSecurityGroupResponse> UpdateSecurityGroupInvoker(UpdateSecurityGroupRequest updateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateSecurityGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecurityGroupRequest);
            return new SyncInvoker<UpdateSecurityGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 数据库补丁升级
        ///
        /// 升级数据库补丁版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeDatabaseVersionResponse UpgradeDatabaseVersion(UpgradeDatabaseVersionRequest upgradeDatabaseVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeDatabaseVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDatabaseVersionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpgradeDatabaseVersionResponse>(response);
        }

        public SyncInvoker<UpgradeDatabaseVersionResponse> UpgradeDatabaseVersionInvoker(UpgradeDatabaseVersionRequest upgradeDatabaseVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeDatabaseVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDatabaseVersionRequest);
            return new SyncInvoker<UpgradeDatabaseVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeDatabaseVersionResponse>);
        }
        
        /// <summary>
        /// 查询当前支持的API版本信息列表
        ///
        /// 查询当前支持的API版本信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListApiVersionResponse ListApiVersion(ListApiVersionRequest listApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionResponse>(response);
        }

        public SyncInvoker<ListApiVersionResponse> ListApiVersionInvoker(ListApiVersionRequest listApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionRequest);
            return new SyncInvoker<ListApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionResponse>);
        }
        
        /// <summary>
        /// 查询指定API版本信息
        ///
        /// 查询指定API版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowApiVersionResponse ShowApiVersion(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", showApiVersionRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }

        public SyncInvoker<ShowApiVersionResponse> ShowApiVersionInvoker(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", showApiVersionRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            return new SyncInvoker<ShowApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApiVersionResponse>);
        }
        
    }
}