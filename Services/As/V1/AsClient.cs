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
        /// 批量删除弹性伸缩配置
        /// </summary>
        public BatchDeleteScalingConfigsResponse BatchDeleteScalingConfigs(BatchDeleteScalingConfigsRequest batchDeleteScalingConfigsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configurations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteScalingConfigsRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteScalingConfigsResponse>(response);
        }
        
        /// <summary>
        /// 伸缩实例生命周期回调
        /// </summary>
        public CompleteLifecycleActionResponse CompleteLifecycleAction(CompleteLifecycleActionRequest completeLifecycleActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , completeLifecycleActionRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_instance_hook/{scaling_group_id}/callback",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", completeLifecycleActionRequest);
            SdkResponse response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<CompleteLifecycleActionResponse>(response);
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
            SdkResponse response = DoHttpRequestSync("POST",request);
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
            SdkResponse response = DoHttpRequestSync("POST",request);
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
            SdkResponse response = DoHttpRequestSync("POST",request);
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
            SdkResponse response = DoHttpRequestSync("PUT",request);
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
            SdkResponse response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateScalingPolicyResponse>(response);
        }
        
        /// <summary>
        /// 创建标签
        /// </summary>
        public CreateScalingTagsResponse CreateScalingTags(CreateScalingTagsRequest createScalingTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , createScalingTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , createScalingTagsRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/{resource_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingTagsRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateScalingTagsResponse>(response);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteLifecycleHookRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteScalingConfigRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteScalingGroupRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteScalingInstanceRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteScalingNotificationRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteScalingPolicyRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteScalingPolicyResponse>(response);
        }
        
        /// <summary>
        /// 删除标签
        /// </summary>
        public DeleteScalingTagsResponse DeleteScalingTags(DeleteScalingTagsRequest deleteScalingTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , deleteScalingTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , deleteScalingTagsRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/{resource_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteScalingTagsRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<DeleteScalingTagsResponse>(response);
        }
        
        /// <summary>
        /// 启用或停止弹性伸缩组
        /// </summary>
        public EnableOrDisableScalingGroupResponse EnableOrDisableScalingGroup(EnableOrDisableScalingGroupRequest enableOrDisableScalingGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , enableOrDisableScalingGroupRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableOrDisableScalingGroupRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<EnableOrDisableScalingGroupResponse>(response);
        }
        
        /// <summary>
        /// 执行或启用或停止弹性伸缩策略。
        /// </summary>
        public ExecuteScalingPolicyResponse ExecuteScalingPolicy(ExecuteScalingPolicyRequest executeScalingPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id" , executeScalingPolicyRequest.ScalingPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeScalingPolicyRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listHookInstancesRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listLifeCycleHooksRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkResponse response = DoHttpRequestSync("POST",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listScalingActivityLogsRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListScalingActivityLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩配置列表
        /// </summary>
        public ListScalingConfigsResponse ListScalingConfigs(ListScalingConfigsRequest listScalingConfigsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listScalingConfigsRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListScalingConfigsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性伸缩组列表
        /// </summary>
        public ListScalingGroupsResponse ListScalingGroups(ListScalingGroupsRequest listScalingGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listScalingGroupsRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listScalingInstancesRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listScalingNotificationsRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listScalingPoliciesRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listScalingPolicyExecuteLogsRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listScalingTagInfosByResourceIdRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listScalingTagInfosByTenantIdRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListScalingTagInfosByTenantIdResponse>(response);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showLifeCycleHookRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showPolicyAndInstanceQuotaRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPolicyAndInstanceQuotaResponse>(response);
        }
        
        /// <summary>
        /// 查询配额
        /// </summary>
        public ShowResourceQuotaResponse ShowResourceQuota(ShowResourceQuotaRequest showResourceQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showResourceQuotaRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showScalingConfigRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showScalingGroupRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showScalingPolicyRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
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
            SdkResponse response = DoHttpRequestSync("PUT",request);
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
            SdkResponse response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateScalingGroupResponse>(response);
        }
        
        /// <summary>
        /// 批量操作实例
        /// </summary>
        public UpdateScalingGroupInstanceResponse UpdateScalingGroupInstance(UpdateScalingGroupInstanceRequest updateScalingGroupInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , updateScalingGroupInstanceRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScalingGroupInstanceRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateScalingGroupInstanceResponse>(response);
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
            SdkResponse response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateScalingPolicyResponse>(response);
        }
        
    }
}