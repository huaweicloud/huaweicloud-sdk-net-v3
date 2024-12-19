using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Aad.V2.Model;

namespace HuaweiCloud.SDK.Aad.V2
{
    public partial class AadClient : Client
    {
        public static ClientBuilder<AadClient> NewBuilder()
        {
            return new ClientBuilder<AadClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 防护策略web-cc黑白名单-创建黑白名单规则
        ///
        /// 防护策略web-cc黑白名单-创建黑白名单规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddWafWhiteIpRuleResponse AddWafWhiteIpRule(AddWafWhiteIpRuleRequest addWafWhiteIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf/blackwhite-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addWafWhiteIpRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AddWafWhiteIpRuleResponse>(response);
        }

        public SyncInvoker<AddWafWhiteIpRuleResponse> AddWafWhiteIpRuleInvoker(AddWafWhiteIpRuleRequest addWafWhiteIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf/blackwhite-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addWafWhiteIpRuleRequest);
            return new SyncInvoker<AddWafWhiteIpRuleResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddWafWhiteIpRuleResponse>);
        }
        
        /// <summary>
        /// 创建防护域名
        ///
        /// 创建防护域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDomainResponse CreateDomain(CreateDomainRequest createDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDomainResponse>(response);
        }

        public SyncInvoker<CreateDomainResponse> CreateDomainInvoker(CreateDomainRequest createDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainRequest);
            return new SyncInvoker<CreateDomainResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDomainResponse>);
        }
        
        /// <summary>
        /// 删除防护域名
        ///
        /// 删除防护域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest deleteDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDomainResponse>(response);
        }

        public SyncInvoker<DeleteDomainResponse> DeleteDomainInvoker(DeleteDomainRequest deleteDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            return new SyncInvoker<DeleteDomainResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDomainResponse>);
        }
        
        /// <summary>
        /// 防护策略web-cc黑白名单-删除黑白名单规则
        ///
        /// 防护策略web-cc黑白名单-删除黑白名单规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteWafWhiteIpRuleResponse DeleteWafWhiteIpRule(DeleteWafWhiteIpRuleRequest deleteWafWhiteIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf/blackwhite-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWafWhiteIpRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteWafWhiteIpRuleResponse>(response);
        }

        public SyncInvoker<DeleteWafWhiteIpRuleResponse> DeleteWafWhiteIpRuleInvoker(DeleteWafWhiteIpRuleRequest deleteWafWhiteIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf/blackwhite-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWafWhiteIpRuleRequest);
            return new SyncInvoker<DeleteWafWhiteIpRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteWafWhiteIpRuleResponse>);
        }
        
        /// <summary>
        /// 查询DDoS攻击事件列表
        ///
        /// 查询DDoS攻击事件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDDoSAttackEventResponse ListDDoSAttackEvent(ListDDoSAttackEventRequest listDDoSAttackEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDDoSAttackEventRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/instances/{instance_id}/ddos-info/attack/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDDoSAttackEventRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListDDoSAttackEventResponse>(response);
        }

        public SyncInvoker<ListDDoSAttackEventResponse> ListDDoSAttackEventInvoker(ListDDoSAttackEventRequest listDDoSAttackEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDDoSAttackEventRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/instances/{instance_id}/ddos-info/attack/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDDoSAttackEventRequest);
            return new SyncInvoker<ListDDoSAttackEventResponse>(this, "POST", request, JsonUtils.DeSerialize<ListDDoSAttackEventResponse>);
        }
        
        /// <summary>
        /// 查询新建连接数和并发连接数
        ///
        /// 查询新建连接数和并发连接数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDDoSConnectionNumberResponse ListDDoSConnectionNumber(ListDDoSConnectionNumberRequest listDDoSConnectionNumberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDDoSConnectionNumberRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/instances/{instance_id}/ddos-info/flow/connection-numbers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDDoSConnectionNumberRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDDoSConnectionNumberResponse>(response);
        }

        public SyncInvoker<ListDDoSConnectionNumberResponse> ListDDoSConnectionNumberInvoker(ListDDoSConnectionNumberRequest listDDoSConnectionNumberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDDoSConnectionNumberRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/instances/{instance_id}/ddos-info/flow/connection-numbers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDDoSConnectionNumberRequest);
            return new SyncInvoker<ListDDoSConnectionNumberResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDDoSConnectionNumberResponse>);
        }
        
        /// <summary>
        /// 查询DDoS攻击防护BPS/PPS流量
        ///
        /// 查询DDoS攻击防护BPS/PPS流量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDDoSFlowResponse ListDDoSFlow(ListDDoSFlowRequest listDDoSFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDDoSFlowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/instances/{instance_id}/ddos-info/flow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDDoSFlowRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDDoSFlowResponse>(response);
        }

        public SyncInvoker<ListDDoSFlowResponse> ListDDoSFlowInvoker(ListDDoSFlowRequest listDDoSFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDDoSFlowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/instances/{instance_id}/ddos-info/flow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDDoSFlowRequest);
            return new SyncInvoker<ListDDoSFlowResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDDoSFlowResponse>);
        }
        
        /// <summary>
        /// 查询频率控制规则列表
        ///
        /// 查询频率控制规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFrequencyControlRuleResponse ListFrequencyControlRule(ListFrequencyControlRuleRequest listFrequencyControlRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf/frequency-control-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFrequencyControlRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFrequencyControlRuleResponse>(response);
        }

        public SyncInvoker<ListFrequencyControlRuleResponse> ListFrequencyControlRuleInvoker(ListFrequencyControlRuleRequest listFrequencyControlRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf/frequency-control-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFrequencyControlRuleRequest);
            return new SyncInvoker<ListFrequencyControlRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFrequencyControlRuleResponse>);
        }
        
        /// <summary>
        /// 查询实例关联的域名信息
        ///
        /// 查询实例关联的域名信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceDomainsResponse ListInstanceDomains(ListInstanceDomainsRequest listInstanceDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceDomainsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/instances/{instance_id}/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceDomainsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceDomainsResponse>(response);
        }

        public SyncInvoker<ListInstanceDomainsResponse> ListInstanceDomainsInvoker(ListInstanceDomainsRequest listInstanceDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceDomainsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/instances/{instance_id}/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceDomainsRequest);
            return new SyncInvoker<ListInstanceDomainsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceDomainsResponse>);
        }
        
        /// <summary>
        /// 查询攻击事件列表
        ///
        /// 查询攻击事件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWafAttackEventResponse ListWafAttackEvent(ListWafAttackEventRequest listWafAttackEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains/waf-info/attack/event", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafAttackEventRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListWafAttackEventResponse>(response);
        }

        public SyncInvoker<ListWafAttackEventResponse> ListWafAttackEventInvoker(ListWafAttackEventRequest listWafAttackEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains/waf-info/attack/event", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafAttackEventRequest);
            return new SyncInvoker<ListWafAttackEventResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWafAttackEventResponse>);
        }
        
        /// <summary>
        /// 带宽曲线
        ///
        /// 带宽曲线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWafBandwidthResponse ListWafBandwidth(ListWafBandwidthRequest listWafBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains/waf-info/flow/bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafBandwidthRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListWafBandwidthResponse>(response);
        }

        public SyncInvoker<ListWafBandwidthResponse> ListWafBandwidthInvoker(ListWafBandwidthRequest listWafBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains/waf-info/flow/bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafBandwidthRequest);
            return new SyncInvoker<ListWafBandwidthResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWafBandwidthResponse>);
        }
        
        /// <summary>
        /// 查询精准防护规则
        ///
        /// 查询精准防护规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWafCustomRuleResponse ListWafCustomRule(ListWafCustomRuleRequest listWafCustomRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf/custom-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafCustomRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListWafCustomRuleResponse>(response);
        }

        public SyncInvoker<ListWafCustomRuleResponse> ListWafCustomRuleInvoker(ListWafCustomRuleRequest listWafCustomRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf/custom-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafCustomRuleRequest);
            return new SyncInvoker<ListWafCustomRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWafCustomRuleResponse>);
        }
        
        /// <summary>
        /// 查询区域封禁规则
        ///
        /// 查询区域封禁规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWafGeoIpRuleResponse ListWafGeoIpRule(ListWafGeoIpRuleRequest listWafGeoIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf/geoip-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafGeoIpRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListWafGeoIpRuleResponse>(response);
        }

        public SyncInvoker<ListWafGeoIpRuleResponse> ListWafGeoIpRuleInvoker(ListWafGeoIpRuleRequest listWafGeoIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf/geoip-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafGeoIpRuleRequest);
            return new SyncInvoker<ListWafGeoIpRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWafGeoIpRuleResponse>);
        }
        
        /// <summary>
        /// 查询请求QPS
        ///
        /// 查询请求QPS
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWafQpsResponse ListWafQps(ListWafQpsRequest listWafQpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains/waf-info/flow/qps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafQpsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListWafQpsResponse>(response);
        }

        public SyncInvoker<ListWafQpsResponse> ListWafQpsInvoker(ListWafQpsRequest listWafQpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains/waf-info/flow/qps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafQpsRequest);
            return new SyncInvoker<ListWafQpsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWafQpsResponse>);
        }
        
        /// <summary>
        /// 防护策略web-cc黑白名单-查询黑白名单规则
        ///
        /// 防护策略web-cc黑白名单-查询黑白名单规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWafWhiteIpRuleResponse ListWafWhiteIpRule(ListWafWhiteIpRuleRequest listWafWhiteIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf/blackwhite-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafWhiteIpRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListWafWhiteIpRuleResponse>(response);
        }

        public SyncInvoker<ListWafWhiteIpRuleResponse> ListWafWhiteIpRuleInvoker(ListWafWhiteIpRuleRequest listWafWhiteIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf/blackwhite-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafWhiteIpRuleRequest);
            return new SyncInvoker<ListWafWhiteIpRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWafWhiteIpRuleResponse>);
        }
        
        /// <summary>
        /// 查询DDoS攻击防护的黑白名单列表
        ///
        /// 查询DDoS攻击防护的黑白名单列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWhiteBlackIpRuleResponse ListWhiteBlackIpRule(ListWhiteBlackIpRuleRequest listWhiteBlackIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/ddos/blackwhite-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWhiteBlackIpRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListWhiteBlackIpRuleResponse>(response);
        }

        public SyncInvoker<ListWhiteBlackIpRuleResponse> ListWhiteBlackIpRuleInvoker(ListWhiteBlackIpRuleRequest listWhiteBlackIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/ddos/blackwhite-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWhiteBlackIpRuleRequest);
            return new SyncInvoker<ListWhiteBlackIpRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWhiteBlackIpRuleResponse>);
        }
        
        /// <summary>
        /// 查询域名关联的证书信息
        ///
        /// 查询域名关联的证书信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainCertificateResponse ShowDomainCertificate(ShowDomainCertificateRequest showDomainCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showDomainCertificateRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains/{domain_id}/certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainCertificateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainCertificateResponse>(response);
        }

        public SyncInvoker<ShowDomainCertificateResponse> ShowDomainCertificateInvoker(ShowDomainCertificateRequest showDomainCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showDomainCertificateRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains/{domain_id}/certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainCertificateRequest);
            return new SyncInvoker<ShowDomainCertificateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainCertificateResponse>);
        }
        
        /// <summary>
        /// 查询流量封禁信息
        ///
        /// 查询流量封禁信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFlowBlockResponse ShowFlowBlock(ShowFlowBlockRequest showFlowBlockRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/ddos/flow-block", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowBlockRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFlowBlockResponse>(response);
        }

        public SyncInvoker<ShowFlowBlockResponse> ShowFlowBlockInvoker(ShowFlowBlockRequest showFlowBlockRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/ddos/flow-block", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowBlockRequest);
            return new SyncInvoker<ShowFlowBlockResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFlowBlockResponse>);
        }
        
        /// <summary>
        /// 查询WEB防护策略配置
        ///
        /// 查询WEB防护策略配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowWafPolicyResponse ShowWafPolicy(ShowWafPolicyRequest showWafPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWafPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowWafPolicyResponse>(response);
        }

        public SyncInvoker<ShowWafPolicyResponse> ShowWafPolicyInvoker(ShowWafPolicyRequest showWafPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWafPolicyRequest);
            return new SyncInvoker<ShowWafPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWafPolicyResponse>);
        }
        
        /// <summary>
        /// 查询CC攻击防护请求QPS
        ///
        /// 查询CC攻击防护请求QPS
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowWafQpsResponse ShowWafQps(ShowWafQpsRequest showWafQpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains/waf-info/flow/request/peak", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWafQpsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowWafQpsResponse>(response);
        }

        public SyncInvoker<ShowWafQpsResponse> ShowWafQpsInvoker(ShowWafQpsRequest showWafQpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains/waf-info/flow/request/peak", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWafQpsRequest);
            return new SyncInvoker<ShowWafQpsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWafQpsResponse>);
        }
        
        /// <summary>
        /// 修改实例规格
        ///
        /// 修改实例规格
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeInstanceSpecResponse UpgradeInstanceSpec(UpgradeInstanceSpecRequest upgradeInstanceSpecRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeInstanceSpecRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpgradeInstanceSpecResponse>(response);
        }

        public SyncInvoker<UpgradeInstanceSpecResponse> UpgradeInstanceSpecInvoker(UpgradeInstanceSpecRequest upgradeInstanceSpecRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeInstanceSpecRequest);
            return new SyncInvoker<UpgradeInstanceSpecResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpgradeInstanceSpecResponse>);
        }
        
    }
}