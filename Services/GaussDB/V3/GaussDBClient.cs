using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.GaussDB.V3.Model;

namespace HuaweiCloud.SDK.GaussDB.V3
{
    public partial class GaussDBClient : Client
    {
        public static ClientBuilder<GaussDBClient> NewBuilder()
        {
            return new ClientBuilder<GaussDBClient>();
        }

        
        /// <summary>
        /// 授予数据库用户数据库权限
        ///
        /// 授予云数据库 GaussDB(for MySQL)实例数据库用户数据库权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddDatabasePermissionResponse AddDatabasePermission(AddDatabasePermissionRequest addDatabasePermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , addDatabasePermissionRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/privilege",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addDatabasePermissionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddDatabasePermissionResponse>(response);
        }
        
        /// <summary>
        /// 批量添加或删除标签
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchTagActionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchTagActionResponse>(response);
        }
        
        /// <summary>
        /// 解绑弹性公网IP
        ///
        /// 实例解绑弹性公网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelGaussMySqlInstanceEipResponse CancelGaussMySqlInstanceEip(CancelGaussMySqlInstanceEipRequest cancelGaussMySqlInstanceEipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , cancelGaussMySqlInstanceEipRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ips/unbind",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelGaussMySqlInstanceEipRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<CancelGaussMySqlInstanceEipResponse>(response);
        }
        
        /// <summary>
        /// 取消定时任务
        ///
        /// 取消定时任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelScheduleTaskResponse CancelScheduleTask(CancelScheduleTaskRequest cancelScheduleTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/scheduled-jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelScheduleTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<CancelScheduleTaskResponse>(response);
        }
        
        /// <summary>
        /// 变更实例规格
        ///
        /// 变更数据库实例的规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeGaussMySqlInstanceSpecificationResponse ChangeGaussMySqlInstanceSpecification(ChangeGaussMySqlInstanceSpecificationRequest changeGaussMySqlInstanceSpecificationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , changeGaussMySqlInstanceSpecificationRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeGaussMySqlInstanceSpecificationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ChangeGaussMySqlInstanceSpecificationResponse>(response);
        }
        
        /// <summary>
        /// 数据库代理规格变更
        ///
        /// 数据库代理规格变更。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeGaussMySqlProxySpecificationResponse ChangeGaussMySqlProxySpecification(ChangeGaussMySqlProxySpecificationRequest changeGaussMySqlProxySpecificationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , changeGaussMySqlProxySpecificationRequest.InstanceId.ToString());
            urlParam.Add("proxy_id" , changeGaussMySqlProxySpecificationRequest.ProxyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/flavor",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeGaussMySqlProxySpecificationRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<ChangeGaussMySqlProxySpecificationResponse>(response);
        }
        
        /// <summary>
        /// 创建手动备份
        ///
        /// 创建手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGaussMySqlBackupResponse CreateGaussMySqlBackup(CreateGaussMySqlBackupRequest createGaussMySqlBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlBackupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateGaussMySqlBackupResponse>(response);
        }
        
        /// <summary>
        /// 创建参数模板
        ///
        /// 创建参数模板信息，包含参数模板名称、描述、数据库版本信息、参数值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGaussMySqlConfigurationResponse CreateGaussMySqlConfiguration(CreateGaussMySqlConfigurationRequest createGaussMySqlConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlConfigurationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateGaussMySqlConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 创建数据库
        ///
        /// 创建云数据库 GaussDB(for MySQL)实例数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGaussMySqlDatabaseResponse CreateGaussMySqlDatabase(CreateGaussMySqlDatabaseRequest createGaussMySqlDatabaseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createGaussMySqlDatabaseRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlDatabaseRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateGaussMySqlDatabaseResponse>(response);
        }
        
        /// <summary>
        /// 创建数据库用户
        ///
        /// 创建云数据库GaussDB(for MySQL)实例数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGaussMySqlDatabaseUserResponse CreateGaussMySqlDatabaseUser(CreateGaussMySqlDatabaseUserRequest createGaussMySqlDatabaseUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createGaussMySqlDatabaseUserRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlDatabaseUserRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateGaussMySqlDatabaseUserResponse>(response);
        }
        
        /// <summary>
        /// 创建数据库实例
        ///
        /// 创建云数据库GaussDB(for MySQL)实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGaussMySqlInstanceResponse CreateGaussMySqlInstance(CreateGaussMySqlInstanceRequest createGaussMySqlInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateGaussMySqlInstanceResponse>(response);
        }
        
        /// <summary>
        /// 开启数据库代理
        ///
        /// 开启数据库代理，只支持ELB模式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGaussMySqlProxyResponse CreateGaussMySqlProxy(CreateGaussMySqlProxyRequest createGaussMySqlProxyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createGaussMySqlProxyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlProxyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateGaussMySqlProxyResponse>(response);
        }
        
        /// <summary>
        /// 创建只读节点
        ///
        /// 创建只读节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGaussMySqlReadonlyNodeResponse CreateGaussMySqlReadonlyNode(CreateGaussMySqlReadonlyNodeRequest createGaussMySqlReadonlyNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createGaussMySqlReadonlyNodeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/enlarge",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlReadonlyNodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateGaussMySqlReadonlyNodeResponse>(response);
        }
        
        /// <summary>
        /// 申请内网域名
        ///
        /// 申请内网域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGaussMysqlDnsResponse CreateGaussMysqlDns(CreateGaussMysqlDnsRequest createGaussMysqlDnsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createGaussMysqlDnsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dns",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMysqlDnsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateGaussMysqlDnsResponse>(response);
        }
        
        /// <summary>
        /// 删除数据库用户的数据库权限
        ///
        /// 删除云数据库 GaussDB(for MySQL)实例数据库用户的数据库权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDatabasePermissionResponse DeleteDatabasePermission(DeleteDatabasePermissionRequest deleteDatabasePermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteDatabasePermissionRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/privilege",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteDatabasePermissionRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteDatabasePermissionResponse>(response);
        }
        
        /// <summary>
        /// 删除手动备份
        ///
        /// 删除手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGaussMySqlBackupResponse DeleteGaussMySqlBackup(DeleteGaussMySqlBackupRequest deleteGaussMySqlBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , deleteGaussMySqlBackupRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGaussMySqlBackupRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlBackupResponse>(response);
        }
        
        /// <summary>
        /// 删除参数模板
        ///
        /// 删除指定参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGaussMySqlConfigurationResponse DeleteGaussMySqlConfiguration(DeleteGaussMySqlConfigurationRequest deleteGaussMySqlConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id" , deleteGaussMySqlConfigurationRequest.ConfigurationId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGaussMySqlConfigurationRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 删除数据库
        ///
        /// 删除云数据库 GaussDB(for MySQL)实例数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGaussMySqlDatabaseResponse DeleteGaussMySqlDatabase(DeleteGaussMySqlDatabaseRequest deleteGaussMySqlDatabaseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteGaussMySqlDatabaseRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteGaussMySqlDatabaseRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlDatabaseResponse>(response);
        }
        
        /// <summary>
        /// 删除数据库用户
        ///
        /// 删除云数据库 GaussDB(for MySQL)实例数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGaussMySqlDatabaseUserResponse DeleteGaussMySqlDatabaseUser(DeleteGaussMySqlDatabaseUserRequest deleteGaussMySqlDatabaseUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteGaussMySqlDatabaseUserRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteGaussMySqlDatabaseUserRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlDatabaseUserResponse>(response);
        }
        
        /// <summary>
        /// 删除/退订数据库实例
        ///
        /// 删除/退订数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGaussMySqlInstanceResponse DeleteGaussMySqlInstance(DeleteGaussMySqlInstanceRequest deleteGaussMySqlInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteGaussMySqlInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGaussMySqlInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlInstanceResponse>(response);
        }
        
        /// <summary>
        /// 关闭数据库代理
        ///
        /// 关闭数据库代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGaussMySqlProxyResponse DeleteGaussMySqlProxy(DeleteGaussMySqlProxyRequest deleteGaussMySqlProxyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteGaussMySqlProxyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteGaussMySqlProxyRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlProxyResponse>(response);
        }
        
        /// <summary>
        /// 删除/退订只读节点
        ///
        /// 删除/退订实例的只读节点。多可用区模式删除/退订只读节点时，要保证删除/退订后，剩余的只读节点和主节点在不同的可用区中，否则无法删除/退订该只读节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGaussMySqlReadonlyNodeResponse DeleteGaussMySqlReadonlyNode(DeleteGaussMySqlReadonlyNodeRequest deleteGaussMySqlReadonlyNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteGaussMySqlReadonlyNodeRequest.InstanceId.ToString());
            urlParam.Add("node_id" , deleteGaussMySqlReadonlyNodeRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGaussMySqlReadonlyNodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlReadonlyNodeResponse>(response);
        }
        
        /// <summary>
        /// 删除指定任务记录
        ///
        /// 删除指定任务记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTaskRecordResponse DeleteTaskRecord(DeleteTaskRecordRequest deleteTaskRecordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , deleteTaskRecordRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTaskRecordRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeleteTaskRecordResponse deleteTaskRecordResponse = JsonUtils.DeSerializeNull<DeleteTaskRecordResponse>(response);
            return deleteTaskRecordResponse;
        }
        
        /// <summary>
        /// 查询实例是否开启备份加密功能
        ///
        /// 查询实例是否开启备份加密功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribeBackupEncryptStatusResponse DescribeBackupEncryptStatus(DescribeBackupEncryptStatusRequest describeBackupEncryptStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , describeBackupEncryptStatusRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/encryption",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeBackupEncryptStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<DescribeBackupEncryptStatusResponse>(response);
        }
        
        /// <summary>
        /// 包周期存储扩容
        ///
        /// 包周期存储扩容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExpandGaussMySqlInstanceVolumeResponse ExpandGaussMySqlInstanceVolume(ExpandGaussMySqlInstanceVolumeRequest expandGaussMySqlInstanceVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , expandGaussMySqlInstanceVolumeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/volume/extend",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", expandGaussMySqlInstanceVolumeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ExpandGaussMySqlInstanceVolumeResponse>(response);
        }
        
        /// <summary>
        /// 扩容数据库代理节点的数量
        ///
        /// 扩容数据库代理节点的数量。
        /// DeC专属云账号暂不支持数据库代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExpandGaussMySqlProxyResponse ExpandGaussMySqlProxy(ExpandGaussMySqlProxyRequest expandGaussMySqlProxyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , expandGaussMySqlProxyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/enlarge",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", expandGaussMySqlProxyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ExpandGaussMySqlProxyResponse>(response);
        }
        
        /// <summary>
        /// 手动主备倒换
        ///
        /// 用户手动进行主备倒换。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public InvokeGaussMySqlInstanceSwitchOverResponse InvokeGaussMySqlInstanceSwitchOver(InvokeGaussMySqlInstanceSwitchOverRequest invokeGaussMySqlInstanceSwitchOverRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , invokeGaussMySqlInstanceSwitchOverRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switchover",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", invokeGaussMySqlInstanceSwitchOverRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<InvokeGaussMySqlInstanceSwitchOverResponse>(response);
        }
        
        /// <summary>
        /// 获取全量SQL的临时下载链接
        ///
        /// 获取全量SQL的临时下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditLogDownloadLinkResponse ListAuditLogDownloadLink(ListAuditLogDownloadLinkRequest listAuditLogDownloadLinkRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listAuditLogDownloadLinkRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/auditlog/download-link",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditLogDownloadLinkRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAuditLogDownloadLinkResponse>(response);
        }
        
        /// <summary>
        /// 查询参数模板
        ///
        /// 获取参数模板列表，包括所有数据库的默认参数模板和用户创建的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGaussMySqlConfigurationsResponse ListGaussMySqlConfigurations(ListGaussMySqlConfigurationsRequest listGaussMySqlConfigurationsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlConfigurationsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListGaussMySqlConfigurationsResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库列表
        ///
        /// 查询 GaussDB(for MySQL)实例数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGaussMySqlDatabaseResponse ListGaussMySqlDatabase(ListGaussMySqlDatabaseRequest listGaussMySqlDatabaseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listGaussMySqlDatabaseRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlDatabaseRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListGaussMySqlDatabaseResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库可用字符集
        ///
        /// 查询云数据库 GaussDB(for MySQL)实例数据库可用字符集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGaussMySqlDatabaseCharsetsResponse ListGaussMySqlDatabaseCharsets(ListGaussMySqlDatabaseCharsetsRequest listGaussMySqlDatabaseCharsetsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listGaussMySqlDatabaseCharsetsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/charsets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlDatabaseCharsetsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListGaussMySqlDatabaseCharsetsResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库用户
        ///
        /// 查询云数据库 GaussDB(for MySQL)实例数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGaussMySqlDatabaseUserResponse ListGaussMySqlDatabaseUser(ListGaussMySqlDatabaseUserRequest listGaussMySqlDatabaseUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listGaussMySqlDatabaseUserRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlDatabaseUserRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListGaussMySqlDatabaseUserResponse>(response);
        }
        
        /// <summary>
        /// 查询专属资源池列表
        ///
        /// 获取专属资源池列表，包括用户开通的所有专属资源池信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGaussMySqlDedicatedResourcesResponse ListGaussMySqlDedicatedResources(ListGaussMySqlDedicatedResourcesRequest listGaussMySqlDedicatedResourcesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dedicated-resources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlDedicatedResourcesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListGaussMySqlDedicatedResourcesResponse>(response);
        }
        
        /// <summary>
        /// 批量查询实例详情
        ///
        /// 批量查询实例详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGaussMySqlInstanceDetailInfoResponse ListGaussMySqlInstanceDetailInfo(ListGaussMySqlInstanceDetailInfoRequest listGaussMySqlInstanceDetailInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlInstanceDetailInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListGaussMySqlInstanceDetailInfoResponse>(response);
        }
        
        /// <summary>
        /// 查询实例列表
        ///
        /// 根据指定条件查询实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGaussMySqlInstancesResponse ListGaussMySqlInstances(ListGaussMySqlInstancesRequest listGaussMySqlInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListGaussMySqlInstancesResponse>(response);
        }
        
        /// <summary>
        /// 获取即时任务列表
        ///
        /// 获取即时任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListImmediateJobsResponse ListImmediateJobs(ListImmediateJobsRequest listImmediateJobsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/immediate-jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImmediateJobsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListImmediateJobsResponse>(response);
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
        /// 获取错误日志详情列表
        ///
        /// 获取指定实例的错误日志详情列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLtsErrorLogDetailsResponse ListLtsErrorLogDetails(ListLtsErrorLogDetailsRequest listLtsErrorLogDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listLtsErrorLogDetailsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/error-logs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listLtsErrorLogDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListLtsErrorLogDetailsResponse>(response);
        }
        
        /// <summary>
        /// 获取慢日志详情列表
        ///
        /// 获取指定实例的慢日志详情列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLtsSlowlogDetailsResponse ListLtsSlowlogDetails(ListLtsSlowlogDetailsRequest listLtsSlowlogDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listLtsSlowlogDetailsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/slow-logs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listLtsSlowlogDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListLtsSlowlogDetailsResponse>(response);
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
        /// 获取定时任务列表
        ///
        /// 获取定时任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListScheduleJobsResponse ListScheduleJobs(ListScheduleJobsRequest listScheduleJobsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/scheduled-jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduleJobsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListScheduleJobsResponse>(response);
        }
        
        /// <summary>
        /// 打开或关闭备份加密
        ///
        /// 打开或关闭备份加密。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyBackupEncryptStatusResponse ModifyBackupEncryptStatus(ModifyBackupEncryptStatusRequest modifyBackupEncryptStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , modifyBackupEncryptStatusRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/encryption",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyBackupEncryptStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ModifyBackupEncryptStatusResponse>(response);
        }
        
        /// <summary>
        /// 设置读写分离路由模式
        ///
        /// 设置读写分离路由模式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyGaussMySqlProxyRouteModeResponse ModifyGaussMySqlProxyRouteMode(ModifyGaussMySqlProxyRouteModeRequest modifyGaussMySqlProxyRouteModeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , modifyGaussMySqlProxyRouteModeRequest.InstanceId.ToString());
            urlParam.Add("proxy_id" , modifyGaussMySqlProxyRouteModeRequest.ProxyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/route-mode",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyGaussMySqlProxyRouteModeRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<ModifyGaussMySqlProxyRouteModeResponse>(response);
        }
        
        /// <summary>
        /// 修改内网域名
        ///
        /// 修改内网域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyGaussMysqlDnsResponse ModifyGaussMysqlDns(ModifyGaussMysqlDnsRequest modifyGaussMysqlDnsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , modifyGaussMysqlDnsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dns",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyGaussMysqlDnsRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<ModifyGaussMysqlDnsResponse>(response);
        }
        
        /// <summary>
        /// 修改数据库用户密码
        ///
        /// 修改云数据库 GaussDB(for MySQL)实例数据库用户密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetGaussMySqlDatabasePasswordResponse ResetGaussMySqlDatabasePassword(ResetGaussMySqlDatabasePasswordRequest resetGaussMySqlDatabasePasswordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resetGaussMySqlDatabasePasswordRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetGaussMySqlDatabasePasswordRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<ResetGaussMySqlDatabasePasswordResponse>(response);
        }
        
        /// <summary>
        /// 重置数据库密码
        ///
        /// 重置数据库密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetGaussMySqlPasswordResponse ResetGaussMySqlPassword(ResetGaussMySqlPasswordRequest resetGaussMySqlPasswordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resetGaussMySqlPasswordRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetGaussMySqlPasswordRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<ResetGaussMySqlPasswordResponse>(response);
        }
        
        /// <summary>
        /// 重启数据库实例
        ///
        /// 重启数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestartGaussMySqlInstanceResponse RestartGaussMySqlInstance(RestartGaussMySqlInstanceRequest restartGaussMySqlInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , restartGaussMySqlInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restart",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restartGaussMySqlInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RestartGaussMySqlInstanceResponse>(response);
        }
        
        /// <summary>
        /// 节点重启
        ///
        /// 节点重启。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestartGaussMySqlNodeResponse RestartGaussMySqlNode(RestartGaussMySqlNodeRequest restartGaussMySqlNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , restartGaussMySqlNodeRequest.InstanceId.ToString());
            urlParam.Add("node_id" , restartGaussMySqlNodeRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/restart",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restartGaussMySqlNodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RestartGaussMySqlNodeResponse>(response);
        }
        
        /// <summary>
        /// 备份恢复到当前实例或已有实例
        ///
        /// 备份恢复到当前实例或已有实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreOldInstanceResponse RestoreOldInstance(RestoreOldInstanceRequest restoreOldInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/restore",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreOldInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RestoreOldInstanceResponse>(response);
        }
        
        /// <summary>
        /// 设置读写分离权重
        ///
        /// 设置读写分离权重。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetGaussMySqlProxyWeightResponse SetGaussMySqlProxyWeight(SetGaussMySqlProxyWeightRequest setGaussMySqlProxyWeightRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , setGaussMySqlProxyWeightRequest.InstanceId.ToString());
            urlParam.Add("proxy_id" , setGaussMySqlProxyWeightRequest.ProxyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/weight",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setGaussMySqlProxyWeightRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<SetGaussMySqlProxyWeightResponse>(response);
        }
        
        /// <summary>
        /// 设置租户基于企业项目的资源配额
        ///
        /// 设置指定企业项目的资源配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetGaussMySqlQuotasResponse SetGaussMySqlQuotas(SetGaussMySqlQuotasRequest setGaussMySqlQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setGaussMySqlQuotasRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<SetGaussMySqlQuotasResponse>(response);
        }
        
        /// <summary>
        /// 查询全量SQL开关状态
        ///
        /// 查询全量SQL开关状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAuditLogResponse ShowAuditLog(ShowAuditLogRequest showAuditLogRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showAuditLogRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/audit-log/switch-status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditLogRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAuditLogResponse>(response);
        }
        
        /// <summary>
        /// 查询可恢复时间段
        ///
        /// 查询实例的可恢复时间段。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBackupRestoreTimeResponse ShowBackupRestoreTime(ShowBackupRestoreTimeRequest showBackupRestoreTimeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showBackupRestoreTimeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-time",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupRestoreTimeRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowBackupRestoreTimeResponse>(response);
        }
        
        /// <summary>
        /// 查询专属资源信息详情
        ///
        /// 查询专属资源信息详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDedicatedResourceInfoResponse ShowDedicatedResourceInfo(ShowDedicatedResourceInfoRequest showDedicatedResourceInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("dedicated_resource_id" , showDedicatedResourceInfoRequest.DedicatedResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dedicated-resource/{dedicated_resource_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDedicatedResourceInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDedicatedResourceInfoResponse>(response);
        }
        
        /// <summary>
        /// 查询备份列表
        ///
        /// 查询备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlBackupListResponse ShowGaussMySqlBackupList(ShowGaussMySqlBackupListRequest showGaussMySqlBackupListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlBackupListRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowGaussMySqlBackupListResponse>(response);
        }
        
        /// <summary>
        /// 查询自动备份策略
        ///
        /// 查询自动备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlBackupPolicyResponse ShowGaussMySqlBackupPolicy(ShowGaussMySqlBackupPolicyRequest showGaussMySqlBackupPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showGaussMySqlBackupPolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlBackupPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowGaussMySqlBackupPolicyResponse>(response);
        }
        
        /// <summary>
        /// 获取参数模板详情
        ///
        /// 获取指定参数模板的参数信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlConfigurationResponse ShowGaussMySqlConfiguration(ShowGaussMySqlConfigurationRequest showGaussMySqlConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id" , showGaussMySqlConfigurationRequest.ConfigurationId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlConfigurationRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowGaussMySqlConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库引擎的版本
        ///
        /// 获取指定数据库引擎对应的数据库版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlEngineVersionResponse ShowGaussMySqlEngineVersion(ShowGaussMySqlEngineVersionRequest showGaussMySqlEngineVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name" , showGaussMySqlEngineVersionRequest.DatabaseName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores/{database_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlEngineVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowGaussMySqlEngineVersionResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库规格
        ///
        /// 获取指定数据库引擎版本对应的规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlFlavorsResponse ShowGaussMySqlFlavors(ShowGaussMySqlFlavorsRequest showGaussMySqlFlavorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name" , showGaussMySqlFlavorsRequest.DatabaseName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors/{database_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlFlavorsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowGaussMySqlFlavorsResponse>(response);
        }
        
        /// <summary>
        /// 查询实例详情信息
        ///
        /// 查询实例详情信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlInstanceInfoResponse ShowGaussMySqlInstanceInfo(ShowGaussMySqlInstanceInfoRequest showGaussMySqlInstanceInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showGaussMySqlInstanceInfoRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlInstanceInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowGaussMySqlInstanceInfoResponse>(response);
        }
        
        /// <summary>
        /// 获取指定ID的任务信息
        ///
        /// 获取GaussDB(for MySQL)任务中心指定ID的任务信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlJobInfoResponse ShowGaussMySqlJobInfo(ShowGaussMySqlJobInfoRequest showGaussMySqlJobInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlJobInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowGaussMySqlJobInfoResponse>(response);
        }
        
        /// <summary>
        /// 查询租户的实例配额
        ///
        /// 获取指定租户的资源配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlProjectQuotasResponse ShowGaussMySqlProjectQuotas(ShowGaussMySqlProjectQuotasRequest showGaussMySqlProjectQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/project-quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlProjectQuotasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowGaussMySqlProjectQuotasResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库代理规格信息
        ///
        /// 查询数据库代理规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlProxyFlavorsResponse ShowGaussMySqlProxyFlavors(ShowGaussMySqlProxyFlavorsRequest showGaussMySqlProxyFlavorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showGaussMySqlProxyFlavorsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlProxyFlavorsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowGaussMySqlProxyFlavorsResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库代理信息列表
        ///
        /// 查询数据库代理信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlProxyListResponse ShowGaussMySqlProxyList(ShowGaussMySqlProxyListRequest showGaussMySqlProxyListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showGaussMySqlProxyListRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlProxyListRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowGaussMySqlProxyListResponse>(response);
        }
        
        /// <summary>
        /// 查询租户基于企业项目的资源配额
        ///
        /// 获取指定企业项目的资源配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlQuotasResponse ShowGaussMySqlQuotas(ShowGaussMySqlQuotasRequest showGaussMySqlQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlQuotasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowGaussMySqlQuotasResponse>(response);
        }
        
        /// <summary>
        /// 查询实例秒级监控
        ///
        /// 查询实例秒级监控信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceMonitorExtendResponse ShowInstanceMonitorExtend(ShowInstanceMonitorExtendRequest showInstanceMonitorExtendRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showInstanceMonitorExtendRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitor-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceMonitorExtendRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowInstanceMonitorExtendResponse>(response);
        }
        
        /// <summary>
        /// 应用参数模板
        ///
        /// 指定实例变更参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchGaussMySqlConfigurationResponse SwitchGaussMySqlConfiguration(SwitchGaussMySqlConfigurationRequest switchGaussMySqlConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id" , switchGaussMySqlConfigurationRequest.ConfigurationId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}/apply",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchGaussMySqlConfigurationRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<SwitchGaussMySqlConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 开关SSL
        ///
        /// 为实例设置SSL数据加密。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchGaussMySqlInstanceSslResponse SwitchGaussMySqlInstanceSsl(SwitchGaussMySqlInstanceSslRequest switchGaussMySqlInstanceSslRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , switchGaussMySqlInstanceSslRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-option",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchGaussMySqlInstanceSslRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<SwitchGaussMySqlInstanceSslResponse>(response);
        }
        
        /// <summary>
        /// 开启或者关闭全量SQL
        ///
        /// 开启或者关闭全量SQL。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAuditLogResponse UpdateAuditLog(UpdateAuditLogRequest updateAuditLogRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateAuditLogRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/audit-log/switch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditLogRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpdateAuditLogResponse>(response);
        }
        
        /// <summary>
        /// 设置备份策略
        ///
        /// 设置自动备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlBackupPolicyResponse UpdateGaussMySqlBackupPolicy(UpdateGaussMySqlBackupPolicyRequest updateGaussMySqlBackupPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateGaussMySqlBackupPolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy/update",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlBackupPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlBackupPolicyResponse>(response);
        }
        
        /// <summary>
        /// 修改参数模板
        ///
        /// 修改指定参数模板的参数信息，包括名称、描述、指定参数的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlConfigurationResponse UpdateGaussMySqlConfiguration(UpdateGaussMySqlConfigurationRequest updateGaussMySqlConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id" , updateGaussMySqlConfigurationRequest.ConfigurationId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlConfigurationRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 修改数据库备注
        ///
        /// 修改云数据库 GaussDB(for MySQL)实例数据库备注。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlDatabaseCommentResponse UpdateGaussMySqlDatabaseComment(UpdateGaussMySqlDatabaseCommentRequest updateGaussMySqlDatabaseCommentRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateGaussMySqlDatabaseCommentRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/comment",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlDatabaseCommentRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlDatabaseCommentResponse>(response);
        }
        
        /// <summary>
        /// 修改数据库用户备注
        ///
        /// 修改云数据库 GaussDB(for MySQL)实例数据库用户备注。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlDatabaseUserCommentResponse UpdateGaussMySqlDatabaseUserComment(UpdateGaussMySqlDatabaseUserCommentRequest updateGaussMySqlDatabaseUserCommentRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateGaussMySqlDatabaseUserCommentRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/comment",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlDatabaseUserCommentRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlDatabaseUserCommentResponse>(response);
        }
        
        /// <summary>
        /// 修改实例备注
        ///
        /// 修改实例备注。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlInstanceAliasResponse UpdateGaussMySqlInstanceAlias(UpdateGaussMySqlInstanceAliasRequest updateGaussMySqlInstanceAliasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateGaussMySqlInstanceAliasRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/alias",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceAliasRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            UpdateGaussMySqlInstanceAliasResponse updateGaussMySqlInstanceAliasResponse = JsonUtils.DeSerializeNull<UpdateGaussMySqlInstanceAliasResponse>(response);
            return updateGaussMySqlInstanceAliasResponse;
        }
        
        /// <summary>
        /// 绑定弹性公网IP
        ///
        /// 实例绑定弹性公网IP，供外网连接使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlInstanceEipResponse UpdateGaussMySqlInstanceEip(UpdateGaussMySqlInstanceEipRequest updateGaussMySqlInstanceEipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateGaussMySqlInstanceEipRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ips/bind",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceEipRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlInstanceEipResponse>(response);
        }
        
        /// <summary>
        /// 修改内网地址
        ///
        /// 修改实例内网地址。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlInstanceInternalIpResponse UpdateGaussMySqlInstanceInternalIp(UpdateGaussMySqlInstanceInternalIpRequest updateGaussMySqlInstanceInternalIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateGaussMySqlInstanceInternalIpRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/internal-ip",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceInternalIpRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlInstanceInternalIpResponse>(response);
        }
        
        /// <summary>
        /// 修改实例名称
        ///
        /// 修改实例名称。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlInstanceNameResponse UpdateGaussMySqlInstanceName(UpdateGaussMySqlInstanceNameRequest updateGaussMySqlInstanceNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateGaussMySqlInstanceNameRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/name",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceNameRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlInstanceNameResponse>(response);
        }
        
        /// <summary>
        /// 设置可维护时间段
        ///
        /// 设置可维护时间段。建议将可维护时间段设置在业务低峰期，避免业务在维护过程中异常中断。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlInstanceOpsWindowResponse UpdateGaussMySqlInstanceOpsWindow(UpdateGaussMySqlInstanceOpsWindowRequest updateGaussMySqlInstanceOpsWindowRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateGaussMySqlInstanceOpsWindowRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ops-window",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceOpsWindowRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            UpdateGaussMySqlInstanceOpsWindowResponse updateGaussMySqlInstanceOpsWindowResponse = JsonUtils.DeSerializeNull<UpdateGaussMySqlInstanceOpsWindowResponse>(response);
            return updateGaussMySqlInstanceOpsWindowResponse;
        }
        
        /// <summary>
        /// 修改实例端口
        ///
        /// 修改实例数据库端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlInstancePortResponse UpdateGaussMySqlInstancePort(UpdateGaussMySqlInstancePortRequest updateGaussMySqlInstancePortRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateGaussMySqlInstancePortRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstancePortRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlInstancePortResponse>(response);
        }
        
        /// <summary>
        /// 修改安全组
        ///
        /// 修改指定实例安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlInstanceSecurityGroupResponse UpdateGaussMySqlInstanceSecurityGroup(UpdateGaussMySqlInstanceSecurityGroupRequest updateGaussMySqlInstanceSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateGaussMySqlInstanceSecurityGroupRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/security-group",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceSecurityGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlInstanceSecurityGroupResponse>(response);
        }
        
        /// <summary>
        /// 修改租户基于企业项目的资源配额
        ///
        /// 修改指定企业项目的资源配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlQuotasResponse UpdateGaussMySqlQuotas(UpdateGaussMySqlQuotasRequest updateGaussMySqlQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlQuotasRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlQuotasResponse>(response);
        }
        
        /// <summary>
        /// 设置实例秒级监控
        ///
        /// 设置实例秒级监控，包括1秒监控和5秒监控。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceMonitorResponse UpdateInstanceMonitor(UpdateInstanceMonitorRequest updateInstanceMonitorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceMonitorRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitor-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceMonitorRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateInstanceMonitorResponse>(response);
        }
        
        /// <summary>
        /// 更改数据库代理连接池类型
        ///
        /// 更改数据库代理连接池类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProxyConnectionPoolTypeResponse UpdateProxyConnectionPoolType(UpdateProxyConnectionPoolTypeRequest updateProxyConnectionPoolTypeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateProxyConnectionPoolTypeRequest.InstanceId.ToString());
            urlParam.Add("proxy_id" , updateProxyConnectionPoolTypeRequest.ProxyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/connection-pool-type",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProxyConnectionPoolTypeRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateProxyConnectionPoolTypeResponse>(response);
        }
        
        /// <summary>
        /// 修改读写分离端口号
        ///
        /// 修改读写分离端口号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProxyPortResponse UpdateProxyPort(UpdateProxyPortRequest updateProxyPortRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateProxyPortRequest.InstanceId.ToString());
            urlParam.Add("proxy_id" , updateProxyPortRequest.ProxyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/port",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProxyPortRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateProxyPortResponse>(response);
        }
        
        /// <summary>
        /// 修改代理会话一致性
        ///
        /// 修改代理会话一致性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProxySessionConsistenceResponse UpdateProxySessionConsistence(UpdateProxySessionConsistenceRequest updateProxySessionConsistenceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateProxySessionConsistenceRequest.InstanceId.ToString());
            urlParam.Add("proxy_id" , updateProxySessionConsistenceRequest.ProxyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/session-consistence",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProxySessionConsistenceRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateProxySessionConsistenceResponse>(response);
        }
        
        /// <summary>
        /// 设置proxy事务拆分
        ///
        /// 设置proxy事务拆分。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTransactionSplitStatusResponse UpdateTransactionSplitStatus(UpdateTransactionSplitStatusRequest updateTransactionSplitStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateTransactionSplitStatusRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/transaction-split",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTransactionSplitStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpdateTransactionSplitStatusResponse>(response);
        }
        
        /// <summary>
        /// 内核版本升级
        ///
        /// 内核版本升级。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeGaussMySqlInstanceDatabaseResponse UpgradeGaussMySqlInstanceDatabase(UpgradeGaussMySqlInstanceDatabaseRequest upgradeGaussMySqlInstanceDatabaseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , upgradeGaussMySqlInstanceDatabaseRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeGaussMySqlInstanceDatabaseRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpgradeGaussMySqlInstanceDatabaseResponse>(response);
        }
        
        /// <summary>
        /// 删除SQL限流规则
        ///
        /// 删除SQL限流规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSqlFilterRuleResponse DeleteSqlFilterRule(DeleteSqlFilterRuleRequest deleteSqlFilterRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteSqlFilterRuleRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteSqlFilterRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteSqlFilterRuleResponse>(response);
        }
        
        /// <summary>
        /// 设置SQL限流规则
        ///
        /// 设置SQL限流规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetSqlFilterRuleResponse SetSqlFilterRule(SetSqlFilterRuleRequest setSqlFilterRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , setSqlFilterRuleRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setSqlFilterRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<SetSqlFilterRuleResponse>(response);
        }
        
        /// <summary>
        /// 查询SQL限流开关状态
        ///
        /// 查询SQL限流开关状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSqlFilterControlResponse ShowSqlFilterControl(ShowSqlFilterControlRequest showSqlFilterControlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showSqlFilterControlRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/switch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSqlFilterControlRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSqlFilterControlResponse>(response);
        }
        
        /// <summary>
        /// 查询SQL限流规则
        ///
        /// 查询SQL限流规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSqlFilterRuleResponse ShowSqlFilterRule(ShowSqlFilterRuleRequest showSqlFilterRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showSqlFilterRuleRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSqlFilterRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSqlFilterRuleResponse>(response);
        }
        
        /// <summary>
        /// 开启或者关闭SQL限流
        ///
        /// 开启或者关闭SQL限流。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSqlFilterControlResponse UpdateSqlFilterControl(UpdateSqlFilterControlRequest updateSqlFilterControlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateSqlFilterControlRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/switch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSqlFilterControlRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpdateSqlFilterControlResponse>(response);
        }
        
    }
}