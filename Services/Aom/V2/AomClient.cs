using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Aom.V2.Model;

namespace HuaweiCloud.SDK.Aom.V2
{
    public partial class AomClient : Client
    {
        public static ClientBuilder<AomClient> NewBuilder()
        {
            return new ClientBuilder<AomClient>();
        }

        
        /// <summary>
        /// 新增告警行动规则
        ///
        /// 新增告警行动规则。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddActionRuleResponse AddActionRule(AddActionRuleRequest addActionRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addActionRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<AddActionRuleResponse>(response);
        }
        
        /// <summary>
        /// 添加阈值规则
        ///
        /// 该接口用于添加一条阈值规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddAlarmRuleResponse AddAlarmRule(AddAlarmRuleRequest addAlarmRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAlarmRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddAlarmRuleResponse>(response);
        }
        
        /// <summary>
        /// 新增一条事件类告警规则
        ///
        /// 新增一条事件类告警规则。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddEvent2alarmRuleResponse AddEvent2alarmRule(AddEvent2alarmRuleRequest addEvent2alarmRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/event2alarm-rule",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addEvent2alarmRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            AddEvent2alarmRuleResponse addEvent2alarmRuleResponse = JsonUtils.DeSerializeNull<AddEvent2alarmRuleResponse>(response);
            return addEvent2alarmRuleResponse;
        }
        
        /// <summary>
        /// 添加监控数据
        ///
        /// 该接口用于向服务端添加一条或多条监控数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddMetricDataResponse AddMetricData(AddMetricDataRequest addMetricDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ams/report/metricdata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addMetricDataRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddMetricDataResponse>(response);
        }
        
        /// <summary>
        /// 新增静默规则
        ///
        /// 新增静默规则。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddMuteRulesResponse AddMuteRules(AddMuteRulesRequest addMuteRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/mute-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addMuteRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<AddMuteRulesResponse>(response);
        }
        
        /// <summary>
        /// 添加或修改服务发现规则
        ///
        /// 该接口用于添加或修改一条或多条服务发现规则。同一projectid下可添加的规则上限为100条。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddOrUpdateServiceDiscoveryRulesResponse AddOrUpdateServiceDiscoveryRules(AddOrUpdateServiceDiscoveryRulesRequest addOrUpdateServiceDiscoveryRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/inv/servicediscoveryrules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addOrUpdateServiceDiscoveryRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<AddOrUpdateServiceDiscoveryRulesResponse>(response);
        }
        
        /// <summary>
        /// 统计事件告警信息
        ///
        /// 该接口用于分段统计指定条件下的事件、告警。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountEventsResponse CountEvents(CountEventsRequest countEventsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/events/statistic",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", countEventsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CountEventsResponse>(response);
        }
        
        /// <summary>
        /// 删除告警行动规则
        ///
        /// 删除告警行动规则。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteActionRuleResponse DeleteActionRule(DeleteActionRuleRequest deleteActionRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteActionRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteActionRuleResponse>(response);
        }
        
        /// <summary>
        /// 删除阈值规则
        ///
        /// 该接口用于删除阈值规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAlarmRuleResponse DeleteAlarmRule(DeleteAlarmRuleRequest deleteAlarmRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_rule_id" , deleteAlarmRuleRequest.AlarmRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules/{alarm_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeleteAlarmRuleResponse deleteAlarmRuleResponse = JsonUtils.DeSerializeNull<DeleteAlarmRuleResponse>(response);
            return deleteAlarmRuleResponse;
        }
        
        /// <summary>
        /// 批量删除阈值规则
        ///
        /// 批量删除阈值规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAlarmRulesResponse DeleteAlarmRules(DeleteAlarmRulesRequest deleteAlarmRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules/delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            DeleteAlarmRulesResponse deleteAlarmRulesResponse = JsonUtils.DeSerializeNull<DeleteAlarmRulesResponse>(response);
            return deleteAlarmRulesResponse;
        }
        
        /// <summary>
        /// 删除事件类告警规则
        ///
        /// 删除一条事件类告警规则。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteEvent2alarmRuleResponse DeleteEvent2alarmRule(DeleteEvent2alarmRuleRequest deleteEvent2alarmRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/event2alarm-rule",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEvent2alarmRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteEvent2alarmRuleResponse>(response);
        }
        
        /// <summary>
        /// 删除静默规则
        ///
        /// 删除静默规则。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteMuteRulesResponse DeleteMuteRules(DeleteMuteRulesRequest deleteMuteRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/mute-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMuteRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteMuteRulesResponse>(response);
        }
        
        /// <summary>
        /// 删除服务发现规则
        ///
        /// 该接口用于删除服务发现规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteserviceDiscoveryRulesResponse DeleteserviceDiscoveryRules(DeleteserviceDiscoveryRulesRequest deleteserviceDiscoveryRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/inv/servicediscoveryrules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteserviceDiscoveryRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteserviceDiscoveryRulesResponse>(response);
        }
        
        /// <summary>
        /// 获取告警行动规则列表
        ///
        /// 获取告警行动规则列表。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListActionRuleResponse ListActionRule(ListActionRuleRequest listActionRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listActionRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListActionRuleResponse>(response);
        }
        
        /// <summary>
        /// 查询阈值规则列表
        ///
        /// 该接口用于查询阈值规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAlarmRuleResponse ListAlarmRule(ListAlarmRuleRequest listAlarmRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmRuleResponse>(response);
        }
        
        /// <summary>
        /// 查询事件类告警规则列表
        ///
        /// 查询事件类告警规则列表。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEvent2alarmRuleResponse ListEvent2alarmRule(ListEvent2alarmRuleRequest listEvent2alarmRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/event2alarm-rule",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEvent2alarmRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListEvent2alarmRuleResponse listEvent2alarmRuleResponse = JsonUtils.DeSerializeNull<ListEvent2alarmRuleResponse>(response);
            listEvent2alarmRuleResponse.Body = JsonUtils.DeSerializeList<Event2alarmRuleBody>(response);
            return listEvent2alarmRuleResponse;
        }
        
        /// <summary>
        /// 查询事件告警信息
        ///
        /// 该接口用于查询对应用户的事件、告警。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEventsResponse ListEvents(ListEventsRequest listEventsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/events",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListEventsResponse>(response);
        }
        
        /// <summary>
        /// 查询日志
        ///
        /// 该接口用于查询不同维度(例如集群、IP、应用等)下的日志内容，支持分页查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLogItemsResponse ListLogItems(ListLogItemsRequest listLogItemsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/als/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogItemsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListLogItemsResponse>(response);
        }
        
        /// <summary>
        /// 查询指标
        ///
        /// 该接口用于查询系统当前可监控的指标列表，可以指定指标命名空间、指标名称、维度、所属资源的编号（格式为：resType_resId），分页查询的起始位置和返回的最大记录条数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMetricItemsResponse ListMetricItems(ListMetricItemsRequest listMetricItemsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ams/metrics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricItemsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListMetricItemsResponse>(response);
        }
        
        /// <summary>
        /// 获取静默规则列表
        ///
        /// 获取静默规则列表。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMuteRuleResponse ListMuteRule(ListMuteRuleRequest listMuteRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/mute-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMuteRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListMuteRuleResponse listMuteRuleResponse = JsonUtils.DeSerializeNull<ListMuteRuleResponse>(response);
            listMuteRuleResponse.Body = JsonUtils.DeSerializeList<MuteRule>(response);
            return listMuteRuleResponse;
        }
        
        /// <summary>
        /// 获取告警发送结果
        ///
        /// 获取告警发送结果。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNotifiedHistoriesResponse ListNotifiedHistories(ListNotifiedHistoriesRequest listNotifiedHistoriesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-notified-histories",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotifiedHistoriesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListNotifiedHistoriesResponse>(response);
        }
        
        /// <summary>
        /// 查询时序数据
        ///
        /// 该接口用于查询指定时间范围内的监控时序数据，可以通过参数指定需要查询的数据维度，数据周期等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSampleResponse ListSample(ListSampleRequest listSampleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/samples",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSampleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListSampleResponse>(response);
        }
        
        /// <summary>
        /// 查询时间序列
        ///
        /// 该接口用于查询系统当前可监控的时间序列列表，可以指定时间序列命名空间、名称、维度、所属资源的编号（格式为：resType_resId），分页查询的起始位置和返回的最大记录条数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSeriesResponse ListSeries(ListSeriesRequest listSeriesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/series",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSeriesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListSeriesResponse>(response);
        }
        
        /// <summary>
        /// 查询系统中已有服务发现规则
        ///
        /// 该接口用于查询系统当前已存在的服务发现规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServiceDiscoveryRulesResponse ListServiceDiscoveryRules(ListServiceDiscoveryRulesRequest listServiceDiscoveryRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/inv/servicediscoveryrules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceDiscoveryRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListServiceDiscoveryRulesResponse>(response);
        }
        
        /// <summary>
        /// 上报事件告警信息
        ///
        /// 该接口用于上报对应用户的事件、告警。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public PushEventsResponse PushEvents(PushEventsRequest pushEventsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/push/events",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", pushEventsRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<PushEventsResponse>(response);
        }
        
        /// <summary>
        /// 通过规则名称获取告警行动规则
        ///
        /// 通过规则名称获取告警行动规则。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowActionRuleResponse ShowActionRule(ShowActionRuleRequest showActionRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_name" , showActionRuleRequest.RuleName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules/{rule_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActionRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowActionRuleResponse>(response);
        }
        
        /// <summary>
        /// 查询单条阈值规则
        ///
        /// 该接口用于查询单条阈值规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAlarmRuleResponse ShowAlarmRule(ShowAlarmRuleRequest showAlarmRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_rule_id" , showAlarmRuleRequest.AlarmRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules/{alarm_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAlarmRuleResponse>(response);
        }
        
        /// <summary>
        /// 查询监控数据
        ///
        /// 该接口用于查询指定时间范围内指标的监控数据，可以通过参数指定需要查询的数据维度，数据周期等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMetricsDataResponse ShowMetricsData(ShowMetricsDataRequest showMetricsDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ams/metricdata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetricsDataRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ShowMetricsDataResponse>(response);
        }
        
        /// <summary>
        /// 修改告警行动规则
        ///
        /// 修改告警行动规则。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateActionRuleResponse UpdateActionRule(UpdateActionRuleRequest updateActionRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateActionRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateActionRuleResponse>(response);
        }
        
        /// <summary>
        /// 修改阈值规则
        ///
        /// 该接口用于修改一条阈值规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAlarmRuleResponse UpdateAlarmRule(UpdateAlarmRuleRequest updateAlarmRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAlarmRuleResponse>(response);
        }
        
        /// <summary>
        /// 更新事件类告警规则
        ///
        /// 更新事件类告警规则。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateEventRuleResponse UpdateEventRule(UpdateEventRuleRequest updateEventRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/event2alarm-rule",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEventRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            UpdateEventRuleResponse updateEventRuleResponse = JsonUtils.DeSerializeNull<UpdateEventRuleResponse>(response);
            return updateEventRuleResponse;
        }
        
        /// <summary>
        /// 修改静默规则
        ///
        /// 修改静默规则。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMuteRuleResponse UpdateMuteRule(UpdateMuteRuleRequest updateMuteRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/mute-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMuteRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateMuteRuleResponse>(response);
        }
        
        /// <summary>
        /// 新增Prometheus实例数据源
        ///
        /// 该接口用于新增Prometheus实例数据源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePromInstanceResponse CreatePromInstance(CreatePromInstanceRequest createPromInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/prometheus",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPromInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePromInstanceResponse>(response);
        }
        
        /// <summary>
        /// 创建预汇聚规则
        ///
        /// 该接口用于创建预汇聚规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRecordingRuleResponse CreateRecordingRule(CreateRecordingRuleRequest createRecordingRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("prometheus_instance" , createRecordingRuleRequest.PrometheusInstance.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{prometheus_instance}/aom/api/v1/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordingRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            CreateRecordingRuleResponse createRecordingRuleResponse = JsonUtils.DeSerializeNull<CreateRecordingRuleResponse>(response);
            return createRecordingRuleResponse;
        }
        
        /// <summary>
        /// 卸载托管Prometheus
        ///
        /// 该接口用于卸载托管Prometheus
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePromInstanceResponse DeletePromInstance(DeletePromInstanceRequest deletePromInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/prometheus",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePromInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeletePromInstanceResponse deletePromInstanceResponse = JsonUtils.DeSerializeNull<DeletePromInstanceResponse>(response);
            return deletePromInstanceResponse;
        }
        
        /// <summary>
        /// 获取Prometheus监控所需Token-access code
        ///
        /// 该接口用于获取Prometheus监控所需Token-access code
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccessCodeResponse ListAccessCode(ListAccessCodeRequest listAccessCodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/access-code",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessCodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAccessCodeResponse>(response);
        }
        
        /// <summary>
        /// 查询集群Agent信息
        ///
        /// 该接口用于查询集群Agent信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAgentsResponse ListAgents(ListAgentsRequest listAgentsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , listAgentsRequest.ClusterId.ToString());
            urlParam.Add("namespace" , listAgentsRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{cluster_id}/{namespace}/agents",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListAgentsResponse listAgentsResponse = JsonUtils.DeSerializeNull<ListAgentsResponse>(response);
            return listAgentsResponse;
        }
        
        /// <summary>
        /// 瞬时数据查询
        ///
        /// 该接口用于查询PromQL(Prometheus Query Language)在特定时间点下的计算结果。（注：接口目前开放的region为：北京四、上海一和广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstantQueryAomPromGetResponse ListInstantQueryAomPromGet(ListInstantQueryAomPromGetRequest listInstantQueryAomPromGetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/query",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstantQueryAomPromGetRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListInstantQueryAomPromGetResponse>(response);
        }
        
        /// <summary>
        /// 瞬时数据查询
        ///
        /// 该接口用于查询PromQL(Prometheus Query Language) 在特定时间点下的计算结果。（注：接口目前开放的region为：北京四、上海一和广州）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstantQueryAomPromPostResponse ListInstantQueryAomPromPost(ListInstantQueryAomPromPostRequest listInstantQueryAomPromPostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/query",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstantQueryAomPromPostRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListInstantQueryAomPromPostResponse>(response);
        }
        
        /// <summary>
        /// 查询标签值
        ///
        /// 该接口用于查询带有指定标签的时间序列列表。（注：接口目前开放的region为：北京四、上海一和广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLabelValuesAomPromGetResponse ListLabelValuesAomPromGet(ListLabelValuesAomPromGetRequest listLabelValuesAomPromGetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("label_name" , listLabelValuesAomPromGetRequest.LabelName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/label/{label_name}/values",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLabelValuesAomPromGetRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListLabelValuesAomPromGetResponse>(response);
        }
        
        /// <summary>
        /// 获取标签名列表
        ///
        /// 该接口用于获取标签名列表。（注：接口目前开放的region为：北京四、上海一和广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLabelsAomPromGetResponse ListLabelsAomPromGet(ListLabelsAomPromGetRequest listLabelsAomPromGetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/labels",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLabelsAomPromGetRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListLabelsAomPromGetResponse>(response);
        }
        
        /// <summary>
        /// 获取标签名列表
        ///
        /// 该接口用于获取标签名列表。（注：接口目前开放的region为：北京四、上海一和广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLabelsAomPromPostResponse ListLabelsAomPromPost(ListLabelsAomPromPostRequest listLabelsAomPromPostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/labels",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLabelsAomPromPostRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListLabelsAomPromPostResponse>(response);
        }
        
        /// <summary>
        /// 元数据查询
        ///
        /// 该接口用于查询序列及序列标签的元数据。（注：接口目前开放的region为：北京四、上海一和广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMetadataAomPromGetResponse ListMetadataAomPromGet(ListMetadataAomPromGetRequest listMetadataAomPromGetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetadataAomPromGetRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListMetadataAomPromGetResponse>(response);
        }
        
        /// <summary>
        /// 是否开通aom2.0
        ///
        /// 该接口用于查询用户是否已经完成aom2.0授权
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPermissionsResponse ListPermissions(ListPermissionsRequest listPermissionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/auth/grant",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListPermissionsResponse listPermissionsResponse = JsonUtils.DeSerializeNull<ListPermissionsResponse>(response);
            listPermissionsResponse.Body = JsonUtils.DeSerializeMap<string, AuthModel>(response);
            return listPermissionsResponse;
        }
        
        /// <summary>
        /// 获取所有正常实例
        ///
        /// 该接口用于获取所有正常prometheus实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPromInstanceResponse ListPromInstance(ListPromInstanceRequest listPromInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/prometheus",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPromInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPromInstanceResponse>(response);
        }
        
        /// <summary>
        /// 区间数据查询
        ///
        /// 该接口用于查询PromQL(Prometheus Query Language)在一段时间返回内的计算结果。（注：接口目前开放的region为：北京四、上海一和广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRangeQueryAomPromGetResponse ListRangeQueryAomPromGet(ListRangeQueryAomPromGetRequest listRangeQueryAomPromGetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/query_range",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRangeQueryAomPromGetRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRangeQueryAomPromGetResponse>(response);
        }
        
        /// <summary>
        /// 区间数据查询
        ///
        /// 该接口用于查询PromQL(Prometheus Query Language)在一段时间返回内的计算结果。（注：接口目前开放的region为：北京四、上海一和广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRangeQueryAomPromPostResponse ListRangeQueryAomPromPost(ListRangeQueryAomPromPostRequest listRangeQueryAomPromPostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/query_range",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRangeQueryAomPromPostRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListRangeQueryAomPromPostResponse>(response);
        }
        
    }
}