using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ces.V1.Model;

namespace HuaweiCloud.SDK.Ces.V1
{
    public partial class CesAsyncClient : Client
    {
        public static ClientBuilder<CesAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CesAsyncClient>();
        }

        
        /// <summary>
        /// 批量查询监控数据
        /// </summary>
        public async Task<BatchListMetricDataResponse> BatchListMetricDataAsync(BatchListMetricDataRequest batchListMetricDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/batch-query-metric-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchListMetricDataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchListMetricDataResponse>(response);
        }
        
        /// <summary>
        /// 创建告警规则
        /// </summary>
        public async Task<CreateAlarmResponse> CreateAlarmAsync(CreateAlarmRequest createAlarmRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAlarmRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAlarmResponse>(response);
        }
        
        /// <summary>
        /// 创建自定义告警模板
        /// </summary>
        public async Task<CreateAlarmTemplateResponse> CreateAlarmTemplateAsync(CreateAlarmTemplateRequest createAlarmTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAlarmTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAlarmTemplateResponse>(response);
        }
        
        /// <summary>
        /// 上报事件
        /// </summary>
        public async Task<CreateEventsResponse> CreateEventsAsync(CreateEventsRequest createEventsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/events",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEventsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            CreateEventsResponse createEventsResponse = JsonUtils.DeSerializeNull<CreateEventsResponse>(response);
            createEventsResponse.Body = JsonUtils.DeSerializeList<CreateEventsResponseBody>(response);
            return createEventsResponse;
        }
        
        /// <summary>
        /// 添加监控数据
        /// </summary>
        public async Task<CreateMetricDataResponse> CreateMetricDataAsync(CreateMetricDataRequest createMetricDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metric-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMetricDataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateMetricDataResponse>(response);
        }
        
        /// <summary>
        /// 删除告警规则
        /// </summary>
        public async Task<DeleteAlarmResponse> DeleteAlarmAsync(DeleteAlarmRequest deleteAlarmRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , deleteAlarmRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteAlarmRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAlarmResponse>(response);
        }
        
        /// <summary>
        /// 删除自定义告警模板
        /// </summary>
        public async Task<DeleteAlarmTemplateResponse> DeleteAlarmTemplateAsync(DeleteAlarmTemplateRequest deleteAlarmTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id" , deleteAlarmTemplateRequest.TemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template/{template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteAlarmTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAlarmTemplateResponse>(response);
        }
        
        /// <summary>
        /// 查询告警历史
        /// </summary>
        public async Task<ListAlarmHistoriesResponse> ListAlarmHistoriesAsync(ListAlarmHistoriesRequest listAlarmHistoriesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-histories",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listAlarmHistoriesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmHistoriesResponse>(response);
        }
        
        /// <summary>
        /// 查询自定义告警模板列表
        /// </summary>
        public async Task<ListAlarmTemplatesResponse> ListAlarmTemplatesAsync(ListAlarmTemplatesRequest listAlarmTemplatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listAlarmTemplatesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmTemplatesResponse>(response);
        }
        
        /// <summary>
        /// 查询告警规则列表
        /// </summary>
        public async Task<ListAlarmsResponse> ListAlarmsAsync(ListAlarmsRequest listAlarmsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listAlarmsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmsResponse>(response);
        }
        
        /// <summary>
        /// 查询指标列表
        /// </summary>
        public async Task<ListMetricsResponse> ListMetricsAsync(ListMetricsRequest listMetricsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metrics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listMetricsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMetricsResponse>(response);
        }
        
        /// <summary>
        /// 查询单条告警规则信息
        /// </summary>
        public async Task<ShowAlarmResponse> ShowAlarmAsync(ShowAlarmRequest showAlarmRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , showAlarmRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showAlarmRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAlarmResponse>(response);
        }
        
        /// <summary>
        /// 查询主机配置数据
        /// </summary>
        public async Task<ShowEventDataResponse> ShowEventDataAsync(ShowEventDataRequest showEventDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/event-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showEventDataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowEventDataResponse>(response);
        }
        
        /// <summary>
        /// 查询监控数据
        /// </summary>
        public async Task<ShowMetricDataResponse> ShowMetricDataAsync(ShowMetricDataRequest showMetricDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metric-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showMetricDataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMetricDataResponse>(response);
        }
        
        /// <summary>
        /// 查询配额
        /// </summary>
        public async Task<ShowQuotasResponse> ShowQuotasAsync(ShowQuotasRequest showQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showQuotasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }
        
        /// <summary>
        /// 查询资源分组下的资源
        /// </summary>
        public async Task<ShowResourceGroupResponse> ShowResourceGroupAsync(ShowResourceGroupRequest showResourceGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , showResourceGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showResourceGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowResourceGroupResponse>(response);
        }
        
        /// <summary>
        /// 启停告警规则
        /// </summary>
        public async Task<UpdateAlarmActionResponse> UpdateAlarmActionAsync(UpdateAlarmActionRequest updateAlarmActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , updateAlarmActionRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAlarmActionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateAlarmActionResponse>(response);
        }
        
        /// <summary>
        /// 更新自定义告警模板
        /// </summary>
        public async Task<UpdateAlarmTemplateResponse> UpdateAlarmTemplateAsync(UpdateAlarmTemplateRequest updateAlarmTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id" , updateAlarmTemplateRequest.TemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template/{template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAlarmTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateAlarmTemplateResponse>(response);
        }
        
    }
}