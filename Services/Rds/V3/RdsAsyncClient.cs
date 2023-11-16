using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Rds.V3.Model;

namespace HuaweiCloud.SDK.Rds.V3
{
    public partial class RdsAsyncClient : Client
    {
        public static ClientBuilder<RdsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<RdsAsyncClient>();
        }

        
        /// <summary>
        /// 在pg_hba.conf文件最后新增单个或多个配置
        ///
        /// 以传入配置全量覆盖当前pg_hba.conf文件内容，入参为空时用默认配置覆盖当前文件内容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddPostgresqlHbaConfResponse> AddPostgresqlHbaConfAsync(AddPostgresqlHbaConfRequest addPostgresqlHbaConfRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , addPostgresqlHbaConfRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addPostgresqlHbaConfRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddPostgresqlHbaConfResponse>(response);
        }
        
        /// <summary>
        /// 应用参数模板
        ///
        /// 应用参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ApplyConfigurationAsyncResponse> ApplyConfigurationAsyncAsync(ApplyConfigurationAsyncRequest applyConfigurationAsyncRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , applyConfigurationAsyncRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations/{config_id}/apply",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyConfigurationAsyncRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<ApplyConfigurationAsyncResponse>(response);
        }
        
        /// <summary>
        /// 绑定和解绑弹性公网IP
        ///
        /// 绑定和解绑弹性公网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AttachEipResponse> AttachEipAsync(AttachEipRequest attachEipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , attachEipRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ip",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachEipRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<AttachEipResponse>(response);
        }
        
        /// <summary>
        /// 批量删除手动备份
        ///
        /// 批量删除手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteManualBackupResponse> BatchDeleteManualBackupAsync(BatchDeleteManualBackupRequest batchDeleteManualBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteManualBackupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteManualBackupResponse>(response);
        }
        
        /// <summary>
        /// 库级时间点恢复
        ///
        /// 库级时间点恢复
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchRestoreDatabaseResponse> BatchRestoreDatabaseAsync(BatchRestoreDatabaseRequest batchRestoreDatabaseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/batch/restore/databases",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestoreDatabaseRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchRestoreDatabaseResponse>(response);
        }
        
        /// <summary>
        /// 表级时间点恢复（PostgreSQL）
        ///
        /// 表级时间点恢复（PostgreSQL）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchRestorePostgreSqlTablesResponse> BatchRestorePostgreSqlTablesAsync(BatchRestorePostgreSqlTablesRequest batchRestorePostgreSqlTablesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/batch/restore/tables",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestorePostgreSqlTablesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchRestorePostgreSqlTablesResponse>(response);
        }
        
        /// <summary>
        /// 批量添加标签
        ///
        /// 批量添加标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchTagAddActionResponse> BatchTagAddActionAsync(BatchTagAddActionRequest batchTagAddActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , batchTagAddActionRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagAddActionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchTagAddActionResponse>(response);
        }
        
        /// <summary>
        /// 批量删除标签
        ///
        /// 批量删除标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchTagDelActionResponse> BatchTagDelActionAsync(BatchTagDelActionRequest batchTagDelActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , batchTagDelActionRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagDelActionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchTagDelActionResponse>(response);
        }
        
        /// <summary>
        /// 更改主备实例的数据同步方式
        ///
        /// 更改主备实例的数据同步方式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeFailoverModeResponse> ChangeFailoverModeAsync(ChangeFailoverModeRequest changeFailoverModeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , changeFailoverModeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/failover/mode",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeFailoverModeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<ChangeFailoverModeResponse>(response);
        }
        
        /// <summary>
        /// 切换主备实例的倒换策略
        ///
        /// 切换主备实例的倒换策略.
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeFailoverStrategyResponse> ChangeFailoverStrategyAsync(ChangeFailoverStrategyRequest changeFailoverStrategyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , changeFailoverStrategyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/failover/strategy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeFailoverStrategyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<ChangeFailoverStrategyResponse>(response);
        }
        
        /// <summary>
        /// 设置可维护时间段
        ///
        /// 设置可维护时间段
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeOpsWindowResponse> ChangeOpsWindowAsync(ChangeOpsWindowRequest changeOpsWindowRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , changeOpsWindowRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ops-window",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeOpsWindowRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<ChangeOpsWindowResponse>(response);
        }
        
        /// <summary>
        /// 复制参数模板
        ///
        /// 复制参数模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CopyConfigurationResponse> CopyConfigurationAsync(CopyConfigurationRequest copyConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , copyConfigurationRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/copy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyConfigurationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CopyConfigurationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfigurationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 申请域名
        ///
        /// 申请域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDnsNameResponse> CreateDnsNameAsync(CreateDnsNameRequest createDnsNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createDnsNameRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/create-dns",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDnsNameRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDnsNameResponse>(response);
        }
        
        /// <summary>
        /// 创建数据库实例
        ///
        /// 创建数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest createInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateInstanceResponse>(response);
        }
        
        /// <summary>
        /// 创建手动备份
        ///
        /// 创建手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateManualBackupResponse> CreateManualBackupAsync(CreateManualBackupRequest createManualBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createManualBackupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateManualBackupResponse>(response);
        }
        
        /// <summary>
        /// 恢复到新实例
        ///
        /// 恢复到新实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRestoreInstanceResponse> CreateRestoreInstanceAsync(CreateRestoreInstanceRequest createRestoreInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRestoreInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRestoreInstanceResponse>(response);
        }
        
        /// <summary>
        /// 获取扩展日志下载信息
        ///
        /// 获取扩展日志下载信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateXelLogDownloadResponse> CreateXelLogDownloadAsync(CreateXelLogDownloadRequest createXelLogDownloadRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createXelLogDownloadRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/xellog-download",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createXelLogDownloadRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateXelLogDownloadResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , deleteConfigurationRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigurationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 删除数据库实例
        ///
        /// 删除数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest deleteInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteInstanceResponse>(response);
        }
        
        /// <summary>
        /// 删除即时任务
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest deleteJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteJobResponse deleteJobResponse = JsonUtils.DeSerializeNull<DeleteJobResponse>(response);
            return deleteJobResponse;
        }
        
        /// <summary>
        /// 删除手动备份
        ///
        /// 删除手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteManualBackupResponse> DeleteManualBackupAsync(DeleteManualBackupRequest deleteManualBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , deleteManualBackupRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteManualBackupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteManualBackupResponse>(response);
        }
        
        /// <summary>
        /// 删除pg_hba.conf文件的单个或多个配置
        ///
        /// 删除pg_hba.conf文件的单个或多个配置，以priority做唯一标识
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePostgresqlHbaConfResponse> DeletePostgresqlHbaConfAsync(DeletePostgresqlHbaConfRequest deletePostgresqlHbaConfRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deletePostgresqlHbaConfRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePostgresqlHbaConfRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeletePostgresqlHbaConfResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , downloadSlowlogRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-download",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSlowlogRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DownloadSlowlogResponse>(response);
        }
        
        /// <summary>
        /// 应用参数模板
        ///
        /// 应用参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableConfigurationResponse> EnableConfigurationAsync(EnableConfigurationRequest enableConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , enableConfigurationRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableConfigurationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<EnableConfigurationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listAuditlogsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditlogsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAuditlogsResponse>(response);
        }
        
        /// <summary>
        /// 获取备份列表
        ///
        /// 获取备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBackupsResponse> ListBackupsAsync(ListBackupsRequest listBackupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBackupsResponse>(response);
        }
        
        /// <summary>
        /// 查询SQLServer可用字符集
        ///
        /// 查询SQLServer可用字符集
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCollationsResponse> ListCollationsAsync(ListCollationsRequest listCollationsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/collations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCollationsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListCollationsResponse>(response);
        }
        
        /// <summary>
        /// 获取参数模板列表
        ///
        /// 获取参数模板列表，包括所有数据库的默认参数模板和用户创建的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConfigurationsResponse> ListConfigurationsAsync(ListConfigurationsRequest listConfigurationsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListConfigurationsResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库引擎的版本
        ///
        /// 查询数据库引擎的版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDatastoresResponse> ListDatastoresAsync(ListDatastoresRequest listDatastoresRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name" , listDatastoresRequest.DatabaseName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores/{database_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoresRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDatastoresResponse>(response);
        }
        
        /// <summary>
        /// 
        ///
        /// 批量查询容灾实例信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDrRelationsResponse> ListDrRelationsAsync(ListDrRelationsRequest listDrRelationsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/disaster-recovery-relation",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDrRelationsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDrRelationsResponse>(response);
        }
        
        /// <summary>
        /// 查询实例可变更规格
        ///
        /// 查询实例可变更规格
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEngineFlavorsResponse> ListEngineFlavorsAsync(ListEngineFlavorsRequest listEngineFlavorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listEngineFlavorsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/available-flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEngineFlavorsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEngineFlavorsResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库错误日志
        ///
        /// 查询数据库错误日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListErrorLogsResponse> ListErrorLogsAsync(ListErrorLogsRequest listErrorLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listErrorLogsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/errorlog",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listErrorLogsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListErrorLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库错误日志
        ///
        /// 查询数据库错误日志。(与原v3接口相比修改offset,符合华为云服务开放 API遵从性规范3.0)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListErrorLogsNewResponse> ListErrorLogsNewAsync(ListErrorLogsNewRequest listErrorLogsNewRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listErrorLogsNewRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/errorlog",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listErrorLogsNewRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListErrorLogsNewResponse>(response);
        }
        
        /// <summary>
        /// 
        ///
        /// 查询实例的错误日志数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListErrorlogForLtsResponse> ListErrorlogForLtsAsync(ListErrorlogForLtsRequest listErrorlogForLtsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listErrorlogForLtsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-logs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listErrorlogForLtsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListErrorlogForLtsResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库规格
        ///
        /// 查询数据库规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFlavorsResponse> ListFlavorsAsync(ListFlavorsRequest listFlavorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name" , listFlavorsRequest.DatabaseName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors/{database_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }
        
        /// <summary>
        /// 查询指定时间点可恢复的库
        ///
        /// 查询指定时间点可恢复的库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHistoryDatabaseResponse> ListHistoryDatabaseAsync(ListHistoryDatabaseRequest listHistoryDatabaseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name" , listHistoryDatabaseRequest.DatabaseName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{database_name}/instances/history/databases",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryDatabaseRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListHistoryDatabaseResponse>(response);
        }
        
        /// <summary>
        /// 获取诊断后的实例数量
        ///
        /// 获取诊断后的实例数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceDiagnosisResponse> ListInstanceDiagnosisAsync(ListInstanceDiagnosisRequest listInstanceDiagnosisRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/diagnosis",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceDiagnosisRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListInstanceDiagnosisResponse>(response);
        }
        
        /// <summary>
        /// 查询实例参数修改历史
        ///
        /// 实例参数修改历史。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceParamHistoriesResponse> ListInstanceParamHistoriesAsync(ListInstanceParamHistoriesRequest listInstanceParamHistoriesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listInstanceParamHistoriesRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configuration-histories",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceParamHistoriesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListInstanceParamHistoriesResponse>(response);
        }
        
        /// <summary>
        /// 查询实例标签
        ///
        /// 查询实例标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceTagsResponse> ListInstanceTagsAsync(ListInstanceTagsRequest listInstanceTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listInstanceTagsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListInstanceTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库实例列表
        ///
        /// 查询数据库实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest listInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListInstancesResponse>(response);
        }
        
        /// <summary>
        /// 获取指定诊断项的诊断结果
        ///
        /// 获取指定诊断项的诊断结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesInfoDiagnosisResponse> ListInstancesInfoDiagnosisAsync(ListInstancesInfoDiagnosisRequest listInstancesInfoDiagnosisRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/diagnosis/info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesInfoDiagnosisRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListInstancesInfoDiagnosisResponse>(response);
        }
        
        /// <summary>
        /// 获取实例是否能使用极速恢复
        ///
        /// 批量获取实例是否能在库表恢复时使用极速恢复。
        /// 
        /// - 调用接口前，您需要了解API 认证鉴权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesSupportFastRestoreResponse> ListInstancesSupportFastRestoreAsync(ListInstancesSupportFastRestoreRequest listInstancesSupportFastRestoreRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/fast-restore",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesSupportFastRestoreRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListInstancesSupportFastRestoreResponse>(response);
        }
        
        /// <summary>
        /// 获取指定ID的任务信息
        ///
        /// 获取指定ID的任务信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListJobInfoResponse> ListJobInfoAsync(ListJobInfoRequest listJobInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListJobInfoResponse>(response);
        }
        
        /// <summary>
        /// 获取指定实例和时间范围的任务信息（SQL Server）
        ///
        /// 获取指定实例和时间范围的任务信息（SQL Server）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListJobInfoDetailResponse> ListJobInfoDetailAsync(ListJobInfoDetailRequest listJobInfoDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listJobInfoDetailRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tasklist/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobInfoDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListJobInfoDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询跨区域备份列表
        ///
        /// 查询跨区域备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOffSiteBackupsResponse> ListOffSiteBackupsAsync(ListOffSiteBackupsRequest listOffSiteBackupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/offsite-backups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOffSiteBackupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListOffSiteBackupsResponse>(response);
        }
        
        /// <summary>
        /// 查询跨区域备份实例列表
        ///
        /// 查询跨区域备份实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOffSiteInstancesResponse> ListOffSiteInstancesAsync(ListOffSiteInstancesRequest listOffSiteInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/backups/offsite-backup-instance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOffSiteInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListOffSiteInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询跨区域备份可恢复时间段
        ///
        /// 查询跨区域备份可恢复时间段。
        /// 如果您备份策略中的保存天数设置较长，建议您传入查询日期“date”。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOffSiteRestoreTimesResponse> ListOffSiteRestoreTimesAsync(ListOffSiteRestoreTimesRequest listOffSiteRestoreTimesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listOffSiteRestoreTimesRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/offsite-restore-time",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOffSiteRestoreTimesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListOffSiteRestoreTimesResponse>(response);
        }
        
        /// <summary>
        /// 查询实例的pg_hba.conf文件配置
        ///
        /// 查询实例的pg_hba.conf文件配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPostgresqlHbaInfoResponse> ListPostgresqlHbaInfoAsync(ListPostgresqlHbaInfoRequest listPostgresqlHbaInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listPostgresqlHbaInfoRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlHbaInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            ListPostgresqlHbaInfoResponse listPostgresqlHbaInfoResponse = JsonUtils.DeSerializeNull<ListPostgresqlHbaInfoResponse>(response);
            listPostgresqlHbaInfoResponse.Body = JsonUtils.DeSerializeList<PostgresqlHbaConf>(response);
            return listPostgresqlHbaInfoResponse;
        }
        
        /// <summary>
        /// 查询实例的pg_hba.conf文件修改历史
        ///
        /// 查询实例的pg_hba.conf文件修改历史
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPostgresqlHbaInfoHistoryResponse> ListPostgresqlHbaInfoHistoryAsync(ListPostgresqlHbaInfoHistoryRequest listPostgresqlHbaInfoHistoryRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listPostgresqlHbaInfoHistoryRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info/history",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlHbaInfoHistoryRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            ListPostgresqlHbaInfoHistoryResponse listPostgresqlHbaInfoHistoryResponse = JsonUtils.DeSerializeNull<ListPostgresqlHbaInfoHistoryResponse>(response);
            listPostgresqlHbaInfoHistoryResponse.Body = JsonUtils.DeSerializeList<PostgresqlHbaHistory>(response);
            return listPostgresqlHbaInfoHistoryResponse;
        }
        
        /// <summary>
        /// 查询指定时间点可恢复的表(PostgreSQL)
        ///
        /// 查询指定时间点可恢复的表(PostgreSQL)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPostgresqlListHistoryTablesResponse> ListPostgresqlListHistoryTablesAsync(ListPostgresqlListHistoryTablesRequest listPostgresqlListHistoryTablesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name" , listPostgresqlListHistoryTablesRequest.DatabaseName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{database_name}/instances/history/tables",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlListHistoryTablesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListPostgresqlListHistoryTablesResponse>(response);
        }
        
        /// <summary>
        /// 
        ///
        /// 查询预定义标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPredefinedTagResponse> ListPredefinedTagAsync(ListPredefinedTagRequest listPredefinedTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tags/predefined-tag",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPredefinedTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPredefinedTagResponse>(response);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询项目标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectTagsResponse> ListProjectTagsAsync(ListProjectTagsRequest listProjectTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询回收站
        ///
        /// 查询回收站实例信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecycleInstancesResponse> ListRecycleInstancesAsync(ListRecycleInstancesRequest listRecycleInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/recycle-instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecycleInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRecycleInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询可恢复时间段
        ///
        /// 查询可恢复时间段。
        /// 如果您备份策略中的保存天数设置较长，建议您传入查询日期“date”。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRestoreTimesResponse> ListRestoreTimesAsync(ListRestoreTimesRequest listRestoreTimesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listRestoreTimesRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-time",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTimesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRestoreTimesResponse>(response);
        }
        
        /// <summary>
        /// 
        ///
        /// 获取指定实例详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSimplifiedInstancesResponse> ListSimplifiedInstancesAsync(ListSimplifiedInstancesRequest listSimplifiedInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/simplified-instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSimplifiedInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListSimplifiedInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询慢日志文件列表
        ///
        /// 查询慢日志文件列表。
        /// 调用该接口取到慢日志文件名后，可以调用接口/v3/{project_id}/instances/{instance_id}/slowlog-download 获取慢日志文件下载链接
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSlowLogFileResponse> ListSlowLogFileAsync(ListSlowLogFileRequest listSlowLogFileRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listSlowLogFileRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-files",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogFileRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSlowLogFileResponse>(response);
        }
        
        /// <summary>
        /// 
        ///
        /// 查询实例慢日志的统计数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSlowLogStatisticsForLtsResponse> ListSlowLogStatisticsForLtsAsync(ListSlowLogStatisticsForLtsRequest listSlowLogStatisticsForLtsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listSlowLogStatisticsForLtsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/slow-logs/statistics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogStatisticsForLtsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListSlowLogStatisticsForLtsResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库慢日志
        ///
        /// 查询数据库慢日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSlowLogsResponse> ListSlowLogsAsync(ListSlowLogsRequest listSlowLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listSlowLogsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSlowLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库慢日志
        ///
        /// 查询数据库慢日志。(与原v3接口相比修改offset,符合华为云服务开放 API遵从性规范3.0)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSlowLogsNewResponse> ListSlowLogsNewAsync(ListSlowLogsNewRequest listSlowLogsNewRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listSlowLogsNewRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/slowlog",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsNewRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSlowLogsNewResponse>(response);
        }
        
        /// <summary>
        /// 
        ///
        /// 查询实例的慢日志数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSlowlogForLtsResponse> ListSlowlogForLtsAsync(ListSlowlogForLtsRequest listSlowlogForLtsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listSlowlogForLtsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-logs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowlogForLtsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListSlowlogForLtsResponse>(response);
        }
        
        /// <summary>
        /// 获取慢日志统计信息
        ///
        /// 获取慢日志统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSlowlogStatisticsResponse> ListSlowlogStatisticsAsync(ListSlowlogStatisticsRequest listSlowlogStatisticsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listSlowlogStatisticsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog/statistics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowlogStatisticsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSlowlogStatisticsResponse>(response);
        }
        
        /// <summary>
        /// 获取SSL证书下载地址
        ///
        /// 获取SSL证书下载地址
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSslCertDownloadLinkResponse> ListSslCertDownloadLinkAsync(ListSslCertDownloadLinkRequest listSslCertDownloadLinkRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listSslCertDownloadLinkRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-cert/download-link",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSslCertDownloadLinkRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSslCertDownloadLinkResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库磁盘类型
        ///
        /// 查询数据库磁盘类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStorageTypesResponse> ListStorageTypesAsync(ListStorageTypesRequest listStorageTypesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name" , listStorageTypesRequest.DatabaseName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/storage-type/{database_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageTypesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListStorageTypesResponse>(response);
        }
        
        /// <summary>
        /// 查询扩展日志文件列表
        ///
        /// 查询扩展日志文件列表。
        /// 查询扩展日志文件列表，可以调用接口/v3/{project_id}/instances/{instance_id}/xellog-download 获取扩展日志下载链接
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListXellogFilesResponse> ListXellogFilesAsync(ListXellogFilesRequest listXellogFilesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listXellogFilesRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/xellog-files",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listXellogFilesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListXellogFilesResponse>(response);
        }
        
        /// <summary>
        /// 迁移主备实例的备机
        ///
        /// 迁移主备实例的备机
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<MigrateFollowerResponse> MigrateFollowerAsync(MigrateFollowerRequest migrateFollowerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , migrateFollowerRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/migrateslave",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateFollowerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<MigrateFollowerResponse>(response);
        }
        
        /// <summary>
        /// 修改pg_hba.conf文件的单个或多个配置
        ///
        /// 修改/新增pg_hba.conf文件的单个或多个配置，以priority做唯一标识，priority不存在的新增，存在的修改
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyPostgresqlHbaConfResponse> ModifyPostgresqlHbaConfAsync(ModifyPostgresqlHbaConfRequest modifyPostgresqlHbaConfRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , modifyPostgresqlHbaConfRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyPostgresqlHbaConfRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<ModifyPostgresqlHbaConfResponse>(response);
        }
        
        /// <summary>
        /// 恢复到已有实例
        ///
        /// 恢复到已有实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestoreExistInstanceResponse> RestoreExistInstanceAsync(RestoreExistInstanceRequest restoreExistInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/recovery",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreExistInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RestoreExistInstanceResponse>(response);
        }
        
        /// <summary>
        /// 表级时间点恢复(MySQL)
        ///
        /// 表级时间点恢复(MySQL)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestoreTablesResponse> RestoreTablesAsync(RestoreTablesRequest restoreTablesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , restoreTablesRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore/tables",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreTablesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RestoreTablesResponse>(response);
        }
        
        /// <summary>
        /// 表级时间点恢复(MySQL)
        ///
        /// 表级时间点恢复(MySQL)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestoreTablesNewResponse> RestoreTablesNewAsync(RestoreTablesNewRequest restoreTablesNewRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , restoreTablesNewRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/restore/tables",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreTablesNewRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RestoreTablesNewResponse>(response);
        }
        
        /// <summary>
        /// 恢复到已有实例
        ///
        /// 恢复到已有实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestoreToExistingInstanceResponse> RestoreToExistingInstanceAsync(RestoreToExistingInstanceRequest restoreToExistingInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recovery",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreToExistingInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RestoreToExistingInstanceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , setAuditlogPolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditlogPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<SetAuditlogPolicyResponse>(response);
        }
        
        /// <summary>
        /// 设置自动扩容策略
        ///
        /// 设置实例存储空间自动扩容策略，按扩容量扣除存储费用。
        /// 可用存储空间小于设置值或者10GB时，自动扩容当前存储空间的15%（非10倍数向上取整，账户余额不足，会导致自动扩容失败）。
        /// 设置只读实例自动扩容与主实例自动扩容互不影响，对只读实例设置自动扩容时，可选择大于或等于主实例的存储空间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetAutoEnlargePolicyResponse> SetAutoEnlargePolicyAsync(SetAutoEnlargePolicyRequest setAutoEnlargePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , setAutoEnlargePolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disk-auto-expansion",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAutoEnlargePolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            SetAutoEnlargePolicyResponse setAutoEnlargePolicyResponse = JsonUtils.DeSerializeNull<SetAutoEnlargePolicyResponse>(response);
            return setAutoEnlargePolicyResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , setBackupPolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBackupPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<SetBackupPolicyResponse>(response);
        }
        
        /// <summary>
        /// 设置binlog本地保留时长
        ///
        /// 修改指定实例的binlog本地保留时长。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetBinlogClearPolicyResponse> SetBinlogClearPolicyAsync(SetBinlogClearPolicyRequest setBinlogClearPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , setBinlogClearPolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/binlog/clear-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBinlogClearPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<SetBinlogClearPolicyResponse>(response);
        }
        
        /// <summary>
        /// 设置跨区域备份策略
        ///
        /// 设置跨区域备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetOffSiteBackupPolicyResponse> SetOffSiteBackupPolicyAsync(SetOffSiteBackupPolicyRequest setOffSiteBackupPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , setOffSiteBackupPolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/offsite-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setOffSiteBackupPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<SetOffSiteBackupPolicyResponse>(response);
        }
        
        /// <summary>
        /// 设置秒级监控策略
        ///
        /// 设置实例秒级监控策略，约五分钟后生效，对于1秒监控和5秒监控，计费方式为按需付费（每小时扣费一次）。
        /// 设置只读实例秒级监控与主实例互不影响。
        /// 规格变更到4U以下的实例，秒级监控功能会自动关闭。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetSecondLevelMonitorResponse> SetSecondLevelMonitorAsync(SetSecondLevelMonitorRequest setSecondLevelMonitorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , setSecondLevelMonitorRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/second-level-monitor",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSecondLevelMonitorRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            SetSecondLevelMonitorResponse setSecondLevelMonitorResponse = JsonUtils.DeSerializeNull<SetSecondLevelMonitorResponse>(response);
            return setSecondLevelMonitorResponse;
        }
        
        /// <summary>
        /// 修改安全组
        ///
        /// 修改安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetSecurityGroupResponse> SetSecurityGroupAsync(SetSecurityGroupRequest setSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , setSecurityGroupRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/security-group",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<SetSecurityGroupResponse>(response);
        }
        
        /// <summary>
        /// 慢日志敏感信息的开关
        ///
        /// V3慢日志敏感信息的开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetSensitiveSlowLogResponse> SetSensitiveSlowLogAsync(SetSensitiveSlowLogRequest setSensitiveSlowLogRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , setSensitiveSlowLogRequest.InstanceId.ToString());
            urlParam.Add("status" , setSensitiveSlowLogRequest.Status.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-sensitization/{status}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSensitiveSlowLogRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<SetSensitiveSlowLogResponse>(response);
        }
        
        /// <summary>
        /// 生成审计日志下载链接
        ///
        /// 生成审计日志下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAuditlogDownloadLinkResponse> ShowAuditlogDownloadLinkAsync(ShowAuditlogDownloadLinkRequest showAuditlogDownloadLinkRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showAuditlogDownloadLinkRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-links",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditlogDownloadLinkRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowAuditlogDownloadLinkResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showAuditlogPolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditlogPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAuditlogPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询自动扩容策略
        ///
        /// 查询实例存储空间自动扩容策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutoEnlargePolicyResponse> ShowAutoEnlargePolicyAsync(ShowAutoEnlargePolicyRequest showAutoEnlargePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showAutoEnlargePolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disk-auto-expansion",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoEnlargePolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAutoEnlargePolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backup-files",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupDownloadLinkRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBackupDownloadLinkResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showBackupPolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBackupPolicyResponse>(response);
        }
        
        /// <summary>
        /// 获取binlog本地保留时长
        ///
        /// 查寻指定实例的binlog本地保留时长。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBinlogClearPolicyResponse> ShowBinlogClearPolicyAsync(ShowBinlogClearPolicyRequest showBinlogClearPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showBinlogClearPolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/binlog/clear-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBinlogClearPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBinlogClearPolicyResponse>(response);
        }
        
        /// <summary>
        /// 获取指定参数模板的参数
        ///
        /// 获取指定参数模板的参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowConfigurationResponse> ShowConfigurationAsync(ShowConfigurationRequest showConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , showConfigurationRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 查询实例ipv6域名。
        ///
        /// 查询实例ipv6域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDnsNameResponse> ShowDnsNameAsync(ShowDnsNameRequest showDnsNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showDnsNameRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dns-ipv6",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDnsNameRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDnsNameResponse>(response);
        }
        
        /// <summary>
        /// 
        ///
        /// 查询实例ipv4域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainNameResponse> ShowDomainNameAsync(ShowDomainNameRequest showDomainNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showDomainNameRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dns",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainNameRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainNameResponse>(response);
        }
        
        /// <summary>
        /// 查询跨云容灾复制状态
        ///
        /// 建立跨云容灾关系后，查询主实例和灾备实例间的复制状态及延迟。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDrReplicaStatusResponse> ShowDrReplicaStatusAsync(ShowDrReplicaStatusRequest showDrReplicaStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showDrReplicaStatusRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDrReplicaStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDrReplicaStatusResponse>(response);
        }
        
        /// <summary>
        /// 获取指定实例的参数模板
        ///
        /// 获取指定实例的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceConfigurationResponse> ShowInstanceConfigurationAsync(ShowInstanceConfigurationRequest showInstanceConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showInstanceConfigurationRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigurationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowInstanceConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 查询跨区域备份策略
        ///
        /// 查询跨区域备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOffSiteBackupPolicyResponse> ShowOffSiteBackupPolicyAsync(ShowOffSiteBackupPolicyRequest showOffSiteBackupPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showOffSiteBackupPolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/offsite-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOffSiteBackupPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowOffSiteBackupPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// 查询当前项目下资源配额情况。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQuotasResponse> ShowQuotasAsync(ShowQuotasRequest showQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }
        
        /// <summary>
        /// 查询回收站的回收策略。
        ///
        /// 查询回收站的回收策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecyclePolicyResponse> ShowRecyclePolicyAsync(ShowRecyclePolicyRequest showRecyclePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecyclePolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRecyclePolicyResponse>(response);
        }
        
        /// <summary>
        /// 获取实例的复制状态。
        ///
        /// 获取实例的复制状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowReplicationStatusResponse> ShowReplicationStatusAsync(ShowReplicationStatusRequest showReplicationStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showReplicationStatusRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replication/status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplicationStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowReplicationStatusResponse>(response);
        }
        
        /// <summary>
        /// 查询秒级监控策略
        ///
        /// 查询实例秒级监控策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSecondLevelMonitoringResponse> ShowSecondLevelMonitoringAsync(ShowSecondLevelMonitoringRequest showSecondLevelMonitoringRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showSecondLevelMonitoringRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/second-level-monitor",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecondLevelMonitoringRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSecondLevelMonitoringResponse>(response);
        }
        
        /// <summary>
        /// 手动倒换主备
        ///
        /// 手动倒换主备.
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartFailoverResponse> StartFailoverAsync(StartFailoverRequest startFailoverRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , startFailoverRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/failover",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", startFailoverRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<StartFailoverResponse>(response);
        }
        
        /// <summary>
        /// 扩容数据库实例的磁盘空间
        ///
        /// 扩容数据库实例的磁盘空间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartInstanceEnlargeVolumeActionResponse> StartInstanceEnlargeVolumeActionAsync(StartInstanceEnlargeVolumeActionRequest startInstanceEnlargeVolumeActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , startInstanceEnlargeVolumeActionRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInstanceEnlargeVolumeActionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<StartInstanceEnlargeVolumeActionResponse>(response);
        }
        
        /// <summary>
        /// 重启数据库实例
        ///
        /// 重启数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartInstanceRestartActionResponse> StartInstanceRestartActionAsync(StartInstanceRestartActionRequest startInstanceRestartActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , startInstanceRestartActionRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInstanceRestartActionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<StartInstanceRestartActionResponse>(response);
        }
        
        /// <summary>
        /// 单机转主备实例
        ///
        /// 单机转主备实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartInstanceSingleToHaActionResponse> StartInstanceSingleToHaActionAsync(StartInstanceSingleToHaActionRequest startInstanceSingleToHaActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , startInstanceSingleToHaActionRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInstanceSingleToHaActionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<StartInstanceSingleToHaActionResponse>(response);
        }
        
        /// <summary>
        /// 设置回收站策略
        ///
        /// 设置回收站策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartRecyclePolicyResponse> StartRecyclePolicyAsync(StartRecyclePolicyRequest startRecyclePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", startRecyclePolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<StartRecyclePolicyResponse>(response);
        }
        
        /// <summary>
        /// 变更数据库实例的规格
        ///
        /// 变更数据库实例的规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartResizeFlavorActionResponse> StartResizeFlavorActionAsync(StartResizeFlavorActionRequest startResizeFlavorActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , startResizeFlavorActionRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", startResizeFlavorActionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<StartResizeFlavorActionResponse>(response);
        }
        
        /// <summary>
        /// 开启实例
        ///
        /// 停止实例以节省费用，在停止数据库实例后，支持手动重新开启实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartupInstanceResponse> StartupInstanceAsync(StartupInstanceRequest startupInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , startupInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action/startup",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", startupInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<StartupInstanceResponse>(response);
        }
        
        /// <summary>
        /// 停止实例
        ///
        /// 实例进行关机，通过暂时停止按需实例以节省费用，实例默认停止七天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest stopInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , stopInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action/shutdown",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<StopInstanceResponse>(response);
        }
        
        /// <summary>
        /// 设置SSL数据加密
        ///
        /// 设置SSL数据加密。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchSslResponse> SwitchSslAsync(SwitchSslRequest switchSslRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , switchSslRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSslRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<SwitchSslResponse>(response);
        }
        
        /// <summary>
        /// 修改参数模板参数
        ///
        /// 修改参数模板参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateConfigurationResponse> UpdateConfigurationAsync(UpdateConfigurationRequest updateConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id" , updateConfigurationRequest.ConfigId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigurationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 修改内网地址
        ///
        /// 修改内网地址
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDataIpResponse> UpdateDataIpAsync(UpdateDataIpRequest updateDataIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateDataIpRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ip",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDataIpRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDataIpResponse>(response);
        }
        
        /// <summary>
        /// 修改域名
        ///
        /// 修改域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDnsNameResponse> UpdateDnsNameAsync(UpdateDnsNameRequest updateDnsNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateDnsNameRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-dns",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDnsNameRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDnsNameResponse>(response);
        }
        
        /// <summary>
        /// 修改指定实例的参数
        ///
        /// 修改指定实例的参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceConfigurationResponse> UpdateInstanceConfigurationAsync(UpdateInstanceConfigurationRequest updateInstanceConfigurationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceConfigurationRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConfigurationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateInstanceConfigurationResponse>(response);
        }
        
        /// <summary>
        /// 修改指定实例的参数
        ///
        /// 修改指定实例的参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceConfigurationAsyncResponse> UpdateInstanceConfigurationAsyncAsync(UpdateInstanceConfigurationAsyncRequest updateInstanceConfigurationAsyncRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceConfigurationAsyncRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConfigurationAsyncRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateInstanceConfigurationAsyncResponse>(response);
        }
        
        /// <summary>
        /// 修改实例名称
        ///
        /// 修改实例名称。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceNameResponse> UpdateInstanceNameAsync(UpdateInstanceNameRequest updateInstanceNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceNameRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/name",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceNameRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateInstanceNameResponse>(response);
        }
        
        /// <summary>
        /// 修改数据库端口
        ///
        /// 修改数据库端口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePortResponse> UpdatePortAsync(UpdatePortRequest updatePortRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updatePortRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePortRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePortResponse>(response);
        }
        
        /// <summary>
        /// 修改实例备注信息
        ///
        /// 修改指定数据库实例的备注信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePostgresqlInstanceAliasResponse> UpdatePostgresqlInstanceAliasAsync(UpdatePostgresqlInstanceAliasRequest updatePostgresqlInstanceAliasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updatePostgresqlInstanceAliasRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/alias",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlInstanceAliasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePostgresqlInstanceAliasResponse>(response);
        }
        
        /// <summary>
        /// 升级内核小版本
        ///
        /// 对实例进行小版本升级。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpgradeDbVersionResponse> UpgradeDbVersionAsync(UpgradeDbVersionRequest upgradeDbVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , upgradeDbVersionRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action/db-upgrade",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpgradeDbVersionResponse>(response);
        }
        
        /// <summary>
        /// 升级内核小版本
        ///
        /// 对实例进行小版本升级。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpgradeDbVersionNewResponse> UpgradeDbVersionNewAsync(UpgradeDbVersionNewRequest upgradeDbVersionNewRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , upgradeDbVersionNewRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbVersionNewRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpgradeDbVersionNewResponse>(response);
        }
        
        /// <summary>
        /// 查询API版本列表
        ///
        /// 查询API版本列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApiVersionResponse> ListApiVersionAsync(ListApiVersionRequest listApiVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/rds",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListApiVersionResponse>(response);
        }
        
        /// <summary>
        /// 查询API版本列表
        ///
        /// 查询API版本列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApiVersionNewResponse> ListApiVersionNewAsync(ListApiVersionNewRequest listApiVersionNewRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionNewRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListApiVersionNewResponse>(response);
        }
        
        /// <summary>
        /// 查询指定的API版本信息
        ///
        /// 查询指定的API版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowApiVersionResponse> ShowApiVersionAsync(ShowApiVersionRequest showApiVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version" , showApiVersionRequest.Version.ToString());
            string urlPath = HttpUtils.AddUrlPath("/rds/{version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }
        
        /// <summary>
        /// 授权数据库帐号
        ///
        /// 授权数据库帐号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AllowDbUserPrivilegeResponse> AllowDbUserPrivilegeAsync(AllowDbUserPrivilegeRequest allowDbUserPrivilegeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , allowDbUserPrivilegeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowDbUserPrivilegeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AllowDbUserPrivilegeResponse>(response);
        }
        
        /// <summary>
        /// 创建数据库
        ///
        /// 创建数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDatabaseResponse> CreateDatabaseAsync(CreateDatabaseRequest createDatabaseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createDatabaseRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDatabaseRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDatabaseResponse>(response);
        }
        
        /// <summary>
        /// 创建数据库用户
        ///
        /// 在指定实例中创建数据库帐号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDbUserResponse> CreateDbUserAsync(CreateDbUserRequest createDbUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createDbUserRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDbUserResponse>(response);
        }
        
        /// <summary>
        /// 删除数据库
        ///
        /// 删除数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDatabaseResponse> DeleteDatabaseAsync(DeleteDatabaseRequest deleteDatabaseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteDatabaseRequest.InstanceId.ToString());
            urlParam.Add("db_name" , deleteDatabaseRequest.DbName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/{db_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteDatabaseResponse>(response);
        }
        
        /// <summary>
        /// 删除数据库用户
        ///
        /// 删除数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDbUserResponse> DeleteDbUserAsync(DeleteDbUserRequest deleteDbUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteDbUserRequest.InstanceId.ToString());
            urlParam.Add("user_name" , deleteDbUserRequest.UserName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/{user_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteDbUserResponse>(response);
        }
        
        /// <summary>
        /// 查询指定用户的已授权数据库
        ///
        /// 查询指定用户的已授权数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuthorizedDatabasesResponse> ListAuthorizedDatabasesAsync(ListAuthorizedDatabasesRequest listAuthorizedDatabasesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listAuthorizedDatabasesRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/database",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorizedDatabasesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAuthorizedDatabasesResponse>(response);
        }
        
        /// <summary>
        /// 查询指定数据库的已授权用户
        ///
        /// 查询指定数据库的已授权用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuthorizedDbUsersResponse> ListAuthorizedDbUsersAsync(ListAuthorizedDbUsersRequest listAuthorizedDbUsersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listAuthorizedDbUsersRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/db_user",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorizedDbUsersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAuthorizedDbUsersResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listDatabasesRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabasesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDatabasesResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库用户列表
        ///
        /// 查询数据库用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDbUsersResponse> ListDbUsersAsync(ListDbUsersRequest listDbUsersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listDbUsersRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbUsersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDbUsersResponse>(response);
        }
        
        /// <summary>
        /// 重置数据库密码
        ///
        /// 重置数据库密码.
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetPwdResponse> ResetPwdAsync(ResetPwdRequest resetPwdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resetPwdRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPwdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<ResetPwdResponse>(response);
        }
        
        /// <summary>
        /// 解除数据库帐号权限
        ///
        /// 解除数据库帐号权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RevokeResponse> RevokeAsync(RevokeRequest revokeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , revokeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<RevokeResponse>(response);
        }
        
        /// <summary>
        /// 设置数据库账号密码
        ///
        /// 设置数据库账号密码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetDbUserPwdResponse> SetDbUserPwdAsync(SetDbUserPwdRequest setDbUserPwdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , setDbUserPwdRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/resetpwd",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setDbUserPwdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<SetDbUserPwdResponse>(response);
        }
        
        /// <summary>
        /// 设置数据库用户只读参数
        ///
        /// 根据业务需求，设置数据库用户只读
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetReadOnlySwitchResponse> SetReadOnlySwitchAsync(SetReadOnlySwitchRequest setReadOnlySwitchRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , setReadOnlySwitchRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/readonly-status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setReadOnlySwitchRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<SetReadOnlySwitchResponse>(response);
        }
        
        /// <summary>
        /// 修改指定实例的数据库备注
        ///
        /// 修改指定实例中的数据库备注。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDatabaseResponse> UpdateDatabaseAsync(UpdateDatabaseRequest updateDatabaseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateDatabaseRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/update",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDatabaseRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpdateDatabaseResponse>(response);
        }
        
        /// <summary>
        /// 修改数据库用户名备注
        ///
        /// 修改数据库用户名备注
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDbUserCommentResponse> UpdateDbUserCommentAsync(UpdateDbUserCommentRequest updateDbUserCommentRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateDbUserCommentRequest.InstanceId.ToString());
            urlParam.Add("user_name" , updateDbUserCommentRequest.UserName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/{user_name}/comment",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDbUserCommentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDbUserCommentResponse>(response);
        }
        
        /// <summary>
        /// 授权数据库帐号
        ///
        /// 在指定实例的数据库中, 设置帐号的权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AllowDbPrivilegeResponse> AllowDbPrivilegeAsync(AllowDbPrivilegeRequest allowDbPrivilegeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , allowDbPrivilegeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowDbPrivilegeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AllowDbPrivilegeResponse>(response);
        }
        
        /// <summary>
        /// 数据库代理规格变更
        ///
        /// 数据库代理实例进行规格变更。
        /// 
        /// - 调用接口前，您需要了解API 认证鉴权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeProxyScaleResponse> ChangeProxyScaleAsync(ChangeProxyScaleRequest changeProxyScaleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , changeProxyScaleRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/scale",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeProxyScaleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ChangeProxyScaleResponse>(response);
        }
        
        /// <summary>
        /// 修改读写分离阈值
        ///
        /// 修改指定实例的读写分离延时阈值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeTheDelayThresholdResponse> ChangeTheDelayThresholdAsync(ChangeTheDelayThresholdRequest changeTheDelayThresholdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , changeTheDelayThresholdRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/delay-threshold",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeTheDelayThresholdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<ChangeTheDelayThresholdResponse>(response);
        }
        
        /// <summary>
        /// 创建数据库
        ///
        /// 在指定实例中创建数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePostgresqlDatabaseResponse> CreatePostgresqlDatabaseAsync(CreatePostgresqlDatabaseRequest createPostgresqlDatabaseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createPostgresqlDatabaseRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostgresqlDatabaseRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePostgresqlDatabaseResponse>(response);
        }
        
        /// <summary>
        /// 创建数据库SCHEMA
        ///
        /// 在指定实例的数据库中, 创建数据库schema。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePostgresqlDatabaseSchemaResponse> CreatePostgresqlDatabaseSchemaAsync(CreatePostgresqlDatabaseSchemaRequest createPostgresqlDatabaseSchemaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createPostgresqlDatabaseSchemaRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostgresqlDatabaseSchemaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePostgresqlDatabaseSchemaResponse>(response);
        }
        
        /// <summary>
        /// 创建数据库用户
        ///
        /// 在指定实例中创建数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePostgresqlDbUserResponse> CreatePostgresqlDbUserAsync(CreatePostgresqlDbUserRequest createPostgresqlDbUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createPostgresqlDbUserRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostgresqlDbUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePostgresqlDbUserResponse>(response);
        }
        
        /// <summary>
        /// 创建插件
        ///
        /// 在指定数据库上创建插件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePostgresqlExtensionResponse> CreatePostgresqlExtensionAsync(CreatePostgresqlExtensionRequest createPostgresqlExtensionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createPostgresqlExtensionRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extensions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostgresqlExtensionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            CreatePostgresqlExtensionResponse createPostgresqlExtensionResponse = JsonUtils.DeSerializeNull<CreatePostgresqlExtensionResponse>(response);
            return createPostgresqlExtensionResponse;
        }
        
        /// <summary>
        /// 删除数据库
        ///
        /// 删除数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePostgresqlDatabaseResponse> DeletePostgresqlDatabaseAsync(DeletePostgresqlDatabaseRequest deletePostgresqlDatabaseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deletePostgresqlDatabaseRequest.InstanceId.ToString());
            urlParam.Add("db_name" , deletePostgresqlDatabaseRequest.DbName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/{db_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePostgresqlDatabaseRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeletePostgresqlDatabaseResponse>(response);
        }
        
        /// <summary>
        /// 删除数据库用户
        ///
        /// 删除数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePostgresqlDbUserResponse> DeletePostgresqlDbUserAsync(DeletePostgresqlDbUserRequest deletePostgresqlDbUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deletePostgresqlDbUserRequest.InstanceId.ToString());
            urlParam.Add("user_name" , deletePostgresqlDbUserRequest.UserName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/{user_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePostgresqlDbUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeletePostgresqlDbUserResponse>(response);
        }
        
        /// <summary>
        /// 删除插件
        ///
        /// 在指定数据库上删除插件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePostgresqlExtensionResponse> DeletePostgresqlExtensionAsync(DeletePostgresqlExtensionRequest deletePostgresqlExtensionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deletePostgresqlExtensionRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extensions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePostgresqlExtensionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeletePostgresqlExtensionResponse deletePostgresqlExtensionResponse = JsonUtils.DeSerializeNull<DeletePostgresqlExtensionResponse>(response);
            return deletePostgresqlExtensionResponse;
        }
        
        /// <summary>
        /// 查询数据库SCHEMA列表
        ///
        /// 查询指定实例的数据库SCHEMA列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPostgresqlDatabaseSchemasResponse> ListPostgresqlDatabaseSchemasAsync(ListPostgresqlDatabaseSchemasRequest listPostgresqlDatabaseSchemasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listPostgresqlDatabaseSchemasRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlDatabaseSchemasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPostgresqlDatabaseSchemasResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库列表
        ///
        /// 查询指定实例中的数据库列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPostgresqlDatabasesResponse> ListPostgresqlDatabasesAsync(ListPostgresqlDatabasesRequest listPostgresqlDatabasesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listPostgresqlDatabasesRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlDatabasesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPostgresqlDatabasesResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库用户列表
        ///
        /// 在指定实例中查询数据库用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPostgresqlDbUserPaginatedResponse> ListPostgresqlDbUserPaginatedAsync(ListPostgresqlDbUserPaginatedRequest listPostgresqlDbUserPaginatedRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listPostgresqlDbUserPaginatedRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlDbUserPaginatedRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPostgresqlDbUserPaginatedResponse>(response);
        }
        
        /// <summary>
        /// 查询插件
        ///
        /// 获取指定数据库的插件信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPostgresqlExtensionResponse> ListPostgresqlExtensionAsync(ListPostgresqlExtensionRequest listPostgresqlExtensionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listPostgresqlExtensionRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extensions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlExtensionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPostgresqlExtensionResponse>(response);
        }
        
        /// <summary>
        /// 解除数据库帐号权限
        ///
        /// 解除数据库帐号权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RevokePostgresqlDbPrivilegeResponse> RevokePostgresqlDbPrivilegeAsync(RevokePostgresqlDbPrivilegeRequest revokePostgresqlDbPrivilegeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , revokePostgresqlDbPrivilegeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokePostgresqlDbPrivilegeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<RevokePostgresqlDbPrivilegeResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库代理可变更的规格
        ///
        /// 查询数据库代理可变更的规格信息。
        /// 
        /// - 调用接口前，您需要了解API 认证鉴权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchQueryScaleComputeFlavorsResponse> SearchQueryScaleComputeFlavorsAsync(SearchQueryScaleComputeFlavorsRequest searchQueryScaleComputeFlavorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , searchQueryScaleComputeFlavorsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/proxy/scale/flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQueryScaleComputeFlavorsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<SearchQueryScaleComputeFlavorsResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库代理可变更的规格
        ///
        /// 查询数据库代理可变更的规格信息。
        /// 
        /// - 调用接口前，您需要了解API 认证鉴权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchQueryScaleFlavorsResponse> SearchQueryScaleFlavorsAsync(SearchQueryScaleFlavorsRequest searchQueryScaleFlavorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , searchQueryScaleFlavorsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/scale/flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQueryScaleFlavorsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<SearchQueryScaleFlavorsResponse>(response);
        }
        
        /// <summary>
        /// 设置数据库用户权限
        ///
        /// 设置数据库用户权限：只读或可读写。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetDatabaseUserPrivilegeResponse> SetDatabaseUserPrivilegeAsync(SetDatabaseUserPrivilegeRequest setDatabaseUserPrivilegeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , setDatabaseUserPrivilegeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/user-privilege",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setDatabaseUserPrivilegeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<SetDatabaseUserPrivilegeResponse>(response);
        }
        
        /// <summary>
        /// 重置数据库帐号密码
        ///
        /// 重置指定数据库帐号的密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetPostgresqlDbUserPwdResponse> SetPostgresqlDbUserPwdAsync(SetPostgresqlDbUserPwdRequest setPostgresqlDbUserPwdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , setPostgresqlDbUserPwdRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/resetpwd",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setPostgresqlDbUserPwdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<SetPostgresqlDbUserPwdResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库代理信息
        ///
        /// 查询指定实例的数据库代理详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInformationAboutDatabaseProxyResponse> ShowInformationAboutDatabaseProxyAsync(ShowInformationAboutDatabaseProxyRequest showInformationAboutDatabaseProxyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showInformationAboutDatabaseProxyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInformationAboutDatabaseProxyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowInformationAboutDatabaseProxyResponse>(response);
        }
        
        /// <summary>
        /// 获取实例指定参数的值
        ///
        /// 获取实例指定参数的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPostgresqlParamValueResponse> ShowPostgresqlParamValueAsync(ShowPostgresqlParamValueRequest showPostgresqlParamValueRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showPostgresqlParamValueRequest.InstanceId.ToString());
            urlParam.Add("name" , showPostgresqlParamValueRequest.Name.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/parameter/{name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPostgresqlParamValueRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPostgresqlParamValueResponse>(response);
        }
        
        /// <summary>
        /// 开启数据库代理
        ///
        /// 为指定实例开启数据库代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartDatabaseProxyResponse> StartDatabaseProxyAsync(StartDatabaseProxyRequest startDatabaseProxyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , startDatabaseProxyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDatabaseProxyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<StartDatabaseProxyResponse>(response);
        }
        
        /// <summary>
        /// 关闭数据库代理
        ///
        /// 为指定实例关闭数据库代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopDatabaseProxyResponse> StopDatabaseProxyAsync(StopDatabaseProxyRequest stopDatabaseProxyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , stopDatabaseProxyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopDatabaseProxyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<StopDatabaseProxyResponse>(response);
        }
        
        /// <summary>
        /// 
        ///
        /// 数据库帐号授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDbUserPrivilegeResponse> UpdateDbUserPrivilegeAsync(UpdateDbUserPrivilegeRequest updateDbUserPrivilegeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateDbUserPrivilegeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user-privilege",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDbUserPrivilegeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateDbUserPrivilegeResponse>(response);
        }
        
        /// <summary>
        /// 修改指定实例的数据库备注
        ///
        /// 修改指定实例中的数据库备注。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePostgresqlDatabaseResponse> UpdatePostgresqlDatabaseAsync(UpdatePostgresqlDatabaseRequest updatePostgresqlDatabaseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updatePostgresqlDatabaseRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/update",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlDatabaseRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpdatePostgresqlDatabaseResponse>(response);
        }
        
        /// <summary>
        /// 修改数据库用户名备注
        ///
        /// 修改数据库用户名备注
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePostgresqlDbUserCommentResponse> UpdatePostgresqlDbUserCommentAsync(UpdatePostgresqlDbUserCommentRequest updatePostgresqlDbUserCommentRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updatePostgresqlDbUserCommentRequest.InstanceId.ToString());
            urlParam.Add("user_name" , updatePostgresqlDbUserCommentRequest.UserName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/{user_name}/comment",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlDbUserCommentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePostgresqlDbUserCommentResponse>(response);
        }
        
        /// <summary>
        /// 修改实例指定参数的值
        ///
        /// 修改实例指定参数的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePostgresqlParameterValueResponse> UpdatePostgresqlParameterValueAsync(UpdatePostgresqlParameterValueRequest updatePostgresqlParameterValueRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updatePostgresqlParameterValueRequest.InstanceId.ToString());
            urlParam.Add("name" , updatePostgresqlParameterValueRequest.Name.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/parameter/{name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlParameterValueRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePostgresqlParameterValueResponse>(response);
        }
        
        /// <summary>
        /// 修改读写分离权重
        ///
        /// 修改指定实例的读写分离权重。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateReadWeightResponse> UpdateReadWeightAsync(UpdateReadWeightRequest updateReadWeightRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateReadWeightRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/weight",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReadWeightRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateReadWeightResponse>(response);
        }
        
        /// <summary>
        /// 授权数据库帐号
        ///
        /// 授权数据库帐号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AllowSqlserverDbUserPrivilegeResponse> AllowSqlserverDbUserPrivilegeAsync(AllowSqlserverDbUserPrivilegeRequest allowSqlserverDbUserPrivilegeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , allowSqlserverDbUserPrivilegeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowSqlserverDbUserPrivilegeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AllowSqlserverDbUserPrivilegeResponse>(response);
        }
        
        /// <summary>
        /// 添加MSDTC
        ///
        /// 添加MSDTC相关主机host地址
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchAddMsdtcsResponse> BatchAddMsdtcsAsync(BatchAddMsdtcsRequest batchAddMsdtcsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , batchAddMsdtcsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/msdtc/host",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddMsdtcsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchAddMsdtcsResponse>(response);
        }
        
        /// <summary>
        /// 创建数据库
        ///
        /// 创建数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSqlserverDatabaseResponse> CreateSqlserverDatabaseAsync(CreateSqlserverDatabaseRequest createSqlserverDatabaseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createSqlserverDatabaseRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSqlserverDatabaseRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSqlserverDatabaseResponse>(response);
        }
        
        /// <summary>
        /// 创建数据库用户
        ///
        /// 创建数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSqlserverDbUserResponse> CreateSqlserverDbUserAsync(CreateSqlserverDbUserRequest createSqlserverDbUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createSqlserverDbUserRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSqlserverDbUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSqlserverDbUserResponse>(response);
        }
        
        /// <summary>
        /// 删除数据库
        ///
        /// 删除数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSqlserverDatabaseResponse> DeleteSqlserverDatabaseAsync(DeleteSqlserverDatabaseRequest deleteSqlserverDatabaseRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteSqlserverDatabaseRequest.InstanceId.ToString());
            urlParam.Add("db_name" , deleteSqlserverDatabaseRequest.DbName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/{db_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlserverDatabaseRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteSqlserverDatabaseResponse>(response);
        }
        
        /// <summary>
        /// 删除数据库
        ///
        /// 删除数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSqlserverDatabaseExResponse> DeleteSqlserverDatabaseExAsync(DeleteSqlserverDatabaseExRequest deleteSqlserverDatabaseExRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteSqlserverDatabaseExRequest.InstanceId.ToString());
            urlParam.Add("db_name" , deleteSqlserverDatabaseExRequest.DbName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/database/{db_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlserverDatabaseExRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteSqlserverDatabaseExResponse>(response);
        }
        
        /// <summary>
        /// 删除数据库用户
        ///
        /// 删除数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSqlserverDbUserResponse> DeleteSqlserverDbUserAsync(DeleteSqlserverDbUserRequest deleteSqlserverDbUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteSqlserverDbUserRequest.InstanceId.ToString());
            urlParam.Add("user_name" , deleteSqlserverDbUserRequest.UserName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/{user_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlserverDbUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteSqlserverDbUserResponse>(response);
        }
        
        /// <summary>
        /// 查询指定数据库的已授权用户
        ///
        /// 查询指定数据库的已授权用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuthorizedSqlserverDbUsersResponse> ListAuthorizedSqlserverDbUsersAsync(ListAuthorizedSqlserverDbUsersRequest listAuthorizedSqlserverDbUsersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listAuthorizedSqlserverDbUsersRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/db_user",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorizedSqlserverDbUsersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAuthorizedSqlserverDbUsersResponse>(response);
        }
        
        /// <summary>
        /// 查询MSDTC的hosts信息
        ///
        /// 查询MSDTC的hosts信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMsdtcHostsResponse> ListMsdtcHostsAsync(ListMsdtcHostsRequest listMsdtcHostsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listMsdtcHostsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/msdtc/hosts",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMsdtcHostsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMsdtcHostsResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库列表
        ///
        /// 查询数据库列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSqlserverDatabasesResponse> ListSqlserverDatabasesAsync(ListSqlserverDatabasesRequest listSqlserverDatabasesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listSqlserverDatabasesRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlserverDatabasesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSqlserverDatabasesResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库用户列表
        ///
        /// 查询数据库用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSqlserverDbUsersResponse> ListSqlserverDbUsersAsync(ListSqlserverDbUsersRequest listSqlserverDbUsersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listSqlserverDbUsersRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlserverDbUsersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSqlserverDbUsersResponse>(response);
        }
        
        /// <summary>
        /// 修改实例字符集
        ///
        /// 修改实例字符集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyCollationResponse> ModifyCollationAsync(ModifyCollationRequest modifyCollationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , modifyCollationRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/collations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyCollationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<ModifyCollationResponse>(response);
        }
        
        /// <summary>
        /// 解除数据库帐号权限
        ///
        /// 解除数据库帐号权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RevokeSqlserverDbUserPrivilegeResponse> RevokeSqlserverDbUserPrivilegeAsync(RevokeSqlserverDbUserPrivilegeRequest revokeSqlserverDbUserPrivilegeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , revokeSqlserverDbUserPrivilegeRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeSqlserverDbUserPrivilegeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<RevokeSqlserverDbUserPrivilegeResponse>(response);
        }
        
    }
}