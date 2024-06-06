using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3
{
    public partial class GaussDBforNoSQLClient : Client
    {
        public static ClientBuilder<GaussDBforNoSQLClient> NewBuilder()
        {
            return new ClientBuilder<GaussDBforNoSQLClient>();
        }

        
        /// <summary>
        /// 应用参数模板
        ///
        /// 将参数模板应用到实例，可以指定一个或多个实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ApplyConfigurationResponse ApplyConfiguration(ApplyConfigurationRequest applyConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", applyConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ApplyConfigurationResponse>(response);
        }

        public SyncInvoker<ApplyConfigurationResponse> ApplyConfigurationInvoker(ApplyConfigurationRequest applyConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", applyConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyConfigurationRequest);
            return new SyncInvoker<ApplyConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<ApplyConfigurationResponse>);
        }
        
        /// <summary>
        /// 批量添加或删除资源标签
        ///
        /// 批量添加或删除指定数据库实例的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchTagActionResponse BatchTagAction(BatchTagActionRequest batchTagActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchTagActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchTagActionResponse>(response);
        }

        public SyncInvoker<BatchTagActionResponse> BatchTagActionInvoker(BatchTagActionRequest batchTagActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchTagActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagActionRequest);
            return new SyncInvoker<BatchTagActionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchTagActionResponse>);
        }
        
        /// <summary>
        /// 校验实例是否可以与指定实例建立/解除容灾关系
        ///
        /// 校验实例是否可以与指定实例建立/解除容灾关系。若接口返回成功，表示可以与指定实例建立/解除容灾关系。
        /// 该接口需要对建立/解除容灾关系的两个实例各调用一次，2次调用都响应成功才能进行容灾关系的搭建/解除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckDisasterRecoveryOperationResponse CheckDisasterRecoveryOperation(CheckDisasterRecoveryOperationRequest checkDisasterRecoveryOperationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", checkDisasterRecoveryOperationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDisasterRecoveryOperationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CheckDisasterRecoveryOperationResponse>(response);
        }

        public SyncInvoker<CheckDisasterRecoveryOperationResponse> CheckDisasterRecoveryOperationInvoker(CheckDisasterRecoveryOperationRequest checkDisasterRecoveryOperationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", checkDisasterRecoveryOperationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDisasterRecoveryOperationRequest);
            return new SyncInvoker<CheckDisasterRecoveryOperationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CheckDisasterRecoveryOperationResponse>);
        }
        
        /// <summary>
        /// 判断弱密码
        ///
        /// 判断弱密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckWeekPasswordResponse CheckWeekPassword(CheckWeekPasswordRequest checkWeekPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/weak-password-verification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkWeekPasswordRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CheckWeekPasswordResponse>(response);
        }

        public SyncInvoker<CheckWeekPasswordResponse> CheckWeekPasswordInvoker(CheckWeekPasswordRequest checkWeekPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/weak-password-verification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkWeekPasswordRequest);
            return new SyncInvoker<CheckWeekPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckWeekPasswordResponse>);
        }
        
        /// <summary>
        /// 参数模板比较
        ///
        /// 比较两个参数模板之间的差异
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CompareConfigurationResponse CompareConfiguration(CompareConfigurationRequest compareConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/comparison", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareConfigurationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CompareConfigurationResponse>(response);
        }

        public SyncInvoker<CompareConfigurationResponse> CompareConfigurationInvoker(CompareConfigurationRequest compareConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/comparison", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareConfigurationRequest);
            return new SyncInvoker<CompareConfigurationResponse>(this, "POST", request, JsonUtils.DeSerialize<CompareConfigurationResponse>);
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
        /// 创建手动备份
        ///
        /// 创建手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateBackResponse CreateBack(CreateBackRequest createBackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createBackRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBackRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateBackResponse>(response);
        }

        public SyncInvoker<CreateBackResponse> CreateBackInvoker(CreateBackRequest createBackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createBackRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBackRequest);
            return new SyncInvoker<CreateBackResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBackResponse>);
        }
        
        /// <summary>
        /// ‘创建冷数据存储’
        ///
        /// ‘创建冷数据存储’
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateColdVolumeResponse CreateColdVolume(CreateColdVolumeRequest createColdVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createColdVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/cold-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createColdVolumeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateColdVolumeResponse>(response);
        }

        public SyncInvoker<CreateColdVolumeResponse> CreateColdVolumeInvoker(CreateColdVolumeRequest createColdVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createColdVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/cold-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createColdVolumeRequest);
            return new SyncInvoker<CreateColdVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateColdVolumeResponse>);
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
        /// 创建Redis数据库账号
        ///
        /// 在Redis实例中创建数据库帐号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDbUserResponse CreateDbUser(CreateDbUserRequest createDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDbUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDbUserResponse>(response);
        }

        public SyncInvoker<CreateDbUserResponse> CreateDbUserInvoker(CreateDbUserRequest createDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDbUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDbUserRequest);
            return new SyncInvoker<CreateDbUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDbUserResponse>);
        }
        
        /// <summary>
        /// 搭建实例与特定实例的容灾关系
        ///
        /// 搭建实例与特定实例的容灾关系。 该接口需要对搭建容灾关系的两个实例分别各调用一次，2次接口都调用成功才能成功搭建容灾关系。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDisasterRecoveryResponse CreateDisasterRecovery(CreateDisasterRecoveryRequest createDisasterRecoveryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDisasterRecoveryRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/construction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDisasterRecoveryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDisasterRecoveryResponse>(response);
        }

        public SyncInvoker<CreateDisasterRecoveryResponse> CreateDisasterRecoveryInvoker(CreateDisasterRecoveryRequest createDisasterRecoveryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDisasterRecoveryRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/construction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDisasterRecoveryRequest);
            return new SyncInvoker<CreateDisasterRecoveryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDisasterRecoveryResponse>);
        }
        
        /// <summary>
        /// 创建实例
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
        /// 删除手动备份
        ///
        /// 删除手动备份
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBackupResponse DeleteBackup(DeleteBackupRequest deleteBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteBackupResponse>(response);
        }

        public SyncInvoker<DeleteBackupResponse> DeleteBackupInvoker(DeleteBackupRequest deleteBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackupRequest);
            return new SyncInvoker<DeleteBackupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteBackupResponse>);
        }
        
        /// <summary>
        /// 删除参数模板
        ///
        /// 删除指定参数模板。
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
        /// 删除Redis数据库账号
        ///
        /// 删除Redis实例的数据库账号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDbUserResponse DeleteDbUser(DeleteDbUserRequest deleteDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDbUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbUserRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDbUserResponse>(response);
        }

        public SyncInvoker<DeleteDbUserResponse> DeleteDbUserInvoker(DeleteDbUserRequest deleteDbUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDbUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDbUserRequest);
            return new SyncInvoker<DeleteDbUserResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDbUserResponse>);
        }
        
        /// <summary>
        /// 解除实例与特定实例的容灾关系
        ///
        /// 解除实例与特定实例的容灾关系。 该接口需要对搭建容灾关系的两个实例分别各调用一次，2次接口都调用成功才能成功解除容灾关系。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDisasterRecoveryResponse DeleteDisasterRecovery(DeleteDisasterRecoveryRequest deleteDisasterRecoveryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDisasterRecoveryRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/deconstruction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDisasterRecoveryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteDisasterRecoveryResponse>(response);
        }

        public SyncInvoker<DeleteDisasterRecoveryResponse> DeleteDisasterRecoveryInvoker(DeleteDisasterRecoveryRequest deleteDisasterRecoveryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDisasterRecoveryRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/deconstruction", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDisasterRecoveryRequest);
            return new SyncInvoker<DeleteDisasterRecoveryResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteDisasterRecoveryResponse>);
        }
        
        /// <summary>
        /// 删除扩容失败的节点
        ///
        /// 删除扩容失败的节点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteEnlargeFailNodeResponse DeleteEnlargeFailNode(DeleteEnlargeFailNodeRequest deleteEnlargeFailNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteEnlargeFailNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/enlarge-failed-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnlargeFailNodeRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteEnlargeFailNodeResponse>(response);
        }

        public SyncInvoker<DeleteEnlargeFailNodeResponse> DeleteEnlargeFailNodeInvoker(DeleteEnlargeFailNodeRequest deleteEnlargeFailNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteEnlargeFailNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/enlarge-failed-nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnlargeFailNodeRequest);
            return new SyncInvoker<DeleteEnlargeFailNodeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteEnlargeFailNodeResponse>);
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
        /// 关闭实例节点会话
        ///
        /// 关闭实例节点会话。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstancesSessionResponse DeleteInstancesSession(DeleteInstancesSessionRequest deleteInstancesSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", deleteInstancesSessionRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/nodes/{node_id}/sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstancesSessionRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstancesSessionResponse>(response);
        }

        public SyncInvoker<DeleteInstancesSessionResponse> DeleteInstancesSessionInvoker(DeleteInstancesSessionRequest deleteInstancesSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", deleteInstancesSessionRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/nodes/{node_id}/sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstancesSessionRequest);
            return new SyncInvoker<DeleteInstancesSessionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstancesSessionResponse>);
        }
        
        /// <summary>
        /// 解除关联LTS日志流
        ///
        /// 将实例日志与LTS日志流解除关联，后台将取消上传实例日志到的LTS日志流里。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLtsConfigsResponse DeleteLtsConfigs(DeleteLtsConfigsRequest deleteLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLtsConfigsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLtsConfigsResponse>(response);
        }

        public SyncInvoker<DeleteLtsConfigsResponse> DeleteLtsConfigsInvoker(DeleteLtsConfigsRequest deleteLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLtsConfigsRequest);
            return new SyncInvoker<DeleteLtsConfigsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLtsConfigsResponse>);
        }
        
        /// <summary>
        /// 扩容指定集群实例的节点数量
        ///
        /// 扩容指定集群实例的节点数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExpandInstanceNodeResponse ExpandInstanceNode(ExpandInstanceNodeRequest expandInstanceNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", expandInstanceNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/enlarge-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandInstanceNodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExpandInstanceNodeResponse>(response);
        }

        public SyncInvoker<ExpandInstanceNodeResponse> ExpandInstanceNodeInvoker(ExpandInstanceNodeRequest expandInstanceNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", expandInstanceNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/enlarge-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", expandInstanceNodeRequest);
            return new SyncInvoker<ExpandInstanceNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<ExpandInstanceNodeResponse>);
        }
        
        /// <summary>
        /// 查询实例可变更规格
        ///
        /// 查询实例可变更规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAvailableFlavorInfosResponse ListAvailableFlavorInfos(ListAvailableFlavorInfosRequest listAvailableFlavorInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAvailableFlavorInfosRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/available-flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableFlavorInfosRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAvailableFlavorInfosResponse>(response);
        }

        public SyncInvoker<ListAvailableFlavorInfosResponse> ListAvailableFlavorInfosInvoker(ListAvailableFlavorInfosRequest listAvailableFlavorInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAvailableFlavorInfosRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/available-flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableFlavorInfosRequest);
            return new SyncInvoker<ListAvailableFlavorInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailableFlavorInfosResponse>);
        }
        
        /// <summary>
        /// 查询GeminiDB(for Cassandra)数据库慢日志
        ///
        /// 查询GeminiDB(for Cassandra)数据库慢日志信息，支持日志关键字搜索。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCassandraSlowLogsResponse ListCassandraSlowLogs(ListCassandraSlowLogsRequest listCassandraSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listCassandraSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/cassandra/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCassandraSlowLogsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListCassandraSlowLogsResponse>(response);
        }

        public SyncInvoker<ListCassandraSlowLogsResponse> ListCassandraSlowLogsInvoker(ListCassandraSlowLogsRequest listCassandraSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listCassandraSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/cassandra/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCassandraSlowLogsRequest);
            return new SyncInvoker<ListCassandraSlowLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListCassandraSlowLogsResponse>);
        }
        
        /// <summary>
        /// 查询支持参数模板的引擎信息
        ///
        /// 查询支持参数模板的引擎信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConfigurationDatastoresResponse ListConfigurationDatastores(ListConfigurationDatastoresRequest listConfigurationDatastoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/datastores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationDatastoresRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListConfigurationDatastoresResponse>(response);
        }

        public SyncInvoker<ListConfigurationDatastoresResponse> ListConfigurationDatastoresInvoker(ListConfigurationDatastoresRequest listConfigurationDatastoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/datastores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationDatastoresRequest);
            return new SyncInvoker<ListConfigurationDatastoresResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigurationDatastoresResponse>);
        }
        
        /// <summary>
        /// 获取参数模板列表
        ///
        /// 获取参数模板列表，包括所有数据库的默认参数模板和用户创建的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConfigurationTemplatesResponse ListConfigurationTemplates(ListConfigurationTemplatesRequest listConfigurationTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListConfigurationTemplatesResponse>(response);
        }

        public SyncInvoker<ListConfigurationTemplatesResponse> ListConfigurationTemplatesInvoker(ListConfigurationTemplatesRequest listConfigurationTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationTemplatesRequest);
            return new SyncInvoker<ListConfigurationTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigurationTemplatesResponse>);
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
        /// 查询指定实例类型的数据库版本信息
        ///
        /// 查询指定实例类型的数据库版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDatastoresResponse ListDatastores(ListDatastoresRequest listDatastoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("datastore_name", listDatastoresRequest.DatastoreName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores/{datastore_name}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoresRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDatastoresResponse>(response);
        }

        public SyncInvoker<ListDatastoresResponse> ListDatastoresInvoker(ListDatastoresRequest listDatastoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("datastore_name", listDatastoresRequest.DatastoreName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores/{datastore_name}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatastoresRequest);
            return new SyncInvoker<ListDatastoresResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatastoresResponse>);
        }
        
        /// <summary>
        /// 获取Redis数据库账号列表和详情
        ///
        /// 获取Redis数据库账号列表和详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDbUsersResponse ListDbUsers(ListDbUsersRequest listDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDbUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDbUsersResponse>(response);
        }

        public SyncInvoker<ListDbUsersResponse> ListDbUsersInvoker(ListDbUsersRequest listDbUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDbUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbUsersRequest);
            return new SyncInvoker<ListDbUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDbUsersResponse>);
        }
        
        /// <summary>
        /// 查询专属资源列表
        ///
        /// 查询专属资源列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDedicatedResourcesResponse ListDedicatedResources(ListDedicatedResourcesRequest listDedicatedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dedicated-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDedicatedResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDedicatedResourcesResponse>(response);
        }

        public SyncInvoker<ListDedicatedResourcesResponse> ListDedicatedResourcesInvoker(ListDedicatedResourcesRequest listDedicatedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dedicated-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDedicatedResourcesRequest);
            return new SyncInvoker<ListDedicatedResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDedicatedResourcesResponse>);
        }
        
        /// <summary>
        /// 查询企业项目配额
        ///
        /// 查询企业项目配额。
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
        /// 查询指定条件下的实例规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFlavorInfosResponse ListFlavorInfos(ListFlavorInfosRequest listFlavorInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorInfosRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorInfosResponse>(response);
        }

        public SyncInvoker<ListFlavorInfosResponse> ListFlavorInfosInvoker(ListFlavorInfosRequest listFlavorInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorInfosRequest);
            return new SyncInvoker<ListFlavorInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorInfosResponse>);
        }
        
        /// <summary>
        /// 查询指定条件下的所有实例规格信息
        ///
        /// 查询指定条件下的所有实例规格信息。
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
        /// 查询GeminiDB(for influxdb)数据库慢日志
        ///
        /// 查询GeminiDB(for influxdb)数据库慢日志信息，支持日志关键字搜索。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInfluxdbSlowLogsResponse ListInfluxdbSlowLogs(ListInfluxdbSlowLogsRequest listInfluxdbSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInfluxdbSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/influxdb/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInfluxdbSlowLogsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListInfluxdbSlowLogsResponse>(response);
        }

        public SyncInvoker<ListInfluxdbSlowLogsResponse> ListInfluxdbSlowLogsInvoker(ListInfluxdbSlowLogsRequest listInfluxdbSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInfluxdbSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/influxdb/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInfluxdbSlowLogsRequest);
            return new SyncInvoker<ListInfluxdbSlowLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInfluxdbSlowLogsResponse>);
        }
        
        /// <summary>
        /// 获取Redis实例数据库列表
        ///
        /// 获取Redis实例数据库列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceDatabasesResponse ListInstanceDatabases(ListInstanceDatabasesRequest listInstanceDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceDatabasesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceDatabasesResponse>(response);
        }

        public SyncInvoker<ListInstanceDatabasesResponse> ListInstanceDatabasesInvoker(ListInstanceDatabasesRequest listInstanceDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceDatabasesRequest);
            return new SyncInvoker<ListInstanceDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceDatabasesResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询指定实例的标签信息。
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
        /// 查询实例列表和详情
        ///
        /// 根据指定条件查询数据库实例列表和详情。
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
        /// 查询资源实例
        ///
        /// 根据标签查询指定的数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstancesByResourceTagsResponse ListInstancesByResourceTags(ListInstancesByResourceTagsRequest listInstancesByResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/resource-instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesByResourceTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListInstancesByResourceTagsResponse>(response);
        }

        public SyncInvoker<ListInstancesByResourceTagsResponse> ListInstancesByResourceTagsInvoker(ListInstancesByResourceTagsRequest listInstancesByResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/resource-instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesByResourceTagsRequest);
            return new SyncInvoker<ListInstancesByResourceTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInstancesByResourceTagsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例
        ///
        /// 根据标签查询指定的数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstancesByTagsResponse ListInstancesByTags(ListInstancesByTagsRequest listInstancesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListInstancesByTagsResponse>(response);
        }

        public SyncInvoker<ListInstancesByTagsResponse> ListInstancesByTagsInvoker(ListInstancesByTagsRequest listInstancesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesByTagsRequest);
            return new SyncInvoker<ListInstancesByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInstancesByTagsResponse>);
        }
        
        /// <summary>
        /// 获取节点会话列表
        ///
        /// 获取节点会话列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstancesSessionResponse ListInstancesSession(ListInstancesSessionRequest listInstancesSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", listInstancesSessionRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/nodes/{node_id}/sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesSessionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesSessionResponse>(response);
        }

        public SyncInvoker<ListInstancesSessionResponse> ListInstancesSessionInvoker(ListInstancesSessionRequest listInstancesSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", listInstancesSessionRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/nodes/{node_id}/sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesSessionRequest);
            return new SyncInvoker<ListInstancesSessionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesSessionResponse>);
        }
        
        /// <summary>
        /// 查询实例节点会话统计信息
        ///
        /// 查询实例节点会话统计信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstancesSessionStatisticsResponse ListInstancesSessionStatistics(ListInstancesSessionStatisticsRequest listInstancesSessionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", listInstancesSessionStatisticsRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/nodes/{node_id}/session-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesSessionStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesSessionStatisticsResponse>(response);
        }

        public SyncInvoker<ListInstancesSessionStatisticsResponse> ListInstancesSessionStatisticsInvoker(ListInstancesSessionStatisticsRequest listInstancesSessionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("node_id", listInstancesSessionStatisticsRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/nodes/{node_id}/session-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesSessionStatisticsRequest);
            return new SyncInvoker<ListInstancesSessionStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesSessionStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询任务列表和详情
        ///
        /// 查询任务列表和详情，默认查询任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListJobsResponse ListJobs(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListJobsResponse>(response);
        }

        public SyncInvoker<ListJobsResponse> ListJobsInvoker(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            return new SyncInvoker<ListJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobsResponse>);
        }
        
        /// <summary>
        /// 查询LTS日志配置信息
        ///
        /// 分页查询实例关联的LTS日志配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLtsConfigsResponse ListLtsConfigs(ListLtsConfigsRequest listLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLtsConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLtsConfigsResponse>(response);
        }

        public SyncInvoker<ListLtsConfigsResponse> ListLtsConfigsInvoker(ListLtsConfigsRequest listLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLtsConfigsRequest);
            return new SyncInvoker<ListLtsConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLtsConfigsResponse>);
        }
        
        /// <summary>
        /// 查询GeminiDB(for Mongo)数据库错误日志
        ///
        /// 查询GeminiDB(for Mongo)数据库错误日志信息，支持日志关键字搜索。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMongodbErrorLogsResponse ListMongodbErrorLogs(ListMongodbErrorLogsRequest listMongodbErrorLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listMongodbErrorLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/mongodb/instances/{instance_id}/error-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMongodbErrorLogsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListMongodbErrorLogsResponse>(response);
        }

        public SyncInvoker<ListMongodbErrorLogsResponse> ListMongodbErrorLogsInvoker(ListMongodbErrorLogsRequest listMongodbErrorLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listMongodbErrorLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/mongodb/instances/{instance_id}/error-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMongodbErrorLogsRequest);
            return new SyncInvoker<ListMongodbErrorLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListMongodbErrorLogsResponse>);
        }
        
        /// <summary>
        /// 查询GeminiDB(for Mongo)数据库慢日志
        ///
        /// 查询GeminiDB(for Mongo)数据库慢日志信息，支持日志关键字搜索。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMongodbSlowLogsResponse ListMongodbSlowLogs(ListMongodbSlowLogsRequest listMongodbSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listMongodbSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/mongodb/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMongodbSlowLogsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListMongodbSlowLogsResponse>(response);
        }

        public SyncInvoker<ListMongodbSlowLogsResponse> ListMongodbSlowLogsInvoker(ListMongodbSlowLogsRequest listMongodbSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listMongodbSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/mongodb/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMongodbSlowLogsRequest);
            return new SyncInvoker<ListMongodbSlowLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListMongodbSlowLogsResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询指定项目的标签信息。
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
        /// 查询回收站实例列表
        ///
        /// 查询回收站所有引擎的实例列表。
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
        /// 查询GeminiDB(for Redis)数据库慢日志
        ///
        /// 查询GeminiDB(for Redis)数据库慢日志信息，支持日志关键字搜索。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRedisSlowLogsResponse ListRedisSlowLogs(ListRedisSlowLogsRequest listRedisSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRedisSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRedisSlowLogsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListRedisSlowLogsResponse>(response);
        }

        public SyncInvoker<ListRedisSlowLogsResponse> ListRedisSlowLogsInvoker(ListRedisSlowLogsRequest listRedisSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRedisSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRedisSlowLogsRequest);
            return new SyncInvoker<ListRedisSlowLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListRedisSlowLogsResponse>);
        }
        
        /// <summary>
        /// 获取GeminiDB(for Cassandra)实例表级恢复的数据库信息
        ///
        /// 获取GeminiDB(for Cassandra)实例表级恢复的数据库信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRestoreDatabasesResponse ListRestoreDatabases(ListRestoreDatabasesRequest listRestoreDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreDatabasesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRestoreDatabasesResponse>(response);
        }

        public SyncInvoker<ListRestoreDatabasesResponse> ListRestoreDatabasesInvoker(ListRestoreDatabasesRequest listRestoreDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreDatabasesRequest);
            return new SyncInvoker<ListRestoreDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestoreDatabasesResponse>);
        }
        
        /// <summary>
        /// 获取GeminiDB(for Cassandra)实例表级恢复的表信息
        ///
        /// 获取GeminiDB(for Cassandra)实例表级恢复的表信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRestoreTablesResponse ListRestoreTables(ListRestoreTablesRequest listRestoreTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreTablesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTablesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRestoreTablesResponse>(response);
        }

        public SyncInvoker<ListRestoreTablesResponse> ListRestoreTablesInvoker(ListRestoreTablesRequest listRestoreTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreTablesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTablesRequest);
            return new SyncInvoker<ListRestoreTablesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestoreTablesResponse>);
        }
        
        /// <summary>
        /// 查询实例可恢复的时间段
        ///
        /// 查询实例可恢复的时间段
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRestoreTimeResponse ListRestoreTime(ListRestoreTimeRequest listRestoreTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreTimeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/restorable-time-periods", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTimeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRestoreTimeResponse>(response);
        }

        public SyncInvoker<ListRestoreTimeResponse> ListRestoreTimeInvoker(ListRestoreTimeRequest listRestoreTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRestoreTimeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/restorable-time-periods", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRestoreTimeRequest);
            return new SyncInvoker<ListRestoreTimeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRestoreTimeResponse>);
        }
        
        /// <summary>
        /// 查询数据库慢日志
        ///
        /// 查询数据库慢日志信息。
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
        /// 修改Redis数据库帐号权限
        ///
        /// 修改Redis数据库帐号权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyDbUserPrivilegeResponse ModifyDbUserPrivilege(ModifyDbUserPrivilegeRequest modifyDbUserPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyDbUserPrivilegeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/db-users/privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyDbUserPrivilegeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyDbUserPrivilegeResponse>(response);
        }

        public SyncInvoker<ModifyDbUserPrivilegeResponse> ModifyDbUserPrivilegeInvoker(ModifyDbUserPrivilegeRequest modifyDbUserPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyDbUserPrivilegeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/db-users/privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyDbUserPrivilegeRequest);
            return new SyncInvoker<ModifyDbUserPrivilegeResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyDbUserPrivilegeResponse>);
        }
        
        /// <summary>
        /// 修改企业项目配额
        ///
        /// 修改企业项目配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyEpsQuotasResponse ModifyEpsQuotas(ModifyEpsQuotasRequest modifyEpsQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyEpsQuotasRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ModifyEpsQuotasResponse>(response);
        }

        public SyncInvoker<ModifyEpsQuotasResponse> ModifyEpsQuotasInvoker(ModifyEpsQuotasRequest modifyEpsQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyEpsQuotasRequest);
            return new SyncInvoker<ModifyEpsQuotasResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ModifyEpsQuotasResponse>);
        }
        
        /// <summary>
        /// 修改数据库端口
        ///
        /// 修改数据库实例的端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyPortResponse ModifyPort(ModifyPortRequest modifyPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyPortRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyPortRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyPortResponse>(response);
        }

        public SyncInvoker<ModifyPortResponse> ModifyPortInvoker(ModifyPortRequest modifyPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyPortRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyPortRequest);
            return new SyncInvoker<ModifyPortResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyPortResponse>);
        }
        
        /// <summary>
        /// 绑定/解绑弹性公网IP
        ///
        /// 实例下的节点绑定弹性公网IP/解绑弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyPublicIpResponse ModifyPublicIp(ModifyPublicIpRequest modifyPublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyPublicIpRequest.InstanceId.ToString());
            urlParam.Add("node_id", modifyPublicIpRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyPublicIpRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ModifyPublicIpResponse>(response);
        }

        public SyncInvoker<ModifyPublicIpResponse> ModifyPublicIpInvoker(ModifyPublicIpRequest modifyPublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyPublicIpRequest.InstanceId.ToString());
            urlParam.Add("node_id", modifyPublicIpRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/public-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyPublicIpRequest);
            return new SyncInvoker<ModifyPublicIpResponse>(this, "POST", request, JsonUtils.DeSerialize<ModifyPublicIpResponse>);
        }
        
        /// <summary>
        /// 变更实例存储容量
        ///
        /// 变更实例的存储容量大小
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyVolumeResponse ModifyVolume(ModifyVolumeRequest modifyVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyVolumeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyVolumeResponse>(response);
        }

        public SyncInvoker<ModifyVolumeResponse> ModifyVolumeInvoker(ModifyVolumeRequest modifyVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyVolumeRequest);
            return new SyncInvoker<ModifyVolumeResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyVolumeResponse>);
        }
        
        /// <summary>
        /// 支持节点的开关机
        ///
        /// 当底层故障导致节点无法正常工作时，可以对该节点执行关机操作，关机后会由其他节点接管业务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public OfflineNodesResponse OfflineNodes(OfflineNodesRequest offlineNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", offlineNodesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", offlineNodesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<OfflineNodesResponse>(response);
        }

        public SyncInvoker<OfflineNodesResponse> OfflineNodesInvoker(OfflineNodesRequest offlineNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", offlineNodesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", offlineNodesRequest);
            return new SyncInvoker<OfflineNodesResponse>(this, "PUT", request, JsonUtils.DeSerialize<OfflineNodesResponse>);
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
        public PauseResumeDataSynchronizationResponse PauseResumeDataSynchronization(PauseResumeDataSynchronizationRequest pauseResumeDataSynchronizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", pauseResumeDataSynchronizationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/data-synchronization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", pauseResumeDataSynchronizationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<PauseResumeDataSynchronizationResponse>(response);
        }

        public SyncInvoker<PauseResumeDataSynchronizationResponse> PauseResumeDataSynchronizationInvoker(PauseResumeDataSynchronizationRequest pauseResumeDataSynchronizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", pauseResumeDataSynchronizationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/data-synchronization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", pauseResumeDataSynchronizationRequest);
            return new SyncInvoker<PauseResumeDataSynchronizationResponse>(this, "POST", request, JsonUtils.DeSerialize<PauseResumeDataSynchronizationResponse>);
        }
        
        /// <summary>
        /// 重置Redis数据库账号密码
        ///
        /// 重置Redis数据库账号密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetDbUserPasswordResponse ResetDbUserPassword(ResetDbUserPasswordRequest resetDbUserPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetDbUserPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/db-users/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetDbUserPasswordRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetDbUserPasswordResponse>(response);
        }

        public SyncInvoker<ResetDbUserPasswordResponse> ResetDbUserPasswordInvoker(ResetDbUserPasswordRequest resetDbUserPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetDbUserPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/redis/instances/{instance_id}/db-users/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetDbUserPasswordRequest);
            return new SyncInvoker<ResetDbUserPasswordResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetDbUserPasswordResponse>);
        }
        
        /// <summary>
        /// 重置自定义参数模板
        ///
        /// 重置自定义参数模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetParamGroupTemplateResponse ResetParamGroupTemplate(ResetParamGroupTemplateRequest resetParamGroupTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", resetParamGroupTemplateRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetParamGroupTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ResetParamGroupTemplateResponse>(response);
        }

        public SyncInvoker<ResetParamGroupTemplateResponse> ResetParamGroupTemplateInvoker(ResetParamGroupTemplateRequest resetParamGroupTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", resetParamGroupTemplateRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetParamGroupTemplateRequest);
            return new SyncInvoker<ResetParamGroupTemplateResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetParamGroupTemplateResponse>);
        }
        
        /// <summary>
        /// 修改实例的管理员密码
        ///
        /// 修改实例的管理员密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetPasswordResponse ResetPassword(ResetPasswordRequest resetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPasswordRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetPasswordResponse>(response);
        }

        public SyncInvoker<ResetPasswordResponse> ResetPasswordInvoker(ResetPasswordRequest resetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPasswordRequest);
            return new SyncInvoker<ResetPasswordResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetPasswordResponse>);
        }
        
        /// <summary>
        /// 扩容冷数据存储
        ///
        /// 扩容冷数据存储。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResizeColdVolumeResponse ResizeColdVolume(ResizeColdVolumeRequest resizeColdVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeColdVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/cold-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeColdVolumeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ResizeColdVolumeResponse>(response);
        }

        public SyncInvoker<ResizeColdVolumeResponse> ResizeColdVolumeInvoker(ResizeColdVolumeRequest resizeColdVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeColdVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/cold-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeColdVolumeRequest);
            return new SyncInvoker<ResizeColdVolumeResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResizeColdVolumeResponse>);
        }
        
        /// <summary>
        /// 变更实例规格
        ///
        /// 变更实例的规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResizeInstanceResponse ResizeInstance(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ResizeInstanceResponse>(response);
        }

        public SyncInvoker<ResizeInstanceResponse> ResizeInstanceInvoker(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/resize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceRequest);
            return new SyncInvoker<ResizeInstanceResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResizeInstanceResponse>);
        }
        
        /// <summary>
        /// 扩容实例存储容量
        ///
        /// 扩容实例的存储容量大小。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResizeInstanceVolumeResponse ResizeInstanceVolume(ResizeInstanceVolumeRequest resizeInstanceVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extend-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceVolumeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResizeInstanceVolumeResponse>(response);
        }

        public SyncInvoker<ResizeInstanceVolumeResponse> ResizeInstanceVolumeInvoker(ResizeInstanceVolumeRequest resizeInstanceVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/extend-volume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceVolumeRequest);
            return new SyncInvoker<ResizeInstanceVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeInstanceVolumeResponse>);
        }
        
        /// <summary>
        /// 重启实例的数据库服务
        ///
        /// 重启实例的数据库服务。
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
        /// 恢复到已有实例
        ///
        /// 恢复到已有实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreExistingInstanceResponse RestoreExistingInstance(RestoreExistingInstanceRequest restoreExistingInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restoreExistingInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreExistingInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestoreExistingInstanceResponse>(response);
        }

        public SyncInvoker<RestoreExistingInstanceResponse> RestoreExistingInstanceInvoker(RestoreExistingInstanceRequest restoreExistingInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restoreExistingInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/recovery", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreExistingInstanceRequest);
            return new SyncInvoker<RestoreExistingInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreExistingInstanceResponse>);
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
        public SaveLtsConfigsResponse SaveLtsConfigs(SaveLtsConfigsRequest saveLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveLtsConfigsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SaveLtsConfigsResponse>(response);
        }

        public SyncInvoker<SaveLtsConfigsResponse> SaveLtsConfigsInvoker(SaveLtsConfigsRequest saveLtsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/logs/lts-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveLtsConfigsRequest);
            return new SyncInvoker<SaveLtsConfigsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SaveLtsConfigsResponse>);
        }
        
        /// <summary>
        /// 设置磁盘自动扩容策略
        ///
        /// 设置磁盘自动扩容策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetAutoEnlargePolicyResponse SetAutoEnlargePolicy(SetAutoEnlargePolicyRequest setAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/disk-auto-expansion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAutoEnlargePolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetAutoEnlargePolicyResponse>(response);
        }

        public SyncInvoker<SetAutoEnlargePolicyResponse> SetAutoEnlargePolicyInvoker(SetAutoEnlargePolicyRequest setAutoEnlargePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/disk-auto-expansion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAutoEnlargePolicyRequest);
            return new SyncInvoker<SetAutoEnlargePolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetAutoEnlargePolicyResponse>);
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
        /// 设置回收策略
        ///
        /// 设置已删除实例保留天数，修改保留天数后删除的实例按照新的天数保留，修改之前已在回收站的实例保留天数不变。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetRecyclePolicyResponse SetRecyclePolicy(SetRecyclePolicyRequest setRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRecyclePolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetRecyclePolicyResponse>(response);
        }

        public SyncInvoker<SetRecyclePolicyResponse> SetRecyclePolicyInvoker(SetRecyclePolicyRequest setRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/recycle-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRecyclePolicyRequest);
            return new SyncInvoker<SetRecyclePolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetRecyclePolicyResponse>);
        }
        
        /// <summary>
        /// 查询备份列表
        ///
        /// 根据指定条件查询备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAllInstancesBackupsResponse ShowAllInstancesBackups(ShowAllInstancesBackupsRequest showAllInstancesBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllInstancesBackupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAllInstancesBackupsResponse>(response);
        }

        public SyncInvoker<ShowAllInstancesBackupsResponse> ShowAllInstancesBackupsInvoker(ShowAllInstancesBackupsRequest showAllInstancesBackupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllInstancesBackupsRequest);
            return new SyncInvoker<ShowAllInstancesBackupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAllInstancesBackupsResponse>);
        }
        
        /// <summary>
        /// 查询备份列表（推荐）
        ///
        /// 根据指定条件查询备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAllInstancesBackupsNewResponse ShowAllInstancesBackupsNew(ShowAllInstancesBackupsNewRequest showAllInstancesBackupsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllInstancesBackupsNewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAllInstancesBackupsNewResponse>(response);
        }

        public SyncInvoker<ShowAllInstancesBackupsNewResponse> ShowAllInstancesBackupsNewInvoker(ShowAllInstancesBackupsNewRequest showAllInstancesBackupsNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllInstancesBackupsNewRequest);
            return new SyncInvoker<ShowAllInstancesBackupsNewResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAllInstancesBackupsNewResponse>);
        }
        
        /// <summary>
        /// 查询参数模板可应用的实例列表
        ///
        /// 查询参数模板可应用的实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowApplicableInstancesResponse ShowApplicableInstances(ShowApplicableInstancesRequest showApplicableInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showApplicableInstancesRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applicable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplicableInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowApplicableInstancesResponse>(response);
        }

        public SyncInvoker<ShowApplicableInstancesResponse> ShowApplicableInstancesInvoker(ShowApplicableInstancesRequest showApplicableInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showApplicableInstancesRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applicable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplicableInstancesRequest);
            return new SyncInvoker<ShowApplicableInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApplicableInstancesResponse>);
        }
        
        /// <summary>
        /// 查询参数模板应用历史
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowApplyHistoryResponse ShowApplyHistory(ShowApplyHistoryRequest showApplyHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showApplyHistoryRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applied-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplyHistoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowApplyHistoryResponse>(response);
        }

        public SyncInvoker<ShowApplyHistoryResponse> ShowApplyHistoryInvoker(ShowApplyHistoryRequest showApplyHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showApplyHistoryRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}/applied-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplyHistoryRequest);
            return new SyncInvoker<ShowApplyHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApplyHistoryResponse>);
        }
        
        /// <summary>
        /// 查询磁盘自动扩容策略
        ///
        /// 查询磁盘自动扩容策略
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
        /// 获取指定参数模板的参数
        ///
        /// 获取指定参数模板的详细信息。
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
        /// 查询实例负载均衡的IP访问黑白名单
        ///
        /// 查询实例负载均衡的IP访问黑白名单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowElbIpGroupResponse ShowElbIpGroup(ShowElbIpGroupRequest showElbIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showElbIpGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/lb/access-control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showElbIpGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowElbIpGroupResponse>(response);
        }

        public SyncInvoker<ShowElbIpGroupResponse> ShowElbIpGroupInvoker(ShowElbIpGroupRequest showElbIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showElbIpGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/lb/access-control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showElbIpGroupRequest);
            return new SyncInvoker<ShowElbIpGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowElbIpGroupResponse>);
        }
        
        /// <summary>
        /// 查询数据库错误日志信息
        ///
        /// 查询数据库错误日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowErrorLogResponse ShowErrorLog(ShowErrorLogRequest showErrorLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showErrorLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showErrorLogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowErrorLogResponse>(response);
        }

        public SyncInvoker<ShowErrorLogResponse> ShowErrorLogInvoker(ShowErrorLogRequest showErrorLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showErrorLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/error-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showErrorLogRequest);
            return new SyncInvoker<ShowErrorLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowErrorLogResponse>);
        }
        
        /// <summary>
        /// 查询高危命令
        ///
        /// 查询Redis的高危命令
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHighRiskCommandsResponse ShowHighRiskCommands(ShowHighRiskCommandsRequest showHighRiskCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showHighRiskCommandsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/high-risk-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHighRiskCommandsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHighRiskCommandsResponse>(response);
        }

        public SyncInvoker<ShowHighRiskCommandsResponse> ShowHighRiskCommandsInvoker(ShowHighRiskCommandsRequest showHighRiskCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showHighRiskCommandsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/high-risk-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHighRiskCommandsRequest);
            return new SyncInvoker<ShowHighRiskCommandsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHighRiskCommandsResponse>);
        }
        
        /// <summary>
        /// 查询实例可搭建双活关系的Region
        ///
        /// 查询实例可搭建双活关系的Region。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceBiactiveRegionsResponse ShowInstanceBiactiveRegions(ShowInstanceBiactiveRegionsRequest showInstanceBiactiveRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceBiactiveRegionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceBiactiveRegionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceBiactiveRegionsResponse>(response);
        }

        public SyncInvoker<ShowInstanceBiactiveRegionsResponse> ShowInstanceBiactiveRegionsInvoker(ShowInstanceBiactiveRegionsRequest showInstanceBiactiveRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceBiactiveRegionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceBiactiveRegionsRequest);
            return new SyncInvoker<ShowInstanceBiactiveRegionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceBiactiveRegionsResponse>);
        }
        
        /// <summary>
        /// 获取指定实例的参数
        ///
        /// 获取指定实例的参数信息。
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
        /// 获取容灾实例主/备角色信息
        ///
        /// 该接口用于获取容灾实例主/备角色信息，以便后续容灾实例备升主和容灾实例主降备接口调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceRoleResponse ShowInstanceRole(ShowInstanceRoleRequest showInstanceRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceRoleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/instance-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRoleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceRoleResponse>(response);
        }

        public SyncInvoker<ShowInstanceRoleResponse> ShowInstanceRoleInvoker(ShowInstanceRoleRequest showInstanceRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceRoleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/instance-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRoleRequest);
            return new SyncInvoker<ShowInstanceRoleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceRoleResponse>);
        }
        
        /// <summary>
        /// 查询创建实例或扩容节点时需要的IP数量
        ///
        /// 查询创建实例或扩容节点时需要的IP数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowIpNumRequirementResponse ShowIpNumRequirement(ShowIpNumRequirementRequest showIpNumRequirementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/ip-num-requirement", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpNumRequirementRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowIpNumRequirementResponse>(response);
        }

        public SyncInvoker<ShowIpNumRequirementResponse> ShowIpNumRequirementInvoker(ShowIpNumRequirementRequest showIpNumRequirementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/ip-num-requirement", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpNumRequirementRequest);
            return new SyncInvoker<ShowIpNumRequirementResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIpNumRequirementResponse>);
        }
        
        /// <summary>
        /// 查询实例参数的修改历史
        ///
        /// 查询实例参数的修改历史
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowModifyHistoryResponse ShowModifyHistory(ShowModifyHistoryRequest showModifyHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showModifyHistoryRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configuration-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showModifyHistoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowModifyHistoryResponse>(response);
        }

        public SyncInvoker<ShowModifyHistoryResponse> ShowModifyHistoryInvoker(ShowModifyHistoryRequest showModifyHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showModifyHistoryRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configuration-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showModifyHistoryRequest);
            return new SyncInvoker<ShowModifyHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowModifyHistoryResponse>);
        }
        
        /// <summary>
        /// 获取GeminiDB Redis的免密配置
        ///
        /// 获取GeminiDB Redis的免密配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPasswordlessConfigResponse ShowPasswordlessConfig(ShowPasswordlessConfigRequest showPasswordlessConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPasswordlessConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/passwordless-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPasswordlessConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPasswordlessConfigResponse>(response);
        }

        public SyncInvoker<ShowPasswordlessConfigResponse> ShowPasswordlessConfigInvoker(ShowPasswordlessConfigRequest showPasswordlessConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPasswordlessConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/passwordless-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPasswordlessConfigRequest);
            return new SyncInvoker<ShowPasswordlessConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPasswordlessConfigResponse>);
        }
        
        /// <summary>
        /// 获取容灾实例数据同步状态
        ///
        /// 获取容灾实例数据同步状态，主备实例id，数据同步指标值，以及倒换和切换场景下的RPO，RTO指标值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPauseResumeStutusResponse ShowPauseResumeStutus(ShowPauseResumeStutusRequest showPauseResumeStutusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPauseResumeStutusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/data-synchronization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPauseResumeStutusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPauseResumeStutusResponse>(response);
        }

        public SyncInvoker<ShowPauseResumeStutusResponse> ShowPauseResumeStutusInvoker(ShowPauseResumeStutusRequest showPauseResumeStutusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPauseResumeStutusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/disaster-recovery/data-synchronization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPauseResumeStutusRequest);
            return new SyncInvoker<ShowPauseResumeStutusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPauseResumeStutusResponse>);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// 查询单租户在GeminiDB服务下的资源配额。
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
        /// 查询回收策略
        ///
        /// 查询回收策略。
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
        /// 查询Redis实例的大key
        ///
        /// 支持查询Redis实例的大key。value长度大于bigkeys-string-threshold参数的string类型的key或者元素数大于bigkeys-composite-threshold参数的hash/list/zset/set/stream类型key，会被判断为大key。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRedisBigKeysResponse ShowRedisBigKeys(ShowRedisBigKeysRequest showRedisBigKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRedisBigKeysRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/big-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRedisBigKeysRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowRedisBigKeysResponse>(response);
        }

        public SyncInvoker<ShowRedisBigKeysResponse> ShowRedisBigKeysInvoker(ShowRedisBigKeysRequest showRedisBigKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRedisBigKeysRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/big-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRedisBigKeysRequest);
            return new SyncInvoker<ShowRedisBigKeysResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowRedisBigKeysResponse>);
        }
        
        /// <summary>
        /// 查询可恢复的实例列表
        ///
        /// 查询用户可恢复的实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRestorableListResponse ShowRestorableList(ShowRestorableListRequest showRestorableListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", showRestorableListRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/restorable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRestorableListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRestorableListResponse>(response);
        }

        public SyncInvoker<ShowRestorableListResponse> ShowRestorableListInvoker(ShowRestorableListRequest showRestorableListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", showRestorableListRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/restorable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRestorableListRequest);
            return new SyncInvoker<ShowRestorableListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRestorableListResponse>);
        }
        
        /// <summary>
        /// 查询慢日志脱敏状态
        ///
        /// 查询慢日志脱敏状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSlowLogDesensitizationResponse ShowSlowLogDesensitization(ShowSlowLogDesensitizationRequest showSlowLogDesensitizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSlowLogDesensitizationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-desensitization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSlowLogDesensitizationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSlowLogDesensitizationResponse>(response);
        }

        public SyncInvoker<ShowSlowLogDesensitizationResponse> ShowSlowLogDesensitizationInvoker(ShowSlowLogDesensitizationRequest showSlowLogDesensitizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSlowLogDesensitizationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-desensitization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSlowLogDesensitizationRequest);
            return new SyncInvoker<ShowSlowLogDesensitizationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSlowLogDesensitizationResponse>);
        }
        
        /// <summary>
        /// 缩容指定集群实例的节点数量
        ///
        /// 缩容指定集群实例的节点数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShrinkInstanceNodeResponse ShrinkInstanceNode(ShrinkInstanceNodeRequest shrinkInstanceNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", shrinkInstanceNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/reduce-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", shrinkInstanceNodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShrinkInstanceNodeResponse>(response);
        }

        public SyncInvoker<ShrinkInstanceNodeResponse> ShrinkInstanceNodeInvoker(ShrinkInstanceNodeRequest shrinkInstanceNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", shrinkInstanceNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/reduce-node", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", shrinkInstanceNodeRequest);
            return new SyncInvoker<ShrinkInstanceNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<ShrinkInstanceNodeResponse>);
        }
        
        /// <summary>
        /// 设置实例负载均衡的IP访问黑白名单
        ///
        /// 设置实例负载均衡的IP访问黑白名单，黑名单、白名单只能选一种，每次调用此接口覆盖之前的设置。关闭后不限制连接的源IP地址。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchIpGroupResponse SwitchIpGroup(SwitchIpGroupRequest switchIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchIpGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/lb/access-control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchIpGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SwitchIpGroupResponse>(response);
        }

        public SyncInvoker<SwitchIpGroupResponse> SwitchIpGroupInvoker(SwitchIpGroupRequest switchIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchIpGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/lb/access-control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchIpGroupRequest);
            return new SyncInvoker<SwitchIpGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SwitchIpGroupResponse>);
        }
        
        /// <summary>
        /// 设置慢日志脱敏状态
        ///
        /// 设置慢日志脱敏状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchSlowlogDesensitizationResponse SwitchSlowlogDesensitization(SwitchSlowlogDesensitizationRequest switchSlowlogDesensitizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSlowlogDesensitizationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-desensitization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSlowlogDesensitizationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SwitchSlowlogDesensitizationResponse>(response);
        }

        public SyncInvoker<SwitchSlowlogDesensitizationResponse> SwitchSlowlogDesensitizationInvoker(SwitchSlowlogDesensitizationRequest switchSlowlogDesensitizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSlowlogDesensitizationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slowlog-desensitization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSlowlogDesensitizationRequest);
            return new SyncInvoker<SwitchSlowlogDesensitizationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SwitchSlowlogDesensitizationResponse>);
        }
        
        /// <summary>
        /// 切换实例SSL开关
        ///
        /// 切换实例SSL开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchSslResponse SwitchSsl(SwitchSslRequest switchSslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSslRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-option", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSslRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchSslResponse>(response);
        }

        public SyncInvoker<SwitchSslResponse> SwitchSslInvoker(SwitchSslRequest switchSslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSslRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-option", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchSslRequest);
            return new SyncInvoker<SwitchSslResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchSslResponse>);
        }
        
        /// <summary>
        /// 容灾实例备升主
        ///
        /// 该接口用于对已经搭建容灾关系的实例，将备实例升级为主实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchToMasterResponse SwitchToMaster(SwitchToMasterRequest switchToMasterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchToMasterRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switchover-master", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchToMasterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchToMasterResponse>(response);
        }

        public SyncInvoker<SwitchToMasterResponse> SwitchToMasterInvoker(SwitchToMasterRequest switchToMasterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchToMasterRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switchover-master", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchToMasterRequest);
            return new SyncInvoker<SwitchToMasterResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchToMasterResponse>);
        }
        
        /// <summary>
        /// 容灾实例主降备
        ///
        /// 该接口用于对已经搭建容灾关系的实例，将主实例降级为备实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchToSlaveResponse SwitchToSlave(SwitchToSlaveRequest switchToSlaveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchToSlaveRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switchover-slave", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchToSlaveRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchToSlaveResponse>(response);
        }

        public SyncInvoker<SwitchToSlaveResponse> SwitchToSlaveInvoker(SwitchToSlaveRequest switchToSlaveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchToSlaveRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switchover-slave", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchToSlaveRequest);
            return new SyncInvoker<SwitchToSlaveResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchToSlaveResponse>);
        }
        
        /// <summary>
        /// 修改副本集跨网段访问配置
        ///
        /// 修改副本集跨网段访问配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateClientNetworkResponse UpdateClientNetwork(UpdateClientNetworkRequest updateClientNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateClientNetworkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/client-network", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClientNetworkRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateClientNetworkResponse>(response);
        }

        public SyncInvoker<UpdateClientNetworkResponse> UpdateClientNetworkInvoker(UpdateClientNetworkRequest updateClientNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateClientNetworkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/client-network", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClientNetworkRequest);
            return new SyncInvoker<UpdateClientNetworkResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateClientNetworkResponse>);
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
            return JsonUtils.DeSerializeNull<UpdateConfigurationResponse>(response);
        }

        public SyncInvoker<UpdateConfigurationResponse> UpdateConfigurationInvoker(UpdateConfigurationRequest updateConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", updateConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigurationRequest);
            return new SyncInvoker<UpdateConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateConfigurationResponse>);
        }
        
        /// <summary>
        /// 操作GeminDB实例数据库
        ///
        /// 操作GeminDB实例数据库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDatabasesResponse UpdateDatabases(UpdateDatabasesRequest updateDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDatabasesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDatabasesResponse>(response);
        }

        public SyncInvoker<UpdateDatabasesResponse> UpdateDatabasesInvoker(UpdateDatabasesRequest updateDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDatabasesRequest);
            return new SyncInvoker<UpdateDatabasesResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDatabasesResponse>);
        }
        
        /// <summary>
        /// 修改高危命令
        ///
        /// 批量修改高危命令
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateHighRiskCommandsResponse UpdateHighRiskCommands(UpdateHighRiskCommandsRequest updateHighRiskCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateHighRiskCommandsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/high-risk-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHighRiskCommandsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateHighRiskCommandsResponse>(response);
        }

        public SyncInvoker<UpdateHighRiskCommandsResponse> UpdateHighRiskCommandsInvoker(UpdateHighRiskCommandsRequest updateHighRiskCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateHighRiskCommandsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/high-risk-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHighRiskCommandsRequest);
            return new SyncInvoker<UpdateHighRiskCommandsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateHighRiskCommandsResponse>);
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
        /// 修改实例名称
        ///
        /// 修改实例名称
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
        /// 支持修改GeminiDB Redis的免密配置
        ///
        /// 支持修改GeminiDB Redis的免密配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePasswordlessConfigResponse UpdatePasswordlessConfig(UpdatePasswordlessConfigRequest updatePasswordlessConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePasswordlessConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/passwordless-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePasswordlessConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePasswordlessConfigResponse>(response);
        }

        public SyncInvoker<UpdatePasswordlessConfigResponse> UpdatePasswordlessConfigInvoker(UpdatePasswordlessConfigRequest updatePasswordlessConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePasswordlessConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/passwordless-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePasswordlessConfigRequest);
            return new SyncInvoker<UpdatePasswordlessConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePasswordlessConfigResponse>);
        }
        
        /// <summary>
        /// 变更实例安全组
        ///
        /// 变更实例关联的安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSecurityGroupResponse UpdateSecurityGroup(UpdateSecurityGroupRequest updateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateSecurityGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecurityGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSecurityGroupResponse>(response);
        }

        public SyncInvoker<UpdateSecurityGroupResponse> UpdateSecurityGroupInvoker(UpdateSecurityGroupRequest updateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateSecurityGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecurityGroupRequest);
            return new SyncInvoker<UpdateSecurityGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 数据库补丁升级
        ///
        /// 升级数据库补丁版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeDbVersionResponse UpgradeDbVersion(UpgradeDbVersionRequest upgradeDbVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeDbVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbVersionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpgradeDbVersionResponse>(response);
        }

        public SyncInvoker<UpgradeDbVersionResponse> UpgradeDbVersionInvoker(UpgradeDbVersionRequest upgradeDbVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeDbVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeDbVersionRequest);
            return new SyncInvoker<UpgradeDbVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeDbVersionResponse>);
        }
        
        /// <summary>
        /// 查询当前支持的API版本信息列表
        ///
        /// 查询当前支持的API版本信息列表。
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
        /// 查询指定API版本信息
        ///
        /// 查询指定API版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowApiVersionResponse ShowApiVersion(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", showApiVersionRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }

        public SyncInvoker<ShowApiVersionResponse> ShowApiVersionInvoker(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", showApiVersionRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            return new SyncInvoker<ShowApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApiVersionResponse>);
        }
        
    }
}