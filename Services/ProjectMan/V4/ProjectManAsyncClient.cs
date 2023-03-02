using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.ProjectMan.V4.Model;

namespace HuaweiCloud.SDK.ProjectMan.V4
{
    public partial class ProjectManAsyncClient : Client
    {
        public static ClientBuilder<ProjectManAsyncClient> NewBuilder()
        {
            return new ClientBuilder<ProjectManAsyncClient>();
        }

        
        /// <summary>
        /// AGC调用 当前用户申请加入项目
        ///
        /// AGC调用 当前用户申请加入项目, 申请的用户id写在header中
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddApplyJoinProjectForAgcResponse> AddApplyJoinProjectForAgcAsync(AddApplyJoinProjectForAgcRequest addApplyJoinProjectForAgcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , addApplyJoinProjectForAgcRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members/agc-join",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addApplyJoinProjectForAgcRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerializeNull<AddApplyJoinProjectForAgcResponse>(response);
        }
        
        /// <summary>
        /// 添加项目成员
        ///
        /// 添加项目成员,可以添加跨租户成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddMemberV4Response> AddMemberV4Async(AddMemberV4Request addMemberV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , addMemberV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/member",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addMemberV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<AddMemberV4Response>(response);
        }
        
        /// <summary>
        /// 批量添加项目成员
        ///
        /// 批量添加项目成员，只能添加和项目创建者同一租户下的成员，不正确的用户id会略过，添加的用户超过权限的，默认角色设置为7
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchAddMembersV4Response> BatchAddMembersV4Async(BatchAddMembersV4Request batchAddMembersV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , batchAddMembersV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddMembersV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchAddMembersV4Response>(response);
        }
        
