using System;
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
        ///
        /// 为指定实例批量添加标签，或批量删除标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 批量删除多个缓存实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 批量查询实例节点信息
        ///
        /// 批量查询指定项目所有实例的节点信息、有效实例个数及节点个数。
        /// 创建中实例不返回节点信息。
        /// 仅支持Redis4.0和Redis5.0实例查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchShowNodesInformationResponse> BatchShowNodesInformationAsync(BatchShowNodesInformationRequest batchShowNodesInformationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances-logical-nodes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowNodesInformationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<BatchShowNodesInformationResponse>(response);
        }
        
        /// <summary>
        /// 批量停止数据迁移任务
        ///
        /// 批量停止数据迁移任务，接口响应成功，仅表示下发任务成功。查询到迁移任务状态为TERMINATED时，即停止成功。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 切换实例主备节点，只有主备实例支持该操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 数据迁移配置页实例连接测试
        ///
        /// 数据迁移配置页实例连接测试
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckMigrationConnectivityResponse> CheckMigrationConnectivityAsync(CheckMigrationConnectivityRequest checkMigrationConnectivityRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , checkMigrationConnectivityRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration/{task_id}/connectivity",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkMigrationConnectivityRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            CheckMigrationConnectivityResponse checkMigrationConnectivityResponse = JsonUtils.DeSerializeNull<CheckMigrationConnectivityResponse>(response);
            return checkMigrationConnectivityResponse;
        }
        
        /// <summary>
        /// 备份指定实例
        ///
        /// 备份指定的缓存实例。
        /// &gt; 只有主备和集群类型的缓存实例支持备份恢复操作，单机实例不支持备份恢复操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 创建ACL账号
        ///
        /// \&quot;为redis4.0/5.0实例（Cluster集群实例除外）创建权限访问账号，包含读写和只读权限。
        /// 如果实例默认账号已开启免密访问，您创建的普通账号不能使用，如需使用普通账号请先关闭默认账号的免密访问。
        /// 单机、主备实例默认账号的密码不能带有冒号(:)，否则无法创建普通账号。\&quot;
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAclAccountResponse> CreateAclAccountAsync(CreateAclAccountRequest createAclAccountRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createAclAccountRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAclAccountRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateAclAccountResponse>(response);
        }
        
        /// <summary>
        /// 创建过期key扫描任务
        ///
        /// 创建过期key扫描任务（Redis 3.0 不支持过期key扫描）。
        /// 过期key扫描会对键空间进行Redis的scan扫描，释放内存中已过期但是由于惰性删除机制而没有释放的内存空间。
        /// 过期key扫描在主节点上执行，会对实例性能有一定的影响，建议不要在业务高峰期进行。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAutoExpireScanTaskResponse> CreateAutoExpireScanTaskAsync(CreateAutoExpireScanTaskRequest createAutoExpireScanTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createAutoExpireScanTaskRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/scan-expire-keys-task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutoExpireScanTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAutoExpireScanTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建大key分析任务
        ///
        /// 为Redis实例创建大key分析任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 创建备份导入页面实例连接测试
        ///
        /// 创建备份导入页面实例连接测试
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateConnectivityTestResponse> CreateConnectivityTestAsync(CreateConnectivityTestRequest createConnectivityTestRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createConnectivityTestRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/connectivity-test",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createConnectivityTestRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateConnectivityTestResponse>(response);
        }
        
        /// <summary>
        /// 创建自定义模板
        ///
        /// 创建自定义模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCustomTemplateResponse> CreateCustomTemplateAsync(CreateCustomTemplateRequest createCustomTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCustomTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateCustomTemplateResponse>(response);
        }
        
        /// <summary>
        /// 创建实例诊断任务
        ///
        /// 诊断指定的缓存实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 创建热key分析任务，Redis 3.0 不支持热key分析。
        /// 
        /// 热key分析需要将缓存实例配置参数maxmemory-policy设置为allkeys-lfu或volatile-lfu。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 创建缓存实例，该接口创建的缓存实例支持按需计费和包周期两种方式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 创建数据迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 创建在线数据迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 新增/修改高级备份信息
        ///
        /// 新增/修改高级备份信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateOrUpdateBackUpInfoResponse> CreateOrUpdateBackUpInfoAsync(CreateOrUpdateBackUpInfoRequest createOrUpdateBackUpInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createOrUpdateBackUpInfoRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/additional-backups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOrUpdateBackUpInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            CreateOrUpdateBackUpInfoResponse createOrUpdateBackUpInfoResponse = JsonUtils.DeSerializeNull<CreateOrUpdateBackUpInfoResponse>(response);
            return createOrUpdateBackUpInfoResponse;
        }
        
        /// <summary>
        /// 采集Redis运行日志
        ///
        /// 采集Redis运行日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 获取日志下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 删除ACL账号
        ///
        /// 删除所创建的ACL普通账号
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAclAccountResponse> DeleteAclAccountAsync(DeleteAclAccountRequest deleteAclAccountRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteAclAccountRequest.InstanceId.ToString());
            urlParam.Add("account_id" , deleteAclAccountRequest.AccountId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAclAccountRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAclAccountResponse>(response);
        }
        
        /// <summary>
        /// 删除后台任务
        ///
        /// 删除后台任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 删除缓存实例已备份的文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 删除大key分析记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 删除自定义模板
        ///
        /// 删除自定义模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteConfigTemplateResponse> DeleteConfigTemplateAsync(DeleteConfigTemplateRequest deleteConfigTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id" , deleteConfigTemplateRequest.TemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates/{template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteConfigTemplateResponse>(response);
        }
        
        /// <summary>
        /// 删除热key分析任务
        ///
        /// 删除热key分析任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 将只读副本的IP从域名中摘除，摘除成功后，只读域名不会再解析到该副本IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 删除数据迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 删除指定的缓存实例，释放该实例的所有资源。
        /// 
        /// &gt; 如果是删除按需资源，请按照本章节执行；如果是删除包周期资源，即退订，请参考[退订包周期资源](https://support.huaweicloud.com/api-oce/zh-cn_topic_0082522030.html#section2)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 进行IP交换
        ///
        /// 进行IP交换
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExchangeInstanceIpResponse> ExchangeInstanceIpAsync(ExchangeInstanceIpRequest exchangeInstanceIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , exchangeInstanceIpRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/exchange-ip",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exchangeInstanceIpRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<ExchangeInstanceIpResponse>(response);
        }
        
        /// <summary>
        /// 集群分片倒换
        ///
        /// 集群分片倒换，适用于proxy和cluster实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteClusterSwitchoverResponse> ExecuteClusterSwitchoverAsync(ExecuteClusterSwitchoverRequest executeClusterSwitchoverRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , executeClusterSwitchoverRequest.InstanceId.ToString());
            urlParam.Add("group_id" , executeClusterSwitchoverRequest.GroupId.ToString());
            urlParam.Add("node_id" , executeClusterSwitchoverRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/groups/{group_id}/replications/{node_id}/async-switchover",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeClusterSwitchoverRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ExecuteClusterSwitchoverResponse>(response);
        }
        
        /// <summary>
        /// 执行web-cli命令V2接口
        ///
        /// 登入web-cli，执行redis命令
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteCommandMobilizationResponse> ExecuteCommandMobilizationAsync(ExecuteCommandMobilizationRequest executeCommandMobilizationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , executeCommandMobilizationRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/webcli/command",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCommandMobilizationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ExecuteCommandMobilizationResponse>(response);
        }
        
        /// <summary>
        /// 查询ACL账户列表
        ///
        /// 查询ACL账户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAclAccountsResponse> ListAclAccountsAsync(ListAclAccountsRequest listAclAccountsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listAclAccountsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclAccountsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAclAccountsResponse>(response);
        }
        
        /// <summary>
        /// 查询可用区信息
        ///
        /// 查询所在局点的可用区信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询后台任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 获取指定实例的备份文件下载链接，下载备份文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询指定缓存实例的备份信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询大key分析任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 查询任务中心任务列表
        ///
        /// 查询任务中心任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCenterTaskResponse> ListCenterTaskAsync(ListCenterTaskRequest listCenterTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCenterTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListCenterTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询实例参数修改记录列表
        ///
        /// 查询实例的参数修改记录列表，支持按照关键字查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConfigHistoriesResponse> ListConfigHistoriesAsync(ListConfigHistoriesRequest listConfigHistoriesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listConfigHistoriesRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/config-histories",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigHistoriesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListConfigHistoriesResponse>(response);
        }
        
        /// <summary>
        /// 查询参数模板列表
        ///
        /// 查询租户的参数模板列表，支持按照条件查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConfigTemplatesResponse> ListConfigTemplatesAsync(ListConfigTemplatesRequest listConfigTemplatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigTemplatesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListConfigTemplatesResponse>(response);
        }
        
        /// <summary>
        /// 查询实例配置参数
        ///
        /// 查询指定实例的配置参数信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询指定缓存实例诊断任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 在创建缓存实例时，需要配置订购的产品规格编码（spec_code），可通过该接口查询产品规格，查询条件不选时默认查询全部。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询读写分离实例和集群实例的分片和副本信息，其中，读写分离实例仅Redis4.0和Redis5.0的主备实例支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询热key分析历史记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询租户的缓存实例列表，支持按照条件查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询维护时间窗开始时间和结束时间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询迁移任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 查询迁移日志列表
        ///
        /// 查询迁移日志列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMigrationTaskLogsResponse> ListMigrationTaskLogsAsync(ListMigrationTaskLogsRequest listMigrationTaskLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , listMigrationTaskLogsRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/logs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMigrationTaskLogsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMigrationTaskLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询主维度信息列表
        ///
        /// 查询主维度对象列表，主维度ID当前支持dcs_instance_id，dcs_memcached_instance_id。
        /// &gt; 该接口当前仅在中国华南区开放。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询主维度下子维度监控对象列表，当前支持子维度的主维度ID的有 dcs_instance_id
        /// &gt; 该接口当前仅在中国华南区开放。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询该租户在当前区域下不同状态的实例数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询Redis运行日志列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询指定缓存实例的恢复记录列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询慢日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询当前租户下处于“运行中”状态的缓存实例的统计信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询租户在指定Project中实例类型的所有资源标签集合。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 登录webCli
        ///
        /// 登录webCli
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<LoginWebCliResponse> LoginWebCliAsync(LoginWebCliRequest loginWebCliRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , loginWebCliRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/webcli/auth",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", loginWebCliRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<LoginWebCliResponse>(response);
        }
        
        /// <summary>
        /// 重置ACL账号密码
        ///
        /// 重置ACL账号密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetAclAccountPassWordResponse> ResetAclAccountPassWordAsync(ResetAclAccountPassWordRequest resetAclAccountPassWordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resetAclAccountPassWordRequest.InstanceId.ToString());
            urlParam.Add("account_id" , resetAclAccountPassWordRequest.AccountId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}/password/reset",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetAclAccountPassWordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<ResetAclAccountPassWordResponse>(response);
        }
        
        /// <summary>
        /// 重置密码
        ///
        /// 重置缓存实例的密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordRequest resetPasswordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resetPasswordRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/password/reset",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetPasswordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ResetPasswordResponse>(response);
        }
        
        /// <summary>
        /// 变更实例规格
        ///
        /// 用户可以为状态为“运行中”的DCS缓存实例进行规格变更，当前仅能支持按需实例的同副本或分片数量的实例规格变更。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 重启运行中的DCS缓存实例。
        /// 
        /// 清空Redis4.0/Redis5.0的实例数据，数据清空后，无法撤销，且无法恢复，请谨慎操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 恢复指定的缓存实例。
        /// &gt; 只有主备和集群类型的缓存实例支持备份恢复操作，单机实例不支持备份恢复操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 立刻扫描过期Key
        ///
        /// 立刻扫描过期Key
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ScanExpireKeyResponse> ScanExpireKeyAsync(ScanExpireKeyRequest scanExpireKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , scanExpireKeyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/auto-expire/scan",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", scanExpireKeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ScanExpireKeyResponse>(response);
        }
        
        /// <summary>
        /// 配置在线数据迁移任务
        ///
        /// 配置在线数据迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 查询高级备份信息
        ///
        /// 查询高级备份信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBackUpInfoResponse> ShowBackUpInfoAsync(ShowBackUpInfoRequest showBackUpInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showBackUpInfoRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/additional-backups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackUpInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBackUpInfoResponse>(response);
        }
        
        /// <summary>
        /// 查询后台任务详细信息
        ///
        /// 查询后台任务详细信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBackgroundTaskProgressResponse> ShowBackgroundTaskProgressAsync(ShowBackgroundTaskProgressRequest showBackgroundTaskProgressRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showBackgroundTaskProgressRequest.InstanceId.ToString());
            urlParam.Add("task_id" , showBackgroundTaskProgressRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}/progress",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackgroundTaskProgressRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBackgroundTaskProgressResponse>(response);
        }
        
        /// <summary>
        /// 查询大key自动分析配置
        ///
        /// 查询大key自动分析配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询大key分析详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 查询参数模板详情
        ///
        /// 查询参数模板详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowConfigTemplateResponse> ShowConfigTemplateAsync(ShowConfigTemplateRequest showConfigTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id" , showConfigTemplateRequest.TemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates/{template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowConfigTemplateResponse>(response);
        }
        
        /// <summary>
        /// 查询指定诊断报告
        ///
        /// 通过报告ID查询诊断报告的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 查询过期Key扫描记录
        ///
        /// 查询过期Key扫描记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowExpireKeyScanInfoResponse> ShowExpireKeyScanInfoAsync(ShowExpireKeyScanInfoRequest showExpireKeyScanInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showExpireKeyScanInfoRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/auto-expire/histories",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExpireKeyScanInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowExpireKeyScanInfoResponse>(response);
        }
        
        /// <summary>
        /// 查询热key自动分析配置
        ///
        /// 查询热key自动分析配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询热key分析详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 通过实例ID查询实例的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 查询租户Job执行结果
        ///
        /// 查询租户Job执行结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobInfoResponse> ShowJobInfoAsync(ShowJobInfoRequest showJobInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobInfoRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowJobInfoResponse>(response);
        }
        
        /// <summary>
        /// 查询迁移任务详情
        ///
        /// 查询迁移任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询在线迁移进度明细。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 查询实例节点信息
        ///
        /// 查询指定实例的节点信息。
        /// 仅支持Redis4.0和Redis5.0实例查询。
        /// 创建中实例不返回节点信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNodesInformationResponse> ShowNodesInformationAsync(ShowNodesInformationRequest showNodesInformationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showNodesInformationRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/logical-nodes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodesInformationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowNodesInformationResponse>(response);
        }
        
        /// <summary>
        /// 查询租户配额
        ///
        /// 查询租户默认可以创建的实例数和总内存的配额限制，以及可以申请配额的最大值和最小值。不同的租户在不同的区域配额可能不同。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 获取副本状态
        ///
        /// 获取副本状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowReplicationStatesResponse> ShowReplicationStatesAsync(ShowReplicationStatesRequest showReplicationStatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showReplicationStatesRequest.InstanceId.ToString());
            urlParam.Add("group_id" , showReplicationStatesRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/groups/{group_id}/group-nodes-state",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplicationStatesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            ShowReplicationStatesResponse showReplicationStatesResponse = JsonUtils.DeSerializeNull<ShowReplicationStatesResponse>(response);
            showReplicationStatesResponse.Body = JsonUtils.DeSerializeList<InstanceReplicationListInfo>(response);
            return showReplicationStatesResponse;
        }
        
        /// <summary>
        /// 查询单个实例标签
        ///
        /// 通过实例ID查询标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 提交前置检查任务
        ///
        /// 提交前置检查任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartInstanceResizeCheckJobResponse> StartInstanceResizeCheckJobAsync(StartInstanceResizeCheckJobRequest startInstanceResizeCheckJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , startInstanceResizeCheckJobRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/resize/check-job",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInstanceResizeCheckJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<StartInstanceResizeCheckJobResponse>(response);
        }
        
        /// <summary>
        /// 停止数据迁移任务
        ///
        /// 停止数据迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 同步停止数据迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 修改ACL账号密码
        ///
        /// 修改ACL账号密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAclAccountPassWordResponse> UpdateAclAccountPassWordAsync(UpdateAclAccountPassWordRequest updateAclAccountPassWordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateAclAccountPassWordRequest.InstanceId.ToString());
            urlParam.Add("account_id" , updateAclAccountPassWordRequest.AccountId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}/password/modify",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAclAccountPassWordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAclAccountPassWordResponse>(response);
        }
        
        /// <summary>
        /// ACL账号修改备注
        ///
        /// ACL账号修改备注
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAclAccountRemarkResponse> UpdateAclAccountRemarkAsync(UpdateAclAccountRemarkRequest updateAclAccountRemarkRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateAclAccountRemarkRequest.InstanceId.ToString());
            urlParam.Add("account_id" , updateAclAccountRemarkRequest.AccountId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAclAccountRemarkRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateAclAccountRemarkResponse>(response);
        }
        
        /// <summary>
        /// 修改ACL角色
        ///
        /// 修改用户的类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAclAccountRoleResponse> UpdateAclAccountRoleAsync(UpdateAclAccountRoleRequest updateAclAccountRoleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateAclAccountRoleRequest.InstanceId.ToString());
            urlParam.Add("account_id" , updateAclAccountRoleRequest.AccountId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}/role",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAclAccountRoleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAclAccountRoleResponse>(response);
        }
        
        /// <summary>
        /// 设置大key自动分析配置
        ///
        /// 设置大key自动分析配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 修改自定义模板
        ///
        /// 修改自定义模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateConfigTemplateResponse> UpdateConfigTemplateAsync(UpdateConfigTemplateRequest updateConfigTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id" , updateConfigTemplateRequest.TemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates/{template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateConfigTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateConfigTemplateResponse>(response);
        }
        
        /// <summary>
        /// 修改实例配置参数
        ///
        /// 为了确保分布式缓存服务发挥出最优性能，您可以根据自己的业务情况对DCS缓存实例的运行参数进行调整。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 设置热key自动分析配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 修改缓存实例的信息，可修改信息包括实例名称、描述、备份策略、维护时间窗开始和结束时间以及安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 变更指定实例的带宽
        ///
        /// 变更指定实例的带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceBandwidthResponse> UpdateInstanceBandwidthAsync(UpdateInstanceBandwidthRequest updateInstanceBandwidthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceBandwidthRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bandwidth",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceBandwidthRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateInstanceBandwidthResponse>(response);
        }
        
        /// <summary>
        /// 设置迁移任务自动重连
        ///
        /// 设置迁移任务自动重连
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMigrationTaskResponse> UpdateMigrationTaskAsync(UpdateMigrationTaskRequest updateMigrationTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , updateMigrationTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMigrationTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            UpdateMigrationTaskResponse updateMigrationTaskResponse = JsonUtils.DeSerializeNull<UpdateMigrationTaskResponse>(response);
            return updateMigrationTaskResponse;
        }
        
        /// <summary>
        /// 修改密码
        ///
        /// 修改缓存实例的密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 设置副本优先级，主节点故障时，权重越小的备节点切换为主节点的优先级越高。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询指定实例的IP白名单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 为指定实例设置IP白名单分组，包含创建、停用、编辑、删除白名单四个功能
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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