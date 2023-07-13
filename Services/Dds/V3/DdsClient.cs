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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , addReadonlyNodeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/readonly-node",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addReadonlyNodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddReadonlyNodeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , addShardingNodeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/enlarge",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addShardingNodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddShardingNodeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id" , attachEipRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nodes/{node_id}/bind-eip",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachEipRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AttachEipResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , attachInternalIpRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-internal-ip",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachInternalIpRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AttachInternalIpResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , batchTagActionRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagActionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchTagActionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id" , cancelEipRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nodes/{node_id}/unbind-eip",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelEipRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CancelEipResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , changeOpsWindowRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/maintenance-window",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeOpsWindowRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<ChangeOpsWindowResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , checkPasswordRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/check-password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkPasswordRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CheckPasswordResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/weak-password-verification",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkWeakPasswordRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CheckWeakPasswordResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/comparison",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareConfigurationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CompareConfigurationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , copyConfigurationRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/copy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyConfigurationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CopyConfigurationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfigurationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateConfigurationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createDatabaseRoleRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-role",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDatabaseRoleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateDatabaseRoleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createDatabaseUserRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDatabaseUserRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateDatabaseUserResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateInstanceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createIpRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/create-ip",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIpRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateIpResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createManualBackupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateManualBackupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteAuditLogRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuditLogRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteAuditLogResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , deleteConfigurationRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigurationRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteConfigurationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteDatabaseRoleRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-role",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseRoleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteDatabaseRoleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteDatabaseUserRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseUserRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteDatabaseUserResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteInstanceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , deleteManualBackupRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteManualBackupRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteManualBackupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id" , deleteSessionRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nodes/{node_id}/session",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSessionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<DeleteSessionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , downloadErrorlogRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/errorlog-download",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadErrorlogRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DownloadErrorlogResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , downloadSlowlogRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-download",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSlowlogRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DownloadSlowlogResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , expandReplicasetNodeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replicaset-node",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandReplicasetNodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ExpandReplicasetNodeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , listAppliedInstancesRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applicable-instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppliedInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAppliedInstancesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listAuditlogLinksRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-links",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditlogLinksRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListAuditlogLinksResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listAuditlogsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditlogsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAuditlogsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listAz2MigrateRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/migrate/az",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAz2MigrateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAz2MigrateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListBackupsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListConfigurationsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listDatabaseRolesRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseRolesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDatabaseRolesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listDatabaseUsersRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseUsersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDatabaseUsersResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("datastore_name" , listDatastoreVersionsRequest.DatastoreName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores/{datastore_name}/versions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoreVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDatastoreVersionsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listErrorLogsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/errorlog",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listErrorLogsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListErrorLogsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorInfosRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListFlavorInfosResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listInstanceTagsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListInstanceTagsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListInstancesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesByTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListInstancesByTagsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listLtsSlowLogsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/slow-logs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLtsSlowLogsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListLtsSlowLogsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListProjectTagsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/recycle-instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecycleInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRecycleInstancesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listRestoreCollectionsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-collection",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreCollectionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRestoreCollectionsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listRestoreDatabasesRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-database",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreDatabasesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRestoreDatabasesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listRestoreTimesRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-time",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTimesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRestoreTimesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id" , listSessionsRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nodes/{node_id}/sessions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSessionsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listSlowLogsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSlowLogsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listSslCertDownloadAddressRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-cert/download-link",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSslCertDownloadAddressRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSslCertDownloadAddressResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/storage-type",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageTypeRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListStorageTypeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTasksRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTasksResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , migrateAzRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/migrate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateAzRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<MigrateAzResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , resetConfigurationRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/reset",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetConfigurationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            ResetConfigurationResponse resetConfigurationResponse = JsonUtils.DeSerializeNull<ResetConfigurationResponse>(response);
            return resetConfigurationResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resetPasswordRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/reset-password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPasswordRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<ResetPasswordResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resizeInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/resize",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ResizeInstanceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resizeInstanceVolumeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/enlarge-volume",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceVolumeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ResizeInstanceVolumeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , restartInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restart",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RestartInstanceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recovery",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RestoreInstanceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , restoreInstanceFromCollectionRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore/collections",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreInstanceFromCollectionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RestoreInstanceFromCollectionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreNewInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RestoreNewInstanceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , setAuditlogPolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditlogPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<SetAuditlogPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , setBackupPolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBackupPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<SetBackupPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , setBalancerSwitchRequest.InstanceId.ToString());
            urlParam.Add("action" , setBalancerSwitchRequest.Action.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balancer/{action}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBalancerSwitchRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<SetBalancerSwitchResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , setBalancerWindowRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balancer/active-window",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBalancerWindowRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<SetBalancerWindowResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRecyclePolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<SetRecyclePolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showAuditlogPolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditlogPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAuditlogPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/download-file",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupDownloadLinkRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowBackupDownloadLinkResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showBackupPolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowBackupPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , showConfigurationAppliedHistoryRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applied-histories",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationAppliedHistoryRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowConfigurationAppliedHistoryResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , showConfigurationModifyHistoryRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/histories",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationModifyHistoryRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowConfigurationModifyHistoryResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , showConfigurationParameterRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationParameterRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowConfigurationParameterResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showConnectionStatisticsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/conn-statistics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConnectionStatisticsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowConnectionStatisticsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showDiskUsageRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disk-usage",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiskUsageRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDiskUsageResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showEntityConfigurationRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEntityConfigurationRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowEntityConfigurationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowJobDetailResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecyclePolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowRecyclePolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showReplSetNameRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replica-set/name",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplSetNameRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowReplSetNameResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showSecondLevelMonitoringStatusRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitoring-by-seconds/switch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecondLevelMonitoringStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSecondLevelMonitoringStatusResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showShardingBalancerRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balancer",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showShardingBalancerRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowShardingBalancerResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showSlowlogDesensitizationSwitchRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-desensitization/status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSlowlogDesensitizationSwitchRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSlowlogDesensitizationSwitchResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showUpgradeDurationRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade-duration",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeDurationRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowUpgradeDurationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , shrinkInstanceNodesRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", shrinkInstanceNodesRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<ShrinkInstanceNodesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , switchConfigurationRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchConfigurationRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<SwitchConfigurationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , switchSecondLevelMonitoringRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitoring-by-seconds/switch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSecondLevelMonitoringRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<SwitchSecondLevelMonitoringResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , switchSlowlogDesensitizationRequest.InstanceId.ToString());
            urlParam.Add("status" , switchSlowlogDesensitizationRequest.Status.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-desensitization/{status}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSlowlogDesensitizationRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<SwitchSlowlogDesensitizationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , switchSslRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switch-ssl",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSslRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<SwitchSslResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , switchoverReplicaSetRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switchover",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchoverReplicaSetRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<SwitchoverReplicaSetResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateClientNetworkRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/client-network",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClientNetworkRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateClientNetworkResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , updateConfigurationParameterRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigurationParameterRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateConfigurationParameterResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateEntityConfigurationRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEntityConfigurationRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateEntityConfigurationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceNameRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-name",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceNameRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateInstanceNameResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstancePortRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-port",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstancePortRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpdateInstancePortResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceRemarkRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/remark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRemarkRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateInstanceRemarkResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateReplSetNameRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replica-set/name",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReplSetNameRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateReplSetNameResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateSecurityGroupRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-security-group",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecurityGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpdateSecurityGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , upgradeDatabaseVersionRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDatabaseVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpgradeDatabaseVersionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListApiVersionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version" , showApiVersionRequest.Version.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }
        
    }
}