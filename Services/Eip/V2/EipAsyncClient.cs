using System;
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
        ///
        /// 共享带宽插入弹性公网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddPublicipsIntoSharedBandwidthResponse> AddPublicipsIntoSharedBandwidthAsync(AddPublicipsIntoSharedBandwidthRequest addPublicipsIntoSharedBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", addPublicipsIntoSharedBandwidthRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}/insert",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addPublicipsIntoSharedBandwidthRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddPublicipsIntoSharedBandwidthResponse>(response);
        }

        public AsyncInvoker<AddPublicipsIntoSharedBandwidthResponse> AddPublicipsIntoSharedBandwidthAsyncInvoker(AddPublicipsIntoSharedBandwidthRequest addPublicipsIntoSharedBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", addPublicipsIntoSharedBandwidthRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}/insert",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addPublicipsIntoSharedBandwidthRequest);
            return new AsyncInvoker<AddPublicipsIntoSharedBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<AddPublicipsIntoSharedBandwidthResponse>);
        }
        
        /// <summary>
        /// 批量创建共享带宽
        ///
        /// 批量创建共享带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateSharedBandwidthsResponse> BatchCreateSharedBandwidthsAsync(BatchCreateSharedBandwidthsRequest batchCreateSharedBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/batch-bandwidths",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateSharedBandwidthsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchCreateSharedBandwidthsResponse>(response);
        }

        public AsyncInvoker<BatchCreateSharedBandwidthsResponse> BatchCreateSharedBandwidthsAsyncInvoker(BatchCreateSharedBandwidthsRequest batchCreateSharedBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/batch-bandwidths",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateSharedBandwidthsRequest);
            return new AsyncInvoker<BatchCreateSharedBandwidthsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateSharedBandwidthsResponse>);
        }
        
        /// <summary>
        /// 批量更新带宽
        ///
        /// 批量更新带宽，共享带宽和包周期带宽该接口不适用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchModifyBandwidthResponse> BatchModifyBandwidthAsync(BatchModifyBandwidthRequest batchModifyBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batch-bandwidths/modify",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchModifyBandwidthRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchModifyBandwidthResponse>(response);
        }

        public AsyncInvoker<BatchModifyBandwidthResponse> BatchModifyBandwidthAsyncInvoker(BatchModifyBandwidthRequest batchModifyBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batch-bandwidths/modify",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchModifyBandwidthRequest);
            return new AsyncInvoker<BatchModifyBandwidthResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchModifyBandwidthResponse>);
        }
        
        /// <summary>
        /// 按需转包API
        ///
        /// 租户按需转包接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeBandwidthToPeriodResponse> ChangeBandwidthToPeriodAsync(ChangeBandwidthToPeriodRequest changeBandwidthToPeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/change-to-period",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeBandwidthToPeriodRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ChangeBandwidthToPeriodResponse>(response);
        }

        public AsyncInvoker<ChangeBandwidthToPeriodResponse> ChangeBandwidthToPeriodAsyncInvoker(ChangeBandwidthToPeriodRequest changeBandwidthToPeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/change-to-period",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeBandwidthToPeriodRequest);
            return new AsyncInvoker<ChangeBandwidthToPeriodResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeBandwidthToPeriodResponse>);
        }
        
        /// <summary>
        /// 创建共享带宽
        ///
        /// 创建共享带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSharedBandwidthResponse> CreateSharedBandwidthAsync(CreateSharedBandwidthRequest createSharedBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSharedBandwidthRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSharedBandwidthResponse>(response);
        }

        public AsyncInvoker<CreateSharedBandwidthResponse> CreateSharedBandwidthAsyncInvoker(CreateSharedBandwidthRequest createSharedBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSharedBandwidthRequest);
            return new AsyncInvoker<CreateSharedBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSharedBandwidthResponse>);
        }
        
        /// <summary>
        /// 删除共享带宽
        ///
        /// 删除共享带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSharedBandwidthResponse> DeleteSharedBandwidthAsync(DeleteSharedBandwidthRequest deleteSharedBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", deleteSharedBandwidthRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSharedBandwidthRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSharedBandwidthResponse>(response);
        }

        public AsyncInvoker<DeleteSharedBandwidthResponse> DeleteSharedBandwidthAsyncInvoker(DeleteSharedBandwidthRequest deleteSharedBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", deleteSharedBandwidthRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSharedBandwidthRequest);
            return new AsyncInvoker<DeleteSharedBandwidthResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSharedBandwidthResponse>);
        }
        
        /// <summary>
        /// 查询带宽加油包列表
        ///
        /// 查询带宽加油包列表信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBandwidthPkgResponse> ListBandwidthPkgAsync(ListBandwidthPkgRequest listBandwidthPkgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidthpkgs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPkgRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBandwidthPkgResponse>(response);
        }

        public AsyncInvoker<ListBandwidthPkgResponse> ListBandwidthPkgAsyncInvoker(ListBandwidthPkgRequest listBandwidthPkgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/bandwidthpkgs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPkgRequest);
            return new AsyncInvoker<ListBandwidthPkgResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBandwidthPkgResponse>);
        }
        
        /// <summary>
        /// 查询带宽列表
        ///
        /// 查询带宽列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBandwidthsResponse> ListBandwidthsAsync(ListBandwidthsRequest listBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bandwidths",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBandwidthsResponse>(response);
        }

        public AsyncInvoker<ListBandwidthsResponse> ListBandwidthsAsyncInvoker(ListBandwidthsRequest listBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bandwidths",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthsRequest);
            return new AsyncInvoker<ListBandwidthsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBandwidthsResponse>);
        }
        
        /// <summary>
        /// 查询配额接口
        ///
        /// 查询配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListQuotasResponse> ListQuotasAsync(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListQuotasResponse>(response);
        }

        public AsyncInvoker<ListQuotasResponse> ListQuotasAsyncInvoker(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            return new AsyncInvoker<ListQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQuotasResponse>);
        }
        
        /// <summary>
        /// 共享带宽移除弹性公网IP
        ///
        /// 共享带宽移除弹性公网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemovePublicipsFromSharedBandwidthResponse> RemovePublicipsFromSharedBandwidthAsync(RemovePublicipsFromSharedBandwidthRequest removePublicipsFromSharedBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", removePublicipsFromSharedBandwidthRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}/remove",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", removePublicipsFromSharedBandwidthRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<RemovePublicipsFromSharedBandwidthResponse>(response);
        }

        public AsyncInvoker<RemovePublicipsFromSharedBandwidthResponse> RemovePublicipsFromSharedBandwidthAsyncInvoker(RemovePublicipsFromSharedBandwidthRequest removePublicipsFromSharedBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", removePublicipsFromSharedBandwidthRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}/remove",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", removePublicipsFromSharedBandwidthRequest);
            return new AsyncInvoker<RemovePublicipsFromSharedBandwidthResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RemovePublicipsFromSharedBandwidthResponse>);
        }
        
        /// <summary>
        /// 查询带宽
        ///
        /// 查询带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBandwidthResponse> ShowBandwidthAsync(ShowBandwidthRequest showBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", showBandwidthRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bandwidths/{bandwidth_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBandwidthRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBandwidthResponse>(response);
        }

        public AsyncInvoker<ShowBandwidthResponse> ShowBandwidthAsyncInvoker(ShowBandwidthRequest showBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", showBandwidthRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bandwidths/{bandwidth_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBandwidthRequest);
            return new AsyncInvoker<ShowBandwidthResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBandwidthResponse>);
        }
        
        /// <summary>
        /// 更新带宽
        ///
        /// 更新带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateBandwidthResponse> UpdateBandwidthAsync(UpdateBandwidthRequest updateBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", updateBandwidthRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bandwidths/{bandwidth_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBandwidthRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateBandwidthResponse>(response);
        }

        public AsyncInvoker<UpdateBandwidthResponse> UpdateBandwidthAsyncInvoker(UpdateBandwidthRequest updateBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", updateBandwidthRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bandwidths/{bandwidth_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBandwidthRequest);
            return new AsyncInvoker<UpdateBandwidthResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateBandwidthResponse>);
        }
        
        /// <summary>
        /// 更新包周期带宽
        ///
        /// 更新带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePrePaidBandwidthResponse> UpdatePrePaidBandwidthAsync(UpdatePrePaidBandwidthRequest updatePrePaidBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", updatePrePaidBandwidthRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePrePaidBandwidthRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePrePaidBandwidthResponse>(response);
        }

        public AsyncInvoker<UpdatePrePaidBandwidthResponse> UpdatePrePaidBandwidthAsyncInvoker(UpdatePrePaidBandwidthRequest updatePrePaidBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("bandwidth_id", updatePrePaidBandwidthRequest.BandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/bandwidths/{bandwidth_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePrePaidBandwidthRequest);
            return new AsyncInvoker<UpdatePrePaidBandwidthResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePrePaidBandwidthResponse>);
        }
        
        /// <summary>
        /// 批量创建弹性公网IP资源标签
        ///
        /// 为指定的弹性公网IP资源实例批量添加标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreatePublicipTagsResponse> BatchCreatePublicipTagsAsync(BatchCreatePublicipTagsRequest batchCreatePublicipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id", batchCreatePublicipTagsRequest.PublicipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreatePublicipTagsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreatePublicipTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreatePublicipTagsResponse> BatchCreatePublicipTagsAsyncInvoker(BatchCreatePublicipTagsRequest batchCreatePublicipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id", batchCreatePublicipTagsRequest.PublicipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreatePublicipTagsRequest);
            return new AsyncInvoker<BatchCreatePublicipTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreatePublicipTagsResponse>);
        }
        
        /// <summary>
        /// 批量创建弹性公网IP
        ///
        /// 批量创建弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreatePublicipsResponse> BatchCreatePublicipsAsync(BatchCreatePublicipsRequest batchCreatePublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batchpublicips",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreatePublicipsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchCreatePublicipsResponse>(response);
        }

        public AsyncInvoker<BatchCreatePublicipsResponse> BatchCreatePublicipsAsyncInvoker(BatchCreatePublicipsRequest batchCreatePublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batchpublicips",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreatePublicipsRequest);
            return new AsyncInvoker<BatchCreatePublicipsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreatePublicipsResponse>);
        }
        
        /// <summary>
        /// 批量删除弹性公网IP
        ///
        /// 批量删除弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeletePublicIpResponse> BatchDeletePublicIpAsync(BatchDeletePublicIpRequest batchDeletePublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batchpublicips",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeletePublicIpRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeletePublicIpResponse>(response);
        }

        public AsyncInvoker<BatchDeletePublicIpResponse> BatchDeletePublicIpAsyncInvoker(BatchDeletePublicIpRequest batchDeletePublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batchpublicips",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeletePublicIpRequest);
            return new AsyncInvoker<BatchDeletePublicIpResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeletePublicIpResponse>);
        }
        
        /// <summary>
        /// 批量删除弹性公网IP资源标签
        ///
        /// 为指定的弹性公网IP资源实例批量删除标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeletePublicipTagsResponse> BatchDeletePublicipTagsAsync(BatchDeletePublicipTagsRequest batchDeletePublicipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id", batchDeletePublicipTagsRequest.PublicipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeletePublicipTagsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeletePublicipTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeletePublicipTagsResponse> BatchDeletePublicipTagsAsyncInvoker(BatchDeletePublicipTagsRequest batchDeletePublicipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id", batchDeletePublicipTagsRequest.PublicipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeletePublicipTagsRequest);
            return new AsyncInvoker<BatchDeletePublicipTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeletePublicipTagsResponse>);
        }
        
        /// <summary>
        /// 批量解绑弹性公网IP
        ///
        /// 批量解绑弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDisassociatePublicipsResponse> BatchDisassociatePublicipsAsync(BatchDisassociatePublicipsRequest batchDisassociatePublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batchpublicips",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDisassociatePublicipsRequest);
            var response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<BatchDisassociatePublicipsResponse>(response);
        }

        public AsyncInvoker<BatchDisassociatePublicipsResponse> BatchDisassociatePublicipsAsyncInvoker(BatchDisassociatePublicipsRequest batchDisassociatePublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/batchpublicips",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDisassociatePublicipsRequest);
            return new AsyncInvoker<BatchDisassociatePublicipsResponse>(this, "PATCH", request, JsonUtils.DeSerialize<BatchDisassociatePublicipsResponse>);
        }
        
        /// <summary>
        /// 按需转包接口
        ///
        /// 租户按需转包接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangePublicipToPeriodResponse> ChangePublicipToPeriodAsync(ChangePublicipToPeriodRequest changePublicipToPeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/change-to-period",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changePublicipToPeriodRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ChangePublicipToPeriodResponse>(response);
        }

        public AsyncInvoker<ChangePublicipToPeriodResponse> ChangePublicipToPeriodAsyncInvoker(ChangePublicipToPeriodRequest changePublicipToPeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/change-to-period",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changePublicipToPeriodRequest);
            return new AsyncInvoker<ChangePublicipToPeriodResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangePublicipToPeriodResponse>);
        }
        
        /// <summary>
        /// 查询PublicIp数量
        ///
        /// 查询PublicIp数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountPublicIpResponse> CountPublicIpAsync(CountPublicIpRequest countPublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elasticips",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countPublicIpRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<CountPublicIpResponse>(response);
        }

        public AsyncInvoker<CountPublicIpResponse> CountPublicIpAsyncInvoker(CountPublicIpRequest countPublicIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/elasticips",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countPublicIpRequest);
            return new AsyncInvoker<CountPublicIpResponse>(this, "GET", request, JsonUtils.DeSerialize<CountPublicIpResponse>);
        }
        
        /// <summary>
        /// 查询PublicIp实例数
        ///
        /// 查询PublicIp实例数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountPublicIpInstanceResponse> CountPublicIpInstanceAsync(CountPublicIpInstanceRequest countPublicIpInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/publicip/instances",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countPublicIpInstanceRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerializeNull<CountPublicIpInstanceResponse>(response);
        }

        public AsyncInvoker<CountPublicIpInstanceResponse> CountPublicIpInstanceAsyncInvoker(CountPublicIpInstanceRequest countPublicIpInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/publicip/instances",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countPublicIpInstanceRequest);
            return new AsyncInvoker<CountPublicIpInstanceResponse>(this, "GET", request, JsonUtils.DeSerializeNull<CountPublicIpInstanceResponse>);
        }
        
        /// <summary>
        /// 申请包周期弹性公网IP
        ///
        /// 申请包年包月的弹性公网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePrePaidPublicipResponse> CreatePrePaidPublicipAsync(CreatePrePaidPublicipRequest createPrePaidPublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPrePaidPublicipRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePrePaidPublicipResponse>(response);
        }

        public AsyncInvoker<CreatePrePaidPublicipResponse> CreatePrePaidPublicipAsyncInvoker(CreatePrePaidPublicipRequest createPrePaidPublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPrePaidPublicipRequest);
            return new AsyncInvoker<CreatePrePaidPublicipResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePrePaidPublicipResponse>);
        }
        
        /// <summary>
        /// 申请弹性公网IP
        ///
        /// 申请弹性公网IP，支持IPv4和IPv6。
        ///  弹性公网IP（Elastic IP）提供独立的公网IP资源，包括公网IP地址与公网出口带宽服务。可以与弹性云服务器、裸金属服务器、虚拟IP、弹性负载均衡、NAT网关等资源灵活地绑定及解绑。拥有多种灵活的计费方式，可以满足各种业务场景的需要。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePublicipResponse> CreatePublicipAsync(CreatePublicipRequest createPublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPublicipRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePublicipResponse>(response);
        }

        public AsyncInvoker<CreatePublicipResponse> CreatePublicipAsyncInvoker(CreatePublicipRequest createPublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPublicipRequest);
            return new AsyncInvoker<CreatePublicipResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePublicipResponse>);
        }
        
        /// <summary>
        /// 创建弹性公网IP资源标签
        ///
        /// 给指定弹性IP资源实例增加标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePublicipTagResponse> CreatePublicipTagAsync(CreatePublicipTagRequest createPublicipTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id", createPublicipTagRequest.PublicipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPublicipTagRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreatePublicipTagResponse>(response);
        }

        public AsyncInvoker<CreatePublicipTagResponse> CreatePublicipTagAsyncInvoker(CreatePublicipTagRequest createPublicipTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id", createPublicipTagRequest.PublicipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPublicipTagRequest);
            return new AsyncInvoker<CreatePublicipTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreatePublicipTagResponse>);
        }
        
        /// <summary>
        /// 删除弹性公网IP
        ///
        /// 删除弹性公网IP,绑定状态eip不允许直接删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePublicipResponse> DeletePublicipAsync(DeletePublicipRequest deletePublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id", deletePublicipRequest.PublicipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips/{publicip_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicipRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePublicipResponse>(response);
        }

        public AsyncInvoker<DeletePublicipResponse> DeletePublicipAsyncInvoker(DeletePublicipRequest deletePublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id", deletePublicipRequest.PublicipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips/{publicip_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicipRequest);
            return new AsyncInvoker<DeletePublicipResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePublicipResponse>);
        }
        
        /// <summary>
        /// 删除弹性公网IP的标签
        ///
        /// 删除指定弹性公网IP的标签信息。其中project_id是项目ID，publicip_id 是要操作的弹性公网IP的id。key是要删除标签的键。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePublicipTagResponse> DeletePublicipTagAsync(DeletePublicipTagRequest deletePublicipTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id", deletePublicipTagRequest.PublicipId.ToString());
            urlParam.Add("key", deletePublicipTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags/{key}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicipTagRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePublicipTagResponse>(response);
        }

        public AsyncInvoker<DeletePublicipTagResponse> DeletePublicipTagAsyncInvoker(DeletePublicipTagRequest deletePublicipTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id", deletePublicipTagRequest.PublicipId.ToString());
            urlParam.Add("key", deletePublicipTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags/{key}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicipTagRequest);
            return new AsyncInvoker<DeletePublicipTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePublicipTagResponse>);
        }
        
        /// <summary>
        /// 查询租户的弹性公网IP标签
        ///
        /// 查询租户在指定区域和实例类型的所有标签集合。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPublicipTagsResponse> ListPublicipTagsAsync(ListPublicipTagsRequest listPublicipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipTagsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPublicipTagsResponse>(response);
        }

        public AsyncInvoker<ListPublicipTagsResponse> ListPublicipTagsAsyncInvoker(ListPublicipTagsRequest listPublicipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipTagsRequest);
            return new AsyncInvoker<ListPublicipTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublicipTagsResponse>);
        }
        
        /// <summary>
        /// 查询弹性公网IP列表
        ///
        /// 查询弹性公网IP列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPublicipsResponse> ListPublicipsAsync(ListPublicipsRequest listPublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPublicipsResponse>(response);
        }

        public AsyncInvoker<ListPublicipsResponse> ListPublicipsAsyncInvoker(ListPublicipsRequest listPublicipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipsRequest);
            return new AsyncInvoker<ListPublicipsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublicipsResponse>);
        }
        
        /// <summary>
        /// 按标签查询弹性公网IP列表
        ///
        /// 使用标签过滤弹性公网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPublicipsByTagsResponse> ListPublicipsByTagsAsync(ListPublicipsByTagsRequest listPublicipsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/resource_instances/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPublicipsByTagsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListPublicipsByTagsResponse>(response);
        }

        public AsyncInvoker<ListPublicipsByTagsResponse> ListPublicipsByTagsAsyncInvoker(ListPublicipsByTagsRequest listPublicipsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/resource_instances/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPublicipsByTagsRequest);
            return new AsyncInvoker<ListPublicipsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListPublicipsByTagsResponse>);
        }
        
        /// <summary>
        /// 查询PublicIp类型
        ///
        /// 查询PublicIp类型
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPublicIpTypeResponse> ShowPublicIpTypeAsync(ShowPublicIpTypeRequest showPublicIpTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/publicip_types",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicIpTypeRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerializeNull<ShowPublicIpTypeResponse>(response);
        }

        public AsyncInvoker<ShowPublicIpTypeResponse> ShowPublicIpTypeAsyncInvoker(ShowPublicIpTypeRequest showPublicIpTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/publicip_types",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicIpTypeRequest);
            return new AsyncInvoker<ShowPublicIpTypeResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ShowPublicIpTypeResponse>);
        }
        
        /// <summary>
        /// 查询弹性公网IP
        ///
        /// 查询指定的弹性公网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPublicipResponse> ShowPublicipAsync(ShowPublicipRequest showPublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id", showPublicipRequest.PublicipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips/{publicip_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPublicipResponse>(response);
        }

        public AsyncInvoker<ShowPublicipResponse> ShowPublicipAsyncInvoker(ShowPublicipRequest showPublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id", showPublicipRequest.PublicipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips/{publicip_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipRequest);
            return new AsyncInvoker<ShowPublicipResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPublicipResponse>);
        }
        
        /// <summary>
        /// 查询弹性公网IP的标签
        ///
        /// 查询指定弹性IP实例的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPublicipTagsResponse> ShowPublicipTagsAsync(ShowPublicipTagsRequest showPublicipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id", showPublicipTagsRequest.PublicipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipTagsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPublicipTagsResponse>(response);
        }

        public AsyncInvoker<ShowPublicipTagsResponse> ShowPublicipTagsAsyncInvoker(ShowPublicipTagsRequest showPublicipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id", showPublicipTagsRequest.PublicipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/publicips/{publicip_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipTagsRequest);
            return new AsyncInvoker<ShowPublicipTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPublicipTagsResponse>);
        }
        
        /// <summary>
        /// 更新弹性公网IP
        ///
        /// 更新弹性公网IP，将弹性公网IP跟一个网卡绑定或者解绑定，转换IP地址版本类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePublicipResponse> UpdatePublicipAsync(UpdatePublicipRequest updatePublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id", updatePublicipRequest.PublicipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips/{publicip_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePublicipRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePublicipResponse>(response);
        }

        public AsyncInvoker<UpdatePublicipResponse> UpdatePublicipAsyncInvoker(UpdatePublicipRequest updatePublicipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id", updatePublicipRequest.PublicipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/publicips/{publicip_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePublicipRequest);
            return new AsyncInvoker<UpdatePublicipResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePublicipResponse>);
        }
        
        /// <summary>
        /// 查询Job状态接口
        ///
        /// 查询Job状态接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourcesJobDetailResponse> ShowResourcesJobDetailAsync(ShowResourcesJobDetailRequest showResourcesJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showResourcesJobDetailRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourcesJobDetailRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowResourcesJobDetailResponse>(response);
        }

        public AsyncInvoker<ShowResourcesJobDetailResponse> ShowResourcesJobDetailAsyncInvoker(ShowResourcesJobDetailRequest showResourcesJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showResourcesJobDetailRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourcesJobDetailRequest);
            return new AsyncInvoker<ShowResourcesJobDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourcesJobDetailResponse>);
        }
        
        /// <summary>
        /// 创建浮动IP
        ///
        /// 创建浮动IP的外部网络UUID，请使用GET /v2.0/networks?router:external&#x3D;True或neutron net-external-list方式获取。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronCreateFloatingIpResponse> NeutronCreateFloatingIpAsync(NeutronCreateFloatingIpRequest neutronCreateFloatingIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFloatingIpRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<NeutronCreateFloatingIpResponse>(response);
        }

        public AsyncInvoker<NeutronCreateFloatingIpResponse> NeutronCreateFloatingIpAsyncInvoker(NeutronCreateFloatingIpRequest neutronCreateFloatingIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFloatingIpRequest);
            return new AsyncInvoker<NeutronCreateFloatingIpResponse>(this, "POST", request, JsonUtils.DeSerialize<NeutronCreateFloatingIpResponse>);
        }
        
        /// <summary>
        /// 删除浮动IP
        ///
        /// 删除指定的浮动IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronDeleteFloatingIpResponse> NeutronDeleteFloatingIpAsync(NeutronDeleteFloatingIpRequest neutronDeleteFloatingIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("floatingip_id", neutronDeleteFloatingIpRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips/{floatingip_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFloatingIpRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<NeutronDeleteFloatingIpResponse>(response);
        }

        public AsyncInvoker<NeutronDeleteFloatingIpResponse> NeutronDeleteFloatingIpAsyncInvoker(NeutronDeleteFloatingIpRequest neutronDeleteFloatingIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("floatingip_id", neutronDeleteFloatingIpRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips/{floatingip_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFloatingIpRequest);
            return new AsyncInvoker<NeutronDeleteFloatingIpResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NeutronDeleteFloatingIpResponse>);
        }
        
        /// <summary>
        /// 查询浮动IP列表
        ///
        /// 查询提交请求的租户有权限操作的所有浮动IP地址。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronListFloatingIpsResponse> NeutronListFloatingIpsAsync(NeutronListFloatingIpsRequest neutronListFloatingIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFloatingIpsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NeutronListFloatingIpsResponse>(response);
        }

        public AsyncInvoker<NeutronListFloatingIpsResponse> NeutronListFloatingIpsAsyncInvoker(NeutronListFloatingIpsRequest neutronListFloatingIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFloatingIpsRequest);
            return new AsyncInvoker<NeutronListFloatingIpsResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronListFloatingIpsResponse>);
        }
        
        /// <summary>
        /// 查询浮动IP
        ///
        /// 查询浮动IP详情，包括浮动IP状态，浮动IP所属路由器ID，浮动IP的外部网络ID等等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronShowFloatingIpResponse> NeutronShowFloatingIpAsync(NeutronShowFloatingIpRequest neutronShowFloatingIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("floatingip_id", neutronShowFloatingIpRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips/{floatingip_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFloatingIpRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NeutronShowFloatingIpResponse>(response);
        }

        public AsyncInvoker<NeutronShowFloatingIpResponse> NeutronShowFloatingIpAsyncInvoker(NeutronShowFloatingIpRequest neutronShowFloatingIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("floatingip_id", neutronShowFloatingIpRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips/{floatingip_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFloatingIpRequest);
            return new AsyncInvoker<NeutronShowFloatingIpResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronShowFloatingIpResponse>);
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
        public async Task<NeutronUpdateFloatingIpResponse> NeutronUpdateFloatingIpAsync(NeutronUpdateFloatingIpRequest neutronUpdateFloatingIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("floatingip_id", neutronUpdateFloatingIpRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips/{floatingip_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFloatingIpRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<NeutronUpdateFloatingIpResponse>(response);
        }

        public AsyncInvoker<NeutronUpdateFloatingIpResponse> NeutronUpdateFloatingIpAsyncInvoker(NeutronUpdateFloatingIpRequest neutronUpdateFloatingIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("floatingip_id", neutronUpdateFloatingIpRequest.FloatingipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/floatingips/{floatingip_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFloatingIpRequest);
            return new AsyncInvoker<NeutronUpdateFloatingIpResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronUpdateFloatingIpResponse>);
        }
        
    }
}