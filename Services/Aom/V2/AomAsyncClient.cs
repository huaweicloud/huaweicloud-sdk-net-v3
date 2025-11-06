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
        /// 新增告警行动规则。
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
        /// 新增一条事件类告警规则。
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
        /// 新增静默规则。
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
        /// 添加或修改指标类或事件类告警规则
        ///
        /// 添加或修改AOM2.0指标类或事件类告警规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddOrUpdateMetricOrEventAlarmRuleResponse> AddOrUpdateMetricOrEventAlarmRuleAsync(AddOrUpdateMetricOrEventAlarmRuleRequest addOrUpdateMetricOrEventAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addOrUpdateMetricOrEventAlarmRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddOrUpdateMetricOrEventAlarmRuleResponse>(response);
        }

        public AsyncInvoker<AddOrUpdateMetricOrEventAlarmRuleResponse> AddOrUpdateMetricOrEventAlarmRuleAsyncInvoker(AddOrUpdateMetricOrEventAlarmRuleRequest addOrUpdateMetricOrEventAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addOrUpdateMetricOrEventAlarmRuleRequest);
            return new AsyncInvoker<AddOrUpdateMetricOrEventAlarmRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<AddOrUpdateMetricOrEventAlarmRuleResponse>);
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
        /// 批量更新Prometheus监控告警规则
        ///
        /// 该接口用于批量启停Prometheus监控告警规则、批量修改Prometheus监控告警规则的告警行动规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateAlarmRuleResponse> BatchUpdateAlarmRuleAsync(BatchUpdateAlarmRuleRequest batchUpdateAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/alarm-rules/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateAlarmRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateAlarmRuleResponse>(response);
        }

        public AsyncInvoker<BatchUpdateAlarmRuleResponse> BatchUpdateAlarmRuleAsyncInvoker(BatchUpdateAlarmRuleRequest batchUpdateAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/alarm-rules/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateAlarmRuleRequest);
            return new AsyncInvoker<BatchUpdateAlarmRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateAlarmRuleResponse>);
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
        /// 新增消息通知模板
        ///
        /// 该接口用于新增消息通知模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateNotificationTemplateResponse> CreateNotificationTemplateAsync(CreateNotificationTemplateRequest createNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNotificationTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateNotificationTemplateResponse>(response);
        }

        public AsyncInvoker<CreateNotificationTemplateResponse> CreateNotificationTemplateAsyncInvoker(CreateNotificationTemplateRequest createNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNotificationTemplateRequest);
            return new AsyncInvoker<CreateNotificationTemplateResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateNotificationTemplateResponse>);
        }
        
        /// <summary>
        /// 删除告警行动规则
        ///
        /// 删除告警行动规则。
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
            if (StringUtils.TryConvertToNonEmptyString(deleteAlarmRuleRequest.AlarmRuleId, out var valueOfAlarmRuleId)) urlParam.Add("alarm_rule_id", valueOfAlarmRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules/{alarm_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAlarmRuleResponse>(response);
        }

        public AsyncInvoker<DeleteAlarmRuleResponse> DeleteAlarmRuleAsyncInvoker(DeleteAlarmRuleRequest deleteAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAlarmRuleRequest.AlarmRuleId, out var valueOfAlarmRuleId)) urlParam.Add("alarm_rule_id", valueOfAlarmRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules/{alarm_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRuleRequest);
            return new AsyncInvoker<DeleteAlarmRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 删除告警模板
        ///
        /// 该接口用于删除告警模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAlarmRuleTemplateResponse> DeleteAlarmRuleTemplateAsync(DeleteAlarmRuleTemplateRequest deleteAlarmRuleTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/alarm-rules-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRuleTemplateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAlarmRuleTemplateResponse>(response);
        }

        public AsyncInvoker<DeleteAlarmRuleTemplateResponse> DeleteAlarmRuleTemplateAsyncInvoker(DeleteAlarmRuleTemplateRequest deleteAlarmRuleTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/alarm-rules-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRuleTemplateRequest);
            return new AsyncInvoker<DeleteAlarmRuleTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAlarmRuleTemplateResponse>);
        }
        
        /// <summary>
        /// 批量删除阈值规则
        ///
        /// 该接口用于批量删除阈值规则
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
        /// 删除仪表盘
        ///
        /// 该接口用于删除仪表盘。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDashboardResponse> DeleteDashboardAsync(DeleteDashboardRequest deleteDashboardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDashboardRequest.DashboardId, out var valueOfDashboardId)) urlParam.Add("dashboard_id", valueOfDashboardId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/aom/dashboards/{dashboard_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDashboardRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDashboardResponse>(response);
        }

        public AsyncInvoker<DeleteDashboardResponse> DeleteDashboardAsyncInvoker(DeleteDashboardRequest deleteDashboardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDashboardRequest.DashboardId, out var valueOfDashboardId)) urlParam.Add("dashboard_id", valueOfDashboardId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/aom/dashboards/{dashboard_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDashboardRequest);
            return new AsyncInvoker<DeleteDashboardResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDashboardResponse>);
        }
        
        /// <summary>
        /// 删除仪表盘分组
        ///
        /// 该接口用于删除仪表盘分组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDashboardsFolderResponse> DeleteDashboardsFolderAsync(DeleteDashboardsFolderRequest deleteDashboardsFolderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDashboardsFolderRequest.FolderId, out var valueOfFolderId)) urlParam.Add("folder_id", valueOfFolderId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/aom/dashboards-folder/{folder_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDashboardsFolderRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDashboardsFolderResponse>(response);
        }

        public AsyncInvoker<DeleteDashboardsFolderResponse> DeleteDashboardsFolderAsyncInvoker(DeleteDashboardsFolderRequest deleteDashboardsFolderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDashboardsFolderRequest.FolderId, out var valueOfFolderId)) urlParam.Add("folder_id", valueOfFolderId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/aom/dashboards-folder/{folder_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDashboardsFolderRequest);
            return new AsyncInvoker<DeleteDashboardsFolderResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDashboardsFolderResponse>);
        }
        
        /// <summary>
        /// 删除事件类告警规则
        ///
        /// 删除一条事件类告警规则。
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
        /// 删除指标类或事件类告警规则
        ///
        /// 删除AOM2.0指标类或事件类告警规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteMetricOrEventAlarmRuleResponse> DeleteMetricOrEventAlarmRuleAsync(DeleteMetricOrEventAlarmRuleRequest deleteMetricOrEventAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMetricOrEventAlarmRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteMetricOrEventAlarmRuleResponse>(response);
        }

        public AsyncInvoker<DeleteMetricOrEventAlarmRuleResponse> DeleteMetricOrEventAlarmRuleAsyncInvoker(DeleteMetricOrEventAlarmRuleRequest deleteMetricOrEventAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMetricOrEventAlarmRuleRequest);
            return new AsyncInvoker<DeleteMetricOrEventAlarmRuleResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteMetricOrEventAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 删除静默规则
        ///
        /// 删除静默规则。
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
        /// 删除消息通知模板
        ///
        /// 该接口用于删除消息通知模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteNotificationTemplateResponse> DeleteNotificationTemplateAsync(DeleteNotificationTemplateRequest deleteNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNotificationTemplateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNotificationTemplateResponse>(response);
        }

        public AsyncInvoker<DeleteNotificationTemplateResponse> DeleteNotificationTemplateAsyncInvoker(DeleteNotificationTemplateRequest deleteNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNotificationTemplateRequest);
            return new AsyncInvoker<DeleteNotificationTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteNotificationTemplateResponse>);
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
        /// 获取告警行动规则列表。
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
        /// 查询主机安装的ICAgent信息
        ///
        /// 该接口用于查询集群主机或用户自定义主机安装的ICAgent信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAgentsResponse> ListAgentsAsync(ListAgentsRequest listAgentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAgentsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(listAgentsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{cluster_id}/{namespace}/agents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerializeNull<ListAgentsResponse>(response);
        }

        public AsyncInvoker<ListAgentsResponse> ListAgentsAsyncInvoker(ListAgentsRequest listAgentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAgentsRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(listAgentsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
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
        /// 查询告警模板列表
        ///
        /// 该接口用于查询告警模板列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAlarmRuleTemplateResponse> ListAlarmRuleTemplateAsync(ListAlarmRuleTemplateRequest listAlarmRuleTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/alarm-rules-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRuleTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmRuleTemplateResponse>(response);
        }

        public AsyncInvoker<ListAlarmRuleTemplateResponse> ListAlarmRuleTemplateAsyncInvoker(ListAlarmRuleTemplateRequest listAlarmRuleTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/alarm-rules-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRuleTemplateRequest);
            return new AsyncInvoker<ListAlarmRuleTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmRuleTemplateResponse>);
        }
        
        /// <summary>
        /// 查询仪表盘列表
        ///
        /// 该接口用于查询仪表盘列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDashBoardsResponse> ListDashBoardsAsync(ListDashBoardsRequest listDashBoardsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/aom/dashboards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDashBoardsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDashBoardsResponse>(response);
        }

        public AsyncInvoker<ListDashBoardsResponse> ListDashBoardsAsyncInvoker(ListDashBoardsRequest listDashBoardsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/aom/dashboards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDashBoardsRequest);
            return new AsyncInvoker<ListDashBoardsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDashBoardsResponse>);
        }
        
        /// <summary>
        /// 查询仪表盘分组列表
        ///
        /// 该接口用于查询仪表盘分组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDashboardsFolderResponse> ListDashboardsFolderAsync(ListDashboardsFolderRequest listDashboardsFolderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/aom/dashboards-folder", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDashboardsFolderRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listDashboardsFolderResponse = JsonUtils.DeSerializeNull<ListDashboardsFolderResponse>(response);
            listDashboardsFolderResponse.Body = JsonUtils.DeSerializeList<DashBoardsFolder>(response);
            return listDashboardsFolderResponse;
        }

        public AsyncInvoker<ListDashboardsFolderResponse> ListDashboardsFolderAsyncInvoker(ListDashboardsFolderRequest listDashboardsFolderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/aom/dashboards-folder", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDashboardsFolderRequest);
            return new AsyncInvoker<ListDashboardsFolderResponse>(this, "GET", request, response =>
            {
                var listDashboardsFolderResponse = JsonUtils.DeSerializeNull<ListDashboardsFolderResponse>(response);
                listDashboardsFolderResponse.Body = JsonUtils.DeSerializeList<DashBoardsFolder>(response);
                return listDashboardsFolderResponse;
            });
        }
        
        /// <summary>
        /// 查询事件类告警规则列表
        ///
        /// 查询事件类告警规则列表。
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
        /// 查询指标类或者事件类告警规则列表
        ///
        /// 查询AOM2.0指标类或者事件类告警规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMetricOrEventAlarmRuleResponse> ListMetricOrEventAlarmRuleAsync(ListMetricOrEventAlarmRuleRequest listMetricOrEventAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricOrEventAlarmRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMetricOrEventAlarmRuleResponse>(response);
        }

        public AsyncInvoker<ListMetricOrEventAlarmRuleResponse> ListMetricOrEventAlarmRuleAsyncInvoker(ListMetricOrEventAlarmRuleRequest listMetricOrEventAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/alarm-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricOrEventAlarmRuleRequest);
            return new AsyncInvoker<ListMetricOrEventAlarmRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMetricOrEventAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 获取静默规则列表
        ///
        /// 获取静默规则列表。
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
        /// 根据消息通知模板名称查询消息通知模板
        ///
        /// 该接口用于根据消息通知模板名称查询消息通知模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNotificationTemplateByNameResponse> ListNotificationTemplateByNameAsync(ListNotificationTemplateByNameRequest listNotificationTemplateByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNotificationTemplateByNameRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/events/notification/template/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationTemplateByNameRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNotificationTemplateByNameResponse>(response);
        }

        public AsyncInvoker<ListNotificationTemplateByNameResponse> ListNotificationTemplateByNameAsyncInvoker(ListNotificationTemplateByNameRequest listNotificationTemplateByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNotificationTemplateByNameRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/events/notification/template/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationTemplateByNameRequest);
            return new AsyncInvoker<ListNotificationTemplateByNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNotificationTemplateByNameResponse>);
        }
        
        /// <summary>
        /// 查询消息通知模板列表
        ///
        /// 该接口用于查询消息通知模板列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNotificationTemplatesResponse> ListNotificationTemplatesAsync(ListNotificationTemplatesRequest listNotificationTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listNotificationTemplatesResponse = JsonUtils.DeSerializeNull<ListNotificationTemplatesResponse>(response);
            listNotificationTemplatesResponse.Body = JsonUtils.DeSerializeList<NotificationTemplate>(response);
            return listNotificationTemplatesResponse;
        }

        public AsyncInvoker<ListNotificationTemplatesResponse> ListNotificationTemplatesAsyncInvoker(ListNotificationTemplatesRequest listNotificationTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationTemplatesRequest);
            return new AsyncInvoker<ListNotificationTemplatesResponse>(this, "GET", request, response =>
            {
                var listNotificationTemplatesResponse = JsonUtils.DeSerializeNull<ListNotificationTemplatesResponse>(response);
                listNotificationTemplatesResponse.Body = JsonUtils.DeSerializeList<NotificationTemplate>(response);
                return listNotificationTemplatesResponse;
            });
        }
        
        /// <summary>
        /// 获取告警发送结果
        ///
        /// 获取告警发送结果。
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
        /// 上报事件或告警信息
        ///
        /// 该接口用于上报事件或告警至AOM，同时支持清除告警信息。
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
        /// 通过规则名称获取告警行动规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowActionRuleResponse> ShowActionRuleAsync(ShowActionRuleRequest showActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showActionRuleRequest.RuleName, out var valueOfRuleName)) urlParam.Add("rule_name", valueOfRuleName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alert/action-rules/{rule_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActionRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowActionRuleResponse>(response);
        }

        public AsyncInvoker<ShowActionRuleResponse> ShowActionRuleAsyncInvoker(ShowActionRuleRequest showActionRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showActionRuleRequest.RuleName, out var valueOfRuleName)) urlParam.Add("rule_name", valueOfRuleName);
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
            if (StringUtils.TryConvertToNonEmptyString(showAlarmRuleRequest.AlarmRuleId, out var valueOfAlarmRuleId)) urlParam.Add("alarm_rule_id", valueOfAlarmRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules/{alarm_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAlarmRuleResponse>(response);
        }

        public AsyncInvoker<ShowAlarmRuleResponse> ShowAlarmRuleAsyncInvoker(ShowAlarmRuleRequest showAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAlarmRuleRequest.AlarmRuleId, out var valueOfAlarmRuleId)) urlParam.Add("alarm_rule_id", valueOfAlarmRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-rules/{alarm_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmRuleRequest);
            return new AsyncInvoker<ShowAlarmRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 查询仪表盘详情
        ///
        /// 该接口用于查询仪表盘详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDashBoardResponse> ShowDashBoardAsync(ShowDashBoardRequest showDashBoardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDashBoardRequest.DashboardId, out var valueOfDashboardId)) urlParam.Add("dashboard_id", valueOfDashboardId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/aom/dashboards/{dashboard_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDashBoardRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDashBoardResponse>(response);
        }

        public AsyncInvoker<ShowDashBoardResponse> ShowDashBoardAsyncInvoker(ShowDashBoardRequest showDashBoardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDashBoardRequest.DashboardId, out var valueOfDashboardId)) urlParam.Add("dashboard_id", valueOfDashboardId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/aom/dashboards/{dashboard_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDashBoardRequest);
            return new AsyncInvoker<ShowDashBoardResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDashBoardResponse>);
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
        /// 修改告警行动规则。
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
        /// 更新事件类告警规则。
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
        /// 修改静默规则。
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
        /// 修改消息通知模板
        ///
        /// 该接口用于修改消息通知模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateNotificationTemplateResponse> UpdateNotificationTemplateAsync(UpdateNotificationTemplateRequest updateNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNotificationTemplateRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateNotificationTemplateResponse>(response);
        }

        public AsyncInvoker<UpdateNotificationTemplateResponse> UpdateNotificationTemplateAsyncInvoker(UpdateNotificationTemplateRequest updateNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNotificationTemplateRequest);
            return new AsyncInvoker<UpdateNotificationTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateNotificationTemplateResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(createRecordingRuleRequest.PrometheusInstance, out var valueOfPrometheusInstance)) urlParam.Add("prometheus_instance", valueOfPrometheusInstance);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{prometheus_instance}/aom/api/v1/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordingRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateRecordingRuleResponse>(response);
        }

        public AsyncInvoker<CreateRecordingRuleResponse> CreateRecordingRuleAsyncInvoker(CreateRecordingRuleRequest createRecordingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRecordingRuleRequest.PrometheusInstance, out var valueOfPrometheusInstance)) urlParam.Add("prometheus_instance", valueOfPrometheusInstance);
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
            var deletePromInstanceResponse = JsonUtils.DeSerializeNull<DeletePromInstanceResponse>(response);
            deletePromInstanceResponse.Body = JsonUtils.DeSerializeMap<string, bool?>(response);
            return deletePromInstanceResponse;
        }

        public AsyncInvoker<DeletePromInstanceResponse> DeletePromInstanceAsyncInvoker(DeletePromInstanceRequest deletePromInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/prometheus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePromInstanceRequest);
            return new AsyncInvoker<DeletePromInstanceResponse>(this, "DELETE", request, response =>
            {
                var deletePromInstanceResponse = JsonUtils.DeSerializeNull<DeletePromInstanceResponse>(response);
                deletePromInstanceResponse.Body = JsonUtils.DeSerializeMap<string, bool?>(response);
                return deletePromInstanceResponse;
            });
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
        /// GET方法查询瞬时数据
        ///
        /// 该接口使用GET方法查询PromQL(Prometheus Query Language)在特定时间点下的计算结果。
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
        /// （推荐）POST方法查询瞬时数据
        ///
        /// 该接口使用POST方法查询PromQL(Prometheus Query Language) 在特定时间点下的计算结果。
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
        /// 该接口用于查询带有指定标签的时间序列列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLabelValuesAomPromGetResponse> ListLabelValuesAomPromGetAsync(ListLabelValuesAomPromGetRequest listLabelValuesAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLabelValuesAomPromGetRequest.LabelName, out var valueOfLabelName)) urlParam.Add("label_name", valueOfLabelName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/label/{label_name}/values", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLabelValuesAomPromGetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLabelValuesAomPromGetResponse>(response);
        }

        public AsyncInvoker<ListLabelValuesAomPromGetResponse> ListLabelValuesAomPromGetAsyncInvoker(ListLabelValuesAomPromGetRequest listLabelValuesAomPromGetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLabelValuesAomPromGetRequest.LabelName, out var valueOfLabelName)) urlParam.Add("label_name", valueOfLabelName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/api/v1/label/{label_name}/values", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLabelValuesAomPromGetRequest);
            return new AsyncInvoker<ListLabelValuesAomPromGetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLabelValuesAomPromGetResponse>);
        }
        
        /// <summary>
        /// GET方法获取标签名列表
        ///
        /// 该接口使用GET方法获取标签名列表。
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
        /// （推荐）POST方法获取标签名列表
        ///
        /// 该接口使用POST方法获取标签名列表。
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
        /// 该接口用于查询序列及序列标签的元数据。
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
        /// GET方法查询区间数据
        ///
        /// 该接口使用GET方法查询PromQL(Prometheus Query Language)在一段时间返回内的计算结果。
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
        /// （推荐）POST方法查询区间数据
        ///
        /// 该接口使用POST方法查询PromQL(Prometheus Query Language)在一段时间返回内的计算结果。
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
        
        /// <summary>
        /// 修改Prometheus实例
        ///
        /// 该接口用于修改Prometheus实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePromInstanceResponse> UpdatePromInstanceAsync(UpdatePromInstanceRequest updatePromInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/prometheus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePromInstanceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePromInstanceResponse>(response);
        }

        public AsyncInvoker<UpdatePromInstanceResponse> UpdatePromInstanceAsyncInvoker(UpdatePromInstanceRequest updatePromInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aom/prometheus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePromInstanceRequest);
            return new AsyncInvoker<UpdatePromInstanceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePromInstanceResponse>);
        }
        
    }
}