using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Eip.V2.Model;

namespace HuaweiCloud.SDK.Eip.V2
{
    public partial class EipAsyncClient : Client
    {
        public static ClientBuilder<EipAsyncClient> NewBuilder()
        {
            return new ClientBuilder<EipAsyncClient>();
        }

        
        /// <summary>
        /// 共享带宽插入弹性公网IP
        /// </summary>
        public async Task<AddPublicipsIntoSharedBandwidthResponse> AddPublicipsIntoSharedBandwidthAsync(AddPublicipsIntoSharedBandwidthRequest addPublicipsIntoSharedBandwidthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id" , addPublicipsIntoSharedBandwidthRequest.BandwidthId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}/insert",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addPublicipsIntoSharedBandwidthRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddPublicipsIntoSharedBandwidthResponse>(response);
        }
        
        /// <summary>
        /// 批量创建共享带宽
        /// </summary>
        public async Task<BatchCreateSharedBandwidthsResponse> BatchCreateSharedBandwidthsAsync(BatchCreateSharedBandwidthsRequest batchCreateSharedBandwidthsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/batch-bandwidths",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateSharedBandwidthsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchCreateSharedBandwidthsResponse>(response);
        }
        
        /// <summary>
        /// 创建共享带宽
        /// </summary>
        public async Task<CreateSharedBandwidthResponse> CreateSharedBandwidthAsync(CreateSharedBandwidthRequest createSharedBandwidthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSharedBandwidthRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSharedBandwidthResponse>(response);
        }
        
        /// <summary>
        /// 删除共享带宽
        /// </summary>
        public async Task<DeleteSharedBandwidthResponse> DeleteSharedBandwidthAsync(DeleteSharedBandwidthRequest deleteSharedBandwidthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id" , deleteSharedBandwidthRequest.BandwidthId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSharedBandwidthRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSharedBandwidthResponse>(response);
        }
        
        /// <summary>
        /// 查询带宽列表
        /// </summary>
        public async Task<ListBandwidthsResponse> ListBandwidthsAsync(ListBandwidthsRequest listBandwidthsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bandwidths",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBandwidthsResponse>(response);
        }
        
        /// <summary>
        /// 查询配额接口
        /// </summary>
        public async Task<ListQuotasResponse> ListQuotasAsync(ListQuotasRequest listQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListQuotasResponse>(response);
        }
        
        /// <summary>
        /// 共享带宽移除弹性公网IP
        /// </summary>
        public async Task<RemovePublicipsFromSharedBandwidthResponse> RemovePublicipsFromSharedBandwidthAsync(RemovePublicipsFromSharedBandwidthRequest removePublicipsFromSharedBandwidthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id" , removePublicipsFromSharedBandwidthRequest.BandwidthId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}/remove",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", removePublicipsFromSharedBandwidthRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<RemovePublicipsFromSharedBandwidthResponse>(response);
        }
        
        /// <summary>
        /// 查询带宽
        /// </summary>
        public async Task<ShowBandwidthResponse> ShowBandwidthAsync(ShowBandwidthRequest showBandwidthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id" , showBandwidthRequest.BandwidthId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bandwidths/{bandwidth_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBandwidthRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBandwidthResponse>(response);
        }
        
        /// <summary>
        /// 更新带宽
        /// </summary>
        public async Task<UpdateBandwidthResponse> UpdateBandwidthAsync(UpdateBandwidthRequest updateBandwidthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id" , updateBandwidthRequest.BandwidthId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bandwidths/{bandwidth_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBandwidthRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateBandwidthResponse>(response);
        }
        
        /// <summary>
        /// 更新包周期带宽
        /// </summary>
        public async Task<UpdatePrePaidBandwidthResponse> UpdatePrePaidBandwidthAsync(UpdatePrePaidBandwidthRequest updatePrePaidBandwidthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id" , updatePrePaidBandwidthRequest.BandwidthId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePrePaidBandwidthRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePrePaidBandwidthResponse>(response);
        }
        
        /// <summary>
        /// 批量创建弹性公网IP资源标签
        /// </summary>
        public async Task<BatchCreatePublicipTagsResponse> BatchCreatePublicipTagsAsync(BatchCreatePublicipTagsRequest batchCreatePublicipTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , batchCreatePublicipTagsRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreatePublicipTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreatePublicipTagsResponse>(response);
        }
        
        /// <summary>
        /// 批量删除弹性公网IP资源标签
        /// </summary>
        public async Task<BatchDeletePublicipTagsResponse> BatchDeletePublicipTagsAsync(BatchDeletePublicipTagsRequest batchDeletePublicipTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , batchDeletePublicipTagsRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeletePublicipTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeletePublicipTagsResponse>(response);
        }
        
