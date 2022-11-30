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