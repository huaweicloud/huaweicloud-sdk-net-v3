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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addPublicipsIntoSharedBandwidthRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}/insert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addPublicipsIntoSharedBandwidthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddPublicipsIntoSharedBandwidthResponse>(response);
        }

        public SyncInvoker<AddPublicipsIntoSharedBandwidthResponse> AddPublicipsIntoSharedBandwidthInvoker(AddPublicipsIntoSharedBandwidthRequest addPublicipsIntoSharedBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addPublicipsIntoSharedBandwidthRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}/insert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addPublicipsIntoSharedBandwidthRequest);
            return new SyncInvoker<AddPublicipsIntoSharedBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<AddPublicipsIntoSharedBandwidthResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/batch-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateSharedBandwidthsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateSharedBandwidthsResponse>(response);
        }

        public SyncInvoker<BatchCreateSharedBandwidthsResponse> BatchCreateSharedBandwidthsInvoker(BatchCreateSharedBandwidthsRequest batchCreateSharedBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/batch-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateSharedBandwidthsRequest);
            return new SyncInvoker<BatchCreateSharedBandwidthsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateSharedBandwidthsResponse>);
        }
        
        /// <summary>
        /// 批量更新带宽
        ///
        /// 批量更新带宽，共享带宽和包周期带宽该接口不适用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchModifyBandwidthResponse BatchModifyBandwidth(BatchModifyBandwidthRequest batchModifyBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batch-bandwidths/modify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchModifyBandwidthRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchModifyBandwidthResponse>(response);
        }

        public SyncInvoker<BatchModifyBandwidthResponse> BatchModifyBandwidthInvoker(BatchModifyBandwidthRequest batchModifyBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batch-bandwidths/modify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchModifyBandwidthRequest);
            return new SyncInvoker<BatchModifyBandwidthResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchModifyBandwidthResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/change-to-period", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeBandwidthToPeriodRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeBandwidthToPeriodResponse>(response);
        }

        public SyncInvoker<ChangeBandwidthToPeriodResponse> ChangeBandwidthToPeriodInvoker(ChangeBandwidthToPeriodRequest changeBandwidthToPeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/change-to-period", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeBandwidthToPeriodRequest);
            return new SyncInvoker<ChangeBandwidthToPeriodResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeBandwidthToPeriodResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSharedBandwidthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSharedBandwidthResponse>(response);
        }

        public SyncInvoker<CreateSharedBandwidthResponse> CreateSharedBandwidthInvoker(CreateSharedBandwidthRequest createSharedBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSharedBandwidthRequest);
            return new SyncInvoker<CreateSharedBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSharedBandwidthResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSharedBandwidthRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSharedBandwidthRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSharedBandwidthResponse>(response);
        }

        public SyncInvoker<DeleteSharedBandwidthResponse> DeleteSharedBandwidthInvoker(DeleteSharedBandwidthRequest deleteSharedBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSharedBandwidthRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSharedBandwidthRequest);
            return new SyncInvoker<DeleteSharedBandwidthResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSharedBandwidthResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidthpkgs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPkgRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBandwidthPkgResponse>(response);
        }

        public SyncInvoker<ListBandwidthPkgResponse> ListBandwidthPkgInvoker(ListBandwidthPkgRequest listBandwidthPkgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidthpkgs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPkgRequest);
            return new SyncInvoker<ListBandwidthPkgResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBandwidthPkgResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBandwidthsResponse>(response);
        }

        public SyncInvoker<ListBandwidthsResponse> ListBandwidthsInvoker(ListBandwidthsRequest listBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthsRequest);
            return new SyncInvoker<ListBandwidthsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBandwidthsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListQuotasResponse>(response);
        }

        public SyncInvoker<ListQuotasResponse> ListQuotasInvoker(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            return new SyncInvoker<ListQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQuotasResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removePublicipsFromSharedBandwidthRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}/remove", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", removePublicipsFromSharedBandwidthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RemovePublicipsFromSharedBandwidthResponse>(response);
        }

        public SyncInvoker<RemovePublicipsFromSharedBandwidthResponse> RemovePublicipsFromSharedBandwidthInvoker(RemovePublicipsFromSharedBandwidthRequest removePublicipsFromSharedBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removePublicipsFromSharedBandwidthRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}/remove", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", removePublicipsFromSharedBandwidthRequest);
            return new SyncInvoker<RemovePublicipsFromSharedBandwidthResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RemovePublicipsFromSharedBandwidthResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBandwidthRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bandwidths/{bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBandwidthRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBandwidthResponse>(response);
        }

        public SyncInvoker<ShowBandwidthResponse> ShowBandwidthInvoker(ShowBandwidthRequest showBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBandwidthRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bandwidths/{bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBandwidthRequest);
            return new SyncInvoker<ShowBandwidthResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBandwidthResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateBandwidthRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bandwidths/{bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBandwidthRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateBandwidthResponse>(response);
        }

        public SyncInvoker<UpdateBandwidthResponse> UpdateBandwidthInvoker(UpdateBandwidthRequest updateBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateBandwidthRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bandwidths/{bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBandwidthRequest);
            return new SyncInvoker<UpdateBandwidthResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateBandwidthResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePrePaidBandwidthRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePrePaidBandwidthRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePrePaidBandwidthResponse>(response);
        }

        public SyncInvoker<UpdatePrePaidBandwidthResponse> UpdatePrePaidBandwidthInvoker(UpdatePrePaidBandwidthRequest updatePrePaidBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePrePaidBandwidthRequest.BandwidthId, out var valueOfBandwidthId)) urlParam.Add("bandwidth_id", valueOfBandwidthId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePrePaidBandwidthRequest);
            return new SyncInvoker<UpdatePrePaidBandwidthResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePrePaidBandwidthResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreatePublicipTagsRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreatePublicipTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreatePublicipTagsResponse>(response);
        }

        public SyncInvoker<BatchCreatePublicipTagsResponse> BatchCreatePublicipTagsInvoker(BatchCreatePublicipTagsRequest batchCreatePublicipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreatePublicipTagsRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreatePublicipTagsRequest);
            return new SyncInvoker<BatchCreatePublicipTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreatePublicipTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batchpublicips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreatePublicipsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreatePublicipsResponse>(response);
        }

        public SyncInvoker<BatchCreatePublicipsResponse> BatchCreatePublicipsInvoker(BatchCreatePublicipsRequest batchCreatePublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batchpublicips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreatePublicipsRequest);
            return new SyncInvoker<BatchCreatePublicipsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreatePublicipsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batchpublicips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeletePublicIpRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeletePublicIpResponse>(response);
        }

        public SyncInvoker<BatchDeletePublicIpResponse> BatchDeletePublicIpInvoker(BatchDeletePublicIpRequest batchDeletePublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batchpublicips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeletePublicIpRequest);
            return new SyncInvoker<BatchDeletePublicIpResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeletePublicIpResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeletePublicipTagsRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeletePublicipTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeletePublicipTagsResponse>(response);
        }

        public SyncInvoker<BatchDeletePublicipTagsResponse> BatchDeletePublicipTagsInvoker(BatchDeletePublicipTagsRequest batchDeletePublicipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeletePublicipTagsRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeletePublicipTagsRequest);
            return new SyncInvoker<BatchDeletePublicipTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeletePublicipTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batchpublicips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDisassociatePublicipsRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<BatchDisassociatePublicipsResponse>(response);
        }

        public SyncInvoker<BatchDisassociatePublicipsResponse> BatchDisassociatePublicipsInvoker(BatchDisassociatePublicipsRequest batchDisassociatePublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batchpublicips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDisassociatePublicipsRequest);
            return new SyncInvoker<BatchDisassociatePublicipsResponse>(this, "PATCH", request, JsonUtils.DeSerialize<BatchDisassociatePublicipsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/change-to-period", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changePublicipToPeriodRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangePublicipToPeriodResponse>(response);
        }

        public SyncInvoker<ChangePublicipToPeriodResponse> ChangePublicipToPeriodInvoker(ChangePublicipToPeriodRequest changePublicipToPeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/change-to-period", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changePublicipToPeriodRequest);
            return new SyncInvoker<ChangePublicipToPeriodResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangePublicipToPeriodResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elasticips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countPublicIpRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CountPublicIpResponse>(response);
        }

        public SyncInvoker<CountPublicIpResponse> CountPublicIpInvoker(CountPublicIpRequest countPublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elasticips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countPublicIpRequest);
            return new SyncInvoker<CountPublicIpResponse>(this, "GET", request, JsonUtils.DeSerialize<CountPublicIpResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/publicip/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countPublicIpInstanceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerializeNull<CountPublicIpInstanceResponse>(response);
        }

        public SyncInvoker<CountPublicIpInstanceResponse> CountPublicIpInstanceInvoker(CountPublicIpInstanceRequest countPublicIpInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/publicip/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countPublicIpInstanceRequest);
            return new SyncInvoker<CountPublicIpInstanceResponse>(this, "GET", request, JsonUtils.DeSerializeNull<CountPublicIpInstanceResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPrePaidPublicipRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePrePaidPublicipResponse>(response);
        }

        public SyncInvoker<CreatePrePaidPublicipResponse> CreatePrePaidPublicipInvoker(CreatePrePaidPublicipRequest createPrePaidPublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPrePaidPublicipRequest);
            return new SyncInvoker<CreatePrePaidPublicipResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePrePaidPublicipResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPublicipRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePublicipResponse>(response);
        }

        public SyncInvoker<CreatePublicipResponse> CreatePublicipInvoker(CreatePublicipRequest createPublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPublicipRequest);
            return new SyncInvoker<CreatePublicipResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePublicipResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPublicipTagRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPublicipTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreatePublicipTagResponse>(response);
        }

        public SyncInvoker<CreatePublicipTagResponse> CreatePublicipTagInvoker(CreatePublicipTagRequest createPublicipTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPublicipTagRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPublicipTagRequest);
            return new SyncInvoker<CreatePublicipTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreatePublicipTagResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePublicipRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips/{publicip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicipRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePublicipResponse>(response);
        }

        public SyncInvoker<DeletePublicipResponse> DeletePublicipInvoker(DeletePublicipRequest deletePublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePublicipRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips/{publicip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicipRequest);
            return new SyncInvoker<DeletePublicipResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePublicipResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePublicipTagRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            if (StringUtils.TryConvertToNonEmptyString(deletePublicipTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicipTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePublicipTagResponse>(response);
        }

        public SyncInvoker<DeletePublicipTagResponse> DeletePublicipTagInvoker(DeletePublicipTagRequest deletePublicipTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePublicipTagRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            if (StringUtils.TryConvertToNonEmptyString(deletePublicipTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicipTagRequest);
            return new SyncInvoker<DeletePublicipTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePublicipTagResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPublicipTagsResponse>(response);
        }

        public SyncInvoker<ListPublicipTagsResponse> ListPublicipTagsInvoker(ListPublicipTagsRequest listPublicipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipTagsRequest);
            return new SyncInvoker<ListPublicipTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublicipTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPublicipsResponse>(response);
        }

        public SyncInvoker<ListPublicipsResponse> ListPublicipsInvoker(ListPublicipsRequest listPublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipsRequest);
            return new SyncInvoker<ListPublicipsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublicipsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPublicipsByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListPublicipsByTagsResponse>(response);
        }

        public SyncInvoker<ListPublicipsByTagsResponse> ListPublicipsByTagsInvoker(ListPublicipsByTagsRequest listPublicipsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPublicipsByTagsRequest);
            return new SyncInvoker<ListPublicipsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListPublicipsByTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/publicip_types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicIpTypeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerializeNull<ShowPublicIpTypeResponse>(response);
        }

        public SyncInvoker<ShowPublicIpTypeResponse> ShowPublicIpTypeInvoker(ShowPublicIpTypeRequest showPublicIpTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/publicip_types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicIpTypeRequest);
            return new SyncInvoker<ShowPublicIpTypeResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ShowPublicIpTypeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublicipRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips/{publicip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPublicipResponse>(response);
        }

        public SyncInvoker<ShowPublicipResponse> ShowPublicipInvoker(ShowPublicipRequest showPublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublicipRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips/{publicip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipRequest);
            return new SyncInvoker<ShowPublicipResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPublicipResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublicipTagsRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPublicipTagsResponse>(response);
        }

        public SyncInvoker<ShowPublicipTagsResponse> ShowPublicipTagsInvoker(ShowPublicipTagsRequest showPublicipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublicipTagsRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipTagsRequest);
            return new SyncInvoker<ShowPublicipTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPublicipTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePublicipRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips/{publicip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePublicipRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePublicipResponse>(response);
        }

        public SyncInvoker<UpdatePublicipResponse> UpdatePublicipInvoker(UpdatePublicipRequest updatePublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePublicipRequest.PublicipId, out var valueOfPublicipId)) urlParam.Add("publicip_id", valueOfPublicipId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips/{publicip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePublicipRequest);
            return new SyncInvoker<UpdatePublicipResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePublicipResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourcesJobDetailRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourcesJobDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResourcesJobDetailResponse>(response);
        }

        public SyncInvoker<ShowResourcesJobDetailResponse> ShowResourcesJobDetailInvoker(ShowResourcesJobDetailRequest showResourcesJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourcesJobDetailRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourcesJobDetailRequest);
            return new SyncInvoker<ShowResourcesJobDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourcesJobDetailResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFloatingIpRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<NeutronCreateFloatingIpResponse>(response);
        }

        public SyncInvoker<NeutronCreateFloatingIpResponse> NeutronCreateFloatingIpInvoker(NeutronCreateFloatingIpRequest neutronCreateFloatingIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFloatingIpRequest);
            return new SyncInvoker<NeutronCreateFloatingIpResponse>(this, "POST", request, JsonUtils.DeSerialize<NeutronCreateFloatingIpResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronDeleteFloatingIpRequest.FloatingipId, out var valueOfFloatingipId)) urlParam.Add("floatingip_id", valueOfFloatingipId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips/{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFloatingIpRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<NeutronDeleteFloatingIpResponse>(response);
        }

        public SyncInvoker<NeutronDeleteFloatingIpResponse> NeutronDeleteFloatingIpInvoker(NeutronDeleteFloatingIpRequest neutronDeleteFloatingIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronDeleteFloatingIpRequest.FloatingipId, out var valueOfFloatingipId)) urlParam.Add("floatingip_id", valueOfFloatingipId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips/{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFloatingIpRequest);
            return new SyncInvoker<NeutronDeleteFloatingIpResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NeutronDeleteFloatingIpResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFloatingIpsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NeutronListFloatingIpsResponse>(response);
        }

        public SyncInvoker<NeutronListFloatingIpsResponse> NeutronListFloatingIpsInvoker(NeutronListFloatingIpsRequest neutronListFloatingIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFloatingIpsRequest);
            return new SyncInvoker<NeutronListFloatingIpsResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronListFloatingIpsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronShowFloatingIpRequest.FloatingipId, out var valueOfFloatingipId)) urlParam.Add("floatingip_id", valueOfFloatingipId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips/{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFloatingIpRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NeutronShowFloatingIpResponse>(response);
        }

        public SyncInvoker<NeutronShowFloatingIpResponse> NeutronShowFloatingIpInvoker(NeutronShowFloatingIpRequest neutronShowFloatingIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronShowFloatingIpRequest.FloatingipId, out var valueOfFloatingipId)) urlParam.Add("floatingip_id", valueOfFloatingipId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips/{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFloatingIpRequest);
            return new SyncInvoker<NeutronShowFloatingIpResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronShowFloatingIpResponse>);
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
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronUpdateFloatingIpRequest.FloatingipId, out var valueOfFloatingipId)) urlParam.Add("floatingip_id", valueOfFloatingipId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips/{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFloatingIpRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<NeutronUpdateFloatingIpResponse>(response);
        }

        public SyncInvoker<NeutronUpdateFloatingIpResponse> NeutronUpdateFloatingIpInvoker(NeutronUpdateFloatingIpRequest neutronUpdateFloatingIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronUpdateFloatingIpRequest.FloatingipId, out var valueOfFloatingipId)) urlParam.Add("floatingip_id", valueOfFloatingipId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips/{floatingip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFloatingIpRequest);
            return new SyncInvoker<NeutronUpdateFloatingIpResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronUpdateFloatingIpResponse>);
        }
        
    }
}