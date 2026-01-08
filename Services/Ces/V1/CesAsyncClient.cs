using System;
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
        ///
        /// 批量查询指定时间范围内指定指标的指定粒度的监控数据，目前最多支持500指标的批量查询。 对于不同的period取值和查询的指标数量，默认的最大查询区间(to-from)不同。 规则为\&quot;指标数量*(to-from)/监控周期&lt;&#x3D;3000\&quot;，若超出阈值，会自动调整from以满足规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchListMetricDataResponse> BatchListMetricDataAsync(BatchListMetricDataRequest batchListMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/batch-query-metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListMetricDataRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchListMetricDataResponse>(response);
        }

        public AsyncInvoker<BatchListMetricDataResponse> BatchListMetricDataAsyncInvoker(BatchListMetricDataRequest batchListMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/batch-query-metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListMetricDataRequest);
            return new AsyncInvoker<BatchListMetricDataResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchListMetricDataResponse>);
        }
        
        /// <summary>
        /// 创建告警规则（V1）
        ///
        /// 创建一条告警规则。创建告警规则V1接口只支持配置单资源单策略规则，建议使用“[创建告警规则（推荐）](CreateAlarmRules.xml)”与前端功能配套使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAlarmResponse> CreateAlarmAsync(CreateAlarmRequest createAlarmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAlarmResponse>(response);
        }

        public AsyncInvoker<CreateAlarmResponse> CreateAlarmAsyncInvoker(CreateAlarmRequest createAlarmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmRequest);
            return new AsyncInvoker<CreateAlarmResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAlarmResponse>);
        }
        
        /// <summary>
        /// 创建自定义告警模板
        ///
        /// 创建自定义告警模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAlarmTemplateResponse> CreateAlarmTemplateAsync(CreateAlarmTemplateRequest createAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAlarmTemplateResponse>(response);
        }

        public AsyncInvoker<CreateAlarmTemplateResponse> CreateAlarmTemplateAsyncInvoker(CreateAlarmTemplateRequest createAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmTemplateRequest);
            return new AsyncInvoker<CreateAlarmTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAlarmTemplateResponse>);
        }
        
        /// <summary>
        /// 上报事件
        ///
        /// 上报自定义事件。事件的time、project_id、event_source、event_name、event_type、sub_event_type、event_state、event_level、event_user、resource_id、resource_name字段相同时，则视为同一条事件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateEventsResponse> CreateEventsAsync(CreateEventsRequest createEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEventsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var createEventsResponse = JsonUtils.DeSerializeNull<CreateEventsResponse>(response);
            createEventsResponse.Body = JsonUtils.DeSerializeList<Event>(response);
            return createEventsResponse;
        }

        public AsyncInvoker<CreateEventsResponse> CreateEventsAsyncInvoker(CreateEventsRequest createEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEventsRequest);
            return new AsyncInvoker<CreateEventsResponse>(this, "POST", request, response =>
            {
                var createEventsResponse = JsonUtils.DeSerializeNull<CreateEventsResponse>(response);
                createEventsResponse.Body = JsonUtils.DeSerializeList<Event>(response);
                return createEventsResponse;
            });
        }
        
        /// <summary>
        /// 添加监控数据
        ///
        /// 添加一条或多条指标监控数据。约束与限制：
        /// 1. 单次POST请求消息体大小不能超过512KB，否则请求会被服务端拒绝。
        /// 2. POST请求发送周期应小于最小聚合周期，否则会出现聚合数据点不连续。例如：聚合周期为5分钟，发送周期为7分钟，则5分钟情况的聚合数据会出现每10分钟才出现一个点。
        /// 3. POST请求体中数据收集时间（collect_time）的值必须从当前时间的前三天到当前时间后的十分钟之内某一时间，如果不在这个范围内，则不允许插入指标数据。
        /// 4. 如果指标上报时间（即调用指标上报接口的时间）与数据收集时间（collect_time）之间的延迟超过10分钟，CES在聚合数据时会丢弃此指标数据。您只能查看近2天的原始指标数据，聚合数据中不会显示这些延迟上报的指标。例如，14:20:00调用CES接口上报数据，请求体中的collect_time字段为14:05:00，表示延迟上报了15分钟。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMetricDataResponse> CreateMetricDataAsync(CreateMetricDataRequest createMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMetricDataRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateMetricDataResponse>(response);
        }

        public AsyncInvoker<CreateMetricDataResponse> CreateMetricDataAsyncInvoker(CreateMetricDataRequest createMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMetricDataRequest);
            return new AsyncInvoker<CreateMetricDataResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateMetricDataResponse>);
        }
        
        /// <summary>
        /// 创建资源分组
        ///
        /// 创建资源分组，资源分组支持将各类资源按照业务集中进行分组管理，可以从分组角度查看监控与告警信息，以提升运维效率。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateResourceGroupResponse> CreateResourceGroupAsync(CreateResourceGroupRequest createResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateResourceGroupResponse>(response);
        }

        public AsyncInvoker<CreateResourceGroupResponse> CreateResourceGroupAsyncInvoker(CreateResourceGroupRequest createResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceGroupRequest);
            return new AsyncInvoker<CreateResourceGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateResourceGroupResponse>);
        }
        
        /// <summary>
        /// 删除告警规则
        ///
        /// 删除一条告警规则。
        /// 告警规则V1接口只支持配置单资源单策略规则，建议使用[批量删除告警规则](BatchDeleteAlarmRules.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAlarmResponse> DeleteAlarmAsync(DeleteAlarmRequest deleteAlarmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAlarmRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAlarmResponse>(response);
        }

        public AsyncInvoker<DeleteAlarmResponse> DeleteAlarmAsyncInvoker(DeleteAlarmRequest deleteAlarmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAlarmRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRequest);
            return new AsyncInvoker<DeleteAlarmResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAlarmResponse>);
        }
        
        /// <summary>
        /// 删除自定义告警模板
        ///
        /// 根据ID删除自定义告警模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAlarmTemplateResponse> DeleteAlarmTemplateAsync(DeleteAlarmTemplateRequest deleteAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAlarmTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmTemplateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAlarmTemplateResponse>(response);
        }

        public AsyncInvoker<DeleteAlarmTemplateResponse> DeleteAlarmTemplateAsyncInvoker(DeleteAlarmTemplateRequest deleteAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAlarmTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmTemplateRequest);
            return new AsyncInvoker<DeleteAlarmTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAlarmTemplateResponse>);
        }
        
        /// <summary>
        /// 删除资源分组
        ///
        /// 删除一条资源分组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteResourceGroupResponse> DeleteResourceGroupAsync(DeleteResourceGroupRequest deleteResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteResourceGroupResponse>(response);
        }

        public AsyncInvoker<DeleteResourceGroupResponse> DeleteResourceGroupAsyncInvoker(DeleteResourceGroupRequest deleteResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceGroupRequest);
            return new AsyncInvoker<DeleteResourceGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteResourceGroupResponse>);
        }
        
        /// <summary>
        /// 查询告警历史
        ///
        /// 查询告警历史列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAlarmHistoriesResponse> ListAlarmHistoriesAsync(ListAlarmHistoriesRequest listAlarmHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmHistoriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmHistoriesResponse>(response);
        }

        public AsyncInvoker<ListAlarmHistoriesResponse> ListAlarmHistoriesAsyncInvoker(ListAlarmHistoriesRequest listAlarmHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmHistoriesRequest);
            return new AsyncInvoker<ListAlarmHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmHistoriesResponse>);
        }
        
        /// <summary>
        /// 查询自定义告警模板列表
        ///
        /// 查询自定义告警模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAlarmTemplatesResponse> ListAlarmTemplatesAsync(ListAlarmTemplatesRequest listAlarmTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmTemplatesResponse>(response);
        }

        public AsyncInvoker<ListAlarmTemplatesResponse> ListAlarmTemplatesAsyncInvoker(ListAlarmTemplatesRequest listAlarmTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTemplatesRequest);
            return new AsyncInvoker<ListAlarmTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询告警规则列表（V1）
        ///
        /// 查询告警规则列表，可以指定分页条件限制结果数量，可以指定排序规则。如果用本接口去查询多资源多策略的告警规则，也只能返回告警规则的某个策略，建议使用“[查询告警规则列表（推荐）](ListAlarmRules.xml)”与前端功能配套使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAlarmsResponse> ListAlarmsAsync(ListAlarmsRequest listAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmsResponse>(response);
        }

        public AsyncInvoker<ListAlarmsResponse> ListAlarmsAsyncInvoker(ListAlarmsRequest listAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmsRequest);
            return new AsyncInvoker<ListAlarmsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmsResponse>);
        }
        
        /// <summary>
        /// 查询某一事件监控详情
        ///
        /// 根据事件监控名称，查询该事件发生的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEventDetailResponse> ListEventDetailAsync(ListEventDetailRequest listEventDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEventDetailRequest.EventName, out var valueOfEventName)) urlParam.Add("event_name", valueOfEventName);
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/event/{event_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEventDetailResponse>(response);
        }

        public AsyncInvoker<ListEventDetailResponse> ListEventDetailAsyncInvoker(ListEventDetailRequest listEventDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEventDetailRequest.EventName, out var valueOfEventName)) urlParam.Add("event_name", valueOfEventName);
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/event/{event_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventDetailRequest);
            return new AsyncInvoker<ListEventDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEventDetailResponse>);
        }
        
        /// <summary>
        /// 查询事件监控列表
        ///
        /// 查询事件监控列表，包括系统事件和自定义事件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEventsResponse> ListEventsAsync(ListEventsRequest listEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEventsResponse>(response);
        }

        public AsyncInvoker<ListEventsResponse> ListEventsAsyncInvoker(ListEventsRequest listEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventsRequest);
            return new AsyncInvoker<ListEventsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEventsResponse>);
        }
        
        /// <summary>
        /// 查询指标列表
        ///
        /// 查询系统当前可监控指标列表，可以指定指标命名空间、指标名称、维度、排序方式，起始记录和最大记录条数过滤查询结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMetricsResponse> ListMetricsAsync(ListMetricsRequest listMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metrics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMetricsResponse>(response);
        }

        public AsyncInvoker<ListMetricsResponse> ListMetricsAsyncInvoker(ListMetricsRequest listMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metrics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricsRequest);
            return new AsyncInvoker<ListMetricsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMetricsResponse>);
        }
        
        /// <summary>
        /// 查询所有资源分组
        ///
        /// 查询所创建的所有资源分组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceGroupResponse> ListResourceGroupAsync(ListResourceGroupRequest listResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListResourceGroupResponse>(response);
        }

        public AsyncInvoker<ListResourceGroupResponse> ListResourceGroupAsyncInvoker(ListResourceGroupRequest listResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceGroupRequest);
            return new AsyncInvoker<ListResourceGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceGroupResponse>);
        }
        
        /// <summary>
        /// 查询单条告警规则信息
        ///
        /// 根据告警ID查询告警规则信息。告警规则V1接口只支持配置单资源单策略规则，建议使用“[查询告警规则列表（推荐）](ListAlarmRules.xml)”、“[查询告警规则资源列表](ListAlarmRuleResources.xml)”与前端功能配套使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAlarmResponse> ShowAlarmAsync(ShowAlarmRequest showAlarmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAlarmRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAlarmResponse>(response);
        }

        public AsyncInvoker<ShowAlarmResponse> ShowAlarmAsyncInvoker(ShowAlarmRequest showAlarmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAlarmRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmRequest);
            return new AsyncInvoker<ShowAlarmResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAlarmResponse>);
        }
        
        /// <summary>
        /// 查询主机配置数据
        ///
        /// 查询指定时间范围指定事件类型的主机配置数据，可以通过参数指定需要查询的数据维度。注意：该接口提供给HANA场景下SAP Monitor查询主机配置数据，其他场景下查不到主机配置数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEventDataResponse> ShowEventDataAsync(ShowEventDataRequest showEventDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/event-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEventDataRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowEventDataResponse>(response);
        }

        public AsyncInvoker<ShowEventDataResponse> ShowEventDataAsyncInvoker(ShowEventDataRequest showEventDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/event-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEventDataRequest);
            return new AsyncInvoker<ShowEventDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEventDataResponse>);
        }
        
        /// <summary>
        /// 查询监控数据
        ///
        /// 查询指定时间范围指定指标的指定粒度的监控数据，可以通过参数指定需要查询的数据维度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMetricDataResponse> ShowMetricDataAsync(ShowMetricDataRequest showMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetricDataRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMetricDataResponse>(response);
        }

        public AsyncInvoker<ShowMetricDataResponse> ShowMetricDataAsyncInvoker(ShowMetricDataRequest showMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetricDataRequest);
            return new AsyncInvoker<ShowMetricDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMetricDataResponse>);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// 查询用户可以创建的资源配额总数及当前使用量，当前仅有告警规则一种资源类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQuotasResponse> ShowQuotasAsync(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }

        public AsyncInvoker<ShowQuotasResponse> ShowQuotasAsyncInvoker(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            return new AsyncInvoker<ShowQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotasResponse>);
        }
        
        /// <summary>
        /// 查询资源分组下的资源
        ///
        /// 根据资源分组ID查询资源分组下的资源。此接口已过时，建议使用v2接口 “[查询资源分组下指定服务类别特定维度的资源列表](ListResourceGroupsServicesResources.xml)”
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceGroupResponse> ShowResourceGroupAsync(ShowResourceGroupRequest showResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceGroupResponse>(response);
        }

        public AsyncInvoker<ShowResourceGroupResponse> ShowResourceGroupAsyncInvoker(ShowResourceGroupRequest showResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceGroupRequest);
            return new AsyncInvoker<ShowResourceGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceGroupResponse>);
        }
        
        /// <summary>
        /// 修改告警规则
        ///
        /// 修改告警规则。
        /// 告警规则V1接口只支持配置单资源单策略规则，建议使用[批量增加告警规则资源](AddAlarmRuleResources.xml)、[批量删除告警规则资源](DeleteAlarmRuleResources.xml)和[修改告警规则策略(全量修改)](UpdateAlarmRulePolicies.xml)与前端功能配套使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAlarmResponse> UpdateAlarmAsync(UpdateAlarmRequest updateAlarmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAlarmRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAlarmResponse>(response);
        }

        public AsyncInvoker<UpdateAlarmResponse> UpdateAlarmAsyncInvoker(UpdateAlarmRequest updateAlarmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAlarmRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmRequest);
            return new AsyncInvoker<UpdateAlarmResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAlarmResponse>);
        }
        
        /// <summary>
        /// 启停告警规则
        ///
        /// 启动或停止一条告警规则。
        /// 告警规则V1接口只支持配置单资源单策略规则，建议使用[批量启停告警规则](BatchEnableAlarmRules.xml)与前端功能配套使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAlarmActionResponse> UpdateAlarmActionAsync(UpdateAlarmActionRequest updateAlarmActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAlarmActionRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmActionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAlarmActionResponse>(response);
        }

        public AsyncInvoker<UpdateAlarmActionResponse> UpdateAlarmActionAsyncInvoker(UpdateAlarmActionRequest updateAlarmActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAlarmActionRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmActionRequest);
            return new AsyncInvoker<UpdateAlarmActionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAlarmActionResponse>);
        }
        
        /// <summary>
        /// 更新自定义告警模板
        ///
        /// 更新自定义告警模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAlarmTemplateResponse> UpdateAlarmTemplateAsync(UpdateAlarmTemplateRequest updateAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAlarmTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmTemplateRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAlarmTemplateResponse>(response);
        }

        public AsyncInvoker<UpdateAlarmTemplateResponse> UpdateAlarmTemplateAsyncInvoker(UpdateAlarmTemplateRequest updateAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAlarmTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmTemplateRequest);
            return new AsyncInvoker<UpdateAlarmTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAlarmTemplateResponse>);
        }
        
        /// <summary>
        /// 更新资源分组
        ///
        /// 更新资源分组，资源分组支持将各类资源按照业务集中进行分组管理，可以从分组角度查看监控与告警信息，以提升运维效率。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateResourceGroupResponse> UpdateResourceGroupAsync(UpdateResourceGroupRequest updateResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateResourceGroupResponse>(response);
        }

        public AsyncInvoker<UpdateResourceGroupResponse> UpdateResourceGroupAsyncInvoker(UpdateResourceGroupRequest updateResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceGroupRequest);
            return new AsyncInvoker<UpdateResourceGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateResourceGroupResponse>);
        }
        
    }
}