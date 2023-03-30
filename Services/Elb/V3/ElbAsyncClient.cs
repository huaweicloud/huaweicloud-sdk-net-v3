using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Elb.V3.Model;

namespace HuaweiCloud.SDK.Elb.V3
{
    public partial class ElbAsyncClient : Client
    {
        public static ClientBuilder<ElbAsyncClient> NewBuilder()
        {
            return new ClientBuilder<ElbAsyncClient>();
        }

        
        /// <summary>
        /// 批量创建后端服务器
        ///
        /// 在指定pool下批量创建后端服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateMembersResponse> BatchCreateMembersAsync(BatchCreateMembersRequest batchCreateMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , batchCreateMembersRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-add",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateMembersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchCreateMembersResponse>(response);
        }
        
        /// <summary>
        /// 批量删除后端服务器
        ///
        /// 在指定pool下批量删除后端服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteMembersResponse> BatchDeleteMembersAsync(BatchDeleteMembersRequest batchDeleteMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , batchDeleteMembersRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteMembersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteMembersResponse>(response);
        }
        
        /// <summary>
        /// 批量更新转发策略优先级
        ///
        /// 批量更新转发策略的优先级。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdatePoliciesPriorityResponse> BatchUpdatePoliciesPriorityAsync(BatchUpdatePoliciesPriorityRequest batchUpdatePoliciesPriorityRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/batch-update-priority",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdatePoliciesPriorityRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchUpdatePoliciesPriorityResponse>(response);
        }
        
        /// <summary>
        /// 变更负载均衡器计费模式
        ///
        /// 负载均衡器计费模式变更，当前只支持按需计费转包周期计费。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeLoadbalancerChargeModeResponse> ChangeLoadbalancerChargeModeAsync(ChangeLoadbalancerChargeModeRequest changeLoadbalancerChargeModeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/change-charge-mode",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeLoadbalancerChargeModeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ChangeLoadbalancerChargeModeResponse>(response);
        }
        
        /// <summary>
        /// 创建证书
        ///
        /// 创建证书。用于HTTPS协议监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCertificateResponse> CreateCertificateAsync(CreateCertificateRequest createCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCertificateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateCertificateResponse>(response);
        }
        
        /// <summary>
        /// 创建健康检查
        ///
        /// 创建健康检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateHealthMonitorResponse> CreateHealthMonitorAsync(CreateHealthMonitorRequest createHealthMonitorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createHealthMonitorRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateHealthMonitorResponse>(response);
        }
        
        /// <summary>
        /// 创建转发策略
        ///
        /// 创建七层转发策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateL7PolicyResponse> CreateL7PolicyAsync(CreateL7PolicyRequest createL7PolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createL7PolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateL7PolicyResponse>(response);
        }
        
        /// <summary>
        /// 创建转发规则
        ///
        /// 创建七层转发规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateL7RuleResponse> CreateL7RuleAsync(CreateL7RuleRequest createL7RuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , createL7RuleRequest.L7policyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createL7RuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateL7RuleResponse>(response);
        }
        
        /// <summary>
        /// 创建监听器
        ///
        /// 创建监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateListenerResponse> CreateListenerAsync(CreateListenerRequest createListenerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createListenerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateListenerResponse>(response);
        }
        
        /// <summary>
        /// 创建负载均衡器
        ///
        /// 创建负载均衡器。
        /// 1. 若要创建内网IPv4负载均衡器，则需要设置vip_subnet_cidr_id。
        /// 2. 若要创建公网IPv4负载均衡器，则需要设置publicip，以及设置vpc_id和vip_subnet_cidr_id这两个参数中的一个。
        /// 3. 若要绑定有已有公网IPv4地址，
        /// 则需要设置publicip_ids，以及设置vpc_id和vip_subnet_cidr_id这两个参数中的一个。
        /// 4. 若要创建内网双栈负载均衡器，则需要设置ipv6_vip_virsubnet_id。
        /// 5. 若要创建公网双栈负载均衡器，则需要设置ipv6_vip_virsubnet_id和ipv6_bandwidth。
        /// 6. 不支持绑定已有未使用的内网IPv4、内网IPv6或公网IPv6地址。
        /// 
        /// [&gt; 不支持创建IPv6地址负载均衡器](tag:dt,dt_test)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest createLoadBalancerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLoadBalancerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateLoadBalancerResponse>(response);
        }
        
        /// <summary>
        /// 创建云日志
        ///
        /// 创建云日志。[荷兰region不支持云日志功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLogtankResponse> CreateLogtankAsync(CreateLogtankRequest createLogtankRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLogtankRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateLogtankResponse>(response);
        }
        
        /// <summary>
        /// 创建后端服务器
        ///
        /// 创建后端服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMemberResponse> CreateMemberAsync(CreateMemberRequest createMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , createMemberRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMemberRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateMemberResponse>(response);
        }
        
        /// <summary>
        /// 创建后端服务器组
        ///
        /// 创建后端服务器组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePoolResponse> CreatePoolAsync(CreatePoolRequest createPoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPoolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePoolResponse>(response);
        }
        
        /// <summary>
        /// 创建自定义安全策略
        ///
        /// 创建自定义安全策略。用于在创建HTTPS监听器时，请求参数中指定security_policy_id来设置监听器的自定义安全策略。
        /// 
        /// [荷兰region不支持自定义安全策略功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSecurityPolicyResponse> CreateSecurityPolicyAsync(CreateSecurityPolicyRequest createSecurityPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSecurityPolicyResponse>(response);
        }
        
        /// <summary>
        /// 删除证书
        ///
        /// 删除证书。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest deleteCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id" , deleteCertificateRequest.CertificateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCertificateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteCertificateResponse>(response);
        }
        
        /// <summary>
        /// 删除健康检查
        ///
        /// 删除健康检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteHealthMonitorResponse> DeleteHealthMonitorAsync(DeleteHealthMonitorRequest deleteHealthMonitorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id" , deleteHealthMonitorRequest.HealthmonitorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHealthMonitorRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteHealthMonitorResponse>(response);
        }
        
        /// <summary>
        /// 删除转发策略
        ///
        /// 删除七层转发策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteL7PolicyResponse> DeleteL7PolicyAsync(DeleteL7PolicyRequest deleteL7PolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , deleteL7PolicyRequest.L7policyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7PolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteL7PolicyResponse>(response);
        }
        
        /// <summary>
        /// 删除转发规则
        ///
        /// 删除七层转发规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteL7RuleResponse> DeleteL7RuleAsync(DeleteL7RuleRequest deleteL7RuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , deleteL7RuleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id" , deleteL7RuleRequest.L7ruleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7RuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteL7RuleResponse>(response);
        }
        
        /// <summary>
        /// 删除监听器
        ///
        /// 删除监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteListenerResponse> DeleteListenerAsync(DeleteListenerRequest deleteListenerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id" , deleteListenerRequest.ListenerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteListenerResponse>(response);
        }
        
        /// <summary>
        /// 删除负载均衡器
        ///
        /// 删除负载均衡器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest deleteLoadBalancerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , deleteLoadBalancerRequest.LoadbalancerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadBalancerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteLoadBalancerResponse>(response);
        }
        
        /// <summary>
        /// 删除云日志
        ///
        /// 删除云日志。[荷兰region不支持云日志功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLogtankResponse> DeleteLogtankAsync(DeleteLogtankRequest deleteLogtankRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("logtank_id" , deleteLogtankRequest.LogtankId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogtankRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteLogtankResponse>(response);
        }
        
        /// <summary>
        /// 删除后端服务器
        ///
        /// 删除后端服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteMemberResponse> DeleteMemberAsync(DeleteMemberRequest deleteMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , deleteMemberRequest.PoolId.ToString());
            urlParam.Add("member_id" , deleteMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMemberRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteMemberResponse>(response);
        }
        
        /// <summary>
        /// 删除后端服务器组
        ///
        /// 删除后端服务器组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePoolResponse> DeletePoolAsync(DeletePoolRequest deletePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , deletePoolRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePoolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePoolResponse>(response);
        }
        
        /// <summary>
        /// 删除自定义安全策略
        ///
        /// 删除自定义安全策略。[荷兰region不支持自定义安全策略功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSecurityPolicyResponse> DeleteSecurityPolicyAsync(DeleteSecurityPolicyRequest deleteSecurityPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_policy_id" , deleteSecurityPolicyRequest.SecurityPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecurityPolicyResponse>(response);
        }
        
        /// <summary>
        /// 后端服务器全局列表
        ///
        /// 查询当前租户下的后端服务器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAllMembersResponse> ListAllMembersAsync(ListAllMembersRequest listAllMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllMembersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAllMembersResponse>(response);
        }
        
        /// <summary>
        /// 查询可用区列表
        ///
        /// 返回租户创建LB时可使用的可用区集合列表情况。
        /// 
        /// - 默认情况下，会返回一个可用区集合。
        /// 在（如创建LB）设置可用区时，填写的可用区必须包含在可用区集合中、为这个可用区集合的子集。
        /// 
        /// - 特殊场景下，部分客户要求负载均衡只能创建在指定可用区集合中，此时会返回客户定制的可用区集合。
        /// 返回可用区集合可能为一个也可能为多个，比如列表有两个可用区集合\\[az1,az2\\],\\[az2,az3\\]。
        /// 在创建负载均衡器时，可以选择创建在多个可用区，但所选的多个可用区必须同属于其中一个可用区集合，
        /// 如可以选az2和az3，但不能选择az1和az3。你可以选择多个可用区，只要这些可用区在一个子集中
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAvailabilityZonesResponse> ListAvailabilityZonesAsync(ListAvailabilityZonesRequest listAvailabilityZonesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/availability-zones",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZonesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAvailabilityZonesResponse>(response);
        }
        
        /// <summary>
        /// 查询证书列表
        ///
        /// 查询证书列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCertificatesResponse> ListCertificatesAsync(ListCertificatesRequest listCertificatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCertificatesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListCertificatesResponse>(response);
        }
        
        /// <summary>
        /// 查询规格列表
        ///
        /// 查询租户在当前region下可用的负载均衡规格列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFlavorsResponse> ListFlavorsAsync(ListFlavorsRequest listFlavorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }
        
        /// <summary>
        /// 查询健康检查列表
        ///
        /// 健康检查列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHealthMonitorsResponse> ListHealthMonitorsAsync(ListHealthMonitorsRequest listHealthMonitorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHealthMonitorsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListHealthMonitorsResponse>(response);
        }
        
        /// <summary>
        /// 查询转发策略列表
        ///
        /// 查询七层转发策略列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListL7PoliciesResponse> ListL7PoliciesAsync(ListL7PoliciesRequest listL7PoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7PoliciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListL7PoliciesResponse>(response);
        }
        
        /// <summary>
        /// 查询转发规则列表
        ///
        /// 查询转发规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListL7RulesResponse> ListL7RulesAsync(ListL7RulesRequest listL7RulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , listL7RulesRequest.L7policyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7RulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListL7RulesResponse>(response);
        }
        
        /// <summary>
        /// 查询监听器列表
        ///
        /// 查询监听器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListListenersResponse> ListListenersAsync(ListListenersRequest listListenersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListListenersResponse>(response);
        }
        
        /// <summary>
        /// 查询负载均衡器列表
        ///
        /// 查询负载均衡器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLoadBalancersResponse> ListLoadBalancersAsync(ListLoadBalancersRequest listLoadBalancersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadBalancersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListLoadBalancersResponse>(response);
        }
        
        /// <summary>
        /// 查询云日志列表
        ///
        /// 查询云日志列表。[荷兰region不支持云日志功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLogtanksResponse> ListLogtanksAsync(ListLogtanksRequest listLogtanksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogtanksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListLogtanksResponse>(response);
        }
        
        /// <summary>
        /// 查询后端服务器列表
        ///
        /// Pool下的后端服务器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMembersResponse> ListMembersAsync(ListMembersRequest listMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , listMembersRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMembersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMembersResponse>(response);
        }
        
        /// <summary>
        /// 查询后端服务器组列表
        ///
        /// 后端服务器组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPoolsResponse> ListPoolsAsync(ListPoolsRequest listPoolsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPoolsResponse>(response);
        }
        
        /// <summary>
        /// 查询配额使用详情
        ///
        /// 查询指定项目中负载均衡相关的各类资源的当前配额和已使用配额信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListQuotaDetailsResponse> ListQuotaDetailsAsync(ListQuotaDetailsRequest listQuotaDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/quotas/details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotaDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListQuotaDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询自定义安全策略列表
        ///
        /// 查询自定义安全策略列表。[荷兰region不支持自定义安全策略功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSecurityPoliciesResponse> ListSecurityPoliciesAsync(ListSecurityPoliciesRequest listSecurityPoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityPoliciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSecurityPoliciesResponse>(response);
        }
        
        /// <summary>
        /// 查询系统安全策略列表
        ///
        /// 查询系统安全策略列表。
        /// 
        /// 系统安全策略为预置的所有租户通用的安全策略，租户不可新增或修改。
        /// 
        /// [荷兰region不支持自定义安全策略功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSystemSecurityPoliciesResponse> ListSystemSecurityPoliciesAsync(ListSystemSecurityPoliciesRequest listSystemSecurityPoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/system-security-policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSystemSecurityPoliciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSystemSecurityPoliciesResponse>(response);
        }
        
        /// <summary>
        /// 查询证书详情
        ///
        /// 查询证书详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCertificateResponse> ShowCertificateAsync(ShowCertificateRequest showCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id" , showCertificateRequest.CertificateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCertificateResponse>(response);
        }
        
        /// <summary>
        /// 查询规格详情
        ///
        /// 查询规格的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFlavorResponse> ShowFlavorAsync(ShowFlavorRequest showFlavorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("flavor_id" , showFlavorRequest.FlavorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/flavors/{flavor_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlavorRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowFlavorResponse>(response);
        }
        
        /// <summary>
        /// 查询健康检查详情
        ///
        /// 查询健康检查详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHealthMonitorResponse> ShowHealthMonitorAsync(ShowHealthMonitorRequest showHealthMonitorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id" , showHealthMonitorRequest.HealthmonitorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthMonitorRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowHealthMonitorResponse>(response);
        }
        
        /// <summary>
        /// 查询转发策略详情
        ///
        /// 查询七层转发策略详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowL7PolicyResponse> ShowL7PolicyAsync(ShowL7PolicyRequest showL7PolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , showL7PolicyRequest.L7policyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7PolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowL7PolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询转发规则详情
        ///
        /// 查询七层转发规则详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowL7RuleResponse> ShowL7RuleAsync(ShowL7RuleRequest showL7RuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , showL7RuleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id" , showL7RuleRequest.L7ruleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7RuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowL7RuleResponse>(response);
        }
        
        /// <summary>
        /// 查询监听器详情
        ///
        /// 监听器详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowListenerResponse> ShowListenerAsync(ShowListenerRequest showListenerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id" , showListenerRequest.ListenerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowListenerResponse>(response);
        }
        
        /// <summary>
        /// 查询负载均衡器详情
        ///
        /// 查询负载均衡器详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLoadBalancerResponse> ShowLoadBalancerAsync(ShowLoadBalancerRequest showLoadBalancerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , showLoadBalancerRequest.LoadbalancerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowLoadBalancerResponse>(response);
        }
        
        /// <summary>
        /// 查询负载均衡器状态树
        ///
        /// 查询负载均衡器状态树，包括负载均衡器及其关联的子资源的状态信息。
        /// 注意：该接口中的operating_status不一定与对应资源的operating_status相同。
        /// 如：当Member的admin_state_up&#x3D;false且operating_status&#x3D;OFFLINE时，
        /// 该接口返回member的operating_status&#x3D;DISABLE。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLoadBalancerStatusResponse> ShowLoadBalancerStatusAsync(ShowLoadBalancerStatusRequest showLoadBalancerStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , showLoadBalancerStatusRequest.LoadbalancerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/statuses",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowLoadBalancerStatusResponse>(response);
        }
        
        /// <summary>
        /// 查询云日志详情
        ///
        /// 云日志详情。[荷兰region不支持云日志功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLogtankResponse> ShowLogtankAsync(ShowLogtankRequest showLogtankRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("logtank_id" , showLogtankRequest.LogtankId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogtankRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowLogtankResponse>(response);
        }
        
        /// <summary>
        /// 查询后端服务器详情
        ///
        /// 后端服务器详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMemberResponse> ShowMemberAsync(ShowMemberRequest showMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , showMemberRequest.PoolId.ToString());
            urlParam.Add("member_id" , showMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMemberResponse>(response);
        }
        
        /// <summary>
        /// 查询后端服务器组详情
        ///
        /// 后端服务器组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPoolResponse> ShowPoolAsync(ShowPoolRequest showPoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , showPoolRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPoolResponse>(response);
        }
        
        /// <summary>
        /// 查询配额详情
        ///
        /// 查询指定项目中负载均衡相关的各类资源的当前配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQuotaResponse> ShowQuotaAsync(ShowQuotaRequest showQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotaResponse>(response);
        }
        
        /// <summary>
        /// 查询自定义安全策略详情
        ///
        /// 查询自定义安全策略详情。[荷兰region不支持自定义安全策略功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSecurityPolicyResponse> ShowSecurityPolicyAsync(ShowSecurityPolicyRequest showSecurityPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_policy_id" , showSecurityPolicyRequest.SecurityPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSecurityPolicyResponse>(response);
        }
        
        /// <summary>
        /// 更新证书
        ///
        /// 更新证书。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateCertificateResponse> UpdateCertificateAsync(UpdateCertificateRequest updateCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id" , updateCertificateRequest.CertificateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateCertificateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateCertificateResponse>(response);
        }
        
        /// <summary>
        /// 更新健康检查
        ///
        /// 更新健康检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateHealthMonitorResponse> UpdateHealthMonitorAsync(UpdateHealthMonitorRequest updateHealthMonitorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id" , updateHealthMonitorRequest.HealthmonitorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateHealthMonitorRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateHealthMonitorResponse>(response);
        }
        
        /// <summary>
        /// 更新转发策略
        ///
        /// 更新七层转发策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateL7PolicyResponse> UpdateL7PolicyAsync(UpdateL7PolicyRequest updateL7PolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , updateL7PolicyRequest.L7policyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateL7PolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateL7PolicyResponse>(response);
        }
        
        /// <summary>
        /// 更新转发规则
        ///
        /// 更新七层转发规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateL7RuleResponse> UpdateL7RuleAsync(UpdateL7RuleRequest updateL7RuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , updateL7RuleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id" , updateL7RuleRequest.L7ruleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateL7RuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateL7RuleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id" , updateListenerRequest.ListenerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateListenerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateListenerResponse>(response);
        }
        
        /// <summary>
        /// 更新负载均衡器
        ///
        /// 更新负载均衡器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLoadBalancerResponse> UpdateLoadBalancerAsync(UpdateLoadBalancerRequest updateLoadBalancerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , updateLoadBalancerRequest.LoadbalancerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLoadBalancerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateLoadBalancerResponse>(response);
        }
        
        /// <summary>
        /// 更新云日志
        ///
        /// 更新云日志。[荷兰region不支持云日志功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLogtankResponse> UpdateLogtankAsync(UpdateLogtankRequest updateLogtankRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("logtank_id" , updateLogtankRequest.LogtankId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLogtankRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateLogtankResponse>(response);
        }
        
        /// <summary>
        /// 更新后端服务器
        ///
        /// 更新后端服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMemberResponse> UpdateMemberAsync(UpdateMemberRequest updateMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("member_id" , updateMemberRequest.MemberId.ToString());
            urlParam.Add("pool_id" , updateMemberRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMemberRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateMemberResponse>(response);
        }
        
        /// <summary>
        /// 更新后端服务器组
        ///
        /// 更新后端服务器组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePoolResponse> UpdatePoolAsync(UpdatePoolRequest updatePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , updatePoolRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePoolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePoolResponse>(response);
        }
        
        /// <summary>
        /// 更新自定义安全策略
        ///
        /// 更新自定义安全策略。[荷兰region不支持自定义安全策略功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSecurityPolicyResponse> UpdateSecurityPolicyAsync(UpdateSecurityPolicyRequest updateSecurityPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_policy_id" , updateSecurityPolicyRequest.SecurityPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecurityPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSecurityPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询API版本列表信息
        ///
        /// 返回ELB当前所有可用的API版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApiVersionsResponse> ListApiVersionsAsync(ListApiVersionsRequest listApiVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/versions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }
        
        /// <summary>
        /// 删除IP地址组的IP列表项
        ///
        /// 批量删除IP地址组的IP列表信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteIpListResponse> BatchDeleteIpListAsync(BatchDeleteIpListRequest batchDeleteIpListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id" , batchDeleteIpListRequest.IpgroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/iplist/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteIpListRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteIpListResponse>(response);
        }
        
        /// <summary>
        /// 计算预占IP数
        ///
        /// 计算以下几种场景的预占用IP数量：
        /// 
        /// - 计算创建LB的第一个七层监听器后总占用IP数量：
        /// 传入loadbalancer_id、l7_flavor_id为空、ip_target_enable不传或为false。
        /// 
        /// - 计算LB规格变更或开启跨VPC后总占用IP数量：
        /// 传入参数loadbalancer_id，及l7_flavor_id不为空或ip_target_enable为true。
        /// 
        /// - 计算创建LB所需IP数量：传入参数availability_zone_id，
        /// 及可选参数l7_flavor_id、ip_target_enable、ip_version，不能传loadbalancer_id。
        /// 
        /// 说明：
        /// - 计算出来的预占IP数大于等于最终实际占用的IP数。
        /// - 总占用IP数量，即整个LB所占用的IP数量。
        /// 
        /// [不支持传入l7_flavor_id](tag:fcs)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountPreoccupyIpNumResponse> CountPreoccupyIpNumAsync(CountPreoccupyIpNumRequest countPreoccupyIpNumRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/preoccupy-ip-num",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", countPreoccupyIpNumRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<CountPreoccupyIpNumResponse>(response);
        }
        
        /// <summary>
        /// 创建IP地址组
        ///
        /// 创建IP地址组。输入的ip可为ip地址或者CIDR子网，支持IPV4和IPV6。
        /// 
        /// 需要注意0.0.0.0与0.0.0.0/32视为重复，0:0:0:0:0:0:0:1与::1与::1/128视为重复，只会保存其中一个。
        /// 
        /// [荷兰region不支持IP地址组功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateIpGroupResponse> CreateIpGroupAsync(CreateIpGroupRequest createIpGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createIpGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateIpGroupResponse>(response);
        }
        
        /// <summary>
        /// 删除IP地址组
        ///
        /// 删除ip地址组。[荷兰region不支持IP地址组功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteIpGroupResponse> DeleteIpGroupAsync(DeleteIpGroupRequest deleteIpGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id" , deleteIpGroupRequest.IpgroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteIpGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询IP地址组列表
        ///
        /// 查询IP地址组列表。[荷兰region不支持IP地址组功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListIpGroupsResponse> ListIpGroupsAsync(ListIpGroupsRequest listIpGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListIpGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查询IP地址组详情
        ///
        /// 获取IP地址组详情。[荷兰region不支持IP地址组功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowIpGroupResponse> ShowIpGroupAsync(ShowIpGroupRequest showIpGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id" , showIpGroupRequest.IpgroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowIpGroupResponse>(response);
        }
        
        /// <summary>
        /// 更新IP地址组
        ///
        /// 更新IP地址组，只支持全量更新IP。即IP地址组中的ip_list将被全量覆盖，不在请求参数中的IP地址将被移除。
        /// 输入的ip可为ip地址或者CIDR子网，支持IPV4和IPV6。
        /// 
        /// 需要注意0.0.0.0与0.0.0.0/32视为重复，0:0:0:0:0:0:0:1与::1与::1/128视为重复，只会保存其中一个。
        /// 
        /// [荷兰region不支持IP地址组功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateIpGroupResponse> UpdateIpGroupAsync(UpdateIpGroupRequest updateIpGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id" , updateIpGroupRequest.IpgroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateIpGroupResponse>(response);
        }
        
        /// <summary>
        /// 更新IP地址组的IP列表项
        ///
        /// 更新IP地址组的IP列表信息。[荷兰region不支持该API](tag:dt,dt_test)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateIpListResponse> UpdateIpListAsync(UpdateIpListRequest updateIpListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id" , updateIpListRequest.IpgroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/iplist/create-or-update",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpListRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpdateIpListResponse>(response);
        }
        
    }
}