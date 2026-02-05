using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ddm.V1.Model;

namespace HuaweiCloud.SDK.Ddm.V1
{
    public partial class DdmClient : Client
    {
        public static ClientBuilder<DdmClient> NewBuilder()
        {
            return new ClientBuilder<DdmClient>();
        }

        
        /// <summary>
        /// 变更内核版本
        ///
        /// 变更内核版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeDatabaseVersionResponse ChangeDatabaseVersion(ChangeDatabaseVersionRequest changeDatabaseVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeDatabaseVersionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database-version/change-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeDatabaseVersionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeDatabaseVersionResponse>(response);
        }

        public SyncInvoker<ChangeDatabaseVersionResponse> ChangeDatabaseVersionInvoker(ChangeDatabaseVersionRequest changeDatabaseVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeDatabaseVersionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database-version/change-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeDatabaseVersionRequest);
            return new SyncInvoker<ChangeDatabaseVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeDatabaseVersionResponse>);
        }
        
        /// <summary>
        /// 创建参数组
        ///
        /// 创建参数组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDdmConfigurationsResponse CreateDdmConfigurations(CreateDdmConfigurationsRequest createDdmConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDdmConfigurationsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDdmConfigurationsResponse>(response);
        }

        public SyncInvoker<CreateDdmConfigurationsResponse> CreateDdmConfigurationsInvoker(CreateDdmConfigurationsRequest createDdmConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDdmConfigurationsRequest);
            return new SyncInvoker<CreateDdmConfigurationsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDdmConfigurationsResponse>);
        }
        
        /// <summary>
        /// 删除参数组
        ///
        /// 删除参数组
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
        /// 查询可变更内核版本
        ///
        /// 查询可变更内核版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDatabaseAvailableVersionsResponse ListDatabaseAvailableVersions(ListDatabaseAvailableVersionsRequest listDatabaseAvailableVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDatabaseAvailableVersionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database-version/available-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseAvailableVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDatabaseAvailableVersionsResponse>(response);
        }

        public SyncInvoker<ListDatabaseAvailableVersionsResponse> ListDatabaseAvailableVersionsInvoker(ListDatabaseAvailableVersionsRequest listDatabaseAvailableVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDatabaseAvailableVersionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database-version/available-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseAvailableVersionsRequest);
            return new SyncInvoker<ListDatabaseAvailableVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabaseAvailableVersionsResponse>);
        }
        
        /// <summary>
        /// 获取参数模板列表
        ///
        /// 获取参数模板列表，包括所有DDM的默认参数模板和用户创建的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDdmConfigurationsResponse ListDdmConfigurations(ListDdmConfigurationsRequest listDdmConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDdmConfigurationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDdmConfigurationsResponse>(response);
        }

        public SyncInvoker<ListDdmConfigurationsResponse> ListDdmConfigurationsInvoker(ListDdmConfigurationsRequest listDdmConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDdmConfigurationsRequest);
            return new SyncInvoker<ListDdmConfigurationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDdmConfigurationsResponse>);
        }
        
        /// <summary>
        /// 修改实例参数
        ///
        /// 修改实例参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyConfigurationResponse ModifyConfiguration(ModifyConfigurationRequest modifyConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyConfigurationResponse>(response);
        }

        public SyncInvoker<ModifyConfigurationResponse> ModifyConfigurationInvoker(ModifyConfigurationRequest modifyConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyConfigurationRequest);
            return new SyncInvoker<ModifyConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyConfigurationResponse>);
        }
        
        /// <summary>
        /// 回滚内核版本
        ///
        /// 回滚内核版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RollBackDatabaseVersionResponse RollBackDatabaseVersion(RollBackDatabaseVersionRequest rollBackDatabaseVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rollBackDatabaseVersionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database-version/rollback-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollBackDatabaseVersionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RollBackDatabaseVersionResponse>(response);
        }

        public SyncInvoker<RollBackDatabaseVersionResponse> RollBackDatabaseVersionInvoker(RollBackDatabaseVersionRequest rollBackDatabaseVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rollBackDatabaseVersionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database-version/rollback-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollBackDatabaseVersionRequest);
            return new SyncInvoker<RollBackDatabaseVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<RollBackDatabaseVersionResponse>);
        }
        
        /// <summary>
        /// 获取指定参数模板的参数
        ///
        /// 获取指定参数模板的参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConfigurationResponse ShowConfiguration(ShowConfigurationRequest showConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigurationResponse>(response);
        }

        public SyncInvoker<ShowConfigurationResponse> ShowConfigurationInvoker(ShowConfigurationRequest showConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationRequest);
            return new SyncInvoker<ShowConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigurationResponse>);
        }
        
        /// <summary>
        /// 内核版本风险提醒
        ///
        /// 内核版本风险提醒
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRiskInfoResponse ShowRiskInfo(ShowRiskInfoRequest showRiskInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRiskInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/show-risk-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRiskInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRiskInfoResponse>(response);
        }

        public SyncInvoker<ShowRiskInfoResponse> ShowRiskInfoInvoker(ShowRiskInfoRequest showRiskInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRiskInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/show-risk-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRiskInfoRequest);
            return new SyncInvoker<ShowRiskInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRiskInfoResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionResponse>(response);
        }

        public SyncInvoker<ListApiVersionResponse> ListApiVersionInvoker(ListApiVersionRequest listApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionRequest);
            return new SyncInvoker<ListApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionResponse>);
        }
        
        /// <summary>
        /// 批量删除实例的节点
        ///
        /// 批量删除实例的节点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteNodesResponse BatchDeleteNodes(BatchDeleteNodesRequest batchDeleteNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteNodesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteNodesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteNodesResponse>(response);
        }

        public SyncInvoker<BatchDeleteNodesResponse> BatchDeleteNodesInvoker(BatchDeleteNodesRequest batchDeleteNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteNodesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteNodesRequest);
            return new SyncInvoker<BatchDeleteNodesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteNodesResponse>);
        }
        
        /// <summary>
        /// 绑定弹性公网IP
        ///
        /// 绑定弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BindEipResponse BindEip(BindEipRequest bindEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(bindEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/eip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", bindEipRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BindEipResponse>(response);
        }

        public SyncInvoker<BindEipResponse> BindEipInvoker(BindEipRequest bindEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(bindEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/eip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", bindEipRequest);
            return new SyncInvoker<BindEipResponse>(this, "POST", request, JsonUtils.DeSerialize<BindEipResponse>);
        }
        
        /// <summary>
        /// 取消分片变更
        ///
        /// 取消分片变更
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelMigrationResponse CancelMigration(CancelMigrationRequest cancelMigrationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cancelMigrationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(cancelMigrationRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            if (StringUtils.TryConvertToNonEmptyString(cancelMigrationRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration/jobs/{job_id}/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelMigrationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<CancelMigrationResponse>(response);
        }

        public SyncInvoker<CancelMigrationResponse> CancelMigrationInvoker(CancelMigrationRequest cancelMigrationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cancelMigrationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(cancelMigrationRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            if (StringUtils.TryConvertToNonEmptyString(cancelMigrationRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration/jobs/{job_id}/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelMigrationRequest);
            return new SyncInvoker<CancelMigrationResponse>(this, "PUT", request, JsonUtils.DeSerialize<CancelMigrationResponse>);
        }
        
        /// <summary>
        /// 修改切换路由策略
        ///
        /// 修改切换路由策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeStrategyResponse ChangeStrategy(ChangeStrategyRequest changeStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeStrategyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(changeStrategyRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            if (StringUtils.TryConvertToNonEmptyString(changeStrategyRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration/jobs/{job_id}/route-switch-strategy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeStrategyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ChangeStrategyResponse>(response);
        }

        public SyncInvoker<ChangeStrategyResponse> ChangeStrategyInvoker(ChangeStrategyRequest changeStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeStrategyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(changeStrategyRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            if (StringUtils.TryConvertToNonEmptyString(changeStrategyRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration/jobs/{job_id}/route-switch-strategy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeStrategyRequest);
            return new SyncInvoker<ChangeStrategyResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeStrategyResponse>);
        }
        
        /// <summary>
        /// 分片变更预校验
        ///
        /// 分片变更预校验
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckMigrateLogicDbResponse CheckMigrateLogicDb(CheckMigrateLogicDbRequest checkMigrateLogicDbRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkMigrateLogicDbRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(checkMigrateLogicDbRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration/precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkMigrateLogicDbRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CheckMigrateLogicDbResponse>(response);
        }

        public SyncInvoker<CheckMigrateLogicDbResponse> CheckMigrateLogicDbInvoker(CheckMigrateLogicDbRequest checkMigrateLogicDbRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkMigrateLogicDbRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(checkMigrateLogicDbRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration/precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkMigrateLogicDbRequest);
            return new SyncInvoker<CheckMigrateLogicDbResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckMigrateLogicDbResponse>);
        }
        
        /// <summary>
        /// 查询分片变更预校验异步结果
        ///
        /// 查询分片变更预校验异步结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckPreliminaryResultsResponse CheckPreliminaryResults(CheckPreliminaryResultsRequest checkPreliminaryResultsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkPreliminaryResultsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(checkPreliminaryResultsRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            if (StringUtils.TryConvertToNonEmptyString(checkPreliminaryResultsRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration/precheck/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkPreliminaryResultsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CheckPreliminaryResultsResponse>(response);
        }

        public SyncInvoker<CheckPreliminaryResultsResponse> CheckPreliminaryResultsInvoker(CheckPreliminaryResultsRequest checkPreliminaryResultsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkPreliminaryResultsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(checkPreliminaryResultsRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            if (StringUtils.TryConvertToNonEmptyString(checkPreliminaryResultsRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration/precheck/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkPreliminaryResultsRequest);
            return new SyncInvoker<CheckPreliminaryResultsResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckPreliminaryResultsResponse>);
        }
        
        /// <summary>
        /// 清理分片变更
        ///
        /// 清理分片变更
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CleanMigrationResponse CleanMigration(CleanMigrationRequest cleanMigrationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cleanMigrationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(cleanMigrationRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            if (StringUtils.TryConvertToNonEmptyString(cleanMigrationRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration/jobs/{job_id}/clean", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cleanMigrationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<CleanMigrationResponse>(response);
        }

        public SyncInvoker<CleanMigrationResponse> CleanMigrationInvoker(CleanMigrationRequest cleanMigrationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cleanMigrationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(cleanMigrationRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            if (StringUtils.TryConvertToNonEmptyString(cleanMigrationRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration/jobs/{job_id}/clean", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cleanMigrationRequest);
            return new SyncInvoker<CleanMigrationResponse>(this, "PUT", request, JsonUtils.DeSerialize<CleanMigrationResponse>);
        }
        
        /// <summary>
        /// 创建DDM逻辑库
        ///
        /// 创建DDM逻辑库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDatabaseResponse CreateDatabase(CreateDatabaseRequest createDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDatabaseResponse>(response);
        }

        public SyncInvoker<CreateDatabaseResponse> CreateDatabaseInvoker(CreateDatabaseRequest createDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseRequest);
            return new SyncInvoker<CreateDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDatabaseResponse>);
        }
        
        /// <summary>
        /// 创建DDM逻辑库
        ///
        /// 创建DDM逻辑库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDdmDatabaseResponse CreateDdmDatabase(CreateDdmDatabaseRequest createDdmDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDdmDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDdmDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDdmDatabaseResponse>(response);
        }

        public SyncInvoker<CreateDdmDatabaseResponse> CreateDdmDatabaseInvoker(CreateDdmDatabaseRequest createDdmDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDdmDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDdmDatabaseRequest);
            return new SyncInvoker<CreateDdmDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDdmDatabaseResponse>);
        }
        
        /// <summary>
        /// 购买创建DDM实例
        ///
        /// 购买创建DDM实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDdmInstanceResponse CreateDdmInstance(CreateDdmInstanceRequest createDdmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDdmInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDdmInstanceResponse>(response);
        }

        public SyncInvoker<CreateDdmInstanceResponse> CreateDdmInstanceInvoker(CreateDdmInstanceRequest createDdmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDdmInstanceRequest);
            return new SyncInvoker<CreateDdmInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDdmInstanceResponse>);
        }
        
        /// <summary>
        /// 创建组
        ///
        /// 创建组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGroupResponse CreateGroup(CreateGroupRequest createGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGroupResponse>(response);
        }

        public SyncInvoker<CreateGroupResponse> CreateGroupInvoker(CreateGroupRequest createGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGroupRequest);
            return new SyncInvoker<CreateGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGroupResponse>);
        }
        
        /// <summary>
        /// 购买DDM实例
        ///
        /// 创建一个DDM实例。
        /// 
        /// DDM运行于虚拟私有云。申请DDM实例前，需保证有可用的虚拟私有云，并且已配置好子网与安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceResponse>(response);
        }

        public SyncInvoker<CreateInstanceResponse> CreateInstanceInvoker(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstanceRequest);
            return new SyncInvoker<CreateInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceResponse>);
        }
        
        /// <summary>
        /// 创建DDM帐号
        ///
        /// DDM帐号用于连接和管理逻辑库。一个DDM实例最多能创建100个DDM帐号，一个DDM帐号可以关联多个逻辑库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateUsersResponse CreateUsers(CreateUsersRequest createUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createUsersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createUsersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateUsersResponse>(response);
        }

        public SyncInvoker<CreateUsersResponse> CreateUsersInvoker(CreateUsersRequest createUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createUsersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createUsersRequest);
            return new SyncInvoker<CreateUsersResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUsersResponse>);
        }
        
        /// <summary>
        /// 删除备份
        ///
        /// 删除备份
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBackupResponse DeleteBackup(DeleteBackupRequest deleteBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBackupRequest.BackupId, out var valueOfBackupId)) urlParam.Add("backup_id", valueOfBackupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteBackupResponse>(response);
        }

        public SyncInvoker<DeleteBackupResponse> DeleteBackupInvoker(DeleteBackupRequest deleteBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBackupRequest.BackupId, out var valueOfBackupId)) urlParam.Add("backup_id", valueOfBackupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackupRequest);
            return new SyncInvoker<DeleteBackupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteBackupResponse>);
        }
        
        /// <summary>
        /// 删除DDM逻辑库
        ///
        /// 删除指定的逻辑库，释放该逻辑库的所有资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDatabaseResponse DeleteDatabase(DeleteDatabaseRequest deleteDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDatabaseRequest.DdmDbname, out var valueOfDdmDbname)) urlParam.Add("ddm_dbname", valueOfDdmDbname);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/databases/{ddm_dbname}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDatabaseResponse>(response);
        }

        public SyncInvoker<DeleteDatabaseResponse> DeleteDatabaseInvoker(DeleteDatabaseRequest deleteDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDatabaseRequest.DdmDbname, out var valueOfDdmDbname)) urlParam.Add("ddm_dbname", valueOfDdmDbname);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/databases/{ddm_dbname}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseRequest);
            return new SyncInvoker<DeleteDatabaseResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDatabaseResponse>);
        }
        
        /// <summary>
        /// 删除逻辑库
        ///
        /// 删除指定的逻辑库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDdmDatabaseResponse DeleteDdmDatabase(DeleteDdmDatabaseRequest deleteDdmDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDdmDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDdmDatabaseRequest.DatabaseName, out var valueOfDatabaseName)) urlParam.Add("database_name", valueOfDatabaseName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDdmDatabaseRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDdmDatabaseResponse>(response);
        }

        public SyncInvoker<DeleteDdmDatabaseResponse> DeleteDdmDatabaseInvoker(DeleteDdmDatabaseRequest deleteDdmDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDdmDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDdmDatabaseRequest.DatabaseName, out var valueOfDatabaseName)) urlParam.Add("database_name", valueOfDatabaseName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDdmDatabaseRequest);
            return new SyncInvoker<DeleteDdmDatabaseResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDdmDatabaseResponse>);
        }
        
        /// <summary>
        /// 删除DDM实例
        ///
        /// 删除指定的DDM实例，释放该实例的所有资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDdmInstanceResponse DeleteDdmInstance(DeleteDdmInstanceRequest deleteDdmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDdmInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDdmInstanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDdmInstanceResponse>(response);
        }

        public SyncInvoker<DeleteDdmInstanceResponse> DeleteDdmInstanceInvoker(DeleteDdmInstanceRequest deleteDdmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDdmInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDdmInstanceRequest);
            return new SyncInvoker<DeleteDdmInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDdmInstanceResponse>);
        }
        
        /// <summary>
        /// 删除实例组
        ///
        /// 删除实例组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGroupResponse DeleteGroup(DeleteGroupRequest deleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteGroupResponse>(response);
        }

        public SyncInvoker<DeleteGroupResponse> DeleteGroupInvoker(DeleteGroupRequest deleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupRequest);
            return new SyncInvoker<DeleteGroupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteGroupResponse>);
        }
        
        /// <summary>
        /// 删除DDM实例
        ///
        /// 删除指定的DDM实例，释放该实例的所有资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInstanceResponse>(response);
        }

        public SyncInvoker<DeleteInstanceResponse> DeleteInstanceInvoker(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            return new SyncInvoker<DeleteInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteInstanceResponse>);
        }
        
        /// <summary>
        /// 删除实例的节点
        ///
        /// 删除实例的节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteNodesResponse DeleteNodes(DeleteNodesRequest deleteNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNodesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteNodesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteNodesResponse>(response);
        }

        public SyncInvoker<DeleteNodesResponse> DeleteNodesInvoker(DeleteNodesRequest deleteNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNodesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteNodesRequest);
            return new SyncInvoker<DeleteNodesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteNodesResponse>);
        }
        
        /// <summary>
        /// 删除DDM帐号
        ///
        /// 删除指定的DDM实例帐号，如果帐号关联了逻辑库，则对应的关联关系也会删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteUserResponse DeleteUser(DeleteUserRequest deleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRequest.Username, out var valueOfUsername)) urlParam.Add("username", valueOfUsername);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/users/{username}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteUserResponse>(response);
        }

        public SyncInvoker<DeleteUserResponse> DeleteUserInvoker(DeleteUserRequest deleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRequest.Username, out var valueOfUsername)) urlParam.Add("username", valueOfUsername);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/users/{username}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            return new SyncInvoker<DeleteUserResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteUserResponse>);
        }
        
        /// <summary>
        /// 导出逻辑库元数据
        ///
        /// 导出所有逻辑库物理分片在数据节点上的分布关系
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadSchemaMetadataResponse DownloadSchemaMetadata(DownloadSchemaMetadataRequest downloadSchemaMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadSchemaMetadataRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema-metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSchemaMetadataRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadSchemaMetadataResponse>(response);
        }

        public SyncInvoker<DownloadSchemaMetadataResponse> DownloadSchemaMetadataInvoker(DownloadSchemaMetadataRequest downloadSchemaMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadSchemaMetadataRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema-metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSchemaMetadataRequest);
            return new SyncInvoker<DownloadSchemaMetadataResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadSchemaMetadataResponse>);
        }
        
        /// <summary>
        /// kill逻辑会话
        ///
        /// kill逻辑会话
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteKillLogicalProcessesResponse ExecuteKillLogicalProcesses(ExecuteKillLogicalProcessesRequest executeKillLogicalProcessesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeKillLogicalProcessesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/logical-processes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeKillLogicalProcessesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<ExecuteKillLogicalProcessesResponse>(response);
        }

        public SyncInvoker<ExecuteKillLogicalProcessesResponse> ExecuteKillLogicalProcessesInvoker(ExecuteKillLogicalProcessesRequest executeKillLogicalProcessesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeKillLogicalProcessesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/logical-processes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeKillLogicalProcessesRequest);
            return new SyncInvoker<ExecuteKillLogicalProcessesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<ExecuteKillLogicalProcessesResponse>);
        }
        
        /// <summary>
        /// kill物理会话
        ///
        /// kill物理会话
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteKillPhysicalProcessesResponse ExecuteKillPhysicalProcesses(ExecuteKillPhysicalProcessesRequest executeKillPhysicalProcessesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeKillPhysicalProcessesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/physical-processes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeKillPhysicalProcessesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<ExecuteKillPhysicalProcessesResponse>(response);
        }

        public SyncInvoker<ExecuteKillPhysicalProcessesResponse> ExecuteKillPhysicalProcessesInvoker(ExecuteKillPhysicalProcessesRequest executeKillPhysicalProcessesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeKillPhysicalProcessesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/physical-processes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeKillPhysicalProcessesRequest);
            return new SyncInvoker<ExecuteKillPhysicalProcessesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<ExecuteKillPhysicalProcessesResponse>);
        }
        
        /// <summary>
        /// DDM实例节点扩容
        ///
        /// 对指定的DDM实例的节点个数进行扩容，支持按需实例与包周期实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExpandDdmInstanceNodesResponse ExpandDdmInstanceNodes(ExpandDdmInstanceNodesRequest expandDdmInstanceNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(expandDdmInstanceNodesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", expandDdmInstanceNodesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExpandDdmInstanceNodesResponse>(response);
        }

        public SyncInvoker<ExpandDdmInstanceNodesResponse> ExpandDdmInstanceNodesInvoker(ExpandDdmInstanceNodesRequest expandDdmInstanceNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(expandDdmInstanceNodesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", expandDdmInstanceNodesRequest);
            return new SyncInvoker<ExpandDdmInstanceNodesResponse>(this, "POST", request, JsonUtils.DeSerialize<ExpandDdmInstanceNodesResponse>);
        }
        
        /// <summary>
        /// DDM实例节点扩容
        ///
        /// 对指定的DDM实例的节点个数进行扩容，支持按需实例与包周期实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExpandInstanceNodesResponse ExpandInstanceNodes(ExpandInstanceNodesRequest expandInstanceNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(expandInstanceNodesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/action/enlarge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", expandInstanceNodesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExpandInstanceNodesResponse>(response);
        }

        public SyncInvoker<ExpandInstanceNodesResponse> ExpandInstanceNodesInvoker(ExpandInstanceNodesRequest expandInstanceNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(expandInstanceNodesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/action/enlarge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", expandInstanceNodesRequest);
            return new SyncInvoker<ExpandInstanceNodesResponse>(this, "POST", request, JsonUtils.DeSerialize<ExpandInstanceNodesResponse>);
        }
        
        /// <summary>
        /// 查询创建逻辑库可选取的数据节点实例列表
        ///
        /// 查询创建逻辑库可选取的数据节点实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAvailableRdsResponse ListAvailableRds(ListAvailableRdsRequest listAvailableRdsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAvailableRdsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/available-data-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableRdsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAvailableRdsResponse>(response);
        }

        public SyncInvoker<ListAvailableRdsResponse> ListAvailableRdsInvoker(ListAvailableRdsRequest listAvailableRdsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAvailableRdsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/available-data-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableRdsRequest);
            return new SyncInvoker<ListAvailableRdsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailableRdsResponse>);
        }
        
        /// <summary>
        /// 查询分片变更可选取的数据节点实例列表
        ///
        /// 查询分片变更可选取的数据节点实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAvailableRdsForMigrateResponse ListAvailableRdsForMigrate(ListAvailableRdsForMigrateRequest listAvailableRdsForMigrateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAvailableRdsForMigrateRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listAvailableRdsForMigrateRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration/available-data-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableRdsForMigrateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAvailableRdsForMigrateResponse>(response);
        }

        public SyncInvoker<ListAvailableRdsForMigrateResponse> ListAvailableRdsForMigrateInvoker(ListAvailableRdsForMigrateRequest listAvailableRdsForMigrateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAvailableRdsForMigrateRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listAvailableRdsForMigrateRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration/available-data-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableRdsForMigrateRequest);
            return new SyncInvoker<ListAvailableRdsForMigrateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailableRdsForMigrateResponse>);
        }
        
        /// <summary>
        /// 查询创建逻辑库可选取的数据库实例列表
        ///
        /// 查询创建逻辑库可选取的数据库实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAvailableRdsListResponse ListAvailableRdsList(ListAvailableRdsListRequest listAvailableRdsListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAvailableRdsListRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableRdsListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAvailableRdsListResponse>(response);
        }

        public SyncInvoker<ListAvailableRdsListResponse> ListAvailableRdsListInvoker(ListAvailableRdsListRequest listAvailableRdsListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAvailableRdsListRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableRdsListRequest);
            return new SyncInvoker<ListAvailableRdsListResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailableRdsListResponse>);
        }
        
        /// <summary>
        /// 获取备份列表
        ///
        /// 获取备份列表
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
        /// 查询DDM逻辑库列表
        ///
        /// 查询DDM逻辑库列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDatabasesResponse ListDatabases(ListDatabasesRequest listDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDatabasesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabasesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDatabasesResponse>(response);
        }

        public SyncInvoker<ListDatabasesResponse> ListDatabasesInvoker(ListDatabasesRequest listDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDatabasesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabasesRequest);
            return new SyncInvoker<ListDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabasesResponse>);
        }
        
        /// <summary>
        /// 查询DDM引擎信息
        ///
        /// 查询DDM引擎信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDdmEnginesResponse ListDdmEngines(ListDdmEnginesRequest listDdmEnginesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/engines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDdmEnginesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDdmEnginesResponse>(response);
        }

        public SyncInvoker<ListDdmEnginesResponse> ListDdmEnginesInvoker(ListDdmEnginesRequest listDdmEnginesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/engines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDdmEnginesRequest);
            return new SyncInvoker<ListDdmEnginesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDdmEnginesResponse>);
        }
        
        /// <summary>
        /// 查询DDM可用区规格信息
        ///
        /// 查询DDM可用区规格信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDdmFlavorsResponse ListDdmFlavors(ListDdmFlavorsRequest listDdmFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDdmFlavorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDdmFlavorsResponse>(response);
        }

        public SyncInvoker<ListDdmFlavorsResponse> ListDdmFlavorsInvoker(ListDdmFlavorsRequest listDdmFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDdmFlavorsRequest);
            return new SyncInvoker<ListDdmFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDdmFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询实例列表
        ///
        /// 查询实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDdmsResponse ListDdms(ListDdmsRequest listDdmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDdmsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDdmsResponse>(response);
        }

        public SyncInvoker<ListDdmsResponse> ListDdmsInvoker(ListDdmsRequest listDdmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDdmsRequest);
            return new SyncInvoker<ListDdmsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDdmsResponse>);
        }
        
        /// <summary>
        /// 查询DDM引擎信息
        ///
        /// 查询DDM引擎信息详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEnginesResponse ListEngines(ListEnginesRequest listEnginesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/engines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnginesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEnginesResponse>(response);
        }

        public SyncInvoker<ListEnginesResponse> ListEnginesInvoker(ListEnginesRequest listEnginesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/engines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnginesRequest);
            return new SyncInvoker<ListEnginesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEnginesResponse>);
        }
        
        /// <summary>
        /// 查询DDM可用区规格信息
        ///
        /// 查询DDM可用区规格信息详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFlavorsResponse ListFlavors(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }

        public SyncInvoker<ListFlavorsResponse> ListFlavorsInvoker(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            return new SyncInvoker<ListFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorsResponse>);
        }
        
        /// <summary>
        /// 获取实例组信息列表
        ///
        /// 获取实例组信息列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupResponse ListGroup(ListGroupRequest listGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGroupResponse>(response);
        }

        public SyncInvoker<ListGroupResponse> ListGroupInvoker(ListGroupRequest listGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupRequest);
            return new SyncInvoker<ListGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupResponse>);
        }
        
        /// <summary>
        /// 查询DDM实例列表
        ///
        /// 查询DDM实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstancesResponse ListInstances(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesResponse>(response);
        }

        public SyncInvoker<ListInstancesResponse> ListInstancesInvoker(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            return new SyncInvoker<ListInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesResponse>);
        }
        
        /// <summary>
        /// 查询DDM实例节点列表
        ///
        /// 查询DDM实例节点列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNodesResponse ListNodes(ListNodesRequest listNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNodesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNodesResponse>(response);
        }

        public SyncInvoker<ListNodesResponse> ListNodesInvoker(ListNodesRequest listNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNodesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodesRequest);
            return new SyncInvoker<ListNodesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNodesResponse>);
        }
        
        /// <summary>
        /// 读写比例监控
        ///
        /// 查询指定时间段内在DDM实例的读写次数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListReadWriteRatioResponse ListReadWriteRatio(ListReadWriteRatioRequest listReadWriteRatioRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listReadWriteRatioRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/read-write-ratio", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReadWriteRatioRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListReadWriteRatioResponse>(response);
        }

        public SyncInvoker<ListReadWriteRatioResponse> ListReadWriteRatioInvoker(ListReadWriteRatioRequest listReadWriteRatioRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listReadWriteRatioRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/read-write-ratio", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReadWriteRatioRequest);
            return new SyncInvoker<ListReadWriteRatioResponse>(this, "GET", request, JsonUtils.DeSerialize<ListReadWriteRatioResponse>);
        }
        
        /// <summary>
        /// 慢日志监控
        ///
        /// 查询指定时间段内在DDM实例上执行过的慢sql相关信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSlowLogResponse ListSlowLog(ListSlowLogRequest listSlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowLogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSlowLogResponse>(response);
        }

        public SyncInvoker<ListSlowLogResponse> ListSlowLogInvoker(ListSlowLogRequest listSlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowLogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogRequest);
            return new SyncInvoker<ListSlowLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSlowLogResponse>);
        }
        
        /// <summary>
        /// 查询慢日志
        ///
        /// 查询慢日志V3
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSlowLogAnalysisResponse ListSlowLogAnalysis(ListSlowLogAnalysisRequest listSlowLogAnalysisRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowLogAnalysisRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-log-analysis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogAnalysisRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSlowLogAnalysisResponse>(response);
        }

        public SyncInvoker<ListSlowLogAnalysisResponse> ListSlowLogAnalysisInvoker(ListSlowLogAnalysisRequest listSlowLogAnalysisRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowLogAnalysisRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-log-analysis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogAnalysisRequest);
            return new SyncInvoker<ListSlowLogAnalysisResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSlowLogAnalysisResponse>);
        }
        
        /// <summary>
        /// 慢日志监控
        ///
        /// 查询指定时间段内在DDM实例上执行过的慢sql相关信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSlowLogsResponse ListSlowLogs(ListSlowLogsRequest listSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowLogsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSlowLogsResponse>(response);
        }

        public SyncInvoker<ListSlowLogsResponse> ListSlowLogsInvoker(ListSlowLogsRequest listSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowLogsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsRequest);
            return new SyncInvoker<ListSlowLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSlowLogsResponse>);
        }
        
        /// <summary>
        /// 查询任务列表
        ///
        /// 查询任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTasksResponse ListTasks(ListTasksRequest listTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTasksResponse>(response);
        }

        public SyncInvoker<ListTasksResponse> ListTasksInvoker(ListTasksRequest listTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTasksRequest);
            return new SyncInvoker<ListTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTasksResponse>);
        }
        
        /// <summary>
        /// 查询DDM帐号列表
        ///
        /// 查询DDM帐号列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUsersResponse ListUsers(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUsersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUsersResponse>(response);
        }

        public SyncInvoker<ListUsersResponse> ListUsersInvoker(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUsersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            return new SyncInvoker<ListUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsersResponse>);
        }
        
        /// <summary>
        /// 分片变更
        ///
        /// 分片变更
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public MigrateLogicDbResponse MigrateLogicDb(MigrateLogicDbRequest migrateLogicDbRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(migrateLogicDbRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(migrateLogicDbRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateLogicDbRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<MigrateLogicDbResponse>(response);
        }

        public SyncInvoker<MigrateLogicDbResponse> MigrateLogicDbInvoker(MigrateLogicDbRequest migrateLogicDbRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(migrateLogicDbRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(migrateLogicDbRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateLogicDbRequest);
            return new SyncInvoker<MigrateLogicDbResponse>(this, "POST", request, JsonUtils.DeSerialize<MigrateLogicDbResponse>);
        }
        
        /// <summary>
        /// 查询分片变更任务详情
        ///
        /// 查询分片变更任务详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public MigrateResultsResponse MigrateResults(MigrateResultsRequest migrateResultsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(migrateResultsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(migrateResultsRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            if (StringUtils.TryConvertToNonEmptyString(migrateResultsRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateResultsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<MigrateResultsResponse>(response);
        }

        public SyncInvoker<MigrateResultsResponse> MigrateResultsInvoker(MigrateResultsRequest migrateResultsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(migrateResultsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(migrateResultsRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            if (StringUtils.TryConvertToNonEmptyString(migrateResultsRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateResultsRequest);
            return new SyncInvoker<MigrateResultsResponse>(this, "GET", request, JsonUtils.DeSerialize<MigrateResultsResponse>);
        }
        
        /// <summary>
        /// 修改实例的ELB IP
        ///
        /// 修改实例的ELB IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyEipResponse ModifyEip(ModifyEipRequest modifyEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/elb/ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyEipRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyEipResponse>(response);
        }

        public SyncInvoker<ModifyEipResponse> ModifyEipInvoker(ModifyEipRequest modifyEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/elb/ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyEipRequest);
            return new SyncInvoker<ModifyEipResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyEipResponse>);
        }
        
        /// <summary>
        /// DDM表数据重载
        ///
        /// DDM实例跨region容灾场景下，针对目标DDM实例实现表数据reload，使数据同步。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RebuildConfigResponse RebuildConfig(RebuildConfigRequest rebuildConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rebuildConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/reload-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebuildConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RebuildConfigResponse>(response);
        }

        public SyncInvoker<RebuildConfigResponse> RebuildConfigInvoker(RebuildConfigRequest rebuildConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rebuildConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/reload-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebuildConfigRequest);
            return new SyncInvoker<RebuildConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RebuildConfigResponse>);
        }
        
        /// <summary>
        /// DDM管理员账号密码管理
        ///
        /// 首次调用时新建DDM管理员帐号并设置密码。后续调用时仅更新管理员密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetAdministratorResponse ResetAdministrator(ResetAdministratorRequest resetAdministratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetAdministratorRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/admin-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetAdministratorRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetAdministratorResponse>(response);
        }

        public SyncInvoker<ResetAdministratorResponse> ResetAdministratorInvoker(ResetAdministratorRequest resetAdministratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetAdministratorRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/admin-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetAdministratorRequest);
            return new SyncInvoker<ResetAdministratorResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetAdministratorResponse>);
        }
        
        /// <summary>
        /// 重置DDM账号密码
        ///
        /// 重置现有DDM帐号的密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetUserPasswordResponse ResetUserPassword(ResetUserPasswordRequest resetUserPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetUserPasswordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(resetUserPasswordRequest.Username, out var valueOfUsername)) urlParam.Add("username", valueOfUsername);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{username}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetUserPasswordRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResetUserPasswordResponse>(response);
        }

        public SyncInvoker<ResetUserPasswordResponse> ResetUserPasswordInvoker(ResetUserPasswordRequest resetUserPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetUserPasswordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(resetUserPasswordRequest.Username, out var valueOfUsername)) urlParam.Add("username", valueOfUsername);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{username}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetUserPasswordRequest);
            return new SyncInvoker<ResetUserPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetUserPasswordResponse>);
        }
        
        /// <summary>
        /// 变更DDM实例规格
        ///
        /// 变更DDM实例规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResizeFlavorResponse ResizeFlavor(ResizeFlavorRequest resizeFlavorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resizeFlavorRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/flavor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeFlavorRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ResizeFlavorResponse>(response);
        }

        public SyncInvoker<ResizeFlavorResponse> ResizeFlavorInvoker(ResizeFlavorRequest resizeFlavorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resizeFlavorRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/flavor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeFlavorRequest);
            return new SyncInvoker<ResizeFlavorResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResizeFlavorResponse>);
        }
        
        /// <summary>
        /// 重启DDM实例
        ///
        /// 重启DDM实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestartDdmInstanceResponse RestartDdmInstance(RestartDdmInstanceRequest restartDdmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restartDdmInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartDdmInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestartDdmInstanceResponse>(response);
        }

        public SyncInvoker<RestartDdmInstanceResponse> RestartDdmInstanceInvoker(RestartDdmInstanceRequest restartDdmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restartDdmInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartDdmInstanceRequest);
            return new SyncInvoker<RestartDdmInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestartDdmInstanceResponse>);
        }
        
        /// <summary>
        /// 重启DDM实例
        ///
        /// 重启指定的DDM实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestartInstanceResponse RestartInstance(RestartInstanceRequest restartInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restartInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restartInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestartInstanceResponse>(response);
        }

        public SyncInvoker<RestartInstanceResponse> RestartInstanceInvoker(RestartInstanceRequest restartInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restartInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restartInstanceRequest);
            return new SyncInvoker<RestartInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestartInstanceResponse>);
        }
        
        /// <summary>
        /// 重启DDM节点
        ///
        /// 重启DDM节点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestartNodeResponse RestartNode(RestartNodeRequest restartNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restartNodeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(restartNodeRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartNodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestartNodeResponse>(response);
        }

        public SyncInvoker<RestartNodeResponse> RestartNodeInvoker(RestartNodeRequest restartNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restartNodeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(restartNodeRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartNodeRequest);
            return new SyncInvoker<RestartNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<RestartNodeResponse>);
        }
        
        /// <summary>
        /// 恢复到新实例
        ///
        /// 恢复到新实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public Restore2ExistResponse Restore2Exist(Restore2ExistRequest restore2ExistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restore2ExistRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restore2ExistRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<Restore2ExistResponse>(response);
        }

        public SyncInvoker<Restore2ExistResponse> Restore2ExistInvoker(Restore2ExistRequest restore2ExistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restore2ExistRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restore2ExistRequest);
            return new SyncInvoker<Restore2ExistResponse>(this, "POST", request, JsonUtils.DeSerialize<Restore2ExistResponse>);
        }
        
        /// <summary>
        /// 元数据恢复
        ///
        /// 元数据恢复
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreMetadataResponse RestoreMetadata(RestoreMetadataRequest restoreMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreMetadataRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/metadata-recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreMetadataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestoreMetadataResponse>(response);
        }

        public SyncInvoker<RestoreMetadataResponse> RestoreMetadataInvoker(RestoreMetadataRequest restoreMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreMetadataRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/metadata-recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreMetadataRequest);
            return new SyncInvoker<RestoreMetadataResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreMetadataResponse>);
        }
        
        /// <summary>
        /// 重试分片变更
        ///
        /// 重试分片变更
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RetryMigrationResponse RetryMigration(RetryMigrationRequest retryMigrationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryMigrationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(retryMigrationRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            if (StringUtils.TryConvertToNonEmptyString(retryMigrationRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration/jobs/{job_id}/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryMigrationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<RetryMigrationResponse>(response);
        }

        public SyncInvoker<RetryMigrationResponse> RetryMigrationInvoker(RetryMigrationRequest retryMigrationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryMigrationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(retryMigrationRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            if (StringUtils.TryConvertToNonEmptyString(retryMigrationRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration/jobs/{job_id}/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryMigrationRequest);
            return new SyncInvoker<RetryMigrationResponse>(this, "PUT", request, JsonUtils.DeSerialize<RetryMigrationResponse>);
        }
        
        /// <summary>
        /// 回滚分片变更
        ///
        /// 回滚分片变更
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RollbackMigrationResponse RollbackMigration(RollbackMigrationRequest rollbackMigrationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rollbackMigrationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(rollbackMigrationRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            if (StringUtils.TryConvertToNonEmptyString(rollbackMigrationRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration/jobs/{job_id}/rollback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollbackMigrationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<RollbackMigrationResponse>(response);
        }

        public SyncInvoker<RollbackMigrationResponse> RollbackMigrationInvoker(RollbackMigrationRequest rollbackMigrationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rollbackMigrationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(rollbackMigrationRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            if (StringUtils.TryConvertToNonEmptyString(rollbackMigrationRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration/jobs/{job_id}/rollback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollbackMigrationRequest);
            return new SyncInvoker<RollbackMigrationResponse>(this, "PUT", request, JsonUtils.DeSerialize<RollbackMigrationResponse>);
        }
        
        /// <summary>
        /// 查询可用于恢复的实例列表
        ///
        /// 查询可用于恢复的实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAvalibleDdmsResponse ShowAvalibleDdms(ShowAvalibleDdmsRequest showAvalibleDdmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAvalibleDdmsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/restorable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvalibleDdmsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAvalibleDdmsResponse>(response);
        }

        public SyncInvoker<ShowAvalibleDdmsResponse> ShowAvalibleDdmsInvoker(ShowAvalibleDdmsRequest showAvalibleDdmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAvalibleDdmsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/restorable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvalibleDdmsRequest);
            return new SyncInvoker<ShowAvalibleDdmsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAvalibleDdmsResponse>);
        }
        
        /// <summary>
        /// 查询可用于时间点恢复的数据节点列表
        ///
        /// 查询可用于时间点恢复的数据节点列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAvalibleRdsResponse ShowAvalibleRds(ShowAvalibleRdsRequest showAvalibleRdsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAvalibleRdsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/restorable-data-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvalibleRdsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAvalibleRdsResponse>(response);
        }

        public SyncInvoker<ShowAvalibleRdsResponse> ShowAvalibleRdsInvoker(ShowAvalibleRdsRequest showAvalibleRdsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAvalibleRdsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/restorable-data-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvalibleRdsRequest);
            return new SyncInvoker<ShowAvalibleRdsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAvalibleRdsResponse>);
        }
        
        /// <summary>
        /// 查询可恢复时间段
        ///
        /// 查询可恢复时间段
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAvalibleTimeResponse ShowAvalibleTime(ShowAvalibleTimeRequest showAvalibleTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAvalibleTimeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/restorable-time-interval", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvalibleTimeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAvalibleTimeResponse>(response);
        }

        public SyncInvoker<ShowAvalibleTimeResponse> ShowAvalibleTimeInvoker(ShowAvalibleTimeRequest showAvalibleTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAvalibleTimeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/restorable-time-interval", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvalibleTimeRequest);
            return new SyncInvoker<ShowAvalibleTimeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAvalibleTimeResponse>);
        }
        
        /// <summary>
        /// 查询备份详情
        ///
        /// 查询备份详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBackupResponse ShowBackup(ShowBackupRequest showBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBackupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showBackupRequest.BackupId, out var valueOfBackupId)) urlParam.Add("backup_id", valueOfBackupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBackupResponse>(response);
        }

        public SyncInvoker<ShowBackupResponse> ShowBackupInvoker(ShowBackupRequest showBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBackupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showBackupRequest.BackupId, out var valueOfBackupId)) urlParam.Add("backup_id", valueOfBackupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupRequest);
            return new SyncInvoker<ShowBackupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackupResponse>);
        }
        
        /// <summary>
        /// 查询DDM逻辑库详细信息
        ///
        /// 查询指定逻辑库的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDatabaseResponse ShowDatabase(ShowDatabaseRequest showDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showDatabaseRequest.DdmDbname, out var valueOfDdmDbname)) urlParam.Add("ddm_dbname", valueOfDdmDbname);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/databases/{ddm_dbname}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDatabaseRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDatabaseResponse>(response);
        }

        public SyncInvoker<ShowDatabaseResponse> ShowDatabaseInvoker(ShowDatabaseRequest showDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showDatabaseRequest.DdmDbname, out var valueOfDdmDbname)) urlParam.Add("ddm_dbname", valueOfDdmDbname);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/databases/{ddm_dbname}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDatabaseRequest);
            return new SyncInvoker<ShowDatabaseResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDatabaseResponse>);
        }
        
        /// <summary>
        /// 获取指定ID的任务信息
        ///
        /// 获取指定ID的任务信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDdmJobResultResponse ShowDdmJobResult(ShowDdmJobResultRequest showDdmJobResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDdmJobResultRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDdmJobResultRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDdmJobResultResponse>(response);
        }

        public SyncInvoker<ShowDdmJobResultResponse> ShowDdmJobResultInvoker(ShowDdmJobResultRequest showDdmJobResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDdmJobResultRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDdmJobResultRequest);
            return new SyncInvoker<ShowDdmJobResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDdmJobResultResponse>);
        }
        
        /// <summary>
        /// 查询DDM实例节点详情
        ///
        /// 查询DDM实例节点详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDdmNodeDetailResponse ShowDdmNodeDetail(ShowDdmNodeDetailRequest showDdmNodeDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDdmNodeDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showDdmNodeDetailRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDdmNodeDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDdmNodeDetailResponse>(response);
        }

        public SyncInvoker<ShowDdmNodeDetailResponse> ShowDdmNodeDetailInvoker(ShowDdmNodeDetailRequest showDdmNodeDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDdmNodeDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showDdmNodeDetailRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDdmNodeDetailRequest);
            return new SyncInvoker<ShowDdmNodeDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDdmNodeDetailResponse>);
        }
        
        /// <summary>
        /// 查询DDM实例详情
        ///
        /// 查询指定DDM实例的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceResponse ShowInstance(ShowInstanceRequest showInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceResponse>(response);
        }

        public SyncInvoker<ShowInstanceResponse> ShowInstanceInvoker(ShowInstanceRequest showInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            return new SyncInvoker<ShowInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceResponse>);
        }
        
        /// <summary>
        /// 查询逻辑库详情
        ///
        /// 查询逻辑库详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceDatabaseResponse ShowInstanceDatabase(ShowInstanceDatabaseRequest showInstanceDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceDatabaseRequest.DatabaseName, out var valueOfDatabaseName)) urlParam.Add("database_name", valueOfDatabaseName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceDatabaseRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceDatabaseResponse>(response);
        }

        public SyncInvoker<ShowInstanceDatabaseResponse> ShowInstanceDatabaseInvoker(ShowInstanceDatabaseRequest showInstanceDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceDatabaseRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceDatabaseRequest.DatabaseName, out var valueOfDatabaseName)) urlParam.Add("database_name", valueOfDatabaseName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceDatabaseRequest);
            return new SyncInvoker<ShowInstanceDatabaseResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceDatabaseResponse>);
        }
        
        /// <summary>
        /// 查询DDM指定实例的参数详情
        ///
        /// 查询DDM指定实例的参数详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceParamResponse ShowInstanceParam(ShowInstanceParamRequest showInstanceParamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceParamRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceParamRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceParamResponse>(response);
        }

        public SyncInvoker<ShowInstanceParamResponse> ShowInstanceParamInvoker(ShowInstanceParamRequest showInstanceParamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceParamRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceParamRequest);
            return new SyncInvoker<ShowInstanceParamResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceParamResponse>);
        }
        
        /// <summary>
        /// 查询访问控制组
        ///
        /// 查询访问控制组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowIpGroupResponse ShowIpGroup(ShowIpGroupRequest showIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIpGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showIpGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/groups/{group_id}/acls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowIpGroupResponse>(response);
        }

        public SyncInvoker<ShowIpGroupResponse> ShowIpGroupInvoker(ShowIpGroupRequest showIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIpGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showIpGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/groups/{group_id}/acls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpGroupRequest);
            return new SyncInvoker<ShowIpGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIpGroupResponse>);
        }
        
        /// <summary>
        /// 查询逻辑会话列表
        ///
        /// 查询逻辑会话列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLogicalProcessesResponse ShowLogicalProcesses(ShowLogicalProcessesRequest showLogicalProcessesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLogicalProcessesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/logical-processes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogicalProcessesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLogicalProcessesResponse>(response);
        }

        public SyncInvoker<ShowLogicalProcessesResponse> ShowLogicalProcessesInvoker(ShowLogicalProcessesRequest showLogicalProcessesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLogicalProcessesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/logical-processes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogicalProcessesRequest);
            return new SyncInvoker<ShowLogicalProcessesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLogicalProcessesResponse>);
        }
        
        /// <summary>
        /// 查询分片变更的日志
        ///
        /// 查询分片变更的日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMigrationLogResponse ShowMigrationLog(ShowMigrationLogRequest showMigrationLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMigrationLogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showMigrationLogRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/task/{task_id}/run-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMigrationLogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMigrationLogResponse>(response);
        }

        public SyncInvoker<ShowMigrationLogResponse> ShowMigrationLogInvoker(ShowMigrationLogRequest showMigrationLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMigrationLogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showMigrationLogRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/task/{task_id}/run-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMigrationLogRequest);
            return new SyncInvoker<ShowMigrationLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMigrationLogResponse>);
        }
        
        /// <summary>
        /// 查询DDM实例节点详情
        ///
        /// 查询DDM实例节点详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowNodeResponse ShowNode(ShowNodeRequest showNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNodeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showNodeRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowNodeResponse>(response);
        }

        public SyncInvoker<ShowNodeResponse> ShowNodeInvoker(ShowNodeRequest showNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNodeRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showNodeRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodeRequest);
            return new SyncInvoker<ShowNodeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNodeResponse>);
        }
        
        /// <summary>
        /// 查询物理会话列表
        ///
        /// 查询物理会话列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPhysicalProcessesResponse ShowPhysicalProcesses(ShowPhysicalProcessesRequest showPhysicalProcessesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPhysicalProcessesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/physical-processes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPhysicalProcessesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPhysicalProcessesResponse>(response);
        }

        public SyncInvoker<ShowPhysicalProcessesResponse> ShowPhysicalProcessesInvoker(ShowPhysicalProcessesRequest showPhysicalProcessesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPhysicalProcessesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/physical-processes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPhysicalProcessesRequest);
            return new SyncInvoker<ShowPhysicalProcessesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPhysicalProcessesResponse>);
        }
        
        /// <summary>
        /// 查询kill会话审计日志
        ///
        /// 查询kill会话审计日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProcessesAuditLogResponse ShowProcessesAuditLog(ShowProcessesAuditLogRequest showProcessesAuditLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProcessesAuditLogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/processes-audit-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProcessesAuditLogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProcessesAuditLogResponse>(response);
        }

        public SyncInvoker<ShowProcessesAuditLogResponse> ShowProcessesAuditLogInvoker(ShowProcessesAuditLogRequest showProcessesAuditLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProcessesAuditLogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/processes-audit-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProcessesAuditLogRequest);
            return new SyncInvoker<ShowProcessesAuditLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProcessesAuditLogResponse>);
        }
        
        /// <summary>
        /// 获取DDM实例绑定的弹性公网IP信息
        ///
        /// 获取DDM实例绑定的弹性公网IP信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPublicIpResponse ShowPublicIp(ShowPublicIpRequest showPublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublicIpRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicIpRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPublicIpResponse>(response);
        }

        public SyncInvoker<ShowPublicIpResponse> ShowPublicIpInvoker(ShowPublicIpRequest showPublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublicIpRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicIpRequest);
            return new SyncInvoker<ShowPublicIpResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPublicIpResponse>);
        }
        
        /// <summary>
        /// 查询实例在恢复时间点关联的数据节点
        ///
        /// 查询实例在恢复时间点关联的数据节点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRelatedDnsResponse ShowRelatedDns(ShowRelatedDnsRequest showRelatedDnsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRelatedDnsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/related-dn", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRelatedDnsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRelatedDnsResponse>(response);
        }

        public SyncInvoker<ShowRelatedDnsResponse> ShowRelatedDnsInvoker(ShowRelatedDnsRequest showRelatedDnsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRelatedDnsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/related-dn", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRelatedDnsRequest);
            return new SyncInvoker<ShowRelatedDnsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRelatedDnsResponse>);
        }
        
        /// <summary>
        /// DDM实例节点缩容
        ///
        /// 对指定的DDM实例的节点个数进行缩容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShrinkInstanceNodesResponse ShrinkInstanceNodes(ShrinkInstanceNodesRequest shrinkInstanceNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(shrinkInstanceNodesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/action/reduce", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", shrinkInstanceNodesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShrinkInstanceNodesResponse>(response);
        }

        public SyncInvoker<ShrinkInstanceNodesResponse> ShrinkInstanceNodesInvoker(ShrinkInstanceNodesRequest shrinkInstanceNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(shrinkInstanceNodesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/action/reduce", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", shrinkInstanceNodesRequest);
            return new SyncInvoker<ShrinkInstanceNodesResponse>(this, "POST", request, JsonUtils.DeSerialize<ShrinkInstanceNodesResponse>);
        }
        
        /// <summary>
        /// 创建访问控制组
        ///
        /// 创建访问控制组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchIpGroupResponse SwitchIpGroup(SwitchIpGroupRequest switchIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchIpGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(switchIpGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/groups/{group_id}/acls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchIpGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchIpGroupResponse>(response);
        }

        public SyncInvoker<SwitchIpGroupResponse> SwitchIpGroupInvoker(SwitchIpGroupRequest switchIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchIpGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(switchIpGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/groups/{group_id}/acls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchIpGroupRequest);
            return new SyncInvoker<SwitchIpGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchIpGroupResponse>);
        }
        
        /// <summary>
        /// 切换路由
        ///
        /// 切换路由
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchRouteResponse SwitchRoute(SwitchRouteRequest switchRouteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchRouteRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(switchRouteRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            if (StringUtils.TryConvertToNonEmptyString(switchRouteRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration/jobs/{job_id}/route-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchRouteRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SwitchRouteResponse>(response);
        }

        public SyncInvoker<SwitchRouteResponse> SwitchRouteInvoker(SwitchRouteRequest switchRouteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchRouteRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(switchRouteRequest.DbName, out var valueOfDbName)) urlParam.Add("db_name", valueOfDbName);
            if (StringUtils.TryConvertToNonEmptyString(switchRouteRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{db_name}/migration/jobs/{job_id}/route-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchRouteRequest);
            return new SyncInvoker<SwitchRouteResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SwitchRouteResponse>);
        }
        
        /// <summary>
        /// 为实例设置SSL数据加密
        ///
        /// 为实例设置SSL数据加密。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchSslResponse SwitchSsl(SwitchSslRequest switchSslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchSslRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switch-ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchSslRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SwitchSslResponse>(response);
        }

        public SyncInvoker<SwitchSslResponse> SwitchSslInvoker(SwitchSslRequest switchSslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchSslRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switch-ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchSslRequest);
            return new SyncInvoker<SwitchSslResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SwitchSslResponse>);
        }
        
        /// <summary>
        /// 同步数据节点
        ///
        /// 同步数据节点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SyncDnInformationResponse SyncDnInformation(SyncDnInformationRequest syncDnInformationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(syncDnInformationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/data-nodes/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncDnInformationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SyncDnInformationResponse>(response);
        }

        public SyncInvoker<SyncDnInformationResponse> SyncDnInformationInvoker(SyncDnInformationRequest syncDnInformationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(syncDnInformationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/data-nodes/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncDnInformationRequest);
            return new SyncInvoker<SyncDnInformationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SyncDnInformationResponse>);
        }
        
        /// <summary>
        /// 解绑弹性公网IP
        ///
        /// 解绑弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UnbindEipResponse UnbindEip(UnbindEipRequest unbindEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unbindEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/eip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unbindEipRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<UnbindEipResponse>(response);
        }

        public SyncInvoker<UnbindEipResponse> UnbindEipInvoker(UnbindEipRequest unbindEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unbindEipRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/eip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unbindEipRequest);
            return new SyncInvoker<UnbindEipResponse>(this, "DELETE", request, JsonUtils.DeSerialize<UnbindEipResponse>);
        }
        
        /// <summary>
        /// 同步DN信息
        ///
        /// 同步当前DDM实例已关联的所有DN实例配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDatabaseInfoResponse UpdateDatabaseInfo(UpdateDatabaseInfoRequest updateDatabaseInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDatabaseInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/rds/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDatabaseInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateDatabaseInfoResponse>(response);
        }

        public SyncInvoker<UpdateDatabaseInfoResponse> UpdateDatabaseInfoInvoker(UpdateDatabaseInfoRequest updateDatabaseInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDatabaseInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/rds/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDatabaseInfoRequest);
            return new SyncInvoker<UpdateDatabaseInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateDatabaseInfoResponse>);
        }
        
        /// <summary>
        /// 修改DDM实例名称
        ///
        /// 修改DDM实例名称。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceNameResponse UpdateInstanceName(UpdateInstanceNameRequest updateInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/modify-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceNameRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceNameResponse>(response);
        }

        public SyncInvoker<UpdateInstanceNameResponse> UpdateInstanceNameInvoker(UpdateInstanceNameRequest updateInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/modify-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceNameRequest);
            return new SyncInvoker<UpdateInstanceNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceNameResponse>);
        }
        
        /// <summary>
        /// 修改DDM实例参数
        ///
        /// 修改DDM实例参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceParamResponse UpdateInstanceParam(UpdateInstanceParamRequest updateInstanceParamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceParamRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceParamRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceParamResponse>(response);
        }

        public SyncInvoker<UpdateInstanceParamResponse> UpdateInstanceParamInvoker(UpdateInstanceParamRequest updateInstanceParamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceParamRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceParamRequest);
            return new SyncInvoker<UpdateInstanceParamResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceParamResponse>);
        }
        
        /// <summary>
        /// 修改实例端口
        ///
        /// 修改实例端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstancePortResponse UpdateInstancePort(UpdateInstancePortRequest updateInstancePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstancePortRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstancePortRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstancePortResponse>(response);
        }

        public SyncInvoker<UpdateInstancePortResponse> UpdateInstancePortInvoker(UpdateInstancePortRequest updateInstancePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstancePortRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstancePortRequest);
            return new SyncInvoker<UpdateInstancePortResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstancePortResponse>);
        }
        
        /// <summary>
        /// 修改DDM实例安全组
        ///
        /// 修改DDM实例安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceSecurityGroupResponse UpdateInstanceSecurityGroup(UpdateInstanceSecurityGroupRequest updateInstanceSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceSecurityGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/modify-security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceSecurityGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceSecurityGroupResponse>(response);
        }

        public SyncInvoker<UpdateInstanceSecurityGroupResponse> UpdateInstanceSecurityGroupInvoker(UpdateInstanceSecurityGroupRequest updateInstanceSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceSecurityGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/modify-security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceSecurityGroupRequest);
            return new SyncInvoker<UpdateInstanceSecurityGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 修改DDM已关联的数据库实例的读策略
        ///
        /// 修改DDM已关联的数据库实例的读策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateReadAndWriteStrategyResponse UpdateReadAndWriteStrategy(UpdateReadAndWriteStrategyRequest updateReadAndWriteStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateReadAndWriteStrategyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/action/read-write-strategy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateReadAndWriteStrategyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateReadAndWriteStrategyResponse>(response);
        }

        public SyncInvoker<UpdateReadAndWriteStrategyResponse> UpdateReadAndWriteStrategyInvoker(UpdateReadAndWriteStrategyRequest updateReadAndWriteStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateReadAndWriteStrategyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/action/read-write-strategy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateReadAndWriteStrategyRequest);
            return new SyncInvoker<UpdateReadAndWriteStrategyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateReadAndWriteStrategyResponse>);
        }
        
        /// <summary>
        /// 修改DDM帐号
        ///
        /// 修改现有DDM帐号的权限或者与逻辑库的管理关系。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateUserResponse UpdateUser(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateUserRequest.Username, out var valueOfUsername)) urlParam.Add("username", valueOfUsername);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/users/{username}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateUserResponse>(response);
        }

        public SyncInvoker<UpdateUserResponse> UpdateUserInvoker(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateUserRequest.Username, out var valueOfUsername)) urlParam.Add("username", valueOfUsername);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/users/{username}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserRequest);
            return new SyncInvoker<UpdateUserResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateUserResponse>);
        }
        
        /// <summary>
        /// 导入逻辑库元数据
        ///
        /// 导入所有逻辑库物理分片分布关系，以此创建相同物理分片分布关系的逻辑库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UploadSchemaMetadataResponse UploadSchemaMetadata(UploadSchemaMetadataRequest uploadSchemaMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(uploadSchemaMetadataRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema-metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", uploadSchemaMetadataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UploadSchemaMetadataResponse>(response);
        }

        public SyncInvoker<UploadSchemaMetadataResponse> UploadSchemaMetadataInvoker(UploadSchemaMetadataRequest uploadSchemaMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(uploadSchemaMetadataRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/schema-metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", uploadSchemaMetadataRequest);
            return new SyncInvoker<UploadSchemaMetadataResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadSchemaMetadataResponse>);
        }
        
        /// <summary>
        /// 弱密码校验
        ///
        /// 弱密码校验
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
        /// rds连通性检查V3
        ///
        /// rds连通性检查V3
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckDataNodeConnectionResponse CheckDataNodeConnection(CheckDataNodeConnectionRequest checkDataNodeConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkDataNodeConnectionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/rds/connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkDataNodeConnectionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CheckDataNodeConnectionResponse>(response);
        }

        public SyncInvoker<CheckDataNodeConnectionResponse> CheckDataNodeConnectionInvoker(CheckDataNodeConnectionRequest checkDataNodeConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkDataNodeConnectionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/rds/connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkDataNodeConnectionRequest);
            return new SyncInvoker<CheckDataNodeConnectionResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckDataNodeConnectionResponse>);
        }
        
        /// <summary>
        /// 比较参数组V3
        ///
        /// 比较参数组V3
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CompareParameterGroupsResponse CompareParameterGroups(CompareParameterGroupsRequest compareParameterGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/diff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", compareParameterGroupsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<CompareParameterGroupsResponse>(response);
        }

        public SyncInvoker<CompareParameterGroupsResponse> CompareParameterGroupsInvoker(CompareParameterGroupsRequest compareParameterGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/diff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", compareParameterGroupsRequest);
            return new SyncInvoker<CompareParameterGroupsResponse>(this, "PUT", request, JsonUtils.DeSerialize<CompareParameterGroupsResponse>);
        }
        
        /// <summary>
        /// 复制参数组V3
        ///
        /// 复制参数组V3
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
            return JsonUtils.DeSerializeNull<CopyConfigurationResponse>(response);
        }

        public SyncInvoker<CopyConfigurationResponse> CopyConfigurationInvoker(CopyConfigurationRequest copyConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(copyConfigurationRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyConfigurationRequest);
            return new SyncInvoker<CopyConfigurationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CopyConfigurationResponse>);
        }
        
        /// <summary>
        /// 参数组应用记录V3
        ///
        /// 参数组应用记录V3
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConfigurationApplyHistoriesResponse ListConfigurationApplyHistories(ListConfigurationApplyHistoriesRequest listConfigurationApplyHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listConfigurationApplyHistoriesRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationApplyHistoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListConfigurationApplyHistoriesResponse>(response);
        }

        public SyncInvoker<ListConfigurationApplyHistoriesResponse> ListConfigurationApplyHistoriesInvoker(ListConfigurationApplyHistoriesRequest listConfigurationApplyHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listConfigurationApplyHistoriesRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationApplyHistoriesRequest);
            return new SyncInvoker<ListConfigurationApplyHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigurationApplyHistoriesResponse>);
        }
        
        /// <summary>
        /// 查询可应用的实例列表V3
        ///
        /// 查询可应用的实例列表V3
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstancesConfigurationsResponse ListInstancesConfigurations(ListInstancesConfigurationsRequest listInstancesConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstancesConfigurationsRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/query-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesConfigurationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesConfigurationsResponse>(response);
        }

        public SyncInvoker<ListInstancesConfigurationsResponse> ListInstancesConfigurationsInvoker(ListInstancesConfigurationsRequest listInstancesConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstancesConfigurationsRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/query-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesConfigurationsRequest);
            return new SyncInvoker<ListInstancesConfigurationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesConfigurationsResponse>);
        }
        
        /// <summary>
        /// 更新参数组V3
        ///
        /// 更新参数组V3
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetParameterGroupResponse ResetParameterGroup(ResetParameterGroupRequest resetParameterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetParameterGroupRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetParameterGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ResetParameterGroupResponse>(response);
        }

        public SyncInvoker<ResetParameterGroupResponse> ResetParameterGroupInvoker(ResetParameterGroupRequest resetParameterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetParameterGroupRequest.ConfigId, out var valueOfConfigId)) urlParam.Add("config_id", valueOfConfigId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetParameterGroupRequest);
            return new SyncInvoker<ResetParameterGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResetParameterGroupResponse>);
        }
        
        /// <summary>
        /// 查询实例详情V3
        ///
        /// 查询实例详情V3
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDdmDetailResponse ShowDdmDetail(ShowDdmDetailRequest showDdmDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDdmDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDdmDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDdmDetailResponse>(response);
        }

        public SyncInvoker<ShowDdmDetailResponse> ShowDdmDetailInvoker(ShowDdmDetailRequest showDdmDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDdmDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDdmDetailRequest);
            return new SyncInvoker<ShowDdmDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDdmDetailResponse>);
        }
        
        /// <summary>
        /// 批量设置读策略V3
        ///
        /// 批量设置读策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchModifyReadWriteStrategyResponse BatchModifyReadWriteStrategy(BatchModifyReadWriteStrategyRequest batchModifyReadWriteStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchModifyReadWriteStrategyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action/batch-modify-read-write-strategy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchModifyReadWriteStrategyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchModifyReadWriteStrategyResponse>(response);
        }

        public SyncInvoker<BatchModifyReadWriteStrategyResponse> BatchModifyReadWriteStrategyInvoker(BatchModifyReadWriteStrategyRequest batchModifyReadWriteStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchModifyReadWriteStrategyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action/batch-modify-read-write-strategy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchModifyReadWriteStrategyRequest);
            return new SyncInvoker<BatchModifyReadWriteStrategyResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchModifyReadWriteStrategyResponse>);
        }
        
        /// <summary>
        /// 修改sql黑名单
        ///
        /// 修改sql黑名单V3
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifySqlBlackListResponse ModifySqlBlackList(ModifySqlBlackListRequest modifySqlBlackListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifySqlBlackListRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(modifySqlBlackListRequest.LogicDbName, out var valueOfLogicDbName)) urlParam.Add("logic_db_name", valueOfLogicDbName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{logic_db_name}/sql-black-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifySqlBlackListRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifySqlBlackListResponse>(response);
        }

        public SyncInvoker<ModifySqlBlackListResponse> ModifySqlBlackListInvoker(ModifySqlBlackListRequest modifySqlBlackListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifySqlBlackListRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(modifySqlBlackListRequest.LogicDbName, out var valueOfLogicDbName)) urlParam.Add("logic_db_name", valueOfLogicDbName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{logic_db_name}/sql-black-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifySqlBlackListRequest);
            return new SyncInvoker<ModifySqlBlackListResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifySqlBlackListResponse>);
        }
        
        /// <summary>
        /// 查询sql黑名单V3
        ///
        /// 查询sql黑名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSqlBlackResponse ListSqlBlack(ListSqlBlackRequest listSqlBlackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlBlackRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listSqlBlackRequest.LogicDbName, out var valueOfLogicDbName)) urlParam.Add("logic_db_name", valueOfLogicDbName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{logic_db_name}/sql-black-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlBlackRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSqlBlackResponse>(response);
        }

        public SyncInvoker<ListSqlBlackResponse> ListSqlBlackInvoker(ListSqlBlackRequest listSqlBlackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSqlBlackRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listSqlBlackRequest.LogicDbName, out var valueOfLogicDbName)) urlParam.Add("logic_db_name", valueOfLogicDbName);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{logic_db_name}/sql-black-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlBlackRequest);
            return new SyncInvoker<ListSqlBlackResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSqlBlackResponse>);
        }
        
    }
}