using System;
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
        /// 创建DNAT规则
        ///
        /// 创建DNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePrivateDnatResponse CreatePrivateDnat(CreatePrivateDnatRequest createPrivateDnatRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateDnatRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePrivateDnatResponse>(response);
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
        /// 删除DNAT规则
        ///
        /// 删除指定的DNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePrivateDnatResponse DeletePrivateDnat(DeletePrivateDnatRequest deletePrivateDnatRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("dnat_rule_id" , deletePrivateDnatRequest.DnatRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules/{dnat_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateDnatRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePrivateDnatResponse>(response);
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
        /// 查询DNAT规则列表
        ///
        /// 查询DNAT规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPrivateDnatsResponse ListPrivateDnats(ListPrivateDnatsRequest listPrivateDnatsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateDnatsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPrivateDnatsResponse>(response);
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
        /// 查询指定的DNAT规则详情
        ///
        /// 查询指定的DNAT规则详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPrivateDnatResponse ShowPrivateDnat(ShowPrivateDnatRequest showPrivateDnatRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("dnat_rule_id" , showPrivateDnatRequest.DnatRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules/{dnat_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateDnatRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPrivateDnatResponse>(response);
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
        /// 更新DNAT规则
        ///
        /// 更新指定的DNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePrivateDnatResponse UpdatePrivateDnat(UpdatePrivateDnatRequest updatePrivateDnatRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("dnat_rule_id" , updatePrivateDnatRequest.DnatRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules/{dnat_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateDnatRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePrivateDnatResponse>(response);
        }
        
        /// <summary>
        /// 批量添加删除中转IP标签
        ///
        /// - 为指定中转IP实例批量添加或删除标签
        /// - 标签管理服务需要使用该接口批量管理中转IP实例的标签。
        /// - 一个中转IP上最多有10个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateDeleteTransitIpTagsResponse BatchCreateDeleteTransitIpTags(BatchCreateDeleteTransitIpTagsRequest batchCreateDeleteTransitIpTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id" , batchCreateDeleteTransitIpTagsRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/{resource_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDeleteTransitIpTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateDeleteTransitIpTagsResponse>(response);
        }
        
        /// <summary>
        /// 添加中转IP标签
        ///
        /// - 一个中转IP上最多有10个标签。
        /// - 此接口为幂等接口：
        /// - 创建时，如果创建的标签已经存在（key相同），则覆盖。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTransitIpTagResponse CreateTransitIpTag(CreateTransitIpTagRequest createTransitIpTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id" , createTransitIpTagRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/{resource_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTransitIpTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateTransitIpTagResponse>(response);
        }
        
        /// <summary>
        /// 删除中转IP标签
        ///
        /// - 幂等接口：
        /// - 删除时，不对标签字符集做校验，调用接口前必须要做encodeURI，服务端需要对接口uri做decodeURI。删除的key不存在报404，key不能为空或者空字符串。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTransitIpTagResponse DeleteTransitIpTag(DeleteTransitIpTagRequest deleteTransitIpTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key" , deleteTransitIpTagRequest.Key.ToString());
            urlParam.Add("resource_id" , deleteTransitIpTagRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/{resource_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTransitIpTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeleteTransitIpTagResponse deleteTransitIpTagResponse = JsonUtils.DeSerializeNull<DeleteTransitIpTagResponse>(response);
            return deleteTransitIpTagResponse;
        }
        
        /// <summary>
        /// 查询中转IP项目标签
        ///
        /// - 查询租户在指定Project和实例类型的所有中转IP标签集合。
        /// - 标签管理服务需要能够列出当前租户全部已使用的中转IP标签集合，为打中转IP标签和过滤中转IP实例时提供标签联想功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTransitIpTagsResponse ListTransitIpTags(ListTransitIpTagsRequest listTransitIpTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitIpTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTransitIpTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询中转IP实例
        ///
        /// - 使用标签过滤中转IP实例。
        /// - 标签管理服务需要提供按标签过滤中转IP服务实例并汇总显示在列表中，需要中转IP服务提供查询能力。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTransitIpsByTagsResponse ListTransitIpsByTags(ListTransitIpsByTagsRequest listTransitIpsByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitIpsByTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListTransitIpsByTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询中转IP标签
        ///
        /// - 查询指定中转IP实例的标签信息。
        /// - 标签管理服务需要使用该接口查询指定中转IP实例的全部标签数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTransitIpTagsResponse ShowTransitIpTags(ShowTransitIpTagsRequest showTransitIpTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id" , showTransitIpTagsRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/{resource_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransitIpTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowTransitIpTagsResponse>(response);
        }
        
        /// <summary>
        /// 批量添加删除私网NAT网关标签
        ///
        /// - 为指定私网NAT网关实例批量添加或删除标签
        /// - 标签管理服务需要使用该接口批量管理私网NAT网关实例的标签。
        /// - 一个私网NAT网关上最多有10个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateDeletePrivateNatTagsResponse BatchCreateDeletePrivateNatTags(BatchCreateDeletePrivateNatTagsRequest batchCreateDeletePrivateNatTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id" , batchCreateDeletePrivateNatTagsRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/{resource_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDeletePrivateNatTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateDeletePrivateNatTagsResponse>(response);
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
        /// 创建私网NAT网关
        ///
        /// 创建私网NAT网关实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePrivateNatResponse CreatePrivateNat(CreatePrivateNatRequest createPrivateNatRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateNatRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePrivateNatResponse>(response);
        }
        
        /// <summary>
        /// 添加私网NAT网关标签
        ///
        /// - 一个私网NAT网关上最多有10个标签。
        /// - 此接口为幂等接口：
        /// - 创建时，如果创建的标签已经存在（key相同），则覆盖。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePrivateNatTagResponse CreatePrivateNatTag(CreatePrivateNatTagRequest createPrivateNatTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id" , createPrivateNatTagRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/{resource_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateNatTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreatePrivateNatTagResponse>(response);
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
        /// 删除私网NAT网关
        ///
        /// 删除私网NAT网关实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePrivateNatResponse DeletePrivateNat(DeletePrivateNatRequest deletePrivateNatRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("gateway_id" , deletePrivateNatRequest.GatewayId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways/{gateway_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateNatRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePrivateNatResponse>(response);
        }
        
        /// <summary>
        /// 删除私网NAT网关标签
        ///
        /// - 幂等接口：
        /// - 删除时，不对标签字符集做校验，调用接口前必须要做encodeURI，服务端需要对接口uri做decodeURI。删除的key不存在报404，key不能为空或者空字符串。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePrivateNatTagResponse DeletePrivateNatTag(DeletePrivateNatTagRequest deletePrivateNatTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key" , deletePrivateNatTagRequest.Key.ToString());
            urlParam.Add("resource_id" , deletePrivateNatTagRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/{resource_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateNatTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeletePrivateNatTagResponse deletePrivateNatTagResponse = JsonUtils.DeSerializeNull<DeletePrivateNatTagResponse>(response);
            return deletePrivateNatTagResponse;
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
        /// 查询私网NAT网关项目标签
        ///
        /// - 查询租户在指定Project和实例类型的所有私网NAT网关标签集合。
        /// - 标签管理服务需要能够列出当前租户全部已使用的私网NAT网关标签集合，为打私网NAT网关标签和过滤私网NAT网关实例时提供标签联想功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPrivateNatTagsResponse ListPrivateNatTags(ListPrivateNatTagsRequest listPrivateNatTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateNatTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPrivateNatTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询私网NAT网关列表
        ///
        /// 查询私网NAT网关实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPrivateNatsResponse ListPrivateNats(ListPrivateNatsRequest listPrivateNatsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateNatsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPrivateNatsResponse>(response);
        }
        
        /// <summary>
        /// 查询私网NAT网关实例
        ///
        /// - 使用标签过滤私网NAT网关实例。
        /// - 标签管理服务需要提供按标签过滤私网NAT网关服务实例并汇总显示在列表中，需要私网NAT网关服务提供查询能力。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPrivateNatsByTagsResponse ListPrivateNatsByTags(ListPrivateNatsByTagsRequest listPrivateNatsByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateNatsByTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListPrivateNatsByTagsResponse>(response);
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
        /// 查询指定的私网NAT网关详情
        ///
        /// 查询指定的私网NAT网关实例详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPrivateNatResponse ShowPrivateNat(ShowPrivateNatRequest showPrivateNatRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("gateway_id" , showPrivateNatRequest.GatewayId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways/{gateway_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateNatRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPrivateNatResponse>(response);
        }
        
        /// <summary>
        /// 查询私网NAT网关标签
        ///
        /// - 查询指定私网NAT网关实例的标签信息。
        /// - 标签管理服务需要使用该接口查询指定私网NAT网关实例的全部标签数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPrivateNatTagsResponse ShowPrivateNatTags(ShowPrivateNatTagsRequest showPrivateNatTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id" , showPrivateNatTagsRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/{resource_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateNatTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPrivateNatTagsResponse>(response);
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
        /// 更新私网NAT网关
        ///
        /// 更新私网NAT网关实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePrivateNatResponse UpdatePrivateNat(UpdatePrivateNatRequest updatePrivateNatRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("gateway_id" , updatePrivateNatRequest.GatewayId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways/{gateway_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateNatRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePrivateNatResponse>(response);
        }
        
        /// <summary>
        /// 创建中转IP
        ///
        /// 创建中转IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTransitIpResponse CreateTransitIp(CreateTransitIpRequest createTransitIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-ips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTransitIpRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateTransitIpResponse>(response);
        }
        
        /// <summary>
        /// 删除中转IP
        ///
        /// 删除中转IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTransitIpResponse DeleteTransitIp(DeleteTransitIpRequest deleteTransitIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("transit_ip_id" , deleteTransitIpRequest.TransitIpId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-ips/{transit_ip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTransitIpRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTransitIpResponse>(response);
        }
        
        /// <summary>
        /// 查询中转IP列表
        ///
        /// 查询中转IP列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTransitIpsResponse ListTransitIps(ListTransitIpsRequest listTransitIpsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-ips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitIpsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTransitIpsResponse>(response);
        }
        
        /// <summary>
        /// 查询指定的中转IP详情
        ///
        /// 查询中转IP详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTransitIpResponse ShowTransitIp(ShowTransitIpRequest showTransitIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("transit_ip_id" , showTransitIpRequest.TransitIpId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-ips/{transit_ip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransitIpRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowTransitIpResponse>(response);
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
        /// 创建SNAT规则
        ///
        /// 创建SNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePrivateSnatResponse CreatePrivateSnat(CreatePrivateSnatRequest createPrivateSnatRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateSnatRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePrivateSnatResponse>(response);
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
        /// 删除SNAT规则
        ///
        /// 删除指定的SNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePrivateSnatResponse DeletePrivateSnat(DeletePrivateSnatRequest deletePrivateSnatRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snat_rule_id" , deletePrivateSnatRequest.SnatRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules/{snat_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateSnatRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePrivateSnatResponse>(response);
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
        /// 查询SNAT规则列表
        ///
        /// 查询SNAT规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPrivateSnatsResponse ListPrivateSnats(ListPrivateSnatsRequest listPrivateSnatsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateSnatsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPrivateSnatsResponse>(response);
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
        /// 查询指定的SNAT规则详情
        ///
        /// 查询指定的SNAT规则详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPrivateSnatResponse ShowPrivateSnat(ShowPrivateSnatRequest showPrivateSnatRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snat_rule_id" , showPrivateSnatRequest.SnatRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules/{snat_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateSnatRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPrivateSnatResponse>(response);
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
        
        /// <summary>
        /// 更新SNAT规则
        ///
        /// 更新指定的SNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePrivateSnatResponse UpdatePrivateSnat(UpdatePrivateSnatRequest updatePrivateSnatRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snat_rule_id" , updatePrivateSnatRequest.SnatRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules/{snat_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateSnatRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePrivateSnatResponse>(response);
        }
        
    }
}