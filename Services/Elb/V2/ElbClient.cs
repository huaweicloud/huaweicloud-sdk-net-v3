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
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 批量添加负载均衡器标签。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 批量删除监听器标签。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 批量删除负载均衡器标签。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 给后端云服务器组添加健康检查
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 创建listener关联的转发策略
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 创建转发规则
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 创建与负载均衡器绑定的监听器。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 给指定监听器添加标签。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 创建私网类型的增强型负载均衡器。创建成功后，该接口会返回创建的增强型负载均衡器的ID、所属子网ID、负载均衡器IP等详细信息。若要创建公网类型的增强型负载均衡器，还需调用创建浮动IP的接口，将浮动IP与私网负载均衡器的vip_port_id绑定。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 给指定负载均衡器添加标签。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 添加属于某个后端云服务器组的后端云服务器。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 创建后端云服务器组。将多个后端云服务器添加到后端云服务器组中后，请求会在后端云服务器间按后端云服务器组的负载均衡算法和后端云服务器的权重来做请求分发。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 创建白名单，控制监听器的访问权限。若开启了白名单功能，只有白名单中放通的IP可以访问该监听器的后端服务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 删除健康检查
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 删除转发策略
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 删除转发规则
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 根据指定ID删除监听器。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 删除监听器的某个key对应的标签。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 根据指定ID删除负载均衡器。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 删除负载均衡器的某个key对应的标签。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 删除后端云服务器
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 删除后端云服务器组。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 删除白名单
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 查询健康检查列表
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 查询转发策略。支持过滤查询和分页查询。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 查询指定转发策略下关联的转发规则列表
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 查询指定项目下所有监听器的标签列表
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 查询监听器列表。支持过滤查询和分页查询。可以通过监听器ID、协议类型、监听端口号、关联的后端云服务器的IP等查询监听器。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 根据标签过滤查询监听器实例。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 查询指定项目下所有负载均衡器的标签列表
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 查询负载均衡器列表。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 根据标签过滤查询负载均衡实例。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 查询属于某个后端云服务器组的后端云服务器。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 查询后端云服务器组列表。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 查询白名单，支持过滤查询和分页查询。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 根据指定ID查询健康检查详情。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 根据指定ID查询转发策略详情。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 根据指定ID查询某转发策略下关联的转发规则详情。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 根据指定ID查询监听器详情。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 查询指定监听器的所有标签信息。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 根据指定负载均衡器ID查询负载均衡器详情
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 查询指定负载均衡器的所有标签信息
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 查询负载均衡器状态树。可通过该接口查询负载均衡器关联的监听器、后端云服务器组、后端云服务器、健康检查、转发策略、转发规则的主要信息，了解负载均衡器下资源的拓扑情况。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 根据指定ID查询后端云服务器详情。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 根据指定ID查询后端云服务器组详情。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 根据指定ID查询白名单详情。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 更新健康检查
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 更新转发策略
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 更新指定的转发规则
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 更新监听器。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 更新负载均衡器。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 更新后端云服务器
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 更新后端云服务器组。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 更新白名单。可以打开或关闭白名单，或更新访问控制的IP。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 创建SSL证书。将监听器和SSL证书绑定后，可以通过负载均衡器实现服务端认证，后端服务器只要提供HTTP服务就能实现安全可靠的连接。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 删除指定的SSL证书
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 查询SSL证书。支持过滤查询和分页查询。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 查询指定SSL证书的详情信息。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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
        ///
        /// 更新指定的SSL证书
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
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