        /// <summary>
        /// 申请包周期弹性公网IP
        /// </summary>
        public async Task<CreatePrePaidPublicipResponse> CreatePrePaidPublicipAsync(CreatePrePaidPublicipRequest createPrePaidPublicipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPrePaidPublicipRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePrePaidPublicipResponse>(response);
        }
        
        /// <summary>
        /// 申请弹性公网IP
        /// </summary>
        public async Task<CreatePublicipResponse> CreatePublicipAsync(CreatePublicipRequest createPublicipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPublicipRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePublicipResponse>(response);
        }
        
        /// <summary>
        /// 创建弹性公网IP资源标签
        /// </summary>
        public async Task<CreatePublicipTagResponse> CreatePublicipTagAsync(CreatePublicipTagRequest createPublicipTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , createPublicipTagRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPublicipTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreatePublicipTagResponse>(response);
        }
        
        /// <summary>
        /// 删除弹性公网IP
        /// </summary>
        public async Task<DeletePublicipResponse> DeletePublicipAsync(DeletePublicipRequest deletePublicipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , deletePublicipRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips/{publicip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicipRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePublicipResponse>(response);
        }
        
        /// <summary>
        /// 删除弹性公网IP的标签
        /// </summary>
        public async Task<DeletePublicipTagResponse> DeletePublicipTagAsync(DeletePublicipTagRequest deletePublicipTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , deletePublicipTagRequest.PublicipId.ToString());
            urlParam.Add("key" , deletePublicipTagRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicipTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePublicipTagResponse>(response);
        }
        
        /// <summary>
        /// 查询租户的弹性公网IP标签
        /// </summary>
        public async Task<ListPublicipTagsResponse> ListPublicipTagsAsync(ListPublicipTagsRequest listPublicipTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPublicipTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性公网IP列表
        /// </summary>
        public async Task<ListPublicipsResponse> ListPublicipsAsync(ListPublicipsRequest listPublicipsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPublicipsResponse>(response);
        }
        
        /// <summary>
        /// 按标签查询弹性公网IP列表
        /// </summary>
        public async Task<ListPublicipsByTagsResponse> ListPublicipsByTagsAsync(ListPublicipsByTagsRequest listPublicipsByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPublicipsByTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListPublicipsByTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性公网IP
        /// </summary>
        public async Task<ShowPublicipResponse> ShowPublicipAsync(ShowPublicipRequest showPublicipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , showPublicipRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips/{publicip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPublicipResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性公网IP的标签
        /// </summary>
        public async Task<ShowPublicipTagsResponse> ShowPublicipTagsAsync(ShowPublicipTagsRequest showPublicipTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , showPublicipTagsRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPublicipTagsResponse>(response);
        }
        
        /// <summary>
        /// 更新弹性公网IP
        /// </summary>
        public async Task<UpdatePublicipResponse> UpdatePublicipAsync(UpdatePublicipRequest updatePublicipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , updatePublicipRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips/{publicip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePublicipRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePublicipResponse>(response);
        }
        
        /// <summary>
        /// 创建浮动IP
        /// </summary>
        public async Task<NeutronCreateFloatingIpResponse> NeutronCreateFloatingIpAsync(NeutronCreateFloatingIpRequest neutronCreateFloatingIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFloatingIpRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<NeutronCreateFloatingIpResponse>(response);
        }
        
        /// <summary>
        /// 删除浮动IP
        /// </summary>
        public async Task<NeutronDeleteFloatingIpResponse> NeutronDeleteFloatingIpAsync(NeutronDeleteFloatingIpRequest neutronDeleteFloatingIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("floatingip_id" , neutronDeleteFloatingIpRequest.FloatingipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips/{floatingip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFloatingIpRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<NeutronDeleteFloatingIpResponse>(response);
        }
        
        /// <summary>
        /// 查询浮动IP列表
        /// </summary>
        public async Task<NeutronListFloatingIpsResponse> NeutronListFloatingIpsAsync(NeutronListFloatingIpsRequest neutronListFloatingIpsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFloatingIpsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NeutronListFloatingIpsResponse>(response);
        }
        
        /// <summary>
        /// 查询浮动IP
        /// </summary>
        public async Task<NeutronShowFloatingIpResponse> NeutronShowFloatingIpAsync(NeutronShowFloatingIpRequest neutronShowFloatingIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("floatingip_id" , neutronShowFloatingIpRequest.FloatingipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips/{floatingip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFloatingIpRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NeutronShowFloatingIpResponse>(response);
        }
        
        /// <summary>
        /// 更新浮动IP
        /// </summary>
        public async Task<NeutronUpdateFloatingIpResponse> NeutronUpdateFloatingIpAsync(NeutronUpdateFloatingIpRequest neutronUpdateFloatingIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("floatingip_id" , neutronUpdateFloatingIpRequest.FloatingipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips/{floatingip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFloatingIpRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<NeutronUpdateFloatingIpResponse>(response);
        }
        
    }
}