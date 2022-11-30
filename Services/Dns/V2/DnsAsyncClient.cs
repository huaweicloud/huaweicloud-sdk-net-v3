using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Dns.V2.Model;

namespace HuaweiCloud.SDK.Dns.V2
{
    public partial class DnsAsyncClient : Client
    {
        public static ClientBuilder<DnsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<DnsAsyncClient>();
        }

        
        /// <summary>
        /// 绑定ip地址。
        ///
        /// 绑定单个IP地址到终端节点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateEndpointIpaddressResponse> AssociateEndpointIpaddressAsync(AssociateEndpointIpaddressRequest associateEndpointIpaddressRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id" , associateEndpointIpaddressRequest.EndpointId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/endpoint/{endpoint_id}/ipaddress",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateEndpointIpaddressRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AssociateEndpointIpaddressResponse>(response);
        }
        
        /// <summary>
        /// 批量删除PTR
        ///
        /// 批量删除PTR。本接口为原子操作，所有记录应全部删除成功或全部失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeletePtrRecordsResponse> BatchDeletePtrRecordsAsync(BatchDeletePtrRecordsRequest batchDeletePtrRecordsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/reverse/floatingips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePtrRecordsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<BatchDeletePtrRecordsResponse>(response);
        }
        
        /// <summary>
        /// 批量删除Record Set
        ///
        /// 批量删除Record Set。
        /// 响应结果中只包含本次实际删除的Record Set。
        /// 支持批量删除公网域名和内网域名的记录集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteRecordSetsResponse> BatchDeleteRecordSetsAsync(BatchDeleteRecordSetsRequest batchDeleteRecordSetsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRecordSetsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteRecordSetsResponse>(response);
        }
        
        /// <summary>
        /// 批量删除Zone
        ///
        /// 批量删除Zone。
        /// 本接口为原子操作，所有记录应全部删除成功或全部失败。
        /// 仅支持公网Zone、内网Zone。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteZonesResponse> BatchDeleteZonesAsync(BatchDeleteZonesRequest batchDeleteZonesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/zones",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteZonesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteZonesResponse>(response);
        }
        
        /// <summary>
        /// 批量设置Record Set状态
        ///
        /// 批量设置Record Set状态。
        /// 响应结果中只包含本次实际更新的Record Set。
        /// 仅支持公网域名记录集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchSetRecordSetsStatusResponse> BatchSetRecordSetsStatusAsync(BatchSetRecordSetsStatusRequest batchSetRecordSetsStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets/statuses",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetRecordSetsStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchSetRecordSetsStatusResponse>(response);
        }
        
        /// <summary>
        /// 批量设置Zone状态
        ///
        /// 批量设置Zone状态。
        /// 响应结果中只包含本次实际更新的Zone。
        /// 仅支持公网Zone。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchSetZonesStatusResponse> BatchSetZonesStatusAsync(BatchSetZonesStatusRequest batchSetZonesStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/zones/statuses",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetZonesStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchSetZonesStatusResponse>(response);
        }
        
        /// <summary>
        /// 创建单个自定义线路
        ///
        /// 创建单个自定义线路
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCustomLineResponse> CreateCustomLineAsync(CreateCustomLineRequest createCustomLineRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/customlines",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCustomLineRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateCustomLineResponse>(response);
        }
        
        /// <summary>
        /// 创建终端节点。
        ///
        /// 创建单个终端节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest createEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/endpoint",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEndpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateEndpointResponse>(response);
        }
        
        /// <summary>
        /// 创建线路分组。
        ///
        /// 创建一个线路分组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLineGroupResponse> CreateLineGroupAsync(CreateLineGroupRequest createLineGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLineGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateLineGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建解析规则。
        ///
        /// 创建一个解析规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateResolveRuleResponse> CreateResolveRuleAsync(CreateResolveRuleRequest createResolveRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrule",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResolveRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateResolveRuleResponse>(response);
        }
        
        /// <summary>
        /// 创建公网域名找回请求。
        ///
        /// 创建公网域名找回请求。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRetrievalResponse> CreateRetrievalAsync(CreateRetrievalRequest createRetrievalRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/retrieval",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRetrievalRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRetrievalResponse>(response);
        }
        
        /// <summary>
        /// 请求立即验证域名找回。
        ///
        /// 请求服务器立即执行找回验证。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRetrievalVerificationResponse> CreateRetrievalVerificationAsync(CreateRetrievalVerificationRequest createRetrievalVerificationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , createRetrievalVerificationRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/retrieval/verification/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRetrievalVerificationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerializeNull<CreateRetrievalVerificationResponse>(response);
        }
        
        /// <summary>
        /// 删除单个自定义线路
        ///
        /// 删除单个自定义线路
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCustomLineResponse> DeleteCustomLineAsync(DeleteCustomLineRequest deleteCustomLineRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("line_id" , deleteCustomLineRequest.LineId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/customlines/{line_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomLineRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteCustomLineResponse>(response);
        }
        
        /// <summary>
        /// 删除终端节点。
        ///
        /// 删除终端节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest deleteEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id" , deleteEndpointRequest.EndpointId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/endpoint/{endpoint_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteEndpointResponse>(response);
        }
        
        /// <summary>
        /// 删除线路分组。
        ///
        /// 删除单个线路分组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLineGroupResponse> DeleteLineGroupAsync(DeleteLineGroupRequest deleteLineGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("linegroup_id" , deleteLineGroupRequest.LinegroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLineGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteLineGroupResponse>(response);
        }
        
        /// <summary>
        /// 删除解析规则。
        ///
        /// 删除解析规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteResolveRuleResponse> DeleteResolveRuleAsync(DeleteResolveRuleRequest deleteResolveRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resolverrule_id" , deleteResolveRuleRequest.ResolverruleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrule/{resolverrule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResolveRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteResolveRuleResponse>(response);
        }
        
        /// <summary>
        /// 解关联ip地址。
        ///
        /// 解除endpoint绑定的IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateEndpointIpaddressResponse> DisassociateEndpointIpaddressAsync(DisassociateEndpointIpaddressRequest disassociateEndpointIpaddressRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id" , disassociateEndpointIpaddressRequest.EndpointId.ToString());
            urlParam.Add("ipaddress_id" , disassociateEndpointIpaddressRequest.IpaddressId.ToString());
            string urlPath = HttpUtils.AddUrlPath("v2.1/endpoint/{endpoint_id}/ipaddress/{ipaddress_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateEndpointIpaddressRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DisassociateEndpointIpaddressResponse>(response);
        }
        
        /// <summary>
        /// 查询所有的云解析服务API版本号
        ///
        /// 查询所有的云解析服务API版本号列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApiVersionsResponse> ListApiVersionsAsync(ListApiVersionsRequest listApiVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }
        
        /// <summary>
        /// 查询自定义线路
        ///
        /// 查询自定义线路
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCustomLineResponse> ListCustomLineAsync(ListCustomLineRequest listCustomLineRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/customlines",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomLineRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListCustomLineResponse>(response);
        }
        
        /// <summary>
        /// 查询ip地址列表。
        ///
        /// 查询某个endpoint下的ip地址列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEndpointIpaddressesResponse> ListEndpointIpaddressesAsync(ListEndpointIpaddressesRequest listEndpointIpaddressesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id" , listEndpointIpaddressesRequest.EndpointId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/endpoint/{endpoint_id}/ipaddress",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointIpaddressesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEndpointIpaddressesResponse>(response);
        }
        
        /// <summary>
        /// 查询vpc信息。
        ///
        /// 查询vpc的终端节点信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEndpointVpcsResponse> ListEndpointVpcsAsync(ListEndpointVpcsRequest listEndpointVpcsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/vpc",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointVpcsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEndpointVpcsResponse>(response);
        }
        
        /// <summary>
        /// 查询终端节点列表。
        ///
        /// 查询终端节点列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEndpointsResponse> ListEndpointsAsync(ListEndpointsRequest listEndpointsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/endpoint",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEndpointsResponse>(response);
        }
        
        /// <summary>
        /// 查询线路分组列表。
        ///
        /// 查询线路分组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLineGroupsResponse> ListLineGroupsAsync(ListLineGroupsRequest listLineGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLineGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListLineGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查询名称服务器列表
        ///
        /// 查询名称服务器列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNameServersResponse> ListNameServersAsync(ListNameServersRequest listNameServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/nameservers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNameServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListNameServersResponse>(response);
        }
        
        /// <summary>
        /// 查询解析规则列表。
        ///
        /// 查询解析规则的列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResoleRulesResponse> ListResoleRulesAsync(ListResoleRulesRequest listResoleRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrule",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResoleRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListResoleRulesResponse>(response);
        }
        
        /// <summary>
        /// 查询指定的云解析服务API版本号
        ///
        /// 查询指定的云解析服务API版本号
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowApiInfoResponse> ShowApiInfoAsync(ShowApiInfoRequest showApiInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version" , showApiInfoRequest.Version.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowApiInfoResponse>(response);
        }
        
        /// <summary>
        /// 查询租户配额
        ///
        /// 查询单租户在DNS服务下的资源配额，包括公网zone配额、内网zone配额、Record Set配额、PTR Record配额、入站终端节点配额、出站终端节点配额、自定义线路配额、线路分组配额等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainQuotaResponse> ShowDomainQuotaAsync(ShowDomainQuotaRequest showDomainQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/quotamg/dns/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainQuotaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainQuotaResponse>(response);
        }
        
        /// <summary>
        /// 查询endpoint。
        ///
        /// 查询终端单个节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEndpointResponse> ShowEndpointAsync(ShowEndpointRequest showEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id" , showEndpointRequest.EndpointId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/endpoint/{endpoint_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEndpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowEndpointResponse>(response);
        }
        
        /// <summary>
        /// 查询线路分组。
        ///
        /// 查询线路分组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLineGroupResponse> ShowLineGroupAsync(ShowLineGroupRequest showLineGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("linegroup_id" , showLineGroupRequest.LinegroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLineGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowLineGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询单个解析规则。
        ///
        /// 查询单个解析规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResoleRuleResponse> ShowResoleRuleAsync(ShowResoleRuleRequest showResoleRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resolverrule_id" , showResoleRuleRequest.ResolverruleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrule/{resolverrule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResoleRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowResoleRuleResponse>(response);
        }
        
        /// <summary>
        /// 查询域名找回。
        ///
        /// 查询域名找回请求。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRetrievalResponse> ShowRetrievalAsync(ShowRetrievalRequest showRetrievalRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/retrieval",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRetrievalRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRetrievalResponse>(response);
        }
        
        /// <summary>
        /// 查询域名找回结果。
        ///
        /// 查询域名找回结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRetrievalVerificationResponse> ShowRetrievalVerificationAsync(ShowRetrievalVerificationRequest showRetrievalVerificationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , showRetrievalVerificationRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/retrieval/verification/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRetrievalVerificationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRetrievalVerificationResponse>(response);
        }
        
        /// <summary>
        /// 更新单个自定义线路
        ///
        /// 更新单个自定义线路
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateCustomLineResponse> UpdateCustomLineAsync(UpdateCustomLineRequest updateCustomLineRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("line_id" , updateCustomLineRequest.LineId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/customlines/{line_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCustomLineRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateCustomLineResponse>(response);
        }
        
        /// <summary>
        /// 修改终端节点
        ///
        /// 修改终端节点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEndpointResponse> UpdateEndpointAsync(UpdateEndpointRequest updateEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id" , updateEndpointRequest.EndpointId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/endpoint/{endpoint_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEndpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateEndpointResponse>(response);
        }
        
        /// <summary>
        /// 更新线路分组。
        ///
        /// 更新单个线路分组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLineGroupsResponse> UpdateLineGroupsAsync(UpdateLineGroupsRequest updateLineGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("linegroup_id" , updateLineGroupsRequest.LinegroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLineGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateLineGroupsResponse>(response);
        }
        
        /// <summary>
        /// 修改解析规则。
        ///
        /// 修改一个解析规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateResolveRuleResponse> UpdateResolveRuleAsync(UpdateResolveRuleRequest updateResolveRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resolverrule_id" , updateResolveRuleRequest.ResolverruleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrule/{resolverrule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResolveRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateResolveRuleResponse>(response);
        }
        
        /// <summary>
        /// 设置弹性IP的PTR记录
        ///
        /// 设置弹性IP的PTR记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateEipRecordSetResponse> CreateEipRecordSetAsync(CreateEipRecordSetRequest createEipRecordSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("region" , createEipRecordSetRequest.Region.ToString());
            urlParam.Add("floatingip_id" , createEipRecordSetRequest.FloatingipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEipRecordSetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<CreateEipRecordSetResponse>(response);
        }
        
        /// <summary>
        /// 查询租户弹性IP的PTR记录列表
        ///
        /// 查询租户弹性IP的PTR记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPtrRecordsResponse> ListPtrRecordsAsync(ListPtrRecordsRequest listPtrRecordsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPtrRecordsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPtrRecordsResponse>(response);
        }
        
        /// <summary>
        /// 将弹性IP的PTR记录恢复为默认值
        ///
        /// 将弹性IP的PTR记录恢复为默认值
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestorePtrRecordResponse> RestorePtrRecordAsync(RestorePtrRecordRequest restorePtrRecordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("region" , restorePtrRecordRequest.Region.ToString());
            urlParam.Add("floatingip_id" , restorePtrRecordRequest.FloatingipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", restorePtrRecordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerializeNull<RestorePtrRecordResponse>(response);
        }
        
        /// <summary>
        /// 查询单个弹性IP的PTR记录
        ///
        /// 查询单个弹性IP的PTR记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPtrRecordSetResponse> ShowPtrRecordSetAsync(ShowPtrRecordSetRequest showPtrRecordSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("region" , showPtrRecordSetRequest.Region.ToString());
            urlParam.Add("floatingip_id" , showPtrRecordSetRequest.FloatingipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPtrRecordSetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPtrRecordSetResponse>(response);
        }
        
        /// <summary>
        /// 修改弹性IP的PTR记录
        ///
        /// 修改弹性IP的PTR记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePtrRecordResponse> UpdatePtrRecordAsync(UpdatePtrRecordRequest updatePtrRecordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("region" , updatePtrRecordRequest.Region.ToString());
            urlParam.Add("floatingip_id" , updatePtrRecordRequest.FloatingipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePtrRecordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<UpdatePtrRecordResponse>(response);
        }
        
        /// <summary>
        /// Record Set关联健康检查。
        ///
        /// Record Set关联健康检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateHealthCheckResponse> AssociateHealthCheckAsync(AssociateHealthCheckRequest associateHealthCheckRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("recordset_id" , associateHealthCheckRequest.RecordsetId.ToString());
            string urlPath = HttpUtils.AddUrlPath(" /v2.1/recordsets/{recordset_id}/associatehealthcheck",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateHealthCheckRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AssociateHealthCheckResponse>(response);
        }
        
        /// <summary>
        /// 批量删除某个Zone下的Record Set资源。
        ///
        /// 批量删除某个Zone下的Record Set资源，当删除的资源不存在时，则默认删除成功。
        /// 响应结果中只包含本次实际删除的资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteRecordSetWithLineResponse> BatchDeleteRecordSetWithLineAsync(BatchDeleteRecordSetWithLineRequest batchDeleteRecordSetWithLineRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , batchDeleteRecordSetWithLineRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRecordSetWithLineRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteRecordSetWithLineResponse>(response);
        }
        
        /// <summary>
        /// 批量修改RecordSet。
        ///
        /// 批量修改RecordSet。属于原子性操作，请求Record Set将全部完成修改，或不做任何修改。
        /// 仅公网Zone支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateRecordSetWithLineResponse> BatchUpdateRecordSetWithLineAsync(BatchUpdateRecordSetWithLineRequest batchUpdateRecordSetWithLineRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , batchUpdateRecordSetWithLineRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateRecordSetWithLineRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchUpdateRecordSetWithLineResponse>(response);
        }
        
        /// <summary>
        /// 创建单个Record Set
        ///
        /// 创建单个Record Set
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRecordSetResponse> CreateRecordSetAsync(CreateRecordSetRequest createRecordSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , createRecordSetRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRecordSetResponse>(response);
        }
        
        /// <summary>
        /// 批量线路创建RecordSet。仅公网Zone支持。
        ///
        /// 批量线路创建RecordSet。属于原子性操作，如果存在一个参数校验不通过，则创建失败。仅公网Zone支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRecordSetWithBatchLinesResponse> CreateRecordSetWithBatchLinesAsync(CreateRecordSetWithBatchLinesRequest createRecordSetWithBatchLinesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , createRecordSetWithBatchLinesRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/batch/lines",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetWithBatchLinesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRecordSetWithBatchLinesResponse>(response);
        }
        
        /// <summary>
        /// 创建单个Record Set，仅适用于公网DNS
        ///
        /// 创建单个Record Set，仅适用于公网DNS
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRecordSetWithLineResponse> CreateRecordSetWithLineAsync(CreateRecordSetWithLineRequest createRecordSetWithLineRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , createRecordSetWithLineRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetWithLineRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRecordSetWithLineResponse>(response);
        }
        
        /// <summary>
        /// 删除单个Record Set
        ///
        /// 删除单个Record Set
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRecordSetResponse> DeleteRecordSetAsync(DeleteRecordSetRequest deleteRecordSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , deleteRecordSetRequest.ZoneId.ToString());
            urlParam.Add("recordset_id" , deleteRecordSetRequest.RecordsetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordSetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteRecordSetResponse>(response);
        }
        
        /// <summary>
        /// 删除单个Record Set
        ///
        /// 删除单个Record Set
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRecordSetsResponse> DeleteRecordSetsAsync(DeleteRecordSetsRequest deleteRecordSetsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , deleteRecordSetsRequest.ZoneId.ToString());
            urlParam.Add("recordset_id" , deleteRecordSetsRequest.RecordsetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordSetsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteRecordSetsResponse>(response);
        }
        
        /// <summary>
        /// Record Set解关联健康检查。
        ///
        /// Record Set解关联健康检查。。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateHealthCheckResponse> DisassociateHealthCheckAsync(DisassociateHealthCheckRequest disassociateHealthCheckRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("recordset_id" , disassociateHealthCheckRequest.RecordsetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets/{recordset_id}/associatehealthcheck",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateHealthCheckRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DisassociateHealthCheckResponse>(response);
        }
        
        /// <summary>
        /// 查询租户Record Set资源列表
        ///
        /// 查询租户Record Set资源列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecordSetsResponse> ListRecordSetsAsync(ListRecordSetsRequest listRecordSetsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/recordsets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRecordSetsResponse>(response);
        }
        
        /// <summary>
        /// 查询单个Zone下Record Set列表
        ///
        /// 查询单个Zone下Record Set列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecordSetsByZoneResponse> ListRecordSetsByZoneAsync(ListRecordSetsByZoneRequest listRecordSetsByZoneRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , listRecordSetsByZoneRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsByZoneRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRecordSetsByZoneResponse>(response);
        }
        
        /// <summary>
        /// 查询租户Record Set资源列表
        ///
        /// 查询租户Record Set资源列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecordSetsWithLineResponse> ListRecordSetsWithLineAsync(ListRecordSetsWithLineRequest listRecordSetsWithLineRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsWithLineRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRecordSetsWithLineResponse>(response);
        }
        
        /// <summary>
        /// 设置Record Set状态
        ///
        /// 设置Record Set状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetRecordSetsStatusResponse> SetRecordSetsStatusAsync(SetRecordSetsStatusRequest setRecordSetsStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("recordset_id" , setRecordSetsStatusRequest.RecordsetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets/{recordset_id}/statuses/set",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRecordSetsStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<SetRecordSetsStatusResponse>(response);
        }
        
        /// <summary>
        /// 查询单个Record Set
        ///
        /// 查询单个Record Set
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecordSetResponse> ShowRecordSetAsync(ShowRecordSetRequest showRecordSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , showRecordSetRequest.ZoneId.ToString());
            urlParam.Add("recordset_id" , showRecordSetRequest.RecordsetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRecordSetResponse>(response);
        }
        
        /// <summary>
        /// 查询单个Zone下Record Set列表
        ///
        /// 查询单个Zone下Record Set列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecordSetByZoneResponse> ShowRecordSetByZoneAsync(ShowRecordSetByZoneRequest showRecordSetByZoneRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , showRecordSetByZoneRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetByZoneRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRecordSetByZoneResponse>(response);
        }
        
        /// <summary>
        /// 查询单个Record Set，仅适用于公网DNS
        ///
        /// 查询单个Record Set，仅适用于公网DNS
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecordSetWithLineResponse> ShowRecordSetWithLineAsync(ShowRecordSetWithLineRequest showRecordSetWithLineRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , showRecordSetWithLineRequest.ZoneId.ToString());
            urlParam.Add("recordset_id" , showRecordSetWithLineRequest.RecordsetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetWithLineRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRecordSetWithLineResponse>(response);
        }
        
        /// <summary>
        /// 修改单个Record Set
        ///
        /// 修改单个Record Set
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRecordSetResponse> UpdateRecordSetAsync(UpdateRecordSetRequest updateRecordSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , updateRecordSetRequest.ZoneId.ToString());
            urlParam.Add("recordset_id" , updateRecordSetRequest.RecordsetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecordSetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRecordSetResponse>(response);
        }
        
        /// <summary>
        /// 修改单个Record Set
        ///
        /// 修改单个Record Set
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRecordSetsResponse> UpdateRecordSetsAsync(UpdateRecordSetsRequest updateRecordSetsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , updateRecordSetsRequest.ZoneId.ToString());
            urlParam.Add("recordset_id" , updateRecordSetsRequest.RecordsetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecordSetsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRecordSetsResponse>(response);
        }
        
        /// <summary>
        /// 为指定实例批量添加或删除标签
        ///
        /// 为指定实例批量添加或删除标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateTagResponse> BatchCreateTagAsync(BatchCreateTagRequest batchCreateTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , batchCreateTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , batchCreateTagRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateTagResponse>(response);
        }
        
        /// <summary>
        /// 为指定实例添加标签
        ///
        /// 为指定实例添加标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTagResponse> CreateTagAsync(CreateTagRequest createTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , createTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , createTagRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateTagResponse>(response);
        }
        
        /// <summary>
        /// 删除资源标签
        ///
        /// 删除资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTagResponse> DeleteTagAsync(DeleteTagRequest deleteTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , deleteTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , deleteTagRequest.ResourceId.ToString());
            urlParam.Add("key" , deleteTagRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTagResponse>(response);
        }
        
        /// <summary>
        /// 使用标签查询资源实例
        ///
        /// 使用标签查询资源实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTagResponse> ListTagAsync(ListTagRequest listTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listTagRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListTagResponse>(response);
        }
        
        /// <summary>
        /// 查询指定实例类型的所有标签集合
        ///
        /// 查询指定实例类型的所有标签集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTagsResponse> ListTagsAsync(ListTagsRequest listTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listTagsRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询指定实例的标签信息
        ///
        /// 查询指定实例的标签信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceTagResponse> ShowResourceTagAsync(ShowResourceTagRequest showResourceTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , showResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , showResourceTagRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowResourceTagResponse>(response);
        }
        
        /// <summary>
        /// 在内网Zone上关联VPC
        ///
        /// 在内网Zone上关联VPC
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateRouterResponse> AssociateRouterAsync(AssociateRouterRequest associateRouterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , associateRouterRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/associaterouter",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRouterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AssociateRouterResponse>(response);
        }
        
        /// <summary>
        /// 创建单个内网Zone
        ///
        /// 创建单个内网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePrivateZoneResponse> CreatePrivateZoneAsync(CreatePrivateZoneRequest createPrivateZoneRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/zones",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateZoneRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePrivateZoneResponse>(response);
        }
        
        /// <summary>
        /// 创建单个公网Zone
        ///
        /// 创建单个公网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePublicZoneResponse> CreatePublicZoneAsync(CreatePublicZoneRequest createPublicZoneRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/zones",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPublicZoneRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePublicZoneResponse>(response);
        }
        
        /// <summary>
        /// 删除单个内网Zone
        ///
        /// 删除单个内网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePrivateZoneResponse> DeletePrivateZoneAsync(DeletePrivateZoneRequest deletePrivateZoneRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , deletePrivateZoneRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateZoneRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeletePrivateZoneResponse>(response);
        }
        
        /// <summary>
        /// 删除单个公网Zone
        ///
        /// 删除单个公网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePublicZoneResponse> DeletePublicZoneAsync(DeletePublicZoneRequest deletePublicZoneRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , deletePublicZoneRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicZoneRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeletePublicZoneResponse>(response);
        }
        
        /// <summary>
        /// 在内网Zone上解关联VPC
        ///
        /// 在内网Zone上解关联VPC
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateRouterResponse> DisassociateRouterAsync(DisassociateRouterRequest disassociateRouterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , disassociateRouterRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/disassociaterouter",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateRouterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DisassociateRouterResponse>(response);
        }
        
        /// <summary>
        /// 查询内网Zone的列表
        ///
        /// 查询内网Zone的列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPrivateZonesResponse> ListPrivateZonesAsync(ListPrivateZonesRequest listPrivateZonesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/zones",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateZonesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPrivateZonesResponse>(response);
        }
        
        /// <summary>
        /// 查询公网Zone的列表
        ///
        /// 查询公网Zone的列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPublicZonesResponse> ListPublicZonesAsync(ListPublicZonesRequest listPublicZonesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/zones",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicZonesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPublicZonesResponse>(response);
        }
        
        /// <summary>
        /// 设置单个内网Zone的子域名递归解析代理
        ///
        /// 设置单个内网Zone的子域名递归解析代理
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetPrivateZoneProxyPatternResponse> SetPrivateZoneProxyPatternAsync(SetPrivateZoneProxyPatternRequest setPrivateZoneProxyPatternRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , setPrivateZoneProxyPatternRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/actions/set-proxy-pattern",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setPrivateZoneProxyPatternRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<SetPrivateZoneProxyPatternResponse>(response);
        }
        
        /// <summary>
        /// 查询单个内网Zone
        ///
        /// 查询单个内网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPrivateZoneResponse> ShowPrivateZoneAsync(ShowPrivateZoneRequest showPrivateZoneRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , showPrivateZoneRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateZoneRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPrivateZoneResponse>(response);
        }
        
        /// <summary>
        /// 查询单个内网Zone的名称服务器
        ///
        /// 查询单个内网Zone的名称服务器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPrivateZoneNameServerResponse> ShowPrivateZoneNameServerAsync(ShowPrivateZoneNameServerRequest showPrivateZoneNameServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , showPrivateZoneNameServerRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/nameservers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateZoneNameServerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPrivateZoneNameServerResponse>(response);
        }
        
        /// <summary>
        /// 查询单个公网Zone
        ///
        /// 查询单个公网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPublicZoneResponse> ShowPublicZoneAsync(ShowPublicZoneRequest showPublicZoneRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , showPublicZoneRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicZoneRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPublicZoneResponse>(response);
        }
        
        /// <summary>
        /// 查询单个公网Zone的名称服务器
        ///
        /// 查询单个公网Zone的名称服务器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPublicZoneNameServerResponse> ShowPublicZoneNameServerAsync(ShowPublicZoneNameServerRequest showPublicZoneNameServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , showPublicZoneNameServerRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/nameservers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicZoneNameServerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPublicZoneNameServerResponse>(response);
        }
        
        /// <summary>
        /// 修改单个内网Zone
        ///
        /// 修改单个内网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePrivateZoneResponse> UpdatePrivateZoneAsync(UpdatePrivateZoneRequest updatePrivateZoneRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , updatePrivateZoneRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateZoneRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<UpdatePrivateZoneResponse>(response);
        }
        
        /// <summary>
        /// 修改单个公网Zone
        ///
        /// 修改单个公网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePublicZoneResponse> UpdatePublicZoneAsync(UpdatePublicZoneRequest updatePublicZoneRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , updatePublicZoneRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePublicZoneRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<UpdatePublicZoneResponse>(response);
        }
        
        /// <summary>
        /// 设置单个公网Zone状态，支持暂停、启用Zone
        ///
        /// 设置单个公网Zone状态，支持暂停、启用Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePublicZoneStatusResponse> UpdatePublicZoneStatusAsync(UpdatePublicZoneStatusRequest updatePublicZoneStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , updatePublicZoneStatusRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/statuses",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePublicZoneStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePublicZoneStatusResponse>(response);
        }
        
    }
}