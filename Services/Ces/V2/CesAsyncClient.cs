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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , addAlarmRuleResourcesRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources/batch-create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAlarmRuleResourcesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<AddAlarmRuleResourcesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , batchCreateResourcesRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/resources/batch-create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateResourcesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchCreateResourcesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAlarmRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteAlarmRulesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAlarmTemplatesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteAlarmTemplatesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteNotificationMasksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteNotificationMasksResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteOneClickAlarmsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteOneClickAlarmsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteResourceGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteResourceGroupsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , batchDeleteResourcesRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/resources/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteResourcesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteResourcesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchEnableAlarmRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchEnableAlarmRulesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/batch-update",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateNotificationMaskTimeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchUpdateNotificationMaskTimeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateNotificationMasksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchUpdateNotificationMasksResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("one_click_alarm_id" , batchUpdateOneClickAlarmPoliciesEnabledStateRequest.OneClickAlarmId.ToString());
            urlParam.Add("alarm_id" , batchUpdateOneClickAlarmPoliciesEnabledStateRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/{one_click_alarm_id}/alarms/{alarm_id}/policies/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateOneClickAlarmPoliciesEnabledStateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchUpdateOneClickAlarmPoliciesEnabledStateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("one_click_alarm_id" , batchUpdateOneClickAlarmsEnabledStateRequest.OneClickAlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/{one_click_alarm_id}/alarm-rules/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateOneClickAlarmsEnabledStateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchUpdateOneClickAlarmsEnabledStateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/widgets/batch-update",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateWidgetsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchUpdateWidgetsResponse>(response);
        }
        
        /// <summary>
        /// 创建告警规则
        ///
        /// 创建告警规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAlarmRulesResponse> CreateAlarmRulesAsync(CreateAlarmRulesRequest createAlarmRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAlarmRulesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAlarmTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("dashboard_id" , createDashboardWidgetsRequest.DashboardId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards/{dashboard_id}/widgets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDashboardWidgetsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDashboardWidgetsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOneClickAlarmRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateOneClickAlarmResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOneDashboardRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateOneDashboardResponse>(response);
        }
        
        /// <summary>
        /// 创建资源分组
        ///
        /// 创建资源分组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateResourceGroupResponse> CreateResourceGroupAsync(CreateResourceGroupRequest createResourceGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateResourceGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , deleteAlarmRuleResourcesRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRuleResourcesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<DeleteAlarmRuleResourcesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDashboardsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DeleteDashboardsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("widget_id" , deleteOneWidgetRequest.WidgetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/widgets/{widget_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOneWidgetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteOneWidgetResponse>(response);
        }
        
        /// <summary>
        /// 查询主机监控维度指标信息
        ///
        /// 根据ECS/BMS资源ID查询磁盘、挂载点、进程、显卡、RAID控制器维度指标信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAgentDimensionInfoResponse> ListAgentDimensionInfoAsync(ListAgentDimensionInfoRequest listAgentDimensionInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listAgentDimensionInfoRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/agent-dimensions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentDimensionInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAgentDimensionInfoResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-histories",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmHistoriesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmHistoriesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , listAlarmRulePoliciesRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRulePoliciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmRulePoliciesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , listAlarmRuleResourcesRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRuleResourcesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmRuleResourcesResponse>(response);
        }
        
        /// <summary>
        /// 查询告警规则列表
        ///
        /// 查询告警规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAlarmRulesResponse> ListAlarmRulesAsync(ListAlarmRulesRequest listAlarmRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmRulesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id" , listAlarmTemplateAssociationAlarmsRequest.TemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates/{template_id}/association-alarms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTemplateAssociationAlarmsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmTemplateAssociationAlarmsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTemplatesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmTemplatesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listCesTargetProjectTagsRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCesTargetProjectTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListCesTargetProjectTagsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDashboardInfosRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDashboardInfosResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("dashboard_id" , listDashboardWidgetsRequest.DashboardId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards/{dashboard_id}/widgets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDashboardWidgetsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDashboardWidgetsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("notification_mask_id" , listNotificationMaskResourcesRequest.NotificationMaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/{notification_mask_id}/resources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationMaskResourcesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListNotificationMaskResourcesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/batch-query",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationMasksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListNotificationMasksResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("one_click_alarm_id" , listOneClickAlarmRulesRequest.OneClickAlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/{one_click_alarm_id}/alarms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOneClickAlarmRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListOneClickAlarmRulesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOneClickAlarmsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListOneClickAlarmsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListResourceGroupsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , listResourceGroupsServicesResourcesRequest.GroupId.ToString());
            urlParam.Add("service" , listResourceGroupsServicesResourcesRequest.Service.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}/services/{service}/resources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceGroupsServicesResourcesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListResourceGroupsServicesResourcesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id" , showAlarmTemplateRequest.TemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates/{template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAlarmTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , showResourceGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowResourceGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("widget_id" , showWidgetRequest.WidgetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/widgets/{widget_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWidgetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowWidgetResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , updateAlarmNotificationsRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/notifications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmNotificationsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAlarmNotificationsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , updateAlarmRulePoliciesRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmRulePoliciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAlarmRulePoliciesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id" , updateAlarmTemplateRequest.TemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-templates/{template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateAlarmTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("dashboard_id" , updateDashboardRequest.DashboardId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboards/{dashboard_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDashboardRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateDashboardResponse>(response);
        }
        
        /// <summary>
        /// 修改告警通知屏蔽规则
        ///
        /// 修改告警通知屏蔽规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateNotificationMasksResponse> UpdateNotificationMasksAsync(UpdateNotificationMasksRequest updateNotificationMasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("notification_mask_id" , updateNotificationMasksRequest.NotificationMaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notification-masks/{notification_mask_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNotificationMasksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateNotificationMasksResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("one_click_alarm_id" , updateOneClickAlarmNotificationsRequest.OneClickAlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/one-click-alarms/{one_click_alarm_id}/notifications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOneClickAlarmNotificationsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateOneClickAlarmNotificationsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , updateResourceGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/resource-groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateResourceGroupResponse>(response);
        }
        
    }
}