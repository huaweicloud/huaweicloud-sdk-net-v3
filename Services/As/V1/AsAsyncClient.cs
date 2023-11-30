using System;
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
        /// 伸缩实例生命周期回调
        ///
        /// 通过生命周期操作令牌或者通过实例ID和生命周期挂钩名称对伸缩实例指定的挂钩进行回调操作。如果在超时时间结束前已完成自定义操作，选择终止或继续完成生命周期操作。如果需要更多时间完成自定义操作，选择延长超时时间，实例保持等待状态的时间将增加1小时。只有实例的生命周期挂钩状态为 HANGING 时才可以进行回调操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AttachCallbackInstanceLifeCycleHookResponse> AttachCallbackInstanceLifeCycleHookAsync(AttachCallbackInstanceLifeCycleHookRequest attachCallbackInstanceLifeCycleHookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", attachCallbackInstanceLifeCycleHookRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_instance_hook/{scaling_group_id}/callback",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachCallbackInstanceLifeCycleHookRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<AttachCallbackInstanceLifeCycleHookResponse>(response);
        }

        public AsyncInvoker<AttachCallbackInstanceLifeCycleHookResponse> AttachCallbackInstanceLifeCycleHookAsyncInvoker(AttachCallbackInstanceLifeCycleHookRequest attachCallbackInstanceLifeCycleHookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", attachCallbackInstanceLifeCycleHookRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_instance_hook/{scaling_group_id}/callback",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachCallbackInstanceLifeCycleHookRequest);
            return new AsyncInvoker<AttachCallbackInstanceLifeCycleHookResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AttachCallbackInstanceLifeCycleHookResponse>);
        }
        
        /// <summary>
        /// 批量添加实例
        ///
        /// 批量移出伸缩组中的实例或批量添加伸缩组外的实例。批量对伸缩组中的实例设置或取消其实例保护属性。批量将伸缩组中的实例转入或移出备用状态。说明：- 单次最多批量操作实例个数为10。批量添加后实例数不能大于伸缩组的最大实例数，批量移出后实例数不能小于伸缩组的最小实例数。- 当伸缩组处于INSERVICE状态且没有伸缩活动时，才能添加实例。- 当伸缩组没有伸缩活动时，才能移出实例。- 向伸缩组中添加实例时，必须保证实例所在的可用区包含于伸缩组的可用区内。- 实例处于INSERVICE状态时才可以进行移出、设置或取消实例保护属性等操作。- 当伸缩组发生自动缩容活动时，设置了实例保护的实例不会被移出伸缩组。- 批量移出弹性伸缩组中的实例时，若该实例加入伸缩组时绑定的监听器和伸缩组本身的监听器相同，会解绑定实例和监听器。若该实例加入伸缩组时绑定的监听器和伸缩组本身的监听器不同，会保留实例和监听器的绑定关系。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchAddScalingInstancesResponse> BatchAddScalingInstancesAsync(BatchAddScalingInstancesRequest batchAddScalingInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchAddScalingInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddScalingInstancesRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchAddScalingInstancesResponse>(response);
        }

        public AsyncInvoker<BatchAddScalingInstancesResponse> BatchAddScalingInstancesAsyncInvoker(BatchAddScalingInstancesRequest batchAddScalingInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchAddScalingInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddScalingInstancesRequest);
            return new AsyncInvoker<BatchAddScalingInstancesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchAddScalingInstancesResponse>);
        }
        
        /// <summary>
        /// 批量删除弹性伸缩配置
        ///
        /// 批量删除指定弹性伸缩配置。被伸缩组使用的伸缩配置不能被删除。单次最多删除伸缩配置个数为50。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteScalingConfigsResponse> BatchDeleteScalingConfigsAsync(BatchDeleteScalingConfigsRequest batchDeleteScalingConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configurations",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteScalingConfigsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteScalingConfigsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteScalingConfigsResponse> BatchDeleteScalingConfigsAsyncInvoker(BatchDeleteScalingConfigsRequest batchDeleteScalingConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configurations",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteScalingConfigsRequest);
            return new AsyncInvoker<BatchDeleteScalingConfigsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteScalingConfigsResponse>);
        }
        
        /// <summary>
        /// 批量删除弹性伸缩策略。
        ///
        /// 批量启用、停用或者删除弹性伸缩策略。单次最多批量操作伸缩策略个数为20。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteScalingPoliciesResponse> BatchDeleteScalingPoliciesAsync(BatchDeleteScalingPoliciesRequest batchDeleteScalingPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policies/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteScalingPoliciesRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteScalingPoliciesResponse>(response);
        }

        public AsyncInvoker<BatchDeleteScalingPoliciesResponse> BatchDeleteScalingPoliciesAsyncInvoker(BatchDeleteScalingPoliciesRequest batchDeleteScalingPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policies/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteScalingPoliciesRequest);
            return new AsyncInvoker<BatchDeleteScalingPoliciesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteScalingPoliciesResponse>);
        }
        
        /// <summary>
        /// 批量停用弹性伸缩策略。
        ///
        /// 批量启用、停用或者删除弹性伸缩策略。单次最多批量操作伸缩策略个数为20。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchPauseScalingPoliciesResponse> BatchPauseScalingPoliciesAsync(BatchPauseScalingPoliciesRequest batchPauseScalingPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policies/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchPauseScalingPoliciesRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchPauseScalingPoliciesResponse>(response);
        }

        public AsyncInvoker<BatchPauseScalingPoliciesResponse> BatchPauseScalingPoliciesAsyncInvoker(BatchPauseScalingPoliciesRequest batchPauseScalingPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policies/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchPauseScalingPoliciesRequest);
            return new AsyncInvoker<BatchPauseScalingPoliciesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchPauseScalingPoliciesResponse>);
        }
        
        /// <summary>
        /// 批量设置实例保护
        ///
        /// 批量移出伸缩组中的实例或批量添加伸缩组外的实例。批量对伸缩组中的实例设置或取消其实例保护属性。批量将伸缩组中的实例转入或移出备用状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchProtectScalingInstancesResponse> BatchProtectScalingInstancesAsync(BatchProtectScalingInstancesRequest batchProtectScalingInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchProtectScalingInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchProtectScalingInstancesRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchProtectScalingInstancesResponse>(response);
        }

        public AsyncInvoker<BatchProtectScalingInstancesResponse> BatchProtectScalingInstancesAsyncInvoker(BatchProtectScalingInstancesRequest batchProtectScalingInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchProtectScalingInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchProtectScalingInstancesRequest);
            return new AsyncInvoker<BatchProtectScalingInstancesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchProtectScalingInstancesResponse>);
        }
        
        /// <summary>
        /// 批量移除实例
        ///
        /// 批量移出伸缩组中的实例或批量添加伸缩组外的实例。批量对伸缩组中的实例设置或取消其实例保护属性。批量将伸缩组中的实例转入或移出备用状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchRemoveScalingInstancesResponse> BatchRemoveScalingInstancesAsync(BatchRemoveScalingInstancesRequest batchRemoveScalingInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchRemoveScalingInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRemoveScalingInstancesRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchRemoveScalingInstancesResponse>(response);
        }

        public AsyncInvoker<BatchRemoveScalingInstancesResponse> BatchRemoveScalingInstancesAsyncInvoker(BatchRemoveScalingInstancesRequest batchRemoveScalingInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchRemoveScalingInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRemoveScalingInstancesRequest);
            return new AsyncInvoker<BatchRemoveScalingInstancesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchRemoveScalingInstancesResponse>);
        }
        
        /// <summary>
        /// 批量启用弹性伸缩策略。
        ///
        /// 批量启用、停用或者删除弹性伸缩策略。单次最多批量操作伸缩策略个数为20。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchResumeScalingPoliciesResponse> BatchResumeScalingPoliciesAsync(BatchResumeScalingPoliciesRequest batchResumeScalingPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policies/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchResumeScalingPoliciesRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchResumeScalingPoliciesResponse>(response);
        }

        public AsyncInvoker<BatchResumeScalingPoliciesResponse> BatchResumeScalingPoliciesAsyncInvoker(BatchResumeScalingPoliciesRequest batchResumeScalingPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policies/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchResumeScalingPoliciesRequest);
            return new AsyncInvoker<BatchResumeScalingPoliciesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchResumeScalingPoliciesResponse>);
        }
        
        /// <summary>
        /// 批量将实例转为备用状态
        ///
        /// 批量移出伸缩组中的实例或批量添加伸缩组外的实例。批量对伸缩组中的实例设置或取消其实例保护属性。批量将伸缩组中的实例转入或移出备用状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchSetScalingInstancesStandbyResponse> BatchSetScalingInstancesStandbyAsync(BatchSetScalingInstancesStandbyRequest batchSetScalingInstancesStandbyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchSetScalingInstancesStandbyRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchSetScalingInstancesStandbyRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchSetScalingInstancesStandbyResponse>(response);
        }

        public AsyncInvoker<BatchSetScalingInstancesStandbyResponse> BatchSetScalingInstancesStandbyAsyncInvoker(BatchSetScalingInstancesStandbyRequest batchSetScalingInstancesStandbyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchSetScalingInstancesStandbyRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchSetScalingInstancesStandbyRequest);
            return new AsyncInvoker<BatchSetScalingInstancesStandbyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchSetScalingInstancesStandbyResponse>);
        }
        
        /// <summary>
        /// 批量取消实例保护
        ///
        /// 批量移出伸缩组中的实例或批量添加伸缩组外的实例。批量对伸缩组中的实例设置或取消其实例保护属性。批量将伸缩组中的实例转入或移出备用状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUnprotectScalingInstancesResponse> BatchUnprotectScalingInstancesAsync(BatchUnprotectScalingInstancesRequest batchUnprotectScalingInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchUnprotectScalingInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUnprotectScalingInstancesRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchUnprotectScalingInstancesResponse>(response);
        }

        public AsyncInvoker<BatchUnprotectScalingInstancesResponse> BatchUnprotectScalingInstancesAsyncInvoker(BatchUnprotectScalingInstancesRequest batchUnprotectScalingInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchUnprotectScalingInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUnprotectScalingInstancesRequest);
            return new AsyncInvoker<BatchUnprotectScalingInstancesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchUnprotectScalingInstancesResponse>);
        }
        
        /// <summary>
        /// 批量将实例移出备用状态
        ///
        /// 批量移出伸缩组中的实例或批量添加伸缩组外的实例。批量对伸缩组中的实例设置或取消其实例保护属性。批量将伸缩组中的实例转入或移出备用状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUnsetScalingInstancesStantbyResponse> BatchUnsetScalingInstancesStantbyAsync(BatchUnsetScalingInstancesStantbyRequest batchUnsetScalingInstancesStantbyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchUnsetScalingInstancesStantbyRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUnsetScalingInstancesStantbyRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchUnsetScalingInstancesStantbyResponse>(response);
        }

        public AsyncInvoker<BatchUnsetScalingInstancesStantbyResponse> BatchUnsetScalingInstancesStantbyAsyncInvoker(BatchUnsetScalingInstancesStantbyRequest batchUnsetScalingInstancesStantbyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", batchUnsetScalingInstancesStantbyRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUnsetScalingInstancesStantbyRequest);
            return new AsyncInvoker<BatchUnsetScalingInstancesStantbyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchUnsetScalingInstancesStantbyResponse>);
        }
        
        /// <summary>
        /// 创建计划任务
        ///
        /// 创建计划任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGroupScheduledTaskResponse> CreateGroupScheduledTaskAsync(CreateGroupScheduledTaskRequest createGroupScheduledTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", createGroupScheduledTaskRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling-groups/{scaling_group_id}/scheduled-tasks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGroupScheduledTaskRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateGroupScheduledTaskResponse>(response);
        }

        public AsyncInvoker<CreateGroupScheduledTaskResponse> CreateGroupScheduledTaskAsyncInvoker(CreateGroupScheduledTaskRequest createGroupScheduledTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", createGroupScheduledTaskRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling-groups/{scaling_group_id}/scheduled-tasks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGroupScheduledTaskRequest);
            return new AsyncInvoker<CreateGroupScheduledTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGroupScheduledTaskResponse>);
        }
        
        /// <summary>
        /// 创建生命周期挂钩
        ///
        /// 创建生命周期挂钩，可为伸缩组添加一个或多个生命周期挂钩，最多添加5个。添加生命周期挂钩后，当伸缩组进行伸缩活动时，实例将被生命周期挂钩挂起并置于等待状态（正在加入伸缩组或正在移出伸缩组），实例将保持此状态直至超时时间结束或者用户手动回调。用户能够在实例保持等待状态的时间段内执行自定义操作，例如，用户可以在新启动的实例上安装或配置软件，也可以在实例终止前从实例中下载日志文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLifyCycleHookResponse> CreateLifyCycleHookAsync(CreateLifyCycleHookRequest createLifyCycleHookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", createLifyCycleHookRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLifyCycleHookRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateLifyCycleHookResponse>(response);
        }

        public AsyncInvoker<CreateLifyCycleHookResponse> CreateLifyCycleHookAsyncInvoker(CreateLifyCycleHookRequest createLifyCycleHookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", createLifyCycleHookRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLifyCycleHookRequest);
            return new AsyncInvoker<CreateLifyCycleHookResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLifyCycleHookResponse>);
        }
        
        /// <summary>
        /// 创建弹性伸缩配置
        ///
        /// 创建弹性伸缩配置。伸缩配置是伸缩组内实例（弹性云服务器云主机）的模板，定义了伸缩组内待添加的实例的规格数据。伸缩配置与伸缩组是解耦的，同一伸缩配置可以被多个伸缩组使用。默认最多可以创建100个伸缩配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateScalingConfigResponse> CreateScalingConfigAsync(CreateScalingConfigRequest createScalingConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingConfigRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateScalingConfigResponse>(response);
        }

        public AsyncInvoker<CreateScalingConfigResponse> CreateScalingConfigAsyncInvoker(CreateScalingConfigRequest createScalingConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingConfigRequest);
            return new AsyncInvoker<CreateScalingConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateScalingConfigResponse>);
        }
        
        /// <summary>
        /// 创建弹性伸缩组
        ///
        /// 伸缩组是具有相同应用场景的实例的集合，是启停伸缩策略和进行伸缩活动的基本单位。伸缩组内定义了最大实例数、期望实例数、最小实例数、虚拟私有云、子网、负载均衡等信息。默认最多可以创建10个伸缩组。如果伸缩组配置了负载均衡，在添加或移除实例时，会自动为实例绑定或解绑负载均衡监听器。如果伸缩组使用负载均衡健康检查方式，伸缩组中的实例需要启用负载均衡器的监听端口才能通过健康检查。端口启用可在安全组中进行配置，可参考添加安全组规则进行操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateScalingGroupResponse> CreateScalingGroupAsync(CreateScalingGroupRequest createScalingGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingGroupRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateScalingGroupResponse>(response);
        }

        public AsyncInvoker<CreateScalingGroupResponse> CreateScalingGroupAsyncInvoker(CreateScalingGroupRequest createScalingGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingGroupRequest);
            return new AsyncInvoker<CreateScalingGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateScalingGroupResponse>);
        }
        
        /// <summary>
        /// 配置伸缩组通知
        ///
        /// 给弹性伸缩组配置通知功能。每调用一次该接口，伸缩组即配置一个通知主题及其通知场景，每个伸缩组最多可以增加5个主题。通知主题由用户事先在SMN创建并进行订阅，当通知主题对应的通知场景出现时，伸缩组会向用户的订阅终端发送通知。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateScalingNotificationResponse> CreateScalingNotificationAsync(CreateScalingNotificationRequest createScalingNotificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", createScalingNotificationRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_notification/{scaling_group_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingNotificationRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<CreateScalingNotificationResponse>(response);
        }

        public AsyncInvoker<CreateScalingNotificationResponse> CreateScalingNotificationAsyncInvoker(CreateScalingNotificationRequest createScalingNotificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", createScalingNotificationRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_notification/{scaling_group_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingNotificationRequest);
            return new AsyncInvoker<CreateScalingNotificationResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreateScalingNotificationResponse>);
        }
        
        /// <summary>
        /// 创建弹性伸缩策略
        ///
        /// 创建弹性伸缩策略。伸缩策略定义了伸缩组内实例的扩张和收缩操作。如果执行伸缩策略造成伸缩组期望实例数与伸缩组内实例数不符，弹性伸缩会自动调整实例资源，以匹配期望实例数。当前伸缩策略支持告警触发策略，周期触发策略，定时触发策略。在策略执行具体动作中，可设置实例变化的个数，或根据当前实例的百分比数进行伸缩。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateScalingPolicyResponse> CreateScalingPolicyAsync(CreateScalingPolicyRequest createScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingPolicyRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateScalingPolicyResponse>(response);
        }

        public AsyncInvoker<CreateScalingPolicyResponse> CreateScalingPolicyAsyncInvoker(CreateScalingPolicyRequest createScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingPolicyRequest);
            return new AsyncInvoker<CreateScalingPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 创建标签
        ///
        /// 创建或删除指定资源的标签。每个伸缩组最多添加10个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateScalingTagInfoResponse> CreateScalingTagInfoAsync(CreateScalingTagInfoRequest createScalingTagInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createScalingTagInfoRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createScalingTagInfoRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/{resource_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingTagInfoRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateScalingTagInfoResponse>(response);
        }

        public AsyncInvoker<CreateScalingTagInfoResponse> CreateScalingTagInfoAsyncInvoker(CreateScalingTagInfoRequest createScalingTagInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createScalingTagInfoRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createScalingTagInfoRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/{resource_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingTagInfoRequest);
            return new AsyncInvoker<CreateScalingTagInfoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateScalingTagInfoResponse>);
        }
        
        /// <summary>
        /// 删除计划任务
        ///
        /// 删除计划任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGroupScheduledTaskResponse> DeleteGroupScheduledTaskAsync(DeleteGroupScheduledTaskRequest deleteGroupScheduledTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", deleteGroupScheduledTaskRequest.ScalingGroupId.ToString());
            urlParam.Add("scheduled_task_id", deleteGroupScheduledTaskRequest.ScheduledTaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling-groups/{scaling_group_id}/scheduled-tasks/{scheduled_task_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupScheduledTaskRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteGroupScheduledTaskResponse>(response);
        }

        public AsyncInvoker<DeleteGroupScheduledTaskResponse> DeleteGroupScheduledTaskAsyncInvoker(DeleteGroupScheduledTaskRequest deleteGroupScheduledTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", deleteGroupScheduledTaskRequest.ScalingGroupId.ToString());
            urlParam.Add("scheduled_task_id", deleteGroupScheduledTaskRequest.ScheduledTaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling-groups/{scaling_group_id}/scheduled-tasks/{scheduled_task_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupScheduledTaskRequest);
            return new AsyncInvoker<DeleteGroupScheduledTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGroupScheduledTaskResponse>);
        }
        
        /// <summary>
        /// 删除生命周期挂钩
        ///
        /// 删除一个指定生命周期挂钩。伸缩组进行伸缩活动时，不允许删除该伸缩组内的生命周期挂钩。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLifecycleHookResponse> DeleteLifecycleHookAsync(DeleteLifecycleHookRequest deleteLifecycleHookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", deleteLifecycleHookRequest.ScalingGroupId.ToString());
            urlParam.Add("lifecycle_hook_name", deleteLifecycleHookRequest.LifecycleHookName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/{lifecycle_hook_name}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLifecycleHookRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteLifecycleHookResponse>(response);
        }

        public AsyncInvoker<DeleteLifecycleHookResponse> DeleteLifecycleHookAsyncInvoker(DeleteLifecycleHookRequest deleteLifecycleHookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", deleteLifecycleHookRequest.ScalingGroupId.ToString());
            urlParam.Add("lifecycle_hook_name", deleteLifecycleHookRequest.LifecycleHookName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/{lifecycle_hook_name}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLifecycleHookRequest);
            return new AsyncInvoker<DeleteLifecycleHookResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLifecycleHookResponse>);
        }
        
        /// <summary>
        /// 删除弹性伸缩配置
        ///
        /// 删除一个指定弹性伸缩配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteScalingConfigResponse> DeleteScalingConfigAsync(DeleteScalingConfigRequest deleteScalingConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_configuration_id", deleteScalingConfigRequest.ScalingConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration/{scaling_configuration_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingConfigRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteScalingConfigResponse>(response);
        }

        public AsyncInvoker<DeleteScalingConfigResponse> DeleteScalingConfigAsyncInvoker(DeleteScalingConfigRequest deleteScalingConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_configuration_id", deleteScalingConfigRequest.ScalingConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration/{scaling_configuration_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingConfigRequest);
            return new AsyncInvoker<DeleteScalingConfigResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScalingConfigResponse>);
        }
        
        /// <summary>
        /// 删除弹性伸缩组
        ///
        /// 删除一个指定弹性伸缩组。force_delete属性表示如果伸缩组存在ECS实例或正在进行伸缩活动，是否强制删除伸缩组并移出和释放ECS实例。默认值为no，表示不强制删除伸缩组。如果force_delete的值为no，必须满足以下两个条件，才能删除伸缩组：条件一：伸缩组没有正在进行的伸缩活动。条件二：伸缩组当前的ECS实例数量（current_instance_number）为0。如果force_delete的值为yes，伸缩组会被置于DELETING状态，拒绝接收新的伸缩活动请求，然后等待已有的伸缩活动完成，最后将伸缩组内所有ECS实例移出伸缩组（用户手动添加的ECS实例会被移出伸缩组，弹性伸缩自动创建的ECS实例会被自动删除）并删除伸缩组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteScalingGroupResponse> DeleteScalingGroupAsync(DeleteScalingGroupRequest deleteScalingGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", deleteScalingGroupRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingGroupRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteScalingGroupResponse>(response);
        }

        public AsyncInvoker<DeleteScalingGroupResponse> DeleteScalingGroupAsyncInvoker(DeleteScalingGroupRequest deleteScalingGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", deleteScalingGroupRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingGroupRequest);
            return new AsyncInvoker<DeleteScalingGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScalingGroupResponse>);
        }
        
        /// <summary>
        /// 移出弹性伸缩组实例
        ///
        /// 从弹性伸缩组中移出一个指定实例。实例处于INSERVICE且移出后实例数不能小于伸缩组的最小实例数时才可以移出。当伸缩组没有伸缩活动时，才能移出实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteScalingInstanceResponse> DeleteScalingInstanceAsync(DeleteScalingInstanceRequest deleteScalingInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteScalingInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{instance_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingInstanceRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteScalingInstanceResponse>(response);
        }

        public AsyncInvoker<DeleteScalingInstanceResponse> DeleteScalingInstanceAsyncInvoker(DeleteScalingInstanceRequest deleteScalingInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteScalingInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{instance_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingInstanceRequest);
            return new AsyncInvoker<DeleteScalingInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScalingInstanceResponse>);
        }
        
        /// <summary>
        /// 删除伸缩组通知
        ///
        /// 删除指定的弹性伸缩组中指定的通知。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteScalingNotificationResponse> DeleteScalingNotificationAsync(DeleteScalingNotificationRequest deleteScalingNotificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", deleteScalingNotificationRequest.ScalingGroupId.ToString());
            urlParam.Add("topic_urn", deleteScalingNotificationRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_notification/{scaling_group_id}/{topic_urn}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingNotificationRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteScalingNotificationResponse>(response);
        }

        public AsyncInvoker<DeleteScalingNotificationResponse> DeleteScalingNotificationAsyncInvoker(DeleteScalingNotificationRequest deleteScalingNotificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", deleteScalingNotificationRequest.ScalingGroupId.ToString());
            urlParam.Add("topic_urn", deleteScalingNotificationRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_notification/{scaling_group_id}/{topic_urn}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingNotificationRequest);
            return new AsyncInvoker<DeleteScalingNotificationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScalingNotificationResponse>);
        }
        
        /// <summary>
        /// 删除弹性伸缩策略
        ///
        /// 删除一个指定弹性伸缩策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteScalingPolicyResponse> DeleteScalingPolicyAsync(DeleteScalingPolicyRequest deleteScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", deleteScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingPolicyRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteScalingPolicyResponse>(response);
        }

        public AsyncInvoker<DeleteScalingPolicyResponse> DeleteScalingPolicyAsyncInvoker(DeleteScalingPolicyRequest deleteScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", deleteScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingPolicyRequest);
            return new AsyncInvoker<DeleteScalingPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 删除标签
        ///
        /// 创建或删除指定资源的标签。每个伸缩组最多添加10个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteScalingTagInfoResponse> DeleteScalingTagInfoAsync(DeleteScalingTagInfoRequest deleteScalingTagInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", deleteScalingTagInfoRequest.ResourceType.ToString());
            urlParam.Add("resource_id", deleteScalingTagInfoRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/{resource_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteScalingTagInfoRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<DeleteScalingTagInfoResponse>(response);
        }

        public AsyncInvoker<DeleteScalingTagInfoResponse> DeleteScalingTagInfoAsyncInvoker(DeleteScalingTagInfoRequest deleteScalingTagInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", deleteScalingTagInfoRequest.ResourceType.ToString());
            urlParam.Add("resource_id", deleteScalingTagInfoRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/{resource_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteScalingTagInfoRequest);
            return new AsyncInvoker<DeleteScalingTagInfoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteScalingTagInfoResponse>);
        }
        
        /// <summary>
        /// 执行弹性伸缩策略。
        ///
        /// 立即执行或启用或停止一个指定弹性伸缩策略。当伸缩组、伸缩策略状态处于INSERVICE时，伸缩策略才能被正确执行，否则会执行失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteScalingPolicyResponse> ExecuteScalingPolicyAsync(ExecuteScalingPolicyRequest executeScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", executeScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeScalingPolicyRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<ExecuteScalingPolicyResponse>(response);
        }

        public AsyncInvoker<ExecuteScalingPolicyResponse> ExecuteScalingPolicyAsyncInvoker(ExecuteScalingPolicyRequest executeScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", executeScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", executeScalingPolicyRequest);
            return new AsyncInvoker<ExecuteScalingPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ExecuteScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 查询计划任务列表
        ///
        /// 查询计划任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGroupScheduledTasksResponse> ListGroupScheduledTasksAsync(ListGroupScheduledTasksRequest listGroupScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listGroupScheduledTasksRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling-groups/{scaling_group_id}/scheduled-tasks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupScheduledTasksRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListGroupScheduledTasksResponse>(response);
        }

        public AsyncInvoker<ListGroupScheduledTasksResponse> ListGroupScheduledTasksAsyncInvoker(ListGroupScheduledTasksRequest listGroupScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listGroupScheduledTasksRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling-groups/{scaling_group_id}/scheduled-tasks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupScheduledTasksRequest);
            return new AsyncInvoker<ListGroupScheduledTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupScheduledTasksResponse>);
        }
        
        /// <summary>
        /// 查询伸缩实例挂起信息
        ///
        /// 添加生命周期挂钩后，当伸缩组进行伸缩活动时，实例将被挂钩挂起并置于等待状态，根据输入条件过滤查询弹性伸缩组中伸缩实例的挂起信息。可根据实例ID进行条件过滤查询。若不加过滤条件默认查询指定伸缩组内所有实例挂起信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHookInstancesResponse> ListHookInstancesAsync(ListHookInstancesRequest listHookInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listHookInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_instance_hook/{scaling_group_id}/list",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHookInstancesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListHookInstancesResponse>(response);
        }

        public AsyncInvoker<ListHookInstancesResponse> ListHookInstancesAsyncInvoker(ListHookInstancesRequest listHookInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listHookInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_instance_hook/{scaling_group_id}/list",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHookInstancesRequest);
            return new AsyncInvoker<ListHookInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHookInstancesResponse>);
        }
        
        /// <summary>
        /// 查询生命周期挂钩列表
        ///
        /// 根据伸缩组ID查询生命周期挂钩列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLifeCycleHooksResponse> ListLifeCycleHooksAsync(ListLifeCycleHooksRequest listLifeCycleHooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listLifeCycleHooksRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/list",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLifeCycleHooksRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListLifeCycleHooksResponse>(response);
        }

        public AsyncInvoker<ListLifeCycleHooksResponse> ListLifeCycleHooksAsyncInvoker(ListLifeCycleHooksRequest listLifeCycleHooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listLifeCycleHooksRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/list",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLifeCycleHooksRequest);
            return new AsyncInvoker<ListLifeCycleHooksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLifeCycleHooksResponse>);
        }
        
        /// <summary>
        /// 查询资源实例
        ///
        /// 根据项目ID查询指定资源类型的资源实例。资源、资源tag默认按照创建时间倒序。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceInstancesResponse> ListResourceInstancesAsync(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceInstancesRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/resource_instances/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListResourceInstancesResponse>(response);
        }

        public AsyncInvoker<ListResourceInstancesResponse> ListResourceInstancesAsyncInvoker(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceInstancesRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/resource_instances/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            return new AsyncInvoker<ListResourceInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceInstancesResponse>);
        }
        
        /// <summary>
        /// 查询伸缩活动日志
        ///
        /// 根据输入条件过滤查询伸缩活动日志。查询结果分页显示。可根据起始时间，截止时间，起始行号，记录数进行条件过滤查询。若不加过滤条件默认查询最多20条伸缩活动日志信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScalingActivityLogsResponse> ListScalingActivityLogsAsync(ListScalingActivityLogsRequest listScalingActivityLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listScalingActivityLogsRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_activity_log/{scaling_group_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingActivityLogsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingActivityLogsResponse>(response);
        }

        public AsyncInvoker<ListScalingActivityLogsResponse> ListScalingActivityLogsAsyncInvoker(ListScalingActivityLogsRequest listScalingActivityLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listScalingActivityLogsRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_activity_log/{scaling_group_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingActivityLogsRequest);
            return new AsyncInvoker<ListScalingActivityLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingActivityLogsResponse>);
        }
        
        /// <summary>
        /// 查询伸缩活动日志v2版本
        ///
        /// 根据输入条件过滤查询伸缩活动日志，支持查询实例伸缩、ELB迁移、实例备用等类型活动。查询结果分页显示。查询伸缩活动日志V2版本与V1版本区别在于，V2版本展示了更详细的实例伸缩日志，如ELB迁移日志，实例备用日志信息。可根据起始时间，截止时间，起始行号，记录数，伸缩活动类型等作为条件过滤查询。若不加过滤条件默认查询最多20条伸缩活动日志信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScalingActivityV2LogsResponse> ListScalingActivityV2LogsAsync(ListScalingActivityV2LogsRequest listScalingActivityV2LogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listScalingActivityV2LogsRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_activity_log/{scaling_group_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingActivityV2LogsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingActivityV2LogsResponse>(response);
        }

        public AsyncInvoker<ListScalingActivityV2LogsResponse> ListScalingActivityV2LogsAsyncInvoker(ListScalingActivityV2LogsRequest listScalingActivityV2LogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listScalingActivityV2LogsRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_activity_log/{scaling_group_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingActivityV2LogsRequest);
            return new AsyncInvoker<ListScalingActivityV2LogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingActivityV2LogsResponse>);
        }
        
        /// <summary>
        /// 查询弹性伸缩配置列表
        ///
        /// 根据输入条件过滤查询弹性伸缩配置。查询结果分页显示。可以根据伸缩配置名称，镜像ID，起始行号，记录条数进行条件过滤查询。若不加过滤条件默认最多查询租户下20条伸缩配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScalingConfigsResponse> ListScalingConfigsAsync(ListScalingConfigsRequest listScalingConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingConfigsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingConfigsResponse>(response);
        }

        public AsyncInvoker<ListScalingConfigsResponse> ListScalingConfigsAsyncInvoker(ListScalingConfigsRequest listScalingConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingConfigsRequest);
            return new AsyncInvoker<ListScalingConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingConfigsResponse>);
        }
        
        /// <summary>
        /// 查询弹性伸缩组列表
        ///
        /// 根据输入条件过滤查询弹性伸缩组列表。查询结果分页显示。可根据伸缩组名称，伸缩配置ID，伸缩组状态，企业项目ID，起始行号，记录条数进行条件过滤查询。若不加过滤条件默认最多查询租户下20条伸缩组信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScalingGroupsResponse> ListScalingGroupsAsync(ListScalingGroupsRequest listScalingGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingGroupsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingGroupsResponse>(response);
        }

        public AsyncInvoker<ListScalingGroupsResponse> ListScalingGroupsAsyncInvoker(ListScalingGroupsRequest listScalingGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingGroupsRequest);
            return new AsyncInvoker<ListScalingGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingGroupsResponse>);
        }
        
        /// <summary>
        /// 查询弹性伸缩组中的实例列表
        ///
        /// 根据输入条件过滤查询弹性伸缩组中实例信息。查询结果分页显示。可根据实例在伸缩组中的生命周期状态，实例健康状态，实例保护状态，起始行号，记录条数进行条件过滤查询。若不加过滤条件默认查询组内最多20条实例信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScalingInstancesResponse> ListScalingInstancesAsync(ListScalingInstancesRequest listScalingInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listScalingInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/list",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingInstancesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingInstancesResponse>(response);
        }

        public AsyncInvoker<ListScalingInstancesResponse> ListScalingInstancesAsyncInvoker(ListScalingInstancesRequest listScalingInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listScalingInstancesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group_instance/{scaling_group_id}/list",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingInstancesRequest);
            return new AsyncInvoker<ListScalingInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingInstancesResponse>);
        }
        
        /// <summary>
        /// 查询伸缩组通知列表
        ///
        /// 根据伸缩组ID查询指定弹性伸缩组的通知列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScalingNotificationsResponse> ListScalingNotificationsAsync(ListScalingNotificationsRequest listScalingNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listScalingNotificationsRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_notification/{scaling_group_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingNotificationsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingNotificationsResponse>(response);
        }

        public AsyncInvoker<ListScalingNotificationsResponse> ListScalingNotificationsAsyncInvoker(ListScalingNotificationsRequest listScalingNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listScalingNotificationsRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_notification/{scaling_group_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingNotificationsRequest);
            return new AsyncInvoker<ListScalingNotificationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingNotificationsResponse>);
        }
        
        /// <summary>
        /// 查询弹性伸缩策略列表
        ///
        /// 根据输入条件过滤查询弹性伸缩策略。查询结果分页显示。可根据伸缩策略名称，策略类型，伸缩策略ID，起始行号，记录数进行条件过滤查询。若不加过滤条件默认查询租户下指定伸缩组内最多20条伸缩策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScalingPoliciesResponse> ListScalingPoliciesAsync(ListScalingPoliciesRequest listScalingPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listScalingPoliciesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_group_id}/list",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingPoliciesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingPoliciesResponse>(response);
        }

        public AsyncInvoker<ListScalingPoliciesResponse> ListScalingPoliciesAsyncInvoker(ListScalingPoliciesRequest listScalingPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", listScalingPoliciesRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_group_id}/list",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingPoliciesRequest);
            return new AsyncInvoker<ListScalingPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingPoliciesResponse>);
        }
        
        /// <summary>
        /// 查询策略执行日志
        ///
        /// 根据输入条件过滤查询策略执行的历史记录。查询结果分页显示。可根据日志ID，伸缩资源类型，伸缩资源ID，策略执行类型，查询额起始，查询截止时间，查询起始行号，查询记录数进行条件过滤查询。若不加过滤条件默认查询最多20条策略执行日志信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScalingPolicyExecuteLogsResponse> ListScalingPolicyExecuteLogsAsync(ListScalingPolicyExecuteLogsRequest listScalingPolicyExecuteLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", listScalingPolicyExecuteLogsRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy_execute_log/{scaling_policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingPolicyExecuteLogsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingPolicyExecuteLogsResponse>(response);
        }

        public AsyncInvoker<ListScalingPolicyExecuteLogsResponse> ListScalingPolicyExecuteLogsAsyncInvoker(ListScalingPolicyExecuteLogsRequest listScalingPolicyExecuteLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", listScalingPolicyExecuteLogsRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy_execute_log/{scaling_policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingPolicyExecuteLogsRequest);
            return new AsyncInvoker<ListScalingPolicyExecuteLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingPolicyExecuteLogsResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 根据项目ID和资源ID查询指定资源类型的资源标签列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScalingTagInfosByResourceIdResponse> ListScalingTagInfosByResourceIdAsync(ListScalingTagInfosByResourceIdRequest listScalingTagInfosByResourceIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listScalingTagInfosByResourceIdRequest.ResourceType.ToString());
            urlParam.Add("resource_id", listScalingTagInfosByResourceIdRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/{resource_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingTagInfosByResourceIdRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingTagInfosByResourceIdResponse>(response);
        }

        public AsyncInvoker<ListScalingTagInfosByResourceIdResponse> ListScalingTagInfosByResourceIdAsyncInvoker(ListScalingTagInfosByResourceIdRequest listScalingTagInfosByResourceIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listScalingTagInfosByResourceIdRequest.ResourceType.ToString());
            urlParam.Add("resource_id", listScalingTagInfosByResourceIdRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/{resource_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingTagInfosByResourceIdRequest);
            return new AsyncInvoker<ListScalingTagInfosByResourceIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingTagInfosByResourceIdResponse>);
        }
        
        /// <summary>
        /// 查询标签
        ///
        /// 根据项目ID查询指定资源类型的标签列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScalingTagInfosByTenantIdResponse> ListScalingTagInfosByTenantIdAsync(ListScalingTagInfosByTenantIdRequest listScalingTagInfosByTenantIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listScalingTagInfosByTenantIdRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingTagInfosByTenantIdRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingTagInfosByTenantIdResponse>(response);
        }

        public AsyncInvoker<ListScalingTagInfosByTenantIdResponse> ListScalingTagInfosByTenantIdAsyncInvoker(ListScalingTagInfosByTenantIdRequest listScalingTagInfosByTenantIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listScalingTagInfosByTenantIdRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/{resource_type}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingTagInfosByTenantIdRequest);
            return new AsyncInvoker<ListScalingTagInfosByTenantIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingTagInfosByTenantIdResponse>);
        }
        
        /// <summary>
        /// 停止弹性伸缩组
        ///
        /// 启用或停止一个指定弹性伸缩组。已停用状态的伸缩组，不会自动触发任何伸缩活动。当伸缩组正在进行伸缩活动，即使停用，正在进行的伸缩活动也不会立即停止。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PauseScalingGroupResponse> PauseScalingGroupAsync(PauseScalingGroupRequest pauseScalingGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", pauseScalingGroupRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", pauseScalingGroupRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<PauseScalingGroupResponse>(response);
        }

        public AsyncInvoker<PauseScalingGroupResponse> PauseScalingGroupAsyncInvoker(PauseScalingGroupRequest pauseScalingGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", pauseScalingGroupRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", pauseScalingGroupRequest);
            return new AsyncInvoker<PauseScalingGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<PauseScalingGroupResponse>);
        }
        
        /// <summary>
        /// 停止弹性伸缩策略。
        ///
        /// 立即执行或启用或停止一个指定弹性伸缩策略。当伸缩组、伸缩策略状态处于INSERVICE时，伸缩策略才能被正确执行，否则会执行失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PauseScalingPolicyResponse> PauseScalingPolicyAsync(PauseScalingPolicyRequest pauseScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", pauseScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", pauseScalingPolicyRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<PauseScalingPolicyResponse>(response);
        }

        public AsyncInvoker<PauseScalingPolicyResponse> PauseScalingPolicyAsyncInvoker(PauseScalingPolicyRequest pauseScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", pauseScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", pauseScalingPolicyRequest);
            return new AsyncInvoker<PauseScalingPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<PauseScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 启用弹性伸缩组
        ///
        /// 启用或停止一个指定弹性伸缩组。已停用状态的伸缩组，不会自动触发任何伸缩活动。当伸缩组正在进行伸缩活动，即使停用，正在进行的伸缩活动也不会立即停止。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResumeScalingGroupResponse> ResumeScalingGroupAsync(ResumeScalingGroupRequest resumeScalingGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", resumeScalingGroupRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resumeScalingGroupRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<ResumeScalingGroupResponse>(response);
        }

        public AsyncInvoker<ResumeScalingGroupResponse> ResumeScalingGroupAsyncInvoker(ResumeScalingGroupRequest resumeScalingGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", resumeScalingGroupRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resumeScalingGroupRequest);
            return new AsyncInvoker<ResumeScalingGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResumeScalingGroupResponse>);
        }
        
        /// <summary>
        /// 启用弹性伸缩策略。
        ///
        /// 立即执行或启用或停止一个指定弹性伸缩策略。当伸缩组、伸缩策略状态处于INSERVICE时，伸缩策略才能被正确执行，否则会执行失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResumeScalingPolicyResponse> ResumeScalingPolicyAsync(ResumeScalingPolicyRequest resumeScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", resumeScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resumeScalingPolicyRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<ResumeScalingPolicyResponse>(response);
        }

        public AsyncInvoker<ResumeScalingPolicyResponse> ResumeScalingPolicyAsyncInvoker(ResumeScalingPolicyRequest resumeScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", resumeScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resumeScalingPolicyRequest);
            return new AsyncInvoker<ResumeScalingPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResumeScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 查询生命周期挂钩详情
        ///
        /// 根据伸缩组ID及生命周期挂钩名称查询指定的生命周期挂钩详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLifeCycleHookResponse> ShowLifeCycleHookAsync(ShowLifeCycleHookRequest showLifeCycleHookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", showLifeCycleHookRequest.ScalingGroupId.ToString());
            urlParam.Add("lifecycle_hook_name", showLifeCycleHookRequest.LifecycleHookName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/{lifecycle_hook_name}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLifeCycleHookRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowLifeCycleHookResponse>(response);
        }

        public AsyncInvoker<ShowLifeCycleHookResponse> ShowLifeCycleHookAsyncInvoker(ShowLifeCycleHookRequest showLifeCycleHookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", showLifeCycleHookRequest.ScalingGroupId.ToString());
            urlParam.Add("lifecycle_hook_name", showLifeCycleHookRequest.LifecycleHookName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/{lifecycle_hook_name}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLifeCycleHookRequest);
            return new AsyncInvoker<ShowLifeCycleHookResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLifeCycleHookResponse>);
        }
        
        /// <summary>
        /// 查询弹性伸缩策略和伸缩实例配额
        ///
        /// 根据伸缩组ID查询指定弹性伸缩组下的伸缩策略和伸缩实例的配额总数及已使用配额数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPolicyAndInstanceQuotaResponse> ShowPolicyAndInstanceQuotaAsync(ShowPolicyAndInstanceQuotaRequest showPolicyAndInstanceQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", showPolicyAndInstanceQuotaRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/quotas/{scaling_group_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyAndInstanceQuotaRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPolicyAndInstanceQuotaResponse>(response);
        }

        public AsyncInvoker<ShowPolicyAndInstanceQuotaResponse> ShowPolicyAndInstanceQuotaAsyncInvoker(ShowPolicyAndInstanceQuotaRequest showPolicyAndInstanceQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", showPolicyAndInstanceQuotaRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/quotas/{scaling_group_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyAndInstanceQuotaRequest);
            return new AsyncInvoker<ShowPolicyAndInstanceQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPolicyAndInstanceQuotaResponse>);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// 查询指定租户下的弹性伸缩组、伸缩配置、伸缩带宽策略、伸缩策略和伸缩实例的配额总数及已使用配额数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceQuotaResponse> ShowResourceQuotaAsync(ShowResourceQuotaRequest showResourceQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/quotas",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceQuotaRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowResourceQuotaResponse>(response);
        }

        public AsyncInvoker<ShowResourceQuotaResponse> ShowResourceQuotaAsyncInvoker(ShowResourceQuotaRequest showResourceQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/quotas",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceQuotaRequest);
            return new AsyncInvoker<ShowResourceQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceQuotaResponse>);
        }
        
        /// <summary>
        /// 查询弹性伸缩配置详情
        ///
        /// 根据伸缩配置ID查询一个弹性伸缩配置的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowScalingConfigResponse> ShowScalingConfigAsync(ShowScalingConfigRequest showScalingConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_configuration_id", showScalingConfigRequest.ScalingConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration/{scaling_configuration_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingConfigRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowScalingConfigResponse>(response);
        }

        public AsyncInvoker<ShowScalingConfigResponse> ShowScalingConfigAsyncInvoker(ShowScalingConfigRequest showScalingConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_configuration_id", showScalingConfigRequest.ScalingConfigurationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_configuration/{scaling_configuration_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingConfigRequest);
            return new AsyncInvoker<ShowScalingConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowScalingConfigResponse>);
        }
        
        /// <summary>
        /// 查询弹性伸缩组详情
        ///
        /// 查询一个指定弹性伸缩组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowScalingGroupResponse> ShowScalingGroupAsync(ShowScalingGroupRequest showScalingGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", showScalingGroupRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingGroupRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowScalingGroupResponse>(response);
        }

        public AsyncInvoker<ShowScalingGroupResponse> ShowScalingGroupAsyncInvoker(ShowScalingGroupRequest showScalingGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", showScalingGroupRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingGroupRequest);
            return new AsyncInvoker<ShowScalingGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowScalingGroupResponse>);
        }
        
        /// <summary>
        /// 查询弹性伸缩策略详情
        ///
        /// 查询指定弹性伸缩策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowScalingPolicyResponse> ShowScalingPolicyAsync(ShowScalingPolicyRequest showScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", showScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingPolicyRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowScalingPolicyResponse>(response);
        }

        public AsyncInvoker<ShowScalingPolicyResponse> ShowScalingPolicyAsyncInvoker(ShowScalingPolicyRequest showScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", showScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingPolicyRequest);
            return new AsyncInvoker<ShowScalingPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 更新计划任务
        ///
        /// 更新计划任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGroupScheduledTaskResponse> UpdateGroupScheduledTaskAsync(UpdateGroupScheduledTaskRequest updateGroupScheduledTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", updateGroupScheduledTaskRequest.ScalingGroupId.ToString());
            urlParam.Add("scheduled_task_id", updateGroupScheduledTaskRequest.ScheduledTaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling-groups/{scaling_group_id}/scheduled-tasks/{scheduled_task_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGroupScheduledTaskRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateGroupScheduledTaskResponse>(response);
        }

        public AsyncInvoker<UpdateGroupScheduledTaskResponse> UpdateGroupScheduledTaskAsyncInvoker(UpdateGroupScheduledTaskRequest updateGroupScheduledTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", updateGroupScheduledTaskRequest.ScalingGroupId.ToString());
            urlParam.Add("scheduled_task_id", updateGroupScheduledTaskRequest.ScheduledTaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling-groups/{scaling_group_id}/scheduled-tasks/{scheduled_task_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateGroupScheduledTaskRequest);
            return new AsyncInvoker<UpdateGroupScheduledTaskResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateGroupScheduledTaskResponse>);
        }
        
        /// <summary>
        /// 修改生命周期挂钩
        ///
        /// 修改一个指定生命周期挂钩中的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLifeCycleHookResponse> UpdateLifeCycleHookAsync(UpdateLifeCycleHookRequest updateLifeCycleHookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", updateLifeCycleHookRequest.ScalingGroupId.ToString());
            urlParam.Add("lifecycle_hook_name", updateLifeCycleHookRequest.LifecycleHookName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/{lifecycle_hook_name}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLifeCycleHookRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateLifeCycleHookResponse>(response);
        }

        public AsyncInvoker<UpdateLifeCycleHookResponse> UpdateLifeCycleHookAsyncInvoker(UpdateLifeCycleHookRequest updateLifeCycleHookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", updateLifeCycleHookRequest.ScalingGroupId.ToString());
            urlParam.Add("lifecycle_hook_name", updateLifeCycleHookRequest.LifecycleHookName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_lifecycle_hook/{scaling_group_id}/{lifecycle_hook_name}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLifeCycleHookRequest);
            return new AsyncInvoker<UpdateLifeCycleHookResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLifeCycleHookResponse>);
        }
        
        /// <summary>
        /// 修改弹性伸缩组
        ///
        /// 修改一个指定弹性伸缩组中的信息。更换伸缩组的伸缩配置，伸缩组中已经存在的使用之前伸缩配置创建的云服务器云主机不受影响。伸缩组为没有正在进行的伸缩活动时，可以修改伸缩组的子网、可用区和负载均衡配置。当伸缩组的期望实例数改变时，会触发伸缩活动加入或移出实例。期望实例数必须大于或等于最小实例数，必须小于或等于最大实例数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateScalingGroupResponse> UpdateScalingGroupAsync(UpdateScalingGroupRequest updateScalingGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", updateScalingGroupRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScalingGroupRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateScalingGroupResponse>(response);
        }

        public AsyncInvoker<UpdateScalingGroupResponse> UpdateScalingGroupAsyncInvoker(UpdateScalingGroupRequest updateScalingGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_group_id", updateScalingGroupRequest.ScalingGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_group/{scaling_group_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScalingGroupRequest);
            return new AsyncInvoker<UpdateScalingGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateScalingGroupResponse>);
        }
        
        /// <summary>
        /// 修改弹性伸缩策略
        ///
        /// 修改指定弹性伸缩策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateScalingPolicyResponse> UpdateScalingPolicyAsync(UpdateScalingPolicyRequest updateScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", updateScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScalingPolicyRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateScalingPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateScalingPolicyResponse> UpdateScalingPolicyAsyncInvoker(UpdateScalingPolicyRequest updateScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", updateScalingPolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v1/{project_id}/scaling_policy/{scaling_policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScalingPolicyRequest);
            return new AsyncInvoker<UpdateScalingPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 查询弹性伸缩API所有版本信息
        ///
        /// 查询弹性伸缩API所有版本信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApiVersionsResponse> ListApiVersionsAsync(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }

        public AsyncInvoker<ListApiVersionsResponse> ListApiVersionsAsyncInvoker(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            return new AsyncInvoker<ListApiVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionsResponse>);
        }
        
        /// <summary>
        /// 查询弹性伸缩API指定版本信息
        ///
        /// 根据租户id和资源id查询指定资源类型的标签列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowApiVersionResponse> ShowApiVersionAsync(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version", showApiVersionRequest.ApiVersion.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{api_version}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }

        public AsyncInvoker<ShowApiVersionResponse> ShowApiVersionAsyncInvoker(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version", showApiVersionRequest.ApiVersion.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{api_version}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            return new AsyncInvoker<ShowApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApiVersionResponse>);
        }
        
        /// <summary>
        /// 创建弹性伸缩策略（V2版本）
        ///
        /// 可针对不同类型资源如伸缩组或带宽，创建弹性伸缩策略。创建弹性伸缩策略V2版本与V1版本的区别在于，V2版本支持创建对带宽资源进行调整的策略，通过伸缩资源类型区分伸缩资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateScalingV2PolicyResponse> CreateScalingV2PolicyAsync(CreateScalingV2PolicyRequest createScalingV2PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingV2PolicyRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateScalingV2PolicyResponse>(response);
        }

        public AsyncInvoker<CreateScalingV2PolicyResponse> CreateScalingV2PolicyAsyncInvoker(CreateScalingV2PolicyRequest createScalingV2PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createScalingV2PolicyRequest);
            return new AsyncInvoker<CreateScalingV2PolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateScalingV2PolicyResponse>);
        }
        
        /// <summary>
        /// 查询弹性伸缩策略全量列表（V2版本）
        ///
        /// 根据输入条件过滤查询弹性伸缩策略，支持查询当前租户下全量伸缩策略。查询结果分页显示。可根据伸缩资源ID，伸缩资源类型，伸缩策略名称，伸缩策略ID，告警ID，企业项目ID，起始行号，记录数，排序方式等条件进行过滤查询。若不加过滤添加默认查询该租户下最多20条伸缩策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAllScalingV2PoliciesResponse> ListAllScalingV2PoliciesAsync(ListAllScalingV2PoliciesRequest listAllScalingV2PoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllScalingV2PoliciesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAllScalingV2PoliciesResponse>(response);
        }

        public AsyncInvoker<ListAllScalingV2PoliciesResponse> ListAllScalingV2PoliciesAsyncInvoker(ListAllScalingV2PoliciesRequest listAllScalingV2PoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllScalingV2PoliciesRequest);
            return new AsyncInvoker<ListAllScalingV2PoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllScalingV2PoliciesResponse>);
        }
        
        /// <summary>
        /// 查询弹性伸缩策略列表（V2版本）
        ///
        /// 根据输入条件过滤查询弹性伸缩策略。查询结果分页显示。查询弹性伸缩策略V2版本与V1版本的区别在于，V2版本响应含伸缩资源类型。可根据伸缩策略名称，策略类型，伸缩策略ID，起始行号，记录数进行条件过滤查询。若不加过滤条件默认查询该租户下指定资源下最多20条伸缩策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScalingV2PoliciesResponse> ListScalingV2PoliciesAsync(ListScalingV2PoliciesRequest listScalingV2PoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_resource_id", listScalingV2PoliciesRequest.ScalingResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy/{scaling_resource_id}/list",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingV2PoliciesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListScalingV2PoliciesResponse>(response);
        }

        public AsyncInvoker<ListScalingV2PoliciesResponse> ListScalingV2PoliciesAsyncInvoker(ListScalingV2PoliciesRequest listScalingV2PoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_resource_id", listScalingV2PoliciesRequest.ScalingResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy/{scaling_resource_id}/list",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScalingV2PoliciesRequest);
            return new AsyncInvoker<ListScalingV2PoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScalingV2PoliciesResponse>);
        }
        
        /// <summary>
        /// 查询指定弹性伸缩策略详情（V2版本）
        ///
        /// 查询指定弹性伸缩策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowScalingV2PolicyResponse> ShowScalingV2PolicyAsync(ShowScalingV2PolicyRequest showScalingV2PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", showScalingV2PolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy/{scaling_policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingV2PolicyRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowScalingV2PolicyResponse>(response);
        }

        public AsyncInvoker<ShowScalingV2PolicyResponse> ShowScalingV2PolicyAsyncInvoker(ShowScalingV2PolicyRequest showScalingV2PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", showScalingV2PolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy/{scaling_policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingV2PolicyRequest);
            return new AsyncInvoker<ShowScalingV2PolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowScalingV2PolicyResponse>);
        }
        
        /// <summary>
        /// 修改弹性伸缩策略（V2版本）
        ///
        /// 修改指定弹性伸缩策略。修改弹性伸缩策略V2版本与V1版本的区别在于，V2版本支持修改伸缩资源类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateScalingV2PolicyResponse> UpdateScalingV2PolicyAsync(UpdateScalingV2PolicyRequest updateScalingV2PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", updateScalingV2PolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy/{scaling_policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScalingV2PolicyRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateScalingV2PolicyResponse>(response);
        }

        public AsyncInvoker<UpdateScalingV2PolicyResponse> UpdateScalingV2PolicyAsyncInvoker(UpdateScalingV2PolicyRequest updateScalingV2PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("scaling_policy_id", updateScalingV2PolicyRequest.ScalingPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/autoscaling-api/v2/{project_id}/scaling_policy/{scaling_policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateScalingV2PolicyRequest);
            return new AsyncInvoker<UpdateScalingV2PolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateScalingV2PolicyResponse>);
        }
        
    }
}