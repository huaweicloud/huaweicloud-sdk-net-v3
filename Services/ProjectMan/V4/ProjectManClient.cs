using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.ProjectMan.V4.Model;

namespace HuaweiCloud.SDK.ProjectMan.V4
{
    public partial class ProjectManClient : Client
    {
        public static ClientBuilder<ProjectManClient> NewBuilder()
        {
            return new ClientBuilder<ProjectManClient>();
        }

        
        /// <summary>
        /// 创建项目
        /// </summary>
        public CreateProjectV4Response CreateProjectV4(CreateProjectV4Request createProjectV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v4/project",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectV4Request);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateProjectV4Response>(response);
        }
        
        /// <summary>
        /// 获取租户没有加入的项目
        /// </summary>
        public ListDomainNotAddedProjectsV4Response ListDomainNotAddedProjectsV4(ListDomainNotAddedProjectsV4Request listDomainNotAddedProjectsV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/domain/not-added",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listDomainNotAddedProjectsV4Request);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDomainNotAddedProjectsV4Response>(response);
        }
        
        /// <summary>
        /// 获取指定工作项的评论列表
        /// </summary>
        public ListIssueCommentsV4Response ListIssueCommentsV4(ListIssueCommentsV4Request listIssueCommentsV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listIssueCommentsV4Request.ProjectId.ToString());
            urlParam.Add("issue_id" , listIssueCommentsV4Request.IssueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/comments",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listIssueCommentsV4Request);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListIssueCommentsV4Response>(response);
        }
        
        /// <summary>
        /// 获取工作项历史记录
        /// </summary>
        public ListIssueRecordsV4Response ListIssueRecordsV4(ListIssueRecordsV4Request listIssueRecordsV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listIssueRecordsV4Request.ProjectId.ToString());
            urlParam.Add("issue_id" , listIssueRecordsV4Request.IssueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issue/{issue_id}/records",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listIssueRecordsV4Request);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListIssueRecordsV4Response>(response);
        }
        
        /// <summary>
        /// 获取指定项目的成员用户列表
        /// </summary>
        public ListProjectMembersV4Response ListProjectMembersV4(ListProjectMembersV4Request listProjectMembersV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listProjectMembersV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listProjectMembersV4Request);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListProjectMembersV4Response>(response);
        }
        
        /// <summary>
        /// 获取指定项目的迭代列表
        /// </summary>
        public ListProjectVersionsV4Response ListProjectVersionsV4(ListProjectVersionsV4Request listProjectVersionsV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listProjectVersionsV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/iterations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listProjectVersionsV4Request);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListProjectVersionsV4Response>(response);
        }
        
        /// <summary>
        /// 按用户查询工时（多项目）
        /// </summary>
        public ListProjectWorkHoursResponse ListProjectWorkHours(ListProjectWorkHoursRequest listProjectWorkHoursRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/work-hours",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectWorkHoursRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListProjectWorkHoursResponse>(response);
        }
        
        /// <summary>
        /// 查询项目列表
        /// </summary>
        public ListProjectsV4Response ListProjectsV4(ListProjectsV4Request listProjectsV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v4/projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listProjectsV4Request);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListProjectsV4Response>(response);
        }
        
        /// <summary>
        /// 主动退出项目
        /// </summary>
        public RemoveProjectResponse RemoveProject(RemoveProjectRequest removeProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , removeProjectRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/quit",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, removeProjectRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<RemoveProjectResponse>(response);
        }
        
        /// <summary>
        /// 获取当前用户信息
        /// </summary>
        public ShowCurUserInfoResponse ShowCurUserInfo(ShowCurUserInfoRequest showCurUserInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v4/user",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showCurUserInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowCurUserInfoResponse>(response);
        }
        
        /// <summary>
        /// 获取当前用户角色
        /// </summary>
        public ShowCurUserRoleResponse ShowCurUserRole(ShowCurUserRoleRequest showCurUserRoleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showCurUserRoleRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/user-role",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showCurUserRoleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowCurUserRoleResponse>(response);
        }
        
        /// <summary>
        /// 按用户查询工时（单项目）
        /// </summary>
        public ShowProjectWorkHoursResponse ShowProjectWorkHours(ShowProjectWorkHoursRequest showProjectWorkHoursRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showProjectWorkHoursRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/work-hours",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectWorkHoursRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ShowProjectWorkHoursResponse>(response);
        }
        
        /// <summary>
        /// 获取工作项完成率
        /// </summary>
        public ShowtIssueCompletionRateResponse ShowtIssueCompletionRate(ShowtIssueCompletionRateRequest showtIssueCompletionRateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showtIssueCompletionRateRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issue-completion-rate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showtIssueCompletionRateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowtIssueCompletionRateResponse>(response);
        }
        
        /// <summary>
        /// 更新成员在项目中的角色
        /// </summary>
        public UpdateMembesRoleV4Response UpdateMembesRoleV4(UpdateMembesRoleV4Request updateMembesRoleV4Request)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , updateMembesRoleV4Request.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members/role",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMembesRoleV4Request);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateMembesRoleV4Response>(response);
        }
        
    }
}