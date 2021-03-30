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
        /// </summary>
        public BatchCreateListenerTagsResponse BatchCreateListenerTags(BatchCreateListenerTagsRequest batchCreateListenerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id" , batchCreateListenerTagsRequest.ListenerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateListenerTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateListenerTagsResponse>(response);
        }
        
        /// <summary>
        /// 批量添加负载均衡器标签
        /// </summary>
        public BatchCreateLoadbalancerTagsResponse BatchCreateLoadbalancerTags(BatchCreateLoadbalancerTagsRequest batchCreateLoadbalancerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , batchCreateLoadbalancerTagsRequest.LoadbalancerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateLoadbalancerTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateLoadbalancerTagsResponse>(response);
        }
        
        /// <summary>
        /// 批量删除监听器标签
        /// </summary>
        public BatchDeleteListenerTagsResponse BatchDeleteListenerTags(BatchDeleteListenerTagsRequest batchDeleteListenerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id" , batchDeleteListenerTagsRequest.ListenerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteListenerTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteListenerTagsResponse>(response);
        }
        
        /// <summary>
        /// 批量删除负载均衡器标签
        /// </summary>
        public BatchDeleteLoadbalancerTagsResponse BatchDeleteLoadbalancerTags(BatchDeleteLoadbalancerTagsRequest batchDeleteLoadbalancerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , batchDeleteLoadbalancerTagsRequest.LoadbalancerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteLoadbalancerTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteLoadbalancerTagsResponse>(response);
        }
        
        /// <summary>
        /// 创建健康检查
        /// </summary>
        public CreateHealthmonitorResponse CreateHealthmonitor(CreateHealthmonitorRequest createHealthmonitorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHealthmonitorRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateHealthmonitorResponse>(response);
        }
        
        /// <summary>
        /// 创建转发策略
        /// </summary>
        public CreateL7policyResponse CreateL7policy(CreateL7policyRequest createL7policyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createL7policyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateL7policyResponse>(response);
        }
        
        /// <summary>
        /// 创建转发规则
        /// </summary>
        public CreateL7ruleResponse CreateL7rule(CreateL7ruleRequest createL7ruleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , createL7ruleRequest.L7policyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createL7ruleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateL7ruleResponse>(response);
        }
        
        /// <summary>
        /// 创建监听器
        /// </summary>
        public CreateListenerResponse CreateListener(CreateListenerRequest createListenerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createListenerRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateListenerResponse>(response);
        }
        
        /// <summary>
        /// 添加监听器标签
        /// </summary>
        public CreateListenerTagsResponse CreateListenerTags(CreateListenerTagsRequest createListenerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id" , createListenerTagsRequest.ListenerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createListenerTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateListenerTagsResponse>(response);
        }
        
        /// <summary>
        /// 创建负载均衡器
        /// </summary>
        public CreateLoadbalancerResponse CreateLoadbalancer(CreateLoadbalancerRequest createLoadbalancerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLoadbalancerRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateLoadbalancerResponse>(response);
        }
        
        /// <summary>
        /// 添加负载均衡器标签
        /// </summary>
        public CreateLoadbalancerTagsResponse CreateLoadbalancerTags(CreateLoadbalancerTagsRequest createLoadbalancerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , createLoadbalancerTagsRequest.LoadbalancerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLoadbalancerTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateLoadbalancerTagsResponse>(response);
        }
        
        /// <summary>
        /// 创建后端云服务器
        /// </summary>
        public CreateMemberResponse CreateMember(CreateMemberRequest createMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , createMemberRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMemberRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateMemberResponse>(response);
        }
        
        /// <summary>
        /// 创建后端云服务器组
        /// </summary>
        public CreatePoolResponse CreatePool(CreatePoolRequest createPoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPoolRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePoolResponse>(response);
        }
        
        /// <summary>
        /// 创建白名单
        /// </summary>
        public CreateWhitelistResponse CreateWhitelist(CreateWhitelistRequest createWhitelistRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWhitelistRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateWhitelistResponse>(response);
        }
        
        /// <summary>
        /// 删除健康检查
        /// </summary>
        public DeleteHealthmonitorResponse DeleteHealthmonitor(DeleteHealthmonitorRequest deleteHealthmonitorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id" , deleteHealthmonitorRequest.HealthmonitorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors/{healthmonitor_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHealthmonitorRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteHealthmonitorResponse>(response);
        }
        
        /// <summary>
        /// 删除转发策略
        /// </summary>
        public DeleteL7policyResponse DeleteL7policy(DeleteL7policyRequest deleteL7policyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , deleteL7policyRequest.L7policyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7policyRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteL7policyResponse>(response);
        }
        
        /// <summary>
        /// 删除转发规则
        /// </summary>
        public DeleteL7ruleResponse DeleteL7rule(DeleteL7ruleRequest deleteL7ruleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , deleteL7ruleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id" , deleteL7ruleRequest.L7ruleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7ruleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteL7ruleResponse>(response);
        }
        
        /// <summary>
        /// 删除监听器
        /// </summary>
        public DeleteListenerResponse DeleteListener(DeleteListenerRequest deleteListenerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id" , deleteListenerRequest.ListenerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners/{listener_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteListenerResponse>(response);
        }
        
        /// <summary>
        /// 删除监听器标签
        /// </summary>
        public DeleteListenerTagsResponse DeleteListenerTags(DeleteListenerTagsRequest deleteListenerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id" , deleteListenerTagsRequest.ListenerId.ToString());
            urlParam.Add("key" , deleteListenerTagsRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteListenerTagsResponse>(response);
        }
        
        /// <summary>
        /// 删除负载均衡
        /// </summary>
        public DeleteLoadbalancerResponse DeleteLoadbalancer(DeleteLoadbalancerRequest deleteLoadbalancerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , deleteLoadbalancerRequest.LoadbalancerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers/{loadbalancer_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadbalancerRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteLoadbalancerResponse>(response);
        }
        
        /// <summary>
        /// 删除负载均衡标签
        /// </summary>
        public DeleteLoadbalancerTagsResponse DeleteLoadbalancerTags(DeleteLoadbalancerTagsRequest deleteLoadbalancerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , deleteLoadbalancerTagsRequest.LoadbalancerId.ToString());
            urlParam.Add("key" , deleteLoadbalancerTagsRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadbalancerTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteLoadbalancerTagsResponse>(response);
        }
        
        /// <summary>
        /// 删除后端云服务器
        /// </summary>
        public DeleteMemberResponse DeleteMember(DeleteMemberRequest deleteMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , deleteMemberRequest.PoolId.ToString());
            urlParam.Add("member_id" , deleteMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMemberRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteMemberResponse>(response);
        }
        
        /// <summary>
        /// 删除后端云服务器组
        /// </summary>
        public DeletePoolResponse DeletePool(DeletePoolRequest deletePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , deletePoolRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePoolRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePoolResponse>(response);
        }
        
        /// <summary>
        /// 删除白名单
        /// </summary>
        public DeleteWhitelistResponse DeleteWhitelist(DeleteWhitelistRequest deleteWhitelistRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("whitelist_id" , deleteWhitelistRequest.WhitelistId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists/{whitelist_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWhitelistRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteWhitelistResponse>(response);
        }
        
        /// <summary>
        /// 查询健康检查列表
        /// </summary>
        public ListHealthmonitorsResponse ListHealthmonitors(ListHealthmonitorsRequest listHealthmonitorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHealthmonitorsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListHealthmonitorsResponse>(response);
        }
        
        /// <summary>
        /// 查询转发策略列表
        /// </summary>
        public ListL7policiesResponse ListL7policies(ListL7policiesRequest listL7policiesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7policiesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListL7policiesResponse>(response);
        }
        
        /// <summary>
        /// 查询转发规则列表
        /// </summary>
        public ListL7rulesResponse ListL7rules(ListL7rulesRequest listL7rulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , listL7rulesRequest.L7policyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7rulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListL7rulesResponse>(response);
        }
        
        /// <summary>
        /// 查询所有监听器的标签列表
        /// </summary>
        public ListListenerTagsResponse ListListenerTags(ListListenerTagsRequest listListenerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenerTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListListenerTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询监听器列表
        /// </summary>
        public ListListenersResponse ListListeners(ListListenersRequest listListenersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListListenersResponse>(response);
        }
        
        /// <summary>
        /// 根据标签查询监听器
        /// </summary>
        public ListListenersByTagsResponse ListListenersByTags(ListListenersByTagsRequest listListenersByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersByTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListListenersByTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询所有负载均衡器的标签列表
        /// </summary>
        public ListLoadbalancerTagsResponse ListLoadbalancerTags(ListLoadbalancerTagsRequest listLoadbalancerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancerTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListLoadbalancerTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询负载均衡列表
        /// </summary>
        public ListLoadbalancersResponse ListLoadbalancers(ListLoadbalancersRequest listLoadbalancersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListLoadbalancersResponse>(response);
        }
        
        /// <summary>
        /// 根据标签查询负载均衡器
        /// </summary>
        public ListLoadbalancersByTagsResponse ListLoadbalancersByTags(ListLoadbalancersByTagsRequest listLoadbalancersByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancersByTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListLoadbalancersByTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询后端云服务器列表
        /// </summary>
        public ListMembersResponse ListMembers(ListMembersRequest listMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , listMembersRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMembersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListMembersResponse>(response);
        }
        
        /// <summary>
        /// 查询后端云服务器组列表
        /// </summary>
        public ListPoolsResponse ListPools(ListPoolsRequest listPoolsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPoolsResponse>(response);
        }
        
        /// <summary>
        /// 查询白名单列表
        /// </summary>
        public ListWhitelistsResponse ListWhitelists(ListWhitelistsRequest listWhitelistsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWhitelistsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListWhitelistsResponse>(response);
        }
        
        /// <summary>
        /// 查询健康检查详情
        /// </summary>
        public ShowHealthmonitorsResponse ShowHealthmonitors(ShowHealthmonitorsRequest showHealthmonitorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id" , showHealthmonitorsRequest.HealthmonitorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors/{healthmonitor_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthmonitorsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowHealthmonitorsResponse>(response);
        }
        
        /// <summary>
        /// 查询转发策略详情
        /// </summary>
        public ShowL7policyResponse ShowL7policy(ShowL7policyRequest showL7policyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , showL7policyRequest.L7policyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7policyRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowL7policyResponse>(response);
        }
        
        /// <summary>
        /// 查询转发规则详情
        /// </summary>
        public ShowL7ruleResponse ShowL7rule(ShowL7ruleRequest showL7ruleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , showL7ruleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id" , showL7ruleRequest.L7ruleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7ruleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowL7ruleResponse>(response);
        }
        
        /// <summary>
        /// 查询监听器详情
        /// </summary>
        public ShowListenerResponse ShowListener(ShowListenerRequest showListenerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id" , showListenerRequest.ListenerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners/{listener_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowListenerResponse>(response);
        }
        
        /// <summary>
        /// 查询监听器的标签详情
        /// </summary>
        public ShowListenerTagsResponse ShowListenerTags(ShowListenerTagsRequest showListenerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id" , showListenerTagsRequest.ListenerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/listeners/{listener_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowListenerTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询负载均衡详情
        /// </summary>
        public ShowLoadbalancerResponse ShowLoadbalancer(ShowLoadbalancerRequest showLoadbalancerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , showLoadbalancerRequest.LoadbalancerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers/{loadbalancer_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadbalancerRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowLoadbalancerResponse>(response);
        }
        
        /// <summary>
        /// 查询负载均衡器的标签详情
        /// </summary>
        public ShowLoadbalancerTagsResponse ShowLoadbalancerTags(ShowLoadbalancerTagsRequest showLoadbalancerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , showLoadbalancerTagsRequest.LoadbalancerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/loadbalancers/{loadbalancer_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadbalancerTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowLoadbalancerTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询负载均衡状态树
        /// </summary>
        public ShowLoadbalancersStatusResponse ShowLoadbalancersStatus(ShowLoadbalancersStatusRequest showLoadbalancersStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , showLoadbalancersStatusRequest.LoadbalancerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers/{loadbalancer_id}/statuses",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadbalancersStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowLoadbalancersStatusResponse>(response);
        }
        
        /// <summary>
        /// 查询后端云服务器详情
        /// </summary>
        public ShowMemberResponse ShowMember(ShowMemberRequest showMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , showMemberRequest.PoolId.ToString());
            urlParam.Add("member_id" , showMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowMemberResponse>(response);
        }
        
        /// <summary>
        /// 查询后端云服务器组详情
        /// </summary>
        public ShowPoolResponse ShowPool(ShowPoolRequest showPoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , showPoolRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPoolResponse>(response);
        }
        
        /// <summary>
        /// 查询白名单详情
        /// </summary>
        public ShowWhitelistResponse ShowWhitelist(ShowWhitelistRequest showWhitelistRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("whitelist_id" , showWhitelistRequest.WhitelistId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists/{whitelist_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWhitelistRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowWhitelistResponse>(response);
        }
        
        /// <summary>
        /// 更新健康检查
        /// </summary>
        public UpdateHealthmonitorResponse UpdateHealthmonitor(UpdateHealthmonitorRequest updateHealthmonitorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id" , updateHealthmonitorRequest.HealthmonitorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/healthmonitors/{healthmonitor_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHealthmonitorRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateHealthmonitorResponse>(response);
        }
        
        /// <summary>
        /// 更新转发策略
        /// </summary>
        public UpdateL7policiesResponse UpdateL7policies(UpdateL7policiesRequest updateL7policiesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , updateL7policiesRequest.L7policyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateL7policiesRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateL7policiesResponse>(response);
        }
        
        /// <summary>
        /// 更新转发规则
        /// </summary>
        public UpdateL7ruleResponse UpdateL7rule(UpdateL7ruleRequest updateL7ruleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , updateL7ruleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id" , updateL7ruleRequest.L7ruleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateL7ruleRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateL7ruleResponse>(response);
        }
        
        /// <summary>
        /// 更新监听器
        /// </summary>
        public UpdateListenerResponse UpdateListener(UpdateListenerRequest updateListenerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id" , updateListenerRequest.ListenerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/listeners/{listener_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateListenerRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateListenerResponse>(response);
        }
        
        /// <summary>
        /// 更新负载均衡器
        /// </summary>
        public UpdateLoadbalancerResponse UpdateLoadbalancer(UpdateLoadbalancerRequest updateLoadbalancerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , updateLoadbalancerRequest.LoadbalancerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/loadbalancers/{loadbalancer_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLoadbalancerRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateLoadbalancerResponse>(response);
        }
        
        /// <summary>
        /// 更新后端云服务器
        /// </summary>
        public UpdateMemberResponse UpdateMember(UpdateMemberRequest updateMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("member_id" , updateMemberRequest.MemberId.ToString());
            urlParam.Add("pool_id" , updateMemberRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMemberRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateMemberResponse>(response);
        }
        
        /// <summary>
        /// 更新后端云服务器组
        /// </summary>
        public UpdatePoolResponse UpdatePool(UpdatePoolRequest updatePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , updatePoolRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/pools/{pool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePoolRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePoolResponse>(response);
        }
        
        /// <summary>
        /// 更新白名单
        /// </summary>
        public UpdateWhitelistResponse UpdateWhitelist(UpdateWhitelistRequest updateWhitelistRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("whitelist_id" , updateWhitelistRequest.WhitelistId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/whitelists/{whitelist_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWhitelistRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateWhitelistResponse>(response);
        }
        
        /// <summary>
        /// 创建SSL证书
        /// </summary>
        public CreateCertificateResponse CreateCertificate(CreateCertificateRequest createCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCertificateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateCertificateResponse>(response);
        }
        
        /// <summary>
        /// 删除SSL证书
        /// </summary>
        public DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest deleteCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id" , deleteCertificateRequest.CertificateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates/{certificate_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCertificateRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteCertificateResponse>(response);
        }
        
        /// <summary>
        /// 查询SSL证书列表
        /// </summary>
        public ListCertificatesResponse ListCertificates(ListCertificatesRequest listCertificatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCertificatesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListCertificatesResponse>(response);
        }
        
        /// <summary>
        /// 查询SSL证书详情
        /// </summary>
        public ShowCertificateResponse ShowCertificate(ShowCertificateRequest showCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id" , showCertificateRequest.CertificateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates/{certificate_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowCertificateResponse>(response);
        }
        
        /// <summary>
        /// 更新SSL证书
        /// </summary>
        public UpdateCertificateResponse UpdateCertificate(UpdateCertificateRequest updateCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id" , updateCertificateRequest.CertificateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elb/certificates/{certificate_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCertificateRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateCertificateResponse>(response);
        }
        
    }
}