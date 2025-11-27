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
            if (StringUtils.TryConvertToNonEmptyString(batchAddAvailableZonesRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/availability-zone/batch-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddAvailableZonesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchAddAvailableZonesResponse>(response);
        }

        public SyncInvoker<BatchAddAvailableZonesResponse> BatchAddAvailableZonesInvoker(BatchAddAvailableZonesRequest batchAddAvailableZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchAddAvailableZonesRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/availability-zone/batch-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddAvailableZonesRequest);
            return new SyncInvoker<BatchAddAvailableZonesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAddAvailableZonesResponse>);
        }
        
        /// <summary>
        /// 批量创建负载均衡器
        ///
        /// [批量创建独享型或者共享型负载均衡器，包括按需及包周期计费负载均衡器。](tag:hws)
        /// [批量创建独享型或者共享型负载均衡器。](tag:hws_hk,hws_eu,hws_eu_wb,hws_test,dt,ctc,cmcc,sbc,hk_sbc)
        /// [批量创建负载均衡器。](tag:hcso,hk_vdf,srg,fcs,tm,hk_tm,ct)
        /// - 若要创建内网IPv4负载均衡器，则需要传入vip_subnet_cidr_id。
        /// - 若要创建公网IPv4负载均衡器，则需要传入publicip，以及传入vpc_id和vip_subnet_cidr_id这两个参数中的一个。
        /// - 若要绑定有已有公网IPv4地址，则需要传入publicip_ids，以及传入vpc_id和vip_subnet_cidr_id这两个参数中的一个。
        /// - 若要创建内网双栈负载均衡器，则需要传入ipv6_vip_virsubnet_id。
        /// - 若要创建公网双栈负载均衡器，则需要传入ipv6_vip_virsubnet_id和ipv6_bandwidth。
        /// - 若要创建网络型负载均衡器，则需要传入l4_flavor_id（网络型规格ID）；若要创建应用型负载均衡器，则需要传入l7_flavor_id（应用型规格ID）；若要创建网络型+应用型负载均衡器，则需要传入l4_flavor_id和l7_flavor_id。
        /// - 如果批量创建的负载均衡器数量大于1，则不支持绑定已有的公网IP，且不支持指定ipv4和ipv6地址。即number大于1时，不支持传入publicip_ids，vip_address和ipv6_vip_address字段。
        /// [- 若要创建包周期负载均衡器，则需要传入prepaid_options，否则创建按需计费负载均衡器。](tag:hws)
        /// - 按需计费分为固定规格计费和弹性规格计费，根据创建时所选规格的类型决定计费方式。具体规格说明见创建LB请求参数l4_flavor_id和l7_flavor_id。
        /// - 异步接口，返回体中包含需要批量创建的负载均衡的ID列表和批量创建负载均衡器的job ID，可以通过job ID查询当前批量创建负载均衡器的进度。
        /// - 批量创建独享型和共享型实例时，请求体传参规则有所不同，具体见请求体说明中各个参数的解释。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateLoadBalancersResponse BatchCreateLoadBalancers(BatchCreateLoadBalancersRequest batchCreateLoadBalancersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateLoadBalancersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateLoadBalancersResponse>(response);
        }

        public SyncInvoker<BatchCreateLoadBalancersResponse> BatchCreateLoadBalancersInvoker(BatchCreateLoadBalancersRequest batchCreateLoadBalancersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateLoadBalancersRequest);
            return new SyncInvoker<BatchCreateLoadBalancersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateLoadBalancersResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(batchCreateMembersRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateMembersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateMembersResponse>(response);
        }

        public SyncInvoker<BatchCreateMembersResponse> BatchCreateMembersInvoker(BatchCreateMembersRequest batchCreateMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateMembersRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
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
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteMembersRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteMembersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteMembersResponse>(response);
        }

        public SyncInvoker<BatchDeleteMembersResponse> BatchDeleteMembersInvoker(BatchDeleteMembersRequest batchDeleteMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteMembersRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteMembersRequest);
            return new SyncInvoker<BatchDeleteMembersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteMembersResponse>);
        }
        
        /// <summary>
        /// 移除负载均衡器可用区
        ///
        /// 移除负载均衡器的可用区。
        /// &gt; 移除可用区可能导致已有连接断开，请谨慎操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchRemoveAvailableZonesResponse BatchRemoveAvailableZones(BatchRemoveAvailableZonesRequest batchRemoveAvailableZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchRemoveAvailableZonesRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/availability-zone/batch-remove", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRemoveAvailableZonesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchRemoveAvailableZonesResponse>(response);
        }

        public SyncInvoker<BatchRemoveAvailableZonesResponse> BatchRemoveAvailableZonesInvoker(BatchRemoveAvailableZonesRequest batchRemoveAvailableZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchRemoveAvailableZonesRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/availability-zone/batch-remove", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRemoveAvailableZonesRequest);
            return new SyncInvoker<BatchRemoveAvailableZonesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRemoveAvailableZonesResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateMembersRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateMembersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchUpdateMembersResponse>(response);
        }

        public SyncInvoker<BatchUpdateMembersResponse> BatchUpdateMembersInvoker(BatchUpdateMembersRequest batchUpdateMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateMembersRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
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
        /// 1. 按需计费转包周期计费。
        /// 2. 按需按规格计费转按需按使用量计费。
        /// 3. 按需按使用量计费转按需按规格计费。
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
        /// 复制已有负载均衡器
        ///
        /// 复制已有的负载均衡器实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CloneLoadbalancerResponse CloneLoadbalancer(CloneLoadbalancerRequest cloneLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cloneLoadbalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/clone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cloneLoadbalancerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CloneLoadbalancerResponse>(response);
        }

        public SyncInvoker<CloneLoadbalancerResponse> CloneLoadbalancerInvoker(CloneLoadbalancerRequest cloneLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cloneLoadbalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/clone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cloneLoadbalancerRequest);
            return new SyncInvoker<CloneLoadbalancerResponse>(this, "POST", request, JsonUtils.DeSerialize<CloneLoadbalancerResponse>);
        }
        
        /// <summary>
        /// 创建证书
        ///
        /// 创建用于弹性负载均衡器HTTPS/TLS/QUIC协议监听器的证书。支持关联云证书与管理服务(CCM)的证书，或者使用自有证书。
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
        /// 修改证书私钥字段回显开关
        ///
        /// 开启或关闭ELB证书的私钥字段回显开关。该开关用于设置各个ELB证书接口的响应字段private_key和enc_private_key是否展示。若开启则证书的详情、列表、更新和创建接口返回私钥内容；不开启则返回脱敏后内容（******）。该开关影响整个租户项目（project），默认开启。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCertificatePrivateKeyEchoResponse CreateCertificatePrivateKeyEcho(CreateCertificatePrivateKeyEchoRequest createCertificatePrivateKeyEchoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/settings/private-key-echo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCertificatePrivateKeyEchoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCertificatePrivateKeyEchoResponse>(response);
        }

        public SyncInvoker<CreateCertificatePrivateKeyEchoResponse> CreateCertificatePrivateKeyEchoInvoker(CreateCertificatePrivateKeyEchoRequest createCertificatePrivateKeyEchoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/settings/private-key-echo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCertificatePrivateKeyEchoRequest);
            return new SyncInvoker<CreateCertificatePrivateKeyEchoResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCertificatePrivateKeyEchoResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(createL7RuleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createL7RuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateL7RuleResponse>(response);
        }

        public SyncInvoker<CreateL7RuleResponse> CreateL7RuleInvoker(CreateL7RuleRequest createL7RuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createL7RuleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createL7RuleRequest);
            return new SyncInvoker<CreateL7RuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateL7RuleResponse>);
        }
        
        /// <summary>
        /// 创建监听器
        ///
        /// 创建监听器。支持通过该接口创建独享型及共享型LB实例下的监听器。
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
        /// [创建独享型负载均衡器，包括按需及包周期计费负载均衡器。](tag:hws)
        /// [创建独享型负载均衡器。](tag:hws_hk,hws_eu,hws_eu_wb,hws_test,dt,ctc,cmcc,sbc,hk_sbc)
        /// [创建负载均衡器。](tag:hcso,hk_vdf,srg,fcs,tm,hk_tm,ct)
        /// 
        /// - 若要创建内网IPv4负载均衡器，则需要传入vip_subnet_cidr_id。
        /// - 若要创建公网IPv4负载均衡器，则需要传入publicip，以及传入vpc_id和vip_subnet_cidr_id这两个参数中的一个。
        /// - 若要绑定有已有公网IPv4地址，则需要传入publicip_ids，以及传入vpc_id和vip_subnet_cidr_id这两个参数中的一个。
        /// - 若要创建内网双栈负载均衡器，则需要传入ipv6_vip_virsubnet_id。
        /// - 若要创建公网双栈负载均衡器，则需要传入ipv6_vip_virsubnet_id和ipv6_bandwidth。
        /// - 若要创建网络型负载均衡器，则需要传入l4_flavor_id（网络型规格ID）；若要创建应用型负载均衡器，则需要传入l7_flavor_id（应用型规格ID）；若要创建网络型+应用型负载均衡器，则需要传入l4_flavor_id和l7_flavor_id。
        /// [- 若要创建包周期负载均衡器，则需要传入prepaid_options，否则创建按需计费负载均衡器。](tag:hws)
        /// - 按需计费分为固定规格计费和弹性规格计费，根据创建时所选规格的类型决定计费方式。具体规格说明见创建LB请求参数l4_flavor_id和l7_flavor_id。
        /// [- 若要创建gateway类型的负载均衡器，则需要：
        ///    - 指定loadbalancer_type&#x3D;\&quot;gateway\&quot;，且不支持指定vip_address，ipv6_vip_address。
        ///    - vip_subnet_cidr_id和ipv6_subnet_cidr_id两者不能都为空，如果两者都传入，则必须属于同一子网。 
        ///    - 不支持创建公网gateway类型LB。
        ///    - 如果要指定规格，则从请求参数gw_flavor_id传入。](tag:hws_eu)
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
        /// 创建云日志。
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
            if (StringUtils.TryConvertToNonEmptyString(createMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMemberRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMemberResponse>(response);
        }

        public SyncInvoker<CreateMemberResponse> CreateMemberInvoker(CreateMemberRequest createMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMemberRequest);
            return new SyncInvoker<CreateMemberResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMemberResponse>);
        }
        
        /// <summary>
        /// 创建后端服务器检测任务
        ///
        /// 创建后端服务器检测任务。包括后端服务器的配置、ACL规则和安全组规则检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMemberHealthCheckJobResponse CreateMemberHealthCheckJob(CreateMemberHealthCheckJobRequest createMemberHealthCheckJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMemberHealthCheckJobRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/members/{member_id}/health-check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMemberHealthCheckJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMemberHealthCheckJobResponse>(response);
        }

        public SyncInvoker<CreateMemberHealthCheckJobResponse> CreateMemberHealthCheckJobInvoker(CreateMemberHealthCheckJobRequest createMemberHealthCheckJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMemberHealthCheckJobRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/members/{member_id}/health-check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMemberHealthCheckJobRequest);
            return new SyncInvoker<CreateMemberHealthCheckJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMemberHealthCheckJobResponse>);
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
        /// 创建自定义安全策略。用于在创建HTTPS/TLS监听器时，请求参数中指定security_policy_id来设置监听器的自定义安全策略。
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
        /// 删除ELB证书。若是删除source&#x3D;scm的证书，关联的云证书与管理服务（CCM）中的证书不会被删除。若想删除已关联到监听器的证书，则需要先解除监听器和证书的绑定关系。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest deleteCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCertificateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCertificateResponse>(response);
        }

        public SyncInvoker<DeleteCertificateResponse> DeleteCertificateInvoker(DeleteCertificateRequest deleteCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteHealthMonitorRequest.HealthmonitorId, out var valueOfHealthmonitorId)) urlParam.Add("healthmonitor_id", valueOfHealthmonitorId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHealthMonitorRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteHealthMonitorResponse>(response);
        }

        public SyncInvoker<DeleteHealthMonitorResponse> DeleteHealthMonitorInvoker(DeleteHealthMonitorRequest deleteHealthMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHealthMonitorRequest.HealthmonitorId, out var valueOfHealthmonitorId)) urlParam.Add("healthmonitor_id", valueOfHealthmonitorId);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteL7PolicyRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7PolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteL7PolicyResponse>(response);
        }

        public SyncInvoker<DeleteL7PolicyResponse> DeleteL7PolicyInvoker(DeleteL7PolicyRequest deleteL7PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteL7PolicyRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteL7RuleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            if (StringUtils.TryConvertToNonEmptyString(deleteL7RuleRequest.L7ruleId, out var valueOfL7ruleId)) urlParam.Add("l7rule_id", valueOfL7ruleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7RuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteL7RuleResponse>(response);
        }

        public SyncInvoker<DeleteL7RuleResponse> DeleteL7RuleInvoker(DeleteL7RuleRequest deleteL7RuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteL7RuleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            if (StringUtils.TryConvertToNonEmptyString(deleteL7RuleRequest.L7ruleId, out var valueOfL7ruleId)) urlParam.Add("l7rule_id", valueOfL7ruleId);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteListenerResponse>(response);
        }

        public SyncInvoker<DeleteListenerResponse> DeleteListenerInvoker(DeleteListenerRequest deleteListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteListenerForceRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}/force", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerForceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteListenerForceResponse>(response);
        }

        public SyncInvoker<DeleteListenerForceResponse> DeleteListenerForceInvoker(DeleteListenerForceRequest deleteListenerForceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteListenerForceRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteLoadBalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadBalancerRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLoadBalancerResponse>(response);
        }

        public SyncInvoker<DeleteLoadBalancerResponse> DeleteLoadBalancerInvoker(DeleteLoadBalancerRequest deleteLoadBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLoadBalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadBalancerRequest);
            return new SyncInvoker<DeleteLoadBalancerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLoadBalancerResponse>);
        }
        
        /// <summary>
        /// 级联删除负载均衡器及关联EIP
        ///
        /// 删除负载均衡器且级联删除其下子资源（删除负载均衡器及其绑定的监听器、后端服务器等一系列资源）。以及根据需要删除或解绑后端服务器组和LB关联的EIP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLoadBalancerCascadeResponse DeleteLoadBalancerCascade(DeleteLoadBalancerCascadeRequest deleteLoadBalancerCascadeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLoadBalancerCascadeRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/delete-cascade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteLoadBalancerCascadeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteLoadBalancerCascadeResponse>(response);
        }

        public SyncInvoker<DeleteLoadBalancerCascadeResponse> DeleteLoadBalancerCascadeInvoker(DeleteLoadBalancerCascadeRequest deleteLoadBalancerCascadeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLoadBalancerCascadeRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/delete-cascade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteLoadBalancerCascadeRequest);
            return new SyncInvoker<DeleteLoadBalancerCascadeResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteLoadBalancerCascadeResponse>);
        }
        
        /// <summary>
        /// 级联删除负载均衡器
        ///
        /// 删除负载均衡器且级联删除其下子资源（删除负载均衡器及其绑定的监听器、后端服务器组、后端服务器等一系列资源）。
        /// - 若LB关联了EIP，则只解绑EIP，不会删除EIP。
        /// [- 若已开启多挂特性，且关联了多个LB，则只做解绑；否则删除。
        /// - 若是共享型LB下的后端服务器组，无论是否多挂都只删除，不解绑。](tag:hc,hk)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLoadBalancerForceResponse DeleteLoadBalancerForce(DeleteLoadBalancerForceRequest deleteLoadBalancerForceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLoadBalancerForceRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/force-elb", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadBalancerForceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLoadBalancerForceResponse>(response);
        }

        public SyncInvoker<DeleteLoadBalancerForceResponse> DeleteLoadBalancerForceInvoker(DeleteLoadBalancerForceRequest deleteLoadBalancerForceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLoadBalancerForceRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/force-elb", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadBalancerForceRequest);
            return new SyncInvoker<DeleteLoadBalancerForceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLoadBalancerForceResponse>);
        }
        
        /// <summary>
        /// 删除云日志
        ///
        /// 删除云日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLogtankResponse DeleteLogtank(DeleteLogtankRequest deleteLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogtankRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLogtankResponse>(response);
        }

        public SyncInvoker<DeleteLogtankResponse> DeleteLogtankInvoker(DeleteLogtankRequest deleteLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteMasterSlavePoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/master-slave-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMasterSlavePoolRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMasterSlavePoolResponse>(response);
        }

        public SyncInvoker<DeleteMasterSlavePoolResponse> DeleteMasterSlavePoolInvoker(DeleteMasterSlavePoolRequest deleteMasterSlavePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMasterSlavePoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMemberRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMemberResponse>(response);
        }

        public SyncInvoker<DeleteMemberResponse> DeleteMemberInvoker(DeleteMemberRequest deleteMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
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
            if (StringUtils.TryConvertToNonEmptyString(deletePoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePoolRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePoolResponse>(response);
        }

        public SyncInvoker<DeletePoolResponse> DeletePoolInvoker(DeletePoolRequest deletePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePoolRequest);
            return new SyncInvoker<DeletePoolResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePoolResponse>);
        }
        
        /// <summary>
        /// 级联删除后端服务器组
        ///
        /// 级联删除后端服务器组，包含在此后端服务器组下的所有后端服务器和健康检查也将被删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePoolCascadeResponse DeletePoolCascade(DeletePoolCascadeRequest deletePoolCascadeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePoolCascadeRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/delete-cascade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePoolCascadeRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePoolCascadeResponse>(response);
        }

        public SyncInvoker<DeletePoolCascadeResponse> DeletePoolCascadeInvoker(DeletePoolCascadeRequest deletePoolCascadeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePoolCascadeRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/delete-cascade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePoolCascadeRequest);
            return new SyncInvoker<DeletePoolCascadeResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePoolCascadeResponse>);
        }
        
        /// <summary>
        /// 销毁回收站负载均衡器
        ///
        /// 销毁回收站负载均衡器。销毁后无法再还原。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRecycleLoadBalancerResponse DeleteRecycleLoadBalancer(DeleteRecycleLoadBalancerRequest deleteRecycleLoadBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRecycleLoadBalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecycleLoadBalancerRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRecycleLoadBalancerResponse>(response);
        }

        public SyncInvoker<DeleteRecycleLoadBalancerResponse> DeleteRecycleLoadBalancerInvoker(DeleteRecycleLoadBalancerRequest deleteRecycleLoadBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRecycleLoadBalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecycleLoadBalancerRequest);
            return new SyncInvoker<DeleteRecycleLoadBalancerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRecycleLoadBalancerResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteSecurityPolicyRequest.SecurityPolicyId, out var valueOfSecurityPolicyId)) urlParam.Add("security_policy_id", valueOfSecurityPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityPolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecurityPolicyResponse>(response);
        }

        public SyncInvoker<DeleteSecurityPolicyResponse> DeleteSecurityPolicyInvoker(DeleteSecurityPolicyRequest deleteSecurityPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecurityPolicyRequest.SecurityPolicyId, out var valueOfSecurityPolicyId)) urlParam.Add("security_policy_id", valueOfSecurityPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityPolicyRequest);
            return new SyncInvoker<DeleteSecurityPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecurityPolicyResponse>);
        }
        
        /// <summary>
        /// 后端服务器全局列表
        ///
        /// 查询当前项目下的后端服务器列表。
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
        /// - 如果传入了loadbalancer_id，则返回该负载均衡器所在集群的可用区集合
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
        /// 查询ELB证书列表。
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
        /// 查询当前租户ELB服务的特性配置
        ///
        /// 查询当前租户ELB服务的特性配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFeatureConfigsResponse ListFeatureConfigs(ListFeatureConfigsRequest listFeatureConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/feature/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFeatureConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFeatureConfigsResponse>(response);
        }

        public SyncInvoker<ListFeatureConfigsResponse> ListFeatureConfigsInvoker(ListFeatureConfigsRequest listFeatureConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/feature/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFeatureConfigsRequest);
            return new SyncInvoker<ListFeatureConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFeatureConfigsResponse>);
        }
        
        /// <summary>
        /// 查询规格列表
        ///
        /// 查询当前局点可用的负载均衡器规格。用于在创建独享型负载均衡器时指定4层或7层规格。
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
        /// 查询异步任务的job列表
        ///
        /// 用于查询实例复制、实例升级等异步接口任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListJobsResponse ListJobs(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListJobsResponse>(response);
        }

        public SyncInvoker<ListJobsResponse> ListJobsInvoker(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            return new SyncInvoker<ListJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobsResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(listL7RulesRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7RulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListL7RulesResponse>(response);
        }

        public SyncInvoker<ListL7RulesResponse> ListL7RulesInvoker(ListL7RulesRequest listL7RulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listL7RulesRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
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
        /// 查询指定ELB实例的特性配置
        ///
        /// 查询指定ELB实例的特性配置情况。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLoadbalancerFeatureResponse ListLoadbalancerFeature(ListLoadbalancerFeatureRequest listLoadbalancerFeatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLoadbalancerFeatureRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/features", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancerFeatureRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLoadbalancerFeatureResponse>(response);
        }

        public SyncInvoker<ListLoadbalancerFeatureResponse> ListLoadbalancerFeatureInvoker(ListLoadbalancerFeatureRequest listLoadbalancerFeatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLoadbalancerFeatureRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/features", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancerFeatureRequest);
            return new SyncInvoker<ListLoadbalancerFeatureResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLoadbalancerFeatureResponse>);
        }
        
        /// <summary>
        /// 查询云日志列表
        ///
        /// 查询云日志列表。
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
            if (StringUtils.TryConvertToNonEmptyString(listMembersRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMembersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMembersResponse>(response);
        }

        public SyncInvoker<ListMembersResponse> ListMembersInvoker(ListMembersRequest listMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMembersRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMembersRequest);
            return new SyncInvoker<ListMembersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMembersResponse>);
        }
        
        /// <summary>
        /// 查询后端服务器组列表
        ///
        /// 查询后端服务器组列表。
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
        /// 查询负载均衡服务相关的各类资源的当前配额和已使用配额。
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
        /// 查询回收站负载均衡器列表
        ///
        /// 查询回收站负载均衡器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRecycleBinLoadBalancersResponse ListRecycleBinLoadBalancers(ListRecycleBinLoadBalancersRequest listRecycleBinLoadBalancersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin/loadbalancers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecycleBinLoadBalancersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRecycleBinLoadBalancersResponse>(response);
        }

        public SyncInvoker<ListRecycleBinLoadBalancersResponse> ListRecycleBinLoadBalancersInvoker(ListRecycleBinLoadBalancersRequest listRecycleBinLoadBalancersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin/loadbalancers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecycleBinLoadBalancersRequest);
            return new SyncInvoker<ListRecycleBinLoadBalancersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecycleBinLoadBalancersResponse>);
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
        /// 还原负载均衡器
        ///
        /// 从回收站中还原负载均衡器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreLoadbalancerResponse RestoreLoadbalancer(RestoreLoadbalancerRequest restoreLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreLoadbalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin/loadbalancers/{loadbalancer_id}/recover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreLoadbalancerRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<RestoreLoadbalancerResponse>(response);
        }

        public SyncInvoker<RestoreLoadbalancerResponse> RestoreLoadbalancerInvoker(RestoreLoadbalancerRequest restoreLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreLoadbalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin/loadbalancers/{loadbalancer_id}/recover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreLoadbalancerRequest);
            return new SyncInvoker<RestoreLoadbalancerResponse>(this, "PUT", request, JsonUtils.DeSerialize<RestoreLoadbalancerResponse>);
        }
        
        /// <summary>
        /// 查询证书详情
        ///
        /// 查询ELB证书详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCertificateResponse ShowCertificate(ShowCertificateRequest showCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCertificateResponse>(response);
        }

        public SyncInvoker<ShowCertificateResponse> ShowCertificateInvoker(ShowCertificateRequest showCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificateRequest);
            return new SyncInvoker<ShowCertificateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCertificateResponse>);
        }
        
        /// <summary>
        /// 查询证书私钥字段回显开关
        ///
        /// 查询证书私钥回显开关的状态。该开关用于设置各个ELB证书接口的响应字段private_key和enc_private_key是否展示。若开启则这些接口返回私钥内容；不开启则返回脱敏后内容（******）。该开关影响整个租户项目（project），默认开启。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCertificatePrivateKeyEchoResponse ShowCertificatePrivateKeyEcho(ShowCertificatePrivateKeyEchoRequest showCertificatePrivateKeyEchoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/settings/private-key-echo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificatePrivateKeyEchoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCertificatePrivateKeyEchoResponse>(response);
        }

        public SyncInvoker<ShowCertificatePrivateKeyEchoResponse> ShowCertificatePrivateKeyEchoInvoker(ShowCertificatePrivateKeyEchoRequest showCertificatePrivateKeyEchoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/settings/private-key-echo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificatePrivateKeyEchoRequest);
            return new SyncInvoker<ShowCertificatePrivateKeyEchoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCertificatePrivateKeyEchoResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showFlavorRequest.FlavorId, out var valueOfFlavorId)) urlParam.Add("flavor_id", valueOfFlavorId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/flavors/{flavor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlavorRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFlavorResponse>(response);
        }

        public SyncInvoker<ShowFlavorResponse> ShowFlavorInvoker(ShowFlavorRequest showFlavorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFlavorRequest.FlavorId, out var valueOfFlavorId)) urlParam.Add("flavor_id", valueOfFlavorId);
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
            if (StringUtils.TryConvertToNonEmptyString(showHealthMonitorRequest.HealthmonitorId, out var valueOfHealthmonitorId)) urlParam.Add("healthmonitor_id", valueOfHealthmonitorId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthMonitorRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHealthMonitorResponse>(response);
        }

        public SyncInvoker<ShowHealthMonitorResponse> ShowHealthMonitorInvoker(ShowHealthMonitorRequest showHealthMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHealthMonitorRequest.HealthmonitorId, out var valueOfHealthmonitorId)) urlParam.Add("healthmonitor_id", valueOfHealthmonitorId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthMonitorRequest);
            return new SyncInvoker<ShowHealthMonitorResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHealthMonitorResponse>);
        }
        
        /// <summary>
        /// 查询异步任务的job状态
        ///
        /// 用于查询实例复制、实例升级等异步接口任务的状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobResponse ShowJob(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }

        public SyncInvoker<ShowJobResponse> ShowJobInvoker(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            return new SyncInvoker<ShowJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showL7PolicyRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7PolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowL7PolicyResponse>(response);
        }

        public SyncInvoker<ShowL7PolicyResponse> ShowL7PolicyInvoker(ShowL7PolicyRequest showL7PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showL7PolicyRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
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
            if (StringUtils.TryConvertToNonEmptyString(showL7RuleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            if (StringUtils.TryConvertToNonEmptyString(showL7RuleRequest.L7ruleId, out var valueOfL7ruleId)) urlParam.Add("l7rule_id", valueOfL7ruleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7RuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowL7RuleResponse>(response);
        }

        public SyncInvoker<ShowL7RuleResponse> ShowL7RuleInvoker(ShowL7RuleRequest showL7RuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showL7RuleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            if (StringUtils.TryConvertToNonEmptyString(showL7RuleRequest.L7ruleId, out var valueOfL7ruleId)) urlParam.Add("l7rule_id", valueOfL7ruleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7RuleRequest);
            return new SyncInvoker<ShowL7RuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowL7RuleResponse>);
        }
        
        /// <summary>
        /// 查询监听器详情
        ///
        /// 查询监听器详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowListenerResponse ShowListener(ShowListenerRequest showListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowListenerResponse>(response);
        }

        public SyncInvoker<ShowListenerResponse> ShowListenerInvoker(ShowListenerRequest showListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
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
            if (StringUtils.TryConvertToNonEmptyString(showLoadBalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLoadBalancerResponse>(response);
        }

        public SyncInvoker<ShowLoadBalancerResponse> ShowLoadBalancerInvoker(ShowLoadBalancerRequest showLoadBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoadBalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerRequest);
            return new SyncInvoker<ShowLoadBalancerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLoadBalancerResponse>);
        }
        
        /// <summary>
        /// 查询负载均衡器占用的下联面子网端口列表
        ///
        /// 查询负载均衡器占用的下联面子网端口和IP地址信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLoadBalancerPortsResponse ShowLoadBalancerPorts(ShowLoadBalancerPortsRequest showLoadBalancerPortsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoadBalancerPortsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/local-ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerPortsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLoadBalancerPortsResponse>(response);
        }

        public SyncInvoker<ShowLoadBalancerPortsResponse> ShowLoadBalancerPortsInvoker(ShowLoadBalancerPortsRequest showLoadBalancerPortsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoadBalancerPortsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/local-ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerPortsRequest);
            return new SyncInvoker<ShowLoadBalancerPortsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLoadBalancerPortsResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showLoadBalancerStatusRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLoadBalancerStatusResponse>(response);
        }

        public SyncInvoker<ShowLoadBalancerStatusResponse> ShowLoadBalancerStatusInvoker(ShowLoadBalancerStatusRequest showLoadBalancerStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoadBalancerStatusRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerStatusRequest);
            return new SyncInvoker<ShowLoadBalancerStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLoadBalancerStatusResponse>);
        }
        
        /// <summary>
        /// 查询云日志详情
        ///
        /// 云日志详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLogtankResponse ShowLogtank(ShowLogtankRequest showLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogtankRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLogtankResponse>(response);
        }

        public SyncInvoker<ShowLogtankResponse> ShowLogtankInvoker(ShowLogtankRequest showLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
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
            if (StringUtils.TryConvertToNonEmptyString(showMasterSlavePoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/master-slave-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMasterSlavePoolRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMasterSlavePoolResponse>(response);
        }

        public SyncInvoker<ShowMasterSlavePoolResponse> ShowMasterSlavePoolInvoker(ShowMasterSlavePoolRequest showMasterSlavePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMasterSlavePoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
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
            if (StringUtils.TryConvertToNonEmptyString(showMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            if (StringUtils.TryConvertToNonEmptyString(showMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMemberResponse>(response);
        }

        public SyncInvoker<ShowMemberResponse> ShowMemberInvoker(ShowMemberRequest showMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            if (StringUtils.TryConvertToNonEmptyString(showMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberRequest);
            return new SyncInvoker<ShowMemberResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMemberResponse>);
        }
        
        /// <summary>
        /// 查询后端服务器检测任务的结果
        ///
        /// 查询后端服务器检测任务的结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMemberHealthCheckJobResponse ShowMemberHealthCheckJob(ShowMemberHealthCheckJobRequest showMemberHealthCheckJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMemberHealthCheckJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/members/check/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberHealthCheckJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMemberHealthCheckJobResponse>(response);
        }

        public SyncInvoker<ShowMemberHealthCheckJobResponse> ShowMemberHealthCheckJobInvoker(ShowMemberHealthCheckJobRequest showMemberHealthCheckJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMemberHealthCheckJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/members/check/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberHealthCheckJobRequest);
            return new SyncInvoker<ShowMemberHealthCheckJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMemberHealthCheckJobResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showPoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPoolResponse>(response);
        }

        public SyncInvoker<ShowPoolResponse> ShowPoolInvoker(ShowPoolRequest showPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolRequest);
            return new SyncInvoker<ShowPoolResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPoolResponse>);
        }
        
        /// <summary>
        /// 查询配额详情
        ///
        /// 查询指定项目中负载均衡相关的各类资源的当前配额。接口返回只包含总配额，不包含已使用配额。若需要查询已使用配额，可使用查询配额使用详情（GET /v3/{project_id}/elb/quotas/details）接口。
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
        /// 查询回收站的配置
        ///
        /// 查询回收站的配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecycleBinResponse ShowRecycleBin(ShowRecycleBinRequest showRecycleBinRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecycleBinRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRecycleBinResponse>(response);
        }

        public SyncInvoker<ShowRecycleBinResponse> ShowRecycleBinInvoker(ShowRecycleBinRequest showRecycleBinRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecycleBinRequest);
            return new SyncInvoker<ShowRecycleBinResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecycleBinResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showSecurityPolicyRequest.SecurityPolicyId, out var valueOfSecurityPolicyId)) urlParam.Add("security_policy_id", valueOfSecurityPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSecurityPolicyResponse>(response);
        }

        public SyncInvoker<ShowSecurityPolicyResponse> ShowSecurityPolicyInvoker(ShowSecurityPolicyRequest showSecurityPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecurityPolicyRequest.SecurityPolicyId, out var valueOfSecurityPolicyId)) urlParam.Add("security_policy_id", valueOfSecurityPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityPolicyRequest);
            return new SyncInvoker<ShowSecurityPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecurityPolicyResponse>);
        }
        
        /// <summary>
        /// 更新证书
        ///
        /// 更新ELB证书。不能更新证书类型，但可以更新证书内容和私钥等。
        /// 注意：更新证书会影响当前证书已关联的监听器，请谨慎操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateCertificateResponse UpdateCertificate(UpdateCertificateRequest updateCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateCertificateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCertificateResponse>(response);
        }

        public SyncInvoker<UpdateCertificateResponse> UpdateCertificateInvoker(UpdateCertificateRequest updateCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
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
            if (StringUtils.TryConvertToNonEmptyString(updateHealthMonitorRequest.HealthmonitorId, out var valueOfHealthmonitorId)) urlParam.Add("healthmonitor_id", valueOfHealthmonitorId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateHealthMonitorRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHealthMonitorResponse>(response);
        }

        public SyncInvoker<UpdateHealthMonitorResponse> UpdateHealthMonitorInvoker(UpdateHealthMonitorRequest updateHealthMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHealthMonitorRequest.HealthmonitorId, out var valueOfHealthmonitorId)) urlParam.Add("healthmonitor_id", valueOfHealthmonitorId);
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
            if (StringUtils.TryConvertToNonEmptyString(updateL7PolicyRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateL7PolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateL7PolicyResponse>(response);
        }

        public SyncInvoker<UpdateL7PolicyResponse> UpdateL7PolicyInvoker(UpdateL7PolicyRequest updateL7PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateL7PolicyRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
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
            if (StringUtils.TryConvertToNonEmptyString(updateL7RuleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            if (StringUtils.TryConvertToNonEmptyString(updateL7RuleRequest.L7ruleId, out var valueOfL7ruleId)) urlParam.Add("l7rule_id", valueOfL7ruleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateL7RuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateL7RuleResponse>(response);
        }

        public SyncInvoker<UpdateL7RuleResponse> UpdateL7RuleInvoker(UpdateL7RuleRequest updateL7RuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateL7RuleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            if (StringUtils.TryConvertToNonEmptyString(updateL7RuleRequest.L7ruleId, out var valueOfL7ruleId)) urlParam.Add("l7rule_id", valueOfL7ruleId);
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
            if (StringUtils.TryConvertToNonEmptyString(updateListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateListenerRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateListenerResponse>(response);
        }

        public SyncInvoker<UpdateListenerResponse> UpdateListenerInvoker(UpdateListenerRequest updateListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
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
            if (StringUtils.TryConvertToNonEmptyString(updateLoadBalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLoadBalancerRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLoadBalancerResponse>(response);
        }

        public SyncInvoker<UpdateLoadBalancerResponse> UpdateLoadBalancerInvoker(UpdateLoadBalancerRequest updateLoadBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLoadBalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLoadBalancerRequest);
            return new SyncInvoker<UpdateLoadBalancerResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLoadBalancerResponse>);
        }
        
        /// <summary>
        /// 更新云日志
        ///
        /// 更新云日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateLogtankResponse UpdateLogtank(UpdateLogtankRequest updateLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLogtankRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLogtankResponse>(response);
        }

        public SyncInvoker<UpdateLogtankResponse> UpdateLogtankInvoker(UpdateLogtankRequest updateLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
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
            if (StringUtils.TryConvertToNonEmptyString(updateMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            if (StringUtils.TryConvertToNonEmptyString(updateMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMemberRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMemberResponse>(response);
        }

        public SyncInvoker<UpdateMemberResponse> UpdateMemberInvoker(UpdateMemberRequest updateMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            if (StringUtils.TryConvertToNonEmptyString(updateMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
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
            if (StringUtils.TryConvertToNonEmptyString(updatePoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePoolRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePoolResponse>(response);
        }

        public SyncInvoker<UpdatePoolResponse> UpdatePoolInvoker(UpdatePoolRequest updatePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePoolRequest);
            return new SyncInvoker<UpdatePoolResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePoolResponse>);
        }
        
        /// <summary>
        /// 开关回收站
        ///
        /// 开启或关闭回收站功能。开启后删除的LB可以进入回收站，否则将不进入回收站而是直接被删除无法恢复。关闭回收站前需要先将回收站中的实例还原或销毁。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRecycleBinEnableResponse UpdateRecycleBinEnable(UpdateRecycleBinEnableRequest updateRecycleBinEnableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecycleBinEnableRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRecycleBinEnableResponse>(response);
        }

        public SyncInvoker<UpdateRecycleBinEnableResponse> UpdateRecycleBinEnableInvoker(UpdateRecycleBinEnableRequest updateRecycleBinEnableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecycleBinEnableRequest);
            return new SyncInvoker<UpdateRecycleBinEnableResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRecycleBinEnableResponse>);
        }
        
        /// <summary>
        /// 更新回收站的配置
        ///
        /// 更新回收站的配置。若回收站未开启，则更新会报错。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRecycleBinPolicyResponse UpdateRecycleBinPolicy(UpdateRecycleBinPolicyRequest updateRecycleBinPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecycleBinPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRecycleBinPolicyResponse>(response);
        }

        public SyncInvoker<UpdateRecycleBinPolicyResponse> UpdateRecycleBinPolicyInvoker(UpdateRecycleBinPolicyRequest updateRecycleBinPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecycleBinPolicyRequest);
            return new SyncInvoker<UpdateRecycleBinPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRecycleBinPolicyResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(updateSecurityPolicyRequest.SecurityPolicyId, out var valueOfSecurityPolicyId)) urlParam.Add("security_policy_id", valueOfSecurityPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecurityPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSecurityPolicyResponse>(response);
        }

        public SyncInvoker<UpdateSecurityPolicyResponse> UpdateSecurityPolicyInvoker(UpdateSecurityPolicyRequest updateSecurityPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSecurityPolicyRequest.SecurityPolicyId, out var valueOfSecurityPolicyId)) urlParam.Add("security_policy_id", valueOfSecurityPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecurityPolicyRequest);
            return new SyncInvoker<UpdateSecurityPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSecurityPolicyResponse>);
        }
        
        /// <summary>
        /// 升级负载均衡器类型
        ///
        /// 升级负载均衡器类型。支持将共享型ELB升级为独享型ELB，但不支持独享型降级为共享型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeLoadbalancerResponse UpgradeLoadbalancer(UpgradeLoadbalancerRequest upgradeLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeLoadbalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeLoadbalancerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpgradeLoadbalancerResponse>(response);
        }

        public SyncInvoker<UpgradeLoadbalancerResponse> UpgradeLoadbalancerInvoker(UpgradeLoadbalancerRequest upgradeLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeLoadbalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeLoadbalancerRequest);
            return new SyncInvoker<UpgradeLoadbalancerResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeLoadbalancerResponse>);
        }
        
        /// <summary>
        /// 查询API版本列表信息
        ///
        /// 查询当前ELB服务所有可用的API版本。通常情况下高版本API（当前v3为最高版本）比低版本API支持更多更全的特性。
        /// 不同版本接口使用时需要注意如下事项：
        /// - 创建负载均衡器（POST /v3/{project_id}/elb/loadbalancers）接口无法创建共享型ELB实例。需要通过v2/v2.0接口创建，或者通过批量创建负载均衡器（/v3/{project_id}/elb/loadbalancers/batch-create）、复制已有负载均衡器（/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/clone）这两个接口创建。
        /// - 其他v3接口都可以同时处理独享型和共享型实例及其子资源。例如：可以使用创建监听器接口（POST /v3/{project_id}/elb/listeners）创建共享型ELB下的监听器。但在这种情况下部分独享型实例特有的特性将不会支持，具体见各API说明。
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
        /// 批量删除IP地址组中IP列表的IP地址项。
        /// 注意：删除IP列表的IP地址项会影响所有已关联的监听器，请谨慎操作。
        /// [荷兰region不支持该API](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteIpListResponse BatchDeleteIpList(BatchDeleteIpListRequest batchDeleteIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteIpListRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/iplist/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteIpListRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteIpListResponse>(response);
        }

        public SyncInvoker<BatchDeleteIpListResponse> BatchDeleteIpListInvoker(BatchDeleteIpListRequest batchDeleteIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteIpListRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/iplist/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteIpListRequest);
            return new SyncInvoker<BatchDeleteIpListResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteIpListResponse>);
        }
        
        /// <summary>
        /// 计算预占IP数
        ///
        /// 计算以下几种场景的预占用IP数量：
        /// 
        /// - 计算创建LB所需IP数量：传入字段availability_zone_id，及可选字段l7_flavor_id、ip_target_enable、ip_version，不能传loadbalancer_id。
        /// - 计算创建LB的第一个七层监听器后新增占用IP数量：传入loadbalancer_id，其他字段不传。
        /// - 计算LB变更（规格变更或特性开启）新增占用IP数量：传入字段loadbalancer_id，及l7_flavor_id不为空或ip_target_enable为true。可以同时传入多个字段，表示同时进行多种变更所需要新增的占用IP数量。
        /// - 计算共享型ELB升级为独享型ELB所需新增占用IP数量：传入sence、loadbalancer_id，其他字段不传。
        /// - 计算ELB实例开启NAT64特性所需新增占用IP数量：传入nat64_enable、loadbalancer_id，其他字段不传。
        /// 
        /// 注意：
        /// - 计算出来的预占IP数大于等于最终实际占用的IP数。
        /// - 只计算新增占用IP数量，不包含已占用的IP数。
        /// 
        /// [不支持传入l7_flavor_id。](tag:hcso,hk_vdf,srg,fcs)
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
        /// 创建IP地址组。IP地址组用于关联监听器，设置监听器访问控制，指定可以访问或者禁止访问监听器的IP地址。
        /// 支持IPv4和IPv6类型地址，可以设置单个IP地址、IP地址段和连续IP地址范围。IP地址范围的格式为ip-ip，例如10.12.3.1-10.12.3.10。
        /// 
        /// 注意：0.0.0.0与0.0.0.0/32视为重复，0:0:0:0:0:0:0:1与::1与::1/128视为重复，只会保存其中一个。
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
        /// 删除IP地址组。已关联监听器的IP地址组无法直接删除，需要先解除关联关系。[荷兰region不支持IP地址组功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteIpGroupResponse DeleteIpGroup(DeleteIpGroupRequest deleteIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteIpGroupRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteIpGroupResponse>(response);
        }

        public SyncInvoker<DeleteIpGroupResponse> DeleteIpGroupInvoker(DeleteIpGroupRequest deleteIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteIpGroupRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
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
            if (StringUtils.TryConvertToNonEmptyString(showIpGroupRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowIpGroupResponse>(response);
        }

        public SyncInvoker<ShowIpGroupResponse> ShowIpGroupInvoker(ShowIpGroupRequest showIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIpGroupRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpGroupRequest);
            return new SyncInvoker<ShowIpGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIpGroupResponse>);
        }
        
        /// <summary>
        /// 查询IP地址组关联的监听器列表
        ///
        /// 查询IP地址组关联的监听器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowIpGroupRelatedListenersResponse ShowIpGroupRelatedListeners(ShowIpGroupRelatedListenersRequest showIpGroupRelatedListenersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIpGroupRelatedListenersRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/related-listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpGroupRelatedListenersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowIpGroupRelatedListenersResponse>(response);
        }

        public SyncInvoker<ShowIpGroupRelatedListenersResponse> ShowIpGroupRelatedListenersInvoker(ShowIpGroupRelatedListenersRequest showIpGroupRelatedListenersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIpGroupRelatedListenersRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/related-listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpGroupRelatedListenersRequest);
            return new SyncInvoker<ShowIpGroupRelatedListenersResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIpGroupRelatedListenersResponse>);
        }
        
        /// <summary>
        /// 更新IP地址组
        ///
        /// 更新IP地址组。若要更新其中的IP地址列表，则只支持全量更新。即IP地址组中的ip_list将被全量覆盖，不在请求参数中的IP地址将被移除。
        /// 支持IPv4和IPv6类型地址，可以设置单个IP地址、IP地址段和连续IP地址范围。IP地址范围的格式为ip-ip，例如10.12.3.1-10.12.3.10。
        /// 
        /// 注意：
        /// - 0.0.0.0与0.0.0.0/32视为重复，0:0:0:0:0:0:0:1与::1与::1/128视为重复，只会保存其中一个。
        /// - 更新IP地址组中的ip_list会影响所有已关联的监听器，请谨慎操作。
        /// 
        /// [荷兰region不支持IP地址组功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateIpGroupResponse UpdateIpGroup(UpdateIpGroupRequest updateIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIpGroupRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateIpGroupResponse>(response);
        }

        public SyncInvoker<UpdateIpGroupResponse> UpdateIpGroupInvoker(UpdateIpGroupRequest updateIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIpGroupRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpGroupRequest);
            return new SyncInvoker<UpdateIpGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateIpGroupResponse>);
        }
        
        /// <summary>
        /// 更新IP地址组的IP列表项
        ///
        /// 添加新的IP地址到IP地址组的IP列表中，或更新已有IP地址的描述。不支持通过该接口删除ip_list中已有的IP地址。
        /// 注意：
        /// - 0.0.0.0与0.0.0.0/32视为重复，0:0:0:0:0:0:0:1与::1与::1/128视为重复，只会保存其中一个。
        /// - 更新IP地址组中的ip_list会影响所有已关联的监听器，请谨慎操作。
        /// 
        /// [荷兰region不支持该API](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateIpListResponse UpdateIpList(UpdateIpListRequest updateIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIpListRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/iplist/create-or-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpListRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateIpListResponse>(response);
        }

        public SyncInvoker<UpdateIpListResponse> UpdateIpListInvoker(UpdateIpListRequest updateIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIpListRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/iplist/create-or-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpListRequest);
            return new SyncInvoker<UpdateIpListResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateIpListResponse>);
        }
        
    }
}