using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Nat.V2.Model;

namespace HuaweiCloud.SDK.Nat.V2
{
    public partial class NatClient : Client
    {
        public static ClientBuilder<NatClient> NewBuilder()
        {
            return new ClientBuilder<NatClient>();
        }

        
        /// <summary>
        /// 批量创建DNAT规则
        ///
        /// 批量创建DNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateNatGatewayDnatRulesResponse BatchCreateNatGatewayDnatRules(BatchCreateNatGatewayDnatRulesRequest batchCreateNatGatewayDnatRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules/batch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateNatGatewayDnatRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchCreateNatGatewayDnatRulesResponse>(response);
        }
        
        /// <summary>
        /// 创建DNAT规则
        ///
        /// 创建DNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateNatGatewayDnatRuleResponse CreateNatGatewayDnatRule(CreateNatGatewayDnatRuleRequest createNatGatewayDnatRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNatGatewayDnatRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateNatGatewayDnatRuleResponse>(response);
        }
        
        /// <summary>
        /// 删除DNAT规则
        ///
        /// 删除指定的DNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteNatGatewayDnatRuleResponse DeleteNatGatewayDnatRule(DeleteNatGatewayDnatRuleRequest deleteNatGatewayDnatRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id" , deleteNatGatewayDnatRuleRequest.NatGatewayId.ToString());
            urlParam.Add("dnat_rule_id" , deleteNatGatewayDnatRuleRequest.DnatRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}/dnat_rules/{dnat_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNatGatewayDnatRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteNatGatewayDnatRuleResponse>(response);
        }
        
        /// <summary>
        /// 查询DNAT规则列表
        ///
        /// 查询DNAT规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNatGatewayDnatRulesResponse ListNatGatewayDnatRules(ListNatGatewayDnatRulesRequest listNatGatewayDnatRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewayDnatRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListNatGatewayDnatRulesResponse>(response);
        }
        
        /// <summary>
        /// 查询指定的DNAT规则详情
        ///
        /// 查询指定的DNAT规则详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowNatGatewayDnatRuleResponse ShowNatGatewayDnatRule(ShowNatGatewayDnatRuleRequest showNatGatewayDnatRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("dnat_rule_id" , showNatGatewayDnatRuleRequest.DnatRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules/{dnat_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNatGatewayDnatRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowNatGatewayDnatRuleResponse>(response);
        }
        
        /// <summary>
        /// 更新DNAT规则
        ///
        /// 更新指定的DNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateNatGatewayDnatRuleResponse UpdateNatGatewayDnatRule(UpdateNatGatewayDnatRuleRequest updateNatGatewayDnatRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("dnat_rule_id" , updateNatGatewayDnatRuleRequest.DnatRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules/{dnat_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNatGatewayDnatRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateNatGatewayDnatRuleResponse>(response);
        }
        
        /// <summary>
        /// 创建公网NAT网关
        ///
        /// 创建公网NAT网关实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateNatGatewayResponse CreateNatGateway(CreateNatGatewayRequest createNatGatewayRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNatGatewayRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateNatGatewayResponse>(response);
        }
        
        /// <summary>
        /// 删除公网NAT网关
        ///
        /// 删除公网NAT网关实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteNatGatewayResponse DeleteNatGateway(DeleteNatGatewayRequest deleteNatGatewayRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id" , deleteNatGatewayRequest.NatGatewayId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNatGatewayRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteNatGatewayResponse>(response);
        }
        
        /// <summary>
        /// 查询公网NAT网关列表
        ///
        /// 查询公网NAT网关实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNatGatewaysResponse ListNatGateways(ListNatGatewaysRequest listNatGatewaysRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewaysRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListNatGatewaysResponse>(response);
        }
        
        /// <summary>
        /// 查询指定的公网NAT网关详情
        ///
        /// 查询指定的公网NAT网关实例详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowNatGatewayResponse ShowNatGateway(ShowNatGatewayRequest showNatGatewayRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id" , showNatGatewayRequest.NatGatewayId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNatGatewayRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowNatGatewayResponse>(response);
        }
        
        /// <summary>
        /// 更新公网NAT网关
        ///
        /// 更新公网NAT网关实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateNatGatewayResponse UpdateNatGateway(UpdateNatGatewayRequest updateNatGatewayRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id" , updateNatGatewayRequest.NatGatewayId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNatGatewayRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateNatGatewayResponse>(response);
        }
        
        /// <summary>
        /// 创建SNAT规则
        ///
        /// 创建SNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateNatGatewaySnatRuleResponse CreateNatGatewaySnatRule(CreateNatGatewaySnatRuleRequest createNatGatewaySnatRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snat_rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNatGatewaySnatRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateNatGatewaySnatRuleResponse>(response);
        }
        
        /// <summary>
        /// 删除SNAT规则
        ///
        /// 删除指定的SNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteNatGatewaySnatRuleResponse DeleteNatGatewaySnatRule(DeleteNatGatewaySnatRuleRequest deleteNatGatewaySnatRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id" , deleteNatGatewaySnatRuleRequest.NatGatewayId.ToString());
            urlParam.Add("snat_rule_id" , deleteNatGatewaySnatRuleRequest.SnatRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}/snat_rules/{snat_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNatGatewaySnatRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteNatGatewaySnatRuleResponse>(response);
        }
        
        /// <summary>
        /// 查询SNAT规则列表
        ///
        /// 查询SNAT规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNatGatewaySnatRulesResponse ListNatGatewaySnatRules(ListNatGatewaySnatRulesRequest listNatGatewaySnatRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snat_rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewaySnatRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListNatGatewaySnatRulesResponse>(response);
        }
        
        /// <summary>
        /// 查询指定的SNAT规则详情
        ///
        /// 查询指定的SNAT规则详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowNatGatewaySnatRuleResponse ShowNatGatewaySnatRule(ShowNatGatewaySnatRuleRequest showNatGatewaySnatRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snat_rule_id" , showNatGatewaySnatRuleRequest.SnatRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snat_rules/{snat_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNatGatewaySnatRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowNatGatewaySnatRuleResponse>(response);
        }
        
        /// <summary>
        /// 更新SNAT规则
        ///
        /// 更新指定的SNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateNatGatewaySnatRuleResponse UpdateNatGatewaySnatRule(UpdateNatGatewaySnatRuleRequest updateNatGatewaySnatRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snat_rule_id" , updateNatGatewaySnatRuleRequest.SnatRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snat_rules/{snat_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNatGatewaySnatRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateNatGatewaySnatRuleResponse>(response);
        }
        
    }
}