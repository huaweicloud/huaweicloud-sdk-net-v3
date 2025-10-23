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
        /// 新增客户端接入认证配置
        ///
        /// 新增客户端接入认证配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddHbaConfsResponse AddHbaConfs(AddHbaConfsRequest addHbaConfsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addHbaConfsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addHbaConfsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AddHbaConfsResponse>(response);
        }

        public SyncInvoker<AddHbaConfsResponse> AddHbaConfsInvoker(AddHbaConfsRequest addHbaConfsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addHbaConfsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addHbaConfsRequest);
            return new SyncInvoker<AddHbaConfsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddHbaConfsResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(addInstanceTagsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addInstanceTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddInstanceTagsResponse>(response);
        }

        public SyncInvoker<AddInstanceTagsResponse> AddInstanceTagsInvoker(AddInstanceTagsRequest addInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addInstanceTagsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(allowDbPrivilegesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", allowDbPrivilegesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AllowDbPrivilegesResponse>(response);
        }

        public SyncInvoker<AllowDbPrivilegesResponse> AllowDbPrivilegesInvoker(AllowDbPrivilegesRequest allowDbPrivilegesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(allowDbPrivilegesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", allowDbPrivilegesRequest);
            return new SyncInvoker<AllowDbPrivilegesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AllowDbPrivilegesResponse>);
        }
        
        /// <summary>
        /// 授权数据库角色
        ///
        /// 在数据库中设置角色的权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AllowDbRolePrivilegesResponse AllowDbRolePrivileges(AllowDbRolePrivilegesRequest allowDbRolePrivilegesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(allowDbRolePrivilegesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", allowDbRolePrivilegesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AllowDbRolePrivilegesResponse>(response);
        }

        public SyncInvoker<AllowDbRolePrivilegesResponse> AllowDbRolePrivilegesInvoker(AllowDbRolePrivilegesRequest allowDbRolePrivilegesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(allowDbRolePrivilegesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", allowDbRolePrivilegesRequest);
            return new SyncInvoker<AllowDbRolePrivilegesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AllowDbRolePrivilegesResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(attachEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(attachEipRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachEipRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AttachEipResponse>(response);
        }

        public SyncInvoker<AttachEipResponse> AttachEipInvoker(AttachEipRequest attachEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(attachEipRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachEipRequest);
            return new SyncInvoker<AttachEipResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachEipResponse>);
        }
        
        /// <summary>
        /// 授权备份文件下载
        ///
        /// 授权租户使用OBS Browser+方式下载备份文件，支持实例级、表级的全量备份及差量备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AuthorizeBackupDownloadResponse AuthorizeBackupDownload(AuthorizeBackupDownloadRequest authorizeBackupDownloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(authorizeBackupDownloadRequest.BackupId, out var valueOfBackupId)) urlParam.Add("backup_id", valueOfBackupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/download/authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", authorizeBackupDownloadRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AuthorizeBackupDownloadResponse>(response);
        }

        public SyncInvoker<AuthorizeBackupDownloadResponse> AuthorizeBackupDownloadInvoker(AuthorizeBackupDownloadRequest authorizeBackupDownloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(authorizeBackupDownloadRequest.BackupId, out var valueOfBackupId)) urlParam.Add("backup_id", valueOfBackupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/download/authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", authorizeBackupDownloadRequest);
            return new SyncInvoker<AuthorizeBackupDownloadResponse>(this, "POST", request, JsonUtils.DeSerialize<AuthorizeBackupDownloadResponse>);
        }
        
        /// <summary>
        /// 批量设置自动备份策略
        ///
        /// 批量设置自动备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchSetBackupPolicyResponse BatchSetBackupPolicy(BatchSetBackupPolicyRequest batchSetBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchSetBackupPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchSetBackupPolicyResponse>(response);
        }

        public SyncInvoker<BatchSetBackupPolicyResponse> BatchSetBackupPolicyInvoker(BatchSetBackupPolicyRequest batchSetBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchSetBackupPolicyRequest);
            return new SyncInvoker<BatchSetBackupPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchSetBackupPolicyResponse>);
        }
        
        /// <summary>
        /// 查询批量实例可升级的版本和升级类型
        ///
        /// 查询批量实例可升级的版本和升级类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchShowUpgradeCandidateVersionsResponse BatchShowUpgradeCandidateVersions(BatchShowUpgradeCandidateVersionsRequest batchShowUpgradeCandidateVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/db-upgrade/candidate-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchShowUpgradeCandidateVersionsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchShowUpgradeCandidateVersionsResponse>(response);
        }

        public SyncInvoker<BatchShowUpgradeCandidateVersionsResponse> BatchShowUpgradeCandidateVersionsInvoker(BatchShowUpgradeCandidateVersionsRequest batchShowUpgradeCandidateVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/db-upgrade/candidate-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchShowUpgradeCandidateVersionsRequest);
            return new SyncInvoker<BatchShowUpgradeCandidateVersionsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchShowUpgradeCandidateVersionsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cancelScheduleTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/schedule-task/{task_id}/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelScheduleTaskRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<CancelScheduleTaskResponse>(response);
        }

        public SyncInvoker<CancelScheduleTaskResponse> CancelScheduleTaskInvoker(CancelScheduleTaskRequest cancelScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cancelScheduleTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/schedule-task/{task_id}/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelScheduleTaskRequest);
            return new SyncInvoker<CancelScheduleTaskResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<CancelScheduleTaskResponse>);
        }
        
        /// <summary>
        /// 备份恢复到目标实例数据后执行数据确认
        ///
        /// 确认备份恢复到目标实例的数据正常。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ConfirmRestoredDataResponse ConfirmRestoredData(ConfirmRestoredDataRequest confirmRestoredDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(confirmRestoredDataRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/confirm-restore-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmRestoredDataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ConfirmRestoredDataResponse>(response);
        }

        public SyncInvoker<ConfirmRestoredDataResponse> ConfirmRestoredDataInvoker(ConfirmRestoredDataRequest confirmRestoredDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(confirmRestoredDataRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/confirm-restore-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmRestoredDataRequest);
            return new SyncInvoker<ConfirmRestoredDataResponse>(this, "POST", request, JsonUtils.DeSerialize<ConfirmRestoredDataResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(copyConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyConfigurationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CopyConfigurationResponse>(response);
        }

        public SyncInvoker<CopyConfigurationResponse> CopyConfigurationInvoker(CopyConfigurationRequest copyConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(copyConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
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
        /// 搭建容灾关系
        ///
        /// 搭建容灾关系（从主实例端下发）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCrossCloudConstructDisasterResponse CreateCrossCloudConstructDisaster(CreateCrossCloudConstructDisasterRequest createCrossCloudConstructDisasterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCrossCloudConstructDisasterRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/construct", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCrossCloudConstructDisasterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCrossCloudConstructDisasterResponse>(response);
        }

        public SyncInvoker<CreateCrossCloudConstructDisasterResponse> CreateCrossCloudConstructDisasterInvoker(CreateCrossCloudConstructDisasterRequest createCrossCloudConstructDisasterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCrossCloudConstructDisasterRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/construct", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCrossCloudConstructDisasterRequest);
            return new SyncInvoker<CreateCrossCloudConstructDisasterResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCrossCloudConstructDisasterResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(createDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDatabaseResponse>(response);
        }

        public SyncInvoker<CreateDatabaseResponse> CreateDatabaseInvoker(CreateDatabaseRequest createDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseRequest);
            return new SyncInvoker<CreateDatabaseResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDatabaseResponse>);
        }
        
        /// <summary>
        /// 创建数据库实例
        ///
        /// 创建数据库实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDatabaseInstanceResponse CreateDatabaseInstance(CreateDatabaseInstanceRequest createDatabaseInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDatabaseInstanceResponse>(response);
        }

        public SyncInvoker<CreateDatabaseInstanceResponse> CreateDatabaseInstanceInvoker(CreateDatabaseInstanceRequest createDatabaseInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseInstanceRequest);
            return new SyncInvoker<CreateDatabaseInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDatabaseInstanceResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(createDatabaseSchemasRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseSchemasRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDatabaseSchemasResponse>(response);
        }

        public SyncInvoker<CreateDatabaseSchemasResponse> CreateDatabaseSchemasInvoker(CreateDatabaseSchemasRequest createDatabaseSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDatabaseSchemasRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
        /// 创建数据库角色
        ///
        /// 创建数据库角色。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDbRoleResponse CreateDbRole(CreateDbRoleRequest createDbRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDbRoleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDbRoleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDbRoleResponse>(response);
        }

        public SyncInvoker<CreateDbRoleResponse> CreateDbRoleInvoker(CreateDbRoleRequest createDbRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDbRoleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDbRoleRequest);
            return new SyncInvoker<CreateDbRoleResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDbRoleResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(createDbUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDbUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDbUserResponse>(response);
        }

        public SyncInvoker<CreateDbUserResponse> CreateDbUserInvoker(CreateDbUserRequest createDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDbUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDbUserRequest);
            return new SyncInvoker<CreateDbUserResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDbUserResponse>);
        }
        
        /// <summary>
        /// 创建数据库实例
        ///
        /// 创建数据库实例，仅支持IAM5的新平面认证方式（AK/SK认证方式）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGaussDbInstanceResponse CreateGaussDbInstance(CreateGaussDbInstanceRequest createGaussDbInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussDbInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGaussDbInstanceResponse>(response);
        }

        public SyncInvoker<CreateGaussDbInstanceResponse> CreateGaussDbInstanceInvoker(CreateGaussDbInstanceRequest createGaussDbInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussDbInstanceRequest);
            return new SyncInvoker<CreateGaussDbInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGaussDbInstanceResponse>);
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
        /// 创建只读节点
        ///
        /// 创建只读节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateReadonlyNodesResponse CreateReadonlyNodes(CreateReadonlyNodesRequest createReadonlyNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createReadonlyNodesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/readonly-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createReadonlyNodesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateReadonlyNodesResponse>(response);
        }

        public SyncInvoker<CreateReadonlyNodesResponse> CreateReadonlyNodesInvoker(CreateReadonlyNodesRequest createReadonlyNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createReadonlyNodesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/readonly-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createReadonlyNodesRequest);
            return new SyncInvoker<CreateReadonlyNodesResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateReadonlyNodesResponse>);
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
        /// 批量实例内核版本定时升级
        ///
        /// 批量实例内核版本定时升级
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateScheduleTaskResponse CreateScheduleTask(CreateScheduleTaskRequest createScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/db-upgrade/schedule-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScheduleTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateScheduleTaskResponse>(response);
        }

        public SyncInvoker<CreateScheduleTaskResponse> CreateScheduleTaskInvoker(CreateScheduleTaskRequest createScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/db-upgrade/schedule-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScheduleTaskRequest);
            return new SyncInvoker<CreateScheduleTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateScheduleTaskResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(createSlowLogDownloadRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-log/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSlowLogDownloadRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSlowLogDownloadResponse>(response);
        }

        public SyncInvoker<CreateSlowLogDownloadResponse> CreateSlowLogDownloadInvoker(CreateSlowLogDownloadRequest createSlowLogDownloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSlowLogDownloadRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigurationRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteConfigurationResponse>(response);
        }

        public SyncInvoker<DeleteConfigurationResponse> DeleteConfigurationInvoker(DeleteConfigurationRequest deleteConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDatabaseResponse>(response);
        }

        public SyncInvoker<DeleteDatabaseResponse> DeleteDatabaseInvoker(DeleteDatabaseRequest deleteDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseRequest);
            return new SyncInvoker<DeleteDatabaseResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDatabaseResponse>);
        }
        
        /// <summary>
        /// 删除数据库SCHEMA
        ///
        /// 删除数据库schema。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDatabaseSchemaResponse DeleteDatabaseSchema(DeleteDatabaseSchemaRequest deleteDatabaseSchemaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDatabaseSchemaRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteDatabaseSchemaRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDatabaseSchemaResponse>(response);
        }

        public SyncInvoker<DeleteDatabaseSchemaResponse> DeleteDatabaseSchemaInvoker(DeleteDatabaseSchemaRequest deleteDatabaseSchemaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDatabaseSchemaRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteDatabaseSchemaRequest);
            return new SyncInvoker<DeleteDatabaseSchemaResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDatabaseSchemaResponse>);
        }
        
        /// <summary>
        /// 删除容灾记录
        ///
        /// 删除容灾记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDisasterRecordResponse DeleteDisasterRecord(DeleteDisasterRecordRequest deleteDisasterRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/disaster/record/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteDisasterRecordRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDisasterRecordResponse>(response);
        }

        public SyncInvoker<DeleteDisasterRecordResponse> DeleteDisasterRecordInvoker(DeleteDisasterRecordRequest deleteDisasterRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/disaster/record/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteDisasterRecordRequest);
            return new SyncInvoker<DeleteDisasterRecordResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDisasterRecordResponse>);
        }
        
        /// <summary>
        /// 删除客户端接入认证配置
        ///
        /// 删除客户端接入认证配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteHbaConfsResponse DeleteHbaConfs(DeleteHbaConfsRequest deleteHbaConfsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHbaConfsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteHbaConfsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteHbaConfsResponse>(response);
        }

        public SyncInvoker<DeleteHbaConfsResponse> DeleteHbaConfsInvoker(DeleteHbaConfsRequest deleteHbaConfsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHbaConfsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteHbaConfsRequest);
            return new SyncInvoker<DeleteHbaConfsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteHbaConfsResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInstanceResponse>(response);
        }

        public SyncInvoker<DeleteInstanceResponse> DeleteInstanceInvoker(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceTagRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInstanceTagResponse>(response);
        }

        public SyncInvoker<DeleteInstanceTagResponse> DeleteInstanceTagInvoker(DeleteInstanceTagRequest deleteInstanceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceTagRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJobRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteJobResponse>(response);
        }

        public SyncInvoker<DeleteJobResponse> DeleteJobInvoker(DeleteJobRequest deleteJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteManualBackupRequest.BackupId, out var valueOfBackupId)) urlParam.Add("backup_id", valueOfBackupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteManualBackupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteManualBackupResponse>(response);
        }

        public SyncInvoker<DeleteManualBackupResponse> DeleteManualBackupInvoker(DeleteManualBackupRequest deleteManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteManualBackupRequest.BackupId, out var valueOfBackupId)) urlParam.Add("backup_id", valueOfBackupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteManualBackupRequest);
            return new SyncInvoker<DeleteManualBackupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteManualBackupResponse>);
        }
        
        /// <summary>
        /// 删除只读节点
        ///
        /// 删除只读节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteReadonlyNodesResponse DeleteReadonlyNodes(DeleteReadonlyNodesRequest deleteReadonlyNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteReadonlyNodesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/readonly-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteReadonlyNodesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteReadonlyNodesResponse>(response);
        }

        public SyncInvoker<DeleteReadonlyNodesResponse> DeleteReadonlyNodesInvoker(DeleteReadonlyNodesRequest deleteReadonlyNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteReadonlyNodesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/readonly-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteReadonlyNodesRequest);
            return new SyncInvoker<DeleteReadonlyNodesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteReadonlyNodesResponse>);
        }
        
        /// <summary>
        /// 删除定时任务信息
        ///
        /// 删除定时任务信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteScheduleTaskResponse DeleteScheduleTask(DeleteScheduleTaskRequest deleteScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteScheduleTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/schedule-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScheduleTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteScheduleTaskResponse>(response);
        }

        public SyncInvoker<DeleteScheduleTaskResponse> DeleteScheduleTaskInvoker(DeleteScheduleTaskRequest deleteScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteScheduleTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/schedule-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScheduleTaskRequest);
            return new SyncInvoker<DeleteScheduleTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScheduleTaskResponse>);
        }
        
        /// <summary>
        /// 分片缩容
        ///
        /// 数据库分片缩容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteShardingResponse DeleteSharding(DeleteShardingRequest deleteShardingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteShardingRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sharding", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteShardingRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteShardingResponse>(response);
        }

        public SyncInvoker<DeleteShardingResponse> DeleteShardingInvoker(DeleteShardingRequest deleteShardingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteShardingRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sharding", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteShardingRequest);
            return new SyncInvoker<DeleteShardingResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteShardingResponse>);
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
        /// 主实例结束容灾日志保持
        ///
        /// 结束stream流式容灾的日志保持功能，目前只有stream流容灾支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteCrossCloudDisasterDataCacheEndResponse ExecuteCrossCloudDisasterDataCacheEnd(ExecuteCrossCloudDisasterDataCacheEndRequest executeCrossCloudDisasterDataCacheEndRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeCrossCloudDisasterDataCacheEndRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/keep-log-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterDataCacheEndRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteCrossCloudDisasterDataCacheEndResponse>(response);
        }

        public SyncInvoker<ExecuteCrossCloudDisasterDataCacheEndResponse> ExecuteCrossCloudDisasterDataCacheEndInvoker(ExecuteCrossCloudDisasterDataCacheEndRequest executeCrossCloudDisasterDataCacheEndRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeCrossCloudDisasterDataCacheEndRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/keep-log-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterDataCacheEndRequest);
            return new SyncInvoker<ExecuteCrossCloudDisasterDataCacheEndResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteCrossCloudDisasterDataCacheEndResponse>);
        }
        
        /// <summary>
        /// 开始日志保持
        ///
        /// 主实例开始容灾日志保持，目前只有stream流容灾支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteCrossCloudDisasterDataCacheStartResponse ExecuteCrossCloudDisasterDataCacheStart(ExecuteCrossCloudDisasterDataCacheStartRequest executeCrossCloudDisasterDataCacheStartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeCrossCloudDisasterDataCacheStartRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/keep-log-start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterDataCacheStartRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteCrossCloudDisasterDataCacheStartResponse>(response);
        }

        public SyncInvoker<ExecuteCrossCloudDisasterDataCacheStartResponse> ExecuteCrossCloudDisasterDataCacheStartInvoker(ExecuteCrossCloudDisasterDataCacheStartRequest executeCrossCloudDisasterDataCacheStartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeCrossCloudDisasterDataCacheStartRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/keep-log-start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterDataCacheStartRequest);
            return new SyncInvoker<ExecuteCrossCloudDisasterDataCacheStartResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteCrossCloudDisasterDataCacheStartResponse>);
        }
        
        /// <summary>
        /// 结束容灾演练
        ///
        /// 灾备实例结束容灾演练，目前只有stream流容灾支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteCrossCloudDisasterEndSimulationResponse ExecuteCrossCloudDisasterEndSimulation(ExecuteCrossCloudDisasterEndSimulationRequest executeCrossCloudDisasterEndSimulationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeCrossCloudDisasterEndSimulationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/simulation-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterEndSimulationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteCrossCloudDisasterEndSimulationResponse>(response);
        }

        public SyncInvoker<ExecuteCrossCloudDisasterEndSimulationResponse> ExecuteCrossCloudDisasterEndSimulationInvoker(ExecuteCrossCloudDisasterEndSimulationRequest executeCrossCloudDisasterEndSimulationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeCrossCloudDisasterEndSimulationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/simulation-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterEndSimulationRequest);
            return new SyncInvoker<ExecuteCrossCloudDisasterEndSimulationResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteCrossCloudDisasterEndSimulationResponse>);
        }
        
        /// <summary>
        /// 备实例容灾升主
        ///
        /// 容灾升主failover（灾备实例端下发）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteCrossCloudDisasterRecoveryFailoverResponse ExecuteCrossCloudDisasterRecoveryFailover(ExecuteCrossCloudDisasterRecoveryFailoverRequest executeCrossCloudDisasterRecoveryFailoverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeCrossCloudDisasterRecoveryFailoverRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/failover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterRecoveryFailoverRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteCrossCloudDisasterRecoveryFailoverResponse>(response);
        }

        public SyncInvoker<ExecuteCrossCloudDisasterRecoveryFailoverResponse> ExecuteCrossCloudDisasterRecoveryFailoverInvoker(ExecuteCrossCloudDisasterRecoveryFailoverRequest executeCrossCloudDisasterRecoveryFailoverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeCrossCloudDisasterRecoveryFailoverRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/failover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterRecoveryFailoverRequest);
            return new SyncInvoker<ExecuteCrossCloudDisasterRecoveryFailoverResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteCrossCloudDisasterRecoveryFailoverResponse>);
        }
        
        /// <summary>
        /// 重建容灾关系
        ///
        /// 流容灾备升主选择支持容灾回切，实现容灾关系的重建任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteCrossCloudDisasterRestoreResponse ExecuteCrossCloudDisasterRestore(ExecuteCrossCloudDisasterRestoreRequest executeCrossCloudDisasterRestoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeCrossCloudDisasterRestoreRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterRestoreRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteCrossCloudDisasterRestoreResponse>(response);
        }

        public SyncInvoker<ExecuteCrossCloudDisasterRestoreResponse> ExecuteCrossCloudDisasterRestoreInvoker(ExecuteCrossCloudDisasterRestoreRequest executeCrossCloudDisasterRestoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeCrossCloudDisasterRestoreRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterRestoreRequest);
            return new SyncInvoker<ExecuteCrossCloudDisasterRestoreResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteCrossCloudDisasterRestoreResponse>);
        }
        
        /// <summary>
        /// 开始容灾演练
        ///
        /// 开始容灾演练，目前只有stream流容灾支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteCrossCloudDisasterStartSimulationResponse ExecuteCrossCloudDisasterStartSimulation(ExecuteCrossCloudDisasterStartSimulationRequest executeCrossCloudDisasterStartSimulationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeCrossCloudDisasterStartSimulationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/simulation-start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterStartSimulationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteCrossCloudDisasterStartSimulationResponse>(response);
        }

        public SyncInvoker<ExecuteCrossCloudDisasterStartSimulationResponse> ExecuteCrossCloudDisasterStartSimulationInvoker(ExecuteCrossCloudDisasterStartSimulationRequest executeCrossCloudDisasterStartSimulationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeCrossCloudDisasterStartSimulationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/simulation-start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterStartSimulationRequest);
            return new SyncInvoker<ExecuteCrossCloudDisasterStartSimulationResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteCrossCloudDisasterStartSimulationResponse>);
        }
        
        /// <summary>
        /// 灾备实例主从切换
        ///
        /// 容灾switchover（可在主备任一一端下发）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteCrossCloudDisasterSwitchoverResponse ExecuteCrossCloudDisasterSwitchover(ExecuteCrossCloudDisasterSwitchoverRequest executeCrossCloudDisasterSwitchoverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeCrossCloudDisasterSwitchoverRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterSwitchoverRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteCrossCloudDisasterSwitchoverResponse>(response);
        }

        public SyncInvoker<ExecuteCrossCloudDisasterSwitchoverResponse> ExecuteCrossCloudDisasterSwitchoverInvoker(ExecuteCrossCloudDisasterSwitchoverRequest executeCrossCloudDisasterSwitchoverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeCrossCloudDisasterSwitchoverRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterSwitchoverRequest);
            return new SyncInvoker<ExecuteCrossCloudDisasterSwitchoverResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteCrossCloudDisasterSwitchoverResponse>);
        }
        
        /// <summary>
        /// 解除容灾关系
        ///
        /// 解除容灾（从容灾主集群下发）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteCrossCloudReleaseDisasterResponse ExecuteCrossCloudReleaseDisaster(ExecuteCrossCloudReleaseDisasterRequest executeCrossCloudReleaseDisasterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeCrossCloudReleaseDisasterRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/release", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudReleaseDisasterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteCrossCloudReleaseDisasterResponse>(response);
        }

        public SyncInvoker<ExecuteCrossCloudReleaseDisasterResponse> ExecuteCrossCloudReleaseDisasterInvoker(ExecuteCrossCloudReleaseDisasterRequest executeCrossCloudReleaseDisasterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeCrossCloudReleaseDisasterRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/release", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudReleaseDisasterRequest);
            return new SyncInvoker<ExecuteCrossCloudReleaseDisasterResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteCrossCloudReleaseDisasterResponse>);
        }
        
        /// <summary>
        /// 导出表信息
        ///
        /// 导出表信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExportSlowSqlResponse ExportSlowSql(ExportSlowSqlRequest exportSlowSqlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(exportSlowSqlRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/table-volume/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exportSlowSqlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ExportSlowSqlResponse>(response);
        }

        public SyncInvoker<ExportSlowSqlResponse> ExportSlowSqlInvoker(ExportSlowSqlRequest exportSlowSqlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(exportSlowSqlRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/table-volume/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exportSlowSqlRequest);
            return new SyncInvoker<ExportSlowSqlResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ExportSlowSqlResponse>);
        }
        
        /// <summary>
        /// 安装插件
        ///
        /// 安装插件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public InstallKernelPluginResponse InstallKernelPlugin(InstallKernelPluginRequest installKernelPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(installKernelPluginRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kernel-plugin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", installKernelPluginRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<InstallKernelPluginResponse>(response);
        }

        public SyncInvoker<InstallKernelPluginResponse> InstallKernelPluginInvoker(InstallKernelPluginRequest installKernelPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(installKernelPluginRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kernel-plugin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", installKernelPluginRequest);
            return new SyncInvoker<InstallKernelPluginResponse>(this, "POST", request, JsonUtils.DeSerialize<InstallKernelPluginResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(listApplicableInstancesRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applicable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicableInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApplicableInstancesResponse>(response);
        }

        public SyncInvoker<ListApplicableInstancesResponse> ListApplicableInstancesInvoker(ListApplicableInstancesRequest listApplicableInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listApplicableInstancesRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
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
            if (StringUtils.TryConvertToNonEmptyString(listAppliedHistoriesRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applied-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppliedHistoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAppliedHistoriesResponse>(response);
        }

        public SyncInvoker<ListAppliedHistoriesResponse> ListAppliedHistoriesInvoker(ListAppliedHistoriesRequest listAppliedHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAppliedHistoriesRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
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
            if (StringUtils.TryConvertToNonEmptyString(listAvailableFlavorsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/available-flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableFlavorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAvailableFlavorsResponse>(response);
        }

        public SyncInvoker<ListAvailableFlavorsResponse> ListAvailableFlavorsInvoker(ListAvailableFlavorsRequest listAvailableFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAvailableFlavorsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
        /// 查询备份列表
        ///
        /// 获取备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBackupsDetailsResponse ListBackupsDetails(ListBackupsDetailsRequest listBackupsDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupsDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBackupsDetailsResponse>(response);
        }

        public SyncInvoker<ListBackupsDetailsResponse> ListBackupsDetailsInvoker(ListBackupsDetailsRequest listBackupsDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupsDetailsRequest);
            return new SyncInvoker<ListBackupsDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBackupsDetailsResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(listBindedEipsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBindedEipsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBindedEipsResponse>(response);
        }

        public SyncInvoker<ListBindedEipsResponse> ListBindedEipsInvoker(ListBindedEipsRequest listBindedEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBindedEipsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBindedEipsRequest);
            return new SyncInvoker<ListBindedEipsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBindedEipsResponse>);
        }
        
        /// <summary>
        /// 查询协调节点列表
        ///
        /// 查询协调节点列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCnInfosBeforeReduceResponse ListCnInfosBeforeReduce(ListCnInfosBeforeReduceRequest listCnInfosBeforeReduceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCnInfosBeforeReduceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/coordinators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCnInfosBeforeReduceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCnInfosBeforeReduceResponse>(response);
        }

        public SyncInvoker<ListCnInfosBeforeReduceResponse> ListCnInfosBeforeReduceInvoker(ListCnInfosBeforeReduceRequest listCnInfosBeforeReduceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCnInfosBeforeReduceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(listComponentInfosRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/components", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listComponentInfosRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListComponentInfosResponse>(response);
        }

        public SyncInvoker<ListComponentInfosResponse> ListComponentInfosInvoker(ListComponentInfosRequest listComponentInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listComponentInfosRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
        /// 查询数据库实例列表/查询实例详情
        ///
        /// 查询数据库实例列表/查询实例详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDatabaseInstancesResponse ListDatabaseInstances(ListDatabaseInstancesRequest listDatabaseInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDatabaseInstancesResponse>(response);
        }

        public SyncInvoker<ListDatabaseInstancesResponse> ListDatabaseInstancesInvoker(ListDatabaseInstancesRequest listDatabaseInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseInstancesRequest);
            return new SyncInvoker<ListDatabaseInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabaseInstancesResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(listDatabaseRolesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseRolesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDatabaseRolesResponse>(response);
        }

        public SyncInvoker<ListDatabaseRolesResponse> ListDatabaseRolesInvoker(ListDatabaseRolesRequest listDatabaseRolesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDatabaseRolesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseRolesRequest);
            return new SyncInvoker<ListDatabaseRolesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabaseRolesResponse>);
        }
        
        /// <summary>
        /// 查询数据库表列表
        ///
        /// 查询指定实例的数据库表列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDatabaseSchemaTablesResponse ListDatabaseSchemaTables(ListDatabaseSchemaTablesRequest listDatabaseSchemaTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDatabaseSchemaTablesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseSchemaTablesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDatabaseSchemaTablesResponse>(response);
        }

        public SyncInvoker<ListDatabaseSchemaTablesResponse> ListDatabaseSchemaTablesInvoker(ListDatabaseSchemaTablesRequest listDatabaseSchemaTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDatabaseSchemaTablesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseSchemaTablesRequest);
            return new SyncInvoker<ListDatabaseSchemaTablesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabaseSchemaTablesResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(listDatabaseSchemasRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schemas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseSchemasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDatabaseSchemasResponse>(response);
        }

        public SyncInvoker<ListDatabaseSchemasResponse> ListDatabaseSchemasInvoker(ListDatabaseSchemasRequest listDatabaseSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDatabaseSchemasRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schemas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseSchemasRequest);
            return new SyncInvoker<ListDatabaseSchemasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabaseSchemasResponse>);
        }
        
        /// <summary>
        /// 查询数据库引擎的版本
        ///
        /// 查询数据库引擎的版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDatabaseVersionsResponse ListDatabaseVersions(ListDatabaseVersionsRequest listDatabaseVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/datastore/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDatabaseVersionsResponse>(response);
        }

        public SyncInvoker<ListDatabaseVersionsResponse> ListDatabaseVersionsInvoker(ListDatabaseVersionsRequest listDatabaseVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/datastore/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseVersionsRequest);
            return new SyncInvoker<ListDatabaseVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabaseVersionsResponse>);
        }
        
        /// <summary>
        /// 查询数据盘空间概况
        ///
        /// 查询数据盘空间概况。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDatabaseVolumeSummaryResponse ListDatabaseVolumeSummary(ListDatabaseVolumeSummaryRequest listDatabaseVolumeSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDatabaseVolumeSummaryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database-volume-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseVolumeSummaryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDatabaseVolumeSummaryResponse>(response);
        }

        public SyncInvoker<ListDatabaseVolumeSummaryResponse> ListDatabaseVolumeSummaryInvoker(ListDatabaseVolumeSummaryRequest listDatabaseVolumeSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDatabaseVolumeSummaryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database-volume-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseVolumeSummaryRequest);
            return new SyncInvoker<ListDatabaseVolumeSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabaseVolumeSummaryResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(listDatabasesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabasesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDatabasesResponse>(response);
        }

        public SyncInvoker<ListDatabasesResponse> ListDatabasesInvoker(ListDatabasesRequest listDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDatabasesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
        /// 查询引擎列表
        ///
        /// 查询引擎列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDatastoresDetailsResponse ListDatastoresDetails(ListDatastoresDetailsRequest listDatastoresDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/datastores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoresDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDatastoresDetailsResponse>(response);
        }

        public SyncInvoker<ListDatastoresDetailsResponse> ListDatastoresDetailsInvoker(ListDatastoresDetailsRequest listDatastoresDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/datastores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoresDetailsRequest);
            return new SyncInvoker<ListDatastoresDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatastoresDetailsResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(listDbUsersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDbUsersResponse>(response);
        }

        public SyncInvoker<ListDbUsersResponse> ListDbUsersInvoker(ListDbUsersRequest listDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDbUsersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbUsersRequest);
            return new SyncInvoker<ListDbUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDbUsersResponse>);
        }
        
        /// <summary>
        /// 查询操作记录
        ///
        /// 查询容灾操作记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDisasterRecoveryRecordResponse ListDisasterRecoveryRecord(ListDisasterRecoveryRecordRequest listDisasterRecoveryRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDisasterRecoveryRecordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDisasterRecoveryRecordRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDisasterRecoveryRecordResponse>(response);
        }

        public SyncInvoker<ListDisasterRecoveryRecordResponse> ListDisasterRecoveryRecordInvoker(ListDisasterRecoveryRecordRequest listDisasterRecoveryRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDisasterRecoveryRecordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDisasterRecoveryRecordRequest);
            return new SyncInvoker<ListDisasterRecoveryRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDisasterRecoveryRecordResponse>);
        }
        
        /// <summary>
        /// 查询企业项目列表
        ///
        /// 查询企业项目列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEnterpriseProjectsResponse ListEnterpriseProjects(ListEnterpriseProjectsRequest listEnterpriseProjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseProjectsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEnterpriseProjectsResponse>(response);
        }

        public SyncInvoker<ListEnterpriseProjectsResponse> ListEnterpriseProjectsInvoker(ListEnterpriseProjectsRequest listEnterpriseProjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseProjectsRequest);
            return new SyncInvoker<ListEnterpriseProjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEnterpriseProjectsResponse>);
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
        /// 查询实例特性列表
        ///
        /// 查询当前实例高级特性列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFeaturesResponse ListFeatures(ListFeaturesRequest listFeaturesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFeaturesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/advance-features", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFeaturesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFeaturesResponse>(response);
        }

        public SyncInvoker<ListFeaturesResponse> ListFeaturesInvoker(ListFeaturesRequest listFeaturesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFeaturesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/advance-features", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFeaturesRequest);
            return new SyncInvoker<ListFeaturesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFeaturesResponse>);
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
        /// 查询数据库规格
        ///
        /// 查询数据库的规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFlavorsDetailsResponse ListFlavorsDetails(ListFlavorsDetailsRequest listFlavorsDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorsDetailsResponse>(response);
        }

        public SyncInvoker<ListFlavorsDetailsResponse> ListFlavorsDetailsInvoker(ListFlavorsDetailsRequest listFlavorsDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsDetailsRequest);
            return new SyncInvoker<ListFlavorsDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorsDetailsResponse>);
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
        /// 查询客户端接入认证配置修改历史
        ///
        /// 查询实例的客户端接入认证配置修改历史。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHbaInfoHistoryResponse ListHbaInfoHistory(ListHbaInfoHistoryRequest listHbaInfoHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHbaInfoHistoryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHbaInfoHistoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHbaInfoHistoryResponse>(response);
        }

        public SyncInvoker<ListHbaInfoHistoryResponse> ListHbaInfoHistoryInvoker(ListHbaInfoHistoryRequest listHbaInfoHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHbaInfoHistoryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHbaInfoHistoryRequest);
            return new SyncInvoker<ListHbaInfoHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHbaInfoHistoryResponse>);
        }
        
        /// <summary>
        /// 查询客户端接入认证配置
        ///
        /// 查询客户端接入认证配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHbaInfosResponse ListHbaInfos(ListHbaInfosRequest listHbaInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHbaInfosRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHbaInfosRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHbaInfosResponse>(response);
        }

        public SyncInvoker<ListHbaInfosResponse> ListHbaInfosInvoker(ListHbaInfosRequest listHbaInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHbaInfosRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHbaInfosRequest);
            return new SyncInvoker<ListHbaInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHbaInfosResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(listHistoryOperationsRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryOperationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHistoryOperationsResponse>(response);
        }

        public SyncInvoker<ListHistoryOperationsResponse> ListHistoryOperationsInvoker(ListHistoryOperationsRequest listHistoryOperationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHistoryOperationsRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryOperationsRequest);
            return new SyncInvoker<ListHistoryOperationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHistoryOperationsResponse>);
        }
        
        /// <summary>
        /// 查询数据库实例列表/查询实例详情
        ///
        /// 查询数据库实例列表/查询实例详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceDetailsResponse ListInstanceDetails(ListInstanceDetailsRequest listInstanceDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceDetailsResponse>(response);
        }

        public SyncInvoker<ListInstanceDetailsResponse> ListInstanceDetailsInvoker(ListInstanceDetailsRequest listInstanceDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceDetailsRequest);
            return new SyncInvoker<ListInstanceDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceDetailsResponse>);
        }
        
        /// <summary>
        /// 查看实例引擎版本分布
        ///
        /// 查看实例引擎版本分布
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceEngineDetailResponse ListInstanceEngineDetail(ListInstanceEngineDetailRequest listInstanceEngineDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastore/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceEngineDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceEngineDetailResponse>(response);
        }

        public SyncInvoker<ListInstanceEngineDetailResponse> ListInstanceEngineDetailInvoker(ListInstanceEngineDetailRequest listInstanceEngineDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastore/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceEngineDetailRequest);
            return new SyncInvoker<ListInstanceEngineDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceEngineDetailResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(listInstanceErrorLogsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceErrorLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceErrorLogsResponse>(response);
        }

        public SyncInvoker<ListInstanceErrorLogsResponse> ListInstanceErrorLogsInvoker(ListInstanceErrorLogsRequest listInstanceErrorLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceErrorLogsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(listInstanceTagsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceTagsResponse>(response);
        }

        public SyncInvoker<ListInstanceTagsResponse> ListInstanceTagsInvoker(ListInstanceTagsRequest listInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceTagsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
        /// 查询实例已安装的插件列表
        ///
        /// 查询实例已安装的插件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListKernelPluginsResponse ListKernelPlugins(ListKernelPluginsRequest listKernelPluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listKernelPluginsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kernel-plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKernelPluginsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listKernelPluginsResponse = JsonUtils.DeSerializeNull<ListKernelPluginsResponse>(response);
            listKernelPluginsResponse.Body = JsonUtils.DeSerializeList<string>(response);
            return listKernelPluginsResponse;
        }

        public SyncInvoker<ListKernelPluginsResponse> ListKernelPluginsInvoker(ListKernelPluginsRequest listKernelPluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listKernelPluginsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kernel-plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKernelPluginsRequest);
            return new SyncInvoker<ListKernelPluginsResponse>(this, "GET", request, response =>
            {
                var listKernelPluginsResponse = JsonUtils.DeSerializeNull<ListKernelPluginsResponse>(response);
                listKernelPluginsResponse.Body = JsonUtils.DeSerializeList<string>(response);
                return listKernelPluginsResponse;
            });
        }
        
        /// <summary>
        /// 查询关键视图下发节点信息
        ///
        /// 查询该实例下可用于执行会话查杀功能的节点 (非日志类型的CN或DN节点) 和其所包含的CN、DN组件信息。该接口是会话查杀功能的前提，其返回值中的每一对节点和组件ID是后续查杀会话接口的入参。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListKeyViewExecuteNodeResponse ListKeyViewExecuteNode(ListKeyViewExecuteNodeRequest listKeyViewExecuteNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listKeyViewExecuteNodeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/key-view-execute-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeyViewExecuteNodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListKeyViewExecuteNodeResponse>(response);
        }

        public SyncInvoker<ListKeyViewExecuteNodeResponse> ListKeyViewExecuteNodeInvoker(ListKeyViewExecuteNodeRequest listKeyViewExecuteNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listKeyViewExecuteNodeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/key-view-execute-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeyViewExecuteNodeRequest);
            return new SyncInvoker<ListKeyViewExecuteNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<ListKeyViewExecuteNodeResponse>);
        }
        
        /// <summary>
        /// 查询KMS秘钥列表
        ///
        /// 查询当前可使用的kms秘钥列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListKmsTdeKeyResponse ListKmsTdeKey(ListKmsTdeKeyRequest listKmsTdeKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listKmsTdeKeyRequest.KmsProjectName, out var valueOfKmsProjectName)) urlParam.Add("kms_project_name", valueOfKmsProjectName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/kms/list-keys/{kms_project_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKmsTdeKeyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListKmsTdeKeyResponse>(response);
        }

        public SyncInvoker<ListKmsTdeKeyResponse> ListKmsTdeKeyInvoker(ListKmsTdeKeyRequest listKmsTdeKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listKmsTdeKeyRequest.KmsProjectName, out var valueOfKmsProjectName)) urlParam.Add("kms_project_name", valueOfKmsProjectName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/kms/list-keys/{kms_project_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKmsTdeKeyRequest);
            return new SyncInvoker<ListKmsTdeKeyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKmsTdeKeyResponse>);
        }
        
        /// <summary>
        /// 查询实例列表指标
        ///
        /// 查询实例列表指标。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMetricDatasResponse ListMetricDatas(ListMetricDatasRequest listMetricDatasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricDatasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMetricDatasResponse>(response);
        }

        public SyncInvoker<ListMetricDatasResponse> ListMetricDatasInvoker(ListMetricDatasRequest listMetricDatasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricDatasRequest);
            return new SyncInvoker<ListMetricDatasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMetricDatasResponse>);
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
        /// 获取参数模板列表
        ///
        /// 获取参数模板列表，包括所有数据库的默认参数模板和用户创建的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListParameterGroupTemplatesResponse ListParameterGroupTemplates(ListParameterGroupTemplatesRequest listParameterGroupTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listParameterGroupTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListParameterGroupTemplatesResponse>(response);
        }

        public SyncInvoker<ListParameterGroupTemplatesResponse> ListParameterGroupTemplatesInvoker(ListParameterGroupTemplatesRequest listParameterGroupTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listParameterGroupTemplatesRequest);
            return new SyncInvoker<ListParameterGroupTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListParameterGroupTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询实例插件拓展信息
        ///
        /// 查询实例插件拓展信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPluginExtensionsResponse ListPluginExtensions(ListPluginExtensionsRequest listPluginExtensionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPluginExtensionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/plugin-extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPluginExtensionsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listPluginExtensionsResponse = JsonUtils.DeSerializeNull<ListPluginExtensionsResponse>(response);
            listPluginExtensionsResponse.Body = JsonUtils.DeSerializeList<PluginExtensions>(response);
            return listPluginExtensionsResponse;
        }

        public SyncInvoker<ListPluginExtensionsResponse> ListPluginExtensionsInvoker(ListPluginExtensionsRequest listPluginExtensionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPluginExtensionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/plugin-extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPluginExtensionsRequest);
            return new SyncInvoker<ListPluginExtensionsResponse>(this, "GET", request, response =>
            {
                var listPluginExtensionsResponse = JsonUtils.DeSerializeNull<ListPluginExtensionsResponse>(response);
                listPluginExtensionsResponse.Body = JsonUtils.DeSerializeList<PluginExtensions>(response);
                return listPluginExtensionsResponse;
            });
        }
        
        /// <summary>
        /// 查询插件列表
        ///
        /// 查询插件列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPluginInfoListResponse ListPluginInfoList(ListPluginInfoListRequest listPluginInfoListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPluginInfoListRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPluginInfoListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPluginInfoListResponse>(response);
        }

        public SyncInvoker<ListPluginInfoListResponse> ListPluginInfoListInvoker(ListPluginInfoListRequest listPluginInfoListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPluginInfoListRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPluginInfoListRequest);
            return new SyncInvoker<ListPluginInfoListResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPluginInfoListResponse>);
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
        /// 查询只读节点信息
        ///
        /// 查询实例的只读节点列表，以及实例可支持的最大只读节点数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListReadonlyNodesResponse ListReadonlyNodes(ListReadonlyNodesRequest listReadonlyNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listReadonlyNodesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/readonly-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReadonlyNodesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListReadonlyNodesResponse>(response);
        }

        public SyncInvoker<ListReadonlyNodesResponse> ListReadonlyNodesInvoker(ListReadonlyNodesRequest listReadonlyNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listReadonlyNodesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/readonly-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReadonlyNodesRequest);
            return new SyncInvoker<ListReadonlyNodesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListReadonlyNodesResponse>);
        }
        
        /// <summary>
        /// 查询实时会话
        ///
        /// 查询数据库实例节点的实时会话列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRealTimeSessionsResponse ListRealTimeSessions(ListRealTimeSessionsRequest listRealTimeSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRealTimeSessionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/real-time-session", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listRealTimeSessionsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListRealTimeSessionsResponse>(response);
        }

        public SyncInvoker<ListRealTimeSessionsResponse> ListRealTimeSessionsInvoker(ListRealTimeSessionsRequest listRealTimeSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRealTimeSessionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/real-time-session", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listRealTimeSessionsRequest);
            return new SyncInvoker<ListRealTimeSessionsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListRealTimeSessionsResponse>);
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
        /// 查询回收站所有引擎实例列表。
        ///
        /// 查询回收站所有引擎实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRecycleInstancesDetailsResponse ListRecycleInstancesDetails(ListRecycleInstancesDetailsRequest listRecycleInstancesDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/recycle-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecycleInstancesDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRecycleInstancesDetailsResponse>(response);
        }

        public SyncInvoker<ListRecycleInstancesDetailsResponse> ListRecycleInstancesDetailsInvoker(ListRecycleInstancesDetailsRequest listRecycleInstancesDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/recycle-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecycleInstancesDetailsRequest);
            return new SyncInvoker<ListRecycleInstancesDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecycleInstancesDetailsResponse>);
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
        /// 查询可用于备份恢复的实例列表
        ///
        /// 查询可用于备份恢复的实例列表，实例信息要符合备份条件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRestorableInstancesDetailsResponse ListRestorableInstancesDetails(ListRestorableInstancesDetailsRequest listRestorableInstancesDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/restorable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestorableInstancesDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRestorableInstancesDetailsResponse>(response);
        }

        public SyncInvoker<ListRestorableInstancesDetailsResponse> ListRestorableInstancesDetailsInvoker(ListRestorableInstancesDetailsRequest listRestorableInstancesDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/restorable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestorableInstancesDetailsRequest);
            return new SyncInvoker<ListRestorableInstancesDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestorableInstancesDetailsResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(listRestoreTimesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTimesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRestoreTimesResponse>(response);
        }

        public SyncInvoker<ListRestoreTimesResponse> ListRestoreTimesInvoker(ListRestoreTimesRequest listRestoreTimesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRestoreTimesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTimesRequest);
            return new SyncInvoker<ListRestoreTimesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestoreTimesResponse>);
        }
        
        /// <summary>
        /// 查看定时任务列表
        ///
        /// 查看定时任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListScheduleTaskResponse ListScheduleTask(ListScheduleTaskRequest listScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/schedule-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduleTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScheduleTaskResponse>(response);
        }

        public SyncInvoker<ListScheduleTaskResponse> ListScheduleTaskInvoker(ListScheduleTaskRequest listScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/schedule-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduleTaskRequest);
            return new SyncInvoker<ListScheduleTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScheduleTaskResponse>);
        }
        
        /// <summary>
        /// 识别SQL文本中的表信息
        ///
        /// 识别SQL文本中的表信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSchemaAndTableResponse ListSchemaAndTable(ListSchemaAndTableRequest listSchemaAndTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSchemaAndTableRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/parse/schema-table", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSchemaAndTableRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListSchemaAndTableResponse>(response);
        }

        public SyncInvoker<ListSchemaAndTableResponse> ListSchemaAndTableInvoker(ListSchemaAndTableRequest listSchemaAndTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSchemaAndTableRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/parse/schema-table", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSchemaAndTableRequest);
            return new SyncInvoker<ListSchemaAndTableResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSchemaAndTableResponse>);
        }
        
        /// <summary>
        /// 查询会话内存上下文列表
        ///
        /// 查询数据库实例节点的会话内存上下文列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSessionMemoryContextResponse ListSessionMemoryContext(ListSessionMemoryContextRequest listSessionMemoryContextRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSessionMemoryContextRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/session/memory-context", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionMemoryContextRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSessionMemoryContextResponse>(response);
        }

        public SyncInvoker<ListSessionMemoryContextResponse> ListSessionMemoryContextInvoker(ListSessionMemoryContextRequest listSessionMemoryContextRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSessionMemoryContextRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/session/memory-context", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionMemoryContextRequest);
            return new SyncInvoker<ListSessionMemoryContextResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSessionMemoryContextResponse>);
        }
        
        /// <summary>
        /// 查询实时会话统计
        ///
        /// 查询数据库实例节点的实时会话统计信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSessionStatisticsResponse ListSessionStatistics(ListSessionStatisticsRequest listSessionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSessionStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/session-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSessionStatisticsResponse>(response);
        }

        public SyncInvoker<ListSessionStatisticsResponse> ListSessionStatisticsInvoker(ListSessionStatisticsRequest listSessionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSessionStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/session-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionStatisticsRequest);
            return new SyncInvoker<ListSessionStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSessionStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询实时会话Top SQL统计
        ///
        /// 查询实时会话Top SQL统计。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSessionTopSqlStatisticsResponse ListSessionTopSqlStatistics(ListSessionTopSqlStatisticsRequest listSessionTopSqlStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSessionTopSqlStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/session/statistic/top-sql", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionTopSqlStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSessionTopSqlStatisticsResponse>(response);
        }

        public SyncInvoker<ListSessionTopSqlStatisticsResponse> ListSessionTopSqlStatisticsInvoker(ListSessionTopSqlStatisticsRequest listSessionTopSqlStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSessionTopSqlStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/session/statistic/top-sql", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionTopSqlStatisticsRequest);
            return new SyncInvoker<ListSessionTopSqlStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSessionTopSqlStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询实时会话Top等待事件统计
        ///
        /// 查询实时会话Top等待事件统计。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSessionWaitEventStatisticsResponse ListSessionWaitEventStatistics(ListSessionWaitEventStatisticsRequest listSessionWaitEventStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSessionWaitEventStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/session/statistic/wait-event", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionWaitEventStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSessionWaitEventStatisticsResponse>(response);
        }

        public SyncInvoker<ListSessionWaitEventStatisticsResponse> ListSessionWaitEventStatisticsInvoker(ListSessionWaitEventStatisticsRequest listSessionWaitEventStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSessionWaitEventStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/session/statistic/wait-event", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionWaitEventStatisticsRequest);
            return new SyncInvoker<ListSessionWaitEventStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSessionWaitEventStatisticsResponse>);
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
        /// 查询支持的插件列表
        ///
        /// 查询支持的插件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSupportKernelPluginsResponse ListSupportKernelPlugins(ListSupportKernelPluginsRequest listSupportKernelPluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/kernel-plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportKernelPluginsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listSupportKernelPluginsResponse = JsonUtils.DeSerializeNull<ListSupportKernelPluginsResponse>(response);
            listSupportKernelPluginsResponse.Body = JsonUtils.DeSerializeList<string>(response);
            return listSupportKernelPluginsResponse;
        }

        public SyncInvoker<ListSupportKernelPluginsResponse> ListSupportKernelPluginsInvoker(ListSupportKernelPluginsRequest listSupportKernelPluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/kernel-plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportKernelPluginsRequest);
            return new SyncInvoker<ListSupportKernelPluginsResponse>(this, "GET", request, response =>
            {
                var listSupportKernelPluginsResponse = JsonUtils.DeSerializeNull<ListSupportKernelPluginsResponse>(response);
                listSupportKernelPluginsResponse.Body = JsonUtils.DeSerializeList<string>(response);
                return listSupportKernelPluginsResponse;
            });
        }
        
        /// <summary>
        /// 查询表定义信息
        ///
        /// 查询表定义信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTableDefinitionResponse ListTableDefinition(ListTableDefinitionRequest listTableDefinitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTableDefinitionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/table-definition", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTableDefinitionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTableDefinitionResponse>(response);
        }

        public SyncInvoker<ListTableDefinitionResponse> ListTableDefinitionInvoker(ListTableDefinitionRequest listTableDefinitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTableDefinitionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/table-definition", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTableDefinitionRequest);
            return new SyncInvoker<ListTableDefinitionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTableDefinitionResponse>);
        }
        
        /// <summary>
        /// 查询指定表的表定义信息列表
        ///
        /// 查询指定表的表定义信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTableDefinitionsResponse ListTableDefinitions(ListTableDefinitionsRequest listTableDefinitionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTableDefinitionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/list-table-definition", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTableDefinitionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTableDefinitionsResponse>(response);
        }

        public SyncInvoker<ListTableDefinitionsResponse> ListTableDefinitionsInvoker(ListTableDefinitionsRequest listTableDefinitionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTableDefinitionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/list-table-definition", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTableDefinitionsRequest);
            return new SyncInvoker<ListTableDefinitionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTableDefinitionsResponse>);
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
        /// 查询事务列表
        ///
        /// 查询数据库实例节点的实时事务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTransactionResponse ListTransaction(ListTransactionRequest listTransactionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTransactionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/transactions/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listTransactionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListTransactionResponse>(response);
        }

        public SyncInvoker<ListTransactionResponse> ListTransactionInvoker(ListTransactionRequest listTransactionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTransactionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/transactions/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listTransactionRequest);
            return new SyncInvoker<ListTransactionResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTransactionResponse>);
        }
        
        /// <summary>
        /// 查询等待事件列表
        ///
        /// 查询数据库实例节点的等待事件列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWaitEventResponse ListWaitEvent(ListWaitEventRequest listWaitEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listWaitEventRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/wait-event-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listWaitEventRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListWaitEventResponse>(response);
        }

        public SyncInvoker<ListWaitEventResponse> ListWaitEventInvoker(ListWaitEventRequest listWaitEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listWaitEventRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/wait-event-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listWaitEventRequest);
            return new SyncInvoker<ListWaitEventResponse>(this, "POST", request, JsonUtils.DeSerialize<ListWaitEventResponse>);
        }
        
        /// <summary>
        /// 修改磁盘自动扩容策略
        ///
        /// 修改磁盘自动扩容策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyAutoEnlargePolicyResponse ModifyAutoEnlargePolicy(ModifyAutoEnlargePolicyRequest modifyAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyAutoEnlargePolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auto-enlarge-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyAutoEnlargePolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ModifyAutoEnlargePolicyResponse>(response);
        }

        public SyncInvoker<ModifyAutoEnlargePolicyResponse> ModifyAutoEnlargePolicyInvoker(ModifyAutoEnlargePolicyRequest modifyAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyAutoEnlargePolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auto-enlarge-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyAutoEnlargePolicyRequest);
            return new SyncInvoker<ModifyAutoEnlargePolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ModifyAutoEnlargePolicyResponse>);
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
        /// 修改客户端接入认证配置
        ///
        /// 修改客户端接入认证配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyHbaConfResponse ModifyHbaConf(ModifyHbaConfRequest modifyHbaConfRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyHbaConfRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyHbaConfRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ModifyHbaConfResponse>(response);
        }

        public SyncInvoker<ModifyHbaConfResponse> ModifyHbaConfInvoker(ModifyHbaConfRequest modifyHbaConfRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyHbaConfRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyHbaConfRequest);
            return new SyncInvoker<ModifyHbaConfResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ModifyHbaConfResponse>);
        }
        
        /// <summary>
        /// 修改指定实例端口号
        ///
        /// 修改指定实例端口号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyInstancePortResponse ModifyInstancePort(ModifyInstancePortRequest modifyInstancePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyInstancePortRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyInstancePortRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyInstancePortResponse>(response);
        }

        public SyncInvoker<ModifyInstancePortResponse> ModifyInstancePortInvoker(ModifyInstancePortRequest modifyInstancePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyInstancePortRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyInstancePortRequest);
            return new SyncInvoker<ModifyInstancePortResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyInstancePortResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(resetConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetConfigurationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ResetConfigurationResponse>(response);
        }

        public SyncInvoker<ResetConfigurationResponse> ResetConfigurationInvoker(ResetConfigurationRequest resetConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetConfigurationRequest);
            return new SyncInvoker<ResetConfigurationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetConfigurationResponse>);
        }
        
        /// <summary>
        /// 重置容灾配置
        ///
        /// 重置容灾网络等配置。1.将自动“创建委托”以授权DBS云服务访问VPC资源信息、查询IAAS接口。2.重置实例容灾网络等配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetDrConfigResponse ResetDrConfig(ResetDrConfigRequest resetDrConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetDrConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/reset-dr-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetDrConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ResetDrConfigResponse>(response);
        }

        public SyncInvoker<ResetDrConfigResponse> ResetDrConfigInvoker(ResetDrConfigRequest resetDrConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetDrConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/reset-dr-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetDrConfigRequest);
            return new SyncInvoker<ResetDrConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetDrConfigResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(resetPwdRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetPwdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ResetPwdResponse>(response);
        }

        public SyncInvoker<ResetPwdResponse> ResetPwdInvoker(ResetPwdRequest resetPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetPwdRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(resizeInstanceFlavorRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/flavor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeInstanceFlavorRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ResizeInstanceFlavorResponse>(response);
        }

        public SyncInvoker<ResizeInstanceFlavorResponse> ResizeInstanceFlavorInvoker(ResizeInstanceFlavorRequest resizeInstanceFlavorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resizeInstanceFlavorRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(restartInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestartInstanceResponse>(response);
        }

        public SyncInvoker<RestartInstanceResponse> RestartInstanceInvoker(RestartInstanceRequest restartInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restartInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartInstanceRequest);
            return new SyncInvoker<RestartInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestartInstanceResponse>);
        }
        
        /// <summary>
        /// 恢复客户端接入认证配置信息
        ///
        /// 恢复客户端接入认证配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreHbaInfoResponse RestoreHbaInfo(RestoreHbaInfoRequest restoreHbaInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreHbaInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreHbaInfoRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<RestoreHbaInfoResponse>(response);
        }

        public SyncInvoker<RestoreHbaInfoResponse> RestoreHbaInfoInvoker(RestoreHbaInfoRequest restoreHbaInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreHbaInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreHbaInfoRequest);
            return new SyncInvoker<RestoreHbaInfoResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<RestoreHbaInfoResponse>);
        }
        
        /// <summary>
        /// 备份恢复到当前实例
        ///
        /// 备份恢复到当前实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreInstanceResponse RestoreInstance(RestoreInstanceRequest restoreInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestoreInstanceResponse>(response);
        }

        public SyncInvoker<RestoreInstanceResponse> RestoreInstanceInvoker(RestoreInstanceRequest restoreInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreInstanceRequest);
            return new SyncInvoker<RestoreInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreInstanceResponse>);
        }
        
        /// <summary>
        /// 配置插件拓展能力
        ///
        /// 配置插件拓展能力
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResumePluginExtensionsResponse ResumePluginExtensions(ResumePluginExtensionsRequest resumePluginExtensionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resumePluginExtensionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/config-plugin-extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resumePluginExtensionsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ResumePluginExtensionsResponse>(response);
        }

        public SyncInvoker<ResumePluginExtensionsResponse> ResumePluginExtensionsInvoker(ResumePluginExtensionsRequest resumePluginExtensionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resumePluginExtensionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/config-plugin-extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resumePluginExtensionsRequest);
            return new SyncInvoker<ResumePluginExtensionsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResumePluginExtensionsResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(runInstanceActionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runInstanceActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunInstanceActionResponse>(response);
        }

        public SyncInvoker<RunInstanceActionResponse> RunInstanceActionInvoker(RunInstanceActionRequest runInstanceActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runInstanceActionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runInstanceActionRequest);
            return new SyncInvoker<RunInstanceActionResponse>(this, "POST", request, JsonUtils.DeSerialize<RunInstanceActionResponse>);
        }
        
        /// <summary>
        /// 查询磁盘自动扩容策略
        ///
        /// 查询磁盘自动扩容策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchAutoEnlargePolicyResponse SearchAutoEnlargePolicy(SearchAutoEnlargePolicyRequest searchAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(searchAutoEnlargePolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auto-enlarge-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchAutoEnlargePolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchAutoEnlargePolicyResponse>(response);
        }

        public SyncInvoker<SearchAutoEnlargePolicyResponse> SearchAutoEnlargePolicyInvoker(SearchAutoEnlargePolicyRequest searchAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(searchAutoEnlargePolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(setBackupPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setBackupPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetBackupPolicyResponse>(response);
        }

        public SyncInvoker<SetBackupPolicyResponse> SetBackupPolicyInvoker(SetBackupPolicyRequest setBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setBackupPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(setDbUserPwdRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setDbUserPwdRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetDbUserPwdResponse>(response);
        }

        public SyncInvoker<SetDbUserPwdResponse> SetDbUserPwdInvoker(SetDbUserPwdRequest setDbUserPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setDbUserPwdRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setDbUserPwdRequest);
            return new SyncInvoker<SetDbUserPwdResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetDbUserPwdResponse>);
        }
        
        /// <summary>
        /// 配置插件license
        ///
        /// 配置插件license
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetKernelPluginLicenseResponse SetKernelPluginLicense(SetKernelPluginLicenseRequest setKernelPluginLicenseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setKernelPluginLicenseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kernel-plugin-license", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setKernelPluginLicenseRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetKernelPluginLicenseResponse>(response);
        }

        public SyncInvoker<SetKernelPluginLicenseResponse> SetKernelPluginLicenseInvoker(SetKernelPluginLicenseRequest setKernelPluginLicenseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setKernelPluginLicenseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kernel-plugin-license", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setKernelPluginLicenseRequest);
            return new SyncInvoker<SetKernelPluginLicenseResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetKernelPluginLicenseResponse>);
        }
        
        /// <summary>
        /// 设置自动备份策略
        ///
        /// 设置自动备份策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetNewBackupPolicyResponse SetNewBackupPolicy(SetNewBackupPolicyRequest setNewBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setNewBackupPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setNewBackupPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetNewBackupPolicyResponse>(response);
        }

        public SyncInvoker<SetNewBackupPolicyResponse> SetNewBackupPolicyInvoker(SetNewBackupPolicyRequest setNewBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setNewBackupPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setNewBackupPolicyRequest);
            return new SyncInvoker<SetNewBackupPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetNewBackupPolicyResponse>);
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
        /// 获取告警记录历史
        ///
        /// 获取告警记录历史。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAlarmHistoryRecordResponse ShowAlarmHistoryRecord(ShowAlarmHistoryRecordRequest showAlarmHistoryRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/alarm-history-record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmHistoryRecordRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAlarmHistoryRecordResponse>(response);
        }

        public SyncInvoker<ShowAlarmHistoryRecordResponse> ShowAlarmHistoryRecordInvoker(ShowAlarmHistoryRecordRequest showAlarmHistoryRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/alarm-history-record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmHistoryRecordRequest);
            return new SyncInvoker<ShowAlarmHistoryRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAlarmHistoryRecordResponse>);
        }
        
        /// <summary>
        /// 实例告警信息汇总统计
        ///
        /// 实例告警信息汇总统计。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAlarmStatisticsResponse ShowAlarmStatistics(ShowAlarmStatisticsRequest showAlarmStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/alarm-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAlarmStatisticsResponse>(response);
        }

        public SyncInvoker<ShowAlarmStatisticsResponse> ShowAlarmStatisticsInvoker(ShowAlarmStatisticsRequest showAlarmStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/alarm-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmStatisticsRequest);
            return new SyncInvoker<ShowAlarmStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAlarmStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取自动中止事务配置
        ///
        /// 获取实例自动中止事务配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutoKillTransactionConfigResponse ShowAutoKillTransactionConfig(ShowAutoKillTransactionConfigRequest showAutoKillTransactionConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoKillTransactionConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/transactions/get-auto-kill-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoKillTransactionConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoKillTransactionConfigResponse>(response);
        }

        public SyncInvoker<ShowAutoKillTransactionConfigResponse> ShowAutoKillTransactionConfigInvoker(ShowAutoKillTransactionConfigRequest showAutoKillTransactionConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoKillTransactionConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/transactions/get-auto-kill-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoKillTransactionConfigRequest);
            return new SyncInvoker<ShowAutoKillTransactionConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoKillTransactionConfigResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showBackupPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBackupPolicyResponse>(response);
        }

        public SyncInvoker<ShowBackupPolicyResponse> ShowBackupPolicyInvoker(ShowBackupPolicyRequest showBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBackupPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(showBalanceStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBalanceStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBalanceStatusResponse>(response);
        }

        public SyncInvoker<ShowBalanceStatusResponse> ShowBalanceStatusInvoker(ShowBalanceStatusRequest showBalanceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBalanceStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBalanceStatusRequest);
            return new SyncInvoker<ShowBalanceStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBalanceStatusResponse>);
        }
        
        /// <summary>
        /// 查询批量实例可升级的版本和升级类型。
        ///
        /// 查询批量实例可升级的版本和升级类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBatchUpgradeCandidateVersionsResponse ShowBatchUpgradeCandidateVersions(ShowBatchUpgradeCandidateVersionsRequest showBatchUpgradeCandidateVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/db-upgrade/candidate-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showBatchUpgradeCandidateVersionsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowBatchUpgradeCandidateVersionsResponse>(response);
        }

        public SyncInvoker<ShowBatchUpgradeCandidateVersionsResponse> ShowBatchUpgradeCandidateVersionsInvoker(ShowBatchUpgradeCandidateVersionsRequest showBatchUpgradeCandidateVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/db-upgrade/candidate-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showBatchUpgradeCandidateVersionsRequest);
            return new SyncInvoker<ShowBatchUpgradeCandidateVersionsResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowBatchUpgradeCandidateVersionsResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showConfigurationDetailRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigurationDetailResponse>(response);
        }

        public SyncInvoker<ShowConfigurationDetailResponse> ShowConfigurationDetailInvoker(ShowConfigurationDetailRequest showConfigurationDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigurationDetailRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationDetailRequest);
            return new SyncInvoker<ShowConfigurationDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigurationDetailResponse>);
        }
        
        /// <summary>
        /// 查询实例容灾监控实时状态
        ///
        /// 查询实例容灾监控实时状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCrossCloudDisasterInstanceMonitorResponse ShowCrossCloudDisasterInstanceMonitor(ShowCrossCloudDisasterInstanceMonitorRequest showCrossCloudDisasterInstanceMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCrossCloudDisasterInstanceMonitorRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/monitor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCrossCloudDisasterInstanceMonitorRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCrossCloudDisasterInstanceMonitorResponse>(response);
        }

        public SyncInvoker<ShowCrossCloudDisasterInstanceMonitorResponse> ShowCrossCloudDisasterInstanceMonitorInvoker(ShowCrossCloudDisasterInstanceMonitorRequest showCrossCloudDisasterInstanceMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCrossCloudDisasterInstanceMonitorRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/monitor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCrossCloudDisasterInstanceMonitorRequest);
            return new SyncInvoker<ShowCrossCloudDisasterInstanceMonitorResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCrossCloudDisasterInstanceMonitorResponse>);
        }
        
        /// <summary>
        /// 查询容灾关系列表
        ///
        /// 查询容灾关系列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCrossCloudDisasterRelationsResponse ShowCrossCloudDisasterRelations(ShowCrossCloudDisasterRelationsRequest showCrossCloudDisasterRelationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/disaster-recovery/relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCrossCloudDisasterRelationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCrossCloudDisasterRelationsResponse>(response);
        }

        public SyncInvoker<ShowCrossCloudDisasterRelationsResponse> ShowCrossCloudDisasterRelationsInvoker(ShowCrossCloudDisasterRelationsRequest showCrossCloudDisasterRelationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/disaster-recovery/relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCrossCloudDisasterRelationsRequest);
            return new SyncInvoker<ShowCrossCloudDisasterRelationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCrossCloudDisasterRelationsResponse>);
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
        /// 获取企业项目剩余配额
        ///
        /// 获取企业项目剩余配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEpsRemainingQuotaResponse ShowEpsRemainingQuota(ShowEpsRemainingQuotaRequest showEpsRemainingQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects/remaining-quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showEpsRemainingQuotaRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowEpsRemainingQuotaResponse>(response);
        }

        public SyncInvoker<ShowEpsRemainingQuotaResponse> ShowEpsRemainingQuotaInvoker(ShowEpsRemainingQuotaRequest showEpsRemainingQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects/remaining-quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showEpsRemainingQuotaRequest);
            return new SyncInvoker<ShowEpsRemainingQuotaResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowEpsRemainingQuotaResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showErrorLogSwitchStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-log/switch/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showErrorLogSwitchStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowErrorLogSwitchStatusResponse>(response);
        }

        public SyncInvoker<ShowErrorLogSwitchStatusResponse> ShowErrorLogSwitchStatusInvoker(ShowErrorLogSwitchStatusRequest showErrorLogSwitchStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showErrorLogSwitchStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-log/switch/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showErrorLogSwitchStatusRequest);
            return new SyncInvoker<ShowErrorLogSwitchStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowErrorLogSwitchStatusResponse>);
        }
        
        /// <summary>
        /// 查询扩容优化参数设置模板
        ///
        /// 查询扩容优化参数设置模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowExpansionParametersResponse ShowExpansionParameters(ShowExpansionParametersRequest showExpansionParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/expansion-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExpansionParametersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowExpansionParametersResponse>(response);
        }

        public SyncInvoker<ShowExpansionParametersResponse> ShowExpansionParametersInvoker(ShowExpansionParametersRequest showExpansionParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/expansion-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExpansionParametersRequest);
            return new SyncInvoker<ShowExpansionParametersResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowExpansionParametersResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showInstanceConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigurationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceConfigurationResponse>(response);
        }

        public SyncInvoker<ShowInstanceConfigurationResponse> ShowInstanceConfigurationInvoker(ShowInstanceConfigurationRequest showInstanceConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(showInstanceDiskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/volume-usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceDiskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceDiskResponse>(response);
        }

        public SyncInvoker<ShowInstanceDiskResponse> ShowInstanceDiskInvoker(ShowInstanceDiskRequest showInstanceDiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceDiskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/volume-usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceDiskRequest);
            return new SyncInvoker<ShowInstanceDiskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceDiskResponse>);
        }
        
        /// <summary>
        /// 查询实例指标数据
        ///
        /// 查询实例指标数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceMetricDataResponse ShowInstanceMetricData(ShowInstanceMetricDataRequest showInstanceMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceMetricDataRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceMetricDataRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceMetricDataResponse>(response);
        }

        public SyncInvoker<ShowInstanceMetricDataResponse> ShowInstanceMetricDataInvoker(ShowInstanceMetricDataRequest showInstanceMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceMetricDataRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceMetricDataRequest);
            return new SyncInvoker<ShowInstanceMetricDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceMetricDataResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showInstanceParamGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceParamGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceParamGroupResponse>(response);
        }

        public SyncInvoker<ShowInstanceParamGroupResponse> ShowInstanceParamGroupInvoker(ShowInstanceParamGroupRequest showInstanceParamGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceParamGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceParamGroupRequest);
            return new SyncInvoker<ShowInstanceParamGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceParamGroupResponse>);
        }
        
        /// <summary>
        /// 获取指定实例的参数模板
        ///
        /// 获取指定实例的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceParamGroupDetailResponse ShowInstanceParamGroupDetail(ShowInstanceParamGroupDetailRequest showInstanceParamGroupDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceParamGroupDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceParamGroupDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceParamGroupDetailResponse>(response);
        }

        public SyncInvoker<ShowInstanceParamGroupDetailResponse> ShowInstanceParamGroupDetailInvoker(ShowInstanceParamGroupDetailRequest showInstanceParamGroupDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceParamGroupDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceParamGroupDetailRequest);
            return new SyncInvoker<ShowInstanceParamGroupDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceParamGroupDetailResponse>);
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
        /// 实例状态统计
        ///
        /// 实例状态统计。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstancesStatisticsResponse ShowInstancesStatistics(ShowInstancesStatisticsRequest showInstancesStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/instances-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstancesStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstancesStatisticsResponse>(response);
        }

        public SyncInvoker<ShowInstancesStatisticsResponse> ShowInstancesStatisticsInvoker(ShowInstancesStatisticsRequest showInstancesStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/instances-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstancesStatisticsRequest);
            return new SyncInvoker<ShowInstancesStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstancesStatisticsResponse>);
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
        /// 查询KMS秘钥详情
        ///
        /// 查询KMS秘钥详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKmsKeyDetailResponse ShowKmsKeyDetail(ShowKmsKeyDetailRequest showKmsKeyDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showKmsKeyDetailRequest.KmsKeyId, out var valueOfKmsKeyId)) urlParam.Add("kms_key_id", valueOfKmsKeyId);
            if (StringUtils.TryConvertToNonEmptyString(showKmsKeyDetailRequest.KmsProjectName, out var valueOfKmsProjectName)) urlParam.Add("kms_project_name", valueOfKmsProjectName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/kms/{kms_key_id}/describe-key/{kms_project_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKmsKeyDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKmsKeyDetailResponse>(response);
        }

        public SyncInvoker<ShowKmsKeyDetailResponse> ShowKmsKeyDetailInvoker(ShowKmsKeyDetailRequest showKmsKeyDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showKmsKeyDetailRequest.KmsKeyId, out var valueOfKmsKeyId)) urlParam.Add("kms_key_id", valueOfKmsKeyId);
            if (StringUtils.TryConvertToNonEmptyString(showKmsKeyDetailRequest.KmsProjectName, out var valueOfKmsProjectName)) urlParam.Add("kms_project_name", valueOfKmsProjectName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/kms/{kms_key_id}/describe-key/{kms_project_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKmsKeyDetailRequest);
            return new SyncInvoker<ShowKmsKeyDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKmsKeyDetailResponse>);
        }
        
        /// <summary>
        /// 查询指标分组的指标名称
        ///
        /// 查询指标分组的指标名称。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMetricNamesResponse ShowMetricNames(ShowMetricNamesRequest showMetricNamesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/metric-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetricNamesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMetricNamesResponse>(response);
        }

        public SyncInvoker<ShowMetricNamesResponse> ShowMetricNamesInvoker(ShowMetricNamesRequest showMetricNamesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/metric-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetricNamesRequest);
            return new SyncInvoker<ShowMetricNamesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMetricNamesResponse>);
        }
        
        /// <summary>
        /// 查询参数模板详情
        ///
        /// 根据参数模板ID获取指定参数模板详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowParameterGroupDetailResponse ShowParameterGroupDetail(ShowParameterGroupDetailRequest showParameterGroupDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showParameterGroupDetailRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showParameterGroupDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowParameterGroupDetailResponse>(response);
        }

        public SyncInvoker<ShowParameterGroupDetailResponse> ShowParameterGroupDetailInvoker(ShowParameterGroupDetailRequest showParameterGroupDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showParameterGroupDetailRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showParameterGroupDetailRequest);
            return new SyncInvoker<ShowParameterGroupDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowParameterGroupDetailResponse>);
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
        /// 查询重分布参数设置模板
        ///
        /// 查询重分布参数设置模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRedistributionParametersResponse ShowRedistributionParameters(ShowRedistributionParametersRequest showRedistributionParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redistribution-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRedistributionParametersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRedistributionParametersResponse>(response);
        }

        public SyncInvoker<ShowRedistributionParametersResponse> ShowRedistributionParametersInvoker(ShowRedistributionParametersRequest showRedistributionParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redistribution-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRedistributionParametersRequest);
            return new SyncInvoker<ShowRedistributionParametersResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRedistributionParametersResponse>);
        }
        
        /// <summary>
        /// 查询实时会话概览
        ///
        /// 查询数据库实例节点的实时会话概览信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSessionOverviewResponse ShowSessionOverview(ShowSessionOverviewRequest showSessionOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSessionOverviewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/session-overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSessionOverviewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSessionOverviewResponse>(response);
        }

        public SyncInvoker<ShowSessionOverviewResponse> ShowSessionOverviewInvoker(ShowSessionOverviewRequest showSessionOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSessionOverviewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/session-overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSessionOverviewRequest);
            return new SyncInvoker<ShowSessionOverviewResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSessionOverviewResponse>);
        }
        
        /// <summary>
        /// 获取分片的磁盘使用信息
        ///
        /// 获取分片的磁盘使用信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowShardDiskMessagesResponse ShowShardDiskMessages(ShowShardDiskMessagesRequest showShardDiskMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showShardDiskMessagesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/shard-volume-usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showShardDiskMessagesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowShardDiskMessagesResponse>(response);
        }

        public SyncInvoker<ShowShardDiskMessagesResponse> ShowShardDiskMessagesInvoker(ShowShardDiskMessagesRequest showShardDiskMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showShardDiskMessagesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/shard-volume-usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showShardDiskMessagesRequest);
            return new SyncInvoker<ShowShardDiskMessagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowShardDiskMessagesResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showSlowLogDownloadRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-log/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSlowLogDownloadRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSlowLogDownloadResponse>(response);
        }

        public SyncInvoker<ShowSlowLogDownloadResponse> ShowSlowLogDownloadInvoker(ShowSlowLogDownloadRequest showSlowLogDownloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSlowLogDownloadRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-log/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSlowLogDownloadRequest);
            return new SyncInvoker<ShowSlowLogDownloadResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSlowLogDownloadResponse>);
        }
        
        /// <summary>
        /// 查询SQL执行计划信息
        ///
        /// 查询等待事件的SQL执行计划信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSlowSqlPlanResponse ShowSlowSqlPlan(ShowSlowSqlPlanRequest showSlowSqlPlanRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSlowSqlPlanRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-sql/optimization/plan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSlowSqlPlanRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSlowSqlPlanResponse>(response);
        }

        public SyncInvoker<ShowSlowSqlPlanResponse> ShowSlowSqlPlanInvoker(ShowSlowSqlPlanRequest showSlowSqlPlanRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSlowSqlPlanRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-sql/optimization/plan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSlowSqlPlanRequest);
            return new SyncInvoker<ShowSlowSqlPlanResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSlowSqlPlanResponse>);
        }
        
        /// <summary>
        /// 查询SQL堆栈信息
        ///
        /// 查询等待事件的SQL堆栈信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSlowSqlStackResponse ShowSlowSqlStack(ShowSlowSqlStackRequest showSlowSqlStackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSlowSqlStackRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-sql/optimization/stack", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSlowSqlStackRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSlowSqlStackResponse>(response);
        }

        public SyncInvoker<ShowSlowSqlStackResponse> ShowSlowSqlStackInvoker(ShowSlowSqlStackRequest showSlowSqlStackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSlowSqlStackRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-sql/optimization/stack", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSlowSqlStackRequest);
            return new SyncInvoker<ShowSlowSqlStackResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSlowSqlStackResponse>);
        }
        
        /// <summary>
        /// 根据时间点或者备份文件查询原实例信息
        ///
        /// 根据时间点或者备份文件查询原实例信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSourceInstanceDetailResponse ShowSourceInstanceDetail(ShowSourceInstanceDetailRequest showSourceInstanceDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instance-snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSourceInstanceDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSourceInstanceDetailResponse>(response);
        }

        public SyncInvoker<ShowSourceInstanceDetailResponse> ShowSourceInstanceDetailInvoker(ShowSourceInstanceDetailRequest showSourceInstanceDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instance-snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSourceInstanceDetailRequest);
            return new SyncInvoker<ShowSourceInstanceDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSourceInstanceDetailResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showSslCertDownloadLinkRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-cert/download-link", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSslCertDownloadLinkRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSslCertDownloadLinkResponse>(response);
        }

        public SyncInvoker<ShowSslCertDownloadLinkResponse> ShowSslCertDownloadLinkInvoker(ShowSslCertDownloadLinkRequest showSslCertDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSslCertDownloadLinkRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-cert/download-link", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSslCertDownloadLinkRequest);
            return new SyncInvoker<ShowSslCertDownloadLinkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSslCertDownloadLinkResponse>);
        }
        
        /// <summary>
        /// 查询实例可升级版本
        ///
        /// 查询实例可升级版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUpgradeCandidateVersionsResponse ShowUpgradeCandidateVersions(ShowUpgradeCandidateVersionsRequest showUpgradeCandidateVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUpgradeCandidateVersionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade/candidate-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeCandidateVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUpgradeCandidateVersionsResponse>(response);
        }

        public SyncInvoker<ShowUpgradeCandidateVersionsResponse> ShowUpgradeCandidateVersionsInvoker(ShowUpgradeCandidateVersionsRequest showUpgradeCandidateVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUpgradeCandidateVersionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade/candidate-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeCandidateVersionsRequest);
            return new SyncInvoker<ShowUpgradeCandidateVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUpgradeCandidateVersionsResponse>);
        }
        
        /// <summary>
        /// 查询实例可升级版本
        ///
        /// 查询实例可升级版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUpgradeCandidateVersionsDetailsResponse ShowUpgradeCandidateVersionsDetails(ShowUpgradeCandidateVersionsDetailsRequest showUpgradeCandidateVersionsDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUpgradeCandidateVersionsDetailsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-upgrade/candidate-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeCandidateVersionsDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUpgradeCandidateVersionsDetailsResponse>(response);
        }

        public SyncInvoker<ShowUpgradeCandidateVersionsDetailsResponse> ShowUpgradeCandidateVersionsDetailsInvoker(ShowUpgradeCandidateVersionsDetailsRequest showUpgradeCandidateVersionsDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUpgradeCandidateVersionsDetailsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-upgrade/candidate-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeCandidateVersionsDetailsRequest);
            return new SyncInvoker<ShowUpgradeCandidateVersionsDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUpgradeCandidateVersionsDetailsResponse>);
        }
        
        /// <summary>
        /// 协调节点缩容
        ///
        /// 协调节点缩容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShrinkCnResponse ShrinkCn(ShrinkCnRequest shrinkCnRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(shrinkCnRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/coordinators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", shrinkCnRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<ShrinkCnResponse>(response);
        }

        public SyncInvoker<ShrinkCnResponse> ShrinkCnInvoker(ShrinkCnRequest shrinkCnRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(shrinkCnRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/coordinators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", shrinkCnRequest);
            return new SyncInvoker<ShrinkCnResponse>(this, "DELETE", request, JsonUtils.DeSerialize<ShrinkCnResponse>);
        }
        
        /// <summary>
        /// 启动实例/节点
        ///
        /// 启动实例/节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartInstanceResponse StartInstance(StartInstanceRequest startInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-startup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartInstanceResponse>(response);
        }

        public SyncInvoker<StartInstanceResponse> StartInstanceInvoker(StartInstanceRequest startInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-startup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startInstanceRequest);
            return new SyncInvoker<StartInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StartInstanceResponse>);
        }
        
        /// <summary>
        /// 开启M兼容端口服务
        ///
        /// 开启指定实例的M兼容端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartMysqlCompatibilityResponse StartMysqlCompatibility(StartMysqlCompatibilityRequest startMysqlCompatibilityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startMysqlCompatibilityRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/mysql-compatibility", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startMysqlCompatibilityRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartMysqlCompatibilityResponse>(response);
        }

        public SyncInvoker<StartMysqlCompatibilityResponse> StartMysqlCompatibilityInvoker(StartMysqlCompatibilityRequest startMysqlCompatibilityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startMysqlCompatibilityRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/mysql-compatibility", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startMysqlCompatibilityRequest);
            return new SyncInvoker<StartMysqlCompatibilityResponse>(this, "POST", request, JsonUtils.DeSerialize<StartMysqlCompatibilityResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(stopBackupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBackupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopBackupResponse>(response);
        }

        public SyncInvoker<StopBackupResponse> StopBackupInvoker(StopBackupRequest stopBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopBackupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBackupRequest);
            return new SyncInvoker<StopBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<StopBackupResponse>);
        }
        
        /// <summary>
        /// 结束空闲会话
        ///
        /// 结束空闲会话。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopFreeSessionResponse StopFreeSession(StopFreeSessionRequest stopFreeSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopFreeSessionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kill-free-session", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopFreeSessionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopFreeSessionResponse>(response);
        }

        public SyncInvoker<StopFreeSessionResponse> StopFreeSessionInvoker(StopFreeSessionRequest stopFreeSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopFreeSessionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kill-free-session", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopFreeSessionRequest);
            return new SyncInvoker<StopFreeSessionResponse>(this, "POST", request, JsonUtils.DeSerialize<StopFreeSessionResponse>);
        }
        
        /// <summary>
        /// 停止实例/节点
        ///
        /// 停止数据库，同时支持节点级别的停止操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopInstanceResponse StopInstance(StopInstanceRequest stopInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopInstanceResponse>(response);
        }

        public SyncInvoker<StopInstanceResponse> StopInstanceInvoker(StopInstanceRequest stopInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopInstanceRequest);
            return new SyncInvoker<StopInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StopInstanceResponse>);
        }
        
        /// <summary>
        /// 结束会话
        ///
        /// 查杀指定会话列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopSessionResponse StopSession(StopSessionRequest stopSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopSessionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kill-session", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopSessionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopSessionResponse>(response);
        }

        public SyncInvoker<StopSessionResponse> StopSessionInvoker(StopSessionRequest stopSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopSessionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kill-session", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopSessionRequest);
            return new SyncInvoker<StopSessionResponse>(this, "POST", request, JsonUtils.DeSerialize<StopSessionResponse>);
        }
        
        /// <summary>
        /// 手动结束事务
        ///
        /// 手动结束事务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopTransactionResponse StopTransaction(StopTransactionRequest stopTransactionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopTransactionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/transactions/kill", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopTransactionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopTransactionResponse>(response);
        }

        public SyncInvoker<StopTransactionResponse> StopTransactionInvoker(StopTransactionRequest stopTransactionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopTransactionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/transactions/kill", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopTransactionRequest);
            return new SyncInvoker<StopTransactionResponse>(this, "POST", request, JsonUtils.DeSerialize<StopTransactionResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(switchConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SwitchConfigurationResponse>(response);
        }

        public SyncInvoker<SwitchConfigurationResponse> SwitchConfigurationInvoker(SwitchConfigurationRequest switchConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchConfigurationRequest);
            return new SyncInvoker<SwitchConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchConfigurationResponse>);
        }
        
        /// <summary>
        /// 开启透明加密
        ///
        /// 开启透明加密。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchKmsTdeResponse SwitchKmsTde(SwitchKmsTdeRequest switchKmsTdeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchKmsTdeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kms-tde/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchKmsTdeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SwitchKmsTdeResponse>(response);
        }

        public SyncInvoker<SwitchKmsTdeResponse> SwitchKmsTdeInvoker(SwitchKmsTdeRequest switchKmsTdeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchKmsTdeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kms-tde/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchKmsTdeRequest);
            return new SyncInvoker<SwitchKmsTdeResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchKmsTdeResponse>);
        }
        
        /// <summary>
        /// 分布式实例一主一备一日志形态切换到一主两备形态
        ///
        /// 当前只支持分布式独立部署一主一备一日志切换至一主两备形态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchReplicaResponse SwitchReplica(SwitchReplicaRequest switchReplicaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchReplicaRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switch-replica", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchReplicaRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchReplicaResponse>(response);
        }

        public SyncInvoker<SwitchReplicaResponse> SwitchReplicaInvoker(SwitchReplicaRequest switchReplicaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchReplicaRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switch-replica", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchReplicaRequest);
            return new SyncInvoker<SwitchReplicaResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchReplicaResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(switchShardRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switch-shard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchShardRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchShardResponse>(response);
        }

        public SyncInvoker<SwitchShardResponse> SwitchShardInvoker(SwitchShardRequest switchShardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchShardRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switch-shard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchShardRequest);
            return new SyncInvoker<SwitchShardResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchShardResponse>);
        }
        
        /// <summary>
        /// 修改扩容优化参数
        ///
        /// 修改扩容优化参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateExpansionParametersResponse UpdateExpansionParameters(UpdateExpansionParametersRequest updateExpansionParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateExpansionParametersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/expansion-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateExpansionParametersRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateExpansionParametersResponse>(response);
        }

        public SyncInvoker<UpdateExpansionParametersResponse> UpdateExpansionParametersInvoker(UpdateExpansionParametersRequest updateExpansionParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateExpansionParametersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/expansion-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateExpansionParametersRequest);
            return new SyncInvoker<UpdateExpansionParametersResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateExpansionParametersResponse>);
        }
        
        /// <summary>
        /// 开启特性
        ///
        /// 打开高级特性开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateFeaturesResponse UpdateFeatures(UpdateFeaturesRequest updateFeaturesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFeaturesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/advance-features", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateFeaturesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateFeaturesResponse>(response);
        }

        public SyncInvoker<UpdateFeaturesResponse> UpdateFeaturesInvoker(UpdateFeaturesRequest updateFeaturesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFeaturesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/advance-features", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateFeaturesRequest);
            return new SyncInvoker<UpdateFeaturesResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateFeaturesResponse>);
        }
        
        /// <summary>
        /// 修改实例别名
        ///
        /// 创建或修改实例备注。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceAliasResponse UpdateInstanceAlias(UpdateInstanceAliasRequest updateInstanceAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceAliasRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/alias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceAliasRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceAliasResponse>(response);
        }

        public SyncInvoker<UpdateInstanceAliasResponse> UpdateInstanceAliasInvoker(UpdateInstanceAliasRequest updateInstanceAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceAliasRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/alias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceAliasRequest);
            return new SyncInvoker<UpdateInstanceAliasResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceAliasResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceConfigurationResponse>(response);
        }

        public SyncInvoker<UpdateInstanceConfigurationResponse> UpdateInstanceConfigurationInvoker(UpdateInstanceConfigurationRequest updateInstanceConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceNameRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceNameResponse>(response);
        }

        public SyncInvoker<UpdateInstanceNameResponse> UpdateInstanceNameInvoker(UpdateInstanceNameRequest updateInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceNameRequest);
            return new SyncInvoker<UpdateInstanceNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceNameResponse>);
        }
        
        /// <summary>
        /// 实例内核版本升级
        ///
        /// GaussDB实例版本升级。包括灰度升级，就地升级，热补丁升级等三种升级方式。 
        /// 
        /// - 就地升级：
        /// 
        ///   就地升级需要停止业务进行，会一次性升级集群中所有节点。就地升级需要暂停业务30分钟来升级。 
        /// 
        /// - 灰度升级： 
        /// 
        ///   每个主DN或者CN组件升级就有一次10秒业务中断。升级过程均是先管理面，再数据面，由备到主的升级方式。灰度升级支持升级自动提交和升级待观察两种操作方式。
        /// 
        ///   - 升级自动提交：所有节点进程一起升级，在升级过程中有大概10秒的业务中断，不阻塞其他业务操作。 
        /// 
        ///   - 升级待观察：升级待观察，将数据库升级过程细分为升级，提交两个阶段。
        /// 
        ///     - 升级阶段可以根据部署方式细分为按分片或者按AZ的滚动升级。
        /// 
        ///       - 分布式实例：根据分片数滚动升级。
        ///       - 集中式实例：根据AZ数进行滚动升级。 
        ///     
        ///     - 提交阶段可以对升级完成后的实例进行业务测试，根据需要可以选择提交升级或者升级回退。
        /// 
        ///       - 提交升级：提交升级。在升级完成，进入提交阶段时。业务测试正常后提交升级，完成本次升级流程。
        /// 
        ///       - 升级回退：升级回退，在升级完成，进入提交阶段时。可以根据需要回退本次升级，回退到升级前的版本。
        /// 
        /// - 热补丁升级
        /// 
        ///   - 升级自动提交：热补丁自动升级并提交，中间无业务中断。
        /// 
        ///   - 升级回退：热补丁回退，无业务中断时间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceVersionsResponse UpdateInstanceVersions(UpdateInstanceVersionsRequest updateInstanceVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceVersionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceVersionsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceVersionsResponse>(response);
        }

        public SyncInvoker<UpdateInstanceVersionsResponse> UpdateInstanceVersionsInvoker(UpdateInstanceVersionsRequest updateInstanceVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceVersionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceVersionsRequest);
            return new SyncInvoker<UpdateInstanceVersionsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceVersionsResponse>);
        }
        
        /// <summary>
        /// 更新/关闭M兼容端口服务
        ///
        /// 更新指定实例的M兼容端口服务配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMysqlCompatibilityResponse UpdateMysqlCompatibility(UpdateMysqlCompatibilityRequest updateMysqlCompatibilityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMysqlCompatibilityRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/mysql-compatibility", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMysqlCompatibilityRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMysqlCompatibilityResponse>(response);
        }

        public SyncInvoker<UpdateMysqlCompatibilityResponse> UpdateMysqlCompatibilityInvoker(UpdateMysqlCompatibilityRequest updateMysqlCompatibilityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMysqlCompatibilityRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/mysql-compatibility", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMysqlCompatibilityRequest);
            return new SyncInvoker<UpdateMysqlCompatibilityResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMysqlCompatibilityResponse>);
        }
        
        /// <summary>
        /// 修改重分布参数
        ///
        /// 修改重分布参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRedistributionControlResponse UpdateRedistributionControl(UpdateRedistributionControlRequest updateRedistributionControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRedistributionControlRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/redistribution-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateRedistributionControlRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRedistributionControlResponse>(response);
        }

        public SyncInvoker<UpdateRedistributionControlResponse> UpdateRedistributionControlInvoker(UpdateRedistributionControlRequest updateRedistributionControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRedistributionControlRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/redistribution-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateRedistributionControlRequest);
            return new SyncInvoker<UpdateRedistributionControlResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRedistributionControlResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(upgradeInstanceVersionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeInstanceVersionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpgradeInstanceVersionResponse>(response);
        }

        public SyncInvoker<UpgradeInstanceVersionResponse> UpgradeInstanceVersionInvoker(UpgradeInstanceVersionRequest upgradeInstanceVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeInstanceVersionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeInstanceVersionRequest);
            return new SyncInvoker<UpgradeInstanceVersionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpgradeInstanceVersionResponse>);
        }
        
        /// <summary>
        /// 批量实例内核版本升级
        ///
        /// GaussDB批量实例版本升级。包括灰度升级，就地升级、热补丁升级三种升级方式。
        /// 就地升级：
        /// 就地升级需要停止业务进行，会一次性升级集群中所有节点。就地升级需要暂停业务30分钟来升级。
        /// 灰度升级：
        /// 升级自动提交：所有节点进程一起升级，在升级过程中有大概10秒的业务中断，不阻塞其他业务操作。
        /// 升级待观察：升级待观察，将数据库升级过程细分为升级，提交两个阶段。升级阶段可以根据部署方式细分为按分片或者按az的滚动升级，提交阶段可以对升级完成后的实例进行业务测试，根据需要可以选择提交升级，或者升级回退。每个主dn或者cn组件升级就有一次10秒业务中断。升级过程均是先管理面，再数据面，由备到主的升级方式。 分布式实例：根据分片数滚动升级，每次滚动升级可以根据选择的分片数进行指定分片数量的节点进行升级。 主备版实例：根据AZ数进行滚动升级，每次滚动升级可以根据选择的AZ进行1个分区或者多个分区进行升级。
        /// 热补丁升级：
        /// 升级自动提交：热补丁自动升级并提交，中间无业务中断，仅修复产品bug。
        /// 提交升级：提交升级。在升级完成，进入提交阶段时。业务测试正常后提交升级，完成本次升级流程。
        /// 升级回退：升级回退，在升级完成，进入提交阶段时。可以根据需要回退本次升级，回退到升级前的版本。
        /// 批量实例可升级版本大于当前所有实例的引擎版本，且选择的所有实例，其升级方式和操作方式要保持一致。
        /// 若批量实例升级方式是灰度升级，默认升级所有az和分片。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeInstancesVersionResponse UpgradeInstancesVersion(UpgradeInstancesVersionRequest upgradeInstancesVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeInstancesVersionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpgradeInstancesVersionResponse>(response);
        }

        public SyncInvoker<UpgradeInstancesVersionResponse> UpgradeInstancesVersionInvoker(UpgradeInstancesVersionRequest upgradeInstancesVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeInstancesVersionRequest);
            return new SyncInvoker<UpgradeInstancesVersionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpgradeInstancesVersionResponse>);
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
        
        /// <summary>
        /// 采集ASP报告
        ///
        /// 采集ASP报告。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CollectAspResponse CollectAsp(CollectAspRequest collectAspRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(collectAspRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/asp/collect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", collectAspRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CollectAspResponse>(response);
        }

        public SyncInvoker<CollectAspResponse> CollectAspInvoker(CollectAspRequest collectAspRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(collectAspRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/asp/collect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", collectAspRequest);
            return new SyncInvoker<CollectAspResponse>(this, "POST", request, JsonUtils.DeSerialize<CollectAspResponse>);
        }
        
        /// <summary>
        /// 查询asp采集结果
        ///
        /// 查询ASP采集结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAspInfosResponse ListAspInfos(ListAspInfosRequest listAspInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAspInfosRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/asp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAspInfosRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAspInfosResponse>(response);
        }

        public SyncInvoker<ListAspInfosResponse> ListAspInfosInvoker(ListAspInfosRequest listAspInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAspInfosRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/asp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAspInfosRequest);
            return new SyncInvoker<ListAspInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAspInfosResponse>);
        }
        
        /// <summary>
        /// 查询ASP开关状态
        ///
        /// 查询ASP开关状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAspStatusResponse ShowAspStatus(ShowAspStatusRequest showAspStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAspStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/asp/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAspStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAspStatusResponse>(response);
        }

        public SyncInvoker<ShowAspStatusResponse> ShowAspStatusInvoker(ShowAspStatusRequest showAspStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAspStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/asp/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAspStatusRequest);
            return new SyncInvoker<ShowAspStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAspStatusResponse>);
        }
        
        /// <summary>
        /// 打开或者关闭ASP开关
        ///
        /// 打开或者关闭ASP开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchAspStatusResponse SwitchAspStatus(SwitchAspStatusRequest switchAspStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchAspStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/asp/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAspStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SwitchAspStatusResponse>(response);
        }

        public SyncInvoker<SwitchAspStatusResponse> SwitchAspStatusInvoker(SwitchAspStatusRequest switchAspStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchAspStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/asp/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAspStatusRequest);
            return new SyncInvoker<SwitchAspStatusResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SwitchAspStatusResponse>);
        }
        
        /// <summary>
        /// 关联LTS日志流
        ///
        /// 关联LTS日志流。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BindLtsConfigResponse BindLtsConfig(BindLtsConfigRequest bindLtsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", bindLtsConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BindLtsConfigResponse>(response);
        }

        public SyncInvoker<BindLtsConfigResponse> BindLtsConfigInvoker(BindLtsConfigRequest bindLtsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", bindLtsConfigRequest);
            return new SyncInvoker<BindLtsConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<BindLtsConfigResponse>);
        }
        
        /// <summary>
        /// 查看LTS日志配置信息
        ///
        /// 查看LTS日志配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLtsConfigsResponse ListLtsConfigs(ListLtsConfigsRequest listLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLtsConfigsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLtsConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLtsConfigsResponse>(response);
        }

        public SyncInvoker<ListLtsConfigsResponse> ListLtsConfigsInvoker(ListLtsConfigsRequest listLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLtsConfigsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLtsConfigsRequest);
            return new SyncInvoker<ListLtsConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLtsConfigsResponse>);
        }
        
        /// <summary>
        /// 解除关联LTS日志流
        ///
        /// 解除关联LTS日志流。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UnbindLtsConfigResponse UnbindLtsConfig(UnbindLtsConfigRequest unbindLtsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", unbindLtsConfigRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<UnbindLtsConfigResponse>(response);
        }

        public SyncInvoker<UnbindLtsConfigResponse> UnbindLtsConfigInvoker(UnbindLtsConfigRequest unbindLtsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", unbindLtsConfigRequest);
            return new SyncInvoker<UnbindLtsConfigResponse>(this, "DELETE", request, JsonUtils.DeSerialize<UnbindLtsConfigResponse>);
        }
        
        /// <summary>
        /// 创建限流任务
        ///
        /// 根据具体范围和类型，进行限流任务的创建
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateLimitTaskResponse CreateLimitTask(CreateLimitTaskRequest createLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createLimitTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/limit-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLimitTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateLimitTaskResponse>(response);
        }

        public SyncInvoker<CreateLimitTaskResponse> CreateLimitTaskInvoker(CreateLimitTaskRequest createLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createLimitTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/limit-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLimitTaskRequest);
            return new SyncInvoker<CreateLimitTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLimitTaskResponse>);
        }
        
        /// <summary>
        /// 创建SQL限流任务
        ///
        /// 根据具体范围和类型，进行限流任务的创建。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSqlLimitTaskResponse CreateSqlLimitTask(CreateSqlLimitTaskRequest createSqlLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSqlLimitTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/limit-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSqlLimitTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSqlLimitTaskResponse>(response);
        }

        public SyncInvoker<CreateSqlLimitTaskResponse> CreateSqlLimitTaskInvoker(CreateSqlLimitTaskRequest createSqlLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSqlLimitTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/limit-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSqlLimitTaskRequest);
            return new SyncInvoker<CreateSqlLimitTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSqlLimitTaskResponse>);
        }
        
        /// <summary>
        /// 删除限流任务
        ///
        /// 根据task_id进行限流任务的删除
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLimitTaskResponse DeleteLimitTask(DeleteLimitTaskRequest deleteLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLimitTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(deleteLimitTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/limit-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLimitTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLimitTaskResponse>(response);
        }

        public SyncInvoker<DeleteLimitTaskResponse> DeleteLimitTaskInvoker(DeleteLimitTaskRequest deleteLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLimitTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(deleteLimitTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/limit-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLimitTaskRequest);
            return new SyncInvoker<DeleteLimitTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLimitTaskResponse>);
        }
        
        /// <summary>
        /// 删除SQL限流任务
        ///
        /// 根据task_id进行SQL限流任务的删除
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSqlLimitTaskResponse DeleteSqlLimitTask(DeleteSqlLimitTaskRequest deleteSqlLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSqlLimitTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSqlLimitTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/limit-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteSqlLimitTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSqlLimitTaskResponse>(response);
        }

        public SyncInvoker<DeleteSqlLimitTaskResponse> DeleteSqlLimitTaskInvoker(DeleteSqlLimitTaskRequest deleteSqlLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSqlLimitTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSqlLimitTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/limit-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteSqlLimitTaskRequest);
            return new SyncInvoker<DeleteSqlLimitTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSqlLimitTaskResponse>);
        }
        
        /// <summary>
        /// 查询实例全量SQL聚合统计列表
        ///
        /// 查询GaussDB数据库实例全量SQL聚合统计列表，主要统计各唯一SQL ID下的SQL记录总数量以及相关时间指标的平均值。支持增强型条件过滤， 如可以对SQL文本（query字段）进行多条件合并查询，对total_sql_time、sql_count字段进行大于、小于、区间范围等条件的过滤。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEnhanceFullSqlStatisticsResponse ListEnhanceFullSqlStatistics(ListEnhanceFullSqlStatisticsRequest listEnhanceFullSqlStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEnhanceFullSqlStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/list-full-sql-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listEnhanceFullSqlStatisticsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListEnhanceFullSqlStatisticsResponse>(response);
        }

        public SyncInvoker<ListEnhanceFullSqlStatisticsResponse> ListEnhanceFullSqlStatisticsInvoker(ListEnhanceFullSqlStatisticsRequest listEnhanceFullSqlStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEnhanceFullSqlStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/list-full-sql-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listEnhanceFullSqlStatisticsRequest);
            return new SyncInvoker<ListEnhanceFullSqlStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListEnhanceFullSqlStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询全量单条SQL记录列表
        ///
        /// 查询GaussDB数据库实例全量SQL日志记录列表，支持增强型条件过滤。 如可对SQL文本（query字段）进行多条件合并查询，可对db_time、cpu_time、data_io_time及execution_time字段进行大于、小于、区间范围等条件的过滤
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEnhanceFullSqlsResponse ListEnhanceFullSqls(ListEnhanceFullSqlsRequest listEnhanceFullSqlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEnhanceFullSqlsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/list-full-sqls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listEnhanceFullSqlsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListEnhanceFullSqlsResponse>(response);
        }

        public SyncInvoker<ListEnhanceFullSqlsResponse> ListEnhanceFullSqlsInvoker(ListEnhanceFullSqlsRequest listEnhanceFullSqlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEnhanceFullSqlsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/list-full-sqls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listEnhanceFullSqlsRequest);
            return new SyncInvoker<ListEnhanceFullSqlsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListEnhanceFullSqlsResponse>);
        }
        
        /// <summary>
        /// 查询GaussDB数据库实例全量SQL开关记录列表
        ///
        /// 查询GaussDB数据库实例全量SQL开关记录列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFullSqlSwitchesResponse ListFullSqlSwitches(ListFullSqlSwitchesRequest listFullSqlSwitchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFullSqlSwitchesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/full-sql-switches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFullSqlSwitchesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFullSqlSwitchesResponse>(response);
        }

        public SyncInvoker<ListFullSqlSwitchesResponse> ListFullSqlSwitchesInvoker(ListFullSqlSwitchesRequest listFullSqlSwitchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFullSqlSwitchesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/full-sql-switches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFullSqlSwitchesRequest);
            return new SyncInvoker<ListFullSqlSwitchesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFullSqlSwitchesResponse>);
        }
        
        /// <summary>
        /// 根据指定条件查询限流任务列表
        ///
        /// 根据指定条件查询限流任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLimitTaskResponse ListLimitTask(ListLimitTaskRequest listLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLimitTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/limit-task-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLimitTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLimitTaskResponse>(response);
        }

        public SyncInvoker<ListLimitTaskResponse> ListLimitTaskInvoker(ListLimitTaskRequest listLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLimitTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/limit-task-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLimitTaskRequest);
            return new SyncInvoker<ListLimitTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLimitTaskResponse>);
        }
        
        /// <summary>
        /// 查询节点的sql模板列表
        ///
        /// 查询节点的sql模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNodeLimitSqlModelResponse ListNodeLimitSqlModel(ListNodeLimitSqlModelRequest listNodeLimitSqlModelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNodeLimitSqlModelRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/list-node-limit-sql-model", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodeLimitSqlModelRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNodeLimitSqlModelResponse>(response);
        }

        public SyncInvoker<ListNodeLimitSqlModelResponse> ListNodeLimitSqlModelInvoker(ListNodeLimitSqlModelRequest listNodeLimitSqlModelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNodeLimitSqlModelRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/list-node-limit-sql-model", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodeLimitSqlModelRequest);
            return new SyncInvoker<ListNodeLimitSqlModelResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNodeLimitSqlModelResponse>);
        }
        
        /// <summary>
        /// 查询慢SQL详情
        ///
        /// 根据归一化SQLID，查询该SQL模板详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSlowSqlDetailsResponse ListSlowSqlDetails(ListSlowSqlDetailsRequest listSlowSqlDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowSqlDetailsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-sql-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSlowSqlDetailsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListSlowSqlDetailsResponse>(response);
        }

        public SyncInvoker<ListSlowSqlDetailsResponse> ListSlowSqlDetailsInvoker(ListSlowSqlDetailsRequest listSlowSqlDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowSqlDetailsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-sql-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSlowSqlDetailsRequest);
            return new SyncInvoker<ListSlowSqlDetailsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSlowSqlDetailsResponse>);
        }
        
        /// <summary>
        /// 查询慢SQL列表
        ///
        /// 查询慢SQL列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSlowSqlsResponse ListSlowSqls(ListSlowSqlsRequest listSlowSqlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowSqlsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-sql-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSlowSqlsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListSlowSqlsResponse>(response);
        }

        public SyncInvoker<ListSlowSqlsResponse> ListSlowSqlsInvoker(ListSlowSqlsRequest listSlowSqlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowSqlsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-sql-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSlowSqlsRequest);
            return new SyncInvoker<ListSlowSqlsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSlowSqlsResponse>);
        }
        
        /// <summary>
        /// 查询慢SQL节点信息
        ///
        /// 根据实例ID查询慢SQL节点信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSqlExcuteNodesResponse ListSqlExcuteNodes(ListSqlExcuteNodesRequest listSqlExcuteNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlExcuteNodesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-sql-execute-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSqlExcuteNodesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListSqlExcuteNodesResponse>(response);
        }

        public SyncInvoker<ListSqlExcuteNodesResponse> ListSqlExcuteNodesInvoker(ListSqlExcuteNodesRequest listSqlExcuteNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlExcuteNodesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-sql-execute-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSqlExcuteNodesRequest);
            return new SyncInvoker<ListSqlExcuteNodesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSqlExcuteNodesResponse>);
        }
        
        /// <summary>
        /// 根据指定条件查询SQL限流任务列表
        ///
        /// 根据指定条件查询SQL限流任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSqlLimitTaskResponse ListSqlLimitTask(ListSqlLimitTaskRequest listSqlLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlLimitTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/limit-task-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSqlLimitTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListSqlLimitTaskResponse>(response);
        }

        public SyncInvoker<ListSqlLimitTaskResponse> ListSqlLimitTaskInvoker(ListSqlLimitTaskRequest listSqlLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlLimitTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/limit-task-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSqlLimitTaskRequest);
            return new SyncInvoker<ListSqlLimitTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSqlLimitTaskResponse>);
        }
        
        /// <summary>
        /// 查询SQL执行计划绑定情况
        ///
        /// 查询SQL执行计划绑定情况。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSqlPlanActionResponse ListSqlPlanAction(ListSqlPlanActionRequest listSqlPlanActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlPlanActionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listSqlPlanActionRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql/{node_id}/plans/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSqlPlanActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListSqlPlanActionResponse>(response);
        }

        public SyncInvoker<ListSqlPlanActionResponse> ListSqlPlanActionInvoker(ListSqlPlanActionRequest listSqlPlanActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlPlanActionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listSqlPlanActionRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql/{node_id}/plans/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSqlPlanActionRequest);
            return new SyncInvoker<ListSqlPlanActionResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSqlPlanActionResponse>);
        }
        
        /// <summary>
        /// 查询GaussDB数据库实例SQL链路
        ///
        /// 查询GaussDB数据库实例SQL链路，包含实例上对应组件的链路列表，如dn_6001、dn_6002、cn_5001、cn_5002。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSqlTraceResponse ListSqlTrace(ListSqlTraceRequest listSqlTraceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlTraceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/full-sql/sql-trace", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlTraceRequest);
            var response = DoHttpRequestSync("GET", request);
            var listSqlTraceResponse = JsonUtils.DeSerializeNull<ListSqlTraceResponse>(response);
            listSqlTraceResponse.Body = JsonUtils.DeSerializeList<NodeExecutionInfoResult>(response);
            return listSqlTraceResponse;
        }

        public SyncInvoker<ListSqlTraceResponse> ListSqlTraceInvoker(ListSqlTraceRequest listSqlTraceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlTraceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/full-sql/sql-trace", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlTraceRequest);
            return new SyncInvoker<ListSqlTraceResponse>(this, "GET", request, response =>
            {
                var listSqlTraceResponse = JsonUtils.DeSerializeNull<ListSqlTraceResponse>(response);
                listSqlTraceResponse.Body = JsonUtils.DeSerializeList<NodeExecutionInfoResult>(response);
                return listSqlTraceResponse;
            });
        }
        
        /// <summary>
        /// 查询单条SQL详情
        ///
        /// 查询单条SQL详情。对于分布式版实例，可查询对应SQL的完整执行记录，包含CN和DN上SQL语句执行历史。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFullSqlResponse ShowFullSql(ShowFullSqlRequest showFullSqlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFullSqlRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showFullSqlRequest.SqlExecId, out var valueOfSqlExecId)) urlParam.Add("sql_exec_id", valueOfSqlExecId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/full-sqls/{sql_exec_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFullSqlRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFullSqlResponse>(response);
        }

        public SyncInvoker<ShowFullSqlResponse> ShowFullSqlInvoker(ShowFullSqlRequest showFullSqlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFullSqlRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showFullSqlRequest.SqlExecId, out var valueOfSqlExecId)) urlParam.Add("sql_exec_id", valueOfSqlExecId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/full-sqls/{sql_exec_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFullSqlRequest);
            return new SyncInvoker<ShowFullSqlResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFullSqlResponse>);
        }
        
        /// <summary>
        /// 查询全局慢SQL详情
        ///
        /// 根据唯一SQLID，查询指定组件的慢SQL详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGlobalSlowSqlDetailResponse ShowGlobalSlowSqlDetail(ShowGlobalSlowSqlDetailRequest showGlobalSlowSqlDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGlobalSlowSqlDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/global-slow-sql-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showGlobalSlowSqlDetailRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowGlobalSlowSqlDetailResponse>(response);
        }

        public SyncInvoker<ShowGlobalSlowSqlDetailResponse> ShowGlobalSlowSqlDetailInvoker(ShowGlobalSlowSqlDetailRequest showGlobalSlowSqlDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGlobalSlowSqlDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/global-slow-sql-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showGlobalSlowSqlDetailRequest);
            return new SyncInvoker<ShowGlobalSlowSqlDetailResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowGlobalSlowSqlDetailResponse>);
        }
        
        /// <summary>
        /// 查询限流任务详情
        ///
        /// 查询限流任务详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLimitTaskResponse ShowLimitTask(ShowLimitTaskRequest showLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLimitTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(showLimitTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/limit-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLimitTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLimitTaskResponse>(response);
        }

        public SyncInvoker<ShowLimitTaskResponse> ShowLimitTaskInvoker(ShowLimitTaskRequest showLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLimitTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(showLimitTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/limit-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLimitTaskRequest);
            return new SyncInvoker<ShowLimitTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLimitTaskResponse>);
        }
        
        /// <summary>
        /// 查询SQL限流任务详情
        ///
        /// 查询SQL限流任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSqlLimitTaskResponse ShowSqlLimitTask(ShowSqlLimitTaskRequest showSqlLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSqlLimitTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(showSqlLimitTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/limit-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSqlLimitTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSqlLimitTaskResponse>(response);
        }

        public SyncInvoker<ShowSqlLimitTaskResponse> ShowSqlLimitTaskInvoker(ShowSqlLimitTaskRequest showSqlLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSqlLimitTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(showSqlLimitTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/limit-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSqlLimitTaskRequest);
            return new SyncInvoker<ShowSqlLimitTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSqlLimitTaskResponse>);
        }
        
        /// <summary>
        /// 开启GaussDB数据库实例全量SQL功能
        ///
        /// 开启全量SQL功能。使实例Agent侧开启内核侧全量SQL能力，持续化采集GaussDB数据库实例上的执行SQL语句，定时批量持久化存储于LTS云服务对应日志流中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartFullSqlResponse StartFullSql(StartFullSqlRequest startFullSqlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startFullSqlRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/full-sqls/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startFullSqlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartFullSqlResponse>(response);
        }

        public SyncInvoker<StartFullSqlResponse> StartFullSqlInvoker(StartFullSqlRequest startFullSqlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startFullSqlRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/full-sqls/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startFullSqlRequest);
            return new SyncInvoker<StartFullSqlResponse>(this, "POST", request, JsonUtils.DeSerialize<StartFullSqlResponse>);
        }
        
        /// <summary>
        /// 关闭全量SQL功能
        ///
        /// 关闭全量SQL功能。关闭后，实例Agent侧将停止内核侧全量SQL语句记录的实时采集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopFullSqlResponse StopFullSql(StopFullSqlRequest stopFullSqlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopFullSqlRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/full-sqls/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopFullSqlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopFullSqlResponse>(response);
        }

        public SyncInvoker<StopFullSqlResponse> StopFullSqlInvoker(StopFullSqlRequest stopFullSqlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopFullSqlRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/full-sqls/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopFullSqlRequest);
            return new SyncInvoker<StopFullSqlResponse>(this, "POST", request, JsonUtils.DeSerialize<StopFullSqlResponse>);
        }
        
        /// <summary>
        /// 同步内核侧sql限流数据至管控侧
        ///
        /// 同步内核侧sql限流数据至管控侧
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SyncLimitDataResponse SyncLimitData(SyncLimitDataRequest syncLimitDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(syncLimitDataRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sync-limit-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncLimitDataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SyncLimitDataResponse>(response);
        }

        public SyncInvoker<SyncLimitDataResponse> SyncLimitDataInvoker(SyncLimitDataRequest syncLimitDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(syncLimitDataRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sync-limit-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncLimitDataRequest);
            return new SyncInvoker<SyncLimitDataResponse>(this, "POST", request, JsonUtils.DeSerialize<SyncLimitDataResponse>);
        }
        
        /// <summary>
        /// 修改限流任务
        ///
        /// 根据新的条件进行限流任务的更新
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateLimitTaskResponse UpdateLimitTask(UpdateLimitTaskRequest updateLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLimitTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(updateLimitTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/limit-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLimitTaskRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLimitTaskResponse>(response);
        }

        public SyncInvoker<UpdateLimitTaskResponse> UpdateLimitTaskInvoker(UpdateLimitTaskRequest updateLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLimitTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(updateLimitTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/limit-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLimitTaskRequest);
            return new SyncInvoker<UpdateLimitTaskResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLimitTaskResponse>);
        }
        
        /// <summary>
        /// 修改SQL限流任务
        ///
        /// 根据新的条件进行SQL限流任务的更新。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSqlLimitTaskResponse UpdateSqlLimitTask(UpdateSqlLimitTaskRequest updateSqlLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSqlLimitTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateSqlLimitTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/limit-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSqlLimitTaskRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSqlLimitTaskResponse>(response);
        }

        public SyncInvoker<UpdateSqlLimitTaskResponse> UpdateSqlLimitTaskInvoker(UpdateSqlLimitTaskRequest updateSqlLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSqlLimitTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateSqlLimitTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/limit-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSqlLimitTaskRequest);
            return new SyncInvoker<UpdateSqlLimitTaskResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSqlLimitTaskResponse>);
        }
        
        /// <summary>
        /// 查询SQL PATCH
        ///
        /// 查询SQL PATCH信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSqlPatchResponse ShowSqlPatch(ShowSqlPatchRequest showSqlPatchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSqlPatchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-patch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSqlPatchRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSqlPatchResponse>(response);
        }

        public SyncInvoker<ShowSqlPatchResponse> ShowSqlPatchInvoker(ShowSqlPatchRequest showSqlPatchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSqlPatchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-patch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSqlPatchRequest);
            return new SyncInvoker<ShowSqlPatchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSqlPatchResponse>);
        }
        
        /// <summary>
        /// 查询TopSQL列表
        ///
        /// 查询TopSQL列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTopSqlsResponse ListTopSqls(ListTopSqlsRequest listTopSqlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTopSqlsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/top-sql-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listTopSqlsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListTopSqlsResponse>(response);
        }

        public SyncInvoker<ListTopSqlsResponse> ListTopSqlsInvoker(ListTopSqlsRequest listTopSqlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTopSqlsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/top-sql-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listTopSqlsRequest);
            return new SyncInvoker<ListTopSqlsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTopSqlsResponse>);
        }
        
        /// <summary>
        /// 采集WDR快照报告
        ///
        /// 采集WDR快照报告。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CollectWdrSnapshotResponse CollectWdrSnapshot(CollectWdrSnapshotRequest collectWdrSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(collectWdrSnapshotRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/wdr-snapshots/collect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", collectWdrSnapshotRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CollectWdrSnapshotResponse>(response);
        }

        public SyncInvoker<CollectWdrSnapshotResponse> CollectWdrSnapshotInvoker(CollectWdrSnapshotRequest collectWdrSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(collectWdrSnapshotRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/wdr-snapshots/collect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", collectWdrSnapshotRequest);
            return new SyncInvoker<CollectWdrSnapshotResponse>(this, "POST", request, JsonUtils.DeSerialize<CollectWdrSnapshotResponse>);
        }
        
        /// <summary>
        /// 生成WDR快照
        ///
        /// 生成WDR快照。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateWdrSnapshotResponse CreateWdrSnapshot(CreateWdrSnapshotRequest createWdrSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createWdrSnapshotRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/wdr-snapshots", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWdrSnapshotRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateWdrSnapshotResponse>(response);
        }

        public SyncInvoker<CreateWdrSnapshotResponse> CreateWdrSnapshotInvoker(CreateWdrSnapshotRequest createWdrSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createWdrSnapshotRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/wdr-snapshots", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWdrSnapshotRequest);
            return new SyncInvoker<CreateWdrSnapshotResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateWdrSnapshotResponse>);
        }
        
        /// <summary>
        /// 查询WDR快照开关状态
        ///
        /// 查询WDR快照开关状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowWdrSnapshotStatusResponse ShowWdrSnapshotStatus(ShowWdrSnapshotStatusRequest showWdrSnapshotStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWdrSnapshotStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/wdr-snapshot/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWdrSnapshotStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowWdrSnapshotStatusResponse>(response);
        }

        public SyncInvoker<ShowWdrSnapshotStatusResponse> ShowWdrSnapshotStatusInvoker(ShowWdrSnapshotStatusRequest showWdrSnapshotStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWdrSnapshotStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/wdr-snapshot/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWdrSnapshotStatusRequest);
            return new SyncInvoker<ShowWdrSnapshotStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWdrSnapshotStatusResponse>);
        }
        
        /// <summary>
        /// 打开或关闭WDR快照开关
        ///
        /// 打开或关闭WDR快照开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchWdrSnapshotStatusResponse SwitchWdrSnapshotStatus(SwitchWdrSnapshotStatusRequest switchWdrSnapshotStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchWdrSnapshotStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/wdr-snapshot/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchWdrSnapshotStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SwitchWdrSnapshotStatusResponse>(response);
        }

        public SyncInvoker<SwitchWdrSnapshotStatusResponse> SwitchWdrSnapshotStatusInvoker(SwitchWdrSnapshotStatusRequest switchWdrSnapshotStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchWdrSnapshotStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/wdr-snapshot/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchWdrSnapshotStatusRequest);
            return new SyncInvoker<SwitchWdrSnapshotStatusResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SwitchWdrSnapshotStatusResponse>);
        }
        
    }
}