using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Eip.V2.Model;

namespace HuaweiCloud.SDK.Eip.V2
{
    public partial class EipClient : Client
    {
        public static ClientBuilder<EipClient> NewBuilder()
        {
            return new ClientBuilder<EipClient>();
        }

        
        /// <summary>
        /// 共享带宽插入弹性公网IP
        /// </summary>
        public AddPublicipsIntoSharedBandwidthResponse AddPublicipsIntoSharedBandwidth(AddPublicipsIntoSharedBandwidthRequest addPublicipsIntoSharedBandwidthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id" , addPublicipsIntoSharedBandwidthRequest.BandwidthId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}/insert",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addPublicipsIntoSharedBandwidthRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddPublicipsIntoSharedBandwidthResponse>(response);
        }
        
        /// <summary>
        /// 批量创建共享带宽
        /// </summary>
        public BatchCreateSharedBandwidthsResponse BatchCreateSharedBandwidths(BatchCreateSharedBandwidthsRequest batchCreateSharedBandwidthsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/batch-bandwidths",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateSharedBandwidthsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchCreateSharedBandwidthsResponse>(response);
        }
        
        /// <summary>
        /// 创建共享带宽
        /// </summary>
        public CreateSharedBandwidthResponse CreateSharedBandwidth(CreateSharedBandwidthRequest createSharedBandwidthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSharedBandwidthRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSharedBandwidthResponse>(response);
        }
        
        /// <summary>
        /// 删除共享带宽
        /// </summary>
        public DeleteSharedBandwidthResponse DeleteSharedBandwidth(DeleteSharedBandwidthRequest deleteSharedBandwidthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id" , deleteSharedBandwidthRequest.BandwidthId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteSharedBandwidthRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSharedBandwidthResponse>(response);
        }
        
        /// <summary>
        /// 查询带宽列表
        /// </summary>
        public ListBandwidthsResponse ListBandwidths(ListBandwidthsRequest listBandwidthsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bandwidths",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listBandwidthsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListBandwidthsResponse>(response);
        }
        
        /// <summary>
        /// 查询配额接口
        /// </summary>
        public ListQuotasResponse ListQuotas(ListQuotasRequest listQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listQuotasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListQuotasResponse>(response);
        }
        
        /// <summary>
        /// 共享带宽移除弹性公网IP
        /// </summary>
        public RemovePublicipsFromSharedBandwidthResponse RemovePublicipsFromSharedBandwidth(RemovePublicipsFromSharedBandwidthRequest removePublicipsFromSharedBandwidthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id" , removePublicipsFromSharedBandwidthRequest.BandwidthId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}/remove",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", removePublicipsFromSharedBandwidthRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<RemovePublicipsFromSharedBandwidthResponse>(response);
        }
        
        /// <summary>
        /// 查询带宽
        /// </summary>
        public ShowBandwidthResponse ShowBandwidth(ShowBandwidthRequest showBandwidthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id" , showBandwidthRequest.BandwidthId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bandwidths/{bandwidth_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showBandwidthRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowBandwidthResponse>(response);
        }
        
        /// <summary>
        /// 更新带宽
        /// </summary>
        public UpdateBandwidthResponse UpdateBandwidth(UpdateBandwidthRequest updateBandwidthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id" , updateBandwidthRequest.BandwidthId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bandwidths/{bandwidth_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBandwidthRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateBandwidthResponse>(response);
        }
        
        /// <summary>
        /// 更新包周期带宽
        /// </summary>
        public UpdatePrePaidBandwidthResponse UpdatePrePaidBandwidth(UpdatePrePaidBandwidthRequest updatePrePaidBandwidthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id" , updatePrePaidBandwidthRequest.BandwidthId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePrePaidBandwidthRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePrePaidBandwidthResponse>(response);
        }
        
        /// <summary>
        /// 批量创建弹性公网IP资源标签
        /// </summary>
        public BatchCreatePublicipTagsResponse BatchCreatePublicipTags(BatchCreatePublicipTagsRequest batchCreatePublicipTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , batchCreatePublicipTagsRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreatePublicipTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreatePublicipTagsResponse>(response);
        }
        
        /// <summary>
        /// 批量删除弹性公网IP资源标签
        /// </summary>
        public BatchDeletePublicipTagsResponse BatchDeletePublicipTags(BatchDeletePublicipTagsRequest batchDeletePublicipTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , batchDeletePublicipTagsRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeletePublicipTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeletePublicipTagsResponse>(response);
        }
        
