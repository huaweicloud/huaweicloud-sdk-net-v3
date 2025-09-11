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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateOrDeleteTagsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dcs/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateOrDeleteTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateOrDeleteTagsResponse> BatchCreateOrDeleteTagsAsyncInvoker(BatchCreateOrDeleteTagsRequest batchCreateOrDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateOrDeleteTagsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dcs/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateOrDeleteTagsRequest);
            return new AsyncInvoker<BatchCreateOrDeleteTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateOrDeleteTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteInstancesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteInstancesResponse>(response);
        }

        public AsyncInvoker<BatchDeleteInstancesResponse> BatchDeleteInstancesAsyncInvoker(BatchDeleteInstancesRequest batchDeleteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteInstancesRequest);
            return new AsyncInvoker<BatchDeleteInstancesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteInstancesResponse>);
        }
        
        /// <summary>
        /// 批量重启在线迁移任务
        ///
        /// 批量重启在线迁移任务，接口响应成功，返回重启在线迁移任务下发结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchRestartOnlineMigrationTasksResponse> BatchRestartOnlineMigrationTasksAsync(BatchRestartOnlineMigrationTasksRequest batchRestartOnlineMigrationTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-tasks/batch-restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRestartOnlineMigrationTasksRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchRestartOnlineMigrationTasksResponse>(response);
        }

        public AsyncInvoker<BatchRestartOnlineMigrationTasksResponse> BatchRestartOnlineMigrationTasksAsyncInvoker(BatchRestartOnlineMigrationTasksRequest batchRestartOnlineMigrationTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-tasks/batch-restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRestartOnlineMigrationTasksRequest);
            return new AsyncInvoker<BatchRestartOnlineMigrationTasksResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRestartOnlineMigrationTasksResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances-logical-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowNodesInformationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<BatchShowNodesInformationResponse>(response);
        }

        public AsyncInvoker<BatchShowNodesInformationResponse> BatchShowNodesInformationAsyncInvoker(BatchShowNodesInformationRequest batchShowNodesInformationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances-logical-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowNodesInformationRequest);
            return new AsyncInvoker<BatchShowNodesInformationResponse>(this, "GET", request, JsonUtils.DeSerialize<BatchShowNodesInformationResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/batch-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStopMigrationTasksRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchStopMigrationTasksResponse>(response);
        }

        public AsyncInvoker<BatchStopMigrationTasksResponse> BatchStopMigrationTasksAsyncInvoker(BatchStopMigrationTasksRequest batchStopMigrationTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/batch-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStopMigrationTasksRequest);
            return new AsyncInvoker<BatchStopMigrationTasksResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchStopMigrationTasksResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeMasterStandbyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/swap", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeMasterStandbyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ChangeMasterStandbyResponse>(response);
        }

        public AsyncInvoker<ChangeMasterStandbyResponse> ChangeMasterStandbyAsyncInvoker(ChangeMasterStandbyRequest changeMasterStandbyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeMasterStandbyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/swap", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeMasterStandbyRequest);
            return new AsyncInvoker<ChangeMasterStandbyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ChangeMasterStandbyResponse>);
        }
        
        /// <summary>
        /// 异步交换实例主备节点
        ///
        /// 异步交换实例主备节点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeMasterStandbyAsyncResponse> ChangeMasterStandbyAsyncAsync(ChangeMasterStandbyAsyncRequest changeMasterStandbyAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeMasterStandbyAsyncRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/async-swap", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeMasterStandbyAsyncRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ChangeMasterStandbyAsyncResponse>(response);
        }

        public AsyncInvoker<ChangeMasterStandbyAsyncResponse> ChangeMasterStandbyAsyncAsyncInvoker(ChangeMasterStandbyAsyncRequest changeMasterStandbyAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeMasterStandbyAsyncRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/async-swap", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeMasterStandbyAsyncRequest);
            return new AsyncInvoker<ChangeMasterStandbyAsyncResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeMasterStandbyAsyncResponse>);
        }
        
        /// <summary>
        /// 指定实例节点启停开关
        ///
        /// 实例节点启停。执行节点关机操作前的24小时内，需要对实例（单机实例除外）进行数据备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeNodesStartStopStatusResponse> ChangeNodesStartStopStatusAsync(ChangeNodesStartStopStatusRequest changeNodesStartStopStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeNodesStartStopStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/nodes/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeNodesStartStopStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<ChangeNodesStartStopStatusResponse>(response);
        }

        public AsyncInvoker<ChangeNodesStartStopStatusResponse> ChangeNodesStartStopStatusAsyncInvoker(ChangeNodesStartStopStatusRequest changeNodesStartStopStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeNodesStartStopStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/nodes/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeNodesStartStopStatusRequest);
            return new AsyncInvoker<ChangeNodesStartStopStatusResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ChangeNodesStartStopStatusResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(copyInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CopyInstanceResponse>(response);
        }

        public AsyncInvoker<CopyInstanceResponse> CopyInstanceAsyncInvoker(CopyInstanceRequest copyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(copyInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyInstanceRequest);
            return new AsyncInvoker<CopyInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyInstanceResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAclAccountRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAclAccountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateAclAccountResponse>(response);
        }

        public AsyncInvoker<CreateAclAccountResponse> CreateAclAccountAsyncInvoker(CreateAclAccountRequest createAclAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAclAccountRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAclAccountRequest);
            return new AsyncInvoker<CreateAclAccountResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateAclAccountResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAutoExpireScanTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/scan-expire-keys-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutoExpireScanTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAutoExpireScanTaskResponse>(response);
        }

        public AsyncInvoker<CreateAutoExpireScanTaskResponse> CreateAutoExpireScanTaskAsyncInvoker(CreateAutoExpireScanTaskRequest createAutoExpireScanTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAutoExpireScanTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/scan-expire-keys-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutoExpireScanTaskRequest);
            return new AsyncInvoker<CreateAutoExpireScanTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAutoExpireScanTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createBigkeyScanTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBigkeyScanTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateBigkeyScanTaskResponse>(response);
        }

        public AsyncInvoker<CreateBigkeyScanTaskResponse> CreateBigkeyScanTaskAsyncInvoker(CreateBigkeyScanTaskRequest createBigkeyScanTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createBigkeyScanTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBigkeyScanTaskRequest);
            return new AsyncInvoker<CreateBigkeyScanTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBigkeyScanTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCustomTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateCustomTemplateResponse>(response);
        }

        public AsyncInvoker<CreateCustomTemplateResponse> CreateCustomTemplateAsyncInvoker(CreateCustomTemplateRequest createCustomTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCustomTemplateRequest);
            return new AsyncInvoker<CreateCustomTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCustomTemplateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDiagnosisTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/diagnosis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDiagnosisTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDiagnosisTaskResponse>(response);
        }

        public AsyncInvoker<CreateDiagnosisTaskResponse> CreateDiagnosisTaskAsyncInvoker(CreateDiagnosisTaskRequest createDiagnosisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDiagnosisTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/diagnosis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDiagnosisTaskRequest);
            return new AsyncInvoker<CreateDiagnosisTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDiagnosisTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createHotkeyScanTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHotkeyScanTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateHotkeyScanTaskResponse>(response);
        }

        public AsyncInvoker<CreateHotkeyScanTaskResponse> CreateHotkeyScanTaskAsyncInvoker(CreateHotkeyScanTaskRequest createHotkeyScanTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createHotkeyScanTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHotkeyScanTaskRequest);
            return new AsyncInvoker<CreateHotkeyScanTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHotkeyScanTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceResponse>(response);
        }

        public AsyncInvoker<CreateInstanceResponse> CreateInstanceAsyncInvoker(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstanceRequest);
            return new AsyncInvoker<CreateInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMigrationTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateMigrationTaskResponse>(response);
        }

        public AsyncInvoker<CreateMigrationTaskResponse> CreateMigrationTaskAsyncInvoker(CreateMigrationTaskRequest createMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMigrationTaskRequest);
            return new AsyncInvoker<CreateMigrationTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMigrationTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration/instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOnlineMigrationTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateOnlineMigrationTaskResponse>(response);
        }

        public AsyncInvoker<CreateOnlineMigrationTaskResponse> CreateOnlineMigrationTaskAsyncInvoker(CreateOnlineMigrationTaskRequest createOnlineMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration/instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOnlineMigrationTaskRequest);
            return new AsyncInvoker<CreateOnlineMigrationTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOnlineMigrationTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRedislogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/redislog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRedislogRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateRedislogResponse>(response);
        }

        public AsyncInvoker<CreateRedislogResponse> CreateRedislogAsyncInvoker(CreateRedislogRequest createRedislogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRedislogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/redislog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRedislogRequest);
            return new AsyncInvoker<CreateRedislogResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateRedislogResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRedislogDownloadLinkRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createRedislogDownloadLinkRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/redislog/{id}/links", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRedislogDownloadLinkRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRedislogDownloadLinkResponse>(response);
        }

        public AsyncInvoker<CreateRedislogDownloadLinkResponse> CreateRedislogDownloadLinkAsyncInvoker(CreateRedislogDownloadLinkRequest createRedislogDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRedislogDownloadLinkRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createRedislogDownloadLinkRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/redislog/{id}/links", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRedislogDownloadLinkRequest);
            return new AsyncInvoker<CreateRedislogDownloadLinkResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRedislogDownloadLinkResponse>);
        }
        
        /// <summary>
        /// 包周期实例变更规格
        ///
        /// 包周期实例变更规格
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateResizeOrderResponse> CreateResizeOrderAsync(CreateResizeOrderRequest createResizeOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createResizeOrderRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/orders/instances/{instance_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createResizeOrderRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateResizeOrderResponse>(response);
        }

        public AsyncInvoker<CreateResizeOrderResponse> CreateResizeOrderAsyncInvoker(CreateResizeOrderRequest createResizeOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createResizeOrderRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/orders/instances/{instance_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createResizeOrderRequest);
            return new AsyncInvoker<CreateResizeOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateResizeOrderResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAclAccountRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAclAccountRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAclAccountRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAclAccountResponse>(response);
        }

        public AsyncInvoker<DeleteAclAccountResponse> DeleteAclAccountAsyncInvoker(DeleteAclAccountRequest deleteAclAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAclAccountRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAclAccountRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAclAccountRequest);
            return new AsyncInvoker<DeleteAclAccountResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAclAccountResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBackgroundTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteBackgroundTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackgroundTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteBackgroundTaskResponse>(response);
        }

        public AsyncInvoker<DeleteBackgroundTaskResponse> DeleteBackgroundTaskAsyncInvoker(DeleteBackgroundTaskRequest deleteBackgroundTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBackgroundTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteBackgroundTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackgroundTaskRequest);
            return new AsyncInvoker<DeleteBackgroundTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteBackgroundTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBackupFileRequest.BackupId, out var valueOfBackupId)) urlParam.Add("backup_id", valueOfBackupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteBackupFileRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackupFileRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteBackupFileResponse>(response);
        }

        public AsyncInvoker<DeleteBackupFileResponse> DeleteBackupFileAsyncInvoker(DeleteBackupFileRequest deleteBackupFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBackupFileRequest.BackupId, out var valueOfBackupId)) urlParam.Add("backup_id", valueOfBackupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteBackupFileRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackupFileRequest);
            return new AsyncInvoker<DeleteBackupFileResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBackupFileResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBigkeyScanTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteBigkeyScanTaskRequest.BigkeyId, out var valueOfBigkeyId)) urlParam.Add("bigkey_id", valueOfBigkeyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey-task/{bigkey_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBigkeyScanTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteBigkeyScanTaskResponse>(response);
        }

        public AsyncInvoker<DeleteBigkeyScanTaskResponse> DeleteBigkeyScanTaskAsyncInvoker(DeleteBigkeyScanTaskRequest deleteBigkeyScanTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBigkeyScanTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteBigkeyScanTaskRequest.BigkeyId, out var valueOfBigkeyId)) urlParam.Add("bigkey_id", valueOfBigkeyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey-task/{bigkey_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBigkeyScanTaskRequest);
            return new AsyncInvoker<DeleteBigkeyScanTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteBigkeyScanTaskResponse>);
        }
        
        /// <summary>
        /// 删除任务中心任务
        ///
        /// 删除任务中心任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCenterTaskResponse> DeleteCenterTaskAsync(DeleteCenterTaskRequest deleteCenterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCenterTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteCenterTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCenterTaskResponse>(response);
        }

        public AsyncInvoker<DeleteCenterTaskResponse> DeleteCenterTaskAsyncInvoker(DeleteCenterTaskRequest deleteCenterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCenterTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteCenterTaskRequest);
            return new AsyncInvoker<DeleteCenterTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCenterTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConfigTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigTemplateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteConfigTemplateResponse>(response);
        }

        public AsyncInvoker<DeleteConfigTemplateResponse> DeleteConfigTemplateAsyncInvoker(DeleteConfigTemplateRequest deleteConfigTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConfigTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigTemplateRequest);
            return new AsyncInvoker<DeleteConfigTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteConfigTemplateResponse>);
        }
        
        /// <summary>
        /// 删除诊断记录
        ///
        /// 删除诊断记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDiagnosisTaskResponse> DeleteDiagnosisTaskAsync(DeleteDiagnosisTaskRequest deleteDiagnosisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDiagnosisTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/diagnosis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteDiagnosisTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDiagnosisTaskResponse>(response);
        }

        public AsyncInvoker<DeleteDiagnosisTaskResponse> DeleteDiagnosisTaskAsyncInvoker(DeleteDiagnosisTaskRequest deleteDiagnosisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDiagnosisTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/diagnosis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteDiagnosisTaskRequest);
            return new AsyncInvoker<DeleteDiagnosisTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDiagnosisTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHotkeyScanTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteHotkeyScanTaskRequest.HotkeyId, out var valueOfHotkeyId)) urlParam.Add("hotkey_id", valueOfHotkeyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey-task/{hotkey_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHotkeyScanTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteHotkeyScanTaskResponse>(response);
        }

        public AsyncInvoker<DeleteHotkeyScanTaskResponse> DeleteHotkeyScanTaskAsyncInvoker(DeleteHotkeyScanTaskRequest deleteHotkeyScanTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHotkeyScanTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteHotkeyScanTaskRequest.HotkeyId, out var valueOfHotkeyId)) urlParam.Add("hotkey_id", valueOfHotkeyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey-task/{hotkey_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHotkeyScanTaskRequest);
            return new AsyncInvoker<DeleteHotkeyScanTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteHotkeyScanTaskResponse>);
        }
        
        /// <summary>
        /// 删除实例带宽弹性伸缩策略
        ///
        /// 删除实例带宽弹性伸缩策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceBandwidthAutoScalingPolicyResponse> DeleteInstanceBandwidthAutoScalingPolicyAsync(DeleteInstanceBandwidthAutoScalingPolicyRequest deleteInstanceBandwidthAutoScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceBandwidthAutoScalingPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/autoscaling-policy/bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceBandwidthAutoScalingPolicyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceBandwidthAutoScalingPolicyResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceBandwidthAutoScalingPolicyResponse> DeleteInstanceBandwidthAutoScalingPolicyAsyncInvoker(DeleteInstanceBandwidthAutoScalingPolicyRequest deleteInstanceBandwidthAutoScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceBandwidthAutoScalingPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/autoscaling-policy/bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceBandwidthAutoScalingPolicyRequest);
            return new AsyncInvoker<DeleteInstanceBandwidthAutoScalingPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceBandwidthAutoScalingPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteIpFromDomainNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteIpFromDomainNameRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteIpFromDomainNameRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group_id}/replications/{node_id}/remove-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpFromDomainNameRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteIpFromDomainNameResponse>(response);
        }

        public AsyncInvoker<DeleteIpFromDomainNameResponse> DeleteIpFromDomainNameAsyncInvoker(DeleteIpFromDomainNameRequest deleteIpFromDomainNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteIpFromDomainNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteIpFromDomainNameRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteIpFromDomainNameRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group_id}/replications/{node_id}/remove-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpFromDomainNameRequest);
            return new AsyncInvoker<DeleteIpFromDomainNameResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteIpFromDomainNameResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-tasks/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteMigrationTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteMigrationTaskResponse>(response);
        }

        public AsyncInvoker<DeleteMigrationTaskResponse> DeleteMigrationTaskAsyncInvoker(DeleteMigrationTaskRequest deleteMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-tasks/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteMigrationTaskRequest);
            return new AsyncInvoker<DeleteMigrationTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteMigrationTaskResponse>);
        }
        
        /// <summary>
        /// 关闭实例公网访问
        ///
        /// 关闭实例公网访问。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePublicIpResponse> DeletePublicIpAsync(DeletePublicIpRequest deletePublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePublicIpRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicIpRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePublicIpResponse>(response);
        }

        public AsyncInvoker<DeletePublicIpResponse> DeletePublicIpAsyncInvoker(DeletePublicIpRequest deletePublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePublicIpRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicIpRequest);
            return new AsyncInvoker<DeletePublicIpResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePublicIpResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSingleInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSingleInstanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSingleInstanceResponse>(response);
        }

        public AsyncInvoker<DeleteSingleInstanceResponse> DeleteSingleInstanceAsyncInvoker(DeleteSingleInstanceRequest deleteSingleInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSingleInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSingleInstanceRequest);
            return new AsyncInvoker<DeleteSingleInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSingleInstanceResponse>);
        }
        
        /// <summary>
        /// 下载热key
        ///
        /// 下载热key。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadHotKeyResponse> DownloadHotKeyAsync(DownloadHotKeyRequest downloadHotKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadHotKeyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(downloadHotKeyRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey/{task_id}/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadHotKeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DownloadHotKeyResponse>(response);
        }

        public AsyncInvoker<DownloadHotKeyResponse> DownloadHotKeyAsyncInvoker(DownloadHotKeyRequest downloadHotKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadHotKeyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(downloadHotKeyRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey/{task_id}/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadHotKeyRequest);
            return new AsyncInvoker<DownloadHotKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<DownloadHotKeyResponse>);
        }
        
        /// <summary>
        /// 下载实例SSL证书
        ///
        /// 下载实例SSL证书。该接口目前仅针对Redis 6.0[基础版](tag:hws,hws_hk)版本实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadSslCertResponse> DownloadSslCertAsync(DownloadSslCertRequest downloadSslCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadSslCertRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/ssl-certs/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSslCertRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DownloadSslCertResponse>(response);
        }

        public AsyncInvoker<DownloadSslCertResponse> DownloadSslCertAsyncInvoker(DownloadSslCertRequest downloadSslCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadSslCertRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/ssl-certs/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSslCertRequest);
            return new AsyncInvoker<DownloadSslCertResponse>(this, "POST", request, JsonUtils.DeSerialize<DownloadSslCertResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(exchangeInstanceIpRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/exchange-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exchangeInstanceIpRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ExchangeInstanceIpResponse>(response);
        }

        public AsyncInvoker<ExchangeInstanceIpResponse> ExchangeInstanceIpAsyncInvoker(ExchangeInstanceIpRequest exchangeInstanceIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(exchangeInstanceIpRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/exchange-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exchangeInstanceIpRequest);
            return new AsyncInvoker<ExchangeInstanceIpResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ExchangeInstanceIpResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeClusterSwitchoverRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(executeClusterSwitchoverRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(executeClusterSwitchoverRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/groups/{group_id}/replications/{node_id}/async-switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeClusterSwitchoverRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteClusterSwitchoverResponse>(response);
        }

        public AsyncInvoker<ExecuteClusterSwitchoverResponse> ExecuteClusterSwitchoverAsyncInvoker(ExecuteClusterSwitchoverRequest executeClusterSwitchoverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeClusterSwitchoverRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(executeClusterSwitchoverRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(executeClusterSwitchoverRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/groups/{group_id}/replications/{node_id}/async-switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeClusterSwitchoverRequest);
            return new AsyncInvoker<ExecuteClusterSwitchoverResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteClusterSwitchoverResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeCommandMobilizationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/webcli/command", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCommandMobilizationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteCommandMobilizationResponse>(response);
        }

        public AsyncInvoker<ExecuteCommandMobilizationResponse> ExecuteCommandMobilizationAsyncInvoker(ExecuteCommandMobilizationRequest executeCommandMobilizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeCommandMobilizationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/webcli/command", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCommandMobilizationRequest);
            return new AsyncInvoker<ExecuteCommandMobilizationResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteCommandMobilizationResponse>);
        }
        
        /// <summary>
        /// 查询实例列表导出任务详情
        ///
        /// 查询实例列表导出任务详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExportExcelJobResponse> ExportExcelJobAsync(ExportExcelJobRequest exportExcelJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/export-job", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportExcelJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ExportExcelJobResponse>(response);
        }

        public AsyncInvoker<ExportExcelJobResponse> ExportExcelJobAsyncInvoker(ExportExcelJobRequest exportExcelJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/export-job", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportExcelJobRequest);
            return new AsyncInvoker<ExportExcelJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ExportExcelJobResponse>);
        }
        
        /// <summary>
        /// 异步导出实例资源
        ///
        /// 异步导出实例资源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExportInstancesTaskResponse> ExportInstancesTaskAsync(ExportInstancesTaskRequest exportInstancesTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exportInstancesTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExportInstancesTaskResponse>(response);
        }

        public AsyncInvoker<ExportInstancesTaskResponse> ExportInstancesTaskAsyncInvoker(ExportInstancesTaskRequest exportInstancesTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exportInstancesTaskRequest);
            return new AsyncInvoker<ExportInstancesTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<ExportInstancesTaskResponse>);
        }
        
        /// <summary>
        /// kill指定的会话
        ///
        /// kill指定的会话
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<HangUpClientsResponse> HangUpClientsAsync(HangUpClientsRequest hangUpClientsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(hangUpClientsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/clients/kill", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", hangUpClientsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<HangUpClientsResponse>(response);
        }

        public AsyncInvoker<HangUpClientsResponse> HangUpClientsAsyncInvoker(HangUpClientsRequest hangUpClientsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(hangUpClientsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/clients/kill", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", hangUpClientsRequest);
            return new AsyncInvoker<HangUpClientsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<HangUpClientsResponse>);
        }
        
        /// <summary>
        /// 下发kill指定节点或实例的全部会话任务
        ///
        /// 下发kill指定节点或实例的全部会话任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<HangUpKillAllClientsResponse> HangUpKillAllClientsAsync(HangUpKillAllClientsRequest hangUpKillAllClientsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(hangUpKillAllClientsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/clients/kill-all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", hangUpKillAllClientsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<HangUpKillAllClientsResponse>(response);
        }

        public AsyncInvoker<HangUpKillAllClientsResponse> HangUpKillAllClientsAsyncInvoker(HangUpKillAllClientsRequest hangUpKillAllClientsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(hangUpKillAllClientsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/clients/kill-all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", hangUpKillAllClientsRequest);
            return new AsyncInvoker<HangUpKillAllClientsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<HangUpKillAllClientsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAclAccountsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclAccountsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAclAccountsResponse>(response);
        }

        public AsyncInvoker<ListAclAccountsResponse> ListAclAccountsAsyncInvoker(ListAclAccountsRequest listAclAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAclAccountsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclAccountsRequest);
            return new AsyncInvoker<ListAclAccountsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAclAccountsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/available-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableZonesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAvailableZonesResponse>(response);
        }

        public AsyncInvoker<ListAvailableZonesResponse> ListAvailableZonesAsyncInvoker(ListAvailableZonesRequest listAvailableZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/available-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableZonesRequest);
            return new AsyncInvoker<ListAvailableZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailableZonesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBackgroundTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackgroundTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBackgroundTaskResponse>(response);
        }

        public AsyncInvoker<ListBackgroundTaskResponse> ListBackgroundTaskAsyncInvoker(ListBackgroundTaskRequest listBackgroundTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBackgroundTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackgroundTaskRequest);
            return new AsyncInvoker<ListBackgroundTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBackgroundTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBackupFileLinksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listBackupFileLinksRequest.BackupId, out var valueOfBackupId)) urlParam.Add("backup_id", valueOfBackupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups/{backup_id}/links", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listBackupFileLinksRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListBackupFileLinksResponse>(response);
        }

        public AsyncInvoker<ListBackupFileLinksResponse> ListBackupFileLinksAsyncInvoker(ListBackupFileLinksRequest listBackupFileLinksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBackupFileLinksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listBackupFileLinksRequest.BackupId, out var valueOfBackupId)) urlParam.Add("backup_id", valueOfBackupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups/{backup_id}/links", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listBackupFileLinksRequest);
            return new AsyncInvoker<ListBackupFileLinksResponse>(this, "POST", request, JsonUtils.DeSerialize<ListBackupFileLinksResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBackupRecordsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupRecordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBackupRecordsResponse>(response);
        }

        public AsyncInvoker<ListBackupRecordsResponse> ListBackupRecordsAsyncInvoker(ListBackupRecordsRequest listBackupRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBackupRecordsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupRecordsRequest);
            return new AsyncInvoker<ListBackupRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBackupRecordsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBigkeyScanTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBigkeyScanTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBigkeyScanTasksResponse>(response);
        }

        public AsyncInvoker<ListBigkeyScanTasksResponse> ListBigkeyScanTasksAsyncInvoker(ListBigkeyScanTasksRequest listBigkeyScanTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBigkeyScanTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBigkeyScanTasksRequest);
            return new AsyncInvoker<ListBigkeyScanTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBigkeyScanTasksResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCenterTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCenterTaskResponse>(response);
        }

        public AsyncInvoker<ListCenterTaskResponse> ListCenterTaskAsyncInvoker(ListCenterTaskRequest listCenterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCenterTaskRequest);
            return new AsyncInvoker<ListCenterTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCenterTaskResponse>);
        }
        
        /// <summary>
        /// 获取会话列表
        ///
        /// 获取会话列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListClientsResponse> ListClientsAsync(ListClientsRequest listClientsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listClientsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/clients", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClientsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListClientsResponse>(response);
        }

        public AsyncInvoker<ListClientsResponse> ListClientsAsyncInvoker(ListClientsRequest listClientsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listClientsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/clients", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClientsRequest);
            return new AsyncInvoker<ListClientsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClientsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listConfigHistoriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/config-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigHistoriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListConfigHistoriesResponse>(response);
        }

        public AsyncInvoker<ListConfigHistoriesResponse> ListConfigHistoriesAsyncInvoker(ListConfigHistoriesRequest listConfigHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listConfigHistoriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/config-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigHistoriesRequest);
            return new AsyncInvoker<ListConfigHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigHistoriesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListConfigTemplatesResponse>(response);
        }

        public AsyncInvoker<ListConfigTemplatesResponse> ListConfigTemplatesAsyncInvoker(ListConfigTemplatesRequest listConfigTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigTemplatesRequest);
            return new AsyncInvoker<ListConfigTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigTemplatesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listConfigurationsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListConfigurationsResponse>(response);
        }

        public AsyncInvoker<ListConfigurationsResponse> ListConfigurationsAsyncInvoker(ListConfigurationsRequest listConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listConfigurationsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationsRequest);
            return new AsyncInvoker<ListConfigurationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigurationsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDiagnosisTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/diagnosis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDiagnosisTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDiagnosisTasksResponse>(response);
        }

        public AsyncInvoker<ListDiagnosisTasksResponse> ListDiagnosisTasksAsyncInvoker(ListDiagnosisTasksRequest listDiagnosisTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDiagnosisTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/diagnosis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDiagnosisTasksRequest);
            return new AsyncInvoker<ListDiagnosisTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDiagnosisTasksResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }

        public AsyncInvoker<ListFlavorsResponse> ListFlavorsAsyncInvoker(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            return new AsyncInvoker<ListFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupReplicationInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupReplicationInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGroupReplicationInfoResponse>(response);
        }

        public AsyncInvoker<ListGroupReplicationInfoResponse> ListGroupReplicationInfoAsyncInvoker(ListGroupReplicationInfoRequest listGroupReplicationInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupReplicationInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupReplicationInfoRequest);
            return new AsyncInvoker<ListGroupReplicationInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupReplicationInfoResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHotKeyScanTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHotKeyScanTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHotKeyScanTasksResponse>(response);
        }

        public AsyncInvoker<ListHotKeyScanTasksResponse> ListHotKeyScanTasksAsyncInvoker(ListHotKeyScanTasksRequest listHotKeyScanTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHotKeyScanTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHotKeyScanTasksRequest);
            return new AsyncInvoker<ListHotKeyScanTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHotKeyScanTasksResponse>);
        }
        
        /// <summary>
        /// 查询实例是否可以扩容
        ///
        /// 查询实例是否可以扩容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceOperationsResponse> ListInstanceOperationsAsync(ListInstanceOperationsRequest listInstanceOperationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceOperationsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/operations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceOperationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceOperationsResponse>(response);
        }

        public AsyncInvoker<ListInstanceOperationsResponse> ListInstanceOperationsAsyncInvoker(ListInstanceOperationsRequest listInstanceOperationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceOperationsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/operations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceOperationsRequest);
            return new AsyncInvoker<ListInstanceOperationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceOperationsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesResponse>(response);
        }

        public AsyncInvoker<ListInstancesResponse> ListInstancesAsyncInvoker(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            return new AsyncInvoker<ListInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/instances/maintain-windows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMaintenanceWindowsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMaintenanceWindowsResponse>(response);
        }

        public AsyncInvoker<ListMaintenanceWindowsResponse> ListMaintenanceWindowsAsyncInvoker(ListMaintenanceWindowsRequest listMaintenanceWindowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/instances/maintain-windows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMaintenanceWindowsRequest);
            return new AsyncInvoker<ListMaintenanceWindowsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMaintenanceWindowsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMigrationTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMigrationTaskResponse>(response);
        }

        public AsyncInvoker<ListMigrationTaskResponse> ListMigrationTaskAsyncInvoker(ListMigrationTaskRequest listMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMigrationTaskRequest);
            return new AsyncInvoker<ListMigrationTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMigrationTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMigrationTaskLogsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMigrationTaskLogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMigrationTaskLogsResponse>(response);
        }

        public AsyncInvoker<ListMigrationTaskLogsResponse> ListMigrationTaskLogsAsyncInvoker(ListMigrationTaskLogsRequest listMigrationTaskLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMigrationTaskLogsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMigrationTaskLogsRequest);
            return new AsyncInvoker<ListMigrationTaskLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMigrationTaskLogsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dims/monitored-objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMonitoredObjectsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMonitoredObjectsResponse>(response);
        }

        public AsyncInvoker<ListMonitoredObjectsResponse> ListMonitoredObjectsAsyncInvoker(ListMonitoredObjectsRequest listMonitoredObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dims/monitored-objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMonitoredObjectsRequest);
            return new AsyncInvoker<ListMonitoredObjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMonitoredObjectsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMonitoredObjectsOfInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dims/monitored-objects/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMonitoredObjectsOfInstanceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMonitoredObjectsOfInstanceResponse>(response);
        }

        public AsyncInvoker<ListMonitoredObjectsOfInstanceResponse> ListMonitoredObjectsOfInstanceAsyncInvoker(ListMonitoredObjectsOfInstanceRequest listMonitoredObjectsOfInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMonitoredObjectsOfInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dims/monitored-objects/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMonitoredObjectsOfInstanceRequest);
            return new AsyncInvoker<ListMonitoredObjectsOfInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMonitoredObjectsOfInstanceResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNumberOfInstancesInDifferentStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNumberOfInstancesInDifferentStatusResponse>(response);
        }

        public AsyncInvoker<ListNumberOfInstancesInDifferentStatusResponse> ListNumberOfInstancesInDifferentStatusAsyncInvoker(ListNumberOfInstancesInDifferentStatusRequest listNumberOfInstancesInDifferentStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNumberOfInstancesInDifferentStatusRequest);
            return new AsyncInvoker<ListNumberOfInstancesInDifferentStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNumberOfInstancesInDifferentStatusResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRedislogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/redislog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRedislogRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRedislogResponse>(response);
        }

        public AsyncInvoker<ListRedislogResponse> ListRedislogAsyncInvoker(ListRedislogRequest listRedislogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRedislogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/redislog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRedislogRequest);
            return new AsyncInvoker<ListRedislogResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRedislogResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRestoreRecordsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/restores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreRecordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRestoreRecordsResponse>(response);
        }

        public AsyncInvoker<ListRestoreRecordsResponse> ListRestoreRecordsAsyncInvoker(ListRestoreRecordsRequest listRestoreRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRestoreRecordsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/restores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreRecordsRequest);
            return new AsyncInvoker<ListRestoreRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestoreRecordsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowlogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowlogRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSlowlogResponse>(response);
        }

        public AsyncInvoker<ListSlowlogResponse> ListSlowlogAsyncInvoker(ListSlowlogRequest listSlowlogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSlowlogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowlogRequest);
            return new AsyncInvoker<ListSlowlogResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSlowlogResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStatisticsOfRunningInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStatisticsOfRunningInstancesResponse>(response);
        }

        public AsyncInvoker<ListStatisticsOfRunningInstancesResponse> ListStatisticsOfRunningInstancesAsyncInvoker(ListStatisticsOfRunningInstancesRequest listStatisticsOfRunningInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStatisticsOfRunningInstancesRequest);
            return new AsyncInvoker<ListStatisticsOfRunningInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStatisticsOfRunningInstancesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dcs/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsOfTenantRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTagsOfTenantResponse>(response);
        }

        public AsyncInvoker<ListTagsOfTenantResponse> ListTagsOfTenantAsyncInvoker(ListTagsOfTenantRequest listTagsOfTenantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dcs/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsOfTenantRequest);
            return new AsyncInvoker<ListTagsOfTenantResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagsOfTenantResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(loginWebCliRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/webcli/auth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", loginWebCliRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<LoginWebCliResponse>(response);
        }

        public AsyncInvoker<LoginWebCliResponse> LoginWebCliAsyncInvoker(LoginWebCliRequest loginWebCliRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(loginWebCliRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/webcli/auth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", loginWebCliRequest);
            return new AsyncInvoker<LoginWebCliResponse>(this, "POST", request, JsonUtils.DeSerialize<LoginWebCliResponse>);
        }
        
        /// <summary>
        /// 登出webCli
        ///
        /// 登出webCli
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<LogoffWebCliResponse> LogoffWebCliAsync(LogoffWebCliRequest logoffWebCliRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(logoffWebCliRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/webcli/logout", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", logoffWebCliRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<LogoffWebCliResponse>(response);
        }

        public AsyncInvoker<LogoffWebCliResponse> LogoffWebCliAsyncInvoker(LogoffWebCliRequest logoffWebCliRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(logoffWebCliRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/webcli/logout", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", logoffWebCliRequest);
            return new AsyncInvoker<LogoffWebCliResponse>(this, "POST", request, JsonUtils.DeSerializeNull<LogoffWebCliResponse>);
        }
        
        /// <summary>
        /// 变更可用区
        ///
        /// 迁移缓存实例可用区，完成单可用区实例跨可用区改造。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<MigrateAzResponse> MigrateAzAsync(MigrateAzRequest migrateAzRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(migrateAzRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/available-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateAzRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<MigrateAzResponse>(response);
        }

        public AsyncInvoker<MigrateAzResponse> MigrateAzAsyncInvoker(MigrateAzRequest migrateAzRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(migrateAzRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/available-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateAzRequest);
            return new AsyncInvoker<MigrateAzResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<MigrateAzResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetAclAccountPassWordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(resetAclAccountPassWordRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}/password/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetAclAccountPassWordRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ResetAclAccountPassWordResponse>(response);
        }

        public AsyncInvoker<ResetAclAccountPassWordResponse> ResetAclAccountPassWordAsyncInvoker(ResetAclAccountPassWordRequest resetAclAccountPassWordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetAclAccountPassWordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(resetAclAccountPassWordRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}/password/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetAclAccountPassWordRequest);
            return new AsyncInvoker<ResetAclAccountPassWordResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResetAclAccountPassWordResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetPasswordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/password/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetPasswordRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResetPasswordResponse>(response);
        }

        public AsyncInvoker<ResetPasswordResponse> ResetPasswordAsyncInvoker(ResetPasswordRequest resetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetPasswordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/password/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetPasswordRequest);
            return new AsyncInvoker<ResetPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetPasswordResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resizeInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ResizeInstanceResponse>(response);
        }

        public AsyncInvoker<ResizeInstanceResponse> ResizeInstanceAsyncInvoker(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resizeInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeInstanceRequest);
            return new AsyncInvoker<ResizeInstanceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResizeInstanceResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restartOrFlushInstancesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<RestartOrFlushInstancesResponse>(response);
        }

        public AsyncInvoker<RestartOrFlushInstancesResponse> RestartOrFlushInstancesAsyncInvoker(RestartOrFlushInstancesRequest restartOrFlushInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restartOrFlushInstancesRequest);
            return new AsyncInvoker<RestartOrFlushInstancesResponse>(this, "PUT", request, JsonUtils.DeSerialize<RestartOrFlushInstancesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/restores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RestoreInstanceResponse>(response);
        }

        public AsyncInvoker<RestoreInstanceResponse> RestoreInstanceAsyncInvoker(RestoreInstanceRequest restoreInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/restores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreInstanceRequest);
            return new AsyncInvoker<RestoreInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreInstanceResponse>);
        }
        
        /// <summary>
        /// IP交换回滚
        ///
        /// IP交换回滚。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RollbackExchangeInstanceIpResponse> RollbackExchangeInstanceIpAsync(RollbackExchangeInstanceIpRequest rollbackExchangeInstanceIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rollbackExchangeInstanceIpRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/rollback-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollbackExchangeInstanceIpRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<RollbackExchangeInstanceIpResponse>(response);
        }

        public AsyncInvoker<RollbackExchangeInstanceIpResponse> RollbackExchangeInstanceIpAsyncInvoker(RollbackExchangeInstanceIpRequest rollbackExchangeInstanceIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rollbackExchangeInstanceIpRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/rollback-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollbackExchangeInstanceIpRequest);
            return new AsyncInvoker<RollbackExchangeInstanceIpResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RollbackExchangeInstanceIpResponse>);
        }
        
        /// <summary>
        /// 下发查询会话列表任务
        ///
        /// 下发查询会话列表任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ScanClientsResponse> ScanClientsAsync(ScanClientsRequest scanClientsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(scanClientsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/clients", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", scanClientsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ScanClientsResponse>(response);
        }

        public AsyncInvoker<ScanClientsResponse> ScanClientsAsyncInvoker(ScanClientsRequest scanClientsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(scanClientsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/clients", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", scanClientsRequest);
            return new AsyncInvoker<ScanClientsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ScanClientsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(scanExpireKeyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/auto-expire/scan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", scanExpireKeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ScanExpireKeyResponse>(response);
        }

        public AsyncInvoker<ScanExpireKeyResponse> ScanExpireKeyAsyncInvoker(ScanExpireKeyRequest scanExpireKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(scanExpireKeyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/auto-expire/scan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", scanExpireKeyRequest);
            return new AsyncInvoker<ScanExpireKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<ScanExpireKeyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setOnlineMigrationTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration/{task_id}/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setOnlineMigrationTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetOnlineMigrationTaskResponse>(response);
        }

        public AsyncInvoker<SetOnlineMigrationTaskResponse> SetOnlineMigrationTaskAsyncInvoker(SetOnlineMigrationTaskRequest setOnlineMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setOnlineMigrationTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration/{task_id}/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setOnlineMigrationTaskRequest);
            return new AsyncInvoker<SetOnlineMigrationTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<SetOnlineMigrationTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBackgroundTaskProgressRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showBackgroundTaskProgressRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}/progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackgroundTaskProgressRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBackgroundTaskProgressResponse>(response);
        }

        public AsyncInvoker<ShowBackgroundTaskProgressResponse> ShowBackgroundTaskProgressAsyncInvoker(ShowBackgroundTaskProgressRequest showBackgroundTaskProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBackgroundTaskProgressRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showBackgroundTaskProgressRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}/progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackgroundTaskProgressRequest);
            return new AsyncInvoker<ShowBackgroundTaskProgressResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackgroundTaskProgressResponse>);
        }
        
        /// <summary>
        /// 获取实例分片带宽
        ///
        /// 获取实例各个分片带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBandwidthsResponse> ShowBandwidthsAsync(ShowBandwidthsRequest showBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBandwidthsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBandwidthsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBandwidthsResponse>(response);
        }

        public AsyncInvoker<ShowBandwidthsResponse> ShowBandwidthsAsyncInvoker(ShowBandwidthsRequest showBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBandwidthsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBandwidthsRequest);
            return new AsyncInvoker<ShowBandwidthsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBandwidthsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBigkeyAutoscanConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey/autoscan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBigkeyAutoscanConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBigkeyAutoscanConfigResponse>(response);
        }

        public AsyncInvoker<ShowBigkeyAutoscanConfigResponse> ShowBigkeyAutoscanConfigAsyncInvoker(ShowBigkeyAutoscanConfigRequest showBigkeyAutoscanConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBigkeyAutoscanConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey/autoscan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBigkeyAutoscanConfigRequest);
            return new AsyncInvoker<ShowBigkeyAutoscanConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBigkeyAutoscanConfigResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBigkeyScanTaskDetailsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showBigkeyScanTaskDetailsRequest.BigkeyId, out var valueOfBigkeyId)) urlParam.Add("bigkey_id", valueOfBigkeyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey-task/{bigkey_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBigkeyScanTaskDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBigkeyScanTaskDetailsResponse>(response);
        }

        public AsyncInvoker<ShowBigkeyScanTaskDetailsResponse> ShowBigkeyScanTaskDetailsAsyncInvoker(ShowBigkeyScanTaskDetailsRequest showBigkeyScanTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBigkeyScanTaskDetailsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showBigkeyScanTaskDetailsRequest.BigkeyId, out var valueOfBigkeyId)) urlParam.Add("bigkey_id", valueOfBigkeyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey-task/{bigkey_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBigkeyScanTaskDetailsRequest);
            return new AsyncInvoker<ShowBigkeyScanTaskDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBigkeyScanTaskDetailsResponse>);
        }
        
        /// <summary>
        /// 查询实例参数修改记录详情
        ///
        /// 查询实例参数修改记录详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowConfigHistoryDetailResponse> ShowConfigHistoryDetailAsync(ShowConfigHistoryDetailRequest showConfigHistoryDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigHistoryDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showConfigHistoryDetailRequest.HistoryId, out var valueOfHistoryId)) urlParam.Add("history_id", valueOfHistoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/config-histories/{history_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigHistoryDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerializeNull<ShowConfigHistoryDetailResponse>(response);
        }

        public AsyncInvoker<ShowConfigHistoryDetailResponse> ShowConfigHistoryDetailAsyncInvoker(ShowConfigHistoryDetailRequest showConfigHistoryDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigHistoryDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showConfigHistoryDetailRequest.HistoryId, out var valueOfHistoryId)) urlParam.Add("history_id", valueOfHistoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/config-histories/{history_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigHistoryDetailRequest);
            return new AsyncInvoker<ShowConfigHistoryDetailResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ShowConfigHistoryDetailResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigTemplateResponse>(response);
        }

        public AsyncInvoker<ShowConfigTemplateResponse> ShowConfigTemplateAsyncInvoker(ShowConfigTemplateRequest showConfigTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigTemplateRequest);
            return new AsyncInvoker<ShowConfigTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigTemplateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDiagnosisTaskDetailsRequest.ReportId, out var valueOfReportId)) urlParam.Add("report_id", valueOfReportId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/diagnosis/{report_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiagnosisTaskDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDiagnosisTaskDetailsResponse>(response);
        }

        public AsyncInvoker<ShowDiagnosisTaskDetailsResponse> ShowDiagnosisTaskDetailsAsyncInvoker(ShowDiagnosisTaskDetailsRequest showDiagnosisTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDiagnosisTaskDetailsRequest.ReportId, out var valueOfReportId)) urlParam.Add("report_id", valueOfReportId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/diagnosis/{report_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiagnosisTaskDetailsRequest);
            return new AsyncInvoker<ShowDiagnosisTaskDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDiagnosisTaskDetailsResponse>);
        }
        
        /// <summary>
        /// 查询自动扫描配置
        ///
        /// 查询自动扫描配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowExpireAutoScanConfigResponse> ShowExpireAutoScanConfigAsync(ShowExpireAutoScanConfigRequest showExpireAutoScanConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showExpireAutoScanConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/scan-expire-keys/autoscan-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExpireAutoScanConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowExpireAutoScanConfigResponse>(response);
        }

        public AsyncInvoker<ShowExpireAutoScanConfigResponse> ShowExpireAutoScanConfigAsyncInvoker(ShowExpireAutoScanConfigRequest showExpireAutoScanConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showExpireAutoScanConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/scan-expire-keys/autoscan-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExpireAutoScanConfigRequest);
            return new AsyncInvoker<ShowExpireAutoScanConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowExpireAutoScanConfigResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showExpireKeyScanInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/auto-expire/histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExpireKeyScanInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowExpireKeyScanInfoResponse>(response);
        }

        public AsyncInvoker<ShowExpireKeyScanInfoResponse> ShowExpireKeyScanInfoAsyncInvoker(ShowExpireKeyScanInfoRequest showExpireKeyScanInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showExpireKeyScanInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/auto-expire/histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExpireKeyScanInfoRequest);
            return new AsyncInvoker<ShowExpireKeyScanInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowExpireKeyScanInfoResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHotkeyAutoscanConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey/autoscan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotkeyAutoscanConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowHotkeyAutoscanConfigResponse>(response);
        }

        public AsyncInvoker<ShowHotkeyAutoscanConfigResponse> ShowHotkeyAutoscanConfigAsyncInvoker(ShowHotkeyAutoscanConfigRequest showHotkeyAutoscanConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHotkeyAutoscanConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey/autoscan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotkeyAutoscanConfigRequest);
            return new AsyncInvoker<ShowHotkeyAutoscanConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHotkeyAutoscanConfigResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHotkeyTaskDetailsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showHotkeyTaskDetailsRequest.HotkeyId, out var valueOfHotkeyId)) urlParam.Add("hotkey_id", valueOfHotkeyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey-task/{hotkey_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotkeyTaskDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowHotkeyTaskDetailsResponse>(response);
        }

        public AsyncInvoker<ShowHotkeyTaskDetailsResponse> ShowHotkeyTaskDetailsAsyncInvoker(ShowHotkeyTaskDetailsRequest showHotkeyTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHotkeyTaskDetailsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showHotkeyTaskDetailsRequest.HotkeyId, out var valueOfHotkeyId)) urlParam.Add("hotkey_id", valueOfHotkeyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey-task/{hotkey_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotkeyTaskDetailsRequest);
            return new AsyncInvoker<ShowHotkeyTaskDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHotkeyTaskDetailsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceResponse>(response);
        }

        public AsyncInvoker<ShowInstanceResponse> ShowInstanceAsyncInvoker(ShowInstanceRequest showInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            return new AsyncInvoker<ShowInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceResponse>);
        }
        
        /// <summary>
        /// 查询实例带宽弹性伸缩策略
        ///
        /// 查询实例带宽弹性伸缩策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceBandwidthAutoScalingPolicyResponse> ShowInstanceBandwidthAutoScalingPolicyAsync(ShowInstanceBandwidthAutoScalingPolicyRequest showInstanceBandwidthAutoScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceBandwidthAutoScalingPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/autoscaling-policy/bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceBandwidthAutoScalingPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceBandwidthAutoScalingPolicyResponse>(response);
        }

        public AsyncInvoker<ShowInstanceBandwidthAutoScalingPolicyResponse> ShowInstanceBandwidthAutoScalingPolicyAsyncInvoker(ShowInstanceBandwidthAutoScalingPolicyRequest showInstanceBandwidthAutoScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceBandwidthAutoScalingPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/autoscaling-policy/bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceBandwidthAutoScalingPolicyRequest);
            return new AsyncInvoker<ShowInstanceBandwidthAutoScalingPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceBandwidthAutoScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 查询实例SSL信息
        ///
        /// 查询实例SSL信息。该接口目前仅针对Redis 6.0[基础版](tag:hws,hws_hk)版本实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceSslDetailResponse> ShowInstanceSslDetailAsync(ShowInstanceSslDetailRequest showInstanceSslDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceSslDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceSslDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceSslDetailResponse>(response);
        }

        public AsyncInvoker<ShowInstanceSslDetailResponse> ShowInstanceSslDetailAsyncInvoker(ShowInstanceSslDetailRequest showInstanceSslDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceSslDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceSslDetailRequest);
            return new AsyncInvoker<ShowInstanceSslDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceSslDetailResponse>);
        }
        
        /// <summary>
        /// 查询集群实例拓扑关系图
        ///
        /// 查询集群实例拓扑关系图。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceTopologyResponse> ShowInstanceTopologyAsync(ShowInstanceTopologyRequest showInstanceTopologyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceTopologyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceTopologyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceTopologyResponse>(response);
        }

        public AsyncInvoker<ShowInstanceTopologyResponse> ShowInstanceTopologyAsyncInvoker(ShowInstanceTopologyRequest showInstanceTopologyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceTopologyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceTopologyRequest);
            return new AsyncInvoker<ShowInstanceTopologyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceTopologyResponse>);
        }
        
        /// <summary>
        /// 根据实例ID获取实例内核版本信息
        ///
        /// 获取对应实例内核版本号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceVersionResponse> ShowInstanceVersionAsync(ShowInstanceVersionRequest showInstanceVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceVersionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceVersionResponse>(response);
        }

        public AsyncInvoker<ShowInstanceVersionResponse> ShowInstanceVersionAsyncInvoker(ShowInstanceVersionRequest showInstanceVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceVersionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceVersionRequest);
            return new AsyncInvoker<ShowInstanceVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceVersionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobInfoRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobInfoResponse>(response);
        }

        public AsyncInvoker<ShowJobInfoResponse> ShowJobInfoAsyncInvoker(ShowJobInfoRequest showJobInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobInfoRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobInfoRequest);
            return new AsyncInvoker<ShowJobInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobInfoResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMigrationTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMigrationTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMigrationTaskResponse>(response);
        }

        public AsyncInvoker<ShowMigrationTaskResponse> ShowMigrationTaskAsyncInvoker(ShowMigrationTaskRequest showMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMigrationTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMigrationTaskRequest);
            return new AsyncInvoker<ShowMigrationTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMigrationTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMigrationTaskStatsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMigrationTaskStatsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMigrationTaskStatsResponse>(response);
        }

        public AsyncInvoker<ShowMigrationTaskStatsResponse> ShowMigrationTaskStatsAsyncInvoker(ShowMigrationTaskStatsRequest showMigrationTaskStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMigrationTaskStatsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMigrationTaskStatsRequest);
            return new AsyncInvoker<ShowMigrationTaskStatsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMigrationTaskStatsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNodesInformationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/logical-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodesInformationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNodesInformationResponse>(response);
        }

        public AsyncInvoker<ShowNodesInformationResponse> ShowNodesInformationAsyncInvoker(ShowNodesInformationRequest showNodesInformationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNodesInformationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/logical-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodesInformationRequest);
            return new AsyncInvoker<ShowNodesInformationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNodesInformationResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaOfTenantRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotaOfTenantResponse>(response);
        }

        public AsyncInvoker<ShowQuotaOfTenantResponse> ShowQuotaOfTenantAsyncInvoker(ShowQuotaOfTenantRequest showQuotaOfTenantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaOfTenantRequest);
            return new AsyncInvoker<ShowQuotaOfTenantResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotaOfTenantResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReplicationStatesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showReplicationStatesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/groups/{group_id}/group-nodes-state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplicationStatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showReplicationStatesResponse = JsonUtils.DeSerializeNull<ShowReplicationStatesResponse>(response);
            showReplicationStatesResponse.Body = JsonUtils.DeSerializeList<InstanceReplicationListInfo>(response);
            return showReplicationStatesResponse;
        }

        public AsyncInvoker<ShowReplicationStatesResponse> ShowReplicationStatesAsyncInvoker(ShowReplicationStatesRequest showReplicationStatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReplicationStatesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showReplicationStatesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/groups/{group_id}/group-nodes-state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplicationStatesRequest);
            return new AsyncInvoker<ShowReplicationStatesResponse>(this, "GET", request, response =>
            {
                var showReplicationStatesResponse = JsonUtils.DeSerializeNull<ShowReplicationStatesResponse>(response);
                showReplicationStatesResponse.Body = JsonUtils.DeSerializeList<InstanceReplicationListInfo>(response);
                return showReplicationStatesResponse;
            });
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTagsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTagsResponse>(response);
        }

        public AsyncInvoker<ShowTagsResponse> ShowTagsAsyncInvoker(ShowTagsRequest showTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTagsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagsRequest);
            return new AsyncInvoker<ShowTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startInstanceResizeCheckJobRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/resize/check-job", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startInstanceResizeCheckJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartInstanceResizeCheckJobResponse>(response);
        }

        public AsyncInvoker<StartInstanceResizeCheckJobResponse> StartInstanceResizeCheckJobAsyncInvoker(StartInstanceResizeCheckJobRequest startInstanceResizeCheckJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startInstanceResizeCheckJobRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/resize/check-job", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startInstanceResizeCheckJobRequest);
            return new AsyncInvoker<StartInstanceResizeCheckJobResponse>(this, "POST", request, JsonUtils.DeSerialize<StartInstanceResizeCheckJobResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopMigrationTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopMigrationTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopMigrationTaskResponse>(response);
        }

        public AsyncInvoker<StopMigrationTaskResponse> StopMigrationTaskAsyncInvoker(StopMigrationTaskRequest stopMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopMigrationTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopMigrationTaskRequest);
            return new AsyncInvoker<StopMigrationTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<StopMigrationTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopMigrationTaskSyncRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/sync-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopMigrationTaskSyncRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<StopMigrationTaskSyncResponse>(response);
        }

        public AsyncInvoker<StopMigrationTaskSyncResponse> StopMigrationTaskSyncAsyncInvoker(StopMigrationTaskSyncRequest stopMigrationTaskSyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopMigrationTaskSyncRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/sync-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopMigrationTaskSyncRequest);
            return new AsyncInvoker<StopMigrationTaskSyncResponse>(this, "POST", request, JsonUtils.DeSerializeNull<StopMigrationTaskSyncResponse>);
        }
        
        /// <summary>
        /// 修改ACL角色
        ///
        /// 修改用户的类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAclAccountResponse> UpdateAclAccountAsync(UpdateAclAccountRequest updateAclAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAclAccountRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateAclAccountRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}/role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAclAccountRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAclAccountResponse>(response);
        }

        public AsyncInvoker<UpdateAclAccountResponse> UpdateAclAccountAsyncInvoker(UpdateAclAccountRequest updateAclAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAclAccountRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateAclAccountRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}/role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAclAccountRequest);
            return new AsyncInvoker<UpdateAclAccountResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAclAccountResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAclAccountPassWordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateAclAccountPassWordRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}/password/modify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAclAccountPassWordRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAclAccountPassWordResponse>(response);
        }

        public AsyncInvoker<UpdateAclAccountPassWordResponse> UpdateAclAccountPassWordAsyncInvoker(UpdateAclAccountPassWordRequest updateAclAccountPassWordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAclAccountPassWordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateAclAccountPassWordRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}/password/modify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAclAccountPassWordRequest);
            return new AsyncInvoker<UpdateAclAccountPassWordResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAclAccountPassWordResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAclAccountRemarkRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateAclAccountRemarkRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAclAccountRemarkRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAclAccountRemarkResponse>(response);
        }

        public AsyncInvoker<UpdateAclAccountRemarkResponse> UpdateAclAccountRemarkAsyncInvoker(UpdateAclAccountRemarkRequest updateAclAccountRemarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAclAccountRemarkRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateAclAccountRemarkRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAclAccountRemarkRequest);
            return new AsyncInvoker<UpdateAclAccountRemarkResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAclAccountRemarkResponse>);
        }
        
        /// <summary>
        /// 修改实例分片带宽
        ///
        /// 修改实例分片带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateBandwidthResponse> UpdateBandwidthAsync(UpdateBandwidthRequest updateBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateBandwidthRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBandwidthRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateBandwidthResponse>(response);
        }

        public AsyncInvoker<UpdateBandwidthResponse> UpdateBandwidthAsyncInvoker(UpdateBandwidthRequest updateBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateBandwidthRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBandwidthRequest);
            return new AsyncInvoker<UpdateBandwidthResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateBandwidthResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateBigkeyAutoscanConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey/autoscan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBigkeyAutoscanConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateBigkeyAutoscanConfigResponse>(response);
        }

        public AsyncInvoker<UpdateBigkeyAutoscanConfigResponse> UpdateBigkeyAutoscanConfigAsyncInvoker(UpdateBigkeyAutoscanConfigRequest updateBigkeyAutoscanConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateBigkeyAutoscanConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey/autoscan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBigkeyAutoscanConfigRequest);
            return new AsyncInvoker<UpdateBigkeyAutoscanConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateBigkeyAutoscanConfigResponse>);
        }
        
        /// <summary>
        /// 开启或关闭客户端ip透传
        ///
        /// 开启或关闭客户端ip透传
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateClientIpTransparentTransmissionResponse> UpdateClientIpTransparentTransmissionAsync(UpdateClientIpTransparentTransmissionRequest updateClientIpTransparentTransmissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClientIpTransparentTransmissionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/client-ip-transparent-transmission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateClientIpTransparentTransmissionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateClientIpTransparentTransmissionResponse>(response);
        }

        public AsyncInvoker<UpdateClientIpTransparentTransmissionResponse> UpdateClientIpTransparentTransmissionAsyncInvoker(UpdateClientIpTransparentTransmissionRequest updateClientIpTransparentTransmissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClientIpTransparentTransmissionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/client-ip-transparent-transmission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateClientIpTransparentTransmissionRequest);
            return new AsyncInvoker<UpdateClientIpTransparentTransmissionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateClientIpTransparentTransmissionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateConfigTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateConfigTemplateRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateConfigTemplateResponse>(response);
        }

        public AsyncInvoker<UpdateConfigTemplateResponse> UpdateConfigTemplateAsyncInvoker(UpdateConfigTemplateRequest updateConfigTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateConfigTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateConfigTemplateRequest);
            return new AsyncInvoker<UpdateConfigTemplateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateConfigTemplateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateConfigurationsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateConfigurationsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateConfigurationsResponse>(response);
        }

        public AsyncInvoker<UpdateConfigurationsResponse> UpdateConfigurationsAsyncInvoker(UpdateConfigurationsRequest updateConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateConfigurationsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateConfigurationsRequest);
            return new AsyncInvoker<UpdateConfigurationsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateConfigurationsResponse>);
        }
        
        /// <summary>
        /// 修改自动扫描配置
        ///
        /// 修改自动扫描配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateExpireAutoScanConfigResponse> UpdateExpireAutoScanConfigAsync(UpdateExpireAutoScanConfigRequest updateExpireAutoScanConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateExpireAutoScanConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/scan-expire-keys/autoscan-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateExpireAutoScanConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateExpireAutoScanConfigResponse>(response);
        }

        public AsyncInvoker<UpdateExpireAutoScanConfigResponse> UpdateExpireAutoScanConfigAsyncInvoker(UpdateExpireAutoScanConfigRequest updateExpireAutoScanConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateExpireAutoScanConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/scan-expire-keys/autoscan-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateExpireAutoScanConfigRequest);
            return new AsyncInvoker<UpdateExpireAutoScanConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateExpireAutoScanConfigResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHotkeyAutoScanConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey/autoscan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateHotkeyAutoScanConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHotkeyAutoScanConfigResponse>(response);
        }

        public AsyncInvoker<UpdateHotkeyAutoScanConfigResponse> UpdateHotkeyAutoScanConfigAsyncInvoker(UpdateHotkeyAutoScanConfigRequest updateHotkeyAutoScanConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHotkeyAutoScanConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey/autoscan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateHotkeyAutoScanConfigRequest);
            return new AsyncInvoker<UpdateHotkeyAutoScanConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHotkeyAutoScanConfigResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceResponse> UpdateInstanceAsyncInvoker(UpdateInstanceRequest updateInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceRequest);
            return new AsyncInvoker<UpdateInstanceResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceBandwidthRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceBandwidthRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceBandwidthResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceBandwidthResponse> UpdateInstanceBandwidthAsyncInvoker(UpdateInstanceBandwidthRequest updateInstanceBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceBandwidthRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceBandwidthRequest);
            return new AsyncInvoker<UpdateInstanceBandwidthResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceBandwidthResponse>);
        }
        
        /// <summary>
        /// 更新实例带宽弹性伸缩策略
        ///
        /// 更新实例带宽弹性伸缩策略。暂不支持实例带宽自动回缩。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceBandwidthAutoScalingPolicyResponse> UpdateInstanceBandwidthAutoScalingPolicyAsync(UpdateInstanceBandwidthAutoScalingPolicyRequest updateInstanceBandwidthAutoScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceBandwidthAutoScalingPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/autoscaling-policy/bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceBandwidthAutoScalingPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceBandwidthAutoScalingPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceBandwidthAutoScalingPolicyResponse> UpdateInstanceBandwidthAutoScalingPolicyAsyncInvoker(UpdateInstanceBandwidthAutoScalingPolicyRequest updateInstanceBandwidthAutoScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceBandwidthAutoScalingPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/autoscaling-policy/bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceBandwidthAutoScalingPolicyRequest);
            return new AsyncInvoker<UpdateInstanceBandwidthAutoScalingPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceBandwidthAutoScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 异步修改实例配置参数
        ///
        /// 为了确保分布式缓存服务发挥出最优性能，您可以根据自己的业务情况对DCS缓存实例的运行参数进行调整。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceConfigResponse> UpdateInstanceConfigAsync(UpdateInstanceConfigRequest updateInstanceConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/async-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceConfigResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceConfigResponse> UpdateInstanceConfigAsyncInvoker(UpdateInstanceConfigRequest updateInstanceConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/async-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceConfigRequest);
            return new AsyncInvoker<UpdateInstanceConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceConfigResponse>);
        }
        
        /// <summary>
        /// 设置IP白名单分组异步接口
        ///
        /// 为指定实例设置IP白名单分组，包含创建、停用、编辑、删除白名单四个功能。返回异步任务jobId，设置白名单分组信息会覆盖掉已有的白名单信息，因此在新增IP白名单分组时，需保留已有的白名单信息后再编辑新的白名单分组信息。
        /// [仅Redis 4.0及以上版本的实例支持设置IP白名单分组，Redis 3.0实例不支持该功能。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateIpWhitelistAsyncResponse> UpdateIpWhitelistAsyncAsync(UpdateIpWhitelistAsyncRequest updateIpWhitelistAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIpWhitelistAsyncRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/whitelist-async", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpWhitelistAsyncRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateIpWhitelistAsyncResponse>(response);
        }

        public AsyncInvoker<UpdateIpWhitelistAsyncResponse> UpdateIpWhitelistAsyncAsyncInvoker(UpdateIpWhitelistAsyncRequest updateIpWhitelistAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIpWhitelistAsyncRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/whitelist-async", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpWhitelistAsyncRequest);
            return new AsyncInvoker<UpdateIpWhitelistAsyncResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateIpWhitelistAsyncResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMigrationTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMigrationTaskRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateMigrationTaskResponse>(response);
        }

        public AsyncInvoker<UpdateMigrationTaskResponse> UpdateMigrationTaskAsyncInvoker(UpdateMigrationTaskRequest updateMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMigrationTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMigrationTaskRequest);
            return new AsyncInvoker<UpdateMigrationTaskResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateMigrationTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePasswordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePasswordRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePasswordResponse>(response);
        }

        public AsyncInvoker<UpdatePasswordResponse> UpdatePasswordAsyncInvoker(UpdatePasswordRequest updatePasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePasswordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePasswordRequest);
            return new AsyncInvoker<UpdatePasswordResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePasswordResponse>);
        }
        
        /// <summary>
        /// 开启/修改实例公网访问
        ///
        /// 开启/修改实例公网访问。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePublicIpResponse> UpdatePublicIpAsync(UpdatePublicIpRequest updatePublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePublicIpRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePublicIpRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdatePublicIpResponse>(response);
        }

        public AsyncInvoker<UpdatePublicIpResponse> UpdatePublicIpAsyncInvoker(UpdatePublicIpRequest updatePublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePublicIpRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePublicIpRequest);
            return new AsyncInvoker<UpdatePublicIpResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdatePublicIpResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSlavePriorityRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateSlavePriorityRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateSlavePriorityRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group_id}/replications/{node_id}/slave-priority", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSlavePriorityRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateSlavePriorityResponse>(response);
        }

        public AsyncInvoker<UpdateSlavePriorityResponse> UpdateSlavePriorityAsyncInvoker(UpdateSlavePriorityRequest updateSlavePriorityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSlavePriorityRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateSlavePriorityRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateSlavePriorityRequest.NodeId, out var valueOfNodeId)) urlParam.Add("node_id", valueOfNodeId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group_id}/replications/{node_id}/slave-priority", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSlavePriorityRequest);
            return new AsyncInvoker<UpdateSlavePriorityResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateSlavePriorityResponse>);
        }
        
        /// <summary>
        /// 开启/关闭SSL
        ///
        /// 开启/关闭SSL。该接口目前仅针对Redis 6.0[基础版](tag:hws,hws_hk)版本实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSslSwitchResponse> UpdateSslSwitchAsync(UpdateSslSwitchRequest updateSslSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSslSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSslSwitchRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSslSwitchResponse>(response);
        }

        public AsyncInvoker<UpdateSslSwitchResponse> UpdateSslSwitchAsyncInvoker(UpdateSslSwitchRequest updateSslSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSslSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSslSwitchRequest);
            return new AsyncInvoker<UpdateSslSwitchResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSslSwitchResponse>);
        }
        
        /// <summary>
        /// 升级实例小版本
        ///
        /// 升级实例小版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpgradeInstanceMinorVersionResponse> UpgradeInstanceMinorVersionAsync(UpgradeInstanceMinorVersionRequest upgradeInstanceMinorVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeInstanceMinorVersionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/minor-version/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeInstanceMinorVersionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpgradeInstanceMinorVersionResponse>(response);
        }

        public AsyncInvoker<UpgradeInstanceMinorVersionResponse> UpgradeInstanceMinorVersionAsyncInvoker(UpgradeInstanceMinorVersionRequest upgradeInstanceMinorVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeInstanceMinorVersionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/minor-version/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeInstanceMinorVersionRequest);
            return new AsyncInvoker<UpgradeInstanceMinorVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeInstanceMinorVersionResponse>);
        }
        
        /// <summary>
        /// 校验集群副本是否支持删除
        ///
        /// 校验集群副本是否支持删除
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ValidateDeletableReplicaResponse> ValidateDeletableReplicaAsync(ValidateDeletableReplicaRequest validateDeletableReplicaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(validateDeletableReplicaRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/deletable-replication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateDeletableReplicaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ValidateDeletableReplicaResponse>(response);
        }

        public AsyncInvoker<ValidateDeletableReplicaResponse> ValidateDeletableReplicaAsyncInvoker(ValidateDeletableReplicaRequest validateDeletableReplicaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(validateDeletableReplicaRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/deletable-replication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateDeletableReplicaRequest);
            return new AsyncInvoker<ValidateDeletableReplicaResponse>(this, "GET", request, JsonUtils.DeSerialize<ValidateDeletableReplicaResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIpWhitelistRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/whitelist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpWhitelistRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowIpWhitelistResponse>(response);
        }

        public AsyncInvoker<ShowIpWhitelistResponse> ShowIpWhitelistAsyncInvoker(ShowIpWhitelistRequest showIpWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIpWhitelistRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/whitelist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpWhitelistRequest);
            return new AsyncInvoker<ShowIpWhitelistResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIpWhitelistResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIpWhitelistRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/whitelist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpWhitelistRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateIpWhitelistResponse>(response);
        }

        public AsyncInvoker<UpdateIpWhitelistResponse> UpdateIpWhitelistAsyncInvoker(UpdateIpWhitelistRequest updateIpWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIpWhitelistRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/whitelist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpWhitelistRequest);
            return new AsyncInvoker<UpdateIpWhitelistResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateIpWhitelistResponse>);
        }
        
        /// <summary>
        /// 创建离线全量key分析任务
        ///
        /// 创建离线全量key分析任务。离线全量key分析用于分析实例指定节点备份文件中的TOP100大key，每种数据类型前缀数量TOP50的key和每种数据类型key的内存占用和数量的分布情况。仅Redis 4.0、5.0、6.0版本及Redis企业版实例支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateOfflineKeyAnalysisResponse> CreateOfflineKeyAnalysisAsync(CreateOfflineKeyAnalysisRequest createOfflineKeyAnalysisRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createOfflineKeyAnalysisRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/offline/key-analysis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOfflineKeyAnalysisRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateOfflineKeyAnalysisResponse>(response);
        }

        public AsyncInvoker<CreateOfflineKeyAnalysisResponse> CreateOfflineKeyAnalysisAsyncInvoker(CreateOfflineKeyAnalysisRequest createOfflineKeyAnalysisRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createOfflineKeyAnalysisRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/offline/key-analysis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOfflineKeyAnalysisRequest);
            return new AsyncInvoker<CreateOfflineKeyAnalysisResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOfflineKeyAnalysisResponse>);
        }
        
        /// <summary>
        /// 删除离线全量key分析记录
        ///
        /// 删除离线全量key分析记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteOfflineKeyAnalysisTaskResponse> DeleteOfflineKeyAnalysisTaskAsync(DeleteOfflineKeyAnalysisTaskRequest deleteOfflineKeyAnalysisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOfflineKeyAnalysisTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteOfflineKeyAnalysisTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/offline/key-analysis/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOfflineKeyAnalysisTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteOfflineKeyAnalysisTaskResponse>(response);
        }

        public AsyncInvoker<DeleteOfflineKeyAnalysisTaskResponse> DeleteOfflineKeyAnalysisTaskAsyncInvoker(DeleteOfflineKeyAnalysisTaskRequest deleteOfflineKeyAnalysisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOfflineKeyAnalysisTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteOfflineKeyAnalysisTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/offline/key-analysis/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOfflineKeyAnalysisTaskRequest);
            return new AsyncInvoker<DeleteOfflineKeyAnalysisTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteOfflineKeyAnalysisTaskResponse>);
        }
        
        /// <summary>
        /// 查询离线全量key分析任务列表
        ///
        /// 查询离线全量key分析任务列表，支持Redis4.0、5.0、6.0版本及Redis企业版。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOfflineKeyAnalysisTaskResponse> ListOfflineKeyAnalysisTaskAsync(ListOfflineKeyAnalysisTaskRequest listOfflineKeyAnalysisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOfflineKeyAnalysisTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/offline/key-analysis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOfflineKeyAnalysisTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOfflineKeyAnalysisTaskResponse>(response);
        }

        public AsyncInvoker<ListOfflineKeyAnalysisTaskResponse> ListOfflineKeyAnalysisTaskAsyncInvoker(ListOfflineKeyAnalysisTaskRequest listOfflineKeyAnalysisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOfflineKeyAnalysisTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/offline/key-analysis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOfflineKeyAnalysisTaskRequest);
            return new AsyncInvoker<ListOfflineKeyAnalysisTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOfflineKeyAnalysisTaskResponse>);
        }
        
        /// <summary>
        /// 查询离线全量key分析详情
        ///
        /// 查询离线全量key分析详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOfflineKeyAnalysisTaskResponse> ShowOfflineKeyAnalysisTaskAsync(ShowOfflineKeyAnalysisTaskRequest showOfflineKeyAnalysisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOfflineKeyAnalysisTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showOfflineKeyAnalysisTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/offline/key-analysis/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOfflineKeyAnalysisTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOfflineKeyAnalysisTaskResponse>(response);
        }

        public AsyncInvoker<ShowOfflineKeyAnalysisTaskResponse> ShowOfflineKeyAnalysisTaskAsyncInvoker(ShowOfflineKeyAnalysisTaskRequest showOfflineKeyAnalysisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOfflineKeyAnalysisTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showOfflineKeyAnalysisTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/offline/key-analysis/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOfflineKeyAnalysisTaskRequest);
            return new AsyncInvoker<ShowOfflineKeyAnalysisTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOfflineKeyAnalysisTaskResponse>);
        }
        
    }
}