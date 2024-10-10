using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Aad.V2.Model;

namespace HuaweiCloud.SDK.Aad.V2
{
    public partial class AadAsyncClient : Client
    {
        public static ClientBuilder<AadAsyncClient> NewBuilder()
        {
            return new ClientBuilder<AadAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 创建防护域名
        ///
        /// 创建防护域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest createDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDomainResponse>(response);
        }

        public AsyncInvoker<CreateDomainResponse> CreateDomainAsyncInvoker(CreateDomainRequest createDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainRequest);
            return new AsyncInvoker<CreateDomainResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDomainResponse>);
        }
        
        /// <summary>
        /// 查询DDoS攻击事件列表
        ///
        /// 查询DDoS攻击事件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDDoSAttackEventResponse> ListDDoSAttackEventAsync(ListDDoSAttackEventRequest listDDoSAttackEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDDoSAttackEventRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/instances/{instance_id}/ddos-info/attack/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDDoSAttackEventRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListDDoSAttackEventResponse>(response);
        }

        public AsyncInvoker<ListDDoSAttackEventResponse> ListDDoSAttackEventAsyncInvoker(ListDDoSAttackEventRequest listDDoSAttackEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDDoSAttackEventRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/instances/{instance_id}/ddos-info/attack/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDDoSAttackEventRequest);
            return new AsyncInvoker<ListDDoSAttackEventResponse>(this, "POST", request, JsonUtils.DeSerialize<ListDDoSAttackEventResponse>);
        }
        
        /// <summary>
        /// 查询新建连接数和并发连接数
        ///
        /// 查询新建连接数和并发连接数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDDoSConnectionNumberResponse> ListDDoSConnectionNumberAsync(ListDDoSConnectionNumberRequest listDDoSConnectionNumberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDDoSConnectionNumberRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/instances/{instance_id}/ddos-info/flow/connection-numbers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDDoSConnectionNumberRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDDoSConnectionNumberResponse>(response);
        }

        public AsyncInvoker<ListDDoSConnectionNumberResponse> ListDDoSConnectionNumberAsyncInvoker(ListDDoSConnectionNumberRequest listDDoSConnectionNumberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDDoSConnectionNumberRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/instances/{instance_id}/ddos-info/flow/connection-numbers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDDoSConnectionNumberRequest);
            return new AsyncInvoker<ListDDoSConnectionNumberResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDDoSConnectionNumberResponse>);
        }
        
        /// <summary>
        /// 查询DDoS攻击防护BPS/PPS流量
        ///
        /// 查询DDoS攻击防护BPS/PPS流量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDDoSFlowResponse> ListDDoSFlowAsync(ListDDoSFlowRequest listDDoSFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDDoSFlowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/instances/{instance_id}/ddos-info/flow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDDoSFlowRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDDoSFlowResponse>(response);
        }

        public AsyncInvoker<ListDDoSFlowResponse> ListDDoSFlowAsyncInvoker(ListDDoSFlowRequest listDDoSFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listDDoSFlowRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/instances/{instance_id}/ddos-info/flow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDDoSFlowRequest);
            return new AsyncInvoker<ListDDoSFlowResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDDoSFlowResponse>);
        }
        
        /// <summary>
        /// 查询频率控制规则列表
        ///
        /// 查询频率控制规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFrequencyControlRuleResponse> ListFrequencyControlRuleAsync(ListFrequencyControlRuleRequest listFrequencyControlRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf/frequency-control-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFrequencyControlRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFrequencyControlRuleResponse>(response);
        }

        public AsyncInvoker<ListFrequencyControlRuleResponse> ListFrequencyControlRuleAsyncInvoker(ListFrequencyControlRuleRequest listFrequencyControlRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf/frequency-control-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFrequencyControlRuleRequest);
            return new AsyncInvoker<ListFrequencyControlRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFrequencyControlRuleResponse>);
        }
        
        /// <summary>
        /// 查询实例关联的域名信息
        ///
        /// 查询实例关联的域名信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceDomainsResponse> ListInstanceDomainsAsync(ListInstanceDomainsRequest listInstanceDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceDomainsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/instances/{instance_id}/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceDomainsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceDomainsResponse>(response);
        }

        public AsyncInvoker<ListInstanceDomainsResponse> ListInstanceDomainsAsyncInvoker(ListInstanceDomainsRequest listInstanceDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceDomainsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/instances/{instance_id}/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceDomainsRequest);
            return new AsyncInvoker<ListInstanceDomainsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceDomainsResponse>);
        }
        
        /// <summary>
        /// 查询攻击事件列表
        ///
        /// 查询攻击事件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWafAttackEventResponse> ListWafAttackEventAsync(ListWafAttackEventRequest listWafAttackEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains/waf-info/attack/event", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafAttackEventRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListWafAttackEventResponse>(response);
        }

        public AsyncInvoker<ListWafAttackEventResponse> ListWafAttackEventAsyncInvoker(ListWafAttackEventRequest listWafAttackEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains/waf-info/attack/event", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafAttackEventRequest);
            return new AsyncInvoker<ListWafAttackEventResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWafAttackEventResponse>);
        }
        
        /// <summary>
        /// 带宽曲线
        ///
        /// 带宽曲线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWafBandwidthResponse> ListWafBandwidthAsync(ListWafBandwidthRequest listWafBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains/waf-info/flow/bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafBandwidthRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListWafBandwidthResponse>(response);
        }

        public AsyncInvoker<ListWafBandwidthResponse> ListWafBandwidthAsyncInvoker(ListWafBandwidthRequest listWafBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains/waf-info/flow/bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafBandwidthRequest);
            return new AsyncInvoker<ListWafBandwidthResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWafBandwidthResponse>);
        }
        
        /// <summary>
        /// 查询精准防护规则
        ///
        /// 查询精准防护规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWafCustomRuleResponse> ListWafCustomRuleAsync(ListWafCustomRuleRequest listWafCustomRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf/custom-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafCustomRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListWafCustomRuleResponse>(response);
        }

        public AsyncInvoker<ListWafCustomRuleResponse> ListWafCustomRuleAsyncInvoker(ListWafCustomRuleRequest listWafCustomRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf/custom-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafCustomRuleRequest);
            return new AsyncInvoker<ListWafCustomRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWafCustomRuleResponse>);
        }
        
        /// <summary>
        /// 查询区域封禁规则
        ///
        /// 查询区域封禁规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWafGeoIpRuleResponse> ListWafGeoIpRuleAsync(ListWafGeoIpRuleRequest listWafGeoIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf/geoip-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafGeoIpRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListWafGeoIpRuleResponse>(response);
        }

        public AsyncInvoker<ListWafGeoIpRuleResponse> ListWafGeoIpRuleAsyncInvoker(ListWafGeoIpRuleRequest listWafGeoIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf/geoip-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafGeoIpRuleRequest);
            return new AsyncInvoker<ListWafGeoIpRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWafGeoIpRuleResponse>);
        }
        
        /// <summary>
        /// 查询请求QPS
        ///
        /// 查询请求QPS
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWafQpsResponse> ListWafQpsAsync(ListWafQpsRequest listWafQpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains/waf-info/flow/qps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafQpsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListWafQpsResponse>(response);
        }

        public AsyncInvoker<ListWafQpsResponse> ListWafQpsAsyncInvoker(ListWafQpsRequest listWafQpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains/waf-info/flow/qps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafQpsRequest);
            return new AsyncInvoker<ListWafQpsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWafQpsResponse>);
        }
        
        /// <summary>
        /// 防护策略web-cc黑白名单-查询黑白名单规则
        ///
        /// 防护策略web-cc黑白名单-查询黑白名单规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWafWhiteIpRuleResponse> ListWafWhiteIpRuleAsync(ListWafWhiteIpRuleRequest listWafWhiteIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf/blackwhite-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafWhiteIpRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListWafWhiteIpRuleResponse>(response);
        }

        public AsyncInvoker<ListWafWhiteIpRuleResponse> ListWafWhiteIpRuleAsyncInvoker(ListWafWhiteIpRuleRequest listWafWhiteIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf/blackwhite-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWafWhiteIpRuleRequest);
            return new AsyncInvoker<ListWafWhiteIpRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWafWhiteIpRuleResponse>);
        }
        
        /// <summary>
        /// 查询DDoS攻击防护的黑白名单列表
        ///
        /// 查询DDoS攻击防护的黑白名单列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWhiteBlackIpRuleResponse> ListWhiteBlackIpRuleAsync(ListWhiteBlackIpRuleRequest listWhiteBlackIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/ddos/blackwhite-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWhiteBlackIpRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListWhiteBlackIpRuleResponse>(response);
        }

        public AsyncInvoker<ListWhiteBlackIpRuleResponse> ListWhiteBlackIpRuleAsyncInvoker(ListWhiteBlackIpRuleRequest listWhiteBlackIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/ddos/blackwhite-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWhiteBlackIpRuleRequest);
            return new AsyncInvoker<ListWhiteBlackIpRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWhiteBlackIpRuleResponse>);
        }
        
        /// <summary>
        /// 查询域名关联的证书信息
        ///
        /// 查询域名关联的证书信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainCertificateResponse> ShowDomainCertificateAsync(ShowDomainCertificateRequest showDomainCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showDomainCertificateRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains/{domain_id}/certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainCertificateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainCertificateResponse>(response);
        }

        public AsyncInvoker<ShowDomainCertificateResponse> ShowDomainCertificateAsyncInvoker(ShowDomainCertificateRequest showDomainCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showDomainCertificateRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains/{domain_id}/certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainCertificateRequest);
            return new AsyncInvoker<ShowDomainCertificateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainCertificateResponse>);
        }
        
        /// <summary>
        /// 查询流量封禁信息
        ///
        /// 查询流量封禁信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFlowBlockResponse> ShowFlowBlockAsync(ShowFlowBlockRequest showFlowBlockRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/ddos/flow-block", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowBlockRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFlowBlockResponse>(response);
        }

        public AsyncInvoker<ShowFlowBlockResponse> ShowFlowBlockAsyncInvoker(ShowFlowBlockRequest showFlowBlockRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/ddos/flow-block", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowBlockRequest);
            return new AsyncInvoker<ShowFlowBlockResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFlowBlockResponse>);
        }
        
        /// <summary>
        /// 查询WEB防护策略配置
        ///
        /// 查询WEB防护策略配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWafPolicyResponse> ShowWafPolicyAsync(ShowWafPolicyRequest showWafPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWafPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowWafPolicyResponse>(response);
        }

        public AsyncInvoker<ShowWafPolicyResponse> ShowWafPolicyAsyncInvoker(ShowWafPolicyRequest showWafPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/policies/waf", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWafPolicyRequest);
            return new AsyncInvoker<ShowWafPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWafPolicyResponse>);
        }
        
        /// <summary>
        /// 查询CC攻击防护请求QPS
        ///
        /// 查询CC攻击防护请求QPS
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWafQpsResponse> ShowWafQpsAsync(ShowWafQpsRequest showWafQpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains/waf-info/flow/request/peak", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWafQpsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowWafQpsResponse>(response);
        }

        public AsyncInvoker<ShowWafQpsResponse> ShowWafQpsAsyncInvoker(ShowWafQpsRequest showWafQpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains/waf-info/flow/request/peak", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWafQpsRequest);
            return new AsyncInvoker<ShowWafQpsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWafQpsResponse>);
        }
        
        /// <summary>
        /// 修改实例规格
        ///
        /// 修改实例规格
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpgradeInstanceSpecResponse> UpgradeInstanceSpecAsync(UpgradeInstanceSpecRequest upgradeInstanceSpecRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeInstanceSpecRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpgradeInstanceSpecResponse>(response);
        }

        public AsyncInvoker<UpgradeInstanceSpecResponse> UpgradeInstanceSpecAsyncInvoker(UpgradeInstanceSpecRequest upgradeInstanceSpecRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeInstanceSpecRequest);
            return new AsyncInvoker<UpgradeInstanceSpecResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpgradeInstanceSpecResponse>);
        }
        
        /// <summary>
        /// 删除防护域名
        ///
        /// 删除防护域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest deleteDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDomainResponse>(response);
        }

        public AsyncInvoker<DeleteDomainResponse> DeleteDomainAsyncInvoker(DeleteDomainRequest deleteDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/aad/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            return new AsyncInvoker<DeleteDomainResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDomainResponse>);
        }
        
    }
}