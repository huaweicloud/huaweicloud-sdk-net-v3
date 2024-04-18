using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3
{
    public partial class GaussDBforopenGaussClient : Client
    {
        public static ClientBuilder<GaussDBforopenGaussClient> NewBuilder()
        {
            return new ClientBuilder<GaussDBforopenGaussClient>();
        }

        
        /// <summary>
        /// 添加实例标签。
        ///
        /// 对指定实例添加用户标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddInstanceTagsResponse AddInstanceTags(AddInstanceTagsRequest addInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addInstanceTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addInstanceTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddInstanceTagsResponse>(response);
        }

        public SyncInvoker<AddInstanceTagsResponse> AddInstanceTagsInvoker(AddInstanceTagsRequest addInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addInstanceTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addInstanceTagsRequest);
            return new SyncInvoker<AddInstanceTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<AddInstanceTagsResponse>);
        }
        
        /// <summary>
        /// 授权数据库帐号
        ///
        /// 在指定实例的数据库中, 设置帐号的权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AllowDbPrivilegesResponse AllowDbPrivileges(AllowDbPrivilegesRequest allowDbPrivilegesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", allowDbPrivilegesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", allowDbPrivilegesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AllowDbPrivilegesResponse>(response);
        }

        public SyncInvoker<AllowDbPrivilegesResponse> AllowDbPrivilegesInvoker(AllowDbPrivilegesRequest allowDbPrivilegesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", allowDbPrivilegesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", allowDbPrivilegesRequest);
            return new SyncInvoker<AllowDbPrivilegesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AllowDbPrivilegesResponse>);
        }
        
        /// <summary>
        /// 绑定/解绑弹性公网IP
        ///
        /// 实例下的节点绑定弹性公网IP/解绑弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AttachEipResponse AttachEip(AttachEipRequest attachEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", attachEipRequest.InstanceId.ToString());
            urlParam.Add("node_id", attachEipRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachEipRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AttachEipResponse>(response);
        }

        public SyncInvoker<AttachEipResponse> AttachEipInvoker(AttachEipRequest attachEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", attachEipRequest.InstanceId.ToString());
            urlParam.Add("node_id", attachEipRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachEipRequest);
            return new SyncInvoker<AttachEipResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachEipResponse>);
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
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyConfigurationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CopyConfigurationResponse>(response);
        }

        public SyncInvoker<CopyConfigurationResponse> CopyConfigurationInvoker(CopyConfigurationRequest copyConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", copyConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyConfigurationRequest);
            return new SyncInvoker<CopyConfigurationResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyConfigurationResponse>);
        }
        
        /// <summary>
        /// 创建参数模板
        ///
        /// 创建参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateConfigurationTemplateResponse CreateConfigurationTemplate(CreateConfigurationTemplateRequest createConfigurationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createConfigurationTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateConfigurationTemplateResponse>(response);
        }

        public SyncInvoker<CreateConfigurationTemplateResponse> CreateConfigurationTemplateInvoker(CreateConfigurationTemplateRequest createConfigurationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createConfigurationTemplateRequest);
            return new SyncInvoker<CreateConfigurationTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateConfigurationTemplateResponse>);
        }
        
        /// <summary>
        /// 创建数据库
        ///
        /// 在指定实例中创建数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDatabaseResponse CreateDatabase(CreateDatabaseRequest createDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDatabaseResponse>(response);
        }

        public SyncInvoker<CreateDatabaseResponse> CreateDatabaseInvoker(CreateDatabaseRequest createDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseRequest);
            return new SyncInvoker<CreateDatabaseResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDatabaseResponse>);
        }
        
        /// <summary>
        /// 创建数据库SCHEMA
        ///
        /// 在指定实例的数据库中, 创建数据库schema。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDatabaseSchemasResponse CreateDatabaseSchemas(CreateDatabaseSchemasRequest createDatabaseSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDatabaseSchemasRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseSchemasRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDatabaseSchemasResponse>(response);
        }

        public SyncInvoker<CreateDatabaseSchemasResponse> CreateDatabaseSchemasInvoker(CreateDatabaseSchemasRequest createDatabaseSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDatabaseSchemasRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseSchemasRequest);
            return new SyncInvoker<CreateDatabaseSchemasResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDatabaseSchemasResponse>);
        }
        
        /// <summary>
        /// 创建数据库实例
        ///
        /// 创建数据库实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDbInstanceResponse CreateDbInstance(CreateDbInstanceRequest createDbInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDbInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDbInstanceResponse>(response);
        }

        public SyncInvoker<CreateDbInstanceResponse> CreateDbInstanceInvoker(CreateDbInstanceRequest createDbInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDbInstanceRequest);
            return new SyncInvoker<CreateDbInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDbInstanceResponse>);
        }
        
        /// <summary>
        /// 创建数据库用户
        ///
        /// 在指定实例中创建数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDbUserResponse CreateDbUser(CreateDbUserRequest createDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDbUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDbUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDbUserResponse>(response);
        }

        public SyncInvoker<CreateDbUserResponse> CreateDbUserInvoker(CreateDbUserRequest createDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDbUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDbUserRequest);
            return new SyncInvoker<CreateDbUserResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDbUserResponse>);
        }
        
        /// <summary>
        /// 创建数据库实例
        ///
        /// 创建数据库企业版和集中式实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceResponse>(response);
        }

        public SyncInvoker<CreateInstanceResponse> CreateInstanceInvoker(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstanceRequest);
            return new SyncInvoker<CreateInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceResponse>);
        }
        
        /// <summary>
        /// 创建手动备份
        ///
        /// 创建手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateManualBackupResponse CreateManualBackup(CreateManualBackupRequest createManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createManualBackupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateManualBackupResponse>(response);
        }

        public SyncInvoker<CreateManualBackupResponse> CreateManualBackupInvoker(CreateManualBackupRequest createManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createManualBackupRequest);
            return new SyncInvoker<CreateManualBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateManualBackupResponse>);
        }
        
        /// <summary>
        /// 恢复到新实例
        ///
        /// 根据备份恢复新实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRestoreInstanceResponse CreateRestoreInstance(CreateRestoreInstanceRequest createRestoreInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRestoreInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRestoreInstanceResponse>(response);
        }

        public SyncInvoker<CreateRestoreInstanceResponse> CreateRestoreInstanceInvoker(CreateRestoreInstanceRequest createRestoreInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRestoreInstanceRequest);
            return new SyncInvoker<CreateRestoreInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRestoreInstanceResponse>);
        }
        
        /// <summary>
        /// 创建慢日志下载信息
        ///
        /// 创建慢日志下载信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSlowLogDownloadResponse CreateSlowLogDownload(CreateSlowLogDownloadRequest createSlowLogDownloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createSlowLogDownloadRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-log/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSlowLogDownloadRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSlowLogDownloadResponse>(response);
        }

        public SyncInvoker<CreateSlowLogDownloadResponse> CreateSlowLogDownloadInvoker(CreateSlowLogDownloadRequest createSlowLogDownloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createSlowLogDownloadRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-log/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSlowLogDownloadRequest);
            return new SyncInvoker<CreateSlowLogDownloadResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSlowLogDownloadResponse>);
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
        /// 删除数据库
        ///
        /// 删除指定实例的数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDatabaseResponse DeleteDatabase(DeleteDatabaseRequest deleteDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDatabaseResponse>(response);
        }

        public SyncInvoker<DeleteDatabaseResponse> DeleteDatabaseInvoker(DeleteDatabaseRequest deleteDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseRequest);
            return new SyncInvoker<DeleteDatabaseResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDatabaseResponse>);
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
        /// 删除实例标签
        ///
        /// 删除实例标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceTagResponse DeleteInstanceTag(DeleteInstanceTagRequest deleteInstanceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceTagRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInstanceTagResponse>(response);
        }

        public SyncInvoker<DeleteInstanceTagResponse> DeleteInstanceTagInvoker(DeleteInstanceTagRequest deleteInstanceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceTagRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceTagRequest);
            return new SyncInvoker<DeleteInstanceTagResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteInstanceTagResponse>);
        }
        
        /// <summary>
        /// 删除任务记录
        ///
        /// 删除任务记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteJobResponse DeleteJob(DeleteJobRequest deleteJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJobRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteJobResponse>(response);
        }

        public SyncInvoker<DeleteJobResponse> DeleteJobInvoker(DeleteJobRequest deleteJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJobRequest);
            return new SyncInvoker<DeleteJobResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteJobResponse>);
        }
        
        /// <summary>
        /// 删除手动备份
        ///
        /// 删除手动备份。
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
            return JsonUtils.DeSerializeNull<DeleteManualBackupResponse>(response);
        }

        public SyncInvoker<DeleteManualBackupResponse> DeleteManualBackupInvoker(DeleteManualBackupRequest deleteManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteManualBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteManualBackupRequest);
            return new SyncInvoker<DeleteManualBackupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteManualBackupResponse>);
        }
        
        /// <summary>
        /// 获取备份下载链接
        ///
        /// 获取备份下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadBackupResponse DownloadBackup(DownloadBackupRequest downloadBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backup-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadBackupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadBackupResponse>(response);
        }

        public SyncInvoker<DownloadBackupResponse> DownloadBackupInvoker(DownloadBackupRequest downloadBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backup-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadBackupRequest);
            return new SyncInvoker<DownloadBackupResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadBackupResponse>);
        }
        
        /// <summary>
        /// 查询可应用实例列表
        ///
        /// 查询可应用当前参数组模板的实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListApplicableInstancesResponse ListApplicableInstances(ListApplicableInstancesRequest listApplicableInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", listApplicableInstancesRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applicable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicableInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApplicableInstancesResponse>(response);
        }

        public SyncInvoker<ListApplicableInstancesResponse> ListApplicableInstancesInvoker(ListApplicableInstancesRequest listApplicableInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", listApplicableInstancesRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applicable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicableInstancesRequest);
            return new SyncInvoker<ListApplicableInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicableInstancesResponse>);
        }
        
        /// <summary>
        /// 查询参数模板的应用记录
        ///
        /// 查询参数模板的应用记录，以实例级别为维度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAppliedHistoriesResponse ListAppliedHistories(ListAppliedHistoriesRequest listAppliedHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", listAppliedHistoriesRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applied-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppliedHistoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAppliedHistoriesResponse>(response);
        }

        public SyncInvoker<ListAppliedHistoriesResponse> ListAppliedHistoriesInvoker(ListAppliedHistoriesRequest listAppliedHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", listAppliedHistoriesRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applied-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppliedHistoriesRequest);
            return new SyncInvoker<ListAppliedHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppliedHistoriesResponse>);
        }
        
        /// <summary>
        /// 查询实例可变更规格
        ///
        /// 查询实例可变更规格列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAvailableFlavorsResponse ListAvailableFlavors(ListAvailableFlavorsRequest listAvailableFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAvailableFlavorsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/available-flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableFlavorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAvailableFlavorsResponse>(response);
        }

        public SyncInvoker<ListAvailableFlavorsResponse> ListAvailableFlavorsInvoker(ListAvailableFlavorsRequest listAvailableFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAvailableFlavorsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/available-flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableFlavorsRequest);
            return new SyncInvoker<ListAvailableFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailableFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询备份列表
        ///
        /// 获取备份列表。
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
        /// 查询实例已绑定EIP列表
        ///
        /// 查询实例已绑定EIP列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBindedEipsResponse ListBindedEips(ListBindedEipsRequest listBindedEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBindedEipsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBindedEipsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBindedEipsResponse>(response);
        }

        public SyncInvoker<ListBindedEipsResponse> ListBindedEipsInvoker(ListBindedEipsRequest listBindedEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBindedEipsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBindedEipsRequest);
            return new SyncInvoker<ListBindedEipsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBindedEipsResponse>);
        }
        
        /// <summary>
        /// 查询协调节点列表
        ///
        /// 查询协调节点列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCnInfosBeforeReduceResponse ListCnInfosBeforeReduce(ListCnInfosBeforeReduceRequest listCnInfosBeforeReduceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listCnInfosBeforeReduceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/coordinators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCnInfosBeforeReduceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCnInfosBeforeReduceResponse>(response);
        }

        public SyncInvoker<ListCnInfosBeforeReduceResponse> ListCnInfosBeforeReduceInvoker(ListCnInfosBeforeReduceRequest listCnInfosBeforeReduceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listCnInfosBeforeReduceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/coordinators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCnInfosBeforeReduceRequest);
            return new SyncInvoker<ListCnInfosBeforeReduceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCnInfosBeforeReduceResponse>);
        }
        
        /// <summary>
        /// 查询实例的组件列表
        ///
        /// 查询实例的组件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListComponentInfosResponse ListComponentInfos(ListComponentInfosRequest listComponentInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listComponentInfosRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/components", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listComponentInfosRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListComponentInfosResponse>(response);
        }

        public SyncInvoker<ListComponentInfosResponse> ListComponentInfosInvoker(ListComponentInfosRequest listComponentInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listComponentInfosRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/components", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listComponentInfosRequest);
            return new SyncInvoker<ListComponentInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListComponentInfosResponse>);
        }
        
        /// <summary>
        /// 获取参数模板列表
        ///
        /// 获取参数模板列表，包括所有数据库的默认参数模板和用户创建的参数模板。
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
        /// 比较两个参数组模板之间的差异
        ///
        /// 获取两个参数配置模板的差异列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConfigurationsDiffResponse ListConfigurationsDiff(ListConfigurationsDiffRequest listConfigurationsDiffRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/comparison", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listConfigurationsDiffRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListConfigurationsDiffResponse>(response);
        }

        public SyncInvoker<ListConfigurationsDiffResponse> ListConfigurationsDiffInvoker(ListConfigurationsDiffRequest listConfigurationsDiffRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/comparison", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listConfigurationsDiffRequest);
            return new SyncInvoker<ListConfigurationsDiffResponse>(this, "POST", request, JsonUtils.DeSerialize<ListConfigurationsDiffResponse>);
        }
        
        /// <summary>
        /// 查询数据库SCHEMA列表
        ///
        /// 查询指定实例的数据库SCHEMA列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDatabaseSchemasResponse ListDatabaseSchemas(ListDatabaseSchemasRequest listDatabaseSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabaseSchemasRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schemas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseSchemasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDatabaseSchemasResponse>(response);
        }

        public SyncInvoker<ListDatabaseSchemasResponse> ListDatabaseSchemasInvoker(ListDatabaseSchemasRequest listDatabaseSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabaseSchemasRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schemas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseSchemasRequest);
            return new SyncInvoker<ListDatabaseSchemasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabaseSchemasResponse>);
        }
        
        /// <summary>
        /// 查询数据库列表
        ///
        /// 查询指定实例中的数据库列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDatabasesResponse ListDatabases(ListDatabasesRequest listDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabasesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDatabasesResponse>(response);
        }

        public SyncInvoker<ListDatabasesResponse> ListDatabasesInvoker(ListDatabasesRequest listDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabasesRequest);
            return new SyncInvoker<ListDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabasesResponse>);
        }
        
        /// <summary>
        /// 查询数据库引擎的版本
        ///
        /// 查询指定数据库引擎对应的版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDatastoresResponse ListDatastores(ListDatastoresRequest listDatastoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastore/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoresRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDatastoresResponse>(response);
        }

        public SyncInvoker<ListDatastoresResponse> ListDatastoresInvoker(ListDatastoresRequest listDatastoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastore/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoresRequest);
            return new SyncInvoker<ListDatastoresResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatastoresResponse>);
        }
        
        /// <summary>
        /// 查询备份列表
        ///
        /// 获取备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDbBackupsResponse ListDbBackups(ListDbBackupsRequest listDbBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbBackupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDbBackupsResponse>(response);
        }

        public SyncInvoker<ListDbBackupsResponse> ListDbBackupsInvoker(ListDbBackupsRequest listDbBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbBackupsRequest);
            return new SyncInvoker<ListDbBackupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDbBackupsResponse>);
        }
        
        /// <summary>
        /// 查询数据库规格
        ///
        /// 查询数据库的规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDbFlavorsResponse ListDbFlavors(ListDbFlavorsRequest listDbFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbFlavorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDbFlavorsResponse>(response);
        }

        public SyncInvoker<ListDbFlavorsResponse> ListDbFlavorsInvoker(ListDbFlavorsRequest listDbFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbFlavorsRequest);
            return new SyncInvoker<ListDbFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDbFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询数据库用户列表
        ///
        /// 在指定实例中查询数据库用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDbUsersResponse ListDbUsers(ListDbUsersRequest listDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDbUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDbUsersResponse>(response);
        }

        public SyncInvoker<ListDbUsersResponse> ListDbUsersInvoker(ListDbUsersRequest listDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDbUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbUsersRequest);
            return new SyncInvoker<ListDbUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDbUsersResponse>);
        }
        
        /// <summary>
        /// 查询企业项目配额组
        ///
        /// 查询企业项目配额组信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEpsQuotasResponse ListEpsQuotas(ListEpsQuotasRequest listEpsQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEpsQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEpsQuotasResponse>(response);
        }

        public SyncInvoker<ListEpsQuotasResponse> ListEpsQuotasInvoker(ListEpsQuotasRequest listEpsQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEpsQuotasRequest);
            return new SyncInvoker<ListEpsQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEpsQuotasResponse>);
        }
        
        /// <summary>
        /// 查询数据库规格
        ///
        /// 查询数据库的规格信息。
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
        /// 查询引擎列表
        ///
        /// 查询引擎列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGaussDbDatastoresResponse ListGaussDbDatastores(ListGaussDbDatastoresRequest listGaussDbDatastoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussDbDatastoresRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGaussDbDatastoresResponse>(response);
        }

        public SyncInvoker<ListGaussDbDatastoresResponse> ListGaussDbDatastoresInvoker(ListGaussDbDatastoresRequest listGaussDbDatastoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussDbDatastoresRequest);
            return new SyncInvoker<ListGaussDbDatastoresResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGaussDbDatastoresResponse>);
        }
        
        /// <summary>
        /// 查询参数模板的修改历史
        ///
        /// 查询参数模板的修改历史记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHistoryOperationsResponse ListHistoryOperations(ListHistoryOperationsRequest listHistoryOperationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", listHistoryOperationsRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryOperationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHistoryOperationsResponse>(response);
        }

        public SyncInvoker<ListHistoryOperationsResponse> ListHistoryOperationsInvoker(ListHistoryOperationsRequest listHistoryOperationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", listHistoryOperationsRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryOperationsRequest);
            return new SyncInvoker<ListHistoryOperationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHistoryOperationsResponse>);
        }
        
        /// <summary>
        /// 查询错误日志下载链接
        ///
        /// 查询数据库错误日志下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceErrorLogsResponse ListInstanceErrorLogs(ListInstanceErrorLogsRequest listInstanceErrorLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceErrorLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceErrorLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceErrorLogsResponse>(response);
        }

        public SyncInvoker<ListInstanceErrorLogsResponse> ListInstanceErrorLogsInvoker(ListInstanceErrorLogsRequest listInstanceErrorLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceErrorLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceErrorLogsRequest);
            return new SyncInvoker<ListInstanceErrorLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceErrorLogsResponse>);
        }
        
        /// <summary>
        /// 查询实例标签
        ///
        /// 查询指定实例的用户标签信息。
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
        /// 查询数据库实例列表/查询实例详情
        ///
        /// 查询数据库实例列表/查询实例详情
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
        /// 查询数据库实例列表/查询实例详情
        ///
        /// 查询数据库实例列表/查询实例详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstancesDetailsResponse ListInstancesDetails(ListInstancesDetailsRequest listInstancesDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesDetailsResponse>(response);
        }

        public SyncInvoker<ListInstancesDetailsResponse> ListInstancesDetailsInvoker(ListInstancesDetailsRequest listInstancesDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesDetailsRequest);
            return new SyncInvoker<ListInstancesDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesDetailsResponse>);
        }
        
        /// <summary>
        /// 获取参数模板列表
        ///
        /// 获取参数模板列表，包括所有数据库的默认参数模板和用户创建的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListParamGroupTemplatesResponse ListParamGroupTemplates(ListParamGroupTemplatesRequest listParamGroupTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listParamGroupTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListParamGroupTemplatesResponse>(response);
        }

        public SyncInvoker<ListParamGroupTemplatesResponse> ListParamGroupTemplatesInvoker(ListParamGroupTemplatesRequest listParamGroupTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listParamGroupTemplatesRequest);
            return new SyncInvoker<ListParamGroupTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListParamGroupTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询预定义标签
        ///
        /// 查询预预定义标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPredefinedTagsResponse ListPredefinedTags(ListPredefinedTagsRequest listPredefinedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/predefined-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPredefinedTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPredefinedTagsResponse>(response);
        }

        public SyncInvoker<ListPredefinedTagsResponse> ListPredefinedTagsInvoker(ListPredefinedTagsRequest listPredefinedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/predefined-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPredefinedTagsRequest);
            return new SyncInvoker<ListPredefinedTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPredefinedTagsResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询项目下所有用户标签信息。
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
        /// 查询回收站所有引擎实例列表。
        ///
        /// 查询回收站所有引擎实例列表。
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
        /// 查询可用于备份恢复的实例列表
        ///
        /// 查询可用于备份恢复的实例列表，实例信息要符合备份条件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRestorableInstancesResponse ListRestorableInstances(ListRestorableInstancesRequest listRestorableInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/restorable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestorableInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRestorableInstancesResponse>(response);
        }

        public SyncInvoker<ListRestorableInstancesResponse> ListRestorableInstancesInvoker(ListRestorableInstancesRequest listRestorableInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/restorable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestorableInstancesRequest);
            return new SyncInvoker<ListRestorableInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestorableInstancesResponse>);
        }
        
        /// <summary>
        /// 查询可恢复时间段
        ///
        /// 查询可恢复时间段。
        /// 如果您备份策略中的保存天数设置较长，建议您传入查询日期“date”。
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
        /// 查询数据库磁盘类型
        ///
        /// 查询指定数据库引擎对应的磁盘类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStorageTypesResponse ListStorageTypes(ListStorageTypesRequest listStorageTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/storage-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageTypesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListStorageTypesResponse>(response);
        }

        public SyncInvoker<ListStorageTypesResponse> ListStorageTypesInvoker(ListStorageTypesRequest listStorageTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/storage-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageTypesRequest);
            return new SyncInvoker<ListStorageTypesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStorageTypesResponse>);
        }
        
        /// <summary>
        /// 查询任务列表
        ///
        /// 获取任务中心的任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTasksResponse ListTasks(ListTasksRequest listTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTasksResponse>(response);
        }

        public SyncInvoker<ListTasksResponse> ListTasksInvoker(ListTasksRequest listTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTasksRequest);
            return new SyncInvoker<ListTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTasksResponse>);
        }
        
        /// <summary>
        /// 查询Top IO列表
        ///
        /// 查询实例数据库进程下的Top IO流量数据，返回与会话信息相关联后的结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTopIoTrafficsResponse ListTopIoTraffics(ListTopIoTrafficsRequest listTopIoTrafficsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listTopIoTrafficsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/top-io-traffics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopIoTrafficsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTopIoTrafficsResponse>(response);
        }

        public SyncInvoker<ListTopIoTrafficsResponse> ListTopIoTrafficsInvoker(ListTopIoTrafficsRequest listTopIoTrafficsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listTopIoTrafficsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/top-io-traffics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopIoTrafficsRequest);
            return new SyncInvoker<ListTopIoTrafficsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTopIoTrafficsResponse>);
        }
        
        /// <summary>
        /// 修改企业项目配额
        ///
        /// 修改企业项目配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyEpsQuotaResponse ModifyEpsQuota(ModifyEpsQuotaRequest modifyEpsQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyEpsQuotaRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ModifyEpsQuotaResponse>(response);
        }

        public SyncInvoker<ModifyEpsQuotaResponse> ModifyEpsQuotaInvoker(ModifyEpsQuotaRequest modifyEpsQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyEpsQuotaRequest);
            return new SyncInvoker<ModifyEpsQuotaResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ModifyEpsQuotaResponse>);
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
        /// 重置数据库密码。
        ///
        /// 重置数据库密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetPwdResponse ResetPwd(ResetPwdRequest resetPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetPwdRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetPwdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ResetPwdResponse>(response);
        }

        public SyncInvoker<ResetPwdResponse> ResetPwdInvoker(ResetPwdRequest resetPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetPwdRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetPwdRequest);
            return new SyncInvoker<ResetPwdResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetPwdResponse>);
        }
        
        /// <summary>
        /// GaussDB数据库实例规格变更
        ///
        /// GaussDB数据库实例规格变更
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResizeInstanceFlavorResponse ResizeInstanceFlavor(ResizeInstanceFlavorRequest resizeInstanceFlavorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceFlavorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/flavor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeInstanceFlavorRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ResizeInstanceFlavorResponse>(response);
        }

        public SyncInvoker<ResizeInstanceFlavorResponse> ResizeInstanceFlavorInvoker(ResizeInstanceFlavorRequest resizeInstanceFlavorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceFlavorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/flavor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeInstanceFlavorRequest);
            return new SyncInvoker<ResizeInstanceFlavorResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResizeInstanceFlavorResponse>);
        }
        
        /// <summary>
        /// 重启数据库实例
        ///
        /// 重启数据库实例。
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
        /// CN横向扩容/DN分片扩容/磁盘扩容
        ///
        /// CN横向扩容/DN分片扩容/磁盘扩容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunInstanceActionResponse RunInstanceAction(RunInstanceActionRequest runInstanceActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", runInstanceActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runInstanceActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunInstanceActionResponse>(response);
        }

        public SyncInvoker<RunInstanceActionResponse> RunInstanceActionInvoker(RunInstanceActionRequest runInstanceActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", runInstanceActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runInstanceActionRequest);
            return new SyncInvoker<RunInstanceActionResponse>(this, "POST", request, JsonUtils.DeSerialize<RunInstanceActionResponse>);
        }
        
        /// <summary>
        /// 查询磁盘自动扩容策略
        ///
        /// 查询磁盘自动扩容策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchAutoEnlargePolicyResponse SearchAutoEnlargePolicy(SearchAutoEnlargePolicyRequest searchAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", searchAutoEnlargePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auto-enlarge-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchAutoEnlargePolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchAutoEnlargePolicyResponse>(response);
        }

        public SyncInvoker<SearchAutoEnlargePolicyResponse> SearchAutoEnlargePolicyInvoker(SearchAutoEnlargePolicyRequest searchAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", searchAutoEnlargePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auto-enlarge-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchAutoEnlargePolicyRequest);
            return new SyncInvoker<SearchAutoEnlargePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchAutoEnlargePolicyResponse>);
        }
        
        /// <summary>
        /// 设置自动备份策略。
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
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setBackupPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetBackupPolicyResponse>(response);
        }

        public SyncInvoker<SetBackupPolicyResponse> SetBackupPolicyInvoker(SetBackupPolicyRequest setBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setBackupPolicyRequest);
            return new SyncInvoker<SetBackupPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetBackupPolicyResponse>);
        }
        
        /// <summary>
        /// 重置数据库帐号密码
        ///
        /// 重置指定数据库帐号的密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetDbUserPwdResponse SetDbUserPwd(SetDbUserPwdRequest setDbUserPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setDbUserPwdRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setDbUserPwdRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetDbUserPwdResponse>(response);
        }

        public SyncInvoker<SetDbUserPwdResponse> SetDbUserPwdInvoker(SetDbUserPwdRequest setDbUserPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setDbUserPwdRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setDbUserPwdRequest);
            return new SyncInvoker<SetDbUserPwdResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetDbUserPwdResponse>);
        }
        
        /// <summary>
        /// 设置回收站策略
        ///
        /// 设置回收站策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetRecyclePolicyResponse SetRecyclePolicy(SetRecyclePolicyRequest setRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setRecyclePolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SetRecyclePolicyResponse>(response);
        }

        public SyncInvoker<SetRecyclePolicyResponse> SetRecyclePolicyInvoker(SetRecyclePolicyRequest setRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setRecyclePolicyRequest);
            return new SyncInvoker<SetRecyclePolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetRecyclePolicyResponse>);
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
        /// 查询实例主备平衡状态
        ///
        /// 查询实例是否发生过主备切换而导致主机负载不均衡。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBalanceStatusResponse ShowBalanceStatus(ShowBalanceStatusRequest showBalanceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBalanceStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBalanceStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBalanceStatusResponse>(response);
        }

        public SyncInvoker<ShowBalanceStatusResponse> ShowBalanceStatusInvoker(ShowBalanceStatusRequest showBalanceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBalanceStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBalanceStatusRequest);
            return new SyncInvoker<ShowBalanceStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBalanceStatusResponse>);
        }
        
        /// <summary>
        /// 查询参数模板详情
        ///
        /// 根据参数模板ID获取指定参数模板详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConfigurationDetailResponse ShowConfigurationDetail(ShowConfigurationDetailRequest showConfigurationDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showConfigurationDetailRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigurationDetailResponse>(response);
        }

        public SyncInvoker<ShowConfigurationDetailResponse> ShowConfigurationDetailInvoker(ShowConfigurationDetailRequest showConfigurationDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showConfigurationDetailRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationDetailRequest);
            return new SyncInvoker<ShowConfigurationDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigurationDetailResponse>);
        }
        
        /// <summary>
        /// 查询解决方案模板配置
        ///
        /// 根据解决方案模板名称或实例ID查询副本数、分片数、节点数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDeploymentFormResponse ShowDeploymentForm(ShowDeploymentFormRequest showDeploymentFormRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/deployment-form", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeploymentFormRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDeploymentFormResponse>(response);
        }

        public SyncInvoker<ShowDeploymentFormResponse> ShowDeploymentFormInvoker(ShowDeploymentFormRequest showDeploymentFormRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/deployment-form", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeploymentFormRequest);
            return new SyncInvoker<ShowDeploymentFormResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeploymentFormResponse>);
        }
        
        /// <summary>
        /// 查询错误日志采集开关状态
        ///
        /// 查询数据库错误日志采集的开关状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowErrorLogSwitchStatusResponse ShowErrorLogSwitchStatus(ShowErrorLogSwitchStatusRequest showErrorLogSwitchStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showErrorLogSwitchStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-log/switch/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showErrorLogSwitchStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowErrorLogSwitchStatusResponse>(response);
        }

        public SyncInvoker<ShowErrorLogSwitchStatusResponse> ShowErrorLogSwitchStatusInvoker(ShowErrorLogSwitchStatusRequest showErrorLogSwitchStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showErrorLogSwitchStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-log/switch/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showErrorLogSwitchStatusRequest);
            return new SyncInvoker<ShowErrorLogSwitchStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowErrorLogSwitchStatusResponse>);
        }
        
        /// <summary>
        /// 获取指定实例的参数模板
        ///
        /// 获取指定实例的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceConfigurationResponse ShowInstanceConfiguration(ShowInstanceConfigurationRequest showInstanceConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigurationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceConfigurationResponse>(response);
        }

        public SyncInvoker<ShowInstanceConfigurationResponse> ShowInstanceConfigurationInvoker(ShowInstanceConfigurationRequest showInstanceConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigurationRequest);
            return new SyncInvoker<ShowInstanceConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceConfigurationResponse>);
        }
        
        /// <summary>
        /// 查询实例存储空间使用信息
        ///
        /// 查询指定实例的存储使用空间和最大空间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceDiskResponse ShowInstanceDisk(ShowInstanceDiskRequest showInstanceDiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceDiskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/volume-usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceDiskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceDiskResponse>(response);
        }

        public SyncInvoker<ShowInstanceDiskResponse> ShowInstanceDiskInvoker(ShowInstanceDiskRequest showInstanceDiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceDiskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/volume-usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceDiskRequest);
            return new SyncInvoker<ShowInstanceDiskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceDiskResponse>);
        }
        
        /// <summary>
        /// 获取指定实例的参数模板
        ///
        /// 获取指定实例的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceParamGroupResponse ShowInstanceParamGroup(ShowInstanceParamGroupRequest showInstanceParamGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceParamGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceParamGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceParamGroupResponse>(response);
        }

        public SyncInvoker<ShowInstanceParamGroupResponse> ShowInstanceParamGroupInvoker(ShowInstanceParamGroupRequest showInstanceParamGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceParamGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceParamGroupRequest);
            return new SyncInvoker<ShowInstanceParamGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceParamGroupResponse>);
        }
        
        /// <summary>
        /// 根据时间点或者备份文件查询原实例信息
        ///
        /// 根据时间点或者备份文件查询原实例信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceSnapshotResponse ShowInstanceSnapshot(ShowInstanceSnapshotRequest showInstanceSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance-snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceSnapshotRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceSnapshotResponse>(response);
        }

        public SyncInvoker<ShowInstanceSnapshotResponse> ShowInstanceSnapshotInvoker(ShowInstanceSnapshotRequest showInstanceSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance-snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceSnapshotRequest);
            return new SyncInvoker<ShowInstanceSnapshotResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceSnapshotResponse>);
        }
        
        /// <summary>
        /// 获取指定ID的任务信息。
        ///
        /// 获取指定ID的任务信息。
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
        /// 查询租户的实例配额
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectQuotasResponse ShowProjectQuotas(ShowProjectQuotasRequest showProjectQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/project-quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectQuotasResponse>(response);
        }

        public SyncInvoker<ShowProjectQuotasResponse> ShowProjectQuotasInvoker(ShowProjectQuotasRequest showProjectQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/project-quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectQuotasRequest);
            return new SyncInvoker<ShowProjectQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectQuotasResponse>);
        }
        
        /// <summary>
        /// 查看回收站策略
        ///
        /// 查看回收站的回收策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecyclePolicyResponse ShowRecyclePolicy(ShowRecyclePolicyRequest showRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecyclePolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRecyclePolicyResponse>(response);
        }

        public SyncInvoker<ShowRecyclePolicyResponse> ShowRecyclePolicyInvoker(ShowRecyclePolicyRequest showRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecyclePolicyRequest);
            return new SyncInvoker<ShowRecyclePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecyclePolicyResponse>);
        }
        
        /// <summary>
        /// 查询慢日志下载信息
        ///
        /// 查询慢日志下载信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSlowLogDownloadResponse ShowSlowLogDownload(ShowSlowLogDownloadRequest showSlowLogDownloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSlowLogDownloadRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-log/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSlowLogDownloadRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSlowLogDownloadResponse>(response);
        }

        public SyncInvoker<ShowSlowLogDownloadResponse> ShowSlowLogDownloadInvoker(ShowSlowLogDownloadRequest showSlowLogDownloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSlowLogDownloadRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-log/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSlowLogDownloadRequest);
            return new SyncInvoker<ShowSlowLogDownloadResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSlowLogDownloadResponse>);
        }
        
        /// <summary>
        /// 查询实例SSL证书下载地址
        ///
        /// 查询实例SSL证书下载地址。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSslCertDownloadLinkResponse ShowSslCertDownloadLink(ShowSslCertDownloadLinkRequest showSslCertDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSslCertDownloadLinkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-cert/download-link", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSslCertDownloadLinkRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSslCertDownloadLinkResponse>(response);
        }

        public SyncInvoker<ShowSslCertDownloadLinkResponse> ShowSslCertDownloadLinkInvoker(ShowSslCertDownloadLinkRequest showSslCertDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSslCertDownloadLinkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-cert/download-link", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSslCertDownloadLinkRequest);
            return new SyncInvoker<ShowSslCertDownloadLinkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSslCertDownloadLinkResponse>);
        }
        
        /// <summary>
        /// 查询实例可升级版本
        ///
        /// 查询实例可升级版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUpgradeCandidateVersionsResponse ShowUpgradeCandidateVersions(ShowUpgradeCandidateVersionsRequest showUpgradeCandidateVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showUpgradeCandidateVersionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade/candidate-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeCandidateVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUpgradeCandidateVersionsResponse>(response);
        }

        public SyncInvoker<ShowUpgradeCandidateVersionsResponse> ShowUpgradeCandidateVersionsInvoker(ShowUpgradeCandidateVersionsRequest showUpgradeCandidateVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showUpgradeCandidateVersionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade/candidate-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeCandidateVersionsRequest);
            return new SyncInvoker<ShowUpgradeCandidateVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUpgradeCandidateVersionsResponse>);
        }
        
        /// <summary>
        /// 启动数据库
        ///
        /// 启动数据库，同时支持节点级别的启动操作
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartInstanceResponse StartInstance(StartInstanceRequest startInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-startup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartInstanceResponse>(response);
        }

        public SyncInvoker<StartInstanceResponse> StartInstanceInvoker(StartInstanceRequest startInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-startup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startInstanceRequest);
            return new SyncInvoker<StartInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StartInstanceResponse>);
        }
        
        /// <summary>
        /// 停止备份
        ///
        /// 停止进行中的备份，包括全备和差备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopBackupResponse StopBackup(StopBackupRequest stopBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", stopBackupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBackupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopBackupResponse>(response);
        }

        public SyncInvoker<StopBackupResponse> StopBackupInvoker(StopBackupRequest stopBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", stopBackupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBackupRequest);
            return new SyncInvoker<StopBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<StopBackupResponse>);
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
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SwitchConfigurationResponse>(response);
        }

        public SyncInvoker<SwitchConfigurationResponse> SwitchConfigurationInvoker(SwitchConfigurationRequest switchConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", switchConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchConfigurationRequest);
            return new SyncInvoker<SwitchConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchConfigurationResponse>);
        }
        
        /// <summary>
        /// 分片节点主备切换。
        ///
        /// 支持用户对单个或多个DN分片做主备切换，同一分组内只能指定一个新的备节点进行升主操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchShardResponse SwitchShard(SwitchShardRequest switchShardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchShardRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switch-shard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchShardRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchShardResponse>(response);
        }

        public SyncInvoker<SwitchShardResponse> SwitchShardInvoker(SwitchShardRequest switchShardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchShardRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switch-shard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchShardRequest);
            return new SyncInvoker<SwitchShardResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchShardResponse>);
        }
        
        /// <summary>
        /// 修改指定实例的参数
        ///
        /// 修改指定实例的参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceConfigurationResponse UpdateInstanceConfiguration(UpdateInstanceConfigurationRequest updateInstanceConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceConfigurationResponse>(response);
        }

        public SyncInvoker<UpdateInstanceConfigurationResponse> UpdateInstanceConfigurationInvoker(UpdateInstanceConfigurationRequest updateInstanceConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceConfigurationRequest);
            return new SyncInvoker<UpdateInstanceConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceConfigurationResponse>);
        }
        
        /// <summary>
        /// 修改实例名称
        ///
        /// 修改实例名称。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceNameResponse UpdateInstanceName(UpdateInstanceNameRequest updateInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceNameRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceNameResponse>(response);
        }

        public SyncInvoker<UpdateInstanceNameResponse> UpdateInstanceNameInvoker(UpdateInstanceNameRequest updateInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceNameRequest);
            return new SyncInvoker<UpdateInstanceNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceNameResponse>);
        }
        
        /// <summary>
        /// 实例内核版本升级
        ///
        /// GaussDB(for openGauss)实例版本升级。包括灰度升级，就地升级，热补丁升级等三种升级方式。 
        /// 就地升级：
        /// 就地升级需要停止业务进行，会一次性升级集群中所有节点。就地升级需要暂停业务30分钟来升级。 
        /// 灰度升级： 
        /// 升级自动提交：所有节点进程一起升级，在升级过程中有大概10秒的业务中断，不阻塞其他业务操作。 
        /// 升级待观察：升级待观察，将数据库升级过程细分为升级，提交两个阶段。升级阶段可以根据部署方式细分为按分片或者按az的滚动升级，提交阶段可以对升级完成后的实例进行业务测试，根据需要可以选择提交升级，或者升级回退。每个主dn或者cn组件升级就有一次10秒业务中断。升级过程均是先管理面，再数据面，由备到主的升级方式。 分布式实例：根据分片数滚动升级，每次滚动升级可以根据选择的分片数进行指定分片数量的节点进行升级。 主备版实例：根据AZ数进行滚动升级，每次滚动升级可以根据选择的AZ进行1个分区或者多个分区进行升级。 
        /// 提交升级：提交升级。在升级完成，进入提交阶段时。业务测试正常后提交升级，完成本次升级流程。
        /// 升级回退：升级回退，在升级完成，进入提交阶段时。可以根据需要回退本次升级，回退到升级前的版本。
        /// 热补丁升级： 
        /// 升级自动提交：热补丁自动升级并提交，中间无业务中断，仅修复产品bug。 
        /// 升级回退：热补丁回退，无业务中断时间
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeInstanceVersionResponse UpgradeInstanceVersion(UpgradeInstanceVersionRequest upgradeInstanceVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeInstanceVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeInstanceVersionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpgradeInstanceVersionResponse>(response);
        }

        public SyncInvoker<UpgradeInstanceVersionResponse> UpgradeInstanceVersionInvoker(UpgradeInstanceVersionRequest upgradeInstanceVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeInstanceVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeInstanceVersionRequest);
            return new SyncInvoker<UpgradeInstanceVersionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpgradeInstanceVersionResponse>);
        }
        
        /// <summary>
        /// 校验参数组名称是否存在
        ///
        /// 校验参数组名称是否存在。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ValidateParaGroupNameResponse ValidateParaGroupName(ValidateParaGroupNameRequest validateParaGroupNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/name-validation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateParaGroupNameRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ValidateParaGroupNameResponse>(response);
        }

        public SyncInvoker<ValidateParaGroupNameResponse> ValidateParaGroupNameInvoker(ValidateParaGroupNameRequest validateParaGroupNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/name-validation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateParaGroupNameRequest);
            return new SyncInvoker<ValidateParaGroupNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ValidateParaGroupNameResponse>);
        }
        
        /// <summary>
        /// 弱密码校验
        ///
        /// 校验数据库root用户密码的安全性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ValidateWeakPasswordResponse ValidateWeakPassword(ValidateWeakPasswordRequest validateWeakPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/weak-password-verification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", validateWeakPasswordRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ValidateWeakPasswordResponse>(response);
        }

        public SyncInvoker<ValidateWeakPasswordResponse> ValidateWeakPasswordInvoker(ValidateWeakPasswordRequest validateWeakPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/weak-password-verification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", validateWeakPasswordRequest);
            return new SyncInvoker<ValidateWeakPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<ValidateWeakPasswordResponse>);
        }
        
    }
}