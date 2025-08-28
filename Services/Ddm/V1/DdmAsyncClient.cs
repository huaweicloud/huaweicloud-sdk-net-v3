using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ddm.V1.Model;

namespace HuaweiCloud.SDK.Ddm.V1
{
    public partial class DdmAsyncClient : Client
    {
        public static ClientBuilder<DdmAsyncClient> NewBuilder()
        {
            return new ClientBuilder<DdmAsyncClient>();
        }

        
        /// <summary>
        /// 变更内核版本
        ///
        /// 变更内核版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeDatabaseVersionResponse> ChangeDatabaseVersionAsync(ChangeDatabaseVersionRequest changeDatabaseVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeDatabaseVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database-version/change-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeDatabaseVersionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeDatabaseVersionResponse>(response);
        }

        public AsyncInvoker<ChangeDatabaseVersionResponse> ChangeDatabaseVersionAsyncInvoker(ChangeDatabaseVersionRequest changeDatabaseVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", changeDatabaseVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database-version/change-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeDatabaseVersionRequest);
            return new AsyncInvoker<ChangeDatabaseVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeDatabaseVersionResponse>);
        }
        
        /// <summary>
        /// 查询可变更内核版本
        ///
        /// 查询可变更内核版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDatabaseAvailableVersionsResponse> ListDatabaseAvailableVersionsAsync(ListDatabaseAvailableVersionsRequest listDatabaseAvailableVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabaseAvailableVersionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database-version/available-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseAvailableVersionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDatabaseAvailableVersionsResponse>(response);
        }

        public AsyncInvoker<ListDatabaseAvailableVersionsResponse> ListDatabaseAvailableVersionsAsyncInvoker(ListDatabaseAvailableVersionsRequest listDatabaseAvailableVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabaseAvailableVersionsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database-version/available-versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabaseAvailableVersionsRequest);
            return new AsyncInvoker<ListDatabaseAvailableVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabaseAvailableVersionsResponse>);
        }
        
        /// <summary>
        /// 获取参数模板列表
        ///
        /// 获取参数模板列表，包括所有DDM的默认参数模板和用户创建的参数模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDdmConfigurationsResponse> ListDdmConfigurationsAsync(ListDdmConfigurationsRequest listDdmConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDdmConfigurationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDdmConfigurationsResponse>(response);
        }

        public AsyncInvoker<ListDdmConfigurationsResponse> ListDdmConfigurationsAsyncInvoker(ListDdmConfigurationsRequest listDdmConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDdmConfigurationsRequest);
            return new AsyncInvoker<ListDdmConfigurationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDdmConfigurationsResponse>);
        }
        
        /// <summary>
        /// 回滚内核版本
        ///
        /// 回滚内核版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RollBackDatabaseVersionResponse> RollBackDatabaseVersionAsync(RollBackDatabaseVersionRequest rollBackDatabaseVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", rollBackDatabaseVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database-version/rollback-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollBackDatabaseVersionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RollBackDatabaseVersionResponse>(response);
        }

        public AsyncInvoker<RollBackDatabaseVersionResponse> RollBackDatabaseVersionAsyncInvoker(RollBackDatabaseVersionRequest rollBackDatabaseVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", rollBackDatabaseVersionRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/database-version/rollback-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rollBackDatabaseVersionRequest);
            return new AsyncInvoker<RollBackDatabaseVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<RollBackDatabaseVersionResponse>);
        }
        
        /// <summary>
        /// 获取指定参数模板的参数
        ///
        /// 获取指定参数模板的参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowConfigurationResponse> ShowConfigurationAsync(ShowConfigurationRequest showConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigurationResponse>(response);
        }

        public AsyncInvoker<ShowConfigurationResponse> ShowConfigurationAsyncInvoker(ShowConfigurationRequest showConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("config_id", showConfigurationRequest.ConfigId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/configurations/{config_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigurationRequest);
            return new AsyncInvoker<ShowConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigurationResponse>);
        }
        
        /// <summary>
        /// 内核版本风险提醒
        ///
        /// 内核版本风险提醒
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRiskInfoResponse> ShowRiskInfoAsync(ShowRiskInfoRequest showRiskInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRiskInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/show-risk-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRiskInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRiskInfoResponse>(response);
        }

        public AsyncInvoker<ShowRiskInfoResponse> ShowRiskInfoAsyncInvoker(ShowRiskInfoRequest showRiskInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRiskInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/show-risk-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRiskInfoRequest);
            return new AsyncInvoker<ShowRiskInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRiskInfoResponse>);
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
        /// 创建DDM逻辑库
        ///
        /// 创建DDM逻辑库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDatabaseResponse> CreateDatabaseAsync(CreateDatabaseRequest createDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDatabaseResponse>(response);
        }

        public AsyncInvoker<CreateDatabaseResponse> CreateDatabaseAsyncInvoker(CreateDatabaseRequest createDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatabaseRequest);
            return new AsyncInvoker<CreateDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDatabaseResponse>);
        }
        
        /// <summary>
        /// 创建DDM逻辑库
        ///
        /// 创建DDM逻辑库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDdmDatabaseResponse> CreateDdmDatabaseAsync(CreateDdmDatabaseRequest createDdmDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDdmDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDdmDatabaseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDdmDatabaseResponse>(response);
        }

        public AsyncInvoker<CreateDdmDatabaseResponse> CreateDdmDatabaseAsyncInvoker(CreateDdmDatabaseRequest createDdmDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDdmDatabaseRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDdmDatabaseRequest);
            return new AsyncInvoker<CreateDdmDatabaseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDdmDatabaseResponse>);
        }
        
        /// <summary>
        /// 创建组
        ///
        /// 创建组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest createGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGroupResponse>(response);
        }

        public AsyncInvoker<CreateGroupResponse> CreateGroupAsyncInvoker(CreateGroupRequest createGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGroupRequest);
            return new AsyncInvoker<CreateGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGroupResponse>);
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
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceResponse>(response);
        }

        public AsyncInvoker<CreateInstanceResponse> CreateInstanceAsyncInvoker(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createInstanceRequest);
            return new AsyncInvoker<CreateInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceResponse>);
        }
        
        /// <summary>
        /// 创建DDM帐号
        ///
        /// DDM帐号用于连接和管理逻辑库。一个DDM实例最多能创建100个DDM帐号，一个DDM帐号可以关联多个逻辑库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateUsersResponse> CreateUsersAsync(CreateUsersRequest createUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createUsersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateUsersResponse>(response);
        }

        public AsyncInvoker<CreateUsersResponse> CreateUsersAsyncInvoker(CreateUsersRequest createUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createUsersRequest);
            return new AsyncInvoker<CreateUsersResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUsersResponse>);
        }
        
        /// <summary>
        /// 删除DDM逻辑库
        ///
        /// 删除指定的逻辑库，释放该逻辑库的所有资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDatabaseResponse> DeleteDatabaseAsync(DeleteDatabaseRequest deleteDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabaseRequest.InstanceId.ToString());
            urlParam.Add("ddm_dbname", deleteDatabaseRequest.DdmDbname.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/databases/{ddm_dbname}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDatabaseResponse>(response);
        }

        public AsyncInvoker<DeleteDatabaseResponse> DeleteDatabaseAsyncInvoker(DeleteDatabaseRequest deleteDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDatabaseRequest.InstanceId.ToString());
            urlParam.Add("ddm_dbname", deleteDatabaseRequest.DdmDbname.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/databases/{ddm_dbname}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDatabaseRequest);
            return new AsyncInvoker<DeleteDatabaseResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDatabaseResponse>);
        }
        
        /// <summary>
        /// 删除逻辑库
        ///
        /// 删除指定的逻辑库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDdmDatabaseResponse> DeleteDdmDatabaseAsync(DeleteDdmDatabaseRequest deleteDdmDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDdmDatabaseRequest.InstanceId.ToString());
            urlParam.Add("database_name", deleteDdmDatabaseRequest.DatabaseName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDdmDatabaseRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDdmDatabaseResponse>(response);
        }

        public AsyncInvoker<DeleteDdmDatabaseResponse> DeleteDdmDatabaseAsyncInvoker(DeleteDdmDatabaseRequest deleteDdmDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDdmDatabaseRequest.InstanceId.ToString());
            urlParam.Add("database_name", deleteDdmDatabaseRequest.DatabaseName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/databases/{database_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDdmDatabaseRequest);
            return new AsyncInvoker<DeleteDdmDatabaseResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDdmDatabaseResponse>);
        }
        
        /// <summary>
        /// 删除DDM实例
        ///
        /// 删除指定的DDM实例，释放该实例的所有资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDdmInstanceResponse> DeleteDdmInstanceAsync(DeleteDdmInstanceRequest deleteDdmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDdmInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDdmInstanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDdmInstanceResponse>(response);
        }

        public AsyncInvoker<DeleteDdmInstanceResponse> DeleteDdmInstanceAsyncInvoker(DeleteDdmInstanceRequest deleteDdmInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteDdmInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDdmInstanceRequest);
            return new AsyncInvoker<DeleteDdmInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDdmInstanceResponse>);
        }
        
        /// <summary>
        /// 删除DDM实例
        ///
        /// 删除指定的DDM实例，释放该实例的所有资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteInstanceResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceResponse> DeleteInstanceAsyncInvoker(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            return new AsyncInvoker<DeleteInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteInstanceResponse>);
        }
        
        /// <summary>
        /// 删除DDM帐号
        ///
        /// 删除指定的DDM实例帐号，如果帐号关联了逻辑库，则对应的关联关系也会删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest deleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteUserRequest.InstanceId.ToString());
            urlParam.Add("username", deleteUserRequest.Username.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/users/{username}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteUserResponse>(response);
        }

        public AsyncInvoker<DeleteUserResponse> DeleteUserAsyncInvoker(DeleteUserRequest deleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteUserRequest.InstanceId.ToString());
            urlParam.Add("username", deleteUserRequest.Username.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/users/{username}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            return new AsyncInvoker<DeleteUserResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteUserResponse>);
        }
        
        /// <summary>
        /// kill逻辑会话
        ///
        /// kill逻辑会话
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteKillLogicalProcessesResponse> ExecuteKillLogicalProcessesAsync(ExecuteKillLogicalProcessesRequest executeKillLogicalProcessesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeKillLogicalProcessesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/logical-processes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeKillLogicalProcessesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<ExecuteKillLogicalProcessesResponse>(response);
        }

        public AsyncInvoker<ExecuteKillLogicalProcessesResponse> ExecuteKillLogicalProcessesAsyncInvoker(ExecuteKillLogicalProcessesRequest executeKillLogicalProcessesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeKillLogicalProcessesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/logical-processes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeKillLogicalProcessesRequest);
            return new AsyncInvoker<ExecuteKillLogicalProcessesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<ExecuteKillLogicalProcessesResponse>);
        }
        
        /// <summary>
        /// kill物理会话
        ///
        /// kill物理会话
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteKillPhysicalProcessesResponse> ExecuteKillPhysicalProcessesAsync(ExecuteKillPhysicalProcessesRequest executeKillPhysicalProcessesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeKillPhysicalProcessesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/physical-processes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeKillPhysicalProcessesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<ExecuteKillPhysicalProcessesResponse>(response);
        }

        public AsyncInvoker<ExecuteKillPhysicalProcessesResponse> ExecuteKillPhysicalProcessesAsyncInvoker(ExecuteKillPhysicalProcessesRequest executeKillPhysicalProcessesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", executeKillPhysicalProcessesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/physical-processes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeKillPhysicalProcessesRequest);
            return new AsyncInvoker<ExecuteKillPhysicalProcessesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<ExecuteKillPhysicalProcessesResponse>);
        }
        
        /// <summary>
        /// DDM实例节点扩容
        ///
        /// 对指定的DDM实例的节点个数进行扩容，支持按需实例与包周期实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExpandDdmInstanceNodesResponse> ExpandDdmInstanceNodesAsync(ExpandDdmInstanceNodesRequest expandDdmInstanceNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", expandDdmInstanceNodesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", expandDdmInstanceNodesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExpandDdmInstanceNodesResponse>(response);
        }

        public AsyncInvoker<ExpandDdmInstanceNodesResponse> ExpandDdmInstanceNodesAsyncInvoker(ExpandDdmInstanceNodesRequest expandDdmInstanceNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", expandDdmInstanceNodesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", expandDdmInstanceNodesRequest);
            return new AsyncInvoker<ExpandDdmInstanceNodesResponse>(this, "POST", request, JsonUtils.DeSerialize<ExpandDdmInstanceNodesResponse>);
        }
        
        /// <summary>
        /// DDM实例节点扩容
        ///
        /// 对指定的DDM实例的节点个数进行扩容，支持按需实例与包周期实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExpandInstanceNodesResponse> ExpandInstanceNodesAsync(ExpandInstanceNodesRequest expandInstanceNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", expandInstanceNodesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/action/enlarge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", expandInstanceNodesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExpandInstanceNodesResponse>(response);
        }

        public AsyncInvoker<ExpandInstanceNodesResponse> ExpandInstanceNodesAsyncInvoker(ExpandInstanceNodesRequest expandInstanceNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", expandInstanceNodesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/action/enlarge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", expandInstanceNodesRequest);
            return new AsyncInvoker<ExpandInstanceNodesResponse>(this, "POST", request, JsonUtils.DeSerialize<ExpandInstanceNodesResponse>);
        }
        
        /// <summary>
        /// 查询创建逻辑库可选取的数据库实例列表
        ///
        /// 查询创建逻辑库可选取的数据库实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAvailableRdsListResponse> ListAvailableRdsListAsync(ListAvailableRdsListRequest listAvailableRdsListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAvailableRdsListRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableRdsListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAvailableRdsListResponse>(response);
        }

        public AsyncInvoker<ListAvailableRdsListResponse> ListAvailableRdsListAsyncInvoker(ListAvailableRdsListRequest listAvailableRdsListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAvailableRdsListRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/rds", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableRdsListRequest);
            return new AsyncInvoker<ListAvailableRdsListResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailableRdsListResponse>);
        }
        
        /// <summary>
        /// 查询DDM逻辑库列表
        ///
        /// 查询DDM逻辑库列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDatabasesResponse> ListDatabasesAsync(ListDatabasesRequest listDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabasesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDatabasesResponse>(response);
        }

        public AsyncInvoker<ListDatabasesResponse> ListDatabasesAsyncInvoker(ListDatabasesRequest listDatabasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDatabasesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/databases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDatabasesRequest);
            return new AsyncInvoker<ListDatabasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDatabasesResponse>);
        }
        
        /// <summary>
        /// 查询DDM引擎信息
        ///
        /// 查询DDM引擎信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDdmEnginesResponse> ListDdmEnginesAsync(ListDdmEnginesRequest listDdmEnginesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/engines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDdmEnginesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDdmEnginesResponse>(response);
        }

        public AsyncInvoker<ListDdmEnginesResponse> ListDdmEnginesAsyncInvoker(ListDdmEnginesRequest listDdmEnginesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/engines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDdmEnginesRequest);
            return new AsyncInvoker<ListDdmEnginesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDdmEnginesResponse>);
        }
        
        /// <summary>
        /// 查询DDM可用区规格信息
        ///
        /// 查询DDM可用区规格信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDdmFlavorsResponse> ListDdmFlavorsAsync(ListDdmFlavorsRequest listDdmFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDdmFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDdmFlavorsResponse>(response);
        }

        public AsyncInvoker<ListDdmFlavorsResponse> ListDdmFlavorsAsyncInvoker(ListDdmFlavorsRequest listDdmFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDdmFlavorsRequest);
            return new AsyncInvoker<ListDdmFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDdmFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询DDM引擎信息
        ///
        /// 查询DDM引擎信息详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEnginesResponse> ListEnginesAsync(ListEnginesRequest listEnginesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/engines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnginesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEnginesResponse>(response);
        }

        public AsyncInvoker<ListEnginesResponse> ListEnginesAsyncInvoker(ListEnginesRequest listEnginesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/engines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnginesRequest);
            return new AsyncInvoker<ListEnginesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEnginesResponse>);
        }
        
        /// <summary>
        /// 查询DDM可用区规格信息
        ///
        /// 查询DDM可用区规格信息详情。
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
        /// 获取实例组信息列表
        ///
        /// 获取实例组信息列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGroupResponse> ListGroupAsync(ListGroupRequest listGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGroupResponse>(response);
        }

        public AsyncInvoker<ListGroupResponse> ListGroupAsyncInvoker(ListGroupRequest listGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupRequest);
            return new AsyncInvoker<ListGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupResponse>);
        }
        
        /// <summary>
        /// 查询DDM实例列表
        ///
        /// 查询DDM实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesResponse>(response);
        }

        public AsyncInvoker<ListInstancesResponse> ListInstancesAsyncInvoker(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            return new AsyncInvoker<ListInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesResponse>);
        }
        
        /// <summary>
        /// 查询DDM实例节点列表
        ///
        /// 查询DDM实例节点列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNodesResponse> ListNodesAsync(ListNodesRequest listNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listNodesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNodesResponse>(response);
        }

        public AsyncInvoker<ListNodesResponse> ListNodesAsyncInvoker(ListNodesRequest listNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listNodesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/nodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodesRequest);
            return new AsyncInvoker<ListNodesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNodesResponse>);
        }
        
        /// <summary>
        /// 读写比例监控
        ///
        /// 查询指定时间段内在DDM实例的读写次数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListReadWriteRatioResponse> ListReadWriteRatioAsync(ListReadWriteRatioRequest listReadWriteRatioRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listReadWriteRatioRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/read-write-ratio", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReadWriteRatioRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListReadWriteRatioResponse>(response);
        }

        public AsyncInvoker<ListReadWriteRatioResponse> ListReadWriteRatioAsyncInvoker(ListReadWriteRatioRequest listReadWriteRatioRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listReadWriteRatioRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/read-write-ratio", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReadWriteRatioRequest);
            return new AsyncInvoker<ListReadWriteRatioResponse>(this, "GET", request, JsonUtils.DeSerialize<ListReadWriteRatioResponse>);
        }
        
        /// <summary>
        /// 慢日志监控
        ///
        /// 查询指定时间段内在DDM实例上执行过的慢sql相关信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSlowLogResponse> ListSlowLogAsync(ListSlowLogRequest listSlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSlowLogResponse>(response);
        }

        public AsyncInvoker<ListSlowLogResponse> ListSlowLogAsyncInvoker(ListSlowLogRequest listSlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/slowlog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogRequest);
            return new AsyncInvoker<ListSlowLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSlowLogResponse>);
        }
        
        /// <summary>
        /// 慢日志监控
        ///
        /// 查询指定时间段内在DDM实例上执行过的慢sql相关信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSlowLogsResponse> ListSlowLogsAsync(ListSlowLogsRequest listSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSlowLogsResponse>(response);
        }

        public AsyncInvoker<ListSlowLogsResponse> ListSlowLogsAsyncInvoker(ListSlowLogsRequest listSlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listSlowLogsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/slow-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSlowLogsRequest);
            return new AsyncInvoker<ListSlowLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSlowLogsResponse>);
        }
        
        /// <summary>
        /// 查询DDM帐号列表
        ///
        /// 查询DDM帐号列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUsersResponse>(response);
        }

        public AsyncInvoker<ListUsersResponse> ListUsersAsyncInvoker(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            return new AsyncInvoker<ListUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsersResponse>);
        }
        
        /// <summary>
        /// DDM表数据重载
        ///
        /// DDM实例跨region容灾场景下，针对目标DDM实例实现表数据reload，使数据同步。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RebuildConfigResponse> RebuildConfigAsync(RebuildConfigRequest rebuildConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", rebuildConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/reload-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebuildConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<RebuildConfigResponse>(response);
        }

        public AsyncInvoker<RebuildConfigResponse> RebuildConfigAsyncInvoker(RebuildConfigRequest rebuildConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", rebuildConfigRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/reload-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebuildConfigRequest);
            return new AsyncInvoker<RebuildConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RebuildConfigResponse>);
        }
        
        /// <summary>
        /// DDM管理员账号密码管理
        ///
        /// 首次调用时新建DDM管理员帐号并设置密码。后续调用时仅更新管理员密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetAdministratorResponse> ResetAdministratorAsync(ResetAdministratorRequest resetAdministratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetAdministratorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/admin-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetAdministratorRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetAdministratorResponse>(response);
        }

        public AsyncInvoker<ResetAdministratorResponse> ResetAdministratorAsyncInvoker(ResetAdministratorRequest resetAdministratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetAdministratorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/admin-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetAdministratorRequest);
            return new AsyncInvoker<ResetAdministratorResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetAdministratorResponse>);
        }
        
        /// <summary>
        /// 重置DDM账号密码
        ///
        /// 重置现有DDM帐号的密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetUserPasswordResponse> ResetUserPasswordAsync(ResetUserPasswordRequest resetUserPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetUserPasswordRequest.InstanceId.ToString());
            urlParam.Add("username", resetUserPasswordRequest.Username.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{username}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetUserPasswordRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResetUserPasswordResponse>(response);
        }

        public AsyncInvoker<ResetUserPasswordResponse> ResetUserPasswordAsyncInvoker(ResetUserPasswordRequest resetUserPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetUserPasswordRequest.InstanceId.ToString());
            urlParam.Add("username", resetUserPasswordRequest.Username.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{username}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetUserPasswordRequest);
            return new AsyncInvoker<ResetUserPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetUserPasswordResponse>);
        }
        
        /// <summary>
        /// 变更DDM实例规格
        ///
        /// 变更DDM实例规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResizeFlavorResponse> ResizeFlavorAsync(ResizeFlavorRequest resizeFlavorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeFlavorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/flavor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeFlavorRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ResizeFlavorResponse>(response);
        }

        public AsyncInvoker<ResizeFlavorResponse> ResizeFlavorAsyncInvoker(ResizeFlavorRequest resizeFlavorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeFlavorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/flavor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeFlavorRequest);
            return new AsyncInvoker<ResizeFlavorResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResizeFlavorResponse>);
        }
        
        /// <summary>
        /// 重启DDM实例
        ///
        /// 重启指定的DDM实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestartInstanceResponse> RestartInstanceAsync(RestartInstanceRequest restartInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restartInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RestartInstanceResponse>(response);
        }

        public AsyncInvoker<RestartInstanceResponse> RestartInstanceAsyncInvoker(RestartInstanceRequest restartInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restartInstanceRequest);
            return new AsyncInvoker<RestartInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestartInstanceResponse>);
        }
        
        /// <summary>
        /// 查询DDM逻辑库详细信息
        ///
        /// 查询指定逻辑库的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDatabaseResponse> ShowDatabaseAsync(ShowDatabaseRequest showDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showDatabaseRequest.InstanceId.ToString());
            urlParam.Add("ddm_dbname", showDatabaseRequest.DdmDbname.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/databases/{ddm_dbname}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDatabaseRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDatabaseResponse>(response);
        }

        public AsyncInvoker<ShowDatabaseResponse> ShowDatabaseAsyncInvoker(ShowDatabaseRequest showDatabaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showDatabaseRequest.InstanceId.ToString());
            urlParam.Add("ddm_dbname", showDatabaseRequest.DdmDbname.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/databases/{ddm_dbname}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDatabaseRequest);
            return new AsyncInvoker<ShowDatabaseResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDatabaseResponse>);
        }
        
        /// <summary>
        /// 获取指定ID的任务信息
        ///
        /// 获取指定ID的任务信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDdmJobResultResponse> ShowDdmJobResultAsync(ShowDdmJobResultRequest showDdmJobResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDdmJobResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDdmJobResultRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDdmJobResultResponse>(response);
        }

        public AsyncInvoker<ShowDdmJobResultResponse> ShowDdmJobResultAsyncInvoker(ShowDdmJobResultRequest showDdmJobResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDdmJobResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDdmJobResultRequest);
            return new AsyncInvoker<ShowDdmJobResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDdmJobResultResponse>);
        }
        
        /// <summary>
        /// 查询DDM实例详情
        ///
        /// 查询指定DDM实例的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceResponse> ShowInstanceAsync(ShowInstanceRequest showInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceResponse>(response);
        }

        public AsyncInvoker<ShowInstanceResponse> ShowInstanceAsyncInvoker(ShowInstanceRequest showInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            return new AsyncInvoker<ShowInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceResponse>);
        }
        
        /// <summary>
        /// 查询DDM指定实例的参数详情
        ///
        /// 查询DDM指定实例的参数详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceParamResponse> ShowInstanceParamAsync(ShowInstanceParamRequest showInstanceParamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceParamRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceParamRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceParamResponse>(response);
        }

        public AsyncInvoker<ShowInstanceParamResponse> ShowInstanceParamAsyncInvoker(ShowInstanceParamRequest showInstanceParamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceParamRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceParamRequest);
            return new AsyncInvoker<ShowInstanceParamResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceParamResponse>);
        }
        
        /// <summary>
        /// 查询逻辑会话列表
        ///
        /// 查询逻辑会话列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLogicalProcessesResponse> ShowLogicalProcessesAsync(ShowLogicalProcessesRequest showLogicalProcessesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showLogicalProcessesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/logical-processes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogicalProcessesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLogicalProcessesResponse>(response);
        }

        public AsyncInvoker<ShowLogicalProcessesResponse> ShowLogicalProcessesAsyncInvoker(ShowLogicalProcessesRequest showLogicalProcessesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showLogicalProcessesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/logical-processes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogicalProcessesRequest);
            return new AsyncInvoker<ShowLogicalProcessesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLogicalProcessesResponse>);
        }
        
        /// <summary>
        /// 查询DDM实例节点详情
        ///
        /// 查询DDM实例节点详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNodeResponse> ShowNodeAsync(ShowNodeRequest showNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showNodeRequest.InstanceId.ToString());
            urlParam.Add("node_id", showNodeRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNodeResponse>(response);
        }

        public AsyncInvoker<ShowNodeResponse> ShowNodeAsyncInvoker(ShowNodeRequest showNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showNodeRequest.InstanceId.ToString());
            urlParam.Add("node_id", showNodeRequest.NodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/nodes/{node_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodeRequest);
            return new AsyncInvoker<ShowNodeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNodeResponse>);
        }
        
        /// <summary>
        /// 查询物理会话列表
        ///
        /// 查询物理会话列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPhysicalProcessesResponse> ShowPhysicalProcessesAsync(ShowPhysicalProcessesRequest showPhysicalProcessesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPhysicalProcessesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/physical-processes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPhysicalProcessesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPhysicalProcessesResponse>(response);
        }

        public AsyncInvoker<ShowPhysicalProcessesResponse> ShowPhysicalProcessesAsyncInvoker(ShowPhysicalProcessesRequest showPhysicalProcessesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPhysicalProcessesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/physical-processes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPhysicalProcessesRequest);
            return new AsyncInvoker<ShowPhysicalProcessesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPhysicalProcessesResponse>);
        }
        
        /// <summary>
        /// 查询kill会话审计日志
        ///
        /// 查询kill会话审计日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProcessesAuditLogResponse> ShowProcessesAuditLogAsync(ShowProcessesAuditLogRequest showProcessesAuditLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showProcessesAuditLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/processes-audit-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProcessesAuditLogRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProcessesAuditLogResponse>(response);
        }

        public AsyncInvoker<ShowProcessesAuditLogResponse> ShowProcessesAuditLogAsyncInvoker(ShowProcessesAuditLogRequest showProcessesAuditLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showProcessesAuditLogRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/processes-audit-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProcessesAuditLogRequest);
            return new AsyncInvoker<ShowProcessesAuditLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProcessesAuditLogResponse>);
        }
        
        /// <summary>
        /// DDM实例节点缩容
        ///
        /// 对指定的DDM实例的节点个数进行缩容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShrinkInstanceNodesResponse> ShrinkInstanceNodesAsync(ShrinkInstanceNodesRequest shrinkInstanceNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", shrinkInstanceNodesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/action/reduce", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", shrinkInstanceNodesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShrinkInstanceNodesResponse>(response);
        }

        public AsyncInvoker<ShrinkInstanceNodesResponse> ShrinkInstanceNodesAsyncInvoker(ShrinkInstanceNodesRequest shrinkInstanceNodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", shrinkInstanceNodesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/action/reduce", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", shrinkInstanceNodesRequest);
            return new AsyncInvoker<ShrinkInstanceNodesResponse>(this, "POST", request, JsonUtils.DeSerialize<ShrinkInstanceNodesResponse>);
        }
        
        /// <summary>
        /// 为实例设置SSL数据加密
        ///
        /// 为实例设置SSL数据加密。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchSslResponse> SwitchSslAsync(SwitchSslRequest switchSslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSslRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switch-ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchSslRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SwitchSslResponse>(response);
        }

        public AsyncInvoker<SwitchSslResponse> SwitchSslAsyncInvoker(SwitchSslRequest switchSslRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", switchSslRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/switch-ssl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchSslRequest);
            return new AsyncInvoker<SwitchSslResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SwitchSslResponse>);
        }
        
        /// <summary>
        /// 同步DN信息
        ///
        /// 同步当前DDM实例已关联的所有DN实例配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDatabaseInfoResponse> UpdateDatabaseInfoAsync(UpdateDatabaseInfoRequest updateDatabaseInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateDatabaseInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/rds/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDatabaseInfoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateDatabaseInfoResponse>(response);
        }

        public AsyncInvoker<UpdateDatabaseInfoResponse> UpdateDatabaseInfoAsyncInvoker(UpdateDatabaseInfoRequest updateDatabaseInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateDatabaseInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/rds/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDatabaseInfoRequest);
            return new AsyncInvoker<UpdateDatabaseInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateDatabaseInfoResponse>);
        }
        
        /// <summary>
        /// 修改DDM实例名称
        ///
        /// 修改DDM实例名称。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceNameResponse> UpdateInstanceNameAsync(UpdateInstanceNameRequest updateInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/modify-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceNameRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceNameResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceNameResponse> UpdateInstanceNameAsyncInvoker(UpdateInstanceNameRequest updateInstanceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceNameRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/modify-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceNameRequest);
            return new AsyncInvoker<UpdateInstanceNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceNameResponse>);
        }
        
        /// <summary>
        /// 修改DDM实例参数
        ///
        /// 修改DDM实例参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceParamResponse> UpdateInstanceParamAsync(UpdateInstanceParamRequest updateInstanceParamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceParamRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceParamRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceParamResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceParamResponse> UpdateInstanceParamAsyncInvoker(UpdateInstanceParamRequest updateInstanceParamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceParamRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceParamRequest);
            return new AsyncInvoker<UpdateInstanceParamResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceParamResponse>);
        }
        
        /// <summary>
        /// 修改实例端口
        ///
        /// 修改实例端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstancePortResponse> UpdateInstancePortAsync(UpdateInstancePortRequest updateInstancePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstancePortRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstancePortRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstancePortResponse>(response);
        }

        public AsyncInvoker<UpdateInstancePortResponse> UpdateInstancePortAsyncInvoker(UpdateInstancePortRequest updateInstancePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstancePortRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/instances/{instance_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstancePortRequest);
            return new AsyncInvoker<UpdateInstancePortResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstancePortResponse>);
        }
        
        /// <summary>
        /// 修改DDM实例安全组
        ///
        /// 修改DDM实例安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceSecurityGroupResponse> UpdateInstanceSecurityGroupAsync(UpdateInstanceSecurityGroupRequest updateInstanceSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceSecurityGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/modify-security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceSecurityGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceSecurityGroupResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceSecurityGroupResponse> UpdateInstanceSecurityGroupAsyncInvoker(UpdateInstanceSecurityGroupRequest updateInstanceSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceSecurityGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/modify-security-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateInstanceSecurityGroupRequest);
            return new AsyncInvoker<UpdateInstanceSecurityGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 修改DDM已关联的数据库实例的读策略
        ///
        /// 修改DDM已关联的数据库实例的读策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateReadAndWriteStrategyResponse> UpdateReadAndWriteStrategyAsync(UpdateReadAndWriteStrategyRequest updateReadAndWriteStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateReadAndWriteStrategyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/action/read-write-strategy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateReadAndWriteStrategyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateReadAndWriteStrategyResponse>(response);
        }

        public AsyncInvoker<UpdateReadAndWriteStrategyResponse> UpdateReadAndWriteStrategyAsyncInvoker(UpdateReadAndWriteStrategyRequest updateReadAndWriteStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateReadAndWriteStrategyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/action/read-write-strategy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateReadAndWriteStrategyRequest);
            return new AsyncInvoker<UpdateReadAndWriteStrategyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateReadAndWriteStrategyResponse>);
        }
        
        /// <summary>
        /// 修改DDM帐号
        ///
        /// 修改现有DDM帐号的权限或者与逻辑库的管理关系。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateUserRequest.InstanceId.ToString());
            urlParam.Add("username", updateUserRequest.Username.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/users/{username}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateUserResponse>(response);
        }

        public AsyncInvoker<UpdateUserResponse> UpdateUserAsyncInvoker(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateUserRequest.InstanceId.ToString());
            urlParam.Add("username", updateUserRequest.Username.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/users/{username}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserRequest);
            return new AsyncInvoker<UpdateUserResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateUserResponse>);
        }
        
        /// <summary>
        /// 弱密码校验
        ///
        /// 弱密码校验
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
        
    }
}