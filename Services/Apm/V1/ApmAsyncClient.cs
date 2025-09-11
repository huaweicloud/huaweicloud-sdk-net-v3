using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Apm.V1.Model;

namespace HuaweiCloud.SDK.Apm.V1
{
    public partial class ApmAsyncClient : Client
    {
        public static ClientBuilder<ApmAsyncClient> NewBuilder()
        {
            return new ClientBuilder<ApmAsyncClient>();
        }

        
        /// <summary>
        /// 创建aksk
        ///
        /// 创建aksk。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAkSkResponse> CreateAkSkAsync(CreateAkSkRequest createAkSkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAkSkRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAkSkResponse>(response);
        }

        public AsyncInvoker<CreateAkSkResponse> CreateAkSkAsyncInvoker(CreateAkSkRequest createAkSkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAkSkRequest);
            return new AsyncInvoker<CreateAkSkResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAkSkResponse>);
        }
        
        /// <summary>
        /// 删除aksk
        ///
        /// 删除aksk。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAkSkResponse> DeleteAkSkAsync(DeleteAkSkRequest deleteAkSkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAkSkRequest.Ak, out var valueOfAk)) urlParam.Add("ak", valueOfAk);
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/access-keys/{ak}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAkSkRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAkSkResponse>(response);
        }

        public AsyncInvoker<DeleteAkSkResponse> DeleteAkSkAsyncInvoker(DeleteAkSkRequest deleteAkSkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAkSkRequest.Ak, out var valueOfAk)) urlParam.Add("ak", valueOfAk);
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/access-keys/{ak}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAkSkRequest);
            return new AsyncInvoker<DeleteAkSkResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAkSkResponse>);
        }
        
        /// <summary>
        /// 查询租户的aksk
        ///
        /// 查询租户的aksk。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAkSksResponse> ShowAkSksAsync(ShowAkSksRequest showAkSksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAkSksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAkSksResponse>(response);
        }

        public AsyncInvoker<ShowAkSksResponse> ShowAkSksAsyncInvoker(ShowAkSksRequest showAkSksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAkSksRequest);
            return new AsyncInvoker<ShowAkSksResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAkSksResponse>);
        }
        
        /// <summary>
        /// 查询告警列表
        ///
        /// 查询系统中存在的告警。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAlarmDataResponse> ListAlarmDataAsync(ListAlarmDataRequest listAlarmDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/alarm/data/get-alarm-data-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmDataRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAlarmDataResponse>(response);
        }

        public AsyncInvoker<ListAlarmDataResponse> ListAlarmDataAsyncInvoker(ListAlarmDataRequest listAlarmDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/alarm/data/get-alarm-data-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmDataRequest);
            return new AsyncInvoker<ListAlarmDataResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAlarmDataResponse>);
        }
        
        /// <summary>
        /// 查询告警消息列表
        ///
        /// 查询单个告警的触发详情与历史。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAlarmNotifyResponse> ListAlarmNotifyAsync(ListAlarmNotifyRequest listAlarmNotifyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/alarm/data/get-alarm-notify-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmNotifyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAlarmNotifyResponse>(response);
        }

        public AsyncInvoker<ListAlarmNotifyResponse> ListAlarmNotifyAsyncInvoker(ListAlarmNotifyRequest listAlarmNotifyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/alarm/data/get-alarm-notify-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmNotifyRequest);
            return new AsyncInvoker<ListAlarmNotifyResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAlarmNotifyResponse>);
        }
        
        /// <summary>
        /// 更改实例的采集状态
        ///
        /// 改变指定实例的采集状态：开启和关闭。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeAgentStatusResponse> ChangeAgentStatusAsync(ChangeAgentStatusRequest changeAgentStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/agent-mgr/change-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeAgentStatusRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeAgentStatusResponse>(response);
        }

        public AsyncInvoker<ChangeAgentStatusResponse> ChangeAgentStatusAsyncInvoker(ChangeAgentStatusRequest changeAgentStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/agent-mgr/change-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeAgentStatusRequest);
            return new AsyncInvoker<ChangeAgentStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeAgentStatusResponse>);
        }
        
        /// <summary>
        /// 删除agent
        ///
        /// 删除agent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAgentResponse> DeleteAgentAsync(DeleteAgentRequest deleteAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/agent-mgr/delete-agent", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAgentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DeleteAgentResponse>(response);
        }

        public AsyncInvoker<DeleteAgentResponse> DeleteAgentAsyncInvoker(DeleteAgentRequest deleteAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/agent-mgr/delete-agent", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAgentRequest);
            return new AsyncInvoker<DeleteAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteAgentResponse>);
        }
        
        /// <summary>
        /// 获取ak/sk
        ///
        /// 获取该用户创建的ak/sk列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAkSkResponse> ListAkSkAsync(ListAkSkRequest listAkSkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/systemmng/get-ak-sk-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAkSkRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAkSkResponse>(response);
        }

        public AsyncInvoker<ListAkSkResponse> ListAkSkAsyncInvoker(ListAkSkRequest listAkSkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/systemmng/get-ak-sk-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAkSkRequest);
            return new AsyncInvoker<ListAkSkResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAkSkResponse>);
        }
        
        /// <summary>
        /// 查询应用列表
        ///
        /// 该接口用于查询对应用户下的应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBusinessResponse> ListBusinessAsync(ListBusinessRequest listBusinessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/business/get-business-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBusinessRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBusinessResponse>(response);
        }

        public AsyncInvoker<ListBusinessResponse> ListBusinessAsyncInvoker(ListBusinessRequest listBusinessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/business/get-business-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBusinessRequest);
            return new AsyncInvoker<ListBusinessResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBusinessResponse>);
        }
        
        /// <summary>
        /// 查询监控项列表
        ///
        /// 查询监控项列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEnvMonitorItemResponse> ListEnvMonitorItemAsync(ListEnvMonitorItemRequest listEnvMonitorItemRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/monitor-item-mgr/get-env-monitor-item-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvMonitorItemRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListEnvMonitorItemResponse>(response);
        }

        public AsyncInvoker<ListEnvMonitorItemResponse> ListEnvMonitorItemAsyncInvoker(ListEnvMonitorItemRequest listEnvMonitorItemRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/monitor-item-mgr/get-env-monitor-item-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvMonitorItemRequest);
            return new AsyncInvoker<ListEnvMonitorItemResponse>(this, "POST", request, JsonUtils.DeSerialize<ListEnvMonitorItemResponse>);
        }
        
        /// <summary>
        /// 保存监控项
        ///
        /// 保存监控项。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SaveMonitorItemConfigResponse> SaveMonitorItemConfigAsync(SaveMonitorItemConfigRequest saveMonitorItemConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/monitor-item-mgr/save-monitor-item-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveMonitorItemConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SaveMonitorItemConfigResponse>(response);
        }

        public AsyncInvoker<SaveMonitorItemConfigResponse> SaveMonitorItemConfigAsyncInvoker(SaveMonitorItemConfigRequest saveMonitorItemConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/monitor-item-mgr/save-monitor-item-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveMonitorItemConfigRequest);
            return new AsyncInvoker<SaveMonitorItemConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<SaveMonitorItemConfigResponse>);
        }
        
        /// <summary>
        /// 查询应用下所有探针
        ///
        /// 该接口用于搜索应用下所有探针情况。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchAgentResponse> SearchAgentAsync(SearchAgentRequest searchAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/agent-mgr/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchAgentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SearchAgentResponse>(response);
        }

        public AsyncInvoker<SearchAgentResponse> SearchAgentAsyncInvoker(SearchAgentRequest searchAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/agent-mgr/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchAgentRequest);
            return new AsyncInvoker<SearchAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchAgentResponse>);
        }
        
        /// <summary>
        /// 对指定区域下的组件和环境及其探针情况进行搜索
        ///
        /// 对指定区域下的组件和环境及其探针情况进行搜索。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchApplicationResponse> SearchApplicationAsync(SearchApplicationRequest searchApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/app-mgr/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchApplicationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SearchApplicationResponse>(response);
        }

        public AsyncInvoker<SearchApplicationResponse> SearchApplicationAsyncInvoker(SearchApplicationRequest searchApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/app-mgr/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchApplicationRequest);
            return new AsyncInvoker<SearchApplicationResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchApplicationResponse>);
        }
        
        /// <summary>
        /// 查询master地址
        ///
        /// 根据region名称获取该region下的master服务podlb地址信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMasterAddressResponse> ShowMasterAddressAsync(ShowMasterAddressRequest showMasterAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/systemmng/get-master-address", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMasterAddressRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMasterAddressResponse>(response);
        }

        public AsyncInvoker<ShowMasterAddressResponse> ShowMasterAddressAsyncInvoker(ShowMasterAddressRequest showMasterAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/systemmng/get-master-address", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMasterAddressRequest);
            return new AsyncInvoker<ShowMasterAddressResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMasterAddressResponse>);
        }
        
        /// <summary>
        /// 根据组件id删除指定的组件
        ///
        /// 该接口用于删除指定的组件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest deleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAppRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/apps/delete-app/{application_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAppResponse>(response);
        }

        public AsyncInvoker<DeleteAppResponse> DeleteAppAsyncInvoker(DeleteAppRequest deleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAppRequest.ApplicationId, out var valueOfApplicationId)) urlParam.Add("application_id", valueOfApplicationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/apps/delete-app/{application_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            return new AsyncInvoker<DeleteAppResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAppResponse>);
        }
        
        /// <summary>
        /// 获取组件下的环境列表
        ///
        /// 获取组件下的环境列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAppEnvsResponse> ListAppEnvsAsync(ListAppEnvsRequest listAppEnvsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/envs/get-app-envs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppEnvsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAppEnvsResponse>(response);
        }

        public AsyncInvoker<ListAppEnvsResponse> ListAppEnvsAsyncInvoker(ListAppEnvsRequest listAppEnvsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/envs/get-app-envs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppEnvsRequest);
            return new AsyncInvoker<ListAppEnvsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppEnvsResponse>);
        }
        
        /// <summary>
        /// 获取组件列表
        ///
        /// 获取组件列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAppsResponse> ListAppsAsync(ListAppsRequest listAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/apps/get-apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAppsResponse>(response);
        }

        public AsyncInvoker<ListAppsResponse> ListAppsAsyncInvoker(ListAppsRequest listAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/apps/get-apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppsRequest);
            return new AsyncInvoker<ListAppsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppsResponse>);
        }
        
        /// <summary>
        /// 查询环境标签
        ///
        /// 查询环境标签接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEnvTagsResponse> ListEnvTagsAsync(ListEnvTagsRequest listEnvTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/tag/get-env-tag-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListEnvTagsResponse>(response);
        }

        public AsyncInvoker<ListEnvTagsResponse> ListEnvTagsAsyncInvoker(ListEnvTagsRequest listEnvTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/tag/get-env-tag-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvTagsRequest);
            return new AsyncInvoker<ListEnvTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListEnvTagsResponse>);
        }
        
        /// <summary>
        /// 查询单个应用的详情
        ///
        /// 查询单个应用的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBusinessDetailResponse> ShowBusinessDetailAsync(ShowBusinessDetailRequest showBusinessDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBusinessDetailRequest.BusinessId, out var valueOfBusinessId)) urlParam.Add("business_id", valueOfBusinessId);
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/business/get-business-detail/{business_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBusinessDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBusinessDetailResponse>(response);
        }

        public AsyncInvoker<ShowBusinessDetailResponse> ShowBusinessDetailAsyncInvoker(ShowBusinessDetailRequest showBusinessDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBusinessDetailRequest.BusinessId, out var valueOfBusinessId)) urlParam.Add("business_id", valueOfBusinessId);
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/business/get-business-detail/{business_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBusinessDetailRequest);
            return new AsyncInvoker<ShowBusinessDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBusinessDetailResponse>);
        }
        
        /// <summary>
        /// 查询子应用详情
        ///
        /// 查询单个子应用详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSubBusinessDetailResponse> ShowSubBusinessDetailAsync(ShowSubBusinessDetailRequest showSubBusinessDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSubBusinessDetailRequest.SubBusinessId, out var valueOfSubBusinessId)) urlParam.Add("sub_business_id", valueOfSubBusinessId);
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/sub-business/get-sub-business-detail/{sub_business_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubBusinessDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSubBusinessDetailResponse>(response);
        }

        public AsyncInvoker<ShowSubBusinessDetailResponse> ShowSubBusinessDetailAsyncInvoker(ShowSubBusinessDetailRequest showSubBusinessDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSubBusinessDetailRequest.SubBusinessId, out var valueOfSubBusinessId)) urlParam.Add("sub_business_id", valueOfSubBusinessId);
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/sub-business/get-sub-business-detail/{sub_business_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubBusinessDetailRequest);
            return new AsyncInvoker<ShowSubBusinessDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSubBusinessDetailResponse>);
        }
        
        /// <summary>
        /// 获取应用树
        ///
        /// 获取应用树。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTopologyTreeResponse> ShowTopologyTreeAsync(ShowTopologyTreeRequest showTopologyTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/topology-trees/get-topology-trees", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopologyTreeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTopologyTreeResponse>(response);
        }

        public AsyncInvoker<ShowTopologyTreeResponse> ShowTopologyTreeAsyncInvoker(ShowTopologyTreeRequest showTopologyTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/cmdb/topology-trees/get-topology-trees", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopologyTreeRequest);
            return new AsyncInvoker<ShowTopologyTreeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTopologyTreeResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFlameLineTreeResponse> ShowFlameLineTreeAsync(ShowFlameLineTreeRequest showFlameLineTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/profiling/flame-line-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlameLineTreeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowFlameLineTreeResponse>(response);
        }

        public AsyncInvoker<ShowFlameLineTreeResponse> ShowFlameLineTreeAsyncInvoker(ShowFlameLineTreeRequest showFlameLineTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/profiling/flame-line-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlameLineTreeRequest);
            return new AsyncInvoker<ShowFlameLineTreeResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowFlameLineTreeResponse>);
        }
        
        /// <summary>
        /// 查询开通的region
        ///
        /// 该接口用于查询用户开通的region信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOpenRegionResponse> ListOpenRegionAsync(ListOpenRegionRequest listOpenRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/region/get-opened-region", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOpenRegionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOpenRegionResponse>(response);
        }

        public AsyncInvoker<ListOpenRegionResponse> ListOpenRegionAsyncInvoker(ListOpenRegionRequest listOpenRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/region/get-opened-region", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOpenRegionRequest);
            return new AsyncInvoker<ListOpenRegionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOpenRegionResponse>);
        }
        
        /// <summary>
        /// 查询所有的支持的region
        ///
        /// 查询所有的支持的region信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSupportedRegionResponse> ListSupportedRegionAsync(ListSupportedRegionRequest listSupportedRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/region/get-all-supported-region", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportedRegionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSupportedRegionResponse>(response);
        }

        public AsyncInvoker<ListSupportedRegionResponse> ListSupportedRegionAsyncInvoker(ListSupportedRegionRequest listSupportedRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/region/get-all-supported-region", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportedRegionRequest);
            return new AsyncInvoker<ListSupportedRegionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSupportedRegionResponse>);
        }
        
        /// <summary>
        /// 查询应用全局拓扑图
        ///
        /// 查询应用级别全局拓扑图信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchBusinessTopologyResponse> SearchBusinessTopologyAsync(SearchBusinessTopologyRequest searchBusinessTopologyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/topology/business-search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchBusinessTopologyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SearchBusinessTopologyResponse>(response);
        }

        public AsyncInvoker<SearchBusinessTopologyResponse> SearchBusinessTopologyAsyncInvoker(SearchBusinessTopologyRequest searchBusinessTopologyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/topology/business-search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchBusinessTopologyRequest);
            return new AsyncInvoker<SearchBusinessTopologyResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchBusinessTopologyResponse>);
        }
        
        /// <summary>
        /// 查询组件环境拓扑图
        ///
        /// 查询组件环境级别全局拓扑图信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchEnvTopologyResponse> SearchEnvTopologyAsync(SearchEnvTopologyRequest searchEnvTopologyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/topology/env-search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchEnvTopologyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SearchEnvTopologyResponse>(response);
        }

        public AsyncInvoker<SearchEnvTopologyResponse> SearchEnvTopologyAsyncInvoker(SearchEnvTopologyRequest searchEnvTopologyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/topology/env-search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchEnvTopologyRequest);
            return new AsyncInvoker<SearchEnvTopologyResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchEnvTopologyResponse>);
        }
        
        /// <summary>
        /// 创建链路追踪应用
        ///
        /// 创建链路追踪应用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateBusinessResponse> CreateBusinessAsync(CreateBusinessRequest createBusinessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/tracing/business/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBusinessRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateBusinessResponse>(response);
        }

        public AsyncInvoker<CreateBusinessResponse> CreateBusinessAsyncInvoker(CreateBusinessRequest createBusinessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/tracing/business/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBusinessRequest);
            return new AsyncInvoker<CreateBusinessResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBusinessResponse>);
        }
        
        /// <summary>
        /// 获取链路追踪应用接入地址
        ///
        /// 获取链路追踪应用接入地址
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAccessPointResponse> ShowAccessPointAsync(ShowAccessPointRequest showAccessPointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAccessPointRequest.BusinessId, out var valueOfBusinessId)) urlParam.Add("business_id", valueOfBusinessId);
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/tracing/access/get-access-point/{business_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessPointRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowAccessPointResponse>(response);
        }

        public AsyncInvoker<ShowAccessPointResponse> ShowAccessPointAsyncInvoker(ShowAccessPointRequest showAccessPointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAccessPointRequest.BusinessId, out var valueOfBusinessId)) urlParam.Add("business_id", valueOfBusinessId);
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/tracing/access/get-access-point/{business_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessPointRequest);
            return new AsyncInvoker<ShowAccessPointResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowAccessPointResponse>);
        }
        
        /// <summary>
        /// 获取链路追踪应用的token
        ///
        /// 获取链路追踪应用的token
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTokenResponse> ShowTokenAsync(ShowTokenRequest showTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTokenRequest.BusinessId, out var valueOfBusinessId)) urlParam.Add("business_id", valueOfBusinessId);
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/tracing/business/token/{business_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTokenRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTokenResponse>(response);
        }

        public AsyncInvoker<ShowTokenResponse> ShowTokenAsyncInvoker(ShowTokenRequest showTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTokenRequest.BusinessId, out var valueOfBusinessId)) urlParam.Add("business_id", valueOfBusinessId);
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/tracing/business/token/{business_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTokenRequest);
            return new AsyncInvoker<ShowTokenResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTokenResponse>);
        }
        
        /// <summary>
        /// 查询URL跟踪Region环境列表
        ///
        /// 查询所选Region下设置了URL跟踪的环境列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBusinessEnvResponse> ListBusinessEnvAsync(ListBusinessEnvRequest listBusinessEnvRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/transaction/business-env", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBusinessEnvRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListBusinessEnvResponse>(response);
        }

        public AsyncInvoker<ListBusinessEnvResponse> ListBusinessEnvAsyncInvoker(ListBusinessEnvRequest listBusinessEnvRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/transaction/business-env", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBusinessEnvRequest);
            return new AsyncInvoker<ListBusinessEnvResponse>(this, "POST", request, JsonUtils.DeSerialize<ListBusinessEnvResponse>);
        }
        
        /// <summary>
        /// 查询URL跟踪视图列表
        ///
        /// 查询当前被调用的URL跟踪视图列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchTransactionResponse> SearchTransactionAsync(SearchTransactionRequest searchTransactionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/transaction/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchTransactionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SearchTransactionResponse>(response);
        }

        public AsyncInvoker<SearchTransactionResponse> SearchTransactionAsyncInvoker(SearchTransactionRequest searchTransactionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/transaction/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchTransactionRequest);
            return new AsyncInvoker<SearchTransactionResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchTransactionResponse>);
        }
        
        /// <summary>
        /// 查询URL跟踪配置列表
        ///
        /// 查询已配置好的URL跟踪配置列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchTransactionConfigResponse> SearchTransactionConfigAsync(SearchTransactionConfigRequest searchTransactionConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/transaction/transaction-config-search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchTransactionConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SearchTransactionConfigResponse>(response);
        }

        public AsyncInvoker<SearchTransactionConfigResponse> SearchTransactionConfigAsyncInvoker(SearchTransactionConfigRequest searchTransactionConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/transaction/transaction-config-search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchTransactionConfigRequest);
            return new AsyncInvoker<SearchTransactionConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchTransactionConfigResponse>);
        }
        
        /// <summary>
        /// 查询URL跟踪视图详情
        ///
        /// 查询某条URL跟踪视图详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTransactionDetailResponse> ShowTransactionDetailAsync(ShowTransactionDetailRequest showTransactionDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/transaction/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransactionDetailRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowTransactionDetailResponse>(response);
        }

        public AsyncInvoker<ShowTransactionDetailResponse> ShowTransactionDetailAsyncInvoker(ShowTransactionDetailRequest showTransactionDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/transaction/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransactionDetailRequest);
            return new AsyncInvoker<ShowTransactionDetailResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowTransactionDetailResponse>);
        }
        
        /// <summary>
        /// 获取实例信息列表
        ///
        /// 获取实例信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEnvInstancesResponse> ListEnvInstancesAsync(ListEnvInstancesRequest listEnvInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/mainview/get-env-instance-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvInstancesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListEnvInstancesResponse>(response);
        }

        public AsyncInvoker<ListEnvInstancesResponse> ListEnvInstancesAsyncInvoker(ListEnvInstancesRequest listEnvInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/mainview/get-env-instance-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnvInstancesRequest);
            return new AsyncInvoker<ListEnvInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListEnvInstancesResponse>);
        }
        
        /// <summary>
        /// 获取原始数据详情
        ///
        /// 获取原始数据详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowClobDetailResponse> ShowClobDetailAsync(ShowClobDetailRequest showClobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/metric/get-clob-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClobDetailRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowClobDetailResponse>(response);
        }

        public AsyncInvoker<ShowClobDetailResponse> ShowClobDetailAsyncInvoker(ShowClobDetailRequest showClobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/metric/get-clob-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClobDetailRequest);
            return new AsyncInvoker<ShowClobDetailResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowClobDetailResponse>);
        }
        
        /// <summary>
        /// 获取监控项信息
        ///
        /// 获取监控项信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEnvMonitorItemsResponse> ShowEnvMonitorItemsAsync(ShowEnvMonitorItemsRequest showEnvMonitorItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/mainview/get-env-monitor-item-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvMonitorItemsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowEnvMonitorItemsResponse>(response);
        }

        public AsyncInvoker<ShowEnvMonitorItemsResponse> ShowEnvMonitorItemsAsyncInvoker(ShowEnvMonitorItemsRequest showEnvMonitorItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/mainview/get-env-monitor-item-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvMonitorItemsRequest);
            return new AsyncInvoker<ShowEnvMonitorItemsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEnvMonitorItemsResponse>);
        }
        
        /// <summary>
        /// 获取event的详情
        ///
        /// 获取event的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEventDetailResponse> ShowEventDetailAsync(ShowEventDetailRequest showEventDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/trace/get-event-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEventDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowEventDetailResponse>(response);
        }

        public AsyncInvoker<ShowEventDetailResponse> ShowEventDetailAsyncInvoker(ShowEventDetailRequest showEventDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/trace/get-event-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEventDetailRequest);
            return new AsyncInvoker<ShowEventDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEventDetailResponse>);
        }
        
        /// <summary>
        /// 获取一个监控项的详情
        ///
        /// 获取一个监控项的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMonitorItemDetailResponse> ShowMonitorItemDetailAsync(ShowMonitorItemDetailRequest showMonitorItemDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/monitor-item-mgr/get-monitor-item-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMonitorItemDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMonitorItemDetailResponse>(response);
        }

        public AsyncInvoker<ShowMonitorItemDetailResponse> ShowMonitorItemDetailAsyncInvoker(ShowMonitorItemDetailRequest showMonitorItemDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/apm-service/monitor-item-mgr/get-monitor-item-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMonitorItemDetailRequest);
            return new AsyncInvoker<ShowMonitorItemDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMonitorItemDetailResponse>);
        }
        
        /// <summary>
        /// 查询监控项配置信息
        ///
        /// 查询监控项配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMonitorItemViewConfigResponse> ShowMonitorItemViewConfigAsync(ShowMonitorItemViewConfigRequest showMonitorItemViewConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/config/get-monitor-item-view-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMonitorItemViewConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMonitorItemViewConfigResponse>(response);
        }

        public AsyncInvoker<ShowMonitorItemViewConfigResponse> ShowMonitorItemViewConfigAsyncInvoker(ShowMonitorItemViewConfigRequest showMonitorItemViewConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/config/get-monitor-item-view-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMonitorItemViewConfigRequest);
            return new AsyncInvoker<ShowMonitorItemViewConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMonitorItemViewConfigResponse>);
        }
        
        /// <summary>
        /// 获取原始数据表格
        ///
        /// 获取原始数据表格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRawTableResponse> ShowRawTableAsync(ShowRawTableRequest showRawTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/metric/raw-table", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRawTableRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowRawTableResponse>(response);
        }

        public AsyncInvoker<ShowRawTableResponse> ShowRawTableAsyncInvoker(ShowRawTableRequest showRawTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/metric/raw-table", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRawTableRequest);
            return new AsyncInvoker<ShowRawTableResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowRawTableResponse>);
        }
        
        /// <summary>
        /// 查询span数据
        ///
        /// span数据查询接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSpanSearchResponse> ShowSpanSearchAsync(ShowSpanSearchRequest showSpanSearchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/trace/span-search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSpanSearchRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowSpanSearchResponse>(response);
        }

        public AsyncInvoker<ShowSpanSearchResponse> ShowSpanSearchAsyncInvoker(ShowSpanSearchRequest showSpanSearchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/trace/span-search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSpanSearchRequest);
            return new AsyncInvoker<ShowSpanSearchResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowSpanSearchResponse>);
        }
        
        /// <summary>
        /// 获取汇总表格数据
        ///
        /// 获取汇总表格数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSumTableResponse> ShowSumTableAsync(ShowSumTableRequest showSumTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/metric/sum-table", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSumTableRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowSumTableResponse>(response);
        }

        public AsyncInvoker<ShowSumTableResponse> ShowSumTableAsyncInvoker(ShowSumTableRequest showSumTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/metric/sum-table", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSumTableRequest);
            return new AsyncInvoker<ShowSumTableResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowSumTableResponse>);
        }
        
        /// <summary>
        /// 调用链拓扑图
        ///
        /// 调用链拓扑图。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTopologyResponse> ShowTopologyAsync(ShowTopologyRequest showTopologyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/trace/topology", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopologyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTopologyResponse>(response);
        }

        public AsyncInvoker<ShowTopologyResponse> ShowTopologyAsyncInvoker(ShowTopologyRequest showTopologyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/trace/topology", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopologyRequest);
            return new AsyncInvoker<ShowTopologyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTopologyResponse>);
        }
        
        /// <summary>
        /// 获取一个trace的所有调用链数据
        ///
        /// 获取一个trace的所有调用链数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTraceEventsResponse> ShowTraceEventsAsync(ShowTraceEventsRequest showTraceEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/trace/get-trace-events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTraceEventsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTraceEventsResponse>(response);
        }

        public AsyncInvoker<ShowTraceEventsResponse> ShowTraceEventsAsyncInvoker(ShowTraceEventsRequest showTraceEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/trace/get-trace-events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTraceEventsRequest);
            return new AsyncInvoker<ShowTraceEventsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTraceEventsResponse>);
        }
        
        /// <summary>
        /// 获取趋势图
        ///
        /// 获取趋势图。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTrendResponse> ShowTrendAsync(ShowTrendRequest showTrendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/metric/trend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrendRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowTrendResponse>(response);
        }

        public AsyncInvoker<ShowTrendResponse> ShowTrendAsyncInvoker(ShowTrendRequest showTrendRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/apm2/openapi/view/metric/trend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrendRequest);
            return new AsyncInvoker<ShowTrendResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowTrendResponse>);
        }
        
    }
}