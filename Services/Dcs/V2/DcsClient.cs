using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Dcs.V2.Model;

namespace HuaweiCloud.SDK.Dcs.V2
{
    public partial class DcsClient : Client
    {
        public static ClientBuilder<DcsClient> NewBuilder()
        {
            return new ClientBuilder<DcsClient>();
        }

        
        /// <summary>
        /// 批量添加或删除标签
        /// </summary>
        public BatchCreateOrDeleteDcsTagsResponse BatchCreateOrDeleteDcsTags(BatchCreateOrDeleteDcsTagsRequest batchCreateOrDeleteDcsTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , batchCreateOrDeleteDcsTagsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dcs/{instance_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateOrDeleteDcsTagsRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteDcsTagsResponse>(response);
        }
        
        /// <summary>
        /// 批量删除实例
        /// </summary>
        public BatchDeleteDCSInstancesResponse BatchDeleteDCSInstances(BatchDeleteDCSInstancesRequest batchDeleteDCSInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteDCSInstancesRequest);
            SdkResponse response = DoHttpRequest("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteDCSInstancesResponse>(response);
        }
        
        /// <summary>
        /// 备份指定实例
        /// </summary>
        public CopyInstanceResponse CopyInstance(CopyInstanceRequest copyInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , copyInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyInstanceRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<CopyInstanceResponse>(response);
        }
        
        /// <summary>
        /// 创建缓存实例
        /// </summary>
        public CreateDCSInstanceResponse CreateDCSInstance(CreateDCSInstanceRequest createDCSInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDCSInstanceRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<CreateDCSInstanceResponse>(response);
        }
        
        /// <summary>
        /// 创建数据迁移任务
        /// </summary>
        public CreateMigrationTaskResponse CreateMigrationTask(CreateMigrationTaskRequest createMigrationTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMigrationTaskRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<CreateMigrationTaskResponse>(response);
        }
        
        /// <summary>
        /// 添加副本
        /// </summary>
        public CreateReplicationResponse CreateReplication(CreateReplicationRequest createReplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createReplicationRequest.InstanceId.ToString());
            urlParam.Add("group_id" , createReplicationRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/groups/{group_id}/replications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createReplicationRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerializeNull<CreateReplicationResponse>(response);
        }
        
        /// <summary>
        /// 删除备份文件
        /// </summary>
        public DeleteBackupFileResponse DeleteBackupFile(DeleteBackupFileRequest deleteBackupFileRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , deleteBackupFileRequest.BackupId.ToString());
            urlParam.Add("instance_id" , deleteBackupFileRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups/{backup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteBackupFileRequest);
            SdkResponse response = DoHttpRequest("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteBackupFileResponse>(response);
        }
        
        /// <summary>
        /// 域名摘除IP
        /// </summary>
        public DeleteIpFromDomainNameResponse DeleteIpFromDomainName(DeleteIpFromDomainNameRequest deleteIpFromDomainNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteIpFromDomainNameRequest.InstanceId.ToString());
            urlParam.Add("group_id" , deleteIpFromDomainNameRequest.GroupId.ToString());
            urlParam.Add("node_id" , deleteIpFromDomainNameRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group_id}/replications/{node_id}/remove-ip",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteIpFromDomainNameRequest);
            SdkResponse response = DoHttpRequest("DELETE",request);
            return JsonUtils.DeSerialize<DeleteIpFromDomainNameResponse>(response);
        }
        
        /// <summary>
        /// 删除数据迁移任务
        /// </summary>
        public DeleteMigrationTaskResponse DeleteMigrationTask(DeleteMigrationTaskRequest deleteMigrationTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-tasks/delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteMigrationTaskRequest);
            SdkResponse response = DoHttpRequest("DELETE",request);
            return JsonUtils.DeSerialize<DeleteMigrationTaskResponse>(response);
        }
        
        /// <summary>
        /// 删除副本
        /// </summary>
        public DeleteReplicationResponse DeleteReplication(DeleteReplicationRequest deleteReplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteReplicationRequest.InstanceId.ToString());
            urlParam.Add("group_id" , deleteReplicationRequest.GroupId.ToString());
            urlParam.Add("node_id" , deleteReplicationRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group_id}/replications/{node_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteReplicationRequest);
            SdkResponse response = DoHttpRequest("DELETE",request);
            return JsonUtils.DeSerialize<DeleteReplicationResponse>(response);
        }
        
