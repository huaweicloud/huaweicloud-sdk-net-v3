using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.As.V1.Model;

namespace HuaweiCloud.SDK.As.V1
{
    public partial class AsClient : Client
    {
        public static ClientBuilder<AsClient> NewBuilder()
        {
            return new ClientBuilder<AsClient>();
        }

        
        /// <summary>
        /// 伸缩实例生命周期回调
        /// </summary>
        public AttachCallbackInstanceLifeCycleHookResponse AttachCallbackInstanceLifeCycleHook(AttachCallbackInstanceLifeCycleHookRequest attachCallbackInstanceLifeCycleHookRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , attachCallbackInstanceLifeCycleHookRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_instance_hook/{scaling_group_id}/callback",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachCallbackInstanceLifeCycleHookRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<AttachCallbackInstanceLifeCycleHookResponse>(response);
        }
        
        /// <summary>
        /// 批量添加实例
        /// </summary>
        public BatchAddScalingInstancesResponse BatchAddScalingInstances(BatchAddScalingInstancesRequest batchAddScalingInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , batchAddScalingInstancesRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddScalingInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchAddScalingInstancesResponse>(response);
        }
        
        /// <summary>
        /// 批量删除弹性伸缩配置
        /// </summary>
        public BatchDeleteScalingConfigsResponse BatchDeleteScalingConfigs(BatchDeleteScalingConfigsRequest batchDeleteScalingConfigsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteScalingConfigsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteScalingConfigsResponse>(response);
        }
        
        /// <summary>
        /// 批量删除弹性伸缩策略。
        /// </summary>
        public BatchDeleteScalingPoliciesResponse BatchDeleteScalingPolicies(BatchDeleteScalingPoliciesRequest batchDeleteScalingPoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policies/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteScalingPoliciesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteScalingPoliciesResponse>(response);
        }
        
        /// <summary>
        /// 批量停用弹性伸缩策略。
        /// </summary>
        public BatchPauseScalingPoliciesResponse BatchPauseScalingPolicies(BatchPauseScalingPoliciesRequest batchPauseScalingPoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policies/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchPauseScalingPoliciesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchPauseScalingPoliciesResponse>(response);
        }
        
        /// <summary>
        /// 批量设置实例保护
        /// </summary>
        public BatchProtectScalingInstancesResponse BatchProtectScalingInstances(BatchProtectScalingInstancesRequest batchProtectScalingInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , batchProtectScalingInstancesRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchProtectScalingInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchProtectScalingInstancesResponse>(response);
        }
        
        /// <summary>
        /// 批量移除实例
        /// </summary>
        public BatchRemoveScalingInstancesResponse BatchRemoveScalingInstances(BatchRemoveScalingInstancesRequest batchRemoveScalingInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , batchRemoveScalingInstancesRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRemoveScalingInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchRemoveScalingInstancesResponse>(response);
        }
        
        /// <summary>
        /// 批量启用弹性伸缩策略。
        /// </summary>
        public BatchResumeScalingPoliciesResponse BatchResumeScalingPolicies(BatchResumeScalingPoliciesRequest batchResumeScalingPoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policies/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchResumeScalingPoliciesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchResumeScalingPoliciesResponse>(response);
        }
        
        /// <summary>
        /// 批量将实例转为备用状态
        /// </summary>
        public BatchSetScalingInstancesStandbyResponse BatchSetScalingInstancesStandby(BatchSetScalingInstancesStandbyRequest batchSetScalingInstancesStandbyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , batchSetScalingInstancesStandbyRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchSetScalingInstancesStandbyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchSetScalingInstancesStandbyResponse>(response);
        }
        
        /// <summary>
        /// 批量取消实例保护
        /// </summary>
        public BatchUnprotectScalingInstancesResponse BatchUnprotectScalingInstances(BatchUnprotectScalingInstancesRequest batchUnprotectScalingInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , batchUnprotectScalingInstancesRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUnprotectScalingInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchUnprotectScalingInstancesResponse>(response);
        }
        
        /// <summary>
        /// 批量将实例移出备用状态
        /// </summary>
        public BatchUnsetScalingInstancesStantbyResponse BatchUnsetScalingInstancesStantby(BatchUnsetScalingInstancesStantbyRequest batchUnsetScalingInstancesStantbyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , batchUnsetScalingInstancesStantbyRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUnsetScalingInstancesStantbyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchUnsetScalingInstancesStantbyResponse>(response);
        }
        
        /// <summary>
        /// 创建生命周期挂钩
        /// </summary>
        public CreateLifyCycleHookResponse CreateLifyCycleHook(CreateLifyCycleHookRequest createLifyCycleHookRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , createLifyCycleHookRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLifyCycleHookRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateLifyCycleHookResponse>(response);
        }
        
