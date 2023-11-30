using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Elb.V2.Model;

namespace HuaweiCloud.SDK.Elb.V2
{
    public partial class ElbAsyncClient : Client
    {
        public static ClientBuilder<ElbAsyncClient> NewBuilder()
        {
            return new ClientBuilder<ElbAsyncClient>();
        }

        
        /// <summary>
        /// 批量添加监听器标签
        ///
        /// 批量添加监听器标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateListenerTagsResponse> BatchCreateListenerTagsAsync(BatchCreateListenerTagsRequest batchCreateListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", batchCreateListenerTagsRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateListenerTagsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateListenerTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateListenerTagsResponse> BatchCreateListenerTagsAsyncInvoker(BatchCreateListenerTagsRequest batchCreateListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", batchCreateListenerTagsRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateListenerTagsRequest);
            return new AsyncInvoker<BatchCreateListenerTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateListenerTagsResponse>);
        }
        
        /// <summary>
        /// 批量添加负载均衡器标签
        ///
        /// 批量添加负载均衡器标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateLoadbalancerTagsResponse> BatchCreateLoadbalancerTagsAsync(BatchCreateLoadbalancerTagsRequest batchCreateLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", batchCreateLoadbalancerTagsRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateLoadbalancerTagsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateLoadbalancerTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateLoadbalancerTagsResponse> BatchCreateLoadbalancerTagsAsyncInvoker(BatchCreateLoadbalancerTagsRequest batchCreateLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", batchCreateLoadbalancerTagsRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateLoadbalancerTagsRequest);
            return new AsyncInvoker<BatchCreateLoadbalancerTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateLoadbalancerTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除监听器标签
        ///
        /// 批量删除监听器标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteListenerTagsResponse> BatchDeleteListenerTagsAsync(BatchDeleteListenerTagsRequest batchDeleteListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", batchDeleteListenerTagsRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteListenerTagsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteListenerTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteListenerTagsResponse> BatchDeleteListenerTagsAsyncInvoker(BatchDeleteListenerTagsRequest batchDeleteListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", batchDeleteListenerTagsRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteListenerTagsRequest);
            return new AsyncInvoker<BatchDeleteListenerTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteListenerTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除负载均衡器标签
        ///
        /// 批量删除负载均衡器标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteLoadbalancerTagsResponse> BatchDeleteLoadbalancerTagsAsync(BatchDeleteLoadbalancerTagsRequest batchDeleteLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", batchDeleteLoadbalancerTagsRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteLoadbalancerTagsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteLoadbalancerTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteLoadbalancerTagsResponse> BatchDeleteLoadbalancerTagsAsyncInvoker(BatchDeleteLoadbalancerTagsRequest batchDeleteLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", batchDeleteLoadbalancerTagsRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteLoadbalancerTagsRequest);
            return new AsyncInvoker<BatchDeleteLoadbalancerTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteLoadbalancerTagsResponse>);
        }
        
        /// <summary>
        /// 创建健康检查
        ///
        /// 给后端云服务器组添加健康检查
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateHealthmonitorResponse> CreateHealthmonitorAsync(CreateHealthmonitorRequest createHealthmonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHealthmonitorRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateHealthmonitorResponse>(response);
        }

        public AsyncInvoker<CreateHealthmonitorResponse> CreateHealthmonitorAsyncInvoker(CreateHealthmonitorRequest createHealthmonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHealthmonitorRequest);
            return new AsyncInvoker<CreateHealthmonitorResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHealthmonitorResponse>);
        }
        
        /// <summary>
        /// 创建转发策略
        ///
        /// 创建listener关联的转发策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateL7policyResponse> CreateL7policyAsync(CreateL7policyRequest createL7policyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createL7policyRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateL7policyResponse>(response);
        }

        public AsyncInvoker<CreateL7policyResponse> CreateL7policyAsyncInvoker(CreateL7policyRequest createL7policyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createL7policyRequest);
            return new AsyncInvoker<CreateL7policyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateL7policyResponse>);
        }
        
        /// <summary>
        /// 创建转发规则
        ///
        /// 创建转发规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateL7ruleResponse> CreateL7ruleAsync(CreateL7ruleRequest createL7ruleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", createL7ruleRequest.L7policyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createL7ruleRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateL7ruleResponse>(response);
        }

        public AsyncInvoker<CreateL7ruleResponse> CreateL7ruleAsyncInvoker(CreateL7ruleRequest createL7ruleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", createL7ruleRequest.L7policyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createL7ruleRequest);
            return new AsyncInvoker<CreateL7ruleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateL7ruleResponse>);
        }
        
        /// <summary>
        /// 创建监听器
        ///
        /// 创建与负载均衡器绑定的监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateListenerResponse> CreateListenerAsync(CreateListenerRequest createListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createListenerRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateListenerResponse>(response);
        }

        public AsyncInvoker<CreateListenerResponse> CreateListenerAsyncInvoker(CreateListenerRequest createListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createListenerRequest);
            return new AsyncInvoker<CreateListenerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateListenerResponse>);
        }
        
        /// <summary>
        /// 添加监听器标签
        ///
        /// 给指定监听器添加标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateListenerTagsResponse> CreateListenerTagsAsync(CreateListenerTagsRequest createListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", createListenerTagsRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createListenerTagsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateListenerTagsResponse>(response);
        }

        public AsyncInvoker<CreateListenerTagsResponse> CreateListenerTagsAsyncInvoker(CreateListenerTagsRequest createListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", createListenerTagsRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createListenerTagsRequest);
            return new AsyncInvoker<CreateListenerTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateListenerTagsResponse>);
        }
        
        /// <summary>
        /// 创建负载均衡器
        ///
        /// 创建私网类型的增强型负载均衡器。创建成功后，该接口会返回创建的增强型负载均衡器的ID、所属子网ID、负载均衡器IP等详细信息。若要创建公网类型的增强型负载均衡器，还需调用创建浮动IP的接口，将浮动IP与私网负载均衡器的vip_port_id绑定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLoadbalancerResponse> CreateLoadbalancerAsync(CreateLoadbalancerRequest createLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLoadbalancerRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateLoadbalancerResponse>(response);
        }

        public AsyncInvoker<CreateLoadbalancerResponse> CreateLoadbalancerAsyncInvoker(CreateLoadbalancerRequest createLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLoadbalancerRequest);
            return new AsyncInvoker<CreateLoadbalancerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLoadbalancerResponse>);
        }
        
        /// <summary>
        /// 添加负载均衡器标签
        ///
        /// 给指定负载均衡器添加标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLoadbalancerTagsResponse> CreateLoadbalancerTagsAsync(CreateLoadbalancerTagsRequest createLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", createLoadbalancerTagsRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLoadbalancerTagsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateLoadbalancerTagsResponse>(response);
        }

        public AsyncInvoker<CreateLoadbalancerTagsResponse> CreateLoadbalancerTagsAsyncInvoker(CreateLoadbalancerTagsRequest createLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", createLoadbalancerTagsRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLoadbalancerTagsRequest);
            return new AsyncInvoker<CreateLoadbalancerTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateLoadbalancerTagsResponse>);
        }
        
        /// <summary>
        /// 创建后端云服务器
        ///
        /// 添加属于某个后端云服务器组的后端云服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMemberResponse> CreateMemberAsync(CreateMemberRequest createMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", createMemberRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMemberRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateMemberResponse>(response);
        }

        public AsyncInvoker<CreateMemberResponse> CreateMemberAsyncInvoker(CreateMemberRequest createMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", createMemberRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMemberRequest);
            return new AsyncInvoker<CreateMemberResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMemberResponse>);
        }
        
        /// <summary>
        /// 创建后端云服务器组
        ///
        /// 创建后端云服务器组。将多个后端云服务器添加到后端云服务器组中后，请求会在后端云服务器间按后端云服务器组的负载均衡算法和后端云服务器的权重来做请求分发。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePoolResponse> CreatePoolAsync(CreatePoolRequest createPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPoolRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePoolResponse>(response);
        }

        public AsyncInvoker<CreatePoolResponse> CreatePoolAsyncInvoker(CreatePoolRequest createPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPoolRequest);
            return new AsyncInvoker<CreatePoolResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePoolResponse>);
        }
        
        /// <summary>
        /// 创建白名单
        ///
        /// 创建白名单，控制监听器的访问权限。若开启了白名单功能，只有白名单中放通的IP可以访问该监听器的后端服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateWhitelistResponse> CreateWhitelistAsync(CreateWhitelistRequest createWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWhitelistRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateWhitelistResponse>(response);
        }

        public AsyncInvoker<CreateWhitelistResponse> CreateWhitelistAsyncInvoker(CreateWhitelistRequest createWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWhitelistRequest);
            return new AsyncInvoker<CreateWhitelistResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWhitelistResponse>);
        }
        
        /// <summary>
        /// 删除健康检查
        ///
        /// 删除健康检查
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteHealthmonitorResponse> DeleteHealthmonitorAsync(DeleteHealthmonitorRequest deleteHealthmonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id", deleteHealthmonitorRequest.HealthmonitorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors/{healthmonitor_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHealthmonitorRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteHealthmonitorResponse>(response);
        }

        public AsyncInvoker<DeleteHealthmonitorResponse> DeleteHealthmonitorAsyncInvoker(DeleteHealthmonitorRequest deleteHealthmonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id", deleteHealthmonitorRequest.HealthmonitorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors/{healthmonitor_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHealthmonitorRequest);
            return new AsyncInvoker<DeleteHealthmonitorResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteHealthmonitorResponse>);
        }
        
        /// <summary>
        /// 删除转发策略
        ///
        /// 删除转发策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteL7policyResponse> DeleteL7policyAsync(DeleteL7policyRequest deleteL7policyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", deleteL7policyRequest.L7policyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7policyRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteL7policyResponse>(response);
        }

        public AsyncInvoker<DeleteL7policyResponse> DeleteL7policyAsyncInvoker(DeleteL7policyRequest deleteL7policyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", deleteL7policyRequest.L7policyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7policyRequest);
            return new AsyncInvoker<DeleteL7policyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteL7policyResponse>);
        }
        
        /// <summary>
        /// 删除转发规则
        ///
        /// 删除转发规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteL7ruleResponse> DeleteL7ruleAsync(DeleteL7ruleRequest deleteL7ruleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", deleteL7ruleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id", deleteL7ruleRequest.L7ruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7ruleRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteL7ruleResponse>(response);
        }

        public AsyncInvoker<DeleteL7ruleResponse> DeleteL7ruleAsyncInvoker(DeleteL7ruleRequest deleteL7ruleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", deleteL7ruleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id", deleteL7ruleRequest.L7ruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7ruleRequest);
            return new AsyncInvoker<DeleteL7ruleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteL7ruleResponse>);
        }
        
        /// <summary>
        /// 删除监听器
        ///
        /// 根据指定ID删除监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteListenerResponse> DeleteListenerAsync(DeleteListenerRequest deleteListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", deleteListenerRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners/{listener_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteListenerResponse>(response);
        }

        public AsyncInvoker<DeleteListenerResponse> DeleteListenerAsyncInvoker(DeleteListenerRequest deleteListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", deleteListenerRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners/{listener_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerRequest);
            return new AsyncInvoker<DeleteListenerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteListenerResponse>);
        }
        
        /// <summary>
        /// 删除监听器标签
        ///
        /// 删除监听器的某个key对应的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteListenerTagsResponse> DeleteListenerTagsAsync(DeleteListenerTagsRequest deleteListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", deleteListenerTagsRequest.ListenerId.ToString());
            urlParam.Add("key", deleteListenerTagsRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags/{key}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerTagsRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteListenerTagsResponse>(response);
        }

        public AsyncInvoker<DeleteListenerTagsResponse> DeleteListenerTagsAsyncInvoker(DeleteListenerTagsRequest deleteListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", deleteListenerTagsRequest.ListenerId.ToString());
            urlParam.Add("key", deleteListenerTagsRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags/{key}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerTagsRequest);
            return new AsyncInvoker<DeleteListenerTagsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteListenerTagsResponse>);
        }
        
        /// <summary>
        /// 删除负载均衡
        ///
        /// 根据指定ID删除负载均衡器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLoadbalancerResponse> DeleteLoadbalancerAsync(DeleteLoadbalancerRequest deleteLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", deleteLoadbalancerRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers/{loadbalancer_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadbalancerRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteLoadbalancerResponse>(response);
        }

        public AsyncInvoker<DeleteLoadbalancerResponse> DeleteLoadbalancerAsyncInvoker(DeleteLoadbalancerRequest deleteLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", deleteLoadbalancerRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers/{loadbalancer_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadbalancerRequest);
            return new AsyncInvoker<DeleteLoadbalancerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLoadbalancerResponse>);
        }
        
        /// <summary>
        /// 删除负载均衡标签
        ///
        /// 删除负载均衡器的某个key对应的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLoadbalancerTagsResponse> DeleteLoadbalancerTagsAsync(DeleteLoadbalancerTagsRequest deleteLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", deleteLoadbalancerTagsRequest.LoadbalancerId.ToString());
            urlParam.Add("key", deleteLoadbalancerTagsRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags/{key}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadbalancerTagsRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteLoadbalancerTagsResponse>(response);
        }

        public AsyncInvoker<DeleteLoadbalancerTagsResponse> DeleteLoadbalancerTagsAsyncInvoker(DeleteLoadbalancerTagsRequest deleteLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", deleteLoadbalancerTagsRequest.LoadbalancerId.ToString());
            urlParam.Add("key", deleteLoadbalancerTagsRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags/{key}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadbalancerTagsRequest);
            return new AsyncInvoker<DeleteLoadbalancerTagsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLoadbalancerTagsResponse>);
        }
        
        /// <summary>
        /// 删除后端云服务器
        ///
        /// 删除后端云服务器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteMemberResponse> DeleteMemberAsync(DeleteMemberRequest deleteMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", deleteMemberRequest.PoolId.ToString());
            urlParam.Add("member_id", deleteMemberRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members/{member_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMemberRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteMemberResponse>(response);
        }

        public AsyncInvoker<DeleteMemberResponse> DeleteMemberAsyncInvoker(DeleteMemberRequest deleteMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", deleteMemberRequest.PoolId.ToString());
            urlParam.Add("member_id", deleteMemberRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members/{member_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMemberRequest);
            return new AsyncInvoker<DeleteMemberResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMemberResponse>);
        }
        
        /// <summary>
        /// 删除后端云服务器组
        ///
        /// 删除后端云服务器组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePoolResponse> DeletePoolAsync(DeletePoolRequest deletePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", deletePoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePoolRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePoolResponse>(response);
        }

        public AsyncInvoker<DeletePoolResponse> DeletePoolAsyncInvoker(DeletePoolRequest deletePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", deletePoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePoolRequest);
            return new AsyncInvoker<DeletePoolResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePoolResponse>);
        }
        
        /// <summary>
        /// 删除白名单
        ///
        /// 删除白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteWhitelistResponse> DeleteWhitelistAsync(DeleteWhitelistRequest deleteWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("whitelist_id", deleteWhitelistRequest.WhitelistId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists/{whitelist_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWhitelistRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteWhitelistResponse>(response);
        }

        public AsyncInvoker<DeleteWhitelistResponse> DeleteWhitelistAsyncInvoker(DeleteWhitelistRequest deleteWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("whitelist_id", deleteWhitelistRequest.WhitelistId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists/{whitelist_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWhitelistRequest);
            return new AsyncInvoker<DeleteWhitelistResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteWhitelistResponse>);
        }
        
        /// <summary>
        /// 查询健康检查列表
        ///
        /// 查询健康检查列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHealthmonitorsResponse> ListHealthmonitorsAsync(ListHealthmonitorsRequest listHealthmonitorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHealthmonitorsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListHealthmonitorsResponse>(response);
        }

        public AsyncInvoker<ListHealthmonitorsResponse> ListHealthmonitorsAsyncInvoker(ListHealthmonitorsRequest listHealthmonitorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHealthmonitorsRequest);
            return new AsyncInvoker<ListHealthmonitorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHealthmonitorsResponse>);
        }
        
        /// <summary>
        /// 查询转发策略列表
        ///
        /// 查询转发策略。支持过滤查询和分页查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListL7policiesResponse> ListL7policiesAsync(ListL7policiesRequest listL7policiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7policiesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListL7policiesResponse>(response);
        }

        public AsyncInvoker<ListL7policiesResponse> ListL7policiesAsyncInvoker(ListL7policiesRequest listL7policiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7policiesRequest);
            return new AsyncInvoker<ListL7policiesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListL7policiesResponse>);
        }
        
        /// <summary>
        /// 查询转发规则列表
        ///
        /// 查询指定转发策略下关联的转发规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListL7rulesResponse> ListL7rulesAsync(ListL7rulesRequest listL7rulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", listL7rulesRequest.L7policyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7rulesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListL7rulesResponse>(response);
        }

        public AsyncInvoker<ListL7rulesResponse> ListL7rulesAsyncInvoker(ListL7rulesRequest listL7rulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", listL7rulesRequest.L7policyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7rulesRequest);
            return new AsyncInvoker<ListL7rulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListL7rulesResponse>);
        }
        
        /// <summary>
        /// 查询所有监听器的标签列表
        ///
        /// 查询指定项目下所有监听器的标签列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListListenerTagsResponse> ListListenerTagsAsync(ListListenerTagsRequest listListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenerTagsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListListenerTagsResponse>(response);
        }

        public AsyncInvoker<ListListenerTagsResponse> ListListenerTagsAsyncInvoker(ListListenerTagsRequest listListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenerTagsRequest);
            return new AsyncInvoker<ListListenerTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListListenerTagsResponse>);
        }
        
        /// <summary>
        /// 查询监听器列表
        ///
        /// 查询监听器列表。支持过滤查询和分页查询。可以通过监听器ID、协议类型、监听端口号、关联的后端云服务器的IP等查询监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListListenersResponse> ListListenersAsync(ListListenersRequest listListenersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListListenersResponse>(response);
        }

        public AsyncInvoker<ListListenersResponse> ListListenersAsyncInvoker(ListListenersRequest listListenersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersRequest);
            return new AsyncInvoker<ListListenersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListListenersResponse>);
        }
        
        /// <summary>
        /// 根据标签查询监听器
        ///
        /// 根据标签过滤查询监听器实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListListenersByTagsResponse> ListListenersByTagsAsync(ListListenersByTagsRequest listListenersByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/resource_instances/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersByTagsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListListenersByTagsResponse>(response);
        }

        public AsyncInvoker<ListListenersByTagsResponse> ListListenersByTagsAsyncInvoker(ListListenersByTagsRequest listListenersByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/resource_instances/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersByTagsRequest);
            return new AsyncInvoker<ListListenersByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListListenersByTagsResponse>);
        }
        
        /// <summary>
        /// 查询所有负载均衡器的标签列表
        ///
        /// 查询指定项目下所有负载均衡器的标签列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLoadbalancerTagsResponse> ListLoadbalancerTagsAsync(ListLoadbalancerTagsRequest listLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancerTagsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListLoadbalancerTagsResponse>(response);
        }

        public AsyncInvoker<ListLoadbalancerTagsResponse> ListLoadbalancerTagsAsyncInvoker(ListLoadbalancerTagsRequest listLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancerTagsRequest);
            return new AsyncInvoker<ListLoadbalancerTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLoadbalancerTagsResponse>);
        }
        
        /// <summary>
        /// 查询负载均衡列表
        ///
        /// 查询负载均衡器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLoadbalancersResponse> ListLoadbalancersAsync(ListLoadbalancersRequest listLoadbalancersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancersRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListLoadbalancersResponse>(response);
        }

        public AsyncInvoker<ListLoadbalancersResponse> ListLoadbalancersAsyncInvoker(ListLoadbalancersRequest listLoadbalancersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancersRequest);
            return new AsyncInvoker<ListLoadbalancersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLoadbalancersResponse>);
        }
        
        /// <summary>
        /// 根据标签查询负载均衡器
        ///
        /// 根据标签过滤查询负载均衡实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLoadbalancersByTagsResponse> ListLoadbalancersByTagsAsync(ListLoadbalancersByTagsRequest listLoadbalancersByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/resource_instances/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancersByTagsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListLoadbalancersByTagsResponse>(response);
        }

        public AsyncInvoker<ListLoadbalancersByTagsResponse> ListLoadbalancersByTagsAsyncInvoker(ListLoadbalancersByTagsRequest listLoadbalancersByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/resource_instances/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancersByTagsRequest);
            return new AsyncInvoker<ListLoadbalancersByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLoadbalancersByTagsResponse>);
        }
        
        /// <summary>
        /// 查询后端云服务器列表
        ///
        /// 查询属于某个后端云服务器组的后端云服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMembersResponse> ListMembersAsync(ListMembersRequest listMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", listMembersRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMembersRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMembersResponse>(response);
        }

        public AsyncInvoker<ListMembersResponse> ListMembersAsyncInvoker(ListMembersRequest listMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", listMembersRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMembersRequest);
            return new AsyncInvoker<ListMembersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMembersResponse>);
        }
        
        /// <summary>
        /// 查询后端云服务器组列表
        ///
        /// 查询后端云服务器组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPoolsResponse> ListPoolsAsync(ListPoolsRequest listPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPoolsResponse>(response);
        }

        public AsyncInvoker<ListPoolsResponse> ListPoolsAsyncInvoker(ListPoolsRequest listPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolsRequest);
            return new AsyncInvoker<ListPoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPoolsResponse>);
        }
        
        /// <summary>
        /// 查询白名单列表
        ///
        /// 查询白名单，支持过滤查询和分页查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWhitelistsResponse> ListWhitelistsAsync(ListWhitelistsRequest listWhitelistsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWhitelistsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListWhitelistsResponse>(response);
        }

        public AsyncInvoker<ListWhitelistsResponse> ListWhitelistsAsyncInvoker(ListWhitelistsRequest listWhitelistsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWhitelistsRequest);
            return new AsyncInvoker<ListWhitelistsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWhitelistsResponse>);
        }
        
        /// <summary>
        /// 查询健康检查详情
        ///
        /// 根据指定ID查询健康检查详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHealthmonitorsResponse> ShowHealthmonitorsAsync(ShowHealthmonitorsRequest showHealthmonitorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id", showHealthmonitorsRequest.HealthmonitorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors/{healthmonitor_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthmonitorsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowHealthmonitorsResponse>(response);
        }

        public AsyncInvoker<ShowHealthmonitorsResponse> ShowHealthmonitorsAsyncInvoker(ShowHealthmonitorsRequest showHealthmonitorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id", showHealthmonitorsRequest.HealthmonitorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors/{healthmonitor_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthmonitorsRequest);
            return new AsyncInvoker<ShowHealthmonitorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHealthmonitorsResponse>);
        }
        
        /// <summary>
        /// 查询转发策略详情
        ///
        /// 根据指定ID查询转发策略详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowL7policyResponse> ShowL7policyAsync(ShowL7policyRequest showL7policyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", showL7policyRequest.L7policyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7policyRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowL7policyResponse>(response);
        }

        public AsyncInvoker<ShowL7policyResponse> ShowL7policyAsyncInvoker(ShowL7policyRequest showL7policyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", showL7policyRequest.L7policyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7policyRequest);
            return new AsyncInvoker<ShowL7policyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowL7policyResponse>);
        }
        
        /// <summary>
        /// 查询转发规则详情
        ///
        /// 根据指定ID查询某转发策略下关联的转发规则详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowL7ruleResponse> ShowL7ruleAsync(ShowL7ruleRequest showL7ruleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", showL7ruleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id", showL7ruleRequest.L7ruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7ruleRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowL7ruleResponse>(response);
        }

        public AsyncInvoker<ShowL7ruleResponse> ShowL7ruleAsyncInvoker(ShowL7ruleRequest showL7ruleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", showL7ruleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id", showL7ruleRequest.L7ruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7ruleRequest);
            return new AsyncInvoker<ShowL7ruleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowL7ruleResponse>);
        }
        
        /// <summary>
        /// 查询监听器详情
        ///
        /// 根据指定ID查询监听器详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowListenerResponse> ShowListenerAsync(ShowListenerRequest showListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", showListenerRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners/{listener_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowListenerResponse>(response);
        }

        public AsyncInvoker<ShowListenerResponse> ShowListenerAsyncInvoker(ShowListenerRequest showListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", showListenerRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners/{listener_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerRequest);
            return new AsyncInvoker<ShowListenerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowListenerResponse>);
        }
        
        /// <summary>
        /// 查询监听器的标签详情
        ///
        /// 查询指定监听器的所有标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowListenerTagsResponse> ShowListenerTagsAsync(ShowListenerTagsRequest showListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", showListenerTagsRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerTagsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowListenerTagsResponse>(response);
        }

        public AsyncInvoker<ShowListenerTagsResponse> ShowListenerTagsAsyncInvoker(ShowListenerTagsRequest showListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", showListenerTagsRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerTagsRequest);
            return new AsyncInvoker<ShowListenerTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowListenerTagsResponse>);
        }
        
        /// <summary>
        /// 查询负载均衡详情
        ///
        /// 根据指定负载均衡器ID查询负载均衡器详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLoadbalancerResponse> ShowLoadbalancerAsync(ShowLoadbalancerRequest showLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", showLoadbalancerRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers/{loadbalancer_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadbalancerRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowLoadbalancerResponse>(response);
        }

        public AsyncInvoker<ShowLoadbalancerResponse> ShowLoadbalancerAsyncInvoker(ShowLoadbalancerRequest showLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", showLoadbalancerRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers/{loadbalancer_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadbalancerRequest);
            return new AsyncInvoker<ShowLoadbalancerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLoadbalancerResponse>);
        }
        
        /// <summary>
        /// 查询负载均衡器的标签详情
        ///
        /// 查询指定负载均衡器的所有标签信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLoadbalancerTagsResponse> ShowLoadbalancerTagsAsync(ShowLoadbalancerTagsRequest showLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", showLoadbalancerTagsRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadbalancerTagsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowLoadbalancerTagsResponse>(response);
        }

        public AsyncInvoker<ShowLoadbalancerTagsResponse> ShowLoadbalancerTagsAsyncInvoker(ShowLoadbalancerTagsRequest showLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", showLoadbalancerTagsRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadbalancerTagsRequest);
            return new AsyncInvoker<ShowLoadbalancerTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLoadbalancerTagsResponse>);
        }
        
        /// <summary>
        /// 查询负载均衡状态树
        ///
        /// 查询负载均衡器状态树。可通过该接口查询负载均衡器关联的监听器、后端云服务器组、后端云服务器、健康检查、转发策略、转发规则的主要信息，了解负载均衡器下资源的拓扑情况。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLoadbalancersStatusResponse> ShowLoadbalancersStatusAsync(ShowLoadbalancersStatusRequest showLoadbalancersStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", showLoadbalancersStatusRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers/{loadbalancer_id}/statuses",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadbalancersStatusRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowLoadbalancersStatusResponse>(response);
        }

        public AsyncInvoker<ShowLoadbalancersStatusResponse> ShowLoadbalancersStatusAsyncInvoker(ShowLoadbalancersStatusRequest showLoadbalancersStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", showLoadbalancersStatusRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers/{loadbalancer_id}/statuses",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadbalancersStatusRequest);
            return new AsyncInvoker<ShowLoadbalancersStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLoadbalancersStatusResponse>);
        }
        
        /// <summary>
        /// 查询后端云服务器详情
        ///
        /// 根据指定ID查询后端云服务器详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMemberResponse> ShowMemberAsync(ShowMemberRequest showMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", showMemberRequest.PoolId.ToString());
            urlParam.Add("member_id", showMemberRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members/{member_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMemberResponse>(response);
        }

        public AsyncInvoker<ShowMemberResponse> ShowMemberAsyncInvoker(ShowMemberRequest showMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", showMemberRequest.PoolId.ToString());
            urlParam.Add("member_id", showMemberRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members/{member_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberRequest);
            return new AsyncInvoker<ShowMemberResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMemberResponse>);
        }
        
        /// <summary>
        /// 查询后端云服务器组详情
        ///
        /// 根据指定ID查询后端云服务器组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPoolResponse> ShowPoolAsync(ShowPoolRequest showPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", showPoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPoolResponse>(response);
        }

        public AsyncInvoker<ShowPoolResponse> ShowPoolAsyncInvoker(ShowPoolRequest showPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", showPoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolRequest);
            return new AsyncInvoker<ShowPoolResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPoolResponse>);
        }
        
        /// <summary>
        /// 查询白名单详情
        ///
        /// 根据指定ID查询白名单详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWhitelistResponse> ShowWhitelistAsync(ShowWhitelistRequest showWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("whitelist_id", showWhitelistRequest.WhitelistId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists/{whitelist_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWhitelistRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowWhitelistResponse>(response);
        }

        public AsyncInvoker<ShowWhitelistResponse> ShowWhitelistAsyncInvoker(ShowWhitelistRequest showWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("whitelist_id", showWhitelistRequest.WhitelistId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists/{whitelist_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWhitelistRequest);
            return new AsyncInvoker<ShowWhitelistResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWhitelistResponse>);
        }
        
        /// <summary>
        /// 更新健康检查
        ///
        /// 更新健康检查
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateHealthmonitorResponse> UpdateHealthmonitorAsync(UpdateHealthmonitorRequest updateHealthmonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id", updateHealthmonitorRequest.HealthmonitorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors/{healthmonitor_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHealthmonitorRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateHealthmonitorResponse>(response);
        }

        public AsyncInvoker<UpdateHealthmonitorResponse> UpdateHealthmonitorAsyncInvoker(UpdateHealthmonitorRequest updateHealthmonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id", updateHealthmonitorRequest.HealthmonitorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors/{healthmonitor_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHealthmonitorRequest);
            return new AsyncInvoker<UpdateHealthmonitorResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHealthmonitorResponse>);
        }
        
        /// <summary>
        /// 更新转发策略
        ///
        /// 更新转发策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateL7policiesResponse> UpdateL7policiesAsync(UpdateL7policiesRequest updateL7policiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", updateL7policiesRequest.L7policyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateL7policiesRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateL7policiesResponse>(response);
        }

        public AsyncInvoker<UpdateL7policiesResponse> UpdateL7policiesAsyncInvoker(UpdateL7policiesRequest updateL7policiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", updateL7policiesRequest.L7policyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateL7policiesRequest);
            return new AsyncInvoker<UpdateL7policiesResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateL7policiesResponse>);
        }
        
        /// <summary>
        /// 更新转发规则
        ///
        /// 更新指定的转发规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateL7ruleResponse> UpdateL7ruleAsync(UpdateL7ruleRequest updateL7ruleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", updateL7ruleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id", updateL7ruleRequest.L7ruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateL7ruleRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateL7ruleResponse>(response);
        }

        public AsyncInvoker<UpdateL7ruleResponse> UpdateL7ruleAsyncInvoker(UpdateL7ruleRequest updateL7ruleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", updateL7ruleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id", updateL7ruleRequest.L7ruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateL7ruleRequest);
            return new AsyncInvoker<UpdateL7ruleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateL7ruleResponse>);
        }
        
        /// <summary>
        /// 更新监听器
        ///
        /// 更新监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateListenerResponse> UpdateListenerAsync(UpdateListenerRequest updateListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", updateListenerRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners/{listener_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateListenerRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateListenerResponse>(response);
        }

        public AsyncInvoker<UpdateListenerResponse> UpdateListenerAsyncInvoker(UpdateListenerRequest updateListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", updateListenerRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners/{listener_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateListenerRequest);
            return new AsyncInvoker<UpdateListenerResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateListenerResponse>);
        }
        
        /// <summary>
        /// 更新负载均衡器
        ///
        /// 更新负载均衡器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLoadbalancerResponse> UpdateLoadbalancerAsync(UpdateLoadbalancerRequest updateLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", updateLoadbalancerRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers/{loadbalancer_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLoadbalancerRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateLoadbalancerResponse>(response);
        }

        public AsyncInvoker<UpdateLoadbalancerResponse> UpdateLoadbalancerAsyncInvoker(UpdateLoadbalancerRequest updateLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", updateLoadbalancerRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers/{loadbalancer_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLoadbalancerRequest);
            return new AsyncInvoker<UpdateLoadbalancerResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLoadbalancerResponse>);
        }
        
        /// <summary>
        /// 更新后端云服务器
        ///
        /// 更新后端云服务器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMemberResponse> UpdateMemberAsync(UpdateMemberRequest updateMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("member_id", updateMemberRequest.MemberId.ToString());
            urlParam.Add("pool_id", updateMemberRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members/{member_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMemberRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateMemberResponse>(response);
        }

        public AsyncInvoker<UpdateMemberResponse> UpdateMemberAsyncInvoker(UpdateMemberRequest updateMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("member_id", updateMemberRequest.MemberId.ToString());
            urlParam.Add("pool_id", updateMemberRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members/{member_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMemberRequest);
            return new AsyncInvoker<UpdateMemberResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMemberResponse>);
        }
        
        /// <summary>
        /// 更新后端云服务器组
        ///
        /// 更新后端云服务器组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePoolResponse> UpdatePoolAsync(UpdatePoolRequest updatePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", updatePoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePoolRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePoolResponse>(response);
        }

        public AsyncInvoker<UpdatePoolResponse> UpdatePoolAsyncInvoker(UpdatePoolRequest updatePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", updatePoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePoolRequest);
            return new AsyncInvoker<UpdatePoolResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePoolResponse>);
        }
        
        /// <summary>
        /// 更新白名单
        ///
        /// 更新白名单。可以打开或关闭白名单，或更新访问控制的IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateWhitelistResponse> UpdateWhitelistAsync(UpdateWhitelistRequest updateWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("whitelist_id", updateWhitelistRequest.WhitelistId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists/{whitelist_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWhitelistRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateWhitelistResponse>(response);
        }

        public AsyncInvoker<UpdateWhitelistResponse> UpdateWhitelistAsyncInvoker(UpdateWhitelistRequest updateWhitelistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("whitelist_id", updateWhitelistRequest.WhitelistId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists/{whitelist_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWhitelistRequest);
            return new AsyncInvoker<UpdateWhitelistResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateWhitelistResponse>);
        }
        
        /// <summary>
        /// 创建SSL证书
        ///
        /// 创建SSL证书。将监听器和SSL证书绑定后，可以通过负载均衡器实现服务端认证，后端服务器只要提供HTTP服务就能实现安全可靠的连接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCertificateResponse> CreateCertificateAsync(CreateCertificateRequest createCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCertificateRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateCertificateResponse>(response);
        }

        public AsyncInvoker<CreateCertificateResponse> CreateCertificateAsyncInvoker(CreateCertificateRequest createCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCertificateRequest);
            return new AsyncInvoker<CreateCertificateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCertificateResponse>);
        }
        
        /// <summary>
        /// 删除SSL证书
        ///
        /// 删除指定的SSL证书
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest deleteCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id", deleteCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates/{certificate_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCertificateRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteCertificateResponse>(response);
        }

        public AsyncInvoker<DeleteCertificateResponse> DeleteCertificateAsyncInvoker(DeleteCertificateRequest deleteCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id", deleteCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates/{certificate_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCertificateRequest);
            return new AsyncInvoker<DeleteCertificateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCertificateResponse>);
        }
        
        /// <summary>
        /// 查询SSL证书列表
        ///
        /// 查询SSL证书。支持过滤查询和分页查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCertificatesResponse> ListCertificatesAsync(ListCertificatesRequest listCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCertificatesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListCertificatesResponse>(response);
        }

        public AsyncInvoker<ListCertificatesResponse> ListCertificatesAsyncInvoker(ListCertificatesRequest listCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCertificatesRequest);
            return new AsyncInvoker<ListCertificatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCertificatesResponse>);
        }
        
        /// <summary>
        /// 查询SSL证书详情
        ///
        /// 查询指定SSL证书的详情信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCertificateResponse> ShowCertificateAsync(ShowCertificateRequest showCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id", showCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates/{certificate_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificateRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCertificateResponse>(response);
        }

        public AsyncInvoker<ShowCertificateResponse> ShowCertificateAsyncInvoker(ShowCertificateRequest showCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id", showCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates/{certificate_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificateRequest);
            return new AsyncInvoker<ShowCertificateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCertificateResponse>);
        }
        
        /// <summary>
        /// 更新SSL证书
        ///
        /// 更新指定的SSL证书
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateCertificateResponse> UpdateCertificateAsync(UpdateCertificateRequest updateCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id", updateCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates/{certificate_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCertificateRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateCertificateResponse>(response);
        }

        public AsyncInvoker<UpdateCertificateResponse> UpdateCertificateAsyncInvoker(UpdateCertificateRequest updateCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id", updateCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates/{certificate_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCertificateRequest);
            return new AsyncInvoker<UpdateCertificateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCertificateResponse>);
        }
        
    }
}