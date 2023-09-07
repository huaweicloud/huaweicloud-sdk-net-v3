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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/applications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateAppResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/tasks/template-task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeployTaskByTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateDeployTaskByTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , deleteApplicationRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteApplicationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , deleteDeployTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeployTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteDeployTaskResponse>(response);
        }
        
        /// <summary>
        /// 获取应用列表
        ///
        /// 查询项目下应用列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllAppResponse ListAllApp(ListAllAppRequest listAllAppRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllAppRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListAllAppResponse>(response);
        }
        
        /// <summary>
        /// 根据开始时间和结束时间查询项目下指定应用的历史部署记录列表
        ///
        /// 根据开始时间和结束时间查询项目下指定应用的历史部署记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDeployTaskHistoryByDateResponse ListDeployTaskHistoryByDate(ListDeployTaskHistoryByDateRequest listDeployTaskHistoryByDateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listDeployTaskHistoryByDateRequest.ProjectId.ToString());
            urlParam.Add("id" , listDeployTaskHistoryByDateRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/task/{id}/history",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeployTaskHistoryByDateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDeployTaskHistoryByDateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listDeployTasksRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeployTasksRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDeployTasksResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , showAppDetailByIdRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/{app_id}/info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppDetailByIdRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAppDetailByIdResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , showDeployTaskDetailRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeployTaskDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDeployTaskDetailResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , startDeployTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/start",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", startDeployTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<StartDeployTaskResponse>(response);
        }
        
        /// <summary>
        /// 应用下创建环境
        ///
        /// 应用下创建环境
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest createEnvironmentRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id" , createEnvironmentRequest.ApplicationId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEnvironmentRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateEnvironmentResponse>(response);
        }
        
        /// <summary>
        /// 删除应用下的环境
        ///
        /// 删除应用下的环境
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest deleteEnvironmentRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id" , deleteEnvironmentRequest.ApplicationId.ToString());
            urlParam.Add("environment_id" , deleteEnvironmentRequest.EnvironmentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnvironmentRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteEnvironmentResponse>(response);
        }
        
        /// <summary>
        /// 环境下删除主机
        ///
        /// 环境下删除主机
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteHostFromEnvironmentResponse DeleteHostFromEnvironment(DeleteHostFromEnvironmentRequest deleteHostFromEnvironmentRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id" , deleteHostFromEnvironmentRequest.ApplicationId.ToString());
            urlParam.Add("environment_id" , deleteHostFromEnvironmentRequest.EnvironmentId.ToString());
            urlParam.Add("host_id" , deleteHostFromEnvironmentRequest.HostId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}/{host_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHostFromEnvironmentRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteHostFromEnvironmentResponse>(response);
        }
        
        /// <summary>
        /// 环境下导入主机
        ///
        /// 环境下导入主机
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ImportHostToEnvironmentResponse ImportHostToEnvironment(ImportHostToEnvironmentRequest importHostToEnvironmentRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id" , importHostToEnvironmentRequest.ApplicationId.ToString());
            urlParam.Add("environment_id" , importHostToEnvironmentRequest.EnvironmentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}/hosts/import",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", importHostToEnvironmentRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ImportHostToEnvironmentResponse>(response);
        }
        
        /// <summary>
        /// 查询应用下环境列表
        ///
        /// 查询应用下环境列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest listEnvironmentsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id" , listEnvironmentsRequest.ApplicationId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvironmentsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListEnvironmentsResponse>(response);
        }
        
        /// <summary>
        /// 查询环境详情
        ///
        /// 查询环境详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEnvironmentDetailResponse ShowEnvironmentDetail(ShowEnvironmentDetailRequest showEnvironmentDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id" , showEnvironmentDetailRequest.ApplicationId.ToString());
            urlParam.Add("environment_id" , showEnvironmentDetailRequest.EnvironmentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}/environments/{environment_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvironmentDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowEnvironmentDetailResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , createDeploymentHostRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeploymentHostRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateDeploymentHostResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , createHostRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHostRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateHostResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , deleteDeploymentHostRequest.GroupId.ToString());
            urlParam.Add("host_id" , deleteDeploymentHostRequest.HostId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeploymentHostRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteDeploymentHostResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , listHostsRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListHostsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , listNewHostsRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNewHostsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListNewHostsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , showDeploymentHostDetailRequest.GroupId.ToString());
            urlParam.Add("host_id" , showDeploymentHostDetailRequest.HostId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeploymentHostDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDeploymentHostDetailResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , showHostDetailRequest.GroupId.ToString());
            urlParam.Add("host_id" , showHostDetailRequest.HostId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}/hosts/{host_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHostDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowHostDetailResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , updateDeploymentHostRequest.GroupId.ToString());
            urlParam.Add("host_id" , updateDeploymentHostRequest.HostId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}/hosts/{host_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeploymentHostRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDeploymentHostResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/host-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeploymentGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateDeploymentGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHostClusterRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateHostClusterResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , deleteDeploymentGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeploymentGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteDeploymentGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostClustersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListHostClustersResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/host-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHostGroupsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListHostGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查询主机集群
        ///
        /// 根据主机集群id查询主机集群详情。该接口于2024年09月30日后不再维护，推荐使用新版ShowHostClusterDetail接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDeploymentGroupDetailResponse ShowDeploymentGroupDetail(ShowDeploymentGroupDetailRequest showDeploymentGroupDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , showDeploymentGroupDetailRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeploymentGroupDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDeploymentGroupDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询主机集群
        ///
        /// 根据主机集群id查询主机集群详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHostClusterDetailResponse ShowHostClusterDetail(ShowHostClusterDetailRequest showHostClusterDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , showHostClusterDetailRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/resources/host-groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHostClusterDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowHostClusterDetailResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , updateDeploymentGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/host-groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeploymentGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDeploymentGroupResponse>(response);
        }
        
        /// <summary>
        /// 获取指定应用的应用部署成功率
        ///
        /// 获取指定应用的应用部署成功率
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTaskSuccessRateResponse ListTaskSuccessRate(ListTaskSuccessRateRequest listTaskSuccessRateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listTaskSuccessRateRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/metrics/success-rate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskSuccessRateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListTaskSuccessRateResponse>(response);
        }
        
        /// <summary>
        /// 获取指定项目的应用部署成功率
        ///
        /// 获取指定项目的应用部署成功率
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectSuccessRateResponse ShowProjectSuccessRate(ShowProjectSuccessRateRequest showProjectSuccessRateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showProjectSuccessRateRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/metrics/success-rate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectSuccessRateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowProjectSuccessRateResponse>(response);
        }
        
    }
}