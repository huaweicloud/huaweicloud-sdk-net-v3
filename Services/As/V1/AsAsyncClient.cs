using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.As.V1.Model;

namespace HuaweiCloud.SDK.As.V1
{
    public partial class AsAsyncClient : Client
    {
        public static ClientBuilder<AsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<AsAsyncClient>();
        }

        
        /// <summary>
        /// 批量删除弹性伸缩配置
        /// </summary>
        public async Task<BatchDeleteScalingConfigsResponse> BatchDeleteScalingConfigsAsync(BatchDeleteScalingConfigsRequest batchDeleteScalingConfigsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteScalingConfigsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteScalingConfigsResponse>(response);
        }
        
        /// <summary>
        /// 伸缩实例生命周期回调
        /// </summary>
        public async Task<CompleteLifecycleActionResponse> CompleteLifecycleActionAsync(CompleteLifecycleActionRequest completeLifecycleActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , completeLifecycleActionRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_instance_hook/{scaling_group_id}/callback",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", completeLifecycleActionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<CompleteLifecycleActionResponse>(response);
        }
        
        /// <summary>
        /// 创建生命周期挂钩
        /// </summary>
        public async Task<CreateLifyCycleHookResponse> CreateLifyCycleHookAsync(CreateLifyCycleHookRequest createLifyCycleHookRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , createLifyCycleHookRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLifyCycleHookRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateLifyCycleHookResponse>(response);
        }
        
        /// <summary>
        /// 创建弹性伸缩配置
        /// </summary>
        public async Task<CreateScalingConfigResponse> CreateScalingConfigAsync(CreateScalingConfigRequest createScalingConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateScalingConfigResponse>(response);
        }
        
        /// <summary>
        /// 创建弹性伸缩组
        /// </summary>
        public async Task<CreateScalingGroupResponse> CreateScalingGroupAsync(CreateScalingGroupRequest createScalingGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateScalingGroupResponse>(response);
        }
        
