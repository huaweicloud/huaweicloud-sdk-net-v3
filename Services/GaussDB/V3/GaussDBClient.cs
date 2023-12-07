using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.GaussDB.V3.Model;

namespace HuaweiCloud.SDK.GaussDB.V3
{
    public partial class GaussDBClient : Client
    {
        public static ClientBuilder<GaussDBClient> NewBuilder()
        {
            return new ClientBuilder<GaussDBClient>();
        }

        
        /// <summary>
        /// 授予数据库用户数据库权限
        ///
        /// 授予云数据库 GaussDB(for MySQL)实例数据库用户数据库权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddDatabasePermissionResponse AddDatabasePermission(AddDatabasePermissionRequest addDatabasePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addDatabasePermissionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addDatabasePermissionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddDatabasePermissionResponse>(response);
        }

        public SyncInvoker<AddDatabasePermissionResponse> AddDatabasePermissionInvoker(AddDatabasePermissionRequest addDatabasePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addDatabasePermissionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addDatabasePermissionRequest);
            return new SyncInvoker<AddDatabasePermissionResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDatabasePermissionResponse>);
        }
        
        /// <summary>
        /// 批量添加或删除标签
        ///
        /// 批量添加或删除指定实例的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchTagActionResponse BatchTagAction(BatchTagActionRequest batchTagActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchTagActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchTagActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchTagActionResponse>(response);
        }

        public SyncInvoker<BatchTagActionResponse> BatchTagActionInvoker(BatchTagActionRequest batchTagActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchTagActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchTagActionRequest);
            return new SyncInvoker<BatchTagActionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchTagActionResponse>);
        }
        
        /// <summary>
        /// 解绑弹性公网IP
        ///
        /// 实例解绑弹性公网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelGaussMySqlInstanceEipResponse CancelGaussMySqlInstanceEip(CancelGaussMySqlInstanceEipRequest cancelGaussMySqlInstanceEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", cancelGaussMySqlInstanceEipRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ips/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelGaussMySqlInstanceEipRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<CancelGaussMySqlInstanceEipResponse>(response);
        }

        public SyncInvoker<CancelGaussMySqlInstanceEipResponse> CancelGaussMySqlInstanceEipInvoker(CancelGaussMySqlInstanceEipRequest cancelGaussMySqlInstanceEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", cancelGaussMySqlInstanceEipRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ips/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelGaussMySqlInstanceEipRequest);
            return new SyncInvoker<CancelGaussMySqlInstanceEipResponse>(this, "PUT", request, JsonUtils.DeSerialize<CancelGaussMySqlInstanceEipResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/scheduled-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelScheduleTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<CancelScheduleTaskResponse>(response);
        }

        public SyncInvoker<CancelScheduleTaskResponse> CancelScheduleTaskInvoker(CancelScheduleTaskRequest cancelScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/scheduled-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelScheduleTaskRequest);
            return new SyncInvoker<CancelScheduleTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<CancelScheduleTaskResponse>);
        }
        
        /// <summary>
        /// 变更实例规格
        ///
        /// 变更数据库实例的规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeGaussMySqlInstanceSpecificationResponse ChangeGaussMySqlInstanceSpecification(ChangeGaussMySqlInstanceSpecificationRequest changeGaussMySqlInstanceSpecificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeGaussMySqlInstanceSpecificationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeGaussMySqlInstanceSpecificationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeGaussMySqlInstanceSpecificationResponse>(response);
        }

        public SyncInvoker<ChangeGaussMySqlInstanceSpecificationResponse> ChangeGaussMySqlInstanceSpecificationInvoker(ChangeGaussMySqlInstanceSpecificationRequest changeGaussMySqlInstanceSpecificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeGaussMySqlInstanceSpecificationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeGaussMySqlInstanceSpecificationRequest);
            return new SyncInvoker<ChangeGaussMySqlInstanceSpecificationResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeGaussMySqlInstanceSpecificationResponse>);
        }
        
        /// <summary>
        /// 数据库代理规格变更
        ///
        /// 数据库代理规格变更。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeGaussMySqlProxySpecificationResponse ChangeGaussMySqlProxySpecification(ChangeGaussMySqlProxySpecificationRequest changeGaussMySqlProxySpecificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeGaussMySqlProxySpecificationRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", changeGaussMySqlProxySpecificationRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/flavor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeGaussMySqlProxySpecificationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ChangeGaussMySqlProxySpecificationResponse>(response);
        }

        public SyncInvoker<ChangeGaussMySqlProxySpecificationResponse> ChangeGaussMySqlProxySpecificationInvoker(ChangeGaussMySqlProxySpecificationRequest changeGaussMySqlProxySpecificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeGaussMySqlProxySpecificationRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", changeGaussMySqlProxySpecificationRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/flavor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeGaussMySqlProxySpecificationRequest);
            return new SyncInvoker<ChangeGaussMySqlProxySpecificationResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeGaussMySqlProxySpecificationResponse>);
        }
        
        /// <summary>
        /// 资源预校验
        ///
        /// 资源预校验。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckResourceResponse CheckResource(CheckResourceRequest checkResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/resource-check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkResourceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CheckResourceResponse>(response);
        }

        public SyncInvoker<CheckResourceResponse> CheckResourceInvoker(CheckResourceRequest checkResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/resource-check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkResourceRequest);
            return new SyncInvoker<CheckResourceResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckResourceResponse>);
        }
        
        /// <summary>
        /// 复制参数组
        ///
        /// 复制参数组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CopyConfigurationsResponse CopyConfigurations(CopyConfigurationsRequest copyConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", copyConfigurationsRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyConfigurationsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CopyConfigurationsResponse>(response);
        }

        public SyncInvoker<CopyConfigurationsResponse> CopyConfigurationsInvoker(CopyConfigurationsRequest copyConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", copyConfigurationsRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyConfigurationsRequest);
            return new SyncInvoker<CopyConfigurationsResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyConfigurationsResponse>);
        }
        
        /// <summary>
        /// 复制实例参数组
        ///
        /// 复制实例参数组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CopyInstanceConfigurationsResponse CopyInstanceConfigurations(CopyInstanceConfigurationsRequest copyInstanceConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", copyInstanceConfigurationsRequest.InstanceId.ToString());
            urlParam.Add("configuration_id", copyInstanceConfigurationsRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations/{configuration_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyInstanceConfigurationsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CopyInstanceConfigurationsResponse>(response);
        }

        public SyncInvoker<CopyInstanceConfigurationsResponse> CopyInstanceConfigurationsInvoker(CopyInstanceConfigurationsRequest copyInstanceConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", copyInstanceConfigurationsRequest.InstanceId.ToString());
            urlParam.Add("configuration_id", copyInstanceConfigurationsRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations/{configuration_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyInstanceConfigurationsRequest);
            return new SyncInvoker<CopyInstanceConfigurationsResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyInstanceConfigurationsResponse>);
        }
        
        /// <summary>
        /// 设置访问控制规则
        ///
        /// 设置访问控制规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAccessControlResponse CreateAccessControl(CreateAccessControlRequest createAccessControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createAccessControlRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", createAccessControlRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/access-control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAccessControlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAccessControlResponse>(response);
        }

        public SyncInvoker<CreateAccessControlResponse> CreateAccessControlInvoker(CreateAccessControlRequest createAccessControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createAccessControlRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", createAccessControlRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/access-control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAccessControlRequest);
            return new SyncInvoker<CreateAccessControlResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAccessControlResponse>);
        }
        
        /// <summary>
        /// 创建手动备份
        ///
        /// 创建手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGaussMySqlBackupResponse CreateGaussMySqlBackup(CreateGaussMySqlBackupRequest createGaussMySqlBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlBackupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGaussMySqlBackupResponse>(response);
        }

        public SyncInvoker<CreateGaussMySqlBackupResponse> CreateGaussMySqlBackupInvoker(CreateGaussMySqlBackupRequest createGaussMySqlBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlBackupRequest);
            return new SyncInvoker<CreateGaussMySqlBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGaussMySqlBackupResponse>);
        }
        
        /// <summary>
        /// 创建参数模板
        ///
        /// 创建参数模板信息，包含参数模板名称、描述、数据库版本信息、参数值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGaussMySqlConfigurationResponse CreateGaussMySqlConfiguration(CreateGaussMySqlConfigurationRequest createGaussMySqlConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlConfigurationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGaussMySqlConfigurationResponse>(response);
        }

        public SyncInvoker<CreateGaussMySqlConfigurationResponse> CreateGaussMySqlConfigurationInvoker(CreateGaussMySqlConfigurationRequest createGaussMySqlConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlConfigurationRequest);
            return new SyncInvoker<CreateGaussMySqlConfigurationResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGaussMySqlConfigurationResponse>);
        }
        
        /// <summary>
        /// 创建数据库
        ///
        /// 创建云数据库 GaussDB(for MySQL)实例数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGaussMySqlDatabaseResponse CreateGaussMySqlDatabase(CreateGaussMySqlDatabaseRequest createGaussMySqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGaussMySqlDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGaussMySqlDatabaseResponse>(response);
        }

        public SyncInvoker<CreateGaussMySqlDatabaseResponse> CreateGaussMySqlDatabaseInvoker(CreateGaussMySqlDatabaseRequest createGaussMySqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGaussMySqlDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlDatabaseRequest);
            return new SyncInvoker<CreateGaussMySqlDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGaussMySqlDatabaseResponse>);
        }
        
        /// <summary>
        /// 创建数据库用户
        ///
        /// 创建云数据库GaussDB(for MySQL)实例数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGaussMySqlDatabaseUserResponse CreateGaussMySqlDatabaseUser(CreateGaussMySqlDatabaseUserRequest createGaussMySqlDatabaseUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGaussMySqlDatabaseUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlDatabaseUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGaussMySqlDatabaseUserResponse>(response);
        }

        public SyncInvoker<CreateGaussMySqlDatabaseUserResponse> CreateGaussMySqlDatabaseUserInvoker(CreateGaussMySqlDatabaseUserRequest createGaussMySqlDatabaseUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGaussMySqlDatabaseUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlDatabaseUserRequest);
            return new SyncInvoker<CreateGaussMySqlDatabaseUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGaussMySqlDatabaseUserResponse>);
        }
        
        /// <summary>
        /// 创建数据库实例
        ///
        /// 创建云数据库GaussDB(for MySQL)实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGaussMySqlInstanceResponse CreateGaussMySqlInstance(CreateGaussMySqlInstanceRequest createGaussMySqlInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGaussMySqlInstanceResponse>(response);
        }

        public SyncInvoker<CreateGaussMySqlInstanceResponse> CreateGaussMySqlInstanceInvoker(CreateGaussMySqlInstanceRequest createGaussMySqlInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlInstanceRequest);
            return new SyncInvoker<CreateGaussMySqlInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGaussMySqlInstanceResponse>);
        }
        
        /// <summary>
        /// 开启数据库代理
        ///
        /// 开启数据库代理，只支持ELB模式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGaussMySqlProxyResponse CreateGaussMySqlProxy(CreateGaussMySqlProxyRequest createGaussMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGaussMySqlProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlProxyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGaussMySqlProxyResponse>(response);
        }

        public SyncInvoker<CreateGaussMySqlProxyResponse> CreateGaussMySqlProxyInvoker(CreateGaussMySqlProxyRequest createGaussMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGaussMySqlProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlProxyRequest);
            return new SyncInvoker<CreateGaussMySqlProxyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGaussMySqlProxyResponse>);
        }
        
        /// <summary>
        /// 创建只读节点
        ///
        /// 创建只读节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGaussMySqlReadonlyNodeResponse CreateGaussMySqlReadonlyNode(CreateGaussMySqlReadonlyNodeRequest createGaussMySqlReadonlyNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGaussMySqlReadonlyNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/enlarge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlReadonlyNodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGaussMySqlReadonlyNodeResponse>(response);
        }

        public SyncInvoker<CreateGaussMySqlReadonlyNodeResponse> CreateGaussMySqlReadonlyNodeInvoker(CreateGaussMySqlReadonlyNodeRequest createGaussMySqlReadonlyNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGaussMySqlReadonlyNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/enlarge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlReadonlyNodeRequest);
            return new SyncInvoker<CreateGaussMySqlReadonlyNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGaussMySqlReadonlyNodeResponse>);
        }
        
        /// <summary>
        /// 申请内网域名
        ///
        /// 申请内网域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGaussMysqlDnsResponse CreateGaussMysqlDns(CreateGaussMysqlDnsRequest createGaussMysqlDnsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGaussMysqlDnsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMysqlDnsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGaussMysqlDnsResponse>(response);
        }

        public SyncInvoker<CreateGaussMysqlDnsResponse> CreateGaussMysqlDnsInvoker(CreateGaussMysqlDnsRequest createGaussMysqlDnsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGaussMysqlDnsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMysqlDnsRequest);
            return new SyncInvoker<CreateGaussMysqlDnsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGaussMysqlDnsResponse>);
        }
        
        /// <summary>
        /// 表级时间点恢复
        ///
        /// 表级时间点恢复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRestoreTablesResponse CreateRestoreTables(CreateRestoreTablesRequest createRestoreTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createRestoreTablesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/restore/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRestoreTablesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRestoreTablesResponse>(response);
        }

        public SyncInvoker<CreateRestoreTablesResponse> CreateRestoreTablesInvoker(CreateRestoreTablesRequest createRestoreTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createRestoreTablesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/restore/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRestoreTablesRequest);
            return new SyncInvoker<CreateRestoreTablesResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRestoreTablesResponse>);
        }
        
        /// <summary>
        /// 删除数据库用户的数据库权限
        ///
        /// 删除云数据库 GaussDB(for MySQL)实例数据库用户的数据库权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDatabasePermissionResponse DeleteDatabasePermission(DeleteDatabasePermissionRequest deleteDatabasePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabasePermissionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteDatabasePermissionRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDatabasePermissionResponse>(response);
        }

        public SyncInvoker<DeleteDatabasePermissionResponse> DeleteDatabasePermissionInvoker(DeleteDatabasePermissionRequest deleteDatabasePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabasePermissionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteDatabasePermissionRequest);
            return new SyncInvoker<DeleteDatabasePermissionResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDatabasePermissionResponse>);
        }
        
        /// <summary>
        /// 删除手动备份
        ///
        /// 删除手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGaussMySqlBackupResponse DeleteGaussMySqlBackup(DeleteGaussMySqlBackupRequest deleteGaussMySqlBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteGaussMySqlBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGaussMySqlBackupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlBackupResponse>(response);
        }

        public SyncInvoker<DeleteGaussMySqlBackupResponse> DeleteGaussMySqlBackupInvoker(DeleteGaussMySqlBackupRequest deleteGaussMySqlBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteGaussMySqlBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGaussMySqlBackupRequest);
            return new SyncInvoker<DeleteGaussMySqlBackupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteGaussMySqlBackupResponse>);
        }
        
        /// <summary>
        /// 删除参数模板
        ///
        /// 删除指定参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGaussMySqlConfigurationResponse DeleteGaussMySqlConfiguration(DeleteGaussMySqlConfigurationRequest deleteGaussMySqlConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", deleteGaussMySqlConfigurationRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGaussMySqlConfigurationRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlConfigurationResponse>(response);
        }

        public SyncInvoker<DeleteGaussMySqlConfigurationResponse> DeleteGaussMySqlConfigurationInvoker(DeleteGaussMySqlConfigurationRequest deleteGaussMySqlConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", deleteGaussMySqlConfigurationRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGaussMySqlConfigurationRequest);
            return new SyncInvoker<DeleteGaussMySqlConfigurationResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteGaussMySqlConfigurationResponse>);
        }
        
        /// <summary>
        /// 删除数据库
        ///
        /// 删除云数据库 GaussDB(for MySQL)实例数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGaussMySqlDatabaseResponse DeleteGaussMySqlDatabase(DeleteGaussMySqlDatabaseRequest deleteGaussMySqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGaussMySqlDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteGaussMySqlDatabaseRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlDatabaseResponse>(response);
        }

        public SyncInvoker<DeleteGaussMySqlDatabaseResponse> DeleteGaussMySqlDatabaseInvoker(DeleteGaussMySqlDatabaseRequest deleteGaussMySqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGaussMySqlDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteGaussMySqlDatabaseRequest);
            return new SyncInvoker<DeleteGaussMySqlDatabaseResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteGaussMySqlDatabaseResponse>);
        }
        
        /// <summary>
        /// 删除数据库用户
        ///
        /// 删除云数据库 GaussDB(for MySQL)实例数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGaussMySqlDatabaseUserResponse DeleteGaussMySqlDatabaseUser(DeleteGaussMySqlDatabaseUserRequest deleteGaussMySqlDatabaseUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGaussMySqlDatabaseUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteGaussMySqlDatabaseUserRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlDatabaseUserResponse>(response);
        }

        public SyncInvoker<DeleteGaussMySqlDatabaseUserResponse> DeleteGaussMySqlDatabaseUserInvoker(DeleteGaussMySqlDatabaseUserRequest deleteGaussMySqlDatabaseUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGaussMySqlDatabaseUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteGaussMySqlDatabaseUserRequest);
            return new SyncInvoker<DeleteGaussMySqlDatabaseUserResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteGaussMySqlDatabaseUserResponse>);
        }
        
        /// <summary>
        /// 删除/退订数据库实例
        ///
        /// 删除/退订数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGaussMySqlInstanceResponse DeleteGaussMySqlInstance(DeleteGaussMySqlInstanceRequest deleteGaussMySqlInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGaussMySqlInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGaussMySqlInstanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlInstanceResponse>(response);
        }

        public SyncInvoker<DeleteGaussMySqlInstanceResponse> DeleteGaussMySqlInstanceInvoker(DeleteGaussMySqlInstanceRequest deleteGaussMySqlInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGaussMySqlInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGaussMySqlInstanceRequest);
            return new SyncInvoker<DeleteGaussMySqlInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteGaussMySqlInstanceResponse>);
        }
        
        /// <summary>
        /// 关闭数据库代理
        ///
        /// 关闭数据库代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGaussMySqlProxyResponse DeleteGaussMySqlProxy(DeleteGaussMySqlProxyRequest deleteGaussMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGaussMySqlProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteGaussMySqlProxyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlProxyResponse>(response);
        }

        public SyncInvoker<DeleteGaussMySqlProxyResponse> DeleteGaussMySqlProxyInvoker(DeleteGaussMySqlProxyRequest deleteGaussMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGaussMySqlProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteGaussMySqlProxyRequest);
            return new SyncInvoker<DeleteGaussMySqlProxyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteGaussMySqlProxyResponse>);
        }
        
        /// <summary>
        /// 删除/退订只读节点
        ///
        /// 删除/退订实例的只读节点。多可用区模式删除/退订只读节点时，要保证删除/退订后，剩余的只读节点和主节点在不同的可用区中，否则无法删除/退订该只读节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGaussMySqlReadonlyNodeResponse DeleteGaussMySqlReadonlyNode(DeleteGaussMySqlReadonlyNodeRequest deleteGaussMySqlReadonlyNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGaussMySqlReadonlyNodeRequest.InstanceId.ToString());
            urlParam.Add("node_id", deleteGaussMySqlReadonlyNodeRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGaussMySqlReadonlyNodeRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlReadonlyNodeResponse>(response);
        }

        public SyncInvoker<DeleteGaussMySqlReadonlyNodeResponse> DeleteGaussMySqlReadonlyNodeInvoker(DeleteGaussMySqlReadonlyNodeRequest deleteGaussMySqlReadonlyNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGaussMySqlReadonlyNodeRequest.InstanceId.ToString());
            urlParam.Add("node_id", deleteGaussMySqlReadonlyNodeRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGaussMySqlReadonlyNodeRequest);
            return new SyncInvoker<DeleteGaussMySqlReadonlyNodeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteGaussMySqlReadonlyNodeResponse>);
        }
        
        /// <summary>
        /// 删除定时任务
        ///
        /// 删除定时任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteScheduleTasKResponse DeleteScheduleTasK(DeleteScheduleTasKRequest deleteScheduleTasKRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteScheduleTasKRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/scheduled-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteScheduleTasKRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteScheduleTasKResponse>(response);
        }

        public SyncInvoker<DeleteScheduleTasKResponse> DeleteScheduleTasKInvoker(DeleteScheduleTasKRequest deleteScheduleTasKRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteScheduleTasKRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/scheduled-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteScheduleTasKRequest);
            return new SyncInvoker<DeleteScheduleTasKResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteScheduleTasKResponse>);
        }
        
        /// <summary>
        /// 删除指定任务记录
        ///
        /// 删除指定任务记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTaskRecordResponse DeleteTaskRecord(DeleteTaskRecordRequest deleteTaskRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteTaskRecordRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTaskRecordRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTaskRecordResponse>(response);
        }

        public SyncInvoker<DeleteTaskRecordResponse> DeleteTaskRecordInvoker(DeleteTaskRecordRequest deleteTaskRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteTaskRecordRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTaskRecordRequest);
            return new SyncInvoker<DeleteTaskRecordResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTaskRecordResponse>);
        }
        
        /// <summary>
        /// 查询实例是否开启备份加密功能
        ///
        /// 查询实例是否开启备份加密功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribeBackupEncryptStatusResponse DescribeBackupEncryptStatus(DescribeBackupEncryptStatusRequest describeBackupEncryptStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describeBackupEncryptStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/encryption", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeBackupEncryptStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DescribeBackupEncryptStatusResponse>(response);
        }

        public SyncInvoker<DescribeBackupEncryptStatusResponse> DescribeBackupEncryptStatusInvoker(DescribeBackupEncryptStatusRequest describeBackupEncryptStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describeBackupEncryptStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/encryption", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeBackupEncryptStatusRequest);
            return new SyncInvoker<DescribeBackupEncryptStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeBackupEncryptStatusResponse>);
        }
        
        /// <summary>
        /// 包周期存储扩容
        ///
        /// 包周期存储扩容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExpandGaussMySqlInstanceVolumeResponse ExpandGaussMySqlInstanceVolume(ExpandGaussMySqlInstanceVolumeRequest expandGaussMySqlInstanceVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", expandGaussMySqlInstanceVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/volume/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", expandGaussMySqlInstanceVolumeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExpandGaussMySqlInstanceVolumeResponse>(response);
        }

        public SyncInvoker<ExpandGaussMySqlInstanceVolumeResponse> ExpandGaussMySqlInstanceVolumeInvoker(ExpandGaussMySqlInstanceVolumeRequest expandGaussMySqlInstanceVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", expandGaussMySqlInstanceVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/volume/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", expandGaussMySqlInstanceVolumeRequest);
            return new SyncInvoker<ExpandGaussMySqlInstanceVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<ExpandGaussMySqlInstanceVolumeResponse>);
        }
        
        /// <summary>
        /// 扩容数据库代理节点的数量
        ///
        /// 扩容数据库代理节点的数量。
        /// DeC专属云账号暂不支持数据库代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExpandGaussMySqlProxyResponse ExpandGaussMySqlProxy(ExpandGaussMySqlProxyRequest expandGaussMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", expandGaussMySqlProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/enlarge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", expandGaussMySqlProxyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExpandGaussMySqlProxyResponse>(response);
        }

        public SyncInvoker<ExpandGaussMySqlProxyResponse> ExpandGaussMySqlProxyInvoker(ExpandGaussMySqlProxyRequest expandGaussMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", expandGaussMySqlProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/enlarge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", expandGaussMySqlProxyRequest);
            return new SyncInvoker<ExpandGaussMySqlProxyResponse>(this, "POST", request, JsonUtils.DeSerialize<ExpandGaussMySqlProxyResponse>);
        }
        
        /// <summary>
        /// 手动主备倒换
        ///
        /// 用户手动进行主备倒换。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public InvokeGaussMySqlInstanceSwitchOverResponse InvokeGaussMySqlInstanceSwitchOver(InvokeGaussMySqlInstanceSwitchOverRequest invokeGaussMySqlInstanceSwitchOverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", invokeGaussMySqlInstanceSwitchOverRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", invokeGaussMySqlInstanceSwitchOverRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<InvokeGaussMySqlInstanceSwitchOverResponse>(response);
        }

        public SyncInvoker<InvokeGaussMySqlInstanceSwitchOverResponse> InvokeGaussMySqlInstanceSwitchOverInvoker(InvokeGaussMySqlInstanceSwitchOverRequest invokeGaussMySqlInstanceSwitchOverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", invokeGaussMySqlInstanceSwitchOverRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", invokeGaussMySqlInstanceSwitchOverRequest);
            return new SyncInvoker<InvokeGaussMySqlInstanceSwitchOverResponse>(this, "PUT", request, JsonUtils.DeSerialize<InvokeGaussMySqlInstanceSwitchOverResponse>);
        }
        
        /// <summary>
        /// 获取全量SQL的临时下载链接
        ///
        /// 获取全量SQL的临时下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditLogDownloadLinkResponse ListAuditLogDownloadLink(ListAuditLogDownloadLinkRequest listAuditLogDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditLogDownloadLinkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/auditlog/download-link", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditLogDownloadLinkRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditLogDownloadLinkResponse>(response);
        }

        public SyncInvoker<ListAuditLogDownloadLinkResponse> ListAuditLogDownloadLinkInvoker(ListAuditLogDownloadLinkRequest listAuditLogDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditLogDownloadLinkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/auditlog/download-link", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditLogDownloadLinkRequest);
            return new SyncInvoker<ListAuditLogDownloadLinkResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditLogDownloadLinkResponse>);
        }
        
        /// <summary>
        /// 对比参数模板
        ///
        /// 比较两个参数模板之间的差异。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConfigurationsDifferencesResponse ListConfigurationsDifferences(ListConfigurationsDifferencesRequest listConfigurationsDifferencesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/comparison", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listConfigurationsDifferencesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListConfigurationsDifferencesResponse>(response);
        }

        public SyncInvoker<ListConfigurationsDifferencesResponse> ListConfigurationsDifferencesInvoker(ListConfigurationsDifferencesRequest listConfigurationsDifferencesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/comparison", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listConfigurationsDifferencesRequest);
            return new SyncInvoker<ListConfigurationsDifferencesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListConfigurationsDifferencesResponse>);
        }
        
        /// <summary>
        /// 查询可应用的实例列表
        ///
        /// 查询指定参数模板可被应用的实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConfigurationsInstancesResponse ListConfigurationsInstances(ListConfigurationsInstancesRequest listConfigurationsInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", listConfigurationsInstancesRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}/applicable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationsInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListConfigurationsInstancesResponse>(response);
        }

        public SyncInvoker<ListConfigurationsInstancesResponse> ListConfigurationsInstancesInvoker(ListConfigurationsInstancesRequest listConfigurationsInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", listConfigurationsInstancesRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}/applicable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationsInstancesRequest);
            return new SyncInvoker<ListConfigurationsInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigurationsInstancesResponse>);
        }
        
        /// <summary>
        /// 查询企业项目
        ///
        /// 查询企业项目。
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
        /// 查询参数模板
        ///
        /// 获取参数模板列表，包括所有数据库的默认参数模板和用户创建的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGaussMySqlConfigurationsResponse ListGaussMySqlConfigurations(ListGaussMySqlConfigurationsRequest listGaussMySqlConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlConfigurationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGaussMySqlConfigurationsResponse>(response);
        }

        public SyncInvoker<ListGaussMySqlConfigurationsResponse> ListGaussMySqlConfigurationsInvoker(ListGaussMySqlConfigurationsRequest listGaussMySqlConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlConfigurationsRequest);
            return new SyncInvoker<ListGaussMySqlConfigurationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGaussMySqlConfigurationsResponse>);
        }
        
        /// <summary>
        /// 查询数据库列表
        ///
        /// 查询 GaussDB(for MySQL)实例数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGaussMySqlDatabaseResponse ListGaussMySqlDatabase(ListGaussMySqlDatabaseRequest listGaussMySqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listGaussMySqlDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlDatabaseRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGaussMySqlDatabaseResponse>(response);
        }

        public SyncInvoker<ListGaussMySqlDatabaseResponse> ListGaussMySqlDatabaseInvoker(ListGaussMySqlDatabaseRequest listGaussMySqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listGaussMySqlDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlDatabaseRequest);
            return new SyncInvoker<ListGaussMySqlDatabaseResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGaussMySqlDatabaseResponse>);
        }
        
        /// <summary>
        /// 查询数据库可用字符集
        ///
        /// 查询云数据库 GaussDB(for MySQL)实例数据库可用字符集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGaussMySqlDatabaseCharsetsResponse ListGaussMySqlDatabaseCharsets(ListGaussMySqlDatabaseCharsetsRequest listGaussMySqlDatabaseCharsetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listGaussMySqlDatabaseCharsetsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/charsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlDatabaseCharsetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGaussMySqlDatabaseCharsetsResponse>(response);
        }

        public SyncInvoker<ListGaussMySqlDatabaseCharsetsResponse> ListGaussMySqlDatabaseCharsetsInvoker(ListGaussMySqlDatabaseCharsetsRequest listGaussMySqlDatabaseCharsetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listGaussMySqlDatabaseCharsetsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/charsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlDatabaseCharsetsRequest);
            return new SyncInvoker<ListGaussMySqlDatabaseCharsetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGaussMySqlDatabaseCharsetsResponse>);
        }
        
        /// <summary>
        /// 查询数据库用户
        ///
        /// 查询云数据库 GaussDB(for MySQL)实例数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGaussMySqlDatabaseUserResponse ListGaussMySqlDatabaseUser(ListGaussMySqlDatabaseUserRequest listGaussMySqlDatabaseUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listGaussMySqlDatabaseUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlDatabaseUserRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGaussMySqlDatabaseUserResponse>(response);
        }

        public SyncInvoker<ListGaussMySqlDatabaseUserResponse> ListGaussMySqlDatabaseUserInvoker(ListGaussMySqlDatabaseUserRequest listGaussMySqlDatabaseUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listGaussMySqlDatabaseUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlDatabaseUserRequest);
            return new SyncInvoker<ListGaussMySqlDatabaseUserResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGaussMySqlDatabaseUserResponse>);
        }
        
        /// <summary>
        /// 查询专属资源池列表
        ///
        /// 获取专属资源池列表，包括用户开通的所有专属资源池信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGaussMySqlDedicatedResourcesResponse ListGaussMySqlDedicatedResources(ListGaussMySqlDedicatedResourcesRequest listGaussMySqlDedicatedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dedicated-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlDedicatedResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGaussMySqlDedicatedResourcesResponse>(response);
        }

        public SyncInvoker<ListGaussMySqlDedicatedResourcesResponse> ListGaussMySqlDedicatedResourcesInvoker(ListGaussMySqlDedicatedResourcesRequest listGaussMySqlDedicatedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dedicated-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlDedicatedResourcesRequest);
            return new SyncInvoker<ListGaussMySqlDedicatedResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGaussMySqlDedicatedResourcesResponse>);
        }
        
        /// <summary>
        /// 批量查询实例详情
        ///
        /// 批量查询实例详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGaussMySqlInstanceDetailInfoResponse ListGaussMySqlInstanceDetailInfo(ListGaussMySqlInstanceDetailInfoRequest listGaussMySqlInstanceDetailInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlInstanceDetailInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGaussMySqlInstanceDetailInfoResponse>(response);
        }

        public SyncInvoker<ListGaussMySqlInstanceDetailInfoResponse> ListGaussMySqlInstanceDetailInfoInvoker(ListGaussMySqlInstanceDetailInfoRequest listGaussMySqlInstanceDetailInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlInstanceDetailInfoRequest);
            return new SyncInvoker<ListGaussMySqlInstanceDetailInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGaussMySqlInstanceDetailInfoResponse>);
        }
        
        /// <summary>
        /// 批量查询实例详情
        ///
        /// 批量查询实例详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGaussMySqlInstanceDetailInfoUnifyStatusResponse ListGaussMySqlInstanceDetailInfoUnifyStatus(ListGaussMySqlInstanceDetailInfoUnifyStatusRequest listGaussMySqlInstanceDetailInfoUnifyStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlInstanceDetailInfoUnifyStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGaussMySqlInstanceDetailInfoUnifyStatusResponse>(response);
        }

        public SyncInvoker<ListGaussMySqlInstanceDetailInfoUnifyStatusResponse> ListGaussMySqlInstanceDetailInfoUnifyStatusInvoker(ListGaussMySqlInstanceDetailInfoUnifyStatusRequest listGaussMySqlInstanceDetailInfoUnifyStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlInstanceDetailInfoUnifyStatusRequest);
            return new SyncInvoker<ListGaussMySqlInstanceDetailInfoUnifyStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGaussMySqlInstanceDetailInfoUnifyStatusResponse>);
        }
        
        /// <summary>
        /// 查询实例列表
        ///
        /// 根据指定条件查询实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGaussMySqlInstancesResponse ListGaussMySqlInstances(ListGaussMySqlInstancesRequest listGaussMySqlInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGaussMySqlInstancesResponse>(response);
        }

        public SyncInvoker<ListGaussMySqlInstancesResponse> ListGaussMySqlInstancesInvoker(ListGaussMySqlInstancesRequest listGaussMySqlInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlInstancesRequest);
            return new SyncInvoker<ListGaussMySqlInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGaussMySqlInstancesResponse>);
        }
        
        /// <summary>
        /// 查询实例列表
        ///
        /// 根据指定条件查询实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGaussMySqlInstancesUnifyStatusResponse ListGaussMySqlInstancesUnifyStatus(ListGaussMySqlInstancesUnifyStatusRequest listGaussMySqlInstancesUnifyStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlInstancesUnifyStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGaussMySqlInstancesUnifyStatusResponse>(response);
        }

        public SyncInvoker<ListGaussMySqlInstancesUnifyStatusResponse> ListGaussMySqlInstancesUnifyStatusInvoker(ListGaussMySqlInstancesUnifyStatusRequest listGaussMySqlInstancesUnifyStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlInstancesUnifyStatusRequest);
            return new SyncInvoker<ListGaussMySqlInstancesUnifyStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGaussMySqlInstancesUnifyStatusResponse>);
        }
        
        /// <summary>
        /// 获取即时任务列表
        ///
        /// 获取即时任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListImmediateJobsResponse ListImmediateJobs(ListImmediateJobsRequest listImmediateJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/immediate-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImmediateJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListImmediateJobsResponse>(response);
        }

        public SyncInvoker<ListImmediateJobsResponse> ListImmediateJobsInvoker(ListImmediateJobsRequest listImmediateJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/immediate-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImmediateJobsRequest);
            return new SyncInvoker<ListImmediateJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListImmediateJobsResponse>);
        }
        
        /// <summary>
        /// 获取指定实例的参数信息
        ///
        /// 获取指定实例的参数信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceConfigurationsResponse ListInstanceConfigurations(ListInstanceConfigurationsRequest listInstanceConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceConfigurationsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceConfigurationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceConfigurationsResponse>(response);
        }

        public SyncInvoker<ListInstanceConfigurationsResponse> ListInstanceConfigurationsInvoker(ListInstanceConfigurationsRequest listInstanceConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceConfigurationsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceConfigurationsRequest);
            return new SyncInvoker<ListInstanceConfigurationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceConfigurationsResponse>);
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
        /// 获取错误日志详情列表
        ///
        /// 获取指定实例的错误日志详情列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLtsErrorLogDetailsResponse ListLtsErrorLogDetails(ListLtsErrorLogDetailsRequest listLtsErrorLogDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listLtsErrorLogDetailsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/error-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listLtsErrorLogDetailsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListLtsErrorLogDetailsResponse>(response);
        }

        public SyncInvoker<ListLtsErrorLogDetailsResponse> ListLtsErrorLogDetailsInvoker(ListLtsErrorLogDetailsRequest listLtsErrorLogDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listLtsErrorLogDetailsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/error-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listLtsErrorLogDetailsRequest);
            return new SyncInvoker<ListLtsErrorLogDetailsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLtsErrorLogDetailsResponse>);
        }
        
        /// <summary>
        /// 获取慢日志详情列表
        ///
        /// 获取指定实例的慢日志详情列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLtsSlowlogDetailsResponse ListLtsSlowlogDetails(ListLtsSlowlogDetailsRequest listLtsSlowlogDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listLtsSlowlogDetailsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listLtsSlowlogDetailsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListLtsSlowlogDetailsResponse>(response);
        }

        public SyncInvoker<ListLtsSlowlogDetailsResponse> ListLtsSlowlogDetailsInvoker(ListLtsSlowlogDetailsRequest listLtsSlowlogDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listLtsSlowlogDetailsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listLtsSlowlogDetailsRequest);
            return new SyncInvoker<ListLtsSlowlogDetailsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLtsSlowlogDetailsResponse>);
        }
        
        /// <summary>
        /// 查询参数修改历史
        ///
        /// 查询参数修改历史。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListModifyHistoryResponse ListModifyHistory(ListModifyHistoryRequest listModifyHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", listModifyHistoryRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}/modify-history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listModifyHistoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListModifyHistoryResponse>(response);
        }

        public SyncInvoker<ListModifyHistoryResponse> ListModifyHistoryInvoker(ListModifyHistoryRequest listModifyHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", listModifyHistoryRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}/modify-history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listModifyHistoryRequest);
            return new SyncInvoker<ListModifyHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ListModifyHistoryResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询指定project ID下实例的所有标签集合。
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
        /// 获取定时任务列表
        ///
        /// 获取定时任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListScheduleJobsResponse ListScheduleJobs(ListScheduleJobsRequest listScheduleJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/scheduled-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduleJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScheduleJobsResponse>(response);
        }

        public SyncInvoker<ListScheduleJobsResponse> ListScheduleJobsInvoker(ListScheduleJobsRequest listScheduleJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/scheduled-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduleJobsRequest);
            return new SyncInvoker<ListScheduleJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScheduleJobsResponse>);
        }
        
        /// <summary>
        /// 打开或关闭备份加密
        ///
        /// 打开或关闭备份加密。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyBackupEncryptStatusResponse ModifyBackupEncryptStatus(ModifyBackupEncryptStatusRequest modifyBackupEncryptStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyBackupEncryptStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/encryption", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyBackupEncryptStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ModifyBackupEncryptStatusResponse>(response);
        }

        public SyncInvoker<ModifyBackupEncryptStatusResponse> ModifyBackupEncryptStatusInvoker(ModifyBackupEncryptStatusRequest modifyBackupEncryptStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyBackupEncryptStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/encryption", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyBackupEncryptStatusRequest);
            return new SyncInvoker<ModifyBackupEncryptStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<ModifyBackupEncryptStatusResponse>);
        }
        
        /// <summary>
        /// 设置读写分离路由模式
        ///
        /// 设置读写分离路由模式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyGaussMySqlProxyRouteModeResponse ModifyGaussMySqlProxyRouteMode(ModifyGaussMySqlProxyRouteModeRequest modifyGaussMySqlProxyRouteModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyGaussMySqlProxyRouteModeRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", modifyGaussMySqlProxyRouteModeRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/route-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyGaussMySqlProxyRouteModeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyGaussMySqlProxyRouteModeResponse>(response);
        }

        public SyncInvoker<ModifyGaussMySqlProxyRouteModeResponse> ModifyGaussMySqlProxyRouteModeInvoker(ModifyGaussMySqlProxyRouteModeRequest modifyGaussMySqlProxyRouteModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyGaussMySqlProxyRouteModeRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", modifyGaussMySqlProxyRouteModeRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/route-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyGaussMySqlProxyRouteModeRequest);
            return new SyncInvoker<ModifyGaussMySqlProxyRouteModeResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyGaussMySqlProxyRouteModeResponse>);
        }
        
        /// <summary>
        /// 修改内网域名
        ///
        /// 修改内网域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyGaussMysqlDnsResponse ModifyGaussMysqlDns(ModifyGaussMysqlDnsRequest modifyGaussMysqlDnsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyGaussMysqlDnsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyGaussMysqlDnsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyGaussMysqlDnsResponse>(response);
        }

        public SyncInvoker<ModifyGaussMysqlDnsResponse> ModifyGaussMysqlDnsInvoker(ModifyGaussMysqlDnsRequest modifyGaussMysqlDnsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyGaussMysqlDnsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyGaussMysqlDnsRequest);
            return new SyncInvoker<ModifyGaussMysqlDnsResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyGaussMysqlDnsResponse>);
        }
        
        /// <summary>
        /// 修改数据库用户密码
        ///
        /// 修改云数据库 GaussDB(for MySQL)实例数据库用户密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetGaussMySqlDatabasePasswordResponse ResetGaussMySqlDatabasePassword(ResetGaussMySqlDatabasePasswordRequest resetGaussMySqlDatabasePasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetGaussMySqlDatabasePasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetGaussMySqlDatabasePasswordRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ResetGaussMySqlDatabasePasswordResponse>(response);
        }

        public SyncInvoker<ResetGaussMySqlDatabasePasswordResponse> ResetGaussMySqlDatabasePasswordInvoker(ResetGaussMySqlDatabasePasswordRequest resetGaussMySqlDatabasePasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetGaussMySqlDatabasePasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetGaussMySqlDatabasePasswordRequest);
            return new SyncInvoker<ResetGaussMySqlDatabasePasswordResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResetGaussMySqlDatabasePasswordResponse>);
        }
        
        /// <summary>
        /// 重置数据库密码
        ///
        /// 重置数据库密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetGaussMySqlPasswordResponse ResetGaussMySqlPassword(ResetGaussMySqlPasswordRequest resetGaussMySqlPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetGaussMySqlPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetGaussMySqlPasswordRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ResetGaussMySqlPasswordResponse>(response);
        }

        public SyncInvoker<ResetGaussMySqlPasswordResponse> ResetGaussMySqlPasswordInvoker(ResetGaussMySqlPasswordRequest resetGaussMySqlPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetGaussMySqlPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetGaussMySqlPasswordRequest);
            return new SyncInvoker<ResetGaussMySqlPasswordResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetGaussMySqlPasswordResponse>);
        }
        
        /// <summary>
        /// 重启数据库实例
        ///
        /// 重启数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestartGaussMySqlInstanceResponse RestartGaussMySqlInstance(RestartGaussMySqlInstanceRequest restartGaussMySqlInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartGaussMySqlInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restartGaussMySqlInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestartGaussMySqlInstanceResponse>(response);
        }

        public SyncInvoker<RestartGaussMySqlInstanceResponse> RestartGaussMySqlInstanceInvoker(RestartGaussMySqlInstanceRequest restartGaussMySqlInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartGaussMySqlInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restartGaussMySqlInstanceRequest);
            return new SyncInvoker<RestartGaussMySqlInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestartGaussMySqlInstanceResponse>);
        }
        
        /// <summary>
        /// 节点重启
        ///
        /// 节点重启。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestartGaussMySqlNodeResponse RestartGaussMySqlNode(RestartGaussMySqlNodeRequest restartGaussMySqlNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartGaussMySqlNodeRequest.InstanceId.ToString());
            urlParam.Add("node_id", restartGaussMySqlNodeRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restartGaussMySqlNodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestartGaussMySqlNodeResponse>(response);
        }

        public SyncInvoker<RestartGaussMySqlNodeResponse> RestartGaussMySqlNodeInvoker(RestartGaussMySqlNodeRequest restartGaussMySqlNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartGaussMySqlNodeRequest.InstanceId.ToString());
            urlParam.Add("node_id", restartGaussMySqlNodeRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restartGaussMySqlNodeRequest);
            return new SyncInvoker<RestartGaussMySqlNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<RestartGaussMySqlNodeResponse>);
        }
        
        /// <summary>
        /// 备份恢复到当前实例或已有实例
        ///
        /// 备份恢复到当前实例或已有实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreOldInstanceResponse RestoreOldInstance(RestoreOldInstanceRequest restoreOldInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreOldInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestoreOldInstanceResponse>(response);
        }

        public SyncInvoker<RestoreOldInstanceResponse> RestoreOldInstanceInvoker(RestoreOldInstanceRequest restoreOldInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreOldInstanceRequest);
            return new SyncInvoker<RestoreOldInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreOldInstanceResponse>);
        }
        
        /// <summary>
        /// 设置读写分离权重
        ///
        /// 设置读写分离权重。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetGaussMySqlProxyWeightResponse SetGaussMySqlProxyWeight(SetGaussMySqlProxyWeightRequest setGaussMySqlProxyWeightRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setGaussMySqlProxyWeightRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", setGaussMySqlProxyWeightRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/weight", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setGaussMySqlProxyWeightRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SetGaussMySqlProxyWeightResponse>(response);
        }

        public SyncInvoker<SetGaussMySqlProxyWeightResponse> SetGaussMySqlProxyWeightInvoker(SetGaussMySqlProxyWeightRequest setGaussMySqlProxyWeightRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setGaussMySqlProxyWeightRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", setGaussMySqlProxyWeightRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/weight", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setGaussMySqlProxyWeightRequest);
            return new SyncInvoker<SetGaussMySqlProxyWeightResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetGaussMySqlProxyWeightResponse>);
        }
        
        /// <summary>
        /// 设置租户基于企业项目的资源配额
        ///
        /// 设置指定企业项目的资源配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetGaussMySqlQuotasResponse SetGaussMySqlQuotas(SetGaussMySqlQuotasRequest setGaussMySqlQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setGaussMySqlQuotasRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SetGaussMySqlQuotasResponse>(response);
        }

        public SyncInvoker<SetGaussMySqlQuotasResponse> SetGaussMySqlQuotasInvoker(SetGaussMySqlQuotasRequest setGaussMySqlQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setGaussMySqlQuotasRequest);
            return new SyncInvoker<SetGaussMySqlQuotasResponse>(this, "POST", request, JsonUtils.DeSerialize<SetGaussMySqlQuotasResponse>);
        }
        
        /// <summary>
        /// 查询全量SQL开关状态
        ///
        /// 查询全量SQL开关状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAuditLogResponse ShowAuditLog(ShowAuditLogRequest showAuditLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAuditLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/audit-log/switch-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditLogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditLogResponse>(response);
        }

        public SyncInvoker<ShowAuditLogResponse> ShowAuditLogInvoker(ShowAuditLogRequest showAuditLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAuditLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/audit-log/switch-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditLogRequest);
            return new SyncInvoker<ShowAuditLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditLogResponse>);
        }
        
        /// <summary>
        /// 查询自动变配
        ///
        /// 查询自动变配。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutoScalingPolicyResponse ShowAutoScalingPolicy(ShowAutoScalingPolicyRequest showAutoScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAutoScalingPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auto-scaling/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoScalingPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoScalingPolicyResponse>(response);
        }

        public SyncInvoker<ShowAutoScalingPolicyResponse> ShowAutoScalingPolicyInvoker(ShowAutoScalingPolicyRequest showAutoScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAutoScalingPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auto-scaling/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoScalingPolicyRequest);
            return new SyncInvoker<ShowAutoScalingPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 查询可恢复时间段
        ///
        /// 查询实例的可恢复时间段。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBackupRestoreTimeResponse ShowBackupRestoreTime(ShowBackupRestoreTimeRequest showBackupRestoreTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBackupRestoreTimeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupRestoreTimeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBackupRestoreTimeResponse>(response);
        }

        public SyncInvoker<ShowBackupRestoreTimeResponse> ShowBackupRestoreTimeInvoker(ShowBackupRestoreTimeRequest showBackupRestoreTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBackupRestoreTimeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupRestoreTimeRequest);
            return new SyncInvoker<ShowBackupRestoreTimeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackupRestoreTimeResponse>);
        }
        
        /// <summary>
        /// 查询专属资源信息详情
        ///
        /// 查询专属资源信息详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDedicatedResourceInfoResponse ShowDedicatedResourceInfo(ShowDedicatedResourceInfoRequest showDedicatedResourceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dedicated_resource_id", showDedicatedResourceInfoRequest.DedicatedResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dedicated-resource/{dedicated_resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDedicatedResourceInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDedicatedResourceInfoResponse>(response);
        }

        public SyncInvoker<ShowDedicatedResourceInfoResponse> ShowDedicatedResourceInfoInvoker(ShowDedicatedResourceInfoRequest showDedicatedResourceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dedicated_resource_id", showDedicatedResourceInfoRequest.DedicatedResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dedicated-resource/{dedicated_resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDedicatedResourceInfoRequest);
            return new SyncInvoker<ShowDedicatedResourceInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDedicatedResourceInfoResponse>);
        }
        
        /// <summary>
        /// 查询全量备份列表
        ///
        /// 查询全量备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlBackupListResponse ShowGaussMySqlBackupList(ShowGaussMySqlBackupListRequest showGaussMySqlBackupListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlBackupListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlBackupListResponse>(response);
        }

        public SyncInvoker<ShowGaussMySqlBackupListResponse> ShowGaussMySqlBackupListInvoker(ShowGaussMySqlBackupListRequest showGaussMySqlBackupListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlBackupListRequest);
            return new SyncInvoker<ShowGaussMySqlBackupListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlBackupListResponse>);
        }
        
        /// <summary>
        /// 查询自动备份策略
        ///
        /// 查询自动备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlBackupPolicyResponse ShowGaussMySqlBackupPolicy(ShowGaussMySqlBackupPolicyRequest showGaussMySqlBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlBackupPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlBackupPolicyResponse>(response);
        }

        public SyncInvoker<ShowGaussMySqlBackupPolicyResponse> ShowGaussMySqlBackupPolicyInvoker(ShowGaussMySqlBackupPolicyRequest showGaussMySqlBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlBackupPolicyRequest);
            return new SyncInvoker<ShowGaussMySqlBackupPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlBackupPolicyResponse>);
        }
        
        /// <summary>
        /// 获取参数模板详情
        ///
        /// 获取指定参数模板的参数信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlConfigurationResponse ShowGaussMySqlConfiguration(ShowGaussMySqlConfigurationRequest showGaussMySqlConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", showGaussMySqlConfigurationRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlConfigurationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlConfigurationResponse>(response);
        }

        public SyncInvoker<ShowGaussMySqlConfigurationResponse> ShowGaussMySqlConfigurationInvoker(ShowGaussMySqlConfigurationRequest showGaussMySqlConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", showGaussMySqlConfigurationRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlConfigurationRequest);
            return new SyncInvoker<ShowGaussMySqlConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlConfigurationResponse>);
        }
        
        /// <summary>
        /// 查询数据库引擎的版本
        ///
        /// 获取指定数据库引擎对应的数据库版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlEngineVersionResponse ShowGaussMySqlEngineVersion(ShowGaussMySqlEngineVersionRequest showGaussMySqlEngineVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name", showGaussMySqlEngineVersionRequest.DatabaseName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlEngineVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlEngineVersionResponse>(response);
        }

        public SyncInvoker<ShowGaussMySqlEngineVersionResponse> ShowGaussMySqlEngineVersionInvoker(ShowGaussMySqlEngineVersionRequest showGaussMySqlEngineVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name", showGaussMySqlEngineVersionRequest.DatabaseName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlEngineVersionRequest);
            return new SyncInvoker<ShowGaussMySqlEngineVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlEngineVersionResponse>);
        }
        
        /// <summary>
        /// 查询数据库规格
        ///
        /// 获取指定数据库引擎版本对应的规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlFlavorsResponse ShowGaussMySqlFlavors(ShowGaussMySqlFlavorsRequest showGaussMySqlFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name", showGaussMySqlFlavorsRequest.DatabaseName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlFlavorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlFlavorsResponse>(response);
        }

        public SyncInvoker<ShowGaussMySqlFlavorsResponse> ShowGaussMySqlFlavorsInvoker(ShowGaussMySqlFlavorsRequest showGaussMySqlFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name", showGaussMySqlFlavorsRequest.DatabaseName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlFlavorsRequest);
            return new SyncInvoker<ShowGaussMySqlFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询增量备份列表
        ///
        /// 查询增量备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlIncrementalBackupListResponse ShowGaussMySqlIncrementalBackupList(ShowGaussMySqlIncrementalBackupListRequest showGaussMySqlIncrementalBackupListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlIncrementalBackupListRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/incremental-backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlIncrementalBackupListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlIncrementalBackupListResponse>(response);
        }

        public SyncInvoker<ShowGaussMySqlIncrementalBackupListResponse> ShowGaussMySqlIncrementalBackupListInvoker(ShowGaussMySqlIncrementalBackupListRequest showGaussMySqlIncrementalBackupListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlIncrementalBackupListRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/incremental-backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlIncrementalBackupListRequest);
            return new SyncInvoker<ShowGaussMySqlIncrementalBackupListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlIncrementalBackupListResponse>);
        }
        
        /// <summary>
        /// 查询实例详情信息
        ///
        /// 查询实例详情信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlInstanceInfoResponse ShowGaussMySqlInstanceInfo(ShowGaussMySqlInstanceInfoRequest showGaussMySqlInstanceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlInstanceInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlInstanceInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlInstanceInfoResponse>(response);
        }

        public SyncInvoker<ShowGaussMySqlInstanceInfoResponse> ShowGaussMySqlInstanceInfoInvoker(ShowGaussMySqlInstanceInfoRequest showGaussMySqlInstanceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlInstanceInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlInstanceInfoRequest);
            return new SyncInvoker<ShowGaussMySqlInstanceInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlInstanceInfoResponse>);
        }
        
        /// <summary>
        /// 查询实例详情信息
        ///
        /// 查询实例详情信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlInstanceInfoUnifyStatusResponse ShowGaussMySqlInstanceInfoUnifyStatus(ShowGaussMySqlInstanceInfoUnifyStatusRequest showGaussMySqlInstanceInfoUnifyStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlInstanceInfoUnifyStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlInstanceInfoUnifyStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlInstanceInfoUnifyStatusResponse>(response);
        }

        public SyncInvoker<ShowGaussMySqlInstanceInfoUnifyStatusResponse> ShowGaussMySqlInstanceInfoUnifyStatusInvoker(ShowGaussMySqlInstanceInfoUnifyStatusRequest showGaussMySqlInstanceInfoUnifyStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlInstanceInfoUnifyStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlInstanceInfoUnifyStatusRequest);
            return new SyncInvoker<ShowGaussMySqlInstanceInfoUnifyStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlInstanceInfoUnifyStatusResponse>);
        }
        
        /// <summary>
        /// 获取指定ID的任务信息
        ///
        /// 获取GaussDB(for MySQL)任务中心指定ID的任务信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlJobInfoResponse ShowGaussMySqlJobInfo(ShowGaussMySqlJobInfoRequest showGaussMySqlJobInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlJobInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlJobInfoResponse>(response);
        }

        public SyncInvoker<ShowGaussMySqlJobInfoResponse> ShowGaussMySqlJobInfoInvoker(ShowGaussMySqlJobInfoRequest showGaussMySqlJobInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlJobInfoRequest);
            return new SyncInvoker<ShowGaussMySqlJobInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlJobInfoResponse>);
        }
        
        /// <summary>
        /// 查询租户的实例配额
        ///
        /// 获取指定租户的资源配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlProjectQuotasResponse ShowGaussMySqlProjectQuotas(ShowGaussMySqlProjectQuotasRequest showGaussMySqlProjectQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/project-quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlProjectQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlProjectQuotasResponse>(response);
        }

        public SyncInvoker<ShowGaussMySqlProjectQuotasResponse> ShowGaussMySqlProjectQuotasInvoker(ShowGaussMySqlProjectQuotasRequest showGaussMySqlProjectQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/project-quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlProjectQuotasRequest);
            return new SyncInvoker<ShowGaussMySqlProjectQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlProjectQuotasResponse>);
        }
        
        /// <summary>
        /// 查询数据库代理规格信息
        ///
        /// 查询数据库代理规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlProxyFlavorsResponse ShowGaussMySqlProxyFlavors(ShowGaussMySqlProxyFlavorsRequest showGaussMySqlProxyFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlProxyFlavorsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlProxyFlavorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlProxyFlavorsResponse>(response);
        }

        public SyncInvoker<ShowGaussMySqlProxyFlavorsResponse> ShowGaussMySqlProxyFlavorsInvoker(ShowGaussMySqlProxyFlavorsRequest showGaussMySqlProxyFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlProxyFlavorsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlProxyFlavorsRequest);
            return new SyncInvoker<ShowGaussMySqlProxyFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlProxyFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询数据库代理信息列表
        ///
        /// 查询数据库代理信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlProxyListResponse ShowGaussMySqlProxyList(ShowGaussMySqlProxyListRequest showGaussMySqlProxyListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlProxyListRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlProxyListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlProxyListResponse>(response);
        }

        public SyncInvoker<ShowGaussMySqlProxyListResponse> ShowGaussMySqlProxyListInvoker(ShowGaussMySqlProxyListRequest showGaussMySqlProxyListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlProxyListRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlProxyListRequest);
            return new SyncInvoker<ShowGaussMySqlProxyListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlProxyListResponse>);
        }
        
        /// <summary>
        /// 查询租户基于企业项目的资源配额
        ///
        /// 获取指定企业项目的资源配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGaussMySqlQuotasResponse ShowGaussMySqlQuotas(ShowGaussMySqlQuotasRequest showGaussMySqlQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlQuotasResponse>(response);
        }

        public SyncInvoker<ShowGaussMySqlQuotasResponse> ShowGaussMySqlQuotasInvoker(ShowGaussMySqlQuotasRequest showGaussMySqlQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlQuotasRequest);
            return new SyncInvoker<ShowGaussMySqlQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlQuotasResponse>);
        }
        
        /// <summary>
        /// 查询内核版本信息
        ///
        /// 查询内核版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceDatabaseVersionResponse ShowInstanceDatabaseVersion(ShowInstanceDatabaseVersionRequest showInstanceDatabaseVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceDatabaseVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceDatabaseVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceDatabaseVersionResponse>(response);
        }

        public SyncInvoker<ShowInstanceDatabaseVersionResponse> ShowInstanceDatabaseVersionInvoker(ShowInstanceDatabaseVersionRequest showInstanceDatabaseVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceDatabaseVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceDatabaseVersionRequest);
            return new SyncInvoker<ShowInstanceDatabaseVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceDatabaseVersionResponse>);
        }
        
        /// <summary>
        /// 查询实例秒级监控
        ///
        /// 查询实例秒级监控信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceMonitorExtendResponse ShowInstanceMonitorExtend(ShowInstanceMonitorExtendRequest showInstanceMonitorExtendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceMonitorExtendRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitor-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceMonitorExtendRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceMonitorExtendResponse>(response);
        }

        public SyncInvoker<ShowInstanceMonitorExtendResponse> ShowInstanceMonitorExtendInvoker(ShowInstanceMonitorExtendRequest showInstanceMonitorExtendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceMonitorExtendRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitor-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceMonitorExtendRequest);
            return new SyncInvoker<ShowInstanceMonitorExtendResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceMonitorExtendResponse>);
        }
        
        /// <summary>
        /// 获取各指标的异常实例数
        ///
        /// 获取各指标的异常实例数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowIntelligentDiagnosisAbnormalCountOfInstancesResponse ShowIntelligentDiagnosisAbnormalCountOfInstances(ShowIntelligentDiagnosisAbnormalCountOfInstancesRequest showIntelligentDiagnosisAbnormalCountOfInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/diagnosis-instance-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIntelligentDiagnosisAbnormalCountOfInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowIntelligentDiagnosisAbnormalCountOfInstancesResponse>(response);
        }

        public SyncInvoker<ShowIntelligentDiagnosisAbnormalCountOfInstancesResponse> ShowIntelligentDiagnosisAbnormalCountOfInstancesInvoker(ShowIntelligentDiagnosisAbnormalCountOfInstancesRequest showIntelligentDiagnosisAbnormalCountOfInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/diagnosis-instance-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIntelligentDiagnosisAbnormalCountOfInstancesRequest);
            return new SyncInvoker<ShowIntelligentDiagnosisAbnormalCountOfInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIntelligentDiagnosisAbnormalCountOfInstancesResponse>);
        }
        
        /// <summary>
        /// 获取某个指标的异常实例信息
        ///
        /// 获取某个指标的异常实例信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowIntelligentDiagnosisInstanceInfosPerMetricResponse ShowIntelligentDiagnosisInstanceInfosPerMetric(ShowIntelligentDiagnosisInstanceInfosPerMetricRequest showIntelligentDiagnosisInstanceInfosPerMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/diagnosis-instance-infos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIntelligentDiagnosisInstanceInfosPerMetricRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowIntelligentDiagnosisInstanceInfosPerMetricResponse>(response);
        }

        public SyncInvoker<ShowIntelligentDiagnosisInstanceInfosPerMetricResponse> ShowIntelligentDiagnosisInstanceInfosPerMetricInvoker(ShowIntelligentDiagnosisInstanceInfosPerMetricRequest showIntelligentDiagnosisInstanceInfosPerMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/diagnosis-instance-infos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIntelligentDiagnosisInstanceInfosPerMetricRequest);
            return new SyncInvoker<ShowIntelligentDiagnosisInstanceInfosPerMetricResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIntelligentDiagnosisInstanceInfosPerMetricResponse>);
        }
        
        /// <summary>
        /// 查询表级时间点恢复可选表
        ///
        /// 查询表级时间点恢复可选表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRestoreTablesResponse ShowRestoreTables(ShowRestoreTablesRequest showRestoreTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRestoreTablesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/restore/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRestoreTablesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRestoreTablesResponse>(response);
        }

        public SyncInvoker<ShowRestoreTablesResponse> ShowRestoreTablesInvoker(ShowRestoreTablesRequest showRestoreTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRestoreTablesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/restore/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRestoreTablesRequest);
            return new SyncInvoker<ShowRestoreTablesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRestoreTablesResponse>);
        }
        
        /// <summary>
        /// 减少数据库代理节点的数量
        ///
        /// 缩容数据库代理节点的数量。
        /// DeC专属云账号暂不支持数据库代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShrinkGaussMySqlProxyResponse ShrinkGaussMySqlProxy(ShrinkGaussMySqlProxyRequest shrinkGaussMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", shrinkGaussMySqlProxyRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", shrinkGaussMySqlProxyRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/reduce", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", shrinkGaussMySqlProxyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ShrinkGaussMySqlProxyResponse>(response);
        }

        public SyncInvoker<ShrinkGaussMySqlProxyResponse> ShrinkGaussMySqlProxyInvoker(ShrinkGaussMySqlProxyRequest shrinkGaussMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", shrinkGaussMySqlProxyRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", shrinkGaussMySqlProxyRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/reduce", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", shrinkGaussMySqlProxyRequest);
            return new SyncInvoker<ShrinkGaussMySqlProxyResponse>(this, "PUT", request, JsonUtils.DeSerialize<ShrinkGaussMySqlProxyResponse>);
        }
        
        /// <summary>
        /// 开启或关闭访问控制
        ///
        /// 开启或关闭访问控制。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchAccessControlResponse SwitchAccessControl(SwitchAccessControlRequest switchAccessControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchAccessControlRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", switchAccessControlRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/access-control-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAccessControlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchAccessControlResponse>(response);
        }

        public SyncInvoker<SwitchAccessControlResponse> SwitchAccessControlInvoker(SwitchAccessControlRequest switchAccessControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchAccessControlRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", switchAccessControlRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/access-control-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAccessControlRequest);
            return new SyncInvoker<SwitchAccessControlResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchAccessControlResponse>);
        }
        
        /// <summary>
        /// 应用参数模板
        ///
        /// 指定实例变更参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchGaussMySqlConfigurationResponse SwitchGaussMySqlConfiguration(SwitchGaussMySqlConfigurationRequest switchGaussMySqlConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", switchGaussMySqlConfigurationRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchGaussMySqlConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SwitchGaussMySqlConfigurationResponse>(response);
        }

        public SyncInvoker<SwitchGaussMySqlConfigurationResponse> SwitchGaussMySqlConfigurationInvoker(SwitchGaussMySqlConfigurationRequest switchGaussMySqlConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", switchGaussMySqlConfigurationRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchGaussMySqlConfigurationRequest);
            return new SyncInvoker<SwitchGaussMySqlConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchGaussMySqlConfigurationResponse>);
        }
        
        /// <summary>
        /// 开关SSL
        ///
        /// 为实例设置SSL数据加密。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchGaussMySqlInstanceSslResponse SwitchGaussMySqlInstanceSsl(SwitchGaussMySqlInstanceSslRequest switchGaussMySqlInstanceSslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchGaussMySqlInstanceSslRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-option", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchGaussMySqlInstanceSslRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SwitchGaussMySqlInstanceSslResponse>(response);
        }

        public SyncInvoker<SwitchGaussMySqlInstanceSslResponse> SwitchGaussMySqlInstanceSslInvoker(SwitchGaussMySqlInstanceSslRequest switchGaussMySqlInstanceSslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchGaussMySqlInstanceSslRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-option", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchGaussMySqlInstanceSslRequest);
            return new SyncInvoker<SwitchGaussMySqlInstanceSslResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchGaussMySqlInstanceSslResponse>);
        }
        
        /// <summary>
        /// 开关数据库代理SSL
        ///
        /// 为数据库代理设置SSL数据加密。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchGaussMySqlProxySslResponse SwitchGaussMySqlProxySsl(SwitchGaussMySqlProxySslRequest switchGaussMySqlProxySslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchGaussMySqlProxySslRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", switchGaussMySqlProxySslRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchGaussMySqlProxySslRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SwitchGaussMySqlProxySslResponse>(response);
        }

        public SyncInvoker<SwitchGaussMySqlProxySslResponse> SwitchGaussMySqlProxySslInvoker(SwitchGaussMySqlProxySslRequest switchGaussMySqlProxySslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchGaussMySqlProxySslRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", switchGaussMySqlProxySslRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchGaussMySqlProxySslRequest);
            return new SyncInvoker<SwitchGaussMySqlProxySslResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchGaussMySqlProxySslResponse>);
        }
        
        /// <summary>
        /// 开启或者关闭全量SQL
        ///
        /// 开启或者关闭全量SQL。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAuditLogResponse UpdateAuditLog(UpdateAuditLogRequest updateAuditLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateAuditLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/audit-log/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditLogRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateAuditLogResponse>(response);
        }

        public SyncInvoker<UpdateAuditLogResponse> UpdateAuditLogInvoker(UpdateAuditLogRequest updateAuditLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateAuditLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/audit-log/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditLogRequest);
            return new SyncInvoker<UpdateAuditLogResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAuditLogResponse>);
        }
        
        /// <summary>
        /// 设置自动变配
        ///
        /// 设置自动变配。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAutoScalingPolicyResponse UpdateAutoScalingPolicy(UpdateAutoScalingPolicyRequest updateAutoScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateAutoScalingPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auto-scaling/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAutoScalingPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAutoScalingPolicyResponse>(response);
        }

        public SyncInvoker<UpdateAutoScalingPolicyResponse> UpdateAutoScalingPolicyInvoker(UpdateAutoScalingPolicyRequest updateAutoScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateAutoScalingPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auto-scaling/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAutoScalingPolicyRequest);
            return new SyncInvoker<UpdateAutoScalingPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAutoScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 设置跨区备份策略
        ///
        /// 设置跨区备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateBackupOffsitePolicyResponse UpdateBackupOffsitePolicy(UpdateBackupOffsitePolicyRequest updateBackupOffsitePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateBackupOffsitePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/offsite-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBackupOffsitePolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateBackupOffsitePolicyResponse>(response);
        }

        public SyncInvoker<UpdateBackupOffsitePolicyResponse> UpdateBackupOffsitePolicyInvoker(UpdateBackupOffsitePolicyRequest updateBackupOffsitePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateBackupOffsitePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/offsite-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBackupOffsitePolicyRequest);
            return new SyncInvoker<UpdateBackupOffsitePolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateBackupOffsitePolicyResponse>);
        }
        
        /// <summary>
        /// 设置备份策略
        ///
        /// 设置自动备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlBackupPolicyResponse UpdateGaussMySqlBackupPolicy(UpdateGaussMySqlBackupPolicyRequest updateGaussMySqlBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlBackupPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlBackupPolicyResponse>(response);
        }

        public SyncInvoker<UpdateGaussMySqlBackupPolicyResponse> UpdateGaussMySqlBackupPolicyInvoker(UpdateGaussMySqlBackupPolicyRequest updateGaussMySqlBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlBackupPolicyRequest);
            return new SyncInvoker<UpdateGaussMySqlBackupPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGaussMySqlBackupPolicyResponse>);
        }
        
        /// <summary>
        /// 修改参数模板
        ///
        /// 修改指定参数模板的参数信息，包括名称、描述、指定参数的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlConfigurationResponse UpdateGaussMySqlConfiguration(UpdateGaussMySqlConfigurationRequest updateGaussMySqlConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", updateGaussMySqlConfigurationRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlConfigurationResponse>(response);
        }

        public SyncInvoker<UpdateGaussMySqlConfigurationResponse> UpdateGaussMySqlConfigurationInvoker(UpdateGaussMySqlConfigurationRequest updateGaussMySqlConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", updateGaussMySqlConfigurationRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlConfigurationRequest);
            return new SyncInvoker<UpdateGaussMySqlConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGaussMySqlConfigurationResponse>);
        }
        
        /// <summary>
        /// 修改数据库备注
        ///
        /// 修改云数据库 GaussDB(for MySQL)实例数据库备注。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlDatabaseCommentResponse UpdateGaussMySqlDatabaseComment(UpdateGaussMySqlDatabaseCommentRequest updateGaussMySqlDatabaseCommentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlDatabaseCommentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/comment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlDatabaseCommentRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlDatabaseCommentResponse>(response);
        }

        public SyncInvoker<UpdateGaussMySqlDatabaseCommentResponse> UpdateGaussMySqlDatabaseCommentInvoker(UpdateGaussMySqlDatabaseCommentRequest updateGaussMySqlDatabaseCommentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlDatabaseCommentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/comment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlDatabaseCommentRequest);
            return new SyncInvoker<UpdateGaussMySqlDatabaseCommentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGaussMySqlDatabaseCommentResponse>);
        }
        
        /// <summary>
        /// 修改数据库用户备注
        ///
        /// 修改云数据库 GaussDB(for MySQL)实例数据库用户备注。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlDatabaseUserCommentResponse UpdateGaussMySqlDatabaseUserComment(UpdateGaussMySqlDatabaseUserCommentRequest updateGaussMySqlDatabaseUserCommentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlDatabaseUserCommentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/comment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlDatabaseUserCommentRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlDatabaseUserCommentResponse>(response);
        }

        public SyncInvoker<UpdateGaussMySqlDatabaseUserCommentResponse> UpdateGaussMySqlDatabaseUserCommentInvoker(UpdateGaussMySqlDatabaseUserCommentRequest updateGaussMySqlDatabaseUserCommentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlDatabaseUserCommentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/comment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlDatabaseUserCommentRequest);
            return new SyncInvoker<UpdateGaussMySqlDatabaseUserCommentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGaussMySqlDatabaseUserCommentResponse>);
        }
        
        /// <summary>
        /// 修改实例备注
        ///
        /// 修改实例备注。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlInstanceAliasResponse UpdateGaussMySqlInstanceAlias(UpdateGaussMySqlInstanceAliasRequest updateGaussMySqlInstanceAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceAliasRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/alias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceAliasRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateGaussMySqlInstanceAliasResponse>(response);
        }

        public SyncInvoker<UpdateGaussMySqlInstanceAliasResponse> UpdateGaussMySqlInstanceAliasInvoker(UpdateGaussMySqlInstanceAliasRequest updateGaussMySqlInstanceAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceAliasRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/alias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceAliasRequest);
            return new SyncInvoker<UpdateGaussMySqlInstanceAliasResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateGaussMySqlInstanceAliasResponse>);
        }
        
        /// <summary>
        /// 绑定弹性公网IP
        ///
        /// 实例绑定弹性公网IP，供外网连接使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlInstanceEipResponse UpdateGaussMySqlInstanceEip(UpdateGaussMySqlInstanceEipRequest updateGaussMySqlInstanceEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceEipRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ips/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceEipRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlInstanceEipResponse>(response);
        }

        public SyncInvoker<UpdateGaussMySqlInstanceEipResponse> UpdateGaussMySqlInstanceEipInvoker(UpdateGaussMySqlInstanceEipRequest updateGaussMySqlInstanceEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceEipRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ips/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceEipRequest);
            return new SyncInvoker<UpdateGaussMySqlInstanceEipResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGaussMySqlInstanceEipResponse>);
        }
        
        /// <summary>
        /// 修改内网地址
        ///
        /// 修改实例内网地址。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlInstanceInternalIpResponse UpdateGaussMySqlInstanceInternalIp(UpdateGaussMySqlInstanceInternalIpRequest updateGaussMySqlInstanceInternalIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceInternalIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/internal-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceInternalIpRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlInstanceInternalIpResponse>(response);
        }

        public SyncInvoker<UpdateGaussMySqlInstanceInternalIpResponse> UpdateGaussMySqlInstanceInternalIpInvoker(UpdateGaussMySqlInstanceInternalIpRequest updateGaussMySqlInstanceInternalIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceInternalIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/internal-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceInternalIpRequest);
            return new SyncInvoker<UpdateGaussMySqlInstanceInternalIpResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGaussMySqlInstanceInternalIpResponse>);
        }
        
        /// <summary>
        /// 修改实例名称
        ///
        /// 修改实例名称。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlInstanceNameResponse UpdateGaussMySqlInstanceName(UpdateGaussMySqlInstanceNameRequest updateGaussMySqlInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceNameRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlInstanceNameResponse>(response);
        }

        public SyncInvoker<UpdateGaussMySqlInstanceNameResponse> UpdateGaussMySqlInstanceNameInvoker(UpdateGaussMySqlInstanceNameRequest updateGaussMySqlInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceNameRequest);
            return new SyncInvoker<UpdateGaussMySqlInstanceNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGaussMySqlInstanceNameResponse>);
        }
        
        /// <summary>
        /// 设置可维护时间段
        ///
        /// 设置可维护时间段。建议将可维护时间段设置在业务低峰期，避免业务在维护过程中异常中断。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlInstanceOpsWindowResponse UpdateGaussMySqlInstanceOpsWindow(UpdateGaussMySqlInstanceOpsWindowRequest updateGaussMySqlInstanceOpsWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceOpsWindowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ops-window", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceOpsWindowRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateGaussMySqlInstanceOpsWindowResponse>(response);
        }

        public SyncInvoker<UpdateGaussMySqlInstanceOpsWindowResponse> UpdateGaussMySqlInstanceOpsWindowInvoker(UpdateGaussMySqlInstanceOpsWindowRequest updateGaussMySqlInstanceOpsWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceOpsWindowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ops-window", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceOpsWindowRequest);
            return new SyncInvoker<UpdateGaussMySqlInstanceOpsWindowResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateGaussMySqlInstanceOpsWindowResponse>);
        }
        
        /// <summary>
        /// 修改实例端口
        ///
        /// 修改实例数据库端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlInstancePortResponse UpdateGaussMySqlInstancePort(UpdateGaussMySqlInstancePortRequest updateGaussMySqlInstancePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstancePortRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstancePortRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlInstancePortResponse>(response);
        }

        public SyncInvoker<UpdateGaussMySqlInstancePortResponse> UpdateGaussMySqlInstancePortInvoker(UpdateGaussMySqlInstancePortRequest updateGaussMySqlInstancePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstancePortRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstancePortRequest);
            return new SyncInvoker<UpdateGaussMySqlInstancePortResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGaussMySqlInstancePortResponse>);
        }
        
        /// <summary>
        /// 修改安全组
        ///
        /// 修改指定实例安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlInstanceSecurityGroupResponse UpdateGaussMySqlInstanceSecurityGroup(UpdateGaussMySqlInstanceSecurityGroupRequest updateGaussMySqlInstanceSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceSecurityGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceSecurityGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlInstanceSecurityGroupResponse>(response);
        }

        public SyncInvoker<UpdateGaussMySqlInstanceSecurityGroupResponse> UpdateGaussMySqlInstanceSecurityGroupInvoker(UpdateGaussMySqlInstanceSecurityGroupRequest updateGaussMySqlInstanceSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceSecurityGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceSecurityGroupRequest);
            return new SyncInvoker<UpdateGaussMySqlInstanceSecurityGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGaussMySqlInstanceSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 修改租户基于企业项目的资源配额
        ///
        /// 修改指定企业项目的资源配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGaussMySqlQuotasResponse UpdateGaussMySqlQuotas(UpdateGaussMySqlQuotasRequest updateGaussMySqlQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlQuotasRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlQuotasResponse>(response);
        }

        public SyncInvoker<UpdateGaussMySqlQuotasResponse> UpdateGaussMySqlQuotasInvoker(UpdateGaussMySqlQuotasRequest updateGaussMySqlQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlQuotasRequest);
            return new SyncInvoker<UpdateGaussMySqlQuotasResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGaussMySqlQuotasResponse>);
        }
        
        /// <summary>
        /// 修改指定实例的参数
        ///
        /// 修改指定实例的参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceConfigurationsResponse UpdateInstanceConfigurations(UpdateInstanceConfigurationsRequest updateInstanceConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceConfigurationsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceConfigurationsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceConfigurationsResponse>(response);
        }

        public SyncInvoker<UpdateInstanceConfigurationsResponse> UpdateInstanceConfigurationsInvoker(UpdateInstanceConfigurationsRequest updateInstanceConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceConfigurationsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceConfigurationsRequest);
            return new SyncInvoker<UpdateInstanceConfigurationsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceConfigurationsResponse>);
        }
        
        /// <summary>
        /// 设置实例秒级监控
        ///
        /// 设置实例秒级监控，包括1秒监控和5秒监控。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceMonitorResponse UpdateInstanceMonitor(UpdateInstanceMonitorRequest updateInstanceMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceMonitorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitor-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceMonitorRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceMonitorResponse>(response);
        }

        public SyncInvoker<UpdateInstanceMonitorResponse> UpdateInstanceMonitorInvoker(UpdateInstanceMonitorRequest updateInstanceMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceMonitorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitor-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceMonitorRequest);
            return new SyncInvoker<UpdateInstanceMonitorResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceMonitorResponse>);
        }
        
        /// <summary>
        /// 更改数据库代理连接池类型
        ///
        /// 更改数据库代理连接池类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProxyConnectionPoolTypeResponse UpdateProxyConnectionPoolType(UpdateProxyConnectionPoolTypeRequest updateProxyConnectionPoolTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateProxyConnectionPoolTypeRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", updateProxyConnectionPoolTypeRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/connection-pool-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProxyConnectionPoolTypeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProxyConnectionPoolTypeResponse>(response);
        }

        public SyncInvoker<UpdateProxyConnectionPoolTypeResponse> UpdateProxyConnectionPoolTypeInvoker(UpdateProxyConnectionPoolTypeRequest updateProxyConnectionPoolTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateProxyConnectionPoolTypeRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", updateProxyConnectionPoolTypeRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/connection-pool-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProxyConnectionPoolTypeRequest);
            return new SyncInvoker<UpdateProxyConnectionPoolTypeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProxyConnectionPoolTypeResponse>);
        }
        
        /// <summary>
        /// 修改代理实例参数
        ///
        /// 修改数据库代理参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProxyNewConfigurationsResponse UpdateProxyNewConfigurations(UpdateProxyNewConfigurationsRequest updateProxyNewConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateProxyNewConfigurationsRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", updateProxyNewConfigurationsRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProxyNewConfigurationsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProxyNewConfigurationsResponse>(response);
        }

        public SyncInvoker<UpdateProxyNewConfigurationsResponse> UpdateProxyNewConfigurationsInvoker(UpdateProxyNewConfigurationsRequest updateProxyNewConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateProxyNewConfigurationsRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", updateProxyNewConfigurationsRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProxyNewConfigurationsRequest);
            return new SyncInvoker<UpdateProxyNewConfigurationsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProxyNewConfigurationsResponse>);
        }
        
        /// <summary>
        /// 修改读写分离端口号
        ///
        /// 修改读写分离端口号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProxyPortResponse UpdateProxyPort(UpdateProxyPortRequest updateProxyPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateProxyPortRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", updateProxyPortRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProxyPortRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProxyPortResponse>(response);
        }

        public SyncInvoker<UpdateProxyPortResponse> UpdateProxyPortInvoker(UpdateProxyPortRequest updateProxyPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateProxyPortRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", updateProxyPortRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProxyPortRequest);
            return new SyncInvoker<UpdateProxyPortResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProxyPortResponse>);
        }
        
        /// <summary>
        /// 修改代理会话一致性
        ///
        /// 修改代理会话一致性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProxySessionConsistenceResponse UpdateProxySessionConsistence(UpdateProxySessionConsistenceRequest updateProxySessionConsistenceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateProxySessionConsistenceRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", updateProxySessionConsistenceRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/session-consistence", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProxySessionConsistenceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProxySessionConsistenceResponse>(response);
        }

        public SyncInvoker<UpdateProxySessionConsistenceResponse> UpdateProxySessionConsistenceInvoker(UpdateProxySessionConsistenceRequest updateProxySessionConsistenceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateProxySessionConsistenceRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", updateProxySessionConsistenceRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/session-consistence", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProxySessionConsistenceRequest);
            return new SyncInvoker<UpdateProxySessionConsistenceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProxySessionConsistenceResponse>);
        }
        
        /// <summary>
        /// 设置proxy事务拆分
        ///
        /// 设置proxy事务拆分。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTransactionSplitStatusResponse UpdateTransactionSplitStatus(UpdateTransactionSplitStatusRequest updateTransactionSplitStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateTransactionSplitStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/transaction-split", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTransactionSplitStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateTransactionSplitStatusResponse>(response);
        }

        public SyncInvoker<UpdateTransactionSplitStatusResponse> UpdateTransactionSplitStatusInvoker(UpdateTransactionSplitStatusRequest updateTransactionSplitStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateTransactionSplitStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/transaction-split", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTransactionSplitStatusRequest);
            return new SyncInvoker<UpdateTransactionSplitStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateTransactionSplitStatusResponse>);
        }
        
        /// <summary>
        /// 内核版本升级
        ///
        /// 内核版本升级。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeGaussMySqlInstanceDatabaseResponse UpgradeGaussMySqlInstanceDatabase(UpgradeGaussMySqlInstanceDatabaseRequest upgradeGaussMySqlInstanceDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeGaussMySqlInstanceDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeGaussMySqlInstanceDatabaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpgradeGaussMySqlInstanceDatabaseResponse>(response);
        }

        public SyncInvoker<UpgradeGaussMySqlInstanceDatabaseResponse> UpgradeGaussMySqlInstanceDatabaseInvoker(UpgradeGaussMySqlInstanceDatabaseRequest upgradeGaussMySqlInstanceDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeGaussMySqlInstanceDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeGaussMySqlInstanceDatabaseRequest);
            return new SyncInvoker<UpgradeGaussMySqlInstanceDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeGaussMySqlInstanceDatabaseResponse>);
        }
        
        /// <summary>
        /// 删除SQL限流规则
        ///
        /// 删除SQL限流规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSqlFilterRuleResponse DeleteSqlFilterRule(DeleteSqlFilterRuleRequest deleteSqlFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteSqlFilterRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteSqlFilterRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSqlFilterRuleResponse>(response);
        }

        public SyncInvoker<DeleteSqlFilterRuleResponse> DeleteSqlFilterRuleInvoker(DeleteSqlFilterRuleRequest deleteSqlFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteSqlFilterRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteSqlFilterRuleRequest);
            return new SyncInvoker<DeleteSqlFilterRuleResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSqlFilterRuleResponse>);
        }
        
        /// <summary>
        /// 设置SQL限流规则
        ///
        /// 设置SQL限流规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetSqlFilterRuleResponse SetSqlFilterRule(SetSqlFilterRuleRequest setSqlFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setSqlFilterRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setSqlFilterRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SetSqlFilterRuleResponse>(response);
        }

        public SyncInvoker<SetSqlFilterRuleResponse> SetSqlFilterRuleInvoker(SetSqlFilterRuleRequest setSqlFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setSqlFilterRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setSqlFilterRuleRequest);
            return new SyncInvoker<SetSqlFilterRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetSqlFilterRuleResponse>);
        }
        
        /// <summary>
        /// 查询SQL限流开关状态
        ///
        /// 查询SQL限流开关状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSqlFilterControlResponse ShowSqlFilterControl(ShowSqlFilterControlRequest showSqlFilterControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSqlFilterControlRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSqlFilterControlRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSqlFilterControlResponse>(response);
        }

        public SyncInvoker<ShowSqlFilterControlResponse> ShowSqlFilterControlInvoker(ShowSqlFilterControlRequest showSqlFilterControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSqlFilterControlRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSqlFilterControlRequest);
            return new SyncInvoker<ShowSqlFilterControlResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSqlFilterControlResponse>);
        }
        
        /// <summary>
        /// 查询SQL限流规则
        ///
        /// 查询SQL限流规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSqlFilterRuleResponse ShowSqlFilterRule(ShowSqlFilterRuleRequest showSqlFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSqlFilterRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSqlFilterRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSqlFilterRuleResponse>(response);
        }

        public SyncInvoker<ShowSqlFilterRuleResponse> ShowSqlFilterRuleInvoker(ShowSqlFilterRuleRequest showSqlFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSqlFilterRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSqlFilterRuleRequest);
            return new SyncInvoker<ShowSqlFilterRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSqlFilterRuleResponse>);
        }
        
        /// <summary>
        /// 开启或者关闭SQL限流
        ///
        /// 开启或者关闭SQL限流。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSqlFilterControlResponse UpdateSqlFilterControl(UpdateSqlFilterControlRequest updateSqlFilterControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateSqlFilterControlRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSqlFilterControlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateSqlFilterControlResponse>(response);
        }

        public SyncInvoker<UpdateSqlFilterControlResponse> UpdateSqlFilterControlInvoker(UpdateSqlFilterControlRequest updateSqlFilterControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateSqlFilterControlRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSqlFilterControlRequest);
            return new SyncInvoker<UpdateSqlFilterControlResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateSqlFilterControlResponse>);
        }
        
    }
}