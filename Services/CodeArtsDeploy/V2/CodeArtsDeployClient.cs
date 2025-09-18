using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CodeArtsDeploy.V2.Model;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2
{
    public partial class CodeArtsDeployClient : Client
    {
        public static ClientBuilder<CodeArtsDeployClient> NewBuilder()
        {
            return new ClientBuilder<CodeArtsDeployClient>();
        }

        
        /// <summary>
        /// 创建分组
        ///
        /// 创建分组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAppGroupsResponse CreateAppGroups(CreateAppGroupsRequest createAppGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAppGroupsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppGroupsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAppGroupsResponse>(response);
        }

        public SyncInvoker<CreateAppGroupsResponse> CreateAppGroupsInvoker(CreateAppGroupsRequest createAppGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAppGroupsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppGroupsRequest);
            return new SyncInvoker<CreateAppGroupsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAppGroupsResponse>);
        }
        
        /// <summary>
        /// 删除分组
        ///
        /// 删除分组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAppGroupsResponse DeleteAppGroups(DeleteAppGroupsRequest deleteAppGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAppGroupsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAppGroupsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppGroupsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAppGroupsResponse>(response);
        }

        public SyncInvoker<DeleteAppGroupsResponse> DeleteAppGroupsInvoker(DeleteAppGroupsRequest deleteAppGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAppGroupsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAppGroupsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppGroupsRequest);
            return new SyncInvoker<DeleteAppGroupsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAppGroupsResponse>);
        }
        
        /// <summary>
        /// 查询分组列表
        ///
        /// 查询分组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAppGroupsResponse ListAppGroups(ListAppGroupsRequest listAppGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAppGroupsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAppGroupsResponse>(response);
        }

        public SyncInvoker<ListAppGroupsResponse> ListAppGroupsInvoker(ListAppGroupsRequest listAppGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAppGroupsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppGroupsRequest);
            return new SyncInvoker<ListAppGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppGroupsResponse>);
        }
        
        /// <summary>
        /// 移动分组
        ///
        /// 往上或者往下移动单个分组,用来在页面上调整分组位置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public MoveAppGroupsResponse MoveAppGroups(MoveAppGroupsRequest moveAppGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(moveAppGroupsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups/swap", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", moveAppGroupsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<MoveAppGroupsResponse>(response);
        }

        public SyncInvoker<MoveAppGroupsResponse> MoveAppGroupsInvoker(MoveAppGroupsRequest moveAppGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(moveAppGroupsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups/swap", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", moveAppGroupsRequest);
            return new SyncInvoker<MoveAppGroupsResponse>(this, "PUT", request, JsonUtils.DeSerialize<MoveAppGroupsResponse>);
        }
        
        /// <summary>
        /// 移动应用至指定分组
        ///
        /// 将应用移动至指定分组（支持批量）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public MoveAppToGroupResponse MoveAppToGroup(MoveAppToGroupRequest moveAppToGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(moveAppToGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups/move", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", moveAppToGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<MoveAppToGroupResponse>(response);
        }

        public SyncInvoker<MoveAppToGroupResponse> MoveAppToGroupInvoker(MoveAppToGroupRequest moveAppToGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(moveAppToGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups/move", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", moveAppToGroupRequest);
            return new SyncInvoker<MoveAppToGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<MoveAppToGroupResponse>);
        }
        
        /// <summary>
        /// 修改分组
        ///
        /// 修改分组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAppGroupsResponse UpdateAppGroups(UpdateAppGroupsRequest updateAppGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAppGroupsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateAppGroupsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppGroupsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAppGroupsResponse>(response);
        }

        public SyncInvoker<UpdateAppGroupsResponse> UpdateAppGroupsInvoker(UpdateAppGroupsRequest updateAppGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAppGroupsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateAppGroupsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_id}/applications/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppGroupsRequest);
            return new SyncInvoker<UpdateAppGroupsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAppGroupsResponse>);
        }
        
        /// <summary>
        /// 批量修改应用权限
        ///
        /// 批量修改应用权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateApplicationPermissionsResponse BatchUpdateApplicationPermissions(BatchUpdateApplicationPermissionsRequest batchUpdateApplicationPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/applications/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateApplicationPermissionsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateApplicationPermissionsResponse>(response);
        }

        public SyncInvoker<BatchUpdateApplicationPermissionsResponse> BatchUpdateApplicationPermissionsInvoker(BatchUpdateApplicationPermissionsRequest batchUpdateApplicationPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/applications/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateApplicationPermissionsRequest);
            return new SyncInvoker<BatchUpdateApplicationPermissionsResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateApplicationPermissionsResponse>);
        }
        
        /// <summary>
        /// 批量配置应用下鉴权级别
        ///
        /// 批量配置应用下鉴权级别为项目级或实例级。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdatePermissionLevelResponse BatchUpdatePermissionLevel(BatchUpdatePermissionLevelRequest batchUpdatePermissionLevelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/applications/permission-level", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdatePermissionLevelRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdatePermissionLevelResponse>(response);
        }

        public SyncInvoker<BatchUpdatePermissionLevelResponse> BatchUpdatePermissionLevelInvoker(BatchUpdatePermissionLevelRequest batchUpdatePermissionLevelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/applications/permission-level", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdatePermissionLevelRequest);
            return new SyncInvoker<BatchUpdatePermissionLevelResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdatePermissionLevelResponse>);
        }
        
        /// <summary>
        /// 查询当前用户是否有项目下创建应用权限
        ///
        /// 查询当前用户是否有项目下创建应用权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckCanCreateResponse CheckCanCreate(CheckCanCreateRequest checkCanCreateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/creatable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkCanCreateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CheckCanCreateResponse>(response);
        }

        public SyncInvoker<CheckCanCreateResponse> CheckCanCreateInvoker(CheckCanCreateRequest checkCanCreateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/creatable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkCanCreateRequest);
            return new SyncInvoker<CheckCanCreateResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckCanCreateResponse>);
        }
        
        /// <summary>
        /// 查询应用实例级/项目级权限矩阵
        ///
        /// 查询应用实例级/项目级权限矩阵，传递app_id时，查询应用实例级权限矩阵；未传app_id，传递project_id时，查询应用项目级权限矩阵。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListApplicationPermissionsResponse ListApplicationPermissions(ListApplicationPermissionsRequest listApplicationPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/applications/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationPermissionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationPermissionsResponse>(response);
        }

        public SyncInvoker<ListApplicationPermissionsResponse> ListApplicationPermissionsInvoker(ListApplicationPermissionsRequest listApplicationPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/applications/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationPermissionsRequest);
            return new SyncInvoker<ListApplicationPermissionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationPermissionsResponse>);
        }
        
        /// <summary>
        /// 批量删除项目下应用
        ///
        /// 批量删除项目下应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteAppResponse BatchDeleteApp(BatchDeleteAppRequest batchDeleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/applications/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteAppResponse>(response);
        }

        public SyncInvoker<BatchDeleteAppResponse> BatchDeleteAppInvoker(BatchDeleteAppRequest batchDeleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/applications/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppRequest);
            return new SyncInvoker<BatchDeleteAppResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteAppResponse>);
        }
        
        /// <summary>
        /// 查询项目下是否存在同名应用
        ///
        /// 查询项目下是否存在同名应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckIsDuplicateAppNameResponse CheckIsDuplicateAppName(CheckIsDuplicateAppNameRequest checkIsDuplicateAppNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/exist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkIsDuplicateAppNameRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CheckIsDuplicateAppNameResponse>(response);
        }

        public SyncInvoker<CheckIsDuplicateAppNameResponse> CheckIsDuplicateAppNameInvoker(CheckIsDuplicateAppNameRequest checkIsDuplicateAppNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/exist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkIsDuplicateAppNameRequest);
            return new SyncInvoker<CheckIsDuplicateAppNameResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckIsDuplicateAppNameResponse>);
        }
        
        /// <summary>
        /// 复制应用
        ///
        /// 复制应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CopyApplicationResponse CopyApplication(CopyApplicationRequest copyApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(copyApplicationRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}/duplicate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyApplicationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CopyApplicationResponse>(response);
        }

        public SyncInvoker<CopyApplicationResponse> CopyApplicationInvoker(CopyApplicationRequest copyApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(copyApplicationRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}/duplicate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyApplicationRequest);
            return new SyncInvoker<CopyApplicationResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyApplicationResponse>);
        }
        
        /// <summary>
        /// 新建应用
        ///
        /// 新建应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAppResponse CreateApp(CreateAppRequest createAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAppResponse>(response);
        }

        public SyncInvoker<CreateAppResponse> CreateAppInvoker(CreateAppRequest createAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            return new SyncInvoker<CreateAppResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAppResponse>);
        }
        
        /// <summary>
        /// 通过模板新建应用
        ///
        /// 通过模板新建应用。该接口于2024年09月30日后不再维护，推荐使用新版CreateApp接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDeployTaskByTemplateResponse CreateDeployTaskByTemplate(CreateDeployTaskByTemplateRequest createDeployTaskByTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/template-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeployTaskByTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDeployTaskByTemplateResponse>(response);
        }

        public SyncInvoker<CreateDeployTaskByTemplateResponse> CreateDeployTaskByTemplateInvoker(CreateDeployTaskByTemplateRequest createDeployTaskByTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/template-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeployTaskByTemplateRequest);
            return new SyncInvoker<CreateDeployTaskByTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDeployTaskByTemplateResponse>);
        }
        
        /// <summary>
        /// 删除应用
        ///
        /// 根据应用id删除应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest deleteApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteApplicationResponse>(response);
        }

        public SyncInvoker<DeleteApplicationResponse> DeleteApplicationInvoker(DeleteApplicationRequest deleteApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            return new SyncInvoker<DeleteApplicationResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteApplicationResponse>);
        }
        
        /// <summary>
        /// 删除应用
        ///
        /// 根据部署任务id删除应用。该接口于2024年09月30日后不再维护，推荐使用新版DeleteApplication接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDeployTaskResponse DeleteDeployTask(DeleteDeployTaskRequest deleteDeployTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeployTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeployTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDeployTaskResponse>(response);
        }

        public SyncInvoker<DeleteDeployTaskResponse> DeleteDeployTaskInvoker(DeleteDeployTaskRequest deleteDeployTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeployTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeployTaskRequest);
            return new SyncInvoker<DeleteDeployTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDeployTaskResponse>);
        }
        
        /// <summary>
        /// 获取应用列表
        ///
        /// 查询项目下应用列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllAppResponse ListAllApp(ListAllAppRequest listAllAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllAppRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAllAppResponse>(response);
        }

        public SyncInvoker<ListAllAppResponse> ListAllAppInvoker(ListAllAppRequest listAllAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllAppRequest);
            return new SyncInvoker<ListAllAppResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAllAppResponse>);
        }
        
        /// <summary>
        /// 根据开始时间和结束时间查询项目下指定应用的历史部署记录列表
        ///
        /// 根据开始时间和结束时间查询项目下指定应用的历史部署记录列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDeployTaskHistoryByDateResponse ListDeployTaskHistoryByDate(ListDeployTaskHistoryByDateRequest listDeployTaskHistoryByDateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDeployTaskHistoryByDateRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listDeployTaskHistoryByDateRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/task/{id}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeployTaskHistoryByDateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDeployTaskHistoryByDateResponse>(response);
        }

        public SyncInvoker<ListDeployTaskHistoryByDateResponse> ListDeployTaskHistoryByDateInvoker(ListDeployTaskHistoryByDateRequest listDeployTaskHistoryByDateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDeployTaskHistoryByDateRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listDeployTaskHistoryByDateRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/task/{id}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeployTaskHistoryByDateRequest);
            return new SyncInvoker<ListDeployTaskHistoryByDateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDeployTaskHistoryByDateResponse>);
        }
        
        /// <summary>
        /// 获取应用列表
        ///
        /// 查询项目下应用列表。该接口于2024年09月30日后不再维护，推荐使用新版ListAllApp接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDeployTasksResponse ListDeployTasks(ListDeployTasksRequest listDeployTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDeployTasksRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeployTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDeployTasksResponse>(response);
        }

        public SyncInvoker<ListDeployTasksResponse> ListDeployTasksInvoker(ListDeployTasksRequest listDeployTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDeployTasksRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeployTasksRequest);
            return new SyncInvoker<ListDeployTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDeployTasksResponse>);
        }
        
        /// <summary>
        /// 获取应用详情
        ///
        /// 根据应用id获取应用详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAppDetailByIdResponse ShowAppDetailById(ShowAppDetailByIdRequest showAppDetailByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAppDetailByIdRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppDetailByIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAppDetailByIdResponse>(response);
        }

        public SyncInvoker<ShowAppDetailByIdResponse> ShowAppDetailByIdInvoker(ShowAppDetailByIdRequest showAppDetailByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAppDetailByIdRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppDetailByIdRequest);
            return new SyncInvoker<ShowAppDetailByIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppDetailByIdResponse>);
        }
        
        /// <summary>
        /// 获取应用详情
        ///
        /// 根据部署任务id获取应用详情。该接口于2024年09月30日后不再维护，推荐使用新版ShowAppDetailById接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDeployTaskDetailResponse ShowDeployTaskDetail(ShowDeployTaskDetailRequest showDeployTaskDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeployTaskDetailRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeployTaskDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDeployTaskDetailResponse>(response);
        }

        public SyncInvoker<ShowDeployTaskDetailResponse> ShowDeployTaskDetailInvoker(ShowDeployTaskDetailRequest showDeployTaskDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeployTaskDetailRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeployTaskDetailRequest);
            return new SyncInvoker<ShowDeployTaskDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeployTaskDetailResponse>);
        }
        
        /// <summary>
        /// 查询部署记录的执行参数
        ///
        /// 查询部署记录的执行参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowExecutionParamsResponse ShowExecutionParams(ShowExecutionParamsRequest showExecutionParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showExecutionParamsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/history/tasks/{task_id}/params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExecutionParamsRequest);
            var response = DoHttpRequestSync("GET", request);
            var showExecutionParamsResponse = JsonUtils.DeSerializeNull<ShowExecutionParamsResponse>(response);
            showExecutionParamsResponse.Body = JsonUtils.DeSerializeList<ConfigInfo>(response);
            return showExecutionParamsResponse;
        }

        public SyncInvoker<ShowExecutionParamsResponse> ShowExecutionParamsInvoker(ShowExecutionParamsRequest showExecutionParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showExecutionParamsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/history/tasks/{task_id}/params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExecutionParamsRequest);
            return new SyncInvoker<ShowExecutionParamsResponse>(this, "GET", request, response =>
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
        public StartDeployTaskResponse StartDeployTask(StartDeployTaskRequest startDeployTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startDeployTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDeployTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartDeployTaskResponse>(response);
        }

        public SyncInvoker<StartDeployTaskResponse> StartDeployTaskInvoker(StartDeployTaskRequest startDeployTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startDeployTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDeployTaskRequest);
            return new SyncInvoker<StartDeployTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<StartDeployTaskResponse>);
        }
        
        /// <summary>
        /// 禁用/取消禁用应用
        ///
        /// 禁用/取消禁用应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAppDisableStatusResponse UpdateAppDisableStatus(UpdateAppDisableStatusRequest updateAppDisableStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAppDisableStatusRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppDisableStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAppDisableStatusResponse>(response);
        }

        public SyncInvoker<UpdateAppDisableStatusResponse> UpdateAppDisableStatusInvoker(UpdateAppDisableStatusRequest updateAppDisableStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAppDisableStatusRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppDisableStatusRequest);
            return new SyncInvoker<UpdateAppDisableStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAppDisableStatusResponse>);
        }
        
        /// <summary>
        /// 更新应用
        ///
        /// 更新应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAppInfoResponse UpdateAppInfo(UpdateAppInfoRequest updateAppInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppInfoRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAppInfoResponse>(response);
        }

        public SyncInvoker<UpdateAppInfoResponse> UpdateAppInfoInvoker(UpdateAppInfoRequest updateAppInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppInfoRequest);
            return new SyncInvoker<UpdateAppInfoResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAppInfoResponse>);
        }
        
        /// <summary>
        /// 获取部署任务状态
        ///
        /// 获取部署任务状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckDeployStatusResponse CheckDeployStatus(CheckDeployStatusRequest checkDeployStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkDeployStatusRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDeployStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CheckDeployStatusResponse>(response);
        }

        public SyncInvoker<CheckDeployStatusResponse> CheckDeployStatusInvoker(CheckDeployStatusRequest checkDeployStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkDeployStatusRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDeployStatusRequest);
            return new SyncInvoker<CheckDeployStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckDeployStatusResponse>);
        }
        
        /// <summary>
        /// 应用下创建环境
        ///
        /// 应用下创建环境。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest createEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createEnvironmentRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEnvironmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateEnvironmentResponse>(response);
        }

        public SyncInvoker<CreateEnvironmentResponse> CreateEnvironmentInvoker(CreateEnvironmentRequest createEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createEnvironmentRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEnvironmentRequest);
            return new SyncInvoker<CreateEnvironmentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEnvironmentResponse>);
        }
        
        /// <summary>
        /// 删除应用下的环境
        ///
        /// 删除应用下的环境。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest deleteEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteEnvironmentRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            if (StringUtils.TryConvertToNonEmptyString(deleteEnvironmentRequest.EnvironmentId, out var valueOfEnvironmentId)) urlParam.Add("environment_id", valueOfEnvironmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnvironmentRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteEnvironmentResponse>(response);
        }

        public SyncInvoker<DeleteEnvironmentResponse> DeleteEnvironmentInvoker(DeleteEnvironmentRequest deleteEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteEnvironmentRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            if (StringUtils.TryConvertToNonEmptyString(deleteEnvironmentRequest.EnvironmentId, out var valueOfEnvironmentId)) urlParam.Add("environment_id", valueOfEnvironmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnvironmentRequest);
            return new SyncInvoker<DeleteEnvironmentResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteEnvironmentResponse>);
        }
        
        /// <summary>
        /// 环境下删除主机
        ///
        /// 环境下删除主机。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteHostFromEnvironmentResponse DeleteHostFromEnvironment(DeleteHostFromEnvironmentRequest deleteHostFromEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHostFromEnvironmentRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            if (StringUtils.TryConvertToNonEmptyString(deleteHostFromEnvironmentRequest.EnvironmentId, out var valueOfEnvironmentId)) urlParam.Add("environment_id", valueOfEnvironmentId);
            if (StringUtils.TryConvertToNonEmptyString(deleteHostFromEnvironmentRequest.HostId, out var valueOfHostId)) urlParam.Add("host_id", valueOfHostId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHostFromEnvironmentRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteHostFromEnvironmentResponse>(response);
        }

        public SyncInvoker<DeleteHostFromEnvironmentResponse> DeleteHostFromEnvironmentInvoker(DeleteHostFromEnvironmentRequest deleteHostFromEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHostFromEnvironmentRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            if (StringUtils.TryConvertToNonEmptyString(deleteHostFromEnvironmentRequest.EnvironmentId, out var valueOfEnvironmentId)) urlParam.Add("environment_id", valueOfEnvironmentId);
            if (StringUtils.TryConvertToNonEmptyString(deleteHostFromEnvironmentRequest.HostId, out var valueOfHostId)) urlParam.Add("host_id", valueOfHostId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHostFromEnvironmentRequest);
            return new SyncInvoker<DeleteHostFromEnvironmentResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteHostFromEnvironmentResponse>);
        }
        
        /// <summary>
        /// 环境下导入主机
        ///
        /// 环境下导入主机。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ImportHostToEnvironmentResponse ImportHostToEnvironment(ImportHostToEnvironmentRequest importHostToEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(importHostToEnvironmentRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            if (StringUtils.TryConvertToNonEmptyString(importHostToEnvironmentRequest.EnvironmentId, out var valueOfEnvironmentId)) urlParam.Add("environment_id", valueOfEnvironmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}/hosts/import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importHostToEnvironmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ImportHostToEnvironmentResponse>(response);
        }

        public SyncInvoker<ImportHostToEnvironmentResponse> ImportHostToEnvironmentInvoker(ImportHostToEnvironmentRequest importHostToEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(importHostToEnvironmentRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            if (StringUtils.TryConvertToNonEmptyString(importHostToEnvironmentRequest.EnvironmentId, out var valueOfEnvironmentId)) urlParam.Add("environment_id", valueOfEnvironmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}/hosts/import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importHostToEnvironmentRequest);
            return new SyncInvoker<ImportHostToEnvironmentResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportHostToEnvironmentResponse>);
        }
        
        /// <summary>
        /// 查询环境内的主机列表
        ///
        /// 查询环境内的主机列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEnvironmentHostsResponse ListEnvironmentHosts(ListEnvironmentHostsRequest listEnvironmentHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEnvironmentHostsRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            if (StringUtils.TryConvertToNonEmptyString(listEnvironmentHostsRequest.EnvironmentId, out var valueOfEnvironmentId)) urlParam.Add("environment_id", valueOfEnvironmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvironmentHostsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEnvironmentHostsResponse>(response);
        }

        public SyncInvoker<ListEnvironmentHostsResponse> ListEnvironmentHostsInvoker(ListEnvironmentHostsRequest listEnvironmentHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEnvironmentHostsRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            if (StringUtils.TryConvertToNonEmptyString(listEnvironmentHostsRequest.EnvironmentId, out var valueOfEnvironmentId)) urlParam.Add("environment_id", valueOfEnvironmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvironmentHostsRequest);
            return new SyncInvoker<ListEnvironmentHostsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEnvironmentHostsResponse>);
        }
        
        /// <summary>
        /// 查询应用下环境列表
        ///
        /// 查询应用下环境列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest listEnvironmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEnvironmentsRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvironmentsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEnvironmentsResponse>(response);
        }

        public SyncInvoker<ListEnvironmentsResponse> ListEnvironmentsInvoker(ListEnvironmentsRequest listEnvironmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEnvironmentsRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvironmentsRequest);
            return new SyncInvoker<ListEnvironmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEnvironmentsResponse>);
        }
        
        /// <summary>
        /// 查询环境详情
        ///
        /// 查询环境详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEnvironmentDetailResponse ShowEnvironmentDetail(ShowEnvironmentDetailRequest showEnvironmentDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEnvironmentDetailRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            if (StringUtils.TryConvertToNonEmptyString(showEnvironmentDetailRequest.EnvironmentId, out var valueOfEnvironmentId)) urlParam.Add("environment_id", valueOfEnvironmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvironmentDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEnvironmentDetailResponse>(response);
        }

        public SyncInvoker<ShowEnvironmentDetailResponse> ShowEnvironmentDetailInvoker(ShowEnvironmentDetailRequest showEnvironmentDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEnvironmentDetailRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            if (StringUtils.TryConvertToNonEmptyString(showEnvironmentDetailRequest.EnvironmentId, out var valueOfEnvironmentId)) urlParam.Add("environment_id", valueOfEnvironmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvironmentDetailRequest);
            return new SyncInvoker<ShowEnvironmentDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEnvironmentDetailResponse>);
        }
        
        /// <summary>
        /// 应用下编辑环境
        ///
        /// 应用下编辑环境。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest updateEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateEnvironmentRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            if (StringUtils.TryConvertToNonEmptyString(updateEnvironmentRequest.EnvironmentId, out var valueOfEnvironmentId)) urlParam.Add("environment_id", valueOfEnvironmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEnvironmentRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEnvironmentResponse>(response);
        }

        public SyncInvoker<UpdateEnvironmentResponse> UpdateEnvironmentInvoker(UpdateEnvironmentRequest updateEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateEnvironmentRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            if (StringUtils.TryConvertToNonEmptyString(updateEnvironmentRequest.EnvironmentId, out var valueOfEnvironmentId)) urlParam.Add("environment_id", valueOfEnvironmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEnvironmentRequest);
            return new SyncInvoker<UpdateEnvironmentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEnvironmentResponse>);
        }
        
        /// <summary>
        /// 查询环境权限
        ///
        /// 查询环境权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEnvironmentPermissionsResponse ListEnvironmentPermissions(ListEnvironmentPermissionsRequest listEnvironmentPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEnvironmentPermissionsRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            if (StringUtils.TryConvertToNonEmptyString(listEnvironmentPermissionsRequest.EnvironmentId, out var valueOfEnvironmentId)) urlParam.Add("environment_id", valueOfEnvironmentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/applications/{application_id}/environments/{environment_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvironmentPermissionsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listEnvironmentPermissionsResponse = JsonUtils.DeSerializeNull<ListEnvironmentPermissionsResponse>(response);
            listEnvironmentPermissionsResponse.Body = JsonUtils.DeSerializeList<DevUcEnvironmentPermission>(response);
            return listEnvironmentPermissionsResponse;
        }

        public SyncInvoker<ListEnvironmentPermissionsResponse> ListEnvironmentPermissionsInvoker(ListEnvironmentPermissionsRequest listEnvironmentPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEnvironmentPermissionsRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            if (StringUtils.TryConvertToNonEmptyString(listEnvironmentPermissionsRequest.EnvironmentId, out var valueOfEnvironmentId)) urlParam.Add("environment_id", valueOfEnvironmentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/applications/{application_id}/environments/{environment_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvironmentPermissionsRequest);
            return new SyncInvoker<ListEnvironmentPermissionsResponse>(this, "GET", request, response =>
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
        public UpdateEnvironmentPermissionResponse UpdateEnvironmentPermission(UpdateEnvironmentPermissionRequest updateEnvironmentPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateEnvironmentPermissionRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            if (StringUtils.TryConvertToNonEmptyString(updateEnvironmentPermissionRequest.EnvironmentId, out var valueOfEnvironmentId)) urlParam.Add("environment_id", valueOfEnvironmentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/applications/{application_id}/environments/{environment_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEnvironmentPermissionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEnvironmentPermissionResponse>(response);
        }

        public SyncInvoker<UpdateEnvironmentPermissionResponse> UpdateEnvironmentPermissionInvoker(UpdateEnvironmentPermissionRequest updateEnvironmentPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateEnvironmentPermissionRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            if (StringUtils.TryConvertToNonEmptyString(updateEnvironmentPermissionRequest.EnvironmentId, out var valueOfEnvironmentId)) urlParam.Add("environment_id", valueOfEnvironmentId);
            var urlPath = HttpUtils.AddUrlPath("/v2/applications/{application_id}/environments/{environment_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEnvironmentPermissionRequest);
            return new SyncInvoker<UpdateEnvironmentPermissionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEnvironmentPermissionResponse>);
        }
        
        /// <summary>
        /// 停止部署任务
        ///
        /// 停止部署任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopDeployTaskResponse StopDeployTask(StopDeployTaskRequest stopDeployTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopDeployTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(stopDeployTaskRequest.RecordId, out var valueOfRecordId)) urlParam.Add("record_id", valueOfRecordId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/records/{record_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopDeployTaskRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<StopDeployTaskResponse>(response);
        }

        public SyncInvoker<StopDeployTaskResponse> StopDeployTaskInvoker(StopDeployTaskRequest stopDeployTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopDeployTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(stopDeployTaskRequest.RecordId, out var valueOfRecordId)) urlParam.Add("record_id", valueOfRecordId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/records/{record_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopDeployTaskRequest);
            return new SyncInvoker<StopDeployTaskResponse>(this, "PUT", request, JsonUtils.DeSerialize<StopDeployTaskResponse>);
        }
        
        /// <summary>
        /// 批量删除主机集群下的主机
        ///
        /// 批量删除主机集群下的主机。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteHostsResponse BatchDeleteHosts(BatchDeleteHostsRequest batchDeleteHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteHostsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteHostsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteHostsResponse>(response);
        }

        public SyncInvoker<BatchDeleteHostsResponse> BatchDeleteHostsInvoker(BatchDeleteHostsRequest batchDeleteHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteHostsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteHostsRequest);
            return new SyncInvoker<BatchDeleteHostsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteHostsResponse>);
        }
        
        /// <summary>
        /// 批量复制主机至目标主机集群
        ///
        /// 批量复制主机至目标主机集群。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CopyHostsToTargetResponse CopyHostsToTarget(CopyHostsToTargetRequest copyHostsToTargetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(copyHostsToTargetRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/replication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyHostsToTargetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CopyHostsToTargetResponse>(response);
        }

        public SyncInvoker<CopyHostsToTargetResponse> CopyHostsToTargetInvoker(CopyHostsToTargetRequest copyHostsToTargetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(copyHostsToTargetRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/replication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyHostsToTargetRequest);
            return new SyncInvoker<CopyHostsToTargetResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyHostsToTargetResponse>);
        }
        
        /// <summary>
        /// 新建主机
        ///
        /// 在指定主机集群下新建主机。该接口于2024年09月30日后不再维护，推荐使用新版CreateHost接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDeploymentHostResponse CreateDeploymentHost(CreateDeploymentHostRequest createDeploymentHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDeploymentHostRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeploymentHostRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDeploymentHostResponse>(response);
        }

        public SyncInvoker<CreateDeploymentHostResponse> CreateDeploymentHostInvoker(CreateDeploymentHostRequest createDeploymentHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDeploymentHostRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeploymentHostRequest);
            return new SyncInvoker<CreateDeploymentHostResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDeploymentHostResponse>);
        }
        
        /// <summary>
        /// 新建主机
        ///
        /// 在指定主机集群下新建主机。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateHostResponse CreateHost(CreateHostRequest createHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createHostRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHostRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateHostResponse>(response);
        }

        public SyncInvoker<CreateHostResponse> CreateHostInvoker(CreateHostRequest createHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createHostRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHostRequest);
            return new SyncInvoker<CreateHostResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHostResponse>);
        }
        
        /// <summary>
        /// 删除主机
        ///
        /// 根据主机id删除主机。该接口于2024年9月30日后不再维护。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDeploymentHostResponse DeleteDeploymentHost(DeleteDeploymentHostRequest deleteDeploymentHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeploymentHostRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDeploymentHostRequest.HostId, out var valueOfHostId)) urlParam.Add("host_id", valueOfHostId);
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeploymentHostRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDeploymentHostResponse>(response);
        }

        public SyncInvoker<DeleteDeploymentHostResponse> DeleteDeploymentHostInvoker(DeleteDeploymentHostRequest deleteDeploymentHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeploymentHostRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDeploymentHostRequest.HostId, out var valueOfHostId)) urlParam.Add("host_id", valueOfHostId);
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeploymentHostRequest);
            return new SyncInvoker<DeleteDeploymentHostResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDeploymentHostResponse>);
        }
        
        /// <summary>
        /// 删除主机集群下主机
        ///
        /// 根据主机id删除主机集群下主机。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteHostResponse DeleteHost(DeleteHostRequest deleteHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHostRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteHostRequest.HostId, out var valueOfHostId)) urlParam.Add("host_id", valueOfHostId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHostRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteHostResponse>(response);
        }

        public SyncInvoker<DeleteHostResponse> DeleteHostInvoker(DeleteHostRequest deleteHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHostRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteHostRequest.HostId, out var valueOfHostId)) urlParam.Add("host_id", valueOfHostId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHostRequest);
            return new SyncInvoker<DeleteHostResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteHostResponse>);
        }
        
        /// <summary>
        /// 查询主机列表
        ///
        /// 根据主机集群id查询指定主机集群下的主机列表。该接口于2024年09月30日后不再维护，推荐使用新版ListNewHosts接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHostsResponse ListHosts(ListHostsRequest listHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHostsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHostsResponse>(response);
        }

        public SyncInvoker<ListHostsResponse> ListHostsInvoker(ListHostsRequest listHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHostsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostsRequest);
            return new SyncInvoker<ListHostsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHostsResponse>);
        }
        
        /// <summary>
        /// 查询主机列表
        ///
        /// 根据主机集群id查询指定主机集群下的主机列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNewHostsResponse ListNewHosts(ListNewHostsRequest listNewHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNewHostsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNewHostsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNewHostsResponse>(response);
        }

        public SyncInvoker<ListNewHostsResponse> ListNewHostsInvoker(ListNewHostsRequest listNewHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNewHostsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNewHostsRequest);
            return new SyncInvoker<ListNewHostsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNewHostsResponse>);
        }
        
        /// <summary>
        /// 查询主机详情
        ///
        /// 根据主机id查询主机详情。该接口于2024年09月30日后不再维护，推荐使用新版ShowHostDetail接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDeploymentHostDetailResponse ShowDeploymentHostDetail(ShowDeploymentHostDetailRequest showDeploymentHostDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeploymentHostDetailRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showDeploymentHostDetailRequest.HostId, out var valueOfHostId)) urlParam.Add("host_id", valueOfHostId);
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeploymentHostDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDeploymentHostDetailResponse>(response);
        }

        public SyncInvoker<ShowDeploymentHostDetailResponse> ShowDeploymentHostDetailInvoker(ShowDeploymentHostDetailRequest showDeploymentHostDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeploymentHostDetailRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showDeploymentHostDetailRequest.HostId, out var valueOfHostId)) urlParam.Add("host_id", valueOfHostId);
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeploymentHostDetailRequest);
            return new SyncInvoker<ShowDeploymentHostDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeploymentHostDetailResponse>);
        }
        
        /// <summary>
        /// 查询主机详情
        ///
        /// 根据主机id查询主机详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHostDetailResponse ShowHostDetail(ShowHostDetailRequest showHostDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHostDetailRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showHostDetailRequest.HostId, out var valueOfHostId)) urlParam.Add("host_id", valueOfHostId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHostDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHostDetailResponse>(response);
        }

        public SyncInvoker<ShowHostDetailResponse> ShowHostDetailInvoker(ShowHostDetailRequest showHostDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHostDetailRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showHostDetailRequest.HostId, out var valueOfHostId)) urlParam.Add("host_id", valueOfHostId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHostDetailRequest);
            return new SyncInvoker<ShowHostDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHostDetailResponse>);
        }
        
        /// <summary>
        /// 修改主机
        ///
        /// 根据主机id修改主机信息。该接口于2024年9月30日后不再维护。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDeploymentHostResponse UpdateDeploymentHost(UpdateDeploymentHostRequest updateDeploymentHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDeploymentHostRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateDeploymentHostRequest.HostId, out var valueOfHostId)) urlParam.Add("host_id", valueOfHostId);
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeploymentHostRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDeploymentHostResponse>(response);
        }

        public SyncInvoker<UpdateDeploymentHostResponse> UpdateDeploymentHostInvoker(UpdateDeploymentHostRequest updateDeploymentHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDeploymentHostRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateDeploymentHostRequest.HostId, out var valueOfHostId)) urlParam.Add("host_id", valueOfHostId);
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeploymentHostRequest);
            return new SyncInvoker<UpdateDeploymentHostResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDeploymentHostResponse>);
        }
        
        /// <summary>
        /// 编辑主机集群下主机信息
        ///
        /// 根据主机id编辑主机集群下主机信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateHostInfoResponse UpdateHostInfo(UpdateHostInfoRequest updateHostInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHostInfoRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateHostInfoRequest.HostId, out var valueOfHostId)) urlParam.Add("host_id", valueOfHostId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHostInfoRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHostInfoResponse>(response);
        }

        public SyncInvoker<UpdateHostInfoResponse> UpdateHostInfoInvoker(UpdateHostInfoRequest updateHostInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHostInfoRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateHostInfoRequest.HostId, out var valueOfHostId)) urlParam.Add("host_id", valueOfHostId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHostInfoRequest);
            return new SyncInvoker<UpdateHostInfoResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHostInfoResponse>);
        }
        
        /// <summary>
        /// 新建主机集群
        ///
        /// 在项目下新建主机集群。该接口于2024年09月30日后不再维护，推荐使用新版CreateHostCluster接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDeploymentGroupResponse CreateDeploymentGroup(CreateDeploymentGroupRequest createDeploymentGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeploymentGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDeploymentGroupResponse>(response);
        }

        public SyncInvoker<CreateDeploymentGroupResponse> CreateDeploymentGroupInvoker(CreateDeploymentGroupRequest createDeploymentGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeploymentGroupRequest);
            return new SyncInvoker<CreateDeploymentGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDeploymentGroupResponse>);
        }
        
        /// <summary>
        /// 新建主机集群
        ///
        /// 在项目下新建主机集群。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateHostClusterResponse CreateHostCluster(CreateHostClusterRequest createHostClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHostClusterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateHostClusterResponse>(response);
        }

        public SyncInvoker<CreateHostClusterResponse> CreateHostClusterInvoker(CreateHostClusterRequest createHostClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHostClusterRequest);
            return new SyncInvoker<CreateHostClusterResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHostClusterResponse>);
        }
        
        /// <summary>
        /// 删除主机集群
        ///
        /// 根据主机集群id删除主机集群。该接口于2024年9月30日后不再维护。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDeploymentGroupResponse DeleteDeploymentGroup(DeleteDeploymentGroupRequest deleteDeploymentGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeploymentGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeploymentGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDeploymentGroupResponse>(response);
        }

        public SyncInvoker<DeleteDeploymentGroupResponse> DeleteDeploymentGroupInvoker(DeleteDeploymentGroupRequest deleteDeploymentGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeploymentGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeploymentGroupRequest);
            return new SyncInvoker<DeleteDeploymentGroupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDeploymentGroupResponse>);
        }
        
        /// <summary>
        /// 删除主机集群
        ///
        /// 根据主机集群id删除主机集群。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteHostClusterResponse DeleteHostCluster(DeleteHostClusterRequest deleteHostClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHostClusterRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHostClusterRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteHostClusterResponse>(response);
        }

        public SyncInvoker<DeleteHostClusterResponse> DeleteHostClusterInvoker(DeleteHostClusterRequest deleteHostClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHostClusterRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHostClusterRequest);
            return new SyncInvoker<DeleteHostClusterResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteHostClusterResponse>);
        }
        
        /// <summary>
        /// 查询主机集群关联环境信息
        ///
        /// 查询主机集群关联环境信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAssociateEnvironmentsInfosResponse ListAssociateEnvironmentsInfos(ListAssociateEnvironmentsInfosRequest listAssociateEnvironmentsInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAssociateEnvironmentsInfosRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/environments/infos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociateEnvironmentsInfosRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAssociateEnvironmentsInfosResponse>(response);
        }

        public SyncInvoker<ListAssociateEnvironmentsInfosResponse> ListAssociateEnvironmentsInfosInvoker(ListAssociateEnvironmentsInfosRequest listAssociateEnvironmentsInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAssociateEnvironmentsInfosRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/environments/infos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociateEnvironmentsInfosRequest);
            return new SyncInvoker<ListAssociateEnvironmentsInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAssociateEnvironmentsInfosResponse>);
        }
        
        /// <summary>
        /// 查询主机集群列表
        ///
        /// 按条件查询主机集群列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHostClustersResponse ListHostClusters(ListHostClustersRequest listHostClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostClustersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHostClustersResponse>(response);
        }

        public SyncInvoker<ListHostClustersResponse> ListHostClustersInvoker(ListHostClustersRequest listHostClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostClustersRequest);
            return new SyncInvoker<ListHostClustersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHostClustersResponse>);
        }
        
        /// <summary>
        /// 查询应用下环境基本信息列表
        ///
        /// 查询应用下环境基本信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHostGroupBaseInfosResponse ListHostGroupBaseInfos(ListHostGroupBaseInfosRequest listHostGroupBaseInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHostGroupBaseInfosRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/host-groups/base/infos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostGroupBaseInfosRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHostGroupBaseInfosResponse>(response);
        }

        public SyncInvoker<ListHostGroupBaseInfosResponse> ListHostGroupBaseInfosInvoker(ListHostGroupBaseInfosRequest listHostGroupBaseInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHostGroupBaseInfosRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/host-groups/base/infos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostGroupBaseInfosRequest);
            return new SyncInvoker<ListHostGroupBaseInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHostGroupBaseInfosResponse>);
        }
        
        /// <summary>
        /// 查询主机集群列表
        ///
        /// 按条件查询主机集群列表。该接口于2024年09月30日后不再维护，推荐使用新版ListHostClusters接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHostGroupsResponse ListHostGroups(ListHostGroupsRequest listHostGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHostGroupsResponse>(response);
        }

        public SyncInvoker<ListHostGroupsResponse> ListHostGroupsInvoker(ListHostGroupsRequest listHostGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostGroupsRequest);
            return new SyncInvoker<ListHostGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHostGroupsResponse>);
        }
        
        /// <summary>
        /// 查询主机集群详情
        ///
        /// 根据主机集群id查询主机集群详情。该接口于2024年09月30日后不再维护，推荐使用新版ShowHostClusterDetail接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDeploymentGroupDetailResponse ShowDeploymentGroupDetail(ShowDeploymentGroupDetailRequest showDeploymentGroupDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeploymentGroupDetailRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeploymentGroupDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDeploymentGroupDetailResponse>(response);
        }

        public SyncInvoker<ShowDeploymentGroupDetailResponse> ShowDeploymentGroupDetailInvoker(ShowDeploymentGroupDetailRequest showDeploymentGroupDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeploymentGroupDetailRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeploymentGroupDetailRequest);
            return new SyncInvoker<ShowDeploymentGroupDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeploymentGroupDetailResponse>);
        }
        
        /// <summary>
        /// 查询主机集群详情
        ///
        /// 根据主机集群id查询主机集群详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHostClusterDetailResponse ShowHostClusterDetail(ShowHostClusterDetailRequest showHostClusterDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHostClusterDetailRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHostClusterDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHostClusterDetailResponse>(response);
        }

        public SyncInvoker<ShowHostClusterDetailResponse> ShowHostClusterDetailInvoker(ShowHostClusterDetailRequest showHostClusterDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHostClusterDetailRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHostClusterDetailRequest);
            return new SyncInvoker<ShowHostClusterDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHostClusterDetailResponse>);
        }
        
        /// <summary>
        /// 修改主机集群
        ///
        /// 根据主机集群id修改主机集群信息。该接口于2024年9月30日后不再维护。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDeploymentGroupResponse UpdateDeploymentGroup(UpdateDeploymentGroupRequest updateDeploymentGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDeploymentGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeploymentGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDeploymentGroupResponse>(response);
        }

        public SyncInvoker<UpdateDeploymentGroupResponse> UpdateDeploymentGroupInvoker(UpdateDeploymentGroupRequest updateDeploymentGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDeploymentGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeploymentGroupRequest);
            return new SyncInvoker<UpdateDeploymentGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDeploymentGroupResponse>);
        }
        
        /// <summary>
        /// 编辑主机集群
        ///
        /// 编辑主机集群。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateHostClusterResponse UpdateHostCluster(UpdateHostClusterRequest updateHostClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHostClusterRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHostClusterRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHostClusterResponse>(response);
        }

        public SyncInvoker<UpdateHostClusterResponse> UpdateHostClusterInvoker(UpdateHostClusterRequest updateHostClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHostClusterRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHostClusterRequest);
            return new SyncInvoker<UpdateHostClusterResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHostClusterResponse>);
        }
        
        /// <summary>
        /// 判断当前用户在项目下是否有权限创建主机集群
        ///
        /// 判断当前用户在项目下是否有权限创建主机集群。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckWhetherHostGroupCanBeCreatedResponse CheckWhetherHostGroupCanBeCreated(CheckWhetherHostGroupCanBeCreatedRequest checkWhetherHostGroupCanBeCreatedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkWhetherHostGroupCanBeCreatedRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/host-groups/creatable/{project_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkWhetherHostGroupCanBeCreatedRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CheckWhetherHostGroupCanBeCreatedResponse>(response);
        }

        public SyncInvoker<CheckWhetherHostGroupCanBeCreatedResponse> CheckWhetherHostGroupCanBeCreatedInvoker(CheckWhetherHostGroupCanBeCreatedRequest checkWhetherHostGroupCanBeCreatedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkWhetherHostGroupCanBeCreatedRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v1/host-groups/creatable/{project_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkWhetherHostGroupCanBeCreatedRequest);
            return new SyncInvoker<CheckWhetherHostGroupCanBeCreatedResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckWhetherHostGroupCanBeCreatedResponse>);
        }
        
        /// <summary>
        /// 查询主机集群权限矩阵
        ///
        /// 根据主机集群id查询主机集群权限矩阵。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHostGroupPermissionsResponse ListHostGroupPermissions(ListHostGroupPermissionsRequest listHostGroupPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHostGroupPermissionsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostGroupPermissionsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listHostGroupPermissionsResponse = JsonUtils.DeSerializeNull<ListHostGroupPermissionsResponse>(response);
            listHostGroupPermissionsResponse.Body = JsonUtils.DeSerializeList<DevUcClusterPermission>(response);
            return listHostGroupPermissionsResponse;
        }

        public SyncInvoker<ListHostGroupPermissionsResponse> ListHostGroupPermissionsInvoker(ListHostGroupPermissionsRequest listHostGroupPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHostGroupPermissionsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostGroupPermissionsRequest);
            return new SyncInvoker<ListHostGroupPermissionsResponse>(this, "GET", request, response =>
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
        public UpdateHostGroupPermissionsResponse UpdateHostGroupPermissions(UpdateHostGroupPermissionsRequest updateHostGroupPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHostGroupPermissionsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHostGroupPermissionsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHostGroupPermissionsResponse>(response);
        }

        public SyncInvoker<UpdateHostGroupPermissionsResponse> UpdateHostGroupPermissionsInvoker(UpdateHostGroupPermissionsRequest updateHostGroupPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHostGroupPermissionsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHostGroupPermissionsRequest);
            return new SyncInvoker<UpdateHostGroupPermissionsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHostGroupPermissionsResponse>);
        }
        
        /// <summary>
        /// 获取指定应用的应用部署成功率
        ///
        /// 获取指定应用的应用部署成功率。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTaskSuccessRateResponse ListTaskSuccessRate(ListTaskSuccessRateRequest listTaskSuccessRateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskSuccessRateRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/metrics/success-rate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskSuccessRateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListTaskSuccessRateResponse>(response);
        }

        public SyncInvoker<ListTaskSuccessRateResponse> ListTaskSuccessRateInvoker(ListTaskSuccessRateRequest listTaskSuccessRateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskSuccessRateRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/metrics/success-rate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskSuccessRateRequest);
            return new SyncInvoker<ListTaskSuccessRateResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTaskSuccessRateResponse>);
        }
        
        /// <summary>
        /// 获取指定项目的应用部署成功率
        ///
        /// 获取指定项目的应用部署成功率。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectSuccessRateResponse ShowProjectSuccessRate(ShowProjectSuccessRateRequest showProjectSuccessRateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectSuccessRateRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/metrics/success-rate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectSuccessRateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectSuccessRateResponse>(response);
        }

        public SyncInvoker<ShowProjectSuccessRateResponse> ShowProjectSuccessRateInvoker(ShowProjectSuccessRateRequest showProjectSuccessRateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectSuccessRateRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/metrics/success-rate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectSuccessRateRequest);
            return new SyncInvoker<ShowProjectSuccessRateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectSuccessRateResponse>);
        }
        
    }
}