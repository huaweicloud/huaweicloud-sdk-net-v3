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
        /// 通过模板新建应用
        ///
        /// 通过模板新建应用。
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
        /// 根据部署任务id删除应用。
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
        /// 根据开始时间和结束时间查询项目下指定应用的历史部署记录列表
        ///
        /// 根据开始时间和结束时间查询项目下指定应用的历史部署记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDeployTaskHistoryByDateResponse ListDeployTaskHistoryByDate(ListDeployTaskHistoryByDateRequest listDeployTaskHistoryByDateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , listDeployTaskHistoryByDateRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/task/{id}/history",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeployTaskHistoryByDateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDeployTaskHistoryByDateResponse>(response);
        }
        
        /// <summary>
        /// 获取应用列表
        ///
        /// 查询项目下应用列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDeployTasksResponse ListDeployTasks(ListDeployTasksRequest listDeployTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeployTasksRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDeployTasksResponse>(response);
        }
        
        /// <summary>
        /// 获取应用详情
        ///
        /// 根据部署任务id获取应用详情。
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
        /// 新建主机
        ///
        /// 在指定主机集群下新建主机。
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
        /// 删除主机
        ///
        /// 根据主机id删除主机。
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
        /// 根据主机集群id查询指定主机集群下的主机列表。
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
        /// 查询主机详情
        ///
        /// 根据主机id查询主机详情。
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
        /// 修改主机
        ///
        /// 根据主机id修改主机信息。
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
        /// 在项目下新建主机集群。
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
        /// 删除主机集群
        ///
        /// 根据主机集群id删除主机集群。
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
        /// 根据主机集群id查询主机集群详情。
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
        /// 修改主机集群
        ///
        /// 根据主机集群id修改主机集群信息。
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
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/metrics/success-rate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectSuccessRateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowProjectSuccessRateResponse>(response);
        }
        
    }
}