using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Eip.V3.Model;

namespace HuaweiCloud.SDK.Eip.V3
{
    public partial class EipAsyncClient : Client
    {
        public static ClientBuilder<EipAsyncClient> NewBuilder()
        {
            return new ClientBuilder<EipAsyncClient>();
        }

        
        /// <summary>
        /// 查询带宽列表
        ///
        /// 查询带宽列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBandwidthResponse> ListBandwidthAsync(ListBandwidthRequest listBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBandwidthResponse>(response);
        }

        public AsyncInvoker<ListBandwidthResponse> ListBandwidthAsyncInvoker(ListBandwidthRequest listBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthRequest);
            return new AsyncInvoker<ListBandwidthResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBandwidthResponse>);
        }
        
        /// <summary>
        /// 查看租户带宽限制
        ///
        /// 获取EIP带宽限制列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBandwidthsLimitResponse> ListBandwidthsLimitAsync(ListBandwidthsLimitRequest listBandwidthsLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/eip-bandwidth-limits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthsLimitRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBandwidthsLimitResponse>(response);
        }

        public AsyncInvoker<ListBandwidthsLimitResponse> ListBandwidthsLimitAsyncInvoker(ListBandwidthsLimitRequest listBandwidthsLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/eip-bandwidth-limits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthsLimitRequest);
            return new AsyncInvoker<ListBandwidthsLimitResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBandwidthsLimitResponse>);
        }
        
        /// <summary>
        /// 查询公共池列表
        ///
        /// 查询公共池列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCommonPoolsResponse> ListCommonPoolsAsync(ListCommonPoolsRequest listCommonPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicip-pools/common-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommonPoolsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCommonPoolsResponse>(response);
        }

        public AsyncInvoker<ListCommonPoolsResponse> ListCommonPoolsAsyncInvoker(ListCommonPoolsRequest listCommonPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicip-pools/common-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommonPoolsRequest);
            return new AsyncInvoker<ListCommonPoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCommonPoolsResponse>);
        }
        
        /// <summary>
        /// 查询带宽列表
        ///
        /// 查询带宽列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEipBandwidthsResponse> ListEipBandwidthsAsync(ListEipBandwidthsRequest listEipBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEipBandwidthsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEipBandwidthsResponse>(response);
        }

        public AsyncInvoker<ListEipBandwidthsResponse> ListEipBandwidthsAsyncInvoker(ListEipBandwidthsRequest listEipBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEipBandwidthsRequest);
            return new AsyncInvoker<ListEipBandwidthsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEipBandwidthsResponse>);
        }
        
        /// <summary>
        /// 查询公共池分组列表
        ///
        /// 查询公共池分组列表，包含名称和位置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPublicBorderGroupsResponse> ListPublicBorderGroupsAsync(ListPublicBorderGroupsRequest listPublicBorderGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/public-border-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicBorderGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPublicBorderGroupsResponse>(response);
        }

        public AsyncInvoker<ListPublicBorderGroupsResponse> ListPublicBorderGroupsAsyncInvoker(ListPublicBorderGroupsRequest listPublicBorderGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/public-border-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicBorderGroupsRequest);
            return new AsyncInvoker<ListPublicBorderGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublicBorderGroupsResponse>);
        }
        
        /// <summary>
        /// 查询公网IP池列表
        ///
        /// 全量查询公网IP池列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPublicipPoolResponse> ListPublicipPoolAsync(ListPublicipPoolRequest listPublicipPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicip-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipPoolRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPublicipPoolResponse>(response);
        }

        public AsyncInvoker<ListPublicipPoolResponse> ListPublicipPoolAsyncInvoker(ListPublicipPoolRequest listPublicipPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicip-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipPoolRequest);
            return new AsyncInvoker<ListPublicipPoolResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublicipPoolResponse>);
        }
        
        /// <summary>
        /// 查询指定租户下的共享带宽类型列表
        ///
        /// 查询指定租户下的共享带宽类型列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListShareBandwidthTypesResponse> ListShareBandwidthTypesAsync(ListShareBandwidthTypesRequest listShareBandwidthTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/share-bandwidth-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listShareBandwidthTypesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListShareBandwidthTypesResponse>(response);
        }

        public AsyncInvoker<ListShareBandwidthTypesResponse> ListShareBandwidthTypesAsyncInvoker(ListShareBandwidthTypesRequest listShareBandwidthTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/share-bandwidth-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listShareBandwidthTypesRequest);
            return new AsyncInvoker<ListShareBandwidthTypesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListShareBandwidthTypesResponse>);
        }
        
        /// <summary>
        /// 查询公网IP池详情
        ///
        /// 查询公网IP池详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPublicipPoolResponse> ShowPublicipPoolAsync(ShowPublicipPoolRequest showPublicipPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublicipPoolRequest.PublicipPoolId, out var valueOfPublicipPoolId)) urlParam.Add("publicip_pool_id", valueOfPublicipPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicip-pools/{publicip_pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipPoolRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPublicipPoolResponse>(response);
        }

        public AsyncInvoker<ShowPublicipPoolResponse> ShowPublicipPoolAsyncInvoker(ShowPublicipPoolRequest showPublicipPoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublicipPoolRequest.PublicipPoolId, out var valueOfPublicipPoolId)) urlParam.Add("publicip_pool_id", valueOfPublicipPoolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicip-pools/{publicip_pool_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipPoolRequest);
            return new AsyncInvoker<ShowPublicipPoolResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPublicipPoolResponse>);
        }
        
        /// <summary>
        /// 查询公网IP池类型
        ///
        /// 查询公网IP池类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPublicipPoolTypesResponse> ShowPublicipPoolTypesAsync(ShowPublicipPoolTypesRequest showPublicipPoolTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicip-pool-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipPoolTypesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPublicipPoolTypesResponse>(response);
        }

        public AsyncInvoker<ShowPublicipPoolTypesResponse> ShowPublicipPoolTypesAsyncInvoker(ShowPublicipPoolTypesRequest showPublicipPoolTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicip-pool-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipPoolTypesRequest);
            return new AsyncInvoker<ShowPublicipPoolTypesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPublicipPoolTypesResponse>);
        }
        
        /// <summary>
        /// 查询GEIP与实例绑定关系的租户列表
        ///
        /// 查询GEIP与实例绑定关系的租户列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectGeipBindingsResponse> ListProjectGeipBindingsAsync(ListProjectGeipBindingsRequest listProjectGeipBindingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/bindings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectGeipBindingsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProjectGeipBindingsResponse>(response);
        }

        public AsyncInvoker<ListProjectGeipBindingsResponse> ListProjectGeipBindingsAsyncInvoker(ListProjectGeipBindingsRequest listProjectGeipBindingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/bindings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectGeipBindingsRequest);
            return new AsyncInvoker<ListProjectGeipBindingsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectGeipBindingsResponse>);
        }
        
        /// <summary>
        /// 创建虚拟igw
        ///
        /// 创建虚拟igw
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTenantVpcIgwResponse> CreateTenantVpcIgwAsync(CreateTenantVpcIgwRequest createTenantVpcIgwRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/vpc-igws", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTenantVpcIgwRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTenantVpcIgwResponse>(response);
        }

        public AsyncInvoker<CreateTenantVpcIgwResponse> CreateTenantVpcIgwAsyncInvoker(CreateTenantVpcIgwRequest createTenantVpcIgwRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/vpc-igws", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTenantVpcIgwRequest);
            return new AsyncInvoker<CreateTenantVpcIgwResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTenantVpcIgwResponse>);
        }
        
        /// <summary>
        /// 删除虚拟igw
        ///
        /// 删除虚拟igw
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTenantVpcIgwResponse> DeleteTenantVpcIgwAsync(DeleteTenantVpcIgwRequest deleteTenantVpcIgwRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTenantVpcIgwRequest.VpcIgwId, out var valueOfVpcIgwId)) urlParam.Add("vpc_igw_id", valueOfVpcIgwId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/vpc-igws/{vpc_igw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTenantVpcIgwRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTenantVpcIgwResponse>(response);
        }

        public AsyncInvoker<DeleteTenantVpcIgwResponse> DeleteTenantVpcIgwAsyncInvoker(DeleteTenantVpcIgwRequest deleteTenantVpcIgwRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTenantVpcIgwRequest.VpcIgwId, out var valueOfVpcIgwId)) urlParam.Add("vpc_igw_id", valueOfVpcIgwId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/vpc-igws/{vpc_igw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTenantVpcIgwRequest);
            return new AsyncInvoker<DeleteTenantVpcIgwResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTenantVpcIgwResponse>);
        }
        
        /// <summary>
        /// 查询指定租户下的虚拟igw列表
        ///
        /// 查询指定租户下的虚拟igw列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTenantVpcIgwsResponse> ListTenantVpcIgwsAsync(ListTenantVpcIgwsRequest listTenantVpcIgwsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/vpc-igws", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantVpcIgwsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTenantVpcIgwsResponse>(response);
        }

        public AsyncInvoker<ListTenantVpcIgwsResponse> ListTenantVpcIgwsAsyncInvoker(ListTenantVpcIgwsRequest listTenantVpcIgwsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/vpc-igws", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantVpcIgwsRequest);
            return new AsyncInvoker<ListTenantVpcIgwsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTenantVpcIgwsResponse>);
        }
        
        /// <summary>
        /// 查询虚拟igw详情
        ///
        /// 查询虚拟igw详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInternalVpcIgwResponse> ShowInternalVpcIgwAsync(ShowInternalVpcIgwRequest showInternalVpcIgwRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInternalVpcIgwRequest.VpcIgwId, out var valueOfVpcIgwId)) urlParam.Add("vpc_igw_id", valueOfVpcIgwId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/vpc-igws/{vpc_igw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInternalVpcIgwRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInternalVpcIgwResponse>(response);
        }

        public AsyncInvoker<ShowInternalVpcIgwResponse> ShowInternalVpcIgwAsyncInvoker(ShowInternalVpcIgwRequest showInternalVpcIgwRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInternalVpcIgwRequest.VpcIgwId, out var valueOfVpcIgwId)) urlParam.Add("vpc_igw_id", valueOfVpcIgwId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/vpc-igws/{vpc_igw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInternalVpcIgwRequest);
            return new AsyncInvoker<ShowInternalVpcIgwResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInternalVpcIgwResponse>);
        }
        
        /// <summary>
        /// 修改虚拟igw
        ///
        /// 修改虚拟igw
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTenantVpcIgwResponse> UpdateTenantVpcIgwAsync(UpdateTenantVpcIgwRequest updateTenantVpcIgwRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTenantVpcIgwRequest.VpcIgwId, out var valueOfVpcIgwId)) urlParam.Add("vpc_igw_id", valueOfVpcIgwId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/vpc-igws/{vpc_igw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTenantVpcIgwRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTenantVpcIgwResponse>(response);
        }

        public AsyncInvoker<UpdateTenantVpcIgwResponse> UpdateTenantVpcIgwAsyncInvoker(UpdateTenantVpcIgwRequest updateTenantVpcIgwRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTenantVpcIgwRequest.VpcIgwId, out var valueOfVpcIgwId)) urlParam.Add("vpc_igw_id", valueOfVpcIgwId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/geip/vpc-igws/{vpc_igw_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTenantVpcIgwRequest);
            return new AsyncInvoker<UpdateTenantVpcIgwResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTenantVpcIgwResponse>);
        }
        
        /// <summary>
        /// 绑定弹性公网IP
        ///
        /// 绑定弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociatePublicipsResponse> AssociatePublicipsAsync(AssociatePublicipsRequest associatePublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associatePublicipsRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/associate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associatePublicipsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AssociatePublicipsResponse>(response);
        }

        public AsyncInvoker<AssociatePublicipsResponse> AssociatePublicipsAsyncInvoker(AssociatePublicipsRequest associatePublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associatePublicipsRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/associate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associatePublicipsRequest);
            return new AsyncInvoker<AssociatePublicipsResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociatePublicipsResponse>);
        }
        
        /// <summary>
        /// 共享带宽批量加入弹性公网IP
        ///
        /// 共享带宽批量加入弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AttachBatchPublicIpResponse> AttachBatchPublicIpAsync(AttachBatchPublicIpRequest attachBatchPublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/attach-share-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachBatchPublicIpRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AttachBatchPublicIpResponse>(response);
        }

        public AsyncInvoker<AttachBatchPublicIpResponse> AttachBatchPublicIpAsyncInvoker(AttachBatchPublicIpRequest attachBatchPublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/attach-share-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachBatchPublicIpRequest);
            return new AsyncInvoker<AttachBatchPublicIpResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachBatchPublicIpResponse>);
        }
        
        /// <summary>
        /// 共享带宽加入弹性公网IP
        ///
        /// 共享带宽加入弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AttachShareBandwidthResponse> AttachShareBandwidthAsync(AttachShareBandwidthRequest attachShareBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachShareBandwidthRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/attach-share-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachShareBandwidthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AttachShareBandwidthResponse>(response);
        }

        public AsyncInvoker<AttachShareBandwidthResponse> AttachShareBandwidthAsyncInvoker(AttachShareBandwidthRequest attachShareBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachShareBandwidthRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/attach-share-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachShareBandwidthRequest);
            return new AsyncInvoker<AttachShareBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachShareBandwidthResponse>);
        }
        
        /// <summary>
        /// 查询弹性公网IP可用数
        ///
        /// IP池用于查询公网可用ip个数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountEipAvailableResourcesResponse> CountEipAvailableResourcesAsync(CountEipAvailableResourcesRequest countEipAvailableResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/resources/available", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", countEipAvailableResourcesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CountEipAvailableResourcesResponse>(response);
        }

        public AsyncInvoker<CountEipAvailableResourcesResponse> CountEipAvailableResourcesAsyncInvoker(CountEipAvailableResourcesRequest countEipAvailableResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/resources/available", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", countEipAvailableResourcesRequest);
            return new AsyncInvoker<CountEipAvailableResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<CountEipAvailableResourcesResponse>);
        }
        
        /// <summary>
        /// 共享带宽批量移出弹性公网IP
        ///
        /// 共享带宽批量移出弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetachBatchPublicIpResponse> DetachBatchPublicIpAsync(DetachBatchPublicIpRequest detachBatchPublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/detach-share-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", detachBatchPublicIpRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DetachBatchPublicIpResponse>(response);
        }

        public AsyncInvoker<DetachBatchPublicIpResponse> DetachBatchPublicIpAsyncInvoker(DetachBatchPublicIpRequest detachBatchPublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/detach-share-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", detachBatchPublicIpRequest);
            return new AsyncInvoker<DetachBatchPublicIpResponse>(this, "POST", request, JsonUtils.DeSerialize<DetachBatchPublicIpResponse>);
        }
        
        /// <summary>
        /// 共享带宽移出弹性公网IP
        ///
        /// 共享带宽移出弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetachShareBandwidthResponse> DetachShareBandwidthAsync(DetachShareBandwidthRequest detachShareBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachShareBandwidthRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/detach-share-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", detachShareBandwidthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DetachShareBandwidthResponse>(response);
        }

        public AsyncInvoker<DetachShareBandwidthResponse> DetachShareBandwidthAsyncInvoker(DetachShareBandwidthRequest detachShareBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachShareBandwidthRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/detach-share-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", detachShareBandwidthRequest);
            return new AsyncInvoker<DetachShareBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<DetachShareBandwidthResponse>);
        }
        
        /// <summary>
        /// 弹性公网IP关闭NAT64
        ///
        /// 弹性公网IP关闭NAT64
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableNat64Response> DisableNat64Async(DisableNat64Request disableNat64Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableNat64Request.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/disable-nat64", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableNat64Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisableNat64Response>(response);
        }

        public AsyncInvoker<DisableNat64Response> DisableNat64AsyncInvoker(DisableNat64Request disableNat64Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableNat64Request.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/disable-nat64", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableNat64Request);
            return new AsyncInvoker<DisableNat64Response>(this, "POST", request, JsonUtils.DeSerialize<DisableNat64Response>);
        }
        
        /// <summary>
        /// 解绑弹性公网IP
        ///
        /// 解绑弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociatePublicipsResponse> DisassociatePublicipsAsync(DisassociatePublicipsRequest disassociatePublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociatePublicipsRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/disassociate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociatePublicipsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisassociatePublicipsResponse>(response);
        }

        public AsyncInvoker<DisassociatePublicipsResponse> DisassociatePublicipsAsyncInvoker(DisassociatePublicipsRequest disassociatePublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociatePublicipsRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/disassociate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociatePublicipsRequest);
            return new AsyncInvoker<DisassociatePublicipsResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociatePublicipsResponse>);
        }
        
        /// <summary>
        /// 弹性公网IP开启NAT64
        ///
        /// 弹性公网IP开启NAT64
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableNat64Response> EnableNat64Async(EnableNat64Request enableNat64Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableNat64Request.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/enable-nat64", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableNat64Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EnableNat64Response>(response);
        }

        public AsyncInvoker<EnableNat64Response> EnableNat64AsyncInvoker(EnableNat64Request enableNat64Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableNat64Request.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/enable-nat64", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableNat64Request);
            return new AsyncInvoker<EnableNat64Response>(this, "POST", request, JsonUtils.DeSerialize<EnableNat64Response>);
        }
        
        /// <summary>
        /// 全量查询弹性公网IP列表
        ///
        /// 查询弹性公网IP列表信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPublicipsResponse> ListPublicipsAsync(ListPublicipsRequest listPublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPublicipsResponse>(response);
        }

        public AsyncInvoker<ListPublicipsResponse> ListPublicipsAsyncInvoker(ListPublicipsRequest listPublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipsRequest);
            return new AsyncInvoker<ListPublicipsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublicipsResponse>);
        }
        
        /// <summary>
        /// 查询弹性公网IP详情
        ///
        /// 查询弹性公网IP详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPublicipResponse> ShowPublicipAsync(ShowPublicipRequest showPublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublicipRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPublicipResponse>(response);
        }

        public AsyncInvoker<ShowPublicipResponse> ShowPublicipAsyncInvoker(ShowPublicipRequest showPublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublicipRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipRequest);
            return new AsyncInvoker<ShowPublicipResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPublicipResponse>);
        }
        
        /// <summary>
        /// 更新弹性公网IP
        ///
        /// 更新弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePublicipResponse> UpdatePublicipAsync(UpdatePublicipRequest updatePublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePublicipRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePublicipRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePublicipResponse>(response);
        }

        public AsyncInvoker<UpdatePublicipResponse> UpdatePublicipAsyncInvoker(UpdatePublicipRequest updatePublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePublicipRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePublicipRequest);
            return new AsyncInvoker<UpdatePublicipResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePublicipResponse>);
        }
        
    }
}