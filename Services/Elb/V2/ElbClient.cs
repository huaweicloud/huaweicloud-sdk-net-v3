using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Elb.V2.Model;

namespace HuaweiCloud.SDK.Elb.V2
{
    public partial class ElbClient : Client
    {
        public static ClientBuilder<ElbClient> NewBuilder()
        {
            return new ClientBuilder<ElbClient>();
        }

        
        /// <summary>
        /// 批量添加监听器标签
        ///
        /// 批量添加监听器标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateListenerTagsResponse BatchCreateListenerTags(BatchCreateListenerTagsRequest batchCreateListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateListenerTagsRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateListenerTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateListenerTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateListenerTagsResponse> BatchCreateListenerTagsInvoker(BatchCreateListenerTagsRequest batchCreateListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateListenerTagsRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateListenerTagsRequest);
            return new SyncInvoker<BatchCreateListenerTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateListenerTagsResponse>);
        }
        
        /// <summary>
        /// 批量添加负载均衡器标签
        ///
        /// 批量添加负载均衡器标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateLoadbalancerTagsResponse BatchCreateLoadbalancerTags(BatchCreateLoadbalancerTagsRequest batchCreateLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateLoadbalancerTagsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateLoadbalancerTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateLoadbalancerTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateLoadbalancerTagsResponse> BatchCreateLoadbalancerTagsInvoker(BatchCreateLoadbalancerTagsRequest batchCreateLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateLoadbalancerTagsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateLoadbalancerTagsRequest);
            return new SyncInvoker<BatchCreateLoadbalancerTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateLoadbalancerTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除监听器标签
        ///
        /// 批量删除监听器标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteListenerTagsResponse BatchDeleteListenerTags(BatchDeleteListenerTagsRequest batchDeleteListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteListenerTagsRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteListenerTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteListenerTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteListenerTagsResponse> BatchDeleteListenerTagsInvoker(BatchDeleteListenerTagsRequest batchDeleteListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteListenerTagsRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteListenerTagsRequest);
            return new SyncInvoker<BatchDeleteListenerTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteListenerTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除负载均衡器标签
        ///
        /// 批量删除负载均衡器标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteLoadbalancerTagsResponse BatchDeleteLoadbalancerTags(BatchDeleteLoadbalancerTagsRequest batchDeleteLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteLoadbalancerTagsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteLoadbalancerTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteLoadbalancerTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteLoadbalancerTagsResponse> BatchDeleteLoadbalancerTagsInvoker(BatchDeleteLoadbalancerTagsRequest batchDeleteLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteLoadbalancerTagsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteLoadbalancerTagsRequest);
            return new SyncInvoker<BatchDeleteLoadbalancerTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteLoadbalancerTagsResponse>);
        }
        
        /// <summary>
        /// 创建健康检查
        ///
        /// 给后端云服务器组添加健康检查
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateHealthmonitorResponse CreateHealthmonitor(CreateHealthmonitorRequest createHealthmonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHealthmonitorRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateHealthmonitorResponse>(response);
        }

        public SyncInvoker<CreateHealthmonitorResponse> CreateHealthmonitorInvoker(CreateHealthmonitorRequest createHealthmonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHealthmonitorRequest);
            return new SyncInvoker<CreateHealthmonitorResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHealthmonitorResponse>);
        }
        
        /// <summary>
        /// 创建转发策略
        ///
        /// 创建listener关联的转发策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateL7policyResponse CreateL7policy(CreateL7policyRequest createL7policyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createL7policyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateL7policyResponse>(response);
        }

        public SyncInvoker<CreateL7policyResponse> CreateL7policyInvoker(CreateL7policyRequest createL7policyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createL7policyRequest);
            return new SyncInvoker<CreateL7policyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateL7policyResponse>);
        }
        
        /// <summary>
        /// 创建转发规则
        ///
        /// 创建转发规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateL7ruleResponse CreateL7rule(CreateL7ruleRequest createL7ruleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createL7ruleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createL7ruleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateL7ruleResponse>(response);
        }

        public SyncInvoker<CreateL7ruleResponse> CreateL7ruleInvoker(CreateL7ruleRequest createL7ruleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createL7ruleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createL7ruleRequest);
            return new SyncInvoker<CreateL7ruleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateL7ruleResponse>);
        }
        
        /// <summary>
        /// 创建监听器
        ///
        /// 创建与负载均衡器绑定的监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateListenerResponse CreateListener(CreateListenerRequest createListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createListenerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateListenerResponse>(response);
        }

        public SyncInvoker<CreateListenerResponse> CreateListenerInvoker(CreateListenerRequest createListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createListenerRequest);
            return new SyncInvoker<CreateListenerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateListenerResponse>);
        }
        
        /// <summary>
        /// 添加监听器标签
        ///
        /// 给指定监听器添加标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateListenerTagsResponse CreateListenerTags(CreateListenerTagsRequest createListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createListenerTagsRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createListenerTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateListenerTagsResponse>(response);
        }

        public SyncInvoker<CreateListenerTagsResponse> CreateListenerTagsInvoker(CreateListenerTagsRequest createListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createListenerTagsRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createListenerTagsRequest);
            return new SyncInvoker<CreateListenerTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateListenerTagsResponse>);
        }
        
        /// <summary>
        /// 创建负载均衡器
        ///
        /// 创建私网类型的增强型负载均衡器。创建成功后，该接口会返回创建的增强型负载均衡器的ID、所属子网ID、负载均衡器IP等详细信息。若要创建公网类型的增强型负载均衡器，还需调用创建浮动IP的接口，将浮动IP与私网负载均衡器的vip_port_id绑定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateLoadbalancerResponse CreateLoadbalancer(CreateLoadbalancerRequest createLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLoadbalancerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateLoadbalancerResponse>(response);
        }

        public SyncInvoker<CreateLoadbalancerResponse> CreateLoadbalancerInvoker(CreateLoadbalancerRequest createLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLoadbalancerRequest);
            return new SyncInvoker<CreateLoadbalancerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLoadbalancerResponse>);
        }
        
        /// <summary>
        /// 添加负载均衡器标签
        ///
        /// 给指定负载均衡器添加标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateLoadbalancerTagsResponse CreateLoadbalancerTags(CreateLoadbalancerTagsRequest createLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createLoadbalancerTagsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLoadbalancerTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateLoadbalancerTagsResponse>(response);
        }

        public SyncInvoker<CreateLoadbalancerTagsResponse> CreateLoadbalancerTagsInvoker(CreateLoadbalancerTagsRequest createLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createLoadbalancerTagsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLoadbalancerTagsRequest);
            return new SyncInvoker<CreateLoadbalancerTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateLoadbalancerTagsResponse>);
        }
        
        /// <summary>
        /// 创建后端云服务器
        ///
        /// 添加属于某个后端云服务器组的后端云服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMemberResponse CreateMember(CreateMemberRequest createMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMemberRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMemberResponse>(response);
        }

        public SyncInvoker<CreateMemberResponse> CreateMemberInvoker(CreateMemberRequest createMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMemberRequest);
            return new SyncInvoker<CreateMemberResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMemberResponse>);
        }
        
        /// <summary>
        /// 创建后端云服务器组
        ///
        /// 创建后端云服务器组。将多个后端云服务器添加到后端云服务器组中后，请求会在后端云服务器间按后端云服务器组的负载均衡算法和后端云服务器的权重来做请求分发。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePoolResponse CreatePool(CreatePoolRequest createPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPoolRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePoolResponse>(response);
        }

        public SyncInvoker<CreatePoolResponse> CreatePoolInvoker(CreatePoolRequest createPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPoolRequest);
            return new SyncInvoker<CreatePoolResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePoolResponse>);
        }
        
        /// <summary>
        /// 创建白名单
        ///
        /// 创建白名单，控制监听器的访问权限。若开启了白名单功能，只有白名单中放通的IP可以访问该监听器的后端服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateWhitelistResponse CreateWhitelist(CreateWhitelistRequest createWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWhitelistRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateWhitelistResponse>(response);
        }

        public SyncInvoker<CreateWhitelistResponse> CreateWhitelistInvoker(CreateWhitelistRequest createWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWhitelistRequest);
            return new SyncInvoker<CreateWhitelistResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWhitelistResponse>);
        }
        
        /// <summary>
        /// 删除健康检查
        ///
        /// 删除健康检查
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteHealthmonitorResponse DeleteHealthmonitor(DeleteHealthmonitorRequest deleteHealthmonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHealthmonitorRequest.HealthmonitorId, out var valueOfHealthmonitorId)) urlParam.Add("healthmonitor_id", valueOfHealthmonitorId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHealthmonitorRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteHealthmonitorResponse>(response);
        }

        public SyncInvoker<DeleteHealthmonitorResponse> DeleteHealthmonitorInvoker(DeleteHealthmonitorRequest deleteHealthmonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHealthmonitorRequest.HealthmonitorId, out var valueOfHealthmonitorId)) urlParam.Add("healthmonitor_id", valueOfHealthmonitorId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHealthmonitorRequest);
            return new SyncInvoker<DeleteHealthmonitorResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteHealthmonitorResponse>);
        }
        
        /// <summary>
        /// 删除转发策略
        ///
        /// 删除转发策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteL7policyResponse DeleteL7policy(DeleteL7policyRequest deleteL7policyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteL7policyRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7policyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteL7policyResponse>(response);
        }

        public SyncInvoker<DeleteL7policyResponse> DeleteL7policyInvoker(DeleteL7policyRequest deleteL7policyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteL7policyRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7policyRequest);
            return new SyncInvoker<DeleteL7policyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteL7policyResponse>);
        }
        
        /// <summary>
        /// 删除转发规则
        ///
        /// 删除转发规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteL7ruleResponse DeleteL7rule(DeleteL7ruleRequest deleteL7ruleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteL7ruleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            if (StringUtils.TryConvertToNonEmptyString(deleteL7ruleRequest.L7ruleId, out var valueOfL7ruleId)) urlParam.Add("l7rule_id", valueOfL7ruleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7ruleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteL7ruleResponse>(response);
        }

        public SyncInvoker<DeleteL7ruleResponse> DeleteL7ruleInvoker(DeleteL7ruleRequest deleteL7ruleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteL7ruleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            if (StringUtils.TryConvertToNonEmptyString(deleteL7ruleRequest.L7ruleId, out var valueOfL7ruleId)) urlParam.Add("l7rule_id", valueOfL7ruleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7ruleRequest);
            return new SyncInvoker<DeleteL7ruleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteL7ruleResponse>);
        }
        
        /// <summary>
        /// 删除监听器
        ///
        /// 根据指定ID删除监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteListenerResponse DeleteListener(DeleteListenerRequest deleteListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteListenerResponse>(response);
        }

        public SyncInvoker<DeleteListenerResponse> DeleteListenerInvoker(DeleteListenerRequest deleteListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerRequest);
            return new SyncInvoker<DeleteListenerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteListenerResponse>);
        }
        
        /// <summary>
        /// 删除监听器标签
        ///
        /// 删除监听器的某个key对应的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteListenerTagsResponse DeleteListenerTags(DeleteListenerTagsRequest deleteListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteListenerTagsRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            if (StringUtils.TryConvertToNonEmptyString(deleteListenerTagsRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerTagsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteListenerTagsResponse>(response);
        }

        public SyncInvoker<DeleteListenerTagsResponse> DeleteListenerTagsInvoker(DeleteListenerTagsRequest deleteListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteListenerTagsRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            if (StringUtils.TryConvertToNonEmptyString(deleteListenerTagsRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerTagsRequest);
            return new SyncInvoker<DeleteListenerTagsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteListenerTagsResponse>);
        }
        
        /// <summary>
        /// 删除负载均衡
        ///
        /// 根据指定ID删除负载均衡器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLoadbalancerResponse DeleteLoadbalancer(DeleteLoadbalancerRequest deleteLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLoadbalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadbalancerRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLoadbalancerResponse>(response);
        }

        public SyncInvoker<DeleteLoadbalancerResponse> DeleteLoadbalancerInvoker(DeleteLoadbalancerRequest deleteLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLoadbalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadbalancerRequest);
            return new SyncInvoker<DeleteLoadbalancerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLoadbalancerResponse>);
        }
        
        /// <summary>
        /// 删除负载均衡标签
        ///
        /// 删除负载均衡器的某个key对应的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLoadbalancerTagsResponse DeleteLoadbalancerTags(DeleteLoadbalancerTagsRequest deleteLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLoadbalancerTagsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            if (StringUtils.TryConvertToNonEmptyString(deleteLoadbalancerTagsRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadbalancerTagsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLoadbalancerTagsResponse>(response);
        }

        public SyncInvoker<DeleteLoadbalancerTagsResponse> DeleteLoadbalancerTagsInvoker(DeleteLoadbalancerTagsRequest deleteLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLoadbalancerTagsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            if (StringUtils.TryConvertToNonEmptyString(deleteLoadbalancerTagsRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadbalancerTagsRequest);
            return new SyncInvoker<DeleteLoadbalancerTagsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLoadbalancerTagsResponse>);
        }
        
        /// <summary>
        /// 删除后端云服务器
        ///
        /// 删除后端云服务器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteMemberResponse DeleteMember(DeleteMemberRequest deleteMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMemberRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMemberResponse>(response);
        }

        public SyncInvoker<DeleteMemberResponse> DeleteMemberInvoker(DeleteMemberRequest deleteMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMemberRequest);
            return new SyncInvoker<DeleteMemberResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMemberResponse>);
        }
        
        /// <summary>
        /// 删除后端云服务器组
        ///
        /// 删除后端云服务器组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePoolResponse DeletePool(DeletePoolRequest deletePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePoolRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePoolResponse>(response);
        }

        public SyncInvoker<DeletePoolResponse> DeletePoolInvoker(DeletePoolRequest deletePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePoolRequest);
            return new SyncInvoker<DeletePoolResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePoolResponse>);
        }
        
        /// <summary>
        /// 删除白名单
        ///
        /// 删除白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteWhitelistResponse DeleteWhitelist(DeleteWhitelistRequest deleteWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteWhitelistRequest.WhitelistId, out var valueOfWhitelistId)) urlParam.Add("whitelist_id", valueOfWhitelistId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists/{whitelist_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWhitelistRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteWhitelistResponse>(response);
        }

        public SyncInvoker<DeleteWhitelistResponse> DeleteWhitelistInvoker(DeleteWhitelistRequest deleteWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteWhitelistRequest.WhitelistId, out var valueOfWhitelistId)) urlParam.Add("whitelist_id", valueOfWhitelistId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists/{whitelist_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWhitelistRequest);
            return new SyncInvoker<DeleteWhitelistResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteWhitelistResponse>);
        }
        
        /// <summary>
        /// 查询健康检查列表
        ///
        /// 查询健康检查列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHealthmonitorsResponse ListHealthmonitors(ListHealthmonitorsRequest listHealthmonitorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHealthmonitorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHealthmonitorsResponse>(response);
        }

        public SyncInvoker<ListHealthmonitorsResponse> ListHealthmonitorsInvoker(ListHealthmonitorsRequest listHealthmonitorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHealthmonitorsRequest);
            return new SyncInvoker<ListHealthmonitorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHealthmonitorsResponse>);
        }
        
        /// <summary>
        /// 查询转发策略列表
        ///
        /// 查询转发策略。支持过滤查询和分页查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListL7policiesResponse ListL7policies(ListL7policiesRequest listL7policiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7policiesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListL7policiesResponse>(response);
        }

        public SyncInvoker<ListL7policiesResponse> ListL7policiesInvoker(ListL7policiesRequest listL7policiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7policiesRequest);
            return new SyncInvoker<ListL7policiesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListL7policiesResponse>);
        }
        
        /// <summary>
        /// 查询转发规则列表
        ///
        /// 查询指定转发策略下关联的转发规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListL7rulesResponse ListL7rules(ListL7rulesRequest listL7rulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listL7rulesRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7rulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListL7rulesResponse>(response);
        }

        public SyncInvoker<ListL7rulesResponse> ListL7rulesInvoker(ListL7rulesRequest listL7rulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listL7rulesRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7rulesRequest);
            return new SyncInvoker<ListL7rulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListL7rulesResponse>);
        }
        
        /// <summary>
        /// 查询所有监听器的标签列表
        ///
        /// 查询指定项目下所有监听器的标签列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListListenerTagsResponse ListListenerTags(ListListenerTagsRequest listListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenerTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListListenerTagsResponse>(response);
        }

        public SyncInvoker<ListListenerTagsResponse> ListListenerTagsInvoker(ListListenerTagsRequest listListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenerTagsRequest);
            return new SyncInvoker<ListListenerTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListListenerTagsResponse>);
        }
        
        /// <summary>
        /// 查询监听器列表
        ///
        /// 查询监听器列表。支持过滤查询和分页查询。可以通过监听器ID、协议类型、监听端口号、关联的后端云服务器的IP等查询监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListListenersResponse ListListeners(ListListenersRequest listListenersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListListenersResponse>(response);
        }

        public SyncInvoker<ListListenersResponse> ListListenersInvoker(ListListenersRequest listListenersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersRequest);
            return new SyncInvoker<ListListenersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListListenersResponse>);
        }
        
        /// <summary>
        /// 根据标签查询监听器
        ///
        /// 根据标签过滤查询监听器实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListListenersByTagsResponse ListListenersByTags(ListListenersByTagsRequest listListenersByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListListenersByTagsResponse>(response);
        }

        public SyncInvoker<ListListenersByTagsResponse> ListListenersByTagsInvoker(ListListenersByTagsRequest listListenersByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersByTagsRequest);
            return new SyncInvoker<ListListenersByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListListenersByTagsResponse>);
        }
        
        /// <summary>
        /// 查询所有负载均衡器的标签列表
        ///
        /// 查询指定项目下所有负载均衡器的标签列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLoadbalancerTagsResponse ListLoadbalancerTags(ListLoadbalancerTagsRequest listLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancerTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLoadbalancerTagsResponse>(response);
        }

        public SyncInvoker<ListLoadbalancerTagsResponse> ListLoadbalancerTagsInvoker(ListLoadbalancerTagsRequest listLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancerTagsRequest);
            return new SyncInvoker<ListLoadbalancerTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLoadbalancerTagsResponse>);
        }
        
        /// <summary>
        /// 查询负载均衡列表
        ///
        /// 查询负载均衡器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLoadbalancersResponse ListLoadbalancers(ListLoadbalancersRequest listLoadbalancersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLoadbalancersResponse>(response);
        }

        public SyncInvoker<ListLoadbalancersResponse> ListLoadbalancersInvoker(ListLoadbalancersRequest listLoadbalancersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancersRequest);
            return new SyncInvoker<ListLoadbalancersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLoadbalancersResponse>);
        }
        
        /// <summary>
        /// 根据标签查询负载均衡器
        ///
        /// 根据标签过滤查询负载均衡实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLoadbalancersByTagsResponse ListLoadbalancersByTags(ListLoadbalancersByTagsRequest listLoadbalancersByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancersByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListLoadbalancersByTagsResponse>(response);
        }

        public SyncInvoker<ListLoadbalancersByTagsResponse> ListLoadbalancersByTagsInvoker(ListLoadbalancersByTagsRequest listLoadbalancersByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancersByTagsRequest);
            return new SyncInvoker<ListLoadbalancersByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLoadbalancersByTagsResponse>);
        }
        
        /// <summary>
        /// 查询后端云服务器列表
        ///
        /// 查询属于某个后端云服务器组的后端云服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMembersResponse ListMembers(ListMembersRequest listMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMembersRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMembersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMembersResponse>(response);
        }

        public SyncInvoker<ListMembersResponse> ListMembersInvoker(ListMembersRequest listMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMembersRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMembersRequest);
            return new SyncInvoker<ListMembersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMembersResponse>);
        }
        
        /// <summary>
        /// 查询后端云服务器组列表
        ///
        /// 查询后端云服务器组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPoolsResponse ListPools(ListPoolsRequest listPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPoolsResponse>(response);
        }

        public SyncInvoker<ListPoolsResponse> ListPoolsInvoker(ListPoolsRequest listPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolsRequest);
            return new SyncInvoker<ListPoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPoolsResponse>);
        }
        
        /// <summary>
        /// 查询白名单列表
        ///
        /// 查询白名单，支持过滤查询和分页查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWhitelistsResponse ListWhitelists(ListWhitelistsRequest listWhitelistsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWhitelistsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListWhitelistsResponse>(response);
        }

        public SyncInvoker<ListWhitelistsResponse> ListWhitelistsInvoker(ListWhitelistsRequest listWhitelistsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWhitelistsRequest);
            return new SyncInvoker<ListWhitelistsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWhitelistsResponse>);
        }
        
        /// <summary>
        /// 查询健康检查详情
        ///
        /// 根据指定ID查询健康检查详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHealthmonitorsResponse ShowHealthmonitors(ShowHealthmonitorsRequest showHealthmonitorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHealthmonitorsRequest.HealthmonitorId, out var valueOfHealthmonitorId)) urlParam.Add("healthmonitor_id", valueOfHealthmonitorId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthmonitorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHealthmonitorsResponse>(response);
        }

        public SyncInvoker<ShowHealthmonitorsResponse> ShowHealthmonitorsInvoker(ShowHealthmonitorsRequest showHealthmonitorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHealthmonitorsRequest.HealthmonitorId, out var valueOfHealthmonitorId)) urlParam.Add("healthmonitor_id", valueOfHealthmonitorId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthmonitorsRequest);
            return new SyncInvoker<ShowHealthmonitorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHealthmonitorsResponse>);
        }
        
        /// <summary>
        /// 查询转发策略详情
        ///
        /// 根据指定ID查询转发策略详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowL7policyResponse ShowL7policy(ShowL7policyRequest showL7policyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showL7policyRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7policyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowL7policyResponse>(response);
        }

        public SyncInvoker<ShowL7policyResponse> ShowL7policyInvoker(ShowL7policyRequest showL7policyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showL7policyRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7policyRequest);
            return new SyncInvoker<ShowL7policyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowL7policyResponse>);
        }
        
        /// <summary>
        /// 查询转发规则详情
        ///
        /// 根据指定ID查询某转发策略下关联的转发规则详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowL7ruleResponse ShowL7rule(ShowL7ruleRequest showL7ruleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showL7ruleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            if (StringUtils.TryConvertToNonEmptyString(showL7ruleRequest.L7ruleId, out var valueOfL7ruleId)) urlParam.Add("l7rule_id", valueOfL7ruleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7ruleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowL7ruleResponse>(response);
        }

        public SyncInvoker<ShowL7ruleResponse> ShowL7ruleInvoker(ShowL7ruleRequest showL7ruleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showL7ruleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            if (StringUtils.TryConvertToNonEmptyString(showL7ruleRequest.L7ruleId, out var valueOfL7ruleId)) urlParam.Add("l7rule_id", valueOfL7ruleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7ruleRequest);
            return new SyncInvoker<ShowL7ruleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowL7ruleResponse>);
        }
        
        /// <summary>
        /// 查询监听器详情
        ///
        /// 根据指定ID查询监听器详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowListenerResponse ShowListener(ShowListenerRequest showListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowListenerResponse>(response);
        }

        public SyncInvoker<ShowListenerResponse> ShowListenerInvoker(ShowListenerRequest showListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerRequest);
            return new SyncInvoker<ShowListenerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowListenerResponse>);
        }
        
        /// <summary>
        /// 查询监听器的标签详情
        ///
        /// 查询指定监听器的所有标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowListenerTagsResponse ShowListenerTags(ShowListenerTagsRequest showListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showListenerTagsRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowListenerTagsResponse>(response);
        }

        public SyncInvoker<ShowListenerTagsResponse> ShowListenerTagsInvoker(ShowListenerTagsRequest showListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showListenerTagsRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerTagsRequest);
            return new SyncInvoker<ShowListenerTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowListenerTagsResponse>);
        }
        
        /// <summary>
        /// 查询负载均衡详情
        ///
        /// 根据指定负载均衡器ID查询负载均衡器详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLoadbalancerResponse ShowLoadbalancer(ShowLoadbalancerRequest showLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoadbalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadbalancerRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLoadbalancerResponse>(response);
        }

        public SyncInvoker<ShowLoadbalancerResponse> ShowLoadbalancerInvoker(ShowLoadbalancerRequest showLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoadbalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadbalancerRequest);
            return new SyncInvoker<ShowLoadbalancerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLoadbalancerResponse>);
        }
        
        /// <summary>
        /// 查询负载均衡器的标签详情
        ///
        /// 查询指定负载均衡器的所有标签信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLoadbalancerTagsResponse ShowLoadbalancerTags(ShowLoadbalancerTagsRequest showLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoadbalancerTagsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadbalancerTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLoadbalancerTagsResponse>(response);
        }

        public SyncInvoker<ShowLoadbalancerTagsResponse> ShowLoadbalancerTagsInvoker(ShowLoadbalancerTagsRequest showLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoadbalancerTagsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadbalancerTagsRequest);
            return new SyncInvoker<ShowLoadbalancerTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLoadbalancerTagsResponse>);
        }
        
        /// <summary>
        /// 查询负载均衡状态树
        ///
        /// 查询负载均衡器状态树。可通过该接口查询负载均衡器关联的监听器、后端云服务器组、后端云服务器、健康检查、转发策略、转发规则的主要信息，了解负载均衡器下资源的拓扑情况。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLoadbalancersStatusResponse ShowLoadbalancersStatus(ShowLoadbalancersStatusRequest showLoadbalancersStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoadbalancersStatusRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers/{loadbalancer_id}/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadbalancersStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLoadbalancersStatusResponse>(response);
        }

        public SyncInvoker<ShowLoadbalancersStatusResponse> ShowLoadbalancersStatusInvoker(ShowLoadbalancersStatusRequest showLoadbalancersStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoadbalancersStatusRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers/{loadbalancer_id}/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadbalancersStatusRequest);
            return new SyncInvoker<ShowLoadbalancersStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLoadbalancersStatusResponse>);
        }
        
        /// <summary>
        /// 查询后端云服务器详情
        ///
        /// 根据指定ID查询后端云服务器详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMemberResponse ShowMember(ShowMemberRequest showMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            if (StringUtils.TryConvertToNonEmptyString(showMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMemberResponse>(response);
        }

        public SyncInvoker<ShowMemberResponse> ShowMemberInvoker(ShowMemberRequest showMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            if (StringUtils.TryConvertToNonEmptyString(showMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberRequest);
            return new SyncInvoker<ShowMemberResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMemberResponse>);
        }
        
        /// <summary>
        /// 查询后端云服务器组详情
        ///
        /// 根据指定ID查询后端云服务器组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPoolResponse ShowPool(ShowPoolRequest showPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPoolResponse>(response);
        }

        public SyncInvoker<ShowPoolResponse> ShowPoolInvoker(ShowPoolRequest showPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolRequest);
            return new SyncInvoker<ShowPoolResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPoolResponse>);
        }
        
        /// <summary>
        /// 查询白名单详情
        ///
        /// 根据指定ID查询白名单详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowWhitelistResponse ShowWhitelist(ShowWhitelistRequest showWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWhitelistRequest.WhitelistId, out var valueOfWhitelistId)) urlParam.Add("whitelist_id", valueOfWhitelistId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists/{whitelist_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWhitelistRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowWhitelistResponse>(response);
        }

        public SyncInvoker<ShowWhitelistResponse> ShowWhitelistInvoker(ShowWhitelistRequest showWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWhitelistRequest.WhitelistId, out var valueOfWhitelistId)) urlParam.Add("whitelist_id", valueOfWhitelistId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists/{whitelist_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWhitelistRequest);
            return new SyncInvoker<ShowWhitelistResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWhitelistResponse>);
        }
        
        /// <summary>
        /// 更新健康检查
        ///
        /// 更新健康检查
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateHealthmonitorResponse UpdateHealthmonitor(UpdateHealthmonitorRequest updateHealthmonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHealthmonitorRequest.HealthmonitorId, out var valueOfHealthmonitorId)) urlParam.Add("healthmonitor_id", valueOfHealthmonitorId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHealthmonitorRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHealthmonitorResponse>(response);
        }

        public SyncInvoker<UpdateHealthmonitorResponse> UpdateHealthmonitorInvoker(UpdateHealthmonitorRequest updateHealthmonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHealthmonitorRequest.HealthmonitorId, out var valueOfHealthmonitorId)) urlParam.Add("healthmonitor_id", valueOfHealthmonitorId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHealthmonitorRequest);
            return new SyncInvoker<UpdateHealthmonitorResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHealthmonitorResponse>);
        }
        
        /// <summary>
        /// 更新转发策略
        ///
        /// 更新转发策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateL7policiesResponse UpdateL7policies(UpdateL7policiesRequest updateL7policiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateL7policiesRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateL7policiesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateL7policiesResponse>(response);
        }

        public SyncInvoker<UpdateL7policiesResponse> UpdateL7policiesInvoker(UpdateL7policiesRequest updateL7policiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateL7policiesRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateL7policiesRequest);
            return new SyncInvoker<UpdateL7policiesResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateL7policiesResponse>);
        }
        
        /// <summary>
        /// 更新转发规则
        ///
        /// 更新指定的转发规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateL7ruleResponse UpdateL7rule(UpdateL7ruleRequest updateL7ruleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateL7ruleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            if (StringUtils.TryConvertToNonEmptyString(updateL7ruleRequest.L7ruleId, out var valueOfL7ruleId)) urlParam.Add("l7rule_id", valueOfL7ruleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateL7ruleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateL7ruleResponse>(response);
        }

        public SyncInvoker<UpdateL7ruleResponse> UpdateL7ruleInvoker(UpdateL7ruleRequest updateL7ruleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateL7ruleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            if (StringUtils.TryConvertToNonEmptyString(updateL7ruleRequest.L7ruleId, out var valueOfL7ruleId)) urlParam.Add("l7rule_id", valueOfL7ruleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateL7ruleRequest);
            return new SyncInvoker<UpdateL7ruleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateL7ruleResponse>);
        }
        
        /// <summary>
        /// 更新监听器
        ///
        /// 更新监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateListenerResponse UpdateListener(UpdateListenerRequest updateListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateListenerRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateListenerResponse>(response);
        }

        public SyncInvoker<UpdateListenerResponse> UpdateListenerInvoker(UpdateListenerRequest updateListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateListenerRequest);
            return new SyncInvoker<UpdateListenerResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateListenerResponse>);
        }
        
        /// <summary>
        /// 更新负载均衡器
        ///
        /// 更新负载均衡器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateLoadbalancerResponse UpdateLoadbalancer(UpdateLoadbalancerRequest updateLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLoadbalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLoadbalancerRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLoadbalancerResponse>(response);
        }

        public SyncInvoker<UpdateLoadbalancerResponse> UpdateLoadbalancerInvoker(UpdateLoadbalancerRequest updateLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLoadbalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLoadbalancerRequest);
            return new SyncInvoker<UpdateLoadbalancerResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLoadbalancerResponse>);
        }
        
        /// <summary>
        /// 更新后端云服务器
        ///
        /// 更新后端云服务器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMemberResponse UpdateMember(UpdateMemberRequest updateMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            if (StringUtils.TryConvertToNonEmptyString(updateMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMemberRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMemberResponse>(response);
        }

        public SyncInvoker<UpdateMemberResponse> UpdateMemberInvoker(UpdateMemberRequest updateMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            if (StringUtils.TryConvertToNonEmptyString(updateMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMemberRequest);
            return new SyncInvoker<UpdateMemberResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMemberResponse>);
        }
        
        /// <summary>
        /// 更新后端云服务器组
        ///
        /// 更新后端云服务器组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePoolResponse UpdatePool(UpdatePoolRequest updatePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePoolRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePoolResponse>(response);
        }

        public SyncInvoker<UpdatePoolResponse> UpdatePoolInvoker(UpdatePoolRequest updatePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePoolRequest);
            return new SyncInvoker<UpdatePoolResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePoolResponse>);
        }
        
        /// <summary>
        /// 更新白名单
        ///
        /// 更新白名单。可以打开或关闭白名单，或更新访问控制的IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateWhitelistResponse UpdateWhitelist(UpdateWhitelistRequest updateWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateWhitelistRequest.WhitelistId, out var valueOfWhitelistId)) urlParam.Add("whitelist_id", valueOfWhitelistId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists/{whitelist_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWhitelistRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateWhitelistResponse>(response);
        }

        public SyncInvoker<UpdateWhitelistResponse> UpdateWhitelistInvoker(UpdateWhitelistRequest updateWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateWhitelistRequest.WhitelistId, out var valueOfWhitelistId)) urlParam.Add("whitelist_id", valueOfWhitelistId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists/{whitelist_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWhitelistRequest);
            return new SyncInvoker<UpdateWhitelistResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateWhitelistResponse>);
        }
        
        /// <summary>
        /// 创建SSL证书
        ///
        /// 创建SSL证书。将监听器和SSL证书绑定后，可以通过负载均衡器实现服务端认证，后端服务器只要提供HTTP服务就能实现安全可靠的连接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCertificateResponse CreateCertificate(CreateCertificateRequest createCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCertificateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCertificateResponse>(response);
        }

        public SyncInvoker<CreateCertificateResponse> CreateCertificateInvoker(CreateCertificateRequest createCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCertificateRequest);
            return new SyncInvoker<CreateCertificateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCertificateResponse>);
        }
        
        /// <summary>
        /// 删除SSL证书
        ///
        /// 删除指定的SSL证书
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest deleteCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCertificateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCertificateResponse>(response);
        }

        public SyncInvoker<DeleteCertificateResponse> DeleteCertificateInvoker(DeleteCertificateRequest deleteCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCertificateRequest);
            return new SyncInvoker<DeleteCertificateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCertificateResponse>);
        }
        
        /// <summary>
        /// 查询SSL证书列表
        ///
        /// 查询SSL证书。支持过滤查询和分页查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCertificatesResponse ListCertificates(ListCertificatesRequest listCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCertificatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCertificatesResponse>(response);
        }

        public SyncInvoker<ListCertificatesResponse> ListCertificatesInvoker(ListCertificatesRequest listCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCertificatesRequest);
            return new SyncInvoker<ListCertificatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCertificatesResponse>);
        }
        
        /// <summary>
        /// 查询SSL证书详情
        ///
        /// 查询指定SSL证书的详情信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCertificateResponse ShowCertificate(ShowCertificateRequest showCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCertificateResponse>(response);
        }

        public SyncInvoker<ShowCertificateResponse> ShowCertificateInvoker(ShowCertificateRequest showCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificateRequest);
            return new SyncInvoker<ShowCertificateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCertificateResponse>);
        }
        
        /// <summary>
        /// 更新SSL证书
        ///
        /// 更新指定的SSL证书
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateCertificateResponse UpdateCertificate(UpdateCertificateRequest updateCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCertificateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCertificateResponse>(response);
        }

        public SyncInvoker<UpdateCertificateResponse> UpdateCertificateInvoker(UpdateCertificateRequest updateCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCertificateRequest);
            return new SyncInvoker<UpdateCertificateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCertificateResponse>);
        }
        
    }
}