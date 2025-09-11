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
        /// 新增告警行动规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddActionRuleResponse AddActionRule(AddActionRuleRequest addActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addActionRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AddActionRuleResponse>(response);
        }

        public SyncInvoker<AddActionRuleResponse> AddActionRuleInvoker(AddActionRuleRequest addActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addActionRuleRequest);
            return new SyncInvoker<AddActionRuleResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddActionRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAlarmRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddAlarmRuleResponse>(response);
        }

        public SyncInvoker<AddAlarmRuleResponse> AddAlarmRuleInvoker(AddAlarmRuleRequest addAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAlarmRuleRequest);
            return new SyncInvoker<AddAlarmRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 新增一条事件类告警规则
        ///
        /// 新增一条事件类告警规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddEvent2alarmRuleResponse AddEvent2alarmRule(AddEvent2alarmRuleRequest addEvent2alarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/event2alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addEvent2alarmRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AddEvent2alarmRuleResponse>(response);
        }

        public SyncInvoker<AddEvent2alarmRuleResponse> AddEvent2alarmRuleInvoker(AddEvent2alarmRuleRequest addEvent2alarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/event2alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addEvent2alarmRuleRequest);
            return new SyncInvoker<AddEvent2alarmRuleResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddEvent2alarmRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ams/report/metricdata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addMetricDataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddMetricDataResponse>(response);
        }

        public SyncInvoker<AddMetricDataResponse> AddMetricDataInvoker(AddMetricDataRequest addMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ams/report/metricdata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addMetricDataRequest);
            return new SyncInvoker<AddMetricDataResponse>(this, "POST", request, JsonUtils.DeSerialize<AddMetricDataResponse>);
        }
        
        /// <summary>
        /// 新增静默规则
        ///
        /// 新增静默规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddMuteRulesResponse AddMuteRules(AddMuteRulesRequest addMuteRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/mute-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addMuteRulesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AddMuteRulesResponse>(response);
        }

        public SyncInvoker<AddMuteRulesResponse> AddMuteRulesInvoker(AddMuteRulesRequest addMuteRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/mute-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addMuteRulesRequest);
            return new SyncInvoker<AddMuteRulesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddMuteRulesResponse>);
        }
        
        /// <summary>
        /// 添加或修改指标类或事件类告警规则
        ///
        /// 添加或修改AOM2.0指标类或事件类告警规则。(注：接口目前开放的region为：华东-上海一)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddOrUpdateMetricOrEventAlarmRuleResponse AddOrUpdateMetricOrEventAlarmRule(AddOrUpdateMetricOrEventAlarmRuleRequest addOrUpdateMetricOrEventAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addOrUpdateMetricOrEventAlarmRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddOrUpdateMetricOrEventAlarmRuleResponse>(response);
        }

        public SyncInvoker<AddOrUpdateMetricOrEventAlarmRuleResponse> AddOrUpdateMetricOrEventAlarmRuleInvoker(AddOrUpdateMetricOrEventAlarmRuleRequest addOrUpdateMetricOrEventAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addOrUpdateMetricOrEventAlarmRuleRequest);
            return new SyncInvoker<AddOrUpdateMetricOrEventAlarmRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<AddOrUpdateMetricOrEventAlarmRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/inv/servicediscoveryrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addOrUpdateServiceDiscoveryRulesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<AddOrUpdateServiceDiscoveryRulesResponse>(response);
        }

        public SyncInvoker<AddOrUpdateServiceDiscoveryRulesResponse> AddOrUpdateServiceDiscoveryRulesInvoker(AddOrUpdateServiceDiscoveryRulesRequest addOrUpdateServiceDiscoveryRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/inv/servicediscoveryrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addOrUpdateServiceDiscoveryRulesRequest);
            return new SyncInvoker<AddOrUpdateServiceDiscoveryRulesResponse>(this, "PUT", request, JsonUtils.DeSerialize<AddOrUpdateServiceDiscoveryRulesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/events/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countEventsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CountEventsResponse>(response);
        }

        public SyncInvoker<CountEventsResponse> CountEventsInvoker(CountEventsRequest countEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/events/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countEventsRequest);
            return new SyncInvoker<CountEventsResponse>(this, "POST", request, JsonUtils.DeSerialize<CountEventsResponse>);
        }
        
        /// <summary>
        /// 删除告警行动规则
        ///
        /// 删除告警行动规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteActionRuleResponse DeleteActionRule(DeleteActionRuleRequest deleteActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteActionRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteActionRuleResponse>(response);
        }

        public SyncInvoker<DeleteActionRuleResponse> DeleteActionRuleInvoker(DeleteActionRuleRequest deleteActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteActionRuleRequest);
            return new SyncInvoker<DeleteActionRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteActionRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAlarmRuleRequest.AlarmRuleId, out var valueOfAlarmRuleId)) urlParam.Add("alarm_rule_id", valueOfAlarmRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules/{alarm_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAlarmRuleResponse>(response);
        }

        public SyncInvoker<DeleteAlarmRuleResponse> DeleteAlarmRuleInvoker(DeleteAlarmRuleRequest deleteAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAlarmRuleRequest.AlarmRuleId, out var valueOfAlarmRuleId)) urlParam.Add("alarm_rule_id", valueOfAlarmRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules/{alarm_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRuleRequest);
            return new SyncInvoker<DeleteAlarmRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 批量删除阈值规则
        ///
        /// 该接口用于批量删除阈值规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAlarmRulesResponse DeleteAlarmRules(DeleteAlarmRulesRequest deleteAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRulesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteAlarmRulesResponse>(response);
        }

        public SyncInvoker<DeleteAlarmRulesResponse> DeleteAlarmRulesInvoker(DeleteAlarmRulesRequest deleteAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRulesRequest);
            return new SyncInvoker<DeleteAlarmRulesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteAlarmRulesResponse>);
        }
        
        /// <summary>
        /// 删除事件类告警规则
        ///
        /// 删除一条事件类告警规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteEvent2alarmRuleResponse DeleteEvent2alarmRule(DeleteEvent2alarmRuleRequest deleteEvent2alarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/event2alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEvent2alarmRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteEvent2alarmRuleResponse>(response);
        }

        public SyncInvoker<DeleteEvent2alarmRuleResponse> DeleteEvent2alarmRuleInvoker(DeleteEvent2alarmRuleRequest deleteEvent2alarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/event2alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEvent2alarmRuleRequest);
            return new SyncInvoker<DeleteEvent2alarmRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteEvent2alarmRuleResponse>);
        }
        
        /// <summary>
        /// 删除指标类或事件类告警规则
        ///
        /// 删除AOM2.0指标类或事件类告警规则。(注：接口目前开放的region为：华东-上海一)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteMetricOrEventAlarmRuleResponse DeleteMetricOrEventAlarmRule(DeleteMetricOrEventAlarmRuleRequest deleteMetricOrEventAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMetricOrEventAlarmRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteMetricOrEventAlarmRuleResponse>(response);
        }

        public SyncInvoker<DeleteMetricOrEventAlarmRuleResponse> DeleteMetricOrEventAlarmRuleInvoker(DeleteMetricOrEventAlarmRuleRequest deleteMetricOrEventAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMetricOrEventAlarmRuleRequest);
            return new SyncInvoker<DeleteMetricOrEventAlarmRuleResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteMetricOrEventAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 删除静默规则
        ///
        /// 删除静默规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteMuteRulesResponse DeleteMuteRules(DeleteMuteRulesRequest deleteMuteRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/mute-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMuteRulesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMuteRulesResponse>(response);
        }

        public SyncInvoker<DeleteMuteRulesResponse> DeleteMuteRulesInvoker(DeleteMuteRulesRequest deleteMuteRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/mute-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMuteRulesRequest);
            return new SyncInvoker<DeleteMuteRulesResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMuteRulesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/inv/servicediscoveryrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteserviceDiscoveryRulesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteserviceDiscoveryRulesResponse>(response);
        }

        public SyncInvoker<DeleteserviceDiscoveryRulesResponse> DeleteserviceDiscoveryRulesInvoker(DeleteserviceDiscoveryRulesRequest deleteserviceDiscoveryRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/inv/servicediscoveryrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteserviceDiscoveryRulesRequest);
            return new SyncInvoker<DeleteserviceDiscoveryRulesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteserviceDiscoveryRulesResponse>);
        }
        
        /// <summary>
        /// 获取告警行动规则列表
        ///
        /// 获取告警行动规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListActionRuleResponse ListActionRule(ListActionRuleRequest listActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listActionRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListActionRuleResponse>(response);
        }

        public SyncInvoker<ListActionRuleResponse> ListActionRuleInvoker(ListActionRuleRequest listActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listActionRuleRequest);
            return new SyncInvoker<ListActionRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListActionRuleResponse>);
        }
        
        /// <summary>
        /// 查询主机安装的ICAgent信息
        ///
        /// 该接口用于查询集群主机或用户自定义主机安装的ICAgent信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAgentsResponse ListAgents(ListAgentsRequest listAgentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAgentsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(listAgentsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{cluster_id}/{namespace}/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerializeNull<ListAgentsResponse>(response);
        }

        public SyncInvoker<ListAgentsResponse> ListAgentsInvoker(ListAgentsRequest listAgentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAgentsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(listAgentsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{cluster_id}/{namespace}/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentsRequest);
            return new SyncInvoker<ListAgentsResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ListAgentsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmRuleResponse>(response);
        }

        public SyncInvoker<ListAlarmRuleResponse> ListAlarmRuleInvoker(ListAlarmRuleRequest listAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRuleRequest);
            return new SyncInvoker<ListAlarmRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 查询事件类告警规则列表
        ///
        /// 查询事件类告警规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEvent2alarmRuleResponse ListEvent2alarmRule(ListEvent2alarmRuleRequest listEvent2alarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/event2alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEvent2alarmRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            var listEvent2alarmRuleResponse = JsonUtils.DeSerializeNull<ListEvent2alarmRuleResponse>(response);
            listEvent2alarmRuleResponse.Body = JsonUtils.DeSerializeList<Event2alarmRuleBody>(response);
            return listEvent2alarmRuleResponse;
        }

        public SyncInvoker<ListEvent2alarmRuleResponse> ListEvent2alarmRuleInvoker(ListEvent2alarmRuleRequest listEvent2alarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/event2alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEvent2alarmRuleRequest);
            return new SyncInvoker<ListEvent2alarmRuleResponse>(this, "GET", request, response =>
            {
                var listEvent2alarmRuleResponse = JsonUtils.DeSerializeNull<ListEvent2alarmRuleResponse>(response);
                listEvent2alarmRuleResponse.Body = JsonUtils.DeSerializeList<Event2alarmRuleBody>(response);
                return listEvent2alarmRuleResponse;
            });
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListEventsResponse>(response);
        }

        public SyncInvoker<ListEventsResponse> ListEventsInvoker(ListEventsRequest listEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventsRequest);
            return new SyncInvoker<ListEventsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListEventsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/als/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogItemsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListLogItemsResponse>(response);
        }

        public SyncInvoker<ListLogItemsResponse> ListLogItemsInvoker(ListLogItemsRequest listLogItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/als/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogItemsRequest);
            return new SyncInvoker<ListLogItemsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLogItemsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ams/metrics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricItemsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListMetricItemsResponse>(response);
        }

        public SyncInvoker<ListMetricItemsResponse> ListMetricItemsInvoker(ListMetricItemsRequest listMetricItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ams/metrics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricItemsRequest);
            return new SyncInvoker<ListMetricItemsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListMetricItemsResponse>);
        }
        
        /// <summary>
        /// 查询指标类或者事件类告警规则列表
        ///
        /// 查询AOM2.0指标类或者事件类告警规则列表。(注：接口目前开放的region为：华东-上海一)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMetricOrEventAlarmRuleResponse ListMetricOrEventAlarmRule(ListMetricOrEventAlarmRuleRequest listMetricOrEventAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricOrEventAlarmRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMetricOrEventAlarmRuleResponse>(response);
        }

        public SyncInvoker<ListMetricOrEventAlarmRuleResponse> ListMetricOrEventAlarmRuleInvoker(ListMetricOrEventAlarmRuleRequest listMetricOrEventAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricOrEventAlarmRuleRequest);
            return new SyncInvoker<ListMetricOrEventAlarmRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMetricOrEventAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 获取静默规则列表
        ///
        /// 获取静默规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMuteRuleResponse ListMuteRule(ListMuteRuleRequest listMuteRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/mute-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMuteRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            var listMuteRuleResponse = JsonUtils.DeSerializeNull<ListMuteRuleResponse>(response);
            listMuteRuleResponse.Body = JsonUtils.DeSerializeList<MuteRule>(response);
            return listMuteRuleResponse;
        }

        public SyncInvoker<ListMuteRuleResponse> ListMuteRuleInvoker(ListMuteRuleRequest listMuteRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/mute-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMuteRuleRequest);
            return new SyncInvoker<ListMuteRuleResponse>(this, "GET", request, response =>
            {
                var listMuteRuleResponse = JsonUtils.DeSerializeNull<ListMuteRuleResponse>(response);
                listMuteRuleResponse.Body = JsonUtils.DeSerializeList<MuteRule>(response);
                return listMuteRuleResponse;
            });
        }
        
        /// <summary>
        /// 获取告警发送结果
        ///
        /// 获取告警发送结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNotifiedHistoriesResponse ListNotifiedHistories(ListNotifiedHistoriesRequest listNotifiedHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-notified-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotifiedHistoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNotifiedHistoriesResponse>(response);
        }

        public SyncInvoker<ListNotifiedHistoriesResponse> ListNotifiedHistoriesInvoker(ListNotifiedHistoriesRequest listNotifiedHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-notified-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotifiedHistoriesRequest);
            return new SyncInvoker<ListNotifiedHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNotifiedHistoriesResponse>);
        }
        
        /// <summary>
        /// 查询aom2.0相关云服务授权信息
        ///
        /// 该接口用于查询aom2.0相关云服务授权信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPermissionsResponse ListPermissions(ListPermissionsRequest listPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/auth/grant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerializeNull<ListPermissionsResponse>(response);
        }

        public SyncInvoker<ListPermissionsResponse> ListPermissionsInvoker(ListPermissionsRequest listPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/auth/grant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionsRequest);
            return new SyncInvoker<ListPermissionsResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ListPermissionsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/samples", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSampleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListSampleResponse>(response);
        }

        public SyncInvoker<ListSampleResponse> ListSampleInvoker(ListSampleRequest listSampleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/samples", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSampleRequest);
            return new SyncInvoker<ListSampleResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSampleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/series", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSeriesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListSeriesResponse>(response);
        }

        public SyncInvoker<ListSeriesResponse> ListSeriesInvoker(ListSeriesRequest listSeriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/series", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSeriesRequest);
            return new SyncInvoker<ListSeriesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSeriesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/inv/servicediscoveryrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceDiscoveryRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServiceDiscoveryRulesResponse>(response);
        }

        public SyncInvoker<ListServiceDiscoveryRulesResponse> ListServiceDiscoveryRulesInvoker(ListServiceDiscoveryRulesRequest listServiceDiscoveryRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/inv/servicediscoveryrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceDiscoveryRulesRequest);
            return new SyncInvoker<ListServiceDiscoveryRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServiceDiscoveryRulesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/push/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", pushEventsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<PushEventsResponse>(response);
        }

        public SyncInvoker<PushEventsResponse> PushEventsInvoker(PushEventsRequest pushEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/push/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", pushEventsRequest);
            return new SyncInvoker<PushEventsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<PushEventsResponse>);
        }
        
        /// <summary>
        /// 通过规则名称获取告警行动规则
        ///
        /// 通过规则名称获取告警行动规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowActionRuleResponse ShowActionRule(ShowActionRuleRequest showActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showActionRuleRequest.RuleName, out var valueOfRuleName)) urlParam.Add("rule_name", valueOfRuleName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules/{rule_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActionRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowActionRuleResponse>(response);
        }

        public SyncInvoker<ShowActionRuleResponse> ShowActionRuleInvoker(ShowActionRuleRequest showActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showActionRuleRequest.RuleName, out var valueOfRuleName)) urlParam.Add("rule_name", valueOfRuleName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules/{rule_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActionRuleRequest);
            return new SyncInvoker<ShowActionRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowActionRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAlarmRuleRequest.AlarmRuleId, out var valueOfAlarmRuleId)) urlParam.Add("alarm_rule_id", valueOfAlarmRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules/{alarm_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAlarmRuleResponse>(response);
        }

        public SyncInvoker<ShowAlarmRuleResponse> ShowAlarmRuleInvoker(ShowAlarmRuleRequest showAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAlarmRuleRequest.AlarmRuleId, out var valueOfAlarmRuleId)) urlParam.Add("alarm_rule_id", valueOfAlarmRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules/{alarm_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmRuleRequest);
            return new SyncInvoker<ShowAlarmRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAlarmRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ams/metricdata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetricsDataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowMetricsDataResponse>(response);
        }

        public SyncInvoker<ShowMetricsDataResponse> ShowMetricsDataInvoker(ShowMetricsDataRequest showMetricsDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ams/metricdata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetricsDataRequest);
            return new SyncInvoker<ShowMetricsDataResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowMetricsDataResponse>);
        }
        
        /// <summary>
        /// 修改告警行动规则
        ///
        /// 修改告警行动规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateActionRuleResponse UpdateActionRule(UpdateActionRuleRequest updateActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateActionRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateActionRuleResponse>(response);
        }

        public SyncInvoker<UpdateActionRuleResponse> UpdateActionRuleInvoker(UpdateActionRuleRequest updateActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateActionRuleRequest);
            return new SyncInvoker<UpdateActionRuleResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateActionRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAlarmRuleResponse>(response);
        }

        public SyncInvoker<UpdateAlarmRuleResponse> UpdateAlarmRuleInvoker(UpdateAlarmRuleRequest updateAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmRuleRequest);
            return new SyncInvoker<UpdateAlarmRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 更新事件类告警规则
        ///
        /// 更新事件类告警规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateEventRuleResponse UpdateEventRule(UpdateEventRuleRequest updateEventRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/event2alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEventRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateEventRuleResponse>(response);
        }

        public SyncInvoker<UpdateEventRuleResponse> UpdateEventRuleInvoker(UpdateEventRuleRequest updateEventRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/event2alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEventRuleRequest);
            return new SyncInvoker<UpdateEventRuleResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateEventRuleResponse>);
        }
        
        /// <summary>
        /// 修改静默规则
        ///
        /// 修改静默规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMuteRuleResponse UpdateMuteRule(UpdateMuteRuleRequest updateMuteRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/mute-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMuteRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateMuteRuleResponse>(response);
        }

        public SyncInvoker<UpdateMuteRuleResponse> UpdateMuteRuleInvoker(UpdateMuteRuleRequest updateMuteRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/mute-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMuteRuleRequest);
            return new SyncInvoker<UpdateMuteRuleResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateMuteRuleResponse>);
        }
        
        /// <summary>
        /// 新增Prometheus实例
        ///
        /// 该接口用于新增Prometheus实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePromInstanceResponse CreatePromInstance(CreatePromInstanceRequest createPromInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/prometheus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPromInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePromInstanceResponse>(response);
        }

        public SyncInvoker<CreatePromInstanceResponse> CreatePromInstanceInvoker(CreatePromInstanceRequest createPromInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/prometheus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPromInstanceRequest);
            return new SyncInvoker<CreatePromInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePromInstanceResponse>);
        }
        
        /// <summary>
        /// 创建Prometheus实例的预聚合规则
        ///
        /// 该接口用于给Prometheus实例创建预聚合规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRecordingRuleResponse CreateRecordingRule(CreateRecordingRuleRequest createRecordingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRecordingRuleRequest.PrometheusInstance, out var valueOfPrometheusInstance)) urlParam.Add("prometheus_instance", valueOfPrometheusInstance);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{prometheus_instance}/aom/api/v1/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordingRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateRecordingRuleResponse>(response);
        }

        public SyncInvoker<CreateRecordingRuleResponse> CreateRecordingRuleInvoker(CreateRecordingRuleRequest createRecordingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRecordingRuleRequest.PrometheusInstance, out var valueOfPrometheusInstance)) urlParam.Add("prometheus_instance", valueOfPrometheusInstance);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{prometheus_instance}/aom/api/v1/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordingRuleRequest);
            return new SyncInvoker<CreateRecordingRuleResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateRecordingRuleResponse>);
        }
        
        /// <summary>
        /// 卸载托管Prometheus实例
        ///
        /// 该接口用于卸载托管Prometheus实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePromInstanceResponse DeletePromInstance(DeletePromInstanceRequest deletePromInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/prometheus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePromInstanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePromInstanceResponse>(response);
        }

        public SyncInvoker<DeletePromInstanceResponse> DeletePromInstanceInvoker(DeletePromInstanceRequest deletePromInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/prometheus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePromInstanceRequest);
            return new SyncInvoker<DeletePromInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePromInstanceResponse>);
        }
        
        /// <summary>
        /// 获取Prometheus实例调用凭证
        ///
        /// 该接口用于获取Prometheus实例调用凭证。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccessCodeResponse ListAccessCode(ListAccessCodeRequest listAccessCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/access-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessCodeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccessCodeResponse>(response);
        }

        public SyncInvoker<ListAccessCodeResponse> ListAccessCodeInvoker(ListAccessCodeRequest listAccessCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/access-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessCodeRequest);
            return new SyncInvoker<ListAccessCodeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccessCodeResponse>);
        }
        
        /// <summary>
        /// GET方法查询瞬时数据
        ///
        /// 该接口使用GET方法查询PromQL(Prometheus Query Language)在特定时间点下的计算结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstantQueryAomPromGetResponse ListInstantQueryAomPromGet(ListInstantQueryAomPromGetRequest listInstantQueryAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstantQueryAomPromGetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstantQueryAomPromGetResponse>(response);
        }

        public SyncInvoker<ListInstantQueryAomPromGetResponse> ListInstantQueryAomPromGetInvoker(ListInstantQueryAomPromGetRequest listInstantQueryAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstantQueryAomPromGetRequest);
            return new SyncInvoker<ListInstantQueryAomPromGetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstantQueryAomPromGetResponse>);
        }
        
        /// <summary>
        /// （推荐）POST方法查询瞬时数据
        ///
        /// 该接口使用POST方法查询PromQL(Prometheus Query Language) 在特定时间点下的计算结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstantQueryAomPromPostResponse ListInstantQueryAomPromPost(ListInstantQueryAomPromPostRequest listInstantQueryAomPromPostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstantQueryAomPromPostRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListInstantQueryAomPromPostResponse>(response);
        }

        public SyncInvoker<ListInstantQueryAomPromPostResponse> ListInstantQueryAomPromPostInvoker(ListInstantQueryAomPromPostRequest listInstantQueryAomPromPostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstantQueryAomPromPostRequest);
            return new SyncInvoker<ListInstantQueryAomPromPostResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInstantQueryAomPromPostResponse>);
        }
        
        /// <summary>
        /// 查询标签值
        ///
        /// 该接口用于查询带有指定标签的时间序列列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLabelValuesAomPromGetResponse ListLabelValuesAomPromGet(ListLabelValuesAomPromGetRequest listLabelValuesAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLabelValuesAomPromGetRequest.LabelName, out var valueOfLabelName)) urlParam.Add("label_name", valueOfLabelName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/label/{label_name}/values", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLabelValuesAomPromGetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLabelValuesAomPromGetResponse>(response);
        }

        public SyncInvoker<ListLabelValuesAomPromGetResponse> ListLabelValuesAomPromGetInvoker(ListLabelValuesAomPromGetRequest listLabelValuesAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLabelValuesAomPromGetRequest.LabelName, out var valueOfLabelName)) urlParam.Add("label_name", valueOfLabelName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/label/{label_name}/values", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLabelValuesAomPromGetRequest);
            return new SyncInvoker<ListLabelValuesAomPromGetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLabelValuesAomPromGetResponse>);
        }
        
        /// <summary>
        /// GET方法获取标签名列表
        ///
        /// 该接口使用GET方法获取标签名列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLabelsAomPromGetResponse ListLabelsAomPromGet(ListLabelsAomPromGetRequest listLabelsAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLabelsAomPromGetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLabelsAomPromGetResponse>(response);
        }

        public SyncInvoker<ListLabelsAomPromGetResponse> ListLabelsAomPromGetInvoker(ListLabelsAomPromGetRequest listLabelsAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLabelsAomPromGetRequest);
            return new SyncInvoker<ListLabelsAomPromGetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLabelsAomPromGetResponse>);
        }
        
        /// <summary>
        /// （推荐）POST方法获取标签名列表
        ///
        /// 该接口使用POST方法获取标签名列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLabelsAomPromPostResponse ListLabelsAomPromPost(ListLabelsAomPromPostRequest listLabelsAomPromPostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLabelsAomPromPostRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListLabelsAomPromPostResponse>(response);
        }

        public SyncInvoker<ListLabelsAomPromPostResponse> ListLabelsAomPromPostInvoker(ListLabelsAomPromPostRequest listLabelsAomPromPostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLabelsAomPromPostRequest);
            return new SyncInvoker<ListLabelsAomPromPostResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLabelsAomPromPostResponse>);
        }
        
        /// <summary>
        /// 元数据查询
        ///
        /// 该接口用于查询序列及序列标签的元数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMetadataAomPromGetResponse ListMetadataAomPromGet(ListMetadataAomPromGetRequest listMetadataAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetadataAomPromGetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMetadataAomPromGetResponse>(response);
        }

        public SyncInvoker<ListMetadataAomPromGetResponse> ListMetadataAomPromGetInvoker(ListMetadataAomPromGetRequest listMetadataAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetadataAomPromGetRequest);
            return new SyncInvoker<ListMetadataAomPromGetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMetadataAomPromGetResponse>);
        }
        
        /// <summary>
        /// 查询Prometheus实例
        ///
        /// 该接口用于查询Prometheus实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPromInstanceResponse ListPromInstance(ListPromInstanceRequest listPromInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/prometheus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPromInstanceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPromInstanceResponse>(response);
        }

        public SyncInvoker<ListPromInstanceResponse> ListPromInstanceInvoker(ListPromInstanceRequest listPromInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/prometheus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPromInstanceRequest);
            return new SyncInvoker<ListPromInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPromInstanceResponse>);
        }
        
        /// <summary>
        /// GET方法查询区间数据
        ///
        /// 该接口使用GET方法查询PromQL(Prometheus Query Language)在一段时间返回内的计算结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRangeQueryAomPromGetResponse ListRangeQueryAomPromGet(ListRangeQueryAomPromGetRequest listRangeQueryAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/query_range", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRangeQueryAomPromGetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRangeQueryAomPromGetResponse>(response);
        }

        public SyncInvoker<ListRangeQueryAomPromGetResponse> ListRangeQueryAomPromGetInvoker(ListRangeQueryAomPromGetRequest listRangeQueryAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/query_range", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRangeQueryAomPromGetRequest);
            return new SyncInvoker<ListRangeQueryAomPromGetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRangeQueryAomPromGetResponse>);
        }
        
        /// <summary>
        /// （推荐）POST方法查询区间数据
        ///
        /// 该接口使用POST方法查询PromQL(Prometheus Query Language)在一段时间返回内的计算结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRangeQueryAomPromPostResponse ListRangeQueryAomPromPost(ListRangeQueryAomPromPostRequest listRangeQueryAomPromPostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/query_range", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRangeQueryAomPromPostRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListRangeQueryAomPromPostResponse>(response);
        }

        public SyncInvoker<ListRangeQueryAomPromPostResponse> ListRangeQueryAomPromPostInvoker(ListRangeQueryAomPromPostRequest listRangeQueryAomPromPostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/query_range", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRangeQueryAomPromPostRequest);
            return new SyncInvoker<ListRangeQueryAomPromPostResponse>(this, "POST", request, JsonUtils.DeSerialize<ListRangeQueryAomPromPostResponse>);
        }
        
    }
}