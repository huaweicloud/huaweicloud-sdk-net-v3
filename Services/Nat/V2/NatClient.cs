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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules/batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateNatGatewayDnatRulesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateNatGatewayDnatRulesResponse>(response);
        }

        public SyncInvoker<BatchCreateNatGatewayDnatRulesResponse> BatchCreateNatGatewayDnatRulesInvoker(BatchCreateNatGatewayDnatRulesRequest batchCreateNatGatewayDnatRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules/batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateNatGatewayDnatRulesRequest);
            return new SyncInvoker<BatchCreateNatGatewayDnatRulesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateNatGatewayDnatRulesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNatGatewayDnatRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateNatGatewayDnatRuleResponse>(response);
        }

        public SyncInvoker<CreateNatGatewayDnatRuleResponse> CreateNatGatewayDnatRuleInvoker(CreateNatGatewayDnatRuleRequest createNatGatewayDnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNatGatewayDnatRuleRequest);
            return new SyncInvoker<CreateNatGatewayDnatRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNatGatewayDnatRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateDnatRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePrivateDnatResponse>(response);
        }

        public SyncInvoker<CreatePrivateDnatResponse> CreatePrivateDnatInvoker(CreatePrivateDnatRequest createPrivateDnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateDnatRequest);
            return new SyncInvoker<CreatePrivateDnatResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePrivateDnatResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id", deleteNatGatewayDnatRuleRequest.NatGatewayId.ToString());
            urlParam.Add("dnat_rule_id", deleteNatGatewayDnatRuleRequest.DnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}/dnat_rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNatGatewayDnatRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNatGatewayDnatRuleResponse>(response);
        }

        public SyncInvoker<DeleteNatGatewayDnatRuleResponse> DeleteNatGatewayDnatRuleInvoker(DeleteNatGatewayDnatRuleRequest deleteNatGatewayDnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id", deleteNatGatewayDnatRuleRequest.NatGatewayId.ToString());
            urlParam.Add("dnat_rule_id", deleteNatGatewayDnatRuleRequest.DnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}/dnat_rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNatGatewayDnatRuleRequest);
            return new SyncInvoker<DeleteNatGatewayDnatRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteNatGatewayDnatRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dnat_rule_id", deletePrivateDnatRequest.DnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateDnatRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePrivateDnatResponse>(response);
        }

        public SyncInvoker<DeletePrivateDnatResponse> DeletePrivateDnatInvoker(DeletePrivateDnatRequest deletePrivateDnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dnat_rule_id", deletePrivateDnatRequest.DnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateDnatRequest);
            return new SyncInvoker<DeletePrivateDnatResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePrivateDnatResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewayDnatRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNatGatewayDnatRulesResponse>(response);
        }

        public SyncInvoker<ListNatGatewayDnatRulesResponse> ListNatGatewayDnatRulesInvoker(ListNatGatewayDnatRulesRequest listNatGatewayDnatRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewayDnatRulesRequest);
            return new SyncInvoker<ListNatGatewayDnatRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNatGatewayDnatRulesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateDnatsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPrivateDnatsResponse>(response);
        }

        public SyncInvoker<ListPrivateDnatsResponse> ListPrivateDnatsInvoker(ListPrivateDnatsRequest listPrivateDnatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateDnatsRequest);
            return new SyncInvoker<ListPrivateDnatsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPrivateDnatsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dnat_rule_id", showNatGatewayDnatRuleRequest.DnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNatGatewayDnatRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowNatGatewayDnatRuleResponse>(response);
        }

        public SyncInvoker<ShowNatGatewayDnatRuleResponse> ShowNatGatewayDnatRuleInvoker(ShowNatGatewayDnatRuleRequest showNatGatewayDnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dnat_rule_id", showNatGatewayDnatRuleRequest.DnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNatGatewayDnatRuleRequest);
            return new SyncInvoker<ShowNatGatewayDnatRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNatGatewayDnatRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dnat_rule_id", showPrivateDnatRequest.DnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateDnatRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPrivateDnatResponse>(response);
        }

        public SyncInvoker<ShowPrivateDnatResponse> ShowPrivateDnatInvoker(ShowPrivateDnatRequest showPrivateDnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dnat_rule_id", showPrivateDnatRequest.DnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateDnatRequest);
            return new SyncInvoker<ShowPrivateDnatResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPrivateDnatResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dnat_rule_id", updateNatGatewayDnatRuleRequest.DnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNatGatewayDnatRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNatGatewayDnatRuleResponse>(response);
        }

        public SyncInvoker<UpdateNatGatewayDnatRuleResponse> UpdateNatGatewayDnatRuleInvoker(UpdateNatGatewayDnatRuleRequest updateNatGatewayDnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dnat_rule_id", updateNatGatewayDnatRuleRequest.DnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNatGatewayDnatRuleRequest);
            return new SyncInvoker<UpdateNatGatewayDnatRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNatGatewayDnatRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dnat_rule_id", updatePrivateDnatRequest.DnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateDnatRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePrivateDnatResponse>(response);
        }

        public SyncInvoker<UpdatePrivateDnatResponse> UpdatePrivateDnatInvoker(UpdatePrivateDnatRequest updatePrivateDnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("dnat_rule_id", updatePrivateDnatRequest.DnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateDnatRequest);
            return new SyncInvoker<UpdatePrivateDnatResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePrivateDnatResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateDeleteTransitIpTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDeleteTransitIpTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateDeleteTransitIpTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateDeleteTransitIpTagsResponse> BatchCreateDeleteTransitIpTagsInvoker(BatchCreateDeleteTransitIpTagsRequest batchCreateDeleteTransitIpTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateDeleteTransitIpTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDeleteTransitIpTagsRequest);
            return new SyncInvoker<BatchCreateDeleteTransitIpTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateDeleteTransitIpTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", createTransitIpTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTransitIpTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTransitIpTagResponse>(response);
        }

        public SyncInvoker<CreateTransitIpTagResponse> CreateTransitIpTagInvoker(CreateTransitIpTagRequest createTransitIpTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", createTransitIpTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTransitIpTagRequest);
            return new SyncInvoker<CreateTransitIpTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTransitIpTagResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key", deleteTransitIpTagRequest.Key.ToString());
            urlParam.Add("resource_id", deleteTransitIpTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/{resource_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTransitIpTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTransitIpTagResponse>(response);
        }

        public SyncInvoker<DeleteTransitIpTagResponse> DeleteTransitIpTagInvoker(DeleteTransitIpTagRequest deleteTransitIpTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key", deleteTransitIpTagRequest.Key.ToString());
            urlParam.Add("resource_id", deleteTransitIpTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/{resource_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTransitIpTagRequest);
            return new SyncInvoker<DeleteTransitIpTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTransitIpTagResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitIpTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTransitIpTagsResponse>(response);
        }

        public SyncInvoker<ListTransitIpTagsResponse> ListTransitIpTagsInvoker(ListTransitIpTagsRequest listTransitIpTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitIpTagsRequest);
            return new SyncInvoker<ListTransitIpTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTransitIpTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitIpsByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListTransitIpsByTagsResponse>(response);
        }

        public SyncInvoker<ListTransitIpsByTagsResponse> ListTransitIpsByTagsInvoker(ListTransitIpsByTagsRequest listTransitIpsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitIpsByTagsRequest);
            return new SyncInvoker<ListTransitIpsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTransitIpsByTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showTransitIpTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransitIpTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTransitIpTagsResponse>(response);
        }

        public SyncInvoker<ShowTransitIpTagsResponse> ShowTransitIpTagsInvoker(ShowTransitIpTagsRequest showTransitIpTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showTransitIpTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransitIpTagsRequest);
            return new SyncInvoker<ShowTransitIpTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTransitIpTagsResponse>);
        }
        
        /// <summary>
        /// 批量添加/删除公网NAT网关资源标签
        ///
        /// - 为指定公网NAT网关实例批量添加或删除标签。 
        /// - 标签管理服务需要使用该接口批量管理实例的标签。 
        /// - 一个资源上最多有10个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateDeleteNatGatewayTagResponse BatchCreateDeleteNatGatewayTag(BatchCreateDeleteNatGatewayTagRequest batchCreateDeleteNatGatewayTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id", batchCreateDeleteNatGatewayTagRequest.NatGatewayId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/{nat_gateway_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDeleteNatGatewayTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateDeleteNatGatewayTagResponse>(response);
        }

        public SyncInvoker<BatchCreateDeleteNatGatewayTagResponse> BatchCreateDeleteNatGatewayTagInvoker(BatchCreateDeleteNatGatewayTagRequest batchCreateDeleteNatGatewayTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id", batchCreateDeleteNatGatewayTagRequest.NatGatewayId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/{nat_gateway_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDeleteNatGatewayTagRequest);
            return new SyncInvoker<BatchCreateDeleteNatGatewayTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateDeleteNatGatewayTagResponse>);
        }
        
        /// <summary>
        /// 添加公网NAT网关资源标签
        ///
        /// - 添加公网NAT网关资源标签。一个资源上最多有10个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateNatGatewayTagResponse CreateNatGatewayTag(CreateNatGatewayTagRequest createNatGatewayTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id", createNatGatewayTagRequest.NatGatewayId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/{nat_gateway_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNatGatewayTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateNatGatewayTagResponse>(response);
        }

        public SyncInvoker<CreateNatGatewayTagResponse> CreateNatGatewayTagInvoker(CreateNatGatewayTagRequest createNatGatewayTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id", createNatGatewayTagRequest.NatGatewayId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/{nat_gateway_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNatGatewayTagRequest);
            return new SyncInvoker<CreateNatGatewayTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateNatGatewayTagResponse>);
        }
        
        /// <summary>
        /// 删除公网NAT网关资源标签
        ///
        /// - 删除指定公网NAT网关资源实例的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteNatGatewayTagResponse DeleteNatGatewayTag(DeleteNatGatewayTagRequest deleteNatGatewayTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id", deleteNatGatewayTagRequest.NatGatewayId.ToString());
            urlParam.Add("key", deleteNatGatewayTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/{nat_gateway_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNatGatewayTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNatGatewayTagResponse>(response);
        }

        public SyncInvoker<DeleteNatGatewayTagResponse> DeleteNatGatewayTagInvoker(DeleteNatGatewayTagRequest deleteNatGatewayTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id", deleteNatGatewayTagRequest.NatGatewayId.ToString());
            urlParam.Add("key", deleteNatGatewayTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/{nat_gateway_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNatGatewayTagRequest);
            return new SyncInvoker<DeleteNatGatewayTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteNatGatewayTagResponse>);
        }
        
        /// <summary>
        /// 查询公网NAT网关资源实例
        ///
        /// - 使用标签过滤公网NAT网关资源实例。
        /// - 标签管理服务需要提供按标签过滤公网NAT网关服务实例并汇总显示在列表中，需要公网NAT网关服务提供查询能力。
        /// - 资源默认按照创建时间倒序，资源tag也按照创建时间倒序。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNatGatewayByTagResponse ListNatGatewayByTag(ListNatGatewayByTagRequest listNatGatewayByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewayByTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListNatGatewayByTagResponse>(response);
        }

        public SyncInvoker<ListNatGatewayByTagResponse> ListNatGatewayByTagInvoker(ListNatGatewayByTagRequest listNatGatewayByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewayByTagRequest);
            return new SyncInvoker<ListNatGatewayByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<ListNatGatewayByTagResponse>);
        }
        
        /// <summary>
        /// 查询公网NAT网关项目标签
        ///
        /// - 查询租户在指定项目和公网NAT网关实例类型的所有标签集合。
        /// - 标签管理服务需要能够列出当前租户全部已使用的标签集合，为各服务Console打标签和过滤实例时提供标签联想功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNatGatewayTagResponse ListNatGatewayTag(ListNatGatewayTagRequest listNatGatewayTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewayTagRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNatGatewayTagResponse>(response);
        }

        public SyncInvoker<ListNatGatewayTagResponse> ListNatGatewayTagInvoker(ListNatGatewayTagRequest listNatGatewayTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewayTagRequest);
            return new SyncInvoker<ListNatGatewayTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNatGatewayTagResponse>);
        }
        
        /// <summary>
        /// 查询公网NAT网关资源标签
        ///
        /// - 查询指定公网NAT网关实例的标签信息。
        /// - 标签管理服务需要使用该接口查询指定公网NAT网关实例的全部标签数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowNatGatewayTagResponse ShowNatGatewayTag(ShowNatGatewayTagRequest showNatGatewayTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id", showNatGatewayTagRequest.NatGatewayId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/{nat_gateway_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNatGatewayTagRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowNatGatewayTagResponse>(response);
        }

        public SyncInvoker<ShowNatGatewayTagResponse> ShowNatGatewayTagInvoker(ShowNatGatewayTagRequest showNatGatewayTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id", showNatGatewayTagRequest.NatGatewayId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/{nat_gateway_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNatGatewayTagRequest);
            return new SyncInvoker<ShowNatGatewayTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNatGatewayTagResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateDeletePrivateNatTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDeletePrivateNatTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateDeletePrivateNatTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateDeletePrivateNatTagsResponse> BatchCreateDeletePrivateNatTagsInvoker(BatchCreateDeletePrivateNatTagsRequest batchCreateDeletePrivateNatTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateDeletePrivateNatTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDeletePrivateNatTagsRequest);
            return new SyncInvoker<BatchCreateDeletePrivateNatTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateDeletePrivateNatTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNatGatewayRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateNatGatewayResponse>(response);
        }

        public SyncInvoker<CreateNatGatewayResponse> CreateNatGatewayInvoker(CreateNatGatewayRequest createNatGatewayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNatGatewayRequest);
            return new SyncInvoker<CreateNatGatewayResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNatGatewayResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateNatRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePrivateNatResponse>(response);
        }

        public SyncInvoker<CreatePrivateNatResponse> CreatePrivateNatInvoker(CreatePrivateNatRequest createPrivateNatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateNatRequest);
            return new SyncInvoker<CreatePrivateNatResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePrivateNatResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", createPrivateNatTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateNatTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreatePrivateNatTagResponse>(response);
        }

        public SyncInvoker<CreatePrivateNatTagResponse> CreatePrivateNatTagInvoker(CreatePrivateNatTagRequest createPrivateNatTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", createPrivateNatTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateNatTagRequest);
            return new SyncInvoker<CreatePrivateNatTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreatePrivateNatTagResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id", deleteNatGatewayRequest.NatGatewayId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNatGatewayRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNatGatewayResponse>(response);
        }

        public SyncInvoker<DeleteNatGatewayResponse> DeleteNatGatewayInvoker(DeleteNatGatewayRequest deleteNatGatewayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id", deleteNatGatewayRequest.NatGatewayId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNatGatewayRequest);
            return new SyncInvoker<DeleteNatGatewayResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteNatGatewayResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("gateway_id", deletePrivateNatRequest.GatewayId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways/{gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateNatRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePrivateNatResponse>(response);
        }

        public SyncInvoker<DeletePrivateNatResponse> DeletePrivateNatInvoker(DeletePrivateNatRequest deletePrivateNatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("gateway_id", deletePrivateNatRequest.GatewayId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways/{gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateNatRequest);
            return new SyncInvoker<DeletePrivateNatResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePrivateNatResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key", deletePrivateNatTagRequest.Key.ToString());
            urlParam.Add("resource_id", deletePrivateNatTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/{resource_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateNatTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePrivateNatTagResponse>(response);
        }

        public SyncInvoker<DeletePrivateNatTagResponse> DeletePrivateNatTagInvoker(DeletePrivateNatTagRequest deletePrivateNatTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key", deletePrivateNatTagRequest.Key.ToString());
            urlParam.Add("resource_id", deletePrivateNatTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/{resource_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateNatTagRequest);
            return new SyncInvoker<DeletePrivateNatTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePrivateNatTagResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewaysRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNatGatewaysResponse>(response);
        }

        public SyncInvoker<ListNatGatewaysResponse> ListNatGatewaysInvoker(ListNatGatewaysRequest listNatGatewaysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewaysRequest);
            return new SyncInvoker<ListNatGatewaysResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNatGatewaysResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateNatTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPrivateNatTagsResponse>(response);
        }

        public SyncInvoker<ListPrivateNatTagsResponse> ListPrivateNatTagsInvoker(ListPrivateNatTagsRequest listPrivateNatTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateNatTagsRequest);
            return new SyncInvoker<ListPrivateNatTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPrivateNatTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateNatsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPrivateNatsResponse>(response);
        }

        public SyncInvoker<ListPrivateNatsResponse> ListPrivateNatsInvoker(ListPrivateNatsRequest listPrivateNatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateNatsRequest);
            return new SyncInvoker<ListPrivateNatsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPrivateNatsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateNatsByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListPrivateNatsByTagsResponse>(response);
        }

        public SyncInvoker<ListPrivateNatsByTagsResponse> ListPrivateNatsByTagsInvoker(ListPrivateNatsByTagsRequest listPrivateNatsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateNatsByTagsRequest);
            return new SyncInvoker<ListPrivateNatsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListPrivateNatsByTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id", showNatGatewayRequest.NatGatewayId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNatGatewayRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowNatGatewayResponse>(response);
        }

        public SyncInvoker<ShowNatGatewayResponse> ShowNatGatewayInvoker(ShowNatGatewayRequest showNatGatewayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id", showNatGatewayRequest.NatGatewayId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNatGatewayRequest);
            return new SyncInvoker<ShowNatGatewayResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNatGatewayResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("gateway_id", showPrivateNatRequest.GatewayId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways/{gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateNatRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPrivateNatResponse>(response);
        }

        public SyncInvoker<ShowPrivateNatResponse> ShowPrivateNatInvoker(ShowPrivateNatRequest showPrivateNatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("gateway_id", showPrivateNatRequest.GatewayId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways/{gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateNatRequest);
            return new SyncInvoker<ShowPrivateNatResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPrivateNatResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showPrivateNatTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateNatTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPrivateNatTagsResponse>(response);
        }

        public SyncInvoker<ShowPrivateNatTagsResponse> ShowPrivateNatTagsInvoker(ShowPrivateNatTagsRequest showPrivateNatTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showPrivateNatTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateNatTagsRequest);
            return new SyncInvoker<ShowPrivateNatTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPrivateNatTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id", updateNatGatewayRequest.NatGatewayId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNatGatewayRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNatGatewayResponse>(response);
        }

        public SyncInvoker<UpdateNatGatewayResponse> UpdateNatGatewayInvoker(UpdateNatGatewayRequest updateNatGatewayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id", updateNatGatewayRequest.NatGatewayId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNatGatewayRequest);
            return new SyncInvoker<UpdateNatGatewayResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNatGatewayResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("gateway_id", updatePrivateNatRequest.GatewayId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways/{gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateNatRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePrivateNatResponse>(response);
        }

        public SyncInvoker<UpdatePrivateNatResponse> UpdatePrivateNatInvoker(UpdatePrivateNatRequest updatePrivateNatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("gateway_id", updatePrivateNatRequest.GatewayId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways/{gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateNatRequest);
            return new SyncInvoker<UpdatePrivateNatResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePrivateNatResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTransitIpRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTransitIpResponse>(response);
        }

        public SyncInvoker<CreateTransitIpResponse> CreateTransitIpInvoker(CreateTransitIpRequest createTransitIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTransitIpRequest);
            return new SyncInvoker<CreateTransitIpResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTransitIpResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("transit_ip_id", deleteTransitIpRequest.TransitIpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-ips/{transit_ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTransitIpRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTransitIpResponse>(response);
        }

        public SyncInvoker<DeleteTransitIpResponse> DeleteTransitIpInvoker(DeleteTransitIpRequest deleteTransitIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("transit_ip_id", deleteTransitIpRequest.TransitIpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-ips/{transit_ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTransitIpRequest);
            return new SyncInvoker<DeleteTransitIpResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTransitIpResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitIpsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTransitIpsResponse>(response);
        }

        public SyncInvoker<ListTransitIpsResponse> ListTransitIpsInvoker(ListTransitIpsRequest listTransitIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitIpsRequest);
            return new SyncInvoker<ListTransitIpsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTransitIpsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("transit_ip_id", showTransitIpRequest.TransitIpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-ips/{transit_ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransitIpRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTransitIpResponse>(response);
        }

        public SyncInvoker<ShowTransitIpResponse> ShowTransitIpInvoker(ShowTransitIpRequest showTransitIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("transit_ip_id", showTransitIpRequest.TransitIpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-ips/{transit_ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransitIpRequest);
            return new SyncInvoker<ShowTransitIpResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTransitIpResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snat_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNatGatewaySnatRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateNatGatewaySnatRuleResponse>(response);
        }

        public SyncInvoker<CreateNatGatewaySnatRuleResponse> CreateNatGatewaySnatRuleInvoker(CreateNatGatewaySnatRuleRequest createNatGatewaySnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snat_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNatGatewaySnatRuleRequest);
            return new SyncInvoker<CreateNatGatewaySnatRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNatGatewaySnatRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateSnatRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePrivateSnatResponse>(response);
        }

        public SyncInvoker<CreatePrivateSnatResponse> CreatePrivateSnatInvoker(CreatePrivateSnatRequest createPrivateSnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateSnatRequest);
            return new SyncInvoker<CreatePrivateSnatResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePrivateSnatResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id", deleteNatGatewaySnatRuleRequest.NatGatewayId.ToString());
            urlParam.Add("snat_rule_id", deleteNatGatewaySnatRuleRequest.SnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}/snat_rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNatGatewaySnatRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNatGatewaySnatRuleResponse>(response);
        }

        public SyncInvoker<DeleteNatGatewaySnatRuleResponse> DeleteNatGatewaySnatRuleInvoker(DeleteNatGatewaySnatRuleRequest deleteNatGatewaySnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("nat_gateway_id", deleteNatGatewaySnatRuleRequest.NatGatewayId.ToString());
            urlParam.Add("snat_rule_id", deleteNatGatewaySnatRuleRequest.SnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}/snat_rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNatGatewaySnatRuleRequest);
            return new SyncInvoker<DeleteNatGatewaySnatRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteNatGatewaySnatRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snat_rule_id", deletePrivateSnatRequest.SnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateSnatRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePrivateSnatResponse>(response);
        }

        public SyncInvoker<DeletePrivateSnatResponse> DeletePrivateSnatInvoker(DeletePrivateSnatRequest deletePrivateSnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snat_rule_id", deletePrivateSnatRequest.SnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateSnatRequest);
            return new SyncInvoker<DeletePrivateSnatResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePrivateSnatResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snat_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewaySnatRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNatGatewaySnatRulesResponse>(response);
        }

        public SyncInvoker<ListNatGatewaySnatRulesResponse> ListNatGatewaySnatRulesInvoker(ListNatGatewaySnatRulesRequest listNatGatewaySnatRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snat_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewaySnatRulesRequest);
            return new SyncInvoker<ListNatGatewaySnatRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNatGatewaySnatRulesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateSnatsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPrivateSnatsResponse>(response);
        }

        public SyncInvoker<ListPrivateSnatsResponse> ListPrivateSnatsInvoker(ListPrivateSnatsRequest listPrivateSnatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateSnatsRequest);
            return new SyncInvoker<ListPrivateSnatsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPrivateSnatsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snat_rule_id", showNatGatewaySnatRuleRequest.SnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snat_rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNatGatewaySnatRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowNatGatewaySnatRuleResponse>(response);
        }

        public SyncInvoker<ShowNatGatewaySnatRuleResponse> ShowNatGatewaySnatRuleInvoker(ShowNatGatewaySnatRuleRequest showNatGatewaySnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snat_rule_id", showNatGatewaySnatRuleRequest.SnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snat_rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNatGatewaySnatRuleRequest);
            return new SyncInvoker<ShowNatGatewaySnatRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNatGatewaySnatRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snat_rule_id", showPrivateSnatRequest.SnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateSnatRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPrivateSnatResponse>(response);
        }

        public SyncInvoker<ShowPrivateSnatResponse> ShowPrivateSnatInvoker(ShowPrivateSnatRequest showPrivateSnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snat_rule_id", showPrivateSnatRequest.SnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateSnatRequest);
            return new SyncInvoker<ShowPrivateSnatResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPrivateSnatResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snat_rule_id", updateNatGatewaySnatRuleRequest.SnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snat_rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNatGatewaySnatRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNatGatewaySnatRuleResponse>(response);
        }

        public SyncInvoker<UpdateNatGatewaySnatRuleResponse> UpdateNatGatewaySnatRuleInvoker(UpdateNatGatewaySnatRuleRequest updateNatGatewaySnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snat_rule_id", updateNatGatewaySnatRuleRequest.SnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snat_rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNatGatewaySnatRuleRequest);
            return new SyncInvoker<UpdateNatGatewaySnatRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNatGatewaySnatRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snat_rule_id", updatePrivateSnatRequest.SnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateSnatRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePrivateSnatResponse>(response);
        }

        public SyncInvoker<UpdatePrivateSnatResponse> UpdatePrivateSnatInvoker(UpdatePrivateSnatRequest updatePrivateSnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("snat_rule_id", updatePrivateSnatRequest.SnatRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateSnatRequest);
            return new SyncInvoker<UpdatePrivateSnatResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePrivateSnatResponse>);
        }
        
    }
}