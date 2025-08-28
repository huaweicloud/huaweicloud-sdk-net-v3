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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", attachCallbackInstanceLifeCycleHookRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_instance_hook/{scaling_group_id}/callback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachCallbackInstanceLifeCycleHookRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<AttachCallbackInstanceLifeCycleHookResponse>(response);
        }

        public SyncInvoker<AttachCallbackInstanceLifeCycleHookResponse> AttachCallbackInstanceLifeCycleHookInvoker(AttachCallbackInstanceLifeCycleHookRequest attachCallbackInstanceLifeCycleHookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", attachCallbackInstanceLifeCycleHookRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_instance_hook/{scaling_group_id}/callback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachCallbackInstanceLifeCycleHookRequest);
            return new SyncInvoker<AttachCallbackInstanceLifeCycleHookResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AttachCallbackInstanceLifeCycleHookResponse>);
        }
        
        /// <summary>
        /// 批量添加实例
        ///
        /// 批量移出伸缩组中的实例或批量添加伸缩组外的实例。批量对伸缩组中的实例设置或取消其实例保护属性。批量将伸缩组中的实例转入或移出备用状态。说明：- 单次最多批量操作实例个数为10。批量添加后实例数不能大于伸缩组的最大实例数，批量移出后实例数不能小于伸缩组的最小实例数。- 当伸缩组处于INSERVICE状态且没有伸缩活动时，才能添加实例。- 当伸缩组没有伸缩活动时，才能移出实例。- 向伸缩组中添加实例时，必须保证实例所在的可用区包含于伸缩组的可用区内。- 实例处于INSERVICE状态时才可以进行移出、设置或取消实例保护属性等操作。- 当伸缩组发生自动缩容活动时，设置了实例保护的实例不会被移出伸缩组。- 批量移出弹性伸缩组中的实例时，若该实例加入伸缩组时绑定的监听器和伸缩组本身的监听器相同，会解绑定实例和监听器。若该实例加入伸缩组时绑定的监听器和伸缩组本身的监听器不同，会保留实例和监听器的绑定关系。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchAddScalingInstancesResponse BatchAddScalingInstances(BatchAddScalingInstancesRequest batchAddScalingInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchAddScalingInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddScalingInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchAddScalingInstancesResponse>(response);
        }

        public SyncInvoker<BatchAddScalingInstancesResponse> BatchAddScalingInstancesInvoker(BatchAddScalingInstancesRequest batchAddScalingInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchAddScalingInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddScalingInstancesRequest);
            return new SyncInvoker<BatchAddScalingInstancesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchAddScalingInstancesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteScalingConfigsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteScalingConfigsResponse>(response);
        }

        public SyncInvoker<BatchDeleteScalingConfigsResponse> BatchDeleteScalingConfigsInvoker(BatchDeleteScalingConfigsRequest batchDeleteScalingConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteScalingConfigsRequest);
            return new SyncInvoker<BatchDeleteScalingConfigsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteScalingConfigsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policies/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteScalingPoliciesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteScalingPoliciesResponse>(response);
        }

        public SyncInvoker<BatchDeleteScalingPoliciesResponse> BatchDeleteScalingPoliciesInvoker(BatchDeleteScalingPoliciesRequest batchDeleteScalingPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policies/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteScalingPoliciesRequest);
            return new SyncInvoker<BatchDeleteScalingPoliciesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteScalingPoliciesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policies/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchPauseScalingPoliciesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchPauseScalingPoliciesResponse>(response);
        }

        public SyncInvoker<BatchPauseScalingPoliciesResponse> BatchPauseScalingPoliciesInvoker(BatchPauseScalingPoliciesRequest batchPauseScalingPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policies/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchPauseScalingPoliciesRequest);
            return new SyncInvoker<BatchPauseScalingPoliciesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchPauseScalingPoliciesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchProtectScalingInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchProtectScalingInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchProtectScalingInstancesResponse>(response);
        }

        public SyncInvoker<BatchProtectScalingInstancesResponse> BatchProtectScalingInstancesInvoker(BatchProtectScalingInstancesRequest batchProtectScalingInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchProtectScalingInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchProtectScalingInstancesRequest);
            return new SyncInvoker<BatchProtectScalingInstancesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchProtectScalingInstancesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchRemoveScalingInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRemoveScalingInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchRemoveScalingInstancesResponse>(response);
        }

        public SyncInvoker<BatchRemoveScalingInstancesResponse> BatchRemoveScalingInstancesInvoker(BatchRemoveScalingInstancesRequest batchRemoveScalingInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchRemoveScalingInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRemoveScalingInstancesRequest);
            return new SyncInvoker<BatchRemoveScalingInstancesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchRemoveScalingInstancesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policies/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchResumeScalingPoliciesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchResumeScalingPoliciesResponse>(response);
        }

        public SyncInvoker<BatchResumeScalingPoliciesResponse> BatchResumeScalingPoliciesInvoker(BatchResumeScalingPoliciesRequest batchResumeScalingPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policies/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchResumeScalingPoliciesRequest);
            return new SyncInvoker<BatchResumeScalingPoliciesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchResumeScalingPoliciesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchSetScalingInstancesStandbyRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchSetScalingInstancesStandbyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchSetScalingInstancesStandbyResponse>(response);
        }

        public SyncInvoker<BatchSetScalingInstancesStandbyResponse> BatchSetScalingInstancesStandbyInvoker(BatchSetScalingInstancesStandbyRequest batchSetScalingInstancesStandbyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchSetScalingInstancesStandbyRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchSetScalingInstancesStandbyRequest);
            return new SyncInvoker<BatchSetScalingInstancesStandbyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchSetScalingInstancesStandbyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchUnprotectScalingInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUnprotectScalingInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchUnprotectScalingInstancesResponse>(response);
        }

        public SyncInvoker<BatchUnprotectScalingInstancesResponse> BatchUnprotectScalingInstancesInvoker(BatchUnprotectScalingInstancesRequest batchUnprotectScalingInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchUnprotectScalingInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUnprotectScalingInstancesRequest);
            return new SyncInvoker<BatchUnprotectScalingInstancesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchUnprotectScalingInstancesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchUnsetScalingInstancesStantbyRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUnsetScalingInstancesStantbyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchUnsetScalingInstancesStantbyResponse>(response);
        }

        public SyncInvoker<BatchUnsetScalingInstancesStantbyResponse> BatchUnsetScalingInstancesStantbyInvoker(BatchUnsetScalingInstancesStantbyRequest batchUnsetScalingInstancesStantbyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchUnsetScalingInstancesStantbyRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUnsetScalingInstancesStantbyRequest);
            return new SyncInvoker<BatchUnsetScalingInstancesStantbyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchUnsetScalingInstancesStantbyResponse>);
        }
        
        /// <summary>
        /// 关闭暖池
        ///
        /// 关闭伸缩组的暖池
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CloseWarmPoolResponse CloseWarmPool(CloseWarmPoolRequest closeWarmPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", closeWarmPoolRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/{project_id}/scaling-groups/{scaling_group_id}/warm-pool", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", closeWarmPoolRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<CloseWarmPoolResponse>(response);
        }

        public SyncInvoker<CloseWarmPoolResponse> CloseWarmPoolInvoker(CloseWarmPoolRequest closeWarmPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", closeWarmPoolRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/{project_id}/scaling-groups/{scaling_group_id}/warm-pool", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", closeWarmPoolRequest);
            return new SyncInvoker<CloseWarmPoolResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CloseWarmPoolResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", createGroupScheduledTaskRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling-groups/{scaling_group_id}/scheduled-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGroupScheduledTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGroupScheduledTaskResponse>(response);
        }

        public SyncInvoker<CreateGroupScheduledTaskResponse> CreateGroupScheduledTaskInvoker(CreateGroupScheduledTaskRequest createGroupScheduledTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", createGroupScheduledTaskRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling-groups/{scaling_group_id}/scheduled-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGroupScheduledTaskRequest);
            return new SyncInvoker<CreateGroupScheduledTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGroupScheduledTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", createLifyCycleHookRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLifyCycleHookRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateLifyCycleHookResponse>(response);
        }

        public SyncInvoker<CreateLifyCycleHookResponse> CreateLifyCycleHookInvoker(CreateLifyCycleHookRequest createLifyCycleHookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", createLifyCycleHookRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLifyCycleHookRequest);
            return new SyncInvoker<CreateLifyCycleHookResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLifyCycleHookResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateScalingConfigResponse>(response);
        }

        public SyncInvoker<CreateScalingConfigResponse> CreateScalingConfigInvoker(CreateScalingConfigRequest createScalingConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingConfigRequest);
            return new SyncInvoker<CreateScalingConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateScalingConfigResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateScalingGroupResponse>(response);
        }

        public SyncInvoker<CreateScalingGroupResponse> CreateScalingGroupInvoker(CreateScalingGroupRequest createScalingGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingGroupRequest);
            return new SyncInvoker<CreateScalingGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateScalingGroupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", createScalingNotificationRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_notification/{scaling_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingNotificationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<CreateScalingNotificationResponse>(response);
        }

        public SyncInvoker<CreateScalingNotificationResponse> CreateScalingNotificationInvoker(CreateScalingNotificationRequest createScalingNotificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", createScalingNotificationRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_notification/{scaling_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingNotificationRequest);
            return new SyncInvoker<CreateScalingNotificationResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreateScalingNotificationResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateScalingPolicyResponse>(response);
        }

        public SyncInvoker<CreateScalingPolicyResponse> CreateScalingPolicyInvoker(CreateScalingPolicyRequest createScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingPolicyRequest);
            return new SyncInvoker<CreateScalingPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateScalingPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createScalingTagInfoRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createScalingTagInfoRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingTagInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateScalingTagInfoResponse>(response);
        }

        public SyncInvoker<CreateScalingTagInfoResponse> CreateScalingTagInfoInvoker(CreateScalingTagInfoRequest createScalingTagInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createScalingTagInfoRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createScalingTagInfoRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingTagInfoRequest);
            return new SyncInvoker<CreateScalingTagInfoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateScalingTagInfoResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", deleteGroupScheduledTaskRequest.ScalingGroupId.ToString());
            urlParam.Add("scheduled_task_id", deleteGroupScheduledTaskRequest.ScheduledTaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling-groups/{scaling_group_id}/scheduled-tasks/{scheduled_task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupScheduledTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGroupScheduledTaskResponse>(response);
        }

        public SyncInvoker<DeleteGroupScheduledTaskResponse> DeleteGroupScheduledTaskInvoker(DeleteGroupScheduledTaskRequest deleteGroupScheduledTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", deleteGroupScheduledTaskRequest.ScalingGroupId.ToString());
            urlParam.Add("scheduled_task_id", deleteGroupScheduledTaskRequest.ScheduledTaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling-groups/{scaling_group_id}/scheduled-tasks/{scheduled_task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupScheduledTaskRequest);
            return new SyncInvoker<DeleteGroupScheduledTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGroupScheduledTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", deleteLifecycleHookRequest.ScalingGroupId.ToString());
            urlParam.Add("lifecycle_hook_name", deleteLifecycleHookRequest.LifecycleHookName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/{lifecycle_hook_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLifecycleHookRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLifecycleHookResponse>(response);
        }

        public SyncInvoker<DeleteLifecycleHookResponse> DeleteLifecycleHookInvoker(DeleteLifecycleHookRequest deleteLifecycleHookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", deleteLifecycleHookRequest.ScalingGroupId.ToString());
            urlParam.Add("lifecycle_hook_name", deleteLifecycleHookRequest.LifecycleHookName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/{lifecycle_hook_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLifecycleHookRequest);
            return new SyncInvoker<DeleteLifecycleHookResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLifecycleHookResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_configuration_id", deleteScalingConfigRequest.ScalingConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration/{scaling_configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingConfigRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteScalingConfigResponse>(response);
        }

        public SyncInvoker<DeleteScalingConfigResponse> DeleteScalingConfigInvoker(DeleteScalingConfigRequest deleteScalingConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_configuration_id", deleteScalingConfigRequest.ScalingConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration/{scaling_configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingConfigRequest);
            return new SyncInvoker<DeleteScalingConfigResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScalingConfigResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", deleteScalingGroupRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteScalingGroupResponse>(response);
        }

        public SyncInvoker<DeleteScalingGroupResponse> DeleteScalingGroupInvoker(DeleteScalingGroupRequest deleteScalingGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", deleteScalingGroupRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingGroupRequest);
            return new SyncInvoker<DeleteScalingGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScalingGroupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteScalingInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingInstanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteScalingInstanceResponse>(response);
        }

        public SyncInvoker<DeleteScalingInstanceResponse> DeleteScalingInstanceInvoker(DeleteScalingInstanceRequest deleteScalingInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteScalingInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingInstanceRequest);
            return new SyncInvoker<DeleteScalingInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScalingInstanceResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", deleteScalingNotificationRequest.ScalingGroupId.ToString());
            urlParam.Add("topic_urn", deleteScalingNotificationRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_notification/{scaling_group_id}/{topic_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingNotificationRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteScalingNotificationResponse>(response);
        }

        public SyncInvoker<DeleteScalingNotificationResponse> DeleteScalingNotificationInvoker(DeleteScalingNotificationRequest deleteScalingNotificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", deleteScalingNotificationRequest.ScalingGroupId.ToString());
            urlParam.Add("topic_urn", deleteScalingNotificationRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_notification/{scaling_group_id}/{topic_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingNotificationRequest);
            return new SyncInvoker<DeleteScalingNotificationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScalingNotificationResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", deleteScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingPolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteScalingPolicyResponse>(response);
        }

        public SyncInvoker<DeleteScalingPolicyResponse> DeleteScalingPolicyInvoker(DeleteScalingPolicyRequest deleteScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", deleteScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingPolicyRequest);
            return new SyncInvoker<DeleteScalingPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScalingPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", deleteScalingTagInfoRequest.ResourceType.ToString());
            urlParam.Add("resource_id", deleteScalingTagInfoRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteScalingTagInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteScalingTagInfoResponse>(response);
        }

        public SyncInvoker<DeleteScalingTagInfoResponse> DeleteScalingTagInfoInvoker(DeleteScalingTagInfoRequest deleteScalingTagInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", deleteScalingTagInfoRequest.ResourceType.ToString());
            urlParam.Add("resource_id", deleteScalingTagInfoRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteScalingTagInfoRequest);
            return new SyncInvoker<DeleteScalingTagInfoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteScalingTagInfoResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", executeScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeScalingPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ExecuteScalingPolicyResponse>(response);
        }

        public SyncInvoker<ExecuteScalingPolicyResponse> ExecuteScalingPolicyInvoker(ExecuteScalingPolicyRequest executeScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", executeScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeScalingPolicyRequest);
            return new SyncInvoker<ExecuteScalingPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ExecuteScalingPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listGroupScheduledTasksRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling-groups/{scaling_group_id}/scheduled-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupScheduledTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGroupScheduledTasksResponse>(response);
        }

        public SyncInvoker<ListGroupScheduledTasksResponse> ListGroupScheduledTasksInvoker(ListGroupScheduledTasksRequest listGroupScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listGroupScheduledTasksRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling-groups/{scaling_group_id}/scheduled-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupScheduledTasksRequest);
            return new SyncInvoker<ListGroupScheduledTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupScheduledTasksResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listHookInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_instance_hook/{scaling_group_id}/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHookInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHookInstancesResponse>(response);
        }

        public SyncInvoker<ListHookInstancesResponse> ListHookInstancesInvoker(ListHookInstancesRequest listHookInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listHookInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_instance_hook/{scaling_group_id}/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHookInstancesRequest);
            return new SyncInvoker<ListHookInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHookInstancesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listLifeCycleHooksRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLifeCycleHooksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLifeCycleHooksResponse>(response);
        }

        public SyncInvoker<ListLifeCycleHooksResponse> ListLifeCycleHooksInvoker(ListLifeCycleHooksRequest listLifeCycleHooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listLifeCycleHooksRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLifeCycleHooksRequest);
            return new SyncInvoker<ListLifeCycleHooksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLifeCycleHooksResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceInstancesRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListResourceInstancesResponse>(response);
        }

        public SyncInvoker<ListResourceInstancesResponse> ListResourceInstancesInvoker(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceInstancesRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            return new SyncInvoker<ListResourceInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceInstancesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listScalingActivityLogsRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_activity_log/{scaling_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingActivityLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScalingActivityLogsResponse>(response);
        }

        public SyncInvoker<ListScalingActivityLogsResponse> ListScalingActivityLogsInvoker(ListScalingActivityLogsRequest listScalingActivityLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listScalingActivityLogsRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_activity_log/{scaling_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingActivityLogsRequest);
            return new SyncInvoker<ListScalingActivityLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingActivityLogsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listScalingActivityV2LogsRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_activity_log/{scaling_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingActivityV2LogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScalingActivityV2LogsResponse>(response);
        }

        public SyncInvoker<ListScalingActivityV2LogsResponse> ListScalingActivityV2LogsInvoker(ListScalingActivityV2LogsRequest listScalingActivityV2LogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listScalingActivityV2LogsRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_activity_log/{scaling_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingActivityV2LogsRequest);
            return new SyncInvoker<ListScalingActivityV2LogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingActivityV2LogsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScalingConfigsResponse>(response);
        }

        public SyncInvoker<ListScalingConfigsResponse> ListScalingConfigsInvoker(ListScalingConfigsRequest listScalingConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingConfigsRequest);
            return new SyncInvoker<ListScalingConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingConfigsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScalingGroupsResponse>(response);
        }

        public SyncInvoker<ListScalingGroupsResponse> ListScalingGroupsInvoker(ListScalingGroupsRequest listScalingGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingGroupsRequest);
            return new SyncInvoker<ListScalingGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingGroupsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listScalingInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScalingInstancesResponse>(response);
        }

        public SyncInvoker<ListScalingInstancesResponse> ListScalingInstancesInvoker(ListScalingInstancesRequest listScalingInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listScalingInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingInstancesRequest);
            return new SyncInvoker<ListScalingInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingInstancesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listScalingNotificationsRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_notification/{scaling_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingNotificationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScalingNotificationsResponse>(response);
        }

        public SyncInvoker<ListScalingNotificationsResponse> ListScalingNotificationsInvoker(ListScalingNotificationsRequest listScalingNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listScalingNotificationsRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_notification/{scaling_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingNotificationsRequest);
            return new SyncInvoker<ListScalingNotificationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingNotificationsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listScalingPoliciesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_group_id}/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingPoliciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScalingPoliciesResponse>(response);
        }

        public SyncInvoker<ListScalingPoliciesResponse> ListScalingPoliciesInvoker(ListScalingPoliciesRequest listScalingPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listScalingPoliciesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_group_id}/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingPoliciesRequest);
            return new SyncInvoker<ListScalingPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingPoliciesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", listScalingPolicyExecuteLogsRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy_execute_log/{scaling_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingPolicyExecuteLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScalingPolicyExecuteLogsResponse>(response);
        }

        public SyncInvoker<ListScalingPolicyExecuteLogsResponse> ListScalingPolicyExecuteLogsInvoker(ListScalingPolicyExecuteLogsRequest listScalingPolicyExecuteLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", listScalingPolicyExecuteLogsRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy_execute_log/{scaling_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingPolicyExecuteLogsRequest);
            return new SyncInvoker<ListScalingPolicyExecuteLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingPolicyExecuteLogsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listScalingTagInfosByResourceIdRequest.ResourceType.ToString());
            urlParam.Add("resource_id", listScalingTagInfosByResourceIdRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingTagInfosByResourceIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScalingTagInfosByResourceIdResponse>(response);
        }

        public SyncInvoker<ListScalingTagInfosByResourceIdResponse> ListScalingTagInfosByResourceIdInvoker(ListScalingTagInfosByResourceIdRequest listScalingTagInfosByResourceIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listScalingTagInfosByResourceIdRequest.ResourceType.ToString());
            urlParam.Add("resource_id", listScalingTagInfosByResourceIdRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingTagInfosByResourceIdRequest);
            return new SyncInvoker<ListScalingTagInfosByResourceIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingTagInfosByResourceIdResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listScalingTagInfosByTenantIdRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingTagInfosByTenantIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScalingTagInfosByTenantIdResponse>(response);
        }

        public SyncInvoker<ListScalingTagInfosByTenantIdResponse> ListScalingTagInfosByTenantIdInvoker(ListScalingTagInfosByTenantIdRequest listScalingTagInfosByTenantIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listScalingTagInfosByTenantIdRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingTagInfosByTenantIdRequest);
            return new SyncInvoker<ListScalingTagInfosByTenantIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingTagInfosByTenantIdResponse>);
        }
        
        /// <summary>
        /// 查询暖池内实例信息
        ///
        /// 查询暖池内实例信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWarmPoolInstancesResponse ListWarmPoolInstances(ListWarmPoolInstancesRequest listWarmPoolInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listWarmPoolInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/{project_id}/scaling-groups/{scaling_group_id}/warm-pool-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWarmPoolInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListWarmPoolInstancesResponse>(response);
        }

        public SyncInvoker<ListWarmPoolInstancesResponse> ListWarmPoolInstancesInvoker(ListWarmPoolInstancesRequest listWarmPoolInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listWarmPoolInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/{project_id}/scaling-groups/{scaling_group_id}/warm-pool-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWarmPoolInstancesRequest);
            return new SyncInvoker<ListWarmPoolInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWarmPoolInstancesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", pauseScalingGroupRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", pauseScalingGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<PauseScalingGroupResponse>(response);
        }

        public SyncInvoker<PauseScalingGroupResponse> PauseScalingGroupInvoker(PauseScalingGroupRequest pauseScalingGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", pauseScalingGroupRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", pauseScalingGroupRequest);
            return new SyncInvoker<PauseScalingGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<PauseScalingGroupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", pauseScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", pauseScalingPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<PauseScalingPolicyResponse>(response);
        }

        public SyncInvoker<PauseScalingPolicyResponse> PauseScalingPolicyInvoker(PauseScalingPolicyRequest pauseScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", pauseScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", pauseScalingPolicyRequest);
            return new SyncInvoker<PauseScalingPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<PauseScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 开启暖池
        ///
        /// 开启并修改暖池参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public PutWarmPoolResponse PutWarmPool(PutWarmPoolRequest putWarmPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", putWarmPoolRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/{project_id}/scaling-groups/{scaling_group_id}/warm-pool", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", putWarmPoolRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<PutWarmPoolResponse>(response);
        }

        public SyncInvoker<PutWarmPoolResponse> PutWarmPoolInvoker(PutWarmPoolRequest putWarmPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", putWarmPoolRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/{project_id}/scaling-groups/{scaling_group_id}/warm-pool", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", putWarmPoolRequest);
            return new SyncInvoker<PutWarmPoolResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<PutWarmPoolResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", resumeScalingGroupRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resumeScalingGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ResumeScalingGroupResponse>(response);
        }

        public SyncInvoker<ResumeScalingGroupResponse> ResumeScalingGroupInvoker(ResumeScalingGroupRequest resumeScalingGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", resumeScalingGroupRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resumeScalingGroupRequest);
            return new SyncInvoker<ResumeScalingGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResumeScalingGroupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", resumeScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resumeScalingPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ResumeScalingPolicyResponse>(response);
        }

        public SyncInvoker<ResumeScalingPolicyResponse> ResumeScalingPolicyInvoker(ResumeScalingPolicyRequest resumeScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", resumeScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resumeScalingPolicyRequest);
            return new SyncInvoker<ResumeScalingPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResumeScalingPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", showLifeCycleHookRequest.ScalingGroupId.ToString());
            urlParam.Add("lifecycle_hook_name", showLifeCycleHookRequest.LifecycleHookName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/{lifecycle_hook_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLifeCycleHookRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLifeCycleHookResponse>(response);
        }

        public SyncInvoker<ShowLifeCycleHookResponse> ShowLifeCycleHookInvoker(ShowLifeCycleHookRequest showLifeCycleHookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", showLifeCycleHookRequest.ScalingGroupId.ToString());
            urlParam.Add("lifecycle_hook_name", showLifeCycleHookRequest.LifecycleHookName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/{lifecycle_hook_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLifeCycleHookRequest);
            return new SyncInvoker<ShowLifeCycleHookResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLifeCycleHookResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", showPolicyAndInstanceQuotaRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/quotas/{scaling_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyAndInstanceQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPolicyAndInstanceQuotaResponse>(response);
        }

        public SyncInvoker<ShowPolicyAndInstanceQuotaResponse> ShowPolicyAndInstanceQuotaInvoker(ShowPolicyAndInstanceQuotaRequest showPolicyAndInstanceQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", showPolicyAndInstanceQuotaRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/quotas/{scaling_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyAndInstanceQuotaRequest);
            return new SyncInvoker<ShowPolicyAndInstanceQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPolicyAndInstanceQuotaResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceQuotaResponse>(response);
        }

        public SyncInvoker<ShowResourceQuotaResponse> ShowResourceQuotaInvoker(ShowResourceQuotaRequest showResourceQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceQuotaRequest);
            return new SyncInvoker<ShowResourceQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceQuotaResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_configuration_id", showScalingConfigRequest.ScalingConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration/{scaling_configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowScalingConfigResponse>(response);
        }

        public SyncInvoker<ShowScalingConfigResponse> ShowScalingConfigInvoker(ShowScalingConfigRequest showScalingConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_configuration_id", showScalingConfigRequest.ScalingConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration/{scaling_configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingConfigRequest);
            return new SyncInvoker<ShowScalingConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowScalingConfigResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", showScalingGroupRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowScalingGroupResponse>(response);
        }

        public SyncInvoker<ShowScalingGroupResponse> ShowScalingGroupInvoker(ShowScalingGroupRequest showScalingGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", showScalingGroupRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingGroupRequest);
            return new SyncInvoker<ShowScalingGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowScalingGroupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", showScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowScalingPolicyResponse>(response);
        }

        public SyncInvoker<ShowScalingPolicyResponse> ShowScalingPolicyInvoker(ShowScalingPolicyRequest showScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", showScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingPolicyRequest);
            return new SyncInvoker<ShowScalingPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 查询暖池信息
        ///
        /// 查询暖池信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowWarmPoolResponse ShowWarmPool(ShowWarmPoolRequest showWarmPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", showWarmPoolRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/{project_id}/scaling-groups/{scaling_group_id}/warm-pool", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWarmPoolRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowWarmPoolResponse>(response);
        }

        public SyncInvoker<ShowWarmPoolResponse> ShowWarmPoolInvoker(ShowWarmPoolRequest showWarmPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", showWarmPoolRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/{project_id}/scaling-groups/{scaling_group_id}/warm-pool", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWarmPoolRequest);
            return new SyncInvoker<ShowWarmPoolResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWarmPoolResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", updateGroupScheduledTaskRequest.ScalingGroupId.ToString());
            urlParam.Add("scheduled_task_id", updateGroupScheduledTaskRequest.ScheduledTaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling-groups/{scaling_group_id}/scheduled-tasks/{scheduled_task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGroupScheduledTaskRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateGroupScheduledTaskResponse>(response);
        }

        public SyncInvoker<UpdateGroupScheduledTaskResponse> UpdateGroupScheduledTaskInvoker(UpdateGroupScheduledTaskRequest updateGroupScheduledTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", updateGroupScheduledTaskRequest.ScalingGroupId.ToString());
            urlParam.Add("scheduled_task_id", updateGroupScheduledTaskRequest.ScheduledTaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling-groups/{scaling_group_id}/scheduled-tasks/{scheduled_task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGroupScheduledTaskRequest);
            return new SyncInvoker<UpdateGroupScheduledTaskResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateGroupScheduledTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", updateLifeCycleHookRequest.ScalingGroupId.ToString());
            urlParam.Add("lifecycle_hook_name", updateLifeCycleHookRequest.LifecycleHookName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/{lifecycle_hook_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLifeCycleHookRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLifeCycleHookResponse>(response);
        }

        public SyncInvoker<UpdateLifeCycleHookResponse> UpdateLifeCycleHookInvoker(UpdateLifeCycleHookRequest updateLifeCycleHookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", updateLifeCycleHookRequest.ScalingGroupId.ToString());
            urlParam.Add("lifecycle_hook_name", updateLifeCycleHookRequest.LifecycleHookName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/{lifecycle_hook_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLifeCycleHookRequest);
            return new SyncInvoker<UpdateLifeCycleHookResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLifeCycleHookResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", updateScalingGroupRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScalingGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateScalingGroupResponse>(response);
        }

        public SyncInvoker<UpdateScalingGroupResponse> UpdateScalingGroupInvoker(UpdateScalingGroupRequest updateScalingGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", updateScalingGroupRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScalingGroupRequest);
            return new SyncInvoker<UpdateScalingGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateScalingGroupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", updateScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScalingPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateScalingPolicyResponse>(response);
        }

        public SyncInvoker<UpdateScalingPolicyResponse> UpdateScalingPolicyInvoker(UpdateScalingPolicyRequest updateScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", updateScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScalingPolicyRequest);
            return new SyncInvoker<UpdateScalingPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateScalingPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }

        public SyncInvoker<ListApiVersionsResponse> ListApiVersionsInvoker(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            return new SyncInvoker<ListApiVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version", showApiVersionRequest.ApiVersion.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }

        public SyncInvoker<ShowApiVersionResponse> ShowApiVersionInvoker(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version", showApiVersionRequest.ApiVersion.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            return new SyncInvoker<ShowApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApiVersionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingV2PolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateScalingV2PolicyResponse>(response);
        }

        public SyncInvoker<CreateScalingV2PolicyResponse> CreateScalingV2PolicyInvoker(CreateScalingV2PolicyRequest createScalingV2PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingV2PolicyRequest);
            return new SyncInvoker<CreateScalingV2PolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateScalingV2PolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllScalingV2PoliciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAllScalingV2PoliciesResponse>(response);
        }

        public SyncInvoker<ListAllScalingV2PoliciesResponse> ListAllScalingV2PoliciesInvoker(ListAllScalingV2PoliciesRequest listAllScalingV2PoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllScalingV2PoliciesRequest);
            return new SyncInvoker<ListAllScalingV2PoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllScalingV2PoliciesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_resource_id", listScalingV2PoliciesRequest.ScalingResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy/{scaling_resource_id}/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingV2PoliciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScalingV2PoliciesResponse>(response);
        }

        public SyncInvoker<ListScalingV2PoliciesResponse> ListScalingV2PoliciesInvoker(ListScalingV2PoliciesRequest listScalingV2PoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_resource_id", listScalingV2PoliciesRequest.ScalingResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy/{scaling_resource_id}/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingV2PoliciesRequest);
            return new SyncInvoker<ListScalingV2PoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingV2PoliciesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", showScalingV2PolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy/{scaling_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingV2PolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowScalingV2PolicyResponse>(response);
        }

        public SyncInvoker<ShowScalingV2PolicyResponse> ShowScalingV2PolicyInvoker(ShowScalingV2PolicyRequest showScalingV2PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", showScalingV2PolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy/{scaling_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingV2PolicyRequest);
            return new SyncInvoker<ShowScalingV2PolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowScalingV2PolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", updateScalingV2PolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy/{scaling_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScalingV2PolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateScalingV2PolicyResponse>(response);
        }

        public SyncInvoker<UpdateScalingV2PolicyResponse> UpdateScalingV2PolicyInvoker(UpdateScalingV2PolicyRequest updateScalingV2PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", updateScalingV2PolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy/{scaling_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScalingV2PolicyRequest);
            return new SyncInvoker<UpdateScalingV2PolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateScalingV2PolicyResponse>);
        }
        
    }
}