        /// <summary>
        /// 批量删除项目成员
        ///
        /// 批量删除项目成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteMembersV4Response> BatchDeleteMembersV4Async(BatchDeleteMembersV4Request batchDeleteMembersV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , batchDeleteMembersV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteMembersV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<BatchDeleteMembersV4Response>(response);
        }
        
        /// <summary>
        /// 更新子用户昵称
        ///
        /// 拥有te_admin角色的用户可以更新其他用户的昵称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateChildNickNamesResponse> BatchUpdateChildNickNamesAsync(BatchUpdateChildNickNamesRequest batchUpdateChildNickNamesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v4/domain/child-users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateChildNickNamesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<BatchUpdateChildNickNamesResponse>(response);
        }
        
        /// <summary>
        /// 检查项目名称是否存在
        ///
        /// 检查项目名称是否存在
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckProjectNameV4Response> CheckProjectNameV4Async(CheckProjectNameV4Request checkProjectNameV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/check-name",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkProjectNameV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CheckProjectNameV4Response>(response);
        }
        
        /// <summary>
        /// 创建项目
        ///
        /// 创建项目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateProjectV4Response> CreateProjectV4Async(CreateProjectV4Request createProjectV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v4/project",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateProjectV4Response>(response);
        }
        
        /// <summary>
        /// 删除项目
        ///
        /// 删除项目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteProjectV4Response> DeleteProjectV4Async(DeleteProjectV4Request deleteProjectV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , deleteProjectV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProjectV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteProjectV4Response>(response);
        }
        
        /// <summary>
        /// 获取租户没有加入的项目
        ///
        /// 获取租户没有加入的项目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDomainNotAddedProjectsV4Response> ListDomainNotAddedProjectsV4Async(ListDomainNotAddedProjectsV4Request listDomainNotAddedProjectsV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/domain/not-added",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainNotAddedProjectsV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDomainNotAddedProjectsV4Response>(response);
        }
        
        /// <summary>
        /// 获取bug统计信息
        ///
        /// 获取bug统计信息，按模块统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectBugStaticsV4Response> ListProjectBugStaticsV4Async(ListProjectBugStaticsV4Request listProjectBugStaticsV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listProjectBugStaticsV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/bug-statistic",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectBugStaticsV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectBugStaticsV4Response>(response);
        }
        
        /// <summary>
        /// 获取需求统计信息
        ///
        /// 获取需求统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectDemandStaticV4Response> ListProjectDemandStaticV4Async(ListProjectDemandStaticV4Request listProjectDemandStaticV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listProjectDemandStaticV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/demand-statistic",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectDemandStaticV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectDemandStaticV4Response>(response);
        }
        
        /// <summary>
        /// 获取指定项目的成员用户列表
        ///
        /// 获取项目成员列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectMembersV4Response> ListProjectMembersV4Async(ListProjectMembersV4Request listProjectMembersV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listProjectMembersV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectMembersV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectMembersV4Response>(response);
        }
        
        /// <summary>
        /// 查询项目列表
        ///
        /// 查询项目列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectsV4Response> ListProjectsV4Async(ListProjectsV4Request listProjectsV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v4/projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectsV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectsV4Response>(response);
        }
        
        /// <summary>
        /// 查询看板项目下工作项的状态历史记录
        ///
        /// 分页查询看板项目下工作项的状态历史记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWorkitemStatusRecordsV4Response> ListWorkitemStatusRecordsV4Async(ListWorkitemStatusRecordsV4Request listWorkitemStatusRecordsV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listWorkitemStatusRecordsV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/work-items/status-records",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkitemStatusRecordsV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListWorkitemStatusRecordsV4Response>(response);
        }
        
        /// <summary>
        /// 查询看板项目下的工作项
        ///
        /// 查询看板项目下的工作项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWorkitemsResponse> ListWorkitemsAsync(ListWorkitemsRequest listWorkitemsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listWorkitemsRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/work-items",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkitemsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListWorkitemsResponse>(response);
        }
        
        /// <summary>
        /// 主动退出项目
        ///
        /// 项目成员主动退出项目，项目创建者不能退出
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemoveProjectResponse> RemoveProjectAsync(RemoveProjectRequest removeProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , removeProjectRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/quit",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeProjectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<RemoveProjectResponse>(response);
        }
        
        /// <summary>
        /// 查询缺陷密度
        ///
        /// 查询缺陷密度
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBugDensityV2Response> ShowBugDensityV2Async(ShowBugDensityV2Request showBugDensityV2Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showBugDensityV2Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bug-density/query",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBugDensityV2Request);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowBugDensityV2Response>(response);
        }
        
        /// <summary>
        /// 查询人均bug
        ///
        /// 查询人均bug
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBugsPerDeveloperResponse> ShowBugsPerDeveloperAsync(ShowBugsPerDeveloperRequest showBugsPerDeveloperRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showBugsPerDeveloperRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bugs-per-developer/query",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBugsPerDeveloperRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowBugsPerDeveloperResponse>(response);
        }
        
        /// <summary>
        /// 查询需求按时完成率
        ///
        /// 查询需求按时完成率
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCompletionRateResponse> ShowCompletionRateAsync(ShowCompletionRateRequest showCompletionRateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showCompletionRateRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/completion-rate/query",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCompletionRateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowCompletionRateResponse>(response);
        }
        
        /// <summary>
        /// 获取当前用户信息
        ///
        /// 获取当前用户信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCurUserInfoResponse> ShowCurUserInfoAsync(ShowCurUserInfoRequest showCurUserInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v4/user",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCurUserInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCurUserInfoResponse>(response);
        }
        
        /// <summary>
        /// 获取当前用户角色
        ///
        /// 获取用户在项目中的角色
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCurUserRoleResponse> ShowCurUserRoleAsync(ShowCurUserRoleRequest showCurUserRoleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showCurUserRoleRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/user-role",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCurUserRoleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCurUserRoleResponse>(response);
        }
        
        /// <summary>
        /// 获取项目详情
        ///
        /// 获取项目详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectInfoV4Response> ShowProjectInfoV4Async(ShowProjectInfoV4Request showProjectInfoV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showProjectInfoV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectInfoV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowProjectInfoV4Response>(response);
        }
        
        /// <summary>
        /// 获取项目概览
        ///
        /// 获取项目概览
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectSummaryV4Response> ShowProjectSummaryV4Async(ShowProjectSummaryV4Request showProjectSummaryV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showProjectSummaryV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/summary",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectSummaryV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowProjectSummaryV4Response>(response);
        }
        
        /// <summary>
        /// 查询看板项目的工作项流转配置
        ///
        /// 查询看板项目的工作项流转配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWorkItemWrokflowConfigResponse> ShowWorkItemWrokflowConfigAsync(ShowWorkItemWrokflowConfigRequest showWorkItemWrokflowConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showWorkItemWrokflowConfigRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/work-items/workflow/config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkItemWrokflowConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowWorkItemWrokflowConfigResponse>(response);
        }
        
        /// <summary>
        /// 更新成员在项目中的角色
        ///
        /// 更新成员在项目中的角色
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMembesRoleV4Response> UpdateMembesRoleV4Async(UpdateMembesRoleV4Request updateMembesRoleV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , updateMembesRoleV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members/role",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMembesRoleV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateMembesRoleV4Response>(response);
        }
        
        /// <summary>
        /// 更新用户昵称
        ///
        /// 更新用户昵称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateNickNameV4Response> UpdateNickNameV4Async(UpdateNickNameV4Request updateNickNameV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v4/user",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNickNameV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateNickNameV4Response>(response);
        }
        
        /// <summary>
        /// 更新项目
        ///
        /// 更新项目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateProjectV4Response> UpdateProjectV4Async(UpdateProjectV4Request updateProjectV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , updateProjectV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateProjectV4Response>(response);
        }
        
        /// <summary>
        /// 批量删除工作项
        ///
        /// 批量删除工作项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteIssuesV4Response> BatchDeleteIssuesV4Async(BatchDeleteIssuesV4Request batchDeleteIssuesV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , batchDeleteIssuesV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteIssuesV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<BatchDeleteIssuesV4Response>(response);
        }
        
        /// <summary>
        /// 批量删除项目的迭代
        ///
        /// 批量删除项目的迭代
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteIterationsV4Response> BatchDeleteIterationsV4Async(BatchDeleteIterationsV4Request batchDeleteIterationsV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , batchDeleteIterationsV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/iterations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteIterationsV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<BatchDeleteIterationsV4Response>(response);
        }
        
        /// <summary>
        /// 取消领域与项目的关联关系
        ///
        /// 取消领域与项目的关联关系
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelProjectDomainResponse> CancelProjectDomainAsync(CancelProjectDomainRequest cancelProjectDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , cancelProjectDomainRequest.ProjectId.ToString());
            urlParam.Add("domain_id" , cancelProjectDomainRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/domains/{domain_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelProjectDomainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<CancelProjectDomainResponse>(response);
        }
        
        /// <summary>
        /// 创建工作项类型自定义字段
        ///
        /// 创建工作项类型自定义字段
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCustomfieldsResponse> CreateCustomfieldsAsync(CreateCustomfieldsRequest createCustomfieldsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , createCustomfieldsRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/custom-fields",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCustomfieldsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateCustomfieldsResponse>(response);
        }
        
        /// <summary>
        /// 创建工作项
        ///
        /// 创建工作项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateIssueV4Response> CreateIssueV4Async(CreateIssueV4Request createIssueV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , createIssueV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issue",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIssueV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateIssueV4Response>(response);
        }
        
        /// <summary>
        /// 创建Scrum项目迭代
        ///
        /// 创建Scrum项目迭代
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateIterationV4Response> CreateIterationV4Async(CreateIterationV4Request createIterationV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , createIterationV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/iteration",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIterationV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateIterationV4Response>(response);
        }
        
        /// <summary>
        /// 创建项目的领域
        ///
        /// 查询项目的领域列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateProjectDomainResponse> CreateProjectDomainAsync(CreateProjectDomainRequest createProjectDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , createProjectDomainRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/domain",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectDomainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateProjectDomainResponse>(response);
        }
        
        /// <summary>
        /// 创建项目的模块
        ///
        /// 查询项目的模块列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateProjectModuleResponse> CreateProjectModuleAsync(CreateProjectModuleRequest createProjectModuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , createProjectModuleRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/module",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectModuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateProjectModuleResponse>(response);
        }
        
        /// <summary>
        /// 细粒度权限用户创建工作项
        ///
        /// 拥有IAM细粒度权限（projectmanConfig:systemSettingField:set）且在devcloud项目中有创建工作项的权限的用户可以设置工作项的创建者
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSystemIssueV4Response> CreateSystemIssueV4Async(CreateSystemIssueV4Request createSystemIssueV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , createSystemIssueV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/system/issue",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSystemIssueV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSystemIssueV4Response>(response);
        }
        
        /// <summary>
        /// 删除附件
        ///
        /// 取消工作项与附件关联，如附件为工作项页面上传则删除附件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAttachmentResponse> DeleteAttachmentAsync(DeleteAttachmentRequest deleteAttachmentRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , deleteAttachmentRequest.ProjectId.ToString());
            urlParam.Add("issue_id" , deleteAttachmentRequest.IssueId.ToString());
            urlParam.Add("attachment_id" , deleteAttachmentRequest.AttachmentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/attachments/{attachment_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAttachmentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAttachmentResponse>(response);
        }
        
        /// <summary>
        /// 删除工作项
        ///
        /// 删除工作项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteIssueV4Response> DeleteIssueV4Async(DeleteIssueV4Request deleteIssueV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , deleteIssueV4Request.ProjectId.ToString());
            urlParam.Add("issue_id" , deleteIssueV4Request.IssueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIssueV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteIssueV4Response>(response);
        }
        
        /// <summary>
        /// 删除项目迭代
        ///
        /// 删除项目迭代
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteIterationV4Response> DeleteIterationV4Async(DeleteIterationV4Request deleteIterationV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , deleteIterationV4Request.ProjectId.ToString());
            urlParam.Add("iteration_id" , deleteIterationV4Request.IterationId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/iterations/{iteration_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIterationV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteIterationV4Response>(response);
        }
        
        /// <summary>
        /// 删除项目的模块
        ///
        /// 删除项目的模块
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteProjectModuleResponse> DeleteProjectModuleAsync(DeleteProjectModuleRequest deleteProjectModuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , deleteProjectModuleRequest.ProjectId.ToString());
            urlParam.Add("module_id" , deleteProjectModuleRequest.ModuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/modules/{module_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProjectModuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteProjectModuleResponse>(response);
        }
        
        /// <summary>
        /// 下载工作项附件
        ///
        /// 下载工作项附件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadAttachmentResponse> DownloadAttachmentAsync(DownloadAttachmentRequest downloadAttachmentRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , downloadAttachmentRequest.ProjectId.ToString());
            urlParam.Add("issue_id" , downloadAttachmentRequest.IssueId.ToString());
            urlParam.Add("attachment_id" , downloadAttachmentRequest.AttachmentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/attachments/{attachment_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAttachmentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<DownloadAttachmentResponse>(response);
        }
        
        /// <summary>
        /// 下载图片
        ///
        /// 下载图片
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadImageFileResponse> DownloadImageFileAsync(DownloadImageFileRequest downloadImageFileRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , downloadImageFileRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/image-file",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadImageFileRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<DownloadImageFileResponse>(response);
        }
        
        /// <summary>
        /// 查询当前工作项已经关联的工作项
        ///
        /// 查询当前工作项已经关联的工作项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAssociatedIssuesResponse> ListAssociatedIssuesAsync(ListAssociatedIssuesRequest listAssociatedIssuesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listAssociatedIssuesRequest.ProjectId.ToString());
            urlParam.Add("issue_id" , listAssociatedIssuesRequest.IssueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/associated-issues",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociatedIssuesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAssociatedIssuesResponse>(response);
        }
        
        /// <summary>
        /// 查询关联用例
        ///
        /// 查询关联用例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAssociatedTestCasesResponse> ListAssociatedTestCasesAsync(ListAssociatedTestCasesRequest listAssociatedTestCasesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listAssociatedTestCasesRequest.ProjectId.ToString());
            urlParam.Add("issue_id" , listAssociatedTestCasesRequest.IssueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/associate-test-cases",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociatedTestCasesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAssociatedTestCasesResponse>(response);
        }
        
        /// <summary>
        /// 查询当前工作项已经关联的关联Wiki
        ///
        /// 查询当前工作项已经关联的关联Wiki
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAssociatedWikisResponse> ListAssociatedWikisAsync(ListAssociatedWikisRequest listAssociatedWikisRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listAssociatedWikisRequest.ProjectId.ToString());
            urlParam.Add("issue_id" , listAssociatedWikisRequest.IssueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/associated-wikis",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociatedWikisRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAssociatedWikisResponse>(response);
        }
        
        /// <summary>
        /// 获取子工作项
        ///
        /// 获取子工作项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListChildIssuesV4Response> ListChildIssuesV4Async(ListChildIssuesV4Request listChildIssuesV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listChildIssuesV4Request.ProjectId.ToString());
            urlParam.Add("issue_id" , listChildIssuesV4Request.IssueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/child",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listChildIssuesV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListChildIssuesV4Response>(response);
        }
        
        /// <summary>
        /// 查询当前工作项已经关联的代码提交记录 / 分支创建记录
        ///
        /// 查询当前工作项已经关联的代码提交记录 / 分支创建记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListIssueAssociatedCommitsResponse> ListIssueAssociatedCommitsAsync(ListIssueAssociatedCommitsRequest listIssueAssociatedCommitsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listIssueAssociatedCommitsRequest.ProjectId.ToString());
            urlParam.Add("issue_id" , listIssueAssociatedCommitsRequest.IssueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/associated-commits",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssueAssociatedCommitsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListIssueAssociatedCommitsResponse>(response);
        }
        
        /// <summary>
        /// 获取指定工作项的评论列表
        ///
        /// 获取工作项的评论
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListIssueCommentsV4Response> ListIssueCommentsV4Async(ListIssueCommentsV4Request listIssueCommentsV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listIssueCommentsV4Request.ProjectId.ToString());
            urlParam.Add("issue_id" , listIssueCommentsV4Request.IssueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/comments",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssueCommentsV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListIssueCommentsV4Response>(response);
        }
        
        /// <summary>
        /// 查询Scrum工作项自定义字段
        ///
        /// 查询Scrum工作项自定义字段的可选列表,符合custom_fields或者names条件的都返回,2个值都不传，返回所有的自定义字段列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListIssueCustomFieldsResponse> ListIssueCustomFieldsAsync(ListIssueCustomFieldsRequest listIssueCustomFieldsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listIssueCustomFieldsRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/custom-fields",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssueCustomFieldsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListIssueCustomFieldsResponse>(response);
        }
        
        /// <summary>
        /// 获取工作项历史记录
        ///
        /// 获取工作项历史记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListIssueRecordsV4Response> ListIssueRecordsV4Async(ListIssueRecordsV4Request listIssueRecordsV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listIssueRecordsV4Request.ProjectId.ToString());
            urlParam.Add("issue_id" , listIssueRecordsV4Request.IssueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issue/{issue_id}/records",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssueRecordsV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListIssueRecordsV4Response>(response);
        }
        
        /// <summary>
        /// 查询项目的工作项
        ///
        /// 工作项类型id, 分页参数，创建时间查询项目的工作项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListIssuesSfV4Response> ListIssuesSfV4Async(ListIssuesSfV4Request listIssuesSfV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listIssuesSfV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssuesSfV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListIssuesSfV4Response>(response);
        }
        
        /// <summary>
        /// 高级查询工作项
        ///
        /// 根据筛选条件查询工作项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListIssuesV4Response> ListIssuesV4Async(ListIssuesV4Request listIssuesV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listIssuesV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssuesV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListIssuesV4Response>(response);
        }
        
        /// <summary>
        /// 查看迭代历史记录
        ///
        /// 查看迭代历史记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListIterationHistoriesResponse> ListIterationHistoriesAsync(ListIterationHistoriesRequest listIterationHistoriesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("iteration_id" , listIterationHistoriesRequest.IterationId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/iterations/{iteration_id}/histories",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIterationHistoriesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListIterationHistoriesResponse>(response);
        }
        
        /// <summary>
        /// 查询项目的领域列表
        ///
        /// 查询项目的领域列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectDomainsResponse> ListProjectDomainsAsync(ListProjectDomainsRequest listProjectDomainsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listProjectDomainsRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/domains",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectDomainsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectDomainsResponse>(response);
        }
        
        /// <summary>
        /// 查询项目下所有工作项的历史记录
        ///
        /// 查询项目下所有工作项的历史记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectIssuesRecordsV4Response> ListProjectIssuesRecordsV4Async(ListProjectIssuesRecordsV4Request listProjectIssuesRecordsV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listProjectIssuesRecordsV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/records",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectIssuesRecordsV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectIssuesRecordsV4Response>(response);
        }
        
        /// <summary>
        /// 获取指定项目的迭代列表
        ///
        /// 获取项目迭代
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectIterationsV4Response> ListProjectIterationsV4Async(ListProjectIterationsV4Request listProjectIterationsV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listProjectIterationsV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/iterations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectIterationsV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectIterationsV4Response>(response);
        }
        
        /// <summary>
        /// 查询项目的模块列表
        ///
        /// 查询项目的模块列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectModulesResponse> ListProjectModulesAsync(ListProjectModulesRequest listProjectModulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listProjectModulesRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/modules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectModulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectModulesResponse>(response);
        }
        
        /// <summary>
        /// 按用户查询工时（多项目）
        ///
        /// 按用户查询工时（多项目）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectWorkHoursResponse> ListProjectWorkHoursAsync(ListProjectWorkHoursRequest listProjectWorkHoursRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/work-hours",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectWorkHoursRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListProjectWorkHoursResponse>(response);
        }
        
        /// <summary>
        /// 查询项目的状态列表
        ///
        /// 查询项目的状态列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScrumProjectStatusesResponse> ListScrumProjectStatusesAsync(ListScrumProjectStatusesRequest listScrumProjectStatusesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listScrumProjectStatusesRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/statuses",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScrumProjectStatusesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScrumProjectStatusesResponse>(response);
        }
        
        /// <summary>
        /// 获取指定工作项停留时间
        ///
        /// 获取指定工作项停留时间
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSpecIssueStayTimesResponse> ListSpecIssueStayTimesAsync(ListSpecIssueStayTimesRequest listSpecIssueStayTimesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v4/issues/duration",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSpecIssueStayTimesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListSpecIssueStayTimesResponse>(response);
        }
        
        /// <summary>
        /// 查询迭代下工作项状态的统计数据（处理人维度）
        ///
        /// 查询迭代下工作项状态的统计数据（处理人维度）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStatusStatisticResponse> ListStatusStatisticAsync(ListStatusStatisticRequest listStatusStatisticRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listStatusStatisticRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/status-statistic",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStatusStatisticRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            ListStatusStatisticResponse listStatusStatisticResponse = JsonUtils.DeSerializeNull<ListStatusStatisticResponse>(response);
            listStatusStatisticResponse.Body = JsonUtils.DeSerializeList<UserStatusStatistic>(response);
            return listStatusStatisticResponse;
        }
        
        /// <summary>
        /// 获取工作项完成率
        ///
        /// 获取工作项的完成率
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowIssueCompletionRateResponse> ShowIssueCompletionRateAsync(ShowIssueCompletionRateRequest showIssueCompletionRateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showIssueCompletionRateRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issue-completion-rate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIssueCompletionRateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowIssueCompletionRateResponse>(response);
        }
        
        /// <summary>
        /// 查询工作项详情
        ///
        /// 查询工作项详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowIssueV4Response> ShowIssueV4Async(ShowIssueV4Request showIssueV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showIssueV4Request.ProjectId.ToString());
            urlParam.Add("issue_id" , showIssueV4Request.IssueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIssueV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowIssueV4Response>(response);
        }
        
        /// <summary>
        /// 查询Scrum项目的工作项流转配置
        ///
        /// 查询Scrum项目的工作项流转配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowIssuesWrokFlowConfigResponse> ShowIssuesWrokFlowConfigAsync(ShowIssuesWrokFlowConfigRequest showIssuesWrokFlowConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showIssuesWrokFlowConfigRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/workflow/config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIssuesWrokFlowConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowIssuesWrokFlowConfigResponse>(response);
        }
        
        /// <summary>
        /// 查看迭代详情
        ///
        /// 查看迭代详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowIterationV4Response> ShowIterationV4Async(ShowIterationV4Request showIterationV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("iteration_id" , showIterationV4Request.IterationId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/iterations/{iteration_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIterationV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowIterationV4Response>(response);
        }
        
        /// <summary>
        /// 按用户查询工时（单项目）
        ///
        /// 按用户查询工时（单项目）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectWorkHoursResponse> ShowProjectWorkHoursAsync(ShowProjectWorkHoursRequest showProjectWorkHoursRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showProjectWorkHoursRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/work-hours",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectWorkHoursRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowProjectWorkHoursResponse>(response);
        }
        
        /// <summary>
        /// 更新工作项
        ///
        /// 更新工作项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateIssueV4Response> UpdateIssueV4Async(UpdateIssueV4Request updateIssueV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , updateIssueV4Request.ProjectId.ToString());
            urlParam.Add("issue_id" , updateIssueV4Request.IssueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIssueV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateIssueV4Response>(response);
        }
        
        /// <summary>
        /// 更新Scrum项目迭代
        ///
        /// 更新Scrum项目迭代
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateIterationV4Response> UpdateIterationV4Async(UpdateIterationV4Request updateIterationV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , updateIterationV4Request.ProjectId.ToString());
            urlParam.Add("iteration_id" , updateIterationV4Request.IterationId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/iterations/{iteration_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIterationV4Request);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateIterationV4Response>(response);
        }
        
        /// <summary>
        /// 更新项目的领域
        ///
        /// 更新项目的领域
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateProjectDomainResponse> UpdateProjectDomainAsync(UpdateProjectDomainRequest updateProjectDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , updateProjectDomainRequest.ProjectId.ToString());
            urlParam.Add("domain_id" , updateProjectDomainRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/domains/{domain_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectDomainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateProjectDomainResponse>(response);
        }
        
        /// <summary>
        /// 更新项目的模块
        ///
        /// 更新项目的模块
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateProjectModuleResponse> UpdateProjectModuleAsync(UpdateProjectModuleRequest updateProjectModuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , updateProjectModuleRequest.ProjectId.ToString());
            urlParam.Add("module_id" , updateProjectModuleRequest.ModuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/modules/{module_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectModuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateProjectModuleResponse>(response);
        }
        
        /// <summary>
        /// 上传工作项附件
        ///
        /// 上传工作项附件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UploadAttachmentsResponse> UploadAttachmentsAsync(UploadAttachmentsRequest uploadAttachmentsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , uploadAttachmentsRequest.ProjectId.ToString());
            urlParam.Add("issue_id" , uploadAttachmentsRequest.IssueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/attachments/upload",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadAttachmentsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UploadAttachmentsResponse>(response);
        }
        
        /// <summary>
        /// 上传图片
        ///
        /// 上传图片
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UploadIssueImgResponse> UploadIssueImgAsync(UploadIssueImgRequest uploadIssueImgRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , uploadIssueImgRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/img",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadIssueImgRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UploadIssueImgResponse>(response);
        }
        
    }
}