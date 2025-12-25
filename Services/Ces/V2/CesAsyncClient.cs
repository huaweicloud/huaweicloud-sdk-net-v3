using System;
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
        /// 批量增加告警规则资源
        ///
        /// 批量增加告警规则资源(资源分组类型的告警规则不支持)，资源分组类型的修改请使用资源分组管理相关接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddAlarmRuleResourcesResponse> AddAlarmRuleResourcesAsync(AddAlarmRuleResourcesRequest addAlarmRuleResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addAlarmRuleResourcesRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAlarmRuleResourcesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddAlarmRuleResourcesResponse>(response);
        }

        public AsyncInvoker<AddAlarmRuleResourcesResponse> AddAlarmRuleResourcesAsyncInvoker(AddAlarmRuleResourcesRequest addAlarmRuleResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addAlarmRuleResourcesRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAlarmRuleResourcesRequest);
            return new AsyncInvoker<AddAlarmRuleResourcesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddAlarmRuleResourcesResponse>);
        }
        
        /// <summary>
        /// 自定义资源分组批量增加关联资源
        ///
        /// 给自定义资源分组,即类型为手动添加的资源分组,批量增加关联资源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateResourcesResponse> BatchCreateResourcesAsync(BatchCreateResourcesRequest batchCreateResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateResourcesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/resources/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateResourcesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateResourcesResponse>(response);
        }

        public AsyncInvoker<BatchCreateResourcesResponse> BatchCreateResourcesAsyncInvoker(BatchCreateResourcesRequest batchCreateResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateResourcesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/resources/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateResourcesRequest);
            return new AsyncInvoker<BatchCreateResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateResourcesResponse>);
        }
        
        /// <summary>
        /// 批量删除告警规则
        ///
        /// 批量删除告警规则V2接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteAlarmRulesResponse> BatchDeleteAlarmRulesAsync(BatchDeleteAlarmRulesRequest batchDeleteAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAlarmRulesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteAlarmRulesResponse>(response);
        }

        public AsyncInvoker<BatchDeleteAlarmRulesResponse> BatchDeleteAlarmRulesAsyncInvoker(BatchDeleteAlarmRulesRequest batchDeleteAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAlarmRulesRequest);
            return new AsyncInvoker<BatchDeleteAlarmRulesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteAlarmRulesResponse>);
        }
        
        /// <summary>
        /// 批量删除自定义告警模板
        ///
        /// 批量删除自定义告警模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteAlarmTemplatesResponse> BatchDeleteAlarmTemplatesAsync(BatchDeleteAlarmTemplatesRequest batchDeleteAlarmTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAlarmTemplatesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteAlarmTemplatesResponse>(response);
        }

        public AsyncInvoker<BatchDeleteAlarmTemplatesResponse> BatchDeleteAlarmTemplatesAsyncInvoker(BatchDeleteAlarmTemplatesRequest batchDeleteAlarmTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAlarmTemplatesRequest);
            return new AsyncInvoker<BatchDeleteAlarmTemplatesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteAlarmTemplatesResponse>);
        }
        
        /// <summary>
        /// 批量删除告警通知屏蔽规则
        ///
        /// 批量删除告警通知屏蔽规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteNotificationMasksResponse> BatchDeleteNotificationMasksAsync(BatchDeleteNotificationMasksRequest batchDeleteNotificationMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteNotificationMasksRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteNotificationMasksResponse>(response);
        }

        public AsyncInvoker<BatchDeleteNotificationMasksResponse> BatchDeleteNotificationMasksAsyncInvoker(BatchDeleteNotificationMasksRequest batchDeleteNotificationMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteNotificationMasksRequest);
            return new AsyncInvoker<BatchDeleteNotificationMasksResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteNotificationMasksResponse>);
        }
        
        /// <summary>
        /// 批量删除一键告警
        ///
        /// 批量删除一键告警
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteOneClickAlarmsResponse> BatchDeleteOneClickAlarmsAsync(BatchDeleteOneClickAlarmsRequest batchDeleteOneClickAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteOneClickAlarmsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteOneClickAlarmsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteOneClickAlarmsResponse> BatchDeleteOneClickAlarmsAsyncInvoker(BatchDeleteOneClickAlarmsRequest batchDeleteOneClickAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteOneClickAlarmsRequest);
            return new AsyncInvoker<BatchDeleteOneClickAlarmsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteOneClickAlarmsResponse>);
        }
        
        /// <summary>
        /// 批量删除资源分组
        ///
        /// 批量删除资源分组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteResourceGroupsResponse> BatchDeleteResourceGroupsAsync(BatchDeleteResourceGroupsRequest batchDeleteResourceGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteResourceGroupsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteResourceGroupsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteResourceGroupsResponse> BatchDeleteResourceGroupsAsyncInvoker(BatchDeleteResourceGroupsRequest batchDeleteResourceGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteResourceGroupsRequest);
            return new AsyncInvoker<BatchDeleteResourceGroupsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteResourceGroupsResponse>);
        }
        
        /// <summary>
        /// 自定义资源分组批量删除关联资源
        ///
        /// 给自定义资源分组,即类型为手动添加的资源分组,批量删除关联资源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteResourcesResponse> BatchDeleteResourcesAsync(BatchDeleteResourcesRequest batchDeleteResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteResourcesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/resources/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteResourcesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteResourcesResponse>(response);
        }

        public AsyncInvoker<BatchDeleteResourcesResponse> BatchDeleteResourcesAsyncInvoker(BatchDeleteResourcesRequest batchDeleteResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteResourcesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/resources/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteResourcesRequest);
            return new AsyncInvoker<BatchDeleteResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteResourcesResponse>);
        }
        
        /// <summary>
        /// 批量启停告警规则
        ///
        /// 批量启停告警规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchEnableAlarmRulesResponse> BatchEnableAlarmRulesAsync(BatchEnableAlarmRulesRequest batchEnableAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchEnableAlarmRulesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchEnableAlarmRulesResponse>(response);
        }

        public AsyncInvoker<BatchEnableAlarmRulesResponse> BatchEnableAlarmRulesAsyncInvoker(BatchEnableAlarmRulesRequest batchEnableAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchEnableAlarmRulesRequest);
            return new AsyncInvoker<BatchEnableAlarmRulesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchEnableAlarmRulesResponse>);
        }
        
        /// <summary>
        /// 批量查询指标数据
        ///
        /// 批量查询指标数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchListSpecifiedMetricDataResponse> BatchListSpecifiedMetricDataAsync(BatchListSpecifiedMetricDataRequest batchListSpecifiedMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batch-query-metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListSpecifiedMetricDataRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchListSpecifiedMetricDataResponse>(response);
        }

        public AsyncInvoker<BatchListSpecifiedMetricDataResponse> BatchListSpecifiedMetricDataAsyncInvoker(BatchListSpecifiedMetricDataRequest batchListSpecifiedMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batch-query-metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListSpecifiedMetricDataRequest);
            return new AsyncInvoker<BatchListSpecifiedMetricDataResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchListSpecifiedMetricDataResponse>);
        }
        
        /// <summary>
        /// 批量修改告警通知屏蔽规则的屏蔽时间
        ///
        /// 批量修改告警通知屏蔽规则的屏蔽时间
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateNotificationMaskTimeResponse> BatchUpdateNotificationMaskTimeAsync(BatchUpdateNotificationMaskTimeRequest batchUpdateNotificationMaskTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateNotificationMaskTimeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchUpdateNotificationMaskTimeResponse>(response);
        }

        public AsyncInvoker<BatchUpdateNotificationMaskTimeResponse> BatchUpdateNotificationMaskTimeAsyncInvoker(BatchUpdateNotificationMaskTimeRequest batchUpdateNotificationMaskTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateNotificationMaskTimeRequest);
            return new AsyncInvoker<BatchUpdateNotificationMaskTimeResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchUpdateNotificationMaskTimeResponse>);
        }
        
        /// <summary>
        /// 批量设置告警通知屏蔽规则
        ///
        /// 批量设置告警通知屏蔽规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateNotificationMasksResponse> BatchUpdateNotificationMasksAsync(BatchUpdateNotificationMasksRequest batchUpdateNotificationMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateNotificationMasksRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateNotificationMasksResponse>(response);
        }

        public AsyncInvoker<BatchUpdateNotificationMasksResponse> BatchUpdateNotificationMasksAsyncInvoker(BatchUpdateNotificationMasksRequest batchUpdateNotificationMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateNotificationMasksRequest);
            return new AsyncInvoker<BatchUpdateNotificationMasksResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateNotificationMasksResponse>);
        }
        
        /// <summary>
        /// 批量修改一键告警关联告警规则策略的启用状态
        ///
        /// 批量修改一键告警关联告警规则策略的启用状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateOneClickAlarmPoliciesEnabledStateResponse> BatchUpdateOneClickAlarmPoliciesEnabledStateAsync(BatchUpdateOneClickAlarmPoliciesEnabledStateRequest batchUpdateOneClickAlarmPoliciesEnabledStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateOneClickAlarmPoliciesEnabledStateRequest.OneClickAlarmId, out var valueOfOneClickAlarmId)) urlParam.Add("one_click_alarm_id", valueOfOneClickAlarmId);
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateOneClickAlarmPoliciesEnabledStateRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/{one_click_alarm_id}/alarms/{alarm_id}/policies/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateOneClickAlarmPoliciesEnabledStateRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateOneClickAlarmPoliciesEnabledStateResponse>(response);
        }

        public AsyncInvoker<BatchUpdateOneClickAlarmPoliciesEnabledStateResponse> BatchUpdateOneClickAlarmPoliciesEnabledStateAsyncInvoker(BatchUpdateOneClickAlarmPoliciesEnabledStateRequest batchUpdateOneClickAlarmPoliciesEnabledStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateOneClickAlarmPoliciesEnabledStateRequest.OneClickAlarmId, out var valueOfOneClickAlarmId)) urlParam.Add("one_click_alarm_id", valueOfOneClickAlarmId);
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateOneClickAlarmPoliciesEnabledStateRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/{one_click_alarm_id}/alarms/{alarm_id}/policies/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateOneClickAlarmPoliciesEnabledStateRequest);
            return new AsyncInvoker<BatchUpdateOneClickAlarmPoliciesEnabledStateResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateOneClickAlarmPoliciesEnabledStateResponse>);
        }
        
        /// <summary>
        /// 批量修改一键告警关联告警规则的启用状态
        ///
        /// 批量修改一键告警关联告警规则的启用状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateOneClickAlarmsEnabledStateResponse> BatchUpdateOneClickAlarmsEnabledStateAsync(BatchUpdateOneClickAlarmsEnabledStateRequest batchUpdateOneClickAlarmsEnabledStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateOneClickAlarmsEnabledStateRequest.OneClickAlarmId, out var valueOfOneClickAlarmId)) urlParam.Add("one_click_alarm_id", valueOfOneClickAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/{one_click_alarm_id}/alarm-rules/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateOneClickAlarmsEnabledStateRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateOneClickAlarmsEnabledStateResponse>(response);
        }

        public AsyncInvoker<BatchUpdateOneClickAlarmsEnabledStateResponse> BatchUpdateOneClickAlarmsEnabledStateAsyncInvoker(BatchUpdateOneClickAlarmsEnabledStateRequest batchUpdateOneClickAlarmsEnabledStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateOneClickAlarmsEnabledStateRequest.OneClickAlarmId, out var valueOfOneClickAlarmId)) urlParam.Add("one_click_alarm_id", valueOfOneClickAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/{one_click_alarm_id}/alarm-rules/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateOneClickAlarmsEnabledStateRequest);
            return new AsyncInvoker<BatchUpdateOneClickAlarmsEnabledStateResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateOneClickAlarmsEnabledStateResponse>);
        }
        
        /// <summary>
        /// 批量更新监控视图
        ///
        /// 批量更新监控视图
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateWidgetsResponse> BatchUpdateWidgetsAsync(BatchUpdateWidgetsRequest batchUpdateWidgetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/widgets/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateWidgetsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchUpdateWidgetsResponse>(response);
        }

        public AsyncInvoker<BatchUpdateWidgetsResponse> BatchUpdateWidgetsAsyncInvoker(BatchUpdateWidgetsRequest batchUpdateWidgetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/widgets/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateWidgetsRequest);
            return new AsyncInvoker<BatchUpdateWidgetsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchUpdateWidgetsResponse>);
        }
        
        /// <summary>
        /// 创建告警规则（推荐）
        ///
        /// 创建告警规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAlarmRulesResponse> CreateAlarmRulesAsync(CreateAlarmRulesRequest createAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmRulesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAlarmRulesResponse>(response);
        }

        public AsyncInvoker<CreateAlarmRulesResponse> CreateAlarmRulesAsyncInvoker(CreateAlarmRulesRequest createAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmRulesRequest);
            return new AsyncInvoker<CreateAlarmRulesResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAlarmRulesResponse>);
        }
        
        /// <summary>
        /// 创建自定义告警模板
        ///
        /// 创建自定义告警模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAlarmTemplateResponse> CreateAlarmTemplateAsync(CreateAlarmTemplateRequest createAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAlarmTemplateResponse>(response);
        }

        public AsyncInvoker<CreateAlarmTemplateResponse> CreateAlarmTemplateAsyncInvoker(CreateAlarmTemplateRequest createAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmTemplateRequest);
            return new AsyncInvoker<CreateAlarmTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAlarmTemplateResponse>);
        }
        
        /// <summary>
        /// 创建/复制/批量创建监控视图到指定的监控看板
        ///
        /// 创建/复制/批量创建监控视图到指定的监控看板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDashboardWidgetsResponse> CreateDashboardWidgetsAsync(CreateDashboardWidgetsRequest createDashboardWidgetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDashboardWidgetsRequest.DashboardId, out var valueOfDashboardId)) urlParam.Add("dashboard_id", valueOfDashboardId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards/{dashboard_id}/widgets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDashboardWidgetsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDashboardWidgetsResponse>(response);
        }

        public AsyncInvoker<CreateDashboardWidgetsResponse> CreateDashboardWidgetsAsyncInvoker(CreateDashboardWidgetsRequest createDashboardWidgetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDashboardWidgetsRequest.DashboardId, out var valueOfDashboardId)) urlParam.Add("dashboard_id", valueOfDashboardId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards/{dashboard_id}/widgets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDashboardWidgetsRequest);
            return new AsyncInvoker<CreateDashboardWidgetsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDashboardWidgetsResponse>);
        }
        
        /// <summary>
        /// 创建一键告警
        ///
        /// 创建一键告警
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateOneClickAlarmResponse> CreateOneClickAlarmAsync(CreateOneClickAlarmRequest createOneClickAlarmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOneClickAlarmRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateOneClickAlarmResponse>(response);
        }

        public AsyncInvoker<CreateOneClickAlarmResponse> CreateOneClickAlarmAsyncInvoker(CreateOneClickAlarmRequest createOneClickAlarmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOneClickAlarmRequest);
            return new AsyncInvoker<CreateOneClickAlarmResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOneClickAlarmResponse>);
        }
        
        /// <summary>
        /// 创建/复制监控看板
        ///
        /// 创建/复制监控看板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateOneDashboardResponse> CreateOneDashboardAsync(CreateOneDashboardRequest createOneDashboardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOneDashboardRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateOneDashboardResponse>(response);
        }

        public AsyncInvoker<CreateOneDashboardResponse> CreateOneDashboardAsyncInvoker(CreateOneDashboardRequest createOneDashboardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOneDashboardRequest);
            return new AsyncInvoker<CreateOneDashboardResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOneDashboardResponse>);
        }
        
        /// <summary>
        /// 创建资源分组（推荐）
        ///
        /// 创建资源分组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateResourceGroupResponse> CreateResourceGroupAsync(CreateResourceGroupRequest createResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateResourceGroupResponse>(response);
        }

        public AsyncInvoker<CreateResourceGroupResponse> CreateResourceGroupAsyncInvoker(CreateResourceGroupRequest createResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceGroupRequest);
            return new AsyncInvoker<CreateResourceGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateResourceGroupResponse>);
        }
        
        /// <summary>
        /// 批量删除告警规则资源
        ///
        /// 批量删除告警规则资源（资源分组类型的告警规则不支持），资源分组类型的修改请使用资源分组管理相关接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAlarmRuleResourcesResponse> DeleteAlarmRuleResourcesAsync(DeleteAlarmRuleResourcesRequest deleteAlarmRuleResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAlarmRuleResourcesRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRuleResourcesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteAlarmRuleResourcesResponse>(response);
        }

        public AsyncInvoker<DeleteAlarmRuleResourcesResponse> DeleteAlarmRuleResourcesAsyncInvoker(DeleteAlarmRuleResourcesRequest deleteAlarmRuleResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAlarmRuleResourcesRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRuleResourcesRequest);
            return new AsyncInvoker<DeleteAlarmRuleResourcesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteAlarmRuleResourcesResponse>);
        }
        
        /// <summary>
        /// 批量删除监控看板
        ///
        /// 批量删除监控看板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDashboardsResponse> DeleteDashboardsAsync(DeleteDashboardsRequest deleteDashboardsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDashboardsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DeleteDashboardsResponse>(response);
        }

        public AsyncInvoker<DeleteDashboardsResponse> DeleteDashboardsAsyncInvoker(DeleteDashboardsRequest deleteDashboardsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDashboardsRequest);
            return new AsyncInvoker<DeleteDashboardsResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteDashboardsResponse>);
        }
        
        /// <summary>
        /// 删除指定监控视图
        ///
        /// 删除指定监控视图
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteOneWidgetResponse> DeleteOneWidgetAsync(DeleteOneWidgetRequest deleteOneWidgetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOneWidgetRequest.WidgetId, out var valueOfWidgetId)) urlParam.Add("widget_id", valueOfWidgetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/widgets/{widget_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOneWidgetRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteOneWidgetResponse>(response);
        }

        public AsyncInvoker<DeleteOneWidgetResponse> DeleteOneWidgetAsyncInvoker(DeleteOneWidgetRequest deleteOneWidgetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOneWidgetRequest.WidgetId, out var valueOfWidgetId)) urlParam.Add("widget_id", valueOfWidgetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/widgets/{widget_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOneWidgetRequest);
            return new AsyncInvoker<DeleteOneWidgetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteOneWidgetResponse>);
        }
        
        /// <summary>
        /// 查询主机监控原始维度值
        ///
        /// 根据ECS/BMS资源ID及特殊维度值(仅支持磁盘、挂载点、进程、显卡、RAID控制器)查询该特殊维度对应的原始维度值；其他维度无需调用该接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAgentDimensionInfoResponse> ListAgentDimensionInfoAsync(ListAgentDimensionInfoRequest listAgentDimensionInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAgentDimensionInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/agent-dimensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentDimensionInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAgentDimensionInfoResponse>(response);
        }

        public AsyncInvoker<ListAgentDimensionInfoResponse> ListAgentDimensionInfoAsyncInvoker(ListAgentDimensionInfoRequest listAgentDimensionInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAgentDimensionInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/agent-dimensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentDimensionInfoRequest);
            return new AsyncInvoker<ListAgentDimensionInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAgentDimensionInfoResponse>);
        }
        
        /// <summary>
        /// 查询告警记录列表
        ///
        /// 查询告警记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAlarmHistoriesResponse> ListAlarmHistoriesAsync(ListAlarmHistoriesRequest listAlarmHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmHistoriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmHistoriesResponse>(response);
        }

        public AsyncInvoker<ListAlarmHistoriesResponse> ListAlarmHistoriesAsyncInvoker(ListAlarmHistoriesRequest listAlarmHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmHistoriesRequest);
            return new AsyncInvoker<ListAlarmHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmHistoriesResponse>);
        }
        
        /// <summary>
        /// 查询告警规则策略列表
        ///
        /// 根据告警规则ID查询策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAlarmRulePoliciesResponse> ListAlarmRulePoliciesAsync(ListAlarmRulePoliciesRequest listAlarmRulePoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmRulePoliciesRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRulePoliciesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmRulePoliciesResponse>(response);
        }

        public AsyncInvoker<ListAlarmRulePoliciesResponse> ListAlarmRulePoliciesAsyncInvoker(ListAlarmRulePoliciesRequest listAlarmRulePoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmRulePoliciesRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRulePoliciesRequest);
            return new AsyncInvoker<ListAlarmRulePoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmRulePoliciesResponse>);
        }
        
        /// <summary>
        /// 查询告警规则资源列表
        ///
        /// 根据告警规则ID查询告警规则资源列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAlarmRuleResourcesResponse> ListAlarmRuleResourcesAsync(ListAlarmRuleResourcesRequest listAlarmRuleResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmRuleResourcesRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRuleResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmRuleResourcesResponse>(response);
        }

        public AsyncInvoker<ListAlarmRuleResourcesResponse> ListAlarmRuleResourcesAsyncInvoker(ListAlarmRuleResourcesRequest listAlarmRuleResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmRuleResourcesRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRuleResourcesRequest);
            return new AsyncInvoker<ListAlarmRuleResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmRuleResourcesResponse>);
        }
        
        /// <summary>
        /// 查询告警规则列表（推荐）
        ///
        /// 查询告警规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAlarmRulesResponse> ListAlarmRulesAsync(ListAlarmRulesRequest listAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmRulesResponse>(response);
        }

        public AsyncInvoker<ListAlarmRulesResponse> ListAlarmRulesAsyncInvoker(ListAlarmRulesRequest listAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRulesRequest);
            return new AsyncInvoker<ListAlarmRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmRulesResponse>);
        }
        
        /// <summary>
        /// 查询告警模板关联的告警规则列表
        ///
        /// 查询告警模板关联的告警规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAlarmTemplateAssociationAlarmsResponse> ListAlarmTemplateAssociationAlarmsAsync(ListAlarmTemplateAssociationAlarmsRequest listAlarmTemplateAssociationAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmTemplateAssociationAlarmsRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates/{template_id}/association-alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTemplateAssociationAlarmsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmTemplateAssociationAlarmsResponse>(response);
        }

        public AsyncInvoker<ListAlarmTemplateAssociationAlarmsResponse> ListAlarmTemplateAssociationAlarmsAsyncInvoker(ListAlarmTemplateAssociationAlarmsRequest listAlarmTemplateAssociationAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmTemplateAssociationAlarmsRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates/{template_id}/association-alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTemplateAssociationAlarmsRequest);
            return new AsyncInvoker<ListAlarmTemplateAssociationAlarmsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmTemplateAssociationAlarmsResponse>);
        }
        
        /// <summary>
        /// 查询告警模板列表
        ///
        /// 查询告警模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAlarmTemplatesResponse> ListAlarmTemplatesAsync(ListAlarmTemplatesRequest listAlarmTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmTemplatesResponse>(response);
        }

        public AsyncInvoker<ListAlarmTemplatesResponse> ListAlarmTemplatesAsyncInvoker(ListAlarmTemplatesRequest listAlarmTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTemplatesRequest);
            return new AsyncInvoker<ListAlarmTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询CES指定项目指定资源类型标签列表
        ///
        /// 查询CES指定项目指定资源类型标签列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCesTargetProjectTagsResponse> ListCesTargetProjectTagsAsync(ListCesTargetProjectTagsRequest listCesTargetProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCesTargetProjectTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCesTargetProjectTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCesTargetProjectTagsResponse>(response);
        }

        public AsyncInvoker<ListCesTargetProjectTagsResponse> ListCesTargetProjectTagsAsyncInvoker(ListCesTargetProjectTagsRequest listCesTargetProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCesTargetProjectTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCesTargetProjectTagsRequest);
            return new AsyncInvoker<ListCesTargetProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCesTargetProjectTagsResponse>);
        }
        
        /// <summary>
        /// 查询监控看板列表
        ///
        /// 查询监控看板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDashboardInfosResponse> ListDashboardInfosAsync(ListDashboardInfosRequest listDashboardInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDashboardInfosRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDashboardInfosResponse>(response);
        }

        public AsyncInvoker<ListDashboardInfosResponse> ListDashboardInfosAsyncInvoker(ListDashboardInfosRequest listDashboardInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDashboardInfosRequest);
            return new AsyncInvoker<ListDashboardInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDashboardInfosResponse>);
        }
        
        /// <summary>
        /// 查询指定监控看板下的监控视图列表
        ///
        /// 查询指定监控看板下的监控视图列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDashboardWidgetsResponse> ListDashboardWidgetsAsync(ListDashboardWidgetsRequest listDashboardWidgetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDashboardWidgetsRequest.DashboardId, out var valueOfDashboardId)) urlParam.Add("dashboard_id", valueOfDashboardId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards/{dashboard_id}/widgets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDashboardWidgetsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDashboardWidgetsResponse>(response);
        }

        public AsyncInvoker<ListDashboardWidgetsResponse> ListDashboardWidgetsAsyncInvoker(ListDashboardWidgetsRequest listDashboardWidgetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDashboardWidgetsRequest.DashboardId, out var valueOfDashboardId)) urlParam.Add("dashboard_id", valueOfDashboardId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards/{dashboard_id}/widgets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDashboardWidgetsRequest);
            return new AsyncInvoker<ListDashboardWidgetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDashboardWidgetsResponse>);
        }
        
        /// <summary>
        /// 查询告警通知屏蔽资源列表
        ///
        /// 查询告警通知屏蔽资源列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNotificationMaskResourcesResponse> ListNotificationMaskResourcesAsync(ListNotificationMaskResourcesRequest listNotificationMaskResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNotificationMaskResourcesRequest.NotificationMaskId, out var valueOfNotificationMaskId)) urlParam.Add("notification_mask_id", valueOfNotificationMaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/{notification_mask_id}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationMaskResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNotificationMaskResourcesResponse>(response);
        }

        public AsyncInvoker<ListNotificationMaskResourcesResponse> ListNotificationMaskResourcesAsyncInvoker(ListNotificationMaskResourcesRequest listNotificationMaskResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNotificationMaskResourcesRequest.NotificationMaskId, out var valueOfNotificationMaskId)) urlParam.Add("notification_mask_id", valueOfNotificationMaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/{notification_mask_id}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationMaskResourcesRequest);
            return new AsyncInvoker<ListNotificationMaskResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNotificationMaskResourcesResponse>);
        }
        
        /// <summary>
        /// 查询告警通知屏蔽列表
        ///
        /// 批量查询指定类型的通知屏蔽规则，目前最多支持100个通知屏蔽规则的批量查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNotificationMasksResponse> ListNotificationMasksAsync(ListNotificationMasksRequest listNotificationMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationMasksRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListNotificationMasksResponse>(response);
        }

        public AsyncInvoker<ListNotificationMasksResponse> ListNotificationMasksAsyncInvoker(ListNotificationMasksRequest listNotificationMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationMasksRequest);
            return new AsyncInvoker<ListNotificationMasksResponse>(this, "POST", request, JsonUtils.DeSerialize<ListNotificationMasksResponse>);
        }
        
        /// <summary>
        /// 查询一键告警关联告警规则列表
        ///
        /// 查询一键告警关联告警规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOneClickAlarmRulesResponse> ListOneClickAlarmRulesAsync(ListOneClickAlarmRulesRequest listOneClickAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOneClickAlarmRulesRequest.OneClickAlarmId, out var valueOfOneClickAlarmId)) urlParam.Add("one_click_alarm_id", valueOfOneClickAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/{one_click_alarm_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOneClickAlarmRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOneClickAlarmRulesResponse>(response);
        }

        public AsyncInvoker<ListOneClickAlarmRulesResponse> ListOneClickAlarmRulesAsyncInvoker(ListOneClickAlarmRulesRequest listOneClickAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOneClickAlarmRulesRequest.OneClickAlarmId, out var valueOfOneClickAlarmId)) urlParam.Add("one_click_alarm_id", valueOfOneClickAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/{one_click_alarm_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOneClickAlarmRulesRequest);
            return new AsyncInvoker<ListOneClickAlarmRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOneClickAlarmRulesResponse>);
        }
        
        /// <summary>
        /// 查询一键告警列表
        ///
        /// 查询一键告警列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOneClickAlarmsResponse> ListOneClickAlarmsAsync(ListOneClickAlarmsRequest listOneClickAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOneClickAlarmsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOneClickAlarmsResponse>(response);
        }

        public AsyncInvoker<ListOneClickAlarmsResponse> ListOneClickAlarmsAsyncInvoker(ListOneClickAlarmsRequest listOneClickAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOneClickAlarmsRequest);
            return new AsyncInvoker<ListOneClickAlarmsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOneClickAlarmsResponse>);
        }
        
        /// <summary>
        /// 查询资源分组列表
        ///
        /// 查询资源分组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceGroupsResponse> ListResourceGroupsAsync(ListResourceGroupsRequest listResourceGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListResourceGroupsResponse>(response);
        }

        public AsyncInvoker<ListResourceGroupsResponse> ListResourceGroupsAsyncInvoker(ListResourceGroupsRequest listResourceGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceGroupsRequest);
            return new AsyncInvoker<ListResourceGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceGroupsResponse>);
        }
        
        /// <summary>
        /// 查询资源分组下指定服务类别特定维度的资源列表
        ///
        /// 查询资源分组下指定服务类别特定维度的资源列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceGroupsServicesResourcesResponse> ListResourceGroupsServicesResourcesAsync(ListResourceGroupsServicesResourcesRequest listResourceGroupsServicesResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceGroupsServicesResourcesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(listResourceGroupsServicesResourcesRequest.Service, out var valueOfService)) urlParam.Add("service", valueOfService);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/services/{service}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceGroupsServicesResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListResourceGroupsServicesResourcesResponse>(response);
        }

        public AsyncInvoker<ListResourceGroupsServicesResourcesResponse> ListResourceGroupsServicesResourcesAsyncInvoker(ListResourceGroupsServicesResourcesRequest listResourceGroupsServicesResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceGroupsServicesResourcesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(listResourceGroupsServicesResourcesRequest.Service, out var valueOfService)) urlParam.Add("service", valueOfService);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/services/{service}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceGroupsServicesResourcesRequest);
            return new AsyncInvoker<ListResourceGroupsServicesResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceGroupsServicesResourcesResponse>);
        }
        
        /// <summary>
        /// 查询告警模板详情
        ///
        /// 查询告警模板详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAlarmTemplateResponse> ShowAlarmTemplateAsync(ShowAlarmTemplateRequest showAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAlarmTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAlarmTemplateResponse>(response);
        }

        public AsyncInvoker<ShowAlarmTemplateResponse> ShowAlarmTemplateAsyncInvoker(ShowAlarmTemplateRequest showAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAlarmTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmTemplateRequest);
            return new AsyncInvoker<ShowAlarmTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAlarmTemplateResponse>);
        }
        
        /// <summary>
        /// 查询指定资源分组详情
        ///
        /// 查询指定资源分组详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceGroupResponse> ShowResourceGroupAsync(ShowResourceGroupRequest showResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceGroupResponse>(response);
        }

        public AsyncInvoker<ShowResourceGroupResponse> ShowResourceGroupAsyncInvoker(ShowResourceGroupRequest showResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceGroupRequest);
            return new AsyncInvoker<ShowResourceGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceGroupResponse>);
        }
        
        /// <summary>
        /// 查询指定监控视图信息
        ///
        /// 查询指定监控视图信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWidgetResponse> ShowWidgetAsync(ShowWidgetRequest showWidgetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWidgetRequest.WidgetId, out var valueOfWidgetId)) urlParam.Add("widget_id", valueOfWidgetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/widgets/{widget_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWidgetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowWidgetResponse>(response);
        }

        public AsyncInvoker<ShowWidgetResponse> ShowWidgetAsyncInvoker(ShowWidgetRequest showWidgetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWidgetRequest.WidgetId, out var valueOfWidgetId)) urlParam.Add("widget_id", valueOfWidgetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/widgets/{widget_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWidgetRequest);
            return new AsyncInvoker<ShowWidgetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWidgetResponse>);
        }
        
        /// <summary>
        /// 修改告警规则告警通知信息
        ///
        /// 修改告警规则告警通知信息，告警策略&amp;资源请使用对应接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAlarmNotificationsResponse> UpdateAlarmNotificationsAsync(UpdateAlarmNotificationsRequest updateAlarmNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAlarmNotificationsRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmNotificationsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAlarmNotificationsResponse>(response);
        }

        public AsyncInvoker<UpdateAlarmNotificationsResponse> UpdateAlarmNotificationsAsyncInvoker(UpdateAlarmNotificationsRequest updateAlarmNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAlarmNotificationsRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmNotificationsRequest);
            return new AsyncInvoker<UpdateAlarmNotificationsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAlarmNotificationsResponse>);
        }
        
        /// <summary>
        /// 修改告警规则策略(全量修改)
        ///
        /// 修改告警规则策略(全量修改)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAlarmRulePoliciesResponse> UpdateAlarmRulePoliciesAsync(UpdateAlarmRulePoliciesRequest updateAlarmRulePoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAlarmRulePoliciesRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmRulePoliciesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAlarmRulePoliciesResponse>(response);
        }

        public AsyncInvoker<UpdateAlarmRulePoliciesResponse> UpdateAlarmRulePoliciesAsyncInvoker(UpdateAlarmRulePoliciesRequest updateAlarmRulePoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAlarmRulePoliciesRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmRulePoliciesRequest);
            return new AsyncInvoker<UpdateAlarmRulePoliciesResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAlarmRulePoliciesResponse>);
        }
        
        /// <summary>
        /// 修改自定义告警模板
        ///
        /// 修改自定义告警模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAlarmTemplateResponse> UpdateAlarmTemplateAsync(UpdateAlarmTemplateRequest updateAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAlarmTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmTemplateRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAlarmTemplateResponse>(response);
        }

        public AsyncInvoker<UpdateAlarmTemplateResponse> UpdateAlarmTemplateAsyncInvoker(UpdateAlarmTemplateRequest updateAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAlarmTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmTemplateRequest);
            return new AsyncInvoker<UpdateAlarmTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAlarmTemplateResponse>);
        }
        
        /// <summary>
        /// 修改监控看板
        ///
        /// 修改监控看板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDashboardResponse> UpdateDashboardAsync(UpdateDashboardRequest updateDashboardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDashboardRequest.DashboardId, out var valueOfDashboardId)) urlParam.Add("dashboard_id", valueOfDashboardId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards/{dashboard_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDashboardRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDashboardResponse>(response);
        }

        public AsyncInvoker<UpdateDashboardResponse> UpdateDashboardAsyncInvoker(UpdateDashboardRequest updateDashboardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDashboardRequest.DashboardId, out var valueOfDashboardId)) urlParam.Add("dashboard_id", valueOfDashboardId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards/{dashboard_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDashboardRequest);
            return new AsyncInvoker<UpdateDashboardResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDashboardResponse>);
        }
        
        /// <summary>
        /// 修改告警通知屏蔽规则
        ///
        /// 修改告警通知屏蔽规则。
        /// 不能修改通过告警规则屏蔽的告警通知，只能修改通过资源屏蔽、策略屏蔽、事件屏蔽创建的告警屏蔽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateNotificationMaskResponse> UpdateNotificationMaskAsync(UpdateNotificationMaskRequest updateNotificationMaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNotificationMaskRequest.NotificationMaskId, out var valueOfNotificationMaskId)) urlParam.Add("notification_mask_id", valueOfNotificationMaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/{notification_mask_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNotificationMaskRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateNotificationMaskResponse>(response);
        }

        public AsyncInvoker<UpdateNotificationMaskResponse> UpdateNotificationMaskAsyncInvoker(UpdateNotificationMaskRequest updateNotificationMaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNotificationMaskRequest.NotificationMaskId, out var valueOfNotificationMaskId)) urlParam.Add("notification_mask_id", valueOfNotificationMaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/{notification_mask_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNotificationMaskRequest);
            return new AsyncInvoker<UpdateNotificationMaskResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateNotificationMaskResponse>);
        }
        
        /// <summary>
        /// 批量修改开启状态的一键告警关联告警规则的告警通知
        ///
        /// 批量修改开启状态的一键告警关联告警规则的告警通知
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateOneClickAlarmNotificationsResponse> UpdateOneClickAlarmNotificationsAsync(UpdateOneClickAlarmNotificationsRequest updateOneClickAlarmNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateOneClickAlarmNotificationsRequest.OneClickAlarmId, out var valueOfOneClickAlarmId)) urlParam.Add("one_click_alarm_id", valueOfOneClickAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/{one_click_alarm_id}/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOneClickAlarmNotificationsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateOneClickAlarmNotificationsResponse>(response);
        }

        public AsyncInvoker<UpdateOneClickAlarmNotificationsResponse> UpdateOneClickAlarmNotificationsAsyncInvoker(UpdateOneClickAlarmNotificationsRequest updateOneClickAlarmNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateOneClickAlarmNotificationsRequest.OneClickAlarmId, out var valueOfOneClickAlarmId)) urlParam.Add("one_click_alarm_id", valueOfOneClickAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/{one_click_alarm_id}/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOneClickAlarmNotificationsRequest);
            return new AsyncInvoker<UpdateOneClickAlarmNotificationsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateOneClickAlarmNotificationsResponse>);
        }
        
        /// <summary>
        /// 修改资源分组
        ///
        /// 修改资源分组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateResourceGroupResponse> UpdateResourceGroupAsync(UpdateResourceGroupRequest updateResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateResourceGroupResponse>(response);
        }

        public AsyncInvoker<UpdateResourceGroupResponse> UpdateResourceGroupAsyncInvoker(UpdateResourceGroupRequest updateResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceGroupRequest);
            return new AsyncInvoker<UpdateResourceGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateResourceGroupResponse>);
        }
        
        /// <summary>
        /// 资源分组异步关联自定义告警模板
        ///
        /// 提交资源分组批量关联自定义告警模板异步任务，由异步任务覆盖性创建告警规则。每个用户创建处于待执行状态的异步任务数量上限为100个，单个资源分组仅可有1个未完成的任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateResourceGroupAssociationAlarmTemplateResponse> UpdateResourceGroupAssociationAlarmTemplateAsync(UpdateResourceGroupAssociationAlarmTemplateRequest updateResourceGroupAssociationAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateResourceGroupAssociationAlarmTemplateRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/alarm-templates/async-association", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceGroupAssociationAlarmTemplateRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateResourceGroupAssociationAlarmTemplateResponse>(response);
        }

        public AsyncInvoker<UpdateResourceGroupAssociationAlarmTemplateResponse> UpdateResourceGroupAssociationAlarmTemplateAsyncInvoker(UpdateResourceGroupAssociationAlarmTemplateRequest updateResourceGroupAssociationAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateResourceGroupAssociationAlarmTemplateRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/alarm-templates/async-association", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceGroupAssociationAlarmTemplateRequest);
            return new AsyncInvoker<UpdateResourceGroupAssociationAlarmTemplateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateResourceGroupAssociationAlarmTemplateResponse>);
        }
        
    }
}