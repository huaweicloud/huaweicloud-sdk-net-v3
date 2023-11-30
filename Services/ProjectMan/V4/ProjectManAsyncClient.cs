using System;
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", addApplyJoinProjectForAgcRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members/agc-join",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addApplyJoinProjectForAgcRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerializeNull<AddApplyJoinProjectForAgcResponse>(response);
        }

        public AsyncInvoker<AddApplyJoinProjectForAgcResponse> AddApplyJoinProjectForAgcAsyncInvoker(AddApplyJoinProjectForAgcRequest addApplyJoinProjectForAgcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", addApplyJoinProjectForAgcRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members/agc-join",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addApplyJoinProjectForAgcRequest);
            return new AsyncInvoker<AddApplyJoinProjectForAgcResponse>(this, "GET", request, JsonUtils.DeSerializeNull<AddApplyJoinProjectForAgcResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", addMemberV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/member",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addMemberV4Request);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<AddMemberV4Response>(response);
        }

        public AsyncInvoker<AddMemberV4Response> AddMemberV4AsyncInvoker(AddMemberV4Request addMemberV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", addMemberV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/member",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addMemberV4Request);
            return new AsyncInvoker<AddMemberV4Response>(this, "POST", request, JsonUtils.DeSerializeNull<AddMemberV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", batchAddMembersV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddMembersV4Request);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchAddMembersV4Response>(response);
        }

        public AsyncInvoker<BatchAddMembersV4Response> BatchAddMembersV4AsyncInvoker(BatchAddMembersV4Request batchAddMembersV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", batchAddMembersV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAddMembersV4Request);
            return new AsyncInvoker<BatchAddMembersV4Response>(this, "POST", request, JsonUtils.DeSerializeNull<BatchAddMembersV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", batchDeleteMembersV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteMembersV4Request);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<BatchDeleteMembersV4Response>(response);
        }

        public AsyncInvoker<BatchDeleteMembersV4Response> BatchDeleteMembersV4AsyncInvoker(BatchDeleteMembersV4Request batchDeleteMembersV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", batchDeleteMembersV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteMembersV4Request);
            return new AsyncInvoker<BatchDeleteMembersV4Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<BatchDeleteMembersV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/domain/child-users",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateChildNickNamesRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<BatchUpdateChildNickNamesResponse>(response);
        }

        public AsyncInvoker<BatchUpdateChildNickNamesResponse> BatchUpdateChildNickNamesAsyncInvoker(BatchUpdateChildNickNamesRequest batchUpdateChildNickNamesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/domain/child-users",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateChildNickNamesRequest);
            return new AsyncInvoker<BatchUpdateChildNickNamesResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<BatchUpdateChildNickNamesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/check-name",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkProjectNameV4Request);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CheckProjectNameV4Response>(response);
        }

        public AsyncInvoker<CheckProjectNameV4Response> CheckProjectNameV4AsyncInvoker(CheckProjectNameV4Request checkProjectNameV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/check-name",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkProjectNameV4Request);
            return new AsyncInvoker<CheckProjectNameV4Response>(this, "POST", request, JsonUtils.DeSerialize<CheckProjectNameV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/project",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectV4Request);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateProjectV4Response>(response);
        }

        public AsyncInvoker<CreateProjectV4Response> CreateProjectV4AsyncInvoker(CreateProjectV4Request createProjectV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/project",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectV4Request);
            return new AsyncInvoker<CreateProjectV4Response>(this, "POST", request, JsonUtils.DeSerialize<CreateProjectV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", deleteProjectV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProjectV4Request);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteProjectV4Response>(response);
        }

        public AsyncInvoker<DeleteProjectV4Response> DeleteProjectV4AsyncInvoker(DeleteProjectV4Request deleteProjectV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", deleteProjectV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProjectV4Request);
            return new AsyncInvoker<DeleteProjectV4Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteProjectV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/domain/not-added",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainNotAddedProjectsV4Request);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDomainNotAddedProjectsV4Response>(response);
        }

        public AsyncInvoker<ListDomainNotAddedProjectsV4Response> ListDomainNotAddedProjectsV4AsyncInvoker(ListDomainNotAddedProjectsV4Request listDomainNotAddedProjectsV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/domain/not-added",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainNotAddedProjectsV4Request);
            return new AsyncInvoker<ListDomainNotAddedProjectsV4Response>(this, "GET", request, JsonUtils.DeSerialize<ListDomainNotAddedProjectsV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectBugStaticsV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/bug-statistic",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectBugStaticsV4Request);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectBugStaticsV4Response>(response);
        }

        public AsyncInvoker<ListProjectBugStaticsV4Response> ListProjectBugStaticsV4AsyncInvoker(ListProjectBugStaticsV4Request listProjectBugStaticsV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectBugStaticsV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/bug-statistic",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectBugStaticsV4Request);
            return new AsyncInvoker<ListProjectBugStaticsV4Response>(this, "GET", request, JsonUtils.DeSerialize<ListProjectBugStaticsV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectDemandStaticV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/demand-statistic",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectDemandStaticV4Request);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectDemandStaticV4Response>(response);
        }

        public AsyncInvoker<ListProjectDemandStaticV4Response> ListProjectDemandStaticV4AsyncInvoker(ListProjectDemandStaticV4Request listProjectDemandStaticV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectDemandStaticV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/demand-statistic",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectDemandStaticV4Request);
            return new AsyncInvoker<ListProjectDemandStaticV4Response>(this, "GET", request, JsonUtils.DeSerialize<ListProjectDemandStaticV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectMembersV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectMembersV4Request);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectMembersV4Response>(response);
        }

        public AsyncInvoker<ListProjectMembersV4Response> ListProjectMembersV4AsyncInvoker(ListProjectMembersV4Request listProjectMembersV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectMembersV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectMembersV4Request);
            return new AsyncInvoker<ListProjectMembersV4Response>(this, "GET", request, JsonUtils.DeSerialize<ListProjectMembersV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/projects",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectsV4Request);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectsV4Response>(response);
        }

        public AsyncInvoker<ListProjectsV4Response> ListProjectsV4AsyncInvoker(ListProjectsV4Request listProjectsV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/projects",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectsV4Request);
            return new AsyncInvoker<ListProjectsV4Response>(this, "GET", request, JsonUtils.DeSerialize<ListProjectsV4Response>);
        }
        
        /// <summary>
        /// 查询项目模板
        ///
        /// 查询项目模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest listTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listTemplatesRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/templates",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplatesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTemplatesResponse>(response);
        }

        public AsyncInvoker<ListTemplatesResponse> ListTemplatesAsyncInvoker(ListTemplatesRequest listTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listTemplatesRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/templates",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplatesRequest);
            return new AsyncInvoker<ListTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTemplatesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listWorkitemStatusRecordsV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/work-items/status-records",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkitemStatusRecordsV4Request);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListWorkitemStatusRecordsV4Response>(response);
        }

        public AsyncInvoker<ListWorkitemStatusRecordsV4Response> ListWorkitemStatusRecordsV4AsyncInvoker(ListWorkitemStatusRecordsV4Request listWorkitemStatusRecordsV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listWorkitemStatusRecordsV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/work-items/status-records",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkitemStatusRecordsV4Request);
            return new AsyncInvoker<ListWorkitemStatusRecordsV4Response>(this, "GET", request, JsonUtils.DeSerialize<ListWorkitemStatusRecordsV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listWorkitemsRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/work-items",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkitemsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListWorkitemsResponse>(response);
        }

        public AsyncInvoker<ListWorkitemsResponse> ListWorkitemsAsyncInvoker(ListWorkitemsRequest listWorkitemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listWorkitemsRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/work-items",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkitemsRequest);
            return new AsyncInvoker<ListWorkitemsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWorkitemsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", removeProjectRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/quit",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeProjectRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<RemoveProjectResponse>(response);
        }

        public AsyncInvoker<RemoveProjectResponse> RemoveProjectAsyncInvoker(RemoveProjectRequest removeProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", removeProjectRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/quit",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeProjectRequest);
            return new AsyncInvoker<RemoveProjectResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RemoveProjectResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showBugDensityV2Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bug-density/query",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBugDensityV2Request);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowBugDensityV2Response>(response);
        }

        public AsyncInvoker<ShowBugDensityV2Response> ShowBugDensityV2AsyncInvoker(ShowBugDensityV2Request showBugDensityV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showBugDensityV2Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bug-density/query",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBugDensityV2Request);
            return new AsyncInvoker<ShowBugDensityV2Response>(this, "POST", request, JsonUtils.DeSerialize<ShowBugDensityV2Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showBugsPerDeveloperRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bugs-per-developer/query",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBugsPerDeveloperRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowBugsPerDeveloperResponse>(response);
        }

        public AsyncInvoker<ShowBugsPerDeveloperResponse> ShowBugsPerDeveloperAsyncInvoker(ShowBugsPerDeveloperRequest showBugsPerDeveloperRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showBugsPerDeveloperRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bugs-per-developer/query",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBugsPerDeveloperRequest);
            return new AsyncInvoker<ShowBugsPerDeveloperResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowBugsPerDeveloperResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showCompletionRateRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/completion-rate/query",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCompletionRateRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowCompletionRateResponse>(response);
        }

        public AsyncInvoker<ShowCompletionRateResponse> ShowCompletionRateAsyncInvoker(ShowCompletionRateRequest showCompletionRateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showCompletionRateRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/completion-rate/query",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCompletionRateRequest);
            return new AsyncInvoker<ShowCompletionRateResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowCompletionRateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCurUserInfoRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCurUserInfoResponse>(response);
        }

        public AsyncInvoker<ShowCurUserInfoResponse> ShowCurUserInfoAsyncInvoker(ShowCurUserInfoRequest showCurUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCurUserInfoRequest);
            return new AsyncInvoker<ShowCurUserInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCurUserInfoResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showCurUserRoleRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/user-role",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCurUserRoleRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCurUserRoleResponse>(response);
        }

        public AsyncInvoker<ShowCurUserRoleResponse> ShowCurUserRoleAsyncInvoker(ShowCurUserRoleRequest showCurUserRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showCurUserRoleRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/user-role",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCurUserRoleRequest);
            return new AsyncInvoker<ShowCurUserRoleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCurUserRoleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showProjectInfoV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectInfoV4Request);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowProjectInfoV4Response>(response);
        }

        public AsyncInvoker<ShowProjectInfoV4Response> ShowProjectInfoV4AsyncInvoker(ShowProjectInfoV4Request showProjectInfoV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showProjectInfoV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectInfoV4Request);
            return new AsyncInvoker<ShowProjectInfoV4Response>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectInfoV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showProjectSummaryV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/summary",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectSummaryV4Request);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowProjectSummaryV4Response>(response);
        }

        public AsyncInvoker<ShowProjectSummaryV4Response> ShowProjectSummaryV4AsyncInvoker(ShowProjectSummaryV4Request showProjectSummaryV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showProjectSummaryV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/summary",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectSummaryV4Request);
            return new AsyncInvoker<ShowProjectSummaryV4Response>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectSummaryV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showWorkItemWrokflowConfigRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/work-items/workflow/config",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkItemWrokflowConfigRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowWorkItemWrokflowConfigResponse>(response);
        }

        public AsyncInvoker<ShowWorkItemWrokflowConfigResponse> ShowWorkItemWrokflowConfigAsyncInvoker(ShowWorkItemWrokflowConfigRequest showWorkItemWrokflowConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showWorkItemWrokflowConfigRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/work-items/workflow/config",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkItemWrokflowConfigRequest);
            return new AsyncInvoker<ShowWorkItemWrokflowConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkItemWrokflowConfigResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", updateMembesRoleV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members/role",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMembesRoleV4Request);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateMembesRoleV4Response>(response);
        }

        public AsyncInvoker<UpdateMembesRoleV4Response> UpdateMembesRoleV4AsyncInvoker(UpdateMembesRoleV4Request updateMembesRoleV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", updateMembesRoleV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members/role",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMembesRoleV4Request);
            return new AsyncInvoker<UpdateMembesRoleV4Response>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateMembesRoleV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNickNameV4Request);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateNickNameV4Response>(response);
        }

        public AsyncInvoker<UpdateNickNameV4Response> UpdateNickNameV4AsyncInvoker(UpdateNickNameV4Request updateNickNameV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNickNameV4Request);
            return new AsyncInvoker<UpdateNickNameV4Response>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateNickNameV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", updateProjectV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectV4Request);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateProjectV4Response>(response);
        }

        public AsyncInvoker<UpdateProjectV4Response> UpdateProjectV4AsyncInvoker(UpdateProjectV4Request updateProjectV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", updateProjectV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectV4Request);
            return new AsyncInvoker<UpdateProjectV4Response>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateProjectV4Response>);
        }
        
        /// <summary>
        /// 添加指定工作项工时
        ///
        /// 添加指定工作项工时
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddIssueWorkHoursResponse> AddIssueWorkHoursAsync(AddIssueWorkHoursRequest addIssueWorkHoursRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", addIssueWorkHoursRequest.ProjectId.ToString());
            urlParam.Add("issue_id", addIssueWorkHoursRequest.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/work-hours",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addIssueWorkHoursRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddIssueWorkHoursResponse>(response);
        }

        public AsyncInvoker<AddIssueWorkHoursResponse> AddIssueWorkHoursAsyncInvoker(AddIssueWorkHoursRequest addIssueWorkHoursRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", addIssueWorkHoursRequest.ProjectId.ToString());
            urlParam.Add("issue_id", addIssueWorkHoursRequest.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/work-hours",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addIssueWorkHoursRequest);
            return new AsyncInvoker<AddIssueWorkHoursResponse>(this, "POST", request, JsonUtils.DeSerialize<AddIssueWorkHoursResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", batchDeleteIssuesV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteIssuesV4Request);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<BatchDeleteIssuesV4Response>(response);
        }

        public AsyncInvoker<BatchDeleteIssuesV4Response> BatchDeleteIssuesV4AsyncInvoker(BatchDeleteIssuesV4Request batchDeleteIssuesV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", batchDeleteIssuesV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteIssuesV4Request);
            return new AsyncInvoker<BatchDeleteIssuesV4Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<BatchDeleteIssuesV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", batchDeleteIterationsV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/iterations",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteIterationsV4Request);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<BatchDeleteIterationsV4Response>(response);
        }

        public AsyncInvoker<BatchDeleteIterationsV4Response> BatchDeleteIterationsV4AsyncInvoker(BatchDeleteIterationsV4Request batchDeleteIterationsV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", batchDeleteIterationsV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/iterations",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteIterationsV4Request);
            return new AsyncInvoker<BatchDeleteIterationsV4Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<BatchDeleteIterationsV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", cancelProjectDomainRequest.ProjectId.ToString());
            urlParam.Add("domain_id", cancelProjectDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/domains/{domain_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelProjectDomainRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<CancelProjectDomainResponse>(response);
        }

        public AsyncInvoker<CancelProjectDomainResponse> CancelProjectDomainAsyncInvoker(CancelProjectDomainRequest cancelProjectDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", cancelProjectDomainRequest.ProjectId.ToString());
            urlParam.Add("domain_id", cancelProjectDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/domains/{domain_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelProjectDomainRequest);
            return new AsyncInvoker<CancelProjectDomainResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CancelProjectDomainResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", createCustomfieldsRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/custom-fields",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCustomfieldsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateCustomfieldsResponse>(response);
        }

        public AsyncInvoker<CreateCustomfieldsResponse> CreateCustomfieldsAsyncInvoker(CreateCustomfieldsRequest createCustomfieldsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", createCustomfieldsRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/custom-fields",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCustomfieldsRequest);
            return new AsyncInvoker<CreateCustomfieldsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCustomfieldsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", createIssueV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issue",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIssueV4Request);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateIssueV4Response>(response);
        }

        public AsyncInvoker<CreateIssueV4Response> CreateIssueV4AsyncInvoker(CreateIssueV4Request createIssueV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", createIssueV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issue",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIssueV4Request);
            return new AsyncInvoker<CreateIssueV4Response>(this, "POST", request, JsonUtils.DeSerialize<CreateIssueV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", createIterationV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/iteration",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIterationV4Request);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateIterationV4Response>(response);
        }

        public AsyncInvoker<CreateIterationV4Response> CreateIterationV4AsyncInvoker(CreateIterationV4Request createIterationV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", createIterationV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/iteration",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIterationV4Request);
            return new AsyncInvoker<CreateIterationV4Response>(this, "POST", request, JsonUtils.DeSerialize<CreateIterationV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", createProjectDomainRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/domain",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectDomainRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateProjectDomainResponse>(response);
        }

        public AsyncInvoker<CreateProjectDomainResponse> CreateProjectDomainAsyncInvoker(CreateProjectDomainRequest createProjectDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", createProjectDomainRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/domain",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectDomainRequest);
            return new AsyncInvoker<CreateProjectDomainResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProjectDomainResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", createProjectModuleRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/module",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectModuleRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateProjectModuleResponse>(response);
        }

        public AsyncInvoker<CreateProjectModuleResponse> CreateProjectModuleAsyncInvoker(CreateProjectModuleRequest createProjectModuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", createProjectModuleRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/module",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectModuleRequest);
            return new AsyncInvoker<CreateProjectModuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProjectModuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", createSystemIssueV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/system/issue",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSystemIssueV4Request);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSystemIssueV4Response>(response);
        }

        public AsyncInvoker<CreateSystemIssueV4Response> CreateSystemIssueV4AsyncInvoker(CreateSystemIssueV4Request createSystemIssueV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", createSystemIssueV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/system/issue",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSystemIssueV4Request);
            return new AsyncInvoker<CreateSystemIssueV4Response>(this, "POST", request, JsonUtils.DeSerialize<CreateSystemIssueV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", deleteAttachmentRequest.ProjectId.ToString());
            urlParam.Add("issue_id", deleteAttachmentRequest.IssueId.ToString());
            urlParam.Add("attachment_id", deleteAttachmentRequest.AttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/attachments/{attachment_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAttachmentRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAttachmentResponse>(response);
        }

        public AsyncInvoker<DeleteAttachmentResponse> DeleteAttachmentAsyncInvoker(DeleteAttachmentRequest deleteAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", deleteAttachmentRequest.ProjectId.ToString());
            urlParam.Add("issue_id", deleteAttachmentRequest.IssueId.ToString());
            urlParam.Add("attachment_id", deleteAttachmentRequest.AttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/attachments/{attachment_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAttachmentRequest);
            return new AsyncInvoker<DeleteAttachmentResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAttachmentResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", deleteIssueV4Request.ProjectId.ToString());
            urlParam.Add("issue_id", deleteIssueV4Request.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIssueV4Request);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteIssueV4Response>(response);
        }

        public AsyncInvoker<DeleteIssueV4Response> DeleteIssueV4AsyncInvoker(DeleteIssueV4Request deleteIssueV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", deleteIssueV4Request.ProjectId.ToString());
            urlParam.Add("issue_id", deleteIssueV4Request.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIssueV4Request);
            return new AsyncInvoker<DeleteIssueV4Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteIssueV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", deleteIterationV4Request.ProjectId.ToString());
            urlParam.Add("iteration_id", deleteIterationV4Request.IterationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/iterations/{iteration_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIterationV4Request);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteIterationV4Response>(response);
        }

        public AsyncInvoker<DeleteIterationV4Response> DeleteIterationV4AsyncInvoker(DeleteIterationV4Request deleteIterationV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", deleteIterationV4Request.ProjectId.ToString());
            urlParam.Add("iteration_id", deleteIterationV4Request.IterationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/iterations/{iteration_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIterationV4Request);
            return new AsyncInvoker<DeleteIterationV4Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteIterationV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", deleteProjectModuleRequest.ProjectId.ToString());
            urlParam.Add("module_id", deleteProjectModuleRequest.ModuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/modules/{module_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProjectModuleRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteProjectModuleResponse>(response);
        }

        public AsyncInvoker<DeleteProjectModuleResponse> DeleteProjectModuleAsyncInvoker(DeleteProjectModuleRequest deleteProjectModuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", deleteProjectModuleRequest.ProjectId.ToString());
            urlParam.Add("module_id", deleteProjectModuleRequest.ModuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/modules/{module_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProjectModuleRequest);
            return new AsyncInvoker<DeleteProjectModuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteProjectModuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", downloadAttachmentRequest.ProjectId.ToString());
            urlParam.Add("issue_id", downloadAttachmentRequest.IssueId.ToString());
            urlParam.Add("attachment_id", downloadAttachmentRequest.AttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/attachments/{attachment_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAttachmentRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<DownloadAttachmentResponse>(response);
        }

        public AsyncInvoker<DownloadAttachmentResponse> DownloadAttachmentAsyncInvoker(DownloadAttachmentRequest downloadAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", downloadAttachmentRequest.ProjectId.ToString());
            urlParam.Add("issue_id", downloadAttachmentRequest.IssueId.ToString());
            urlParam.Add("attachment_id", downloadAttachmentRequest.AttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/attachments/{attachment_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadAttachmentRequest);
            return new AsyncInvoker<DownloadAttachmentResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadAttachmentResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", downloadImageFileRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/image-file",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadImageFileRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<DownloadImageFileResponse>(response);
        }

        public AsyncInvoker<DownloadImageFileResponse> DownloadImageFileAsyncInvoker(DownloadImageFileRequest downloadImageFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", downloadImageFileRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/image-file",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadImageFileRequest);
            return new AsyncInvoker<DownloadImageFileResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadImageFileResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listAssociatedIssuesRequest.ProjectId.ToString());
            urlParam.Add("issue_id", listAssociatedIssuesRequest.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/associated-issues",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociatedIssuesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAssociatedIssuesResponse>(response);
        }

        public AsyncInvoker<ListAssociatedIssuesResponse> ListAssociatedIssuesAsyncInvoker(ListAssociatedIssuesRequest listAssociatedIssuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listAssociatedIssuesRequest.ProjectId.ToString());
            urlParam.Add("issue_id", listAssociatedIssuesRequest.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/associated-issues",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociatedIssuesRequest);
            return new AsyncInvoker<ListAssociatedIssuesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAssociatedIssuesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listAssociatedTestCasesRequest.ProjectId.ToString());
            urlParam.Add("issue_id", listAssociatedTestCasesRequest.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/associate-test-cases",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociatedTestCasesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAssociatedTestCasesResponse>(response);
        }

        public AsyncInvoker<ListAssociatedTestCasesResponse> ListAssociatedTestCasesAsyncInvoker(ListAssociatedTestCasesRequest listAssociatedTestCasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listAssociatedTestCasesRequest.ProjectId.ToString());
            urlParam.Add("issue_id", listAssociatedTestCasesRequest.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/associate-test-cases",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociatedTestCasesRequest);
            return new AsyncInvoker<ListAssociatedTestCasesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAssociatedTestCasesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listAssociatedWikisRequest.ProjectId.ToString());
            urlParam.Add("issue_id", listAssociatedWikisRequest.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/associated-wikis",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociatedWikisRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAssociatedWikisResponse>(response);
        }

        public AsyncInvoker<ListAssociatedWikisResponse> ListAssociatedWikisAsyncInvoker(ListAssociatedWikisRequest listAssociatedWikisRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listAssociatedWikisRequest.ProjectId.ToString());
            urlParam.Add("issue_id", listAssociatedWikisRequest.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/associated-wikis",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociatedWikisRequest);
            return new AsyncInvoker<ListAssociatedWikisResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAssociatedWikisResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listChildIssuesV4Request.ProjectId.ToString());
            urlParam.Add("issue_id", listChildIssuesV4Request.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/child",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listChildIssuesV4Request);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListChildIssuesV4Response>(response);
        }

        public AsyncInvoker<ListChildIssuesV4Response> ListChildIssuesV4AsyncInvoker(ListChildIssuesV4Request listChildIssuesV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listChildIssuesV4Request.ProjectId.ToString());
            urlParam.Add("issue_id", listChildIssuesV4Request.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/child",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listChildIssuesV4Request);
            return new AsyncInvoker<ListChildIssuesV4Response>(this, "GET", request, JsonUtils.DeSerialize<ListChildIssuesV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listIssueAssociatedCommitsRequest.ProjectId.ToString());
            urlParam.Add("issue_id", listIssueAssociatedCommitsRequest.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/associated-commits",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssueAssociatedCommitsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListIssueAssociatedCommitsResponse>(response);
        }

        public AsyncInvoker<ListIssueAssociatedCommitsResponse> ListIssueAssociatedCommitsAsyncInvoker(ListIssueAssociatedCommitsRequest listIssueAssociatedCommitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listIssueAssociatedCommitsRequest.ProjectId.ToString());
            urlParam.Add("issue_id", listIssueAssociatedCommitsRequest.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/associated-commits",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssueAssociatedCommitsRequest);
            return new AsyncInvoker<ListIssueAssociatedCommitsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIssueAssociatedCommitsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listIssueCommentsV4Request.ProjectId.ToString());
            urlParam.Add("issue_id", listIssueCommentsV4Request.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/comments",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssueCommentsV4Request);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListIssueCommentsV4Response>(response);
        }

        public AsyncInvoker<ListIssueCommentsV4Response> ListIssueCommentsV4AsyncInvoker(ListIssueCommentsV4Request listIssueCommentsV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listIssueCommentsV4Request.ProjectId.ToString());
            urlParam.Add("issue_id", listIssueCommentsV4Request.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/comments",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssueCommentsV4Request);
            return new AsyncInvoker<ListIssueCommentsV4Response>(this, "GET", request, JsonUtils.DeSerialize<ListIssueCommentsV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listIssueCustomFieldsRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/custom-fields",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssueCustomFieldsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListIssueCustomFieldsResponse>(response);
        }

        public AsyncInvoker<ListIssueCustomFieldsResponse> ListIssueCustomFieldsAsyncInvoker(ListIssueCustomFieldsRequest listIssueCustomFieldsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listIssueCustomFieldsRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/custom-fields",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssueCustomFieldsRequest);
            return new AsyncInvoker<ListIssueCustomFieldsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListIssueCustomFieldsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listIssueRecordsV4Request.ProjectId.ToString());
            urlParam.Add("issue_id", listIssueRecordsV4Request.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issue/{issue_id}/records",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssueRecordsV4Request);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListIssueRecordsV4Response>(response);
        }

        public AsyncInvoker<ListIssueRecordsV4Response> ListIssueRecordsV4AsyncInvoker(ListIssueRecordsV4Request listIssueRecordsV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listIssueRecordsV4Request.ProjectId.ToString());
            urlParam.Add("issue_id", listIssueRecordsV4Request.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issue/{issue_id}/records",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssueRecordsV4Request);
            return new AsyncInvoker<ListIssueRecordsV4Response>(this, "GET", request, JsonUtils.DeSerialize<ListIssueRecordsV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listIssuesSfV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssuesSfV4Request);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListIssuesSfV4Response>(response);
        }

        public AsyncInvoker<ListIssuesSfV4Response> ListIssuesSfV4AsyncInvoker(ListIssuesSfV4Request listIssuesSfV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listIssuesSfV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssuesSfV4Request);
            return new AsyncInvoker<ListIssuesSfV4Response>(this, "GET", request, JsonUtils.DeSerialize<ListIssuesSfV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listIssuesV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssuesV4Request);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListIssuesV4Response>(response);
        }

        public AsyncInvoker<ListIssuesV4Response> ListIssuesV4AsyncInvoker(ListIssuesV4Request listIssuesV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listIssuesV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssuesV4Request);
            return new AsyncInvoker<ListIssuesV4Response>(this, "POST", request, JsonUtils.DeSerialize<ListIssuesV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("iteration_id", listIterationHistoriesRequest.IterationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/iterations/{iteration_id}/histories",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIterationHistoriesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListIterationHistoriesResponse>(response);
        }

        public AsyncInvoker<ListIterationHistoriesResponse> ListIterationHistoriesAsyncInvoker(ListIterationHistoriesRequest listIterationHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("iteration_id", listIterationHistoriesRequest.IterationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/iterations/{iteration_id}/histories",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIterationHistoriesRequest);
            return new AsyncInvoker<ListIterationHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIterationHistoriesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectDomainsRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/domains",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectDomainsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectDomainsResponse>(response);
        }

        public AsyncInvoker<ListProjectDomainsResponse> ListProjectDomainsAsyncInvoker(ListProjectDomainsRequest listProjectDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectDomainsRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/domains",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectDomainsRequest);
            return new AsyncInvoker<ListProjectDomainsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectDomainsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectIssuesRecordsV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/records",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectIssuesRecordsV4Request);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectIssuesRecordsV4Response>(response);
        }

        public AsyncInvoker<ListProjectIssuesRecordsV4Response> ListProjectIssuesRecordsV4AsyncInvoker(ListProjectIssuesRecordsV4Request listProjectIssuesRecordsV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectIssuesRecordsV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/records",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectIssuesRecordsV4Request);
            return new AsyncInvoker<ListProjectIssuesRecordsV4Response>(this, "GET", request, JsonUtils.DeSerialize<ListProjectIssuesRecordsV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectIterationsV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/iterations",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectIterationsV4Request);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectIterationsV4Response>(response);
        }

        public AsyncInvoker<ListProjectIterationsV4Response> ListProjectIterationsV4AsyncInvoker(ListProjectIterationsV4Request listProjectIterationsV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectIterationsV4Request.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/iterations",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectIterationsV4Request);
            return new AsyncInvoker<ListProjectIterationsV4Response>(this, "GET", request, JsonUtils.DeSerialize<ListProjectIterationsV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectModulesRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/modules",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectModulesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectModulesResponse>(response);
        }

        public AsyncInvoker<ListProjectModulesResponse> ListProjectModulesAsyncInvoker(ListProjectModulesRequest listProjectModulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectModulesRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/modules",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectModulesRequest);
            return new AsyncInvoker<ListProjectModulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectModulesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/work-hours",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectWorkHoursRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListProjectWorkHoursResponse>(response);
        }

        public AsyncInvoker<ListProjectWorkHoursResponse> ListProjectWorkHoursAsyncInvoker(ListProjectWorkHoursRequest listProjectWorkHoursRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/work-hours",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectWorkHoursRequest);
            return new AsyncInvoker<ListProjectWorkHoursResponse>(this, "POST", request, JsonUtils.DeSerialize<ListProjectWorkHoursResponse>);
        }
        
        /// <summary>
        /// 查询项目下的工时类型
        ///
        /// 查询项目下的工时类型
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectWorkHoursTypeResponse> ListProjectWorkHoursTypeAsync(ListProjectWorkHoursTypeRequest listProjectWorkHoursTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectWorkHoursTypeRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/work-hours-type",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectWorkHoursTypeRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectWorkHoursTypeResponse>(response);
        }

        public AsyncInvoker<ListProjectWorkHoursTypeResponse> ListProjectWorkHoursTypeAsyncInvoker(ListProjectWorkHoursTypeRequest listProjectWorkHoursTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectWorkHoursTypeRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/work-hours-type",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectWorkHoursTypeRequest);
            return new AsyncInvoker<ListProjectWorkHoursTypeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectWorkHoursTypeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listScrumProjectStatusesRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/statuses",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScrumProjectStatusesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScrumProjectStatusesResponse>(response);
        }

        public AsyncInvoker<ListScrumProjectStatusesResponse> ListScrumProjectStatusesAsyncInvoker(ListScrumProjectStatusesRequest listScrumProjectStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listScrumProjectStatusesRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/statuses",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScrumProjectStatusesRequest);
            return new AsyncInvoker<ListScrumProjectStatusesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScrumProjectStatusesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/issues/duration",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSpecIssueStayTimesRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListSpecIssueStayTimesResponse>(response);
        }

        public AsyncInvoker<ListSpecIssueStayTimesResponse> ListSpecIssueStayTimesAsyncInvoker(ListSpecIssueStayTimesRequest listSpecIssueStayTimesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/issues/duration",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSpecIssueStayTimesRequest);
            return new AsyncInvoker<ListSpecIssueStayTimesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSpecIssueStayTimesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listStatusStatisticRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/status-statistic",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStatusStatisticRequest);
            var response = await DoHttpRequestAsync("GET",request);
            var listStatusStatisticResponse = JsonUtils.DeSerializeNull<ListStatusStatisticResponse>(response);
            listStatusStatisticResponse.Body = JsonUtils.DeSerializeList<UserStatusStatistic>(response);
            return listStatusStatisticResponse;
        }

        public AsyncInvoker<ListStatusStatisticResponse> ListStatusStatisticAsyncInvoker(ListStatusStatisticRequest listStatusStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listStatusStatisticRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/status-statistic",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStatusStatisticRequest);
            return new AsyncInvoker<ListStatusStatisticResponse>(this, "GET", request, response =>
            {
                var listStatusStatisticResponse = JsonUtils.DeSerializeNull<ListStatusStatisticResponse>(response);
                listStatusStatisticResponse.Body = JsonUtils.DeSerializeList<UserStatusStatistic>(response);
                return listStatusStatisticResponse;
            });
        }
        
        /// <summary>
        /// 高级查询我的待办工作项
        ///
        /// 高级查询我的待办工作项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchIssuesResponse> SearchIssuesAsync(SearchIssuesRequest searchIssuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/issues",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchIssuesRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<SearchIssuesResponse>(response);
        }

        public AsyncInvoker<SearchIssuesResponse> SearchIssuesAsyncInvoker(SearchIssuesRequest searchIssuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/issues",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchIssuesRequest);
            return new AsyncInvoker<SearchIssuesResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchIssuesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showIssueCompletionRateRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issue-completion-rate",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIssueCompletionRateRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowIssueCompletionRateResponse>(response);
        }

        public AsyncInvoker<ShowIssueCompletionRateResponse> ShowIssueCompletionRateAsyncInvoker(ShowIssueCompletionRateRequest showIssueCompletionRateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showIssueCompletionRateRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issue-completion-rate",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIssueCompletionRateRequest);
            return new AsyncInvoker<ShowIssueCompletionRateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIssueCompletionRateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showIssueV4Request.ProjectId.ToString());
            urlParam.Add("issue_id", showIssueV4Request.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIssueV4Request);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowIssueV4Response>(response);
        }

        public AsyncInvoker<ShowIssueV4Response> ShowIssueV4AsyncInvoker(ShowIssueV4Request showIssueV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showIssueV4Request.ProjectId.ToString());
            urlParam.Add("issue_id", showIssueV4Request.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIssueV4Request);
            return new AsyncInvoker<ShowIssueV4Response>(this, "GET", request, JsonUtils.DeSerialize<ShowIssueV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showIssuesWrokFlowConfigRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/workflow/config",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIssuesWrokFlowConfigRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowIssuesWrokFlowConfigResponse>(response);
        }

        public AsyncInvoker<ShowIssuesWrokFlowConfigResponse> ShowIssuesWrokFlowConfigAsyncInvoker(ShowIssuesWrokFlowConfigRequest showIssuesWrokFlowConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showIssuesWrokFlowConfigRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/workflow/config",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIssuesWrokFlowConfigRequest);
            return new AsyncInvoker<ShowIssuesWrokFlowConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIssuesWrokFlowConfigResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("iteration_id", showIterationV4Request.IterationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/iterations/{iteration_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIterationV4Request);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowIterationV4Response>(response);
        }

        public AsyncInvoker<ShowIterationV4Response> ShowIterationV4AsyncInvoker(ShowIterationV4Request showIterationV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("iteration_id", showIterationV4Request.IterationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/iterations/{iteration_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIterationV4Request);
            return new AsyncInvoker<ShowIterationV4Response>(this, "GET", request, JsonUtils.DeSerialize<ShowIterationV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showProjectWorkHoursRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/work-hours",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectWorkHoursRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowProjectWorkHoursResponse>(response);
        }

        public AsyncInvoker<ShowProjectWorkHoursResponse> ShowProjectWorkHoursAsyncInvoker(ShowProjectWorkHoursRequest showProjectWorkHoursRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showProjectWorkHoursRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/work-hours",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectWorkHoursRequest);
            return new AsyncInvoker<ShowProjectWorkHoursResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowProjectWorkHoursResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", updateIssueV4Request.ProjectId.ToString());
            urlParam.Add("issue_id", updateIssueV4Request.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIssueV4Request);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateIssueV4Response>(response);
        }

        public AsyncInvoker<UpdateIssueV4Response> UpdateIssueV4AsyncInvoker(UpdateIssueV4Request updateIssueV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", updateIssueV4Request.ProjectId.ToString());
            urlParam.Add("issue_id", updateIssueV4Request.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIssueV4Request);
            return new AsyncInvoker<UpdateIssueV4Response>(this, "PUT", request, JsonUtils.DeSerialize<UpdateIssueV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", updateIterationV4Request.ProjectId.ToString());
            urlParam.Add("iteration_id", updateIterationV4Request.IterationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/iterations/{iteration_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIterationV4Request);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateIterationV4Response>(response);
        }

        public AsyncInvoker<UpdateIterationV4Response> UpdateIterationV4AsyncInvoker(UpdateIterationV4Request updateIterationV4Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", updateIterationV4Request.ProjectId.ToString());
            urlParam.Add("iteration_id", updateIterationV4Request.IterationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/iterations/{iteration_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIterationV4Request);
            return new AsyncInvoker<UpdateIterationV4Response>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateIterationV4Response>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", updateProjectDomainRequest.ProjectId.ToString());
            urlParam.Add("domain_id", updateProjectDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/domains/{domain_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectDomainRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateProjectDomainResponse>(response);
        }

        public AsyncInvoker<UpdateProjectDomainResponse> UpdateProjectDomainAsyncInvoker(UpdateProjectDomainRequest updateProjectDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", updateProjectDomainRequest.ProjectId.ToString());
            urlParam.Add("domain_id", updateProjectDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/domains/{domain_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectDomainRequest);
            return new AsyncInvoker<UpdateProjectDomainResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProjectDomainResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", updateProjectModuleRequest.ProjectId.ToString());
            urlParam.Add("module_id", updateProjectModuleRequest.ModuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/modules/{module_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectModuleRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateProjectModuleResponse>(response);
        }

        public AsyncInvoker<UpdateProjectModuleResponse> UpdateProjectModuleAsyncInvoker(UpdateProjectModuleRequest updateProjectModuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", updateProjectModuleRequest.ProjectId.ToString());
            urlParam.Add("module_id", updateProjectModuleRequest.ModuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/modules/{module_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectModuleRequest);
            return new AsyncInvoker<UpdateProjectModuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProjectModuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", uploadAttachmentsRequest.ProjectId.ToString());
            urlParam.Add("issue_id", uploadAttachmentsRequest.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/attachments/upload",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadAttachmentsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UploadAttachmentsResponse>(response);
        }

        public AsyncInvoker<UploadAttachmentsResponse> UploadAttachmentsAsyncInvoker(UploadAttachmentsRequest uploadAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", uploadAttachmentsRequest.ProjectId.ToString());
            urlParam.Add("issue_id", uploadAttachmentsRequest.IssueId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/issues/{issue_id}/attachments/upload",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadAttachmentsRequest);
            return new AsyncInvoker<UploadAttachmentsResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadAttachmentsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", uploadIssueImgRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/img",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadIssueImgRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UploadIssueImgResponse>(response);
        }

        public AsyncInvoker<UploadIssueImgResponse> UploadIssueImgAsyncInvoker(UploadIssueImgRequest uploadIssueImgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", uploadIssueImgRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/img",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadIssueImgRequest);
            return new AsyncInvoker<UploadIssueImgResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadIssueImgResponse>);
        }
        
    }
}