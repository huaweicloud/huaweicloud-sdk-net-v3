using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Dcs.V2.Model;

namespace HuaweiCloud.SDK.Dcs.V2
{
    public partial class DcsAsyncClient : Client
    {
        public static ClientBuilder<DcsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<DcsAsyncClient>();
        }

        
        /// <summary>
        /// 批量添加或删除标签
        /// </summary>
        public async Task<BatchCreateOrDeleteTagsResponse> BatchCreateOrDeleteTagsAsync(BatchCreateOrDeleteTagsRequest batchCreateOrDeleteTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , batchCreateOrDeleteTagsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dcs/{instance_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateOrDeleteTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteTagsResponse>(response);
        }
        
        /// <summary>
        /// 批量删除实例
        /// </summary>
        public async Task<BatchDeleteInstancesResponse> BatchDeleteInstancesAsync(BatchDeleteInstancesRequest batchDeleteInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteInstancesResponse>(response);
        }
        
        /// <summary>
        /// 批量停止数据迁移任务
        /// </summary>
        public async Task<BatchStopMigrationTasksResponse> BatchStopMigrationTasksAsync(BatchStopMigrationTasksRequest batchStopMigrationTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/batch-stop",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStopMigrationTasksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchStopMigrationTasksResponse>(response);
        }
        
        /// <summary>
        /// 主备切换
        /// </summary>
        public async Task<ChangeMasterStandbyResponse> ChangeMasterStandbyAsync(ChangeMasterStandbyRequest changeMasterStandbyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , changeMasterStandbyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/swap",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeMasterStandbyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<ChangeMasterStandbyResponse>(response);
        }
        
        /// <summary>
        /// 备份指定实例
        /// </summary>
        public async Task<CopyInstanceResponse> CopyInstanceAsync(CopyInstanceRequest copyInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , copyInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CopyInstanceResponse>(response);
        }
        
        /// <summary>
        /// 创建大key分析任务
        /// </summary>
        public async Task<CreateBigkeyScanTaskResponse> CreateBigkeyScanTaskAsync(CreateBigkeyScanTaskRequest createBigkeyScanTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createBigkeyScanTaskRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey-task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBigkeyScanTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateBigkeyScanTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建实例诊断任务
        /// </summary>
        public async Task<CreateDiagnosisTaskResponse> CreateDiagnosisTaskAsync(CreateDiagnosisTaskRequest createDiagnosisTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createDiagnosisTaskRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/diagnosis",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDiagnosisTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDiagnosisTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建热key分析任务
        /// </summary>
        public async Task<CreateHotkeyScanTaskResponse> CreateHotkeyScanTaskAsync(CreateHotkeyScanTaskRequest createHotkeyScanTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createHotkeyScanTaskRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey-task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHotkeyScanTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateHotkeyScanTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建缓存实例
        /// </summary>
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest createInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateInstanceResponse>(response);
        }
        
        /// <summary>
        /// 创建数据迁移任务
        /// </summary>
        public async Task<CreateMigrationTaskResponse> CreateMigrationTaskAsync(CreateMigrationTaskRequest createMigrationTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMigrationTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateMigrationTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建在线数据迁移任务
        /// </summary>
        public async Task<CreateOnlineMigrationTaskResponse> CreateOnlineMigrationTaskAsync(CreateOnlineMigrationTaskRequest createOnlineMigrationTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration/instance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOnlineMigrationTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateOnlineMigrationTaskResponse>(response);
        }
        
        /// <summary>
        /// 采集Redis运行日志
        /// </summary>
        public async Task<CreateRedislogResponse> CreateRedislogAsync(CreateRedislogRequest createRedislogRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createRedislogRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/redislog",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRedislogRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateRedislogResponse>(response);
        }
        
        /// <summary>
        /// 获取日志下载链接
        /// </summary>
        public async Task<CreateRedislogDownloadLinkResponse> CreateRedislogDownloadLinkAsync(CreateRedislogDownloadLinkRequest createRedislogDownloadLinkRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createRedislogDownloadLinkRequest.InstanceId.ToString());
            urlParam.Add("id" , createRedislogDownloadLinkRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/redislog/{id}/links",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRedislogDownloadLinkRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRedislogDownloadLinkResponse>(response);
        }
        
        /// <summary>
        /// 删除后台任务
        /// </summary>
        public async Task<DeleteBackgroundTaskResponse> DeleteBackgroundTaskAsync(DeleteBackgroundTaskRequest deleteBackgroundTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteBackgroundTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id" , deleteBackgroundTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackgroundTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteBackgroundTaskResponse>(response);
        }
        
        /// <summary>
        /// 删除备份文件
        /// </summary>
        public async Task<DeleteBackupFileResponse> DeleteBackupFileAsync(DeleteBackupFileRequest deleteBackupFileRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , deleteBackupFileRequest.BackupId.ToString());
            urlParam.Add("instance_id" , deleteBackupFileRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups/{backup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackupFileRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteBackupFileResponse>(response);
        }
        
        /// <summary>
        /// 删除大key分析记录
        /// </summary>
        public async Task<DeleteBigkeyScanTaskResponse> DeleteBigkeyScanTaskAsync(DeleteBigkeyScanTaskRequest deleteBigkeyScanTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteBigkeyScanTaskRequest.InstanceId.ToString());
            urlParam.Add("bigkey_id" , deleteBigkeyScanTaskRequest.BigkeyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey-task/{bigkey_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBigkeyScanTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteBigkeyScanTaskResponse>(response);
        }
        
        /// <summary>
        /// 删除热key分析任务
        /// </summary>
        public async Task<DeleteHotkeyScanTaskResponse> DeleteHotkeyScanTaskAsync(DeleteHotkeyScanTaskRequest deleteHotkeyScanTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteHotkeyScanTaskRequest.InstanceId.ToString());
            urlParam.Add("hotkey_id" , deleteHotkeyScanTaskRequest.HotkeyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey-task/{hotkey_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHotkeyScanTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteHotkeyScanTaskResponse>(response);
        }
        
        /// <summary>
        /// 域名摘除IP
        /// </summary>
        public async Task<DeleteIpFromDomainNameResponse> DeleteIpFromDomainNameAsync(DeleteIpFromDomainNameRequest deleteIpFromDomainNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteIpFromDomainNameRequest.InstanceId.ToString());
            urlParam.Add("group_id" , deleteIpFromDomainNameRequest.GroupId.ToString());
            urlParam.Add("node_id" , deleteIpFromDomainNameRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group_id}/replications/{node_id}/remove-ip",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpFromDomainNameRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteIpFromDomainNameResponse>(response);
        }
        
        /// <summary>
        /// 删除数据迁移任务
        /// </summary>
        public async Task<DeleteMigrationTaskResponse> DeleteMigrationTaskAsync(DeleteMigrationTaskRequest deleteMigrationTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-tasks/delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteMigrationTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteMigrationTaskResponse>(response);
        }
        
        /// <summary>
        /// 删除实例
        /// </summary>
        public async Task<DeleteSingleInstanceResponse> DeleteSingleInstanceAsync(DeleteSingleInstanceRequest deleteSingleInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteSingleInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSingleInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSingleInstanceResponse>(response);
        }
        
        /// <summary>
        /// 查询可用区信息
        /// </summary>
        public async Task<ListAvailableZonesResponse> ListAvailableZonesAsync(ListAvailableZonesRequest listAvailableZonesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/available-zones",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableZonesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAvailableZonesResponse>(response);
        }
        
        /// <summary>
        /// 查询后台任务列表
        /// </summary>
        public async Task<ListBackgroundTaskResponse> ListBackgroundTaskAsync(ListBackgroundTaskRequest listBackgroundTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listBackgroundTaskRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackgroundTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBackgroundTaskResponse>(response);
        }
        
        /// <summary>
        /// 获取备份文件下载链接
        /// </summary>
        public async Task<ListBackupFileLinksResponse> ListBackupFileLinksAsync(ListBackupFileLinksRequest listBackupFileLinksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listBackupFileLinksRequest.InstanceId.ToString());
            urlParam.Add("backup_id" , listBackupFileLinksRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups/{backup_id}/links",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listBackupFileLinksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListBackupFileLinksResponse>(response);
        }
        
        /// <summary>
        /// 查询实例备份信息
        /// </summary>
        public async Task<ListBackupRecordsResponse> ListBackupRecordsAsync(ListBackupRecordsRequest listBackupRecordsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listBackupRecordsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupRecordsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBackupRecordsResponse>(response);
        }
        
        /// <summary>
        /// 查询大key分析任务列表
        /// </summary>
        public async Task<ListBigkeyScanTasksResponse> ListBigkeyScanTasksAsync(ListBigkeyScanTasksRequest listBigkeyScanTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listBigkeyScanTasksRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBigkeyScanTasksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBigkeyScanTasksResponse>(response);
        }
        
        /// <summary>
        /// 查询实例配置参数
        /// </summary>
        public async Task<ListConfigurationsResponse> ListConfigurationsAsync(ListConfigurationsRequest listConfigurationsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listConfigurationsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListConfigurationsResponse>(response);
        }
        
        /// <summary>
        /// 查询实例诊断任务列表
        /// </summary>
        public async Task<ListDiagnosisTasksResponse> ListDiagnosisTasksAsync(ListDiagnosisTasksRequest listDiagnosisTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listDiagnosisTasksRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/diagnosis",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDiagnosisTasksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDiagnosisTasksResponse>(response);
        }
        
        /// <summary>
        /// 查询产品规格
        /// </summary>
        public async Task<ListFlavorsResponse> ListFlavorsAsync(ListFlavorsRequest listFlavorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }
        
        /// <summary>
        /// 查询分片信息
        /// </summary>
        public async Task<ListGroupReplicationInfoResponse> ListGroupReplicationInfoAsync(ListGroupReplicationInfoRequest listGroupReplicationInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listGroupReplicationInfoRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupReplicationInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListGroupReplicationInfoResponse>(response);
        }
        
        /// <summary>
        /// 查询热key分析任务列表
        /// </summary>
        public async Task<ListHotKeyScanTasksResponse> ListHotKeyScanTasksAsync(ListHotKeyScanTasksRequest listHotKeyScanTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listHotKeyScanTasksRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHotKeyScanTasksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListHotKeyScanTasksResponse>(response);
        }
        
        /// <summary>
        /// 查询所有实例列表
        /// </summary>
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest listInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询维护时间窗时间段
        /// </summary>
        public async Task<ListMaintenanceWindowsResponse> ListMaintenanceWindowsAsync(ListMaintenanceWindowsRequest listMaintenanceWindowsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/instances/maintain-windows",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMaintenanceWindowsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMaintenanceWindowsResponse>(response);
        }
        
        /// <summary>
        /// 查询迁移任务列表
        /// </summary>
        public async Task<ListMigrationTaskResponse> ListMigrationTaskAsync(ListMigrationTaskRequest listMigrationTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMigrationTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMigrationTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询主维度信息列表
        /// </summary>
        public async Task<ListMonitoredObjectsResponse> ListMonitoredObjectsAsync(ListMonitoredObjectsRequest listMonitoredObjectsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dims/monitored-objects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMonitoredObjectsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMonitoredObjectsResponse>(response);
        }
        
        /// <summary>
        /// 查询单个主维度下子维度监控对象列表
        /// </summary>
        public async Task<ListMonitoredObjectsOfInstanceResponse> ListMonitoredObjectsOfInstanceAsync(ListMonitoredObjectsOfInstanceRequest listMonitoredObjectsOfInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listMonitoredObjectsOfInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dims/monitored-objects/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMonitoredObjectsOfInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMonitoredObjectsOfInstanceResponse>(response);
        }
        
        /// <summary>
        /// 查询实例状态
        /// </summary>
        public async Task<ListNumberOfInstancesInDifferentStatusResponse> ListNumberOfInstancesInDifferentStatusAsync(ListNumberOfInstancesInDifferentStatusRequest listNumberOfInstancesInDifferentStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNumberOfInstancesInDifferentStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListNumberOfInstancesInDifferentStatusResponse>(response);
        }
        
        /// <summary>
        /// 查询Redis运行日志列表
        /// </summary>
        public async Task<ListRedislogResponse> ListRedislogAsync(ListRedislogRequest listRedislogRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listRedislogRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/redislog",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRedislogRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRedislogResponse>(response);
        }
        
        /// <summary>
        /// 查询实例恢复记录
        /// </summary>
        public async Task<ListRestoreRecordsResponse> ListRestoreRecordsAsync(ListRestoreRecordsRequest listRestoreRecordsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listRestoreRecordsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/restores",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreRecordsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRestoreRecordsResponse>(response);
        }
        
        /// <summary>
        /// 查询慢日志
        /// </summary>
        public async Task<ListSlowlogResponse> ListSlowlogAsync(ListSlowlogRequest listSlowlogRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listSlowlogRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/slowlog",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowlogRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSlowlogResponse>(response);
        }
        
        /// <summary>
        /// 查询运行中实例的统计信息
        /// </summary>
        public async Task<ListStatisticsOfRunningInstancesResponse> ListStatisticsOfRunningInstancesAsync(ListStatisticsOfRunningInstancesRequest listStatisticsOfRunningInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/statistic",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStatisticsOfRunningInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListStatisticsOfRunningInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询租户所有标签
        /// </summary>
        public async Task<ListTagsOfTenantResponse> ListTagsOfTenantAsync(ListTagsOfTenantRequest listTagsOfTenantRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dcs/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsOfTenantRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTagsOfTenantResponse>(response);
        }
        
        /// <summary>
        /// 变更实例规格
        /// </summary>
        public async Task<ResizeInstanceResponse> ResizeInstanceAsync(ResizeInstanceRequest resizeInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resizeInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/resize",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<ResizeInstanceResponse>(response);
        }
        
        /// <summary>
        /// 重启实例或清空数据
        /// </summary>
        public async Task<RestartOrFlushInstancesResponse> RestartOrFlushInstancesAsync(RestartOrFlushInstancesRequest restartOrFlushInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restartOrFlushInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<RestartOrFlushInstancesResponse>(response);
        }
        
        /// <summary>
        /// 恢复指定实例
        /// </summary>
        public async Task<RestoreInstanceResponse> RestoreInstanceAsync(RestoreInstanceRequest restoreInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , restoreInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/restores",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RestoreInstanceResponse>(response);
        }
        
        /// <summary>
        /// 配置在线数据迁移任务
        /// </summary>
        public async Task<SetOnlineMigrationTaskResponse> SetOnlineMigrationTaskAsync(SetOnlineMigrationTaskRequest setOnlineMigrationTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , setOnlineMigrationTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration/{task_id}/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setOnlineMigrationTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<SetOnlineMigrationTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询大key自动分析配置
        /// </summary>
        public async Task<ShowBigkeyAutoscanConfigResponse> ShowBigkeyAutoscanConfigAsync(ShowBigkeyAutoscanConfigRequest showBigkeyAutoscanConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showBigkeyAutoscanConfigRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey/autoscan",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBigkeyAutoscanConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBigkeyAutoscanConfigResponse>(response);
        }
        
        /// <summary>
        /// 查询大key分析详情
        /// </summary>
        public async Task<ShowBigkeyScanTaskDetailsResponse> ShowBigkeyScanTaskDetailsAsync(ShowBigkeyScanTaskDetailsRequest showBigkeyScanTaskDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showBigkeyScanTaskDetailsRequest.InstanceId.ToString());
            urlParam.Add("bigkey_id" , showBigkeyScanTaskDetailsRequest.BigkeyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey-task/{bigkey_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBigkeyScanTaskDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBigkeyScanTaskDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询指定诊断报告
        /// </summary>
        public async Task<ShowDiagnosisTaskDetailsResponse> ShowDiagnosisTaskDetailsAsync(ShowDiagnosisTaskDetailsRequest showDiagnosisTaskDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("report_id" , showDiagnosisTaskDetailsRequest.ReportId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/diagnosis/{report_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiagnosisTaskDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDiagnosisTaskDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询热key自动分析配置
        /// </summary>
        public async Task<ShowHotkeyAutoscanConfigResponse> ShowHotkeyAutoscanConfigAsync(ShowHotkeyAutoscanConfigRequest showHotkeyAutoscanConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showHotkeyAutoscanConfigRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey/autoscan",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotkeyAutoscanConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowHotkeyAutoscanConfigResponse>(response);
        }
        
        /// <summary>
        /// 查询热key分析详情
        /// </summary>
        public async Task<ShowHotkeyTaskDetailsResponse> ShowHotkeyTaskDetailsAsync(ShowHotkeyTaskDetailsRequest showHotkeyTaskDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showHotkeyTaskDetailsRequest.InstanceId.ToString());
            urlParam.Add("hotkey_id" , showHotkeyTaskDetailsRequest.HotkeyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey-task/{hotkey_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotkeyTaskDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowHotkeyTaskDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询指定实例
        /// </summary>
        public async Task<ShowInstanceResponse> ShowInstanceAsync(ShowInstanceRequest showInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowInstanceResponse>(response);
        }
        
        /// <summary>
        /// 查询迁移任务详情
        /// </summary>
        public async Task<ShowMigrationTaskResponse> ShowMigrationTaskAsync(ShowMigrationTaskRequest showMigrationTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showMigrationTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMigrationTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMigrationTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询在线迁移进度明细
        /// </summary>
        public async Task<ShowMigrationTaskStatsResponse> ShowMigrationTaskStatsAsync(ShowMigrationTaskStatsRequest showMigrationTaskStatsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showMigrationTaskStatsRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/stats",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMigrationTaskStatsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMigrationTaskStatsResponse>(response);
        }
        
        /// <summary>
        /// 查询租户配额
        /// </summary>
        public async Task<ShowQuotaOfTenantResponse> ShowQuotaOfTenantAsync(ShowQuotaOfTenantRequest showQuotaOfTenantRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/quota",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaOfTenantRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotaOfTenantResponse>(response);
        }
        
        /// <summary>
        /// 查询单个实例标签
        /// </summary>
        public async Task<ShowTagsResponse> ShowTagsAsync(ShowTagsRequest showTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showTagsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTagsResponse>(response);
        }
        
        /// <summary>
        /// 停止数据迁移任务
        /// </summary>
        public async Task<StopMigrationTaskResponse> StopMigrationTaskAsync(StopMigrationTaskRequest stopMigrationTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , stopMigrationTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/stop",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopMigrationTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<StopMigrationTaskResponse>(response);
        }
        
        /// <summary>
        /// 同步停止数据迁移任务
        /// </summary>
        public async Task<StopMigrationTaskSyncResponse> StopMigrationTaskSyncAsync(StopMigrationTaskSyncRequest stopMigrationTaskSyncRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , stopMigrationTaskSyncRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/sync-stop",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopMigrationTaskSyncRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<StopMigrationTaskSyncResponse>(response);
        }
        
        /// <summary>
        /// 设置大key自动分析配置
        /// </summary>
        public async Task<UpdateBigkeyAutoscanConfigResponse> UpdateBigkeyAutoscanConfigAsync(UpdateBigkeyAutoscanConfigRequest updateBigkeyAutoscanConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateBigkeyAutoscanConfigRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey/autoscan",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBigkeyAutoscanConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateBigkeyAutoscanConfigResponse>(response);
        }
        
        /// <summary>
        /// 修改实例配置参数
        /// </summary>
        public async Task<UpdateConfigurationsResponse> UpdateConfigurationsAsync(UpdateConfigurationsRequest updateConfigurationsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateConfigurationsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateConfigurationsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateConfigurationsResponse>(response);
        }
        
        /// <summary>
        /// 设置热key自动分析配置
        /// </summary>
        public async Task<UpdateHotkeyAutoScanConfigResponse> UpdateHotkeyAutoScanConfigAsync(UpdateHotkeyAutoScanConfigRequest updateHotkeyAutoScanConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateHotkeyAutoScanConfigRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey/autoscan",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateHotkeyAutoScanConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateHotkeyAutoScanConfigResponse>(response);
        }
        
        /// <summary>
        /// 修改实例信息
        /// </summary>
        public async Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest updateInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateInstanceResponse>(response);
        }
        
        /// <summary>
        /// 修改密码
        /// </summary>
        public async Task<UpdatePasswordResponse> UpdatePasswordAsync(UpdatePasswordRequest updatePasswordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updatePasswordRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePasswordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePasswordResponse>(response);
        }
        
        /// <summary>
        /// 设置备节点优先级
        /// </summary>
        public async Task<UpdateSlavePriorityResponse> UpdateSlavePriorityAsync(UpdateSlavePriorityRequest updateSlavePriorityRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateSlavePriorityRequest.InstanceId.ToString());
            urlParam.Add("group_id" , updateSlavePriorityRequest.GroupId.ToString());
            urlParam.Add("node_id" , updateSlavePriorityRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group_id}/replications/{node_id}/slave-priority",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSlavePriorityRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateSlavePriorityResponse>(response);
        }
        
        /// <summary>
        /// 查询指定实例的IP白名单
        /// </summary>
        public async Task<ShowIpWhitelistResponse> ShowIpWhitelistAsync(ShowIpWhitelistRequest showIpWhitelistRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showIpWhitelistRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/whitelist",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpWhitelistRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowIpWhitelistResponse>(response);
        }
        
        /// <summary>
        /// 设置IP白名单分组
        /// </summary>
        public async Task<UpdateIpWhitelistResponse> UpdateIpWhitelistAsync(UpdateIpWhitelistRequest updateIpWhitelistRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateIpWhitelistRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/whitelist",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpWhitelistRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateIpWhitelistResponse>(response);
        }
        
    }
}