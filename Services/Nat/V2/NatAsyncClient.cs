using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Nat.V2.Model;

namespace HuaweiCloud.SDK.Nat.V2
{
    public partial class NatAsyncClient : Client
    {
        public static ClientBuilder<NatAsyncClient> NewBuilder()
        {
            return new ClientBuilder<NatAsyncClient>();
        }

        
        /// <summary>
        /// 批量添加删除中转子网标签
        ///
        /// - 为指定中转子网实例批量添加或删除标签
        /// - 标签管理服务需要使用该接口批量管理中转子网实例的标签。
        /// - 一个中转子网上最多有20个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateDeleteTransitSubnetTagsResponse> BatchCreateDeleteTransitSubnetTagsAsync(BatchCreateDeleteTransitSubnetTagsRequest batchCreateDeleteTransitSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateDeleteTransitSubnetTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-subnets/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDeleteTransitSubnetTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateDeleteTransitSubnetTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateDeleteTransitSubnetTagsResponse> BatchCreateDeleteTransitSubnetTagsAsyncInvoker(BatchCreateDeleteTransitSubnetTagsRequest batchCreateDeleteTransitSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateDeleteTransitSubnetTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-subnets/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDeleteTransitSubnetTagsRequest);
            return new AsyncInvoker<BatchCreateDeleteTransitSubnetTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateDeleteTransitSubnetTagsResponse>);
        }
        
        /// <summary>
        /// 创建中转子网
        ///
        /// 创建中转子网。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTransitSubnetResponse> CreateTransitSubnetAsync(CreateTransitSubnetRequest createTransitSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTransitSubnetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTransitSubnetResponse>(response);
        }

        public AsyncInvoker<CreateTransitSubnetResponse> CreateTransitSubnetAsyncInvoker(CreateTransitSubnetRequest createTransitSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTransitSubnetRequest);
            return new AsyncInvoker<CreateTransitSubnetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTransitSubnetResponse>);
        }
        
        /// <summary>
        /// 添加中转子网标签
        ///
        /// - 为指定中转子网添加标签
        /// - 一个中转子网上最多有20个标签。
        /// - 此接口为幂等接口：
        /// - 创建时，如果创建的标签已经存在（key相同），则覆盖。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTransitSubnetTagResponse> CreateTransitSubnetTagAsync(CreateTransitSubnetTagRequest createTransitSubnetTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTransitSubnetTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-subnets/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTransitSubnetTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTransitSubnetTagResponse>(response);
        }

        public AsyncInvoker<CreateTransitSubnetTagResponse> CreateTransitSubnetTagAsyncInvoker(CreateTransitSubnetTagRequest createTransitSubnetTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTransitSubnetTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-subnets/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTransitSubnetTagRequest);
            return new AsyncInvoker<CreateTransitSubnetTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTransitSubnetTagResponse>);
        }
        
        /// <summary>
        /// 删除中转子网
        ///
        /// 删除中转子网。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTransitSubnetResponse> DeleteTransitSubnetAsync(DeleteTransitSubnetRequest deleteTransitSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTransitSubnetRequest.TransitSubnetId, out var valueOfTransitSubnetId)) urlParam.Add("transit_subnet_id", valueOfTransitSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-subnets/{transit_subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTransitSubnetRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTransitSubnetResponse>(response);
        }

        public AsyncInvoker<DeleteTransitSubnetResponse> DeleteTransitSubnetAsyncInvoker(DeleteTransitSubnetRequest deleteTransitSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTransitSubnetRequest.TransitSubnetId, out var valueOfTransitSubnetId)) urlParam.Add("transit_subnet_id", valueOfTransitSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-subnets/{transit_subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTransitSubnetRequest);
            return new AsyncInvoker<DeleteTransitSubnetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTransitSubnetResponse>);
        }
        
        /// <summary>
        /// 删除中转子网标签
        ///
        /// - 幂等接口：
        /// - 删除时，不对标签字符集做校验，调用接口前必须要做encodeURI，服务端需要对接口uri做decodeURI。删除的key不存在报404，key不能为空或者空字符串。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTransitSubnetTagResponse> DeleteTransitSubnetTagAsync(DeleteTransitSubnetTagRequest deleteTransitSubnetTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTransitSubnetTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            if (StringUtils.TryConvertToNonEmptyString(deleteTransitSubnetTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-subnets/{resource_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTransitSubnetTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTransitSubnetTagResponse>(response);
        }

        public AsyncInvoker<DeleteTransitSubnetTagResponse> DeleteTransitSubnetTagAsyncInvoker(DeleteTransitSubnetTagRequest deleteTransitSubnetTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTransitSubnetTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            if (StringUtils.TryConvertToNonEmptyString(deleteTransitSubnetTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-subnets/{resource_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTransitSubnetTagRequest);
            return new AsyncInvoker<DeleteTransitSubnetTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTransitSubnetTagResponse>);
        }
        
        /// <summary>
        /// 查询中转子网列表
        ///
        /// 查询中转子网列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTransitSubnetResponse> ListTransitSubnetAsync(ListTransitSubnetRequest listTransitSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitSubnetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTransitSubnetResponse>(response);
        }

        public AsyncInvoker<ListTransitSubnetResponse> ListTransitSubnetAsyncInvoker(ListTransitSubnetRequest listTransitSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitSubnetRequest);
            return new AsyncInvoker<ListTransitSubnetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTransitSubnetResponse>);
        }
        
        /// <summary>
        /// 查询中转子网项目标签
        ///
        /// - 查询租户在指定Project的所有中转子网标签集合。
        /// - 标签管理服务需要能够列出当前租户全部已使用的中转子网标签集合，为打中转子网标签和过滤中转子网实例时提供标签联想功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTransitSubnetTagsResponse> ListTransitSubnetTagsAsync(ListTransitSubnetTagsRequest listTransitSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-subnets/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitSubnetTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTransitSubnetTagsResponse>(response);
        }

        public AsyncInvoker<ListTransitSubnetTagsResponse> ListTransitSubnetTagsAsyncInvoker(ListTransitSubnetTagsRequest listTransitSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-subnets/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitSubnetTagsRequest);
            return new AsyncInvoker<ListTransitSubnetTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTransitSubnetTagsResponse>);
        }
        
        /// <summary>
        /// 查询中转子网实例
        ///
        /// - 使用标签过滤中转子网实例。
        /// - 标签管理服务需要提供按标签过滤中转子网服务实例并汇总显示在列表中，需要中转子网服务提供查询能力。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTransitSubnetsByTagsResponse> ListTransitSubnetsByTagsAsync(ListTransitSubnetsByTagsRequest listTransitSubnetsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-subnets/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitSubnetsByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListTransitSubnetsByTagsResponse>(response);
        }

        public AsyncInvoker<ListTransitSubnetsByTagsResponse> ListTransitSubnetsByTagsAsyncInvoker(ListTransitSubnetsByTagsRequest listTransitSubnetsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-subnets/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitSubnetsByTagsRequest);
            return new AsyncInvoker<ListTransitSubnetsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTransitSubnetsByTagsResponse>);
        }
        
        /// <summary>
        /// 查询指定的中转子网详情
        ///
        /// 查询指定的中转子网详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTransitSubnetResponse> ShowTransitSubnetAsync(ShowTransitSubnetRequest showTransitSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTransitSubnetRequest.TransitSubnetId, out var valueOfTransitSubnetId)) urlParam.Add("transit_subnet_id", valueOfTransitSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-subnets/{transit_subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransitSubnetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTransitSubnetResponse>(response);
        }

        public AsyncInvoker<ShowTransitSubnetResponse> ShowTransitSubnetAsyncInvoker(ShowTransitSubnetRequest showTransitSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTransitSubnetRequest.TransitSubnetId, out var valueOfTransitSubnetId)) urlParam.Add("transit_subnet_id", valueOfTransitSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-subnets/{transit_subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransitSubnetRequest);
            return new AsyncInvoker<ShowTransitSubnetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTransitSubnetResponse>);
        }
        
        /// <summary>
        /// 查询中转子网标签
        ///
        /// - 查询指定中转子网实例的标签信息。
        /// - 标签管理服务需要使用该接口查询指定中转子网实例的全部标签数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTransitSubnetTagsResponse> ShowTransitSubnetTagsAsync(ShowTransitSubnetTagsRequest showTransitSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTransitSubnetTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-subnets/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransitSubnetTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTransitSubnetTagsResponse>(response);
        }

        public AsyncInvoker<ShowTransitSubnetTagsResponse> ShowTransitSubnetTagsAsyncInvoker(ShowTransitSubnetTagsRequest showTransitSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTransitSubnetTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-subnets/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransitSubnetTagsRequest);
            return new AsyncInvoker<ShowTransitSubnetTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTransitSubnetTagsResponse>);
        }
        
        /// <summary>
        /// 更新中转子网
        ///
        /// 更新指定的中转子网。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTransitSubnetResponse> UpdateTransitSubnetAsync(UpdateTransitSubnetRequest updateTransitSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTransitSubnetRequest.TransitSubnetId, out var valueOfTransitSubnetId)) urlParam.Add("transit_subnet_id", valueOfTransitSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-subnets/{transit_subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTransitSubnetRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTransitSubnetResponse>(response);
        }

        public AsyncInvoker<UpdateTransitSubnetResponse> UpdateTransitSubnetAsyncInvoker(UpdateTransitSubnetRequest updateTransitSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTransitSubnetRequest.TransitSubnetId, out var valueOfTransitSubnetId)) urlParam.Add("transit_subnet_id", valueOfTransitSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-subnets/{transit_subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTransitSubnetRequest);
            return new AsyncInvoker<UpdateTransitSubnetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTransitSubnetResponse>);
        }
        
        /// <summary>
        /// 批量创建DNAT规则
        ///
        /// 批量创建DNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateNatGatewayDnatRulesResponse> BatchCreateNatGatewayDnatRulesAsync(BatchCreateNatGatewayDnatRulesRequest batchCreateNatGatewayDnatRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules/batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateNatGatewayDnatRulesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateNatGatewayDnatRulesResponse>(response);
        }

        public AsyncInvoker<BatchCreateNatGatewayDnatRulesResponse> BatchCreateNatGatewayDnatRulesAsyncInvoker(BatchCreateNatGatewayDnatRulesRequest batchCreateNatGatewayDnatRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules/batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateNatGatewayDnatRulesRequest);
            return new AsyncInvoker<BatchCreateNatGatewayDnatRulesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateNatGatewayDnatRulesResponse>);
        }
        
        /// <summary>
        /// 创建DNAT规则
        ///
        /// 创建DNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateNatGatewayDnatRuleResponse> CreateNatGatewayDnatRuleAsync(CreateNatGatewayDnatRuleRequest createNatGatewayDnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNatGatewayDnatRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateNatGatewayDnatRuleResponse>(response);
        }

        public AsyncInvoker<CreateNatGatewayDnatRuleResponse> CreateNatGatewayDnatRuleAsyncInvoker(CreateNatGatewayDnatRuleRequest createNatGatewayDnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNatGatewayDnatRuleRequest);
            return new AsyncInvoker<CreateNatGatewayDnatRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNatGatewayDnatRuleResponse>);
        }
        
        /// <summary>
        /// 创建DNAT规则
        ///
        /// 创建DNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePrivateDnatResponse> CreatePrivateDnatAsync(CreatePrivateDnatRequest createPrivateDnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateDnatRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePrivateDnatResponse>(response);
        }

        public AsyncInvoker<CreatePrivateDnatResponse> CreatePrivateDnatAsyncInvoker(CreatePrivateDnatRequest createPrivateDnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateDnatRequest);
            return new AsyncInvoker<CreatePrivateDnatResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePrivateDnatResponse>);
        }
        
        /// <summary>
        /// 删除DNAT规则
        ///
        /// 删除指定的DNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteNatGatewayDnatRuleResponse> DeleteNatGatewayDnatRuleAsync(DeleteNatGatewayDnatRuleRequest deleteNatGatewayDnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNatGatewayDnatRuleRequest.NatGatewayId, out var valueOfNatGatewayId)) urlParam.Add("nat_gateway_id", valueOfNatGatewayId);
            if (StringUtils.TryConvertToNonEmptyString(deleteNatGatewayDnatRuleRequest.DnatRuleId, out var valueOfDnatRuleId)) urlParam.Add("dnat_rule_id", valueOfDnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}/dnat_rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNatGatewayDnatRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNatGatewayDnatRuleResponse>(response);
        }

        public AsyncInvoker<DeleteNatGatewayDnatRuleResponse> DeleteNatGatewayDnatRuleAsyncInvoker(DeleteNatGatewayDnatRuleRequest deleteNatGatewayDnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNatGatewayDnatRuleRequest.NatGatewayId, out var valueOfNatGatewayId)) urlParam.Add("nat_gateway_id", valueOfNatGatewayId);
            if (StringUtils.TryConvertToNonEmptyString(deleteNatGatewayDnatRuleRequest.DnatRuleId, out var valueOfDnatRuleId)) urlParam.Add("dnat_rule_id", valueOfDnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}/dnat_rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNatGatewayDnatRuleRequest);
            return new AsyncInvoker<DeleteNatGatewayDnatRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteNatGatewayDnatRuleResponse>);
        }
        
        /// <summary>
        /// 删除DNAT规则
        ///
        /// 删除指定的DNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePrivateDnatResponse> DeletePrivateDnatAsync(DeletePrivateDnatRequest deletePrivateDnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePrivateDnatRequest.DnatRuleId, out var valueOfDnatRuleId)) urlParam.Add("dnat_rule_id", valueOfDnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateDnatRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePrivateDnatResponse>(response);
        }

        public AsyncInvoker<DeletePrivateDnatResponse> DeletePrivateDnatAsyncInvoker(DeletePrivateDnatRequest deletePrivateDnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePrivateDnatRequest.DnatRuleId, out var valueOfDnatRuleId)) urlParam.Add("dnat_rule_id", valueOfDnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateDnatRequest);
            return new AsyncInvoker<DeletePrivateDnatResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePrivateDnatResponse>);
        }
        
        /// <summary>
        /// 查询DNAT规则列表
        ///
        /// 查询DNAT规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNatGatewayDnatRulesResponse> ListNatGatewayDnatRulesAsync(ListNatGatewayDnatRulesRequest listNatGatewayDnatRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewayDnatRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNatGatewayDnatRulesResponse>(response);
        }

        public AsyncInvoker<ListNatGatewayDnatRulesResponse> ListNatGatewayDnatRulesAsyncInvoker(ListNatGatewayDnatRulesRequest listNatGatewayDnatRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewayDnatRulesRequest);
            return new AsyncInvoker<ListNatGatewayDnatRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNatGatewayDnatRulesResponse>);
        }
        
        /// <summary>
        /// 查询DNAT规则列表
        ///
        /// 查询DNAT规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPrivateDnatsResponse> ListPrivateDnatsAsync(ListPrivateDnatsRequest listPrivateDnatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateDnatsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPrivateDnatsResponse>(response);
        }

        public AsyncInvoker<ListPrivateDnatsResponse> ListPrivateDnatsAsyncInvoker(ListPrivateDnatsRequest listPrivateDnatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateDnatsRequest);
            return new AsyncInvoker<ListPrivateDnatsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPrivateDnatsResponse>);
        }
        
        /// <summary>
        /// 查询指定的DNAT规则详情
        ///
        /// 查询指定的DNAT规则详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNatGatewayDnatRuleResponse> ShowNatGatewayDnatRuleAsync(ShowNatGatewayDnatRuleRequest showNatGatewayDnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNatGatewayDnatRuleRequest.DnatRuleId, out var valueOfDnatRuleId)) urlParam.Add("dnat_rule_id", valueOfDnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNatGatewayDnatRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNatGatewayDnatRuleResponse>(response);
        }

        public AsyncInvoker<ShowNatGatewayDnatRuleResponse> ShowNatGatewayDnatRuleAsyncInvoker(ShowNatGatewayDnatRuleRequest showNatGatewayDnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNatGatewayDnatRuleRequest.DnatRuleId, out var valueOfDnatRuleId)) urlParam.Add("dnat_rule_id", valueOfDnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNatGatewayDnatRuleRequest);
            return new AsyncInvoker<ShowNatGatewayDnatRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNatGatewayDnatRuleResponse>);
        }
        
        /// <summary>
        /// 查询指定的DNAT规则详情
        ///
        /// 查询指定的DNAT规则详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPrivateDnatResponse> ShowPrivateDnatAsync(ShowPrivateDnatRequest showPrivateDnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPrivateDnatRequest.DnatRuleId, out var valueOfDnatRuleId)) urlParam.Add("dnat_rule_id", valueOfDnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateDnatRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPrivateDnatResponse>(response);
        }

        public AsyncInvoker<ShowPrivateDnatResponse> ShowPrivateDnatAsyncInvoker(ShowPrivateDnatRequest showPrivateDnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPrivateDnatRequest.DnatRuleId, out var valueOfDnatRuleId)) urlParam.Add("dnat_rule_id", valueOfDnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateDnatRequest);
            return new AsyncInvoker<ShowPrivateDnatResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPrivateDnatResponse>);
        }
        
        /// <summary>
        /// 更新DNAT规则
        ///
        /// 更新指定的DNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateNatGatewayDnatRuleResponse> UpdateNatGatewayDnatRuleAsync(UpdateNatGatewayDnatRuleRequest updateNatGatewayDnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNatGatewayDnatRuleRequest.DnatRuleId, out var valueOfDnatRuleId)) urlParam.Add("dnat_rule_id", valueOfDnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNatGatewayDnatRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNatGatewayDnatRuleResponse>(response);
        }

        public AsyncInvoker<UpdateNatGatewayDnatRuleResponse> UpdateNatGatewayDnatRuleAsyncInvoker(UpdateNatGatewayDnatRuleRequest updateNatGatewayDnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNatGatewayDnatRuleRequest.DnatRuleId, out var valueOfDnatRuleId)) urlParam.Add("dnat_rule_id", valueOfDnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dnat_rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNatGatewayDnatRuleRequest);
            return new AsyncInvoker<UpdateNatGatewayDnatRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNatGatewayDnatRuleResponse>);
        }
        
        /// <summary>
        /// 更新DNAT规则
        ///
        /// 更新指定的DNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePrivateDnatResponse> UpdatePrivateDnatAsync(UpdatePrivateDnatRequest updatePrivateDnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePrivateDnatRequest.DnatRuleId, out var valueOfDnatRuleId)) urlParam.Add("dnat_rule_id", valueOfDnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateDnatRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePrivateDnatResponse>(response);
        }

        public AsyncInvoker<UpdatePrivateDnatResponse> UpdatePrivateDnatAsyncInvoker(UpdatePrivateDnatRequest updatePrivateDnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePrivateDnatRequest.DnatRuleId, out var valueOfDnatRuleId)) urlParam.Add("dnat_rule_id", valueOfDnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/dnat-rules/{dnat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateDnatRequest);
            return new AsyncInvoker<UpdatePrivateDnatResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePrivateDnatResponse>);
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
        public async Task<BatchCreateDeleteTransitIpTagsResponse> BatchCreateDeleteTransitIpTagsAsync(BatchCreateDeleteTransitIpTagsRequest batchCreateDeleteTransitIpTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateDeleteTransitIpTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDeleteTransitIpTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateDeleteTransitIpTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateDeleteTransitIpTagsResponse> BatchCreateDeleteTransitIpTagsAsyncInvoker(BatchCreateDeleteTransitIpTagsRequest batchCreateDeleteTransitIpTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateDeleteTransitIpTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDeleteTransitIpTagsRequest);
            return new AsyncInvoker<BatchCreateDeleteTransitIpTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateDeleteTransitIpTagsResponse>);
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
        public async Task<CreateTransitIpTagResponse> CreateTransitIpTagAsync(CreateTransitIpTagRequest createTransitIpTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTransitIpTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTransitIpTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTransitIpTagResponse>(response);
        }

        public AsyncInvoker<CreateTransitIpTagResponse> CreateTransitIpTagAsyncInvoker(CreateTransitIpTagRequest createTransitIpTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTransitIpTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTransitIpTagRequest);
            return new AsyncInvoker<CreateTransitIpTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTransitIpTagResponse>);
        }
        
        /// <summary>
        /// 删除中转IP标签
        ///
        /// - 幂等接口：
        /// - 删除时，不对标签字符集做校验，调用接口前必须要做encodeURI，服务端需要对接口uri做decodeURI。删除的key不存在报404，key不能为空或者空字符串。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTransitIpTagResponse> DeleteTransitIpTagAsync(DeleteTransitIpTagRequest deleteTransitIpTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTransitIpTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            if (StringUtils.TryConvertToNonEmptyString(deleteTransitIpTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/{resource_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTransitIpTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTransitIpTagResponse>(response);
        }

        public AsyncInvoker<DeleteTransitIpTagResponse> DeleteTransitIpTagAsyncInvoker(DeleteTransitIpTagRequest deleteTransitIpTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTransitIpTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            if (StringUtils.TryConvertToNonEmptyString(deleteTransitIpTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/{resource_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTransitIpTagRequest);
            return new AsyncInvoker<DeleteTransitIpTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTransitIpTagResponse>);
        }
        
        /// <summary>
        /// 查询中转IP项目标签
        ///
        /// - 查询租户在指定Project和实例类型的所有中转IP标签集合。
        /// - 标签管理服务需要能够列出当前租户全部已使用的中转IP标签集合，为打中转IP标签和过滤中转IP实例时提供标签联想功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTransitIpTagsResponse> ListTransitIpTagsAsync(ListTransitIpTagsRequest listTransitIpTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitIpTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTransitIpTagsResponse>(response);
        }

        public AsyncInvoker<ListTransitIpTagsResponse> ListTransitIpTagsAsyncInvoker(ListTransitIpTagsRequest listTransitIpTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitIpTagsRequest);
            return new AsyncInvoker<ListTransitIpTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTransitIpTagsResponse>);
        }
        
        /// <summary>
        /// 查询中转IP实例
        ///
        /// - 使用标签过滤中转IP实例。
        /// - 标签管理服务需要提供按标签过滤中转IP服务实例并汇总显示在列表中，需要中转IP服务提供查询能力。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTransitIpsByTagsResponse> ListTransitIpsByTagsAsync(ListTransitIpsByTagsRequest listTransitIpsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitIpsByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListTransitIpsByTagsResponse>(response);
        }

        public AsyncInvoker<ListTransitIpsByTagsResponse> ListTransitIpsByTagsAsyncInvoker(ListTransitIpsByTagsRequest listTransitIpsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitIpsByTagsRequest);
            return new AsyncInvoker<ListTransitIpsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTransitIpsByTagsResponse>);
        }
        
        /// <summary>
        /// 查询中转IP标签
        ///
        /// - 查询指定中转IP实例的标签信息。
        /// - 标签管理服务需要使用该接口查询指定中转IP实例的全部标签数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTransitIpTagsResponse> ShowTransitIpTagsAsync(ShowTransitIpTagsRequest showTransitIpTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTransitIpTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransitIpTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTransitIpTagsResponse>(response);
        }

        public AsyncInvoker<ShowTransitIpTagsResponse> ShowTransitIpTagsAsyncInvoker(ShowTransitIpTagsRequest showTransitIpTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTransitIpTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/transit-ips/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransitIpTagsRequest);
            return new AsyncInvoker<ShowTransitIpTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTransitIpTagsResponse>);
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
        public async Task<BatchCreateDeleteNatGatewayTagResponse> BatchCreateDeleteNatGatewayTagAsync(BatchCreateDeleteNatGatewayTagRequest batchCreateDeleteNatGatewayTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateDeleteNatGatewayTagRequest.NatGatewayId, out var valueOfNatGatewayId)) urlParam.Add("nat_gateway_id", valueOfNatGatewayId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/{nat_gateway_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDeleteNatGatewayTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateDeleteNatGatewayTagResponse>(response);
        }

        public AsyncInvoker<BatchCreateDeleteNatGatewayTagResponse> BatchCreateDeleteNatGatewayTagAsyncInvoker(BatchCreateDeleteNatGatewayTagRequest batchCreateDeleteNatGatewayTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateDeleteNatGatewayTagRequest.NatGatewayId, out var valueOfNatGatewayId)) urlParam.Add("nat_gateway_id", valueOfNatGatewayId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/{nat_gateway_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDeleteNatGatewayTagRequest);
            return new AsyncInvoker<BatchCreateDeleteNatGatewayTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateDeleteNatGatewayTagResponse>);
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
        public async Task<BatchCreateDeletePrivateNatTagsResponse> BatchCreateDeletePrivateNatTagsAsync(BatchCreateDeletePrivateNatTagsRequest batchCreateDeletePrivateNatTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateDeletePrivateNatTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDeletePrivateNatTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateDeletePrivateNatTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateDeletePrivateNatTagsResponse> BatchCreateDeletePrivateNatTagsAsyncInvoker(BatchCreateDeletePrivateNatTagsRequest batchCreateDeletePrivateNatTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateDeletePrivateNatTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDeletePrivateNatTagsRequest);
            return new AsyncInvoker<BatchCreateDeletePrivateNatTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateDeletePrivateNatTagsResponse>);
        }
        
        /// <summary>
        /// 创建公网NAT网关
        ///
        /// 创建公网NAT网关实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateNatGatewayResponse> CreateNatGatewayAsync(CreateNatGatewayRequest createNatGatewayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNatGatewayRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateNatGatewayResponse>(response);
        }

        public AsyncInvoker<CreateNatGatewayResponse> CreateNatGatewayAsyncInvoker(CreateNatGatewayRequest createNatGatewayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNatGatewayRequest);
            return new AsyncInvoker<CreateNatGatewayResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNatGatewayResponse>);
        }
        
        /// <summary>
        /// 添加公网NAT网关资源标签
        ///
        /// - 添加公网NAT网关资源标签。一个资源上最多有10个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateNatGatewayTagResponse> CreateNatGatewayTagAsync(CreateNatGatewayTagRequest createNatGatewayTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createNatGatewayTagRequest.NatGatewayId, out var valueOfNatGatewayId)) urlParam.Add("nat_gateway_id", valueOfNatGatewayId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/{nat_gateway_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNatGatewayTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateNatGatewayTagResponse>(response);
        }

        public AsyncInvoker<CreateNatGatewayTagResponse> CreateNatGatewayTagAsyncInvoker(CreateNatGatewayTagRequest createNatGatewayTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createNatGatewayTagRequest.NatGatewayId, out var valueOfNatGatewayId)) urlParam.Add("nat_gateway_id", valueOfNatGatewayId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/{nat_gateway_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNatGatewayTagRequest);
            return new AsyncInvoker<CreateNatGatewayTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateNatGatewayTagResponse>);
        }
        
        /// <summary>
        /// 创建私网NAT网关
        ///
        /// 创建私网NAT网关实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePrivateNatResponse> CreatePrivateNatAsync(CreatePrivateNatRequest createPrivateNatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateNatRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePrivateNatResponse>(response);
        }

        public AsyncInvoker<CreatePrivateNatResponse> CreatePrivateNatAsyncInvoker(CreatePrivateNatRequest createPrivateNatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateNatRequest);
            return new AsyncInvoker<CreatePrivateNatResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePrivateNatResponse>);
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
        public async Task<CreatePrivateNatTagResponse> CreatePrivateNatTagAsync(CreatePrivateNatTagRequest createPrivateNatTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPrivateNatTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateNatTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreatePrivateNatTagResponse>(response);
        }

        public AsyncInvoker<CreatePrivateNatTagResponse> CreatePrivateNatTagAsyncInvoker(CreatePrivateNatTagRequest createPrivateNatTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPrivateNatTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateNatTagRequest);
            return new AsyncInvoker<CreatePrivateNatTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreatePrivateNatTagResponse>);
        }
        
        /// <summary>
        /// 删除公网NAT网关
        ///
        /// 删除公网NAT网关实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteNatGatewayResponse> DeleteNatGatewayAsync(DeleteNatGatewayRequest deleteNatGatewayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNatGatewayRequest.NatGatewayId, out var valueOfNatGatewayId)) urlParam.Add("nat_gateway_id", valueOfNatGatewayId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNatGatewayRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNatGatewayResponse>(response);
        }

        public AsyncInvoker<DeleteNatGatewayResponse> DeleteNatGatewayAsyncInvoker(DeleteNatGatewayRequest deleteNatGatewayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNatGatewayRequest.NatGatewayId, out var valueOfNatGatewayId)) urlParam.Add("nat_gateway_id", valueOfNatGatewayId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNatGatewayRequest);
            return new AsyncInvoker<DeleteNatGatewayResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteNatGatewayResponse>);
        }
        
        /// <summary>
        /// 删除公网NAT网关资源标签
        ///
        /// - 删除指定公网NAT网关资源实例的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteNatGatewayTagResponse> DeleteNatGatewayTagAsync(DeleteNatGatewayTagRequest deleteNatGatewayTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNatGatewayTagRequest.NatGatewayId, out var valueOfNatGatewayId)) urlParam.Add("nat_gateway_id", valueOfNatGatewayId);
            if (StringUtils.TryConvertToNonEmptyString(deleteNatGatewayTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/{nat_gateway_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNatGatewayTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNatGatewayTagResponse>(response);
        }

        public AsyncInvoker<DeleteNatGatewayTagResponse> DeleteNatGatewayTagAsyncInvoker(DeleteNatGatewayTagRequest deleteNatGatewayTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNatGatewayTagRequest.NatGatewayId, out var valueOfNatGatewayId)) urlParam.Add("nat_gateway_id", valueOfNatGatewayId);
            if (StringUtils.TryConvertToNonEmptyString(deleteNatGatewayTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/{nat_gateway_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNatGatewayTagRequest);
            return new AsyncInvoker<DeleteNatGatewayTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteNatGatewayTagResponse>);
        }
        
        /// <summary>
        /// 删除私网NAT网关
        ///
        /// 删除私网NAT网关实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePrivateNatResponse> DeletePrivateNatAsync(DeletePrivateNatRequest deletePrivateNatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePrivateNatRequest.GatewayId, out var valueOfGatewayId)) urlParam.Add("gateway_id", valueOfGatewayId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways/{gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateNatRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePrivateNatResponse>(response);
        }

        public AsyncInvoker<DeletePrivateNatResponse> DeletePrivateNatAsyncInvoker(DeletePrivateNatRequest deletePrivateNatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePrivateNatRequest.GatewayId, out var valueOfGatewayId)) urlParam.Add("gateway_id", valueOfGatewayId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways/{gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateNatRequest);
            return new AsyncInvoker<DeletePrivateNatResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePrivateNatResponse>);
        }
        
        /// <summary>
        /// 删除私网NAT网关标签
        ///
        /// - 幂等接口：
        /// - 删除时，不对标签字符集做校验，调用接口前必须要做encodeURI，服务端需要对接口uri做decodeURI。删除的key不存在报404，key不能为空或者空字符串。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePrivateNatTagResponse> DeletePrivateNatTagAsync(DeletePrivateNatTagRequest deletePrivateNatTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePrivateNatTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            if (StringUtils.TryConvertToNonEmptyString(deletePrivateNatTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/{resource_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateNatTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePrivateNatTagResponse>(response);
        }

        public AsyncInvoker<DeletePrivateNatTagResponse> DeletePrivateNatTagAsyncInvoker(DeletePrivateNatTagRequest deletePrivateNatTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePrivateNatTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            if (StringUtils.TryConvertToNonEmptyString(deletePrivateNatTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/{resource_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateNatTagRequest);
            return new AsyncInvoker<DeletePrivateNatTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePrivateNatTagResponse>);
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
        public async Task<ListNatGatewayByTagResponse> ListNatGatewayByTagAsync(ListNatGatewayByTagRequest listNatGatewayByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewayByTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListNatGatewayByTagResponse>(response);
        }

        public AsyncInvoker<ListNatGatewayByTagResponse> ListNatGatewayByTagAsyncInvoker(ListNatGatewayByTagRequest listNatGatewayByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewayByTagRequest);
            return new AsyncInvoker<ListNatGatewayByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<ListNatGatewayByTagResponse>);
        }
        
        /// <summary>
        /// 支持创建的NAT网关规格列表
        ///
        /// 支持创建的NAT网关规格列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNatGatewaySpecsResponse> ListNatGatewaySpecsAsync(ListNatGatewaySpecsRequest listNatGatewaySpecsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateway_specs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewaySpecsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNatGatewaySpecsResponse>(response);
        }

        public AsyncInvoker<ListNatGatewaySpecsResponse> ListNatGatewaySpecsAsyncInvoker(ListNatGatewaySpecsRequest listNatGatewaySpecsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateway_specs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewaySpecsRequest);
            return new AsyncInvoker<ListNatGatewaySpecsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNatGatewaySpecsResponse>);
        }
        
        /// <summary>
        /// 查询公网NAT网关项目标签
        ///
        /// - 查询租户在指定项目和公网NAT网关实例类型的所有标签集合。
        /// - 标签管理服务需要能够列出当前租户全部已使用的标签集合，为各服务Console打标签和过滤实例时提供标签联想功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNatGatewayTagResponse> ListNatGatewayTagAsync(ListNatGatewayTagRequest listNatGatewayTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewayTagRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNatGatewayTagResponse>(response);
        }

        public AsyncInvoker<ListNatGatewayTagResponse> ListNatGatewayTagAsyncInvoker(ListNatGatewayTagRequest listNatGatewayTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewayTagRequest);
            return new AsyncInvoker<ListNatGatewayTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNatGatewayTagResponse>);
        }
        
        /// <summary>
        /// 查询公网NAT网关列表
        ///
        /// 查询公网NAT网关实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNatGatewaysResponse> ListNatGatewaysAsync(ListNatGatewaysRequest listNatGatewaysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewaysRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNatGatewaysResponse>(response);
        }

        public AsyncInvoker<ListNatGatewaysResponse> ListNatGatewaysAsyncInvoker(ListNatGatewaysRequest listNatGatewaysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewaysRequest);
            return new AsyncInvoker<ListNatGatewaysResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNatGatewaysResponse>);
        }
        
        /// <summary>
        /// 查询私网NAT网关项目标签
        ///
        /// - 查询租户在指定Project和实例类型的所有私网NAT网关标签集合。
        /// - 标签管理服务需要能够列出当前租户全部已使用的私网NAT网关标签集合，为打私网NAT网关标签和过滤私网NAT网关实例时提供标签联想功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPrivateNatTagsResponse> ListPrivateNatTagsAsync(ListPrivateNatTagsRequest listPrivateNatTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateNatTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPrivateNatTagsResponse>(response);
        }

        public AsyncInvoker<ListPrivateNatTagsResponse> ListPrivateNatTagsAsyncInvoker(ListPrivateNatTagsRequest listPrivateNatTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateNatTagsRequest);
            return new AsyncInvoker<ListPrivateNatTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPrivateNatTagsResponse>);
        }
        
        /// <summary>
        /// 查询私网NAT网关列表
        ///
        /// 查询私网NAT网关实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPrivateNatsResponse> ListPrivateNatsAsync(ListPrivateNatsRequest listPrivateNatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateNatsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPrivateNatsResponse>(response);
        }

        public AsyncInvoker<ListPrivateNatsResponse> ListPrivateNatsAsyncInvoker(ListPrivateNatsRequest listPrivateNatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateNatsRequest);
            return new AsyncInvoker<ListPrivateNatsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPrivateNatsResponse>);
        }
        
        /// <summary>
        /// 查询私网NAT网关实例
        ///
        /// - 使用标签过滤私网NAT网关实例。
        /// - 标签管理服务需要提供按标签过滤私网NAT网关服务实例并汇总显示在列表中，需要私网NAT网关服务提供查询能力。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPrivateNatsByTagsResponse> ListPrivateNatsByTagsAsync(ListPrivateNatsByTagsRequest listPrivateNatsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateNatsByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListPrivateNatsByTagsResponse>(response);
        }

        public AsyncInvoker<ListPrivateNatsByTagsResponse> ListPrivateNatsByTagsAsyncInvoker(ListPrivateNatsByTagsRequest listPrivateNatsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateNatsByTagsRequest);
            return new AsyncInvoker<ListPrivateNatsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListPrivateNatsByTagsResponse>);
        }
        
        /// <summary>
        /// 查询项目支持的网关规格列表
        ///
        /// 查询项目支持的网关规格列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSpecsResponse> ListSpecsAsync(ListSpecsRequest listSpecsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/specs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSpecsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSpecsResponse>(response);
        }

        public AsyncInvoker<ListSpecsResponse> ListSpecsAsyncInvoker(ListSpecsRequest listSpecsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/specs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSpecsRequest);
            return new AsyncInvoker<ListSpecsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSpecsResponse>);
        }
        
        /// <summary>
        /// 查询指定的公网NAT网关详情
        ///
        /// 查询指定的公网NAT网关实例详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNatGatewayResponse> ShowNatGatewayAsync(ShowNatGatewayRequest showNatGatewayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNatGatewayRequest.NatGatewayId, out var valueOfNatGatewayId)) urlParam.Add("nat_gateway_id", valueOfNatGatewayId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNatGatewayRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNatGatewayResponse>(response);
        }

        public AsyncInvoker<ShowNatGatewayResponse> ShowNatGatewayAsyncInvoker(ShowNatGatewayRequest showNatGatewayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNatGatewayRequest.NatGatewayId, out var valueOfNatGatewayId)) urlParam.Add("nat_gateway_id", valueOfNatGatewayId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNatGatewayRequest);
            return new AsyncInvoker<ShowNatGatewayResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNatGatewayResponse>);
        }
        
        /// <summary>
        /// 查询公网NAT网关资源标签
        ///
        /// - 查询指定公网NAT网关实例的标签信息。
        /// - 标签管理服务需要使用该接口查询指定公网NAT网关实例的全部标签数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNatGatewayTagResponse> ShowNatGatewayTagAsync(ShowNatGatewayTagRequest showNatGatewayTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNatGatewayTagRequest.NatGatewayId, out var valueOfNatGatewayId)) urlParam.Add("nat_gateway_id", valueOfNatGatewayId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/{nat_gateway_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNatGatewayTagRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNatGatewayTagResponse>(response);
        }

        public AsyncInvoker<ShowNatGatewayTagResponse> ShowNatGatewayTagAsyncInvoker(ShowNatGatewayTagRequest showNatGatewayTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNatGatewayTagRequest.NatGatewayId, out var valueOfNatGatewayId)) urlParam.Add("nat_gateway_id", valueOfNatGatewayId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/nat_gateways/{nat_gateway_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNatGatewayTagRequest);
            return new AsyncInvoker<ShowNatGatewayTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNatGatewayTagResponse>);
        }
        
        /// <summary>
        /// 查询指定的私网NAT网关详情
        ///
        /// 查询指定的私网NAT网关实例详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPrivateNatResponse> ShowPrivateNatAsync(ShowPrivateNatRequest showPrivateNatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPrivateNatRequest.GatewayId, out var valueOfGatewayId)) urlParam.Add("gateway_id", valueOfGatewayId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways/{gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateNatRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPrivateNatResponse>(response);
        }

        public AsyncInvoker<ShowPrivateNatResponse> ShowPrivateNatAsyncInvoker(ShowPrivateNatRequest showPrivateNatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPrivateNatRequest.GatewayId, out var valueOfGatewayId)) urlParam.Add("gateway_id", valueOfGatewayId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways/{gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateNatRequest);
            return new AsyncInvoker<ShowPrivateNatResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPrivateNatResponse>);
        }
        
        /// <summary>
        /// 查询私网NAT网关标签
        ///
        /// - 查询指定私网NAT网关实例的标签信息。
        /// - 标签管理服务需要使用该接口查询指定私网NAT网关实例的全部标签数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPrivateNatTagsResponse> ShowPrivateNatTagsAsync(ShowPrivateNatTagsRequest showPrivateNatTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPrivateNatTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateNatTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPrivateNatTagsResponse>(response);
        }

        public AsyncInvoker<ShowPrivateNatTagsResponse> ShowPrivateNatTagsAsyncInvoker(ShowPrivateNatTagsRequest showPrivateNatTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPrivateNatTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat-gateways/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateNatTagsRequest);
            return new AsyncInvoker<ShowPrivateNatTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPrivateNatTagsResponse>);
        }
        
        /// <summary>
        /// 更新公网NAT网关
        ///
        /// 更新公网NAT网关实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateNatGatewayResponse> UpdateNatGatewayAsync(UpdateNatGatewayRequest updateNatGatewayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNatGatewayRequest.NatGatewayId, out var valueOfNatGatewayId)) urlParam.Add("nat_gateway_id", valueOfNatGatewayId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNatGatewayRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNatGatewayResponse>(response);
        }

        public AsyncInvoker<UpdateNatGatewayResponse> UpdateNatGatewayAsyncInvoker(UpdateNatGatewayRequest updateNatGatewayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNatGatewayRequest.NatGatewayId, out var valueOfNatGatewayId)) urlParam.Add("nat_gateway_id", valueOfNatGatewayId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNatGatewayRequest);
            return new AsyncInvoker<UpdateNatGatewayResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNatGatewayResponse>);
        }
        
        /// <summary>
        /// 更新私网NAT网关
        ///
        /// 更新私网NAT网关实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePrivateNatResponse> UpdatePrivateNatAsync(UpdatePrivateNatRequest updatePrivateNatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePrivateNatRequest.GatewayId, out var valueOfGatewayId)) urlParam.Add("gateway_id", valueOfGatewayId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways/{gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateNatRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePrivateNatResponse>(response);
        }

        public AsyncInvoker<UpdatePrivateNatResponse> UpdatePrivateNatAsyncInvoker(UpdatePrivateNatRequest updatePrivateNatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePrivateNatRequest.GatewayId, out var valueOfGatewayId)) urlParam.Add("gateway_id", valueOfGatewayId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/gateways/{gateway_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateNatRequest);
            return new AsyncInvoker<UpdatePrivateNatResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePrivateNatResponse>);
        }
        
        /// <summary>
        /// 创建中转IP
        ///
        /// 创建中转IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTransitIpResponse> CreateTransitIpAsync(CreateTransitIpRequest createTransitIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTransitIpRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTransitIpResponse>(response);
        }

        public AsyncInvoker<CreateTransitIpResponse> CreateTransitIpAsyncInvoker(CreateTransitIpRequest createTransitIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTransitIpRequest);
            return new AsyncInvoker<CreateTransitIpResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTransitIpResponse>);
        }
        
        /// <summary>
        /// 删除中转IP
        ///
        /// 删除中转IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTransitIpResponse> DeleteTransitIpAsync(DeleteTransitIpRequest deleteTransitIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTransitIpRequest.TransitIpId, out var valueOfTransitIpId)) urlParam.Add("transit_ip_id", valueOfTransitIpId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-ips/{transit_ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTransitIpRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTransitIpResponse>(response);
        }

        public AsyncInvoker<DeleteTransitIpResponse> DeleteTransitIpAsyncInvoker(DeleteTransitIpRequest deleteTransitIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTransitIpRequest.TransitIpId, out var valueOfTransitIpId)) urlParam.Add("transit_ip_id", valueOfTransitIpId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-ips/{transit_ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTransitIpRequest);
            return new AsyncInvoker<DeleteTransitIpResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTransitIpResponse>);
        }
        
        /// <summary>
        /// 查询中转IP列表
        ///
        /// 查询中转IP列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTransitIpsResponse> ListTransitIpsAsync(ListTransitIpsRequest listTransitIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitIpsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTransitIpsResponse>(response);
        }

        public AsyncInvoker<ListTransitIpsResponse> ListTransitIpsAsyncInvoker(ListTransitIpsRequest listTransitIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransitIpsRequest);
            return new AsyncInvoker<ListTransitIpsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTransitIpsResponse>);
        }
        
        /// <summary>
        /// 查询指定的中转IP详情
        ///
        /// 查询中转IP详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTransitIpResponse> ShowTransitIpAsync(ShowTransitIpRequest showTransitIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTransitIpRequest.TransitIpId, out var valueOfTransitIpId)) urlParam.Add("transit_ip_id", valueOfTransitIpId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-ips/{transit_ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransitIpRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTransitIpResponse>(response);
        }

        public AsyncInvoker<ShowTransitIpResponse> ShowTransitIpAsyncInvoker(ShowTransitIpRequest showTransitIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTransitIpRequest.TransitIpId, out var valueOfTransitIpId)) urlParam.Add("transit_ip_id", valueOfTransitIpId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/transit-ips/{transit_ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTransitIpRequest);
            return new AsyncInvoker<ShowTransitIpResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTransitIpResponse>);
        }
        
        /// <summary>
        /// 创建SNAT规则
        ///
        /// 创建SNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateNatGatewaySnatRuleResponse> CreateNatGatewaySnatRuleAsync(CreateNatGatewaySnatRuleRequest createNatGatewaySnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snat_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNatGatewaySnatRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateNatGatewaySnatRuleResponse>(response);
        }

        public AsyncInvoker<CreateNatGatewaySnatRuleResponse> CreateNatGatewaySnatRuleAsyncInvoker(CreateNatGatewaySnatRuleRequest createNatGatewaySnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snat_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNatGatewaySnatRuleRequest);
            return new AsyncInvoker<CreateNatGatewaySnatRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNatGatewaySnatRuleResponse>);
        }
        
        /// <summary>
        /// 创建SNAT规则
        ///
        /// 创建SNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePrivateSnatResponse> CreatePrivateSnatAsync(CreatePrivateSnatRequest createPrivateSnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateSnatRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePrivateSnatResponse>(response);
        }

        public AsyncInvoker<CreatePrivateSnatResponse> CreatePrivateSnatAsyncInvoker(CreatePrivateSnatRequest createPrivateSnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateSnatRequest);
            return new AsyncInvoker<CreatePrivateSnatResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePrivateSnatResponse>);
        }
        
        /// <summary>
        /// 删除SNAT规则
        ///
        /// 删除指定的SNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteNatGatewaySnatRuleResponse> DeleteNatGatewaySnatRuleAsync(DeleteNatGatewaySnatRuleRequest deleteNatGatewaySnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNatGatewaySnatRuleRequest.NatGatewayId, out var valueOfNatGatewayId)) urlParam.Add("nat_gateway_id", valueOfNatGatewayId);
            if (StringUtils.TryConvertToNonEmptyString(deleteNatGatewaySnatRuleRequest.SnatRuleId, out var valueOfSnatRuleId)) urlParam.Add("snat_rule_id", valueOfSnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}/snat_rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNatGatewaySnatRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNatGatewaySnatRuleResponse>(response);
        }

        public AsyncInvoker<DeleteNatGatewaySnatRuleResponse> DeleteNatGatewaySnatRuleAsyncInvoker(DeleteNatGatewaySnatRuleRequest deleteNatGatewaySnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNatGatewaySnatRuleRequest.NatGatewayId, out var valueOfNatGatewayId)) urlParam.Add("nat_gateway_id", valueOfNatGatewayId);
            if (StringUtils.TryConvertToNonEmptyString(deleteNatGatewaySnatRuleRequest.SnatRuleId, out var valueOfSnatRuleId)) urlParam.Add("snat_rule_id", valueOfSnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/nat_gateways/{nat_gateway_id}/snat_rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNatGatewaySnatRuleRequest);
            return new AsyncInvoker<DeleteNatGatewaySnatRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteNatGatewaySnatRuleResponse>);
        }
        
        /// <summary>
        /// 删除SNAT规则
        ///
        /// 删除指定的SNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePrivateSnatResponse> DeletePrivateSnatAsync(DeletePrivateSnatRequest deletePrivateSnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePrivateSnatRequest.SnatRuleId, out var valueOfSnatRuleId)) urlParam.Add("snat_rule_id", valueOfSnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateSnatRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePrivateSnatResponse>(response);
        }

        public AsyncInvoker<DeletePrivateSnatResponse> DeletePrivateSnatAsyncInvoker(DeletePrivateSnatRequest deletePrivateSnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePrivateSnatRequest.SnatRuleId, out var valueOfSnatRuleId)) urlParam.Add("snat_rule_id", valueOfSnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateSnatRequest);
            return new AsyncInvoker<DeletePrivateSnatResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePrivateSnatResponse>);
        }
        
        /// <summary>
        /// 查询SNAT规则列表
        ///
        /// 查询SNAT规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNatGatewaySnatRulesResponse> ListNatGatewaySnatRulesAsync(ListNatGatewaySnatRulesRequest listNatGatewaySnatRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snat_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewaySnatRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNatGatewaySnatRulesResponse>(response);
        }

        public AsyncInvoker<ListNatGatewaySnatRulesResponse> ListNatGatewaySnatRulesAsyncInvoker(ListNatGatewaySnatRulesRequest listNatGatewaySnatRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snat_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNatGatewaySnatRulesRequest);
            return new AsyncInvoker<ListNatGatewaySnatRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNatGatewaySnatRulesResponse>);
        }
        
        /// <summary>
        /// 查询SNAT规则列表
        ///
        /// 查询SNAT规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPrivateSnatsResponse> ListPrivateSnatsAsync(ListPrivateSnatsRequest listPrivateSnatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateSnatsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPrivateSnatsResponse>(response);
        }

        public AsyncInvoker<ListPrivateSnatsResponse> ListPrivateSnatsAsyncInvoker(ListPrivateSnatsRequest listPrivateSnatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateSnatsRequest);
            return new AsyncInvoker<ListPrivateSnatsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPrivateSnatsResponse>);
        }
        
        /// <summary>
        /// 查询指定的SNAT规则详情
        ///
        /// 查询指定的SNAT规则详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNatGatewaySnatRuleResponse> ShowNatGatewaySnatRuleAsync(ShowNatGatewaySnatRuleRequest showNatGatewaySnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNatGatewaySnatRuleRequest.SnatRuleId, out var valueOfSnatRuleId)) urlParam.Add("snat_rule_id", valueOfSnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snat_rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNatGatewaySnatRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNatGatewaySnatRuleResponse>(response);
        }

        public AsyncInvoker<ShowNatGatewaySnatRuleResponse> ShowNatGatewaySnatRuleAsyncInvoker(ShowNatGatewaySnatRuleRequest showNatGatewaySnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNatGatewaySnatRuleRequest.SnatRuleId, out var valueOfSnatRuleId)) urlParam.Add("snat_rule_id", valueOfSnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snat_rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNatGatewaySnatRuleRequest);
            return new AsyncInvoker<ShowNatGatewaySnatRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNatGatewaySnatRuleResponse>);
        }
        
        /// <summary>
        /// 查询指定的SNAT规则详情
        ///
        /// 查询指定的SNAT规则详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPrivateSnatResponse> ShowPrivateSnatAsync(ShowPrivateSnatRequest showPrivateSnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPrivateSnatRequest.SnatRuleId, out var valueOfSnatRuleId)) urlParam.Add("snat_rule_id", valueOfSnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateSnatRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPrivateSnatResponse>(response);
        }

        public AsyncInvoker<ShowPrivateSnatResponse> ShowPrivateSnatAsyncInvoker(ShowPrivateSnatRequest showPrivateSnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPrivateSnatRequest.SnatRuleId, out var valueOfSnatRuleId)) urlParam.Add("snat_rule_id", valueOfSnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateSnatRequest);
            return new AsyncInvoker<ShowPrivateSnatResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPrivateSnatResponse>);
        }
        
        /// <summary>
        /// 更新SNAT规则
        ///
        /// 更新指定的SNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateNatGatewaySnatRuleResponse> UpdateNatGatewaySnatRuleAsync(UpdateNatGatewaySnatRuleRequest updateNatGatewaySnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNatGatewaySnatRuleRequest.SnatRuleId, out var valueOfSnatRuleId)) urlParam.Add("snat_rule_id", valueOfSnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snat_rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNatGatewaySnatRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNatGatewaySnatRuleResponse>(response);
        }

        public AsyncInvoker<UpdateNatGatewaySnatRuleResponse> UpdateNatGatewaySnatRuleAsyncInvoker(UpdateNatGatewaySnatRuleRequest updateNatGatewaySnatRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNatGatewaySnatRuleRequest.SnatRuleId, out var valueOfSnatRuleId)) urlParam.Add("snat_rule_id", valueOfSnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/snat_rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNatGatewaySnatRuleRequest);
            return new AsyncInvoker<UpdateNatGatewaySnatRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNatGatewaySnatRuleResponse>);
        }
        
        /// <summary>
        /// 更新SNAT规则
        ///
        /// 更新指定的SNAT规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePrivateSnatResponse> UpdatePrivateSnatAsync(UpdatePrivateSnatRequest updatePrivateSnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePrivateSnatRequest.SnatRuleId, out var valueOfSnatRuleId)) urlParam.Add("snat_rule_id", valueOfSnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateSnatRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePrivateSnatResponse>(response);
        }

        public AsyncInvoker<UpdatePrivateSnatResponse> UpdatePrivateSnatAsyncInvoker(UpdatePrivateSnatRequest updatePrivateSnatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePrivateSnatRequest.SnatRuleId, out var valueOfSnatRuleId)) urlParam.Add("snat_rule_id", valueOfSnatRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/private-nat/snat-rules/{snat_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateSnatRequest);
            return new AsyncInvoker<UpdatePrivateSnatResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePrivateSnatResponse>);
        }
        
    }
}