        /// <summary>
        /// 创建弹性伸缩配置
        /// </summary>
        public CreateScalingConfigResponse CreateScalingConfig(CreateScalingConfigRequest createScalingConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateScalingConfigResponse>(response);
        }
        
        /// <summary>
        /// 创建弹性伸缩组
        /// </summary>
        public CreateScalingGroupResponse CreateScalingGroup(CreateScalingGroupRequest createScalingGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateScalingGroupResponse>(response);
        }
        
        /// <summary>
        /// 配置伸缩组通知
        /// </summary>
        public CreateScalingNotificationResponse CreateScalingNotification(CreateScalingNotificationRequest createScalingNotificationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , createScalingNotificationRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_notification/{scaling_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingNotificationRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<CreateScalingNotificationResponse>(response);
        }
        
        /// <summary>
        /// 创建弹性伸缩策略
        /// </summary>
        public CreateScalingPolicyResponse CreateScalingPolicy(CreateScalingPolicyRequest createScalingPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateScalingPolicyResponse>(response);
        }
        
        /// <summary>
        /// 创建标签
        /// </summary>
        public CreateScalingTagInfoResponse CreateScalingTagInfo(CreateScalingTagInfoRequest createScalingTagInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , createScalingTagInfoRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , createScalingTagInfoRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/{resource_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingTagInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateScalingTagInfoResponse>(response);
        }
        
        /// <summary>
        /// 删除生命周期挂钩
        /// </summary>
        public DeleteLifecycleHookResponse DeleteLifecycleHook(DeleteLifecycleHookRequest deleteLifecycleHookRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , deleteLifecycleHookRequest.ScalingGroupId.ToString());
            urlParam.Add("lifecycle_hook_name" , deleteLifecycleHookRequest.LifecycleHookName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/{lifecycle_hook_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLifecycleHookRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteLifecycleHookResponse>(response);
        }
        
        /// <summary>
        /// 删除弹性伸缩配置
        /// </summary>
        public DeleteScalingConfigResponse DeleteScalingConfig(DeleteScalingConfigRequest deleteScalingConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_configuration_id" , deleteScalingConfigRequest.ScalingConfigurationId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration/{scaling_configuration_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteScalingConfigResponse>(response);
        }
        
        /// <summary>
        /// 删除弹性伸缩组
        /// </summary>
        public DeleteScalingGroupResponse DeleteScalingGroup(DeleteScalingGroupRequest deleteScalingGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , deleteScalingGroupRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteScalingGroupResponse>(response);
        }
        
        /// <summary>
        /// 移出弹性伸缩组实例
        /// </summary>
        public DeleteScalingInstanceResponse DeleteScalingInstance(DeleteScalingInstanceRequest deleteScalingInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteScalingInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteScalingInstanceResponse>(response);
        }
        
        /// <summary>
        /// 删除伸缩组通知
        /// </summary>
        public DeleteScalingNotificationResponse DeleteScalingNotification(DeleteScalingNotificationRequest deleteScalingNotificationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , deleteScalingNotificationRequest.ScalingGroupId.ToString());
            urlParam.Add("topic_urn" , deleteScalingNotificationRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_notification/{scaling_group_id}/{topic_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingNotificationRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteScalingNotificationResponse>(response);
        }
        
        /// <summary>
        /// 删除弹性伸缩策略
        /// </summary>
        public DeleteScalingPolicyResponse DeleteScalingPolicy(DeleteScalingPolicyRequest deleteScalingPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id" , deleteScalingPolicyRequest.ScalingPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteScalingPolicyResponse>(response);
        }
        
        /// <summary>
        /// 删除标签
        /// </summary>
        public DeleteScalingTagInfoResponse DeleteScalingTagInfo(DeleteScalingTagInfoRequest deleteScalingTagInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , deleteScalingTagInfoRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , deleteScalingTagInfoRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/{resource_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteScalingTagInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<DeleteScalingTagInfoResponse>(response);
        }
        
        /// <summary>
        /// 执行弹性伸缩策略。
        /// </summary>
        public ExecuteScalingPolicyResponse ExecuteScalingPolicy(ExecuteScalingPolicyRequest executeScalingPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id" , executeScalingPolicyRequest.ScalingPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeScalingPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<ExecuteScalingPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询伸缩实例挂起信息
        /// </summary>
        public ListHookInstancesResponse ListHookInstances(ListHookInstancesRequest listHookInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , listHookInstancesRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_instance_hook/{scaling_group_id}/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHookInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListHookInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询生命周期挂钩列表
        /// </summary>
        public ListLifeCycleHooksResponse ListLifeCycleHooks(ListLifeCycleHooksRequest listLifeCycleHooksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , listLifeCycleHooksRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLifeCycleHooksRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListLifeCycleHooksResponse>(response);
        }
        
        /// <summary>
        /// 查询资源实例
        /// </summary>
        public ListResourceInstancesResponse ListResourceInstances(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listResourceInstancesRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListResourceInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询伸缩活动日志
        /// </summary>
        public ListScalingActivityLogsResponse ListScalingActivityLogs(ListScalingActivityLogsRequest listScalingActivityLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , listScalingActivityLogsRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_activity_log/{scaling_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingActivityLogsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListScalingActivityLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询伸缩活动日志v2版本
        /// </summary>
        public ListScalingActivityV2LogsResponse ListScalingActivityV2Logs(ListScalingActivityV2LogsRequest listScalingActivityV2LogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , listScalingActivityV2LogsRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_activity_log/{scaling_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingActivityV2LogsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListScalingActivityV2LogsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩配置列表
        /// </summary>
        public ListScalingConfigsResponse ListScalingConfigs(ListScalingConfigsRequest listScalingConfigsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingConfigsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListScalingConfigsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩组列表
        /// </summary>
        public ListScalingGroupsResponse ListScalingGroups(ListScalingGroupsRequest listScalingGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingGroupsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListScalingGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩组中的实例列表
        /// </summary>
        public ListScalingInstancesResponse ListScalingInstances(ListScalingInstancesRequest listScalingInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , listScalingInstancesRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListScalingInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询伸缩组通知列表
        /// </summary>
        public ListScalingNotificationsResponse ListScalingNotifications(ListScalingNotificationsRequest listScalingNotificationsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , listScalingNotificationsRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_notification/{scaling_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingNotificationsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListScalingNotificationsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩策略列表
        /// </summary>
        public ListScalingPoliciesResponse ListScalingPolicies(ListScalingPoliciesRequest listScalingPoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , listScalingPoliciesRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_group_id}/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingPoliciesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListScalingPoliciesResponse>(response);
        }
        
        /// <summary>
        /// 查询策略执行日志
        /// </summary>
        public ListScalingPolicyExecuteLogsResponse ListScalingPolicyExecuteLogs(ListScalingPolicyExecuteLogsRequest listScalingPolicyExecuteLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id" , listScalingPolicyExecuteLogsRequest.ScalingPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy_execute_log/{scaling_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingPolicyExecuteLogsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListScalingPolicyExecuteLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询资源标签
        /// </summary>
        public ListScalingTagInfosByResourceIdResponse ListScalingTagInfosByResourceId(ListScalingTagInfosByResourceIdRequest listScalingTagInfosByResourceIdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listScalingTagInfosByResourceIdRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , listScalingTagInfosByResourceIdRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/{resource_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingTagInfosByResourceIdRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListScalingTagInfosByResourceIdResponse>(response);
        }
        
        /// <summary>
        /// 查询标签
        /// </summary>
        public ListScalingTagInfosByTenantIdResponse ListScalingTagInfosByTenantId(ListScalingTagInfosByTenantIdRequest listScalingTagInfosByTenantIdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listScalingTagInfosByTenantIdRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingTagInfosByTenantIdRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListScalingTagInfosByTenantIdResponse>(response);
        }
        
        /// <summary>
        /// 停止弹性伸缩组
        /// </summary>
        public PauseScalingGroupResponse PauseScalingGroup(PauseScalingGroupRequest pauseScalingGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , pauseScalingGroupRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", pauseScalingGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<PauseScalingGroupResponse>(response);
        }
        
        /// <summary>
        /// 停止弹性伸缩策略。
        /// </summary>
        public PauseScalingPolicyResponse PauseScalingPolicy(PauseScalingPolicyRequest pauseScalingPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id" , pauseScalingPolicyRequest.ScalingPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", pauseScalingPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<PauseScalingPolicyResponse>(response);
        }
        
        /// <summary>
        /// 启用弹性伸缩组
        /// </summary>
        public ResumeScalingGroupResponse ResumeScalingGroup(ResumeScalingGroupRequest resumeScalingGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , resumeScalingGroupRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resumeScalingGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<ResumeScalingGroupResponse>(response);
        }
        
        /// <summary>
        /// 启用弹性伸缩策略。
        /// </summary>
        public ResumeScalingPolicyResponse ResumeScalingPolicy(ResumeScalingPolicyRequest resumeScalingPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id" , resumeScalingPolicyRequest.ScalingPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resumeScalingPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<ResumeScalingPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询生命周期挂钩详情
        /// </summary>
        public ShowLifeCycleHookResponse ShowLifeCycleHook(ShowLifeCycleHookRequest showLifeCycleHookRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , showLifeCycleHookRequest.ScalingGroupId.ToString());
            urlParam.Add("lifecycle_hook_name" , showLifeCycleHookRequest.LifecycleHookName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/{lifecycle_hook_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLifeCycleHookRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowLifeCycleHookResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩策略和伸缩实例配额
        /// </summary>
        public ShowPolicyAndInstanceQuotaResponse ShowPolicyAndInstanceQuota(ShowPolicyAndInstanceQuotaRequest showPolicyAndInstanceQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , showPolicyAndInstanceQuotaRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/quotas/{scaling_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyAndInstanceQuotaRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPolicyAndInstanceQuotaResponse>(response);
        }
        
        /// <summary>
        /// 查询配额
        /// </summary>
        public ShowResourceQuotaResponse ShowResourceQuota(ShowResourceQuotaRequest showResourceQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceQuotaRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowResourceQuotaResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩配置详情
        /// </summary>
        public ShowScalingConfigResponse ShowScalingConfig(ShowScalingConfigRequest showScalingConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_configuration_id" , showScalingConfigRequest.ScalingConfigurationId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration/{scaling_configuration_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowScalingConfigResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩组详情
        /// </summary>
        public ShowScalingGroupResponse ShowScalingGroup(ShowScalingGroupRequest showScalingGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , showScalingGroupRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowScalingGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩策略详情
        /// </summary>
        public ShowScalingPolicyResponse ShowScalingPolicy(ShowScalingPolicyRequest showScalingPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id" , showScalingPolicyRequest.ScalingPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowScalingPolicyResponse>(response);
        }
        
        /// <summary>
        /// 修改生命周期挂钩
        /// </summary>
        public UpdateLifeCycleHookResponse UpdateLifeCycleHook(UpdateLifeCycleHookRequest updateLifeCycleHookRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , updateLifeCycleHookRequest.ScalingGroupId.ToString());
            urlParam.Add("lifecycle_hook_name" , updateLifeCycleHookRequest.LifecycleHookName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/{lifecycle_hook_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLifeCycleHookRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateLifeCycleHookResponse>(response);
        }
        
        /// <summary>
        /// 修改弹性伸缩组
        /// </summary>
        public UpdateScalingGroupResponse UpdateScalingGroup(UpdateScalingGroupRequest updateScalingGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , updateScalingGroupRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScalingGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateScalingGroupResponse>(response);
        }
        
        /// <summary>
        /// 修改弹性伸缩策略
        /// </summary>
        public UpdateScalingPolicyResponse UpdateScalingPolicy(UpdateScalingPolicyRequest updateScalingPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id" , updateScalingPolicyRequest.ScalingPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScalingPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateScalingPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩API所有版本信息
        /// </summary>
        public ListApiVersionsResponse ListApiVersions(ListApiVersionsRequest listApiVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩API指定版本信息
        /// </summary>
        public ShowApiVersionResponse ShowApiVersion(ShowApiVersionRequest showApiVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version" , showApiVersionRequest.ApiVersion.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{api_version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }
        
        /// <summary>
        /// 创建弹性伸缩策略（V2版本）
        /// </summary>
        public CreateScalingV2PolicyResponse CreateScalingV2Policy(CreateScalingV2PolicyRequest createScalingV2PolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingV2PolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateScalingV2PolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩策略全量列表（V2版本）
        /// </summary>
        public ListAllScalingV2PoliciesResponse ListAllScalingV2Policies(ListAllScalingV2PoliciesRequest listAllScalingV2PoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllScalingV2PoliciesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAllScalingV2PoliciesResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩策略列表（V2版本）
        /// </summary>
        public ListScalingV2PoliciesResponse ListScalingV2Policies(ListScalingV2PoliciesRequest listScalingV2PoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_resource_id" , listScalingV2PoliciesRequest.ScalingResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy/{scaling_resource_id}/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingV2PoliciesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListScalingV2PoliciesResponse>(response);
        }
        
        /// <summary>
        /// 查询指定弹性伸缩策略详情（V2版本）
        /// </summary>
        public ShowScalingV2PolicyResponse ShowScalingV2Policy(ShowScalingV2PolicyRequest showScalingV2PolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id" , showScalingV2PolicyRequest.ScalingPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy/{scaling_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingV2PolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowScalingV2PolicyResponse>(response);
        }
        
        /// <summary>
        /// 修改弹性伸缩策略（V2版本）
        /// </summary>
        public UpdateScalingV2PolicyResponse UpdateScalingV2Policy(UpdateScalingV2PolicyRequest updateScalingV2PolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id" , updateScalingV2PolicyRequest.ScalingPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy/{scaling_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScalingV2PolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateScalingV2PolicyResponse>(response);
        }
        
    }
}