        /// <summary>
        /// 配置伸缩组通知
        /// </summary>
        public async Task<CreateScalingNotificationResponse> CreateScalingNotificationAsync(CreateScalingNotificationRequest createScalingNotificationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , createScalingNotificationRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_notification/{scaling_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingNotificationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<CreateScalingNotificationResponse>(response);
        }
        
        /// <summary>
        /// 创建弹性伸缩策略
        /// </summary>
        public async Task<CreateScalingPolicyResponse> CreateScalingPolicyAsync(CreateScalingPolicyRequest createScalingPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateScalingPolicyResponse>(response);
        }
        
        /// <summary>
        /// 创建标签
        /// </summary>
        public async Task<CreateScalingTagsResponse> CreateScalingTagsAsync(CreateScalingTagsRequest createScalingTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , createScalingTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , createScalingTagsRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/{resource_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateScalingTagsResponse>(response);
        }
        
        /// <summary>
        /// 删除生命周期挂钩
        /// </summary>
        public async Task<DeleteLifecycleHookResponse> DeleteLifecycleHookAsync(DeleteLifecycleHookRequest deleteLifecycleHookRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , deleteLifecycleHookRequest.ScalingGroupId.ToString());
            urlParam.Add("lifecycle_hook_name" , deleteLifecycleHookRequest.LifecycleHookName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/{lifecycle_hook_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLifecycleHookRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteLifecycleHookResponse>(response);
        }
        
        /// <summary>
        /// 删除弹性伸缩配置
        /// </summary>
        public async Task<DeleteScalingConfigResponse> DeleteScalingConfigAsync(DeleteScalingConfigRequest deleteScalingConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_configuration_id" , deleteScalingConfigRequest.ScalingConfigurationId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration/{scaling_configuration_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteScalingConfigResponse>(response);
        }
        
        /// <summary>
        /// 删除弹性伸缩组
        /// </summary>
        public async Task<DeleteScalingGroupResponse> DeleteScalingGroupAsync(DeleteScalingGroupRequest deleteScalingGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , deleteScalingGroupRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteScalingGroupResponse>(response);
        }
        
        /// <summary>
        /// 移出弹性伸缩组实例
        /// </summary>
        public async Task<DeleteScalingInstanceResponse> DeleteScalingInstanceAsync(DeleteScalingInstanceRequest deleteScalingInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteScalingInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteScalingInstanceResponse>(response);
        }
        
        /// <summary>
        /// 删除伸缩组通知
        /// </summary>
        public async Task<DeleteScalingNotificationResponse> DeleteScalingNotificationAsync(DeleteScalingNotificationRequest deleteScalingNotificationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , deleteScalingNotificationRequest.ScalingGroupId.ToString());
            urlParam.Add("topic_urn" , deleteScalingNotificationRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_notification/{scaling_group_id}/{topic_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingNotificationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteScalingNotificationResponse>(response);
        }
        
        /// <summary>
        /// 删除弹性伸缩策略
        /// </summary>
        public async Task<DeleteScalingPolicyResponse> DeleteScalingPolicyAsync(DeleteScalingPolicyRequest deleteScalingPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id" , deleteScalingPolicyRequest.ScalingPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteScalingPolicyResponse>(response);
        }
        
        /// <summary>
        /// 删除标签
        /// </summary>
        public async Task<DeleteScalingTagsResponse> DeleteScalingTagsAsync(DeleteScalingTagsRequest deleteScalingTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , deleteScalingTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , deleteScalingTagsRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/{resource_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteScalingTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<DeleteScalingTagsResponse>(response);
        }
        
        /// <summary>
        /// 启用或停止弹性伸缩组
        /// </summary>
        public async Task<EnableOrDisableScalingGroupResponse> EnableOrDisableScalingGroupAsync(EnableOrDisableScalingGroupRequest enableOrDisableScalingGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , enableOrDisableScalingGroupRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableOrDisableScalingGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<EnableOrDisableScalingGroupResponse>(response);
        }
        
        /// <summary>
        /// 批量操作弹性伸缩策略。
        /// </summary>
        public async Task<ExecuteScalingPoliciesResponse> ExecuteScalingPoliciesAsync(ExecuteScalingPoliciesRequest executeScalingPoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policies/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeScalingPoliciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<ExecuteScalingPoliciesResponse>(response);
        }
        
        /// <summary>
        /// 执行或启用或停止弹性伸缩策略。
        /// </summary>
        public async Task<ExecuteScalingPolicyResponse> ExecuteScalingPolicyAsync(ExecuteScalingPolicyRequest executeScalingPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id" , executeScalingPolicyRequest.ScalingPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeScalingPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<ExecuteScalingPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询伸缩实例挂起信息
        /// </summary>
        public async Task<ListHookInstancesResponse> ListHookInstancesAsync(ListHookInstancesRequest listHookInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , listHookInstancesRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_instance_hook/{scaling_group_id}/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHookInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListHookInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询生命周期挂钩列表
        /// </summary>
        public async Task<ListLifeCycleHooksResponse> ListLifeCycleHooksAsync(ListLifeCycleHooksRequest listLifeCycleHooksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , listLifeCycleHooksRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLifeCycleHooksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListLifeCycleHooksResponse>(response);
        }
        
        /// <summary>
        /// 查询资源实例
        /// </summary>
        public async Task<ListResourceInstancesResponse> ListResourceInstancesAsync(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listResourceInstancesRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListResourceInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询伸缩活动日志
        /// </summary>
        public async Task<ListScalingActivityLogsResponse> ListScalingActivityLogsAsync(ListScalingActivityLogsRequest listScalingActivityLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , listScalingActivityLogsRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_activity_log/{scaling_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingActivityLogsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingActivityLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询伸缩活动日志v2版本
        /// </summary>
        public async Task<ListScalingActivityV2LogsResponse> ListScalingActivityV2LogsAsync(ListScalingActivityV2LogsRequest listScalingActivityV2LogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , listScalingActivityV2LogsRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_activity_log/{scaling_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingActivityV2LogsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingActivityV2LogsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩配置列表
        /// </summary>
        public async Task<ListScalingConfigsResponse> ListScalingConfigsAsync(ListScalingConfigsRequest listScalingConfigsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingConfigsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingConfigsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩组列表
        /// </summary>
        public async Task<ListScalingGroupsResponse> ListScalingGroupsAsync(ListScalingGroupsRequest listScalingGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩组中的实例列表
        /// </summary>
        public async Task<ListScalingInstancesResponse> ListScalingInstancesAsync(ListScalingInstancesRequest listScalingInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , listScalingInstancesRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询伸缩组通知列表
        /// </summary>
        public async Task<ListScalingNotificationsResponse> ListScalingNotificationsAsync(ListScalingNotificationsRequest listScalingNotificationsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , listScalingNotificationsRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_notification/{scaling_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingNotificationsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingNotificationsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩策略列表
        /// </summary>
        public async Task<ListScalingPoliciesResponse> ListScalingPoliciesAsync(ListScalingPoliciesRequest listScalingPoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , listScalingPoliciesRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_group_id}/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingPoliciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingPoliciesResponse>(response);
        }
        
        /// <summary>
        /// 查询策略执行日志
        /// </summary>
        public async Task<ListScalingPolicyExecuteLogsResponse> ListScalingPolicyExecuteLogsAsync(ListScalingPolicyExecuteLogsRequest listScalingPolicyExecuteLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id" , listScalingPolicyExecuteLogsRequest.ScalingPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy_execute_log/{scaling_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingPolicyExecuteLogsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingPolicyExecuteLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询资源标签
        /// </summary>
        public async Task<ListScalingTagInfosByResourceIdResponse> ListScalingTagInfosByResourceIdAsync(ListScalingTagInfosByResourceIdRequest listScalingTagInfosByResourceIdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listScalingTagInfosByResourceIdRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , listScalingTagInfosByResourceIdRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/{resource_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingTagInfosByResourceIdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingTagInfosByResourceIdResponse>(response);
        }
        
        /// <summary>
        /// 查询标签
        /// </summary>
        public async Task<ListScalingTagInfosByTenantIdResponse> ListScalingTagInfosByTenantIdAsync(ListScalingTagInfosByTenantIdRequest listScalingTagInfosByTenantIdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listScalingTagInfosByTenantIdRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingTagInfosByTenantIdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingTagInfosByTenantIdResponse>(response);
        }
        
        /// <summary>
        /// 查询生命周期挂钩详情
        /// </summary>
        public async Task<ShowLifeCycleHookResponse> ShowLifeCycleHookAsync(ShowLifeCycleHookRequest showLifeCycleHookRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , showLifeCycleHookRequest.ScalingGroupId.ToString());
            urlParam.Add("lifecycle_hook_name" , showLifeCycleHookRequest.LifecycleHookName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/{lifecycle_hook_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLifeCycleHookRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowLifeCycleHookResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩策略和伸缩实例配额
        /// </summary>
        public async Task<ShowPolicyAndInstanceQuotaResponse> ShowPolicyAndInstanceQuotaAsync(ShowPolicyAndInstanceQuotaRequest showPolicyAndInstanceQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , showPolicyAndInstanceQuotaRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/quotas/{scaling_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyAndInstanceQuotaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPolicyAndInstanceQuotaResponse>(response);
        }
        
        /// <summary>
        /// 查询配额
        /// </summary>
        public async Task<ShowResourceQuotaResponse> ShowResourceQuotaAsync(ShowResourceQuotaRequest showResourceQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceQuotaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowResourceQuotaResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩配置详情
        /// </summary>
        public async Task<ShowScalingConfigResponse> ShowScalingConfigAsync(ShowScalingConfigRequest showScalingConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_configuration_id" , showScalingConfigRequest.ScalingConfigurationId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration/{scaling_configuration_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowScalingConfigResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩组详情
        /// </summary>
        public async Task<ShowScalingGroupResponse> ShowScalingGroupAsync(ShowScalingGroupRequest showScalingGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , showScalingGroupRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowScalingGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩策略详情
        /// </summary>
        public async Task<ShowScalingPolicyResponse> ShowScalingPolicyAsync(ShowScalingPolicyRequest showScalingPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id" , showScalingPolicyRequest.ScalingPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowScalingPolicyResponse>(response);
        }
        
        /// <summary>
        /// 修改生命周期挂钩
        /// </summary>
        public async Task<UpdateLifeCycleHookResponse> UpdateLifeCycleHookAsync(UpdateLifeCycleHookRequest updateLifeCycleHookRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , updateLifeCycleHookRequest.ScalingGroupId.ToString());
            urlParam.Add("lifecycle_hook_name" , updateLifeCycleHookRequest.LifecycleHookName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/{lifecycle_hook_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLifeCycleHookRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateLifeCycleHookResponse>(response);
        }
        
        /// <summary>
        /// 修改弹性伸缩组
        /// </summary>
        public async Task<UpdateScalingGroupResponse> UpdateScalingGroupAsync(UpdateScalingGroupRequest updateScalingGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , updateScalingGroupRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScalingGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateScalingGroupResponse>(response);
        }
        
        /// <summary>
        /// 批量操作实例
        /// </summary>
        public async Task<UpdateScalingGroupInstanceResponse> UpdateScalingGroupInstanceAsync(UpdateScalingGroupInstanceRequest updateScalingGroupInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , updateScalingGroupInstanceRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScalingGroupInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateScalingGroupInstanceResponse>(response);
        }
        
        /// <summary>
        /// 修改弹性伸缩策略
        /// </summary>
        public async Task<UpdateScalingPolicyResponse> UpdateScalingPolicyAsync(UpdateScalingPolicyRequest updateScalingPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id" , updateScalingPolicyRequest.ScalingPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScalingPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateScalingPolicyResponse>(response);
        }
        
        /// <summary>
        /// 创建弹性伸缩策略（V2版本）
        /// </summary>
        public async Task<CreateScalingV2PolicyResponse> CreateScalingV2PolicyAsync(CreateScalingV2PolicyRequest createScalingV2PolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingV2PolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateScalingV2PolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩策略全量列表（V2版本）
        /// </summary>
        public async Task<ListAllScalingV2PoliciesResponse> ListAllScalingV2PoliciesAsync(ListAllScalingV2PoliciesRequest listAllScalingV2PoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllScalingV2PoliciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAllScalingV2PoliciesResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩策略列表（V2版本）
        /// </summary>
        public async Task<ListScalingV2PoliciesResponse> ListScalingV2PoliciesAsync(ListScalingV2PoliciesRequest listScalingV2PoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_resource_id" , listScalingV2PoliciesRequest.ScalingResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy/{scaling_resource_id}/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingV2PoliciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingV2PoliciesResponse>(response);
        }
        
        /// <summary>
        /// 查询指定弹性伸缩策略详情（V2版本）
        /// </summary>
        public async Task<ShowScalingV2PolicyResponse> ShowScalingV2PolicyAsync(ShowScalingV2PolicyRequest showScalingV2PolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id" , showScalingV2PolicyRequest.ScalingPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy/{scaling_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingV2PolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowScalingV2PolicyResponse>(response);
        }
        
        /// <summary>
        /// 修改弹性伸缩策略（V2版本）
        /// </summary>
        public async Task<UpdateScalingV2PolicyResponse> UpdateScalingV2PolicyAsync(UpdateScalingV2PolicyRequest updateScalingV2PolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id" , updateScalingV2PolicyRequest.ScalingPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy/{scaling_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScalingV2PolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateScalingV2PolicyResponse>(response);
        }
        
    }
}