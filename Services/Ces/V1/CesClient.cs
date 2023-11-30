using System;
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
        ///
        /// 批量查询指定时间范围内指定指标的指定粒度的监控数据，目前最多支持500指标的批量查询。 对于不同的period取值和查询的指标数量，默认的最大查询区间(to-from)不同。 规则为\&quot;指标数量*(to-from)/监控周期&lt;&#x3D;3000\&quot;，若超出阈值，会自动调整from以满足规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchListMetricDataResponse BatchListMetricData(BatchListMetricDataRequest batchListMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/batch-query-metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListMetricDataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchListMetricDataResponse>(response);
        }

        public SyncInvoker<BatchListMetricDataResponse> BatchListMetricDataInvoker(BatchListMetricDataRequest batchListMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/batch-query-metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListMetricDataRequest);
            return new SyncInvoker<BatchListMetricDataResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchListMetricDataResponse>);
        }
        
        /// <summary>
        /// 创建告警规则
        ///
        /// 创建一条告警规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAlarmResponse CreateAlarm(CreateAlarmRequest createAlarmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAlarmResponse>(response);
        }

        public SyncInvoker<CreateAlarmResponse> CreateAlarmInvoker(CreateAlarmRequest createAlarmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmRequest);
            return new SyncInvoker<CreateAlarmResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAlarmResponse>);
        }
        
        /// <summary>
        /// 创建自定义告警模板
        ///
        /// 创建自定义告警模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAlarmTemplateResponse CreateAlarmTemplate(CreateAlarmTemplateRequest createAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAlarmTemplateResponse>(response);
        }

        public SyncInvoker<CreateAlarmTemplateResponse> CreateAlarmTemplateInvoker(CreateAlarmTemplateRequest createAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmTemplateRequest);
            return new SyncInvoker<CreateAlarmTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAlarmTemplateResponse>);
        }
        
        /// <summary>
        /// 上报事件
        ///
        /// 上报自定义事件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateEventsResponse CreateEvents(CreateEventsRequest createEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEventsRequest);
            var response = DoHttpRequestSync("POST", request);
            var createEventsResponse = JsonUtils.DeSerializeNull<CreateEventsResponse>(response);
            createEventsResponse.Body = JsonUtils.DeSerializeList<CreateEventsResponseBody>(response);
            return createEventsResponse;
        }

        public SyncInvoker<CreateEventsResponse> CreateEventsInvoker(CreateEventsRequest createEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEventsRequest);
            return new SyncInvoker<CreateEventsResponse>(this, "POST", request, response =>
            {
                var createEventsResponse = JsonUtils.DeSerializeNull<CreateEventsResponse>(response);
                createEventsResponse.Body = JsonUtils.DeSerializeList<CreateEventsResponseBody>(response);
                return createEventsResponse;
            });
        }
        
        /// <summary>
        /// 添加监控数据
        ///
        /// 添加一条或多条指标监控数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMetricDataResponse CreateMetricData(CreateMetricDataRequest createMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMetricDataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateMetricDataResponse>(response);
        }

        public SyncInvoker<CreateMetricDataResponse> CreateMetricDataInvoker(CreateMetricDataRequest createMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMetricDataRequest);
            return new SyncInvoker<CreateMetricDataResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateMetricDataResponse>);
        }
        
        /// <summary>
        /// 创建资源分组
        ///
        /// 创建资源分组，资源分组支持将各类资源按照业务集中进行分组管理，可以从分组角度查看监控与告警信息，以提升运维效率。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateResourceGroupResponse CreateResourceGroup(CreateResourceGroupRequest createResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateResourceGroupResponse>(response);
        }

        public SyncInvoker<CreateResourceGroupResponse> CreateResourceGroupInvoker(CreateResourceGroupRequest createResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceGroupRequest);
            return new SyncInvoker<CreateResourceGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateResourceGroupResponse>);
        }
        
        /// <summary>
        /// 删除告警规则
        ///
        /// 删除一条告警规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAlarmResponse DeleteAlarm(DeleteAlarmRequest deleteAlarmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id", deleteAlarmRequest.AlarmId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAlarmResponse>(response);
        }

        public SyncInvoker<DeleteAlarmResponse> DeleteAlarmInvoker(DeleteAlarmRequest deleteAlarmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id", deleteAlarmRequest.AlarmId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRequest);
            return new SyncInvoker<DeleteAlarmResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAlarmResponse>);
        }
        
        /// <summary>
        /// 删除自定义告警模板
        ///
        /// 根据ID删除自定义告警模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAlarmTemplateResponse DeleteAlarmTemplate(DeleteAlarmTemplateRequest deleteAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id", deleteAlarmTemplateRequest.TemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAlarmTemplateResponse>(response);
        }

        public SyncInvoker<DeleteAlarmTemplateResponse> DeleteAlarmTemplateInvoker(DeleteAlarmTemplateRequest deleteAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id", deleteAlarmTemplateRequest.TemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmTemplateRequest);
            return new SyncInvoker<DeleteAlarmTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAlarmTemplateResponse>);
        }
        
        /// <summary>
        /// 删除资源分组
        ///
        /// 删除一条资源分组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteResourceGroupResponse DeleteResourceGroup(DeleteResourceGroupRequest deleteResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteResourceGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteResourceGroupResponse>(response);
        }

        public SyncInvoker<DeleteResourceGroupResponse> DeleteResourceGroupInvoker(DeleteResourceGroupRequest deleteResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteResourceGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceGroupRequest);
            return new SyncInvoker<DeleteResourceGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteResourceGroupResponse>);
        }
        
        /// <summary>
        /// 查询告警历史
        ///
        /// 查询告警历史列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAlarmHistoriesResponse ListAlarmHistories(ListAlarmHistoriesRequest listAlarmHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmHistoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmHistoriesResponse>(response);
        }

        public SyncInvoker<ListAlarmHistoriesResponse> ListAlarmHistoriesInvoker(ListAlarmHistoriesRequest listAlarmHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmHistoriesRequest);
            return new SyncInvoker<ListAlarmHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmHistoriesResponse>);
        }
        
        /// <summary>
        /// 查询自定义告警模板列表
        ///
        /// 查询自定义告警模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAlarmTemplatesResponse ListAlarmTemplates(ListAlarmTemplatesRequest listAlarmTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmTemplatesResponse>(response);
        }

        public SyncInvoker<ListAlarmTemplatesResponse> ListAlarmTemplatesInvoker(ListAlarmTemplatesRequest listAlarmTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTemplatesRequest);
            return new SyncInvoker<ListAlarmTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询告警规则列表
        ///
        /// 查询告警规则列表，可以指定分页条件限制结果数量，可以指定排序规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAlarmsResponse ListAlarms(ListAlarmsRequest listAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmsResponse>(response);
        }

        public SyncInvoker<ListAlarmsResponse> ListAlarmsInvoker(ListAlarmsRequest listAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmsRequest);
            return new SyncInvoker<ListAlarmsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmsResponse>);
        }
        
        /// <summary>
        /// 查询某一事件监控详情
        ///
        /// 根据事件监控名称，查询该事件发生的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEventDetailResponse ListEventDetail(ListEventDetailRequest listEventDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("event_name", listEventDetailRequest.EventName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/event/{event_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEventDetailResponse>(response);
        }

        public SyncInvoker<ListEventDetailResponse> ListEventDetailInvoker(ListEventDetailRequest listEventDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("event_name", listEventDetailRequest.EventName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/event/{event_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventDetailRequest);
            return new SyncInvoker<ListEventDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEventDetailResponse>);
        }
        
        /// <summary>
        /// 查询事件监控列表
        ///
        /// 查询事件监控列表，包括系统事件和自定义事件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEventsResponse ListEvents(ListEventsRequest listEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEventsResponse>(response);
        }

        public SyncInvoker<ListEventsResponse> ListEventsInvoker(ListEventsRequest listEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventsRequest);
            return new SyncInvoker<ListEventsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEventsResponse>);
        }
        
        /// <summary>
        /// 查询指标列表
        ///
        /// 查询系统当前可监控指标列表，可以指定指标命名空间、指标名称、维度、排序方式，起始记录和最大记录条数过滤查询结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMetricsResponse ListMetrics(ListMetricsRequest listMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metrics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMetricsResponse>(response);
        }

        public SyncInvoker<ListMetricsResponse> ListMetricsInvoker(ListMetricsRequest listMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metrics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricsRequest);
            return new SyncInvoker<ListMetricsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMetricsResponse>);
        }
        
        /// <summary>
        /// 查询所有资源分组
        ///
        /// 查询所创建的所有资源分组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceGroupResponse ListResourceGroup(ListResourceGroupRequest listResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListResourceGroupResponse>(response);
        }

        public SyncInvoker<ListResourceGroupResponse> ListResourceGroupInvoker(ListResourceGroupRequest listResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceGroupRequest);
            return new SyncInvoker<ListResourceGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceGroupResponse>);
        }
        
        /// <summary>
        /// 查询单条告警规则信息
        ///
        /// 根据告警ID查询告警规则信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAlarmResponse ShowAlarm(ShowAlarmRequest showAlarmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id", showAlarmRequest.AlarmId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAlarmResponse>(response);
        }

        public SyncInvoker<ShowAlarmResponse> ShowAlarmInvoker(ShowAlarmRequest showAlarmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id", showAlarmRequest.AlarmId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmRequest);
            return new SyncInvoker<ShowAlarmResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAlarmResponse>);
        }
        
        /// <summary>
        /// 查询主机配置数据
        ///
        /// 查询指定时间范围指定事件类型的主机配置数据，可以通过参数指定需要查询的数据维度。注意：该接口提供给HANA场景下SAP Monitor查询主机配置数据，其他场景下查不到主机配置数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEventDataResponse ShowEventData(ShowEventDataRequest showEventDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/event-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEventDataRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEventDataResponse>(response);
        }

        public SyncInvoker<ShowEventDataResponse> ShowEventDataInvoker(ShowEventDataRequest showEventDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/event-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEventDataRequest);
            return new SyncInvoker<ShowEventDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEventDataResponse>);
        }
        
        /// <summary>
        /// 查询监控数据
        ///
        /// 查询指定时间范围指定指标的指定粒度的监控数据，可以通过参数指定需要查询的数据维度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMetricDataResponse ShowMetricData(ShowMetricDataRequest showMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetricDataRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMetricDataResponse>(response);
        }

        public SyncInvoker<ShowMetricDataResponse> ShowMetricDataInvoker(ShowMetricDataRequest showMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetricDataRequest);
            return new SyncInvoker<ShowMetricDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMetricDataResponse>);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// 查询用户可以创建的资源配额总数及当前使用量，当前仅有告警规则一种资源类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowQuotasResponse ShowQuotas(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }

        public SyncInvoker<ShowQuotasResponse> ShowQuotasInvoker(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            return new SyncInvoker<ShowQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotasResponse>);
        }
        
        /// <summary>
        /// 查询资源分组下的资源
        ///
        /// 根据资源分组ID查询资源分组下的资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceGroupResponse ShowResourceGroup(ShowResourceGroupRequest showResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", showResourceGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceGroupResponse>(response);
        }

        public SyncInvoker<ShowResourceGroupResponse> ShowResourceGroupInvoker(ShowResourceGroupRequest showResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", showResourceGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceGroupRequest);
            return new SyncInvoker<ShowResourceGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceGroupResponse>);
        }
        
        /// <summary>
        /// 修改告警规则
        ///
        /// 修改告警规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAlarmResponse UpdateAlarm(UpdateAlarmRequest updateAlarmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id", updateAlarmRequest.AlarmId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAlarmResponse>(response);
        }

        public SyncInvoker<UpdateAlarmResponse> UpdateAlarmInvoker(UpdateAlarmRequest updateAlarmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id", updateAlarmRequest.AlarmId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmRequest);
            return new SyncInvoker<UpdateAlarmResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAlarmResponse>);
        }
        
        /// <summary>
        /// 启停告警规则
        ///
        /// 启动或停止一条告警规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAlarmActionResponse UpdateAlarmAction(UpdateAlarmActionRequest updateAlarmActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id", updateAlarmActionRequest.AlarmId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmActionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAlarmActionResponse>(response);
        }

        public SyncInvoker<UpdateAlarmActionResponse> UpdateAlarmActionInvoker(UpdateAlarmActionRequest updateAlarmActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id", updateAlarmActionRequest.AlarmId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmActionRequest);
            return new SyncInvoker<UpdateAlarmActionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAlarmActionResponse>);
        }
        
        /// <summary>
        /// 更新自定义告警模板
        ///
        /// 更新自定义告警模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAlarmTemplateResponse UpdateAlarmTemplate(UpdateAlarmTemplateRequest updateAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id", updateAlarmTemplateRequest.TemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAlarmTemplateResponse>(response);
        }

        public SyncInvoker<UpdateAlarmTemplateResponse> UpdateAlarmTemplateInvoker(UpdateAlarmTemplateRequest updateAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id", updateAlarmTemplateRequest.TemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmTemplateRequest);
            return new SyncInvoker<UpdateAlarmTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAlarmTemplateResponse>);
        }
        
        /// <summary>
        /// 更新资源分组
        ///
        /// 更新资源分组，资源分组支持将各类资源按照业务集中进行分组管理，可以从分组角度查看监控与告警信息，以提升运维效率。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateResourceGroupResponse UpdateResourceGroup(UpdateResourceGroupRequest updateResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateResourceGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateResourceGroupResponse>(response);
        }

        public SyncInvoker<UpdateResourceGroupResponse> UpdateResourceGroupInvoker(UpdateResourceGroupRequest updateResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateResourceGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceGroupRequest);
            return new SyncInvoker<UpdateResourceGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateResourceGroupResponse>);
        }
        
    }
}