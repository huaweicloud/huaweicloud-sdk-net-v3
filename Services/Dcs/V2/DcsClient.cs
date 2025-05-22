using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Dcs.V2.Model;

namespace HuaweiCloud.SDK.Dcs.V2
{
    public partial class DcsClient : Client
    {
        public static ClientBuilder<DcsClient> NewBuilder()
        {
            return new ClientBuilder<DcsClient>();
        }

        
        /// <summary>
        /// 批量添加或删除标签
        ///
        /// 为指定实例批量添加标签，或批量删除标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateOrDeleteTagsResponse BatchCreateOrDeleteTags(BatchCreateOrDeleteTagsRequest batchCreateOrDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchCreateOrDeleteTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dcs/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateOrDeleteTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateOrDeleteTagsResponse> BatchCreateOrDeleteTagsInvoker(BatchCreateOrDeleteTagsRequest batchCreateOrDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchCreateOrDeleteTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dcs/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateOrDeleteTagsRequest);
            return new SyncInvoker<BatchCreateOrDeleteTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateOrDeleteTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除实例
        ///
        /// 批量删除多个缓存实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteInstancesResponse BatchDeleteInstances(BatchDeleteInstancesRequest batchDeleteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteInstancesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteInstancesResponse>(response);
        }

        public SyncInvoker<BatchDeleteInstancesResponse> BatchDeleteInstancesInvoker(BatchDeleteInstancesRequest batchDeleteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteInstancesRequest);
            return new SyncInvoker<BatchDeleteInstancesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteInstancesResponse>);
        }
        
        /// <summary>
        /// 批量重启在线迁移任务
        ///
        /// 批量重启在线迁移任务，接口响应成功，返回重启在线迁移任务下发结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchRestartOnlineMigrationTasksResponse BatchRestartOnlineMigrationTasks(BatchRestartOnlineMigrationTasksRequest batchRestartOnlineMigrationTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-tasks/batch-restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRestartOnlineMigrationTasksRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchRestartOnlineMigrationTasksResponse>(response);
        }

        public SyncInvoker<BatchRestartOnlineMigrationTasksResponse> BatchRestartOnlineMigrationTasksInvoker(BatchRestartOnlineMigrationTasksRequest batchRestartOnlineMigrationTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-tasks/batch-restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRestartOnlineMigrationTasksRequest);
            return new SyncInvoker<BatchRestartOnlineMigrationTasksResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRestartOnlineMigrationTasksResponse>);
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
        public BatchShowNodesInformationResponse BatchShowNodesInformation(BatchShowNodesInformationRequest batchShowNodesInformationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances-logical-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowNodesInformationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<BatchShowNodesInformationResponse>(response);
        }

        public SyncInvoker<BatchShowNodesInformationResponse> BatchShowNodesInformationInvoker(BatchShowNodesInformationRequest batchShowNodesInformationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances-logical-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowNodesInformationRequest);
            return new SyncInvoker<BatchShowNodesInformationResponse>(this, "GET", request, JsonUtils.DeSerialize<BatchShowNodesInformationResponse>);
        }
        
        /// <summary>
        /// 批量停止数据迁移任务
        ///
        /// 批量停止数据迁移任务，接口响应成功，仅表示下发任务成功。查询到迁移任务状态为TERMINATED时，即停止成功。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchStopMigrationTasksResponse BatchStopMigrationTasks(BatchStopMigrationTasksRequest batchStopMigrationTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/batch-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStopMigrationTasksRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchStopMigrationTasksResponse>(response);
        }

        public SyncInvoker<BatchStopMigrationTasksResponse> BatchStopMigrationTasksInvoker(BatchStopMigrationTasksRequest batchStopMigrationTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/batch-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStopMigrationTasksRequest);
            return new SyncInvoker<BatchStopMigrationTasksResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchStopMigrationTasksResponse>);
        }
        
        /// <summary>
        /// 主备切换
        ///
        /// 切换实例主备节点，只有主备实例支持该操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeMasterStandbyResponse ChangeMasterStandby(ChangeMasterStandbyRequest changeMasterStandbyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeMasterStandbyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/swap", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeMasterStandbyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ChangeMasterStandbyResponse>(response);
        }

        public SyncInvoker<ChangeMasterStandbyResponse> ChangeMasterStandbyInvoker(ChangeMasterStandbyRequest changeMasterStandbyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeMasterStandbyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/swap", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeMasterStandbyRequest);
            return new SyncInvoker<ChangeMasterStandbyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ChangeMasterStandbyResponse>);
        }
        
        /// <summary>
        /// 异步交换实例主备节点
        ///
        /// 异步交换实例主备节点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeMasterStandbyAsyncResponse ChangeMasterStandbyAsync(ChangeMasterStandbyAsyncRequest changeMasterStandbyAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeMasterStandbyAsyncRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/async-swap", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeMasterStandbyAsyncRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ChangeMasterStandbyAsyncResponse>(response);
        }

        public SyncInvoker<ChangeMasterStandbyAsyncResponse> ChangeMasterStandbyAsyncInvoker(ChangeMasterStandbyAsyncRequest changeMasterStandbyAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeMasterStandbyAsyncRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/async-swap", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeMasterStandbyAsyncRequest);
            return new SyncInvoker<ChangeMasterStandbyAsyncResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeMasterStandbyAsyncResponse>);
        }
        
        /// <summary>
        /// 指定实例节点启停开关
        ///
        /// 实例节点启停。执行节点关机操作前的24小时内，需要对实例（单机实例除外）进行数据备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeNodesStartStopStatusResponse ChangeNodesStartStopStatus(ChangeNodesStartStopStatusRequest changeNodesStartStopStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeNodesStartStopStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/nodes/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeNodesStartStopStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ChangeNodesStartStopStatusResponse>(response);
        }

        public SyncInvoker<ChangeNodesStartStopStatusResponse> ChangeNodesStartStopStatusInvoker(ChangeNodesStartStopStatusRequest changeNodesStartStopStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeNodesStartStopStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/nodes/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeNodesStartStopStatusRequest);
            return new SyncInvoker<ChangeNodesStartStopStatusResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ChangeNodesStartStopStatusResponse>);
        }
        
        /// <summary>
        /// 备份指定实例
        ///
        /// 备份指定的缓存实例。
        /// &gt; 只有主备和集群类型的缓存实例支持备份恢复操作，单机实例不支持备份恢复操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CopyInstanceResponse CopyInstance(CopyInstanceRequest copyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", copyInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CopyInstanceResponse>(response);
        }

        public SyncInvoker<CopyInstanceResponse> CopyInstanceInvoker(CopyInstanceRequest copyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", copyInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyInstanceRequest);
            return new SyncInvoker<CopyInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyInstanceResponse>);
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
        public CreateAclAccountResponse CreateAclAccount(CreateAclAccountRequest createAclAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createAclAccountRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAclAccountRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateAclAccountResponse>(response);
        }

        public SyncInvoker<CreateAclAccountResponse> CreateAclAccountInvoker(CreateAclAccountRequest createAclAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createAclAccountRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAclAccountRequest);
            return new SyncInvoker<CreateAclAccountResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateAclAccountResponse>);
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
        public CreateAutoExpireScanTaskResponse CreateAutoExpireScanTask(CreateAutoExpireScanTaskRequest createAutoExpireScanTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createAutoExpireScanTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/scan-expire-keys-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutoExpireScanTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAutoExpireScanTaskResponse>(response);
        }

        public SyncInvoker<CreateAutoExpireScanTaskResponse> CreateAutoExpireScanTaskInvoker(CreateAutoExpireScanTaskRequest createAutoExpireScanTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createAutoExpireScanTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/scan-expire-keys-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAutoExpireScanTaskRequest);
            return new SyncInvoker<CreateAutoExpireScanTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAutoExpireScanTaskResponse>);
        }
        
        /// <summary>
        /// 创建大key分析任务
        ///
        /// 为Redis实例创建大key分析任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateBigkeyScanTaskResponse CreateBigkeyScanTask(CreateBigkeyScanTaskRequest createBigkeyScanTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createBigkeyScanTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBigkeyScanTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateBigkeyScanTaskResponse>(response);
        }

        public SyncInvoker<CreateBigkeyScanTaskResponse> CreateBigkeyScanTaskInvoker(CreateBigkeyScanTaskRequest createBigkeyScanTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createBigkeyScanTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBigkeyScanTaskRequest);
            return new SyncInvoker<CreateBigkeyScanTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBigkeyScanTaskResponse>);
        }
        
        /// <summary>
        /// 创建自定义模板
        ///
        /// 创建自定义模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCustomTemplateResponse CreateCustomTemplate(CreateCustomTemplateRequest createCustomTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCustomTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCustomTemplateResponse>(response);
        }

        public SyncInvoker<CreateCustomTemplateResponse> CreateCustomTemplateInvoker(CreateCustomTemplateRequest createCustomTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCustomTemplateRequest);
            return new SyncInvoker<CreateCustomTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCustomTemplateResponse>);
        }
        
        /// <summary>
        /// 创建实例诊断任务
        ///
        /// 诊断指定的缓存实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDiagnosisTaskResponse CreateDiagnosisTask(CreateDiagnosisTaskRequest createDiagnosisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDiagnosisTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/diagnosis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDiagnosisTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDiagnosisTaskResponse>(response);
        }

        public SyncInvoker<CreateDiagnosisTaskResponse> CreateDiagnosisTaskInvoker(CreateDiagnosisTaskRequest createDiagnosisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDiagnosisTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/diagnosis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDiagnosisTaskRequest);
            return new SyncInvoker<CreateDiagnosisTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDiagnosisTaskResponse>);
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
        public CreateHotkeyScanTaskResponse CreateHotkeyScanTask(CreateHotkeyScanTaskRequest createHotkeyScanTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createHotkeyScanTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHotkeyScanTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateHotkeyScanTaskResponse>(response);
        }

        public SyncInvoker<CreateHotkeyScanTaskResponse> CreateHotkeyScanTaskInvoker(CreateHotkeyScanTaskRequest createHotkeyScanTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createHotkeyScanTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHotkeyScanTaskRequest);
            return new SyncInvoker<CreateHotkeyScanTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHotkeyScanTaskResponse>);
        }
        
        /// <summary>
        /// 创建缓存实例
        ///
        /// 创建缓存实例，该接口创建的缓存实例支持按需计费和包周期两种方式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceResponse>(response);
        }

        public SyncInvoker<CreateInstanceResponse> CreateInstanceInvoker(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstanceRequest);
            return new SyncInvoker<CreateInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceResponse>);
        }
        
        /// <summary>
        /// 创建数据迁移任务
        ///
        /// 创建数据迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMigrationTaskResponse CreateMigrationTask(CreateMigrationTaskRequest createMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMigrationTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMigrationTaskResponse>(response);
        }

        public SyncInvoker<CreateMigrationTaskResponse> CreateMigrationTaskInvoker(CreateMigrationTaskRequest createMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMigrationTaskRequest);
            return new SyncInvoker<CreateMigrationTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMigrationTaskResponse>);
        }
        
        /// <summary>
        /// 创建在线数据迁移任务
        ///
        /// 创建在线数据迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOnlineMigrationTaskResponse CreateOnlineMigrationTask(CreateOnlineMigrationTaskRequest createOnlineMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration/instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOnlineMigrationTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateOnlineMigrationTaskResponse>(response);
        }

        public SyncInvoker<CreateOnlineMigrationTaskResponse> CreateOnlineMigrationTaskInvoker(CreateOnlineMigrationTaskRequest createOnlineMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration/instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOnlineMigrationTaskRequest);
            return new SyncInvoker<CreateOnlineMigrationTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOnlineMigrationTaskResponse>);
        }
        
        /// <summary>
        /// 采集Redis运行日志
        ///
        /// 采集Redis运行日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRedislogResponse CreateRedislog(CreateRedislogRequest createRedislogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createRedislogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/redislog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRedislogRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateRedislogResponse>(response);
        }

        public SyncInvoker<CreateRedislogResponse> CreateRedislogInvoker(CreateRedislogRequest createRedislogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createRedislogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/redislog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRedislogRequest);
            return new SyncInvoker<CreateRedislogResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateRedislogResponse>);
        }
        
        /// <summary>
        /// 获取日志下载链接
        ///
        /// 获取日志下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRedislogDownloadLinkResponse CreateRedislogDownloadLink(CreateRedislogDownloadLinkRequest createRedislogDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createRedislogDownloadLinkRequest.InstanceId.ToString());
            urlParam.Add("id", createRedislogDownloadLinkRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/redislog/{id}/links", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRedislogDownloadLinkRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRedislogDownloadLinkResponse>(response);
        }

        public SyncInvoker<CreateRedislogDownloadLinkResponse> CreateRedislogDownloadLinkInvoker(CreateRedislogDownloadLinkRequest createRedislogDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createRedislogDownloadLinkRequest.InstanceId.ToString());
            urlParam.Add("id", createRedislogDownloadLinkRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/redislog/{id}/links", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRedislogDownloadLinkRequest);
            return new SyncInvoker<CreateRedislogDownloadLinkResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRedislogDownloadLinkResponse>);
        }
        
        /// <summary>
        /// 包周期实例变更规格
        ///
        /// 包周期实例变更规格
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateResizeOrderResponse CreateResizeOrder(CreateResizeOrderRequest createResizeOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createResizeOrderRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/orders/instances/{instance_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createResizeOrderRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateResizeOrderResponse>(response);
        }

        public SyncInvoker<CreateResizeOrderResponse> CreateResizeOrderInvoker(CreateResizeOrderRequest createResizeOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createResizeOrderRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/orders/instances/{instance_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createResizeOrderRequest);
            return new SyncInvoker<CreateResizeOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateResizeOrderResponse>);
        }
        
        /// <summary>
        /// 删除ACL账号
        ///
        /// 删除所创建的ACL普通账号
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAclAccountResponse DeleteAclAccount(DeleteAclAccountRequest deleteAclAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteAclAccountRequest.InstanceId.ToString());
            urlParam.Add("account_id", deleteAclAccountRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAclAccountRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAclAccountResponse>(response);
        }

        public SyncInvoker<DeleteAclAccountResponse> DeleteAclAccountInvoker(DeleteAclAccountRequest deleteAclAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteAclAccountRequest.InstanceId.ToString());
            urlParam.Add("account_id", deleteAclAccountRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAclAccountRequest);
            return new SyncInvoker<DeleteAclAccountResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAclAccountResponse>);
        }
        
        /// <summary>
        /// 删除后台任务
        ///
        /// 删除后台任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBackgroundTaskResponse DeleteBackgroundTask(DeleteBackgroundTaskRequest deleteBackgroundTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteBackgroundTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", deleteBackgroundTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackgroundTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteBackgroundTaskResponse>(response);
        }

        public SyncInvoker<DeleteBackgroundTaskResponse> DeleteBackgroundTaskInvoker(DeleteBackgroundTaskRequest deleteBackgroundTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteBackgroundTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", deleteBackgroundTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackgroundTaskRequest);
            return new SyncInvoker<DeleteBackgroundTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteBackgroundTaskResponse>);
        }
        
        /// <summary>
        /// 删除备份文件
        ///
        /// 删除缓存实例已备份的文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBackupFileResponse DeleteBackupFile(DeleteBackupFileRequest deleteBackupFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteBackupFileRequest.BackupId.ToString());
            urlParam.Add("instance_id", deleteBackupFileRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackupFileRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteBackupFileResponse>(response);
        }

        public SyncInvoker<DeleteBackupFileResponse> DeleteBackupFileInvoker(DeleteBackupFileRequest deleteBackupFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteBackupFileRequest.BackupId.ToString());
            urlParam.Add("instance_id", deleteBackupFileRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackupFileRequest);
            return new SyncInvoker<DeleteBackupFileResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBackupFileResponse>);
        }
        
        /// <summary>
        /// 删除大key分析记录
        ///
        /// 删除大key分析记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBigkeyScanTaskResponse DeleteBigkeyScanTask(DeleteBigkeyScanTaskRequest deleteBigkeyScanTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteBigkeyScanTaskRequest.InstanceId.ToString());
            urlParam.Add("bigkey_id", deleteBigkeyScanTaskRequest.BigkeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey-task/{bigkey_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBigkeyScanTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteBigkeyScanTaskResponse>(response);
        }

        public SyncInvoker<DeleteBigkeyScanTaskResponse> DeleteBigkeyScanTaskInvoker(DeleteBigkeyScanTaskRequest deleteBigkeyScanTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteBigkeyScanTaskRequest.InstanceId.ToString());
            urlParam.Add("bigkey_id", deleteBigkeyScanTaskRequest.BigkeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey-task/{bigkey_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBigkeyScanTaskRequest);
            return new SyncInvoker<DeleteBigkeyScanTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteBigkeyScanTaskResponse>);
        }
        
        /// <summary>
        /// 删除任务中心任务
        ///
        /// 删除任务中心任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCenterTaskResponse DeleteCenterTask(DeleteCenterTaskRequest deleteCenterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", deleteCenterTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteCenterTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCenterTaskResponse>(response);
        }

        public SyncInvoker<DeleteCenterTaskResponse> DeleteCenterTaskInvoker(DeleteCenterTaskRequest deleteCenterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", deleteCenterTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteCenterTaskRequest);
            return new SyncInvoker<DeleteCenterTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCenterTaskResponse>);
        }
        
        /// <summary>
        /// 删除自定义模板
        ///
        /// 删除自定义模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteConfigTemplateResponse DeleteConfigTemplate(DeleteConfigTemplateRequest deleteConfigTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id", deleteConfigTemplateRequest.TemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteConfigTemplateResponse>(response);
        }

        public SyncInvoker<DeleteConfigTemplateResponse> DeleteConfigTemplateInvoker(DeleteConfigTemplateRequest deleteConfigTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id", deleteConfigTemplateRequest.TemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigTemplateRequest);
            return new SyncInvoker<DeleteConfigTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteConfigTemplateResponse>);
        }
        
        /// <summary>
        /// 删除诊断记录
        ///
        /// 删除诊断记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDiagnosisTaskResponse DeleteDiagnosisTask(DeleteDiagnosisTaskRequest deleteDiagnosisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDiagnosisTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/diagnosis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteDiagnosisTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDiagnosisTaskResponse>(response);
        }

        public SyncInvoker<DeleteDiagnosisTaskResponse> DeleteDiagnosisTaskInvoker(DeleteDiagnosisTaskRequest deleteDiagnosisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDiagnosisTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/diagnosis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteDiagnosisTaskRequest);
            return new SyncInvoker<DeleteDiagnosisTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDiagnosisTaskResponse>);
        }
        
        /// <summary>
        /// 删除热key分析任务
        ///
        /// 删除热key分析任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteHotkeyScanTaskResponse DeleteHotkeyScanTask(DeleteHotkeyScanTaskRequest deleteHotkeyScanTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteHotkeyScanTaskRequest.InstanceId.ToString());
            urlParam.Add("hotkey_id", deleteHotkeyScanTaskRequest.HotkeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey-task/{hotkey_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHotkeyScanTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteHotkeyScanTaskResponse>(response);
        }

        public SyncInvoker<DeleteHotkeyScanTaskResponse> DeleteHotkeyScanTaskInvoker(DeleteHotkeyScanTaskRequest deleteHotkeyScanTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteHotkeyScanTaskRequest.InstanceId.ToString());
            urlParam.Add("hotkey_id", deleteHotkeyScanTaskRequest.HotkeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey-task/{hotkey_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHotkeyScanTaskRequest);
            return new SyncInvoker<DeleteHotkeyScanTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteHotkeyScanTaskResponse>);
        }
        
        /// <summary>
        /// 删除实例带宽弹性伸缩策略
        ///
        /// 删除实例带宽弹性伸缩策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceBandwidthAutoScalingPolicyResponse DeleteInstanceBandwidthAutoScalingPolicy(DeleteInstanceBandwidthAutoScalingPolicyRequest deleteInstanceBandwidthAutoScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceBandwidthAutoScalingPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/autoscaling-policy/bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceBandwidthAutoScalingPolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceBandwidthAutoScalingPolicyResponse>(response);
        }

        public SyncInvoker<DeleteInstanceBandwidthAutoScalingPolicyResponse> DeleteInstanceBandwidthAutoScalingPolicyInvoker(DeleteInstanceBandwidthAutoScalingPolicyRequest deleteInstanceBandwidthAutoScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceBandwidthAutoScalingPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/autoscaling-policy/bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceBandwidthAutoScalingPolicyRequest);
            return new SyncInvoker<DeleteInstanceBandwidthAutoScalingPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceBandwidthAutoScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 域名摘除IP
        ///
        /// 将只读副本的IP从域名中摘除，摘除成功后，只读域名不会再解析到该副本IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteIpFromDomainNameResponse DeleteIpFromDomainName(DeleteIpFromDomainNameRequest deleteIpFromDomainNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteIpFromDomainNameRequest.InstanceId.ToString());
            urlParam.Add("group_id", deleteIpFromDomainNameRequest.GroupId.ToString());
            urlParam.Add("node_id", deleteIpFromDomainNameRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group_id}/replications/{node_id}/remove-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpFromDomainNameRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteIpFromDomainNameResponse>(response);
        }

        public SyncInvoker<DeleteIpFromDomainNameResponse> DeleteIpFromDomainNameInvoker(DeleteIpFromDomainNameRequest deleteIpFromDomainNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteIpFromDomainNameRequest.InstanceId.ToString());
            urlParam.Add("group_id", deleteIpFromDomainNameRequest.GroupId.ToString());
            urlParam.Add("node_id", deleteIpFromDomainNameRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group_id}/replications/{node_id}/remove-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpFromDomainNameRequest);
            return new SyncInvoker<DeleteIpFromDomainNameResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteIpFromDomainNameResponse>);
        }
        
        /// <summary>
        /// 删除数据迁移任务
        ///
        /// 删除数据迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteMigrationTaskResponse DeleteMigrationTask(DeleteMigrationTaskRequest deleteMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-tasks/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteMigrationTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteMigrationTaskResponse>(response);
        }

        public SyncInvoker<DeleteMigrationTaskResponse> DeleteMigrationTaskInvoker(DeleteMigrationTaskRequest deleteMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-tasks/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteMigrationTaskRequest);
            return new SyncInvoker<DeleteMigrationTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteMigrationTaskResponse>);
        }
        
        /// <summary>
        /// 关闭实例公网访问
        ///
        /// 关闭实例公网访问。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePublicIpResponse DeletePublicIp(DeletePublicIpRequest deletePublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deletePublicIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicIpRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePublicIpResponse>(response);
        }

        public SyncInvoker<DeletePublicIpResponse> DeletePublicIpInvoker(DeletePublicIpRequest deletePublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deletePublicIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicIpRequest);
            return new SyncInvoker<DeletePublicIpResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePublicIpResponse>);
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
        public DeleteSingleInstanceResponse DeleteSingleInstance(DeleteSingleInstanceRequest deleteSingleInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteSingleInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSingleInstanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSingleInstanceResponse>(response);
        }

        public SyncInvoker<DeleteSingleInstanceResponse> DeleteSingleInstanceInvoker(DeleteSingleInstanceRequest deleteSingleInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteSingleInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSingleInstanceRequest);
            return new SyncInvoker<DeleteSingleInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSingleInstanceResponse>);
        }
        
        /// <summary>
        /// 下载热key
        ///
        /// 下载热key。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadHotKeyResponse DownloadHotKey(DownloadHotKeyRequest downloadHotKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", downloadHotKeyRequest.InstanceId.ToString());
            urlParam.Add("task_id", downloadHotKeyRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey/{task_id}/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadHotKeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DownloadHotKeyResponse>(response);
        }

        public SyncInvoker<DownloadHotKeyResponse> DownloadHotKeyInvoker(DownloadHotKeyRequest downloadHotKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", downloadHotKeyRequest.InstanceId.ToString());
            urlParam.Add("task_id", downloadHotKeyRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey/{task_id}/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadHotKeyRequest);
            return new SyncInvoker<DownloadHotKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<DownloadHotKeyResponse>);
        }
        
        /// <summary>
        /// 下载实例SSL证书
        ///
        /// 下载实例SSL证书。该接口目前仅针对Redis 6.0[基础版](tag:hws,hws_hk)版本实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadSslCertResponse DownloadSslCert(DownloadSslCertRequest downloadSslCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", downloadSslCertRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/ssl-certs/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSslCertRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DownloadSslCertResponse>(response);
        }

        public SyncInvoker<DownloadSslCertResponse> DownloadSslCertInvoker(DownloadSslCertRequest downloadSslCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", downloadSslCertRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/ssl-certs/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadSslCertRequest);
            return new SyncInvoker<DownloadSslCertResponse>(this, "POST", request, JsonUtils.DeSerialize<DownloadSslCertResponse>);
        }
        
        /// <summary>
        /// 进行IP交换
        ///
        /// 进行IP交换
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExchangeInstanceIpResponse ExchangeInstanceIp(ExchangeInstanceIpRequest exchangeInstanceIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", exchangeInstanceIpRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/exchange-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exchangeInstanceIpRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ExchangeInstanceIpResponse>(response);
        }

        public SyncInvoker<ExchangeInstanceIpResponse> ExchangeInstanceIpInvoker(ExchangeInstanceIpRequest exchangeInstanceIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", exchangeInstanceIpRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/exchange-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exchangeInstanceIpRequest);
            return new SyncInvoker<ExchangeInstanceIpResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ExchangeInstanceIpResponse>);
        }
        
        /// <summary>
        /// 集群分片倒换
        ///
        /// 集群分片倒换，适用于proxy和cluster实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteClusterSwitchoverResponse ExecuteClusterSwitchover(ExecuteClusterSwitchoverRequest executeClusterSwitchoverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeClusterSwitchoverRequest.InstanceId.ToString());
            urlParam.Add("group_id", executeClusterSwitchoverRequest.GroupId.ToString());
            urlParam.Add("node_id", executeClusterSwitchoverRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/groups/{group_id}/replications/{node_id}/async-switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeClusterSwitchoverRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteClusterSwitchoverResponse>(response);
        }

        public SyncInvoker<ExecuteClusterSwitchoverResponse> ExecuteClusterSwitchoverInvoker(ExecuteClusterSwitchoverRequest executeClusterSwitchoverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeClusterSwitchoverRequest.InstanceId.ToString());
            urlParam.Add("group_id", executeClusterSwitchoverRequest.GroupId.ToString());
            urlParam.Add("node_id", executeClusterSwitchoverRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/groups/{group_id}/replications/{node_id}/async-switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeClusterSwitchoverRequest);
            return new SyncInvoker<ExecuteClusterSwitchoverResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteClusterSwitchoverResponse>);
        }
        
        /// <summary>
        /// 执行web-cli命令V2接口
        ///
        /// 登入web-cli，执行redis命令
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteCommandMobilizationResponse ExecuteCommandMobilization(ExecuteCommandMobilizationRequest executeCommandMobilizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeCommandMobilizationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/webcli/command", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCommandMobilizationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteCommandMobilizationResponse>(response);
        }

        public SyncInvoker<ExecuteCommandMobilizationResponse> ExecuteCommandMobilizationInvoker(ExecuteCommandMobilizationRequest executeCommandMobilizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeCommandMobilizationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/webcli/command", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeCommandMobilizationRequest);
            return new SyncInvoker<ExecuteCommandMobilizationResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteCommandMobilizationResponse>);
        }
        
        /// <summary>
        /// 查询实例列表导出任务详情
        ///
        /// 查询实例列表导出任务详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExportExcelJobResponse ExportExcelJob(ExportExcelJobRequest exportExcelJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/export-job", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportExcelJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ExportExcelJobResponse>(response);
        }

        public SyncInvoker<ExportExcelJobResponse> ExportExcelJobInvoker(ExportExcelJobRequest exportExcelJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/export-job", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportExcelJobRequest);
            return new SyncInvoker<ExportExcelJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ExportExcelJobResponse>);
        }
        
        /// <summary>
        /// 异步导出实例资源
        ///
        /// 异步导出实例资源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExportInstancesTaskResponse ExportInstancesTask(ExportInstancesTaskRequest exportInstancesTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exportInstancesTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExportInstancesTaskResponse>(response);
        }

        public SyncInvoker<ExportInstancesTaskResponse> ExportInstancesTaskInvoker(ExportInstancesTaskRequest exportInstancesTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exportInstancesTaskRequest);
            return new SyncInvoker<ExportInstancesTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<ExportInstancesTaskResponse>);
        }
        
        /// <summary>
        /// kill指定的会话
        ///
        /// kill指定的会话
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public HangUpClientsResponse HangUpClients(HangUpClientsRequest hangUpClientsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", hangUpClientsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/clients/kill", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", hangUpClientsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<HangUpClientsResponse>(response);
        }

        public SyncInvoker<HangUpClientsResponse> HangUpClientsInvoker(HangUpClientsRequest hangUpClientsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", hangUpClientsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/clients/kill", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", hangUpClientsRequest);
            return new SyncInvoker<HangUpClientsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<HangUpClientsResponse>);
        }
        
        /// <summary>
        /// 下发kill指定节点或实例的全部会话任务
        ///
        /// 下发kill指定节点或实例的全部会话任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public HangUpKillAllClientsResponse HangUpKillAllClients(HangUpKillAllClientsRequest hangUpKillAllClientsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", hangUpKillAllClientsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/clients/kill-all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", hangUpKillAllClientsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<HangUpKillAllClientsResponse>(response);
        }

        public SyncInvoker<HangUpKillAllClientsResponse> HangUpKillAllClientsInvoker(HangUpKillAllClientsRequest hangUpKillAllClientsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", hangUpKillAllClientsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/clients/kill-all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", hangUpKillAllClientsRequest);
            return new SyncInvoker<HangUpKillAllClientsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<HangUpKillAllClientsResponse>);
        }
        
        /// <summary>
        /// 查询ACL账户列表
        ///
        /// 查询ACL账户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAclAccountsResponse ListAclAccounts(ListAclAccountsRequest listAclAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAclAccountsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclAccountsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAclAccountsResponse>(response);
        }

        public SyncInvoker<ListAclAccountsResponse> ListAclAccountsInvoker(ListAclAccountsRequest listAclAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAclAccountsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclAccountsRequest);
            return new SyncInvoker<ListAclAccountsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAclAccountsResponse>);
        }
        
        /// <summary>
        /// 查询可用区信息
        ///
        /// 查询所在局点的可用区信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAvailableZonesResponse ListAvailableZones(ListAvailableZonesRequest listAvailableZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/available-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableZonesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAvailableZonesResponse>(response);
        }

        public SyncInvoker<ListAvailableZonesResponse> ListAvailableZonesInvoker(ListAvailableZonesRequest listAvailableZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/available-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableZonesRequest);
            return new SyncInvoker<ListAvailableZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailableZonesResponse>);
        }
        
        /// <summary>
        /// 查询后台任务列表
        ///
        /// 查询后台任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBackgroundTaskResponse ListBackgroundTask(ListBackgroundTaskRequest listBackgroundTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBackgroundTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackgroundTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBackgroundTaskResponse>(response);
        }

        public SyncInvoker<ListBackgroundTaskResponse> ListBackgroundTaskInvoker(ListBackgroundTaskRequest listBackgroundTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBackgroundTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackgroundTaskRequest);
            return new SyncInvoker<ListBackgroundTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBackgroundTaskResponse>);
        }
        
        /// <summary>
        /// 获取备份文件下载链接
        ///
        /// 获取指定实例的备份文件下载链接，下载备份文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBackupFileLinksResponse ListBackupFileLinks(ListBackupFileLinksRequest listBackupFileLinksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBackupFileLinksRequest.InstanceId.ToString());
            urlParam.Add("backup_id", listBackupFileLinksRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups/{backup_id}/links", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listBackupFileLinksRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListBackupFileLinksResponse>(response);
        }

        public SyncInvoker<ListBackupFileLinksResponse> ListBackupFileLinksInvoker(ListBackupFileLinksRequest listBackupFileLinksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBackupFileLinksRequest.InstanceId.ToString());
            urlParam.Add("backup_id", listBackupFileLinksRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups/{backup_id}/links", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listBackupFileLinksRequest);
            return new SyncInvoker<ListBackupFileLinksResponse>(this, "POST", request, JsonUtils.DeSerialize<ListBackupFileLinksResponse>);
        }
        
        /// <summary>
        /// 查询实例备份信息
        ///
        /// 查询指定缓存实例的备份信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBackupRecordsResponse ListBackupRecords(ListBackupRecordsRequest listBackupRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBackupRecordsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupRecordsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBackupRecordsResponse>(response);
        }

        public SyncInvoker<ListBackupRecordsResponse> ListBackupRecordsInvoker(ListBackupRecordsRequest listBackupRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBackupRecordsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupRecordsRequest);
            return new SyncInvoker<ListBackupRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBackupRecordsResponse>);
        }
        
        /// <summary>
        /// 查询大key分析任务列表
        ///
        /// 查询大key分析任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBigkeyScanTasksResponse ListBigkeyScanTasks(ListBigkeyScanTasksRequest listBigkeyScanTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBigkeyScanTasksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBigkeyScanTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBigkeyScanTasksResponse>(response);
        }

        public SyncInvoker<ListBigkeyScanTasksResponse> ListBigkeyScanTasksInvoker(ListBigkeyScanTasksRequest listBigkeyScanTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBigkeyScanTasksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBigkeyScanTasksRequest);
            return new SyncInvoker<ListBigkeyScanTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBigkeyScanTasksResponse>);
        }
        
        /// <summary>
        /// 查询任务中心任务列表
        ///
        /// 查询任务中心任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCenterTaskResponse ListCenterTask(ListCenterTaskRequest listCenterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCenterTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCenterTaskResponse>(response);
        }

        public SyncInvoker<ListCenterTaskResponse> ListCenterTaskInvoker(ListCenterTaskRequest listCenterTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCenterTaskRequest);
            return new SyncInvoker<ListCenterTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCenterTaskResponse>);
        }
        
        /// <summary>
        /// 获取会话列表
        ///
        /// 获取会话列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListClientsResponse ListClients(ListClientsRequest listClientsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listClientsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/clients", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClientsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListClientsResponse>(response);
        }

        public SyncInvoker<ListClientsResponse> ListClientsInvoker(ListClientsRequest listClientsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listClientsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/clients", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClientsRequest);
            return new SyncInvoker<ListClientsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClientsResponse>);
        }
        
        /// <summary>
        /// 查询实例参数修改记录列表
        ///
        /// 查询实例的参数修改记录列表，支持按照关键字查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConfigHistoriesResponse ListConfigHistories(ListConfigHistoriesRequest listConfigHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listConfigHistoriesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/config-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigHistoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListConfigHistoriesResponse>(response);
        }

        public SyncInvoker<ListConfigHistoriesResponse> ListConfigHistoriesInvoker(ListConfigHistoriesRequest listConfigHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listConfigHistoriesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/config-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigHistoriesRequest);
            return new SyncInvoker<ListConfigHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigHistoriesResponse>);
        }
        
        /// <summary>
        /// 查询参数模板列表
        ///
        /// 查询租户的参数模板列表，支持按照条件查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConfigTemplatesResponse ListConfigTemplates(ListConfigTemplatesRequest listConfigTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListConfigTemplatesResponse>(response);
        }

        public SyncInvoker<ListConfigTemplatesResponse> ListConfigTemplatesInvoker(ListConfigTemplatesRequest listConfigTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigTemplatesRequest);
            return new SyncInvoker<ListConfigTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询实例配置参数
        ///
        /// 查询指定实例的配置参数信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConfigurationsResponse ListConfigurations(ListConfigurationsRequest listConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listConfigurationsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListConfigurationsResponse>(response);
        }

        public SyncInvoker<ListConfigurationsResponse> ListConfigurationsInvoker(ListConfigurationsRequest listConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listConfigurationsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationsRequest);
            return new SyncInvoker<ListConfigurationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigurationsResponse>);
        }
        
        /// <summary>
        /// 查询实例诊断任务列表
        ///
        /// 查询指定缓存实例诊断任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDiagnosisTasksResponse ListDiagnosisTasks(ListDiagnosisTasksRequest listDiagnosisTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDiagnosisTasksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/diagnosis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDiagnosisTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDiagnosisTasksResponse>(response);
        }

        public SyncInvoker<ListDiagnosisTasksResponse> ListDiagnosisTasksInvoker(ListDiagnosisTasksRequest listDiagnosisTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDiagnosisTasksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/diagnosis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDiagnosisTasksRequest);
            return new SyncInvoker<ListDiagnosisTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDiagnosisTasksResponse>);
        }
        
        /// <summary>
        /// 查询产品规格
        ///
        /// 在创建缓存实例时，需要配置订购的产品规格编码（spec_code），可通过该接口查询产品规格，查询条件不选时默认查询全部。
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
        /// 查询分片信息
        ///
        /// 查询读写分离实例和集群实例的分片和副本信息，其中，读写分离实例仅Redis4.0和Redis5.0的主备实例支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupReplicationInfoResponse ListGroupReplicationInfo(ListGroupReplicationInfoRequest listGroupReplicationInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listGroupReplicationInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupReplicationInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGroupReplicationInfoResponse>(response);
        }

        public SyncInvoker<ListGroupReplicationInfoResponse> ListGroupReplicationInfoInvoker(ListGroupReplicationInfoRequest listGroupReplicationInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listGroupReplicationInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupReplicationInfoRequest);
            return new SyncInvoker<ListGroupReplicationInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupReplicationInfoResponse>);
        }
        
        /// <summary>
        /// 查询热key分析任务列表
        ///
        /// 查询热key分析历史记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHotKeyScanTasksResponse ListHotKeyScanTasks(ListHotKeyScanTasksRequest listHotKeyScanTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listHotKeyScanTasksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHotKeyScanTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHotKeyScanTasksResponse>(response);
        }

        public SyncInvoker<ListHotKeyScanTasksResponse> ListHotKeyScanTasksInvoker(ListHotKeyScanTasksRequest listHotKeyScanTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listHotKeyScanTasksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHotKeyScanTasksRequest);
            return new SyncInvoker<ListHotKeyScanTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHotKeyScanTasksResponse>);
        }
        
        /// <summary>
        /// 查询实例是否可以扩容
        ///
        /// 查询实例是否可以扩容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceOperationsResponse ListInstanceOperations(ListInstanceOperationsRequest listInstanceOperationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceOperationsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/operations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceOperationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceOperationsResponse>(response);
        }

        public SyncInvoker<ListInstanceOperationsResponse> ListInstanceOperationsInvoker(ListInstanceOperationsRequest listInstanceOperationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceOperationsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/operations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceOperationsRequest);
            return new SyncInvoker<ListInstanceOperationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceOperationsResponse>);
        }
        
        /// <summary>
        /// 查询所有实例列表
        ///
        /// 查询租户的缓存实例列表，支持按照条件查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstancesResponse ListInstances(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesResponse>(response);
        }

        public SyncInvoker<ListInstancesResponse> ListInstancesInvoker(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            return new SyncInvoker<ListInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesResponse>);
        }
        
        /// <summary>
        /// 查询维护时间窗时间段
        ///
        /// 查询维护时间窗开始时间和结束时间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMaintenanceWindowsResponse ListMaintenanceWindows(ListMaintenanceWindowsRequest listMaintenanceWindowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/instances/maintain-windows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMaintenanceWindowsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMaintenanceWindowsResponse>(response);
        }

        public SyncInvoker<ListMaintenanceWindowsResponse> ListMaintenanceWindowsInvoker(ListMaintenanceWindowsRequest listMaintenanceWindowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/instances/maintain-windows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMaintenanceWindowsRequest);
            return new SyncInvoker<ListMaintenanceWindowsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMaintenanceWindowsResponse>);
        }
        
        /// <summary>
        /// 查询迁移任务列表
        ///
        /// 查询迁移任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMigrationTaskResponse ListMigrationTask(ListMigrationTaskRequest listMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMigrationTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMigrationTaskResponse>(response);
        }

        public SyncInvoker<ListMigrationTaskResponse> ListMigrationTaskInvoker(ListMigrationTaskRequest listMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMigrationTaskRequest);
            return new SyncInvoker<ListMigrationTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMigrationTaskResponse>);
        }
        
        /// <summary>
        /// 查询迁移日志列表
        ///
        /// 查询迁移日志列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMigrationTaskLogsResponse ListMigrationTaskLogs(ListMigrationTaskLogsRequest listMigrationTaskLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", listMigrationTaskLogsRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMigrationTaskLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMigrationTaskLogsResponse>(response);
        }

        public SyncInvoker<ListMigrationTaskLogsResponse> ListMigrationTaskLogsInvoker(ListMigrationTaskLogsRequest listMigrationTaskLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", listMigrationTaskLogsRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMigrationTaskLogsRequest);
            return new SyncInvoker<ListMigrationTaskLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMigrationTaskLogsResponse>);
        }
        
        /// <summary>
        /// 查询主维度信息列表
        ///
        /// 查询主维度对象列表，主维度ID当前支持dcs_instance_id，dcs_memcached_instance_id。
        /// &gt; 该接口当前仅在中国华南区开放。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMonitoredObjectsResponse ListMonitoredObjects(ListMonitoredObjectsRequest listMonitoredObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dims/monitored-objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMonitoredObjectsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMonitoredObjectsResponse>(response);
        }

        public SyncInvoker<ListMonitoredObjectsResponse> ListMonitoredObjectsInvoker(ListMonitoredObjectsRequest listMonitoredObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dims/monitored-objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMonitoredObjectsRequest);
            return new SyncInvoker<ListMonitoredObjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMonitoredObjectsResponse>);
        }
        
        /// <summary>
        /// 查询单个主维度下子维度监控对象列表
        ///
        /// 查询主维度下子维度监控对象列表，当前支持子维度的主维度ID的有 dcs_instance_id
        /// &gt; 该接口当前仅在中国华南区开放。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMonitoredObjectsOfInstanceResponse ListMonitoredObjectsOfInstance(ListMonitoredObjectsOfInstanceRequest listMonitoredObjectsOfInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listMonitoredObjectsOfInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dims/monitored-objects/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMonitoredObjectsOfInstanceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMonitoredObjectsOfInstanceResponse>(response);
        }

        public SyncInvoker<ListMonitoredObjectsOfInstanceResponse> ListMonitoredObjectsOfInstanceInvoker(ListMonitoredObjectsOfInstanceRequest listMonitoredObjectsOfInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listMonitoredObjectsOfInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dims/monitored-objects/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMonitoredObjectsOfInstanceRequest);
            return new SyncInvoker<ListMonitoredObjectsOfInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMonitoredObjectsOfInstanceResponse>);
        }
        
        /// <summary>
        /// 查询实例状态
        ///
        /// 查询该租户在当前区域下不同状态的实例数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNumberOfInstancesInDifferentStatusResponse ListNumberOfInstancesInDifferentStatus(ListNumberOfInstancesInDifferentStatusRequest listNumberOfInstancesInDifferentStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNumberOfInstancesInDifferentStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNumberOfInstancesInDifferentStatusResponse>(response);
        }

        public SyncInvoker<ListNumberOfInstancesInDifferentStatusResponse> ListNumberOfInstancesInDifferentStatusInvoker(ListNumberOfInstancesInDifferentStatusRequest listNumberOfInstancesInDifferentStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNumberOfInstancesInDifferentStatusRequest);
            return new SyncInvoker<ListNumberOfInstancesInDifferentStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNumberOfInstancesInDifferentStatusResponse>);
        }
        
        /// <summary>
        /// 查询Redis运行日志列表
        ///
        /// 查询Redis运行日志列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRedislogResponse ListRedislog(ListRedislogRequest listRedislogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRedislogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/redislog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRedislogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRedislogResponse>(response);
        }

        public SyncInvoker<ListRedislogResponse> ListRedislogInvoker(ListRedislogRequest listRedislogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRedislogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/redislog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRedislogRequest);
            return new SyncInvoker<ListRedislogResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRedislogResponse>);
        }
        
        /// <summary>
        /// 查询实例恢复记录
        ///
        /// 查询指定缓存实例的恢复记录列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRestoreRecordsResponse ListRestoreRecords(ListRestoreRecordsRequest listRestoreRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreRecordsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/restores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreRecordsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRestoreRecordsResponse>(response);
        }

        public SyncInvoker<ListRestoreRecordsResponse> ListRestoreRecordsInvoker(ListRestoreRecordsRequest listRestoreRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreRecordsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/restores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreRecordsRequest);
            return new SyncInvoker<ListRestoreRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestoreRecordsResponse>);
        }
        
        /// <summary>
        /// 查询慢日志
        ///
        /// 查询慢日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSlowlogResponse ListSlowlog(ListSlowlogRequest listSlowlogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowlogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowlogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSlowlogResponse>(response);
        }

        public SyncInvoker<ListSlowlogResponse> ListSlowlogInvoker(ListSlowlogRequest listSlowlogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowlogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowlogRequest);
            return new SyncInvoker<ListSlowlogResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSlowlogResponse>);
        }
        
        /// <summary>
        /// 查询运行中实例的统计信息
        ///
        /// 查询当前租户下处于“运行中”状态的缓存实例的统计信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStatisticsOfRunningInstancesResponse ListStatisticsOfRunningInstances(ListStatisticsOfRunningInstancesRequest listStatisticsOfRunningInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStatisticsOfRunningInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListStatisticsOfRunningInstancesResponse>(response);
        }

        public SyncInvoker<ListStatisticsOfRunningInstancesResponse> ListStatisticsOfRunningInstancesInvoker(ListStatisticsOfRunningInstancesRequest listStatisticsOfRunningInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStatisticsOfRunningInstancesRequest);
            return new SyncInvoker<ListStatisticsOfRunningInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStatisticsOfRunningInstancesResponse>);
        }
        
        /// <summary>
        /// 查询租户所有标签
        ///
        /// 查询租户在指定Project中实例类型的所有资源标签集合。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagsOfTenantResponse ListTagsOfTenant(ListTagsOfTenantRequest listTagsOfTenantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dcs/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsOfTenantRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTagsOfTenantResponse>(response);
        }

        public SyncInvoker<ListTagsOfTenantResponse> ListTagsOfTenantInvoker(ListTagsOfTenantRequest listTagsOfTenantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dcs/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsOfTenantRequest);
            return new SyncInvoker<ListTagsOfTenantResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagsOfTenantResponse>);
        }
        
        /// <summary>
        /// 登录webCli
        ///
        /// 登录webCli
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public LoginWebCliResponse LoginWebCli(LoginWebCliRequest loginWebCliRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", loginWebCliRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/webcli/auth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", loginWebCliRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<LoginWebCliResponse>(response);
        }

        public SyncInvoker<LoginWebCliResponse> LoginWebCliInvoker(LoginWebCliRequest loginWebCliRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", loginWebCliRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/webcli/auth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", loginWebCliRequest);
            return new SyncInvoker<LoginWebCliResponse>(this, "POST", request, JsonUtils.DeSerialize<LoginWebCliResponse>);
        }
        
        /// <summary>
        /// 登出webCli
        ///
        /// 登出webCli
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public LogoffWebCliResponse LogoffWebCli(LogoffWebCliRequest logoffWebCliRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", logoffWebCliRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/webcli/logout", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", logoffWebCliRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<LogoffWebCliResponse>(response);
        }

        public SyncInvoker<LogoffWebCliResponse> LogoffWebCliInvoker(LogoffWebCliRequest logoffWebCliRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", logoffWebCliRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/webcli/logout", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", logoffWebCliRequest);
            return new SyncInvoker<LogoffWebCliResponse>(this, "POST", request, JsonUtils.DeSerializeNull<LogoffWebCliResponse>);
        }
        
        /// <summary>
        /// 变更可用区
        ///
        /// 迁移缓存实例可用区，完成单可用区实例跨可用区改造。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public MigrateAzResponse MigrateAz(MigrateAzRequest migrateAzRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", migrateAzRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/available-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateAzRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<MigrateAzResponse>(response);
        }

        public SyncInvoker<MigrateAzResponse> MigrateAzInvoker(MigrateAzRequest migrateAzRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", migrateAzRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/available-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateAzRequest);
            return new SyncInvoker<MigrateAzResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<MigrateAzResponse>);
        }
        
        /// <summary>
        /// 重置ACL账号密码
        ///
        /// 重置ACL账号密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetAclAccountPassWordResponse ResetAclAccountPassWord(ResetAclAccountPassWordRequest resetAclAccountPassWordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetAclAccountPassWordRequest.InstanceId.ToString());
            urlParam.Add("account_id", resetAclAccountPassWordRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}/password/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetAclAccountPassWordRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ResetAclAccountPassWordResponse>(response);
        }

        public SyncInvoker<ResetAclAccountPassWordResponse> ResetAclAccountPassWordInvoker(ResetAclAccountPassWordRequest resetAclAccountPassWordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetAclAccountPassWordRequest.InstanceId.ToString());
            urlParam.Add("account_id", resetAclAccountPassWordRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}/password/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetAclAccountPassWordRequest);
            return new SyncInvoker<ResetAclAccountPassWordResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResetAclAccountPassWordResponse>);
        }
        
        /// <summary>
        /// 重置密码
        ///
        /// 重置缓存实例的密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetPasswordResponse ResetPassword(ResetPasswordRequest resetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/password/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetPasswordRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResetPasswordResponse>(response);
        }

        public SyncInvoker<ResetPasswordResponse> ResetPasswordInvoker(ResetPasswordRequest resetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/password/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetPasswordRequest);
            return new SyncInvoker<ResetPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetPasswordResponse>);
        }
        
        /// <summary>
        /// 变更实例规格
        ///
        /// 用户可以为状态为“运行中”的DCS缓存实例进行规格变更，当前仅能支持按需实例的同副本或分片数量的实例规格变更。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResizeInstanceResponse ResizeInstance(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ResizeInstanceResponse>(response);
        }

        public SyncInvoker<ResizeInstanceResponse> ResizeInstanceInvoker(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeInstanceRequest);
            return new SyncInvoker<ResizeInstanceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResizeInstanceResponse>);
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
        public RestartOrFlushInstancesResponse RestartOrFlushInstances(RestartOrFlushInstancesRequest restartOrFlushInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restartOrFlushInstancesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<RestartOrFlushInstancesResponse>(response);
        }

        public SyncInvoker<RestartOrFlushInstancesResponse> RestartOrFlushInstancesInvoker(RestartOrFlushInstancesRequest restartOrFlushInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restartOrFlushInstancesRequest);
            return new SyncInvoker<RestartOrFlushInstancesResponse>(this, "PUT", request, JsonUtils.DeSerialize<RestartOrFlushInstancesResponse>);
        }
        
        /// <summary>
        /// 恢复指定实例
        ///
        /// 恢复指定的缓存实例。
        /// &gt; 只有主备和集群类型的缓存实例支持备份恢复操作，单机实例不支持备份恢复操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreInstanceResponse RestoreInstance(RestoreInstanceRequest restoreInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restoreInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/restores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestoreInstanceResponse>(response);
        }

        public SyncInvoker<RestoreInstanceResponse> RestoreInstanceInvoker(RestoreInstanceRequest restoreInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restoreInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/restores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreInstanceRequest);
            return new SyncInvoker<RestoreInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreInstanceResponse>);
        }
        
        /// <summary>
        /// IP交换回滚
        ///
        /// IP交换回滚。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RollbackExchangeInstanceIpResponse RollbackExchangeInstanceIp(RollbackExchangeInstanceIpRequest rollbackExchangeInstanceIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", rollbackExchangeInstanceIpRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/rollback-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollbackExchangeInstanceIpRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RollbackExchangeInstanceIpResponse>(response);
        }

        public SyncInvoker<RollbackExchangeInstanceIpResponse> RollbackExchangeInstanceIpInvoker(RollbackExchangeInstanceIpRequest rollbackExchangeInstanceIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", rollbackExchangeInstanceIpRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/rollback-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollbackExchangeInstanceIpRequest);
            return new SyncInvoker<RollbackExchangeInstanceIpResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RollbackExchangeInstanceIpResponse>);
        }
        
        /// <summary>
        /// 下发查询会话列表任务
        ///
        /// 下发查询会话列表任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ScanClientsResponse ScanClients(ScanClientsRequest scanClientsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", scanClientsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/clients", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", scanClientsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ScanClientsResponse>(response);
        }

        public SyncInvoker<ScanClientsResponse> ScanClientsInvoker(ScanClientsRequest scanClientsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", scanClientsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/clients", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", scanClientsRequest);
            return new SyncInvoker<ScanClientsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ScanClientsResponse>);
        }
        
        /// <summary>
        /// 立刻扫描过期Key
        ///
        /// 立刻扫描过期Key
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ScanExpireKeyResponse ScanExpireKey(ScanExpireKeyRequest scanExpireKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", scanExpireKeyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/auto-expire/scan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", scanExpireKeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ScanExpireKeyResponse>(response);
        }

        public SyncInvoker<ScanExpireKeyResponse> ScanExpireKeyInvoker(ScanExpireKeyRequest scanExpireKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", scanExpireKeyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/auto-expire/scan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", scanExpireKeyRequest);
            return new SyncInvoker<ScanExpireKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<ScanExpireKeyResponse>);
        }
        
        /// <summary>
        /// 配置在线数据迁移任务
        ///
        /// 配置在线数据迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetOnlineMigrationTaskResponse SetOnlineMigrationTask(SetOnlineMigrationTaskRequest setOnlineMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", setOnlineMigrationTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration/{task_id}/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setOnlineMigrationTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetOnlineMigrationTaskResponse>(response);
        }

        public SyncInvoker<SetOnlineMigrationTaskResponse> SetOnlineMigrationTaskInvoker(SetOnlineMigrationTaskRequest setOnlineMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", setOnlineMigrationTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration/{task_id}/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setOnlineMigrationTaskRequest);
            return new SyncInvoker<SetOnlineMigrationTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<SetOnlineMigrationTaskResponse>);
        }
        
        /// <summary>
        /// 查询后台任务详细信息
        ///
        /// 查询后台任务详细信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBackgroundTaskProgressResponse ShowBackgroundTaskProgress(ShowBackgroundTaskProgressRequest showBackgroundTaskProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBackgroundTaskProgressRequest.InstanceId.ToString());
            urlParam.Add("task_id", showBackgroundTaskProgressRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}/progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackgroundTaskProgressRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBackgroundTaskProgressResponse>(response);
        }

        public SyncInvoker<ShowBackgroundTaskProgressResponse> ShowBackgroundTaskProgressInvoker(ShowBackgroundTaskProgressRequest showBackgroundTaskProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBackgroundTaskProgressRequest.InstanceId.ToString());
            urlParam.Add("task_id", showBackgroundTaskProgressRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}/progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackgroundTaskProgressRequest);
            return new SyncInvoker<ShowBackgroundTaskProgressResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackgroundTaskProgressResponse>);
        }
        
        /// <summary>
        /// 获取实例分片带宽
        ///
        /// 获取实例各个分片带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBandwidthsResponse ShowBandwidths(ShowBandwidthsRequest showBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBandwidthsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBandwidthsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBandwidthsResponse>(response);
        }

        public SyncInvoker<ShowBandwidthsResponse> ShowBandwidthsInvoker(ShowBandwidthsRequest showBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBandwidthsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBandwidthsRequest);
            return new SyncInvoker<ShowBandwidthsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBandwidthsResponse>);
        }
        
        /// <summary>
        /// 查询大key自动分析配置
        ///
        /// 查询大key自动分析配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBigkeyAutoscanConfigResponse ShowBigkeyAutoscanConfig(ShowBigkeyAutoscanConfigRequest showBigkeyAutoscanConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBigkeyAutoscanConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey/autoscan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBigkeyAutoscanConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBigkeyAutoscanConfigResponse>(response);
        }

        public SyncInvoker<ShowBigkeyAutoscanConfigResponse> ShowBigkeyAutoscanConfigInvoker(ShowBigkeyAutoscanConfigRequest showBigkeyAutoscanConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBigkeyAutoscanConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey/autoscan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBigkeyAutoscanConfigRequest);
            return new SyncInvoker<ShowBigkeyAutoscanConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBigkeyAutoscanConfigResponse>);
        }
        
        /// <summary>
        /// 查询大key分析详情
        ///
        /// 查询大key分析详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBigkeyScanTaskDetailsResponse ShowBigkeyScanTaskDetails(ShowBigkeyScanTaskDetailsRequest showBigkeyScanTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBigkeyScanTaskDetailsRequest.InstanceId.ToString());
            urlParam.Add("bigkey_id", showBigkeyScanTaskDetailsRequest.BigkeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey-task/{bigkey_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBigkeyScanTaskDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBigkeyScanTaskDetailsResponse>(response);
        }

        public SyncInvoker<ShowBigkeyScanTaskDetailsResponse> ShowBigkeyScanTaskDetailsInvoker(ShowBigkeyScanTaskDetailsRequest showBigkeyScanTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBigkeyScanTaskDetailsRequest.InstanceId.ToString());
            urlParam.Add("bigkey_id", showBigkeyScanTaskDetailsRequest.BigkeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey-task/{bigkey_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBigkeyScanTaskDetailsRequest);
            return new SyncInvoker<ShowBigkeyScanTaskDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBigkeyScanTaskDetailsResponse>);
        }
        
        /// <summary>
        /// 查询实例参数修改记录详情
        ///
        /// 查询实例参数修改记录详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConfigHistoryDetailResponse ShowConfigHistoryDetail(ShowConfigHistoryDetailRequest showConfigHistoryDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showConfigHistoryDetailRequest.InstanceId.ToString());
            urlParam.Add("history_id", showConfigHistoryDetailRequest.HistoryId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/config-histories/{history_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigHistoryDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerializeNull<ShowConfigHistoryDetailResponse>(response);
        }

        public SyncInvoker<ShowConfigHistoryDetailResponse> ShowConfigHistoryDetailInvoker(ShowConfigHistoryDetailRequest showConfigHistoryDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showConfigHistoryDetailRequest.InstanceId.ToString());
            urlParam.Add("history_id", showConfigHistoryDetailRequest.HistoryId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/config-histories/{history_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigHistoryDetailRequest);
            return new SyncInvoker<ShowConfigHistoryDetailResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ShowConfigHistoryDetailResponse>);
        }
        
        /// <summary>
        /// 查询参数模板详情
        ///
        /// 查询参数模板详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConfigTemplateResponse ShowConfigTemplate(ShowConfigTemplateRequest showConfigTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id", showConfigTemplateRequest.TemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigTemplateResponse>(response);
        }

        public SyncInvoker<ShowConfigTemplateResponse> ShowConfigTemplateInvoker(ShowConfigTemplateRequest showConfigTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id", showConfigTemplateRequest.TemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigTemplateRequest);
            return new SyncInvoker<ShowConfigTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigTemplateResponse>);
        }
        
        /// <summary>
        /// 查询指定诊断报告
        ///
        /// 通过报告ID查询诊断报告的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDiagnosisTaskDetailsResponse ShowDiagnosisTaskDetails(ShowDiagnosisTaskDetailsRequest showDiagnosisTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("report_id", showDiagnosisTaskDetailsRequest.ReportId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/diagnosis/{report_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiagnosisTaskDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDiagnosisTaskDetailsResponse>(response);
        }

        public SyncInvoker<ShowDiagnosisTaskDetailsResponse> ShowDiagnosisTaskDetailsInvoker(ShowDiagnosisTaskDetailsRequest showDiagnosisTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("report_id", showDiagnosisTaskDetailsRequest.ReportId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/diagnosis/{report_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiagnosisTaskDetailsRequest);
            return new SyncInvoker<ShowDiagnosisTaskDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDiagnosisTaskDetailsResponse>);
        }
        
        /// <summary>
        /// 查询自动扫描配置
        ///
        /// 查询自动扫描配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowExpireAutoScanConfigResponse ShowExpireAutoScanConfig(ShowExpireAutoScanConfigRequest showExpireAutoScanConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showExpireAutoScanConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/scan-expire-keys/autoscan-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExpireAutoScanConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowExpireAutoScanConfigResponse>(response);
        }

        public SyncInvoker<ShowExpireAutoScanConfigResponse> ShowExpireAutoScanConfigInvoker(ShowExpireAutoScanConfigRequest showExpireAutoScanConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showExpireAutoScanConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/scan-expire-keys/autoscan-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExpireAutoScanConfigRequest);
            return new SyncInvoker<ShowExpireAutoScanConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowExpireAutoScanConfigResponse>);
        }
        
        /// <summary>
        /// 查询过期Key扫描记录
        ///
        /// 查询过期Key扫描记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowExpireKeyScanInfoResponse ShowExpireKeyScanInfo(ShowExpireKeyScanInfoRequest showExpireKeyScanInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showExpireKeyScanInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/auto-expire/histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExpireKeyScanInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowExpireKeyScanInfoResponse>(response);
        }

        public SyncInvoker<ShowExpireKeyScanInfoResponse> ShowExpireKeyScanInfoInvoker(ShowExpireKeyScanInfoRequest showExpireKeyScanInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showExpireKeyScanInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/auto-expire/histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExpireKeyScanInfoRequest);
            return new SyncInvoker<ShowExpireKeyScanInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowExpireKeyScanInfoResponse>);
        }
        
        /// <summary>
        /// 查询热key自动分析配置
        ///
        /// 查询热key自动分析配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHotkeyAutoscanConfigResponse ShowHotkeyAutoscanConfig(ShowHotkeyAutoscanConfigRequest showHotkeyAutoscanConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showHotkeyAutoscanConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey/autoscan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotkeyAutoscanConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHotkeyAutoscanConfigResponse>(response);
        }

        public SyncInvoker<ShowHotkeyAutoscanConfigResponse> ShowHotkeyAutoscanConfigInvoker(ShowHotkeyAutoscanConfigRequest showHotkeyAutoscanConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showHotkeyAutoscanConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey/autoscan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotkeyAutoscanConfigRequest);
            return new SyncInvoker<ShowHotkeyAutoscanConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHotkeyAutoscanConfigResponse>);
        }
        
        /// <summary>
        /// 查询热key分析详情
        ///
        /// 查询热key分析详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHotkeyTaskDetailsResponse ShowHotkeyTaskDetails(ShowHotkeyTaskDetailsRequest showHotkeyTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showHotkeyTaskDetailsRequest.InstanceId.ToString());
            urlParam.Add("hotkey_id", showHotkeyTaskDetailsRequest.HotkeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey-task/{hotkey_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotkeyTaskDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHotkeyTaskDetailsResponse>(response);
        }

        public SyncInvoker<ShowHotkeyTaskDetailsResponse> ShowHotkeyTaskDetailsInvoker(ShowHotkeyTaskDetailsRequest showHotkeyTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showHotkeyTaskDetailsRequest.InstanceId.ToString());
            urlParam.Add("hotkey_id", showHotkeyTaskDetailsRequest.HotkeyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey-task/{hotkey_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotkeyTaskDetailsRequest);
            return new SyncInvoker<ShowHotkeyTaskDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHotkeyTaskDetailsResponse>);
        }
        
        /// <summary>
        /// 查询指定实例
        ///
        /// 通过实例ID查询实例的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceResponse ShowInstance(ShowInstanceRequest showInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceResponse>(response);
        }

        public SyncInvoker<ShowInstanceResponse> ShowInstanceInvoker(ShowInstanceRequest showInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            return new SyncInvoker<ShowInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceResponse>);
        }
        
        /// <summary>
        /// 查询实例带宽弹性伸缩策略
        ///
        /// 查询实例带宽弹性伸缩策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceBandwidthAutoScalingPolicyResponse ShowInstanceBandwidthAutoScalingPolicy(ShowInstanceBandwidthAutoScalingPolicyRequest showInstanceBandwidthAutoScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceBandwidthAutoScalingPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/autoscaling-policy/bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceBandwidthAutoScalingPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceBandwidthAutoScalingPolicyResponse>(response);
        }

        public SyncInvoker<ShowInstanceBandwidthAutoScalingPolicyResponse> ShowInstanceBandwidthAutoScalingPolicyInvoker(ShowInstanceBandwidthAutoScalingPolicyRequest showInstanceBandwidthAutoScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceBandwidthAutoScalingPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/autoscaling-policy/bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceBandwidthAutoScalingPolicyRequest);
            return new SyncInvoker<ShowInstanceBandwidthAutoScalingPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceBandwidthAutoScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 查询实例SSL信息
        ///
        /// 查询实例SSL信息。该接口目前仅针对Redis 6.0[基础版](tag:hws,hws_hk)版本实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceSslDetailResponse ShowInstanceSslDetail(ShowInstanceSslDetailRequest showInstanceSslDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceSslDetailRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceSslDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceSslDetailResponse>(response);
        }

        public SyncInvoker<ShowInstanceSslDetailResponse> ShowInstanceSslDetailInvoker(ShowInstanceSslDetailRequest showInstanceSslDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceSslDetailRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceSslDetailRequest);
            return new SyncInvoker<ShowInstanceSslDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceSslDetailResponse>);
        }
        
        /// <summary>
        /// 查询集群实例拓扑关系图
        ///
        /// 查询集群实例拓扑关系图。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceTopologyResponse ShowInstanceTopology(ShowInstanceTopologyRequest showInstanceTopologyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceTopologyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceTopologyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceTopologyResponse>(response);
        }

        public SyncInvoker<ShowInstanceTopologyResponse> ShowInstanceTopologyInvoker(ShowInstanceTopologyRequest showInstanceTopologyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceTopologyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceTopologyRequest);
            return new SyncInvoker<ShowInstanceTopologyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceTopologyResponse>);
        }
        
        /// <summary>
        /// 根据实例ID获取实例内核版本信息
        ///
        /// 获取对应实例内核版本号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceVersionResponse ShowInstanceVersion(ShowInstanceVersionRequest showInstanceVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceVersionResponse>(response);
        }

        public SyncInvoker<ShowInstanceVersionResponse> ShowInstanceVersionInvoker(ShowInstanceVersionRequest showInstanceVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceVersionRequest);
            return new SyncInvoker<ShowInstanceVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceVersionResponse>);
        }
        
        /// <summary>
        /// 查询租户Job执行结果
        ///
        /// 查询租户Job执行结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobInfoResponse ShowJobInfo(ShowJobInfoRequest showJobInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobInfoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobInfoResponse>(response);
        }

        public SyncInvoker<ShowJobInfoResponse> ShowJobInfoInvoker(ShowJobInfoRequest showJobInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobInfoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobInfoRequest);
            return new SyncInvoker<ShowJobInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobInfoResponse>);
        }
        
        /// <summary>
        /// 查询迁移任务详情
        ///
        /// 查询迁移任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMigrationTaskResponse ShowMigrationTask(ShowMigrationTaskRequest showMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", showMigrationTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMigrationTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMigrationTaskResponse>(response);
        }

        public SyncInvoker<ShowMigrationTaskResponse> ShowMigrationTaskInvoker(ShowMigrationTaskRequest showMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", showMigrationTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMigrationTaskRequest);
            return new SyncInvoker<ShowMigrationTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMigrationTaskResponse>);
        }
        
        /// <summary>
        /// 查询在线迁移进度明细
        ///
        /// 查询在线迁移进度明细。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMigrationTaskStatsResponse ShowMigrationTaskStats(ShowMigrationTaskStatsRequest showMigrationTaskStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", showMigrationTaskStatsRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMigrationTaskStatsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMigrationTaskStatsResponse>(response);
        }

        public SyncInvoker<ShowMigrationTaskStatsResponse> ShowMigrationTaskStatsInvoker(ShowMigrationTaskStatsRequest showMigrationTaskStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", showMigrationTaskStatsRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMigrationTaskStatsRequest);
            return new SyncInvoker<ShowMigrationTaskStatsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMigrationTaskStatsResponse>);
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
        public ShowNodesInformationResponse ShowNodesInformation(ShowNodesInformationRequest showNodesInformationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showNodesInformationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/logical-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodesInformationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowNodesInformationResponse>(response);
        }

        public SyncInvoker<ShowNodesInformationResponse> ShowNodesInformationInvoker(ShowNodesInformationRequest showNodesInformationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showNodesInformationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/logical-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodesInformationRequest);
            return new SyncInvoker<ShowNodesInformationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNodesInformationResponse>);
        }
        
        /// <summary>
        /// 查询租户配额
        ///
        /// 查询租户默认可以创建的实例数和总内存的配额限制，以及可以申请配额的最大值和最小值。不同的租户在不同的区域配额可能不同。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowQuotaOfTenantResponse ShowQuotaOfTenant(ShowQuotaOfTenantRequest showQuotaOfTenantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaOfTenantRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotaOfTenantResponse>(response);
        }

        public SyncInvoker<ShowQuotaOfTenantResponse> ShowQuotaOfTenantInvoker(ShowQuotaOfTenantRequest showQuotaOfTenantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaOfTenantRequest);
            return new SyncInvoker<ShowQuotaOfTenantResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotaOfTenantResponse>);
        }
        
        /// <summary>
        /// 获取副本状态
        ///
        /// 获取副本状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowReplicationStatesResponse ShowReplicationStates(ShowReplicationStatesRequest showReplicationStatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showReplicationStatesRequest.InstanceId.ToString());
            urlParam.Add("group_id", showReplicationStatesRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/groups/{group_id}/group-nodes-state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplicationStatesRequest);
            var response = DoHttpRequestSync("GET", request);
            var showReplicationStatesResponse = JsonUtils.DeSerializeNull<ShowReplicationStatesResponse>(response);
            showReplicationStatesResponse.Body = JsonUtils.DeSerializeList<InstanceReplicationListInfo>(response);
            return showReplicationStatesResponse;
        }

        public SyncInvoker<ShowReplicationStatesResponse> ShowReplicationStatesInvoker(ShowReplicationStatesRequest showReplicationStatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showReplicationStatesRequest.InstanceId.ToString());
            urlParam.Add("group_id", showReplicationStatesRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/groups/{group_id}/group-nodes-state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplicationStatesRequest);
            return new SyncInvoker<ShowReplicationStatesResponse>(this, "GET", request, response =>
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
        public ShowTagsResponse ShowTags(ShowTagsRequest showTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTagsResponse>(response);
        }

        public SyncInvoker<ShowTagsResponse> ShowTagsInvoker(ShowTagsRequest showTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagsRequest);
            return new SyncInvoker<ShowTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTagsResponse>);
        }
        
        /// <summary>
        /// 提交前置检查任务
        ///
        /// 提交前置检查任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartInstanceResizeCheckJobResponse StartInstanceResizeCheckJob(StartInstanceResizeCheckJobRequest startInstanceResizeCheckJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startInstanceResizeCheckJobRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/resize/check-job", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startInstanceResizeCheckJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartInstanceResizeCheckJobResponse>(response);
        }

        public SyncInvoker<StartInstanceResizeCheckJobResponse> StartInstanceResizeCheckJobInvoker(StartInstanceResizeCheckJobRequest startInstanceResizeCheckJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", startInstanceResizeCheckJobRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/resize/check-job", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", startInstanceResizeCheckJobRequest);
            return new SyncInvoker<StartInstanceResizeCheckJobResponse>(this, "POST", request, JsonUtils.DeSerialize<StartInstanceResizeCheckJobResponse>);
        }
        
        /// <summary>
        /// 停止数据迁移任务
        ///
        /// 停止数据迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopMigrationTaskResponse StopMigrationTask(StopMigrationTaskRequest stopMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", stopMigrationTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopMigrationTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopMigrationTaskResponse>(response);
        }

        public SyncInvoker<StopMigrationTaskResponse> StopMigrationTaskInvoker(StopMigrationTaskRequest stopMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", stopMigrationTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopMigrationTaskRequest);
            return new SyncInvoker<StopMigrationTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<StopMigrationTaskResponse>);
        }
        
        /// <summary>
        /// 同步停止数据迁移任务
        ///
        /// 同步停止数据迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopMigrationTaskSyncResponse StopMigrationTaskSync(StopMigrationTaskSyncRequest stopMigrationTaskSyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", stopMigrationTaskSyncRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/sync-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopMigrationTaskSyncRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<StopMigrationTaskSyncResponse>(response);
        }

        public SyncInvoker<StopMigrationTaskSyncResponse> StopMigrationTaskSyncInvoker(StopMigrationTaskSyncRequest stopMigrationTaskSyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", stopMigrationTaskSyncRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}/sync-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopMigrationTaskSyncRequest);
            return new SyncInvoker<StopMigrationTaskSyncResponse>(this, "POST", request, JsonUtils.DeSerializeNull<StopMigrationTaskSyncResponse>);
        }
        
        /// <summary>
        /// 修改ACL角色
        ///
        /// 修改用户的类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAclAccountResponse UpdateAclAccount(UpdateAclAccountRequest updateAclAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateAclAccountRequest.InstanceId.ToString());
            urlParam.Add("account_id", updateAclAccountRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}/role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAclAccountRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAclAccountResponse>(response);
        }

        public SyncInvoker<UpdateAclAccountResponse> UpdateAclAccountInvoker(UpdateAclAccountRequest updateAclAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateAclAccountRequest.InstanceId.ToString());
            urlParam.Add("account_id", updateAclAccountRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}/role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAclAccountRequest);
            return new SyncInvoker<UpdateAclAccountResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAclAccountResponse>);
        }
        
        /// <summary>
        /// 修改ACL账号密码
        ///
        /// 修改ACL账号密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAclAccountPassWordResponse UpdateAclAccountPassWord(UpdateAclAccountPassWordRequest updateAclAccountPassWordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateAclAccountPassWordRequest.InstanceId.ToString());
            urlParam.Add("account_id", updateAclAccountPassWordRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}/password/modify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAclAccountPassWordRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAclAccountPassWordResponse>(response);
        }

        public SyncInvoker<UpdateAclAccountPassWordResponse> UpdateAclAccountPassWordInvoker(UpdateAclAccountPassWordRequest updateAclAccountPassWordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateAclAccountPassWordRequest.InstanceId.ToString());
            urlParam.Add("account_id", updateAclAccountPassWordRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}/password/modify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAclAccountPassWordRequest);
            return new SyncInvoker<UpdateAclAccountPassWordResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAclAccountPassWordResponse>);
        }
        
        /// <summary>
        /// ACL账号修改备注
        ///
        /// ACL账号修改备注
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAclAccountRemarkResponse UpdateAclAccountRemark(UpdateAclAccountRemarkRequest updateAclAccountRemarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateAclAccountRemarkRequest.InstanceId.ToString());
            urlParam.Add("account_id", updateAclAccountRemarkRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAclAccountRemarkRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAclAccountRemarkResponse>(response);
        }

        public SyncInvoker<UpdateAclAccountRemarkResponse> UpdateAclAccountRemarkInvoker(UpdateAclAccountRemarkRequest updateAclAccountRemarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateAclAccountRemarkRequest.InstanceId.ToString());
            urlParam.Add("account_id", updateAclAccountRemarkRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/accounts/{account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAclAccountRemarkRequest);
            return new SyncInvoker<UpdateAclAccountRemarkResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAclAccountRemarkResponse>);
        }
        
        /// <summary>
        /// 修改实例分片带宽
        ///
        /// 修改实例分片带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateBandwidthResponse UpdateBandwidth(UpdateBandwidthRequest updateBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateBandwidthRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBandwidthRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateBandwidthResponse>(response);
        }

        public SyncInvoker<UpdateBandwidthResponse> UpdateBandwidthInvoker(UpdateBandwidthRequest updateBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateBandwidthRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBandwidthRequest);
            return new SyncInvoker<UpdateBandwidthResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateBandwidthResponse>);
        }
        
        /// <summary>
        /// 设置大key自动分析配置
        ///
        /// 设置大key自动分析配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateBigkeyAutoscanConfigResponse UpdateBigkeyAutoscanConfig(UpdateBigkeyAutoscanConfigRequest updateBigkeyAutoscanConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateBigkeyAutoscanConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey/autoscan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBigkeyAutoscanConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateBigkeyAutoscanConfigResponse>(response);
        }

        public SyncInvoker<UpdateBigkeyAutoscanConfigResponse> UpdateBigkeyAutoscanConfigInvoker(UpdateBigkeyAutoscanConfigRequest updateBigkeyAutoscanConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateBigkeyAutoscanConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bigkey/autoscan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBigkeyAutoscanConfigRequest);
            return new SyncInvoker<UpdateBigkeyAutoscanConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateBigkeyAutoscanConfigResponse>);
        }
        
        /// <summary>
        /// 开启或关闭客户端ip透传
        ///
        /// 开启或关闭客户端ip透传
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateClientIpTransparentTransmissionResponse UpdateClientIpTransparentTransmission(UpdateClientIpTransparentTransmissionRequest updateClientIpTransparentTransmissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateClientIpTransparentTransmissionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/client-ip-transparent-transmission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateClientIpTransparentTransmissionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateClientIpTransparentTransmissionResponse>(response);
        }

        public SyncInvoker<UpdateClientIpTransparentTransmissionResponse> UpdateClientIpTransparentTransmissionInvoker(UpdateClientIpTransparentTransmissionRequest updateClientIpTransparentTransmissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateClientIpTransparentTransmissionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{instance_id}/client-ip-transparent-transmission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateClientIpTransparentTransmissionRequest);
            return new SyncInvoker<UpdateClientIpTransparentTransmissionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateClientIpTransparentTransmissionResponse>);
        }
        
        /// <summary>
        /// 修改自定义模板
        ///
        /// 修改自定义模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateConfigTemplateResponse UpdateConfigTemplate(UpdateConfigTemplateRequest updateConfigTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id", updateConfigTemplateRequest.TemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateConfigTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateConfigTemplateResponse>(response);
        }

        public SyncInvoker<UpdateConfigTemplateResponse> UpdateConfigTemplateInvoker(UpdateConfigTemplateRequest updateConfigTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id", updateConfigTemplateRequest.TemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/config-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateConfigTemplateRequest);
            return new SyncInvoker<UpdateConfigTemplateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateConfigTemplateResponse>);
        }
        
        /// <summary>
        /// 修改实例配置参数
        ///
        /// 为了确保分布式缓存服务发挥出最优性能，您可以根据自己的业务情况对DCS缓存实例的运行参数进行调整。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateConfigurationsResponse UpdateConfigurations(UpdateConfigurationsRequest updateConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateConfigurationsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateConfigurationsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateConfigurationsResponse>(response);
        }

        public SyncInvoker<UpdateConfigurationsResponse> UpdateConfigurationsInvoker(UpdateConfigurationsRequest updateConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateConfigurationsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateConfigurationsRequest);
            return new SyncInvoker<UpdateConfigurationsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateConfigurationsResponse>);
        }
        
        /// <summary>
        /// 修改自动扫描配置
        ///
        /// 修改自动扫描配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateExpireAutoScanConfigResponse UpdateExpireAutoScanConfig(UpdateExpireAutoScanConfigRequest updateExpireAutoScanConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateExpireAutoScanConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/scan-expire-keys/autoscan-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateExpireAutoScanConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateExpireAutoScanConfigResponse>(response);
        }

        public SyncInvoker<UpdateExpireAutoScanConfigResponse> UpdateExpireAutoScanConfigInvoker(UpdateExpireAutoScanConfigRequest updateExpireAutoScanConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateExpireAutoScanConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/scan-expire-keys/autoscan-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateExpireAutoScanConfigRequest);
            return new SyncInvoker<UpdateExpireAutoScanConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateExpireAutoScanConfigResponse>);
        }
        
        /// <summary>
        /// 设置热key自动分析配置
        ///
        /// 设置热key自动分析配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateHotkeyAutoScanConfigResponse UpdateHotkeyAutoScanConfig(UpdateHotkeyAutoScanConfigRequest updateHotkeyAutoScanConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateHotkeyAutoScanConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey/autoscan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateHotkeyAutoScanConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHotkeyAutoScanConfigResponse>(response);
        }

        public SyncInvoker<UpdateHotkeyAutoScanConfigResponse> UpdateHotkeyAutoScanConfigInvoker(UpdateHotkeyAutoScanConfigRequest updateHotkeyAutoScanConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateHotkeyAutoScanConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/hotkey/autoscan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateHotkeyAutoScanConfigRequest);
            return new SyncInvoker<UpdateHotkeyAutoScanConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHotkeyAutoScanConfigResponse>);
        }
        
        /// <summary>
        /// 修改实例信息
        ///
        /// 修改缓存实例的信息，可修改信息包括实例名称、描述、备份策略、维护时间窗开始和结束时间以及安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest updateInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceResponse>(response);
        }

        public SyncInvoker<UpdateInstanceResponse> UpdateInstanceInvoker(UpdateInstanceRequest updateInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceRequest);
            return new SyncInvoker<UpdateInstanceResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceResponse>);
        }
        
        /// <summary>
        /// 变更指定实例的带宽
        ///
        /// 变更指定实例的带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceBandwidthResponse UpdateInstanceBandwidth(UpdateInstanceBandwidthRequest updateInstanceBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceBandwidthRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceBandwidthRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceBandwidthResponse>(response);
        }

        public SyncInvoker<UpdateInstanceBandwidthResponse> UpdateInstanceBandwidthInvoker(UpdateInstanceBandwidthRequest updateInstanceBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceBandwidthRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceBandwidthRequest);
            return new SyncInvoker<UpdateInstanceBandwidthResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceBandwidthResponse>);
        }
        
        /// <summary>
        /// 更新实例带宽弹性伸缩策略
        ///
        /// 更新实例带宽弹性伸缩策略。暂不支持实例带宽自动回缩。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceBandwidthAutoScalingPolicyResponse UpdateInstanceBandwidthAutoScalingPolicy(UpdateInstanceBandwidthAutoScalingPolicyRequest updateInstanceBandwidthAutoScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceBandwidthAutoScalingPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/autoscaling-policy/bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceBandwidthAutoScalingPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceBandwidthAutoScalingPolicyResponse>(response);
        }

        public SyncInvoker<UpdateInstanceBandwidthAutoScalingPolicyResponse> UpdateInstanceBandwidthAutoScalingPolicyInvoker(UpdateInstanceBandwidthAutoScalingPolicyRequest updateInstanceBandwidthAutoScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceBandwidthAutoScalingPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/autoscaling-policy/bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceBandwidthAutoScalingPolicyRequest);
            return new SyncInvoker<UpdateInstanceBandwidthAutoScalingPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceBandwidthAutoScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 异步修改实例配置参数
        ///
        /// 为了确保分布式缓存服务发挥出最优性能，您可以根据自己的业务情况对DCS缓存实例的运行参数进行调整。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceConfigResponse UpdateInstanceConfig(UpdateInstanceConfigRequest updateInstanceConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/async-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceConfigResponse>(response);
        }

        public SyncInvoker<UpdateInstanceConfigResponse> UpdateInstanceConfigInvoker(UpdateInstanceConfigRequest updateInstanceConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/async-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceConfigRequest);
            return new SyncInvoker<UpdateInstanceConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceConfigResponse>);
        }
        
        /// <summary>
        /// 设置IP白名单分组异步接口
        ///
        /// 为指定实例设置IP白名单分组，包含创建、停用、编辑、删除白名单四个功能。返回异步任务jobId，设置白名单分组信息会覆盖掉已有的白名单信息，因此在新增IP白名单分组时，需保留已有的白名单信息后再编辑新的白名单分组信息。
        /// [仅Redis 4.0及以上版本的实例支持设置IP白名单分组，Redis 3.0实例不支持该功能。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateIpWhitelistAsyncResponse UpdateIpWhitelistAsync(UpdateIpWhitelistAsyncRequest updateIpWhitelistAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateIpWhitelistAsyncRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/whitelist-async", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpWhitelistAsyncRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateIpWhitelistAsyncResponse>(response);
        }

        public SyncInvoker<UpdateIpWhitelistAsyncResponse> UpdateIpWhitelistAsyncInvoker(UpdateIpWhitelistAsyncRequest updateIpWhitelistAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateIpWhitelistAsyncRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/whitelist-async", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpWhitelistAsyncRequest);
            return new SyncInvoker<UpdateIpWhitelistAsyncResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateIpWhitelistAsyncResponse>);
        }
        
        /// <summary>
        /// 设置迁移任务自动重连
        ///
        /// 设置迁移任务自动重连
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMigrationTaskResponse UpdateMigrationTask(UpdateMigrationTaskRequest updateMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", updateMigrationTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMigrationTaskRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateMigrationTaskResponse>(response);
        }

        public SyncInvoker<UpdateMigrationTaskResponse> UpdateMigrationTaskInvoker(UpdateMigrationTaskRequest updateMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", updateMigrationTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/migration-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMigrationTaskRequest);
            return new SyncInvoker<UpdateMigrationTaskResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateMigrationTaskResponse>);
        }
        
        /// <summary>
        /// 修改密码
        ///
        /// 修改缓存实例的密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePasswordResponse UpdatePassword(UpdatePasswordRequest updatePasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePasswordRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePasswordResponse>(response);
        }

        public SyncInvoker<UpdatePasswordResponse> UpdatePasswordInvoker(UpdatePasswordRequest updatePasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePasswordRequest);
            return new SyncInvoker<UpdatePasswordResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePasswordResponse>);
        }
        
        /// <summary>
        /// 开启/修改实例公网访问
        ///
        /// 开启/修改实例公网访问。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePublicIpResponse UpdatePublicIp(UpdatePublicIpRequest updatePublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePublicIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePublicIpRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdatePublicIpResponse>(response);
        }

        public SyncInvoker<UpdatePublicIpResponse> UpdatePublicIpInvoker(UpdatePublicIpRequest updatePublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePublicIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePublicIpRequest);
            return new SyncInvoker<UpdatePublicIpResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdatePublicIpResponse>);
        }
        
        /// <summary>
        /// 设置备节点优先级
        ///
        /// 设置副本优先级，主节点故障时，权重越小的备节点切换为主节点的优先级越高。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSlavePriorityResponse UpdateSlavePriority(UpdateSlavePriorityRequest updateSlavePriorityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateSlavePriorityRequest.InstanceId.ToString());
            urlParam.Add("group_id", updateSlavePriorityRequest.GroupId.ToString());
            urlParam.Add("node_id", updateSlavePriorityRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group_id}/replications/{node_id}/slave-priority", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSlavePriorityRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateSlavePriorityResponse>(response);
        }

        public SyncInvoker<UpdateSlavePriorityResponse> UpdateSlavePriorityInvoker(UpdateSlavePriorityRequest updateSlavePriorityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateSlavePriorityRequest.InstanceId.ToString());
            urlParam.Add("group_id", updateSlavePriorityRequest.GroupId.ToString());
            urlParam.Add("node_id", updateSlavePriorityRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group_id}/replications/{node_id}/slave-priority", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSlavePriorityRequest);
            return new SyncInvoker<UpdateSlavePriorityResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateSlavePriorityResponse>);
        }
        
        /// <summary>
        /// 开启/关闭SSL
        ///
        /// 开启/关闭SSL。该接口目前仅针对Redis 6.0[基础版](tag:hws,hws_hk)版本实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSslSwitchResponse UpdateSslSwitch(UpdateSslSwitchRequest updateSslSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateSslSwitchRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSslSwitchRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSslSwitchResponse>(response);
        }

        public SyncInvoker<UpdateSslSwitchResponse> UpdateSslSwitchInvoker(UpdateSslSwitchRequest updateSslSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateSslSwitchRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSslSwitchRequest);
            return new SyncInvoker<UpdateSslSwitchResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSslSwitchResponse>);
        }
        
        /// <summary>
        /// 升级实例小版本
        ///
        /// 升级实例小版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeInstanceMinorVersionResponse UpgradeInstanceMinorVersion(UpgradeInstanceMinorVersionRequest upgradeInstanceMinorVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeInstanceMinorVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/minor-version/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeInstanceMinorVersionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpgradeInstanceMinorVersionResponse>(response);
        }

        public SyncInvoker<UpgradeInstanceMinorVersionResponse> UpgradeInstanceMinorVersionInvoker(UpgradeInstanceMinorVersionRequest upgradeInstanceMinorVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeInstanceMinorVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/minor-version/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeInstanceMinorVersionRequest);
            return new SyncInvoker<UpgradeInstanceMinorVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeInstanceMinorVersionResponse>);
        }
        
        /// <summary>
        /// 校验集群副本是否支持删除
        ///
        /// 校验集群副本是否支持删除
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ValidateDeletableReplicaResponse ValidateDeletableReplica(ValidateDeletableReplicaRequest validateDeletableReplicaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", validateDeletableReplicaRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/deletable-replication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateDeletableReplicaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ValidateDeletableReplicaResponse>(response);
        }

        public SyncInvoker<ValidateDeletableReplicaResponse> ValidateDeletableReplicaInvoker(ValidateDeletableReplicaRequest validateDeletableReplicaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", validateDeletableReplicaRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/deletable-replication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateDeletableReplicaRequest);
            return new SyncInvoker<ValidateDeletableReplicaResponse>(this, "GET", request, JsonUtils.DeSerialize<ValidateDeletableReplicaResponse>);
        }
        
        /// <summary>
        /// 查询指定实例的IP白名单
        ///
        /// 查询指定实例的IP白名单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowIpWhitelistResponse ShowIpWhitelist(ShowIpWhitelistRequest showIpWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showIpWhitelistRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/whitelist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpWhitelistRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowIpWhitelistResponse>(response);
        }

        public SyncInvoker<ShowIpWhitelistResponse> ShowIpWhitelistInvoker(ShowIpWhitelistRequest showIpWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showIpWhitelistRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/whitelist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpWhitelistRequest);
            return new SyncInvoker<ShowIpWhitelistResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIpWhitelistResponse>);
        }
        
        /// <summary>
        /// 设置IP白名单分组
        ///
        /// 为指定实例设置IP白名单分组，包含创建、停用、编辑、删除白名单四个功能
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateIpWhitelistResponse UpdateIpWhitelist(UpdateIpWhitelistRequest updateIpWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateIpWhitelistRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/whitelist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpWhitelistRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateIpWhitelistResponse>(response);
        }

        public SyncInvoker<UpdateIpWhitelistResponse> UpdateIpWhitelistInvoker(UpdateIpWhitelistRequest updateIpWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateIpWhitelistRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instance/{instance_id}/whitelist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpWhitelistRequest);
            return new SyncInvoker<UpdateIpWhitelistResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateIpWhitelistResponse>);
        }
        
        /// <summary>
        /// 创建离线全量key分析任务
        ///
        /// 创建离线全量key分析任务。离线全量key分析用于分析实例指定节点备份文件中的TOP100大key，每种数据类型前缀数量TOP50的key和每种数据类型key的内存占用和数量的分布情况。仅Redis 4.0、5.0、6.0版本及Redis企业版实例支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOfflineKeyAnalysisResponse CreateOfflineKeyAnalysis(CreateOfflineKeyAnalysisRequest createOfflineKeyAnalysisRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createOfflineKeyAnalysisRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/offline/key-analysis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOfflineKeyAnalysisRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateOfflineKeyAnalysisResponse>(response);
        }

        public SyncInvoker<CreateOfflineKeyAnalysisResponse> CreateOfflineKeyAnalysisInvoker(CreateOfflineKeyAnalysisRequest createOfflineKeyAnalysisRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createOfflineKeyAnalysisRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/offline/key-analysis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOfflineKeyAnalysisRequest);
            return new SyncInvoker<CreateOfflineKeyAnalysisResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOfflineKeyAnalysisResponse>);
        }
        
        /// <summary>
        /// 删除离线全量key分析记录
        ///
        /// 删除离线全量key分析记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteOfflineKeyAnalysisTaskResponse DeleteOfflineKeyAnalysisTask(DeleteOfflineKeyAnalysisTaskRequest deleteOfflineKeyAnalysisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteOfflineKeyAnalysisTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", deleteOfflineKeyAnalysisTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/offline/key-analysis/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOfflineKeyAnalysisTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteOfflineKeyAnalysisTaskResponse>(response);
        }

        public SyncInvoker<DeleteOfflineKeyAnalysisTaskResponse> DeleteOfflineKeyAnalysisTaskInvoker(DeleteOfflineKeyAnalysisTaskRequest deleteOfflineKeyAnalysisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteOfflineKeyAnalysisTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", deleteOfflineKeyAnalysisTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/offline/key-analysis/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOfflineKeyAnalysisTaskRequest);
            return new SyncInvoker<DeleteOfflineKeyAnalysisTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteOfflineKeyAnalysisTaskResponse>);
        }
        
        /// <summary>
        /// 查询离线全量key分析任务列表
        ///
        /// 查询离线全量key分析任务列表，支持Redis4.0、5.0、6.0版本及Redis企业版。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOfflineKeyAnalysisTaskResponse ListOfflineKeyAnalysisTask(ListOfflineKeyAnalysisTaskRequest listOfflineKeyAnalysisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listOfflineKeyAnalysisTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/offline/key-analysis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOfflineKeyAnalysisTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOfflineKeyAnalysisTaskResponse>(response);
        }

        public SyncInvoker<ListOfflineKeyAnalysisTaskResponse> ListOfflineKeyAnalysisTaskInvoker(ListOfflineKeyAnalysisTaskRequest listOfflineKeyAnalysisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listOfflineKeyAnalysisTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/offline/key-analysis", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOfflineKeyAnalysisTaskRequest);
            return new SyncInvoker<ListOfflineKeyAnalysisTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOfflineKeyAnalysisTaskResponse>);
        }
        
        /// <summary>
        /// 查询离线全量key分析详情
        ///
        /// 查询离线全量key分析详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOfflineKeyAnalysisTaskResponse ShowOfflineKeyAnalysisTask(ShowOfflineKeyAnalysisTaskRequest showOfflineKeyAnalysisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showOfflineKeyAnalysisTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", showOfflineKeyAnalysisTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/offline/key-analysis/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOfflineKeyAnalysisTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOfflineKeyAnalysisTaskResponse>(response);
        }

        public SyncInvoker<ShowOfflineKeyAnalysisTaskResponse> ShowOfflineKeyAnalysisTaskInvoker(ShowOfflineKeyAnalysisTaskRequest showOfflineKeyAnalysisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showOfflineKeyAnalysisTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", showOfflineKeyAnalysisTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/offline/key-analysis/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOfflineKeyAnalysisTaskRequest);
            return new SyncInvoker<ShowOfflineKeyAnalysisTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOfflineKeyAnalysisTaskResponse>);
        }
        
    }
}