        /// <summary>
        /// 删除实例
        /// </summary>
        public DeleteSingleDCSInstanceResponse DeleteSingleDCSInstance(DeleteSingleDCSInstanceRequest deleteSingleDCSInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteSingleDCSInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteSingleDCSInstanceRequest);
            SdkResponse response = DoHttpRequest("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSingleDCSInstanceResponse>(response);
        }
        
        /// <summary>
        /// 查询可用区信息
        /// </summary>
        public ListAvailableZonesResponse ListAvailableZones(ListAvailableZonesRequest listAvailableZonesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/available-zones",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listAvailableZonesRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ListAvailableZonesResponse>(response);
        }
        
        /// <summary>
        /// 获取备份文件下载链接
        /// </summary>
        public ListBackupFileLinksResponse ListBackupFileLinks(ListBackupFileLinksRequest listBackupFileLinksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listBackupFileLinksRequest.InstanceId.ToString());
            urlParam.Add("backup_id" , listBackupFileLinksRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups/{backup_id}/links",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listBackupFileLinksRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<ListBackupFileLinksResponse>(response);
        }
        
        /// <summary>
        /// 查询实例备份信息
        /// </summary>
        public ListBackupRecordsResponse ListBackupRecords(ListBackupRecordsRequest listBackupRecordsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listBackupRecordsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listBackupRecordsRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ListBackupRecordsResponse>(response);
        }
        
        /// <summary>
        /// 查询主维度信息列表
        /// </summary>
        public ListCESMonitoredObjectsResponse ListCESMonitoredObjects(ListCESMonitoredObjectsRequest listCESMonitoredObjectsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dims/monitored-objects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listCESMonitoredObjectsRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ListCESMonitoredObjectsResponse>(response);
        }
        
        /// <summary>
        /// 查询实例配置参数
        /// </summary>
        public ListConfigurationsResponse ListConfigurations(ListConfigurationsRequest listConfigurationsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listConfigurationsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listConfigurationsRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ListConfigurationsResponse>(response);
        }
        
        /// <summary>
        /// 查询租户所有标签
        /// </summary>
        public ListDcsTagsOfTenantResponse ListDcsTagsOfTenant(ListDcsTagsOfTenantRequest listDcsTagsOfTenantRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dcs/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listDcsTagsOfTenantRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ListDcsTagsOfTenantResponse>(response);
        }
        
        /// <summary>
        /// 查询产品规格
        /// </summary>
        public ListFlavorsResponse ListFlavors(ListFlavorsRequest listFlavorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listFlavorsRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }
        
        /// <summary>
        /// 查询分片信息
        /// </summary>
        public ListGroupReplicationInfoResponse ListGroupReplicationInfo(ListGroupReplicationInfoRequest listGroupReplicationInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listGroupReplicationInfoRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listGroupReplicationInfoRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ListGroupReplicationInfoResponse>(response);
        }
        
        /// <summary>
        /// 查询维护时间窗时间段
        /// </summary>
        public ListMaintenanceWindowsResponse ListMaintenanceWindows(ListMaintenanceWindowsRequest listMaintenanceWindowsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/instances/maintain-windows",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listMaintenanceWindowsRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ListMaintenanceWindowsResponse>(response);
        }
        
        /// <summary>
        /// 查询迁移任务列表
        /// </summary>
        public ListMigrationTaskResponse ListMigrationTask(ListMigrationTaskRequest listMigrationTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listMigrationTaskRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ListMigrationTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询单个主维度下子维度监控对象列表
        /// </summary>
        public ListMonitoredObjectsOfInstanceResponse ListMonitoredObjectsOfInstance(ListMonitoredObjectsOfInstanceRequest listMonitoredObjectsOfInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listMonitoredObjectsOfInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dims/monitored-objects/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listMonitoredObjectsOfInstanceRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ListMonitoredObjectsOfInstanceResponse>(response);
        }
        
        /// <summary>
        /// 查询实例状态
        /// </summary>
        public ListNumberOfInstancesInDifferentStatusResponse ListNumberOfInstancesInDifferentStatus(ListNumberOfInstancesInDifferentStatusRequest listNumberOfInstancesInDifferentStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listNumberOfInstancesInDifferentStatusRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ListNumberOfInstancesInDifferentStatusResponse>(response);
        }
        
        /// <summary>
        /// 查询实例恢复记录
        /// </summary>
        public ListRestoreRecordsResponse ListRestoreRecords(ListRestoreRecordsRequest listRestoreRecordsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listRestoreRecordsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/restores",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listRestoreRecordsRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ListRestoreRecordsResponse>(response);
        }
        
        /// <summary>
        /// 查询运行中实例的统计信息
        /// </summary>
        public ListStatisticsOfRunningInstancesResponse ListStatisticsOfRunningInstances(ListStatisticsOfRunningInstancesRequest listStatisticsOfRunningInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/statistic",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listStatisticsOfRunningInstancesRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ListStatisticsOfRunningInstancesResponse>(response);
        }
        
        /// <summary>
        /// 重启实例或清空数据
        /// </summary>
        public RestartOrFlushDCSInstancesResponse RestartOrFlushDCSInstances(RestartOrFlushDCSInstancesRequest restartOrFlushDCSInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restartOrFlushDCSInstancesRequest);
            SdkResponse response = DoHttpRequest("PUT",request);
            return JsonUtils.DeSerialize<RestartOrFlushDCSInstancesResponse>(response);
        }
        
