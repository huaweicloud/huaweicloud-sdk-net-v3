using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Eip.V3.Model;

namespace HuaweiCloud.SDK.Eip.V3
{
    public partial class EipClient : Client
    {
        public static ClientBuilder<EipClient> NewBuilder()
        {
            return new ClientBuilder<EipClient>();
        }

        
        /// <summary>
        /// 查询带宽列表
        ///
        /// 查询带宽列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBandwidthResponse ListBandwidth(ListBandwidthRequest listBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBandwidthResponse>(response);
        }

        public SyncInvoker<ListBandwidthResponse> ListBandwidthInvoker(ListBandwidthRequest listBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthRequest);
            return new SyncInvoker<ListBandwidthResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBandwidthResponse>);
        }
        
        /// <summary>
        /// 查看租户带宽限制
        ///
        /// 获取EIP带宽限制列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBandwidthsLimitResponse ListBandwidthsLimit(ListBandwidthsLimitRequest listBandwidthsLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/eip-bandwidth-limits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthsLimitRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBandwidthsLimitResponse>(response);
        }

        public SyncInvoker<ListBandwidthsLimitResponse> ListBandwidthsLimitInvoker(ListBandwidthsLimitRequest listBandwidthsLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/eip-bandwidth-limits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthsLimitRequest);
            return new SyncInvoker<ListBandwidthsLimitResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBandwidthsLimitResponse>);
        }
        
        /// <summary>
        /// 查询公共池列表
        ///
        /// 查询公共池列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCommonPoolsResponse ListCommonPools(ListCommonPoolsRequest listCommonPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicip-pools/common-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommonPoolsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCommonPoolsResponse>(response);
        }

        public SyncInvoker<ListCommonPoolsResponse> ListCommonPoolsInvoker(ListCommonPoolsRequest listCommonPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicip-pools/common-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommonPoolsRequest);
            return new SyncInvoker<ListCommonPoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCommonPoolsResponse>);
        }
        
        /// <summary>
        /// 查询带宽列表
        ///
        /// 查询带宽列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEipBandwidthsResponse ListEipBandwidths(ListEipBandwidthsRequest listEipBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEipBandwidthsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEipBandwidthsResponse>(response);
        }

        public SyncInvoker<ListEipBandwidthsResponse> ListEipBandwidthsInvoker(ListEipBandwidthsRequest listEipBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEipBandwidthsRequest);
            return new SyncInvoker<ListEipBandwidthsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEipBandwidthsResponse>);
        }
        
        /// <summary>
        /// 查询公共池分组列表
        ///
        /// 查询公共池分组列表，包含名称和位置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPublicBorderGroupsResponse ListPublicBorderGroups(ListPublicBorderGroupsRequest listPublicBorderGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/public-border-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicBorderGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPublicBorderGroupsResponse>(response);
        }

        public SyncInvoker<ListPublicBorderGroupsResponse> ListPublicBorderGroupsInvoker(ListPublicBorderGroupsRequest listPublicBorderGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/public-border-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicBorderGroupsRequest);
            return new SyncInvoker<ListPublicBorderGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublicBorderGroupsResponse>);
        }
        
        /// <summary>
        /// 查询公网IP池列表
        ///
        /// 全量查询公网IP池列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPublicipPoolResponse ListPublicipPool(ListPublicipPoolRequest listPublicipPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicip-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipPoolRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPublicipPoolResponse>(response);
        }

        public SyncInvoker<ListPublicipPoolResponse> ListPublicipPoolInvoker(ListPublicipPoolRequest listPublicipPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicip-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipPoolRequest);
            return new SyncInvoker<ListPublicipPoolResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublicipPoolResponse>);
        }
        
        /// <summary>
        /// 查询指定租户下的共享带宽类型列表
        ///
        /// 查询指定租户下的共享带宽类型列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListShareBandwidthTypesResponse ListShareBandwidthTypes(ListShareBandwidthTypesRequest listShareBandwidthTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/share-bandwidth-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listShareBandwidthTypesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListShareBandwidthTypesResponse>(response);
        }

        public SyncInvoker<ListShareBandwidthTypesResponse> ListShareBandwidthTypesInvoker(ListShareBandwidthTypesRequest listShareBandwidthTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/share-bandwidth-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listShareBandwidthTypesRequest);
            return new SyncInvoker<ListShareBandwidthTypesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListShareBandwidthTypesResponse>);
        }
        
        /// <summary>
        /// 查询公网IP池详情
        ///
        /// 查询公网IP池详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPublicipPoolResponse ShowPublicipPool(ShowPublicipPoolRequest showPublicipPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublicipPoolRequest.PublicipPoolId, out var valueOfPublicipPoolId)) urlParam.Add("publicip_pool_id", valueOfPublicipPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicip-pools/{publicip_pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipPoolRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPublicipPoolResponse>(response);
        }

        public SyncInvoker<ShowPublicipPoolResponse> ShowPublicipPoolInvoker(ShowPublicipPoolRequest showPublicipPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublicipPoolRequest.PublicipPoolId, out var valueOfPublicipPoolId)) urlParam.Add("publicip_pool_id", valueOfPublicipPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicip-pools/{publicip_pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipPoolRequest);
            return new SyncInvoker<ShowPublicipPoolResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPublicipPoolResponse>);
        }
        
        /// <summary>
        /// 查询GEIP与实例绑定关系的租户列表
        ///
        /// 查询GEIP与实例绑定关系的租户列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectGeipBindingsResponse ListProjectGeipBindings(ListProjectGeipBindingsRequest listProjectGeipBindingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/bindings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectGeipBindingsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProjectGeipBindingsResponse>(response);
        }

        public SyncInvoker<ListProjectGeipBindingsResponse> ListProjectGeipBindingsInvoker(ListProjectGeipBindingsRequest listProjectGeipBindingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/bindings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectGeipBindingsRequest);
            return new SyncInvoker<ListProjectGeipBindingsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectGeipBindingsResponse>);
        }
        
        /// <summary>
        /// 创建虚拟igw
        ///
        /// 创建虚拟igw
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTenantVpcIgwResponse CreateTenantVpcIgw(CreateTenantVpcIgwRequest createTenantVpcIgwRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/vpc-igws", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTenantVpcIgwRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTenantVpcIgwResponse>(response);
        }

        public SyncInvoker<CreateTenantVpcIgwResponse> CreateTenantVpcIgwInvoker(CreateTenantVpcIgwRequest createTenantVpcIgwRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/vpc-igws", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTenantVpcIgwRequest);
            return new SyncInvoker<CreateTenantVpcIgwResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTenantVpcIgwResponse>);
        }
        
        /// <summary>
        /// 删除虚拟igw
        ///
        /// 删除虚拟igw
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTenantVpcIgwResponse DeleteTenantVpcIgw(DeleteTenantVpcIgwRequest deleteTenantVpcIgwRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTenantVpcIgwRequest.VpcIgwId, out var valueOfVpcIgwId)) urlParam.Add("vpc_igw_id", valueOfVpcIgwId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/vpc-igws/{vpc_igw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTenantVpcIgwRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTenantVpcIgwResponse>(response);
        }

        public SyncInvoker<DeleteTenantVpcIgwResponse> DeleteTenantVpcIgwInvoker(DeleteTenantVpcIgwRequest deleteTenantVpcIgwRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTenantVpcIgwRequest.VpcIgwId, out var valueOfVpcIgwId)) urlParam.Add("vpc_igw_id", valueOfVpcIgwId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/vpc-igws/{vpc_igw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTenantVpcIgwRequest);
            return new SyncInvoker<DeleteTenantVpcIgwResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTenantVpcIgwResponse>);
        }
        
        /// <summary>
        /// 查询指定租户下的虚拟igw列表
        ///
        /// 查询指定租户下的虚拟igw列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTenantVpcIgwsResponse ListTenantVpcIgws(ListTenantVpcIgwsRequest listTenantVpcIgwsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/vpc-igws", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantVpcIgwsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTenantVpcIgwsResponse>(response);
        }

        public SyncInvoker<ListTenantVpcIgwsResponse> ListTenantVpcIgwsInvoker(ListTenantVpcIgwsRequest listTenantVpcIgwsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/vpc-igws", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantVpcIgwsRequest);
            return new SyncInvoker<ListTenantVpcIgwsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTenantVpcIgwsResponse>);
        }
        
        /// <summary>
        /// 查询虚拟igw详情
        ///
        /// 查询虚拟igw详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInternalVpcIgwResponse ShowInternalVpcIgw(ShowInternalVpcIgwRequest showInternalVpcIgwRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInternalVpcIgwRequest.VpcIgwId, out var valueOfVpcIgwId)) urlParam.Add("vpc_igw_id", valueOfVpcIgwId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/vpc-igws/{vpc_igw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInternalVpcIgwRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInternalVpcIgwResponse>(response);
        }

        public SyncInvoker<ShowInternalVpcIgwResponse> ShowInternalVpcIgwInvoker(ShowInternalVpcIgwRequest showInternalVpcIgwRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInternalVpcIgwRequest.VpcIgwId, out var valueOfVpcIgwId)) urlParam.Add("vpc_igw_id", valueOfVpcIgwId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/vpc-igws/{vpc_igw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInternalVpcIgwRequest);
            return new SyncInvoker<ShowInternalVpcIgwResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInternalVpcIgwResponse>);
        }
        
        /// <summary>
        /// 修改虚拟igw
        ///
        /// 修改虚拟igw
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTenantVpcIgwResponse UpdateTenantVpcIgw(UpdateTenantVpcIgwRequest updateTenantVpcIgwRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTenantVpcIgwRequest.VpcIgwId, out var valueOfVpcIgwId)) urlParam.Add("vpc_igw_id", valueOfVpcIgwId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/vpc-igws/{vpc_igw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTenantVpcIgwRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTenantVpcIgwResponse>(response);
        }

        public SyncInvoker<UpdateTenantVpcIgwResponse> UpdateTenantVpcIgwInvoker(UpdateTenantVpcIgwRequest updateTenantVpcIgwRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTenantVpcIgwRequest.VpcIgwId, out var valueOfVpcIgwId)) urlParam.Add("vpc_igw_id", valueOfVpcIgwId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/vpc-igws/{vpc_igw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTenantVpcIgwRequest);
            return new SyncInvoker<UpdateTenantVpcIgwResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTenantVpcIgwResponse>);
        }
        
        /// <summary>
        /// 绑定弹性公网IP
        ///
        /// 绑定弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociatePublicipsResponse AssociatePublicips(AssociatePublicipsRequest associatePublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associatePublicipsRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/associate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associatePublicipsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AssociatePublicipsResponse>(response);
        }

        public SyncInvoker<AssociatePublicipsResponse> AssociatePublicipsInvoker(AssociatePublicipsRequest associatePublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associatePublicipsRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/associate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associatePublicipsRequest);
            return new SyncInvoker<AssociatePublicipsResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociatePublicipsResponse>);
        }
        
        /// <summary>
        /// 共享带宽批量加入弹性公网IP
        ///
        /// 共享带宽批量加入弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AttachBatchPublicIpResponse AttachBatchPublicIp(AttachBatchPublicIpRequest attachBatchPublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/attach-share-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachBatchPublicIpRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AttachBatchPublicIpResponse>(response);
        }

        public SyncInvoker<AttachBatchPublicIpResponse> AttachBatchPublicIpInvoker(AttachBatchPublicIpRequest attachBatchPublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/attach-share-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachBatchPublicIpRequest);
            return new SyncInvoker<AttachBatchPublicIpResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachBatchPublicIpResponse>);
        }
        
        /// <summary>
        /// 共享带宽加入弹性公网IP
        ///
        /// 共享带宽加入弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AttachShareBandwidthResponse AttachShareBandwidth(AttachShareBandwidthRequest attachShareBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachShareBandwidthRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/attach-share-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachShareBandwidthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AttachShareBandwidthResponse>(response);
        }

        public SyncInvoker<AttachShareBandwidthResponse> AttachShareBandwidthInvoker(AttachShareBandwidthRequest attachShareBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachShareBandwidthRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/attach-share-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachShareBandwidthRequest);
            return new SyncInvoker<AttachShareBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachShareBandwidthResponse>);
        }
        
        /// <summary>
        /// 查询弹性公网IP可用数
        ///
        /// IP池用于查询公网可用ip个数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountEipAvailableResourcesResponse CountEipAvailableResources(CountEipAvailableResourcesRequest countEipAvailableResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/resources/available", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", countEipAvailableResourcesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CountEipAvailableResourcesResponse>(response);
        }

        public SyncInvoker<CountEipAvailableResourcesResponse> CountEipAvailableResourcesInvoker(CountEipAvailableResourcesRequest countEipAvailableResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/resources/available", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", countEipAvailableResourcesRequest);
            return new SyncInvoker<CountEipAvailableResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<CountEipAvailableResourcesResponse>);
        }
        
        /// <summary>
        /// 共享带宽批量移出弹性公网IP
        ///
        /// 共享带宽批量移出弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetachBatchPublicIpResponse DetachBatchPublicIp(DetachBatchPublicIpRequest detachBatchPublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/detach-share-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", detachBatchPublicIpRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetachBatchPublicIpResponse>(response);
        }

        public SyncInvoker<DetachBatchPublicIpResponse> DetachBatchPublicIpInvoker(DetachBatchPublicIpRequest detachBatchPublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/detach-share-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", detachBatchPublicIpRequest);
            return new SyncInvoker<DetachBatchPublicIpResponse>(this, "POST", request, JsonUtils.DeSerialize<DetachBatchPublicIpResponse>);
        }
        
        /// <summary>
        /// 共享带宽移出弹性公网IP
        ///
        /// 共享带宽移出弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetachShareBandwidthResponse DetachShareBandwidth(DetachShareBandwidthRequest detachShareBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachShareBandwidthRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/detach-share-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", detachShareBandwidthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetachShareBandwidthResponse>(response);
        }

        public SyncInvoker<DetachShareBandwidthResponse> DetachShareBandwidthInvoker(DetachShareBandwidthRequest detachShareBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachShareBandwidthRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/detach-share-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", detachShareBandwidthRequest);
            return new SyncInvoker<DetachShareBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<DetachShareBandwidthResponse>);
        }
        
        /// <summary>
        /// 弹性公网IP关闭NAT64
        ///
        /// 弹性公网IP关闭NAT64
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableNat64Response DisableNat64(DisableNat64Request disableNat64Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableNat64Request.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/disable-nat64", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableNat64Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisableNat64Response>(response);
        }

        public SyncInvoker<DisableNat64Response> DisableNat64Invoker(DisableNat64Request disableNat64Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableNat64Request.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/disable-nat64", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableNat64Request);
            return new SyncInvoker<DisableNat64Response>(this, "POST", request, JsonUtils.DeSerialize<DisableNat64Response>);
        }
        
        /// <summary>
        /// 解绑弹性公网IP
        ///
        /// 解绑弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociatePublicipsResponse DisassociatePublicips(DisassociatePublicipsRequest disassociatePublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociatePublicipsRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/disassociate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociatePublicipsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisassociatePublicipsResponse>(response);
        }

        public SyncInvoker<DisassociatePublicipsResponse> DisassociatePublicipsInvoker(DisassociatePublicipsRequest disassociatePublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociatePublicipsRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/disassociate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociatePublicipsRequest);
            return new SyncInvoker<DisassociatePublicipsResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociatePublicipsResponse>);
        }
        
        /// <summary>
        /// 弹性公网IP开启NAT64
        ///
        /// 弹性公网IP开启NAT64
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableNat64Response EnableNat64(EnableNat64Request enableNat64Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableNat64Request.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/enable-nat64", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableNat64Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EnableNat64Response>(response);
        }

        public SyncInvoker<EnableNat64Response> EnableNat64Invoker(EnableNat64Request enableNat64Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableNat64Request.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/enable-nat64", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableNat64Request);
            return new SyncInvoker<EnableNat64Response>(this, "POST", request, JsonUtils.DeSerialize<EnableNat64Response>);
        }
        
        /// <summary>
        /// 全量查询弹性公网IP列表
        ///
        /// 查询弹性公网IP列表信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPublicipsResponse ListPublicips(ListPublicipsRequest listPublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPublicipsResponse>(response);
        }

        public SyncInvoker<ListPublicipsResponse> ListPublicipsInvoker(ListPublicipsRequest listPublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipsRequest);
            return new SyncInvoker<ListPublicipsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublicipsResponse>);
        }
        
        /// <summary>
        /// 查询弹性公网IP详情
        ///
        /// 查询弹性公网IP详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPublicipResponse ShowPublicip(ShowPublicipRequest showPublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublicipRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPublicipResponse>(response);
        }

        public SyncInvoker<ShowPublicipResponse> ShowPublicipInvoker(ShowPublicipRequest showPublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublicipRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipRequest);
            return new SyncInvoker<ShowPublicipResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPublicipResponse>);
        }
        
        /// <summary>
        /// 更新弹性公网IP
        ///
        /// 更新弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePublicipResponse UpdatePublicip(UpdatePublicipRequest updatePublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePublicipRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePublicipRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePublicipResponse>(response);
        }

        public SyncInvoker<UpdatePublicipResponse> UpdatePublicipInvoker(UpdatePublicipRequest updatePublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePublicipRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePublicipRequest);
            return new SyncInvoker<UpdatePublicipResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePublicipResponse>);
        }
        
    }
}