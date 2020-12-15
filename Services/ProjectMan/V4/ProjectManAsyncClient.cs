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
        /// 批量删除项目的迭代
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
        /// 批量删除项目成员
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
        /// 检查项目名称是否存在
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
        /// 创建Scrum项目迭代
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
        /// 创建项目
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
        /// 删除项目迭代
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
        /// 删除项目
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
        /// 获取指定项目的迭代列表
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
        /// 获取指定项目的成员用户列表
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
        /// 主动退出项目
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
        /// 获取当前用户信息
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
        /// 查看迭代详情
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
        /// 获取项目概览
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
        /// 更新Scrum项目迭代
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
        /// 更新成员在项目中的角色
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
        /// 创建工作项
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
        /// 删除工作项
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
        /// 获取子工作项
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
        /// 获取指定工作项的评论列表
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
        /// 获取工作项历史记录
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
        /// 高级查询工作项
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
        /// 按用户查询工时（多项目）
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
        /// 查询工作项详情
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
        /// 按用户查询工时（单项目）
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
        /// 获取工作项完成率
        /// </summary>
        public async Task<ShowtIssueCompletionRateResponse> ShowtIssueCompletionRateAsync(ShowtIssueCompletionRateRequest showtIssueCompletionRateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showtIssueCompletionRateRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issue-completion-rate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showtIssueCompletionRateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowtIssueCompletionRateResponse>(response);
        }
        
        /// <summary>
        /// 更新工作项
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
        
    }
}