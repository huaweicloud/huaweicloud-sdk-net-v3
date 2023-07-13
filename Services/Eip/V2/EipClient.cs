using System;
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
        ///
        /// 共享带宽插入弹性公网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 批量创建共享带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 按需转包API
        ///
        /// 租户按需转包接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeBandwidthToPeriodResponse ChangeBandwidthToPeriod(ChangeBandwidthToPeriodRequest changeBandwidthToPeriodRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/change-to-period",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeBandwidthToPeriodRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ChangeBandwidthToPeriodResponse>(response);
        }
        
        /// <summary>
        /// 创建共享带宽
        ///
        /// 创建共享带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 删除共享带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSharedBandwidthResponse DeleteSharedBandwidth(DeleteSharedBandwidthRequest deleteSharedBandwidthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id" , deleteSharedBandwidthRequest.BandwidthId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSharedBandwidthRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSharedBandwidthResponse>(response);
        }
        
        /// <summary>
        /// 查询带宽加油包列表
        ///
        /// 查询带宽加油包列表信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBandwidthPkgResponse ListBandwidthPkg(ListBandwidthPkgRequest listBandwidthPkgRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidthpkgs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPkgRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListBandwidthPkgResponse>(response);
        }
        
        /// <summary>
        /// 查询带宽列表
        ///
        /// 查询带宽列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBandwidthsResponse ListBandwidths(ListBandwidthsRequest listBandwidthsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bandwidths",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListBandwidthsResponse>(response);
        }
        
        /// <summary>
        /// 查询配额接口
        ///
        /// 查询配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListQuotasResponse ListQuotas(ListQuotasRequest listQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListQuotasResponse>(response);
        }
        
        /// <summary>
        /// 共享带宽移除弹性公网IP
        ///
        /// 共享带宽移除弹性公网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 查询带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBandwidthResponse ShowBandwidth(ShowBandwidthRequest showBandwidthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id" , showBandwidthRequest.BandwidthId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bandwidths/{bandwidth_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBandwidthRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowBandwidthResponse>(response);
        }
        
        /// <summary>
        /// 更新带宽
        ///
        /// 更新带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 更新带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 为指定的弹性公网IP资源实例批量添加标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 批量创建弹性公网IP
        ///
        /// 批量创建弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreatePublicipsResponse BatchCreatePublicips(BatchCreatePublicipsRequest batchCreatePublicipsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batchpublicips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreatePublicipsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchCreatePublicipsResponse>(response);
        }
        
        /// <summary>
        /// 批量删除弹性公网IP
        ///
        /// 批量删除弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeletePublicIpResponse BatchDeletePublicIp(BatchDeletePublicIpRequest batchDeletePublicIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batchpublicips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeletePublicIpRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeletePublicIpResponse>(response);
        }
        
        /// <summary>
        /// 批量删除弹性公网IP资源标签
        ///
        /// 为指定的弹性公网IP资源实例批量删除标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 批量解绑弹性公网IP
        ///
        /// 批量解绑弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDisassociatePublicipsResponse BatchDisassociatePublicips(BatchDisassociatePublicipsRequest batchDisassociatePublicipsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batchpublicips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDisassociatePublicipsRequest);
            HttpResponseMessage response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerialize<BatchDisassociatePublicipsResponse>(response);
        }
        
        /// <summary>
        /// 按需转包接口
        ///
        /// 租户按需转包接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangePublicipToPeriodResponse ChangePublicipToPeriod(ChangePublicipToPeriodRequest changePublicipToPeriodRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/change-to-period",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changePublicipToPeriodRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ChangePublicipToPeriodResponse>(response);
        }
        
        /// <summary>
        /// 查询PublicIp数量
        ///
        /// 查询PublicIp数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountPublicIpResponse CountPublicIp(CountPublicIpRequest countPublicIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elasticips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", countPublicIpRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<CountPublicIpResponse>(response);
        }
        
        /// <summary>
        /// 查询PublicIp实例数
        ///
        /// 查询PublicIp实例数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountPublicIpInstanceResponse CountPublicIpInstance(CountPublicIpInstanceRequest countPublicIpInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/publicip/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", countPublicIpInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            CountPublicIpInstanceResponse countPublicIpInstanceResponse = JsonUtils.DeSerializeNull<CountPublicIpInstanceResponse>(response);
            return countPublicIpInstanceResponse;
        }
        
        /// <summary>
        /// 申请包周期弹性公网IP
        ///
        /// 申请包年包月的弹性公网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 申请弹性公网IP，支持IPv4和IPv6。
        ///  弹性公网IP（Elastic IP）提供独立的公网IP资源，包括公网IP地址与公网出口带宽服务。可以与弹性云服务器、裸金属服务器、虚拟IP、弹性负载均衡、NAT网关等资源灵活地绑定及解绑。拥有多种灵活的计费方式，可以满足各种业务场景的需要。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 给指定弹性IP资源实例增加标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 删除弹性公网IP,绑定状态eip不允许直接删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePublicipResponse DeletePublicip(DeletePublicipRequest deletePublicipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , deletePublicipRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips/{publicip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicipRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePublicipResponse>(response);
        }
        
        /// <summary>
        /// 删除弹性公网IP的标签
        ///
        /// 删除指定弹性公网IP的标签信息。其中project_id是项目ID，publicip_id 是要操作的弹性公网IP的id。key是要删除标签的键。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePublicipTagResponse DeletePublicipTag(DeletePublicipTagRequest deletePublicipTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , deletePublicipTagRequest.PublicipId.ToString());
            urlParam.Add("key" , deletePublicipTagRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicipTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePublicipTagResponse>(response);
        }
        
        /// <summary>
        /// 查询租户的弹性公网IP标签
        ///
        /// 查询租户在指定区域和实例类型的所有标签集合。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPublicipTagsResponse ListPublicipTags(ListPublicipTagsRequest listPublicipTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPublicipTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性公网IP列表
        ///
        /// 查询弹性公网IP列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPublicipsResponse ListPublicips(ListPublicipsRequest listPublicipsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPublicipsResponse>(response);
        }
        
        /// <summary>
        /// 按标签查询弹性公网IP列表
        ///
        /// 使用标签过滤弹性公网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 查询PublicIp类型
        ///
        /// 查询PublicIp类型
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPublicIpTypeResponse ShowPublicIpType(ShowPublicIpTypeRequest showPublicIpTypeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/publicip_types",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicIpTypeRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ShowPublicIpTypeResponse showPublicIpTypeResponse = JsonUtils.DeSerializeNull<ShowPublicIpTypeResponse>(response);
            return showPublicIpTypeResponse;
        }
        
        /// <summary>
        /// 查询弹性公网IP
        ///
        /// 查询指定的弹性公网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPublicipResponse ShowPublicip(ShowPublicipRequest showPublicipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , showPublicipRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips/{publicip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPublicipResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性公网IP的标签
        ///
        /// 查询指定弹性IP实例的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPublicipTagsResponse ShowPublicipTags(ShowPublicipTagsRequest showPublicipTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , showPublicipTagsRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPublicipTagsResponse>(response);
        }
        
        /// <summary>
        /// 更新弹性公网IP
        ///
        /// 更新弹性公网IP，将弹性公网IP跟一个网卡绑定或者解绑定，转换IP地址版本类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 查询Job状态接口
        ///
        /// 查询Job状态接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourcesJobDetailResponse ShowResourcesJobDetail(ShowResourcesJobDetailRequest showResourcesJobDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showResourcesJobDetailRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourcesJobDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowResourcesJobDetailResponse>(response);
        }
        
        /// <summary>
        /// 创建浮动IP
        ///
        /// 创建浮动IP的外部网络UUID，请使用GET /v2.0/networks?router:external&#x3D;True或neutron net-external-list方式获取。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        ///
        /// 删除指定的浮动IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronDeleteFloatingIpResponse NeutronDeleteFloatingIp(NeutronDeleteFloatingIpRequest neutronDeleteFloatingIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("floatingip_id" , neutronDeleteFloatingIpRequest.FloatingipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips/{floatingip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFloatingIpRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<NeutronDeleteFloatingIpResponse>(response);
        }
        
        /// <summary>
        /// 查询浮动IP列表
        ///
        /// 查询提交请求的租户有权限操作的所有浮动IP地址。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronListFloatingIpsResponse NeutronListFloatingIps(NeutronListFloatingIpsRequest neutronListFloatingIpsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFloatingIpsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<NeutronListFloatingIpsResponse>(response);
        }
        
        /// <summary>
        /// 查询浮动IP
        ///
        /// 查询浮动IP详情，包括浮动IP状态，浮动IP所属路由器ID，浮动IP的外部网络ID等等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronShowFloatingIpResponse NeutronShowFloatingIp(NeutronShowFloatingIpRequest neutronShowFloatingIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("floatingip_id" , neutronShowFloatingIpRequest.FloatingipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips/{floatingip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFloatingIpRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<NeutronShowFloatingIpResponse>(response);
        }
        
        /// <summary>
        /// 更新浮动IP
        ///
        /// 更新浮动IP。
        ///  更新时需在URL中给出浮动IP地址的ID。
        ///  port_id 为空，则表示浮动IP从端口解绑。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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