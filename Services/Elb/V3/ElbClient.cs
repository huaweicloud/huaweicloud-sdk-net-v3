using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Elb.V3.Model;

namespace HuaweiCloud.SDK.Elb.V3
{
    public partial class ElbClient : Client
    {
        public static ClientBuilder<ElbClient> NewBuilder()
        {
            return new ClientBuilder<ElbClient>();
        }

        
        /// <summary>
        /// 新增负载均衡器可用区
        ///
        /// 给负载均衡器新增可用区。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchAddAvailableZonesResponse BatchAddAvailableZones(BatchAddAvailableZonesRequest batchAddAvailableZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", batchAddAvailableZonesRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/availability-zone/batch-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddAvailableZonesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchAddAvailableZonesResponse>(response);
        }

        public SyncInvoker<BatchAddAvailableZonesResponse> BatchAddAvailableZonesInvoker(BatchAddAvailableZonesRequest batchAddAvailableZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", batchAddAvailableZonesRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/availability-zone/batch-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddAvailableZonesRequest);
            return new SyncInvoker<BatchAddAvailableZonesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAddAvailableZonesResponse>);
        }
        
        /// <summary>
        /// 批量创建后端服务器
        ///
        /// 在指定pool下批量创建后端服务器。一次最多创建200个。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateMembersResponse BatchCreateMembers(BatchCreateMembersRequest batchCreateMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", batchCreateMembersRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateMembersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateMembersResponse>(response);
        }

        public SyncInvoker<BatchCreateMembersResponse> BatchCreateMembersInvoker(BatchCreateMembersRequest batchCreateMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", batchCreateMembersRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateMembersRequest);
            return new SyncInvoker<BatchCreateMembersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateMembersResponse>);
        }
        
        /// <summary>
        /// 批量删除后端服务器
        ///
        /// 在指定pool下批量删除后端服务器。一次最多添加200个。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteMembersResponse BatchDeleteMembers(BatchDeleteMembersRequest batchDeleteMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", batchDeleteMembersRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteMembersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteMembersResponse>(response);
        }

        public SyncInvoker<BatchDeleteMembersResponse> BatchDeleteMembersInvoker(BatchDeleteMembersRequest batchDeleteMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", batchDeleteMembersRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteMembersRequest);
            return new SyncInvoker<BatchDeleteMembersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteMembersResponse>);
        }
        
        /// <summary>
        /// 移除负载均衡器可用区
        ///
        /// 移除负载均衡器的可用区。
        /// &gt; 移除可用区可能导致已有链接断开，请谨慎操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchRemoveAvailableZonesResponse BatchRemoveAvailableZones(BatchRemoveAvailableZonesRequest batchRemoveAvailableZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", batchRemoveAvailableZonesRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/availability-zone/batch-remove", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRemoveAvailableZonesRequest);
            var response = DoHttpRequestSync("POST", request);
            return XmlUtils.DeSerialize<BatchRemoveAvailableZonesResponse>(response);
        }

        public SyncInvoker<BatchRemoveAvailableZonesResponse> BatchRemoveAvailableZonesInvoker(BatchRemoveAvailableZonesRequest batchRemoveAvailableZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", batchRemoveAvailableZonesRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/availability-zone/batch-remove", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRemoveAvailableZonesRequest);
            return new SyncInvoker<BatchRemoveAvailableZonesResponse>(this, "POST", request, XmlUtils.DeSerialize<BatchRemoveAvailableZonesResponse>);
        }
        
        /// <summary>
        /// 批量更新后端服务器
        ///
        /// 在指定pool下批量更新后端服务器。一次最多添加200个。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateMembersResponse BatchUpdateMembers(BatchUpdateMembersRequest batchUpdateMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", batchUpdateMembersRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateMembersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchUpdateMembersResponse>(response);
        }

        public SyncInvoker<BatchUpdateMembersResponse> BatchUpdateMembersInvoker(BatchUpdateMembersRequest batchUpdateMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", batchUpdateMembersRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateMembersRequest);
            return new SyncInvoker<BatchUpdateMembersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchUpdateMembersResponse>);
        }
        
        /// <summary>
        /// 批量更新转发策略优先级
        ///
        /// 批量更新转发策略的优先级。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdatePoliciesPriorityResponse BatchUpdatePoliciesPriority(BatchUpdatePoliciesPriorityRequest batchUpdatePoliciesPriorityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/batch-update-priority", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdatePoliciesPriorityRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchUpdatePoliciesPriorityResponse>(response);
        }

        public SyncInvoker<BatchUpdatePoliciesPriorityResponse> BatchUpdatePoliciesPriorityInvoker(BatchUpdatePoliciesPriorityRequest batchUpdatePoliciesPriorityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/batch-update-priority", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdatePoliciesPriorityRequest);
            return new SyncInvoker<BatchUpdatePoliciesPriorityResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchUpdatePoliciesPriorityResponse>);
        }
        
        /// <summary>
        /// 变更负载均衡器计费模式
        ///
        /// 负载均衡器计费模式变更，当前支持的计费模式变更为：
        /// 1. 按需计费转包周期计费；
        /// 2. 按需按规格计费转按需按使用量计费；
        /// 3. 按需按使用量计费转按需按规格计费；
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeLoadbalancerChargeModeResponse ChangeLoadbalancerChargeMode(ChangeLoadbalancerChargeModeRequest changeLoadbalancerChargeModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/change-charge-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeLoadbalancerChargeModeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeLoadbalancerChargeModeResponse>(response);
        }

        public SyncInvoker<ChangeLoadbalancerChargeModeResponse> ChangeLoadbalancerChargeModeInvoker(ChangeLoadbalancerChargeModeRequest changeLoadbalancerChargeModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/change-charge-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeLoadbalancerChargeModeRequest);
            return new SyncInvoker<ChangeLoadbalancerChargeModeResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeLoadbalancerChargeModeResponse>);
        }
        
        /// <summary>
        /// 创建证书
        ///
        /// 创建证书。用于HTTPS协议监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCertificateResponse CreateCertificate(CreateCertificateRequest createCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCertificateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCertificateResponse>(response);
        }

        public SyncInvoker<CreateCertificateResponse> CreateCertificateInvoker(CreateCertificateRequest createCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCertificateRequest);
            return new SyncInvoker<CreateCertificateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCertificateResponse>);
        }
        
        /// <summary>
        /// 创建健康检查
        ///
        /// 创建健康检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateHealthMonitorResponse CreateHealthMonitor(CreateHealthMonitorRequest createHealthMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createHealthMonitorRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateHealthMonitorResponse>(response);
        }

        public SyncInvoker<CreateHealthMonitorResponse> CreateHealthMonitorInvoker(CreateHealthMonitorRequest createHealthMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createHealthMonitorRequest);
            return new SyncInvoker<CreateHealthMonitorResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHealthMonitorResponse>);
        }
        
        /// <summary>
        /// 创建转发策略
        ///
        /// 创建七层转发策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateL7PolicyResponse CreateL7Policy(CreateL7PolicyRequest createL7PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createL7PolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateL7PolicyResponse>(response);
        }

        public SyncInvoker<CreateL7PolicyResponse> CreateL7PolicyInvoker(CreateL7PolicyRequest createL7PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createL7PolicyRequest);
            return new SyncInvoker<CreateL7PolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateL7PolicyResponse>);
        }
        
        /// <summary>
        /// 创建转发规则
        ///
        /// 创建七层转发规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateL7RuleResponse CreateL7Rule(CreateL7RuleRequest createL7RuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", createL7RuleRequest.L7policyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createL7RuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateL7RuleResponse>(response);
        }

        public SyncInvoker<CreateL7RuleResponse> CreateL7RuleInvoker(CreateL7RuleRequest createL7RuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", createL7RuleRequest.L7policyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createL7RuleRequest);
            return new SyncInvoker<CreateL7RuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateL7RuleResponse>);
        }
        
        /// <summary>
        /// 创建监听器
        ///
        /// 创建监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateListenerResponse CreateListener(CreateListenerRequest createListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createListenerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateListenerResponse>(response);
        }

        public SyncInvoker<CreateListenerResponse> CreateListenerInvoker(CreateListenerRequest createListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createListenerRequest);
            return new SyncInvoker<CreateListenerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateListenerResponse>);
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
        /// [&gt; 关于计费：
        /// - 若billing_info非空时，包周期。
        /// - 若billing_info为空，autoscaling.enable&#x3D;true时，弹性计费。
        /// - 若billing_info为空，autoscaling.enable&#x3D;false或未设置，charge_mode&#x3D;lcu，按量计费。
        /// - 若billing_info为空，autoscaling.enable&#x3D;false或未设置，charge_mode&#x3D;flavor，固定规格按需计费。](tag:hws)
        /// [&gt; 不支持创建IPv6地址负载均衡器](tag:dt,dt_test)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest createLoadBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLoadBalancerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateLoadBalancerResponse>(response);
        }

        public SyncInvoker<CreateLoadBalancerResponse> CreateLoadBalancerInvoker(CreateLoadBalancerRequest createLoadBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLoadBalancerRequest);
            return new SyncInvoker<CreateLoadBalancerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLoadBalancerResponse>);
        }
        
        /// <summary>
        /// 创建云日志
        ///
        /// 创建云日志。[荷兰region不支持云日志功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateLogtankResponse CreateLogtank(CreateLogtankRequest createLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLogtankRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateLogtankResponse>(response);
        }

        public SyncInvoker<CreateLogtankResponse> CreateLogtankInvoker(CreateLogtankRequest createLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLogtankRequest);
            return new SyncInvoker<CreateLogtankResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLogtankResponse>);
        }
        
        /// <summary>
        /// 创建主备后端服务器组
        ///
        /// 创建主备后端服务器组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMasterSlavePoolResponse CreateMasterSlavePool(CreateMasterSlavePoolRequest createMasterSlavePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/master-slave-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMasterSlavePoolRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMasterSlavePoolResponse>(response);
        }

        public SyncInvoker<CreateMasterSlavePoolResponse> CreateMasterSlavePoolInvoker(CreateMasterSlavePoolRequest createMasterSlavePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/master-slave-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMasterSlavePoolRequest);
            return new SyncInvoker<CreateMasterSlavePoolResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMasterSlavePoolResponse>);
        }
        
        /// <summary>
        /// 创建后端服务器
        ///
        /// 创建后端服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMemberResponse CreateMember(CreateMemberRequest createMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", createMemberRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMemberRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMemberResponse>(response);
        }

        public SyncInvoker<CreateMemberResponse> CreateMemberInvoker(CreateMemberRequest createMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", createMemberRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMemberRequest);
            return new SyncInvoker<CreateMemberResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMemberResponse>);
        }
        
        /// <summary>
        /// 创建后端服务器组
        ///
        /// 创建后端服务器组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePoolResponse CreatePool(CreatePoolRequest createPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPoolRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePoolResponse>(response);
        }

        public SyncInvoker<CreatePoolResponse> CreatePoolInvoker(CreatePoolRequest createPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPoolRequest);
            return new SyncInvoker<CreatePoolResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePoolResponse>);
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
        public CreateSecurityPolicyResponse CreateSecurityPolicy(CreateSecurityPolicyRequest createSecurityPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSecurityPolicyResponse>(response);
        }

        public SyncInvoker<CreateSecurityPolicyResponse> CreateSecurityPolicyInvoker(CreateSecurityPolicyRequest createSecurityPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityPolicyRequest);
            return new SyncInvoker<CreateSecurityPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSecurityPolicyResponse>);
        }
        
        /// <summary>
        /// 删除证书
        ///
        /// 删除证书。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest deleteCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id", deleteCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCertificateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCertificateResponse>(response);
        }

        public SyncInvoker<DeleteCertificateResponse> DeleteCertificateInvoker(DeleteCertificateRequest deleteCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id", deleteCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCertificateRequest);
            return new SyncInvoker<DeleteCertificateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCertificateResponse>);
        }
        
        /// <summary>
        /// 删除健康检查
        ///
        /// 删除健康检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteHealthMonitorResponse DeleteHealthMonitor(DeleteHealthMonitorRequest deleteHealthMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id", deleteHealthMonitorRequest.HealthmonitorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHealthMonitorRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteHealthMonitorResponse>(response);
        }

        public SyncInvoker<DeleteHealthMonitorResponse> DeleteHealthMonitorInvoker(DeleteHealthMonitorRequest deleteHealthMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id", deleteHealthMonitorRequest.HealthmonitorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHealthMonitorRequest);
            return new SyncInvoker<DeleteHealthMonitorResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteHealthMonitorResponse>);
        }
        
        /// <summary>
        /// 删除转发策略
        ///
        /// 删除七层转发策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteL7PolicyResponse DeleteL7Policy(DeleteL7PolicyRequest deleteL7PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", deleteL7PolicyRequest.L7policyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7PolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteL7PolicyResponse>(response);
        }

        public SyncInvoker<DeleteL7PolicyResponse> DeleteL7PolicyInvoker(DeleteL7PolicyRequest deleteL7PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", deleteL7PolicyRequest.L7policyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7PolicyRequest);
            return new SyncInvoker<DeleteL7PolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteL7PolicyResponse>);
        }
        
        /// <summary>
        /// 删除转发规则
        ///
        /// 删除七层转发规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteL7RuleResponse DeleteL7Rule(DeleteL7RuleRequest deleteL7RuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", deleteL7RuleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id", deleteL7RuleRequest.L7ruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7RuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteL7RuleResponse>(response);
        }

        public SyncInvoker<DeleteL7RuleResponse> DeleteL7RuleInvoker(DeleteL7RuleRequest deleteL7RuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", deleteL7RuleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id", deleteL7RuleRequest.L7ruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7RuleRequest);
            return new SyncInvoker<DeleteL7RuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteL7RuleResponse>);
        }
        
        /// <summary>
        /// 删除监听器
        ///
        /// 删除监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteListenerResponse DeleteListener(DeleteListenerRequest deleteListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", deleteListenerRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteListenerResponse>(response);
        }

        public SyncInvoker<DeleteListenerResponse> DeleteListenerInvoker(DeleteListenerRequest deleteListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", deleteListenerRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerRequest);
            return new SyncInvoker<DeleteListenerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteListenerResponse>);
        }
        
        /// <summary>
        /// 级联删除监听器
        ///
        /// 删除监听器且级联删除其下子资源（删除监听器、转发策略等，解绑后端服务器组）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteListenerForceResponse DeleteListenerForce(DeleteListenerForceRequest deleteListenerForceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", deleteListenerForceRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}/force", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerForceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteListenerForceResponse>(response);
        }

        public SyncInvoker<DeleteListenerForceResponse> DeleteListenerForceInvoker(DeleteListenerForceRequest deleteListenerForceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", deleteListenerForceRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}/force", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerForceRequest);
            return new SyncInvoker<DeleteListenerForceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteListenerForceResponse>);
        }
        
        /// <summary>
        /// 删除负载均衡器
        ///
        /// 删除负载均衡器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest deleteLoadBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", deleteLoadBalancerRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadBalancerRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLoadBalancerResponse>(response);
        }

        public SyncInvoker<DeleteLoadBalancerResponse> DeleteLoadBalancerInvoker(DeleteLoadBalancerRequest deleteLoadBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", deleteLoadBalancerRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadBalancerRequest);
            return new SyncInvoker<DeleteLoadBalancerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLoadBalancerResponse>);
        }
        
        /// <summary>
        /// 级联删除负载均衡器
        ///
        /// 删除负载均衡器且级联删除其下子资源（删除负载均衡器及其绑定的监听器、后端服务器组、后端服务器等一系列资源）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLoadBalancerForceResponse DeleteLoadBalancerForce(DeleteLoadBalancerForceRequest deleteLoadBalancerForceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", deleteLoadBalancerForceRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/force-elb", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadBalancerForceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLoadBalancerForceResponse>(response);
        }

        public SyncInvoker<DeleteLoadBalancerForceResponse> DeleteLoadBalancerForceInvoker(DeleteLoadBalancerForceRequest deleteLoadBalancerForceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", deleteLoadBalancerForceRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/force-elb", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadBalancerForceRequest);
            return new SyncInvoker<DeleteLoadBalancerForceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLoadBalancerForceResponse>);
        }
        
        /// <summary>
        /// 删除云日志
        ///
        /// 删除云日志。[荷兰region不支持云日志功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLogtankResponse DeleteLogtank(DeleteLogtankRequest deleteLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("logtank_id", deleteLogtankRequest.LogtankId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogtankRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLogtankResponse>(response);
        }

        public SyncInvoker<DeleteLogtankResponse> DeleteLogtankInvoker(DeleteLogtankRequest deleteLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("logtank_id", deleteLogtankRequest.LogtankId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogtankRequest);
            return new SyncInvoker<DeleteLogtankResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLogtankResponse>);
        }
        
        /// <summary>
        /// 删除主备后端服务器组
        ///
        /// 删除主备后端服务器组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteMasterSlavePoolResponse DeleteMasterSlavePool(DeleteMasterSlavePoolRequest deleteMasterSlavePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", deleteMasterSlavePoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/master-slave-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMasterSlavePoolRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMasterSlavePoolResponse>(response);
        }

        public SyncInvoker<DeleteMasterSlavePoolResponse> DeleteMasterSlavePoolInvoker(DeleteMasterSlavePoolRequest deleteMasterSlavePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", deleteMasterSlavePoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/master-slave-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMasterSlavePoolRequest);
            return new SyncInvoker<DeleteMasterSlavePoolResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMasterSlavePoolResponse>);
        }
        
        /// <summary>
        /// 删除后端服务器
        ///
        /// 删除后端服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteMemberResponse DeleteMember(DeleteMemberRequest deleteMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", deleteMemberRequest.PoolId.ToString());
            urlParam.Add("member_id", deleteMemberRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMemberRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMemberResponse>(response);
        }

        public SyncInvoker<DeleteMemberResponse> DeleteMemberInvoker(DeleteMemberRequest deleteMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", deleteMemberRequest.PoolId.ToString());
            urlParam.Add("member_id", deleteMemberRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMemberRequest);
            return new SyncInvoker<DeleteMemberResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMemberResponse>);
        }
        
        /// <summary>
        /// 删除后端服务器组
        ///
        /// 删除后端服务器组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePoolResponse DeletePool(DeletePoolRequest deletePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", deletePoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePoolRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePoolResponse>(response);
        }

        public SyncInvoker<DeletePoolResponse> DeletePoolInvoker(DeletePoolRequest deletePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", deletePoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePoolRequest);
            return new SyncInvoker<DeletePoolResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePoolResponse>);
        }
        
        /// <summary>
        /// 删除自定义安全策略
        ///
        /// 删除自定义安全策略。[荷兰region不支持自定义安全策略功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSecurityPolicyResponse DeleteSecurityPolicy(DeleteSecurityPolicyRequest deleteSecurityPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_policy_id", deleteSecurityPolicyRequest.SecurityPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityPolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecurityPolicyResponse>(response);
        }

        public SyncInvoker<DeleteSecurityPolicyResponse> DeleteSecurityPolicyInvoker(DeleteSecurityPolicyRequest deleteSecurityPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_policy_id", deleteSecurityPolicyRequest.SecurityPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityPolicyRequest);
            return new SyncInvoker<DeleteSecurityPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecurityPolicyResponse>);
        }
        
        /// <summary>
        /// 后端服务器全局列表
        ///
        /// 查询当前租户下的后端服务器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllMembersResponse ListAllMembers(ListAllMembersRequest listAllMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllMembersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAllMembersResponse>(response);
        }

        public SyncInvoker<ListAllMembersResponse> ListAllMembersInvoker(ListAllMembersRequest listAllMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllMembersRequest);
            return new SyncInvoker<ListAllMembersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllMembersResponse>);
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
        public ListAvailabilityZonesResponse ListAvailabilityZones(ListAvailabilityZonesRequest listAvailabilityZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/availability-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZonesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAvailabilityZonesResponse>(response);
        }

        public SyncInvoker<ListAvailabilityZonesResponse> ListAvailabilityZonesInvoker(ListAvailabilityZonesRequest listAvailabilityZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/availability-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZonesRequest);
            return new SyncInvoker<ListAvailabilityZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailabilityZonesResponse>);
        }
        
        /// <summary>
        /// 查询证书列表
        ///
        /// 查询证书列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCertificatesResponse ListCertificates(ListCertificatesRequest listCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCertificatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCertificatesResponse>(response);
        }

        public SyncInvoker<ListCertificatesResponse> ListCertificatesInvoker(ListCertificatesRequest listCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCertificatesRequest);
            return new SyncInvoker<ListCertificatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCertificatesResponse>);
        }
        
        /// <summary>
        /// 查询规格列表
        ///
        /// 查询租户在当前region下可用的负载均衡规格列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFlavorsResponse ListFlavors(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }

        public SyncInvoker<ListFlavorsResponse> ListFlavorsInvoker(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            return new SyncInvoker<ListFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorsResponse>);
        }
        
        /// <summary>
        /// 查询健康检查列表
        ///
        /// 健康检查列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHealthMonitorsResponse ListHealthMonitors(ListHealthMonitorsRequest listHealthMonitorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHealthMonitorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHealthMonitorsResponse>(response);
        }

        public SyncInvoker<ListHealthMonitorsResponse> ListHealthMonitorsInvoker(ListHealthMonitorsRequest listHealthMonitorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHealthMonitorsRequest);
            return new SyncInvoker<ListHealthMonitorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHealthMonitorsResponse>);
        }
        
        /// <summary>
        /// 查询转发策略列表
        ///
        /// 查询七层转发策略列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListL7PoliciesResponse ListL7Policies(ListL7PoliciesRequest listL7PoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7PoliciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListL7PoliciesResponse>(response);
        }

        public SyncInvoker<ListL7PoliciesResponse> ListL7PoliciesInvoker(ListL7PoliciesRequest listL7PoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7PoliciesRequest);
            return new SyncInvoker<ListL7PoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListL7PoliciesResponse>);
        }
        
        /// <summary>
        /// 查询转发规则列表
        ///
        /// 查询转发规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListL7RulesResponse ListL7Rules(ListL7RulesRequest listL7RulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", listL7RulesRequest.L7policyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7RulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListL7RulesResponse>(response);
        }

        public SyncInvoker<ListL7RulesResponse> ListL7RulesInvoker(ListL7RulesRequest listL7RulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", listL7RulesRequest.L7policyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7RulesRequest);
            return new SyncInvoker<ListL7RulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListL7RulesResponse>);
        }
        
        /// <summary>
        /// 查询监听器列表
        ///
        /// 查询监听器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListListenersResponse ListListeners(ListListenersRequest listListenersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListListenersResponse>(response);
        }

        public SyncInvoker<ListListenersResponse> ListListenersInvoker(ListListenersRequest listListenersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersRequest);
            return new SyncInvoker<ListListenersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListListenersResponse>);
        }
        
        /// <summary>
        /// 查询负载均衡器列表
        ///
        /// 查询负载均衡器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLoadBalancersResponse ListLoadBalancers(ListLoadBalancersRequest listLoadBalancersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadBalancersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLoadBalancersResponse>(response);
        }

        public SyncInvoker<ListLoadBalancersResponse> ListLoadBalancersInvoker(ListLoadBalancersRequest listLoadBalancersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadBalancersRequest);
            return new SyncInvoker<ListLoadBalancersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLoadBalancersResponse>);
        }
        
        /// <summary>
        /// 查询云日志列表
        ///
        /// 查询云日志列表。[荷兰region不支持云日志功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLogtanksResponse ListLogtanks(ListLogtanksRequest listLogtanksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogtanksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLogtanksResponse>(response);
        }

        public SyncInvoker<ListLogtanksResponse> ListLogtanksInvoker(ListLogtanksRequest listLogtanksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogtanksRequest);
            return new SyncInvoker<ListLogtanksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLogtanksResponse>);
        }
        
        /// <summary>
        /// 查询主备后端服务器组列表
        ///
        /// 主备后端服务器组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMasterSlavePoolsResponse ListMasterSlavePools(ListMasterSlavePoolsRequest listMasterSlavePoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/master-slave-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMasterSlavePoolsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMasterSlavePoolsResponse>(response);
        }

        public SyncInvoker<ListMasterSlavePoolsResponse> ListMasterSlavePoolsInvoker(ListMasterSlavePoolsRequest listMasterSlavePoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/master-slave-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMasterSlavePoolsRequest);
            return new SyncInvoker<ListMasterSlavePoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMasterSlavePoolsResponse>);
        }
        
        /// <summary>
        /// 查询后端服务器列表
        ///
        /// Pool下的后端服务器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMembersResponse ListMembers(ListMembersRequest listMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", listMembersRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMembersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMembersResponse>(response);
        }

        public SyncInvoker<ListMembersResponse> ListMembersInvoker(ListMembersRequest listMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", listMembersRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMembersRequest);
            return new SyncInvoker<ListMembersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMembersResponse>);
        }
        
        /// <summary>
        /// 查询后端服务器组列表
        ///
        /// 后端服务器组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPoolsResponse ListPools(ListPoolsRequest listPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPoolsResponse>(response);
        }

        public SyncInvoker<ListPoolsResponse> ListPoolsInvoker(ListPoolsRequest listPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolsRequest);
            return new SyncInvoker<ListPoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPoolsResponse>);
        }
        
        /// <summary>
        /// 查询配额使用详情
        ///
        /// 查询指定项目中负载均衡相关的各类资源的当前配额和已使用配额信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListQuotaDetailsResponse ListQuotaDetails(ListQuotaDetailsRequest listQuotaDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/quotas/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotaDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListQuotaDetailsResponse>(response);
        }

        public SyncInvoker<ListQuotaDetailsResponse> ListQuotaDetailsInvoker(ListQuotaDetailsRequest listQuotaDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/quotas/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotaDetailsRequest);
            return new SyncInvoker<ListQuotaDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQuotaDetailsResponse>);
        }
        
        /// <summary>
        /// 查询自定义安全策略列表
        ///
        /// 查询自定义安全策略列表。[荷兰region不支持自定义安全策略功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSecurityPoliciesResponse ListSecurityPolicies(ListSecurityPoliciesRequest listSecurityPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityPoliciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSecurityPoliciesResponse>(response);
        }

        public SyncInvoker<ListSecurityPoliciesResponse> ListSecurityPoliciesInvoker(ListSecurityPoliciesRequest listSecurityPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityPoliciesRequest);
            return new SyncInvoker<ListSecurityPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecurityPoliciesResponse>);
        }
        
        /// <summary>
        /// 查询系统安全策略列表
        ///
        /// 查询系统安全策略列表。
        /// 
        /// 系统安全策略为预置的所有租户通用的安全策略，租户不可新增或修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSystemSecurityPoliciesResponse ListSystemSecurityPolicies(ListSystemSecurityPoliciesRequest listSystemSecurityPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/system-security-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSystemSecurityPoliciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSystemSecurityPoliciesResponse>(response);
        }

        public SyncInvoker<ListSystemSecurityPoliciesResponse> ListSystemSecurityPoliciesInvoker(ListSystemSecurityPoliciesRequest listSystemSecurityPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/system-security-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSystemSecurityPoliciesRequest);
            return new SyncInvoker<ListSystemSecurityPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSystemSecurityPoliciesResponse>);
        }
        
        /// <summary>
        /// 查询证书详情
        ///
        /// 查询证书详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCertificateResponse ShowCertificate(ShowCertificateRequest showCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id", showCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCertificateResponse>(response);
        }

        public SyncInvoker<ShowCertificateResponse> ShowCertificateInvoker(ShowCertificateRequest showCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id", showCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificateRequest);
            return new SyncInvoker<ShowCertificateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCertificateResponse>);
        }
        
        /// <summary>
        /// 查询规格详情
        ///
        /// 查询规格的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFlavorResponse ShowFlavor(ShowFlavorRequest showFlavorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("flavor_id", showFlavorRequest.FlavorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/flavors/{flavor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlavorRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFlavorResponse>(response);
        }

        public SyncInvoker<ShowFlavorResponse> ShowFlavorInvoker(ShowFlavorRequest showFlavorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("flavor_id", showFlavorRequest.FlavorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/flavors/{flavor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlavorRequest);
            return new SyncInvoker<ShowFlavorResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFlavorResponse>);
        }
        
        /// <summary>
        /// 查询健康检查详情
        ///
        /// 查询健康检查详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHealthMonitorResponse ShowHealthMonitor(ShowHealthMonitorRequest showHealthMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id", showHealthMonitorRequest.HealthmonitorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthMonitorRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHealthMonitorResponse>(response);
        }

        public SyncInvoker<ShowHealthMonitorResponse> ShowHealthMonitorInvoker(ShowHealthMonitorRequest showHealthMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id", showHealthMonitorRequest.HealthmonitorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthMonitorRequest);
            return new SyncInvoker<ShowHealthMonitorResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHealthMonitorResponse>);
        }
        
        /// <summary>
        /// 查询转发策略详情
        ///
        /// 查询七层转发策略详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowL7PolicyResponse ShowL7Policy(ShowL7PolicyRequest showL7PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", showL7PolicyRequest.L7policyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7PolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowL7PolicyResponse>(response);
        }

        public SyncInvoker<ShowL7PolicyResponse> ShowL7PolicyInvoker(ShowL7PolicyRequest showL7PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", showL7PolicyRequest.L7policyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7PolicyRequest);
            return new SyncInvoker<ShowL7PolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowL7PolicyResponse>);
        }
        
        /// <summary>
        /// 查询转发规则详情
        ///
        /// 查询七层转发规则详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowL7RuleResponse ShowL7Rule(ShowL7RuleRequest showL7RuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", showL7RuleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id", showL7RuleRequest.L7ruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7RuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowL7RuleResponse>(response);
        }

        public SyncInvoker<ShowL7RuleResponse> ShowL7RuleInvoker(ShowL7RuleRequest showL7RuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", showL7RuleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id", showL7RuleRequest.L7ruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7RuleRequest);
            return new SyncInvoker<ShowL7RuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowL7RuleResponse>);
        }
        
        /// <summary>
        /// 查询监听器详情
        ///
        /// 监听器详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowListenerResponse ShowListener(ShowListenerRequest showListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", showListenerRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowListenerResponse>(response);
        }

        public SyncInvoker<ShowListenerResponse> ShowListenerInvoker(ShowListenerRequest showListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", showListenerRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerRequest);
            return new SyncInvoker<ShowListenerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowListenerResponse>);
        }
        
        /// <summary>
        /// 查询负载均衡器详情
        ///
        /// 查询负载均衡器详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLoadBalancerResponse ShowLoadBalancer(ShowLoadBalancerRequest showLoadBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", showLoadBalancerRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLoadBalancerResponse>(response);
        }

        public SyncInvoker<ShowLoadBalancerResponse> ShowLoadBalancerInvoker(ShowLoadBalancerRequest showLoadBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", showLoadBalancerRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerRequest);
            return new SyncInvoker<ShowLoadBalancerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLoadBalancerResponse>);
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
        public ShowLoadBalancerStatusResponse ShowLoadBalancerStatus(ShowLoadBalancerStatusRequest showLoadBalancerStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", showLoadBalancerStatusRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLoadBalancerStatusResponse>(response);
        }

        public SyncInvoker<ShowLoadBalancerStatusResponse> ShowLoadBalancerStatusInvoker(ShowLoadBalancerStatusRequest showLoadBalancerStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", showLoadBalancerStatusRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerStatusRequest);
            return new SyncInvoker<ShowLoadBalancerStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLoadBalancerStatusResponse>);
        }
        
        /// <summary>
        /// 查询云日志详情
        ///
        /// 云日志详情。[荷兰region不支持云日志功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLogtankResponse ShowLogtank(ShowLogtankRequest showLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("logtank_id", showLogtankRequest.LogtankId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogtankRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLogtankResponse>(response);
        }

        public SyncInvoker<ShowLogtankResponse> ShowLogtankInvoker(ShowLogtankRequest showLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("logtank_id", showLogtankRequest.LogtankId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogtankRequest);
            return new SyncInvoker<ShowLogtankResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLogtankResponse>);
        }
        
        /// <summary>
        /// 查询主备后端服务器组详情
        ///
        /// 主备后端服务器组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMasterSlavePoolResponse ShowMasterSlavePool(ShowMasterSlavePoolRequest showMasterSlavePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", showMasterSlavePoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/master-slave-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMasterSlavePoolRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMasterSlavePoolResponse>(response);
        }

        public SyncInvoker<ShowMasterSlavePoolResponse> ShowMasterSlavePoolInvoker(ShowMasterSlavePoolRequest showMasterSlavePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", showMasterSlavePoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/master-slave-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMasterSlavePoolRequest);
            return new SyncInvoker<ShowMasterSlavePoolResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMasterSlavePoolResponse>);
        }
        
        /// <summary>
        /// 查询后端服务器详情
        ///
        /// 后端服务器详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMemberResponse ShowMember(ShowMemberRequest showMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", showMemberRequest.PoolId.ToString());
            urlParam.Add("member_id", showMemberRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMemberResponse>(response);
        }

        public SyncInvoker<ShowMemberResponse> ShowMemberInvoker(ShowMemberRequest showMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", showMemberRequest.PoolId.ToString());
            urlParam.Add("member_id", showMemberRequest.MemberId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberRequest);
            return new SyncInvoker<ShowMemberResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMemberResponse>);
        }
        
        /// <summary>
        /// 查询后端服务器组详情
        ///
        /// 后端服务器组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPoolResponse ShowPool(ShowPoolRequest showPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", showPoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPoolResponse>(response);
        }

        public SyncInvoker<ShowPoolResponse> ShowPoolInvoker(ShowPoolRequest showPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", showPoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolRequest);
            return new SyncInvoker<ShowPoolResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPoolResponse>);
        }
        
        /// <summary>
        /// 查询配额详情
        ///
        /// 查询指定项目中负载均衡相关的各类资源的当前配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowQuotaResponse ShowQuota(ShowQuotaRequest showQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotaResponse>(response);
        }

        public SyncInvoker<ShowQuotaResponse> ShowQuotaInvoker(ShowQuotaRequest showQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            return new SyncInvoker<ShowQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotaResponse>);
        }
        
        /// <summary>
        /// 查询自定义安全策略详情
        ///
        /// 查询自定义安全策略详情。[荷兰region不支持自定义安全策略功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSecurityPolicyResponse ShowSecurityPolicy(ShowSecurityPolicyRequest showSecurityPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_policy_id", showSecurityPolicyRequest.SecurityPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSecurityPolicyResponse>(response);
        }

        public SyncInvoker<ShowSecurityPolicyResponse> ShowSecurityPolicyInvoker(ShowSecurityPolicyRequest showSecurityPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_policy_id", showSecurityPolicyRequest.SecurityPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityPolicyRequest);
            return new SyncInvoker<ShowSecurityPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecurityPolicyResponse>);
        }
        
        /// <summary>
        /// 更新证书
        ///
        /// 更新证书。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateCertificateResponse UpdateCertificate(UpdateCertificateRequest updateCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id", updateCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateCertificateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCertificateResponse>(response);
        }

        public SyncInvoker<UpdateCertificateResponse> UpdateCertificateInvoker(UpdateCertificateRequest updateCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id", updateCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateCertificateRequest);
            return new SyncInvoker<UpdateCertificateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCertificateResponse>);
        }
        
        /// <summary>
        /// 更新健康检查
        ///
        /// 更新健康检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateHealthMonitorResponse UpdateHealthMonitor(UpdateHealthMonitorRequest updateHealthMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id", updateHealthMonitorRequest.HealthmonitorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateHealthMonitorRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHealthMonitorResponse>(response);
        }

        public SyncInvoker<UpdateHealthMonitorResponse> UpdateHealthMonitorInvoker(UpdateHealthMonitorRequest updateHealthMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id", updateHealthMonitorRequest.HealthmonitorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateHealthMonitorRequest);
            return new SyncInvoker<UpdateHealthMonitorResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHealthMonitorResponse>);
        }
        
        /// <summary>
        /// 更新转发策略
        ///
        /// 更新七层转发策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateL7PolicyResponse UpdateL7Policy(UpdateL7PolicyRequest updateL7PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", updateL7PolicyRequest.L7policyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateL7PolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateL7PolicyResponse>(response);
        }

        public SyncInvoker<UpdateL7PolicyResponse> UpdateL7PolicyInvoker(UpdateL7PolicyRequest updateL7PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", updateL7PolicyRequest.L7policyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateL7PolicyRequest);
            return new SyncInvoker<UpdateL7PolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateL7PolicyResponse>);
        }
        
        /// <summary>
        /// 更新转发规则
        ///
        /// 更新七层转发规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateL7RuleResponse UpdateL7Rule(UpdateL7RuleRequest updateL7RuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", updateL7RuleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id", updateL7RuleRequest.L7ruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateL7RuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateL7RuleResponse>(response);
        }

        public SyncInvoker<UpdateL7RuleResponse> UpdateL7RuleInvoker(UpdateL7RuleRequest updateL7RuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id", updateL7RuleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id", updateL7RuleRequest.L7ruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateL7RuleRequest);
            return new SyncInvoker<UpdateL7RuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateL7RuleResponse>);
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
            urlParam.Add("listener_id", updateListenerRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateListenerRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateListenerResponse>(response);
        }

        public SyncInvoker<UpdateListenerResponse> UpdateListenerInvoker(UpdateListenerRequest updateListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id", updateListenerRequest.ListenerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateListenerRequest);
            return new SyncInvoker<UpdateListenerResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateListenerResponse>);
        }
        
        /// <summary>
        /// 更新负载均衡器
        ///
        /// 更新负载均衡器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateLoadBalancerResponse UpdateLoadBalancer(UpdateLoadBalancerRequest updateLoadBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", updateLoadBalancerRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLoadBalancerRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLoadBalancerResponse>(response);
        }

        public SyncInvoker<UpdateLoadBalancerResponse> UpdateLoadBalancerInvoker(UpdateLoadBalancerRequest updateLoadBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id", updateLoadBalancerRequest.LoadbalancerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLoadBalancerRequest);
            return new SyncInvoker<UpdateLoadBalancerResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLoadBalancerResponse>);
        }
        
        /// <summary>
        /// 更新云日志
        ///
        /// 更新云日志。[荷兰region不支持云日志功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateLogtankResponse UpdateLogtank(UpdateLogtankRequest updateLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("logtank_id", updateLogtankRequest.LogtankId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLogtankRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLogtankResponse>(response);
        }

        public SyncInvoker<UpdateLogtankResponse> UpdateLogtankInvoker(UpdateLogtankRequest updateLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("logtank_id", updateLogtankRequest.LogtankId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLogtankRequest);
            return new SyncInvoker<UpdateLogtankResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLogtankResponse>);
        }
        
        /// <summary>
        /// 更新后端服务器
        ///
        /// 更新后端服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMemberResponse UpdateMember(UpdateMemberRequest updateMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("member_id", updateMemberRequest.MemberId.ToString());
            urlParam.Add("pool_id", updateMemberRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMemberRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMemberResponse>(response);
        }

        public SyncInvoker<UpdateMemberResponse> UpdateMemberInvoker(UpdateMemberRequest updateMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("member_id", updateMemberRequest.MemberId.ToString());
            urlParam.Add("pool_id", updateMemberRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMemberRequest);
            return new SyncInvoker<UpdateMemberResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMemberResponse>);
        }
        
        /// <summary>
        /// 更新后端服务器组
        ///
        /// 更新后端服务器组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePoolResponse UpdatePool(UpdatePoolRequest updatePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", updatePoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePoolRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePoolResponse>(response);
        }

        public SyncInvoker<UpdatePoolResponse> UpdatePoolInvoker(UpdatePoolRequest updatePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id", updatePoolRequest.PoolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePoolRequest);
            return new SyncInvoker<UpdatePoolResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePoolResponse>);
        }
        
        /// <summary>
        /// 更新自定义安全策略
        ///
        /// 更新自定义安全策略。[荷兰region不支持自定义安全策略功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSecurityPolicyResponse UpdateSecurityPolicy(UpdateSecurityPolicyRequest updateSecurityPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_policy_id", updateSecurityPolicyRequest.SecurityPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecurityPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSecurityPolicyResponse>(response);
        }

        public SyncInvoker<UpdateSecurityPolicyResponse> UpdateSecurityPolicyInvoker(UpdateSecurityPolicyRequest updateSecurityPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_policy_id", updateSecurityPolicyRequest.SecurityPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecurityPolicyRequest);
            return new SyncInvoker<UpdateSecurityPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSecurityPolicyResponse>);
        }
        
        /// <summary>
        /// 查询API版本列表信息
        ///
        /// 返回ELB当前所有可用的API版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListApiVersionsResponse ListApiVersions(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }

        public SyncInvoker<ListApiVersionsResponse> ListApiVersionsInvoker(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            return new SyncInvoker<ListApiVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionsResponse>);
        }
        
        /// <summary>
        /// 删除IP地址组的IP列表项
        ///
        /// 批量删除IP地址组的IP列表信息。[荷兰region不支持该API](tag:dt,dt_test)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteIpListResponse BatchDeleteIpList(BatchDeleteIpListRequest batchDeleteIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id", batchDeleteIpListRequest.IpgroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/iplist/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteIpListRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteIpListResponse>(response);
        }

        public SyncInvoker<BatchDeleteIpListResponse> BatchDeleteIpListInvoker(BatchDeleteIpListRequest batchDeleteIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id", batchDeleteIpListRequest.IpgroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/iplist/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteIpListRequest);
            return new SyncInvoker<BatchDeleteIpListResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteIpListResponse>);
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
        /// [不支持传入l7_flavor_id](tag:hcso,fcs,fcs_vm,mix,hcso_g42,hcso_g42_b)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountPreoccupyIpNumResponse CountPreoccupyIpNum(CountPreoccupyIpNumRequest countPreoccupyIpNumRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/preoccupy-ip-num", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countPreoccupyIpNumRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CountPreoccupyIpNumResponse>(response);
        }

        public SyncInvoker<CountPreoccupyIpNumResponse> CountPreoccupyIpNumInvoker(CountPreoccupyIpNumRequest countPreoccupyIpNumRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/preoccupy-ip-num", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countPreoccupyIpNumRequest);
            return new SyncInvoker<CountPreoccupyIpNumResponse>(this, "GET", request, JsonUtils.DeSerialize<CountPreoccupyIpNumResponse>);
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
        public CreateIpGroupResponse CreateIpGroup(CreateIpGroupRequest createIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createIpGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateIpGroupResponse>(response);
        }

        public SyncInvoker<CreateIpGroupResponse> CreateIpGroupInvoker(CreateIpGroupRequest createIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createIpGroupRequest);
            return new SyncInvoker<CreateIpGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateIpGroupResponse>);
        }
        
        /// <summary>
        /// 删除IP地址组
        ///
        /// 删除ip地址组。[荷兰region不支持IP地址组功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteIpGroupResponse DeleteIpGroup(DeleteIpGroupRequest deleteIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id", deleteIpGroupRequest.IpgroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteIpGroupResponse>(response);
        }

        public SyncInvoker<DeleteIpGroupResponse> DeleteIpGroupInvoker(DeleteIpGroupRequest deleteIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id", deleteIpGroupRequest.IpgroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpGroupRequest);
            return new SyncInvoker<DeleteIpGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteIpGroupResponse>);
        }
        
        /// <summary>
        /// 查询IP地址组列表
        ///
        /// 查询IP地址组列表。[荷兰region不支持IP地址组功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListIpGroupsResponse ListIpGroups(ListIpGroupsRequest listIpGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListIpGroupsResponse>(response);
        }

        public SyncInvoker<ListIpGroupsResponse> ListIpGroupsInvoker(ListIpGroupsRequest listIpGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpGroupsRequest);
            return new SyncInvoker<ListIpGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIpGroupsResponse>);
        }
        
        /// <summary>
        /// 查询IP地址组详情
        ///
        /// 获取IP地址组详情。[荷兰region不支持IP地址组功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowIpGroupResponse ShowIpGroup(ShowIpGroupRequest showIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id", showIpGroupRequest.IpgroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowIpGroupResponse>(response);
        }

        public SyncInvoker<ShowIpGroupResponse> ShowIpGroupInvoker(ShowIpGroupRequest showIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id", showIpGroupRequest.IpgroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpGroupRequest);
            return new SyncInvoker<ShowIpGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIpGroupResponse>);
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
        public UpdateIpGroupResponse UpdateIpGroup(UpdateIpGroupRequest updateIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id", updateIpGroupRequest.IpgroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateIpGroupResponse>(response);
        }

        public SyncInvoker<UpdateIpGroupResponse> UpdateIpGroupInvoker(UpdateIpGroupRequest updateIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id", updateIpGroupRequest.IpgroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpGroupRequest);
            return new SyncInvoker<UpdateIpGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateIpGroupResponse>);
        }
        
        /// <summary>
        /// 更新IP地址组的IP列表项
        ///
        /// 添加新的IP地址到IP地址组的IP列表信息，或更新已有IP地址的描述。[荷兰region不支持该API](tag:dt,dt_test)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateIpListResponse UpdateIpList(UpdateIpListRequest updateIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id", updateIpListRequest.IpgroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/iplist/create-or-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpListRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateIpListResponse>(response);
        }

        public SyncInvoker<UpdateIpListResponse> UpdateIpListInvoker(UpdateIpListRequest updateIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id", updateIpListRequest.IpgroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/iplist/create-or-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpListRequest);
            return new SyncInvoker<UpdateIpListResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateIpListResponse>);
        }
        
    }
}