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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addPostgresqlHbaConfRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addPostgresqlHbaConfRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddPostgresqlHbaConfResponse>(response);
        }

        public AsyncInvoker<AddPostgresqlHbaConfResponse> AddPostgresqlHbaConfAsyncInvoker(AddPostgresqlHbaConfRequest addPostgresqlHbaConfRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addPostgresqlHbaConfRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addPostgresqlHbaConfRequest);
            return new AsyncInvoker<AddPostgresqlHbaConfResponse>(this, "POST", request, JsonUtils.DeSerialize<AddPostgresqlHbaConfResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(applyConfigurationAsyncRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyConfigurationAsyncRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ApplyConfigurationAsyncResponse>(response);
        }

        public AsyncInvoker<ApplyConfigurationAsyncResponse> ApplyConfigurationAsyncAsyncInvoker(ApplyConfigurationAsyncRequest applyConfigurationAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(applyConfigurationAsyncRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyConfigurationAsyncRequest);
            return new AsyncInvoker<ApplyConfigurationAsyncResponse>(this, "PUT", request, JsonUtils.DeSerialize<ApplyConfigurationAsyncResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachEipRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<AttachEipResponse>(response);
        }

        public AsyncInvoker<AttachEipResponse> AttachEipAsyncInvoker(AttachEipRequest attachEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachEipRequest);
            return new AsyncInvoker<AttachEipResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AttachEipResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteManualBackupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteManualBackupResponse>(response);
        }

        public AsyncInvoker<BatchDeleteManualBackupResponse> BatchDeleteManualBackupAsyncInvoker(BatchDeleteManualBackupRequest batchDeleteManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteManualBackupRequest);
            return new AsyncInvoker<BatchDeleteManualBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteManualBackupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/batch/restore/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestoreDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchRestoreDatabaseResponse>(response);
        }

        public AsyncInvoker<BatchRestoreDatabaseResponse> BatchRestoreDatabaseAsyncInvoker(BatchRestoreDatabaseRequest batchRestoreDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/batch/restore/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestoreDatabaseRequest);
            return new AsyncInvoker<BatchRestoreDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRestoreDatabaseResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/batch/restore/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestorePostgreSqlTablesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchRestorePostgreSqlTablesResponse>(response);
        }

        public AsyncInvoker<BatchRestorePostgreSqlTablesResponse> BatchRestorePostgreSqlTablesAsyncInvoker(BatchRestorePostgreSqlTablesRequest batchRestorePostgreSqlTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/batch/restore/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestorePostgreSqlTablesRequest);
            return new AsyncInvoker<BatchRestorePostgreSqlTablesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRestorePostgreSqlTablesResponse>);
        }
        
        /// <summary>
        /// 批量停止实例
        ///
        /// 批量停止实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchStopInstanceResponse> BatchStopInstanceAsync(BatchStopInstanceRequest batchStopInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/batch/action/shutdown", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStopInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchStopInstanceResponse>(response);
        }

        public AsyncInvoker<BatchStopInstanceResponse> BatchStopInstanceAsyncInvoker(BatchStopInstanceRequest batchStopInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/batch/action/shutdown", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStopInstanceRequest);
            return new AsyncInvoker<BatchStopInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchStopInstanceResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchTagAddActionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagAddActionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchTagAddActionResponse>(response);
        }

        public AsyncInvoker<BatchTagAddActionResponse> BatchTagAddActionAsyncInvoker(BatchTagAddActionRequest batchTagAddActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchTagAddActionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagAddActionRequest);
            return new AsyncInvoker<BatchTagAddActionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchTagAddActionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchTagDelActionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagDelActionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchTagDelActionResponse>(response);
        }

        public AsyncInvoker<BatchTagDelActionResponse> BatchTagDelActionAsyncInvoker(BatchTagDelActionRequest batchTagDelActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchTagDelActionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagDelActionRequest);
            return new AsyncInvoker<BatchTagDelActionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchTagDelActionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeFailoverModeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/failover/mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeFailoverModeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ChangeFailoverModeResponse>(response);
        }

        public AsyncInvoker<ChangeFailoverModeResponse> ChangeFailoverModeAsyncInvoker(ChangeFailoverModeRequest changeFailoverModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeFailoverModeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/failover/mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeFailoverModeRequest);
            return new AsyncInvoker<ChangeFailoverModeResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeFailoverModeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeFailoverStrategyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/failover/strategy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeFailoverStrategyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<ChangeFailoverStrategyResponse>(response);
        }

        public AsyncInvoker<ChangeFailoverStrategyResponse> ChangeFailoverStrategyAsyncInvoker(ChangeFailoverStrategyRequest changeFailoverStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeFailoverStrategyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/failover/strategy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeFailoverStrategyRequest);
            return new AsyncInvoker<ChangeFailoverStrategyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ChangeFailoverStrategyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeOpsWindowRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ops-window", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeOpsWindowRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<ChangeOpsWindowResponse>(response);
        }

        public AsyncInvoker<ChangeOpsWindowResponse> ChangeOpsWindowAsyncInvoker(ChangeOpsWindowRequest changeOpsWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeOpsWindowRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ops-window", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeOpsWindowRequest);
            return new AsyncInvoker<ChangeOpsWindowResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ChangeOpsWindowResponse>);
        }
        
        /// <summary>
        /// 大版本升级预检查
        ///
        /// 提供mysql5.7升级mysql8.0预检查接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckInstanceForUpgradeResponse> CheckInstanceForUpgradeAsync(CheckInstanceForUpgradeRequest checkInstanceForUpgradeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkInstanceForUpgradeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/upgrade-version/precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkInstanceForUpgradeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<CheckInstanceForUpgradeResponse>(response);
        }

        public AsyncInvoker<CheckInstanceForUpgradeResponse> CheckInstanceForUpgradeAsyncInvoker(CheckInstanceForUpgradeRequest checkInstanceForUpgradeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkInstanceForUpgradeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/upgrade-version/precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkInstanceForUpgradeRequest);
            return new AsyncInvoker<CheckInstanceForUpgradeResponse>(this, "PUT", request, JsonUtils.DeSerialize<CheckInstanceForUpgradeResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(copyConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyConfigurationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CopyConfigurationResponse>(response);
        }

        public AsyncInvoker<CopyConfigurationResponse> CopyConfigurationAsyncInvoker(CopyConfigurationRequest copyConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(copyConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyConfigurationRequest);
            return new AsyncInvoker<CopyConfigurationResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyConfigurationResponse>);
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
        /// 申请域名
        ///
        /// 申请域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDnsNameResponse> CreateDnsNameAsync(CreateDnsNameRequest createDnsNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDnsNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/create-dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDnsNameRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDnsNameResponse>(response);
        }

        public AsyncInvoker<CreateDnsNameResponse> CreateDnsNameAsyncInvoker(CreateDnsNameRequest createDnsNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDnsNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/create-dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDnsNameRequest);
            return new AsyncInvoker<CreateDnsNameResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDnsNameResponse>);
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
        /// 创建数据库实例V5接口，仅支持IAM5的新平面认证方式（AK/SK认证方式）
        ///
        /// 创建数据库实例V5接口，仅支持IAM5的新平面认证方式（AK/SK认证方式）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceIam5Response> CreateInstanceIam5Async(CreateInstanceIam5Request createInstanceIam5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceIam5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceIam5Response>(response);
        }

        public AsyncInvoker<CreateInstanceIam5Response> CreateInstanceIam5AsyncInvoker(CreateInstanceIam5Request createInstanceIam5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceIam5Request);
            return new AsyncInvoker<CreateInstanceIam5Response>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceIam5Response>);
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
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createManualBackupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateManualBackupResponse>(response);
        }

        public AsyncInvoker<CreateManualBackupResponse> CreateManualBackupAsyncInvoker(CreateManualBackupRequest createManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createManualBackupRequest);
            return new AsyncInvoker<CreateManualBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateManualBackupResponse>);
        }
        
        /// <summary>
        /// 开启数据库代理
        ///
        /// 开启数据库代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRdSforMySqlProxyResponse> CreateRdSforMySqlProxyAsync(CreateRdSforMySqlProxyRequest createRdSforMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRdSforMySqlProxyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/open", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRdSforMySqlProxyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRdSforMySqlProxyResponse>(response);
        }

        public AsyncInvoker<CreateRdSforMySqlProxyResponse> CreateRdSforMySqlProxyAsyncInvoker(CreateRdSforMySqlProxyRequest createRdSforMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRdSforMySqlProxyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/open", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRdSforMySqlProxyRequest);
            return new AsyncInvoker<CreateRdSforMySqlProxyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRdSforMySqlProxyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRestoreInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRestoreInstanceResponse>(response);
        }

        public AsyncInvoker<CreateRestoreInstanceResponse> CreateRestoreInstanceAsyncInvoker(CreateRestoreInstanceRequest createRestoreInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRestoreInstanceRequest);
            return new AsyncInvoker<CreateRestoreInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRestoreInstanceResponse>);
        }
        
        /// <summary>
        /// 新增SQL限流
        ///
        /// 新增SQL限流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSqlLimitResponse> CreateSqlLimitAsync(CreateSqlLimitRequest createSqlLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSqlLimitRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-limit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSqlLimitRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSqlLimitResponse>(response);
        }

        public AsyncInvoker<CreateSqlLimitResponse> CreateSqlLimitAsyncInvoker(CreateSqlLimitRequest createSqlLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSqlLimitRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-limit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSqlLimitRequest);
            return new AsyncInvoker<CreateSqlLimitResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSqlLimitResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createXelLogDownloadRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/xellog-download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createXelLogDownloadRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateXelLogDownloadResponse>(response);
        }

        public AsyncInvoker<CreateXelLogDownloadResponse> CreateXelLogDownloadAsyncInvoker(CreateXelLogDownloadRequest createXelLogDownloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createXelLogDownloadRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/xellog-download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createXelLogDownloadRequest);
            return new AsyncInvoker<CreateXelLogDownloadResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateXelLogDownloadResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigurationRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteConfigurationResponse>(response);
        }

        public AsyncInvoker<DeleteConfigurationResponse> DeleteConfigurationAsyncInvoker(DeleteConfigurationRequest deleteConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigurationRequest);
            return new AsyncInvoker<DeleteConfigurationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteConfigurationResponse>);
        }
        
        /// <summary>
        /// 解除实例容灾关系接口
        ///
        /// 解除实例容灾关系接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDisasterRecoveryResponse> DeleteDisasterRecoveryAsync(DeleteDisasterRecoveryRequest deleteDisasterRecoveryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDisasterRecoveryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/delete-disaster-recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDisasterRecoveryRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDisasterRecoveryResponse>(response);
        }

        public AsyncInvoker<DeleteDisasterRecoveryResponse> DeleteDisasterRecoveryAsyncInvoker(DeleteDisasterRecoveryRequest deleteDisasterRecoveryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDisasterRecoveryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/delete-disaster-recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDisasterRecoveryRequest);
            return new AsyncInvoker<DeleteDisasterRecoveryResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDisasterRecoveryResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInstanceResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceResponse> DeleteInstanceAsyncInvoker(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            return new AsyncInvoker<DeleteInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteInstanceResponse>);
        }
        
        /// <summary>
        /// 删除即时任务
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest deleteJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJobRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteJobResponse>(response);
        }

        public AsyncInvoker<DeleteJobResponse> DeleteJobAsyncInvoker(DeleteJobRequest deleteJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJobRequest);
            return new AsyncInvoker<DeleteJobResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteJobResponse>);
        }
        
        /// <summary>
        /// 解除LTS配置信息
        ///
        /// 解除LTS配置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLogLtsConfigsResponse> DeleteLogLtsConfigsAsync(DeleteLogLtsConfigsRequest deleteLogLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLogLtsConfigsRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{engine}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogLtsConfigsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLogLtsConfigsResponse>(response);
        }

        public AsyncInvoker<DeleteLogLtsConfigsResponse> DeleteLogLtsConfigsAsyncInvoker(DeleteLogLtsConfigsRequest deleteLogLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLogLtsConfigsRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{engine}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogLtsConfigsRequest);
            return new AsyncInvoker<DeleteLogLtsConfigsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLogLtsConfigsResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteManualBackupRequest.BackupId, out var valueOfBackupId)) urlParam.Add("backup_id", valueOfBackupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteManualBackupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteManualBackupResponse>(response);
        }

        public AsyncInvoker<DeleteManualBackupResponse> DeleteManualBackupAsyncInvoker(DeleteManualBackupRequest deleteManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteManualBackupRequest.BackupId, out var valueOfBackupId)) urlParam.Add("backup_id", valueOfBackupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteManualBackupRequest);
            return new AsyncInvoker<DeleteManualBackupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteManualBackupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePostgresqlHbaConfRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePostgresqlHbaConfRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePostgresqlHbaConfResponse>(response);
        }

        public AsyncInvoker<DeletePostgresqlHbaConfResponse> DeletePostgresqlHbaConfAsyncInvoker(DeletePostgresqlHbaConfRequest deletePostgresqlHbaConfRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePostgresqlHbaConfRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePostgresqlHbaConfRequest);
            return new AsyncInvoker<DeletePostgresqlHbaConfResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePostgresqlHbaConfResponse>);
        }
        
        /// <summary>
        /// 关闭数据库代理
        ///
        /// 关闭数据库代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRdSforMySqlProxyResponse> DeleteRdSforMySqlProxyAsync(DeleteRdSforMySqlProxyRequest deleteRdSforMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRdSforMySqlProxyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteRdSforMySqlProxyRequest.ProxyId, out var valueOfProxyId)) urlParam.Add("proxy_id", valueOfProxyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRdSforMySqlProxyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteRdSforMySqlProxyResponse>(response);
        }

        public AsyncInvoker<DeleteRdSforMySqlProxyResponse> DeleteRdSforMySqlProxyAsyncInvoker(DeleteRdSforMySqlProxyRequest deleteRdSforMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRdSforMySqlProxyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteRdSforMySqlProxyRequest.ProxyId, out var valueOfProxyId)) urlParam.Add("proxy_id", valueOfProxyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRdSforMySqlProxyRequest);
            return new AsyncInvoker<DeleteRdSforMySqlProxyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteRdSforMySqlProxyResponse>);
        }
        
        /// <summary>
        /// 删除SQL限流
        ///
        /// 删除SQL限流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSqlLimitResponse> DeleteSqlLimitAsync(DeleteSqlLimitRequest deleteSqlLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSqlLimitRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-limit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlLimitRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSqlLimitResponse>(response);
        }

        public AsyncInvoker<DeleteSqlLimitResponse> DeleteSqlLimitAsyncInvoker(DeleteSqlLimitRequest deleteSqlLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSqlLimitRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-limit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlLimitRequest);
            return new AsyncInvoker<DeleteSqlLimitResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSqlLimitResponse>);
        }
        
        /// <summary>
        /// 获取错误日志下载链接
        ///
        /// 获取错误日志下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadErrorlogResponse> DownloadErrorlogAsync(DownloadErrorlogRequest downloadErrorlogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadErrorlogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/errorlog-download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadErrorlogRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DownloadErrorlogResponse>(response);
        }

        public AsyncInvoker<DownloadErrorlogResponse> DownloadErrorlogAsyncInvoker(DownloadErrorlogRequest downloadErrorlogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadErrorlogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/errorlog-download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadErrorlogRequest);
            return new AsyncInvoker<DownloadErrorlogResponse>(this, "POST", request, JsonUtils.DeSerialize<DownloadErrorlogResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadSlowlogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSlowlogRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DownloadSlowlogResponse>(response);
        }

        public AsyncInvoker<DownloadSlowlogResponse> DownloadSlowlogAsyncInvoker(DownloadSlowlogRequest downloadSlowlogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadSlowlogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSlowlogRequest);
            return new AsyncInvoker<DownloadSlowlogResponse>(this, "POST", request, JsonUtils.DeSerialize<DownloadSlowlogResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<EnableConfigurationResponse>(response);
        }

        public AsyncInvoker<EnableConfigurationResponse> EnableConfigurationAsyncInvoker(EnableConfigurationRequest enableConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableConfigurationRequest);
            return new AsyncInvoker<EnableConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<EnableConfigurationResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditlogsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditlogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditlogsResponse>(response);
        }

        public AsyncInvoker<ListAuditlogsResponse> ListAuditlogsAsyncInvoker(ListAuditlogsRequest listAuditlogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditlogsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditlogsRequest);
            return new AsyncInvoker<ListAuditlogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditlogsResponse>);
        }
        
        /// <summary>
        /// 查询转储任务列表
        ///
        /// 查询转储任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBackupTransfersResponse> ListBackupTransfersAsync(ListBackupTransfersRequest listBackupTransfersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transfer-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupTransfersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBackupTransfersResponse>(response);
        }

        public AsyncInvoker<ListBackupTransfersResponse> ListBackupTransfersAsyncInvoker(ListBackupTransfersRequest listBackupTransfersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transfer-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupTransfersRequest);
            return new AsyncInvoker<ListBackupTransfersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBackupTransfersResponse>);
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
        /// 查询SQLServer可用字符集
        ///
        /// 查询SQLServer可用字符集
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCollationsResponse> ListCollationsAsync(ListCollationsRequest listCollationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/collations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCollationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCollationsResponse>(response);
        }

        public AsyncInvoker<ListCollationsResponse> ListCollationsAsyncInvoker(ListCollationsRequest listCollationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/collations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCollationsRequest);
            return new AsyncInvoker<ListCollationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCollationsResponse>);
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
        /// 查询数据库引擎的版本
        ///
        /// 查询数据库引擎的版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDatastoresResponse> ListDatastoresAsync(ListDatastoresRequest listDatastoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDatastoresRequest.DatabaseName, out var valueOfDatabaseName)) urlParam.Add("database_name", valueOfDatabaseName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoresRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDatastoresResponse>(response);
        }

        public AsyncInvoker<ListDatastoresResponse> ListDatastoresAsyncInvoker(ListDatastoresRequest listDatastoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDatastoresRequest.DatabaseName, out var valueOfDatabaseName)) urlParam.Add("database_name", valueOfDatabaseName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoresRequest);
            return new AsyncInvoker<ListDatastoresResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatastoresResponse>);
        }
        
        /// <summary>
        /// 查询容灾管理列表
        ///
        /// 查询容灾管理列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDrInfosResponse> ListDrInfosAsync(ListDrInfosRequest listDrInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/disaster-recovery-infos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDrInfosRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListDrInfosResponse>(response);
        }

        public AsyncInvoker<ListDrInfosResponse> ListDrInfosAsyncInvoker(ListDrInfosRequest listDrInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/disaster-recovery-infos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDrInfosRequest);
            return new AsyncInvoker<ListDrInfosResponse>(this, "POST", request, JsonUtils.DeSerialize<ListDrInfosResponse>);
        }
        
        /// <summary>
        /// 批量查询容灾实例信息
        ///
        /// 批量查询容灾实例信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDrRelationsResponse> ListDrRelationsAsync(ListDrRelationsRequest listDrRelationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/disaster-recovery-relation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDrRelationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDrRelationsResponse>(response);
        }

        public AsyncInvoker<ListDrRelationsResponse> ListDrRelationsAsyncInvoker(ListDrRelationsRequest listDrRelationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/disaster-recovery-relation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDrRelationsRequest);
            return new AsyncInvoker<ListDrRelationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDrRelationsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEngineFlavorsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/available-flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEngineFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEngineFlavorsResponse>(response);
        }

        public AsyncInvoker<ListEngineFlavorsResponse> ListEngineFlavorsAsyncInvoker(ListEngineFlavorsRequest listEngineFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEngineFlavorsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/available-flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEngineFlavorsRequest);
            return new AsyncInvoker<ListEngineFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEngineFlavorsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listErrorLogsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/errorlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listErrorLogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListErrorLogsResponse>(response);
        }

        public AsyncInvoker<ListErrorLogsResponse> ListErrorLogsAsyncInvoker(ListErrorLogsRequest listErrorLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listErrorLogsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/errorlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listErrorLogsRequest);
            return new AsyncInvoker<ListErrorLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListErrorLogsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listErrorLogsNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/errorlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listErrorLogsNewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListErrorLogsNewResponse>(response);
        }

        public AsyncInvoker<ListErrorLogsNewResponse> ListErrorLogsNewAsyncInvoker(ListErrorLogsNewRequest listErrorLogsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listErrorLogsNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/errorlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listErrorLogsNewRequest);
            return new AsyncInvoker<ListErrorLogsNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListErrorLogsNewResponse>);
        }
        
        /// <summary>
        /// 查询实例的错误日志数据
        ///
        /// 查询实例的错误日志数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListErrorlogForLtsResponse> ListErrorlogForLtsAsync(ListErrorlogForLtsRequest listErrorlogForLtsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listErrorlogForLtsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listErrorlogForLtsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListErrorlogForLtsResponse>(response);
        }

        public AsyncInvoker<ListErrorlogForLtsResponse> ListErrorlogForLtsAsyncInvoker(ListErrorlogForLtsRequest listErrorlogForLtsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listErrorlogForLtsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listErrorlogForLtsRequest);
            return new AsyncInvoker<ListErrorlogForLtsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListErrorlogForLtsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFlavorsRequest.DatabaseName, out var valueOfDatabaseName)) urlParam.Add("database_name", valueOfDatabaseName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }

        public AsyncInvoker<ListFlavorsResponse> ListFlavorsAsyncInvoker(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFlavorsRequest.DatabaseName, out var valueOfDatabaseName)) urlParam.Add("database_name", valueOfDatabaseName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            return new AsyncInvoker<ListFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询数据库可变更规格接口
        ///
        /// 查询数据库可变更规格接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFlavorsResizeResponse> ListFlavorsResizeAsync(ListFlavorsResizeRequest listFlavorsResizeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFlavorsResizeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/flavors-resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsResizeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorsResizeResponse>(response);
        }

        public AsyncInvoker<ListFlavorsResizeResponse> ListFlavorsResizeAsyncInvoker(ListFlavorsResizeRequest listFlavorsResizeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFlavorsResizeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/flavors-resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsResizeRequest);
            return new AsyncInvoker<ListFlavorsResizeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorsResizeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHistoryDatabaseRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{engine}/instances/history/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListHistoryDatabaseResponse>(response);
        }

        public AsyncInvoker<ListHistoryDatabaseResponse> ListHistoryDatabaseAsyncInvoker(ListHistoryDatabaseRequest listHistoryDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHistoryDatabaseRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{engine}/instances/history/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryDatabaseRequest);
            return new AsyncInvoker<ListHistoryDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<ListHistoryDatabaseResponse>);
        }
        
        /// <summary>
        /// 查询实例大版本升级检查历史
        ///
        /// 查询实例大版本升级检查历史。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInspectionHistoriesResponse> ListInspectionHistoriesAsync(ListInspectionHistoriesRequest listInspectionHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInspectionHistoriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/inspection-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInspectionHistoriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInspectionHistoriesResponse>(response);
        }

        public AsyncInvoker<ListInspectionHistoriesResponse> ListInspectionHistoriesAsyncInvoker(ListInspectionHistoriesRequest listInspectionHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInspectionHistoriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/inspection-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInspectionHistoriesRequest);
            return new AsyncInvoker<ListInspectionHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInspectionHistoriesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/diagnosis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceDiagnosisRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceDiagnosisResponse>(response);
        }

        public AsyncInvoker<ListInstanceDiagnosisResponse> ListInstanceDiagnosisAsyncInvoker(ListInstanceDiagnosisRequest listInstanceDiagnosisRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/diagnosis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceDiagnosisRequest);
            return new AsyncInvoker<ListInstanceDiagnosisResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceDiagnosisResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceParamHistoriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configuration-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceParamHistoriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceParamHistoriesResponse>(response);
        }

        public AsyncInvoker<ListInstanceParamHistoriesResponse> ListInstanceParamHistoriesAsyncInvoker(ListInstanceParamHistoriesRequest listInstanceParamHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceParamHistoriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configuration-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceParamHistoriesRequest);
            return new AsyncInvoker<ListInstanceParamHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceParamHistoriesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceTagsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceTagsResponse>(response);
        }

        public AsyncInvoker<ListInstanceTagsResponse> ListInstanceTagsAsyncInvoker(ListInstanceTagsRequest listInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceTagsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTagsRequest);
            return new AsyncInvoker<ListInstanceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceTagsResponse>);
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
        /// 获取指定诊断项的诊断结果
        ///
        /// 获取指定诊断项的诊断结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesInfoDiagnosisResponse> ListInstancesInfoDiagnosisAsync(ListInstancesInfoDiagnosisRequest listInstancesInfoDiagnosisRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/diagnosis/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesInfoDiagnosisRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesInfoDiagnosisResponse>(response);
        }

        public AsyncInvoker<ListInstancesInfoDiagnosisResponse> ListInstancesInfoDiagnosisAsyncInvoker(ListInstancesInfoDiagnosisRequest listInstancesInfoDiagnosisRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/diagnosis/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesInfoDiagnosisRequest);
            return new AsyncInvoker<ListInstancesInfoDiagnosisResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesInfoDiagnosisResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/fast-restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesSupportFastRestoreRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListInstancesSupportFastRestoreResponse>(response);
        }

        public AsyncInvoker<ListInstancesSupportFastRestoreResponse> ListInstancesSupportFastRestoreAsyncInvoker(ListInstancesSupportFastRestoreRequest listInstancesSupportFastRestoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/fast-restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesSupportFastRestoreRequest);
            return new AsyncInvoker<ListInstancesSupportFastRestoreResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInstancesSupportFastRestoreResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListJobInfoResponse>(response);
        }

        public AsyncInvoker<ListJobInfoResponse> ListJobInfoAsyncInvoker(ListJobInfoRequest listJobInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobInfoRequest);
            return new AsyncInvoker<ListJobInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobInfoResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listJobInfoDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tasklist/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobInfoDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListJobInfoDetailResponse>(response);
        }

        public AsyncInvoker<ListJobInfoDetailResponse> ListJobInfoDetailAsyncInvoker(ListJobInfoDetailRequest listJobInfoDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listJobInfoDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tasklist/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobInfoDetailRequest);
            return new AsyncInvoker<ListJobInfoDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobInfoDetailResponse>);
        }
        
        /// <summary>
        /// 获取LTS配置信息
        ///
        /// 获取LTS配置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLogLtsConfigsResponse> ListLogLtsConfigsAsync(ListLogLtsConfigsRequest listLogLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLogLtsConfigsRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{engine}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogLtsConfigsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLogLtsConfigsResponse>(response);
        }

        public AsyncInvoker<ListLogLtsConfigsResponse> ListLogLtsConfigsAsyncInvoker(ListLogLtsConfigsRequest listLogLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLogLtsConfigsRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{engine}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogLtsConfigsRequest);
            return new AsyncInvoker<ListLogLtsConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLogLtsConfigsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/offsite-backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOffSiteBackupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOffSiteBackupsResponse>(response);
        }

        public AsyncInvoker<ListOffSiteBackupsResponse> ListOffSiteBackupsAsyncInvoker(ListOffSiteBackupsRequest listOffSiteBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/offsite-backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOffSiteBackupsRequest);
            return new AsyncInvoker<ListOffSiteBackupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOffSiteBackupsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/backups/offsite-backup-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOffSiteInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOffSiteInstancesResponse>(response);
        }

        public AsyncInvoker<ListOffSiteInstancesResponse> ListOffSiteInstancesAsyncInvoker(ListOffSiteInstancesRequest listOffSiteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/backups/offsite-backup-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOffSiteInstancesRequest);
            return new AsyncInvoker<ListOffSiteInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOffSiteInstancesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOffSiteRestoreTimesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/offsite-restore-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOffSiteRestoreTimesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOffSiteRestoreTimesResponse>(response);
        }

        public AsyncInvoker<ListOffSiteRestoreTimesResponse> ListOffSiteRestoreTimesAsyncInvoker(ListOffSiteRestoreTimesRequest listOffSiteRestoreTimesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOffSiteRestoreTimesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/offsite-restore-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOffSiteRestoreTimesRequest);
            return new AsyncInvoker<ListOffSiteRestoreTimesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOffSiteRestoreTimesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPostgresqlHbaInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlHbaInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listPostgresqlHbaInfoResponse = JsonUtils.DeSerializeNull<ListPostgresqlHbaInfoResponse>(response);
            listPostgresqlHbaInfoResponse.Body = JsonUtils.DeSerializeList<PostgresqlHbaConf>(response);
            return listPostgresqlHbaInfoResponse;
        }

        public AsyncInvoker<ListPostgresqlHbaInfoResponse> ListPostgresqlHbaInfoAsyncInvoker(ListPostgresqlHbaInfoRequest listPostgresqlHbaInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPostgresqlHbaInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlHbaInfoRequest);
            return new AsyncInvoker<ListPostgresqlHbaInfoResponse>(this, "GET", request, response =>
            {
                var listPostgresqlHbaInfoResponse = JsonUtils.DeSerializeNull<ListPostgresqlHbaInfoResponse>(response);
                listPostgresqlHbaInfoResponse.Body = JsonUtils.DeSerializeList<PostgresqlHbaConf>(response);
                return listPostgresqlHbaInfoResponse;
            });
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPostgresqlHbaInfoHistoryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlHbaInfoHistoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listPostgresqlHbaInfoHistoryResponse = JsonUtils.DeSerializeNull<ListPostgresqlHbaInfoHistoryResponse>(response);
            listPostgresqlHbaInfoHistoryResponse.Body = JsonUtils.DeSerializeList<PostgresqlHbaHistory>(response);
            return listPostgresqlHbaInfoHistoryResponse;
        }

        public AsyncInvoker<ListPostgresqlHbaInfoHistoryResponse> ListPostgresqlHbaInfoHistoryAsyncInvoker(ListPostgresqlHbaInfoHistoryRequest listPostgresqlHbaInfoHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPostgresqlHbaInfoHistoryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlHbaInfoHistoryRequest);
            return new AsyncInvoker<ListPostgresqlHbaInfoHistoryResponse>(this, "GET", request, response =>
            {
                var listPostgresqlHbaInfoHistoryResponse = JsonUtils.DeSerializeNull<ListPostgresqlHbaInfoHistoryResponse>(response);
                listPostgresqlHbaInfoHistoryResponse.Body = JsonUtils.DeSerializeList<PostgresqlHbaHistory>(response);
                return listPostgresqlHbaInfoHistoryResponse;
            });
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPostgresqlListHistoryTablesRequest.DatabaseName, out var valueOfDatabaseName)) urlParam.Add("database_name", valueOfDatabaseName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{database_name}/instances/history/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlListHistoryTablesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListPostgresqlListHistoryTablesResponse>(response);
        }

        public AsyncInvoker<ListPostgresqlListHistoryTablesResponse> ListPostgresqlListHistoryTablesAsyncInvoker(ListPostgresqlListHistoryTablesRequest listPostgresqlListHistoryTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPostgresqlListHistoryTablesRequest.DatabaseName, out var valueOfDatabaseName)) urlParam.Add("database_name", valueOfDatabaseName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{database_name}/instances/history/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlListHistoryTablesRequest);
            return new AsyncInvoker<ListPostgresqlListHistoryTablesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListPostgresqlListHistoryTablesResponse>);
        }
        
        /// <summary>
        /// 查询预定义标签
        ///
        /// 查询预定义标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPredefinedTagResponse> ListPredefinedTagAsync(ListPredefinedTagRequest listPredefinedTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tags/predefined-tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPredefinedTagRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPredefinedTagResponse>(response);
        }

        public AsyncInvoker<ListPredefinedTagResponse> ListPredefinedTagAsyncInvoker(ListPredefinedTagRequest listPredefinedTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tags/predefined-tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPredefinedTagRequest);
            return new AsyncInvoker<ListPredefinedTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPredefinedTagResponse>);
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
        /// 查询数据库代理信息列表
        ///
        /// 查询数据库代理信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRdSforMySqlProxyResponse> ListRdSforMySqlProxyAsync(ListRdSforMySqlProxyRequest listRdSforMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRdSforMySqlProxyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRdSforMySqlProxyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRdSforMySqlProxyResponse>(response);
        }

        public AsyncInvoker<ListRdSforMySqlProxyResponse> ListRdSforMySqlProxyAsyncInvoker(ListRdSforMySqlProxyRequest listRdSforMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRdSforMySqlProxyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRdSforMySqlProxyRequest);
            return new AsyncInvoker<ListRdSforMySqlProxyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRdSforMySqlProxyResponse>);
        }
        
        /// <summary>
        /// 查询数据库代理规格信息
        ///
        /// 查询数据库代理规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRdSforMysqlProxyFlavorsResponse> ListRdSforMysqlProxyFlavorsAsync(ListRdSforMysqlProxyFlavorsRequest listRdSforMysqlProxyFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRdSforMysqlProxyFlavorsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRdSforMysqlProxyFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRdSforMysqlProxyFlavorsResponse>(response);
        }

        public AsyncInvoker<ListRdSforMysqlProxyFlavorsResponse> ListRdSforMysqlProxyFlavorsAsyncInvoker(ListRdSforMysqlProxyFlavorsRequest listRdSforMysqlProxyFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRdSforMysqlProxyFlavorsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRdSforMysqlProxyFlavorsRequest);
            return new AsyncInvoker<ListRdSforMysqlProxyFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRdSforMysqlProxyFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询只读实例可恢复到主实例的库
        ///
        /// 查询只读实例可恢复到主实例的库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListReadOnlyReplayDatabaseResponse> ListReadOnlyReplayDatabaseAsync(ListReadOnlyReplayDatabaseRequest listReadOnlyReplayDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listReadOnlyReplayDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/log-replay/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReadOnlyReplayDatabaseRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListReadOnlyReplayDatabaseResponse>(response);
        }

        public AsyncInvoker<ListReadOnlyReplayDatabaseResponse> ListReadOnlyReplayDatabaseAsyncInvoker(ListReadOnlyReplayDatabaseRequest listReadOnlyReplayDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listReadOnlyReplayDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/log-replay/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReadOnlyReplayDatabaseRequest);
            return new AsyncInvoker<ListReadOnlyReplayDatabaseResponse>(this, "GET", request, JsonUtils.DeSerialize<ListReadOnlyReplayDatabaseResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(listRestoreTimesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTimesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRestoreTimesResponse>(response);
        }

        public AsyncInvoker<ListRestoreTimesResponse> ListRestoreTimesAsyncInvoker(ListRestoreTimesRequest listRestoreTimesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRestoreTimesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTimesRequest);
            return new AsyncInvoker<ListRestoreTimesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestoreTimesResponse>);
        }
        
        /// <summary>
        /// 查询定时任务列表
        ///
        /// 查询定时任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScheduleTasksResponse> ListScheduleTasksAsync(ListScheduleTasksRequest listScheduleTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/schedule-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduleTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListScheduleTasksResponse>(response);
        }

        public AsyncInvoker<ListScheduleTasksResponse> ListScheduleTasksAsyncInvoker(ListScheduleTasksRequest listScheduleTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/schedule-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduleTasksRequest);
            return new AsyncInvoker<ListScheduleTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScheduleTasksResponse>);
        }
        
        /// <summary>
        /// 查询共享备份列表
        ///
        /// 查询共享备份列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListShareBackupsResponse> ListShareBackupsAsync(ListShareBackupsRequest listShareBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/share-backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listShareBackupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListShareBackupsResponse>(response);
        }

        public AsyncInvoker<ListShareBackupsResponse> ListShareBackupsAsyncInvoker(ListShareBackupsRequest listShareBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/share-backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listShareBackupsRequest);
            return new AsyncInvoker<ListShareBackupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListShareBackupsResponse>);
        }
        
        /// <summary>
        /// 获取指定实例详情
        ///
        /// 获取指定实例详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSimplifiedInstancesResponse> ListSimplifiedInstancesAsync(ListSimplifiedInstancesRequest listSimplifiedInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/simplified-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSimplifiedInstancesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListSimplifiedInstancesResponse>(response);
        }

        public AsyncInvoker<ListSimplifiedInstancesResponse> ListSimplifiedInstancesAsyncInvoker(ListSimplifiedInstancesRequest listSimplifiedInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/simplified-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSimplifiedInstancesRequest);
            return new AsyncInvoker<ListSimplifiedInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSimplifiedInstancesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowLogFileRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogFileRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSlowLogFileResponse>(response);
        }

        public AsyncInvoker<ListSlowLogFileResponse> ListSlowLogFileAsyncInvoker(ListSlowLogFileRequest listSlowLogFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowLogFileRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogFileRequest);
            return new AsyncInvoker<ListSlowLogFileResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSlowLogFileResponse>);
        }
        
        /// <summary>
        /// 查询实例慢日志的统计数据
        ///
        /// 查询实例慢日志的统计数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSlowLogStatisticsForLtsResponse> ListSlowLogStatisticsForLtsAsync(ListSlowLogStatisticsForLtsRequest listSlowLogStatisticsForLtsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowLogStatisticsForLtsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/slow-logs/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogStatisticsForLtsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListSlowLogStatisticsForLtsResponse>(response);
        }

        public AsyncInvoker<ListSlowLogStatisticsForLtsResponse> ListSlowLogStatisticsForLtsAsyncInvoker(ListSlowLogStatisticsForLtsRequest listSlowLogStatisticsForLtsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowLogStatisticsForLtsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/slow-logs/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogStatisticsForLtsRequest);
            return new AsyncInvoker<ListSlowLogStatisticsForLtsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSlowLogStatisticsForLtsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowLogsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSlowLogsResponse>(response);
        }

        public AsyncInvoker<ListSlowLogsResponse> ListSlowLogsAsyncInvoker(ListSlowLogsRequest listSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowLogsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsRequest);
            return new AsyncInvoker<ListSlowLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSlowLogsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowLogsNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsNewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSlowLogsNewResponse>(response);
        }

        public AsyncInvoker<ListSlowLogsNewResponse> ListSlowLogsNewAsyncInvoker(ListSlowLogsNewRequest listSlowLogsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowLogsNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsNewRequest);
            return new AsyncInvoker<ListSlowLogsNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSlowLogsNewResponse>);
        }
        
        /// <summary>
        /// 查询实例的慢日志数据
        ///
        /// 查询实例的慢日志数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSlowlogForLtsResponse> ListSlowlogForLtsAsync(ListSlowlogForLtsRequest listSlowlogForLtsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowlogForLtsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowlogForLtsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListSlowlogForLtsResponse>(response);
        }

        public AsyncInvoker<ListSlowlogForLtsResponse> ListSlowlogForLtsAsyncInvoker(ListSlowlogForLtsRequest listSlowlogForLtsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowlogForLtsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowlogForLtsRequest);
            return new AsyncInvoker<ListSlowlogForLtsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSlowlogForLtsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowlogStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowlogStatisticsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSlowlogStatisticsResponse>(response);
        }

        public AsyncInvoker<ListSlowlogStatisticsResponse> ListSlowlogStatisticsAsyncInvoker(ListSlowlogStatisticsRequest listSlowlogStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowlogStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowlogStatisticsRequest);
            return new AsyncInvoker<ListSlowlogStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSlowlogStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询SQL限流列表
        ///
        /// 查询SQL限流列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSqlLimitResponse> ListSqlLimitAsync(ListSqlLimitRequest listSqlLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlLimitRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-limit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlLimitRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSqlLimitResponse>(response);
        }

        public AsyncInvoker<ListSqlLimitResponse> ListSqlLimitAsyncInvoker(ListSqlLimitRequest listSqlLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlLimitRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-limit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlLimitRequest);
            return new AsyncInvoker<ListSqlLimitResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSqlLimitResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSslCertDownloadLinkRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-cert/download-link", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSslCertDownloadLinkRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSslCertDownloadLinkResponse>(response);
        }

        public AsyncInvoker<ListSslCertDownloadLinkResponse> ListSslCertDownloadLinkAsyncInvoker(ListSslCertDownloadLinkRequest listSslCertDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSslCertDownloadLinkRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-cert/download-link", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSslCertDownloadLinkRequest);
            return new AsyncInvoker<ListSslCertDownloadLinkResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSslCertDownloadLinkResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listStorageTypesRequest.DatabaseName, out var valueOfDatabaseName)) urlParam.Add("database_name", valueOfDatabaseName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/storage-type/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageTypesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStorageTypesResponse>(response);
        }

        public AsyncInvoker<ListStorageTypesResponse> ListStorageTypesAsyncInvoker(ListStorageTypesRequest listStorageTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listStorageTypesRequest.DatabaseName, out var valueOfDatabaseName)) urlParam.Add("database_name", valueOfDatabaseName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/storage-type/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageTypesRequest);
            return new AsyncInvoker<ListStorageTypesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStorageTypesResponse>);
        }
        
        /// <summary>
        /// 查询及时任务列表
        ///
        /// 查询及时任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTasksResponse> ListTasksAsync(ListTasksRequest listTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasklist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTasksResponse>(response);
        }

        public AsyncInvoker<ListTasksResponse> ListTasksAsyncInvoker(ListTasksRequest listTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasklist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTasksRequest);
            return new AsyncInvoker<ListTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTasksResponse>);
        }
        
        /// <summary>
        /// 查询高级备份策略
        ///
        /// 查询高级备份策略，可查看自定义稀疏备份等
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUpdateBackupEnhancePolicyResponse> ListUpdateBackupEnhancePolicyAsync(ListUpdateBackupEnhancePolicyRequest listUpdateBackupEnhancePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUpdateBackupEnhancePolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/enhance-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpdateBackupEnhancePolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUpdateBackupEnhancePolicyResponse>(response);
        }

        public AsyncInvoker<ListUpdateBackupEnhancePolicyResponse> ListUpdateBackupEnhancePolicyAsyncInvoker(ListUpdateBackupEnhancePolicyRequest listUpdateBackupEnhancePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUpdateBackupEnhancePolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/enhance-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpdateBackupEnhancePolicyRequest);
            return new AsyncInvoker<ListUpdateBackupEnhancePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUpdateBackupEnhancePolicyResponse>);
        }
        
        /// <summary>
        /// 查询实例大版本升级历史信息
        ///
        /// 查询实例大版本升级历史信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUpgradeHistoriesResponse> ListUpgradeHistoriesAsync(ListUpgradeHistoriesRequest listUpgradeHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUpgradeHistoriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/upgrade-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpgradeHistoriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUpgradeHistoriesResponse>(response);
        }

        public AsyncInvoker<ListUpgradeHistoriesResponse> ListUpgradeHistoriesAsyncInvoker(ListUpgradeHistoriesRequest listUpgradeHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUpgradeHistoriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/upgrade-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpgradeHistoriesRequest);
            return new AsyncInvoker<ListUpgradeHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUpgradeHistoriesResponse>);
        }
        
        /// <summary>
        /// 查询实例的磁盘信息
        ///
        /// 查询实例的磁盘信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVolumeInfoResponse> ListVolumeInfoAsync(ListVolumeInfoRequest listVolumeInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listVolumeInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/volumes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumeInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerializeNull<ListVolumeInfoResponse>(response);
        }

        public AsyncInvoker<ListVolumeInfoResponse> ListVolumeInfoAsyncInvoker(ListVolumeInfoRequest listVolumeInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listVolumeInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/volumes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumeInfoRequest);
            return new AsyncInvoker<ListVolumeInfoResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ListVolumeInfoResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listXellogFilesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/xellog-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listXellogFilesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListXellogFilesResponse>(response);
        }

        public AsyncInvoker<ListXellogFilesResponse> ListXellogFilesAsyncInvoker(ListXellogFilesRequest listXellogFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listXellogFilesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/xellog-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listXellogFilesRequest);
            return new AsyncInvoker<ListXellogFilesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListXellogFilesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(migrateFollowerRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/migrateslave", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateFollowerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<MigrateFollowerResponse>(response);
        }

        public AsyncInvoker<MigrateFollowerResponse> MigrateFollowerAsyncInvoker(MigrateFollowerRequest migrateFollowerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(migrateFollowerRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/migrateslave", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateFollowerRequest);
            return new AsyncInvoker<MigrateFollowerResponse>(this, "POST", request, JsonUtils.DeSerialize<MigrateFollowerResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyPostgresqlHbaConfRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyPostgresqlHbaConfRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyPostgresqlHbaConfResponse>(response);
        }

        public AsyncInvoker<ModifyPostgresqlHbaConfResponse> ModifyPostgresqlHbaConfAsyncInvoker(ModifyPostgresqlHbaConfRequest modifyPostgresqlHbaConfRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyPostgresqlHbaConfRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyPostgresqlHbaConfRequest);
            return new AsyncInvoker<ModifyPostgresqlHbaConfResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyPostgresqlHbaConfResponse>);
        }
        
        /// <summary>
        /// 设置读写分离路由模式
        ///
        /// 设置读写分离路由模式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyRdSforMySqlProxyRouteModeResponse> ModifyRdSforMySqlProxyRouteModeAsync(ModifyRdSforMySqlProxyRouteModeRequest modifyRdSforMySqlProxyRouteModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyRdSforMySqlProxyRouteModeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(modifyRdSforMySqlProxyRouteModeRequest.ProxyId, out var valueOfProxyId)) urlParam.Add("proxy_id", valueOfProxyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/route-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyRdSforMySqlProxyRouteModeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ModifyRdSforMySqlProxyRouteModeResponse>(response);
        }

        public AsyncInvoker<ModifyRdSforMySqlProxyRouteModeResponse> ModifyRdSforMySqlProxyRouteModeAsyncInvoker(ModifyRdSforMySqlProxyRouteModeRequest modifyRdSforMySqlProxyRouteModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyRdSforMySqlProxyRouteModeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(modifyRdSforMySqlProxyRouteModeRequest.ProxyId, out var valueOfProxyId)) urlParam.Add("proxy_id", valueOfProxyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/route-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyRdSforMySqlProxyRouteModeRequest);
            return new AsyncInvoker<ModifyRdSforMySqlProxyRouteModeResponse>(this, "POST", request, JsonUtils.DeSerialize<ModifyRdSforMySqlProxyRouteModeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreExistInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RestoreExistInstanceResponse>(response);
        }

        public AsyncInvoker<RestoreExistInstanceResponse> RestoreExistInstanceAsyncInvoker(RestoreExistInstanceRequest restoreExistInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreExistInstanceRequest);
            return new AsyncInvoker<RestoreExistInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreExistInstanceResponse>);
        }
        
        /// <summary>
        /// 延迟库只读，恢复库到主实例
        ///
        /// 延迟库只读，恢复库到主实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestoreLogReplayDatabaseResponse> RestoreLogReplayDatabaseAsync(RestoreLogReplayDatabaseRequest restoreLogReplayDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreLogReplayDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/log-replay/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreLogReplayDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RestoreLogReplayDatabaseResponse>(response);
        }

        public AsyncInvoker<RestoreLogReplayDatabaseResponse> RestoreLogReplayDatabaseAsyncInvoker(RestoreLogReplayDatabaseRequest restoreLogReplayDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreLogReplayDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/log-replay/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreLogReplayDatabaseRequest);
            return new AsyncInvoker<RestoreLogReplayDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreLogReplayDatabaseResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreTablesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreTablesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RestoreTablesResponse>(response);
        }

        public AsyncInvoker<RestoreTablesResponse> RestoreTablesAsyncInvoker(RestoreTablesRequest restoreTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreTablesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreTablesRequest);
            return new AsyncInvoker<RestoreTablesResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreTablesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreTablesNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/restore/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreTablesNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RestoreTablesNewResponse>(response);
        }

        public AsyncInvoker<RestoreTablesNewResponse> RestoreTablesNewAsyncInvoker(RestoreTablesNewRequest restoreTablesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreTablesNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/restore/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreTablesNewRequest);
            return new AsyncInvoker<RestoreTablesNewResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreTablesNewResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreToExistingInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RestoreToExistingInstanceResponse>(response);
        }

        public AsyncInvoker<RestoreToExistingInstanceResponse> RestoreToExistingInstanceAsyncInvoker(RestoreToExistingInstanceRequest restoreToExistingInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreToExistingInstanceRequest);
            return new AsyncInvoker<RestoreToExistingInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreToExistingInstanceResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditlogPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditlogPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SetAuditlogPolicyResponse>(response);
        }

        public AsyncInvoker<SetAuditlogPolicyResponse> SetAuditlogPolicyAsyncInvoker(SetAuditlogPolicyRequest setAuditlogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAuditlogPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditlogPolicyRequest);
            return new AsyncInvoker<SetAuditlogPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetAuditlogPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAutoEnlargePolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disk-auto-expansion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAutoEnlargePolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetAutoEnlargePolicyResponse>(response);
        }

        public AsyncInvoker<SetAutoEnlargePolicyResponse> SetAutoEnlargePolicyAsyncInvoker(SetAutoEnlargePolicyRequest setAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAutoEnlargePolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disk-auto-expansion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAutoEnlargePolicyRequest);
            return new AsyncInvoker<SetAutoEnlargePolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetAutoEnlargePolicyResponse>);
        }
        
        /// <summary>
        /// 设置实例内核小版本自动升级策略
        ///
        /// 设置实例内核小版本自动升级策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetAutoUpgradePolicyResponse> SetAutoUpgradePolicyAsync(SetAutoUpgradePolicyRequest setAutoUpgradePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAutoUpgradePolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-auto-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAutoUpgradePolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SetAutoUpgradePolicyResponse>(response);
        }

        public AsyncInvoker<SetAutoUpgradePolicyResponse> SetAutoUpgradePolicyAsyncInvoker(SetAutoUpgradePolicyRequest setAutoUpgradePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setAutoUpgradePolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-auto-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAutoUpgradePolicyRequest);
            return new AsyncInvoker<SetAutoUpgradePolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetAutoUpgradePolicyResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(setBackupPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBackupPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetBackupPolicyResponse>(response);
        }

        public AsyncInvoker<SetBackupPolicyResponse> SetBackupPolicyAsyncInvoker(SetBackupPolicyRequest setBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setBackupPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBackupPolicyRequest);
            return new AsyncInvoker<SetBackupPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetBackupPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setBinlogClearPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/binlog/clear-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBinlogClearPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SetBinlogClearPolicyResponse>(response);
        }

        public AsyncInvoker<SetBinlogClearPolicyResponse> SetBinlogClearPolicyAsyncInvoker(SetBinlogClearPolicyRequest setBinlogClearPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setBinlogClearPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/binlog/clear-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBinlogClearPolicyRequest);
            return new AsyncInvoker<SetBinlogClearPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetBinlogClearPolicyResponse>);
        }
        
        /// <summary>
        /// 重启数据库代理
        ///
        /// 重启数据库代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetInstancesProxyRestartResponse> SetInstancesProxyRestartAsync(SetInstancesProxyRestartRequest setInstancesProxyRestartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setInstancesProxyRestartRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(setInstancesProxyRestartRequest.ProxyId, out var valueOfProxyId)) urlParam.Add("proxy_id", valueOfProxyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setInstancesProxyRestartRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetInstancesProxyRestartResponse>(response);
        }

        public AsyncInvoker<SetInstancesProxyRestartResponse> SetInstancesProxyRestartAsyncInvoker(SetInstancesProxyRestartRequest setInstancesProxyRestartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setInstancesProxyRestartRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(setInstancesProxyRestartRequest.ProxyId, out var valueOfProxyId)) urlParam.Add("proxy_id", valueOfProxyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setInstancesProxyRestartRequest);
            return new AsyncInvoker<SetInstancesProxyRestartResponse>(this, "POST", request, JsonUtils.DeSerialize<SetInstancesProxyRestartResponse>);
        }
        
        /// <summary>
        /// 关联LTS配置信息
        ///
        /// 关联LTS配置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetLogLtsConfigsResponse> SetLogLtsConfigsAsync(SetLogLtsConfigsRequest setLogLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setLogLtsConfigsRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{engine}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setLogLtsConfigsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SetLogLtsConfigsResponse>(response);
        }

        public AsyncInvoker<SetLogLtsConfigsResponse> SetLogLtsConfigsAsyncInvoker(SetLogLtsConfigsRequest setLogLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setLogLtsConfigsRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{engine}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setLogLtsConfigsRequest);
            return new AsyncInvoker<SetLogLtsConfigsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetLogLtsConfigsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setOffSiteBackupPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/offsite-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setOffSiteBackupPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetOffSiteBackupPolicyResponse>(response);
        }

        public AsyncInvoker<SetOffSiteBackupPolicyResponse> SetOffSiteBackupPolicyAsyncInvoker(SetOffSiteBackupPolicyRequest setOffSiteBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setOffSiteBackupPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/offsite-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setOffSiteBackupPolicyRequest);
            return new AsyncInvoker<SetOffSiteBackupPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetOffSiteBackupPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSecondLevelMonitorRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/second-level-monitor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSecondLevelMonitorRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetSecondLevelMonitorResponse>(response);
        }

        public AsyncInvoker<SetSecondLevelMonitorResponse> SetSecondLevelMonitorAsyncInvoker(SetSecondLevelMonitorRequest setSecondLevelMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSecondLevelMonitorRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/second-level-monitor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSecondLevelMonitorRequest);
            return new AsyncInvoker<SetSecondLevelMonitorResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetSecondLevelMonitorResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSecurityGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSecurityGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SetSecurityGroupResponse>(response);
        }

        public AsyncInvoker<SetSecurityGroupResponse> SetSecurityGroupAsyncInvoker(SetSecurityGroupRequest setSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSecurityGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSecurityGroupRequest);
            return new AsyncInvoker<SetSecurityGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetSecurityGroupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSensitiveSlowLogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(setSensitiveSlowLogRequest.Status, out var valueOfStatus)) urlParam.Add("status", valueOfStatus);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-sensitization/{status}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSensitiveSlowLogRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetSensitiveSlowLogResponse>(response);
        }

        public AsyncInvoker<SetSensitiveSlowLogResponse> SetSensitiveSlowLogAsyncInvoker(SetSensitiveSlowLogRequest setSensitiveSlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setSensitiveSlowLogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(setSensitiveSlowLogRequest.Status, out var valueOfStatus)) urlParam.Add("status", valueOfStatus);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-sensitization/{status}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSensitiveSlowLogRequest);
            return new AsyncInvoker<SetSensitiveSlowLogResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetSensitiveSlowLogResponse>);
        }
        
        /// <summary>
        /// 设置自动转储策略
        ///
        /// 设置自动转储策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetTransferPolicyResponse> SetTransferPolicyAsync(SetTransferPolicyRequest setTransferPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setTransferPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/transfer/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setTransferPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetTransferPolicyResponse>(response);
        }

        public AsyncInvoker<SetTransferPolicyResponse> SetTransferPolicyAsyncInvoker(SetTransferPolicyRequest setTransferPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setTransferPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/transfer/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setTransferPolicyRequest);
            return new AsyncInvoker<SetTransferPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetTransferPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditlogDownloadLinkRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-links", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditlogDownloadLinkRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowAuditlogDownloadLinkResponse>(response);
        }

        public AsyncInvoker<ShowAuditlogDownloadLinkResponse> ShowAuditlogDownloadLinkAsyncInvoker(ShowAuditlogDownloadLinkRequest showAuditlogDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditlogDownloadLinkRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-links", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditlogDownloadLinkRequest);
            return new AsyncInvoker<ShowAuditlogDownloadLinkResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowAuditlogDownloadLinkResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditlogPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditlogPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditlogPolicyResponse>(response);
        }

        public AsyncInvoker<ShowAuditlogPolicyResponse> ShowAuditlogPolicyAsyncInvoker(ShowAuditlogPolicyRequest showAuditlogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditlogPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditlogPolicyRequest);
            return new AsyncInvoker<ShowAuditlogPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditlogPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoEnlargePolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disk-auto-expansion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoEnlargePolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoEnlargePolicyResponse>(response);
        }

        public AsyncInvoker<ShowAutoEnlargePolicyResponse> ShowAutoEnlargePolicyAsyncInvoker(ShowAutoEnlargePolicyRequest showAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoEnlargePolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disk-auto-expansion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoEnlargePolicyRequest);
            return new AsyncInvoker<ShowAutoEnlargePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoEnlargePolicyResponse>);
        }
        
        /// <summary>
        /// 查询实例内核小版本自动升级策略
        ///
        /// 查询实例内核小版本自动升级策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutoUpgradePolicyResponse> ShowAutoUpgradePolicyAsync(ShowAutoUpgradePolicyRequest showAutoUpgradePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoUpgradePolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-auto-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoUpgradePolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoUpgradePolicyResponse>(response);
        }

        public AsyncInvoker<ShowAutoUpgradePolicyResponse> ShowAutoUpgradePolicyAsyncInvoker(ShowAutoUpgradePolicyRequest showAutoUpgradePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoUpgradePolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-auto-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoUpgradePolicyRequest);
            return new AsyncInvoker<ShowAutoUpgradePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoUpgradePolicyResponse>);
        }
        
        /// <summary>
        /// 查询实例可升级的目标版本
        ///
        /// 查询实例可升级的目标版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAvailableVersionResponse> ShowAvailableVersionAsync(ShowAvailableVersionRequest showAvailableVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAvailableVersionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/available-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvailableVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAvailableVersionResponse>(response);
        }

        public AsyncInvoker<ShowAvailableVersionResponse> ShowAvailableVersionAsyncInvoker(ShowAvailableVersionRequest showAvailableVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAvailableVersionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/available-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvailableVersionRequest);
            return new AsyncInvoker<ShowAvailableVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAvailableVersionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backup-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupDownloadLinkRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBackupDownloadLinkResponse>(response);
        }

        public AsyncInvoker<ShowBackupDownloadLinkResponse> ShowBackupDownloadLinkAsyncInvoker(ShowBackupDownloadLinkRequest showBackupDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backup-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupDownloadLinkRequest);
            return new AsyncInvoker<ShowBackupDownloadLinkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackupDownloadLinkResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showBackupPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBackupPolicyResponse>(response);
        }

        public AsyncInvoker<ShowBackupPolicyResponse> ShowBackupPolicyAsyncInvoker(ShowBackupPolicyRequest showBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBackupPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupPolicyRequest);
            return new AsyncInvoker<ShowBackupPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackupPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBinlogClearPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/binlog/clear-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBinlogClearPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBinlogClearPolicyResponse>(response);
        }

        public AsyncInvoker<ShowBinlogClearPolicyResponse> ShowBinlogClearPolicyAsyncInvoker(ShowBinlogClearPolicyRequest showBinlogClearPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBinlogClearPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/binlog/clear-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBinlogClearPolicyRequest);
            return new AsyncInvoker<ShowBinlogClearPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBinlogClearPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigurationResponse>(response);
        }

        public AsyncInvoker<ShowConfigurationResponse> ShowConfigurationAsyncInvoker(ShowConfigurationRequest showConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationRequest);
            return new AsyncInvoker<ShowConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigurationResponse>);
        }
        
        /// <summary>
        /// 查询库级备份包含的库
        ///
        /// 查询库级备份包含的库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDatabaseLevelDatabaseResponse> ShowDatabaseLevelDatabaseAsync(ShowDatabaseLevelDatabaseRequest showDatabaseLevelDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDatabaseLevelDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/db-table-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDatabaseLevelDatabaseRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDatabaseLevelDatabaseResponse>(response);
        }

        public AsyncInvoker<ShowDatabaseLevelDatabaseResponse> ShowDatabaseLevelDatabaseAsyncInvoker(ShowDatabaseLevelDatabaseRequest showDatabaseLevelDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDatabaseLevelDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/db-table-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDatabaseLevelDatabaseRequest);
            return new AsyncInvoker<ShowDatabaseLevelDatabaseResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDatabaseLevelDatabaseResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDnsNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dns-ipv6", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDnsNameRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDnsNameResponse>(response);
        }

        public AsyncInvoker<ShowDnsNameResponse> ShowDnsNameAsyncInvoker(ShowDnsNameRequest showDnsNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDnsNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dns-ipv6", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDnsNameRequest);
            return new AsyncInvoker<ShowDnsNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDnsNameResponse>);
        }
        
        /// <summary>
        /// 查询实例ipv4域名
        ///
        /// 查询实例ipv4域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainNameResponse> ShowDomainNameAsync(ShowDomainNameRequest showDomainNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainNameRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainNameResponse>(response);
        }

        public AsyncInvoker<ShowDomainNameResponse> ShowDomainNameAsyncInvoker(ShowDomainNameRequest showDomainNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainNameRequest);
            return new AsyncInvoker<ShowDomainNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainNameResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDrReplicaStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDrReplicaStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDrReplicaStatusResponse>(response);
        }

        public AsyncInvoker<ShowDrReplicaStatusResponse> ShowDrReplicaStatusAsyncInvoker(ShowDrReplicaStatusRequest showDrReplicaStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDrReplicaStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDrReplicaStatusRequest);
            return new AsyncInvoker<ShowDrReplicaStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDrReplicaStatusResponse>);
        }
        
        /// <summary>
        /// 获取增备策略
        ///
        /// 获取增备策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowIncreBackupPolicy1Response> ShowIncreBackupPolicy1Async(ShowIncreBackupPolicy1Request showIncreBackupPolicy1Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIncreBackupPolicy1Request.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/incre-backup/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIncreBackupPolicy1Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowIncreBackupPolicy1Response>(response);
        }

        public AsyncInvoker<ShowIncreBackupPolicy1Response> ShowIncreBackupPolicy1AsyncInvoker(ShowIncreBackupPolicy1Request showIncreBackupPolicy1Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIncreBackupPolicy1Request.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/incre-backup/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIncreBackupPolicy1Request);
            return new AsyncInvoker<ShowIncreBackupPolicy1Response>(this, "GET", request, JsonUtils.DeSerialize<ShowIncreBackupPolicy1Response>);
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
            if (StringUtils.TryConvertToNonEmptyString(showInstanceConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigurationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceConfigurationResponse>(response);
        }

        public AsyncInvoker<ShowInstanceConfigurationResponse> ShowInstanceConfigurationAsyncInvoker(ShowInstanceConfigurationRequest showInstanceConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigurationRequest);
            return new AsyncInvoker<ShowInstanceConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceConfigurationResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOffSiteBackupPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/offsite-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOffSiteBackupPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOffSiteBackupPolicyResponse>(response);
        }

        public AsyncInvoker<ShowOffSiteBackupPolicyResponse> ShowOffSiteBackupPolicyAsyncInvoker(ShowOffSiteBackupPolicyRequest showOffSiteBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOffSiteBackupPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/offsite-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOffSiteBackupPolicyRequest);
            return new AsyncInvoker<ShowOffSiteBackupPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOffSiteBackupPolicyResponse>);
        }
        
        /// <summary>
        /// 获取mysql5.7升级mysql8.0预检查结果
        ///
        /// 获取mysql5.7升级mysql8.0预检查结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPrecheckResultResponse> ShowPrecheckResultAsync(ShowPrecheckResultRequest showPrecheckResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPrecheckResultRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/upgrade-version/precheck-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrecheckResultRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPrecheckResultResponse>(response);
        }

        public AsyncInvoker<ShowPrecheckResultResponse> ShowPrecheckResultAsyncInvoker(ShowPrecheckResultRequest showPrecheckResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPrecheckResultRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/upgrade-version/precheck-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrecheckResultRequest);
            return new AsyncInvoker<ShowPrecheckResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPrecheckResultResponse>);
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
        /// 查询回收站的回收策略。
        ///
        /// 查询回收站的回收策略。
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
        /// 获取实例的复制状态。
        ///
        /// 获取实例的复制状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowReplicationStatusResponse> ShowReplicationStatusAsync(ShowReplicationStatusRequest showReplicationStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReplicationStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replication/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplicationStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowReplicationStatusResponse>(response);
        }

        public AsyncInvoker<ShowReplicationStatusResponse> ShowReplicationStatusAsyncInvoker(ShowReplicationStatusRequest showReplicationStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReplicationStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replication/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplicationStatusRequest);
            return new AsyncInvoker<ShowReplicationStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReplicationStatusResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecondLevelMonitoringRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/second-level-monitor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecondLevelMonitoringRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSecondLevelMonitoringResponse>(response);
        }

        public AsyncInvoker<ShowSecondLevelMonitoringResponse> ShowSecondLevelMonitoringAsyncInvoker(ShowSecondLevelMonitoringRequest showSecondLevelMonitoringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecondLevelMonitoringRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/second-level-monitor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecondLevelMonitoringRequest);
            return new AsyncInvoker<ShowSecondLevelMonitoringResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecondLevelMonitoringResponse>);
        }
        
        /// <summary>
        /// 查询实例磁盘空间使用量
        ///
        /// 查询实例磁盘空间使用量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStorageUsedSpaceResponse> ShowStorageUsedSpaceAsync(ShowStorageUsedSpaceRequest showStorageUsedSpaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStorageUsedSpaceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/storage-used-space", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStorageUsedSpaceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStorageUsedSpaceResponse>(response);
        }

        public AsyncInvoker<ShowStorageUsedSpaceResponse> ShowStorageUsedSpaceAsyncInvoker(ShowStorageUsedSpaceRequest showStorageUsedSpaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStorageUsedSpaceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/storage-used-space", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStorageUsedSpaceRequest);
            return new AsyncInvoker<ShowStorageUsedSpaceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStorageUsedSpaceResponse>);
        }
        
        /// <summary>
        /// 根据实例id查询sqlserver TDE状态
        ///
        /// 根据实例id查询sqlserver TDE状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTdeStatusResponse> ShowTdeStatusAsync(ShowTdeStatusRequest showTdeStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTdeStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tde-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTdeStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTdeStatusResponse>(response);
        }

        public AsyncInvoker<ShowTdeStatusResponse> ShowTdeStatusAsyncInvoker(ShowTdeStatusRequest showTdeStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTdeStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tde-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTdeStatusRequest);
            return new AsyncInvoker<ShowTdeStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTdeStatusResponse>);
        }
        
        /// <summary>
        /// 查询自动转储策略
        ///
        /// 查询自动转储策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTransferPolicyResponse> ShowTransferPolicyAsync(ShowTransferPolicyRequest showTransferPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTransferPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/transfer/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransferPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTransferPolicyResponse>(response);
        }

        public AsyncInvoker<ShowTransferPolicyResponse> ShowTransferPolicyAsyncInvoker(ShowTransferPolicyRequest showTransferPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTransferPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/transfer/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransferPolicyRequest);
            return new AsyncInvoker<ShowTransferPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTransferPolicyResponse>);
        }
        
        /// <summary>
        /// 查询大版本检查状态或升级状态
        ///
        /// 查询大版本检查状态或升级状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUpgradeDbMajorVersionStatusResponse> ShowUpgradeDbMajorVersionStatusAsync(ShowUpgradeDbMajorVersionStatusRequest showUpgradeDbMajorVersionStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUpgradeDbMajorVersionStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeDbMajorVersionStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUpgradeDbMajorVersionStatusResponse>(response);
        }

        public AsyncInvoker<ShowUpgradeDbMajorVersionStatusResponse> ShowUpgradeDbMajorVersionStatusAsyncInvoker(ShowUpgradeDbMajorVersionStatusRequest showUpgradeDbMajorVersionStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUpgradeDbMajorVersionStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeDbMajorVersionStatusRequest);
            return new AsyncInvoker<ShowUpgradeDbMajorVersionStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUpgradeDbMajorVersionStatusResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startFailoverRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/failover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startFailoverRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<StartFailoverResponse>(response);
        }

        public AsyncInvoker<StartFailoverResponse> StartFailoverAsyncInvoker(StartFailoverRequest startFailoverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startFailoverRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/failover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startFailoverRequest);
            return new AsyncInvoker<StartFailoverResponse>(this, "PUT", request, JsonUtils.DeSerialize<StartFailoverResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startInstanceEnlargeVolumeActionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInstanceEnlargeVolumeActionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartInstanceEnlargeVolumeActionResponse>(response);
        }

        public AsyncInvoker<StartInstanceEnlargeVolumeActionResponse> StartInstanceEnlargeVolumeActionAsyncInvoker(StartInstanceEnlargeVolumeActionRequest startInstanceEnlargeVolumeActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startInstanceEnlargeVolumeActionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInstanceEnlargeVolumeActionRequest);
            return new AsyncInvoker<StartInstanceEnlargeVolumeActionResponse>(this, "POST", request, JsonUtils.DeSerialize<StartInstanceEnlargeVolumeActionResponse>);
        }
        
        /// <summary>
        /// 数据库实例的磁盘空间缩容
        ///
        /// 数据库实例的磁盘空间缩容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartInstanceReduceVolumeActionResponse> StartInstanceReduceVolumeActionAsync(StartInstanceReduceVolumeActionRequest startInstanceReduceVolumeActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startInstanceReduceVolumeActionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInstanceReduceVolumeActionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartInstanceReduceVolumeActionResponse>(response);
        }

        public AsyncInvoker<StartInstanceReduceVolumeActionResponse> StartInstanceReduceVolumeActionAsyncInvoker(StartInstanceReduceVolumeActionRequest startInstanceReduceVolumeActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startInstanceReduceVolumeActionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInstanceReduceVolumeActionRequest);
            return new AsyncInvoker<StartInstanceReduceVolumeActionResponse>(this, "POST", request, JsonUtils.DeSerialize<StartInstanceReduceVolumeActionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startInstanceRestartActionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInstanceRestartActionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartInstanceRestartActionResponse>(response);
        }

        public AsyncInvoker<StartInstanceRestartActionResponse> StartInstanceRestartActionAsyncInvoker(StartInstanceRestartActionRequest startInstanceRestartActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startInstanceRestartActionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInstanceRestartActionRequest);
            return new AsyncInvoker<StartInstanceRestartActionResponse>(this, "POST", request, JsonUtils.DeSerialize<StartInstanceRestartActionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startInstanceSingleToHaActionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInstanceSingleToHaActionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartInstanceSingleToHaActionResponse>(response);
        }

        public AsyncInvoker<StartInstanceSingleToHaActionResponse> StartInstanceSingleToHaActionAsyncInvoker(StartInstanceSingleToHaActionRequest startInstanceSingleToHaActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startInstanceSingleToHaActionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInstanceSingleToHaActionRequest);
            return new AsyncInvoker<StartInstanceSingleToHaActionResponse>(this, "POST", request, JsonUtils.DeSerialize<StartInstanceSingleToHaActionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startRecyclePolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<StartRecyclePolicyResponse>(response);
        }

        public AsyncInvoker<StartRecyclePolicyResponse> StartRecyclePolicyAsyncInvoker(StartRecyclePolicyRequest startRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startRecyclePolicyRequest);
            return new AsyncInvoker<StartRecyclePolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<StartRecyclePolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startResizeFlavorActionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startResizeFlavorActionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartResizeFlavorActionResponse>(response);
        }

        public AsyncInvoker<StartResizeFlavorActionResponse> StartResizeFlavorActionAsyncInvoker(StartResizeFlavorActionRequest startResizeFlavorActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startResizeFlavorActionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startResizeFlavorActionRequest);
            return new AsyncInvoker<StartResizeFlavorActionResponse>(this, "POST", request, JsonUtils.DeSerialize<StartResizeFlavorActionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startupInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action/startup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startupInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartupInstanceResponse>(response);
        }

        public AsyncInvoker<StartupInstanceResponse> StartupInstanceAsyncInvoker(StartupInstanceRequest startupInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startupInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action/startup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startupInstanceRequest);
            return new AsyncInvoker<StartupInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StartupInstanceResponse>);
        }
        
        /// <summary>
        /// 停止备份
        ///
        /// 停止创建备份
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopBackupResponse> StopBackupAsync(StopBackupRequest stopBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopBackupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBackupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopBackupResponse>(response);
        }

        public AsyncInvoker<StopBackupResponse> StopBackupAsyncInvoker(StopBackupRequest stopBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopBackupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBackupRequest);
            return new AsyncInvoker<StopBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<StopBackupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action/shutdown", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopInstanceResponse>(response);
        }

        public AsyncInvoker<StopInstanceResponse> StopInstanceAsyncInvoker(StopInstanceRequest stopInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action/shutdown", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopInstanceRequest);
            return new AsyncInvoker<StopInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StopInstanceResponse>);
        }
        
        /// <summary>
        /// 开启/关闭/禁用所有SQL限流
        ///
        /// 开启/关闭/禁用所有SQL限流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchSqlLimitResponse> SwitchSqlLimitAsync(SwitchSqlLimitRequest switchSqlLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchSqlLimitRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-limit/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSqlLimitRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SwitchSqlLimitResponse>(response);
        }

        public AsyncInvoker<SwitchSqlLimitResponse> SwitchSqlLimitAsyncInvoker(SwitchSqlLimitRequest switchSqlLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchSqlLimitRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-limit/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSqlLimitRequest);
            return new AsyncInvoker<SwitchSqlLimitResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchSqlLimitResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchSslRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSslRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SwitchSslResponse>(response);
        }

        public AsyncInvoker<SwitchSslResponse> SwitchSslAsyncInvoker(SwitchSslRequest switchSslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchSslRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSslRequest);
            return new AsyncInvoker<SwitchSslResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchSslResponse>);
        }
        
        /// <summary>
        /// 手动转储备份
        ///
        /// 手动转储备份
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<TransferBackupResponse> TransferBackupAsync(TransferBackupRequest transferBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(transferBackupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/transfer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", transferBackupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<TransferBackupResponse>(response);
        }

        public AsyncInvoker<TransferBackupResponse> TransferBackupAsyncInvoker(TransferBackupRequest transferBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(transferBackupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/transfer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", transferBackupRequest);
            return new AsyncInvoker<TransferBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<TransferBackupResponse>);
        }
        
        /// <summary>
        /// 解除节点只读状态接口
        ///
        /// 解除节点只读状态接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UnlockNodeReadonlyStatusResponse> UnlockNodeReadonlyStatusAsync(UnlockNodeReadonlyStatusRequest unlockNodeReadonlyStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unlockNodeReadonlyStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/unlock-node-readonly-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unlockNodeReadonlyStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UnlockNodeReadonlyStatusResponse>(response);
        }

        public AsyncInvoker<UnlockNodeReadonlyStatusResponse> UnlockNodeReadonlyStatusAsyncInvoker(UnlockNodeReadonlyStatusRequest unlockNodeReadonlyStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unlockNodeReadonlyStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/unlock-node-readonly-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unlockNodeReadonlyStatusRequest);
            return new AsyncInvoker<UnlockNodeReadonlyStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<UnlockNodeReadonlyStatusResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(updateConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateConfigurationResponse>(response);
        }

        public AsyncInvoker<UpdateConfigurationResponse> UpdateConfigurationAsyncInvoker(UpdateConfigurationRequest updateConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigurationRequest);
            return new AsyncInvoker<UpdateConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateConfigurationResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDataIpRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDataIpRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDataIpResponse>(response);
        }

        public AsyncInvoker<UpdateDataIpResponse> UpdateDataIpAsyncInvoker(UpdateDataIpRequest updateDataIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDataIpRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDataIpRequest);
            return new AsyncInvoker<UpdateDataIpResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDataIpResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDnsNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDnsNameRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDnsNameResponse>(response);
        }

        public AsyncInvoker<UpdateDnsNameResponse> UpdateDnsNameAsyncInvoker(UpdateDnsNameRequest updateDnsNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDnsNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDnsNameRequest);
            return new AsyncInvoker<UpdateDnsNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDnsNameResponse>);
        }
        
        /// <summary>
        /// 修改增备策略
        ///
        /// 修改增备策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateIncreBackupPolicy1Response> UpdateIncreBackupPolicy1Async(UpdateIncreBackupPolicy1Request updateIncreBackupPolicy1Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIncreBackupPolicy1Request.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/incre-backup/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIncreBackupPolicy1Request);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateIncreBackupPolicy1Response>(response);
        }

        public AsyncInvoker<UpdateIncreBackupPolicy1Response> UpdateIncreBackupPolicy1AsyncInvoker(UpdateIncreBackupPolicy1Request updateIncreBackupPolicy1Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIncreBackupPolicy1Request.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/incre-backup/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIncreBackupPolicy1Request);
            return new AsyncInvoker<UpdateIncreBackupPolicy1Response>(this, "PUT", request, JsonUtils.DeSerialize<UpdateIncreBackupPolicy1Response>);
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
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceConfigurationResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceConfigurationResponse> UpdateInstanceConfigurationAsyncInvoker(UpdateInstanceConfigurationRequest updateInstanceConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
        public async Task<UpdateInstanceConfigurationAsyncResponse> UpdateInstanceConfigurationAsyncAsync(UpdateInstanceConfigurationAsyncRequest updateInstanceConfigurationAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceConfigurationAsyncRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConfigurationAsyncRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceConfigurationAsyncResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceConfigurationAsyncResponse> UpdateInstanceConfigurationAsyncAsyncInvoker(UpdateInstanceConfigurationAsyncRequest updateInstanceConfigurationAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceConfigurationAsyncRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConfigurationAsyncRequest);
            return new AsyncInvoker<UpdateInstanceConfigurationAsyncResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceConfigurationAsyncResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceNameRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceNameResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceNameResponse> UpdateInstanceNameAsyncInvoker(UpdateInstanceNameRequest updateInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceNameRequest);
            return new AsyncInvoker<UpdateInstanceNameResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceNameResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePortRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePortRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePortResponse>(response);
        }

        public AsyncInvoker<UpdatePortResponse> UpdatePortAsyncInvoker(UpdatePortRequest updatePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePortRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePortRequest);
            return new AsyncInvoker<UpdatePortResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePortResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePostgresqlInstanceAliasRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/alias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlInstanceAliasRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePostgresqlInstanceAliasResponse>(response);
        }

        public AsyncInvoker<UpdatePostgresqlInstanceAliasResponse> UpdatePostgresqlInstanceAliasAsyncInvoker(UpdatePostgresqlInstanceAliasRequest updatePostgresqlInstanceAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePostgresqlInstanceAliasRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/alias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlInstanceAliasRequest);
            return new AsyncInvoker<UpdatePostgresqlInstanceAliasResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePostgresqlInstanceAliasResponse>);
        }
        
        /// <summary>
        /// 修改SQL限流
        ///
        /// 修改SQL限流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSqlLimitResponse> UpdateSqlLimitAsync(UpdateSqlLimitRequest updateSqlLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSqlLimitRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-limit/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSqlLimitRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSqlLimitResponse>(response);
        }

        public AsyncInvoker<UpdateSqlLimitResponse> UpdateSqlLimitAsyncInvoker(UpdateSqlLimitRequest updateSqlLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSqlLimitRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-limit/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSqlLimitRequest);
            return new AsyncInvoker<UpdateSqlLimitResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSqlLimitResponse>);
        }
        
        /// <summary>
        /// sqlserverTDE开关
        ///
        /// sqlserverTDE开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTdeStatusResponse> UpdateTdeStatusAsync(UpdateTdeStatusRequest updateTdeStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTdeStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tde", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTdeStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTdeStatusResponse>(response);
        }

        public AsyncInvoker<UpdateTdeStatusResponse> UpdateTdeStatusAsyncInvoker(UpdateTdeStatusRequest updateTdeStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTdeStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tde", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTdeStatusRequest);
            return new AsyncInvoker<UpdateTdeStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTdeStatusResponse>);
        }
        
        /// <summary>
        /// RDS实例按需转包周期
        ///
        /// RDS实例按需转包周期
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateToPeriodResponse> UpdateToPeriodAsync(UpdateToPeriodRequest updateToPeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateToPeriodRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/to-period", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateToPeriodRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateToPeriodResponse>(response);
        }

        public AsyncInvoker<UpdateToPeriodResponse> UpdateToPeriodAsyncInvoker(UpdateToPeriodRequest updateToPeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateToPeriodRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/to-period", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateToPeriodRequest);
            return new AsyncInvoker<UpdateToPeriodResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateToPeriodResponse>);
        }
        
        /// <summary>
        /// PostgreSQL数据库升级大版本
        ///
        /// PostgreSQL数据库升级大版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpgradeDbMajorVersionResponse> UpgradeDbMajorVersionAsync(UpgradeDbMajorVersionRequest upgradeDbMajorVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeDbMajorVersionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbMajorVersionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpgradeDbMajorVersionResponse>(response);
        }

        public AsyncInvoker<UpgradeDbMajorVersionResponse> UpgradeDbMajorVersionAsyncInvoker(UpgradeDbMajorVersionRequest upgradeDbMajorVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeDbMajorVersionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbMajorVersionRequest);
            return new AsyncInvoker<UpgradeDbMajorVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeDbMajorVersionResponse>);
        }
        
        /// <summary>
        /// 大版本升级前进行升级检查
        ///
        /// 大版本升级前进行升级检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpgradeDbMajorVersionPreCheckResponse> UpgradeDbMajorVersionPreCheckAsync(UpgradeDbMajorVersionPreCheckRequest upgradeDbMajorVersionPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeDbMajorVersionPreCheckRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/inspection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbMajorVersionPreCheckRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpgradeDbMajorVersionPreCheckResponse>(response);
        }

        public AsyncInvoker<UpgradeDbMajorVersionPreCheckResponse> UpgradeDbMajorVersionPreCheckAsyncInvoker(UpgradeDbMajorVersionPreCheckRequest upgradeDbMajorVersionPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeDbMajorVersionPreCheckRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/inspection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbMajorVersionPreCheckRequest);
            return new AsyncInvoker<UpgradeDbMajorVersionPreCheckResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeDbMajorVersionPreCheckResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeDbVersionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbVersionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpgradeDbVersionResponse>(response);
        }

        public AsyncInvoker<UpgradeDbVersionResponse> UpgradeDbVersionAsyncInvoker(UpgradeDbVersionRequest upgradeDbVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeDbVersionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbVersionRequest);
            return new AsyncInvoker<UpgradeDbVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeDbVersionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeDbVersionNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbVersionNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpgradeDbVersionNewResponse>(response);
        }

        public AsyncInvoker<UpgradeDbVersionNewResponse> UpgradeDbVersionNewAsyncInvoker(UpgradeDbVersionNewRequest upgradeDbVersionNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeDbVersionNewRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbVersionNewRequest);
            return new AsyncInvoker<UpgradeDbVersionNewResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeDbVersionNewResponse>);
        }
        
        /// <summary>
        /// MySQL大版本升级
        ///
        /// 提供mysql5.7升级mysql8.0的下发接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpgradeLargeVersionResponse> UpgradeLargeVersionAsync(UpgradeLargeVersionRequest upgradeLargeVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeLargeVersionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeLargeVersionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpgradeLargeVersionResponse>(response);
        }

        public AsyncInvoker<UpgradeLargeVersionResponse> UpgradeLargeVersionAsyncInvoker(UpgradeLargeVersionRequest upgradeLargeVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeLargeVersionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeLargeVersionRequest);
            return new AsyncInvoker<UpgradeLargeVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeLargeVersionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionResponse>(response);
        }

        public AsyncInvoker<ListApiVersionResponse> ListApiVersionAsyncInvoker(ListApiVersionRequest listApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionRequest);
            return new AsyncInvoker<ListApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionNewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionNewResponse>(response);
        }

        public AsyncInvoker<ListApiVersionNewResponse> ListApiVersionNewAsyncInvoker(ListApiVersionNewRequest listApiVersionNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionNewRequest);
            return new AsyncInvoker<ListApiVersionNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionNewResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showApiVersionRequest.Version, out var valueOfVersion)) urlParam.Add("version", valueOfVersion);
            var urlPath = HttpUtils.AddUrlPath("/rds/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }

        public AsyncInvoker<ShowApiVersionResponse> ShowApiVersionAsyncInvoker(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showApiVersionRequest.Version, out var valueOfVersion)) urlParam.Add("version", valueOfVersion);
            var urlPath = HttpUtils.AddUrlPath("/rds/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            return new AsyncInvoker<ShowApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApiVersionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(allowDbUserPrivilegeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowDbUserPrivilegeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AllowDbUserPrivilegeResponse>(response);
        }

        public AsyncInvoker<AllowDbUserPrivilegeResponse> AllowDbUserPrivilegeAsyncInvoker(AllowDbUserPrivilegeRequest allowDbUserPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(allowDbUserPrivilegeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowDbUserPrivilegeRequest);
            return new AsyncInvoker<AllowDbUserPrivilegeResponse>(this, "POST", request, JsonUtils.DeSerialize<AllowDbUserPrivilegeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDatabaseResponse>(response);
        }

        public AsyncInvoker<CreateDatabaseResponse> CreateDatabaseAsyncInvoker(CreateDatabaseRequest createDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDatabaseRequest);
            return new AsyncInvoker<CreateDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDatabaseResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDbUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDbUserResponse>(response);
        }

        public AsyncInvoker<CreateDbUserResponse> CreateDbUserAsyncInvoker(CreateDbUserRequest createDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDbUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbUserRequest);
            return new AsyncInvoker<CreateDbUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDbUserResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDatabaseRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/{db_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDatabaseResponse>(response);
        }

        public AsyncInvoker<DeleteDatabaseResponse> DeleteDatabaseAsyncInvoker(DeleteDatabaseRequest deleteDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDatabaseRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/{db_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseRequest);
            return new AsyncInvoker<DeleteDatabaseResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDatabaseResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDbUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDbUserRequest.UserName, out var valueOfUserName)) urlParam.Add("user_name", valueOfUserName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbUserRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDbUserResponse>(response);
        }

        public AsyncInvoker<DeleteDbUserResponse> DeleteDbUserAsyncInvoker(DeleteDbUserRequest deleteDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDbUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDbUserRequest.UserName, out var valueOfUserName)) urlParam.Add("user_name", valueOfUserName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbUserRequest);
            return new AsyncInvoker<DeleteDbUserResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDbUserResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuthorizedDatabasesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorizedDatabasesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuthorizedDatabasesResponse>(response);
        }

        public AsyncInvoker<ListAuthorizedDatabasesResponse> ListAuthorizedDatabasesAsyncInvoker(ListAuthorizedDatabasesRequest listAuthorizedDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuthorizedDatabasesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorizedDatabasesRequest);
            return new AsyncInvoker<ListAuthorizedDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuthorizedDatabasesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuthorizedDbUsersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/db_user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorizedDbUsersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuthorizedDbUsersResponse>(response);
        }

        public AsyncInvoker<ListAuthorizedDbUsersResponse> ListAuthorizedDbUsersAsyncInvoker(ListAuthorizedDbUsersRequest listAuthorizedDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuthorizedDbUsersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/db_user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorizedDbUsersRequest);
            return new AsyncInvoker<ListAuthorizedDbUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuthorizedDbUsersResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDatabasesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabasesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDatabasesResponse>(response);
        }

        public AsyncInvoker<ListDatabasesResponse> ListDatabasesAsyncInvoker(ListDatabasesRequest listDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDatabasesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabasesRequest);
            return new AsyncInvoker<ListDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabasesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDbUsersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbUsersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDbUsersResponse>(response);
        }

        public AsyncInvoker<ListDbUsersResponse> ListDbUsersAsyncInvoker(ListDbUsersRequest listDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDbUsersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbUsersRequest);
            return new AsyncInvoker<ListDbUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDbUsersResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetPwdRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPwdRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ResetPwdResponse>(response);
        }

        public AsyncInvoker<ResetPwdResponse> ResetPwdAsyncInvoker(ResetPwdRequest resetPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetPwdRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPwdRequest);
            return new AsyncInvoker<ResetPwdResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetPwdResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(revokeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<RevokeResponse>(response);
        }

        public AsyncInvoker<RevokeResponse> RevokeAsyncInvoker(RevokeRequest revokeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(revokeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeRequest);
            return new AsyncInvoker<RevokeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<RevokeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setDbUserPwdRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/resetpwd", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setDbUserPwdRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetDbUserPwdResponse>(response);
        }

        public AsyncInvoker<SetDbUserPwdResponse> SetDbUserPwdAsyncInvoker(SetDbUserPwdRequest setDbUserPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setDbUserPwdRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/resetpwd", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setDbUserPwdRequest);
            return new AsyncInvoker<SetDbUserPwdResponse>(this, "POST", request, JsonUtils.DeSerialize<SetDbUserPwdResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setReadOnlySwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/readonly-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setReadOnlySwitchRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SetReadOnlySwitchResponse>(response);
        }

        public AsyncInvoker<SetReadOnlySwitchResponse> SetReadOnlySwitchAsyncInvoker(SetReadOnlySwitchRequest setReadOnlySwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setReadOnlySwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/readonly-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setReadOnlySwitchRequest);
            return new AsyncInvoker<SetReadOnlySwitchResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetReadOnlySwitchResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateDatabaseResponse>(response);
        }

        public AsyncInvoker<UpdateDatabaseResponse> UpdateDatabaseAsyncInvoker(UpdateDatabaseRequest updateDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDatabaseRequest);
            return new AsyncInvoker<UpdateDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateDatabaseResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDbUserCommentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateDbUserCommentRequest.UserName, out var valueOfUserName)) urlParam.Add("user_name", valueOfUserName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/{user_name}/comment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDbUserCommentRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDbUserCommentResponse>(response);
        }

        public AsyncInvoker<UpdateDbUserCommentResponse> UpdateDbUserCommentAsyncInvoker(UpdateDbUserCommentRequest updateDbUserCommentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDbUserCommentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateDbUserCommentRequest.UserName, out var valueOfUserName)) urlParam.Add("user_name", valueOfUserName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/{user_name}/comment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDbUserCommentRequest);
            return new AsyncInvoker<UpdateDbUserCommentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDbUserCommentResponse>);
        }
        
        /// <summary>
        /// 修改实例下用户host信息
        ///
        /// 修改实例下用户host信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateHostPrivilegeResponse> UpdateHostPrivilegeAsync(UpdateHostPrivilegeRequest updateHostPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHostPrivilegeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/host-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHostPrivilegeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHostPrivilegeResponse>(response);
        }

        public AsyncInvoker<UpdateHostPrivilegeResponse> UpdateHostPrivilegeAsyncInvoker(UpdateHostPrivilegeRequest updateHostPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHostPrivilegeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/host-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHostPrivilegeRequest);
            return new AsyncInvoker<UpdateHostPrivilegeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHostPrivilegeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(allowDbPrivilegeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowDbPrivilegeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AllowDbPrivilegeResponse>(response);
        }

        public AsyncInvoker<AllowDbPrivilegeResponse> AllowDbPrivilegeAsyncInvoker(AllowDbPrivilegeRequest allowDbPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(allowDbPrivilegeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowDbPrivilegeRequest);
            return new AsyncInvoker<AllowDbPrivilegeResponse>(this, "POST", request, JsonUtils.DeSerialize<AllowDbPrivilegeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeProxyScaleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/scale", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeProxyScaleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeProxyScaleResponse>(response);
        }

        public AsyncInvoker<ChangeProxyScaleResponse> ChangeProxyScaleAsyncInvoker(ChangeProxyScaleRequest changeProxyScaleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeProxyScaleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/scale", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeProxyScaleRequest);
            return new AsyncInvoker<ChangeProxyScaleResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeProxyScaleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeTheDelayThresholdRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/delay-threshold", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeTheDelayThresholdRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ChangeTheDelayThresholdResponse>(response);
        }

        public AsyncInvoker<ChangeTheDelayThresholdResponse> ChangeTheDelayThresholdAsyncInvoker(ChangeTheDelayThresholdRequest changeTheDelayThresholdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeTheDelayThresholdRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/delay-threshold", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeTheDelayThresholdRequest);
            return new AsyncInvoker<ChangeTheDelayThresholdResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeTheDelayThresholdResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPostgresqlDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostgresqlDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePostgresqlDatabaseResponse>(response);
        }

        public AsyncInvoker<CreatePostgresqlDatabaseResponse> CreatePostgresqlDatabaseAsyncInvoker(CreatePostgresqlDatabaseRequest createPostgresqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPostgresqlDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostgresqlDatabaseRequest);
            return new AsyncInvoker<CreatePostgresqlDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePostgresqlDatabaseResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPostgresqlDatabaseSchemaRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostgresqlDatabaseSchemaRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePostgresqlDatabaseSchemaResponse>(response);
        }

        public AsyncInvoker<CreatePostgresqlDatabaseSchemaResponse> CreatePostgresqlDatabaseSchemaAsyncInvoker(CreatePostgresqlDatabaseSchemaRequest createPostgresqlDatabaseSchemaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPostgresqlDatabaseSchemaRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostgresqlDatabaseSchemaRequest);
            return new AsyncInvoker<CreatePostgresqlDatabaseSchemaResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePostgresqlDatabaseSchemaResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPostgresqlDbUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostgresqlDbUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePostgresqlDbUserResponse>(response);
        }

        public AsyncInvoker<CreatePostgresqlDbUserResponse> CreatePostgresqlDbUserAsyncInvoker(CreatePostgresqlDbUserRequest createPostgresqlDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPostgresqlDbUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostgresqlDbUserRequest);
            return new AsyncInvoker<CreatePostgresqlDbUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePostgresqlDbUserResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPostgresqlExtensionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostgresqlExtensionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreatePostgresqlExtensionResponse>(response);
        }

        public AsyncInvoker<CreatePostgresqlExtensionResponse> CreatePostgresqlExtensionAsyncInvoker(CreatePostgresqlExtensionRequest createPostgresqlExtensionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPostgresqlExtensionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostgresqlExtensionRequest);
            return new AsyncInvoker<CreatePostgresqlExtensionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreatePostgresqlExtensionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePostgresqlDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deletePostgresqlDatabaseRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/{db_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePostgresqlDatabaseRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePostgresqlDatabaseResponse>(response);
        }

        public AsyncInvoker<DeletePostgresqlDatabaseResponse> DeletePostgresqlDatabaseAsyncInvoker(DeletePostgresqlDatabaseRequest deletePostgresqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePostgresqlDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deletePostgresqlDatabaseRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/{db_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePostgresqlDatabaseRequest);
            return new AsyncInvoker<DeletePostgresqlDatabaseResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePostgresqlDatabaseResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePostgresqlDbUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deletePostgresqlDbUserRequest.UserName, out var valueOfUserName)) urlParam.Add("user_name", valueOfUserName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePostgresqlDbUserRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePostgresqlDbUserResponse>(response);
        }

        public AsyncInvoker<DeletePostgresqlDbUserResponse> DeletePostgresqlDbUserAsyncInvoker(DeletePostgresqlDbUserRequest deletePostgresqlDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePostgresqlDbUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deletePostgresqlDbUserRequest.UserName, out var valueOfUserName)) urlParam.Add("user_name", valueOfUserName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePostgresqlDbUserRequest);
            return new AsyncInvoker<DeletePostgresqlDbUserResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePostgresqlDbUserResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePostgresqlExtensionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePostgresqlExtensionRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePostgresqlExtensionResponse>(response);
        }

        public AsyncInvoker<DeletePostgresqlExtensionResponse> DeletePostgresqlExtensionAsyncInvoker(DeletePostgresqlExtensionRequest deletePostgresqlExtensionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePostgresqlExtensionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePostgresqlExtensionRequest);
            return new AsyncInvoker<DeletePostgresqlExtensionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePostgresqlExtensionResponse>);
        }
        
        /// <summary>
        /// 授予用户角色
        ///
        /// 授予用户角色
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecutePrivilegeDatabaseUserRoleResponse> ExecutePrivilegeDatabaseUserRoleAsync(ExecutePrivilegeDatabaseUserRoleRequest executePrivilegeDatabaseUserRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executePrivilegeDatabaseUserRoleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executePrivilegeDatabaseUserRoleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecutePrivilegeDatabaseUserRoleResponse>(response);
        }

        public AsyncInvoker<ExecutePrivilegeDatabaseUserRoleResponse> ExecutePrivilegeDatabaseUserRoleAsyncInvoker(ExecutePrivilegeDatabaseUserRoleRequest executePrivilegeDatabaseUserRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executePrivilegeDatabaseUserRoleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executePrivilegeDatabaseUserRoleRequest);
            return new AsyncInvoker<ExecutePrivilegeDatabaseUserRoleResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecutePrivilegeDatabaseUserRoleResponse>);
        }
        
        /// <summary>
        /// 撤回用户角色
        ///
        /// 撤回用户角色
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteRevokeDatabaseUserRoleResponse> ExecuteRevokeDatabaseUserRoleAsync(ExecuteRevokeDatabaseUserRoleRequest executeRevokeDatabaseUserRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeRevokeDatabaseUserRoleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeRevokeDatabaseUserRoleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<ExecuteRevokeDatabaseUserRoleResponse>(response);
        }

        public AsyncInvoker<ExecuteRevokeDatabaseUserRoleResponse> ExecuteRevokeDatabaseUserRoleAsyncInvoker(ExecuteRevokeDatabaseUserRoleRequest executeRevokeDatabaseUserRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeRevokeDatabaseUserRoleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeRevokeDatabaseUserRoleRequest);
            return new AsyncInvoker<ExecuteRevokeDatabaseUserRoleResponse>(this, "DELETE", request, JsonUtils.DeSerialize<ExecuteRevokeDatabaseUserRoleResponse>);
        }
        
        /// <summary>
        /// 查询数据库角色信息
        ///
        /// 查询数据库角色信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDatabaseUserRoleResponse> ListDatabaseUserRoleAsync(ListDatabaseUserRoleRequest listDatabaseUserRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDatabaseUserRoleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseUserRoleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDatabaseUserRoleResponse>(response);
        }

        public AsyncInvoker<ListDatabaseUserRoleResponse> ListDatabaseUserRoleAsyncInvoker(ListDatabaseUserRoleRequest listDatabaseUserRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDatabaseUserRoleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseUserRoleRequest);
            return new AsyncInvoker<ListDatabaseUserRoleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabaseUserRoleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPostgresqlDatabaseSchemasRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlDatabaseSchemasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPostgresqlDatabaseSchemasResponse>(response);
        }

        public AsyncInvoker<ListPostgresqlDatabaseSchemasResponse> ListPostgresqlDatabaseSchemasAsyncInvoker(ListPostgresqlDatabaseSchemasRequest listPostgresqlDatabaseSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPostgresqlDatabaseSchemasRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlDatabaseSchemasRequest);
            return new AsyncInvoker<ListPostgresqlDatabaseSchemasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPostgresqlDatabaseSchemasResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPostgresqlDatabasesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlDatabasesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPostgresqlDatabasesResponse>(response);
        }

        public AsyncInvoker<ListPostgresqlDatabasesResponse> ListPostgresqlDatabasesAsyncInvoker(ListPostgresqlDatabasesRequest listPostgresqlDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPostgresqlDatabasesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlDatabasesRequest);
            return new AsyncInvoker<ListPostgresqlDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPostgresqlDatabasesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPostgresqlDbUserPaginatedRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlDbUserPaginatedRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPostgresqlDbUserPaginatedResponse>(response);
        }

        public AsyncInvoker<ListPostgresqlDbUserPaginatedResponse> ListPostgresqlDbUserPaginatedAsyncInvoker(ListPostgresqlDbUserPaginatedRequest listPostgresqlDbUserPaginatedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPostgresqlDbUserPaginatedRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlDbUserPaginatedRequest);
            return new AsyncInvoker<ListPostgresqlDbUserPaginatedResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPostgresqlDbUserPaginatedResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPostgresqlExtensionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlExtensionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPostgresqlExtensionResponse>(response);
        }

        public AsyncInvoker<ListPostgresqlExtensionResponse> ListPostgresqlExtensionAsyncInvoker(ListPostgresqlExtensionRequest listPostgresqlExtensionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPostgresqlExtensionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlExtensionRequest);
            return new AsyncInvoker<ListPostgresqlExtensionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPostgresqlExtensionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(revokePostgresqlDbPrivilegeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokePostgresqlDbPrivilegeRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<RevokePostgresqlDbPrivilegeResponse>(response);
        }

        public AsyncInvoker<RevokePostgresqlDbPrivilegeResponse> RevokePostgresqlDbPrivilegeAsyncInvoker(RevokePostgresqlDbPrivilegeRequest revokePostgresqlDbPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(revokePostgresqlDbPrivilegeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokePostgresqlDbPrivilegeRequest);
            return new AsyncInvoker<RevokePostgresqlDbPrivilegeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<RevokePostgresqlDbPrivilegeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(searchQueryScaleComputeFlavorsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/proxy/scale/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQueryScaleComputeFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchQueryScaleComputeFlavorsResponse>(response);
        }

        public AsyncInvoker<SearchQueryScaleComputeFlavorsResponse> SearchQueryScaleComputeFlavorsAsyncInvoker(SearchQueryScaleComputeFlavorsRequest searchQueryScaleComputeFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(searchQueryScaleComputeFlavorsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/proxy/scale/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQueryScaleComputeFlavorsRequest);
            return new AsyncInvoker<SearchQueryScaleComputeFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchQueryScaleComputeFlavorsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(searchQueryScaleFlavorsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/scale/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQueryScaleFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchQueryScaleFlavorsResponse>(response);
        }

        public AsyncInvoker<SearchQueryScaleFlavorsResponse> SearchQueryScaleFlavorsAsyncInvoker(SearchQueryScaleFlavorsRequest searchQueryScaleFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(searchQueryScaleFlavorsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/scale/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQueryScaleFlavorsRequest);
            return new AsyncInvoker<SearchQueryScaleFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchQueryScaleFlavorsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setDatabaseUserPrivilegeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/user-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setDatabaseUserPrivilegeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SetDatabaseUserPrivilegeResponse>(response);
        }

        public AsyncInvoker<SetDatabaseUserPrivilegeResponse> SetDatabaseUserPrivilegeAsyncInvoker(SetDatabaseUserPrivilegeRequest setDatabaseUserPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setDatabaseUserPrivilegeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/user-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setDatabaseUserPrivilegeRequest);
            return new AsyncInvoker<SetDatabaseUserPrivilegeResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetDatabaseUserPrivilegeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setPostgresqlDbUserPwdRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/resetpwd", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setPostgresqlDbUserPwdRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetPostgresqlDbUserPwdResponse>(response);
        }

        public AsyncInvoker<SetPostgresqlDbUserPwdResponse> SetPostgresqlDbUserPwdAsyncInvoker(SetPostgresqlDbUserPwdRequest setPostgresqlDbUserPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setPostgresqlDbUserPwdRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/resetpwd", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setPostgresqlDbUserPwdRequest);
            return new AsyncInvoker<SetPostgresqlDbUserPwdResponse>(this, "POST", request, JsonUtils.DeSerialize<SetPostgresqlDbUserPwdResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInformationAboutDatabaseProxyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInformationAboutDatabaseProxyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInformationAboutDatabaseProxyResponse>(response);
        }

        public AsyncInvoker<ShowInformationAboutDatabaseProxyResponse> ShowInformationAboutDatabaseProxyAsyncInvoker(ShowInformationAboutDatabaseProxyRequest showInformationAboutDatabaseProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInformationAboutDatabaseProxyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInformationAboutDatabaseProxyRequest);
            return new AsyncInvoker<ShowInformationAboutDatabaseProxyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInformationAboutDatabaseProxyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPostgresqlParamValueRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showPostgresqlParamValueRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/parameter/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPostgresqlParamValueRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPostgresqlParamValueResponse>(response);
        }

        public AsyncInvoker<ShowPostgresqlParamValueResponse> ShowPostgresqlParamValueAsyncInvoker(ShowPostgresqlParamValueRequest showPostgresqlParamValueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPostgresqlParamValueRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showPostgresqlParamValueRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/parameter/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPostgresqlParamValueRequest);
            return new AsyncInvoker<ShowPostgresqlParamValueResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPostgresqlParamValueResponse>);
        }
        
        /// <summary>
        /// 查询wal日志恢复时间窗
        ///
        /// 查询wal日志恢复时间窗
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecoveryTimeWindowResponse> ShowRecoveryTimeWindowAsync(ShowRecoveryTimeWindowRequest showRecoveryTimeWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRecoveryTimeWindowRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/recovery-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecoveryTimeWindowRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRecoveryTimeWindowResponse>(response);
        }

        public AsyncInvoker<ShowRecoveryTimeWindowResponse> ShowRecoveryTimeWindowAsyncInvoker(ShowRecoveryTimeWindowRequest showRecoveryTimeWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRecoveryTimeWindowRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/recovery-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecoveryTimeWindowRequest);
            return new AsyncInvoker<ShowRecoveryTimeWindowResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecoveryTimeWindowResponse>);
        }
        
        /// <summary>
        /// 获取wal日志延迟回放状态
        ///
        /// 获取wal日志延迟回放状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowReplayDelayStatusResponse> ShowReplayDelayStatusAsync(ShowReplayDelayStatusRequest showReplayDelayStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReplayDelayStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replay-delay/show", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplayDelayStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowReplayDelayStatusResponse>(response);
        }

        public AsyncInvoker<ShowReplayDelayStatusResponse> ShowReplayDelayStatusAsyncInvoker(ShowReplayDelayStatusRequest showReplayDelayStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReplayDelayStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replay-delay/show", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplayDelayStatusRequest);
            return new AsyncInvoker<ShowReplayDelayStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReplayDelayStatusResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startDatabaseProxyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDatabaseProxyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartDatabaseProxyResponse>(response);
        }

        public AsyncInvoker<StartDatabaseProxyResponse> StartDatabaseProxyAsyncInvoker(StartDatabaseProxyRequest startDatabaseProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startDatabaseProxyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDatabaseProxyRequest);
            return new AsyncInvoker<StartDatabaseProxyResponse>(this, "POST", request, JsonUtils.DeSerialize<StartDatabaseProxyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopDatabaseProxyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopDatabaseProxyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<StopDatabaseProxyResponse>(response);
        }

        public AsyncInvoker<StopDatabaseProxyResponse> StopDatabaseProxyAsyncInvoker(StopDatabaseProxyRequest stopDatabaseProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopDatabaseProxyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopDatabaseProxyRequest);
            return new AsyncInvoker<StopDatabaseProxyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<StopDatabaseProxyResponse>);
        }
        
        /// <summary>
        /// 中止/恢复wal日志回放
        ///
        /// 中止/恢复wal日志回放
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchLogReplayResponse> SwitchLogReplayAsync(SwitchLogReplayRequest switchLogReplayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchLogReplayRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/log-replay/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchLogReplayRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SwitchLogReplayResponse>(response);
        }

        public AsyncInvoker<SwitchLogReplayResponse> SwitchLogReplayAsyncInvoker(SwitchLogReplayRequest switchLogReplayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchLogReplayRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/log-replay/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchLogReplayRequest);
            return new AsyncInvoker<SwitchLogReplayResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchLogReplayResponse>);
        }
        
        /// <summary>
        /// 修改数据库owner
        ///
        /// 修改数据库owner
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDatabaseOwnerResponse> UpdateDatabaseOwnerAsync(UpdateDatabaseOwnerRequest updateDatabaseOwnerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDatabaseOwnerRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/owner", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDatabaseOwnerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateDatabaseOwnerResponse>(response);
        }

        public AsyncInvoker<UpdateDatabaseOwnerResponse> UpdateDatabaseOwnerAsyncInvoker(UpdateDatabaseOwnerRequest updateDatabaseOwnerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDatabaseOwnerRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/owner", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDatabaseOwnerRequest);
            return new AsyncInvoker<UpdateDatabaseOwnerResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateDatabaseOwnerResponse>);
        }
        
        /// <summary>
        /// 数据库帐号授权
        ///
        /// 数据库帐号授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDbUserPrivilegeResponse> UpdateDbUserPrivilegeAsync(UpdateDbUserPrivilegeRequest updateDbUserPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDbUserPrivilegeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDbUserPrivilegeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateDbUserPrivilegeResponse>(response);
        }

        public AsyncInvoker<UpdateDbUserPrivilegeResponse> UpdateDbUserPrivilegeAsyncInvoker(UpdateDbUserPrivilegeRequest updateDbUserPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDbUserPrivilegeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDbUserPrivilegeRequest);
            return new AsyncInvoker<UpdateDbUserPrivilegeResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateDbUserPrivilegeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePostgresqlDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdatePostgresqlDatabaseResponse>(response);
        }

        public AsyncInvoker<UpdatePostgresqlDatabaseResponse> UpdatePostgresqlDatabaseAsyncInvoker(UpdatePostgresqlDatabaseRequest updatePostgresqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePostgresqlDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlDatabaseRequest);
            return new AsyncInvoker<UpdatePostgresqlDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdatePostgresqlDatabaseResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePostgresqlDbUserCommentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updatePostgresqlDbUserCommentRequest.UserName, out var valueOfUserName)) urlParam.Add("user_name", valueOfUserName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/{user_name}/comment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlDbUserCommentRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePostgresqlDbUserCommentResponse>(response);
        }

        public AsyncInvoker<UpdatePostgresqlDbUserCommentResponse> UpdatePostgresqlDbUserCommentAsyncInvoker(UpdatePostgresqlDbUserCommentRequest updatePostgresqlDbUserCommentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePostgresqlDbUserCommentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updatePostgresqlDbUserCommentRequest.UserName, out var valueOfUserName)) urlParam.Add("user_name", valueOfUserName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/{user_name}/comment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlDbUserCommentRequest);
            return new AsyncInvoker<UpdatePostgresqlDbUserCommentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePostgresqlDbUserCommentResponse>);
        }
        
        /// <summary>
        /// 更新插件
        ///
        /// 在指定数据库上更新插件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePostgresqlExtensionResponse> UpdatePostgresqlExtensionAsync(UpdatePostgresqlExtensionRequest updatePostgresqlExtensionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePostgresqlExtensionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlExtensionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePostgresqlExtensionResponse>(response);
        }

        public AsyncInvoker<UpdatePostgresqlExtensionResponse> UpdatePostgresqlExtensionAsyncInvoker(UpdatePostgresqlExtensionRequest updatePostgresqlExtensionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePostgresqlExtensionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlExtensionRequest);
            return new AsyncInvoker<UpdatePostgresqlExtensionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePostgresqlExtensionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePostgresqlParameterValueRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updatePostgresqlParameterValueRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/parameter/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlParameterValueRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePostgresqlParameterValueResponse>(response);
        }

        public AsyncInvoker<UpdatePostgresqlParameterValueResponse> UpdatePostgresqlParameterValueAsyncInvoker(UpdatePostgresqlParameterValueRequest updatePostgresqlParameterValueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePostgresqlParameterValueRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updatePostgresqlParameterValueRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/parameter/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlParameterValueRequest);
            return new AsyncInvoker<UpdatePostgresqlParameterValueResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePostgresqlParameterValueResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateReadWeightRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/weight", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReadWeightRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateReadWeightResponse>(response);
        }

        public AsyncInvoker<UpdateReadWeightResponse> UpdateReadWeightAsyncInvoker(UpdateReadWeightRequest updateReadWeightRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateReadWeightRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/weight", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReadWeightRequest);
            return new AsyncInvoker<UpdateReadWeightResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateReadWeightResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(allowSqlserverDbUserPrivilegeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowSqlserverDbUserPrivilegeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AllowSqlserverDbUserPrivilegeResponse>(response);
        }

        public AsyncInvoker<AllowSqlserverDbUserPrivilegeResponse> AllowSqlserverDbUserPrivilegeAsyncInvoker(AllowSqlserverDbUserPrivilegeRequest allowSqlserverDbUserPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(allowSqlserverDbUserPrivilegeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowSqlserverDbUserPrivilegeRequest);
            return new AsyncInvoker<AllowSqlserverDbUserPrivilegeResponse>(this, "POST", request, JsonUtils.DeSerialize<AllowSqlserverDbUserPrivilegeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchAddMsdtcsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/msdtc/host", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddMsdtcsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchAddMsdtcsResponse>(response);
        }

        public AsyncInvoker<BatchAddMsdtcsResponse> BatchAddMsdtcsAsyncInvoker(BatchAddMsdtcsRequest batchAddMsdtcsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchAddMsdtcsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/msdtc/host", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddMsdtcsRequest);
            return new AsyncInvoker<BatchAddMsdtcsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAddMsdtcsResponse>);
        }
        
        /// <summary>
        /// 复制数据库
        ///
        /// 复制数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CopyDatabaseResponse> CopyDatabaseAsync(CopyDatabaseRequest copyDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(copyDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/procedure", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CopyDatabaseResponse>(response);
        }

        public AsyncInvoker<CopyDatabaseResponse> CopyDatabaseAsyncInvoker(CopyDatabaseRequest copyDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(copyDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/procedure", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyDatabaseRequest);
            return new AsyncInvoker<CopyDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyDatabaseResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSqlserverDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSqlserverDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSqlserverDatabaseResponse>(response);
        }

        public AsyncInvoker<CreateSqlserverDatabaseResponse> CreateSqlserverDatabaseAsyncInvoker(CreateSqlserverDatabaseRequest createSqlserverDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSqlserverDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSqlserverDatabaseRequest);
            return new AsyncInvoker<CreateSqlserverDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSqlserverDatabaseResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSqlserverDbUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSqlserverDbUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSqlserverDbUserResponse>(response);
        }

        public AsyncInvoker<CreateSqlserverDbUserResponse> CreateSqlserverDbUserAsyncInvoker(CreateSqlserverDbUserRequest createSqlserverDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSqlserverDbUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSqlserverDbUserRequest);
            return new AsyncInvoker<CreateSqlserverDbUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSqlserverDbUserResponse>);
        }
        
        /// <summary>
        /// 删除MSDTC
        ///
        /// 删除MSDTC相关主机host地址
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteMsdtcLocalHostResponse> DeleteMsdtcLocalHostAsync(DeleteMsdtcLocalHostRequest deleteMsdtcLocalHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMsdtcLocalHostRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/msdtc/host", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMsdtcLocalHostRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteMsdtcLocalHostResponse>(response);
        }

        public AsyncInvoker<DeleteMsdtcLocalHostResponse> DeleteMsdtcLocalHostAsyncInvoker(DeleteMsdtcLocalHostRequest deleteMsdtcLocalHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMsdtcLocalHostRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/msdtc/host", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMsdtcLocalHostRequest);
            return new AsyncInvoker<DeleteMsdtcLocalHostResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteMsdtcLocalHostResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSqlserverDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSqlserverDatabaseRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/{db_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlserverDatabaseRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSqlserverDatabaseResponse>(response);
        }

        public AsyncInvoker<DeleteSqlserverDatabaseResponse> DeleteSqlserverDatabaseAsyncInvoker(DeleteSqlserverDatabaseRequest deleteSqlserverDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSqlserverDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSqlserverDatabaseRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/{db_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlserverDatabaseRequest);
            return new AsyncInvoker<DeleteSqlserverDatabaseResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSqlserverDatabaseResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSqlserverDatabaseExRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSqlserverDatabaseExRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/database/{db_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlserverDatabaseExRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSqlserverDatabaseExResponse>(response);
        }

        public AsyncInvoker<DeleteSqlserverDatabaseExResponse> DeleteSqlserverDatabaseExAsyncInvoker(DeleteSqlserverDatabaseExRequest deleteSqlserverDatabaseExRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSqlserverDatabaseExRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSqlserverDatabaseExRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/database/{db_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlserverDatabaseExRequest);
            return new AsyncInvoker<DeleteSqlserverDatabaseExResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSqlserverDatabaseExResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSqlserverDbUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSqlserverDbUserRequest.UserName, out var valueOfUserName)) urlParam.Add("user_name", valueOfUserName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlserverDbUserRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSqlserverDbUserResponse>(response);
        }

        public AsyncInvoker<DeleteSqlserverDbUserResponse> DeleteSqlserverDbUserAsyncInvoker(DeleteSqlserverDbUserRequest deleteSqlserverDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSqlserverDbUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSqlserverDbUserRequest.UserName, out var valueOfUserName)) urlParam.Add("user_name", valueOfUserName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlserverDbUserRequest);
            return new AsyncInvoker<DeleteSqlserverDbUserResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSqlserverDbUserResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuthorizedSqlserverDbUsersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/db_user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorizedSqlserverDbUsersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuthorizedSqlserverDbUsersResponse>(response);
        }

        public AsyncInvoker<ListAuthorizedSqlserverDbUsersResponse> ListAuthorizedSqlserverDbUsersAsyncInvoker(ListAuthorizedSqlserverDbUsersRequest listAuthorizedSqlserverDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuthorizedSqlserverDbUsersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/db_user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorizedSqlserverDbUsersRequest);
            return new AsyncInvoker<ListAuthorizedSqlserverDbUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuthorizedSqlserverDbUsersResponse>);
        }
        
        /// <summary>
        /// 查询云市场服务商列表
        ///
        /// 查询云市场服务商列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBusinessPartnersResponse> ListBusinessPartnersAsync(ListBusinessPartnersRequest listBusinessPartnersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/business-partners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBusinessPartnersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBusinessPartnersResponse>(response);
        }

        public AsyncInvoker<ListBusinessPartnersResponse> ListBusinessPartnersAsyncInvoker(ListBusinessPartnersRequest listBusinessPartnersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/business-partners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBusinessPartnersRequest);
            return new AsyncInvoker<ListBusinessPartnersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBusinessPartnersResponse>);
        }
        
        /// <summary>
        /// 查询云市场引擎商品列表
        ///
        /// 查询云市场引擎商品列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMarketplaceEngineProductsResponse> ListMarketplaceEngineProductsAsync(ListMarketplaceEngineProductsRequest listMarketplaceEngineProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMarketplaceEngineProductsRequest.BpDomainId, out var valueOfBpDomainId)) urlParam.Add("bp_domain_id", valueOfBpDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/business-partner/{bp_domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMarketplaceEngineProductsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMarketplaceEngineProductsResponse>(response);
        }

        public AsyncInvoker<ListMarketplaceEngineProductsResponse> ListMarketplaceEngineProductsAsyncInvoker(ListMarketplaceEngineProductsRequest listMarketplaceEngineProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMarketplaceEngineProductsRequest.BpDomainId, out var valueOfBpDomainId)) urlParam.Add("bp_domain_id", valueOfBpDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/business-partner/{bp_domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMarketplaceEngineProductsRequest);
            return new AsyncInvoker<ListMarketplaceEngineProductsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMarketplaceEngineProductsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMsdtcHostsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/msdtc/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMsdtcHostsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMsdtcHostsResponse>(response);
        }

        public AsyncInvoker<ListMsdtcHostsResponse> ListMsdtcHostsAsyncInvoker(ListMsdtcHostsRequest listMsdtcHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMsdtcHostsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/msdtc/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMsdtcHostsRequest);
            return new AsyncInvoker<ListMsdtcHostsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMsdtcHostsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlserverDatabasesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlserverDatabasesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSqlserverDatabasesResponse>(response);
        }

        public AsyncInvoker<ListSqlserverDatabasesResponse> ListSqlserverDatabasesAsyncInvoker(ListSqlserverDatabasesRequest listSqlserverDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlserverDatabasesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlserverDatabasesRequest);
            return new AsyncInvoker<ListSqlserverDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSqlserverDatabasesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlserverDbUsersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlserverDbUsersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSqlserverDbUsersResponse>(response);
        }

        public AsyncInvoker<ListSqlserverDbUsersResponse> ListSqlserverDbUsersAsyncInvoker(ListSqlserverDbUsersRequest listSqlserverDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlserverDbUsersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlserverDbUsersRequest);
            return new AsyncInvoker<ListSqlserverDbUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSqlserverDbUsersResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyCollationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/collations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyCollationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyCollationResponse>(response);
        }

        public AsyncInvoker<ModifyCollationResponse> ModifyCollationAsyncInvoker(ModifyCollationRequest modifyCollationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyCollationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/collations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyCollationRequest);
            return new AsyncInvoker<ModifyCollationResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyCollationResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(revokeSqlserverDbUserPrivilegeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeSqlserverDbUserPrivilegeRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<RevokeSqlserverDbUserPrivilegeResponse>(response);
        }

        public AsyncInvoker<RevokeSqlserverDbUserPrivilegeResponse> RevokeSqlserverDbUserPrivilegeAsyncInvoker(RevokeSqlserverDbUserPrivilegeRequest revokeSqlserverDbUserPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(revokeSqlserverDbUserPrivilegeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeSqlserverDbUserPrivilegeRequest);
            return new AsyncInvoker<RevokeSqlserverDbUserPrivilegeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<RevokeSqlserverDbUserPrivilegeResponse>);
        }
        
        /// <summary>
        /// 收缩数据库日志
        ///
        /// 收缩数据库日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetInstancesDbShrinkResponse> SetInstancesDbShrinkAsync(SetInstancesDbShrinkRequest setInstancesDbShrinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setInstancesDbShrinkRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_shrink", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setInstancesDbShrinkRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetInstancesDbShrinkResponse>(response);
        }

        public AsyncInvoker<SetInstancesDbShrinkResponse> SetInstancesDbShrinkAsyncInvoker(SetInstancesDbShrinkRequest setInstancesDbShrinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setInstancesDbShrinkRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_shrink", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setInstancesDbShrinkRequest);
            return new AsyncInvoker<SetInstancesDbShrinkResponse>(this, "POST", request, JsonUtils.DeSerialize<SetInstancesDbShrinkResponse>);
        }
        
        /// <summary>
        /// 收缩数据库日志
        ///
        /// 收缩数据库日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetInstancesNewDbShrinkResponse> SetInstancesNewDbShrinkAsync(SetInstancesNewDbShrinkRequest setInstancesNewDbShrinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setInstancesNewDbShrinkRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-shrink", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setInstancesNewDbShrinkRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetInstancesNewDbShrinkResponse>(response);
        }

        public AsyncInvoker<SetInstancesNewDbShrinkResponse> SetInstancesNewDbShrinkAsyncInvoker(SetInstancesNewDbShrinkRequest setInstancesNewDbShrinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setInstancesNewDbShrinkRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-shrink", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setInstancesNewDbShrinkRequest);
            return new AsyncInvoker<SetInstancesNewDbShrinkResponse>(this, "POST", request, JsonUtils.DeSerialize<SetInstancesNewDbShrinkResponse>);
        }
        
        /// <summary>
        /// 查询sql统计列表
        ///
        /// 查询sql统计列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSqlStatisticsResponse> ListSqlStatisticsAsync(ListSqlStatisticsRequest listSqlStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlStatisticsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSqlStatisticsResponse>(response);
        }

        public AsyncInvoker<ListSqlStatisticsResponse> ListSqlStatisticsAsyncInvoker(ListSqlStatisticsRequest listSqlStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlStatisticsRequest);
            return new AsyncInvoker<ListSqlStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSqlStatisticsResponse>);
        }
        
        /// <summary>
        /// sql统计视图重置
        ///
        /// sql统计视图重置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetViewSqlStatisticsResponse> ResetViewSqlStatisticsAsync(ResetViewSqlStatisticsRequest resetViewSqlStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetViewSqlStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-statistics/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetViewSqlStatisticsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResetViewSqlStatisticsResponse>(response);
        }

        public AsyncInvoker<ResetViewSqlStatisticsResponse> ResetViewSqlStatisticsAsyncInvoker(ResetViewSqlStatisticsRequest resetViewSqlStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetViewSqlStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-statistics/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetViewSqlStatisticsRequest);
            return new AsyncInvoker<ResetViewSqlStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetViewSqlStatisticsResponse>);
        }
        
    }
}