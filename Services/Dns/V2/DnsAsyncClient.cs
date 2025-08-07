using System;
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
        /// 终端节点绑定IP地址
        ///
        /// 终端节点绑定IP地址。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateEndpointIpaddressResponse> AssociateEndpointIpaddressAsync(AssociateEndpointIpaddressRequest associateEndpointIpaddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id", associateEndpointIpaddressRequest.EndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}/ipaddresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateEndpointIpaddressRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AssociateEndpointIpaddressResponse>(response);
        }

        public AsyncInvoker<AssociateEndpointIpaddressResponse> AssociateEndpointIpaddressAsyncInvoker(AssociateEndpointIpaddressRequest associateEndpointIpaddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id", associateEndpointIpaddressRequest.EndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}/ipaddresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateEndpointIpaddressRequest);
            return new AsyncInvoker<AssociateEndpointIpaddressResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateEndpointIpaddressResponse>);
        }
        
        /// <summary>
        /// 解析器转发规则关联VPC
        ///
        /// 解析器转发规则关联VPC。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateResolverRuleRouterResponse> AssociateResolverRuleRouterAsync(AssociateResolverRuleRouterRequest associateResolverRuleRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resolverrule_id", associateResolverRuleRouterRequest.ResolverruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules/{resolverrule_id}/associaterouter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateResolverRuleRouterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AssociateResolverRuleRouterResponse>(response);
        }

        public AsyncInvoker<AssociateResolverRuleRouterResponse> AssociateResolverRuleRouterAsyncInvoker(AssociateResolverRuleRouterRequest associateResolverRuleRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resolverrule_id", associateResolverRuleRouterRequest.ResolverruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules/{resolverrule_id}/associaterouter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateResolverRuleRouterRequest);
            return new AsyncInvoker<AssociateResolverRuleRouterResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateResolverRuleRouterResponse>);
        }
        
        /// <summary>
        /// 在内网域名上关联VPC
        ///
        /// 当您的内网域名创建完成后，可以通过调用此接口为内网域名关联新的VPC。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateRouterResponse> AssociateRouterAsync(AssociateRouterRequest associateRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", associateRouterRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/associaterouter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRouterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AssociateRouterResponse>(response);
        }

        public AsyncInvoker<AssociateRouterResponse> AssociateRouterAsyncInvoker(AssociateRouterRequest associateRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", associateRouterRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/associaterouter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRouterRequest);
            return new AsyncInvoker<AssociateRouterResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateRouterResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchCreateTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchCreateTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateTagResponse>(response);
        }

        public AsyncInvoker<BatchCreateTagResponse> BatchCreateTagAsyncInvoker(BatchCreateTagRequest batchCreateTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchCreateTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchCreateTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateTagRequest);
            return new AsyncInvoker<BatchCreateTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateTagResponse>);
        }
        
        /// <summary>
        /// 批量删除反向解析
        ///
        /// 批量删除反向解析。本接口为原子操作，所有记录应全部删除成功或全部失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeletePtrRecordsResponse> BatchDeletePtrRecordsAsync(BatchDeletePtrRecordsRequest batchDeletePtrRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/reverse/floatingips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePtrRecordsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<BatchDeletePtrRecordsResponse>(response);
        }

        public AsyncInvoker<BatchDeletePtrRecordsResponse> BatchDeletePtrRecordsAsyncInvoker(BatchDeletePtrRecordsRequest batchDeletePtrRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/reverse/floatingips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePtrRecordsRequest);
            return new AsyncInvoker<BatchDeletePtrRecordsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<BatchDeletePtrRecordsResponse>);
        }
        
        /// <summary>
        /// 批量删除域名下的记录集
        ///
        /// 批量删除域名下的记录集，当删除的资源不存在时，则默认删除成功。
        /// 响应结果中只包含本次实际删除的资源。
        /// 支持公网域名和内网域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteRecordSetWithLineResponse> BatchDeleteRecordSetWithLineAsync(BatchDeleteRecordSetWithLineRequest batchDeleteRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", batchDeleteRecordSetWithLineRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRecordSetWithLineRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteRecordSetWithLineResponse>(response);
        }

        public AsyncInvoker<BatchDeleteRecordSetWithLineResponse> BatchDeleteRecordSetWithLineAsyncInvoker(BatchDeleteRecordSetWithLineRequest batchDeleteRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", batchDeleteRecordSetWithLineRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRecordSetWithLineRequest);
            return new AsyncInvoker<BatchDeleteRecordSetWithLineResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteRecordSetWithLineResponse>);
        }
        
        /// <summary>
        /// 批量删除记录集
        ///
        /// 批量删除记录集。
        /// 响应结果中只包含本次实际删除的记录集。
        /// 支持批量删除公网域名和内网域名的记录集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteRecordSetsResponse> BatchDeleteRecordSetsAsync(BatchDeleteRecordSetsRequest batchDeleteRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRecordSetsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteRecordSetsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteRecordSetsResponse> BatchDeleteRecordSetsAsyncInvoker(BatchDeleteRecordSetsRequest batchDeleteRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRecordSetsRequest);
            return new AsyncInvoker<BatchDeleteRecordSetsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteRecordSetsResponse>);
        }
        
        /// <summary>
        /// 批量删除域名
        ///
        /// 批量删除域名。
        /// 本接口为原子操作，所有记录应全部删除成功或全部失败。
        /// 支持公网域名、内网域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteZonesResponse> BatchDeleteZonesAsync(BatchDeleteZonesRequest batchDeleteZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteZonesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteZonesResponse>(response);
        }

        public AsyncInvoker<BatchDeleteZonesResponse> BatchDeleteZonesAsyncInvoker(BatchDeleteZonesRequest batchDeleteZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteZonesRequest);
            return new AsyncInvoker<BatchDeleteZonesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteZonesResponse>);
        }
        
        /// <summary>
        /// 批量设置记录集状态
        ///
        /// 批量设置记录集状态。
        /// 响应结果中只包含本次实际更新的记录集。
        /// 支持公网域名和内网域名的记录集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchSetRecordSetsStatusResponse> BatchSetRecordSetsStatusAsync(BatchSetRecordSetsStatusRequest batchSetRecordSetsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetRecordSetsStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchSetRecordSetsStatusResponse>(response);
        }

        public AsyncInvoker<BatchSetRecordSetsStatusResponse> BatchSetRecordSetsStatusAsyncInvoker(BatchSetRecordSetsStatusRequest batchSetRecordSetsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetRecordSetsStatusRequest);
            return new AsyncInvoker<BatchSetRecordSetsStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchSetRecordSetsStatusResponse>);
        }
        
        /// <summary>
        /// 批量设置域名状态
        ///
        /// 批量设置域名状态。
        /// 响应结果中只包含本次实际更新的域名。
        /// 支持公网域名、内网域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchSetZonesStatusResponse> BatchSetZonesStatusAsync(BatchSetZonesStatusRequest batchSetZonesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetZonesStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchSetZonesStatusResponse>(response);
        }

        public AsyncInvoker<BatchSetZonesStatusResponse> BatchSetZonesStatusAsyncInvoker(BatchSetZonesStatusRequest batchSetZonesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetZonesStatusRequest);
            return new AsyncInvoker<BatchSetZonesStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchSetZonesStatusResponse>);
        }
        
        /// <summary>
        /// 批量修改记录集
        ///
        /// 批量修改记录集。属于原子性操作，请求记录集将全部完成修改，或不做任何修改。
        /// 仅公网域名支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateRecordSetWithLineResponse> BatchUpdateRecordSetWithLineAsync(BatchUpdateRecordSetWithLineRequest batchUpdateRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", batchUpdateRecordSetWithLineRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateRecordSetWithLineRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateRecordSetWithLineResponse>(response);
        }

        public AsyncInvoker<BatchUpdateRecordSetWithLineResponse> BatchUpdateRecordSetWithLineAsyncInvoker(BatchUpdateRecordSetWithLineRequest batchUpdateRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", batchUpdateRecordSetWithLineRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateRecordSetWithLineRequest);
            return new AsyncInvoker<BatchUpdateRecordSetWithLineResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateRecordSetWithLineResponse>);
        }
        
        /// <summary>
        /// 创建自定义线路
        ///
        /// 创建自定义线路。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCustomLineResponse> CreateCustomLineAsync(CreateCustomLineRequest createCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCustomLineRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateCustomLineResponse>(response);
        }

        public AsyncInvoker<CreateCustomLineResponse> CreateCustomLineAsyncInvoker(CreateCustomLineRequest createCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCustomLineRequest);
            return new AsyncInvoker<CreateCustomLineResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCustomLineResponse>);
        }
        
        /// <summary>
        /// 创建终端节点
        ///
        /// 创建终端节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest createEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEndpointRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateEndpointResponse>(response);
        }

        public AsyncInvoker<CreateEndpointResponse> CreateEndpointAsyncInvoker(CreateEndpointRequest createEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEndpointRequest);
            return new AsyncInvoker<CreateEndpointResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEndpointResponse>);
        }
        
        /// <summary>
        /// 创建线路分组
        ///
        /// 创建线路分组。该接口部分区域未上线，如需使用请提交工单申请开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLineGroupResponse> CreateLineGroupAsync(CreateLineGroupRequest createLineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLineGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateLineGroupResponse>(response);
        }

        public AsyncInvoker<CreateLineGroupResponse> CreateLineGroupAsyncInvoker(CreateLineGroupRequest createLineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLineGroupRequest);
            return new AsyncInvoker<CreateLineGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLineGroupResponse>);
        }
        
        /// <summary>
        /// 创建内网域名
        ///
        /// 内网域名是指在VPC中生效的域名，内网域名创建后，用户可以将其与私网IP地址相关联，为云服务提供VPC内的内网域名解析服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePrivateZoneResponse> CreatePrivateZoneAsync(CreatePrivateZoneRequest createPrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateZoneRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePrivateZoneResponse>(response);
        }

        public AsyncInvoker<CreatePrivateZoneResponse> CreatePrivateZoneAsyncInvoker(CreatePrivateZoneRequest createPrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateZoneRequest);
            return new AsyncInvoker<CreatePrivateZoneResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePrivateZoneResponse>);
        }
        
        /// <summary>
        /// 创建公网域名
        ///
        /// 您在使用华为云云解析服务为自己注册的域名配置DNS解析之前，需要先将域名添加至云解析服务控制台。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePublicZoneResponse> CreatePublicZoneAsync(CreatePublicZoneRequest createPublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPublicZoneRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePublicZoneResponse>(response);
        }

        public AsyncInvoker<CreatePublicZoneResponse> CreatePublicZoneAsyncInvoker(CreatePublicZoneRequest createPublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPublicZoneRequest);
            return new AsyncInvoker<CreatePublicZoneResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePublicZoneResponse>);
        }
        
        /// <summary>
        /// 批量线路创建记录集
        ///
        /// 批量线路创建记录集。属于原子性操作，如果存在一个参数校验不通过，则创建失败。仅公网域名支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRecordSetWithBatchLinesResponse> CreateRecordSetWithBatchLinesAsync(CreateRecordSetWithBatchLinesRequest createRecordSetWithBatchLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", createRecordSetWithBatchLinesRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/batch/lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetWithBatchLinesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRecordSetWithBatchLinesResponse>(response);
        }

        public AsyncInvoker<CreateRecordSetWithBatchLinesResponse> CreateRecordSetWithBatchLinesAsyncInvoker(CreateRecordSetWithBatchLinesRequest createRecordSetWithBatchLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", createRecordSetWithBatchLinesRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/batch/lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetWithBatchLinesRequest);
            return new AsyncInvoker<CreateRecordSetWithBatchLinesResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRecordSetWithBatchLinesResponse>);
        }
        
        /// <summary>
        /// 创建解析器转发规则
        ///
        /// 创建解析器转发规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateResolverRuleResponse> CreateResolverRuleAsync(CreateResolverRuleRequest createResolverRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResolverRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateResolverRuleResponse>(response);
        }

        public AsyncInvoker<CreateResolverRuleResponse> CreateResolverRuleAsyncInvoker(CreateResolverRuleRequest createResolverRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResolverRuleRequest);
            return new AsyncInvoker<CreateResolverRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateResolverRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTagResponse>(response);
        }

        public AsyncInvoker<CreateTagResponse> CreateTagAsyncInvoker(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            return new AsyncInvoker<CreateTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagResponse>);
        }
        
        /// <summary>
        /// 删除自定义线路
        ///
        /// 删除自定义线路。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCustomLineResponse> DeleteCustomLineAsync(DeleteCustomLineRequest deleteCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("line_id", deleteCustomLineRequest.LineId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines/{line_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomLineRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteCustomLineResponse>(response);
        }

        public AsyncInvoker<DeleteCustomLineResponse> DeleteCustomLineAsyncInvoker(DeleteCustomLineRequest deleteCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("line_id", deleteCustomLineRequest.LineId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines/{line_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomLineRequest);
            return new AsyncInvoker<DeleteCustomLineResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteCustomLineResponse>);
        }
        
        /// <summary>
        /// 删除终端节点
        ///
        /// 删除终端节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest deleteEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id", deleteEndpointRequest.EndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteEndpointResponse>(response);
        }

        public AsyncInvoker<DeleteEndpointResponse> DeleteEndpointAsyncInvoker(DeleteEndpointRequest deleteEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id", deleteEndpointRequest.EndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointRequest);
            return new AsyncInvoker<DeleteEndpointResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteEndpointResponse>);
        }
        
        /// <summary>
        /// 删除线路分组
        ///
        /// 删除线路分组。该接口部分区域未上线，如需使用请提交工单申请开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLineGroupResponse> DeleteLineGroupAsync(DeleteLineGroupRequest deleteLineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("linegroup_id", deleteLineGroupRequest.LinegroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLineGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteLineGroupResponse>(response);
        }

        public AsyncInvoker<DeleteLineGroupResponse> DeleteLineGroupAsyncInvoker(DeleteLineGroupRequest deleteLineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("linegroup_id", deleteLineGroupRequest.LinegroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLineGroupRequest);
            return new AsyncInvoker<DeleteLineGroupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteLineGroupResponse>);
        }
        
        /// <summary>
        /// 删除内网域名
        ///
        /// 当您的内网域名不再使用时，您可以通过调用此接口将其删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePrivateZoneResponse> DeletePrivateZoneAsync(DeletePrivateZoneRequest deletePrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", deletePrivateZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateZoneRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePrivateZoneResponse>(response);
        }

        public AsyncInvoker<DeletePrivateZoneResponse> DeletePrivateZoneAsyncInvoker(DeletePrivateZoneRequest deletePrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", deletePrivateZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateZoneRequest);
            return new AsyncInvoker<DeletePrivateZoneResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePrivateZoneResponse>);
        }
        
        /// <summary>
        /// 删除公网域名
        ///
        /// 当您的公网域名不再使用时，您可以通过调用此接口将其删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePublicZoneResponse> DeletePublicZoneAsync(DeletePublicZoneRequest deletePublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", deletePublicZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicZoneRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePublicZoneResponse>(response);
        }

        public AsyncInvoker<DeletePublicZoneResponse> DeletePublicZoneAsyncInvoker(DeletePublicZoneRequest deletePublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", deletePublicZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicZoneRequest);
            return new AsyncInvoker<DeletePublicZoneResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePublicZoneResponse>);
        }
        
        /// <summary>
        /// 删除解析器转发规则
        ///
        /// 删除解析器转发规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteResolverRuleResponse> DeleteResolverRuleAsync(DeleteResolverRuleRequest deleteResolverRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resolverrule_id", deleteResolverRuleRequest.ResolverruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules/{resolverrule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResolverRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteResolverRuleResponse>(response);
        }

        public AsyncInvoker<DeleteResolverRuleResponse> DeleteResolverRuleAsyncInvoker(DeleteResolverRuleRequest deleteResolverRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resolverrule_id", deleteResolverRuleRequest.ResolverruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules/{resolverrule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResolverRuleRequest);
            return new AsyncInvoker<DeleteResolverRuleResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteResolverRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", deleteTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", deleteTagRequest.ResourceId.ToString());
            urlParam.Add("key", deleteTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTagResponse>(response);
        }

        public AsyncInvoker<DeleteTagResponse> DeleteTagAsyncInvoker(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", deleteTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", deleteTagRequest.ResourceId.ToString());
            urlParam.Add("key", deleteTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            return new AsyncInvoker<DeleteTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTagResponse>);
        }
        
        /// <summary>
        /// 终端节点解绑IP地址
        ///
        /// 终端节点解绑IP地址。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateEndpointIpaddressResponse> DisassociateEndpointIpaddressAsync(DisassociateEndpointIpaddressRequest disassociateEndpointIpaddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id", disassociateEndpointIpaddressRequest.EndpointId.ToString());
            urlParam.Add("ipaddress_id", disassociateEndpointIpaddressRequest.IpaddressId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}/ipaddresses/{ipaddress_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateEndpointIpaddressRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DisassociateEndpointIpaddressResponse>(response);
        }

        public AsyncInvoker<DisassociateEndpointIpaddressResponse> DisassociateEndpointIpaddressAsyncInvoker(DisassociateEndpointIpaddressRequest disassociateEndpointIpaddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id", disassociateEndpointIpaddressRequest.EndpointId.ToString());
            urlParam.Add("ipaddress_id", disassociateEndpointIpaddressRequest.IpaddressId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}/ipaddresses/{ipaddress_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateEndpointIpaddressRequest);
            return new AsyncInvoker<DisassociateEndpointIpaddressResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DisassociateEndpointIpaddressResponse>);
        }
        
        /// <summary>
        /// 解析器转发规则解关联VPC
        ///
        /// 解析器转发规则解关联VPC。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateResolverRuleRouterResponse> DisassociateResolverRuleRouterAsync(DisassociateResolverRuleRouterRequest disassociateResolverRuleRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resolverrule_id", disassociateResolverRuleRouterRequest.ResolverruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules/{resolverrule_id}/disassociaterouter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateResolverRuleRouterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisassociateResolverRuleRouterResponse>(response);
        }

        public AsyncInvoker<DisassociateResolverRuleRouterResponse> DisassociateResolverRuleRouterAsyncInvoker(DisassociateResolverRuleRouterRequest disassociateResolverRuleRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resolverrule_id", disassociateResolverRuleRouterRequest.ResolverruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules/{resolverrule_id}/disassociaterouter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateResolverRuleRouterRequest);
            return new AsyncInvoker<DisassociateResolverRuleRouterResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateResolverRuleRouterResponse>);
        }
        
        /// <summary>
        /// 在内网域名上解关联VPC
        ///
        /// 当您的内网域名创建完成后，可以通过调用此接口为内网域名解除已关联的VPC。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateRouterResponse> DisassociateRouterAsync(DisassociateRouterRequest disassociateRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", disassociateRouterRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/disassociaterouter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateRouterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisassociateRouterResponse>(response);
        }

        public AsyncInvoker<DisassociateRouterResponse> DisassociateRouterAsyncInvoker(DisassociateRouterRequest disassociateRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", disassociateRouterRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/disassociaterouter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateRouterRequest);
            return new AsyncInvoker<DisassociateRouterResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateRouterResponse>);
        }
        
        /// <summary>
        /// 查询API版本信息列表
        ///
        /// 查询云解析服务支持的所有API版本信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApiVersionsResponse> ListApiVersionsAsync(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }

        public AsyncInvoker<ListApiVersionsResponse> ListApiVersionsAsyncInvoker(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            return new AsyncInvoker<ListApiVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionsResponse>);
        }
        
        /// <summary>
        /// 查询自定义线路
        ///
        /// 查询自定义线路。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCustomLineResponse> ListCustomLineAsync(ListCustomLineRequest listCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomLineRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCustomLineResponse>(response);
        }

        public AsyncInvoker<ListCustomLineResponse> ListCustomLineAsyncInvoker(ListCustomLineRequest listCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomLineRequest);
            return new AsyncInvoker<ListCustomLineResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCustomLineResponse>);
        }
        
        /// <summary>
        /// 查询IP地址列表
        ///
        /// 查询终端节点下的IP地址列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEndpointIpaddressesResponse> ListEndpointIpaddressesAsync(ListEndpointIpaddressesRequest listEndpointIpaddressesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id", listEndpointIpaddressesRequest.EndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}/ipaddresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointIpaddressesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEndpointIpaddressesResponse>(response);
        }

        public AsyncInvoker<ListEndpointIpaddressesResponse> ListEndpointIpaddressesAsyncInvoker(ListEndpointIpaddressesRequest listEndpointIpaddressesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id", listEndpointIpaddressesRequest.EndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}/ipaddresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointIpaddressesRequest);
            return new AsyncInvoker<ListEndpointIpaddressesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEndpointIpaddressesResponse>);
        }
        
        /// <summary>
        /// 查询终端节点VPC列表
        ///
        /// 查询终端节点VPC列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEndpointVpcsResponse> ListEndpointVpcsAsync(ListEndpointVpcsRequest listEndpointVpcsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/vpcs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointVpcsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEndpointVpcsResponse>(response);
        }

        public AsyncInvoker<ListEndpointVpcsResponse> ListEndpointVpcsAsyncInvoker(ListEndpointVpcsRequest listEndpointVpcsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/vpcs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointVpcsRequest);
            return new AsyncInvoker<ListEndpointVpcsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEndpointVpcsResponse>);
        }
        
        /// <summary>
        /// 查询终端节点列表
        ///
        /// 查询终端节点列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEndpointsResponse> ListEndpointsAsync(ListEndpointsRequest listEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEndpointsResponse>(response);
        }

        public AsyncInvoker<ListEndpointsResponse> ListEndpointsAsyncInvoker(ListEndpointsRequest listEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointsRequest);
            return new AsyncInvoker<ListEndpointsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEndpointsResponse>);
        }
        
        /// <summary>
        /// 查询线路分组列表
        ///
        /// 查询线路分组列表。该接口部分区域未上线，如需使用请提交工单申请开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLineGroupsResponse> ListLineGroupsAsync(ListLineGroupsRequest listLineGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLineGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLineGroupsResponse>(response);
        }

        public AsyncInvoker<ListLineGroupsResponse> ListLineGroupsAsyncInvoker(ListLineGroupsRequest listLineGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLineGroupsRequest);
            return new AsyncInvoker<ListLineGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLineGroupsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/nameservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNameServersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNameServersResponse>(response);
        }

        public AsyncInvoker<ListNameServersResponse> ListNameServersAsyncInvoker(ListNameServersRequest listNameServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/nameservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNameServersRequest);
            return new AsyncInvoker<ListNameServersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNameServersResponse>);
        }
        
        /// <summary>
        /// 查询内网域名列表
        ///
        /// 当您的内网域名创建成功后，您可以通过调用此接口查询单个内网域名信息，包括域名、ID、状态、记录集个数、企业项目、标签、TTL、创建时间、修改时间、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPrivateZonesResponse> ListPrivateZonesAsync(ListPrivateZonesRequest listPrivateZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateZonesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPrivateZonesResponse>(response);
        }

        public AsyncInvoker<ListPrivateZonesResponse> ListPrivateZonesAsyncInvoker(ListPrivateZonesRequest listPrivateZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateZonesRequest);
            return new AsyncInvoker<ListPrivateZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPrivateZonesResponse>);
        }
        
        /// <summary>
        /// 查询公网域名列表
        ///
        /// 当您的公网域名创建成功后，您可以通过调用此接口查询所有公网域名信息，包括域名、ID、状态、记录集个数、企业项目、标签、TTL、创建时间、修改时间、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPublicZonesResponse> ListPublicZonesAsync(ListPublicZonesRequest listPublicZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicZonesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPublicZonesResponse>(response);
        }

        public AsyncInvoker<ListPublicZonesResponse> ListPublicZonesAsyncInvoker(ListPublicZonesRequest listPublicZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicZonesRequest);
            return new AsyncInvoker<ListPublicZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublicZonesResponse>);
        }
        
        /// <summary>
        /// 查询解析器转发规则列表
        ///
        /// 查询解析器转发规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResolverRulesResponse> ListResolverRulesAsync(ListResolverRulesRequest listResolverRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResolverRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListResolverRulesResponse>(response);
        }

        public AsyncInvoker<ListResolverRulesResponse> ListResolverRulesAsyncInvoker(ListResolverRulesRequest listResolverRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResolverRulesRequest);
            return new AsyncInvoker<ListResolverRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResolverRulesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listTagRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListTagResponse>(response);
        }

        public AsyncInvoker<ListTagResponse> ListTagAsyncInvoker(ListTagRequest listTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listTagRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagRequest);
            return new AsyncInvoker<ListTagResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTagResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTagsResponse>(response);
        }

        public AsyncInvoker<ListTagsResponse> ListTagsAsyncInvoker(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            return new AsyncInvoker<ListTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagsResponse>);
        }
        
        /// <summary>
        /// 设置内网域名的子域名递归解析代理
        ///
        /// 当您的内网域名创建成功后，您可以通过调用此接口设置开启或者关闭内网域名的子域名递归解析代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetPrivateZoneProxyPatternResponse> SetPrivateZoneProxyPatternAsync(SetPrivateZoneProxyPatternRequest setPrivateZoneProxyPatternRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", setPrivateZoneProxyPatternRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/actions/set-proxy-pattern", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setPrivateZoneProxyPatternRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SetPrivateZoneProxyPatternResponse>(response);
        }

        public AsyncInvoker<SetPrivateZoneProxyPatternResponse> SetPrivateZoneProxyPatternAsyncInvoker(SetPrivateZoneProxyPatternRequest setPrivateZoneProxyPatternRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", setPrivateZoneProxyPatternRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/actions/set-proxy-pattern", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setPrivateZoneProxyPatternRequest);
            return new AsyncInvoker<SetPrivateZoneProxyPatternResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetPrivateZoneProxyPatternResponse>);
        }
        
        /// <summary>
        /// 查询指定版本号的API版本信息
        ///
        /// 查询指定版本号的云解析服务API版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowApiInfoResponse> ShowApiInfoAsync(ShowApiInfoRequest showApiInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", showApiInfoRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowApiInfoResponse>(response);
        }

        public AsyncInvoker<ShowApiInfoResponse> ShowApiInfoAsyncInvoker(ShowApiInfoRequest showApiInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", showApiInfoRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiInfoRequest);
            return new AsyncInvoker<ShowApiInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApiInfoResponse>);
        }
        
        /// <summary>
        /// 查询租户配额
        ///
        /// 查询租户在DNS服务下的资源配额，包括公网域名配额、内网域名配额、记录集配额、反向解析配额、自定义线路配额、线路分组配额、入站终端节点配额、出站终端节点配额、转发规则配额等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainQuotaResponse> ShowDomainQuotaAsync(ShowDomainQuotaRequest showDomainQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/quotamg/dns/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainQuotaResponse>(response);
        }

        public AsyncInvoker<ShowDomainQuotaResponse> ShowDomainQuotaAsyncInvoker(ShowDomainQuotaRequest showDomainQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/quotamg/dns/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainQuotaRequest);
            return new AsyncInvoker<ShowDomainQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainQuotaResponse>);
        }
        
        /// <summary>
        /// 查询终端节点
        ///
        /// 查询终端节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEndpointResponse> ShowEndpointAsync(ShowEndpointRequest showEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id", showEndpointRequest.EndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEndpointRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowEndpointResponse>(response);
        }

        public AsyncInvoker<ShowEndpointResponse> ShowEndpointAsyncInvoker(ShowEndpointRequest showEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id", showEndpointRequest.EndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEndpointRequest);
            return new AsyncInvoker<ShowEndpointResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEndpointResponse>);
        }
        
        /// <summary>
        /// 查询线路分组
        ///
        /// 查询线路分组。该接口部分区域未上线，如需使用请提交工单申请开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLineGroupResponse> ShowLineGroupAsync(ShowLineGroupRequest showLineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("linegroup_id", showLineGroupRequest.LinegroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLineGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLineGroupResponse>(response);
        }

        public AsyncInvoker<ShowLineGroupResponse> ShowLineGroupAsyncInvoker(ShowLineGroupRequest showLineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("linegroup_id", showLineGroupRequest.LinegroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLineGroupRequest);
            return new AsyncInvoker<ShowLineGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLineGroupResponse>);
        }
        
        /// <summary>
        /// 查询内网域名
        ///
        /// 当您的内网域名创建成功后，您可以通过调用此接口查询单个内网域名信息，包括域名、ID、状态、记录集个数、企业项目、标签、TTL、创建时间、修改时间、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPrivateZoneResponse> ShowPrivateZoneAsync(ShowPrivateZoneRequest showPrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showPrivateZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateZoneRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPrivateZoneResponse>(response);
        }

        public AsyncInvoker<ShowPrivateZoneResponse> ShowPrivateZoneAsyncInvoker(ShowPrivateZoneRequest showPrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showPrivateZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateZoneRequest);
            return new AsyncInvoker<ShowPrivateZoneResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPrivateZoneResponse>);
        }
        
        /// <summary>
        /// 查询内网域名的名称服务器
        ///
        /// 当您的内网域名创建成功后，您可以通过调用此接口查询内网域名的名称服务器信息，包括优先级、DNS服务器地址等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPrivateZoneNameServerResponse> ShowPrivateZoneNameServerAsync(ShowPrivateZoneNameServerRequest showPrivateZoneNameServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showPrivateZoneNameServerRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/nameservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateZoneNameServerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPrivateZoneNameServerResponse>(response);
        }

        public AsyncInvoker<ShowPrivateZoneNameServerResponse> ShowPrivateZoneNameServerAsyncInvoker(ShowPrivateZoneNameServerRequest showPrivateZoneNameServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showPrivateZoneNameServerRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/nameservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateZoneNameServerRequest);
            return new AsyncInvoker<ShowPrivateZoneNameServerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPrivateZoneNameServerResponse>);
        }
        
        /// <summary>
        /// 查询公网域名
        ///
        /// 当您的公网域名创建成功后，您可以通过调用此接口查询单个公网域名信息，包括域名、ID、状态、记录集个数、企业项目、标签、TTL、创建时间、修改时间、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPublicZoneResponse> ShowPublicZoneAsync(ShowPublicZoneRequest showPublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showPublicZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicZoneRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPublicZoneResponse>(response);
        }

        public AsyncInvoker<ShowPublicZoneResponse> ShowPublicZoneAsyncInvoker(ShowPublicZoneRequest showPublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showPublicZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicZoneRequest);
            return new AsyncInvoker<ShowPublicZoneResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPublicZoneResponse>);
        }
        
        /// <summary>
        /// 查询公网域名的名称服务器
        ///
        /// 当您的公网域名创建成功后，您可以通过调用此接口查询公网域名的名称服务器信息，包括主机名、优先级等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPublicZoneNameServerResponse> ShowPublicZoneNameServerAsync(ShowPublicZoneNameServerRequest showPublicZoneNameServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showPublicZoneNameServerRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/nameservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicZoneNameServerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPublicZoneNameServerResponse>(response);
        }

        public AsyncInvoker<ShowPublicZoneNameServerResponse> ShowPublicZoneNameServerAsyncInvoker(ShowPublicZoneNameServerRequest showPublicZoneNameServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showPublicZoneNameServerRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/nameservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicZoneNameServerRequest);
            return new AsyncInvoker<ShowPublicZoneNameServerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPublicZoneNameServerResponse>);
        }
        
        /// <summary>
        /// 查询解析器转发规则
        ///
        /// 查询解析器转发规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResolverRuleResponse> ShowResolverRuleAsync(ShowResolverRuleRequest showResolverRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resolverrule_id", showResolverRuleRequest.ResolverruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules/{resolverrule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResolverRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowResolverRuleResponse>(response);
        }

        public AsyncInvoker<ShowResolverRuleResponse> ShowResolverRuleAsyncInvoker(ShowResolverRuleRequest showResolverRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resolverrule_id", showResolverRuleRequest.ResolverruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules/{resolverrule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResolverRuleRequest);
            return new AsyncInvoker<ShowResolverRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResolverRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", showResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", showResourceTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceTagRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceTagResponse>(response);
        }

        public AsyncInvoker<ShowResourceTagResponse> ShowResourceTagAsyncInvoker(ShowResourceTagRequest showResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", showResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", showResourceTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceTagRequest);
            return new AsyncInvoker<ShowResourceTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceTagResponse>);
        }
        
        /// <summary>
        /// 修改自定义线路
        ///
        /// 修改自定义线路。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateCustomLineResponse> UpdateCustomLineAsync(UpdateCustomLineRequest updateCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("line_id", updateCustomLineRequest.LineId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines/{line_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCustomLineRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCustomLineResponse>(response);
        }

        public AsyncInvoker<UpdateCustomLineResponse> UpdateCustomLineAsyncInvoker(UpdateCustomLineRequest updateCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("line_id", updateCustomLineRequest.LineId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines/{line_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCustomLineRequest);
            return new AsyncInvoker<UpdateCustomLineResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCustomLineResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id", updateEndpointRequest.EndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEndpointRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEndpointResponse>(response);
        }

        public AsyncInvoker<UpdateEndpointResponse> UpdateEndpointAsyncInvoker(UpdateEndpointRequest updateEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id", updateEndpointRequest.EndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEndpointRequest);
            return new AsyncInvoker<UpdateEndpointResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEndpointResponse>);
        }
        
        /// <summary>
        /// 修改线路分组
        ///
        /// 修改线路分组。该接口部分区域未上线，如需使用请提交工单申请开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLineGroupsResponse> UpdateLineGroupsAsync(UpdateLineGroupsRequest updateLineGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("linegroup_id", updateLineGroupsRequest.LinegroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLineGroupsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLineGroupsResponse>(response);
        }

        public AsyncInvoker<UpdateLineGroupsResponse> UpdateLineGroupsAsyncInvoker(UpdateLineGroupsRequest updateLineGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("linegroup_id", updateLineGroupsRequest.LinegroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLineGroupsRequest);
            return new AsyncInvoker<UpdateLineGroupsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLineGroupsResponse>);
        }
        
        /// <summary>
        /// 修改内网域名
        ///
        /// 当您的内网域名创建成功后，您可以通过调用此接口修改内网域名的基本信息，包括TTL、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePrivateZoneResponse> UpdatePrivateZoneAsync(UpdatePrivateZoneRequest updatePrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updatePrivateZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateZoneRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpdatePrivateZoneResponse>(response);
        }

        public AsyncInvoker<UpdatePrivateZoneResponse> UpdatePrivateZoneAsyncInvoker(UpdatePrivateZoneRequest updatePrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updatePrivateZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateZoneRequest);
            return new AsyncInvoker<UpdatePrivateZoneResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdatePrivateZoneResponse>);
        }
        
        /// <summary>
        /// 设置内网域名状态
        ///
        /// 当您的内网域名创建成功后，您可以通过调用此接口设置内网域名的状态，包括暂停、启用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePrivateZoneStatusResponse> UpdatePrivateZoneStatusAsync(UpdatePrivateZoneStatusRequest updatePrivateZoneStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updatePrivateZoneStatusRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateZoneStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePrivateZoneStatusResponse>(response);
        }

        public AsyncInvoker<UpdatePrivateZoneStatusResponse> UpdatePrivateZoneStatusAsyncInvoker(UpdatePrivateZoneStatusRequest updatePrivateZoneStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updatePrivateZoneStatusRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateZoneStatusRequest);
            return new AsyncInvoker<UpdatePrivateZoneStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePrivateZoneStatusResponse>);
        }
        
        /// <summary>
        /// 修改公网域名
        ///
        /// 当您的公网域名创建成功后，您可以通过调用此接口修改公网域名的基本信息，包括TTL、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePublicZoneResponse> UpdatePublicZoneAsync(UpdatePublicZoneRequest updatePublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updatePublicZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePublicZoneRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpdatePublicZoneResponse>(response);
        }

        public AsyncInvoker<UpdatePublicZoneResponse> UpdatePublicZoneAsyncInvoker(UpdatePublicZoneRequest updatePublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updatePublicZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePublicZoneRequest);
            return new AsyncInvoker<UpdatePublicZoneResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdatePublicZoneResponse>);
        }
        
        /// <summary>
        /// 设置公网域名状态
        ///
        /// 当您的公网域名创建成功后，您可以通过调用此接口设置公网域名的状态，包括暂停、启用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePublicZoneStatusResponse> UpdatePublicZoneStatusAsync(UpdatePublicZoneStatusRequest updatePublicZoneStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updatePublicZoneStatusRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePublicZoneStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePublicZoneStatusResponse>(response);
        }

        public AsyncInvoker<UpdatePublicZoneStatusResponse> UpdatePublicZoneStatusAsyncInvoker(UpdatePublicZoneStatusRequest updatePublicZoneStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updatePublicZoneStatusRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePublicZoneStatusRequest);
            return new AsyncInvoker<UpdatePublicZoneStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePublicZoneStatusResponse>);
        }
        
        /// <summary>
        /// 修改解析器转发规则
        ///
        /// 修改解析器转发规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateResolverRuleResponse> UpdateResolverRuleAsync(UpdateResolverRuleRequest updateResolverRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resolverrule_id", updateResolverRuleRequest.ResolverruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules/{resolverrule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResolverRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateResolverRuleResponse>(response);
        }

        public AsyncInvoker<UpdateResolverRuleResponse> UpdateResolverRuleAsyncInvoker(UpdateResolverRuleRequest updateResolverRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resolverrule_id", updateResolverRuleRequest.ResolverruleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules/{resolverrule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResolverRuleRequest);
            return new AsyncInvoker<UpdateResolverRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateResolverRuleResponse>);
        }
        
        /// <summary>
        /// 关闭DNSSEC
        ///
        /// 关闭公网域名的DNSSEC。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableDnssecConfigResponse> DisableDnssecConfigAsync(DisableDnssecConfigRequest disableDnssecConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", disableDnssecConfigRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/disable-dnssec", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableDnssecConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisableDnssecConfigResponse>(response);
        }

        public AsyncInvoker<DisableDnssecConfigResponse> DisableDnssecConfigAsyncInvoker(DisableDnssecConfigRequest disableDnssecConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", disableDnssecConfigRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/disable-dnssec", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableDnssecConfigRequest);
            return new AsyncInvoker<DisableDnssecConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<DisableDnssecConfigResponse>);
        }
        
        /// <summary>
        /// 开启DNSSEC
        ///
        /// 开启公网域名的DNSSEC。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableDnssecConfigResponse> EnableDnssecConfigAsync(EnableDnssecConfigRequest enableDnssecConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", enableDnssecConfigRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/enable-dnssec", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDnssecConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EnableDnssecConfigResponse>(response);
        }

        public AsyncInvoker<EnableDnssecConfigResponse> EnableDnssecConfigAsyncInvoker(EnableDnssecConfigRequest enableDnssecConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", enableDnssecConfigRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/enable-dnssec", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDnssecConfigRequest);
            return new AsyncInvoker<EnableDnssecConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableDnssecConfigResponse>);
        }
        
        /// <summary>
        /// 查询DNSSEC
        ///
        /// 查询公网域名的DNSSEC。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDnssecConfigResponse> ShowDnssecConfigAsync(ShowDnssecConfigRequest showDnssecConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showDnssecConfigRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/dnssec", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDnssecConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDnssecConfigResponse>(response);
        }

        public AsyncInvoker<ShowDnssecConfigResponse> ShowDnssecConfigAsyncInvoker(ShowDnssecConfigRequest showDnssecConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showDnssecConfigRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/dnssec", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDnssecConfigRequest);
            return new AsyncInvoker<ShowDnssecConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDnssecConfigResponse>);
        }
        
        /// <summary>
        /// 设置弹性公网IP的反向解析记录
        ///
        /// 设置弹性公网IP的反向解析记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateEipRecordSetResponse> CreateEipRecordSetAsync(CreateEipRecordSetRequest createEipRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("region", createEipRecordSetRequest.Region.ToString());
            urlParam.Add("floatingip_id", createEipRecordSetRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEipRecordSetRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<CreateEipRecordSetResponse>(response);
        }

        public AsyncInvoker<CreateEipRecordSetResponse> CreateEipRecordSetAsyncInvoker(CreateEipRecordSetRequest createEipRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("region", createEipRecordSetRequest.Region.ToString());
            urlParam.Add("floatingip_id", createEipRecordSetRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEipRecordSetRequest);
            return new AsyncInvoker<CreateEipRecordSetResponse>(this, "PATCH", request, JsonUtils.DeSerialize<CreateEipRecordSetResponse>);
        }
        
        /// <summary>
        /// 创建记录集
        ///
        /// 记录集是指一组资源记录的集合，这些资源记录属于同一域名，用于定义域名支持的解析类型以及解析值。您的域名创建完成后，可以通过调用此接口为域名添加不同类型的记录集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRecordSetResponse> CreateRecordSetAsync(CreateRecordSetRequest createRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", createRecordSetRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRecordSetResponse>(response);
        }

        public AsyncInvoker<CreateRecordSetResponse> CreateRecordSetAsyncInvoker(CreateRecordSetRequest createRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", createRecordSetRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetRequest);
            return new AsyncInvoker<CreateRecordSetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRecordSetResponse>);
        }
        
        /// <summary>
        /// 删除记录集
        ///
        /// 当您的记录集不再使用时，您可以通过调用此接口将其删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRecordSetResponse> DeleteRecordSetAsync(DeleteRecordSetRequest deleteRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", deleteRecordSetRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", deleteRecordSetRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordSetRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteRecordSetResponse>(response);
        }

        public AsyncInvoker<DeleteRecordSetResponse> DeleteRecordSetAsyncInvoker(DeleteRecordSetRequest deleteRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", deleteRecordSetRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", deleteRecordSetRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordSetRequest);
            return new AsyncInvoker<DeleteRecordSetResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteRecordSetResponse>);
        }
        
        /// <summary>
        /// 查询弹性公网IP的反向解析记录列表
        ///
        /// 查询弹性公网IP的反向解析记录列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPtrRecordsResponse> ListPtrRecordsAsync(ListPtrRecordsRequest listPtrRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPtrRecordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPtrRecordsResponse>(response);
        }

        public AsyncInvoker<ListPtrRecordsResponse> ListPtrRecordsAsyncInvoker(ListPtrRecordsRequest listPtrRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPtrRecordsRequest);
            return new AsyncInvoker<ListPtrRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPtrRecordsResponse>);
        }
        
        /// <summary>
        /// 查询租户记录集列表
        ///
        /// 当您的记录集创建成功后，您可以通过调用此接口查询指定域名下的所有记录集信息，包括名称、ID、状态、所属域名、解析记录值、标签、TTL、创建时间、修改时间、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecordSetsResponse> ListRecordSetsAsync(ListRecordSetsRequest listRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRecordSetsResponse>(response);
        }

        public AsyncInvoker<ListRecordSetsResponse> ListRecordSetsAsyncInvoker(ListRecordSetsRequest listRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsRequest);
            return new AsyncInvoker<ListRecordSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordSetsResponse>);
        }
        
        /// <summary>
        /// 查询域名下的记录集列表
        ///
        /// 当您的记录集创建成功后，您可以通过调用此接口查询指定域名下的所有记录集信息，包括名称、ID、状态、所属域名、解析记录值、标签、TTL、创建时间、修改时间、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecordSetsByZoneResponse> ListRecordSetsByZoneAsync(ListRecordSetsByZoneRequest listRecordSetsByZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", listRecordSetsByZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsByZoneRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRecordSetsByZoneResponse>(response);
        }

        public AsyncInvoker<ListRecordSetsByZoneResponse> ListRecordSetsByZoneAsyncInvoker(ListRecordSetsByZoneRequest listRecordSetsByZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", listRecordSetsByZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsByZoneRequest);
            return new AsyncInvoker<ListRecordSetsByZoneResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordSetsByZoneResponse>);
        }
        
        /// <summary>
        /// 将弹性公网IP的反向解析记录恢复为默认值
        ///
        /// 将弹性公网IP的反向解析记录恢复为默认值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestorePtrRecordResponse> RestorePtrRecordAsync(RestorePtrRecordRequest restorePtrRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("region", restorePtrRecordRequest.Region.ToString());
            urlParam.Add("floatingip_id", restorePtrRecordRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restorePtrRecordRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<RestorePtrRecordResponse>(response);
        }

        public AsyncInvoker<RestorePtrRecordResponse> RestorePtrRecordAsyncInvoker(RestorePtrRecordRequest restorePtrRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("region", restorePtrRecordRequest.Region.ToString());
            urlParam.Add("floatingip_id", restorePtrRecordRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restorePtrRecordRequest);
            return new AsyncInvoker<RestorePtrRecordResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<RestorePtrRecordResponse>);
        }
        
        /// <summary>
        /// 查询弹性公网IP的反向解析记录
        ///
        /// 查询弹性公网IP的反向解析记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPtrRecordSetResponse> ShowPtrRecordSetAsync(ShowPtrRecordSetRequest showPtrRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("region", showPtrRecordSetRequest.Region.ToString());
            urlParam.Add("floatingip_id", showPtrRecordSetRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPtrRecordSetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPtrRecordSetResponse>(response);
        }

        public AsyncInvoker<ShowPtrRecordSetResponse> ShowPtrRecordSetAsyncInvoker(ShowPtrRecordSetRequest showPtrRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("region", showPtrRecordSetRequest.Region.ToString());
            urlParam.Add("floatingip_id", showPtrRecordSetRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPtrRecordSetRequest);
            return new AsyncInvoker<ShowPtrRecordSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPtrRecordSetResponse>);
        }
        
        /// <summary>
        /// 查询记录集
        ///
        /// 当您的记录集创建成功后，您可以通过调用此接口查询指定域名下的所有记录集信息，包括名称、ID、状态、所属域名、解析记录值、标签、TTL、创建时间、修改时间、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecordSetResponse> ShowRecordSetAsync(ShowRecordSetRequest showRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showRecordSetRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", showRecordSetRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordSetResponse>(response);
        }

        public AsyncInvoker<ShowRecordSetResponse> ShowRecordSetAsyncInvoker(ShowRecordSetRequest showRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showRecordSetRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", showRecordSetRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetRequest);
            return new AsyncInvoker<ShowRecordSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordSetResponse>);
        }
        
        /// <summary>
        /// 修改弹性公网IP的反向解析记录
        ///
        /// 修改弹性公网IP的反向解析记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePtrRecordResponse> UpdatePtrRecordAsync(UpdatePtrRecordRequest updatePtrRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("region", updatePtrRecordRequest.Region.ToString());
            urlParam.Add("floatingip_id", updatePtrRecordRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePtrRecordRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpdatePtrRecordResponse>(response);
        }

        public AsyncInvoker<UpdatePtrRecordResponse> UpdatePtrRecordAsyncInvoker(UpdatePtrRecordRequest updatePtrRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("region", updatePtrRecordRequest.Region.ToString());
            urlParam.Add("floatingip_id", updatePtrRecordRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePtrRecordRequest);
            return new AsyncInvoker<UpdatePtrRecordResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdatePtrRecordResponse>);
        }
        
        /// <summary>
        /// 修改记录集
        ///
        /// 当您的记录集创建成功后，您可以通过调用此接口修改记录集的信息，包括域名、类型、记录值、TTL、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRecordSetResponse> UpdateRecordSetAsync(UpdateRecordSetRequest updateRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updateRecordSetRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", updateRecordSetRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecordSetRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRecordSetResponse>(response);
        }

        public AsyncInvoker<UpdateRecordSetResponse> UpdateRecordSetAsyncInvoker(UpdateRecordSetRequest updateRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updateRecordSetRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", updateRecordSetRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecordSetRequest);
            return new AsyncInvoker<UpdateRecordSetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRecordSetResponse>);
        }
        
        /// <summary>
        /// 创建弹性公网IP的反向解析记录
        ///
        /// 创建弹性公网IP的反向解析记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePtrResponse> CreatePtrAsync(CreatePtrRequest createPtrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/ptrs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPtrRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePtrResponse>(response);
        }

        public AsyncInvoker<CreatePtrResponse> CreatePtrAsyncInvoker(CreatePtrRequest createPtrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/ptrs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPtrRequest);
            return new AsyncInvoker<CreatePtrResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePtrResponse>);
        }
        
        /// <summary>
        /// 创建记录集
        ///
        /// 记录集是指一组资源记录的集合，这些资源记录属于同一域名，用于定义域名支持的解析类型以及解析值。您的域名创建完成后，可以通过调用此接口为域名添加不同类型的记录集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRecordSetWithLineResponse> CreateRecordSetWithLineAsync(CreateRecordSetWithLineRequest createRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", createRecordSetWithLineRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetWithLineRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRecordSetWithLineResponse>(response);
        }

        public AsyncInvoker<CreateRecordSetWithLineResponse> CreateRecordSetWithLineAsyncInvoker(CreateRecordSetWithLineRequest createRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", createRecordSetWithLineRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetWithLineRequest);
            return new AsyncInvoker<CreateRecordSetWithLineResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRecordSetWithLineResponse>);
        }
        
        /// <summary>
        /// 将弹性公网IP的反向解析记录恢复为默认值
        ///
        /// 将弹性公网IP的反向解析记录恢复为默认值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePtrResponse> DeletePtrAsync(DeletePtrRequest deletePtrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ptr_id", deletePtrRequest.PtrId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/ptrs/{ptr_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePtrRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePtrResponse>(response);
        }

        public AsyncInvoker<DeletePtrResponse> DeletePtrAsyncInvoker(DeletePtrRequest deletePtrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ptr_id", deletePtrRequest.PtrId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/ptrs/{ptr_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePtrRequest);
            return new AsyncInvoker<DeletePtrResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePtrResponse>);
        }
        
        /// <summary>
        /// 删除记录集
        ///
        /// 当您的记录集不再使用时，您可以通过调用此接口将其删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRecordSetsResponse> DeleteRecordSetsAsync(DeleteRecordSetsRequest deleteRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", deleteRecordSetsRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", deleteRecordSetsRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordSetsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteRecordSetsResponse>(response);
        }

        public AsyncInvoker<DeleteRecordSetsResponse> DeleteRecordSetsAsyncInvoker(DeleteRecordSetsRequest deleteRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", deleteRecordSetsRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", deleteRecordSetsRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordSetsRequest);
            return new AsyncInvoker<DeleteRecordSetsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteRecordSetsResponse>);
        }
        
        /// <summary>
        /// 查询弹性公网IP的反向解析记录列表
        ///
        /// 查询弹性公网IP的反向解析记录列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPtrsResponse> ListPtrsAsync(ListPtrsRequest listPtrsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/ptrs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPtrsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPtrsResponse>(response);
        }

        public AsyncInvoker<ListPtrsResponse> ListPtrsAsyncInvoker(ListPtrsRequest listPtrsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/ptrs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPtrsRequest);
            return new AsyncInvoker<ListPtrsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPtrsResponse>);
        }
        
        /// <summary>
        /// 查询公网域名的线路列表
        ///
        /// 公网域名支持设置线路解析，当您的公网域名创建完成并添加记录集时，可通过调用此接口查询公网域名的所有解析线路。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPublicZoneLinesResponse> ListPublicZoneLinesAsync(ListPublicZoneLinesRequest listPublicZoneLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", listPublicZoneLinesRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicZoneLinesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPublicZoneLinesResponse>(response);
        }

        public AsyncInvoker<ListPublicZoneLinesResponse> ListPublicZoneLinesAsyncInvoker(ListPublicZoneLinesRequest listPublicZoneLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", listPublicZoneLinesRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicZoneLinesRequest);
            return new AsyncInvoker<ListPublicZoneLinesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublicZoneLinesResponse>);
        }
        
        /// <summary>
        /// 查询租户记录集列表
        ///
        /// 当您的记录集创建成功后，您可以通过调用此接口查询单个记录集信息，包括名称、ID、状态、所属域名、解析记录值、标签、TTL、创建时间、修改时间、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecordSetsWithLineResponse> ListRecordSetsWithLineAsync(ListRecordSetsWithLineRequest listRecordSetsWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsWithLineRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRecordSetsWithLineResponse>(response);
        }

        public AsyncInvoker<ListRecordSetsWithLineResponse> ListRecordSetsWithLineAsyncInvoker(ListRecordSetsWithLineRequest listRecordSetsWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsWithLineRequest);
            return new AsyncInvoker<ListRecordSetsWithLineResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordSetsWithLineResponse>);
        }
        
        /// <summary>
        /// 设置记录集状态
        ///
        /// 当您的内网域名创建成功后，您可以通过调用此接口设置记录集的状态，包括暂停、启用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetRecordSetsStatusResponse> SetRecordSetsStatusAsync(SetRecordSetsStatusRequest setRecordSetsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("recordset_id", setRecordSetsStatusRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets/{recordset_id}/statuses/set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRecordSetsStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SetRecordSetsStatusResponse>(response);
        }

        public AsyncInvoker<SetRecordSetsStatusResponse> SetRecordSetsStatusAsyncInvoker(SetRecordSetsStatusRequest setRecordSetsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("recordset_id", setRecordSetsStatusRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets/{recordset_id}/statuses/set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRecordSetsStatusRequest);
            return new AsyncInvoker<SetRecordSetsStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetRecordSetsStatusResponse>);
        }
        
        /// <summary>
        /// 查询弹性公网IP的反向解析记录
        ///
        /// 查询弹性公网IP的反向解析记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPtrResponse> ShowPtrAsync(ShowPtrRequest showPtrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ptr_id", showPtrRequest.PtrId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/ptrs/{ptr_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPtrRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPtrResponse>(response);
        }

        public AsyncInvoker<ShowPtrResponse> ShowPtrAsyncInvoker(ShowPtrRequest showPtrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ptr_id", showPtrRequest.PtrId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/ptrs/{ptr_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPtrRequest);
            return new AsyncInvoker<ShowPtrResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPtrResponse>);
        }
        
        /// <summary>
        /// 查询域名下的记录集列表
        ///
        /// 当您的记录集创建成功后，您可以通过调用此接口查询单个记录集信息，包括名称、ID、状态、所属域名、解析记录值、标签、TTL、创建时间、修改时间、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecordSetByZoneResponse> ShowRecordSetByZoneAsync(ShowRecordSetByZoneRequest showRecordSetByZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showRecordSetByZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetByZoneRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordSetByZoneResponse>(response);
        }

        public AsyncInvoker<ShowRecordSetByZoneResponse> ShowRecordSetByZoneAsyncInvoker(ShowRecordSetByZoneRequest showRecordSetByZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showRecordSetByZoneRequest.ZoneId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetByZoneRequest);
            return new AsyncInvoker<ShowRecordSetByZoneResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordSetByZoneResponse>);
        }
        
        /// <summary>
        /// 查询记录集
        ///
        /// 当您的记录集创建成功后，您可以通过调用此接口查询单个记录集信息，包括名称、ID、状态、所属域名、解析记录值、标签、TTL、创建时间、修改时间、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecordSetWithLineResponse> ShowRecordSetWithLineAsync(ShowRecordSetWithLineRequest showRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showRecordSetWithLineRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", showRecordSetWithLineRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetWithLineRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordSetWithLineResponse>(response);
        }

        public AsyncInvoker<ShowRecordSetWithLineResponse> ShowRecordSetWithLineAsyncInvoker(ShowRecordSetWithLineRequest showRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", showRecordSetWithLineRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", showRecordSetWithLineRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetWithLineRequest);
            return new AsyncInvoker<ShowRecordSetWithLineResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordSetWithLineResponse>);
        }
        
        /// <summary>
        /// 修改弹性公网IP的反向解析记录
        ///
        /// 修改弹性公网IP的反向解析记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePtrResponse> UpdatePtrAsync(UpdatePtrRequest updatePtrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ptr_id", updatePtrRequest.PtrId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/ptrs/{ptr_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePtrRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePtrResponse>(response);
        }

        public AsyncInvoker<UpdatePtrResponse> UpdatePtrAsyncInvoker(UpdatePtrRequest updatePtrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("ptr_id", updatePtrRequest.PtrId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/ptrs/{ptr_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePtrRequest);
            return new AsyncInvoker<UpdatePtrResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePtrResponse>);
        }
        
        /// <summary>
        /// 修改记录集
        ///
        /// 当您的记录集创建成功后，您可以通过调用此接口修改记录集的信息，包括域名、类型、记录值、TTL、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRecordSetsResponse> UpdateRecordSetsAsync(UpdateRecordSetsRequest updateRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updateRecordSetsRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", updateRecordSetsRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecordSetsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRecordSetsResponse>(response);
        }

        public AsyncInvoker<UpdateRecordSetsResponse> UpdateRecordSetsAsyncInvoker(UpdateRecordSetsRequest updateRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id", updateRecordSetsRequest.ZoneId.ToString());
            urlParam.Add("recordset_id", updateRecordSetsRequest.RecordsetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecordSetsRequest);
            return new AsyncInvoker<UpdateRecordSetsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRecordSetsResponse>);
        }
        
    }
}