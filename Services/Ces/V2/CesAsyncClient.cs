using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ces.V2.Model;

namespace HuaweiCloud.SDK.Ces.V2
{
    public partial class CesAsyncClient : Client
    {
        public static ClientBuilder<CesAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CesAsyncClient>();
        }

        
        /// <summary>
        /// 增加告警资源(资源分组类型的告警规则不支持)
        /// </summary>
        public async Task<AddAlarmResourcesResponse> AddAlarmResourcesAsync(AddAlarmResourcesRequest addAlarmResourcesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , addAlarmResourcesRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources/batch-create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAlarmResourcesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<AddAlarmResourcesResponse>(response);
        }
        
        /// <summary>
        /// 自定义资源分组批量增加关联资源
        /// </summary>
        public async Task<AddResourceGroupsResourcesBatchResponse> AddResourceGroupsResourcesBatchAsync(AddResourceGroupsResourcesBatchRequest addResourceGroupsResourcesBatchRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , addResourceGroupsResourcesBatchRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/resources/batch-create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addResourceGroupsResourcesBatchRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<AddResourceGroupsResourcesBatchResponse>(response);
        }
        
        /// <summary>
        /// 创建告警
        /// </summary>
        public async Task<CreateAlarmResponse> CreateAlarmAsync(CreateAlarmRequest createAlarmRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAlarmResponse>(response);
        }
        
        /// <summary>
        /// 删除告警规则
        /// </summary>
        public async Task<DeleteAlarmResponse> DeleteAlarmAsync(DeleteAlarmRequest deleteAlarmRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , deleteAlarmRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAlarmResponse>(response);
        }
        
        /// <summary>
        /// 删除告警资源（资源分组类型的告警规则不支持）
        /// </summary>
        public async Task<DeleteAlarmResourcesResponse> DeleteAlarmResourcesAsync(DeleteAlarmResourcesRequest deleteAlarmResourcesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , deleteAlarmResourcesRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmResourcesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<DeleteAlarmResourcesResponse>(response);
        }
        
        /// <summary>
        /// 自定义资源分组批量删除关联资源
        /// </summary>
        public async Task<DeleteResourceGroupsResourcesBatchResponse> DeleteResourceGroupsResourcesBatchAsync(DeleteResourceGroupsResourcesBatchRequest deleteResourceGroupsResourcesBatchRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , deleteResourceGroupsResourcesBatchRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/resources/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceGroupsResourcesBatchRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<DeleteResourceGroupsResourcesBatchResponse>(response);
        }
        
        /// <summary>
        /// 查询告警历史
        /// </summary>
        public async Task<ListAlarmHistoriesResponse> ListAlarmHistoriesAsync(ListAlarmHistoriesRequest listAlarmHistoriesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-histories",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmHistoriesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmHistoriesResponse>(response);
        }
        
        /// <summary>
        /// 根据告警ID查询告警资源列表
        /// </summary>
        public async Task<ListAlarmResourcesResponse> ListAlarmResourcesAsync(ListAlarmResourcesRequest listAlarmResourcesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , listAlarmResourcesRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmResourcesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmResourcesResponse>(response);
        }
        
        /// <summary>
        /// 查询告警列表
        /// </summary>
        public async Task<ListAlarmsResponse> ListAlarmsAsync(ListAlarmsRequest listAlarmsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmsResponse>(response);
        }
        
        /// <summary>
        /// 修改告警规则基本信息
        /// </summary>
        public async Task<UpdateAlarmActionResponse> UpdateAlarmActionAsync(UpdateAlarmActionRequest updateAlarmActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , updateAlarmActionRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/base-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmActionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAlarmActionResponse>(response);
        }
        
    }
}