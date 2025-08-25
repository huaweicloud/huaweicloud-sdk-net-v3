using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Rds.V3.Model;

namespace HuaweiCloud.SDK.Rds.V3
{
    public partial class RdsClient : Client
    {
        public static ClientBuilder<RdsClient> NewBuilder()
        {
            return new ClientBuilder<RdsClient>();
        }

        
        /// <summary>
        /// 在pg_hba.conf文件最后新增单个或多个配置
        ///
        /// 以传入配置全量覆盖当前pg_hba.conf文件内容，入参为空时用默认配置覆盖当前文件内容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddPostgresqlHbaConfResponse AddPostgresqlHbaConf(AddPostgresqlHbaConfRequest addPostgresqlHbaConfRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addPostgresqlHbaConfRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addPostgresqlHbaConfRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddPostgresqlHbaConfResponse>(response);
        }

        public SyncInvoker<AddPostgresqlHbaConfResponse> AddPostgresqlHbaConfInvoker(AddPostgresqlHbaConfRequest addPostgresqlHbaConfRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addPostgresqlHbaConfRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addPostgresqlHbaConfRequest);
            return new SyncInvoker<AddPostgresqlHbaConfResponse>(this, "POST", request, JsonUtils.DeSerialize<AddPostgresqlHbaConfResponse>);
        }
        
        /// <summary>
        /// 应用参数模板
        ///
        /// 应用参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ApplyConfigurationAsyncResponse ApplyConfigurationAsync(ApplyConfigurationAsyncRequest applyConfigurationAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", applyConfigurationAsyncRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyConfigurationAsyncRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ApplyConfigurationAsyncResponse>(response);
        }

        public SyncInvoker<ApplyConfigurationAsyncResponse> ApplyConfigurationAsyncInvoker(ApplyConfigurationAsyncRequest applyConfigurationAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", applyConfigurationAsyncRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyConfigurationAsyncRequest);
            return new SyncInvoker<ApplyConfigurationAsyncResponse>(this, "PUT", request, JsonUtils.DeSerialize<ApplyConfigurationAsyncResponse>);
        }
        
        /// <summary>
        /// 绑定和解绑弹性公网IP
        ///
        /// 绑定和解绑弹性公网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AttachEipResponse AttachEip(AttachEipRequest attachEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", attachEipRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachEipRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<AttachEipResponse>(response);
        }

        public SyncInvoker<AttachEipResponse> AttachEipInvoker(AttachEipRequest attachEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", attachEipRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachEipRequest);
            return new SyncInvoker<AttachEipResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AttachEipResponse>);
        }
        
        /// <summary>
        /// 批量删除手动备份
        ///
        /// 批量删除手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteManualBackupResponse BatchDeleteManualBackup(BatchDeleteManualBackupRequest batchDeleteManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteManualBackupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteManualBackupResponse>(response);
        }

        public SyncInvoker<BatchDeleteManualBackupResponse> BatchDeleteManualBackupInvoker(BatchDeleteManualBackupRequest batchDeleteManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteManualBackupRequest);
            return new SyncInvoker<BatchDeleteManualBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteManualBackupResponse>);
        }
        
        /// <summary>
        /// 库级时间点恢复
        ///
        /// 库级时间点恢复
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchRestoreDatabaseResponse BatchRestoreDatabase(BatchRestoreDatabaseRequest batchRestoreDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/batch/restore/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestoreDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchRestoreDatabaseResponse>(response);
        }

        public SyncInvoker<BatchRestoreDatabaseResponse> BatchRestoreDatabaseInvoker(BatchRestoreDatabaseRequest batchRestoreDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/batch/restore/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestoreDatabaseRequest);
            return new SyncInvoker<BatchRestoreDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRestoreDatabaseResponse>);
        }
        
        /// <summary>
        /// 表级时间点恢复（PostgreSQL）
        ///
        /// 表级时间点恢复（PostgreSQL）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchRestorePostgreSqlTablesResponse BatchRestorePostgreSqlTables(BatchRestorePostgreSqlTablesRequest batchRestorePostgreSqlTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/batch/restore/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestorePostgreSqlTablesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchRestorePostgreSqlTablesResponse>(response);
        }

        public SyncInvoker<BatchRestorePostgreSqlTablesResponse> BatchRestorePostgreSqlTablesInvoker(BatchRestorePostgreSqlTablesRequest batchRestorePostgreSqlTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/batch/restore/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestorePostgreSqlTablesRequest);
            return new SyncInvoker<BatchRestorePostgreSqlTablesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRestorePostgreSqlTablesResponse>);
        }
        
        /// <summary>
        /// 批量停止实例
        ///
        /// 批量停止实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchStopInstanceResponse BatchStopInstance(BatchStopInstanceRequest batchStopInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/batch/action/shutdown", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStopInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchStopInstanceResponse>(response);
        }

        public SyncInvoker<BatchStopInstanceResponse> BatchStopInstanceInvoker(BatchStopInstanceRequest batchStopInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/batch/action/shutdown", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStopInstanceRequest);
            return new SyncInvoker<BatchStopInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchStopInstanceResponse>);
        }
        
        /// <summary>
        /// 批量添加标签
        ///
        /// 批量添加标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchTagAddActionResponse BatchTagAddAction(BatchTagAddActionRequest batchTagAddActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchTagAddActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagAddActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchTagAddActionResponse>(response);
        }

        public SyncInvoker<BatchTagAddActionResponse> BatchTagAddActionInvoker(BatchTagAddActionRequest batchTagAddActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchTagAddActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagAddActionRequest);
            return new SyncInvoker<BatchTagAddActionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchTagAddActionResponse>);
        }
        
        /// <summary>
        /// 批量删除标签
        ///
        /// 批量删除标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchTagDelActionResponse BatchTagDelAction(BatchTagDelActionRequest batchTagDelActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchTagDelActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagDelActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchTagDelActionResponse>(response);
        }

        public SyncInvoker<BatchTagDelActionResponse> BatchTagDelActionInvoker(BatchTagDelActionRequest batchTagDelActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchTagDelActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagDelActionRequest);
            return new SyncInvoker<BatchTagDelActionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchTagDelActionResponse>);
        }
        
        /// <summary>
        /// 更改主备实例的数据同步方式
        ///
        /// 更改主备实例的数据同步方式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeFailoverModeResponse ChangeFailoverMode(ChangeFailoverModeRequest changeFailoverModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeFailoverModeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/failover/mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeFailoverModeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ChangeFailoverModeResponse>(response);
        }

        public SyncInvoker<ChangeFailoverModeResponse> ChangeFailoverModeInvoker(ChangeFailoverModeRequest changeFailoverModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeFailoverModeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/failover/mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeFailoverModeRequest);
            return new SyncInvoker<ChangeFailoverModeResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeFailoverModeResponse>);
        }
        
        /// <summary>
        /// 切换主备实例的倒换策略
        ///
        /// 切换主备实例的倒换策略.
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeFailoverStrategyResponse ChangeFailoverStrategy(ChangeFailoverStrategyRequest changeFailoverStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeFailoverStrategyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/failover/strategy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeFailoverStrategyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ChangeFailoverStrategyResponse>(response);
        }

        public SyncInvoker<ChangeFailoverStrategyResponse> ChangeFailoverStrategyInvoker(ChangeFailoverStrategyRequest changeFailoverStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeFailoverStrategyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/failover/strategy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeFailoverStrategyRequest);
            return new SyncInvoker<ChangeFailoverStrategyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ChangeFailoverStrategyResponse>);
        }
        
        /// <summary>
        /// 设置可维护时间段
        ///
        /// 设置可维护时间段
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeOpsWindowResponse ChangeOpsWindow(ChangeOpsWindowRequest changeOpsWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeOpsWindowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ops-window", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeOpsWindowRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ChangeOpsWindowResponse>(response);
        }

        public SyncInvoker<ChangeOpsWindowResponse> ChangeOpsWindowInvoker(ChangeOpsWindowRequest changeOpsWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeOpsWindowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ops-window", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeOpsWindowRequest);
            return new SyncInvoker<ChangeOpsWindowResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ChangeOpsWindowResponse>);
        }
        
        /// <summary>
        /// 大版本升级预检查
        ///
        /// 提供mysql5.7升级mysql8.0预检查接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckInstanceForUpgradeResponse CheckInstanceForUpgrade(CheckInstanceForUpgradeRequest checkInstanceForUpgradeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", checkInstanceForUpgradeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/upgrade-version/precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkInstanceForUpgradeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<CheckInstanceForUpgradeResponse>(response);
        }

        public SyncInvoker<CheckInstanceForUpgradeResponse> CheckInstanceForUpgradeInvoker(CheckInstanceForUpgradeRequest checkInstanceForUpgradeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", checkInstanceForUpgradeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/upgrade-version/precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkInstanceForUpgradeRequest);
            return new SyncInvoker<CheckInstanceForUpgradeResponse>(this, "PUT", request, JsonUtils.DeSerialize<CheckInstanceForUpgradeResponse>);
        }
        
        /// <summary>
        /// 复制参数模板
        ///
        /// 复制参数模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CopyConfigurationResponse CopyConfiguration(CopyConfigurationRequest copyConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", copyConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyConfigurationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CopyConfigurationResponse>(response);
        }

        public SyncInvoker<CopyConfigurationResponse> CopyConfigurationInvoker(CopyConfigurationRequest copyConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", copyConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyConfigurationRequest);
            return new SyncInvoker<CopyConfigurationResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyConfigurationResponse>);
        }
        
        /// <summary>
        /// 创建参数模板
        ///
        /// 创建参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateConfigurationResponse CreateConfiguration(CreateConfigurationRequest createConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfigurationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateConfigurationResponse>(response);
        }

        public SyncInvoker<CreateConfigurationResponse> CreateConfigurationInvoker(CreateConfigurationRequest createConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfigurationRequest);
            return new SyncInvoker<CreateConfigurationResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateConfigurationResponse>);
        }
        
        /// <summary>
        /// 申请域名
        ///
        /// 申请域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDnsNameResponse CreateDnsName(CreateDnsNameRequest createDnsNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDnsNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/create-dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDnsNameRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDnsNameResponse>(response);
        }

        public SyncInvoker<CreateDnsNameResponse> CreateDnsNameInvoker(CreateDnsNameRequest createDnsNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDnsNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/create-dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDnsNameRequest);
            return new SyncInvoker<CreateDnsNameResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDnsNameResponse>);
        }
        
        /// <summary>
        /// 创建数据库实例
        ///
        /// 创建数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceResponse>(response);
        }

        public SyncInvoker<CreateInstanceResponse> CreateInstanceInvoker(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRequest);
            return new SyncInvoker<CreateInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceResponse>);
        }
        
        /// <summary>
        /// 创建数据库实例V5接口，仅支持IAM5的新平面认证方式（AK/SK认证方式）
        ///
        /// 创建数据库实例V5接口，仅支持IAM5的新平面认证方式（AK/SK认证方式）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceIam5Response CreateInstanceIam5(CreateInstanceIam5Request createInstanceIam5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceIam5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceIam5Response>(response);
        }

        public SyncInvoker<CreateInstanceIam5Response> CreateInstanceIam5Invoker(CreateInstanceIam5Request createInstanceIam5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceIam5Request);
            return new SyncInvoker<CreateInstanceIam5Response>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceIam5Response>);
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
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createManualBackupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateManualBackupResponse>(response);
        }

        public SyncInvoker<CreateManualBackupResponse> CreateManualBackupInvoker(CreateManualBackupRequest createManualBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createManualBackupRequest);
            return new SyncInvoker<CreateManualBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateManualBackupResponse>);
        }
        
        /// <summary>
        /// 开启数据库代理
        ///
        /// 开启数据库代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRdSforMySqlProxyResponse CreateRdSforMySqlProxy(CreateRdSforMySqlProxyRequest createRdSforMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createRdSforMySqlProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/open", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRdSforMySqlProxyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRdSforMySqlProxyResponse>(response);
        }

        public SyncInvoker<CreateRdSforMySqlProxyResponse> CreateRdSforMySqlProxyInvoker(CreateRdSforMySqlProxyRequest createRdSforMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createRdSforMySqlProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/open", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRdSforMySqlProxyRequest);
            return new SyncInvoker<CreateRdSforMySqlProxyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRdSforMySqlProxyResponse>);
        }
        
        /// <summary>
        /// 恢复到新实例
        ///
        /// 恢复到新实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRestoreInstanceResponse CreateRestoreInstance(CreateRestoreInstanceRequest createRestoreInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRestoreInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRestoreInstanceResponse>(response);
        }

        public SyncInvoker<CreateRestoreInstanceResponse> CreateRestoreInstanceInvoker(CreateRestoreInstanceRequest createRestoreInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRestoreInstanceRequest);
            return new SyncInvoker<CreateRestoreInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRestoreInstanceResponse>);
        }
        
        /// <summary>
        /// 新增SQL限流
        ///
        /// 新增SQL限流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSqlLimitResponse CreateSqlLimit(CreateSqlLimitRequest createSqlLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createSqlLimitRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-limit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSqlLimitRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSqlLimitResponse>(response);
        }

        public SyncInvoker<CreateSqlLimitResponse> CreateSqlLimitInvoker(CreateSqlLimitRequest createSqlLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createSqlLimitRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-limit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSqlLimitRequest);
            return new SyncInvoker<CreateSqlLimitResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSqlLimitResponse>);
        }
        
        /// <summary>
        /// 获取扩展日志下载信息
        ///
        /// 获取扩展日志下载信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateXelLogDownloadResponse CreateXelLogDownload(CreateXelLogDownloadRequest createXelLogDownloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createXelLogDownloadRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/xellog-download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createXelLogDownloadRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateXelLogDownloadResponse>(response);
        }

        public SyncInvoker<CreateXelLogDownloadResponse> CreateXelLogDownloadInvoker(CreateXelLogDownloadRequest createXelLogDownloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createXelLogDownloadRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/xellog-download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createXelLogDownloadRequest);
            return new SyncInvoker<CreateXelLogDownloadResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateXelLogDownloadResponse>);
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
        /// 解除实例容灾关系接口
        ///
        /// 解除实例容灾关系接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDisasterRecoveryResponse DeleteDisasterRecovery(DeleteDisasterRecoveryRequest deleteDisasterRecoveryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDisasterRecoveryRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/delete-disaster-recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDisasterRecoveryRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDisasterRecoveryResponse>(response);
        }

        public SyncInvoker<DeleteDisasterRecoveryResponse> DeleteDisasterRecoveryInvoker(DeleteDisasterRecoveryRequest deleteDisasterRecoveryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDisasterRecoveryRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/delete-disaster-recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDisasterRecoveryRequest);
            return new SyncInvoker<DeleteDisasterRecoveryResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDisasterRecoveryResponse>);
        }
        
        /// <summary>
        /// 删除数据库实例
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
        /// 删除即时任务
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteJobResponse DeleteJob(DeleteJobRequest deleteJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJobRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteJobResponse>(response);
        }

        public SyncInvoker<DeleteJobResponse> DeleteJobInvoker(DeleteJobRequest deleteJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJobRequest);
            return new SyncInvoker<DeleteJobResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteJobResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 解除LTS配置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLogLtsConfigsResponse DeleteLogLtsConfigs(DeleteLogLtsConfigsRequest deleteLogLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", deleteLogLtsConfigsRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{engine}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogLtsConfigsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLogLtsConfigsResponse>(response);
        }

        public SyncInvoker<DeleteLogLtsConfigsResponse> DeleteLogLtsConfigsInvoker(DeleteLogLtsConfigsRequest deleteLogLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", deleteLogLtsConfigsRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{engine}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogLtsConfigsRequest);
            return new SyncInvoker<DeleteLogLtsConfigsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLogLtsConfigsResponse>);
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
        /// 删除pg_hba.conf文件的单个或多个配置
        ///
        /// 删除pg_hba.conf文件的单个或多个配置，以priority做唯一标识
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePostgresqlHbaConfResponse DeletePostgresqlHbaConf(DeletePostgresqlHbaConfRequest deletePostgresqlHbaConfRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deletePostgresqlHbaConfRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePostgresqlHbaConfRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePostgresqlHbaConfResponse>(response);
        }

        public SyncInvoker<DeletePostgresqlHbaConfResponse> DeletePostgresqlHbaConfInvoker(DeletePostgresqlHbaConfRequest deletePostgresqlHbaConfRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deletePostgresqlHbaConfRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePostgresqlHbaConfRequest);
            return new SyncInvoker<DeletePostgresqlHbaConfResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePostgresqlHbaConfResponse>);
        }
        
        /// <summary>
        /// 关闭数据库代理
        ///
        /// 关闭数据库代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRdSforMySqlProxyResponse DeleteRdSforMySqlProxy(DeleteRdSforMySqlProxyRequest deleteRdSforMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteRdSforMySqlProxyRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", deleteRdSforMySqlProxyRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRdSforMySqlProxyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteRdSforMySqlProxyResponse>(response);
        }

        public SyncInvoker<DeleteRdSforMySqlProxyResponse> DeleteRdSforMySqlProxyInvoker(DeleteRdSforMySqlProxyRequest deleteRdSforMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteRdSforMySqlProxyRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", deleteRdSforMySqlProxyRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRdSforMySqlProxyRequest);
            return new SyncInvoker<DeleteRdSforMySqlProxyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteRdSforMySqlProxyResponse>);
        }
        
        /// <summary>
        /// 删除SQL限流
        ///
        /// 删除SQL限流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSqlLimitResponse DeleteSqlLimit(DeleteSqlLimitRequest deleteSqlLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteSqlLimitRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-limit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlLimitRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSqlLimitResponse>(response);
        }

        public SyncInvoker<DeleteSqlLimitResponse> DeleteSqlLimitInvoker(DeleteSqlLimitRequest deleteSqlLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteSqlLimitRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-limit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlLimitRequest);
            return new SyncInvoker<DeleteSqlLimitResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSqlLimitResponse>);
        }
        
        /// <summary>
        /// 获取错误日志下载链接
        ///
        /// 获取错误日志下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadErrorlogResponse DownloadErrorlog(DownloadErrorlogRequest downloadErrorlogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", downloadErrorlogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/errorlog-download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadErrorlogRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DownloadErrorlogResponse>(response);
        }

        public SyncInvoker<DownloadErrorlogResponse> DownloadErrorlogInvoker(DownloadErrorlogRequest downloadErrorlogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", downloadErrorlogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/errorlog-download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadErrorlogRequest);
            return new SyncInvoker<DownloadErrorlogResponse>(this, "POST", request, JsonUtils.DeSerialize<DownloadErrorlogResponse>);
        }
        
        /// <summary>
        /// 获取慢日志下载链接
        ///
        /// 获取慢日志下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadSlowlogResponse DownloadSlowlog(DownloadSlowlogRequest downloadSlowlogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", downloadSlowlogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSlowlogRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DownloadSlowlogResponse>(response);
        }

        public SyncInvoker<DownloadSlowlogResponse> DownloadSlowlogInvoker(DownloadSlowlogRequest downloadSlowlogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", downloadSlowlogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSlowlogRequest);
            return new SyncInvoker<DownloadSlowlogResponse>(this, "POST", request, JsonUtils.DeSerialize<DownloadSlowlogResponse>);
        }
        
        /// <summary>
        /// 应用参数模板
        ///
        /// 应用参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableConfigurationResponse EnableConfiguration(EnableConfigurationRequest enableConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", enableConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<EnableConfigurationResponse>(response);
        }

        public SyncInvoker<EnableConfigurationResponse> EnableConfigurationInvoker(EnableConfigurationRequest enableConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", enableConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableConfigurationRequest);
            return new SyncInvoker<EnableConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<EnableConfigurationResponse>);
        }
        
        /// <summary>
        /// 获取审计日志列表
        ///
        /// 获取审计日志列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditlogsResponse ListAuditlogs(ListAuditlogsRequest listAuditlogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditlogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditlogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditlogsResponse>(response);
        }

        public SyncInvoker<ListAuditlogsResponse> ListAuditlogsInvoker(ListAuditlogsRequest listAuditlogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditlogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditlogsRequest);
            return new SyncInvoker<ListAuditlogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditlogsResponse>);
        }
        
        /// <summary>
        /// 查询转储任务列表
        ///
        /// 查询转储任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBackupTransfersResponse ListBackupTransfers(ListBackupTransfersRequest listBackupTransfersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transfer-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupTransfersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBackupTransfersResponse>(response);
        }

        public SyncInvoker<ListBackupTransfersResponse> ListBackupTransfersInvoker(ListBackupTransfersRequest listBackupTransfersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transfer-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupTransfersRequest);
            return new SyncInvoker<ListBackupTransfersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBackupTransfersResponse>);
        }
        
        /// <summary>
        /// 获取备份列表
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
        /// 查询SQLServer可用字符集
        ///
        /// 查询SQLServer可用字符集
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCollationsResponse ListCollations(ListCollationsRequest listCollationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/collations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCollationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCollationsResponse>(response);
        }

        public SyncInvoker<ListCollationsResponse> ListCollationsInvoker(ListCollationsRequest listCollationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/collations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCollationsRequest);
            return new SyncInvoker<ListCollationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCollationsResponse>);
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
        /// 查询数据库引擎的版本
        ///
        /// 查询数据库引擎的版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDatastoresResponse ListDatastores(ListDatastoresRequest listDatastoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name", listDatastoresRequest.DatabaseName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoresRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDatastoresResponse>(response);
        }

        public SyncInvoker<ListDatastoresResponse> ListDatastoresInvoker(ListDatastoresRequest listDatastoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name", listDatastoresRequest.DatabaseName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoresRequest);
            return new SyncInvoker<ListDatastoresResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatastoresResponse>);
        }
        
        /// <summary>
        /// 查询容灾管理列表
        ///
        /// 查询容灾管理列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDrInfosResponse ListDrInfos(ListDrInfosRequest listDrInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/disaster-recovery-infos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDrInfosRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListDrInfosResponse>(response);
        }

        public SyncInvoker<ListDrInfosResponse> ListDrInfosInvoker(ListDrInfosRequest listDrInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/disaster-recovery-infos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDrInfosRequest);
            return new SyncInvoker<ListDrInfosResponse>(this, "POST", request, JsonUtils.DeSerialize<ListDrInfosResponse>);
        }
        
        /// <summary>
        /// 批量查询容灾实例信息
        ///
        /// 批量查询容灾实例信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDrRelationsResponse ListDrRelations(ListDrRelationsRequest listDrRelationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/disaster-recovery-relation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDrRelationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDrRelationsResponse>(response);
        }

        public SyncInvoker<ListDrRelationsResponse> ListDrRelationsInvoker(ListDrRelationsRequest listDrRelationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/disaster-recovery-relation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDrRelationsRequest);
            return new SyncInvoker<ListDrRelationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDrRelationsResponse>);
        }
        
        /// <summary>
        /// 查询实例可变更规格
        ///
        /// 查询实例可变更规格
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEngineFlavorsResponse ListEngineFlavors(ListEngineFlavorsRequest listEngineFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listEngineFlavorsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/available-flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEngineFlavorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEngineFlavorsResponse>(response);
        }

        public SyncInvoker<ListEngineFlavorsResponse> ListEngineFlavorsInvoker(ListEngineFlavorsRequest listEngineFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listEngineFlavorsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/available-flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEngineFlavorsRequest);
            return new SyncInvoker<ListEngineFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEngineFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询数据库错误日志
        ///
        /// 查询数据库错误日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListErrorLogsResponse ListErrorLogs(ListErrorLogsRequest listErrorLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listErrorLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/errorlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listErrorLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListErrorLogsResponse>(response);
        }

        public SyncInvoker<ListErrorLogsResponse> ListErrorLogsInvoker(ListErrorLogsRequest listErrorLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listErrorLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/errorlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listErrorLogsRequest);
            return new SyncInvoker<ListErrorLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListErrorLogsResponse>);
        }
        
        /// <summary>
        /// 查询数据库错误日志
        ///
        /// 查询数据库错误日志。(与原v3接口相比修改offset,符合华为云服务开放 API遵从性规范3.0)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListErrorLogsNewResponse ListErrorLogsNew(ListErrorLogsNewRequest listErrorLogsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listErrorLogsNewRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/errorlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listErrorLogsNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListErrorLogsNewResponse>(response);
        }

        public SyncInvoker<ListErrorLogsNewResponse> ListErrorLogsNewInvoker(ListErrorLogsNewRequest listErrorLogsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listErrorLogsNewRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/errorlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listErrorLogsNewRequest);
            return new SyncInvoker<ListErrorLogsNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListErrorLogsNewResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 查询实例的错误日志数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListErrorlogForLtsResponse ListErrorlogForLts(ListErrorlogForLtsRequest listErrorlogForLtsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listErrorlogForLtsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listErrorlogForLtsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListErrorlogForLtsResponse>(response);
        }

        public SyncInvoker<ListErrorlogForLtsResponse> ListErrorlogForLtsInvoker(ListErrorlogForLtsRequest listErrorlogForLtsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listErrorlogForLtsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listErrorlogForLtsRequest);
            return new SyncInvoker<ListErrorlogForLtsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListErrorlogForLtsResponse>);
        }
        
        /// <summary>
        /// 查询数据库规格
        ///
        /// 查询数据库规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFlavorsResponse ListFlavors(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name", listFlavorsRequest.DatabaseName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }

        public SyncInvoker<ListFlavorsResponse> ListFlavorsInvoker(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name", listFlavorsRequest.DatabaseName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            return new SyncInvoker<ListFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询数据库可变更规格接口
        ///
        /// 查询数据库可变更规格接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFlavorsResizeResponse ListFlavorsResize(ListFlavorsResizeRequest listFlavorsResizeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listFlavorsResizeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/flavors-resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsResizeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorsResizeResponse>(response);
        }

        public SyncInvoker<ListFlavorsResizeResponse> ListFlavorsResizeInvoker(ListFlavorsResizeRequest listFlavorsResizeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listFlavorsResizeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/flavors-resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsResizeRequest);
            return new SyncInvoker<ListFlavorsResizeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorsResizeResponse>);
        }
        
        /// <summary>
        /// 查询指定时间点可恢复的库
        ///
        /// 查询指定时间点可恢复的库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHistoryDatabaseResponse ListHistoryDatabase(ListHistoryDatabaseRequest listHistoryDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", listHistoryDatabaseRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{engine}/instances/history/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListHistoryDatabaseResponse>(response);
        }

        public SyncInvoker<ListHistoryDatabaseResponse> ListHistoryDatabaseInvoker(ListHistoryDatabaseRequest listHistoryDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", listHistoryDatabaseRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{engine}/instances/history/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryDatabaseRequest);
            return new SyncInvoker<ListHistoryDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<ListHistoryDatabaseResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 查询实例大版本升级检查历史。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInspectionHistoriesResponse ListInspectionHistories(ListInspectionHistoriesRequest listInspectionHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInspectionHistoriesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/inspection-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInspectionHistoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInspectionHistoriesResponse>(response);
        }

        public SyncInvoker<ListInspectionHistoriesResponse> ListInspectionHistoriesInvoker(ListInspectionHistoriesRequest listInspectionHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInspectionHistoriesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/inspection-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInspectionHistoriesRequest);
            return new SyncInvoker<ListInspectionHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInspectionHistoriesResponse>);
        }
        
        /// <summary>
        /// 获取诊断后的实例数量
        ///
        /// 获取诊断后的实例数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceDiagnosisResponse ListInstanceDiagnosis(ListInstanceDiagnosisRequest listInstanceDiagnosisRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/diagnosis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceDiagnosisRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceDiagnosisResponse>(response);
        }

        public SyncInvoker<ListInstanceDiagnosisResponse> ListInstanceDiagnosisInvoker(ListInstanceDiagnosisRequest listInstanceDiagnosisRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/diagnosis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceDiagnosisRequest);
            return new SyncInvoker<ListInstanceDiagnosisResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceDiagnosisResponse>);
        }
        
        /// <summary>
        /// 查询实例参数修改历史
        ///
        /// 实例参数修改历史。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceParamHistoriesResponse ListInstanceParamHistories(ListInstanceParamHistoriesRequest listInstanceParamHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceParamHistoriesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configuration-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceParamHistoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceParamHistoriesResponse>(response);
        }

        public SyncInvoker<ListInstanceParamHistoriesResponse> ListInstanceParamHistoriesInvoker(ListInstanceParamHistoriesRequest listInstanceParamHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceParamHistoriesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configuration-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceParamHistoriesRequest);
            return new SyncInvoker<ListInstanceParamHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceParamHistoriesResponse>);
        }
        
        /// <summary>
        /// 查询实例标签
        ///
        /// 查询实例标签。
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
        /// 查询数据库实例列表
        ///
        /// 查询数据库实例列表。
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
        /// 获取指定诊断项的诊断结果
        ///
        /// 获取指定诊断项的诊断结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstancesInfoDiagnosisResponse ListInstancesInfoDiagnosis(ListInstancesInfoDiagnosisRequest listInstancesInfoDiagnosisRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/diagnosis/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesInfoDiagnosisRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesInfoDiagnosisResponse>(response);
        }

        public SyncInvoker<ListInstancesInfoDiagnosisResponse> ListInstancesInfoDiagnosisInvoker(ListInstancesInfoDiagnosisRequest listInstancesInfoDiagnosisRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/diagnosis/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesInfoDiagnosisRequest);
            return new SyncInvoker<ListInstancesInfoDiagnosisResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesInfoDiagnosisResponse>);
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
        public ListInstancesSupportFastRestoreResponse ListInstancesSupportFastRestore(ListInstancesSupportFastRestoreRequest listInstancesSupportFastRestoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/fast-restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesSupportFastRestoreRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListInstancesSupportFastRestoreResponse>(response);
        }

        public SyncInvoker<ListInstancesSupportFastRestoreResponse> ListInstancesSupportFastRestoreInvoker(ListInstancesSupportFastRestoreRequest listInstancesSupportFastRestoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/fast-restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesSupportFastRestoreRequest);
            return new SyncInvoker<ListInstancesSupportFastRestoreResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInstancesSupportFastRestoreResponse>);
        }
        
        /// <summary>
        /// 获取指定ID的任务信息
        ///
        /// 获取指定ID的任务信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListJobInfoResponse ListJobInfo(ListJobInfoRequest listJobInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListJobInfoResponse>(response);
        }

        public SyncInvoker<ListJobInfoResponse> ListJobInfoInvoker(ListJobInfoRequest listJobInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobInfoRequest);
            return new SyncInvoker<ListJobInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobInfoResponse>);
        }
        
        /// <summary>
        /// 获取指定实例和时间范围的任务信息（SQL Server）
        ///
        /// 获取指定实例和时间范围的任务信息（SQL Server）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListJobInfoDetailResponse ListJobInfoDetail(ListJobInfoDetailRequest listJobInfoDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listJobInfoDetailRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tasklist/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobInfoDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListJobInfoDetailResponse>(response);
        }

        public SyncInvoker<ListJobInfoDetailResponse> ListJobInfoDetailInvoker(ListJobInfoDetailRequest listJobInfoDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listJobInfoDetailRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tasklist/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobInfoDetailRequest);
            return new SyncInvoker<ListJobInfoDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobInfoDetailResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 获取LTS配置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLogLtsConfigsResponse ListLogLtsConfigs(ListLogLtsConfigsRequest listLogLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", listLogLtsConfigsRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{engine}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogLtsConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLogLtsConfigsResponse>(response);
        }

        public SyncInvoker<ListLogLtsConfigsResponse> ListLogLtsConfigsInvoker(ListLogLtsConfigsRequest listLogLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", listLogLtsConfigsRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{engine}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogLtsConfigsRequest);
            return new SyncInvoker<ListLogLtsConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLogLtsConfigsResponse>);
        }
        
        /// <summary>
        /// 查询跨区域备份列表
        ///
        /// 查询跨区域备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOffSiteBackupsResponse ListOffSiteBackups(ListOffSiteBackupsRequest listOffSiteBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/offsite-backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOffSiteBackupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOffSiteBackupsResponse>(response);
        }

        public SyncInvoker<ListOffSiteBackupsResponse> ListOffSiteBackupsInvoker(ListOffSiteBackupsRequest listOffSiteBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/offsite-backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOffSiteBackupsRequest);
            return new SyncInvoker<ListOffSiteBackupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOffSiteBackupsResponse>);
        }
        
        /// <summary>
        /// 查询跨区域备份实例列表
        ///
        /// 查询跨区域备份实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOffSiteInstancesResponse ListOffSiteInstances(ListOffSiteInstancesRequest listOffSiteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/backups/offsite-backup-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOffSiteInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOffSiteInstancesResponse>(response);
        }

        public SyncInvoker<ListOffSiteInstancesResponse> ListOffSiteInstancesInvoker(ListOffSiteInstancesRequest listOffSiteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/backups/offsite-backup-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOffSiteInstancesRequest);
            return new SyncInvoker<ListOffSiteInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOffSiteInstancesResponse>);
        }
        
        /// <summary>
        /// 查询跨区域备份可恢复时间段
        ///
        /// 查询跨区域备份可恢复时间段。
        /// 如果您备份策略中的保存天数设置较长，建议您传入查询日期“date”。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOffSiteRestoreTimesResponse ListOffSiteRestoreTimes(ListOffSiteRestoreTimesRequest listOffSiteRestoreTimesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listOffSiteRestoreTimesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/offsite-restore-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOffSiteRestoreTimesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOffSiteRestoreTimesResponse>(response);
        }

        public SyncInvoker<ListOffSiteRestoreTimesResponse> ListOffSiteRestoreTimesInvoker(ListOffSiteRestoreTimesRequest listOffSiteRestoreTimesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listOffSiteRestoreTimesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/offsite-restore-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOffSiteRestoreTimesRequest);
            return new SyncInvoker<ListOffSiteRestoreTimesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOffSiteRestoreTimesResponse>);
        }
        
        /// <summary>
        /// 查询实例的pg_hba.conf文件配置
        ///
        /// 查询实例的pg_hba.conf文件配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPostgresqlHbaInfoResponse ListPostgresqlHbaInfo(ListPostgresqlHbaInfoRequest listPostgresqlHbaInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPostgresqlHbaInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlHbaInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            var listPostgresqlHbaInfoResponse = JsonUtils.DeSerializeNull<ListPostgresqlHbaInfoResponse>(response);
            listPostgresqlHbaInfoResponse.Body = JsonUtils.DeSerializeList<PostgresqlHbaConf>(response);
            return listPostgresqlHbaInfoResponse;
        }

        public SyncInvoker<ListPostgresqlHbaInfoResponse> ListPostgresqlHbaInfoInvoker(ListPostgresqlHbaInfoRequest listPostgresqlHbaInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPostgresqlHbaInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlHbaInfoRequest);
            return new SyncInvoker<ListPostgresqlHbaInfoResponse>(this, "GET", request, response =>
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
        public ListPostgresqlHbaInfoHistoryResponse ListPostgresqlHbaInfoHistory(ListPostgresqlHbaInfoHistoryRequest listPostgresqlHbaInfoHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPostgresqlHbaInfoHistoryRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlHbaInfoHistoryRequest);
            var response = DoHttpRequestSync("GET", request);
            var listPostgresqlHbaInfoHistoryResponse = JsonUtils.DeSerializeNull<ListPostgresqlHbaInfoHistoryResponse>(response);
            listPostgresqlHbaInfoHistoryResponse.Body = JsonUtils.DeSerializeList<PostgresqlHbaHistory>(response);
            return listPostgresqlHbaInfoHistoryResponse;
        }

        public SyncInvoker<ListPostgresqlHbaInfoHistoryResponse> ListPostgresqlHbaInfoHistoryInvoker(ListPostgresqlHbaInfoHistoryRequest listPostgresqlHbaInfoHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPostgresqlHbaInfoHistoryRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlHbaInfoHistoryRequest);
            return new SyncInvoker<ListPostgresqlHbaInfoHistoryResponse>(this, "GET", request, response =>
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
        public ListPostgresqlListHistoryTablesResponse ListPostgresqlListHistoryTables(ListPostgresqlListHistoryTablesRequest listPostgresqlListHistoryTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name", listPostgresqlListHistoryTablesRequest.DatabaseName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{database_name}/instances/history/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlListHistoryTablesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListPostgresqlListHistoryTablesResponse>(response);
        }

        public SyncInvoker<ListPostgresqlListHistoryTablesResponse> ListPostgresqlListHistoryTablesInvoker(ListPostgresqlListHistoryTablesRequest listPostgresqlListHistoryTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name", listPostgresqlListHistoryTablesRequest.DatabaseName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{database_name}/instances/history/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlListHistoryTablesRequest);
            return new SyncInvoker<ListPostgresqlListHistoryTablesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListPostgresqlListHistoryTablesResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 查询预定义标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPredefinedTagResponse ListPredefinedTag(ListPredefinedTagRequest listPredefinedTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tags/predefined-tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPredefinedTagRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPredefinedTagResponse>(response);
        }

        public SyncInvoker<ListPredefinedTagResponse> ListPredefinedTagInvoker(ListPredefinedTagRequest listPredefinedTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tags/predefined-tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPredefinedTagRequest);
            return new SyncInvoker<ListPredefinedTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPredefinedTagResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询项目标签。
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
        /// 查询数据库代理信息列表
        ///
        /// 查询数据库代理信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRdSforMySqlProxyResponse ListRdSforMySqlProxy(ListRdSforMySqlProxyRequest listRdSforMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRdSforMySqlProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRdSforMySqlProxyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRdSforMySqlProxyResponse>(response);
        }

        public SyncInvoker<ListRdSforMySqlProxyResponse> ListRdSforMySqlProxyInvoker(ListRdSforMySqlProxyRequest listRdSforMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRdSforMySqlProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRdSforMySqlProxyRequest);
            return new SyncInvoker<ListRdSforMySqlProxyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRdSforMySqlProxyResponse>);
        }
        
        /// <summary>
        /// 查询数据库代理规格信息
        ///
        /// 查询数据库代理规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRdSforMysqlProxyFlavorsResponse ListRdSforMysqlProxyFlavors(ListRdSforMysqlProxyFlavorsRequest listRdSforMysqlProxyFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRdSforMysqlProxyFlavorsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRdSforMysqlProxyFlavorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRdSforMysqlProxyFlavorsResponse>(response);
        }

        public SyncInvoker<ListRdSforMysqlProxyFlavorsResponse> ListRdSforMysqlProxyFlavorsInvoker(ListRdSforMysqlProxyFlavorsRequest listRdSforMysqlProxyFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRdSforMysqlProxyFlavorsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRdSforMysqlProxyFlavorsRequest);
            return new SyncInvoker<ListRdSforMysqlProxyFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRdSforMysqlProxyFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询只读实例可恢复到主实例的库
        ///
        /// 查询只读实例可恢复到主实例的库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListReadOnlyReplayDatabaseResponse ListReadOnlyReplayDatabase(ListReadOnlyReplayDatabaseRequest listReadOnlyReplayDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listReadOnlyReplayDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/log-replay/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReadOnlyReplayDatabaseRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListReadOnlyReplayDatabaseResponse>(response);
        }

        public SyncInvoker<ListReadOnlyReplayDatabaseResponse> ListReadOnlyReplayDatabaseInvoker(ListReadOnlyReplayDatabaseRequest listReadOnlyReplayDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listReadOnlyReplayDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/log-replay/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReadOnlyReplayDatabaseRequest);
            return new SyncInvoker<ListReadOnlyReplayDatabaseResponse>(this, "GET", request, JsonUtils.DeSerialize<ListReadOnlyReplayDatabaseResponse>);
        }
        
        /// <summary>
        /// 查询回收站
        ///
        /// 查询回收站实例信息
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
        /// 查询定时任务列表
        ///
        /// 查询定时任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListScheduleTasksResponse ListScheduleTasks(ListScheduleTasksRequest listScheduleTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/schedule-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduleTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScheduleTasksResponse>(response);
        }

        public SyncInvoker<ListScheduleTasksResponse> ListScheduleTasksInvoker(ListScheduleTasksRequest listScheduleTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/schedule-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduleTasksRequest);
            return new SyncInvoker<ListScheduleTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScheduleTasksResponse>);
        }
        
        /// <summary>
        /// 查询共享备份列表
        ///
        /// 查询共享备份列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListShareBackupsResponse ListShareBackups(ListShareBackupsRequest listShareBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/share-backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listShareBackupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListShareBackupsResponse>(response);
        }

        public SyncInvoker<ListShareBackupsResponse> ListShareBackupsInvoker(ListShareBackupsRequest listShareBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/share-backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listShareBackupsRequest);
            return new SyncInvoker<ListShareBackupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListShareBackupsResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 获取指定实例详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSimplifiedInstancesResponse ListSimplifiedInstances(ListSimplifiedInstancesRequest listSimplifiedInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/simplified-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSimplifiedInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListSimplifiedInstancesResponse>(response);
        }

        public SyncInvoker<ListSimplifiedInstancesResponse> ListSimplifiedInstancesInvoker(ListSimplifiedInstancesRequest listSimplifiedInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/simplified-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSimplifiedInstancesRequest);
            return new SyncInvoker<ListSimplifiedInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSimplifiedInstancesResponse>);
        }
        
        /// <summary>
        /// 查询慢日志文件列表
        ///
        /// 查询慢日志文件列表。
        /// 调用该接口取到慢日志文件名后，可以调用接口/v3/{project_id}/instances/{instance_id}/slowlog-download 获取慢日志文件下载链接
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSlowLogFileResponse ListSlowLogFile(ListSlowLogFileRequest listSlowLogFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowLogFileRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogFileRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSlowLogFileResponse>(response);
        }

        public SyncInvoker<ListSlowLogFileResponse> ListSlowLogFileInvoker(ListSlowLogFileRequest listSlowLogFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowLogFileRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogFileRequest);
            return new SyncInvoker<ListSlowLogFileResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSlowLogFileResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 查询实例慢日志的统计数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSlowLogStatisticsForLtsResponse ListSlowLogStatisticsForLts(ListSlowLogStatisticsForLtsRequest listSlowLogStatisticsForLtsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowLogStatisticsForLtsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/slow-logs/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogStatisticsForLtsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListSlowLogStatisticsForLtsResponse>(response);
        }

        public SyncInvoker<ListSlowLogStatisticsForLtsResponse> ListSlowLogStatisticsForLtsInvoker(ListSlowLogStatisticsForLtsRequest listSlowLogStatisticsForLtsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowLogStatisticsForLtsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/slow-logs/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogStatisticsForLtsRequest);
            return new SyncInvoker<ListSlowLogStatisticsForLtsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSlowLogStatisticsForLtsResponse>);
        }
        
        /// <summary>
        /// 查询数据库慢日志
        ///
        /// 查询数据库慢日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSlowLogsResponse ListSlowLogs(ListSlowLogsRequest listSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSlowLogsResponse>(response);
        }

        public SyncInvoker<ListSlowLogsResponse> ListSlowLogsInvoker(ListSlowLogsRequest listSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsRequest);
            return new SyncInvoker<ListSlowLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSlowLogsResponse>);
        }
        
        /// <summary>
        /// 查询数据库慢日志
        ///
        /// 查询数据库慢日志。(与原v3接口相比修改offset,符合华为云服务开放 API遵从性规范3.0)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSlowLogsNewResponse ListSlowLogsNew(ListSlowLogsNewRequest listSlowLogsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowLogsNewRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSlowLogsNewResponse>(response);
        }

        public SyncInvoker<ListSlowLogsNewResponse> ListSlowLogsNewInvoker(ListSlowLogsNewRequest listSlowLogsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowLogsNewRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsNewRequest);
            return new SyncInvoker<ListSlowLogsNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSlowLogsNewResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 查询实例的慢日志数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSlowlogForLtsResponse ListSlowlogForLts(ListSlowlogForLtsRequest listSlowlogForLtsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowlogForLtsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowlogForLtsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListSlowlogForLtsResponse>(response);
        }

        public SyncInvoker<ListSlowlogForLtsResponse> ListSlowlogForLtsInvoker(ListSlowlogForLtsRequest listSlowlogForLtsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowlogForLtsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowlogForLtsRequest);
            return new SyncInvoker<ListSlowlogForLtsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSlowlogForLtsResponse>);
        }
        
        /// <summary>
        /// 获取慢日志统计信息
        ///
        /// 获取慢日志统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSlowlogStatisticsResponse ListSlowlogStatistics(ListSlowlogStatisticsRequest listSlowlogStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowlogStatisticsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowlogStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSlowlogStatisticsResponse>(response);
        }

        public SyncInvoker<ListSlowlogStatisticsResponse> ListSlowlogStatisticsInvoker(ListSlowlogStatisticsRequest listSlowlogStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowlogStatisticsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowlogStatisticsRequest);
            return new SyncInvoker<ListSlowlogStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSlowlogStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询SQL限流列表
        ///
        /// 查询SQL限流列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSqlLimitResponse ListSqlLimit(ListSqlLimitRequest listSqlLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSqlLimitRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-limit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlLimitRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSqlLimitResponse>(response);
        }

        public SyncInvoker<ListSqlLimitResponse> ListSqlLimitInvoker(ListSqlLimitRequest listSqlLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSqlLimitRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-limit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlLimitRequest);
            return new SyncInvoker<ListSqlLimitResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSqlLimitResponse>);
        }
        
        /// <summary>
        /// 获取SSL证书下载地址
        ///
        /// 获取SSL证书下载地址
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSslCertDownloadLinkResponse ListSslCertDownloadLink(ListSslCertDownloadLinkRequest listSslCertDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSslCertDownloadLinkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-cert/download-link", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSslCertDownloadLinkRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSslCertDownloadLinkResponse>(response);
        }

        public SyncInvoker<ListSslCertDownloadLinkResponse> ListSslCertDownloadLinkInvoker(ListSslCertDownloadLinkRequest listSslCertDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSslCertDownloadLinkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-cert/download-link", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSslCertDownloadLinkRequest);
            return new SyncInvoker<ListSslCertDownloadLinkResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSslCertDownloadLinkResponse>);
        }
        
        /// <summary>
        /// 查询数据库磁盘类型
        ///
        /// 查询数据库磁盘类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStorageTypesResponse ListStorageTypes(ListStorageTypesRequest listStorageTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name", listStorageTypesRequest.DatabaseName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/storage-type/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageTypesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListStorageTypesResponse>(response);
        }

        public SyncInvoker<ListStorageTypesResponse> ListStorageTypesInvoker(ListStorageTypesRequest listStorageTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name", listStorageTypesRequest.DatabaseName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/storage-type/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageTypesRequest);
            return new SyncInvoker<ListStorageTypesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStorageTypesResponse>);
        }
        
        /// <summary>
        /// 查询及时任务列表
        ///
        /// 查询及时任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTasksResponse ListTasks(ListTasksRequest listTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasklist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTasksResponse>(response);
        }

        public SyncInvoker<ListTasksResponse> ListTasksInvoker(ListTasksRequest listTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasklist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTasksRequest);
            return new SyncInvoker<ListTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTasksResponse>);
        }
        
        /// <summary>
        /// 查询高级备份策略
        ///
        /// 查询高级备份策略，可查看自定义稀疏备份等
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUpdateBackupEnhancePolicyResponse ListUpdateBackupEnhancePolicy(ListUpdateBackupEnhancePolicyRequest listUpdateBackupEnhancePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listUpdateBackupEnhancePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/enhance-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpdateBackupEnhancePolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUpdateBackupEnhancePolicyResponse>(response);
        }

        public SyncInvoker<ListUpdateBackupEnhancePolicyResponse> ListUpdateBackupEnhancePolicyInvoker(ListUpdateBackupEnhancePolicyRequest listUpdateBackupEnhancePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listUpdateBackupEnhancePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/enhance-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpdateBackupEnhancePolicyRequest);
            return new SyncInvoker<ListUpdateBackupEnhancePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUpdateBackupEnhancePolicyResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 查询实例大版本升级历史信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUpgradeHistoriesResponse ListUpgradeHistories(ListUpgradeHistoriesRequest listUpgradeHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listUpgradeHistoriesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/upgrade-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpgradeHistoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUpgradeHistoriesResponse>(response);
        }

        public SyncInvoker<ListUpgradeHistoriesResponse> ListUpgradeHistoriesInvoker(ListUpgradeHistoriesRequest listUpgradeHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listUpgradeHistoriesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/upgrade-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpgradeHistoriesRequest);
            return new SyncInvoker<ListUpgradeHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUpgradeHistoriesResponse>);
        }
        
        /// <summary>
        /// 查询实例的磁盘信息
        ///
        /// 查询实例的磁盘信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVolumeInfoResponse ListVolumeInfo(ListVolumeInfoRequest listVolumeInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listVolumeInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/volumes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumeInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerializeNull<ListVolumeInfoResponse>(response);
        }

        public SyncInvoker<ListVolumeInfoResponse> ListVolumeInfoInvoker(ListVolumeInfoRequest listVolumeInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listVolumeInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/volumes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumeInfoRequest);
            return new SyncInvoker<ListVolumeInfoResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ListVolumeInfoResponse>);
        }
        
        /// <summary>
        /// 查询扩展日志文件列表
        ///
        /// 查询扩展日志文件列表。
        /// 查询扩展日志文件列表，可以调用接口/v3/{project_id}/instances/{instance_id}/xellog-download 获取扩展日志下载链接
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListXellogFilesResponse ListXellogFiles(ListXellogFilesRequest listXellogFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listXellogFilesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/xellog-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listXellogFilesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListXellogFilesResponse>(response);
        }

        public SyncInvoker<ListXellogFilesResponse> ListXellogFilesInvoker(ListXellogFilesRequest listXellogFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listXellogFilesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/xellog-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listXellogFilesRequest);
            return new SyncInvoker<ListXellogFilesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListXellogFilesResponse>);
        }
        
        /// <summary>
        /// 迁移主备实例的备机
        ///
        /// 迁移主备实例的备机
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public MigrateFollowerResponse MigrateFollower(MigrateFollowerRequest migrateFollowerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", migrateFollowerRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/migrateslave", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateFollowerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<MigrateFollowerResponse>(response);
        }

        public SyncInvoker<MigrateFollowerResponse> MigrateFollowerInvoker(MigrateFollowerRequest migrateFollowerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", migrateFollowerRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/migrateslave", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateFollowerRequest);
            return new SyncInvoker<MigrateFollowerResponse>(this, "POST", request, JsonUtils.DeSerialize<MigrateFollowerResponse>);
        }
        
        /// <summary>
        /// 修改pg_hba.conf文件的单个或多个配置
        ///
        /// 修改/新增pg_hba.conf文件的单个或多个配置，以priority做唯一标识，priority不存在的新增，存在的修改
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyPostgresqlHbaConfResponse ModifyPostgresqlHbaConf(ModifyPostgresqlHbaConfRequest modifyPostgresqlHbaConfRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyPostgresqlHbaConfRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyPostgresqlHbaConfRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyPostgresqlHbaConfResponse>(response);
        }

        public SyncInvoker<ModifyPostgresqlHbaConfResponse> ModifyPostgresqlHbaConfInvoker(ModifyPostgresqlHbaConfRequest modifyPostgresqlHbaConfRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyPostgresqlHbaConfRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/hba-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyPostgresqlHbaConfRequest);
            return new SyncInvoker<ModifyPostgresqlHbaConfResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyPostgresqlHbaConfResponse>);
        }
        
        /// <summary>
        /// 设置读写分离路由模式
        ///
        /// 设置读写分离路由模式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyRdSforMySqlProxyRouteModeResponse ModifyRdSforMySqlProxyRouteMode(ModifyRdSforMySqlProxyRouteModeRequest modifyRdSforMySqlProxyRouteModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyRdSforMySqlProxyRouteModeRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", modifyRdSforMySqlProxyRouteModeRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/route-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyRdSforMySqlProxyRouteModeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ModifyRdSforMySqlProxyRouteModeResponse>(response);
        }

        public SyncInvoker<ModifyRdSforMySqlProxyRouteModeResponse> ModifyRdSforMySqlProxyRouteModeInvoker(ModifyRdSforMySqlProxyRouteModeRequest modifyRdSforMySqlProxyRouteModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyRdSforMySqlProxyRouteModeRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", modifyRdSforMySqlProxyRouteModeRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/route-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyRdSforMySqlProxyRouteModeRequest);
            return new SyncInvoker<ModifyRdSforMySqlProxyRouteModeResponse>(this, "POST", request, JsonUtils.DeSerialize<ModifyRdSforMySqlProxyRouteModeResponse>);
        }
        
        /// <summary>
        /// 恢复到已有实例
        ///
        /// 恢复到已有实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreExistInstanceResponse RestoreExistInstance(RestoreExistInstanceRequest restoreExistInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreExistInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestoreExistInstanceResponse>(response);
        }

        public SyncInvoker<RestoreExistInstanceResponse> RestoreExistInstanceInvoker(RestoreExistInstanceRequest restoreExistInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreExistInstanceRequest);
            return new SyncInvoker<RestoreExistInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreExistInstanceResponse>);
        }
        
        /// <summary>
        /// 延迟库只读，恢复库到主实例
        ///
        /// 延迟库只读，恢复库到主实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreLogReplayDatabaseResponse RestoreLogReplayDatabase(RestoreLogReplayDatabaseRequest restoreLogReplayDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restoreLogReplayDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/log-replay/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreLogReplayDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestoreLogReplayDatabaseResponse>(response);
        }

        public SyncInvoker<RestoreLogReplayDatabaseResponse> RestoreLogReplayDatabaseInvoker(RestoreLogReplayDatabaseRequest restoreLogReplayDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restoreLogReplayDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/log-replay/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreLogReplayDatabaseRequest);
            return new SyncInvoker<RestoreLogReplayDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreLogReplayDatabaseResponse>);
        }
        
        /// <summary>
        /// 表级时间点恢复(MySQL)
        ///
        /// 表级时间点恢复(MySQL)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreTablesResponse RestoreTables(RestoreTablesRequest restoreTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restoreTablesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreTablesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestoreTablesResponse>(response);
        }

        public SyncInvoker<RestoreTablesResponse> RestoreTablesInvoker(RestoreTablesRequest restoreTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restoreTablesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreTablesRequest);
            return new SyncInvoker<RestoreTablesResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreTablesResponse>);
        }
        
        /// <summary>
        /// 表级时间点恢复(MySQL)
        ///
        /// 表级时间点恢复(MySQL)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreTablesNewResponse RestoreTablesNew(RestoreTablesNewRequest restoreTablesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restoreTablesNewRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/restore/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreTablesNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestoreTablesNewResponse>(response);
        }

        public SyncInvoker<RestoreTablesNewResponse> RestoreTablesNewInvoker(RestoreTablesNewRequest restoreTablesNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restoreTablesNewRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/restore/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreTablesNewRequest);
            return new SyncInvoker<RestoreTablesNewResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreTablesNewResponse>);
        }
        
        /// <summary>
        /// 恢复到已有实例
        ///
        /// 恢复到已有实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreToExistingInstanceResponse RestoreToExistingInstance(RestoreToExistingInstanceRequest restoreToExistingInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreToExistingInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestoreToExistingInstanceResponse>(response);
        }

        public SyncInvoker<RestoreToExistingInstanceResponse> RestoreToExistingInstanceInvoker(RestoreToExistingInstanceRequest restoreToExistingInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreToExistingInstanceRequest);
            return new SyncInvoker<RestoreToExistingInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreToExistingInstanceResponse>);
        }
        
        /// <summary>
        /// 设置审计日志策略
        ///
        /// 设置审计日志策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetAuditlogPolicyResponse SetAuditlogPolicy(SetAuditlogPolicyRequest setAuditlogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setAuditlogPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditlogPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SetAuditlogPolicyResponse>(response);
        }

        public SyncInvoker<SetAuditlogPolicyResponse> SetAuditlogPolicyInvoker(SetAuditlogPolicyRequest setAuditlogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setAuditlogPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAuditlogPolicyRequest);
            return new SyncInvoker<SetAuditlogPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetAuditlogPolicyResponse>);
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
        public SetAutoEnlargePolicyResponse SetAutoEnlargePolicy(SetAutoEnlargePolicyRequest setAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setAutoEnlargePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disk-auto-expansion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAutoEnlargePolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetAutoEnlargePolicyResponse>(response);
        }

        public SyncInvoker<SetAutoEnlargePolicyResponse> SetAutoEnlargePolicyInvoker(SetAutoEnlargePolicyRequest setAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setAutoEnlargePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disk-auto-expansion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAutoEnlargePolicyRequest);
            return new SyncInvoker<SetAutoEnlargePolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetAutoEnlargePolicyResponse>);
        }
        
        /// <summary>
        /// 设置实例内核小版本自动升级策略
        ///
        /// 设置实例内核小版本自动升级策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetAutoUpgradePolicyResponse SetAutoUpgradePolicy(SetAutoUpgradePolicyRequest setAutoUpgradePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setAutoUpgradePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-auto-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAutoUpgradePolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SetAutoUpgradePolicyResponse>(response);
        }

        public SyncInvoker<SetAutoUpgradePolicyResponse> SetAutoUpgradePolicyInvoker(SetAutoUpgradePolicyRequest setAutoUpgradePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setAutoUpgradePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-auto-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAutoUpgradePolicyRequest);
            return new SyncInvoker<SetAutoUpgradePolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetAutoUpgradePolicyResponse>);
        }
        
        /// <summary>
        /// 设置自动备份策略
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
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBackupPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetBackupPolicyResponse>(response);
        }

        public SyncInvoker<SetBackupPolicyResponse> SetBackupPolicyInvoker(SetBackupPolicyRequest setBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBackupPolicyRequest);
            return new SyncInvoker<SetBackupPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetBackupPolicyResponse>);
        }
        
        /// <summary>
        /// 设置binlog本地保留时长
        ///
        /// 修改指定实例的binlog本地保留时长。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetBinlogClearPolicyResponse SetBinlogClearPolicy(SetBinlogClearPolicyRequest setBinlogClearPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setBinlogClearPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/binlog/clear-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBinlogClearPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SetBinlogClearPolicyResponse>(response);
        }

        public SyncInvoker<SetBinlogClearPolicyResponse> SetBinlogClearPolicyInvoker(SetBinlogClearPolicyRequest setBinlogClearPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setBinlogClearPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/binlog/clear-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setBinlogClearPolicyRequest);
            return new SyncInvoker<SetBinlogClearPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetBinlogClearPolicyResponse>);
        }
        
        /// <summary>
        /// 重启数据库代理
        ///
        /// 重启数据库代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetInstancesProxyRestartResponse SetInstancesProxyRestart(SetInstancesProxyRestartRequest setInstancesProxyRestartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setInstancesProxyRestartRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", setInstancesProxyRestartRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setInstancesProxyRestartRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetInstancesProxyRestartResponse>(response);
        }

        public SyncInvoker<SetInstancesProxyRestartResponse> SetInstancesProxyRestartInvoker(SetInstancesProxyRestartRequest setInstancesProxyRestartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setInstancesProxyRestartRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", setInstancesProxyRestartRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setInstancesProxyRestartRequest);
            return new SyncInvoker<SetInstancesProxyRestartResponse>(this, "POST", request, JsonUtils.DeSerialize<SetInstancesProxyRestartResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 关联LTS配置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetLogLtsConfigsResponse SetLogLtsConfigs(SetLogLtsConfigsRequest setLogLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", setLogLtsConfigsRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{engine}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setLogLtsConfigsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SetLogLtsConfigsResponse>(response);
        }

        public SyncInvoker<SetLogLtsConfigsResponse> SetLogLtsConfigsInvoker(SetLogLtsConfigsRequest setLogLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", setLogLtsConfigsRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{engine}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setLogLtsConfigsRequest);
            return new SyncInvoker<SetLogLtsConfigsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetLogLtsConfigsResponse>);
        }
        
        /// <summary>
        /// 设置跨区域备份策略
        ///
        /// 设置跨区域备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetOffSiteBackupPolicyResponse SetOffSiteBackupPolicy(SetOffSiteBackupPolicyRequest setOffSiteBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setOffSiteBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/offsite-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setOffSiteBackupPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetOffSiteBackupPolicyResponse>(response);
        }

        public SyncInvoker<SetOffSiteBackupPolicyResponse> SetOffSiteBackupPolicyInvoker(SetOffSiteBackupPolicyRequest setOffSiteBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setOffSiteBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/offsite-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setOffSiteBackupPolicyRequest);
            return new SyncInvoker<SetOffSiteBackupPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetOffSiteBackupPolicyResponse>);
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
        public SetSecondLevelMonitorResponse SetSecondLevelMonitor(SetSecondLevelMonitorRequest setSecondLevelMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setSecondLevelMonitorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/second-level-monitor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSecondLevelMonitorRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetSecondLevelMonitorResponse>(response);
        }

        public SyncInvoker<SetSecondLevelMonitorResponse> SetSecondLevelMonitorInvoker(SetSecondLevelMonitorRequest setSecondLevelMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setSecondLevelMonitorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/second-level-monitor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSecondLevelMonitorRequest);
            return new SyncInvoker<SetSecondLevelMonitorResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetSecondLevelMonitorResponse>);
        }
        
        /// <summary>
        /// 修改安全组
        ///
        /// 修改安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetSecurityGroupResponse SetSecurityGroup(SetSecurityGroupRequest setSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setSecurityGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSecurityGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SetSecurityGroupResponse>(response);
        }

        public SyncInvoker<SetSecurityGroupResponse> SetSecurityGroupInvoker(SetSecurityGroupRequest setSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setSecurityGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSecurityGroupRequest);
            return new SyncInvoker<SetSecurityGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 慢日志敏感信息的开关
        ///
        /// V3慢日志敏感信息的开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetSensitiveSlowLogResponse SetSensitiveSlowLog(SetSensitiveSlowLogRequest setSensitiveSlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setSensitiveSlowLogRequest.InstanceId.ToString());
            urlParam.Add("status", setSensitiveSlowLogRequest.Status.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-sensitization/{status}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSensitiveSlowLogRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetSensitiveSlowLogResponse>(response);
        }

        public SyncInvoker<SetSensitiveSlowLogResponse> SetSensitiveSlowLogInvoker(SetSensitiveSlowLogRequest setSensitiveSlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setSensitiveSlowLogRequest.InstanceId.ToString());
            urlParam.Add("status", setSensitiveSlowLogRequest.Status.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-sensitization/{status}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setSensitiveSlowLogRequest);
            return new SyncInvoker<SetSensitiveSlowLogResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetSensitiveSlowLogResponse>);
        }
        
        /// <summary>
        /// 设置自动转储策略
        ///
        /// 设置自动转储策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetTransferPolicyResponse SetTransferPolicy(SetTransferPolicyRequest setTransferPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setTransferPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/transfer/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setTransferPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetTransferPolicyResponse>(response);
        }

        public SyncInvoker<SetTransferPolicyResponse> SetTransferPolicyInvoker(SetTransferPolicyRequest setTransferPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setTransferPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/transfer/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setTransferPolicyRequest);
            return new SyncInvoker<SetTransferPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetTransferPolicyResponse>);
        }
        
        /// <summary>
        /// 生成审计日志下载链接
        ///
        /// 生成审计日志下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAuditlogDownloadLinkResponse ShowAuditlogDownloadLink(ShowAuditlogDownloadLinkRequest showAuditlogDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAuditlogDownloadLinkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-links", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditlogDownloadLinkRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowAuditlogDownloadLinkResponse>(response);
        }

        public SyncInvoker<ShowAuditlogDownloadLinkResponse> ShowAuditlogDownloadLinkInvoker(ShowAuditlogDownloadLinkRequest showAuditlogDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAuditlogDownloadLinkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-links", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditlogDownloadLinkRequest);
            return new SyncInvoker<ShowAuditlogDownloadLinkResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowAuditlogDownloadLinkResponse>);
        }
        
        /// <summary>
        /// 查询审计日志策略
        ///
        /// 查询审计日志策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAuditlogPolicyResponse ShowAuditlogPolicy(ShowAuditlogPolicyRequest showAuditlogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAuditlogPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditlogPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditlogPolicyResponse>(response);
        }

        public SyncInvoker<ShowAuditlogPolicyResponse> ShowAuditlogPolicyInvoker(ShowAuditlogPolicyRequest showAuditlogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAuditlogPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auditlog-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditlogPolicyRequest);
            return new SyncInvoker<ShowAuditlogPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditlogPolicyResponse>);
        }
        
        /// <summary>
        /// 查询自动扩容策略
        ///
        /// 查询实例存储空间自动扩容策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutoEnlargePolicyResponse ShowAutoEnlargePolicy(ShowAutoEnlargePolicyRequest showAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAutoEnlargePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disk-auto-expansion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoEnlargePolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoEnlargePolicyResponse>(response);
        }

        public SyncInvoker<ShowAutoEnlargePolicyResponse> ShowAutoEnlargePolicyInvoker(ShowAutoEnlargePolicyRequest showAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAutoEnlargePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disk-auto-expansion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoEnlargePolicyRequest);
            return new SyncInvoker<ShowAutoEnlargePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoEnlargePolicyResponse>);
        }
        
        /// <summary>
        /// 查询实例内核小版本自动升级策略
        ///
        /// 查询实例内核小版本自动升级策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutoUpgradePolicyResponse ShowAutoUpgradePolicy(ShowAutoUpgradePolicyRequest showAutoUpgradePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAutoUpgradePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-auto-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoUpgradePolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoUpgradePolicyResponse>(response);
        }

        public SyncInvoker<ShowAutoUpgradePolicyResponse> ShowAutoUpgradePolicyInvoker(ShowAutoUpgradePolicyRequest showAutoUpgradePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAutoUpgradePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-auto-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoUpgradePolicyRequest);
            return new SyncInvoker<ShowAutoUpgradePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoUpgradePolicyResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 查询实例可升级的目标版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAvailableVersionResponse ShowAvailableVersion(ShowAvailableVersionRequest showAvailableVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAvailableVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/available-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvailableVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAvailableVersionResponse>(response);
        }

        public SyncInvoker<ShowAvailableVersionResponse> ShowAvailableVersionInvoker(ShowAvailableVersionRequest showAvailableVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAvailableVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/available-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvailableVersionRequest);
            return new SyncInvoker<ShowAvailableVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAvailableVersionResponse>);
        }
        
        /// <summary>
        /// 获取备份下载链接
        ///
        /// 获取备份下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBackupDownloadLinkResponse ShowBackupDownloadLink(ShowBackupDownloadLinkRequest showBackupDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backup-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupDownloadLinkRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBackupDownloadLinkResponse>(response);
        }

        public SyncInvoker<ShowBackupDownloadLinkResponse> ShowBackupDownloadLinkInvoker(ShowBackupDownloadLinkRequest showBackupDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backup-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupDownloadLinkRequest);
            return new SyncInvoker<ShowBackupDownloadLinkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackupDownloadLinkResponse>);
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
        /// 获取binlog本地保留时长
        ///
        /// 查寻指定实例的binlog本地保留时长。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBinlogClearPolicyResponse ShowBinlogClearPolicy(ShowBinlogClearPolicyRequest showBinlogClearPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBinlogClearPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/binlog/clear-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBinlogClearPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBinlogClearPolicyResponse>(response);
        }

        public SyncInvoker<ShowBinlogClearPolicyResponse> ShowBinlogClearPolicyInvoker(ShowBinlogClearPolicyRequest showBinlogClearPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBinlogClearPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/binlog/clear-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBinlogClearPolicyRequest);
            return new SyncInvoker<ShowBinlogClearPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBinlogClearPolicyResponse>);
        }
        
        /// <summary>
        /// 获取指定参数模板的参数
        ///
        /// 获取指定参数模板的参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConfigurationResponse ShowConfiguration(ShowConfigurationRequest showConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigurationResponse>(response);
        }

        public SyncInvoker<ShowConfigurationResponse> ShowConfigurationInvoker(ShowConfigurationRequest showConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationRequest);
            return new SyncInvoker<ShowConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigurationResponse>);
        }
        
        /// <summary>
        /// 查询库级备份包含的库
        ///
        /// 查询库级备份包含的库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDatabaseLevelDatabaseResponse ShowDatabaseLevelDatabase(ShowDatabaseLevelDatabaseRequest showDatabaseLevelDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showDatabaseLevelDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/db-table-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDatabaseLevelDatabaseRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDatabaseLevelDatabaseResponse>(response);
        }

        public SyncInvoker<ShowDatabaseLevelDatabaseResponse> ShowDatabaseLevelDatabaseInvoker(ShowDatabaseLevelDatabaseRequest showDatabaseLevelDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showDatabaseLevelDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/db-table-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDatabaseLevelDatabaseRequest);
            return new SyncInvoker<ShowDatabaseLevelDatabaseResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDatabaseLevelDatabaseResponse>);
        }
        
        /// <summary>
        /// 查询实例ipv6域名。
        ///
        /// 查询实例ipv6域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDnsNameResponse ShowDnsName(ShowDnsNameRequest showDnsNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showDnsNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dns-ipv6", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDnsNameRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDnsNameResponse>(response);
        }

        public SyncInvoker<ShowDnsNameResponse> ShowDnsNameInvoker(ShowDnsNameRequest showDnsNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showDnsNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dns-ipv6", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDnsNameRequest);
            return new SyncInvoker<ShowDnsNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDnsNameResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 查询实例ipv4域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainNameResponse ShowDomainName(ShowDomainNameRequest showDomainNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showDomainNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainNameRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainNameResponse>(response);
        }

        public SyncInvoker<ShowDomainNameResponse> ShowDomainNameInvoker(ShowDomainNameRequest showDomainNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showDomainNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainNameRequest);
            return new SyncInvoker<ShowDomainNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainNameResponse>);
        }
        
        /// <summary>
        /// 查询跨云容灾复制状态
        ///
        /// 建立跨云容灾关系后，查询主实例和灾备实例间的复制状态及延迟。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDrReplicaStatusResponse ShowDrReplicaStatus(ShowDrReplicaStatusRequest showDrReplicaStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showDrReplicaStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDrReplicaStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDrReplicaStatusResponse>(response);
        }

        public SyncInvoker<ShowDrReplicaStatusResponse> ShowDrReplicaStatusInvoker(ShowDrReplicaStatusRequest showDrReplicaStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showDrReplicaStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDrReplicaStatusRequest);
            return new SyncInvoker<ShowDrReplicaStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDrReplicaStatusResponse>);
        }
        
        /// <summary>
        /// 获取增备策略
        ///
        /// 获取增备策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowIncreBackupPolicy1Response ShowIncreBackupPolicy1(ShowIncreBackupPolicy1Request showIncreBackupPolicy1Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showIncreBackupPolicy1Request.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/incre-backup/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIncreBackupPolicy1Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowIncreBackupPolicy1Response>(response);
        }

        public SyncInvoker<ShowIncreBackupPolicy1Response> ShowIncreBackupPolicy1Invoker(ShowIncreBackupPolicy1Request showIncreBackupPolicy1Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showIncreBackupPolicy1Request.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/incre-backup/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIncreBackupPolicy1Request);
            return new SyncInvoker<ShowIncreBackupPolicy1Response>(this, "GET", request, JsonUtils.DeSerialize<ShowIncreBackupPolicy1Response>);
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
        /// 查询跨区域备份策略
        ///
        /// 查询跨区域备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOffSiteBackupPolicyResponse ShowOffSiteBackupPolicy(ShowOffSiteBackupPolicyRequest showOffSiteBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showOffSiteBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/offsite-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOffSiteBackupPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOffSiteBackupPolicyResponse>(response);
        }

        public SyncInvoker<ShowOffSiteBackupPolicyResponse> ShowOffSiteBackupPolicyInvoker(ShowOffSiteBackupPolicyRequest showOffSiteBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showOffSiteBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/offsite-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOffSiteBackupPolicyRequest);
            return new SyncInvoker<ShowOffSiteBackupPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOffSiteBackupPolicyResponse>);
        }
        
        /// <summary>
        /// 获取mysql5.7升级mysql8.0预检查结果
        ///
        /// 获取mysql5.7升级mysql8.0预检查结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPrecheckResultResponse ShowPrecheckResult(ShowPrecheckResultRequest showPrecheckResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPrecheckResultRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/upgrade-version/precheck-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrecheckResultRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPrecheckResultResponse>(response);
        }

        public SyncInvoker<ShowPrecheckResultResponse> ShowPrecheckResultInvoker(ShowPrecheckResultRequest showPrecheckResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPrecheckResultRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/upgrade-version/precheck-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrecheckResultRequest);
            return new SyncInvoker<ShowPrecheckResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPrecheckResultResponse>);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// 查询当前项目下资源配额情况。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowQuotasResponse ShowQuotas(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }

        public SyncInvoker<ShowQuotasResponse> ShowQuotasInvoker(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            return new SyncInvoker<ShowQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotasResponse>);
        }
        
        /// <summary>
        /// 查询回收站的回收策略。
        ///
        /// 查询回收站的回收策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecyclePolicyResponse ShowRecyclePolicy(ShowRecyclePolicyRequest showRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecyclePolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRecyclePolicyResponse>(response);
        }

        public SyncInvoker<ShowRecyclePolicyResponse> ShowRecyclePolicyInvoker(ShowRecyclePolicyRequest showRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecyclePolicyRequest);
            return new SyncInvoker<ShowRecyclePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecyclePolicyResponse>);
        }
        
        /// <summary>
        /// 获取实例的复制状态。
        ///
        /// 获取实例的复制状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowReplicationStatusResponse ShowReplicationStatus(ShowReplicationStatusRequest showReplicationStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showReplicationStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replication/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplicationStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowReplicationStatusResponse>(response);
        }

        public SyncInvoker<ShowReplicationStatusResponse> ShowReplicationStatusInvoker(ShowReplicationStatusRequest showReplicationStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showReplicationStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replication/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplicationStatusRequest);
            return new SyncInvoker<ShowReplicationStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReplicationStatusResponse>);
        }
        
        /// <summary>
        /// 查询秒级监控策略
        ///
        /// 查询实例秒级监控策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSecondLevelMonitoringResponse ShowSecondLevelMonitoring(ShowSecondLevelMonitoringRequest showSecondLevelMonitoringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSecondLevelMonitoringRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/second-level-monitor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecondLevelMonitoringRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSecondLevelMonitoringResponse>(response);
        }

        public SyncInvoker<ShowSecondLevelMonitoringResponse> ShowSecondLevelMonitoringInvoker(ShowSecondLevelMonitoringRequest showSecondLevelMonitoringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSecondLevelMonitoringRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/second-level-monitor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecondLevelMonitoringRequest);
            return new SyncInvoker<ShowSecondLevelMonitoringResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecondLevelMonitoringResponse>);
        }
        
        /// <summary>
        /// 查询实例磁盘空间使用量
        ///
        /// 查询实例磁盘空间使用量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStorageUsedSpaceResponse ShowStorageUsedSpace(ShowStorageUsedSpaceRequest showStorageUsedSpaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showStorageUsedSpaceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/storage-used-space", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStorageUsedSpaceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStorageUsedSpaceResponse>(response);
        }

        public SyncInvoker<ShowStorageUsedSpaceResponse> ShowStorageUsedSpaceInvoker(ShowStorageUsedSpaceRequest showStorageUsedSpaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showStorageUsedSpaceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/storage-used-space", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStorageUsedSpaceRequest);
            return new SyncInvoker<ShowStorageUsedSpaceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStorageUsedSpaceResponse>);
        }
        
        /// <summary>
        /// 根据实例id查询sqlserver TDE状态
        ///
        /// 根据实例id查询sqlserver TDE状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTdeStatusResponse ShowTdeStatus(ShowTdeStatusRequest showTdeStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showTdeStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tde-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTdeStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTdeStatusResponse>(response);
        }

        public SyncInvoker<ShowTdeStatusResponse> ShowTdeStatusInvoker(ShowTdeStatusRequest showTdeStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showTdeStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tde-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTdeStatusRequest);
            return new SyncInvoker<ShowTdeStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTdeStatusResponse>);
        }
        
        /// <summary>
        /// 查询自动转储策略
        ///
        /// 查询自动转储策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTransferPolicyResponse ShowTransferPolicy(ShowTransferPolicyRequest showTransferPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showTransferPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/transfer/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransferPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTransferPolicyResponse>(response);
        }

        public SyncInvoker<ShowTransferPolicyResponse> ShowTransferPolicyInvoker(ShowTransferPolicyRequest showTransferPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showTransferPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/transfer/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransferPolicyRequest);
            return new SyncInvoker<ShowTransferPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTransferPolicyResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 查询大版本检查状态或升级状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUpgradeDbMajorVersionStatusResponse ShowUpgradeDbMajorVersionStatus(ShowUpgradeDbMajorVersionStatusRequest showUpgradeDbMajorVersionStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showUpgradeDbMajorVersionStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeDbMajorVersionStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUpgradeDbMajorVersionStatusResponse>(response);
        }

        public SyncInvoker<ShowUpgradeDbMajorVersionStatusResponse> ShowUpgradeDbMajorVersionStatusInvoker(ShowUpgradeDbMajorVersionStatusRequest showUpgradeDbMajorVersionStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showUpgradeDbMajorVersionStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeDbMajorVersionStatusRequest);
            return new SyncInvoker<ShowUpgradeDbMajorVersionStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUpgradeDbMajorVersionStatusResponse>);
        }
        
        /// <summary>
        /// 手动倒换主备
        ///
        /// 手动倒换主备.
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartFailoverResponse StartFailover(StartFailoverRequest startFailoverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startFailoverRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/failover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startFailoverRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<StartFailoverResponse>(response);
        }

        public SyncInvoker<StartFailoverResponse> StartFailoverInvoker(StartFailoverRequest startFailoverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startFailoverRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/failover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startFailoverRequest);
            return new SyncInvoker<StartFailoverResponse>(this, "PUT", request, JsonUtils.DeSerialize<StartFailoverResponse>);
        }
        
        /// <summary>
        /// 扩容数据库实例的磁盘空间
        ///
        /// 扩容数据库实例的磁盘空间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartInstanceEnlargeVolumeActionResponse StartInstanceEnlargeVolumeAction(StartInstanceEnlargeVolumeActionRequest startInstanceEnlargeVolumeActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startInstanceEnlargeVolumeActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInstanceEnlargeVolumeActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartInstanceEnlargeVolumeActionResponse>(response);
        }

        public SyncInvoker<StartInstanceEnlargeVolumeActionResponse> StartInstanceEnlargeVolumeActionInvoker(StartInstanceEnlargeVolumeActionRequest startInstanceEnlargeVolumeActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startInstanceEnlargeVolumeActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInstanceEnlargeVolumeActionRequest);
            return new SyncInvoker<StartInstanceEnlargeVolumeActionResponse>(this, "POST", request, JsonUtils.DeSerialize<StartInstanceEnlargeVolumeActionResponse>);
        }
        
        /// <summary>
        /// 数据库实例的磁盘空间缩容
        ///
        /// 数据库实例的磁盘空间缩容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartInstanceReduceVolumeActionResponse StartInstanceReduceVolumeAction(StartInstanceReduceVolumeActionRequest startInstanceReduceVolumeActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startInstanceReduceVolumeActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInstanceReduceVolumeActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartInstanceReduceVolumeActionResponse>(response);
        }

        public SyncInvoker<StartInstanceReduceVolumeActionResponse> StartInstanceReduceVolumeActionInvoker(StartInstanceReduceVolumeActionRequest startInstanceReduceVolumeActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startInstanceReduceVolumeActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInstanceReduceVolumeActionRequest);
            return new SyncInvoker<StartInstanceReduceVolumeActionResponse>(this, "POST", request, JsonUtils.DeSerialize<StartInstanceReduceVolumeActionResponse>);
        }
        
        /// <summary>
        /// 重启数据库实例
        ///
        /// 重启数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartInstanceRestartActionResponse StartInstanceRestartAction(StartInstanceRestartActionRequest startInstanceRestartActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startInstanceRestartActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInstanceRestartActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartInstanceRestartActionResponse>(response);
        }

        public SyncInvoker<StartInstanceRestartActionResponse> StartInstanceRestartActionInvoker(StartInstanceRestartActionRequest startInstanceRestartActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startInstanceRestartActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInstanceRestartActionRequest);
            return new SyncInvoker<StartInstanceRestartActionResponse>(this, "POST", request, JsonUtils.DeSerialize<StartInstanceRestartActionResponse>);
        }
        
        /// <summary>
        /// 单机转主备实例
        ///
        /// 单机转主备实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartInstanceSingleToHaActionResponse StartInstanceSingleToHaAction(StartInstanceSingleToHaActionRequest startInstanceSingleToHaActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startInstanceSingleToHaActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInstanceSingleToHaActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartInstanceSingleToHaActionResponse>(response);
        }

        public SyncInvoker<StartInstanceSingleToHaActionResponse> StartInstanceSingleToHaActionInvoker(StartInstanceSingleToHaActionRequest startInstanceSingleToHaActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startInstanceSingleToHaActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startInstanceSingleToHaActionRequest);
            return new SyncInvoker<StartInstanceSingleToHaActionResponse>(this, "POST", request, JsonUtils.DeSerialize<StartInstanceSingleToHaActionResponse>);
        }
        
        /// <summary>
        /// 设置回收站策略
        ///
        /// 设置回收站策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartRecyclePolicyResponse StartRecyclePolicy(StartRecyclePolicyRequest startRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startRecyclePolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<StartRecyclePolicyResponse>(response);
        }

        public SyncInvoker<StartRecyclePolicyResponse> StartRecyclePolicyInvoker(StartRecyclePolicyRequest startRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startRecyclePolicyRequest);
            return new SyncInvoker<StartRecyclePolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<StartRecyclePolicyResponse>);
        }
        
        /// <summary>
        /// 变更数据库实例的规格
        ///
        /// 变更数据库实例的规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartResizeFlavorActionResponse StartResizeFlavorAction(StartResizeFlavorActionRequest startResizeFlavorActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startResizeFlavorActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startResizeFlavorActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartResizeFlavorActionResponse>(response);
        }

        public SyncInvoker<StartResizeFlavorActionResponse> StartResizeFlavorActionInvoker(StartResizeFlavorActionRequest startResizeFlavorActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startResizeFlavorActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startResizeFlavorActionRequest);
            return new SyncInvoker<StartResizeFlavorActionResponse>(this, "POST", request, JsonUtils.DeSerialize<StartResizeFlavorActionResponse>);
        }
        
        /// <summary>
        /// 开启实例
        ///
        /// 停止实例以节省费用，在停止数据库实例后，支持手动重新开启实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartupInstanceResponse StartupInstance(StartupInstanceRequest startupInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startupInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action/startup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startupInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartupInstanceResponse>(response);
        }

        public SyncInvoker<StartupInstanceResponse> StartupInstanceInvoker(StartupInstanceRequest startupInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startupInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action/startup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startupInstanceRequest);
            return new SyncInvoker<StartupInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StartupInstanceResponse>);
        }
        
        /// <summary>
        /// 停止备份
        ///
        /// 停止创建备份
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
        /// 停止实例
        ///
        /// 实例进行关机，通过暂时停止按需实例以节省费用，实例默认停止七天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopInstanceResponse StopInstance(StopInstanceRequest stopInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", stopInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action/shutdown", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopInstanceResponse>(response);
        }

        public SyncInvoker<StopInstanceResponse> StopInstanceInvoker(StopInstanceRequest stopInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", stopInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action/shutdown", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopInstanceRequest);
            return new SyncInvoker<StopInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<StopInstanceResponse>);
        }
        
        /// <summary>
        /// 开启/关闭/禁用所有SQL限流
        ///
        /// 开启/关闭/禁用所有SQL限流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchSqlLimitResponse SwitchSqlLimit(SwitchSqlLimitRequest switchSqlLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSqlLimitRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-limit/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSqlLimitRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SwitchSqlLimitResponse>(response);
        }

        public SyncInvoker<SwitchSqlLimitResponse> SwitchSqlLimitInvoker(SwitchSqlLimitRequest switchSqlLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSqlLimitRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-limit/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSqlLimitRequest);
            return new SyncInvoker<SwitchSqlLimitResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchSqlLimitResponse>);
        }
        
        /// <summary>
        /// 设置SSL数据加密
        ///
        /// 设置SSL数据加密。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchSslResponse SwitchSsl(SwitchSslRequest switchSslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSslRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSslRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SwitchSslResponse>(response);
        }

        public SyncInvoker<SwitchSslResponse> SwitchSslInvoker(SwitchSslRequest switchSslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSslRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSslRequest);
            return new SyncInvoker<SwitchSslResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchSslResponse>);
        }
        
        /// <summary>
        /// 手动转储备份
        ///
        /// 手动转储备份
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public TransferBackupResponse TransferBackup(TransferBackupRequest transferBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", transferBackupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/transfer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", transferBackupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<TransferBackupResponse>(response);
        }

        public SyncInvoker<TransferBackupResponse> TransferBackupInvoker(TransferBackupRequest transferBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", transferBackupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/transfer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", transferBackupRequest);
            return new SyncInvoker<TransferBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<TransferBackupResponse>);
        }
        
        /// <summary>
        /// 解除节点只读状态接口
        ///
        /// 解除节点只读状态接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UnlockNodeReadonlyStatusResponse UnlockNodeReadonlyStatus(UnlockNodeReadonlyStatusRequest unlockNodeReadonlyStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", unlockNodeReadonlyStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/unlock-node-readonly-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unlockNodeReadonlyStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UnlockNodeReadonlyStatusResponse>(response);
        }

        public SyncInvoker<UnlockNodeReadonlyStatusResponse> UnlockNodeReadonlyStatusInvoker(UnlockNodeReadonlyStatusRequest unlockNodeReadonlyStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", unlockNodeReadonlyStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/unlock-node-readonly-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unlockNodeReadonlyStatusRequest);
            return new SyncInvoker<UnlockNodeReadonlyStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<UnlockNodeReadonlyStatusResponse>);
        }
        
        /// <summary>
        /// 修改参数模板参数
        ///
        /// 修改参数模板参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateConfigurationResponse UpdateConfiguration(UpdateConfigurationRequest updateConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", updateConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateConfigurationResponse>(response);
        }

        public SyncInvoker<UpdateConfigurationResponse> UpdateConfigurationInvoker(UpdateConfigurationRequest updateConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", updateConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigurationRequest);
            return new SyncInvoker<UpdateConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateConfigurationResponse>);
        }
        
        /// <summary>
        /// 修改内网地址
        ///
        /// 修改内网地址
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDataIpResponse UpdateDataIp(UpdateDataIpRequest updateDataIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateDataIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDataIpRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDataIpResponse>(response);
        }

        public SyncInvoker<UpdateDataIpResponse> UpdateDataIpInvoker(UpdateDataIpRequest updateDataIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateDataIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDataIpRequest);
            return new SyncInvoker<UpdateDataIpResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDataIpResponse>);
        }
        
        /// <summary>
        /// 修改域名
        ///
        /// 修改域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDnsNameResponse UpdateDnsName(UpdateDnsNameRequest updateDnsNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateDnsNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDnsNameRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDnsNameResponse>(response);
        }

        public SyncInvoker<UpdateDnsNameResponse> UpdateDnsNameInvoker(UpdateDnsNameRequest updateDnsNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateDnsNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/modify-dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDnsNameRequest);
            return new SyncInvoker<UpdateDnsNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDnsNameResponse>);
        }
        
        /// <summary>
        /// 修改增备策略
        ///
        /// 修改增备策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateIncreBackupPolicy1Response UpdateIncreBackupPolicy1(UpdateIncreBackupPolicy1Request updateIncreBackupPolicy1Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateIncreBackupPolicy1Request.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/incre-backup/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIncreBackupPolicy1Request);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateIncreBackupPolicy1Response>(response);
        }

        public SyncInvoker<UpdateIncreBackupPolicy1Response> UpdateIncreBackupPolicy1Invoker(UpdateIncreBackupPolicy1Request updateIncreBackupPolicy1Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateIncreBackupPolicy1Request.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/incre-backup/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIncreBackupPolicy1Request);
            return new SyncInvoker<UpdateIncreBackupPolicy1Response>(this, "PUT", request, JsonUtils.DeSerialize<UpdateIncreBackupPolicy1Response>);
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
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceConfigurationResponse>(response);
        }

        public SyncInvoker<UpdateInstanceConfigurationResponse> UpdateInstanceConfigurationInvoker(UpdateInstanceConfigurationRequest updateInstanceConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConfigurationRequest);
            return new SyncInvoker<UpdateInstanceConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceConfigurationResponse>);
        }
        
        /// <summary>
        /// 修改指定实例的参数
        ///
        /// 修改指定实例的参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceConfigurationAsyncResponse UpdateInstanceConfigurationAsync(UpdateInstanceConfigurationAsyncRequest updateInstanceConfigurationAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceConfigurationAsyncRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConfigurationAsyncRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceConfigurationAsyncResponse>(response);
        }

        public SyncInvoker<UpdateInstanceConfigurationAsyncResponse> UpdateInstanceConfigurationAsyncInvoker(UpdateInstanceConfigurationAsyncRequest updateInstanceConfigurationAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceConfigurationAsyncRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConfigurationAsyncRequest);
            return new SyncInvoker<UpdateInstanceConfigurationAsyncResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceConfigurationAsyncResponse>);
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
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceNameRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceNameResponse>(response);
        }

        public SyncInvoker<UpdateInstanceNameResponse> UpdateInstanceNameInvoker(UpdateInstanceNameRequest updateInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceNameRequest);
            return new SyncInvoker<UpdateInstanceNameResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceNameResponse>);
        }
        
        /// <summary>
        /// 修改数据库端口
        ///
        /// 修改数据库端口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePortResponse UpdatePort(UpdatePortRequest updatePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePortRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePortRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePortResponse>(response);
        }

        public SyncInvoker<UpdatePortResponse> UpdatePortInvoker(UpdatePortRequest updatePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePortRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePortRequest);
            return new SyncInvoker<UpdatePortResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePortResponse>);
        }
        
        /// <summary>
        /// 修改实例备注信息
        ///
        /// 修改指定数据库实例的备注信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePostgresqlInstanceAliasResponse UpdatePostgresqlInstanceAlias(UpdatePostgresqlInstanceAliasRequest updatePostgresqlInstanceAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePostgresqlInstanceAliasRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/alias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlInstanceAliasRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePostgresqlInstanceAliasResponse>(response);
        }

        public SyncInvoker<UpdatePostgresqlInstanceAliasResponse> UpdatePostgresqlInstanceAliasInvoker(UpdatePostgresqlInstanceAliasRequest updatePostgresqlInstanceAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePostgresqlInstanceAliasRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/alias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlInstanceAliasRequest);
            return new SyncInvoker<UpdatePostgresqlInstanceAliasResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePostgresqlInstanceAliasResponse>);
        }
        
        /// <summary>
        /// 修改SQL限流
        ///
        /// 修改SQL限流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSqlLimitResponse UpdateSqlLimit(UpdateSqlLimitRequest updateSqlLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateSqlLimitRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-limit/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSqlLimitRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSqlLimitResponse>(response);
        }

        public SyncInvoker<UpdateSqlLimitResponse> UpdateSqlLimitInvoker(UpdateSqlLimitRequest updateSqlLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateSqlLimitRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-limit/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSqlLimitRequest);
            return new SyncInvoker<UpdateSqlLimitResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSqlLimitResponse>);
        }
        
        /// <summary>
        /// sqlserverTDE开关
        ///
        /// sqlserverTDE开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTdeStatusResponse UpdateTdeStatus(UpdateTdeStatusRequest updateTdeStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateTdeStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tde", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTdeStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTdeStatusResponse>(response);
        }

        public SyncInvoker<UpdateTdeStatusResponse> UpdateTdeStatusInvoker(UpdateTdeStatusRequest updateTdeStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateTdeStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tde", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTdeStatusRequest);
            return new SyncInvoker<UpdateTdeStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTdeStatusResponse>);
        }
        
        /// <summary>
        /// RDS实例按需转包周期
        ///
        /// RDS实例按需转包周期
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateToPeriodResponse UpdateToPeriod(UpdateToPeriodRequest updateToPeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateToPeriodRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/to-period", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateToPeriodRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateToPeriodResponse>(response);
        }

        public SyncInvoker<UpdateToPeriodResponse> UpdateToPeriodInvoker(UpdateToPeriodRequest updateToPeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateToPeriodRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/to-period", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateToPeriodRequest);
            return new SyncInvoker<UpdateToPeriodResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateToPeriodResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// PostgreSQL数据库升级大版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeDbMajorVersionResponse UpgradeDbMajorVersion(UpgradeDbMajorVersionRequest upgradeDbMajorVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeDbMajorVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbMajorVersionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpgradeDbMajorVersionResponse>(response);
        }

        public SyncInvoker<UpgradeDbMajorVersionResponse> UpgradeDbMajorVersionInvoker(UpgradeDbMajorVersionRequest upgradeDbMajorVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeDbMajorVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbMajorVersionRequest);
            return new SyncInvoker<UpgradeDbMajorVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeDbMajorVersionResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 大版本升级前进行升级检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeDbMajorVersionPreCheckResponse UpgradeDbMajorVersionPreCheck(UpgradeDbMajorVersionPreCheckRequest upgradeDbMajorVersionPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeDbMajorVersionPreCheckRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/inspection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbMajorVersionPreCheckRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpgradeDbMajorVersionPreCheckResponse>(response);
        }

        public SyncInvoker<UpgradeDbMajorVersionPreCheckResponse> UpgradeDbMajorVersionPreCheckInvoker(UpgradeDbMajorVersionPreCheckRequest upgradeDbMajorVersionPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeDbMajorVersionPreCheckRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-version/inspection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbMajorVersionPreCheckRequest);
            return new SyncInvoker<UpgradeDbMajorVersionPreCheckResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeDbMajorVersionPreCheckResponse>);
        }
        
        /// <summary>
        /// 升级内核小版本
        ///
        /// 对实例进行小版本升级。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeDbVersionResponse UpgradeDbVersion(UpgradeDbVersionRequest upgradeDbVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeDbVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbVersionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpgradeDbVersionResponse>(response);
        }

        public SyncInvoker<UpgradeDbVersionResponse> UpgradeDbVersionInvoker(UpgradeDbVersionRequest upgradeDbVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeDbVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbVersionRequest);
            return new SyncInvoker<UpgradeDbVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeDbVersionResponse>);
        }
        
        /// <summary>
        /// 升级内核小版本
        ///
        /// 对实例进行小版本升级。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeDbVersionNewResponse UpgradeDbVersionNew(UpgradeDbVersionNewRequest upgradeDbVersionNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeDbVersionNewRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbVersionNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpgradeDbVersionNewResponse>(response);
        }

        public SyncInvoker<UpgradeDbVersionNewResponse> UpgradeDbVersionNewInvoker(UpgradeDbVersionNewRequest upgradeDbVersionNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeDbVersionNewRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbVersionNewRequest);
            return new SyncInvoker<UpgradeDbVersionNewResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeDbVersionNewResponse>);
        }
        
        /// <summary>
        /// MySQL大版本升级
        ///
        /// 提供mysql5.7升级mysql8.0的下发接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeLargeVersionResponse UpgradeLargeVersion(UpgradeLargeVersionRequest upgradeLargeVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeLargeVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeLargeVersionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpgradeLargeVersionResponse>(response);
        }

        public SyncInvoker<UpgradeLargeVersionResponse> UpgradeLargeVersionInvoker(UpgradeLargeVersionRequest upgradeLargeVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeLargeVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/major-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeLargeVersionRequest);
            return new SyncInvoker<UpgradeLargeVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeLargeVersionResponse>);
        }
        
        /// <summary>
        /// 查询API版本列表
        ///
        /// 查询API版本列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListApiVersionResponse ListApiVersion(ListApiVersionRequest listApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionResponse>(response);
        }

        public SyncInvoker<ListApiVersionResponse> ListApiVersionInvoker(ListApiVersionRequest listApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionRequest);
            return new SyncInvoker<ListApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionResponse>);
        }
        
        /// <summary>
        /// 查询API版本列表
        ///
        /// 查询API版本列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListApiVersionNewResponse ListApiVersionNew(ListApiVersionNewRequest listApiVersionNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionNewResponse>(response);
        }

        public SyncInvoker<ListApiVersionNewResponse> ListApiVersionNewInvoker(ListApiVersionNewRequest listApiVersionNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionNewRequest);
            return new SyncInvoker<ListApiVersionNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionNewResponse>);
        }
        
        /// <summary>
        /// 查询指定的API版本信息
        ///
        /// 查询指定的API版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowApiVersionResponse ShowApiVersion(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", showApiVersionRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/rds/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }

        public SyncInvoker<ShowApiVersionResponse> ShowApiVersionInvoker(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", showApiVersionRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/rds/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            return new SyncInvoker<ShowApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApiVersionResponse>);
        }
        
        /// <summary>
        /// 授权数据库帐号
        ///
        /// 授权数据库帐号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AllowDbUserPrivilegeResponse AllowDbUserPrivilege(AllowDbUserPrivilegeRequest allowDbUserPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", allowDbUserPrivilegeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowDbUserPrivilegeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AllowDbUserPrivilegeResponse>(response);
        }

        public SyncInvoker<AllowDbUserPrivilegeResponse> AllowDbUserPrivilegeInvoker(AllowDbUserPrivilegeRequest allowDbUserPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", allowDbUserPrivilegeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowDbUserPrivilegeRequest);
            return new SyncInvoker<AllowDbUserPrivilegeResponse>(this, "POST", request, JsonUtils.DeSerialize<AllowDbUserPrivilegeResponse>);
        }
        
        /// <summary>
        /// 创建数据库
        ///
        /// 创建数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDatabaseResponse CreateDatabase(CreateDatabaseRequest createDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDatabaseResponse>(response);
        }

        public SyncInvoker<CreateDatabaseResponse> CreateDatabaseInvoker(CreateDatabaseRequest createDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDatabaseRequest);
            return new SyncInvoker<CreateDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDatabaseResponse>);
        }
        
        /// <summary>
        /// 创建数据库用户
        ///
        /// 在指定实例中创建数据库帐号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDbUserResponse CreateDbUser(CreateDbUserRequest createDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDbUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDbUserResponse>(response);
        }

        public SyncInvoker<CreateDbUserResponse> CreateDbUserInvoker(CreateDbUserRequest createDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDbUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbUserRequest);
            return new SyncInvoker<CreateDbUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDbUserResponse>);
        }
        
        /// <summary>
        /// 删除数据库
        ///
        /// 删除数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDatabaseResponse DeleteDatabase(DeleteDatabaseRequest deleteDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabaseRequest.InstanceId.ToString());
            urlParam.Add("db_name", deleteDatabaseRequest.DbName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/{db_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDatabaseResponse>(response);
        }

        public SyncInvoker<DeleteDatabaseResponse> DeleteDatabaseInvoker(DeleteDatabaseRequest deleteDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabaseRequest.InstanceId.ToString());
            urlParam.Add("db_name", deleteDatabaseRequest.DbName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/{db_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseRequest);
            return new SyncInvoker<DeleteDatabaseResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDatabaseResponse>);
        }
        
        /// <summary>
        /// 删除数据库用户
        ///
        /// 删除数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDbUserResponse DeleteDbUser(DeleteDbUserRequest deleteDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDbUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", deleteDbUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbUserRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDbUserResponse>(response);
        }

        public SyncInvoker<DeleteDbUserResponse> DeleteDbUserInvoker(DeleteDbUserRequest deleteDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDbUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", deleteDbUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbUserRequest);
            return new SyncInvoker<DeleteDbUserResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDbUserResponse>);
        }
        
        /// <summary>
        /// 查询指定用户的已授权数据库
        ///
        /// 查询指定用户的已授权数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuthorizedDatabasesResponse ListAuthorizedDatabases(ListAuthorizedDatabasesRequest listAuthorizedDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuthorizedDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorizedDatabasesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuthorizedDatabasesResponse>(response);
        }

        public SyncInvoker<ListAuthorizedDatabasesResponse> ListAuthorizedDatabasesInvoker(ListAuthorizedDatabasesRequest listAuthorizedDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuthorizedDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorizedDatabasesRequest);
            return new SyncInvoker<ListAuthorizedDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuthorizedDatabasesResponse>);
        }
        
        /// <summary>
        /// 查询指定数据库的已授权用户
        ///
        /// 查询指定数据库的已授权用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuthorizedDbUsersResponse ListAuthorizedDbUsers(ListAuthorizedDbUsersRequest listAuthorizedDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuthorizedDbUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/db_user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorizedDbUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuthorizedDbUsersResponse>(response);
        }

        public SyncInvoker<ListAuthorizedDbUsersResponse> ListAuthorizedDbUsersInvoker(ListAuthorizedDbUsersRequest listAuthorizedDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuthorizedDbUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/db_user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorizedDbUsersRequest);
            return new SyncInvoker<ListAuthorizedDbUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuthorizedDbUsersResponse>);
        }
        
        /// <summary>
        /// 查询数据库列表
        ///
        /// 查询数据库列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDatabasesResponse ListDatabases(ListDatabasesRequest listDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabasesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDatabasesResponse>(response);
        }

        public SyncInvoker<ListDatabasesResponse> ListDatabasesInvoker(ListDatabasesRequest listDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabasesRequest);
            return new SyncInvoker<ListDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabasesResponse>);
        }
        
        /// <summary>
        /// 查询数据库用户列表
        ///
        /// 查询数据库用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDbUsersResponse ListDbUsers(ListDbUsersRequest listDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDbUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDbUsersResponse>(response);
        }

        public SyncInvoker<ListDbUsersResponse> ListDbUsersInvoker(ListDbUsersRequest listDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDbUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbUsersRequest);
            return new SyncInvoker<ListDbUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDbUsersResponse>);
        }
        
        /// <summary>
        /// 重置数据库密码
        ///
        /// 重置数据库密码.
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetPwdResponse ResetPwd(ResetPwdRequest resetPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetPwdRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPwdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ResetPwdResponse>(response);
        }

        public SyncInvoker<ResetPwdResponse> ResetPwdInvoker(ResetPwdRequest resetPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetPwdRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPwdRequest);
            return new SyncInvoker<ResetPwdResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetPwdResponse>);
        }
        
        /// <summary>
        /// 解除数据库帐号权限
        ///
        /// 解除数据库帐号权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RevokeResponse Revoke(RevokeRequest revokeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", revokeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<RevokeResponse>(response);
        }

        public SyncInvoker<RevokeResponse> RevokeInvoker(RevokeRequest revokeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", revokeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeRequest);
            return new SyncInvoker<RevokeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<RevokeResponse>);
        }
        
        /// <summary>
        /// 设置数据库账号密码
        ///
        /// 设置数据库账号密码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetDbUserPwdResponse SetDbUserPwd(SetDbUserPwdRequest setDbUserPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setDbUserPwdRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/resetpwd", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setDbUserPwdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetDbUserPwdResponse>(response);
        }

        public SyncInvoker<SetDbUserPwdResponse> SetDbUserPwdInvoker(SetDbUserPwdRequest setDbUserPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setDbUserPwdRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/resetpwd", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setDbUserPwdRequest);
            return new SyncInvoker<SetDbUserPwdResponse>(this, "POST", request, JsonUtils.DeSerialize<SetDbUserPwdResponse>);
        }
        
        /// <summary>
        /// 设置数据库用户只读参数
        ///
        /// 根据业务需求，设置数据库用户只读
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetReadOnlySwitchResponse SetReadOnlySwitch(SetReadOnlySwitchRequest setReadOnlySwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setReadOnlySwitchRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/readonly-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setReadOnlySwitchRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SetReadOnlySwitchResponse>(response);
        }

        public SyncInvoker<SetReadOnlySwitchResponse> SetReadOnlySwitchInvoker(SetReadOnlySwitchRequest setReadOnlySwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setReadOnlySwitchRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/readonly-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setReadOnlySwitchRequest);
            return new SyncInvoker<SetReadOnlySwitchResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetReadOnlySwitchResponse>);
        }
        
        /// <summary>
        /// 修改指定实例的数据库备注
        ///
        /// 修改指定实例中的数据库备注。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDatabaseResponse UpdateDatabase(UpdateDatabaseRequest updateDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateDatabaseResponse>(response);
        }

        public SyncInvoker<UpdateDatabaseResponse> UpdateDatabaseInvoker(UpdateDatabaseRequest updateDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDatabaseRequest);
            return new SyncInvoker<UpdateDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateDatabaseResponse>);
        }
        
        /// <summary>
        /// 修改数据库用户名备注
        ///
        /// 修改数据库用户名备注
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDbUserCommentResponse UpdateDbUserComment(UpdateDbUserCommentRequest updateDbUserCommentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateDbUserCommentRequest.InstanceId.ToString());
            urlParam.Add("user_name", updateDbUserCommentRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/{user_name}/comment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDbUserCommentRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDbUserCommentResponse>(response);
        }

        public SyncInvoker<UpdateDbUserCommentResponse> UpdateDbUserCommentInvoker(UpdateDbUserCommentRequest updateDbUserCommentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateDbUserCommentRequest.InstanceId.ToString());
            urlParam.Add("user_name", updateDbUserCommentRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/{user_name}/comment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDbUserCommentRequest);
            return new SyncInvoker<UpdateDbUserCommentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDbUserCommentResponse>);
        }
        
        /// <summary>
        /// 修改实例下用户host信息
        ///
        /// 修改实例下用户host信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateHostPrivilegeResponse UpdateHostPrivilege(UpdateHostPrivilegeRequest updateHostPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateHostPrivilegeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/host-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHostPrivilegeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHostPrivilegeResponse>(response);
        }

        public SyncInvoker<UpdateHostPrivilegeResponse> UpdateHostPrivilegeInvoker(UpdateHostPrivilegeRequest updateHostPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateHostPrivilegeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/host-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHostPrivilegeRequest);
            return new SyncInvoker<UpdateHostPrivilegeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHostPrivilegeResponse>);
        }
        
        /// <summary>
        /// 授权数据库帐号
        ///
        /// 在指定实例的数据库中, 设置帐号的权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AllowDbPrivilegeResponse AllowDbPrivilege(AllowDbPrivilegeRequest allowDbPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", allowDbPrivilegeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowDbPrivilegeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AllowDbPrivilegeResponse>(response);
        }

        public SyncInvoker<AllowDbPrivilegeResponse> AllowDbPrivilegeInvoker(AllowDbPrivilegeRequest allowDbPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", allowDbPrivilegeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowDbPrivilegeRequest);
            return new SyncInvoker<AllowDbPrivilegeResponse>(this, "POST", request, JsonUtils.DeSerialize<AllowDbPrivilegeResponse>);
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
        public ChangeProxyScaleResponse ChangeProxyScale(ChangeProxyScaleRequest changeProxyScaleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeProxyScaleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/scale", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeProxyScaleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeProxyScaleResponse>(response);
        }

        public SyncInvoker<ChangeProxyScaleResponse> ChangeProxyScaleInvoker(ChangeProxyScaleRequest changeProxyScaleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeProxyScaleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/scale", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeProxyScaleRequest);
            return new SyncInvoker<ChangeProxyScaleResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeProxyScaleResponse>);
        }
        
        /// <summary>
        /// 修改读写分离阈值
        ///
        /// 修改指定实例的读写分离延时阈值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeTheDelayThresholdResponse ChangeTheDelayThreshold(ChangeTheDelayThresholdRequest changeTheDelayThresholdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeTheDelayThresholdRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/delay-threshold", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeTheDelayThresholdRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ChangeTheDelayThresholdResponse>(response);
        }

        public SyncInvoker<ChangeTheDelayThresholdResponse> ChangeTheDelayThresholdInvoker(ChangeTheDelayThresholdRequest changeTheDelayThresholdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeTheDelayThresholdRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/delay-threshold", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeTheDelayThresholdRequest);
            return new SyncInvoker<ChangeTheDelayThresholdResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeTheDelayThresholdResponse>);
        }
        
        /// <summary>
        /// 创建数据库
        ///
        /// 在指定实例中创建数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePostgresqlDatabaseResponse CreatePostgresqlDatabase(CreatePostgresqlDatabaseRequest createPostgresqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createPostgresqlDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostgresqlDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePostgresqlDatabaseResponse>(response);
        }

        public SyncInvoker<CreatePostgresqlDatabaseResponse> CreatePostgresqlDatabaseInvoker(CreatePostgresqlDatabaseRequest createPostgresqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createPostgresqlDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostgresqlDatabaseRequest);
            return new SyncInvoker<CreatePostgresqlDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePostgresqlDatabaseResponse>);
        }
        
        /// <summary>
        /// 创建数据库SCHEMA
        ///
        /// 在指定实例的数据库中, 创建数据库schema。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePostgresqlDatabaseSchemaResponse CreatePostgresqlDatabaseSchema(CreatePostgresqlDatabaseSchemaRequest createPostgresqlDatabaseSchemaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createPostgresqlDatabaseSchemaRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostgresqlDatabaseSchemaRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePostgresqlDatabaseSchemaResponse>(response);
        }

        public SyncInvoker<CreatePostgresqlDatabaseSchemaResponse> CreatePostgresqlDatabaseSchemaInvoker(CreatePostgresqlDatabaseSchemaRequest createPostgresqlDatabaseSchemaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createPostgresqlDatabaseSchemaRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostgresqlDatabaseSchemaRequest);
            return new SyncInvoker<CreatePostgresqlDatabaseSchemaResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePostgresqlDatabaseSchemaResponse>);
        }
        
        /// <summary>
        /// 创建数据库用户
        ///
        /// 在指定实例中创建数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePostgresqlDbUserResponse CreatePostgresqlDbUser(CreatePostgresqlDbUserRequest createPostgresqlDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createPostgresqlDbUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostgresqlDbUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePostgresqlDbUserResponse>(response);
        }

        public SyncInvoker<CreatePostgresqlDbUserResponse> CreatePostgresqlDbUserInvoker(CreatePostgresqlDbUserRequest createPostgresqlDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createPostgresqlDbUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostgresqlDbUserRequest);
            return new SyncInvoker<CreatePostgresqlDbUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePostgresqlDbUserResponse>);
        }
        
        /// <summary>
        /// 创建插件
        ///
        /// 在指定数据库上创建插件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePostgresqlExtensionResponse CreatePostgresqlExtension(CreatePostgresqlExtensionRequest createPostgresqlExtensionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createPostgresqlExtensionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostgresqlExtensionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreatePostgresqlExtensionResponse>(response);
        }

        public SyncInvoker<CreatePostgresqlExtensionResponse> CreatePostgresqlExtensionInvoker(CreatePostgresqlExtensionRequest createPostgresqlExtensionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createPostgresqlExtensionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostgresqlExtensionRequest);
            return new SyncInvoker<CreatePostgresqlExtensionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreatePostgresqlExtensionResponse>);
        }
        
        /// <summary>
        /// 删除数据库
        ///
        /// 删除数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePostgresqlDatabaseResponse DeletePostgresqlDatabase(DeletePostgresqlDatabaseRequest deletePostgresqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deletePostgresqlDatabaseRequest.InstanceId.ToString());
            urlParam.Add("db_name", deletePostgresqlDatabaseRequest.DbName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/{db_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePostgresqlDatabaseRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePostgresqlDatabaseResponse>(response);
        }

        public SyncInvoker<DeletePostgresqlDatabaseResponse> DeletePostgresqlDatabaseInvoker(DeletePostgresqlDatabaseRequest deletePostgresqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deletePostgresqlDatabaseRequest.InstanceId.ToString());
            urlParam.Add("db_name", deletePostgresqlDatabaseRequest.DbName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/{db_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePostgresqlDatabaseRequest);
            return new SyncInvoker<DeletePostgresqlDatabaseResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePostgresqlDatabaseResponse>);
        }
        
        /// <summary>
        /// 删除数据库用户
        ///
        /// 删除数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePostgresqlDbUserResponse DeletePostgresqlDbUser(DeletePostgresqlDbUserRequest deletePostgresqlDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deletePostgresqlDbUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", deletePostgresqlDbUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePostgresqlDbUserRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePostgresqlDbUserResponse>(response);
        }

        public SyncInvoker<DeletePostgresqlDbUserResponse> DeletePostgresqlDbUserInvoker(DeletePostgresqlDbUserRequest deletePostgresqlDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deletePostgresqlDbUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", deletePostgresqlDbUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePostgresqlDbUserRequest);
            return new SyncInvoker<DeletePostgresqlDbUserResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePostgresqlDbUserResponse>);
        }
        
        /// <summary>
        /// 删除插件
        ///
        /// 在指定数据库上删除插件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePostgresqlExtensionResponse DeletePostgresqlExtension(DeletePostgresqlExtensionRequest deletePostgresqlExtensionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deletePostgresqlExtensionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePostgresqlExtensionRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePostgresqlExtensionResponse>(response);
        }

        public SyncInvoker<DeletePostgresqlExtensionResponse> DeletePostgresqlExtensionInvoker(DeletePostgresqlExtensionRequest deletePostgresqlExtensionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deletePostgresqlExtensionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePostgresqlExtensionRequest);
            return new SyncInvoker<DeletePostgresqlExtensionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePostgresqlExtensionResponse>);
        }
        
        /// <summary>
        /// 授予用户角色
        ///
        /// 授予用户角色
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecutePrivilegeDatabaseUserRoleResponse ExecutePrivilegeDatabaseUserRole(ExecutePrivilegeDatabaseUserRoleRequest executePrivilegeDatabaseUserRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executePrivilegeDatabaseUserRoleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executePrivilegeDatabaseUserRoleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecutePrivilegeDatabaseUserRoleResponse>(response);
        }

        public SyncInvoker<ExecutePrivilegeDatabaseUserRoleResponse> ExecutePrivilegeDatabaseUserRoleInvoker(ExecutePrivilegeDatabaseUserRoleRequest executePrivilegeDatabaseUserRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executePrivilegeDatabaseUserRoleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executePrivilegeDatabaseUserRoleRequest);
            return new SyncInvoker<ExecutePrivilegeDatabaseUserRoleResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecutePrivilegeDatabaseUserRoleResponse>);
        }
        
        /// <summary>
        /// 撤回用户角色
        ///
        /// 撤回用户角色
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteRevokeDatabaseUserRoleResponse ExecuteRevokeDatabaseUserRole(ExecuteRevokeDatabaseUserRoleRequest executeRevokeDatabaseUserRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeRevokeDatabaseUserRoleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeRevokeDatabaseUserRoleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<ExecuteRevokeDatabaseUserRoleResponse>(response);
        }

        public SyncInvoker<ExecuteRevokeDatabaseUserRoleResponse> ExecuteRevokeDatabaseUserRoleInvoker(ExecuteRevokeDatabaseUserRoleRequest executeRevokeDatabaseUserRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeRevokeDatabaseUserRoleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeRevokeDatabaseUserRoleRequest);
            return new SyncInvoker<ExecuteRevokeDatabaseUserRoleResponse>(this, "DELETE", request, JsonUtils.DeSerialize<ExecuteRevokeDatabaseUserRoleResponse>);
        }
        
        /// <summary>
        /// 查询数据库角色信息
        ///
        /// 查询数据库角色信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDatabaseUserRoleResponse ListDatabaseUserRole(ListDatabaseUserRoleRequest listDatabaseUserRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabaseUserRoleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseUserRoleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDatabaseUserRoleResponse>(response);
        }

        public SyncInvoker<ListDatabaseUserRoleResponse> ListDatabaseUserRoleInvoker(ListDatabaseUserRoleRequest listDatabaseUserRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabaseUserRoleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseUserRoleRequest);
            return new SyncInvoker<ListDatabaseUserRoleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabaseUserRoleResponse>);
        }
        
        /// <summary>
        /// 查询数据库SCHEMA列表
        ///
        /// 查询指定实例的数据库SCHEMA列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPostgresqlDatabaseSchemasResponse ListPostgresqlDatabaseSchemas(ListPostgresqlDatabaseSchemasRequest listPostgresqlDatabaseSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPostgresqlDatabaseSchemasRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlDatabaseSchemasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPostgresqlDatabaseSchemasResponse>(response);
        }

        public SyncInvoker<ListPostgresqlDatabaseSchemasResponse> ListPostgresqlDatabaseSchemasInvoker(ListPostgresqlDatabaseSchemasRequest listPostgresqlDatabaseSchemasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPostgresqlDatabaseSchemasRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlDatabaseSchemasRequest);
            return new SyncInvoker<ListPostgresqlDatabaseSchemasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPostgresqlDatabaseSchemasResponse>);
        }
        
        /// <summary>
        /// 查询数据库列表
        ///
        /// 查询指定实例中的数据库列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPostgresqlDatabasesResponse ListPostgresqlDatabases(ListPostgresqlDatabasesRequest listPostgresqlDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPostgresqlDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlDatabasesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPostgresqlDatabasesResponse>(response);
        }

        public SyncInvoker<ListPostgresqlDatabasesResponse> ListPostgresqlDatabasesInvoker(ListPostgresqlDatabasesRequest listPostgresqlDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPostgresqlDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlDatabasesRequest);
            return new SyncInvoker<ListPostgresqlDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPostgresqlDatabasesResponse>);
        }
        
        /// <summary>
        /// 查询数据库用户列表
        ///
        /// 在指定实例中查询数据库用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPostgresqlDbUserPaginatedResponse ListPostgresqlDbUserPaginated(ListPostgresqlDbUserPaginatedRequest listPostgresqlDbUserPaginatedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPostgresqlDbUserPaginatedRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlDbUserPaginatedRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPostgresqlDbUserPaginatedResponse>(response);
        }

        public SyncInvoker<ListPostgresqlDbUserPaginatedResponse> ListPostgresqlDbUserPaginatedInvoker(ListPostgresqlDbUserPaginatedRequest listPostgresqlDbUserPaginatedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPostgresqlDbUserPaginatedRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlDbUserPaginatedRequest);
            return new SyncInvoker<ListPostgresqlDbUserPaginatedResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPostgresqlDbUserPaginatedResponse>);
        }
        
        /// <summary>
        /// 查询插件
        ///
        /// 获取指定数据库的插件信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPostgresqlExtensionResponse ListPostgresqlExtension(ListPostgresqlExtensionRequest listPostgresqlExtensionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPostgresqlExtensionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlExtensionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPostgresqlExtensionResponse>(response);
        }

        public SyncInvoker<ListPostgresqlExtensionResponse> ListPostgresqlExtensionInvoker(ListPostgresqlExtensionRequest listPostgresqlExtensionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPostgresqlExtensionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostgresqlExtensionRequest);
            return new SyncInvoker<ListPostgresqlExtensionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPostgresqlExtensionResponse>);
        }
        
        /// <summary>
        /// 解除数据库帐号权限
        ///
        /// 解除数据库帐号权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RevokePostgresqlDbPrivilegeResponse RevokePostgresqlDbPrivilege(RevokePostgresqlDbPrivilegeRequest revokePostgresqlDbPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", revokePostgresqlDbPrivilegeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokePostgresqlDbPrivilegeRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<RevokePostgresqlDbPrivilegeResponse>(response);
        }

        public SyncInvoker<RevokePostgresqlDbPrivilegeResponse> RevokePostgresqlDbPrivilegeInvoker(RevokePostgresqlDbPrivilegeRequest revokePostgresqlDbPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", revokePostgresqlDbPrivilegeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokePostgresqlDbPrivilegeRequest);
            return new SyncInvoker<RevokePostgresqlDbPrivilegeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<RevokePostgresqlDbPrivilegeResponse>);
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
        public SearchQueryScaleComputeFlavorsResponse SearchQueryScaleComputeFlavors(SearchQueryScaleComputeFlavorsRequest searchQueryScaleComputeFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", searchQueryScaleComputeFlavorsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/proxy/scale/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQueryScaleComputeFlavorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchQueryScaleComputeFlavorsResponse>(response);
        }

        public SyncInvoker<SearchQueryScaleComputeFlavorsResponse> SearchQueryScaleComputeFlavorsInvoker(SearchQueryScaleComputeFlavorsRequest searchQueryScaleComputeFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", searchQueryScaleComputeFlavorsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/proxy/scale/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQueryScaleComputeFlavorsRequest);
            return new SyncInvoker<SearchQueryScaleComputeFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchQueryScaleComputeFlavorsResponse>);
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
        public SearchQueryScaleFlavorsResponse SearchQueryScaleFlavors(SearchQueryScaleFlavorsRequest searchQueryScaleFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", searchQueryScaleFlavorsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/scale/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQueryScaleFlavorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchQueryScaleFlavorsResponse>(response);
        }

        public SyncInvoker<SearchQueryScaleFlavorsResponse> SearchQueryScaleFlavorsInvoker(SearchQueryScaleFlavorsRequest searchQueryScaleFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", searchQueryScaleFlavorsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/scale/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchQueryScaleFlavorsRequest);
            return new SyncInvoker<SearchQueryScaleFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchQueryScaleFlavorsResponse>);
        }
        
        /// <summary>
        /// 设置数据库用户权限
        ///
        /// 设置数据库用户权限：只读或可读写。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetDatabaseUserPrivilegeResponse SetDatabaseUserPrivilege(SetDatabaseUserPrivilegeRequest setDatabaseUserPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setDatabaseUserPrivilegeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/user-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setDatabaseUserPrivilegeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SetDatabaseUserPrivilegeResponse>(response);
        }

        public SyncInvoker<SetDatabaseUserPrivilegeResponse> SetDatabaseUserPrivilegeInvoker(SetDatabaseUserPrivilegeRequest setDatabaseUserPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setDatabaseUserPrivilegeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/user-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setDatabaseUserPrivilegeRequest);
            return new SyncInvoker<SetDatabaseUserPrivilegeResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetDatabaseUserPrivilegeResponse>);
        }
        
        /// <summary>
        /// 重置数据库帐号密码
        ///
        /// 重置指定数据库帐号的密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetPostgresqlDbUserPwdResponse SetPostgresqlDbUserPwd(SetPostgresqlDbUserPwdRequest setPostgresqlDbUserPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setPostgresqlDbUserPwdRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/resetpwd", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setPostgresqlDbUserPwdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetPostgresqlDbUserPwdResponse>(response);
        }

        public SyncInvoker<SetPostgresqlDbUserPwdResponse> SetPostgresqlDbUserPwdInvoker(SetPostgresqlDbUserPwdRequest setPostgresqlDbUserPwdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setPostgresqlDbUserPwdRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/resetpwd", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setPostgresqlDbUserPwdRequest);
            return new SyncInvoker<SetPostgresqlDbUserPwdResponse>(this, "POST", request, JsonUtils.DeSerialize<SetPostgresqlDbUserPwdResponse>);
        }
        
        /// <summary>
        /// 查询数据库代理信息
        ///
        /// 查询指定实例的数据库代理详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInformationAboutDatabaseProxyResponse ShowInformationAboutDatabaseProxy(ShowInformationAboutDatabaseProxyRequest showInformationAboutDatabaseProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInformationAboutDatabaseProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInformationAboutDatabaseProxyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInformationAboutDatabaseProxyResponse>(response);
        }

        public SyncInvoker<ShowInformationAboutDatabaseProxyResponse> ShowInformationAboutDatabaseProxyInvoker(ShowInformationAboutDatabaseProxyRequest showInformationAboutDatabaseProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInformationAboutDatabaseProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInformationAboutDatabaseProxyRequest);
            return new SyncInvoker<ShowInformationAboutDatabaseProxyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInformationAboutDatabaseProxyResponse>);
        }
        
        /// <summary>
        /// 获取实例指定参数的值
        ///
        /// 获取实例指定参数的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPostgresqlParamValueResponse ShowPostgresqlParamValue(ShowPostgresqlParamValueRequest showPostgresqlParamValueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPostgresqlParamValueRequest.InstanceId.ToString());
            urlParam.Add("name", showPostgresqlParamValueRequest.Name.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/parameter/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPostgresqlParamValueRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPostgresqlParamValueResponse>(response);
        }

        public SyncInvoker<ShowPostgresqlParamValueResponse> ShowPostgresqlParamValueInvoker(ShowPostgresqlParamValueRequest showPostgresqlParamValueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPostgresqlParamValueRequest.InstanceId.ToString());
            urlParam.Add("name", showPostgresqlParamValueRequest.Name.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/parameter/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPostgresqlParamValueRequest);
            return new SyncInvoker<ShowPostgresqlParamValueResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPostgresqlParamValueResponse>);
        }
        
        /// <summary>
        /// 查询wal日志恢复时间窗
        ///
        /// 查询wal日志恢复时间窗
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecoveryTimeWindowResponse ShowRecoveryTimeWindow(ShowRecoveryTimeWindowRequest showRecoveryTimeWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRecoveryTimeWindowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/recovery-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecoveryTimeWindowRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRecoveryTimeWindowResponse>(response);
        }

        public SyncInvoker<ShowRecoveryTimeWindowResponse> ShowRecoveryTimeWindowInvoker(ShowRecoveryTimeWindowRequest showRecoveryTimeWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRecoveryTimeWindowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/recovery-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecoveryTimeWindowRequest);
            return new SyncInvoker<ShowRecoveryTimeWindowResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecoveryTimeWindowResponse>);
        }
        
        /// <summary>
        /// 获取wal日志延迟回放状态
        ///
        /// 获取wal日志延迟回放状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowReplayDelayStatusResponse ShowReplayDelayStatus(ShowReplayDelayStatusRequest showReplayDelayStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showReplayDelayStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replay-delay/show", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplayDelayStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowReplayDelayStatusResponse>(response);
        }

        public SyncInvoker<ShowReplayDelayStatusResponse> ShowReplayDelayStatusInvoker(ShowReplayDelayStatusRequest showReplayDelayStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showReplayDelayStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/replay-delay/show", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplayDelayStatusRequest);
            return new SyncInvoker<ShowReplayDelayStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReplayDelayStatusResponse>);
        }
        
        /// <summary>
        /// 开启数据库代理
        ///
        /// 为指定实例开启数据库代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartDatabaseProxyResponse StartDatabaseProxy(StartDatabaseProxyRequest startDatabaseProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startDatabaseProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDatabaseProxyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartDatabaseProxyResponse>(response);
        }

        public SyncInvoker<StartDatabaseProxyResponse> StartDatabaseProxyInvoker(StartDatabaseProxyRequest startDatabaseProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startDatabaseProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDatabaseProxyRequest);
            return new SyncInvoker<StartDatabaseProxyResponse>(this, "POST", request, JsonUtils.DeSerialize<StartDatabaseProxyResponse>);
        }
        
        /// <summary>
        /// 关闭数据库代理
        ///
        /// 为指定实例关闭数据库代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopDatabaseProxyResponse StopDatabaseProxy(StopDatabaseProxyRequest stopDatabaseProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", stopDatabaseProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopDatabaseProxyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<StopDatabaseProxyResponse>(response);
        }

        public SyncInvoker<StopDatabaseProxyResponse> StopDatabaseProxyInvoker(StopDatabaseProxyRequest stopDatabaseProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", stopDatabaseProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopDatabaseProxyRequest);
            return new SyncInvoker<StopDatabaseProxyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<StopDatabaseProxyResponse>);
        }
        
        /// <summary>
        /// 中止/恢复wal日志回放
        ///
        /// 中止/恢复wal日志回放
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchLogReplayResponse SwitchLogReplay(SwitchLogReplayRequest switchLogReplayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchLogReplayRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/log-replay/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchLogReplayRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SwitchLogReplayResponse>(response);
        }

        public SyncInvoker<SwitchLogReplayResponse> SwitchLogReplayInvoker(SwitchLogReplayRequest switchLogReplayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchLogReplayRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/log-replay/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchLogReplayRequest);
            return new SyncInvoker<SwitchLogReplayResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchLogReplayResponse>);
        }
        
        /// <summary>
        /// 修改数据库owner
        ///
        /// 修改数据库owner
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDatabaseOwnerResponse UpdateDatabaseOwner(UpdateDatabaseOwnerRequest updateDatabaseOwnerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateDatabaseOwnerRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/owner", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDatabaseOwnerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateDatabaseOwnerResponse>(response);
        }

        public SyncInvoker<UpdateDatabaseOwnerResponse> UpdateDatabaseOwnerInvoker(UpdateDatabaseOwnerRequest updateDatabaseOwnerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateDatabaseOwnerRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/owner", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDatabaseOwnerRequest);
            return new SyncInvoker<UpdateDatabaseOwnerResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateDatabaseOwnerResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 数据库帐号授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDbUserPrivilegeResponse UpdateDbUserPrivilege(UpdateDbUserPrivilegeRequest updateDbUserPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateDbUserPrivilegeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDbUserPrivilegeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateDbUserPrivilegeResponse>(response);
        }

        public SyncInvoker<UpdateDbUserPrivilegeResponse> UpdateDbUserPrivilegeInvoker(UpdateDbUserPrivilegeRequest updateDbUserPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateDbUserPrivilegeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-user-privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDbUserPrivilegeRequest);
            return new SyncInvoker<UpdateDbUserPrivilegeResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateDbUserPrivilegeResponse>);
        }
        
        /// <summary>
        /// 修改指定实例的数据库备注
        ///
        /// 修改指定实例中的数据库备注。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePostgresqlDatabaseResponse UpdatePostgresqlDatabase(UpdatePostgresqlDatabaseRequest updatePostgresqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePostgresqlDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdatePostgresqlDatabaseResponse>(response);
        }

        public SyncInvoker<UpdatePostgresqlDatabaseResponse> UpdatePostgresqlDatabaseInvoker(UpdatePostgresqlDatabaseRequest updatePostgresqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePostgresqlDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlDatabaseRequest);
            return new SyncInvoker<UpdatePostgresqlDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdatePostgresqlDatabaseResponse>);
        }
        
        /// <summary>
        /// 修改数据库用户名备注
        ///
        /// 修改数据库用户名备注
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePostgresqlDbUserCommentResponse UpdatePostgresqlDbUserComment(UpdatePostgresqlDbUserCommentRequest updatePostgresqlDbUserCommentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePostgresqlDbUserCommentRequest.InstanceId.ToString());
            urlParam.Add("user_name", updatePostgresqlDbUserCommentRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/{user_name}/comment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlDbUserCommentRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePostgresqlDbUserCommentResponse>(response);
        }

        public SyncInvoker<UpdatePostgresqlDbUserCommentResponse> UpdatePostgresqlDbUserCommentInvoker(UpdatePostgresqlDbUserCommentRequest updatePostgresqlDbUserCommentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePostgresqlDbUserCommentRequest.InstanceId.ToString());
            urlParam.Add("user_name", updatePostgresqlDbUserCommentRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/{user_name}/comment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlDbUserCommentRequest);
            return new SyncInvoker<UpdatePostgresqlDbUserCommentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePostgresqlDbUserCommentResponse>);
        }
        
        /// <summary>
        /// 更新插件
        ///
        /// 在指定数据库上更新插件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePostgresqlExtensionResponse UpdatePostgresqlExtension(UpdatePostgresqlExtensionRequest updatePostgresqlExtensionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePostgresqlExtensionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlExtensionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePostgresqlExtensionResponse>(response);
        }

        public SyncInvoker<UpdatePostgresqlExtensionResponse> UpdatePostgresqlExtensionInvoker(UpdatePostgresqlExtensionRequest updatePostgresqlExtensionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePostgresqlExtensionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlExtensionRequest);
            return new SyncInvoker<UpdatePostgresqlExtensionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePostgresqlExtensionResponse>);
        }
        
        /// <summary>
        /// 修改实例指定参数的值
        ///
        /// 修改实例指定参数的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePostgresqlParameterValueResponse UpdatePostgresqlParameterValue(UpdatePostgresqlParameterValueRequest updatePostgresqlParameterValueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePostgresqlParameterValueRequest.InstanceId.ToString());
            urlParam.Add("name", updatePostgresqlParameterValueRequest.Name.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/parameter/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlParameterValueRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePostgresqlParameterValueResponse>(response);
        }

        public SyncInvoker<UpdatePostgresqlParameterValueResponse> UpdatePostgresqlParameterValueInvoker(UpdatePostgresqlParameterValueRequest updatePostgresqlParameterValueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePostgresqlParameterValueRequest.InstanceId.ToString());
            urlParam.Add("name", updatePostgresqlParameterValueRequest.Name.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/parameter/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePostgresqlParameterValueRequest);
            return new SyncInvoker<UpdatePostgresqlParameterValueResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePostgresqlParameterValueResponse>);
        }
        
        /// <summary>
        /// 修改读写分离权重
        ///
        /// 修改指定实例的读写分离权重。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateReadWeightResponse UpdateReadWeight(UpdateReadWeightRequest updateReadWeightRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateReadWeightRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/weight", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReadWeightRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateReadWeightResponse>(response);
        }

        public SyncInvoker<UpdateReadWeightResponse> UpdateReadWeightInvoker(UpdateReadWeightRequest updateReadWeightRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateReadWeightRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/weight", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReadWeightRequest);
            return new SyncInvoker<UpdateReadWeightResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateReadWeightResponse>);
        }
        
        /// <summary>
        /// 授权数据库帐号
        ///
        /// 授权数据库帐号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AllowSqlserverDbUserPrivilegeResponse AllowSqlserverDbUserPrivilege(AllowSqlserverDbUserPrivilegeRequest allowSqlserverDbUserPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", allowSqlserverDbUserPrivilegeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowSqlserverDbUserPrivilegeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AllowSqlserverDbUserPrivilegeResponse>(response);
        }

        public SyncInvoker<AllowSqlserverDbUserPrivilegeResponse> AllowSqlserverDbUserPrivilegeInvoker(AllowSqlserverDbUserPrivilegeRequest allowSqlserverDbUserPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", allowSqlserverDbUserPrivilegeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", allowSqlserverDbUserPrivilegeRequest);
            return new SyncInvoker<AllowSqlserverDbUserPrivilegeResponse>(this, "POST", request, JsonUtils.DeSerialize<AllowSqlserverDbUserPrivilegeResponse>);
        }
        
        /// <summary>
        /// 添加MSDTC
        ///
        /// 添加MSDTC相关主机host地址
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchAddMsdtcsResponse BatchAddMsdtcs(BatchAddMsdtcsRequest batchAddMsdtcsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchAddMsdtcsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/msdtc/host", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddMsdtcsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchAddMsdtcsResponse>(response);
        }

        public SyncInvoker<BatchAddMsdtcsResponse> BatchAddMsdtcsInvoker(BatchAddMsdtcsRequest batchAddMsdtcsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchAddMsdtcsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/msdtc/host", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddMsdtcsRequest);
            return new SyncInvoker<BatchAddMsdtcsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAddMsdtcsResponse>);
        }
        
        /// <summary>
        /// 复制数据库
        ///
        /// 复制数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CopyDatabaseResponse CopyDatabase(CopyDatabaseRequest copyDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", copyDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/procedure", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CopyDatabaseResponse>(response);
        }

        public SyncInvoker<CopyDatabaseResponse> CopyDatabaseInvoker(CopyDatabaseRequest copyDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", copyDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/procedure", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyDatabaseRequest);
            return new SyncInvoker<CopyDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyDatabaseResponse>);
        }
        
        /// <summary>
        /// 创建数据库
        ///
        /// 创建数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSqlserverDatabaseResponse CreateSqlserverDatabase(CreateSqlserverDatabaseRequest createSqlserverDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createSqlserverDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSqlserverDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSqlserverDatabaseResponse>(response);
        }

        public SyncInvoker<CreateSqlserverDatabaseResponse> CreateSqlserverDatabaseInvoker(CreateSqlserverDatabaseRequest createSqlserverDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createSqlserverDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSqlserverDatabaseRequest);
            return new SyncInvoker<CreateSqlserverDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSqlserverDatabaseResponse>);
        }
        
        /// <summary>
        /// 创建数据库用户
        ///
        /// 创建数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSqlserverDbUserResponse CreateSqlserverDbUser(CreateSqlserverDbUserRequest createSqlserverDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createSqlserverDbUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSqlserverDbUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSqlserverDbUserResponse>(response);
        }

        public SyncInvoker<CreateSqlserverDbUserResponse> CreateSqlserverDbUserInvoker(CreateSqlserverDbUserRequest createSqlserverDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createSqlserverDbUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSqlserverDbUserRequest);
            return new SyncInvoker<CreateSqlserverDbUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSqlserverDbUserResponse>);
        }
        
        /// <summary>
        /// 删除MSDTC
        ///
        /// 删除MSDTC相关主机host地址
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteMsdtcLocalHostResponse DeleteMsdtcLocalHost(DeleteMsdtcLocalHostRequest deleteMsdtcLocalHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteMsdtcLocalHostRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/msdtc/host", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMsdtcLocalHostRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteMsdtcLocalHostResponse>(response);
        }

        public SyncInvoker<DeleteMsdtcLocalHostResponse> DeleteMsdtcLocalHostInvoker(DeleteMsdtcLocalHostRequest deleteMsdtcLocalHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteMsdtcLocalHostRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/msdtc/host", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMsdtcLocalHostRequest);
            return new SyncInvoker<DeleteMsdtcLocalHostResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteMsdtcLocalHostResponse>);
        }
        
        /// <summary>
        /// 删除数据库
        ///
        /// 删除数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSqlserverDatabaseResponse DeleteSqlserverDatabase(DeleteSqlserverDatabaseRequest deleteSqlserverDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteSqlserverDatabaseRequest.InstanceId.ToString());
            urlParam.Add("db_name", deleteSqlserverDatabaseRequest.DbName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/{db_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlserverDatabaseRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSqlserverDatabaseResponse>(response);
        }

        public SyncInvoker<DeleteSqlserverDatabaseResponse> DeleteSqlserverDatabaseInvoker(DeleteSqlserverDatabaseRequest deleteSqlserverDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteSqlserverDatabaseRequest.InstanceId.ToString());
            urlParam.Add("db_name", deleteSqlserverDatabaseRequest.DbName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/{db_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlserverDatabaseRequest);
            return new SyncInvoker<DeleteSqlserverDatabaseResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSqlserverDatabaseResponse>);
        }
        
        /// <summary>
        /// 删除数据库
        ///
        /// 删除数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSqlserverDatabaseExResponse DeleteSqlserverDatabaseEx(DeleteSqlserverDatabaseExRequest deleteSqlserverDatabaseExRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteSqlserverDatabaseExRequest.InstanceId.ToString());
            urlParam.Add("db_name", deleteSqlserverDatabaseExRequest.DbName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/database/{db_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlserverDatabaseExRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSqlserverDatabaseExResponse>(response);
        }

        public SyncInvoker<DeleteSqlserverDatabaseExResponse> DeleteSqlserverDatabaseExInvoker(DeleteSqlserverDatabaseExRequest deleteSqlserverDatabaseExRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteSqlserverDatabaseExRequest.InstanceId.ToString());
            urlParam.Add("db_name", deleteSqlserverDatabaseExRequest.DbName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/database/{db_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlserverDatabaseExRequest);
            return new SyncInvoker<DeleteSqlserverDatabaseExResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSqlserverDatabaseExResponse>);
        }
        
        /// <summary>
        /// 删除数据库用户
        ///
        /// 删除数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSqlserverDbUserResponse DeleteSqlserverDbUser(DeleteSqlserverDbUserRequest deleteSqlserverDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteSqlserverDbUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", deleteSqlserverDbUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlserverDbUserRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSqlserverDbUserResponse>(response);
        }

        public SyncInvoker<DeleteSqlserverDbUserResponse> DeleteSqlserverDbUserInvoker(DeleteSqlserverDbUserRequest deleteSqlserverDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteSqlserverDbUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", deleteSqlserverDbUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlserverDbUserRequest);
            return new SyncInvoker<DeleteSqlserverDbUserResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSqlserverDbUserResponse>);
        }
        
        /// <summary>
        /// 查询指定数据库的已授权用户
        ///
        /// 查询指定数据库的已授权用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuthorizedSqlserverDbUsersResponse ListAuthorizedSqlserverDbUsers(ListAuthorizedSqlserverDbUsersRequest listAuthorizedSqlserverDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuthorizedSqlserverDbUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/db_user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorizedSqlserverDbUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuthorizedSqlserverDbUsersResponse>(response);
        }

        public SyncInvoker<ListAuthorizedSqlserverDbUsersResponse> ListAuthorizedSqlserverDbUsersInvoker(ListAuthorizedSqlserverDbUsersRequest listAuthorizedSqlserverDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuthorizedSqlserverDbUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/db_user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorizedSqlserverDbUsersRequest);
            return new SyncInvoker<ListAuthorizedSqlserverDbUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuthorizedSqlserverDbUsersResponse>);
        }
        
        /// <summary>
        /// 查询云市场服务商列表
        ///
        /// 查询云市场服务商列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBusinessPartnersResponse ListBusinessPartners(ListBusinessPartnersRequest listBusinessPartnersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/business-partners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBusinessPartnersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBusinessPartnersResponse>(response);
        }

        public SyncInvoker<ListBusinessPartnersResponse> ListBusinessPartnersInvoker(ListBusinessPartnersRequest listBusinessPartnersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/business-partners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBusinessPartnersRequest);
            return new SyncInvoker<ListBusinessPartnersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBusinessPartnersResponse>);
        }
        
        /// <summary>
        /// 查询云市场引擎商品列表
        ///
        /// 查询云市场引擎商品列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMarketplaceEngineProductsResponse ListMarketplaceEngineProducts(ListMarketplaceEngineProductsRequest listMarketplaceEngineProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bp_domain_id", listMarketplaceEngineProductsRequest.BpDomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/business-partner/{bp_domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMarketplaceEngineProductsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMarketplaceEngineProductsResponse>(response);
        }

        public SyncInvoker<ListMarketplaceEngineProductsResponse> ListMarketplaceEngineProductsInvoker(ListMarketplaceEngineProductsRequest listMarketplaceEngineProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bp_domain_id", listMarketplaceEngineProductsRequest.BpDomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/business-partner/{bp_domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMarketplaceEngineProductsRequest);
            return new SyncInvoker<ListMarketplaceEngineProductsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMarketplaceEngineProductsResponse>);
        }
        
        /// <summary>
        /// 查询MSDTC的hosts信息
        ///
        /// 查询MSDTC的hosts信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMsdtcHostsResponse ListMsdtcHosts(ListMsdtcHostsRequest listMsdtcHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listMsdtcHostsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/msdtc/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMsdtcHostsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMsdtcHostsResponse>(response);
        }

        public SyncInvoker<ListMsdtcHostsResponse> ListMsdtcHostsInvoker(ListMsdtcHostsRequest listMsdtcHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listMsdtcHostsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/msdtc/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMsdtcHostsRequest);
            return new SyncInvoker<ListMsdtcHostsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMsdtcHostsResponse>);
        }
        
        /// <summary>
        /// 查询数据库列表
        ///
        /// 查询数据库列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSqlserverDatabasesResponse ListSqlserverDatabases(ListSqlserverDatabasesRequest listSqlserverDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSqlserverDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlserverDatabasesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSqlserverDatabasesResponse>(response);
        }

        public SyncInvoker<ListSqlserverDatabasesResponse> ListSqlserverDatabasesInvoker(ListSqlserverDatabasesRequest listSqlserverDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSqlserverDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlserverDatabasesRequest);
            return new SyncInvoker<ListSqlserverDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSqlserverDatabasesResponse>);
        }
        
        /// <summary>
        /// 查询数据库用户列表
        ///
        /// 查询数据库用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSqlserverDbUsersResponse ListSqlserverDbUsers(ListSqlserverDbUsersRequest listSqlserverDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSqlserverDbUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlserverDbUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSqlserverDbUsersResponse>(response);
        }

        public SyncInvoker<ListSqlserverDbUsersResponse> ListSqlserverDbUsersInvoker(ListSqlserverDbUsersRequest listSqlserverDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSqlserverDbUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_user/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlserverDbUsersRequest);
            return new SyncInvoker<ListSqlserverDbUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSqlserverDbUsersResponse>);
        }
        
        /// <summary>
        /// 修改实例字符集
        ///
        /// 修改实例字符集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyCollationResponse ModifyCollation(ModifyCollationRequest modifyCollationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyCollationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/collations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyCollationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyCollationResponse>(response);
        }

        public SyncInvoker<ModifyCollationResponse> ModifyCollationInvoker(ModifyCollationRequest modifyCollationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyCollationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/collations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyCollationRequest);
            return new SyncInvoker<ModifyCollationResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyCollationResponse>);
        }
        
        /// <summary>
        /// 解除数据库帐号权限
        ///
        /// 解除数据库帐号权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RevokeSqlserverDbUserPrivilegeResponse RevokeSqlserverDbUserPrivilege(RevokeSqlserverDbUserPrivilegeRequest revokeSqlserverDbUserPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", revokeSqlserverDbUserPrivilegeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeSqlserverDbUserPrivilegeRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<RevokeSqlserverDbUserPrivilegeResponse>(response);
        }

        public SyncInvoker<RevokeSqlserverDbUserPrivilegeResponse> RevokeSqlserverDbUserPrivilegeInvoker(RevokeSqlserverDbUserPrivilegeRequest revokeSqlserverDbUserPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", revokeSqlserverDbUserPrivilegeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeSqlserverDbUserPrivilegeRequest);
            return new SyncInvoker<RevokeSqlserverDbUserPrivilegeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<RevokeSqlserverDbUserPrivilegeResponse>);
        }
        
        /// <summary>
        /// 收缩数据库日志
        ///
        /// 收缩数据库日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetInstancesDbShrinkResponse SetInstancesDbShrink(SetInstancesDbShrinkRequest setInstancesDbShrinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setInstancesDbShrinkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_shrink", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setInstancesDbShrinkRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetInstancesDbShrinkResponse>(response);
        }

        public SyncInvoker<SetInstancesDbShrinkResponse> SetInstancesDbShrinkInvoker(SetInstancesDbShrinkRequest setInstancesDbShrinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setInstancesDbShrinkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db_shrink", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setInstancesDbShrinkRequest);
            return new SyncInvoker<SetInstancesDbShrinkResponse>(this, "POST", request, JsonUtils.DeSerialize<SetInstancesDbShrinkResponse>);
        }
        
        /// <summary>
        /// 收缩数据库日志
        ///
        /// 收缩数据库日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetInstancesNewDbShrinkResponse SetInstancesNewDbShrink(SetInstancesNewDbShrinkRequest setInstancesNewDbShrinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setInstancesNewDbShrinkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-shrink", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setInstancesNewDbShrinkRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetInstancesNewDbShrinkResponse>(response);
        }

        public SyncInvoker<SetInstancesNewDbShrinkResponse> SetInstancesNewDbShrinkInvoker(SetInstancesNewDbShrinkRequest setInstancesNewDbShrinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setInstancesNewDbShrinkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/db-shrink", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setInstancesNewDbShrinkRequest);
            return new SyncInvoker<SetInstancesNewDbShrinkResponse>(this, "POST", request, JsonUtils.DeSerialize<SetInstancesNewDbShrinkResponse>);
        }
        
        /// <summary>
        /// 查询sql统计列表
        ///
        /// 查询sql统计列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSqlStatisticsResponse ListSqlStatistics(ListSqlStatisticsRequest listSqlStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSqlStatisticsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSqlStatisticsResponse>(response);
        }

        public SyncInvoker<ListSqlStatisticsResponse> ListSqlStatisticsInvoker(ListSqlStatisticsRequest listSqlStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSqlStatisticsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlStatisticsRequest);
            return new SyncInvoker<ListSqlStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSqlStatisticsResponse>);
        }
        
        /// <summary>
        /// sql统计视图重置
        ///
        /// sql统计视图重置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetViewSqlStatisticsResponse ResetViewSqlStatistics(ResetViewSqlStatisticsRequest resetViewSqlStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetViewSqlStatisticsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-statistics/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetViewSqlStatisticsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResetViewSqlStatisticsResponse>(response);
        }

        public SyncInvoker<ResetViewSqlStatisticsResponse> ResetViewSqlStatisticsInvoker(ResetViewSqlStatisticsRequest resetViewSqlStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetViewSqlStatisticsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-statistics/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetViewSqlStatisticsRequest);
            return new SyncInvoker<ResetViewSqlStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetViewSqlStatisticsResponse>);
        }
        
    }
}