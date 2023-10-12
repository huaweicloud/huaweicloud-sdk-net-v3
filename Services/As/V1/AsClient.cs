using System;
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
        ///
        /// 通过生命周期操作令牌或者通过实例ID和生命周期挂钩名称对伸缩实例指定的挂钩进行回调操作。如果在超时时间结束前已完成自定义操作，选择终止或继续完成生命周期操作。如果需要更多时间完成自定义操作，选择延长超时时间，实例保持等待状态的时间将增加1小时。只有实例的生命周期挂钩状态为 HANGING 时才可以进行回调操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 批量移出伸缩组中的实例或批量添加伸缩组外的实例。批量对伸缩组中的实例设置或取消其实例保护属性。批量将伸缩组中的实例转入或移出备用状态。
        /// 说明：
        /// - 单次最多批量操作实例个数为10。批量添加后实例数不能大于伸缩组的最大实例数，批量移出后实例数不能小于伸缩组的最小实例数。
        /// - 当伸缩组处于INSERVICE状态且没有伸缩活动时，才能添加实例。
        /// - 当伸缩组没有伸缩活动时，才能移出实例。
        /// - 向伸缩组中添加实例时，必须保证实例所在的可用区包含于伸缩组的可用区内。
        /// - 实例处于INSERVICE状态时才可以进行移出、设置或取消实例保护属性等操作。
        /// - 当伸缩组发生自动缩容活动时，设置了实例保护的实例不会被移出伸缩组。
        /// - 批量移出弹性伸缩组中的实例时，若该实例加入伸缩组时绑定的监听器和伸缩组本身的监听器相同，会解绑定实例和监听器。若该实例加入伸缩组时绑定的监听器和伸缩组本身的监听器不同，会保留实例和监听器的绑定关系。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 批量删除指定弹性伸缩配置。被伸缩组使用的伸缩配置不能被删除。单次最多删除伸缩配置个数为50。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 批量启用、停用或者删除弹性伸缩策略。单次最多批量操作伸缩策略个数为20。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 批量启用、停用或者删除弹性伸缩策略。单次最多批量操作伸缩策略个数为20。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 批量移出伸缩组中的实例或批量添加伸缩组外的实例。批量对伸缩组中的实例设置或取消其实例保护属性。批量将伸缩组中的实例转入或移出备用状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 批量移出伸缩组中的实例或批量添加伸缩组外的实例。批量对伸缩组中的实例设置或取消其实例保护属性。批量将伸缩组中的实例转入或移出备用状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 批量启用、停用或者删除弹性伸缩策略。单次最多批量操作伸缩策略个数为20。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 批量移出伸缩组中的实例或批量添加伸缩组外的实例。批量对伸缩组中的实例设置或取消其实例保护属性。批量将伸缩组中的实例转入或移出备用状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 批量移出伸缩组中的实例或批量添加伸缩组外的实例。批量对伸缩组中的实例设置或取消其实例保护属性。批量将伸缩组中的实例转入或移出备用状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 批量移出伸缩组中的实例或批量添加伸缩组外的实例。批量对伸缩组中的实例设置或取消其实例保护属性。批量将伸缩组中的实例转入或移出备用状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 创建计划任务
        ///
        /// 创建计划任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGroupScheduledTaskResponse CreateGroupScheduledTask(CreateGroupScheduledTaskRequest createGroupScheduledTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , createGroupScheduledTaskRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling-groups/{scaling_group_id}/scheduled-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGroupScheduledTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateGroupScheduledTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建生命周期挂钩
        ///
        /// 创建生命周期挂钩，可为伸缩组添加一个或多个生命周期挂钩，最多添加5个。添加生命周期挂钩后，当伸缩组进行伸缩活动时，实例将被生命周期挂钩挂起并置于等待状态（正在加入伸缩组或正在移出伸缩组），实例将保持此状态直至超时时间结束或者用户手动回调。用户能够在实例保持等待状态的时间段内执行自定义操作，例如，用户可以在新启动的实例上安装或配置软件，也可以在实例终止前从实例中下载日志文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 创建弹性伸缩配置。伸缩配置是伸缩组内实例（弹性云服务器云主机）的模板，定义了伸缩组内待添加的实例的规格数据。伸缩配置与伸缩组是解耦的，同一伸缩配置可以被多个伸缩组使用。默认最多可以创建100个伸缩配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 伸缩组是具有相同应用场景的实例的集合，是启停伸缩策略和进行伸缩活动的基本单位。伸缩组内定义了最大实例数、期望实例数、最小实例数、虚拟私有云、子网、负载均衡等信息。默认最多可以创建10个伸缩组。如果伸缩组配置了负载均衡，在添加或移除实例时，会自动为实例绑定或解绑负载均衡监听器。如果伸缩组使用负载均衡健康检查方式，伸缩组中的实例需要启用负载均衡器的监听端口才能通过健康检查。端口启用可在安全组中进行配置，可参考添加安全组规则进行操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 给弹性伸缩组配置通知功能。每调用一次该接口，伸缩组即配置一个通知主题及其通知场景，每个伸缩组最多可以增加5个主题。通知主题由用户事先在SMN创建并进行订阅，当通知主题对应的通知场景出现时，伸缩组会向用户的订阅终端发送通知。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 创建弹性伸缩策略。伸缩策略定义了伸缩组内实例的扩张和收缩操作。如果执行伸缩策略造成伸缩组期望实例数与伸缩组内实例数不符，弹性伸缩会自动调整实例资源，以匹配期望实例数。当前伸缩策略支持告警触发策略，周期触发策略，定时触发策略。在策略执行具体动作中，可设置实例变化的个数，或根据当前实例的百分比数进行伸缩。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 创建或删除指定资源的标签。每个伸缩组最多添加10个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 删除计划任务
        ///
        /// 删除计划任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGroupScheduledTaskResponse DeleteGroupScheduledTask(DeleteGroupScheduledTaskRequest deleteGroupScheduledTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , deleteGroupScheduledTaskRequest.ScalingGroupId.ToString());
            urlParam.Add("scheduled_task_id" , deleteGroupScheduledTaskRequest.ScheduledTaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling-groups/{scaling_group_id}/scheduled-tasks/{scheduled_task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupScheduledTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteGroupScheduledTaskResponse>(response);
        }
        
        /// <summary>
        /// 删除生命周期挂钩
        ///
        /// 删除一个指定生命周期挂钩。伸缩组进行伸缩活动时，不允许删除该伸缩组内的生命周期挂钩。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 删除一个指定弹性伸缩配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 删除一个指定弹性伸缩组。force_delete属性表示如果伸缩组存在ECS实例或正在进行伸缩活动，是否强制删除伸缩组并移出和释放ECS实例。默认值为no，表示不强制删除伸缩组。如果force_delete的值为no，必须满足以下两个条件，才能删除伸缩组：条件一：伸缩组没有正在进行的伸缩活动。条件二：伸缩组当前的ECS实例数量（current_instance_number）为0。如果force_delete的值为yes，伸缩组会被置于DELETING状态，拒绝接收新的伸缩活动请求，然后等待已有的伸缩活动完成，最后将伸缩组内所有ECS实例移出伸缩组（用户手动添加的ECS实例会被移出伸缩组，弹性伸缩自动创建的ECS实例会被自动删除）并删除伸缩组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 从弹性伸缩组中移出一个指定实例。实例处于INSERVICE且移出后实例数不能小于伸缩组的最小实例数时才可以移出。当伸缩组没有伸缩活动时，才能移出实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 删除指定的弹性伸缩组中指定的通知。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 删除一个指定弹性伸缩策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 创建或删除指定资源的标签。每个伸缩组最多添加10个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 立即执行或启用或停止一个指定弹性伸缩策略。当伸缩组、伸缩策略状态处于INSERVICE时，伸缩策略才能被正确执行，否则会执行失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 查询计划任务列表
        ///
        /// 查询计划任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupScheduledTasksResponse ListGroupScheduledTasks(ListGroupScheduledTasksRequest listGroupScheduledTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , listGroupScheduledTasksRequest.ScalingGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling-groups/{scaling_group_id}/scheduled-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupScheduledTasksRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListGroupScheduledTasksResponse>(response);
        }
        
        /// <summary>
        /// 查询伸缩实例挂起信息
        ///
        /// 添加生命周期挂钩后，当伸缩组进行伸缩活动时，实例将被挂钩挂起并置于等待状态，根据输入条件过滤查询弹性伸缩组中伸缩实例的挂起信息。可根据实例ID进行条件过滤查询。若不加过滤条件默认查询指定伸缩组内所有实例挂起信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据伸缩组ID查询生命周期挂钩列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据项目ID查询指定资源类型的资源实例。资源、资源tag默认按照创建时间倒序。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据输入条件过滤查询伸缩活动日志。查询结果分页显示。可根据起始时间，截止时间，起始行号，记录数进行条件过滤查询。若不加过滤条件默认查询最多20条伸缩活动日志信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据输入条件过滤查询伸缩活动日志，支持查询实例伸缩、ELB迁移、实例备用等类型活动。查询结果分页显示。查询伸缩活动日志V2版本与V1版本区别在于，V2版本展示了更详细的实例伸缩日志，如ELB迁移日志，实例备用日志信息。可根据起始时间，截止时间，起始行号，记录数，伸缩活动类型等作为条件过滤查询。若不加过滤条件默认查询最多20条伸缩活动日志信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据输入条件过滤查询弹性伸缩配置。查询结果分页显示。可以根据伸缩配置名称，镜像ID，起始行号，记录条数进行条件过滤查询。若不加过滤条件默认最多查询租户下20条伸缩配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据输入条件过滤查询弹性伸缩组列表。查询结果分页显示。可根据伸缩组名称，伸缩配置ID，伸缩组状态，企业项目ID，起始行号，记录条数进行条件过滤查询。若不加过滤条件默认最多查询租户下20条伸缩组信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据输入条件过滤查询弹性伸缩组中实例信息。查询结果分页显示。可根据实例在伸缩组中的生命周期状态，实例健康状态，实例保护状态，起始行号，记录条数进行条件过滤查询。若不加过滤条件默认查询组内最多20条实例信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据伸缩组ID查询指定弹性伸缩组的通知列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据输入条件过滤查询弹性伸缩策略。查询结果分页显示。可根据伸缩策略名称，策略类型，伸缩策略ID，起始行号，记录数进行条件过滤查询。若不加过滤条件默认查询租户下指定伸缩组内最多20条伸缩策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据输入条件过滤查询策略执行的历史记录。查询结果分页显示。可根据日志ID，伸缩资源类型，伸缩资源ID，策略执行类型，查询额起始，查询截止时间，查询起始行号，查询记录数进行条件过滤查询。若不加过滤条件默认查询最多20条策略执行日志信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据项目ID和资源ID查询指定资源类型的资源标签列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据项目ID查询指定资源类型的标签列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 启用或停止一个指定弹性伸缩组。已停用状态的伸缩组，不会自动触发任何伸缩活动。当伸缩组正在进行伸缩活动，即使停用，正在进行的伸缩活动也不会立即停止。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 立即执行或启用或停止一个指定弹性伸缩策略。当伸缩组、伸缩策略状态处于INSERVICE时，伸缩策略才能被正确执行，否则会执行失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 启用或停止一个指定弹性伸缩组。已停用状态的伸缩组，不会自动触发任何伸缩活动。当伸缩组正在进行伸缩活动，即使停用，正在进行的伸缩活动也不会立即停止。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 立即执行或启用或停止一个指定弹性伸缩策略。当伸缩组、伸缩策略状态处于INSERVICE时，伸缩策略才能被正确执行，否则会执行失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据伸缩组ID及生命周期挂钩名称查询指定的生命周期挂钩详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据伸缩组ID查询指定弹性伸缩组下的伸缩策略和伸缩实例的配额总数及已使用配额数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询指定租户下的弹性伸缩组、伸缩配置、伸缩带宽策略、伸缩策略和伸缩实例的配额总数及已使用配额数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据伸缩配置ID查询一个弹性伸缩配置的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询一个指定弹性伸缩组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询指定弹性伸缩策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 更新计划任务
        ///
        /// 更新计划任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGroupScheduledTaskResponse UpdateGroupScheduledTask(UpdateGroupScheduledTaskRequest updateGroupScheduledTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id" , updateGroupScheduledTaskRequest.ScalingGroupId.ToString());
            urlParam.Add("scheduled_task_id" , updateGroupScheduledTaskRequest.ScheduledTaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling-groups/{scaling_group_id}/scheduled-tasks/{scheduled_task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGroupScheduledTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateGroupScheduledTaskResponse>(response);
        }
        
        /// <summary>
        /// 修改生命周期挂钩
        ///
        /// 修改一个指定生命周期挂钩中的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 修改一个指定弹性伸缩组中的信息。更换伸缩组的伸缩配置，伸缩组中已经存在的使用之前伸缩配置创建的云服务器云主机不受影响。伸缩组为没有正在进行的伸缩活动时，可以修改伸缩组的子网、可用区和负载均衡配置。当伸缩组的期望实例数改变时，会触发伸缩活动加入或移出实例。期望实例数必须大于或等于最小实例数，必须小于或等于最大实例数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 修改指定弹性伸缩策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询弹性伸缩API所有版本信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据租户id和资源id查询指定资源类型的标签列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 可针对不同类型资源如伸缩组或带宽，创建弹性伸缩策略。创建弹性伸缩策略V2版本与V1版本的区别在于，V2版本支持创建对带宽资源进行调整的策略，通过伸缩资源类型区分伸缩资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据输入条件过滤查询弹性伸缩策略，支持查询当前租户下全量伸缩策略。查询结果分页显示。可根据伸缩资源ID，伸缩资源类型，伸缩策略名称，伸缩策略ID，告警ID，企业项目ID，起始行号，记录数，排序方式等条件进行过滤查询。若不加过滤添加默认查询该租户下最多20条伸缩策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 根据输入条件过滤查询弹性伸缩策略。查询结果分页显示。查询弹性伸缩策略V2版本与V1版本的区别在于，V2版本响应含伸缩资源类型。可根据伸缩策略名称，策略类型，伸缩策略ID，起始行号，记录数进行条件过滤查询。若不加过滤条件默认查询该租户下指定资源下最多20条伸缩策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询指定弹性伸缩策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 修改指定弹性伸缩策略。修改弹性伸缩策略V2版本与V1版本的区别在于，V2版本支持修改伸缩资源类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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