        /// <summary>
        /// 恢复指定实例
        /// </summary>
        public RestoreInstanceResponse RestoreInstance(RestoreInstanceRequest restoreInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , restoreInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/restores",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreInstanceRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<RestoreInstanceResponse>(response);
        }
        
        /// <summary>
        /// 查询单个实例标签
        /// </summary>
        public ShowDcsTagsResponse ShowDcsTags(ShowDcsTagsRequest showDcsTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showDcsTagsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showDcsTagsRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ShowDcsTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询迁移任务详情
        /// </summary>
        public ShowMigrationTaskResponse ShowMigrationTask(ShowMigrationTaskRequest showMigrationTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showMigrationTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showMigrationTaskRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ShowMigrationTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询租户配额
        /// </summary>
        public ShowQuotaOfTenantResponse ShowQuotaOfTenant(ShowQuotaOfTenantRequest showQuotaOfTenantRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/quota",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showQuotaOfTenantRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ShowQuotaOfTenantResponse>(response);
        }
        
        /// <summary>
        /// 停止数据迁移任务
        /// </summary>
        public StopMigrationTaskResponse StopMigrationTask(StopMigrationTaskRequest stopMigrationTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , stopMigrationTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/stop",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, stopMigrationTaskRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerialize<StopMigrationTaskResponse>(response);
        }
        
        /// <summary>
        /// 修改实例配置参数
        /// </summary>
        public UpdateConfigurationsResponse UpdateConfigurations(UpdateConfigurationsRequest updateConfigurationsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateConfigurationsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateConfigurationsRequest);
            SdkResponse response = DoHttpRequest("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateConfigurationsResponse>(response);
        }
        
        /// <summary>
        /// 修改实例信息
        /// </summary>
        public UpdateDCSInstanceResponse UpdateDCSInstance(UpdateDCSInstanceRequest updateDCSInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateDCSInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDCSInstanceRequest);
            SdkResponse response = DoHttpRequest("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateDCSInstanceResponse>(response);
        }
        
        /// <summary>
        /// 修改密码
        /// </summary>
        public UpdatePasswordResponse UpdatePassword(UpdatePasswordRequest updatePasswordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updatePasswordRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePasswordRequest);
            SdkResponse response = DoHttpRequest("PUT",request);
            return JsonUtils.DeSerialize<UpdatePasswordResponse>(response);
        }
        
        /// <summary>
        /// 设置备节点优先级
        /// </summary>
        public UpdateSlavePriorityResponse UpdateSlavePriority(UpdateSlavePriorityRequest updateSlavePriorityRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateSlavePriorityRequest.InstanceId.ToString());
            urlParam.Add("group_id" , updateSlavePriorityRequest.GroupId.ToString());
            urlParam.Add("node_id" , updateSlavePriorityRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group_id}/replications/{node_id}/slave-priority",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSlavePriorityRequest);
            SdkResponse response = DoHttpRequest("POST",request);
            return JsonUtils.DeSerializeNull<UpdateSlavePriorityResponse>(response);
        }
        
        /// <summary>
        /// 查询指定实例的IP白名单
        /// </summary>
        public ShowIpWhitelistResponse ShowIpWhitelist(ShowIpWhitelistRequest showIpWhitelistRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showIpWhitelistRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/whitelist",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showIpWhitelistRequest);
            SdkResponse response = DoHttpRequest("GET",request);
            return JsonUtils.DeSerialize<ShowIpWhitelistResponse>(response);
        }
        
        /// <summary>
        /// 设置IP白名单分组
        /// </summary>
        public UpdateIpWhitelistResponse UpdateIpWhitelist(UpdateIpWhitelistRequest updateIpWhitelistRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateIpWhitelistRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/whitelist",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpWhitelistRequest);
            SdkResponse response = DoHttpRequest("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateIpWhitelistResponse>(response);
        }
        
    }
}