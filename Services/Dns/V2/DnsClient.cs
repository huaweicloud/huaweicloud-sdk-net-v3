using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Dns.V2.Model;

namespace HuaweiCloud.SDK.Dns.V2
{
    public partial class DnsClient : Client
    {
        public static ClientBuilder<DnsClient> NewBuilder()
        {
            return new ClientBuilder<DnsClient>();
        }

        
        /// <summary>
        /// 终端节点绑定IP地址
        ///
        /// 终端节点绑定IP地址。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateEndpointIpaddressResponse AssociateEndpointIpaddress(AssociateEndpointIpaddressRequest associateEndpointIpaddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateEndpointIpaddressRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}/ipaddresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateEndpointIpaddressRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AssociateEndpointIpaddressResponse>(response);
        }

        public SyncInvoker<AssociateEndpointIpaddressResponse> AssociateEndpointIpaddressInvoker(AssociateEndpointIpaddressRequest associateEndpointIpaddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateEndpointIpaddressRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}/ipaddresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateEndpointIpaddressRequest);
            return new SyncInvoker<AssociateEndpointIpaddressResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateEndpointIpaddressResponse>);
        }
        
        /// <summary>
        /// 解析器转发规则关联VPC
        ///
        /// 解析器转发规则关联VPC。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateResolverRuleRouterResponse AssociateResolverRuleRouter(AssociateResolverRuleRouterRequest associateResolverRuleRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateResolverRuleRouterRequest.ResolverruleId, out var valueOfResolverruleId)) urlParam.Add("resolverrule_id", valueOfResolverruleId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules/{resolverrule_id}/associaterouter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateResolverRuleRouterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AssociateResolverRuleRouterResponse>(response);
        }

        public SyncInvoker<AssociateResolverRuleRouterResponse> AssociateResolverRuleRouterInvoker(AssociateResolverRuleRouterRequest associateResolverRuleRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateResolverRuleRouterRequest.ResolverruleId, out var valueOfResolverruleId)) urlParam.Add("resolverrule_id", valueOfResolverruleId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules/{resolverrule_id}/associaterouter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateResolverRuleRouterRequest);
            return new SyncInvoker<AssociateResolverRuleRouterResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateResolverRuleRouterResponse>);
        }
        
        /// <summary>
        /// 在内网域名上关联VPC
        ///
        /// 当您的内网域名创建完成后，可以通过调用此接口为内网域名关联新的VPC。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateRouterResponse AssociateRouter(AssociateRouterRequest associateRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateRouterRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/associaterouter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRouterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AssociateRouterResponse>(response);
        }

        public SyncInvoker<AssociateRouterResponse> AssociateRouterInvoker(AssociateRouterRequest associateRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateRouterRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/associaterouter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRouterRequest);
            return new SyncInvoker<AssociateRouterResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateRouterResponse>);
        }
        
        /// <summary>
        /// 为指定实例批量添加或删除标签
        ///
        /// 为指定实例批量添加或删除标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateTagResponse BatchCreateTag(BatchCreateTagRequest batchCreateTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(batchCreateTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateTagResponse>(response);
        }

        public SyncInvoker<BatchCreateTagResponse> BatchCreateTagInvoker(BatchCreateTagRequest batchCreateTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(batchCreateTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateTagRequest);
            return new SyncInvoker<BatchCreateTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateTagResponse>);
        }
        
        /// <summary>
        /// 批量删除反向解析
        ///
        /// 批量删除反向解析。本接口为原子操作，所有记录应全部删除成功或全部失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeletePtrRecordsResponse BatchDeletePtrRecords(BatchDeletePtrRecordsRequest batchDeletePtrRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/reverse/floatingips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePtrRecordsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<BatchDeletePtrRecordsResponse>(response);
        }

        public SyncInvoker<BatchDeletePtrRecordsResponse> BatchDeletePtrRecordsInvoker(BatchDeletePtrRecordsRequest batchDeletePtrRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/reverse/floatingips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePtrRecordsRequest);
            return new SyncInvoker<BatchDeletePtrRecordsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<BatchDeletePtrRecordsResponse>);
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
        public BatchDeleteRecordSetWithLineResponse BatchDeleteRecordSetWithLine(BatchDeleteRecordSetWithLineRequest batchDeleteRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteRecordSetWithLineRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRecordSetWithLineRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteRecordSetWithLineResponse>(response);
        }

        public SyncInvoker<BatchDeleteRecordSetWithLineResponse> BatchDeleteRecordSetWithLineInvoker(BatchDeleteRecordSetWithLineRequest batchDeleteRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteRecordSetWithLineRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRecordSetWithLineRequest);
            return new SyncInvoker<BatchDeleteRecordSetWithLineResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteRecordSetWithLineResponse>);
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
        public BatchDeleteRecordSetsResponse BatchDeleteRecordSets(BatchDeleteRecordSetsRequest batchDeleteRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRecordSetsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteRecordSetsResponse>(response);
        }

        public SyncInvoker<BatchDeleteRecordSetsResponse> BatchDeleteRecordSetsInvoker(BatchDeleteRecordSetsRequest batchDeleteRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRecordSetsRequest);
            return new SyncInvoker<BatchDeleteRecordSetsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteRecordSetsResponse>);
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
        public BatchDeleteZonesResponse BatchDeleteZones(BatchDeleteZonesRequest batchDeleteZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteZonesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteZonesResponse>(response);
        }

        public SyncInvoker<BatchDeleteZonesResponse> BatchDeleteZonesInvoker(BatchDeleteZonesRequest batchDeleteZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteZonesRequest);
            return new SyncInvoker<BatchDeleteZonesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteZonesResponse>);
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
        public BatchSetRecordSetsStatusResponse BatchSetRecordSetsStatus(BatchSetRecordSetsStatusRequest batchSetRecordSetsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetRecordSetsStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchSetRecordSetsStatusResponse>(response);
        }

        public SyncInvoker<BatchSetRecordSetsStatusResponse> BatchSetRecordSetsStatusInvoker(BatchSetRecordSetsStatusRequest batchSetRecordSetsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetRecordSetsStatusRequest);
            return new SyncInvoker<BatchSetRecordSetsStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchSetRecordSetsStatusResponse>);
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
        public BatchSetZonesStatusResponse BatchSetZonesStatus(BatchSetZonesStatusRequest batchSetZonesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetZonesStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchSetZonesStatusResponse>(response);
        }

        public SyncInvoker<BatchSetZonesStatusResponse> BatchSetZonesStatusInvoker(BatchSetZonesStatusRequest batchSetZonesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetZonesStatusRequest);
            return new SyncInvoker<BatchSetZonesStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchSetZonesStatusResponse>);
        }
        
        /// <summary>
        /// 批量修改记录集
        ///
        /// 批量修改记录集。属于原子性操作，请求记录集将全部完成修改，或不做任何修改。
        /// 仅公网域名支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateRecordSetWithLineResponse BatchUpdateRecordSetWithLine(BatchUpdateRecordSetWithLineRequest batchUpdateRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateRecordSetWithLineRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateRecordSetWithLineRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateRecordSetWithLineResponse>(response);
        }

        public SyncInvoker<BatchUpdateRecordSetWithLineResponse> BatchUpdateRecordSetWithLineInvoker(BatchUpdateRecordSetWithLineRequest batchUpdateRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateRecordSetWithLineRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateRecordSetWithLineRequest);
            return new SyncInvoker<BatchUpdateRecordSetWithLineResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateRecordSetWithLineResponse>);
        }
        
        /// <summary>
        /// 创建公网子域名授权
        ///
        /// 当创建子域名时提示“域名与其他租户冲突，你需要添加TXT授权校验”，通过调用当前接口生成子域名授权的TXT记录验证信息。
        /// 
        /// **[公网域名为全局资源，请选择“华北-北京四（cn-north-4）”区域调用。](tag:hws)**
        /// **[公网域名为全局资源，请选择“亚太-新加坡（ap-southeast-3）”区域调用。](tag:hws_hk)**
        /// 
        /// &gt; TXT记录验证信息生成后，请前往主域名所属的DNS服务商处添加相应的TXT类型解析记录，主机记录和记录值与验证信息保持一致。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAuthorizeTxtRecordResponse CreateAuthorizeTxtRecord(CreateAuthorizeTxtRecordRequest createAuthorizeTxtRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/authorize-txtrecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuthorizeTxtRecordRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAuthorizeTxtRecordResponse>(response);
        }

        public SyncInvoker<CreateAuthorizeTxtRecordResponse> CreateAuthorizeTxtRecordInvoker(CreateAuthorizeTxtRecordRequest createAuthorizeTxtRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/authorize-txtrecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuthorizeTxtRecordRequest);
            return new SyncInvoker<CreateAuthorizeTxtRecordResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAuthorizeTxtRecordResponse>);
        }
        
        /// <summary>
        /// 验证公网子域名授权
        ///
        /// 用户在主域名所属DNS服务商处添加TXT类型解析记录后，调用当前接口验证子域名授权状态。
        /// 
        /// **[公网域名为全局资源，请选择“华北-北京四（cn-north-4）”区域调用。](tag:hws)**
        /// **[公网域名为全局资源，请选择“亚太-新加坡（ap-southeast-3）”区域调用。](tag:hws_hk)**
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAuthorizeTxtRecordVerificationResponse CreateAuthorizeTxtRecordVerification(CreateAuthorizeTxtRecordVerificationRequest createAuthorizeTxtRecordVerificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAuthorizeTxtRecordVerificationRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/authorize-txtrecord/{id}/verify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuthorizeTxtRecordVerificationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAuthorizeTxtRecordVerificationResponse>(response);
        }

        public SyncInvoker<CreateAuthorizeTxtRecordVerificationResponse> CreateAuthorizeTxtRecordVerificationInvoker(CreateAuthorizeTxtRecordVerificationRequest createAuthorizeTxtRecordVerificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAuthorizeTxtRecordVerificationRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/authorize-txtrecord/{id}/verify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuthorizeTxtRecordVerificationRequest);
            return new SyncInvoker<CreateAuthorizeTxtRecordVerificationResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAuthorizeTxtRecordVerificationResponse>);
        }
        
        /// <summary>
        /// 创建自定义线路
        ///
        /// 创建自定义线路。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCustomLineResponse CreateCustomLine(CreateCustomLineRequest createCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCustomLineRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCustomLineResponse>(response);
        }

        public SyncInvoker<CreateCustomLineResponse> CreateCustomLineInvoker(CreateCustomLineRequest createCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCustomLineRequest);
            return new SyncInvoker<CreateCustomLineResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCustomLineResponse>);
        }
        
        /// <summary>
        /// 创建终端节点
        ///
        /// 创建终端节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateEndpointResponse CreateEndpoint(CreateEndpointRequest createEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEndpointRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateEndpointResponse>(response);
        }

        public SyncInvoker<CreateEndpointResponse> CreateEndpointInvoker(CreateEndpointRequest createEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEndpointRequest);
            return new SyncInvoker<CreateEndpointResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEndpointResponse>);
        }
        
        /// <summary>
        /// 创建线路分组
        ///
        /// 创建线路分组。该接口部分区域未上线，如需使用请提交工单申请开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateLineGroupResponse CreateLineGroup(CreateLineGroupRequest createLineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLineGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateLineGroupResponse>(response);
        }

        public SyncInvoker<CreateLineGroupResponse> CreateLineGroupInvoker(CreateLineGroupRequest createLineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLineGroupRequest);
            return new SyncInvoker<CreateLineGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLineGroupResponse>);
        }
        
        /// <summary>
        /// 创建内网域名
        ///
        /// 内网域名是指在VPC中生效的域名，内网域名创建后，用户可以将其与私网IP地址相关联，为云服务提供VPC内的内网域名解析服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePrivateZoneResponse CreatePrivateZone(CreatePrivateZoneRequest createPrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateZoneRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePrivateZoneResponse>(response);
        }

        public SyncInvoker<CreatePrivateZoneResponse> CreatePrivateZoneInvoker(CreatePrivateZoneRequest createPrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateZoneRequest);
            return new SyncInvoker<CreatePrivateZoneResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePrivateZoneResponse>);
        }
        
        /// <summary>
        /// 创建公网域名
        ///
        /// 您在使用华为云云解析服务为自己注册的域名配置DNS解析之前，需要先将域名添加至云解析服务控制台。
        /// 
        /// **[公网域名为全局资源，请选择“华北-北京四（cn-north-4）”区域调用。](tag:hws)**
        /// **[公网域名为全局资源，请选择“亚太-新加坡（ap-southeast-3）”区域调用。](tag:hws_hk)**
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePublicZoneResponse CreatePublicZone(CreatePublicZoneRequest createPublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPublicZoneRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePublicZoneResponse>(response);
        }

        public SyncInvoker<CreatePublicZoneResponse> CreatePublicZoneInvoker(CreatePublicZoneRequest createPublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPublicZoneRequest);
            return new SyncInvoker<CreatePublicZoneResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePublicZoneResponse>);
        }
        
        /// <summary>
        /// 批量线路创建记录集
        ///
        /// 批量线路创建记录集。属于原子性操作，如果存在一个参数校验不通过，则创建失败。仅公网域名支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRecordSetWithBatchLinesResponse CreateRecordSetWithBatchLines(CreateRecordSetWithBatchLinesRequest createRecordSetWithBatchLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRecordSetWithBatchLinesRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/batch/lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetWithBatchLinesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRecordSetWithBatchLinesResponse>(response);
        }

        public SyncInvoker<CreateRecordSetWithBatchLinesResponse> CreateRecordSetWithBatchLinesInvoker(CreateRecordSetWithBatchLinesRequest createRecordSetWithBatchLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRecordSetWithBatchLinesRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/batch/lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetWithBatchLinesRequest);
            return new SyncInvoker<CreateRecordSetWithBatchLinesResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRecordSetWithBatchLinesResponse>);
        }
        
        /// <summary>
        /// 创建解析器转发规则
        ///
        /// 创建解析器转发规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateResolverRuleResponse CreateResolverRule(CreateResolverRuleRequest createResolverRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResolverRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateResolverRuleResponse>(response);
        }

        public SyncInvoker<CreateResolverRuleResponse> CreateResolverRuleInvoker(CreateResolverRuleRequest createResolverRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResolverRuleRequest);
            return new SyncInvoker<CreateResolverRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateResolverRuleResponse>);
        }
        
        /// <summary>
        /// 为指定实例添加标签
        ///
        /// 为指定实例添加标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTagResponse CreateTag(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTagResponse>(response);
        }

        public SyncInvoker<CreateTagResponse> CreateTagInvoker(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            return new SyncInvoker<CreateTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagResponse>);
        }
        
        /// <summary>
        /// 删除自定义线路
        ///
        /// 删除自定义线路。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCustomLineResponse DeleteCustomLine(DeleteCustomLineRequest deleteCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCustomLineRequest.LineId, out var valueOfLineId)) urlParam.Add("line_id", valueOfLineId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines/{line_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomLineRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteCustomLineResponse>(response);
        }

        public SyncInvoker<DeleteCustomLineResponse> DeleteCustomLineInvoker(DeleteCustomLineRequest deleteCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCustomLineRequest.LineId, out var valueOfLineId)) urlParam.Add("line_id", valueOfLineId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines/{line_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomLineRequest);
            return new SyncInvoker<DeleteCustomLineResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteCustomLineResponse>);
        }
        
        /// <summary>
        /// 删除终端节点
        ///
        /// 删除终端节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest deleteEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteEndpointRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteEndpointResponse>(response);
        }

        public SyncInvoker<DeleteEndpointResponse> DeleteEndpointInvoker(DeleteEndpointRequest deleteEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteEndpointRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointRequest);
            return new SyncInvoker<DeleteEndpointResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteEndpointResponse>);
        }
        
        /// <summary>
        /// 删除线路分组
        ///
        /// 删除线路分组。该接口部分区域未上线，如需使用请提交工单申请开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLineGroupResponse DeleteLineGroup(DeleteLineGroupRequest deleteLineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLineGroupRequest.LinegroupId, out var valueOfLinegroupId)) urlParam.Add("linegroup_id", valueOfLinegroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLineGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteLineGroupResponse>(response);
        }

        public SyncInvoker<DeleteLineGroupResponse> DeleteLineGroupInvoker(DeleteLineGroupRequest deleteLineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLineGroupRequest.LinegroupId, out var valueOfLinegroupId)) urlParam.Add("linegroup_id", valueOfLinegroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLineGroupRequest);
            return new SyncInvoker<DeleteLineGroupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteLineGroupResponse>);
        }
        
        /// <summary>
        /// 删除内网域名
        ///
        /// 当您的内网域名不再使用时，您可以通过调用此接口将其删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePrivateZoneResponse DeletePrivateZone(DeletePrivateZoneRequest deletePrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePrivateZoneRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateZoneRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePrivateZoneResponse>(response);
        }

        public SyncInvoker<DeletePrivateZoneResponse> DeletePrivateZoneInvoker(DeletePrivateZoneRequest deletePrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePrivateZoneRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateZoneRequest);
            return new SyncInvoker<DeletePrivateZoneResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePrivateZoneResponse>);
        }
        
        /// <summary>
        /// 删除公网域名
        ///
        /// 当您的公网域名不再使用时，您可以通过调用此接口将其删除。
        /// 
        /// **[公网域名为全局资源，请选择“华北-北京四（cn-north-4）”区域调用。](tag:hws)**
        /// **[公网域名为全局资源，请选择“亚太-新加坡（ap-southeast-3）”区域调用。](tag:hws_hk)**
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePublicZoneResponse DeletePublicZone(DeletePublicZoneRequest deletePublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePublicZoneRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicZoneRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePublicZoneResponse>(response);
        }

        public SyncInvoker<DeletePublicZoneResponse> DeletePublicZoneInvoker(DeletePublicZoneRequest deletePublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePublicZoneRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicZoneRequest);
            return new SyncInvoker<DeletePublicZoneResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePublicZoneResponse>);
        }
        
        /// <summary>
        /// 删除解析器转发规则
        ///
        /// 删除解析器转发规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteResolverRuleResponse DeleteResolverRule(DeleteResolverRuleRequest deleteResolverRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteResolverRuleRequest.ResolverruleId, out var valueOfResolverruleId)) urlParam.Add("resolverrule_id", valueOfResolverruleId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules/{resolverrule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResolverRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteResolverRuleResponse>(response);
        }

        public SyncInvoker<DeleteResolverRuleResponse> DeleteResolverRuleInvoker(DeleteResolverRuleRequest deleteResolverRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteResolverRuleRequest.ResolverruleId, out var valueOfResolverruleId)) urlParam.Add("resolverrule_id", valueOfResolverruleId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules/{resolverrule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResolverRuleRequest);
            return new SyncInvoker<DeleteResolverRuleResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteResolverRuleResponse>);
        }
        
        /// <summary>
        /// 删除资源标签
        ///
        /// 删除资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTagResponse DeleteTag(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTagResponse>(response);
        }

        public SyncInvoker<DeleteTagResponse> DeleteTagInvoker(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            return new SyncInvoker<DeleteTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTagResponse>);
        }
        
        /// <summary>
        /// 终端节点解绑IP地址
        ///
        /// 终端节点解绑IP地址。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateEndpointIpaddressResponse DisassociateEndpointIpaddress(DisassociateEndpointIpaddressRequest disassociateEndpointIpaddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateEndpointIpaddressRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            if (StringUtils.TryConvertToNonEmptyString(disassociateEndpointIpaddressRequest.IpaddressId, out var valueOfIpaddressId)) urlParam.Add("ipaddress_id", valueOfIpaddressId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}/ipaddresses/{ipaddress_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateEndpointIpaddressRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DisassociateEndpointIpaddressResponse>(response);
        }

        public SyncInvoker<DisassociateEndpointIpaddressResponse> DisassociateEndpointIpaddressInvoker(DisassociateEndpointIpaddressRequest disassociateEndpointIpaddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateEndpointIpaddressRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            if (StringUtils.TryConvertToNonEmptyString(disassociateEndpointIpaddressRequest.IpaddressId, out var valueOfIpaddressId)) urlParam.Add("ipaddress_id", valueOfIpaddressId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}/ipaddresses/{ipaddress_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateEndpointIpaddressRequest);
            return new SyncInvoker<DisassociateEndpointIpaddressResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DisassociateEndpointIpaddressResponse>);
        }
        
        /// <summary>
        /// 解析器转发规则解关联VPC
        ///
        /// 解析器转发规则解关联VPC。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateResolverRuleRouterResponse DisassociateResolverRuleRouter(DisassociateResolverRuleRouterRequest disassociateResolverRuleRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateResolverRuleRouterRequest.ResolverruleId, out var valueOfResolverruleId)) urlParam.Add("resolverrule_id", valueOfResolverruleId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules/{resolverrule_id}/disassociaterouter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateResolverRuleRouterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisassociateResolverRuleRouterResponse>(response);
        }

        public SyncInvoker<DisassociateResolverRuleRouterResponse> DisassociateResolverRuleRouterInvoker(DisassociateResolverRuleRouterRequest disassociateResolverRuleRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateResolverRuleRouterRequest.ResolverruleId, out var valueOfResolverruleId)) urlParam.Add("resolverrule_id", valueOfResolverruleId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules/{resolverrule_id}/disassociaterouter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateResolverRuleRouterRequest);
            return new SyncInvoker<DisassociateResolverRuleRouterResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateResolverRuleRouterResponse>);
        }
        
        /// <summary>
        /// 在内网域名上解关联VPC
        ///
        /// 当您的内网域名创建完成后，可以通过调用此接口为内网域名解除已关联的VPC。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateRouterResponse DisassociateRouter(DisassociateRouterRequest disassociateRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateRouterRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/disassociaterouter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateRouterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisassociateRouterResponse>(response);
        }

        public SyncInvoker<DisassociateRouterResponse> DisassociateRouterInvoker(DisassociateRouterRequest disassociateRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateRouterRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/disassociaterouter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateRouterRequest);
            return new SyncInvoker<DisassociateRouterResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateRouterResponse>);
        }
        
        /// <summary>
        /// 查询API版本信息列表
        ///
        /// 查询云解析服务支持的所有API版本信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListApiVersionsResponse ListApiVersions(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }

        public SyncInvoker<ListApiVersionsResponse> ListApiVersionsInvoker(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            return new SyncInvoker<ListApiVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionsResponse>);
        }
        
        /// <summary>
        /// 查询自定义线路
        ///
        /// 查询自定义线路。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCustomLineResponse ListCustomLine(ListCustomLineRequest listCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomLineRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCustomLineResponse>(response);
        }

        public SyncInvoker<ListCustomLineResponse> ListCustomLineInvoker(ListCustomLineRequest listCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomLineRequest);
            return new SyncInvoker<ListCustomLineResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCustomLineResponse>);
        }
        
        /// <summary>
        /// 查询IP地址列表
        ///
        /// 查询终端节点下的IP地址列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEndpointIpaddressesResponse ListEndpointIpaddresses(ListEndpointIpaddressesRequest listEndpointIpaddressesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEndpointIpaddressesRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}/ipaddresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointIpaddressesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEndpointIpaddressesResponse>(response);
        }

        public SyncInvoker<ListEndpointIpaddressesResponse> ListEndpointIpaddressesInvoker(ListEndpointIpaddressesRequest listEndpointIpaddressesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEndpointIpaddressesRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}/ipaddresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointIpaddressesRequest);
            return new SyncInvoker<ListEndpointIpaddressesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEndpointIpaddressesResponse>);
        }
        
        /// <summary>
        /// 查询终端节点VPC列表
        ///
        /// 查询终端节点VPC列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEndpointVpcsResponse ListEndpointVpcs(ListEndpointVpcsRequest listEndpointVpcsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/vpcs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointVpcsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEndpointVpcsResponse>(response);
        }

        public SyncInvoker<ListEndpointVpcsResponse> ListEndpointVpcsInvoker(ListEndpointVpcsRequest listEndpointVpcsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/vpcs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointVpcsRequest);
            return new SyncInvoker<ListEndpointVpcsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEndpointVpcsResponse>);
        }
        
        /// <summary>
        /// 查询终端节点列表
        ///
        /// 查询终端节点列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEndpointsResponse ListEndpoints(ListEndpointsRequest listEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEndpointsResponse>(response);
        }

        public SyncInvoker<ListEndpointsResponse> ListEndpointsInvoker(ListEndpointsRequest listEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointsRequest);
            return new SyncInvoker<ListEndpointsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEndpointsResponse>);
        }
        
        /// <summary>
        /// 查询线路分组列表
        ///
        /// 查询线路分组列表。该接口部分区域未上线，如需使用请提交工单申请开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLineGroupsResponse ListLineGroups(ListLineGroupsRequest listLineGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLineGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLineGroupsResponse>(response);
        }

        public SyncInvoker<ListLineGroupsResponse> ListLineGroupsInvoker(ListLineGroupsRequest listLineGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLineGroupsRequest);
            return new SyncInvoker<ListLineGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLineGroupsResponse>);
        }
        
        /// <summary>
        /// 查询名称服务器列表
        ///
        /// 查询名称服务器列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNameServersResponse ListNameServers(ListNameServersRequest listNameServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/nameservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNameServersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNameServersResponse>(response);
        }

        public SyncInvoker<ListNameServersResponse> ListNameServersInvoker(ListNameServersRequest listNameServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/nameservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNameServersRequest);
            return new SyncInvoker<ListNameServersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNameServersResponse>);
        }
        
        /// <summary>
        /// 查询内网域名列表
        ///
        /// 当您的内网域名创建成功后，您可以通过调用此接口查询单个内网域名信息，包括域名、ID、状态、记录集个数、企业项目、标签、TTL、创建时间、修改时间、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPrivateZonesResponse ListPrivateZones(ListPrivateZonesRequest listPrivateZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateZonesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPrivateZonesResponse>(response);
        }

        public SyncInvoker<ListPrivateZonesResponse> ListPrivateZonesInvoker(ListPrivateZonesRequest listPrivateZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateZonesRequest);
            return new SyncInvoker<ListPrivateZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPrivateZonesResponse>);
        }
        
        /// <summary>
        /// 查询公网域名列表
        ///
        /// 当您的公网域名创建成功后，您可以通过调用此接口查询所有公网域名信息，包括域名、ID、状态、记录集个数、企业项目、标签、TTL、创建时间、修改时间、描述等。
        /// 
        /// **[公网域名为全局资源，请选择“华北-北京四（cn-north-4）”区域调用。](tag:hws)**
        /// **[公网域名为全局资源，请选择“亚太-新加坡（ap-southeast-3）”区域调用。](tag:hws_hk)**
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPublicZonesResponse ListPublicZones(ListPublicZonesRequest listPublicZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicZonesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPublicZonesResponse>(response);
        }

        public SyncInvoker<ListPublicZonesResponse> ListPublicZonesInvoker(ListPublicZonesRequest listPublicZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicZonesRequest);
            return new SyncInvoker<ListPublicZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublicZonesResponse>);
        }
        
        /// <summary>
        /// 查询解析器转发规则列表
        ///
        /// 查询解析器转发规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResolverRulesResponse ListResolverRules(ListResolverRulesRequest listResolverRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResolverRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListResolverRulesResponse>(response);
        }

        public SyncInvoker<ListResolverRulesResponse> ListResolverRulesInvoker(ListResolverRulesRequest listResolverRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResolverRulesRequest);
            return new SyncInvoker<ListResolverRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResolverRulesResponse>);
        }
        
        /// <summary>
        /// 使用标签查询资源实例
        ///
        /// 使用标签查询资源实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagResponse ListTag(ListTagRequest listTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListTagResponse>(response);
        }

        public SyncInvoker<ListTagResponse> ListTagInvoker(ListTagRequest listTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagRequest);
            return new SyncInvoker<ListTagResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTagResponse>);
        }
        
        /// <summary>
        /// 查询指定实例类型的所有标签集合
        ///
        /// 查询指定实例类型的所有标签集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagsResponse ListTags(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTagsResponse>(response);
        }

        public SyncInvoker<ListTagsResponse> ListTagsInvoker(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            return new SyncInvoker<ListTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagsResponse>);
        }
        
        /// <summary>
        /// 设置内网域名的子域名递归解析代理
        ///
        /// 当您的内网域名创建成功后，您可以通过调用此接口设置开启或者关闭内网域名的子域名递归解析代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetPrivateZoneProxyPatternResponse SetPrivateZoneProxyPattern(SetPrivateZoneProxyPatternRequest setPrivateZoneProxyPatternRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setPrivateZoneProxyPatternRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/actions/set-proxy-pattern", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setPrivateZoneProxyPatternRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SetPrivateZoneProxyPatternResponse>(response);
        }

        public SyncInvoker<SetPrivateZoneProxyPatternResponse> SetPrivateZoneProxyPatternInvoker(SetPrivateZoneProxyPatternRequest setPrivateZoneProxyPatternRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setPrivateZoneProxyPatternRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/actions/set-proxy-pattern", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setPrivateZoneProxyPatternRequest);
            return new SyncInvoker<SetPrivateZoneProxyPatternResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetPrivateZoneProxyPatternResponse>);
        }
        
        /// <summary>
        /// 查询指定版本号的API版本信息
        ///
        /// 查询指定版本号的云解析服务API版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowApiInfoResponse ShowApiInfo(ShowApiInfoRequest showApiInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showApiInfoRequest.Version, out var valueOfVersion)) urlParam.Add("version", valueOfVersion);
            var urlPath = HttpUtils.AddUrlPath("/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowApiInfoResponse>(response);
        }

        public SyncInvoker<ShowApiInfoResponse> ShowApiInfoInvoker(ShowApiInfoRequest showApiInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showApiInfoRequest.Version, out var valueOfVersion)) urlParam.Add("version", valueOfVersion);
            var urlPath = HttpUtils.AddUrlPath("/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiInfoRequest);
            return new SyncInvoker<ShowApiInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApiInfoResponse>);
        }
        
        /// <summary>
        /// 查询公网子域名授权
        ///
        /// 查询已生成的子域名授权TXT记录验证信息。
        /// 
        /// **[公网域名为全局资源，请选择“华北-北京四（cn-north-4）”区域调用。](tag:hws)**
        /// **[公网域名为全局资源，请选择“亚太-新加坡（ap-southeast-3）”区域调用。](tag:hws_hk)**
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAuthorizeTxtRecordResponse ShowAuthorizeTxtRecord(ShowAuthorizeTxtRecordRequest showAuthorizeTxtRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/authorize-txtrecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuthorizeTxtRecordRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAuthorizeTxtRecordResponse>(response);
        }

        public SyncInvoker<ShowAuthorizeTxtRecordResponse> ShowAuthorizeTxtRecordInvoker(ShowAuthorizeTxtRecordRequest showAuthorizeTxtRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/authorize-txtrecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuthorizeTxtRecordRequest);
            return new SyncInvoker<ShowAuthorizeTxtRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuthorizeTxtRecordResponse>);
        }
        
        /// <summary>
        /// 查询租户配额
        ///
        /// 查询租户在DNS服务下的资源配额，包括公网域名配额、内网域名配额、记录集配额、反向解析配额、自定义线路配额、线路分组配额、入站终端节点配额、出站终端节点配额、转发规则配额等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainQuotaResponse ShowDomainQuota(ShowDomainQuotaRequest showDomainQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/quotamg/dns/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainQuotaResponse>(response);
        }

        public SyncInvoker<ShowDomainQuotaResponse> ShowDomainQuotaInvoker(ShowDomainQuotaRequest showDomainQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/quotamg/dns/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainQuotaRequest);
            return new SyncInvoker<ShowDomainQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainQuotaResponse>);
        }
        
        /// <summary>
        /// 查询终端节点
        ///
        /// 查询终端节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEndpointResponse ShowEndpoint(ShowEndpointRequest showEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEndpointRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEndpointRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEndpointResponse>(response);
        }

        public SyncInvoker<ShowEndpointResponse> ShowEndpointInvoker(ShowEndpointRequest showEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEndpointRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEndpointRequest);
            return new SyncInvoker<ShowEndpointResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEndpointResponse>);
        }
        
        /// <summary>
        /// 查询线路分组
        ///
        /// 查询线路分组。该接口部分区域未上线，如需使用请提交工单申请开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLineGroupResponse ShowLineGroup(ShowLineGroupRequest showLineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLineGroupRequest.LinegroupId, out var valueOfLinegroupId)) urlParam.Add("linegroup_id", valueOfLinegroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLineGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLineGroupResponse>(response);
        }

        public SyncInvoker<ShowLineGroupResponse> ShowLineGroupInvoker(ShowLineGroupRequest showLineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLineGroupRequest.LinegroupId, out var valueOfLinegroupId)) urlParam.Add("linegroup_id", valueOfLinegroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLineGroupRequest);
            return new SyncInvoker<ShowLineGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLineGroupResponse>);
        }
        
        /// <summary>
        /// 查询内网域名
        ///
        /// 当您的内网域名创建成功后，您可以通过调用此接口查询单个内网域名信息，包括域名、ID、状态、记录集个数、企业项目、标签、TTL、创建时间、修改时间、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPrivateZoneResponse ShowPrivateZone(ShowPrivateZoneRequest showPrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPrivateZoneRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateZoneRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPrivateZoneResponse>(response);
        }

        public SyncInvoker<ShowPrivateZoneResponse> ShowPrivateZoneInvoker(ShowPrivateZoneRequest showPrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPrivateZoneRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateZoneRequest);
            return new SyncInvoker<ShowPrivateZoneResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPrivateZoneResponse>);
        }
        
        /// <summary>
        /// 查询内网域名的名称服务器
        ///
        /// 当您的内网域名创建成功后，您可以通过调用此接口查询内网域名的名称服务器信息，包括优先级、DNS服务器地址等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPrivateZoneNameServerResponse ShowPrivateZoneNameServer(ShowPrivateZoneNameServerRequest showPrivateZoneNameServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPrivateZoneNameServerRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/nameservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateZoneNameServerRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPrivateZoneNameServerResponse>(response);
        }

        public SyncInvoker<ShowPrivateZoneNameServerResponse> ShowPrivateZoneNameServerInvoker(ShowPrivateZoneNameServerRequest showPrivateZoneNameServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPrivateZoneNameServerRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/nameservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateZoneNameServerRequest);
            return new SyncInvoker<ShowPrivateZoneNameServerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPrivateZoneNameServerResponse>);
        }
        
        /// <summary>
        /// 查询公网域名
        ///
        /// 当您的公网域名创建成功后，您可以通过调用此接口查询单个公网域名信息，包括域名、ID、状态、记录集个数、企业项目、标签、TTL、创建时间、修改时间、描述等。
        /// 
        /// **[公网域名为全局资源，请选择“华北-北京四（cn-north-4）”区域调用。](tag:hws)**
        /// **[公网域名为全局资源，请选择“亚太-新加坡（ap-southeast-3）”区域调用。](tag:hws_hk)**
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPublicZoneResponse ShowPublicZone(ShowPublicZoneRequest showPublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublicZoneRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicZoneRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPublicZoneResponse>(response);
        }

        public SyncInvoker<ShowPublicZoneResponse> ShowPublicZoneInvoker(ShowPublicZoneRequest showPublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublicZoneRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicZoneRequest);
            return new SyncInvoker<ShowPublicZoneResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPublicZoneResponse>);
        }
        
        /// <summary>
        /// 查询公网域名的名称服务器
        ///
        /// 当您的公网域名创建成功后，您可以通过调用此接口查询公网域名的名称服务器信息，包括主机名、优先级等。
        /// 
        /// **[公网域名为全局资源，请选择“华北-北京四（cn-north-4）”区域调用。](tag:hws)**
        /// **[公网域名为全局资源，请选择“亚太-新加坡（ap-southeast-3）”区域调用。](tag:hws_hk)**
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPublicZoneNameServerResponse ShowPublicZoneNameServer(ShowPublicZoneNameServerRequest showPublicZoneNameServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublicZoneNameServerRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/nameservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicZoneNameServerRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPublicZoneNameServerResponse>(response);
        }

        public SyncInvoker<ShowPublicZoneNameServerResponse> ShowPublicZoneNameServerInvoker(ShowPublicZoneNameServerRequest showPublicZoneNameServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublicZoneNameServerRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/nameservers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicZoneNameServerRequest);
            return new SyncInvoker<ShowPublicZoneNameServerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPublicZoneNameServerResponse>);
        }
        
        /// <summary>
        /// 查询解析器转发规则
        ///
        /// 查询解析器转发规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResolverRuleResponse ShowResolverRule(ShowResolverRuleRequest showResolverRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResolverRuleRequest.ResolverruleId, out var valueOfResolverruleId)) urlParam.Add("resolverrule_id", valueOfResolverruleId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules/{resolverrule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResolverRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResolverRuleResponse>(response);
        }

        public SyncInvoker<ShowResolverRuleResponse> ShowResolverRuleInvoker(ShowResolverRuleRequest showResolverRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResolverRuleRequest.ResolverruleId, out var valueOfResolverruleId)) urlParam.Add("resolverrule_id", valueOfResolverruleId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules/{resolverrule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResolverRuleRequest);
            return new SyncInvoker<ShowResolverRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResolverRuleResponse>);
        }
        
        /// <summary>
        /// 查询指定实例的标签信息
        ///
        /// 查询指定实例的标签信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceTagResponse ShowResourceTag(ShowResourceTagRequest showResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(showResourceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceTagRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceTagResponse>(response);
        }

        public SyncInvoker<ShowResourceTagResponse> ShowResourceTagInvoker(ShowResourceTagRequest showResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(showResourceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceTagRequest);
            return new SyncInvoker<ShowResourceTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceTagResponse>);
        }
        
        /// <summary>
        /// 修改自定义线路
        ///
        /// 修改自定义线路。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateCustomLineResponse UpdateCustomLine(UpdateCustomLineRequest updateCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateCustomLineRequest.LineId, out var valueOfLineId)) urlParam.Add("line_id", valueOfLineId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines/{line_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCustomLineRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCustomLineResponse>(response);
        }

        public SyncInvoker<UpdateCustomLineResponse> UpdateCustomLineInvoker(UpdateCustomLineRequest updateCustomLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateCustomLineRequest.LineId, out var valueOfLineId)) urlParam.Add("line_id", valueOfLineId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/customlines/{line_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCustomLineRequest);
            return new SyncInvoker<UpdateCustomLineResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCustomLineResponse>);
        }
        
        /// <summary>
        /// 修改终端节点
        ///
        /// 修改终端节点
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateEndpointResponse UpdateEndpoint(UpdateEndpointRequest updateEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateEndpointRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEndpointRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEndpointResponse>(response);
        }

        public SyncInvoker<UpdateEndpointResponse> UpdateEndpointInvoker(UpdateEndpointRequest updateEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateEndpointRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEndpointRequest);
            return new SyncInvoker<UpdateEndpointResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEndpointResponse>);
        }
        
        /// <summary>
        /// 修改线路分组
        ///
        /// 修改线路分组。该接口部分区域未上线，如需使用请提交工单申请开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateLineGroupsResponse UpdateLineGroups(UpdateLineGroupsRequest updateLineGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLineGroupsRequest.LinegroupId, out var valueOfLinegroupId)) urlParam.Add("linegroup_id", valueOfLinegroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLineGroupsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLineGroupsResponse>(response);
        }

        public SyncInvoker<UpdateLineGroupsResponse> UpdateLineGroupsInvoker(UpdateLineGroupsRequest updateLineGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLineGroupsRequest.LinegroupId, out var valueOfLinegroupId)) urlParam.Add("linegroup_id", valueOfLinegroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLineGroupsRequest);
            return new SyncInvoker<UpdateLineGroupsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLineGroupsResponse>);
        }
        
        /// <summary>
        /// 修改内网域名
        ///
        /// 当您的内网域名创建成功后，您可以通过调用此接口修改内网域名的基本信息，包括TTL、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePrivateZoneResponse UpdatePrivateZone(UpdatePrivateZoneRequest updatePrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePrivateZoneRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateZoneRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<UpdatePrivateZoneResponse>(response);
        }

        public SyncInvoker<UpdatePrivateZoneResponse> UpdatePrivateZoneInvoker(UpdatePrivateZoneRequest updatePrivateZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePrivateZoneRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateZoneRequest);
            return new SyncInvoker<UpdatePrivateZoneResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdatePrivateZoneResponse>);
        }
        
        /// <summary>
        /// 设置内网域名状态
        ///
        /// 当您的内网域名创建成功后，您可以通过调用此接口设置内网域名的状态，包括暂停、启用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePrivateZoneStatusResponse UpdatePrivateZoneStatus(UpdatePrivateZoneStatusRequest updatePrivateZoneStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePrivateZoneStatusRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateZoneStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePrivateZoneStatusResponse>(response);
        }

        public SyncInvoker<UpdatePrivateZoneStatusResponse> UpdatePrivateZoneStatusInvoker(UpdatePrivateZoneStatusRequest updatePrivateZoneStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePrivateZoneStatusRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateZoneStatusRequest);
            return new SyncInvoker<UpdatePrivateZoneStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePrivateZoneStatusResponse>);
        }
        
        /// <summary>
        /// 修改公网域名
        ///
        /// 当您的公网域名创建成功后，您可以通过调用此接口修改公网域名的基本信息，包括TTL、描述等。
        /// 
        /// **[公网域名为全局资源，请选择“华北-北京四（cn-north-4）”区域调用。](tag:hws)**
        /// **[公网域名为全局资源，请选择“亚太-新加坡（ap-southeast-3）”区域调用。](tag:hws_hk)**
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePublicZoneResponse UpdatePublicZone(UpdatePublicZoneRequest updatePublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePublicZoneRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePublicZoneRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<UpdatePublicZoneResponse>(response);
        }

        public SyncInvoker<UpdatePublicZoneResponse> UpdatePublicZoneInvoker(UpdatePublicZoneRequest updatePublicZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePublicZoneRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePublicZoneRequest);
            return new SyncInvoker<UpdatePublicZoneResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdatePublicZoneResponse>);
        }
        
        /// <summary>
        /// 设置公网域名状态
        ///
        /// 当您的公网域名创建成功后，您可以通过调用此接口设置公网域名的状态，包括暂停、启用。
        /// 
        /// **[公网域名为全局资源，请选择“华北-北京四（cn-north-4）”区域调用。](tag:hws)**
        /// **[公网域名为全局资源，请选择“亚太-新加坡（ap-southeast-3）”区域调用。](tag:hws_hk)**
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePublicZoneStatusResponse UpdatePublicZoneStatus(UpdatePublicZoneStatusRequest updatePublicZoneStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePublicZoneStatusRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePublicZoneStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePublicZoneStatusResponse>(response);
        }

        public SyncInvoker<UpdatePublicZoneStatusResponse> UpdatePublicZoneStatusInvoker(UpdatePublicZoneStatusRequest updatePublicZoneStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePublicZoneStatusRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePublicZoneStatusRequest);
            return new SyncInvoker<UpdatePublicZoneStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePublicZoneStatusResponse>);
        }
        
        /// <summary>
        /// 修改解析器转发规则
        ///
        /// 修改解析器转发规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateResolverRuleResponse UpdateResolverRule(UpdateResolverRuleRequest updateResolverRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateResolverRuleRequest.ResolverruleId, out var valueOfResolverruleId)) urlParam.Add("resolverrule_id", valueOfResolverruleId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules/{resolverrule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResolverRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateResolverRuleResponse>(response);
        }

        public SyncInvoker<UpdateResolverRuleResponse> UpdateResolverRuleInvoker(UpdateResolverRuleRequest updateResolverRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateResolverRuleRequest.ResolverruleId, out var valueOfResolverruleId)) urlParam.Add("resolverrule_id", valueOfResolverruleId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/resolverrules/{resolverrule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResolverRuleRequest);
            return new SyncInvoker<UpdateResolverRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateResolverRuleResponse>);
        }
        
        /// <summary>
        /// 关闭DNSSEC
        ///
        /// 关闭公网域名的DNSSEC。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableDnssecConfigResponse DisableDnssecConfig(DisableDnssecConfigRequest disableDnssecConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableDnssecConfigRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/disable-dnssec", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableDnssecConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisableDnssecConfigResponse>(response);
        }

        public SyncInvoker<DisableDnssecConfigResponse> DisableDnssecConfigInvoker(DisableDnssecConfigRequest disableDnssecConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableDnssecConfigRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/disable-dnssec", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableDnssecConfigRequest);
            return new SyncInvoker<DisableDnssecConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<DisableDnssecConfigResponse>);
        }
        
        /// <summary>
        /// 开启DNSSEC
        ///
        /// 开启公网域名的DNSSEC。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableDnssecConfigResponse EnableDnssecConfig(EnableDnssecConfigRequest enableDnssecConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableDnssecConfigRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/enable-dnssec", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDnssecConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EnableDnssecConfigResponse>(response);
        }

        public SyncInvoker<EnableDnssecConfigResponse> EnableDnssecConfigInvoker(EnableDnssecConfigRequest enableDnssecConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableDnssecConfigRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/enable-dnssec", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDnssecConfigRequest);
            return new SyncInvoker<EnableDnssecConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableDnssecConfigResponse>);
        }
        
        /// <summary>
        /// 查询DNSSEC
        ///
        /// 查询公网域名的DNSSEC。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDnssecConfigResponse ShowDnssecConfig(ShowDnssecConfigRequest showDnssecConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDnssecConfigRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/dnssec", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDnssecConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDnssecConfigResponse>(response);
        }

        public SyncInvoker<ShowDnssecConfigResponse> ShowDnssecConfigInvoker(ShowDnssecConfigRequest showDnssecConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDnssecConfigRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/dnssec", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDnssecConfigRequest);
            return new SyncInvoker<ShowDnssecConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDnssecConfigResponse>);
        }
        
        /// <summary>
        /// 设置弹性公网IP的反向解析记录
        ///
        /// 设置弹性公网IP的反向解析记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateEipRecordSetResponse CreateEipRecordSet(CreateEipRecordSetRequest createEipRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createEipRecordSetRequest.Region, out var valueOfRegion)) urlParam.Add("region", valueOfRegion);
            if (StringUtils.TryConvertToNonEmptyString(createEipRecordSetRequest.FloatingipId, out var valueOfFloatingipId)) urlParam.Add("floatingip_id", valueOfFloatingipId);
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEipRecordSetRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<CreateEipRecordSetResponse>(response);
        }

        public SyncInvoker<CreateEipRecordSetResponse> CreateEipRecordSetInvoker(CreateEipRecordSetRequest createEipRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createEipRecordSetRequest.Region, out var valueOfRegion)) urlParam.Add("region", valueOfRegion);
            if (StringUtils.TryConvertToNonEmptyString(createEipRecordSetRequest.FloatingipId, out var valueOfFloatingipId)) urlParam.Add("floatingip_id", valueOfFloatingipId);
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEipRecordSetRequest);
            return new SyncInvoker<CreateEipRecordSetResponse>(this, "PATCH", request, JsonUtils.DeSerialize<CreateEipRecordSetResponse>);
        }
        
        /// <summary>
        /// 创建记录集
        ///
        /// 记录集是指一组资源记录的集合，这些资源记录属于同一域名，用于定义域名支持的解析类型以及解析值。您的域名创建完成后，可以通过调用此接口为域名添加不同类型的记录集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRecordSetResponse CreateRecordSet(CreateRecordSetRequest createRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRecordSetRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRecordSetResponse>(response);
        }

        public SyncInvoker<CreateRecordSetResponse> CreateRecordSetInvoker(CreateRecordSetRequest createRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRecordSetRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetRequest);
            return new SyncInvoker<CreateRecordSetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRecordSetResponse>);
        }
        
        /// <summary>
        /// 删除记录集
        ///
        /// 当您的记录集不再使用时，您可以通过调用此接口将其删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRecordSetResponse DeleteRecordSet(DeleteRecordSetRequest deleteRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRecordSetRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            if (StringUtils.TryConvertToNonEmptyString(deleteRecordSetRequest.RecordsetId, out var valueOfRecordsetId)) urlParam.Add("recordset_id", valueOfRecordsetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordSetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteRecordSetResponse>(response);
        }

        public SyncInvoker<DeleteRecordSetResponse> DeleteRecordSetInvoker(DeleteRecordSetRequest deleteRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRecordSetRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            if (StringUtils.TryConvertToNonEmptyString(deleteRecordSetRequest.RecordsetId, out var valueOfRecordsetId)) urlParam.Add("recordset_id", valueOfRecordsetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordSetRequest);
            return new SyncInvoker<DeleteRecordSetResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteRecordSetResponse>);
        }
        
        /// <summary>
        /// 查询弹性公网IP的反向解析记录列表
        ///
        /// 查询弹性公网IP的反向解析记录列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPtrRecordsResponse ListPtrRecords(ListPtrRecordsRequest listPtrRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPtrRecordsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPtrRecordsResponse>(response);
        }

        public SyncInvoker<ListPtrRecordsResponse> ListPtrRecordsInvoker(ListPtrRecordsRequest listPtrRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPtrRecordsRequest);
            return new SyncInvoker<ListPtrRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPtrRecordsResponse>);
        }
        
        /// <summary>
        /// 查询租户记录集列表
        ///
        /// 当您的记录集创建成功后，您可以通过调用此接口查询指定域名下的所有记录集信息，包括名称、ID、状态、所属域名、解析记录值、标签、TTL、创建时间、修改时间、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRecordSetsResponse ListRecordSets(ListRecordSetsRequest listRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRecordSetsResponse>(response);
        }

        public SyncInvoker<ListRecordSetsResponse> ListRecordSetsInvoker(ListRecordSetsRequest listRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsRequest);
            return new SyncInvoker<ListRecordSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordSetsResponse>);
        }
        
        /// <summary>
        /// 查询域名下的记录集列表
        ///
        /// 当您的记录集创建成功后，您可以通过调用此接口查询指定域名下的所有记录集信息，包括名称、ID、状态、所属域名、解析记录值、标签、TTL、创建时间、修改时间、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRecordSetsByZoneResponse ListRecordSetsByZone(ListRecordSetsByZoneRequest listRecordSetsByZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRecordSetsByZoneRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsByZoneRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRecordSetsByZoneResponse>(response);
        }

        public SyncInvoker<ListRecordSetsByZoneResponse> ListRecordSetsByZoneInvoker(ListRecordSetsByZoneRequest listRecordSetsByZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRecordSetsByZoneRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsByZoneRequest);
            return new SyncInvoker<ListRecordSetsByZoneResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordSetsByZoneResponse>);
        }
        
        /// <summary>
        /// 将弹性公网IP的反向解析记录恢复为默认值
        ///
        /// 将弹性公网IP的反向解析记录恢复为默认值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestorePtrRecordResponse RestorePtrRecord(RestorePtrRecordRequest restorePtrRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restorePtrRecordRequest.Region, out var valueOfRegion)) urlParam.Add("region", valueOfRegion);
            if (StringUtils.TryConvertToNonEmptyString(restorePtrRecordRequest.FloatingipId, out var valueOfFloatingipId)) urlParam.Add("floatingip_id", valueOfFloatingipId);
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restorePtrRecordRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<RestorePtrRecordResponse>(response);
        }

        public SyncInvoker<RestorePtrRecordResponse> RestorePtrRecordInvoker(RestorePtrRecordRequest restorePtrRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restorePtrRecordRequest.Region, out var valueOfRegion)) urlParam.Add("region", valueOfRegion);
            if (StringUtils.TryConvertToNonEmptyString(restorePtrRecordRequest.FloatingipId, out var valueOfFloatingipId)) urlParam.Add("floatingip_id", valueOfFloatingipId);
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restorePtrRecordRequest);
            return new SyncInvoker<RestorePtrRecordResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<RestorePtrRecordResponse>);
        }
        
        /// <summary>
        /// 查询弹性公网IP的反向解析记录
        ///
        /// 查询弹性公网IP的反向解析记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPtrRecordSetResponse ShowPtrRecordSet(ShowPtrRecordSetRequest showPtrRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPtrRecordSetRequest.Region, out var valueOfRegion)) urlParam.Add("region", valueOfRegion);
            if (StringUtils.TryConvertToNonEmptyString(showPtrRecordSetRequest.FloatingipId, out var valueOfFloatingipId)) urlParam.Add("floatingip_id", valueOfFloatingipId);
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPtrRecordSetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPtrRecordSetResponse>(response);
        }

        public SyncInvoker<ShowPtrRecordSetResponse> ShowPtrRecordSetInvoker(ShowPtrRecordSetRequest showPtrRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPtrRecordSetRequest.Region, out var valueOfRegion)) urlParam.Add("region", valueOfRegion);
            if (StringUtils.TryConvertToNonEmptyString(showPtrRecordSetRequest.FloatingipId, out var valueOfFloatingipId)) urlParam.Add("floatingip_id", valueOfFloatingipId);
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPtrRecordSetRequest);
            return new SyncInvoker<ShowPtrRecordSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPtrRecordSetResponse>);
        }
        
        /// <summary>
        /// 查询记录集
        ///
        /// 当您的记录集创建成功后，您可以通过调用此接口查询指定域名下的所有记录集信息，包括名称、ID、状态、所属域名、解析记录值、标签、TTL、创建时间、修改时间、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecordSetResponse ShowRecordSet(ShowRecordSetRequest showRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRecordSetRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            if (StringUtils.TryConvertToNonEmptyString(showRecordSetRequest.RecordsetId, out var valueOfRecordsetId)) urlParam.Add("recordset_id", valueOfRecordsetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordSetResponse>(response);
        }

        public SyncInvoker<ShowRecordSetResponse> ShowRecordSetInvoker(ShowRecordSetRequest showRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRecordSetRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            if (StringUtils.TryConvertToNonEmptyString(showRecordSetRequest.RecordsetId, out var valueOfRecordsetId)) urlParam.Add("recordset_id", valueOfRecordsetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetRequest);
            return new SyncInvoker<ShowRecordSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordSetResponse>);
        }
        
        /// <summary>
        /// 修改弹性公网IP的反向解析记录
        ///
        /// 修改弹性公网IP的反向解析记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePtrRecordResponse UpdatePtrRecord(UpdatePtrRecordRequest updatePtrRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePtrRecordRequest.Region, out var valueOfRegion)) urlParam.Add("region", valueOfRegion);
            if (StringUtils.TryConvertToNonEmptyString(updatePtrRecordRequest.FloatingipId, out var valueOfFloatingipId)) urlParam.Add("floatingip_id", valueOfFloatingipId);
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePtrRecordRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<UpdatePtrRecordResponse>(response);
        }

        public SyncInvoker<UpdatePtrRecordResponse> UpdatePtrRecordInvoker(UpdatePtrRecordRequest updatePtrRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePtrRecordRequest.Region, out var valueOfRegion)) urlParam.Add("region", valueOfRegion);
            if (StringUtils.TryConvertToNonEmptyString(updatePtrRecordRequest.FloatingipId, out var valueOfFloatingipId)) urlParam.Add("floatingip_id", valueOfFloatingipId);
            var urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePtrRecordRequest);
            return new SyncInvoker<UpdatePtrRecordResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdatePtrRecordResponse>);
        }
        
        /// <summary>
        /// 修改记录集
        ///
        /// 当您的记录集创建成功后，您可以通过调用此接口修改记录集的信息，包括域名、类型、记录值、TTL、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRecordSetResponse UpdateRecordSet(UpdateRecordSetRequest updateRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRecordSetRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            if (StringUtils.TryConvertToNonEmptyString(updateRecordSetRequest.RecordsetId, out var valueOfRecordsetId)) urlParam.Add("recordset_id", valueOfRecordsetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecordSetRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRecordSetResponse>(response);
        }

        public SyncInvoker<UpdateRecordSetResponse> UpdateRecordSetInvoker(UpdateRecordSetRequest updateRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRecordSetRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            if (StringUtils.TryConvertToNonEmptyString(updateRecordSetRequest.RecordsetId, out var valueOfRecordsetId)) urlParam.Add("recordset_id", valueOfRecordsetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecordSetRequest);
            return new SyncInvoker<UpdateRecordSetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRecordSetResponse>);
        }
        
        /// <summary>
        /// 创建弹性公网IP的反向解析记录
        ///
        /// 创建弹性公网IP的反向解析记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePtrResponse CreatePtr(CreatePtrRequest createPtrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/ptrs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPtrRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePtrResponse>(response);
        }

        public SyncInvoker<CreatePtrResponse> CreatePtrInvoker(CreatePtrRequest createPtrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/ptrs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPtrRequest);
            return new SyncInvoker<CreatePtrResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePtrResponse>);
        }
        
        /// <summary>
        /// 创建记录集
        ///
        /// 记录集是指一组资源记录的集合，这些资源记录属于同一域名，用于定义域名支持的解析类型以及解析值。您的域名创建完成后，可以通过调用此接口为域名添加不同类型的记录集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRecordSetWithLineResponse CreateRecordSetWithLine(CreateRecordSetWithLineRequest createRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRecordSetWithLineRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetWithLineRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRecordSetWithLineResponse>(response);
        }

        public SyncInvoker<CreateRecordSetWithLineResponse> CreateRecordSetWithLineInvoker(CreateRecordSetWithLineRequest createRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRecordSetWithLineRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetWithLineRequest);
            return new SyncInvoker<CreateRecordSetWithLineResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRecordSetWithLineResponse>);
        }
        
        /// <summary>
        /// 将弹性公网IP的反向解析记录恢复为默认值
        ///
        /// 将弹性公网IP的反向解析记录恢复为默认值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePtrResponse DeletePtr(DeletePtrRequest deletePtrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePtrRequest.PtrId, out var valueOfPtrId)) urlParam.Add("ptr_id", valueOfPtrId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/ptrs/{ptr_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePtrRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePtrResponse>(response);
        }

        public SyncInvoker<DeletePtrResponse> DeletePtrInvoker(DeletePtrRequest deletePtrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePtrRequest.PtrId, out var valueOfPtrId)) urlParam.Add("ptr_id", valueOfPtrId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/ptrs/{ptr_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePtrRequest);
            return new SyncInvoker<DeletePtrResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePtrResponse>);
        }
        
        /// <summary>
        /// 删除记录集
        ///
        /// 当您的记录集不再使用时，您可以通过调用此接口将其删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRecordSetsResponse DeleteRecordSets(DeleteRecordSetsRequest deleteRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRecordSetsRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            if (StringUtils.TryConvertToNonEmptyString(deleteRecordSetsRequest.RecordsetId, out var valueOfRecordsetId)) urlParam.Add("recordset_id", valueOfRecordsetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordSetsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteRecordSetsResponse>(response);
        }

        public SyncInvoker<DeleteRecordSetsResponse> DeleteRecordSetsInvoker(DeleteRecordSetsRequest deleteRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRecordSetsRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            if (StringUtils.TryConvertToNonEmptyString(deleteRecordSetsRequest.RecordsetId, out var valueOfRecordsetId)) urlParam.Add("recordset_id", valueOfRecordsetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordSetsRequest);
            return new SyncInvoker<DeleteRecordSetsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteRecordSetsResponse>);
        }
        
        /// <summary>
        /// 查询弹性公网IP的反向解析记录列表
        ///
        /// 查询弹性公网IP的反向解析记录列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPtrsResponse ListPtrs(ListPtrsRequest listPtrsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/ptrs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPtrsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPtrsResponse>(response);
        }

        public SyncInvoker<ListPtrsResponse> ListPtrsInvoker(ListPtrsRequest listPtrsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/ptrs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPtrsRequest);
            return new SyncInvoker<ListPtrsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPtrsResponse>);
        }
        
        /// <summary>
        /// 查询公网域名的线路列表
        ///
        /// 公网域名支持设置线路解析，当您的公网域名创建完成并添加记录集时，可通过调用此接口查询公网域名的所有解析线路。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPublicZoneLinesResponse ListPublicZoneLines(ListPublicZoneLinesRequest listPublicZoneLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPublicZoneLinesRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicZoneLinesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPublicZoneLinesResponse>(response);
        }

        public SyncInvoker<ListPublicZoneLinesResponse> ListPublicZoneLinesInvoker(ListPublicZoneLinesRequest listPublicZoneLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPublicZoneLinesRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicZoneLinesRequest);
            return new SyncInvoker<ListPublicZoneLinesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublicZoneLinesResponse>);
        }
        
        /// <summary>
        /// 查询租户记录集列表
        ///
        /// 当您的记录集创建成功后，您可以通过调用此接口查询单个记录集信息，包括名称、ID、状态、所属域名、解析记录值、标签、TTL、创建时间、修改时间、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRecordSetsWithLineResponse ListRecordSetsWithLine(ListRecordSetsWithLineRequest listRecordSetsWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsWithLineRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRecordSetsWithLineResponse>(response);
        }

        public SyncInvoker<ListRecordSetsWithLineResponse> ListRecordSetsWithLineInvoker(ListRecordSetsWithLineRequest listRecordSetsWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsWithLineRequest);
            return new SyncInvoker<ListRecordSetsWithLineResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordSetsWithLineResponse>);
        }
        
        /// <summary>
        /// 设置记录集状态
        ///
        /// 当您的内网域名创建成功后，您可以通过调用此接口设置记录集的状态，包括暂停、启用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetRecordSetsStatusResponse SetRecordSetsStatus(SetRecordSetsStatusRequest setRecordSetsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setRecordSetsStatusRequest.RecordsetId, out var valueOfRecordsetId)) urlParam.Add("recordset_id", valueOfRecordsetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets/{recordset_id}/statuses/set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRecordSetsStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SetRecordSetsStatusResponse>(response);
        }

        public SyncInvoker<SetRecordSetsStatusResponse> SetRecordSetsStatusInvoker(SetRecordSetsStatusRequest setRecordSetsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setRecordSetsStatusRequest.RecordsetId, out var valueOfRecordsetId)) urlParam.Add("recordset_id", valueOfRecordsetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets/{recordset_id}/statuses/set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRecordSetsStatusRequest);
            return new SyncInvoker<SetRecordSetsStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetRecordSetsStatusResponse>);
        }
        
        /// <summary>
        /// 查询弹性公网IP的反向解析记录
        ///
        /// 查询弹性公网IP的反向解析记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPtrResponse ShowPtr(ShowPtrRequest showPtrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPtrRequest.PtrId, out var valueOfPtrId)) urlParam.Add("ptr_id", valueOfPtrId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/ptrs/{ptr_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPtrRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPtrResponse>(response);
        }

        public SyncInvoker<ShowPtrResponse> ShowPtrInvoker(ShowPtrRequest showPtrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPtrRequest.PtrId, out var valueOfPtrId)) urlParam.Add("ptr_id", valueOfPtrId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/ptrs/{ptr_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPtrRequest);
            return new SyncInvoker<ShowPtrResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPtrResponse>);
        }
        
        /// <summary>
        /// 查询域名下的记录集列表
        ///
        /// 当您的记录集创建成功后，您可以通过调用此接口查询单个记录集信息，包括名称、ID、状态、所属域名、解析记录值、标签、TTL、创建时间、修改时间、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecordSetByZoneResponse ShowRecordSetByZone(ShowRecordSetByZoneRequest showRecordSetByZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRecordSetByZoneRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetByZoneRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordSetByZoneResponse>(response);
        }

        public SyncInvoker<ShowRecordSetByZoneResponse> ShowRecordSetByZoneInvoker(ShowRecordSetByZoneRequest showRecordSetByZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRecordSetByZoneRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetByZoneRequest);
            return new SyncInvoker<ShowRecordSetByZoneResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordSetByZoneResponse>);
        }
        
        /// <summary>
        /// 查询记录集
        ///
        /// 当您的记录集创建成功后，您可以通过调用此接口查询单个记录集信息，包括名称、ID、状态、所属域名、解析记录值、标签、TTL、创建时间、修改时间、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecordSetWithLineResponse ShowRecordSetWithLine(ShowRecordSetWithLineRequest showRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRecordSetWithLineRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            if (StringUtils.TryConvertToNonEmptyString(showRecordSetWithLineRequest.RecordsetId, out var valueOfRecordsetId)) urlParam.Add("recordset_id", valueOfRecordsetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetWithLineRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordSetWithLineResponse>(response);
        }

        public SyncInvoker<ShowRecordSetWithLineResponse> ShowRecordSetWithLineInvoker(ShowRecordSetWithLineRequest showRecordSetWithLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRecordSetWithLineRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            if (StringUtils.TryConvertToNonEmptyString(showRecordSetWithLineRequest.RecordsetId, out var valueOfRecordsetId)) urlParam.Add("recordset_id", valueOfRecordsetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetWithLineRequest);
            return new SyncInvoker<ShowRecordSetWithLineResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordSetWithLineResponse>);
        }
        
        /// <summary>
        /// 修改弹性公网IP的反向解析记录
        ///
        /// 修改弹性公网IP的反向解析记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePtrResponse UpdatePtr(UpdatePtrRequest updatePtrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePtrRequest.PtrId, out var valueOfPtrId)) urlParam.Add("ptr_id", valueOfPtrId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/ptrs/{ptr_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePtrRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePtrResponse>(response);
        }

        public SyncInvoker<UpdatePtrResponse> UpdatePtrInvoker(UpdatePtrRequest updatePtrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePtrRequest.PtrId, out var valueOfPtrId)) urlParam.Add("ptr_id", valueOfPtrId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/ptrs/{ptr_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePtrRequest);
            return new SyncInvoker<UpdatePtrResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePtrResponse>);
        }
        
        /// <summary>
        /// 修改记录集
        ///
        /// 当您的记录集创建成功后，您可以通过调用此接口修改记录集的信息，包括域名、类型、记录值、TTL、描述等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRecordSetsResponse UpdateRecordSets(UpdateRecordSetsRequest updateRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRecordSetsRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            if (StringUtils.TryConvertToNonEmptyString(updateRecordSetsRequest.RecordsetId, out var valueOfRecordsetId)) urlParam.Add("recordset_id", valueOfRecordsetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecordSetsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRecordSetsResponse>(response);
        }

        public SyncInvoker<UpdateRecordSetsResponse> UpdateRecordSetsInvoker(UpdateRecordSetsRequest updateRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRecordSetsRequest.ZoneId, out var valueOfZoneId)) urlParam.Add("zone_id", valueOfZoneId);
            if (StringUtils.TryConvertToNonEmptyString(updateRecordSetsRequest.RecordsetId, out var valueOfRecordsetId)) urlParam.Add("recordset_id", valueOfRecordsetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecordSetsRequest);
            return new SyncInvoker<UpdateRecordSetsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRecordSetsResponse>);
        }
        
    }
}