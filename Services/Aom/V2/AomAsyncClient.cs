using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Aom.V2.Model;

namespace HuaweiCloud.SDK.Aom.V2
{
    public partial class AomAsyncClient : Client
    {
        public static ClientBuilder<AomAsyncClient> NewBuilder()
        {
            return new ClientBuilder<AomAsyncClient>();
        }

        
        /// <summary>
        /// 新增告警行动规则
        ///
        /// 新增告警行动规则。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddActionRuleResponse> AddActionRuleAsync(AddActionRuleRequest addActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addActionRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddActionRuleResponse>(response);
        }

        public AsyncInvoker<AddActionRuleResponse> AddActionRuleAsyncInvoker(AddActionRuleRequest addActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addActionRuleRequest);
            return new AsyncInvoker<AddActionRuleResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddActionRuleResponse>);
        }
        
        /// <summary>
        /// 添加阈值规则
        ///
        /// 该接口用于添加一条阈值规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddAlarmRuleResponse> AddAlarmRuleAsync(AddAlarmRuleRequest addAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAlarmRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddAlarmRuleResponse>(response);
        }

        public AsyncInvoker<AddAlarmRuleResponse> AddAlarmRuleAsyncInvoker(AddAlarmRuleRequest addAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAlarmRuleRequest);
            return new AsyncInvoker<AddAlarmRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 新增一条事件类告警规则
        ///
        /// 新增一条事件类告警规则。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddEvent2alarmRuleResponse> AddEvent2alarmRuleAsync(AddEvent2alarmRuleRequest addEvent2alarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/event2alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addEvent2alarmRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddEvent2alarmRuleResponse>(response);
        }

        public AsyncInvoker<AddEvent2alarmRuleResponse> AddEvent2alarmRuleAsyncInvoker(AddEvent2alarmRuleRequest addEvent2alarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/event2alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addEvent2alarmRuleRequest);
            return new AsyncInvoker<AddEvent2alarmRuleResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddEvent2alarmRuleResponse>);
        }
        
        /// <summary>
        /// 添加监控数据
        ///
        /// 该接口用于向服务端添加一条或多条监控数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddMetricDataResponse> AddMetricDataAsync(AddMetricDataRequest addMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ams/report/metricdata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addMetricDataRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddMetricDataResponse>(response);
        }

        public AsyncInvoker<AddMetricDataResponse> AddMetricDataAsyncInvoker(AddMetricDataRequest addMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ams/report/metricdata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addMetricDataRequest);
            return new AsyncInvoker<AddMetricDataResponse>(this, "POST", request, JsonUtils.DeSerialize<AddMetricDataResponse>);
        }
        
        /// <summary>
        /// 新增静默规则
        ///
        /// 新增静默规则。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddMuteRulesResponse> AddMuteRulesAsync(AddMuteRulesRequest addMuteRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/mute-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addMuteRulesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddMuteRulesResponse>(response);
        }

        public AsyncInvoker<AddMuteRulesResponse> AddMuteRulesAsyncInvoker(AddMuteRulesRequest addMuteRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/mute-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addMuteRulesRequest);
            return new AsyncInvoker<AddMuteRulesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddMuteRulesResponse>);
        }
        
        /// <summary>
        /// 添加或修改服务发现规则
        ///
        /// 该接口用于添加或修改一条或多条服务发现规则。同一projectid下可添加的规则上限为100条。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddOrUpdateServiceDiscoveryRulesResponse> AddOrUpdateServiceDiscoveryRulesAsync(AddOrUpdateServiceDiscoveryRulesRequest addOrUpdateServiceDiscoveryRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/inv/servicediscoveryrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addOrUpdateServiceDiscoveryRulesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<AddOrUpdateServiceDiscoveryRulesResponse>(response);
        }

        public AsyncInvoker<AddOrUpdateServiceDiscoveryRulesResponse> AddOrUpdateServiceDiscoveryRulesAsyncInvoker(AddOrUpdateServiceDiscoveryRulesRequest addOrUpdateServiceDiscoveryRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/inv/servicediscoveryrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addOrUpdateServiceDiscoveryRulesRequest);
            return new AsyncInvoker<AddOrUpdateServiceDiscoveryRulesResponse>(this, "PUT", request, JsonUtils.DeSerialize<AddOrUpdateServiceDiscoveryRulesResponse>);
        }
        
        /// <summary>
        /// 统计事件告警信息
        ///
        /// 该接口用于分段统计指定条件下的事件、告警。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountEventsResponse> CountEventsAsync(CountEventsRequest countEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/events/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countEventsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CountEventsResponse>(response);
        }

        public AsyncInvoker<CountEventsResponse> CountEventsAsyncInvoker(CountEventsRequest countEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/events/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countEventsRequest);
            return new AsyncInvoker<CountEventsResponse>(this, "POST", request, JsonUtils.DeSerialize<CountEventsResponse>);
        }
        
        /// <summary>
        /// 删除告警行动规则
        ///
        /// 删除告警行动规则。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteActionRuleResponse> DeleteActionRuleAsync(DeleteActionRuleRequest deleteActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteActionRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteActionRuleResponse>(response);
        }

        public AsyncInvoker<DeleteActionRuleResponse> DeleteActionRuleAsyncInvoker(DeleteActionRuleRequest deleteActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteActionRuleRequest);
            return new AsyncInvoker<DeleteActionRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteActionRuleResponse>);
        }
        
        /// <summary>
        /// 删除阈值规则
        ///
        /// 该接口用于删除阈值规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAlarmRuleResponse> DeleteAlarmRuleAsync(DeleteAlarmRuleRequest deleteAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_rule_id", deleteAlarmRuleRequest.AlarmRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules/{alarm_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAlarmRuleResponse>(response);
        }

        public AsyncInvoker<DeleteAlarmRuleResponse> DeleteAlarmRuleAsyncInvoker(DeleteAlarmRuleRequest deleteAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_rule_id", deleteAlarmRuleRequest.AlarmRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules/{alarm_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRuleRequest);
            return new AsyncInvoker<DeleteAlarmRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 批量删除阈值规则
        ///
        /// 批量删除阈值规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAlarmRulesResponse> DeleteAlarmRulesAsync(DeleteAlarmRulesRequest deleteAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRulesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteAlarmRulesResponse>(response);
        }

        public AsyncInvoker<DeleteAlarmRulesResponse> DeleteAlarmRulesAsyncInvoker(DeleteAlarmRulesRequest deleteAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRulesRequest);
            return new AsyncInvoker<DeleteAlarmRulesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteAlarmRulesResponse>);
        }
        
        /// <summary>
        /// 删除事件类告警规则
        ///
        /// 删除一条事件类告警规则。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteEvent2alarmRuleResponse> DeleteEvent2alarmRuleAsync(DeleteEvent2alarmRuleRequest deleteEvent2alarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/event2alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEvent2alarmRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteEvent2alarmRuleResponse>(response);
        }

        public AsyncInvoker<DeleteEvent2alarmRuleResponse> DeleteEvent2alarmRuleAsyncInvoker(DeleteEvent2alarmRuleRequest deleteEvent2alarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/event2alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEvent2alarmRuleRequest);
            return new AsyncInvoker<DeleteEvent2alarmRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteEvent2alarmRuleResponse>);
        }
        
        /// <summary>
        /// 删除静默规则
        ///
        /// 删除静默规则。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteMuteRulesResponse> DeleteMuteRulesAsync(DeleteMuteRulesRequest deleteMuteRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/mute-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMuteRulesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMuteRulesResponse>(response);
        }

        public AsyncInvoker<DeleteMuteRulesResponse> DeleteMuteRulesAsyncInvoker(DeleteMuteRulesRequest deleteMuteRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/mute-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMuteRulesRequest);
            return new AsyncInvoker<DeleteMuteRulesResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMuteRulesResponse>);
        }
        
        /// <summary>
        /// 删除服务发现规则
        ///
        /// 该接口用于删除服务发现规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteserviceDiscoveryRulesResponse> DeleteserviceDiscoveryRulesAsync(DeleteserviceDiscoveryRulesRequest deleteserviceDiscoveryRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/inv/servicediscoveryrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteserviceDiscoveryRulesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteserviceDiscoveryRulesResponse>(response);
        }

        public AsyncInvoker<DeleteserviceDiscoveryRulesResponse> DeleteserviceDiscoveryRulesAsyncInvoker(DeleteserviceDiscoveryRulesRequest deleteserviceDiscoveryRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/inv/servicediscoveryrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteserviceDiscoveryRulesRequest);
            return new AsyncInvoker<DeleteserviceDiscoveryRulesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteserviceDiscoveryRulesResponse>);
        }
        
        /// <summary>
        /// 获取告警行动规则列表
        ///
        /// 获取告警行动规则列表。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListActionRuleResponse> ListActionRuleAsync(ListActionRuleRequest listActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listActionRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListActionRuleResponse>(response);
        }

        public AsyncInvoker<ListActionRuleResponse> ListActionRuleAsyncInvoker(ListActionRuleRequest listActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listActionRuleRequest);
            return new AsyncInvoker<ListActionRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListActionRuleResponse>);
        }
        
        /// <summary>
        /// 查询集群主机安装的ICAgent信息
        ///
        /// 该接口用于查询集群主机安装的ICAgent信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAgentsResponse> ListAgentsAsync(ListAgentsRequest listAgentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listAgentsRequest.ClusterId.ToString());
            urlParam.Add("namespace", listAgentsRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{cluster_id}/{namespace}/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerializeNull<ListAgentsResponse>(response);
        }

        public AsyncInvoker<ListAgentsResponse> ListAgentsAsyncInvoker(ListAgentsRequest listAgentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id", listAgentsRequest.ClusterId.ToString());
            urlParam.Add("namespace", listAgentsRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{cluster_id}/{namespace}/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentsRequest);
            return new AsyncInvoker<ListAgentsResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ListAgentsResponse>);
        }
        
        /// <summary>
        /// 查询阈值规则列表
        ///
        /// 该接口用于查询阈值规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAlarmRuleResponse> ListAlarmRuleAsync(ListAlarmRuleRequest listAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmRuleResponse>(response);
        }

        public AsyncInvoker<ListAlarmRuleResponse> ListAlarmRuleAsyncInvoker(ListAlarmRuleRequest listAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRuleRequest);
            return new AsyncInvoker<ListAlarmRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 查询事件类告警规则列表
        ///
        /// 查询事件类告警规则列表。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEvent2alarmRuleResponse> ListEvent2alarmRuleAsync(ListEvent2alarmRuleRequest listEvent2alarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/event2alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEvent2alarmRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listEvent2alarmRuleResponse = JsonUtils.DeSerializeNull<ListEvent2alarmRuleResponse>(response);
            listEvent2alarmRuleResponse.Body = JsonUtils.DeSerializeList<Event2alarmRuleBody>(response);
            return listEvent2alarmRuleResponse;
        }

        public AsyncInvoker<ListEvent2alarmRuleResponse> ListEvent2alarmRuleAsyncInvoker(ListEvent2alarmRuleRequest listEvent2alarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/event2alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEvent2alarmRuleRequest);
            return new AsyncInvoker<ListEvent2alarmRuleResponse>(this, "GET", request, response =>
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
        public async Task<ListEventsResponse> ListEventsAsync(ListEventsRequest listEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListEventsResponse>(response);
        }

        public AsyncInvoker<ListEventsResponse> ListEventsAsyncInvoker(ListEventsRequest listEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventsRequest);
            return new AsyncInvoker<ListEventsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListEventsResponse>);
        }
        
        /// <summary>
        /// 查询日志
        ///
        /// 该接口用于查询不同维度(例如集群、IP、应用等)下的日志内容，支持分页查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLogItemsResponse> ListLogItemsAsync(ListLogItemsRequest listLogItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/als/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogItemsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListLogItemsResponse>(response);
        }

        public AsyncInvoker<ListLogItemsResponse> ListLogItemsAsyncInvoker(ListLogItemsRequest listLogItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/als/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogItemsRequest);
            return new AsyncInvoker<ListLogItemsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLogItemsResponse>);
        }
        
        /// <summary>
        /// 查询指标
        ///
        /// 该接口用于查询系统当前可监控的指标列表，可以指定指标命名空间、指标名称、维度、所属资源的编号（格式为：resType_resId），分页查询的起始位置和返回的最大记录条数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMetricItemsResponse> ListMetricItemsAsync(ListMetricItemsRequest listMetricItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ams/metrics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricItemsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListMetricItemsResponse>(response);
        }

        public AsyncInvoker<ListMetricItemsResponse> ListMetricItemsAsyncInvoker(ListMetricItemsRequest listMetricItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ams/metrics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricItemsRequest);
            return new AsyncInvoker<ListMetricItemsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListMetricItemsResponse>);
        }
        
        /// <summary>
        /// 获取静默规则列表
        ///
        /// 获取静默规则列表。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMuteRuleResponse> ListMuteRuleAsync(ListMuteRuleRequest listMuteRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/mute-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMuteRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listMuteRuleResponse = JsonUtils.DeSerializeNull<ListMuteRuleResponse>(response);
            listMuteRuleResponse.Body = JsonUtils.DeSerializeList<MuteRule>(response);
            return listMuteRuleResponse;
        }

        public AsyncInvoker<ListMuteRuleResponse> ListMuteRuleAsyncInvoker(ListMuteRuleRequest listMuteRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/mute-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMuteRuleRequest);
            return new AsyncInvoker<ListMuteRuleResponse>(this, "GET", request, response =>
            {
                var listMuteRuleResponse = JsonUtils.DeSerializeNull<ListMuteRuleResponse>(response);
                listMuteRuleResponse.Body = JsonUtils.DeSerializeList<MuteRule>(response);
                return listMuteRuleResponse;
            });
        }
        
        /// <summary>
        /// 获取告警发送结果
        ///
        /// 获取告警发送结果。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNotifiedHistoriesResponse> ListNotifiedHistoriesAsync(ListNotifiedHistoriesRequest listNotifiedHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-notified-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotifiedHistoriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNotifiedHistoriesResponse>(response);
        }

        public AsyncInvoker<ListNotifiedHistoriesResponse> ListNotifiedHistoriesAsyncInvoker(ListNotifiedHistoriesRequest listNotifiedHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-notified-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotifiedHistoriesRequest);
            return new AsyncInvoker<ListNotifiedHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNotifiedHistoriesResponse>);
        }
        
        /// <summary>
        /// 查询aom2.0相关云服务授权信息
        ///
        /// 该接口用于查询aom2.0相关云服务授权信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPermissionsResponse> ListPermissionsAsync(ListPermissionsRequest listPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/auth/grant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerializeNull<ListPermissionsResponse>(response);
        }

        public AsyncInvoker<ListPermissionsResponse> ListPermissionsAsyncInvoker(ListPermissionsRequest listPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/auth/grant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionsRequest);
            return new AsyncInvoker<ListPermissionsResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ListPermissionsResponse>);
        }
        
        /// <summary>
        /// 查询时序数据
        ///
        /// 该接口用于查询指定时间范围内的监控时序数据，可以通过参数指定需要查询的数据维度，数据周期等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSampleResponse> ListSampleAsync(ListSampleRequest listSampleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/samples", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSampleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListSampleResponse>(response);
        }

        public AsyncInvoker<ListSampleResponse> ListSampleAsyncInvoker(ListSampleRequest listSampleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/samples", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSampleRequest);
            return new AsyncInvoker<ListSampleResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSampleResponse>);
        }
        
        /// <summary>
        /// 查询时间序列
        ///
        /// 该接口用于查询系统当前可监控的时间序列列表，可以指定时间序列命名空间、名称、维度、所属资源的编号（格式为：resType_resId），分页查询的起始位置和返回的最大记录条数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSeriesResponse> ListSeriesAsync(ListSeriesRequest listSeriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/series", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSeriesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListSeriesResponse>(response);
        }

        public AsyncInvoker<ListSeriesResponse> ListSeriesAsyncInvoker(ListSeriesRequest listSeriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/series", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSeriesRequest);
            return new AsyncInvoker<ListSeriesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSeriesResponse>);
        }
        
        /// <summary>
        /// 查询系统中已有服务发现规则
        ///
        /// 该接口用于查询系统当前已存在的服务发现规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServiceDiscoveryRulesResponse> ListServiceDiscoveryRulesAsync(ListServiceDiscoveryRulesRequest listServiceDiscoveryRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/inv/servicediscoveryrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceDiscoveryRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServiceDiscoveryRulesResponse>(response);
        }

        public AsyncInvoker<ListServiceDiscoveryRulesResponse> ListServiceDiscoveryRulesAsyncInvoker(ListServiceDiscoveryRulesRequest listServiceDiscoveryRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/inv/servicediscoveryrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceDiscoveryRulesRequest);
            return new AsyncInvoker<ListServiceDiscoveryRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServiceDiscoveryRulesResponse>);
        }
        
        /// <summary>
        /// 上报事件告警信息
        ///
        /// 该接口用于上报对应用户的事件、告警。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PushEventsResponse> PushEventsAsync(PushEventsRequest pushEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/push/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", pushEventsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<PushEventsResponse>(response);
        }

        public AsyncInvoker<PushEventsResponse> PushEventsAsyncInvoker(PushEventsRequest pushEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/push/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", pushEventsRequest);
            return new AsyncInvoker<PushEventsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<PushEventsResponse>);
        }
        
        /// <summary>
        /// 通过规则名称获取告警行动规则
        ///
        /// 通过规则名称获取告警行动规则。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowActionRuleResponse> ShowActionRuleAsync(ShowActionRuleRequest showActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_name", showActionRuleRequest.RuleName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules/{rule_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActionRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowActionRuleResponse>(response);
        }

        public AsyncInvoker<ShowActionRuleResponse> ShowActionRuleAsyncInvoker(ShowActionRuleRequest showActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_name", showActionRuleRequest.RuleName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules/{rule_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActionRuleRequest);
            return new AsyncInvoker<ShowActionRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowActionRuleResponse>);
        }
        
        /// <summary>
        /// 查询单条阈值规则
        ///
        /// 该接口用于查询单条阈值规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAlarmRuleResponse> ShowAlarmRuleAsync(ShowAlarmRuleRequest showAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_rule_id", showAlarmRuleRequest.AlarmRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules/{alarm_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAlarmRuleResponse>(response);
        }

        public AsyncInvoker<ShowAlarmRuleResponse> ShowAlarmRuleAsyncInvoker(ShowAlarmRuleRequest showAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_rule_id", showAlarmRuleRequest.AlarmRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules/{alarm_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmRuleRequest);
            return new AsyncInvoker<ShowAlarmRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 查询监控数据
        ///
        /// 该接口用于查询指定时间范围内指标的监控数据，可以通过参数指定需要查询的数据维度，数据周期等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMetricsDataResponse> ShowMetricsDataAsync(ShowMetricsDataRequest showMetricsDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ams/metricdata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetricsDataRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowMetricsDataResponse>(response);
        }

        public AsyncInvoker<ShowMetricsDataResponse> ShowMetricsDataAsyncInvoker(ShowMetricsDataRequest showMetricsDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ams/metricdata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetricsDataRequest);
            return new AsyncInvoker<ShowMetricsDataResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowMetricsDataResponse>);
        }
        
        /// <summary>
        /// 修改告警行动规则
        ///
        /// 修改告警行动规则。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateActionRuleResponse> UpdateActionRuleAsync(UpdateActionRuleRequest updateActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateActionRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateActionRuleResponse>(response);
        }

        public AsyncInvoker<UpdateActionRuleResponse> UpdateActionRuleAsyncInvoker(UpdateActionRuleRequest updateActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateActionRuleRequest);
            return new AsyncInvoker<UpdateActionRuleResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateActionRuleResponse>);
        }
        
        /// <summary>
        /// 修改阈值规则
        ///
        /// 该接口用于修改一条阈值规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAlarmRuleResponse> UpdateAlarmRuleAsync(UpdateAlarmRuleRequest updateAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAlarmRuleResponse>(response);
        }

        public AsyncInvoker<UpdateAlarmRuleResponse> UpdateAlarmRuleAsyncInvoker(UpdateAlarmRuleRequest updateAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmRuleRequest);
            return new AsyncInvoker<UpdateAlarmRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 更新事件类告警规则
        ///
        /// 更新事件类告警规则。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEventRuleResponse> UpdateEventRuleAsync(UpdateEventRuleRequest updateEventRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/event2alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEventRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateEventRuleResponse>(response);
        }

        public AsyncInvoker<UpdateEventRuleResponse> UpdateEventRuleAsyncInvoker(UpdateEventRuleRequest updateEventRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/event2alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEventRuleRequest);
            return new AsyncInvoker<UpdateEventRuleResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateEventRuleResponse>);
        }
        
        /// <summary>
        /// 修改静默规则
        ///
        /// 修改静默规则。（注：接口目前开放的region为：上海一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMuteRuleResponse> UpdateMuteRuleAsync(UpdateMuteRuleRequest updateMuteRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/mute-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMuteRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateMuteRuleResponse>(response);
        }

        public AsyncInvoker<UpdateMuteRuleResponse> UpdateMuteRuleAsyncInvoker(UpdateMuteRuleRequest updateMuteRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/mute-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMuteRuleRequest);
            return new AsyncInvoker<UpdateMuteRuleResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateMuteRuleResponse>);
        }
        
        /// <summary>
        /// 新增Prometheus实例
        ///
        /// 该接口用于新增Prometheus实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePromInstanceResponse> CreatePromInstanceAsync(CreatePromInstanceRequest createPromInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/prometheus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPromInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePromInstanceResponse>(response);
        }

        public AsyncInvoker<CreatePromInstanceResponse> CreatePromInstanceAsyncInvoker(CreatePromInstanceRequest createPromInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/prometheus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPromInstanceRequest);
            return new AsyncInvoker<CreatePromInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePromInstanceResponse>);
        }
        
        /// <summary>
        /// 创建Prometheus实例的预聚合规则
        ///
        /// 该接口用于给Prometheus实例创建预聚合规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRecordingRuleResponse> CreateRecordingRuleAsync(CreateRecordingRuleRequest createRecordingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("prometheus_instance", createRecordingRuleRequest.PrometheusInstance.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{prometheus_instance}/aom/api/v1/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordingRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateRecordingRuleResponse>(response);
        }

        public AsyncInvoker<CreateRecordingRuleResponse> CreateRecordingRuleAsyncInvoker(CreateRecordingRuleRequest createRecordingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("prometheus_instance", createRecordingRuleRequest.PrometheusInstance.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{prometheus_instance}/aom/api/v1/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordingRuleRequest);
            return new AsyncInvoker<CreateRecordingRuleResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateRecordingRuleResponse>);
        }
        
        /// <summary>
        /// 卸载托管Prometheus实例
        ///
        /// 该接口用于卸载托管Prometheus实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePromInstanceResponse> DeletePromInstanceAsync(DeletePromInstanceRequest deletePromInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/prometheus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePromInstanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePromInstanceResponse>(response);
        }

        public AsyncInvoker<DeletePromInstanceResponse> DeletePromInstanceAsyncInvoker(DeletePromInstanceRequest deletePromInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/prometheus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePromInstanceRequest);
            return new AsyncInvoker<DeletePromInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePromInstanceResponse>);
        }
        
        /// <summary>
        /// 获取Prometheus实例调用凭证
        ///
        /// 该接口用于获取Prometheus实例调用凭证。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAccessCodeResponse> ListAccessCodeAsync(ListAccessCodeRequest listAccessCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/access-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessCodeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAccessCodeResponse>(response);
        }

        public AsyncInvoker<ListAccessCodeResponse> ListAccessCodeAsyncInvoker(ListAccessCodeRequest listAccessCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/access-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessCodeRequest);
            return new AsyncInvoker<ListAccessCodeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccessCodeResponse>);
        }
        
        /// <summary>
        /// 瞬时数据查询
        ///
        /// 该接口用于查询PromQL(Prometheus Query Language)在特定时间点下的计算结果。（注：接口目前开放的region为：北京四、上海一和广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstantQueryAomPromGetResponse> ListInstantQueryAomPromGetAsync(ListInstantQueryAomPromGetRequest listInstantQueryAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstantQueryAomPromGetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstantQueryAomPromGetResponse>(response);
        }

        public AsyncInvoker<ListInstantQueryAomPromGetResponse> ListInstantQueryAomPromGetAsyncInvoker(ListInstantQueryAomPromGetRequest listInstantQueryAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstantQueryAomPromGetRequest);
            return new AsyncInvoker<ListInstantQueryAomPromGetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstantQueryAomPromGetResponse>);
        }
        
        /// <summary>
        /// 瞬时数据查询
        ///
        /// 该接口用于查询PromQL(Prometheus Query Language) 在特定时间点下的计算结果。（注：接口目前开放的region为：北京四、上海一和广州）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstantQueryAomPromPostResponse> ListInstantQueryAomPromPostAsync(ListInstantQueryAomPromPostRequest listInstantQueryAomPromPostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstantQueryAomPromPostRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListInstantQueryAomPromPostResponse>(response);
        }

        public AsyncInvoker<ListInstantQueryAomPromPostResponse> ListInstantQueryAomPromPostAsyncInvoker(ListInstantQueryAomPromPostRequest listInstantQueryAomPromPostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstantQueryAomPromPostRequest);
            return new AsyncInvoker<ListInstantQueryAomPromPostResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInstantQueryAomPromPostResponse>);
        }
        
        /// <summary>
        /// 查询标签值
        ///
        /// 该接口用于查询带有指定标签的时间序列列表。（注：接口目前开放的region为：北京四、上海一和广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLabelValuesAomPromGetResponse> ListLabelValuesAomPromGetAsync(ListLabelValuesAomPromGetRequest listLabelValuesAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("label_name", listLabelValuesAomPromGetRequest.LabelName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/label/{label_name}/values", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLabelValuesAomPromGetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLabelValuesAomPromGetResponse>(response);
        }

        public AsyncInvoker<ListLabelValuesAomPromGetResponse> ListLabelValuesAomPromGetAsyncInvoker(ListLabelValuesAomPromGetRequest listLabelValuesAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("label_name", listLabelValuesAomPromGetRequest.LabelName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/label/{label_name}/values", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLabelValuesAomPromGetRequest);
            return new AsyncInvoker<ListLabelValuesAomPromGetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLabelValuesAomPromGetResponse>);
        }
        
        /// <summary>
        /// 获取标签名列表
        ///
        /// 该接口用于获取标签名列表。（注：接口目前开放的region为：北京四、上海一和广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLabelsAomPromGetResponse> ListLabelsAomPromGetAsync(ListLabelsAomPromGetRequest listLabelsAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLabelsAomPromGetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLabelsAomPromGetResponse>(response);
        }

        public AsyncInvoker<ListLabelsAomPromGetResponse> ListLabelsAomPromGetAsyncInvoker(ListLabelsAomPromGetRequest listLabelsAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLabelsAomPromGetRequest);
            return new AsyncInvoker<ListLabelsAomPromGetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLabelsAomPromGetResponse>);
        }
        
        /// <summary>
        /// 获取标签名列表
        ///
        /// 该接口用于获取标签名列表。（注：接口目前开放的region为：北京四、上海一和广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLabelsAomPromPostResponse> ListLabelsAomPromPostAsync(ListLabelsAomPromPostRequest listLabelsAomPromPostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLabelsAomPromPostRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListLabelsAomPromPostResponse>(response);
        }

        public AsyncInvoker<ListLabelsAomPromPostResponse> ListLabelsAomPromPostAsyncInvoker(ListLabelsAomPromPostRequest listLabelsAomPromPostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLabelsAomPromPostRequest);
            return new AsyncInvoker<ListLabelsAomPromPostResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLabelsAomPromPostResponse>);
        }
        
        /// <summary>
        /// 元数据查询
        ///
        /// 该接口用于查询序列及序列标签的元数据。（注：接口目前开放的region为：北京四、上海一和广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMetadataAomPromGetResponse> ListMetadataAomPromGetAsync(ListMetadataAomPromGetRequest listMetadataAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetadataAomPromGetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMetadataAomPromGetResponse>(response);
        }

        public AsyncInvoker<ListMetadataAomPromGetResponse> ListMetadataAomPromGetAsyncInvoker(ListMetadataAomPromGetRequest listMetadataAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetadataAomPromGetRequest);
            return new AsyncInvoker<ListMetadataAomPromGetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMetadataAomPromGetResponse>);
        }
        
        /// <summary>
        /// 查询Prometheus实例
        ///
        /// 该接口用于查询Prometheus实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPromInstanceResponse> ListPromInstanceAsync(ListPromInstanceRequest listPromInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/prometheus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPromInstanceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPromInstanceResponse>(response);
        }

        public AsyncInvoker<ListPromInstanceResponse> ListPromInstanceAsyncInvoker(ListPromInstanceRequest listPromInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/prometheus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPromInstanceRequest);
            return new AsyncInvoker<ListPromInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPromInstanceResponse>);
        }
        
        /// <summary>
        /// 区间数据查询
        ///
        /// 该接口用于查询PromQL(Prometheus Query Language)在一段时间返回内的计算结果。（注：接口目前开放的region为：北京四、上海一和广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRangeQueryAomPromGetResponse> ListRangeQueryAomPromGetAsync(ListRangeQueryAomPromGetRequest listRangeQueryAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/query_range", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRangeQueryAomPromGetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRangeQueryAomPromGetResponse>(response);
        }

        public AsyncInvoker<ListRangeQueryAomPromGetResponse> ListRangeQueryAomPromGetAsyncInvoker(ListRangeQueryAomPromGetRequest listRangeQueryAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/query_range", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRangeQueryAomPromGetRequest);
            return new AsyncInvoker<ListRangeQueryAomPromGetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRangeQueryAomPromGetResponse>);
        }
        
        /// <summary>
        /// 区间数据查询
        ///
        /// 该接口用于查询PromQL(Prometheus Query Language)在一段时间返回内的计算结果。（注：接口目前开放的region为：北京四、上海一和广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRangeQueryAomPromPostResponse> ListRangeQueryAomPromPostAsync(ListRangeQueryAomPromPostRequest listRangeQueryAomPromPostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/query_range", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRangeQueryAomPromPostRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListRangeQueryAomPromPostResponse>(response);
        }

        public AsyncInvoker<ListRangeQueryAomPromPostResponse> ListRangeQueryAomPromPostAsyncInvoker(ListRangeQueryAomPromPostRequest listRangeQueryAomPromPostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/query_range", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRangeQueryAomPromPostRequest);
            return new AsyncInvoker<ListRangeQueryAomPromPostResponse>(this, "POST", request, JsonUtils.DeSerialize<ListRangeQueryAomPromPostResponse>);
        }
        
    }
}