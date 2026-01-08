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
        /// 新增负载均衡器可用区
        ///
        /// 给负载均衡器新增可用区。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchAddAvailableZonesResponse> BatchAddAvailableZonesAsync(BatchAddAvailableZonesRequest batchAddAvailableZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchAddAvailableZonesRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/availability-zone/batch-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddAvailableZonesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchAddAvailableZonesResponse>(response);
        }

        public AsyncInvoker<BatchAddAvailableZonesResponse> BatchAddAvailableZonesAsyncInvoker(BatchAddAvailableZonesRequest batchAddAvailableZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchAddAvailableZonesRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/availability-zone/batch-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddAvailableZonesRequest);
            return new AsyncInvoker<BatchAddAvailableZonesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAddAvailableZonesResponse>);
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
        public async Task<BatchCreateLoadBalancersResponse> BatchCreateLoadBalancersAsync(BatchCreateLoadBalancersRequest batchCreateLoadBalancersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateLoadBalancersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateLoadBalancersResponse>(response);
        }

        public AsyncInvoker<BatchCreateLoadBalancersResponse> BatchCreateLoadBalancersAsyncInvoker(BatchCreateLoadBalancersRequest batchCreateLoadBalancersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateLoadBalancersRequest);
            return new AsyncInvoker<BatchCreateLoadBalancersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateLoadBalancersResponse>);
        }
        
        /// <summary>
        /// 批量创建后端服务器
        ///
        /// 在指定pool下批量创建后端服务器。一次最多创建200个。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateMembersResponse> BatchCreateMembersAsync(BatchCreateMembersRequest batchCreateMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateMembersRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateMembersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateMembersResponse>(response);
        }

        public AsyncInvoker<BatchCreateMembersResponse> BatchCreateMembersAsyncInvoker(BatchCreateMembersRequest batchCreateMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateMembersRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateMembersRequest);
            return new AsyncInvoker<BatchCreateMembersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateMembersResponse>);
        }
        
        /// <summary>
        /// 批量删除证书
        ///
        /// 批量删除证书。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteCertificatesResponse> BatchDeleteCertificatesAsync(BatchDeleteCertificatesRequest batchDeleteCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteCertificatesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteCertificatesResponse>(response);
        }

        public AsyncInvoker<BatchDeleteCertificatesResponse> BatchDeleteCertificatesAsyncInvoker(BatchDeleteCertificatesRequest batchDeleteCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteCertificatesRequest);
            return new AsyncInvoker<BatchDeleteCertificatesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteCertificatesResponse>);
        }
        
        /// <summary>
        /// 批量删监听器
        ///
        /// 批量删除监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteListenersResponse> BatchDeleteListenersAsync(BatchDeleteListenersRequest batchDeleteListenersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteListenersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteListenersResponse>(response);
        }

        public AsyncInvoker<BatchDeleteListenersResponse> BatchDeleteListenersAsyncInvoker(BatchDeleteListenersRequest batchDeleteListenersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteListenersRequest);
            return new AsyncInvoker<BatchDeleteListenersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteListenersResponse>);
        }
        
        /// <summary>
        /// 批量删除负载均衡器
        ///
        /// 批量删除负载均衡器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteLoadbalancersResponse> BatchDeleteLoadbalancersAsync(BatchDeleteLoadbalancersRequest batchDeleteLoadbalancersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteLoadbalancersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteLoadbalancersResponse>(response);
        }

        public AsyncInvoker<BatchDeleteLoadbalancersResponse> BatchDeleteLoadbalancersAsyncInvoker(BatchDeleteLoadbalancersRequest batchDeleteLoadbalancersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteLoadbalancersRequest);
            return new AsyncInvoker<BatchDeleteLoadbalancersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteLoadbalancersResponse>);
        }
        
        /// <summary>
        /// 批量删除后端服务器
        ///
        /// 在指定pool下批量删除后端服务器。一次最多添加200个。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteMembersResponse> BatchDeleteMembersAsync(BatchDeleteMembersRequest batchDeleteMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteMembersRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteMembersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteMembersResponse>(response);
        }

        public AsyncInvoker<BatchDeleteMembersResponse> BatchDeleteMembersAsyncInvoker(BatchDeleteMembersRequest batchDeleteMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteMembersRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteMembersRequest);
            return new AsyncInvoker<BatchDeleteMembersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteMembersResponse>);
        }
        
        /// <summary>
        /// 批量删除后端服务器组
        ///
        /// 批量删除后端服务器组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeletePoolsResponse> BatchDeletePoolsAsync(BatchDeletePoolsRequest batchDeletePoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeletePoolsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeletePoolsResponse>(response);
        }

        public AsyncInvoker<BatchDeletePoolsResponse> BatchDeletePoolsAsyncInvoker(BatchDeletePoolsRequest batchDeletePoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeletePoolsRequest);
            return new AsyncInvoker<BatchDeletePoolsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeletePoolsResponse>);
        }
        
        /// <summary>
        /// 批量将IP地址从LB实例域名解析中移除
        ///
        /// 批量将IP地址从LB实例域名解析中移除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDisableDomainIPsResponse> BatchDisableDomainIPsAsync(BatchDisableDomainIPsRequest batchDisableDomainIPsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDisableDomainIPsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/dns/ips/batch-disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDisableDomainIPsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDisableDomainIPsResponse>(response);
        }

        public AsyncInvoker<BatchDisableDomainIPsResponse> BatchDisableDomainIPsAsyncInvoker(BatchDisableDomainIPsRequest batchDisableDomainIPsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDisableDomainIPsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/dns/ips/batch-disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDisableDomainIPsRequest);
            return new AsyncInvoker<BatchDisableDomainIPsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDisableDomainIPsResponse>);
        }
        
        /// <summary>
        /// 批量将IP地址加入LB实例域名解析中
        ///
        /// 批量将IP地址加入LB实例域名解析中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchEnableDomainIPsResponse> BatchEnableDomainIPsAsync(BatchEnableDomainIPsRequest batchEnableDomainIPsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchEnableDomainIPsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/dns/ips/batch-enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchEnableDomainIPsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchEnableDomainIPsResponse>(response);
        }

        public AsyncInvoker<BatchEnableDomainIPsResponse> BatchEnableDomainIPsAsyncInvoker(BatchEnableDomainIPsRequest batchEnableDomainIPsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchEnableDomainIPsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/dns/ips/batch-enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchEnableDomainIPsRequest);
            return new AsyncInvoker<BatchEnableDomainIPsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchEnableDomainIPsResponse>);
        }
        
        /// <summary>
        /// 移除负载均衡器可用区
        ///
        /// 移除负载均衡器的可用区。
        /// &gt; 移除可用区可能导致已有连接断开，请谨慎操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchRemoveAvailableZonesResponse> BatchRemoveAvailableZonesAsync(BatchRemoveAvailableZonesRequest batchRemoveAvailableZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchRemoveAvailableZonesRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/availability-zone/batch-remove", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRemoveAvailableZonesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchRemoveAvailableZonesResponse>(response);
        }

        public AsyncInvoker<BatchRemoveAvailableZonesResponse> BatchRemoveAvailableZonesAsyncInvoker(BatchRemoveAvailableZonesRequest batchRemoveAvailableZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchRemoveAvailableZonesRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/availability-zone/batch-remove", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRemoveAvailableZonesRequest);
            return new AsyncInvoker<BatchRemoveAvailableZonesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRemoveAvailableZonesResponse>);
        }
        
        /// <summary>
        /// 批量更新后端服务器
        ///
        /// 在指定pool下批量更新后端服务器。一次最多添加200个。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateMembersResponse> BatchUpdateMembersAsync(BatchUpdateMembersRequest batchUpdateMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateMembersRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateMembersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchUpdateMembersResponse>(response);
        }

        public AsyncInvoker<BatchUpdateMembersResponse> BatchUpdateMembersAsyncInvoker(BatchUpdateMembersRequest batchUpdateMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateMembersRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateMembersRequest);
            return new AsyncInvoker<BatchUpdateMembersResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchUpdateMembersResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/batch-update-priority", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdatePoliciesPriorityRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchUpdatePoliciesPriorityResponse>(response);
        }

        public AsyncInvoker<BatchUpdatePoliciesPriorityResponse> BatchUpdatePoliciesPriorityAsyncInvoker(BatchUpdatePoliciesPriorityRequest batchUpdatePoliciesPriorityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/batch-update-priority", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdatePoliciesPriorityRequest);
            return new AsyncInvoker<BatchUpdatePoliciesPriorityResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchUpdatePoliciesPriorityResponse>);
        }
        
        /// <summary>
        /// 变更监听器标签列表
        ///
        /// 批量添加或删除指定监听器器标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeListenerTagsResponse> ChangeListenerTagsAsync(ChangeListenerTagsRequest changeListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeListenerTagsRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/listeners/{listener_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeListenerTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ChangeListenerTagsResponse>(response);
        }

        public AsyncInvoker<ChangeListenerTagsResponse> ChangeListenerTagsAsyncInvoker(ChangeListenerTagsRequest changeListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeListenerTagsRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/listeners/{listener_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeListenerTagsRequest);
            return new AsyncInvoker<ChangeListenerTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ChangeListenerTagsResponse>);
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
        public async Task<ChangeLoadbalancerChargeModeResponse> ChangeLoadbalancerChargeModeAsync(ChangeLoadbalancerChargeModeRequest changeLoadbalancerChargeModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/change-charge-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeLoadbalancerChargeModeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeLoadbalancerChargeModeResponse>(response);
        }

        public AsyncInvoker<ChangeLoadbalancerChargeModeResponse> ChangeLoadbalancerChargeModeAsyncInvoker(ChangeLoadbalancerChargeModeRequest changeLoadbalancerChargeModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/change-charge-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeLoadbalancerChargeModeRequest);
            return new AsyncInvoker<ChangeLoadbalancerChargeModeResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeLoadbalancerChargeModeResponse>);
        }
        
        /// <summary>
        /// 变更负载均衡器标签列表
        ///
        /// 批量添加或删除指定负载均衡器标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeLoadbalancerTagsResponse> ChangeLoadbalancerTagsAsync(ChangeLoadbalancerTagsRequest changeLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeLoadbalancerTagsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/loadbalancers/{loadbalancer_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeLoadbalancerTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ChangeLoadbalancerTagsResponse>(response);
        }

        public AsyncInvoker<ChangeLoadbalancerTagsResponse> ChangeLoadbalancerTagsAsyncInvoker(ChangeLoadbalancerTagsRequest changeLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeLoadbalancerTagsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/loadbalancers/{loadbalancer_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeLoadbalancerTagsRequest);
            return new AsyncInvoker<ChangeLoadbalancerTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ChangeLoadbalancerTagsResponse>);
        }
        
        /// <summary>
        /// 复制已有监听器
        ///
        /// 复制已有的监听器到同VPC内的负载均衡器。
        /// - 仅支持同VPC实例间使用监听器复制功能。
        /// - 不支持网关型LB下监听器进行复制，也不支持复制到网关型LB下。
        /// - 仅同类型实例之间可以使用监听器复制功能。
        /// - 对复制的源监听器有如下限制：后端服务器总数不能超过1000；转发策略总数不能超过100。
        /// - 源监听器所在负载均衡器和目的监听器所在负载均衡器不能处于冻结、迁移状态。
        /// - 源监听器中若配置quic_config，复制后为null。
        /// - 七层转发策略配置为重定向到监听器，该转发策略不会进行复制。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CloneListenerResponse> CloneListenerAsync(CloneListenerRequest cloneListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cloneListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}/clone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cloneListenerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CloneListenerResponse>(response);
        }

        public AsyncInvoker<CloneListenerResponse> CloneListenerAsyncInvoker(CloneListenerRequest cloneListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cloneListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}/clone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cloneListenerRequest);
            return new AsyncInvoker<CloneListenerResponse>(this, "POST", request, JsonUtils.DeSerialize<CloneListenerResponse>);
        }
        
        /// <summary>
        /// 复制已有负载均衡器
        ///
        /// 复制已有的负载均衡器实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CloneLoadbalancerResponse> CloneLoadbalancerAsync(CloneLoadbalancerRequest cloneLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cloneLoadbalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/clone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cloneLoadbalancerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CloneLoadbalancerResponse>(response);
        }

        public AsyncInvoker<CloneLoadbalancerResponse> CloneLoadbalancerAsyncInvoker(CloneLoadbalancerRequest cloneLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cloneLoadbalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/clone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cloneLoadbalancerRequest);
            return new AsyncInvoker<CloneLoadbalancerResponse>(this, "POST", request, JsonUtils.DeSerialize<CloneLoadbalancerResponse>);
        }
        
        /// <summary>
        /// 创建证书
        ///
        /// 创建用于弹性负载均衡器HTTPS/TLS/QUIC协议监听器的证书。支持关联云证书与管理服务(CCM)的证书，或者使用自有证书。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCertificateResponse> CreateCertificateAsync(CreateCertificateRequest createCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCertificateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateCertificateResponse>(response);
        }

        public AsyncInvoker<CreateCertificateResponse> CreateCertificateAsyncInvoker(CreateCertificateRequest createCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCertificateRequest);
            return new AsyncInvoker<CreateCertificateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCertificateResponse>);
        }
        
        /// <summary>
        /// 修改证书私钥字段回显开关
        ///
        /// 开启或关闭ELB证书的私钥字段回显开关。该开关用于设置各个ELB证书接口的响应字段private_key和enc_private_key是否展示。若开启则证书的详情、列表、更新和创建接口返回私钥内容；不开启则返回脱敏后内容（******）。该开关影响整个租户项目（project），默认开启。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCertificatePrivateKeyEchoResponse> CreateCertificatePrivateKeyEchoAsync(CreateCertificatePrivateKeyEchoRequest createCertificatePrivateKeyEchoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/settings/private-key-echo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCertificatePrivateKeyEchoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateCertificatePrivateKeyEchoResponse>(response);
        }

        public AsyncInvoker<CreateCertificatePrivateKeyEchoResponse> CreateCertificatePrivateKeyEchoAsyncInvoker(CreateCertificatePrivateKeyEchoRequest createCertificatePrivateKeyEchoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/settings/private-key-echo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCertificatePrivateKeyEchoRequest);
            return new AsyncInvoker<CreateCertificatePrivateKeyEchoResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCertificatePrivateKeyEchoResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createHealthMonitorRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateHealthMonitorResponse>(response);
        }

        public AsyncInvoker<CreateHealthMonitorResponse> CreateHealthMonitorAsyncInvoker(CreateHealthMonitorRequest createHealthMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createHealthMonitorRequest);
            return new AsyncInvoker<CreateHealthMonitorResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHealthMonitorResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createL7PolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateL7PolicyResponse>(response);
        }

        public AsyncInvoker<CreateL7PolicyResponse> CreateL7PolicyAsyncInvoker(CreateL7PolicyRequest createL7PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createL7PolicyRequest);
            return new AsyncInvoker<CreateL7PolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateL7PolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createL7RuleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createL7RuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateL7RuleResponse>(response);
        }

        public AsyncInvoker<CreateL7RuleResponse> CreateL7RuleAsyncInvoker(CreateL7RuleRequest createL7RuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createL7RuleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createL7RuleRequest);
            return new AsyncInvoker<CreateL7RuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateL7RuleResponse>);
        }
        
        /// <summary>
        /// 创建监听器
        ///
        /// 创建监听器。支持通过该接口创建独享型及共享型LB实例下的监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateListenerResponse> CreateListenerAsync(CreateListenerRequest createListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createListenerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateListenerResponse>(response);
        }

        public AsyncInvoker<CreateListenerResponse> CreateListenerAsyncInvoker(CreateListenerRequest createListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createListenerRequest);
            return new AsyncInvoker<CreateListenerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateListenerResponse>);
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
        /// - 若要创建gateway类型的负载均衡器，则需要：
        ///    - 指定loadbalancer_type&#x3D;\&quot;gateway\&quot;，且不支持指定vip_address，ipv6_vip_address。
        ///    - vip_subnet_cidr_id和ipv6_subnet_cidr_id两者不能都为空，如果两者都传入，则必须属于同一子网。
        ///    - 不支持创建公网gateway类型LB。
        ///    - 不支持传入autoscaling字段，不支持l4_flavor_id和l7_flavor_id。
        ///    - 必须要指定网关型规格，通过参数gw_flavor_id传入。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest createLoadBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLoadBalancerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateLoadBalancerResponse>(response);
        }

        public AsyncInvoker<CreateLoadBalancerResponse> CreateLoadBalancerAsyncInvoker(CreateLoadBalancerRequest createLoadBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLoadBalancerRequest);
            return new AsyncInvoker<CreateLoadBalancerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLoadBalancerResponse>);
        }
        
        /// <summary>
        /// 创建云日志
        ///
        /// 创建云日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLogtankResponse> CreateLogtankAsync(CreateLogtankRequest createLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLogtankRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateLogtankResponse>(response);
        }

        public AsyncInvoker<CreateLogtankResponse> CreateLogtankAsyncInvoker(CreateLogtankRequest createLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLogtankRequest);
            return new AsyncInvoker<CreateLogtankResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLogtankResponse>);
        }
        
        /// <summary>
        /// 创建主备后端服务器组
        ///
        /// 创建主备后端服务器组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMasterSlavePoolResponse> CreateMasterSlavePoolAsync(CreateMasterSlavePoolRequest createMasterSlavePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/master-slave-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMasterSlavePoolRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateMasterSlavePoolResponse>(response);
        }

        public AsyncInvoker<CreateMasterSlavePoolResponse> CreateMasterSlavePoolAsyncInvoker(CreateMasterSlavePoolRequest createMasterSlavePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/master-slave-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMasterSlavePoolRequest);
            return new AsyncInvoker<CreateMasterSlavePoolResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMasterSlavePoolResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMemberRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateMemberResponse>(response);
        }

        public AsyncInvoker<CreateMemberResponse> CreateMemberAsyncInvoker(CreateMemberRequest createMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMemberRequest);
            return new AsyncInvoker<CreateMemberResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMemberResponse>);
        }
        
        /// <summary>
        /// 创建后端服务器检测任务
        ///
        /// 创建后端服务器检测任务。包括后端服务器的配置、ACL规则和安全组规则检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMemberHealthCheckJobResponse> CreateMemberHealthCheckJobAsync(CreateMemberHealthCheckJobRequest createMemberHealthCheckJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMemberHealthCheckJobRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/members/{member_id}/health-check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMemberHealthCheckJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateMemberHealthCheckJobResponse>(response);
        }

        public AsyncInvoker<CreateMemberHealthCheckJobResponse> CreateMemberHealthCheckJobAsyncInvoker(CreateMemberHealthCheckJobRequest createMemberHealthCheckJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMemberHealthCheckJobRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/members/{member_id}/health-check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMemberHealthCheckJobRequest);
            return new AsyncInvoker<CreateMemberHealthCheckJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMemberHealthCheckJobResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPoolRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePoolResponse>(response);
        }

        public AsyncInvoker<CreatePoolResponse> CreatePoolAsyncInvoker(CreatePoolRequest createPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPoolRequest);
            return new AsyncInvoker<CreatePoolResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePoolResponse>);
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
        public async Task<CreateSecurityPolicyResponse> CreateSecurityPolicyAsync(CreateSecurityPolicyRequest createSecurityPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSecurityPolicyResponse>(response);
        }

        public AsyncInvoker<CreateSecurityPolicyResponse> CreateSecurityPolicyAsyncInvoker(CreateSecurityPolicyRequest createSecurityPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityPolicyRequest);
            return new AsyncInvoker<CreateSecurityPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSecurityPolicyResponse>);
        }
        
        /// <summary>
        /// 删除证书
        ///
        /// 删除ELB证书。若是删除source&#x3D;scm的证书，关联的云证书与管理服务（CCM）中的证书不会被删除。若想删除已关联到监听器的证书，则需要先解除监听器和证书的绑定关系。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest deleteCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCertificateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCertificateResponse>(response);
        }

        public AsyncInvoker<DeleteCertificateResponse> DeleteCertificateAsyncInvoker(DeleteCertificateRequest deleteCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCertificateRequest);
            return new AsyncInvoker<DeleteCertificateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCertificateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHealthMonitorRequest.HealthmonitorId, out var valueOfHealthmonitorId)) urlParam.Add("healthmonitor_id", valueOfHealthmonitorId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHealthMonitorRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteHealthMonitorResponse>(response);
        }

        public AsyncInvoker<DeleteHealthMonitorResponse> DeleteHealthMonitorAsyncInvoker(DeleteHealthMonitorRequest deleteHealthMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHealthMonitorRequest.HealthmonitorId, out var valueOfHealthmonitorId)) urlParam.Add("healthmonitor_id", valueOfHealthmonitorId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHealthMonitorRequest);
            return new AsyncInvoker<DeleteHealthMonitorResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteHealthMonitorResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteL7PolicyRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7PolicyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteL7PolicyResponse>(response);
        }

        public AsyncInvoker<DeleteL7PolicyResponse> DeleteL7PolicyAsyncInvoker(DeleteL7PolicyRequest deleteL7PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteL7PolicyRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7PolicyRequest);
            return new AsyncInvoker<DeleteL7PolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteL7PolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteL7RuleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            if (StringUtils.TryConvertToNonEmptyString(deleteL7RuleRequest.L7ruleId, out var valueOfL7ruleId)) urlParam.Add("l7rule_id", valueOfL7ruleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7RuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteL7RuleResponse>(response);
        }

        public AsyncInvoker<DeleteL7RuleResponse> DeleteL7RuleAsyncInvoker(DeleteL7RuleRequest deleteL7RuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteL7RuleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            if (StringUtils.TryConvertToNonEmptyString(deleteL7RuleRequest.L7ruleId, out var valueOfL7ruleId)) urlParam.Add("l7rule_id", valueOfL7ruleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7RuleRequest);
            return new AsyncInvoker<DeleteL7RuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteL7RuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteListenerResponse>(response);
        }

        public AsyncInvoker<DeleteListenerResponse> DeleteListenerAsyncInvoker(DeleteListenerRequest deleteListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerRequest);
            return new AsyncInvoker<DeleteListenerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteListenerResponse>);
        }
        
        /// <summary>
        /// 级联删除监听器
        ///
        /// 删除监听器且级联删除其下子资源（删除监听器、转发策略等，解绑后端服务器组）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteListenerForceResponse> DeleteListenerForceAsync(DeleteListenerForceRequest deleteListenerForceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteListenerForceRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}/force", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerForceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteListenerForceResponse>(response);
        }

        public AsyncInvoker<DeleteListenerForceResponse> DeleteListenerForceAsyncInvoker(DeleteListenerForceRequest deleteListenerForceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteListenerForceRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}/force", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerForceRequest);
            return new AsyncInvoker<DeleteListenerForceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteListenerForceResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLoadBalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadBalancerRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLoadBalancerResponse>(response);
        }

        public AsyncInvoker<DeleteLoadBalancerResponse> DeleteLoadBalancerAsyncInvoker(DeleteLoadBalancerRequest deleteLoadBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLoadBalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadBalancerRequest);
            return new AsyncInvoker<DeleteLoadBalancerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLoadBalancerResponse>);
        }
        
        /// <summary>
        /// 级联删除负载均衡器及关联EIP
        ///
        /// 删除负载均衡器且级联删除其下子资源（删除负载均衡器及其绑定的监听器、后端服务器等一系列资源）。以及根据需要删除或解绑后端服务器组和LB关联的EIP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLoadBalancerCascadeResponse> DeleteLoadBalancerCascadeAsync(DeleteLoadBalancerCascadeRequest deleteLoadBalancerCascadeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLoadBalancerCascadeRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/delete-cascade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteLoadBalancerCascadeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteLoadBalancerCascadeResponse>(response);
        }

        public AsyncInvoker<DeleteLoadBalancerCascadeResponse> DeleteLoadBalancerCascadeAsyncInvoker(DeleteLoadBalancerCascadeRequest deleteLoadBalancerCascadeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLoadBalancerCascadeRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/delete-cascade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteLoadBalancerCascadeRequest);
            return new AsyncInvoker<DeleteLoadBalancerCascadeResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteLoadBalancerCascadeResponse>);
        }
        
        /// <summary>
        /// 级联删除负载均衡器
        ///
        /// 删除负载均衡器且级联删除其下子资源（删除负载均衡器及其绑定的监听器、后端服务器组、后端服务器等一系列资源）。
        /// - 若LB关联了EIP，则只解绑EIP，不会删除EIP。
        /// - 若LB已开启了误删保护开关，则级联删除失败。
        /// - 若LB下任意一个后端服务器组开启了误删保护开关，则级联删除失败。
        /// - 修改保护开关开启不影响级联删除，仍能正常删除。
        /// [- 若已开启多挂特性，且关联了多个LB，则只做解绑；否则删除。
        /// - 若是共享型LB下的后端服务器组，无论是否多挂都只删除，不解绑。](tag:hws,hws_hk)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLoadBalancerForceResponse> DeleteLoadBalancerForceAsync(DeleteLoadBalancerForceRequest deleteLoadBalancerForceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLoadBalancerForceRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/force-elb", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadBalancerForceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLoadBalancerForceResponse>(response);
        }

        public AsyncInvoker<DeleteLoadBalancerForceResponse> DeleteLoadBalancerForceAsyncInvoker(DeleteLoadBalancerForceRequest deleteLoadBalancerForceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLoadBalancerForceRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/force-elb", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadBalancerForceRequest);
            return new AsyncInvoker<DeleteLoadBalancerForceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLoadBalancerForceResponse>);
        }
        
        /// <summary>
        /// 删除云日志
        ///
        /// 删除云日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLogtankResponse> DeleteLogtankAsync(DeleteLogtankRequest deleteLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogtankRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLogtankResponse>(response);
        }

        public AsyncInvoker<DeleteLogtankResponse> DeleteLogtankAsyncInvoker(DeleteLogtankRequest deleteLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogtankRequest);
            return new AsyncInvoker<DeleteLogtankResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLogtankResponse>);
        }
        
        /// <summary>
        /// 删除主备后端服务器组
        ///
        /// 删除主备后端服务器组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteMasterSlavePoolResponse> DeleteMasterSlavePoolAsync(DeleteMasterSlavePoolRequest deleteMasterSlavePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMasterSlavePoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/master-slave-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMasterSlavePoolRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMasterSlavePoolResponse>(response);
        }

        public AsyncInvoker<DeleteMasterSlavePoolResponse> DeleteMasterSlavePoolAsyncInvoker(DeleteMasterSlavePoolRequest deleteMasterSlavePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMasterSlavePoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/master-slave-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMasterSlavePoolRequest);
            return new AsyncInvoker<DeleteMasterSlavePoolResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMasterSlavePoolResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMemberRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMemberResponse>(response);
        }

        public AsyncInvoker<DeleteMemberResponse> DeleteMemberAsyncInvoker(DeleteMemberRequest deleteMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMemberRequest);
            return new AsyncInvoker<DeleteMemberResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMemberResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePoolRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePoolResponse>(response);
        }

        public AsyncInvoker<DeletePoolResponse> DeletePoolAsyncInvoker(DeletePoolRequest deletePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePoolRequest);
            return new AsyncInvoker<DeletePoolResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePoolResponse>);
        }
        
        /// <summary>
        /// 级联删除后端服务器组
        ///
        /// 级联删除后端服务器组，包含在此后端服务器组下的所有后端服务器和健康检查也将被删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePoolCascadeResponse> DeletePoolCascadeAsync(DeletePoolCascadeRequest deletePoolCascadeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePoolCascadeRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/delete-cascade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePoolCascadeRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePoolCascadeResponse>(response);
        }

        public AsyncInvoker<DeletePoolCascadeResponse> DeletePoolCascadeAsyncInvoker(DeletePoolCascadeRequest deletePoolCascadeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePoolCascadeRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/delete-cascade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePoolCascadeRequest);
            return new AsyncInvoker<DeletePoolCascadeResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePoolCascadeResponse>);
        }
        
        /// <summary>
        /// 销毁回收站负载均衡器
        ///
        /// 销毁回收站负载均衡器。销毁后无法再还原。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRecycleLoadBalancerResponse> DeleteRecycleLoadBalancerAsync(DeleteRecycleLoadBalancerRequest deleteRecycleLoadBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRecycleLoadBalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecycleLoadBalancerRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRecycleLoadBalancerResponse>(response);
        }

        public AsyncInvoker<DeleteRecycleLoadBalancerResponse> DeleteRecycleLoadBalancerAsyncInvoker(DeleteRecycleLoadBalancerRequest deleteRecycleLoadBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRecycleLoadBalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecycleLoadBalancerRequest);
            return new AsyncInvoker<DeleteRecycleLoadBalancerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRecycleLoadBalancerResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecurityPolicyRequest.SecurityPolicyId, out var valueOfSecurityPolicyId)) urlParam.Add("security_policy_id", valueOfSecurityPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityPolicyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecurityPolicyResponse>(response);
        }

        public AsyncInvoker<DeleteSecurityPolicyResponse> DeleteSecurityPolicyAsyncInvoker(DeleteSecurityPolicyRequest deleteSecurityPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecurityPolicyRequest.SecurityPolicyId, out var valueOfSecurityPolicyId)) urlParam.Add("security_policy_id", valueOfSecurityPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityPolicyRequest);
            return new AsyncInvoker<DeleteSecurityPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecurityPolicyResponse>);
        }
        
        /// <summary>
        /// 查询转发规则列表
        ///
        /// 查询当前项目下的转发规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAllL7RulesResponse> ListAllL7RulesAsync(ListAllL7RulesRequest listAllL7RulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllL7RulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAllL7RulesResponse>(response);
        }

        public AsyncInvoker<ListAllL7RulesResponse> ListAllL7RulesAsyncInvoker(ListAllL7RulesRequest listAllL7RulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllL7RulesRequest);
            return new AsyncInvoker<ListAllL7RulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllL7RulesResponse>);
        }
        
        /// <summary>
        /// 后端服务器全局列表
        ///
        /// 查询当前项目下的后端服务器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAllMembersResponse> ListAllMembersAsync(ListAllMembersRequest listAllMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllMembersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAllMembersResponse>(response);
        }

        public AsyncInvoker<ListAllMembersResponse> ListAllMembersAsyncInvoker(ListAllMembersRequest listAllMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllMembersRequest);
            return new AsyncInvoker<ListAllMembersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllMembersResponse>);
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
        public async Task<ListAvailabilityZonesResponse> ListAvailabilityZonesAsync(ListAvailabilityZonesRequest listAvailabilityZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/availability-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZonesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAvailabilityZonesResponse>(response);
        }

        public AsyncInvoker<ListAvailabilityZonesResponse> ListAvailabilityZonesAsyncInvoker(ListAvailabilityZonesRequest listAvailabilityZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/availability-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZonesRequest);
            return new AsyncInvoker<ListAvailabilityZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailabilityZonesResponse>);
        }
        
        /// <summary>
        /// 查询证书列表
        ///
        /// 查询ELB证书列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCertificatesResponse> ListCertificatesAsync(ListCertificatesRequest listCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCertificatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCertificatesResponse>(response);
        }

        public AsyncInvoker<ListCertificatesResponse> ListCertificatesAsyncInvoker(ListCertificatesRequest listCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCertificatesRequest);
            return new AsyncInvoker<ListCertificatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCertificatesResponse>);
        }
        
        /// <summary>
        /// 查询负载均衡器ip的域名配置信息
        ///
        /// 查询负载均衡器ip的域名配置信息，即负载均衡器的ip是否加入了域名解析。
        /// 注意：当负载均衡器的公网域名和私网域名都没有打开时，该接口返回空列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDomainIPsResponse> ListDomainIPsAsync(ListDomainIPsRequest listDomainIPsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDomainIPsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/dns/ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainIPsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDomainIPsResponse>(response);
        }

        public AsyncInvoker<ListDomainIPsResponse> ListDomainIPsAsyncInvoker(ListDomainIPsRequest listDomainIPsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDomainIPsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/dns/ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainIPsRequest);
            return new AsyncInvoker<ListDomainIPsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainIPsResponse>);
        }
        
        /// <summary>
        /// 查询当前租户ELB服务的特性配置
        ///
        /// 查询当前租户ELB服务的特性配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFeatureConfigsResponse> ListFeatureConfigsAsync(ListFeatureConfigsRequest listFeatureConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/feature/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFeatureConfigsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFeatureConfigsResponse>(response);
        }

        public AsyncInvoker<ListFeatureConfigsResponse> ListFeatureConfigsAsyncInvoker(ListFeatureConfigsRequest listFeatureConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/feature/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFeatureConfigsRequest);
            return new AsyncInvoker<ListFeatureConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFeatureConfigsResponse>);
        }
        
        /// <summary>
        /// 查询规格列表
        ///
        /// 查询当前局点可用的负载均衡器规格。用于在创建独享型负载均衡器时指定4层或7层规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFlavorsResponse> ListFlavorsAsync(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }

        public AsyncInvoker<ListFlavorsResponse> ListFlavorsAsyncInvoker(ListFlavorsRequest listFlavorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/flavors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            return new AsyncInvoker<ListFlavorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlavorsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHealthMonitorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHealthMonitorsResponse>(response);
        }

        public AsyncInvoker<ListHealthMonitorsResponse> ListHealthMonitorsAsyncInvoker(ListHealthMonitorsRequest listHealthMonitorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHealthMonitorsRequest);
            return new AsyncInvoker<ListHealthMonitorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHealthMonitorsResponse>);
        }
        
        /// <summary>
        /// 查询异步任务的job列表
        ///
        /// 用于查询实例复制、实例升级等异步接口任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListJobsResponse>(response);
        }

        public AsyncInvoker<ListJobsResponse> ListJobsAsyncInvoker(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            return new AsyncInvoker<ListJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7PoliciesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListL7PoliciesResponse>(response);
        }

        public AsyncInvoker<ListL7PoliciesResponse> ListL7PoliciesAsyncInvoker(ListL7PoliciesRequest listL7PoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7PoliciesRequest);
            return new AsyncInvoker<ListL7PoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListL7PoliciesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listL7RulesRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7RulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListL7RulesResponse>(response);
        }

        public AsyncInvoker<ListL7RulesResponse> ListL7RulesAsyncInvoker(ListL7RulesRequest listL7RulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listL7RulesRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7RulesRequest);
            return new AsyncInvoker<ListL7RulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListL7RulesResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/listeners/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenerTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListListenerTagsResponse>(response);
        }

        public AsyncInvoker<ListListenerTagsResponse> ListListenerTagsAsyncInvoker(ListListenerTagsRequest listListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/listeners/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenerTagsRequest);
            return new AsyncInvoker<ListListenerTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListListenerTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListListenersResponse>(response);
        }

        public AsyncInvoker<ListListenersResponse> ListListenersAsyncInvoker(ListListenersRequest listListenersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersRequest);
            return new AsyncInvoker<ListListenersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListListenersResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadBalancersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLoadBalancersResponse>(response);
        }

        public AsyncInvoker<ListLoadBalancersResponse> ListLoadBalancersAsyncInvoker(ListLoadBalancersRequest listLoadBalancersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadBalancersRequest);
            return new AsyncInvoker<ListLoadBalancersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLoadBalancersResponse>);
        }
        
        /// <summary>
        /// 查询指定ELB实例的特性配置
        ///
        /// 查询指定ELB实例的特性配置情况。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLoadbalancerFeatureResponse> ListLoadbalancerFeatureAsync(ListLoadbalancerFeatureRequest listLoadbalancerFeatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLoadbalancerFeatureRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/features", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancerFeatureRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLoadbalancerFeatureResponse>(response);
        }

        public AsyncInvoker<ListLoadbalancerFeatureResponse> ListLoadbalancerFeatureAsyncInvoker(ListLoadbalancerFeatureRequest listLoadbalancerFeatureRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLoadbalancerFeatureRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/features", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancerFeatureRequest);
            return new AsyncInvoker<ListLoadbalancerFeatureResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLoadbalancerFeatureResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/loadbalancers/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancerTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLoadbalancerTagsResponse>(response);
        }

        public AsyncInvoker<ListLoadbalancerTagsResponse> ListLoadbalancerTagsAsyncInvoker(ListLoadbalancerTagsRequest listLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/loadbalancers/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadbalancerTagsRequest);
            return new AsyncInvoker<ListLoadbalancerTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLoadbalancerTagsResponse>);
        }
        
        /// <summary>
        /// 查询云日志列表
        ///
        /// 查询云日志列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLogtanksResponse> ListLogtanksAsync(ListLogtanksRequest listLogtanksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogtanksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLogtanksResponse>(response);
        }

        public AsyncInvoker<ListLogtanksResponse> ListLogtanksAsyncInvoker(ListLogtanksRequest listLogtanksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogtanksRequest);
            return new AsyncInvoker<ListLogtanksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLogtanksResponse>);
        }
        
        /// <summary>
        /// 查询主备后端服务器组列表
        ///
        /// 主备后端服务器组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMasterSlavePoolsResponse> ListMasterSlavePoolsAsync(ListMasterSlavePoolsRequest listMasterSlavePoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/master-slave-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMasterSlavePoolsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMasterSlavePoolsResponse>(response);
        }

        public AsyncInvoker<ListMasterSlavePoolsResponse> ListMasterSlavePoolsAsyncInvoker(ListMasterSlavePoolsRequest listMasterSlavePoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/master-slave-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMasterSlavePoolsRequest);
            return new AsyncInvoker<ListMasterSlavePoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMasterSlavePoolsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMembersRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMembersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMembersResponse>(response);
        }

        public AsyncInvoker<ListMembersResponse> ListMembersAsyncInvoker(ListMembersRequest listMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMembersRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMembersRequest);
            return new AsyncInvoker<ListMembersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMembersResponse>);
        }
        
        /// <summary>
        /// 查询后端服务器组列表
        ///
        /// 查询后端服务器组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPoolsResponse> ListPoolsAsync(ListPoolsRequest listPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPoolsResponse>(response);
        }

        public AsyncInvoker<ListPoolsResponse> ListPoolsAsyncInvoker(ListPoolsRequest listPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolsRequest);
            return new AsyncInvoker<ListPoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPoolsResponse>);
        }
        
        /// <summary>
        /// 查询配额使用详情
        ///
        /// 查询负载均衡服务相关的各类资源的当前配额和已使用配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListQuotaDetailsResponse> ListQuotaDetailsAsync(ListQuotaDetailsRequest listQuotaDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/quotas/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotaDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListQuotaDetailsResponse>(response);
        }

        public AsyncInvoker<ListQuotaDetailsResponse> ListQuotaDetailsAsyncInvoker(ListQuotaDetailsRequest listQuotaDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/quotas/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotaDetailsRequest);
            return new AsyncInvoker<ListQuotaDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQuotaDetailsResponse>);
        }
        
        /// <summary>
        /// 查询回收站负载均衡器列表
        ///
        /// 查询回收站负载均衡器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecycleBinLoadBalancersResponse> ListRecycleBinLoadBalancersAsync(ListRecycleBinLoadBalancersRequest listRecycleBinLoadBalancersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin/loadbalancers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecycleBinLoadBalancersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRecycleBinLoadBalancersResponse>(response);
        }

        public AsyncInvoker<ListRecycleBinLoadBalancersResponse> ListRecycleBinLoadBalancersAsyncInvoker(ListRecycleBinLoadBalancersRequest listRecycleBinLoadBalancersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin/loadbalancers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecycleBinLoadBalancersRequest);
            return new AsyncInvoker<ListRecycleBinLoadBalancersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecycleBinLoadBalancersResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityPoliciesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSecurityPoliciesResponse>(response);
        }

        public AsyncInvoker<ListSecurityPoliciesResponse> ListSecurityPoliciesAsyncInvoker(ListSecurityPoliciesRequest listSecurityPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityPoliciesRequest);
            return new AsyncInvoker<ListSecurityPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecurityPoliciesResponse>);
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
        public async Task<ListSystemSecurityPoliciesResponse> ListSystemSecurityPoliciesAsync(ListSystemSecurityPoliciesRequest listSystemSecurityPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/system-security-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSystemSecurityPoliciesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSystemSecurityPoliciesResponse>(response);
        }

        public AsyncInvoker<ListSystemSecurityPoliciesResponse> ListSystemSecurityPoliciesAsyncInvoker(ListSystemSecurityPoliciesRequest listSystemSecurityPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/system-security-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSystemSecurityPoliciesRequest);
            return new AsyncInvoker<ListSystemSecurityPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSystemSecurityPoliciesResponse>);
        }
        
        /// <summary>
        /// 还原负载均衡器
        ///
        /// 从回收站中还原负载均衡器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestoreLoadbalancerResponse> RestoreLoadbalancerAsync(RestoreLoadbalancerRequest restoreLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreLoadbalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin/loadbalancers/{loadbalancer_id}/recover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreLoadbalancerRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<RestoreLoadbalancerResponse>(response);
        }

        public AsyncInvoker<RestoreLoadbalancerResponse> RestoreLoadbalancerAsyncInvoker(RestoreLoadbalancerRequest restoreLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restoreLoadbalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin/loadbalancers/{loadbalancer_id}/recover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreLoadbalancerRequest);
            return new AsyncInvoker<RestoreLoadbalancerResponse>(this, "PUT", request, JsonUtils.DeSerialize<RestoreLoadbalancerResponse>);
        }
        
        /// <summary>
        /// 查询证书详情
        ///
        /// 查询ELB证书详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCertificateResponse> ShowCertificateAsync(ShowCertificateRequest showCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCertificateResponse>(response);
        }

        public AsyncInvoker<ShowCertificateResponse> ShowCertificateAsyncInvoker(ShowCertificateRequest showCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificateRequest);
            return new AsyncInvoker<ShowCertificateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCertificateResponse>);
        }
        
        /// <summary>
        /// 查询证书私钥字段回显开关
        ///
        /// 查询证书私钥回显开关的状态。该开关用于设置各个ELB证书接口的响应字段private_key和enc_private_key是否展示。若开启则这些接口返回私钥内容；不开启则返回脱敏后内容（******）。该开关影响整个租户项目（project），默认开启。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCertificatePrivateKeyEchoResponse> ShowCertificatePrivateKeyEchoAsync(ShowCertificatePrivateKeyEchoRequest showCertificatePrivateKeyEchoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/settings/private-key-echo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificatePrivateKeyEchoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCertificatePrivateKeyEchoResponse>(response);
        }

        public AsyncInvoker<ShowCertificatePrivateKeyEchoResponse> ShowCertificatePrivateKeyEchoAsyncInvoker(ShowCertificatePrivateKeyEchoRequest showCertificatePrivateKeyEchoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/settings/private-key-echo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificatePrivateKeyEchoRequest);
            return new AsyncInvoker<ShowCertificatePrivateKeyEchoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCertificatePrivateKeyEchoResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFlavorRequest.FlavorId, out var valueOfFlavorId)) urlParam.Add("flavor_id", valueOfFlavorId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/flavors/{flavor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlavorRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFlavorResponse>(response);
        }

        public AsyncInvoker<ShowFlavorResponse> ShowFlavorAsyncInvoker(ShowFlavorRequest showFlavorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFlavorRequest.FlavorId, out var valueOfFlavorId)) urlParam.Add("flavor_id", valueOfFlavorId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/flavors/{flavor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlavorRequest);
            return new AsyncInvoker<ShowFlavorResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFlavorResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHealthMonitorRequest.HealthmonitorId, out var valueOfHealthmonitorId)) urlParam.Add("healthmonitor_id", valueOfHealthmonitorId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthMonitorRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowHealthMonitorResponse>(response);
        }

        public AsyncInvoker<ShowHealthMonitorResponse> ShowHealthMonitorAsyncInvoker(ShowHealthMonitorRequest showHealthMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHealthMonitorRequest.HealthmonitorId, out var valueOfHealthmonitorId)) urlParam.Add("healthmonitor_id", valueOfHealthmonitorId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthMonitorRequest);
            return new AsyncInvoker<ShowHealthMonitorResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHealthMonitorResponse>);
        }
        
        /// <summary>
        /// 查询异步任务的job状态
        ///
        /// 用于查询实例复制、实例升级等异步接口任务的状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobResponse> ShowJobAsync(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }

        public AsyncInvoker<ShowJobResponse> ShowJobAsyncInvoker(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            return new AsyncInvoker<ShowJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showL7PolicyRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7PolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowL7PolicyResponse>(response);
        }

        public AsyncInvoker<ShowL7PolicyResponse> ShowL7PolicyAsyncInvoker(ShowL7PolicyRequest showL7PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showL7PolicyRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7PolicyRequest);
            return new AsyncInvoker<ShowL7PolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowL7PolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showL7RuleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            if (StringUtils.TryConvertToNonEmptyString(showL7RuleRequest.L7ruleId, out var valueOfL7ruleId)) urlParam.Add("l7rule_id", valueOfL7ruleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7RuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowL7RuleResponse>(response);
        }

        public AsyncInvoker<ShowL7RuleResponse> ShowL7RuleAsyncInvoker(ShowL7RuleRequest showL7RuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showL7RuleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            if (StringUtils.TryConvertToNonEmptyString(showL7RuleRequest.L7ruleId, out var valueOfL7ruleId)) urlParam.Add("l7rule_id", valueOfL7ruleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7RuleRequest);
            return new AsyncInvoker<ShowL7RuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowL7RuleResponse>);
        }
        
        /// <summary>
        /// 查询监听器详情
        ///
        /// 查询监听器详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowListenerResponse> ShowListenerAsync(ShowListenerRequest showListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowListenerResponse>(response);
        }

        public AsyncInvoker<ShowListenerResponse> ShowListenerAsyncInvoker(ShowListenerRequest showListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerRequest);
            return new AsyncInvoker<ShowListenerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowListenerResponse>);
        }
        
        /// <summary>
        /// 查询监听器的标签
        ///
        /// 查询指定监听器的所有标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowListenerTagsResponse> ShowListenerTagsAsync(ShowListenerTagsRequest showListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showListenerTagsRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/listeners/{listener_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowListenerTagsResponse>(response);
        }

        public AsyncInvoker<ShowListenerTagsResponse> ShowListenerTagsAsyncInvoker(ShowListenerTagsRequest showListenerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showListenerTagsRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/listeners/{listener_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerTagsRequest);
            return new AsyncInvoker<ShowListenerTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowListenerTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoadBalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLoadBalancerResponse>(response);
        }

        public AsyncInvoker<ShowLoadBalancerResponse> ShowLoadBalancerAsyncInvoker(ShowLoadBalancerRequest showLoadBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoadBalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerRequest);
            return new AsyncInvoker<ShowLoadBalancerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLoadBalancerResponse>);
        }
        
        /// <summary>
        /// 查询负载均衡内部转发用的IP
        ///
        /// 查询负载均衡内部转发用的IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLoadBalancerPortsResponse> ShowLoadBalancerPortsAsync(ShowLoadBalancerPortsRequest showLoadBalancerPortsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoadBalancerPortsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/local-ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerPortsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLoadBalancerPortsResponse>(response);
        }

        public AsyncInvoker<ShowLoadBalancerPortsResponse> ShowLoadBalancerPortsAsyncInvoker(ShowLoadBalancerPortsRequest showLoadBalancerPortsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoadBalancerPortsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/local-ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerPortsRequest);
            return new AsyncInvoker<ShowLoadBalancerPortsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLoadBalancerPortsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoadBalancerStatusRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLoadBalancerStatusResponse>(response);
        }

        public AsyncInvoker<ShowLoadBalancerStatusResponse> ShowLoadBalancerStatusAsyncInvoker(ShowLoadBalancerStatusRequest showLoadBalancerStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoadBalancerStatusRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerStatusRequest);
            return new AsyncInvoker<ShowLoadBalancerStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLoadBalancerStatusResponse>);
        }
        
        /// <summary>
        /// 查询负载均衡器拓扑
        ///
        /// 查询负载均衡拓扑，将负载均衡器及其包含的监听器、后端服务器组以拓扑的形式展示。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLoadBalancerTopologyResponse> ShowLoadBalancerTopologyAsync(ShowLoadBalancerTopologyRequest showLoadBalancerTopologyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoadBalancerTopologyRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/topology", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerTopologyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLoadBalancerTopologyResponse>(response);
        }

        public AsyncInvoker<ShowLoadBalancerTopologyResponse> ShowLoadBalancerTopologyAsyncInvoker(ShowLoadBalancerTopologyRequest showLoadBalancerTopologyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoadBalancerTopologyRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/topology", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerTopologyRequest);
            return new AsyncInvoker<ShowLoadBalancerTopologyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLoadBalancerTopologyResponse>);
        }
        
        /// <summary>
        /// 查询负载均衡器的标签
        ///
        /// 查询指定负载均衡器的所有标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLoadbalancerTagsResponse> ShowLoadbalancerTagsAsync(ShowLoadbalancerTagsRequest showLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoadbalancerTagsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/loadbalancers/{loadbalancer_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadbalancerTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLoadbalancerTagsResponse>(response);
        }

        public AsyncInvoker<ShowLoadbalancerTagsResponse> ShowLoadbalancerTagsAsyncInvoker(ShowLoadbalancerTagsRequest showLoadbalancerTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoadbalancerTagsRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/loadbalancers/{loadbalancer_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadbalancerTagsRequest);
            return new AsyncInvoker<ShowLoadbalancerTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLoadbalancerTagsResponse>);
        }
        
        /// <summary>
        /// 查询云日志详情
        ///
        /// 云日志详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLogtankResponse> ShowLogtankAsync(ShowLogtankRequest showLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogtankRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLogtankResponse>(response);
        }

        public AsyncInvoker<ShowLogtankResponse> ShowLogtankAsyncInvoker(ShowLogtankRequest showLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogtankRequest);
            return new AsyncInvoker<ShowLogtankResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLogtankResponse>);
        }
        
        /// <summary>
        /// 查询主备后端服务器组详情
        ///
        /// 主备后端服务器组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMasterSlavePoolResponse> ShowMasterSlavePoolAsync(ShowMasterSlavePoolRequest showMasterSlavePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMasterSlavePoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/master-slave-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMasterSlavePoolRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMasterSlavePoolResponse>(response);
        }

        public AsyncInvoker<ShowMasterSlavePoolResponse> ShowMasterSlavePoolAsyncInvoker(ShowMasterSlavePoolRequest showMasterSlavePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMasterSlavePoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/master-slave-pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMasterSlavePoolRequest);
            return new AsyncInvoker<ShowMasterSlavePoolResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMasterSlavePoolResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            if (StringUtils.TryConvertToNonEmptyString(showMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMemberResponse>(response);
        }

        public AsyncInvoker<ShowMemberResponse> ShowMemberAsyncInvoker(ShowMemberRequest showMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            if (StringUtils.TryConvertToNonEmptyString(showMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberRequest);
            return new AsyncInvoker<ShowMemberResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMemberResponse>);
        }
        
        /// <summary>
        /// 查询后端服务器检测任务的结果
        ///
        /// 查询后端服务器检测任务的结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMemberHealthCheckJobResponse> ShowMemberHealthCheckJobAsync(ShowMemberHealthCheckJobRequest showMemberHealthCheckJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMemberHealthCheckJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/members/check/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberHealthCheckJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMemberHealthCheckJobResponse>(response);
        }

        public AsyncInvoker<ShowMemberHealthCheckJobResponse> ShowMemberHealthCheckJobAsyncInvoker(ShowMemberHealthCheckJobRequest showMemberHealthCheckJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMemberHealthCheckJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/members/check/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberHealthCheckJobRequest);
            return new AsyncInvoker<ShowMemberHealthCheckJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMemberHealthCheckJobResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPoolResponse>(response);
        }

        public AsyncInvoker<ShowPoolResponse> ShowPoolAsyncInvoker(ShowPoolRequest showPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolRequest);
            return new AsyncInvoker<ShowPoolResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPoolResponse>);
        }
        
        /// <summary>
        /// 查询配额详情
        ///
        /// 查询指定项目中负载均衡相关的各类资源的当前配额。接口返回只包含总配额，不包含已使用配额。若需要查询已使用配额，可使用查询配额使用详情（GET /v3/{project_id}/elb/quotas/details）接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQuotaResponse> ShowQuotaAsync(ShowQuotaRequest showQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotaResponse>(response);
        }

        public AsyncInvoker<ShowQuotaResponse> ShowQuotaAsyncInvoker(ShowQuotaRequest showQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            return new AsyncInvoker<ShowQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotaResponse>);
        }
        
        /// <summary>
        /// 查询回收站的配置
        ///
        /// 查询回收站的配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecycleBinResponse> ShowRecycleBinAsync(ShowRecycleBinRequest showRecycleBinRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecycleBinRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRecycleBinResponse>(response);
        }

        public AsyncInvoker<ShowRecycleBinResponse> ShowRecycleBinAsyncInvoker(ShowRecycleBinRequest showRecycleBinRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecycleBinRequest);
            return new AsyncInvoker<ShowRecycleBinResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecycleBinResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecurityPolicyRequest.SecurityPolicyId, out var valueOfSecurityPolicyId)) urlParam.Add("security_policy_id", valueOfSecurityPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSecurityPolicyResponse>(response);
        }

        public AsyncInvoker<ShowSecurityPolicyResponse> ShowSecurityPolicyAsyncInvoker(ShowSecurityPolicyRequest showSecurityPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecurityPolicyRequest.SecurityPolicyId, out var valueOfSecurityPolicyId)) urlParam.Add("security_policy_id", valueOfSecurityPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityPolicyRequest);
            return new AsyncInvoker<ShowSecurityPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecurityPolicyResponse>);
        }
        
        /// <summary>
        /// 更新证书
        ///
        /// 更新ELB证书。不能更新证书类型，但可以更新证书内容和私钥等。
        /// 注意：更新证书会影响当前证书已关联的监听器，请谨慎操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateCertificateResponse> UpdateCertificateAsync(UpdateCertificateRequest updateCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateCertificateRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCertificateResponse>(response);
        }

        public AsyncInvoker<UpdateCertificateResponse> UpdateCertificateAsyncInvoker(UpdateCertificateRequest updateCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateCertificateRequest);
            return new AsyncInvoker<UpdateCertificateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCertificateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHealthMonitorRequest.HealthmonitorId, out var valueOfHealthmonitorId)) urlParam.Add("healthmonitor_id", valueOfHealthmonitorId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateHealthMonitorRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHealthMonitorResponse>(response);
        }

        public AsyncInvoker<UpdateHealthMonitorResponse> UpdateHealthMonitorAsyncInvoker(UpdateHealthMonitorRequest updateHealthMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHealthMonitorRequest.HealthmonitorId, out var valueOfHealthmonitorId)) urlParam.Add("healthmonitor_id", valueOfHealthmonitorId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateHealthMonitorRequest);
            return new AsyncInvoker<UpdateHealthMonitorResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHealthMonitorResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateL7PolicyRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateL7PolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateL7PolicyResponse>(response);
        }

        public AsyncInvoker<UpdateL7PolicyResponse> UpdateL7PolicyAsyncInvoker(UpdateL7PolicyRequest updateL7PolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateL7PolicyRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateL7PolicyRequest);
            return new AsyncInvoker<UpdateL7PolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateL7PolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateL7RuleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            if (StringUtils.TryConvertToNonEmptyString(updateL7RuleRequest.L7ruleId, out var valueOfL7ruleId)) urlParam.Add("l7rule_id", valueOfL7ruleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateL7RuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateL7RuleResponse>(response);
        }

        public AsyncInvoker<UpdateL7RuleResponse> UpdateL7RuleAsyncInvoker(UpdateL7RuleRequest updateL7RuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateL7RuleRequest.L7policyId, out var valueOfL7policyId)) urlParam.Add("l7policy_id", valueOfL7policyId);
            if (StringUtils.TryConvertToNonEmptyString(updateL7RuleRequest.L7ruleId, out var valueOfL7ruleId)) urlParam.Add("l7rule_id", valueOfL7ruleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateL7RuleRequest);
            return new AsyncInvoker<UpdateL7RuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateL7RuleResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(updateListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateListenerRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateListenerResponse>(response);
        }

        public AsyncInvoker<UpdateListenerResponse> UpdateListenerAsyncInvoker(UpdateListenerRequest updateListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateListenerRequest);
            return new AsyncInvoker<UpdateListenerResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateListenerResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLoadBalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLoadBalancerRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLoadBalancerResponse>(response);
        }

        public AsyncInvoker<UpdateLoadBalancerResponse> UpdateLoadBalancerAsyncInvoker(UpdateLoadBalancerRequest updateLoadBalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLoadBalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLoadBalancerRequest);
            return new AsyncInvoker<UpdateLoadBalancerResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLoadBalancerResponse>);
        }
        
        /// <summary>
        /// 更新云日志
        ///
        /// 更新云日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLogtankResponse> UpdateLogtankAsync(UpdateLogtankRequest updateLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLogtankRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLogtankResponse>(response);
        }

        public AsyncInvoker<UpdateLogtankResponse> UpdateLogtankAsyncInvoker(UpdateLogtankRequest updateLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLogtankRequest);
            return new AsyncInvoker<UpdateLogtankResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLogtankResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            if (StringUtils.TryConvertToNonEmptyString(updateMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMemberRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMemberResponse>(response);
        }

        public AsyncInvoker<UpdateMemberResponse> UpdateMemberAsyncInvoker(UpdateMemberRequest updateMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            if (StringUtils.TryConvertToNonEmptyString(updateMemberRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMemberRequest);
            return new AsyncInvoker<UpdateMemberResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMemberResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePoolRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePoolResponse>(response);
        }

        public AsyncInvoker<UpdatePoolResponse> UpdatePoolAsyncInvoker(UpdatePoolRequest updatePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePoolRequest.PoolId, out var valueOfPoolId)) urlParam.Add("pool_id", valueOfPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePoolRequest);
            return new AsyncInvoker<UpdatePoolResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePoolResponse>);
        }
        
        /// <summary>
        /// 开关回收站
        ///
        /// 开启或关闭回收站功能。开启后删除的LB可以进入回收站，否则将不进入回收站而是直接被删除无法恢复。关闭回收站前需要先将回收站中的实例还原或销毁。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRecycleBinEnableResponse> UpdateRecycleBinEnableAsync(UpdateRecycleBinEnableRequest updateRecycleBinEnableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecycleBinEnableRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRecycleBinEnableResponse>(response);
        }

        public AsyncInvoker<UpdateRecycleBinEnableResponse> UpdateRecycleBinEnableAsyncInvoker(UpdateRecycleBinEnableRequest updateRecycleBinEnableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecycleBinEnableRequest);
            return new AsyncInvoker<UpdateRecycleBinEnableResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRecycleBinEnableResponse>);
        }
        
        /// <summary>
        /// 更新回收站的配置
        ///
        /// 更新回收站的配置。若回收站未开启，则更新会报错。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRecycleBinPolicyResponse> UpdateRecycleBinPolicyAsync(UpdateRecycleBinPolicyRequest updateRecycleBinPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecycleBinPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRecycleBinPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateRecycleBinPolicyResponse> UpdateRecycleBinPolicyAsyncInvoker(UpdateRecycleBinPolicyRequest updateRecycleBinPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/recycle-bin/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecycleBinPolicyRequest);
            return new AsyncInvoker<UpdateRecycleBinPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRecycleBinPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSecurityPolicyRequest.SecurityPolicyId, out var valueOfSecurityPolicyId)) urlParam.Add("security_policy_id", valueOfSecurityPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecurityPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSecurityPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateSecurityPolicyResponse> UpdateSecurityPolicyAsyncInvoker(UpdateSecurityPolicyRequest updateSecurityPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSecurityPolicyRequest.SecurityPolicyId, out var valueOfSecurityPolicyId)) urlParam.Add("security_policy_id", valueOfSecurityPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecurityPolicyRequest);
            return new AsyncInvoker<UpdateSecurityPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSecurityPolicyResponse>);
        }
        
        /// <summary>
        /// 配置负载均衡器系统默认域名化
        ///
        /// 配置负载均衡器系统默认域名化。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSystemDefaultDomainConfigResponse> UpdateSystemDefaultDomainConfigAsync(UpdateSystemDefaultDomainConfigRequest updateSystemDefaultDomainConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSystemDefaultDomainConfigRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/dns/system-default-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSystemDefaultDomainConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateSystemDefaultDomainConfigResponse>(response);
        }

        public AsyncInvoker<UpdateSystemDefaultDomainConfigResponse> UpdateSystemDefaultDomainConfigAsyncInvoker(UpdateSystemDefaultDomainConfigRequest updateSystemDefaultDomainConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSystemDefaultDomainConfigRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/dns/system-default-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSystemDefaultDomainConfigRequest);
            return new AsyncInvoker<UpdateSystemDefaultDomainConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateSystemDefaultDomainConfigResponse>);
        }
        
        /// <summary>
        /// 配置负载均衡器用户自定义域名化
        ///
        /// 配置负载均衡器用户自定义域名化。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateUserDefinedDomainConfigResponse> UpdateUserDefinedDomainConfigAsync(UpdateUserDefinedDomainConfigRequest updateUserDefinedDomainConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserDefinedDomainConfigRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/dns/user-defined-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserDefinedDomainConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateUserDefinedDomainConfigResponse>(response);
        }

        public AsyncInvoker<UpdateUserDefinedDomainConfigResponse> UpdateUserDefinedDomainConfigAsyncInvoker(UpdateUserDefinedDomainConfigRequest updateUserDefinedDomainConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserDefinedDomainConfigRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/dns/user-defined-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserDefinedDomainConfigRequest);
            return new AsyncInvoker<UpdateUserDefinedDomainConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateUserDefinedDomainConfigResponse>);
        }
        
        /// <summary>
        /// 升级负载均衡器类型
        ///
        /// 升级负载均衡器类型。支持将共享型ELB升级为独享型ELB，但不支持独享型降级为共享型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpgradeLoadbalancerResponse> UpgradeLoadbalancerAsync(UpgradeLoadbalancerRequest upgradeLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeLoadbalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeLoadbalancerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpgradeLoadbalancerResponse>(response);
        }

        public AsyncInvoker<UpgradeLoadbalancerResponse> UpgradeLoadbalancerAsyncInvoker(UpgradeLoadbalancerRequest upgradeLoadbalancerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeLoadbalancerRequest.LoadbalancerId, out var valueOfLoadbalancerId)) urlParam.Add("loadbalancer_id", valueOfLoadbalancerId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", upgradeLoadbalancerRequest);
            return new AsyncInvoker<UpgradeLoadbalancerResponse>(this, "POST", request, JsonUtils.DeSerialize<UpgradeLoadbalancerResponse>);
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
        public async Task<ListApiVersionsResponse> ListApiVersionsAsync(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }

        public AsyncInvoker<ListApiVersionsResponse> ListApiVersionsAsyncInvoker(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            return new AsyncInvoker<ListApiVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionsResponse>);
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
        public async Task<BatchDeleteIpListResponse> BatchDeleteIpListAsync(BatchDeleteIpListRequest batchDeleteIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteIpListRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/iplist/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteIpListRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteIpListResponse>(response);
        }

        public AsyncInvoker<BatchDeleteIpListResponse> BatchDeleteIpListAsyncInvoker(BatchDeleteIpListRequest batchDeleteIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteIpListRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/iplist/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteIpListRequest);
            return new AsyncInvoker<BatchDeleteIpListResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteIpListResponse>);
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
        public async Task<CountPreoccupyIpNumResponse> CountPreoccupyIpNumAsync(CountPreoccupyIpNumRequest countPreoccupyIpNumRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/preoccupy-ip-num", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countPreoccupyIpNumRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CountPreoccupyIpNumResponse>(response);
        }

        public AsyncInvoker<CountPreoccupyIpNumResponse> CountPreoccupyIpNumAsyncInvoker(CountPreoccupyIpNumRequest countPreoccupyIpNumRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/preoccupy-ip-num", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countPreoccupyIpNumRequest);
            return new AsyncInvoker<CountPreoccupyIpNumResponse>(this, "GET", request, JsonUtils.DeSerialize<CountPreoccupyIpNumResponse>);
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
        public async Task<CreateIpGroupResponse> CreateIpGroupAsync(CreateIpGroupRequest createIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createIpGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateIpGroupResponse>(response);
        }

        public AsyncInvoker<CreateIpGroupResponse> CreateIpGroupAsyncInvoker(CreateIpGroupRequest createIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createIpGroupRequest);
            return new AsyncInvoker<CreateIpGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateIpGroupResponse>);
        }
        
        /// <summary>
        /// 删除IP地址组
        ///
        /// 删除IP地址组。已关联监听器的IP地址组无法直接删除，需要先解除关联关系。[荷兰region不支持IP地址组功能，请勿使用。](tag:dt)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteIpGroupResponse> DeleteIpGroupAsync(DeleteIpGroupRequest deleteIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteIpGroupRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteIpGroupResponse>(response);
        }

        public AsyncInvoker<DeleteIpGroupResponse> DeleteIpGroupAsyncInvoker(DeleteIpGroupRequest deleteIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteIpGroupRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpGroupRequest);
            return new AsyncInvoker<DeleteIpGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteIpGroupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListIpGroupsResponse>(response);
        }

        public AsyncInvoker<ListIpGroupsResponse> ListIpGroupsAsyncInvoker(ListIpGroupsRequest listIpGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpGroupsRequest);
            return new AsyncInvoker<ListIpGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIpGroupsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIpGroupRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowIpGroupResponse>(response);
        }

        public AsyncInvoker<ShowIpGroupResponse> ShowIpGroupAsyncInvoker(ShowIpGroupRequest showIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIpGroupRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpGroupRequest);
            return new AsyncInvoker<ShowIpGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIpGroupResponse>);
        }
        
        /// <summary>
        /// 查询IP地址组关联的监听器列表
        ///
        /// 查询IP地址组关联的监听器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowIpGroupRelatedListenersResponse> ShowIpGroupRelatedListenersAsync(ShowIpGroupRelatedListenersRequest showIpGroupRelatedListenersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIpGroupRelatedListenersRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/related-listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpGroupRelatedListenersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowIpGroupRelatedListenersResponse>(response);
        }

        public AsyncInvoker<ShowIpGroupRelatedListenersResponse> ShowIpGroupRelatedListenersAsyncInvoker(ShowIpGroupRelatedListenersRequest showIpGroupRelatedListenersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIpGroupRelatedListenersRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/related-listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpGroupRelatedListenersRequest);
            return new AsyncInvoker<ShowIpGroupRelatedListenersResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIpGroupRelatedListenersResponse>);
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
        public async Task<UpdateIpGroupResponse> UpdateIpGroupAsync(UpdateIpGroupRequest updateIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIpGroupRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateIpGroupResponse>(response);
        }

        public AsyncInvoker<UpdateIpGroupResponse> UpdateIpGroupAsyncInvoker(UpdateIpGroupRequest updateIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIpGroupRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpGroupRequest);
            return new AsyncInvoker<UpdateIpGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateIpGroupResponse>);
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
        public async Task<UpdateIpListResponse> UpdateIpListAsync(UpdateIpListRequest updateIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIpListRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/iplist/create-or-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpListRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateIpListResponse>(response);
        }

        public AsyncInvoker<UpdateIpListResponse> UpdateIpListAsyncInvoker(UpdateIpListRequest updateIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIpListRequest.IpgroupId, out var valueOfIpgroupId)) urlParam.Add("ipgroup_id", valueOfIpgroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/iplist/create-or-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpListRequest);
            return new AsyncInvoker<UpdateIpListResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateIpListResponse>);
        }
        
    }
}