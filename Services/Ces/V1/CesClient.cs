using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ces.V1.Model;

namespace HuaweiCloud.SDK.Ces.V1
{
    public partial class CesClient : Client
    {
        public static ClientBuilder<CesClient> NewBuilder()
        {
            return new ClientBuilder<CesClient>();
        }

        
        /// <summary>
        /// 批量查询监控数据
        /// </summary>
        public BatchListMetricDataResponse BatchListMetricData(BatchListMetricDataRequest batchListMetricDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/batch-query-metric-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchListMetricDataRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchListMetricDataResponse>(response);
        }
        
        /// <summary>
        /// 创建告警规则
        /// </summary>
        public CreateAlarmResponse CreateAlarm(CreateAlarmRequest createAlarmRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAlarmRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateAlarmResponse>(response);
        }
        
        /// <summary>
        /// 上报事件
        /// </summary>
        public CreateEventsResponse CreateEvents(CreateEventsRequest createEventsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/events",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEventsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            CreateEventsResponse createEventsResponse = JsonUtils.DeSerializeNull<CreateEventsResponse>(response);
            createEventsResponse.Body = JsonUtils.DeSerializeList<CreateEventsResponseBody>(response);
            return createEventsResponse;
        }
        
        /// <summary>
        /// 添加监控数据
        /// </summary>
        public CreateMetricDataResponse CreateMetricData(CreateMetricDataRequest createMetricDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metric-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMetricDataRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateMetricDataResponse>(response);
        }
        
        /// <summary>
        /// 删除告警规则
        /// </summary>
        public DeleteAlarmResponse DeleteAlarm(DeleteAlarmRequest deleteAlarmRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , deleteAlarmRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteAlarmRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAlarmResponse>(response);
        }
        
        /// <summary>
        /// 查询告警规则列表
        /// </summary>
        public ListAlarmsResponse ListAlarms(ListAlarmsRequest listAlarmsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listAlarmsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmsResponse>(response);
        }
        
        /// <summary>
        /// 查询指标列表
        /// </summary>
        public ListMetricsResponse ListMetrics(ListMetricsRequest listMetricsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metrics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listMetricsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListMetricsResponse>(response);
        }
        
        /// <summary>
        /// 查询单条告警规则信息
        /// </summary>
        public ShowAlarmResponse ShowAlarm(ShowAlarmRequest showAlarmRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , showAlarmRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showAlarmRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAlarmResponse>(response);
        }
        
        /// <summary>
        /// 查询主机配置数据
        /// </summary>
        public ShowEventDataResponse ShowEventData(ShowEventDataRequest showEventDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/event-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showEventDataRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowEventDataResponse>(response);
        }
        
        /// <summary>
        /// 查询监控数据
        /// </summary>
        public ShowMetricDataResponse ShowMetricData(ShowMetricDataRequest showMetricDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metric-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showMetricDataRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowMetricDataResponse>(response);
        }
        
        /// <summary>
        /// 查询配额
        /// </summary>
        public ShowQuotasResponse ShowQuotas(ShowQuotasRequest showQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showQuotasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }
        
        /// <summary>
        /// 启停告警规则
        /// </summary>
        public UpdateAlarmActionResponse UpdateAlarmAction(UpdateAlarmActionRequest updateAlarmActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , updateAlarmActionRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAlarmActionRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateAlarmActionResponse>(response);
        }
        
    }
}