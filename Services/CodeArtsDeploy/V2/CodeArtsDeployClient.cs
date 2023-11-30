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
            urlParam.Add("app_id", deleteApplicationRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteApplicationResponse>(response);
        }

        public SyncInvoker<DeleteApplicationResponse> DeleteApplicationInvoker(DeleteApplicationRequest deleteApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", deleteApplicationRequest.AppId.ToString());
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
            urlParam.Add("task_id", deleteDeployTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeployTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDeployTaskResponse>(response);
        }

        public SyncInvoker<DeleteDeployTaskResponse> DeleteDeployTaskInvoker(DeleteDeployTaskRequest deleteDeployTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", deleteDeployTaskRequest.TaskId.ToString());
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
            urlParam.Add("project_id", listDeployTaskHistoryByDateRequest.ProjectId.ToString());
            urlParam.Add("id", listDeployTaskHistoryByDateRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/task/{id}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeployTaskHistoryByDateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDeployTaskHistoryByDateResponse>(response);
        }

        public SyncInvoker<ListDeployTaskHistoryByDateResponse> ListDeployTaskHistoryByDateInvoker(ListDeployTaskHistoryByDateRequest listDeployTaskHistoryByDateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listDeployTaskHistoryByDateRequest.ProjectId.ToString());
            urlParam.Add("id", listDeployTaskHistoryByDateRequest.Id.ToString());
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
            urlParam.Add("project_id", listDeployTasksRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeployTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDeployTasksResponse>(response);
        }

        public SyncInvoker<ListDeployTasksResponse> ListDeployTasksInvoker(ListDeployTasksRequest listDeployTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listDeployTasksRequest.ProjectId.ToString());
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
            urlParam.Add("app_id", showAppDetailByIdRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppDetailByIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAppDetailByIdResponse>(response);
        }

        public SyncInvoker<ShowAppDetailByIdResponse> ShowAppDetailByIdInvoker(ShowAppDetailByIdRequest showAppDetailByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", showAppDetailByIdRequest.AppId.ToString());
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
            urlParam.Add("task_id", showDeployTaskDetailRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeployTaskDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDeployTaskDetailResponse>(response);
        }

        public SyncInvoker<ShowDeployTaskDetailResponse> ShowDeployTaskDetailInvoker(ShowDeployTaskDetailRequest showDeployTaskDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", showDeployTaskDetailRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeployTaskDetailRequest);
            return new SyncInvoker<ShowDeployTaskDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeployTaskDetailResponse>);
        }
        
        /// <summary>
        /// 查询部署记录的执行参数
        ///
        /// 查询部署记录的执行参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowExecutionParamsResponse ShowExecutionParams(ShowExecutionParamsRequest showExecutionParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", showExecutionParamsRequest.TaskId.ToString());
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
            urlParam.Add("task_id", showExecutionParamsRequest.TaskId.ToString());
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
            urlParam.Add("task_id", startDeployTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDeployTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartDeployTaskResponse>(response);
        }

        public SyncInvoker<StartDeployTaskResponse> StartDeployTaskInvoker(StartDeployTaskRequest startDeployTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", startDeployTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDeployTaskRequest);
            return new SyncInvoker<StartDeployTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<StartDeployTaskResponse>);
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
            urlParam.Add("application_id", createEnvironmentRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEnvironmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateEnvironmentResponse>(response);
        }

        public SyncInvoker<CreateEnvironmentResponse> CreateEnvironmentInvoker(CreateEnvironmentRequest createEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", createEnvironmentRequest.ApplicationId.ToString());
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
            urlParam.Add("application_id", deleteEnvironmentRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", deleteEnvironmentRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnvironmentRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteEnvironmentResponse>(response);
        }

        public SyncInvoker<DeleteEnvironmentResponse> DeleteEnvironmentInvoker(DeleteEnvironmentRequest deleteEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", deleteEnvironmentRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", deleteEnvironmentRequest.EnvironmentId.ToString());
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
            urlParam.Add("application_id", deleteHostFromEnvironmentRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", deleteHostFromEnvironmentRequest.EnvironmentId.ToString());
            urlParam.Add("host_id", deleteHostFromEnvironmentRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHostFromEnvironmentRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteHostFromEnvironmentResponse>(response);
        }

        public SyncInvoker<DeleteHostFromEnvironmentResponse> DeleteHostFromEnvironmentInvoker(DeleteHostFromEnvironmentRequest deleteHostFromEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", deleteHostFromEnvironmentRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", deleteHostFromEnvironmentRequest.EnvironmentId.ToString());
            urlParam.Add("host_id", deleteHostFromEnvironmentRequest.HostId.ToString());
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
            urlParam.Add("application_id", importHostToEnvironmentRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", importHostToEnvironmentRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}/hosts/import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importHostToEnvironmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ImportHostToEnvironmentResponse>(response);
        }

        public SyncInvoker<ImportHostToEnvironmentResponse> ImportHostToEnvironmentInvoker(ImportHostToEnvironmentRequest importHostToEnvironmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", importHostToEnvironmentRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", importHostToEnvironmentRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}/hosts/import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importHostToEnvironmentRequest);
            return new SyncInvoker<ImportHostToEnvironmentResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportHostToEnvironmentResponse>);
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
            urlParam.Add("application_id", listEnvironmentsRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvironmentsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEnvironmentsResponse>(response);
        }

        public SyncInvoker<ListEnvironmentsResponse> ListEnvironmentsInvoker(ListEnvironmentsRequest listEnvironmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", listEnvironmentsRequest.ApplicationId.ToString());
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
            urlParam.Add("application_id", showEnvironmentDetailRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", showEnvironmentDetailRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvironmentDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEnvironmentDetailResponse>(response);
        }

        public SyncInvoker<ShowEnvironmentDetailResponse> ShowEnvironmentDetailInvoker(ShowEnvironmentDetailRequest showEnvironmentDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", showEnvironmentDetailRequest.ApplicationId.ToString());
            urlParam.Add("environment_id", showEnvironmentDetailRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvironmentDetailRequest);
            return new SyncInvoker<ShowEnvironmentDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEnvironmentDetailResponse>);
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
            urlParam.Add("group_id", createDeploymentHostRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeploymentHostRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDeploymentHostResponse>(response);
        }

        public SyncInvoker<CreateDeploymentHostResponse> CreateDeploymentHostInvoker(CreateDeploymentHostRequest createDeploymentHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", createDeploymentHostRequest.GroupId.ToString());
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
            urlParam.Add("group_id", createHostRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHostRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateHostResponse>(response);
        }

        public SyncInvoker<CreateHostResponse> CreateHostInvoker(CreateHostRequest createHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", createHostRequest.GroupId.ToString());
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
            urlParam.Add("group_id", deleteDeploymentHostRequest.GroupId.ToString());
            urlParam.Add("host_id", deleteDeploymentHostRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeploymentHostRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDeploymentHostResponse>(response);
        }

        public SyncInvoker<DeleteDeploymentHostResponse> DeleteDeploymentHostInvoker(DeleteDeploymentHostRequest deleteDeploymentHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteDeploymentHostRequest.GroupId.ToString());
            urlParam.Add("host_id", deleteDeploymentHostRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeploymentHostRequest);
            return new SyncInvoker<DeleteDeploymentHostResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDeploymentHostResponse>);
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
            urlParam.Add("group_id", listHostsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHostsResponse>(response);
        }

        public SyncInvoker<ListHostsResponse> ListHostsInvoker(ListHostsRequest listHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listHostsRequest.GroupId.ToString());
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
            urlParam.Add("group_id", listNewHostsRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNewHostsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNewHostsResponse>(response);
        }

        public SyncInvoker<ListNewHostsResponse> ListNewHostsInvoker(ListNewHostsRequest listNewHostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listNewHostsRequest.GroupId.ToString());
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
            urlParam.Add("group_id", showDeploymentHostDetailRequest.GroupId.ToString());
            urlParam.Add("host_id", showDeploymentHostDetailRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeploymentHostDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDeploymentHostDetailResponse>(response);
        }

        public SyncInvoker<ShowDeploymentHostDetailResponse> ShowDeploymentHostDetailInvoker(ShowDeploymentHostDetailRequest showDeploymentHostDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", showDeploymentHostDetailRequest.GroupId.ToString());
            urlParam.Add("host_id", showDeploymentHostDetailRequest.HostId.ToString());
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
            urlParam.Add("group_id", showHostDetailRequest.GroupId.ToString());
            urlParam.Add("host_id", showHostDetailRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHostDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHostDetailResponse>(response);
        }

        public SyncInvoker<ShowHostDetailResponse> ShowHostDetailInvoker(ShowHostDetailRequest showHostDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", showHostDetailRequest.GroupId.ToString());
            urlParam.Add("host_id", showHostDetailRequest.HostId.ToString());
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
            urlParam.Add("group_id", updateDeploymentHostRequest.GroupId.ToString());
            urlParam.Add("host_id", updateDeploymentHostRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeploymentHostRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDeploymentHostResponse>(response);
        }

        public SyncInvoker<UpdateDeploymentHostResponse> UpdateDeploymentHostInvoker(UpdateDeploymentHostRequest updateDeploymentHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateDeploymentHostRequest.GroupId.ToString());
            urlParam.Add("host_id", updateDeploymentHostRequest.HostId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeploymentHostRequest);
            return new SyncInvoker<UpdateDeploymentHostResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDeploymentHostResponse>);
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
            urlParam.Add("group_id", deleteDeploymentGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeploymentGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDeploymentGroupResponse>(response);
        }

        public SyncInvoker<DeleteDeploymentGroupResponse> DeleteDeploymentGroupInvoker(DeleteDeploymentGroupRequest deleteDeploymentGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteDeploymentGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeploymentGroupRequest);
            return new SyncInvoker<DeleteDeploymentGroupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDeploymentGroupResponse>);
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
            urlParam.Add("group_id", showDeploymentGroupDetailRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeploymentGroupDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDeploymentGroupDetailResponse>(response);
        }

        public SyncInvoker<ShowDeploymentGroupDetailResponse> ShowDeploymentGroupDetailInvoker(ShowDeploymentGroupDetailRequest showDeploymentGroupDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", showDeploymentGroupDetailRequest.GroupId.ToString());
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
            urlParam.Add("group_id", showHostClusterDetailRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHostClusterDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHostClusterDetailResponse>(response);
        }

        public SyncInvoker<ShowHostClusterDetailResponse> ShowHostClusterDetailInvoker(ShowHostClusterDetailRequest showHostClusterDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", showHostClusterDetailRequest.GroupId.ToString());
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
            urlParam.Add("group_id", updateDeploymentGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeploymentGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDeploymentGroupResponse>(response);
        }

        public SyncInvoker<UpdateDeploymentGroupResponse> UpdateDeploymentGroupInvoker(UpdateDeploymentGroupRequest updateDeploymentGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateDeploymentGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeploymentGroupRequest);
            return new SyncInvoker<UpdateDeploymentGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDeploymentGroupResponse>);
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
            urlParam.Add("project_id", listTaskSuccessRateRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/metrics/success-rate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskSuccessRateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListTaskSuccessRateResponse>(response);
        }

        public SyncInvoker<ListTaskSuccessRateResponse> ListTaskSuccessRateInvoker(ListTaskSuccessRateRequest listTaskSuccessRateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listTaskSuccessRateRequest.ProjectId.ToString());
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
            urlParam.Add("project_id", showProjectSuccessRateRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/metrics/success-rate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectSuccessRateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectSuccessRateResponse>(response);
        }

        public SyncInvoker<ShowProjectSuccessRateResponse> ShowProjectSuccessRateInvoker(ShowProjectSuccessRateRequest showProjectSuccessRateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showProjectSuccessRateRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/metrics/success-rate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectSuccessRateRequest);
            return new SyncInvoker<ShowProjectSuccessRateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectSuccessRateResponse>);
        }
        
    }
}