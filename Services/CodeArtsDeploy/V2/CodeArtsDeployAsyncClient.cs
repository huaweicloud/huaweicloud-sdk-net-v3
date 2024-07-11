using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CodeArtsDeploy.V2.Model;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2
{
    public partial class CodeArtsDeployAsyncClient : Client
    {
        public static ClientBuilder<CodeArtsDeployAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CodeArtsDeployAsyncClient>();
        }

        
        /// <summary>
        /// 创建分组
        ///
        /// 创建分组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAppGroupsResponse> CreateAppGroupsAsync(CreateAppGroupsRequest createAppGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", createAppGroupsRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppGroupsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAppGroupsResponse>(response);
        }

        public AsyncInvoker<CreateAppGroupsResponse> CreateAppGroupsAsyncInvoker(CreateAppGroupsRequest createAppGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", createAppGroupsRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppGroupsRequest);
            return new AsyncInvoker<CreateAppGroupsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAppGroupsResponse>);
        }
        
        /// <summary>
        /// 删除分组
        ///
        /// 删除分组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAppGroupsResponse> DeleteAppGroupsAsync(DeleteAppGroupsRequest deleteAppGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", deleteAppGroupsRequest.ProjectId.ToString());
            urlParam.Add("group_id", deleteAppGroupsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppGroupsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAppGroupsResponse>(response);
        }

        public AsyncInvoker<DeleteAppGroupsResponse> DeleteAppGroupsAsyncInvoker(DeleteAppGroupsRequest deleteAppGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", deleteAppGroupsRequest.ProjectId.ToString());
            urlParam.Add("group_id", deleteAppGroupsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppGroupsRequest);
            return new AsyncInvoker<DeleteAppGroupsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAppGroupsResponse>);
        }
        
        /// <summary>
        /// 查询分组列表
        ///
        /// 查询分组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAppGroupsResponse> ListAppGroupsAsync(ListAppGroupsRequest listAppGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listAppGroupsRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAppGroupsResponse>(response);
        }

        public AsyncInvoker<ListAppGroupsResponse> ListAppGroupsAsyncInvoker(ListAppGroupsRequest listAppGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listAppGroupsRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppGroupsRequest);
            return new AsyncInvoker<ListAppGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppGroupsResponse>);
        }
        
        /// <summary>
        /// 移动分组
        ///
        /// 往上或者往下移动单个分组,用来在页面上调整分组位置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<MoveAppGroupsResponse> MoveAppGroupsAsync(MoveAppGroupsRequest moveAppGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", moveAppGroupsRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups/swap", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", moveAppGroupsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<MoveAppGroupsResponse>(response);
        }

        public AsyncInvoker<MoveAppGroupsResponse> MoveAppGroupsAsyncInvoker(MoveAppGroupsRequest moveAppGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", moveAppGroupsRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups/swap", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", moveAppGroupsRequest);
            return new AsyncInvoker<MoveAppGroupsResponse>(this, "PUT", request, JsonUtils.DeSerialize<MoveAppGroupsResponse>);
        }
        
        /// <summary>
        /// 移动应用至指定分组
        ///
        /// 将应用移动至指定分组（支持批量）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<MoveAppToGroupResponse> MoveAppToGroupAsync(MoveAppToGroupRequest moveAppToGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", moveAppToGroupRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups/move", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", moveAppToGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<MoveAppToGroupResponse>(response);
        }

        public AsyncInvoker<MoveAppToGroupResponse> MoveAppToGroupAsyncInvoker(MoveAppToGroupRequest moveAppToGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", moveAppToGroupRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups/move", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", moveAppToGroupRequest);
            return new AsyncInvoker<MoveAppToGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<MoveAppToGroupResponse>);
        }
        
        /// <summary>
        /// 修改分组
        ///
        /// 修改分组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAppGroupsResponse> UpdateAppGroupsAsync(UpdateAppGroupsRequest updateAppGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", updateAppGroupsRequest.ProjectId.ToString());
            urlParam.Add("group_id", updateAppGroupsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppGroupsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAppGroupsResponse>(response);
        }

        public AsyncInvoker<UpdateAppGroupsResponse> UpdateAppGroupsAsyncInvoker(UpdateAppGroupsRequest updateAppGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", updateAppGroupsRequest.ProjectId.ToString());
            urlParam.Add("group_id", updateAppGroupsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppGroupsRequest);
            return new AsyncInvoker<UpdateAppGroupsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAppGroupsResponse>);
        }
        
        /// <summary>
        /// 批量修改应用权限
        ///
        /// 批量修改应用权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateApplicationPermissionsResponse> BatchUpdateApplicationPermissionsAsync(BatchUpdateApplicationPermissionsRequest batchUpdateApplicationPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/applications/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateApplicationPermissionsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateApplicationPermissionsResponse>(response);
        }

        public AsyncInvoker<BatchUpdateApplicationPermissionsResponse> BatchUpdateApplicationPermissionsAsyncInvoker(BatchUpdateApplicationPermissionsRequest batchUpdateApplicationPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/applications/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateApplicationPermissionsRequest);
            return new AsyncInvoker<BatchUpdateApplicationPermissionsResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateApplicationPermissionsResponse>);
        }
        
        /// <summary>
        /// 批量配置应用下鉴权级别
        ///
        /// 批量配置应用下鉴权级别为项目级或实例级。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdatePermissionLevelResponse> BatchUpdatePermissionLevelAsync(BatchUpdatePermissionLevelRequest batchUpdatePermissionLevelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/applications/permission-level", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdatePermissionLevelRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdatePermissionLevelResponse>(response);
        }

        public AsyncInvoker<BatchUpdatePermissionLevelResponse> BatchUpdatePermissionLevelAsyncInvoker(BatchUpdatePermissionLevelRequest batchUpdatePermissionLevelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/applications/permission-level", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdatePermissionLevelRequest);
            return new AsyncInvoker<BatchUpdatePermissionLevelResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdatePermissionLevelResponse>);
        }
        
        /// <summary>
        /// 查询当前用户是否有项目下创建应用权限
        ///
        /// 查询当前用户是否有项目下创建应用权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckCanCreateResponse> CheckCanCreateAsync(CheckCanCreateRequest checkCanCreateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/creatable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkCanCreateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CheckCanCreateResponse>(response);
        }

        public AsyncInvoker<CheckCanCreateResponse> CheckCanCreateAsyncInvoker(CheckCanCreateRequest checkCanCreateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/creatable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkCanCreateRequest);
            return new AsyncInvoker<CheckCanCreateResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckCanCreateResponse>);
        }
        
        /// <summary>
        /// 查询应用实例级/项目级权限矩阵
        ///
        /// 查询应用实例级/项目级权限矩阵，传递app_id时，查询应用实例级权限矩阵；未传app_id，传递project_id时，查询应用项目级权限矩阵。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApplicationPermissionsResponse> ListApplicationPermissionsAsync(ListApplicationPermissionsRequest listApplicationPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/applications/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationPermissionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationPermissionsResponse>(response);
        }

        public AsyncInvoker<ListApplicationPermissionsResponse> ListApplicationPermissionsAsyncInvoker(ListApplicationPermissionsRequest listApplicationPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/applications/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationPermissionsRequest);
            return new AsyncInvoker<ListApplicationPermissionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationPermissionsResponse>);
        }
        
        /// <summary>
        /// 批量删除项目下应用
        ///
        /// 批量删除项目下应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteAppResponse> BatchDeleteAppAsync(BatchDeleteAppRequest batchDeleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/applications/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteAppResponse>(response);
        }

        public AsyncInvoker<BatchDeleteAppResponse> BatchDeleteAppAsyncInvoker(BatchDeleteAppRequest batchDeleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/applications/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppRequest);
            return new AsyncInvoker<BatchDeleteAppResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteAppResponse>);
        }
        
        /// <summary>
        /// 查询项目下是否存在同名应用
        ///
        /// 查询项目下是否存在同名应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckIsDuplicateAppNameResponse> CheckIsDuplicateAppNameAsync(CheckIsDuplicateAppNameRequest checkIsDuplicateAppNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/exist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkIsDuplicateAppNameRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CheckIsDuplicateAppNameResponse>(response);
        }

        public AsyncInvoker<CheckIsDuplicateAppNameResponse> CheckIsDuplicateAppNameAsyncInvoker(CheckIsDuplicateAppNameRequest checkIsDuplicateAppNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/exist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkIsDuplicateAppNameRequest);
            return new AsyncInvoker<CheckIsDuplicateAppNameResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckIsDuplicateAppNameResponse>);
        }
        
        /// <summary>
        /// 复制应用
        ///
        /// 复制应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CopyApplicationResponse> CopyApplicationAsync(CopyApplicationRequest copyApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", copyApplicationRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}/duplicate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyApplicationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CopyApplicationResponse>(response);
        }

        public AsyncInvoker<CopyApplicationResponse> CopyApplicationAsyncInvoker(CopyApplicationRequest copyApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", copyApplicationRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}/duplicate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyApplicationRequest);
            return new AsyncInvoker<CopyApplicationResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyApplicationResponse>);
        }
        
        /// <summary>
        /// 新建应用
        ///
        /// 新建应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAppResponse> CreateAppAsync(CreateAppRequest createAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAppResponse>(response);
        }

        public AsyncInvoker<CreateAppResponse> CreateAppAsyncInvoker(CreateAppRequest createAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            return new AsyncInvoker<CreateAppResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAppResponse>);
        }
        
        /// <summary>
        /// 通过模板新建应用
        ///
        /// 通过模板新建应用。该接口于2024年09月30日后不再维护，推荐使用新版CreateApp接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDeployTaskByTemplateResponse> CreateDeployTaskByTemplateAsync(CreateDeployTaskByTemplateRequest createDeployTaskByTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/template-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeployTaskByTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDeployTaskByTemplateResponse>(response);
        }

        public AsyncInvoker<CreateDeployTaskByTemplateResponse> CreateDeployTaskByTemplateAsyncInvoker(CreateDeployTaskByTemplateRequest createDeployTaskByTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/template-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeployTaskByTemplateRequest);
            return new AsyncInvoker<CreateDeployTaskByTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDeployTaskByTemplateResponse>);
        }
        
        /// <summary>
        /// 删除应用
        ///
        /// 根据应用id删除应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest deleteApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", deleteApplicationRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteApplicationResponse>(response);
        }

        public AsyncInvoker<DeleteApplicationResponse> DeleteApplicationAsyncInvoker(DeleteApplicationRequest deleteApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", deleteApplicationRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            return new AsyncInvoker<DeleteApplicationResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteApplicationResponse>);
        }
        
        /// <summary>
        /// 删除应用
        ///
        /// 根据部署任务id删除应用。该接口于2024年09月30日后不再维护，推荐使用新版DeleteApplication接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDeployTaskResponse> DeleteDeployTaskAsync(DeleteDeployTaskRequest deleteDeployTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", deleteDeployTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeployTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDeployTaskResponse>(response);
        }

        public AsyncInvoker<DeleteDeployTaskResponse> DeleteDeployTaskAsyncInvoker(DeleteDeployTaskRequest deleteDeployTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", deleteDeployTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeployTaskRequest);
            return new AsyncInvoker<DeleteDeployTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDeployTaskResponse>);
        }
        
        /// <summary>
        /// 获取应用列表
        ///
        /// 查询项目下应用列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAllAppResponse> ListAllAppAsync(ListAllAppRequest listAllAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllAppRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAllAppResponse>(response);
        }

        public AsyncInvoker<ListAllAppResponse> ListAllAppAsyncInvoker(ListAllAppRequest listAllAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllAppRequest);
            return new AsyncInvoker<ListAllAppResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAllAppResponse>);
        }
        
        /// <summary>
        /// 根据开始时间和结束时间查询项目下指定应用的历史部署记录列表
        ///
        /// 根据开始时间和结束时间查询项目下指定应用的历史部署记录列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDeployTaskHistoryByDateResponse> ListDeployTaskHistoryByDateAsync(ListDeployTaskHistoryByDateRequest listDeployTaskHistoryByDateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listDeployTaskHistoryByDateRequest.ProjectId.ToString());
            urlParam.Add("id", listDeployTaskHistoryByDateRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/task/{id}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeployTaskHistoryByDateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDeployTaskHistoryByDateResponse>(response);
        }

        public AsyncInvoker<ListDeployTaskHistoryByDateResponse> ListDeployTaskHistoryByDateAsyncInvoker(ListDeployTaskHistoryByDateRequest listDeployTaskHistoryByDateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listDeployTaskHistoryByDateRequest.ProjectId.ToString());
            urlParam.Add("id", listDeployTaskHistoryByDateRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/task/{id}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeployTaskHistoryByDateRequest);
            return new AsyncInvoker<ListDeployTaskHistoryByDateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDeployTaskHistoryByDateResponse>);
        }
        
        /// <summary>
        /// 获取应用列表
        ///
        /// 查询项目下应用列表。该接口于2024年09月30日后不再维护，推荐使用新版ListAllApp接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDeployTasksResponse> ListDeployTasksAsync(ListDeployTasksRequest listDeployTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listDeployTasksRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeployTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDeployTasksResponse>(response);
        }

        public AsyncInvoker<ListDeployTasksResponse> ListDeployTasksAsyncInvoker(ListDeployTasksRequest listDeployTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listDeployTasksRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeployTasksRequest);
            return new AsyncInvoker<ListDeployTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDeployTasksResponse>);
        }
        
        /// <summary>
        /// 获取应用详情
        ///
        /// 根据应用id获取应用详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAppDetailByIdResponse> ShowAppDetailByIdAsync(ShowAppDetailByIdRequest showAppDetailByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", showAppDetailByIdRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppDetailByIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAppDetailByIdResponse>(response);
        }

        public AsyncInvoker<ShowAppDetailByIdResponse> ShowAppDetailByIdAsyncInvoker(ShowAppDetailByIdRequest showAppDetailByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", showAppDetailByIdRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppDetailByIdRequest);
            return new AsyncInvoker<ShowAppDetailByIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppDetailByIdResponse>);
        }
        
        /// <summary>
        /// 获取应用详情
        ///
        /// 根据部署任务id获取应用详情。该接口于2024年09月30日后不再维护，推荐使用新版ShowAppDetailById接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDeployTaskDetailResponse> ShowDeployTaskDetailAsync(ShowDeployTaskDetailRequest showDeployTaskDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", showDeployTaskDetailRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeployTaskDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDeployTaskDetailResponse>(response);
        }

        public AsyncInvoker<ShowDeployTaskDetailResponse> ShowDeployTaskDetailAsyncInvoker(ShowDeployTaskDetailRequest showDeployTaskDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", showDeployTaskDetailRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeployTaskDetailRequest);
            return new AsyncInvoker<ShowDeployTaskDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeployTaskDetailResponse>);
        }
        
        /// <summary>
        /// 查询部署记录的执行参数
        ///
        /// 查询部署记录的执行参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowExecutionParamsResponse> ShowExecutionParamsAsync(ShowExecutionParamsRequest showExecutionParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", showExecutionParamsRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/history/tasks/{task_id}/params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExecutionParamsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showExecutionParamsResponse = JsonUtils.DeSerializeNull<ShowExecutionParamsResponse>(response);
            showExecutionParamsResponse.Body = JsonUtils.DeSerializeList<ConfigInfo>(response);
            return showExecutionParamsResponse;
        }

        public AsyncInvoker<ShowExecutionParamsResponse> ShowExecutionParamsAsyncInvoker(ShowExecutionParamsRequest showExecutionParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", showExecutionParamsRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/history/tasks/{task_id}/params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExecutionParamsRequest);
            return new AsyncInvoker<ShowExecutionParamsResponse>(this, "GET", request, response =>
            {
                var showExecutionParamsResponse = JsonUtils.DeSerializeNull<ShowExecutionParamsResponse>(response);
                showExecutionParamsResponse.Body = JsonUtils.DeSerializeList<ConfigInfo>(response);
                return showExecutionParamsResponse;
            });
        }
        
        /// <summary>
        /// 部署应用
        ///
        /// 根据部署任务id部署应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartDeployTaskResponse> StartDeployTaskAsync(StartDeployTaskRequest startDeployTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", startDeployTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDeployTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartDeployTaskResponse>(response);
        }

        public AsyncInvoker<StartDeployTaskResponse> StartDeployTaskAsyncInvoker(StartDeployTaskRequest startDeployTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", startDeployTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDeployTaskRequest);
            return new AsyncInvoker<StartDeployTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<StartDeployTaskResponse>);
        }
        
        /// <summary>
        /// 禁用/取消禁用应用
        ///
        /// 禁用/取消禁用应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAppDisableStatusResponse> UpdateAppDisableStatusAsync(UpdateAppDisableStatusRequest updateAppDisableStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateAppDisableStatusRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppDisableStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAppDisableStatusResponse>(response);
        }

        public AsyncInvoker<UpdateAppDisableStatusResponse> UpdateAppDisableStatusAsyncInvoker(UpdateAppDisableStatusRequest updateAppDisableStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateAppDisableStatusRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppDisableStatusRequest);
            return new AsyncInvoker<UpdateAppDisableStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAppDisableStatusResponse>);
        }
        
        /// <summary>
        /// 更新应用
        ///
        /// 更新应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAppInfoResponse> UpdateAppInfoAsync(UpdateAppInfoRequest updateAppInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppInfoRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAppInfoResponse>(response);
        }

        public AsyncInvoker<UpdateAppInfoResponse> UpdateAppInfoAsyncInvoker(UpdateAppInfoRequest updateAppInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppInfoRequest);
            return new AsyncInvoker<UpdateAppInfoResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAppInfoResponse>);
        }
        
        /// <summary>
        /// 应用下创建环境
        ///
        /// 应用下创建环境。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest createEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", createEnvironmentRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEnvironmentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateEnvironmentResponse>(response);
        }

        public AsyncInvoker<CreateEnvironmentResponse> CreateEnvironmentAsyncInvoker(CreateEnvironmentRequest createEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", createEnvironmentRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEnvironmentRequest);
            return new AsyncInvoker<CreateEnvironmentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEnvironmentResponse>);
        }
        
        /// <summary>
        /// 删除应用下的环境
        ///
        /// 删除应用下的环境。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(DeleteEnvironmentRequest deleteEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", deleteEnvironmentRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", deleteEnvironmentRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnvironmentRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteEnvironmentResponse>(response);
        }

        public AsyncInvoker<DeleteEnvironmentResponse> DeleteEnvironmentAsyncInvoker(DeleteEnvironmentRequest deleteEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", deleteEnvironmentRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", deleteEnvironmentRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnvironmentRequest);
            return new AsyncInvoker<DeleteEnvironmentResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteEnvironmentResponse>);
        }
        
        /// <summary>
        /// 环境下删除主机
        ///
        /// 环境下删除主机。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteHostFromEnvironmentResponse> DeleteHostFromEnvironmentAsync(DeleteHostFromEnvironmentRequest deleteHostFromEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", deleteHostFromEnvironmentRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", deleteHostFromEnvironmentRequest.EnvironmentId.ToString());
            urlParam.Add("host_id", deleteHostFromEnvironmentRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHostFromEnvironmentRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteHostFromEnvironmentResponse>(response);
        }

        public AsyncInvoker<DeleteHostFromEnvironmentResponse> DeleteHostFromEnvironmentAsyncInvoker(DeleteHostFromEnvironmentRequest deleteHostFromEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", deleteHostFromEnvironmentRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", deleteHostFromEnvironmentRequest.EnvironmentId.ToString());
            urlParam.Add("host_id", deleteHostFromEnvironmentRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHostFromEnvironmentRequest);
            return new AsyncInvoker<DeleteHostFromEnvironmentResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteHostFromEnvironmentResponse>);
        }
        
        /// <summary>
        /// 环境下导入主机
        ///
        /// 环境下导入主机。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ImportHostToEnvironmentResponse> ImportHostToEnvironmentAsync(ImportHostToEnvironmentRequest importHostToEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", importHostToEnvironmentRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", importHostToEnvironmentRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}/hosts/import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importHostToEnvironmentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ImportHostToEnvironmentResponse>(response);
        }

        public AsyncInvoker<ImportHostToEnvironmentResponse> ImportHostToEnvironmentAsyncInvoker(ImportHostToEnvironmentRequest importHostToEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", importHostToEnvironmentRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", importHostToEnvironmentRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}/hosts/import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importHostToEnvironmentRequest);
            return new AsyncInvoker<ImportHostToEnvironmentResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportHostToEnvironmentResponse>);
        }
        
        /// <summary>
        /// 查询环境内的主机列表
        ///
        /// 查询环境内的主机列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEnvironmentHostsResponse> ListEnvironmentHostsAsync(ListEnvironmentHostsRequest listEnvironmentHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", listEnvironmentHostsRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", listEnvironmentHostsRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvironmentHostsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEnvironmentHostsResponse>(response);
        }

        public AsyncInvoker<ListEnvironmentHostsResponse> ListEnvironmentHostsAsyncInvoker(ListEnvironmentHostsRequest listEnvironmentHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", listEnvironmentHostsRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", listEnvironmentHostsRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvironmentHostsRequest);
            return new AsyncInvoker<ListEnvironmentHostsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEnvironmentHostsResponse>);
        }
        
        /// <summary>
        /// 查询应用下环境列表
        ///
        /// 查询应用下环境列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest listEnvironmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", listEnvironmentsRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvironmentsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEnvironmentsResponse>(response);
        }

        public AsyncInvoker<ListEnvironmentsResponse> ListEnvironmentsAsyncInvoker(ListEnvironmentsRequest listEnvironmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", listEnvironmentsRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvironmentsRequest);
            return new AsyncInvoker<ListEnvironmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEnvironmentsResponse>);
        }
        
        /// <summary>
        /// 查询环境详情
        ///
        /// 查询环境详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEnvironmentDetailResponse> ShowEnvironmentDetailAsync(ShowEnvironmentDetailRequest showEnvironmentDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", showEnvironmentDetailRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", showEnvironmentDetailRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvironmentDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowEnvironmentDetailResponse>(response);
        }

        public AsyncInvoker<ShowEnvironmentDetailResponse> ShowEnvironmentDetailAsyncInvoker(ShowEnvironmentDetailRequest showEnvironmentDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", showEnvironmentDetailRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", showEnvironmentDetailRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvironmentDetailRequest);
            return new AsyncInvoker<ShowEnvironmentDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEnvironmentDetailResponse>);
        }
        
        /// <summary>
        /// 应用下编辑环境
        ///
        /// 应用下编辑环境。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest updateEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", updateEnvironmentRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", updateEnvironmentRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEnvironmentRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEnvironmentResponse>(response);
        }

        public AsyncInvoker<UpdateEnvironmentResponse> UpdateEnvironmentAsyncInvoker(UpdateEnvironmentRequest updateEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", updateEnvironmentRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", updateEnvironmentRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEnvironmentRequest);
            return new AsyncInvoker<UpdateEnvironmentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEnvironmentResponse>);
        }
        
        /// <summary>
        /// 查询环境权限
        ///
        /// 查询环境权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEnvironmentPermissionsResponse> ListEnvironmentPermissionsAsync(ListEnvironmentPermissionsRequest listEnvironmentPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", listEnvironmentPermissionsRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", listEnvironmentPermissionsRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/applications/{application_id}/environments/{environment_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvironmentPermissionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listEnvironmentPermissionsResponse = JsonUtils.DeSerializeNull<ListEnvironmentPermissionsResponse>(response);
            listEnvironmentPermissionsResponse.Body = JsonUtils.DeSerializeList<DevUcEnvironmentPermission>(response);
            return listEnvironmentPermissionsResponse;
        }

        public AsyncInvoker<ListEnvironmentPermissionsResponse> ListEnvironmentPermissionsAsyncInvoker(ListEnvironmentPermissionsRequest listEnvironmentPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", listEnvironmentPermissionsRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", listEnvironmentPermissionsRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/applications/{application_id}/environments/{environment_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvironmentPermissionsRequest);
            return new AsyncInvoker<ListEnvironmentPermissionsResponse>(this, "GET", request, response =>
            {
                var listEnvironmentPermissionsResponse = JsonUtils.DeSerializeNull<ListEnvironmentPermissionsResponse>(response);
                listEnvironmentPermissionsResponse.Body = JsonUtils.DeSerializeList<DevUcEnvironmentPermission>(response);
                return listEnvironmentPermissionsResponse;
            });
        }
        
        /// <summary>
        /// 编辑环境权限
        ///
        /// 编辑环境权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEnvironmentPermissionResponse> UpdateEnvironmentPermissionAsync(UpdateEnvironmentPermissionRequest updateEnvironmentPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", updateEnvironmentPermissionRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", updateEnvironmentPermissionRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/applications/{application_id}/environments/{environment_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEnvironmentPermissionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEnvironmentPermissionResponse>(response);
        }

        public AsyncInvoker<UpdateEnvironmentPermissionResponse> UpdateEnvironmentPermissionAsyncInvoker(UpdateEnvironmentPermissionRequest updateEnvironmentPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", updateEnvironmentPermissionRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", updateEnvironmentPermissionRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/applications/{application_id}/environments/{environment_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEnvironmentPermissionRequest);
            return new AsyncInvoker<UpdateEnvironmentPermissionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEnvironmentPermissionResponse>);
        }
        
        /// <summary>
        /// 批量删除主机集群下的主机
        ///
        /// 批量删除主机集群下的主机。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteHostsResponse> BatchDeleteHostsAsync(BatchDeleteHostsRequest batchDeleteHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", batchDeleteHostsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteHostsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteHostsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteHostsResponse> BatchDeleteHostsAsyncInvoker(BatchDeleteHostsRequest batchDeleteHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", batchDeleteHostsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteHostsRequest);
            return new AsyncInvoker<BatchDeleteHostsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteHostsResponse>);
        }
        
        /// <summary>
        /// 批量复制主机至目标主机集群
        ///
        /// 批量复制主机至目标主机集群。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CopyHostsToTargetResponse> CopyHostsToTargetAsync(CopyHostsToTargetRequest copyHostsToTargetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", copyHostsToTargetRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/replication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyHostsToTargetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CopyHostsToTargetResponse>(response);
        }

        public AsyncInvoker<CopyHostsToTargetResponse> CopyHostsToTargetAsyncInvoker(CopyHostsToTargetRequest copyHostsToTargetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", copyHostsToTargetRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/replication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyHostsToTargetRequest);
            return new AsyncInvoker<CopyHostsToTargetResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyHostsToTargetResponse>);
        }
        
        /// <summary>
        /// 新建主机
        ///
        /// 在指定主机集群下新建主机。该接口于2024年09月30日后不再维护，推荐使用新版CreateHost接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDeploymentHostResponse> CreateDeploymentHostAsync(CreateDeploymentHostRequest createDeploymentHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", createDeploymentHostRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeploymentHostRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDeploymentHostResponse>(response);
        }

        public AsyncInvoker<CreateDeploymentHostResponse> CreateDeploymentHostAsyncInvoker(CreateDeploymentHostRequest createDeploymentHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", createDeploymentHostRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeploymentHostRequest);
            return new AsyncInvoker<CreateDeploymentHostResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDeploymentHostResponse>);
        }
        
        /// <summary>
        /// 新建主机
        ///
        /// 在指定主机集群下新建主机。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateHostResponse> CreateHostAsync(CreateHostRequest createHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", createHostRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHostRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateHostResponse>(response);
        }

        public AsyncInvoker<CreateHostResponse> CreateHostAsyncInvoker(CreateHostRequest createHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", createHostRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHostRequest);
            return new AsyncInvoker<CreateHostResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHostResponse>);
        }
        
        /// <summary>
        /// 删除主机
        ///
        /// 根据主机id删除主机。该接口于2024年9月30日后不再维护。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDeploymentHostResponse> DeleteDeploymentHostAsync(DeleteDeploymentHostRequest deleteDeploymentHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteDeploymentHostRequest.GroupId.ToString());
            urlParam.Add("host_id", deleteDeploymentHostRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeploymentHostRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDeploymentHostResponse>(response);
        }

        public AsyncInvoker<DeleteDeploymentHostResponse> DeleteDeploymentHostAsyncInvoker(DeleteDeploymentHostRequest deleteDeploymentHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteDeploymentHostRequest.GroupId.ToString());
            urlParam.Add("host_id", deleteDeploymentHostRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeploymentHostRequest);
            return new AsyncInvoker<DeleteDeploymentHostResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDeploymentHostResponse>);
        }
        
        /// <summary>
        /// 删除主机集群下主机
        ///
        /// 根据主机id删除主机集群下主机。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteHostResponse> DeleteHostAsync(DeleteHostRequest deleteHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteHostRequest.GroupId.ToString());
            urlParam.Add("host_id", deleteHostRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHostRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteHostResponse>(response);
        }

        public AsyncInvoker<DeleteHostResponse> DeleteHostAsyncInvoker(DeleteHostRequest deleteHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteHostRequest.GroupId.ToString());
            urlParam.Add("host_id", deleteHostRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHostRequest);
            return new AsyncInvoker<DeleteHostResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteHostResponse>);
        }
        
        /// <summary>
        /// 查询主机列表
        ///
        /// 根据主机集群id查询指定主机集群下的主机列表。该接口于2024年09月30日后不再维护，推荐使用新版ListNewHosts接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHostsResponse> ListHostsAsync(ListHostsRequest listHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listHostsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHostsResponse>(response);
        }

        public AsyncInvoker<ListHostsResponse> ListHostsAsyncInvoker(ListHostsRequest listHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listHostsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostsRequest);
            return new AsyncInvoker<ListHostsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHostsResponse>);
        }
        
        /// <summary>
        /// 查询主机列表
        ///
        /// 根据主机集群id查询指定主机集群下的主机列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNewHostsResponse> ListNewHostsAsync(ListNewHostsRequest listNewHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listNewHostsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNewHostsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNewHostsResponse>(response);
        }

        public AsyncInvoker<ListNewHostsResponse> ListNewHostsAsyncInvoker(ListNewHostsRequest listNewHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listNewHostsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNewHostsRequest);
            return new AsyncInvoker<ListNewHostsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNewHostsResponse>);
        }
        
        /// <summary>
        /// 查询主机详情
        ///
        /// 根据主机id查询主机详情。该接口于2024年09月30日后不再维护，推荐使用新版ShowHostDetail接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDeploymentHostDetailResponse> ShowDeploymentHostDetailAsync(ShowDeploymentHostDetailRequest showDeploymentHostDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", showDeploymentHostDetailRequest.GroupId.ToString());
            urlParam.Add("host_id", showDeploymentHostDetailRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeploymentHostDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDeploymentHostDetailResponse>(response);
        }

        public AsyncInvoker<ShowDeploymentHostDetailResponse> ShowDeploymentHostDetailAsyncInvoker(ShowDeploymentHostDetailRequest showDeploymentHostDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", showDeploymentHostDetailRequest.GroupId.ToString());
            urlParam.Add("host_id", showDeploymentHostDetailRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeploymentHostDetailRequest);
            return new AsyncInvoker<ShowDeploymentHostDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeploymentHostDetailResponse>);
        }
        
        /// <summary>
        /// 查询主机详情
        ///
        /// 根据主机id查询主机详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHostDetailResponse> ShowHostDetailAsync(ShowHostDetailRequest showHostDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", showHostDetailRequest.GroupId.ToString());
            urlParam.Add("host_id", showHostDetailRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHostDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowHostDetailResponse>(response);
        }

        public AsyncInvoker<ShowHostDetailResponse> ShowHostDetailAsyncInvoker(ShowHostDetailRequest showHostDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", showHostDetailRequest.GroupId.ToString());
            urlParam.Add("host_id", showHostDetailRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHostDetailRequest);
            return new AsyncInvoker<ShowHostDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHostDetailResponse>);
        }
        
        /// <summary>
        /// 修改主机
        ///
        /// 根据主机id修改主机信息。该接口于2024年9月30日后不再维护。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDeploymentHostResponse> UpdateDeploymentHostAsync(UpdateDeploymentHostRequest updateDeploymentHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateDeploymentHostRequest.GroupId.ToString());
            urlParam.Add("host_id", updateDeploymentHostRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeploymentHostRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDeploymentHostResponse>(response);
        }

        public AsyncInvoker<UpdateDeploymentHostResponse> UpdateDeploymentHostAsyncInvoker(UpdateDeploymentHostRequest updateDeploymentHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateDeploymentHostRequest.GroupId.ToString());
            urlParam.Add("host_id", updateDeploymentHostRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeploymentHostRequest);
            return new AsyncInvoker<UpdateDeploymentHostResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDeploymentHostResponse>);
        }
        
        /// <summary>
        /// 编辑主机集群下主机信息
        ///
        /// 根据主机id编辑主机集群下主机信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateHostInfoResponse> UpdateHostInfoAsync(UpdateHostInfoRequest updateHostInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateHostInfoRequest.GroupId.ToString());
            urlParam.Add("host_id", updateHostInfoRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHostInfoRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHostInfoResponse>(response);
        }

        public AsyncInvoker<UpdateHostInfoResponse> UpdateHostInfoAsyncInvoker(UpdateHostInfoRequest updateHostInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateHostInfoRequest.GroupId.ToString());
            urlParam.Add("host_id", updateHostInfoRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHostInfoRequest);
            return new AsyncInvoker<UpdateHostInfoResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHostInfoResponse>);
        }
        
        /// <summary>
        /// 新建主机集群
        ///
        /// 在项目下新建主机集群。该接口于2024年09月30日后不再维护，推荐使用新版CreateHostCluster接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDeploymentGroupResponse> CreateDeploymentGroupAsync(CreateDeploymentGroupRequest createDeploymentGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeploymentGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDeploymentGroupResponse>(response);
        }

        public AsyncInvoker<CreateDeploymentGroupResponse> CreateDeploymentGroupAsyncInvoker(CreateDeploymentGroupRequest createDeploymentGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeploymentGroupRequest);
            return new AsyncInvoker<CreateDeploymentGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDeploymentGroupResponse>);
        }
        
        /// <summary>
        /// 新建主机集群
        ///
        /// 在项目下新建主机集群。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateHostClusterResponse> CreateHostClusterAsync(CreateHostClusterRequest createHostClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHostClusterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateHostClusterResponse>(response);
        }

        public AsyncInvoker<CreateHostClusterResponse> CreateHostClusterAsyncInvoker(CreateHostClusterRequest createHostClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHostClusterRequest);
            return new AsyncInvoker<CreateHostClusterResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHostClusterResponse>);
        }
        
        /// <summary>
        /// 删除主机集群
        ///
        /// 根据主机集群id删除主机集群。该接口于2024年9月30日后不再维护。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDeploymentGroupResponse> DeleteDeploymentGroupAsync(DeleteDeploymentGroupRequest deleteDeploymentGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteDeploymentGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeploymentGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDeploymentGroupResponse>(response);
        }

        public AsyncInvoker<DeleteDeploymentGroupResponse> DeleteDeploymentGroupAsyncInvoker(DeleteDeploymentGroupRequest deleteDeploymentGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteDeploymentGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeploymentGroupRequest);
            return new AsyncInvoker<DeleteDeploymentGroupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDeploymentGroupResponse>);
        }
        
        /// <summary>
        /// 删除主机集群
        ///
        /// 根据主机集群id删除主机集群。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteHostClusterResponse> DeleteHostClusterAsync(DeleteHostClusterRequest deleteHostClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteHostClusterRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHostClusterRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteHostClusterResponse>(response);
        }

        public AsyncInvoker<DeleteHostClusterResponse> DeleteHostClusterAsyncInvoker(DeleteHostClusterRequest deleteHostClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteHostClusterRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHostClusterRequest);
            return new AsyncInvoker<DeleteHostClusterResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteHostClusterResponse>);
        }
        
        /// <summary>
        /// 查询主机集群关联环境信息
        ///
        /// 查询主机集群关联环境信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAssociateEnvironmentsInfosResponse> ListAssociateEnvironmentsInfosAsync(ListAssociateEnvironmentsInfosRequest listAssociateEnvironmentsInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listAssociateEnvironmentsInfosRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/environments/infos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociateEnvironmentsInfosRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAssociateEnvironmentsInfosResponse>(response);
        }

        public AsyncInvoker<ListAssociateEnvironmentsInfosResponse> ListAssociateEnvironmentsInfosAsyncInvoker(ListAssociateEnvironmentsInfosRequest listAssociateEnvironmentsInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listAssociateEnvironmentsInfosRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/environments/infos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociateEnvironmentsInfosRequest);
            return new AsyncInvoker<ListAssociateEnvironmentsInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAssociateEnvironmentsInfosResponse>);
        }
        
        /// <summary>
        /// 查询主机集群列表
        ///
        /// 按条件查询主机集群列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHostClustersResponse> ListHostClustersAsync(ListHostClustersRequest listHostClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostClustersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHostClustersResponse>(response);
        }

        public AsyncInvoker<ListHostClustersResponse> ListHostClustersAsyncInvoker(ListHostClustersRequest listHostClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostClustersRequest);
            return new AsyncInvoker<ListHostClustersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHostClustersResponse>);
        }
        
        /// <summary>
        /// 查询应用下环境基本信息列表
        ///
        /// 查询应用下环境基本信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHostGroupBaseInfosResponse> ListHostGroupBaseInfosAsync(ListHostGroupBaseInfosRequest listHostGroupBaseInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", listHostGroupBaseInfosRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/host-groups/base/infos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostGroupBaseInfosRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHostGroupBaseInfosResponse>(response);
        }

        public AsyncInvoker<ListHostGroupBaseInfosResponse> ListHostGroupBaseInfosAsyncInvoker(ListHostGroupBaseInfosRequest listHostGroupBaseInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", listHostGroupBaseInfosRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/host-groups/base/infos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostGroupBaseInfosRequest);
            return new AsyncInvoker<ListHostGroupBaseInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHostGroupBaseInfosResponse>);
        }
        
        /// <summary>
        /// 查询主机集群列表
        ///
        /// 按条件查询主机集群列表。该接口于2024年09月30日后不再维护，推荐使用新版ListHostClusters接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHostGroupsResponse> ListHostGroupsAsync(ListHostGroupsRequest listHostGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHostGroupsResponse>(response);
        }

        public AsyncInvoker<ListHostGroupsResponse> ListHostGroupsAsyncInvoker(ListHostGroupsRequest listHostGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostGroupsRequest);
            return new AsyncInvoker<ListHostGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHostGroupsResponse>);
        }
        
        /// <summary>
        /// 查询主机集群详情
        ///
        /// 根据主机集群id查询主机集群详情。该接口于2024年09月30日后不再维护，推荐使用新版ShowHostClusterDetail接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDeploymentGroupDetailResponse> ShowDeploymentGroupDetailAsync(ShowDeploymentGroupDetailRequest showDeploymentGroupDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", showDeploymentGroupDetailRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeploymentGroupDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDeploymentGroupDetailResponse>(response);
        }

        public AsyncInvoker<ShowDeploymentGroupDetailResponse> ShowDeploymentGroupDetailAsyncInvoker(ShowDeploymentGroupDetailRequest showDeploymentGroupDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", showDeploymentGroupDetailRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeploymentGroupDetailRequest);
            return new AsyncInvoker<ShowDeploymentGroupDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeploymentGroupDetailResponse>);
        }
        
        /// <summary>
        /// 查询主机集群详情
        ///
        /// 根据主机集群id查询主机集群详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHostClusterDetailResponse> ShowHostClusterDetailAsync(ShowHostClusterDetailRequest showHostClusterDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", showHostClusterDetailRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHostClusterDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowHostClusterDetailResponse>(response);
        }

        public AsyncInvoker<ShowHostClusterDetailResponse> ShowHostClusterDetailAsyncInvoker(ShowHostClusterDetailRequest showHostClusterDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", showHostClusterDetailRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHostClusterDetailRequest);
            return new AsyncInvoker<ShowHostClusterDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHostClusterDetailResponse>);
        }
        
        /// <summary>
        /// 修改主机集群
        ///
        /// 根据主机集群id修改主机集群信息。该接口于2024年9月30日后不再维护。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDeploymentGroupResponse> UpdateDeploymentGroupAsync(UpdateDeploymentGroupRequest updateDeploymentGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateDeploymentGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeploymentGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDeploymentGroupResponse>(response);
        }

        public AsyncInvoker<UpdateDeploymentGroupResponse> UpdateDeploymentGroupAsyncInvoker(UpdateDeploymentGroupRequest updateDeploymentGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateDeploymentGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeploymentGroupRequest);
            return new AsyncInvoker<UpdateDeploymentGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDeploymentGroupResponse>);
        }
        
        /// <summary>
        /// 编辑主机集群
        ///
        /// 编辑主机集群。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateHostClusterResponse> UpdateHostClusterAsync(UpdateHostClusterRequest updateHostClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateHostClusterRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHostClusterRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHostClusterResponse>(response);
        }

        public AsyncInvoker<UpdateHostClusterResponse> UpdateHostClusterAsyncInvoker(UpdateHostClusterRequest updateHostClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateHostClusterRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHostClusterRequest);
            return new AsyncInvoker<UpdateHostClusterResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHostClusterResponse>);
        }
        
        /// <summary>
        /// 判断当前用户在项目下是否有权限创建主机集群
        ///
        /// 判断当前用户在项目下是否有权限创建主机集群。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckWhetherHostGroupCanBeCreatedResponse> CheckWhetherHostGroupCanBeCreatedAsync(CheckWhetherHostGroupCanBeCreatedRequest checkWhetherHostGroupCanBeCreatedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", checkWhetherHostGroupCanBeCreatedRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/host-groups/creatable/{project_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkWhetherHostGroupCanBeCreatedRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CheckWhetherHostGroupCanBeCreatedResponse>(response);
        }

        public AsyncInvoker<CheckWhetherHostGroupCanBeCreatedResponse> CheckWhetherHostGroupCanBeCreatedAsyncInvoker(CheckWhetherHostGroupCanBeCreatedRequest checkWhetherHostGroupCanBeCreatedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", checkWhetherHostGroupCanBeCreatedRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/host-groups/creatable/{project_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkWhetherHostGroupCanBeCreatedRequest);
            return new AsyncInvoker<CheckWhetherHostGroupCanBeCreatedResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckWhetherHostGroupCanBeCreatedResponse>);
        }
        
        /// <summary>
        /// 查询主机集群权限矩阵
        ///
        /// 根据主机集群id查询主机集群权限矩阵。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHostGroupPermissionsResponse> ListHostGroupPermissionsAsync(ListHostGroupPermissionsRequest listHostGroupPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listHostGroupPermissionsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostGroupPermissionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listHostGroupPermissionsResponse = JsonUtils.DeSerializeNull<ListHostGroupPermissionsResponse>(response);
            listHostGroupPermissionsResponse.Body = JsonUtils.DeSerializeList<DevUcClusterPermission>(response);
            return listHostGroupPermissionsResponse;
        }

        public AsyncInvoker<ListHostGroupPermissionsResponse> ListHostGroupPermissionsAsyncInvoker(ListHostGroupPermissionsRequest listHostGroupPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listHostGroupPermissionsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostGroupPermissionsRequest);
            return new AsyncInvoker<ListHostGroupPermissionsResponse>(this, "GET", request, response =>
            {
                var listHostGroupPermissionsResponse = JsonUtils.DeSerializeNull<ListHostGroupPermissionsResponse>(response);
                listHostGroupPermissionsResponse.Body = JsonUtils.DeSerializeList<DevUcClusterPermission>(response);
                return listHostGroupPermissionsResponse;
            });
        }
        
        /// <summary>
        /// 修改主机集群权限矩阵
        ///
        /// 根据主机集群id修改主机集群权限矩阵。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateHostGroupPermissionsResponse> UpdateHostGroupPermissionsAsync(UpdateHostGroupPermissionsRequest updateHostGroupPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateHostGroupPermissionsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHostGroupPermissionsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHostGroupPermissionsResponse>(response);
        }

        public AsyncInvoker<UpdateHostGroupPermissionsResponse> UpdateHostGroupPermissionsAsyncInvoker(UpdateHostGroupPermissionsRequest updateHostGroupPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateHostGroupPermissionsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHostGroupPermissionsRequest);
            return new AsyncInvoker<UpdateHostGroupPermissionsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHostGroupPermissionsResponse>);
        }
        
        /// <summary>
        /// 获取指定应用的应用部署成功率
        ///
        /// 获取指定应用的应用部署成功率。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTaskSuccessRateResponse> ListTaskSuccessRateAsync(ListTaskSuccessRateRequest listTaskSuccessRateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listTaskSuccessRateRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/metrics/success-rate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskSuccessRateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListTaskSuccessRateResponse>(response);
        }

        public AsyncInvoker<ListTaskSuccessRateResponse> ListTaskSuccessRateAsyncInvoker(ListTaskSuccessRateRequest listTaskSuccessRateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listTaskSuccessRateRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/metrics/success-rate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskSuccessRateRequest);
            return new AsyncInvoker<ListTaskSuccessRateResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTaskSuccessRateResponse>);
        }
        
        /// <summary>
        /// 获取指定项目的应用部署成功率
        ///
        /// 获取指定项目的应用部署成功率。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectSuccessRateResponse> ShowProjectSuccessRateAsync(ShowProjectSuccessRateRequest showProjectSuccessRateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showProjectSuccessRateRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/metrics/success-rate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectSuccessRateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectSuccessRateResponse>(response);
        }

        public AsyncInvoker<ShowProjectSuccessRateResponse> ShowProjectSuccessRateAsyncInvoker(ShowProjectSuccessRateRequest showProjectSuccessRateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showProjectSuccessRateRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/metrics/success-rate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectSuccessRateRequest);
            return new AsyncInvoker<ShowProjectSuccessRateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectSuccessRateResponse>);
        }
        
    }
}