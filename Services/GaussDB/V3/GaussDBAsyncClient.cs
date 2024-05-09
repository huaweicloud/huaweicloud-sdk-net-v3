using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.GaussDB.V3.Model;

namespace HuaweiCloud.SDK.GaussDB.V3
{
    public partial class GaussDBAsyncClient : Client
    {
        public static ClientBuilder<GaussDBAsyncClient> NewBuilder()
        {
            return new ClientBuilder<GaussDBAsyncClient>();
        }

        
        /// <summary>
        /// 授予数据库用户数据库权限
        ///
        /// 授予云数据库 GaussDB(for MySQL)实例数据库用户数据库权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddDatabasePermissionResponse> AddDatabasePermissionAsync(AddDatabasePermissionRequest addDatabasePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addDatabasePermissionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addDatabasePermissionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddDatabasePermissionResponse>(response);
        }

        public AsyncInvoker<AddDatabasePermissionResponse> AddDatabasePermissionAsyncInvoker(AddDatabasePermissionRequest addDatabasePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", addDatabasePermissionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addDatabasePermissionRequest);
            return new AsyncInvoker<AddDatabasePermissionResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDatabasePermissionResponse>);
        }
        
        /// <summary>
        /// 批量添加或删除标签
        ///
        /// 批量添加或删除指定实例的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchTagActionResponse> BatchTagActionAsync(BatchTagActionRequest batchTagActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchTagActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchTagActionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchTagActionResponse>(response);
        }

        public AsyncInvoker<BatchTagActionResponse> BatchTagActionAsyncInvoker(BatchTagActionRequest batchTagActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchTagActionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchTagActionRequest);
            return new AsyncInvoker<BatchTagActionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchTagActionResponse>);
        }
        
        /// <summary>
        /// 解绑弹性公网IP
        ///
        /// 实例解绑弹性公网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelGaussMySqlInstanceEipResponse> CancelGaussMySqlInstanceEipAsync(CancelGaussMySqlInstanceEipRequest cancelGaussMySqlInstanceEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", cancelGaussMySqlInstanceEipRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ips/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelGaussMySqlInstanceEipRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<CancelGaussMySqlInstanceEipResponse>(response);
        }

        public AsyncInvoker<CancelGaussMySqlInstanceEipResponse> CancelGaussMySqlInstanceEipAsyncInvoker(CancelGaussMySqlInstanceEipRequest cancelGaussMySqlInstanceEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", cancelGaussMySqlInstanceEipRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ips/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelGaussMySqlInstanceEipRequest);
            return new AsyncInvoker<CancelGaussMySqlInstanceEipResponse>(this, "PUT", request, JsonUtils.DeSerialize<CancelGaussMySqlInstanceEipResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/scheduled-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelScheduleTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<CancelScheduleTaskResponse>(response);
        }

        public AsyncInvoker<CancelScheduleTaskResponse> CancelScheduleTaskAsyncInvoker(CancelScheduleTaskRequest cancelScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/scheduled-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelScheduleTaskRequest);
            return new AsyncInvoker<CancelScheduleTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<CancelScheduleTaskResponse>);
        }
        
        /// <summary>
        /// 变更实例规格
        ///
        /// 变更数据库实例的规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeGaussMySqlInstanceSpecificationResponse> ChangeGaussMySqlInstanceSpecificationAsync(ChangeGaussMySqlInstanceSpecificationRequest changeGaussMySqlInstanceSpecificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeGaussMySqlInstanceSpecificationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeGaussMySqlInstanceSpecificationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeGaussMySqlInstanceSpecificationResponse>(response);
        }

        public AsyncInvoker<ChangeGaussMySqlInstanceSpecificationResponse> ChangeGaussMySqlInstanceSpecificationAsyncInvoker(ChangeGaussMySqlInstanceSpecificationRequest changeGaussMySqlInstanceSpecificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeGaussMySqlInstanceSpecificationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeGaussMySqlInstanceSpecificationRequest);
            return new AsyncInvoker<ChangeGaussMySqlInstanceSpecificationResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeGaussMySqlInstanceSpecificationResponse>);
        }
        
        /// <summary>
        /// 数据库代理规格变更
        ///
        /// 数据库代理规格变更。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeGaussMySqlProxySpecificationResponse> ChangeGaussMySqlProxySpecificationAsync(ChangeGaussMySqlProxySpecificationRequest changeGaussMySqlProxySpecificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeGaussMySqlProxySpecificationRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", changeGaussMySqlProxySpecificationRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/flavor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeGaussMySqlProxySpecificationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ChangeGaussMySqlProxySpecificationResponse>(response);
        }

        public AsyncInvoker<ChangeGaussMySqlProxySpecificationResponse> ChangeGaussMySqlProxySpecificationAsyncInvoker(ChangeGaussMySqlProxySpecificationRequest changeGaussMySqlProxySpecificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeGaussMySqlProxySpecificationRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", changeGaussMySqlProxySpecificationRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/flavor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeGaussMySqlProxySpecificationRequest);
            return new AsyncInvoker<ChangeGaussMySqlProxySpecificationResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeGaussMySqlProxySpecificationResponse>);
        }
        
        /// <summary>
        /// 资源预校验
        ///
        /// 资源预校验。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckResourceResponse> CheckResourceAsync(CheckResourceRequest checkResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/resource-check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkResourceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CheckResourceResponse>(response);
        }

        public AsyncInvoker<CheckResourceResponse> CheckResourceAsyncInvoker(CheckResourceRequest checkResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/resource-check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkResourceRequest);
            return new AsyncInvoker<CheckResourceResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckResourceResponse>);
        }
        
        /// <summary>
        /// 复制参数组
        ///
        /// 复制参数组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CopyConfigurationsResponse> CopyConfigurationsAsync(CopyConfigurationsRequest copyConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", copyConfigurationsRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyConfigurationsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CopyConfigurationsResponse>(response);
        }

        public AsyncInvoker<CopyConfigurationsResponse> CopyConfigurationsAsyncInvoker(CopyConfigurationsRequest copyConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", copyConfigurationsRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyConfigurationsRequest);
            return new AsyncInvoker<CopyConfigurationsResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyConfigurationsResponse>);
        }
        
        /// <summary>
        /// 复制实例参数组
        ///
        /// 复制实例参数组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CopyInstanceConfigurationsResponse> CopyInstanceConfigurationsAsync(CopyInstanceConfigurationsRequest copyInstanceConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", copyInstanceConfigurationsRequest.InstanceId.ToString());
            urlParam.Add("configuration_id", copyInstanceConfigurationsRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations/{configuration_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyInstanceConfigurationsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CopyInstanceConfigurationsResponse>(response);
        }

        public AsyncInvoker<CopyInstanceConfigurationsResponse> CopyInstanceConfigurationsAsyncInvoker(CopyInstanceConfigurationsRequest copyInstanceConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", copyInstanceConfigurationsRequest.InstanceId.ToString());
            urlParam.Add("configuration_id", copyInstanceConfigurationsRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations/{configuration_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyInstanceConfigurationsRequest);
            return new AsyncInvoker<CopyInstanceConfigurationsResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyInstanceConfigurationsResponse>);
        }
        
        /// <summary>
        /// 设置访问控制规则
        ///
        /// 设置访问控制规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAccessControlResponse> CreateAccessControlAsync(CreateAccessControlRequest createAccessControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createAccessControlRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", createAccessControlRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/access-control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAccessControlRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAccessControlResponse>(response);
        }

        public AsyncInvoker<CreateAccessControlResponse> CreateAccessControlAsyncInvoker(CreateAccessControlRequest createAccessControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createAccessControlRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", createAccessControlRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/access-control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAccessControlRequest);
            return new AsyncInvoker<CreateAccessControlResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAccessControlResponse>);
        }
        
        /// <summary>
        /// 创建手动备份
        ///
        /// 创建手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGaussMySqlBackupResponse> CreateGaussMySqlBackupAsync(CreateGaussMySqlBackupRequest createGaussMySqlBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlBackupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGaussMySqlBackupResponse>(response);
        }

        public AsyncInvoker<CreateGaussMySqlBackupResponse> CreateGaussMySqlBackupAsyncInvoker(CreateGaussMySqlBackupRequest createGaussMySqlBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlBackupRequest);
            return new AsyncInvoker<CreateGaussMySqlBackupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGaussMySqlBackupResponse>);
        }
        
        /// <summary>
        /// 创建参数模板
        ///
        /// 创建参数模板信息，包含参数模板名称、描述、数据库版本信息、参数值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGaussMySqlConfigurationResponse> CreateGaussMySqlConfigurationAsync(CreateGaussMySqlConfigurationRequest createGaussMySqlConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlConfigurationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGaussMySqlConfigurationResponse>(response);
        }

        public AsyncInvoker<CreateGaussMySqlConfigurationResponse> CreateGaussMySqlConfigurationAsyncInvoker(CreateGaussMySqlConfigurationRequest createGaussMySqlConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlConfigurationRequest);
            return new AsyncInvoker<CreateGaussMySqlConfigurationResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGaussMySqlConfigurationResponse>);
        }
        
        /// <summary>
        /// 创建数据库
        ///
        /// 创建云数据库 GaussDB(for MySQL)实例数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGaussMySqlDatabaseResponse> CreateGaussMySqlDatabaseAsync(CreateGaussMySqlDatabaseRequest createGaussMySqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGaussMySqlDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGaussMySqlDatabaseResponse>(response);
        }

        public AsyncInvoker<CreateGaussMySqlDatabaseResponse> CreateGaussMySqlDatabaseAsyncInvoker(CreateGaussMySqlDatabaseRequest createGaussMySqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGaussMySqlDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlDatabaseRequest);
            return new AsyncInvoker<CreateGaussMySqlDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGaussMySqlDatabaseResponse>);
        }
        
        /// <summary>
        /// 创建数据库用户
        ///
        /// 创建云数据库GaussDB(for MySQL)实例数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGaussMySqlDatabaseUserResponse> CreateGaussMySqlDatabaseUserAsync(CreateGaussMySqlDatabaseUserRequest createGaussMySqlDatabaseUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGaussMySqlDatabaseUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlDatabaseUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGaussMySqlDatabaseUserResponse>(response);
        }

        public AsyncInvoker<CreateGaussMySqlDatabaseUserResponse> CreateGaussMySqlDatabaseUserAsyncInvoker(CreateGaussMySqlDatabaseUserRequest createGaussMySqlDatabaseUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGaussMySqlDatabaseUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlDatabaseUserRequest);
            return new AsyncInvoker<CreateGaussMySqlDatabaseUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGaussMySqlDatabaseUserResponse>);
        }
        
        /// <summary>
        /// 创建数据库实例
        ///
        /// 创建云数据库GaussDB(for MySQL)实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGaussMySqlInstanceResponse> CreateGaussMySqlInstanceAsync(CreateGaussMySqlInstanceRequest createGaussMySqlInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGaussMySqlInstanceResponse>(response);
        }

        public AsyncInvoker<CreateGaussMySqlInstanceResponse> CreateGaussMySqlInstanceAsyncInvoker(CreateGaussMySqlInstanceRequest createGaussMySqlInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlInstanceRequest);
            return new AsyncInvoker<CreateGaussMySqlInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGaussMySqlInstanceResponse>);
        }
        
        /// <summary>
        /// 开启数据库代理
        ///
        /// 开启数据库代理，只支持ELB模式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGaussMySqlProxyResponse> CreateGaussMySqlProxyAsync(CreateGaussMySqlProxyRequest createGaussMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGaussMySqlProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlProxyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGaussMySqlProxyResponse>(response);
        }

        public AsyncInvoker<CreateGaussMySqlProxyResponse> CreateGaussMySqlProxyAsyncInvoker(CreateGaussMySqlProxyRequest createGaussMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGaussMySqlProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlProxyRequest);
            return new AsyncInvoker<CreateGaussMySqlProxyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGaussMySqlProxyResponse>);
        }
        
        /// <summary>
        /// 创建只读节点
        ///
        /// 创建只读节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGaussMySqlReadonlyNodeResponse> CreateGaussMySqlReadonlyNodeAsync(CreateGaussMySqlReadonlyNodeRequest createGaussMySqlReadonlyNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGaussMySqlReadonlyNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/enlarge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlReadonlyNodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGaussMySqlReadonlyNodeResponse>(response);
        }

        public AsyncInvoker<CreateGaussMySqlReadonlyNodeResponse> CreateGaussMySqlReadonlyNodeAsyncInvoker(CreateGaussMySqlReadonlyNodeRequest createGaussMySqlReadonlyNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGaussMySqlReadonlyNodeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/enlarge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMySqlReadonlyNodeRequest);
            return new AsyncInvoker<CreateGaussMySqlReadonlyNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGaussMySqlReadonlyNodeResponse>);
        }
        
        /// <summary>
        /// 申请内网域名
        ///
        /// 申请内网域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGaussMysqlDnsResponse> CreateGaussMysqlDnsAsync(CreateGaussMysqlDnsRequest createGaussMysqlDnsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGaussMysqlDnsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMysqlDnsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGaussMysqlDnsResponse>(response);
        }

        public AsyncInvoker<CreateGaussMysqlDnsResponse> CreateGaussMysqlDnsAsyncInvoker(CreateGaussMysqlDnsRequest createGaussMysqlDnsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGaussMysqlDnsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGaussMysqlDnsRequest);
            return new AsyncInvoker<CreateGaussMysqlDnsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGaussMysqlDnsResponse>);
        }
        
        /// <summary>
        /// 表级时间点恢复
        ///
        /// 表级时间点恢复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRestoreTablesResponse> CreateRestoreTablesAsync(CreateRestoreTablesRequest createRestoreTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createRestoreTablesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/restore/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRestoreTablesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRestoreTablesResponse>(response);
        }

        public AsyncInvoker<CreateRestoreTablesResponse> CreateRestoreTablesAsyncInvoker(CreateRestoreTablesRequest createRestoreTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createRestoreTablesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/restore/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRestoreTablesRequest);
            return new AsyncInvoker<CreateRestoreTablesResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRestoreTablesResponse>);
        }
        
        /// <summary>
        /// 删除数据库用户的数据库权限
        ///
        /// 删除云数据库 GaussDB(for MySQL)实例数据库用户的数据库权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDatabasePermissionResponse> DeleteDatabasePermissionAsync(DeleteDatabasePermissionRequest deleteDatabasePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabasePermissionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteDatabasePermissionRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDatabasePermissionResponse>(response);
        }

        public AsyncInvoker<DeleteDatabasePermissionResponse> DeleteDatabasePermissionAsyncInvoker(DeleteDatabasePermissionRequest deleteDatabasePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabasePermissionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/privilege", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteDatabasePermissionRequest);
            return new AsyncInvoker<DeleteDatabasePermissionResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDatabasePermissionResponse>);
        }
        
        /// <summary>
        /// 删除手动备份
        ///
        /// 删除手动备份。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGaussMySqlBackupResponse> DeleteGaussMySqlBackupAsync(DeleteGaussMySqlBackupRequest deleteGaussMySqlBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteGaussMySqlBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGaussMySqlBackupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlBackupResponse>(response);
        }

        public AsyncInvoker<DeleteGaussMySqlBackupResponse> DeleteGaussMySqlBackupAsyncInvoker(DeleteGaussMySqlBackupRequest deleteGaussMySqlBackupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id", deleteGaussMySqlBackupRequest.BackupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGaussMySqlBackupRequest);
            return new AsyncInvoker<DeleteGaussMySqlBackupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteGaussMySqlBackupResponse>);
        }
        
        /// <summary>
        /// 删除参数模板
        ///
        /// 删除指定参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGaussMySqlConfigurationResponse> DeleteGaussMySqlConfigurationAsync(DeleteGaussMySqlConfigurationRequest deleteGaussMySqlConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", deleteGaussMySqlConfigurationRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGaussMySqlConfigurationRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlConfigurationResponse>(response);
        }

        public AsyncInvoker<DeleteGaussMySqlConfigurationResponse> DeleteGaussMySqlConfigurationAsyncInvoker(DeleteGaussMySqlConfigurationRequest deleteGaussMySqlConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", deleteGaussMySqlConfigurationRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGaussMySqlConfigurationRequest);
            return new AsyncInvoker<DeleteGaussMySqlConfigurationResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteGaussMySqlConfigurationResponse>);
        }
        
        /// <summary>
        /// 删除数据库
        ///
        /// 删除云数据库 GaussDB(for MySQL)实例数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGaussMySqlDatabaseResponse> DeleteGaussMySqlDatabaseAsync(DeleteGaussMySqlDatabaseRequest deleteGaussMySqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGaussMySqlDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteGaussMySqlDatabaseRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlDatabaseResponse>(response);
        }

        public AsyncInvoker<DeleteGaussMySqlDatabaseResponse> DeleteGaussMySqlDatabaseAsyncInvoker(DeleteGaussMySqlDatabaseRequest deleteGaussMySqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGaussMySqlDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteGaussMySqlDatabaseRequest);
            return new AsyncInvoker<DeleteGaussMySqlDatabaseResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteGaussMySqlDatabaseResponse>);
        }
        
        /// <summary>
        /// 删除数据库用户
        ///
        /// 删除云数据库 GaussDB(for MySQL)实例数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGaussMySqlDatabaseUserResponse> DeleteGaussMySqlDatabaseUserAsync(DeleteGaussMySqlDatabaseUserRequest deleteGaussMySqlDatabaseUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGaussMySqlDatabaseUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteGaussMySqlDatabaseUserRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlDatabaseUserResponse>(response);
        }

        public AsyncInvoker<DeleteGaussMySqlDatabaseUserResponse> DeleteGaussMySqlDatabaseUserAsyncInvoker(DeleteGaussMySqlDatabaseUserRequest deleteGaussMySqlDatabaseUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGaussMySqlDatabaseUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteGaussMySqlDatabaseUserRequest);
            return new AsyncInvoker<DeleteGaussMySqlDatabaseUserResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteGaussMySqlDatabaseUserResponse>);
        }
        
        /// <summary>
        /// 删除/退订数据库实例
        ///
        /// 删除/退订数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGaussMySqlInstanceResponse> DeleteGaussMySqlInstanceAsync(DeleteGaussMySqlInstanceRequest deleteGaussMySqlInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGaussMySqlInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGaussMySqlInstanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlInstanceResponse>(response);
        }

        public AsyncInvoker<DeleteGaussMySqlInstanceResponse> DeleteGaussMySqlInstanceAsyncInvoker(DeleteGaussMySqlInstanceRequest deleteGaussMySqlInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGaussMySqlInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGaussMySqlInstanceRequest);
            return new AsyncInvoker<DeleteGaussMySqlInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteGaussMySqlInstanceResponse>);
        }
        
        /// <summary>
        /// 关闭数据库代理
        ///
        /// 关闭数据库代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGaussMySqlProxyResponse> DeleteGaussMySqlProxyAsync(DeleteGaussMySqlProxyRequest deleteGaussMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGaussMySqlProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteGaussMySqlProxyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlProxyResponse>(response);
        }

        public AsyncInvoker<DeleteGaussMySqlProxyResponse> DeleteGaussMySqlProxyAsyncInvoker(DeleteGaussMySqlProxyRequest deleteGaussMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGaussMySqlProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteGaussMySqlProxyRequest);
            return new AsyncInvoker<DeleteGaussMySqlProxyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteGaussMySqlProxyResponse>);
        }
        
        /// <summary>
        /// 删除/退订只读节点
        ///
        /// 删除/退订实例的只读节点。多可用区模式删除/退订只读节点时，要保证删除/退订后，剩余的只读节点和主节点在不同的可用区中，否则无法删除/退订该只读节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGaussMySqlReadonlyNodeResponse> DeleteGaussMySqlReadonlyNodeAsync(DeleteGaussMySqlReadonlyNodeRequest deleteGaussMySqlReadonlyNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGaussMySqlReadonlyNodeRequest.InstanceId.ToString());
            urlParam.Add("node_id", deleteGaussMySqlReadonlyNodeRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGaussMySqlReadonlyNodeRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteGaussMySqlReadonlyNodeResponse>(response);
        }

        public AsyncInvoker<DeleteGaussMySqlReadonlyNodeResponse> DeleteGaussMySqlReadonlyNodeAsyncInvoker(DeleteGaussMySqlReadonlyNodeRequest deleteGaussMySqlReadonlyNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteGaussMySqlReadonlyNodeRequest.InstanceId.ToString());
            urlParam.Add("node_id", deleteGaussMySqlReadonlyNodeRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGaussMySqlReadonlyNodeRequest);
            return new AsyncInvoker<DeleteGaussMySqlReadonlyNodeResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteGaussMySqlReadonlyNodeResponse>);
        }
        
        /// <summary>
        /// 删除定时任务
        ///
        /// 删除定时任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteScheduleTasKResponse> DeleteScheduleTasKAsync(DeleteScheduleTasKRequest deleteScheduleTasKRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteScheduleTasKRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/scheduled-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteScheduleTasKRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteScheduleTasKResponse>(response);
        }

        public AsyncInvoker<DeleteScheduleTasKResponse> DeleteScheduleTasKAsyncInvoker(DeleteScheduleTasKRequest deleteScheduleTasKRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteScheduleTasKRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/scheduled-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteScheduleTasKRequest);
            return new AsyncInvoker<DeleteScheduleTasKResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteScheduleTasKResponse>);
        }
        
        /// <summary>
        /// 删除指定任务记录
        ///
        /// 删除指定任务记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTaskRecordResponse> DeleteTaskRecordAsync(DeleteTaskRecordRequest deleteTaskRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteTaskRecordRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTaskRecordRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTaskRecordResponse>(response);
        }

        public AsyncInvoker<DeleteTaskRecordResponse> DeleteTaskRecordAsyncInvoker(DeleteTaskRecordRequest deleteTaskRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteTaskRecordRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTaskRecordRequest);
            return new AsyncInvoker<DeleteTaskRecordResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTaskRecordResponse>);
        }
        
        /// <summary>
        /// 查询实例是否开启备份加密功能
        ///
        /// 查询实例是否开启备份加密功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DescribeBackupEncryptStatusResponse> DescribeBackupEncryptStatusAsync(DescribeBackupEncryptStatusRequest describeBackupEncryptStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describeBackupEncryptStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/encryption", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeBackupEncryptStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DescribeBackupEncryptStatusResponse>(response);
        }

        public AsyncInvoker<DescribeBackupEncryptStatusResponse> DescribeBackupEncryptStatusAsyncInvoker(DescribeBackupEncryptStatusRequest describeBackupEncryptStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describeBackupEncryptStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/encryption", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeBackupEncryptStatusRequest);
            return new AsyncInvoker<DescribeBackupEncryptStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeBackupEncryptStatusResponse>);
        }
        
        /// <summary>
        /// 包周期存储扩容
        ///
        /// 包周期存储扩容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExpandGaussMySqlInstanceVolumeResponse> ExpandGaussMySqlInstanceVolumeAsync(ExpandGaussMySqlInstanceVolumeRequest expandGaussMySqlInstanceVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", expandGaussMySqlInstanceVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/volume/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", expandGaussMySqlInstanceVolumeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExpandGaussMySqlInstanceVolumeResponse>(response);
        }

        public AsyncInvoker<ExpandGaussMySqlInstanceVolumeResponse> ExpandGaussMySqlInstanceVolumeAsyncInvoker(ExpandGaussMySqlInstanceVolumeRequest expandGaussMySqlInstanceVolumeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", expandGaussMySqlInstanceVolumeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/volume/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", expandGaussMySqlInstanceVolumeRequest);
            return new AsyncInvoker<ExpandGaussMySqlInstanceVolumeResponse>(this, "POST", request, JsonUtils.DeSerialize<ExpandGaussMySqlInstanceVolumeResponse>);
        }
        
        /// <summary>
        /// 扩容数据库代理节点的数量
        ///
        /// 扩容数据库代理节点的数量。
        /// DeC专属云账号暂不支持数据库代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExpandGaussMySqlProxyResponse> ExpandGaussMySqlProxyAsync(ExpandGaussMySqlProxyRequest expandGaussMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", expandGaussMySqlProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/enlarge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", expandGaussMySqlProxyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExpandGaussMySqlProxyResponse>(response);
        }

        public AsyncInvoker<ExpandGaussMySqlProxyResponse> ExpandGaussMySqlProxyAsyncInvoker(ExpandGaussMySqlProxyRequest expandGaussMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", expandGaussMySqlProxyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/enlarge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", expandGaussMySqlProxyRequest);
            return new AsyncInvoker<ExpandGaussMySqlProxyResponse>(this, "POST", request, JsonUtils.DeSerialize<ExpandGaussMySqlProxyResponse>);
        }
        
        /// <summary>
        /// 手动主备倒换
        ///
        /// 用户手动进行主备倒换。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<InvokeGaussMySqlInstanceSwitchOverResponse> InvokeGaussMySqlInstanceSwitchOverAsync(InvokeGaussMySqlInstanceSwitchOverRequest invokeGaussMySqlInstanceSwitchOverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", invokeGaussMySqlInstanceSwitchOverRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", invokeGaussMySqlInstanceSwitchOverRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<InvokeGaussMySqlInstanceSwitchOverResponse>(response);
        }

        public AsyncInvoker<InvokeGaussMySqlInstanceSwitchOverResponse> InvokeGaussMySqlInstanceSwitchOverAsyncInvoker(InvokeGaussMySqlInstanceSwitchOverRequest invokeGaussMySqlInstanceSwitchOverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", invokeGaussMySqlInstanceSwitchOverRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", invokeGaussMySqlInstanceSwitchOverRequest);
            return new AsyncInvoker<InvokeGaussMySqlInstanceSwitchOverResponse>(this, "PUT", request, JsonUtils.DeSerialize<InvokeGaussMySqlInstanceSwitchOverResponse>);
        }
        
        /// <summary>
        /// 获取全量SQL的临时下载链接
        ///
        /// 获取全量SQL的临时下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditLogDownloadLinkResponse> ListAuditLogDownloadLinkAsync(ListAuditLogDownloadLinkRequest listAuditLogDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditLogDownloadLinkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/auditlog/download-link", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditLogDownloadLinkRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditLogDownloadLinkResponse>(response);
        }

        public AsyncInvoker<ListAuditLogDownloadLinkResponse> ListAuditLogDownloadLinkAsyncInvoker(ListAuditLogDownloadLinkRequest listAuditLogDownloadLinkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAuditLogDownloadLinkRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/auditlog/download-link", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditLogDownloadLinkRequest);
            return new AsyncInvoker<ListAuditLogDownloadLinkResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditLogDownloadLinkResponse>);
        }
        
        /// <summary>
        /// 对比参数模板
        ///
        /// 比较两个参数模板之间的差异。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConfigurationsDifferencesResponse> ListConfigurationsDifferencesAsync(ListConfigurationsDifferencesRequest listConfigurationsDifferencesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/comparison", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listConfigurationsDifferencesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListConfigurationsDifferencesResponse>(response);
        }

        public AsyncInvoker<ListConfigurationsDifferencesResponse> ListConfigurationsDifferencesAsyncInvoker(ListConfigurationsDifferencesRequest listConfigurationsDifferencesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/comparison", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listConfigurationsDifferencesRequest);
            return new AsyncInvoker<ListConfigurationsDifferencesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListConfigurationsDifferencesResponse>);
        }
        
        /// <summary>
        /// 查询可应用的实例列表
        ///
        /// 查询指定参数模板可被应用的实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConfigurationsInstancesResponse> ListConfigurationsInstancesAsync(ListConfigurationsInstancesRequest listConfigurationsInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", listConfigurationsInstancesRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}/applicable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationsInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListConfigurationsInstancesResponse>(response);
        }

        public AsyncInvoker<ListConfigurationsInstancesResponse> ListConfigurationsInstancesAsyncInvoker(ListConfigurationsInstancesRequest listConfigurationsInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", listConfigurationsInstancesRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}/applicable-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigurationsInstancesRequest);
            return new AsyncInvoker<ListConfigurationsInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigurationsInstancesResponse>);
        }
        
        /// <summary>
        /// 查询企业项目
        ///
        /// 查询企业项目。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEnterpriseProjectsResponse> ListEnterpriseProjectsAsync(ListEnterpriseProjectsRequest listEnterpriseProjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseProjectsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEnterpriseProjectsResponse>(response);
        }

        public AsyncInvoker<ListEnterpriseProjectsResponse> ListEnterpriseProjectsAsyncInvoker(ListEnterpriseProjectsRequest listEnterpriseProjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseProjectsRequest);
            return new AsyncInvoker<ListEnterpriseProjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEnterpriseProjectsResponse>);
        }
        
        /// <summary>
        /// 查询参数模板
        ///
        /// 获取参数模板列表，包括所有数据库的默认参数模板和用户创建的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGaussMySqlConfigurationsResponse> ListGaussMySqlConfigurationsAsync(ListGaussMySqlConfigurationsRequest listGaussMySqlConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlConfigurationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGaussMySqlConfigurationsResponse>(response);
        }

        public AsyncInvoker<ListGaussMySqlConfigurationsResponse> ListGaussMySqlConfigurationsAsyncInvoker(ListGaussMySqlConfigurationsRequest listGaussMySqlConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlConfigurationsRequest);
            return new AsyncInvoker<ListGaussMySqlConfigurationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGaussMySqlConfigurationsResponse>);
        }
        
        /// <summary>
        /// 查询数据库列表
        ///
        /// 查询 GaussDB(for MySQL)实例数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGaussMySqlDatabaseResponse> ListGaussMySqlDatabaseAsync(ListGaussMySqlDatabaseRequest listGaussMySqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listGaussMySqlDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlDatabaseRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGaussMySqlDatabaseResponse>(response);
        }

        public AsyncInvoker<ListGaussMySqlDatabaseResponse> ListGaussMySqlDatabaseAsyncInvoker(ListGaussMySqlDatabaseRequest listGaussMySqlDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listGaussMySqlDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlDatabaseRequest);
            return new AsyncInvoker<ListGaussMySqlDatabaseResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGaussMySqlDatabaseResponse>);
        }
        
        /// <summary>
        /// 查询数据库可用字符集
        ///
        /// 查询云数据库 GaussDB(for MySQL)实例数据库可用字符集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGaussMySqlDatabaseCharsetsResponse> ListGaussMySqlDatabaseCharsetsAsync(ListGaussMySqlDatabaseCharsetsRequest listGaussMySqlDatabaseCharsetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listGaussMySqlDatabaseCharsetsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/charsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlDatabaseCharsetsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGaussMySqlDatabaseCharsetsResponse>(response);
        }

        public AsyncInvoker<ListGaussMySqlDatabaseCharsetsResponse> ListGaussMySqlDatabaseCharsetsAsyncInvoker(ListGaussMySqlDatabaseCharsetsRequest listGaussMySqlDatabaseCharsetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listGaussMySqlDatabaseCharsetsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/charsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlDatabaseCharsetsRequest);
            return new AsyncInvoker<ListGaussMySqlDatabaseCharsetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGaussMySqlDatabaseCharsetsResponse>);
        }
        
        /// <summary>
        /// 查询数据库用户
        ///
        /// 查询云数据库 GaussDB(for MySQL)实例数据库用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGaussMySqlDatabaseUserResponse> ListGaussMySqlDatabaseUserAsync(ListGaussMySqlDatabaseUserRequest listGaussMySqlDatabaseUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listGaussMySqlDatabaseUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlDatabaseUserRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGaussMySqlDatabaseUserResponse>(response);
        }

        public AsyncInvoker<ListGaussMySqlDatabaseUserResponse> ListGaussMySqlDatabaseUserAsyncInvoker(ListGaussMySqlDatabaseUserRequest listGaussMySqlDatabaseUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listGaussMySqlDatabaseUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlDatabaseUserRequest);
            return new AsyncInvoker<ListGaussMySqlDatabaseUserResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGaussMySqlDatabaseUserResponse>);
        }
        
        /// <summary>
        /// 查询专属资源池列表
        ///
        /// 获取专属资源池列表，包括用户开通的所有专属资源池信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGaussMySqlDedicatedResourcesResponse> ListGaussMySqlDedicatedResourcesAsync(ListGaussMySqlDedicatedResourcesRequest listGaussMySqlDedicatedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dedicated-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlDedicatedResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGaussMySqlDedicatedResourcesResponse>(response);
        }

        public AsyncInvoker<ListGaussMySqlDedicatedResourcesResponse> ListGaussMySqlDedicatedResourcesAsyncInvoker(ListGaussMySqlDedicatedResourcesRequest listGaussMySqlDedicatedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dedicated-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlDedicatedResourcesRequest);
            return new AsyncInvoker<ListGaussMySqlDedicatedResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGaussMySqlDedicatedResourcesResponse>);
        }
        
        /// <summary>
        /// 批量查询实例详情
        ///
        /// 批量查询实例详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGaussMySqlInstanceDetailInfoResponse> ListGaussMySqlInstanceDetailInfoAsync(ListGaussMySqlInstanceDetailInfoRequest listGaussMySqlInstanceDetailInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlInstanceDetailInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGaussMySqlInstanceDetailInfoResponse>(response);
        }

        public AsyncInvoker<ListGaussMySqlInstanceDetailInfoResponse> ListGaussMySqlInstanceDetailInfoAsyncInvoker(ListGaussMySqlInstanceDetailInfoRequest listGaussMySqlInstanceDetailInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlInstanceDetailInfoRequest);
            return new AsyncInvoker<ListGaussMySqlInstanceDetailInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGaussMySqlInstanceDetailInfoResponse>);
        }
        
        /// <summary>
        /// 批量查询实例详情
        ///
        /// 批量查询实例详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGaussMySqlInstanceDetailInfoUnifyStatusResponse> ListGaussMySqlInstanceDetailInfoUnifyStatusAsync(ListGaussMySqlInstanceDetailInfoUnifyStatusRequest listGaussMySqlInstanceDetailInfoUnifyStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlInstanceDetailInfoUnifyStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGaussMySqlInstanceDetailInfoUnifyStatusResponse>(response);
        }

        public AsyncInvoker<ListGaussMySqlInstanceDetailInfoUnifyStatusResponse> ListGaussMySqlInstanceDetailInfoUnifyStatusAsyncInvoker(ListGaussMySqlInstanceDetailInfoUnifyStatusRequest listGaussMySqlInstanceDetailInfoUnifyStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlInstanceDetailInfoUnifyStatusRequest);
            return new AsyncInvoker<ListGaussMySqlInstanceDetailInfoUnifyStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGaussMySqlInstanceDetailInfoUnifyStatusResponse>);
        }
        
        /// <summary>
        /// 查询实例列表
        ///
        /// 根据指定条件查询实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGaussMySqlInstancesResponse> ListGaussMySqlInstancesAsync(ListGaussMySqlInstancesRequest listGaussMySqlInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGaussMySqlInstancesResponse>(response);
        }

        public AsyncInvoker<ListGaussMySqlInstancesResponse> ListGaussMySqlInstancesAsyncInvoker(ListGaussMySqlInstancesRequest listGaussMySqlInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlInstancesRequest);
            return new AsyncInvoker<ListGaussMySqlInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGaussMySqlInstancesResponse>);
        }
        
        /// <summary>
        /// 查询实例列表
        ///
        /// 根据指定条件查询实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGaussMySqlInstancesUnifyStatusResponse> ListGaussMySqlInstancesUnifyStatusAsync(ListGaussMySqlInstancesUnifyStatusRequest listGaussMySqlInstancesUnifyStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlInstancesUnifyStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGaussMySqlInstancesUnifyStatusResponse>(response);
        }

        public AsyncInvoker<ListGaussMySqlInstancesUnifyStatusResponse> ListGaussMySqlInstancesUnifyStatusAsyncInvoker(ListGaussMySqlInstancesUnifyStatusRequest listGaussMySqlInstancesUnifyStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGaussMySqlInstancesUnifyStatusRequest);
            return new AsyncInvoker<ListGaussMySqlInstancesUnifyStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGaussMySqlInstancesUnifyStatusResponse>);
        }
        
        /// <summary>
        /// 获取即时任务列表
        ///
        /// 获取即时任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListImmediateJobsResponse> ListImmediateJobsAsync(ListImmediateJobsRequest listImmediateJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/immediate-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImmediateJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListImmediateJobsResponse>(response);
        }

        public AsyncInvoker<ListImmediateJobsResponse> ListImmediateJobsAsyncInvoker(ListImmediateJobsRequest listImmediateJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/immediate-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImmediateJobsRequest);
            return new AsyncInvoker<ListImmediateJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListImmediateJobsResponse>);
        }
        
        /// <summary>
        /// 获取指定实例的参数信息
        ///
        /// 获取指定实例的参数信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceConfigurationsResponse> ListInstanceConfigurationsAsync(ListInstanceConfigurationsRequest listInstanceConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceConfigurationsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceConfigurationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceConfigurationsResponse>(response);
        }

        public AsyncInvoker<ListInstanceConfigurationsResponse> ListInstanceConfigurationsAsyncInvoker(ListInstanceConfigurationsRequest listInstanceConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceConfigurationsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceConfigurationsRequest);
            return new AsyncInvoker<ListInstanceConfigurationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceConfigurationsResponse>);
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
        /// 获取错误日志详情列表
        ///
        /// 获取指定实例的错误日志详情列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLtsErrorLogDetailsResponse> ListLtsErrorLogDetailsAsync(ListLtsErrorLogDetailsRequest listLtsErrorLogDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listLtsErrorLogDetailsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/error-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listLtsErrorLogDetailsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListLtsErrorLogDetailsResponse>(response);
        }

        public AsyncInvoker<ListLtsErrorLogDetailsResponse> ListLtsErrorLogDetailsAsyncInvoker(ListLtsErrorLogDetailsRequest listLtsErrorLogDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listLtsErrorLogDetailsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/error-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listLtsErrorLogDetailsRequest);
            return new AsyncInvoker<ListLtsErrorLogDetailsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLtsErrorLogDetailsResponse>);
        }
        
        /// <summary>
        /// 获取慢日志详情列表
        ///
        /// 获取指定实例的慢日志详情列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLtsSlowlogDetailsResponse> ListLtsSlowlogDetailsAsync(ListLtsSlowlogDetailsRequest listLtsSlowlogDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listLtsSlowlogDetailsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listLtsSlowlogDetailsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListLtsSlowlogDetailsResponse>(response);
        }

        public AsyncInvoker<ListLtsSlowlogDetailsResponse> ListLtsSlowlogDetailsAsyncInvoker(ListLtsSlowlogDetailsRequest listLtsSlowlogDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listLtsSlowlogDetailsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listLtsSlowlogDetailsRequest);
            return new AsyncInvoker<ListLtsSlowlogDetailsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLtsSlowlogDetailsResponse>);
        }
        
        /// <summary>
        /// 查询参数修改历史
        ///
        /// 查询参数修改历史。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListModifyHistoryResponse> ListModifyHistoryAsync(ListModifyHistoryRequest listModifyHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", listModifyHistoryRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}/modify-history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listModifyHistoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListModifyHistoryResponse>(response);
        }

        public AsyncInvoker<ListModifyHistoryResponse> ListModifyHistoryAsyncInvoker(ListModifyHistoryRequest listModifyHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", listModifyHistoryRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}/modify-history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listModifyHistoryRequest);
            return new AsyncInvoker<ListModifyHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ListModifyHistoryResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询指定project ID下实例的所有标签集合。
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
        /// 获取定时任务列表
        ///
        /// 获取定时任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScheduleJobsResponse> ListScheduleJobsAsync(ListScheduleJobsRequest listScheduleJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/scheduled-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduleJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListScheduleJobsResponse>(response);
        }

        public AsyncInvoker<ListScheduleJobsResponse> ListScheduleJobsAsyncInvoker(ListScheduleJobsRequest listScheduleJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/scheduled-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduleJobsRequest);
            return new AsyncInvoker<ListScheduleJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScheduleJobsResponse>);
        }
        
        /// <summary>
        /// 打开或关闭备份加密
        ///
        /// 打开或关闭备份加密。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyBackupEncryptStatusResponse> ModifyBackupEncryptStatusAsync(ModifyBackupEncryptStatusRequest modifyBackupEncryptStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyBackupEncryptStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/encryption", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyBackupEncryptStatusRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ModifyBackupEncryptStatusResponse>(response);
        }

        public AsyncInvoker<ModifyBackupEncryptStatusResponse> ModifyBackupEncryptStatusAsyncInvoker(ModifyBackupEncryptStatusRequest modifyBackupEncryptStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyBackupEncryptStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/encryption", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyBackupEncryptStatusRequest);
            return new AsyncInvoker<ModifyBackupEncryptStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<ModifyBackupEncryptStatusResponse>);
        }
        
        /// <summary>
        /// 设置读写分离路由模式
        ///
        /// 设置读写分离路由模式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyGaussMySqlProxyRouteModeResponse> ModifyGaussMySqlProxyRouteModeAsync(ModifyGaussMySqlProxyRouteModeRequest modifyGaussMySqlProxyRouteModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyGaussMySqlProxyRouteModeRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", modifyGaussMySqlProxyRouteModeRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/route-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyGaussMySqlProxyRouteModeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyGaussMySqlProxyRouteModeResponse>(response);
        }

        public AsyncInvoker<ModifyGaussMySqlProxyRouteModeResponse> ModifyGaussMySqlProxyRouteModeAsyncInvoker(ModifyGaussMySqlProxyRouteModeRequest modifyGaussMySqlProxyRouteModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyGaussMySqlProxyRouteModeRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", modifyGaussMySqlProxyRouteModeRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/route-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyGaussMySqlProxyRouteModeRequest);
            return new AsyncInvoker<ModifyGaussMySqlProxyRouteModeResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyGaussMySqlProxyRouteModeResponse>);
        }
        
        /// <summary>
        /// 修改内网域名
        ///
        /// 修改内网域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyGaussMysqlDnsResponse> ModifyGaussMysqlDnsAsync(ModifyGaussMysqlDnsRequest modifyGaussMysqlDnsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyGaussMysqlDnsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyGaussMysqlDnsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyGaussMysqlDnsResponse>(response);
        }

        public AsyncInvoker<ModifyGaussMysqlDnsResponse> ModifyGaussMysqlDnsAsyncInvoker(ModifyGaussMysqlDnsRequest modifyGaussMysqlDnsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyGaussMysqlDnsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyGaussMysqlDnsRequest);
            return new AsyncInvoker<ModifyGaussMysqlDnsResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyGaussMysqlDnsResponse>);
        }
        
        /// <summary>
        /// 修改数据库用户密码
        ///
        /// 修改云数据库 GaussDB(for MySQL)实例数据库用户密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetGaussMySqlDatabasePasswordResponse> ResetGaussMySqlDatabasePasswordAsync(ResetGaussMySqlDatabasePasswordRequest resetGaussMySqlDatabasePasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetGaussMySqlDatabasePasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetGaussMySqlDatabasePasswordRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ResetGaussMySqlDatabasePasswordResponse>(response);
        }

        public AsyncInvoker<ResetGaussMySqlDatabasePasswordResponse> ResetGaussMySqlDatabasePasswordAsyncInvoker(ResetGaussMySqlDatabasePasswordRequest resetGaussMySqlDatabasePasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetGaussMySqlDatabasePasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetGaussMySqlDatabasePasswordRequest);
            return new AsyncInvoker<ResetGaussMySqlDatabasePasswordResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResetGaussMySqlDatabasePasswordResponse>);
        }
        
        /// <summary>
        /// 重置数据库密码
        ///
        /// 重置数据库密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetGaussMySqlPasswordResponse> ResetGaussMySqlPasswordAsync(ResetGaussMySqlPasswordRequest resetGaussMySqlPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetGaussMySqlPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetGaussMySqlPasswordRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ResetGaussMySqlPasswordResponse>(response);
        }

        public AsyncInvoker<ResetGaussMySqlPasswordResponse> ResetGaussMySqlPasswordAsyncInvoker(ResetGaussMySqlPasswordRequest resetGaussMySqlPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetGaussMySqlPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetGaussMySqlPasswordRequest);
            return new AsyncInvoker<ResetGaussMySqlPasswordResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetGaussMySqlPasswordResponse>);
        }
        
        /// <summary>
        /// 重启数据库实例
        ///
        /// 重启数据库实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestartGaussMySqlInstanceResponse> RestartGaussMySqlInstanceAsync(RestartGaussMySqlInstanceRequest restartGaussMySqlInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartGaussMySqlInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restartGaussMySqlInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RestartGaussMySqlInstanceResponse>(response);
        }

        public AsyncInvoker<RestartGaussMySqlInstanceResponse> RestartGaussMySqlInstanceAsyncInvoker(RestartGaussMySqlInstanceRequest restartGaussMySqlInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartGaussMySqlInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restartGaussMySqlInstanceRequest);
            return new AsyncInvoker<RestartGaussMySqlInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestartGaussMySqlInstanceResponse>);
        }
        
        /// <summary>
        /// 节点重启
        ///
        /// 节点重启。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestartGaussMySqlNodeResponse> RestartGaussMySqlNodeAsync(RestartGaussMySqlNodeRequest restartGaussMySqlNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartGaussMySqlNodeRequest.InstanceId.ToString());
            urlParam.Add("node_id", restartGaussMySqlNodeRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restartGaussMySqlNodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RestartGaussMySqlNodeResponse>(response);
        }

        public AsyncInvoker<RestartGaussMySqlNodeResponse> RestartGaussMySqlNodeAsyncInvoker(RestartGaussMySqlNodeRequest restartGaussMySqlNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartGaussMySqlNodeRequest.InstanceId.ToString());
            urlParam.Add("node_id", restartGaussMySqlNodeRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes/{node_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restartGaussMySqlNodeRequest);
            return new AsyncInvoker<RestartGaussMySqlNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<RestartGaussMySqlNodeResponse>);
        }
        
        /// <summary>
        /// 备份恢复到当前实例或已有实例
        ///
        /// 备份恢复到当前实例或已有实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestoreOldInstanceResponse> RestoreOldInstanceAsync(RestoreOldInstanceRequest restoreOldInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreOldInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RestoreOldInstanceResponse>(response);
        }

        public AsyncInvoker<RestoreOldInstanceResponse> RestoreOldInstanceAsyncInvoker(RestoreOldInstanceRequest restoreOldInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreOldInstanceRequest);
            return new AsyncInvoker<RestoreOldInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreOldInstanceResponse>);
        }
        
        /// <summary>
        /// 设置读写分离权重
        ///
        /// 设置读写分离权重。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetGaussMySqlProxyWeightResponse> SetGaussMySqlProxyWeightAsync(SetGaussMySqlProxyWeightRequest setGaussMySqlProxyWeightRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setGaussMySqlProxyWeightRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", setGaussMySqlProxyWeightRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/weight", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setGaussMySqlProxyWeightRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SetGaussMySqlProxyWeightResponse>(response);
        }

        public AsyncInvoker<SetGaussMySqlProxyWeightResponse> SetGaussMySqlProxyWeightAsyncInvoker(SetGaussMySqlProxyWeightRequest setGaussMySqlProxyWeightRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setGaussMySqlProxyWeightRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", setGaussMySqlProxyWeightRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/weight", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setGaussMySqlProxyWeightRequest);
            return new AsyncInvoker<SetGaussMySqlProxyWeightResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetGaussMySqlProxyWeightResponse>);
        }
        
        /// <summary>
        /// 设置租户基于企业项目的资源配额
        ///
        /// 设置指定企业项目的资源配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetGaussMySqlQuotasResponse> SetGaussMySqlQuotasAsync(SetGaussMySqlQuotasRequest setGaussMySqlQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setGaussMySqlQuotasRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetGaussMySqlQuotasResponse>(response);
        }

        public AsyncInvoker<SetGaussMySqlQuotasResponse> SetGaussMySqlQuotasAsyncInvoker(SetGaussMySqlQuotasRequest setGaussMySqlQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setGaussMySqlQuotasRequest);
            return new AsyncInvoker<SetGaussMySqlQuotasResponse>(this, "POST", request, JsonUtils.DeSerialize<SetGaussMySqlQuotasResponse>);
        }
        
        /// <summary>
        /// 查询全量SQL开关状态
        ///
        /// 查询全量SQL开关状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAuditLogResponse> ShowAuditLogAsync(ShowAuditLogRequest showAuditLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAuditLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/audit-log/switch-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditLogRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditLogResponse>(response);
        }

        public AsyncInvoker<ShowAuditLogResponse> ShowAuditLogAsyncInvoker(ShowAuditLogRequest showAuditLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAuditLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/audit-log/switch-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditLogRequest);
            return new AsyncInvoker<ShowAuditLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditLogResponse>);
        }
        
        /// <summary>
        /// 查询自动变配
        ///
        /// 查询自动变配。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutoScalingPolicyResponse> ShowAutoScalingPolicyAsync(ShowAutoScalingPolicyRequest showAutoScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAutoScalingPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auto-scaling/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoScalingPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoScalingPolicyResponse>(response);
        }

        public AsyncInvoker<ShowAutoScalingPolicyResponse> ShowAutoScalingPolicyAsyncInvoker(ShowAutoScalingPolicyRequest showAutoScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showAutoScalingPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auto-scaling/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoScalingPolicyRequest);
            return new AsyncInvoker<ShowAutoScalingPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 查询可恢复时间段
        ///
        /// 查询实例的可恢复时间段。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBackupRestoreTimeResponse> ShowBackupRestoreTimeAsync(ShowBackupRestoreTimeRequest showBackupRestoreTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBackupRestoreTimeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupRestoreTimeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBackupRestoreTimeResponse>(response);
        }

        public AsyncInvoker<ShowBackupRestoreTimeResponse> ShowBackupRestoreTimeAsyncInvoker(ShowBackupRestoreTimeRequest showBackupRestoreTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBackupRestoreTimeRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/restore-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupRestoreTimeRequest);
            return new AsyncInvoker<ShowBackupRestoreTimeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackupRestoreTimeResponse>);
        }
        
        /// <summary>
        /// 查询专属资源信息详情
        ///
        /// 查询专属资源信息详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDedicatedResourceInfoResponse> ShowDedicatedResourceInfoAsync(ShowDedicatedResourceInfoRequest showDedicatedResourceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dedicated_resource_id", showDedicatedResourceInfoRequest.DedicatedResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dedicated-resource/{dedicated_resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDedicatedResourceInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDedicatedResourceInfoResponse>(response);
        }

        public AsyncInvoker<ShowDedicatedResourceInfoResponse> ShowDedicatedResourceInfoAsyncInvoker(ShowDedicatedResourceInfoRequest showDedicatedResourceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dedicated_resource_id", showDedicatedResourceInfoRequest.DedicatedResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/dedicated-resource/{dedicated_resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDedicatedResourceInfoRequest);
            return new AsyncInvoker<ShowDedicatedResourceInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDedicatedResourceInfoResponse>);
        }
        
        /// <summary>
        /// 查询全量备份列表
        ///
        /// 查询全量备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGaussMySqlBackupListResponse> ShowGaussMySqlBackupListAsync(ShowGaussMySqlBackupListRequest showGaussMySqlBackupListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlBackupListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlBackupListResponse>(response);
        }

        public AsyncInvoker<ShowGaussMySqlBackupListResponse> ShowGaussMySqlBackupListAsyncInvoker(ShowGaussMySqlBackupListRequest showGaussMySqlBackupListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlBackupListRequest);
            return new AsyncInvoker<ShowGaussMySqlBackupListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlBackupListResponse>);
        }
        
        /// <summary>
        /// 查询自动备份策略
        ///
        /// 查询自动备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGaussMySqlBackupPolicyResponse> ShowGaussMySqlBackupPolicyAsync(ShowGaussMySqlBackupPolicyRequest showGaussMySqlBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlBackupPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlBackupPolicyResponse>(response);
        }

        public AsyncInvoker<ShowGaussMySqlBackupPolicyResponse> ShowGaussMySqlBackupPolicyAsyncInvoker(ShowGaussMySqlBackupPolicyRequest showGaussMySqlBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlBackupPolicyRequest);
            return new AsyncInvoker<ShowGaussMySqlBackupPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlBackupPolicyResponse>);
        }
        
        /// <summary>
        /// 获取参数模板详情
        ///
        /// 获取指定参数模板的参数信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGaussMySqlConfigurationResponse> ShowGaussMySqlConfigurationAsync(ShowGaussMySqlConfigurationRequest showGaussMySqlConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", showGaussMySqlConfigurationRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlConfigurationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlConfigurationResponse>(response);
        }

        public AsyncInvoker<ShowGaussMySqlConfigurationResponse> ShowGaussMySqlConfigurationAsyncInvoker(ShowGaussMySqlConfigurationRequest showGaussMySqlConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", showGaussMySqlConfigurationRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlConfigurationRequest);
            return new AsyncInvoker<ShowGaussMySqlConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlConfigurationResponse>);
        }
        
        /// <summary>
        /// 查询数据库引擎的版本
        ///
        /// 获取指定数据库引擎对应的数据库版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGaussMySqlEngineVersionResponse> ShowGaussMySqlEngineVersionAsync(ShowGaussMySqlEngineVersionRequest showGaussMySqlEngineVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name", showGaussMySqlEngineVersionRequest.DatabaseName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlEngineVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlEngineVersionResponse>(response);
        }

        public AsyncInvoker<ShowGaussMySqlEngineVersionResponse> ShowGaussMySqlEngineVersionAsyncInvoker(ShowGaussMySqlEngineVersionRequest showGaussMySqlEngineVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name", showGaussMySqlEngineVersionRequest.DatabaseName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/datastores/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlEngineVersionRequest);
            return new AsyncInvoker<ShowGaussMySqlEngineVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlEngineVersionResponse>);
        }
        
        /// <summary>
        /// 查询数据库规格
        ///
        /// 获取指定数据库引擎版本对应的规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGaussMySqlFlavorsResponse> ShowGaussMySqlFlavorsAsync(ShowGaussMySqlFlavorsRequest showGaussMySqlFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name", showGaussMySqlFlavorsRequest.DatabaseName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlFlavorsResponse>(response);
        }

        public AsyncInvoker<ShowGaussMySqlFlavorsResponse> ShowGaussMySqlFlavorsAsyncInvoker(ShowGaussMySqlFlavorsRequest showGaussMySqlFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("database_name", showGaussMySqlFlavorsRequest.DatabaseName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlFlavorsRequest);
            return new AsyncInvoker<ShowGaussMySqlFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询增量备份列表
        ///
        /// 查询增量备份列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGaussMySqlIncrementalBackupListResponse> ShowGaussMySqlIncrementalBackupListAsync(ShowGaussMySqlIncrementalBackupListRequest showGaussMySqlIncrementalBackupListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlIncrementalBackupListRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/incremental-backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlIncrementalBackupListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlIncrementalBackupListResponse>(response);
        }

        public AsyncInvoker<ShowGaussMySqlIncrementalBackupListResponse> ShowGaussMySqlIncrementalBackupListAsyncInvoker(ShowGaussMySqlIncrementalBackupListRequest showGaussMySqlIncrementalBackupListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlIncrementalBackupListRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/incremental-backups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlIncrementalBackupListRequest);
            return new AsyncInvoker<ShowGaussMySqlIncrementalBackupListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlIncrementalBackupListResponse>);
        }
        
        /// <summary>
        /// 查询实例详情信息
        ///
        /// 查询实例详情信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGaussMySqlInstanceInfoResponse> ShowGaussMySqlInstanceInfoAsync(ShowGaussMySqlInstanceInfoRequest showGaussMySqlInstanceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlInstanceInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlInstanceInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlInstanceInfoResponse>(response);
        }

        public AsyncInvoker<ShowGaussMySqlInstanceInfoResponse> ShowGaussMySqlInstanceInfoAsyncInvoker(ShowGaussMySqlInstanceInfoRequest showGaussMySqlInstanceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlInstanceInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlInstanceInfoRequest);
            return new AsyncInvoker<ShowGaussMySqlInstanceInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlInstanceInfoResponse>);
        }
        
        /// <summary>
        /// 查询实例详情信息
        ///
        /// 查询实例详情信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGaussMySqlInstanceInfoUnifyStatusResponse> ShowGaussMySqlInstanceInfoUnifyStatusAsync(ShowGaussMySqlInstanceInfoUnifyStatusRequest showGaussMySqlInstanceInfoUnifyStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlInstanceInfoUnifyStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlInstanceInfoUnifyStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlInstanceInfoUnifyStatusResponse>(response);
        }

        public AsyncInvoker<ShowGaussMySqlInstanceInfoUnifyStatusResponse> ShowGaussMySqlInstanceInfoUnifyStatusAsyncInvoker(ShowGaussMySqlInstanceInfoUnifyStatusRequest showGaussMySqlInstanceInfoUnifyStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlInstanceInfoUnifyStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.1/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlInstanceInfoUnifyStatusRequest);
            return new AsyncInvoker<ShowGaussMySqlInstanceInfoUnifyStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlInstanceInfoUnifyStatusResponse>);
        }
        
        /// <summary>
        /// 获取指定ID的任务信息
        ///
        /// 获取GaussDB(for MySQL)任务中心指定ID的任务信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGaussMySqlJobInfoResponse> ShowGaussMySqlJobInfoAsync(ShowGaussMySqlJobInfoRequest showGaussMySqlJobInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlJobInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlJobInfoResponse>(response);
        }

        public AsyncInvoker<ShowGaussMySqlJobInfoResponse> ShowGaussMySqlJobInfoAsyncInvoker(ShowGaussMySqlJobInfoRequest showGaussMySqlJobInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlJobInfoRequest);
            return new AsyncInvoker<ShowGaussMySqlJobInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlJobInfoResponse>);
        }
        
        /// <summary>
        /// 查询租户的实例配额
        ///
        /// 获取指定租户的资源配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGaussMySqlProjectQuotasResponse> ShowGaussMySqlProjectQuotasAsync(ShowGaussMySqlProjectQuotasRequest showGaussMySqlProjectQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/project-quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlProjectQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlProjectQuotasResponse>(response);
        }

        public AsyncInvoker<ShowGaussMySqlProjectQuotasResponse> ShowGaussMySqlProjectQuotasAsyncInvoker(ShowGaussMySqlProjectQuotasRequest showGaussMySqlProjectQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/project-quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlProjectQuotasRequest);
            return new AsyncInvoker<ShowGaussMySqlProjectQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlProjectQuotasResponse>);
        }
        
        /// <summary>
        /// 查询数据库代理规格信息
        ///
        /// 查询数据库代理规格信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGaussMySqlProxyFlavorsResponse> ShowGaussMySqlProxyFlavorsAsync(ShowGaussMySqlProxyFlavorsRequest showGaussMySqlProxyFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlProxyFlavorsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlProxyFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlProxyFlavorsResponse>(response);
        }

        public AsyncInvoker<ShowGaussMySqlProxyFlavorsResponse> ShowGaussMySqlProxyFlavorsAsyncInvoker(ShowGaussMySqlProxyFlavorsRequest showGaussMySqlProxyFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlProxyFlavorsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlProxyFlavorsRequest);
            return new AsyncInvoker<ShowGaussMySqlProxyFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlProxyFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询数据库代理信息列表
        ///
        /// 查询数据库代理信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGaussMySqlProxyListResponse> ShowGaussMySqlProxyListAsync(ShowGaussMySqlProxyListRequest showGaussMySqlProxyListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlProxyListRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlProxyListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlProxyListResponse>(response);
        }

        public AsyncInvoker<ShowGaussMySqlProxyListResponse> ShowGaussMySqlProxyListAsyncInvoker(ShowGaussMySqlProxyListRequest showGaussMySqlProxyListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGaussMySqlProxyListRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlProxyListRequest);
            return new AsyncInvoker<ShowGaussMySqlProxyListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlProxyListResponse>);
        }
        
        /// <summary>
        /// 查询租户基于企业项目的资源配额
        ///
        /// 获取指定企业项目的资源配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGaussMySqlQuotasResponse> ShowGaussMySqlQuotasAsync(ShowGaussMySqlQuotasRequest showGaussMySqlQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGaussMySqlQuotasResponse>(response);
        }

        public AsyncInvoker<ShowGaussMySqlQuotasResponse> ShowGaussMySqlQuotasAsyncInvoker(ShowGaussMySqlQuotasRequest showGaussMySqlQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGaussMySqlQuotasRequest);
            return new AsyncInvoker<ShowGaussMySqlQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGaussMySqlQuotasResponse>);
        }
        
        /// <summary>
        /// 查询内核版本信息
        ///
        /// 查询内核版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceDatabaseVersionResponse> ShowInstanceDatabaseVersionAsync(ShowInstanceDatabaseVersionRequest showInstanceDatabaseVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceDatabaseVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceDatabaseVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceDatabaseVersionResponse>(response);
        }

        public AsyncInvoker<ShowInstanceDatabaseVersionResponse> ShowInstanceDatabaseVersionAsyncInvoker(ShowInstanceDatabaseVersionRequest showInstanceDatabaseVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceDatabaseVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceDatabaseVersionRequest);
            return new AsyncInvoker<ShowInstanceDatabaseVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceDatabaseVersionResponse>);
        }
        
        /// <summary>
        /// 查询实例秒级监控
        ///
        /// 查询实例秒级监控信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceMonitorExtendResponse> ShowInstanceMonitorExtendAsync(ShowInstanceMonitorExtendRequest showInstanceMonitorExtendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceMonitorExtendRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitor-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceMonitorExtendRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceMonitorExtendResponse>(response);
        }

        public AsyncInvoker<ShowInstanceMonitorExtendResponse> ShowInstanceMonitorExtendAsyncInvoker(ShowInstanceMonitorExtendRequest showInstanceMonitorExtendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceMonitorExtendRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitor-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceMonitorExtendRequest);
            return new AsyncInvoker<ShowInstanceMonitorExtendResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceMonitorExtendResponse>);
        }
        
        /// <summary>
        /// 获取各指标的异常实例数
        ///
        /// 获取各指标的异常实例数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowIntelligentDiagnosisAbnormalCountOfInstancesResponse> ShowIntelligentDiagnosisAbnormalCountOfInstancesAsync(ShowIntelligentDiagnosisAbnormalCountOfInstancesRequest showIntelligentDiagnosisAbnormalCountOfInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/diagnosis-instance-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIntelligentDiagnosisAbnormalCountOfInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowIntelligentDiagnosisAbnormalCountOfInstancesResponse>(response);
        }

        public AsyncInvoker<ShowIntelligentDiagnosisAbnormalCountOfInstancesResponse> ShowIntelligentDiagnosisAbnormalCountOfInstancesAsyncInvoker(ShowIntelligentDiagnosisAbnormalCountOfInstancesRequest showIntelligentDiagnosisAbnormalCountOfInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/diagnosis-instance-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIntelligentDiagnosisAbnormalCountOfInstancesRequest);
            return new AsyncInvoker<ShowIntelligentDiagnosisAbnormalCountOfInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIntelligentDiagnosisAbnormalCountOfInstancesResponse>);
        }
        
        /// <summary>
        /// 获取某个指标的异常实例信息
        ///
        /// 获取某个指标的异常实例信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowIntelligentDiagnosisInstanceInfosPerMetricResponse> ShowIntelligentDiagnosisInstanceInfosPerMetricAsync(ShowIntelligentDiagnosisInstanceInfosPerMetricRequest showIntelligentDiagnosisInstanceInfosPerMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/diagnosis-instance-infos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIntelligentDiagnosisInstanceInfosPerMetricRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowIntelligentDiagnosisInstanceInfosPerMetricResponse>(response);
        }

        public AsyncInvoker<ShowIntelligentDiagnosisInstanceInfosPerMetricResponse> ShowIntelligentDiagnosisInstanceInfosPerMetricAsyncInvoker(ShowIntelligentDiagnosisInstanceInfosPerMetricRequest showIntelligentDiagnosisInstanceInfosPerMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/diagnosis-instance-infos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIntelligentDiagnosisInstanceInfosPerMetricRequest);
            return new AsyncInvoker<ShowIntelligentDiagnosisInstanceInfosPerMetricResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIntelligentDiagnosisInstanceInfosPerMetricResponse>);
        }
        
        /// <summary>
        /// 查询表级时间点恢复可选表
        ///
        /// 查询表级时间点恢复可选表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRestoreTablesResponse> ShowRestoreTablesAsync(ShowRestoreTablesRequest showRestoreTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRestoreTablesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/restore/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRestoreTablesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRestoreTablesResponse>(response);
        }

        public AsyncInvoker<ShowRestoreTablesResponse> ShowRestoreTablesAsyncInvoker(ShowRestoreTablesRequest showRestoreTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRestoreTablesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/restore/tables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRestoreTablesRequest);
            return new AsyncInvoker<ShowRestoreTablesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRestoreTablesResponse>);
        }
        
        /// <summary>
        /// 减少数据库代理节点的数量
        ///
        /// 缩容数据库代理节点的数量。
        /// DeC专属云账号暂不支持数据库代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShrinkGaussMySqlProxyResponse> ShrinkGaussMySqlProxyAsync(ShrinkGaussMySqlProxyRequest shrinkGaussMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", shrinkGaussMySqlProxyRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", shrinkGaussMySqlProxyRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/reduce", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", shrinkGaussMySqlProxyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ShrinkGaussMySqlProxyResponse>(response);
        }

        public AsyncInvoker<ShrinkGaussMySqlProxyResponse> ShrinkGaussMySqlProxyAsyncInvoker(ShrinkGaussMySqlProxyRequest shrinkGaussMySqlProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", shrinkGaussMySqlProxyRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", shrinkGaussMySqlProxyRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/reduce", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", shrinkGaussMySqlProxyRequest);
            return new AsyncInvoker<ShrinkGaussMySqlProxyResponse>(this, "PUT", request, JsonUtils.DeSerialize<ShrinkGaussMySqlProxyResponse>);
        }
        
        /// <summary>
        /// 开启或关闭访问控制
        ///
        /// 开启或关闭访问控制。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchAccessControlResponse> SwitchAccessControlAsync(SwitchAccessControlRequest switchAccessControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchAccessControlRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", switchAccessControlRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/access-control-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAccessControlRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SwitchAccessControlResponse>(response);
        }

        public AsyncInvoker<SwitchAccessControlResponse> SwitchAccessControlAsyncInvoker(SwitchAccessControlRequest switchAccessControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchAccessControlRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", switchAccessControlRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/access-control-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchAccessControlRequest);
            return new AsyncInvoker<SwitchAccessControlResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchAccessControlResponse>);
        }
        
        /// <summary>
        /// 应用参数模板
        ///
        /// 指定实例变更参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchGaussMySqlConfigurationResponse> SwitchGaussMySqlConfigurationAsync(SwitchGaussMySqlConfigurationRequest switchGaussMySqlConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", switchGaussMySqlConfigurationRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchGaussMySqlConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SwitchGaussMySqlConfigurationResponse>(response);
        }

        public AsyncInvoker<SwitchGaussMySqlConfigurationResponse> SwitchGaussMySqlConfigurationAsyncInvoker(SwitchGaussMySqlConfigurationRequest switchGaussMySqlConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", switchGaussMySqlConfigurationRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchGaussMySqlConfigurationRequest);
            return new AsyncInvoker<SwitchGaussMySqlConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchGaussMySqlConfigurationResponse>);
        }
        
        /// <summary>
        /// 开关SSL
        ///
        /// 为实例设置SSL数据加密。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchGaussMySqlInstanceSslResponse> SwitchGaussMySqlInstanceSslAsync(SwitchGaussMySqlInstanceSslRequest switchGaussMySqlInstanceSslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchGaussMySqlInstanceSslRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-option", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchGaussMySqlInstanceSslRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SwitchGaussMySqlInstanceSslResponse>(response);
        }

        public AsyncInvoker<SwitchGaussMySqlInstanceSslResponse> SwitchGaussMySqlInstanceSslAsyncInvoker(SwitchGaussMySqlInstanceSslRequest switchGaussMySqlInstanceSslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchGaussMySqlInstanceSslRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ssl-option", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchGaussMySqlInstanceSslRequest);
            return new AsyncInvoker<SwitchGaussMySqlInstanceSslResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchGaussMySqlInstanceSslResponse>);
        }
        
        /// <summary>
        /// 开关数据库代理SSL
        ///
        /// 为数据库代理设置SSL数据加密。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchGaussMySqlProxySslResponse> SwitchGaussMySqlProxySslAsync(SwitchGaussMySqlProxySslRequest switchGaussMySqlProxySslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchGaussMySqlProxySslRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", switchGaussMySqlProxySslRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchGaussMySqlProxySslRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SwitchGaussMySqlProxySslResponse>(response);
        }

        public AsyncInvoker<SwitchGaussMySqlProxySslResponse> SwitchGaussMySqlProxySslAsyncInvoker(SwitchGaussMySqlProxySslRequest switchGaussMySqlProxySslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchGaussMySqlProxySslRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", switchGaussMySqlProxySslRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchGaussMySqlProxySslRequest);
            return new AsyncInvoker<SwitchGaussMySqlProxySslResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchGaussMySqlProxySslResponse>);
        }
        
        /// <summary>
        /// 开启或者关闭全量SQL
        ///
        /// 开启或者关闭全量SQL。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAuditLogResponse> UpdateAuditLogAsync(UpdateAuditLogRequest updateAuditLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateAuditLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/audit-log/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditLogRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateAuditLogResponse>(response);
        }

        public AsyncInvoker<UpdateAuditLogResponse> UpdateAuditLogAsyncInvoker(UpdateAuditLogRequest updateAuditLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateAuditLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instance/{instance_id}/audit-log/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAuditLogRequest);
            return new AsyncInvoker<UpdateAuditLogResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAuditLogResponse>);
        }
        
        /// <summary>
        /// 设置自动变配
        ///
        /// 设置自动变配。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAutoScalingPolicyResponse> UpdateAutoScalingPolicyAsync(UpdateAutoScalingPolicyRequest updateAutoScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateAutoScalingPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auto-scaling/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAutoScalingPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAutoScalingPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateAutoScalingPolicyResponse> UpdateAutoScalingPolicyAsyncInvoker(UpdateAutoScalingPolicyRequest updateAutoScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateAutoScalingPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/auto-scaling/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAutoScalingPolicyRequest);
            return new AsyncInvoker<UpdateAutoScalingPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAutoScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 设置跨区备份策略
        ///
        /// 设置跨区备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateBackupOffsitePolicyResponse> UpdateBackupOffsitePolicyAsync(UpdateBackupOffsitePolicyRequest updateBackupOffsitePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateBackupOffsitePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/offsite-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBackupOffsitePolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateBackupOffsitePolicyResponse>(response);
        }

        public AsyncInvoker<UpdateBackupOffsitePolicyResponse> UpdateBackupOffsitePolicyAsyncInvoker(UpdateBackupOffsitePolicyRequest updateBackupOffsitePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateBackupOffsitePolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/offsite-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBackupOffsitePolicyRequest);
            return new AsyncInvoker<UpdateBackupOffsitePolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateBackupOffsitePolicyResponse>);
        }
        
        /// <summary>
        /// 设置备份策略
        ///
        /// 设置自动备份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGaussMySqlBackupPolicyResponse> UpdateGaussMySqlBackupPolicyAsync(UpdateGaussMySqlBackupPolicyRequest updateGaussMySqlBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlBackupPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlBackupPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateGaussMySqlBackupPolicyResponse> UpdateGaussMySqlBackupPolicyAsyncInvoker(UpdateGaussMySqlBackupPolicyRequest updateGaussMySqlBackupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlBackupPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/backups/policy/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlBackupPolicyRequest);
            return new AsyncInvoker<UpdateGaussMySqlBackupPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGaussMySqlBackupPolicyResponse>);
        }
        
        /// <summary>
        /// 修改参数模板
        ///
        /// 修改指定参数模板的参数信息，包括名称、描述、指定参数的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGaussMySqlConfigurationResponse> UpdateGaussMySqlConfigurationAsync(UpdateGaussMySqlConfigurationRequest updateGaussMySqlConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", updateGaussMySqlConfigurationRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlConfigurationResponse>(response);
        }

        public AsyncInvoker<UpdateGaussMySqlConfigurationResponse> UpdateGaussMySqlConfigurationAsyncInvoker(UpdateGaussMySqlConfigurationRequest updateGaussMySqlConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("configuration_id", updateGaussMySqlConfigurationRequest.ConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlConfigurationRequest);
            return new AsyncInvoker<UpdateGaussMySqlConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGaussMySqlConfigurationResponse>);
        }
        
        /// <summary>
        /// 修改数据库备注
        ///
        /// 修改云数据库 GaussDB(for MySQL)实例数据库备注。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGaussMySqlDatabaseCommentResponse> UpdateGaussMySqlDatabaseCommentAsync(UpdateGaussMySqlDatabaseCommentRequest updateGaussMySqlDatabaseCommentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlDatabaseCommentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/comment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlDatabaseCommentRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlDatabaseCommentResponse>(response);
        }

        public AsyncInvoker<UpdateGaussMySqlDatabaseCommentResponse> UpdateGaussMySqlDatabaseCommentAsyncInvoker(UpdateGaussMySqlDatabaseCommentRequest updateGaussMySqlDatabaseCommentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlDatabaseCommentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/comment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlDatabaseCommentRequest);
            return new AsyncInvoker<UpdateGaussMySqlDatabaseCommentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGaussMySqlDatabaseCommentResponse>);
        }
        
        /// <summary>
        /// 修改数据库用户备注
        ///
        /// 修改云数据库 GaussDB(for MySQL)实例数据库用户备注。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGaussMySqlDatabaseUserCommentResponse> UpdateGaussMySqlDatabaseUserCommentAsync(UpdateGaussMySqlDatabaseUserCommentRequest updateGaussMySqlDatabaseUserCommentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlDatabaseUserCommentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/comment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlDatabaseUserCommentRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlDatabaseUserCommentResponse>(response);
        }

        public AsyncInvoker<UpdateGaussMySqlDatabaseUserCommentResponse> UpdateGaussMySqlDatabaseUserCommentAsyncInvoker(UpdateGaussMySqlDatabaseUserCommentRequest updateGaussMySqlDatabaseUserCommentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlDatabaseUserCommentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-users/comment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlDatabaseUserCommentRequest);
            return new AsyncInvoker<UpdateGaussMySqlDatabaseUserCommentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGaussMySqlDatabaseUserCommentResponse>);
        }
        
        /// <summary>
        /// 修改实例备注
        ///
        /// 修改实例备注。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGaussMySqlInstanceAliasResponse> UpdateGaussMySqlInstanceAliasAsync(UpdateGaussMySqlInstanceAliasRequest updateGaussMySqlInstanceAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceAliasRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/alias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceAliasRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateGaussMySqlInstanceAliasResponse>(response);
        }

        public AsyncInvoker<UpdateGaussMySqlInstanceAliasResponse> UpdateGaussMySqlInstanceAliasAsyncInvoker(UpdateGaussMySqlInstanceAliasRequest updateGaussMySqlInstanceAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceAliasRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/alias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceAliasRequest);
            return new AsyncInvoker<UpdateGaussMySqlInstanceAliasResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateGaussMySqlInstanceAliasResponse>);
        }
        
        /// <summary>
        /// 绑定弹性公网IP
        ///
        /// 实例绑定弹性公网IP，供外网连接使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGaussMySqlInstanceEipResponse> UpdateGaussMySqlInstanceEipAsync(UpdateGaussMySqlInstanceEipRequest updateGaussMySqlInstanceEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceEipRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ips/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceEipRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlInstanceEipResponse>(response);
        }

        public AsyncInvoker<UpdateGaussMySqlInstanceEipResponse> UpdateGaussMySqlInstanceEipAsyncInvoker(UpdateGaussMySqlInstanceEipRequest updateGaussMySqlInstanceEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceEipRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/public-ips/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceEipRequest);
            return new AsyncInvoker<UpdateGaussMySqlInstanceEipResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGaussMySqlInstanceEipResponse>);
        }
        
        /// <summary>
        /// 修改内网地址
        ///
        /// 修改实例内网地址。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGaussMySqlInstanceInternalIpResponse> UpdateGaussMySqlInstanceInternalIpAsync(UpdateGaussMySqlInstanceInternalIpRequest updateGaussMySqlInstanceInternalIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceInternalIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/internal-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceInternalIpRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlInstanceInternalIpResponse>(response);
        }

        public AsyncInvoker<UpdateGaussMySqlInstanceInternalIpResponse> UpdateGaussMySqlInstanceInternalIpAsyncInvoker(UpdateGaussMySqlInstanceInternalIpRequest updateGaussMySqlInstanceInternalIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceInternalIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/internal-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceInternalIpRequest);
            return new AsyncInvoker<UpdateGaussMySqlInstanceInternalIpResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGaussMySqlInstanceInternalIpResponse>);
        }
        
        /// <summary>
        /// 修改实例名称
        ///
        /// 修改实例名称。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGaussMySqlInstanceNameResponse> UpdateGaussMySqlInstanceNameAsync(UpdateGaussMySqlInstanceNameRequest updateGaussMySqlInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceNameRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlInstanceNameResponse>(response);
        }

        public AsyncInvoker<UpdateGaussMySqlInstanceNameResponse> UpdateGaussMySqlInstanceNameAsyncInvoker(UpdateGaussMySqlInstanceNameRequest updateGaussMySqlInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceNameRequest);
            return new AsyncInvoker<UpdateGaussMySqlInstanceNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGaussMySqlInstanceNameResponse>);
        }
        
        /// <summary>
        /// 设置可维护时间段
        ///
        /// 设置可维护时间段。建议将可维护时间段设置在业务低峰期，避免业务在维护过程中异常中断。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGaussMySqlInstanceOpsWindowResponse> UpdateGaussMySqlInstanceOpsWindowAsync(UpdateGaussMySqlInstanceOpsWindowRequest updateGaussMySqlInstanceOpsWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceOpsWindowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ops-window", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceOpsWindowRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateGaussMySqlInstanceOpsWindowResponse>(response);
        }

        public AsyncInvoker<UpdateGaussMySqlInstanceOpsWindowResponse> UpdateGaussMySqlInstanceOpsWindowAsyncInvoker(UpdateGaussMySqlInstanceOpsWindowRequest updateGaussMySqlInstanceOpsWindowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceOpsWindowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/ops-window", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceOpsWindowRequest);
            return new AsyncInvoker<UpdateGaussMySqlInstanceOpsWindowResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateGaussMySqlInstanceOpsWindowResponse>);
        }
        
        /// <summary>
        /// 修改实例端口
        ///
        /// 修改实例数据库端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGaussMySqlInstancePortResponse> UpdateGaussMySqlInstancePortAsync(UpdateGaussMySqlInstancePortRequest updateGaussMySqlInstancePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstancePortRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstancePortRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlInstancePortResponse>(response);
        }

        public AsyncInvoker<UpdateGaussMySqlInstancePortResponse> UpdateGaussMySqlInstancePortAsyncInvoker(UpdateGaussMySqlInstancePortRequest updateGaussMySqlInstancePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstancePortRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstancePortRequest);
            return new AsyncInvoker<UpdateGaussMySqlInstancePortResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGaussMySqlInstancePortResponse>);
        }
        
        /// <summary>
        /// 修改安全组
        ///
        /// 修改指定实例安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGaussMySqlInstanceSecurityGroupResponse> UpdateGaussMySqlInstanceSecurityGroupAsync(UpdateGaussMySqlInstanceSecurityGroupRequest updateGaussMySqlInstanceSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceSecurityGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceSecurityGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlInstanceSecurityGroupResponse>(response);
        }

        public AsyncInvoker<UpdateGaussMySqlInstanceSecurityGroupResponse> UpdateGaussMySqlInstanceSecurityGroupAsyncInvoker(UpdateGaussMySqlInstanceSecurityGroupRequest updateGaussMySqlInstanceSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateGaussMySqlInstanceSecurityGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlInstanceSecurityGroupRequest);
            return new AsyncInvoker<UpdateGaussMySqlInstanceSecurityGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGaussMySqlInstanceSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 修改租户基于企业项目的资源配额
        ///
        /// 修改指定企业项目的资源配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGaussMySqlQuotasResponse> UpdateGaussMySqlQuotasAsync(UpdateGaussMySqlQuotasRequest updateGaussMySqlQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlQuotasRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGaussMySqlQuotasResponse>(response);
        }

        public AsyncInvoker<UpdateGaussMySqlQuotasResponse> UpdateGaussMySqlQuotasAsyncInvoker(UpdateGaussMySqlQuotasRequest updateGaussMySqlQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGaussMySqlQuotasRequest);
            return new AsyncInvoker<UpdateGaussMySqlQuotasResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGaussMySqlQuotasResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceConfigurationsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceConfigurationsResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceConfigurationsResponse> UpdateInstanceConfigurationsAsyncInvoker(UpdateInstanceConfigurationsRequest updateInstanceConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceConfigurationsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceConfigurationsRequest);
            return new AsyncInvoker<UpdateInstanceConfigurationsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceConfigurationsResponse>);
        }
        
        /// <summary>
        /// 设置实例秒级监控
        ///
        /// 设置实例秒级监控，包括1秒监控和5秒监控。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceMonitorResponse> UpdateInstanceMonitorAsync(UpdateInstanceMonitorRequest updateInstanceMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceMonitorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitor-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceMonitorRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceMonitorResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceMonitorResponse> UpdateInstanceMonitorAsyncInvoker(UpdateInstanceMonitorRequest updateInstanceMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceMonitorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/monitor-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceMonitorRequest);
            return new AsyncInvoker<UpdateInstanceMonitorResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceMonitorResponse>);
        }
        
        /// <summary>
        /// 开启或关闭新增节点自动加入该Proxy
        ///
        /// 开启或关闭新增节点自动加入该Proxy。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateNewNodeAutoAddSwitchResponse> UpdateNewNodeAutoAddSwitchAsync(UpdateNewNodeAutoAddSwitchRequest updateNewNodeAutoAddSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateNewNodeAutoAddSwitchRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", updateNewNodeAutoAddSwitchRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/new-node-auto-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateNewNodeAutoAddSwitchRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateNewNodeAutoAddSwitchResponse>(response);
        }

        public AsyncInvoker<UpdateNewNodeAutoAddSwitchResponse> UpdateNewNodeAutoAddSwitchAsyncInvoker(UpdateNewNodeAutoAddSwitchRequest updateNewNodeAutoAddSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateNewNodeAutoAddSwitchRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", updateNewNodeAutoAddSwitchRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/new-node-auto-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateNewNodeAutoAddSwitchRequest);
            return new AsyncInvoker<UpdateNewNodeAutoAddSwitchResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateNewNodeAutoAddSwitchResponse>);
        }
        
        /// <summary>
        /// 更改数据库代理连接池类型
        ///
        /// 更改数据库代理连接池类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateProxyConnectionPoolTypeResponse> UpdateProxyConnectionPoolTypeAsync(UpdateProxyConnectionPoolTypeRequest updateProxyConnectionPoolTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateProxyConnectionPoolTypeRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", updateProxyConnectionPoolTypeRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/connection-pool-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProxyConnectionPoolTypeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProxyConnectionPoolTypeResponse>(response);
        }

        public AsyncInvoker<UpdateProxyConnectionPoolTypeResponse> UpdateProxyConnectionPoolTypeAsyncInvoker(UpdateProxyConnectionPoolTypeRequest updateProxyConnectionPoolTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateProxyConnectionPoolTypeRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", updateProxyConnectionPoolTypeRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/connection-pool-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProxyConnectionPoolTypeRequest);
            return new AsyncInvoker<UpdateProxyConnectionPoolTypeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProxyConnectionPoolTypeResponse>);
        }
        
        /// <summary>
        /// 修改代理实例参数
        ///
        /// 修改数据库代理参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateProxyNewConfigurationsResponse> UpdateProxyNewConfigurationsAsync(UpdateProxyNewConfigurationsRequest updateProxyNewConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateProxyNewConfigurationsRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", updateProxyNewConfigurationsRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProxyNewConfigurationsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProxyNewConfigurationsResponse>(response);
        }

        public AsyncInvoker<UpdateProxyNewConfigurationsResponse> UpdateProxyNewConfigurationsAsyncInvoker(UpdateProxyNewConfigurationsRequest updateProxyNewConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateProxyNewConfigurationsRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", updateProxyNewConfigurationsRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProxyNewConfigurationsRequest);
            return new AsyncInvoker<UpdateProxyNewConfigurationsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProxyNewConfigurationsResponse>);
        }
        
        /// <summary>
        /// 修改读写分离端口号
        ///
        /// 修改读写分离端口号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateProxyPortResponse> UpdateProxyPortAsync(UpdateProxyPortRequest updateProxyPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateProxyPortRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", updateProxyPortRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProxyPortRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProxyPortResponse>(response);
        }

        public AsyncInvoker<UpdateProxyPortResponse> UpdateProxyPortAsyncInvoker(UpdateProxyPortRequest updateProxyPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateProxyPortRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", updateProxyPortRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProxyPortRequest);
            return new AsyncInvoker<UpdateProxyPortResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProxyPortResponse>);
        }
        
        /// <summary>
        /// 修改代理会话一致性
        ///
        /// 修改代理会话一致性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateProxySessionConsistenceResponse> UpdateProxySessionConsistenceAsync(UpdateProxySessionConsistenceRequest updateProxySessionConsistenceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateProxySessionConsistenceRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", updateProxySessionConsistenceRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/session-consistence", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProxySessionConsistenceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProxySessionConsistenceResponse>(response);
        }

        public AsyncInvoker<UpdateProxySessionConsistenceResponse> UpdateProxySessionConsistenceAsyncInvoker(UpdateProxySessionConsistenceRequest updateProxySessionConsistenceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateProxySessionConsistenceRequest.InstanceId.ToString());
            urlParam.Add("proxy_id", updateProxySessionConsistenceRequest.ProxyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/{proxy_id}/session-consistence", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProxySessionConsistenceRequest);
            return new AsyncInvoker<UpdateProxySessionConsistenceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProxySessionConsistenceResponse>);
        }
        
        /// <summary>
        /// 设置proxy事务拆分
        ///
        /// 设置proxy事务拆分。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTransactionSplitStatusResponse> UpdateTransactionSplitStatusAsync(UpdateTransactionSplitStatusRequest updateTransactionSplitStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateTransactionSplitStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/transaction-split", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTransactionSplitStatusRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateTransactionSplitStatusResponse>(response);
        }

        public AsyncInvoker<UpdateTransactionSplitStatusResponse> UpdateTransactionSplitStatusAsyncInvoker(UpdateTransactionSplitStatusRequest updateTransactionSplitStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateTransactionSplitStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/proxy/transaction-split", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTransactionSplitStatusRequest);
            return new AsyncInvoker<UpdateTransactionSplitStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateTransactionSplitStatusResponse>);
        }
        
        /// <summary>
        /// 内核版本升级
        ///
        /// 内核版本升级。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpgradeGaussMySqlInstanceDatabaseResponse> UpgradeGaussMySqlInstanceDatabaseAsync(UpgradeGaussMySqlInstanceDatabaseRequest upgradeGaussMySqlInstanceDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeGaussMySqlInstanceDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeGaussMySqlInstanceDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpgradeGaussMySqlInstanceDatabaseResponse>(response);
        }

        public AsyncInvoker<UpgradeGaussMySqlInstanceDatabaseResponse> UpgradeGaussMySqlInstanceDatabaseAsyncInvoker(UpgradeGaussMySqlInstanceDatabaseRequest upgradeGaussMySqlInstanceDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", upgradeGaussMySqlInstanceDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/db-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeGaussMySqlInstanceDatabaseRequest);
            return new AsyncInvoker<UpgradeGaussMySqlInstanceDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeGaussMySqlInstanceDatabaseResponse>);
        }
        
        /// <summary>
        /// HTAP数据同步库配置校验
        ///
        /// HTAP数据同步库配置校验。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckDataBaseConfigResponse> CheckDataBaseConfigAsync(CheckDataBaseConfigRequest checkDataBaseConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", checkDataBaseConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/starrocks/databases/replication/database-config-check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkDataBaseConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CheckDataBaseConfigResponse>(response);
        }

        public AsyncInvoker<CheckDataBaseConfigResponse> CheckDataBaseConfigAsyncInvoker(CheckDataBaseConfigRequest checkDataBaseConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", checkDataBaseConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/starrocks/databases/replication/database-config-check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkDataBaseConfigRequest);
            return new AsyncInvoker<CheckDataBaseConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckDataBaseConfigResponse>);
        }
        
        /// <summary>
        /// HTAP数据同步表配置校验
        ///
        /// HTAP数据同步表配置校验。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckTableConfigResponse> CheckTableConfigAsync(CheckTableConfigRequest checkTableConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", checkTableConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/starrocks/databases/replication/table-config-check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkTableConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CheckTableConfigResponse>(response);
        }

        public AsyncInvoker<CheckTableConfigResponse> CheckTableConfigAsyncInvoker(CheckTableConfigRequest checkTableConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", checkTableConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/starrocks/databases/replication/table-config-check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkTableConfigRequest);
            return new AsyncInvoker<CheckTableConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckTableConfigResponse>);
        }
        
        /// <summary>
        /// 创建StarRocks数据同步
        ///
        /// 创建StarRocks数据同步。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateStarRocksDataReplicationResponse> CreateStarRocksDataReplicationAsync(CreateStarRocksDataReplicationRequest createStarRocksDataReplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createStarRocksDataReplicationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/starrocks/databases/replication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createStarRocksDataReplicationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateStarRocksDataReplicationResponse>(response);
        }

        public AsyncInvoker<CreateStarRocksDataReplicationResponse> CreateStarRocksDataReplicationAsyncInvoker(CreateStarRocksDataReplicationRequest createStarRocksDataReplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createStarRocksDataReplicationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/starrocks/databases/replication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createStarRocksDataReplicationRequest);
            return new AsyncInvoker<CreateStarRocksDataReplicationResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateStarRocksDataReplicationResponse>);
        }
        
        /// <summary>
        /// 删除StarRocks数据同步
        ///
        /// 删除StarRocks数据同步。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteStarRocksDataReplicationResponse> DeleteStarRocksDataReplicationAsync(DeleteStarRocksDataReplicationRequest deleteStarRocksDataReplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteStarRocksDataReplicationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/starrocks/databases/replication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteStarRocksDataReplicationRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteStarRocksDataReplicationResponse>(response);
        }

        public AsyncInvoker<DeleteStarRocksDataReplicationResponse> DeleteStarRocksDataReplicationAsyncInvoker(DeleteStarRocksDataReplicationRequest deleteStarRocksDataReplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteStarRocksDataReplicationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/starrocks/databases/replication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteStarRocksDataReplicationRequest);
            return new AsyncInvoker<DeleteStarRocksDataReplicationResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteStarRocksDataReplicationResponse>);
        }
        
        /// <summary>
        /// 查询StarRocks数据库
        ///
        /// 查询StarRocks数据库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStarRocksDataBasesResponse> ListStarRocksDataBasesAsync(ListStarRocksDataBasesRequest listStarRocksDataBasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listStarRocksDataBasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/starrocks/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStarRocksDataBasesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStarRocksDataBasesResponse>(response);
        }

        public AsyncInvoker<ListStarRocksDataBasesResponse> ListStarRocksDataBasesAsyncInvoker(ListStarRocksDataBasesRequest listStarRocksDataBasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listStarRocksDataBasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/starrocks/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStarRocksDataBasesRequest);
            return new AsyncInvoker<ListStarRocksDataBasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStarRocksDataBasesResponse>);
        }
        
        /// <summary>
        /// 查询StarRocks数据同步配置信息
        ///
        /// 查询StarRocks数据同步配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStarRocksDataReplicationConfigResponse> ListStarRocksDataReplicationConfigAsync(ListStarRocksDataReplicationConfigRequest listStarRocksDataReplicationConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listStarRocksDataReplicationConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/starrocks/databases/replication/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStarRocksDataReplicationConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStarRocksDataReplicationConfigResponse>(response);
        }

        public AsyncInvoker<ListStarRocksDataReplicationConfigResponse> ListStarRocksDataReplicationConfigAsyncInvoker(ListStarRocksDataReplicationConfigRequest listStarRocksDataReplicationConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listStarRocksDataReplicationConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/starrocks/databases/replication/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStarRocksDataReplicationConfigRequest);
            return new AsyncInvoker<ListStarRocksDataReplicationConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStarRocksDataReplicationConfigResponse>);
        }
        
        /// <summary>
        /// 查询StarRocks数据同步状态信息
        ///
        /// 查询StarRocks数据同步状态信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStarRocksDataReplicationsResponse> ListStarRocksDataReplicationsAsync(ListStarRocksDataReplicationsRequest listStarRocksDataReplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listStarRocksDataReplicationsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/starrocks/databases/replication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStarRocksDataReplicationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStarRocksDataReplicationsResponse>(response);
        }

        public AsyncInvoker<ListStarRocksDataReplicationsResponse> ListStarRocksDataReplicationsAsyncInvoker(ListStarRocksDataReplicationsRequest listStarRocksDataReplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listStarRocksDataReplicationsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/starrocks/databases/replication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStarRocksDataReplicationsRequest);
            return new AsyncInvoker<ListStarRocksDataReplicationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStarRocksDataReplicationsResponse>);
        }
        
        /// <summary>
        /// 查询StarRocks数据同步的库参数配置
        ///
        /// 查询StarRocks数据同步的库参数配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStarRocksDbParametersResponse> ListStarRocksDbParametersAsync(ListStarRocksDbParametersRequest listStarRocksDbParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listStarRocksDbParametersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/starrocks/databases/replication/database-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStarRocksDbParametersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStarRocksDbParametersResponse>(response);
        }

        public AsyncInvoker<ListStarRocksDbParametersResponse> ListStarRocksDbParametersAsyncInvoker(ListStarRocksDbParametersRequest listStarRocksDbParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listStarRocksDbParametersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/starrocks/databases/replication/database-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStarRocksDbParametersRequest);
            return new AsyncInvoker<ListStarRocksDbParametersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStarRocksDbParametersResponse>);
        }
        
        /// <summary>
        /// 删除SQL限流规则
        ///
        /// 删除SQL限流规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSqlFilterRuleResponse> DeleteSqlFilterRuleAsync(DeleteSqlFilterRuleRequest deleteSqlFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteSqlFilterRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteSqlFilterRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSqlFilterRuleResponse>(response);
        }

        public AsyncInvoker<DeleteSqlFilterRuleResponse> DeleteSqlFilterRuleAsyncInvoker(DeleteSqlFilterRuleRequest deleteSqlFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteSqlFilterRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteSqlFilterRuleRequest);
            return new AsyncInvoker<DeleteSqlFilterRuleResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSqlFilterRuleResponse>);
        }
        
        /// <summary>
        /// 设置SQL限流规则
        ///
        /// 设置SQL限流规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetSqlFilterRuleResponse> SetSqlFilterRuleAsync(SetSqlFilterRuleRequest setSqlFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setSqlFilterRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setSqlFilterRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SetSqlFilterRuleResponse>(response);
        }

        public AsyncInvoker<SetSqlFilterRuleResponse> SetSqlFilterRuleAsyncInvoker(SetSqlFilterRuleRequest setSqlFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", setSqlFilterRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", setSqlFilterRuleRequest);
            return new AsyncInvoker<SetSqlFilterRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetSqlFilterRuleResponse>);
        }
        
        /// <summary>
        /// 查询SQL限流开关状态
        ///
        /// 查询SQL限流开关状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSqlFilterControlResponse> ShowSqlFilterControlAsync(ShowSqlFilterControlRequest showSqlFilterControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSqlFilterControlRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSqlFilterControlRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSqlFilterControlResponse>(response);
        }

        public AsyncInvoker<ShowSqlFilterControlResponse> ShowSqlFilterControlAsyncInvoker(ShowSqlFilterControlRequest showSqlFilterControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSqlFilterControlRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSqlFilterControlRequest);
            return new AsyncInvoker<ShowSqlFilterControlResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSqlFilterControlResponse>);
        }
        
        /// <summary>
        /// 查询SQL限流规则
        ///
        /// 查询SQL限流规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSqlFilterRuleResponse> ShowSqlFilterRuleAsync(ShowSqlFilterRuleRequest showSqlFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSqlFilterRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSqlFilterRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSqlFilterRuleResponse>(response);
        }

        public AsyncInvoker<ShowSqlFilterRuleResponse> ShowSqlFilterRuleAsyncInvoker(ShowSqlFilterRuleRequest showSqlFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showSqlFilterRuleRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSqlFilterRuleRequest);
            return new AsyncInvoker<ShowSqlFilterRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSqlFilterRuleResponse>);
        }
        
        /// <summary>
        /// 开启或者关闭SQL限流
        ///
        /// 开启或者关闭SQL限流。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSqlFilterControlResponse> UpdateSqlFilterControlAsync(UpdateSqlFilterControlRequest updateSqlFilterControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateSqlFilterControlRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSqlFilterControlRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateSqlFilterControlResponse>(response);
        }

        public AsyncInvoker<UpdateSqlFilterControlResponse> UpdateSqlFilterControlAsyncInvoker(UpdateSqlFilterControlRequest updateSqlFilterControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateSqlFilterControlRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/sql-filter/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSqlFilterControlRequest);
            return new AsyncInvoker<UpdateSqlFilterControlResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateSqlFilterControlResponse>);
        }
        
    }
}