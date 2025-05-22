using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3
{
    public partial class GaussDBforNoSQLAsyncClient : Client
    {
        public static ClientBuilder<GaussDBforNoSQLAsyncClient> NewBuilder()
        {
            return new ClientBuilder<GaussDBforNoSQLAsyncClient>();
        }

        
        /// <summary>
        /// 应用参数模板
        ///
        /// 将参数模板应用到实例，可以指定一个或多个实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ApplyConfigurationResponse> ApplyConfigurationAsync(ApplyConfigurationRequest applyConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", applyConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ApplyConfigurationResponse>(response);
        }

        public AsyncInvoker<ApplyConfigurationResponse> ApplyConfigurationAsyncInvoker(ApplyConfigurationRequest applyConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", applyConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyConfigurationRequest);
            return new AsyncInvoker<ApplyConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<ApplyConfigurationResponse>);
        }
        
        /// <summary>
        /// 应用参数模板
        ///
        /// 将参数模板应用到实例，可以指定一个或多个实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ApplyConfigurationToInstancesResponse> ApplyConfigurationToInstancesAsync(ApplyConfigurationToInstancesRequest applyConfigurationToInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", applyConfigurationToInstancesRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyConfigurationToInstancesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ApplyConfigurationToInstancesResponse>(response);
        }

        public AsyncInvoker<ApplyConfigurationToInstancesResponse> ApplyConfigurationToInstancesAsyncInvoker(ApplyConfigurationToInstancesRequest applyConfigurationToInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", applyConfigurationToInstancesRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyConfigurationToInstancesRequest);
            return new AsyncInvoker<ApplyConfigurationToInstancesResponse>(this, "PUT", request, JsonUtils.DeSerialize<ApplyConfigurationToInstancesResponse>);
        }
        
        /// <summary>
        /// 批量删除手动备份
        ///
        /// 批量删除数据库实例的手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteManualBackupResponse> BatchDeleteManualBackupAsync(BatchDeleteManualBackupRequest batchDeleteManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteManualBackupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<BatchDeleteManualBackupResponse>(response);
        }

        public AsyncInvoker<BatchDeleteManualBackupResponse> BatchDeleteManualBackupAsyncInvoker(BatchDeleteManualBackupRequest batchDeleteManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteManualBackupRequest);
            return new AsyncInvoker<BatchDeleteManualBackupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<BatchDeleteManualBackupResponse>);
        }
        
        /// <summary>
        /// 批量添加或删除资源标签
        ///
        /// 批量添加或删除指定数据库实例的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchTagActionResponse> BatchTagActionAsync(BatchTagActionRequest batchTagActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchTagActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagActionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchTagActionResponse>(response);
        }

        public AsyncInvoker<BatchTagActionResponse> BatchTagActionAsyncInvoker(BatchTagActionRequest batchTagActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchTagActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagActionRequest);
            return new AsyncInvoker<BatchTagActionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchTagActionResponse>);
        }
        
        /// <summary>
        /// 批量数据库补丁升级
        ///
        /// 批量升级数据库补丁版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpgradeDatabaseVersionResponse> BatchUpgradeDatabaseVersionAsync(BatchUpgradeDatabaseVersionRequest batchUpgradeDatabaseVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpgradeDatabaseVersionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchUpgradeDatabaseVersionResponse>(response);
        }

        public AsyncInvoker<BatchUpgradeDatabaseVersionResponse> BatchUpgradeDatabaseVersionAsyncInvoker(BatchUpgradeDatabaseVersionRequest batchUpgradeDatabaseVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpgradeDatabaseVersionRequest);
            return new AsyncInvoker<BatchUpgradeDatabaseVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchUpgradeDatabaseVersionResponse>);
        }
        
        /// <summary>
        /// 取消定时任务
        ///
        /// 取消定时任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelInstanceScheduleWindowResponse> CancelInstanceScheduleWindowAsync(CancelInstanceScheduleWindowRequest cancelInstanceScheduleWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", cancelInstanceScheduleWindowRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/scheduled-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelInstanceScheduleWindowRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<CancelInstanceScheduleWindowResponse>(response);
        }

        public AsyncInvoker<CancelInstanceScheduleWindowResponse> CancelInstanceScheduleWindowAsyncInvoker(CancelInstanceScheduleWindowRequest cancelInstanceScheduleWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", cancelInstanceScheduleWindowRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/scheduled-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelInstanceScheduleWindowRequest);
            return new AsyncInvoker<CancelInstanceScheduleWindowResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CancelInstanceScheduleWindowResponse>);
        }
        
        /// <summary>
        /// 校验实例是否可以与指定实例建立/解除容灾关系
        ///
        /// 校验实例是否可以与指定实例建立/解除容灾关系。若接口返回成功，表示可以与指定实例建立/解除容灾关系。
        /// 该接口需要对建立/解除容灾关系的两个实例各调用一次，2次调用都响应成功才能进行容灾关系的搭建/解除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckDisasterRecoveryOperationResponse> CheckDisasterRecoveryOperationAsync(CheckDisasterRecoveryOperationRequest checkDisasterRecoveryOperationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", checkDisasterRecoveryOperationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDisasterRecoveryOperationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CheckDisasterRecoveryOperationResponse>(response);
        }

        public AsyncInvoker<CheckDisasterRecoveryOperationResponse> CheckDisasterRecoveryOperationAsyncInvoker(CheckDisasterRecoveryOperationRequest checkDisasterRecoveryOperationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", checkDisasterRecoveryOperationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDisasterRecoveryOperationRequest);
            return new AsyncInvoker<CheckDisasterRecoveryOperationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CheckDisasterRecoveryOperationResponse>);
        }
        
        /// <summary>
        /// 判断弱密码
        ///
        /// 判断弱密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckWeekPasswordResponse> CheckWeekPasswordAsync(CheckWeekPasswordRequest checkWeekPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/weak-password-verification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkWeekPasswordRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CheckWeekPasswordResponse>(response);
        }

        public AsyncInvoker<CheckWeekPasswordResponse> CheckWeekPasswordAsyncInvoker(CheckWeekPasswordRequest checkWeekPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/weak-password-verification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkWeekPasswordRequest);
            return new AsyncInvoker<CheckWeekPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckWeekPasswordResponse>);
        }
        
        /// <summary>
        /// 关闭实例所有节点会话
        ///
        /// 关闭实例所有节点会话。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ClearInstanceSessionsResponse> ClearInstanceSessionsAsync(ClearInstanceSessionsRequest clearInstanceSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", clearInstanceSessionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", clearInstanceSessionsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<ClearInstanceSessionsResponse>(response);
        }

        public AsyncInvoker<ClearInstanceSessionsResponse> ClearInstanceSessionsAsyncInvoker(ClearInstanceSessionsRequest clearInstanceSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", clearInstanceSessionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", clearInstanceSessionsRequest);
            return new AsyncInvoker<ClearInstanceSessionsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<ClearInstanceSessionsResponse>);
        }
        
        /// <summary>
        /// 参数模板比较
        ///
        /// 比较两个参数模板之间的差异
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CompareConfigurationResponse> CompareConfigurationAsync(CompareConfigurationRequest compareConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/comparison", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareConfigurationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CompareConfigurationResponse>(response);
        }

        public AsyncInvoker<CompareConfigurationResponse> CompareConfigurationAsyncInvoker(CompareConfigurationRequest compareConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/comparison", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareConfigurationRequest);
            return new AsyncInvoker<CompareConfigurationResponse>(this, "POST", request, JsonUtils.DeSerialize<CompareConfigurationResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", copyConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyConfigurationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CopyConfigurationResponse>(response);
        }

        public AsyncInvoker<CopyConfigurationResponse> CopyConfigurationAsyncInvoker(CopyConfigurationRequest copyConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", copyConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyConfigurationRequest);
            return new AsyncInvoker<CopyConfigurationResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyConfigurationResponse>);
        }
        
        /// <summary>
        /// 创建手动备份
        ///
        /// 创建手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateBackResponse> CreateBackAsync(CreateBackRequest createBackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createBackRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBackRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateBackResponse>(response);
        }

        public AsyncInvoker<CreateBackResponse> CreateBackAsyncInvoker(CreateBackRequest createBackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createBackRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBackRequest);
            return new AsyncInvoker<CreateBackResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBackResponse>);
        }
        
        /// <summary>
        /// ‘创建冷数据存储’
        ///
        /// ‘创建冷数据存储’
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateColdVolumeResponse> CreateColdVolumeAsync(CreateColdVolumeRequest createColdVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createColdVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/cold-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createColdVolumeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateColdVolumeResponse>(response);
        }

        public AsyncInvoker<CreateColdVolumeResponse> CreateColdVolumeAsyncInvoker(CreateColdVolumeRequest createColdVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createColdVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/cold-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createColdVolumeRequest);
            return new AsyncInvoker<CreateColdVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateColdVolumeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfigurationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateConfigurationResponse>(response);
        }

        public AsyncInvoker<CreateConfigurationResponse> CreateConfigurationAsyncInvoker(CreateConfigurationRequest createConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfigurationRequest);
            return new AsyncInvoker<CreateConfigurationResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateConfigurationResponse>);
        }
        
        /// <summary>
        /// 创建内存加速映射
        ///
        /// 创建内存加速映射。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDbCacheMappingResponse> CreateDbCacheMappingAsync(CreateDbCacheMappingRequest createDbCacheMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dbcache/mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbCacheMappingRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDbCacheMappingResponse>(response);
        }

        public AsyncInvoker<CreateDbCacheMappingResponse> CreateDbCacheMappingAsyncInvoker(CreateDbCacheMappingRequest createDbCacheMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dbcache/mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbCacheMappingRequest);
            return new AsyncInvoker<CreateDbCacheMappingResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDbCacheMappingResponse>);
        }
        
        /// <summary>
        /// 创建内存加速规则
        ///
        /// 创建内存加速规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDbCacheRuleResponse> CreateDbCacheRuleAsync(CreateDbCacheRuleRequest createDbCacheRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dbcache/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbCacheRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDbCacheRuleResponse>(response);
        }

        public AsyncInvoker<CreateDbCacheRuleResponse> CreateDbCacheRuleAsyncInvoker(CreateDbCacheRuleRequest createDbCacheRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dbcache/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbCacheRuleRequest);
            return new AsyncInvoker<CreateDbCacheRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDbCacheRuleResponse>);
        }
        
        /// <summary>
        /// 创建Redis数据库账号
        ///
        /// 在Redis实例中创建数据库帐号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDbUserResponse> CreateDbUserAsync(CreateDbUserRequest createDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDbUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDbUserResponse>(response);
        }

        public AsyncInvoker<CreateDbUserResponse> CreateDbUserAsyncInvoker(CreateDbUserRequest createDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDbUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbUserRequest);
            return new AsyncInvoker<CreateDbUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDbUserResponse>);
        }
        
        /// <summary>
        /// 搭建实例与特定实例的容灾关系
        ///
        /// 搭建实例与特定实例的容灾关系。 该接口需要对搭建容灾关系的两个实例分别各调用一次，2次接口都调用成功才能成功搭建容灾关系。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDisasterRecoveryResponse> CreateDisasterRecoveryAsync(CreateDisasterRecoveryRequest createDisasterRecoveryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDisasterRecoveryRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/construction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDisasterRecoveryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDisasterRecoveryResponse>(response);
        }

        public AsyncInvoker<CreateDisasterRecoveryResponse> CreateDisasterRecoveryAsyncInvoker(CreateDisasterRecoveryRequest createDisasterRecoveryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDisasterRecoveryRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/construction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDisasterRecoveryRequest);
            return new AsyncInvoker<CreateDisasterRecoveryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDisasterRecoveryResponse>);
        }
        
        /// <summary>
        /// 搭建双活
        ///
        /// 为了实现跨区域实例数据同步，GeminiDB提供了异地双活功能，即创建异地双活实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGeminiDbDualActiveResponse> CreateGeminiDbDualActiveAsync(CreateGeminiDbDualActiveRequest createGeminiDbDualActiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGeminiDbDualActiveRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dual-active-relationship", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGeminiDbDualActiveRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGeminiDbDualActiveResponse>(response);
        }

        public AsyncInvoker<CreateGeminiDbDualActiveResponse> CreateGeminiDbDualActiveAsyncInvoker(CreateGeminiDbDualActiveRequest createGeminiDbDualActiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGeminiDbDualActiveRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dual-active-relationship", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGeminiDbDualActiveRequest);
            return new AsyncInvoker<CreateGeminiDbDualActiveResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGeminiDbDualActiveResponse>);
        }
        
        /// <summary>
        /// 创建实例
        ///
        /// 创建数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceResponse>(response);
        }

        public AsyncInvoker<CreateInstanceResponse> CreateInstanceAsyncInvoker(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRequest);
            return new AsyncInvoker<CreateInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceResponse>);
        }
        
        /// <summary>
        /// 删除手动备份
        ///
        /// 删除手动备份
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteBackupResponse> DeleteBackupAsync(DeleteBackupRequest deleteBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteBackupResponse>(response);
        }

        public AsyncInvoker<DeleteBackupResponse> DeleteBackupAsyncInvoker(DeleteBackupRequest deleteBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackupRequest);
            return new AsyncInvoker<DeleteBackupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteBackupResponse>);
        }
        
        /// <summary>
        /// 删除参数模板
        ///
        /// 删除指定参数模板。
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
        /// 解除内存加速映射
        ///
        /// 解除指定内存加速映射。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDbCacheMappingResponse> DeleteDbCacheMappingAsync(DeleteDbCacheMappingRequest deleteDbCacheMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dbcache/mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbCacheMappingRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDbCacheMappingResponse>(response);
        }

        public AsyncInvoker<DeleteDbCacheMappingResponse> DeleteDbCacheMappingAsyncInvoker(DeleteDbCacheMappingRequest deleteDbCacheMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dbcache/mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbCacheMappingRequest);
            return new AsyncInvoker<DeleteDbCacheMappingResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDbCacheMappingResponse>);
        }
        
        /// <summary>
        /// 删除内存加速规则
        ///
        /// 删除内存加速规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDbCacheRuleResponse> DeleteDbCacheRuleAsync(DeleteDbCacheRuleRequest deleteDbCacheRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dbcache/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbCacheRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDbCacheRuleResponse>(response);
        }

        public AsyncInvoker<DeleteDbCacheRuleResponse> DeleteDbCacheRuleAsyncInvoker(DeleteDbCacheRuleRequest deleteDbCacheRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dbcache/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbCacheRuleRequest);
            return new AsyncInvoker<DeleteDbCacheRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDbCacheRuleResponse>);
        }
        
        /// <summary>
        /// 删除Redis数据库账号
        ///
        /// 删除Redis实例的数据库账号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDbUserResponse> DeleteDbUserAsync(DeleteDbUserRequest deleteDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDbUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbUserRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDbUserResponse>(response);
        }

        public AsyncInvoker<DeleteDbUserResponse> DeleteDbUserAsyncInvoker(DeleteDbUserRequest deleteDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDbUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbUserRequest);
            return new AsyncInvoker<DeleteDbUserResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDbUserResponse>);
        }
        
        /// <summary>
        /// 解除实例与特定实例的容灾关系
        ///
        /// 解除实例与特定实例的容灾关系。 该接口需要对搭建容灾关系的两个实例分别各调用一次，2次接口都调用成功才能成功解除容灾关系。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDisasterRecoveryResponse> DeleteDisasterRecoveryAsync(DeleteDisasterRecoveryRequest deleteDisasterRecoveryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDisasterRecoveryRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/deconstruction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDisasterRecoveryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DeleteDisasterRecoveryResponse>(response);
        }

        public AsyncInvoker<DeleteDisasterRecoveryResponse> DeleteDisasterRecoveryAsyncInvoker(DeleteDisasterRecoveryRequest deleteDisasterRecoveryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDisasterRecoveryRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/deconstruction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDisasterRecoveryRequest);
            return new AsyncInvoker<DeleteDisasterRecoveryResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteDisasterRecoveryResponse>);
        }
        
        /// <summary>
        /// 删除扩容失败的节点
        ///
        /// 删除扩容失败的节点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteEnlargeFailNodeResponse> DeleteEnlargeFailNodeAsync(DeleteEnlargeFailNodeRequest deleteEnlargeFailNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteEnlargeFailNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/enlarge-failed-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnlargeFailNodeRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteEnlargeFailNodeResponse>(response);
        }

        public AsyncInvoker<DeleteEnlargeFailNodeResponse> DeleteEnlargeFailNodeAsyncInvoker(DeleteEnlargeFailNodeRequest deleteEnlargeFailNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteEnlargeFailNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/enlarge-failed-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnlargeFailNodeRequest);
            return new AsyncInvoker<DeleteEnlargeFailNodeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteEnlargeFailNodeResponse>);
        }
        
        /// <summary>
        /// 解除双活
        ///
        /// 解除跨区域双活。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGeminiDbDualActiveResponse> DeleteGeminiDbDualActiveAsync(DeleteGeminiDbDualActiveRequest deleteGeminiDbDualActiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGeminiDbDualActiveRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dual-active-relationship", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGeminiDbDualActiveRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteGeminiDbDualActiveResponse>(response);
        }

        public AsyncInvoker<DeleteGeminiDbDualActiveResponse> DeleteGeminiDbDualActiveAsyncInvoker(DeleteGeminiDbDualActiveRequest deleteGeminiDbDualActiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGeminiDbDualActiveRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dual-active-relationship", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGeminiDbDualActiveRequest);
            return new AsyncInvoker<DeleteGeminiDbDualActiveResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteGeminiDbDualActiveResponse>);
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
        /// 关闭实例节点会话
        ///
        /// 关闭实例节点会话。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstancesSessionResponse> DeleteInstancesSessionAsync(DeleteInstancesSessionRequest deleteInstancesSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", deleteInstancesSessionRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/nodes/{node_id}/sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstancesSessionRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstancesSessionResponse>(response);
        }

        public AsyncInvoker<DeleteInstancesSessionResponse> DeleteInstancesSessionAsyncInvoker(DeleteInstancesSessionRequest deleteInstancesSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", deleteInstancesSessionRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/nodes/{node_id}/sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstancesSessionRequest);
            return new AsyncInvoker<DeleteInstancesSessionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstancesSessionResponse>);
        }
        
        /// <summary>
        /// 解除关联LTS日志流
        ///
        /// 将实例日志与LTS日志流解除关联，后台将取消上传实例日志到的LTS日志流里。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLtsConfigsResponse> DeleteLtsConfigsAsync(DeleteLtsConfigsRequest deleteLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLtsConfigsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLtsConfigsResponse>(response);
        }

        public AsyncInvoker<DeleteLtsConfigsResponse> DeleteLtsConfigsAsyncInvoker(DeleteLtsConfigsRequest deleteLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLtsConfigsRequest);
            return new AsyncInvoker<DeleteLtsConfigsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLtsConfigsResponse>);
        }
        
        /// <summary>
        /// 删除Redis禁用命令
        ///
        /// 删除Redis禁用命令。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRedisDisabledCommandsResponse> DeleteRedisDisabledCommandsAsync(DeleteRedisDisabledCommandsRequest deleteRedisDisabledCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteRedisDisabledCommandsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/disabled-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRedisDisabledCommandsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRedisDisabledCommandsResponse>(response);
        }

        public AsyncInvoker<DeleteRedisDisabledCommandsResponse> DeleteRedisDisabledCommandsAsyncInvoker(DeleteRedisDisabledCommandsRequest deleteRedisDisabledCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteRedisDisabledCommandsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/disabled-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRedisDisabledCommandsRequest);
            return new AsyncInvoker<DeleteRedisDisabledCommandsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRedisDisabledCommandsResponse>);
        }
        
        /// <summary>
        /// 扩容指定集群实例的节点数量
        ///
        /// 扩容指定集群实例的节点数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExpandInstanceNodeResponse> ExpandInstanceNodeAsync(ExpandInstanceNodeRequest expandInstanceNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", expandInstanceNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/enlarge-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandInstanceNodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExpandInstanceNodeResponse>(response);
        }

        public AsyncInvoker<ExpandInstanceNodeResponse> ExpandInstanceNodeAsyncInvoker(ExpandInstanceNodeRequest expandInstanceNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", expandInstanceNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/enlarge-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandInstanceNodeRequest);
            return new AsyncInvoker<ExpandInstanceNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<ExpandInstanceNodeResponse>);
        }
        
        /// <summary>
        /// 查询实例可变更规格
        ///
        /// 查询实例可变更规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAvailableFlavorInfosResponse> ListAvailableFlavorInfosAsync(ListAvailableFlavorInfosRequest listAvailableFlavorInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAvailableFlavorInfosRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/available-flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableFlavorInfosRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAvailableFlavorInfosResponse>(response);
        }

        public AsyncInvoker<ListAvailableFlavorInfosResponse> ListAvailableFlavorInfosAsyncInvoker(ListAvailableFlavorInfosRequest listAvailableFlavorInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAvailableFlavorInfosRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/available-flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableFlavorInfosRequest);
            return new AsyncInvoker<ListAvailableFlavorInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailableFlavorInfosResponse>);
        }
        
        /// <summary>
        /// 查询GeminiDB(for Cassandra)数据库慢日志
        ///
        /// 查询GeminiDB(for Cassandra)数据库慢日志信息，支持日志关键字搜索。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCassandraSlowLogsResponse> ListCassandraSlowLogsAsync(ListCassandraSlowLogsRequest listCassandraSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listCassandraSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/cassandra/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCassandraSlowLogsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListCassandraSlowLogsResponse>(response);
        }

        public AsyncInvoker<ListCassandraSlowLogsResponse> ListCassandraSlowLogsAsyncInvoker(ListCassandraSlowLogsRequest listCassandraSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listCassandraSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/cassandra/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCassandraSlowLogsRequest);
            return new AsyncInvoker<ListCassandraSlowLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListCassandraSlowLogsResponse>);
        }
        
        /// <summary>
        /// 查询支持参数模板的接口信息
        ///
        /// 查询支持参数模板的接口信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConfigurationDatastoresResponse> ListConfigurationDatastoresAsync(ListConfigurationDatastoresRequest listConfigurationDatastoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/datastores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationDatastoresRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListConfigurationDatastoresResponse>(response);
        }

        public AsyncInvoker<ListConfigurationDatastoresResponse> ListConfigurationDatastoresAsyncInvoker(ListConfigurationDatastoresRequest listConfigurationDatastoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/datastores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationDatastoresRequest);
            return new AsyncInvoker<ListConfigurationDatastoresResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigurationDatastoresResponse>);
        }
        
        /// <summary>
        /// 获取参数模板列表
        ///
        /// 获取参数模板列表，包括所有数据库的默认参数模板和用户创建的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConfigurationTemplatesResponse> ListConfigurationTemplatesAsync(ListConfigurationTemplatesRequest listConfigurationTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListConfigurationTemplatesResponse>(response);
        }

        public AsyncInvoker<ListConfigurationTemplatesResponse> ListConfigurationTemplatesAsyncInvoker(ListConfigurationTemplatesRequest listConfigurationTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationTemplatesRequest);
            return new AsyncInvoker<ListConfigurationTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigurationTemplatesResponse>);
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
        /// 查询指定实例类型的数据库版本信息
        ///
        /// 查询指定实例类型的数据库版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDatastoresResponse> ListDatastoresAsync(ListDatastoresRequest listDatastoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("datastore_name", listDatastoresRequest.DatastoreName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores/{datastore_name}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoresRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDatastoresResponse>(response);
        }

        public AsyncInvoker<ListDatastoresResponse> ListDatastoresAsyncInvoker(ListDatastoresRequest listDatastoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("datastore_name", listDatastoresRequest.DatastoreName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores/{datastore_name}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoresRequest);
            return new AsyncInvoker<ListDatastoresResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatastoresResponse>);
        }
        
        /// <summary>
        /// 查询内存加速映射列表和详情
        ///
        /// 根据指定条件查询内存加速映射关系列表和详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDbCacheMappingsResponse> ListDbCacheMappingsAsync(ListDbCacheMappingsRequest listDbCacheMappingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dbcache/mappings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbCacheMappingsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDbCacheMappingsResponse>(response);
        }

        public AsyncInvoker<ListDbCacheMappingsResponse> ListDbCacheMappingsAsyncInvoker(ListDbCacheMappingsRequest listDbCacheMappingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dbcache/mappings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbCacheMappingsRequest);
            return new AsyncInvoker<ListDbCacheMappingsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDbCacheMappingsResponse>);
        }
        
        /// <summary>
        /// 查询内存加速规则列表和详情
        ///
        /// 查询内存加速规则列表和详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDbCacheRulesResponse> ListDbCacheRulesAsync(ListDbCacheRulesRequest listDbCacheRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dbcache/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbCacheRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDbCacheRulesResponse>(response);
        }

        public AsyncInvoker<ListDbCacheRulesResponse> ListDbCacheRulesAsyncInvoker(ListDbCacheRulesRequest listDbCacheRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dbcache/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbCacheRulesRequest);
            return new AsyncInvoker<ListDbCacheRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDbCacheRulesResponse>);
        }
        
        /// <summary>
        /// 获取Redis数据库账号列表和详情
        ///
        /// 获取Redis数据库账号列表和详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDbUsersResponse> ListDbUsersAsync(ListDbUsersRequest listDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDbUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbUsersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDbUsersResponse>(response);
        }

        public AsyncInvoker<ListDbUsersResponse> ListDbUsersAsyncInvoker(ListDbUsersRequest listDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDbUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbUsersRequest);
            return new AsyncInvoker<ListDbUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDbUsersResponse>);
        }
        
        /// <summary>
        /// 查询专属资源列表
        ///
        /// 查询专属资源列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDedicatedResourcesResponse> ListDedicatedResourcesAsync(ListDedicatedResourcesRequest listDedicatedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dedicated-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDedicatedResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDedicatedResourcesResponse>(response);
        }

        public AsyncInvoker<ListDedicatedResourcesResponse> ListDedicatedResourcesAsyncInvoker(ListDedicatedResourcesRequest listDedicatedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dedicated-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDedicatedResourcesRequest);
            return new AsyncInvoker<ListDedicatedResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDedicatedResourcesResponse>);
        }
        
        /// <summary>
        /// 查询企业项目配额
        ///
        /// 查询企业项目配额。
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
        /// 查询数据库规格
        ///
        /// 查询指定条件下的实例规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFlavorInfosResponse> ListFlavorInfosAsync(ListFlavorInfosRequest listFlavorInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorInfosRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorInfosResponse>(response);
        }

        public AsyncInvoker<ListFlavorInfosResponse> ListFlavorInfosAsyncInvoker(ListFlavorInfosRequest listFlavorInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorInfosRequest);
            return new AsyncInvoker<ListFlavorInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorInfosResponse>);
        }
        
        /// <summary>
        /// 查询指定条件下的所有实例规格信息
        ///
        /// 查询指定条件下的所有实例规格信息。
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
        /// 查询GeminiDB(for influxdb)数据库慢日志
        ///
        /// 查询GeminiDB(for influxdb)数据库慢日志信息，支持日志关键字搜索。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInfluxdbSlowLogsResponse> ListInfluxdbSlowLogsAsync(ListInfluxdbSlowLogsRequest listInfluxdbSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInfluxdbSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/influxdb/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInfluxdbSlowLogsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListInfluxdbSlowLogsResponse>(response);
        }

        public AsyncInvoker<ListInfluxdbSlowLogsResponse> ListInfluxdbSlowLogsAsyncInvoker(ListInfluxdbSlowLogsRequest listInfluxdbSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInfluxdbSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/influxdb/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInfluxdbSlowLogsRequest);
            return new AsyncInvoker<ListInfluxdbSlowLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInfluxdbSlowLogsResponse>);
        }
        
        /// <summary>
        /// 获取Redis实例数据库列表
        ///
        /// 获取Redis实例数据库列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceDatabasesResponse> ListInstanceDatabasesAsync(ListInstanceDatabasesRequest listInstanceDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceDatabasesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceDatabasesResponse>(response);
        }

        public AsyncInvoker<ListInstanceDatabasesResponse> ListInstanceDatabasesAsyncInvoker(ListInstanceDatabasesRequest listInstanceDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceDatabasesRequest);
            return new AsyncInvoker<ListInstanceDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceDatabasesResponse>);
        }
        
        /// <summary>
        /// 查询实例可维护时间段
        ///
        /// 查询实例可维护时间段。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceMaintenanceWindowResponse> ListInstanceMaintenanceWindowAsync(ListInstanceMaintenanceWindowRequest listInstanceMaintenanceWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceMaintenanceWindowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ops-window", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceMaintenanceWindowRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceMaintenanceWindowResponse>(response);
        }

        public AsyncInvoker<ListInstanceMaintenanceWindowResponse> ListInstanceMaintenanceWindowAsyncInvoker(ListInstanceMaintenanceWindowRequest listInstanceMaintenanceWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceMaintenanceWindowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ops-window", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceMaintenanceWindowRequest);
            return new AsyncInvoker<ListInstanceMaintenanceWindowResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceMaintenanceWindowResponse>);
        }
        
        /// <summary>
        /// 获取实例的会话
        ///
        /// 获取实例的会话。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceSessionsResponse> ListInstanceSessionsAsync(ListInstanceSessionsRequest listInstanceSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceSessionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceSessionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceSessionsResponse>(response);
        }

        public AsyncInvoker<ListInstanceSessionsResponse> ListInstanceSessionsAsyncInvoker(ListInstanceSessionsRequest listInstanceSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceSessionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceSessionsRequest);
            return new AsyncInvoker<ListInstanceSessionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceSessionsResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询指定实例的标签信息。
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
        /// 查询实例列表和详情
        ///
        /// 根据指定条件查询数据库实例列表和详情。
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
        /// 查询资源实例
        ///
        /// 根据标签查询指定的数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesByResourceTagsResponse> ListInstancesByResourceTagsAsync(ListInstancesByResourceTagsRequest listInstancesByResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/resource-instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesByResourceTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListInstancesByResourceTagsResponse>(response);
        }

        public AsyncInvoker<ListInstancesByResourceTagsResponse> ListInstancesByResourceTagsAsyncInvoker(ListInstancesByResourceTagsRequest listInstancesByResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/resource-instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesByResourceTagsRequest);
            return new AsyncInvoker<ListInstancesByResourceTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInstancesByResourceTagsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例
        ///
        /// 根据标签查询指定的数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesByTagsResponse> ListInstancesByTagsAsync(ListInstancesByTagsRequest listInstancesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListInstancesByTagsResponse>(response);
        }

        public AsyncInvoker<ListInstancesByTagsResponse> ListInstancesByTagsAsyncInvoker(ListInstancesByTagsRequest listInstancesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesByTagsRequest);
            return new AsyncInvoker<ListInstancesByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInstancesByTagsResponse>);
        }
        
        /// <summary>
        /// 获取节点会话列表
        ///
        /// 获取节点会话列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesSessionResponse> ListInstancesSessionAsync(ListInstancesSessionRequest listInstancesSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", listInstancesSessionRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/nodes/{node_id}/sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesSessionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesSessionResponse>(response);
        }

        public AsyncInvoker<ListInstancesSessionResponse> ListInstancesSessionAsyncInvoker(ListInstancesSessionRequest listInstancesSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", listInstancesSessionRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/nodes/{node_id}/sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesSessionRequest);
            return new AsyncInvoker<ListInstancesSessionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesSessionResponse>);
        }
        
        /// <summary>
        /// 查询实例节点会话统计信息
        ///
        /// 查询实例节点会话统计信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesSessionStatisticsResponse> ListInstancesSessionStatisticsAsync(ListInstancesSessionStatisticsRequest listInstancesSessionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", listInstancesSessionStatisticsRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/nodes/{node_id}/session-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesSessionStatisticsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesSessionStatisticsResponse>(response);
        }

        public AsyncInvoker<ListInstancesSessionStatisticsResponse> ListInstancesSessionStatisticsAsyncInvoker(ListInstancesSessionStatisticsRequest listInstancesSessionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", listInstancesSessionStatisticsRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/nodes/{node_id}/session-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesSessionStatisticsRequest);
            return new AsyncInvoker<ListInstancesSessionStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesSessionStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询任务列表和详情
        ///
        /// 查询任务列表和详情，默认查询任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListJobsResponse>(response);
        }

        public AsyncInvoker<ListJobsResponse> ListJobsAsyncInvoker(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            return new AsyncInvoker<ListJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobsResponse>);
        }
        
        /// <summary>
        /// 查询LTS日志配置信息
        ///
        /// 分页查询实例关联的LTS日志配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLtsConfigsResponse> ListLtsConfigsAsync(ListLtsConfigsRequest listLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLtsConfigsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLtsConfigsResponse>(response);
        }

        public AsyncInvoker<ListLtsConfigsResponse> ListLtsConfigsAsyncInvoker(ListLtsConfigsRequest listLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLtsConfigsRequest);
            return new AsyncInvoker<ListLtsConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLtsConfigsResponse>);
        }
        
        /// <summary>
        /// 查询GeminiDB(for Mongo)数据库错误日志
        ///
        /// 查询GeminiDB(for Mongo)数据库错误日志信息，支持日志关键字搜索。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMongodbErrorLogsResponse> ListMongodbErrorLogsAsync(ListMongodbErrorLogsRequest listMongodbErrorLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listMongodbErrorLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/mongodb/instances/{instance_id}/error-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMongodbErrorLogsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListMongodbErrorLogsResponse>(response);
        }

        public AsyncInvoker<ListMongodbErrorLogsResponse> ListMongodbErrorLogsAsyncInvoker(ListMongodbErrorLogsRequest listMongodbErrorLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listMongodbErrorLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/mongodb/instances/{instance_id}/error-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMongodbErrorLogsRequest);
            return new AsyncInvoker<ListMongodbErrorLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListMongodbErrorLogsResponse>);
        }
        
        /// <summary>
        /// 查询GeminiDB(for Mongo)数据库慢日志
        ///
        /// 查询GeminiDB(for Mongo)数据库慢日志信息，支持日志关键字搜索。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMongodbSlowLogsResponse> ListMongodbSlowLogsAsync(ListMongodbSlowLogsRequest listMongodbSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listMongodbSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/mongodb/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMongodbSlowLogsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListMongodbSlowLogsResponse>(response);
        }

        public AsyncInvoker<ListMongodbSlowLogsResponse> ListMongodbSlowLogsAsyncInvoker(ListMongodbSlowLogsRequest listMongodbSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listMongodbSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/mongodb/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMongodbSlowLogsRequest);
            return new AsyncInvoker<ListMongodbSlowLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListMongodbSlowLogsResponse>);
        }
        
        /// <summary>
        /// 查询定时任务列表
        ///
        /// 根据指定条件查询定时任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNosqlTaskListResponse> ListNosqlTaskListAsync(ListNosqlTaskListRequest listNosqlTaskListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/scheduled-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNosqlTaskListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNosqlTaskListResponse>(response);
        }

        public AsyncInvoker<ListNosqlTaskListResponse> ListNosqlTaskListAsyncInvoker(ListNosqlTaskListRequest listNosqlTaskListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/scheduled-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNosqlTaskListRequest);
            return new AsyncInvoker<ListNosqlTaskListResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNosqlTaskListResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询指定项目的标签信息。
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
        /// 查询回收站实例列表
        ///
        /// 查询回收站所有引擎的实例列表。
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
        /// 查询Redis可恢复时间点
        ///
        /// 查询Redis可恢复时间点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRedisPitrRestoreTimeResponse> ListRedisPitrRestoreTimeAsync(ListRedisPitrRestoreTimeRequest listRedisPitrRestoreTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRedisPitrRestoreTimeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/pitr/restorable-time-periods", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRedisPitrRestoreTimeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRedisPitrRestoreTimeResponse>(response);
        }

        public AsyncInvoker<ListRedisPitrRestoreTimeResponse> ListRedisPitrRestoreTimeAsyncInvoker(ListRedisPitrRestoreTimeRequest listRedisPitrRestoreTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRedisPitrRestoreTimeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/pitr/restorable-time-periods", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRedisPitrRestoreTimeRequest);
            return new AsyncInvoker<ListRedisPitrRestoreTimeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRedisPitrRestoreTimeResponse>);
        }
        
        /// <summary>
        /// 查询GeminiDB(for Redis)数据库慢日志
        ///
        /// 查询GeminiDB(for Redis)数据库慢日志信息，支持日志关键字搜索。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRedisSlowLogsResponse> ListRedisSlowLogsAsync(ListRedisSlowLogsRequest listRedisSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRedisSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRedisSlowLogsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListRedisSlowLogsResponse>(response);
        }

        public AsyncInvoker<ListRedisSlowLogsResponse> ListRedisSlowLogsAsyncInvoker(ListRedisSlowLogsRequest listRedisSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRedisSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRedisSlowLogsRequest);
            return new AsyncInvoker<ListRedisSlowLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListRedisSlowLogsResponse>);
        }
        
        /// <summary>
        /// 获取GeminiDB(for Cassandra)实例表级恢复的数据库信息
        ///
        /// 获取GeminiDB(for Cassandra)实例表级恢复的数据库信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRestoreDatabasesResponse> ListRestoreDatabasesAsync(ListRestoreDatabasesRequest listRestoreDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreDatabasesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRestoreDatabasesResponse>(response);
        }

        public AsyncInvoker<ListRestoreDatabasesResponse> ListRestoreDatabasesAsyncInvoker(ListRestoreDatabasesRequest listRestoreDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreDatabasesRequest);
            return new AsyncInvoker<ListRestoreDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestoreDatabasesResponse>);
        }
        
        /// <summary>
        /// 获取GeminiDB(for Cassandra)实例表级恢复的表信息
        ///
        /// 获取GeminiDB(for Cassandra)实例表级恢复的表信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRestoreTablesResponse> ListRestoreTablesAsync(ListRestoreTablesRequest listRestoreTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreTablesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTablesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRestoreTablesResponse>(response);
        }

        public AsyncInvoker<ListRestoreTablesResponse> ListRestoreTablesAsyncInvoker(ListRestoreTablesRequest listRestoreTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreTablesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTablesRequest);
            return new AsyncInvoker<ListRestoreTablesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestoreTablesResponse>);
        }
        
        /// <summary>
        /// 查询实例可恢复的时间段
        ///
        /// 查询实例可恢复的时间段
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRestoreTimeResponse> ListRestoreTimeAsync(ListRestoreTimeRequest listRestoreTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreTimeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/restorable-time-periods", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTimeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRestoreTimeResponse>(response);
        }

        public AsyncInvoker<ListRestoreTimeResponse> ListRestoreTimeAsyncInvoker(ListRestoreTimeRequest listRestoreTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreTimeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/restorable-time-periods", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTimeRequest);
            return new AsyncInvoker<ListRestoreTimeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestoreTimeResponse>);
        }
        
        /// <summary>
        /// 查询数据库慢日志
        ///
        /// 查询数据库慢日志信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSlowLogsResponse> ListSlowLogsAsync(ListSlowLogsRequest listSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSlowLogsResponse>(response);
        }

        public AsyncInvoker<ListSlowLogsResponse> ListSlowLogsAsyncInvoker(ListSlowLogsRequest listSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsRequest);
            return new AsyncInvoker<ListSlowLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSlowLogsResponse>);
        }
        
        /// <summary>
        /// 修改Redis数据库帐号权限
        ///
        /// 修改Redis数据库帐号权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyDbUserPrivilegeResponse> ModifyDbUserPrivilegeAsync(ModifyDbUserPrivilegeRequest modifyDbUserPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyDbUserPrivilegeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/db-users/privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyDbUserPrivilegeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyDbUserPrivilegeResponse>(response);
        }

        public AsyncInvoker<ModifyDbUserPrivilegeResponse> ModifyDbUserPrivilegeAsyncInvoker(ModifyDbUserPrivilegeRequest modifyDbUserPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyDbUserPrivilegeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/db-users/privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyDbUserPrivilegeRequest);
            return new AsyncInvoker<ModifyDbUserPrivilegeResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyDbUserPrivilegeResponse>);
        }
        
        /// <summary>
        /// 修改企业项目配额
        ///
        /// 修改企业项目配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyEpsQuotasResponse> ModifyEpsQuotasAsync(ModifyEpsQuotasRequest modifyEpsQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyEpsQuotasRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<ModifyEpsQuotasResponse>(response);
        }

        public AsyncInvoker<ModifyEpsQuotasResponse> ModifyEpsQuotasAsyncInvoker(ModifyEpsQuotasRequest modifyEpsQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyEpsQuotasRequest);
            return new AsyncInvoker<ModifyEpsQuotasResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ModifyEpsQuotasResponse>);
        }
        
        /// <summary>
        /// 设置实例可维护时间段
        ///
        /// 设置指定实例可维护时间段。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyInstanceMaintenanceWindowResponse> ModifyInstanceMaintenanceWindowAsync(ModifyInstanceMaintenanceWindowRequest modifyInstanceMaintenanceWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyInstanceMaintenanceWindowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/maintenance-window", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyInstanceMaintenanceWindowRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<ModifyInstanceMaintenanceWindowResponse>(response);
        }

        public AsyncInvoker<ModifyInstanceMaintenanceWindowResponse> ModifyInstanceMaintenanceWindowAsyncInvoker(ModifyInstanceMaintenanceWindowRequest modifyInstanceMaintenanceWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyInstanceMaintenanceWindowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/maintenance-window", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyInstanceMaintenanceWindowRequest);
            return new AsyncInvoker<ModifyInstanceMaintenanceWindowResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ModifyInstanceMaintenanceWindowResponse>);
        }
        
        /// <summary>
        /// 修改数据库端口
        ///
        /// 修改数据库实例的端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyPortResponse> ModifyPortAsync(ModifyPortRequest modifyPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyPortRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyPortRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyPortResponse>(response);
        }

        public AsyncInvoker<ModifyPortResponse> ModifyPortAsyncInvoker(ModifyPortRequest modifyPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyPortRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyPortRequest);
            return new AsyncInvoker<ModifyPortResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyPortResponse>);
        }
        
        /// <summary>
        /// 绑定/解绑弹性公网IP
        ///
        /// 实例下的节点绑定弹性公网IP/解绑弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyPublicIpResponse> ModifyPublicIpAsync(ModifyPublicIpRequest modifyPublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyPublicIpRequest.InstanceId.ToString());
            urlParam.Add("node_id", modifyPublicIpRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyPublicIpRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ModifyPublicIpResponse>(response);
        }

        public AsyncInvoker<ModifyPublicIpResponse> ModifyPublicIpAsyncInvoker(ModifyPublicIpRequest modifyPublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyPublicIpRequest.InstanceId.ToString());
            urlParam.Add("node_id", modifyPublicIpRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyPublicIpRequest);
            return new AsyncInvoker<ModifyPublicIpResponse>(this, "POST", request, JsonUtils.DeSerialize<ModifyPublicIpResponse>);
        }
        
        /// <summary>
        /// 变更实例存储容量
        ///
        /// 变更实例的存储容量大小
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyVolumeResponse> ModifyVolumeAsync(ModifyVolumeRequest modifyVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyVolumeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyVolumeResponse>(response);
        }

        public AsyncInvoker<ModifyVolumeResponse> ModifyVolumeAsyncInvoker(ModifyVolumeRequest modifyVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyVolumeRequest);
            return new AsyncInvoker<ModifyVolumeResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyVolumeResponse>);
        }
        
        /// <summary>
        /// 支持节点的开关机
        ///
        /// 当底层故障导致节点无法正常工作时，可以对该节点执行关机操作，关机后会由其他节点接管业务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<OfflineNodesResponse> OfflineNodesAsync(OfflineNodesRequest offlineNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", offlineNodesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", offlineNodesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<OfflineNodesResponse>(response);
        }

        public AsyncInvoker<OfflineNodesResponse> OfflineNodesAsyncInvoker(OfflineNodesRequest offlineNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", offlineNodesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", offlineNodesRequest);
            return new AsyncInvoker<OfflineNodesResponse>(this, "PUT", request, JsonUtils.DeSerialize<OfflineNodesResponse>);
        }
        
        /// <summary>
        /// 暂停/恢复具备容灾关系的实例数据同步
        ///
        /// 该接口用于暂停/恢复具备容灾关系的实例数据同步。
        /// 
        /// 该接口需要对具备容灾关系的两个实例分别各调用一次，2次接口都调用成功才能成功暂停/恢复容灾实例数据同步。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PauseResumeDataSynchronizationResponse> PauseResumeDataSynchronizationAsync(PauseResumeDataSynchronizationRequest pauseResumeDataSynchronizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", pauseResumeDataSynchronizationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/data-synchronization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", pauseResumeDataSynchronizationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<PauseResumeDataSynchronizationResponse>(response);
        }

        public AsyncInvoker<PauseResumeDataSynchronizationResponse> PauseResumeDataSynchronizationAsyncInvoker(PauseResumeDataSynchronizationRequest pauseResumeDataSynchronizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", pauseResumeDataSynchronizationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/data-synchronization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", pauseResumeDataSynchronizationRequest);
            return new AsyncInvoker<PauseResumeDataSynchronizationResponse>(this, "POST", request, JsonUtils.DeSerialize<PauseResumeDataSynchronizationResponse>);
        }
        
        /// <summary>
        /// 重置Redis数据库账号密码
        ///
        /// 重置Redis数据库账号密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetDbUserPasswordResponse> ResetDbUserPasswordAsync(ResetDbUserPasswordRequest resetDbUserPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetDbUserPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/db-users/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetDbUserPasswordRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetDbUserPasswordResponse>(response);
        }

        public AsyncInvoker<ResetDbUserPasswordResponse> ResetDbUserPasswordAsyncInvoker(ResetDbUserPasswordRequest resetDbUserPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetDbUserPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/db-users/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetDbUserPasswordRequest);
            return new AsyncInvoker<ResetDbUserPasswordResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetDbUserPasswordResponse>);
        }
        
        /// <summary>
        /// 重置自定义参数模板
        ///
        /// 重置自定义参数模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetParamGroupTemplateResponse> ResetParamGroupTemplateAsync(ResetParamGroupTemplateRequest resetParamGroupTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", resetParamGroupTemplateRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetParamGroupTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ResetParamGroupTemplateResponse>(response);
        }

        public AsyncInvoker<ResetParamGroupTemplateResponse> ResetParamGroupTemplateAsyncInvoker(ResetParamGroupTemplateRequest resetParamGroupTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", resetParamGroupTemplateRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetParamGroupTemplateRequest);
            return new AsyncInvoker<ResetParamGroupTemplateResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetParamGroupTemplateResponse>);
        }
        
        /// <summary>
        /// 修改实例的管理员密码
        ///
        /// 修改实例的管理员密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordRequest resetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPasswordRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetPasswordResponse>(response);
        }

        public AsyncInvoker<ResetPasswordResponse> ResetPasswordAsyncInvoker(ResetPasswordRequest resetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPasswordRequest);
            return new AsyncInvoker<ResetPasswordResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetPasswordResponse>);
        }
        
        /// <summary>
        /// 扩容冷数据存储
        ///
        /// 扩容冷数据存储。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResizeColdVolumeResponse> ResizeColdVolumeAsync(ResizeColdVolumeRequest resizeColdVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeColdVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/cold-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeColdVolumeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ResizeColdVolumeResponse>(response);
        }

        public AsyncInvoker<ResizeColdVolumeResponse> ResizeColdVolumeAsyncInvoker(ResizeColdVolumeRequest resizeColdVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeColdVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/cold-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeColdVolumeRequest);
            return new AsyncInvoker<ResizeColdVolumeResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResizeColdVolumeResponse>);
        }
        
        /// <summary>
        /// 变更实例规格
        ///
        /// 变更实例的规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResizeInstanceResponse> ResizeInstanceAsync(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ResizeInstanceResponse>(response);
        }

        public AsyncInvoker<ResizeInstanceResponse> ResizeInstanceAsyncInvoker(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceRequest);
            return new AsyncInvoker<ResizeInstanceResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResizeInstanceResponse>);
        }
        
        /// <summary>
        /// 扩容实例存储容量
        ///
        /// 扩容实例的存储容量大小。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResizeInstanceVolumeResponse> ResizeInstanceVolumeAsync(ResizeInstanceVolumeRequest resizeInstanceVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extend-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceVolumeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResizeInstanceVolumeResponse>(response);
        }

        public AsyncInvoker<ResizeInstanceVolumeResponse> ResizeInstanceVolumeAsyncInvoker(ResizeInstanceVolumeRequest resizeInstanceVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extend-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceVolumeRequest);
            return new AsyncInvoker<ResizeInstanceVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeInstanceVolumeResponse>);
        }
        
        /// <summary>
        /// 重启实例或节点
        ///
        /// 重启实例或节点的数据库服务。
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
        /// 恢复到已有实例
        ///
        /// 恢复到已有实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestoreExistingInstanceResponse> RestoreExistingInstanceAsync(RestoreExistingInstanceRequest restoreExistingInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restoreExistingInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreExistingInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RestoreExistingInstanceResponse>(response);
        }

        public AsyncInvoker<RestoreExistingInstanceResponse> RestoreExistingInstanceAsyncInvoker(RestoreExistingInstanceRequest restoreExistingInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restoreExistingInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreExistingInstanceRequest);
            return new AsyncInvoker<RestoreExistingInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreExistingInstanceResponse>);
        }
        
        /// <summary>
        /// 恢复当前Redis实例到指定时间点
        ///
        /// 恢复当前Redis实例到指定时间点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestoreRedisPitrResponse> RestoreRedisPitrAsync(RestoreRedisPitrRequest restoreRedisPitrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restoreRedisPitrRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/pitr", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreRedisPitrRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<RestoreRedisPitrResponse>(response);
        }

        public AsyncInvoker<RestoreRedisPitrResponse> RestoreRedisPitrAsyncInvoker(RestoreRedisPitrRequest restoreRedisPitrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restoreRedisPitrRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/pitr", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreRedisPitrRequest);
            return new AsyncInvoker<RestoreRedisPitrResponse>(this, "PUT", request, JsonUtils.DeSerialize<RestoreRedisPitrResponse>);
        }
        
        /// <summary>
        /// 关联LTS日志流
        ///
        /// - 将实例日志与LTS日志流关联，后台将自动上传实例日志到关联的LTS日志流里。
        /// - 关联成功后，会产生一定费用，具体计费可参考云日志服务（LTS）的定价详情。
        /// - 系统会为当前选择的日志流创建对应日志类型的结构化配置，若该日志流已存在其他日志类型的结构化配置，系统会进行覆盖。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SaveLtsConfigsResponse> SaveLtsConfigsAsync(SaveLtsConfigsRequest saveLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveLtsConfigsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SaveLtsConfigsResponse>(response);
        }

        public AsyncInvoker<SaveLtsConfigsResponse> SaveLtsConfigsAsyncInvoker(SaveLtsConfigsRequest saveLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveLtsConfigsRequest);
            return new AsyncInvoker<SaveLtsConfigsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SaveLtsConfigsResponse>);
        }
        
        /// <summary>
        /// 设置Redis禁用命令
        ///
        /// 设置Redis禁用命令。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SaveRedisDisabledCommandsResponse> SaveRedisDisabledCommandsAsync(SaveRedisDisabledCommandsRequest saveRedisDisabledCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", saveRedisDisabledCommandsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/disabled-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveRedisDisabledCommandsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SaveRedisDisabledCommandsResponse>(response);
        }

        public AsyncInvoker<SaveRedisDisabledCommandsResponse> SaveRedisDisabledCommandsAsyncInvoker(SaveRedisDisabledCommandsRequest saveRedisDisabledCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", saveRedisDisabledCommandsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/disabled-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveRedisDisabledCommandsRequest);
            return new AsyncInvoker<SaveRedisDisabledCommandsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SaveRedisDisabledCommandsResponse>);
        }
        
        /// <summary>
        /// 设置磁盘自动扩容策略
        ///
        /// 设置磁盘自动扩容策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetAutoEnlargePolicyResponse> SetAutoEnlargePolicyAsync(SetAutoEnlargePolicyRequest setAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/disk-auto-expansion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAutoEnlargePolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetAutoEnlargePolicyResponse>(response);
        }

        public AsyncInvoker<SetAutoEnlargePolicyResponse> SetAutoEnlargePolicyAsyncInvoker(SetAutoEnlargePolicyRequest setAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/disk-auto-expansion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAutoEnlargePolicyRequest);
            return new AsyncInvoker<SetAutoEnlargePolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetAutoEnlargePolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBackupPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetBackupPolicyResponse>(response);
        }

        public AsyncInvoker<SetBackupPolicyResponse> SetBackupPolicyAsyncInvoker(SetBackupPolicyRequest setBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBackupPolicyRequest);
            return new AsyncInvoker<SetBackupPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetBackupPolicyResponse>);
        }
        
        /// <summary>
        /// 设置实例容灾切换的故障节点比例
        ///
        /// 设置实例容灾切换的故障节点比例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetDisasterRecoverySettingsResponse> SetDisasterRecoverySettingsAsync(SetDisasterRecoverySettingsRequest setDisasterRecoverySettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/disaster-recovery/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setDisasterRecoverySettingsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SetDisasterRecoverySettingsResponse>(response);
        }

        public AsyncInvoker<SetDisasterRecoverySettingsResponse> SetDisasterRecoverySettingsAsyncInvoker(SetDisasterRecoverySettingsRequest setDisasterRecoverySettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/disaster-recovery/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setDisasterRecoverySettingsRequest);
            return new AsyncInvoker<SetDisasterRecoverySettingsResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetDisasterRecoverySettingsResponse>);
        }
        
        /// <summary>
        /// 开启/关闭实例数据导出
        ///
        /// 开启/关闭实例数据导出。
        /// 当前支持将InfluxDB数据转为parquet格式文件然后上传到指定的OBS桶中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetInstanceDataDumpResponse> SetInstanceDataDumpAsync(SetInstanceDataDumpRequest setInstanceDataDumpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setInstanceDataDumpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/data-dump", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setInstanceDataDumpRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetInstanceDataDumpResponse>(response);
        }

        public AsyncInvoker<SetInstanceDataDumpResponse> SetInstanceDataDumpAsyncInvoker(SetInstanceDataDumpRequest setInstanceDataDumpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setInstanceDataDumpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/data-dump", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setInstanceDataDumpRequest);
            return new AsyncInvoker<SetInstanceDataDumpResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetInstanceDataDumpResponse>);
        }
        
        /// <summary>
        /// 设置回收策略
        ///
        /// 设置已删除实例保留天数，修改保留天数后删除的实例按照新的天数保留，修改之前已在回收站的实例保留天数不变。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetRecyclePolicyResponse> SetRecyclePolicyAsync(SetRecyclePolicyRequest setRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRecyclePolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetRecyclePolicyResponse>(response);
        }

        public AsyncInvoker<SetRecyclePolicyResponse> SetRecyclePolicyAsyncInvoker(SetRecyclePolicyRequest setRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRecyclePolicyRequest);
            return new AsyncInvoker<SetRecyclePolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetRecyclePolicyResponse>);
        }
        
        /// <summary>
        /// 设置Redis恢复到指定时间点策略
        ///
        /// 设置Redis恢复到指定时间点策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetRedisPitrPolicyResponse> SetRedisPitrPolicyAsync(SetRedisPitrPolicyRequest setRedisPitrPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setRedisPitrPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/pitr/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRedisPitrPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetRedisPitrPolicyResponse>(response);
        }

        public AsyncInvoker<SetRedisPitrPolicyResponse> SetRedisPitrPolicyAsyncInvoker(SetRedisPitrPolicyRequest setRedisPitrPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setRedisPitrPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/pitr/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRedisPitrPolicyRequest);
            return new AsyncInvoker<SetRedisPitrPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetRedisPitrPolicyResponse>);
        }
        
        /// <summary>
        /// 查询备份列表
        ///
        /// 根据指定条件查询备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAllInstancesBackupsResponse> ShowAllInstancesBackupsAsync(ShowAllInstancesBackupsRequest showAllInstancesBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllInstancesBackupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAllInstancesBackupsResponse>(response);
        }

        public AsyncInvoker<ShowAllInstancesBackupsResponse> ShowAllInstancesBackupsAsyncInvoker(ShowAllInstancesBackupsRequest showAllInstancesBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllInstancesBackupsRequest);
            return new AsyncInvoker<ShowAllInstancesBackupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAllInstancesBackupsResponse>);
        }
        
        /// <summary>
        /// 查询备份列表（推荐）
        ///
        /// 根据指定条件查询备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAllInstancesBackupsNewResponse> ShowAllInstancesBackupsNewAsync(ShowAllInstancesBackupsNewRequest showAllInstancesBackupsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllInstancesBackupsNewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAllInstancesBackupsNewResponse>(response);
        }

        public AsyncInvoker<ShowAllInstancesBackupsNewResponse> ShowAllInstancesBackupsNewAsyncInvoker(ShowAllInstancesBackupsNewRequest showAllInstancesBackupsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllInstancesBackupsNewRequest);
            return new AsyncInvoker<ShowAllInstancesBackupsNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAllInstancesBackupsNewResponse>);
        }
        
        /// <summary>
        /// 查询参数模板可应用的实例列表
        ///
        /// 查询参数模板可应用的实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowApplicableInstancesResponse> ShowApplicableInstancesAsync(ShowApplicableInstancesRequest showApplicableInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showApplicableInstancesRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applicable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplicableInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowApplicableInstancesResponse>(response);
        }

        public AsyncInvoker<ShowApplicableInstancesResponse> ShowApplicableInstancesAsyncInvoker(ShowApplicableInstancesRequest showApplicableInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showApplicableInstancesRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applicable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplicableInstancesRequest);
            return new AsyncInvoker<ShowApplicableInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApplicableInstancesResponse>);
        }
        
        /// <summary>
        /// 查询参数模板应用历史
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowApplyHistoryResponse> ShowApplyHistoryAsync(ShowApplyHistoryRequest showApplyHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showApplyHistoryRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applied-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplyHistoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowApplyHistoryResponse>(response);
        }

        public AsyncInvoker<ShowApplyHistoryResponse> ShowApplyHistoryAsyncInvoker(ShowApplyHistoryRequest showApplyHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showApplyHistoryRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applied-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplyHistoryRequest);
            return new AsyncInvoker<ShowApplyHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApplyHistoryResponse>);
        }
        
        /// <summary>
        /// 查询磁盘自动扩容策略
        ///
        /// 查询磁盘自动扩容策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutoEnlargePolicyResponse> ShowAutoEnlargePolicyAsync(ShowAutoEnlargePolicyRequest showAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAutoEnlargePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disk-auto-expansion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoEnlargePolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoEnlargePolicyResponse>(response);
        }

        public AsyncInvoker<ShowAutoEnlargePolicyResponse> ShowAutoEnlargePolicyAsyncInvoker(ShowAutoEnlargePolicyRequest showAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAutoEnlargePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disk-auto-expansion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoEnlargePolicyRequest);
            return new AsyncInvoker<ShowAutoEnlargePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoEnlargePolicyResponse>);
        }
        
        /// <summary>
        /// 查询自动备份策略
        ///
        /// 查询自动备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBackupPoliciesResponse> ShowBackupPoliciesAsync(ShowBackupPoliciesRequest showBackupPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBackupPoliciesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupPoliciesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBackupPoliciesResponse>(response);
        }

        public AsyncInvoker<ShowBackupPoliciesResponse> ShowBackupPoliciesAsyncInvoker(ShowBackupPoliciesRequest showBackupPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBackupPoliciesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupPoliciesRequest);
            return new AsyncInvoker<ShowBackupPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackupPoliciesResponse>);
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
        /// 获取指定参数模板的参数
        ///
        /// 获取指定参数模板的详细信息。
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
        /// 查询实例容灾切换的故障节点比例
        ///
        /// 查询实例容灾切换的故障节点比例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDisasterRecoverySettingsResponse> ShowDisasterRecoverySettingsAsync(ShowDisasterRecoverySettingsRequest showDisasterRecoverySettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/disaster-recovery/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDisasterRecoverySettingsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDisasterRecoverySettingsResponse>(response);
        }

        public AsyncInvoker<ShowDisasterRecoverySettingsResponse> ShowDisasterRecoverySettingsAsyncInvoker(ShowDisasterRecoverySettingsRequest showDisasterRecoverySettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/disaster-recovery/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDisasterRecoverySettingsRequest);
            return new AsyncInvoker<ShowDisasterRecoverySettingsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDisasterRecoverySettingsResponse>);
        }
        
        /// <summary>
        /// 查询实例负载均衡的IP访问黑白名单
        ///
        /// 查询实例负载均衡的IP访问黑白名单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowElbIpGroupResponse> ShowElbIpGroupAsync(ShowElbIpGroupRequest showElbIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showElbIpGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/lb/access-control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showElbIpGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowElbIpGroupResponse>(response);
        }

        public AsyncInvoker<ShowElbIpGroupResponse> ShowElbIpGroupAsyncInvoker(ShowElbIpGroupRequest showElbIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showElbIpGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/lb/access-control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showElbIpGroupRequest);
            return new AsyncInvoker<ShowElbIpGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowElbIpGroupResponse>);
        }
        
        /// <summary>
        /// 查询数据库错误日志信息
        ///
        /// 查询数据库错误日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowErrorLogResponse> ShowErrorLogAsync(ShowErrorLogRequest showErrorLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showErrorLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showErrorLogRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowErrorLogResponse>(response);
        }

        public AsyncInvoker<ShowErrorLogResponse> ShowErrorLogAsyncInvoker(ShowErrorLogRequest showErrorLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showErrorLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showErrorLogRequest);
            return new AsyncInvoker<ShowErrorLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowErrorLogResponse>);
        }
        
        /// <summary>
        /// 查询高危命令
        ///
        /// 查询Redis的高危命令
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHighRiskCommandsResponse> ShowHighRiskCommandsAsync(ShowHighRiskCommandsRequest showHighRiskCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showHighRiskCommandsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/high-risk-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHighRiskCommandsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowHighRiskCommandsResponse>(response);
        }

        public AsyncInvoker<ShowHighRiskCommandsResponse> ShowHighRiskCommandsAsyncInvoker(ShowHighRiskCommandsRequest showHighRiskCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showHighRiskCommandsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/high-risk-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHighRiskCommandsRequest);
            return new AsyncInvoker<ShowHighRiskCommandsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHighRiskCommandsResponse>);
        }
        
        /// <summary>
        /// 查询实例可搭建双活关系的Region
        ///
        /// 查询实例可搭建双活关系的Region。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceBiactiveRegionsResponse> ShowInstanceBiactiveRegionsAsync(ShowInstanceBiactiveRegionsRequest showInstanceBiactiveRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceBiactiveRegionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceBiactiveRegionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceBiactiveRegionsResponse>(response);
        }

        public AsyncInvoker<ShowInstanceBiactiveRegionsResponse> ShowInstanceBiactiveRegionsAsyncInvoker(ShowInstanceBiactiveRegionsRequest showInstanceBiactiveRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceBiactiveRegionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceBiactiveRegionsRequest);
            return new AsyncInvoker<ShowInstanceBiactiveRegionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceBiactiveRegionsResponse>);
        }
        
        /// <summary>
        /// 查询实例参数配置
        ///
        /// 查询实例参数配置。
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
        /// 获取容灾实例主/备角色信息
        ///
        /// 该接口用于获取容灾实例主/备角色信息，以便后续容灾实例备升主和容灾实例主降备接口调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceRoleResponse> ShowInstanceRoleAsync(ShowInstanceRoleRequest showInstanceRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceRoleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/instance-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRoleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceRoleResponse>(response);
        }

        public AsyncInvoker<ShowInstanceRoleResponse> ShowInstanceRoleAsyncInvoker(ShowInstanceRoleRequest showInstanceRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceRoleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/instance-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRoleRequest);
            return new AsyncInvoker<ShowInstanceRoleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceRoleResponse>);
        }
        
        /// <summary>
        /// 查询创建实例或扩容节点时需要的IP数量
        ///
        /// 查询创建实例或扩容节点时需要的IP数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowIpNumRequirementResponse> ShowIpNumRequirementAsync(ShowIpNumRequirementRequest showIpNumRequirementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/ip-num-requirement", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpNumRequirementRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowIpNumRequirementResponse>(response);
        }

        public AsyncInvoker<ShowIpNumRequirementResponse> ShowIpNumRequirementAsyncInvoker(ShowIpNumRequirementRequest showIpNumRequirementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/ip-num-requirement", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpNumRequirementRequest);
            return new AsyncInvoker<ShowIpNumRequirementResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIpNumRequirementResponse>);
        }
        
        /// <summary>
        /// 查询实例参数的修改历史
        ///
        /// 查询实例参数的修改历史
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowModifyHistoryResponse> ShowModifyHistoryAsync(ShowModifyHistoryRequest showModifyHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showModifyHistoryRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configuration-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showModifyHistoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowModifyHistoryResponse>(response);
        }

        public AsyncInvoker<ShowModifyHistoryResponse> ShowModifyHistoryAsyncInvoker(ShowModifyHistoryRequest showModifyHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showModifyHistoryRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configuration-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showModifyHistoryRequest);
            return new AsyncInvoker<ShowModifyHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowModifyHistoryResponse>);
        }
        
        /// <summary>
        /// 获取GeminiDB Redis的免密配置
        ///
        /// 获取GeminiDB Redis的免密配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPasswordlessConfigResponse> ShowPasswordlessConfigAsync(ShowPasswordlessConfigRequest showPasswordlessConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPasswordlessConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/passwordless-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPasswordlessConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPasswordlessConfigResponse>(response);
        }

        public AsyncInvoker<ShowPasswordlessConfigResponse> ShowPasswordlessConfigAsyncInvoker(ShowPasswordlessConfigRequest showPasswordlessConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPasswordlessConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/passwordless-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPasswordlessConfigRequest);
            return new AsyncInvoker<ShowPasswordlessConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPasswordlessConfigResponse>);
        }
        
        /// <summary>
        /// 获取容灾实例数据同步状态
        ///
        /// 获取容灾实例数据同步状态，主备实例id，数据同步指标值，以及倒换和切换场景下的RPO，RTO指标值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPauseResumeStutusResponse> ShowPauseResumeStutusAsync(ShowPauseResumeStutusRequest showPauseResumeStutusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPauseResumeStutusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/data-synchronization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPauseResumeStutusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPauseResumeStutusResponse>(response);
        }

        public AsyncInvoker<ShowPauseResumeStutusResponse> ShowPauseResumeStutusAsyncInvoker(ShowPauseResumeStutusRequest showPauseResumeStutusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPauseResumeStutusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/data-synchronization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPauseResumeStutusRequest);
            return new AsyncInvoker<ShowPauseResumeStutusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPauseResumeStutusResponse>);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// 查询单租户在GeminiDB服务下的资源配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQuotasResponse> ShowQuotasAsync(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }

        public AsyncInvoker<ShowQuotasResponse> ShowQuotasAsyncInvoker(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            return new AsyncInvoker<ShowQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotasResponse>);
        }
        
        /// <summary>
        /// 查询回收策略
        ///
        /// 查询回收策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecyclePolicyResponse> ShowRecyclePolicyAsync(ShowRecyclePolicyRequest showRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecyclePolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRecyclePolicyResponse>(response);
        }

        public AsyncInvoker<ShowRecyclePolicyResponse> ShowRecyclePolicyAsyncInvoker(ShowRecyclePolicyRequest showRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecyclePolicyRequest);
            return new AsyncInvoker<ShowRecyclePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecyclePolicyResponse>);
        }
        
        /// <summary>
        /// 查询Redis实例的大key
        ///
        /// 支持查询Redis实例的大key。value长度大于bigkeys-string-threshold参数的string类型的key或者元素数大于bigkeys-composite-threshold参数的hash/list/zset/set/stream类型key，会被判断为大key。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRedisBigKeysResponse> ShowRedisBigKeysAsync(ShowRedisBigKeysRequest showRedisBigKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRedisBigKeysRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/big-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRedisBigKeysRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowRedisBigKeysResponse>(response);
        }

        public AsyncInvoker<ShowRedisBigKeysResponse> ShowRedisBigKeysAsyncInvoker(ShowRedisBigKeysRequest showRedisBigKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRedisBigKeysRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/big-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRedisBigKeysRequest);
            return new AsyncInvoker<ShowRedisBigKeysResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowRedisBigKeysResponse>);
        }
        
        /// <summary>
        /// 查询Redis禁用命令
        ///
        /// 查询Redis禁用命令。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRedisDisabledCommandsResponse> ShowRedisDisabledCommandsAsync(ShowRedisDisabledCommandsRequest showRedisDisabledCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRedisDisabledCommandsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/disabled-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRedisDisabledCommandsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRedisDisabledCommandsResponse>(response);
        }

        public AsyncInvoker<ShowRedisDisabledCommandsResponse> ShowRedisDisabledCommandsAsyncInvoker(ShowRedisDisabledCommandsRequest showRedisDisabledCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRedisDisabledCommandsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/disabled-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRedisDisabledCommandsRequest);
            return new AsyncInvoker<ShowRedisDisabledCommandsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRedisDisabledCommandsResponse>);
        }
        
        /// <summary>
        /// 查询Redis实例的热key
        ///
        /// 支持查询Redis实例的热key。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRedisHotKeysResponse> ShowRedisHotKeysAsync(ShowRedisHotKeysRequest showRedisHotKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRedisHotKeysRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hot-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRedisHotKeysRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRedisHotKeysResponse>(response);
        }

        public AsyncInvoker<ShowRedisHotKeysResponse> ShowRedisHotKeysAsyncInvoker(ShowRedisHotKeysRequest showRedisHotKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRedisHotKeysRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hot-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRedisHotKeysRequest);
            return new AsyncInvoker<ShowRedisHotKeysResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRedisHotKeysResponse>);
        }
        
        /// <summary>
        /// 查询Redis实例指定时间点恢复所占用的存储空间
        ///
        /// 查询Redis实例指定时间点恢复所占用的存储空间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRedisPitrInfoResponse> ShowRedisPitrInfoAsync(ShowRedisPitrInfoRequest showRedisPitrInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRedisPitrInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/pitr", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRedisPitrInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRedisPitrInfoResponse>(response);
        }

        public AsyncInvoker<ShowRedisPitrInfoResponse> ShowRedisPitrInfoAsyncInvoker(ShowRedisPitrInfoRequest showRedisPitrInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRedisPitrInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/pitr", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRedisPitrInfoRequest);
            return new AsyncInvoker<ShowRedisPitrInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRedisPitrInfoResponse>);
        }
        
        /// <summary>
        /// 查询Redis恢复到指定时间点策略
        ///
        /// 查询Redis恢复到指定时间点策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRedisPitrPolicyResponse> ShowRedisPitrPolicyAsync(ShowRedisPitrPolicyRequest showRedisPitrPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRedisPitrPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/pitr/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRedisPitrPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRedisPitrPolicyResponse>(response);
        }

        public AsyncInvoker<ShowRedisPitrPolicyResponse> ShowRedisPitrPolicyAsyncInvoker(ShowRedisPitrPolicyRequest showRedisPitrPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRedisPitrPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/pitr/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRedisPitrPolicyRequest);
            return new AsyncInvoker<ShowRedisPitrPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRedisPitrPolicyResponse>);
        }
        
        /// <summary>
        /// 查询可恢复的实例列表
        ///
        /// 查询用户可恢复的实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRestorableListResponse> ShowRestorableListAsync(ShowRestorableListRequest showRestorableListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", showRestorableListRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/restorable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRestorableListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRestorableListResponse>(response);
        }

        public AsyncInvoker<ShowRestorableListResponse> ShowRestorableListAsyncInvoker(ShowRestorableListRequest showRestorableListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", showRestorableListRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/restorable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRestorableListRequest);
            return new AsyncInvoker<ShowRestorableListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRestorableListResponse>);
        }
        
        /// <summary>
        /// 查询秒级监控配置
        ///
        /// 查询秒级监控配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSecondLevelMonitoringStatusResponse> ShowSecondLevelMonitoringStatusAsync(ShowSecondLevelMonitoringStatusRequest showSecondLevelMonitoringStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSecondLevelMonitoringStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitoring-by-seconds/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecondLevelMonitoringStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSecondLevelMonitoringStatusResponse>(response);
        }

        public AsyncInvoker<ShowSecondLevelMonitoringStatusResponse> ShowSecondLevelMonitoringStatusAsyncInvoker(ShowSecondLevelMonitoringStatusRequest showSecondLevelMonitoringStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSecondLevelMonitoringStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitoring-by-seconds/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecondLevelMonitoringStatusRequest);
            return new AsyncInvoker<ShowSecondLevelMonitoringStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecondLevelMonitoringStatusResponse>);
        }
        
        /// <summary>
        /// 查询慢日志脱敏状态
        ///
        /// 查询慢日志脱敏状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSlowLogDesensitizationResponse> ShowSlowLogDesensitizationAsync(ShowSlowLogDesensitizationRequest showSlowLogDesensitizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSlowLogDesensitizationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-desensitization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSlowLogDesensitizationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSlowLogDesensitizationResponse>(response);
        }

        public AsyncInvoker<ShowSlowLogDesensitizationResponse> ShowSlowLogDesensitizationAsyncInvoker(ShowSlowLogDesensitizationRequest showSlowLogDesensitizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSlowLogDesensitizationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-desensitization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSlowLogDesensitizationRequest);
            return new AsyncInvoker<ShowSlowLogDesensitizationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSlowLogDesensitizationResponse>);
        }
        
        /// <summary>
        /// 缩容指定集群实例的节点数量
        ///
        /// 缩容指定集群实例的节点数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShrinkInstanceNodeResponse> ShrinkInstanceNodeAsync(ShrinkInstanceNodeRequest shrinkInstanceNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", shrinkInstanceNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/reduce-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", shrinkInstanceNodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShrinkInstanceNodeResponse>(response);
        }

        public AsyncInvoker<ShrinkInstanceNodeResponse> ShrinkInstanceNodeAsyncInvoker(ShrinkInstanceNodeRequest shrinkInstanceNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", shrinkInstanceNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/reduce-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", shrinkInstanceNodeRequest);
            return new AsyncInvoker<ShrinkInstanceNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<ShrinkInstanceNodeResponse>);
        }
        
        /// <summary>
        /// 停止备份
        ///
        /// 支持紧急情况下停止备份功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopBackupResponse> StopBackupAsync(StopBackupRequest stopBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", stopBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBackupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<StopBackupResponse>(response);
        }

        public AsyncInvoker<StopBackupResponse> StopBackupAsyncInvoker(StopBackupRequest stopBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", stopBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBackupRequest);
            return new AsyncInvoker<StopBackupResponse>(this, "PUT", request, JsonUtils.DeSerialize<StopBackupResponse>);
        }
        
        /// <summary>
        /// 设置实例负载均衡的IP访问黑白名单
        ///
        /// 设置实例负载均衡的IP访问黑白名单，黑名单、白名单只能选一种，每次调用此接口覆盖之前的设置。关闭后不限制连接的源IP地址。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchIpGroupResponse> SwitchIpGroupAsync(SwitchIpGroupRequest switchIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchIpGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/lb/access-control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchIpGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SwitchIpGroupResponse>(response);
        }

        public AsyncInvoker<SwitchIpGroupResponse> SwitchIpGroupAsyncInvoker(SwitchIpGroupRequest switchIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchIpGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/lb/access-control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchIpGroupRequest);
            return new AsyncInvoker<SwitchIpGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SwitchIpGroupResponse>);
        }
        
        /// <summary>
        /// Redis主备切换
        ///
        /// 切换实例的主备节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchOverResponse> SwitchOverAsync(SwitchOverRequest switchOverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchOverRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchOverRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SwitchOverResponse>(response);
        }

        public AsyncInvoker<SwitchOverResponse> SwitchOverAsyncInvoker(SwitchOverRequest switchOverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchOverRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchOverRequest);
            return new AsyncInvoker<SwitchOverResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchOverResponse>);
        }
        
        /// <summary>
        /// 开启/关闭秒级监控
        ///
        /// 开启或关闭指定实例的5秒级监控。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchSecondLevelMonitoringResponse> SwitchSecondLevelMonitoringAsync(SwitchSecondLevelMonitoringRequest switchSecondLevelMonitoringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSecondLevelMonitoringRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitoring-by-seconds/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSecondLevelMonitoringRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SwitchSecondLevelMonitoringResponse>(response);
        }

        public AsyncInvoker<SwitchSecondLevelMonitoringResponse> SwitchSecondLevelMonitoringAsyncInvoker(SwitchSecondLevelMonitoringRequest switchSecondLevelMonitoringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSecondLevelMonitoringRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitoring-by-seconds/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSecondLevelMonitoringRequest);
            return new AsyncInvoker<SwitchSecondLevelMonitoringResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SwitchSecondLevelMonitoringResponse>);
        }
        
        /// <summary>
        /// 设置慢日志脱敏状态
        ///
        /// 设置慢日志脱敏状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchSlowlogDesensitizationResponse> SwitchSlowlogDesensitizationAsync(SwitchSlowlogDesensitizationRequest switchSlowlogDesensitizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSlowlogDesensitizationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-desensitization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSlowlogDesensitizationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SwitchSlowlogDesensitizationResponse>(response);
        }

        public AsyncInvoker<SwitchSlowlogDesensitizationResponse> SwitchSlowlogDesensitizationAsyncInvoker(SwitchSlowlogDesensitizationRequest switchSlowlogDesensitizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSlowlogDesensitizationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-desensitization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSlowlogDesensitizationRequest);
            return new AsyncInvoker<SwitchSlowlogDesensitizationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SwitchSlowlogDesensitizationResponse>);
        }
        
        /// <summary>
        /// 切换实例SSL开关
        ///
        /// 切换实例SSL开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchSslResponse> SwitchSslAsync(SwitchSslRequest switchSslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSslRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-option", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSslRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SwitchSslResponse>(response);
        }

        public AsyncInvoker<SwitchSslResponse> SwitchSslAsyncInvoker(SwitchSslRequest switchSslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSslRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-option", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSslRequest);
            return new AsyncInvoker<SwitchSslResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchSslResponse>);
        }
        
        /// <summary>
        /// 容灾实例备升主
        ///
        /// 该接口用于对已经搭建容灾关系的实例，将备实例升级为主实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchToMasterResponse> SwitchToMasterAsync(SwitchToMasterRequest switchToMasterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchToMasterRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switchover-master", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchToMasterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SwitchToMasterResponse>(response);
        }

        public AsyncInvoker<SwitchToMasterResponse> SwitchToMasterAsyncInvoker(SwitchToMasterRequest switchToMasterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchToMasterRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switchover-master", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchToMasterRequest);
            return new AsyncInvoker<SwitchToMasterResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchToMasterResponse>);
        }
        
        /// <summary>
        /// 容灾实例主降备
        ///
        /// 该接口用于对已经搭建容灾关系的实例，将主实例降级为备实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchToSlaveResponse> SwitchToSlaveAsync(SwitchToSlaveRequest switchToSlaveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchToSlaveRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switchover-slave", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchToSlaveRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SwitchToSlaveResponse>(response);
        }

        public AsyncInvoker<SwitchToSlaveResponse> SwitchToSlaveAsyncInvoker(SwitchToSlaveRequest switchToSlaveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchToSlaveRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switchover-slave", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchToSlaveRequest);
            return new AsyncInvoker<SwitchToSlaveResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchToSlaveResponse>);
        }
        
        /// <summary>
        /// 修改副本集跨网段访问配置
        ///
        /// 修改副本集跨网段访问配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateClientNetworkResponse> UpdateClientNetworkAsync(UpdateClientNetworkRequest updateClientNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateClientNetworkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/client-network", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClientNetworkRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateClientNetworkResponse>(response);
        }

        public AsyncInvoker<UpdateClientNetworkResponse> UpdateClientNetworkAsyncInvoker(UpdateClientNetworkRequest updateClientNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateClientNetworkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/client-network", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClientNetworkRequest);
            return new AsyncInvoker<UpdateClientNetworkResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateClientNetworkResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", updateConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateConfigurationResponse>(response);
        }

        public AsyncInvoker<UpdateConfigurationResponse> UpdateConfigurationAsyncInvoker(UpdateConfigurationRequest updateConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", updateConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigurationRequest);
            return new AsyncInvoker<UpdateConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateConfigurationResponse>);
        }
        
        /// <summary>
        /// 操作GeminDB实例数据库
        ///
        /// 操作GeminDB实例数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDatabasesResponse> UpdateDatabasesAsync(UpdateDatabasesRequest updateDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDatabasesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDatabasesResponse>(response);
        }

        public AsyncInvoker<UpdateDatabasesResponse> UpdateDatabasesAsyncInvoker(UpdateDatabasesRequest updateDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDatabasesRequest);
            return new AsyncInvoker<UpdateDatabasesResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDatabasesResponse>);
        }
        
        /// <summary>
        /// 修改内存加速规则
        ///
        /// 修改指定内存加速规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDbCacheRuleResponse> UpdateDbCacheRuleAsync(UpdateDbCacheRuleRequest updateDbCacheRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dbcache/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDbCacheRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDbCacheRuleResponse>(response);
        }

        public AsyncInvoker<UpdateDbCacheRuleResponse> UpdateDbCacheRuleAsyncInvoker(UpdateDbCacheRuleRequest updateDbCacheRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dbcache/rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDbCacheRuleRequest);
            return new AsyncInvoker<UpdateDbCacheRuleResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDbCacheRuleResponse>);
        }
        
        /// <summary>
        /// 修改高危命令
        ///
        /// 批量修改高危命令
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateHighRiskCommandsResponse> UpdateHighRiskCommandsAsync(UpdateHighRiskCommandsRequest updateHighRiskCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateHighRiskCommandsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/high-risk-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHighRiskCommandsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateHighRiskCommandsResponse>(response);
        }

        public AsyncInvoker<UpdateHighRiskCommandsResponse> UpdateHighRiskCommandsAsyncInvoker(UpdateHighRiskCommandsRequest updateHighRiskCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateHighRiskCommandsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/high-risk-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHighRiskCommandsRequest);
            return new AsyncInvoker<UpdateHighRiskCommandsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateHighRiskCommandsResponse>);
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
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceConfigurationResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceConfigurationResponse> UpdateInstanceConfigurationAsyncInvoker(UpdateInstanceConfigurationRequest updateInstanceConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConfigurationRequest);
            return new AsyncInvoker<UpdateInstanceConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceConfigurationResponse>);
        }
        
        /// <summary>
        /// 修改指定实例的参数
        ///
        /// 修改指定实例的参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceConfigurationsResponse> UpdateInstanceConfigurationsAsync(UpdateInstanceConfigurationsRequest updateInstanceConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceConfigurationsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConfigurationsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceConfigurationsResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceConfigurationsResponse> UpdateInstanceConfigurationsAsyncInvoker(UpdateInstanceConfigurationsRequest updateInstanceConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceConfigurationsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConfigurationsRequest);
            return new AsyncInvoker<UpdateInstanceConfigurationsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceConfigurationsResponse>);
        }
        
        /// <summary>
        /// 修改实例名称
        ///
        /// 修改实例名称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceNameResponse> UpdateInstanceNameAsync(UpdateInstanceNameRequest updateInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceNameRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceNameResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceNameResponse> UpdateInstanceNameAsyncInvoker(UpdateInstanceNameRequest updateInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceNameRequest);
            return new AsyncInvoker<UpdateInstanceNameResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceNameResponse>);
        }
        
        /// <summary>
        /// 支持修改GeminiDB Redis的免密配置
        ///
        /// 支持修改GeminiDB Redis的免密配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePasswordlessConfigResponse> UpdatePasswordlessConfigAsync(UpdatePasswordlessConfigRequest updatePasswordlessConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePasswordlessConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/passwordless-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePasswordlessConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePasswordlessConfigResponse>(response);
        }

        public AsyncInvoker<UpdatePasswordlessConfigResponse> UpdatePasswordlessConfigAsyncInvoker(UpdatePasswordlessConfigRequest updatePasswordlessConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePasswordlessConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/passwordless-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePasswordlessConfigRequest);
            return new AsyncInvoker<UpdatePasswordlessConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePasswordlessConfigResponse>);
        }
        
        /// <summary>
        /// 变更实例安全组
        ///
        /// 变更实例关联的安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSecurityGroupResponse> UpdateSecurityGroupAsync(UpdateSecurityGroupRequest updateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateSecurityGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecurityGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSecurityGroupResponse>(response);
        }

        public AsyncInvoker<UpdateSecurityGroupResponse> UpdateSecurityGroupAsyncInvoker(UpdateSecurityGroupRequest updateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateSecurityGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecurityGroupRequest);
            return new AsyncInvoker<UpdateSecurityGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 数据库补丁升级
        ///
        /// 升级数据库补丁版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpgradeDbVersionResponse> UpgradeDbVersionAsync(UpgradeDbVersionRequest upgradeDbVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeDbVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbVersionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpgradeDbVersionResponse>(response);
        }

        public AsyncInvoker<UpgradeDbVersionResponse> UpgradeDbVersionAsyncInvoker(UpgradeDbVersionRequest upgradeDbVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeDbVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbVersionRequest);
            return new AsyncInvoker<UpgradeDbVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeDbVersionResponse>);
        }
        
        /// <summary>
        /// 查询当前支持的API版本信息列表
        ///
        /// 查询当前支持的API版本信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApiVersionResponse> ListApiVersionAsync(ListApiVersionRequest listApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionResponse>(response);
        }

        public AsyncInvoker<ListApiVersionResponse> ListApiVersionAsyncInvoker(ListApiVersionRequest listApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionRequest);
            return new AsyncInvoker<ListApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionResponse>);
        }
        
        /// <summary>
        /// 查询指定API版本信息
        ///
        /// 查询指定API版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowApiVersionResponse> ShowApiVersionAsync(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", showApiVersionRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }

        public AsyncInvoker<ShowApiVersionResponse> ShowApiVersionAsyncInvoker(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", showApiVersionRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            return new AsyncInvoker<ShowApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApiVersionResponse>);
        }
        
    }
}