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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/bandwidths",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBandwidthResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicip-pools/common-pools",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommonPoolsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListCommonPoolsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/public-border-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicBorderGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPublicBorderGroupsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicip-pools",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipPoolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPublicipPoolResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/share-bandwidth-types",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listShareBandwidthTypesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListShareBandwidthTypesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_pool_id" , showPublicipPoolRequest.PublicipPoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicip-pools/{publicip_pool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipPoolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPublicipPoolResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , associatePublicipsRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/associate-instance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associatePublicipsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AssociatePublicipsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/attach-share-bandwidth",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachBatchPublicIpRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AttachBatchPublicIpResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , attachShareBandwidthRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/attach-share-bandwidth",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachShareBandwidthRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AttachShareBandwidthResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/resources/available",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", countEipAvailableResourcesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CountEipAvailableResourcesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/detach-share-bandwidth",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", detachBatchPublicIpRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetachBatchPublicIpResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , detachShareBandwidthRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/detach-share-bandwidth",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", detachShareBandwidthRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DetachShareBandwidthResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , disableNat64Request.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/disable-nat64",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableNat64Request);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DisableNat64Response>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , disassociatePublicipsRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/disassociate-instance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociatePublicipsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DisassociatePublicipsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , enableNat64Request.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/enable-nat64",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableNat64Request);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<EnableNat64Response>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPublicipsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , showPublicipRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPublicipResponse>(response);
        }
        
        /// <summary>
        /// 绑定弹性公网IP
        ///
        /// 绑定弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAssociatePublicipResponse> UpdateAssociatePublicipAsync(UpdateAssociatePublicipRequest updateAssociatePublicipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , updateAssociatePublicipRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/associate-instance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAssociatePublicipRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAssociatePublicipResponse>(response);
        }
        
        /// <summary>
        /// 解绑弹性公网IP
        ///
        /// 解绑弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDisassociatePublicipResponse> UpdateDisassociatePublicipAsync(UpdateDisassociatePublicipRequest updateDisassociatePublicipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , updateDisassociatePublicipRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/disassociate-instance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDisassociatePublicipRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDisassociatePublicipResponse>(response);
        }
        
    }
}