        /// <summary>
        /// 申请包周期弹性公网IP
        /// </summary>
        public CreatePrePaidPublicipResponse CreatePrePaidPublicip(CreatePrePaidPublicipRequest createPrePaidPublicipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPrePaidPublicipRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePrePaidPublicipResponse>(response);
        }
        
        /// <summary>
        /// 申请弹性公网IP
        /// </summary>
        public CreatePublicipResponse CreatePublicip(CreatePublicipRequest createPublicipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPublicipRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePublicipResponse>(response);
        }
        
        /// <summary>
        /// 创建弹性公网IP资源标签
        /// </summary>
        public CreatePublicipTagResponse CreatePublicipTag(CreatePublicipTagRequest createPublicipTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , createPublicipTagRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPublicipTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreatePublicipTagResponse>(response);
        }
        
        /// <summary>
        /// 删除弹性公网IP
        /// </summary>
        public DeletePublicipResponse DeletePublicip(DeletePublicipRequest deletePublicipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , deletePublicipRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips/{publicip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deletePublicipRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePublicipResponse>(response);
        }
        
        /// <summary>
        /// 删除弹性公网IP的标签
        /// </summary>
        public DeletePublicipTagResponse DeletePublicipTag(DeletePublicipTagRequest deletePublicipTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , deletePublicipTagRequest.PublicipId.ToString());
            urlParam.Add("key" , deletePublicipTagRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deletePublicipTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePublicipTagResponse>(response);
        }
        
        /// <summary>
        /// 查询租户的弹性公网IP标签
        /// </summary>
        public ListPublicipTagsResponse ListPublicipTags(ListPublicipTagsRequest listPublicipTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listPublicipTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPublicipTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性公网IP列表
        /// </summary>
        public ListPublicipsResponse ListPublicips(ListPublicipsRequest listPublicipsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listPublicipsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPublicipsResponse>(response);
        }
        
        /// <summary>
        /// 按标签查询弹性公网IP列表
        /// </summary>
        public ListPublicipsByTagsResponse ListPublicipsByTags(ListPublicipsByTagsRequest listPublicipsByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPublicipsByTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListPublicipsByTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性公网IP
        /// </summary>
        public ShowPublicipResponse ShowPublicip(ShowPublicipRequest showPublicipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , showPublicipRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips/{publicip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showPublicipRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPublicipResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性公网IP的标签
        /// </summary>
        public ShowPublicipTagsResponse ShowPublicipTags(ShowPublicipTagsRequest showPublicipTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , showPublicipTagsRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showPublicipTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPublicipTagsResponse>(response);
        }
        
        /// <summary>
        /// 更新弹性公网IP
        /// </summary>
        public UpdatePublicipResponse UpdatePublicip(UpdatePublicipRequest updatePublicipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , updatePublicipRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips/{publicip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePublicipRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePublicipResponse>(response);
        }
        
        /// <summary>
        /// 创建浮动IP
        /// </summary>
        public NeutronCreateFloatingIpResponse NeutronCreateFloatingIp(NeutronCreateFloatingIpRequest neutronCreateFloatingIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFloatingIpRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<NeutronCreateFloatingIpResponse>(response);
        }
        
        /// <summary>
        /// 删除浮动IP
        /// </summary>
        public NeutronDeleteFloatingIpResponse NeutronDeleteFloatingIp(NeutronDeleteFloatingIpRequest neutronDeleteFloatingIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("floatingip_id" , neutronDeleteFloatingIpRequest.FloatingipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips/{floatingip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, neutronDeleteFloatingIpRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<NeutronDeleteFloatingIpResponse>(response);
        }
        
        /// <summary>
        /// 查询浮动IP列表
        /// </summary>
        public NeutronListFloatingIpsResponse NeutronListFloatingIps(NeutronListFloatingIpsRequest neutronListFloatingIpsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, neutronListFloatingIpsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<NeutronListFloatingIpsResponse>(response);
        }
        
        /// <summary>
        /// 查询浮动IP
        /// </summary>
        public NeutronShowFloatingIpResponse NeutronShowFloatingIp(NeutronShowFloatingIpRequest neutronShowFloatingIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("floatingip_id" , neutronShowFloatingIpRequest.FloatingipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips/{floatingip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, neutronShowFloatingIpRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<NeutronShowFloatingIpResponse>(response);
        }
        
        /// <summary>
        /// 更新浮动IP
        /// </summary>
        public NeutronUpdateFloatingIpResponse NeutronUpdateFloatingIp(NeutronUpdateFloatingIpRequest neutronUpdateFloatingIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("floatingip_id" , neutronUpdateFloatingIpRequest.FloatingipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips/{floatingip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFloatingIpRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<NeutronUpdateFloatingIpResponse>(response);
        }
        
    }
}