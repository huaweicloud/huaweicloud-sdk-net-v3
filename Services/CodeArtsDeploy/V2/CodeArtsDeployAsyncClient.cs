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
        /// 新建应用
        ///
        /// 新建应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAppResponse> CreateAppAsync(CreateAppRequest createAppRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/applications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAppResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/tasks/template-task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeployTaskByTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDeployTaskByTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , deleteApplicationRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteApplicationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , deleteDeployTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeployTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteDeployTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllAppRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListAllAppResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listDeployTaskHistoryByDateRequest.ProjectId.ToString());
            urlParam.Add("id" , listDeployTaskHistoryByDateRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/task/{id}/history",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeployTaskHistoryByDateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDeployTaskHistoryByDateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listDeployTasksRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeployTasksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDeployTasksResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , showAppDetailByIdRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}/info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppDetailByIdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAppDetailByIdResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showDeployTaskDetailRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeployTaskDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDeployTaskDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询部署记录的执行参数
        ///
        /// 查询部署记录的执行参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowExecutionParamsResponse> ShowExecutionParamsAsync(ShowExecutionParamsRequest showExecutionParamsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showExecutionParamsRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/history/tasks/{task_id}/params",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExecutionParamsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            ShowExecutionParamsResponse showExecutionParamsResponse = JsonUtils.DeSerializeNull<ShowExecutionParamsResponse>(response);
            showExecutionParamsResponse.Body = JsonUtils.DeSerializeList<ConfigInfo>(response);
            return showExecutionParamsResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , startDeployTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/start",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDeployTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<StartDeployTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id" , createEnvironmentRequest.ApplicationId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEnvironmentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateEnvironmentResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id" , deleteEnvironmentRequest.ApplicationId.ToString());
            urlParam.Add("environment_id" , deleteEnvironmentRequest.EnvironmentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnvironmentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteEnvironmentResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id" , deleteHostFromEnvironmentRequest.ApplicationId.ToString());
            urlParam.Add("environment_id" , deleteHostFromEnvironmentRequest.EnvironmentId.ToString());
            urlParam.Add("host_id" , deleteHostFromEnvironmentRequest.HostId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}/{host_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHostFromEnvironmentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteHostFromEnvironmentResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id" , importHostToEnvironmentRequest.ApplicationId.ToString());
            urlParam.Add("environment_id" , importHostToEnvironmentRequest.EnvironmentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}/hosts/import",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", importHostToEnvironmentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ImportHostToEnvironmentResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id" , listEnvironmentsRequest.ApplicationId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvironmentsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEnvironmentsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id" , showEnvironmentDetailRequest.ApplicationId.ToString());
            urlParam.Add("environment_id" , showEnvironmentDetailRequest.EnvironmentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvironmentDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowEnvironmentDetailResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , createDeploymentHostRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeploymentHostRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDeploymentHostResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , createHostRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHostRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateHostResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , deleteDeploymentHostRequest.GroupId.ToString());
            urlParam.Add("host_id" , deleteDeploymentHostRequest.HostId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeploymentHostRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteDeploymentHostResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , listHostsRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListHostsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , listNewHostsRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNewHostsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListNewHostsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , showDeploymentHostDetailRequest.GroupId.ToString());
            urlParam.Add("host_id" , showDeploymentHostDetailRequest.HostId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeploymentHostDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDeploymentHostDetailResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , showHostDetailRequest.GroupId.ToString());
            urlParam.Add("host_id" , showHostDetailRequest.HostId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/{host_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHostDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowHostDetailResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , updateDeploymentHostRequest.GroupId.ToString());
            urlParam.Add("host_id" , updateDeploymentHostRequest.HostId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeploymentHostRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDeploymentHostResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/host-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeploymentGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDeploymentGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHostClusterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateHostClusterResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , deleteDeploymentGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeploymentGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteDeploymentGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostClustersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListHostClustersResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/host-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListHostGroupsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , showDeploymentGroupDetailRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeploymentGroupDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDeploymentGroupDetailResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , showHostClusterDetailRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHostClusterDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowHostClusterDetailResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , updateDeploymentGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeploymentGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDeploymentGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listTaskSuccessRateRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/metrics/success-rate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskSuccessRateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListTaskSuccessRateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showProjectSuccessRateRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/metrics/success-rate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectSuccessRateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowProjectSuccessRateResponse>(response);
        }
        
    }
}