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
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        /// 批量删除告警规则
        ///
        /// 批量删除告警规则V2接口
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        /// 批量启停告警规则
        ///
        /// 批量启停告警规则
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        /// 批量删除告警规则资源
        ///
        /// 批量删除告警规则资源（资源分组类型的告警规则不支持），资源分组类型的修改请使用资源分组管理相关接口
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        /// 修改告警规则策略(全量修改)
        ///
        /// 修改告警规则策略(全量修改)
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        
    }
}