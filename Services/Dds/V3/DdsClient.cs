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
        /// 扩容指定集群实例的节点数量
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
        /// 绑定节点的公网IP
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
        /// 修改实例内网IP
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
        /// 批量添加或删除指定实例的标签
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
        /// 节点解绑公网IP
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
        /// 检查数据库用户密码
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
        /// 创建数据库角色
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
        /// 创建文档数据库实例/恢复到新实例，包括集群实例、副本集实例、以及单节点实例。
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
        /// 打开集群的Shard/Config IP开关
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
        /// 创建数据库实例的手动备份
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
        /// 删除数据库实例
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
        /// 删除数据库实例的手动备份
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
        /// 生成审计日志下载链接
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
        /// 根据指定条件查询备份列表
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
        /// 查询数据库角色列表
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
        /// 查询指定条件下的所有实例规格信息
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
        /// 查询指定实例的标签信息
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
        /// 根据指定条件查询实例列表
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
        /// 根据标签查询指定的数据库实例
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
        /// 查询指定project ID下实例的所有标签集合
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
        /// 获取可恢复的数据库集合列表
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
        /// 查询数据库慢日志
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
        /// 查询当前区域下的数据库磁盘类型
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
        /// 修改数据库用户密码
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
        /// 变更实例的规格
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
        /// 扩容实例相关的存储容量大小
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
        /// 重启实例的数据库服务
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
        /// </summary>
        public RestoreInstanceResponse RestoreInstance(RestoreInstanceRequest restoreInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recovery",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<RestoreInstanceResponse>(response);
        }
        
        /// <summary>
        /// 库表级时间点恢复
        /// </summary>
        public RestoreInstanceFromCollectionResponse RestoreInstanceFromCollection(RestoreInstanceFromCollectionRequest restoreInstanceFromCollectionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , restoreInstanceFromCollectionRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore/collections",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreInstanceFromCollectionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<RestoreInstanceFromCollectionResponse>(response);
        }
        
        /// <summary>
        /// 设置审计日志策略
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
        /// 查询审计日志策略
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
        /// 切换mongodb实例的SSL开关
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
        /// 副本集主备倒换
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
        /// 修改实例名称
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
        /// 修改实例端口
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
        /// 修改实例的安全组
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
        /// 查询当前支持的API版本信息列表
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