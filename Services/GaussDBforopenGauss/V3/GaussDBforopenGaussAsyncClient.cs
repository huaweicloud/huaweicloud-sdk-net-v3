using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3
{
    public partial class GaussDBforopenGaussAsyncClient : Client
    {
        public static ClientBuilder<GaussDBforopenGaussAsyncClient> NewBuilder()
        {
            return new ClientBuilder<GaussDBforopenGaussAsyncClient>();
        }

        
        /// <summary>
        /// 添加实例标签。
        ///
        /// 对指定实例添加用户标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddInstanceTagsResponse> AddInstanceTagsAsync(AddInstanceTagsRequest addInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addInstanceTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addInstanceTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddInstanceTagsResponse>(response);
        }

        public AsyncInvoker<AddInstanceTagsResponse> AddInstanceTagsAsyncInvoker(AddInstanceTagsRequest addInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addInstanceTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addInstanceTagsRequest);
            return new AsyncInvoker<AddInstanceTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<AddInstanceTagsResponse>);
        }
        
        /// <summary>
        /// 授权数据库帐号
        ///
        /// 在指定实例的数据库中, 设置帐号的权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AllowDbPrivilegesResponse> AllowDbPrivilegesAsync(AllowDbPrivilegesRequest allowDbPrivilegesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", allowDbPrivilegesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", allowDbPrivilegesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AllowDbPrivilegesResponse>(response);
        }

        public AsyncInvoker<AllowDbPrivilegesResponse> AllowDbPrivilegesAsyncInvoker(AllowDbPrivilegesRequest allowDbPrivilegesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", allowDbPrivilegesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", allowDbPrivilegesRequest);
            return new AsyncInvoker<AllowDbPrivilegesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AllowDbPrivilegesResponse>);
        }
        
        /// <summary>
        /// 授权数据库角色
        ///
        /// 在数据库中设置角色的权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AllowDbRolePrivilegesResponse> AllowDbRolePrivilegesAsync(AllowDbRolePrivilegesRequest allowDbRolePrivilegesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", allowDbRolePrivilegesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", allowDbRolePrivilegesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AllowDbRolePrivilegesResponse>(response);
        }

        public AsyncInvoker<AllowDbRolePrivilegesResponse> AllowDbRolePrivilegesAsyncInvoker(AllowDbRolePrivilegesRequest allowDbRolePrivilegesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", allowDbRolePrivilegesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", allowDbRolePrivilegesRequest);
            return new AsyncInvoker<AllowDbRolePrivilegesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AllowDbRolePrivilegesResponse>);
        }
        
        /// <summary>
        /// 绑定/解绑弹性公网IP
        ///
        /// 实例下的节点绑定弹性公网IP/解绑弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AttachEipResponse> AttachEipAsync(AttachEipRequest attachEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", attachEipRequest.InstanceId.ToString());
            urlParam.Add("node_id", attachEipRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachEipRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AttachEipResponse>(response);
        }

        public AsyncInvoker<AttachEipResponse> AttachEipAsyncInvoker(AttachEipRequest attachEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", attachEipRequest.InstanceId.ToString());
            urlParam.Add("node_id", attachEipRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachEipRequest);
            return new AsyncInvoker<AttachEipResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachEipResponse>);
        }
        
        /// <summary>
        /// 查询批量实例可升级的版本和升级类型。
        ///
        /// 查询批量实例可升级的版本和升级类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchShowUpgradeCandidateVersionsResponse> BatchShowUpgradeCandidateVersionsAsync(BatchShowUpgradeCandidateVersionsRequest batchShowUpgradeCandidateVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/db-upgrade/candidate-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchShowUpgradeCandidateVersionsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchShowUpgradeCandidateVersionsResponse>(response);
        }

        public AsyncInvoker<BatchShowUpgradeCandidateVersionsResponse> BatchShowUpgradeCandidateVersionsAsyncInvoker(BatchShowUpgradeCandidateVersionsRequest batchShowUpgradeCandidateVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/db-upgrade/candidate-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchShowUpgradeCandidateVersionsRequest);
            return new AsyncInvoker<BatchShowUpgradeCandidateVersionsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchShowUpgradeCandidateVersionsResponse>);
        }
        
        /// <summary>
        /// 取消定时任务
        ///
        /// 取消定时任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelScheduleTaskResponse> CancelScheduleTaskAsync(CancelScheduleTaskRequest cancelScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", cancelScheduleTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/schedule-task/{task_id}/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelScheduleTaskRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<CancelScheduleTaskResponse>(response);
        }

        public AsyncInvoker<CancelScheduleTaskResponse> CancelScheduleTaskAsyncInvoker(CancelScheduleTaskRequest cancelScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", cancelScheduleTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/schedule-task/{task_id}/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelScheduleTaskRequest);
            return new AsyncInvoker<CancelScheduleTaskResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<CancelScheduleTaskResponse>);
        }
        
        /// <summary>
        /// 备份恢复到目标实例数据后执行数据确认
        ///
        /// 确认备份恢复到目标实例的数据正常。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ConfirmRestoredDataResponse> ConfirmRestoredDataAsync(ConfirmRestoredDataRequest confirmRestoredDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", confirmRestoredDataRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/confirm-restore-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmRestoredDataRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ConfirmRestoredDataResponse>(response);
        }

        public AsyncInvoker<ConfirmRestoredDataResponse> ConfirmRestoredDataAsyncInvoker(ConfirmRestoredDataRequest confirmRestoredDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", confirmRestoredDataRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/confirm-restore-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmRestoredDataRequest);
            return new AsyncInvoker<ConfirmRestoredDataResponse>(this, "POST", request, JsonUtils.DeSerialize<ConfirmRestoredDataResponse>);
        }
        
        /// <summary>
        /// 复制参数模板
        ///
        /// 复制参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CopyConfigurationResponse> CopyConfigurationAsync(CopyConfigurationRequest copyConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", copyConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyConfigurationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CopyConfigurationResponse>(response);
        }

        public AsyncInvoker<CopyConfigurationResponse> CopyConfigurationAsyncInvoker(CopyConfigurationRequest copyConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", copyConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyConfigurationRequest);
            return new AsyncInvoker<CopyConfigurationResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyConfigurationResponse>);
        }
        
        /// <summary>
        /// 创建参数模板
        ///
        /// 创建参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateConfigurationTemplateResponse> CreateConfigurationTemplateAsync(CreateConfigurationTemplateRequest createConfigurationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createConfigurationTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateConfigurationTemplateResponse>(response);
        }

        public AsyncInvoker<CreateConfigurationTemplateResponse> CreateConfigurationTemplateAsyncInvoker(CreateConfigurationTemplateRequest createConfigurationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createConfigurationTemplateRequest);
            return new AsyncInvoker<CreateConfigurationTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateConfigurationTemplateResponse>);
        }
        
        /// <summary>
        /// 搭建容灾关系
        ///
        /// 搭建容灾关系（从主实例端下发）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCrossCloudConstructDisasterResponse> CreateCrossCloudConstructDisasterAsync(CreateCrossCloudConstructDisasterRequest createCrossCloudConstructDisasterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createCrossCloudConstructDisasterRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/construct", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCrossCloudConstructDisasterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateCrossCloudConstructDisasterResponse>(response);
        }

        public AsyncInvoker<CreateCrossCloudConstructDisasterResponse> CreateCrossCloudConstructDisasterAsyncInvoker(CreateCrossCloudConstructDisasterRequest createCrossCloudConstructDisasterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createCrossCloudConstructDisasterRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/construct", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCrossCloudConstructDisasterRequest);
            return new AsyncInvoker<CreateCrossCloudConstructDisasterResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCrossCloudConstructDisasterResponse>);
        }
        
        /// <summary>
        /// 创建数据库
        ///
        /// 在指定实例中创建数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDatabaseResponse> CreateDatabaseAsync(CreateDatabaseRequest createDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDatabaseResponse>(response);
        }

        public AsyncInvoker<CreateDatabaseResponse> CreateDatabaseAsyncInvoker(CreateDatabaseRequest createDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseRequest);
            return new AsyncInvoker<CreateDatabaseResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDatabaseResponse>);
        }
        
        /// <summary>
        /// 创建数据库实例
        ///
        /// 创建数据库实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDatabaseInstanceResponse> CreateDatabaseInstanceAsync(CreateDatabaseInstanceRequest createDatabaseInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDatabaseInstanceResponse>(response);
        }

        public AsyncInvoker<CreateDatabaseInstanceResponse> CreateDatabaseInstanceAsyncInvoker(CreateDatabaseInstanceRequest createDatabaseInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseInstanceRequest);
            return new AsyncInvoker<CreateDatabaseInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDatabaseInstanceResponse>);
        }
        
        /// <summary>
        /// 创建数据库SCHEMA
        ///
        /// 在指定实例的数据库中, 创建数据库schema。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDatabaseSchemasResponse> CreateDatabaseSchemasAsync(CreateDatabaseSchemasRequest createDatabaseSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDatabaseSchemasRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseSchemasRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDatabaseSchemasResponse>(response);
        }

        public AsyncInvoker<CreateDatabaseSchemasResponse> CreateDatabaseSchemasAsyncInvoker(CreateDatabaseSchemasRequest createDatabaseSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDatabaseSchemasRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseSchemasRequest);
            return new AsyncInvoker<CreateDatabaseSchemasResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDatabaseSchemasResponse>);
        }
        
        /// <summary>
        /// 创建数据库实例
        ///
        /// 创建数据库实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDbInstanceResponse> CreateDbInstanceAsync(CreateDbInstanceRequest createDbInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDbInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDbInstanceResponse>(response);
        }

        public AsyncInvoker<CreateDbInstanceResponse> CreateDbInstanceAsyncInvoker(CreateDbInstanceRequest createDbInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDbInstanceRequest);
            return new AsyncInvoker<CreateDbInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDbInstanceResponse>);
        }
        
        /// <summary>
        /// 创建数据库角色
        ///
        /// 创建数据库角色。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDbRoleResponse> CreateDbRoleAsync(CreateDbRoleRequest createDbRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDbRoleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDbRoleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDbRoleResponse>(response);
        }

        public AsyncInvoker<CreateDbRoleResponse> CreateDbRoleAsyncInvoker(CreateDbRoleRequest createDbRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDbRoleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDbRoleRequest);
            return new AsyncInvoker<CreateDbRoleResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDbRoleResponse>);
        }
        
        /// <summary>
        /// 创建数据库用户
        ///
        /// 在指定实例中创建数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDbUserResponse> CreateDbUserAsync(CreateDbUserRequest createDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDbUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDbUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDbUserResponse>(response);
        }

        public AsyncInvoker<CreateDbUserResponse> CreateDbUserAsyncInvoker(CreateDbUserRequest createDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDbUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDbUserRequest);
            return new AsyncInvoker<CreateDbUserResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDbUserResponse>);
        }
        
        /// <summary>
        /// 创建数据库实例
        ///
        /// 创建数据库实例，仅支持IAM5的新平面认证方式（AK/SK认证方式）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGaussDbInstanceResponse> CreateGaussDbInstanceAsync(CreateGaussDbInstanceRequest createGaussDbInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussDbInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGaussDbInstanceResponse>(response);
        }

        public AsyncInvoker<CreateGaussDbInstanceResponse> CreateGaussDbInstanceAsyncInvoker(CreateGaussDbInstanceRequest createGaussDbInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussDbInstanceRequest);
            return new AsyncInvoker<CreateGaussDbInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGaussDbInstanceResponse>);
        }
        
        /// <summary>
        /// 创建数据库实例
        ///
        /// 创建数据库企业版和集中式实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceResponse>(response);
        }

        public AsyncInvoker<CreateInstanceResponse> CreateInstanceAsyncInvoker(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstanceRequest);
            return new AsyncInvoker<CreateInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createManualBackupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateManualBackupResponse>(response);
        }

        public AsyncInvoker<CreateManualBackupResponse> CreateManualBackupAsyncInvoker(CreateManualBackupRequest createManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createManualBackupRequest);
            return new AsyncInvoker<CreateManualBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateManualBackupResponse>);
        }
        
        /// <summary>
        /// 恢复到新实例
        ///
        /// 根据备份恢复新实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRestoreInstanceResponse> CreateRestoreInstanceAsync(CreateRestoreInstanceRequest createRestoreInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRestoreInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRestoreInstanceResponse>(response);
        }

        public AsyncInvoker<CreateRestoreInstanceResponse> CreateRestoreInstanceAsyncInvoker(CreateRestoreInstanceRequest createRestoreInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRestoreInstanceRequest);
            return new AsyncInvoker<CreateRestoreInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRestoreInstanceResponse>);
        }
        
        /// <summary>
        /// 批量实例内核版本定时升级
        ///
        /// 批量实例内核版本定时升级
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateScheduleTaskResponse> CreateScheduleTaskAsync(CreateScheduleTaskRequest createScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/db-upgrade/schedule-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScheduleTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateScheduleTaskResponse>(response);
        }

        public AsyncInvoker<CreateScheduleTaskResponse> CreateScheduleTaskAsyncInvoker(CreateScheduleTaskRequest createScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/db-upgrade/schedule-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScheduleTaskRequest);
            return new AsyncInvoker<CreateScheduleTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateScheduleTaskResponse>);
        }
        
        /// <summary>
        /// 创建慢日志下载信息
        ///
        /// 创建慢日志下载信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSlowLogDownloadResponse> CreateSlowLogDownloadAsync(CreateSlowLogDownloadRequest createSlowLogDownloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createSlowLogDownloadRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-log/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSlowLogDownloadRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSlowLogDownloadResponse>(response);
        }

        public AsyncInvoker<CreateSlowLogDownloadResponse> CreateSlowLogDownloadAsyncInvoker(CreateSlowLogDownloadRequest createSlowLogDownloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createSlowLogDownloadRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-log/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSlowLogDownloadRequest);
            return new AsyncInvoker<CreateSlowLogDownloadResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSlowLogDownloadResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", deleteConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigurationRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteConfigurationResponse>(response);
        }

        public AsyncInvoker<DeleteConfigurationResponse> DeleteConfigurationAsyncInvoker(DeleteConfigurationRequest deleteConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", deleteConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigurationRequest);
            return new AsyncInvoker<DeleteConfigurationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteConfigurationResponse>);
        }
        
        /// <summary>
        /// 删除数据库
        ///
        /// 删除指定实例的数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDatabaseResponse> DeleteDatabaseAsync(DeleteDatabaseRequest deleteDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDatabaseResponse>(response);
        }

        public AsyncInvoker<DeleteDatabaseResponse> DeleteDatabaseAsyncInvoker(DeleteDatabaseRequest deleteDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseRequest);
            return new AsyncInvoker<DeleteDatabaseResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDatabaseResponse>);
        }
        
        /// <summary>
        /// 删除数据库SCHEMA
        ///
        /// 删除数据库schema。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDatabaseSchemaResponse> DeleteDatabaseSchemaAsync(DeleteDatabaseSchemaRequest deleteDatabaseSchemaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabaseSchemaRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteDatabaseSchemaRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDatabaseSchemaResponse>(response);
        }

        public AsyncInvoker<DeleteDatabaseSchemaResponse> DeleteDatabaseSchemaAsyncInvoker(DeleteDatabaseSchemaRequest deleteDatabaseSchemaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabaseSchemaRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteDatabaseSchemaRequest);
            return new AsyncInvoker<DeleteDatabaseSchemaResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDatabaseSchemaResponse>);
        }
        
        /// <summary>
        /// 删除实例
        ///
        /// 删除数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInstanceResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceResponse> DeleteInstanceAsyncInvoker(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            return new AsyncInvoker<DeleteInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteInstanceResponse>);
        }
        
        /// <summary>
        /// 删除实例标签
        ///
        /// 删除实例标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceTagResponse> DeleteInstanceTagAsync(DeleteInstanceTagRequest deleteInstanceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceTagRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInstanceTagResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceTagResponse> DeleteInstanceTagAsyncInvoker(DeleteInstanceTagRequest deleteInstanceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceTagRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceTagRequest);
            return new AsyncInvoker<DeleteInstanceTagResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteInstanceTagResponse>);
        }
        
        /// <summary>
        /// 删除任务记录
        ///
        /// 删除任务记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest deleteJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJobRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteJobResponse>(response);
        }

        public AsyncInvoker<DeleteJobResponse> DeleteJobAsyncInvoker(DeleteJobRequest deleteJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJobRequest);
            return new AsyncInvoker<DeleteJobResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteJobResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteManualBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteManualBackupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteManualBackupResponse>(response);
        }

        public AsyncInvoker<DeleteManualBackupResponse> DeleteManualBackupAsyncInvoker(DeleteManualBackupRequest deleteManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteManualBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteManualBackupRequest);
            return new AsyncInvoker<DeleteManualBackupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteManualBackupResponse>);
        }
        
        /// <summary>
        /// 删除定时任务信息
        ///
        /// 删除定时任务信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteScheduleTaskResponse> DeleteScheduleTaskAsync(DeleteScheduleTaskRequest deleteScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", deleteScheduleTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/schedule-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScheduleTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteScheduleTaskResponse>(response);
        }

        public AsyncInvoker<DeleteScheduleTaskResponse> DeleteScheduleTaskAsyncInvoker(DeleteScheduleTaskRequest deleteScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", deleteScheduleTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/schedule-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScheduleTaskRequest);
            return new AsyncInvoker<DeleteScheduleTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScheduleTaskResponse>);
        }
        
        /// <summary>
        /// 获取备份下载链接
        ///
        /// 获取备份下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadBackupResponse> DownloadBackupAsync(DownloadBackupRequest downloadBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backup-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadBackupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadBackupResponse>(response);
        }

        public AsyncInvoker<DownloadBackupResponse> DownloadBackupAsyncInvoker(DownloadBackupRequest downloadBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backup-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadBackupRequest);
            return new AsyncInvoker<DownloadBackupResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadBackupResponse>);
        }
        
        /// <summary>
        /// 主实例结束容灾日志保持
        ///
        /// 结束stream流式容灾的日志保持功能，目前只有stream流容灾支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteCrossCloudDisasterDataCacheEndResponse> ExecuteCrossCloudDisasterDataCacheEndAsync(ExecuteCrossCloudDisasterDataCacheEndRequest executeCrossCloudDisasterDataCacheEndRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeCrossCloudDisasterDataCacheEndRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/keep-log-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterDataCacheEndRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteCrossCloudDisasterDataCacheEndResponse>(response);
        }

        public AsyncInvoker<ExecuteCrossCloudDisasterDataCacheEndResponse> ExecuteCrossCloudDisasterDataCacheEndAsyncInvoker(ExecuteCrossCloudDisasterDataCacheEndRequest executeCrossCloudDisasterDataCacheEndRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeCrossCloudDisasterDataCacheEndRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/keep-log-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterDataCacheEndRequest);
            return new AsyncInvoker<ExecuteCrossCloudDisasterDataCacheEndResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteCrossCloudDisasterDataCacheEndResponse>);
        }
        
        /// <summary>
        /// 开始日志保持
        ///
        /// 主实例开始容灾日志保持，目前只有stream流容灾支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteCrossCloudDisasterDataCacheStartResponse> ExecuteCrossCloudDisasterDataCacheStartAsync(ExecuteCrossCloudDisasterDataCacheStartRequest executeCrossCloudDisasterDataCacheStartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeCrossCloudDisasterDataCacheStartRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/keep-log-start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterDataCacheStartRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteCrossCloudDisasterDataCacheStartResponse>(response);
        }

        public AsyncInvoker<ExecuteCrossCloudDisasterDataCacheStartResponse> ExecuteCrossCloudDisasterDataCacheStartAsyncInvoker(ExecuteCrossCloudDisasterDataCacheStartRequest executeCrossCloudDisasterDataCacheStartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeCrossCloudDisasterDataCacheStartRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/keep-log-start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterDataCacheStartRequest);
            return new AsyncInvoker<ExecuteCrossCloudDisasterDataCacheStartResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteCrossCloudDisasterDataCacheStartResponse>);
        }
        
        /// <summary>
        /// 结束容灾演练
        ///
        /// 灾备实例结束容灾演练，目前只有stream流容灾支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteCrossCloudDisasterEndSimulationResponse> ExecuteCrossCloudDisasterEndSimulationAsync(ExecuteCrossCloudDisasterEndSimulationRequest executeCrossCloudDisasterEndSimulationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeCrossCloudDisasterEndSimulationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/simulation-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterEndSimulationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteCrossCloudDisasterEndSimulationResponse>(response);
        }

        public AsyncInvoker<ExecuteCrossCloudDisasterEndSimulationResponse> ExecuteCrossCloudDisasterEndSimulationAsyncInvoker(ExecuteCrossCloudDisasterEndSimulationRequest executeCrossCloudDisasterEndSimulationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeCrossCloudDisasterEndSimulationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/simulation-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterEndSimulationRequest);
            return new AsyncInvoker<ExecuteCrossCloudDisasterEndSimulationResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteCrossCloudDisasterEndSimulationResponse>);
        }
        
        /// <summary>
        /// 备实例容灾升主
        ///
        /// 容灾升主failover（灾备实例端下发）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteCrossCloudDisasterRecoveryFailoverResponse> ExecuteCrossCloudDisasterRecoveryFailoverAsync(ExecuteCrossCloudDisasterRecoveryFailoverRequest executeCrossCloudDisasterRecoveryFailoverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeCrossCloudDisasterRecoveryFailoverRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/failover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterRecoveryFailoverRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteCrossCloudDisasterRecoveryFailoverResponse>(response);
        }

        public AsyncInvoker<ExecuteCrossCloudDisasterRecoveryFailoverResponse> ExecuteCrossCloudDisasterRecoveryFailoverAsyncInvoker(ExecuteCrossCloudDisasterRecoveryFailoverRequest executeCrossCloudDisasterRecoveryFailoverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeCrossCloudDisasterRecoveryFailoverRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/failover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterRecoveryFailoverRequest);
            return new AsyncInvoker<ExecuteCrossCloudDisasterRecoveryFailoverResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteCrossCloudDisasterRecoveryFailoverResponse>);
        }
        
        /// <summary>
        /// 重建容灾关系
        ///
        /// 流容灾备升主选择支持容灾回切，实现容灾关系的重建任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteCrossCloudDisasterRestoreResponse> ExecuteCrossCloudDisasterRestoreAsync(ExecuteCrossCloudDisasterRestoreRequest executeCrossCloudDisasterRestoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeCrossCloudDisasterRestoreRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterRestoreRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteCrossCloudDisasterRestoreResponse>(response);
        }

        public AsyncInvoker<ExecuteCrossCloudDisasterRestoreResponse> ExecuteCrossCloudDisasterRestoreAsyncInvoker(ExecuteCrossCloudDisasterRestoreRequest executeCrossCloudDisasterRestoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeCrossCloudDisasterRestoreRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterRestoreRequest);
            return new AsyncInvoker<ExecuteCrossCloudDisasterRestoreResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteCrossCloudDisasterRestoreResponse>);
        }
        
        /// <summary>
        /// 开始容灾演练
        ///
        /// 开始容灾演练，目前只有stream流容灾支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteCrossCloudDisasterStartSimulationResponse> ExecuteCrossCloudDisasterStartSimulationAsync(ExecuteCrossCloudDisasterStartSimulationRequest executeCrossCloudDisasterStartSimulationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeCrossCloudDisasterStartSimulationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/simulation-start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterStartSimulationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteCrossCloudDisasterStartSimulationResponse>(response);
        }

        public AsyncInvoker<ExecuteCrossCloudDisasterStartSimulationResponse> ExecuteCrossCloudDisasterStartSimulationAsyncInvoker(ExecuteCrossCloudDisasterStartSimulationRequest executeCrossCloudDisasterStartSimulationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeCrossCloudDisasterStartSimulationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/simulation-start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterStartSimulationRequest);
            return new AsyncInvoker<ExecuteCrossCloudDisasterStartSimulationResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteCrossCloudDisasterStartSimulationResponse>);
        }
        
        /// <summary>
        /// 灾备实例主从切换
        ///
        /// 容灾switchover（可在主备任一一端下发）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteCrossCloudDisasterSwitchoverResponse> ExecuteCrossCloudDisasterSwitchoverAsync(ExecuteCrossCloudDisasterSwitchoverRequest executeCrossCloudDisasterSwitchoverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeCrossCloudDisasterSwitchoverRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterSwitchoverRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteCrossCloudDisasterSwitchoverResponse>(response);
        }

        public AsyncInvoker<ExecuteCrossCloudDisasterSwitchoverResponse> ExecuteCrossCloudDisasterSwitchoverAsyncInvoker(ExecuteCrossCloudDisasterSwitchoverRequest executeCrossCloudDisasterSwitchoverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeCrossCloudDisasterSwitchoverRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudDisasterSwitchoverRequest);
            return new AsyncInvoker<ExecuteCrossCloudDisasterSwitchoverResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteCrossCloudDisasterSwitchoverResponse>);
        }
        
        /// <summary>
        /// 解除容灾关系
        ///
        /// 解除容灾（从容灾主集群下发）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteCrossCloudReleaseDisasterResponse> ExecuteCrossCloudReleaseDisasterAsync(ExecuteCrossCloudReleaseDisasterRequest executeCrossCloudReleaseDisasterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeCrossCloudReleaseDisasterRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/release", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudReleaseDisasterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteCrossCloudReleaseDisasterResponse>(response);
        }

        public AsyncInvoker<ExecuteCrossCloudReleaseDisasterResponse> ExecuteCrossCloudReleaseDisasterAsyncInvoker(ExecuteCrossCloudReleaseDisasterRequest executeCrossCloudReleaseDisasterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeCrossCloudReleaseDisasterRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/release", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCrossCloudReleaseDisasterRequest);
            return new AsyncInvoker<ExecuteCrossCloudReleaseDisasterResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteCrossCloudReleaseDisasterResponse>);
        }
        
        /// <summary>
        /// 安装插件
        ///
        /// 安装插件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<InstallKernelPluginResponse> InstallKernelPluginAsync(InstallKernelPluginRequest installKernelPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", installKernelPluginRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kernel-plugin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", installKernelPluginRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<InstallKernelPluginResponse>(response);
        }

        public AsyncInvoker<InstallKernelPluginResponse> InstallKernelPluginAsyncInvoker(InstallKernelPluginRequest installKernelPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", installKernelPluginRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kernel-plugin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", installKernelPluginRequest);
            return new AsyncInvoker<InstallKernelPluginResponse>(this, "POST", request, JsonUtils.DeSerialize<InstallKernelPluginResponse>);
        }
        
        /// <summary>
        /// 查询可应用实例列表
        ///
        /// 查询可应用当前参数组模板的实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApplicableInstancesResponse> ListApplicableInstancesAsync(ListApplicableInstancesRequest listApplicableInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", listApplicableInstancesRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applicable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicableInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApplicableInstancesResponse>(response);
        }

        public AsyncInvoker<ListApplicableInstancesResponse> ListApplicableInstancesAsyncInvoker(ListApplicableInstancesRequest listApplicableInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", listApplicableInstancesRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applicable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicableInstancesRequest);
            return new AsyncInvoker<ListApplicableInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicableInstancesResponse>);
        }
        
        /// <summary>
        /// 查询参数模板的应用记录
        ///
        /// 查询参数模板的应用记录，以实例级别为维度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAppliedHistoriesResponse> ListAppliedHistoriesAsync(ListAppliedHistoriesRequest listAppliedHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", listAppliedHistoriesRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applied-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppliedHistoriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAppliedHistoriesResponse>(response);
        }

        public AsyncInvoker<ListAppliedHistoriesResponse> ListAppliedHistoriesAsyncInvoker(ListAppliedHistoriesRequest listAppliedHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", listAppliedHistoriesRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applied-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppliedHistoriesRequest);
            return new AsyncInvoker<ListAppliedHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppliedHistoriesResponse>);
        }
        
        /// <summary>
        /// 查询实例可变更规格
        ///
        /// 查询实例可变更规格列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAvailableFlavorsResponse> ListAvailableFlavorsAsync(ListAvailableFlavorsRequest listAvailableFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAvailableFlavorsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/available-flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAvailableFlavorsResponse>(response);
        }

        public AsyncInvoker<ListAvailableFlavorsResponse> ListAvailableFlavorsAsyncInvoker(ListAvailableFlavorsRequest listAvailableFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAvailableFlavorsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/available-flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableFlavorsRequest);
            return new AsyncInvoker<ListAvailableFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailableFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询备份列表
        ///
        /// 获取备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBackupsResponse> ListBackupsAsync(ListBackupsRequest listBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBackupsResponse>(response);
        }

        public AsyncInvoker<ListBackupsResponse> ListBackupsAsyncInvoker(ListBackupsRequest listBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupsRequest);
            return new AsyncInvoker<ListBackupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBackupsResponse>);
        }
        
        /// <summary>
        /// 查询备份列表
        ///
        /// 获取备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBackupsDetailsResponse> ListBackupsDetailsAsync(ListBackupsDetailsRequest listBackupsDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupsDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBackupsDetailsResponse>(response);
        }

        public AsyncInvoker<ListBackupsDetailsResponse> ListBackupsDetailsAsyncInvoker(ListBackupsDetailsRequest listBackupsDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupsDetailsRequest);
            return new AsyncInvoker<ListBackupsDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBackupsDetailsResponse>);
        }
        
        /// <summary>
        /// 查询实例已绑定EIP列表
        ///
        /// 查询实例已绑定EIP列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBindedEipsResponse> ListBindedEipsAsync(ListBindedEipsRequest listBindedEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBindedEipsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBindedEipsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBindedEipsResponse>(response);
        }

        public AsyncInvoker<ListBindedEipsResponse> ListBindedEipsAsyncInvoker(ListBindedEipsRequest listBindedEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBindedEipsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBindedEipsRequest);
            return new AsyncInvoker<ListBindedEipsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBindedEipsResponse>);
        }
        
        /// <summary>
        /// 查询协调节点列表
        ///
        /// 查询协调节点列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCnInfosBeforeReduceResponse> ListCnInfosBeforeReduceAsync(ListCnInfosBeforeReduceRequest listCnInfosBeforeReduceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listCnInfosBeforeReduceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/coordinators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCnInfosBeforeReduceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCnInfosBeforeReduceResponse>(response);
        }

        public AsyncInvoker<ListCnInfosBeforeReduceResponse> ListCnInfosBeforeReduceAsyncInvoker(ListCnInfosBeforeReduceRequest listCnInfosBeforeReduceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listCnInfosBeforeReduceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/coordinators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCnInfosBeforeReduceRequest);
            return new AsyncInvoker<ListCnInfosBeforeReduceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCnInfosBeforeReduceResponse>);
        }
        
        /// <summary>
        /// 查询实例的组件列表
        ///
        /// 查询实例的组件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListComponentInfosResponse> ListComponentInfosAsync(ListComponentInfosRequest listComponentInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listComponentInfosRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/components", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listComponentInfosRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListComponentInfosResponse>(response);
        }

        public AsyncInvoker<ListComponentInfosResponse> ListComponentInfosAsyncInvoker(ListComponentInfosRequest listComponentInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listComponentInfosRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/components", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listComponentInfosRequest);
            return new AsyncInvoker<ListComponentInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListComponentInfosResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListConfigurationsResponse>(response);
        }

        public AsyncInvoker<ListConfigurationsResponse> ListConfigurationsAsyncInvoker(ListConfigurationsRequest listConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationsRequest);
            return new AsyncInvoker<ListConfigurationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigurationsResponse>);
        }
        
        /// <summary>
        /// 比较两个参数组模板之间的差异
        ///
        /// 获取两个参数配置模板的差异列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConfigurationsDiffResponse> ListConfigurationsDiffAsync(ListConfigurationsDiffRequest listConfigurationsDiffRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/comparison", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listConfigurationsDiffRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListConfigurationsDiffResponse>(response);
        }

        public AsyncInvoker<ListConfigurationsDiffResponse> ListConfigurationsDiffAsyncInvoker(ListConfigurationsDiffRequest listConfigurationsDiffRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/comparison", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listConfigurationsDiffRequest);
            return new AsyncInvoker<ListConfigurationsDiffResponse>(this, "POST", request, JsonUtils.DeSerialize<ListConfigurationsDiffResponse>);
        }
        
        /// <summary>
        /// 查询数据库实例列表/查询实例详情
        ///
        /// 查询数据库实例列表/查询实例详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDatabaseInstancesResponse> ListDatabaseInstancesAsync(ListDatabaseInstancesRequest listDatabaseInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDatabaseInstancesResponse>(response);
        }

        public AsyncInvoker<ListDatabaseInstancesResponse> ListDatabaseInstancesAsyncInvoker(ListDatabaseInstancesRequest listDatabaseInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseInstancesRequest);
            return new AsyncInvoker<ListDatabaseInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabaseInstancesResponse>);
        }
        
        /// <summary>
        /// 查询数据库角色列表
        ///
        /// 查询数据库角色列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDatabaseRolesResponse> ListDatabaseRolesAsync(ListDatabaseRolesRequest listDatabaseRolesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabaseRolesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseRolesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDatabaseRolesResponse>(response);
        }

        public AsyncInvoker<ListDatabaseRolesResponse> ListDatabaseRolesAsyncInvoker(ListDatabaseRolesRequest listDatabaseRolesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabaseRolesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseRolesRequest);
            return new AsyncInvoker<ListDatabaseRolesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabaseRolesResponse>);
        }
        
        /// <summary>
        /// 查询数据库SCHEMA列表
        ///
        /// 查询指定实例的数据库SCHEMA列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDatabaseSchemasResponse> ListDatabaseSchemasAsync(ListDatabaseSchemasRequest listDatabaseSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabaseSchemasRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schemas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseSchemasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDatabaseSchemasResponse>(response);
        }

        public AsyncInvoker<ListDatabaseSchemasResponse> ListDatabaseSchemasAsyncInvoker(ListDatabaseSchemasRequest listDatabaseSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabaseSchemasRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schemas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseSchemasRequest);
            return new AsyncInvoker<ListDatabaseSchemasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabaseSchemasResponse>);
        }
        
        /// <summary>
        /// 查询数据库列表
        ///
        /// 查询指定实例中的数据库列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDatabasesResponse> ListDatabasesAsync(ListDatabasesRequest listDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabasesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDatabasesResponse>(response);
        }

        public AsyncInvoker<ListDatabasesResponse> ListDatabasesAsyncInvoker(ListDatabasesRequest listDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabasesRequest);
            return new AsyncInvoker<ListDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabasesResponse>);
        }
        
        /// <summary>
        /// 查询数据库引擎的版本
        ///
        /// 查询指定数据库引擎对应的版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDatastoresResponse> ListDatastoresAsync(ListDatastoresRequest listDatastoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastore/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoresRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDatastoresResponse>(response);
        }

        public AsyncInvoker<ListDatastoresResponse> ListDatastoresAsyncInvoker(ListDatastoresRequest listDatastoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastore/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoresRequest);
            return new AsyncInvoker<ListDatastoresResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatastoresResponse>);
        }
        
        /// <summary>
        /// 查询引擎列表
        ///
        /// 查询引擎列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDatastoresDetailsResponse> ListDatastoresDetailsAsync(ListDatastoresDetailsRequest listDatastoresDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/datastores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoresDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDatastoresDetailsResponse>(response);
        }

        public AsyncInvoker<ListDatastoresDetailsResponse> ListDatastoresDetailsAsyncInvoker(ListDatastoresDetailsRequest listDatastoresDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/datastores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoresDetailsRequest);
            return new AsyncInvoker<ListDatastoresDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatastoresDetailsResponse>);
        }
        
        /// <summary>
        /// 查询备份列表
        ///
        /// 获取备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDbBackupsResponse> ListDbBackupsAsync(ListDbBackupsRequest listDbBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbBackupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDbBackupsResponse>(response);
        }

        public AsyncInvoker<ListDbBackupsResponse> ListDbBackupsAsyncInvoker(ListDbBackupsRequest listDbBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbBackupsRequest);
            return new AsyncInvoker<ListDbBackupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDbBackupsResponse>);
        }
        
        /// <summary>
        /// 查询数据库规格
        ///
        /// 查询数据库的规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDbFlavorsResponse> ListDbFlavorsAsync(ListDbFlavorsRequest listDbFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDbFlavorsResponse>(response);
        }

        public AsyncInvoker<ListDbFlavorsResponse> ListDbFlavorsAsyncInvoker(ListDbFlavorsRequest listDbFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbFlavorsRequest);
            return new AsyncInvoker<ListDbFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDbFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询数据库用户列表
        ///
        /// 在指定实例中查询数据库用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDbUsersResponse> ListDbUsersAsync(ListDbUsersRequest listDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDbUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbUsersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDbUsersResponse>(response);
        }

        public AsyncInvoker<ListDbUsersResponse> ListDbUsersAsyncInvoker(ListDbUsersRequest listDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDbUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbUsersRequest);
            return new AsyncInvoker<ListDbUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDbUsersResponse>);
        }
        
        /// <summary>
        /// 查询操作记录
        ///
        /// 查询容灾操作记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDisasterRecoveryRecordResponse> ListDisasterRecoveryRecordAsync(ListDisasterRecoveryRecordRequest listDisasterRecoveryRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDisasterRecoveryRecordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDisasterRecoveryRecordRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDisasterRecoveryRecordResponse>(response);
        }

        public AsyncInvoker<ListDisasterRecoveryRecordResponse> ListDisasterRecoveryRecordAsyncInvoker(ListDisasterRecoveryRecordRequest listDisasterRecoveryRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDisasterRecoveryRecordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDisasterRecoveryRecordRequest);
            return new AsyncInvoker<ListDisasterRecoveryRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDisasterRecoveryRecordResponse>);
        }
        
        /// <summary>
        /// 查询企业项目配额组
        ///
        /// 查询企业项目配额组信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEpsQuotasResponse> ListEpsQuotasAsync(ListEpsQuotasRequest listEpsQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEpsQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEpsQuotasResponse>(response);
        }

        public AsyncInvoker<ListEpsQuotasResponse> ListEpsQuotasAsyncInvoker(ListEpsQuotasRequest listEpsQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEpsQuotasRequest);
            return new AsyncInvoker<ListEpsQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEpsQuotasResponse>);
        }
        
        /// <summary>
        /// 查询实例特性列表
        ///
        /// 查询当前实例高级特性列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFeaturesResponse> ListFeaturesAsync(ListFeaturesRequest listFeaturesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listFeaturesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/advance-features", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFeaturesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFeaturesResponse>(response);
        }

        public AsyncInvoker<ListFeaturesResponse> ListFeaturesAsyncInvoker(ListFeaturesRequest listFeaturesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listFeaturesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/advance-features", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFeaturesRequest);
            return new AsyncInvoker<ListFeaturesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFeaturesResponse>);
        }
        
        /// <summary>
        /// 查询数据库规格
        ///
        /// 查询数据库的规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFlavorsResponse> ListFlavorsAsync(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }

        public AsyncInvoker<ListFlavorsResponse> ListFlavorsAsyncInvoker(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            return new AsyncInvoker<ListFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询数据库规格
        ///
        /// 查询数据库的规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFlavorsDetailsResponse> ListFlavorsDetailsAsync(ListFlavorsDetailsRequest listFlavorsDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorsDetailsResponse>(response);
        }

        public AsyncInvoker<ListFlavorsDetailsResponse> ListFlavorsDetailsAsyncInvoker(ListFlavorsDetailsRequest listFlavorsDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsDetailsRequest);
            return new AsyncInvoker<ListFlavorsDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorsDetailsResponse>);
        }
        
        /// <summary>
        /// 查询引擎列表
        ///
        /// 查询引擎列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGaussDbDatastoresResponse> ListGaussDbDatastoresAsync(ListGaussDbDatastoresRequest listGaussDbDatastoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussDbDatastoresRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGaussDbDatastoresResponse>(response);
        }

        public AsyncInvoker<ListGaussDbDatastoresResponse> ListGaussDbDatastoresAsyncInvoker(ListGaussDbDatastoresRequest listGaussDbDatastoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussDbDatastoresRequest);
            return new AsyncInvoker<ListGaussDbDatastoresResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGaussDbDatastoresResponse>);
        }
        
        /// <summary>
        /// 查询参数模板的修改历史
        ///
        /// 查询参数模板的修改历史记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHistoryOperationsResponse> ListHistoryOperationsAsync(ListHistoryOperationsRequest listHistoryOperationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", listHistoryOperationsRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryOperationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHistoryOperationsResponse>(response);
        }

        public AsyncInvoker<ListHistoryOperationsResponse> ListHistoryOperationsAsyncInvoker(ListHistoryOperationsRequest listHistoryOperationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", listHistoryOperationsRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryOperationsRequest);
            return new AsyncInvoker<ListHistoryOperationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHistoryOperationsResponse>);
        }
        
        /// <summary>
        /// 查询数据库实例列表/查询实例详情
        ///
        /// 查询数据库实例列表/查询实例详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceDetailsResponse> ListInstanceDetailsAsync(ListInstanceDetailsRequest listInstanceDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceDetailsResponse>(response);
        }

        public AsyncInvoker<ListInstanceDetailsResponse> ListInstanceDetailsAsyncInvoker(ListInstanceDetailsRequest listInstanceDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceDetailsRequest);
            return new AsyncInvoker<ListInstanceDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceDetailsResponse>);
        }
        
        /// <summary>
        /// 查看实例引擎版本分布
        ///
        /// 查看实例引擎版本分布
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceEngineDetailResponse> ListInstanceEngineDetailAsync(ListInstanceEngineDetailRequest listInstanceEngineDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastore/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceEngineDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceEngineDetailResponse>(response);
        }

        public AsyncInvoker<ListInstanceEngineDetailResponse> ListInstanceEngineDetailAsyncInvoker(ListInstanceEngineDetailRequest listInstanceEngineDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastore/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceEngineDetailRequest);
            return new AsyncInvoker<ListInstanceEngineDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceEngineDetailResponse>);
        }
        
        /// <summary>
        /// 查询错误日志下载链接
        ///
        /// 查询数据库错误日志下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceErrorLogsResponse> ListInstanceErrorLogsAsync(ListInstanceErrorLogsRequest listInstanceErrorLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceErrorLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceErrorLogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceErrorLogsResponse>(response);
        }

        public AsyncInvoker<ListInstanceErrorLogsResponse> ListInstanceErrorLogsAsyncInvoker(ListInstanceErrorLogsRequest listInstanceErrorLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceErrorLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceErrorLogsRequest);
            return new AsyncInvoker<ListInstanceErrorLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceErrorLogsResponse>);
        }
        
        /// <summary>
        /// 查询实例标签
        ///
        /// 查询指定实例的用户标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceTagsResponse> ListInstanceTagsAsync(ListInstanceTagsRequest listInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceTagsResponse>(response);
        }

        public AsyncInvoker<ListInstanceTagsResponse> ListInstanceTagsAsyncInvoker(ListInstanceTagsRequest listInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTagsRequest);
            return new AsyncInvoker<ListInstanceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceTagsResponse>);
        }
        
        /// <summary>
        /// 查询数据库实例列表/查询实例详情
        ///
        /// 查询数据库实例列表/查询实例详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesResponse>(response);
        }

        public AsyncInvoker<ListInstancesResponse> ListInstancesAsyncInvoker(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            return new AsyncInvoker<ListInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesResponse>);
        }
        
        /// <summary>
        /// 查询数据库实例列表/查询实例详情
        ///
        /// 查询数据库实例列表/查询实例详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesDetailsResponse> ListInstancesDetailsAsync(ListInstancesDetailsRequest listInstancesDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesDetailsResponse>(response);
        }

        public AsyncInvoker<ListInstancesDetailsResponse> ListInstancesDetailsAsyncInvoker(ListInstancesDetailsRequest listInstancesDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesDetailsRequest);
            return new AsyncInvoker<ListInstancesDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesDetailsResponse>);
        }
        
        /// <summary>
        /// 查询实例已安装的插件列表
        ///
        /// 查询实例已安装的插件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListKernelPluginsResponse> ListKernelPluginsAsync(ListKernelPluginsRequest listKernelPluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listKernelPluginsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kernel-plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKernelPluginsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listKernelPluginsResponse = JsonUtils.DeSerializeNull<ListKernelPluginsResponse>(response);
            listKernelPluginsResponse.Body = JsonUtils.DeSerializeList<string>(response);
            return listKernelPluginsResponse;
        }

        public AsyncInvoker<ListKernelPluginsResponse> ListKernelPluginsAsyncInvoker(ListKernelPluginsRequest listKernelPluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listKernelPluginsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kernel-plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKernelPluginsRequest);
            return new AsyncInvoker<ListKernelPluginsResponse>(this, "GET", request, response =>
            {
                var listKernelPluginsResponse = JsonUtils.DeSerializeNull<ListKernelPluginsResponse>(response);
                listKernelPluginsResponse.Body = JsonUtils.DeSerializeList<string>(response);
                return listKernelPluginsResponse;
            });
        }
        
        /// <summary>
        /// 获取参数模板列表
        ///
        /// 获取参数模板列表，包括所有数据库的默认参数模板和用户创建的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListParamGroupTemplatesResponse> ListParamGroupTemplatesAsync(ListParamGroupTemplatesRequest listParamGroupTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listParamGroupTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListParamGroupTemplatesResponse>(response);
        }

        public AsyncInvoker<ListParamGroupTemplatesResponse> ListParamGroupTemplatesAsyncInvoker(ListParamGroupTemplatesRequest listParamGroupTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listParamGroupTemplatesRequest);
            return new AsyncInvoker<ListParamGroupTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListParamGroupTemplatesResponse>);
        }
        
        /// <summary>
        /// 获取参数模板列表
        ///
        /// 获取参数模板列表，包括所有数据库的默认参数模板和用户创建的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListParameterGroupTemplatesResponse> ListParameterGroupTemplatesAsync(ListParameterGroupTemplatesRequest listParameterGroupTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listParameterGroupTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListParameterGroupTemplatesResponse>(response);
        }

        public AsyncInvoker<ListParameterGroupTemplatesResponse> ListParameterGroupTemplatesAsyncInvoker(ListParameterGroupTemplatesRequest listParameterGroupTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listParameterGroupTemplatesRequest);
            return new AsyncInvoker<ListParameterGroupTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListParameterGroupTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询实例插件拓展信息
        ///
        /// 查询实例插件拓展信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPluginExtensionsResponse> ListPluginExtensionsAsync(ListPluginExtensionsRequest listPluginExtensionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPluginExtensionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/plugin-extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPluginExtensionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listPluginExtensionsResponse = JsonUtils.DeSerializeNull<ListPluginExtensionsResponse>(response);
            listPluginExtensionsResponse.Body = JsonUtils.DeSerializeList<PluginExtensions>(response);
            return listPluginExtensionsResponse;
        }

        public AsyncInvoker<ListPluginExtensionsResponse> ListPluginExtensionsAsyncInvoker(ListPluginExtensionsRequest listPluginExtensionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPluginExtensionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/plugin-extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPluginExtensionsRequest);
            return new AsyncInvoker<ListPluginExtensionsResponse>(this, "GET", request, response =>
            {
                var listPluginExtensionsResponse = JsonUtils.DeSerializeNull<ListPluginExtensionsResponse>(response);
                listPluginExtensionsResponse.Body = JsonUtils.DeSerializeList<PluginExtensions>(response);
                return listPluginExtensionsResponse;
            });
        }
        
        /// <summary>
        /// 查询预定义标签
        ///
        /// 查询预预定义标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPredefinedTagsResponse> ListPredefinedTagsAsync(ListPredefinedTagsRequest listPredefinedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/predefined-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPredefinedTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPredefinedTagsResponse>(response);
        }

        public AsyncInvoker<ListPredefinedTagsResponse> ListPredefinedTagsAsyncInvoker(ListPredefinedTagsRequest listPredefinedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/predefined-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPredefinedTagsRequest);
            return new AsyncInvoker<ListPredefinedTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPredefinedTagsResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询项目下所有用户标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectTagsResponse> ListProjectTagsAsync(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProjectTagsResponse>(response);
        }

        public AsyncInvoker<ListProjectTagsResponse> ListProjectTagsAsyncInvoker(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            return new AsyncInvoker<ListProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectTagsResponse>);
        }
        
        /// <summary>
        /// 查询回收站所有引擎实例列表。
        ///
        /// 查询回收站所有引擎实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecycleInstancesResponse> ListRecycleInstancesAsync(ListRecycleInstancesRequest listRecycleInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/recycle-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecycleInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRecycleInstancesResponse>(response);
        }

        public AsyncInvoker<ListRecycleInstancesResponse> ListRecycleInstancesAsyncInvoker(ListRecycleInstancesRequest listRecycleInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/recycle-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecycleInstancesRequest);
            return new AsyncInvoker<ListRecycleInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecycleInstancesResponse>);
        }
        
        /// <summary>
        /// 查询回收站所有引擎实例列表。
        ///
        /// 查询回收站所有引擎实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecycleInstancesDetailsResponse> ListRecycleInstancesDetailsAsync(ListRecycleInstancesDetailsRequest listRecycleInstancesDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/recycle-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecycleInstancesDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRecycleInstancesDetailsResponse>(response);
        }

        public AsyncInvoker<ListRecycleInstancesDetailsResponse> ListRecycleInstancesDetailsAsyncInvoker(ListRecycleInstancesDetailsRequest listRecycleInstancesDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/recycle-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecycleInstancesDetailsRequest);
            return new AsyncInvoker<ListRecycleInstancesDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecycleInstancesDetailsResponse>);
        }
        
        /// <summary>
        /// 查询可用于备份恢复的实例列表
        ///
        /// 查询可用于备份恢复的实例列表，实例信息要符合备份条件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRestorableInstancesResponse> ListRestorableInstancesAsync(ListRestorableInstancesRequest listRestorableInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/restorable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestorableInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRestorableInstancesResponse>(response);
        }

        public AsyncInvoker<ListRestorableInstancesResponse> ListRestorableInstancesAsyncInvoker(ListRestorableInstancesRequest listRestorableInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/restorable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestorableInstancesRequest);
            return new AsyncInvoker<ListRestorableInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestorableInstancesResponse>);
        }
        
        /// <summary>
        /// 查询可用于备份恢复的实例列表
        ///
        /// 查询可用于备份恢复的实例列表，实例信息要符合备份条件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRestorableInstancesDetailsResponse> ListRestorableInstancesDetailsAsync(ListRestorableInstancesDetailsRequest listRestorableInstancesDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/restorable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestorableInstancesDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRestorableInstancesDetailsResponse>(response);
        }

        public AsyncInvoker<ListRestorableInstancesDetailsResponse> ListRestorableInstancesDetailsAsyncInvoker(ListRestorableInstancesDetailsRequest listRestorableInstancesDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/restorable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestorableInstancesDetailsRequest);
            return new AsyncInvoker<ListRestorableInstancesDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestorableInstancesDetailsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreTimesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTimesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRestoreTimesResponse>(response);
        }

        public AsyncInvoker<ListRestoreTimesResponse> ListRestoreTimesAsyncInvoker(ListRestoreTimesRequest listRestoreTimesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreTimesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTimesRequest);
            return new AsyncInvoker<ListRestoreTimesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestoreTimesResponse>);
        }
        
        /// <summary>
        /// 查看定时任务列表
        ///
        /// 查看定时任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScheduleTaskResponse> ListScheduleTaskAsync(ListScheduleTaskRequest listScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/schedule-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduleTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListScheduleTaskResponse>(response);
        }

        public AsyncInvoker<ListScheduleTaskResponse> ListScheduleTaskAsyncInvoker(ListScheduleTaskRequest listScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/schedule-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduleTaskRequest);
            return new AsyncInvoker<ListScheduleTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScheduleTaskResponse>);
        }
        
        /// <summary>
        /// 查询数据库磁盘类型
        ///
        /// 查询指定数据库引擎对应的磁盘类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStorageTypesResponse> ListStorageTypesAsync(ListStorageTypesRequest listStorageTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/storage-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageTypesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStorageTypesResponse>(response);
        }

        public AsyncInvoker<ListStorageTypesResponse> ListStorageTypesAsyncInvoker(ListStorageTypesRequest listStorageTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/storage-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageTypesRequest);
            return new AsyncInvoker<ListStorageTypesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStorageTypesResponse>);
        }
        
        /// <summary>
        /// 查询支持的插件列表
        ///
        /// 查询支持的插件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSupportKernelPluginsResponse> ListSupportKernelPluginsAsync(ListSupportKernelPluginsRequest listSupportKernelPluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/kernel-plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportKernelPluginsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listSupportKernelPluginsResponse = JsonUtils.DeSerializeNull<ListSupportKernelPluginsResponse>(response);
            listSupportKernelPluginsResponse.Body = JsonUtils.DeSerializeList<string>(response);
            return listSupportKernelPluginsResponse;
        }

        public AsyncInvoker<ListSupportKernelPluginsResponse> ListSupportKernelPluginsAsyncInvoker(ListSupportKernelPluginsRequest listSupportKernelPluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/kernel-plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportKernelPluginsRequest);
            return new AsyncInvoker<ListSupportKernelPluginsResponse>(this, "GET", request, response =>
            {
                var listSupportKernelPluginsResponse = JsonUtils.DeSerializeNull<ListSupportKernelPluginsResponse>(response);
                listSupportKernelPluginsResponse.Body = JsonUtils.DeSerializeList<string>(response);
                return listSupportKernelPluginsResponse;
            });
        }
        
        /// <summary>
        /// 查询任务列表
        ///
        /// 获取任务中心的任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTasksResponse> ListTasksAsync(ListTasksRequest listTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTasksResponse>(response);
        }

        public AsyncInvoker<ListTasksResponse> ListTasksAsyncInvoker(ListTasksRequest listTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTasksRequest);
            return new AsyncInvoker<ListTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTasksResponse>);
        }
        
        /// <summary>
        /// 修改企业项目配额
        ///
        /// 修改企业项目配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyEpsQuotaResponse> ModifyEpsQuotaAsync(ModifyEpsQuotaRequest modifyEpsQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyEpsQuotaRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<ModifyEpsQuotaResponse>(response);
        }

        public AsyncInvoker<ModifyEpsQuotaResponse> ModifyEpsQuotaAsyncInvoker(ModifyEpsQuotaRequest modifyEpsQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyEpsQuotaRequest);
            return new AsyncInvoker<ModifyEpsQuotaResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ModifyEpsQuotaResponse>);
        }
        
        /// <summary>
        /// 重置参数模板
        ///
        /// 重置参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetConfigurationResponse> ResetConfigurationAsync(ResetConfigurationRequest resetConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", resetConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetConfigurationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ResetConfigurationResponse>(response);
        }

        public AsyncInvoker<ResetConfigurationResponse> ResetConfigurationAsyncInvoker(ResetConfigurationRequest resetConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", resetConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetConfigurationRequest);
            return new AsyncInvoker<ResetConfigurationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetConfigurationResponse>);
        }
        
        /// <summary>
        /// 重置容灾配置
        ///
        /// 重置容灾网络等配置。1.将自动“创建委托”以授权DBS云服务访问VPC资源信息、查询IAAS接口。2.重置实例容灾网络等配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetDrConfigResponse> ResetDrConfigAsync(ResetDrConfigRequest resetDrConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetDrConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/reset-dr-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetDrConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ResetDrConfigResponse>(response);
        }

        public AsyncInvoker<ResetDrConfigResponse> ResetDrConfigAsyncInvoker(ResetDrConfigRequest resetDrConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetDrConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/reset-dr-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetDrConfigRequest);
            return new AsyncInvoker<ResetDrConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetDrConfigResponse>);
        }
        
        /// <summary>
        /// 重置数据库密码。
        ///
        /// 重置数据库密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetPwdResponse> ResetPwdAsync(ResetPwdRequest resetPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetPwdRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetPwdRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ResetPwdResponse>(response);
        }

        public AsyncInvoker<ResetPwdResponse> ResetPwdAsyncInvoker(ResetPwdRequest resetPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetPwdRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetPwdRequest);
            return new AsyncInvoker<ResetPwdResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetPwdResponse>);
        }
        
        /// <summary>
        /// GaussDB数据库实例规格变更
        ///
        /// GaussDB数据库实例规格变更
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResizeInstanceFlavorResponse> ResizeInstanceFlavorAsync(ResizeInstanceFlavorRequest resizeInstanceFlavorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceFlavorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/flavor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeInstanceFlavorRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ResizeInstanceFlavorResponse>(response);
        }

        public AsyncInvoker<ResizeInstanceFlavorResponse> ResizeInstanceFlavorAsyncInvoker(ResizeInstanceFlavorRequest resizeInstanceFlavorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceFlavorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/flavor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeInstanceFlavorRequest);
            return new AsyncInvoker<ResizeInstanceFlavorResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResizeInstanceFlavorResponse>);
        }
        
        /// <summary>
        /// 重启数据库实例
        ///
        /// 重启数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestartInstanceResponse> RestartInstanceAsync(RestartInstanceRequest restartInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RestartInstanceResponse>(response);
        }

        public AsyncInvoker<RestartInstanceResponse> RestartInstanceAsyncInvoker(RestartInstanceRequest restartInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartInstanceRequest);
            return new AsyncInvoker<RestartInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestartInstanceResponse>);
        }
        
        /// <summary>
        /// 备份恢复到当前实例
        ///
        /// 备份恢复到当前实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestoreInstanceResponse> RestoreInstanceAsync(RestoreInstanceRequest restoreInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RestoreInstanceResponse>(response);
        }

        public AsyncInvoker<RestoreInstanceResponse> RestoreInstanceAsyncInvoker(RestoreInstanceRequest restoreInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreInstanceRequest);
            return new AsyncInvoker<RestoreInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreInstanceResponse>);
        }
        
        /// <summary>
        /// 配置插件拓展能力
        ///
        /// 配置插件拓展能力
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResumePluginExtensionsResponse> ResumePluginExtensionsAsync(ResumePluginExtensionsRequest resumePluginExtensionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resumePluginExtensionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/config-plugin-extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resumePluginExtensionsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ResumePluginExtensionsResponse>(response);
        }

        public AsyncInvoker<ResumePluginExtensionsResponse> ResumePluginExtensionsAsyncInvoker(ResumePluginExtensionsRequest resumePluginExtensionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resumePluginExtensionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/config-plugin-extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resumePluginExtensionsRequest);
            return new AsyncInvoker<ResumePluginExtensionsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResumePluginExtensionsResponse>);
        }
        
        /// <summary>
        /// CN横向扩容/DN分片扩容/磁盘扩容
        ///
        /// CN横向扩容/DN分片扩容/磁盘扩容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunInstanceActionResponse> RunInstanceActionAsync(RunInstanceActionRequest runInstanceActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", runInstanceActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runInstanceActionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RunInstanceActionResponse>(response);
        }

        public AsyncInvoker<RunInstanceActionResponse> RunInstanceActionAsyncInvoker(RunInstanceActionRequest runInstanceActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", runInstanceActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runInstanceActionRequest);
            return new AsyncInvoker<RunInstanceActionResponse>(this, "POST", request, JsonUtils.DeSerialize<RunInstanceActionResponse>);
        }
        
        /// <summary>
        /// 查询磁盘自动扩容策略
        ///
        /// 查询磁盘自动扩容策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchAutoEnlargePolicyResponse> SearchAutoEnlargePolicyAsync(SearchAutoEnlargePolicyRequest searchAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", searchAutoEnlargePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auto-enlarge-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchAutoEnlargePolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchAutoEnlargePolicyResponse>(response);
        }

        public AsyncInvoker<SearchAutoEnlargePolicyResponse> SearchAutoEnlargePolicyAsyncInvoker(SearchAutoEnlargePolicyRequest searchAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", searchAutoEnlargePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auto-enlarge-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchAutoEnlargePolicyRequest);
            return new AsyncInvoker<SearchAutoEnlargePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchAutoEnlargePolicyResponse>);
        }
        
        /// <summary>
        /// 设置自动备份策略。
        ///
        /// 设置自动备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetBackupPolicyResponse> SetBackupPolicyAsync(SetBackupPolicyRequest setBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setBackupPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetBackupPolicyResponse>(response);
        }

        public AsyncInvoker<SetBackupPolicyResponse> SetBackupPolicyAsyncInvoker(SetBackupPolicyRequest setBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setBackupPolicyRequest);
            return new AsyncInvoker<SetBackupPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetBackupPolicyResponse>);
        }
        
        /// <summary>
        /// 重置数据库帐号密码
        ///
        /// 重置指定数据库帐号的密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetDbUserPwdResponse> SetDbUserPwdAsync(SetDbUserPwdRequest setDbUserPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setDbUserPwdRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setDbUserPwdRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetDbUserPwdResponse>(response);
        }

        public AsyncInvoker<SetDbUserPwdResponse> SetDbUserPwdAsyncInvoker(SetDbUserPwdRequest setDbUserPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setDbUserPwdRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setDbUserPwdRequest);
            return new AsyncInvoker<SetDbUserPwdResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetDbUserPwdResponse>);
        }
        
        /// <summary>
        /// 配置插件license
        ///
        /// 配置插件license
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetKernelPluginLicenseResponse> SetKernelPluginLicenseAsync(SetKernelPluginLicenseRequest setKernelPluginLicenseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setKernelPluginLicenseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kernel-plugin-license", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setKernelPluginLicenseRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetKernelPluginLicenseResponse>(response);
        }

        public AsyncInvoker<SetKernelPluginLicenseResponse> SetKernelPluginLicenseAsyncInvoker(SetKernelPluginLicenseRequest setKernelPluginLicenseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setKernelPluginLicenseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/kernel-plugin-license", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setKernelPluginLicenseRequest);
            return new AsyncInvoker<SetKernelPluginLicenseResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetKernelPluginLicenseResponse>);
        }
        
        /// <summary>
        /// 设置自动备份策略
        ///
        /// 设置自动备份策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetNewBackupPolicyResponse> SetNewBackupPolicyAsync(SetNewBackupPolicyRequest setNewBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setNewBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setNewBackupPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetNewBackupPolicyResponse>(response);
        }

        public AsyncInvoker<SetNewBackupPolicyResponse> SetNewBackupPolicyAsyncInvoker(SetNewBackupPolicyRequest setNewBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setNewBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setNewBackupPolicyRequest);
            return new AsyncInvoker<SetNewBackupPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetNewBackupPolicyResponse>);
        }
        
        /// <summary>
        /// 设置回收站策略
        ///
        /// 设置回收站策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetRecyclePolicyResponse> SetRecyclePolicyAsync(SetRecyclePolicyRequest setRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setRecyclePolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SetRecyclePolicyResponse>(response);
        }

        public AsyncInvoker<SetRecyclePolicyResponse> SetRecyclePolicyAsyncInvoker(SetRecyclePolicyRequest setRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setRecyclePolicyRequest);
            return new AsyncInvoker<SetRecyclePolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetRecyclePolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBackupPolicyResponse>(response);
        }

        public AsyncInvoker<ShowBackupPolicyResponse> ShowBackupPolicyAsyncInvoker(ShowBackupPolicyRequest showBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupPolicyRequest);
            return new AsyncInvoker<ShowBackupPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackupPolicyResponse>);
        }
        
        /// <summary>
        /// 查询实例主备平衡状态
        ///
        /// 查询实例是否发生过主备切换而导致主机负载不均衡。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBalanceStatusResponse> ShowBalanceStatusAsync(ShowBalanceStatusRequest showBalanceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBalanceStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBalanceStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBalanceStatusResponse>(response);
        }

        public AsyncInvoker<ShowBalanceStatusResponse> ShowBalanceStatusAsyncInvoker(ShowBalanceStatusRequest showBalanceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBalanceStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/balance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBalanceStatusRequest);
            return new AsyncInvoker<ShowBalanceStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBalanceStatusResponse>);
        }
        
        /// <summary>
        /// 查询批量实例可升级的版本和升级类型。
        ///
        /// 查询批量实例可升级的版本和升级类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBatchUpgradeCandidateVersionsResponse> ShowBatchUpgradeCandidateVersionsAsync(ShowBatchUpgradeCandidateVersionsRequest showBatchUpgradeCandidateVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/db-upgrade/candidate-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showBatchUpgradeCandidateVersionsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowBatchUpgradeCandidateVersionsResponse>(response);
        }

        public AsyncInvoker<ShowBatchUpgradeCandidateVersionsResponse> ShowBatchUpgradeCandidateVersionsAsyncInvoker(ShowBatchUpgradeCandidateVersionsRequest showBatchUpgradeCandidateVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/db-upgrade/candidate-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showBatchUpgradeCandidateVersionsRequest);
            return new AsyncInvoker<ShowBatchUpgradeCandidateVersionsResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowBatchUpgradeCandidateVersionsResponse>);
        }
        
        /// <summary>
        /// 查询参数模板详情
        ///
        /// 根据参数模板ID获取指定参数模板详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowConfigurationDetailResponse> ShowConfigurationDetailAsync(ShowConfigurationDetailRequest showConfigurationDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showConfigurationDetailRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigurationDetailResponse>(response);
        }

        public AsyncInvoker<ShowConfigurationDetailResponse> ShowConfigurationDetailAsyncInvoker(ShowConfigurationDetailRequest showConfigurationDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showConfigurationDetailRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationDetailRequest);
            return new AsyncInvoker<ShowConfigurationDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigurationDetailResponse>);
        }
        
        /// <summary>
        /// 查询实例容灾监控实时状态
        ///
        /// 查询实例容灾监控实时状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCrossCloudDisasterInstanceMonitorResponse> ShowCrossCloudDisasterInstanceMonitorAsync(ShowCrossCloudDisasterInstanceMonitorRequest showCrossCloudDisasterInstanceMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showCrossCloudDisasterInstanceMonitorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/monitor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCrossCloudDisasterInstanceMonitorRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCrossCloudDisasterInstanceMonitorResponse>(response);
        }

        public AsyncInvoker<ShowCrossCloudDisasterInstanceMonitorResponse> ShowCrossCloudDisasterInstanceMonitorAsyncInvoker(ShowCrossCloudDisasterInstanceMonitorRequest showCrossCloudDisasterInstanceMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showCrossCloudDisasterInstanceMonitorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/instances/{instance_id}/disaster-recovery/monitor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCrossCloudDisasterInstanceMonitorRequest);
            return new AsyncInvoker<ShowCrossCloudDisasterInstanceMonitorResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCrossCloudDisasterInstanceMonitorResponse>);
        }
        
        /// <summary>
        /// 查询容灾关系列表
        ///
        /// 查询容灾关系列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCrossCloudDisasterRelationsResponse> ShowCrossCloudDisasterRelationsAsync(ShowCrossCloudDisasterRelationsRequest showCrossCloudDisasterRelationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/disaster-recovery/relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCrossCloudDisasterRelationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCrossCloudDisasterRelationsResponse>(response);
        }

        public AsyncInvoker<ShowCrossCloudDisasterRelationsResponse> ShowCrossCloudDisasterRelationsAsyncInvoker(ShowCrossCloudDisasterRelationsRequest showCrossCloudDisasterRelationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.5/{project_id}/disaster-recovery/relations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCrossCloudDisasterRelationsRequest);
            return new AsyncInvoker<ShowCrossCloudDisasterRelationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCrossCloudDisasterRelationsResponse>);
        }
        
        /// <summary>
        /// 查询解决方案模板配置
        ///
        /// 根据解决方案模板名称或实例ID查询副本数、分片数、节点数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDeploymentFormResponse> ShowDeploymentFormAsync(ShowDeploymentFormRequest showDeploymentFormRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/deployment-form", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeploymentFormRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDeploymentFormResponse>(response);
        }

        public AsyncInvoker<ShowDeploymentFormResponse> ShowDeploymentFormAsyncInvoker(ShowDeploymentFormRequest showDeploymentFormRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/deployment-form", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeploymentFormRequest);
            return new AsyncInvoker<ShowDeploymentFormResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeploymentFormResponse>);
        }
        
        /// <summary>
        /// 查询错误日志采集开关状态
        ///
        /// 查询数据库错误日志采集的开关状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowErrorLogSwitchStatusResponse> ShowErrorLogSwitchStatusAsync(ShowErrorLogSwitchStatusRequest showErrorLogSwitchStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showErrorLogSwitchStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-log/switch/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showErrorLogSwitchStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowErrorLogSwitchStatusResponse>(response);
        }

        public AsyncInvoker<ShowErrorLogSwitchStatusResponse> ShowErrorLogSwitchStatusAsyncInvoker(ShowErrorLogSwitchStatusRequest showErrorLogSwitchStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showErrorLogSwitchStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-log/switch/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showErrorLogSwitchStatusRequest);
            return new AsyncInvoker<ShowErrorLogSwitchStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowErrorLogSwitchStatusResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigurationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceConfigurationResponse>(response);
        }

        public AsyncInvoker<ShowInstanceConfigurationResponse> ShowInstanceConfigurationAsyncInvoker(ShowInstanceConfigurationRequest showInstanceConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigurationRequest);
            return new AsyncInvoker<ShowInstanceConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceConfigurationResponse>);
        }
        
        /// <summary>
        /// 查询实例存储空间使用信息
        ///
        /// 查询指定实例的存储使用空间和最大空间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceDiskResponse> ShowInstanceDiskAsync(ShowInstanceDiskRequest showInstanceDiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceDiskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/volume-usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceDiskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceDiskResponse>(response);
        }

        public AsyncInvoker<ShowInstanceDiskResponse> ShowInstanceDiskAsyncInvoker(ShowInstanceDiskRequest showInstanceDiskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceDiskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/volume-usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceDiskRequest);
            return new AsyncInvoker<ShowInstanceDiskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceDiskResponse>);
        }
        
        /// <summary>
        /// 获取指定实例的参数模板
        ///
        /// 获取指定实例的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceParamGroupResponse> ShowInstanceParamGroupAsync(ShowInstanceParamGroupRequest showInstanceParamGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceParamGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceParamGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceParamGroupResponse>(response);
        }

        public AsyncInvoker<ShowInstanceParamGroupResponse> ShowInstanceParamGroupAsyncInvoker(ShowInstanceParamGroupRequest showInstanceParamGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceParamGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceParamGroupRequest);
            return new AsyncInvoker<ShowInstanceParamGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceParamGroupResponse>);
        }
        
        /// <summary>
        /// 获取指定实例的参数模板
        ///
        /// 获取指定实例的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceParamGroupDetailResponse> ShowInstanceParamGroupDetailAsync(ShowInstanceParamGroupDetailRequest showInstanceParamGroupDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceParamGroupDetailRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceParamGroupDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceParamGroupDetailResponse>(response);
        }

        public AsyncInvoker<ShowInstanceParamGroupDetailResponse> ShowInstanceParamGroupDetailAsyncInvoker(ShowInstanceParamGroupDetailRequest showInstanceParamGroupDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceParamGroupDetailRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.2/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceParamGroupDetailRequest);
            return new AsyncInvoker<ShowInstanceParamGroupDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceParamGroupDetailResponse>);
        }
        
        /// <summary>
        /// 根据时间点或者备份文件查询原实例信息
        ///
        /// 根据时间点或者备份文件查询原实例信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceSnapshotResponse> ShowInstanceSnapshotAsync(ShowInstanceSnapshotRequest showInstanceSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance-snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceSnapshotRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceSnapshotResponse>(response);
        }

        public AsyncInvoker<ShowInstanceSnapshotResponse> ShowInstanceSnapshotAsyncInvoker(ShowInstanceSnapshotRequest showInstanceSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance-snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceSnapshotRequest);
            return new AsyncInvoker<ShowInstanceSnapshotResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceSnapshotResponse>);
        }
        
        /// <summary>
        /// 获取指定ID的任务信息。
        ///
        /// 获取指定ID的任务信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobDetailResponse> ShowJobDetailAsync(ShowJobDetailRequest showJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobDetailResponse>(response);
        }

        public AsyncInvoker<ShowJobDetailResponse> ShowJobDetailAsyncInvoker(ShowJobDetailRequest showJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            return new AsyncInvoker<ShowJobDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobDetailResponse>);
        }
        
        /// <summary>
        /// 查询参数模板详情
        ///
        /// 根据参数模板ID获取指定参数模板详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowParameterGroupDetailResponse> ShowParameterGroupDetailAsync(ShowParameterGroupDetailRequest showParameterGroupDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showParameterGroupDetailRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showParameterGroupDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowParameterGroupDetailResponse>(response);
        }

        public AsyncInvoker<ShowParameterGroupDetailResponse> ShowParameterGroupDetailAsyncInvoker(ShowParameterGroupDetailRequest showParameterGroupDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showParameterGroupDetailRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showParameterGroupDetailRequest);
            return new AsyncInvoker<ShowParameterGroupDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowParameterGroupDetailResponse>);
        }
        
        /// <summary>
        /// 查询租户的实例配额
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectQuotasResponse> ShowProjectQuotasAsync(ShowProjectQuotasRequest showProjectQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/project-quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectQuotasResponse>(response);
        }

        public AsyncInvoker<ShowProjectQuotasResponse> ShowProjectQuotasAsyncInvoker(ShowProjectQuotasRequest showProjectQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/project-quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectQuotasRequest);
            return new AsyncInvoker<ShowProjectQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectQuotasResponse>);
        }
        
        /// <summary>
        /// 查看回收站策略
        ///
        /// 查看回收站的回收策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecyclePolicyResponse> ShowRecyclePolicyAsync(ShowRecyclePolicyRequest showRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecyclePolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRecyclePolicyResponse>(response);
        }

        public AsyncInvoker<ShowRecyclePolicyResponse> ShowRecyclePolicyAsyncInvoker(ShowRecyclePolicyRequest showRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecyclePolicyRequest);
            return new AsyncInvoker<ShowRecyclePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecyclePolicyResponse>);
        }
        
        /// <summary>
        /// 查询慢日志下载信息
        ///
        /// 查询慢日志下载信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSlowLogDownloadResponse> ShowSlowLogDownloadAsync(ShowSlowLogDownloadRequest showSlowLogDownloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSlowLogDownloadRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-log/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSlowLogDownloadRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSlowLogDownloadResponse>(response);
        }

        public AsyncInvoker<ShowSlowLogDownloadResponse> ShowSlowLogDownloadAsyncInvoker(ShowSlowLogDownloadRequest showSlowLogDownloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSlowLogDownloadRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-log/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSlowLogDownloadRequest);
            return new AsyncInvoker<ShowSlowLogDownloadResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSlowLogDownloadResponse>);
        }
        
        /// <summary>
        /// 根据时间点或者备份文件查询原实例信息
        ///
        /// 根据时间点或者备份文件查询原实例信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSourceInstanceDetailResponse> ShowSourceInstanceDetailAsync(ShowSourceInstanceDetailRequest showSourceInstanceDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instance-snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSourceInstanceDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSourceInstanceDetailResponse>(response);
        }

        public AsyncInvoker<ShowSourceInstanceDetailResponse> ShowSourceInstanceDetailAsyncInvoker(ShowSourceInstanceDetailRequest showSourceInstanceDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instance-snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSourceInstanceDetailRequest);
            return new AsyncInvoker<ShowSourceInstanceDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSourceInstanceDetailResponse>);
        }
        
        /// <summary>
        /// 查询实例SSL证书下载地址
        ///
        /// 查询实例SSL证书下载地址。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSslCertDownloadLinkResponse> ShowSslCertDownloadLinkAsync(ShowSslCertDownloadLinkRequest showSslCertDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSslCertDownloadLinkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-cert/download-link", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSslCertDownloadLinkRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSslCertDownloadLinkResponse>(response);
        }

        public AsyncInvoker<ShowSslCertDownloadLinkResponse> ShowSslCertDownloadLinkAsyncInvoker(ShowSslCertDownloadLinkRequest showSslCertDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSslCertDownloadLinkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-cert/download-link", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSslCertDownloadLinkRequest);
            return new AsyncInvoker<ShowSslCertDownloadLinkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSslCertDownloadLinkResponse>);
        }
        
        /// <summary>
        /// 查询实例可升级版本
        ///
        /// 查询实例可升级版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUpgradeCandidateVersionsResponse> ShowUpgradeCandidateVersionsAsync(ShowUpgradeCandidateVersionsRequest showUpgradeCandidateVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showUpgradeCandidateVersionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade/candidate-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeCandidateVersionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUpgradeCandidateVersionsResponse>(response);
        }

        public AsyncInvoker<ShowUpgradeCandidateVersionsResponse> ShowUpgradeCandidateVersionsAsyncInvoker(ShowUpgradeCandidateVersionsRequest showUpgradeCandidateVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showUpgradeCandidateVersionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade/candidate-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeCandidateVersionsRequest);
            return new AsyncInvoker<ShowUpgradeCandidateVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUpgradeCandidateVersionsResponse>);
        }
        
        /// <summary>
        /// 查询实例可升级版本
        ///
        /// 查询实例可升级版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUpgradeCandidateVersionsDetailsResponse> ShowUpgradeCandidateVersionsDetailsAsync(ShowUpgradeCandidateVersionsDetailsRequest showUpgradeCandidateVersionsDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showUpgradeCandidateVersionsDetailsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-upgrade/candidate-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeCandidateVersionsDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUpgradeCandidateVersionsDetailsResponse>(response);
        }

        public AsyncInvoker<ShowUpgradeCandidateVersionsDetailsResponse> ShowUpgradeCandidateVersionsDetailsAsyncInvoker(ShowUpgradeCandidateVersionsDetailsRequest showUpgradeCandidateVersionsDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showUpgradeCandidateVersionsDetailsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-upgrade/candidate-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeCandidateVersionsDetailsRequest);
            return new AsyncInvoker<ShowUpgradeCandidateVersionsDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUpgradeCandidateVersionsDetailsResponse>);
        }
        
        /// <summary>
        /// 启动数据库
        ///
        /// 启动数据库，同时支持节点级别的启动操作
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest startInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-startup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartInstanceResponse>(response);
        }

        public AsyncInvoker<StartInstanceResponse> StartInstanceAsyncInvoker(StartInstanceRequest startInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-startup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startInstanceRequest);
            return new AsyncInvoker<StartInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StartInstanceResponse>);
        }
        
        /// <summary>
        /// 开启M兼容端口服务
        ///
        /// 开启指定实例的M兼容端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartMysqlCompatibilityResponse> StartMysqlCompatibilityAsync(StartMysqlCompatibilityRequest startMysqlCompatibilityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startMysqlCompatibilityRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/mysql-compatibility", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startMysqlCompatibilityRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartMysqlCompatibilityResponse>(response);
        }

        public AsyncInvoker<StartMysqlCompatibilityResponse> StartMysqlCompatibilityAsyncInvoker(StartMysqlCompatibilityRequest startMysqlCompatibilityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startMysqlCompatibilityRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/mysql-compatibility", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startMysqlCompatibilityRequest);
            return new AsyncInvoker<StartMysqlCompatibilityResponse>(this, "POST", request, JsonUtils.DeSerialize<StartMysqlCompatibilityResponse>);
        }
        
        /// <summary>
        /// 停止备份
        ///
        /// 停止进行中的备份，包括全备和差备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopBackupResponse> StopBackupAsync(StopBackupRequest stopBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", stopBackupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBackupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopBackupResponse>(response);
        }

        public AsyncInvoker<StopBackupResponse> StopBackupAsyncInvoker(StopBackupRequest stopBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", stopBackupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBackupRequest);
            return new AsyncInvoker<StopBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<StopBackupResponse>);
        }
        
        /// <summary>
        /// 停止数据库
        ///
        /// 停止数据库,同时支持节点级别的停止操作
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest stopInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", stopInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopInstanceResponse>(response);
        }

        public AsyncInvoker<StopInstanceResponse> StopInstanceAsyncInvoker(StopInstanceRequest stopInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", stopInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", stopInstanceRequest);
            return new AsyncInvoker<StopInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StopInstanceResponse>);
        }
        
        /// <summary>
        /// 应用参数模板
        ///
        /// 指定实例变更参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchConfigurationResponse> SwitchConfigurationAsync(SwitchConfigurationRequest switchConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", switchConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SwitchConfigurationResponse>(response);
        }

        public AsyncInvoker<SwitchConfigurationResponse> SwitchConfigurationAsyncInvoker(SwitchConfigurationRequest switchConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", switchConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchConfigurationRequest);
            return new AsyncInvoker<SwitchConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchConfigurationResponse>);
        }
        
        /// <summary>
        /// 分片节点主备切换。
        ///
        /// 支持用户对单个或多个DN分片做主备切换，同一分组内只能指定一个新的备节点进行升主操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchShardResponse> SwitchShardAsync(SwitchShardRequest switchShardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchShardRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switch-shard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchShardRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SwitchShardResponse>(response);
        }

        public AsyncInvoker<SwitchShardResponse> SwitchShardAsyncInvoker(SwitchShardRequest switchShardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchShardRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switch-shard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchShardRequest);
            return new AsyncInvoker<SwitchShardResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchShardResponse>);
        }
        
        /// <summary>
        /// 开启特性
        ///
        /// 打开高级特性开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateFeaturesResponse> UpdateFeaturesAsync(UpdateFeaturesRequest updateFeaturesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateFeaturesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/advance-features", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateFeaturesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateFeaturesResponse>(response);
        }

        public AsyncInvoker<UpdateFeaturesResponse> UpdateFeaturesAsyncInvoker(UpdateFeaturesRequest updateFeaturesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateFeaturesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/advance-features", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateFeaturesRequest);
            return new AsyncInvoker<UpdateFeaturesResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateFeaturesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceConfigurationResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceConfigurationResponse> UpdateInstanceConfigurationAsyncInvoker(UpdateInstanceConfigurationRequest updateInstanceConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceConfigurationRequest);
            return new AsyncInvoker<UpdateInstanceConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceConfigurationResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceNameRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceNameResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceNameResponse> UpdateInstanceNameAsyncInvoker(UpdateInstanceNameRequest updateInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceNameRequest);
            return new AsyncInvoker<UpdateInstanceNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceNameResponse>);
        }
        
        /// <summary>
        /// 更新/关闭M兼容端口服务
        ///
        /// 更新指定实例的M兼容端口服务配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMysqlCompatibilityResponse> UpdateMysqlCompatibilityAsync(UpdateMysqlCompatibilityRequest updateMysqlCompatibilityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateMysqlCompatibilityRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/mysql-compatibility", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMysqlCompatibilityRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMysqlCompatibilityResponse>(response);
        }

        public AsyncInvoker<UpdateMysqlCompatibilityResponse> UpdateMysqlCompatibilityAsyncInvoker(UpdateMysqlCompatibilityRequest updateMysqlCompatibilityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateMysqlCompatibilityRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/mysql-compatibility", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMysqlCompatibilityRequest);
            return new AsyncInvoker<UpdateMysqlCompatibilityResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMysqlCompatibilityResponse>);
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
        public async Task<UpgradeInstanceVersionResponse> UpgradeInstanceVersionAsync(UpgradeInstanceVersionRequest upgradeInstanceVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeInstanceVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeInstanceVersionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpgradeInstanceVersionResponse>(response);
        }

        public AsyncInvoker<UpgradeInstanceVersionResponse> UpgradeInstanceVersionAsyncInvoker(UpgradeInstanceVersionRequest upgradeInstanceVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeInstanceVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeInstanceVersionRequest);
            return new AsyncInvoker<UpgradeInstanceVersionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpgradeInstanceVersionResponse>);
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
        public async Task<UpgradeInstancesVersionResponse> UpgradeInstancesVersionAsync(UpgradeInstancesVersionRequest upgradeInstancesVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeInstancesVersionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpgradeInstancesVersionResponse>(response);
        }

        public AsyncInvoker<UpgradeInstancesVersionResponse> UpgradeInstancesVersionAsyncInvoker(UpgradeInstancesVersionRequest upgradeInstancesVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeInstancesVersionRequest);
            return new AsyncInvoker<UpgradeInstancesVersionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpgradeInstancesVersionResponse>);
        }
        
        /// <summary>
        /// 校验参数组名称是否存在
        ///
        /// 校验参数组名称是否存在。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ValidateParaGroupNameResponse> ValidateParaGroupNameAsync(ValidateParaGroupNameRequest validateParaGroupNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/name-validation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateParaGroupNameRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ValidateParaGroupNameResponse>(response);
        }

        public AsyncInvoker<ValidateParaGroupNameResponse> ValidateParaGroupNameAsyncInvoker(ValidateParaGroupNameRequest validateParaGroupNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/name-validation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateParaGroupNameRequest);
            return new AsyncInvoker<ValidateParaGroupNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ValidateParaGroupNameResponse>);
        }
        
        /// <summary>
        /// 弱密码校验
        ///
        /// 校验数据库root用户密码的安全性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ValidateWeakPasswordResponse> ValidateWeakPasswordAsync(ValidateWeakPasswordRequest validateWeakPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/weak-password-verification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", validateWeakPasswordRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ValidateWeakPasswordResponse>(response);
        }

        public AsyncInvoker<ValidateWeakPasswordResponse> ValidateWeakPasswordAsyncInvoker(ValidateWeakPasswordRequest validateWeakPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/weak-password-verification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", validateWeakPasswordRequest);
            return new AsyncInvoker<ValidateWeakPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<ValidateWeakPasswordResponse>);
        }
        
        /// <summary>
        /// 创建限流任务
        ///
        /// 根据具体范围和类型，进行限流任务的创建
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLimitTaskResponse> CreateLimitTaskAsync(CreateLimitTaskRequest createLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createLimitTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/limit-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLimitTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateLimitTaskResponse>(response);
        }

        public AsyncInvoker<CreateLimitTaskResponse> CreateLimitTaskAsyncInvoker(CreateLimitTaskRequest createLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createLimitTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/limit-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLimitTaskRequest);
            return new AsyncInvoker<CreateLimitTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLimitTaskResponse>);
        }
        
        /// <summary>
        /// 删除限流任务
        ///
        /// 根据task_id进行限流任务的删除
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLimitTaskResponse> DeleteLimitTaskAsync(DeleteLimitTaskRequest deleteLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", deleteLimitTaskRequest.TaskId.ToString());
            urlParam.Add("instance_id", deleteLimitTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/limit-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLimitTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLimitTaskResponse>(response);
        }

        public AsyncInvoker<DeleteLimitTaskResponse> DeleteLimitTaskAsyncInvoker(DeleteLimitTaskRequest deleteLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", deleteLimitTaskRequest.TaskId.ToString());
            urlParam.Add("instance_id", deleteLimitTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/limit-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLimitTaskRequest);
            return new AsyncInvoker<DeleteLimitTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLimitTaskResponse>);
        }
        
        /// <summary>
        /// 根据指定条件查询限流任务列表
        ///
        /// 根据指定条件查询限流任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLimitTaskResponse> ListLimitTaskAsync(ListLimitTaskRequest listLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listLimitTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/limit-task-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLimitTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLimitTaskResponse>(response);
        }

        public AsyncInvoker<ListLimitTaskResponse> ListLimitTaskAsyncInvoker(ListLimitTaskRequest listLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listLimitTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/limit-task-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLimitTaskRequest);
            return new AsyncInvoker<ListLimitTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLimitTaskResponse>);
        }
        
        /// <summary>
        /// 查询节点的sql模板列表
        ///
        /// 查询节点的sql模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNodeLimitSqlModelResponse> ListNodeLimitSqlModelAsync(ListNodeLimitSqlModelRequest listNodeLimitSqlModelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listNodeLimitSqlModelRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/list-node-limit-sql-model", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodeLimitSqlModelRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNodeLimitSqlModelResponse>(response);
        }

        public AsyncInvoker<ListNodeLimitSqlModelResponse> ListNodeLimitSqlModelAsyncInvoker(ListNodeLimitSqlModelRequest listNodeLimitSqlModelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listNodeLimitSqlModelRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/list-node-limit-sql-model", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodeLimitSqlModelRequest);
            return new AsyncInvoker<ListNodeLimitSqlModelResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNodeLimitSqlModelResponse>);
        }
        
        /// <summary>
        /// 查询限流任务详情
        ///
        /// 查询限流任务详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLimitTaskResponse> ShowLimitTaskAsync(ShowLimitTaskRequest showLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", showLimitTaskRequest.TaskId.ToString());
            urlParam.Add("instance_id", showLimitTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/limit-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLimitTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLimitTaskResponse>(response);
        }

        public AsyncInvoker<ShowLimitTaskResponse> ShowLimitTaskAsyncInvoker(ShowLimitTaskRequest showLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", showLimitTaskRequest.TaskId.ToString());
            urlParam.Add("instance_id", showLimitTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/limit-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLimitTaskRequest);
            return new AsyncInvoker<ShowLimitTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLimitTaskResponse>);
        }
        
        /// <summary>
        /// 同步内核侧sql限流数据至管控侧
        ///
        /// 同步内核侧sql限流数据至管控侧
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SyncLimitDataResponse> SyncLimitDataAsync(SyncLimitDataRequest syncLimitDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", syncLimitDataRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sync-limit-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncLimitDataRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SyncLimitDataResponse>(response);
        }

        public AsyncInvoker<SyncLimitDataResponse> SyncLimitDataAsyncInvoker(SyncLimitDataRequest syncLimitDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", syncLimitDataRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sync-limit-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncLimitDataRequest);
            return new AsyncInvoker<SyncLimitDataResponse>(this, "POST", request, JsonUtils.DeSerialize<SyncLimitDataResponse>);
        }
        
        /// <summary>
        /// 修改限流任务
        ///
        /// 根据新的条件进行限流任务的更新
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLimitTaskResponse> UpdateLimitTaskAsync(UpdateLimitTaskRequest updateLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", updateLimitTaskRequest.TaskId.ToString());
            urlParam.Add("instance_id", updateLimitTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/limit-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLimitTaskRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLimitTaskResponse>(response);
        }

        public AsyncInvoker<UpdateLimitTaskResponse> UpdateLimitTaskAsyncInvoker(UpdateLimitTaskRequest updateLimitTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", updateLimitTaskRequest.TaskId.ToString());
            urlParam.Add("instance_id", updateLimitTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/limit-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLimitTaskRequest);
            return new AsyncInvoker<UpdateLimitTaskResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLimitTaskResponse>);
        }
        
    }
}