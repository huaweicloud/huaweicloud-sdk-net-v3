using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ces.V2.Model;

namespace HuaweiCloud.SDK.Ces.V2
{
    public partial class CesClient : Client
    {
        public static ClientBuilder<CesClient> NewBuilder()
        {
            return new ClientBuilder<CesClient>();
        }

        
        /// <summary>
        /// 批量增加告警规则资源
        ///
        /// 批量增加告警规则资源(资源分组类型的告警规则不支持)，资源分组类型的修改请使用资源分组管理相关接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddAlarmRuleResourcesResponse AddAlarmRuleResources(AddAlarmRuleResourcesRequest addAlarmRuleResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addAlarmRuleResourcesRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAlarmRuleResourcesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AddAlarmRuleResourcesResponse>(response);
        }

        public SyncInvoker<AddAlarmRuleResourcesResponse> AddAlarmRuleResourcesInvoker(AddAlarmRuleResourcesRequest addAlarmRuleResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addAlarmRuleResourcesRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAlarmRuleResourcesRequest);
            return new SyncInvoker<AddAlarmRuleResourcesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddAlarmRuleResourcesResponse>);
        }
        
        /// <summary>
        /// 自定义资源分组批量增加关联资源
        ///
        /// 给自定义资源分组,即类型为手动添加的资源分组,批量增加关联资源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateResourcesResponse BatchCreateResources(BatchCreateResourcesRequest batchCreateResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateResourcesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/resources/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateResourcesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateResourcesResponse>(response);
        }

        public SyncInvoker<BatchCreateResourcesResponse> BatchCreateResourcesInvoker(BatchCreateResourcesRequest batchCreateResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateResourcesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/resources/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateResourcesRequest);
            return new SyncInvoker<BatchCreateResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateResourcesResponse>);
        }
        
        /// <summary>
        /// 批量删除告警规则
        ///
        /// 批量删除告警规则V2接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteAlarmRulesResponse BatchDeleteAlarmRules(BatchDeleteAlarmRulesRequest batchDeleteAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAlarmRulesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteAlarmRulesResponse>(response);
        }

        public SyncInvoker<BatchDeleteAlarmRulesResponse> BatchDeleteAlarmRulesInvoker(BatchDeleteAlarmRulesRequest batchDeleteAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAlarmRulesRequest);
            return new SyncInvoker<BatchDeleteAlarmRulesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteAlarmRulesResponse>);
        }
        
        /// <summary>
        /// 批量删除自定义告警模板
        ///
        /// 批量删除自定义告警模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteAlarmTemplatesResponse BatchDeleteAlarmTemplates(BatchDeleteAlarmTemplatesRequest batchDeleteAlarmTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAlarmTemplatesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteAlarmTemplatesResponse>(response);
        }

        public SyncInvoker<BatchDeleteAlarmTemplatesResponse> BatchDeleteAlarmTemplatesInvoker(BatchDeleteAlarmTemplatesRequest batchDeleteAlarmTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAlarmTemplatesRequest);
            return new SyncInvoker<BatchDeleteAlarmTemplatesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteAlarmTemplatesResponse>);
        }
        
        /// <summary>
        /// 批量删除告警通知屏蔽规则
        ///
        /// 批量删除告警通知屏蔽规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteNotificationMasksResponse BatchDeleteNotificationMasks(BatchDeleteNotificationMasksRequest batchDeleteNotificationMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteNotificationMasksRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteNotificationMasksResponse>(response);
        }

        public SyncInvoker<BatchDeleteNotificationMasksResponse> BatchDeleteNotificationMasksInvoker(BatchDeleteNotificationMasksRequest batchDeleteNotificationMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteNotificationMasksRequest);
            return new SyncInvoker<BatchDeleteNotificationMasksResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteNotificationMasksResponse>);
        }
        
        /// <summary>
        /// 批量删除一键告警
        ///
        /// 批量删除一键告警
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteOneClickAlarmsResponse BatchDeleteOneClickAlarms(BatchDeleteOneClickAlarmsRequest batchDeleteOneClickAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteOneClickAlarmsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteOneClickAlarmsResponse>(response);
        }

        public SyncInvoker<BatchDeleteOneClickAlarmsResponse> BatchDeleteOneClickAlarmsInvoker(BatchDeleteOneClickAlarmsRequest batchDeleteOneClickAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteOneClickAlarmsRequest);
            return new SyncInvoker<BatchDeleteOneClickAlarmsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteOneClickAlarmsResponse>);
        }
        
        /// <summary>
        /// 批量删除资源分组
        ///
        /// 批量删除资源分组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteResourceGroupsResponse BatchDeleteResourceGroups(BatchDeleteResourceGroupsRequest batchDeleteResourceGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteResourceGroupsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteResourceGroupsResponse>(response);
        }

        public SyncInvoker<BatchDeleteResourceGroupsResponse> BatchDeleteResourceGroupsInvoker(BatchDeleteResourceGroupsRequest batchDeleteResourceGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteResourceGroupsRequest);
            return new SyncInvoker<BatchDeleteResourceGroupsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteResourceGroupsResponse>);
        }
        
        /// <summary>
        /// 自定义资源分组批量删除关联资源
        ///
        /// 给自定义资源分组,即类型为手动添加的资源分组,批量删除关联资源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteResourcesResponse BatchDeleteResources(BatchDeleteResourcesRequest batchDeleteResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteResourcesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/resources/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteResourcesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteResourcesResponse>(response);
        }

        public SyncInvoker<BatchDeleteResourcesResponse> BatchDeleteResourcesInvoker(BatchDeleteResourcesRequest batchDeleteResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteResourcesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/resources/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteResourcesRequest);
            return new SyncInvoker<BatchDeleteResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteResourcesResponse>);
        }
        
        /// <summary>
        /// 批量启停告警规则
        ///
        /// 批量启停告警规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchEnableAlarmRulesResponse BatchEnableAlarmRules(BatchEnableAlarmRulesRequest batchEnableAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchEnableAlarmRulesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchEnableAlarmRulesResponse>(response);
        }

        public SyncInvoker<BatchEnableAlarmRulesResponse> BatchEnableAlarmRulesInvoker(BatchEnableAlarmRulesRequest batchEnableAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchEnableAlarmRulesRequest);
            return new SyncInvoker<BatchEnableAlarmRulesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchEnableAlarmRulesResponse>);
        }
        
        /// <summary>
        /// 批量查询指标数据
        ///
        /// 批量查询指标数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchListSpecifiedMetricDataResponse BatchListSpecifiedMetricData(BatchListSpecifiedMetricDataRequest batchListSpecifiedMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batch-query-metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListSpecifiedMetricDataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchListSpecifiedMetricDataResponse>(response);
        }

        public SyncInvoker<BatchListSpecifiedMetricDataResponse> BatchListSpecifiedMetricDataInvoker(BatchListSpecifiedMetricDataRequest batchListSpecifiedMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batch-query-metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListSpecifiedMetricDataRequest);
            return new SyncInvoker<BatchListSpecifiedMetricDataResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchListSpecifiedMetricDataResponse>);
        }
        
        /// <summary>
        /// 批量修改告警通知屏蔽规则的屏蔽时间
        ///
        /// 批量修改告警通知屏蔽规则的屏蔽时间
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateNotificationMaskTimeResponse BatchUpdateNotificationMaskTime(BatchUpdateNotificationMaskTimeRequest batchUpdateNotificationMaskTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateNotificationMaskTimeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchUpdateNotificationMaskTimeResponse>(response);
        }

        public SyncInvoker<BatchUpdateNotificationMaskTimeResponse> BatchUpdateNotificationMaskTimeInvoker(BatchUpdateNotificationMaskTimeRequest batchUpdateNotificationMaskTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateNotificationMaskTimeRequest);
            return new SyncInvoker<BatchUpdateNotificationMaskTimeResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchUpdateNotificationMaskTimeResponse>);
        }
        
        /// <summary>
        /// 批量设置告警通知屏蔽规则
        ///
        /// 批量设置告警通知屏蔽规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateNotificationMasksResponse BatchUpdateNotificationMasks(BatchUpdateNotificationMasksRequest batchUpdateNotificationMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateNotificationMasksRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateNotificationMasksResponse>(response);
        }

        public SyncInvoker<BatchUpdateNotificationMasksResponse> BatchUpdateNotificationMasksInvoker(BatchUpdateNotificationMasksRequest batchUpdateNotificationMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateNotificationMasksRequest);
            return new SyncInvoker<BatchUpdateNotificationMasksResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateNotificationMasksResponse>);
        }
        
        /// <summary>
        /// 批量修改一键告警关联告警规则策略的启用状态
        ///
        /// 批量修改一键告警关联告警规则策略的启用状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateOneClickAlarmPoliciesEnabledStateResponse BatchUpdateOneClickAlarmPoliciesEnabledState(BatchUpdateOneClickAlarmPoliciesEnabledStateRequest batchUpdateOneClickAlarmPoliciesEnabledStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateOneClickAlarmPoliciesEnabledStateRequest.OneClickAlarmId, out var valueOfOneClickAlarmId)) urlParam.Add("one_click_alarm_id", valueOfOneClickAlarmId);
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateOneClickAlarmPoliciesEnabledStateRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/{one_click_alarm_id}/alarms/{alarm_id}/policies/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateOneClickAlarmPoliciesEnabledStateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateOneClickAlarmPoliciesEnabledStateResponse>(response);
        }

        public SyncInvoker<BatchUpdateOneClickAlarmPoliciesEnabledStateResponse> BatchUpdateOneClickAlarmPoliciesEnabledStateInvoker(BatchUpdateOneClickAlarmPoliciesEnabledStateRequest batchUpdateOneClickAlarmPoliciesEnabledStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateOneClickAlarmPoliciesEnabledStateRequest.OneClickAlarmId, out var valueOfOneClickAlarmId)) urlParam.Add("one_click_alarm_id", valueOfOneClickAlarmId);
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateOneClickAlarmPoliciesEnabledStateRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/{one_click_alarm_id}/alarms/{alarm_id}/policies/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateOneClickAlarmPoliciesEnabledStateRequest);
            return new SyncInvoker<BatchUpdateOneClickAlarmPoliciesEnabledStateResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateOneClickAlarmPoliciesEnabledStateResponse>);
        }
        
        /// <summary>
        /// 批量修改一键告警关联告警规则的启用状态
        ///
        /// 批量修改一键告警关联告警规则的启用状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateOneClickAlarmsEnabledStateResponse BatchUpdateOneClickAlarmsEnabledState(BatchUpdateOneClickAlarmsEnabledStateRequest batchUpdateOneClickAlarmsEnabledStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateOneClickAlarmsEnabledStateRequest.OneClickAlarmId, out var valueOfOneClickAlarmId)) urlParam.Add("one_click_alarm_id", valueOfOneClickAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/{one_click_alarm_id}/alarm-rules/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateOneClickAlarmsEnabledStateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateOneClickAlarmsEnabledStateResponse>(response);
        }

        public SyncInvoker<BatchUpdateOneClickAlarmsEnabledStateResponse> BatchUpdateOneClickAlarmsEnabledStateInvoker(BatchUpdateOneClickAlarmsEnabledStateRequest batchUpdateOneClickAlarmsEnabledStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateOneClickAlarmsEnabledStateRequest.OneClickAlarmId, out var valueOfOneClickAlarmId)) urlParam.Add("one_click_alarm_id", valueOfOneClickAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/{one_click_alarm_id}/alarm-rules/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateOneClickAlarmsEnabledStateRequest);
            return new SyncInvoker<BatchUpdateOneClickAlarmsEnabledStateResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateOneClickAlarmsEnabledStateResponse>);
        }
        
        /// <summary>
        /// 批量更新监控视图
        ///
        /// 批量更新监控视图
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateWidgetsResponse BatchUpdateWidgets(BatchUpdateWidgetsRequest batchUpdateWidgetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/widgets/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateWidgetsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchUpdateWidgetsResponse>(response);
        }

        public SyncInvoker<BatchUpdateWidgetsResponse> BatchUpdateWidgetsInvoker(BatchUpdateWidgetsRequest batchUpdateWidgetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/widgets/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateWidgetsRequest);
            return new SyncInvoker<BatchUpdateWidgetsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchUpdateWidgetsResponse>);
        }
        
        /// <summary>
        /// 创建告警规则（推荐）
        ///
        /// 创建告警规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAlarmRulesResponse CreateAlarmRules(CreateAlarmRulesRequest createAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmRulesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAlarmRulesResponse>(response);
        }

        public SyncInvoker<CreateAlarmRulesResponse> CreateAlarmRulesInvoker(CreateAlarmRulesRequest createAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmRulesRequest);
            return new SyncInvoker<CreateAlarmRulesResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAlarmRulesResponse>);
        }
        
        /// <summary>
        /// 创建自定义告警模板
        ///
        /// 创建自定义告警模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAlarmTemplateResponse CreateAlarmTemplate(CreateAlarmTemplateRequest createAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAlarmTemplateResponse>(response);
        }

        public SyncInvoker<CreateAlarmTemplateResponse> CreateAlarmTemplateInvoker(CreateAlarmTemplateRequest createAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmTemplateRequest);
            return new SyncInvoker<CreateAlarmTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAlarmTemplateResponse>);
        }
        
        /// <summary>
        /// 创建/复制/批量创建监控视图到指定的监控看板
        ///
        /// 创建/复制/批量创建监控视图到指定的监控看板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDashboardWidgetsResponse CreateDashboardWidgets(CreateDashboardWidgetsRequest createDashboardWidgetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDashboardWidgetsRequest.DashboardId, out var valueOfDashboardId)) urlParam.Add("dashboard_id", valueOfDashboardId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards/{dashboard_id}/widgets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDashboardWidgetsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDashboardWidgetsResponse>(response);
        }

        public SyncInvoker<CreateDashboardWidgetsResponse> CreateDashboardWidgetsInvoker(CreateDashboardWidgetsRequest createDashboardWidgetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDashboardWidgetsRequest.DashboardId, out var valueOfDashboardId)) urlParam.Add("dashboard_id", valueOfDashboardId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards/{dashboard_id}/widgets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDashboardWidgetsRequest);
            return new SyncInvoker<CreateDashboardWidgetsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDashboardWidgetsResponse>);
        }
        
        /// <summary>
        /// 创建一键告警
        ///
        /// 创建一键告警
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOneClickAlarmResponse CreateOneClickAlarm(CreateOneClickAlarmRequest createOneClickAlarmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOneClickAlarmRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateOneClickAlarmResponse>(response);
        }

        public SyncInvoker<CreateOneClickAlarmResponse> CreateOneClickAlarmInvoker(CreateOneClickAlarmRequest createOneClickAlarmRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOneClickAlarmRequest);
            return new SyncInvoker<CreateOneClickAlarmResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOneClickAlarmResponse>);
        }
        
        /// <summary>
        /// 创建/复制监控看板
        ///
        /// 创建/复制监控看板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOneDashboardResponse CreateOneDashboard(CreateOneDashboardRequest createOneDashboardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOneDashboardRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateOneDashboardResponse>(response);
        }

        public SyncInvoker<CreateOneDashboardResponse> CreateOneDashboardInvoker(CreateOneDashboardRequest createOneDashboardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOneDashboardRequest);
            return new SyncInvoker<CreateOneDashboardResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOneDashboardResponse>);
        }
        
        /// <summary>
        /// 创建资源分组（推荐）
        ///
        /// 创建资源分组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateResourceGroupResponse CreateResourceGroup(CreateResourceGroupRequest createResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateResourceGroupResponse>(response);
        }

        public SyncInvoker<CreateResourceGroupResponse> CreateResourceGroupInvoker(CreateResourceGroupRequest createResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceGroupRequest);
            return new SyncInvoker<CreateResourceGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateResourceGroupResponse>);
        }
        
        /// <summary>
        /// 批量删除告警规则资源
        ///
        /// 批量删除告警规则资源（资源分组类型的告警规则不支持），资源分组类型的修改请使用资源分组管理相关接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAlarmRuleResourcesResponse DeleteAlarmRuleResources(DeleteAlarmRuleResourcesRequest deleteAlarmRuleResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAlarmRuleResourcesRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRuleResourcesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteAlarmRuleResourcesResponse>(response);
        }

        public SyncInvoker<DeleteAlarmRuleResourcesResponse> DeleteAlarmRuleResourcesInvoker(DeleteAlarmRuleResourcesRequest deleteAlarmRuleResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAlarmRuleResourcesRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRuleResourcesRequest);
            return new SyncInvoker<DeleteAlarmRuleResourcesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteAlarmRuleResourcesResponse>);
        }
        
        /// <summary>
        /// 批量删除监控看板
        ///
        /// 批量删除监控看板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDashboardsResponse DeleteDashboards(DeleteDashboardsRequest deleteDashboardsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDashboardsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteDashboardsResponse>(response);
        }

        public SyncInvoker<DeleteDashboardsResponse> DeleteDashboardsInvoker(DeleteDashboardsRequest deleteDashboardsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDashboardsRequest);
            return new SyncInvoker<DeleteDashboardsResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteDashboardsResponse>);
        }
        
        /// <summary>
        /// 删除指定监控视图
        ///
        /// 删除指定监控视图
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteOneWidgetResponse DeleteOneWidget(DeleteOneWidgetRequest deleteOneWidgetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOneWidgetRequest.WidgetId, out var valueOfWidgetId)) urlParam.Add("widget_id", valueOfWidgetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/widgets/{widget_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOneWidgetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteOneWidgetResponse>(response);
        }

        public SyncInvoker<DeleteOneWidgetResponse> DeleteOneWidgetInvoker(DeleteOneWidgetRequest deleteOneWidgetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOneWidgetRequest.WidgetId, out var valueOfWidgetId)) urlParam.Add("widget_id", valueOfWidgetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/widgets/{widget_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOneWidgetRequest);
            return new SyncInvoker<DeleteOneWidgetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteOneWidgetResponse>);
        }
        
        /// <summary>
        /// 查询主机监控原始维度值
        ///
        /// 根据ECS/BMS资源ID及特殊维度值(仅支持磁盘、挂载点、进程、显卡、RAID控制器)查询该特殊维度对应的原始维度值；其他维度无需调用该接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAgentDimensionInfoResponse ListAgentDimensionInfo(ListAgentDimensionInfoRequest listAgentDimensionInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAgentDimensionInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/agent-dimensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentDimensionInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAgentDimensionInfoResponse>(response);
        }

        public SyncInvoker<ListAgentDimensionInfoResponse> ListAgentDimensionInfoInvoker(ListAgentDimensionInfoRequest listAgentDimensionInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAgentDimensionInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/agent-dimensions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentDimensionInfoRequest);
            return new SyncInvoker<ListAgentDimensionInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAgentDimensionInfoResponse>);
        }
        
        /// <summary>
        /// 查询告警记录列表
        ///
        /// 查询告警记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAlarmHistoriesResponse ListAlarmHistories(ListAlarmHistoriesRequest listAlarmHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmHistoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmHistoriesResponse>(response);
        }

        public SyncInvoker<ListAlarmHistoriesResponse> ListAlarmHistoriesInvoker(ListAlarmHistoriesRequest listAlarmHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmHistoriesRequest);
            return new SyncInvoker<ListAlarmHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmHistoriesResponse>);
        }
        
        /// <summary>
        /// 查询告警规则策略列表
        ///
        /// 根据告警规则ID查询策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAlarmRulePoliciesResponse ListAlarmRulePolicies(ListAlarmRulePoliciesRequest listAlarmRulePoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmRulePoliciesRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRulePoliciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmRulePoliciesResponse>(response);
        }

        public SyncInvoker<ListAlarmRulePoliciesResponse> ListAlarmRulePoliciesInvoker(ListAlarmRulePoliciesRequest listAlarmRulePoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmRulePoliciesRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRulePoliciesRequest);
            return new SyncInvoker<ListAlarmRulePoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmRulePoliciesResponse>);
        }
        
        /// <summary>
        /// 查询告警规则资源列表
        ///
        /// 根据告警规则ID查询告警规则资源列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAlarmRuleResourcesResponse ListAlarmRuleResources(ListAlarmRuleResourcesRequest listAlarmRuleResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmRuleResourcesRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRuleResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmRuleResourcesResponse>(response);
        }

        public SyncInvoker<ListAlarmRuleResourcesResponse> ListAlarmRuleResourcesInvoker(ListAlarmRuleResourcesRequest listAlarmRuleResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmRuleResourcesRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRuleResourcesRequest);
            return new SyncInvoker<ListAlarmRuleResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmRuleResourcesResponse>);
        }
        
        /// <summary>
        /// 查询告警规则列表（推荐）
        ///
        /// 查询告警规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAlarmRulesResponse ListAlarmRules(ListAlarmRulesRequest listAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmRulesResponse>(response);
        }

        public SyncInvoker<ListAlarmRulesResponse> ListAlarmRulesInvoker(ListAlarmRulesRequest listAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRulesRequest);
            return new SyncInvoker<ListAlarmRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmRulesResponse>);
        }
        
        /// <summary>
        /// 查询告警模板关联的告警规则列表
        ///
        /// 查询告警模板关联的告警规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAlarmTemplateAssociationAlarmsResponse ListAlarmTemplateAssociationAlarms(ListAlarmTemplateAssociationAlarmsRequest listAlarmTemplateAssociationAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmTemplateAssociationAlarmsRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates/{template_id}/association-alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTemplateAssociationAlarmsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmTemplateAssociationAlarmsResponse>(response);
        }

        public SyncInvoker<ListAlarmTemplateAssociationAlarmsResponse> ListAlarmTemplateAssociationAlarmsInvoker(ListAlarmTemplateAssociationAlarmsRequest listAlarmTemplateAssociationAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAlarmTemplateAssociationAlarmsRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates/{template_id}/association-alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTemplateAssociationAlarmsRequest);
            return new SyncInvoker<ListAlarmTemplateAssociationAlarmsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmTemplateAssociationAlarmsResponse>);
        }
        
        /// <summary>
        /// 查询告警模板列表
        ///
        /// 查询告警模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAlarmTemplatesResponse ListAlarmTemplates(ListAlarmTemplatesRequest listAlarmTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAlarmTemplatesResponse>(response);
        }

        public SyncInvoker<ListAlarmTemplatesResponse> ListAlarmTemplatesInvoker(ListAlarmTemplatesRequest listAlarmTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTemplatesRequest);
            return new SyncInvoker<ListAlarmTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAlarmTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询CES指定项目指定资源类型标签列表
        ///
        /// 查询CES指定项目指定资源类型标签列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCesTargetProjectTagsResponse ListCesTargetProjectTags(ListCesTargetProjectTagsRequest listCesTargetProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCesTargetProjectTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCesTargetProjectTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCesTargetProjectTagsResponse>(response);
        }

        public SyncInvoker<ListCesTargetProjectTagsResponse> ListCesTargetProjectTagsInvoker(ListCesTargetProjectTagsRequest listCesTargetProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCesTargetProjectTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCesTargetProjectTagsRequest);
            return new SyncInvoker<ListCesTargetProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCesTargetProjectTagsResponse>);
        }
        
        /// <summary>
        /// 查询监控看板列表
        ///
        /// 查询监控看板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDashboardInfosResponse ListDashboardInfos(ListDashboardInfosRequest listDashboardInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDashboardInfosRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDashboardInfosResponse>(response);
        }

        public SyncInvoker<ListDashboardInfosResponse> ListDashboardInfosInvoker(ListDashboardInfosRequest listDashboardInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDashboardInfosRequest);
            return new SyncInvoker<ListDashboardInfosResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDashboardInfosResponse>);
        }
        
        /// <summary>
        /// 查询指定监控看板下的监控视图列表
        ///
        /// 查询指定监控看板下的监控视图列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDashboardWidgetsResponse ListDashboardWidgets(ListDashboardWidgetsRequest listDashboardWidgetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDashboardWidgetsRequest.DashboardId, out var valueOfDashboardId)) urlParam.Add("dashboard_id", valueOfDashboardId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards/{dashboard_id}/widgets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDashboardWidgetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDashboardWidgetsResponse>(response);
        }

        public SyncInvoker<ListDashboardWidgetsResponse> ListDashboardWidgetsInvoker(ListDashboardWidgetsRequest listDashboardWidgetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDashboardWidgetsRequest.DashboardId, out var valueOfDashboardId)) urlParam.Add("dashboard_id", valueOfDashboardId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards/{dashboard_id}/widgets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDashboardWidgetsRequest);
            return new SyncInvoker<ListDashboardWidgetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDashboardWidgetsResponse>);
        }
        
        /// <summary>
        /// 查询告警通知屏蔽资源列表
        ///
        /// 查询告警通知屏蔽资源列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNotificationMaskResourcesResponse ListNotificationMaskResources(ListNotificationMaskResourcesRequest listNotificationMaskResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNotificationMaskResourcesRequest.NotificationMaskId, out var valueOfNotificationMaskId)) urlParam.Add("notification_mask_id", valueOfNotificationMaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/{notification_mask_id}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationMaskResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNotificationMaskResourcesResponse>(response);
        }

        public SyncInvoker<ListNotificationMaskResourcesResponse> ListNotificationMaskResourcesInvoker(ListNotificationMaskResourcesRequest listNotificationMaskResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNotificationMaskResourcesRequest.NotificationMaskId, out var valueOfNotificationMaskId)) urlParam.Add("notification_mask_id", valueOfNotificationMaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/{notification_mask_id}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationMaskResourcesRequest);
            return new SyncInvoker<ListNotificationMaskResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNotificationMaskResourcesResponse>);
        }
        
        /// <summary>
        /// 查询告警通知屏蔽列表
        ///
        /// 批量查询指定类型的通知屏蔽规则，目前最多支持100个通知屏蔽规则的批量查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNotificationMasksResponse ListNotificationMasks(ListNotificationMasksRequest listNotificationMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationMasksRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListNotificationMasksResponse>(response);
        }

        public SyncInvoker<ListNotificationMasksResponse> ListNotificationMasksInvoker(ListNotificationMasksRequest listNotificationMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationMasksRequest);
            return new SyncInvoker<ListNotificationMasksResponse>(this, "POST", request, JsonUtils.DeSerialize<ListNotificationMasksResponse>);
        }
        
        /// <summary>
        /// 查询一键告警关联告警规则列表
        ///
        /// 查询一键告警关联告警规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOneClickAlarmRulesResponse ListOneClickAlarmRules(ListOneClickAlarmRulesRequest listOneClickAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOneClickAlarmRulesRequest.OneClickAlarmId, out var valueOfOneClickAlarmId)) urlParam.Add("one_click_alarm_id", valueOfOneClickAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/{one_click_alarm_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOneClickAlarmRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOneClickAlarmRulesResponse>(response);
        }

        public SyncInvoker<ListOneClickAlarmRulesResponse> ListOneClickAlarmRulesInvoker(ListOneClickAlarmRulesRequest listOneClickAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listOneClickAlarmRulesRequest.OneClickAlarmId, out var valueOfOneClickAlarmId)) urlParam.Add("one_click_alarm_id", valueOfOneClickAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/{one_click_alarm_id}/alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOneClickAlarmRulesRequest);
            return new SyncInvoker<ListOneClickAlarmRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOneClickAlarmRulesResponse>);
        }
        
        /// <summary>
        /// 查询一键告警列表
        ///
        /// 查询一键告警列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOneClickAlarmsResponse ListOneClickAlarms(ListOneClickAlarmsRequest listOneClickAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOneClickAlarmsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOneClickAlarmsResponse>(response);
        }

        public SyncInvoker<ListOneClickAlarmsResponse> ListOneClickAlarmsInvoker(ListOneClickAlarmsRequest listOneClickAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOneClickAlarmsRequest);
            return new SyncInvoker<ListOneClickAlarmsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOneClickAlarmsResponse>);
        }
        
        /// <summary>
        /// 查询资源分组列表
        ///
        /// 查询资源分组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceGroupsResponse ListResourceGroups(ListResourceGroupsRequest listResourceGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListResourceGroupsResponse>(response);
        }

        public SyncInvoker<ListResourceGroupsResponse> ListResourceGroupsInvoker(ListResourceGroupsRequest listResourceGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceGroupsRequest);
            return new SyncInvoker<ListResourceGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceGroupsResponse>);
        }
        
        /// <summary>
        /// 查询资源分组下指定服务类别特定维度的资源列表
        ///
        /// 查询资源分组下指定服务类别特定维度的资源列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceGroupsServicesResourcesResponse ListResourceGroupsServicesResources(ListResourceGroupsServicesResourcesRequest listResourceGroupsServicesResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceGroupsServicesResourcesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(listResourceGroupsServicesResourcesRequest.Service, out var valueOfService)) urlParam.Add("service", valueOfService);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/services/{service}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceGroupsServicesResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListResourceGroupsServicesResourcesResponse>(response);
        }

        public SyncInvoker<ListResourceGroupsServicesResourcesResponse> ListResourceGroupsServicesResourcesInvoker(ListResourceGroupsServicesResourcesRequest listResourceGroupsServicesResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceGroupsServicesResourcesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(listResourceGroupsServicesResourcesRequest.Service, out var valueOfService)) urlParam.Add("service", valueOfService);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/services/{service}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceGroupsServicesResourcesRequest);
            return new SyncInvoker<ListResourceGroupsServicesResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceGroupsServicesResourcesResponse>);
        }
        
        /// <summary>
        /// 查询告警模板详情
        ///
        /// 查询告警模板详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAlarmTemplateResponse ShowAlarmTemplate(ShowAlarmTemplateRequest showAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAlarmTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAlarmTemplateResponse>(response);
        }

        public SyncInvoker<ShowAlarmTemplateResponse> ShowAlarmTemplateInvoker(ShowAlarmTemplateRequest showAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAlarmTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmTemplateRequest);
            return new SyncInvoker<ShowAlarmTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAlarmTemplateResponse>);
        }
        
        /// <summary>
        /// 查询指定资源分组详情
        ///
        /// 查询指定资源分组详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceGroupResponse ShowResourceGroup(ShowResourceGroupRequest showResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceGroupResponse>(response);
        }

        public SyncInvoker<ShowResourceGroupResponse> ShowResourceGroupInvoker(ShowResourceGroupRequest showResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceGroupRequest);
            return new SyncInvoker<ShowResourceGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceGroupResponse>);
        }
        
        /// <summary>
        /// 查询指定监控视图信息
        ///
        /// 查询指定监控视图信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowWidgetResponse ShowWidget(ShowWidgetRequest showWidgetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWidgetRequest.WidgetId, out var valueOfWidgetId)) urlParam.Add("widget_id", valueOfWidgetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/widgets/{widget_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWidgetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowWidgetResponse>(response);
        }

        public SyncInvoker<ShowWidgetResponse> ShowWidgetInvoker(ShowWidgetRequest showWidgetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWidgetRequest.WidgetId, out var valueOfWidgetId)) urlParam.Add("widget_id", valueOfWidgetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/widgets/{widget_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWidgetRequest);
            return new SyncInvoker<ShowWidgetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWidgetResponse>);
        }
        
        /// <summary>
        /// 修改告警规则告警通知信息
        ///
        /// 修改告警规则告警通知信息，告警策略&amp;资源请使用对应接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAlarmNotificationsResponse UpdateAlarmNotifications(UpdateAlarmNotificationsRequest updateAlarmNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAlarmNotificationsRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmNotificationsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAlarmNotificationsResponse>(response);
        }

        public SyncInvoker<UpdateAlarmNotificationsResponse> UpdateAlarmNotificationsInvoker(UpdateAlarmNotificationsRequest updateAlarmNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAlarmNotificationsRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmNotificationsRequest);
            return new SyncInvoker<UpdateAlarmNotificationsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAlarmNotificationsResponse>);
        }
        
        /// <summary>
        /// 修改告警规则策略(全量修改)
        ///
        /// 修改告警规则策略(全量修改)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAlarmRulePoliciesResponse UpdateAlarmRulePolicies(UpdateAlarmRulePoliciesRequest updateAlarmRulePoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAlarmRulePoliciesRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmRulePoliciesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAlarmRulePoliciesResponse>(response);
        }

        public SyncInvoker<UpdateAlarmRulePoliciesResponse> UpdateAlarmRulePoliciesInvoker(UpdateAlarmRulePoliciesRequest updateAlarmRulePoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAlarmRulePoliciesRequest.AlarmId, out var valueOfAlarmId)) urlParam.Add("alarm_id", valueOfAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmRulePoliciesRequest);
            return new SyncInvoker<UpdateAlarmRulePoliciesResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAlarmRulePoliciesResponse>);
        }
        
        /// <summary>
        /// 修改自定义告警模板
        ///
        /// 修改自定义告警模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAlarmTemplateResponse UpdateAlarmTemplate(UpdateAlarmTemplateRequest updateAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAlarmTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAlarmTemplateResponse>(response);
        }

        public SyncInvoker<UpdateAlarmTemplateResponse> UpdateAlarmTemplateInvoker(UpdateAlarmTemplateRequest updateAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAlarmTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmTemplateRequest);
            return new SyncInvoker<UpdateAlarmTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAlarmTemplateResponse>);
        }
        
        /// <summary>
        /// 修改监控看板
        ///
        /// 修改监控看板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDashboardResponse UpdateDashboard(UpdateDashboardRequest updateDashboardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDashboardRequest.DashboardId, out var valueOfDashboardId)) urlParam.Add("dashboard_id", valueOfDashboardId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards/{dashboard_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDashboardRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDashboardResponse>(response);
        }

        public SyncInvoker<UpdateDashboardResponse> UpdateDashboardInvoker(UpdateDashboardRequest updateDashboardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDashboardRequest.DashboardId, out var valueOfDashboardId)) urlParam.Add("dashboard_id", valueOfDashboardId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards/{dashboard_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDashboardRequest);
            return new SyncInvoker<UpdateDashboardResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDashboardResponse>);
        }
        
        /// <summary>
        /// 修改告警通知屏蔽规则
        ///
        /// 修改告警通知屏蔽规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateNotificationMaskResponse UpdateNotificationMask(UpdateNotificationMaskRequest updateNotificationMaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNotificationMaskRequest.NotificationMaskId, out var valueOfNotificationMaskId)) urlParam.Add("notification_mask_id", valueOfNotificationMaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/{notification_mask_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNotificationMaskRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateNotificationMaskResponse>(response);
        }

        public SyncInvoker<UpdateNotificationMaskResponse> UpdateNotificationMaskInvoker(UpdateNotificationMaskRequest updateNotificationMaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNotificationMaskRequest.NotificationMaskId, out var valueOfNotificationMaskId)) urlParam.Add("notification_mask_id", valueOfNotificationMaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/{notification_mask_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNotificationMaskRequest);
            return new SyncInvoker<UpdateNotificationMaskResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateNotificationMaskResponse>);
        }
        
        /// <summary>
        /// 批量修改开启状态的一键告警关联告警规则的告警通知
        ///
        /// 批量修改开启状态的一键告警关联告警规则的告警通知
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateOneClickAlarmNotificationsResponse UpdateOneClickAlarmNotifications(UpdateOneClickAlarmNotificationsRequest updateOneClickAlarmNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateOneClickAlarmNotificationsRequest.OneClickAlarmId, out var valueOfOneClickAlarmId)) urlParam.Add("one_click_alarm_id", valueOfOneClickAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/{one_click_alarm_id}/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOneClickAlarmNotificationsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateOneClickAlarmNotificationsResponse>(response);
        }

        public SyncInvoker<UpdateOneClickAlarmNotificationsResponse> UpdateOneClickAlarmNotificationsInvoker(UpdateOneClickAlarmNotificationsRequest updateOneClickAlarmNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateOneClickAlarmNotificationsRequest.OneClickAlarmId, out var valueOfOneClickAlarmId)) urlParam.Add("one_click_alarm_id", valueOfOneClickAlarmId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/{one_click_alarm_id}/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOneClickAlarmNotificationsRequest);
            return new SyncInvoker<UpdateOneClickAlarmNotificationsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateOneClickAlarmNotificationsResponse>);
        }
        
        /// <summary>
        /// 修改资源分组
        ///
        /// 修改资源分组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateResourceGroupResponse UpdateResourceGroup(UpdateResourceGroupRequest updateResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateResourceGroupResponse>(response);
        }

        public SyncInvoker<UpdateResourceGroupResponse> UpdateResourceGroupInvoker(UpdateResourceGroupRequest updateResourceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateResourceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceGroupRequest);
            return new SyncInvoker<UpdateResourceGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateResourceGroupResponse>);
        }
        
        /// <summary>
        /// 资源分组异步关联自定义告警模板
        ///
        /// 提交资源分组批量关联自定义告警模板异步任务，由异步任务覆盖性创建告警规则。每个用户创建处于待执行状态的异步任务数量上限为100个，单个资源分组仅可有1个未完成的任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateResourceGroupAssociationAlarmTemplateResponse UpdateResourceGroupAssociationAlarmTemplate(UpdateResourceGroupAssociationAlarmTemplateRequest updateResourceGroupAssociationAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateResourceGroupAssociationAlarmTemplateRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/alarm-templates/async-association", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceGroupAssociationAlarmTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateResourceGroupAssociationAlarmTemplateResponse>(response);
        }

        public SyncInvoker<UpdateResourceGroupAssociationAlarmTemplateResponse> UpdateResourceGroupAssociationAlarmTemplateInvoker(UpdateResourceGroupAssociationAlarmTemplateRequest updateResourceGroupAssociationAlarmTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateResourceGroupAssociationAlarmTemplateRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/alarm-templates/async-association", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceGroupAssociationAlarmTemplateRequest);
            return new SyncInvoker<UpdateResourceGroupAssociationAlarmTemplateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateResourceGroupAssociationAlarmTemplateResponse>);
        }
        
    }
}