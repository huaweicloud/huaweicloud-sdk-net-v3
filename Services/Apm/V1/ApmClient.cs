using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Apm.V1.Model;

namespace HuaweiCloud.SDK.Apm.V1
{
    public partial class ApmClient : Client
    {
        public static ClientBuilder<ApmClient> NewBuilder()
        {
            return new ClientBuilder<ApmClient>();
        }

        
        /// <summary>
        /// 创建aksk
        ///
        /// 创建aksk。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAkSkResponse CreateAkSk(CreateAkSkRequest createAkSkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAkSkRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAkSkResponse>(response);
        }

        public SyncInvoker<CreateAkSkResponse> CreateAkSkInvoker(CreateAkSkRequest createAkSkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAkSkRequest);
            return new SyncInvoker<CreateAkSkResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAkSkResponse>);
        }
        
        /// <summary>
        /// 删除aksk
        ///
        /// 删除aksk。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAkSkResponse DeleteAkSk(DeleteAkSkRequest deleteAkSkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ak", deleteAkSkRequest.Ak.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/access-keys/{ak}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAkSkRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAkSkResponse>(response);
        }

        public SyncInvoker<DeleteAkSkResponse> DeleteAkSkInvoker(DeleteAkSkRequest deleteAkSkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ak", deleteAkSkRequest.Ak.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/access-keys/{ak}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAkSkRequest);
            return new SyncInvoker<DeleteAkSkResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAkSkResponse>);
        }
        
        /// <summary>
        /// 查询租户的aksk
        ///
        /// 查询租户的aksk。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAkSksResponse ShowAkSks(ShowAkSksRequest showAkSksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAkSksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAkSksResponse>(response);
        }

        public SyncInvoker<ShowAkSksResponse> ShowAkSksInvoker(ShowAkSksRequest showAkSksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAkSksRequest);
            return new SyncInvoker<ShowAkSksResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAkSksResponse>);
        }
        
        /// <summary>
        /// 查询告警列表
        ///
        /// 查询系统中存在的告警。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAlarmDataResponse ListAlarmData(ListAlarmDataRequest listAlarmDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/alarm/data/get-alarm-data-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmDataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAlarmDataResponse>(response);
        }

        public SyncInvoker<ListAlarmDataResponse> ListAlarmDataInvoker(ListAlarmDataRequest listAlarmDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/alarm/data/get-alarm-data-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmDataRequest);
            return new SyncInvoker<ListAlarmDataResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAlarmDataResponse>);
        }
        
        /// <summary>
        /// 查询告警消息列表
        ///
        /// 查询单个告警的触发详情与历史。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAlarmNotifyResponse ListAlarmNotify(ListAlarmNotifyRequest listAlarmNotifyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/alarm/data/get-alarm-notify-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmNotifyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAlarmNotifyResponse>(response);
        }

        public SyncInvoker<ListAlarmNotifyResponse> ListAlarmNotifyInvoker(ListAlarmNotifyRequest listAlarmNotifyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/alarm/data/get-alarm-notify-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmNotifyRequest);
            return new SyncInvoker<ListAlarmNotifyResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAlarmNotifyResponse>);
        }
        
        /// <summary>
        /// 更改实例的采集状态
        ///
        /// 改变指定实例的采集状态：开启和关闭。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeAgentStatusResponse ChangeAgentStatus(ChangeAgentStatusRequest changeAgentStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/agent-mgr/change-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeAgentStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeAgentStatusResponse>(response);
        }

        public SyncInvoker<ChangeAgentStatusResponse> ChangeAgentStatusInvoker(ChangeAgentStatusRequest changeAgentStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/agent-mgr/change-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeAgentStatusRequest);
            return new SyncInvoker<ChangeAgentStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeAgentStatusResponse>);
        }
        
        /// <summary>
        /// 删除agent
        ///
        /// 删除agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAgentResponse DeleteAgent(DeleteAgentRequest deleteAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/agent-mgr/delete-agent", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAgentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteAgentResponse>(response);
        }

        public SyncInvoker<DeleteAgentResponse> DeleteAgentInvoker(DeleteAgentRequest deleteAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/agent-mgr/delete-agent", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAgentRequest);
            return new SyncInvoker<DeleteAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteAgentResponse>);
        }
        
        /// <summary>
        /// 获取ak/sk
        ///
        /// 获取该用户创建的ak/sk列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAkSkResponse ListAkSk(ListAkSkRequest listAkSkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/systemmng/get-ak-sk-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAkSkRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAkSkResponse>(response);
        }

        public SyncInvoker<ListAkSkResponse> ListAkSkInvoker(ListAkSkRequest listAkSkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/systemmng/get-ak-sk-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAkSkRequest);
            return new SyncInvoker<ListAkSkResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAkSkResponse>);
        }
        
        /// <summary>
        /// 查询应用列表
        ///
        /// 该接口用于查询对应用户下的应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBusinessResponse ListBusiness(ListBusinessRequest listBusinessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/business/get-business-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBusinessRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBusinessResponse>(response);
        }

        public SyncInvoker<ListBusinessResponse> ListBusinessInvoker(ListBusinessRequest listBusinessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/business/get-business-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBusinessRequest);
            return new SyncInvoker<ListBusinessResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBusinessResponse>);
        }
        
        /// <summary>
        /// 查询监控项列表
        ///
        /// 查询监控项列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEnvMonitorItemResponse ListEnvMonitorItem(ListEnvMonitorItemRequest listEnvMonitorItemRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/monitor-item-mgr/get-env-monitor-item-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvMonitorItemRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListEnvMonitorItemResponse>(response);
        }

        public SyncInvoker<ListEnvMonitorItemResponse> ListEnvMonitorItemInvoker(ListEnvMonitorItemRequest listEnvMonitorItemRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/monitor-item-mgr/get-env-monitor-item-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvMonitorItemRequest);
            return new SyncInvoker<ListEnvMonitorItemResponse>(this, "POST", request, JsonUtils.DeSerialize<ListEnvMonitorItemResponse>);
        }
        
        /// <summary>
        /// 保存监控项
        ///
        /// 保存监控项。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SaveMonitorItemConfigResponse SaveMonitorItemConfig(SaveMonitorItemConfigRequest saveMonitorItemConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/monitor-item-mgr/save-monitor-item-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveMonitorItemConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SaveMonitorItemConfigResponse>(response);
        }

        public SyncInvoker<SaveMonitorItemConfigResponse> SaveMonitorItemConfigInvoker(SaveMonitorItemConfigRequest saveMonitorItemConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/monitor-item-mgr/save-monitor-item-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveMonitorItemConfigRequest);
            return new SyncInvoker<SaveMonitorItemConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<SaveMonitorItemConfigResponse>);
        }
        
        /// <summary>
        /// 查询应用下所有探针
        ///
        /// 该接口用于搜索应用下所有探针情况。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchAgentResponse SearchAgent(SearchAgentRequest searchAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/agent-mgr/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchAgentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchAgentResponse>(response);
        }

        public SyncInvoker<SearchAgentResponse> SearchAgentInvoker(SearchAgentRequest searchAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/agent-mgr/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchAgentRequest);
            return new SyncInvoker<SearchAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchAgentResponse>);
        }
        
        /// <summary>
        /// 对指定区域下的组件和环境及其探针情况进行搜索
        ///
        /// 对指定区域下的组件和环境及其探针情况进行搜索。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchApplicationResponse SearchApplication(SearchApplicationRequest searchApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/app-mgr/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchApplicationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchApplicationResponse>(response);
        }

        public SyncInvoker<SearchApplicationResponse> SearchApplicationInvoker(SearchApplicationRequest searchApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/app-mgr/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchApplicationRequest);
            return new SyncInvoker<SearchApplicationResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchApplicationResponse>);
        }
        
        /// <summary>
        /// 查询master地址
        ///
        /// 根据region名称获取该region下的master服务podlb地址信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMasterAddressResponse ShowMasterAddress(ShowMasterAddressRequest showMasterAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/systemmng/get-master-address", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMasterAddressRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMasterAddressResponse>(response);
        }

        public SyncInvoker<ShowMasterAddressResponse> ShowMasterAddressInvoker(ShowMasterAddressRequest showMasterAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/systemmng/get-master-address", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMasterAddressRequest);
            return new SyncInvoker<ShowMasterAddressResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMasterAddressResponse>);
        }
        
        /// <summary>
        /// 根据组件id删除指定的组件
        ///
        /// 该接口用于删除指定的组件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAppResponse DeleteApp(DeleteAppRequest deleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", deleteAppRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/apps/delete-app/{application_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAppResponse>(response);
        }

        public SyncInvoker<DeleteAppResponse> DeleteAppInvoker(DeleteAppRequest deleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", deleteAppRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/apps/delete-app/{application_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            return new SyncInvoker<DeleteAppResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAppResponse>);
        }
        
        /// <summary>
        /// 获取组件下的环境列表
        ///
        /// 获取组件下的环境列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAppEnvsResponse ListAppEnvs(ListAppEnvsRequest listAppEnvsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/envs/get-app-envs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppEnvsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAppEnvsResponse>(response);
        }

        public SyncInvoker<ListAppEnvsResponse> ListAppEnvsInvoker(ListAppEnvsRequest listAppEnvsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/envs/get-app-envs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppEnvsRequest);
            return new SyncInvoker<ListAppEnvsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppEnvsResponse>);
        }
        
        /// <summary>
        /// 获取组件列表
        ///
        /// 获取组件列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAppsResponse ListApps(ListAppsRequest listAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/apps/get-apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAppsResponse>(response);
        }

        public SyncInvoker<ListAppsResponse> ListAppsInvoker(ListAppsRequest listAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/apps/get-apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppsRequest);
            return new SyncInvoker<ListAppsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppsResponse>);
        }
        
        /// <summary>
        /// 查询环境标签
        ///
        /// 查询环境标签接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEnvTagsResponse ListEnvTags(ListEnvTagsRequest listEnvTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/tag/get-env-tag-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListEnvTagsResponse>(response);
        }

        public SyncInvoker<ListEnvTagsResponse> ListEnvTagsInvoker(ListEnvTagsRequest listEnvTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/tag/get-env-tag-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvTagsRequest);
            return new SyncInvoker<ListEnvTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListEnvTagsResponse>);
        }
        
        /// <summary>
        /// 查询单个应用的详情
        ///
        /// 查询单个应用的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBusinessDetailResponse ShowBusinessDetail(ShowBusinessDetailRequest showBusinessDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("business_id", showBusinessDetailRequest.BusinessId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/business/get-business-detail/{business_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBusinessDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBusinessDetailResponse>(response);
        }

        public SyncInvoker<ShowBusinessDetailResponse> ShowBusinessDetailInvoker(ShowBusinessDetailRequest showBusinessDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("business_id", showBusinessDetailRequest.BusinessId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/business/get-business-detail/{business_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBusinessDetailRequest);
            return new SyncInvoker<ShowBusinessDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBusinessDetailResponse>);
        }
        
        /// <summary>
        /// 查询子应用详情
        ///
        /// 查询单个子应用详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSubBusinessDetailResponse ShowSubBusinessDetail(ShowSubBusinessDetailRequest showSubBusinessDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_business_id", showSubBusinessDetailRequest.SubBusinessId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/sub-business/get-sub-business-detail/{sub_business_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubBusinessDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSubBusinessDetailResponse>(response);
        }

        public SyncInvoker<ShowSubBusinessDetailResponse> ShowSubBusinessDetailInvoker(ShowSubBusinessDetailRequest showSubBusinessDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_business_id", showSubBusinessDetailRequest.SubBusinessId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/sub-business/get-sub-business-detail/{sub_business_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubBusinessDetailRequest);
            return new SyncInvoker<ShowSubBusinessDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSubBusinessDetailResponse>);
        }
        
        /// <summary>
        /// 获取应用树
        ///
        /// 获取应用树。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTopologyTreeResponse ShowTopologyTree(ShowTopologyTreeRequest showTopologyTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/topology-trees/get-topology-trees", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopologyTreeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTopologyTreeResponse>(response);
        }

        public SyncInvoker<ShowTopologyTreeResponse> ShowTopologyTreeInvoker(ShowTopologyTreeRequest showTopologyTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/topology-trees/get-topology-trees", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopologyTreeRequest);
            return new SyncInvoker<ShowTopologyTreeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTopologyTreeResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFlameLineTreeResponse ShowFlameLineTree(ShowFlameLineTreeRequest showFlameLineTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/profiling/flame-line-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlameLineTreeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowFlameLineTreeResponse>(response);
        }

        public SyncInvoker<ShowFlameLineTreeResponse> ShowFlameLineTreeInvoker(ShowFlameLineTreeRequest showFlameLineTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/profiling/flame-line-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlameLineTreeRequest);
            return new SyncInvoker<ShowFlameLineTreeResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowFlameLineTreeResponse>);
        }
        
        /// <summary>
        /// 查询开通的region
        ///
        /// 该接口用于查询用户开通的region信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOpenRegionResponse ListOpenRegion(ListOpenRegionRequest listOpenRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/region/get-opened-region", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOpenRegionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOpenRegionResponse>(response);
        }

        public SyncInvoker<ListOpenRegionResponse> ListOpenRegionInvoker(ListOpenRegionRequest listOpenRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/region/get-opened-region", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOpenRegionRequest);
            return new SyncInvoker<ListOpenRegionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOpenRegionResponse>);
        }
        
        /// <summary>
        /// 查询所有的支持的region
        ///
        /// 查询所有的支持的region信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSupportedRegionResponse ListSupportedRegion(ListSupportedRegionRequest listSupportedRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/region/get-all-supported-region", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportedRegionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSupportedRegionResponse>(response);
        }

        public SyncInvoker<ListSupportedRegionResponse> ListSupportedRegionInvoker(ListSupportedRegionRequest listSupportedRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/region/get-all-supported-region", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportedRegionRequest);
            return new SyncInvoker<ListSupportedRegionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSupportedRegionResponse>);
        }
        
        /// <summary>
        /// 查询应用全局拓扑图
        ///
        /// 查询应用级别全局拓扑图信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchBusinessTopologyResponse SearchBusinessTopology(SearchBusinessTopologyRequest searchBusinessTopologyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/topology/business-search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchBusinessTopologyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchBusinessTopologyResponse>(response);
        }

        public SyncInvoker<SearchBusinessTopologyResponse> SearchBusinessTopologyInvoker(SearchBusinessTopologyRequest searchBusinessTopologyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/topology/business-search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchBusinessTopologyRequest);
            return new SyncInvoker<SearchBusinessTopologyResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchBusinessTopologyResponse>);
        }
        
        /// <summary>
        /// 查询组件环境拓扑图
        ///
        /// 查询组件环境级别全局拓扑图信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchEnvTopologyResponse SearchEnvTopology(SearchEnvTopologyRequest searchEnvTopologyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/topology/env-search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchEnvTopologyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchEnvTopologyResponse>(response);
        }

        public SyncInvoker<SearchEnvTopologyResponse> SearchEnvTopologyInvoker(SearchEnvTopologyRequest searchEnvTopologyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/topology/env-search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchEnvTopologyRequest);
            return new SyncInvoker<SearchEnvTopologyResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchEnvTopologyResponse>);
        }
        
        /// <summary>
        /// 创建链路追踪应用
        ///
        /// 创建链路追踪应用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateBusinessResponse CreateBusiness(CreateBusinessRequest createBusinessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/tracing/business/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBusinessRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateBusinessResponse>(response);
        }

        public SyncInvoker<CreateBusinessResponse> CreateBusinessInvoker(CreateBusinessRequest createBusinessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/tracing/business/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBusinessRequest);
            return new SyncInvoker<CreateBusinessResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBusinessResponse>);
        }
        
        /// <summary>
        /// 获取链路追踪应用接入地址
        ///
        /// 获取链路追踪应用接入地址
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAccessPointResponse ShowAccessPoint(ShowAccessPointRequest showAccessPointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("business_id", showAccessPointRequest.BusinessId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/tracing/access/get-access-point/{business_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessPointRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowAccessPointResponse>(response);
        }

        public SyncInvoker<ShowAccessPointResponse> ShowAccessPointInvoker(ShowAccessPointRequest showAccessPointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("business_id", showAccessPointRequest.BusinessId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/tracing/access/get-access-point/{business_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessPointRequest);
            return new SyncInvoker<ShowAccessPointResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowAccessPointResponse>);
        }
        
        /// <summary>
        /// 获取链路追踪应用的token
        ///
        /// 获取链路追踪应用的token
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTokenResponse ShowToken(ShowTokenRequest showTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("business_id", showTokenRequest.BusinessId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/tracing/business/token/{business_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTokenRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTokenResponse>(response);
        }

        public SyncInvoker<ShowTokenResponse> ShowTokenInvoker(ShowTokenRequest showTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("business_id", showTokenRequest.BusinessId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/tracing/business/token/{business_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTokenRequest);
            return new SyncInvoker<ShowTokenResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTokenResponse>);
        }
        
        /// <summary>
        /// 查询URL跟踪Region环境列表
        ///
        /// 查询所选Region下设置了URL跟踪的环境列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBusinessEnvResponse ListBusinessEnv(ListBusinessEnvRequest listBusinessEnvRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/transaction/business-env", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBusinessEnvRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListBusinessEnvResponse>(response);
        }

        public SyncInvoker<ListBusinessEnvResponse> ListBusinessEnvInvoker(ListBusinessEnvRequest listBusinessEnvRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/transaction/business-env", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBusinessEnvRequest);
            return new SyncInvoker<ListBusinessEnvResponse>(this, "POST", request, JsonUtils.DeSerialize<ListBusinessEnvResponse>);
        }
        
        /// <summary>
        /// 查询URL跟踪视图列表
        ///
        /// 查询当前被调用的URL跟踪视图列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchTransactionResponse SearchTransaction(SearchTransactionRequest searchTransactionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/transaction/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchTransactionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchTransactionResponse>(response);
        }

        public SyncInvoker<SearchTransactionResponse> SearchTransactionInvoker(SearchTransactionRequest searchTransactionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/transaction/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchTransactionRequest);
            return new SyncInvoker<SearchTransactionResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchTransactionResponse>);
        }
        
        /// <summary>
        /// 查询URL跟踪配置列表
        ///
        /// 查询已配置好的URL跟踪配置列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchTransactionConfigResponse SearchTransactionConfig(SearchTransactionConfigRequest searchTransactionConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/transaction/transaction-config-search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchTransactionConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchTransactionConfigResponse>(response);
        }

        public SyncInvoker<SearchTransactionConfigResponse> SearchTransactionConfigInvoker(SearchTransactionConfigRequest searchTransactionConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/transaction/transaction-config-search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchTransactionConfigRequest);
            return new SyncInvoker<SearchTransactionConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchTransactionConfigResponse>);
        }
        
        /// <summary>
        /// 查询URL跟踪视图详情
        ///
        /// 查询某条URL跟踪视图详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTransactionDetailResponse ShowTransactionDetail(ShowTransactionDetailRequest showTransactionDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/transaction/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransactionDetailRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowTransactionDetailResponse>(response);
        }

        public SyncInvoker<ShowTransactionDetailResponse> ShowTransactionDetailInvoker(ShowTransactionDetailRequest showTransactionDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/transaction/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransactionDetailRequest);
            return new SyncInvoker<ShowTransactionDetailResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowTransactionDetailResponse>);
        }
        
        /// <summary>
        /// 获取实例信息列表
        ///
        /// 获取实例信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEnvInstancesResponse ListEnvInstances(ListEnvInstancesRequest listEnvInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/mainview/get-env-instance-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListEnvInstancesResponse>(response);
        }

        public SyncInvoker<ListEnvInstancesResponse> ListEnvInstancesInvoker(ListEnvInstancesRequest listEnvInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/mainview/get-env-instance-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvInstancesRequest);
            return new SyncInvoker<ListEnvInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListEnvInstancesResponse>);
        }
        
        /// <summary>
        /// 获取原始数据详情
        ///
        /// 获取原始数据详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowClobDetailResponse ShowClobDetail(ShowClobDetailRequest showClobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/metric/get-clob-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClobDetailRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowClobDetailResponse>(response);
        }

        public SyncInvoker<ShowClobDetailResponse> ShowClobDetailInvoker(ShowClobDetailRequest showClobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/metric/get-clob-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClobDetailRequest);
            return new SyncInvoker<ShowClobDetailResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowClobDetailResponse>);
        }
        
        /// <summary>
        /// 获取监控项信息
        ///
        /// 获取监控项信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEnvMonitorItemsResponse ShowEnvMonitorItems(ShowEnvMonitorItemsRequest showEnvMonitorItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/mainview/get-env-monitor-item-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvMonitorItemsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEnvMonitorItemsResponse>(response);
        }

        public SyncInvoker<ShowEnvMonitorItemsResponse> ShowEnvMonitorItemsInvoker(ShowEnvMonitorItemsRequest showEnvMonitorItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/mainview/get-env-monitor-item-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvMonitorItemsRequest);
            return new SyncInvoker<ShowEnvMonitorItemsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEnvMonitorItemsResponse>);
        }
        
        /// <summary>
        /// 获取event的详情
        ///
        /// 获取event的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEventDetailResponse ShowEventDetail(ShowEventDetailRequest showEventDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/trace/get-event-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEventDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEventDetailResponse>(response);
        }

        public SyncInvoker<ShowEventDetailResponse> ShowEventDetailInvoker(ShowEventDetailRequest showEventDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/trace/get-event-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEventDetailRequest);
            return new SyncInvoker<ShowEventDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEventDetailResponse>);
        }
        
        /// <summary>
        /// 获取一个监控项的详情
        ///
        /// 获取一个监控项的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMonitorItemDetailResponse ShowMonitorItemDetail(ShowMonitorItemDetailRequest showMonitorItemDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/monitor-item-mgr/get-monitor-item-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMonitorItemDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMonitorItemDetailResponse>(response);
        }

        public SyncInvoker<ShowMonitorItemDetailResponse> ShowMonitorItemDetailInvoker(ShowMonitorItemDetailRequest showMonitorItemDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/monitor-item-mgr/get-monitor-item-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMonitorItemDetailRequest);
            return new SyncInvoker<ShowMonitorItemDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMonitorItemDetailResponse>);
        }
        
        /// <summary>
        /// 查询监控项配置信息
        ///
        /// 查询监控项配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMonitorItemViewConfigResponse ShowMonitorItemViewConfig(ShowMonitorItemViewConfigRequest showMonitorItemViewConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/config/get-monitor-item-view-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMonitorItemViewConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMonitorItemViewConfigResponse>(response);
        }

        public SyncInvoker<ShowMonitorItemViewConfigResponse> ShowMonitorItemViewConfigInvoker(ShowMonitorItemViewConfigRequest showMonitorItemViewConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/config/get-monitor-item-view-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMonitorItemViewConfigRequest);
            return new SyncInvoker<ShowMonitorItemViewConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMonitorItemViewConfigResponse>);
        }
        
        /// <summary>
        /// 获取原始数据表格
        ///
        /// 获取原始数据表格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRawTableResponse ShowRawTable(ShowRawTableRequest showRawTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/metric/raw-table", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRawTableRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowRawTableResponse>(response);
        }

        public SyncInvoker<ShowRawTableResponse> ShowRawTableInvoker(ShowRawTableRequest showRawTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/metric/raw-table", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRawTableRequest);
            return new SyncInvoker<ShowRawTableResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowRawTableResponse>);
        }
        
        /// <summary>
        /// 查询span数据
        ///
        /// span数据查询接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSpanSearchResponse ShowSpanSearch(ShowSpanSearchRequest showSpanSearchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/trace/span-search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSpanSearchRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowSpanSearchResponse>(response);
        }

        public SyncInvoker<ShowSpanSearchResponse> ShowSpanSearchInvoker(ShowSpanSearchRequest showSpanSearchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/trace/span-search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSpanSearchRequest);
            return new SyncInvoker<ShowSpanSearchResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowSpanSearchResponse>);
        }
        
        /// <summary>
        /// 获取汇总表格数据
        ///
        /// 获取汇总表格数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSumTableResponse ShowSumTable(ShowSumTableRequest showSumTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/metric/sum-table", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSumTableRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowSumTableResponse>(response);
        }

        public SyncInvoker<ShowSumTableResponse> ShowSumTableInvoker(ShowSumTableRequest showSumTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/metric/sum-table", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSumTableRequest);
            return new SyncInvoker<ShowSumTableResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowSumTableResponse>);
        }
        
        /// <summary>
        /// 调用链拓扑图
        ///
        /// 调用链拓扑图。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTopologyResponse ShowTopology(ShowTopologyRequest showTopologyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/trace/topology", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopologyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTopologyResponse>(response);
        }

        public SyncInvoker<ShowTopologyResponse> ShowTopologyInvoker(ShowTopologyRequest showTopologyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/trace/topology", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopologyRequest);
            return new SyncInvoker<ShowTopologyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTopologyResponse>);
        }
        
        /// <summary>
        /// 获取一个trace的所有调用链数据
        ///
        /// 获取一个trace的所有调用链数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTraceEventsResponse ShowTraceEvents(ShowTraceEventsRequest showTraceEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/trace/get-trace-events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTraceEventsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTraceEventsResponse>(response);
        }

        public SyncInvoker<ShowTraceEventsResponse> ShowTraceEventsInvoker(ShowTraceEventsRequest showTraceEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/trace/get-trace-events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTraceEventsRequest);
            return new SyncInvoker<ShowTraceEventsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTraceEventsResponse>);
        }
        
        /// <summary>
        /// 获取趋势图
        ///
        /// 获取趋势图。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTrendResponse ShowTrend(ShowTrendRequest showTrendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/metric/trend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrendRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowTrendResponse>(response);
        }

        public SyncInvoker<ShowTrendResponse> ShowTrendInvoker(ShowTrendRequest showTrendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/metric/trend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrendRequest);
            return new SyncInvoker<ShowTrendResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowTrendResponse>);
        }
        
    }
}